//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Dsa.DataModels;
using System;
using Dsa.Enums;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;


namespace Dsa.Pages.Customer
{
    public class CustomerCreatePage : DsaPageBase
    {
        public CustomerCreatePage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements


        public IWebElement SearchResultsRoute { get { return WebDriver.GetElement(By.XPath("#/customer/customersearchresults/PartyId={0}")); } }

        public IWebElement DetailsViewRoute { get { return WebDriver.GetElement(By.XPath("#/customer/details/Id/")); } }

        public IWebElement AddMyAccount { get { return WebDriver.GetElement(By.Id("_addMyAccount")); } }

        public IWebElement TxtAddAffinityId { get { return WebDriver.GetElement(By.Id("customerDetails_accountNumber")); } }

        public IWebElement ViewMoreMyAccounts { get { return WebDriver.GetElement(By.Id("_viewMore")); } }

        public IWebElement LnkEnableDellAdvantage { get { return WebDriver.GetElement(By.Id("_enableDellAdvantage")); } }

        public IWebElement BtnEnableDellAdvantagePopYes { get { return WebDriver.GetElement(By.Id("messageDialogButton_0")); } }

        public IWebElement BtnEnableDellAdvantagePopNo { get { return WebDriver.GetElement(By.Id("messageDialogButton_1")); } }

        public IWebElement HdrQuoteListPage { get { return WebDriver.GetElement(By.Id("quote_list_h")); } }

        public IWebElement SalesRepId { get { return WebDriver.GetElement(By.Id("sales-rep-id")); } }

        public IWebElement LblCustomerName { get { return WebDriver.GetElement(By.Id("h3.pull-left")); } }

        public IWebElement MyAccountsPopupClassName { get { return WebDriver.GetElement(By.Id("modal-wrap")); } }

        public IWebElement DdlPerPage { get { return WebDriver.GetElement(By.Id("grid_paging_itemsPerPage")); } }

        public IWebElement MsgNoResults { get { return WebDriver.GetElement(By.Id("common_noResults_message")); } }

        public IWebElement TxtAddNote{ get { return WebDriver.GetElement(By.Id("_comments")); } }

        public IWebElement BtnAddNoteSave{ get { return WebDriver.GetElement(By.Id("_save")); } }

        public IWebElement HdrCustomerSearchResult{ get { return WebDriver.GetElement(By.Id("customer_searchResults_selectionHeader")); } }

        public IWebElement HdrCustomerParty { get { return WebDriver.GetElement(By.Id("customer_savedSearches_h")); } }

        public IWebElement CustomerPartyRefineSearch { get { return WebDriver.GetElement(By.Id("customerParty_noResults_editSearch")); } }

        public IWebElement CustomerPartyNoHitsExactMatch { get { return WebDriver.GetElement(By.Id("customerParty_noResults_exactMatch")); } }

        public IWebElement GridCustomerSearchResult { get { return WebDriver.GetElement(By.Id("customerSearchResult_grid")); } }

        public IWebElement BtnCustomerSearch { get { return WebDriver.GetElement(By.Id("customerSearch_searchAction")); } }

        public IWebElement EmailInputFieldId { get { return WebDriver.GetElement(By.Id("customerSearch_email")); } }

        public IWebElement OrderNumberInputFieldId { get { return WebDriver.GetElement(By.Id("customerSearch_orderNumber")); } }

        public IWebElement GridPagingDisplay20Items { get { return WebDriver.GetElement(By.Id("1-20")); } }

        public IWebElement HdrAddNewCustomer { get { return WebDriver.GetElement(By.Id("customerCreate_header")); } }

        public IWebElement CustCreateCurrency { get { return WebDriver.GetElement(By.XPath("//*[@id='customerCreate_finance_currency']")); } }

        public IWebElement BtnAddNewCustomerSave { get { return WebDriver.GetElement(By.Id("customer_create_navigation_save")); } }

        public IWebElement BtnAddNewCustomerCancel { get { return WebDriver.GetElement(By.Id("customer_create_navigation_cancel")); } }

        public IWebElement AddNewCustomerNotes { get { return WebDriver.GetElement(By.Id("customerCreate_notes")); } }

        public IWebElement CustCreateContactInfoDisplayMode { get { return WebDriver.GetElement(By.Id("customerCreate_contactInformation")); } }

        public IWebElement ContactInfoBusinessUnitId { get { return WebDriver.GetElement(By.Id("customerCreate_information_businessUnit")); } }

        public IWebElement ContactInfoCompanyNameId { get { return WebDriver.GetElement(By.Id("customerCreate_information_company_name")); } }

        public IWebElement EmailMP { get { return WebDriver.GetElement(By.Id("createCustomerBilling_Marketing_Preference_OptIn_email")); } }

        public IWebElement CompNumberDisplay { get { return WebDriver.GetElement(By.XPath("//td[contains(text(),'No items in list.')]")); } }
       
        #region PMC

        public IWebElement BillingCustomerConsentNotification { get { return WebDriver.GetElement(By.XPath("//*[@id='body-content']//div[2]//div[2]//div[contains(text(), 'When collecting or updating a customer')]")); } }

        public IWebElement BillingPMCUpdateNotification{ get { return WebDriver.GetElement(By.XPath("//*[@id='body-content']//div[2]//div[2]//div[contains(text(), 'Any update to PMC will take up to 24/48 hours to reflect in DSA.')]")); } }

        public IWebElement ShippingCustomerConsentNotification { get { return WebDriver.GetElement(By.XPath("//*[@id='body-content']//div[4]//div[2]//div[contains(text(), 'When collecting or updating a customer')]")); } }

        public IWebElement ShippingPMCUpdateNotification { get { return WebDriver.GetElement(By.XPath("//*[@id='body-content']//div[4]//div[2]//div[contains(text(), 'Any update to PMC will take up to 24/48 hours to reflect in DSA.')]")); } }

        public IWebElement BillingExpandCustomerConsent { get { return WebDriver.GetElement(By.XPath("//*[@id='body-content']//div[2]//div[2]//div[contains(text(), 'Read Privacy Notice Script')]")); } }

        public IWebElement ShippingExpandCustomerConsent { get { return WebDriver.GetElement(By.XPath("//*[@id='body-content']//div[4]//div[2]//div[contains(text(), 'Read Privacy Notice Script')]")); } }

        public IWebElement BillingConsentScriptText { get { return WebDriver.GetElement(By.XPath("//marketing-preference[@name='billingMarketingPreference']//p[contains(text(),'To learn how Dell uses your data and how to set ma')]")); } }

        public IWebElement ShippingConsentScriptText { get { return WebDriver.GetElement(By.XPath("//marketing-preference[@name='shippingMarketingPreference']//p[contains(text(),'To learn how Dell uses your data and how to set ma')]")); } }
       
