using Dell.Adept.UI.Web.Pages;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Account
{
    public class AccountSearchPage : DsaPageBase
    {
        public AccountSearchPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region -- Elements

        public IWebElement TxtAccountName { get { return WebDriver.GetElement(By.Id("accountSearch_accountName")); } }

        public IWebElement TxtAccountNumber { get { return WebDriver.GetElement(By.Id("accountSearch_accountNumber")); } }

        public IWebElement TxtSfdcDealId { get { return WebDriver.GetElement(By.Id("accountSearch_sfdcDealID")); } }

        public IWebElement TxtCustomerNumber { get { return WebDriver.GetElement(By.Id("accountSearch_customerNumber")); } }

        public IWebElement BtnSearch { get { return WebDriver.GetElement(By.Id("accountSearch_searchButton")); } }

        #endregion

        #region Methods

        /// <summary>
        /// Executes the search.
        /// </summary>
        /// <param name="isDeterministicSearch">if set to <c>true</c> [is deterministicearch].</param>
        /// <returns></returns>
        public IPage ExecuteSearch(IWebDriver driver, bool isDeterministicSearch = true)
        {
            BtnSearch.Click(driver);
            driver.VerifyBusyOverlayNotDisplayed();
            if (isDeterministicSearch)
                return new AccountDetailsPage(WebDriver);
            return new AccountSearchResultsPage(WebDriver);
        }

        #endregion

        // Search PAM Accounts
        public AccountDetailsPage SearchPAMAccount(string searchType, string text)
        {
            if(searchType == "AccountNumber")
            {
                TxtAccountNumber.SetText(WebDriver, text);
                BtnSearch.Click(WebDriver);
            }
            else if (searchType == "CustomerNumber")
            {
                TxtCustomerNumber.SetText(WebDriver, text);
                BtnSearch.Click(WebDriver);
            }
            else if (searchType == "SfdcDealId")
            {
                TxtSfdcDealId.SetText(WebDriver, text);
                BtnSearch.Click(WebDriver);
            }
            else if (searchType == "AccountName")
            {
                TxtAccountName.SetText(WebDriver, text);
                BtnSearch.Click(WebDriver);
            }
            return new AccountDetailsPage(WebDriver);
        }
     
    }
}
