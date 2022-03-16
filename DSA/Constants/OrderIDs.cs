namespace Dsa.Constants
{
    public static class OrderIDs
    {
        // Order Search
        public const string OrderSearchDateRangeDdl = "orderSearch_dateRange";
        public const string OrderSearchResultsGrid  = "orderSearchResults_Grid";
        public const string OrderSearchResultsItemPerPage = "orderSearchResult_itemsPerPage";
        public const string OrderSearchOrderNumberTextbox = "orderSearch_orderNumber";
        public const string OrderSearchDpIdTextbox = "orderSearch_dpid";
        public const string OrderSearchDealIdTextbox = "orderSearch_dealID";
        public const string OrderSearchComQuoteNumberTextbox = "orderSearch_comQuoteNumber";
        public const string OrderSearchQuoteNameTextbox = "orderSearch_quoteName";
        public const string OrderSearchPoNumberTextbox = "orderSearch_poNumber";
        public const string OrderSearchServiceTagTextbox = "orderSearch_serviceTag";
        public const string SearchButton = "orderSearch_searchButton";
        public const string ClearButton = "orderSearch_clearAction";
        public const string OrderSearchCreatedByTextbox = "orderSearch_orderCreatedBy";
        public const string OrderSearchLoggedInSalesRepTextbox = "orderSearch_loggedInSalesRepId";

        // Order Details
        public const string OrderDetailsHeader = "orderDetails_title";
        public const string DpidLbl = "orderDetails_dpid";
        public const string QuoteNumberLbl = "orderDetails_quoteNumber";
        public const string PoNumberLbl    = "orderDetails_poNumber";
        public const string MoreActionsLnk = "orderDetails_moreActions";
        public const string CopyOrderLnk   = "orderDetails_editQuote";
        public const string CancelOrderLnk = "orderDetails_cancelOrder";
        public const string CustomerNumber = "orderDetails_customerNumber";
        public const string CompanyNumber = "orderDetails_companyNumber";
        public const string CustomerToggle = "orderDetails_customerInformationToggle";
        public const string OrderDetailsNoResults = "noResults_returnPrevious_partPre";
        public const string OrderDetailsOrderHeader = "orderDetails_order_header_";
        
        // Save As Order
        public const string AddPaymentMethodLink = "quoteSaveAsOrderPayment_addPayment";
        public const string ExportNoRadioButton = "quoteSaveAsOrderExport_noRadio";
        public const string ExportYesRadioButton = "quoteSaveAsOrderExport_yesRadio";
        public const string ExportProductUsage = "quoteSaveAsOrderExport_productUsage";
        public const string ExportProductCountry = "quoteSaveAsOrderExport_countryCode";
        public const string ExportComplianceNextButton = "quoteSaveAsOrderExport_next";
        public const string PaymentMethodNextButton = "quoteSaveAsOrderPayment_next";
        public const string PoNumberTextBox = "quoteSaveAsOrderPayment_poNumber";
        public const string EmailConfirmationCheckBox = "quoteSaveAsOrderEmails_Confirmation";
        public const string EmailConfirmationNextButton = "quoteSaveAsOrderEmails_next";
        public const string EmailConfirmationSendToTextBox = "quoteSaveAsOrderEmails_sendTo";
        public const string FirstPaymentMethod = "quoteSaveAsOrderPayment_method_0";
        public const string SecondPaymentMethod = "quoteSaveAsOrderPayment_method_1";
        public const string ThirdPaymentMethod = "quoteSaveAsOrderPayment_method_2";
        public const string FifthPaymentMethod = "quoteSaveAsOrderPayment_method_4";


        // Review Order
        public const string OrderReviewSaveOrder = "orderReview_createOrder";

        public const string RemainingBalnce = "payment_netTerms_balance";
        public const string CreditLimit = "payment_netTerms_creditLimit";
        public const string NakOrderError = "orderDetails_orderProcessingResults_notice";
        public const string PaymentInfoSectionArrow = "orderDetails_payment_information_Toggle";
        public const string OrderDetailsRemainingBalance = "orderDetails_payment_information_netterms1_cardholdername";
        public const string OrderReviewGmorLastButton = "bootstro_lastBtn";
        public const string OrderReviewGmorNextButton = "bootstro_nextBtn";
        public const string OrderReviewPaymentInfoSectionArrow = "orderReview_payment_information_Toggle";
        public const string OrderReviewRemainingBalance = "orderReview_payment_information_netterms1_cardholdername";
        
        public const string OrderSavePoAmount = "quoteSaveAsOrderExport_sendPoRequest_poAmount";
        public const string OrderSendPoRequest = "quoteSaveAsOrderExport_sendPoRequest_send";
        public const string OrderSendCloseSuccess = "quoteSaveAsOrderExport_sendPoRequest_close";
        public const string OrderSendPaymentNext = "quoteSaveAsOrderPayment_next";
        public const string OrderSendEmailNext = "quoteSaveAsOrderEmails_next";
        public const string ReviewOrderSummaryListPrice = "orderReview_summary_listPrice";
        public const string ReviewOrderSummarySellingPrice = "orderReview_summary_sellingPrice";
        public const string ReviewOrderSummaryDiscount = "orderReview_summary_discountPercent";
        public const string ReviewOrderSummaryTotalMargin = "orderReview_summary_marginValue";
        public const string ReviewOrderSummaryTotalShipping = "orderReview_summary_shippingAmount";
        public const string ReviewOrderSummaryTotalTax = "orderReview_summary_totalTaxAmount";

    }
}
