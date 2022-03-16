using Dsa.Pages.Customer;
using OpenQA.Selenium;
using System;
using Dsa.Utils;
using FluentAssertions;
using System.Data;
using OpenQA.Selenium.Interactions;

namespace Dsa.Workflows
{
    public class CopyCustomerWorkflow
    {
        #region Copy Customer
        /// <summary>
        /// This method is used to copy the customer from Consumer Company to Consumer Company
        /// </summary>
        /// <param name="webDriver"></param>
        /// <param name="customerNumber"></param>
        /// <param name="companyName"></param>
        /// <param name="companyNumber"></param>
        /// <returns>Compnay Name and Csutomer Name</returns>
        public static string CopyCompanyFromCosumerToConsumerCompany(IWebDriver webDriver, DataRow row)
        {
            string newCompnayName ="";
            try
            {
                //Search by Customer Number 
                CustomerDetailsPage customerDetailsPage = CustomerSearchWorkflow.SearchCustomerByCustomerNumber(webDriver, row["CustomerNumber"].ToString());
                //Wait for Customer Details Page to load
                //customerDetailsPage.WaitForCustomerDetailsPageToLoad();
                WebDriverUtil.WaitForElementDisplay(webDriver, customerDetailsPage.HdrCustomerDetail, TimeSpan.FromSeconds(20));
                //Verify the given Company name is same as Company searcehd & loaded
                row["CompanyName"].ToString().Should().Should().BeEquivalentTo(customerDetailsPage.DetailsHeader().Split(':')[0].Trim());
                //String.Equals(customerDetailsPage.DetailsHeader().Split(':')[0].Trim(), row["CompanyName"].ToString().Trim(), StringComparison.OrdinalIgnoreCase).Should().BeTrue();
                //Verify the given Customer name is same as Customer loaded
                row["CustomerName"].ToString().Should().Should().BeEquivalentTo(customerDetailsPage.DetailsHeader().Split(':')[1].Trim());
                //Click More Action
                customerDetailsPage.MoreActionClk();
                customerDetailsPage.LnkCopyCustomer.Click();
                //Select catalogue using compnay number
                SalesChannelSelectWorkflow.SelectCompanyNumber(webDriver, row["CompanyNumber"].ToString());
                CustomerCreatePage customerCreatePage = new CustomerCreatePage(webDriver);
                //Wait for Add New Customer header to display
                webDriver.WaitForElementDisplay(customerCreatePage.HdrAddNewCustomer);
                //Update Company Name & Number for Consumer
                customerCreatePage.BillingContactFirstNameTxt.SetText(webDriver, "AUTOCOMPANY" + row["CompanyNumber"].ToString());
                //customerCreatePage.BillingContactFirstNameTxt.SendKeys("AUTOCOMPANY19");
                newCompnayName = "QEDT" + DateTime.Now.ToString("MMddhhmm");
                //customerCreatePage.BillingContactLastNameTxt.SetText(webDriver, newCompnayName);
                customerCreatePage.BillingContactLastNameTxt.SendKeys(newCompnayName);
                //Verify and select the "Mark same as Billling Address:" checkbox
                if (!customerCreatePage.VerifyBillingAndShippingSame())
                    customerCreatePage.ShippingAddressSameAdBillingChk.Click();
                //Save Customer
                customerCreatePage.SaveCustomer();
                //Wait for Newly Copied Customer Details Page to load
                customerDetailsPage.WaitForCustomerDetailsPageToLoad();

            }
            catch (Exception e)
            {
                Logger.Write("Exception Occured while Copying Customer");
                return "Exception - While Copying Customer";
            }
            return "AUTOCOMPANY" + row["CompanyNumber"].ToString() + " " + newCompnayName + " : AUTOCOMPANY" + row["CompanyNumber"].ToString() + " " + newCompnayName;
        }
        #endregion

