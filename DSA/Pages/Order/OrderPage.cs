using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Order
{
    public class OrderPage : DsaPageBase
    {
        public OrderPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements


public IWebElement OrderDetailsOrderStatus { get { return WebDriver.GetElement(By.Id("orderDetails_orderStatus")); } }


public IWebElement LnkRebook { get { return WebDriver.GetElement(By.Id("rebook")); } }


public IWebElement HdrRebook { get { return WebDriver.GetElement(By.Id("quoteCreate_title")); } }


public IWebElement LnkEditOrder { get { return WebDriver.GetElement(By.Id("ABC")); } }
        //TODO Need to add the element Id once the UI is ready

public IWebElement OrderDetailsProductName { get { return WebDriver.GetElement(By.Id("orderDetails_LI_productDescription_{0}")); } }


public IWebElement OrderSummaryListPrice { get { return WebDriver.GetElement(By.Id("orderDetails_summary_listPrice")); } }


public IWebElement OrderSummarySellingPrice { get { return WebDriver.GetElement(By.Id("orderDetails_summary_sellingPrice")); } }


public IWebElement OrderSummaryDiscount { get { return WebDriver.GetElement(By.Id("orderDetails_summary_discountPercent")); } }


public IWebElement OrderSummaryMargin { get { return WebDriver.GetElement(By.Id("orderDetails_summary_marginValue")); } }


public IWebElement OrderSummaryShippingPrice { get { return WebDriver.GetElement(By.Id("orderDetails_summary_shippingPriceAmount")); } }


public IWebElement OrderSummaryShippingDiscount { get { return WebDriver.GetElement(By.Id("orderDetails_summary_shippingDiscountAmount")); } }


public IWebElement OrderSummarySubTotal { get { return WebDriver.GetElement(By.Id("orderDetails_summary_subtotalAmount")); } }


public IWebElement OrderSummaryTotalShipping { get { return WebDriver.GetElement(By.Id("orderDetails_summary_shippingAmount")); } }


public IWebElement OrderSummaryTotalTax { get { return WebDriver.GetElement(By.Id("orderDetails_summary_totalTaxAmount")); } }


public IWebElement OrderSummaryTotalEcoFee { get { return WebDriver.GetElement(By.Id("orderDetails_summary_ecoFee")); } }


public IWebElement OrderSummaryFinalPrice { get { return WebDriver.GetElement(By.Id("orderDetails_summary_finalPrice")); } }
       

public IWebElement CardAmount { get { return WebDriver.GetElement(By.Id("cartPayment_amount")); } }


public IWebElement BtnAddCreditCardSave { get { return WebDriver.GetElement(By.CssSelector(".btn-bar > button:nth-child(1)")); } }


public IWebElement BtnAddCreditCardCancel { get { return WebDriver.GetElement(By.Id("btn-default")); } }


public IWebElement BtnClosePopup { get { return WebDriver.GetElement(By.Id("icon-ui-close")); } }


public IWebElement RemainingBalnce { get { return WebDriver.GetElement(By.Id("payment_netTerms_balance")); } }


public IWebElement CreditLimit { get { return WebDriver.GetElement(By.Id("payment_netTerms_creditLimit")); } }


public IWebElement NakOrderError { get { return WebDriver.GetElement(By.Id("orderDetails_orderProcessingResults_notice")); } }


public IWebElement PaymentInfoSectionArrow { get { return WebDriver.GetElement(By.Id("orderDetails_payment_information_Toggle")); } }


public IWebElement OrderDetailsRemainingBalance { get { return WebDriver.GetElement(By.Id("orderDetails_payment_information_netterms1_cardholdername")); } }


public IWebElement OrderSavePoAmount { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderExport_sendPoRequest_poAmount")); } }


public IWebElement OrderSendPoRequest { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderExport_sendPoRequest_send")); } }


public IWebElement OrderSendCloseSuccess { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderExport_sendPoRequest_close")); } }


public IWebElement OrderSendPaymentNext { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderPayment_next")); } }


public IWebElement OrderSendEmailNext { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderEmails_next")); } }


public IWebElement ReviewOrderCompRevenueSummary { get { return WebDriver.GetElement(By.Id("orderReview_summary_compRevenue")); } }


public IWebElement ReviewOrderUnitCompRevenue { get { return WebDriver.GetElement(By.Id("orderReview_LI_PI_unitCompRevenue_{0}")); } }


public IWebElement LblPomId { get { return WebDriver.GetElement(By.CssSelector("#_quoteStatus_label > span")); } }


public IWebElement LnkPomIdAddCss { get { return WebDriver.GetElement(By.CssSelector("#_pomId > span:nth-child(2) > span > a")); } }


public IWebElement LnkPomIdEditCss { get { return WebDriver.GetElement(By.CssSelector("#quoteDetail_pomId > span:nth-child(2) > span.ng-hide > a")); } }


public IWebElement PomId { get { return WebDriver.GetElement(By.CssSelector("#_pomId > span:nth-child(2) > span")); } }


public IWebElement PomIdText { get { return WebDriver.GetElement(By.Id("#pom_id")); } }


public IWebElement LnkChange { get { return WebDriver.GetElement(By.Id("#quoteSaveAsOrderPayment_Change")); } }


public IWebElement PomIdValidationMessage { get { return WebDriver.GetElement(By.CssSelector("#_quote_Validation > p > span")); } }


public IWebElement PomIdValidationMessageOnReviewOrderPage { get { return WebDriver.GetElement(By.CssSelector("#orderReview_pomId > span > label")); } }


public IWebElement LnkPomAddOnReviewOrderPage { get { return WebDriver.GetElement(By.CssSelector("#orderReview_pomId > span > a")); } }


public IWebElement LnkPomEditOnReviewOrderPage { get { return WebDriver.GetElement(By.CssSelector("#orderReview_pomId > span > a")); } }


public IWebElement TxtPomIdOnReviewOrderPage { get { return WebDriver.GetElement(By.Id("#pom_id")); } }


public IWebElement OrderType { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrder_orderType")); } }
        //Todo: Need to provide the ordertype Id, once the devwork is completed.

public IWebElement DpsNumber { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrder_dpsNumber")); } }
        //Todo: Need to provide the ordertype id, once the devwork is completed.

public IWebElement OriginalOrderNumber { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrder_originalOrderNumber")); } }
        //Todo: Need to provide the ordertype id, once the devwork is completed.

public IWebElement ReasonCode { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrder_reasonCode")); } }
        //Todo: Need to provide the ordertype id, once the devwork is completed.

public IWebElement OrderTypeOnOrderDetails { get { return WebDriver.GetElement(By.Id("orderDetailsLI_D_orderType_{0}")); } }
        //Todo: Need to provide the ordertype Id, once the devwork is completed.

public IWebElement OrderTypeOnReviewOrders { get { return WebDriver.GetElement(By.Id("orderReview_orderType")); } }
        //Todo: Need to provide the ordertype Id, once the devwork is completed.

public IWebElement OrderDetailsSummaryFinalPrice { get { return WebDriver.GetElement(By.XPath("//*[@id='GMOR_terms_of_sale_anchor']/descendant::span[2]")); } }

        #endregion

        #region Methods

      //  public OrderPage GetOrderSummaryFinalPrice()
        //{
          //  OrderSummaryFinalPrice.Text(WebDriver);

            //return new OrderPage(webDriver);
        //}
        #endregion
    }
}
