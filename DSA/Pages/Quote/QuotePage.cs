using Dell.Adept.UI.Web.Pages;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Linq;

namespace Dsa.Pages.Quote
{
    public class QuotePage: DsaPageBase
    {
        static string lineItemPagePrefix = "quoteCreate";
        public QuotePage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        public QuotePage(IWebDriver webDriver, string pagePrefix) : base(webDriver)
        {
            if (!string.IsNullOrEmpty(pagePrefix))
            {
                lineItemPagePrefix = pagePrefix + "_";
            }
            else
            {
                lineItemPagePrefix = pagePrefix;
            }

            PageFactory.InitElements(webDriver, this);
            webDriver.VerifyBusyOverlayNotDisplayed();
        }

        #region Elements

        
        

public IWebElement QuoteDetailsUnitListPrice { get { return WebDriver.GetElement(By.Id("quoteDetail_LI_PI_unitListPrice_{0}")); } }


public IWebElement QuoteDetailsUnitSellingPrice { get { return WebDriver.GetElement(By.Id("quoteDetail_LI_PI_unitSellingPrice_{0}")); } }


public IWebElement QuoteDetailsLineItemQty { get { return WebDriver.GetElement(By.Id("quoteDetail_LI_quantity_{0}")); } }


public IWebElement QuoteDetailsSellingPrice { get { return WebDriver.GetElement(By.Id("quoteDetail_LI_PI_totalSellingPrice_{0}")); } }


public IWebElement QuoteDetailsUnitDiscount { get { return WebDriver.GetElement(By.Id("quoteDetail_LI_PI_dol_{0}")); } }


public IWebElement LspPopup { get { return WebDriver.GetElement(By.Id("_setDefaultContract")); } }


public IWebElement HdrLspPopup { get { return WebDriver.GetElement(By.Id("_declineScript2_header")); } }


public IWebElement LspPopupYesBtn { get { return WebDriver.GetElement(By.Id("_setDefaultContract_ok")); } }


public IWebElement LspPopupNoBtn { get { return WebDriver.GetElement(By.Id("_setDefaultContract_cancel")); } }


public IWebElement QuoteDetailsShippingMethod { get { return WebDriver.GetElement(By.Id("quoteDetail_LI_SI_shippingMethod_1")); } }


public IWebElement QuoteDetailsSmartPriceRevenu { get { return WebDriver.GetElement(By.Id("quoteDetail_LI_PI_unitCompRevenue_{0}")); } }


public IWebElement HdrSummary { get { return WebDriver.GetElement(By.Id("{0}_summary_header")); } }


public IWebElement LblListPrice { get { return WebDriver.GetElement(By.Id("{0}_summary_listPrice")); } }


public IWebElement LblSellingPrice { get { return WebDriver.GetElement(By.Id("{0}_summary_sellingPrice")); } }


public IWebElement LblDiscountPercent { get { return WebDriver.GetElement(By.Id("{0}_summary_discountPercent")); } }


public IWebElement LblMarginValue { get { return WebDriver.GetElement(By.Id("{0}_summary_marginValue")); } }


public IWebElement LblShippingPriceAmount { get { return WebDriver.GetElement(By.Id("{0}_summary_shippingPriceAmount")); } }


public IWebElement LblShippingDiscount { get { return WebDriver.GetElement(By.Id("{0}_summary_shippingDiscountAmount")); } }


public IWebElement LblSubtotalAmount { get { return WebDriver.GetElement(By.Id("{0}_summary_subtotalAmount")); } }


public IWebElement LblShippingAmount { get { return WebDriver.GetElement(By.Id("{0}_summary_shippingAmount")); } }


public IWebElement LblTotalTaxAmount { get { return WebDriver.GetElement(By.Id("{0}_summary_totalTaxAmount")); } }


public IWebElement LblEcoFee { get { return WebDriver.GetElement(By.Id("{0}_summary_ecoFee")); } }


public IWebElement LblFinalPrice { get { return WebDriver.GetElement(By.Id("{0}_summary_finalPrice")); } }


public IWebElement Update { get { return WebDriver.GetElement(By.Id("_lineItem_update")); } }


public IWebElement LblUpdatePriceSummary { get { return WebDriver.GetElement(By.Id("_summary_update")); } }


public IWebElement InventoryStatus { get { return WebDriver.GetElement(By.Id("quoteDetail_LI_itemInventoryStatus_{0}")); } }


public IWebElement QuoteDetailsShowMore { get { return WebDriver.GetElement(By.Id("quoteDetail_LI_show_more_{0}")); } }


public IWebElement AtsMessage { get { return WebDriver.GetElement(By.Id("quoteCreate_inventoryStatusValidationMsg")); } }


public IWebElement RemoveItem { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_removeItem")); } }


public IWebElement ItemNotificationMessage { get { return WebDriver.GetElement(By.Id("quoteDetail_item_validation")); } }


public IWebElement LblDol { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_PI_unitPercent_1_label")); } }


public IWebElement PromotionDiscount { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_PI_unitPercent_{0}")); } }


public IWebElement ContractDiscount { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_PI_unitPercent_{0}")); } }


public IWebElement DolPercentage { get { return WebDriver.GetElement(By.CssSelector("#{0}_LI_PI_dolPercentage_{1} > input")); } }


public IWebElement DolValidationMessage { get { return WebDriver.GetElement(By.Id("quoteCreate_item_validation")); } }


public IWebElement DolPercentageQuoteDetails { get { return WebDriver.GetElement(By.Id("quoteDetail_LI_PI_dolPercentage_{0}")); } }


public IWebElement UnitSellingPrice { get { return WebDriver.GetElement(By.Id("{0}_LI_PI_unitSellingPrice_{1}")); } }


public IWebElement UnitListPrice { get { return WebDriver.GetElement(By.Id("{0}_LI_PI_unitPrice_{1}")); } }


public IWebElement UnitCostPrice { get { return WebDriver.GetElement(By.Id("{0}_LI_PI_unitCost_{1}")); } }


public IWebElement UnitDiscount { get { return WebDriver.GetElement(By.Id("{0}_LI_PI_dol_{1}")); } }


public IWebElement UnitSmartPriceRevenue { get { return WebDriver.GetElement(By.Id("{0}_LI_PI_unitCompRevenue_{1")); } }


public IWebElement UnitMargin { get { return WebDriver.GetElement(By.Id("{0}_LI_PI_unitMargin_{1}")); } }


public IWebElement Promotions { get { return WebDriver.GetElement(By.Id("{0}_LI_PI_unitPercent_{1}")); } }


public IWebElement Quanitity { get { return WebDriver.GetElement(By.Id("{0}_LI_quantity_input_{1}")); } }


public IWebElement ListPrice { get { return WebDriver.GetElement(By.Id("{0}_LI_totalListPrice_{1}")); } }


public IWebElement Cost { get { return WebDriver.GetElement(By.Id("{0}_LI_cost_{1}")); } }


public IWebElement Discount { get { return WebDriver.GetElement(By.Id("{0}_LI_totalDiscountPercent_{1}")); } }


public IWebElement SellingPrice { get { return WebDriver.GetElement(By.Id("{0}_LI_unitPrice_{1}")); } }


public IWebElement SmartPriceRevenue { get { return WebDriver.GetElement(By.Id("{0}_LI_compRevenue_{1}")); } }


public IWebElement Margin { get { return WebDriver.GetElement(By.Id("{0}_LI_margin_{1}")); } }


public IWebElement SubTotal { get { return WebDriver.GetElement(By.Id("{0}_LI_sellingPrice_{1}")); } }


public IWebElement TotalCost { get { return WebDriver.GetElement(By.Id("{0}_LI_sellingPrice_{1}")); } }


public IWebElement TotalShipping { get { return WebDriver.GetElement(By.Id("{0}_LI_totalShippingAmount_{1}")); } }


public IWebElement TotalTax { get { return WebDriver.GetElement(By.Id("{0}_LI_tax_{1}")); } }


public IWebElement TotalEcoFee { get { return WebDriver.GetElement(By.Id("{0}_LI_ecoFee_{1}")); } }


public IWebElement TotalAmount { get { return WebDriver.GetElement(By.Id("{0}_LI_totalAmount_{1}")); } }


public IWebElement FullFillmentTime { get { return WebDriver.GetElement(By.Id("{0}_LI_itemBuildTime_{1}")); } }


public IWebElement OrderCode { get { return WebDriver.GetElement(By.Id("{0}_LI_orderCode_{1}")); } }


public IWebElement TaxType { get { return WebDriver.GetElement(By.Id("{0}_LI_PI_taxType_{1}")); } }


public IWebElement TaxRate { get { return WebDriver.GetElement(By.Id("{0}_LI_PI_taxRate_{1}")); } }


public IWebElement TaxableAmount { get { return WebDriver.GetElement(By.Id("{0}_LI_PI_taxableAmount_{1")); } }


public IWebElement TaxAmount { get { return WebDriver.GetElement(By.Id("{0}_LI_PI_taxAmount_{1")); } }


public IWebElement StateEnvironmentalFee { get { return WebDriver.GetElement(By.Id("{0}_LI_PI_stateEnvFee_{1}")); } }


public IWebElement EmailAddress { get { return WebDriver.GetElement(By.Id("{0}_LI_SI_emailAddress_{1}")); } }


public IWebElement MustArriveByDate { get { return WebDriver.GetElement(By.Id("{0}_LI_SI_arriveByDate_{1}")); } }


public IWebElement Edd { get { return WebDriver.GetElement(By.Id("{0}_LI_SI_estimatedDeliveryDate_{1}")); } }


public IWebElement BtnQuoteSearch { get { return WebDriver.GetElement(By.Id("quoteSearch_searchButton")); } }


public IWebElement BtnClearSearch { get { return WebDriver.GetElement(By.Id("quoteSearch_clearAction")); } }


public IWebElement TxtQuoteName { get { return WebDriver.GetElement(By.Id("quoteSearch_quoteName")); } }


public IWebElement TxtDOMSQuoteNumber { get { return WebDriver.GetElement(By.Id("quoteSearch_domsQuoteNumber")); } }


public IWebElement TxtOpportunityId { get { return WebDriver.GetElement(By.Id("quoteSearch_opportunityID")); } }


public IWebElement TxtQuoteNumber { get { return WebDriver.GetElement(By.Id("quoteSearch_quoteNumber")); } }


public IWebElement QuoteSearchDateRangeFilter { get { return WebDriver.GetElement(By.Id("quoteSearch_dateRange")); } }


public IWebElement TxtQuoteSearchSalesRepId { get { return WebDriver.GetElement(By.Id("quoteSearch_salesRepId")); } }


public IWebElement LnkEditQuoteSearch { get { return WebDriver.GetElement(By.Id("quote_searchEdit_link")); } }


public IWebElement QuoteSearchFromDate { get { return WebDriver.GetElement(By.Id("quote_fromDate")); } }


public IWebElement QuoteSearchToDate { get { return WebDriver.GetElement(By.Id("quote_toDate")); } }


public IWebElement QuoteSearchViewRoute { get { return WebDriver.GetElement(By.XPath("#/quote/search/")); } }


public IWebElement QuoteSearchGrid { get { return WebDriver.GetElement(By.Id("quoteSearchResults_Grid")); } }


public IWebElement QuoteSearchItemsPerPage { get { return WebDriver.GetElement(By.Id("quoteSearchResult_itemsPerPage")); } }


public IWebElement DetailsViewRoute { get { return WebDriver.GetElement(By.XPath("#/quote/details/QuoteNumber/{0}")); } }


public IWebElement DOMSQuoteDetailsViewRoute { get { return WebDriver.GetElement(By.XPath("#/quote/details/DomsNumber/{0}")); } }


public IWebElement DetailsForVersionViewRoute { get { return WebDriver.GetElement(By.XPath("#/quote/details/QuoteNumber/{0}?versionNumber={1}")); } }


public IWebElement QuoteSendCfoViewRoute { get { return WebDriver.GetElement(By.XPath("#/quote/sendCfo/1000016382284V1/false")); } }


public IWebElement QuoteSendCfoViewRouteForPreview { get { return WebDriver.GetElement(By.XPath("#/quote/sendCfo/1000016377888V1/false")); } }


public IWebElement CfoHistoryViewRoute { get { return WebDriver.GetElement(By.XPath("#/quote/sendcfo")); } }


public IWebElement QuoteEmailQueuedViewRoute { get { return WebDriver.GetElement(By.XPath("#/quote/quoteQueuedCfo/16")); } }


public IWebElement MustArriveDateId { get { return WebDriver.GetElement(By.Id("{0}_LI_SI_arriveByDate_{1}")); } }


public IWebElement NonTiedDolOffList { get { return WebDriver.GetElement(By.Id("quoteCreate_Sku_discount_input_{0}")); } }


public IWebElement NonTiedUnitSellingPrice { get { return WebDriver.GetElement(By.CssSelector("#quoteCreate_Sku-PI_unitSellingPrice_{0} > input:nth-child(1)")); } }


public IWebElement NonTiedQuantity { get { return WebDriver.GetElement(By.Id("quoteCreate_Sku_quantity_input_{0}")); } }


public IWebElement QuoteTitle { get { return WebDriver.GetElement(By.Id("quoteDetail_title")); } }


public IWebElement QuoteNumberTitle { get { return WebDriver.GetElement(By.Id("quoteNumber")); } }


public IWebElement DetailContentId { get { return WebDriver.GetElement(By.Id("quoteDetail_header")); } }


public IWebElement BtnCreateOrder { get { return WebDriver.GetElement(By.Id("quoteDetail_createOrder")); } }


public IWebElement BtnSendCfo { get { return WebDriver.GetElement(By.Id("quoteDetail_sendCFO")); } }


public IWebElement MoreQuoteActions { get { return WebDriver.GetElement(By.Id("quoteDetail_moreActions")); } }


public IWebElement BtnCopyQuote { get { return WebDriver.GetElement(By.Id("quoteDetail_copyQuote")); } }


public IWebElement MergeQuotes { get { return WebDriver.GetElement(By.Id("quoteDetail_mergeQuotes")); } }


public IWebElement QuoteResultsMergeQuotes { get { return WebDriver.GetElement(By.Id("quoteSearchResults_mergeQuotes")); } }


public IWebElement QuoteResultsClearAll { get { return WebDriver.GetElement(By.Id("quoteSearchResults_mergeQuoteClearAll")); } }


public IWebElement BtnAssociateOpportunity { get { return WebDriver.GetElement(By.Id("quoteDetail_associateOpportunity")); } }


public IWebElement BtnOrderList { get { return WebDriver.GetElement(By.Id("quoteDetail_orderList")); } }


public IWebElement QuoteVersion { get { return WebDriver.GetElement(By.Id("quoteDetail_versionToggle")); } }


public IWebElement QuoteExpiredCouponMessage { get { return WebDriver.GetElement(By.Id("quoteDetail_validationErrorText")); } }


public IWebElement QuoteStatus { get { return WebDriver.GetElement(By.Id("quoteDetail_quoteStatus")); } }


public IWebElement eQuotePremierId { get { return WebDriver.GetElement(By.Id("quoteDetail_premierId")); } }


public IWebElement QuotePONumber { get { return WebDriver.GetElement(By.Id("quoteDetail_infoTable_poNumber")); } }


public IWebElement ExpirationDate { get { return WebDriver.GetElement(By.Id("quoteDetail_expirationDate")); } }


public IWebElement QuotePONumberEntryField { get { return WebDriver.GetElement(By.Id("quoteDetail_poNumber")); } }


public IWebElement BtnEditPONumber { get { return WebDriver.GetElement(By.Id("quoteDetail_editPoNumber")); } }


public IWebElement BtnSavePONumber { get { return WebDriver.GetElement(By.Id("quoteDetail_savePoNumber")); } }


public IWebElement BtnCancelPONumber { get { return WebDriver.GetElement(By.Id("quoteDetail_cancelPoNumber")); } }


public IWebElement OpportunityId { get { return WebDriver.GetElement(By.Id("quoteDetail_infoTable_dealId")); } }


public IWebElement MoreActions_MergeQuote { get { return WebDriver.GetElement(By.Id("quoteDetail_mergeQuote")); } }


public IWebElement MoreActions_SaveAsEQuote { get { return WebDriver.GetElement(By.Id("quoteDetail_saveAseQuote")); } }


public IWebElement QuoteIsExpiredMsg { get { return WebDriver.GetElement(By.Id("quoteDetail_quoteExpiryErrorMessage")); } }


public IWebElement EQuoteInvalidContractCodeErrorMessage { get { return WebDriver.GetElement(By.Id("quoteDetail_eQuoteInvalidContractCodesErrorMessage")); } }


public IWebElement PremierCustomerSetModal { get { return WebDriver.GetElement(By.Id("quoteDetail_customerSetSection")); } }


public IWebElement BtnMergeQuote { get { return WebDriver.GetElement(By.Id("quoteDetail_mergeQuote")); } }


public IWebElement BtnSplitQuote { get { return WebDriver.GetElement(By.Id("quoteDetail_splitQuote")); } }


public IWebElement BtnSendPoRequest { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest")); } }


public IWebElement QuoteDetailShippingAmount { get { return WebDriver.GetElement(By.Id("quoteDetail_summary_shippingAmount")); } }


public IWebElement QuoteResultsPerPage { get { return WebDriver.GetElement(By.Id("quoteSearchResult_itemsPerPage")); } }


public IWebElement BtnMergeQuoteClearAll { get { return WebDriver.GetElement(By.Id("quoteDetail_mergeQuoteClearAll")); } }


public IWebElement DetailsMergeQuoteLimitExceedMsg { get { return WebDriver.GetElement(By.Id("quoteDetail_mergeQuotes_warningMessage")); } }


public IWebElement QuoteDetailEndUserCustNum { get { return WebDriver.GetElement(By.Id("quoteDetail_endUserCustomerNumber")); } }


public IWebElement BtnEditPaymentMethod { get { return WebDriver.GetElement(By.Id("quoteDetail_editPaymentMethod")); } }


public IWebElement BtnSavePaymentMethod { get { return WebDriver.GetElement(By.Id("quoteDetail_savePaymentMethod")); } }


public IWebElement BtnCancelPaymentMethod { get { return WebDriver.GetElement(By.Id("quoteDetail_cancelPaymentMethod")); } }


public IWebElement AssociateOpportunityGrid { get { return WebDriver.GetElement(By.Id("QuoteDetail_opportunitySelectGrid")); } }


public IWebElement OpportunityDealId { get { return WebDriver.GetElement(By.Id("quoteDetail_dealId")); } }


public IWebElement QuotePaymentMethod { get { return WebDriver.GetElement(By.Id("{0}_financingPaymentMethod")); } }


public IWebElement QuotePaymentMethodNew { get { return WebDriver.GetElement(By.Id("{0}_financingPaymentMethodNew")); } }


public IWebElement QuoteTaxExempt { get { return WebDriver.GetElement(By.Id("{0}_taxExempt")); } }


public IWebElement BtnAddTagSalesRep { get { return WebDriver.GetElement(By.Id("{0}_addNewTagSalesRep")); } }


public IWebElement NewTagSalesRepId { get { return WebDriver.GetElement(By.Id("{0}_tagRepNew")); } }


public IWebElement TagSalesRepId { get { return WebDriver.GetElement(By.Id("{0}_tagRep_{1}")); } }


public IWebElement BtnDeletePrimarySalesRepId { get { return WebDriver.GetElement(By.Id("{0}_deletePrimarySalesRep")); } }


public IWebElement NewPrimarySalesRepId { get { return WebDriver.GetElement(By.Id("{0}_salesRepNew")); } }


public IWebElement DeleteTagSalesRepId { get { return WebDriver.GetElement(By.Id("{0}_deleteTagSalesRep_{1}")); } }


public IWebElement QuoteCreateViewRoute { get { return WebDriver.GetElement(By.XPath("#/quote/create")); } }


public IWebElement QuoteCreateDisplayMode { get { return WebDriver.GetElement(By.Id("quoteCreate")); } }


public IWebElement QuoteCreateForm { get { return WebDriver.GetElement(By.Id("QuoteCreateForm")); } }


public IWebElement QuoteCreateTitleId { get { return WebDriver.GetElement(By.Id("quoteCreate_title")); } }


public IWebElement HdrQuoteCreateGridId { get { return WebDriver.GetElement(By.Id("quoteCreate_header")); } }


public IWebElement FinancialInformationAccordionId { get { return WebDriver.GetElement(By.Id("quoteCreate_financialInformationHeading")); } }


public IWebElement FinancialInformationGridId { get { return WebDriver.GetElement(By.Id("quoteCreate_financialInformation")); } }


public IWebElement DetailCustomerInformation { get { return WebDriver.GetElement(By.Id("quoteCreate_customer_information")); } }


public IWebElement QuoteDetailCustomerInformationToggle { get { return WebDriver.GetElement(By.Id("quoteDetail_customerInformationToggle")); } }


public IWebElement ShippingInformationToggle { get { return WebDriver.GetElement(By.Id("quoteCreate_shippingInformationToggle")); } }


public IWebElement CustomerInformationToggle { get { return WebDriver.GetElement(By.Id("quoteCreate_customerInformationToggle")); } }


public IWebElement HdrCustomerInformation { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_contactHeading')]/div/span[1)]/span")); } }


public IWebElement CustomerId { get { return WebDriver.GetElement(By.Id("quoteCreate_customerId")); } }


public IWebElement CustomerNumber { get { return WebDriver.GetElement(By.Id("quoteCreate_customerNumber")); } }


public IWebElement CompanyName { get { return WebDriver.GetElement(By.Id("quoteCreate_companyName")); } }


public IWebElement CompanyNumber { get { return WebDriver.GetElement(By.Id("quoteCreate_companyNumber")); } }


public IWebElement CustomerClass { get { return WebDriver.GetElement(By.Id("quoteCreate_customerClass")); } }


public IWebElement ParentReference { get { return WebDriver.GetElement(By.Id("quoteCreate_parentReference")); } }


public IWebElement Channel { get { return WebDriver.GetElement(By.Id("quoteCreate_channel")); } }


public IWebElement ContactCfoLanguage { get { return WebDriver.GetElement(By.Id("quoteCreate_contactCFOLang")); } }


public IWebElement LegacyFreeShipping { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_chargeShippingPrice')]/div")); } }


public IWebElement Address1 { get { return WebDriver.GetElement(By.Id("quoteCreate_address1")); } }


public IWebElement Address2 { get { return WebDriver.GetElement(By.Id("quoteCreate_address2")); } }


public IWebElement City { get { return WebDriver.GetElement(By.Id("quoteCreate_city")); } }


public IWebElement State { get { return WebDriver.GetElement(By.Id("quoteCreate_state")); } }


public IWebElement PostalCode { get { return WebDriver.GetElement(By.Id("quoteCreate_zip")); } }


public IWebElement Country { get { return WebDriver.GetElement(By.Id("quoteCreate_primaryContactCountry")); } }


public IWebElement PrimaryContactName { get { return WebDriver.GetElement(By.Id("quoteCreate_primaryContactName")); } }


public IWebElement Department { get { return WebDriver.GetElement(By.Id("quoteCreate_department")); } }


public IWebElement Email { get { return WebDriver.GetElement(By.Id("quoteCreate_email")); } }


public IWebElement Telephone { get { return WebDriver.GetElement(By.Id("quoteCreate_telephone")); } }


public IWebElement CreditDetails { get { return WebDriver.GetElement(By.Id("quoteDetail_CreditDetails")); } }


public IWebElement BtnCancelQuoteId { get { return WebDriver.GetElement(By.Id("quoteCreate_cancel")); } }


public IWebElement BtnSaveQuoteId { get { return WebDriver.GetElement(By.Id("quoteCreate_saveQuote")); } }


public IWebElement BtnAddItemId { get { return WebDriver.GetElement(By.Id("quoteCreate_addItem")); } }


public IWebElement BtnAddItemFromOpportunityId { get { return WebDriver.GetElement(By.Id("quoteCreate_addItemFromOpportunity")); } }


public IWebElement BtnConfigItemId { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_configItem")); } }


public IWebElement LnkSplitItemId { get { return WebDriver.GetElement(By.Id("quoteCreate_lineItem_split")); } }


public IWebElement DdlAccountId { get { return WebDriver.GetElement(By.Id("quoteCreate_opportunityAccounts")); } }


public IWebElement LnkChooseCustomerId { get { return WebDriver.GetElement(By.Id("quoteCreate_chooseCustomer")); } }


public IWebElement SearchCustomerId { get { return WebDriver.GetElement(By.Id("quoteCreate_searchCustomer")); } }


public IWebElement ChangeCustomerId { get { return WebDriver.GetElement(By.Id("quoteCreate_changeCustomer")); } }


public IWebElement AccountCustomerId { get { return WebDriver.GetElement(By.Id("quoteCreate_accountCustomer")); } }


public IWebElement CustomerNumberId { get { return WebDriver.GetElement(By.Id("quoteCreate_customerNumber")); } }


public IWebElement QuoteNameId { get { return WebDriver.GetElement(By.Id("quoteCreate_quoteName")); } }


public IWebElement DealId { get { return WebDriver.GetElement(By.Id("quoteCreate_dealId")); } }


public IWebElement ExpirationDateId { get { return WebDriver.GetElement(By.Id("quoteCreate_expirationDate")); } }


public IWebElement SaveQuoteValidationSectionId { get { return WebDriver.GetElement(By.Id("quoteCreate_validation")); } }


public IWebElement CustomerNumberValidationMsgId { get { return WebDriver.GetElement(By.Id("quoteCreate_validation_customerNumber")); } }


public IWebElement ContractCodeValidationMsgId { get { return WebDriver.GetElement(By.Id("quoteCreate_validation_contractCode")); } }


public IWebElement CustomerContractCodeInputFieldId { get { return WebDriver.GetElement(By.Id("quoteCreate_contractCode")); } }


public IWebElement LnkQuoteContractsPickFromList { get { return WebDriver.GetElement(By.Id("quoteCreate_selectContract")); } }


public IWebElement ShippingMethodValidationMsgId { get { return WebDriver.GetElement(By.Id("quoteCreate_validation_shippingMethod")); } }


public IWebElement LineItemSellingPriceId { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_sellingPrice_")); } }


public IWebElement LineItemMarginId { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_margin_")); } }


public IWebElement LineItemMarginPercentId { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_marginPercentage_")); } }


public IWebElement LineItemQuantityId { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_quantity_input_{0}")); } }


public IWebElement LineItemOpportunityId { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_OpportunityLineId_")); } }


public IWebElement OpportunitySearchModalId { get { return WebDriver.GetElement(By.Id("searchConnectxt")); } }


public IWebElement OppLIsearchModalDataTableId { get { return WebDriver.GetElement(By.Id("opportunityLine_productGrid")); } }


public IWebElement PONumberId { get { return WebDriver.GetElement(By.Id("quoteCreate_poNumber")); } }


public IWebElement DefaultPoBoxWarningId { get { return WebDriver.GetElement(By.Id("ABCquoteCreate_shippingDefault_poBoxWarning")); } }


public IWebElement CustomerInformationAccordionId { get { return WebDriver.GetElement(By.Id("quoteCreate_contactHeading")); } }


public IWebElement CustomerInformationGridId { get { return WebDriver.GetElement(By.Id("quoteCreate_contactAddresses")); } }


public IWebElement QuoteLevelValidationMessage { get { return WebDriver.GetElement(By.Id("quoteCreate_copy_Quote_Validation")); } }


public IWebElement ItemLevelValidationMessage { get { return WebDriver.GetElement(By.Id("quoteCreate_copy_Quote_Item_Validation")); } }


public IWebElement LnkViewOpp { get { return WebDriver.GetElement(By.Id("quoteCreate_viewOpportunity")); } }


public IWebElement SelectEndUserCustomer { get { return WebDriver.GetElement(By.Id("quoteCreate_selectEndUserCustomer")); } }


public IWebElement EndUserCustomerNumberId { get { return WebDriver.GetElement(By.Id("quoteCreate_endUserCustomerNumber")); } }


public IWebElement LblEndUserCustomerNumber { get { return WebDriver.GetElement(By.Id("quoteDetail_infoTable_endUserCustomerNumber")); } }


public IWebElement ChangeCustomerConfirmId { get { return WebDriver.GetElement(By.Id("changeCustomer_confirm")); } }


public IWebElement ChangeCustomerCancel { get { return WebDriver.GetElement(By.Id("changeCustomer_cancel")); } }


public IWebElement CustomerListGridId { get { return WebDriver.GetElement(By.Id("customerSelect_customerGrid")); } }


public IWebElement CustomerListFilter { get { return WebDriver.GetElement(By.Id("customerSelect_searchFilter")); } }


public IWebElement CustomerListFilterValue { get { return WebDriver.GetElement(By.Id("customerSelect_searchFilter_value")); } }


public IWebElement CustomerListSearch { get { return WebDriver.GetElement(By.Id("customerSelect_searchAction")); } }


public IWebElement AddressSelectGrid { get { return WebDriver.GetElement(By.Id("addressSelect_addressGrid")); } }


public IWebElement NotesToggleId { get { return WebDriver.GetElement(By.Id("quoteCreate_notesToggle")); } }


public IWebElement NotesGridAccordionId { get { return WebDriver.GetElement(By.Id("quoteCreate_notesGrid_accordion")); } }


public IWebElement QuoteShippingHeadingId { get { return WebDriver.GetElement(By.Id("quoteCreate_shippingHeading")); } }


public IWebElement QuoteShippingInformationGridId { get { return WebDriver.GetElement(By.Id("quoteCreate_shipping_information")); } }


public IWebElement HdrQuoteLineItems { get { return WebDriver.GetElement(By.Id("quoteCreate_items_header")); } }


public IWebElement QuoteLineItemProductDescId { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_productDescription_{0}")); } }


public IWebElement QuoteLineItemCsSiNumber { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_cssiNumber_")); } }


public IWebElement BtnQuoteLineItemDeleteId { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_removeItem")); } }


public IWebElement QuoteLineItemDisconnect { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_disconnectOpportunityProduct")); } }


public IWebElement QuoteLineItemConnect { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_connectOpportunityProduct")); } }


public IWebElement QuoteSummaryUpdateId { get { return WebDriver.GetElement(By.Id("quoteCreate_summary_update")); } }


public IWebElement HdrQuoteShippingOptions { get { return WebDriver.GetElement(By.Id("quoteCreate_shippingOptions_header")); } }


public IWebElement QuoteShippingMethodId { get { return WebDriver.GetElement(By.Id("quoteCreate_shippingMethod")); } }


public IWebElement LblQuoteEstimatedDeliveryDate { get { return WebDriver.GetElement(By.Id("quoteCreate_estimatedDeliveryDate_label")); } }


public IWebElement QuoteEstimatedDeliveryDate { get { return WebDriver.GetElement(By.Id("quoteCreate_estimatedDeliveryDate")); } }


public IWebElement QuoteDefaultShipToAddressId { get { return WebDriver.GetElement(By.Id("quoteCreate_defaultShipToAddress")); } }


public IWebElement LnkQuotePickShippingAddress { get { return WebDriver.GetElement(By.Id("quoteCreate_chooseAddress")); } }


public IWebElement LnkQuoteAddShippingAddress { get { return WebDriver.GetElement(By.Id("quoteCreate_shippingNewAddressLink")); } }


public IWebElement QuoteShippingInstructionsId { get { return WebDriver.GetElement(By.Id("quoteCreate_shippingInstructions")); } }


public IWebElement QuoteActionPaymentOption { get { return WebDriver.GetElement(By.Id("quoteCreate_financingPaymentMethod")); } }


public IWebElement QuoteActionTaxExempt { get { return WebDriver.GetElement(By.Id("quoteCreate_taxExempt")); } }


public IWebElement QuoteSummarySectionId { get { return WebDriver.GetElement(By.Id("quoteCreate_summary")); } }


public IWebElement ATSNotificationMsgId { get { return WebDriver.GetElement(By.Id("quoteCreate_inventoryStatusValidationMsg")); } }


public IWebElement NoPaymentMethodSelectedId { get { return WebDriver.GetElement(By.Id("Pick a payment")); } }


public IWebElement QuoteDfsStatus { get { return WebDriver.GetElement(By.Id("quoteCreate_dfsStatus")); } }


public IWebElement QuoteEmailDisplayMode { get { return WebDriver.GetElement(By.Id("QuoteEmail")); } }


public IWebElement QuoteEmailCollectAddress { get { return WebDriver.GetElement(By.Id("QuoteEmail_collectAddress")); } }


public IWebElement QuoteEmailContinue { get { return WebDriver.GetElement(By.Id("QuoteEmail_continue")); } }


public IWebElement QuoteEmailCancel { get { return WebDriver.GetElement(By.Id("QuoteEmail_cancel")); } }


public IWebElement QuoteEmailClose { get { return WebDriver.GetElement(By.Id("QuoteEmail_close")); } }


public IWebElement ItemEmailCollectAddress { get { return WebDriver.GetElement(By.Id("{0}_LI_SI_emailAddress_{1}")); } }


public IWebElement AddCouponId { get { return WebDriver.GetElement(By.Id("{0}_addCoupon")); } }


public IWebElement DivCouponValidationMessageId { get { return WebDriver.GetElement(By.Id("{0}_couponValidationMessage")); } }


public IWebElement DivQuoteAppliedCouponsId { get { return WebDriver.GetElement(By.Id("{0}_appliedCoupons")); } }


public IWebElement ValidCoupon { get { return WebDriver.GetElement(By.Id("4FQJ24KM1$BV4R")); } }
        //Valid Quote level coupon code

public IWebElement TxtDnCId { get { return WebDriver.GetElement(By.Id("{0}_LI_discountValue")); } }


public IWebElement DiscountPercentId { get { return WebDriver.GetElement(By.Id("{0}_LI_discountPercent")); } }


public IWebElement DnCQuoteLevelTableId { get { return WebDriver.GetElement(By.Id("quoteCreate_discountList")); } }


public IWebElement DnCQuoteLevelAddedCoupon { get { return WebDriver.GetElement(By.Id("quoteCreateLI_D_discountName_")); } }


public IWebElement SummaryListPrice { get { return WebDriver.GetElement(By.Id("{0}_summary_listPrice")); } }


public IWebElement SummarySellingPrice { get { return WebDriver.GetElement(By.Id("{0}_summary_sellingPrice")); } }


public IWebElement SummaryCostPrice { get { return WebDriver.GetElement(By.Id("{0}_summary_costPrice")); } }


public IWebElement SummarySubtotalAmount { get { return WebDriver.GetElement(By.Id("{0}_summary_subtotalAmount")); } }


public IWebElement SummaryShippingAmount { get { return WebDriver.GetElement(By.Id("{0}_summary_shippingAmount")); } }


public IWebElement SummarySmartPriceRevenue { get { return WebDriver.GetElement(By.Id("{0}_summary_compRevenue")); } }


public IWebElement SummaryTotalTaxAmount { get { return WebDriver.GetElement(By.Id("{0}_summary_totalTaxAmount")); } }


public IWebElement SummaryEcoFee { get { return WebDriver.GetElement(By.Id("{0}_summary_ecoFee")); } }


public IWebElement SummaryFinalPrice { get { return WebDriver.GetElement(By.Id("{0}_summary_finalPrice")); } }


public IWebElement SummaryDiscountPercentage { get { return WebDriver.GetElement(By.Id("{0}_summary_discountPercent")); } }


public IWebElement SummaryDiscountPrice { get { return WebDriver.GetElement(By.Id("{0}_summary_dncDiscountPrice")); } }


public IWebElement SummaryDiscountValue { get { return WebDriver.GetElement(By.Id("{0}_summary_discountValue")); } }


public IWebElement SummaryDiscountTotalSaving { get { return WebDriver.GetElement(By.Id("{0}_summary_totalSavings")); } }


public IWebElement SummaryMarginValue { get { return WebDriver.GetElement(By.Id("{0}_summary_marginValue")); } }


public IWebElement SummaryMarginPercentage { get { return WebDriver.GetElement(By.Id("{0}_summary_marginPercentage")); } }


public IWebElement GoalDealId { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_goalDealId_input_{0}")); } }


public IWebElement PickFromList { get { return WebDriver.GetElement(By.Id("quoteCreate_selectGoalDealId_{0}")); } }


public IWebElement GoalDealPopupId { get { return WebDriver.GetElement(By.Id("Quotecreation_goaldealsGrid")); } }


public IWebElement GoalDealPopUpSelectId { get { return WebDriver.GetElement(By.Id("quotecreation_goaldealsGrid_select")); } }


public IWebElement GoalDealDiscountLimitPopup { get { return WebDriver.GetElement(By.Id("changeCustomer_title")); } }
        //TODO Need to change the Pop Up title id

public IWebElement GoalDealDiscountLimitPopupOk { get { return WebDriver.GetElement(By.Id("discountLimitReached_ok")); } }


public IWebElement GoalDealDiscountLimitPopupClose { get { return WebDriver.GetElement(By.Id("discountLimitReached_close")); } }


public IWebElement GoalExceedsLimitsValidation { get { return WebDriver.GetElement(By.Id("{0}_dealValidationErrorMessage_exceedingDealLimits")); } }


public IWebElement GoalDealIdMissingValidation { get { return WebDriver.GetElement(By.Id("{0}_dealValidationErrorMessage_missingGoalDeal")); } }


public IWebElement GoalNotWonValidation { get { return WebDriver.GetElement(By.Id("{0}_dealValidationErrorMessage_dealNotWon")); } }


public IWebElement GoalExpiredValidation { get { return WebDriver.GetElement(By.Id("{0}_dealValidationErrorMessage_dealExpired")); } }


public IWebElement GoalNotApplicable { get { return WebDriver.GetElement(By.Id("{0}_dealValidationErrorMessage_notApplicableDealId")); } }


public IWebElement ItemLevelGoalDealMissingValidation { get { return WebDriver.GetElement(By.Id("{0}_dealValidationErrorMessage_LI_dealIdMissing")); } }


public IWebElement ItemLevelGoalDealNotWonValidation { get { return WebDriver.GetElement(By.Id("{0}_dealValidationErrorMessage_LI_dealNotWon")); } }


public IWebElement ItemLevelGoalDealExpiredValidation { get { return WebDriver.GetElement(By.Id("{0}_dealValidationErrorMessage_LI_dealExpired")); } }


public IWebElement ItemLevelGoalNotApplicable { get { return WebDriver.GetElement(By.Id("{0}_dealValidationErrorMessage_LI_notApplicableDealId")); } }


public IWebElement ItemLevelGoalExceedsLimits { get { return WebDriver.GetElement(By.Id("{0}_dealValidationErrorMessage_LI_exceedingDealLimits")); } }


public IWebElement ItemLevelGoalDealProductRestrictionValidation { get { return WebDriver.GetElement(By.Id("{0}_dealValidationErrorMessage_LI_dealRestriction")); } }


public IWebElement ItemlevelContractCodeInCreateQuote { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_contractCode_input_{0}")); } }


public IWebElement SetContractAsDefaultYes { get { return WebDriver.GetElement(By.Id("_confirm_ok")); } }


public IWebElement SetContractAsDefaultNo { get { return WebDriver.GetElement(By.Id("_confirm_cancel")); } }


public IWebElement LineItemPromotion { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_PI_unitPercent_{0}")); } }


public IWebElement LineItemDiscount { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_totalDiscountPercent_{0}")); } }


public IWebElement TotalSellingPrice { get { return WebDriver.GetElement(By.Id("_LI_sellingPrice_{0}")); } }


public IWebElement TotalShippingPrice { get { return WebDriver.GetElement(By.Id("_LI_totalShippingAmount_{0}")); } }


public IWebElement CouponMessage { get { return WebDriver.GetElement(By.Id("popover-content")); } }


public IWebElement AddCoupon { get { return WebDriver.GetElement(By.Id("quoteCreate_addCoupon")); } }


public IWebElement RemoveCoupon { get { return WebDriver.GetElement(By.Id("removeCoupon")); } }


public IWebElement LblCoupon { get { return WebDriver.GetElement(By.Id("quoteCreateLI_D_discountName_{0}")); } }


public IWebElement LnkCouponDetails { get { return WebDriver.GetElement(By.Id("quoteCreateLI_D_Coupon_display")); } }


public IWebElement NoCouponAppliedMessage { get { return WebDriver.GetElement(By.Id("alert alert-info ng-scope")); } }


public IWebElement ShowMore { get { return WebDriver.GetElement(By.Id("{0}_LI_show_more_{1}")); } }


public IWebElement ExpandOption { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_CS_Item_1_{0}")); } }


public IWebElement OptionDiscount { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_CS_discountPercent_build1_category{0}")); } }


public IWebElement QuoteLevelSummaryDiscount { get { return WebDriver.GetElement(By.Id("quoteCreate_summary_discountPercent")); } }


public IWebElement CouponDetails { get { return WebDriver.GetElement(By.Id("promotion_show_details")); } }


public IWebElement CouponExpireDate { get { return WebDriver.GetElement(By.Id("expiration ng-binding")); } }


public IWebElement LnkPromotion { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_LI_D_financialPromos_{0}')]/a")); } }


public IWebElement PromotionDetails { get { return WebDriver.GetElement(By.Id("promotion_show_details")); } }


public IWebElement LnkQuoteDetailsCouponDetails { get { return WebDriver.GetElement(By.Id("quoteDetailLI_D_Coupon_display")); } }


public IWebElement LblQuoteDetailsCoupon { get { return WebDriver.GetElement(By.Id("quoteDetailLI_D_discountName_{0}")); } }


public IWebElement LnkQuoteDetailsPromotion { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_LI_D_financialPromos_{0}')]/a")); } }


public IWebElement QuoteDetailsCouponExpiredMessage { get { return WebDriver.GetElement(By.Id("ABC")); } }


public IWebElement QuoteDetailsSummaryDiscount { get { return WebDriver.GetElement(By.Id("quoteDetail_summary_discountPercent")); } }


public IWebElement QuoteDetailCompRevenueSummary { get { return WebDriver.GetElement(By.Id("quoteDetail_summary_compRevenue")); } }


public IWebElement QuoteDetailUnitCompRevenue { get { return WebDriver.GetElement(By.Id("quoteDetail_LI_PI_unitCompRevenue_{0}")); } }


public IWebElement HdrQuoteSendCfoTitlePage { get { return WebDriver.GetElement(By.Id("quoteSendCfo_title")); } }
        

public IWebElement HdrCfoQuoteSettings { get { return WebDriver.GetElement(By.Id("quoteSendCfo_headerQuoteSettings")); } }


public IWebElement CfoLanguageSettingsField { get { return WebDriver.GetElement(By.Id("quoteSendCfo_language_options")); } }


public IWebElement CfoPricingDisplayField { get { return WebDriver.GetElement(By.Id("quoteSendCfo_pricing_options")); } }


public IWebElement CfoSkuNumberDisplayField { get { return WebDriver.GetElement(By.Id("quoteSendCfo_skuNumberDisplay_options")); } }


public IWebElement CfoBannersField { get { return WebDriver.GetElement(By.Id("quoteSendCfo_banners_option")); } }


public IWebElement CfoFormatField { get { return WebDriver.GetElement(By.Id("quoteSendCfo_format_option")); } }


public IWebElement BtnCfoPreviewEmail { get { return WebDriver.GetElement(By.Id("quoteSendCfo_previewQuote")); } }


public IWebElement HdrCfoQuoteQueued { get { return WebDriver.GetElement(By.Id("quoteSendCfo_emailQueued")); } }


public IWebElement TxtCfoEmailGreeting { get { return WebDriver.GetElement(By.Id("quoteSendCfo_greeting")); } }


public IWebElement BtnCfoEmailGreetingEdit { get { return WebDriver.GetElement(By.Id("quoteSendCfo_greetingEdit")); } }


public IWebElement BtnCfoEmailDefaultGreetingMessage { get { return WebDriver.GetElement(By.Id("quoteSendCfo_greetingDefaultSetting")); } }


public IWebElement TxtCfoEmailBody { get { return WebDriver.GetElement(By.Id("quoteSendCfo_body")); } }


public IWebElement BtnCfoEmailBodyEdit { get { return WebDriver.GetElement(By.Id("quoteSendCfo_bodyEdit")); } }


public IWebElement BtnCfoEmailDefaultBodyMessage { get { return WebDriver.GetElement(By.Id("quoteSendCfo_bodyDefaultSetting")); } }


public IWebElement TxtCfoAdditionalComments { get { return WebDriver.GetElement(By.Id("quoteSendCfo_comments")); } }


public IWebElement CfoFaxOption { get { return WebDriver.GetElement(By.Id("quoteSendCfo_viaFax")); } }


public IWebElement CfoFaxTextFieldId { get { return WebDriver.GetElement(By.Id("quoteSendCfo_faxNumber")); } }


public IWebElement CfoFaxAttention { get { return WebDriver.GetElement(By.Id("quoteSendCfo_attention")); } }


public IWebElement CfoHistoryOutputTypeView { get { return WebDriver.GetElement(By.Id("view_{0}")); } }


public IWebElement CfoResendEmailTextArea { get { return WebDriver.GetElement(By.Id("resendCFOEmail_originalRecipients")); } }


public IWebElement BtnCfoResendCancel { get { return WebDriver.GetElement(By.Id("resendCFOEmail_cancel")); } }


public IWebElement BtnCfoResendClose { get { return WebDriver.GetElement(By.Id("resendCFOEmail_close")); } }


public IWebElement CfoOutputTypePopUp { get { return WebDriver.GetElement(By.Id("_cfoViewDocument")); } }


public IWebElement CfoOutputPopUpContent { get { return WebDriver.GetElement(By.Id("_viewDocumentContent")); } }


public IWebElement HdrCfoEmailPreview { get { return WebDriver.GetElement(By.Id("_title")); } }

        //TODO Need to change the ID according to standards

public IWebElement LnkCfoCustomerOutput { get { return WebDriver.GetElement(By.Id("_CustomerOutputReport")); } }


public IWebElement CustomerHoldModelId { get { return WebDriver.GetElement(By.Id("customerHold_title")); } }


public IWebElement BtnCustomerHoldConfirm { get { return WebDriver.GetElement(By.Id("customerHold_confirm")); } }


public IWebElement DivContractsListId { get { return WebDriver.GetElement(By.Id("Quotecreation_contractSelectGrid")); } }


public IWebElement ContractsSelect { get { return WebDriver.GetElement(By.Id("quoteCreate_select_contractCode")); } }


public IWebElement BtnCurrentQuote { get { return WebDriver.GetElement(By.Id("menu_currentQuote")); } }


public IWebElement ProductLevelDiscountPercentage { get { return WebDriver.GetElement(By.Id("1_LI_discountPercent")); } }


public IWebElement ProductLevelUnitPrice { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_unitPrice_1")); } }


public IWebElement ContractCodeErrorMessageClassName { get { return WebDriver.GetElement(By.Id("popover-content")); } }


public IWebElement ContractExpiryErrorMessageOnItemLevel { get { return WebDriver.GetElement(By.Id("{0}_contractExpiryErrorMessage_contractsExpired")); } }
        //Todo: Need to be update

public IWebElement ContractExpiryErrorMessageOnQuoteLevel { get { return WebDriver.GetElement(By.Id("{0}_contractexpiryErrorText")); } }
        //Todo: Need to be update

public IWebElement ContractCopyQuote { get { return WebDriver.GetElement(By.Id("contractCopyQuoteLink")); } }
        //Todo: Need to be update

public IWebElement CatalogeGrid { get { return WebDriver.GetElement(By.Id("customerSetSelect_Grid")); } }


public IWebElement CatalogSelect { get { return WebDriver.GetElement(By.Id("customerSetSelect_Grid_select_{0}")); } }


public IWebElement CatalogSelectForCreateCustomer { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid_select_{0}")); } }


public IWebElement QuoteExpirationDate { get { return WebDriver.GetElement(By.Id("quoteCreate_expirationDate")); } }


public IWebElement QuoteSaveUpdateRevenueDisplayMode { get { return WebDriver.GetElement(By.Id("quoteSaveUpdateRevenue")); } }


public IWebElement UpdateRevenueAssociateOpportunity { get { return WebDriver.GetElement(By.Id("quoteSaveUpdateRevenue_AssociateOpportunity")); } }


public IWebElement UpdateRevenueCommonInfo { get { return WebDriver.GetElement(By.Id("quoteSaveUpdateRevenue_commonInfo")); } }


public IWebElement ChkboxUpdateRevenueRadioId { get { return WebDriver.GetElement(By.Id("quoteSaveUpdateRevenue_radioCheckBox")); } }


public IWebElement BtnUpdateRevenueNextId { get { return WebDriver.GetElement(By.Id("quoteSaveUpdateRevenue_next")); } }


public IWebElement BtnUpdateRevenueSkipId { get { return WebDriver.GetElement(By.Id("quoteSaveUpdateRevenue_skip")); } }


public IWebElement BtnNoItemsSkipUpdateRevenueId { get { return WebDriver.GetElement(By.Id("quoteSaveUpdateRevenue_skipNoItemsToUpdate")); } }


public IWebElement UpdateRevenueUpdateOpportunity { get { return WebDriver.GetElement(By.Id("quoteSaveUpdateRevenue_UpdateOpportunity")); } }


public IWebElement DellPaysShippingMethodMessageId { get { return WebDriver.GetElement(By.Id("{0}_dellPayShippingMessageText_{1}")); } }


public IWebElement BtnQuoteListMergeQuoteId { get { return WebDriver.GetElement(By.Id("quoteSearchResults_mergeQuotes")); } }


public IWebElement BtnQuoteListMergeQuoteClearAllId { get { return WebDriver.GetElement(By.Id("quoteSearchResults_mergeQuoteClearAll")); } }


public IWebElement MergeQuoteLimitExceedMsgId { get { return WebDriver.GetElement(By.Id("quoteSearchResults_mergeQuotes_limitExceeded")); } }


public IWebElement MergeQuoteModal_Title { get { return WebDriver.GetElement(By.Id("QuoteMerge_mergeCount")); } }


public IWebElement MergeQuoteModal_MasterQuoteMag { get { return WebDriver.GetElement(By.Id("QuoteMerge_masterQuoteMsg")); } }


public IWebElement MergeQuoteModal_Grid { get { return WebDriver.GetElement(By.Id("quoteMerge_Grid")); } }


public IWebElement MergeQuoteModal_CreateQuote { get { return WebDriver.GetElement(By.Id("QuoteMerge_continue")); } }


public IWebElement MergeQuoteModal_AddMoreQuote { get { return WebDriver.GetElement(By.Id("QuoteMerge_addMore")); } }


public IWebElement MergeQuoteModal_Cancel { get { return WebDriver.GetElement(By.Id("QuoteMerge_cancel")); } }


public IWebElement MergeQuoteModal_Close { get { return WebDriver.GetElement(By.Id("QuoteMerge_close")); } }


public IWebElement MergeQuoteModal_MasterQuoteNOTSelected { get { return WebDriver.GetElement(By.Id("QuoteMerge_mergeQuotes_masterNotSelected")); } }


public IWebElement MergeQuoteModal_Remove { get { return WebDriver.GetElement(By.Id("quoteMergeRemove_Grid_remove")); } }


public IWebElement MergeQuoteModal_Undo { get { return WebDriver.GetElement(By.Id("quoteMergeRemove_Grid_undo")); } }


public IWebElement DeclineScriptPopup { get { return WebDriver.GetElement(By.Id("_declineScript2")); } }


public IWebElement PcRequiredScriptPopup { get { return WebDriver.GetElement(By.Id("_pcRequiredScript")); } }


public IWebElement BtnDeclineScriptPopupClose { get { return WebDriver.GetElement(By.Id("_declineScript2_close")); } }


public IWebElement HdrFinancialServices { get { return WebDriver.GetElement(By.Id("{0}_financialServices_header")); } }


public IWebElement DfsCustomerMessage { get { return WebDriver.GetElement(By.Id("quoteCreate_dfsEnabled_dfsMessage")); } }


public IWebElement DfsCustomerStatus { get { return WebDriver.GetElement(By.Id("quoteCreate_dfsEnabled_dfsStatus")); } }


public IWebElement DfsCustomerCreditStatus { get { return WebDriver.GetElement(By.Id("customerDetails_dbcCreditStatus")); } }


public IWebElement DfsCustomerLeaseCreditStatus { get { return WebDriver.GetElement(By.Id("customerDetails_leaseCreditStatus")); } }


public IWebElement DfsCustomerPaymentTerms { get { return WebDriver.GetElement(By.Id("quoteCreate_paymentTerm")); } }


public IWebElement DfsCustomerCurrency { get { return WebDriver.GetElement(By.Id("quoteCreate_currency")); } }


public IWebElement DfsCustomerCreditLimit { get { return WebDriver.GetElement(By.Id("quoteCreate_CreditLimit")); } }


public IWebElement DfsCustomerCurrentBalance { get { return WebDriver.GetElement(By.Id("quoteCreate_CurrentBalance")); } }


public IWebElement HdrDfsCustomerFinancialInfo { get { return WebDriver.GetElement(By.Id("quoteCreate_financialInformationHeading")); } }


public IWebElement ItemAddedToggle { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_1")); } }


public IWebElement MarginLb { get { return WebDriver.GetElement(By.Id("quoteDetail_LI_margin_1")); } }


public IWebElement ShowMoreForEachItem { get { return WebDriver.GetElement(By.CssSelector("#quoteCreate_LI_show_more_1 > div > a > i")); } }


public IWebElement AddNewShippingEmailAddress { get { return WebDriver.GetElement(By.Id("#quoteCreate_LI_SI_shippingNewEmailAddressLink_1")); } }


public IWebElement SearchShippingEmailAddress { get { return WebDriver.GetElement(By.Id("#quoteCreate_LI_SI_searchEmailAddress_1")); } }


public IWebElement CancelShippingEmailAddress { get { return WebDriver.GetElement(By.CssSelector("#COM > div.modal-large.ng-scope > div > div.btn-bar > button")); } }


public IWebElement ChangeShippingEmailAddress { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_SI_shippingNewEmailAddressLink_1")); } }


public IWebElement AddEmailAddressPopUp { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_email")); } }


public IWebElement SaveEmailIDbyShippingAddress { get { return WebDriver.GetElement(By.Id("#customerDetails_addShippingAddress_save")); } }


public IWebElement ConfirmEmailIDbyShippingAddress { get { return WebDriver.GetElement(By.CssSelector("#customerDetails_validateAddress_shippingAddress_validation_withSuggestion > div:nth-child(2) > div > div > input")); } }


public IWebElement SelectConfirmEmailIDbyShippingAddress { get { return WebDriver.GetElement(By.Id("#customerDetails_validateAddress_addShippingAddress_select")); } }


public IWebElement DdlSelectFromEmailID { get { return WebDriver.GetElement(By.Id("customerSelect_searchFilter")); } }


public IWebElement TxtSearchEmailID { get { return WebDriver.GetElement(By.Id("customerSelect_searchFilter_value")); } }


public IWebElement SearchEmailIDbyShippingAddress { get { return WebDriver.GetElement(By.Id("customerSelect_searchAction")); } }


public IWebElement SelectEmailIDbyShippingAddress { get { return WebDriver.GetElement(By.Id("#addressSelect_addressGrid_select")); } }


public IWebElement SortEmailIDbyShippingAddress { get { return WebDriver.GetElement(By.CssSelector("#addressSelect_addressGrid > div > div > table > thead > tr > th:nth-child(8)")); } }

        // [FindsBy(How = How.CssSelector, Using = "div.col-md-4:nth-child(3) > div:nth-child(2) > div:nth-child(2) > div:nth-child(2)")] 
        public IWebElement MarginLable;


public IWebElement CustomerInformationPrimaryContact { get { return WebDriver.GetElement(By.Id("quoteDetail_primaryContactName")); } }


public IWebElement CompRevenueSummary { get { return WebDriver.GetElement(By.Id("quoteCreate_summary_compRevenue")); } }


public IWebElement QuoteDetails_CompRevenueSummary { get { return WebDriver.GetElement(By.Id("quoteDetail_LI_PI_unitCompRevenue_{0}")); } }


public IWebElement CompRevenueUnitCompRevenue { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_PI_unitCompRevenue_{0}")); } }


public IWebElement RefreshSmartPrice { get { return WebDriver.GetElement(By.Id("quoteCreate_updateSmartPrice")); } }


public IWebElement SmartPricePopup { get { return WebDriver.GetElement(By.Id("smartPriceGuidance_{0}")); } }


public IWebElement ICodeOverride { get { return WebDriver.GetElement(By.Id("icode-override")); } }


public IWebElement LnkPomIdAddCss { get { return WebDriver.GetElement(By.CssSelector("#quoteDetail_pomId > span:nth-child(2) > span:nth-child(1) > a")); } }


public IWebElement LnkPomIdEditCss { get { return WebDriver.GetElement(By.CssSelector("#quoteDetail_pomId > span:nth-child(2) > span.ng-hide > a")); } }


public IWebElement PomId { get { return WebDriver.GetElement(By.CssSelector("#quoteDetail_pomId > span:nth-child(2) > span:nth-child(2) > label")); } }


public IWebElement PomIdText { get { return WebDriver.GetElement(By.Id("#pom_id")); } }


public IWebElement PomIdValidationMessage { get { return WebDriver.GetElement(By.CssSelector("#quoteDetail_quote_Validation > p > span")); } }


public IWebElement PomIdEditCssLinkOnOrderDetails { get { return WebDriver.GetElement(By.Id("ABC")); } }


public IWebElement SalesRepMismatchPopup { get { return WebDriver.GetElement(By.XPath("//*[@id='COM')]/div[4)]/div/h3")); } }


public IWebElement SalesRepMismatchSaveOrder { get { return WebDriver.GetElement(By.XPath("//*[@id='COM')]/div[4)]/div/div[3)]/button[1)]")); } }


public IWebElement SalesRepMismatchSaveOrderUsingSalesrepId { get { return WebDriver.GetElement(By.XPath("//*[@id='COM')]/div[4)]/div/div[3)]/button[2)]")); } }


public IWebElement SalesRepMismatchSaveOrderCancel { get { return WebDriver.GetElement(By.Id("quoteDetail_cancel")); } }


public IWebElement SalesRepMismatchMessage { get { return WebDriver.GetElement(By.XPath("//*[@id='COM')]/div[4)]/div/div[2)]/div")); } }


public IWebElement FinancialInformationId { get { return WebDriver.GetElement(By.Id("quoteCreate_financialInformationHeading")); } }


public IWebElement FinancialInformationToggle { get { return WebDriver.GetElement(By.CssSelector("#quoteCreate_financialInformationHeading > div > span > a")); } }


public IWebElement HdrFinancialInformation { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_financialInformationHeading')]/div/span[1)]/span")); } }


public IWebElement PaymentMethod { get { return WebDriver.GetElement(By.Id("quoteCreate_financingPaymentMethod")); } }


public IWebElement PaymentTerms { get { return WebDriver.GetElement(By.Id("quoteCreate_paymentTerm")); } }


public IWebElement Currency { get { return WebDriver.GetElement(By.Id("quoteCreate_currency")); } }


public IWebElement FinancialDiscount { get { return WebDriver.GetElement(By.Id("quoteCreate_discount")); } }


public IWebElement FederalTaxId { get { return WebDriver.GetElement(By.Id("quoteCreate_federalTaxId")); } }


public IWebElement TaxExempt { get { return WebDriver.GetElement(By.Id("quoteCreate_taxExempt")); } }


public IWebElement DiscountEntitlements { get { return WebDriver.GetElement(By.Id("quoteCreate_discountEntitlements")); } }


public IWebElement PromotionCode { get { return WebDriver.GetElement(By.Id("quoteCreate_promotionCode")); } }


public IWebElement CustomerHold { get { return WebDriver.GetElement(By.Id("quoteCreate_customerHold")); } }


public IWebElement CreditHold { get { return WebDriver.GetElement(By.Id("quoteCreate_creditHold")); } }


public IWebElement DivCreditDetails { get { return WebDriver.GetElement(By.Id("quoteCreate_CreditDetails")); } }


public IWebElement CreditLimit { get { return WebDriver.GetElement(By.Id("quoteCreate_CreditLimit")); } }


public IWebElement CurrentBalance { get { return WebDriver.GetElement(By.Id("quoteCreate_CurrentBalance")); } }


public IWebElement RemainingBalance { get { return WebDriver.GetElement(By.Id("quoteCreate_RemainingBalance")); } }


public IWebElement ThirtyDayBalance { get { return WebDriver.GetElement(By.Id("quoteCreate_30DayBalance")); } }


public IWebElement SixtyDayBalance { get { return WebDriver.GetElement(By.Id("quoteCreate_60DayBalance")); } }


public IWebElement PrimarySalesRep { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_salesRep')]/span")); } }


public IWebElement TagSalesRep { get { return WebDriver.GetElement(By.Id("quoteCreate_tagRepNew")); } }


public IWebElement QuoteDetailsNoResults { get { return WebDriver.GetElement(By.Id("common_noResults_message")); } }

        public IWebElement LblItemLevelMargin(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id(lineItemPagePrefix + "LI_itemMarginPercentage_0_" + lineItemIndex));
        }

        public IWebElement LblItemLevelUnitMargin(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id(lineItemPagePrefix + "LI_PI_unitMargin_0_" + lineItemIndex));            
        }

        public IWebElement LnkItemLevelProductDescription(int lineItemIndex = 1)
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return WebDriver.GetElement(By.Id(string.Format("{0}_LI_cssiNumber_0_{1}", lineItemPagePrefix, lineItemIndex)));
        }

        public IWebElement LblAPOSItemLevelTotalMaring(int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id(lineItemPagePrefix + "SEItem_unitMargin_0_" + lineItemIndex));
        }

      

        #endregion

        #region Methods

        /// <summary>
        /// Executes the Quote search.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="isDeterministicSearch"></param>
        /// <returns></returns>
        public IPage ExecuteQuoteSearch(IWebDriver driver,bool isDeterministicSearch = true)
        {
            BtnQuoteSearch.Click(driver);
            if (isDeterministicSearch)
                return new QuoteDetailsPage(WebDriver);
            return new QuoteSearchResultsPage(WebDriver);
        }

        public bool VerifyCreateOrderDisabled()
        {
           string disabled= BtnCreateOrder.GetAttribute("disabled");
           return disabled.Equals("true");
        }

       
        public int GetTotalItems()
        {
            return WebDriver.GetElements(By.XPath("//*[contains(@id,'LI_productDescription_0_')]")).Count;
        }

        public void GetMarginAndUnitMargin(string productDescription, out string ItemLevelMargin, out string ItemLevelUnitMargin)
        {
            var itemsCount = GetTotalItems();
            
            for (int i = 0; i < itemsCount; i++)
            {
                if (LnkItemLevelProductDescription(i).GetText(WebDriver).Equals(productDescription))
                {
                    LblItemLevelMargin(i).WaitForElement(WebDriver);
                    ItemLevelMargin = LblItemLevelMargin(i).GetText(WebDriver);
                    ItemLevelUnitMargin = LblItemLevelUnitMargin(i).GetText(WebDriver);
                    return;
                }
            }
            ItemLevelMargin = string.Empty;
            ItemLevelUnitMargin = string.Empty;
        }

        public bool ValidateMarginVisibilityAtItemLevel(string OrderCodesWithBrandIDFlag, bool ViewMarginRight)
        {
            bool result = true;
            foreach (var item in OrderCodesWithBrandIDFlag.Split('|'))
            {
                string ItemLevelMargin, ItemLevelUnitMaring;
                GetMarginAndUnitMargin(item.Split(';')[2], out  ItemLevelMargin, out ItemLevelUnitMaring);

                if (ViewMarginRight == true || Convert.ToBoolean(item.Split(';')[1]) == true)
                {
                    if (string.IsNullOrEmpty(ItemLevelMargin) || string.IsNullOrEmpty(ItemLevelUnitMaring))                        
                    {
                        result = false;
                        Logger.Write(string.Format("Item not found on quote creation page {0}", item.Split(';')[2]));
                    }

                    if (!ItemLevelMargin.Any(c => char.IsDigit(c)) || !ItemLevelUnitMaring.Any(c => char.IsDigit(c)))
                    {
                        result = false;
                        Logger.Write(string.Format("Margin for item {0} {1} does not contain any digits", item.Split(';')[0], item.Split(';')[1]));
                    }

                }
                else
                {
                    if (!ItemLevelMargin.Contains("-") || !ItemLevelUnitMaring.Contains("-"))
                        result = false;
                    Logger.Write(string.Format("Margin for item {0} {1} is not in right format", item.Split(';')[0], item.Split(';')[1]));
                }
            }

            return result;
        }

        public bool ValidateMarginVisibilityAtItemLevelForAPOSQuote(string OrderCodesWithBrandIDFlag, bool ViewMarginRight)
        {
            bool result = true;
            int i = 0;

            foreach (var item in OrderCodesWithBrandIDFlag.Split('|'))
            {
                string aposTotalMargin = LblAPOSItemLevelTotalMaring(i).GetText(WebDriver);                

                if (ViewMarginRight == true || Convert.ToBoolean(item.Split(';')[1]) == true)
                {
                    if (string.IsNullOrEmpty(aposTotalMargin) || string.IsNullOrEmpty(aposTotalMargin))
                    {
                        result = false;
                        Logger.Write(string.Format("Item not found on quote creation page {0}", item.Split(';')[2]));
                    }

                    if (!aposTotalMargin.Any(c => char.IsDigit(c)) || !aposTotalMargin.Any(c => char.IsDigit(c)))
                    {
                        result = false;
                        Logger.Write(string.Format("Margin for item {0} {1} does not contain any digits", item.Split(';')[0], item.Split(';')[1]));
                    }

                }
                else
                {
                    if (!aposTotalMargin.Contains("-") || !aposTotalMargin.Contains("-"))
                        result = false;
                    Logger.Write(string.Format("Margin for item {0} {1} is not in right format", item.Split(';')[0], item.Split(';')[1]));
                }
            }

            return result;
        }

        #endregion
    }
}
