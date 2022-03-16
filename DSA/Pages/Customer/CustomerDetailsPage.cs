using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Dsa.Pages.Quote;
using Dsa.Pages.Order;
using System.Data;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Enums;
using Dsa.Pages.Account;
using OpenQA.Selenium.Support.UI;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;
using Dell.Adept.Web;

namespace Dsa.Pages.Customer
{
    public class CustomerDetailsPage : DsaPageBase
    {
        public CustomerDetailsPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements

        public IWebElement MobileNumber { get { return WebDriver.GetElement(By.Id("EditContactDialog_contact_mobilePhone")); } }

        public IWebElement WorkNumber { get { return WebDriver.GetElement(By.Id("EditContactDialog_contact_workPhone")); } }

        public IWebElement LblMenuMain { get { return WebDriver.GetElement(By.Id("menu_main_label")); } }

        public IWebElement LnkMenuHome { get { return WebDriver.GetElement(By.Id("menu_home_link")); } }

        public IWebElement CustomerInformationId { get { return WebDriver.GetElement(By.Id("customerDetails_customerDetails")); } }

        public IWebElement CustomerName { get { return WebDriver.GetElement(By.Id("quoteSearchResults_customerName")); } }

        public IWebElement CustomerInformationGridId { get { return WebDriver.GetElement(By.Id("customerDetails_customerInformation")); } }

        public IWebElement HdrCustomerDetail { get { return WebDriver.GetElement(By.Id("customerDetails_header")); } }

        public IWebElement HdrBillToAddress { get { return WebDriver.GetElement(By.Id("customerDetails_detailsHighlight_header_billToAddress")); } }

        public IWebElement ContactAddressId { get { return WebDriver.GetElement(By.Id("customerDetails_contactAddressesToggle")); } }

