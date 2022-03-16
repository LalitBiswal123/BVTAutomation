using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Quote
{
    public class QuoteListPage : DsaPageBase
    {
        public QuoteListPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement MergeQuotes { get { return WebDriver.GetElement(By.Id("quoteSearchResults_mergeQuotes")); } }


public IWebElement QuoteMergeContinue { get { return WebDriver.GetElement(By.Id("QuoteMerge_continue")); } }


public IWebElement ClearAll { get { return WebDriver.GetElement(By.Id("quoteSearchResults_mergeQuoteClearAll")); } }


public IWebElement HdrQuoteList { get { return WebDriver.GetElement(By.Id("quote_list_h")); } }


public IWebElement TblQuoteList { get { return WebDriver.GetElement(By.Id("DataTables_Table_8")); } }


public IWebElement QuoteLists { get { return WebDriver.GetElement(By.Id("DataTables_Table_8")); } }

        #endregion

    }
}
