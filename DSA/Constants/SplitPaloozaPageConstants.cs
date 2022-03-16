namespace Dsa.Constants
{
    public class SplitPaloozaPageConstants
    {
        public const string QuoteNumber = "#quoteSplit_header > div:nth-child(2) > div:nth-child(2) > div > p";
        public const string Title = "quoteSplit_title";
        public const string Select = "splitQuoteSelect";
        public const string Delete = "splitQuoteDelete";

        // Create quote section
        public const string CustomerNumberTxt = "quoteSplit_customerNumber";
        public const string QuoteNameTxt = "quoteSplit_quoteName";
        public const string ExpirationDateTxt = "quoteSplit_expirationDate";
        public const string PoNumberTxt = "quoteSplit_poNumber";
        public const string ContractCodeTxt = "quoteSplit_contractCode";
        public const string DealIdTxt = "quoteSplit_dealId";
        public const string EndUserCustomerNumberTxt = "quoteSplit_endUserCustomerNumber";


        public const string SaveQuotes = "quoteSplit_saveQuotes";
        public const string Cancel = "quoteSplit_cancel";


        // Summary Header
        public const string SummaryHeader = "quoteSplit_summary_header";
        public const string ListPriceLbl = "quoteSplit_summary_listPrice";
        public const string SellingPriceLbl = "quoteSplit_summary_sellingPrice";
        public const string DiscountPercentLbl = "quoteSplit_summary_discountPercent";
        public const string MarginValueLbl = "quoteSplit_summary_marginValue";
        public const string MarginPercentageLbl = "quoteSplit_summary_marginPercentage";
        public const string SubtotalAmountLbl = "quoteSplit_summary_subtotalAmount";
        public const string ShippingAmountLbl = "quoteSplit_summary_shippingAmount";
        public const string TotalTaxAmountLbl = "quoteSplit_summary_totalTaxAmount";
        public const string EcoFeeLbl = "quoteSplit_summary_ecoFee";
        public const string FinalPriceLbl = "quoteSplit_summary_finalPrice";

        // Item level controls
        public static int ItemIndex { get; set; }
        public static readonly string LineItemToggle = string.Format("quoteSplit_LI_{0}", ItemIndex);
        public static readonly string Item = string.Format("quoteSplit_LI_productDescription_{0}", ItemIndex);
        public static readonly string Edd = string.Format("quoteSplit_LI_edd_{0}", ItemIndex);
        public static readonly string UnitPrice = string.Format("quoteSplit_LI_unitPrice_{0}", ItemIndex);
        public static readonly string Quantity = string.Format("quoteSplit_LI_quantity_input_{0}", ItemIndex);
        public static readonly string ShippingAmount = string.Format("quoteSplit_LI_totalShippingAmount_{0}", ItemIndex);
        public static readonly string SellingPrice = string.Format("quoteSplit_LI_sellingPrice_{0}", ItemIndex);
        public static readonly string DiscountValue = string.Format("{0}_LI_discountValue", ItemIndex);
        public static readonly string DiscountPercent = string.Format("{0}_LI_discountPercent", ItemIndex);
        public static readonly string Margin = string.Format("quoteSplit_LI_margin_{0}", ItemIndex);
        public static readonly string MarginPercentage = string.Format("quoteSplit_LI_marginPercentage_{0}", ItemIndex);
        public static readonly string ContractCode = string.Format("quoteSplit_LI_contractCode_input_{0}", ItemIndex);
        public static readonly string ItemBuildTime = string.Format("quoteSplit_LI_itemBuildTime_{0}", ItemIndex);
        public static readonly string ItemShipDate = string.Format("quoteSplit_LI_itemShipDate_{0}", ItemIndex);
        public static readonly string OrderCode = string.Format("quoteSplit_LI_orderCode_{0}", ItemIndex);
        public static readonly string SkuNumber = string.Format("quoteSplit_LI_skuNumber_{0}", ItemIndex);
        public static readonly string GoalDealId = string.Format("quoteSplit_LI_goalDealId_{0}", ItemIndex);
        public static readonly string LineItemTax = string.Format("quoteSplit_LI_tax_{0}", ItemIndex);
        public static readonly string LineItemEcoFee = string.Format("quoteSplit_LI_ecoFee_{0}", ItemIndex);
        public static readonly string LineItemTotal = string.Format("quoteSplit_LI_totalAmount_{0}", ItemIndex);

        public static readonly string DellPayShippingMessageText = string.Format("quoteSplit_dellPayShippingMessageText_1{0}", ItemIndex);


        // Goal Control
        public static readonly string GoalNewRequest = string.Format("quoteSplit_createNewGoalDealId_{0}", ItemIndex);
        public static readonly string GoalPickFromList = string.Format("quoteSplit_selectGoalDealId_{0}", ItemIndex);
        public static readonly string GoalTool = string.Format("quoteSplit_openGoalTool_2{0}", ItemIndex);

        //Pricing Information
        public static readonly string PricingInformationToggle = string.Format("quoteSplit_LI_PI_toggle_{0}", ItemIndex);
        public static readonly string PricingInformationHeader = "quoteSplit_LI_PI_header";
        public static readonly string PiUnitPrice = string.Format("quoteSplit_LI_PI_unitPrice_{0}", ItemIndex);
        public static readonly string PiStateEnvFee = string.Format("quoteSplit_LI_PI_stateEnvFee_{0}", ItemIndex);
        public static readonly string PiUnitMargin = string.Format("quoteSplit_LI_PI_unitMargin_{0}", ItemIndex);
        public static readonly string PiShippingAmount = string.Format("quoteSplit_LI_PI_shippingAmount_{0}", ItemIndex);
        public static readonly string PiDol = string.Format("quoteSplit_LI_PI_dol_{0}", ItemIndex);
        public static readonly string PiTotalAmount = string.Format("quoteSplit_LI_PI_totalAmount_{0}", ItemIndex);

        //Discount
        public static readonly string DiscountTotal = string.Format("_li_discount_total_{0}", ItemIndex);
        public static readonly string DiscountToggle = string.Format("quoteSplit_LI_discount_Toggle_{0}", ItemIndex);

        // Configuration Specs
        public static readonly string ConfigurationSpecsToggle = string.Format("quoteSplit_LI_CS_toggle_{0}", ItemIndex);
        public static readonly string ConfigurationSpecsGrid = string.Format("quoteSplit_LI_CS_grid_{0}", ItemIndex);
        public static readonly string ConfigurationSpecsHeader = "quoteSplit_LI_CS_header";

        // Shipping Information
        public static readonly string ShippingToggle = string.Format("quoteSplit_LI_SI_toggle_{0}", ItemIndex);
        public static readonly string ShippingHeader = "quoteSplit_LI_SI_header";
        public static readonly string ShippingMethod = string.Format("quoteSplit_LI_SI_shippingMethod_{0}", ItemIndex);
        public static readonly string ShippingPickAddressLnk = string.Format("quoteSplit_LI_SI_shippingPickAddressLink_{0}", ItemIndex);
        public static readonly string ShippingNewAddressLnk = string.Format("quoteSplit_LI_SI_shippingNewAddressLink_{0}", ItemIndex);
        public static readonly string ShippingEmailAddressLnk = string.Format("quoteSplit_LI_SI_emailAddress_{0}", ItemIndex);
        public static readonly string ShippingArriveByDate = string.Format("quoteSplit_LI_SI_arriveByDate_{0}", ItemIndex);
        public static readonly string ShippingEstimatedDeliveryDate = string.Format("quoteSplit_LI_SI_estimatedDeliveryDate_{0}", ItemIndex);
        public static readonly string ShippingInstructions = string.Format("quoteSplit_LI_SI_shippingInstructions_{0}", ItemIndex);

        // Taxes       
        public static readonly string TaxesToggle = string.Format("quoteSplit_LI_taxes_toggle_{0}", ItemIndex);
        public static readonly string TaxesHeader = "quoteSplit_LI_taxes_header";
        public static readonly string TotalTax = string.Format("quoteSplit_LI_taxTotal_{0}", ItemIndex);
        public static readonly string TaxTable = string.Format("DataTables_Table_{0}", ItemIndex);

        // Notes
        public const string NotesToggleBtn = "quoteCreate_notesToggle";
        public const string NotesHeaderSpn = "quoteCreate_notes_header";
        public const string NotesTbl = "DataTables_Table_3";

        // Installationinstructions
        public const string InstallationinstructionsToggleBtn = "quoteCreate_installationinstructionsToggle";
        public const string InstallationinstructionsHeaderSpn = "quoteCreate_installationinstructions_header";
        public const string InstallationInstructionsTxtArea = "quoteCreate_installationInstructions";
        public const string SaveInstallationInstructionsLnk = "quoteCreate_saveInstallationInstructions";
        public const string CancelInstallationInstructionsLnk = "quoteCreate_cancelInstallationInstructions";

        // Customer Information
        public const string CustomerInformationToggle = "quoteSplit_customerInformationToggle";
        public const string CustomerInformationHeader = "//*[@id='quoteSplit_contactHeading']/div/span[1]/span";
        public const string CustomerId = "quoteSplit_customerId";
        public const string CustomerNumber = "quoteSplit_customerNumber";
        public const string CompanyName = "quoteSplit_companyName";
        public const string CompanyNumber = "quoteSplit_companyNumber";
        public const string CustomerClass = "quoteSplit_customerClass";
        public const string ParentReference = "quoteSplit_parentReference";
        public const string Channel = "quoteSplit_channel";
        public const string ContactCfoLanguage = "quoteSplit_contactCFOLang";
        public const string Address1 = "quoteSplit_address1";
        public const string Address2 = "quoteSplit_address2";
        public const string City = "quoteSplit_city";
        public const string State = "quoteSplit_state";
        public const string PostalCode = "quoteSplit_zip";
        public const string Country = "quoteSplit_primaryContactCountry";
        public const string PrimaryContactName = "quoteSplit_primaryContactName";
        public const string Department = "quoteSplit_department";
        public const string Email = "quoteSplit_email";
        public const string Telephone = "quoteSplit_telephone";

        // Financial Information
        public const string FinancialInformationId = "quoteSplit_financialInformationHeading";
        public const string FinancialInformationToggle = "//*[@id='quoteSplit_financialInformationHeading']/div/span/a";
        public const string FinancialInformationHeader = "//*[@id='quoteSplit_financialInformationHeading']/div/span[1]/span";
        public const string PaymentMethod = "quoteSplit_financingPaymentMethod";
        public const string PaymentTerms = "quoteSplit_paymentTerm";
        public const string Currency = "quoteSplit_currency";
        public const string Discount = "quoteSplit_discount";
        public const string FederalTaxId = "quoteSplit_federalTaxId";
        public const string TaxExempt = "quoteSplit_taxExempt";
        public const string DiscountEntitlements = "quoteSplit_discountEntitlements";
        public const string PromotionCode = "quoteSplit_promotionCode";
        public const string CustomerHold = "quoteSplit_customerHold";
        public const string CreditHold = "quoteSplit_creditHold";

        public const string CreditLimit = "quoteSplit_CreditLimit";
        public const string CurrentBalance = "quoteSplit_CurrentBalance";
        public const string RemainingBalance = "quoteSplit_RemainingBalance";

        public const string ThirtyDayBalance = "quoteSplit_30DayBalance";
        public const string SixtyDayBalance = "quoteSplit_60DayBalance";
        public const string PrimarySalesRep = "//*[@id='quoteSplit_salesRep']/span";
        public const string TagSalesRep = "quoteSplit_tagRepNew";
    }
}
