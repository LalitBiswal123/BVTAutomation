using System;
using System.Collections.Generic;
using Dsa.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Dsa.Pages.Customer
{
    public class PersonSearchPage : DsaPageBase
    {
        public PersonSearchPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements
        
        public IWebElement TxtCustomerFirstName { get { return WebDriver.GetElement(By.Id("customerSearch_contactFirstName")); } }

        public IWebElement TxtCustomerLastName { get { return WebDriver.GetElement(By.Id("customerSearch_contactLastName")); } }

        public IWebElement TxtCustomerCompanyName { get { return WebDriver.GetElement(By.XPath("//*[@id='customerSearch_companyName'")); } }

        public IWebElement TxtCustomerEmail { get { return WebDriver.GetElement(By.Id("customerSearch_email")); } }

        public IWebElement TxtCustomerPhoneNumber { get { return WebDriver.GetElement(By.Id("customerSearch_phoneNumber")); } }

        //public IWebElement TxtCustomerNumber { get { return WebDriver.GetElement(By.Id("customerSearch_customerNumber")); } }
        public IWebElement TxtCustomerNumber { get { return WebDriver.GetElement(By.Id("uniqueIdSearch_customerNumber")); } }
        public IWebElement TxtCustomerNumber_Reseller { get { return WebDriver.GetElement(By.Id("uniqueIdSearch_customerNumber")); } }       

        public IWebElement CurrencyOptions { get { return WebDriver.GetElement(By.XPath("//*[@id='customerSearch_curreny']")); } }

        public IWebElement TxtCustomerOrderNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='customerSearch_orderNumber']")); } }

        public IWebElement TxtCustomerDPID { get { return WebDriver.GetElement(By.Id("customerSearch_DPIDNumber")); } }

        public IWebElement TxtCustomerQuoteNumber { get { return WebDriver.GetElement(By.Id("customerSearch_QuoteNumber")); } }

        public IWebElement UniqueIdentiferSearch { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/div/div[2]")); } }

        public IWebElement TxtAddressLine1 { get { return WebDriver.GetElement(By.Id("customerSearch_addrLineOne")); } }

        public IWebElement ValidCombinationsLink { get { return WebDriver.GetElement(By.Id("customerSearch_viewCombinationSearch")); } }

        public IWebElement LblAddressLine1 { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Address Line 1')]")); } }

        public IWebElement AddressLineVerbiage { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'To Search by Address Line 1, First Name and Last Name are required.')]")); } }

        public IWebElement VerbiageCloseBtn { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Close')]")); } }

        public IWebElement BtnCustomerSearch { get { return WebDriver.GetElement(By.Id("customerSearch_searchAction")); } }
        public IWebElement BtnCustomerSearch_Reseller { get { return WebDriver.GetElement(By.Id("uniqueIdSearch_uniqueIdSearch")); } }
        
        public IWebElement BtnCustomerClear { get { return WebDriver.GetElement(By.Id("customerSearch_clearAction")); } }

        public IWebElement ChkBoxCustomerExactMatches { get { return WebDriver.GetElement(By.Id("customerSearch_ExactMatches")); } }

        public IWebElement InvalidCustomerSearchErrorMessage1 { get { return WebDriver.GetElement(By.Id("noResults_Apology_Bold")); } }

        public IWebElement InvalidCustomerSearchErrorMessage2 { get { return WebDriver.GetElement(By.Id("noResults_returnPrevious_partPre")); } }

        public IWebElement InvalidCustomerSearchErrorMessage3 { get { return WebDriver.GetElement(By.Id("common_noResults_link")); } }

        public IWebElement InvalidCustomerSearchErrorMessage4 { get { return WebDriver.GetElement(By.Id("noResults_returnPrevious_partPost")); } }

        public IWebElement DdlOrganizationComanyNumber { get { return WebDriver.GetElement(By.Id("customerSearch_salesChannel")); } }

        public IWebElement CurrencyLabel { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Currency')]")); } }

        #endregion

        public CustomerDetailsPage SearchPersonByCustomerNumber(string customerNumber)
        {
            TxtCustomerNumber.SetText(WebDriver, customerNumber);
            BtnCustomerSearch.Click(WebDriver);
            return new CustomerDetailsPage(WebDriver);
        }

        public CustomerDetailsPage SearchPersonByCustomerNumber_Reseller(string customerNumber)
        {
            TxtCustomerNumber_Reseller.SetText(WebDriver, customerNumber);
            BtnCustomerSearch_Reseller.Click(WebDriver);
            return new CustomerDetailsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerPartyBySalesChannel(string CompanyNumber, string phoneNumber)
        {
            TxtCustomerPhoneNumber.SetText(WebDriver, phoneNumber);
            DdlOrganizationComanyNumber.PickDropdownByText(WebDriver, CompanyNumber);
            BtnCustomerSearch.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerPartyBySalesChannelLN(string CompanyNumber, string LastName)
        {
            TxtCustomerLastName.SetText(WebDriver, LastName);
            DdlOrganizationComanyNumber.PickDropdownByText(WebDriver, CompanyNumber);
            BtnCustomerSearch.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerPartyByCurrency(string Currency, string FirstName, string LastName)
        {
            TxtCustomerLastName.SetText(WebDriver, LastName);
            TxtCustomerFirstName.SetText(WebDriver, FirstName);
            CurrencyOptions.PickDropdownByText(WebDriver, Currency);
            BtnCustomerSearch.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerByAddressLineAndNames(string FirstName, string LastName, string AddressLine)
        {
            TxtCustomerFirstName.SetText(WebDriver, FirstName);
            TxtCustomerLastName.SetText(WebDriver, LastName);
            TxtAddressLine1.SetText(WebDriver, AddressLine);
            BtnCustomerSearch.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerByAddressLineAndLastName(string LastName, string AddressLine)
        {            
            TxtCustomerLastName.SetText(WebDriver, LastName);
            TxtAddressLine1.SetText(WebDriver, AddressLine);
            BtnCustomerSearch.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerByAddressLineAndEmail(string AddressLine, string Email)
        {
            TxtAddressLine1.SetText(WebDriver, AddressLine);
            TxtCustomerEmail.SetText(WebDriver, Email);
            BtnCustomerSearch.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerByAddressLineAndPhoneNumber(string AddressLine, string PhoneNumber)
        {
            TxtAddressLine1.SetText(WebDriver, AddressLine);
            TxtCustomerPhoneNumber.SetText(WebDriver, PhoneNumber);
            BtnCustomerSearch.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }       

        public PersonSearchPage GetAllOptionsFromDropDown(IWebElement element, int count)
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
            return new PersonSearchPage(WebDriver);
        }


        /// <summary>
        /// Validates this instance by checking that the page title is displayed and that it matches 
        /// the title as stored in the associated resource file.
        /// </summary>
        /// <returns><c>true</c> if the page title is displayed and is the correct value, 
        /// <c>false</c> otherwise.</returns>

        public override bool Validate()
        {
            return TxtCustomerNumber.Displayed;
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

        public PersonSearchPage GetUniqueIdentiferResults(IWebDriver webDriver)
        {
            bool isDisabled = Validate();
            Assert.IsTrue(isDisabled, "Customer text box is disabled");
            bool isDisabledOrder = IsOrderNumberEnabled();
            Assert.IsFalse(isDisabledOrder, "Customer OrderTextBox Disabled");
            bool isDisabledDPID = IsDPIDEnabled();
            Assert.IsFalse(isDisabledDPID, "Customer OrderTextBox Disabled");
            bool isDisabledQuotenumber = IsQuoteNumEnabled();
            Assert.IsFalse(isDisabledQuotenumber, "Customer OrderTextBox Disabled");
            return new PersonSearchPage(WebDriver);

        }
       

        // <summary>
        /// Determines whether this instance is active.
        /// </summary>
        /// <returns><c>true</c> if this instance is active; otherwise, <c>false</c>.</returns>
        public override bool IsActive()
        {
            //WebDriver.WaitFor(dr => dr.GetElement(_byCustomerNumberTxt).Displayed);
            return (WebDriver.Url.Contains("customer2/person/search/"));
        }



        #region Commented out code ----> **** commenting out the below as this is handled in the new Customer Search page *****


        //public CustomerDetailsPage SearchCustomerByDpid(string dpId)
        //{
        //    TxtCustomerDPID.SetText(WebDriver, dpId);
        //    BtnCustomerSearch.Click(WebDriver);
        //    return new CustomerDetailsPage(WebDriver);
        //}

        ///// <summary>
        ///// Searches the customer by order number.
        ///// </summary>
        ///// <param name="driver">The driver.</param>
        ///// <param name="orderNumber">The order number.</param>
        ///// <returns></returns>
        //public CustomerDetailsPage SearchCustomerByOrderNumber(string orderNumber)
        //{
        //    TxtCustomerOrderNumber.SetText(WebDriver, orderNumber);
        //    BtnCustomerSearch.Click(WebDriver);
        //    return new CustomerDetailsPage(WebDriver);
        //}

        ///// <summary>
        ///// Searches the customer by quote number.
        ///// </summary>
        ///// <param name="driver">The driver.</param>
        ///// <param name="quoteNumber">The quote number.</param>
        ///// <returns></returns>
        //public CustomerDetailsPage SearchCustomerByQuoteNumber(string quoteNumber)
        //{
        //    TxtCustomerQuoteNumber.SetText(WebDriver, quoteNumber);
        //    BtnCustomerSearch.Click(WebDriver);
        //    return new CustomerDetailsPage(WebDriver);
        //}


        #endregion


        public CustomerPartyResultsPage SearchCustomerPartyByEmail(string email)
        {
            TxtCustomerEmail.SetText(WebDriver, email);
            BtnCustomerSearch.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerPartyByPhoneNumber(string phoneNumber)
        {
            TxtCustomerPhoneNumber.SetText(WebDriver, phoneNumber);
            BtnCustomerSearch.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerByFirstNameLastName(string firstName, string lastName)
        {
            TxtCustomerFirstName.SetText(WebDriver, firstName);
            TxtCustomerLastName.SetText(WebDriver, lastName);
            BtnCustomerSearch.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public PersonSearchPage customerfirstlastname(string firstName,string lastName)
        {
            TxtCustomerFirstName.SetText(WebDriver, firstName);
            TxtCustomerLastName.SetText(WebDriver, lastName);
            return  new PersonSearchPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerByLastName(string lastName)
        {

            TxtCustomerLastName.SetText(WebDriver, lastName);
            BtnCustomerSearch.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }


        

        public PersonSearchPage customerCompanyName(string CompnyName)
        {
            TxtCustomerCompanyName.SetText(WebDriver, CompnyName);
            
            return new PersonSearchPage(WebDriver);
        }
    }
}
