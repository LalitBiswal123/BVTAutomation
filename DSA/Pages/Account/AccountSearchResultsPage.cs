using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;

namespace Dsa.Pages.Account
{
    public class AccountSearchResultsPage : DsaPageBase
    {
        public AccountSearchResultsPage(IWebDriver webDriver)
            : base(webDriver)
        {
           PageFactory.InitElements(webDriver, this);
        }
        #region Elements

        public IWebElement NoItemInListCssSelector { get { return WebDriver.GetElement(By.CssSelector("div > div > div > div:nth-child(2)")); } }

        public IWebElement TblAccountSearchResult { get { return WebDriver.GetElement(By.XPath(".//*[@id='accountSearchResult_grid')]/div/table")); } }

        public IWebElement SelectAccount { get { return WebDriver.GetElement(By.Id("accountSearchResultGrid-0-")); } }

        public IWebElement AccountNotFound1 { get { return WebDriver.GetElement(By.XPath("//*[@id='noResults_Apology_Bold']")); } }

        public IWebElement AccountNotFound2 { get { return WebDriver.GetElement(By.XPath("//*[@id='noResults_returnPrevious_partPre']")); } }

        public IWebElement AccountNotFound3 { get { return WebDriver.GetElement(By.XPath("//*[@id='common_noResults_link']")); } }

        public IWebElement AccountNotFound4 { get { return WebDriver.GetElement(By.XPath("//*[@id='noResults_returnPrevious_partPost']")); } }
        #endregion

        public AccountSearchResultsPage AccountNotFoundError()
        {
            Logger.Write("Error Displayed: " + AccountNotFound1.GetText(WebDriver) + AccountNotFound2.GetText(WebDriver) + AccountNotFound3.GetText(WebDriver) + AccountNotFound4.GetText(WebDriver));
            return new AccountSearchResultsPage(WebDriver);
        }
    }
}