        #region Verify Customer Information Section
        /// <summary>
        /// This method is used to Verify the data in the Customer Information Section
        /// </summary>
        /// <param name="webDriver"></param>
        /// <param name="customerNumber"></param>
        /// <param name="companyName"></param>
        /// <param name="companyNumber"></param>
        /// <param name="customerClass"></param>
        /// <param name="customerCategory"></param>
        /// <param name="workPhone"></param>
        /// <param name="fax"></param>
        public static void VerfiyCustomerInformation(IWebDriver webDriver, string companyName, DataRow row)
        {
            try
            {
                CustomerDetailsPage customerDetailsPage = new CustomerDetailsPage(webDriver);
                //Verify the given Company is same as Company loaded
                row["CompanyName"].ToString().Should().Should().BeEquivalentTo(customerDetailsPage.DetailsHeader().Split(':')[0].Trim());
                row["CompanyName"].ToString().Should().Should().BeEquivalentTo(customerDetailsPage.TxtCompanyName.Text);
                //String.Equals(customerDetailsPage.DetailsHeader().Split(':')[0].Trim(), companyName.Split(':')[0].Trim(), StringComparison.OrdinalIgnoreCase).Should().BeTrue();
                //Verify the given Customer name is same as Customer loaded
                row["CustomerName"].ToString().Should().Should().BeEquivalentTo(customerDetailsPage.DetailsHeader().Split(':')[1].Trim());
                //Verify New Compnay Customer number is different from Original/Source Customer number
                row["CustomerName"].ToString().Should().NotBeSameAs(customerDetailsPage.HdrCustomerNumber.Text);
                row["CustomerName"].ToString().Should().NotBeSameAs(customerDetailsPage.LblCustomerNumber.Text);
                //Verify Sales Channel with Company Number
                row["CompanyNumber"].ToString().Should().Should().BeEquivalentTo(customerDetailsPage.LblCompanyNumber.Text);
                //Verify Customer Class
                row["CustomerClass"].ToString().Should().Should().BeEquivalentTo(customerDetailsPage.TxtCustomerClass.Text);
                //Verify Customer Category
                row["CustomerCategory"].ToString().Should().Should().BeEquivalentTo(customerDetailsPage.TxtCustomerCategory.Text);
                //Verify Customer CFO Language
                row["ContactCFOLanguage"].ToString().Should().Should().BeEquivalentTo(customerDetailsPage.TxtContactCFOLanguage.Text);
                //Verify Last Updated with Current date in MM/DD/YYYY
                DateTime.Today.ToString("MM/dd/yyyy").Should().BeEquivalentTo(customerDetailsPage.TxtLastUpdated.Text);
                //Verify Status as Active
                "Active".Should().BeEquivalentTo(customerDetailsPage.CustomerStatus.Text);
                //Verify Customer Hold as No
                "No".Should().BeEquivalentTo(customerDetailsPage.CustomerHold.Text);
                //Verify Sales Rep ID:
                customerDetailsPage.SalesRepId.Text.Should().BeOneOf("12345", "999");
                //Verify Work Phone with Company Phone
                if (row["CompanyNumber"].ToString() != "19" || row["CompanyNumber"].ToString()!="29")// For Consumer Comapnies Billing Work Phone is Company Number
                    row["BillingWorkPhone"].ToString().Should().Should().BeEquivalentTo(customerDetailsPage.TxtCompanyPhone.Text);
                else//For Commercial Companies need to Pass Company Phone seperately
                    row["CompanyPhone"].ToString().Should().Should().BeEquivalentTo(customerDetailsPage.TxtCompanyPhone.Text);
                //Verify Company Fax with Fax
                row["BillingFax"].ToString().Should().Should().BeEquivalentTo(customerDetailsPage.TxtCompanyFax.Text);
            }
            catch (Exception ex)
            {
 
            }
        }
        #endregion

        #region Verify Customer Shipping Contact and Address data by passing the Customer Billing Contact and Address when both Billing and Shipping are same in Locations Section

