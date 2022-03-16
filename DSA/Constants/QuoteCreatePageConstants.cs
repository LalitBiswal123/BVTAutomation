using System;

namespace Dsa.Constants
{
    public class QuoteCreatePageConstants
    {
        public const string ProductCatalogGrd = "customerSetSelect_Grid_select";

        public const string QuoteCreateTitle = "quoteCreate_title";

        public const string SearchCustomerLnk = "quoteCreate_searchCustomer";
        public const string ChangeCustomerLnk = "quoteCreate_changeCustomer";
        public const string SelectEndUserCustomerLnk = "quoteCreate_selectEndUserCustomer";
        public const string ExpirationDateViewButtonCss = "#QuoteCreateForm > div:nth-child(3) > div > span > span > span > span";
       
        // Create quote section
        public const string MenuProductItemsTxt = "menu_productItems";
        public const string CustomerNumberTxt = "quoteCreate_customerNumber";
        public const string QuoteNameTxt = "quoteCreate_quoteName";
        public const string QuoteCreateVersionRb = "quoteCreate_quote";
        public const string QuoteVersionNextBtn = "quoteCreate_next";
        public const string ExpirationDateTxt = "quoteCreate_expirationDate";
        public const string PoNumberTxt = "quoteCreate_poNumber";
        public const string ContractCodeTxt = "quoteCreate_LI_contractCode_input_1";
        public const string DealIdTxt = "quoteCreate_dealId";
        public const string EndUserCustomerNumberTxt = "quoteCreate_endUserCustomerNumber";
        public const string EndUserCustomerMessage = "quoteCreate_addEndUserInputGroup";
        public const string SameEndUserCustomer = "quoteCreate_addEndUserInputGroup";
        public const string LineItemValidationMessage = "quoteCreate_item_validation";
        public const string CreateQuoteShippingMethod = "quoteCreate_shippingMethod";
        public const string AddItemBtn = "quoteCreate_addItem";
        public const string AddItemFromOpportunityBtn = "quoteCreate_addItemFromOpportunity";
        public const string DefaultShippingAddress = "quoteCreate_defaultShipToAddress";
        public const string SaveQuoteBtn = "quoteCreate_saveQuote";
        public const string EndUserCutomerTxt = "quoteCreate_endUserCustomerNumber";
        public const string ChooseAddress = "quoteCreate_chooseAddress";
        public const string AddNewAddressLink = "quoteCreate_shippingNewAddressLink";
        
        // Notes
        public const string NotesToggleBtn = "quoteCreate_notesToggle";
        public const string NotesHeaderSpn = "quoteCreate_notes_header";
        public const string NotesTbl= "DataTables_Table_3";

        // Installationinstructions
        public const string InstallationinstructionsToggleBtn = "quoteCreate_installationinstructionsToggle";
        public const string InstallationinstructionsHeaderSpn = "quoteCreate_installationinstructions_header";
        public const string InstallationInstructionsTxtArea = "quoteCreate_installationInstructions";
        public const string SaveInstallationInstructionsLnk = "quoteCreate_saveInstallationInstructions";
        public const string CancelInstallationInstructionsLnk = "quoteCreate_cancelInstallationInstructions";

        // Summary Header
        public const string SummaryHeader = "quoteCreate_summary_header";
        public const string ListPriceLbl = "quoteCreate_summary_listPrice";
        public const string SellingPriceLbl = "quoteCreate_summary_sellingPrice";
        public const string DiscountPercentLbl = "quoteCreate_summary_discountPercent";
        public const string MarginValueLbl = "quoteCreate_summary_marginValue";
        public const string MarginPercentageLbl = "quoteCreate_summary_marginPercentage";
        public const string SubtotalAmountLbl = "quoteCreate_summary_subtotalAmount";
        public const string ShippingAmountLbl = "quoteCreate_summary_shippingAmount";
        public const string TotalTaxAmountLbl = "quoteCreate_summary_totalTaxAmount";
        public const string EcoFeeLbl = "quoteCreate_summary_ecoFee";
        public const string FinalPriceLbl = "quoteCreate_summary_finalPrice";
        public const string Update = "quoteCreate_lineItem_update";
        public const string UpdatePriceSummaryLbl = "quoteCreate_summary_update";

        // Item level controls
        public const string RemoveItemLnk = "quoteCreate_LI_removeItem";
        public const string ConfigureLnk = "quoteCreate_LI_configItem";
        public const string SplitLnk = "quoteCreate_lineItem_split";
        public const string ShowMoreLnk = "quoteCreate_LI_show_more_{0}";

