using System;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;

namespace Dsa.Pages.Quote
{
    public class QuoteSearchResultsPage : DsaPageBase
    {
        public QuoteSearchResultsPage(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "Quote Search Results Page";
            PageFactory.InitElements(webDriver, this);
            webDriver.WaitForPageLoad(TimeSpan.FromSeconds(2000));
        }
        #region Elements


public IWebElement QuoteResultsTable { get { return WebDriver.GetElement(By.XPath("//table[contains(@id, 'DataTables_Table_')]")); } }


public IWebElement QuoteSearchResultsGrid { get { return WebDriver.GetElement(By.Id("DataTables_Table_quoteSearchResults_Grid")); } }


public IWebElement QuoteResultsMergeQuotes { get { return WebDriver.GetElement(By.Id("quoteSearchResults_mergeQuotes")); } }


public IWebElement ClearAllBtn { get { return WebDriver.GetElement(By.Id("quoteSearchResults_mergeQuoteClearAll")); } }


public IWebElement MergeQuoteSelect { get { return WebDriver.GetElement(By.Id("a[id^='quoteSearchResults_merge_select']")); } }


  public IWebElement QuoteSearchItemsPerPage { get { return WebDriver.GetElement(By.Id("quoteSearchResults_Grid_grid_paging_itemsPerPage;")); } }


public IWebElement LnkEditQuoteSearch { get { return WebDriver.GetElement(By.Id("quote_searchEdit_link")); } }


public IWebElement NoResultsMsg { get { return WebDriver.GetElement(By.Id("noResults_returnPrevious_partPre")); } }


public IWebElement CreateQuote { get { return WebDriver.GetElement(By.Id("mergeQuote_continue")); } }


public IWebElement ErrorAgreementIdMismatch { get { return WebDriver.GetElement(By.Id("mergeQuote_mergeQuotes_errorMessage")); } }

        

public IWebElement MergeQuoteLimitExceededMsg { get { return WebDriver.GetElement(By.Id("quoteSearchResults_mergeQuotes_limitExceeded")); } }

        //[FindsBy(How = How.XPath, Using = "//table[contains(@id, 'DataTables_Table_')]/tbody/descendant::tr")]

public IList<IWebElement> QuoteListRows { get { return WebDriver.GetElements(By.XPath("//*[@id='DataTables_Table_0']/tbody/descendant::tr")); } }

        public IWebElement QuoteListRowColoumn(int rowIndex = 1, int coloumnIndex = 1)
        {
            //return WebDriver.GetElement(By.XPath("(//table[contains(@id, 'DataTables_Table_')]/tbody/descendant::tr)[" + rowIndex  + "]//td[" + coloumnIndex + "]"));
            return WebDriver.GetElement(By.XPath("(//*[@id='DataTables_Table_0']/tbody/descendant::tr)[" + rowIndex + "]//td[" + coloumnIndex + "]"));
        }

        #endregion

        #region Methods

        /// <summary>
        /// Click on Available Quote Name from the Quote Result List
        /// </summary>
        /// <param name="quoteName">Quote Name</param>
        /// <returns></returns>
        public QuoteDetailsPage SelectQuoteNameFromTable(string quoteName)
        {
            QuoteSearchItemsPerPage.PickDropdownByText(WebDriver, "40 per page");
            By.PartialLinkText(quoteName).Click(WebDriver, TimeSpan.FromSeconds(60)); // This takes a long time to load. So kept 60 seconds as maximum.
            return new QuoteDetailsPage(WebDriver);
        }

        /// <summary>
        /// Click on Edit Search Button.
        /// </summary>
        /// <returns>Quote search page</returns>
        public QuoteSearchPage EditSearchBehaviour(IWebDriver driver)
        {
            LnkEditQuoteSearch.Click(driver);
            return new QuoteSearchPage(WebDriver);
        }

        #endregion

        public void ClickLineItemMergeButton(string quoteNumber)
        {
            throw new NotImplementedException();
        }

        public bool IsMergeQuoteLimitExceedMsgIdDisplayed()
        {
            throw new NotImplementedException();
        }

        public bool IsLineItemMergeButtonActive(string quoteNumber)
        {
            throw new NotImplementedException();
        }

        public void ClickLineItemRemoveButton(string quoteNumber)
        {
            throw new NotImplementedException();
        }

