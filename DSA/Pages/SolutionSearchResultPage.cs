using System;
using System.Collections.Generic;
using System.Linq;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Dsa.Enums;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;

namespace Dsa.Pages
{
    public class SolutionSearchResultPage : DsaPageBase
    {
        //private readonly double pageLoadWaitTime = double.Parse(ConfigurationManager.AppSettings["PageLoadWaitTime"]);
        public SolutionSearchResultPage(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "Solution Search Page";
            PageFactory.InitElements(webDriver, this);
            webDriver.WaitForPageLoad(TimeSpan.FromSeconds(2000));
            //GridYourSolutions.WaitForElement(webDriver, TimeSpan.FromSeconds(2000));
        }

        #region Elements


public IWebElement SolutionsSearchResultsGrid { get { return WebDriver.GetElement(By.Id("DataTables_Table_solutionsSearchResults_Grid")); } }


public IWebElement ModelWrapper { get { return WebDriver.GetElement(By.Id("DataTables_Table_0_wrapper")); } }


public IWebElement ValidationErrorMsg { get { return WebDriver.GetElement(By.Id("_solutionvalidation_error")); } }


public IWebElement BtnSearchEdit { get { return WebDriver.GetElement(By.Id("_searchEdit_link")); } }


public IWebElement SolutionSearchResult { get { return WebDriver.GetElement(By.ClassName("app-title")); } }


public IWebElement BtnYes { get { return WebDriver.GetElement(By.Id("messageDialogButton_0")); } }


public IWebElement SolnNotFoundError { get { return WebDriver.GetElement(By.Id("_solutionNotFound_error")); } }

        public By SortingAscBy { get { return By.XPath(".//*[contains(@class, 'sorting_asc sorting_disabled')]"); } }
        public By SortingDescBy { get { return By.XPath(".//*[contains(@class, 'sorting_desc sorting_disabled')]"); } }
        public By SortingBy { get { return By.XPath(".//*[contains(@class, 'sorting_disabled')]"); } }
        public By SolutionIdBy { get { return By.XPath(".//*[contains(@class, 'ng-scope')]"); } }
        public By CatalogSelectBtnBy { get { return By.ClassName("grid-btn"); } }
        public By GridBy { get { return By.Id("solutionsSearchResults_Grid"); } }


public IWebElement ArwNextPage { get { return WebDriver.GetElement(By.ClassName("icon-ui-arrowright")); } }


public IWebElement PaginationGrid { get { return WebDriver.GetElement(By.ClassName("c-grid-control")); } }

        public IWebElement GridYourSolutions { get; set; }

        #endregion

        //public IWebElement NextPageArrow = PaginationGrid.FindElements(By.ClassName("arrow")).FirstOrDefault(o => o.FindElement(By.TagName("span")).GetAttribute("data-ng-class").Equals("{disabled: nextPage.disabled}"));

        private bool SolutionexistsBy
        {
            get
            {
                return SolutionsSearchResultsGrid.FindElements(By.XPath(".//*[contains(@class, 'ng-scope')]"))
                        .Any(o => o.GetAttribute("ng-click").Contains("viewSolution"));
            }
        }

        public void SortAscOrDesc(string sortCol)
        {

            switch (sortCol)
            {
                case "SolutionId":
                    SolutionsSearchResultsGrid.FindElements(SortingBy)
                        .FirstOrDefault(o => o.Text.Contains("Solution Id"))
                        .Click();
                    break;
                case "CustomerName":
                    SolutionsSearchResultsGrid.FindElements(SortingBy)
                        .FirstOrDefault(o => o.Text.Contains("Customer Name"))
                        .Click();
                    break;
                case "CustomerNumber":
                    SolutionsSearchResultsGrid.FindElements(SortingBy)
                        .FirstOrDefault(o => o.Text.Contains("Customer Number"))
                        .Click();
                    break;
                case "SolutionName":
                    SolutionsSearchResultsGrid.FindElements(SortingBy)
                        .FirstOrDefault(o => o.Text.Contains("Solution Name"))
                        .Click();
                    break;
                case "ListPrice":
                    SolutionsSearchResultsGrid.FindElements(SortingBy)
                        .FirstOrDefault(o => o.Text.Contains("List Price"))
                        .Click();
                    break;
                case "QuoteNumber":
                    SolutionsSearchResultsGrid.FindElements(SortingBy)
                        .FirstOrDefault(o => o.Text.Contains("Quote Id"))
                        .Click();
                    break;
                case "XPODStatus":
                    SolutionsSearchResultsGrid.FindElements(SortingBy)
                        .FirstOrDefault(o => o.Text.Contains("XPOD Status"))
                        .Click();
                    break;
            }

        }

