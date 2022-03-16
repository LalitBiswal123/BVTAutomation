using System;
using System.Collections.Generic;
using System.Linq;
using Dsa.Utils;
using OpenQA.Selenium;
using Dsa.Pages.Quote;
using Dell.Adept.Testing.DataGenerators.Primitive;

namespace Dsa.Workflows
{
    public static class MergeQuoteWorkflow
    {
        #region Merge Quote (5 Quotes by name)
        public static QuoteDetailsPage MergeQuote_5Quotes_ByName(IWebDriver webDriver, List<string> orderCode,
            string customerName, string companyNumber, string quoteName, List<string> quoteNumbers)
        {
            //Search for Quote
            Console.WriteLine("Searching for quotes by name");
            QuoteSearchWorkflow.SearchQuoteByNameForMerge(webDriver, quoteName);

            Console.WriteLine("Selecting first four quotes to merge");
            //Select first four to merge
            for (var i = 0; i < 4; i++)
            {
                new QuoteSearchResultsPage(webDriver).ClickLineItemMergeButton(quoteNumbers[i]);
            }

            Console.WriteLine("Verify 5th qoute can't be selected to merge");
            //Verify 5 quote can't be selected
            if (!new QuoteSearchResultsPage(webDriver).IsMergeQuoteLimitExceedMsgIdDisplayed())
                throw new Exception("Error: Merge Quote Limit is not Displayed");
            if (!new QuoteSearchResultsPage(webDriver).IsLineItemMergeButtonActive(quoteNumbers[4]))
                throw new Exception("Quote Button is still active");

            Console.WriteLine("Remove one quote and select another");
            //Remove one quote and select a different quote
            new QuoteSearchResultsPage(webDriver).ClickLineItemRemoveButton(quoteNumbers[3]);
            if (new QuoteSearchResultsPage(webDriver).IsMergeQuoteLimitExceedMsgIdDisplayed())
                throw new Exception("Error: Merge Quote Limit should not be Displayed");
            new QuoteSearchResultsPage(webDriver).ClickLineItemMergeButton(quoteNumbers[4]);
            if (!new QuoteSearchResultsPage(webDriver).IsMergeQuoteLimitExceedMsgIdDisplayed())
                throw new Exception("Error: Merge Quote Limit is not Displayed");

            Console.WriteLine("Click Merge Quote Button");
            //Click Merge Quote Button
            new QuoteSearchResultsPage(webDriver).ClickMergeQuoteButton();

            Console.WriteLine("Verify Merge Popup functionality");
            //Verify when clicking remove button from popup
            new QuoteSearchResultsPage(webDriver).ClickRemoveFromMergePopup(quoteNumbers[2]);
            if (new QuoteSearchResultsPage(webDriver).VerifyUndoButtonIsDisplayed(quoteNumbers[2]))
                throw new Exception("Error: Undo Button is not visible");
            new QuoteSearchResultsPage(webDriver).ClickRemoveFromMergePopup(quoteNumbers[1]);
            new QuoteSearchResultsPage(webDriver).ClickRemoveFromMergePopup(quoteNumbers[4]);
            if (!new QuoteSearchResultsPage(webDriver).VerifyCreateQuoteIsDisabled())
                throw new Exception("Error: Create Quote button should have been disabled.");

            new QuoteSearchResultsPage(webDriver).ClickUndoFromMergePopup(quoteNumbers[1]);
            new QuoteSearchResultsPage(webDriver).ClickUndoFromMergePopup(quoteNumbers[2]);
            new QuoteSearchResultsPage(webDriver).ClickUndoFromMergePopup(quoteNumbers[4]);

            Console.WriteLine("Click continue to merge quote");
            //Click Merge Quote Continue Button
            new QuoteSearchResultsPage(webDriver).ClickMergeQuoteContinue();

            Console.WriteLine("Verify quotes merged successfully");
            VerifyMergedCreateQuote(webDriver, orderCode, customerName, companyNumber);

            return new QuoteDetailsPage(webDriver);
        }

        #endregion

