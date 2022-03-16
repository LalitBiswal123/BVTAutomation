using Dsa.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace Dsa.Pages.Customer
{
    public class OrganizationSearchPage : DsaPageBase
    {
        public OrganizationSearchPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements

        public IWebElement TxtOrganizationCompanyName { get { return WebDriver.GetElement(By.Id("customerSearch_companyName")); } }

        public IWebElement TxtOrganizationPhoneNumber { get { return WebDriver.GetElement(By.Id("customerSearch_phoneNumber")); } }

        public IWebElement TxtOrganizationCity { get { return WebDriver.GetElement(By.Id("customerSearch_city")); } }

        public IWebElement DdlOrganizationState { get { return WebDriver.GetElement(By.Id("customerSearch_state")); } }

        public IWebElement DdlOrganizationComanyNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='customerSearch_salesChannel']")); } }

        public IWebElement CurrencyOptions { get { return WebDriver.GetElement(By.XPath("//*[@id='customerSearch_curreny']")); } }

        public IWebElement CurrencyLabel { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/div/div[1]/div[9]/label")); } }

        public IWebElement TxtOrganizationZip { get { return WebDriver.GetElement(By.Id("customerSearch_zip")); } }

        public IWebElement TxtOrganizationCustomerNumber { get { return WebDriver.GetElement(By.Id("customerSearch_customerNumber")); } }

        public IWebElement TxtOrganizationOrderNumber { get { return WebDriver.GetElement(By.Id("customerSearch_orderNumber")); } }

        public IWebElement TxtOrganizationDPID { get { return WebDriver.GetElement(By.Id("customerSearch_DPIDNumber")); } }

        public IWebElement TxtOrganizationQuoteNumber { get { return WebDriver.GetElement(By.Id("customerSearch_QuoteNumber")); } }

        public IWebElement TxtAffinityAccountIdOrg { get { return WebDriver.GetElement(By.Id("customerSearch_AffinityAccountID")); } }

        public IWebElement ChkOrganizaitonExactMatches { get { return WebDriver.GetElement(By.Id("customerSearch_ExactMatches")); } }

        public IWebElement BtnOrganizationSearch { get { return WebDriver.GetElement(By.Id("customerSearch_searchAction")); } }

        public IWebElement BtnOrganizationClear { get { return WebDriver.GetElement(By.Id("customerSearch_clearAction")); } }

        public IWebElement AddressTypeDropdown { get { return WebDriver.GetElement(By.Id("customerSearch_addressType")); } }

        public IWebElement TxtCustomerOrderNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='customerSearch_orderNumber'")); } }

        public IWebElement CreditStatusBanner { get { return WebDriver.GetElement(By.Id("customerDetails_creditHoldWarningMessage")); } }

        public IWebElement TxtCustomerNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='customerSearch_customerNumber']")); } }

        public IWebElement LblAddressLine1 { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Address Line 1')]")); } }

        public IWebElement TxtAddressLine1 { get { return WebDriver.GetElement(By.Id("customerSearch_addrLineOne")); } }

        public IWebElement ValidCombinationsLink { get { return WebDriver.GetElement(By.Id("customerSearch_viewCombinationSearch")); } }

        public IWebElement AddressLineVerbiage { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'To Search by Address Line 1, Company Name is required.')]")); } }

        public IWebElement VerbiageCloseBtn { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Close')]")); } }

        public IWebElement TxtCustomerDPID { get { return WebDriver.GetElement(By.Id("customerSearch_DPIDNumber")); } }

        public IWebElement TxtCustomerQuoteNumber { get { return WebDriver.GetElement(By.Id("customerSearch_QuoteNumber")); } }

        public IWebElement InvalidCustomerSearchErrorMessage1 { get { return WebDriver.GetElement(By.Id("noResults_Apology_Bold")); } }

        public IWebElement InvalidCustomerSearchErrorMessage2 { get { return WebDriver.GetElement(By.Id("noResults_returnPrevious_partPre")); } }

        public IWebElement InvalidCustomerSearchErrorMessage3 { get { return WebDriver.GetElement(By.Id("common_noResults_link")); } }

        public IWebElement InvalidCustomerSearchErrorMessage4 { get { return WebDriver.GetElement(By.Id("noResults_returnPrevious_partPost")); } }
        #endregion

        /// <summary>
        /// Validates this instance by checking that the page title is displayed and that it matches 
        /// the title as stored in the associated resource file.
        /// </summary>
        /// <returns><c>true</c> if the page title is displayed and is the correct value, 
        /// <c>false</c> otherwise.</returns>

        public override bool Validate()
        {
            return TxtOrganizationCustomerNumber.Displayed;
        }
        /// <summary>
        /// Determines whether this instance is active.
        /// </summary>
        /// <returns><c>true</c> if this instance is active; otherwise, <c>false</c>.</returns>
        public override bool IsActive()
        {
            //WebDriver.WaitFor(dr => dr.GetElement(_byCustomerNumberTxt).Displayed);
            return (WebDriver.Url.Contains("/customer2/organization/search/"));
        }

        public CustomerPartyResultsPage SearchCustomerPartyByZip(string zip, string companyName)
        {
            TxtOrganizationCompanyName.SetText(WebDriver, companyName);
            TxtOrganizationZip.SetText(WebDriver, zip);
            BtnOrganizationSearch.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerPartyByState(string state, string companyName)
        {
            TxtOrganizationCompanyName.SetText(WebDriver, companyName);
            DdlOrganizationState.PickDropdownByText(WebDriver, state);
            BtnOrganizationSearch.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }


        public CustomerPartyResultsPage SearchCustomerPartyByCompanyNumber(string CompanyNumber, string companyName)
        {
            TxtOrganizationCompanyName.SetText(WebDriver, companyName);
            DdlOrganizationComanyNumber.PickDropdownByText(WebDriver, CompanyNumber);
            BtnOrganizationSearch.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerPartyByCity(string city, string companyName)
        {
            TxtOrganizationCompanyName.SetText(WebDriver, companyName);
            TxtOrganizationCity.SetText(WebDriver, city);
            BtnOrganizationSearch.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerPartyByCompanyname(string companyName)
        {
            TxtOrganizationCompanyName.SetText(WebDriver, companyName);
            BtnOrganizationSearch.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerPartyByCompanyNameAndAddressType(string companyName,string type)
        {
            TxtOrganizationCompanyName.SetText(WebDriver, companyName);
            AddressTypeDropdown.PickDropdownByText(WebDriver, type);
            BtnOrganizationSearch.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerDetailsPage SearchPersonByCustomerNumber(string customerNumber)
        {
            TxtOrganizationCustomerNumber.SetText(WebDriver, customerNumber);
            BtnOrganizationSearch.Click(WebDriver);
            return new CustomerDetailsPage(WebDriver);
        }

        public CustomerDetailsPage SearchCustomerByDpid(string dpId)
        {
            TxtOrganizationDPID.SetText(WebDriver, dpId);
            BtnOrganizationSearch.Click(WebDriver);
            return new CustomerDetailsPage(WebDriver);
        }

        public CustomerDetailsPage SearchCustomerByOrderNumber(string orderNumber)
        {
            TxtOrganizationOrderNumber.SetText(WebDriver, orderNumber);
            BtnOrganizationSearch.Click(WebDriver);
            return new CustomerDetailsPage(WebDriver);
        }

        public CustomerDetailsPage SearchCustomerByQuoteNumber(string quoteNumber)
        {
            TxtOrganizationQuoteNumber.SetText(WebDriver, quoteNumber);
            BtnOrganizationSearch.Click(WebDriver);
            return new CustomerDetailsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerPartyByPhoneNumber(string phoneNumber)
        {
            TxtOrganizationPhoneNumber.SetText(WebDriver, phoneNumber);
            BtnOrganizationSearch.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }


        public OrganizationSearchPage salesChannel(string CompanyNumber)
        {
            DdlOrganizationComanyNumber.PickDropdownByText(WebDriver, CompanyNumber);

            return new OrganizationSearchPage(WebDriver);
        }

        public OrganizationSearchPage currency(string phoneNumber)
        {
            CurrencyOptions.PickDropdownByText(WebDriver, phoneNumber);

            return new OrganizationSearchPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerByAddressLineAndPhoneNumber(string AddressLine, string PhoneNumber)
        {
            TxtAddressLine1.SetText(WebDriver, AddressLine);
            TxtOrganizationPhoneNumber.SetText(WebDriver, PhoneNumber);
            BtnOrganizationSearch.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerByAddressLineAndCompanyName(string CompanyName, string AddressLine)
        {
            TxtOrganizationCompanyName.SetText(WebDriver, CompanyName);
            TxtAddressLine1.SetText(WebDriver, AddressLine);
            BtnOrganizationSearch.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public bool IsCustomerNumberEnabled()
        {
            return TxtCustomerNumber.Enabled;
        }


        public bool IsOrderNumberEnabled()
        {
            return TxtCustomerOrderNumber.Enabled;
        }

        public bool IsDPIDEnabled()
        {
            return TxtCustomerDPID.Enabled;
        }

        public bool IsQuoteNumEnabled()
        {
            return TxtCustomerQuoteNumber.Enabled;
        }
        public OrganizationSearchPage GetUniqueIdentiferResults(IWebDriver webDriver)
        {
            bool isDisabled = IsCustomerNumberEnabled();
            Assert.IsFalse(isDisabled, "Customer text box is disabled");
            bool isDisabledOrder = IsOrderNumberEnabled();
            Assert.IsFalse(isDisabledOrder, "Customer OrderTextBox Disabled");
            bool isDisabledDPID = IsDPIDEnabled();
            Assert.IsFalse(isDisabledDPID, "Customer OrderTextBox Disabled");
            bool isDisabledQuotenumber = IsQuoteNumEnabled();
            Assert.IsFalse(isDisabledQuotenumber, "Customer OrderTextBox Disabled");
            return new OrganizationSearchPage(WebDriver);

        }

        public OrganizationSearchPage GetAllOptionsFromDropDown(IWebElement element, int count)
        {
            SelectElement select = new SelectElement(element);
            IList<IWebElement> list = select.Options;
            var total = list.Count;
            if (total.Equals(count))
            {
                foreach (var item in list)
                {
                    Logger.Write(item.GetText(WebDriver));
                }

            }
            return new OrganizationSearchPage(WebDriver);
        }


    }
}