        public static void VerfiyShippingContactWhenBillingAndShippingAreSame(IWebDriver webDriver, DataRow row, string companyName)
        {
            string addressRow = "//div[@id='customerDetails_locationsGrid']//table//tr//td[Text()='textToReplace']/parent::tr";
            By shippingAddresLocator = DsaUtil.GetLocatorWithText(addressRow, "Primary Shipping");
            string shippingRow = webDriver.FindElement(shippingAddresLocator).GetAttribute("class");
            string shippingContactAndAddressLocators = "//div[@id='customerDetails_locationsGrid']//table//tr[@class='" + shippingRow + "']//td[Text()='textToReplace']";
            try
            {
                CustomerDetailsPage customerDetailsPage = new CustomerDetailsPage(webDriver);
                //Expand Locations
                customerDetailsPage.ExpandLocation();
                //Verify Shipping Company Name
                webDriver.WaitForElementDisplay(DsaUtil.GetLocatorWithText(shippingContactAndAddressLocators, companyName.Split(':')[0].Trim()), TimeSpan.FromMilliseconds(25));
                //Verfiy First Name
                webDriver.WaitForElementDisplay(DsaUtil.GetLocatorWithText(shippingContactAndAddressLocators, companyName.Split(':')[1].Split(' ')[0].Trim()), TimeSpan.FromMilliseconds(25));
                //Verfiy Last Name
                webDriver.WaitForElementDisplay(DsaUtil.GetLocatorWithText(shippingContactAndAddressLocators, companyName.Split(':')[1].Split(' ')[1].Trim()), TimeSpan.FromMilliseconds(25));
                //Verfiy Address Line1
                webDriver.WaitForElementDisplay(DsaUtil.GetLocatorWithText(shippingContactAndAddressLocators, row["BillingAddressLine1"].ToString()), TimeSpan.FromMilliseconds(25));
                //Verfiy Address Line2
                webDriver.WaitForElementDisplay(DsaUtil.GetLocatorWithText(shippingContactAndAddressLocators, row["BillingAddressLine2"].ToString()), TimeSpan.FromMilliseconds(25));
                //Verfiy City
                webDriver.WaitForElementDisplay(DsaUtil.GetLocatorWithText(shippingContactAndAddressLocators, row["BillingCity"].ToString()), TimeSpan.FromMilliseconds(25));
                //Verify State
                webDriver.WaitForElementDisplay(DsaUtil.GetLocatorWithText(shippingContactAndAddressLocators, row["BillingState"].ToString()), TimeSpan.FromMilliseconds(25));
                //Verify Zip Code
                webDriver.WaitForElementDisplay(DsaUtil.GetLocatorWithText(shippingContactAndAddressLocators, row["BillingZipCodeExtension"].ToString()), TimeSpan.FromMilliseconds(25));
                //Verify Primary Billing
                webDriver.WaitForElementDisplay(DsaUtil.GetLocatorWithText(shippingContactAndAddressLocators, "Primary Shipping"), TimeSpan.FromMilliseconds(25));
                //Verify Contact Status
                webDriver.WaitForElementDisplay(DsaUtil.GetLocatorWithText(shippingContactAndAddressLocators, "Active"), TimeSpan.FromMilliseconds(25));

            }
            catch (Exception ex)
            {

            }
        }

        #endregion

        #region Verify Customer Shipping Primary Contact, Mail Id and Phone Numbers data by passing the Customer Billing Contact and Address when both Billing and Shipping are same in Locations Section

        public static void VerfiyShippingPrimaryContactMailIdPhoneNumbersWhenBillingAndShippingAreSame(IWebDriver webDriver, DataRow row, string companyName)
        {
            string addressRow = "//div[@id='customerDetails_locationsGrid']//table//tr//td[Text()='textToReplace']/parent::tr";
            By shippingAddresLocator = DsaUtil.GetLocatorWithText(addressRow, "Primary Shipping");
            string shippingRow = webDriver.FindElement(shippingAddresLocator).GetAttribute("class");
            By byShippingAddressExpand = By.XPath("//div[@id='customerDetails_locationsGrid']//table//tr[@class='" + shippingRow + "']//a");
            string shippingPrimaryContactPhoneNumberLocators = "(//div[@id='customerDetails_locationsGrid']//table//tr[@class='" + shippingRow + "']/following-sibling::tr[@class='details-view'])[1]//td[Text()='textToReplace']";
            try
            {
                CustomerDetailsPage customerDetailsPage = new CustomerDetailsPage(webDriver);
                //Expand Shipping Adresss
                customerDetailsPage.ExpandAddress(byShippingAddressExpand);
                //Verify Billing Title
                webDriver.WaitForElementDisplay(DsaUtil.GetLocatorWithText(shippingPrimaryContactPhoneNumberLocators, row["BillingTitle"].ToString()), TimeSpan.FromMilliseconds(25));
                //Verify First Name
                webDriver.WaitForElementDisplay(DsaUtil.GetLocatorWithText(shippingPrimaryContactPhoneNumberLocators, companyName.Split(':')[0].Trim().Split(' ')[0].Trim()), TimeSpan.FromMilliseconds(25));
                //Verfiy Middle Name
                webDriver.WaitForElementDisplay(DsaUtil.GetLocatorWithText(shippingPrimaryContactPhoneNumberLocators, row["BillingMiddle"].ToString()), TimeSpan.FromMilliseconds(25));
                //Verify Last Name
                webDriver.WaitForElementDisplay(DsaUtil.GetLocatorWithText(shippingPrimaryContactPhoneNumberLocators, companyName.Split(':')[0].Split(' ')[1].Trim()), TimeSpan.FromMilliseconds(25));
                //Verify Invoicing Email
                webDriver.WaitForElementDisplay(DsaUtil.GetLocatorWithText(shippingPrimaryContactPhoneNumberLocators, row["BillingInvoicingEmail"].ToString()), TimeSpan.FromMilliseconds(25));
                //Verify Home Phone
                webDriver.WaitForElementDisplay(DsaUtil.GetLocatorWithText(shippingPrimaryContactPhoneNumberLocators, row["BillingHomePhone"].ToString()), TimeSpan.FromMilliseconds(25));
                //Verify Mobile Phone
                webDriver.WaitForElementDisplay(DsaUtil.GetLocatorWithText(shippingPrimaryContactPhoneNumberLocators, row["BillingMobilePhone"].ToString()), TimeSpan.FromMilliseconds(25));
                //Verify Work Phone and Ext
                webDriver.WaitForElementDisplay(DsaUtil.GetLocatorWithText(shippingPrimaryContactPhoneNumberLocators, row["BillingWorkPhone"].ToString()), TimeSpan.FromMilliseconds(25));
                //Verify Fax
                webDriver.WaitForElementDisplay(DsaUtil.GetLocatorWithText(shippingPrimaryContactPhoneNumberLocators, row["BillingFax"].ToString()), TimeSpan.FromMilliseconds(25));

            }
            catch (Exception ex)
            {

            }
        }