        public IWebElement BillingConsentScript(int? ConsentIndex)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='body-content']//div[2]/div[2]//div//p[" + ConsentIndex + "]"));
        }
        

        public IWebElement ShippingConsentScript(int? ConsentIndex)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='body-content']//div[4]/div[2]//div//p[" + ConsentIndex + "]"));
        }     

         public IWebElement BillingPMCOptIn(string PMCField)
        {
            return WebDriver.FindElement(By.Id("createCustomerBilling_Marketing_Preference_OptIn_" + PMCField + ""));
        }

        public IWebElement BillingPMCOptOut(string PMCField)
        {
            return WebDriver.FindElement(By.Id("createCustomerBilling_Marketing_Preference_OptOut_" + PMCField + ""));
        }

        public IWebElement ShippingPMCOptIn(string PMCField)
        {
            return WebDriver.FindElement(By.Id("createCustomerShipping_Marketing_Preference_OptIn_" + PMCField + ""));
        }

        public IWebElement ShippingPMCOptOut(string PMCField)
        {
            return WebDriver.FindElement(By.Id("createCustomerShipping_Marketing_Preference_OptOut_" + PMCField + ""));
        }

        public IWebElement BillingCustomerConsentScript { get { return WebDriver.GetElement(By.XPath("//*[@id= 'body-content']//div[2]//div[2]//div[contains(text(),'When collecting or updating a customer')]")); } }

        public IWebElement ShippingCustomerConsentScript { get { return WebDriver.GetElement(By.XPath("//*[@id= 'body-content']//div[4]//div[2]//div[contains(text(),'Read Privacy Notice Script')]")); } }

        public IWebElement ExpandShippingCustomerConsentScript { get { return WebDriver.GetElement(By.XPath("//marketing-preference[@name='shippingMarketingPreference']//div[@class='col-md-12']//div[@class='col-md-12']")); } }

        public IWebElement ExpandBillingCustomerConsentScript { get { return WebDriver.GetElement(By.XPath("//marketing-preference[@name='billingMarketingPreference']//div[@class='col-md-12']//div[@class='col-md-12']")); } }

        public IWebElement LangEnglish { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'English')] ")); } }

        public IWebElement LangFrench { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'French')] ")); } }



        #endregion

        public string GetEmailMP()
        {
            return EmailMP.GetText(WebDriver);
        }

        public IWebElement PhonePMC { get { return WebDriver.GetElement(By.Id("createCustomerBilling_Marketing_Preference_OptIn_phone")); } }
        public string GetPhonePMC()
        {
            return PhonePMC.GetText(WebDriver);
        }

        public IWebElement MobilePMCOptIn { get { return WebDriver.GetElement(By.Id("createCustomerBilling_Marketing_Preference_OptIn_mobilee")); } }

        public string GetMobilePMC()
        {
            return MobilePMCOptIn.GetText(WebDriver);
        }

        public IWebElement MobilePMCOptout { get { return WebDriver.GetElement(By.Id("createCustomerBilling_Marketing_Preference_OptOut_mobile")); } }

        public string GetMobilePMCOptOut()
        {
            return MobilePMCOptout.GetText(WebDriver);
        }

        public void addCustomerWithInvalidEmail(IWebDriver driver, DataRow row, string randomemailaddress)
        {
            CompanyName.SetText(driver, row["Company_Name"].ToString(), null);
            BillingContactFirstNameTxt.SetText(driver, row["First_Name"].ToString(), null);
            BillingContactLastNameTxt.SetText(driver, row["Last_Name"].ToString(), null);
            BillingContactInvoicingEmailTxt.SetText(driver, randomemailaddress, null);
            BillingContacMobilePhoneTxt.SetText(driver, row["Billing_Phone"].ToString(), null);
            ContactCompPhone.SetText(driver, row["Company_Phone"].ToString(), null);
            CustomerBillingAddressLine1Txt.SetText(driver, row["Address_Line1"].ToString(), null);
            CustomerBillingZipCodeTxt.SetText(driver, row["Zip_Code"].ToString(), null);

        }

        public void addCustomerWithInvalidPhoneBilling(IWebDriver driver, DataRow row, string randomemphonenumber)
        {
            BillingContactFirstNameTxt.SetText(driver, row["First_Name"].ToString(), null);
            BillingContactLastNameTxt.SetText(driver, row["Last_Name"].ToString(), null);
            BillingContactInvoicingEmailTxt.SetText(driver, row["BillingEmail"].ToString(), null);
            BillingContacMobilePhoneTxt.SetText(driver, randomemphonenumber, null);
            CompanyName.SetText(driver, row["CompanyName"].ToString(), null);
            ContactCompPhone.SetText(driver, row["Company_Phone"].ToString(), null);
            CustomerBillingAddressLine1Txt.SetText(driver, row["BillingAddressLine1"].ToString(), null);
            CustomerBillingZipCodeTxt.SetText(driver, row["BillingZip"].ToString(), null);

        }


        public void addCustomerWithInvalidEmailConsumerCust(IWebDriver driver, DataRow row, string randomemailaddress)
        {
            BillingContactFirstNameTxt.SetText(driver, row["First_Name"].ToString(), null);
            BillingContactLastNameTxt.SetText(driver, row["Last_Name"].ToString(), null);
            BillingContactInvoicingEmailTxt.SetText(driver, randomemailaddress, null);
            BillingContacMobilePhoneTxt.SetText(driver, row["BillingMobilePhone"].ToString(), null);
            CustomerBillingAddressLine1Txt.SetText(driver, row["BillingAddressLine1"].ToString(), null);
            CustomerBillingZipCodeTxt.SetText(driver, row["BillingZip"].ToString(), null);

        }


        public void addCustomerBilling(IWebDriver driver, DataRow row)
        {
            CompanyName.SetText(driver, row["Company_Name"].ToString(), null);
            BillingContactFirstNameTxt.SetText(driver, row["First_Name"].ToString(), null);
            BillingContactLastNameTxt.SetText(driver, row["Last_Name"].ToString(), null);
            BillingContactInvoicingEmailTxt.SetText(driver, row["Billing_Email"].ToString(), null);
            BillingContacMobilePhoneTxt.SetText(driver, row["Billing_Phone"].ToString(), null);
            ContactCompPhone.SetText(driver, row["Company_Phone"].ToString(), null);
            CustomerBillingAddressLine1Txt.SetText(driver, row["Address_Line1"].ToString(), null);
            CustomerBillingZipCodeTxt.SetText(driver, row["Zip_Code"].ToString(), null);

        }

        public void addCustomerShippingInvalidPhone(IWebDriver driver, DataRow row, string randomphonenumber)
        {
            ShippingContactFirstNameTxt.SetText(driver, row["First_Name"].ToString(), null);
            ShippingContactLastNameTxt.SetText(driver, row["Last_Name"].ToString(), null);
            ShippingContactInvoicingEmailTxt.SetText(driver, row["Billing_Email"].ToString(), null);
            ShippingContactMobileHomeTxt.SetText(driver, randomphonenumber, null);
            ShippingContactAddressLine1Txt.SetText(driver, row["Address_Line1"].ToString(), null);
            ShippingContactZipCodeTxt.SetText(driver, row["Zip_Code"].ToString(), null);

        }

        public void addCustomerShippingInvalidEmail(IWebDriver driver, DataRow row, string randomemailaddress)
        {
            ShippingContactFirstNameTxt.SetText(driver, row["First_Name"].ToString(), null);
            ShippingContactLastNameTxt.SetText(driver, row["Last_Name"].ToString(), null);
            ShippingContactInvoicingEmailTxt.SetText(driver, randomemailaddress, null);
            ShippingContactMobileHomeTxt.SetText(driver, row["Billing_Phone"].ToString(), null);
            ShippingContactAddressLine1Txt.SetText(driver, row["Address_Line1"].ToString(), null);
            ShippingContactZipCodeTxt.SetText(driver, row["Zip_Code"].ToString(), null);

        }

        public List<IWebElement> AllEmailOverrideValidation { get { return WebDriver.GetElements(By.XPath("//div/email-errors//input[@class='form-input']")); } }

        public List<IWebElement> AllPhoneOverrideValidation { get { return WebDriver.GetElements(By.XPath("//div/phone-errors//input[@class='form-input']")); } }

        public IWebElement directMailPMC { get { return WebDriver.GetElement(By.Id("createCustomerBilling_Marketing_Preference_OptIn_directMail")); } }

        public IWebElement CompanyName { get { return WebDriver.GetElement(By.Id("customerCreate_information_company_name")); } }

        public By LblCompany_NameBy = By.Id("customerCreate_information_company_name");

        public IWebElement ContactInfoCompanyNumberId { get { return WebDriver.GetElement(By.Id("customerCreate_information_segment")); } }

        public IWebElement ContactInfoCustomerClassId { get { return WebDriver.GetElement(By.Id("customerCreate_information_customerClass")); } }

        public IWebElement PreferredLang { get { return WebDriver.GetElement(By.XPath("//*[@id='prefferedlanguage']")); } }

        public IWebElement CustomerClassValidationError { get { return WebDriver.GetElement(By.Id("customerCreate_information_validation_customerCategory")); } }

        public IWebElement CustomerCategory { get { return WebDriver.GetElement(By.Id("customerCreate_information_customerCategory")); } }

        public IWebElement ContactInfoParentRefId { get { return WebDriver.GetElement(By.Id("customerCreate_contactInformation_parentReference")); } }

        public IWebElement ContactInfoChannelId { get { return WebDriver.GetElement(By.Id("customerCreate_contactInformation_channel")); } }

        public IWebElement ContactInfoTitle { get { return WebDriver.GetElement(By.Id("customerCreate_billing_contact_title")); } }

        public IWebElement CustCreateFinancialDisplayMode { get { return WebDriver.GetElement(By.Id("customerCreate_financialInformation")); } }

        public IWebElement FinancialPaymentTermId { get { return WebDriver.GetElement(By.Id("customerCreate_finance_paymentTerm")); } }

        public IWebElement FinancialCurrencyId { get { return WebDriver.GetElement(By.Id("customerCreate_financialInformation_currencym")); } }

        public IWebElement FinancialInvoiceDeliveryMethodId { get { return WebDriver.GetElement(By.Id("customerCreate_financialInformation_invoiceDeliveryMethod")); } }

        public IWebElement FinancialDiscountCodeId { get { return WebDriver.GetElement(By.Id("customerCreate_financialInformation_discountCode")); } }

        public IWebElement FinancialTaxId { get { return WebDriver.GetElement(By.Id("customerCreate_financialInformation_taxId")); } }

        public IWebElement CustCreateSalesRepId { get { return WebDriver.GetElement(By.Id("customerCreate_relationship_salesRepId")); } }

        public IWebElement RemainingBalanceLable { get { return WebDriver.GetElement(By.Id("customerDetails_remainingBalance")); } }

        public IWebElement CreditDetails { get { return WebDriver.GetElement(By.Id("credit-details-container")); } }

        public IWebElement CustomerCreateValidationModelId { get { return WebDriver.GetElement(By.Id("customerCreate_validation_authorization")); } }

        public IWebElement HdrCustCreateEnteredAddr { get { return WebDriver.GetElement(By.Id("customerAddress_suggestions_entered_address_header")); } }

        public IWebElement CustCreateSuggestnsWithSuggestnModalId { get { return WebDriver.GetElement(By.Id("createCustomerDuplicateCustomersDialog_withSuggestion")); } }

        public IWebElement HdrDupeCustModalEnteredAddr { get { return WebDriver.GetElement(By.Id("customerCreate_suggestions_entered_address_header")); } }

        public IWebElement HdrDupeCustModalSimilarAddr { get { return WebDriver.GetElement(By.Id("customerCreate_suggestions_withSuggestion_header_0")); } }

        public IWebElement BtnDupeCustModalClose { get { return WebDriver.GetElement(By.Id("customerCreate_suggestions__close")); } }

      
        public IWebElement BtnDupeCustModalSaveEntered { get { return WebDriver.GetElement(By.Id("createCustomerDuplicateCustomersDialog_entered_save")); } }

        public IWebElement BtnDupeCustModalSuggestedCorrect { get { return WebDriver.GetElement(By.Id("customerCreate_suggestions_suggested_correct_0")); } }

        public IWebElement MsgCustCreateShipAddrLine1 { get { return WebDriver.GetElement(By.Id("customerCreate_shippingAddress_line1Message")); } }

        public IWebElement MsgCustCreateShipAddrLine2 { get { return WebDriver.GetElement(By.Id("customerCreate_shippingAddress_line2Messag")); } }

        public IWebElement BtnUseInQuote { get { return WebDriver.GetElement(By.Id("customerDetails_createQuote")); } }

        public IWebElement TxtSearchMyAccountEmail { get { return WebDriver.GetElement(By.Id("search_email_input")); } }

        public IWebElement BtnSearchMyAccount { get { return WebDriver.GetElement(By.Id("search_email")); } }

        public IWebElement TxtMyAccountFirstName { get { return WebDriver.GetElement(By.Id("myaccount_first_name")); } }

        public IWebElement TxtMyAccountLastName { get { return WebDriver.GetElement(By.Id("myaccount_last_name")); } }

        public IWebElement TxtMyAccountEmailAddress { get { return WebDriver.GetElement(By.Id("myaccount_email_address")); } }

        public IWebElement TxtMyAccountAddressLine1 { get { return WebDriver.GetElement(By.Id("myaccount_address_line1")); } }

        public IWebElement TxtMyAccountAddressLine2 { get { return WebDriver.GetElement(By.Id("myaccount_address_line2")); } }

        public IWebElement TxtMyAccountCity { get { return WebDriver.GetElement(By.Id("myaccount_city")); } }

        public IWebElement TxtMyAccountState { get { return WebDriver.GetElement(By.Id("myaccount_state")); } }

        public IWebElement TxtMyAccountZip{ get { return WebDriver.GetElement(By.Id("myaccount_zip_code")); }}

        public IWebElement TxtMyAccountZip4 { get { return WebDriver.GetElement(By.Id("myaccount_zip_4")); } }

        public IWebElement ChkMyAccountIncludeOffer { get { return WebDriver.GetElement(By.Id("myaccount_include_offers")); } }

        public IWebElement ChkMyAccountEnableDellAdvantage { get { return WebDriver.GetElement(By.Id("myaccount_enable_dell_advantage")); } }

        public IWebElement BtnAddMyAccount { get { return WebDriver.GetElement(By.Id("_addMyAccountButton")); } }

        public IWebElement BtnCancelAddMyAccount { get { return WebDriver.GetElement(By.Id("_cancel")); } }

        public IWebElement CloseMyAccountPopup { get { return WebDriver.GetElement(By.Id("_close")); } }

        public IWebElement DivSearchEmailError { get { return WebDriver.GetElement(By.Id("_emailSearchErrorSection")); } }

        public IWebElement DivAssociateMyAccountError { get { return WebDriver.GetElement(By.Id("_associateMyAccountErrorSection")); } }

        public IWebElement MsgSearchMyAccountSuccessRow1 { get { return WebDriver.GetElement(By.CssSelector("#COM > div.modal-small.ng-scope > div > div:nth-child(3) > div.modal-body > div:nth-child(2) > div")); } }

        public IWebElement MsgSearchMyAccountSuccessRow2 { get { return WebDriver.GetElement(By.CssSelector("#COM > div.modal-small.ng-scope > div > div:nth-child(3) > div.modal-body > div:nth-child(3) > div")); } }

        public IWebElement DivAddMyAccountFormValidationError { get { return WebDriver.GetElement(By.Id("_formValidationErrorSection")); } }

        public IWebElement LnkPartyLevelToggle { get { return WebDriver.GetElement(By.CssSelector("#customerSearchResults_partyGrid > div > table > tbody > tr:nth-child(1) > td:nth-child(1) > a")); } }

        public IWebElement LnkCustNumber { get { return WebDriver.GetElement(By.CssSelector("#customerSearchResults_partyGrid > div > table > tbody > tr.details-view > td.detail-cell > table > tbody > tr > td:nth-child(1) > a")); } }

        public IWebElement LnkCompany { get { return WebDriver.GetElement(By.CssSelector("#customerSearchResults_partyGrid > div > table > tbody > tr.details-view > td.detail-cell > table > tbody > tr > td:nth-child(2) > a")); } }

        public IWebElement CompanyNumber { get { return WebDriver.GetElement(By.CssSelector("#customerSearchResults_partyGrid > div > table > tbody > tr.details-view > td.detail-cell > table > tbody > tr > td:nth-child(3) > a")); } }

        public IWebElement BtnViewAllCustomer { get { return WebDriver.GetElement(By.CssSelector("tr.ng-scope:nth-child(1) > td:nth-child(6) > a:nth-child(1)")); } }

        public IWebElement LblCompanyCol { get { return WebDriver.GetElement(By.CssSelector("#customerSearchResults_partyGrid > div > table > thead > tr > th:nth-child(2)")); } }

        public IWebElement LblContactNameCol { get { return WebDriver.GetElement(By.CssSelector("#customerSearchResults_partyGrid > div > table > thead > tr > th:nth-child(3)")); } }

        public IWebElement LblAddressCol { get { return WebDriver.GetElement(By.CssSelector("#customerSearchResults_partyGrid > div > table > thead > tr > th:nth-child(4)")); } }

        public IWebElement CompanyNumberPopUp { get { return WebDriver.GetElement(By.Id("companyNumberSelect_Grid")); } }

        public IWebElement CompanyNameText { get { return WebDriver.GetElement(By.Id("customerCreate_contactInformation_companyName")); } }

        public IWebElement LblCompanyNameBy { get { return WebDriver.GetElement(By.Id("customerCreate_contactInformation_companyName_label")); } }

        public IWebElement LblMenuMain { get { return WebDriver.GetElement(By.Id("menu_main_label")); } }

        public IWebElement LnkMenuHome { get { return WebDriver.GetElement(By.Id("menu_home_link")); } }

        public IWebElement LnkAddCustomer { get { return WebDriver.GetElement(By.Id("menu_customerAdd_link")); } }

        /// <summary>
        /// Adding missing customer create web elements
        /// </summary>

        public IWebElement CustomerBillingAddressLine1Txt { get { return WebDriver.GetElement(By.Id("customerCreate_billing_address_line1")); } }

        public IWebElement CustomerBillingAddressLine1WarningMsg { get { return WebDriver.GetElement(By.XPath("//p[contains(text(),'Cannot accept the')]")); } }

        public IWebElement CustomerBillingAddressLine2Txt { get { return WebDriver.GetElement(By.Id("customerCreate_billing_address_line2")); } }

        public IWebElement FieldApartment { get { return WebDriver.GetElement(By.Id("apartment")); } }

        public IWebElement FieldBuilding { get { return WebDriver.GetElement(By.Id("building")); } }

        public IWebElement FieldDepartment { get { return WebDriver.GetElement(By.Id("department")); } }

        public IWebElement FieldSuite { get { return WebDriver.GetElement(By.XPath("//input[@name='suite']")); } }

        public IWebElement FieldFloor { get { return WebDriver.GetElement(By.Id("floor")); } }

        public IWebElement FieldRoom { get { return WebDriver.GetElement(By.Id("room")); } }

        public IWebElement CustomerBillingCityTxt { get { return WebDriver.GetElement(By.Id("customerCreate_billing_address_city")); } }

        public IWebElement CustomerBillingStateTxt { get { return WebDriver.GetElement(By.Id("customerCreate_billing_address_state")); } }

        public IWebElement CustomerBillingZipCodeTxt { get { return WebDriver.GetElement(By.XPath("//input[@id='customerCreate_billing_address_postalCode']")); } }

        public IWebElement CustomerBillingZipCodeExtensionTxt { get { return WebDriver.GetElement(By.Id("customerCreate_billing_address_postalCodeExtension")); } }

        public IWebElement CustomerBillingCountryTxt { get { return WebDriver.GetElement(By.Id("customerCreate_billing_address_country")); } }

        public IWebElement CACustomerBillingCountryTxt { get { return WebDriver.GetElement(By.XPath("//*[@id='customerCreate_billing_address_country']")); } }

        public IWebElement CompanyPhoneContryCode { get { return WebDriver.GetElement(By.XPath("//div[@class = 'phone-country-code-box'])[1]")); } }

        public IWebElement ChooseCompanyPhoneContryCode { get { return WebDriver.GetElement(By.XPath("//div[@class='content-shell']//li[3]")); } }

        public IWebElement CompanyFaxContryCode { get { return WebDriver.GetElement(By.XPath("//div[@class = 'phone-country-code-box'])[2]")); } }

        public IWebElement MobileContryCode { get { return WebDriver.GetElement(By.XPath("//div[@class ='phone-country-code-box'])[3]")); } }

        public IWebElement WorkCountryCode { get { return WebDriver.GetElement(By.XPath("//div[@class ='phone-country-code-box'])[4]")); } }

        public IWebElement CountryCodeFaxBilling { get { return WebDriver.GetElement(By.XPath("//div[@class ='phone-country-code-box'])[5]")); } }

        public IWebElement InvoiceDeliverMethodTxt { get { return WebDriver.GetElement(By.Id("customerCreate_billing_contact_invoiceDeliveryMethod")); } }

        public IWebElement BillingContactFirstNameTxt { get { return WebDriver.GetElement(By.Id("customerCreate_billing_contact_firstName")); } }

        public IWebElement BillingContactMiddleNameTxt { get { return WebDriver.GetElement(By.Id("customerCreate_billing_contact_middleName")); } }

        public IWebElement BillingContactLastNameTxt { get { return WebDriver.GetElement(By.Id("customerCreate_billing_contact_lastName")); } }

        public IWebElement BillingContactDepartmentTxt { get { return WebDriver.GetElement(By.Id("customerCreate_billing_contact_department")); } }

        public IWebElement BillingContactInvoicingEmailTxt { get { return WebDriver.GetElement(By.Id("customerCreate_billing_contact_email")); } }

        public By LblInvoicingEmailBy = By.Id("customerCreate_billingInformation_invoicingEmail");
       
        public IWebElement BillingContactDigitalFulfillmentEmailTxt { get { return WebDriver.GetElement(By.Id("customerCreate_billingInformation_digitalFulfillmentEmail")); } }

        public IWebElement BillingContactProSupportEmailTxt { get { return WebDriver.GetElement(By.Id("customerCreate_billingInformation_warrantyEmail")); } }

        public IWebElement BillingContactFlexBillingEmailTxt { get { return WebDriver.GetElement(By.Id("customerCreate_billingInformation_flexBillingEmail")); } }

        public IWebElement BillingContactOtherEmailTxt { get { return WebDriver.GetElement(By.Id("customerCreate_billingInformation_otherEmail")); } }

        public IWebElement BillingCountryCodeMobile { get { return WebDriver.GetElement(By.Name("phone-country-code-box")); } }

        public IWebElement additems { get { return WebDriver.GetElement(By.ClassName("quoteCreate_additem_top_1_")); } }

        public IWebElement BillingContacMobilePhoneTxt { get { return WebDriver.GetElement(By.Id("customerCreate_billing_contact_mobilePhone")); } }

        public IWebElement LblMobilePhoneBy { get { return WebDriver.GetElement(By.Id("customerCreate_billingInformation_mobilePhone_label")); } }

        public IWebElement BillingContacWorkPhoneTxt { get { return WebDriver.GetElement(By.XPath("//*[@id='customerCreate_billing_contact_workPhone']")); } }

        public IWebElement BillingContactHomePhoneTxt { get { return WebDriver.GetElement(By.Id("customerCreate_billing_contact_workPhone")); } }

        public IWebElement BillingContactFaxTxt { get { return WebDriver.GetElement(By.Id("customerCreate_billing_contact_faxNumber")); } }

        public IWebElement BillingInvoicePreferenceLst { get { return WebDriver.GetElement(By.Id("customerCreate_billing_contact_invoicePreference")); } }

        public IWebElement ShippingAddressSameAdBillingChk { get { return WebDriver.GetElement(By.XPath("//input[@id='customerCreate_shipping_sameAsBilling']")); } }

        public IWebElement BusinessAct { get { return WebDriver.GetElement(By.Id("customerCreate_typeSelection_business")); } }
        public IWebElement ShippingContactTitleLst { get { return WebDriver.GetElement(By.Id("customerCreate_shipping_contact_title")); } }

        public IWebElement ShippingContactAddressLine1Txt { get { return WebDriver.GetElement(By.Id("customerCreate_shipping_address_line1")); } }

        public IWebElement POboxValidationMsg { get { return WebDriver.GetElement(By.XPath("//p[contains(text(),'PO box')]")); } }

        public IWebElement ShippingContactAddressLine2Txt { get { return WebDriver.GetElement(By.Id("customerCreate_shipping_address_line2")); } }

        public IWebElement ShippingContactDepartmentTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shipping_contact_department")); } }

        public IWebElement ShippingContactMailStopTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shipping_address_shippingAddress_mailStop")); } }

        public IWebElement ShippingContactCityTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shipping_address_city")); } }

        public IWebElement ShippingContactStateLst { get { return WebDriver.GetElement(By.Id("customerCreate_shipping_address_state")); } }

        public IWebElement ShippingContactZipCodeTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shipping_address_postalCode")); } }

        public IWebElement ShippingContactzipCodeExtensionTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shipping_address_postalCodeExtension")); } }

        public IWebElement ShippingContactCountryLst { get { return WebDriver.GetElement(By.Id("customerCreate_shipping_address_country")); } }

        public IWebElement ShippingContactFirstNameTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shipping_contact_firstName")); } }

        public IWebElement ShippingContactMiddleNameTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shipping_contact_middleName")); } }

        public IWebElement ShippingContactLastNameTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shipping_contact_lastName")); } }

        public IWebElement ShippingContactInvoicingEmailTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shipping_contact_email")); } }

        public IWebElement ShippingContactDigitalFulFillmentEmailTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shippingAddress_digitalFulfillmentEmail")); } }

        public IWebElement ShippingContactProSupportEmailTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shippingAddress_warrantyEmail")); } }

        public IWebElement ShippingContactFlexBillingEmailTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shippingAddress_flexBillingEmail")); } }

        public IWebElement ShippingContactOtherEmailTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shippingAddress_otherEmail")); } }

        public IWebElement ShippingContactHomePhoneTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shippingAddress_homePhone")); } }

        public IWebElement ShippingContactMobileHomeTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shipping_contact_mobilePhone")); } }

        public IWebElement ShippingContactWorkPhoneTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shipping_contact_workPhone")); } }

        public IWebElement ShippingContactFaxTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shipping_contact_faxNumber")); } }

        public IWebElement FinancialInvoicePreferenceLst { get { return WebDriver.GetElement(By.Id("customerCreate_financialInformation_invoicePreference")); } }

        public IWebElement ConfirmYesBtn { get { return WebDriver.GetElement(By.Id("AddressSuggestionsDialog_addShippingAddress_select")); } }

        public IWebElement SaveLegalCompanyName { get { return WebDriver.GetElement(By.Id("save_legal_compantName")); } }

        public IWebElement LegalCompanyNameNotification { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-warning ng-star-inserted']")); } }

        public IWebElement UseVerifiedAddressBtn { get { return WebDriver.GetElement(By.Id("_addShippingAddress_select")); } }

        public IWebElement AddressSuggestionPopup { get { return WebDriver.GetElement(By.Id("AddressSuggestionsDialog")); } }

        public IWebElement AddressValidationRdBtn { get { return WebDriver.GetElement(By.XPath("//*[@id='_shippingAddress_validation_withSuggestion']/div[3]/div[2]/div/div/input")); } }

        public IWebElement CustomerCreateNotes { get { return WebDriver.GetElement(By.XPath("//div[@id='customerCreate_notes']/div/div/div/textareat")); } }

        public IWebElement ShippingTitleTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shippingAddress_title")); } }

        public IWebElement ShippingEmailTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shipping_contact_email")); } }

        public IWebElement ShippingPrimaryPhoneTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shippingAddress_primaryPhone")); } }

        public IWebElement ShippingSecondaryPhoneTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shippingAddress_secondaryPhone")); } }

        public IWebElement BillingEmailTxt { get { return WebDriver.GetElement(By.Id("customerCreate_billingInformation_email")); } }

        public IWebElement BillingPrimaryPhoneTxt { get { return WebDriver.GetElement(By.Id("customerCreate_billingInformation_primaryPhone")); } }

        public IWebElement BillingSecondaryPhoneTxt { get { return WebDriver.GetElement(By.Id("customerCreate_billingInformation_secondaryPhone")); } }

        public IWebElement ShippingCompanyTxt { get { return WebDriver.GetElement(By.Id("customerCreate_shippingAddress_companyName")); } }

        public IWebElement AddressValidationPopUp { get { return WebDriver.GetElement(By.Id("_shippingAddress_validation_withSuggestion")); } }

        public IWebElement AddressVerificationPopUp { get { return WebDriver.GetElement(By.XPath("//h2[text()='Company Name Verification']")); } }

        public IWebElement CreateThisNewCustomer { get { return WebDriver.GetElement(By.Id("createCustomerDuplicateCustomersDialog_entered_save")); } }

        public IWebElement AddressValidationCheck { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_shippingAddress_validation_withSuggestion")); } }

        public IWebElement VerifiedAddressRdBtn { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_validateAddress_shippingAddress_validation_withSuggestion']//input)[2]")); } }

        public IWebElement EnteredAddressRdBtn { get { return WebDriver.GetElement(By.XPath("//*[@class='adrs-suggestion-modal-body']//input[1]")); } }

        public IWebElement EmailWarningMsg { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-warning ng-star-inserted']")); } }

        public IWebElement ShippingAddressLineWarningMsg { get { return WebDriver.GetElement(By.XPath("//*[@class='alert alert-warning']")); } }

        public IWebElement SaveAddressRdBtn { get { return WebDriver.GetElement(By.Id("AddressSuggestionsDialog_addShippingAddress_useOriginal")); } }

        public IWebElement CustomerCreateEnteredAddressRdBtn { get { return WebDriver.GetElement(By.XPath("//*[@id='_shippingAddress_validation_withSuggestion']//input)[1]")); } }

        public IWebElement MailingAddressSameAdBillingChk { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_sameAsBilling")); } }

        public IWebElement ContactCompPhone { get { return WebDriver.GetElement(By.Id("customerCreate_information_company_phone")); } }

        public IWebElement ContactInfoCompanyFax { get { return WebDriver.GetElement(By.Id("customerCreate_information_company_fax")); } }

        public IWebElement BillingContactState { get { return WebDriver.GetElement(By.Id("customerCreate_billingInformation_state")); } }

        public IWebElement InvoicePreference { get { return WebDriver.GetElement(By.Id("customerCreate_billing_contact_invoicePreference")); } }

        public IWebElement MaillingAddressSameAdBillingChk { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_sameAsBilling")); } }
       
        public IWebElement MailingInfoTitle { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_title")); } }

        public IWebElement MailingInfoFirstName { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_firstName")); } }

        public IWebElement MailingInfoMiddleName { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_middleName")); } }

        public IWebElement MailingInfoLastName { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_lastName")); } }

        public IWebElement MailingInfoInvoicingEmail { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_invoicingEmail")); } }

        public IWebElement MailingInfoDigitalFulfillmentEmail { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_digitalFulfillmentEmail")); } }

        public IWebElement MailingInfoProSupportEmail { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_warrantyEmail")); } }

        public IWebElement MailingInfoFlexBillingEmail { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_flexBillingEmail")); } }

        public IWebElement MailingInfoOtherEmail { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_otherEmail")); } }

        public IWebElement MailingInfoHomePhone { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_homePhone")); } }

        public IWebElement MailingInfoMobilePhone { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_mobilePhone")); } }

        public IWebElement ShippingInfoMobilePhone { get { return WebDriver.GetElement(By.Id("customerCreate_shipping_contact_mobilePhone")); } }

        public IWebElement ValidationErrorMsg { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-warning ng-star-inserted']")); } }

        public IWebElement EmailOverride { get { return WebDriver.GetElement(By.XPath("//input[@class='form-input']")); } }
        public IWebElement EmailOverrideValidation { get { return WebDriver.GetElement(By.XPath("//div/email-errors//input[@class='form-input']")); } }

        public IWebElement PhoneOverrideValidation { get { return WebDriver.GetElement(By.XPath(".//phone-errors//input[@class='form-input']")); } }

        public void CheckAllEmailOverrideValidation()
        {

            foreach (var item in AllEmailOverrideValidation)
            {
                item.Click(WebDriver);
            }


        }

        public void CheckAllPhoneOverrideValidation()
        {

            foreach (var item in AllPhoneOverrideValidation)
            {
                item.Click(WebDriver);
            }


        }
        public bool getValidationErrorMessage()
        {
            try
            {
                return ValidationErrorMsg.Displayed;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
        }

        public bool GetEmailErrorMessage()
        {
            var message = ValidationErrorMsg.GetText(WebDriver);
            if (message.Contains("Must use the format name"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public IWebElement MailingInfoWorkPhone { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_workPhone")); } }

        public IWebElement MailingInfoFaxNumber { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_faxNumber")); } }

        public IWebElement MailingInfoAddressLine1 { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_line1")); } }

        public IWebElement MailingInfoAddressLine2 { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_line2")); } }

        public IWebElement MailingInfoDepartament { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_department")); } }

        public IWebElement MailingInfoMailStop { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_mailStop")); } }

        public IWebElement MailingInfoCity { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_city")); } }

        public IWebElement MailingInfoState { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_state")); } }

        public IWebElement MailingInfoZipCode { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_postalCode")); } }

        public IWebElement MailingInfoZipExtensionCode { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_extensionpostalCode")); } }

        public IWebElement MailingInfoCountry { get { return WebDriver.GetElement(By.Id("customerCreate_mailingAddress_country")); } }

        public IWebElement UseOriginalAddress { get { return WebDriver.GetElement(By.Id("AddressSuggestionsDialog_addShippingAddress_useOriginal")); } }

        public IWebElement AddShippingAddress { get { return WebDriver.GetElement(By.Id("AddressSuggestionsDialog_addShippingAddress_select")); } }

        public IWebElement LinkAccountRadioBtn { get { return WebDriver.GetElement(By.Id("customerCreate_typeSelection_link")); } }

        public IWebElement FunderCustomerRadioBtn { get { return WebDriver.GetElement(By.Id("customerCreate_typeSelection_funder")); } }

        public IList<IWebElement> PostalCodeTxt { get { return WebDriver.GetElements(By.XPath("//*[contains(text(), 'Postal Code')]")); } }

        public IWebElement AddAddressField { get { return WebDriver.GetElement(By.XPath("//customer-address[@name='billingAddress']//a[@class='k-icon k-i-arrow-s']")); } }

        public IWebElement ExpandedAddAddressField { get { return WebDriver.GetElement(By.XPath("//a[@class='k-icon k-i-arrow-n']")); } }

        public IList<IWebElement> AdditionalAddressFields { get { return WebDriver.GetElements(By.XPath("//customer-address[@name='billingAddress']//address-line2-extra-fields//label")); } }

        public IWebElement CustomerTypeAsPersonal { get { return WebDriver.GetElement(By.XPath("//input[@id='customerCreate_typeSelection_personal']")); } }
        public IWebElement CustomerTypeAsBusiness { get { return WebDriver.GetElement(By.XPath("//input[@id='customerCreate_typeSelection_business']")); } }
        public Boolean VerifyPOFieldNotVisible()
        {
            Boolean flag=true;
            foreach(IWebElement el in AdditionalAddressFields)
            {
                if (el.Text.Equals("PO Box")) {
                    flag = false;
                    break;
                }
            }
            return flag;
        }


        #region Customer Create pending popup.

        public IWebElement CustomerCreatePendingPopup { get { return WebDriver.GetElement(By.Id("customerDialog_messages_shippingAddress_validationMessage")); } }

        public IWebElement CustomerCreatePendingPopupOkBtn { get { return WebDriver.GetElement(By.Id("customerDialog_messages_addShippingAddress_ok")); } }

        public IWebElement CustomerCreatePendingPopupCancelBtn { get { return WebDriver.GetElement(By.Id("customerDialog_messages_addShippingAddress_cancel")); } }

        public IWebElement CustomerCreatePendingPopupMessage { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDialog_messages_shippingAddress_validationMessage']/div[3]/span")); } }
        #endregion

        #endregion

        public IWebElement BillingWorkPhoneCountryCode()
        {
            return WebDriver.GetElements(By.XPath("//*[@name='workPhoneCountryCode']//div[contains(@class, 'phone-country-code-box')]"))[0];
        }
        public IWebElement ShippingWorkPhoneCountryCode()
        {
            return WebDriver.GetElements(By.XPath("//*[@name='workPhoneCountryCode']//div[contains(@class, 'phone-country-code-box')]"))[1];
        }

        public IWebElement MobilePhoneCountryCode(int lineitemIndex)
        {
            return WebDriver.GetElements(By.XPath("//phone-country-code/div/div"))[lineitemIndex - 1];
        }

        public IWebElement WorkPhoneCountryCode(int lineitemIndex)
        {
            return WebDriver.GetElements(By.XPath("//phone-country-code/div/div"))[lineitemIndex - 1];
        }

        public IWebElement FaxCountryCode(int lineitemIndex)
        {
            return WebDriver.GetElements(By.XPath("//phone-country-code/div/div"))[lineitemIndex - 1];
        }

        public void SetContactInfoReqdFields_DellPrint(string companyNumber, string companyName, string customerClass)
        {

        }

        public void SetBillingInfoReqdFields_DellPrint(Address billingInfo)
        {

        }

        public void SetShippingInfoReqdFields(Address billingInfo)
        {

        }

        public void SetShippingInfoReqdFields_DellPrint(Address billingInfo)
        {

        }

        public void SetMailingInfoReqdFields_DellPrint(Address billingInfo)
        {

        }

        public void SetContactInfoReqdFields(string companyNumber, string companyName, string customerClass)
        {

        }

        public void SetBillingInfoReqdFields(Address billingInfo)
        {

        }

        public void MarkSameAsBillingAddressCheckbox()
        {

        }

        public void MarkMailingSameAsBillingAddressCheckbox()
        {

        }

        public void SetFinancialPrefrences_DellPrint(FinancialPrefrences financialPreference)
        {

        }

        public void SetPrimarySalesRepId(string repId)
        {

        }

        public void SaveCustomer()
        {
            BtnAddNewCustomerSave.Click(WebDriver);
        }

        // Get the Area Code element
        public IWebElement PhoneAreaCode(int? index)
        {
            return WebDriver.GetElement(By.XPath("//div[@class = 'phone-country-code-box'])[" + index + "]"));
        }

        // Get the list of Area Codes 
        public IWebElement SelectPhoneAreaCode(int? index)
        {
            return WebDriver.GetElement(By.XPath("//div[@class='content-shell']//li[" + index + "]"));
        }

        // Get and Set Area Code
        public void SetPhoneAreaCode(int? phoneIndex, int? areaCodeIndex)
        {
            PhoneAreaCode(phoneIndex).Click(WebDriver);
            SelectPhoneAreaCode(areaCodeIndex).Click(WebDriver);
        }

        public void SaveCustomerAddressValidation()
        {
            BtnAddNewCustomerSave.Click(WebDriver);
            
            if (AddressSuggestionPopup.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
            {
                UseOriginalAddress.Click(WebDriver);
                AddShippingAddress.Click(WebDriver);
                SaveLegalCompanyName.Click(WebDriver, TimeSpan.FromSeconds(5));
                if (CustCreateSuggestnsWithSuggestnModalId.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
                 {
                  BtnDupeCustModalSaveEntered.Click(WebDriver, TimeSpan.FromSeconds(5));

                 }
               
            }
           
            WebDriver.VerifyBusyOverlayNotDisplayed();
        }

        public bool IsAvsVisible()
        {
            return AddressSuggestionPopup.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10));
        }

        public bool HasDupeCustomerWarningModal()
        {
            return CustCreateSuggestnsWithSuggestnModalId.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10));
        }

        public void SelectEnteredAddress()
        {

        }

        public void SelectEnteredCustomer()
        {

        }

        public void SelectOriginalAddressFromAvsPopup()
        {
            UseOriginalAddress.Click(WebDriver);
            ConfirmYesBtn.Click(WebDriver);
        }

        //public bool IsAddressValidation()
        //{
        //    return WebDriver.ElementExists(AddressValidationCheck);
        //}

        /// <summary>
        /// Validates if the Billing Address is same as Shipping Address i.e.,Checkbox selected or not
        /// </summary>
        /// <returns>true if Checkbox selected or else false</returns>
        public bool VerifyBillingAndShippingSame()
        {
            if (ShippingAddressSameAdBillingChk.GetAttribute("class").Contains("ng-not-empty"))
                return true;
            return false;
        }

        /// <summary>
        /// Validates the page is not busy and the header displays 
        /// </summary>
        /// <returns><c>true</c> if the page title is displayed and is the correct value, 
        /// <c>false</c> otherwise.</returns>
        public override bool Validate()
        {
            return HdrAddNewCustomer.Displayed;
        }

        /// <summary>
        /// validate page is active.
        /// </summary>
        /// <returns><c>true</c> if url is correct<c>false</c>.</returns>
        public override bool IsActive()
        {
            ContactInfoCompanyNameId.WaitForElement(WebDriver);
            return (WebDriver.Url.Contains("customer/create"));
        }

        // To get all dropdown values
        public CustomerCreatePage GetAllOptionsFromDropDown(IWebElement element, int count)
        {
            SelectElement select = new SelectElement(element);
            IList<IWebElement> list = select.Options;
            var total = list.Count;
            if (total.Equals(count))
            {
                foreach (var item in list)
                {
                    Logger.Write(item.GetText(WebDriver));
                }

            }
            else
            {
                Assert.Fail("Count doesn't match.");
            }
            return new CustomerCreatePage(WebDriver);
        }

        // Get all elements
        public CustomerCreatePage GetAllElements(IList<IWebElement> element, String text, int count)
        {
            IList<IWebElement> list = element;
            var total = list.Count;
            if (total.Equals(count))
            {
                foreach (var txt in list)
                {
                    var returnedText = txt.GetText(WebDriver);
                    returnedText.Equals(text);
                }
            }
            return new CustomerCreatePage(WebDriver);
        }

        /// <summary>
        /// pick the company on the given row of the dropdown
        /// </summary>
        /// <param name="row"></param>
        public void PickCompany(int row)
        {
            ContactInfoCompanyNumberId.PickDropdownByIndex(WebDriver, row);

        }

        /// <summary>
        /// use menu to go to Home
        /// </summary>
        /// <returns></returns>
        public HomePage GotoHomePage()
        {
            LblMenuMain.Click(WebDriver);
            LnkMenuHome.Click(WebDriver);
            return new HomePage(WebDriver);
        }

        /// <summary>
        /// use menu to Add Customer
        /// </summary>
        public CustomerCreatePage AddCustomerFromMenu()
        {
            LblMenuMain.Click(WebDriver);
            LnkAddCustomer.Click(WebDriver);
            return new CustomerCreatePage(WebDriver);
        }

        /// <summary>
        /// set comp name to random string
        /// </summary>
        public void SetCompanyName()
        {
            var companyName = Guid.NewGuid().ToString("N").Substring(0, 5);
            ContactInfoCompanyNameId.SetText(WebDriver, companyName);
        }


        /// <summary>
        /// set comp to given name
        /// </summary>
        /// <param name="companyName"></param>
        public void SetCompanyName(string companyName)
        {
            ContactInfoCompanyNameId.SetText(WebDriver, companyName);
        }

        /// <summary>
        /// set comp to given number
        /// </summary>
        /// <param name="companyNumber"></param>
        public void SelectCompanyNumber(string companyNumber)
        {
            ContactInfoCompanyNumberId.PickDropdownByText(WebDriver, companyNumber);
        }

        /// <summary>
        /// get the list of company numbers in the dropdown
        /// </summary>
        /// <returns></returns>
        public string GetCompanyNumberList()
        {
            return ContactInfoCompanyNumberId.GetText(WebDriver);
        }

        /// <summary>
        /// set parent reference
        /// </summary>
        /// <param name="parentReference"></param>
        public void SetParentReference(string parentReference)
        {
            ContactInfoParentRefId.SetText(WebDriver, parentReference);
        }

        /// <summary>
        /// pick customer class from dropdown
        /// </summary>
        /// <param name="customerClass"></param>
        public void SelectCustomerClass(string customerClass)
        {
            //TODO use position of customerClass in list
            ContactInfoCustomerClassId.PickDropdownByText(WebDriver, customerClass);
        }

        public string GetPostalCode()
        {
            return CustomerBillingZipCodeTxt.GetText(WebDriver);
        }

        public string GetLang()
        {
            return PreferredLang.GetText(WebDriver);
        }

        public string GetCurrency()
        {
            return CustCreateCurrency.GetText(WebDriver);
        }



        public void SelectCountry(string country)
        {
            CustomerBillingCountryTxt.PickDropdownByText(WebDriver, country);
        }
        public void SelectTitle(string title)
        {
            ContactInfoTitle.PickDropdownByText(WebDriver, title);
        }

        public void SelectLanguage(String Lang)
        {
            PreferredLang.PickDropdownByText(WebDriver, Lang);
        }

        public void SelectCurrency(String Currency)
        {
            CustCreateCurrency.PickDropdownByText(WebDriver, Currency);

        }

        public bool ElementExistValidation(By stringBy)
        {
            return WebDriver.ElementExists(stringBy);
        }

        public bool IsFunderRadioButtonVisible()
        {
            return FunderCustomerRadioBtn.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(20)); ;
        }

        //TODO Need to finish the below

        ///// <summary>
        ///// set shipping contact first name
        ///// </summary>
        ///// <param name="firstName"></param>
        //public void SetShippingContactFirstName(string firstName)
        //{
        //    Shipp.ClearText(By.Id(CustomerIDs.ShippingAddrFirstNameId));
        //    .SetText(WebDriver, firstName);
        //}

        ///// <summary>
        ///// set middle name
        ///// </summary>
        //public string ShippingContactMidName
        //{
        //    set { WebDriver.GetElement(By.Id(CustomerIDs.ShippingAddrMiddleNameId)).SendKeys(value); }
        //}

        ///// <summary>
        ///// set shipping contact last name
        ///// </summary>
        ///// <param name="lastName"></param>
        //public void SetShippingContactLastName(string lastName)
        //{
        //    WebDriver.SetText(By.Id(CustomerIDs.ShippingAddrLastNameId), lastName);
        //}

        ///// <summary>
        ///// set Shipping Department
        ///// </summary>
        //public string ShippingDepartment
        //{
        //    set { WebDriver.GetElement(By.Id(CustomerIDs.ShippingAddrDeptId)).SendKeys(value); }
        //}


        ///// <summary>
        ///// set shipping mailstop
        ///// </summary>
        ///// <param name="mailStop"></param>
        //public void SetShippingMailStop(string mailStop)
        //{
        //    WebDriver.SetText(By.Id(CustomerIDs.ShippingAddrMailStopId), mailStop);
        //}

        //public void SetShippingEMail(string email)
        //{
        //    WebDriver.SetText(By.Id(CustomerIDs.ShippingAddrEmail), email);
        //}

        ///// <summary>
        ///// set shipping title
        ///// </summary>
        ///// <param name="title"></param>
        //public void SetTitle(string title)
        //{
        //    WebDriver.SetText(By.Id(CustomerIDs.ShippingAddrTitleId), title);
        //}

        ///// <summary>
        ///// set shipping phone1
        ///// </summary>
        ///// <param name="priPhone"></param>
        //public void SetShippingPrimaryPhone(string priPhone)
        //{
        //    WebDriver.SetText(By.Id(CustomerIDs.ShippingAddrPrimaryPhoneId), priPhone);
        //}

        ///// <summary>
        ///// set shipping phone2
        ///// </summary>
        ///// <param name="secPhone"></param>
        //public void SetShippingSecondaryPhone(string secPhone)
        //{
        //    WebDriver.SetText(By.Id(CustomerIDs.ShippingAddrSecondaryPhoneId), secPhone);
        //}

        ///// <summary>
        ///// set shipping fax
        ///// </summary>
        ///// <param name="faxNumber"></param>
        //public void SetShippingFaxNumber(string faxNumber)
        //{
        //    WebDriver.SetText(By.Id(CustomerIDs.ShippingAddrFaxNumId), faxNumber);
        //}

        ///// <summary>
        ///// set shipping address line1
        ///// </summary>
        ///// <param name="line1Value"></param>
        //public void SetShippingAddressLine1(string line1Value)
        //{
        //    WebDriver.ClearText(By.Id(CustomerIDs.ShippingAddrAddLine1Id));
        //    WebDriver.SetText(By.Id(CustomerIDs.ShippingAddrAddLine1Id), line1Value);
        //}

        ///// <summary>
        ///// set shipping address line2
        ///// </summary>
        ///// <param name="line2Value"></param>
        //public void SetShippingAddressLine2(string line2Value)
        //{
        //    WebDriver.ClearText(By.Id(CustomerIDs.ShippingAddrAddLine2Id));
        //    WebDriver.SetText(By.Id(CustomerIDs.ShippingAddrAddLine2Id), line2Value);
        //    WebDriver.GetElement(By.Id(CustomerIDs.ShippingAddrAddLine2Id)).SendKeys(Keys.Tab);
        //}

        ///// <summary>
        ///// set shipping address PO box
        ///// </summary>
        //public void SetPoBoxShippingAddress()
        //{
        //    WebDriver.ClearText(By.Id(CustomerIDs.ShippingAddrAddLine1Id));
        //    WebDriver.SetText(By.Id(CustomerIDs.ShippingAddrAddLine1Id), "PO Box 102");
        //    WebDriver.ClearText(By.Id(CustomerIDs.ShippingAddrAddLine2Id));
        //    WebDriver.SetText(By.Id(CustomerIDs.ShippingAddrAddLine2Id), "PO Box 104");
        //}

        ///// <summary>
        ///// /// set billing address line1
        ///// </summary>
        //public void SetPoBoxBillingAddress()
        //{
        //    WebDriver.ClearText(By.Id(CustomerIDs.BillingInfoAddLine1Id));
        //    WebDriver.SetText(By.Id(CustomerIDs.BillingInfoAddLine1Id), "PO Box 102");
        //    WebDriver.ClearText(By.Id(CustomerIDs.BillingInfoAddLine2Id));
        //    WebDriver.SetText(By.Id(CustomerIDs.BillingInfoAddLine2Id), "PO Box 104");
        //}

        ///// <summary>
        ///// set shipping address city
        ///// </summary>
        ///// <param name="city"></param>
        //public void SetShippingCity(string city)
        //{
        //    WebDriver.SetText(By.Id(CustomerIDs.ShippingAddrCityId), city);
        //}

        ///// <summary>
        ///// set shipping address state
        ///// </summary>
        ///// <param name="state"></param>
        //public void SelectShippingState(string state)
        //{
        //    WebDriver.PickDropdownByText(By.Id(CustomerIDs.ShippingAddrStateId), state);
        //}

        ///// <summary>
        ///// set shipping address zip
        ///// </summary>
        ///// <param name="postalCode"></param>
        //public void SetShippingZipCode(string postalCode)
        //{
        //    WebDriver.SetText(By.Id(CustomerIDs.ShippingAddrZipCodeId), postalCode);
        //}

        ///// <summary>
        ///// set shipping address plus 4
        ///// </summary>
        ///// <param name="plusFour"></param>
        //public void SetShippingPlus4(string plusFour)
        //{
        //    WebDriver.SetText(By.Id(CustomerIDs.ShippingAddrPlusFour), plusFour);
        //}

        ///// <summary>
        ///// make shipping same as billing
        ///// </summary>
        //public void MarkSameAsBillingAddressCheckbox()
        //{
        //    WebDriver.GetElement(By.Id(CustomerIDs.ShippingAddrSameAsBillingId)).Set(true);
        //}

        //public void MarkSameAsBillingAdressCheckBoxMailingAddress()
        //{
        //    WebDriver.GetElement(By.Id(CustomerIDs.MailingAddrSameAsBillingId)).Set(true);
        //}

        ///// <summary>
        ///// set primary sales rep
        ///// </summary>
        ///// <param name="salesRepId"></param>
        //public void SetPrimarySalesRepId(string salesRepId)
        //{
        //    WebDriver.SetText(By.Id(CustomerIDs.CustCreateSalesRepId), salesRepId);
        //}

        //// General Section

        ///// <summary>
        ///// Sets the contact information required fields.
        ///// </summary>
        ///// <param name="companyNumber">The company number.</param>
        ///// <param name="companyName">Name of the company.</param>
        ///// <param name="customerClass">The customer class.</param>
        //public void SetContactInfoReqdFields(string companyNumber, string companyName, string customerClass)
        //{
        //    SelectCompanyNumber(companyNumber);
        //    SetCompanyName(companyName);
        //    SelectCustomerClass(customerClass);
        //}

        //public void SetContactInfoReqforHcls(DataRow row)
        //{
        //    SelectCompanyNumber(row["ComapnyNumber04"].ToString());
        //}
        ///// <summary>
        ///// enter billing required fields
        ///// </summary>
        //public void SetBillingInfoReqdFields(Address billing)
        //{
        //    BillingContactFirstName = billing.FirstName;
        //    BillingContactLastName = billing.LastName;
        //    BillingAddressLine1 = billing.AddressLine1;
        //    BillingEmail = billing.Email;
        //    BillingPrimaryPhone = billing.PrimaryPhone;
        //    BillingCity = billing.City;
        //    BillingState = billing.State;
        //    BillingZipCode = billing.ZipCode;
        //    BillingPlus4 = billing.ZipExtension;
        //}

        ///// <summary>
        ///// Sets the shipping information required fields.
        ///// </summary>
        ///// <param name="shipping">The shipping.</param>
        //public void SetShippingInfoReqdFields(Address shipping)
        //{
        //    SetShippingContactFirstName(shipping.FirstName);
        //    SetShippingContactLastName(shipping.LastName);
        //    SetShippingPrimaryPhone(shipping.PrimaryPhone);
        //    SetShippingEMail(shipping.Email);
        //    SetShippingAddressLine1(shipping.AddressLine1);
        //    SetShippingCity(shipping.City);
        //    SelectShippingState(shipping.State);
        //    SetShippingZipCode(shipping.ZipCode);
        //    SetShippingPlus4(shipping.ZipExtension);
        //}

        ///// <summary>
        ///// Sets all required fields.
        ///// </summary>
        ///// <param name="newCustomer">The new customer.</param>
        //public void SetAllReqdFields(NewCustomer newCustomer)
        //{
        //    SetContactInfoReqdFields(newCustomer.CompanyNumber, newCustomer.CompanyName, newCustomer.CustomerClass);
        //    SetBillingInfoReqdFields(newCustomer.BillingInformation);
        //    if (newCustomer.ShippingAddressSameAsBillingAddress)
        //    {
        //        MarkSameAsBillingAddressCheckbox();
        //    }
        //    else
        //    {
        //        SetShippingInfoReqdFields(newCustomer.ShippingAddress);
        //    }

        //    //TODO remove next line once Sales Rep is automatically added
        //    SetPrimarySalesRepId(newCustomer.PrimarySalesRepId);
        //}

        ///// <summary>
        ///// enter all non-required fields
        ///// </summary>
        //public void SetAllNonReqdFields(NewCustomer newCustomer)
        //{
        //    SetParentReference("xxx"); //TODO 

        //    BillingContactMidName = newCustomer.BillingInformation.MiddleInitial;
        //    BillingDepartment = newCustomer.BillingInformation.Department;
        //    BillingSecondaryPhone = newCustomer.BillingInformation.SecondaryPhone;
        //    BillingFaxNumber = newCustomer.BillingInformation.FaxNumber;
        //    BillingAddressLine2 = newCustomer.BillingInformation.AddressLine2;

        //    ShippingCompanyName = newCustomer.ShippingAddress.CompanyName;
        //    ShippingContactMidName = newCustomer.ShippingAddress.MiddleInitial;
        //    ShippingDepartment = newCustomer.ShippingAddress.Department;
        //    SetTitle(newCustomer.ShippingAddress.Title);
        //    SetShippingPrimaryPhone(newCustomer.ShippingAddress.PrimaryPhone);
        //    SetShippingSecondaryPhone(newCustomer.ShippingAddress.SecondaryPhone);
        //    SetShippingAddressLine1(newCustomer.ShippingAddress.AddressLine1);
        //    SetShippingAddressLine2(newCustomer.ShippingAddress.AddressLine2);
        //    SetShippingFaxNumber(newCustomer.ShippingAddress.FaxNumber);
        //    SetShippingMailStop(newCustomer.ShippingAddress.Mailstop);
        //}

        ///// <summary>
        ///// Enters the incomplete billing address.
        ///// </summary>
        ///// <param name="newCustomer">The new customer.</param>
        ///// <param name="line1">The line1.</param>
        //public void EnterIncompleteAddress(NewCustomer newCustomer, string line1)
        //{
        //    SetAllReqdFields(newCustomer);
        //    WebDriver.ClearText(By.Id(CustomerIDs.BillingInfoAddLine1Id));
        //    BillingAddressLine1 = line1;
        //    MarkSameAsBillingAddressCheckbox();
        //}

        ///// <summary>
        ///// add a note with given content
        ///// </summary>
        ///// <param name="customerNote"></param>
        //public void AddNotes(string customerNote)
        //{
        //    //WebDriver.FindElement(By.Id(CustomerIDs.AddNewCustomerNotes)).SendKeys(customerNote);
        //    //there are two elements with same id; the one it finds is the wrong one. So:
        //    WebDriver.SetText(By.TagName("textarea"), customerNote);
        //}

        ///// <summary>
        ///// save
        ///// </summary>
        //public void ClickSave()
        //{
        //    WebDriverByLblSummaryTotalTaxBy.Id(CustomerIDs.AddNewCustomerSaveButton));
        //    WebDriver.VerifyBusyOverlayNotDisplayed();
        //}

        ///// <summary>
        ///// cancel the Add
        ///// </summary>
        //public void ClickCancel()
        //{
        //    WebDriverByLblSummaryTotalTaxBy.Id(CustomerIDs.AddNewCustomerCancelButton));
        //}

        //public CreateCustomerPage SelectCompanyNumbers(string compNum)
        //{
        //    var selectCompNumr = new SelectCompanyNumberDailog(this, WebDriver.GetElement(_CompanyNumberPopUp));
        //    selectCompNumr.SelectCompanyNumber(compNum);

        //    return this;
        //}

        //private readonly By _CompanyNumberPopUp = By.Id(CustomerIDs.CompanyNumberPopUp);

        ///// <summary>
        ///// is validation modal up?
        ///// </summary>
        ///// <returns></returns>
        //public bool HasCustomerCreateValidationModal()
        //{
        //    return WebDriver.GetElement(By.Id(CustomerIDs.CustomerCreateValidationModelId)).Displayed;
        //}

        ///// <summary>
        ///// is dupe-customer warning up?
        ///// </summary>
        ///// <returns></returns>
        //public bool HasDupeCustomerWarningModal()
        //{
        //    return WebDriver.GetElement
        //        (By.Id(CustomerIDs.CustCreateSuggestnsWithSuggestnModalId)).Displayed;
        //}

        ///// <summary>
        ///// get any required fields that were not entered
        ///// </summary>
        ///// <returns></returns>
        //public string GetMissingFields()
        //{
        //    var by = new List<By>();
        //    by.Add(By.Id(CustomerIDs.ContactInfoCompanyNameId));
        //    by.Add(By.Id(CustomerIDs.BillingInfoFirstNameId));
        //    by.Add(By.Id(CustomerIDs.BillingInfoLastNameId));
        //    by.Add(By.Id(CustomerIDs.BillingInfoEmailId));
        //    by.Add(By.Id(CustomerIDs.BillingInfoAddLine1Id));
        //    by.Add(By.Id(CustomerIDs.BillingInfoCityId));
        //    by.Add(By.Id(CustomerIDs.BillingInfoStateId));
        //    by.Add(By.Id(CustomerIDs.BillingInfoZipCodeId));
        //    by.Add(By.Id(CustomerIDs.ShippingAddrFirstNameId));
        //    by.Add(By.Id(CustomerIDs.ShippingAddrLastNameId));
        //    by.Add(By.Id(CustomerIDs.ShippingAddrAddLine1Id));
        //    by.Add(By.Id(CustomerIDs.ShippingAddrCityId));
        //    by.Add(By.Id(CustomerIDs.ShippingAddrStateId));
        //    by.Add(By.Id(CustomerIDs.ShippingAddrZipCodeId));
        //    by.Add(By.Id(CustomerIDs.ContactInfoCustomerClassId));
        //    by.Add(By.Id(CustomerIDs.BillingInfoPrimaryPhoneId));
        //    by.Add(By.Id(CustomerIDs.ShippingAddrPrimaryPhoneId));

        //    return WebDriver.GetMissingRequiredFields(by.ToArray());
        //    // TOTO CustomerIDs.SalesRepId is off the screen, so can't be found
        //}

        ///// <summary>
        ///// is billing address suggestiong popup up?
        ///// </summary>
        ///// <returns></returns>
        //public bool HasBillingAddrSuggestionsPopup()
        //{
        //    return WebDriver.GetElement(By.Id(CustomerIDs.AddressSuggestionTitle)).Displayed;
        //}

        ///// <summary>
        ///// select the Entered billing address
        ///// </summary>
        //public CustomerDetailsPage SelectEnteredBillingAddr()
        //{
        //    return SelectEnteredAddress();
        //}

        ///// <summary>
        ///// select the Entered billing & shipping addresses
        ///// </summary>
        //public CustomerDetailsPage SelectEnteredBillAndShipAddr()
        //{
        //    SelectEnteredBillingAddr();
        //    return SelectEnteredAddress();
        //}

        ///// <summary>
        ///// get count of suggested addresses
        ///// </summary>
        ///// <returns></returns>
        //public int GetSugstnPopupEntrdAddrCount()
        //{
        //    return WebDriver.FindElements
        //        (By.Id(CustomerIDs.DupeCustModalEnteredAddrHeader)).Count;
        //}

        ///// <summary>
        ///// get count of similar addresses
        ///// </summary>
        ///// <returns></returns>
        //public int GetSugstnPopupSimilarAddrCount()
        //{
        //    return WebDriver.FindElements
        //        (By.Id(CustomerIDs.DupeCustModalSimilarAddrHeader)).Count;
        //}

        ///// <summary>
        ///// ???
        ///// </summary>
        ///// <returns></returns>
        //public bool HasSuggestedCorrectButton()
        //{
        //    return WebDriver.GetElement
        //        (By.Id(CustomerIDs.DupeCustModalSuggestedCorrectButton)).Displayed;
        //}

        ///// <summary>
        ///// does suggestions popup have a Close button?
        ///// </summary>
        ///// <returns></returns>
        //public bool HasSuggestedPopupCloseButton()
        //{
        //    return WebDriver.GetElement
        //        (By.Id(CustomerIDs.DupeCustModalCloseButton)).Displayed;
        //}

        ///// <summary>
        ///// select first suggestion
        ///// </summary>
        //public CustomerDetailsPage SelectFirstSuggestedAddress()
        //{
        //    return SelectSuggestedAddress(1);
        //}

        ///// <summary>
        ///// select given suggestion
        ///// </summary>
        ///// <param name="row"></param>
        //public CustomerDetailsPage SelectSuggestedAddress(int row)
        //{
        //    //click radio button
        //    WebDriverByLblSummaryTotalTaxBy.Id(string.Concat(CustomerIDs.SuggestedAddressLine1, row - 1)));
        //    //click [Select] 
        //    WebDriverByLblSummaryTotalTaxBy.Id(CustomerIDs.SuggestedAddressSelect));
        //    WebDriver.VerifyBusyOverlayNotDisplayed();
        //    return new CustomerDetailsPage(WebDriver); //doesn't always go there...
        //}

        ///// <summary>
        ///// stick with entered address
        ///// </summary>
        //public CustomerDetailsPage SelectEnteredAddress()
        //{
        //    WebDriverByLblSummaryTotalTaxBy.Id(CustomerIDs.EnteredAddressLine1));
        //    WebDriverByLblSummaryTotalTaxBy.Id(CustomerIDs.SuggestedAddressSelect));
        //    WebDriver.VerifyBusyOverlayNotDisplayed();
        //    return new CustomerDetailsPage(WebDriver); //doesn't always go there...
        //}

        ///// <summary>
        ///// edit the given suggested address
        ///// </summary>
        ///// <param name="row"></param>
        //public void EditSuggestedAddress(int row)
        //{
        //    WebDriverByLblSummaryTotalTaxBy.Id(string.Concat(CustomerIDs.SuggestedAddressLine1, row)));
        //    WebDriverByLblSummaryTotalTaxBy.Id(CustomerIDs.SuggestedAddressEdit));
        //}

        ///// <summary>
        ///// select a suggested duplicate customer
        ///// </summary>
        //public CustomerDetailsPage SelectSuggestedCustomer()
        //{
        //    WebDriverByLblSummaryTotalTaxBy.Id(CustomerIDs.DupeCustModalSuggestedCorrectButton));
        //    WebDriver.VerifyBusyOverlayNotDisplayed();
        //    return new CustomerDetailsPage(WebDriver);
        //}

        ///// <summary>
        ///// select entered duplicate customer
        ///// </summary>
        //public CustomerDetailsPage SelectEnteredCustomer()
        //{
        //    if (WebDriver.GetElement(By.Id(CustomerIDs.DupeCustModalSaveEnteredButton)).Displayed)
        //    {
        //        WebDriverByLblSummaryTotalTaxBy.Id(CustomerIDs.DupeCustModalSaveEnteredButton));
        //        WebDriver.VerifyBusyOverlayNotDisplayed();
        //    }
        //    return new CustomerDetailsPage(WebDriver);
        //}

        ///// <summary>
        ///// is customer addr suggestion header up?
        ///// </summary>
        ///// <returns></returns>
        //public bool HasCustAddressSuggestionHeader()
        //{
        //    return WebDriver.GetElement(By.Id(CustomerIDs.AddressSuggestionTitle)).Displayed;
        //}

        ///// <summary>
        ///// Close duplicate customer modal 
        ///// </summary>
        //public void ClickCloseButton()
        //{
        //    WebDriverByLblSummaryTotalTaxBy.Id(CustomerIDs.DupeCustModalCloseButton));
        //}

        ///// <summary>
        ///// get the PO Box warning message
        ///// </summary>
        ///// <returns></returns>
        //public string GetPoBoxWarning()
        //{
        //    return
        //        WebDriver.FindElement(By.CssSelector("span.invalid-input.ng-binding")).Text;
        //}

        ///// <summary>
        ///// get the warning messages
        ///// </summary>
        ///// <returns></returns>
        //public List<string> GetWarningMessages()
        //{
        //    var messages = WebDriver.FindElements(By.CssSelector("span.invalid-input.ng-binding"));
        //    return (from message in messages where message.Text != "" select message.Text).ToList();
        //}

        ///// <summary>
        ///// get the count of warning PO Box messages
        ///// </summary>
        ///// <returns></returns>
        //public long GetPoBoxWarningCount()
        //{
        //    return WebDriver.ExecuteJsScript<long>
        //        (string.Format("return $('span.invalid-input.ng-binding').text().split('PO').length-1"));
        //}

        //public CustomerDetailsPage Validation_UseOriginalAddress()
        //{
        //    WebDriverByLblSummaryTotalTaxBy.Id(CustomerIDs.ValidateAddressCancelButton));
        //    return new CustomerDetailsPage(WebDriver);
        //}

        //public void ValidationMsg_ClickEdit()
        //{
        //    WebDriverByLblSummaryTotalTaxBy.Id(CustomerIDs.ValidateAddressEditButton));
        //}

        //public void SetValidateStreet(string addressLine1)
        //{
        //    WebDriver.ClearText(By.Id(CustomerIDs.ValidateAddressStreet));
        //    WebDriver.SetText(By.Id(CustomerIDs.ValidateAddressStreet), addressLine1);
        //    WebDriver.GetElement(By.Id(CustomerIDs.ValidateAddressStreet)).SendKeys(Keys.Tab);
        //    WebDriverByLblSummaryTotalTaxBy.Id(CustomerIDs.ValidateAddressOKButton));
        //}



        //public bool IsAVSVisible()
        //{
        //    return AVSModel.Displayed;
        //}

        public int ValidateAddressLinePObox(string line, string pobox, int status)
        {
            ShippingContactAddressLine1Txt.WaitForElement(WebDriver);
            if (line == AddressLine.Line1.ToString()) ShippingContactAddressLine1Txt.SendKeys(pobox);
            else
                if (line == AddressLine.Line2.ToString()) ShippingContactAddressLine2Txt.SendKeys(pobox);
            ShippingContactAddressLine1Txt.SendKeys(Keys.Tab);

            try
            {
                if (WebDriver.IsElementVisible(POboxValidationMsg))
                {
                    Logger.Write(pobox + "is validated");
                }
            }
            catch (NoSuchElementException)
            {
                Logger.Write(pobox + "is not validated");
                status++;
            }

            ShippingContactAddressLine1Txt.Clear();
            ShippingContactAddressLine1Txt.SendKeys(Keys.Tab);
            return status;
        }

        /// <summary>
        /// Determines if Customer creation pending popup is displayed.
        /// </summary>
        /// <param name="webDriver"></param>
        /// <returns></returns>
        public bool IsCustomerCreationPending()
        {
            return CustomerCreatePendingPopup.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>customerNumber</returns>
        public string GetPendingCustomerNumber()
        {
            var pendingMessage = CustomerCreatePendingPopupMessage.Text;
            var customerNumber = Regex.Match(pendingMessage, @"\d+").Value;

            return customerNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ContinueWithPendingCustomerCreation()
        {
            CustomerCreatePendingPopupOkBtn.Click(WebDriver);
        }

        //Marketing preference Email opt in/opt out method
        public bool IsEmailMPEnabled()
        {
            return EmailMP.Enabled;
        }

        public bool EmailMPRadioButton()
        {

            if (EmailMP.IsElementClickable(WebDriver))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool directMailPMCRadioButton()
        {

            if (directMailPMC.IsElementClickable(WebDriver))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MobilePMCOptInRadioButton()
        {

            if (MobilePMCOptIn.IsElementClickable(WebDriver))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PhonePMCRadioButton()
        {

            if (PhonePMC.IsElementClickable(WebDriver))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //customerCreatePage.MailingInfoMobilePhone.Click();

        

    }
}