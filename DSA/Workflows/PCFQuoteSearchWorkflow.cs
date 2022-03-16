using OpenQA.Selenium;
using Dsa.Pages.Quote;
using Dsa.Utils;
using System;
using Dsa.Pages.PCFConvergence;

namespace Dsa.Workflows
{
    /// <summary>
    /// Quote search related workflows are to be written in this class.
    /// </summary>
    public static class PCFQuoteSearchWorkflow
    {
        #region Search Quote by Quote Number
        /// <summary>
        /// Search the Quote by Quote number.
        /// </summary>
        /// <param name="driver">Driver</param>
        /// <param name="quoteNumber">Quote Number</param>
        /// <returns></returns>
        public static QuoteDetailsPage SearchQuoteByQuoteNumber(IWebDriver driver, string quoteNumber)
        {
            var quoteSearch = HomeWorkflow.GoToQuoteSearchPage(driver);
            return quoteSearch.QuoteSearchByQuoteNumber(quoteNumber);
        }

        #endregion

        #region Search Quote by Name for Merge
        ///// <summary>
        ///// Search the Quote by DOMS Quote number.
        ///// </summary>
        ///// <param name="driver">Driver</param>
        ///// <param name="domsQuoteNumber">DOMS Quote Number</param>
        ///// <returns></returns>
        //public static QuoteDetailsPage SearchQuoteByDomsQuoteNumber(IWebDriver driver, string domsQuoteNumber)
        //{
        //    var quoteSearch = Home.GoToQuoteSearchPage(driver);
        //    quoteSearch.TxtDOMSQuoteNumber.SetText(driver, domsQuoteNumber);
        //    return (QuoteDetailsPage)quoteSearch.ExecuteQuoteSearch();
        //}

        ///// <summary>
        ///// Search the Quote by Quote Name.
        ///// </summary>
        ///// <param name="driver">Driver</param>
        ///// <param name="quoteName">Quote Name</param>
        ///// <returns></returns>
        //public static QuoteDetailsPage SearchQuoteByQuoteName(IWebDriver driver, string quoteName)
        //{
        //    var quoteSearch = Home.GoToQuoteSearchPage(driver);
        //    quoteSearch.TxtQuoteName.SetText(driver, quoteName);
        //    quoteSearch.DdlQuoteSearchDateRangeFilter.PickDropdownByText(driver, "View All");
        //    var searchResult = (QuoteSearchResultsPage)quoteSearch.ExecuteQuoteSearch(false);
        //    return searchResult.SelectQuoteNameFromTable(quoteName);
        //}

        public static QuoteSearchResultsPage SearchQuoteByNameForMerge(IWebDriver driver, string quoteName)
        {
            var quoteSearch = HomeWorkflow.GoToQuoteSearchPage(driver);
            quoteSearch.QuoteSearchByQuoteName(quoteName);
            if (new QuoteSearchResultsPage(driver).QuoteSearchItemsPerPage.IsElementDisplayed(driver, TimeSpan.FromSeconds(3)))
                new QuoteSearchResultsPage(driver).QuoteSearchItemsPerPage.PickDropdownByText(driver, "40 per page");

            driver.VerifyBusyOverlayNotDisplayed();
            return new QuoteSearchResultsPage(driver);
        }

        #endregion

        
    }

}
