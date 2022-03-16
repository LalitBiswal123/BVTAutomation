using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.DataModels;
using Dsa.Pages.Customer;
using Dsa.Pages.Quote;
using Dsa.Utils;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Dsa.Pages.Order
{
    public class ManageHeldOrdersPage : DsaPageBase
    {
        public ManageHeldOrdersPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(WebDriver, this);
        }



        #region Elements





public IWebElement LnkOrderHoldMyQueueTab { get { return WebDriver.GetElement(By.Id("tab_myQueue")); } }


public IWebElement LnkOrderHoldSummaryTab { get { return WebDriver.GetElement(By.Id("tab_summary")); } }


public IWebElement LnkOrderHoldHeldOrdersTab { get { return WebDriver.GetElement(By.Id("tab_heldOrders")); } }


public IWebElement ManageHeldOrdersText { get { return WebDriver.GetElement(By.Id("manageHelOrders_title")); } }


public IWebElement ProductValidatorHoldType3 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_3_ProductValidatorHold")); } }


public IWebElement CustomerValidatorHoldType4 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_4_CustomerValidatorHold")); } }


public IWebElement CreditCardHoldType7 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_7_CreditCardHold")); } }


public IWebElement PayPalHoldType8 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_8_PayPalHold")); } }


public IWebElement GiftCardHoldType10 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_10_GiftCardHold")); } }


public IWebElement GlobalPaymentFulfillmentLevelHoldType11 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_11_GlobalPaymentFulfillmentLevelHold")); } }


public IWebElement CVHoldType13 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_13_CVHold")); } }


public IWebElement PVHoldType14 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_14_PVHold")); } }


public IWebElement QVBulkType16 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_16_QVBulk")); } }


public IWebElement OrderValidatorHoldType17 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_17_OrderValidatorHold")); } }


public IWebElement GCSFirstArticleReviewHoldType41 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_41_GCSFirstArticleReviewHold")); } }


public IWebElement PendingOrderModifyHoldType46 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_46_PendingOrderModifyHold")); } }


public IWebElement ContractValidatorHoldType61 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_61_ContractValidatorHold")); } }


public IWebElement CustomerCommitmentManagerHoldType62 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_62_CustomerCommitmentManagerHold")); } }


public IWebElement FrictionlessFlagHoldType63 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_63_FrictionlessFlagHold")); } }


public IWebElement OCIRejectedHolType64 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_64_OCIRejectedHold")); } }


public IWebElement OCITransformerValidationHoldType65 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_65_OCITransformerValidationHold")); } }


public IWebElement OnlineExceptionHoldType66 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_66_OnlineExceptionHold")); } }


public IWebElement StopAtQuoteHoldType67 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_67_StopAtQuoteHold")); } }


public IWebElement POValidationHoldType69 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_69_POValidationHold")); } }


public IWebElement PromotionValidatorHoldType70 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_70_PromotionValidatorHold")); } }


public IWebElement LargeOrderQualityAuditPendingHoldType73 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_73_LargeOrderQualityAuditPendingHold")); } }


public IWebElement LargeOrderQualityAuditReviewHoldType74 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_74_LargeOrderQualityAuditReviewHold")); } }


public IWebElement ViewReleaseQualityCheckHoldType75 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_75_ViewReleaseQualityCheckHold")); } }


public IWebElement QualityCheckAuditPendingHoldType76 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_76_QualityCheckAuditPendingHold")); } }


public IWebElement GPGConnectivityHoldType90 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_90_GPGConnectivityHold")); } }


public IWebElement PVConnectivityHoldType91 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_91_PVConnectivityHold")); } }


public IWebElement OnlineExceptionHoldType92 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_92_OnlineExceptionHold")); } }


public IWebElement RecurringPaymentHoldType93 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_93_RecurringPaymentHold")); } }


public IWebElement CreditCardRegisterFailHoldType94 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_94_CreditCardRegisterFailHold")); } }


public IWebElement PurchaseOrderRegisterFailHoldType95 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_95_PurchaseOrderRegisterFailHold")); } }


public IWebElement PayPalRegisterFailHoldType96 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_96_PayPalRegisterFailHold")); } }


public IWebElement MissingTenantIDDomainHoldType101 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_101_MissingTenantIDDomainHold")); } }


public IWebElement ValidationHoldType102 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_102_ValidationHold")); } }


public IWebElement SystemFailureHoldType103 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_103_SystemFailureHold")); } }


public IWebElement PORejectionHoldType104 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_104_PORejectionHold")); } }


public IWebElement ATSPickHoldType113 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_117_ATSPickHold")); } }


public IWebElement GCSFMPickHoldtype114 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_118_GCSFMPickHold")); } }


public IWebElement GCSFMStockHoldType115 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_119_GCSFMStockHold")); } }


public IWebElement RSValidationHoldType116 { get { return WebDriver.GetElement(By.Id("workflow_summary_hold_type_120_RSValidationHold")); } }


public IWebElement BtnCloseDialog { get { return WebDriver.GetElement(By.Id("_btn_ok")); } }


public IWebElement BtnManageUsersSearch { get { return WebDriver.GetElement(By.Id("manage_users_form_Search")); } }


public IWebElement TableManageHeldOrdersMyQueue { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']")); } }


public IWebElement TableManageHeldOrdersManageUsersGrid { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_div_ManageUsersGrid']")); } }


public IWebElement TextSuspendedComments { get { return WebDriver.GetElement(By.XPath("//*[@id='_orderCommentsData']//div[2]")); } }

        


public IWebElement TextBoxManageUsersName { get { return WebDriver.GetElement(By.Id("userSearch_name")); } }


public IWebElement LnkOrderCommentsHeading { get { return WebDriver.GetElement(By.Id("_orderCommentsHeading")); } }


public IWebElement TextAreaSuspendedOrderComment { get { return WebDriver.GetElement(By.Id("order_comments")); } }



public IWebElement LblManageUsersAssignedHoldTypeField { get { return WebDriver.GetElement(By.XPath("//*[@id='manage_users_form']/div/div[1]/div[2]/label")); } }


public IWebElement TextBoxManageUsersHoldType { get { return WebDriver.GetElement(By.Id("userSearch_hold_type")); } }


public IWebElement LblManageUsersEmailField { get { return WebDriver.GetElement(By.XPath("//*[@id='manage_users_form']/div/div[2]/div/label")); } }


public IWebElement TextBoxManageUsersEmail { get { return WebDriver.GetElement(By.Id("userSearch_email")); } }


public IWebElement LblManageUsersOPBadgeField { get { return WebDriver.GetElement(By.XPath("//*[@id='manage_users_form']/div/div[3]/div[1]/label")); } }


public IWebElement TxtAreaReleaseWorkItem { get { return WebDriver.GetElement(By.XPath("//*[@id='workflow_release_order']/div[2]/div/textarea")); } }


public IWebElement BtnCloseReleaseWorkItem { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'order_modaldialog')]/div[1]/a/span")); } }


public IWebElement CheckBoxReleaseProductValidaionHold { get { return WebDriver.GetElement(By.XPath("//release-product-validation-hold/div/div[2]/input")); } }


public IWebElement firstElementInTable { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'MyWorkgroupGrid-0-')]")); } }


public IWebElement BtnAddCommentSuspendOrder { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'_orderCommentsData')]//button")); } }

        