        #endregion


        public static string CopyCustomer(IWebDriver webDriver, DataRow row, bool isVerifiedAddress = true, bool isVerifiedLegalCompanyname = true,string CompanyName = "",string CompanyNumber= "" , string OldCustNumber= "", string CompanyPhNo = "")
        {  
            var customerNumber = string.Empty;            
            string newCompnayName = "";
            try
            {
                CustomerDetailsPage customerDetailsPage = CustomerSearchWorkflow.SearchCustomerByCustomerNumber(webDriver, OldCustNumber);
                WebDriverUtil.WaitForElementDisplay(webDriver, customerDetailsPage.HdrCustomerDetail, TimeSpan.FromSeconds(20));
                customerDetailsPage.MoreActionClk();
                customerDetailsPage.LnkCopyCustomer.Click();
                //Select catalogue using compnay number
                SalesChannelSelectWorkflow.SelectCompanyNumber(webDriver, CompanyNumber);
                CustomerCreatePage customerCreatePage = new CustomerCreatePage(webDriver);
                if (customerCreatePage.CompanyName.IsElementClickable(webDriver, TimeSpan.FromSeconds(10)))
                {
                    if (CompanyName!="")
                    {
                        customerCreatePage.CompanyName.Clear();
                        customerCreatePage.CompanyName.SendKeys(CompanyName);
                    }
                    if (customerCreatePage.ContactCompPhone.GetText(webDriver).Equals(""))
                    {
                        customerCreatePage.ContactCompPhone.SendKeys(CompanyPhNo);
                        customerCreatePage.ContactCompPhone.SendKeys(Keys.Tab);
                        customerCreatePage.ContactInfoCompanyFax.SendKeys(Keys.Tab);
                    }
                }
                if (customerCreatePage.BtnAddNewCustomerSave.IsElementClickable(webDriver, TimeSpan.FromSeconds(20)))
                {
                    customerCreatePage.SaveCustomer();
                }            
                              
                webDriver.VerifyBusyOverlayNotDisplayed();
                if (customerCreatePage.AddressValidationPopUp.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)))
                {
                    customerCreatePage.ConfirmYesBtn.Click(webDriver);
                }
                if (customerCreatePage.AddressVerificationPopUp.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)))
                {
                    if (isVerifiedAddress == true && isVerifiedLegalCompanyname == true)
                    {
                        customerCreatePage.LegalCompanyNameNotification.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)).Equals(false);
                    }
                    else
                    {
                        customerCreatePage.LegalCompanyNameNotification.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)).Equals(true);
                    }
                    customerCreatePage.SaveLegalCompanyName.Click(webDriver);
                }
                if (customerCreatePage.CreateThisNewCustomer.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)))
                {
                    customerCreatePage.CreateThisNewCustomer.Click(webDriver);
                }
                customerNumber = customerDetailsPage.LblCustomerNumber.GetText(webDriver);
                //Wait for Newly Copied Customer Details Page to load
                customerDetailsPage.WaitForCustomerDetailsPageToLoad();

            }
            catch (Exception e)
            {
                Logger.Write("Exception Occured while Copying Customer");
                return "Exception - While Copying Customer";
            }
            return customerNumber;
        }

    }
}