        #region Merge Quote(5 Quotes by Quote Numbers)
        public static QuoteDetailsPage MergeQuote_5Quotes_ByQuoteNumbers(IWebDriver webDriver,
            List<string> orderCode, string customerName, string companyNumber, List<string> quoteNumbers)
        {
            QuoteSearchWorkflow.SearchQuoteByQuoteNumber(webDriver, quoteNumbers[0]);
            new QuoteDetailsPage(webDriver).SelectMergeQuote();
            if (!new QuoteDetailsPage(webDriver).IsMergeQuoteButtonDisabled())
                throw new Exception("Error: Merge Button should be disabled");
            //new QuoteDetailsPage(webDriver).SelectMergeQuote();
            QuoteSearchWorkflow.SearchQuoteByQuoteNumber(webDriver, quoteNumbers[1]);
            new QuoteDetailsPage(webDriver).SelectMergeQuote();
            if (new QuoteDetailsPage(webDriver).IsMergeQuoteButtonDisabled())
                throw new Exception("Error: Merge Button should not be disabled");
            new QuoteDetailsPage(webDriver).ClickMergeQuotes();
            if (new QuoteDetailsPage(webDriver).IsMergeCreateQuoteButtonDisabled())
                throw new Exception("Error: Create Merge Button should not be disabled");
            new QuoteDetailsPage(webDriver).ClickCancelMergeQuote();
            //new QuoteDetailsPage(webDriver).SelectMergeQuote();
            QuoteSearchWorkflow.SearchQuoteByQuoteNumber(webDriver, quoteNumbers[2]);
            new QuoteDetailsPage(webDriver).SelectMergeQuote();
            //new QuoteDetailsPage(webDriver).SelectMergeQuote();
            QuoteSearchWorkflow.SearchQuoteByQuoteNumber(webDriver, quoteNumbers[3]);
            new QuoteDetailsPage(webDriver).SelectMergeQuote();
            if (new QuoteDetailsPage(webDriver).IsMergeQuoteLimitDisplayed())
                throw new Exception("Error: Warning message should be displayed.");
            new QuoteDetailsPage(webDriver).ClickMergeQuotes();

            //Verify when clicking remove button from popup
            new QuoteDetailsPage(webDriver).ClickRemoveFromMergePopup(quoteNumbers[2]);
            if (new QuoteDetailsPage(webDriver).VerifyUndoButtonIsDisplayed(quoteNumbers[2]))
                throw new Exception("Error: Undo Button is not visible");
            new QuoteDetailsPage(webDriver).ClickRemoveFromMergePopup(quoteNumbers[1]);
            new QuoteDetailsPage(webDriver).ClickRemoveFromMergePopup(quoteNumbers[3]);
            if (!new QuoteDetailsPage(webDriver).IsMergeCreateQuoteButtonDisabled())
                throw new Exception("Error: Create Quote button should have been disabled.");

            new QuoteDetailsPage(webDriver).ClickUndoFromMergePopup(quoteNumbers[1]);
            new QuoteDetailsPage(webDriver).ClickUndoFromMergePopup(quoteNumbers[2]);
            new QuoteDetailsPage(webDriver).ClickAddMoreQuotes();
            QuoteSearchWorkflow.SearchQuoteByQuoteNumber(webDriver, quoteNumbers[4]);
            new QuoteDetailsPage(webDriver).SelectMergeQuote();

            new QuoteDetailsPage(webDriver).ClickMergeQuotes();
            new QuoteDetailsPage(webDriver).ClickCreateQuoteFromMergeModal();

            VerifyMergedCreateQuote(webDriver, orderCode, customerName, companyNumber);

            return new QuoteDetailsPage(webDriver);

        }

        #endregion

