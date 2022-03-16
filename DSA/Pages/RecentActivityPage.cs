using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using System.Linq;
using System.Collections.Generic;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;

namespace Dsa.Pages
{
    public class RecentActivityPage : DsaPageBase
    {
        private const string ByDataTableViewAllCustomersId = "DataTables_Table_";

        public RecentActivityPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement DdlDateRange { get { return WebDriver.GetElement(By.Id("recentActivity_dateRange")); } }


public IWebElement DdlActivityType { get { return WebDriver.GetElement(By.Id("recentActivity_activityType")); } }


public IWebElement FromDate { get { return WebDriver.GetElement(By.XPath("//*[@class='advanced-search']/div[1]/div[1]/span/span/span/span")); } }


public IWebElement ToDate { get { return WebDriver.GetElement(By.XPath("//*[@class='advanced-search']/div[2]/div[1]/span/span/span/span")); } }


public IWebElement TblRecentActivityResult { get { return WebDriver.GetElement(By.XPath("//*[@id='recentActivity_Grid']/div/table")); } }


public IWebElement BtnPreviousPage { get { return WebDriver.GetElement(By.XPath("//*[@class='c-grid-pagination c-pagination ng-isolate-scope']//span[1]")); } }


public IWebElement BtnNextPage { get { return WebDriver.GetElement(By.XPath("//*[@class='c-grid-pagination c-pagination ng-isolate-scope']//span[2]")); } }


public IWebElement GridQuoteActivities { get { return WebDriver.GetElement(By.Id("quoteActivities_Grid")); } }


public IWebElement GridOrderActivities { get { return WebDriver.GetElement(By.Id("orderActivities_Grid")); } }


public IWebElement GridSolutionActivities { get { return WebDriver.GetElement(By.Id("solutionActivities_Grid")); } }


public IWebElement GridRecentActivity { get { return WebDriver.GetElement(By.Id("recentActivity_Grid")); } }


public IWebElement QuotesTab { get { return WebDriver.GetElement(By.Id("activity_quotes_tab")); } }


public IWebElement OrdersTab { get { return WebDriver.GetElement(By.Id("activity-orders_tab")); } }


public IWebElement FavoriteQuoteTab { get { return WebDriver.GetElement(By.Id("activity-fav-quotes_tab")); } }


public IWebElement OpportunitiesTab { get { return WebDriver.GetElement(By.LinkText("Opportunities")); } }


public IWebElement PageLinkArrow { get { return WebDriver.GetElement(By.ClassName("icon-ui-arrowright")); } }


public IWebElement ItemsPerPageDropDown { get { return WebDriver.GetElement(By.Id("grid_paging_itemsPerPage")); } }

        //[FindsBy(How = How.Id, Using = "quoteActivity_title")]
        //public IWebElement RecentQuoteTitle;
        public IWebElement RecentQuoteTitle { get { return WebDriver.GetElement(By.Id("quoteActivity_title")); } }

        //[FindsBy(How = How.Id, Using = "orderActivity_title")]
        //public IWebElement RecentOrderTitle;
        public IWebElement RecentOrderTitle { get { return WebDriver.GetElement(By.Id("orderActivity_title")); } }


public IWebElement RecentSolutionQuoteTitle { get { return WebDriver.GetElement(By.Id("solutionActivities_title_recentSolutions")); } }


public IWebElement RecentOpportunitiesTitle { get { return WebDriver.GetElement(By.Id("opportunityActivity_title")); } }


public IWebElement RecentDraftQuoteTitle { get { return WebDriver.GetElement(By.Id("draftQuoteActivity_title")); } }


public IWebElement DraftQuoteResultsGrid { get { return WebDriver.GetElement(By.Id("draftQuoteActivities_Grid")); } }


public IWebElement FavoriteQuoteResultsGrid { get { return WebDriver.GetElement(By.Id("favQuoteActivities_Grid")); } }


        #endregion

        public bool IsQuoteTabActive()
        {
            return QuotesTab.FindElement(By.XPath("..")).GetAttribute("class").Contains("active");
        }

        public bool IsOrderTabActive()
        {
            return OrdersTab.FindElement(By.XPath("..")).GetAttribute("class").Contains("active");
        }

        public bool IsFavoriteQuoteTabActive()
        {
            return FavoriteQuoteTab.FindElement(By.XPath("..")).GetAttribute("class").Contains("active");
        }

