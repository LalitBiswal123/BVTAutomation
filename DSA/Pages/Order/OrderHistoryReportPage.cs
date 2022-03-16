using Dsa.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace Dsa.Pages.Order
{
    public class OrderHistoryReportPage : DsaPageBase
    {
        public OrderHistoryReportPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement BtnSearchOrderHistoryReport { get { return WebDriver.GetElement(By.Id("OrderBeta_searchButton")); } }


public IWebElement BtnOrderHistoryCalander { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/div[1]/div/div/div[1]/div/span/span/span/span")); } }


public IWebElement TblOrderHistoryReportResult { get { return WebDriver.GetElement(By.XPath("//*[@id='order_search_grid']/div/table")); } }


public IWebElement BtnSearch { get { return WebDriver.GetElement(By.CssSelector("#orderHistory_searchButton")); } }


public IWebElement TglOrderDetalis { get { return WebDriver.GetElement(By.CssSelector("#order_search_grid > div > table > tbody > tr:nth-child(1) > td:nth-child(1) > a")); } }


public IWebElement TglQuoteDetalis { get { return WebDriver.GetElement(By.CssSelector("#quote_search_grid > div > table > tbody > tr:nth-child(1) > td:nth-child(1) > a")); } }


public IWebElement BtnExport { get { return WebDriver.GetElement(By.CssSelector("#order_export")); } }


public IWebElement BtnExportQuote { get { return WebDriver.GetElement(By.CssSelector("#quote_export")); } }


public IWebElement BtnQuoteSearch { get { return WebDriver.GetElement(By.CssSelector("#quoteHistory_searchButton")); } }


public IWebElement TabQuoteHistory { get { return WebDriver.GetElement(By.CssSelector("#main > div:nth-child(1) > ul > li:nth-child(2) > a")); } }


public IWebElement OrderSearchCreatedBy { get { return WebDriver.GetElement(By.CssSelector("#order_search_createdBy")); } }


public IWebElement QuoteSearchCreatedByEmaiID { get { return WebDriver.GetElement(By.CssSelector("#quoteHistory_search_createdBy")); } }


public IWebElement QuoteSearchCreatedBySalesRepiD { get { return WebDriver.GetElement(By.CssSelector("#quoteHistory_search_salesRepId")); } }


public IWebElement LblQuote { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_0 > tbody > tr.details-view > td.detail-cell > table > thead > tr > th:nth-child(2)")); } }


public IWebElement LblShipDate { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_0 > tbody > tr.details-view > td.detail-cell > table > thead > tr > th:nth-child(4)")); } }


public IWebElement LblCustomerNumber { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_0 > tbody > tr.details-view > td.detail-cell > table > thead > tr > th:nth-child(1)")); } }


public IWebElement LblRepType { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_0 > tbody > tr.details-view > td.detail-cell > table > thead > tr > th:nth-child(8)")); } }


public IWebElement LblSalesRepIDTgl { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_0 > tbody > tr.details-view > td.detail-cell > table > thead > tr > th:nth-child(7)")); } }


public IWebElement LblSalesRepName { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_0 > tbody > tr.details-view > td.detail-cell > table > thead > tr > th:nth-child(6)")); } }


public IWebElement LblPaymentMethod { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_0 > tbody > tr.details-view > td.detail-cell > table > thead > tr > th:nth-child(5)")); } }


public IWebElement LblPO { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_0 > tbody > tr.details-view > td.detail-cell > table > thead > tr > th:nth-child(3)")); } }


public IWebElement OrderHistoryLoadQuote { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_1 > tbody > tr:nth-child(1) > td:nth-child(5) > a")); } }


public IWebElement QuoteSaveDateSort { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_1 > thead > tr > th:nth-child(2)")); } }


public IWebElement QuoteCustomerNameSort { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_1 > thead > tr > th:nth-child(3)")); } }


public IWebElement QuoteeQuoteSort { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_1 > thead > tr > th:nth-child(4)")); } }


public IWebElement QuoteQuoteNumberSort { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_1 > thead > tr > th:nth-child(5)")); } }


public IWebElement QuoteVersionSort { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_1 > thead > tr > th:nth-child(6)")); } }


public IWebElement QuoteStatusSort { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_1 > thead > tr > th:nth-child(7)")); } }


public IWebElement QuoteRevenueSort { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_1 > thead > tr > th:nth-child(8)")); } }


public IWebElement QuoteMarginSort { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_1 > thead > tr > th:nth-child(9)")); } }


public IWebElement TblOrderReport { get { return WebDriver.GetElement(By.CssSelector("#main > div.row.mg-top-10.ng-scope > div.col-md-9 > div:nth-child(1)")); } }


public IWebElement OrderReportTableID { get { return WebDriver.GetElement(By.CssSelector("#main > div.row.mg-top-10.ng-scope > div.col-md-9 > div:nth-child(1)")); } }


public IWebElement LblSalesRepId { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_4 > tbody > tr.details-view > td.detail-cell > table > tbody > tr > td:nth-child(7)")); } }


public IWebElement OrderSearchSalesRepId { get { return WebDriver.GetElement(By.Id("order_search_salesRepId")); } }


public IWebElement GridQuoteReport { get { return WebDriver.GetElement(By.Id("quote_search_grid")); } }


public IWebElement GridPagingItem { get { return WebDriver.GetElement(By.Id("grid_paging_itemsPerPage")); } }



public IWebElement LnkDpidSearchElement { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='DPID']")); } }

public IWebElement txtDpidSearchCreatedBy { get { return WebDriver.GetElement(By.XPath("//*[@id='orderHistory_search_createdBy']")); } }


public IWebElement txtDpidSearch { get { return WebDriver.GetElement(By.Id("orderHistory_searchButton")); } }


public IWebElement tblDpidSearchOrderDetails { get { return WebDriver.GetElement(By.XPath("//*[@id='order_search_grid']//table/tbody")); } }

public IWebElement ResultDpid { get { return WebDriver.GetElement(By.XPath("//div[@class='ag-body-container']//div[@col-id='dpid']//a")); } }
        #endregion

        public void SwitchToNewTab()
        {
            WebDriver.SwitchTo().Window(WebDriver.WindowHandles.Last());
            Assert.IsTrue(WebDriver.Url.Contains("/order/details/dpid/"));
        }

        public void ClickOnAnyNotCancelledDPID()
        {          
            for (int i = 2; i < 20; i++)
            {
                if (!(WebDriver.FindElement(By.XPath(".//div[contains(@class,'ag-body')]//div[@role='row'][" + i + "]//div[@col-id='orderStatus']")).GetText(WebDriver).Contains("Cancelled")))
                {
                    WebDriver.FindElement(By.XPath(".//div[contains(@class,'ag-body')]//div[@role='row'][" + i + "]//div[@col-id='dpid']//a")).Click(WebDriver);
                    break;
                }
            }
        }
    }
}