        public const string PopOverValidationMessageDiv = "popover-inner";
        public static readonly string LineItemTotalEcoFee = "quoteCreate_LI_ecoFee_{0}";
        public static readonly string LineItemTotalAmount = "quoteCreate_LI_totalAmount_{0}";
        public static readonly string LineItemPickDifferentShipping = "quoteCreate_LI_SI_shippingPickAddressLink_{0}";
        public static readonly string LineItemToggle = "quoteCreate_LI_{0}";
        public static readonly string Item = "quoteCreate_LI_productDescription_{0}";
        public static readonly string Edd = "quoteCreate_LI_edd_{0}";
        public static readonly string UnitPrice = "quoteCreate_LI_PI_unitPrice_{0}";
        //public static readonly string Quantity = "quoteCreate_LI_quantity_input_{0}";
        public static readonly string Quantity = "quoteCreate_LI_quantity_{0}";
        public static readonly string SellingPrice = "quoteCreate_LI_sellingPrice_{0}";
        //public static readonly string SellingPrice = "//*[@id=\"quoteCreate_LI_sellingPrice_{0}\"]";
        public static readonly string DiscountValue = "quoteCreate_LI_PI_dol_{0}";
        public static readonly string DiscountPercent = "{0}_LI_discountPercent";
        public static readonly string Margin = "quoteCreate_LI_margin_{0}";
        public static readonly string MarginPercentage = "quoteCreate_LI_marginPercentage_{0}";
        public static readonly string ContractCode = "quoteCreate_LI_contractCode_input_{0}";
        public static readonly string ContractCodeText = "quoteCreate_LI_contractCode_{0}";
        public static readonly string ItemBuildTime = "quoteCreate_LI_itemBuildTime_{0}";
        public static readonly string ItemShipDate = "quoteCreate_LI_itemShipDate_{0}";
        public static readonly string OrderCode = "quoteCreate_LI_orderCode_{0}";
        public static readonly string SkuNumber = "quoteCreate_LI_skuNumber_{0}";
        public static readonly string GoalDealId = "quoteCreate_LI_goalDealId_{0}";
        public static readonly string ContractDiscountItemLevel = "quoteCreate_LI_PI_contractPercent_{0}";
        public static readonly string ItemLevelValidation = "quoteCreate_itemValidation_{0}";
        public static readonly string ItemLevelManualDiscountTextbox = "{0}_LI_manualPercent";

        

        public static readonly string DellPayShippingMessageText = "quoteCreate_dellPayShippingMessageText_{0}";

        public static readonly string LineHeader = "quoteCreate_lineHeader";
        public static readonly string QuoteCreateLineItemsCount = "//*[@id='quoteCreate_line_items']/div/div[2]";

        // Goal Control
        public static readonly string GoalNewRequest = "quoteCreate_createNewGoalDealId_{0}";
        public static readonly string GoalPickFromList = "quoteCreate_selectGoalDealId_{0}";
        public static readonly string GoalTool = "quoteCreate_openGoalTool_2{0}";

        //Pricing Information
        public static readonly string UnitSellingPrice = "quoteCreate_LI_PI_unitSellingPrice_{0}";
        public static readonly string PricingInformationToggle = "quoteCreate_LI_PI_toggle_{0}";
        public static readonly string PricingInformationHeader = "quoteCreate_LI_PI_header";
        public static readonly string PiUnitPrice = "quoteCreate_LI_PI_unitPrice_{0}";
        public static readonly string PiStateEnvFee = "quoteCreate_LI_PI_stateEnvFee_{0}";
        public static readonly string PiUnitMargin = "quoteCreate_LI_PI_unitMargin_{0}";
        public static readonly string PiShippingAmount = "quoteCreate_LI_PI_shippingAmount_{0}";
        public static readonly string PiDol = "quoteCreate_LI_PI_dol_{0}";
        public static readonly string PiTotalAmount = "quoteCreate_LI_PI_totalAmount_{0}";

        public static readonly string LineItemLevelShippingAmountDiv = "quoteCreate_LI_totalShippingAmount_{0}";
        //Discount
        public static readonly string DiscountTotal = "_li_discount_total_{0}";
        public static readonly string DiscountToggle = "quoteCreate_LI_discount_Toggle_{0}";

        // Configuration Specs
        public static readonly string ConfigurationSpecsToggle = "quoteCreate_LI_CS_toggle_{0}";
        public static readonly string ConfigurationSpecsGrid = "quoteCreate_LI_CS_grid_{0}";
        public static readonly string ConfigurationSpecsHeader = "quoteCreate_LI_CS_header";

        // Shipping Information
        public static readonly string ShippingToggle = "quoteCreate_LI_SI_toggle_{0}";
        public static readonly string ShippingHeader = "quoteCreate_LI_SI_header";
        public static readonly string ShippingMethod = "quoteCreate_LI_SI_shippingMethod_{0}";
        public static readonly string ShippingPickAddressLnk = "quoteCreate_LI_SI_shippingPickAddressLink_{0}";
        public static readonly string ShippingNewAddressLnk = "quoteCreate_LI_SI_shippingNewAddressLink_{0}";
        public static readonly string ShippingEmailAddressLnk = "quoteCreate_LI_SI_emailAddress_{0}";
        public static readonly string ShippingArriveByDate = "quoteCreate_LI_SI_arriveByDate_{0}";
        public static readonly string ShippingEstimatedDeliveryDate = "quoteCreate_LI_SI_estimatedDeliveryDate_{0}";
        public static readonly string ShippingInstructions = "quoteCreate_LI_SI_shippingInstructions_{0}";
        public static readonly string ShippingAddress = "quoteDetail_LI_SI_addressInformation_{0}";
       

