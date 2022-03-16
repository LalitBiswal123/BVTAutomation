using System;
using System.Collections.Generic;
using System.Linq;
using Dsa.Pages.Order;
using Dsa.Utils;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;
using System.Threading;
using FluentAssertions;
using System.Text.RegularExpressions;
using System.Globalization;
using Microsoft.Win32;
using System.IO;
using OpenQA.Selenium.Chrome;

namespace Dsa.Pages
{
    public class ReportingPage : DsaPageBase
    {
        public ReportingPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        public static string QuoteResultTable = @".//*[@id='quote_search_grid']/div/descendant::div[@class='ui-grid-row']";

        #region Elements


public IWebElement BtnOrderTab { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='Orders']")); } }


public IWebElement BtnQuoteTab { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='Quotes']")); } }

        //[FindsBy(How = How.XPath, Using = @"//a[normalize-space()='DPID']")]
        //public IWebElement BtnDpidTab;


public IWebElement BtnGossHistorySearch { get { return WebDriver.GetElement(By.Id("gossHistory_searchButton")); } }


public IWebElement BtnOrdersBetaTab { get { return WebDriver.GetElement(By.XPath(".//*[@id='main']/reports-shell/dsa-tabs/ul/li[3]/a[text()=' Orders ']")); } }


public IWebElement LabelFinalPrice { get { return WebDriver.GetElement(By.XPath("//*[contains(@class,'col-md-3 left-border text-center')]")); } }


public IWebElement QuoteSearch_FromDate { get { return WebDriver.GetElement(By.XPath(".//*[@id='Quote_search_fromDate']/descendant::span[@role='button']")); } }


public IWebElement QuoteSearch_ToDate { get { return WebDriver.GetElement(By.XPath(".//*[@id='Quote_search_toDate']/descendant::span[@role='button']")); } }


public IWebElement BtnQuoteHistorySearch { get { return WebDriver.GetElement(By.Id("Quote_searchButton")); } }


public IWebElement BtnOrderHistorySearch { get { return WebDriver.GetElement(By.Id("orderHistory_searchButton")); } }


public IWebElement TxtGossHistorySalesRep { get { return WebDriver.GetElement(By.Id("gossHistory_search_salesRepId")); } }


public IWebElement TxtGossHistoryPoNumber { get { return WebDriver.GetElement(By.Id("gossHistory_search_poNumber")); } }


public IWebElement TxtGossHistoryCustomerNumberNumber { get { return WebDriver.GetElement(By.Id("gossHistory_search_customerNumber")); } }


public IWebElement TxtQuoteHistorySalesRep { get { return WebDriver.GetElement(By.Id("Quote_search_salesRepId")); } }


public IWebElement TxtQuoteHistoryCreatedBy { get { return WebDriver.GetElement(By.Id("Quote_search_createdBy")); } }


public IWebElement TxtOrderHistorySalesRep { get { return WebDriver.GetElement(By.Id("orderHistory_search_salesRepId")); } }


public IWebElement TxtOrderHistoryCreatedBy { get { return WebDriver.GetElement(By.Id("orderHistory_search_createdBy")); } }


public IWebElement DivGossOrdersList { get { return WebDriver.GetElement(By.Id("gossOrderList_Grid")); } }


public IWebElement DivQuoteSearchList { get { return WebDriver.GetElement(By.XPath(".//*[@id='quote_search_grid']/div/descendant::div[@class='ui-grid-row']")); } }


public IWebElement DivOrderSearchList { get { return WebDriver.GetElement(By.Id("order_search_grid")); } }


public IWebElement MsgGossNoResult { get { return WebDriver.GetElement(By.Id("gossHistory_emailNotFound_error")); } }


public IWebElement MsgDPIDNoResult { get { return WebDriver.GetElement(By.Id("orderHistory_emailNotFound_error")); } }


public IWebElement MsgOrdersBetaNoResult { get { return WebDriver.GetElement(By.Id("OrderBeta_emailNotFound_error")); } }


public IWebElement OrderPageTbl { get { return WebDriver.GetElement(By.XPath("//table[@id='DataTables_Table_0']")); } }


public IWebElement GridPagingItem { get { return WebDriver.GetElement(By.Id("grid_paging_itemsPerPage")); } }


public IWebElement Option20items { get { return WebDriver.GetElement(By.XPath("//*[@id='grid_paging_itemsPerPage']/option[2]")); } }


public IWebElement Option40items { get { return WebDriver.GetElement(By.XPath("//*[@id='grid_paging_itemsPerPage']/option[2]")); } }


public IList<IWebElement> OrderListPaginationList { get { return WebDriver.GetElements(By.XPath(".//*[@id='partyGrid_pagination']//li/a")); } }