        public void SortSolutionSearchPage(string sortCol, string ascOrDesc)
        {
            if (ascOrDesc == "Asc" && SolutionsSearchResultsGrid.ElementExists(SortingDescBy))
            {
                SortAscOrDesc(sortCol);
            }
            else if (ascOrDesc == "Desc" && SolutionsSearchResultsGrid.ElementExists(SortingAscBy))
            {
                SortAscOrDesc(sortCol);
            }

        }

        public bool VerifyAddToQuote()
        {

            return true;
        }

        public void VerifyAddToQuoteBtnEnabledforSol(string solId)
        {

        }

        public bool VerifyAddtoQuotebtn()
        {

            return true;
        }



        public void ClickOnAddToQuote(string solId)
        {
            //SolutionsSearchResultsGrid.FindElements(By.ClassName("no-sort")).FirstOrDefault(o => o.FindElements(By.TagName("a")).Any(x => x.GetAttribute("data-ng-click").Equals("createQuote('" + solId + "', '1')"))).Click();
            string searchStr = "createQuote('" + solId.Split('.')[0] + "', '" + solId.Split('.')[1] + "')";
            WebDriver.GetElement(By.XPath("//a[contains(@data-ng-click,\"" + searchStr + "\") and @class='grid-btn']")).Click(WebDriver);

            if (WebDriver.TryFindElement(BtnYes, TimeSpan.FromSeconds(2))) //Handles the pop up to exit any current quote
                BtnYes.Click();
        }

        private List<IWebElement> SolutionsList
        {
            get
            {
                return SolutionsSearchResultsGrid.FindElements(By.TagName("tr")).SkipWhile(e => e.Text.Contains("no results have been found")).ToList();
            }
        }
        public bool GoToNextPage()
        {

            //if (!ArwNextPage.IsElementVisible()) return false;
            if (!WebDriver.TryFindElement(ArwNextPage, TimeSpan.FromSeconds(2))) return false;
            ArwNextPage.Click();
            //Thread.Sleep(2000);
            return true;
        }