        // Taxes
        public static readonly string LineItemTotalTax = "quoteCreate_LI_tax_{0}";
        public static readonly string TaxesToggle = "quoteCreate_LI_taxes_toggle_{0}";
        public static readonly string TaxesHeader = "quoteCreate_LI_taxes_header";
        public static readonly string TotalTax = "quoteCreate_LI_taxTotal_{0}";
        public static readonly string TaxTable = "DataTables_Table_{0}";
        
        // Customer Information
        public const string CustomerInformationToggle = "quoteCreate_customerInformationToggle";
        public const string CustomerInformationHeader = "//*[@id='quoteCreate_contactHeading']/div/span[1]/span";
        public const string CustomerId = "quoteCreate_customerId";
        public const string CustomerNumber = "quoteCreate_customerNumber";
        public const string CompanyName = "quoteCreate_companyName";
        public const string CompanyNumber = "quoteCreate_companyNumber";
        public const string CustomerClass = "quoteCreate_customerClass";
        public const string ParentReference = "quoteCreate_parentReference";
        public const string Channel = "quoteCreate_channel";
        public const string ContactCfoLanguage = "quoteCreate_contactCFOLang";
        public const string Address1 = "quoteCreate_address1";
        public const string Address2 = "quoteCreate_address2";
        public const string City = "quoteCreate_city";
        public const string State = "quoteCreate_state";
        public const string PostalCode = "quoteCreate_zip";
        public const string Country = "quoteCreate_primaryContactCountry";
        public const string PrimaryContactName = "quoteCreate_primaryContactName";
        public const string Department = "quoteCreate_department";
        public const string Email = "quoteCreate_email";
        public const string Telephone = "quoteCreate_telephone";

        // Financial Information
        public const string FinancialInformationId = "quoteCreate_financialInformationHeading";
        public const string FinancialInformationToggle = "#quoteCreate_financialInformationHeading > div > span > a";
        public const string FinancialInformationHeader = "//*[@id='quoteCreate_financialInformationHeading']/div/span[1]/span";
        public const string PaymentMethod = "quoteCreate_financingPaymentMethod";
        public const string PaymentTerms = "quoteCreate_paymentTerm";
        public const string Currency = "quoteCreate_currency";
        public const string Discount = "quoteCreate_discount";
        public const string FederalTaxId = "quoteCreate_federalTaxId";
        public const string TaxExempt = "quoteCreate_taxExempt";
        public const string DiscountEntitlements = "quoteCreate_discountEntitlements";
        public const string PromotionCode = "quoteCreate_promotionCode";
        public const string CustomerHold = "quoteCreate_customerHold";
        public const string CreditHold = "quoteCreate_creditHold";

        public const string CreditDetailsDiv = "quoteCreate_CreditDetails";

        public const string CreditLimit = "quoteCreate_CreditLimit";
        public const string CurrentBalance = "quoteCreate_CurrentBalance";
        public const string RemainingBalance = "quoteCreate_RemainingBalance";

        public const string ThirtyDayBalance = "quoteCreate_30DayBalance";
        public const string SixtyDayBalance = "quoteCreate_60DayBalance";
        public const string PrimarySalesRep = "//*[@id='quoteCreate_salesRep']/span";
        public const string TagSalesRep = "quoteCreate_tagRepNew";

        //admin
        public const string SearchCustLnk = "quoteCreate_searchCustomer";
        public const string LineItemDetailsDiv = "line-item-details";

        //Add Shipping Address
        public const string AddShippingAddress_CompanyName = "customerDetails_addShippingAddress_companyName";
        public const string AddShippingAddress_FirstName = "customerDetails_addShippingAddress_firstName";
        public const string AddShippingAddress_LastName = "customerDetails_addShippingAddress_lastName";
        public const string AddShippingAddress_Email = "customerDetails_addShippingAddress_email";
        public const string AddShippingAddress_Address1 = "customerDetails_addShippingAddress_addressLine1";
        public const string AddShippingAddress_Address2 = "customerDetails_addShippingAddress_addressLine2";
        public const string AddShippingAddress_City = "customerDetails_addShippingAddress_city";
        public const string AddShippingAddress_State = "customerDetails_addShippingAddress_state";
        public const string AddShippingAddress_ZipCode = "customerDetails_addShippingAddress_zipCode";
        public const string AddShippingAddress_PrimaryPhone = "customerDetails_addShippingAddress_primaryPhone";
        public const string AddShippingAddress_SaveButton = "customerDetails_addShippingAddress_save";



        public const double DoubleTen = 0.05;
        public const double DoubleOne = 01.00;
        public const Int32 Int32Seven = 2;
        public const Int32 Int32One = 1;

    }
}