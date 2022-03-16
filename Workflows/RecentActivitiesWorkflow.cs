using System.Collections.Generic;
using Dsa.Pages;
using Dsa.Utils;
using OpenQA.Selenium;

namespace Dsa.Workflows
{
    public static class RecentActivitiesWorkflow
    {
        #region Recent Activites View all Quotes
        public static RecentActivityPage RecentActivites_ViewAll_Quotes(IWebDriver webDriver)
        {

            new HomePage(webDriver).ViewAllRecentActivity("quote");
            return new RecentActivityPage(webDriver);//.IsActive() ? new RecentActivityPage(webDriver) : null;
            //return new RecentActivityPage(webDriver).IsActive() ? new RecentActivityPage(webDriver) : null;
        }

        #endregion

        #region Recent Activites View all Orders
        public static RecentActivityPage RecentActivites_ViewAll_Orders(IWebDriver webDriver)
        {
            new HomePage(webDriver).ViewAllRecentActivity("order");
            //new RecentActivityPage(webDriver).OrdersTab.Click();
            return new RecentActivityPage(webDriver);
            //return new RecentActivityPage(webDriver).IsActive() ? new RecentActivityPage(webDriver) : null;
        }

        #endregion

        #region Recent Activities View all Opportunities
        public static RecentActivityPage RecentActivites_ViewAll_Opportunites(IWebDriver webDriver)
        {
            new HomePage(webDriver).ViewAllRecentActivity("opportunities");
            return new RecentActivityPage(webDriver);
            //new RecentActivityPage(webDriver).OpportunitiesTab.Click();
            //return new RecentActivityPage(webDriver).IsActive() ? new RecentActivityPage(webDriver) : null;
        }

        #endregion

        #region Recient Activites View All Quotes Verify Pagination (Commented)
        //public static bool RecientActivites_ViewAll_Quotes_VerifyPagination(IWebDriver webDriver)
        //{
        //    new HomePage(webDriver).ViewAllRecentActivity("quote");
        //    return new RecentActivityPage(webDriver).VerifyPagination(1);
        //}

        //public static bool RecientActivites_ViewAll_Orders_VerifyPagination(IWebDriver webDriver)
        //{
        //    new HomePage(webDriver).ViewAllRecentActivity("order");
        //    //new RecentActivityPage(webDriver).OrdersTab.Click();
        //    return new RecentActivityPage(webDriver).VerifyPagination(2);
        //}

        //public static bool RecientActivites_ViewAll_Opportunities_VerifyPagination(IWebDriver webDriver)
        //{
        //    new HomePage(webDriver).ViewAllRecentActivity("opportunities");
        //    //new RecentActivityPage(webDriver).OpportunitiesTab.Click();
        //    return new RecentActivityPage(webDriver).VerifyPagination(3);
        //}

        #endregion

        #region Recent Activites Verify Date Range Changes
        public static bool RecentActivites_VerifyDateRangeChanges(IWebDriver webDriver, int tabSelected)
        {
            new RecentActivityPage(webDriver).DdlDateRange.PickDropdownByText(webDriver, "Today");
            var numberOfItemsForFirstDateRange =
                new RecentActivityPage(webDriver).TotalNumberOfItemsPerDateRange(tabSelected);
            var listOfOptions = new List<string>
            {
                "Last 7 days",
                "Last 10 days",
                "Last 30 days",
                "Last 60 days",
                "Last 90 days",
                "View All",
                "Choose A Date Range"
            };
            foreach (var listOfOption in listOfOptions)
            {
                new RecentActivityPage(webDriver).DdlDateRange.PickDropdownByText(webDriver, listOfOption);
                new RecentActivityPage(webDriver).ClickPageLinkArrow();
                var numberOfItemsForSecondDateRange = new RecentActivityPage(webDriver).TotalNumberOfItemsPerDateRange(tabSelected);
                numberOfItemsForFirstDateRange = numberOfItemsForFirstDateRange < numberOfItemsForSecondDateRange
                    ? numberOfItemsForSecondDateRange
                    : 0;
                if (numberOfItemsForFirstDateRange != 0) continue;
                new RecentActivityPage(webDriver).ClickPageLinkArrow();
                numberOfItemsForSecondDateRange = new RecentActivityPage(webDriver).TotalNumberOfItemsPerDateRange(tabSelected);
                numberOfItemsForFirstDateRange = numberOfItemsForFirstDateRange < numberOfItemsForSecondDateRange
                    ? numberOfItemsForSecondDateRange
                    : 0;
                if (numberOfItemsForFirstDateRange == 0)
                {
                    return false;
                }
            }

            return true;
        }

        #endregion

        #region Recent Activites View all Draft Quotes
        public static RecentActivityPage RecentActivites_ViewAll_DraftQuotes(IWebDriver webDriver)
        {
            new HomePage(webDriver).ViewAllRecentActivity("Draft");
            return new RecentActivityPage(webDriver);
        }
        #endregion

        #region Recent Activites View all Solutions Quotes
        public static RecentActivityPage RecentActivites_ViewAll_SolutionsQuotes(IWebDriver webDriver)
        {
            new HomePage(webDriver).ViewAllRecentActivity("solution");
            return new RecentActivityPage(webDriver);
        }
        #endregion


    }
}