        public void ClickMergeQuoteButton()
        {
            throw new NotImplementedException();
        }

        public void ClickRemoveFromMergePopup(string quoteNumber)
        {
            throw new NotImplementedException();
        }

        public bool VerifyUndoButtonIsDisplayed(string quoteNumber)
        {
            throw new NotImplementedException();
        }

        public bool VerifyCreateQuoteIsDisabled()
        {
            throw new NotImplementedException();
        }

        public void ClickUndoFromMergePopup(string quoteNumber)
        {
            throw new NotImplementedException();
        }

        public void ClickMergeQuoteContinue()
        {
            throw new NotImplementedException();
        }

        public bool NoResultsFound()
        {
            return NoResultsMsg.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10));
        }

        public IWebElement GetQuoteNameFromResults(int atIndex = 0)
        {           
            var ListElements = WebDriver.GetElements(By.XPath("//*[@id='DataTables_Table_quoteSearchResults_Grid']/tbody/tr"));
            return ListElements[atIndex].FindElement(By.XPath("//td[3]/a"));
        }

        public string NoResultsFoundMessage()
        {
            return NoResultsMsg.GetText(WebDriver);
        }

        public List<IWebElement> QuoteList
        {
            get
            {
                return QuoteSearchResultsGrid.FindElements(By.TagName("tr")).SkipWhile(e => e.Text.Contains("No results have been found")).ToList();
            }
        }
        

        public int NumberOfQuotesAvailableToMerge(IWebDriver webDriver)
        {
            List<IWebElement> availableQuotesToMerge = QuoteSearchResultsGrid.FindElements(By.XPath("//button[contains(@id, 'quoteSearchResults_merge_select_')]"))
                .SkipWhile(e => (e.GetAttribute("disabled") != null) || !e.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2)))
               .ToList();
            return availableQuotesToMerge.Count;
        }

        public int NumberOfQuotesAvailableToRemoveFromMerge(IWebDriver webDriver)
        {
            List<IWebElement> availableToRemove = new QuoteSearchResultsPage(webDriver)
                .QuoteSearchResultsGrid.FindElements(By.XPath("//button[contains(@id, 'quoteSearchResults_merge_remove_') and @class = 'custom grid-btn']"))
                .ToList();
            return availableToRemove.Count;
        }

        public List<IWebElement> MergeQuoteButtons(IWebDriver webDriver)
        {
            return QuoteResultsMergeQuotes.FindElements(By.XPath("//button[contains(@id, 'quoteSearchResults_merge_select_')]"))
                .SkipWhile(e => !e.IsElementClickable(webDriver))
                .ToList();
        }

        public List<IWebElement> RemoveQuoteButtons(IWebDriver webDriver)
        {
            return new QuoteSearchResultsPage(webDriver)
                .QuoteSearchResultsGrid.FindElements(By.XPath("//button[contains(@id, 'quoteSearchResults_merge_remove_') and @class = 'custom grid-btn']"))
                .ToList();
        }
        
        public List<IWebElement> OrderedQuoteList
        {
            get
            {
                return QuoteSearchResultsGrid.FindElements(By.XPath("//tr[*/a = 'Ordered']")).ToList();
            }
        }

        public List<IWebElement> PaginationPages
        {
            get
            {
                return WebDriver.FindElements(By.Id("quoteSearchResults_Grid_partyGrid_pagination")).ToList();
            }
        }

        public bool isQuoteTypeMatchesforQuoteinQuoteList(string QuoteNumber, string QuoteType)
        {
            bool isQuoteTypeMatches = false;
            var quoteList = QuoteListRows;
            for (int i = 0; i < quoteList.Count; i++)
            {
                if (QuoteListRowColoumn(i + 1, 7).GetText(WebDriver).Contains(QuoteNumber) == true && QuoteListRowColoumn(i + 1, 10).GetText(WebDriver) == QuoteType)
                {
                    isQuoteTypeMatches = true;
                    break;
                }
            }
            return isQuoteTypeMatches;
        }

        public IWebElement MergeQuoteFromQuoteList(string QuoteNumber)
        {
            return WebDriver.FindElement(By.Id("quoteSearchResults_merge_select_" + QuoteNumber + ""));

        }

       
    }
}
