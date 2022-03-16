using System;
using System.Data;
using System.Security.Cryptography;
using Dell.Adept.Testing.DataGenerators.Primitive;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.DataModels;
using Dsa.Pages;
using Dsa.Pages.Customer;
using Dsa.Utils;
using OpenQA.Selenium;

namespace Dsa.Workflows
{
    public static class CreateCustomerWorkflow
    {

        #region Private Methods

        #region Get New Customer Data
        private static NewCustomer GetNewCustomerData(string businessunit, string compNum, string compName, string custClass,
            string parentRef, bool shippingSameAsBilling, Address billing, Address shipping, string salesRep,
            string note, string currency, FinancialPrefrences financialPrefrences)
        {
            var customer = new NewCustomer
            {
                BusinessUnit = businessunit,
                CompanyNumber = compNum,
                CompanyName = compName,
                CustomerClass = custClass,
                ParentReference = parentRef,
                PrimarySalesRepId = salesRep,
                Currency = currency,
                Note = note,
                BillingInformation = billing,
                ShippingAddressSameAsBillingAddress = shippingSameAsBilling,
                ShippingAddress = shippingSameAsBilling ? billing : shipping,
                FinancialPrefrences = financialPrefrences
            };

            return customer;
        }

        #endregion

        #region Get New Address Data
        private static Address GetNewAddressData(string compName, string firstName, string middle, string lastName, string dept,
            string email, string title, string mailStop, string phone1, string phone2, string fax, string address1,
            string address2, string city, string state, string zip, string zipExt, string country, string invoiceDeliveryMethod)
        {
            var address = new Address
            {
                CompanyName = compName,
                FirstName = firstName,
                MiddleInitial = middle,
                LastName = lastName,
                Department = dept,
                Email = email,
                Title = title,
                Mailstop = mailStop,
                PrimaryPhone = phone1,
                SecondaryPhone = phone2,
                FaxNumber = fax,
                AddressLine1 = address1,
                AddressLine2 = address2,
                City = city,
                State = state,
                ZipCode = zip,
                ZipExtension = zipExt,
                Country = country,
                InvoiceDeliveryMethod = invoiceDeliveryMethod
            };
            return address;
        }
        #endregion

        #endregion

        #region Public Methods

        #region Create New Customer
        public static void CreateNewCustomer(IWebDriver webDriver, DataRow row, string companyNumber, bool isDellPrint, bool shippingSameAsBilling, bool mailingSameAsBilling)
        {
            // Navigate to Create Customer Page.
            HomeWorkflow.GoToCustomerCreatePage(webDriver);

            // Select Company number from Catalog popup.
            new ProductSearchPage(webDriver).SelectCompanyNumber(companyNumber);

            // Create new customer.
            var pendingCustomerNumber = CreateCustomerWorkflow.GetCustomerData(webDriver, row, shippingSameAsBilling, mailingSameAsBilling, isDellPrint);

            CustomerDetailsPage cusDetailsPage;
            // If pending customer number is empty (customer is successfully created). Navigate to customer details screen.
            if (string.IsNullOrEmpty(pendingCustomerNumber))
            {
                // Navigate to Customer details screen.
                cusDetailsPage = new CustomerDetailsPage(webDriver);
                cusDetailsPage.WaitForCustomerDetailsPageToLoad();
            }
            else
            {
                cusDetailsPage = CustomerSearchWorkflow.SearchCustomerByCustomerNumber(webDriver, pendingCustomerNumber);
                cusDetailsPage.WaitForCustomerDetailsPageToLoad();
                var customerNumber = cusDetailsPage.LblCustomerNumber.GetText(webDriver);
                Logger.Write("Created customer number : " + customerNumber);
            }

            /*var isDellPrintCompany = ValidateCompany.IsCompanyNumberDellPrint(companyNumber);

            if (isDellPrint && isDellPrintCompany)
            {

                new CustomerCreatePage(webDriver).SetContactInfoReqdFields_DellPrint(newCustomer.CompanyNumber, newCustomer.CompanyName, newCustomer.CustomerClass);
                new CustomerCreatePage(webDriver).SetBillingInfoReqdFields_DellPrint(newCustomer.BillingInformation);
            }
            else
            {
                new CustomerCreatePage(webDriver).SetContactInfoReqdFields(newCustomer.CompanyNumber, newCustomer.CompanyName, newCustomer.CustomerClass);
                new CustomerCreatePage(webDriver).SetBillingInfoReqdFields(newCustomer.BillingInformation);
            }


            if (newCustomer.ShippingAddressSameAsBillingAddress)
            {
                new CustomerCreatePage(webDriver).MarkSameAsBillingAddressCheckbox();
                if (isDellPrint && isDellPrintCompany)
                {
                    new CustomerCreatePage(webDriver).MarkMailingSameAsBillingAddressCheckbox();
                }
            }
            else
            {
                if (isDellPrint && isDellPrintCompany)
                {
                    new CustomerCreatePage(webDriver).SetShippingInfoReqdFields_DellPrint(newCustomer.ShippingAddress);
                    new CustomerCreatePage(webDriver).SetMailingInfoReqdFields_DellPrint(newCustomer.ShippingAddress);
                }
                else
                {
                    new CustomerCreatePage(webDriver).SetShippingInfoReqdFields(newCustomer.ShippingAddress);
                }
            }
            if (isDellPrint && isDellPrintCompany)
            {
                new CustomerCreatePage(webDriver).SetFinancialPrefrences_DellPrint(newCustomer.FinancialPrefrences);
            }
            //TODO remove next line once Sales Rep is automatically populated
            new CustomerCreatePage(webDriver).SetPrimarySalesRepId(newCustomer.PrimarySalesRepId);

            new CustomerCreatePage(webDriver).SaveCustomer();
            return new CustomerCreatePage(webDriver);*/
        }

        #endregion

        #region Navigate to Create New Customer
        public static bool NavigateToCreateNewCustomer(IWebDriver webDriver)
        {
            var mainmenu = new HomePage(webDriver).ClickMainMenu(webDriver);
            mainmenu.AddCustomer();
            return new CustomerCreatePage(webDriver).IsActive();
        }

        #endregion

        #region Pop up Logic

        public static void PopUpLogic(IWebDriver webDriver)
        {
            if (new CustomerCreatePage(webDriver).IsAvsVisible())
                new CustomerCreatePage(webDriver).SelectEnteredAddress();

            if (new CustomerCreatePage(webDriver).HasDupeCustomerWarningModal())
                new CustomerCreatePage(webDriver).SelectEnteredCustomer();
        }

        #endregion

        #region Refresh and wait multiple times
        public static void RefreshAndWaitMultipleTimes(IWebDriver webDriver)
        {

            RefreshPageIfErrorPageIsDisplayed(webDriver);

            RefreshPageIfErrorPageIsDisplayed(webDriver);

            RefreshPageIfErrorPageIsDisplayed(webDriver);

            RefreshPageIfErrorPageIsDisplayed(webDriver);

            RefreshPageIfErrorPageIsDisplayed(webDriver);

            RefreshPageIfErrorPageIsDisplayed(webDriver);

        }

        #endregion

        #region Refresh page if Error page is displayed