        public SolutionSearchPage FindSolutionInListAndClick(SolutionSearchResultsType clickOn, string solutionId)
        {
            IWebElement solutionRow;
            //FindSolutionInList(solutionId, out solutionRow);
            switch (clickOn)
            {
                case SolutionSearchResultsType.AddToQuote:
                    //SolutionsSearchResultsGrid.FindElements(By.ClassName("grid-btn")).FirstOrDefault(o => o.GetAttribute("data-ng-click").Equals("createQuote('" + solutionId.Split('.')[0] + "', '" + solutionId.Split('.')[1] + "')")).Click();
                    SolutionsSearchResultsGrid.FindElement(By.ClassName("grid-btn")).Click(WebDriver);
                    break;
                case SolutionSearchResultsType.SolutionId:
                    //SolutionsSearchResultsGrid.FindElements(By.Id(solutionId.Split('.')[0])).FirstOrDefault(o => o.GetAttribute("ng-click").Equals("viewSolution('" + solutionId.Split('.')[0] + "', '" + solutionId.Split('.')[1] + "')")).Click();
                    SolutionsSearchResultsGrid.FindElement(By.XPath("//a[contains(text(), '" + solutionId + "')]")).Click(WebDriver);
                    //Thread.Sleep(3000);
                    //return new SolutionSearchPage(WebDriver);
                    break;
                case SolutionSearchResultsType.SolutionName:
                    SolutionsSearchResultsGrid.FindElement(By.XPath("//a[contains(@id, 'solutionName')]")).Click(WebDriver);
                    break;
                default:
                    break;

            }
            WebDriver.WaitForBusyOverlay();
            if (WebDriver.TryFindElement(BtnYes, TimeSpan.FromSeconds(2))) //Handles the pop up to exit any current quote
                BtnYes.Click();
            return new SolutionSearchPage(WebDriver);
        }
        public bool FindSolutionInList(string solutionId, out IWebElement solutionRow)
        {
            // Change the items per page view option to the highest available in the options
            bool found = false;
            solutionRow = null;
            //Thread.Sleep(1000);
            while (0 < SolutionsList.Count)
            {
                solutionRow = SolutionsList.FirstOrDefault(row => row.Text.Contains(solutionId + " "));

                if (solutionRow != null)
                {
                    found = true;
                    //SolutionsSearchResultsGrid.FindElements(By.Id(solutionID)).FirstOrDefault(o => o.Text.Equals(solutionId)).Click();

                    WebDriver.WaitForBusyOverlay();
                    WebDriver.WaitForPageLoad();
                    WebDriver.WaitForBusyOverlay();
                    break;
                }
                SolutionsList.Clear();
                // If solution is not found in current page, go to next page
                // Break the loop if there is no next page exists
                if (!GoToNextPage()) break;
            }

            return found;
        }

        public bool FindQuoteInList(string quoteNumber)
        {
            bool found = false;
            IWebElement solutionRow = null;

            while (0 < SolutionsList.Count)
            {
                solutionRow = SolutionsList.FirstOrDefault(row => row.Text.Contains(quoteNumber));
                
                if (solutionRow != null)
                {
                    found = true;

                    WebDriver.WaitForBusyOverlay();
                    WebDriver.WaitForPageLoad();
                    WebDriver.WaitForBusyOverlay();
                    break;
                }
                SolutionsList.Clear();
                // If quote is not found in current page, go to next page
                // Break the loop if there is no next page
                if (!GoToNextPage()) break;
            }

            return found;
        }

        public bool FindCustomerInList(string customerNumber)
        {
            bool found = false;
            IWebElement solutionRow = null;

            while (0<SolutionsList.Count)
            {
                solutionRow = SolutionsList.FirstOrDefault(row => row.Text.Contains(customerNumber));

                if(solutionRow!= null)
                {
                    found = true;

                    WebDriver.WaitForBusyOverlay();
                    WebDriver.WaitForPageLoad();
                    WebDriver.WaitForBusyOverlay();
                    break;
                }
                SolutionsList.Clear();
                // If quote is not found in current page, go to next page
                // Break the loop if there is no next page
                if (!GoToNextPage()) break;
            }

            return found;
        }

        public bool VerifyValidationErrorMsg()
        {
            if (WebDriver.TryFindElement(ValidationErrorMsg, TimeSpan.FromSeconds(5)))
                return ValidationErrorMsg.Text.Contains("Validation Errors");
            else return false;

        }

        public bool VerifyXpodValidationErrorMsg()
        {
            if (WebDriver.TryFindElement(ValidationErrorMsg, TimeSpan.FromSeconds(5)))
                return ValidationErrorMsg.Text.Contains("XPOD status Not Approved");
            else return false;
        }

        public SolutionSearchPage ClickEditSearchBtn()
        {
            BtnSearchEdit.Click(WebDriver);
            return new SolutionSearchPage(WebDriver);
        }

        public List<String> GetQuotesFromGrid()
        {
            List<string> quotesList = WebDriver.FindElements(By.XPath("//*[contains(@id, 'DataTables_Table_solutionsSearchResults_Grid')]/tbody/tr/td[7]")).Select(x => x.GetText(WebDriver)).ToList();
            return quotesList;
        }
    }
}
