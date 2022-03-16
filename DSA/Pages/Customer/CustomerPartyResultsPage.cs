using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace Dsa.Pages.Customer
{
    public partial class CustomerPartyResultsPage : DsaPageBase
    {
        public CustomerPartyResultsPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }


        #region Elements

        public IWebElement CustomerPartyEditSearch { get { return WebDriver.GetElement(By.Id("customer_searchEdit_link")); } }

        public IWebElement TxtCustomerPartyEnterSearchTerm { get { return WebDriver.GetElement(By.Id("customerParty_searchFilter_value")); } }

        public IWebElement BtnCustomerPartySearch { get { return WebDriver.GetElement(By.Id("customerParty_searchAction")); } }

        public IWebElement DdlCustomerPartySearchFilter { get { return WebDriver.GetElement(By.Id("customerParty_Filter")); } }

        public IWebElement FilterButton { get { return WebDriver.GetElement(By.Id("customerParty_filterAction")); } }

        public IWebElement GridPartySearchResult { get { return WebDriver.GetElement(By.XPath("//ag-grid-angular[@class='ag-theme-balham']")); } }

        public IWebElement BtnSearchByExactMatch { get { return WebDriver.GetElement(By.XPath("//button[@id='customer_searchExact_link']")); } }

        public IWebElement TglPartylevel { get { return WebDriver.GetElement(By.CssSelector("#customerSearchResults_partyGrid > div > table > tbody > tr:nth-child(1) > td:nth-child(1) > a")); } }

        public IWebElement BtnViewAllCustomers { get { return WebDriver.GetElement(By.XPath(@"//*[contains(@class, 'ag-full-width-container')]/div[1]/results-grid-row-renderer/div/div[1]/div[6]/a")); } }

        public IWebElement LnkCustomerNumber { get { return WebDriver.GetElement(By.XPath(@"//*[contains(@class, 'ag-full-width-container')]/div[1]/results-grid-row-renderer/div/div[2]/table/tbody/tr[2]/td[2]/a")); } }

        public IWebElement customerDetailsCustomerNum { get { return WebDriver.GetElement(By.Id("customerDetails_customerNum")); } }

        public IWebElement LnkCompany { get { return WebDriver.GetElement(By.XPath(@"//*[contains(@class, 'ag-full-width-container')]/div[1]/results-grid-row-renderer/div/div[2]/table/tbody/tr[2]/td[2]/a")); } }

        public IWebElement LnkCompanyNumber { get { return WebDriver.GetElement(By.XPath(@"//*[contains(@class, 'ag-full-width-container')]/div[1]/results-grid-row-renderer/div/div[2]/table/tbody/tr[2]/td[3]/a")); } }

        public IWebElement LblCompanyCol { get { return WebDriver.GetElement(By.XPath(@"//*[contains(@class, 'ag-full-width-container')]/div[1]/results-grid-row-renderer/div/div[1]/div[2]")); } }

        public IWebElement LblContactNameCol { get { return WebDriver.GetElement(By.XPath(@"//*[contains(@class, 'ag-full-width-container')]/div[1]/results-grid-row-renderer/div/div[1]/div[3]")); } }

        public IWebElement LblAddressCol { get { return WebDriver.GetElement(By.XPath(@"//*[contains(@class, 'ag-full-width-container')]/div[1]/results-grid-row-renderer/div/div[1]/div[4]")); } }

        public IWebElement CustomerExpandBtn { get { return WebDriver.GetElement(By.XPath(@"//*[contains(@class, 'ag-full-width-container')]/div[1]/results-grid-row-renderer/div/div[1]/div[1]/a")); } }
     
        public IWebElement LnkViewAllCustomersCustomerId { get { return WebDriver.GetElement(By.XPath(@"//*[contains(local-name(), 'app-grid-hyperlink-cell-renderer')][1]/a")); } }
        #endregion

        /// <summary>
        /// Selects the customer party from table.
        /// </summary>
        /// <param name="party">The party.</param>
        /// <returns></returns>
        public CustomerSearchResultsPage SelectCustomerPartyFromTable(string party)
        {
            By.LinkText(party).Click(WebDriver);
            return new CustomerSearchResultsPage(WebDriver);
        }

        public CustomerSearchResultsPage SelectFirstCustomerPartyFromTable()
        {
            CustomerExpandBtn.Click(WebDriver);
            LnkCustomerNumber.Click(WebDriver);
            return new CustomerSearchResultsPage(WebDriver);
        }

        public CustomerPartyResultsPage PartyLevelTglClick()
        {
            TglPartylevel.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public CustomerPartyResultsPage ViewAllCustomerClick()
        {
            BtnViewAllCustomers.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }


        public CustomerPartyResultsPage FilterBy(string filterBy, string companyName)
        {
            DdlCustomerPartySearchFilter.PickDropdownByText(WebDriver, filterBy);
            TxtCustomerPartyEnterSearchTerm.SetText(WebDriver, companyName);
            FilterButton.Click(WebDriver);
            return new CustomerPartyResultsPage(WebDriver);
        }

        public string CompanyName()
        {
            return LnkCompany.Text;
        }

        public string CustomerNumber()
        {
            return customerDetailsCustomerNum.Text;
        }

        //public CustomerDetailsPage PartyLevelCutomerClk()
        //{
        //    LnkCustomerNumber.Click(WebDriver);
        //    return new CustomerDetailsPage(WebDriver);
        //}     
        //public CustomerDetailsPage PartyLevelCompanyClk()
        //{
        //    LnkCompany.Click(WebDriver);
        //    return new CustomerDetailsPage(WebDriver);
        //}       

        //public CustomerDetailsPage PartyLevelCompanyNumberClk()
        //{
        //    LnkCompanyNumber.Click(WebDriver);
        //    return new CustomerDetailsPage(WebDriver);
        //}   


        /// <summary>
        /// Gets the customer party list.
        /// </summary>
        /// <returns></returns>
        public List<Dictionary<string, object>> GetCustomerPartyList()
        {
            return GridPartySearchResult.GetGridData(WebDriver);
        }

        /// <summary>
        /// Validates this instance by checking that the page title is displayed and that it matches 
        /// the title as stored in the associated resource file.
        /// </summary>
        /// <returns><c>true</c> if the page title is displayed and is the correct value, 
        /// <c>false</c> otherwise.</returns>
        public override bool Validate()
        {
            return CustomerPartyEditSearch.Displayed;
        }

        /// <summary>
        /// Determines whether this instance is active.
        /// </summary>
        /// <returns><c>true</c> if this instance is active; otherwise, <c>false</c>.</returns>
        public override bool IsActive()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return (WebDriver.Url.Contains("/customer/partysearchresults"));
        }

        public void EditSearch()
        {
            CustomerPartyEditSearch.Click(WebDriver);
        }

        public void SelectFirstCustomerFromViewAllCustomers()
        {
            BtnViewAllCustomers.Click(WebDriver);
            LnkViewAllCustomersCustomerId.Click(WebDriver);
        }

    }
}