        public static void RefreshPageIfErrorPageIsDisplayed(IWebDriver webDriver)
        {
            if (!new CustomerDetailsPage(webDriver).HasNoResultsMsg()) return;
            webDriver.Navigate().Refresh();
        }

        #endregion

        #region Get New Customer Data

        public static NewCustomer GetNewCustomerData(DataRow row, bool sameBillingShipping, bool uniqueFirstName)
        {
            string name = string.Empty;
            if (uniqueFirstName)
                name = Generator.RandomString(3, Generator.RandomCharacterGroup.AlphaOnly).ToUpper();
            return GetNewCustomerData("US", row["CompanyNumber"].ToString(),
                row["BillingCompanyName"].ToString(),
                row["CustomerClass"].ToString(), string.Empty, sameBillingShipping,
                GetNewAddressData(row["BillingCompanyName"].ToString(), row["BillingFirstName"] + name,
                    row["BillingMiddle"].ToString(), row["BillingLastName"].ToString(),
                    row["BillingDept"].ToString(), row["BillingEmail"].ToString(), row["BillingTitle"].ToString(),
                    row["BillingMailstop"].ToString(),
                    row["BillingPhone1"].ToString(), row["BillingPhone2"].ToString(),
                    row["BillingFax"].ToString(), row["BillingAddressLine1"].ToString(),
                    row["BillingAddressLine2"].ToString(), row["BillingCity"].ToString(), row["BillingState"].ToString(),
                    row["BillingZip"].ToString(), row["BillingPlus4"].ToString(), row["BillingCountry"].ToString(),
                    row["InvoiceDeliveryMethod"].ToString()),
                GetNewAddressData(row["ShippingCompanyName"].ToString(), row["ShippingFirstName"] + name,
                    row["ShippingMiddle"].ToString(), row["ShippingLastName"].ToString(),
                    row["ShippingDept"].ToString(), row["ShippingEmail"].ToString(), row["ShippingTitle"].ToString(),
                    row["ShippingMailstop"].ToString(),
                    row["ShippingPhone1"].ToString(), row["ShippingPhone2"].ToString(),
                    row["ShippingFax"].ToString(), row["ShippingAddressLine1"].ToString(),
                    row["ShippingAddressLine2"].ToString(), row["ShippingCity"].ToString(),
                    row["ShippingState"].ToString(),
                    row["ShippingZip"].ToString(), row["ShippingPlus4"].ToString(), row["ShippingCountry"].ToString(),
                    string.Empty),
                row["SalesRepID"].ToString(),
                "Test Note created at: " + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss"), "USD",
                new FinancialPrefrences
                {
                    InvoicePreference = row["InvoicePreference"].ToString(),
                    PaymentTerm = row["PaymentTerm"].ToString()
                });
        }

        #endregion

        #region Verify Customer Details Page
        public static bool VerifyCustomerDetailsPage(IWebDriver webDriver, string billingFirstName, string companyNumber)
        {
            var customerName = new CustomerDetailsPage(webDriver).BillToAddrContactName.GetText(webDriver);
            if (!string.Equals(customerName.Substring(0, 5), billingFirstName))
                throw new Exception("Billing First Name was not correct");
            if (!string.Equals(new CustomerDetailsPage(webDriver).LblCustomerNumber.GetText(webDriver), companyNumber))
                throw new Exception("Company number was not correct");
            return true;
        }

        #endregion

        #region Enter Customer Data

        public static void EnterCustomerData(IWebDriver webDriver, DataRow row, bool isCommercialCustomer = false, bool isShippingSameAsBilling = false)
        {
            var customerCreatePage = new CustomerCreatePage(webDriver);
            webDriver.VerifyBusyOverlayNotDisplayed();

            if (isCommercialCustomer == true)
            {
                customerCreatePage.ContactInfoCustomerClassId.PickDropdownByText(webDriver, row["CustomerClass"].ToString());
                webDriver.WaitForBusyOverlay();
                // Enter Company Details
                customerCreatePage.ContactInfoCompanyNameId.SetText(webDriver, row["CompanyName"].ToString());
                customerCreatePage.ContactCompPhone.SetText(webDriver, row["CompanyPhone"].ToString());
               
            }

            webDriver.WaitForBusyOverlay();
            // Enter Billing Details
            customerCreatePage.BillingContactFirstNameTxt.SetText(webDriver, row["BillingFirstName"].ToString());
            customerCreatePage.BillingContactMiddleNameTxt.SetText(webDriver, row["BillingMiddle"].ToString());
            customerCreatePage.BillingContactLastNameTxt.SetText(webDriver, row["BillingLastName"].ToString());
            customerCreatePage.BillingContactDepartmentTxt.SetText(webDriver, row["BillingDepartment"].ToString());
            customerCreatePage.CustomerBillingCountryTxt.PickDropdownByText(webDriver, row["BillingCountry"].ToString());
            customerCreatePage.CustomerBillingAddressLine1Txt.SetText(webDriver, row["BillingAddressLine1"].ToString());
            customerCreatePage.CustomerBillingAddressLine2Txt.SetText(webDriver, row["BillingAddressLine2"].ToString());
            customerCreatePage.CustomerBillingZipCodeTxt.SetText(webDriver, row["BillingZip"].ToString());
            customerCreatePage.CustomerBillingZipCodeExtensionTxt.SetText(webDriver, row["BillingZipCodeExtension"].ToString());
            
           
            customerCreatePage.BillingContactInvoicingEmailTxt.SetText(webDriver, row["BillingEmail"].ToString());
            if (customerCreatePage.EmailOverrideValidation.IsElementDisplayed(webDriver))
            {
                customerCreatePage.CheckAllEmailOverrideValidation();
            }

            customerCreatePage.BillingContacWorkPhoneTxt.SetText(webDriver, row["BillingWorkPhone"].ToString());

            if (customerCreatePage.PhoneOverrideValidation.IsElementDisplayed(webDriver))
            {
                customerCreatePage.CheckAllPhoneOverrideValidation();
            }

            if (!string.IsNullOrEmpty(row["BillingState"].ToString())) // to be removed after defect is fixed
            {
                customerCreatePage = new CustomerCreatePage(webDriver);
                customerCreatePage.CustomerBillingStateTxt.PickDropdownByText(webDriver, row["BillingState"].ToString());
            }

            // Enter Shipping Details

            if (isShippingSameAsBilling)
            {
                customerCreatePage.ShippingAddressSameAdBillingChk.SelectCheckBox(webDriver);
            }
            else
            {
                customerCreatePage.ShippingContactTitleLst.PickDropdownByText(webDriver, row["ShippingTitle"].ToString());
                customerCreatePage.ShippingContactFirstNameTxt.SetText(webDriver, row["ShippingFirstName"].ToString());
                customerCreatePage.ShippingContactMiddleNameTxt.SetText(webDriver, row["ShippingMiddle"].ToString());
                customerCreatePage.ShippingContactLastNameTxt.SetText(webDriver, row["ShippingLastName"].ToString());
                customerCreatePage.ShippingContactDepartmentTxt.SetText(webDriver, row["ShippingDepartment"].ToString());
                customerCreatePage.ShippingContactCountryLst.PickDropdownByText(webDriver, row["ShippingCountry"].ToString());
                customerCreatePage.ShippingContactAddressLine1Txt.SetText(webDriver, row["ShippingAddressLine1"].ToString());
                customerCreatePage.ShippingContactAddressLine2Txt.SetText(webDriver, row["ShippingAddressLine2"].ToString());
                customerCreatePage.ShippingContactMailStopTxt.SetText(webDriver, row["ShippingMailStop"].ToString());
                customerCreatePage.ShippingContactZipCodeTxt.SetText(webDriver, row["ShippingZip"].ToString());
                customerCreatePage.ShippingContactzipCodeExtensionTxt.SetText(webDriver, row["ShippingzipCodeExtension"].ToString());


                customerCreatePage.ShippingContactInvoicingEmailTxt.SetText(webDriver, row["ShippingInvoicingEmail"].ToString());
                if (customerCreatePage.EmailOverride.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)))
                {
                    customerCreatePage.EmailOverride.Click(webDriver);
                }