        public bool IsOpportunitiesTabActive()
        {
            return OpportunitiesTab.FindElement(By.XPath("..")).GetAttribute("class").Contains("active");
        }

        public string DateRangeSelectedText()
        {
            return DdlDateRange.GetText(WebDriver);
        }

        public List<string> AllDateRangeOptions()
        {
            return ((SelectElement)DdlDateRange).Options.Select(webElement => webElement.Text).ToList();
        }

        public void ClickPageLinkArrow()
        {
            if (PageLinkArrow != null)
            {
                PageLinkArrow.Click();
            }
        }

        public bool VerifyPagination(int type)
        {
            var totalNumberOfItems = TotalNumberOfItemsPerDateRange(type);

            int numberofPages;
            var totalItemsOnTab = 0;
            Console.WriteLine("Total number of items on this page = " + totalNumberOfItems);

            var perpagecount = Convert.ToInt32(ItemsPerPageDropDown.Select().SelectedOption.GetAttribute("value").Trim());
            if (totalNumberOfItems > 100)
                totalNumberOfItems = 100;
            if (perpagecount != 0 && totalNumberOfItems % perpagecount == 0)
            {
                numberofPages = totalNumberOfItems / perpagecount;
            }
            else if (perpagecount != 0)
            {
                numberofPages = (int)Math.Ceiling(((decimal)totalNumberOfItems / perpagecount));
            }
            else numberofPages = 1;

            Console.WriteLine("Number of pages for this tab is : " + numberofPages);

            while (numberofPages >= 1)
            {
                var numberOItems = WebDriver.FindElement(By.Id(ByDataTableViewAllCustomersId + (type - 1))).FindElements(By.TagName("tr")).Count;
                Console.WriteLine("Number of items on this page is : " + numberOItems);
                totalItemsOnTab = totalItemsOnTab + numberOItems;

                if (PageLinkArrow == null)
                {
                    Console.WriteLine("No multiple pages present.");
                }
                else
                {
                    PageLinkArrow.FindElement(By.XPath("..")).Click();
                }
                numberofPages--;
            }
            Console.WriteLine("Total number of items :" + totalItemsOnTab);

            if (totalNumberOfItems == totalItemsOnTab)
            {
                Console.WriteLine("Item count is correct.");
                return true;
            }
            Console.WriteLine("Incorrect item count.");
            return false;
        }

        public int TotalNumberOfItemsPerDateRange(int type)
        {
            try
            {
                var typeOfPagination = string.Empty;
                switch (type)
                {
                    case 1:
                        typeOfPagination = "quoteActivities_Grid_fromto";
                        break;
                    case 2:
                        typeOfPagination = "orderActivities_Grid_fromto";
                        break;
                    case 3:
                        typeOfPagination = "opportunitiesActivities_Grid_fromto";
                        break;
                }

                string[] splitStrings = { " of " };
                WebDriver.WaitForElementVisible(By.Id(typeOfPagination), TimeSpan.FromSeconds(10));
                var totalNumberOfItem = WebDriver.FindElement(By.Id(typeOfPagination));
                var totalNumberOfItems =
                    Convert.ToInt32(totalNumberOfItem.Text.Split(splitStrings, StringSplitOptions.None).Last());
                return totalNumberOfItems;
            }
            catch
            {
                return WebDriver.FindElement(By.Id(ByDataTableViewAllCustomersId + (type - 1))).FindElements(By.TagName("tr")).Count;
            }
        }

        public List<Dictionary<string, object>> GetDraftQuoteGridResults()
        {
            return DraftQuoteResultsGrid.GetHtmlTableData(WebDriver);
            //  return WebDriver.GetHtmlTableData(By.Id("draftQuoteActivities_Grid"));
        }

        public bool IsColoumnPresentInGrid(IWebDriver testWebDriver, IWebElement TypeGrid, string ColoumnName)
        {
            bool isFound = false;

            var HeaderColumns= TypeGrid.GetElements(testWebDriver, By.XPath(".//th"));
            if (HeaderColumns.Count() > 0)
            {
                for (int i = 0; i < HeaderColumns.Count(); i++)
                {
                    if (HeaderColumns[i].GetText(testWebDriver) == ColoumnName)
                    {
                        isFound = true;
                        break;
                    }
                }
            }
            return isFound;
            
        }
    }
}