        public IWebElement FinancialInfoId { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Financial Information')]")); } }

        public List<IWebElement> AllEmailOverrideValidation { get { return WebDriver.GetElements(By.XPath("//div/email-errors//input[@class='form-input']")); } }

        public List<IWebElement> AllPhoneOverrideValidation { get { return WebDriver.GetElements(By.XPath("//div/phone-errors//input[@class='form-input']")); } }

        public IWebElement EmailOverrideValidation { get { return WebDriver.GetElement(By.XPath("//div/email-errors//input[@class='form-input']")); } }

        public IWebElement PhoneOverrideValidation { get { return WebDriver.GetElement(By.XPath("//div/phone-errors//input[@class='form-input']")); } }

        public IWebElement Currency { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_Customer_Currency")); } }

        public IWebElement LstDashboardMenu { get { return WebDriver.GetElement(By.XPath(".//*[@id='body-content']/descendant::dashboard/span/ul")); } }

        public IWebElement LinkViewForCustomer { get { return WebDriver.GetElement(By.Id("dashboardByCustomer")); } }

        public IWebElement AdditionalAddressFields { get { return WebDriver.GetElement(By.XPath("//*[@class='address-line2-extra-fields']")); } }

        public IWebElement FieldApartment { get { return WebDriver.GetElement(By.Id("apartment")); } }

        public IWebElement FieldBuilding { get { return WebDriver.GetElement(By.Id("building")); } }

        public IWebElement FieldDepartment { get { return WebDriver.GetElement(By.Id("department")); } }

        public IWebElement FieldSuite { get { return WebDriver.GetElement(By.Id("suite")); } }

        public IWebElement FieldFloor { get { return WebDriver.GetElement(By.Id("floor")); } }

        public IWebElement FieldRoom { get { return WebDriver.GetElement(By.Id("suite")); } }

        public IWebElement LinkViewForAccount { get { return WebDriver.GetElement(By.Id("dashboardByAccount")); } }

        By LnkViewForCustomer = By.Id("dashboardByCustomer");
        By LnkViewForAccount = By.Id("dashboardByAccount");

        public IWebElement CompanyName1 { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Company Name 1')]")); } }

        public IWebElement CompanyName2 { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Company Name 2')]")); } }

        public IWebElement CAMLocationID { get { return WebDriver.GetElement(By.XPath(".//*[@id='customerDetails_Locations']//div[@id='DataTables_div_locations']//span[contains(text(),'CAM Location Id')]/following-sibling::div")); } }

        public IWebElement AddressID { get { return WebDriver.GetElement(By.XPath(".//*[@id='customerDetails_Locations']//div[@id='DataTables_div_locations']//span[contains(text(),'Address Id')]/following-sibling::div")); } }

        public IWebElement AddressIDLocations { get { return WebDriver.GetElement(By.XPath("//div[@id='DataTables_div_locations']//span[contains(text(),'Address Id')]/following-sibling::div")); } }

        public IWebElement CAMLocationIDLocations { get { return WebDriver.GetElement(By.XPath("//div[@id='DataTables_div_locations']//span[contains(text(),'CAM Location Id')]/following-sibling::div")); } }

        public IWebElement CatalogContentValue { get { return WebDriver.GetElement(By.Id("DataTables_Table_companyNumbers")); } }

        public IWebElement FldCustomerNumber { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Customer Number')]")); } }

        public IWebElement LblLinkType { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Link Type')]")); } }

        public List<IWebElement> ExpandAddressLocation { get { return WebDriver.GetElements(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr/td/a")); } }

        public IWebElement SalesRepName { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_salesRepComponent_name_value")); } }

        public IWebElement ErrorPopUpMsg { get { return WebDriver.GetElement(By.Id("dialog_heading")); } }

        public IWebElement DFSHeaderSection { get { return WebDriver.GetElement(By.XPath("//dfs-smb-header/div[1]/div[1]/div[1]")); } }

        public IWebElement UCIDNoUCIDResultsPage { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/div[1]/div/div[2]")); } }

        public IWebElement UCIDStatusUCIDResultsPage { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/div[2]/div/div[2]")); } }

        public IWebElement CustomerHoldStatus { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_CustomerHold")); } }

        public IWebElement CompLegNameField { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Company Legal Name')]")); } }

        public IWebElement PreferredLangField { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Preferred Language')]")); } }

        public IWebElement TaxExemptField { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Tax Exempt')]")); } }

        public IWebElement CompPhoneField { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Company Phone')]")); } }

        public IWebElement CompFaxField { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Company Fax')]")); } }

        public IWebElement LastUpdatedValue { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_LastUpdated")); } }

        public IWebElement AccountNumberTxt { get { return WebDriver.GetElement(By.XPath(".//*[@id='customerDetails_informationComponent_accountComponent_accountNumber']/div/div")); } }

        public IWebElement AccountNameTxt { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_header']/a")); } }

        public IWebElement TaxExemptStatus { get { return WebDriver.GetElement(By.XPath("//*[@id='exemption']")); } }

        public IWebElement SeeExemptStates { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_informationComponent']//state-province-tax-exemption//a[contains(text(), 'See Exempt States')]")); } }

        public IWebElement SeeExemptStatesHeading { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_informationComponent']//state-province-tax-exemption//popover-content//h3")); } }

        public IWebElement TblFinancialInfo { get { return WebDriver.GetElement(By.Id("customerDetails_financialInformation")); } }

        public IWebElement BtnCreateQuote { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_createQuote']")); } }

        public IWebElement BtnCreateAPOSQuote { get { return WebDriver.GetElement(By.Id("customerDetailsNavigation_createAposQuote")); } }

        public IWebElement BtnCreateNexusQuote { get { return WebDriver.GetElement(By.Id("customerDetailsNavigation_createNexusQuote1")); } }

        public IWebElement BtnCreateQuoteToggle { get { return WebDriver.GetElement(By.XPath("//*[@class = 'btn btn-success dropdown-toggle']")); } }

        public IWebElement ViewAccountId { get { return WebDriver.GetElement(By.Id("customerDetails_viewAccountFromCustomer")); } }

        public IWebElement MoreActions { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'More Actions')][1]")); } }

        public IWebElement RequestHold { get { return WebDriver.GetElement(By.Id("customerdetails_requesthold")); } }

        public IWebElement BtnUseInQuoteAsEndUser { get { return WebDriver.GetElement(By.Id("customerDetails_useEndUser")); } }

        public IWebElement BtnUseInQuoteAsInstallAtCustomer { get { return WebDriver.GetElement(By.Id("customerDetails_installAt")); } }

        public IWebElement btnuse { get { return WebDriver.GetElement(By.XPath("//button[@id='customerDetails_installAt']")); } }

        public IWebElement BtnEndUser { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_customerDetails']//following::div[contains(text(),'End Users')]")); } }

        public IWebElement BtnMyAccountCart { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_view']//div[contains(text(), 'My Account Carts')]")); } }

        public IWebElement BtnViewAllMyAccountsCart { get { return WebDriver.GetElement(By.Id("customerDetails_viewAll")); } }

        public IWebElement LnkAddDellAdvantage { get { return WebDriver.GetElement(By.XPath("//a[@id='customerDetails_addMyAccount']")); } }

        public IWebElement BtnsubmitDellAdvantage { get { return WebDriver.GetElement(By.XPath("//button[contains(text(),'Create & Add My Account')]")); } }

        public IWebElement BtnCancelDellAdvantage { get { return WebDriver.GetElement(By.XPath("//div[@id='_searchAndCreateMyAccount_content']//button[@id='_cancel']")); } }

        public IWebElement BtnFunders { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_view']/div[6]/div[1]/div")); } }

        public IWebElement LnkAddFunderCustomer { get { return WebDriver.GetElement(By.XPath("//*[@id='add']")); } }

        public IWebElement AddFunderCustomerNumber { get { return WebDriver.GetElement(By.Id("customerId")); } }

        public IWebElement LnkEditSalesRep { get { return WebDriver.GetElement(By.Id("customerDetails_editSalesRep")); } }

        public IWebElement TxtSalesRepInput { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_salesRepComponent_salesRepIdInput")); } }

        public IWebElement LnkSaveSalesRep { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_salesRepComponent_updateSalesRep")); } }

        public IWebElement AddFunderDealerId { get { return WebDriver.GetElement(By.Id("dealerId")); } }

        public IWebElement AddFunderRelationshipTerm { get { return WebDriver.GetElement(By.Id("relationshipTerm")); } }

        public IWebElement SubmitBtn { get { return WebDriver.GetElement(By.Id("Add_Credit_Request_submit")); } }

        public IWebElement SubmitBtn1 { get { return WebDriver.GetElement(By.Id("_submit")); } }

        public IWebElement ChannelSubmitBtn { get { return WebDriver.GetElement(By.Id("_submit")); } }

        public IWebElement FunderMustbeSameasParent { get { return WebDriver.GetElement(By.XPath("//*[@class ='alert alert-error ng-star-inserted']")); } }

        public IWebElement AddFunderTableRow1 { get { return WebDriver.GetElement(By.Id("DataTables_Table_FunderCustomersGrid")); } }

        public IWebElement LocationsRow2 { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[2]")); } }

        public IWebElement LocationsRow1 { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[1]")); } }

        public IWebElement TypeBillingPrime { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[1]/td[9]")); } }

        public IWebElement TypeShippingPrime { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[2]/td[9]")); } }

        public IWebElement AddEndUserTableRow1 { get { return WebDriver.GetElement(By.Id("DataTables_Table_EnduserCustomersGrid")); } }

        public IWebElement EndUserTable { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_EnduserCustomersGrid']/tbody/tr")); } }

        public IWebElement LinkNumberTextBox { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_linkNumber']")); } }

        public IWebElement LinkNumberDropdown { get { return WebDriver.GetElement(By.Id("customerDetails_linkType")); } }

        public IWebElement LnkAddEndUser { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_EndUser']//*[@id='add']")); } }

        public IWebElement CustomerNoandSegment { get { return WebDriver.GetElement(By.XPath("//*[@id='body-content']//h5")); } }

        public IWebElement EndUserTextboxPopup { get { return WebDriver.GetElement(By.Id("customerId")); } }

        public IWebElement CustomerHold { get { return WebDriver.GetElement(By.Id("customerDetails_CustomerHold")); } }

        public IWebElement LnkAddAffinityId { get { return WebDriver.GetElement(By.Id("customerDetails_showAdd")); } }

        public IWebElement LnkAddAffinityAccountSubmit { get { return WebDriver.GetElement(By.Id("customerDetails_submitAccount")); } }

        public IWebElement AlertMessage { get { return WebDriver.GetElement(By.XPath("//*[@class='alert alert-danger']")); } }

        public IWebElement MsgAffinityError { get { return WebDriver.GetElement(By.Id("customerDetails_accountMessage")); } }

        public IWebElement DivCustomerDetailsMyAccount { get { return WebDriver.GetElement(By.Id("customer-detail-add-myaccount")); } }

        public IWebElement CustomerDetailsMyAccountEmails { get { return WebDriver.GetElement(By.Id("customerDetails_myAccount")); } }

        public IWebElement LblLinkNumberLabel { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Link Number')]")); } }

        public IWebElement LblCompanyNumber { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_CompanyNumber")); } }

        public IWebElement LnkAddLinkNumber { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_linkComponent_addlinkNumber")); } }

        public IWebElement LblLinkNumber { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_linkComponent_linkNumber")); } }

        public IWebElement DdlLinkType { get { return WebDriver.GetElement(By.Name("linkType")); } }

        public IWebElement LnkUseInQuote { get { return WebDriver.GetElement(By.Id("customerDetails_useQuote")); } }

        public IWebElement LnkSaveLinkNumber { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_linkComponent_updateLinkType")); } }

        public IWebElement LinkNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_informationComponent_linkComponent']//div[1]//span[1]")); } }

        public IWebElement LnkCancelSaveLinkNumber { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_linkComponent_cancelLinkNumber")); } }

        public IWebElement DivSaveLinkNumberError { get { return WebDriver.GetElement(By.Id("customerDetails_customerLinkNumberNotUpdated")); } }

        public IWebElement LnkEditLinkNumber { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_linkComponent_updateLinkNumber")); } }

        public IWebElement TxtContactCFOLanguage { get { return WebDriver.GetElement(By.Id("customerDetails_CFOLang")); } }

        public IWebElement TxtLinkNumber { get { return WebDriver.GetElement(By.TagName("input")); } }

        public IWebElement LnkDeleteLinkNumber { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_linkComponent_deleteLinkNumber")); } }

        public IWebElement LblCustomerNumber { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_CustomerNumber")); } }

        public IWebElement CompanyName { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_CustomerName")); } }

        public IWebElement LegalCompanyName { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_LegalCompanyName")); } }

        public IWebElement PhoneNumber { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_companyPhone_value")); } }

        public IWebElement FaxNumber { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_companyFax_value")); } }

        public IWebElement PhoneNumberMobile { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[2]/td/customer-details-locations-expand-view/div/div/div/div/div[3]/div[1]/div")); } }

        public IWebElement ExpandAddressLocations { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[1]/td[1]/a")); } }

        public IWebElement CountryCodeMobileNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[2]/td/add-component/customer-details-locations-expand-view/div/div/div/div/div[3]/div[1]")); } }

        public IWebElement CountryCodeWorkNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[2]/td/add-component/customer-details-locations-expand-view/div/div/div/div/div[3]/div[2]")); } }

        public IWebElement CountryCodeFaxNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[2]/td/add-component/customer-details-locations-expand-view/div/div/div/div/div[3]/div[3]")); } }

        public IWebElement HdrCustomerNumber { get { return WebDriver.GetElement(By.Id("customerDetailsNavigation_customerNumber")); } }

        public IWebElement TxtSalesRepId { get { return WebDriver.GetElement(By.Name("salesRepId")); } }

        public IWebElement SalesRepId { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_salesRepComponent_id_value")); } }

        public IWebElement LnkEditSalesRepId { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_salesRepComponent_editSalesRep")); } }

        public IWebElement StarMakeFavorite { get { return WebDriver.GetElement(By.XPath(".//a[@title='Mark Favorite']/i")); } }

        public IWebElement StarRemoveFavorite { get { return WebDriver.GetElement(By.XPath(".//a[@title='Remove Favorite']/i")); } }

        public IWebElement TxtEditSalesRepId { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_salesRepComponent_salesRepIdInput")); } }

        public IWebElement SaveEditSalesRepId { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_salesRepComponent_updateSalesRep")); } }

        public IWebElement LnkAddAccountNumber { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_accountComponent_showAdd")); } }

        public IWebElement TxtCompanyPhone { get { return WebDriver.GetElement(By.XPath("//div/label[text()='Company Phone:']/parent::div//div[@id='sales-rep-name']")); } }

        public IWebElement TxtCompanyFax { get { return WebDriver.GetElement(By.XPath("//div/label[text()='Company Fax:']/parent::div//div[@id='sales-rep-name']")); } }

        public IWebElement MsgDfsCustomer { get { return WebDriver.GetElement(By.Id("_dfsEnabled_dfsMessage")); } }

        public IWebElement DfsCustomerStatus { get { return WebDriver.GetElement(By.Id("customerDetails_dfsStatus")); } }

        public IWebElement DfsCustomerMessage { get { return WebDriver.GetElement(By.Id("customerDetails_dfsMessage")); } }
        public IWebElement DfsCustomerCreditStatus { get { return WebDriver.GetElement(By.Id("customerDetails_dbcCreditStatus")); } }

        public IWebElement DfsCustomerLeaseCreditStatus { get { return WebDriver.GetElement(By.Id("customerDetails_leaseCreditStatus")); } }

        public IWebElement DfsCustomerPaymentTerms { get { return WebDriver.GetElement(By.Id("customerDetails_paymentTerms")); } }

        public IWebElement DfsCustomerCurrency { get { return WebDriver.GetElement(By.Id("customerDetails_currency")); } }

        public IWebElement PreferredLang { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_informationComponent_preferredLanguageComponent_customerPreferredLanguage']")); } }

        public IWebElement PreferedLangCanada { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_informationComponent_preferredLanguageComponent_customerPreferredLanguage']/text()")); } }

        public IWebElement DfsCustomerCreditLimit { get { return WebDriver.GetElement(By.Id("customerDetails_creditLimit")); } }

        public IWebElement DfsCustomerCurrentBalance { get { return WebDriver.GetElement(By.Id("customerDetails_currencyBalance")); } }

        public IWebElement Location { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_view']/div[2]/div[1]/div")); } }

        public IWebElement UseOriginalAddress { get { return WebDriver.GetElement(By.Id("AddressSuggestionsDialog_addShippingAddress_useOriginal")); } }

        public IWebElement ShiptoCustomerBanner { get { return WebDriver.GetElement(By.Id("customerDetails_warning_cannotCreateQuoteBecauseItIsFunderAccount")); } }

        public IWebElement customerInfo { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_informationComponent']//div//div")); } }

        public IWebElement locations { get { return WebDriver.GetElement(By.Id("customerDetails_locations")); } }

        public IWebElement ConfirmYesBtn { get { return WebDriver.GetElement(By.Id("AddressSuggestionsDialog_addShippingAddress_select")); } }

        public IWebElement TypeOfCreditRequest { get { return WebDriver.GetElement(By.Name("creditRequestType")); } }

        public IWebElement CreditSuccessMessage { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Success! The credit request')]")); } }

        public IWebElement CreditErrorMessage { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-error ng-star-inserted']")); } }

        public IWebElement AddlocationCompanyName { get { return WebDriver.GetElement(By.XPath("//*[@id='mat-dialog-title-0']//div//h2")); } }

        public IWebElement creditRequestPopupClose { get { return WebDriver.GetElement(By.Id("Add_Credit_Request_cancel")); } }

        public IWebElement CreditComment { get { return WebDriver.GetElement(By.XPath("//*[@id='creditRequest_comments']")); } }

        public IWebElement CreditLimit { get { return WebDriver.GetElement(By.XPath("//*[@id='creditRequest_creditlimit']")); } }

        public IWebElement CreditReqPaymentType { get { return WebDriver.GetElement(By.XPath("//*[@id='creditRequest_paymentType']")); } }

        public IWebElement FirstNoteText { get { return WebDriver.GetElement(By.CssSelector("#CreditRequestNotesDialog_viewNotes~.mat-dialog-content>.view-notes-dialog-content-wrapper>div:nth-child(1)>div:nth-child(3)")); } }

        public IWebElement FirstNoteTime { get { return WebDriver.GetElement(By.CssSelector("#CreditRequestNotesDialog_viewNotes~.mat-dialog-content>.view-notes-dialog-content-wrapper>div:nth-child(1)>div:nth-child(2)")); } }

        public IWebElement CreditReqFunderCustomer { get { return WebDriver.GetElement(By.XPath("//*[@id='creditRequest_funderCustomer']")); } }

        public IWebElement CreditRequestSubmitbtn { get { return WebDriver.GetElement(By.Id("Add_Credit_Request_submit")); } }

        public IWebElement AddNewAddressLocation { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_addLocation']")); } }

        public IWebElement AddNewContactLocation { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_addNewContact']")); } }

        public IWebElement EditContactPrimaryShipping { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']//tr[1]//a[contains(text(),'Edit Contact')]")); } }

        public IWebElement EditContactPrimaryBilling { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']//tr[2]//a[contains(text(),'Edit Contact')]")); } }

        public IWebElement AddLocationEditContact { get { return WebDriver.GetElement(By.XPath("/html/body/div[3]/div[2]/div/div[2]/div[1]/div[2]/div[1]/div/div[2]/div[2]/div/div/div/div/span/div[2]/div[1]/div/table/tbody/tr[1]/td[12]/span/a")); } }

        public IWebElement AddLocationCheckBilling { get { return WebDriver.GetElement(By.XPath("//*[text()='Types']//following::input[1]")); } }

        public IWebElement AddLocationCheckBillingAsPrimary { get { return WebDriver.GetElement(By.XPath("//*[@id='COM']/div[4]/div/div/form/div[2]/fieldset/div/div[1]/div[2]/label/input")); } }

        public IWebElement AddLocationCheckShipping { get { return WebDriver.GetElement(By.XPath("//*[text()='Types']//following::input[2]")); } }

        public IWebElement AddLocationCheckShippingAsPrimary { get { return WebDriver.GetElement(By.XPath("//*[text()='Types']//following::input[3]")); } }

        public IWebElement AddLocationShippingAsPrimary { get { return WebDriver.GetElement(By.XPath("//*[@id='mat - dialog - 0]/add-location-dialog/form/mat-dialog-content/div[1]/div[1]/div/div[2]/label[2]/input")); } }

        public IWebElement AddLocationCheckMailing { get { return WebDriver.GetElement(By.XPath("//*[@id='COM']/div[4]/div/div/form/div[2]/fieldset/div/div[3]/div[1]/label/input")); } }

        public IWebElement AddLocationCheckMailingAsPrimary { get { return WebDriver.GetElement(By.XPath("//*[@id='COM']/div[4]/div/div/form/div[2]/fieldset/div/div[3]/div[2]/label/input")); } }

        public IWebElement HdrDfsCustomerFinancialInfo { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_view']/div[3]/div/div")); } }

        public IWebElement AddLocationAddress1 { get { return WebDriver.GetElement(By.Id("AddLocationDialog_address_line1")); } }

        public IWebElement AddLocationAddress2 { get { return WebDriver.GetElement(By.Id("AddLocationDialog_address_line2")); } }

        public IWebElement AddressLineShippingPrimary { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[2]/td[4]")); } }

        public IWebElement AddLocationAddress1WarningMsg { get { return WebDriver.GetElement(By.XPath("//p[contains(text(),'Cannot accept the')]")); } }

        public IWebElement AddLocationCity { get { return WebDriver.GetElement(By.Name("city")); } }

        public IWebElement AddLocationZipcode { get { return WebDriver.GetElement(By.Id("AddLocationDialog_address_postalCode")); } }

        public IWebElement AddLocationPostalcode { get { return WebDriver.GetElement(By.Id("AddLocationDialog_address_postalCode")); } }

        public IWebElement AddLocationSelectTitle { get { return WebDriver.GetElement(By.Name("title")); } }

        public IWebElement AddLocationFirstName { get { return WebDriver.GetElement(By.Id("AddLocationDialog_contact_firstName")); } }

        public IWebElement AddLocationLastName { get { return WebDriver.GetElement(By.Id("AddLocationDialog_contact_lastName")); } }

        public IWebElement AddNewContactTitle { get { return WebDriver.GetElement(By.Name("title")); } }

        public IWebElement AddLocationPhoneHome { get { return WebDriver.GetElement(By.Name("homePhone")); } }

        public IWebElement AddLocationSelectCountry { get { return WebDriver.GetElement(By.Name("country")); } }

        public IWebElement Expndlocations { get { return WebDriver.GetElement(By.Id("customerDetails_locations")); } }

        public IWebElement AddLocationSelectState { get { return WebDriver.GetElement(By.Name("state")); } }

        public IWebElement AddLocationSelectProvince { get { return WebDriver.GetElement(By.Id("AddLocationDialog_address_state")); } }

        public IWebElement AddLocationMailStop { get { return WebDriver.GetElement(By.Id("AddLocationDialog_address_shippingAddress_mailStop")); } }

        public IWebElement AddNewAddressCountry { get { return WebDriver.GetElement(By.XPath("//*[@id='AddLocationDialog_address_country']")); } }

        public IWebElement AddLocationPhoneMobile { get { return WebDriver.GetElement(By.Id("AddLocationDialog_contact_mobilePhone")); } }

        public IWebElement AddLocationPhoneWork { get { return WebDriver.GetElement(By.Id("AddLocationDialog_contact_workPhone")); } }

        public IWebElement AddLocationFaxNumber { get { return WebDriver.GetElement(By.Id("AddLocationDialog_contact_faxNumber")); } }

        public IWebElement AddLocationEmailInvoice { get { return WebDriver.GetElement(By.Id("AddLocationDialog_contact_email")); } }

        public IWebElement InvoiceDeliveryTxt { get { return WebDriver.GetElement(By.Id("AddLocationDialog_contact_invoiceDeliveryMethod")); } }

        public IWebElement InvoicePreferenceTxt { get { return WebDriver.GetElement(By.Id("AddLocationDialog_contact_invoicePreference")); } }

        public IWebElement CancelButton { get { return WebDriver.GetElement(By.Id("AddLocationDialog_cancel")); } }

        public IWebElement WarningforAddNewContact { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'alert alert-warning')]")); } }

        public IWebElement Close { get { return WebDriver.GetElement(By.Name("close")); } }

        public IWebElement AddLocationSelectInvoicingDelivery { get { return WebDriver.GetElement(By.Name("invoicedeliverymethod")); } }

        public IWebElement AddLocationSubmit { get { return WebDriver.GetElement(By.Id("AddLocationDialog_submit")); } }

        public IWebElement AddNewContact { get { return WebDriver.GetElement(By.XPath("//*[text()='Add New Contact']")); } }

        public IWebElement AddNewAddress { get { return WebDriver.GetElement(By.XPath("//*[text()='Add New Address']")); } }

        public IWebElement AddNewContactFirstName { get { return WebDriver.GetElement(By.XPath("//*[@id='AddNewContactComponent_first_name']")); } }

        public IWebElement AddNewContactLastName { get { return WebDriver.GetElement(By.XPath("//*[@id='AddNewContactComponent_last_name']")); } }

        public IWebElement AddNewContactMobilePhone { get { return WebDriver.GetElement(By.Name("mobilePhone")); } }

        public IWebElement AddNewContactWorkPhone { get { return WebDriver.GetElement(By.Name("workPhone")); } }

        public IWebElement AddNewContactEmail { get { return WebDriver.GetElement(By.Id("AddNewContactComponent_email")); } }

        public IWebElement AddNewContactSelectShippingAddress { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_addressInfo']/tbody/tr[2]/td[10]/input")); } }

        public IWebElement AddNewContactSaveButton { get { return WebDriver.GetElement(By.Id("AddNewContactComponent_saveContact")); } }

        public IWebElement AddNewContactDuplicateCheck { get { return WebDriver.GetElement(By.XPath("//*[@class='alert alert-error ng-star-inserted']")); } }

        public IWebElement ViewAllLocation { get { return WebDriver.GetElement(By.Id("customerDetails_LocationsViewAll")); } }

        public IWebElement LocationsAndContactsTable { get { return WebDriver.GetElement(By.Id("DataTables_div_locations")); } }

        public IWebElement LocationsTable { get { return WebDriver.GetElement(By.XPath("/html/body/div[3]/div[2]/div/div[2]/div[1]/div[2]/div[1]/div/div[2]/div[2]/div/div/div/div/span/div[2]/div[1]/div/table")); } }

        public IWebElement LocationsTableRow1 { get { return WebDriver.GetElement(By.XPath("/html/body/div[3]/div[2]/div/div[2]/div[1]/div[2]/div[1]/div/div[2]/div[2]/div/div/div/div/span/div[2]/div[1]/div/table/tbody/tr[1]")); } }

        public IWebElement LocationsTableRow2 { get { return WebDriver.GetElement(By.XPath("/html/body/div[3]/div[2]/div/div[2]/div[1]/div[2]/div[1]/div/div[2]/div[2]/div/div/div/div/span/div[2]/div[1]/div/table/tbody/tr[2]")); } }

        public IWebElement DfsEligible { get { return WebDriver.GetElement(By.Id("customerDetails_dfsEnabled_dfsStatus")); } }

        public IWebElement CreditDetails { get { return WebDriver.GetElement(By.Id("credit-details-container")); } }

        public IWebElement CreditRequestDetails { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_view']/div[3]/div[2]/div/div[2]/div[1]/div/small")); } }

        public IWebElement RemainingBalanceLable { get { return WebDriver.GetElement(By.Id("customerDetails_remainingBalance")); } }

        public IWebElement OrderSection { get { return WebDriver.GetElement(By.Id("customerDetails_orderListSection")); } }

        public IWebElement OrderId { get { return WebDriver.GetElement(By.Id("customerDetails_orderListHeading")); } }

        public IWebElement OrderGrid { get { return WebDriver.GetElement(By.Id("customerDetails_ordersGrid")); } }

        public IWebElement OrderList { get { return WebDriver.GetElement(By.Id("customerDetails_orderList")); } }

        public IWebElement BtnExpandOrderList { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'Order List')]")); } }

        public IWebElement POColumn { get { return WebDriver.GetElement(By.XPath(".//*[@id='DataTables_div_customerDetails_Orders_OrdersGrid']/table/thead/tr/th[5]")); } }

        public IWebElement OrderListViewAll { get { return WebDriver.GetElement(By.Id("customerDetails_orderListViewAll")); } }

        public IWebElement ShipToAddressId { get { return WebDriver.GetElement(By.Id("customerDetails_shipToAddressesHeading")); } }

        public IWebElement ShipToAddressGrid { get { return WebDriver.GetElement(By.Id("customerDetails_shipToAddresses")); } }

        public IWebElement ShipToAddressViewAll { get { return WebDriver.GetElement(By.Id("customerDetails_shippingAddressesListViewAll")); } }

        public IWebElement HdrAddShippingAddress { get { return WebDriver.GetElement(By.Id("customerDetails_shippingAddress_header")); } }

        public IWebElement LnkAddShipToAddress { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='Add Location/Contact']")); } }

        public IWebElement AddShipToAddrCompanyName { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_companyName")); } }

        public IWebElement AddShipToAddrPrimaryPhone { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_primaryPhone")); } }

        public IWebElement HdrShipToAddressAll { get { return WebDriver.GetElement(By.Id("customer_shipping_addresses_list_h")); } }

        public IWebElement ShipToAddressAllGrid { get { return WebDriver.GetElement(By.Id("customerDetailsShipToAddressList")); } }

        public IWebElement DivAddShipping { get { return WebDriver.GetElement(By.Id("customerDetails_add_shippingAddress")); } }

        public IWebElement AddressSuggestionModal { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_shippingAddress_validation_withSuggestion")); } }

        public IWebElement HdrAddressSuggestion { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_shippingAddress_validation_withSuggestion_header")); } }

        public IWebElement AddressSuggestionTitle { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_entered_address_header")); } }

        public IWebElement MsgCannotValidateAddressModal { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_shippingAddress_validationMessage")); } }

        public IWebElement HdrCannotValidateAddress { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_shippingAddress_validationMessage_header")); } }

        public IWebElement MsgValidateAddressAdditional { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_additionalMessages")); } }

        public IWebElement BtnValidateAddressOK { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_address_ok")); } }

        public IWebElement BtnValidateAddressCancel { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_address_cancel")); } }

        public IWebElement BtnValidateAddressEdit { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_address_edit")); } }

        public IWebElement SuggestedAddressLine1 { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_suggested_line1_")); } }

        public IWebElement SuggestedAddressLine2 { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_suggested_line2_")); } }

        public IWebElement SuggestedAddressCityStateZip { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_suggested_line3_")); } }

        public IWebElement SuggestedAddressCountry { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_suggested_country_")); } }

        public IWebElement EnteredAddressLine1 { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_entered_line1")); } }

        public IWebElement SuggestedAddressEdit { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_addShippingAddress_edit")); } }

        public IWebElement SuggestedAddressSelect { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_addShippingAddress_select")); } }

        public IWebElement BtnCannotValidateAddressOK { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_addShippingAddress_ok")); } }

        public IWebElement BtnCannotValidateAddressCancel { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_addShippingAddress_cancel")); } }

        public IWebElement BtnSuggestShippingCancel { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_addShippingAddress_close")); } }

        public IWebElement ValidateAddressStreet { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_input_street")); } }

        public IWebElement ValidateAddressUnit { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_input_unit")); } }

        public IWebElement BillToAddrCompanyName { get { return WebDriver.GetElement(By.Id("customerDetails_billToAddress_companyName")); } }

        public IWebElement BillToAddrContactName { get { return WebDriver.GetElement(By.Id("customerDetails_billToAddress_contactName")); } }

        public IWebElement BillToAddrContactPhone { get { return WebDriver.GetElement(By.Id("customerDetails_billToAddress_contactPhone")); } }

        public IWebElement BillToAddrContactEmail { get { return WebDriver.GetElement(By.Id("customerDetails_billToAddress_contactEmail")); } }

        public IWebElement BillToAddrFax { get { return WebDriver.GetElement(By.Id("customerDetails_billToAddress_customerFax")); } }

        public IWebElement BillToAddrTitle { get { return WebDriver.GetElement(By.Id("customerDetails_billToAddress_title")); } }

        public IWebElement BillToAddrLine1 { get { return WebDriver.GetElement(By.Id("customerDetails_billToAddress_address1")); } }

        public IWebElement BillToAddrLine2 { get { return WebDriver.GetElement(By.Id("customerDetails_billToAddress_address2")); } }

        public IWebElement BillToAddrCity { get { return WebDriver.GetElement(By.Id("customerDetails_billToAddress_city")); } }

        public IWebElement BillToAddrState { get { return WebDriver.GetElement(By.Id("customerDetails_billToAddress_state")); } }

        public IWebElement BillToAddrZip { get { return WebDriver.GetElement(By.Id("customerDetails_billToAddress_zipCode")); } }

        public IWebElement BillToAddrCountry { get { return WebDriver.GetElement(By.Id("customerDetails_billToAddress_country")); } }

        public IWebElement BillToAddrDept { get { return WebDriver.GetElement(By.Id("customerDetails_billToAddress_department")); } }

        public IWebElement BillToAddrMailstop { get { return WebDriver.GetElement(By.Id("customerDetails_billToAddress_mailstop")); } }

        public IWebElement NoteId { get { return WebDriver.GetElement(By.Id("customerDetails_notesToggle")); } }

        public IWebElement CustomerDetailViewAllNotes { get { return WebDriver.GetElement(By.Id("customerDetails_NotesViewAll")); } }

        public IWebElement AddNoteId { get { return WebDriver.GetElement(By.Id("customerDetails_addNote")); } }

        public IWebElement AddNotes { get { return WebDriver.GetElement(By.CssSelector("#customerDetails_view > div:nth-child(8) > div.accordion-heading > div > span > a")); } }

        public IWebElement HdrAddNote { get { return WebDriver.GetElement(By.Id("customerDetails_addNote_heading")); } }

        public IWebElement NoteGrid { get { return WebDriver.GetElement(By.Id("notesList")); } }

        public IWebElement AllNotesGrid { get { return WebDriver.GetElement(By.Id("notesList")); } }

        // yes, it's a different grid but uses same id
        public IWebElement AllNotesCustomerName { get { return WebDriver.GetElement(By.Id("customerViewAllNotes_customerName")); } }

        public IWebElement AllNotesAccountName { get { return WebDriver.GetElement(By.Id("customerViewAllNotes_accountName")); } }

        public IWebElement QuoteId { get { return WebDriver.GetElement(By.Id("customerDetails_quoteListToggle")); } }

        public IWebElement QuoteGrid { get { return WebDriver.GetElement(By.Id("customerDetailsQuoteList")); } }

        public IWebElement QuoteListViewAll { get { return WebDriver.GetElement(By.Id("customerDetails_QuotesViewAll")); } }

        public IWebElement LblCreditDetails { get { return WebDriver.GetElement(By.Id("#customerDetails_creditDetails_header")); } }

        public IWebElement BtnAddCustomerDetails { get { return WebDriver.GetElement(By.Id("customerDetails_addToYourCustomers")); } }

        public IWebElement NoResultsMessage { get { return WebDriver.GetElement(By.Id("common_noResults_message")); } }

        public IWebElement LnkViewMoreAccounts { get { return WebDriver.GetElement(By.Id("_viewMore")); } }

        public IWebElement LnkEnableDellAdvantage { get { return WebDriver.GetElement(By.Id("_enableDellAdvantage")); } }

        public IWebElement BtnEnableDellAdvantagePopYes { get { return WebDriver.GetElement(By.Id("messageDialogButton_0")); } }

        public IWebElement BtnEnableDellAdvantagePopNo { get { return WebDriver.GetElement(By.Id("messageDialogButton_1")); } }

        public IWebElement BtnAddMyAccount { get { return WebDriver.GetElement(By.Id("customerDetails_addMyAccount")); } }

        public IWebElement CancelDialogBox { get { return WebDriver.GetElement(By.Id("_cancel")); } }

        public IWebElement MatchedMyAccountRecord { get { return WebDriver.GetElement(By.XPath("//div[@class='col-sm-12'][contains(.,'The info you entered matched an existing My Account record.')]")); } }

        public IWebElement ErrorMessageUnmatchedAccount { get { return WebDriver.GetElement(By.Id("_emailSearchErrorSection")); } }

        public IWebElement AddMyAccountPopUp { get { return WebDriver.GetElement(By.XPath("//*[@id='COM']/div[2]")); } }

        public IWebElement CheckBoxEmailOffers { get { return WebDriver.GetElement(By.Id("myaccount_include_offers")); } }

        public IWebElement CheckBoxEnableDellAdvantage { get { return WebDriver.GetElement(By.Id("myaccount_enable_dell_advantage")); } }

        public IWebElement EmailSearchTextbox { get { return WebDriver.GetElement(By.Id("search_email_input")); } }

        public IWebElement BtnEmailSearch { get { return WebDriver.GetElement(By.Id("search_email")); } }

        public IWebElement TxtAddNote { get { return WebDriver.GetElement(By.Id("_comments")); } }

        public IWebElement BtnAddNoteSave { get { return WebDriver.GetElement(By.Id("_save")); } }

        public IWebElement TxtAddAffinityId { get { return WebDriver.GetElement(By.Id("customerDetails_accountNumber")); } }

        public IWebElement TxtCompanyName { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_CustomerName")); } }

        public IWebElement TxtCustomerCompanyName { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_CustomerName")); } }

        public IWebElement CustomerNameTxt { get { return WebDriver.GetElement(By.TagName("h3")); } }

        public IWebElement CustomerBillingNameTxt { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_header']/span[1]")); } }

        public IWebElement QuoteListExpandBtn { get { return WebDriver.GetElement(By.XPath(@"//div[normalize-space()='Quote List']//a")); } }

        public IWebElement FundersExpandBtn { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_view']//div[contains(text(), 'Funders')]")); } }

        public IWebElement FundersViewAllLnk { get { return WebDriver.GetElement(By.XPath(@"//div[normalize-space()='Funders']//following::*[text()='View all']")); } }

        public IWebElement FinancialInformation { get { return WebDriver.GetElement(By.XPath("//div[normalize-space()='Financial Information']/span/a")); } }

        public IWebElement Financialinfo { get { return WebDriver.GetElement(By.XPath(@"//div[normalize-space()='Financial Information']//a")); } }

        public IWebElement CurrenyTextFinancialInfo { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_view']//customer-details-financial-information//label[contains(text(), 'Currency')]")); } }

        public IWebElement CreditRequestDetailsExpandBtn { get { return WebDriver.GetElement(By.XPath(@"//div[normalize-space()='Credit Request Details']//a")); } }

        public IWebElement ViewNotesBtn { get { return WebDriver.GetElement(By.XPath(@"//*[@id='DataTables_Table_creditRequestDetails']//following::a[text()='View Notes']")); } }

        public IWebElement Endusers { get { return WebDriver.GetElement(By.XPath(@"//div[normalize-space()='End Users']//a")); } }

        public IWebElement EndusersViewAllLnk { get { return WebDriver.GetElement(By.XPath(@"//div[normalize-space()='End Users']//following::*[text()='View all']")); } }

        public IList<IWebElement> OrdeListHasRows { get { return WebDriver.GetElements(By.XPath(@"//div[@id='DataTables_div_customerDetails_Orders_OrdersGrid']/table//tr")); } }

        public IWebElement BackToCustomerDetailsPageLnk { get { return WebDriver.GetElement(By.XPath("//a[@id='View_All_Relations_Navigation_customerDetailLink']")); } }

        public IWebElement ChannelPartners { get { return WebDriver.GetElement(By.XPath(@"//div[normalize-space()='Channel Partners']//a")); } }

        public IWebElement ChannelPartnersViewAllLnk { get { return WebDriver.GetElement(By.XPath(@"//div[normalize-space()='Channel Partners']//following::*[text()='View all']")); } }

        public IWebElement QuoteList { get { return WebDriver.GetElement(By.XPath(@"//div[normalize-space()='Quote List']//a")); } }

        public IWebElement ExpndOrderList { get { return WebDriver.GetElement(By.XPath(@"//div[normalize-space()='Order List']//a")); } }

        public IWebElement POField { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'PO')]")); } }

        public IWebElement SolutionList { get { return WebDriver.GetElement(By.XPath(@"//div[normalize-space()='Solution List']//a")); } }

        public IWebElement BtnSolutionListViewAll { get { return WebDriver.GetElement(By.Id("customerDetails_solutionListViewAll")); } }

        public IWebElement BtnSolutionId { get { return WebDriver.GetElement(By.XPath(@"//span[contains(text(),'Solution Id')]")); } }

        public IWebElement BtnSolutionName { get { return WebDriver.GetElement(By.XPath(@"//span[contains(text(),'Solution Name')]")); } }

        public IWebElement BtnListPrice { get { return WebDriver.GetElement(By.XPath(@"//span[contains(text(),'List Price')]")); } }

        public IWebElement BtnQuoteNumber { get { return WebDriver.GetElement(By.XPath(@"//span[contains(text(),'Quote Number')]")); } }

        public IWebElement BtnXPODStatus { get { return WebDriver.GetElement(By.XPath(@"//span[contains(text(),'XPOD Status')]")); } }

        public IWebElement EmailOverride { get { return WebDriver.GetElement(By.XPath(@"//*[@id='override']/input")); } }

        public IWebElement NoEmailOverride { get { return WebDriver.GetElement(By.XPath("//*[@id='override']/text()")); } }

        public IWebElement MyAccountCart { get { return WebDriver.GetElement(By.XPath(@"//div[normalize-space()='My Account Carts']//a")); } }

        public IWebElement PremierPages { get { return WebDriver.GetElement(By.XPath(@"//div[normalize-space()='Premier Pages']//a")); } }

        public IWebElement DBCCreditStatus { get { return WebDriver.GetElement(By.Id("customerDetails_dbcCreditStatus")); } }

        public IWebElement DBCLeaseStatus { get { return WebDriver.GetElement(By.Id("customerDetails_leaseCreditStatus")); } }

        public IWebElement ViewAllPremierPages { get { return WebDriver.GetElement(By.Id("customerDetails_Premier_Section_ViewAll")); } }

        public IWebElement FunderRemovalYesBtn { get { return WebDriver.GetElement(By.Id("_btn_ok")); } }

        public IWebElement Notes { get { return WebDriver.GetElement(By.XPath(@"//div[normalize-space()='Notes']//a")); } }

        public IWebElement ContinueBtn { get { return WebDriver.GetElement(By.XPath(@"//button[normalize-space()='Continue']")); } }

        public IWebElement TxtFinalPrice { get { return WebDriver.GetElement(By.Id("quoteCreate_summary_finalPrice")); } }

        public IWebElement ChangeSalesChannel { get { return WebDriver.GetElement(By.Id("customerDetails_changeSalesChannel")); } }

        public IWebElement ChangeSalesChannelYes { get { return WebDriver.GetElement(By.XPath("//*[text()='Yes']")); } }

        public IWebElement SalesChannel { get { return WebDriver.GetElement(By.Name("salesChannel")); } }

        public IWebElement SelectSalesChannelSubmit { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Submit')]")); } }

        public IWebElement ChangeSalesChannelOk { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Ok')]")); } }

        public IWebElement CustomerClass { get { return WebDriver.GetElement(By.XPath("//*[@name='customerClass']")); } }

        public IWebElement TxtCustomerClass { get { return WebDriver.GetElement(By.Id("customerDetails_customerClass")); } }

        public IWebElement CustomerCategoryTxt { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_CustomerCategory")); } }

        public IWebElement TxtCustomerCategory { get { return WebDriver.GetElement(By.Id("customerDetails_customerCategory")); } }

        public IWebElement TxtLastUpdated { get { return WebDriver.GetElement(By.Id("customerDetails_LastUpdated")); } }

        public IWebElement YesRequestHold { get { return WebDriver.GetElement(By.Id("requestHoldDialog_submit")); } }

        public IWebElement AddLocationContactFromLocationsAndContactsPage { get { return WebDriver.GetElement(By.CssSelector(".btn-default")); } }

        public IWebElement loadingSpinner { get { return WebDriver.GetElement(By.CssSelector("#main > div:nth-child(1) > span")); } }

        public IWebElement LblDfs { get { return WebDriver.GetElement(By.Id("_dfsMessage")); } }

        public IWebElement AddShippingAddressFirstName { get { return WebDriver.GetElement(By.Name("firstName")); } }

        public IWebElement AddShippingAddressLastName { get { return WebDriver.GetElement(By.Name("lastName")); } }

        public IWebElement AddShippingAddressEmail { get { return WebDriver.GetElement(By.Name("emailInvoice")); } }

        public IWebElement AddShippingAddressLine1 { get { return WebDriver.GetElement(By.Name("address1")); } }

        public IWebElement AddShippingAddressCity { get { return WebDriver.GetElement(By.Name("city")); } }

        public IWebElement AddShippingAddressState { get { return WebDriver.GetElement(By.Name("state")); } }

        public IWebElement AddShippingAddressZipCode { get { return WebDriver.GetElement(By.Name("zipCode")); } }

        public IWebElement AddShippingAddressPrimaryPhone { get { return WebDriver.GetElement(By.Name("phoneMobile")); } }

        public IWebElement AddShippingAddressSubmitBtn { get { return WebDriver.GetElement(By.Id("submit")); } }

        public IWebElement VerifiedAddressesRadioBtn { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_validateAddress_shippingAddress_validation_withSuggestion']/div[3]/div/div/input")); } }

        public IWebElement AddShippingAddressZipExtension { get { return WebDriver.GetElement(By.Name("zipCodePlus")); } }

        public IWebElement NotesExpandBtn { get { return WebDriver.GetElement(By.XPath(@"//div[normalize-space()='Notes']//a")); } }

        public IWebElement LnkCopyCustomer { get { return WebDriver.GetElement(By.Id("customerDetails_copyCustomer")); } }

        public IWebElement LocationsHeader { get { return WebDriver.GetElement(By.XPath("//div[@id='customerDetails_view']//div[@class='accordion-heading'])[1]")); } }

        public IWebElement customerAsSoldToBtn { get { return WebDriver.GetElement(By.Id("customerDetails_soldTo")); } }

        public IWebElement customerAsShipToBtn { get { return WebDriver.GetElement(By.Id("customerDetails_shippingGroup")); } }

        public IWebElement LocationsExpandBtn { get { return WebDriver.GetElement(By.XPath(@"//div[normalize-space()='Locations']//a")); } }

        public IWebElement ShippingAddress { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[2]/td[4]")); } }

        public IWebElement EditContactCopyBtn { get { return WebDriver.GetElement(By.Id("EditContactDialog_copy")); } }

        //Edit Contact Element Ids

        public IWebElement EditContactEmailInvoice { get { return WebDriver.GetElement(By.Id("EditContactDialog_contact_email")); } }

        public IWebElement EditContactSubmitBtn { get { return WebDriver.GetElement(By.Id("EditContactDialog_submit")); } }

        public IWebElement LocationsPrimaryBillingEditContactBtn { get { return WebDriver.GetElement(By.XPath("//*[text()='Primary Billing']/following::a[contains(text(),'Edit Contact')][1]")); } }

        public IWebElement EditContact { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Edit Contact')]")); } }

        public IWebElement ViewAllLocationsDeactivateLocationBtn { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']//a[contains(text(), 'Deactivate Location')]")); } }

        public IWebElement ViewAllLocationsActivateLocationBtn { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']//a[contains(text(), 'Activate Location')]")); } }

        public IWebElement ViewAllLocationsSetAsPrimaryBtn { get { return WebDriver.GetElement(By.XPath("//*[text()='Shipping']/following::a[contains(text(),'Set as')][1]")); } }

        public IWebElement CustomerAccountLnk { get { return WebDriver.GetElement(By.XPath("//*[@id='View_All_Locations_Navigation_customerDetailLink']/span")); } }

        public IWebElement AddFavorite { get { return WebDriver.GetElement(By.XPath("//*[@id='_confirm']/mat-dialog-content")); } }

        public IWebElement ExistingFavorite { get { return WebDriver.GetElement(By.XPath("//*[@id='_confirm']/mat-dialog-content/span/text()")); } }

        public IWebElement ViewAllLocationsDeactivateContinueBtn { get { return WebDriver.GetElement(By.Id("_btn_ok")); } }

        public IWebElement AddCreditRequest { get { return WebDriver.GetElement(By.XPath(@"//a[contains(text(),'Add Credit Request')]")); } }

        public IWebElement CustomerClassTxt { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_classComponent_customerClass")); } }

        public IWebElement ChangeCustomerClassLnk { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_classComponent_action_changeCustomerClass")); } }

        public IWebElement CustomerClassDropDown { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_classComponent_customerClass_selector")); } }

        public IWebElement SaveCustomerClassLnk { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_classComponent_action_updateCustomerClass")); } }

        public IWebElement ChangeShipGrpConfirmButton { get { return WebDriver.GetElement(By.Id("changeCustomer_confirm")); } }

        public IWebElement ChangeShipGrpCancelButton { get { return WebDriver.GetElement(By.Id("changeCustomer_cancel")); } }

        public IWebElement CustomerStatus { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_Status")); } }

        public IWebElement RequestHldWarnTitle { get { return WebDriver.GetElement(By.Id("customerWarn_title")); } }

        public IWebElement CustomerType { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_CustomerType")); } }

        public IWebElement FunderAcntWarnMsg { get { return WebDriver.GetElement(By.Id("customerDetails_warning_cannotCreateQuoteBecauseItIsFunderAccount")); } }

        public IWebElement BtnCreateSolution { get { return WebDriver.GetElement(By.Id("customerDetailsNavigation_quoteSolution")); } }

        public IWebElement QuoteListTab { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_view']//div[contains(text(), 'Quote List')]")); } }

        //Reporting Elements and MultiQuote Elements

        public IWebElement OrdersListTab { get { return WebDriver.GetElement(By.XPath(@".//*[@id='customerDetails_view']/div[8]/div/div")); } }

        public IWebElement OrderNewTab { get { return WebDriver.GetElement(By.XPath(@".//*[@id='customerDetails_Orders_TabBar']/li[3]")); } }

        public string OrderListResultGrid = @".//*[@id='DataTables_Table_customerDetails_Orders_OrdersGrid']/tbody/descendant::tr";

        public IWebElement FirstRowDPID_OrderList { get { return WebDriver.GetElement(By.XPath(@".//*[@id='DataTables_Table_customerDetails_Orders_OrdersGrid']/descendant::tr[2]/td[3]/a")); } }

        public IWebElement QuoteList_ViewAll { get { return WebDriver.GetElement(By.Id("customerDetails_QuotesViewAll")); } }

        public IList<IWebElement> QuoteList_AddButton { get { return WebDriver.GetElements(By.XPath(".//*[@id='DataTables_Table_0']/descendant::a[contains(text(),'Add')]")); } }

        public IWebElement MultiQuoteSendButton { get { return WebDriver.GetElement(By.XPath(".//*[@id='quoteSearchResults_mergeQuotes'][contains(text(),'Send')]")); } }

        public IList<IWebElement> QuoteList_AddedQuote_InHeader { get { return WebDriver.GetElements(By.XPath(@".//*[@id='main']/descendant::li[@class='list-group-item']")); } }

        public IList<IWebElement> AllAccordian { get { return WebDriver.GetElements(By.XPath(".//*[@id='customerDetails_view']/descendant::div[@class='accordion-toggle']")); } }

        public IList<IWebElement> QuoteListAllItemDesc { get { return WebDriver.GetElements(By.XPath(".//*[@id='DataTables_Table_quoteNumber']/tbody/descendant::tr//td[5]")); } }

        public IWebElement LnkDFSDetails { get { return WebDriver.GetElement(By.Id("declineScript")); } }

        public IWebElement QuoteListAddBtn { get { return WebDriver.GetElement(By.XPath("//a[@class='grid-btn'][contains(text(),'Add')]")); } }

        public IList<IWebElement> MultipleQuoteList { get { return WebDriver.GetElements(By.XPath(".//*[@id='main']//li[@ng-repeat='SendCFOQuote in SendCFOList']")); } }

        public IWebElement QuoteListLine { get { return WebDriver.GetElement(By.XPath("//ul[@class='list-inline']")); } }

        public IWebElement Quotelisttable { get { return WebDriver.GetElement(By.Id("DataTables_Table_3")); } }

        public IWebElement OrderdetailsDPIDLink { get { return WebDriver.GetElement(By.Id("customerDetails_Orders_OrdersGrid-0-")); } }

        public IWebElement OrderdetailsOrderNumberLink { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_Orders_OrdersGrid-0-']//following::a")); } }

        public IWebElement OrderdetailsOrderStatusLink { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_Orders_OrdersGrid-0-']//following::a//following::a")); } }

        public IWebElement ViewOrders30DaysLink { get { return WebDriver.GetElement(By.XPath("//a[@id = 'customerDetails_Orders_GoToViewAll' and text() = '30 days']")); } }

        public IWebElement ViewOrders120DaysLink { get { return WebDriver.GetElement(By.XPath("//a[@id = 'customerDetails_Orders_GoToViewAll' and text() = '120 days']")); } }

        public IList<IWebElement> customerQuoteListRows { get { return WebDriver.GetElements(By.XPath("//*[@id='DataTables_Table_quoteNumber']/tbody/descendant::tr")); } }

        public IWebElement DisplayItemsPerPage { get { return WebDriver.GetElement(By.XPath("//*[@id='locations_grid_paging_itemsPerPage;']")); } }

        public IWebElement GroupLvlChangeShipToCustomer { get { return WebDriver.GetElement(By.Id(@"customerDetails_shippingGroup")); } }

        public IWebElement OrderListAccordian { get { return WebDriver.GetElement(By.XPath("//div[@class = 'accordion-toggle' and contains(text(), 'Order List')]")); } }

        public IWebElement EditContactBillTo { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']//tr[2]//a[contains(text(),'Edit Contact')]")); } }

        public IWebElement PrimaryBillingExpansionButton { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[1]/td[1]/a")); } }

        public IWebElement CreateThisNewCustomer { get { return WebDriver.GetElement(By.Id("createCustomerDuplicateCustomersDialog_entered_save")); } }

        public IWebElement BtnUseInQuoteReseller { get { return WebDriver.GetElement(By.Id("customerDetails_reseller")); } }
        
        public IWebElement LnkRunCredit { get { return WebDriver.GetElement(By.Id("RunCredit")); } }
        public IWebElement ViewDfSlinikforDpaCustomer { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='View DFS Details']")); } }
       
        public IWebElement expandBillingOrShippingAddress(int? index)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[" + index + "]/td[1]/a"));
        }

        public IWebElement getPhoneAreaCode(int? addressIndex, int? index)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']//tbody//tr[" + addressIndex + "]//td//div[3]//div[" + index + "]//div"));
        }

        public bool ElementisDisplayed(IWebElement el)
        {
            try
            {
                return el.Displayed;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
        }

        public IWebElement TitleDropdown { get { return WebDriver.GetElement(By.Id("AddLocationDialog_contact_title")); } }

        public string[] getTitles()
        {
            SelectElement el = new SelectElement(TitleDropdown);
            string[] actualTitles = new string[el.Options.Count - 1];
            for (int i = 1; i <= actualTitles.Length; i++)
            {
                actualTitles[i - 1] = el.Options.ElementAt(i).Text.Trim();
            }
            return actualTitles;
        }

        public string GetAddressTypeValue(IWebDriver driver,int index)
        {
            return driver.FindElement(By.XPath(".//table[@id='DataTables_Table_locations']/tbody/tr[" + index + "]/td[10]")).Text.Trim();
        }

        public int GetCountofElements(IWebDriver driver)
        {
            int count = driver.FindElements(By.XPath("//*[@id='credit-details-container']/div/div[@class='data-group']")).Count();
            return count;
        }

        public IWebElement UndeliveredReasonValue { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_locations > tbody > tr:nth-child(2) > td > add-component > customer-details-locations-expand-view > div > div > div > div > div:nth-child(4) > div:nth-child(4) > div")); } }

        public IWebElement DellFinancing { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_creditDetails_header']")); } }

        public IWebElement CreditLimitDF { get { return WebDriver.GetElement(By.XPath("//*[@id='credit-details-container']/div/div[1]/label")); } }

        public IWebElement RemainingBalanceDF { get { return WebDriver.GetElement(By.XPath("//*[@id='credit-details-container']/div/div[2]/label")); } }

        public void CustomerAddMyAccount()

        {
            MyAccountCart.Click();
            BtnAddMyAccount.Click();
            AddMyAccountPopUp.Displayed.Should().BeTrue();
        }


        public void ExpandCreditRequest()
        {
            FinancialInfoId.IsElementClickable(WebDriver).Should().BeTrue();
            FinancialInfoId.Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            CreditRequestDetailsExpandBtn.IsElementDisplayed(WebDriver).Should().BeTrue();
            CreditRequestDetailsExpandBtn.Click(WebDriver);
        }

        public int GetCreditRequestCount()
        {
            return CreditRequestDate.Count;
        }


        public void VerifyCreditRequestDate(string condition)
        {
            foreach (var el in CreditRequestDate)
            {
                TimeSpan span = DateTime.Parse(el.Text.Trim()) - DateTime.Now;
                if (condition.Equals("<"))
                {
                    (span.Days < 90).Should().BeTrue();
                }

                if (condition.Equals(">"))
                {
                    (span.Days > 90).Should().BeTrue();
                }

                if (condition.Equals(">="))
                {
                    (span.Days >= 90).Should().BeTrue();
                }

                if (condition.Equals("<="))
                {
                    (span.Days <= 90).Should().BeTrue();
                }

                if (condition.Equals("="))
                {
                    (span.Days == 90).Should().BeTrue();
                }
            }
        }


        #region PIR Elements

        public IWebElement InvoiceProfileNotFoundError { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-error ng-star-inserted']")); } }

        public IWebElement InvoiceCopies { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Invoice Copies')]")); } }

        public IWebElement CreditNoteCopies { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Credit Note Copies')]")); } }

        public IWebElement DebitNoteCopies { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Debit Note Copies')]")); } }

        public IWebElement ConsolidationMethod { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Consolidation Method')]")); } }

        public IWebElement CustomInvoice { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Custom Invoicing')]")); } }

        public IWebElement SpecialHandling { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Special Handling')]")); } }

        public IWebElement eVoicingEnabled { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'eInvoicing Enabled')]")); } }

        public IWebElement CustomerIdentifier { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Customer Identifier')]")); } }

        public IWebElement TransactionType { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Transaction Type')]")); } }

        public IWebElement TrackerCustomerNumberLbl { get { return WebDriver.GetElement(By.XPath("//label[contains(text(), 'Tracker Customer Number')]")); } }

        public IWebElement ParentTCNLbl { get { return WebDriver.GetElement(By.XPath("//label[contains(text(), 'Parent')])[1]")); } }

        public IWebElement ParentDCNLbl { get { return WebDriver.GetElement(By.XPath("//label[contains(text(), 'Parent')])[2]")); } }

        public IWebElement ELCDefaultLbl { get { return WebDriver.GetElement(By.XPath("//label[contains(text(), 'Default')]")); } }

        public IWebElement Frequence { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Frequence')]")); } }

        public IWebElement EDIFormat { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'EDI Format')]")); } }

        public IWebElement StartDate { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Start Date')]")); } }

        public IWebElement EndDate { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'End Date')]")); } }

        public IWebElement IntermediaryIdentifier { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Intermediary Identifier')]")); } }

        public IWebElement TransactionNature { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Transaction Nature')]")); } }

        public IWebElement FrequencyDetail { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Frequency Detail')]")); } }

        public IWebElement ViewInvoiceProfileButton { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']//tr//a[contains(text(),'View Invoice Profile')]")); } }

        public IWebElement CustomerConsentNotifications { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'When collecting or updating a customer')]")); } }

        public IWebElement PMCUpdateNotifications { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Any update to PMC will take up to 24/48 hours to reflect in DSA.')]")); } }

        public IWebElement CustomerConsentScriptLink { get { return WebDriver.GetElement(By.XPath("//div[contains(text(), 'Read Privacy Notice Script')]")); } }

        public IWebElement CustomerConsentScriptText { get { return WebDriver.GetElement(By.XPath("//p[contains(text(),'To learn how Dell uses your data and how to set ma')]")); } }


        public IWebElement GetCustomerConsentScript(int? ConsentIndex)
        {
            return WebDriver.FindElement(By.XPath("//marketing-preference//div//p[" + ConsentIndex + "]"));
        }

        public void VerifyCustomerConsentScript(DataRow row)
        {
            CustomerConsentScriptLink.Displayed.Should().BeTrue();
            CustomerConsentScriptLink.Click(WebDriver);
            CustomerConsentScriptText.GetText(WebDriver).Should().BeEquivalentTo(row["CustomerConsentScript"].ToString());
            Close.Click();
        }

        public void EditContactInfoPMC(String mobileNumber, String workNumber, String emailAddress)
        {
            MobileNumber.Clear();
            MobileNumber.SetText(WebDriver, mobileNumber);
            EditContactSubmitBtn.Enabled.Should().BeFalse();

            WorkNumber.Clear();
            WorkNumber.SetText(WebDriver, workNumber);
            EditContactSubmitBtn.Enabled.Should().BeFalse();

            EditContactEmailInvoice.Clear();
            EditContactEmailInvoice.SetText(WebDriver, emailAddress);
            EditContactSubmitBtn.Enabled.Should().BeFalse();

            Close.Click();
        }

        public void EditContactEmail(String emailAddress)
        {
            EditContactEmailInvoice.Clear();
            EditContactEmailInvoice.SetText(WebDriver, emailAddress);
        }

        public void EditContactMobile(String mobileNumber)
        {
            MobileNumber.Clear();
            MobileNumber.SetText(WebDriver, mobileNumber);
        }

        public void EditContactWork(String phoneNumber)
        {
            WorkNumber.Clear();
            WorkNumber.SetText(WebDriver, phoneNumber);
        }

        public IWebElement EditContactOptIn(string PMCField)
        {
            return WebDriver.FindElement(By.Id("EditContactDialog_Marketing_Preference_OptIn_" + PMCField + ""));
        }

        public IWebElement EditContactOptOut(string PMCField)
        {
            return WebDriver.FindElement(By.Id("EditContactDialog_Marketing_Preference_OptOut_" + PMCField + ""));
        }

        public IWebElement AddLocationOptIn(string PMCField)
        {
            return WebDriver.FindElement(By.Id("Marketing_Preference_OptIn_" + PMCField + ""));
        }

        public void delay(int timeOutInSeconds)
        {
            System.Threading.Thread.Sleep(timeOutInSeconds * 1000);
        }

        public IWebElement AddLocationOptOut(string PMCField)
        {
            return WebDriver.FindElement(By.Id("Marketing_Preference_OptOut_" + PMCField + ""));
        }

        public IWebElement getTextForTypeOfRequest(string creditId) {
            return WebDriver.FindElement(By.XPath(".//td[text()='" + creditId + "']/following-sibling::td"));
        }

        public IList<IWebElement> CustomerAccountEmailAddress { get { return WebDriver.GetElements(By.CssSelector("customer-details-my-account div.data-group span:first-of-type")); } }

        public bool VerifyEmailAddressDoesNotExistInMyAccount(string emailaddress)
        {
            foreach (var email in CustomerAccountEmailAddress)
            {

                if (email.Text.Trim().Equals(emailaddress))
                    return false;
            }
            return true;
        }

        public IWebElement ExpandCustomerConsentScript { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Read Privacy Notice Script')]")); } }

        public IWebElement CustomerConsentScript { get { return WebDriver.GetElement(By.XPath("//div[@class='col-md-6']//div[@class='col-md-12']")); } }

        public IWebElement EditCustomerConsentScript { get { return WebDriver.GetElement(By.XPath("//div[@class='col-md-12']//div[@class='col-md-12']")); } }

        public IWebElement LangEnglish { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'English')]")); } }

        public IWebElement LangFrench { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'French')]")); } }

        public IWebElement CloseEdit { get { return WebDriver.GetElement(By.XPath("//button[@name='close']")); } }

        public IWebElement AddNewAddPopUp { get { return WebDriver.GetElement(By.XPath("//div[@id='cdk-overlay-2']")); } }


        #endregion

        #region Canada Elements

        public IWebElement PostalCodeTxt_AddNewAddress { get { return WebDriver.GetElement(By.XPath("//*[@id='mat-dialog-0']//customer-address//span[contains(text(), 'Postal Code')]")); } }

        public IWebElement PostalCodeTxt { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']//span[contains(text(), 'Postal Code')]")); } }

        public IWebElement ProvinceTxt { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']//span[contains(text(), 'Province')]")); } }

        public IWebElement PostalCodeTxt_AddNewContact { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_addressInfo']//span[contains(text(), 'Postal Code')]")); } }

        public IWebElement ProvinceTxt_AddNewContact { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_addressInfo']//span[contains(text(), 'Province')]")); } }

        public IWebElement Status_AddNewContact { get { return WebDriver.GetElement(By.XPath("//*[@id='mat-dialog-0']//add-new-contact//form//div//select-address-grid//div[2]//div//select")); } }

        public IWebElement Status_ViewAllLocations { get { return WebDriver.GetElement(By.XPath("//*[@id='View_All_Locations_Filter']//div[3]//select")); } }

        public IWebElement Addressline_TableLocations { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr/td[5]")); } }

        public IWebElement Email_TableLocations { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr/td[9]")); } }

        public IWebElement No_results_TableLocations { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr/td")); } }

        public IWebElement Criteria_ViewAllLocations { get { return WebDriver.GetElement(By.XPath("//*[@id='viewAllLocations_generalFilter']")); } }

        public IWebElement Filtervalue_ViewAllLocations { get { return WebDriver.GetElement(By.XPath("//*[@id='viewAllLocations_searchFilter_general_value']")); } }

        public IWebElement BtnApply { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Apply')]")); } }

        public IWebElement RelatedTab_ViewAllLocations { get { return WebDriver.GetElement(By.Id("View_All_Locations_Grid_tab_3")); } }

        public IWebElement SelectPaymentTerm { get { return WebDriver.GetElement(By.Id("creditRequest_termdays")); } }

        public IWebElement FavoriteTab_ViewAllLocations { get { return WebDriver.GetElement(By.Id("View_All_Locations_Grid_tab_1")); } }

        public IWebElement StandardTab_ViewAllLocations { get { return WebDriver.GetElement(By.Id("View_All_Locations_Grid_tab_2")); } }

        public IWebElement ExpandStandardTab_Firstlink { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[1]/td[1]/a")); } }

        public IWebElement MobileNum_CountryCode { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[2]/td/add-component/locations-grid-expand-view/div/div/div/div/div[3]/div[1]/div")); } }

        public IWebElement AddressSuggestionPopup { get { return WebDriver.GetElement(By.Id("AddressSuggestionsDialog")); } }

        public IWebElement AddressesTable { get { return WebDriver.GetElement(By.Id("DataTables_Table_locations")); } }

        public IWebElement QuoteListTable { get { return WebDriver.GetElement(By.Id("DataTables_Table_quoteNumber")); } }

        public IWebElement OrderListTable { get { return WebDriver.GetElement(By.Id("DataTables_Table_customerDetails_Orders_OrdersGrid")); } }

        public IWebElement SolutionListTable { get { return WebDriver.GetElement(By.Id("DataTables_Table_solutionNumber")); } }

        public IWebElement AddressTableAddNewContact { get { return WebDriver.GetElement(By.Id("DataTables_Table_addressInfo")); } }

        public IWebElement RowOneStandard { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[1]")); } }

        public IWebElement RowOneCompany { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[1]/td[2]")); } }

        public IWebElement RowOneName { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[1]/td[3]")); } }

        public IWebElement RowOneAddress { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[1]/td[5]")); } }

        public IWebElement RowOneEmail { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[1]/td[8]")); } }

        public IWebElement RowOneType { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']/tbody/tr[1]/td[10]")); } }

        public IWebElement ErrorMsg { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/customer-details-main/div/div")); } }

        public IWebElement CloseBtn { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Close')]")); } }

        public IWebElement LocationsBillingAddCreditRequestBtn { get { return WebDriver.GetElement(By.XPath("//*[text()='Billing']/following::a[contains(text(),'Add Credit Request')]")); } }

        public IWebElement CreditRequestDetailsUnderFinance { get { return WebDriver.GetElement(By.XPath("//small[contains(text(),'Credit Request Details')]")); } }

        public IWebElement MyAccountcarts { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'My Account Carts')]")); } }

        public IWebElement LastUpdated { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Last Updated')]")); } }

        public IWebElement CreditRequestId { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Credit Request ID')]")); } }

        public IWebElement TypeOfRequest { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Type of request')]")); } }

        public IWebElement CreditRequestInfo { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_creditRequestDetails']/tbody/tr[1]")); } }

        public IWebElement DBCAccountStatus { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'DBC Account Status')]")); } }

        public IWebElement DBCAvailcredit { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'DBC Available Credit')]")); } }

        public IWebElement LeaseCreditStatus { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Lease Credit Status')]")); } }

        public IWebElement LeaseAccountStatus { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Lease Account Status')]")); } }

        public IWebElement LeaseOffer { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Lease Offer')]")); } }

        public IWebElement GenaralInfo { get { return WebDriver.GetElement(By.Id("customerDetails_paymentInfo_header")); } }

        public IWebElement PaymentTerms { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Payment Terms:')]")); } }

        public IWebElement CurrencyCad { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Currency:')]")); } }

        public IWebElement FederalTaxId { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Federal Tax ID:')]")); } }

        public IWebElement DiscountEntitlements { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Discount Entitlements:')]")); } }

        public IWebElement DellCreditLimit { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Credit Limit:')]")); } }

        public IWebElement DellRemainingBalance { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Remaining Balance:')]")); } }

        public IWebElement WorkInPrograss { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Work In-Progress(hold):')]")); } }

        public IWebElement DellCreditStatus { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Credit Status:')]")); } }

        public IWebElement CreditHold { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Credit Hold:')]")); } }

        public IWebElement CreditRequestType { get { return WebDriver.GetElement(By.XPath("//select[@name='creditRequestType']")); } }

        public IWebElement LblDellFinance { get { return WebDriver.GetElement(By.Id("customerDetails_creditDetails_header")); } }

        public IWebElement LocationsPrimaryBillingAddCreditRequestBtn { get { return WebDriver.GetElement(By.XPath("//*[text()='Primary Billing']/following::a[contains(text(),'Add Credit Request')]")); } }

        public IWebElement MyAccountEmail { get { return WebDriver.GetElement(By.XPath("//input[@id='myaccount_email_address']")); } }

        public IWebElement AddAccountWarningMessage { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'The info you entered matched an existing My Accoun')]")); } }

        public IWebElement MyAccountFName { get { return WebDriver.GetElement(By.XPath("//input[@id='myaccount_first_name']")); } }

        public IWebElement MyAccountLName { get { return WebDriver.GetElement(By.Id("myaccount_last_name")); } }

        public IWebElement DellFinancialInfo { get { return WebDriver.GetElement(By.Id("financialServices_header")); } }

        public IWebElement LnkPersonSearch { get { return WebDriver.GetElement(By.Id("menu_personSearch")); } }

        public IWebElement linkAcntWarnMsg { get { return WebDriver.GetElement(By.Id("customerDetails_warning_cannotCreateQuoteBecauseItIsLinkAccount")); } }

        public IWebElement PersonAssigned { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Person Assigned')]")); } }

        public IWebElement StatusOfRequest { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Status Of Request')]")); } }

        public IWebElement ApprovalStatus { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Approval Status')]")); } }

        public IWebElement UCIDText { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'UCID')]")); } }

        public IWebElement updateCreditRequestPopUp { get { return WebDriver.GetElement(By.Id("UpdateCreditRequestDialog_updateCreditRequest")); } }

        public IWebElement CustomerDetailsHeader { get { return WebDriver.GetElement(By.CssSelector("#customerDetails_customerDetails .section-header .row >div>h3")); } }

        public IWebElement MyAccountEmailPatched { get { return WebDriver.GetElement(By.CssSelector("#customerDetails_view>div:nth-child(7) customer-details-my-account>div div.data-group>div>div#customerDetails_myAccount:nth-child(1) span:first-of-type")); } }

        public IWebElement DellAdvantageEnabled { get { return WebDriver.GetElement(By.CssSelector("#customerDetails_view>div:nth-child(7) customer-details-my-account>div div.data-group>div>div#customerDetails_myAccount:nth-child(1) span:last-of-type")); } }

        public IWebElement DfsGoodCreditStatus { get { return WebDriver.GetElement(By.Id("customerDetails_CreditStatus")); } }

        public IWebElement ViewNotesWindow { get { return WebDriver.GetElement(By.XPath(@"//div[@class='mat-dialog-content']")); } }

        public IWebElement ViewNotesPopUpClose { get { return WebDriver.GetElement(By.Id("CreditRequestNotesDialog_close")); } }

        public IWebElement UpdateCreditRequestPopUpClose { get { return WebDriver.GetElement(By.XPath("//button[@class='btn btn-blank icon-ui-close']")); } }

        public IWebElement BtnInformationRequest { get { return WebDriver.GetElement(By.CssSelector("#DataTables_div_creditRequestDetails>table tbody>tr.odd>td:nth-child(7) div>div:nth-child(1)>a:nth-child(1)")); } }

        public IWebElement BtnUpdateRequest { get { return WebDriver.GetElement(By.CssSelector("#DataTables_div_creditRequestDetails>table tbody>tr.odd>td:nth-child(7) div>div:nth-child(1)>a:nth-child(2)")); } }

        public IWebElement CreditRequestNotes { get { return WebDriver.GetElement(By.Id("UpdateCreditRequestDialog_comments")); } }

        public IWebElement UpdateCreditRequestSubmit { get { return WebDriver.GetElement(By.Id("UpdateCreditRequestDialog_submit")); } }

        public IWebElement RequestUpdateSuccessMessage { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-success ng-star-inserted']")); } }

        public IWebElement CreditRequestStatus { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_creditRequestDetails>tbody>tr:nth-child(1)>td:nth-child(5)")); } }

        public IList<IWebElement> CreditRequestDate { get { return WebDriver.GetElements(By.CssSelector("#DataTables_Table_creditRequestDetails tbody>tr>td:nth-child(1)")); } }

        public IWebElement UpdateCreditRequestCancel { get { return WebDriver.GetElement(By.Id("UpdateCreditRequestDialog_cancel")); } }

        public IWebElement BtnUploadFile { get { return WebDriver.GetElement(By.Id("fileUpload")); } }

        public IWebElement CheckboxReassigntoAnalyst { get { return WebDriver.GetElement(By.Id("isreassign")); } }

        public IWebElement UploadSuccessMessage { get { return WebDriver.GetElement(By.CssSelector("#Credit_Request_File_Upload~div div.alert")); } }

        public IWebElement BtnSubmit { get { return WebDriver.GetElement(By.CssSelector(".dialog-footer>button.btn-success")); } }


        #endregion

        #region PAM Elements

        public IWebElement CustomerPAMInfo { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_PartnerAccountMgmt")); } }


        #endregion


        public string GetCustomerPAMInfo()
        {
            return CustomerPAMInfo.GetText(WebDriver);
        }

        public CustomerDetailsPage verifyPIRFieldsareDisplayed()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            InvoiceCopies.Displayed.Should().BeTrue();
            CreditNoteCopies.Displayed.Should().BeTrue();
            DebitNoteCopies.Displayed.Should().BeTrue();
            ConsolidationMethod.Displayed.Should().BeTrue();
            CustomInvoice.Displayed.Should().BeTrue();
            SpecialHandling.Displayed.Should().BeTrue();
            eVoicingEnabled.Displayed.Should().BeTrue();
            CustomerIdentifier.Displayed.Should().BeTrue();
            TransactionType.Displayed.Should().BeTrue();
            Frequence.Displayed.Should().BeTrue();
            EDIFormat.Displayed.Should().BeTrue();
            StartDate.Displayed.Should().BeTrue();
            EndDate.Displayed.Should().BeTrue();
            IntermediaryIdentifier.Displayed.Should().BeTrue();
            TransactionNature.Displayed.Should().BeTrue();
            FrequencyDetail.Displayed.Should().BeTrue();
            return new CustomerDetailsPage(WebDriver);
        }

        public IWebElement customerQuoteListRowColoumn(int rowIndex = 1, int coloumnIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_quoteNumber']/tbody/descendant::tr)[" + rowIndex + "]//td[" + coloumnIndex + "]"));
        }

        #endregion

        /// summary>
        /// Gets the link number value.
        /// </summary>
        /// <value>
        /// The link number value.
        /// </value>
        public string LinkNumberValue
        {
            get
            {
                string val = LblLinkNumber.GetText(WebDriver);
                return val.Substring(0, val.IndexOf("\r", StringComparison.Ordinal));
            }
        }

        public void SelectStatusAddNewContact(IWebDriver WebDriver, String Status, IWebElement Element1, IWebElement Element2, IWebElement Element3)
        {
            if (Status.ToString() == "All" || Status.ToString() == "Active" || Status.ToString() == "Hold" || Status.ToString() == "Inactive" || Status.ToString() == "Suspend" || Status.ToString() == "DNBMatchHold")
            {
                Element1.PickDropdownByText(WebDriver, Status);
                BtnApply.Click();
                WebDriver.VerifyBusyOverlayNotDisplayed();
                Element2.IsElementDisplayed(WebDriver).Should().BeTrue();
                Element3.IsElementDisplayed(WebDriver).Should().BeTrue();
            }

        }

        public void SelectStatus(IWebDriver WebDriver, String Status, IWebElement Element1)
        {
            if (Status.ToString() == "All" || Status.ToString() == "Active" || Status.ToString() == "Hold" || Status.ToString() == "Inactive" || Status.ToString() == "Suspend" || Status.ToString() == "DNBMatchHold")
            {
                Element1.PickDropdownByText(WebDriver, Status);
                BtnApply.Click();
                WebDriver.VerifyBusyOverlayNotDisplayed();

            }

        }

        public void AddCreditRequestBtn(IWebDriver driver, DataRow row)
        {
            AddCreditRequest.Click(WebDriver);

            TypeOfCreditRequest.PickDropdownByText(WebDriver, "Other");
            CreditComment.SetText(driver, row["Comment"].ToString());
            SubmitBtn.Click(WebDriver);
            CloseBtn.Click(WebDriver);
        }


        public void ViewAllAddCreditRequest()
        {
            //ExpandLocationsSection();
            var allLocations = GetLocationsAndContactsTable();
            foreach (var location in allLocations)
            {
                if (location["Type"].ToString().Equals("Primary Billing"))
                {
                    LocationsPrimaryBillingAddCreditRequestBtn.Click(WebDriver);

                }
            }

        }

        public void ViewAddCreditRequest()
        {
            //ExpandLocationsSection();
            var allLocations = GetLocationsAndContactsTable();
            foreach (var location in allLocations)
            {
                if (location["Type"].ToString().Equals("Primary Billing"))
                {
                    LocationsPrimaryBillingAddCreditRequestBtn.IsElementDisplayed(WebDriver).Should().BeTrue();
                    LocationsPrimaryBillingAddCreditRequestBtn.GetText(WebDriver);


                }
                else if (location["Type"].ToString().Equals("Billing"))
                {
                    LocationsBillingAddCreditRequestBtn.IsElementDisplayed(WebDriver).Should().BeTrue();
                    LocationsBillingAddCreditRequestBtn.GetText(WebDriver);
                }

            }
        }

        public CustomerDetailsPage MoveToNewAddressLink() {

            WebDriver.ScrollToElement(By.XPath("//*[@id='customerDetails_addLocation']"));

            return new CustomerDetailsPage(WebDriver);
        }

        public void SelectCirterionAddNewContact(IWebDriver WebDriver, String Criteria, IWebElement Element1, IWebElement Element2)
        {
            if (Criteria.ToString() == "Select a criterion" || Criteria.ToString() == "Company Name" || Criteria.ToString() == "First Name"
                || Criteria.ToString() == "Last Name" || Criteria.ToString() == "Email" || Criteria.ToString() == "Address Line 1" || Criteria.ToString() == "Address Line 2" || Criteria.ToString() == "City"
                || Criteria.ToString() == "Province" || Criteria.ToString() == "Postal Code" || Criteria.ToString() == "Type" || Criteria.ToString() == "Address ID")
            {
                Element1.PickDropdownByText(WebDriver, Criteria);
            }
            if (Criteria.ToString() == "Company Name")
            {
                Element2.IsElementClickable(WebDriver).Should().BeTrue();
                Element2.SendKeys("English CAD");
            }
            else if (Criteria.ToString() == "First Name")
            {
                Element2.IsElementClickable(WebDriver).Should().BeTrue();
                Element2.SendKeys("SHUSH");
            }
            else if (Criteria.ToString() == "Last Name")
            {
                Element2.IsElementClickable(WebDriver).Should().BeTrue();
                Element2.SendKeys("Person");
            }
            else if (Criteria.ToString() == "Email")
            {
                Element2.IsElementClickable(WebDriver).Should().BeTrue();
                Element2.SendKeys("TESTABCE@DELL.COM");
            }
            else if (Criteria.ToString() == "Address Line 1")
            {
                Element2.IsElementClickable(WebDriver).Should().BeTrue();
                Element2.SendKeys("189");
            }
            else if (Criteria.ToString() == "Address Line 2")
            {
                Element2.IsElementClickable(WebDriver).Should().BeTrue();
                Element2.SendKeys("");
            }
            else if (Criteria.ToString() == "City")
            {
                Element2.IsElementClickable(WebDriver).Should().BeTrue();
                Element2.SendKeys("Ottawa");
            }
            else if (Criteria.ToString() == "Province")
            {
                Element2.IsElementClickable(WebDriver).Should().BeTrue();
                Element2.SendKeys("ON");
            }
            else if (Criteria.ToString() == "Postal Code")
            {
                Element2.IsElementClickable(WebDriver).Should().BeTrue();
                Element2.SendKeys("K1A 0G9");
            }
            else if (Criteria.ToString() == "Type")
            {
                Element2.IsElementClickable(WebDriver).Should().BeTrue();
                Element2.SendKeys("Primary Shipping");
            }
            else if (Criteria.ToString() == "Address ID")
            {
                Element2.IsElementClickable(WebDriver).Should().BeTrue();
                Element2.SendKeys("202156226116236212");
            }

            {
                BtnApply.Click();
                WebDriver.VerifyBusyOverlayNotDisplayed();

            }

        }

        /// <summary>
        /// Validates this instance by checking that the page header is displayed 
        /// </summary>
        /// <returns><c>true</c> if the page title is displayed and is the correct value, 
        /// <c>false</c> otherwise.</returns>
        public override bool Validate()
        {
            return WebDriver.VerifyBusyOverlayNotDisplayed() && HdrCustomerDetail.Displayed;
        }

        /// <summary>
        /// Determines whether customer details page has really loaded.
        /// </summary>
        /// <returns></returns>
        public void WaitForCustomerDetailsPageToLoad()
        {
            int numOfRetries = 10;
            //WebDriver.WaitForBusyOverlay();

            //A.N. - Changing the code below as this only takes customer details as a valid result.
            //It is still valid to get no results (deactive customer).
            //  while (WebDriver.TryFindElement(NoResultsMessage, TimeSpan.FromSeconds(15)))
            //  {
            //      WebDriver.Navigate().Refresh();
            //      numOfRetries -= 1;
            //      if (numOfRetries <= 0) break;
            //  }

            while (!WebDriver.TryFindElement(CustomerInformationId, TimeSpan.FromSeconds(15)))
            {
                if (WebDriver.TryFindElement(NoResultsMessage, TimeSpan.FromSeconds(15)))
                {
                    break;
                }
                //WebDriver.Navigate().Refresh();
                numOfRetries -= 1;
                if (numOfRetries <= 0) break;
            }
        }

        public void WaitForDashboardIconLoad()
        {
            WaitForCustomerDetailsPageToLoad();
            while (!WebDriver.ElementExists(By.Id("customerDetails_dashboard")))
            {
                //Do Nothing 
            }
        }

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

        /// <summary>
        /// Determines whether this instance is active.
        /// </summary>
        /// <returns><c>true</c> if this instance is active; otherwise, <c>false</c>.</returns>
        public override bool IsActive()
        {
            return (WebDriver.Url.Contains("#/customer/details/Id/"));
        }

        /// <summary>
        /// Uses the customer in quote as end user.
        /// </summary>
        /// <returns></returns>
        public QuotePage UseInQuoteAsEndUser()
        {
            BtnUseInQuoteAsEndUser.Click(WebDriver);
            return new QuotePage(WebDriver);
        }

        /// <summary>
        /// Get the number of rows from end users table on customer details page.
        /// </summary>
        /// <returns></returns>
        public int EndUsersTableRowCount()
        {
            int numOfOddRows = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_EnduserCustomersGrid']//tr[@class='odd']")).Count;
            int numOfEvenRows = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_EnduserCustomersGrid']//tr[@class='even']")).Count;
            int numOfRows = numOfOddRows + numOfEvenRows;
            return numOfRows;
        }

        /// <summary>
        /// Get the number of rows from end users view all table.
        /// </summary>
        /// <returns></returns>
        public int EndUsersViewAllTableRowCount()
        {
            int numOfOddRows = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_0']//tr[@class='odd']")).Count;
            int numOfEvenRows = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_0']//tr[@class='even']")).Count;
            int numOfRows = numOfOddRows + numOfEvenRows;
            return numOfRows;
        }

        /// <summary>
        /// Get the number of rows from channel partners table on customer details page.
        /// </summary>
        /// <returns></returns>
        public int ChannelPartnersTableRowCount()
        {
            int numOfOddRows = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_PartnerCustomersGrid']//tr[@class='odd']")).Count;
            int numOfEvenRows = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_PartnerCustomersGrid']//tr[@class='even']")).Count;
            int numOfRows = numOfOddRows + numOfEvenRows;
            return numOfRows;
        }

        /// <summary>
        /// Get the number of rows from channel partners view all table.
        /// </summary>
        /// <returns></returns>
        public int ChannelPartnersViewAllTableRowCount()
        {
            int numOfOddRows = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_1']//tr[@class='odd']")).Count;
            int numOfEvenRows = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_1']//tr[@class='even']")).Count;
            int numOfRows = numOfOddRows + numOfEvenRows;
            return numOfRows;
        }

        /// <summary>
        /// Get the number of rows in Funder table on customer details page.
        /// </summary>
        /// <returns></returns>
        public int GetFunderTableRowCount()
        {
            int numOfOddRows = WebDriver.FindElements(By.XPath("//table[@id='DataTables_Table_FunderCustomersGrid']//tr[@class='odd']")).Count;
            int numOfEvenRows = WebDriver.FindElements(By.XPath("//table[@id='DataTables_Table_FunderCustomersGrid']//tr[@class='even']")).Count;
            int numOfRows = numOfOddRows + numOfEvenRows;
            return numOfRows;
        }

        /// <summary>
        /// Get the number of rows from funders view all table.
        /// </summary>
        /// <returns></returns>
        public int FundersViewAllTableRowCount()
        {
            int numOfOddRows = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_2']//tr[@class='odd']")).Count;
            int numOfEvenRows = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_2']//tr[@class='even']")).Count;
            int numOfRows = numOfOddRows + numOfEvenRows;
            return numOfRows;
        }

        /// <summary>
        /// Get the number of rows in Location & Contacts table.
        /// </summary>
        /// <returns></returns>
        public int GetLocationContactTableRowCount()
        {
            int numOfOddRows = WebDriver.FindElements(By.XPath("//*[@id='Customer_AddressesAddressGrid_Grid']//tr[@class='odd']")).Count;
            int numOfEvenRows = WebDriver.FindElements(By.XPath("//*[@id='Customer_AddressesAddressGrid_Grid']//tr[@class='even']")).Count;
            int numOfRows = numOfOddRows + numOfEvenRows;
            return numOfRows;
        }

        /// <summary>
        /// use cust to create quote.
        /// </summary>
        /// <returns></returns>
        public CreateQuotePage UseInQuoteClk()
        {
            BtnCreateQuote.Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        }

        public CreateQuotePage CreateQuote()
        {
            BtnCreateQuote.Click(WebDriver);
            if (WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_companyNumbers']//a[text()='Select'][1]"), TimeSpan.FromSeconds(5)) != null)
            {
                //WebDriver.GetElement(By.XPath("//*[@id='customerSetSelect_Grid']//a[text()='Select'][1]")).Click(WebDriver);
                WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_companyNumbers']//a[text()='Select'][1]")).Click(WebDriver);
            }
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.WaitForElementDisplay(new CreateQuotePage(WebDriver).TxtQuoteName);
            return new CreateQuotePage(WebDriver);
        }


        /// <summary>
        /// Gets the customer detail information div.
        /// </summary>
        /// <value>
        /// The customer detail information div.
        /// </value>
        public string CustomerDetailInfoDiv
        {
            get { return CustomerInformationId.GetText(WebDriver).Replace(@"\r", string.Empty).Replace(@"\n", string.Empty); }
        }

        ///// <summary>
        /////  true if dashboard menu is displayed
        ///// </summary>
        ///// <returns></returns>
        //public bool HasDashboardDDMenu()
        //{
        //    return LstDashboardMenu.Displayed;
        //}

        /// <summary>
        /// Click event of dashboard icon and verify the drop down menu
        /// </summary>
        /// <returns></returns>
        public bool ClickLnkDashboardIcon()
        {
            LnkDashboardIcon_Dropdown.Click(WebDriver);

            if (LstDashboardMenu.IsElementDisplayed(WebDriver))
            {
                return WebDriver.ElementExists(LnkViewForCustomer) && WebDriver.ElementExists(LnkViewForAccount);
            }
            else return false;
        }

        public CreateQuotePage ChangeCustomerUseInQuote()
        {
            LnkUseInQuote.Click();
            ViewAllLocationsDeactivateContinueBtn.Click();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return new CreateQuotePage(WebDriver);
        }

        /// <summary>
        /// Click event of View for Customer option under dashboard menu
        /// </summary>
        public CustomerDashboardPage ClickLinkViewForCustomer()
        {
            LinkViewForCustomer.Click(WebDriver);
            return new CustomerDashboardPage(WebDriver);
        }

        /// <summary>
        /// Click event of View for Account option under dashboard menu
        /// </summary>
        public CustomerDashboardPage ClickLinkViewForAccount()
        {
            LinkViewForAccount.Click(WebDriver);
            return new CustomerDashboardPage(WebDriver);
        }

        /// <summary>
        /// true if it went to No Results error page
        /// </summary>
        /// <returns></returns>
        public bool HasNoResultsMsg()
        {
            return NoResultsMessage.Displayed;
        }

        /// <summary>
        /// Refreshes the page if error page is displayed.
        /// </summary>
        public void RefreshPageIfErrorPageIsDisplayed()
        {
            // If there is an error page immediately after the customer is saved, then wait for 5 seconds and refreash the page again.
            // This is due to intermittent issues during create customer process. CMDM team has confirmed that this cannot be resolved.
            if (HasNoResultsMsg())
            {
                WebDriver.Navigate().Refresh();
            }
        }

        /// <summary>
        /// Uses the customer in quote as end user.
        /// </summary>
        /// <returns></returns>
        public void MoreActionClk()
        {
            MoreActions.Click(WebDriver);

        }

        public void ViewMoreMyAccounts()
        {
            var viewMore = LnkViewMoreAccounts.GetElements(WebDriver, By.CssSelector("tbody > tr > td")).FirstOrDefault(a => a.Text.Contains("View more"));
            if (viewMore != null)
                viewMore.Click(WebDriver);
        }

        public void ViewLessMyAccounts()
        {
            var viewLess = LnkViewMoreAccounts.GetElements(WebDriver, By.CssSelector("tbody > tr > td")).FirstOrDefault(a => a.Text.Contains("View less"));
            if (viewLess != null)
                viewLess.Click(WebDriver);
        }


        /// <summary>
        /// MyAccount email ids on customer details page.
        /// </summary>
        /// <returns></returns>
        public List<string> MyAccountEmails()
        {
            var emails = CustomerDetailsMyAccountEmails.GetElements(WebDriver, By.CssSelector("tbody > tr > td"))
                    .Where(a => !string.IsNullOrEmpty(a.Text))
                    .Select(a => a.Text.Substring(0, a.Text.IndexOf("\r", StringComparison.Ordinal)))
                    .ToList();

            if (emails.Count > 3)
            {
                ViewMoreMyAccounts();
            }

            return CustomerDetailsMyAccountEmails.GetElements(WebDriver, By.CssSelector("tbody > tr > td"))
                    .Where(a => !string.IsNullOrEmpty(a.Text))
                    .Select(a => a.Text.Substring(0, a.Text.IndexOf("\r", StringComparison.Ordinal)))
                    .ToList();
        }

        /// <summary>
        /// My account email with dell advantage status.
        /// </summary>
        /// <returns></returns>
        public List<string> MyAccountEmailWithDellAdvantageStatus()
        {
            var emails = CustomerDetailsMyAccountEmails.GetElements(WebDriver, By.CssSelector("tbody > tr > td"))
                    .Where(a => !string.IsNullOrEmpty(a.Text))
                    .Select(a => a.Text.Substring(0, a.Text.IndexOf("\r", StringComparison.Ordinal)))
                    .ToList();

            if (emails.Count > 3)
            {
                ViewMoreMyAccounts();
            }

            return CustomerDetailsMyAccountEmails.GetElements(WebDriver, By.CssSelector("tbody > tr > td"))
                .Where(a => !string.IsNullOrEmpty(a.Text))
                .Select(a => a.Text.Replace("\r", string.Empty).Replace("\n", "|"))
                .ToList();
        }

        /// <summary>
        /// Enables the dell advantage.
        /// </summary>
        /// <param name="myAccountEmail">My account email.</param>
        /// <param name="clickFinalYes">if set to <c>true</c> [click final yes].</param>
        public void EnableDellAdvantage(string myAccountEmail, bool clickFinalYes = true)
        {
            var emails = CustomerDetailsMyAccountEmails.GetElements(WebDriver, By.CssSelector("tbody > tr > td"))
                    .Where(a => !string.IsNullOrEmpty(a.Text))
                    .Select(a => a.Text.Substring(0, a.Text.IndexOf("\r", StringComparison.Ordinal)))
                    .ToList();

            if (emails.Count > 3)
            {
                ViewMoreMyAccounts();
            }

            var myAccountDivs = CustomerDetailsMyAccountEmails.GetElements(WebDriver, By.CssSelector("tbody > tr > td"))
                    .Where(a => !string.IsNullOrEmpty(a.Text))
                    .ToList();

            var myAcc = myAccountDivs.FirstOrDefault(a => a.Text.StartsWith(myAccountEmail));
            if (myAcc != null)
                LnkEnableDellAdvantage.Click(WebDriver);

            if (clickFinalYes)
                BtnEnableDellAdvantagePopYes.Click(WebDriver);
        }


        public void CancelEnableDellAdvantage()
        {
            BtnEnableDellAdvantagePopNo.Click(WebDriver);
        }

        public bool IsEnableDellAdvantagePopupOpened()
        {
            var popup = WebDriver.GetElement(By.ClassName("modal-small"));
            return popup.Displayed && popup.Text.Contains("Are you sure you want to Enable Dell Advantage");
        }

        //TODO:: _customerDetailsAddMyAccountLink Id needs some modifications to be done
        ///// <summary>
        ///// Adds my account.
        ///// </summary>
        ///// <returns></returns>
        //public AddMyAccountPopup AddMyAccount()
        //{
        //    WebDriverByLblSummaryTotalTax_customerDetailsAddMyAccountLink);
        //    return new AddMyAccountPopup(this, MyAccountPopupDiv);
        //}

        /// <summary>
        /// Click on 
        /// </summary>
        /// <returns></returns>
        public void ViewAccountBtnClk()
        {
            ViewAccountId.Click(WebDriver);

        }
        public void ClickAddMyAccountLink()
        {
            BtnAddMyAccount.Click(WebDriver);
        }
        /// <summary>
        /// Uses the customer in quote as end user.
        /// </summary>
        /// <returns></returns>
        public void FinancialInforTglClk()
        {
            FinancialInfoId.Click(WebDriver);

        }

        public void WaitForBusyIndicatorAppearAndDisappear()
        {
            WebDriver.WaitForElementVisible(By.XPath("//*[@id='busy-indicator']"), TimeSpan.FromSeconds(25));
            var wait = new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime);
            wait.Until<bool>(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='busy-indicator']")));
        }

        /// <summary>
        /// Header test
        /// </summary>
        /// <returns>text of page header</returns>
        public string DetailsHeader()
        {
            return HdrCustomerDetail.GetText(WebDriver);
        }

        /// <summary>
        /// Payment Terms
        /// </summary>
        /// <returns>text of payment terms</returns>
        public string DetailsPaymentTerms()
        {
            return DfsCustomerPaymentTerms.GetText(WebDriver);
        }

        /// <summary>
        /// Currency
        /// </summary>
        /// <returns>currency text</returns>
        public string DetailsCurrency()
        {
            return DfsCustomerCurrency.GetText(WebDriver);
        }

        public string GetLang()
        {
            return PreferredLang.GetText(WebDriver);
        }
        /// <summary>
        /// Gets the credit details under financial information.
        /// </summary>
        /// <value>
        /// The credit details under financial information.
        /// </value>
        public string CreditDetailsUnderFinancialInformation
        {
            get { return CreditDetails.GetText(WebDriver); }
        }


        /// <summary>
        /// Gets the remaining balance.
        /// </summary>
        /// <value>
        /// The remaining balance.
        /// </value>
        public string RemainingBalance
        {
            get { return RemainingBalanceLable.GetText(WebDriver); }
        }

        public object CustCreateCurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>list of shipping addresses</returns>
        public List<Dictionary<string, object>> GetShipToAddressList()
        {
            // WebDriver.WaitForElementVisible(By.Id(CustomerIDs.ShipToAddressAllGrid), TimeSpan.FromSeconds(30));

            return ShipToAddressAllGrid.GetHtmlTableData(WebDriver);
        }

        /// <summary>
        /// expand accordion, expand sub row
        /// </summary>
        /// <returns>sub row contents</returns>
        public string GetExpandedShippingAddressRow()
        {
            //expand sub row
            ShipToAddressAllGrid.FindElement(By.CssSelector("a.k-icon.expandRow"));
            //return sub row contents
            return WebDriver.FindElement(By.ClassName("detail-cell")).Text;
        }


        /// <summary>
        /// Opens the add shipping address popup.
        /// </summary>
        /// <returns></returns>
        public AddShippingAddressPopup OpenAddShippingAddressPopup()
        {
            LnkAddShipToAddress.Click(WebDriver);
            return new AddShippingAddressPopup(this, DivAddShipping);
        }

        /// <summary>
        /// expand accordion
        /// </summary>
        /// <returns>financial info contents</returns>
        public string GetFinancialInformation()
        {
            HdrDfsCustomerFinancialInfo.WaitForElement(WebDriver);
            return HdrDfsCustomerFinancialInfo.FindElement(By.XPath("..")).FindElement(By.XPath("..")).Text;
        }

        /// <summary>
        /// expand accordion
        /// </summary>
        /// <returns>list of associated quotes</returns>
        public List<Dictionary<string, object>> GetQuoteList()
        {
            QuoteGrid.WaitForElement(WebDriver);
            return QuoteGrid.GetHtmlTableData(WebDriver);
        }

        /// <summary>
        /// expand accordion, expand sub row
        /// </summary>
        /// <returns>contents of sub row</returns>
        public string GetExpandedQuoteListRow()
        {
            //expand accordion & sub row
            QuoteGrid.FindElement(By.ClassName("expandRow")).Click(WebDriver);
            //return sub row contents
            return WebDriver.GetElement(By.ClassName("detail-cell")).GetText(WebDriver);
        }

        /// <summary>
        /// expand accordion 
        /// </summary>
        public void ShowOrders()
        {
            OrderGrid.Click(WebDriver);
        }

        /// <summary>
        /// expand accordion and get grid
        /// </summary>
        /// <returns>list of associated orders</returns>
        public List<Dictionary<string, object>> GetOrderList()
        {
            ShowOrders();
            return OrderGrid.GetHtmlTableData(WebDriver);
        }

        /// <summary>
        /// expand accordion, expand sub row
        /// </summary>
        /// <returns>contents of sub row</returns>
        public string GetExpandedOrderListRow()
        {
            //expand accordion & sub row
            OrderGrid.FindElement(By.ClassName("expandRow")).Click(WebDriver);
            //return sub row contents
            return WebDriver.GetElement(By.ClassName("detail-cell")).GetText(WebDriver);
        }

        /// <summary>
        /// display and return Notes
        /// </summary>
        /// <returns>list of notes</returns>
        public List<Dictionary<string, object>> GetNoteList()
        {
            ShowNotes();
            return NoteGrid.GetHtmlTableData(WebDriver);
        }

        /// <summary>
        /// expand Notes accordion
        /// </summary>
        public void ShowNotes()
        {
            NoteGrid.WaitForElement(WebDriver);
        }

        /// <summary>
        /// Add a note with the given content and save it
        /// </summary>
        /// <param name="customerNote"></param>
        public void AddNote(string customerNote)
        {
            AddNoteId.Click(WebDriver);
            HdrAddNote.Click(WebDriver);
            TxtAddNote.SetText(WebDriver, customerNote);
            BtnAddNoteSave.Click(WebDriver);
        }

        public void AddToggleClick()
        {
            AddNoteId.Click(WebDriver);
        }

        public void AddNotesClick()
        {
            HdrAddNote.Click(WebDriver);
        }

        //public void AddNotes(string customerNote)
        //{
        //    TxtAddNote.SetText(WebDriver, customerNote);
        //}

        public void SaveAddNotes()
        {
            BtnAddNoteSave.Click(WebDriver);
        }


        /// <summary>
        /// click the View All Notes link
        /// </summary>
        /// <returns>ViewAllNotesPage</returns>
        public ViewNotesPage ViewAllNotes()
        {
            CustomerDetailViewAllNotes.Click(WebDriver);
            return new ViewNotesPage(WebDriver);
        }

        /// <summary>
        /// Go to Account Details
        /// </summary>
        /// <returns></returns>
        public AccountDetailsPage ViewAccount()
        {
            MoreActions.WaitForElement(WebDriver);
            MoreActions.Click(WebDriver);
            ViewAccountId.Click(WebDriver);
            return new AccountDetailsPage(WebDriver);
        }

        /// <summary>
        /// Assert: get any missing Header fields 
        /// </summary>
        /// <returns></returns>
        public string MissingHeaderFields()
        {
            var missingFields = new StringBuilder();
            if (!CustomerDetailInfoDiv.Contains("Customer Number"))
                missingFields.AppendFormat("{0},", "Customer Number");
            if (!CustomerDetailInfoDiv.Contains("Company Name"))
                missingFields.AppendFormat("{0},", "Company Name");
            if (!CustomerDetailInfoDiv.Contains("Customer Class"))
                missingFields.AppendFormat("{0},", "Customer Class");
            if (!CustomerDetailInfoDiv.Contains("Contact CFO Language"))
                missingFields.AppendFormat("{0},", "Contact CFO Language");
            if (!CustomerDetailInfoDiv.Contains("Last Updated"))
                missingFields.AppendFormat("{0},", "Last Updated");
            if (!CustomerDetailInfoDiv.Contains("Status"))
                missingFields.AppendFormat("{0},", "Status");
            if (!CustomerDetailInfoDiv.Contains("Sales Rep Name"))
                missingFields.AppendFormat("{0},", "Sales Rep Name");
            if (!CustomerDetailInfoDiv.Contains("Sales Rep ID"))
                missingFields.AppendFormat("{0},", "Sales Rep ID");

            return missingFields.ToString();
        }

        /// <summary>
        /// expand Quotes accordion
        /// </summary>
        public void ShowQuotes()
        {
            QuoteGrid.WaitForElement(WebDriver);
            QuoteId.Click(WebDriver);
        }

        /// <summary>
        /// click on View All Quotes and return page
        /// </summary>
        /// <returns></returns>
        public QuoteSearchResultsPage ViewAllQuotes()
        {
            QuoteListExpandBtn.Click(WebDriver);
            QuoteListViewAll.Click(WebDriver);
            WebDriver.TryFindElement(new QuoteSearchResultsPage(WebDriver).QuoteResultsTable, TimeSpan.FromSeconds(15));
            return new QuoteSearchResultsPage(WebDriver);
        }

        /// <summary>
        /// click on View All Orders and return page
        /// </summary>
        /// <returns></returns>
        public OrderSearchResultsPage ViewAllOrders()
        {
            OrderListViewAll.Click(WebDriver);
            // WebDriver.GetElement(By.Id(OrderIDs.OrderSearchResultsGrid));
            return new OrderSearchResultsPage(WebDriver);
        }

        /// <summary>
        /// click on View All Adresses and return page
        /// </summary>
        /// <returns></returns>
        public ViewAddressesPage ViewAllShippingAddresses()
        {
            ShipToAddressViewAll.Click(WebDriver);
            ShipToAddressAllGrid.Click(WebDriver);
            return new ViewAddressesPage(WebDriver);
        }

        /// <summary>
        /// expand Shipping Address accordion
        /// </summary>
        public void ShowShipToAddress()
        {
            ShipToAddressId.Click(WebDriver);
        }

        /// <summary>
        /// Clicks on DFS Credit check 
        /// </summary>
        public void ClickOnCheckDfsCredit()
        {
            By.LinkText("Check DFS Credit").Click(WebDriver);

        }

        public void ClickOnAddAccountLink()
        {
            LnkAddAffinityId.Click(WebDriver);
        }

        public void AddAffinityId(string affinityId)
        {
            TxtAddAffinityId.SetText(WebDriver, affinityId);
            TxtAddAffinityId.SendKeys(Keys.Tab);
        }


        public void ClickOnAddAccountSubmitLink()
        {
            LnkAddAffinityAccountSubmit.Click(WebDriver);
        }

        public bool AffinityErrorMessageIsShown()
        {
            return MsgAffinityError.Displayed;
        }

        public string AffinityErrorMessageText()
        {
            return MsgAffinityError.GetText(WebDriver);
        }


        /// <summary>
        /// Adds the link number.
        /// </summary>
        public void AddLinkNumber()
        {
            LnkAddLinkNumber.Click(WebDriver);
        }

        public void CancelAddLinkNumber()
        {
            LnkCancelSaveLinkNumber.Click(WebDriver);
        }

        /// <summary>
        /// Determines whether [is edit link number visible].
        /// </summary>
        /// <returns></returns>
        public bool IsEditLinkNumberVisible()
        {
            return LnkEditLinkNumber.Displayed;
        }

        public bool IsAddLinkNumberVisible()
        {
            return LnkAddLinkNumber.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(20)); ;
        }
        public bool IsDeleteLinkNumberVisible()
        {
            return LnkDeleteLinkNumber.Displayed;
        }

        public void EnterLinkNumberDetails(string linkNumber, string linkType)
        {
            TxtLinkNumber.SetText(WebDriver, linkNumber);
            DdlLinkType.PickDropdownByText(WebDriver, linkType);
        }

        /// <summary>
        /// Edits the link number.
        /// </summary>
        public void EditLinkNumber()
        {
            LnkEditLinkNumber.Click(WebDriver);
        }

        /// <summary>
        /// Deletes the link number.
        /// </summary>
        public void DeleteLinkNumber()
        {
            LnkDeleteLinkNumber.Click(WebDriver);
        }

        /// <summary>
        /// Saves the link number.
        /// </summary>
        public void SaveLinkNumber()
        {
            LnkSaveLinkNumber.Click(WebDriver);
        }

        public bool IsEditSalesRepIdVisible()
        {
            return LnkEditSalesRepId.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(20)); ;
        }


        public bool IsChangeCustomerClassLnkVisible()
        {
            return ChangeCustomerClassLnk.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(20)); ;
        }

        public bool IsLnkAddAccountNumberVisible()
        {
            return LnkAddAccountNumber.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(20)); ;
        }

        public void ApplyRequestHold()
        {
            MoreActions.Click(WebDriver);
            RequestHold.Click(WebDriver);

            if (IsRequestHoldPopupDisplayed())
            {
                YesRequestHold.Click(WebDriver);
            }
        }

        public bool IsRequestHoldPopupDisplayed()
        {
            return RequestHldWarnTitle.Displayed;
        }

        /// <summary>
        /// Determines whether [is save link number error displayed].
        /// </summary>
        /// <returns></returns>
        public bool IsSaveLinkNumberErrorDisplayed()
        {
            return DivSaveLinkNumberError.Displayed;
        }

        public bool IsCreateQuoteButtonDisplayed()
        {
            return BtnCreateQuote.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(20));
        }

        /// <summary></summary>
        /// <returns>
        /// Customer Number IWebElement
        /// </returns>
        public IWebElement GetCustomerNumber()
        {
            return LblCustomerNumber;
        }

        /// <summary></summary>
        /// <returns>
        /// Customer Name IWebElement
        /// </returns>
        public IWebElement GetCustomerName()
        {
            return CustomerNameTxt;
        }

        /// <summary></summary>
        /// <returns>
        /// Customer billing Name IWebElement
        /// </returns>
        public IWebElement GetCustomerBillingName()
        {
            return CustomerBillingNameTxt;
        }

        /// <summary>
        /// Account number IWebElement
        /// </summary>
        /// <returns></returns>
        public IWebElement GetAccountNumber()
        {
            return AccountNumberTxt;
        }

        /// <summary>
        /// Account Name IWebElement
        /// </summary>
        /// <returns></returns>
        public IWebElement GetAccountName()
        {
            return AccountNameTxt;
        }

        public IWebElement GetEditContactButtonFromPrimaryBilling(int index)
        {
            IList<IWebElement> EditContact =
            WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_locations']//tr[3]//a[contains(text(),'Edit Contact')]"));
            return EditContact.ElementAt(index);
        }

        public IWebElement GetEditContactButtonFromAddressTable(int index)
        {
            ReadOnlyCollection<IWebElement> EditContact =
            WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_locations']//tr//a[contains(text(),'Edit Contact')]"));
            return EditContact.ElementAt(index);
        }

        public void AddAddressFromLocation(IWebDriver driver, DataRow row, int number)
        {

            if (row["addressType"].ToString() == "Billing")
            {
                AddLocationCheckBilling.Click(driver);
            }
            else if (row["addressType"].ToString() == "Shipping")
            {
                AddLocationCheckShipping.Click(driver);
                AddLocationCheckShippingAsPrimary.Click(driver);
            }

            AddLocationAddress1.SetText(driver, number.ToString(), null);
            AddLocationZipcode.SetText(driver, row["AddLocationZipcode1"].ToString(), null);
            //AddLocationCity.SetText(driver, row["AddLocationCity1"].ToString(), null);
            //AddLocationSelectState.PickDropdownByText(driver, row["AddLocationSelectState1"].ToString());

            AddLocationSelectTitle.PickDropdownByText(driver, row["AddLocationSelectTitle1"].ToString());
            AddLocationFirstName.SetText(driver, row["AddLocationFirstName1"].ToString(), null);
            AddLocationLastName.SetText(driver, row["AddLocationLastName1"].ToString(), null);
            AddLocationPhoneMobile.SetText(driver, row["AddLocationPhoneHome1"].ToString(), null);
            AddLocationEmailInvoice.SetText(driver, row["AddLocationEmailInvoice1"].ToString(), null);
            if (EmailOverrideValidation.IsElementDisplayed(WebDriver))
            {
                EmailOverrideValidation.Click(WebDriver);
            }
            else
            {
                //do nothing
            }


            AddLocationSubmit.Click();

            if (IsAvsVisible())
            {
                SelectOriginalAddressFromAvsPopup();
            }
            else
            {
                // do nothing
            }
            driver.VerifyBusyOverlayNotDisplayed();
        }

        public List<Dictionary<string, object>> GetAddressTable()
        {
            AddressesTable.WaitForElement(WebDriver);
            return AddressesTable.GetTableData(WebDriver);
        }

        public List<Dictionary<string, object>> GetQuoteListTable()
        {
            QuoteListTable.WaitForElement(WebDriver);
            return QuoteListTable.GetTableData(WebDriver);
        }
        public List<Dictionary<string, object>> GetOrderListTable()
        {
            OrderListTable.WaitForElement(WebDriver);
            return OrderListTable.GetTableData(WebDriver);
        }

        public List<Dictionary<string, object>> GetSolutionListTable()
        {
            SolutionListTable.WaitForElement(WebDriver);
            return SolutionListTable.GetTableData(WebDriver);
        }

        public IWebElement SelectAddressTab(int? tabNumber)
        {
            return WebDriver.GetElement(By.Id("View_All_Locations_Grid_tab_" + tabNumber));

        }
        public List<Dictionary<string, object>> GetAddressTableViewLocations(int? tabNumber)
        {
            AddressesTable.WaitForElement(WebDriver);
            SelectAddressTab(tabNumber).Click();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            if (DisplayItemsPerPage.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
            {
                DisplayItemsPerPage.PickDropdownByText(WebDriver, "40 per page");
            }
            else
            {
                // do nothing
            }
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return AddressesTable.GetTableData(WebDriver);
        }

        public List<Dictionary<string, object>> GetAddNewAddressAddressTable()
        {
            AddressTableAddNewContact.WaitForElement(WebDriver);
            //return AddressesTable.GetHtmlTableData(WebDriver);
            return AddressTableAddNewContact.GetTableData(WebDriver);
        }

        public void AddNewAddressFromLocation(IWebDriver driver, DataRow row, int number)
        {

            if (row["addressTypeShipping"].ToString() == "Shipping")
            {
                AddLocationCheckShipping.Click(driver);
                AddLocationCheckShippingAsPrimary.Click(driver);
            }

            AddLocationAddress1.SetText(driver, number.ToString(), null);
            AddLocationPostalcode.SetText(driver, row["Postalcode"].ToString(), null);

            //AddLocationPostalcodeExt.SetText(driver, row["PostalcodeExt"].ToString(), null);
            AddLocationSelectTitle.PickDropdownByText(driver, row["AddLocationSelectTitle1"].ToString());
            AddLocationFirstName.SetText(driver, row["AddLocationFirstName"].ToString(), null);
            AddLocationLastName.SetText(driver, row["AddLocationLastName"].ToString(), null);
            AddLocationPhoneMobile.SetText(driver, row["AddLocationPhoneHome"].ToString(), null);
            AddLocationEmailInvoice.SetText(driver, row["AddLocationEmail"].ToString(), null);
            AddLocationSubmit.Click();

            if (IsAvsVisible())
            {
                SelectOriginalAddressFromAvsPopup();
            }
            else
            {
                // do nothing
            }
            driver.VerifyBusyOverlayNotDisplayed();
        }

        public bool IsAvsVisible()
        {
            return AddressSuggestionPopup.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(30));
        }

        public void SelectOriginalAddressFromAvsPopup()
        {
            UseOriginalAddress.Click();
            ConfirmYesBtn.Click();
        }

        public void AddInternationalAddressFromLocation(IWebDriver driver, DataRow row, int number)
        {
            if (row["addressType"].ToString() == "Billing")
            {
                AddLocationCheckBilling.Click(driver);
            }

            string timeStamp = DateTime.Now.Ticks.ToString().Substring(8, 10);
            string AddLocationFirstName1 = row["AddLocationFirstName1"].ToString() + timeStamp;

            AddLocationSelectCountry.PickDropdownByText(driver, row["AddLocationSelectCountry1"].ToString());
            AddLocationAddress1.SetText(driver, number.ToString(), null);
            AddLocationCity.SetText(driver, row["AddLocationCity1"].ToString(), null);
            AddLocationSelectTitle.PickDropdownByText(driver, row["AddLocationSelectTitle1"].ToString());
            AddLocationFirstName.SetText(driver, AddLocationFirstName1, null);
            AddLocationLastName.SetText(driver, row["AddLocationLastName1"].ToString(), null);
            AddLocationPhoneMobile.SetText(driver, row["AddLocationPhoneHome1"].ToString(), null);
            AddLocationEmailInvoice.SetText(driver, row["AddLocationEmailInvoice1"].ToString(), null);
            if (EmailOverride.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5)))
            {
                EmailOverride.Click(WebDriver);
            }
            else
            {
                //Do nothing
            }
            AddLocationSubmit.Click(driver);
            driver.VerifyBusyOverlayNotDisplayed();
        }

        public void AddShippingAddress(IWebDriver driver, DataRow row, int number)
        {
            AddShippingAddressFirstName.SetText(driver, row["AddShippingFirstName"].ToString());
            AddShippingAddressLastName.SetText(driver, row["AddShippingLastName"].ToString());
            AddShippingAddressEmail.SetText(driver, row["AddShippingEmail"].ToString());
            AddShippingAddressLine1.SetText(driver, number.ToString());
            AddShippingAddressCity.SetText(driver, row["AddShippingCity"].ToString());
            AddShippingAddressState.PickDropdownByText(driver, row["AddShippingState"].ToString());
            AddShippingAddressZipCode.SetText(driver, row["AddShippingZipCode"].ToString());
            AddShippingAddressZipExtension.SetText(driver, row["AddShippingZipExtension"].ToString());
            AddShippingAddressPrimaryPhone.SetText(driver, row["AddShippingPrimaryPhone"].ToString());
            //AddShippingAddressSaveBtn.Click(driver);
            AddShippingAddressSubmitBtn.Click(driver);
            VerifiedAddressesRadioBtn.Click(driver);
            SuggestedAddressSelect.Click(driver);
        }

        public void FillAddLocationWithInvalidEmailandPhoneNumber(IWebDriver driver, DataRow row)
        {
            AddLocationAddress1.SetText(driver, row["AddressLine1"].ToString(), null);
            AddLocationPostalcode.SetText(driver, row["ZipCode"].ToString(), null);
            AddLocationFirstName.SetText(driver, row["FirstName"].ToString(), null);
            AddLocationLastName.SetText(driver, row["LastName"].ToString(), null);
        }

        public void FillAddLocationWithInvalidPhoneNumber(IWebDriver driver, DataRow row)
        {
            AddLocationAddress1.SetText(driver, row["AddressLine1"].ToString(), null);
            AddLocationPostalcode.SetText(driver, row["ZipCode"].ToString(), null);
            AddLocationFirstName.SetText(driver, row["FirstName"].ToString(), null);
            AddLocationLastName.SetText(driver, row["LastName"].ToString(), null);
            AddLocationEmailInvoice.SetText(driver, row["AddLocationEmailInvoice1"].ToString(), null);
        }

        public void AddNewContactLocationsInvalidPhone(IWebDriver driver, DataRow row)
        {
            AddNewContactFirstName.SetText(driver, row["AddLocationFirstName1"].ToString(), null);
            AddNewContactLastName.SetText(driver, row["AddLocationLastName1"].ToString());
            AddNewContactEmail.SetText(driver, row["AddContactEmail1"].ToString());
        }

        public void AddNewContactViewAllLocation(IWebDriver driver, DataRow row, String randomEmailaddress)
        {
            AddNewContact.Click();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            AddNewContactFirstName.SetText(driver, row["AddLocationFirstName1"].ToString(), null);
            AddNewContactLastName.SetText(driver, row["AddLocationLastName1"].ToString());
            AddNewContactMobilePhone.SetText(driver, row["AddLocationPhoneHome1"].ToString());
            AddNewContactEmail.SetText(driver, randomEmailaddress);
            AddNewContactSelectShippingAddress.Click();
            AddNewContactSaveButton.Click();
        }

        public void Duplicatecheck(IWebDriver driver, DataRow row, String randomEmailaddress)
        {
            AddNewContact.Click();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            AddNewContactFirstName.SetText(driver, row["AddLocationFirstName"].ToString(), null);
            AddNewContactLastName.SetText(driver, row["AddLocationLastName"].ToString());
            AddNewContactMobilePhone.SetText(driver, row["AddLocationPhoneHome"].ToString());
            AddNewContactEmail.SetText(driver, randomEmailaddress);
            AddNewContactSelectShippingAddress.Click();
            AddNewContactSaveButton.Click();
        }

        public void AddNewContactCustomerDetails(IWebDriver driver, DataRow row, String randomEmailAddress)
        {
            AddNewContactFirstName.SetText(driver, row["AddLocationFirstName1"].ToString(), null);
            AddNewContactLastName.SetText(driver, row["AddLocationLastName1"].ToString());
            AddNewContactMobilePhone.SetText(driver, row["AddLocationPhoneHome1"].ToString());
            AddNewContactEmail.SetText(driver, randomEmailAddress);
            AddNewContactSelectShippingAddress.Click();
            AddNewContactSaveButton.Click();
        }

        public void AddNewContactContryCustomerDetails(IWebDriver driver, DataRow row, String randomEmailAddress)
        {
            AddNewContactFirstName.SetText(driver, row["AddLocationFirstName1"].ToString(), null);
            AddNewContactLastName.SetText(driver, row["AddLocationLastName1"].ToString());
            AddNewContactMobilePhone.SetText(driver, row["AddLocationPhoneHome1"].ToString());
            AddNewContactEmail.SetText(driver, randomEmailAddress);
            AddNewContactSelectShippingAddress.Click();
            //AddNewContactSaveButton.Click();
        }

        public IWebElement CompanyMismatchError(string text)
        {
            return WebDriver.FindElement(By.XPath("//*[contains(text(), 'Please ensure your " + text + " customer company number is same as your current customer company number.')]"));
        }

        public QuoteListPage GoToQuoteListPage()
        {
            QuoteListExpandBtn.Click(WebDriver);
            QuoteListViewAll.Click(WebDriver);
            return new QuoteListPage(WebDriver);
        }

        public IWebElement GetLocationTable(int index)
        {
            string locationTableXPath =
                String.Format(
                    "//*[@id='DataTables_Table_locations']/tbody/tr[{0}]",
                    index);
            return WebDriver.FindElement(By.XPath(locationTableXPath));
        }

        public IWebElement GetCreditRequestTable(int index)
        {
            string CreditRequestTableXPath =
                String.Format("//*[@id='DataTables_Table_creditRequestDetails']/tbody/tr[{0}]", index);
            return WebDriver.FindElement(By.XPath(CreditRequestTableXPath));
        }

        public void ClickChangeSalesChannel()
        {
            ChangeSalesChannel.Click(WebDriver);
        }

        public string GetCompanyNumber()
        {
            return LblCompanyNumber.GetText(WebDriver);
        }

        /// <summary>
        /// Select Sales Channel on Change Sales Channel popup.
        /// </summary>
        /// <param name="CompanyNumber"></param>
        public void SelectSalesChannel(string CompanyNumber)
        {
            SalesChannel.WaitForElement(WebDriver);
            SalesChannel.Select().SelectByPartialText(CompanyNumber);
        }

        /// <summary>
        /// Sets SalesRep Id on ChangeSalesChannel popup.
        /// </summary>
        /// <param name="SalesRepID"></param>
        public void SetSalesRepID(string SalesRepID)
        {
            TxtSalesRepId.Clear();
            TxtSalesRepId.SendKeys(SalesRepID);
        }

        public string GetSalesRepId()
        {
            return SalesRepId.GetText(WebDriver);
        }


        public void EditSalesRepID(string SalesRepID)
        {
            LnkEditSalesRep.WaitForElement(WebDriver);
            LnkEditSalesRep.Click(WebDriver);
            TxtSalesRepInput.WaitForElement(WebDriver);
            TxtSalesRepInput.Clear();
            TxtSalesRepInput.SetText(WebDriver, SalesRepID);
            LnkSaveSalesRep.Click(WebDriver);
            //LnkEditSalesRepId
        }

        public void SubmitSetSelectSalesChannel()
        {
            SelectSalesChannelSubmit.Click();
        }

        public void SelectCustomerClass(string PartialText)
        {
            CustomerClass.Select().SelectByPartialText(PartialText);
        }

        public void CaEditSalesRepID(string SalesRepID)
        {
            LnkEditSalesRepId.WaitForElement(WebDriver);
            LnkEditSalesRepId.Click(WebDriver);
            TxtSalesRepInput.WaitForElement(WebDriver);
            TxtSalesRepInput.Clear();
            TxtSalesRepInput.SetText(WebDriver, SalesRepID);
            LnkSaveSalesRep.Click(WebDriver);
        }
        /// <summary>
        /// Changes Company number. 
        /// Selects Change Sales Channel option from Menu
        /// </summary>
        /// <param name="Company"></param>
        /// <param name="SalesRepID"></param>
        /// <param name="CustomerClass"></param>
        public void ChangeCompanyNumber(string Company, string SalesRepID, string CustomerClass)
        {
            var currentCompany = GetCompanyNumber();

            MoreActionClk();
            ClickChangeSalesChannel();

            if (ChangeSalesChannelYes.IsElementDisplayed(WebDriver, null))
            {
                ChangeSalesChannelYes.Click();
            }
            if (!currentCompany.Equals(Company))
            {
                SelectSalesChannel(Company);

                SetSalesRepID(SalesRepID);

                SelectCustomerClass(CustomerClass);
                SubmitSetSelectSalesChannel();
            }
        }

        public void ChangeCompNumber(string Company, string SalesRepID, string CustomerClass)
        {
            MoreActionClk();
            ClickChangeSalesChannel();

            SelectSalesChannel(Company);
            SetSalesRepID(SalesRepID);
            SelectCustomerClass(CustomerClass);
            SubmitSetSelectSalesChannel();
        }

        public void SalesChannelPopup(string Company, string SalesRepID, string CustomerClass)
        {
            SelectSalesChannel(Company);
            SetSalesRepID(SalesRepID);
            SelectCustomerClass(CustomerClass);
            SubmitSetSelectSalesChannel();
        }

        public IWebElement GetRemoveBtnFromFundersTable(int index)
        {
            string removeBtnXPath = String.Format("//a[contains(text(),'Remove')]", index);
            return WebDriver.FindElement(By.XPath(removeBtnXPath));
        }

        public List<Dictionary<string, object>> GetFundersTable()
        {
            // Wait for funders table to load.
            AddFunderTableRow1.WaitForElement(WebDriver);
            return AddFunderTableRow1.GetTableData(WebDriver);
        }

        /// <summary>
        /// Clicks on CopyCustomer from MoreActions and navigates to CustomerCreatePage.
        /// </summary>
        /// <returns>returns CustomerCreatePage</returns>
        public CustomerCreatePage CopyCustomer()
        {
            // Click on MoreActions.
            MoreActionClk();

            // Click on Copy Customer.
            LnkCopyCustomer.Click(WebDriver);

            var companyNumber = LblCompanyNumber.GetText(WebDriver);
            var selectCatalog = new SelectCompanyNumberDailog(WebDriver);
            selectCatalog.SelectCompanyNumber(companyNumber);

            return new CustomerCreatePage(WebDriver);
        }


        // Copy Customer and pass Sales channel
        public CustomerCreatePage CopyCustomerSelectSalesChannel(IWebDriver WebDriver, String CompanyNumber)
        {
            MoreActionClk();
            LnkCopyCustomer.Click(WebDriver);

            // Select Catalog
            var selectCatalog = new SelectCompanyNumberDailog(WebDriver);
            selectCatalog.SelectCompanyNumber(CompanyNumber);
            return new CustomerCreatePage(WebDriver);
        }


        /// <summary>
        /// This method is used to Expand the Locations section
        /// </summary>
        /// <returns></returns>
        public bool ExpandLocation()
        {
            try
            {
                By byLocationsBody = By.XPath("//div[@id='customerDetails_view']//div[@class='accordion-heading'])[1]/parent::div//div[@class='accordion-body']");
                if (!WebDriver.WaitForElementDisplay(byLocationsBody, TimeSpan.FromSeconds(1)))
                {
                    LocationsHeader.Click();
                    if (WebDriver.WaitForElementDisplay(byLocationsBody, TimeSpan.FromSeconds(1)))
                        return true;
                }
                else if (WebDriver.WaitForElementDisplay(byLocationsBody, TimeSpan.FromSeconds(1)))
                    return true;
            }
            catch (Exception) { }
            return false;
        }
        /// <summary>
        /// This method is used to Expand the Adresses -Billing/Shipping under Locations section
        /// </summary>
        /// <param name="byAddressType"></param>
        /// <returns></returns>
        public bool ExpandAddress(By byAddressType)
        {
            try
            {
                if (WebDriver.WaitAndGetElementAfterDisplay(byAddressType, TimeSpan.FromMilliseconds(50)) != null)
                {
                    IWebElement eleAddressType = WebDriver.WaitAndGetElementAfterDisplay(byAddressType, TimeSpan.FromMilliseconds(25));
                    eleAddressType.GetAttribute("class").Contains("k-i-arrow-s");
                    eleAddressType.Click();
                    if (WebDriver.FindElement(byAddressType).GetAttribute("class").Contains("k-i-arrow-n"))
                        return true;
                }
            }
            catch (Exception ex) { }
            return false;
        }

        /// <summary>
        /// Gets the Locations and Contacts Table data from Locations and Contacts page.
        /// </summary>
        /// <returns></returns>
        public List<Dictionary<string, object>> GetLocationsAndContactsTable()
        {
            ViewAllLocationsDeactivateLocationBtn.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(60));
            LocationsAndContactsTable.WaitForElement(WebDriver);
            return LocationsAndContactsTable.GetHtmlTableData(WebDriver);
        }

        public List<Dictionary<string, object>> GetLocationsTable()
        {
            LocationsAndContactsTable.WaitForElement(WebDriver);
            if (DisplayItemsPerPage.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
            {
                DisplayItemsPerPage.PickDropdownByText(WebDriver, "40 per page");
            }
            else
            {
                // do nothing
            }
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return LocationsAndContactsTable.GetHtmlTableData(WebDriver);
        }

        /// <summary>
        /// Returns Primary Billing Contact under Locations section.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryBillingContact()
        {
            //ExpandLocationsSection();
            var allLocations = GetLocationsAndContactsTable();
            var primaryBillingContact = new Dictionary<string, object>();
            foreach (var location in allLocations)
            {
                if (location["Type"].ToString().Equals("Primary Billing"))
                {
                    primaryBillingContact = location;
                    break;
                }
            }
            return primaryBillingContact;
        }

        /// <summary>
        /// Expands Locations section in CustomerDetails page.
        /// </summary>
        public void ExpandLocationsSection()
        {
            LocationsExpandBtn.Click(WebDriver);
        }

        /// <summary>
        /// Edits Primary Billing Contact in Table under Locations section.
        /// </summary>
        public void EditPrimaryBillingContact(string emailAddress)
        {
            //ExpandLocationsSection();
            var allLocations = GetLocationsAndContactsTable();
            foreach (var location in allLocations)
            {
                if (location["Type"].ToString().Equals("Primary Billing"))
                {
                    LocationsPrimaryBillingEditContactBtn.Click(WebDriver);
                    EditContactEmailInvoice.SetText(WebDriver, emailAddress);

                    if (EmailOverride.IsElementDisplayed(WebDriver))
                    {
                        EmailOverride.Click(WebDriver);
                    }
                    else
                    {
                        //do nothing
                    }
                    MobileNumber.Click(WebDriver);
                    WebDriver.VerifyBusyOverlayNotDisplayed();
                    EditContactSubmitBtn.Click(WebDriver);
                }
            }
        }

        public void EditBillingContact(string noemailAddress)
        {
            //ExpandLocationsSection();
            var allLocations = GetLocationsAndContactsTable();
            foreach (var location in allLocations)
            {
                if (location["Type"].ToString().Equals("Primary Billing"))
                {
                    LocationsPrimaryBillingEditContactBtn.Click(WebDriver);
                    EditContactEmailInvoice.SetText(WebDriver, noemailAddress);

                    if (NoEmailOverride.IsElementDisplayed(WebDriver))
                    {
                        NoEmailOverride.Click(WebDriver);
                    }
                    else
                    {
                        //do nothing
                    }
                    MobileNumber.Click(WebDriver);
                    WebDriver.VerifyBusyOverlayNotDisplayed();
                    EditContactSubmitBtn.Click(WebDriver);
                }
            }
        }
        public void EditContactAndValidateEmailAddress(string emailAddress)
        {
            //ExpandLocationsSection();
            var allLocations = GetLocationsAndContactsTable();
            foreach (var location in allLocations)
            {
                if (location["Type"].ToString().Equals("Primary Billing"))
                {
                    LocationsPrimaryBillingEditContactBtn.Click(WebDriver);


                    EditContactEmailInvoice.SendKeys("~ | : ; < {],> Dave_@_}");
                    //validate here// 
                    var customerDetailsPage = new CustomerDetailsPage(WebDriver);
                    customerDetailsPage.EditContactEmailInvoice.IsElementDisplayed(WebDriver);
                    Logger.Write("Must use the format name@domain.tld");
                    EditContactEmailInvoice.Clear();
                    EditContactEmailInvoice.SetText(WebDriver, emailAddress);
                    EditContactSubmitBtn.Click(WebDriver);
                }
            }
        }
        /// <summary>
        /// Displays the ChangeShippingGroupPopup when trying to patch a different company customer at shipping group level from bill to .
        /// </summary>
        /// <returns></returns>
        public bool IsChangeShippingGroupCustomerPopupDisplayed()
        {
            return ChangeShipGrpConfirmButton.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(20));
        }

        public void ExpandAddress(object byShippingAddressExpand)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks the status of undelivered reason value for primary billing address in locations table.
        /// True for Approved.
        /// False for Not Approved.
        /// </summary>
        /// <returns>true/false</returns>
        public bool CheckIfDunsMatchStatusIsNotApproved()
        {
            // considers duns status as not approved by default.
            var isDunsStatusNotApproved = true;

            // Get Primary billing location.
            var primaryBillingContact = GetPrimaryBillingContact();

            // Check the value for undelivered reason.
            var dunsStatus = primaryBillingContact["Undelivered Reason Value"].ToString();

            isDunsStatusNotApproved = dunsStatus.Contains("Not Approved");

            // return true or false.
            return isDunsStatusNotApproved;
        }

        public void ExpandAccordian(string AccordianName)
        {
            foreach (IWebElement element in AllAccordian)
            {
                if (element.GetText(WebDriver).Contains(AccordianName))
                {
                    IWebElement ClickAccordian = element.FindElement(By.TagName("a"));
                    ((IJavaScriptExecutor)WebDriver).ExecuteScript("arguments[0].scrollIntoView(true);", ClickAccordian);
                    ClickAccordian.Click();

                }
            }
        }

        public List<string> GetAllColumnValues_Quotes(string ColName)//updated with New UI
        {

            IList<IWebElement> Columns = WebDriver.FindElements
                (By.XPath(
                @".//*[@id='DataTables_Table_1']"));

            //Check if We have Data Available



            List<string> ColumnValues = new List<string>();
            foreach (IWebElement element in Columns)
            {
                ColumnValues.Add(element.GetText(WebDriver));
            }

            return ColumnValues;
        }

        public bool VerifyOrderGridHasData()
        {
            return OrdeListHasRows.Count > 1;
        }

        public OrderListPage GoToOrderListPage()
        {
            OrdersListTab.Click(WebDriver);
            //QuoteListViewAll.Click(WebDriver);
            return new OrderListPage(WebDriver);
        }

        /// <summary>
        /// Clicks on the Duration days Link 
        /// </summary>
        /// <param name="webDriver"></param>
        /// <param name="daysLink"></param>
        /// <returns></returns>
        public ReportingPage ViewOrdersDuration(IWebDriver webDriver, IWebElement daysLink)
        {
            WebDriverUtil.WaitForElementDisplay(webDriver, daysLink, TimeSpan.FromSeconds(5));
            WebDriverUtil.JavaScriptClick(webDriver, daysLink);
            return new ReportingPage(webDriver);
        }

        public bool isQuoteTypeMatchesforQuoteinCustomerQuoteList(string QuoteNumber, string QuoteType)
        {
            bool isQuoteTypeMatches = false;
            var quoteList = customerQuoteListRows;
            for (int i = 0; i < quoteList.Count; i++)
            {
                if (customerQuoteListRowColoumn(i + 1, 8).GetText(WebDriver).Contains(QuoteNumber) == true && customerQuoteListRowColoumn(i + 1, 11).GetText(WebDriver) == QuoteType)
                {
                    isQuoteTypeMatches = true;
                    break;
                }
            }
            return isQuoteTypeMatches;
        }

        public IWebElement AddressLines(string lineAddress, int lineRowIndex = 1)
        {
            return WebDriver.GetElement(By.XPath($"(//table[@id = 'DataTables_Table_locations']//td[contains(text(), '{lineAddress}')])[{lineRowIndex}]"));
        }

        public IWebElement City(string city, int lineRowIndex = 1)
        {
            return WebDriver.GetElement(By.XPath($"(//table[@id = 'DataTables_Table_locations']//td[contains(text(), '{city}')])[{lineRowIndex}]"));
        }

        public IWebElement State(string state, int lineRowIndex = 1)
        {
            return WebDriver.GetElement(By.XPath($"(//table[@id = 'DataTables_Table_locations']//td[contains(text(), '{state}')])[{lineRowIndex}]"));
        }
        public IWebElement ZipCode(string zipCode, int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath($"(//table[@id = 'DataTables_Table_locations']//td[contains(text(), '{zipCode}')])[{lineItemIndex}]"));
        }

        public IWebElement Email(string email, int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath($"(//table[@id = 'DataTables_Table_locations']//td[contains(text(), '{email}')])[{lineItemIndex}]"));
        }

        public IWebElement Type(int lineItemIndex = 9)
        {
            return WebDriver.GetElement(By.XPath($"(//td[@ng-reflect-ng-class = '[object Object]'])[{lineItemIndex}]"));
        }

        public IWebElement Yes { get { return WebDriver.GetElement(By.XPath(@"COM")); } }

        public CustomerDetailsPage GetAllOptionsFromDropDown(IWebElement element, int count)
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
            return new CustomerDetailsPage(WebDriver);
        }

        public IWebElement CheckTaxExemptHeadings(String fieldName)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='customerDetails_informationComponent']//state-province-tax-exemption//popover-content//h5[contains(text(), '" + fieldName + "')]"));
        }

        public bool VerifyOrdersGridHeaders(string columnName)
        {
            IWebElement header = WebDriver.FindElement(By.XPath($"//table[contains(@id, 'Orders_OrdersGrid')]//*[text() = '{columnName}']"));
            return header.Displayed;
        }

        /// <summary>
        /// Expands Premier Pages section.
        /// </summary>
        public void ExpandPremierPages()
        {
            PremierPages.Click();
        }

        /// <summary>
        /// Navigates to View All Premier pages.
        /// </summary>
        public void NavigateToPremierPages()
        {
            ExpandPremierPages();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            ViewAllPremierPages.Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
        }

        public CustomerDetailsPage ClickonFinancialInformation(IWebDriver driver)
        {
            FinancialInformation.Click(driver);
            driver.Manage().Timeouts().PageLoad = new TimeSpan(0, 0, 120);
            return new CustomerDetailsPage(WebDriver);
        }

        public IWebElement DFSStatus => new WebDriverWait(WebDriver, TimeSpan.FromSeconds(90)).Until(ExpectedConditions.ElementIsVisible(By.Id("customerDetails_dfsStatus")));
        
        public DpaPaymentPage RunCredit()
        {
            LnkRunCredit.Click(WebDriver);
            WebDriverUtil.WaitUntilUrlDisplay(WebDriver, "Consumer/DPA/DPACreditApp", 45);
            return new DpaPaymentPage(WebDriver);
        }

        public DfsPaymentPage ClickViewDfsDetailsLink()
        {            
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[normalize-space()='View DFS Details']")));

            if (ViewDfSlinikforDpaCustomer.IsElementClickable(WebDriver))
                ViewDfSlinikforDpaCustomer.Click();
            return new DfsPaymentPage(WebDriver);
        }

        #region CA New DFS elements
        //public IWebElement CaFinancialInfoSection { get { return WebDriver.GetElement(By.XPath("//div[normalize-space()='Financial Information']/following-sibling::div")); } }
        public IWebElement DFSDetailsLink { get { return WebDriver.GetElement(By.XPath("//dfs-smb-info-ca//a[@id='scc_viewDfsDetailsLink']")); } }
        public IWebElement LeaseAccStatusValue { get { return WebDriver.GetElement(By.XPath("//label[text()='Lease Account Status']/following-sibling::div/span[contains(@id,'leaseAccountStatus')]")); } }
        public IWebElement CreditStatusValue { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Lease Credit Status')]/following-sibling::div/span")); } }
        public IWebElement LeaseOfferValue { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Lease Offer')]/following-sibling::div/span")); } }
        public IWebElement MLAValue { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'MLA')]/following-sibling::div/span")); } }
        public IList<IWebElement> CaDfsStatusLabels { get { return WebDriver.GetElements(By.XPath("//dfs-smb-info-ca//div/label")); } }
        public IWebElement CaDfsEligible { get { return WebDriver.GetElement(By.Id("lookup_dfsStatus")); } }
        public IWebElement LeaseLabel { get { return WebDriver.GetElement(By.XPath("//*[text()='Lease: ']")); } }
        public IWebElement LeaseValue { get { return WebDriver.GetElement(By.XPath("//span[contains(@id,'leaseCreditStatusDesc')]")); } }//approved
        public IWebElement LeaseValueAmount { get { return WebDriver.GetElement(By.Id("customerLookupDetails_leaseCreditStatus")); } }//$15000
        public IWebElement MlaValue { get { return WebDriver.GetElement(By.Id("customerlookupDetails_hasMLA")); } } // yes
        public IWebElement MlaLabel { get { return WebDriver.GetElement(By.XPath("//*[text()=' MLA: ']")); } }
        public IList<IWebElement> CaDfsHeaderLabels { get { return WebDriver.GetElements(By.XPath("//dfs-smb-lookup-header/div//label")); } }
        public IWebElement DFSDetailsHeaderLink { get { return WebDriver.GetElement(By.XPath("//dfs-smb-lookup-header//a[@id='scc_viewDfsDetailsLink']")); } }
        public void WaitUntilCreditCheckIsDone()
        {           
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("lookup_dfsStatus")));
        }
        #endregion
    }

}
