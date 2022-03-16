namespace Dsa.Constants
{
    public static class CustomerIDs
    {
        public const string SearchResultsRoute = "#/customer/customersearchresults/PartyId={0}";
        public const string DetailsViewRoute = "#/customer/details/Id/";
        public const string SelectSalesChannelHeader = "#COM > div.modal-medium.ng-scope > div > h3";
        

        public static string GetViewRouteForCustomerNumber(long customerNumber)
        {
            return string.Concat(DetailsViewRoute, customerNumber);
        }

        public const string ValidateAddressOKBtn = "customerDetails_validateAddress_address_ok";
        public const string AddShippingAddress = "customerDetails_shippingAddress";
        public const string CustomerInformationId = "customerDetails_customerDetails";
        public const string CustomerInformationGridId   = "customerDetails_customerInformation";
        public const string CustomerDetailHeader        = "customerDetails_header";
        public const string BillToAddressHeader         = "customerDetails_detailsHighlight_header_billToAddress";
        public const string ContactAddressId            = "customerDetails_contactAddressesToggle";
        public const string FinancialInfoId             = "customerDetails_financialInformationToggle";
        public const string FinancialInfoGridId         = "customerDetails_financialInformation";
        public const string CreateQuoteButtonId         = "customerDetails_createQuote";
        public const string ViewAccountId               = "customerDetails_viewAccountFromCustomer";
        public const string MoreActions                 = "customerDetails_moreActions";
        public const string UseInQuoteAsEndUser         = "customerDetails_useEndUser";
        public const string CustomerHold                = "customerDetails_CustomerHold";
        public const string CustomerStatus              = "customerDetails_Status";
        public const string AddMyAccount                = "_addMyAccount";
        public const string AddAffinityIdTextBoxId = "customerDetails_accountNumber";
        public const string AddAffinityIdLinkId = "customerDetails_showAdd";
        public const string AddAffinityAccountSubmitLinkId = "customerDetails_submitAccount";
        public const string AffinityErrorMessageId = "customerDetails_accountMessage";
        public const string CustomerDetailsMyAccountDiv = "customer-detail-add-myaccount";
        public const string CustomerDetailsMyAccountEmails = "customerDetails_myAccount";
        public const string ViewMoreMyAccounts = "_viewMore";


        public const string EnableDellAdvantageHyperlink = "_enableDellAdvantage";
        public const string EnableDellAdvantagePopYesBtn = "messageDialogButton_0";
        public const string EnableDellAdvantagePopNoBtn = "messageDialogButton_1";
        
        public const string QuoteId = "customerDetails_quoteListToggle";
        public const string QuoteGrid = "customerDetailsQuoteList";
        public const string QuoteListViewAll = "customerDetails_quoteListViewAll";
        public const string QuoteListPageHeader = "quote_list_h";
        
        public const string SalesRepId = "sales-rep-id";

        public const string CustomerNameLblCssSelector = "h3.pull-left";
        public const string CreditDetailsLblCssSelector = "#customerDetails_creditDetails_header";
        public const string AddCustomerDetailsButtonId = "customerDetails_addToYourCustomers";

        public const string CustomerDetailsMyAccountDivCssSelector =
            "#" + CustomerDetailsMyAccountDiv + " > div > div:nth-child(2)";

        public const string CustomerDetailsAddMyAccountLinkCssSelector =
            "#" + CustomerDetailsMyAccountDiv +
            " > div > div:nth-child(2) > div:nth-child(3) > div:not([class~='ng-hide']) > a";

        public const string MyAccountsPopupClassName = "modal-wrap";

        //LinkNumber
        public const string LinkNumberLabel = "customerDetails_linkNumber_label";
        public const string LinkTypeLabel = "customerDetails_companyNumber_label";
        public const string CompanyNumber = "customerDetails_companyNumber";
        public const string AddLinkNumberHyperlink = "customerDetails_addlinkNumber";
        public const string LinkNumberLabelValue = "customerDetails_linkNumber";
        public const string LinkTypeDropdown = "customerDetails_linkType";
        public const string SaveLinkNumberHyperlink = "customerDetails_updateLinkType";
        public const string CancelSaveLinkNumberHyperlink = "customerDetails_cancelLinkNumber";
        public const string SaveLinkNumberErrorDiv = "customerDetails_customerLinkNumberNotUpdated";
        public const string EditLinkNumberHyperlink = "customerDetails_updateLinkNumber";
        public const string DeleteLinkNumberHyperlink = "customerDetails_deleteLinkNumber";
        
        //For DFS Customer
        public const string DfsCustomerNumberLbl = "customerDetails_customerNum";
        //public const string DfsCustomerMessage = "customerDetails_dfsMessage";
        public const string DfsCustomerMessage = "_dfsEnabled_dfsMessage";
        //public const string DfsCustomerStatus = "customerDetails_dfsStatus";
        public const string DfsCustomerStatus = "_dfsEnabled_dfsStatus";
        public const string DfsCustomerCreditStatus = "customerDetails_dbcCreditStatus";
        public const string DfsCustomerLeaseCreditStatus = "customerDetails_leaseCreditStatus";
        public const string DfsCustomerPaymentTerms = "customerDetails_paymentTerms";
        public const string DfsCustomerCurrency     = "customerDetails_currency";
        public const string DfsCustomerCreditLimit  = "customerDetails_creditLimit";
        public const string DfsCustomerCurrentBalance = "customerDetails_currencyBalance";
        public const string DfsCustomerFinancialInfoHeader = "customerDetails_financialInformation_heading";
        public const string DfsEligible = "customerDetails_dfsEnabled_dfsStatus";

        public const string OrderSection = "customerDetails_orderListSection";
        public const string OrderId = "customerDetails_orderListHeading";
        public const string OrderGrid = "customerDetails_ordersGrid";
        public const string OrderList = "customerDetails_orderList";
        public const string OrderListViewAll = "customerDetails_orderListViewAll";

        //Customer ShipToAddress Add related constants
        public const string ShipToAddressId = "customerDetails_shipToAddressesHeading";
        public const string ShipToAddressGrid = "customerDetails_shipToAddresses";
        public const string ShipToAddressViewAll = "customerDetails_shippingAddressesListViewAll";
        public const string ShipToAddressAllGrid = "customerDetailsShipToAddressList";
        public const string ShipToAddressAllHeader = "customer_shipping_addresses_list_h";

        public const string AddShipToAddressLink = "customerDetails_shippingAddress";
        public const string AddShippingAddressHeader = "customerDetails_shippingAddress_header";
        public const string AddShippingDivId = "customerDetails_add_shippingAddress";
        public const string AddShippingCompanyNameId = "customerDetails_addShippingAddress_companyName";
        public const string AddShippingFirstNameId = "customerDetails_addShippingAddress_firstName";
        public const string AddShippingMiddleNameId = "customerDetails_addShippingAddress_middleName";
        public const string AddShippingLastNameId = "customerDetails_addShippingAddress_lastName";
        public const string AddShippingTitle = "customerDetails_addShippingAddress_title";
        public const string AddShippingDepartmentId = "customerDetails_addShippingAddress_department";
        public const string AddShippingMailStop = "customerDetails_addShippingAddress_mailstop";
        public const string AddShippingPrimaryPhoneId = "customerDetails_addShippingAddress_primaryPhone";
        public const string AddShippingSecPhoneId = "customerDetails_addShippingAddress_secondaryPhone";
        public const string AddShippingFaxNumberId = "customerDetails_addShippingAddress_fax";
        public const string AddShippingAddress1 = "customerDetails_addShippingAddress_addressLine1";
        public const string AddShippingAddress2 = "customerDetails_addShippingAddress_addressLine2";
        public const string AddShippingCity = "customerDetails_addShippingAddress_city";
        public const string AddShippingState = "customerDetails_addShippingAddress_state";
        public const string AddShippingZipCode = "customerDetails_addShippingAddress_zipCode";
        public const string AddShippingZipCodeExtension = "customerDetails_addShippingAddress_zipCodeExtension";
        public const string AddShippingCountry = "customerDetails_addShippingAddress_country";
        public const string AddShippingEmailId = "customerDetails_addShippingAddress_email";
        public const string AddShippingSaveButton = "customerDetails_addShippingAddress_save";
        public const string AddShippingCancelButton = "customerDetails_addShippingAddress_cancel";

        public const string AddressSuggestionModal      = "customerDetails_validateAddress_shippingAddress_validation_withSuggestion";
        public const string AddressSuggestionHeader     = "customerDetails_validateAddress_shippingAddress_validation_withSuggestion_header";
        public const string AddressSuggestionTitle      = "customerDetails_validateAddress_entered_address_header";
        public const string CannotValidateAddressModal  = "customerDetails_validateAddress_shippingAddress_validationMessage";
        public const string CannotValidateAddressHeader = "customerDetails_validateAddress_shippingAddress_validationMessage_header";
        
        public const string ValidateAddressAdditionalMsg = "customerDetails_validateAddress_additionalMessages";
        public const string ValidateAddressOKButton     = "customerDetails_validateAddress_address_ok";
        public const string ValidateAddressCancelButton = "customerDetails_validateAddress_address_cancel";
        public const string ValidateAddressEditButton   = "customerDetails_validateAddress_address_edit";
        public const string SuggestedAddressLine1       = "customerDetails_validateAddress_suggested_line1_";
        public const string SuggestedAddressLine2       = "customerDetails_validateAddress_suggested_line2_";
        public const string SuggestedAddressCityStateZip = "customerDetails_validateAddress_suggested_line3_";
        public const string SuggestedAddressCountry     = "customerDetails_validateAddress_suggested_country_";
        public const string EnteredAddressLine1         = "customerDetails_validateAddress_entered_line1";
        
        public const string SuggestedAddressEdit            = "customerDetails_validateAddress_addShippingAddress_edit";
        public const string SuggestedAddressSelect          = "customerDetails_validateAddress_addShippingAddress_select";
        public const string CannotValidateAddressOKButton   = "customerDetails_validateAddress_addShippingAddress_ok";
        public const string CannotValidateAddressCancelButton = "customerDetails_validateAddress_addShippingAddress_cancel";
        public const string SuggestShippingCancelButton     = "customerDetails_validateAddress_addShippingAddress_close";
        public const string ValidateAddressStreet           = "customerDetails_validateAddress_input_street";
        public const string ValidateAddressUnit             = "customerDetails_validateAddress_input_unit";

        public const string BillToAddrCompanyName   = "customerDetails_billToAddress_companyName";
        public const string BillToAddrContactName   = "customerDetails_billToAddress_contactName";
        public const string BillToAddrContactPhone  = "customerDetails_billToAddress_contactPhone";
        public const string BillToAddrContactEmail  = "customerDetails_billToAddress_contactEmail";
        public const string BillToAddrFax           = "customerDetails_billToAddress_customerFax";
        public const string BillToAddrTitle         = "customerDetails_billToAddress_title";

        public const string BillToAddrLine1         = "customerDetails_billToAddress_address1";
        public const string BillToAddrLine2         = "customerDetails_billToAddress_address2";
        public const string BillToAddrCity          = "customerDetails_billToAddress_city";
        public const string BillToAddrState         = "customerDetails_billToAddress_state";
        public const string BillToAddrZip           = "customerDetails_billToAddress_zipCode";
        public const string BillToAddrCountry       = "customerDetails_billToAddress_country";
        public const string BillToAddrDept          = "customerDetails_billToAddress_department";
        public const string BillToAddrMailstop      = "customerDetails_billToAddress_mailstop";

        // AddNewCustomer: Notes constants
        public const string NoteId          = "customerDetails_notesToggle";
        public const string ViewAllNotes    = "customerDetails_NotesViewAll";
        public const string AddNoteId       = "customerDetails_addNote";
        public const string AddNoteHeaderId = "customerDetails_addNote_heading";
        public const string NoteGrid        = "notesList";
        public const string AllNotesGrid    = "notesList";     // yes, it's a different grid but uses same id
        public const string AllNotesCustomerName    = "customerViewAllNotes_customerName";
        public const string AllNotesAccountName     = "customerViewAllNotes_accountName";
        public const string PerPageDropdown = "grid_paging_itemsPerPage";
        
        public const string NoResultsMessage = "common_noResults_message";
        public const string AddNoteTextBoxId = "_comments";
        public const string AddNoteSaveButtonId = "_save";

        public const string CustomerSearchResultHeaderId = "customer_searchResults_selectionHeader";
        public const string CustomerPartyHeaderId       = "customer_savedSearches_h";
        public const string CustomerPartyEditSearch     = "customer_searchEdit_link";

        public const string CustomerPartyRefineSearch           = "customerParty_noResults_editSearch";
        public const string CustomerPartyNoHitsExactMatch       = "customerParty_noResults_exactMatch";
        public const string CustomerPartyEnterSearchTermTextBox = "customerParty_searchFilter_value";
        public const string CustomerPartySearchButton           = "customerParty_searchAction";
        public const string CustomerPartySearchFilterDropdown   = "customerParty_searchFilter";

        public const string PartySearchResultGrid       = "customerSearchResults_partyGrid";
        public const string CustomerSearchResultGrid    = "customerSearchResult_grid";
        public const string CustomerSearchButtonId      = "customerSearch_searchAction";
        public const string CompanyNameInputFieldId     = "customerSearch_companyName";
        public const string EmailInputFieldId           = "customerSearch_email";
        public const string PhoneNumberInputFieldId     = "customerSearch_phoneNumber";
        public const string CustomerNumberInputFieldId  = "customerSearch_customerNumber";
        public const string OrderNumberInputFieldId     = "customerSearch_orderNumber";

        public static string ContactFirstNameInputFieldId   = "customerSearch_contactFirstName";
        public static string ContactMiddleNameInputFieldId  = "customerSearch_contactMiddleName";
        public static string ContactLastNameInputFieldId    = "customerSearch_contactLastName";
        public static string ContactAddressLine1InputFieldId = "customerSearch_address1";
        public static string ContactAddressLine2InputFieldId = "customerSearch_address2";
        public static string ContactCityInputFieldId        = "customerSearch_city";
        public static string ContactStateInputFieldId       = "customerSearch_state";
        public static string ContactZipCodeInputFieldId     = "customerSearch_zip";
        public static string DpidNumberInputFieldId         = "customerSearch_DPIDNumber";
        public static string QuoteNumberInputFieldId        = "customerSearch_QuoteNumber";
        public static string AffinityAccountIdInputFieldId  = "customerSearch_AffinityAccountID";

        public static string CustSearchValidationModalId = "customerSearch_validationMessage";
        public static string CustSearchExactMatchFlagId = "customerSearch_ExactMatches";
        public static string AddressTypeDropdown        = "customerSearch_addressType";

        public static string FirstNameRequiredIcon = "customerSearch_validationIcon_contactFirstName";
        public static string LastNameRequiredIcon = "customerSearch_validationIcon_contactLastName";
        public static string CompanyRequiredIcon = "customerSearch_validationIcon_companyName";
        public static string PhoneRequiredIcon = "customerSearch_validationIcon_phoneNumber";
        public static string CityRequiredIcon = "customerSearch_validationIcon_city";
        public static string StateRequiredIcon = "customerSearch_validationIcon_state";
        public static string ZipRequiredIcon = "customerSearch_validationIcon_zip";
        public static string EmailRequiredIcon = "customerSearch_validationIcon_email";
        public static string SalesRepRequiredIcon = "customerSearch_validationIcon_primarySalesRepID";
        public static string ValidCombinationsLink = "customerSearch_viewCombinationSearch";
        public static string ClearSearchButton = "customerSearch_clearAction";

        public const int Display20Items = 20;
        public const string GridPagingDisplay20Items = "1-20";

        // AddNewCustomer: Metadata
        public const string AddNewCustomerHeader = "customerCreate_header";
        public const string AddNewCustomerSaveButton = "customerCreate_saveCustomer";
        public const string AddNewCustomerCancelButton = "customerCreate_cancel";
        public const string AddNewCustomerNotes = "customerCreate_notes";

        // AddNewCustomer: Contact Information constants
        public const string CustCreateContactInfoDisplayMode = "customerCreate_contactInformation";
        public const string ContactInfoBusinessUnitId = "customerCreate_contactInformation_businessUnit";
        public const string ContactInfoCompanyNameId = "customerCreate_contactInformation_companyName";
        public const string ContactInfoCompanyNumberId = "customerCreate_contactInformation_segment";
        public const string ContactInfoCustomerClassId = "customerCreate_contactInformation_customerClass";
        //public const string ContactInfoCustomerClassId = "_contactInformation_customerClass";


        public const string ContactInfoParentRefId = "customerCreate_contactInformation_parentReference";
        public const string ContactInfoChannelId = "customerCreate_contactInformation_channel";


        // AddNewCustomer: Billing Address constants
        public static readonly string BillingInfoTitle = "customerCreate_billingInformation_title";
        public static readonly string BillingInfoFirstNameId = "customerCreate_billingInformation_firstName";
        public static readonly string BillingInfoMiddleNameId = "customerCreate_billingInformation_middleName";
        public static readonly string BillingInfoLastNameId = "customerCreate_billingInformation_lastName";
        public static readonly string BillingInfoDeptId = "customerCreate_billingInformation_department";
        public static readonly string BillingInfoEmailId = "customerCreate_billingInformation_email";
        public static readonly string BillingInfoPrimaryPhoneId = "customerCreate_billingInformation_primaryPhone";
        public static readonly string BillingInfoSecondaryPhoneId = "customerCreate_billingInformation_secondaryPhone";
        public static readonly string BillingInfoFaxNumId = "customerCreate_billingInformation_faxNumber";
        public static readonly string BillingInfoAddLine1Id = "customerCreate_billingInformation_line1";
        public static readonly string BillingInfoAddLine2Id = "customerCreate_billingInformation_line2";
        public static readonly string BillingInfoCityId = "customerCreate_billingInformation_city";
        public static readonly string BillingInfoStateId = "customerCreate_billingInformation_state";
        public static readonly string BillingInfoZipCodeId = "customerCreate_billingInformation_postalCode";
        public static readonly string BillingInfoCountryId = "customerCreate_billingInformation_country";
        public static readonly string BillingInfoPlusFour = "customerCreate_billingInformation_extensionpostalCode";
        public static readonly string BillingInfoInvoiceEmail = "customerCreate_billingInformation_invoicingEmail";
        public static readonly string BillingInfoHomePhoneId = "customerCreate_billingInformation_homePhone";
        public static readonly string BillingInfoInvoiceDeliveryMethodName = "invoiceDeliveryMethod";

        // AddNewCustomer: Shipping Address constants
        public static readonly string ShippingAddrTitle = "customerCreate_shippingInformation_title";
        public static readonly string ShippingAddrSameAsBillingId = "customerCreate_shippingAddress_sameAsBilling";
        public static readonly string ShippingAddrCompanyNameId = "customerCreate_shippingAddress_companyName";
        public static readonly string ShippingAddrFirstNameId = "customerCreate_shippingAddress_firstName";
        public static readonly string ShippingAddrMiddleNameId = "customerCreate_shippingAddress_middleName";
        public static readonly string ShippingAddrLastNameId = "customerCreate_shippingAddress_lastName";
        public static readonly string ShippingAddrTitleId = "customerCreate_shippingAddress_title";
        public static readonly string ShippingAddrDeptId = "customerCreate_shippingAddress_department";
        public static readonly string ShippingAddrPrimaryPhoneId = "customerCreate_shippingAddress_primaryPhone";
        public static readonly string ShippingAddrSecondaryPhoneId = "customerCreate_shippingAddress_secondaryPhone";
        public static readonly string ShippingAddrFaxNumId = "customerCreate_shippingAddress_faxNumber";
        public static readonly string ShippingAddrAddLine1Id = "customerCreate_shippingAddress_line1";
        public static readonly string ShippingAddrAddLine2Id = "customerCreate_shippingAddress_line2";
        public static readonly string ShippingAddrMailStopId = "customerCreate_shippingAddress_mailStop";
        public static readonly string ShippingAddrCityId = "customerCreate_shippingAddress_city";
        public static readonly string ShippingAddrStateId = "customerCreate_shippingAddress_state";
        public static readonly string ShippingAddrZipCodeId = "customerCreate_shippingAddress_postalCode";
        public static readonly string ShippingAddrCountryId = "customerCreate_shippingAddress_country";
        public static readonly string ShippingAddrPlusFour = "customerCreate_shippingAddress_extensionpostalCode";
        public static readonly string ShippingAddrEmail = "customerCreate_shippingAddress_email";
        public static readonly string ShippingAddrHomePhone = "customerCreate_shippingAddress_homePhone";
        public static readonly string ShippingAddrInvoicingEmail = "customerCreate_shippingAddress_invoicingEmail";

        public static readonly string MailingAddrSameAsBillingId = "customerCreate_mailingAddress_sameAsBilling";
        public static readonly string MailingAddrPlusFour = "customerCreate_mailingAddress_extensionpostalCode";
        public static readonly string MailingAddrZipCodeId = "customerCreate_mailingAddress_postalCode";
        public static readonly string MailingAddrStateId = "customerCreate_mailingAddress_state";
        public static readonly string MailingAddrCityId = "customerCreate_mailingAddress_city";
        public static readonly string MailingAddrAddLine1Id = "customerCreate_mailingAddress_line1";
        public static readonly string MailingAddrInvoicingEmail = "customerCreate_mailingAddress_invoicingEmail";
        public static readonly string MailingAddrHomePhone = "customerCreate_mailingAddress_homePhone";
        public static readonly string MailingAddrLastNameId = "customerCreate_mailingAddress_lastName";
        public static readonly string MailingAddrFirstNameId = "customerCreate_mailingAddress_firstName";
        public static readonly string MailingAddrTitle = "customerCreate_mailingAddress_title";

        // AddNewCustomer: Financial constants
        public const string CustCreateFinancialDisplayMode = "customerCreate_financialInformation";
        public const string FinancialPaymentTermId = "customerCreate_financialInformation_paymentTerm";
        public const string FinancialCurrencyId = "customerCreate_financialInformation_currency";
        public const string FinancialInvoiceDeliveryMethodId = "customerCreate_financialInformation_invoiceDeliveryMethod";
        public const string FinancialDiscountCodeId = "customerCreate_financialInformation_discountCode";
        public const string FinancialTaxId = "customerCreate_financialInformation_taxId";
        public const string CustCreateSalesRepId = "customerCreate_relationshipManagement_primarySalesRep";

        public const string RemainingBalanceLable = "customerDetails_remainingBalance";
        public const string CreditDetails = "credit-details-container";

        // AddNewCustomer: Validation constants
        public const string CustomerCreateValidationModelId = "customerCreate_validation_authorization";
        public const string CustCreateEnteredAddrHeader = "customerAddress_suggestions_entered_address_header";

        // AddNewCustomer: Dupe Customer Warning popup
        public const string CustCreateSuggestnsWithSuggestnModalId = "customerCreate_suggestions_withSuggestion";
        public const string DupeCustModalEnteredAddrHeader = "customerCreate_suggestions_entered_address_header";
        public const string DupeCustModalSimilarAddrHeader = "customerCreate_suggestions_withSuggestion_header_0";
        public const string DupeCustModalCloseButton = "customerCreate_suggestions__close"; //double underscore
        public const string DupeCustModalSaveEnteredButton = "customerCreate_suggestions_entered_save";
        public const string DupeCustModalSuggestedCorrectButton = "customerCreate_suggestions_suggested_correct_0";
        public const string CustCreateShipAddrLine1Message = "customerCreate_shippingAddress_line1Message";
        public const string CustCreateShipAddrLine2Message = "customerCreate_shippingAddress_line2Message";
        
        // admin
        public const string UseInQuoteBtn = "customerDetails_createQuote";

        // MyAccount
        public const string SearchMyAccountEmailTextbox = "search_email_input";
        public const string SearchMyAccountButton = "search_email";
        public const string MyAccountFirstNameTextbox = "myaccount_first_name";
        public const string MyAccountLastNameTextbox = "myaccount_last_name";
        public const string MyAccountEmailAddressTextbox = "myaccount_email_address";
        public const string MyAccountAddressLine1Textbox = "myaccount_address_line1";
        public const string MyAccountAddressLine2Textbox = "myaccount_address_line2";
        public const string MyAccountCityTextbox = "myaccount_city";
        public const string MyAccountStateTextbox = "myaccount_state";
        public const string MyAccountZipTextbox = "myaccount_zip_code";
        public const string MyAccountZip4Textbox = "myaccount_zip_4";
        public const string MyAccountIncludeOfferCheckbox = "myaccount_include_offers";
        public const string MyAccountEnableDellAdvantageCheckbox = "myaccount_enable_dell_advantage";
        public const string AddMyAccountButton = "_addMyAccountButton";
        public const string CancelAddMyAccountButton = "_cancel";
        public const string CloseMyAccountPopup = "_close";
        public const string SearchEmailErrorDiv = "_emailSearchErrorSection";
        public const string AssociateMyAccountErrorDiv = "_associateMyAccountErrorSection";
        public const string SearchMyAccountSuccessMessageRow1 = "#COM > div.modal-small.ng-scope > div > div:nth-child(3) > div.modal-body > div:nth-child(2) > div";
        public const string SearchMyAccountSuccessMessageRow2 = "#COM > div.modal-small.ng-scope > div > div:nth-child(3) > div.modal-body > div:nth-child(3) > div";
        public const string AddMyAccountFormValidationErrorDiv = "_formValidationErrorSection";
    }
}
