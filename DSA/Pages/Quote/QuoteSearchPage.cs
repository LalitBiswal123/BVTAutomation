using System;
using Dsa.Pages.PCFConvergence;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Dsa.Pages.PCFConvergence;

namespace Dsa.Pages.Quote
{
    public class QuoteSearchPage : DsaPageBase
    {
        public QuoteSearchPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements

        //[FindsBy(How = How.XPath, Using = "//input[@id = 'quoteSearch_quoteNumber'][1]")]
        //public IWebElement TxtQuoteNumber;

        public IWebElement TxtQuoteNumber { get { return WebDriver.GetElement(By.XPath("//input[@id = 'quoteSearch_quoteNumber'][1]")); } }

        //[FindsBy(How = How.Id, Using = "quoteSearch_draftQuoteNumber")]
        //public IWebElement TxtDraftQuoteNumber;
        public IWebElement TxtDraftQuoteNumber { get { return WebDriver.GetElement(By.Id("quoteSearch_draftQuoteNumber")); } }


public IWebElement TxtDOMSQuoteNumber { get { return WebDriver.GetElement(By.Id("quoteSearch_domsQuoteNumber")); } }


public IWebElement TxtOpportunityId { get { return WebDriver.GetElement(By.Id("quoteSearch_opportunityID")); } }


public IWebElement TxtQuoteName { get { return WebDriver.GetElement(By.Id("quoteSearch_quoteName")); } }


public IWebElement DdlQuoteSearchDateRangeFilter { get { return WebDriver.GetElement(By.Id("quoteSearch_dateRange")); } }


public IWebElement TxtQuoteSearchSalesRepId { get { return WebDriver.GetElement(By.Id("quoteSearch_salesRepId")); } }

        //[FindsBy(How = How.Id, Using = "quoteSearch_searchButton")]
        //public IWebElement BtnQuoteSearch;

        public IWebElement BtnQuoteSearch { get { return WebDriver.GetElement(By.Id("quoteSearch_searchButton")); } }


public IWebElement BtnClearSearch { get { return WebDriver.GetElement(By.Id("quoteSearch_clearAction")); } }


public IWebElement TxtLspHeader { get { return WebDriver.GetElement(By.XPath("//h3[contains(text(), 'List Price')]")); } }


public IWebElement TxtQuoteSearchPageHeader { get { return WebDriver.GetElement(By.XPath("//h2[text() = 'Quote Search']")); } }

        //[FindsBy(How = How.Id, Using = "_setDefaultContract_cancel")]
        //public IWebElement BtnLspViewOriginalQuote;

        public IWebElement BtnLspViewOriginalQuote { get { return WebDriver.GetElement(By.Id("_setDefaultContract_cancel")); } }

        //[FindsBy(How = How.Id, Using = "_setDefaultContract_ok")]
        //public IWebElement BtnLspContinue;

        public IWebElement BtnLspContinue { get { return WebDriver.GetElement(By.Id("_setDefaultContract_ok")); } }




        #endregion


        public QuoteDetailsPage QuoteSearchByQuoteNumber(string quoteNumber, bool viewOriginalQuote = true)
        {

            TxtQuoteNumber.SetText(WebDriver, quoteNumber);
            BtnQuoteSearch.Click(WebDriver);
            new QuoteDetailsPage(WebDriver).WaitForQuoteValidationToComplete();
            if (BtnLspViewOriginalQuote.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
                HandleLspPopUp(viewOriginalQuote);
            return new QuoteDetailsPage(WebDriver);
        }

        public PCFQuoteSummaryPage PCFQuoteSearchByQuoteNumber(string quoteNumber, bool viewOriginalQuote = true)
        {

            TxtQuoteNumber.SetText(WebDriver, quoteNumber);
            BtnQuoteSearch.Click(WebDriver);
            new PCFQuoteSummaryPage(WebDriver).WaitForQuoteValidationToComplete();
            if (BtnLspViewOriginalQuote.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
                HandleLspPopUp(viewOriginalQuote);
            return new PCFQuoteSummaryPage(WebDriver);
        }


        public QuoteSearchResultsPage QuoteSearchByQuoteName(string quoteName)
        {
            TxtQuoteName.SetText(WebDriver, quoteName);
            DdlQuoteSearchDateRangeFilter.PickDropdownByText(WebDriver, "View All");
            BtnQuoteSearch.Click(WebDriver);
            return new QuoteSearchResultsPage(WebDriver);
        }

        public QuoteDetailsPage SearchQuoteByDomsQuoteNumber(string domsQuoteNumber, bool viewOriginalQuote = true)
        {
            TxtDOMSQuoteNumber.SetText(WebDriver, domsQuoteNumber);
            BtnQuoteSearch.Click(WebDriver);
            new QuoteDetailsPage(WebDriver).WaitForQuoteValidationToComplete();
            if (BtnLspViewOriginalQuote.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(45)))
                HandleLspPopUp(viewOriginalQuote);
            return new QuoteDetailsPage(WebDriver);
        }

        public CreateQuotePage QuoteSearchByDraftQuoteNumber(string draftQuoteNumber)
        {
            TxtDraftQuoteNumber.WaitForElement(WebDriver);
            TxtDraftQuoteNumber.SetText(WebDriver, draftQuoteNumber);
            BtnQuoteSearch.Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        }

        public void HandleLspPopUp(bool viewOriginalQuote = true)
        {
            if (viewOriginalQuote)
                BtnLspViewOriginalQuote.Click(WebDriver);
            else
                BtnLspContinue.Click(WebDriver);

        }
        public PCFQuoteSummaryPage SearchByQuoteNumber(string quoteNumber)
        {
            TxtQuoteNumber.SetText(WebDriver, quoteNumber);
            BtnQuoteSearch.Click(WebDriver);
            new PCFQuoteSummaryPage(WebDriver).WaitForQuoteValidationToComplete();           
            return new PCFQuoteSummaryPage(WebDriver);
        }
    }
}