        #region Merge Quote (5 Quotes by Quote Numbers Different Shipping Address)
        public static QuoteDetailsPage MergeQuote_5Quotes_ByQuoteNumbers_DifferentShippingAddress(IWebDriver webDriver,
            List<string> orderCode, string customerName, string companyNumber, string shippingName,
            List<string> quoteNumbers)
        {

            QuoteSearchWorkflow.SearchQuoteByQuoteNumber(webDriver, quoteNumbers[0]);
            new QuoteDetailsPage(webDriver).SelectMergeQuote();
            if (!new QuoteDetailsPage(webDriver).IsMergeQuoteButtonDisabled())
                throw new Exception("Error: Merge Button should be disabled");
            new QuoteDetailsPage(webDriver).SelectMergeQuote();
            QuoteSearchWorkflow.SearchQuoteByQuoteNumber(webDriver, quoteNumbers[1]);
            new QuoteDetailsPage(webDriver).SelectMergeQuote();
            if (new QuoteDetailsPage(webDriver).IsMergeQuoteButtonDisabled())
                throw new Exception("Error: Merge Button should not be disabled");
            new QuoteDetailsPage(webDriver).ClickMergeQuotes();
            if (new QuoteDetailsPage(webDriver).IsMergeCreateQuoteButtonDisabled())
                throw new Exception("Error: Create Merge Button should not be disabled");
            new QuoteDetailsPage(webDriver).ClickCancelMergeQuote();
            new QuoteDetailsPage(webDriver).SelectMergeQuote();
            QuoteSearchWorkflow.SearchQuoteByQuoteNumber(webDriver, quoteNumbers[2]);
            new QuoteDetailsPage(webDriver).SelectMergeQuote();
            new QuoteDetailsPage(webDriver).SelectMergeQuote();
            QuoteSearchWorkflow.SearchQuoteByQuoteNumber(webDriver, quoteNumbers[3]);
            new QuoteDetailsPage(webDriver).SelectMergeQuote();
            if (new QuoteDetailsPage(webDriver).IsMergeQuoteLimitDisplayed())
                throw new Exception("Error: Warning message should be displayed.");
            new QuoteDetailsPage(webDriver).ClickMergeQuotes();

            //Verify when clicking remove button from popup
            new QuoteDetailsPage(webDriver).ClickRemoveFromMergePopup(quoteNumbers[2]);
            if (new QuoteDetailsPage(webDriver).VerifyUndoButtonIsDisplayed(quoteNumbers[2]))
                throw new Exception("Error: Undo Button is not visible");
            new QuoteDetailsPage(webDriver).ClickRemoveFromMergePopup(quoteNumbers[1]);
            new QuoteDetailsPage(webDriver).ClickRemoveFromMergePopup(quoteNumbers[3]);
            if (!new QuoteDetailsPage(webDriver).IsMergeCreateQuoteButtonDisabled())
                throw new Exception("Error: Create Quote button should have been disabled.");

            new QuoteDetailsPage(webDriver).ClickUndoFromMergePopup(quoteNumbers[1]);
            new QuoteDetailsPage(webDriver).ClickUndoFromMergePopup(quoteNumbers[2]);
            new QuoteDetailsPage(webDriver).ClickAddMoreQuotes();
            QuoteSearchWorkflow.SearchQuoteByQuoteNumber(webDriver, quoteNumbers[4]);
            new QuoteDetailsPage(webDriver).SelectMergeQuote();

            new QuoteDetailsPage(webDriver).ClickMergeQuotes();
            new QuoteDetailsPage(webDriver).ClickDifferentMasterQuote(quoteNumbers[4]);
            new QuoteDetailsPage(webDriver).ClickCreateQuoteFromMergeModal();

            VerifyMergedCreateQuote(webDriver, orderCode, customerName, companyNumber, shippingName);

            return new QuoteDetailsPage(webDriver);

        }

        #endregion

        #region Verify merged Create Quote
        private static void VerifyMergedCreateQuote(IWebDriver webDriver, IEnumerable<string> orderCode,
            string customerName, string companyNumber, string shippingName = null)
        {

            if (
                !new CreateQuotePage(webDriver).GetCustomerNameAfterCustomerLoaded()
                    .Equals(customerName, StringComparison.InvariantCultureIgnoreCase))
                throw new Exception("Error: Customer Name is incorrect");
            if (!new CreateQuotePage(webDriver).GetCompanyNumber().Contains(companyNumber))
                throw new Exception("Error: Company Number is incorrect");
            new CreateQuotePage(webDriver).ExpandAllShowMore();
            if (!string.IsNullOrWhiteSpace(shippingName))
                if (!new CreateQuotePage(webDriver).DivDefaultShipToAddress.GetText(webDriver).Contains(shippingName))
                    throw new Exception("Error: Address is incorrect");

            var listOfOrderCodes = new List<string>();
            for (var i = 0; i < 4; i++)
            {
                listOfOrderCodes.Add(new CreateQuotePage(webDriver).GetLineItemOrderCode(i + 1));
            }

            foreach (var listOfOrderCode in listOfOrderCodes.Where(listOfOrderCode => orderCode.All(code => code != listOfOrderCode)))
            {
                throw new Exception(string.Format("Error: Order Code not found on page: {0}", listOfOrderCode));
            }
            new CreateQuotePage(webDriver).SaveQuote();
        }

