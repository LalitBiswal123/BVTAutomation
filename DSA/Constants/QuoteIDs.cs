namespace Dsa.Constants
{
    public static class QuoteIDs
    {
        // LSP Start
        public const string QuoteDetailsUnitListPrice = "quoteDetail_LI_PI_unitListPrice_{0}";
        public const string QuoteDetailsUnitSellingPrice = "quoteDetail_LI_PI_unitSellingPrice_{0}";
        public const string QuoteDetailsLineItemQty = "quoteDetail_LI_quantity_{0}";
        public const string QuoteDetailsSellingPrice = "quoteDetail_LI_PI_totalSellingPrice_{0}";
        public const string QuoteDetailsUnitDiscount = "quoteDetail_LI_PI_dol_{0}";
        public const string LspPopup = "_setDefaultContract";
        public const string LspPopupHeader = "_declineScript2_header";
        public const string LspPopupYesBtn = "_setDefaultContract_ok";
        public const string LspPopupNoBtn = "_setDefaultContract_cancel";
        public const string QuoteDetailsShippingMethod = "quoteDetail_LI_SI_shippingMethod_1";

        // LSP End

        // ATS Start
        public const string InventoryStatus = "quoteDetail_LI_itemInventoryStatus_{0}";
        public const string QuoteDetailsShowMore = "quoteDetail_LI_show_more_{0}";
        public const string AtsMessage = "quoteCreate_inventoryStatusValidationMsg";
        public const string RemoveItem = "quoteCreate_LI_removeItem";
        // ATS End

        // DOL Start
        public const string ItemNotificationMessage = "quoteDetail_item_validation";
        public const string DolLbl = "quoteCreate_LI_PI_unitPercent_1_label";
        public const string PromotionDiscount = "quoteCreate_LI_PI_unitPercent_{0}";
        public const string ContractDiscount = "quoteCreate_LI_PI_unitPercent_{0}";
        public const string DolPercentage = "quoteCreate_LI_PI_dolPercentage_{0}";
        public const string DolValidationMessage = "quoteCreate_item_validation";
        public const string DolPercentageQuoteDetails = "quoteDetail_LI_PI_dolPercentage_{0}";
        public const string UnitSellingPriceCreateQuote = "quoteCreate_LI_PI_unitSellingPrice_{0}";
        public const string UnitListPriceCreateQuote = "quoteCreate_LI_PI_unitPrice_{0}";

        // DOL End

        public const string QuoteSearchButton = "quoteSearch_searchButton";
        public const string ClearSearchButton = "quoteSearch_clearAction";
        public const string QuoteNameField = "quoteSearch_quoteName";
        public const string DOMSQuoteNumberField = "quoteSearch_domsQuoteNumber";
        public const string OpportunityIdField = "quoteSearch_opportunityID";
        public const string QuoteNumberField = "quoteSearch_quoteNumber";
        public const string QuoteSearchDateRangeFilter = "quoteSearch_dateRange";
        public const string EditQuoteSearchLink = "quote_searchEdit_link";

        public const string QuoteSearchFromDate = "quote_fromDate";
        public const string QuoteSearchToDate = "quote_toDate";

        public const string QuoteSearchViewRoute = "#/quote/search/";
        public const string QuoteSearchGrid = "quoteSearchResults_Grid";
        public const string QuoteSearchItemsPerPage = "quoteSearchResult_itemsPerPage";

        public const string DetailsViewRoute = "#/quote/details/QuoteNumber/{0}";
        public const string DOMSQuoteDetailsViewRoute = "#/quote/details/DomsNumber/{0}";
        public const string DetailsForVersionViewRoute = "#/quote/details/QuoteNumber/{0}?versionNumber={1}";
        private const string SendCfoViewRoute = "#/quote/sendCfo/{0}{1}/{2}";
        public const string QuoteSendCfoViewRoute = "#/quote/sendCfo/1000016382284V1/false";
        public const string QuoteSendCfoViewRouteForPreview = "#/quote/sendCfo/1000016377888V1/false";
        public const string CfoHistoryViewRoute = "#/quote/sendcfo";
        public const string QuoteEmailQueuedViewRoute = "#/quote/quoteQueuedCfo/16";

        public const string MustArriveDateId = "{0}_LI_SI_arriveByDate_{1}";

        public static readonly string LineItemDiv = "#quoteDetail_accordion_{0}";

        public static string GetViewRouteForQuoteNumber(long quoteNumber)
        {
            return string.Format(DetailsViewRoute, quoteNumber);
        }

        public static string GetViewRouteForQuoteNumber(long quoteNumber, int version)
        {
            return string.Format(DetailsForVersionViewRoute, quoteNumber, version);
        }

        public static string GetViewRouteForDOMSQuoteNumber(long quoteNumber)
        {
            return string.Format(DOMSQuoteDetailsViewRoute, quoteNumber);
        }

        public static string GetQuoteSendCFORoute(int quoteNumber, string version, bool isPreviewMode)
        {
            return string.Format(SendCfoViewRoute, quoteNumber, version, isPreviewMode ? "true" : "false");
        }

        public const string QuoteTitle = "quoteDetail_title";
        public const string QuoteNumberTitle = "quoteNumber";
        public const string DetailContentId = "quoteDetail_header";
        public const string CreateOrderButton = "quoteDetail_createOrder";
        public const string SendCfoButton = "quoteDetail_sendCFO";
        public const string MoreQuoteActions = "quoteDetail_moreActions";
        public const string CopyQuoteButton = "quoteDetail_copyquote";
        public const string MergeQuotes = "quoteDetail_mergeQuotes";
        public const string QuoteResultsMergeQuotes = "quoteSearchResults_mergeQuotes";
        public const string QuoteResultsClearAll = "quoteSearchResults_mergeQuoteClearAll";
        public const string AssociateOpportunityButton = "quoteDetail_associateOpportunity";
        public const string OrderListButton = "quoteDetail_orderList";
        public const string QuoteVersion = "quoteDetail_versionToggle";
        public const string QuoteExpiredCouponMessage = "quoteDetail_validationErrorText";
        public const string QuoteStatus = "quoteDetail_quoteStatus";
        public const string eQuotePremierId = "quoteDetail_premierId";
        public const string QuotePONumber = "quoteDetail_infoTable_poNumber";
        public const string ExpirationDate = "quoteDetail_expirationDate";
        public const string QuotePONumberEntryField = "quoteDetail_poNumber";
        public const string EditPONumberButton = "quoteDetail_editPoNumber";
        public const string SavePONumberButton = "quoteDetail_savePoNumber";
        public const string CancelPONumberButton = "quoteDetail_cancelPoNumber";
        public const string OpportunityId = "quoteDetail_infoTable_dealId";
        public const string MoreActions_MergeQuote = "quoteDetail_mergeQuote";
        public const string MoreActions_SaveAsEQuote = "quoteDetail_saveAseQuote";
        public const string QuoteIsExpiredMsg = "quoteDetail_quoteExpiryErrorMessage";
        public const string EQuoteInvalidContractCodeErrorMessage = "quoteDetail_eQuoteInvalidContractCodesErrorMessage";
        public const string PremierCustomerSetModal = "quoteDetail_customerSetSection";
        public const string MergeQuoteButton = "//*[@id='quoteDetail_mergeQuote']/span";
        public const string SplitQuoteButton = "quoteDetail_splitQuote";
        public const string SendPoRequestButton = "quoteDetail_sendPoRequest";
        public const string QuoteDetailShippingAmount = "quoteDetail_summary_shippingAmount";
        public const string QuoteDetailSummaryListPrice = "quoteDetail_summary_listPrice";

        public const string MergeQuoteClearAllButton = "quoteDetail_mergeQuoteClearAll";
        public const string DetailsMergeQuoteLimitExceedMsg = "quoteDetail_mergeQuotes_warningMessage";
        public const string QuoteDetailEndUserCustNum = "quoteDetail_endUserCustomerNumber";
        public const string EditPaymentMethodButton = "quoteDetail_editPaymentMethod";
        public const string SavePaymentMethodButton = "quoteDetail_savePaymentMethod";
        public const string CancelPaymentMethodButton = "quoteDetail_cancelPaymentMethod";
        public const string AssociateOpportunityGrid = "QuoteDetail_opportunitySelectGrid";
        public const string OpportunityDealId = "quoteDetail_dealId";

        public const string QuotePaymentMethod = "{0}_financingPaymentMethod";
        public const string QuotePaymentMethodNew = "{0}_financingPaymentMethodNew";
        public const string QuoteTaxExempt = "{0}_taxExempt";
        public const string AddTagSalesRepButtonId = "{0}_addNewTagSalesRep";
        public const string NewTagSalesRepId = "{0}_tagRepNew";
        public const string TagSalesRepId = "{0}_tagRep_{1}";
        public const string DeletePrimarySalesRepButtonId = "{0}_deletePrimarySalesRep";
        public const string NewPrimarySalesRepId = "{0}_salesRepNew";
        public const string DeleteTagSalesRepId = "{0}_deleteTagSalesRep_{1}";

        public const string QuoteCreateViewRoute = "#/quote/create";
        public const string QuoteCreateDisplayMode = "quoteCreate";
        public const string QuoteCreateForm = "QuoteCreateForm";

        public const string QuoteCreateTitleId = "quoteCreate_title";
        public const string QuoteCreateHeaderGridId = "quoteCreate_header";

        public const string FinancialInformationAccordionId = "quoteCreate_financialInformationHeading";
        public const string FinancialInformationGridId = "quoteCreate_financialInformation";
        public const string DetailCustomerInformation = "quoteCreate_customer_information";
        public const string CustomerInformationToggle = "quoteDetail_customerInformationToggle";
        public const string ShippingInformationToggle = "quoteCreate_shippingInformationToggle";

        //Financial Information
        public const string CreditDetails = "quoteDetail_CreditDetails";
        public const string RemainingBalance = "quoteDetail_RemainingBalance";

        public const string CancelQuoteButtonId = "quoteCreate_cancel";
        public const string SaveQuoteButtonId = "quoteCreate_saveQuote";
        public const string AddItemButtonId = "quoteCreate_addItem";
        public const string AddItemFromOpportunityButtonId = "quoteCreate_addItemFromOpportunity";
        public const string ConfigItemButtonId = "quoteCreate_LI_configItem";
        public const string SplitItemLinkId = "quoteCreate_lineItem_split";
        public const string AccountDropDownId = "quoteCreate_opportunityAccounts";
        public const string ChooseCustomerLinkId = "quoteCreate_chooseCustomer";
        public const string SearchCustomerId = "quoteCreate_searchCustomer";
        public const string ChangeCustomerId = "quoteCreate_changeCustomer";
        public const string AccountCustomerId = "quoteCreate_accountCustomer";
        public const string CustomerNumberId = "quoteDetail_customerNumber";
        public const string CompanyNumberId = "quoteDetail_companyNumber";
        public const string QuoteNameId = "quoteCreate_quoteName";
        public const string DealId = "quoteCreate_dealId";
        public const string ExpirationDateId = "quoteCreate_expirationDate";
        public const string SaveQuoteValidationSectionId = "quoteCreate_validation";
        public const string CustomerNumberValidationMsgId = "quoteCreate_validation_customerNumber";
        public const string ContractCodeValidationMsgId = "quoteCreate_validation_contractCode";
        public const string CustomerContractCodeInputFieldId = "quoteCreate_contractCode";
        public const string QuoteContractsPickFromListLink = "quoteCreate_selectContract";
        public const string ShippingMethodValidationMsgId = "quoteCreate_validation_shippingMethod";
        public const string LineItemSellingPriceId = "quoteCreate_LI_sellingPrice_";
        public const string LineItemMarginId = "quoteCreate_LI_margin_";
        public const string LineItemMarginPercentId = "quoteCreate_LI_marginPercentage_";
        //public const string LineItemQuantityId = "quoteCreate_LI_quantity_input_";
        public const string LineItemQuantityId = "quoteCreate_LI_quantity_";
        public const string LineItemOpportunityId = "quoteCreate_LI_OpportunityLineId_";
        public const string OpportunitySearchModalId = "searchConnectxt";
        public const string OppLIsearchModalDataTableId = "opportunityLine_productGrid";
        public const string PONumberId = "quoteCreate_poNumber";
        public const string DefaultPoBoxWarningId = "quoteCreate_shippingDefault_poBoxWarning";
        public const string CustomerInformationAccordionId = "quoteCreate_contactHeading";
        public const string CustomerInformationGridId = "quoteCreate_contactAddresses";
        public const string QuoteLevelValidationMessage = "quoteCreate_copy_Quote_Validation";
        public const string ItemLevelValidationMessage = "quoteCreate_copy_Quote_Item_Validation";

        public const string ViewOppLink = "quoteCreate_viewOpportunity";
        public const string SelectEndUserCustomer = "quoteCreate_selectEndUserCustomer";
        public const string EndUserCustomerNumberId = "quoteCreate_endUserCustomerNumber";
        public const string EndUserCustomerNumberLabelId = "quoteDetail_infoTable_endUserCustomerNumber";

        public const string ChangeCustomerConfirmId = "changeCustomer_confirm";
        public const string ChangeCustomerCancel = "changeCustomer_cancel";
        public const string CustomerListGridId = "customerSelect_customerGrid";

        public const string CustomerListFilter = "customerSelect_searchFilter";
        public const string CustomerListFilterValue = "customerSelect_searchFilter_value";
        public const string CustomerListSearch = "customerSelect_searchAction";
        public const string AddressSelectGrid = "addressSelect_addressGrid";

        public const string NotesToggleId = "quoteCreate_notesToggle";
        public const string NotesGridAccordionId = "quoteCreate_notesGrid_accordion";

        public const string QuoteShippingHeadingId = "quoteCreate_shippingHeading";
        public const string QuoteShippingInformationGridId = "quoteCreate_shipping_information";

        public const string QuoteLineItemsHeader = "quoteCreate_items_header";
        //parameter gets filled when called
        public const string QuoteLineItemProductDescId = "quoteCreate_LI_productDescription_{0}";
        public const string QuoteLineItemCsSiNumber = "quoteCreate_LI_cssiNumber";
        public const string QuoteLineItemDeleteButtonId = "quoteCreate_LI_removeItem";
        public const string QuoteLineItemDisconnect = "quoteCreate_LI_disconnectOpportunityProduct";
        public const string QuoteLineItemConnect = "quoteCreate_LI_connectOpportunityProduct";
        public const string QuoteSummaryUpdateId = "quoteCreate_summary_update";

        public const string QuoteShippingOptionsHeader = "quoteCreate_shippingOptions_header";
        public const string QuoteShippingMethodId = "quoteCreate_shippingMethod";
        public const string QuoteEstimatedDeliveryDateLabel = "quoteCreate_estimatedDeliveryDate_label";
        public const string QuoteEstimatedDeliveryDate = "quoteCreate_estimatedDeliveryDate";
        public const string QuoteDefaultShipToAddressId = "quoteCreate_defaultShipToAddress";
        public const string QuotePickShippingAddressLink = "quoteCreate_chooseAddress";
        public const string QuoteAddShippingAddressLink = "quoteCreate_shippingNewAddressLink";
        public const string QuoteShippingInstructionsId = "quoteCreate_shippingInstructions";
        public const string QuoteActionPaymentOption = "quoteCreate_financingPaymentMethod";
        public const string QuoteActionTaxExempt = "quoteCreate_taxExempt";
        public const string QuoteSummarySectionId = "quoteCreate_summary";
        public const string ATSNotificationMsgId = "quoteCreate_inventoryStatusValidationMsg";

        public const string NoPaymentMethodSelectedId = "Pick a payment";
        public const string QuoteDfsStatus = "quoteCreate_dfsStatus";

        //Quote Create / Collect Email Address constants
        public const string QuoteEmailDisplayMode = "QuoteEmail";

        public const string QuoteEmailCollectAddress = "QuoteEmail_collectAddress";
        public const string QuoteEmailContinue = "QuoteEmail_continue";
        public const string QuoteEmailCancel = "QuoteEmail_cancel";
        public const string QuoteEmailClose = "QuoteEmail_close";
        public const string ItemEmailCollectAddress = "{0}_LI_SI_emailAddress_{1}";


        // Coupon related constants
        public const string AddCouponId = "{0}_addCoupon";
        public const string CouponValidationMessageDivId = "{0}_couponValidationMessage";
        public const string QuoteAppliedCouponsDivId = "{0}_appliedCoupons";

        public const string ValidCoupon = "4FQJ24KM1$BV4R"; //Valid Quote level coupon code
        public const string DnCTextBoxId = "{0}_LI_discountValue";
        public const string DiscountPercentId = "{0}_LI_discountPercent";
        public const string DnCQuoteLevelTableId = "quoteCreate_discountList";
        public const string DnCQuoteLevelAddedCoupon = "quoteCreateLI_D_discountName_" + ValidCoupon;

        public const string SummaryListPrice = "{0}_summary_listPrice";
        public const string SummaryBundlePrice = "{0}_summary_bundlePrice";
        public const string SummarySellingPrice = "{0}_summary_sellingPrice";
        public const string SummaryCostPrice = "{0}_summary_costPrice";
        public const string SummarySubtotalAmount = "{0}_summary_subtotalAmount";
        public const string SummaryShippingAmount = "{0}_summary_shippingAmount";
        public const string SummaryTotalTaxAmount = "{0}_summary_totalTaxAmount";
        public const string SummaryEcoFee = "{0}_summary_ecoFee";
        public const string SummaryFinalPrice = "{0}_summary_finalPrice";

        public const string SummaryDiscountPercentage = "{0}_summary_discountPercent";
        public const string SummaryDiscountPrice = "{0}_summary_dncDiscountPrice";
        public const string SummaryDiscountValue = "{0}_summary_discountValue";
        public const string SummaryDiscountTotalSaving = "{0}_summary_totalSavings";

        public const string SummaryMarginValue = "{0}_summary_marginValue";
        public const string SummaryMarginPercentage = "{0}_summary_marginPercentage";

        // Goal deal Ids
        public const string GoalDealId = "quoteCreate_LI_goalDealId_input_{0}";
        public const string PickFromList = "quoteCreate_selectGoalDealId_{0}";
        public const string GoalDealPopupId = "Quotecreation_goaldealsGrid";
        public const string GoalDealPopUpSelectId = "quotecreation_goaldealsGrid_select";
        public const string GoalDealDiscountLimitPopup = "changeCustomer_title"; //TODO Need to change the Pop Up title id
        public const string GoalDealDiscountLimitPopupOk = "discountLimitReached_ok";
        public const string GoalDealDiscountLimitPopupClose = "discountLimitReached_close";

        //Quote Level Validations
        public const string GoalExceedsLimitsValidation = "{0}_dealValidationErrorMessage_exceedingDealLimits";
        public const string GoalDealIdMissingValidation = "{0}_dealValidationErrorMessage_missingGoalDeal";
        public const string GoalNotWonValidation = "{0}_dealValidationErrorMessage_dealNotWon";
        public const string GoalExpiredValidation = "{0}_dealValidationErrorMessage_dealExpired";
        public const string GoalNotApplicable = "{0}_dealValidationErrorMessage_notApplicableDealId";

        //Item Level Validation 
        public const string ItemLevelGoalDealMissingValidation = "{0}_dealValidationErrorMessage_LI_dealIdMissing";
        public const string ItemLevelGoalDealNotWonValidation = "{0}_dealValidationErrorMessage_LI_dealNotWon";
        public const string ItemLevelGoalDealExpiredValidation = "{0}_dealValidationErrorMessage_LI_dealExpired";
        public const string ItemLevelGoalNotApplicable = "{0}_dealValidationErrorMessage_LI_notApplicableDealId";
        public const string ItemLevelGoalExceedsLimits = "{0}_dealValidationErrorMessage_LI_exceedingDealLimits";
        public const string ItemLevelGoalDealProductRestrictionValidation = "{0}_dealValidationErrorMessage_LI_dealRestriction";

        public const string ItemlevelContractCodeInCreateQuote = "quoteCreate_LI_contractCode_input_{0}";
        public const string SetContractAsDefaultYes = "_confirm_ok";
        public const string SetContractAsDefaultNo = "_confirm_cancel";

        public const string LineItemPromotion = "quoteCreate_LI_PI_promotionPercent_{0}";
        public const string LineItemDiscount = "quoteCreate_LI_PI_unitPercent_{0}";
        public const string TotalSellingPrice = "_LI_sellingPrice_{0}";
        public static readonly string TotalShippingPrice = "quoteCreate_LI_totalShippingAmount_{0}";
        public const string CouponMessage = "popover-content";
        public const string AddCoupon = "quoteCreate_addCoupon";
        public const string RemoveCoupon = "removeCoupon";
        public const string CouponLbl = "quoteCreateLI_D_discountName_{0}";
        public const string CouponDetailsLink = "quoteCreateLI_D_Coupon_display";
        public const string NoCouponAppliedMessage = "alert alert-info ng-scope";
        //public const string ShowMore = "quoteCreate_LI_show_more_{0}";
        public static readonly string ShowMore = "#quoteDetail_LI_show_more_{0} > div > a > i";
        public const string ExpandOption = "quoteCreate_LI_CS_Item_1_{0}";
        public const string OptionDiscount = "quoteCreate_LI_CS_discountPercent_build1_category{0}";
        public const string QuoteLevelSummaryDiscount = "quoteCreate_summary_discountPercent";
        public const string CouponDetails = "promotion_show_details";
        public const string CouponExpireDate = "expiration ng-binding";
        public const string PromotionLink = "//*[@id='quoteCreate_LI_D_financialPromos_{0}']/a";
        public const string PromotionDetails = "promotion_show_details";

        public const string QuoteDetailsCouponDetailsLink = "quoteDetailLI_D_Coupon_display";
        public const string QuoteDetailsCouponLbl = "quoteDetailLI_D_discountName_{0}";
        public const string QuoteDetailsPromotionLink = "//*[@id='quoteDetail_LI_D_financialPromos_{0}']/a";
        public const string QuoteDetailsCouponExpiredMessage = "";
        public const string QuoteDetailsSummaryDiscount = "quoteDetail_summary_discountPercent";


        //Send Quote CFO Constants 
        public const string QuoteSendCfoTitlePageHeader = "quoteSendCfo_title";
        public const string CfoSendQuoteEmailTextField = "quoteSendCfo_emailAddress";
        public const string CfoSendEmailButton = "quoteSendCfo_sendQuote";
        public const string CfoQuoteSettingsHeader = "quoteSendCfo_headerQuoteSettings";
        public const string CfoLanguageSettingsField = "quoteSendCfo_language_options";
        public const string CfoPricingDisplayField = "quoteSendCfo_pricing_options";
        public const string CfoSkuNumberDisplayField = "quoteSendCfo_skuNumberDisplay_options";
        public const string CfoBannersField = "quoteSendCfo_banners_option";
        public const string CfoFormatField = "quoteSendCfo_format_option";
        public const string CfoPreviewEmailButton = "quoteSendCfo_previewQuote";
        public const string CfoQuoteQueuedHeader = "quoteSendCfo_emailQueued";
        public const string CfoEmailGreetingTextBox = "quoteSendCfo_greeting";
        public const string CfoEmailGreetingEditButton = "quoteSendCfo_greetingEdit";
        public const string CfoEmailDefaultGreetingMessageButton = "quoteSendCfo_greetingDefaultSetting";

        public const string CfoEmailBodyTextBox = "quoteSendCfo_body";
        public const string CfoEmailBodyEditButton = "quoteSendCfo_bodyEdit";
        public const string CfoEmailDefaultBodyMessageButton = "quoteSendCfo_bodyDefaultSetting";

        public const string CfoSendQuoteEmailSubject = "quoteSendCfo_subject";
        public const string CfoAdditionalCommentsTextBox = "quoteSendCfo_comments";
        public const string CfoFaxOption = "quoteSendCfo_viaFax";
        public const string CfoFaxTextFieldId = "quoteSendCfo_faxNumber";
        public const string CfoFaxAttention = "quoteSendCfo_attention";


        //public const string CfoHistoryGrid = "cfo_historyGrid";
        public const string CfoHistoryGrid = "DataTables_div_";
        public const string CfoHistoryTitlePageHeader = "cfoHistory_CustomerOutput";
        public const string CfoHistoryDateFilter = "cfoHistory_dateRange";
        public const string CfoHistoryOutputTypeFilter = "cfoHistory_outputType";
        public const string CfoHistoryCustomerFilter = "quoteCfoSearch_customer";
        public const string CfoHistorySentByFilter = "dateRange_sentBy";
        public const string CfoHistoryRecordCheckBox = "cfoHistory_{0}";
        public const string CfoHistoryResendQuote = "resend_{0}";
        public const string CfoHistoryOutputTypeView = "view_{0}";
        public const string CfoResendHeader = "resendCFOEmail_header";
        public const string CfoResendCheckBox = "resendCFOEmail_checkBox";
        public const string CfoResendEmailTextArea = "resendCFOEmail_originalRecipients";
        public const string CfoResendSendButton = "resendCFOEmail_send";
        public const string CfoResendCancelButton = "resendCFOEmail_cancel";
        public const string CfoResendCloseButton = "resendCFOEmail_close";

        public const string CfoOutputTypePopUp = "_cfoViewDocument";
        public const string CfoOutputPopUpContent = "_viewDocumentContent";

        public const string CfoEmailPreviewHeader = "_title"; //TODO Need to change the ID according to standards
        public const string CfoCustomerOutputLink = "_CustomerOutputReport"; //TODO Need to change the ID according to standards

        public const string CustomerHoldModelId = "customerHold_title";
        public const string CustomerHoldConfirmButton = "customerHold_confirm";

        //Contracts Related Constants
        public const string ContractsListDivId = "Quotecreation_contractSelectGrid";
        public const string ContractsSelect = "quoteCreate_select_contractCode";

        public const string CurrentQuoteButton = "menu_currentQuote";

        public const string ProductLevelDiscountPercentage = "1_LI_discountPercent";
        public const string ProductLevelUnitPrice = "quoteCreate_LI_unitPrice_1";
        public const string ContractCodeErrorMessageClassName = "popover-content";
        public const string ContractExpiryErrorMessageOnItemLevel = "{0}_contractExpiryErrorMessage_contractsExpired"; //Todo: Need to be update
        public const string ContractExpiryErrorMessageOnQuoteLevel = "{0}_contractexpiryErrorText"; //Todo: Need to be update
        public const string ContractCopyQuote = "contractCopyQuoteLink"; //Todo: Need to be update

        public const string CatalogeGrid = "customerSetSelect_Grid";
        public const string CatalogSelect = "customerSetSelect_Grid_select_{0}";
        public const string QuoteExpirationDate = "quoteCreate_expirationDate";


        //-------------------------------------------------------------------------------------------------------------
        public const string QuoteSaveUpdateRevenueDisplayMode = "quoteSaveUpdateRevenue";

        public const string UpdateRevenueAssociateOpportunity = "quoteSaveUpdateRevenue_AssociateOpportunity";
        public const string UpdateRevenueCommonInfo = "quoteSaveUpdateRevenue_commonInfo";
        public const string UpdateRevenueRadioCheckBoxId = "quoteSaveUpdateRevenue_radioCheckBox";
        public const string UpdateRevenueNextButtonId = "quoteSaveUpdateRevenue_next";
        public const string UpdateRevenueSkipButtonId = "quoteSaveUpdateRevenue_skip";
        public const string NoItemsSkipUpdateRevenueButtonId = "quoteSaveUpdateRevenue_skipNoItemsToUpdate";
        public const string UpdateRevenueUpdateOpportunity = "quoteSaveUpdateRevenue_UpdateOpportunity";

        //Dell pays shipping method message id
        public const string DellPaysShippingMethodMessageId = "{0}_dellPayShippingMessageText_{1}";

        //Quote Merge
        public const string QuoteListMergeQuoteButtonId = "quoteSearchResults_mergeQuotes";
        public const string QuoteListMergeQuoteClearAllButtonId = "quoteSearchResults_mergeQuoteClearAll";
        public const string MergeQuoteLimitExceedMsgId = "quoteSearchResults_mergeQuotes_limitExceeded";
        public const string MergeQuoteModal_Title = "QuoteMerge_mergeCount";
        public const string MergeQuoteModal_MasterQuoteMag = "QuoteMerge_masterQuoteMsg";
        public const string MergeQuoteModal_Grid = "quoteMerge_Grid";
        public const string MergeQuoteModal_CreateQuote = "QuoteMerge_continue";
        public const string MergeQuoteModal_AddMoreQuote = "QuoteMerge_addMore";
        public const string MergeQuoteModal_Cancel = "QuoteMerge_cancel";
        public const string MergeQuoteModal_Close = "QuoteMerge_close";
        public const string MergeQuoteModal_MasterQuoteNOTSelected = "QuoteMerge_mergeQuotes_masterNotSelected";
        public const string MergeQuoteModal_Remove = "quoteMergeRemove_Grid_remove";
        public const string MergeQuoteModal_Undo = "quoteMergeRemove_Grid_undo";
        public const string DeclineScriptPopup = "_declineScript2";
        public const string PcRequiredScriptPopup = "_pcRequiredScript";
        public const string DeclineScriptPopupCloseButton = "_declineScript2_close";
        public const string FinancialServicesHeader = "{0}_financialServices_header";
        public const string MergeQuoteWarning = "quoteDetail_mergeQuotes_limitExceeded";

        //DFSDetails
        //public const string DfsCustomerMessage = "quoteCreate_dfsMessage";
        public const string DfsCustomerMessage = "quoteCreate_dfsEnabled_dfsMessage";
        //public const string DfsCustomerStatus = "quoteCreate_dfsStatus";
        public const string DfsCustomerStatus = "quoteCreate_dfsEnabled_dfsStatus";
        public const string DfsCustomerCreditStatus = "customerDetails_dbcCreditStatus";
        public const string DfsCustomerLeaseCreditStatus = "customerDetails_leaseCreditStatus";
        public const string DfsCustomerPaymentTerms = "quoteCreate_paymentTerm";
        public const string DfsCustomerCurrency = "quoteCreate_currency";
        public const string DfsCustomerCreditLimit = "quoteCreate_CreditLimit";
        public const string DfsCustomerCurrentBalance = "quoteCreate_CurrentBalance";
        public const string DfsCustomerFinancialInfoHeader = "quoteCreate_financialInformationHeading";

        // Admin - role
        public const string ItemAddedToggle = "quoteCreate_LI_1";
        public const string MarginLb = "quoteDetail_LI_margin_1";
        public const string ShowMoreForEachItem = "#quoteCreate_LI_show_more_1 > div > a > i";
        public const string AddNewShippingEmailAddress = "#quoteCreate_LI_SI_shippingNewEmailAddressLink_1";
        public const string SearchShippingEmailAddress = "#quoteCreate_LI_SI_searchEmailAddress_1";
        public const string CancelShippingEmailAddress = "#COM > div.modal-large.ng-scope > div > div.btn-bar > button";
        public const string ChangeShippingEmailAddress = "quoteCreate_LI_SI_shippingNewEmailAddressLink_1";
        public const string AddEmailAddressPopUp = "customerDetails_addShippingAddress_email";
        public const string SaveEmailIDbyShippingAddress = "#customerDetails_addShippingAddress_save";
        public const string ConfirmEmailIDbyShippingAddress = "#customerDetails_validateAddress_shippingAddress_validation_withSuggestion > div:nth-child(2) > div > div > input";
        public const string SelectConfirmEmailIDbyShippingAddress = "#customerDetails_validateAddress_addShippingAddress_select";
        public const string SelectFromDropDownEmailID = "customerSelect_searchFilter";
        public const string SearchEmailIDTextBox = "customerSelect_searchFilter_value";
        public const string SearchEmailIDbyShippingAddress = "customerSelect_searchAction";
        public const string SelectEmailIDbyShippingAddress = "#addressSelect_addressGrid_select";
        public const string SortEmailIDbyShippingAddress = "#addressSelect_addressGrid > div > div > table > thead > tr > th:nth-child(8)";
        // public const string MarginLable = "div.col-md-4:nth-child(3) > div:nth-child(2) > div:nth-child(2) > div:nth-child(2)";

        public const string CustomerInformationPrimaryContact = "quoteDetail_primaryContactName";
    }
}
