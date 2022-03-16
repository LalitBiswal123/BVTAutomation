using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.DataModels;
using Dsa.Pages.Customer;
using Dsa.Pages.Order;
using Dsa.Pages.Quote;
using Dsa.Utils;
using Dsa.Workflows;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Dsa.Pages.PCFConvergence
{
    public class PCFOrderDetailsPage : DsaPageBase
    {
        private const string PagePrefix = "orderDetails";
        private IWebDriver webDriver;
        public PCFOrderDetailsPage(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "Order Details Page";
            this.webDriver = webDriver;
        }
        public PCFPaymentsPage Summary
        {
            get
            {
                return new PCFPaymentsPage(WebDriver);
            }
        }


        #region UI Elements

        public IWebElement SendAnyway_Button { get { return WebDriver.GetElement(By.Id("proceed-button")); } }

        public IWebElement BtnUpdateOrderContinue { get { return WebDriver.GetElement(By.XPath("//*[@id='_btn_ok']")); } }

        public IWebElement dpidLabel { get { return WebDriver.GetElement(By.Id("order_label_dpid_information")); } }
        public By dpidLabelLocator { get { return By.Id("order_label_dpid_information"); } }
        public IWebElement OrderProcessiongStatus { get { return WebDriver.GetElement(By.XPath("//*[@id='dpidInformationSection']/div/div[3]/div[1]/div[2]")); } }
        public IWebElement OrderProcessiongStatus1 { get { return WebDriver.GetElement(By.XPath("//*[@id='dpidInformationSection']/div/div[3]/div[1]/div[2]/div")); } }
        public IWebElement OpenOrderDetails { get { return WebDriver.FindElement(By.XPath("//*[@id='orderActions_OrderDetails_navLink_header']")); } }
        public IWebElement CancelLink { get { return WebDriver.FindElement(By.XPath("//*[@id='orderActions_OrderDetails_navLink_body']/div[1]/div/div")); } }
        public IWebElement DPIDNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='order_label_dpid_information']")); } }
        public IWebElement LnkRebook { get { return WebDriver.GetElement(By.LinkText("rebook")); } }
        public IWebElement LnkUpdateOrder { get { return WebDriver.FindElement(By.XPath("//*[@id='moreActionsUpdateOrderLabel']")); } }

        public By OrderDetailsHeaderLocator { get { return By.XPath("//span[contains(text(), 'Order Details')]"); } }
        public By OrderDetailsErrorLocator { get { return By.XPath("//*[@role='error']"); } }

        public IWebElement CustomerName_Label { get { return WebDriver.GetElement(By.Id("orderSummary_customerName")); } }

        public IWebElement CompanyDetails_Label { get { return WebDriver.GetElement(By.Id("orderSummary_companyDetails")); } }

        public IWebElement DellSignIn_Button { get { return WebDriver.GetElement(By.Id("lemcEmployeeLoginLink")); } }

        public IWebElement SolutionID_Hyperlink { get { return WebDriver.GetElement(By.ClassName("orderSummary_solutionNumber")); } }

        public IWebElement CustInfoFlyout { get { return WebDriver.GetElement(By.Id("customerInformation_OrderDetails_navLink")); } }

        public IWebElement PrefLanguage { get { return WebDriver.GetElement(By.XPath("//*[@id='collapse_BillTo']/div/div/app-customer/div/div[1]/div[6]/span")); } }

        public IWebElement CustomerInfoBackbutton { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Back')]")); } }

        public IWebElement CustomerHeader { get { return WebDriver.GetElement(By.Id("orderSummary_customerName")); } }

        public void delay(int timeOutInSeconds)
        {
            System.Threading.Thread.Sleep(timeOutInSeconds * 1000);
        }

        // push for the id of the element to be changed as makes no sense
        public IWebElement PrimarySalesRep_Input { get { return WebDriver.GetElement(By.ClassName("primary-sales-rep")); } }

        public IWebElement TaggedSalesRepExpand_Button { get { return WebDriver.GetElement(By.XPath("//*[@class='sales-rep_label']/descendant::button")); } }

        public IWebElement AcceptCookies_Button { get { return WebDriver.GetElement(By.Id("_evidon-accept-button")); } }

        public IWebElement OrderHistoryAndHolds_Label { get { return WebDriver.GetElement(By.Id("label_order_history_holds_section_title")); } }

        public IList<IWebElement> TaggedSalesReps { get { return WebDriver.FindElements(By.XPath("//*[@id='undefined_accordion']/descendant::span")); } }

        public IWebElement Btn_OrderHistoryAndHolds { get { return WebDriver.FindElement(By.Id("holds_OrderDetails_navLink_header")); } }

        public IWebElement Btn_InstallationInstructions { get { return WebDriver.FindElement(By.XPath("//*[@id='installInstruct_OrderDetails_navLink_header']/parent::button")); } }

        public IWebElement InstallationInstructionsTextBox { get { return WebDriver.FindElement(By.Id("installation-instructions-text")); } }

        public IWebElement PaymentNavLink { get { return WebDriver.FindElement(By.Id("payment_OrderDetails_navLink_header")); } }

        public IWebElement LblQuoteNumber { get { return WebDriver.GetElement(By.XPath("//*[@class='orderSummary_quoteNumber']")); } }

        public IWebElement ByLblSummaryTotalShipping
        {
            get { return WebDriver.GetElement(By.Id("pricingSummary_totalShipping")); }
        }

        public IList<IWebElement> LinksGOVGCMPOMReport { get { return WebDriver.FindElements(By.XPath("//*[@id='relatedTools_OrderDetails_navLink_body']/span")); } }

        public IWebElement RelatedToolsLink { get { return WebDriver.FindElement(By.Id("relatedTools_OrderDetails_navLink_header")); } }

        public IWebElement OrderRejectStatusLink { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'Rejected (REJ)')]")); } }


        public IWebElement RejectReason { get { return WebDriver.GetElement(By.XPath("//div[@class='dds__modal-body']/p")); } }

        public IWebElement RejectReasonBtnX { get { return WebDriver.GetElement(By.XPath("//button[contains(@class,'dds__close dds__position-absolute dds__float-right')]")); } }

        public IWebElement ViewCurrentOrdersLink { get { return WebDriver.GetElement(By.Id("viewCurrentOrders_OrderDetails_navLink_header")); } }

        public IWebElement ContainerElementInDialog { get { return WebDriver.GetElement(By.Id("viewRelatedOrdersTable")); } }

        public IWebElement LnkCopyOrder { get { return WebDriver.GetElement(By.Id("moreActionsCopyOrderLabel")); } }

        public IWebElement ExpandPanelLink { get { return WebDriver.GetElement(By.XPath("//*[contains(@class,'nav-toggle-collapsed')]")); } }

        public IWebElement GtpIdValue { get { return WebDriver.GetElement(By.XPath("//*[@id='dpidInformationSection']//div//div[3]//div[6]//div[2]//span")); } }

        public IWebElement EditGtpIdLnk { get { return WebDriver.GetElement(By.XPath("//*[@class='dds__btn-link edit_gtp_id_button']")); } }

        public IWebElement GtpIdTxtBox { get { return WebDriver.GetElement(By.XPath("//*[@id='dpidInformationSection']//div//div[3]//div[7]//div[2]//input")); } }

        public IWebElement BtnSaveOrder { get { return WebDriver.GetElement(By.Id("btnSaveOrder")); } }

        public IWebElement CopyOrderLink { get { return WebDriver.GetElement(By.XPath("//button[contains(text(),'Copy Order')]")); } }

        public IWebElement LanguageCode(string language = "EN")
        {
            return WebDriver.GetElement(By.XPath($"//*[@id='dpidInformationSection']//span[contains(text(), '{language}')]") );
        }

        public IWebElement LblPoNumber { get { return WebDriver.GetElement(By.Id("//button[@class='dds__btn-link edit_po_number_button']/parent::div//span")); } }
        public IWebElement FunderNameOnBillToCustomer { get { return WebDriver.GetElement(By.XPath("//span[text()=' Bill To Customer ']/../following-sibling::div/div[1]/span")); } }
        public IWebElement FunderNumber { get { return WebDriver.GetElement(By.XPath("//span[text()=' Bill To Customer ']/../following-sibling::div/div[2]/span[2]")); } }
        public IWebElement CurrentCustomerCompanyName { get { return WebDriver.GetElement(By.XPath("//span[text()=' Sold To Customer ']/../following-sibling::div/div[1]/span")); } }
        public IWebElement CurrentCustomerNum { get { return WebDriver.GetElement(By.XPath("//span[text()=' Sold To Customer ']/../following-sibling::div/div[2]/span[2]")); } }

        public By ViewDuplicateOrdersDialog
        {
            get { return By.XPath("//div[@id='duplicate_order_details_modal']"); }
        }
        public IWebElement SoldToCustInDupOrdersDialog { get { return WebDriver.GetElement(By.XPath("//*[@class='dds__col-sm-4']//ancestor::div[contains(text(),'Sold')]")); } }

        public IWebElement PONumberInDupOrdersDialog { get { return WebDriver.GetElement(By.XPath("//*[@class='dds__col-sm-4']//ancestor::div[contains(text(),'PO')]")); } }

        public IWebElement ItemQntyDupOrdersDialog { get { return WebDriver.GetElement(By.XPath("//*[@class='dds__col-sm-4']//ancestor::div[contains(text(),'Item')]")); } }

        public IWebElement OrderTotalInDupOrdersDialog { get { return WebDriver.GetElement(By.XPath("//*[@class='dds__col-sm-4']//ancestor::div[contains(text(),'Total')]")); } }

        public IWebElement ShipToAddLn1InDupOrdersDialog { get { return WebDriver.GetElement(By.XPath("//*[@class='dds__col-sm-4']//ancestor::div[contains(text(),'Address')]")); } }

        public IWebElement DupDPIDWindowClose { get { return WebDriver.GetElement(By.XPath("//div[@id='duplicate_order_details_modal']/div/div/button")); } }

        public IWebElement FinalPrice { get { return WebDriver.GetElement(By.Id("pricingSummary_finalPrice")); } }

        public IWebElement ShiptoAddressinorder { get { return WebDriver.GetElement(By.XPath("//*[@id='shipping_info_0_accordion']/descendant::div[@class='dds__col-sm'][1]")); } }

        public IWebElement SoldtoCustomerno { get { return WebDriver.GetElement(By.XPath("(//*[text()='Customer Number']/following-sibling::span)[2]")); } }

        public IWebElement ViewDuplicateOrdersLnk { get { return WebDriver.GetElement(By.Id("btnDuplicateOrderDetailsModal")); } }

        public IWebElement ExpandShippingLink { get { return WebDriver.GetElement(By.XPath("//span[text()='Shipping']/parent::button")); } }

        public IList<IWebElement> DupDPIDListitems { get { return WebDriver.GetElements(By.XPath("//a[@placement='top']")); } }

        public IWebElement DuplicateDPIDWindowHeaderDPID { get { return WebDriver.GetElement(By.XPath("//*[@class='dds__h4_duplicate_header']/a")); } }

        public IWebElement DupDPIDDisclaimer { get { return WebDriver.GetElement(By.XPath("//p[@class='dds__small dds__text-center duplicate-overflow']")); } }

        public IWebElement AdditionalCheckoutFieldLink { get { return WebDriver.GetElement(By.XPath("//div[@id='additional_checkout_fields_OrderDetails_navLink_header']/parent::button")); } }

        public IWebElement AdditionalCheckoutFieldLabel { get { return WebDriver.GetElement(By.XPath("//div[@id='dashboardModalOffcanvas']/div/div[2]")); } }


        #endregion

        #region Install At

        public IWebElement ShippingInfo { get { return WebDriver.GetElement(By.XPath("//*[@class='accordion-header dds__pl-1' and contains(text(), 'Shipping')]")); } }

        public IWebElement InstallAtCamLocationId { get { return WebDriver.GetElement(By.XPath("//*[@class='dds__col-sm-12 label_shipping_install_at_camLocationId']")); } }

        public IWebElement UCIDShipTo { get { return WebDriver.GetElement(By.XPath("//*[@class='dds__col-sm-12 label_shipping_ship_to_ucid']")); } }

        public IWebElement LnkPickDifferentAddress { get { return WebDriver.GetElement(By.XPath("//*[@class='dds__btn-link dds__text-truncate dds__pl-sm-0']")); } }

        public IWebElement AddressesTable { get { return WebDriver.GetElement(By.XPath("//*[@id='change-address-dialog_address-grid']")); } }

        public IWebElement SelectAddressTab(String selectTab)
        {
            return WebDriver.GetElement(By.Id("change-address-dialog_address-grid_tab_" + selectTab));
        }

        public List<Dictionary<string, object>> GetAddressTable()
        {
            AddressesTable.WaitForElement(WebDriver);
            return AddressesTable.GetTableData(WebDriver);
        }

        #endregion

        #region GroupSummaryElements
        public IWebElement LblGroupSummaryShippingAmount(int groupIndex = 1)
        {
            return WebDriver.GetElement(By.Id("Shipping_pricing_Summary_" + (groupIndex - 1) + "_totalShipping"));
        }
        #endregion

        #region Actions

        public void WaitForOrderToLoad()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            var pageLoaded = WebDriver.WaitForEitherElement(OrderDetailsHeaderLocator, OrderDetailsErrorLocator);
            if (!pageLoaded)
            {
                Assert.Fail("Order failed to load!");
            }
        }

        public void GoToDPID(string dpid, string country = "US", string language = "EN")
        {
            var url = WebDriver.Url;
            url = new StringBuilder().AppendFormat(url + "{0}/{1}/{2}", country, language, dpid).ToString();
            WebDriver.Navigate().GoToUrl(url);
            WebDriver.WaitForPageLoad();

            WaitForOrderToLoad();
        }

        public string GetCustomerNumber()
        {
            string companyDetails = CompanyDetails_Label.Text;
            companyDetails = companyDetails.Trim();
            string[] companyDetailsArray = companyDetails.Split(' ');
            return companyDetailsArray.First();
        }


        public bool VerifySolutionHyperlinkWorks(IWebDriver driver)
        {
            bool redirectedToOSC = false;
            SolutionID_Hyperlink.PCFClick(driver);
            //switch to new window.
            WebDriver.SwitchTo().Window(WebDriver.WindowHandles.Last());
            redirectedToOSC = WebDriver.Url.Contains("osc");
            //if you want to switch back to your first window
            //WebDriver.SwitchTo().Window(WebDriver.WindowHandles.First());
            return redirectedToOSC;
        }

        public bool VerifyNonOSCOrderHasNoSolutionID()
        {
            try
            {
                return !SolutionID_Hyperlink.Displayed;
            }
            catch (Exception e)
            {
                return true;
            }
        }

        public IList<string> GetTaggedSalesReps(IWebDriver driver, int numberOfSalesReps = 1)
        {
            TaggedSalesRepExpand_Button.PCFClick(driver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            var salesRepsIds = new List<string>();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            for (int i = 0; i < numberOfSalesReps; i++)
            {
                wait.Until(d => TaggedSalesReps[i].Displayed);
            }
            foreach (var element in TaggedSalesReps)
            {
                salesRepsIds.Add(element.Text.Split('/').First().Trim());
            }
            return salesRepsIds;
        }


        public bool VerifyOrderHold(string orderHold)
        {
            string xpath = string.Format("//td[text()='{0}']", orderHold);
            try
            {
                WebDriver.FindElement(By.XPath(xpath));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SwitchWindowAndVerifyURL(IWebDriver driver, IWebElement link, string url)
        {
            string parentWindow = driver.CurrentWindowHandle;
            link.Click();
            foreach (string window in driver.WindowHandles)
            {
                if (window != parentWindow)
                {
                    driver.SwitchTo().Window(window);
                    WebDriverUtil.WaitUntilUrlDisplay(driver, url, 20);
                    if (driver.Url.Contains(url))
                    {
                        Logger.Write("Window Switched to " + driver.Url);
                        driver.Close();
                        driver.SwitchTo().Window(parentWindow);
                        return true;
                    }
                }

            }
            return false;
        }

        #endregion

        #region FT2
        public IWebElement GoalLiteDealIdLabel { get { return WebDriver.GetElement(By.Id("orderDetails_goalLiteId_label")); } }

        public IWebElement LblDpid { get { return WebDriver.GetElement(By.Id("orderDetails_dpid")); } }

        public IWebElement LblSummaryLevelSmartPriceRevenue { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_GI_smartPrice_Revenue_']")); } }

        public IWebElement GoalLiteDealIdValue { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_goalLiteId_value']/label")); } }

        public IWebElement LnkMoreActions { get { return WebDriver.GetElement(By.XPath("//*[@id='orderActions_OrderDetails_navLink']")); } }

        public IWebElement LnkCancelOrder { get { return WebDriver.GetElement(By.XPath("//*[@id='moreActionsCancelOrderLabel']")); } }

        public IWebElement ByItemSummaryUpSellModRevenueLabel1(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_orders_line_items_']/div/div[2]/div/dpid-order-item/div/div[2]/div/div/div/order-item-header-summary/div/div[3]/div/order-item-smart-price-info/div/div[3]/label"));
        }

        public IWebElement ExpandAllElm
        {
            get
            {
                return WebDriver.GetElement(By.XPath("//button[contains(., 'Expand All')]"));
            }
         }

        public IWebElement LnkSearchOrder { get { return WebDriver.GetElement(By.XPath("//*[@id='buttonDropdownPrimary']/ul/li[3]/app-menu-item[1]/li/ul/li[7]/a")); } }
        public IWebElement LnkHome { get { return WebDriver.GetElement(By.XPath("//*//*[@id='buttonDropdownPrimary']/ul/li[1]/app-menu-item[1]/li/ul/li[1]/h5/a")); } }

        public IWebElement TblOrderHolds { get { return WebDriver.GetElement(By.XPath("//*[@class='table releaseHold']")); } }
        public string pcfGetOrderProcessingStatusOfDpid()
        {
            while (!WebDriver.ElementExists(By.XPath("//*[@id='dpidInformationSection']/div/div[3]/div[1]/div[2]/div")))
            {
                //Do Nothing 
            }

            return OrderProcessiongStatus1.GetText(WebDriver);
        }

        public PCFCancelOrderPage CancelOrderPage()
        {

            return new PCFCancelOrderPage(webDriver);
        }

        public string GetGoalDealIdFromItem(int itemIndex = 1)
        {
            return
                WebDriver.GetElement(By.Id(PagePrefix + "_LI_info_goalDealId_" + "_" + (itemIndex - 1))).GetText(WebDriver);
        }

        //public PCFOrderDetailsPage CancelOrder()
        //{
        //    OpenOrderDetails.Click(WebDriver);
        //    WebDriver.VerifyBusyOverlayNotDisplayed();
        //    CancelLink.Click(WebDriver);
        //    return new PCFOrderDetailsPage(webDriver);
        //}

        public string GetOrderHoldActionStatus(string holdType)
        {
            return TblOrderHolds.FindElement(By.XPath("//td[normalize-space()='" + holdType + "']//..//td[last()]"))
                .GetText(WebDriver);

        }

        public IWebElement ExpandLineItem(int lineItemIndex = 1)

        {
            //return WebDriver.GetElements(By.XPath("//span[contains(@id,'_LI_lineNumber__')]"))[lineItemIndex];
            //return WebDriver.GetElement(By.Id(PagePrefix + "_LI_" + "lineNumber__" + (lineItemIndex - 1)));
            return WebDriver.GetElement(By.XPath("(//span[contains(@id,'_LI_lineNumber__')])[" + lineItemIndex + "]"));
        }

        public IWebElement ExpandLineItem_(int lineItemIndex = 1)

        {
            return WebDriver.GetElement(By.XPath("//*[@id='productsSummary"+(lineItemIndex-1)+"_headingOne']/h5/button[2]"));
        }

        public IWebElement LnkItemDesc(int lineItemIndex = 1)
        {
            return WebDriver.GetElements(By.XPath("//*[contains(@id, 'displayMode_LI_lineNumber__')]"))[
                lineItemIndex - 1];

            // return WebDriver.GetElements(By.XPath("(//*@id='orderDetails_LI_lineNumber__0')"))[1];

            //(//*[@id='orderDetails_LI_lineNumber__0'])[1]
            // return WebDriver.GetElements(By.XPath("(//*[contains(@id, 'orderDetails_LI_lineNumber__0')]"))[1];
        }

        public IWebElement TxtOrderSearchDpId
        {
            get{
                return WebDriver.GetElement(By.Id("orderSearch_dpid"));

            }
        }

        public IWebElement GotoMenu { get { return WebDriver.GetElement(By.XPath("//*[@id='masthead_menu_title']")); } }

        public IWebElement SearchOrderlnk { get { return WebDriver.GetElement(By.XPath("//*[@id='buttonDropdownPrimary']/ul/li[3]/app-menu-item[1]/li/ul/li[7]/a")); } }
        public PCFOrderDetailsPage SearchOrderByDpidNumber(string dpidnumber)
        {
            TxtOrderSearchDpId.SetText(WebDriver, dpidnumber);
            return new PCFOrderDetailsPage(WebDriver);
        }

        public OrderSearchPage GoToOrderSearchPage()
        {
            GotoMenu.Click(WebDriver);
            LnkSearchOrder.Click(WebDriver);
            return new OrderSearchPage(WebDriver);
        }

        public string GetDPIDNumber()
        {
            while (!WebDriver.ElementExists(By.XPath("//*[@id='order_label_dpid_information']")))
            {
                //Do Nothing 
            }

            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            return DPIDNumber.GetText(WebDriver).TrimStart("DPID ".ToCharArray());
        }

        public CreateQuotePage RebookOrder()
        {
            while (!WebDriver.ElementExists(By.LinkText("rebook")))
            {
                //Do Nothing 
            }
            LnkRebook.Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return new CreateQuotePage(WebDriver);
        }

        public PCFOrderDetailsPage ReleaseOrderHold(string holdType)
        {
            var linkname = "";
            if (holdType == "CVHold" || holdType == "PVHold")
            {
                linkname = "Approve";
            }
            else
            {
                linkname = "Release Hold";
            }


            TblOrderHolds
                .FindElement(By.XPath("//td[normalize-space()='" + holdType + "']//..//a[normalize-space()='" + linkname + "']")).Click(WebDriver);
            return new PCFOrderDetailsPage(WebDriver);
        }

        public CreateQuotePage UpdateOrder()
        {
            while (!WebDriver.ElementExists(By.XPath("//*[@id='orderActions_OrderDetails_navLink_header']")))
            {
                //Do Nothing 
            }
            OpenOrderDetails.Click(WebDriver);
            LnkUpdateOrder.Click(WebDriver);
            //if (!LnkUpdateOrder.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(20)))
            //{
            //    LnkUpdateOrder.Click(WebDriver);
            //}
            //else
            //{
            //    WebDriver.Navigate().Refresh();
            //    LnkUpdateOrder.Click(WebDriver);
            //}
            WebDriver.WaitForPageLoad();
            BtnUpdateOrderContinue.Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.WaitForPageLoad();
            return new CreateQuotePage(WebDriver);
        }

        public PCFCancelOrderPage CancelOrder()
        {
            WebDriver.WaitForPageLoad();
            while (!WebDriver.ElementExists(By.XPath("//*[@id='orderActions_OrderDetails_navLink']")))
            
            {
                    //Do Nothing 
            }
            
            LnkMoreActions.PCFClick(WebDriver);
            LnkCancelOrder.PCFClick(WebDriver);
            WebDriver.WaitForPageLoad();
            return new PCFCancelOrderPage(WebDriver);
        }

        public PCFOrderDetailsPage ExpandItemDetails(int index = 1)
        {
            //ExpandLineItem(index).Click(WebDriver);
            LnkItemDesc(index).Click(WebDriver);
            return new PCFOrderDetailsPage(WebDriver);
        }


        public PCFOrderDetailsPage ExpandAll()
        {

            ExpandAllElm.Click(WebDriver);
            return new PCFOrderDetailsPage(webDriver);
        }

        #endregion

        #region POM
        public IWebElement PoNumberLabel_OrderDetailspage { get { return WebDriver.GetElement(By.XPath("//div[@id='headerPONumberTitle']")); } }

        public IWebElement EditPONumber { get { return WebDriver.GetElement(By.XPath("//button[@class='dds__btn-link edit_po_number_button']")); } }
        public IWebElement TxtPONumber { get { return WebDriver.GetElement(By.XPath("//input[contains(@class,'edit_po_number_input_box')]")); } }

        
        public IWebElement PoNumber_OrderDetailspage { get { return WebDriver.GetElement(By.XPath("//button[@class='dds__btn-link edit_po_number_button']//parent::div//child::span")); } }
        public IWebElement POMIDLabel_OrderDetailspage { get { return WebDriver.GetElement(By.XPath("//div[@id='headerPOMIdTitle']")); } }
        public IWebElement POMID_OrderDetailspage { get { return WebDriver.GetElement(By.XPath("//div[@class='field-value dds__btn-link']/span/a")); } }

        public IWebElement OrderNumberField { get { return WebDriver.GetElement(By.XPath("//div[@class='dds__divider-title purchase_order_title']/div")); } }
        public IWebElement TblOrderHolds_OrderDetails { get { return WebDriver.GetElement(By.XPath("//*[@class='dds__table borderless table_order_holds']")); } }
        public IWebElement LnkClosePOM { get { return WebDriver.GetElement(By.Id("moreActionsClosePomIdLabel")); } }
        public IWebElement CloseConfirmation { get { return WebDriver.GetElement(By.XPath("//h3[@id='dds__modal-title_close_pom']")); } }

        public IWebElement POMCloseYes { get { return WebDriver.GetElement(By.XPath("//button[@id='pomid_close']")); } }

        public IWebElement POMCloseNo { get { return WebDriver.GetElement(By.XPath("//button[@id='pomid_cancel']")); } }

        public IWebElement POMClose { get { return WebDriver.GetElement(By.XPath("//button[@id='pomid_close']")); } }
        public IWebElement SuccessMsg { get { return WebDriver.GetElement(By.XPath("//div[@id='orderDetails_gimrMessage']/div")); } }
        public IWebElement OrderPOMid { get { return WebDriver.GetElement(By.XPath("//div[@id='close_pom_pomId']/div")); } }

        public IWebElement RelatedLinksPOM { get { return WebDriver.FindElement(By.XPath("//*[@id='relatedTools_OrderDetails_navLink_body']/span[3]")); } }

        public IWebElement BlankPOMID { get { return WebDriver.FindElement(By.XPath("//span[@class='pom_id']")); } }
        public IWebElement BlankPoNumber { get { return WebDriver.FindElement(By.XPath("//span[@class='order_label_po_number_title']/parent::div/parent::div/div[@class='field-value']/span")); } }

        
        public void ReleaseOrderHold(string holdType, IWebDriver driver)
        {
            var linkname = "";
            if (holdType == "CVHold" || holdType == "PVHold")
            {
                linkname = "Approve";
            }
            else
            {
                linkname = "Release Hold";
            }


            TblOrderHolds_OrderDetails
                .FindElement(By.XPath("//button[@class='dds__btn-link dds__text-truncate dds__p-0 button_order_holds_approve']")).Click(driver);

        }

        #endregion POM

        public string GetDpidFromOrderDetails()
        {
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            var dpid = wait.Until(ExpectedConditions.ElementIsVisible(dpidLabelLocator));
            var label = dpid.GetText(webDriver, TimeSpan.FromSeconds(3));
            return label.TrimStart("DPID ".ToCharArray());
        }

        public CreateQuotePage CopyOrder()
        {
            LnkMoreActions.Click(WebDriver);
            LnkCopyOrder.Click(WebDriver);
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            return new CreateQuotePage(WebDriver);
        }

        public IWebElement LblFulfillmentLevelRSid(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='productsSummary" + (lineItemIndex - 1) + "_accordion']"));
        }
        public IWebElement VerifyListofPayments(int shippingGroupIndex = 1)
        {
            return WebDriver.GetElements(By.XPath("(//*[contains(@id,'_paymentmethod')])"))[shippingGroupIndex - 1];
        }

        public void ExpandPanel()
        {
            try
            {
                ExpandPanelLink.Click();
            }
            catch(NullReferenceException e)
            {
                // do nothing, panel is expanded
            }
        }

        public PCFOrderDetailsPage EditAndUpdateGtpId(IWebDriver WebDriver, string GtpId)
		{
            EditGtpIdLnk.Click(WebDriver);
            GtpIdTxtBox.SendKeys(Keys.Control + "a");
            GtpIdTxtBox.SendKeys(Keys.Backspace);
            GtpIdTxtBox.SetText(WebDriver, GtpId);
            GtpIdTxtBox.SendKeys(Keys.Tab);
            BtnSaveOrder.Click(WebDriver);
            WebDriver.WaitForPageLoad();
            return new PCFOrderDetailsPage(WebDriver);
		}

        public IWebElement GetCustomPriceNotification(string text)
        {
            return WebDriver.FindElement(
                By.XPath("//p[contains(text(),'"+text +"')]"));
        }

        //Pricing Summary 

        public IWebElement LblPricingSummaryListPrice { get { return WebDriver.GetElement(By.XPath("//*[@id='list-price']/span[2]")); } }


        public IWebElement LblPricingSummaryDiscount { get { return WebDriver.GetElement(By.XPath("//*[@id='discount']/div/span[1]")); } }
        public IWebElement LblPricingSummaryDiscountPercentage { get { return WebDriver.GetElement(By.XPath("//*[@id='discount']/div/span[2]")); } }


        public IWebElement LblPricingSummarySellingPrice { get { return WebDriver.GetElement(By.XPath("//*[@id='selling-price']/span[2]")); } }

        public IWebElement LblSummaryMargin { get { return WebDriver.GetElement(By.XPath("//*[@id='total-margin']/div/span[1]")); } }


        public IWebElement LblPricingSummaryShippingPrice { get { return WebDriver.GetElement(By.XPath("//*[@id='shipping-price']/span[2]")); } }


        public IWebElement LblPricingSummaryShippingDiscount { get { return WebDriver.GetElement(By.XPath("//*[@id='shipping-discount']/span[2]")); } }


        public IWebElement LblPricingSummaryTotalShipping { get { return WebDriver.GetElement(By.XPath("//*[@id='total-shipping']/span[2]")); } }


        public IWebElement LblPricingSummaryTaxableAmount { get { return WebDriver.GetElement(By.XPath("pricingSummary_taxableAmount")); } }


        public IWebElement LblPricingSummaryNonTaxableAmount { get { return WebDriver.GetElement(By.XPath("pricingSummary_nonTaxableAmount")); } }


        public IWebElement LblPricingSummaryTotalTax { get { return WebDriver.GetElement(By.XPath("//*[@id='total-tax']/span[2]")); } }


        public IWebElement LblPricingSummarySubTotal { get { return WebDriver.GetElement(By.XPath("//*[@id='sub-total']/span[2]")); } }


        public IWebElement LblPricingSummaryTotalEcoFee { get { return WebDriver.GetElement(By.XPath("//*[@id='total-eco-fee']/span[2]")); } }


        public IWebElement LblPricingSummaryFinalPrice { get { return WebDriver.GetElement(By.XPath("//*[@id='total']/div/span")); } }
        
        public IWebElement OrderDetailsPaymentInformationToggle { get { return WebDriver.GetElement(By.XPath("//*[@id='payment_OrderDetails_navLink']")); } }
        public IWebElement OrderDetailsPaymentTerms { get { return WebDriver.GetElement(By.XPath("//*[@id='OrderDetails_payment_information_NetTerms1_terms']")); } }

        public IWebElement GetOrderTypeFromSingleOrder { get { return WebDriver.GetElement(By.XPath("//span[@class='order_order_type']")); } }

        public IWebElement GetContractCode { get { return WebDriver.GetElement(By.XPath("//*[@id='productsSummary0_accordion']/div/div/div/div/app-order-product-summary/div/div[2]/app-order-product-item-details/div[3]/div[7]/span[2]")); } }

        public QuoteSummaryValues GetOrderSummaryValues(bool isSmartPriceEnabled = false)
        {
            var values = new QuoteSummaryValues();
            Logger.Write("Getting Values Of Summary of Quote ");
            Logger.Write("-------------------------");

            values.ListPrice = LblPricingSummaryListPrice.GetText(WebDriver);
            values.SellingPrice = LblPricingSummarySellingPrice.GetText(WebDriver);

            values.Discount = LblPricingSummaryDiscount.GetText(WebDriver);
            string discountPert = LblPricingSummaryDiscountPercentage.GetText(WebDriver);
            values.DiscountPercentage = LblPricingSummaryDiscountPercentage.GetText(WebDriver).Substring(1, discountPert.Length - 2);

            values.TotalMargin = LblSummaryMargin.GetText(WebDriver).Substring(3);
            //if (isSmartPriceEnabled)
            //  values.SmartpriceRevenue = ByLblSummarySmartpriceRevenue.GetText(WebDriver);
            values.ShippingPrice = LblPricingSummaryShippingPrice.GetText(WebDriver);
            values.ShippingDiscount = LblPricingSummaryShippingDiscount.GetText(WebDriver);
            values.Subtotal = Convert.ToDouble(LblPricingSummarySubTotal.GetText(WebDriver).Substring(1));
            values.TotalShipping = Convert.ToDouble(LblPricingSummaryTotalShipping.GetText(WebDriver).Substring(1));
            values.TotalTax = Convert.ToDouble(LblPricingSummaryTotalTax.GetText(WebDriver).Substring(1));
            values.TotalEcoFee = Convert.ToDouble(LblPricingSummaryTotalEcoFee.GetText(WebDriver).Substring(1));
            values.FinalPrice = Convert.ToDouble(LblPricingSummaryFinalPrice.GetText(WebDriver).Substring(5));

            return values;
        }

        public ItemQuoteData GetLineItemUnitValuesWithQuantity(int itemIndex = 1, bool contractCodeRequired = false)
        {
            Logger.Write("Getting Values for Item " + itemIndex + " With Quantity");
            Logger.Write("-------------------------");

            var itemQuoteDataWithQuantity = new ItemQuoteData
            {
                ListPrice = LblItemLevelTotalListPrice(itemIndex).GetText(WebDriver).Substring(1),
                Discount = Convert.ToDouble(LblItemLevelTotalDiscount(itemIndex).GetText(WebDriver).Split('/')[1]
                    .Substring(2)),
                // DiscountOffList = Convert.ToDouble(LblItemLevelDiscount(itemIndex, groupIndex).GetText(WebDriver).Split('/')[0].Substring(0).Split('%')[0]),
                SellingPrice = LblItemLevelTotalSellingPrice(itemIndex).GetText(WebDriver).Substring(1),
                Margin = LblItemLevelMargin(itemIndex).GetText(WebDriver),
                MarginValue =
                    Convert.ToDouble(LblItemLevelMargin(itemIndex).GetText(WebDriver).Split('/')[1].Substring(2)),
                MarginPert =
                    Convert.ToDouble(LblItemLevelMargin(itemIndex).GetText(WebDriver).Split('/')[0].Substring(0)
                        .Split('%')[0]),
                PromoValue =
                    Convert.ToDouble(LblItemLevelPromotions(itemIndex).GetText(WebDriver).Split('/')[1].Substring(2)),
                PromoPert = Convert.ToDouble(LblItemLevelPromotions(itemIndex).GetText(WebDriver).Split('/')[0]
                    .Substring(0).Split('%')[0]),
                ContractCode = contractCodeRequired ? LblContractCode(itemIndex).GetText(WebDriver) : ""
            };

            return itemQuoteDataWithQuantity;
        }

        public IWebElement LblItemLevelTotalListPrice(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='productsSummary" + (lineItemIndex -1) + "_accordion']/div/div/div/div/app-order-product-summary/div/div[2]/app-order-product-item-details/div[1]/div[2]/div[2]/span[2]"));
        }

        public IWebElement LblItemLevelTotalDiscount(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='productsSummary" + (lineItemIndex - 1) + "_accordion']/div/div/div/div/app-order-product-summary/div/div[2]/app-order-product-item-details/div[1]/div[2]/div[4]/span[2]"));
        }

        public IWebElement LblItemLevelTotalSellingPrice(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='productsSummary" + (lineItemIndex - 1) + "_accordion']/div/div/div/div/app-order-product-summary/div/div[2]/app-order-product-item-details/div[1]/div[2]/div[5]/span[2]"));
        }
        public IWebElement LblItemLevelMargin(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='productsSummary" + (lineItemIndex - 1) + "_accordion']/div/div/div/div/app-order-product-summary/div/div[2]/app-order-product-item-details/div[1]/div[2]/div[6]/span[2]"));
        }
        public IWebElement LblItemLevelPromotions(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='productsSummary" + (lineItemIndex - 1) + "_accordion']/div/div/div/div/app-order-product-summary/div/div[2]/app-order-product-item-details/div[3]/div[2]/span[2]"));
        }

        public IWebElement LblContractCode(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='productsSummary" + (lineItemIndex - 1) + "_accordion']/div/div/div/div/app-order-product-summary/div/div[2]/app-order-product-item-details/div[3]/div[3]/span[2]"));
        }

        public bool ValidateFunderSwap()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            var funderName = FunderNameOnBillToCustomer.GetText(WebDriver);
            var customerName = CurrentCustomerCompanyName.GetText(WebDriver);
            var funderCust = FunderNumber.GetText(WebDriver);
            var customerNum = CurrentCustomerNum.GetText(WebDriver);
            if ((funderName != customerName) && (funderCust != customerNum))
                return true;
            return false;
        }

        public void VerifyDpidlistinOderdetails(IWebDriver driver, string DiffDPID)
        {
            string finalprice = FinalPrice.Text;
            string SoldtoCustomer = SoldtoCustomerno.Text.Replace(" " + ",", "");
            ExpandShippingSection(driver);
            driver.VerifyBusyOverlayNotDisplayed();
            string Shiptoaddresstext = ShiptoAddressinorder.Text.Replace(" " + ",", "");

            Ordersearchwithdefferentdpid(driver, DiffDPID);
            FinalPrice.GetText(driver).Should().Equals(finalprice);
            SoldtoCustomerno.GetText(driver).Should().Equals(SoldtoCustomer);
            ExpandShippingLink.Click();
            ShiptoAddressinorder.GetText(driver).Should().Equals(Shiptoaddresstext);
        }

        public void Ordersearchwithdefferentdpid(IWebDriver driver, string DPID)
        {
            new HomePage(driver).ClickDellLogo(driver);
            driver.VerifyBusyOverlayNotDisplayed();
            HomeWorkflow.GoToOrderSearchPage(driver);
            new OrderSearchPage(driver).SearchOrderByDpidNumber(DPID);
            driver.PCFVerifyBusyOverlayNotDisplayed();
            try
            {
                SendAnyway_Button.Click();
                driver.PCFVerifyBusyOverlayNotDisplayed();
            }
            catch { }
            new PCFOrderDetailsPage(driver).GetDpidFromOrderDetails().Should().BeEquivalentTo(DPID);
            // orderDetailsPage.ViewDuplicateOrdersLnk.Click();
            //var Disclaimer = orderDetailsPage.DupDPIDDisclaimer.Text.ToString();
            //Assert.IsTrue(Disclaimer.Equals("Note: The DPID list below may not be updated because it was generated at the time of order creation. Therefore, new orders or changes " +
            //    "to existing orders will not have been subjected to the duplicate PO check."));
        }

        public void CloseDuplicateDPIDWindow(IWebDriver driver)
        {
            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].click();", DupDPIDWindowClose);
        }

        public void ExpandShippingSection(IWebDriver driver)
        {
            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].click();", ExpandShippingLink);
        }

        public void WaitForOrderDetailsToload()
        {
            WebDriverUtil.WaitForElementDisplay(WebDriver, By.Id("order_label_dpid_information"), TimeSpan.FromSeconds(15));
        }
        public string GetOrderProcessingStatusOfDpid()
        {
            return OrderProcessiongStatus1.GetText(WebDriver);
        }
    }
}