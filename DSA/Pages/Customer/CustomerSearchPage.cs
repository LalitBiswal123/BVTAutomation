using System;
using System.Collections.Generic;
using Dsa.Utils;
using Dsa.Workflows;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Dsa.Pages.Customer
{
    public class CustomerSearchPage : DsaPageBase
    {
        public CustomerSearchPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }



        #region Elements

        //  public IWebElement TxtCustomerNumber { get { return WebDriver.GetElement(By.Id("uniqueIdSearch_customerNumber")); } }

        public IWebElement TxtCustomerNumber { get { return WebDriver.GetElement(By.XPath("//input[@id='uniqueIdSearch_customerNumber']")); } }
        public IWebElement TxtQuoteNumber { get { return WebDriver.GetElement(By.Id("uniqueIdSearch_QuoteNumber")); } }

        public IWebElement TxtOrderNumber { get { return WebDriver.GetElement(By.Id("uniqueIdSearch_orderNumber")); } }

        public IWebElement TxtDPIDNumber { get { return WebDriver.GetElement(By.Id("uniqueIdSearch_DPIDNumber")); } }

        public IWebElement TxtUCIDNumber { get { return WebDriver.GetElement(By.Id("uniqueIdSearch_UCID")); } }

        public IWebElement UniqueFindCustomer { get { return WebDriver.GetElement(By.Id("uniqueIdSearch_uniqueIdSearch")); } }

        public IWebElement ExpandAdvanceSearch { get { return WebDriver.GetElement(By.XPath("//a[contains(text(),'Advanced Search')]")); } }

        public IWebElement CollapseExpAdvSearch { get { return WebDriver.GetElement(By.XPath("//a[@class='k-icon expandRowPromise k-i-arrow-s']")); } }

        public IWebElement TxtEmailID { get { return WebDriver.GetElement(By.Id("advancedSearch_email")); } }

        public IWebElement TxtComapnyName { get { return WebDriver.GetElement(By.Id("advancedSearch_companyName")); } }

        public IWebElement TxtZipCode { get { return WebDriver.GetElement(By.Id("advancedSearch_zip")); } }

        public IWebElement TxtState { get { return WebDriver.GetElement(By.Id("advancedSearch_state")); } }

        public IWebElement TxtPhoneNumber { get { return WebDriver.GetElement(By.Id("advancedSearch_phoneNumber")); } }

        public IWebElement TxtFirstName { get { return WebDriver.GetElement(By.Id("advancedSearch_contactFirstName")); } }

        public IWebElement TxtLastName { get { return WebDriver.GetElement(By.Id("advancedSearch_contactLastName")); } }

        public IWebElement TxtAddressType { get { return WebDriver.GetElement(By.Id("advancedSearch_addressType")); } }

        public IWebElement TxtCustomerType { get { return WebDriver.GetElement(By.Id("advancedSearch_salesChannel")); } }

        public IWebElement AdvanceSearchFindCustomer { get { return WebDriver.GetElement(By.Id("advancedSearch_searchAction")); } }

        public IWebElement TxtAddressline1 { get { return WebDriver.GetElement(By.Id("advancedSearch_addressLine1")); } }

        public IWebElement TxtCity { get { return WebDriver.GetElement(By.Id("advancedSearch_city")); } }

        public IWebElement AdvanceSearchCompanyNameValidation { get { return WebDriver.GetElement(By.Id("advancedSearch_validationIcon_companyName")); } }

        public IWebElement SmartSearchInput { get { return WebDriver.GetElement(By.Id("smartSearchInput")); } }

        public IWebElement SmartSearchSubmit { get { return WebDriver.GetElement(By.Id("smartSearch_Submit")); } }

        public IWebElement InvalidCustomerSearchErrorMessage1 { get { return WebDriver.GetElement(By.Id("noResults_Apology_Bold")); } }

        public IWebElement InvalidCustomerSearchErrorMessage2 { get { return WebDriver.GetElement(By.Id("noResults_returnPrevious_partPre")); } }

        public IWebElement InvalidCustomerSearchErrorMessage3 { get { return WebDriver.GetElement(By.Id("common_noResults_link")); } }

        public IWebElement InvalidCustomerSearchErrorMessage4 { get { return WebDriver.GetElement(By.Id("noResults_returnPrevious_partPost")); } }

        public IWebElement NoItemsInTheListForInavalidUCID { get { return WebDriver.GetElement(By.XPath("//div[@class='ag-center-cols-container']")); } }

        public IWebElement UCIDContainsNoUCIDNuberForInavalidUCID { get { return WebDriver.GetElement(By.XPath("//div[@id='main']/div[1]/div[1]/div[2]")); } }

        public IWebElement UniqueCustomerNumber { get { return WebDriver.GetElement(By.Id("customerSearch_customerNumber")); } }

        public IWebElement QuickSearchField { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/div/div[1]/smart-search/form")); } }


        #endregion

        //Unique Identifier Search 

        public CustomerDetailsPage SearchCustomerByCustomerNumber(string customerNumber)
        {
            TxtCustomerNumber.SetText(WebDriver, customerNumber);
            UniqueFindCustomer.Click(WebDriver);

            return new CustomerDetailsPage(WebDriver);
        }



        public CustomerDetailsPage SearchCustomerByQuoteNumber(string quoteNumber)
        {
            TxtQuoteNumber.SetText(WebDriver, quoteNumber);
            UniqueFindCustomer.Click(WebDriver);

            return new CustomerDetailsPage(WebDriver);
        }


        public CustomerDetailsPage SearchCustomerByOrderNumber(string orderNumber)
        {
            TxtOrderNumber.SetText(WebDriver, orderNumber);
            UniqueFindCustomer.Click(WebDriver);
            return new CustomerDetailsPage(WebDriver);
        }

        public CustomerDetailsPage SearchCustomerByDpid(string dpId)
        {
            TxtDPIDNumber.SetText(WebDriver, dpId);
            UniqueFindCustomer.Click(WebDriver);
            return new CustomerDetailsPage(WebDriver);
        }

        public CustomerSearchResultsPage SearchCustomerByUCID(string UCID)
        {

            TxtUCIDNumber.SetText(WebDriver, UCID);
            // UniqueFindCustomer.Click(WebDriver, TimeSpan.FromSeconds(10));
            UniqueFindCustomer.Submit();
            return new CustomerSearchResultsPage(WebDriver);
        }

        public CustomerSearchPage FindCustomerByCustomerNumber(string customerNumber)
        {
            TxtCustomerNumber.SetText(WebDriver, customerNumber);

            return new CustomerSearchPage(WebDriver);

        }


        //Advance search 


        public CustomerPartyResultsPage SearchCustomerByEmail(string email)
        {
            ExpandAdvanceSearch.Click(WebDriver);
            TxtEmailID.SetText(WebDriver, email);
            AdvanceSearchFindCustomer.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerSearchResultsPage SearchCustomerByCompanyName(string companyName)
        {
            // ExpandAdvanceSearch.Click(WebDriver);
            TxtComapnyName.SetText(WebDriver, companyName);
            DsaUtil.WaitForPageLoad(WebDriver);
            AdvanceSearchFindCustomer.Click(WebDriver);
            return new CustomerSearchResultsPage(WebDriver);
        }

        public CustomerSearchPage SearchCustomerByCompanyNameandAddressline(string companyName, string addressline1)
        {
            ExpandAdvanceSearch.Click(WebDriver);
            TxtComapnyName.SetText(WebDriver, companyName);
            TxtAddressline1.SetText(WebDriver, addressline1);

            return new CustomerSearchPage(WebDriver);
        }

        public CustomerSearchPage SearchCustomerByCompNameInvalidZipCodeTxt(string zipcode, string companyName)
        {
            //ExpandAdvanceSearch.Click(WebDriver);
            TxtComapnyName.SetText(WebDriver, companyName);
            TxtZipCode.SetText(WebDriver, zipcode);

            return new CustomerSearchPage(WebDriver);
        }

        public CustomerSearchPage SearchByContactName(string contactName)
        {

            SmartSearchInput.SetText(WebDriver, contactName);

            SmartSearchSubmit.Click(WebDriver);
            return new CustomerSearchPage(WebDriver);
        }

        public CustomerDetailsPage GetAllOptionsFromDropDown(IWebElement element, int count)
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
            else
            {

                Assert.Fail("Count doesn't match.");
            }
            return new CustomerDetailsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerByStateAndCompanyName(string state, string companyName)
        {
            TxtComapnyName.SetText(WebDriver, companyName);
            TxtState.PickDropdownByText(WebDriver, state);
            AdvanceSearchFindCustomer.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerByCityAndCompanyName(string city, string companyName)
        {
            TxtComapnyName.SetText(WebDriver, companyName);
            TxtCity.SetText(WebDriver, city);
            AdvanceSearchFindCustomer.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerByZip(string zip, string companyName)
        {
            TxtComapnyName.SetText(WebDriver, companyName);
            TxtZipCode.SetText(WebDriver, zip);
            AdvanceSearchFindCustomer.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerByCompanyname(string companyName)
        {
            TxtComapnyName.SetText(WebDriver, companyName);
            AdvanceSearchFindCustomer.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerByPhoneNumber(string phoneNumber)
        {
            TxtPhoneNumber.SetText(WebDriver, phoneNumber);
            AdvanceSearchFindCustomer.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerPartyResultsPage SearchCustomerByFirstNameAndLastName(string firstName, string lastName)
        {
            TxtFirstName.SetText(WebDriver, firstName);
            TxtLastName.SetText(WebDriver, lastName);
            AdvanceSearchFindCustomer.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }
        public CustomerPartyResultsPage SearchCustomerByEmailID(string email)
        {
            TxtEmailID.SetText(WebDriver, email);
            AdvanceSearchFindCustomer.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

    }
}
