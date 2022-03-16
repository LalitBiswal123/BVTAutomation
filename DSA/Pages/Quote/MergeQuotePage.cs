using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace Dsa.Pages.Quote
{
    public class MergeQuotePage : DsaPageBase
    {
        public MergeQuotePage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements


public IWebElement CreateQuote { get { return WebDriver.GetElement(By.XPath("//*[contains(@id, '_continue')]")); } }


public IWebElement AddMoreQuotes { get { return WebDriver.GetElement(By.XPath("//*[contains(@id, '_addMore')]")); } }


public IWebElement Cancel { get { return WebDriver.GetElement(By.XPath("//*[contains(@id, '_cancel')]")); } }


public IWebElement Close { get { return WebDriver.GetElement(By.XPath("//*[contains(@id, '_close')]")); } }


public IWebElement GridMergeQuote { get { return WebDriver.GetElement(By.XPath("//*[contains(@id, 'Merge_Grid')]")); } }


public IWebElement HdrMergeQuote { get { return WebDriver.GetElement(By.XPath("//*[contains(@id, '_mergeCount')]")); } }


public IWebElement MasterNotSelectedMsg { get { return WebDriver.GetElement(By.XPath("//*[contains(@id, '_masterNotSelected')]")); } }

        #endregion

        private List<IWebElement> RdoBtnsForMasterQuote
        {
            get
            {
                return WebDriver.FindElements(By.XPath("//input[contains(@id, '_Grid_')]")).ToList();
            }
        }

        public void SelectMasterQuoteAtIndex(IWebDriver webDriver, int index = 1)
        {
            RdoBtnsForMasterQuote[index].Click(webDriver);
        }

        public bool IsAddMoreQuotesBtnEnabled()
        {
            return AddMoreQuotes.Enabled;
        }

        public List<IWebElement> RemoveQuoteButtons(IWebDriver webDriver)
        {
            //return new QuoteSearchResultsPage(webDriver)
            //    .QuoteSearchResultsGrid.FindElements(By.XPath("//a[contains(@id, 'QuoteMerge_remove_') and contains(@class, 'grid-btn')]"))
            //    .ToList();

            return WebDriver.FindElements(By.XPath("//a[contains(@id, 'QuoteMerge_remove_') or contains(@id, 'mergeQuote_remove')]")).ToList();
        }
        
        public List<IWebElement> UndoButtons(IWebDriver webDriver)
        {
            //return new QuoteSearchResultsPage(webDriver)
            //    .QuoteSearchResultsGrid.FindElements(By.XPath("//a[contains(@id, 'QuoteMerge_undo_') and contains(@class, 'grid-btn')]"))
            //    .ToList();

            return WebDriver.FindElements(By.XPath("//a[contains(@id, 'QuoteMerge_undo_') or contains(@id, 'mergeQuote_remove_undo')]")).ToList();
        }
        
        public void SelectAsMaster(IWebDriver webDriver, string quoteNum, string quoteVersion = "1")
        {
            var xpath = "//input[contains(@id, 'mergeQuote_Grid_') and contains(@id, '" + quoteNum + "." + quoteVersion + "')]";
            WebDriver.GetElement(By.XPath(xpath)).Click(webDriver);
        }



    }
}
