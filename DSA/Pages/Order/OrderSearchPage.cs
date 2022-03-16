using Dell.Adept.UI.Web.Pages;
using Dsa.Pages.PCFConvergence;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace Dsa.Pages.Order
{
    public partial class OrderSearchPage : DsaPageBase
    {
        public OrderSearchPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement OrderSearchDateRangeDdl { get { return WebDriver.GetElement(By.Id("orderSearch_dateRange")); } }


public IWebElement OrderSearchResultsGrid { get { return WebDriver.GetElement(By.Id("orderSearchResults_Grid")); } }


public IWebElement OrderSearchResultsItemPerPage { get { return WebDriver.GetElement(By.Id("orderSearchResult_itemsPerPage")); } }

        //[FindsBy(How = How.Id, Using = "orderSearch_orderNumber")]
        //public IWebElement TxtOrderSearchOrderNumber;
        public IWebElement TxtOrderSearchOrderNumber { get { return WebDriver.GetElement(By.Id("orderSearch_orderNumber")); } }



public IWebElement TxtOrderSearchDpId { get { return WebDriver.GetElement(By.Id("orderSearch_dpid")); } }


public IWebElement TxtOrderSearchDealId { get { return WebDriver.GetElement(By.Id("orderSearch_dealID")); } }


public IWebElement TxtOrderSearchQuoteNumber { get { return WebDriver.GetElement(By.Id("orderSearch_quoteNumber")); } }


public IWebElement TxtOrderSearchQuoteName { get { return WebDriver.GetElement(By.Id("orderSearch_quoteName")); } }


public IWebElement TxtOrderSearchPoNumber { get { return WebDriver.GetElement(By.Id("orderSearch_poNumber")); } }


public IWebElement TxtOrderSearchServiceTag { get { return WebDriver.GetElement(By.Id("orderSearch_serviceTag")); } }

        //[FindsBy(How = How.Id, Using = "orderSearch_searchButton")]
        //public IWebElement BtnSearch;

        public IWebElement BtnSearch { get { return WebDriver.GetElement(By.Id("orderSearch_searchButton")); } }



public IWebElement BtnClear { get { return WebDriver.GetElement(By.Id("orderSearch_clearAction")); } }


public IWebElement TxtOrderSearchCreatedBy { get { return WebDriver.GetElement(By.Id("orderSearch_orderCreatedBy")); } }


public IWebElement TxtOrderSearchLoggedInSalesRep { get { return WebDriver.GetElement(By.Id("orderSearch_loggedInSalesRepId")); } }


public IWebElement ExactMatchCheckBox { get { return WebDriver.GetElement(By.Id("orderSearch_ExactMatches")); } }


public IWebElement TxtDPSNumber { get { return WebDriver.GetElement(By.Id("orderSearch_dpsNumber")); } }


public IWebElement DPSNumberLink { get { return WebDriver.GetElement(By.XPath("(//table[@id='DataTables_Table_1']//a[contains(text(),'Cancelled')])[1]")); } }


public IWebElement DPSNumberLink1 { get { return WebDriver.GetElement(By.XPath("//table[@id='DataTables_Table_21']//a[contains(text(),'Cancelled')]")); } }


public IWebElement FirstDPID { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_1']/tbody/tr[1]/td[5]/a")); } }
        
        #endregion

        #region Methods

        public IPage ExecuteSearch(bool isDeterministicSearch = true)
        {
            BtnSearch.Click(WebDriver);
            if (isDeterministicSearch)
                return new PCFOrderDetailsPage(WebDriver);
            return new OrderSearchResultsPage(WebDriver);
        }

        /// <summary>
        /// Searches the Order by Order By Number.
        /// </summary>
        /// <param name="ordernumber">The account number.</param>
        /// <returns></returns>

        public OrderDetailsPage SearchOrderByOrderNumber(string ordernumber)
        {
            TxtOrderSearchOrderNumber.SetText(WebDriver, ordernumber);
            return (OrderDetailsPage)ExecuteSearch();
        }

        public PCFOrderDetailsPage PCFSearchOrderByOrderNumber(string ordernumber)
        {
            TxtOrderSearchOrderNumber.SetText(WebDriver, ordernumber);
            return (PCFOrderDetailsPage)ExecuteSearch();
        }

        public OrderDetailsPage SearchOrderByDPSNumber(string ordernumber)
        {
            TxtDPSNumber.SetText(WebDriver, ordernumber);
            return (OrderDetailsPage)ExecuteSearch();

        }

        public void  ClickOnFirstDPIP(IWebDriver driver)
        {
            
            FirstDPID.Click(driver);

        }


        /// <summary>
        /// Searches the Order by DPID Number.
        /// </summary>
        /// <param name="dpidnumber">The SFDC deal identifier.</param>
        /// <returns></returns>

        public OrderDetailsPage SearchOrderByDpidNumber(string dpidnumber)
        {
            TxtOrderSearchDpId.SetText(WebDriver, dpidnumber);
            return (OrderDetailsPage)ExecuteSearch();
        }

        public PCFOrderDetailsPage PCFOrderSearchByDpidNumber(string dpidnumber)
        {
            TxtOrderSearchDpId.SetText(WebDriver, dpidnumber);
            return (PCFOrderDetailsPage)ExecuteSearch();
        }

        /// <summary>
        /// Searches the Order by COM Quote Number.
        /// </summary>
        /// <param name="comQuoteNumber">The COM quote No. identifier.</param>
        /// <returns></returns>
        public OrderSearchResultsPage SearchQuoteNumber(string comQuoteNumber)
        {
            TxtOrderSearchQuoteNumber.SetText(WebDriver, comQuoteNumber);
            OrderSearchDateRangeDdl.PickDropdownByText(WebDriver, "View All");
            return (OrderSearchResultsPage)ExecuteSearch(false);
        }

        /// <summary>
        /// Searches the Order by Quote Name.
        /// </summary>
        /// <param name="quoteName">The Quote Name identifier .</param>
        /// <returns></returns>

        public OrderSearchResultsPage SearchQuoteName(string quoteName)
        {
            TxtOrderSearchQuoteName.SetText(WebDriver, quoteName);
            OrderSearchDateRangeDdl.PickDropdownByText(WebDriver, "View All");
            return (OrderSearchResultsPage)ExecuteSearch(false);
        }

        public OrderSearchResultsPage SearchOrderDateRange(string range)
        {
            OrderSearchDateRangeDdl.PickDropdownByText(WebDriver, range);
            return (OrderSearchResultsPage)ExecuteSearch(false);
        }

        /// <summary>
        /// Searches the Order by PO Number.
        /// </summary>
        /// <param name="poNumber">The PO Number identifier .</param>
        /// <returns></returns>
        public OrderSearchResultsPage SearchOrderByPoNumber(string poNumber,bool IsExactMatch=true)
        {
            TxtOrderSearchPoNumber.Clear();
            TxtOrderSearchPoNumber.SetText(WebDriver, poNumber);
            Thread.Sleep(3000);
            WebDriver.WaitForElementDisplay(OrderSearchDateRangeDdl, System.TimeSpan.FromSeconds(4));
            OrderSearchDateRangeDdl.PickDropdownByText(WebDriver, "View All");
            if (!IsExactMatch)
            {
                ExactMatchCheckBox.Click();
            }
            return (OrderSearchResultsPage)ExecuteSearch(false);
        }

        public OrderSearchResultsPage SearchOrderByPoNumber(string poNumber, string searchBy, bool IsExactMatch = true)
        {
            TxtOrderSearchPoNumber.Clear();
            TxtOrderSearchPoNumber.SetText(WebDriver, poNumber);
            OrderSearchDateRangeDdl.PickDropdownByText(WebDriver, searchBy);
            if (!IsExactMatch)
            {
                ExactMatchCheckBox.Click();
            }
            return (OrderSearchResultsPage)ExecuteSearch(false);
        }

        /// <summary>
        /// Searches the Order by Service tag Number.
        /// </summary>
        /// <param name="serviceTag">The service tag.</param>
        /// <returns></returns>
        public OrderDetailsPage SearchOrderByServiceTag(string serviceTag)
        {
            TxtOrderSearchServiceTag.SetText(WebDriver, serviceTag);
            return (OrderDetailsPage)ExecuteSearch();
        }

        #endregion

        #region PCF
        public IPage PCFExecuteSearch(bool isDeterministicSearch = true)
        {
            BtnSearch.Click(WebDriver);
            if (isDeterministicSearch)
                return new PCFOrderDetailsPage(WebDriver);
            return new OrderSearchResultsPage(WebDriver);
        }


        public PCFOrderDetailsPage PCFSearchOrderByDpidNumber(string dpidnumber)
        {
            TxtOrderSearchDpId.SetText(WebDriver, dpidnumber);
            return (PCFOrderDetailsPage)PCFExecuteSearch();
        }

      

        #endregion

    }
}