        //[FindsBy(How = How.XPath, Using = "(//*[@id='quote_search_grid_pagination']/ul/li[2]/a")]

public IWebElement QuoteSearchPagination2ndPage { get { return WebDriver.GetElement(By.XPath(".//*[@id='gridPagination_page2']")); } }


public IWebElement SaveDateColumnHeader { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Save Date')]")); } }


public IWebElement LnkGoToNextPage { get { return WebDriver.GetElement(By.Id("gridPagination_next")); } }


public IWebElement DivLastPageNumber { get { return WebDriver.GetElement(By.XPath("//div[@id='quote_search_grid_pagination']//li[last()]//a//div")); } }


public IWebElement ColumnPreferencesButton { get { return WebDriver.GetElement(By.XPath("//button[@value = 'Column Preferences']")); } }


public IWebElement SavePreferences { get { return WebDriver.GetElement(By.XPath("//button[@id = 'btnColPrefSave']")); } }


public IWebElement CreatedFromLabel { get { return WebDriver.GetElement(By.XPath("//label[@id = 'Quote_search_createDate' and text() = 'From:']")); } }


public IWebElement CreatedToLabel { get { return WebDriver.GetElement(By.XPath("//label[contains(text(), 'To')]")); } }


public IWebElement SalesRepLabel { get { return WebDriver.GetElement(By.Id("Quote_search_salesRepIdLabel")); } }



        /// <summary>
        /// New elements Reporting
        /// </summary>
        /// <param name="createByEmail"></param>
        /// <param name="salesRep"></param>
        /// <returns></returns>


public IWebElement Orders_FromDate { get { return WebDriver.GetElement(By.XPath(".//*[@id='main']/descendant::span[@aria-controls='gossHistory_search_fromDate_dateview']")); } }


public IWebElement DPID_FromDate { get { return WebDriver.GetElement(By.XPath(".//*[@id='main']/descendant::span[@aria-controls='orderHistory_search_fromDate_dateview']")); } }



public IWebElement SelectAllColumnCheckBox { get { return WebDriver.GetElement(By.XPath(".//*[@id='cdk-overlay-0']//column-preferences//span[contains(text(),'Select All')]/parent::div/input")); } }



public IWebElement SelectAllOrderStatusCheckBox { get { return WebDriver.GetElement(By.XPath(".//*[@id='cdk-overlay-0']//column-preferences//span[contains(text(),'Order Status')]/parent::div/input")); } }


public IWebElement BtnOrderStatus { get { return WebDriver.GetElement(By.Id("gossHistory_moreActions")); } }


public IWebElement BtnSaveColPref { get { return WebDriver.GetElement(By.Id("btnColPrefSave")); } }


public IWebElement CreatedByEmailTextBox { get { return WebDriver.GetElement(By.Id("Order_search_createdBy")); } }

       
        public IWebElement BtnOpenColPref { get { return WebDriver.GetElement(By.XPath(".//*[@id='main']//orders-report//button[@value='Columns']")); } }


        public IWebElement BtnOpenColPrefQuotesTab { get { return WebDriver.GetElement(By.XPath(".//*[@id='main']//quotes-report//button[contains(text(),'Column Preferences')]")); } }


public IWebElement OrdersFromDate_SelectedDate { get { return WebDriver.GetElement(By.XPath(".//daypicker/table/tbody//button[contains(@class,'active')]/span")); } }


public IWebElement QuotesTab { get { return WebDriver.GetElement(By.XPath(" //li[@role = 'presentation']//a[contains(text(),'Quotes')]")); } }
 

public IWebElement TxtOrdersToDate { get { return WebDriver.GetElement(By.Id("gossHistory_search_toDate")); } }


public IWebElement TxtOrdersFromDate { get { return WebDriver.GetElement(By.Id("gossHistory_search_fromDate")); } }


public IWebElement TxtQuoteToDate { get { return WebDriver.GetElement(By.Id("Quote_search_toDate")); } }

public IWebElement TxtQuoteFromDate { get { return WebDriver.GetElement(By.Id("Quote_search_fromDate")); } }


public IWebElement TxtDPIDToDate { get { return WebDriver.GetElement(By.Id("orderHistory_search_toDate")); } }

public IWebElement TxtDPIDFromDate { get { return WebDriver.GetElement(By.Id("orderHistory_search_fromDate")); } }


public IWebElement OrderStatusDropDown { get { return WebDriver.GetElement(By.XPath(".//*[@id='reportFilters']/descendant::label")); } }


public IList<IWebElement> OrderTypeColumn { get { return WebDriver.GetElements(By.XPath("//div[@col-id = 'orderType_1' and @role = 'gridcell']")); } }


public IWebElement Select_DeselectColumnPref { get { return WebDriver.GetElement(By.XPath(".//mat-dialog-container/column-preferences//span[text()='Select All']/parent::div/input")); } }


public IList<IWebElement> QuoteTab_QuoteCol_Hyperlink { get { return WebDriver.GetElements(By.XPath(".//*[@id='quote_search_grid']/descendant::div[@class='ui-grid-canvas'][2]/descendant::a[contains(@href,'QuoteNumber')]")); } }


public IList<IWebElement> QuoteTab_Col_Description { get { return WebDriver.GetElements(By.XPath(".//*[@id='quote_search_grid']/descendant::div[@class='ui-grid-canvas'][2]/descendant::div[contains(@ng-bind-html,'row.entity.description')]")); } }


public IList<IWebElement> AllColumns { get { return WebDriver.GetElements(By.XPath("//div[@class = 'ag-header-cell ag-header-cell-sortable']")); } }


public IWebElement SelectAllCheckBox { get { return WebDriver.GetElement(By.XPath("//span[text() = 'Select All']")); } }


        //Orders Beta New Controls

public IWebElement OrdersBeta_FromDate { get { return WebDriver.GetElement(By.XPath(".//*[@id='OrderBeta_search_fromDate']/descendant::span[@role='button']")); } }


public IWebElement OrdersBeta_ToDate { get { return WebDriver.GetElement(By.XPath(".//*[@id='OrderBeta_search_toDate']/descendant::span[@role='button']")); } }


public IWebElement OrdersBeta_CustomerNo { get { return WebDriver.GetElement(By.Id("Order_search_customerNumber")); } }


public IWebElement OrdersBeta_PurchaseOrderNo { get { return WebDriver.GetElement(By.Id("Order_search_poNumber")); } }


public IWebElement OrdersBeta_SalesRepId { get { return WebDriver.GetElement(By.Id("Order_search_salesRepId")); } }


public IWebElement OrdersBeta_SalesRepTypeButton { get { return WebDriver.GetElement(By.XPath(".//*[@id='main']/reports-shell/dsa-tabs//dropdown-multiselect/div/button")); } }

        //[FindsBy(How = How.XPath, Using = ".//*[@id='main']/reports-shell/dsa-tabs//dropdown-multiselect/div/button")]

public IWebElement OrdersBeta_SalesRepTypeDropdown { get { return WebDriver.GetElement(By.XPath(".//div[@class='btn-group arb-filter col-sm-8']//button[@type='button']")); } }

        //[FindsBy(How = How.XPath, Using = ".//div[@class='btn-group arb-filter col-sm-8']//ul[@class='dropdown-menu']//li[1]//label[1]")]

public IWebElement SalesRepType_SelectDeselect { get { return WebDriver.GetElement(By.XPath(".//div[@class='btn-group arb-filter col-sm-8']//ul[@class='dropdown-menu']//li[1]")); } }


public IWebElement OrdersBeta_OrderStatusDropDown { get { return WebDriver.GetElement(By.XPath(".//*[@id='reportFilters']/dropdown-multiselect-hierarchial/div/button")); } }


public IWebElement OrdersBetaFromDate_SelectedDate { get { return WebDriver.GetElement(By.XPath(".//daypicker//tbody//td//button[contains(@class,'active')]/span")); } }


public IWebElement BtnOrderBetaSearch { get { return WebDriver.GetElement(By.Id("Order_searchButton")); } }


public IWebElement TxtOrderNewToDate { get { return WebDriver.GetElement(By.Id("orderBeta_search_toDate")); } }

public IWebElement TxtOrderNewFromDate { get { return WebDriver.GetElement(By.Id("orderBeta_search_fromDate")); } }


public IWebElement BtnSelectDeselectOrderStatus { get { return WebDriver.GetElement(By.XPath(".//*[@id='reportFilters']/dropdown-multiselect-hierarchial//span[text()='Select/Deselect']")); } }


public IWebElement ExportExcelButton { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Export to Excel')]")); } }


public IWebElement SalesRepTypeNoSelectionText { get { return WebDriver.GetElement(By.XPath(".//div[@class='alert-warning']//span")); } }


public IWebElement SalesRepType_ChkBxSelectDeselect { get { return WebDriver.GetElement(By.XPath(".//div[@class='btn-group arb-filter col-sm-8']//ul[@class='dropdown-menu']//li[1]//label[1]//input")); } }


public IWebElement SalesRepType_ChkBxPrimary { get { return WebDriver.GetElement(By.XPath(".//div[@class='btn-group arb-filter col-sm-8']//ul[@class='dropdown-menu']//li[2]//label[1]//input")); } }


public IWebElement SalesRepType_ChkBxSecondary { get { return WebDriver.GetElement(By.XPath(".//div[@class='btn-group arb-filter col-sm-8']//ul[@class='dropdown-menu']//li[3]//label[1]//input")); } }


public IWebElement SalesRepType_ChkBxProcessor { get { return WebDriver.GetElement(By.XPath(".//div[@class='btn-group arb-filter col-sm-8']//ul[@class='dropdown-menu']//li[4]//label[1]//input")); } }


public IList<IWebElement> SalesRepType_Dropdownselection { get { return WebDriver.GetElements(By.XPath(".//div[@class='btn-group arb-filter col-sm-8']//ul[@class='dropdown-menu']//li//label//input")); } }


public IWebElement OrderType_preference_ChkBx { get { return WebDriver.GetElement(By.XPath("//*[text()='Order Type']//preceding::input[1]")); } }


public IWebElement OrderType_Preference_Row { get { return WebDriver.GetElement(By.XPath("//*[text()='Order Type']//preceding::input[1]//ancestor::li")); } }


public IWebElement SourceApplication_Dropdownselection { get { return WebDriver.GetElement(By.XPath(".//*[@id='main']/reports-shell/dsa-tabs//dropdown-multiselect/div/button[1]")); } }


public IWebElement SourceApplication_Lable { get { return WebDriver.GetElement(By.XPath("//div[text()='Source Application:']")); } }


public IWebElement SelectDeselect_ChkBx { get { return WebDriver.GetElement(By.XPath("//ul[@ng-reflect-klass='dropdown-menu']//child::li/label//input[1]")); } }


public IWebElement SelectDeselectChkBx { get { return WebDriver.GetElement(By.XPath("   (//*[contains(text(), ' Select / Deselect All ')])[1]")); } }



public IWebElement Sourceapplication_preference_ChkBx { get { return WebDriver.GetElement(By.XPath("//*[text()='Source Application']//preceding::input[1]")); } }


public IWebElement BtnCancelColPref { get { return WebDriver.GetElement(By.Id("btnColPrefCancel")); } }


public IWebElement Sourceapplicationcolumn { get { return WebDriver.GetElement(By.XPath("//span[text()='Source Application']")); } }


public IWebElement SelectAll_ChkBX { get { return WebDriver.GetElement(By.XPath("//span[text()='Select All']//preceding::input[1]")); } }


public IWebElement Sourceapplication_Preference_Row { get { return WebDriver.GetElement(By.XPath("//*[text()='Source Application']//preceding::input[1]//ancestor::li")); } }


public IWebElement Dpid_Preference_Row { get { return WebDriver.GetElement(By.XPath("//span[text()='DPID']//preceding::input[1]//ancestor::li")); } }


public IWebElement Companyname_Preference_Row { get { return WebDriver.GetElement(By.XPath("//span[text()='Company Name']//preceding::input[1]//ancestor::li")); } }


public IWebElement QuoteNumber_Preference_Row { get { return WebDriver.GetElement(By.XPath("//span[text()='Quote Number']//preceding::input[1]//ancestor::li")); } }
        // [FindsBy(How = How.XPath, Using = "//*[text()='Save Date']//preceding::input[1]//ancestor::li")]
        // public IWebElement Savedatelist;

        // [FindsBy(How = How.XPath, Using = "//*[text()='Company Name']//preceding::input[1]//ancestor::li")]
        // public IWebElement CompanyNamelist;

        // [FindsBy(How = How.XPath, Using = "//*[text()='Company Number']//preceding::input[1]//ancestor::li")]
        //  public IWebElement CompanyNumberlist;


public IWebElement SourceApplication_Validationmessage { get { return WebDriver.GetElement(By.XPath("//div[@class='twoColumnGridRightWithNoBottonPadding']/div/div/div/div/span")); } }


public IWebElement PoExctMatchChkBx { get { return WebDriver.GetElement(By.Id("Order_poExactMatch")); } }


public IWebElement ClmnPrefPOchkBx { get { return WebDriver.GetElement(By.XPath("//span[text()='PO']//preceding::input[1]")); } }


public IWebElement BtnOpenColPrefOrdersTab { get { return WebDriver.GetElement(By.XPath(".//*[@id='main']//orders-report//button[contains(text(),'Column Preferences')]")); } }


public IWebElement CompanyName_preference_ChkBx { get { return WebDriver.GetElement(By.XPath("//span[text()='Company Name']//preceding::input[1]")); } }


public IWebElement QuoteNumber_preference_ChkBx { get { return WebDriver.GetElement(By.XPath("//span[@class='dragGrip']//following::span[text()='Quote Number']//preceding::input[1]")); } }


public IWebElement DPID_preference_ChkBx { get { return WebDriver.GetElement(By.XPath("//span[text()='DPID']//preceding::input[1]")); } }


public IWebElement OrderSearchCount { get { return WebDriver.GetElement(By.XPath("//div[@class='col-md-3']/strong")); } }


public IWebElement OrderNumber_preference_ChkBx { get { return WebDriver.GetElement(By.XPath("//span[text()='Order Number']//preceding::input[1]")); } }

public IWebElement LinkedOrderNumber_preference_ChkBx { get { return WebDriver.GetElement(By.XPath("//span[@class='dragGrip']//following::span[text()='Linked Order Numbers']//preceding::input[1]")); } }



public IWebElement DpidNumberLink { get { return WebDriver.GetElement(By.XPath("//div[@col-id='dpid']/grid-hyperlink-cell/a")); } }

public IWebElement OrderNumberLink { get { return WebDriver.GetElement(By.XPath("//div[@col-id='orderNumber']/grid-hyperlink-cell/a")); } }

public IWebElement QuoteNumberLink { get { return WebDriver.GetElement(By.XPath("//div[@col-id='quoteNumber']/grid-hyperlink-cell/a")); } }

public IWebElement LinkedOrderNumberLink { get { return WebDriver.GetElement(By.XPath("//div[@col-id='linkedOrderNumbers']/grid-hyperlink-cell/a")); } }




public IWebElement DatePickerPreviousBtn { get { return WebDriver.GetElement(By.XPath("//table[@aria-activedescendant='activeDateId']/thead/tr/th/button[@tabindex='-1']")); } }



public IWebElement DatePickerPreviousYears { get { return WebDriver.GetElement(By.XPath("//table[@role='grid']/thead/tr/th/button[@tabindex='-1']")); } }



public IWebElement MnthFisrtValue { get { return WebDriver.GetElement(By.XPath("//span[text()='01']")); } }


public IWebElement OrderStatusBtn { get { return WebDriver.GetElement(By.XPath("//label[text()='Order Status:']//following::button[1]")); } }



public IWebElement OrderStatusSlctDeslctChkBx { get { return WebDriver.GetElement(By.XPath("//span[text()='CANCELLED']//preceding::input[1]//preceding::input[1]")); } }


public IWebElement OrderStatusPODChkBx { get { return WebDriver.GetElement(By.XPath("//span[text()='Proof of Delivery (POD)']//preceding::input[1]")); } }


public IWebElement OrderStatus { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_AllOrderHeader_orderStatus_0']")); } }


public IWebElement Calenderbtn { get { return WebDriver.GetElement(By.XPath("//span[@class='k-icon k-i-calendar']")); } }



public IWebElement OrdrstatusShipped { get { return WebDriver.GetElement(By.XPath("//*[@id='reportFilters']/dropdown-multiselect-hierarchial//span[text()='Shipped/Closed (CL)']")); } }


public IWebElement OrdrstatusExport { get { return WebDriver.GetElement(By.XPath("//*[@id='reportFilters']/dropdown-multiselect-hierarchial//span[text()='Export compliance']")); } }


public IWebElement OrdrstatusReject { get { return WebDriver.GetElement(By.XPath("//*[@id='reportFilters']/dropdown-multiselect-hierarchial//span[text()='Reject']")); } }


public IWebElement OrdrstatusComplete { get { return WebDriver.GetElement(By.XPath("//*[@id='reportFilters']/dropdown-multiselect-hierarchial//span[text()='Complete (GCMP) / Booked (BK)']")); } }


public IWebElement OrdrstatusPreprod { get { return WebDriver.GetElement(By.XPath("//*[@id='reportFilters']/dropdown-multiselect-hierarchial//span[text()='Pre-Production (100)']")); } }

public IWebElement OrdrstatusInprod { get { return WebDriver.GetElement(By.XPath("//*[@id='reportFilters']/dropdown-multiselect-hierarchial//span[text()='In-Production (200)']")); } }


public IWebElement OrdrstatusDelivered { get { return WebDriver.GetElement(By.XPath("//*[@id='reportFilters']/dropdown-multiselect-hierarchial//span[text()='Proof of Delivery (POD)']")); } }

public IWebElement OrdrstatusInvoice { get { return WebDriver.GetElement(By.XPath("//*[@id='reportFilters']/dropdown-multiselect-hierarchial//span[text()='Invoice (IN)']")); } }


public IWebElement PoNumberAlartmessage { get { return WebDriver.GetElement(By.XPath("//div[@class='alert']/div/span")); } }


public IWebElement AccountNumberTextBox { get { return WebDriver.GetElement(By.Id("Order_search_accountNumber")); } }


public IWebElement SalesRepTypeButton { get { return WebDriver.GetElement(By.XPath("(//label[@id = 'Order_search_salesRepType']//following::button[@class= 'btn btn-default dropdown-toggle'])[1]")); } }


public IWebElement AlertMessage { get { return WebDriver.GetElement(By.XPath("//div[@class = 'alert-warning']")); } }


public IWebElement SearchButton { get { return WebDriver.GetElement(By.XPath("//button[contains(@id,'searchButton')]")); } }


public IWebElement QuoteStatusDropDown { get { return WebDriver.GetElement(By.XPath(" (//label[text() = 'Quote Status:']//following::div/select)[1]")); } }
       

        #region Date_Element_Locators


public IWebElement fromDateText { get { return WebDriver.GetElement(By.XPath("(//span[@class = 'k-picker-wrap k-state-default']//input[contains(@class, 'form-control form-input k-input input-sm')])[1]")); } }


public IWebElement toDateText { get { return WebDriver.GetElement(By.XPath("(//span[@class = 'k-picker-wrap k-state-default']//input[contains(@class, 'form-control form-input k-input input-sm')])[2]")); } }


public IWebElement fromCalenderbtn { get { return WebDriver.GetElement(By.XPath("(//span[@class='k-icon k-i-calendar'])[1]")); } }


public IWebElement toCalenderbtn { get { return WebDriver.GetElement(By.XPath("(//span[@class='k-icon k-i-calendar'])[2]")); } }


public IWebElement MonthYearLabel { get { return WebDriver.GetElement(By.XPath("//button[@class = 'btn btn-default btn-secondary btn-sm']")); } }


public IWebElement pullLeftButton { get { return WebDriver.GetElement(By.XPath("//button[contains(@class, 'pull-left float-left')]")); } }


public IWebElement pullRightButton { get { return WebDriver.GetElement(By.XPath("//button[contains(@class, 'btn-sm pull-right float-right')]")); } }


public IList<IWebElement> orderDateColumns { get { return WebDriver.GetElements(By.XPath("//div[@class = 'ag-pinned-left-cols-container']//grid-date-cell")); } }


public IWebElement CustomerNumber { get { return WebDriver.GetElement(By.XPath("//input[@id = 'Order_search_customerNumber']")); } }


public IWebElement FromDateField { get { return WebDriver.GetElement(By.XPath("(//div[@class = 'dsa-control-group date']//input[contains(@class, 'form-control form-input k-input input-sm')])[1]")); } }


public IWebElement ToDateField { get { return WebDriver.GetElement(By.XPath("(//div[@class = 'dsa-control-group date']//input[contains(@class, 'form-control form-input k-input input-sm')])[2]")); } }


public IWebElement HideFilter { get { return WebDriver.GetElement(By.XPath("//div[@class = 'searchFiltersExpanded']")); } }


public IWebElement OrderStatusLabel { get { return WebDriver.GetElement(By.XPath("//label[@id = 'Order_search_salesRepType']//following::label[text() = 'Order Status:']")); } }


public IWebElement FromLabel { get { return WebDriver.GetElement(By.XPath("//label[@id = 'Order_search_createDate' and text() = 'From: ']")); } }


public IWebElement ToLabel { get { return WebDriver.GetElement(By.XPath("//label[@id = 'Order_search_createDate' and text() = 'To: ']")); } }



public IWebElement SalesRepMultiSelectButton { get { return WebDriver.GetElement(By.XPath("(((//label[@id= 'Order_search_salesRepType'])[1])//following::button)[1]")); } }

        #endregion

        #endregion

        public ReportingPage SearchQuoteHistory(string createByEmail = "", string salesRep = "")
        {
            BtnQuoteTab.Click(WebDriver);
            new ReportingPage(WebDriver).WaitForBusyIndicator(WebDriver);

            if (!string.IsNullOrEmpty(createByEmail))
                TxtQuoteHistoryCreatedBy.SetText(WebDriver, createByEmail);
            else if (!string.IsNullOrEmpty(salesRep))
                TxtQuoteHistorySalesRep.SetText(WebDriver, salesRep);

            BtnQuoteHistorySearch.Click(WebDriver);
            return this;
        }

        //public ReportingPage SearchDpidHistory(string createByEmail = "", string salesRep = "")
        //{
        //    BtnDpidTab.Click(WebDriver);
        //    if (!string.IsNullOrEmpty(createByEmail))
        //        TxtOrderHistoryCreatedBy.SetText(WebDriver, createByEmail);
        //    else if (!string.IsNullOrEmpty(salesRep))
        //        TxtOrderHistorySalesRep.SetText(WebDriver, salesRep);

        //    BtnOrderHistorySearch.Click(WebDriver);
        //    return this;
        //}

        public ReportingPage SearchOrderHistory(string salesRep = "", string custNumber = "", string po = "")
        {
            BtnOrderTab.Click(WebDriver);
            if (!string.IsNullOrEmpty(salesRep))
                TxtGossHistorySalesRep.SetText(WebDriver, salesRep);

            if (!string.IsNullOrEmpty(custNumber))
                TxtGossHistoryCustomerNumberNumber.SetText(WebDriver, custNumber);

            if (!string.IsNullOrEmpty(po))
                TxtGossHistoryPoNumber.SetText(WebDriver, po);

            BtnGossHistorySearch.Click(WebDriver);
            return this;
        }

        public List<IWebElement> GetAllQuoteNumberDivs()
        {
            return WebDriver.GetElements(
                    By.XPath(
                        @"//*[contains(@class,'ui-grid-render-container-body')]/div[contains(@class,'ui-grid-viewport')]" +
                        @"//div[contains(@class,'ui-grid-row')]//a[contains(@href, 'details/QuoteNumber')]"));
        }

        public bool SalesRepIdExists()
        {
            return string.IsNullOrWhiteSpace(TxtGossHistorySalesRep.GetText(WebDriver));
        }

        public void Verify()
        {
            WebDriver.FindElement(By.XPath(".//*[@id='main']//orders-report//button[@value='Columns']"));
        }

        public OrderDetailsPage ClickDpidFromResult()
        {
            DivGossOrdersList.FindElement(By.CssSelector("table > tbody > tr:nth-child(1) > td:nth-child(4) > a")).Click(WebDriver);
            return new OrderDetailsPage(WebDriver);
        }

        //public QuoteDetailsPage ClickQuoteNumberFromResult()
        //{
        //    DivQuoteSearchList.FindElement(By.CssSelector("table > tbody > tr:nth-child(1) > td:nth-child(5) > a")).Click(WebDriver);
        //    return new QuoteDetailsPage(WebDriver);
        //}

        //public QuoteDetailsPage ClickQuoteDetailsPagingMenu()
        //{
        //    if (QuoteSearchPagination2ndPage.Displayed)
        //    {
        //        GridPagingItem.Click();
        //        Option20items.Click();
        //        QuoteSearchPagination2ndPage.Click();
        //    }
        //    return new QuoteDetailsPage(WebDriver);
        //}

        public bool ClickOrderDetailsPagingMenu()
        {
            if (OrderListPaginationList.Count > 1)
            {
                OrderListPaginationList[1].Click();
                return true;
            }
            else
            {
                GridPagingItem.Click();
                Option20items.Click();
                WaitForBusyIndicator(WebDriver);
                OrderListPaginationList[1].Click();
                return true;
            }

        }

        public void WaitForBusyIndicator(IWebDriver Driver)//Changes Done As Per New UI Works Fine
        {
            WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(1));
            Wait.Until(
              ExpectedConditions.InvisibilityOfElementLocated(
                  By.XPath(".//*[@id='busy-indicator']")));
            System.Threading.Thread.Sleep(1000 * 30);
        }


        public string GetFirstValueFromColumn(string ColumnName)//Changes Done As Per New UI Works Fine For Quotes and Orders Tab
        {
            string xpath = $"//div[contains(@col-id, '{ColumnName}')]";

            IList<IWebElement> AllCell = WebDriver.FindElements(By.XPath(xpath));
            if (AllCell.Count > 0)
            {
                if (ColumnName == "orderNumber")
                {
                    return AllCell[0].FindElement(By.TagName("grid-hyperlink-cell")).Text;
                }
                else
                {
                    //GetText(webdriver) is not returning full text. Hence updated this as below                
                    return AllCell[0].Text;
                    //.FindElement(By.TagName("span")).GetAttribute("title");
                }

            }
            else
            {
                return string.Empty;
            }
        }


        public string GetItemDescription(int index)
        {
            index = index + 1;
            string text = WebDriver.FindElement(By.XPath($"(//div[@col-id = 'description'])[{index}]")).Text;
            return text;
        }

        public void ClickFirstHyperlinkByColumn(string ColumnName)//need modification
        {
            try
            {
                string xpath = $"//div[@col-id = '{ColumnName}']";
                IList<IWebElement> AllCell = WebDriver.FindElements(By.XPath(xpath));
                if (AllCell.Count > 0)
                {
                    AllCell[1].Click();

                }
                else
                {
                    throw new Exception("There is No Value In The Grid");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //public string OrderStatusMapping(string OrderStatusFromGrid, bool reversemap = false)
        //{
        //    string status = "";
        //    if (reversemap)
        //    {
        //        switch (OrderStatusFromGrid)
        //        {
        //            case "In Production (200)":
        //                status = "In-Production";
        //                break;
        //            case "Order is on HOLD (HLD)":
        //                status = "Hold";
        //                break;

        //        }
        //    }
        //    else
        //    {
        //        switch (OrderStatusFromGrid)
        //        {
        //            case "In-Production":
        //                status = "In Production (200)";
        //                break;
        //            case "Hold":
        //                status = "Order is on HOLD (HLD)";
        //                break;

        //        }
        //    }


        //    return status;
        //}

        //public void ClearOrderStatusFilter()
        //{
        //    new ReportingPage(WebDriver).BtnOrderStatus.Click();
        //    System.Threading.Thread.Sleep(1000 * 10);
        //    //Deselect All 
        //    OpenQA.Selenium.IWebElement Select_Deselect = new ReportingPage(WebDriver).SelectAllOrderStatusCheckBox;


        //    //If All Selected or Select/DeSelect Is Checked With 2-3 Items Clickc Once To DeselectAll
        //    if (Select_Deselect.Selected)
        //    {
        //        Select_Deselect.Click();
        //    }
        //    //If Select/DeSelect is Not Checked But only 2/3 Items Checked Click Twice To Deselect All
        //    else
        //    {
        //        {
        //            Select_Deselect.Click();
        //            Select_Deselect.Click();
        //        }
        //    }
        //}

        public void SelectOrderStatusFilter(string orderstatus)//Updated With New UI
        {
            OrdersBeta_OrderStatusDropDown.Click();
            //Uncheck All
            BtnSelectDeselectOrderStatus.Click();

            var SelectedOrderStatusXpath = @".//*[@id='reportFilters']/dropdown-multiselect-hierarchial//span[text()='" + orderstatus + "']";
            IWebElement OrderStatusElement = WebDriver.FindElement(By.XPath(SelectedOrderStatusXpath));
            OrderStatusElement.Click();


            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            js.ExecuteScript("arguments[0].click();", new HomePage(WebDriver).LbldsaTitle);
        }

        public void Orders_SelectColumnFilter(string columnname)//updated as per new UI
        {
          //Select Column
         IWebElement ColumnName = WebDriver.FindElement(By.XPath(
                        ".//column-preferences//span[contains(text()," + "'" + columnname + "'" + ")]/parent::div/input"));
                new OpenQA.Selenium.Interactions.Actions(WebDriver).MoveToElement(ColumnName).Click().Build().Perform();
            }


        public void ClearColumnPreferences()//updated as per new UI
        {
            try
            {
                System.Threading.Thread.Sleep(10 * 1000);
                new ReportingPage(WebDriver).WaitForBusyIndicator(WebDriver);
                IWebElement Select_DeselectColumn = new ReportingPage(WebDriver).Select_DeselectColumnPref;

                if (Select_DeselectColumn.Selected)
                {
                    Select_DeselectColumn.Click();
                    System.Threading.Thread.Sleep(5 * 1000);
                }
                else
                {
                    //Select_DeselectColumn.Click();
                    WebDriverUtil.JavaScriptClick(WebDriver, Select_DeselectColumn);
                    System.Threading.Thread.Sleep(5 * 1000);
                    //Select_DeselectColumn.Click();
                    WebDriverUtil.JavaScriptClick(WebDriver, Select_DeselectColumn);
                    System.Threading.Thread.Sleep(5 * 1000);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<string> GetAllColumnValues_Page1(string ColName)//updated with New UI
        {
            //Old Code
            //ReadOnlyCollection<IWebElement> Columns = WebDriver.FindElements
            //    (By.XPath(
            //    @".//*[@id='borderLayout_eGridPanel']//div[ @col-id='" + ColName + "'][@role='gridcell']"));

            //New Code
            ReadOnlyCollection<IWebElement> Columns = WebDriver.FindElements
              (By.XPath($"//div[contains(@col-id, '{ColName}')][@role='gridcell']"));

            //Check if We have Data Available
            List<string> ColumnValues = new List<string>();
            foreach (IWebElement element in Columns)
            {
                ColumnValues.Add(element.GetText(WebDriver));
            }

            return ColumnValues;
        }

        public ReadOnlyCollection<IWebElement> QuoteTabRows(string ColName)
        {
            ReadOnlyCollection<IWebElement> allRows = WebDriver.FindElements(By.XPath($"//div[contains(@col-id, '{ColName}')][@role='gridcell']"));
            return allRows;
        }

        public ReadOnlyCollection<IWebElement> OrderTabRows(string ColName)
        {
            ReadOnlyCollection<IWebElement> allRows = WebDriver.FindElements(By.XPath($"//div[contains(@col-id, '{ColName}')]"));
            return allRows;
        }
        //div[contains(@col-id, '')][@col-id='orderDate']

        public void PopulateDataByChangingDate()//updated with New UI
        {
            int ResultDisplayed = 1;

            try
            {
                while (ResultDisplayed <= 3)
                {
                    OrdersBeta_FromDate.Click();
                    string SelectedDefaultDate = OrdersBetaFromDate_SelectedDate.GetText(WebDriver);
                    //New Logic
                    //ReadOnlyCollection<IWebElement> Dates= WebDriver.FindElements(By.XPath(".//*[@id='orderBeta_search_fromDate_dateview']/descendant::td[contains(@class,'k-other-month')]"));
                    string NewSearchDate = (int.Parse(SelectedDefaultDate) - ResultDisplayed).ToString();
                    if (int.Parse(NewSearchDate) < 1)
                    {
                        NewSearchDate = (30 - ResultDisplayed).ToString();
                    }
                    if (int.Parse(NewSearchDate) >= 1 && int.Parse(NewSearchDate) <= 9)
                    {
                        NewSearchDate = "0" + NewSearchDate;
                    }
                    string NewDate = ".//daypicker//tbody//td//button[contains(@class,'btn-default')]/span[text()=" + "'" + NewSearchDate + "']";

                    WebDriver.FindElement(By.XPath(NewDate)).Click();
                    System.Threading.Thread.Sleep(1000 * 3);
                    BtnOrderBetaSearch.Click();
                    WaitForBusyIndicator(WebDriver);
                    if (!WebDriver.WaitForElementDisplay(MsgOrdersBetaNoResult))
                    {
                        break;
                    }
                    else { ResultDisplayed++; }
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool VerifyDefaultSalesRepType()
        {

            if (SalesRepType_Dropdownselection.Count == 4)
            {
                return SalesRepType_Dropdownselection[0].Text == "Select / Deselect All" &&
                       SalesRepType_Dropdownselection[1].Text == "Primary" &&
                       SalesRepType_Dropdownselection[2].Text == "Secondary" &&
                       SalesRepType_Dropdownselection[3].Text == "Processor/Creator";
            }
            return false;

        }
        public List<string> GetAllColumnValues(string ColName)
        {

            ReadOnlyCollection<IWebElement> Columns = WebDriver.FindElements(By.XPath($"//div[contains(@col-id, '{ColName}')][@role='gridcell']"));

            List<string> ColumnValues = new List<string>();
            foreach (IWebElement element in Columns)
            {
                //Remove $ from Text
                string filteredText = element.GetText(WebDriver);
                filteredText = filteredText.Substring(1);
                ColumnValues.Add(filteredText);
            }

            return ColumnValues;
        }

        public void draganddrop(IWebElement srcelmnt, IWebElement dstelmnt, IWebDriver webdriver)
        {
            OpenQA.Selenium.Interactions.Actions ac = new OpenQA.Selenium.Interactions.Actions(webdriver);
            //       Actions action = new Actions(driver);
            //  ac.KeyDown()


            IWebElement srcelm = webdriver.FindElement(By.XPath("//*[text()='Source Application']//preceding::input[1]//preceding::div[1]/span"));
            IWebElement destelm = webdriver.FindElement(By.XPath("//*[text()='LOB']//preceding::input[1]//preceding::div[1]/span"));

            //*[text()='Source Application']//preceding::input[1]//preceding::div[1]/span
            ac.ClickAndHold(srcelmnt).MoveToElement(dstelmnt).Release(dstelmnt).Build().Perform();
            // ac.ClickAndHold(srcelm).MoveToElement(destelm).Release(destelm).Build().Perform();
            //ac.DragAndDrop(srcelmnt, dstelmnt).Build().Perform();
            //  ac.ClickAndHold(srcelmnt).KeyDown(Keys.ArrowUp).KeyUp(Keys.ArrowUp).Build().Perform();

        }

        public void ClickLinksSwitchTowindowAndVerifyUrl(String Parentwindow, IWebDriver webdriver, String Column, IWebElement ColumnLink, String URL)
        {
            string parentWindow = webdriver.CurrentWindowHandle;
            Thread.Sleep(3000);

            IList<string> columnvalues = GetAllColumnValues_Page1(Column);
            for (int i = 0; i < columnvalues.Count; i++)
            {

                if (columnvalues.ElementAt(i).Length > 0)
                {
                    ColumnLink.Click();


                    foreach (string window in webdriver.WindowHandles)
                    {
                        if (window != parentWindow)
                        {
                            webdriver.SwitchTo().Window(window);
                            webdriver.VerifyBusyOverlayNotDisplayed();
                            webdriver.Url.Contains(URL).Should().Be(true);

                            Logger.Write("Window Switched to " + webdriver.Url);
                            webdriver.Close();
                            webdriver.SwitchTo().Window(Parentwindow);


                        }

                    }
                    Thread.Sleep(3000);

                }
                break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webdriver"></param>
        /// <param name="date"></param>
        public void DateFromFunction(IWebDriver webdriver, string date)
        {
            DateSelector(webdriver, date, fromCalenderbtn);
        }

        public void DateToFunction(IWebDriver webdriver, string date)
        {
            DateSelector(webdriver, date, toCalenderbtn);
        }

        public IWebElement MonthElement(int monthIndex)
        {
            return WebDriver.GetElement(By.Id(string.Format("//*[contains(text(), '{0}')]", monthIndex)), TimeSpan.FromSeconds(3));
        }

        public void DateSelector(IWebDriver webdriver, string date, IWebElement calenderIcon)
        {

            webdriver.VerifyBusyOverlayNotDisplayed();
            calenderIcon.WaitForElement(webdriver);
            calenderIcon.Click();
                
            string month = date.Split('/')[0];
            string dd = date.Split('/')[1];
            string year = date.Split('/')[2];

            Logger.Write("Wait for the from calender element to display");
            WebDriverUtil.WaitForElementDisplay(webdriver, fromDateText, TimeSpan.FromSeconds(5));

            string selectedFromDate = fromDateText.GetText(webdriver);

            int selectedYear = int.Parse(selectedFromDate.Substring(selectedFromDate.Length - 4));
            int reqYear = int.Parse(year);

            if (selectedYear != reqYear)
            {
                string yearLabel = MonthYearLabel.Text;
                var getYear = Regex.Match(yearLabel, @"\d+").Value;

                if (selectedYear > reqYear)
                {
                    while (int.Parse(getYear) != int.Parse(year))
                    {
                        Logger.Write("clicks on privios year button");
                        WebDriverUtil.JavaScriptClick(webdriver, pullLeftButton);
                        yearLabel = MonthYearLabel.Text;
                        getYear = Regex.Match(yearLabel, @"\d+").Value;
                        webdriver.WaitForElementDisplay(MonthYearLabel, TimeSpan.FromSeconds(5));
                    }
                }

                else if (selectedYear < reqYear)
                {
                    Logger.Write("Clicks right for next future year");

                    while (int.Parse(getYear) != int.Parse(year))
                    {
                        WebDriverUtil.JavaScriptClick(webdriver, pullRightButton);
                        yearLabel = MonthYearLabel.Text;
                        getYear = Regex.Match(yearLabel, @"\d+").Value;
                        webdriver.WaitForElementDisplay(MonthYearLabel, TimeSpan.FromSeconds(5));
                    }
                }
            }

            Logger.Write("For selecting month");
            string getMonth = MonthYearLabel.Text;
            getMonth = Regex.Replace(getMonth, "[^a-zA-Z]", "");
            MonthYearLabel.WaitForElement(webdriver);
            MonthYearLabel.Click();

            //Convert month number to alphabet Month
            int intMonth = int.Parse(month);
            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(intMonth);
            IWebElement monthElement = MonthElement(monthName);

            DsaUtil.IsElementClickable(monthElement, webdriver, TimeSpan.FromSeconds(5));
            WebDriverUtil.JavaScriptClick(webdriver, monthElement);

            Logger.Write("For selecting date");
            IWebElement dateElement = DayElement(dd);
            DsaUtil.IsElementClickable(dateElement, webdriver, TimeSpan.FromSeconds(5));
            dateElement.Click();
        }

        public IWebElement MonthElement(string monthName)
        {
            return WebDriver.GetElement(By.XPath(string.Format("//*[contains(text(), '{0}')]", monthName)), TimeSpan.FromSeconds(3));
        }

        public IWebElement DayElement(string dayIndex)
        {
            return WebDriver.GetElement(By.XPath(string.Format("(//*[contains(@id, 'datepicker')]//button/span[contains(text(), '{0}')])[2]", dayIndex)), TimeSpan.FromSeconds(3));
        }

        /// <summary>
        /// Verifies Order Date Cloumn - Boundary Validation FromDate & ToDate
        /// </summary>
        /// <param name = "webDriver" ></ param >
        /// < param name="fromDate"></param>
        /// <param name = "toDate" ></ param >
        /// < returns ></ returns >
        public bool VerifyOrderDateColumn(string fromDate, string toDate)
        {
            bool result = false;

            for (int i = 0; i < orderDateColumns.Count; i++)
            {
                if (orderDateColumns[i].Text == fromDate || orderDateColumns[i].Text == toDate)
                {
                    WebDriver.WaitForElementDisplay(orderDateColumns[i], TimeSpan.FromSeconds(4));
                    result = true;
                }
            }
            return result;
        }

        public bool VerifyCustomerNumber(string expected)
        {
            bool result = false;

            if (expected == CustomerNumber.GetAttribute("ng-reflect-model"))
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// Method verifies if From and To Date has the difference with the given input 30 and 120
        /// </summary>
        /// <param name="DaysComparision"></param>
        /// <returns></returns>
        public bool VerifyCalenderDuration(int DaysComparision, IWebDriver webDriver)
        {
            bool compareDate = false;

            WebDriverUtil.VerifyBusyOverlayNotDisplayed(webDriver);

            Logger.Write("Gets current TO-Date from System");
            string currentToDate = DateTime.Now.ToString("MM/dd/yyyy");

            Logger.Write("Gets current TO-Date from Application");
            WebDriverUtil.WaitForElementDisplay(webDriver, FromDateField, TimeSpan.FromSeconds(5));
            string toDate = ToDateField.GetText(webDriver);

            Logger.Write("Gets current From-Date from Application");
            WebDriverUtil.WaitForElementDisplay(webDriver, FromDateField, TimeSpan.FromSeconds(5));
            string fromDate = FromDateField.GetText(webDriver);

            Logger.Write("Decrese current date by given input number of days for comparision");
            string pastDate = DateTime.Today.AddDays(-DaysComparision).ToString("MM/dd/yyyy");

            if (currentToDate == toDate)
            {
                compareDate = true;
            }
            if (pastDate == fromDate)
            {
                compareDate = true;
            }
            else
            {
                compareDate = false;
            }

            return compareDate;
        }

        public bool VerifyDateDurationCustomerNumber(IWebDriver webDriver, IWebElement link, string customer_Number, string url, int durationDays)
        {
            bool IsDurationMatch = false;
            WebDriverUtil.VerifyBusyOverlayNotDisplayed(webDriver);

            string parentWindow = webDriver.CurrentWindowHandle;

            foreach (string window in webDriver.WindowHandles)
            {

                IList<string> childWindows = webDriver.WindowHandles;

                if (childWindows.Last() != parentWindow)
                {
                    webDriver.SwitchTo().Window(childWindows.Last());

                    IsDurationMatch = VerifyCustomerNumber(customer_Number);

                    IsDurationMatch = VerifyCalenderDuration(durationDays, webDriver);

                    if (webDriver.Url.Contains(url))
                    {
                        Logger.Write("Window Switched to " + webDriver.Url);
                        webDriver.Close();
                        webDriver.SwitchTo().Window(parentWindow);
                    }
                }
            }
            return IsDurationMatch;
        }

        /// <summary>
        /// Gets the Count of the Column Preferences
        /// </summary>
        /// <returns></returns>
        public int GetColumnCount()
        {
            int count = AllColumns.Count();
            return count;
        }

        /// <summary>
        /// Clears All Preferences Except One to Save Preference
        /// </summary>
        /// <param name="columnNameToSelect"></param>
        public void ClearAllColumnsExceptOne(IWebDriver driver, string columnNameToSelect)
        {
            //First Click Selects All
            WebDriverUtil.JavaScriptClick(driver, SelectAll_ChkBX);

            Thread.Sleep(5000);
            SelectAll_ChkBX.UnSelectCheckBox(driver);

            //Select Column
            Orders_SelectColumnFilter(columnNameToSelect);


            //click Save for Saving Prefernces
            Thread.Sleep(3000);
            WebDriverUtil.JavaScriptClick(driver, BtnSaveColPref);

            driver.VerifyBusyOverlayNotDisplayed();
        }

        public bool VerifyColumnPresent(IWebDriver webDriver, string columnText)
        {
            IWebElement ele = WebDriver.GetElement(By.XPath($"//grid-hedercomponent-cell//*[contains(text(), '{columnText}')]"));
            WebDriverUtil.WaitForElementPresentinDom(webDriver, By.XPath($"//grid-hedercomponent-cell//*[contains(text(), '{columnText}')]"));
            webDriver.WaitForElementDisplay(ele, TimeSpan.FromSeconds(10));
            bool Isdisplayed = ele.Displayed;
            return Isdisplayed;
        }

        public IWebElement GetSourceApplicationListItem(string itemName)
        {
            //ul/li/label[contains(text(),' DSAPARTNER ')]
           return WebDriver.FindElement(By.XPath($"//ul/li/label[contains(text(), ' {itemName} ')]"));
        }
        public void SelectSourceApplicationDropDown(IWebDriver webDriver, string textToBeSelected)
        {
            SourceApplication_Dropdownselection.Click();
            //DsaUtil.UnSelectCheckBox(SelectDeselect_ChkBx, webDriver);
            webDriver.FindElement(By.XPath("(//label[contains(text(),  'Select / Deselect All ')])[1]")).Click();
            SourceApplication_Dropdownselection.Click();
            IWebElement itemtoBeSelected = GetSourceApplicationListItem(textToBeSelected);
            itemtoBeSelected.Click();
        }

        public void SearchPONumber(string poNumber, IWebDriver webDriver)
        {
            for (int i = 1; i < 3; i++)
            {
                string fromDate = DateTime.Now.AddDays(-30 * i).ToString("MM/dd/yyyy");
                Logger.Write("Date Selection from Text Box");
                DateFromFunction(webDriver, fromDate);

                OrdersBeta_PurchaseOrderNo.SetText(webDriver, poNumber, TimeSpan.FromSeconds(10));
                BtnOrderBetaSearch.Click();

                if (WebDriverUtil.WaitForElementDisplay(webDriver, By.XPath($"//a[text() = '{poNumber}']"), TimeSpan.FromSeconds(3)) == true)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// ** Working Code For Verifing Input Mathces Corresponding Columns Values in all the Rows
        /// </summary>
        /// <param name="columnNames"></param>
        /// <param name="verifyAllRowMatchValue"></param>
        public bool VerifyColumnsTableValues(IWebDriver driver, IList<string> columnNames, IList<string> verifyAllRowMatchValue, int displayPerPage = 0, int numberofPagesToVerify = 0)
        {
            bool isMatching = false;
            List<string> allHeaders = new List<string>();
            List<string> allRows = new List<string>();
            Dictionary<string, List<string>> allColumnRows = new Dictionary<string, List<string>>();

            for (int pageNumber = 1; pageNumber <= numberofPagesToVerify; pageNumber++)
            {
                if (pageNumber > 0)
                {
                    IWebElement paginationBySequence = driver.FindElement(By.XPath($"//a/div[contains(text(), '{pageNumber.ToString()}')]"));
                    paginationBySequence.Click();
                    driver.VerifyBusyOverlayNotDisplayed();
                }

                //Find Display Drop Down and change value as per number of records needed
                if (displayPerPage != 0)
                {
                    IWebElement webElement = driver.FindElement(By.XPath("//select[@id = 'grid_paging_itemsPerPage']"));

                    SelectElement selectElement = new SelectElement(webElement);

                    string itemsperPage = " 0 per page ";

                    itemsperPage = itemsperPage.Replace("0", displayPerPage.ToString());

                    selectElement.SelectByText(itemsperPage);

                    driver.VerifyBusyOverlayNotDisplayed();

                }

                //To Get all the Headers
                for (int c = 0; c < columnNames.Count; c++)
                {
                    string headerName = columnNames[c];
                    string header = driver.FindElement(By.XPath($"//grid-hedercomponent-cell//*[contains(text(), '{headerName}')]")).Text;
                    allHeaders.Add(header);
                }

                //Get Total Number of User Input Headers
                for (int j = 0; j < columnNames.Count; j++)
                {
                    Logger.Write("Add All Column Headers");
                    string colId = ConvertColumnsNames(columnNames[j]);

                    IList<IWebElement> allValuesRead = driver.FindElements(By.XPath($"//div[contains(@col-id,'{colId}')]"));

                    List<string> rowTextValues = new List<string>();

                    for (int i = 1; i < allValuesRead.Count; i++)
                    {
                        rowTextValues.Add(allValuesRead[i].Text.ToLower()); //To avoid Conflict of Caps Converted to Lower
                        string independentVal = verifyAllRowMatchValue[j].ToLower();

                        if (allValuesRead[i].Text.Contains(independentVal))
                        {
                            isMatching = true;

                        }
                        else
                        {
                            Logger.Write("Expected Text is ****" + verifyAllRowMatchValue[j]);
                            Logger.Write("Actual Text is ****" + allValuesRead[i].Text);

                            isMatching = false;
                            break;
                        }
                    }
                }
            }
            return isMatching;
        }

        /// <summary>
        /// Get Table By Pagination and to Match Row Values in Excel
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="columnNames"></param>
        /// <param name="rowsValues"></param>
        /// <param name="displayPerPage"></param>
        /// <param name="numberofPagesToVerify"></param>
        /// <returns></returns>
        public Dictionary<string, IList<string>> GetTableDataToMatchExcel(IWebDriver driver, IList<string> columnNames, int rowsValues, int displayPerPage, int numberofPagesToVerify = 1)
        {
            List<string> allHeaders = new List<string>();
            List<string> allRows = new List<string>();

            Dictionary<string, IList<string>> allColumnRows = new Dictionary<string, IList<string>>();

            //Find Display Drop Down and change value as per number of records needed
            if (displayPerPage != 0)
            {
                IWebElement webElement = driver.FindElement(By.XPath("//select[@id = 'grid_paging_itemsPerPage']"));
                SelectElement selectElement = new SelectElement(webElement);

                string itemsperPage = " 0 per page ";
                itemsperPage = itemsperPage.Replace("0", displayPerPage.ToString());
                selectElement.SelectByText(itemsperPage);
                driver.VerifyBusyOverlayNotDisplayed();
            }

            //To Get all the Headers
            for (int c = 0; c < columnNames.Count; c++)
            {
                string headerName = columnNames[c];
                string header = driver.FindElement(By.XPath($"//grid-hedercomponent-cell//*[contains(text(), '{headerName}')]")).Text;
                allHeaders.Add(header);
            }

            //Get Total Number of User Input Headers
            for (int j = 0; j < columnNames.Count; j++)
            {
                //Logger.Write("Add All Column Headers");

                List<string> rowTextValues = new List<string>();

                string colId = ConvertColumnsNames(columnNames[j]);

                for (int pageNumber = 1; pageNumber <= numberofPagesToVerify; pageNumber++)
                {
                    IWebElement paginationBySequence = driver.FindElement(By.XPath($"//a/div[contains(text(), '{pageNumber.ToString()}')]"));
                    paginationBySequence.Click();
                    driver.VerifyBusyOverlayNotDisplayed();

                    IList<IWebElement> allValuesRead = driver.FindElements(By.XPath($"//div[contains(@col-id,'{colId}')]"));

                    if (allValuesRead.Count() < rowsValues)
                    {
                        Console.WriteLine("The Total Number of Rows are {0}", allValuesRead.Count());
                        rowsValues = allValuesRead.Count();
                    }


                    for (int i = 1; i < rowsValues; i++)
                    {
                        if (allValuesRead[i].Text == "-")
                        {
                            rowTextValues.Add("0");
                        }
                        else
                        {
                            rowTextValues.Add(allValuesRead[i].Text);
                        }
                    }
                }

                allColumnRows.Add(columnNames[j], rowTextValues);
            }

            return allColumnRows;
        }

       

        private bool CheckDate(String date)
        {
            try
            {
                DateTime dt = DateTime.Parse(date);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Input Required Number of Columns and Rows
        /// </summary>
        /// <param name="colCount"></param>
        /// <param name="rowCount"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public Dictionary<string, IList<string>> GetExcelDataToMatchTable(int colCount, int rowCount, string path)
        {
            Thread.Sleep(5000);
            Excel.Application xlApp = new Excel.Application();
            string filteredPath = path.Replace(".crdownload", "");
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filteredPath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            Dictionary<string, IList<string>> AllRowColumns = new Dictionary<string, IList<string>>();

            for (int j = 2; j <= colCount + 1; j++)
            {
                List<string> rowsValues = new List<string>();

                for (int i = 2; i <= rowCount; i++)
                {

                    //new line
                    if (j == 2)
                        Console.Write("\r\n");

                    string row = Convert.ToString(xlRange.Cells[i, j].Value);

                    if (string.IsNullOrEmpty(row) == false)
                    {
                        if (CheckDate(row))
                        {
                            DateTime oDate = Convert.ToDateTime(row);
                            row = oDate.ToString("MM/dd/yyyy");
                        }

                    }
                    rowsValues.Add(row);
                }
                //Add A Column Keys as a Header and Rows values as List
                AllRowColumns.Add(xlRange.Cells[1, j].Value.ToString(), rowsValues);
            }

            return AllRowColumns;
        }

        public Dictionary<string, IList<string>> GetExcelDataToMatchUnSortedTable(int colCount, string path)
        {

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;


            Dictionary<string, IList<string>> AllRowColumns = new Dictionary<string, IList<string>>();

            for (int j = 2; j <= colCount + 1; j++)
            {
                List<string> rowsValues = new List<string>();

                for (int i = 2; i <= xlRange.Count; i++)
                {

                    //new line
                    if (j == 2)
                        Console.Write("\r\n");

                    string row = Convert.ToString(xlRange.Cells[i, j].Value);

                    if (string.IsNullOrEmpty(row) == false)
                    {
                        if (row.Contains("/"))
                        {
                            DateTime oDate = Convert.ToDateTime(row);
                            row = oDate.ToString("MM/dd/yyyy");
                        }

                    }
                    rowsValues.Add(row);
                }
                //Add A Column Keys as a Header and Rows values as List
                AllRowColumns.Add(xlRange.Cells[1, j].Value.ToString(), rowsValues);
            }

            return AllRowColumns;
        }

        /// <summary>
        /// Verify Quote/Order Status
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="columnNames"></param>
        /// <param name="rowsValues"></param>
        /// <param name="displayPerPage"></param>
        /// <param name="numberofPagesToVerify"></param>
        /// <returns></returns>
        public bool VerifyQuoteStatus(IWebDriver driver, IList<string> columnNames, int rowsValues, int displayPerPage, string quoteStatus, string quoteStatus2 = null, string quoteSeries = "300", int numberofPagesToVerify = 1)
        {
            bool isMathing = true;

            //Find Display Drop Down and change value as per number of records needed
            if (displayPerPage != 0)
            {
                IWebElement webElement = driver.FindElement(By.XPath("//select[@id = 'grid_paging_itemsPerPage']"));
                SelectElement selectElement = new SelectElement(webElement);

                string itemsperPage = " 0 per page ";
                itemsperPage = itemsperPage.Replace("0", displayPerPage.ToString());
                selectElement.SelectByText(itemsperPage);
                driver.VerifyBusyOverlayNotDisplayed();
            }

            //Get Total Number of User Input Headers
            for (int j = 0; j < columnNames.Count; j++)
            {
                //Logger.Write("Add All Column Headers");

                List<string> rowTextValues = new List<string>();

                string colId = ConvertColumnsNames(columnNames[j]);

                for (int pageNumber = 1; pageNumber <= numberofPagesToVerify; pageNumber++)
                {
                    IWebElement paginationBySequence = driver.FindElement(By.XPath($"//a/div[contains(text(), '{pageNumber.ToString()}')]"));
                    paginationBySequence.Click();
                    driver.VerifyBusyOverlayNotDisplayed();

                    IList<IWebElement> allValuesRead = GetQuoteStatus(WebDriver, quoteSeries, colId);

                    if (allValuesRead.Count() < rowsValues)
                    {
                        Console.WriteLine("The Total Number of Rows are {0}", allValuesRead.Count());
                        rowsValues = allValuesRead.Count();
                    }


                    for (int i = 1; i < rowsValues; i++)
                    {
                        if (allValuesRead[i].Text == "-")
                        {
                            rowTextValues.Add("0");
                        }
                        else
                        {
                            rowTextValues.Add(allValuesRead[i].Text);
                        }
                    }

                    if(quoteStatus2 == null)
                    {

                     if (!rowTextValues.Contains(quoteStatus))
                     {
                        isMathing = false;
                     }
                   }
                    else
                    {
                        if (!rowTextValues.Contains(quoteStatus) || !rowTextValues.Contains(quoteStatus2))
                        {
                            isMathing = false;
                        }
                    }
                }
            }
            return isMathing;
        }

        public IList<IWebElement> GetAllQuotesStatusListByType(IWebDriver driver, string quoteSeries, string statusType)
        {
            IList<IWebElement> allValuesRead = driver.FindElements(By.XPath($"//a[starts-with(text(), '{quoteSeries}')]//following::div[text() = '{statusType}']"));
            return allValuesRead;
        }

        public IList<IWebElement> GetQuoteStatus(IWebDriver driver, string quoteSeries, string colName)
        {
            string colId = ConvertColumnsNames(colName);
            IList<IWebElement> allValuesRead = driver.FindElements(By.XPath($"//a[starts-with(text(), '{quoteSeries}')]//following::div[@col-id = '{colId}']"));
            return allValuesRead;
        }

        public IList<IWebElement> GetAllRowsByColumnName(IWebDriver driver, string columnName)
        {
            string convertedCol = ConvertColumnsNames(columnName);
            IList<IWebElement> allValuesRead = driver.FindElements(By.XPath($"//div[contains(@col-id,'{convertedCol}')]"));
            return allValuesRead;
        }
        public void SelectQuoteStatus(IWebDriver driver, string status)
        {
            SelectElement selectElement = new SelectElement(QuoteStatusDropDown);
            selectElement.SelectByText(status);
        }



        /// <summary>
        /// Gets Download Path for any User Profiles
        /// </summary>
        /// <returns></returns>
        public static string GetDownloadProfile()
        {
            Thread.Sleep(5000);
            string userProfileFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string downloadsFolder = userProfileFolder + "\\Downloads\\";
            return downloadsFolder;
        }

        public void DeleteExtingExcelFiles()
        {
            string file = GetDownloadProfile();
            string filesToDelete = @"*Report*.csv";   // Only delete DOC files containing "DeleteMe" in their filenames
            try
            {
                string[] fileList = System.IO.Directory.GetFiles(file, filesToDelete);
                foreach (string i in fileList)
                {
                    System.Diagnostics.Debug.WriteLine(file + "will be deleted");
                    File.Delete(file);
                }
            }
            catch (IOException ex)
            {
                Logger.Write(ex.Message);
            }
        }

        /// <summary>
        /// Gets the Latest File from given Directory --> Then Convert into String for Path
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        public static FileInfo GetNewestFile(DirectoryInfo directory)
        {
            return directory.GetFiles()
                .Union(directory.GetDirectories().Select(d => GetNewestFile(d)))
                .OrderByDescending(f => (f == null ? DateTime.MinValue : f.LastWriteTime))
                .FirstOrDefault();
        }

        /// <summary>
        /// Dictionary comparer to Remove Extra Spaces and Compare Keys and Values
        /// </summary>
        /// <param name="data1"></param>
        /// <param name="data2"></param>
        /// <returns></returns>
        public static bool DictionaryComparer(Dictionary<string, IList<string>> data1, Dictionary<string, IList<string>> data2)
        {
            bool IsMathcing = true;

            for (int i = 0; i < data1.Keys.Count; i++)
            {
                if (data1.Keys.ElementAt(i) != data2.Keys.ElementAt(i))
                {
                    IsMathcing = false;

                    Console.WriteLine("Item at the Position {0} is not mathcing at Row Number  ", i);
                    Console.WriteLine("Expected is {0} but the actual is {1}", data1.Keys.ElementAt(i), data2.Keys.ElementAt(i));
                }
            }

            for (int j = 0; j < data1.Values.Count; j++)
            {

                if (data1.Values.ElementAt(j).ToString().Trim() != data2.Values.ElementAt(j).ToString().Trim())
                {
                    IsMathcing = false;

                    Console.WriteLine("Item at the Position {0} is not mathcing at Row Number  ", j);
                    Console.WriteLine("Expected is {0} but the actual is {1}", data1.Values.ElementAt(j), data2.Keys.ElementAt(j));
                }
            }

            return IsMathcing;
        }

        /// <summary>
        /// Dictionary comparer to Remove Extra Spaces and Compare Keys and Values
        /// </summary>
        /// <param name="data1"></param>
        /// <param name="data2"></param>
        /// <returns></returns>
        public static bool DictionaryComparerUnSortedData(Dictionary<string, IList<string>> data1, Dictionary<string, IList<string>> data2)
        {
            bool IsMathcing = false;

            for (int i = 0; i < data1.Keys.Count; i++)
            {
                if (data1.Keys.ElementAt(i) == data2.Keys.ElementAt(i))
                {
                    IsMathcing = true;
                }
                else
                {
                    Logger.Write("Item at the Position Number " + i + " is not mathcing");
                    Logger.Write("Expected is " + data1.Keys.ElementAt(i) + " but the actual is " + data2.Keys.ElementAt(i) + "");
                    break;
                }
            }

            for (int j = 0; j < data1.Values.Count; j++)
            {
                Logger.Write("Gets Each Element through Run Time");
                for (int k = 0; k < data1.Values.ElementAt(j).Count(); k++)
                {
                    string val = data1.Values.ElementAt(j).ElementAt(k);
                    //Remove Zero from first position as Excel does not contain 0 for company code starting with
                    val = val.TrimStart(new Char[] { '0' });

                    if (data2.Any(x => data1.Contains(x)))
                    {

                        IsMathcing = true;
                    }
                    //if (data2.Values.ElementAt(j).ToList().Any(x => x.Contains(val)))
                    //{
                    //    IsMathcing = true;
                    //}
                    else
                    {
                        Logger.Write("Item at the Position Number " + j + " is not mathcing");
                        Logger.Write("Expected is " + val + " but the actual is " + data2.Values.ElementAt(j) + "");
                        IsMathcing = false;
                        break;
                    }
                }
            }


            //if (data2.Any(x => data1.Contains(x)))
            //{

            //    IsMathcing = true;
            //}

            return IsMathcing;
        }

        /// <summary>
        /// To Get Xpath of Corresponding Rows conversion to colId
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static string ConvertColumnsNames(string columnName)
        {

            string rowName = columnName;

            switch (rowName.Trim())
            {

                case "Order Date":
                    rowName = "orderDate";
                    break;

                case "Order Type":
                    rowName = "orderType";
                    break;

                case "Company Number":
                    rowName = "companyNumber";
                    break;

                case "DPID":
                    rowName = "dpid";
                    break;

                case "Ship To Customer Number":
                    rowName = "shipToCustomerNumber";
                    break;

                case "Ship To Customer Name":
                    rowName = "shipToCustomerName";
                    break;

                case "Ship To Email Address":
                    rowName = "shipToEmail";
                    break;

                case "Bill To Customer Number":
                    rowName = "billToCustomerNumber";
                    break;


                case "Bill To Customer Name":
                    rowName = "billToCustomerName";
                    break;

                case "Bill To Email Address":
                    rowName = "billToEmail";
                    break;

                case "Order Number":
                    rowName = "orderNumber";
                    break;

                case "Order Status":
                    rowName = "orderStatus";
                    break;

                case "Payment Method":
                    rowName = "paymentMethod";
                    break;

                case "Final Price":
                    rowName = "finalPrice";
                    break;

                case "Sold To Customer Number":
                    rowName = "soldToCustomerNumber";
                    break;

                case "Quote Number":
                    rowName = "quoteNumber";
                    break;

                case "Quantity":
                    rowName = "quantity";
                    break;

                case "Description":
                    rowName = "description";
                    break;

                case "PO":
                    rowName = "po";
                    break;

                case "Ship Date":
                    rowName = "shipdate";
                    break;

                case "Linked Order Numbers":
                    rowName = "linkedOrderNumbers";
                    break;

                case "Primary Sales Rep":
                    rowName = "primarySalesRep";
                    break;

                case "Primary Sales Rep ID":
                    rowName = "alesRepId";
                    break;

                case "Created By":
                    rowName = "createdBy";
                    break;

                case "Secondary Sales Rep":
                    rowName = "secondarySalesRep";
                    break;

                case "Secondary Sales Rep ID":
                    rowName = "secondarySalesRepId";
                    break;

                case "Company Name":
                    rowName = "companyName";
                    break;

                case "Contract Code":
                    rowName = "contractCode";
                    break;

                case "CS ID":
                    rowName = "csId";
                    break;

                case "LOB":
                    rowName = "csId";
                    break;

                case "Status Date":
                    rowName = "statusDate";
                    break;

                case "Sold To Customer Name":
                    rowName = "soldToCustomerName";
                    break;

                case "Sold To Email Address":
                    rowName = "soldToEmail";
                    break;


                case "Solution ID":
                    rowName = "solutionId";
                    break;


                case "SubTotal":
                    rowName = "subTotal";
                    break;


                case "Source Application":
                    rowName = "sourceApplicationName";
                    break;


                case "Margin":
                    rowName = "margin";
                    break;


                case "Currency Code":
                    rowName = "currencyCode";
                    break;


                default:
                    Console.WriteLine("Empty");
                    break;
            }

            return rowName;
        }



public IWebElement OdersPageFirstDPID { get { return WebDriver.GetElement(By.XPath("(.//*[@ref='eBodyViewport']//div[@col-id='dpid_1'][@role='gridcell']//a)[1]")); } }

        #region QuotesTab
        public void ClearQuoteTabColumnPreferences()//updated as per new UI
        {
            IWebElement selectAll = WebDriver.FindElement(By.XPath("(//input[@type= 'checkbox'])[1]"));
            new OpenQA.Selenium.Interactions.Actions(WebDriver).MoveToElement(selectAll).Click();
            WebDriverUtil.JavaScriptClick(WebDriver, selectAll);
            selectAll.UnSelectCheckBox(WebDriver);
        }

        public void SelectQuoteColumns(string ColumnName)
        {
            IWebElement checkBox = WebDriver.FindElement(By.XPath($"//span[text() = '{ColumnName}']//preceding-sibling::input"));
            new OpenQA.Selenium.Interactions.Actions(WebDriver).MoveToElement(checkBox).Click().Build().Perform();
        }

        public void SelectIJavaScriptColumns(string ColumnName)
        {
            IWebElement checkBox = WebDriver.FindElement(By.XPath($"//span[text() = '{ColumnName}']//preceding-sibling::input"));
            WebDriverUtil.JavaScriptClick(WebDriver, checkBox);
        }



        public bool VerifyColumnHeaders(IWebDriver driver, IList<string> expectedColumns)
        {
            bool ismatching = false;

            IList<string> allHeaders = new List<string>();

            for (int i = 0; i < expectedColumns.Count(); i++)
            {
                WebDriverUtil.StalenessOfElement(driver, By.XPath($"//span[@class = 'ag-header-select-all ag-hidden']//following::*[text() = '{expectedColumns[i]}']"), TimeSpan.FromSeconds(3));
                string actualColumn = driver.FindElement(By.XPath($"//span[@class = 'ag-header-select-all ag-hidden']//following::*[text() = '{expectedColumns[i]}']")).Text;
                allHeaders.Add(actualColumn);
            }


            if (allHeaders.SequenceEqual(expectedColumns))
            {
                ismatching = true;
            }
            return ismatching;
        }

        public void SortColumns(string columnsToSort)
        {
            WebDriver.FindElement(By.XPath($"//a[contains(text(), '{columnsToSort}')]")).Click();
        }



        public void SelectSalesRepType(bool primary, bool secondary)
        {

            WebDriverUtil.JavaScriptClick(WebDriver, SalesRepMultiSelectButton);

            WebDriver.FindElement(By.XPath("((//ul[@class = 'dropdown-menu'])[1]/li/label)[1]")).Click();

            if (primary == true)
            {
                WebDriverUtil.JavaScriptClick(WebDriver, SalesRepMultiSelectButton);

                //Select All Check Box to Deselect
                WebDriver.FindElement(By.XPath("((//ul[@class = 'dropdown-menu'])[1]/li/label)[1]")).Click();

                //Select Primary
                WebDriverUtil.JavaScriptClick(WebDriver, SalesRepMultiSelectButton);
                WebDriver.FindElement(By.XPath("((//ul[@class = 'dropdown-menu'])[1]/li/label)[2]")).Click();
            }
            else if (secondary == true)
            {
                //Select All Check Box to Deselect
                WebDriverUtil.JavaScriptClick(WebDriver, SalesRepMultiSelectButton);
                WebDriver.FindElement(By.XPath("((//ul[@class = 'dropdown-menu'])[1]/li/label)[1]")).Click();

                //Click Secondary
                WebDriverUtil.JavaScriptClick(WebDriver, SalesRepMultiSelectButton);
                WebDriver.FindElement(By.XPath("((//ul[@class = 'dropdown-menu'])[1]/li/label)[3]")).Click();  
            }
        }

        public void SelectSalesRepType(string selectCheckBox, bool select = true)
        {
            By checkBoxPath = By.XPath($"//ul[@class = 'dropdown-menu']//label[contains(text(), '{selectCheckBox}')]");
            SalesRepTypeButton.Click();
            WebDriver.WaitForElementDisplay(checkBoxPath);

            if (select)
            {
                IWebElement checkBox = WebDriver.FindElement(checkBoxPath);

                if (checkBox.Selected == false)
                {
                    checkBox.Click();
                }
            }
            else
            {
                IWebElement checkBox2 = WebDriver.FindElement(checkBoxPath);
                if (checkBox2.Selected == true)
                {
                    checkBox2.Click();
                }
            }
        }

        public void DeSelectCheckBox(string selectCheckBox)
        {
            By checkBoxPath = By.XPath($"//ul[@class = 'dropdown-menu']//label[contains(text(), '{selectCheckBox}')]");

            if (WebDriver.WaitForElementDisplay(checkBoxPath, TimeSpan.FromSeconds(2)) == false)
            {
                SalesRepTypeButton.Click();
            }
            IWebElement checkBox = WebDriver.FindElement(checkBoxPath);
            checkBox.Click();
        }

        public bool VerifyTableColumnValues(IWebDriver driver, IList<string> columnNames, string value1, string value2, int displayPerPage = 0, int numberofPagesToVerify = 0)
        {
            bool isMatching = false;
            List<string> allHeaders = new List<string>();
            List<string> allRows = new List<string>();
            Dictionary<string, List<string>> allColumnRows = new Dictionary<string, List<string>>();

            for (int pageNumber = 1; pageNumber <= numberofPagesToVerify; pageNumber++)
            {
                if (pageNumber > 0)
                {
                    IWebElement paginationBySequence = driver.FindElement(By.XPath($"//a/div[contains(text(), '{pageNumber.ToString()}')]"));
                    WebDriverUtil.JavaScriptClick(WebDriver, paginationBySequence);
                    driver.VerifyBusyOverlayNotDisplayed();
                }

                //Find Display Drop Down and change value as per number of records needed
                if (displayPerPage != 0)
                {
                    IWebElement webElement = driver.FindElement(By.XPath("//select[@id = 'grid_paging_itemsPerPage']"));

                    SelectElement selectElement = new SelectElement(webElement);

                    string itemsperPage = " 0 per page ";

                    itemsperPage = itemsperPage.Replace("0", displayPerPage.ToString());

                    selectElement.SelectByText(itemsperPage);

                    driver.VerifyBusyOverlayNotDisplayed();

                }

                //To Get all the Headers
                for (int c = 0; c < columnNames.Count; c++)
                {
                    string headerName = columnNames[c];
                    string header = driver.FindElement(By.XPath($"//grid-hedercomponent-cell//*[contains(text(), '{headerName}')]")).Text;
                    allHeaders.Add(header);
                }

                //Get Total Number of User Input Headers
                for (int j = 0; j < columnNames.Count; j++)
                {
                    Logger.Write("Add All Column Headers");
                    string colId = ConvertColumnsNames(columnNames[j]);

                    IList<IWebElement> allValuesRead = driver.FindElements(By.XPath($"//div[contains(@col-id,'{colId}')]"));

                    List<string> rowTextValues = new List<string>();

                    for (int i = 1; i < allValuesRead.Count; i++)
                    {
                        rowTextValues.Add(allValuesRead[i].Text.ToLower()); //To avoid Conflict of Caps Converted to Lower


                        if (allValuesRead[i].Text.Contains(value1) || allValuesRead[i].Text.Contains(value2) || allValuesRead[i].Text.Contains(""))
                        {
                            isMatching = true;

                        }

                        else
                        {
                            Logger.Write("Expected Text is ****" + value1);
                            Logger.Write("Expected Text is ****" + value2);
                            Logger.Write("Actual Text is ****" + allValuesRead[i].Text);

                            isMatching = false;
                            break;
                        }
                    }
                }
            }
            return isMatching;
        }
        
        /// <summary>
        /// Date Comparer in Decending Order
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="columnNames"></param>
        /// <param name="displayPerPage"></param>
        /// <param name="numberofPagesToVerify"></param>
        /// <returns></returns>
        public bool OrderHistoryDateComparer(IWebDriver driver, IList<string> columnNames, int displayPerPage = 0, int numberofPagesToVerify = 0)
        {
            bool isMatching = true;

            List<string> rowTextValues = new List<string>();
            List<DateTime> allDates = new List<DateTime>();


            for (int pageNumber = 1; pageNumber <= numberofPagesToVerify; pageNumber++)
            {
                if (pageNumber > 0)
                {
                    IWebElement paginationBySequence = driver.FindElement(By.XPath($"//a/div[contains(text(), '{pageNumber.ToString()}')]"));
                    WebDriverUtil.JavaScriptClick(WebDriver, paginationBySequence);
                    driver.VerifyBusyOverlayNotDisplayed();
                }

                //Find Display Drop Down and change value as per number of records needed
                if (displayPerPage != 0)
                {
                    IWebElement webElement = driver.FindElement(By.XPath("//select[@id = 'grid_paging_itemsPerPage']"));

                    SelectElement selectElement = new SelectElement(webElement);

                    string itemsperPage = " 0 per page ";

                    itemsperPage = itemsperPage.Replace("0", displayPerPage.ToString());

                    selectElement.SelectByText(itemsperPage);

                    driver.VerifyBusyOverlayNotDisplayed();

                }

                //Get Total Number of User Input Headers
                for (int j = 0; j < columnNames.Count; j++)
                {
                    Logger.Write("Add All Column Headers");
                    string colId = ConvertColumnsNames(columnNames[j]);

                    IList<IWebElement> allValuesRead = driver.FindElements(By.XPath($"//div[contains(@col-id,'{colId}')]"));

                    for (int i = 1; i < allValuesRead.Count; i++)
                    {
                        //If the Row Does not Contrain the Value check and Add
                        if (!rowTextValues.Contains(allValuesRead[i].Text))
                        {
                            rowTextValues.Add(allValuesRead[i].Text);
                        }
                    }
                }

                for (int k = 0; k < rowTextValues.Count; k++)
                {

                    DateTime convertedDate = Convert.ToDateTime(rowTextValues[k]);

                    allDates.Add(convertedDate);
                }

                for (int i = 0; i < allDates.Count() - 1; i++)
                {
                     isMatching = false;

                    if (allDates[i].CompareTo(allDates[i + 1]) == 1)
                    {
                        isMatching = true;
                    }
                   
                }
               
            }
            return isMatching;
        }

        public ReadOnlyCollection<IWebElement> RowElements(string columnName)
        {
            string path = ConvertColumnsNames(columnName);
            ReadOnlyCollection<IWebElement> webElement = WebDriver.FindElements(By.XPath($"//div[contains(@col-id, '{path}')]/grid-currency-cell[@class = 'ng-star-inserted']"));
            return webElement;    
        }

        public void DisplayItemsPerPage(int displayPerPage)
        {
            if (displayPerPage != 0)
            {
                IWebElement webElement = WebDriver.FindElement(By.XPath("//select[@id = 'grid_paging_itemsPerPage']"));
                SelectElement selectElement = new SelectElement(webElement);

                string itemsperPage = " 0 per page ";
                itemsperPage = itemsperPage.Replace("0", displayPerPage.ToString());
                selectElement.SelectByText(itemsperPage);
                WebDriver.VerifyBusyOverlayNotDisplayed();
            }
        }

        public bool VerifyDecendingOrder(IList<string> inputData)
        {
            bool isDecending = false;

            for (int i = 0; i < inputData.Count() - 1; i++)
            {
                isDecending = false;

                int data = int.Parse(inputData[i]);
                int data1 = int.Parse(inputData[i + 1]);

                if (data >= data1)
                {
                    isDecending = true;
                }
                else
                {
                    isDecending = false;
                    break;
                }
            }

            return isDecending;
        }


        public bool VerifyAscendingOrder(IList<string> inputData)
        {
            bool isDecending = false;

            for (int i = 0; i < inputData.Count() - 1; i++)
            {
                isDecending = false;

                int data = int.Parse(inputData[i]);
                int data1 = int.Parse(inputData[i + 1]);

                if (data <= data1)
                {
                    isDecending = true;
                }
                else
                {
                    isDecending = false;
                    break;
                }
            }

            return isDecending;
        }

    }
    #endregion
}