        public static bool MergeRandomQuotesFromQuoteSearchResults(IWebDriver webDriver, int numberOfQuotesToMerge, bool clickMergeBtn = true)
        {
            var result = false;

            //return false if there's no minimum number of quotes to merge 
            if (numberOfQuotesToMerge < 2 || numberOfQuotesToMerge > 4)
                return result;

            var numOfQuotesAvailableToMerge = new QuoteSearchResultsPage(webDriver).NumberOfQuotesAvailableToMerge(webDriver);
            if (numberOfQuotesToMerge > numOfQuotesAvailableToMerge)
                return result;

            //click merge quotes buttons to add them to the list

            foreach (var e in new QuoteSearchResultsPage(webDriver).MergeQuoteButtons(webDriver))
            {
                e.Click(webDriver);
                numberOfQuotesToMerge--;
                if (numberOfQuotesToMerge == 0)
                    break;
            }

            if(clickMergeBtn)
                new QuoteSearchResultsPage(webDriver).QuoteResultsMergeQuotes.Click(webDriver);

            result = true;
            return result;
        }
        
        public static bool SearchQuoteByQuoteNameAndMergeQuotes(IWebDriver webDriver, string quoteName, int numberOfQuotesToMerge)
        {
            QuoteSearchWorkflow.SearchQuoteByNameForMerge(webDriver, quoteName);
            return MergeRandomQuotesFromQuoteSearchResults(webDriver, numberOfQuotesToMerge);
        }

        public static bool RemoveQuotesFromMergeAtIndex(IWebDriver webDriver, int index = 1)
        {
            bool result = false;
            
            if(new QuoteSearchResultsPage(webDriver).NumberOfQuotesAvailableToRemoveFromMerge(webDriver) != 0)
            {
                var quotesInList = new QuoteSearchResultsPage(webDriver).RemoveQuoteButtons(webDriver);
                quotesInList[index-1].Click(webDriver);
                result = true;
            }

            return result;
        }

        public static bool RemoveRandomQuotesFromMergeListOnQuoteSearchResults(IWebDriver webDriver, int numberOfQuotesToRemove)
        {
            var result = false;

            if (numberOfQuotesToRemove < 1 || numberOfQuotesToRemove > 4)
                return result;

            while(numberOfQuotesToRemove!=0)
            {
                result = RemoveQuotesFromMergeAtIndex(webDriver, Generator.RandomInt(1, numberOfQuotesToRemove));
                numberOfQuotesToRemove--;
            }
            
            return result;
        }

        public static List<IWebElement> GetOrderedQuoteList(IWebDriver webDriver)
        {
            var pageNumberList = new QuoteSearchResultsPage(webDriver).PaginationPages;
            var list = new QuoteSearchResultsPage(webDriver).OrderedQuoteList;
            var currentPage = 1;

            // try while or do-while or the worst case for loop -> NEEDS REVISITING
            while (currentPage != new QuoteSearchResultsPage(webDriver).PaginationPages.Count && list.Count < 1)
            {
                list.Clear();
                list = new QuoteSearchResultsPage(webDriver).OrderedQuoteList;
                if (list.Count >= 1)
                    break;
                new QuoteSearchResultsPage(webDriver).PaginationPages[currentPage].Click(webDriver);
                webDriver.WaitForPageLoad();
                currentPage++;
                
            }
            

            return list;
        }

        #endregion
    }
}