                customerCreatePage.ShippingContactWorkPhoneTxt.SetText(webDriver, row["ShippingWorkPhone"].ToString());

                if (!string.IsNullOrEmpty(row["ShippingState"].ToString())) // to be removed after defect is fixed
                {
                    customerCreatePage = new CustomerCreatePage(webDriver);
                    customerCreatePage.ShippingContactStateLst.PickDropdownByText(webDriver, row["ShippingState"].ToString());
                }

            }

            // Enter Finance Details
            FinancialDellPrintCustomer(webDriver, row);

            // Enter Relationship Details
            if (row["SalesRepID"].ToString() != null)
            {
                customerCreatePage.CustCreateSalesRepId.Clear();
                customerCreatePage.CustCreateSalesRepId.SetText(webDriver, row["SalesRepID"].ToString());
            }

        }

        #endregion

        #region Save Customer

        public static string SaveCustomer(IWebDriver webDriver, bool isCommercialCustomer = false, bool shippingSameAsBilling = true)
        {
            string createdCustomerNumber;

            //customerCreatePage.BtnAddNewCustomerSave.Click(webDriver);
            new CustomerCreatePage(webDriver).BtnAddNewCustomerSave.SendKeys(Keys.Enter); // temporary fix as the regular click method isn't working
            webDriver.WaitForBusyOverlay();

            if (isCommercialCustomer)
            {
                if (new CustomerCreatePage(webDriver).AddressValidationPopUp.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(20)))
                {
                    new CustomerCreatePage(webDriver).EnteredAddressRdBtn.Click(webDriver);
                    new CustomerCreatePage(webDriver).SaveAddressRdBtn.Click(webDriver);
                }
                else if (new CustomerCreatePage(webDriver).CustCreateSuggestnsWithSuggestnModalId.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(20)))
                {
                    new CustomerCreatePage(webDriver).BtnDupeCustModalSaveEntered.Click(webDriver);
                }
                else if (new CustomerCreatePage(webDriver).AddressSuggestionPopup.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(20)))
                {
                    new CustomerCreatePage(webDriver).UseOriginalAddress.Click(webDriver);
                    new CustomerCreatePage(webDriver).AddShippingAddress.Click(webDriver);
                    webDriver.VerifyBusyOverlayNotDisplayed();

                    if (!shippingSameAsBilling)
                    {
                        webDriver.WaitForElementVisible(By.Id("AddressSuggestionsDialog"), TimeSpan.FromSeconds(20));
                        new CustomerCreatePage(webDriver).UseOriginalAddress.Click(webDriver);
                        new CustomerCreatePage(webDriver).AddShippingAddress.Click(webDriver);
                        webDriver.VerifyBusyOverlayNotDisplayed();
                        Logger.Write("2nd address suggestion handled successfully.");
                    }
                }

                webDriver.VerifyBusyOverlayNotDisplayed();

                if (new CustomerCreatePage(webDriver).AddressValidationPopUp.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)))
                {
                    new CustomerCreatePage(webDriver).ConfirmYesBtn.Click(webDriver);
                }
                if (new CustomerCreatePage(webDriver).AddressVerificationPopUp.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)))
                {
                    new CustomerCreatePage(webDriver).SaveLegalCompanyName.Click(webDriver, TimeSpan.FromSeconds(10));
                }
                if (new CustomerCreatePage(webDriver).CreateThisNewCustomer.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(120)))
                {
                    new CustomerCreatePage(webDriver).CreateThisNewCustomer.Click(webDriver);
                    webDriver.VerifyBusyOverlayNotDisplayed();
                }
                createdCustomerNumber = ProcessCustomerCreationPending(new CustomerCreatePage(webDriver));
            }
            else
            {
                if (new CustomerCreatePage(webDriver).AddressSuggestionPopup.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)))
                {
                    new CustomerCreatePage(webDriver).UseOriginalAddress.Click(webDriver);
                    new CustomerCreatePage(webDriver).AddShippingAddress.Click(webDriver);
                    if (new CustomerCreatePage(webDriver).CustCreateSuggestnsWithSuggestnModalId.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)))
                    {
                        new CustomerCreatePage(webDriver).BtnDupeCustModalSaveEntered.Click(webDriver);
                    }
                }
                webDriver.VerifyBusyOverlayNotDisplayed();
                createdCustomerNumber = ProcessCustomerCreationPending(new CustomerCreatePage(webDriver));
            }

            return createdCustomerNumber;
        }

        #endregion

        #region Get Customer Data

        public static string GetCustomerData(IWebDriver webDriver, DataRow row, bool shippingSameAsBilling = true, bool mailingSameAsBilling = true, bool isDellConsumer = false)
        {
            var customerCreatePage = new CustomerCreatePage(webDriver);
            var customerNumber = string.Empty;

            switch (isDellConsumer)
            {
                case true:
                    webDriver.VerifyBusyOverlayNotDisplayed();
                    AddBillingAddressDellPrintCustomer(webDriver, row);
                    if (shippingSameAsBilling.Equals(false))
                    {
                        ShippingInformationDellPrintCompany(webDriver, row);
                    }
                    else
                    {
                        customerCreatePage.ShippingAddressSameAdBillingChk.SelectCheckBox(webDriver);
                    }
                    webDriver.ScrollToBottom();
                    FinancialDellPrintCustomer(webDriver, row);
                    customerCreatePage.BtnAddNewCustomerSave.Click(webDriver);
                    if (customerCreatePage.AddressSuggestionPopup.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)))
                    {
                        webDriver.WaitForBusyOverlay();
                        customerCreatePage.UseOriginalAddress.Click(webDriver);
                        customerCreatePage.AddShippingAddress.Click(webDriver);
                        if (customerCreatePage.CustCreateSuggestnsWithSuggestnModalId.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)))
                        {
                            customerCreatePage.BtnDupeCustModalSaveEntered.Click(webDriver);
                        }
                    }
                    webDriver.VerifyBusyOverlayNotDisplayed();
                    customerNumber = ProcessCustomerCreationPending(customerCreatePage);
                    //if (shippingSameAsBilling.Equals(false))
                    //{
                    //    customerCreatePage.UseOriginalAddress.Click(webDriver);
                    //    customerCreatePage.AddShippingAddress.Click(webDriver);
                    //}

                    break;
                case false:
                    webDriver.VerifyBusyOverlayNotDisplayed();
                    webDriver.WaitForBusyOverlay();
                    BillingAddressNonDPCustomer(webDriver, row);

                    if (customerCreatePage.BusinessAct.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)))
                    {
                        customerCreatePage.BusinessAct.SelectCheckBox(webDriver);
                    }
                    else
                    { 
                        
                    }


                    if (shippingSameAsBilling.Equals(false))
                    {
                        ShippingInformationNonDpCompany(webDriver, row);
                    }
                    else
                    {
                        customerCreatePage.ShippingAddressSameAdBillingChk.SelectCheckBox(webDriver);
                    }
                    FinancialDellPrintCustomer(webDriver, row);
                    customerCreatePage.BtnAddNewCustomerSave.Click(webDriver);
                    if (customerCreatePage.AddressValidationPopUp.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)))
                    {
                        customerCreatePage.EnteredAddressRdBtn.Click(webDriver);
                        customerCreatePage.SaveAddressRdBtn.Click(webDriver);
                    }
                    else if (customerCreatePage.CustCreateSuggestnsWithSuggestnModalId.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)))
                    {
                        customerCreatePage.BtnDupeCustModalSaveEntered.Click(webDriver);
                    }
                    else if (customerCreatePage.AddressSuggestionPopup.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)))
                    {
                        customerCreatePage.UseOriginalAddress.Click(webDriver);
                        customerCreatePage.AddShippingAddress.Click(webDriver);
                    }
                    else if (shippingSameAsBilling.Equals(false))
                    {
                        customerCreatePage.UseOriginalAddress.Click(webDriver);
                        customerCreatePage.AddShippingAddress.Click(webDriver);
                    }
                    webDriver.VerifyBusyOverlayNotDisplayed();

                    if (customerCreatePage.AddressValidationPopUp.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)))
                    {
                        customerCreatePage.ConfirmYesBtn.Click(webDriver);
                    }
                    if (customerCreatePage.AddressVerificationPopUp.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(20)))
                    {
                        customerCreatePage.SaveLegalCompanyName.Click(webDriver, TimeSpan.FromSeconds(20));
                    }
                    if (customerCreatePage.CreateThisNewCustomer.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(120)))
                    {
                        customerCreatePage.CreateThisNewCustomer.Click(webDriver);
                        webDriver.VerifyBusyOverlayNotDisplayed();
                    }
                    customerNumber = ProcessCustomerCreationPending(customerCreatePage);
                    break;
            }

            return customerNumber;
        }

        private static string ProcessCustomerCreationPending(CustomerCreatePage customerCreatePage)
        {
            if (customerCreatePage.IsCustomerCreationPending())
            {
                var customerNumber = customerCreatePage.GetPendingCustomerNumber();
                customerCreatePage.ContinueWithPendingCustomerCreation();

                return customerNumber;
            }

            return string.Empty;
        }

        #endregion

        ////Temporary: Need modification. have to modify NewCustomer model class to have a better code approach
        //public static void GetCustomerData(IWebDriver webDriver,DataRow row, bool shippingSameAsBilling,bool isDellPrint)
        //{
        //    string name = string.Empty;
        //    name = Generator.RandomString(3, Generator.RandomCharacterGroup.AlphaOnly).ToUpper();
        //    var customerCreatePage = new CustomerCreatePage(webDriver);

        //    switch (isDellPrint)
        //    {
        //        case true:
        //            BillingAddressDellPrintCustomer(webDriver, row, name);
        //            if (shippingSameAsBilling.Equals(false))
        //            {
        //                ShippingInformationDellPrintCompany(webDriver, row, name);
        //            }
        //            else
        //            {
        //                customerCreatePage.ShippingAddressSameAdBillingChk.Click(webDriver);
        //            }
        //            FinancialDellPrintCustomer(webDriver, row);
        //            customerCreatePage.CustCreateSalesRepId.SetText(webDriver, row["SalesRepID"].ToString());
        //            customerCreatePage.CustomerCreateNotes.SendKeys(row["Notes"].ToString());

        //            customerCreatePage.BtnAddNewCustomerSave.Click(webDriver);


        //            //Commented temporary as validate address pop up is not showing up
        //            //if (webDriver.Url.Contains("customer/details").Equals(false))
        //            //{

        //            //        if (webDriver.FindElement(By.Id("_shippingAddress_validation_withSuggestion"))
        //            //            .Displayed.Equals(true))
        //            //        {
        //            //            customerCreatePage.UseOriginalAddressBtn.Click(webDriver);
        //            //            customerCreatePage.ConfirmYesBtn.Click(webDriver);
        //            //        }
        //            //}

        //            break;
        //        case false:
        //            BillingAddressNonDPCustomer(webDriver, row, name);
        //            if (shippingSameAsBilling.Equals(false))
        //            {
        //                ShippingInformationNonDpCompany(webDriver, row, name);
        //            }
        //            else
        //            {
        //                customerCreatePage.ShippingAddressSameAdBillingChk.Click(webDriver);

        //            }

        //            customerCreatePage.MailingAddressSameAdBillingChk.Click(webDriver);

        //            customerCreatePage.CustCreateSalesRepId.SetText(webDriver, row["SalesRepID"].ToString());
        //            customerCreatePage.CustomerCreateNotes.SendKeys(row["Notes"].ToString());
        //            customerCreatePage.BtnAddNewCustomerSave.Click(webDriver);
        //            //customerCreatePage.VerifiedAddressRdBtn.Click(webDriver);
        //            //customerCreatePage.SaveAddressRdBtn.Click(webDriver);
        //            if (shippingSameAsBilling.Equals(false))
        //            {
        //                customerCreatePage.VerifiedAddressRdBtn.Click(webDriver);
        //                customerCreatePage.SaveAddressRdBtn.Click(webDriver);
        //            }

        //            break;
        //    }
        //}

        //public static void ShippingInformationDellPrintCompany(IWebDriver webDriver, DataRow row, string name)
        //{
        //    var customerCreatePage = new CustomerCreatePage(webDriver);
        //    customerCreatePage.ShippingContactTitleLst.PickDropdownByText(webDriver, row["ShippingTitle"].ToString());
        //    customerCreatePage.ShippingContactAddressLine1Txt.SetText(webDriver, row["ShippingAddressLine1"].ToString());
        //    customerCreatePage.ShippingContactAddressLine2Txt.SetText(webDriver, row["ShippingAddressLine2"].ToString());
        //    customerCreatePage.ShippingContactDepartmentTxt.SetText(webDriver, row["ShippingDepartment"].ToString());
        //    customerCreatePage.ShippingContactMailStopTxt.SetText(webDriver, row["ShippingMailStop"].ToString());
        //    customerCreatePage.ShippingContactCityTxt.SetText(webDriver, row["ShippingCity"].ToString());
        //    customerCreatePage.ShippingContactStateLst.PickDropdownByText(webDriver, row["ShippingState"].ToString());
        //    customerCreatePage.ShippingContactZipCodeTxt.SetText(webDriver, row["ShippingZip"].ToString());
        //    customerCreatePage.ShippingContactzipCodeExtensionTxt.SetText(webDriver, row["ShippingzipCodeExtension"].ToString());
        //    customerCreatePage.ShippingContactCountryLst.PickDropdownByText(webDriver, row["ShippingCountry"].ToString());
        //    customerCreatePage.ShippingContactFirstNameTxt.SetText(webDriver, row["ShippingFirstName"].ToString() + name);
        //    customerCreatePage.ShippingContactMiddleNameTxt.SetText(webDriver, row["ShippingMiddle"].ToString());
        //    customerCreatePage.ShippingContactLastNameTxt.SetText(webDriver, row["ShippingLastName"].ToString() + name);
        //    customerCreatePage.ShippingContactInvoicingEmailTxt.SetText(webDriver, row["ShippingInvoicingEmail"].ToString());
        //    customerCreatePage.ShippingContactDigitalFulFillmentEmailTxt.SetText(webDriver, row["ShippingIDigitalFulfillmentEmail"].ToString());
        //    customerCreatePage.ShippingContactProSupportEmailTxt.SetText(webDriver, row["ShippingProSupportEmail"].ToString());
        //    customerCreatePage.ShippingContactFlexBillingEmailTxt.SetText(webDriver, row["ShippingFlexbillingEmail"].ToString());
        //    customerCreatePage.ShippingContactOtherEmailTxt.SetText(webDriver, row["ShippingOtherEmail"].ToString());
        //    customerCreatePage.ShippingContactHomePhoneTxt.SetText(webDriver, row["ShippingHomePhone"].ToString());
        //    customerCreatePage.ShippingContactMobileHomeTxt.SetText(webDriver, row["ShippingMobileFax"].ToString());
        //    customerCreatePage.ShippingContactWorkHomeTxt.SetText(webDriver, "ShippingWorkPhone");
        //    customerCreatePage.ShippingContactFaxTxt.SetText(webDriver, row["ShippingFax"].ToString());
        //}

        #region Add Shipping Information Dell Print Company

        public static void ShippingInformationDellPrintCompany(IWebDriver webDriver, DataRow row)
        {
            var customerCreatePage = new CustomerCreatePage(webDriver);
            customerCreatePage.ShippingContactTitleLst.PickDropdownByText(webDriver, row["ShippingTitle"].ToString());
            customerCreatePage.ShippingContactAddressLine1Txt.SetText(webDriver, row["ShippingAddressLine1"].ToString());
            customerCreatePage.ShippingContactAddressLine2Txt.SetText(webDriver, row["ShippingAddressLine2"].ToString());
            customerCreatePage.ShippingContactDepartmentTxt.SetText(webDriver, row["ShippingDepartment"].ToString());
            customerCreatePage.ShippingContactMailStopTxt.SetText(webDriver, row["ShippingMailStop"].ToString());
            customerCreatePage.ShippingContactCityTxt.SetText(webDriver, row["ShippingCity"].ToString());
            customerCreatePage.ShippingContactStateLst.PickDropdownByText(webDriver, row["ShippingState"].ToString());
            customerCreatePage.ShippingContactZipCodeTxt.SetText(webDriver, row["ShippingZip"].ToString());
            customerCreatePage.ShippingContactzipCodeExtensionTxt.SetText(webDriver, row["ShippingzipCodeExtension"].ToString());
            customerCreatePage.ShippingContactCountryLst.PickDropdownByText(webDriver, row["ShippingCountry"].ToString());
            customerCreatePage.ShippingContactFirstNameTxt.SetText(webDriver, row["ShippingFirstName"].ToString());
            customerCreatePage.ShippingContactMiddleNameTxt.SetText(webDriver, row["ShippingMiddle"].ToString());
            customerCreatePage.ShippingContactLastNameTxt.SetText(webDriver, row["ShippingLastName"].ToString());
            customerCreatePage.ShippingContactInvoicingEmailTxt.SetText(webDriver, row["ShippingInvoicingEmail"].ToString());
            customerCreatePage.ShippingContactDigitalFulFillmentEmailTxt.SetText(webDriver, row["ShippingIDigitalFulfillmentEmail"].ToString());
            customerCreatePage.ShippingContactProSupportEmailTxt.SetText(webDriver, row["ShippingProSupportEmail"].ToString());
            customerCreatePage.ShippingContactFlexBillingEmailTxt.SetText(webDriver, row["ShippingFlexbillingEmail"].ToString());
            customerCreatePage.ShippingContactOtherEmailTxt.SetText(webDriver, row["ShippingOtherEmail"].ToString());
            customerCreatePage.ShippingContactHomePhoneTxt.SetText(webDriver, row["ShippingHomePhone"].ToString());
            customerCreatePage.ShippingContactMobileHomeTxt.SetText(webDriver, row["ShippingMobilePhone"].ToString());
            customerCreatePage.ShippingContactWorkPhoneTxt.SetText(webDriver, row["ShippingWorkPhone"].ToString());
            customerCreatePage.ShippingContactFaxTxt.SetText(webDriver, row["ShippingFax"].ToString());
        }

        #endregion

        #region Shipping Information Non DP Company

        public static void ShippingInformationNonDpCompany(IWebDriver webDriver, DataRow row)
        {
            var customerCreatePage = new CustomerCreatePage(webDriver);
            customerCreatePage.ShippingContactTitleLst.PickDropdownByText(webDriver, row["ShippingTitle"].ToString());
            customerCreatePage.ShippingContactAddressLine1Txt.SetText(webDriver, row["ShippingAddressLine1"].ToString());
            customerCreatePage.ShippingContactAddressLine2Txt.SetText(webDriver, row["ShippingAddressLine2"].ToString());
            customerCreatePage.ShippingContactDepartmentTxt.SetText(webDriver, row["ShippingDepartment"].ToString());
            customerCreatePage.ShippingContactMailStopTxt.SetText(webDriver, row["ShippingMailStop"].ToString());
            customerCreatePage.ShippingContactCityTxt.SetText(webDriver, row["ShippingCity"].ToString());
            customerCreatePage.ShippingContactStateLst.PickDropdownByText(webDriver, row["ShippingState"].ToString());
            customerCreatePage.ShippingContactZipCodeTxt.SetText(webDriver, row["ShippingZip"].ToString());
            customerCreatePage.ShippingContactzipCodeExtensionTxt.SetText(webDriver, row["ShippingZipCodeExtension"].ToString());
            customerCreatePage.ShippingContactCountryLst.PickDropdownByText(webDriver, row["ShippingCountry"].ToString());
            customerCreatePage.ShippingContactFirstNameTxt.SetText(webDriver, row["ShippingFirstName"].ToString());
            customerCreatePage.ShippingContactMiddleNameTxt.SetText(webDriver, row["ShippingMiddle"].ToString());
            customerCreatePage.ShippingContactLastNameTxt.SetText(webDriver, row["ShippingLastName"].ToString());
            customerCreatePage.ShippingEmailTxt.SetText(webDriver, row["ShippingInvoicingEmail"].ToString());
            customerCreatePage.ShippingContactDigitalFulFillmentEmailTxt.SetText(webDriver, row["ShippingIDigitalFulfillmentEmail"].ToString());
            customerCreatePage.ShippingContactProSupportEmailTxt.SetText(webDriver, row["ShippingProSupportEmail"].ToString());
            customerCreatePage.ShippingContactFlexBillingEmailTxt.SetText(webDriver, row["ShippingFlexbillingEmail"].ToString());
            customerCreatePage.ShippingContactOtherEmailTxt.SetText(webDriver, row["ShippingOtherEmail"].ToString());
            customerCreatePage.ShippingPrimaryPhoneTxt.SetText(webDriver, row["ShippingHomePhone"].ToString());
            customerCreatePage.ShippingSecondaryPhoneTxt.SetText(webDriver, row["ShippingMobilePhone"].ToString());
            customerCreatePage.ShippingContactWorkPhoneTxt.SetText(webDriver, row["ShippingWorkPhone"].ToString());
            customerCreatePage.ShippingContactFaxTxt.SetText(webDriver, row["ShippingFax"].ToString());

        }

        #endregion

        #region Add Billing Address Dell Print Customer

        public static void AddBillingAddressDellPrintCustomer(IWebDriver webDriver, DataRow row)
        {
            var customerCreatePage = new CustomerCreatePage(webDriver);
            webDriver.VerifyBusyOverlayNotDisplayed();
            customerCreatePage.ContactInfoCustomerClassId.PickDropdownByText(webDriver, row["CustomerClass"].ToString());
            customerCreatePage.ContactInfoTitle.PickDropdownByText(webDriver, row["BillingTitle"].ToString());
            customerCreatePage.CustomerBillingCountryTxt.PickDropdownByText(webDriver, row["BillingCountry"].ToString());
            customerCreatePage.BillingContactFirstNameTxt.SetText(webDriver, row["BillingFirstName"].ToString());
            customerCreatePage.BillingContactMiddleNameTxt.SetText(webDriver, row["BillingMiddle"].ToString());
            customerCreatePage.BillingContactLastNameTxt.SetText(webDriver, row["BillingLastName"].ToString());
            customerCreatePage.CustomerBillingAddressLine1Txt.SetText(webDriver, row["BillingAddressLine1"].ToString());
            customerCreatePage.CustomerBillingAddressLine2Txt.SetText(webDriver, row["BillingAddressLine2"].ToString());
            //customerCreatePage.CustomerBillingCityTxt.SetText(webDriver, row["BillingCity"].ToString());
            //customerCreatePage.CustomerBillingStateTxt.PickDropdownByText(webDriver, row["BillingState"].ToString()); 

            customerCreatePage.CustomerBillingZipCodeTxt.SetText(webDriver, row["BillingZip"].ToString());
            customerCreatePage.CustomerBillingZipCodeExtensionTxt.SetText(webDriver, row["BillingZipCodeExtension"].ToString());
            customerCreatePage.InvoiceDeliverMethodTxt.PickDropdownByText(webDriver, row["InvoiceDeliveryMethod"].ToString());
            customerCreatePage.InvoicePreference.PickDropdownByText(webDriver, row["InvoicePreference"].ToString());
            customerCreatePage.BillingContactDepartmentTxt.SetText(webDriver, row["BillingDepartment"].ToString());
            customerCreatePage.BillingContactInvoicingEmailTxt.SetText(webDriver, row["BillingInvoicingEmail"].ToString());
            if (customerCreatePage.EmailOverride.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)))
            {
                customerCreatePage.EmailOverride.Click(webDriver);
            }
            else
            {
                //Do nothing
            }

            customerCreatePage.BillingContactHomePhoneTxt.SetText(webDriver, row["BillingHomePhone"].ToString());
            customerCreatePage.BillingContacMobilePhoneTxt.SetText(webDriver, row["BillingMobilePhone"].ToString());
            if (customerCreatePage.PhoneOverrideValidation.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)))
            {
                customerCreatePage.PhoneOverrideValidation.Click(webDriver);
            }
            else
            {
                //Do nothing
            }
            customerCreatePage.BillingContacWorkPhoneTxt.SetText(webDriver, row["BillingWorkPhone"].ToString());
            customerCreatePage.BillingContactFaxTxt.SetText(webDriver, row["BillingFax"].ToString());

        }

        #endregion

        #region Billing Address Non DP Customer
        public static void BillingAddressNonDPCustomer(IWebDriver webDriver, DataRow row)
        {
            string dateTime = DateTime.Now.ToShortDateString();
            string[] splitDate = dateTime.Split('/');
            string currentMonth = splitDate[0];
            string currentDay = splitDate[1];
            string currentYear = splitDate[2];

            webDriver.WaitForBusyOverlay();
            var customerCreatePage = new CustomerCreatePage(webDriver);
            if (customerCreatePage.ElementExistValidation(customerCreatePage.LblCompany_NameBy))
            {
                webDriver.VerifyBusyOverlayNotDisplayed();
                customerCreatePage.ContactInfoCustomerClassId.PickDropdownByText(webDriver, row["CustomerClass"].ToString());
                customerCreatePage.ContactInfoCompanyNameId.SetText(webDriver, row["CompanyName"].ToString());
                customerCreatePage.ContactCompPhone.SetText(webDriver, row["CompanyPhone"].ToString());
                customerCreatePage.ContactInfoTitle.PickDropdownByText(webDriver, row["BillingTitle"].ToString());
                customerCreatePage.BillingContacMobilePhoneTxt.SetText(webDriver, row["BillingMobilePhone"].ToString());
                customerCreatePage.BillingContactInvoicingEmailTxt.SetText(webDriver, row["BillingEmail"].ToString());
                customerCreatePage.BillingContacWorkPhoneTxt.SetText(webDriver, row["BillingWorkPhone"].ToString());
                customerCreatePage.BillingContactFaxTxt.SetText(webDriver, row["BillingFaxNumber"].ToString());

                if (customerCreatePage.EmailOverride.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)))
                {
                    customerCreatePage.EmailOverride.Click(webDriver);
                }
                else
                {
                    //Do nothing
                }
                
                customerCreatePage.InvoiceDeliverMethodTxt.PickDropdownByText(webDriver, row["InvoiceDeliveryMethod"].ToString());
                customerCreatePage.InvoicePreference.PickDropdownByText(webDriver, row["InvoicePreference"].ToString());

                webDriver.WaitForElementVisible(By.Id("customerCreate_billing_contact_workPhone"), TimeSpan.FromSeconds(20));
        

                if (customerCreatePage.PhoneOverrideValidation.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)))
                {
                    customerCreatePage.PhoneOverrideValidation.Click(webDriver);
                }
                else
                {
                    //Do nothing
                }

            }
            else
            {
                customerCreatePage.ContactInfoCompanyNameId.SetText(webDriver, row["CompanyName"].ToString());
                customerCreatePage.ContactCompPhone.SetText(webDriver, row["CompanyPhone"].ToString());
                if (customerCreatePage.PhoneOverrideValidation.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)))
                {
                    customerCreatePage.PhoneOverrideValidation.Click(webDriver);
                }
                else
                {
                    //Do nothing
                }
                customerCreatePage.BillingContactInvoicingEmailTxt.SetText(webDriver, row["BillingEmail"].ToString());
                if (customerCreatePage.EmailOverride.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)))
                {
                    customerCreatePage.EmailOverride.Click(webDriver);
                }
                else
                {
                    //Do nothing
                }
                customerCreatePage.BillingContacWorkPhoneTxt.SetText(webDriver, row["BillingHomePhone"].ToString());
            }
            
            
            webDriver.VerifyBusyOverlayNotDisplayed();
            webDriver.ScrollToTop();
            //customerCreatePage.CustomerBillingCountryTxt.PickDropdownByText(webDriver, row["BillingCountry"].ToString());
            //customerCreatePage.BillingContactFaxTxt.SetText(webDriver, row["CompanyFax"].ToString());  
            customerCreatePage.BillingContactFirstNameTxt.SetText(webDriver, row["BillingFirstName"].ToString());
            customerCreatePage.BillingContactMiddleNameTxt.SetText(webDriver, row["BillingMiddle"].ToString());
            customerCreatePage.BillingContactLastNameTxt.SetText(webDriver, row["BillingLastName"].ToString());
            customerCreatePage.BillingContactDepartmentTxt.SetText(webDriver, row["BillingDepartment"].ToString());
            customerCreatePage.CustomerBillingAddressLine1Txt.SetText(webDriver, row["BillingAddressLine1"].ToString());
            customerCreatePage.CustomerBillingAddressLine2Txt.SetText(webDriver, row["BillingAddressLine2"].ToString());
            customerCreatePage.CustomerBillingZipCodeTxt.SetText(webDriver, row["BillingZip"].ToString());
            customerCreatePage.CustomerBillingZipCodeExtensionTxt.SetText(webDriver, row["BillingZipCodeExtension"].ToString());


            if (customerCreatePage.ElementExistValidation(customerCreatePage.LblInvoicingEmailBy))
            {
                customerCreatePage.BillingContactInvoicingEmailTxt.SetText(webDriver, row["BillingEmail"].ToString());
            }


        }


        #endregion


        #region Mailing Information Non DP Company

        public static void MailingInformationNonDpCompany(IWebDriver webDriver, DataRow row)
        {
            var customerCreatePage = new CustomerCreatePage(webDriver);
            customerCreatePage.MailingInfoTitle.PickDropdownByText(webDriver, row["MailingTitle"].ToString());
            customerCreatePage.MailingInfoFirstName.SetText(webDriver, row["MailingFirstName"].ToString());
            customerCreatePage.MailingInfoMiddleName.SetText(webDriver, row["MailingMiddleName"].ToString());
            customerCreatePage.MailingInfoLastName.SetText(webDriver, row["MailingLastName"].ToString());
            customerCreatePage.MailingInfoInvoicingEmail.SetText(webDriver, row["MailingInvoicingEmail"].ToString());
            customerCreatePage.MailingInfoDigitalFulfillmentEmail.SetText(webDriver, row["MailingDigitalEmail"].ToString());
            customerCreatePage.MailingInfoProSupportEmail.SetText(webDriver, row["MailingProSupportEmail"].ToString());
            customerCreatePage.MailingInfoFlexBillingEmail.SetText(webDriver, row["MailingFlexMail"].ToString());
            customerCreatePage.MailingInfoOtherEmail.SetText(webDriver, row["MailingOtherEmail"].ToString());
            customerCreatePage.MailingInfoHomePhone.SetText(webDriver, row["MailingHomePhone"].ToString());
            customerCreatePage.MailingInfoMobilePhone.SetText(webDriver, row["MailingMobilePhone"].ToString());
            customerCreatePage.MailingInfoWorkPhone.SetText(webDriver, row["MailingWorkPhone"].ToString());
            customerCreatePage.MailingInfoFaxNumber.SetText(webDriver, row["MailingFaxNumber"].ToString());
            customerCreatePage.MailingInfoAddressLine1.SetText(webDriver, row["MailingAddressLine1"].ToString());
            customerCreatePage.MailingInfoAddressLine2.SetText(webDriver, row["MailingAddressLine2"].ToString());
            customerCreatePage.MailingInfoDepartament.SetText(webDriver, row["MailingDepartament"].ToString());
            customerCreatePage.MailingInfoMailStop.SetText(webDriver, row["MailingMailStop"].ToString());
            customerCreatePage.MailingInfoCity.SetText(webDriver, row["MailingCity"].ToString());
            customerCreatePage.MailingInfoState.PickDropdownByText(webDriver, row["MailingState"].ToString());
            customerCreatePage.MailingInfoZipCode.SetText(webDriver, row["MailingZipCode"].ToString());
            customerCreatePage.MailingInfoZipExtensionCode.SetText(webDriver, row["MailingZipExtensionCode"].ToString());
            customerCreatePage.MailingInfoCountry.PickDropdownByText(webDriver, row["MailingCountry"].ToString());
        }

        #endregion

        //public static void FinancialDellPrintCustomer(IWebDriver webDriver, DataRow row)
        //{
        //    var customerCreatePage = new CustomerCreatePage(webDriver);
        //    customerCreatePage.BillingInvoicePreferenceLst.PickDropdownByText(webDriver, row["InvoicePreference"].ToString());
        //    customerCreatePage.FinancialPaymentTermId.PickDropdownByText(webDriver, row["PaymentTerm"].ToString());
        //}

        #region Financial Dell Print Customer

        public static void FinancialDellPrintCustomer(IWebDriver webDriver, DataRow row)
        {
            var customerCreatePage = new CustomerCreatePage(webDriver);
            customerCreatePage.FinancialPaymentTermId.PickDropdownByText(webDriver, row["PaymentTerm"].ToString());
        }

        #endregion

        #region Randomize Data

        public static DataRow RandomizeData(DataRow row, bool shippingSameAsBilling, bool mailingSameAsBilling, bool IsDellConsumer)
        {

            int randomNumber = DsaUtil.GetNextRnd(1, 500);
            string billingAddressNumberSuffix = Convert.ToString(randomNumber);
            string nameSuffix = Generator.RandomString(3, Generator.RandomCharacterGroup.AlphaOnly).ToUpper();
            string lastNameSuffix = Generator.RandomString(3, Generator.RandomCharacterGroup.AlphaOnly).ToUpper();

            row["BillingFirstName"] = String.Format("{0}{1}", row["BillingFirstName"], nameSuffix);
            row["BillingLastName"] = String.Format("{0}{1}", row["BillingLastName"], lastNameSuffix);
            row["BillingAddressLine1"] = String.Format("{0} {1}", billingAddressNumberSuffix, row["BillingAddressLine1"]);

            if (!IsDellConsumer)
            {
                string companyNameSuffix = Generator.RandomString(3, Generator.RandomCharacterGroup.AlphaOnly).ToUpper();
                row["CompanyName"] = String.Format("{0}{1}", row["CompanyName"], companyNameSuffix);
            }
            if (!shippingSameAsBilling)
            {
                string shippingNameSuffix = Generator.RandomString(3, Generator.RandomCharacterGroup.AlphaOnly).ToUpper();
                string shippingLastNameSuffix = Generator.RandomString(3, Generator.RandomCharacterGroup.AlphaOnly).ToUpper();
                string shippingAddressNumberSuffix = Convert.ToString(DsaUtil.GetNextRnd(1, 500));
                row["ShippingFirstName"] = String.Format("{0}{1}", row["ShippingFirstName"], shippingNameSuffix);
                row["ShippingLastName"] = String.Format("{0}{1}", row["ShippingLastName"], shippingLastNameSuffix);
                row["ShippingAddressLine1"] = String.Format("{0} {1}", shippingAddressNumberSuffix, row["ShippingAddressLine1"]);
            }
            if (!mailingSameAsBilling && !IsDellConsumer)
            {
                string mailingNameSuffix = Generator.RandomString(3, Generator.RandomCharacterGroup.AlphaOnly).ToUpper();
                string mailingLastNameSuffix = Generator.RandomString(3, Generator.RandomCharacterGroup.AlphaOnly).ToUpper();
                string mailingAddressNumberSuffix = Convert.ToString(DsaUtil.GetNextRnd(1, 500));

                row["MailingFirstName"] = String.Format("{0}{1}", row["MailingFirstName"], mailingNameSuffix);
                row["MailingLastName"] = String.Format("{0}{1}", row["MailingLastName"], mailingLastNameSuffix);
                row["MailingAddressLine1"] = String.Format("{0} {1}", mailingAddressNumberSuffix, row["MailingAddressLine1"]);
            }

            return row;
        }

        #endregion

        #region Override phone number validations

        public static void OverridePhoneNumberValidations(IWebDriver webDriver)
        {
            var customerCreatePage = new CustomerCreatePage(webDriver);

            if (!customerCreatePage.PhoneOverrideValidation.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5))
            ) return;
            var webElementList = webDriver.GetElements(By.XPath("//phone-errors//input"));

            foreach (var el in webElementList)
            {
                el.SelectCheckBox(webDriver);
            }
        }

        #endregion

        #endregion


        #region LegalCompanyNameCustomerCreation
        public static string CustomerCreationLegalCompanyName(IWebDriver webDriver, DataRow row, bool shippingSameAsBilling = true, bool mailingSameAsBilling = true, bool isDellConsumer = false, bool isVerifiedAddress = true, bool isVerifiedLegalCompanyname = true)
        {
            var customerCreatePage = new CustomerCreatePage(webDriver);
            var customerNumber = string.Empty;

            switch (isDellConsumer)
            {
                case true:
                    AddBillingAddressDellPrintCustomer(webDriver, row);
                    if (shippingSameAsBilling.Equals(false))
                    {
                        ShippingInformationNonDpCompany(webDriver, row);
                    }
                    else
                    {
                        customerCreatePage.ShippingAddressSameAdBillingChk.SelectCheckBox(webDriver);
                    }
                    FinancialDellPrintCustomer(webDriver, row);
                    customerCreatePage.BtnAddNewCustomerSave.Click(webDriver);
                    if (customerCreatePage.AddressSuggestionPopup.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)))
                    {
                        customerCreatePage.UseOriginalAddress.Click(webDriver);
                        customerCreatePage.AddShippingAddress.Click(webDriver);
                        if (customerCreatePage.CustCreateSuggestnsWithSuggestnModalId.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)))
                        {
                            customerCreatePage.BtnDupeCustModalSaveEntered.Click(webDriver);
                        }
                    }
                    webDriver.VerifyBusyOverlayNotDisplayed();
                    customerNumber = ProcessCustomerCreationPending(customerCreatePage);
                    //if (shippingSameAsBilling.Equals(false))
                    //{
                    //    customerCreatePage.UseOriginalAddress.Click(webDriver);
                    //    customerCreatePage.AddShippingAddress.Click(webDriver);
                    //}

                    break;
                case false:
                    BillingAddressNonDPCustomer(webDriver, row);
                    if (shippingSameAsBilling.Equals(false))
                    {
                        AddShippingInformation(webDriver, row);
                    }
                    else
                    {
                        customerCreatePage.ShippingAddressSameAdBillingChk.SelectCheckBox(webDriver);
                    }
                    //FinancialDellPrintCustomer(webDriver, row);
                    customerCreatePage.BtnAddNewCustomerSave.Click(webDriver);
                    if (customerCreatePage.AddressValidationPopUp.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)))
                    {
                        customerCreatePage.EnteredAddressRdBtn.Click(webDriver);
                        customerCreatePage.SaveAddressRdBtn.Click(webDriver);
                    }
                    else if (customerCreatePage.CustCreateSuggestnsWithSuggestnModalId.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)))
                    {
                        customerCreatePage.BtnDupeCustModalSaveEntered.Click(webDriver);
                    }
                    else if (customerCreatePage.AddressSuggestionPopup.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(10)))
                    {
                        customerCreatePage.UseOriginalAddress.Click(webDriver);
                        customerCreatePage.AddShippingAddress.Click(webDriver);
                    }
                    //else if (shippingSameAsBilling.Equals(false))
                    //{
                    //    customerCreatePage.UseOriginalAddress.Click(webDriver);
                    //    customerCreatePage.AddShippingAddress.Click(webDriver);
                    //}
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
                    customerNumber = ProcessCustomerCreationPending(customerCreatePage);
                    break;
            }

            return customerNumber;
        }


        public static void AddShippingInformation(IWebDriver webDriver, DataRow row)
        {
            var customerCreatePage = new CustomerCreatePage(webDriver);
            customerCreatePage.ShippingContactTitleLst.PickDropdownByText(webDriver, row["ShippingTitle"].ToString());
            customerCreatePage.ShippingContactAddressLine1Txt.SetText(webDriver, row["ShippingAddressLine1"].ToString());
            customerCreatePage.ShippingContactAddressLine2Txt.SetText(webDriver, row["ShippingAddressLine2"].ToString());
            customerCreatePage.ShippingContactDepartmentTxt.SetText(webDriver, row["ShippingDepartment"].ToString());
            customerCreatePage.ShippingContactMailStopTxt.SetText(webDriver, row["ShippingMailStop"].ToString());
            customerCreatePage.ShippingContactCityTxt.SetText(webDriver, row["ShippingCity"].ToString());
            customerCreatePage.ShippingContactStateLst.PickDropdownByText(webDriver, row["ShippingState"].ToString());
            customerCreatePage.ShippingContactZipCodeTxt.SetText(webDriver, row["ShippingZip"].ToString());
            customerCreatePage.ShippingContactzipCodeExtensionTxt.SetText(webDriver, row["ShippingZipCodeExtension"].ToString());
            customerCreatePage.ShippingContactCountryLst.PickDropdownByText(webDriver, row["ShippingCountry"].ToString());
            customerCreatePage.ShippingContactFirstNameTxt.SetText(webDriver, row["ShippingFirstName"].ToString());
            customerCreatePage.ShippingContactMiddleNameTxt.SetText(webDriver, row["ShippingMiddle"].ToString());
            customerCreatePage.ShippingContactLastNameTxt.SetText(webDriver, row["ShippingLastName"].ToString());
            customerCreatePage.ShippingEmailTxt.SetText(webDriver, row["ShippingInvoicingEmail"].ToString());
            customerCreatePage.ShippingInfoMobilePhone.SetText(webDriver, row["ShippingMobile"].ToString());

        }

        #endregion
    }
}