public IWebElement MyQueueGrid { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_div_MyWorkgroupGrid']")); } }


public IWebElement OrderDetailsTooltip { get { return WebDriver.GetElement(By.XPath("//order-workflow-status//div/i")); } }


public IWebElement TableAssignedHeldOrders { get { return WebDriver.GetElement(By.XPath("//*[@id='workflow_summary']/div[3]/ul/li")); } }


public IWebElement TextBoxManageUsersOPBadge { get { return WebDriver.GetElement(By.Id("userSearch_badge")); } }


public IWebElement ReleaseWorkItemMessage { get { return WebDriver.GetElement(By.XPath("//*[@id='workflow_release_order']/div[1]")); } }

public IWebElement DPID { get { return WebDriver.GetElement(By.Id("copyId")); } }


public IWebElement ManageHeldOrdersWorkFlowAssignedOrderDPID { get { return WebDriver.GetElement(By.XPath("//*[@id='workflow_assigned_order']/div/span")); } }


public IWebElement DropdownManageHeldOrdersWorkFlowSelectWorking { get { return WebDriver.GetElement(By.XPath("//*[@id='workflow_assigned_order']/div/a/span")); } }


public IWebElement SearchBoxAvailableUsers { get { return WebDriver.GetElement(By.XPath("//*[@id='hold_types_user']/div/div/input")); } }

        


public IWebElement SuspendWorkItemPopup { get { return WebDriver.GetElement(By.Id("mat-dialog-0")); } }


public IWebElement LnkApproveHeldOrder { get { return WebDriver.GetElement(By.Id("_approveHold")); } }


public IWebElement LnkDeclineHeldOrder { get { return WebDriver.GetElement(By.Id("_declineHold")); } }


public IWebElement LnkReleaseHoldHeldOrder { get { return WebDriver.GetElement(By.Id("_releaseHold")); } }


public IWebElement pagesFromToMyQueue { get { return WebDriver.GetElement(By.Id("MyWorkgroupGrid_fromto")); } }


public IWebElement LnkOrderDetailsUpdateWorkFlow { get { return WebDriver.GetElement(By.Id("workflow_release_order")); } }


public IWebElement BtnAssignUsers { get { return WebDriver.GetElement(By.Id("hold-types-assign-users")); } }


public IWebElement WorkFlowLable { get { return WebDriver.GetElement(By.XPath("//*[@id='held_orders_form']/div/div[2]/div[2]/label")); } }

public IWebElement HeldOrder { get { return WebDriver.GetElement(By.XPath("//*[@id='held_orders_form']/div/div[2]/div[3]/label")); } }


public IWebElement holdtypeDropdown { get { return WebDriver.GetElement(By.XPath("//*[@id='held_orders_form']/div/div[2]/div[3]/div/multi-select/div/div/button/span")); } }


public IWebElement holdtypeSelectAll { get { return WebDriver.GetElement(By.XPath("//*[@id='held_orders_form']/div/div[2]/div[3]/div/multi-select/div/div[2]/ul/li[1]/label/input")); } }



public IWebElement SummaryTable { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_div_HeldOrdersGrid']")); } }


public IWebElement Searchclick { get { return WebDriver.GetElement(By.Id("heldOrdersSearch")); } }


        //[FindsBy(How = How.XPath, Using = "//*[@id='main']/div[2]/gcm-my-queue/div/div/div/div/div")]
        //public IWebElement MyQueueSummaryTable;


public IWebElement Getnextlist { get { return WebDriver.GetElement(By.XPath("//*[@id='next_in_queue_addNextWorkItems']")); } }


public IWebElement Labledpid { get { return WebDriver.GetElement(By.XPath("//*[@id='held_orders_form']/div/div[1]/div[3]/label")); } }


public IWebElement LableHeldorderstatus { get { return WebDriver.GetElement(By.XPath("//*[@id='held_orders_form']/div/div[2]/div[1]/label")); } }


public IWebElement Lablecompanyname { get { return WebDriver.GetElement(By.XPath("//*[@id='held_orders_form']/div/div[3]/div[1]/label")); } }


public IWebElement Lablecustomernumber { get { return WebDriver.GetElement(By.XPath("//*[@id='held_orders_form']/div/div[3]/div[2]/label")); } }


public IWebElement Lableassignedto { get { return WebDriver.GetElement(By.XPath("//*[@id='held_orders_form']/div/div[3]/div[3]/label")); } }


public IWebElement LableSalesrepid { get { return WebDriver.GetElement(By.XPath("//*[@id='held_orders_form']/div/div[3]/div[4]/label")); } }


public IWebElement Heldorderdropdown { get { return WebDriver.GetElement(By.XPath("//*[@id='held_orders_form']/div/div[2]/div[1]/div/select/option[2]")); } }


public IWebElement ComapanyNametext { get { return WebDriver.GetElement(By.Id("companyName")); } }


public IWebElement AssignedtoText { get { return WebDriver.GetElement(By.Id("opEmail")); } }


public IWebElement PoNumberText { get { return WebDriver.GetElement(By.Id("poNumber")); } }


public IWebElement SalesRepidext { get { return WebDriver.GetElement(By.Id("salesRepId")); } }



public IWebElement HeldOrderstatusoptions { get { return WebDriver.GetElement(By.XPath("//*[@id='held_orders_form']/div/div[2]/div[1]/div/select")); } }
        //Date pickers


public IWebElement HeldOrders_FromDate { get { return WebDriver.GetElement(By.XPath("//*[@id='held_orders_form']/div/div[1]/div[1]/div/common-date-picker/div/div[1]/span/span/span/span")); } }


public IWebElement HeldOrders_EndDate { get { return WebDriver.GetElement(By.XPath("//*[@id='held_orders_form']/div/div[1]/div[2]/div/common-date-picker/div/div[1]/span/span/span/span")); } }


public IWebElement OrdersFromDate_SelectedDate { get { return WebDriver.GetElement(By.XPath(".//daypicker//tbody//td//button[contains(@class,'active')]/span")); } }


public IWebElement HeldOrderStatus { get { return WebDriver.GetElement(By.XPath("//*[@id='held_orders_form']//select")); } }


public IWebElement WorkflowStatus { get { return WebDriver.GetElement(By.XPath("//*[@id='held_orders_form']/div/div[2]/div[2]//button/span")); } }

        #endregion

        #region tabs
        //tabs

public IWebElement LnkOrderHoldManageUsersTab { get { return WebDriver.GetElement(By.Id("tab_manageUsers")); } }


public IWebElement LnkManageHeldOrdersSearchEmail { get { return WebDriver.GetElement(By.Id("userSearch_email")); } }


public IWebElement LnkManageHeldOrdersSearchName { get { return WebDriver.GetElement(By.Id("userSearch_name")); } }


public IWebElement LnkManageHeldOrdersSearchBadgeNumber { get { return WebDriver.GetElement(By.Id("userSearch_badge")); } }


public IWebElement LnkManageHeldOrdersSearchAssignedHoldType { get { return WebDriver.GetElement(By.Id("userSearch_hold_type")); } }



        #endregion

        #region buttons


public IWebElement BtnManageHeldOrdersMyQueueWorkThisItem { get { return WebDriver.GetElement(By.Id("next_in_queue_goToNextWorkItem")); } }


public IWebElement BtnOrderDetailsSave { get { return WebDriver.GetElement(By.Id("orderDetails_saveOrder")); } }

        #endregion

        #region ManageHeldOrders
       
        public ManageHeldOrdersPage SelectFirstHeldorderStatus()
        {
            Heldorderdropdown.PickDropdownByIndex(WebDriver,2);
            return new ManageHeldOrdersPage(WebDriver);
        }

        public ManageHeldOrdersPage SelectFirstHeldorderStatusdrop()
        {
            HeldOrderStatus.PickDropdownByValue(WebDriver, "Workflow");
            return new ManageHeldOrdersPage(WebDriver);
        }
        public string getTextFromManageHeldOrdersTab(int index)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='main']/div[1]/div/ul/li[" + index + "]")).Text;

        }

        public bool isColumnSortedAscending(int index)
        {
            string result = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_ManageUsersGrid']/thead/tr/th[" + index + "]/span/span")).GetAttribute("class");
            if (result == "sorting_asc")
                return true;
            else return false;
        }

        public bool isColumnSortedDescending(int index)
        {
            string result = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_ManageUsersGrid']/thead/tr/th[" + index + "]/span/span")).GetAttribute("class");
            if (result == "sorting_desc")
                return true;
            else return false;
        }


        public bool isColumnSortedAscendingHeldOrder(int index)
        {
            string result = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_HeldOrdersGrid']/thead/tr/th[" + index + "]/span/span")).GetAttribute("class");
            if (result == "sorting_asc")
                return true;
            else return false;
        }

        public bool isColumnSortedDescendingHeldOrder(int index)
        {
            string result = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_HeldOrdersGrid']/thead/tr/th[" + index + "]/span/span")).GetAttribute("class");
            if (result == "sorting_desc")
                return true;
            else return false;
        }
        public List<string> getPageNumberOptions()
        {
            int num = 4;
            List<string> perPageValues = new List<string>();
            for (int count = 1; count <= num; count++)
            {
                var options = WebDriver.GetElement(By.XPath("//*[@id='ManageUsersGrid_grid_paging_itemsPerPage;']/option[" + count + "]")).GetAttribute("value");
                perPageValues.Add(options);
            }
            return perPageValues;
        }

        public string getActiveTabText()
        {
            return WebDriver.FindElement(By.XPath("//div//parent::li[@class='active']/a")).Text;

        }

        public bool IsTabActive(string tabText)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='tab_" + tabText + "']/parent::li")).GetAttribute("class").Equals("active");

        }

        public string getManageHeldOrdersTypeUserQty(string typeId)
        {
            return 
                WebDriver.FindElement(By.XPath("//*[@id='"+ typeId + "']/table/tbody/tr/td[1]")).Text;

        }

        public IWebElement ManageHeldOrdersAssignUsersBtn(string typeId)
        {
            return
                WebDriver.FindElement(By.XPath("//*[@id='" + typeId + "']/table/tbody/tr/td[2]//button[contains(text(),'Assign Users')]"));

        }

        public bool IsAssignedUserPopupOpened(string type)
        {       
            var popup = WebDriver.GetElement(By.ClassName("mat-dialog-container"));
            DsaUtil.WaitForPageLoad(WebDriver);
            return popup.Displayed && popup.Text.Contains("Assign Users to Hold Type '");
        }

        public string getAssignUsersHeaderText()
        {
            return WebDriver.FindElement(By.XPath("//*[@id='dialog_heading']")).Text;
        }

        public void closePopup()
        {
            BtnCloseDialog.Click();
        }

        public int getTotalNumberResultsFromSearched()
        {
            string qty = WebDriver.FindElement(By.XPath("//*[@id='ManageUsersGrid_fromto']")).Text;
            int.TryParse(qty.Substring(qty.LastIndexOf(' ')),out int i);
            return i;
        }

        public int getTotalNumberResultsFromMyQueueSearched()
        {
            string qty = WebDriver.FindElement(By.XPath("//*[@id='MyWorkgroupGrid_fromto']")).Text;
            int.TryParse(qty.Substring(qty.LastIndexOf(' ')), out int i);
            return i;
        }

        public IWebElement paginationRowsSelected()
        {
            return WebDriver.FindElement(By.XPath("//*[@id='ManageUsersGrid_grid_paging_itemsPerPage;']"));
        }

        public void setMyQueuePaginationRowsSelectedToForty()
        {
            
            var mySelectElm = WebDriver.FindElement(By.Id("MyWorkgroupGrid_grid_paging_itemsPerPage;"));
            var mySelect = new SelectElement(mySelectElm);
            mySelect.SelectByText("40 per page");

        }

        public IWebElement setFlag(int row)
        {

            var ele= WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/tbody/tr[" + row + "]/td[2]//span[1]"));
            return ele;
        }

        public bool IsSelectWorkThisItemButtonPresent()
        {
            return WebDriver.FindElements(By.Id("next_in_queue_goToNextWorkItem")).Count != 0;
        }

        #endregion

        #region tables

        public List<IWebElement> manageHeldOrdersSearchResults()
        {
            var elemTable = WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_ManageUsersGrid']"));
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            return lstTrElem;

        }

        public List<IWebElement> manageHeldOrdersMyQueueResults()
        {
            var elemTable = WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']"));
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            return lstTrElem;

        }

        public int paginationPageCount()
        {
            var pages = WebDriver.FindElements(By.XPath("//*[@id='MyWorkgroupGrid_partyGrid_pagination']//ul"));
            int size = pages.Count;
            return size;

        }

        public IWebElement navigateToMyQueuePage(int pageNo)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='MyWorkgroupGrid_partyGrid_pagination']/ul[" + pageNo + "]/li/a/div"));
        }

        public List<IWebElement> manageHeldOrdersSearchResultsbyCol()
        {
            try
            {
                var elemTable = WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_ManageUsersGrid']"));
                List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("th")));
                return lstTrElem;
            }
            catch (NoSuchElementException e)
            {
                throw;
            }
        }

        public List<IWebElement> manageHeldOrdersSearchResultsbyColumn()
        {
            try
            {
                //var elemTable = WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_HeldOrdersGrid']"));
                //List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("th")));
             
                //return lstTrElem;

                List<IWebElement> lstTrElem = new List<IWebElement>(WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_HeldOrdersGrid']/thead/tr/th")));
                return lstTrElem;
               }
            catch (NoSuchElementException e)
            {
                throw;
            }
        }

        public string manageHeldOrdersSearchResultsbyField(int row,int col)
        {
            try
            { 
            var elem = WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_ManageUsersGrid']/tbody/tr[" + row + "]/td[" + col + "]"));
            return elem.Text;
            }
            catch (NoSuchElementException e)
            {
                throw;
            }
        }

        public string manageHeldOrdersSearchMyQueuebyField(int row, int col)
        {
            try
            { 
            var elem = WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']//tbody/tr[" + row + "]/td[" + col + "]"));
            return elem.Text;
            }
            catch (NoSuchElementException e)
            {
                throw;
            }
        }

        public IWebElement manageHeldOrdersSelectMyQueuebyField(int row, int col)
        {
            try
            {
                return WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']//tbody/tr[" + row + "]/td[" + col + "]/a"));
                
            }
            catch (NoSuchElementException e)
            {
                throw(e);
            }
        }

        public string getNextInQueueDPIDFromMyQueueContainer()
        {
            return WebDriver.FindElement(By.XPath("//*[@id='next_in_queue']/div/div/span[3]")).Text;
        }

        public bool NextWorkingDPIDFromHeaderLinkExists()
        {
            return WebDriver.ElementExists(By.XPath("//*[@id='workflow_assigned_order']/div/span"));
        }

        public string getNextWorkingDPIDFromDSAHeader()
        {
            return WebDriver.FindElement(By.XPath("//*[@id='workflow_assigned_order']/div/span")).Text;
        }

        public IWebElement addNext5WorkingItemsManageHeldOrdersLink()
        {
            return WebDriver.GetElement(By.XPath("//*[@id='next_in_queue_addNextWorkItems_link']"));
        }

        public IWebElement addNext5WorkingItemsManageHeldOrders()
        {
            return WebDriver.GetElement(By.XPath("//*[@id='next_in_queue_addNextWorkItems']"));
        }

        public void WaitForMyQueueTableToLoad()
        {
            TableManageHeldOrdersMyQueue.WaitForElementDisplayed(TimeSpan.FromSeconds(10));
        }

        public void WaitForMyQueueTableFirstElemenetToLoad()
        {
            DsaUtil.WaitForElement(firstElementInTable,WebDriver);
        }

        public void WaitForManageUsersTableToLoad()
        {
            TableManageHeldOrdersManageUsersGrid.WaitForElementDisplayed(TimeSpan.FromSeconds(10));
        }

        

        public void WaitForBtnManageHeldOrdersMyQueueWorkThisItemToLoad()
        {
            BtnManageHeldOrdersMyQueueWorkThisItem.WaitForElementDisplayed(TimeSpan.FromSeconds(10));
        }

        public void WaitForManageHeldOrdersWorkFlowAssignedOrderDPIDToLoad()
        {
            ManageHeldOrdersWorkFlowAssignedOrderDPID.WaitForElementDisplayed(TimeSpan.FromSeconds(20));
        }

        public IWebElement SortGridBy(int column)
        {
            var headerlnk = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_ManageUsersGrid']/thead/tr/th["+ column +"]/span"));
            if (headerlnk == null)
                throw new NoSuchElementException(string.Format("Cannot find column header {0}", column));
            return headerlnk;
        }

    
        public IWebElement SortGridHeldorderBy(int column)
        {
            var headerlnk = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_HeldOrdersGrid']/thead/tr/th[" + column + "]/span"));
            if (headerlnk == null)
                throw new NoSuchElementException(string.Format("Cannot find column header {0}", column));
            return headerlnk;
        }

        public IWebElement btnViewOrderDetailsOnDSAHeaderWorkingDropdown()
        {
            return WebDriver.FindElement(By.XPath("//div[@class='menu-contents']/p/a[2]"));
        }

       
        //input : ManageHeldOrders Page Object
        //method : Selects Work Next Item or Work This Item button on MyQueue page
        //if not there - clicks the "Select Next 5 Items link"
        //returns : Next Item selected DPID
        public string selectNextItemButtonOrSelectNextFiveInQueue(ManageHeldOrdersPage page)
        {
            IWebElement NextItemOrViewItem = null;
            string nextDPID = null;
            if (!page.IsSelectWorkThisItemButtonPresent())
            {
                page.addNext5WorkingItemsManageHeldOrdersLink().Click(WebDriver);
                page.WaitForMyQueueTableToLoad();
                page = new ManageHeldOrdersPage(WebDriver);
                page.WaitForMyQueueTableToLoad();
                page.WaitForMyQueueTableFirstElemenetToLoad();
                nextDPID = page.manageHeldOrdersSearchMyQueuebyField(1, 1);
                NextItemOrViewItem = page.BtnManageHeldOrdersMyQueueWorkThisItem;
                NextItemOrViewItem.Click(WebDriver);
                
            }
            //if Next Item/View Button is visible
            else if (page.BtnManageHeldOrdersMyQueueWorkThisItem.IsElementDisplayed(WebDriver))
            {
                List<IWebElement> searchResults = page.manageHeldOrdersMyQueueResults();
                nextDPID = page.manageHeldOrdersSearchMyQueuebyField(1, 1);
                NextItemOrViewItem = page.BtnManageHeldOrdersMyQueueWorkThisItem;
                NextItemOrViewItem.Click(WebDriver);
                
            }
            return nextDPID;
        }

        //input : WebDriver
        //release the Order in Fixed status in MyQueue
        public void releaseHeldOrderInFixedStatus(IWebDriver TestWebDriver)
        {
            //Navigate to Manage Held Orders myQueue
            new HomePage(TestWebDriver).ClickMainMenu(TestWebDriver).LnkOrderHoldWorkflow.Click(TestWebDriver);
            ManageHeldOrdersPage manageHeldOrders = new ManageHeldOrdersPage(TestWebDriver);
            manageHeldOrders.LnkOrderHoldMyQueueTab.Click(TestWebDriver);
            ManageHeldOrdersPage manageUsersMyQueue = new ManageHeldOrdersPage(TestWebDriver);
            manageUsersMyQueue.BtnManageHeldOrdersMyQueueWorkThisItem.Click(TestWebDriver);
            DsaUtil.WaitForElement(manageUsersMyQueue.LnkOrderCommentsHeading, TestWebDriver);
            if (manageUsersMyQueue.LnkReleaseHoldHeldOrder.IsElementDisplayed(TestWebDriver,TimeSpan.FromSeconds(3)))
            {
                manageUsersMyQueue.LnkReleaseHoldHeldOrder.Click(TestWebDriver);
            }
            else if (!manageUsersMyQueue.LnkReleaseHoldHeldOrder.IsElementDisplayed(TestWebDriver, TimeSpan.FromSeconds(3)) && manageUsersMyQueue.LnkApproveHeldOrder.IsElementDisplayed(TestWebDriver, TimeSpan.FromSeconds(3)))
            {
                manageUsersMyQueue.LnkApproveHeldOrder.Click(TestWebDriver);
            }
            else
            {
                manageUsersMyQueue.CheckBoxReleaseProductValidaionHold.Click(TestWebDriver);
                manageUsersMyQueue.BtnOrderDetailsSave.Click(TestWebDriver);
            }
        }


        //input : Page Object,process account and DPID
        // function: from Order Details page,puts an Order into suspend 
        public void suspendOrderfromOrderDetailsPage(ManageHeldOrdersPage order,string processAccount,string nextInQueueDPID)
        {
            //Click Suspend DPID link
            order.LnkSelectWorkingDropdown().Click(WebDriver);
            order.LnkSuspendDPIDFromWorkingDropdown().Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            //fill in details in Suspend window and suspend DPID
            order.SuspendWorkItemPopup.IsElementDisplayed(WebDriver).Should().BeTrue();
            order.RadioSelectAssignOtherUserFromSuspend().Click(WebDriver);
            //change to process id where running - for automation - Processdsasec3@Dell.com
            order.EmailAddressSelectAssignOtherUserFromSuspend().SetText(WebDriver, processAccount);
            order.SuspendWorkItemTextarea().SendKeys("Suspending : DPID " + nextInQueueDPID);
            order.BtnSuspendDPID(nextInQueueDPID).Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            order.SuspendVerificationMessage().Should().BeEquivalentTo("DPID " + nextInQueueDPID + " has been suspended.");
            order.CloseSuspendConfirmationPopup().Click(WebDriver);
            order.getWorflowStatusFromOrderDetails().Should().BeEquivalentTo("Suspended");
            order.IsSelectWorkingDropdownPresent().Should().BeFalse();
            Logger.Write("DPID :" + nextInQueueDPID + "now suspended");

        }

       
        public void releaseHeldOrder(ManageHeldOrdersPage orderToRelease)
        {
           
                DsaUtil.WaitForElement(orderToRelease.LnkOrderCommentsHeading, WebDriver);
                if (orderToRelease.LnkReleaseHoldHeldOrder.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(3)))
                {
                    orderToRelease.LnkReleaseHoldHeldOrder.Click(WebDriver);
                }
                else if (!orderToRelease.LnkReleaseHoldHeldOrder.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(3)) && orderToRelease.LnkApproveHeldOrder.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(3)))
                {
                    orderToRelease.LnkApproveHeldOrder.Click(WebDriver);
                }
                else
                {
                    orderToRelease.CheckBoxReleaseProductValidaionHold.Click(WebDriver);
                    orderToRelease.BtnOrderDetailsSave.Click(WebDriver);
                }
            
        }

        //
        public void clearDownHeldOrdersMyQueue(IWebDriver TestWebDriver,ManageHeldOrdersPage myQueue,int queueSize)
        {
            for (int i = 0; i < queueSize - 3; i++)
            {
                //new HomePage(TestWebDriver).WaitForGridToLoad();
                //Navigate to Manage Held Orders myQueue
                new HomePage(TestWebDriver).ClickMainMenu(TestWebDriver).LnkOrderHoldWorkflow.Click(TestWebDriver);
                ManageHeldOrdersPage landingPage = new ManageHeldOrdersPage(TestWebDriver);
                landingPage.LnkOrderHoldMyQueueTab.Click(TestWebDriver);
                ManageHeldOrdersPage manageHeldOrdersMyQueue = new ManageHeldOrdersPage(TestWebDriver);
                TestWebDriver.VerifyBusyOverlayNotDisplayed();
                string DPID = manageHeldOrdersMyQueue.manageHeldOrdersSelectMyQueuebyField(1, 1).Text;
                if (!manageHeldOrdersMyQueue.BtnManageHeldOrdersMyQueueWorkThisItem.IsElementDisplayed(TestWebDriver,TimeSpan.FromSeconds(3)))
                {
                    manageHeldOrdersMyQueue.manageHeldOrdersSelectMyQueuebyField(1, 1).Click(TestWebDriver);
                }
                else
                {
                    manageHeldOrdersMyQueue.BtnManageHeldOrdersMyQueueWorkThisItem.Click(TestWebDriver);
                }
                ManageHeldOrdersPage orderOpened = new ManageHeldOrdersPage(TestWebDriver);
                orderOpened.getWorflowStatusFromOrderDetails();
                switch(orderOpened.getWorflowStatusFromOrderDetails())
                {
                    case "Working":
                        orderOpened.releaseHeldOrder(orderOpened);
                        orderOpened.navigateToManageHeldOrdersMyQueueFromMenu(TestWebDriver);
                        break;
                    case "Suspended":
                        orderOpened.LnkOrderDetailsUpdateWorkFlow.Click(TestWebDriver);
                        orderOpened.TxtAreaReleaseWorkItem.SetText(TestWebDriver, "release DPID");
                        orderOpened.BtnReleaseDPID(DPID).Click(TestWebDriver);
                        orderOpened.CloseSuspendConfirmationPopup();
                        //Navigate to Manage Held Orders myQueue
                        new HomePage(TestWebDriver).ClickMainMenu(TestWebDriver).LnkOrderHoldWorkflow.Click(TestWebDriver);
                        ManageHeldOrdersPage landingPageNew = new ManageHeldOrdersPage(TestWebDriver);
                        landingPageNew.LnkOrderHoldMyQueueTab.Click(TestWebDriver);
                        ManageHeldOrdersPage manageUsersMyQueueNew = new ManageHeldOrdersPage(TestWebDriver);
                        manageUsersMyQueueNew.BtnManageHeldOrdersMyQueueWorkThisItem.Click(TestWebDriver);
                        DsaUtil.WaitForElement(manageUsersMyQueueNew.LnkOrderCommentsHeading, TestWebDriver);
                        if (manageUsersMyQueueNew.LnkReleaseHoldHeldOrder.IsElementDisplayed(TestWebDriver, TimeSpan.FromSeconds(3)))
                        {
                            manageUsersMyQueueNew.LnkReleaseHoldHeldOrder.Click(TestWebDriver);
                        }
                        else if (!manageUsersMyQueueNew.LnkReleaseHoldHeldOrder.IsElementDisplayed(TestWebDriver, TimeSpan.FromSeconds(3)) && manageUsersMyQueueNew.LnkApproveHeldOrder.IsElementDisplayed(TestWebDriver, TimeSpan.FromSeconds(3)))
                        {
                            manageUsersMyQueueNew.LnkApproveHeldOrder.Click(TestWebDriver);
                        }
                        else
                        {
                            manageUsersMyQueueNew.CheckBoxReleaseProductValidaionHold.Click(TestWebDriver);
                            TestWebDriver.WaitForBusyOverlay();
                            manageUsersMyQueueNew.BtnOrderDetailsSave.Click(TestWebDriver);
                        }
                        break;
                    case "Fixed":
                        orderOpened.releaseHeldOrderInFixedStatus(WebDriver);
                        break;
                    default :
                        break;
                }


            }
        }

        public ManageHeldOrdersPage navigateToManageHeldOrdersMyQueueFromMenu(IWebDriver driver)
        {
            new HomePage(driver).ClickMainMenu(driver).LnkOrderHoldWorkflow.Click(driver);
            ManageHeldOrdersPage manageHeldOrdersEmptyQueue = new ManageHeldOrdersPage(driver);
            manageHeldOrdersEmptyQueue.LnkOrderHoldMyQueueTab.Click(driver);
            ManageHeldOrdersPage manageHeldOrdersMyQueue = new ManageHeldOrdersPage(driver);
            return manageHeldOrdersMyQueue;
        }

        public List<IWebElement> manageHeldOrdersMyQueueList()
        {
            var elemTable = WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/tbody"));
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            return lstTrElem;

        }

        public List<IWebElement> manageHeldOrdersMyQueuebyCol()
        {
            var elemTable = WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']"));
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("th")));
            return lstTrElem;

        }
       
        public string manageHeldOrdersMyQueuebyField(int row, int col)
        {
            var elem = WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/tbody/tr[" + row + "]/td[" + col + "]"));
            return elem.Text;

        }

        public IWebElement manageHeldOrdersMyQueuebyFieldElement(int row, int col)
        {
            var elem = WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/tbody/tr[" + row + "]/td[" + col + "]"));
            return elem;

        }



        public string getWorflowStatusFromOrderDetails()
        {
            string result = WebDriver.GetElement(By.XPath("//order-workflow-status/div/div[1]/div/span")).Text;
            return result.Substring(result.LastIndexOf(": ") + 2);

        }

        public IWebElement LnkSuspendDPIDFromWorkingDropdown()
        {
            return WebDriver.GetElement(By.XPath("//*[@id='workflow_suspend_assigned_order']"));
        }
    
        public IWebElement LnkSelectWorkingDropdown()
        {
            return WebDriver.GetElement(By.XPath("//*[@id='workflow_assigned_order']/div/a"));
        }

        public bool IsSelectWorkingDropdownPresent()
        {
            return WebDriver.FindElements(By.XPath("//*[@id='workflow_assigned_order']/div/a")).Count != 0;
        }

        public IWebElement RadioSelectAssignOtherUserFromSuspend()
        {
            //return WebDriver.GetElement(By.XPath("//*[@id='workflow_suspend_assigned_order']/div[1]/div/ul/li[3]/label/input"));
            return WebDriver.GetElement(By.XPath("//*[@id='workflow_suspend_assigned_order']//input[./@type = 'radio']/following::*[text() = 'Assign to other user: ']"));
        }

        public IWebElement EmailAddressSelectAssignOtherUserFromSuspend()
        {
            return WebDriver.GetElement(By.XPath("//*[@id='workflow_suspend_assigned_order']//input[./@type = 'email']"));
        }

        public string SuspendVerificationMessage()
        {
            return WebDriver.GetElement(By.XPath("//*[@id='workflow_suspend_assigned_order']/div")).Text;
        }

        public IWebElement CloseSuspendConfirmationPopup()
        {
            return WebDriver.GetElement(By.XPath("//*[@id='workflow-suspend-assigned-order_modaldialog']/div[1]/a/span"));
        }

        public IWebElement BtnSuspendDPID(string DPID)
        {
            return WebDriver.GetElement(By.Id("workflow_suspend_assigned_order_" + DPID + "_Suspend"));
        }

        public IWebElement BtnReleaseDPID(string DPID)
        {
            return WebDriver.GetElement(By.Id("workflow_release_order_" + DPID + "_Release"));
        }

        public IWebElement LnkMyQueueDPID(string DPID)
        {
            return WebDriver.GetElement(By.Id("MyWorkgroupGrid-0-" + DPID));
        }

        public IWebElement SuspendWorkItemTextarea()
        {
            return WebDriver.GetElement(By.XPath("//*[@id='workflow_suspend_assigned_order']/div[2]/div/textarea"));
        }

        public void handleErrorPage()
        {
            if (WebDriver.FindElements(By.XPath("//*[@id='error_unauthorized_message']")).Count > 0)
            {
                WebDriver.FindElement(By.XPath("//*[@id='error_unauthorized_message']/a")).Click();
            }

        }

        #endregion

        #region id_list
        public Dictionary<string, string> getHeldOrderList()
        {
            Dictionary<string, string> heldOrdersList = new Dictionary<string, string>();
            heldOrdersList.Add("ProductValidatorHold", "workflow_summary_hold_type_3_ProductValidatorHold");
            heldOrdersList.Add("CustomerValidatorHold", "workflow_summary_hold_type_4_CustomerValidatorHold");
            heldOrdersList.Add("CreditCardHold", "workflow_summary_hold_type_7_CreditCardHold");
            heldOrdersList.Add("PayPalHold", "workflow_summary_hold_type_8_PayPalHold");
            heldOrdersList.Add("GiftCardHold", "workflow_summary_hold_type_10_GiftCardHold");
            heldOrdersList.Add("GlobalPaymentFulfillmentLevelHold", "workflow_summary_hold_type_11_GlobalPaymentFulfillmentLevelHold");
            heldOrdersList.Add("CVHold", "workflow_summary_hold_type_13_CVHold");
            heldOrdersList.Add("PVHold", "workflow_summary_hold_type_14_PVHold");
            heldOrdersList.Add("QVBulk", "workflow_summary_hold_type_16_QVBulk");
            heldOrdersList.Add("OrderValidatorHold", "workflow_summary_hold_type_17_OrderValidatorHold");
            heldOrdersList.Add("GCSFirstArticleReviewHold", "workflow_summary_hold_type_41_GCSFirstArticleReviewHold");
            heldOrdersList.Add("PendingOrderModifyHold", "workflow_summary_hold_type_46_PendingOrderModifyHold");
            heldOrdersList.Add("ContractValidatorHold", "workflow_summary_hold_type_61_ContractValidatorHold");
            heldOrdersList.Add("CustomerCommitmentManagerHold", "workflow_summary_hold_type_62_CustomerCommitmentManagerHold");
            heldOrdersList.Add("FrictionlessFlagHold", "workflow_summary_hold_type_63_FrictionlessFlagHold");
            heldOrdersList.Add("OCIRejectedHold", "workflow_summary_hold_type_64_OCIRejectedHold");
            heldOrdersList.Add("OCITransformerValidationHold", "workflow_summary_hold_type_65_OCITransformerValidationHold");
            heldOrdersList.Add("OnlineExceptionHold_66", "workflow_summary_hold_type_66_OnlineExceptionHold");
            heldOrdersList.Add("StopAtQuoteHold", "workflow_summary_hold_type_67_StopAtQuoteHold");
            heldOrdersList.Add("POValidationHold", "workflow_summary_hold_type_69_POValidationHold");
            heldOrdersList.Add("PromotionValidatorHold", "workflow_summary_hold_type_70_PromotionValidatorHold");
            heldOrdersList.Add("LargeOrderQualityAuditPendingHold", "workflow_summary_hold_type_73_LargeOrderQualityAuditPendingHold");
            heldOrdersList.Add("LargeOrderQualityAuditReviewHold", "workflow_summary_hold_type_74_LargeOrderQualityAuditReviewHold");
            heldOrdersList.Add("ViewReleaseQualityCheckHold", "workflow_summary_hold_type_75_ViewReleaseQualityCheckHold");
            heldOrdersList.Add("QualityCheckAuditPendingHold", "workflow_summary_hold_type_76_QualityCheckAuditPendingHold");
            heldOrdersList.Add("GPGConnectivityHold", "workflow_summary_hold_type_90_GPGConnectivityHold");
            heldOrdersList.Add("PVConnectivityHold", "workflow_summary_hold_type_91_PVConnectivityHold");
            heldOrdersList.Add("OnlineExceptionHold_92", "workflow_summary_hold_type_92_OnlineExceptionHold");
            heldOrdersList.Add("RecurringPaymentHold", "workflow_summary_hold_type_93_RecurringPaymentHold");
            heldOrdersList.Add("CreditCardRegisterFailHold", "workflow_summary_hold_type_94_CreditCardRegisterFailHold");
            heldOrdersList.Add("PurchaseOrderRegisterFailHold", "workflow_summary_hold_type_95_PurchaseOrderRegisterFailHold");
            heldOrdersList.Add("PayPalRegisterFailHold", "workflow_summary_hold_type_96_PayPalRegisterFailHold");
            heldOrdersList.Add("MissingTenantIDDomainHold", "workflow_summary_hold_type_101_MissingTenantIDDomainHold");
            heldOrdersList.Add("ValidationHold", "workflow_summary_hold_type_102_ValidationHold");
            heldOrdersList.Add("SystemFailureHold", "workflow_summary_hold_type_103_SystemFailureHold");
            heldOrdersList.Add("PORejectionHold", "workflow_summary_hold_type_104_PORejectionHold");
            heldOrdersList.Add("ReadyStock Inventory Available Hold", "workflow_summary_hold_type_117_ATSPickHold");
            heldOrdersList.Add("ReadyStock GCSFM Pick Hold", "workflow_summary_hold_type_118_GCSFMPickHold");
            heldOrdersList.Add("ReadyStock GCSFM Stock Hold", "workflow_summary_hold_type_119_GCSFMStockHold");
            heldOrdersList.Add("ReadyStock Data Validation Hold", "workflow_summary_hold_type_120_RSValidationHold");
            heldOrdersList.Add("Selling Entity Hold", "workflow_summary_hold_type_121_SellingEntityHold");

            return heldOrdersList;
        }

        public Dictionary<string, string> getHeldOrderListForG4()
        {
            Dictionary<string, string> heldOrdersList = new Dictionary<string, string>();
            heldOrdersList.Add("ATS Pick Hold", "workflow_summary_hold_type_82_ATSPickHold");
            heldOrdersList.Add("Customer Commitment Manager Hold", "workflow_summary_hold_type_48_CustomerCommitmentManagerHold");
            heldOrdersList.Add("Credit Card Hold", "workflow_summary_hold_type_7_CreditCardHold");
            heldOrdersList.Add("CreditCardRegisterFailHold", "workflow_summary_hold_type_73_CreditCardRegisterFailHold");
            heldOrdersList.Add("GCS First Article Review Hold", "workflow_summary_hold_type_20_GCSFirstArticleReviewHold");
            heldOrdersList.Add("SystemFailureHold", "workflow_summary_hold_type_81_SystemFailureHold");
            heldOrdersList.Add("Contract Validator Hold", "workflow_summary_hold_type_47_ContractValidatorHold");
            heldOrdersList.Add("Customer Validator", "workflow_summary_hold_type_4_CustomerValidatorHold");
            heldOrdersList.Add("Frictionless Flag Hold", "workflow_summary_hold_type_49_FrictionlessFlagHold");
            heldOrdersList.Add("GiftCard Hold", "workflow_summary_hold_type_10_GiftCardHold");
            heldOrdersList.Add("GCSFM Pick Hold", "workflow_summary_hold_type_83_GCSFMPickHold");
            heldOrdersList.Add("GCSFM Stock Hold", "workflow_summary_hold_type_84_GCSFMStockHold");
            heldOrdersList.Add("GPGConnectivityHold", "workflow_summary_hold_type_69_GPGConnectivityHold");
            heldOrdersList.Add("ValidationHold", "workflow_summary_hold_type_80_ValidationHold");
            heldOrdersList.Add("LargeOrderQualityAuditPendingHold", "workflow_summary_hold_type_57_LargeOrderQualityAuditPendingHold");
            heldOrdersList.Add("LargeOrderQualityAuditReviewHold", "workflow_summary_hold_type_58_LargeOrderQualityAuditReviewHold");
            heldOrdersList.Add("MissingTenantIDDomainHold", "workflow_summary_hold_type_79_MissingTenantIDDomainHold");
            heldOrdersList.Add("Online Exception Hold", "workflow_summary_hold_type_52_OnlineExceptionHold");
            heldOrdersList.Add("OnlineExceptionHold", "workflow_summary_hold_type_71_OnlineExceptionHold");
            heldOrdersList.Add("OrderValidator Hold", "workflow_summary_hold_type_17_OrderValidatorHold");
            heldOrdersList.Add("GlobalPayment FulfillmentLevel Hold", "workflow_summary_hold_type_11_GlobalPaymentFulfillmentLevelHold");
            heldOrdersList.Add("Pending Order Modify", "workflow_summary_hold_type_19_PendingOrderModifyHold");
            heldOrdersList.Add("PoDuplicateCheckHold", "workflow_summary_hold_type_76_PoDuplicateCheckHold");
            heldOrdersList.Add("PO Validation Hold", "workflow_summary_hold_type_55_POValidationHold");
            heldOrdersList.Add("PurchaseOrderRegisterFailHold", "workflow_summary_hold_type_74_PurchaseOrderRegisterFailHold");
            heldOrdersList.Add("PORejectionHold", "workflow_summary_hold_type_78_PORejectionHold");
            heldOrdersList.Add("Product ValidatorHold", "workflow_summary_hold_type_3_ProductValidatorHold");
            heldOrdersList.Add("PVConnectivityHold", "workflow_summary_hold_type_70_PVConnectivityHold");
            heldOrdersList.Add("PayPal Hold", "workflow_summary_hold_type_8_PayPalHold");
            heldOrdersList.Add("PayPalRegisterFailHold", "workflow_summary_hold_type_75_PayPalRegisterFailHold");
            heldOrdersList.Add("QualityCheckAuditPendingHold", "workflow_summary_hold_type_60_QualityCheckAuditPendingHold");
            heldOrdersList.Add("ViewReleaseQualityCheckHold", "workflow_summary_hold_type_59_ViewReleaseQualityCheckHold");
            heldOrdersList.Add("Bulk Quality Hold", "workflow_summary_hold_type_16_QVBulk");
            heldOrdersList.Add("CVHold", "workflow_summary_hold_type_13_CVHold");
            heldOrdersList.Add("PVHold", "workflow_summary_hold_type_14_PVHold");
            heldOrdersList.Add("Promotion Validator Hold", "workflow_summary_hold_type_56_PromotionValidatorHold");
            heldOrdersList.Add("RecurringPaymentHold", "workflow_summary_hold_type_72_RecurringPaymentHold");
            heldOrdersList.Add("RS Validation Hold", "workflow_summary_hold_type_85_RSValidationHold");
            heldOrdersList.Add("Stop At Quote Hold", "workflow_summary_hold_type_53_StopAtQuoteHold");
            

            return heldOrdersList;
        }
        #endregion
    }
}
