using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.DataModels;
using Dsa.Pages.Customer;
using Dsa.Pages.Quote;
using Dsa.Utils;
using Dsa.Workflows;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Dsa.Pages.Order
{
    public class OrderDetailsPage : DsaPageBase
    {
        private const string PagePrefix = "orderDetails";

        public OrderDetailsPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        public QuoteSummary Summary
        {
            get { return new QuoteSummary(WebDriver, PagePrefix); }
        }

        public QuotePage PageInformation
        {
            get { return new QuotePage(WebDriver, PagePrefix); }
        }

        #region Elements



        //[FindsBy(How = How.Id, Using = "//*[@id='main']/quote-create-root/quote-create/div/div/div[1]/quote-create-header/div[6]/div/quote-create-dell-print-address/div/div/div[1]/div]")]
        //public IWebElement AddressesDropDown;



public IWebElement LblPaymentMethodElement { get { return WebDriver.GetElement(By.CssSelector("div[id^='orderDetails_payment_information'][id$='paymentmethod']")); } }


public IWebElement LnkCurrentCustomerCompanyName { get { return WebDriver.GetElement(By.Id("currentCustomer_createCustomerHeaderLink1")); } }


public IWebElement LnkCurrentCustomerCustomerName { get { return WebDriver.GetElement(By.Id("currentCustomer_createCustomerHeaderLink2")); } }


public IWebElement TxtCurrentCustomerCustomerNumber { get { return WebDriver.GetElement(By.Id("currentCustomer_customerNumber")); } }


public IWebElement TxtCurrentCustomerCompanyNumber { get { return WebDriver.GetElement(By.Id("currentCustomer_context")); } }

        //-------------------------------------------


public IWebElement LnkSalesRepInformation { get { return WebDriver.GetElement(By.Id("orderDetails_salesrep_information_Heading")); } }


public IWebElement ExpandInstallationInstructions1 { get { return WebDriver.GetElement(By.Id("orderDetails_installationinstructions_header")); } }


public IWebElement TxtInstallationInstructions { get { return WebDriver.GetElement(By.Id("orderDetails_installationinstructions")); } }


public IWebElement LnkSalesRepDetails { get { return WebDriver.GetElement(By.Id("orderDetails_salesRep")); } }

public IWebElement LblInstallInsfailed { get { return WebDriver.GetElement(By.Id("orderDetails_updateHoldFailed")); } }

public IWebElement LblLicenseContact { get { return WebDriver.GetElement(By.XPath("//label[text()= 'License Contact:']")); } }

public IList<IWebElement> LinksGOVGCMPOMReport { get { return WebDriver.GetElements(By.XPath("//a[@class='link-group']")); } }

public IWebElement LblLicenseContactData { get { return WebDriver.GetElement(By.Id("orderDetails_contactName")); } }

public IWebElement LblLicenseContactEmail { get { return WebDriver.GetElement(By.Id("orderDetails_contactEmail")); } }


public IWebElement LblLicenseContactConfirmation { get { return WebDriver.GetElement(By.XPath("//label[text()= 'License Confirmation:']")); } }


public IWebElement LblLicenseContactConfirmationInfo { get { return WebDriver.GetElement(By.Id("orderDetails_licenseDescription")); } }


public IWebElement TxtShippingInstructions { get { return WebDriver.GetElement(By.Id("orderDetails_edit_shipping_instructions")); } }

      
        public IWebElement LblOrderDetailsPrimarySalesRep { get { return WebDriver.GetElement(By.Id("orderDetails_salesRep")); } }


        public IWebElement HdrOrderDetails { get { return WebDriver.GetElement(By.Id("orderDetails_title")); } }


public IWebElement SalerepChgmsg { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_salesRep']//a[text()='Cancel']/preceding-sibling::span")); } }


        //[FindsBy(How = How.Id, Using = "orderDetails_dpid")] public IWebElement LblDpid;
        public IWebElement LblDpid { get { return WebDriver.GetElement(By.Id("orderDetails_dpid")); } }

        public IWebElement AsyncOgDpidInprogress { get { return WebDriver.GetElement(By.Id("asyncOg_dpid_inprogress")); } }

        public IWebElement AsyncOgDpidRefresh { get { return WebDriver.GetElement(By.Id("asyncOg_dpid_refresh")); } }
        

public IWebElement LblSolutionId { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_solutionNumber']/a")); } }


public IWebElement LinkedEnteredDPID { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_cancelledOrder_dpid'][2] ")); } }

public IWebElement LblQuoteNumber { get { return WebDriver.GetElement(By.Id("orderDetails_quoteNumber")); } }

public IWebElement LblPoNumber { get { return WebDriver.GetElement(By.Id("orderDetails_poNumber")); } }

public IWebElement LblPOMID { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_pomId']//label")); } }

public IWebElement PoMId { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_pomId']/span")); } }

       //[FindsBy(How = How.Id, Using = "orderDetails_moreActions")] public IWebElement LnkMoreActions;
        public IWebElement LnkMoreActions { get { return WebDriver.GetElement(By.Id("orderActions_OrderDetails_navLink")); } }

public IWebElement LnkCopyOrder { get { return WebDriver.GetElement(By.Id("orderDetails_editQuote")); } }

public IWebElement LnkCancelOrder { get { return WebDriver.GetElement(By.Id("orderDetails_cancelOrder")); } }

        //[FindsBy(How = How.Id, Using = "orderDetails_change_order")] public IWebElement LnkUpdateOrder;
        public IWebElement LnkUpdateOrder { get { return WebDriver.GetElement(By.Id("orderDetails_change_order")); } }


public IWebElement BtnSendOrder { get { return WebDriver.GetElement(By.Id("orderDetails_createOrder")); } }

public IWebElement BtnSaveOrder { get { return WebDriver.GetElement(By.Id("orderDetails_saveOrder")); } }


public IWebElement CustomerNumber { get { return WebDriver.GetElement(By.Id("orderDetails_customerNumber")); } }

public IWebElement CompanyNumber { get { return WebDriver.GetElement(By.Id("orderDetails_companyNumber")); } }

public IWebElement CustomerToggle { get { return WebDriver.GetElement(By.Id("orderDetails_customerInformationToggle")); } }


public IWebElement OrderDetailsPaymentInformationToggle { get { return WebDriver.GetElement(By.Id("orderDetails_payment_information_Heading")); } }


public IWebElement OrderDetailsPaymentMethod { get { return WebDriver.GetElement(By.Id("orderDetails_payment_information_1_paymentmethod")); } }


public IWebElement OrderDetailsPaymentTerm { get { return WebDriver.GetElement(By.Id("orderDetails_payment_information_netterms1_paymentterms")); } }

public IWebElement OrderDetailsNoResults { get { return WebDriver.GetElement(By.Id("noResults_returnPrevious_partPre")); } }

public IWebElement HdrOrderDetailsOrder { get { return WebDriver.GetElement(By.Id("orderDetails_order_header_")); } }


public IList<IWebElement> OrderStatus { get { return WebDriver.GetElements(By.XPath("//*[contains(@id,'orderDetails_AllOrderHeader_orderStatus_')]")); } }


public IWebElement OEP_iFrame { get { return WebDriver.GetElement(By.XPath("//oeptimelinemodalpopup/div/div/iframe")); } }


public IWebElement OEP_OrderNumber { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'ORDER -')]")); } }


public IWebElement OEP_CloseWindow { get { return WebDriver.GetElement(By.XPath("//div[@class='modal-close']/button")); } }


public IWebElement OrderProcessiongStatus { get { return WebDriver.GetElement(By.XPath(".//*[contains(@id,'orderDetails_AllOrderHeader_orderOmsStatus_0')]")); } }

public IWebElement LnkViewDell { get { return WebDriver.GetElement(By.LinkText("View in Dell.com")); } }


public IWebElement LnkEditEndUser { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_endUserNumber']//a")); } }

public IWebElement CreatedByLink { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_createdBy']//a")); } }

public IWebElement UndoEdit { get { return WebDriver.GetElement(By.Id("orderDetails_undoEdit")); } }

public IWebElement LnkRebook { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='rebook']")); } }

public IWebElement LnkCustomerToggle { get { return WebDriver.GetElement(By.Id("orderDetails_customerInformationToggle")); } }

public IWebElement LblCompanyNumber { get { return WebDriver.GetElement(By.Id("orderDetails_companyNumber")); } }

public IWebElement LnkViewMoreLess { get { return WebDriver.GetElement(By.Id("toggleMoreLess__")); } }


public IWebElement LnkPickDifferentAddress { get { return WebDriver.GetElement(By.Id("orderDetails_LI_SI_shippingPickAddressLink_1")); } }


public IWebElement LnkStandardAddress { get { return WebDriver.GetElement(By.Id("AddressSelectDialog_address-grid_tab_standard")); } }


public IWebElement AddressesTable { get { return WebDriver.GetElement(By.XPath("//*[@id='AddressSelectDialog_address-grid']")); } }

public IWebElement EditPONumber { get { return WebDriver.GetElement(By.Id("orderDetails_editPoNumber")); } }


public IWebElement TxtPONumber { get { return WebDriver.GetElement(By.Id("orderDetails_edit_po_number")); } }

public IWebElement LnkSalesRepEdit { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_salesRep']/a")); } }


public IWebElement LblSalesRepId { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_salesRep']/span")); } }


public IWebElement LblInvalidSalesRep { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_salesRep']/span")); } }


public IWebElement TxtSalesRepId { get { return WebDriver.GetElement(By.Id("orderDetails_edit_salesRep_number")); } }


public IWebElement LnkEndUserEdit { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_endUserNumber']/a")); } }


public IWebElement TxtEnduser { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_endUserNumber']//input")); } }


public IWebElement TxtMABD { get { return WebDriver.GetElement(By.Id("orderDetails_mabd_startDate")); } }


public IWebElement calMABD { get { return WebDriver.GetElement(By.XPath("//*[@class='k-icon k-i-calendar']")); } }

public IWebElement calnextMonth { get { return WebDriver.GetElement(By.XPath("(//*[@id='orderDetails_mabd_startDate']//daypicker//button)[3]")); } }


public IWebElement calDay { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'datepicker--')]//button/span[text()='15']")); } }


public IWebElement LnkClosePOM { get { return WebDriver.GetElement(By.Id("orderDetails_gmir")); } }

public IWebElement OrderPOMid { get { return WebDriver.GetElement(By.XPath("//close-pom-id//label[@id='pom_id']")); } }

public IWebElement CloseConfirmation { get { return WebDriver.GetElement(By.XPath("//close-pom-id//h3[@id='H1']")); } }

public IWebElement POMCloseYes { get { return WebDriver.GetElement(By.XPath("//button[@id='pomid_close']")); } }

public IWebElement POMCloseNo { get { return WebDriver.GetElement(By.XPath("//button[@id='pomid_cancel']")); } }

public IWebElement POMClose { get { return WebDriver.GetElement(By.XPath("//button[@name='close']")); } }

public IWebElement SuccessMsg { get { return WebDriver.GetElement(By.XPath("//div[@id='orderDetails_gimrMessage']/div")); } }

public IWebElement LnkGotoMyQueue { get { return WebDriver.GetElement(By.XPath("//div[@id='orderDetails_gimrMessage']/div/a")); } }


public IWebElement LblEndUserCustomer { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_endUserNumber']//span")); } }



public IWebElement EUBusinessUnitValidationMsg { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_endUserNumber']//span[contains(text(),'End User Customer Number not valid for this business unit.')]")); } }


public IWebElement EUBilltoCustomerValidationMsg { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_endUserNumber']//span[contains(text(),'Please ensure that end user customer number is not same as customer number.')]")); } }

public IWebElement LnkProformaInvoice { get { return WebDriver.GetElement(By.Id("orderDetails_proformaInvoice")); } }

public IWebElement LnkCreateInvoiceOrder { get { return WebDriver.GetElement(By.Id("orderDetails_createInvoiceOrder")); } }


        public IWebElement GetOrderTypeFromSingleOrder { get { return WebDriver.GetElement(By.XPath("//*[contains(@id, 'orderDetails_AllOrderHeader_orderType')]/../div")); } }


        public IWebElement LblOriginalOrderNumber { get { return WebDriver.GetElement(By.Id("orderDetails_oringialOrderNumber")); } }

public IWebElement LblReasonCode { get { return WebDriver.GetElement(By.Id("orderDetails_exchangeReasonCode")); } }

public IWebElement LblDpsNumber { get { return WebDriver.GetElement(By.Id("orderDetails_dpsNumber")); } }

        //[FindsBy(How = How.XPath, Using = "//*[@id='orderDetails_header']//div[contains(@data-ng-if,'hold')]//table")]
public IWebElement TblOrderHolds { get { return WebDriver.GetElement(By.XPath("//*[@class='table releaseHold']")); } }

public IWebElement TblOrderHolds1 { get { return WebDriver.GetElement(By.XPath("//*[@id='main']//order-details-hold/table/tbody/tr/td[1]/span")); } }



public IWebElement ChkOverrideProductValidationHold { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Release Product')]/..//input")); } }

        //[FindsBy(How = How.XPath, Using = "(//*[@id='NG2_UPGRADE_66_0']//td)[1]")]
public IWebElement TblHoldType { get { return WebDriver.GetElement(By.XPath("//*[@class='table releaseHold']")); } }

public IWebElement TblHoldType2 { get { return WebDriver.GetElement(By.XPath("(//*[@id='NG2_UPGRADE_66_0']//td)[4]")); } }


public IWebElement LblOrderDetailsSummaryLevelDfsRevenuePrice { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_GI_revenue_Incentive_']")); } }

        //// [FindsBy(How = How.XPath, Using = "//*[@id='_btn_ok']")]
        //[FindsBy(How = How.XPath, Using = "//button[normalize-space()='Continue']")]
        //public IWebElement BtnUpdateOrderContinue;
        public IWebElement BtnUpdateOrderContinue { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='Continue']")); } }

public IWebElement DPID { get { return WebDriver.GetElement(By.Id("copyId")); } }


public IList<IWebElement> OrderNumbers { get { return WebDriver.GetElements(By.XPath("//*[contains(@id,'orderDetails_order_header')]/h3")); } }

        
        public IWebElement ImgValidatingQuoteBusyIndicator { get { return WebDriver.GetElement(By.CssSelector(@"#quoteDetail_header > div > div.section-header.pd-btm-5 > div.col-md-12.table-column-centered.mg-btm-10.mg-top-10.ng-scope > p > span > img")); } }


        //[FindsBy(How = How.XPath,
          //  Using = "//*[@id='orderDetails_summary']//span[contains(text(),'Final Price')]/following-sibling::span")]

public IWebElement LblOrderDetailsPageFinalPrice { get { return WebDriver.GetElement(By.XPath("//*[contains(@class,'col-md-6 financial final-price')]")); } }


public IWebElement LblSourceApplicationName { get { return WebDriver.GetElement(By.Id("orderDetails_sourceApplicationName")); } }


public IWebElement LblModifiedByApplication { get { return WebDriver.GetElement(By.Id("orderDetails_modifiedByApplicationName")); } }


public IWebElement LblIsGovernmentCard { get { return WebDriver.GetElement(By.Id("orderDetails_payment_information_creditCard1_governmentcard")); } }

        //[FindsBy(How = How.XPath, Using = "//*[@id='orderDetails_summary_compRevenue']")]

public IWebElement LblSummaryLevelSmartPriceRevenue { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_GI_smartPrice_Revenue_']")); } }


public IWebElement TxtEmailSendTo { get { return WebDriver.GetElement(By.XPath("//*[contains(@class, 'send-cfo-email-textarea')]")); } }

public IWebElement BtnCustEmailsSend { get { return WebDriver.GetElement(By.Id("QuoteOrderConfirmation_next")); } }


public IWebElement BtnCustEmailCancel { get { return WebDriver.GetElement(By.XPath("//button[contains(text(), 'Cancel')]")); } }


public IWebElement OrderDetailsSrcApplication { get { return WebDriver.GetElement(By.Id("orderDetails_sourceApplicationName")); } }


public IWebElement OrderDetailsModifiedByApplication { get { return WebDriver.GetElement(By.Id("orderDetails_modifiedByApplicationName")); } }

public IWebElement LblMABD { get { return WebDriver.GetElement(By.Id("orderDetails_LI_SI_arriveByDate_2")); } }


public IWebElement LblSalesRepoInfoTog_SalesRepId { get { return WebDriver.GetElement(By.XPath("((//*[@id='orderDetails_salesRep'])[2]//span)[1]")); } }

public IWebElement cldMABSelect { get { return WebDriver.GetElement(By.XPath("//span[text()='select']")); } }

public IWebElement lnkNavNext { get { return WebDriver.GetElement(By.XPath("//a[@class='k-link k-nav-next']")); } }


public IWebElement PaymentInfoSectionArrow { get { return WebDriver.GetElement(By.Id("orderDetails_payment_information_Toggle")); } }

public IWebElement lnkDate { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='18']")); } }

        //[FindsBy(How = How.XPath, Using = ".//*[@id='orderDetails_header']/descendant::h2[@class='app-title']")]
        //public IWebElement OrderDetailsHeader;


public IWebElement OrderDetailsHeader { get { return WebDriver.GetElement(By.XPath("//order-page-title/div/div[1]/h2")); } }

public IWebElement LnkApproveHold { get { return WebDriver.GetElement(By.Id("_approveHold")); } }

public IWebElement LnkDeclineHold { get { return WebDriver.GetElement(By.Id("_declineHold")); } }

public IWebElement OrderCFOSection { get { return WebDriver.GetElement(By.Id("orderCfo_orderCfoHeading")); } }

        //Order Tracking
public IWebElement CarrierCode { get { return WebDriver.GetElement(By.Id("order_index-0_tracking_carrier_value")); } }

public IWebElement TrackingNumbers { get { return WebDriver.GetElement(By.Id("order_index-0_tracking_numbers_value")); } }

public IWebElement TrackingUnavailable { get { return WebDriver.GetElement(By.Id("order_index-0_tracking_error_unavailable")); } }


public IList<IWebElement> ItemsCollapse { get { return WebDriver.GetElements(By.XPath("//*[@class='line-item-hdr order-line-item ccpHeaderCollapsed']")); } }


public IList<IWebElement> ItemsExpand { get { return WebDriver.GetElements(By.XPath("//*[@class='line-item-hdr order-line-item ccpHeaderExpanded']")); } }


public IWebElement ExpandAllbtn { get { return WebDriver.GetElement(By.XPath("//a[@class='grid-btn' and contains(text(), 'Expand All')]")); } }


public IWebElement ViewDuplicateOrdersLnk { get { return WebDriver.GetElement(By.XPath("//a[@id='_holdtype']")); } }





        //[FindsBy(How = How.XPath, Using = "//a[@id='orderDetails_relatedOrders_link']")]
        //public IWebElement ViewRelatedOrdersLnk;



public IWebElement SoldToCustInDupOrdersDialog { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'Sold To Customer Number')]")); } }


public IWebElement PONumberInDupOrdersDialog { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'PO Number')]")); } }


public IWebElement ItemQntyDupOrdersDialog { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'Item Quantity')]")); } }


public IWebElement OrderTotalInDupOrdersDialog { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'Order Total')]")); } }


public IWebElement ShipToAddLn1InDupOrdersDialog { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'Ship to Street Address Line1')]")); } }


public IWebElement HeaderDPID { get { return WebDriver.GetElement(By.XPath("//div[@class='col-md-12 text-center']/h4/a")); } }


public IWebElement DupDPIDListitem { get { return WebDriver.GetElement(By.XPath("//a[@placement='top']")); } }


public IWebElement DupDPIDDisclaimer { get { return WebDriver.GetElement(By.XPath("//p[@class='mg-btm-40 text-small']")); } }


public IWebElement DupDPIDWindowClose { get { return WebDriver.GetElement(By.XPath("//a[@id='duplicateOrder_close']/span[@class='icon-ui-close']")); } }


public IWebElement ViewRelatedOrdersLnk { get { return WebDriver.GetElement(By.Id("orderDetails_relatedOrders_link")); } }


public IWebElement OrderInfoOnExpansion { get { return WebDriver.GetElement(By.XPath("//div[@class='custom-expanded ccpBody']//div[@class='body']")); } }


public IList<IWebElement> OrderInfoElementsExpander { get { return WebDriver.GetElements(By.XPath("//div[@class='ccpHeaderCollapsed']//div[@class='col-sm-offset-6 col-sm-2']")); } }


public IList<IWebElement> ContainerElementsInDialog { get { return WebDriver.GetElements(By.XPath("//div[@class='container show-grid']")); } }


public IWebElement RebookedRelatedOrder { get { return WebDriver.GetElement(By.XPath("//div[@class='c-data-grid']//div[@class='col-sm-2']/a")); } }



public IWebElement NoRelatedOrdersMessage { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'There are no related orders available!')]")); } }

        //[FindsBy(How = How.XPath, Using = "//span[@class='icon-ui-close']")]

public IWebElement RelDPIDWindowClose { get { return WebDriver.GetElement(By.XPath("//a[@aria-label='Close Modal']")); } }


public IWebElement ManuallyLinkedDPID { get { return WebDriver.GetElement(By.XPath("//input[@placeholder='Enter DPID from canceled order']")); } }

public IWebElement OrderStatusOfRelOrder { get { return WebDriver.GetElement(By.ClassName("col-sm-offset-2 col-sm-2")); } }

public IWebElement OrderStatusOfRelOrderLabel { get { return WebDriver.GetElement(By.XPath("(//div[@class = 'ccpHeaderExpanded']/div[@class = 'col-sm-2'])[1]")); } }


public IWebElement DescriptionOfRelOrder { get { return WebDriver.GetElement(By.ClassName("col-sm-4 ellipsis_text")); } }

        //[FindsBy(How = How.XPath, Using = "//div[@class='c-data-grid-overflow']")]
        //public IWebElement RelatedOrderswithScrollBar;

public IWebElement FinalPriceOfRelOrder { get { return WebDriver.GetElement(By.ClassName("col-sm-2")); } }

public IWebElement BtnCopyOrder { get { return WebDriver.GetElement(By.XPath("//a[@class='grid-btn pull-right']")); } }

        //[FindsBy(How = How.Id, Using = "orderDetails_LI_productRsId")]
        //public IWebElement LblFulfillmentLevelRSid;

        //div[@class='row even']//div[@class='ccpHeaderExpanded']//div[@class='col-sm-2']

public IWebElement LnkPOMID { get { return WebDriver.GetElement(By.XPath("//div[@id='orderDetails_pomId']/span/a")); } }


public IWebElement BlankPOMID { get { return WebDriver.GetElement(By.XPath("//div[@id='orderDetails_pomId_label']/div/span")); } }


public IWebElement LnkPOM { get { return WebDriver.GetElement(By.XPath("//div[@id='salesRepHelpLinks']/a[4]")); } }


public IList<IWebElement> ItemsList { get { return WebDriver.GetElements(By.XPath("//a[@class='grid-btn' and contains(text(), 'Expand All')]")); } }


public IWebElement DPSNumber { get { return WebDriver.GetElement(By.Id("orderDetails_dpsNumber")); } }



public IWebElement FunderNameOnBillToCustomer { get { return WebDriver.GetElement(By.XPath("//customer-information//div/div/div//div")); } }


public IWebElement FunderNameOnBillToAddress { get { return WebDriver.GetElement(By.XPath("//order-details-address//div[@class='address-block pd-top-10']//div[1]")); } }


public IWebElement BillToAddressHeader { get { return WebDriver.GetElement(By.XPath("//order-details-address//div[@class='ccpHeaderCollapsed']")); } }



public IList<IWebElement> RelatedOrdersList { get { return WebDriver.GetElements(By.XPath("//div[@class='ccpHeaderCollapsed']//div[@class='col-sm-2']")); } }



public IWebElement GoalLiteDealIdLabel { get { return WebDriver.GetElement(By.Id("orderDetails_goalLiteId_label")); } }


public IWebElement GoalLiteDealIdValue { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_goalLiteId_value']/label")); } }


public IWebElement CFOMailsList { get { return WebDriver.GetElement(By.XPath("//table[@class='table']")); } }


public IWebElement POnumbers { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_poNumber']")); } }


public IWebElement BillToCustInfo { get { return WebDriver.GetElement(By.XPath("//bill-to-customer-information//div[@class='ccpHeaderCollapsed']")); } }


public IWebElement PrefLanguage { get { return WebDriver.GetElement(By.Id("orderDetails_billToPreferredLang")); } }


public IWebElement createCustomerHearder { get { return WebDriver.GetElement(By.Id("currentCustomer_createCustomerHeaderLink2")); } }


public IWebElement MoreDetails { get { return WebDriver.GetElement(By.XPath("//a[contains(text(), 'More Details')]")); } }


public IWebElement MoreDetailsOk { get { return WebDriver.GetElement(By.XPath("//button[@class='btn btn-success']")); } }


public IWebElement CCValue1 { get { return WebDriver.GetElement(By.XPath("(//label[contains(text(), 'CC Number:')])[1]/following-sibling::div")); } }


public IWebElement CCValue2 { get { return WebDriver.GetElement(By.XPath("(//label[contains(text(), 'CC Number:')])[2]/following-sibling::div")); } }


public IWebElement CancellationNotification { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-warning']//p")); } }


public IWebElement PaymentInformation { get { return WebDriver.GetElement(By.Id("orderDetails_payment_information_Toggle")); } }


public IWebElement PaymentInformationHeader { get { return WebDriver.GetElement(By.Id("orderDetails_payment_information_Heading")); } }


public IWebElement RefreshOrderLnk { get { return WebDriver.GetElement(By.Id("orderDetails_refreshOrder")); } }

        // [FindsBy(How = How.XPath, Using = "//a[@target='_blank' and contains(@href,'#/order/details/dpid/')]")]
        // public IWebElement Ordersearchresultcolumn;

        //[FindsBy(How = How.XPath, Using = "//div[@class='c-data-grid-overflow']")]
        //public IWebElement RelatedOrderswithScrollBar;
        public By ViewDuplicateOrdersDialog
        {
            get { return By.ClassName("cdk-overlay-pane"); }
        }
        //public By ViewRelatedOrdersDialog
        //{
        //    get { return By.ClassName("modal-wrap goal-deal-select-modal"); }
        //}

        public IWebElement RebookedRelatedOrderStatus(string orderNum)
        {
            var xpath = string.Format("//a[contains(text(),'Order {0}')]/following::div[1]", orderNum);
            return WebDriver.FindElement(By.XPath(xpath));
        }

        public IWebElement RebookedRelatedOrderinDPID(string orderNum)
        {
            var xpath = string.Format("//a[contains(text(),'Order {0}')]", orderNum);
            return WebDriver.FindElement(By.XPath(xpath));
        }

        public IWebElement RebookedRelatedOrderinDPIDExpand(string orderNum)
        {
            var xpath = string.Format("//a[contains(text(),'Order {0}')]/preceding::div[@aria-label='View More Button'][1]", orderNum);
            return WebDriver.FindElement(By.XPath(xpath));
        }

        public By RelatedOrderswithScrollBar
        {
            get { return By.ClassName("c-data-grid-overflow"); }
        }

        public By ViewRelatedOrdersDialog
        {
            get { return By.XPath("//div[@class = 'modal-body contract-model-body related-dpid-order']"); }
        }

        public IWebElement LblFulfillmentLevelRSid(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id("displayMode_LI_productRsId__" + (lineItemIndex - 1)));
        }

        public bool VerifyIfRebookedRelatedOrderExists()
        {
            try
            {
                WebDriverUtil.WaitForElementDisplay(WebDriver, By.XPath("//div[@class='c-data-grid']//div[@class='col-sm-2']/a"), TimeSpan.FromSeconds(5));
                WebDriver.FindElement(By.XPath("//div[@class='c-data-grid']//div[@class='col-sm-2']/a"));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool VerifyIfCopiedRelatedOrderExists()
        {
            try
            {
                WebDriverUtil.WaitForElementDisplay(WebDriver, WebDriver.FindElement(By.XPath("//div[@class='c-data-grid']//div[@class='col-sm-2']/a"), TimeSpan.FromSeconds(5)));
                WebDriver.FindElement(By.XPath("//div[@class='c-data-grid']//div[@class='col-sm-2']/a"));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IList<IWebElement> DpidRelatedOrders
        {
            get { return WebDriver.FindElements(By.XPath("//div[@class='ccpBody custom-expanded']//div[@class='body']")); }

        }

        public bool IsDPidExpandedForRelatedOrders()
        {
            try
            {
                WebDriver.FindElement(By.XPath("//div[@class='ccpBody custom-expanded']"));
                return true;
            }
            catch
            {
                return false;
            }
            //div[@class='ccpBody custom-expanded']
        }


        public IWebElement TxtInstallationInstruction
        {
            get { return WebDriver.GetElement(By.CssSelector("textarea#" + PagePrefix + "_installationinstructions")); }
        }


public IWebElement AddressExpandLink { get { return WebDriver.GetElement(By.XPath("//h2[contains(text(), 'Addresses')]")); } }


public IWebElement AddressBlock1 { get { return WebDriver.GetElement(By.XPath("(//div[@class = 'address-block pd-top-10'])[1]")); } }


public IWebElement AddressBlock2 { get { return WebDriver.GetElement(By.XPath("(//div[@class = 'address-block pd-top-10'])[2]")); } }


public IWebElement groupAddress1 { get { return WebDriver.GetElement(By.XPath("(//div[@class = 'address-block pd-top-10'])[3]")); } }


public IWebElement groupAddress2 { get { return WebDriver.GetElement(By.XPath("(//div[@class = 'address-block pd-top-10'])[4]")); } }
        #endregion

        public string GetSnowRequestID()
        {
            return WebDriver.FindElement(By.Id("orderDetails_fld_snow_request_id"), TimeSpan.FromSeconds(5)).GetText(WebDriver);
        }

        public string GetLeBuCc()
        {
            return WebDriver.FindElement(By.XPath("//div[@id='orderDetails_fld_lebUcc_id']/label"), TimeSpan.FromSeconds(5)).GetText(WebDriver);
        }

        public IWebElement GetCustomPriceNotification(string text)
        {
            return WebDriver.FindElement(
                By.XPath("//*[@id='orderDetails_quote_Validation']//p[contains(normalize-space(),'" + text + "')]"));
        }

        public IWebElement VerifyListofPayments(int shippingGroupIndex = 1)
        {
            return WebDriver.GetElements(By.XPath("(//*[contains(@id,'_paymentmethod')])"))[shippingGroupIndex - 1];
        }

        public IWebElement VerifyListofAmount(int shippingGroupIndex = 1)
        {

            return WebDriver.GetElements(By.XPath("(//*[contains(@id,'_amount')])"))[shippingGroupIndex - 1];
        }

        public IWebElement VerifyListofPaymentType(int shippingGroupIndex = 1)
        {
            return WebDriver.GetElements(By.XPath("(//*[contains(@id,'_paymentType')])"))[shippingGroupIndex - 1];
        }

        public IWebElement VerifyHoldType(int index = 1)
        {

            return WebDriver.GetElement(By.XPath("(//*[@id='NG2_UPGRADE_66_0']//td)[" + index + "]"));
        }

        public IWebElement GetFullFilmentUnit(int fulfilindex = 1)
        {

            return WebDriver.GetElement(
                By.XPath("(//*[contains(@id,'orderDetails_order_header')])[" + fulfilindex + "]"));
        }

        public IWebElement GetFUOrderProcessingStatus(int fulfilindex = 1)
        {

            return WebDriver.GetElement(By.XPath("(//*[contains(@id,'orderDetails_AllOrderHeader_orderOmsStatus')])[" + fulfilindex + "]"));
        }

        public IWebElement InstallAtAddressInfo(int? InstallAtIndex)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='orderDetails_LI_SI_installataddressInformation_0']/div"));
        }
        public IWebElement ItemProductDescriptionOrderDetails(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_productDescription_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
        }

        public IWebElement DTCPSummaryDiscountPercentOrderDetails()
        {
            return WebDriver.GetElement(By.Id("orderDetails_summary_discountPercent"));
        }

        public bool DTCPVerifyDiscountOrderDetails(string discountPercent)
        {
            string SummarydiscPert = DTCPSummaryDiscountPercentOrderDetails().GetText(WebDriver);
            if (SummarydiscPert.Contains(discountPercent))
                return true;
            else
                return false;
        }

public IWebElement OrderCommentsToggle { get { return WebDriver.GetElement(By.Id("_orderCommentsToggle")); } }

public IWebElement txtOrderComments { get { return WebDriver.GetElement(By.Id("order_comments")); } }


public IWebElement btnAddComment { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='Add Comment']")); } }


public IWebElement btnLoadAllComments { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='Load All']")); } }


public IWebElement OrderNumberField { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_order_header_0']/h3")); } }


public IWebElement OrderNumberField1 { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_order_header_1']/h3")); } }


public IWebElement topassemplylevel { get { return WebDriver.GetElement(By.XPath("//*[@id='orderReview_accordion_0_0']/div[2]/div/div/div[2]/div[4]/div[3]/order-item-tla-info/div/div[1]/p")); } }


public IWebElement topassemplylevelvalue { get { return WebDriver.GetElement(By.Id("orderReview_LI_info_tla_0_0")); } }


public IWebElement OrderCancelRequestHistory { get { return WebDriver.GetElement(By.Id("orderCancelReject_history_heading")); } }


public IWebElement CancelOrderRequestReceivedPanel { get { return WebDriver.GetElement(By.XPath("//div[@id = 'orderCancelRejectView']//div[@class = 'accordion-inner-transparent']//label")); } }


public IWebElement CancelOrderRequestReceived { get { return WebDriver.GetElement(By.XPath("//label[contains(text(), 'CancelOrder request received.')]")); } }


public IWebElement CancelOrderRequestProcessed { get { return WebDriver.GetElement(By.Id("orderDetails_quote_Validation")); } }


public IWebElement CancelOrderSucessfull { get { return WebDriver.GetElement(By.XPath("//cancel-request-history//div[@id='orderCancelRejectView']//div[@id='orderCancelHistoryView_0']//div[text()='Status :']/parent::div//div[text()='Cancelled']")); } }


public IWebElement ProductTotalAmount { get { return WebDriver.GetElement(By.XPath("//div[contains(@class, 'text-right mg-btm-10 content-bold')]")); } }


public IWebElement ProductDescription { get { return WebDriver.GetElement(By.XPath("//span[contains(@id, 'orderDetails_LI_productDescription__0')]")); } }


public IWebElement UnitListPrice { get { return WebDriver.GetElement(By.XPath("//div[@id = 'orderDetails_LI_PI_unitPrice__0']")); } }


public IWebElement FinalPrice { get { return WebDriver.GetElement(By.XPath("(//span[@id = 'orderDetails_summary_finalPrice'])[1]")); } }


public IWebElement ShiptoAddressinorder { get { return WebDriver.GetElement(By.XPath("(//span[contains(text(), 'Ship to Address')]/following::div)[1]")); } }


public IWebElement UCIDRequestShippingAddress { get { return WebDriver.GetElement(By.CssSelector("#orderDetails_LI_SI_addressInformation_0 .address-block")); } }


public IWebElement SoldtoCustomerno { get { return WebDriver.GetElement(By.XPath("(//p[contains(text(), ' Sold to Customer ')]/following::div)[1]")); } }


public IWebElement LnkEditFunder { get { return WebDriver.GetElement(By.XPath("//a[text()='Edit Funder']")); } }


public IWebElement LstFundersList { get { return WebDriver.GetElement(By.Id("chooseFunder_FunderList")); } }


public IWebElement BtnFundersSelectOk { get { return WebDriver.GetElement(By.XPath("//button[text()='Ok']")); } }


public IWebElement FlexBillingInfoLabel { get { return WebDriver.GetElement(By.XPath("//p[contains(text(), 'Flex Billing Information')]")); } }


public IWebElement SelectedCadence { get { return WebDriver.GetElement(By.XPath("//apos-flex-billing-pricing-information/div/div[1]/div")); } }


public IWebElement UpfrontAmount { get { return WebDriver.GetElement(By.XPath("//apos-flex-billing-pricing-information/div/div[2]/div")); } }


public IWebElement MonthlyAmount { get { return WebDriver.GetElement(By.XPath("//apos-flex-billing-pricing-information/div/div[3]/div")); } }


public IWebElement TotalContractValue { get { return WebDriver.GetElement(By.XPath("//apos-flex-billing-pricing-information/div/div[4]/div")); } }


public IWebElement GPID { get { return WebDriver.GetElement(By.XPath("//td[contains(text(), 'GP ID')]")); } }


public IWebElement HedgeRateValue { get { return WebDriver.GetElement(By.Id("orderDetails_hedgeRate")); } }


public IWebElement LanguageCode { get { return WebDriver.GetElement(By.Id("orderDetails_orderLanguage")); } }

        #region ItemElements

        public IWebElement GetExpandAllButton(IWebElement parenEle)
        {
            return WebDriver.FindElements(By.XPath("//a[@class='grid-btn' and contains(text(), 'Expand All')]"))
                .First(x => x.Displayed == true);
        }

        public IWebElement ExpandLineItem(int lineItemIndex = 1)

        {
            //return WebDriver.GetElements(By.XPath("//span[contains(@id,'_LI_lineNumber__')]"))[lineItemIndex];
            //return WebDriver.GetElement(By.Id(PagePrefix + "_LI_" + "lineNumber__" + (lineItemIndex - 1)));
            return WebDriver.GetElement(By.XPath("(//span[contains(@id,'_LI_lineNumber__')])[" + lineItemIndex + "]"));
        }

        public IWebElement LblItemLevelUnitListPrice(int lineItemIndex = 1)
        {
            return WebDriver.GetElements(By.Id(PagePrefix + "_LI_PI_unitPrice_" + "_" + (lineItemIndex - 1)))[0];
        }

        public IWebElement LblItemLevelUnitCost(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath(PagePrefix + "_LI_PI_unitCost_" + "_" + (lineItemIndex - 1)));
        }

        public IWebElement LblItemLevelUnitDiscount(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_PI_dol_" + "_" + (lineItemIndex - 1)));
        }

        public IWebElement LblItemLevelUnitSellingPrice(int lineItemIndex = 1)
        {
            //return WebDriver.GetElements(By.XPath("//span[contains(@id,'_LI_lineNumber__')]n"))[lineItemIndex - 1];
            return WebDriver.GetElement(By.Id("_LI_PI_unitSellingPrice_" + "_" + (lineItemIndex - 1)));
        }


        public IWebElement LblItemLevelUnitMargin(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_PI_unitMargin_" + "_" + (lineItemIndex - 1)));
        }

        public IWebElement LblItemLevelContractDiscount(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_PI_unitPercent_" + lineItemIndex));
        }

        public IWebElement LblItemLevelPromotions(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_PI_promotionPercent_" + "_" + (lineItemIndex - 1)));
        }

        public IWebElement LblItemLevelDiscountOffList(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//div[contains(@id,'orderDetails_LI_PI_promotionPercent__" + (lineItemIndex - 1) + "')]/../following-sibling::div[1]//div"));
        }

        public IWebElement LblItemLevelQuantity(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_quantity_" + "_" + (lineItemIndex - 1)));
        }

        public IWebElement LblItemLevelTotalListPrice(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_totalListPrice_" + "_" + (lineItemIndex - 1)));
        }

        public IWebElement LblItemLevelTotalCostPrice(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_cost_" + "_" + (lineItemIndex - 1)));
        }

        public IWebElement LblItemLevelTotalDiscount(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_totalDiscountPercent_" + "_" + (lineItemIndex - 1)));
        }

        public IWebElement LblItemLevelTotalSellingPrice(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_PI_unitSellingPrice_" + "_" + (lineItemIndex - 1)));
        }

        public IWebElement LblItemLevelMargin(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_margin_" + "_" + (lineItemIndex - 1)));
        }

        public IWebElement LblContractCode(int lineItemIndex = 1)
        {
            return
                WebDriver.GetElement(By.Id(PagePrefix + "_LI_contractCode_" +
                                           lineItemIndex)); //.FindElements(By.Id(PagePrefix + "_LI_contractCode_" + lineItemIndex))[0];
        }


        public IWebElement LnkItemDesc(int lineItemIndex = 1)
        {
            return WebDriver.GetElements(By.XPath("//*[contains(@id, 'displayMode_LI_lineNumber__')]"))[
                lineItemIndex - 1];

            // return WebDriver.GetElements(By.XPath("(//*@id='orderDetails_LI_lineNumber__0')"))[1];

            //(//*[@id='orderDetails_LI_lineNumber__0'])[1]
            // return WebDriver.GetElements(By.XPath("(//*[contains(@id, 'orderDetails_LI_lineNumber__0')]"))[1];
        }


public IWebElement TxtRdd { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_LI_SI_revisedDeliveryDate_1']/span")); } }

        //[FindsBy(How = How.XPath, Using = "//*[@id='orderDetails_order_header_']/div[3]/div[1]/div[5]/div")]
        //public IWebElement TxtInvoiceNumber;

public IWebElement TxtInvoiceNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_order_header_0']/div/div[1]/order-header-status/div[5]/div")); } }

public IWebElement LnkInvoiceNumber { get { return WebDriver.GetElement(By.Id("orderDetails_InvoiceNo")); } }


public IWebElement EnterMABD { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_mabd_startDate']/div/div/span/span/input")); } }

        #endregion

        #region Solutionelements


public IWebElement HoldType { get { return WebDriver.GetElement(By.XPath("//div[contains(@data-ng-if,'vieworderholds()')]/table//td[1]")); } }


public IWebElement CFIProjectStatus { get { return WebDriver.GetElement(By.XPath("//div[contains(@data-ng-if,'vieworderholds()')]/table//td[2]")); } }

        By FirstArticleCheckBox = By.Id("orderDetails_modifyOrder_firstArticle");

        By FirstArticleCheckboxLabel =
            By.XPath("//label[text()='First Article - Check box and select Save Order to release order']");

        By HoldTypeBy = By.XPath("//div[contains(@data-ng-if,'vieworderholds()')]/table//td[1]");


public IWebElement OrderRejectStatus { get { return WebDriver.GetElement(By.XPath("//*[@ng-reflect-status-code='REJ' and @ng-reflect-status-display-text='Rejected (REJ)']")); } }


public IWebElement OrderRejectStatusLink { get { return WebDriver.GetElement(By.XPath("//a[contains(text(),'Rejected (REJ)')]")); } }


public IWebElement RejectReasonBtnOk { get { return WebDriver.GetElement(By.XPath("//button[@class='btn btn-success']")); } }


public IWebElement RejectReason { get { return WebDriver.GetElement(By.XPath("//*[@class='orderRejectReason']")); } }
        //*[text()='137698 | Is Ready Stock Order or not ; :137698 | Is Ready Stock Order or not ;']
        #endregion

        //#region ItemSummaryElements
        //public IWebElement LblItemSummarySellingPrice(int lineItemIndex = 1, int groupIndex = 1)
        //{
        //    return WebDriver.GetElement(By.Id(PagePrefix + "_LI_pricingTotals_sellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
        //}

        //public IWebElement LblItemSummaryTax(int lineItemIndex = 1, int groupIndex = 1)
        //{
        //    return WebDriver.GetElement(By.Id(PagePrefix + "_LI_tax_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
        //}

        //public IWebElement LblItemSummaryEcoFee(int lineItemIndex = 1, int groupIndex = 1)
        //{
        //    return WebDriver.GetElement(By.Id(PagePrefix + "_LI_ecoFee_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
        //}

        //public IWebElement LblItemSummaryTotalAmount(int lineItemIndex = 1, int groupIndex = 1)
        //{
        //    return WebDriver.GetElement(By.Id(PagePrefix + "_LI_totalAmount_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
        //}

        //#endregion

        //#region GroupSummaryElements
        //public IWebElement LblGroupSummarySubTotal(int groupIndex = 1)
        //{
        //    return WebDriver.GetElement(By.Id(PagePrefix + "_GI_sellingPrice_" + (groupIndex - 1)));
        //}

        //public IWebElement LblGroupSummaryShippingAmount(int groupIndex = 1)
        //{
        //    return WebDriver.GetElement(By.Id(PagePrefix + "_GI_totalShippingAmount_" + (groupIndex - 1)));
        //}

        //public IWebElement LblGroupSummaryTax(int groupIndex = 1)
        //{
        //    return WebDriver.GetElement(By.Id(PagePrefix + "_GI_tax_" + (groupIndex - 1)));
        //}

        //public IWebElement LblGroupSummaryEcoFee(int groupIndex = 1)
        //{
        //    return WebDriver.GetElement(By.Id(PagePrefix + "_GI_ecoFee_" + (groupIndex - 1)));
        //}

        //public IWebElement LblGroupSummaryTotalAmount(int groupIndex = 1)
        //{
        //    return WebDriver.GetElement(By.Id(PagePrefix + "_GI_totalAmount_" + (groupIndex - 1)));
        //}

        //#endregion

        #region Auotopilot order page elements
        public IList<IWebElement> TxtTenantIdinOrderdetails()
        {
            return WebDriver.GetElements(By.XPath(string.Format("//*[contains(@id,'orderDetails_LI_AutoPilot_TenantIdValue__')]")), TimeSpan.FromSeconds(3));
        }

        public IList<IWebElement> TxtDomainOrderdetails()
        {
            return WebDriver.GetElements(By.XPath(string.Format("//*[contains(@id,'orderDetails_LI_AutoPilot_DomainValue__')]")), TimeSpan.FromSeconds(3));
        }
        public IList<IWebElement> AutopilotsectioninOrder()
        {
            return WebDriver.GetElements(By.Id(string.Format("orderDetails__0")), TimeSpan.FromSeconds(6));
            //*[@id="orderDetails__0"]
        }
        //[FindsBy(How = How.XPath, Using = "//*[contains(@id,'orderDetails_LI_AutoPilot_DomainValue__')]")]
        //public IList<IWebElement> TxtDomainOrderdetails;


        //[FindsBy(How = How.XPath, Using = "//*[contains(@id,'orderDetails_LI_AutoPilot_TenantIdValue__')]")]
        //public IList<IWebElement> TxtTenantIdinOrderdetails;



public IList<IWebElement> ExpandItemsinDPID { get { return WebDriver.GetElements(By.XPath("//*[contains(@id,'orderDetails_LI_lineNumber__')]")); } }



public IList<IWebElement> AutoPilotItemsinDpid { get { return WebDriver.GetElements(By.XPath("//*[contains(@id,'orderDetails__') and contains(text(),'Windows Autopilot')]")); } }



public IWebElement ItemsinOderspage { get { return WebDriver.GetElement(By.Id("orderDetails_LI_cssiNumber__0")); } }

        //[FindsBy(How = How.XPath, Using = "//auto-pilot-item")]
        //public IWebElement AutopilotsectioninOrder;

        public IWebElement AutopilotsectioninbeforesaveOrder(int itemIndex = 1, int itemsubIndex = 1)
        {
            return WebDriver.GetElement(By.XPath(string.Format("//*[@id='orderDetails_{0}_{1}", itemIndex - 1, itemsubIndex - 1)), TimeSpan.FromSeconds(6));
            //*[@id="orderReview_0_1"]
        }

        public IWebElement TxtTenantIdinOrderdetailsbeoresaveOrder(int itemIndex = 1, int itemsubIndex = 1)
        {
            return WebDriver.GetElement(By.Id(string.Format("orderDetails_LI_AutoPilot_TenantIdValue__{0}_{1}", itemIndex - 1, itemsubIndex - 1)), TimeSpan.FromSeconds(3));
        }

        public IWebElement TxtDomainOrderdetailsbeforesaveOrder(int itemIndex = 1, int itemsubIndex = 1)
        {
            return WebDriver.GetElement(By.Id(string.Format("orderDetails_LI_AutoPilot_DomainValue__{0}_{1}", itemIndex - 1, itemsubIndex - 1)), TimeSpan.FromSeconds(3));
        }
        #endregion autopilot order page elements
        #region Auotopilot order page methods

        public void ItemsInOderdetails(IWebDriver driver)
        {
            ItemsinOderspage.IsElementClickable(WebDriver, TimeSpan.FromSeconds(5));
            ItemsinOderspage.Click(driver);
        }
        public void ExpandAllItems(IWebDriver driver)
        {
            foreach (IWebElement ele in ExpandItemsinDPID)
                ele.Click(driver);
        }
        public void SelectmultipleemailswhileCreateOrder(IWebDriver driver, string paymentMethod)
        {

            var quoteDetails = new QuoteDetailsPage(driver);
            var paymentsPage = new PaymentsPage(driver);
            var emailConfirmation = new EmailConfirmationPage(driver);
            var orderSave = quoteDetails.CreateOrder().WillNotExportOutsideUs();
            emailConfirmation.SelectMultipleEmails(driver);
            emailConfirmation.SelectorderCreateorderackccSoldToEmailAddress(driver);

            emailConfirmation.TxtorderAckOriginalRecipient().IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5));
            string EmailsList = emailConfirmation.TxtorderAckOriginalRecipient().GetText(driver, TimeSpan.FromSeconds(3));
            Logger.Write($"Emails list {EmailsList} are displayed ");

            //  emailConfirmation.OrderEmailslist(driver,true);

            emailConfirmation.EmailConfirmationNext();

            paymentsPage.SelectFirstPaymentMethod(paymentMethod);

            paymentsPage.PaymentMethodNext();
            new OrderReviewPage(driver).SaveOrder();
            new OrderDetailsPage(driver).OrderCFOCompare(EmailsList, "Order Acknowledgement", driver).Should().BeTrue();

        }
        public void Ordersearchwithdefferentdpid(IWebDriver driver, string DPID)
        {

            HomeWorkflow.GoToOrderSearchPage(driver);
            OrderDetailsPage orderDetailsPage = new OrderSearchPage(driver).SearchOrderByDpidNumber(DPID);
            orderDetailsPage.GetDpidFromOrderDetails().Should().BeEquivalentTo(DPID);
            // orderDetailsPage.ViewDuplicateOrdersLnk.Click();
            //var Disclaimer = orderDetailsPage.DupDPIDDisclaimer.Text.ToString();
            //Assert.IsTrue(Disclaimer.Equals("Note: The DPID list below may not be updated because it was generated at the time of order creation. Therefore, new orders or changes " +
            //    "to existing orders will not have been subjected to the duplicate PO check."));
        }



        public void VerifyAutopilotDatainOrderdetilsPage(IWebDriver driver, bool verifyTenantIdandDomainDataShown, string tenantId, string domain)
        {
            if (verifyTenantIdandDomainDataShown == true)
            {
                VerifyTenantIdandDomainDataShowninOrderdetails(driver, tenantId, domain).Should().BeTrue();
                Logger.Write($"Autopilot section with TenantId-{tenantId} and Domain-{domain} is displayed ");

            }
            else
            {
                if (!string.IsNullOrEmpty(tenantId) && !string.IsNullOrEmpty(domain))
                {
                    VerifyTenantIdandDomainDataShowninOrderdetails(driver, tenantId, domain).Should().BeFalse();
                    Logger.Write($"Autopilot section shown with NO TenantId and Domain data at Item");
                }
            }

        }

        //public bool VerifyAutopilotSectionDisplayedinOrderdetailsPage(IWebDriver driver,int itemIndex = 1)
        //{
        //    return AutopilotsectioninOrder()[itemIndex].IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(3)) && GetTenantIDinOrderdetails(driver).IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(3)) && GetDominIDinOrderdetails(driver).IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2));
        //}
        public bool VerifyAutopilotSectionDisplayedinBeforesaveOrderde(int ItemIndex = 1, int itemsubIndex = 1)
        {
            return AutopilotsectioninbeforesaveOrder(ItemIndex, itemsubIndex).IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(3)) && TxtTenantIdinOrderdetailsbeoresaveOrder(ItemIndex, itemsubIndex).IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(3)) && TxtDomainOrderdetailsbeforesaveOrder(ItemIndex, itemsubIndex).IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2));
        }
        public bool VerifyTenantIdandDomainDataShowninOrderdetails(IWebDriver driver, string tenantId, string domain)
        {
            return GetTenantIDinOrderdetails(driver).Equals(tenantId) && GetDominIDinOrderdetails(driver).Equals(domain);

        }
        public string GetTenantIDinOrderdetails(IWebDriver driver)
        {
            if (TxtTenantIdinOrderdetails().Count > 0)
            {
                for (int i = 0; i <= TxtTenantIdinOrderdetails().Count; i++)
                {
                    if (TxtTenantIdinOrderdetails()[i].IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(3)))
                    {
                        string tenanId = TxtTenantIdinOrderdetails()[i].GetText(driver);
                        Logger.Write($"Autopilot section with TenantId-{tenanId} is displayed");
                        VerifyTenantIdReadonly(i);
                        return tenanId;
                    }
                }
            }
            return null;
        }

        public string GetDominIDinOrderdetails(IWebDriver driver)
        {
            if (TxtDomainOrderdetails().Count > 0)
            {
                for (int i = 0; i <= TxtDomainOrderdetails().Count; i++)
                {
                    if (TxtDomainOrderdetails()[i].IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(3)))
                    {
                        string domainId = TxtDomainOrderdetails()[i].GetText(driver);
                        Logger.Write($"Autopilot section with TenantId-{domainId} is displayed");
                        VerifyDomainIdReadonly(i);
                        return domainId;
                    }
                }
            }
            return null;
        }

        public void VerifyTenantIdReadonly(int i)
        {

            TxtTenantIdinOrderdetails()[i].TagName.Should().NotBe("input");
            TxtTenantIdinOrderdetails()[i].GetAttribute("type").Should().NotBe("text");
        }
        public void VerifyDomainIdReadonly(int i)
        {
            TxtDomainOrderdetails()[i].TagName.Should().NotBe("input");
            TxtDomainOrderdetails()[i].GetAttribute("type").Should().NotBe("text");
        }

        //public void VerifyAutopilotDatainOrderdetilspage(bool verifyAutopilotSectionDisplayed, bool verifyTenantIdandDomainDataShown, string tenantId, string domain, int ItemIndex = 1)
        //{

        //        if (verifyAutopilotSectionDisplayed == true)
        //        {
        //        if(ItemsclickonOrderdetails(ItemIndex))
        //       // for (int i = 0; i <= AutopilotsectioninOrder().Count; i++)
        //       if(AutopilotsectioninOrders()!=null)
        //          {

        //            VerifyAutopilotSectionDisplayedinOrderdetailsPage(ItemIndex).Should().BeTrue();
        //            Logger.Write($"Autopilot section is displayed at Item in Shipping Group {ItemIndex}");
        //            if (verifyTenantIdandDomainDataShown == true)
        //            {
        //                VerifyTenantIdandDomainDataShowninOrderdetails(tenantId, domain,).Should().BeTrue();
        //                Logger.Write($"Autopilot section with TenantId-{tenantId} and Domain-{domain} is displayed at Item- in Shipping Group-{ItemIndex}");
        //                VerifyTenantIdandDomainIdReadonly(1);
        //            }
        //            else
        //            {
        //                if (!string.IsNullOrEmpty(tenantId) && !string.IsNullOrEmpty(domain))
        //                {
        //                    VerifyTenantIdandDomainDataShowninOrderdetails(tenantId, domain, ItemIndex).Should().BeFalse();
        //                    Logger.Write($"Autopilot section shown with NO TenantId and Domain data at Item-{ItemIndex}");
        //                }
        //            }
        //          }
        //        }
        //    else
        //    {
        //        ItemsclickonOrderdetails(ItemIndex);
        //        VerifyAutopilotSectionDisplayedinOrderdetailsPage(ItemIndex).Should().BeFalse();
        //        Logger.Write($"Autopilot section is NOT displayed at Item in Shipping Group {ItemIndex}");
        //    }
        //    // TxtTenantIdinOrderdetails(shippingGroupIndex, itemIndex).TagName.Should().NotBe("input");
        //    //TxtTenantIdinOrderdetails(shippingGroupIndex, itemIndex).GetAttribute("type").Should().NotBe("text");
        //}
        #endregion autopilot order page methods

        public void VerifyDpidlistinOderdetails(IWebDriver driver, string DiffDPID)
        {
            string finalprice = FinalPrice.Text;
            string Shiptoaddresstext = ShiptoAddressinorder.Text.Replace(" " + ",", "");
            string SoldtoCustomer = SoldtoCustomerno.Text.Replace(" " + ",", "");

            Ordersearchwithdefferentdpid(driver, DiffDPID);
            FinalPrice.GetText(driver).Should().Equals(finalprice);
            ShiptoAddressinorder.GetText(driver).Should().Equals(Shiptoaddresstext);
            SoldtoCustomerno.GetText(driver).Should().Equals(SoldtoCustomer);

        }


        public string GetOrderSpecificStatus(string orderNum)
        {
            IWebElement orderDetails = WebDriver.FindElements(By.XPath("//div[contains(@class,'split-order')]")).FirstOrDefault(x => x.Text.Contains(orderNum));
            IWebElement orderTxt = orderDetails.FindElement(By.XPath("//label[contains(@id,'orderDetails_AllOrderHeader_orderOmsStatus_')]"));
            return orderTxt.Text;
        }

        public OrderDetailsPage ExpandItemDetails(int index = 1)
        {
            //ExpandLineItem(index).Click(WebDriver);
            LnkItemDesc(index).Click(WebDriver);
            return new OrderDetailsPage(WebDriver);
        }

        public IWebElement GetOrderTypeFromMultiOrders(int orderIndex = 1)
        {
            return
                WebDriver.GetElement(
                    By.XPath("(//*[@id='orderDetailsLI_D_orderType_US Order'])[" + orderIndex + "]"));
        }

        public string ValidatePaymentMethod(string paymentMethod, int numberOfPayments)
        {

            LblPaymentMethodElement.WaitForElement(WebDriver);
            //return WebDriver.FindElement(By.Id("orderDetails_payment_information_" + paymentMethod + numberOfPayments + "_paymentmethod")).GetText(WebDriver);
            return WebDriver
                .FindElement(By.Id("orderDetails_payment_information_" + numberOfPayments + "_paymentmethod"))
                .GetText(WebDriver);
        }

        public void RefreshPage()
        {
            WebDriver.RefreshCurrentPage();
            string dpid = GetDpidFromOrderDetails();
        }

        /// <summary>
        /// Mail list to be verified with the Order Details page
        /// Compare the list with the given and return true if matches
        /// </summary>
        /// <param name="cfoMailList"></param>
        /// <param name="cfoType">Order Acknowledgement/Order Communication</param>
        /// <returns></returns>
        public bool OrderCFOCompare(string cfoMailList, string cfoType, IWebDriver webDriver)
        {
            int k = cfoType.Contains("Ack") ? 1 : 2;
            if (OrderCFOSection.Displayed)
            {
                //OrderCFOSection.Click();
                WebDriverUtil.JavaScriptClick(webDriver, OrderCFOSection);
                IList<IWebElement> LstOrderCFOPReferences =
                    WebDriver.FindElements(By.XPath("(//*[@id='orderCfo_orderCfoRecords']//table)[" + k + "]//td"));
                string[] mailList = new string[LstOrderCFOPReferences.Count];
                for (int i = 0; i < LstOrderCFOPReferences.Count; i++)
                    mailList[i] = LstOrderCFOPReferences[i].Text.Trim().ToString();
                string[] selectedCFOMailList = cfoMailList.Split(';').ToArray();
                if (selectedCFOMailList.Length == mailList.Length)
                {
                    var result = selectedCFOMailList.Except(mailList).ToArray();
                    if (result.Count() == 0)
                    {
                        OrderCFOSection.Click();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            OrderCFOSection.Click();
            return false;
        }

        public string GetOrderHoldActionStatus(string holdType)
        {
            return TblOrderHolds.FindElement(By.XPath("//td[normalize-space()='" + holdType + "']//..//td[last()]"))
                .GetText(WebDriver);

        }

        public OrderDetailsPage ReleaseOrderHold(string holdType)
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
            return new OrderDetailsPage(WebDriver);
        }

        public OrderDetailsPage ReleaseOrderTaxHold(string holdType)
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
                .FindElement(By.XPath("//td[normalize-space()='" + holdType + "']//..//label[normalize-space()='" + linkname + "']")).Click(WebDriver);
            return new OrderDetailsPage(WebDriver);
        }

        public OrderDetailsPage DeclineOrderHold(string holdType)
        {
            var linkname = "";
            if (holdType == "CVHold" || holdType == "PVHold")
            {
                linkname = "Decline";
            }

            TblOrderHolds
                .FindElement(By.XPath("//td[normalize-space()='" + holdType + "']//..//a[normalize-space()='" +
                                      linkname + "']")).Click(WebDriver);
            return new OrderDetailsPage(WebDriver);
        }


        public string GetDpidFromOrderDetails()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
           if(!LblDpid.IsElementDisplayed(WebDriver))
            {
                if(AsyncOgDpidInprogress.IsElementDisplayed(WebDriver))
                {
                    AsyncOgDpidRefresh.Click(WebDriver);
                }                
            }
            LblDpid.WaitUntilTextChanges(WebDriver, "2");
            return LblDpid.GetText(WebDriver).Split('\r')[0];

        }

        public bool VerifyLicenseContactInfoandConfirmation()
        {
            bool LicenseContact = LblLicenseContact.Displayed &
                                  "This data is not available in DSA, please look it up in Nexus tool" ==
                                  LblLicenseContactData.Text.Trim() & LblLicenseContactEmail.Text != null;
            bool LicenseContactInfo = LblLicenseContactConfirmation.Displayed &
                                      "This data is not available in DSA, please look it up in Nexus tool" ==
                                      LblLicenseContactConfirmationInfo.Text.Trim();
            if (LicenseContact & LicenseContactInfo)
                return true;
            return false;
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

        public void SwitchToWindow(IWebDriver driver, IWebElement link, string url)
        {
            string parentWindow = driver.CurrentWindowHandle;
            link.Click();
            foreach (string window in driver.WindowHandles)
            {
                if (window != parentWindow)
                {
                    driver.SwitchTo().Window(window);
                    if (driver.Url.Contains(url))
                    {
                        Logger.Write("Window Switched to " + driver.Url);
                    }
                }
            }

        }

        public string GetSolutionIdFromOrderDetails()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return LblSolutionId.GetText(WebDriver);
        }

        public OrderDetailsPage ExpandCustomerSection()
        {
            LnkCustomerToggle.Click(WebDriver);
            return new OrderDetailsPage(WebDriver);
        }

        public CustomerDetailsPage GoToCustomerDetails()
        {
            LnkCurrentCustomerCustomerName.Click(WebDriver);
            return new CustomerDetailsPage(WebDriver);
        }

        public string GetCompanyNumber()
        {
            return LblCompanyNumber.GetText(WebDriver);
        }

        public OrderDetailsPage EditSalesRep()
        {
            LnkSalesRepEdit.Click(WebDriver);
            return new OrderDetailsPage(WebDriver);
        }

        public String ModifySalesRepId(string CursalesRepId, string invalidSalesrepid = "")
        {
            String chgSalesrepId = "";
            if (CursalesRepId.Equals("12345"))
                chgSalesrepId = "1234";
            else if (CursalesRepId.Equals("1234"))
                chgSalesrepId = "12345";
            else if (CursalesRepId.Equals("999"))
                chgSalesrepId = "12345";
            else
                chgSalesrepId = "12345";
            if (invalidSalesrepid != "")
                chgSalesrepId = invalidSalesrepid;

            TxtSalesRepId.Clear();
            TxtSalesRepId.SetText(WebDriver, chgSalesrepId);
            return chgSalesrepId;
        }

        public OrderDetailsPage UndoEditOrder()
        {
            LnkMoreActions.Click(WebDriver);
            UndoEdit.Click(WebDriver);
            return new OrderDetailsPage(WebDriver);
        }

        public OrderDetailsPage BtnExpandAll()
        {
            LnkViewMoreLess.Click(WebDriver);
            return new OrderDetailsPage(WebDriver);
        }

        public string GetOrderProcessingStatusOfDpid()
        {
            return OrderProcessiongStatus.GetText(WebDriver);
        }

        public string GetViewRelatedOrder()
        {
            WebDriver.WaitForElementDisplay(By.XPath("//*[@id='orderDetails_dpid']//related-dpid-orders//div[@class = 'container show-grid']//div[@class = 'ccpHeaderExpanded']/div"), TimeSpan.FromSeconds(5));
            return WebDriver.FindElement(By.XPath("//*[@id='orderDetails_dpid']//related-dpid-orders//div[@class = 'container show-grid']//div[@class = 'ccpHeaderExpanded']/div")).Text;
        }

        public OrderDetailsPage LnkEditPoNumber()
        {
            EditPONumber.Click(WebDriver);
            return new OrderDetailsPage(WebDriver);
        }

        public OrderDetailsPage EnterPoNumber(string poNumber)
        {
            TxtPONumber.SetText(WebDriver, poNumber);
            WebDriver.WaitForPageLoad();
            return new OrderDetailsPage(WebDriver);

        }

        public OrderDetailsPage LnkEditEndUserNumber()
        {
            LnkEditEndUser.Click(WebDriver);
            return new OrderDetailsPage(WebDriver);
        }

        public OrderDetailsPage EnterEndUserNumber(string endUserNumber)
        {
            TxtEnduser.SetText(WebDriver, endUserNumber);
            WebDriver.WaitForPageLoad();
            return new OrderDetailsPage(WebDriver);

        }

        public String SelectMABD()
        {
            calMABD.Click(WebDriver);
            calnextMonth.Click(WebDriver);
            calnextMonth.Click(WebDriver);
            calDay.Click(WebDriver);
            return TxtMABD.GetText(WebDriver);
        }

        public OrderDetailsPage ExpandinstallationInstruction()
        {
            ExpandInstallationInstructions1.Click(WebDriver);
            return new OrderDetailsPage(WebDriver);
        }

        public OrderDetailsPage EnterInstallationInstructions(string installationInstruction)
        {
            TxtInstallationInstructions.IsElementClickable(WebDriver);
            TxtInstallationInstructions.SendKeys(Keys.Control + "a");
            TxtInstallationInstructions.SendKeys(Keys.Delete);

            var tempIns = installationInstruction.Split('|');
            foreach (var institem in tempIns)
            {
                TxtInstallationInstructions.SendKeys(institem);
                TxtInstallationInstructions.SendKeys(Keys.Shift + Keys.Enter);
            }
            //TxtInstallationInstructions.SetText(WebDriver, installationInstruction);
            TxtInstallationInstructions.SendKeys(Keys.Tab);
            return new OrderDetailsPage(WebDriver);

        }

        public OrderDetailsPage EnterShippingInstructions(string shippingInstruction)
        {
            TxtShippingInstructions.SetText(WebDriver, shippingInstruction);
            //WebDriver.WaitForPageLoad();
            return new OrderDetailsPage(WebDriver);

        }

        public IWebElement TxtItemLevelPhoneNumber(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_SI_phoneNumber_" + lineItemIndex));
        }


        public IWebElement LnkItemLevelShowMore(int lineItemIndex = 1)
        {
            //return WebDriver.GetElement(By.Id(PagePrefix + "_SEItem_accordionMore__" + (lineItemIndex - 1)));
            //return WebDriver.GetElements(By.XPath("//div[contains(@id,'_SEItem_accordionMore__')]"))[lineItemIndex];
            return WebDriver.GetElement(By.XPath("(//div[contains(@id,'_SEItem_accordionMore__')])[" + lineItemIndex + "]"));
        }

        public IWebElement LblItemPoNumber(int lineItemIndex = 1)
        {
            //return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_LI_poLineNumber__" + (lineItemIndex - 1) + "'][2]"));
            //return WebDriver.GetElements(By.XPath("//div[contains(@id,'_LI_poLineNumber__')]"))[lineItemIndex];
            return WebDriver.GetElement(By.XPath("(//div[contains(@id,'_LI_poLineNumber__')])[" + lineItemIndex + "]"));
        }

        public OrderDetailsPage SaveOrder()
        {
            BtnSaveOrder.Click(WebDriver);
            return this;
        }


        public CreateQuotePage CopyOrder()
        {
            LnkMoreActions.Click(WebDriver);
            LnkCopyOrder.Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        }

        public OrderDetailsPage ProFormaInvoice()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            LnkMoreActions.Click(WebDriver);
            LnkProformaInvoice.Click(WebDriver);
            return new OrderDetailsPage(WebDriver);
        }


        public CreateQuotePage CreateInvoiceOrder()
        {
            LnkMoreActions.Click(WebDriver);
            LnkCreateInvoiceOrder.Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        }

        public CreateQuotePage UpdateOrder()
        {
            LnkMoreActions.Click(WebDriver);
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
            BtnUpdateOrderContinue.Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.WaitForPageLoad();
            return new CreateQuotePage(WebDriver);
        }


        public CancelOrderPage CancelOrder()
        {
            LnkMoreActions.Click(WebDriver);
            LnkCancelOrder.Click(WebDriver);
            WebDriver.WaitForPageLoad();
            return new CancelOrderPage(WebDriver);
        }

        public void CancelByOrderSearch()
        {
            CancelOrder().SelectReason("Customer has cancelled the order");
            new CancelOrderPage(WebDriver).ClickRebookChkBox();
            new CancelOrderPage(WebDriver).OrderCancellationComments("cancel order test").ClickCancelOrderNextBtn();
            new CancelOrderPage(WebDriver).LblCancelOrderSuccessMsg.IsElementDisplayed(WebDriver).Should().BeTrue();
            new CancelOrderPage(WebDriver).ClickCancelOrderSuccessBtn();
            RebookOrder();

        }
        public CreateQuotePage RebookOrder()
        {
            LnkRebook.Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        }

        public CreateQuotePage CopyOrderOrderlevel()
        {
            WebDriver.WaitForPageLoad();
            BtnCopyOrder.Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        }

        public ItemQuoteData GetLineItemUnitValues(int itemIndex = 1, bool contractCodeRequired = false)
        {
            Logger.Write("Getting Values for Item " + itemIndex);
            Logger.Write("-------------------------");

            var itemQuoteData = new ItemQuoteData
            {
                ListPrice = LblItemLevelUnitListPrice(itemIndex).GetText(WebDriver).Substring(1),
                DiscountOffList =
                    Convert.ToDouble(LblItemLevelDiscountOffList(itemIndex).GetText(WebDriver).Split('%')[0]),
                Discount = Convert.ToDouble(LblItemLevelUnitDiscount(itemIndex).GetText(WebDriver).Substring(1)),
                SellingPrice = LblItemLevelUnitSellingPrice(itemIndex).GetText(WebDriver).Substring(1),
                MarginValue = Convert.ToDouble(LblItemLevelUnitMargin(itemIndex).GetText(WebDriver).Substring(1)),
                Quantity = int.Parse(LblItemLevelQuantity(itemIndex).GetText(WebDriver)),
                ContractCode = contractCodeRequired ? LblContractCode(itemIndex).GetText(WebDriver) : ""
            };
            //SellingPrice = "$" + ByTxtItemLevelUnitSellingPrice(i).GetText(WebDriver).Replace(",", string.Empty),


            return itemQuoteData;
        }

        public List<string> GetOrders()
        {
            List<string> k = new List<string>();
            foreach (IWebElement j in WebDriver.GetElements(
                By.XPath("//div[contains(@id,'orderDetails_order_header')]//h3")))
            {
                k.Add(j.GetText(WebDriver));

            }
            return k;
        }

        public void WaitForQuoteValidationToComplete()
        {
            while (WebDriver.TryFindElement(ImgValidatingQuoteBusyIndicator, TimeSpan.FromSeconds(10)))
            {
                // try checking with Busyoverlay in DSAUTIL file
            }
        }

        public OrderDetailsPage ExpandItemModule(int itemIndex = 1, int moduleIndex = 1)
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            ExpandItem(itemIndex);
            By.Id(String.Format("orderDetails_LI_CS_Item__{0}_{1}", itemIndex - 1, moduleIndex - 1)).Click(WebDriver);
            return new OrderDetailsPage(WebDriver);
        }

        public OrderDetailsPage ExpandItem(int itemIndex = 1)
        {
            var links = LnkExpandItem(itemIndex);
            links[0].Click(WebDriver);

            return new OrderDetailsPage(WebDriver);
        }

        public List<IWebElement> LnkExpandItem(int itemIndex)
        {
            By.Id("orderDetails_LI_productDescription__" + (itemIndex - 1)).Click(WebDriver);
            return WebDriver.GetElements(By.Id("orderDetails_SEItem_accordionMore__" + (itemIndex - 1)));
        }

        public bool GetSKUDescofVIQuotePage(int itemIndex, int moduleIndex)
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            ExpandItemModule(itemIndex, moduleIndex);
            var skuDescVI = WebDriver.FindElement(By.XPath(String.Format(
                "//*[@id='orderDetails_LI_CS_configInfo_build_categoryTable__{0}_{1}']/tbody/tr[1]/td", itemIndex - 1,
                moduleIndex - 1))).Text;
            //Verify that skudesc contains months appended
            bool skuDesc = skuDescVI.Contains(" Month(s)");
            return skuDesc;
        }

        public bool IsItemsCollapsed()
        {
            return (ItemsCollapse.Count > 0 && ItemsExpand.Count == 0) ? true : false;
        }

        public bool IsItemsExpanded()
        {
            return (ItemsExpand.Count > 0 && ItemsCollapse.Count == 0) ? true : false;
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

        public OrderDetailsPage ChangeShippingaddress()
        {
            LnkPickDifferentAddress.Click(WebDriver);
            LnkStandardAddress.Click(WebDriver);
            return new OrderDetailsPage(WebDriver);
        }

        public IWebElement SelectAddressTab(String selectTab)
        {
            return WebDriver.GetElement(By.Id("AddressSelectDialog_address-grid_tab_" + selectTab));
        }

        public List<Dictionary<string, object>> GetAddressTable()
        {
            AddressesTable.WaitForElement(WebDriver);
            return AddressesTable.GetTableData(WebDriver);
        }

        public OrderDetailsPage ChooseShippingAddress(string custName)
        {
            WebDriver.GetElement(
                By.XPath(
                    "//*[@id='AddressSelectController_addressSelect_addressGrid']//table/tbody//tr//td[normalize-space()='" +
                    custName + "']//..//a[normalize-space()='Select']")).Click(WebDriver);
            return new OrderDetailsPage(WebDriver);
        }

        public OrderDetailsPage PickShippingAddress()
        {
            WebDriver.GetElement(
                By.XPath(
                    "//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[1]/td[14]/add-component/change-address-actions/a")).Click(WebDriver);
            return new OrderDetailsPage(WebDriver);
        }

        public IWebElement ByItemSummaryUpSellModRevenueLabel(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_servicesIncentive_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"));

        }

        public IWebElement ByItemSummaryUpSellModRevenueLabel1(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_orders_line_items_']/div/div[2]/div/dpid-order-item/div/div[2]/div/div/div/order-item-header-summary/div/div[3]/div/order-item-smart-price-info/div/div[3]/label"));
        }

        //public ItemSummaryValues GetItemLevelSummary(int groupIndex = 1, int itemIndex = 1)
        //{
        //    Logger.Write("Getting Values for Item Level Summary for Item " + itemIndex + "in Shipping Group " + groupIndex);
        //    Logger.Write("-------------------------");

        //    var itemSummary = new ItemSummaryValues
        //    {
        //        TotalSellingPrice = Convert.ToDouble(LblItemSummarySellingPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
        //        TotalTax = Convert.ToDouble(LblItemSummaryTax(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
        //        TotalEcoFee = Convert.ToDouble(LblItemSummaryEcoFee(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
        //        TotalAmount = Convert.ToDouble(LblItemSummaryTotalAmount(itemIndex, groupIndex).GetText(WebDriver).Substring(1))
        //    };

        //    return itemSummary;
        //}


        //public ShippingGroupSummary GetShippingGroupSummary(int groupIndex = 1)
        //{
        //    Logger.Write("Getting Values for Shipping Group Summary for group " + groupIndex);
        //    Logger.Write("-------------------------");

        //    var shipGroupSummary = new ShippingGroupSummary()
        //    {
        //        SubTotal = Convert.ToDouble(LblGroupSummarySubTotal(groupIndex).GetText(WebDriver).Substring(1)),
        //        TotalShipping = Convert.ToDouble(LblGroupSummaryShippingAmount(groupIndex).GetText(WebDriver).Substring(1)),
        //        TotalTax = Convert.ToDouble(LblGroupSummaryTax(groupIndex).GetText(WebDriver).Substring(1)),
        //        TotalEcoFee = Convert.ToDouble(LblGroupSummaryEcoFee(groupIndex).GetText(WebDriver).Substring(1)),
        //        TotalAmount = Convert.ToDouble(LblGroupSummaryTotalAmount(groupIndex).GetText(WebDriver).Substring(1))
        //    };

        //    return shipGroupSummary;
        //}

        public IList<IWebElement> orderCommentsArea()
        {
            return WebDriver.GetElements(By.XPath("(//*[@class='cfg-group mg-btm-10 col-md-12'])"));
        }

        public void ClickYesClosePOM()
        {
            POMCloseYes.Click(WebDriver);
            POMClose.Click(WebDriver);
        }
        public bool IsTopLevelAssemplytDisplayed()
        {
            return topassemplylevel.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(20));
        }

        public string ApplyTlaItemsvaluestxt(int itemIndex)
        {
            return LnkItemLevelTLAtextbox(itemIndex).GetText(WebDriver);
        }


        public IWebElement LnkItemLevelTLAtextbox(int lineItemIndex = 1)
        {
            var lstwebelements = WebDriver.GetElements(By.XPath("//*[contains(@id,'orderDetails_LI_tla__0')]/span"), TimeSpan.FromSeconds(10));

            if (lstwebelements != null && lstwebelements.Count > 0)
            {
                return lstwebelements[lineItemIndex - 1];
            }
            return null;
        }
        public bool ValidateFunderSwap()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            var funderName = FunderNameOnBillToCustomer.GetText(WebDriver);
            var customerName = LnkCurrentCustomerCompanyName.GetText(WebDriver);
            if (funderName != customerName)
                return true;
            return false;
        }

        public bool ValidateFunderSwapOnBillToAddress()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            BillToAddressHeader.Click();
            FunderNameOnBillToAddress.WaitUntilTextChanges(WebDriver, "DFS FUNDING");
            var funderName = FunderNameOnBillToAddress.GetText(WebDriver);
            if (funderName == "DFS FUNDING")
                return true;
            return false;
        }

        public bool ViewOrderCancelRequestHistory(IWebDriver webDriver, IWebElement expectedElement)
        {
            bool IsElementDisplayed = false;

            webDriver.WaitForElementDisplay(expectedElement, TimeSpan.FromSeconds(5));

            if (expectedElement.Displayed)
            {
                IsElementDisplayed = true;
            }

            return IsElementDisplayed;

        }


        #region SolutionsCode

        public bool VerifyHoldTypeAndCFIProjectStatus(string holdtype, string cfiProjectstatus)
        {
            bool result = false;
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.Navigate().Refresh();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            string HoldTypeFromApp = HoldType.Text;
            string CFIProjectStatusFromApp = CFIProjectStatus.Text;
            if (HoldTypeFromApp.Equals(holdtype) && CFIProjectStatusFromApp.Contains(cfiProjectstatus))
            {
                result = true;
            }
            return result;
        }

        public bool IsCFIFirstArticleReviewHoldReleased()
        {
            return HoldType.IsElementDisplayed(WebDriver);
            //return WebElement.ElementExists(HoldType, HoldTypeBy); If in case IsElementDisplayed is not working, then, use this line.
        }

        public bool IsfirstArticleReviewCheckBoxDisplayedWithProperLabel()
        {
            bool result = false;
            WebDriver.Navigate().Refresh();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            if (WebDriver.ElementExists(FirstArticleCheckBox) && WebDriver.ElementExists(FirstArticleCheckboxLabel))
            {
                DsaUtil.WaitForElement(WebDriver.FindElement(FirstArticleCheckBox), WebDriver);
                result = WebDriver.FindElement(FirstArticleCheckBox).Displayed;
            }
            return result;
        }

        public OrderDetailsPage SelectFirstArticleCheckBox()
        {
            DsaUtil.SelectCheckBox(WebDriver.FindElement(FirstArticleCheckBox), WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return new OrderDetailsPage(WebDriver);
        }

        public bool IsSaveOrderEnabled()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            DsaUtil.WaitForElement(BtnSaveOrder, WebDriver);
            return BtnSaveOrder.Enabled;
        }


        public string GetGoalDealIdFromItem(int itemIndex = 1)
        {
            return
                WebDriver.GetElement(By.Id(PagePrefix + "_LI_info_goalDealId_" + "_" + (itemIndex - 1))).GetText(WebDriver);
        }

        /// <summary>
        /// Verify the Unit Price is Presnt is non Zero
        /// </summary>
        /// <param name="webDriver"></param>
        /// <param name="webElement"></param>
        /// <returns></returns>
        public bool VerifyUnitPriceGreaterthanZero(IWebDriver webDriver, IWebElement webElement)
        {
            bool unitPriceIsPresent = false;

            WebDriverUtil.ScrollIntoElement(webDriver, webElement);
            string unitListPrice = webElement.Text;

            unitListPrice = Regex.Match(unitListPrice, @"\d+").Value;

            int number = Int32.Parse(unitListPrice);


            if (number > 0)
            {
                unitPriceIsPresent = true;
            }

            return unitPriceIsPresent;
        }
        public string GetGoalDealIdFromNonTiedItem(int shippingGroupIndex = 1, int itemIndex = 1, int nontiedItemIndex = 1)
        {
            return
                WebDriver.GetElement(
                        By.Id(PagePrefix + "_LI_NTSKU_NonTied_info_goalDealId_" + (shippingGroupIndex - 1) + "_" +
                              (itemIndex - 1) + "_" + (nontiedItemIndex - 1)))
                    .GetText(WebDriver);
        }



        /// <summary>
        /// Verifies Expected Amount from Quote details page and Actual Amount in Order Detail Page
        /// </summary>
        /// <param name="webDriver"></param>
        /// <param name="expectedAmount"></param>
        /// <param name="actualAmount"></param>
        /// <returns></returns>
        public bool VerifyTotalAmount(IWebDriver webDriver, string expectedAmount, IWebElement actualAmount)
        {
            bool IsAmountMatching = false;

            expectedAmount = Regex.Match(expectedAmount, @"\d+").Value;
            int expectedAmountInt = Int32.Parse(expectedAmount);

            WebDriverUtil.ScrollIntoElement(webDriver, actualAmount);
            string actualAmountText = actualAmount.Text;
            actualAmountText = Regex.Match(actualAmountText, @"\d+").Value;
            int actualAmountInt = Int32.Parse(actualAmountText);

            if (expectedAmountInt == actualAmountInt)
            {
                IsAmountMatching = true;
            }

            return IsAmountMatching;
        }

        #endregion

        public OrderDetailsPage LnkPaymentMethod()
        {
            OrderDetailsPaymentInformationToggle.Click(WebDriver);
            return new OrderDetailsPage(WebDriver);
        }

        #region ProductsUnitElements
        public IWebElement ProductsElement(int itemIndex = 0)
        {
            return WebDriver.GetElement(By.Id(string.Format("orderDetails_LI_productDescription__{0}", itemIndex - 1)), TimeSpan.FromSeconds(3));
        }

        public IWebElement UnitListPriceElement(int itemIndex = 0)
        {
            return WebDriver.GetElement(By.Id(string.Format("orderDetails_LI_PI_unitPrice__{0}", itemIndex - 1)), TimeSpan.FromSeconds(3));
        }

        public IWebElement UnitDiscountElement(int itemIndex = 0)
        {
            return WebDriver.GetElement(By.Id(string.Format("orderDetails_LI_PI_dol__{0}", itemIndex - 1)), TimeSpan.FromSeconds(3));
        }

        public IWebElement UnitSellingPriceElement(int itemIndex = 0)
        {
            return WebDriver.GetElement(By.Id(string.Format("_LI_PI_unitSellingPrice__{0}", itemIndex - 1)), TimeSpan.FromSeconds(3));
        }

        public IWebElement ListPriceElement(int itemIndex = 0)
        {
            return WebDriver.GetElement(By.Id(string.Format("orderDetails_LI_totalListPrice__{0}", itemIndex - 1)), TimeSpan.FromSeconds(3));
        }

        #endregion


        public IList<string> GetAllOrderProductsUnitPrices(IWebDriver webdriver, int totalItems, bool GetunitListPrice, bool GetunitDiscount, bool GetunitSellingPrice, bool finalPrice = true, int shipppingAddress = 0)
        {
            IList<string> unitOrderPricing = new List<string>();

            for (int i = 0; i < totalItems; i++)
            {
                if (GetunitListPrice)
                {
                    IWebElement unitListPriceEle = UnitListPriceElement(i + 1);
                    string actualListPrice = unitListPriceEle.Text;
                    actualListPrice = Regex.Replace(actualListPrice, @"[^\d]", "");
                    unitOrderPricing.Add(actualListPrice);
                }

                if (GetunitDiscount)
                {
                    IWebElement UnitDiscountEle = UnitDiscountElement(i + 1);
                    string actualDiscountPrice = UnitDiscountEle.Text;
                    actualDiscountPrice = Regex.Replace(actualDiscountPrice, @"[^\d]", "");
                    unitOrderPricing.Add(actualDiscountPrice);
                }


                if (GetunitSellingPrice)
                {
                    IWebElement UnitSelleingPriceEle = UnitSellingPriceElement(i + 1);
                    string actualunitSellingPrice = UnitSelleingPriceEle.Text;
                    actualunitSellingPrice = Regex.Replace(actualunitSellingPrice, @"[^\d]", "");
                    unitOrderPricing.Add(actualunitSellingPrice);
                }
            }

            if (finalPrice)
            {
                string finalprice = FinalPrice.Text;
                string actualfinalPrice = Regex.Replace(finalprice, @"[^\d]", "");
                unitOrderPricing.Add(actualfinalPrice);
            }
            return unitOrderPricing;

        }

        /// <summary>
        /// Get Products Descriptions on order details Page
        /// </summary>
        /// <param name="webDriver"></param>
        /// <param name="totalItems"></param>
        /// <returns></returns>
        public IList<string> GetAllProductsDescription(IWebDriver webdriver, int itemindex = 0, int shipppingAddress = 0)
        {
            CheckIfProductExpanded(webdriver, itemindex);

            IList<string> products = new List<string>();

            for (int i = 1; i <= itemindex; i++)
            {
                CheckIfProductExpanded(webdriver, itemindex);
                IWebElement productsEle = ProductsElement(itemindex);
                CheckIfProductExpanded(webdriver, itemindex);
                products.Add(productsEle.Text);
            }
            return products;
        }


        public void CheckIfProductExpanded(IWebDriver webdriver, int shippingAddressIndex = 1, int itemIndex = 1)
        {
            IWebElement ProductsDetailsEle = ProductsElement(itemIndex);

            try
            {
                if (webdriver.FindElement(By.XPath("(//div[@class = 'line-item-hdr ccpHeaderCollapsed'])['" + itemIndex + "']")).Displayed == true)
                {
                    ProductsElement(itemIndex).Click();
                    WebDriverUtil.VerifyBusyOverlayNotDisplayed(webdriver);
                }
            }
            catch (Exception e)
            {

            }
        }
        public IList<OrderProductUnitObjects> GetProductandUnitItems(IWebDriver webDriver, int shippingAddressIndex = 0, int itemIndex = 0)
        {
            CheckIfProductExpanded(webDriver, itemIndex);
            WebDriverUtil.VerifyBusyOverlayNotDisplayed(webDriver);

            WebDriverUtil.WaitForElementDisplay(webDriver, ProductsElement(itemIndex), TimeSpan.FromSeconds(3));
            string productTitle = ProductsElement(itemIndex).Text;

            WebDriverUtil.WaitForElementDisplay(webDriver, UnitListPriceElement(itemIndex), TimeSpan.FromSeconds(3));
            string unitListPrice = UnitListPriceElement(itemIndex).Text;

            WebDriverUtil.WaitForElementDisplay(webDriver, UnitDiscountElement(itemIndex), TimeSpan.FromSeconds(3));
            string unitDiscount = UnitDiscountElement(itemIndex).Text;

            WebDriverUtil.WaitForElementDisplay(webDriver, UnitSellingPriceElement(itemIndex), TimeSpan.FromSeconds(3));
            string unitSellingPrice = UnitSellingPriceElement(itemIndex).Text;

            WebDriverUtil.WaitForElementDisplay(webDriver, ListPriceElement(itemIndex), TimeSpan.FromSeconds(3));
            string listPrice = ListPriceElement(itemIndex).Text;

            WebDriverUtil.StalenessOfElement(webDriver, FinalPrice);

            var items = new List<OrderProductUnitObjects>();
            items.Add(new OrderProductUnitObjects
            {
                ProductTitle = productTitle,
                UnitListPrice = unitListPrice,
                UnitDiscount = unitDiscount,
                ListPrice = listPrice,
            });

            return items;
        }

        public static void CompareQuoteDetailOrderDetailProductsUnits(IList<ProductUnitObjects> quoteDetailsProductUnits, IList<OrderProductUnitObjects> orderDetailsProducUnits)
        {
            quoteDetailsProductUnits[0].ProductTitle.Trim().Should().BeEquivalentTo(orderDetailsProducUnits[0].ProductTitle.Trim());
            quoteDetailsProductUnits[0].UnitListPrice.Trim().Should().BeEquivalentTo(orderDetailsProducUnits[0].UnitListPrice.Trim());
            quoteDetailsProductUnits[0].UnitDiscount.Trim().Should().BeEquivalentTo(orderDetailsProducUnits[0].UnitDiscount.Trim());
            quoteDetailsProductUnits[0].ListPrice.Trim().Should().BeEquivalentTo(orderDetailsProducUnits[0].ListPrice.Trim());
        }

        public void WaitForBusyIndicatorAppearAndDisappear()
        {
            WebDriver.WaitForElementVisible(By.XPath("//*[@id='busy-indicator']"), TimeSpan.FromSeconds(10));
            var wait = new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime);
            wait.Until<bool>(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='busy-indicator']")));
        }
        public void OpenNewTab(string baseUrl)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            js.ExecuteScript("window.open();");
            WebDriver.SwitchTo().Window(WebDriver.WindowHandles.Last());
            WebDriver.Url = baseUrl;
        }
        public string GetGPID()
        {
            WebDriver.RefreshCurrentPage();
            MoreDetails.Click(WebDriver);
            MoreDetails.WaitForElementVisible(TimeSpan.FromSeconds(150));
            string[] tempArr = GPID.Text.Split(':');
            MoreDetailsOk.Click();
            return tempArr[(tempArr.Length) - 1];
        }


        public string GetCCVaue(int value)
        {
            PaymentInformation.IsElementClickable(WebDriver, TimeSpan.FromSeconds(150));
            if (PaymentInformationHeader.GetAttribute("class").Contains("ccpHeaderCollapsed"))
            {
                PaymentInformation.Click();
            }
            string CC = string.Empty;
            if (value == 1)
                CC = CCValue1.Text;
            if (value == 2)
                CC = CCValue1.Text;
            return CC;
        }

        public IWebElement WaitUntilOEPTimelineDisplayed()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(30));
            return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[contains(text(),'ORDER STATUS')]")));
        }

        public IList<string> GetOrderNumbers()
        {
            var orderNumbers = new List<string>();
            foreach(var element in OrderNumbers)
            {
                var x = element.Text;
                var array = element.Text.Trim().Split('-');
                var orderArray = array.First().Split(' ');
                orderNumbers.Add(orderArray.Last());
            }
            return orderNumbers;
        }

        // Digital fulfillment

        public IWebElement DigitalFulfillmentEmail_Collapsed() => WebDriver.GetElement(By.XPath("//od-df-emails/div/div[@aria-label='View More Button']"));

        public IList<IWebElement> DF_Emails() => WebDriver.GetElements(By.Id("email_value_0"));

        public OrderDetailsPage DF_SaveOrder(OrderReviewPage orderReviewPage)
        {
            orderReviewPage.BtnSaveOrder.Click(WebDriver);
            bool isServicesdown = new OrderReviewPage(WebDriver).CheckforPaymentServices();
            if (isServicesdown == true)
                orderReviewPage.BtnSaveOrder.Click(WebDriver);
            return new OrderDetailsPage(WebDriver);
        }

        public CreateQuotePage DFUpdateOrder()
        {
            new OrderDetailsPage(WebDriver).RefreshOrderLnk.Click(WebDriver);
            int a = 0;
            do
            {
                LnkMoreActions.Click(WebDriver);
                var displayed = LnkUpdateOrder.IsElementDisplayed(WebDriver);
                if(displayed)
                {
                    LnkUpdateOrder.Click(WebDriver);
                    break;
                }else
                {
                    a = a + 1;
                    WebDriver.Navigate().Refresh();
                }
                
            }
            while (a < 3);
            
            BtnUpdateOrderContinue.Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.WaitForPageLoad();
            return new CreateQuotePage(WebDriver);
        }

        #region GetProductsUnits


        public IWebElement ProductsDescription(int itemindex)
        {
            return WebDriver.GetElement(By.XPath($"(//span[contains(@id, 'orderDetails_LI_productDescription')])[{itemindex}]"));
        }

        public IWebElement ProductUnitListPrice(int itemindex)
        {
            return WebDriver.GetElement(By.XPath($"(//span[contains(@id, 'orderDetails_LI_productDescription')]//following::div[contains(@id, 'orderDetails_LI_PI_unitPrice')])[{itemindex}]"));
        }

        public IWebElement ProductUnitDiscount(int itemindex)
        {
            return WebDriver.GetElement(By.XPath($"(//span[contains(@id, 'orderDetails_LI_productDescription')]//following::div[contains(@id, 'orderDetails_LI_PI_dol__')])[{itemindex}]"));
        }

        public IWebElement ProductUnitSellingPrice(int itemindex)
        {
            return WebDriver.GetElement(By.XPath($"(//span[contains(@id, 'orderDetails_LI_productDescription')]//following::div[@class = 'financial' and contains(@id, 'LI_PI_unitSellingPrice')])[{itemindex}]"));
        }

        public IWebElement ProductListPrice(int itemindex)
        {
            return WebDriver.GetElement(By.XPath($"(//span[contains(@id, 'orderDetails_LI_productDescription')]//following::div[contains(@id, 'orderDetails_LI_totalListPrice')])[{itemindex}]"));
        }

        public IList<OrderProductUnitObjects> GetAllOrderDetailsProductsUnits(bool getProducts = true)
        {
            var items = new List<OrderProductUnitObjects>();

            if (getProducts == true)
            {
                IList<IWebElement> allProducts = WebDriver.FindElements(By.XPath("//span[contains(@id, 'orderDetails_LI_productDescription')]"));

                for (int i = 0; i < allProducts.Count; i++)
                {
                    WebDriver.VerifyBusyOverlayNotDisplayed();
                    allProducts[i].Click(); //--July 30 Sprint 13 Expand Not Needed, Sprint 16 it must be collapsed by default
                }

                for (int i = 1; i <= allProducts.Count; i++)

                    items.Add(new OrderProductUnitObjects
                    {
                        ProductTitle = ProductsDescription(i).Text,
                        UnitListPrice = ProductUnitListPrice(i).Text,
                        UnitDiscount = ProductUnitDiscount(i).Text,
                        ListPrice = ProductListPrice(i).Text,
                    });
            }

            return items;
        }

        public IWebElement ExpandElement(int itemIndex)
        {
            return WebDriver.GetElement(By.XPath($"(//div[@class = 'line-item-hdr ccpHeaderCollapsed'])[{itemIndex}]"));
        }
        public void ExpandProductItem(int itemIndex)
        {
            bool isTrue = WebDriverUtil.WaitForElementDisplay(WebDriver, ExpandElement(itemIndex));

            if (isTrue)
            {
                ExpandElement(itemIndex).Click();
            }
        }

        public bool CompareQuoteOrderProductsandUnits(IList<ProductUnitObjects> quoteDetailsItems, IList<OrderProductUnitObjects> OrderDetailsItems)
        {
            bool IsMatching = true;
            try
            {
                quoteDetailsItems.Where(y => OrderDetailsItems.Any(z => z.ProductTitle == y.ProductTitle));
                quoteDetailsItems.Where(y => OrderDetailsItems.Any(z => z.UnitListPrice == y.UnitListPrice));
                quoteDetailsItems.Where(y => OrderDetailsItems.Any(z => z.UnitDiscount == y.UnitDiscount));
                quoteDetailsItems.Where(y => OrderDetailsItems.Any(z => z.ListPrice == y.ListPrice));

            }

            catch (Exception e)
            {
                IsMatching = false;
            }

            return IsMatching;
        }

        public void EditOrderDisableEditPONumber(string ob2CcDpid, string ob2gcDPID, string ob2hcDPID)
        {
            string[] ob2Dpids = new string[] { ob2CcDpid, ob2gcDPID, ob2hcDPID };
            foreach (string dpids in ob2Dpids)
            {
                HomeWorkflow.GoToOrderSearchPage(WebDriver);
                new OrderSearchPage(WebDriver).SearchOrderByDpidNumber(dpids);
                GetDpidFromOrderDetails().Should().BeEquivalentTo(dpids).ToString();
                OrderDetailsSrcApplication.GetText(WebDriver).Should().NotBe("Dell Sales Application");
                EditPONumber.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)).Should().BeFalse();
            }
        }

        public bool VerifyAttributes()
        {
            bool isDisplayed = false;

            string[] attributes = new string[] { "DPID", "PO #", "Order Status", "Description", "Final Price" };

            for (int i = 0; i < attributes.Count() - 1; i++)
            {
                IWebElement webElement = WebDriver.GetElement(By.XPath($"(//div[@id='orderDetails_dpid']//div//div[contains(@class, 'col-sm') and text() = '{attributes[i]}'])[1]"));

                if (webElement.Displayed == true)
                {
                    isDisplayed = true;
                }
            }

            return isDisplayed;
        }
        #endregion
    }

    public class OrderProductUnitObjects
    {
        public string ProductTitle { get; set; }
        public string UnitListPrice { get; set; }
        public string UnitDiscount { get; set; }
        public string ListPrice { get; set; }
    }

}

