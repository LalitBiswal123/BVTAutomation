using System;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Dsa.Pages.Solutions;
using Dsa.Enums;
using System.Collections.Generic;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;

namespace Dsa.Pages
{
    public class SolutionSearchPage : DsaPageBase
    {
        //private readonly double pageLoadWaitTime = double.Parse(ConfigurationManager.AppSettings["PageLoadWaitTime"]);
        public SolutionSearchPage(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "Solution Search Page";
            PageFactory.InitElements(webDriver, this);
            webDriver.WaitForPageLoad(TimeSpan.FromSeconds(2000));
            //GridYourSolutions.WaitForElement(webDriver, TimeSpan.FromSeconds(2000));
        }

        #region Elements


public IWebElement TxtSearchBySolutionOwner { get { return WebDriver.GetElement(By.Id("searchSolutions_solutionOwner")); } }


public IWebElement TxtSearchBySolutionId { get { return WebDriver.GetElement(By.Id("searchSolutions_solutionId")); } }


public IWebElement TxtSearchByCustomerName { get { return WebDriver.GetElement(By.Id("searchSolutions_customerName")); } }


public IWebElement TxtSearchByCustomerNumber { get { return WebDriver.GetElement(By.Id("searchSolutions_dealId")); } }


public IWebElement TxtSearchByDealId { get { return WebDriver.GetElement(By.Id("searchSolutions_solutionOwner")); } }


public IWebElement TxtSearchBySolutionName { get { return WebDriver.GetElement(By.Id("searchSolutions_solutionName")); } }


public IWebElement TxtSearchByQuoteNumber { get { return WebDriver.GetElement(By.Id("searchSolutions_solutionQuoteNumber")); } }


public IWebElement BtnSearch { get { return WebDriver.GetElement(By.Id("solutionSearch_button")); } }


public IWebElement SolutionSearchResult { get { return WebDriver.GetElement(By.ClassName("app-title")); } }


public IList<IWebElement> QuoteIDList { get { return WebDriver.GetElements(By.ClassName("//table//a[contains(@href, '#/quote/details/QuoteNumber/')]")); } }
        #endregion


        public SolutionSearchPage SolutionSearch(SolutionSearchType searchBy, string searchStr)
        {
            switch (searchBy)
            {
                case SolutionSearchType.SolutionId:
                    TxtSearchBySolutionId.Click();
                    TxtSearchBySolutionId.Clear();
                    TxtSearchBySolutionId.SendKeys(searchStr);
                    break;
                case SolutionSearchType.CustomerName:
                    TxtSearchByCustomerName.Click();
                    TxtSearchByCustomerName.Clear();
                    TxtSearchByCustomerName.SendKeys(searchStr);
                    break;
                case SolutionSearchType.CustomerNumber:
                    TxtSearchByCustomerNumber.Click();
                    TxtSearchByCustomerNumber.Clear();
                    TxtSearchByCustomerNumber.SendKeys(searchStr);
                    break;
                case SolutionSearchType.DealId: TxtSearchByDealId.Click();
                    TxtSearchByDealId.Clear();
                    TxtSearchByDealId.SendKeys(searchStr);
                    break;
                case SolutionSearchType.SolutionOwner:
                    TxtSearchBySolutionOwner.Click();
                    TxtSearchBySolutionOwner.Clear();
                    TxtSearchBySolutionOwner.SendKeys(searchStr);
                    break;
                case SolutionSearchType.SolutionName:
                    TxtSearchBySolutionName.Click();
                    TxtSearchBySolutionName.Clear();
                    TxtSearchBySolutionName.Clear();
                    TxtSearchBySolutionName.SendKeys(searchStr);
                    break;
                case SolutionSearchType.QuoteNumber:
                    TxtSearchByQuoteNumber.Click();
                    TxtSearchByQuoteNumber.Clear();
                    TxtSearchByQuoteNumber.SendKeys(searchStr);
                    break;
            }
            BtnSearch.Click(WebDriver);
            //WebDriver.WaitForBusyOverlay();
            SolutionSearchResult.WaitUntilTextChanges(WebDriver, "Solution Search Results");
            WebDriver.WaitForElementDisplay(By.XPath("//table[contains(@id, 'DataTables_Table_')]"), TimeSpan.FromSeconds(15));
            return new SolutionSearchPage(WebDriver);
        }
        public SolutionConfigurationPage SolutionSearch(string solutionId)
        {
            string xpath = "//a[contains(text(),'" + solutionId + "')]";
            WebDriver.FindElement(By.XPath(xpath)).Click(WebDriver);
            if (WebDriver.Url.Contains($"identity/global/"))
                WebDriver.RefreshCurrentPage();
            return new SolutionConfigurationPage(WebDriver);
        }

  }
}
