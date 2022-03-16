
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Dsa.DataModels;
using Dsa.Enums;
using Dsa.Pages.Product;
using Dsa.Pages.APOS;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using Dsa.Pages.Solutions;
using Dell.Adept.Testing.DataGenerators.Primitive;
using Dsa.Pages.Customer;
using Dsa.Pages.Order;
using FluentAssertions;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Workflows;
using Dsa.Pages.Solutions.ManageAccounts;
using OpenQA.Selenium.Interactions;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using Dsa.Pages.PCFConvergence;

namespace Dsa.Pages.Quote
{
	public class CreateQuotePage : DsaPageBase
	{
		private const string pagePrefix = "quoteCreate";
		private const string selectGoalDeal = "_LI_selectGoalDealId_";
		private const string shippingMethod = "shippingMethod";
		public static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		private IWebDriver webDriver;

		public CreateQuotePage(IWebDriver webDriver)
			: base(webDriver)
		{
			Name = "Create Quote Page";
			this.webDriver = webDriver;
			PageFactory.InitElements(webDriver, this);
			webDriver.VerifyBusyOverlayNotDisplayed();
		}

		public QuoteSummary Summary
		{
			get { return new QuoteSummary(WebDriver, pagePrefix); }
		}

		public QuoteFooter OtherInformation
		{
			get { return new QuoteFooter(WebDriver, pagePrefix); }
		}

		public QuotePage PageInformation
		{
			get { return new QuotePage(WebDriver, pagePrefix); }
		}



		#region Solution Elements




		public IWebElement CreateQuoteOverrideValidationMessages { get { return WebDriver.GetElement(By.XPath(@"//div[@id='quoteCreate_validation']")); } }

		public IWebElement CreateQuoteValidationMessages { get { return WebDriver.GetElement(By.XPath(@"//quote-create-header-notification")); } }

		public IWebElement CreateQuoteAddItemButton { get { return WebDriver.GetElement(By.Id(@"quoteCreate_additem_top_0_")); } }

		public IWebElement CreateQuoteOverrideXPODMessages { get { return WebDriver.GetElement(By.Id(@"quoteCreate_Overridable_XPOD_Messages")); } }



		public IWebElement FinalPrice { get { return WebDriver.GetElement(By.XPath("//*[text()='Final Price:']/following::span[1]")); } }


		public IWebElement ReviewChecklist { get { return WebDriver.GetElement(By.XPath("//a[@id='menu_currentQuote2']/following::div[@id='review-checklist-modal']")); } }


		public IWebElement ReviewChecklistModal { get { return WebDriver.GetElement(By.XPath("//*[@id='review-checklist-modal']")); } }


		public IWebElement PromotionArea { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_D_Promos_-']/input")); } }

		By PromotionAreaby = By.XPath(".//*[@id='quoteCreate_D_Promos_-']");

		//[FindsBy(How = How.LinkText, Using = "Exclude All")]
		//public IWebElement LnkExcludeAllPromotion;
		public IWebElement LnkExcludeAllPromotion { get { return WebDriver.GetElement(By.LinkText("Exclude All")); } }


		public IWebElement LnkIncludeAllPromotion { get { return WebDriver.GetElement(By.LinkText("Include All")); } }


		public IWebElement OverrideValidationDialog { get { return WebDriver.GetElement(By.XPath("//div[div[h3[contains(text(),'Override Validation')]]]")); } }


		public IWebElement CreateQuoteGSCVValidation { get { return WebDriver.GetElement(By.Id("quoteCreate_GSCVValidation")); } }


		public IWebElement GSCVValidationWarningDialog { get { return WebDriver.GetElement(By.XPath("//div[h3[contains(text(),'Warning')]]")); } }


		public IWebElement BtnPersonalizedRecommended { get { return WebDriver.GetElement(By.Id("toggleMoreLess_0_0")); } }


		public IWebElement LinkedQuotesListBox { get { return WebDriver.GetElement(By.Id("quoteCreate_LinkedQuotes")); } }


		public IWebElement QuoteName { get { return WebDriver.GetElement(By.Id("quoteCreate_quoteName")); } }


		public IWebElement ShippingInstructionsMessageAtHeader { get { return WebDriver.GetElement(By.Id(".//*[@id='quoteCreate_header']/div[contains(@data-ng-show,'ShippingInstructions')]")); } }


		public IWebElement SolutionId { get { return WebDriver.GetElement(By.Id("quoteCreate_items_header_s")); } }

		public IWebElement BtnCreateNewSolution { get { return WebDriver.GetElement(By.Id("create_new_solution")); } }

		public IWebElement GridYourSolutions { get { return WebDriver.GetElement(By.Id("divsolutionTable")); } }

		public IWebElement ShippingInstructionsMessageAtShippingMethod { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_GI_0_shippingMethod']/../div ")); } }


		public IWebElement SfdcDealIdPresnetintheTxtBox { get { return WebDriver.GetElement(By.Id("quoteCreate_viewOpportunity")); } }


		public IWebElement GSCVValidationWarningDialogYesButton_2 { get { return WebDriver.GetElement(By.Id("messageDialogButton_0")); } }


		public IWebElement OverrideValidationDialogCheckBoxby_2 { get { return WebDriver.GetElement(By.XPath("//input[@id='quote_details_agreed']")); } }


		public IWebElement OverrideValidationDialogOverrideby_2 { get { return WebDriver.GetElement(By.XPath("//button[text()='Override']")); } }


		public IWebElement ProductValidationErrorMessagesby_2 { get { return WebDriver.GetElement(By.Id("quoteCreate_Overridable_Validation_Messages")); } }


		public IWebElement BtnConnToOppCancel { get { return WebDriver.GetElement(By.XPath("//button[text()='Cancel']")); } }


		public IWebElement BtnConnToOppConnect { get { return WebDriver.GetElement(By.XPath("//button[text()='Connect Item']")); } }


		public IWebElement LblIncoorectAssoWarning { get { return WebDriver.GetElement(By.XPath("//p[contains(text(),'is not associated with')]")); } }



		public IWebElement LblSelectDestShippingGroup { get { return WebDriver.GetElement(By.XPath(".//*[contains(text(),'Select Destination Shipping Group')]")); } }

		//[FindsBy(How = How.XPath, Using = "//*[@class='moveItemPopup']//select")]
		//public IWebElement DropDwnShippingGroup;
		public IWebElement DropDwnShippingGroup { get { return WebDriver.GetElement(By.XPath("//*[@class='moveItemPopup']//select")); } }


		//[FindsBy(How = How.Id, Using = "btnApply")]
		//public IWebElement BtnMove;
		public IWebElement BtnMove { get { return WebDriver.GetElement(By.Id("btnApply")); } }



		public IWebElement BtnCancel { get { return WebDriver.GetElement(By.Id("btnCancel")); } }


		public IWebElement ShippingMethodChangeNotification { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'This item')]")); } }


		public IWebElement AddNewContactCancel { get { return WebDriver.GetElement(By.XPath("//button[@name='cancel']")); } }


		public IWebElement RateCardSummaryTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Rate Card Summary')]")); } }


		public IWebElement ErrorNotificationRenewal { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Please ensure your Install-At customer company number same as your Billing customer company number.')]")); } }


		public IWebElement DbcHeader { get { return WebDriver.GetElement(By.Id("quoteCreate_summary_dbc_header")); } }


		public IWebElement InfoDialogHeading { get { return WebDriver.GetElement(By.Id("dialog_heading")); } }


		public IWebElement ChangeInstallAtCustomer { get { return WebDriver.GetElement(By.Id("quoteCreate_GI_changeCustomer_installAt_0")); } }


		public IWebElement ChangeInstallAtCustomer2 { get { return WebDriver.GetElement(By.Id("quoteCreate_GI_changeCustomer_installAt_1")); } }

		public IWebElement CloudDimensionVxRailText { get { return WebDriver.GetElement(By.XPath("(//*[contains(text(), 'VMWare Cloud on DellEMC')])[1]")); } }

		public List<IWebElement> ExpandAddressLocation { get { return WebDriver.GetElements(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr/td/a")); } }


		public IWebElement AddressID { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[2]/td/add-component/change-address-expand-view/div/table/tbody/tr[8]/td[1]")); } }


		public IWebElement CAMLocationID { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[2]/td/add-component/change-address-expand-view/div/table/tbody/tr[8]/td[2]")); } }


		public IWebElement ItemLanguage { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[2]/td/add-component/change-address-expand-view/div/table/tbody/tr[4]/td[2]")); } }


		public IWebElement CFOLanguage { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[2]/td/add-component/change-address-expand-view/div/table/tbody/tr[4]/td[3]")); } }

		public IWebElement FavoriteTab { get { return WebDriver.GetElement(By.Id("change-address-dialog_address-grid_tab_favorite")); } }


		public IWebElement RelatedTab { get { return WebDriver.GetElement(By.Id("change-address-dialog_address-grid_tab_related")); } }


		public IWebElement InstallAtCustNum { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_installAt_0']/div[1]")); } }


		public IWebElement InstallAtChange { get { return WebDriver.GetElement(By.XPath(".//div[@id='quoteCreate_GI_shippingInformation_installAt_0']//a[@id='quoteCreate_shipment-0_chooseAddress']")); } }


		public IWebElement FilterSetValue { get { return WebDriver.GetElement(By.Id("customerParty_searchFilter_general_value")); } }


		public IWebElement LnkChangeQuoteLevelShippingCustomer { get { return WebDriver.GetElement(By.Id("quoteCreate_GI_changeCustomer_0")); } }

		public IWebElement AdditionalAddressFields { get { return WebDriver.GetElement(By.XPath("//*[@class='address-line2-extra-fields']")); } }

		public IWebElement FieldApartment { get { return WebDriver.GetElement(By.Id("apartment")); } }

		public IWebElement FieldBuilding { get { return WebDriver.GetElement(By.Id("building")); } }

		public IWebElement FieldDepartment { get { return WebDriver.GetElement(By.Id("department")); } }

		public IWebElement FieldSuite { get { return WebDriver.GetElement(By.Id("suite")); } }

		public IWebElement FieldFloor { get { return WebDriver.GetElement(By.Id("floor")); } }

		public IWebElement FieldRoom { get { return WebDriver.GetElement(By.Id("suite")); } }
		public IWebElement NotificationBuisnessCredit { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'please complete the Business Credit Application')]")); } }

		public IWebElement BtnBuisnessCredit { get { return WebDriver.GetElement(By.XPath("//div[contains(@class,'right-column-block')]//button[contains(text(),'Business Credit Application')]")); } }


		#region APOS ClearPrice 

		public IWebElement GetClearPriceValues(int index)
		{
			return WebDriver.GetElement(By.XPath("(//*[@id='quoteCreate_LI_configuration_details_0_0_0']//p[2])[" + index + "]"));
		}


		public IWebElement ClearPriceGuidanceLabel { get { return WebDriver.GetElement(By.XPath("//p[contains(text(), 'Clear Price Guidance')]")); } }


		public IWebElement ClearPriceDiscount { get { return WebDriver.GetElement(By.XPath("//p[contains(text(), 'POS Discount')]")); } }


		public IWebElement ClearPriceCurrencyCode { get { return WebDriver.GetElement(By.XPath("//p[contains(text(), 'POS Clear Price Currency')]")); } }

		public IWebElement DraftQuoteSalesRepChngNotification { get { return WebDriver.GetElement(By.XPath("//*[@id='notificationMessages_0']/span[2][contains(text(),'Primary Sales Rep on the quote (12345) is different from the Sales Rep on the Customer/Account (9999).')]")); } }

		#endregion


		#region PAM Elements


		public IWebElement PAMData { get { return WebDriver.GetElement(By.XPath("//*[@id='body-content']/div[2]//div//quote-create-navigation//customer-header//div//h5[2]//span")); } }

		#endregion

		By ValidationErrorMessagesby = By.XPath(".//div[contains(@data-ng-if,'Override')]//span[1]");

		By XPODErrorMessagesby = By.XPath(".//div[contains(@data-ng-if,'Override')]//span[contains(text(),'XPOD')]");

		By ProductValidationErrorMessagesby = By.Id("quoteCreate_Overridable_Validation_Messages");

		By OverrideButtonby = By.XPath(".//a[contains(text(),'Override')]");

		By OverrideValidationDialogCheckBoxby = By.XPath("//input[@data-ng-model='userAgreed']");

		By OverrideValidationDialogOverrideby = By.XPath("//button[text()='Override']");

		By CreateQuoteGSCVValidationby = By.Id("quoteCreate_GSCVValidation");

		By GSCVValidationWarningDialogYesButton = By.Id("messageDialogButton_0");

		By ApprovalNeededDailogby = By.XPath("//div[div[h3[contains(text(),'Approval needed')]]]");

		By DiscountLimitReached = By.Id("changeCustomer_title");

		By discountLimitReached_ok = By.Id("discountLimitReached_ok");

		By CreateQuoteOverrideValidationMessagesby = By.Id("quoteCreate_Overridable_Validation_Messages");

		By quoteCreate_XPOD_Validation_Messageby = By.Id("quoteCreate_XPOD_Validation_Message");



		public IWebElement LnkNewRequestGroupLevel(int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id((pagePrefix + "_GI_createNewGoalDealId_" + (groupIndex - 1))));
		}

		public IWebElement LnkPickFromListGroupLevel(int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id((pagePrefix + "_GI_selectGoalDealId_" + (groupIndex - 1))));
		}

		public int GetCadenceGridSummaryCount()
		{
			return WebDriver.FindElements(By.XPath("//table[@class='c-data-grid c-data-grid-table dataTable table-layout-fixed']")).Count;
		}

		public IWebElement ShippingMethodGroupLevel(int groupIndex = 0)
		{
			return WebDriver.GetElement(By.Id((pagePrefix + "_GI_" + (groupIndex) + "_shippingMethod")));
		}
		public IWebElement ChangeInstallCustomer(int Index)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_GI_changeCustomer_installAt_" + Index));
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

		#endregion

		#region Other Elements

		//[FindsBy(How = How.Id, Using = @"quoteCreate_customerNumber")]
		//public IWebElement TxtCustomerNumber { get; set; }
		public IWebElement TxtCustomerNumber { get { return WebDriver.GetElement(By.Id("quoteCreate_customerNumber")); } }


		public IWebElement LnkSearchForACustomer { get { return WebDriver.GetElement(By.Id("quoteCreate_searchCustomer")); } }


		public IWebElement LnkChooseCustomerFromAccount { get { return WebDriver.GetElement(By.Id("quoteCreate_chooseCustomer")); } }


		public IWebElement BtnSaveQuoteToggle { get { return WebDriver.GetElement(By.Id("quoteCreate_saveQuoteToggle")); } }


		public IWebElement ChangeAddressTable { get { return WebDriver.GetElement(By.Id("DataTables_div_gridChangeAddress")); } }
		public IWebElement ChangeAddressTableList { get { return WebDriver.GetElement(By.Id("DataTables_Table_gridChangeAddress")); } }

		public IWebElement UCIDColumn { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']//span[contains(text(), 'UCID')]")); } }


		public IWebElement TxtQuoteCopiedFrom { get { return WebDriver.GetElement(By.Id("quote_copiedFrom")); } }


		public IWebElement TxtOrderCopiedFrom { get { return WebDriver.GetElement(By.Id("order_copiedFrom")); } }


		//[FindsBy(How = How.Id, Using = @"quoteCreate_quoteName")]
		//public IWebElement TxtQuoteName { get; set; }
		public IWebElement TxtQuoteName { get { return WebDriver.GetElement(By.Id("quoteCreate_quoteName")); } }

		// [FindsBy(How = How.Id, Using = @"//*[@id='quoteCreate_expirationDate']/div/div/span/span/input")]
		//public IWebElement TxtExpirationDate { get; set; }


		public IWebElement TxtExpirationDate { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_expirationDate']/div/div[1]/span/span/input")); } }


		public IWebElement BtnAddNewContactShipping { get { return WebDriver.GetElement(By.Id("quoteCreate_shipment-1_addNewContact")); } }


		public IWebElement CreateQouteLang { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_language']")); } }


		public IWebElement createCustomerHearder { get { return WebDriver.GetElement(By.Id("currentCustomer_createCustomerHeaderLink2")); } }


		public IWebElement TxtQuoteExpirationDate { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_expirationDate']/div/div[1]/span/span/input")); } }


		public IWebElement IconExpirationDatePicker { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_expirationDate']//span[@class='k-icon k-i-calendar']")); } }


		public IWebElement TxtPoNumber { get { return WebDriver.GetElement(By.Id("quoteCreate_poNumber_input")); } }


		public IWebElement TxtLanguag { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_language']")); } }


		public IWebElement LanguageAfterSplitOrMerge { get { return WebDriver.GetElement(By.Id("quoteCreate_language")); } }

		//[FindsBy(How = How.ClassName, Using = "ng-pristine ng-valid ng-star-inserted ng-touched")]
		//public IWebElement LanguageAfterSplit { get; set; }


		public IWebElement LnkAsFrench { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_language']/option[2]")); } }


		public IWebElement LnkAsEnglish { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_language']/option[1]")); } }


		public IWebElement TxtSfdcDealId { get { return WebDriver.GetElement(By.Id("quoteCreate_dealId")); } }

		//[FindsBy(How = How.Id, Using = @"quoteCreate_endUserCustomerNumber")]
		//public IWebElement TxtEndUserCustomerNumber { get; set; }
		public IWebElement TxtEndUserCustomerNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_endUserCustomerNumber']")); } }


		public IWebElement LblEndUserNotBeSame { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_addEndUserInputGroup']/span")); } }


		public IWebElement ManualyLinkedDPID { get { return WebDriver.GetElement(By.XPath("//input[@placeholder='Enter DPID from canceled order']")); } }


		public IWebElement LnkSearchEndUserCustomer { get { return WebDriver.GetElement(By.Id("quoteCreate_selectEndUserCustomer")); } }


		public IWebElement ChkIcodedSkuOverride { get { return WebDriver.GetElement(By.Id("icode-override")); } }


		public IWebElement LnkCompanyName { get { return WebDriver.GetElement(By.Id("quoteCreate_createCustomerHeaderLink")); } }


		public IWebElement HdrAccountCustomerHeader { get { return WebDriver.GetElement(By.XPath("id('quoteCreate_accountCustomer')")); } }


		public IWebElement LnkCustomerName { get { return WebDriver.GetElement(By.XPath("id('quoteCreate_accountCustomer')/a[2]")); } }


		public IWebElement HdrCompanyNumberSegment { get { return WebDriver.GetElement(By.CssSelector(".segment-info")); } }


		public IWebElement LnkChangeCustomer { get { return WebDriver.GetElement(By.Id("quoteCreate_changeBillToCustomer")); } }


		public IWebElement BtnChangeCustomerConfirm { get { return WebDriver.GetElement(By.XPath("//button[@id = '_btn_ok' and contains(text(), 'Change Customer')]")); } }


		public IWebElement BtnConfirmSolutionEdit { get { return WebDriver.GetElement(By.XPath("//*[@id='_confirm']/mat-dialog-actions/div[2]//button[@id = '_btn_ok']")); } }


		public IWebElement BtnChangeCustomerCancel { get { return WebDriver.GetElement(By.XPath("//button[@id = '_btn_cancel' and contains(text(), 'Cancel')]")); } }


		public IWebElement LnkChangeQuoteLevelShipToCustomer { get { return WebDriver.GetElement(By.Id("quoteCreate_changeShipToCustomer")); } }


		public IWebElement DivDefaultShipToAddress { get { return WebDriver.GetElement(By.Id("quoteCreate_defaultShipToAddress")); } }


		public IWebElement DivDefaultBilliToAddress { get { return WebDriver.GetElement(By.Id("quoteCreate_defaultBillToAddress")); } }


		public IWebElement TxtAddCoupon { get { return WebDriver.GetElement(By.Id("quoteCreate_addCoupon")); } }


		public IWebElement LnkPickDifferentAddress { get { return WebDriver.GetElement(By.Id("quoteCreate_chooseAddress")); } }


		public IWebElement LnkQuoteLevelAddressesArrow { get { return WebDriver.GetElement(By.Id("quoteCreate_addresses_arrow")); } }



		public IWebElement LnkQuoteLevelChangeShipToAddress { get { return WebDriver.GetElement(By.Id("quoteCreate_shipping_chooseAddress")); } }



		public IWebElement LnkQuoteLevelSelectShipToAddress { get { return WebDriver.GetElement(By.Id("AddressSelectController_addressSelect_addressGrid_select")); } }

		//[FindsBy(How = How.XPath, Using = "/html/body/div[8]/div/div[2]/div[2]/div/table/tbody/tr[1]")]
		//public IWebElement LnkQuoteLevelSelectShipToAddressGetData { get; set; }


		public IWebElement LnkQuoteLevelGetDataShipToAddress { get { return WebDriver.GetElement(By.Id("quoteCreate_shipping_defaultAddress")); } }


		public IWebElement LnkAddQuoteLevelShippingAddress { get { return WebDriver.GetElement(By.Id("quoteCreate_shipping_newAddressLink")); } }


		public IWebElement DdlShippingMethod { get { return WebDriver.GetElement(By.Id("quoteCreate_shippingMethod")); } }


		public IWebElement LblEstimatedDeliveryDate { get { return WebDriver.GetElement(By.Id("quoteCreate_estimatedDeliveryDate")); } }


		public IWebElement MsgContractCodeMissing { get { return WebDriver.GetElement(By.XPath("//*[contains(@id, 'quoteCreate_contractMissingMsg')]")); } }

		//[FindsBy(How = How.XPath, Using = "//*[contains(@id , '_btn_ok')]")]

		public IWebElement BtnSetContractAsDefaultYes { get { return WebDriver.GetElement(By.XPath("//button[@id='_confirm_ok']")); } }


		public IWebElement BtnSetContractAsDefaultNo { get { return WebDriver.GetElement(By.XPath("//*[contains(@id , '_btn_cancel')]")); } }


		public IWebElement LnkCurrentCustomerCompanyName { get { return WebDriver.GetElement(By.Id("currentCustomer_createCustomerHeaderLink1")); } }


		public IWebElement WarningMABD { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-warning text-small']")); } }



		public IWebElement LnkCurrentCustomerCustomerName { get { return WebDriver.GetElement(By.Id("currentCustomer_createCustomerHeaderLink2")); } }

		//[FindsBy(How = How.Id, Using = "currentCustomer_customerNumber")]
		//public IWebElement TxtCurrentCustomerCustomerNumber { get; set; }
		public IWebElement TxtCurrentCustomerCustomerNumber { get { return WebDriver.GetElement(By.Id("currentCustomer_customerNumber")); } }



		public IWebElement TxtCurrentCustomerCompanyNumber { get { return WebDriver.GetElement(By.Id("currentCustomer_context")); } }

		//[FindsBy(How = How.Id, Using = @"quoteCreate_saveQuote")]
		//public IWebElement BtnSaveQuote { get; set; }
		public IWebElement BtnSaveQuote { get { return WebDriver.GetElement(By.Id("quoteCreate_saveQuote")); } }


		public IWebElement SalesRepIdOnQuote { get { return WebDriver.GetElement(By.Id("quoteCreate_salesRepNew")); } }


		public IWebElement ChangeButton { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[2]/td[15]/add-component/change-address-actions/a")); } }


		public IWebElement LnkQuoteLevelEditBillto { get { return WebDriver.GetElement(By.Id("quoteCreate_billing_editAddress")); } }


		public IWebElement LnkQuoteLevelEditSoldto { get { return WebDriver.GetElement(By.Id("quoteCreate_soldTo_editAddress")); } }

		public IWebElement ExpandAddress { get { return WebDriver.GetElement(By.XPath("//*[@id='qc - dp - address_accordion_header']/button/div")); } }
		                                                                             
		public IWebElement BtnSaveAsOrder { get { return WebDriver.GetElement(By.Id("quoteCreate_saveOrder")); } }


		public IWebElement CancelButton { get { return WebDriver.GetElement(By.Id("AddLocationDialog_cancel")); } }


		public IWebElement ExpandCustomerConsentScript { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Read Privacy Notice Script')]")); } }


		public IWebElement CustomerConsentScript { get { return WebDriver.GetElement(By.XPath("//div[@class='col-md-6']//div[@class='col-md-12']")); } }


		public IWebElement EditCustomerConsentScript { get { return WebDriver.GetElement(By.XPath("//div[@class='collapse in show ng-star-inserted']")); } }


		public IWebElement LangEnglish { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'English')] ")); } }


		public IWebElement LangFrench { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'French')] ")); } }



		public IWebElement BtnUpdateSmartPrice { get { return WebDriver.GetElement(By.Id("quoteCreate_updateSmartPrice")); } }


		public IWebElement RdbGenerateNewQuoteNumberFromCopyQuote { get { return WebDriver.GetElement(By.Id("quoteCreate_quote")); } }


		public IWebElement BtnCopyQuoteNext { get { return WebDriver.GetElement(By.Id("quoteCreate_next")); } }

		//[FindsBy(How = How.Id, Using = @"menu_productItems1")]
		//public IWebElement LblItemCountMastHead;
		public IWebElement LblItemCountMastHead { get { return WebDriver.GetElement(By.Id("menu_productItems1")); } }


		public IWebElement BtnCurrentQuote { get { return WebDriver.GetElement(By.Id("menu_currentQuote1")); } }


		public IWebElement Searchlnk { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_accordion_0_0']/div[3]/div/div[2]/div[3]/quote-create-line-item-contract/line-item-contract/div/div/div[1]/p/span/a")); } }


		public IWebElement ContractModalPopUp { get { return WebDriver.GetElement(By.XPath("//*[@class='modal-wrap goal-deal-select-modal goal-search-model']")); } }


		public IWebElement ContractModalPopUpColumn { get { return WebDriver.GetElement(By.Id("DataTables_Table_global_contract_grid")); } }


		public IWebElement ContractModalPopUpState { get { return WebDriver.GetElement(By.XPath("//*[@class='mg-btm-5']/div[1]/p")); } }


		public IWebElement ContractModalPopUpCompanyNumber { get { return WebDriver.GetElement(By.XPath("//*[@class='mg-btm-5']/div[2]/p")); } }


		public IWebElement ContractModalPopUpCusClass { get { return WebDriver.GetElement(By.XPath("//*[@class='mg-btm-5']/div[3]/p")); } }


		public IWebElement ContractModalPopUpDisclaimerText { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_accordion_0_0']/div[3]/div/div[2]/div[3]/quote-create-line-item-contract/line-item-contract/div[2]/contract-selector/div/div[3]/div[2]/span")); } }


		public IWebElement ContractModalPopUpContract { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_global_contract_grid']//input[1]")); } }


		public IWebElement BtnApplyContract { get { return WebDriver.GetElement(By.Id("btnApply")); } }


		public IWebElement AppliedContract { get { return WebDriver.GetElement(By.Id("global_contract_grid-0-")); } }


		public IWebElement IncorrectCustomerNotification { get { return WebDriver.GetElement(By.Id("_customerQuoteFailed_incorrectCustomer")); } }


		public IWebElement LnkCustomerInformationToggle { get { return WebDriver.GetElement(By.XPath("//h1[contains(text(),'Bill to Customer Information')]")); } }


		public IWebElement LblBillToCustomerStatus { get { return WebDriver.GetElement(By.Id("quoteCreate_billToCustomerStatus")); } }


		public IWebElement ImgValidatingQuoteBusyIndicator { get { return WebDriver.GetElement(By.CssSelector("#quoteDetail_header > div > div.section-header.pd-btm-5 > div.col-md-12.table-column-centered.mg-btm-10.mg-top-10.ng-scope > p > span > img")); } }


		public IWebElement LnkSplitQuoteCustomerFinancialInformationToggle { get { return WebDriver.GetElement(By.Id("quoteSplit_quoteCreate_billToCustomerFinancialInformationToggle")); } }
		public IWebElement LnkSplitQuoteCustomerFinancialInformationToggle1 { get { return WebDriver.GetElement(By.Id("quoteCreate_financialInformationHeading")); } }
		
		public IWebElement MsgQuoteLevelGoalDamValidation { get { return WebDriver.GetElement(By.Id("quoteCreate_dealValidationMessage")); } }



		public IWebElement BtnYesSubmitDamRequest { get { return WebDriver.GetElement(By.Id("closeApprovalRequest_Submit")); } }


		public IWebElement BtnNoContinueWorking { get { return WebDriver.GetElement(By.Id("closeApprovalRequest_NoSubmit")); } }


		public IWebElement DdlDamApprover { get { return WebDriver.GetElement(By.Id("damApproval_Approver")); } }


		public IWebElement ChkDamApprovalPriority { get { return WebDriver.GetElement(By.Id("damApproval_Priority")); } }


		public IWebElement TxtDamApprovalJustification { get { return WebDriver.GetElement(By.Id("damApproval_Justification")); } }


		public IWebElement BtnSubmitDamApproval { get { return WebDriver.GetElement(By.Id("closeApprovalRequest_Submit")); } }


		public IWebElement DivDamApprovalPopup { get { return WebDriver.GetElement(By.XPath("//*[@class='dsa-modal-wrap']")); } }


		public IWebElement PriceChangeNotificationMsg { get { return WebDriver.GetElement(By.CssSelector("p.ng-scope")); } }

		//[FindsBy(How = How.Id, Using = @"quoteCreate_addShippingGroup")]
		//public IWebElement AddShippingGroup;
		public IWebElement AddShippingGroup { get { return WebDriver.GetElement(By.Id("quoteCreate_addShippingGroup")); } }



		public IWebElement additems { get { return WebDriver.GetElement(By.Id("quoteCreate_additem_top_1_")); } }


		public IWebElement MoreActions { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'More Actions')]")); } }


		public IWebElement Bygroup { get { return WebDriver.GetElement(By.Id("quoteDetail_splitBy_byShippingGroup")); } }


		public IWebElement ByEDD { get { return WebDriver.GetElement(By.Id("quoteDetail_splitBy_byEDD")); } }


		public IWebElement ByItem { get { return WebDriver.GetElement(By.Id("quoteDetail_splitBy_byProduct")); } }


		public IWebElement BtnRemoveShippGrpConfirm { get { return WebDriver.GetElement(By.XPath("//button[contains(text(), 'Remove Shipping Group')]")); } }


		public IWebElement SaveAllButton { get { return WebDriver.GetElement(By.Id("quoteSplit_saveQuotes")); } }


		public IWebElement SaveAllLinkedQuotesButton { get { return WebDriver.GetElement(By.Id("quoteCreate_saveAllLinkedQuote")); } }
		// have defect to save the splited quote, once tat fixed will updated the code here tomorrow.

		public IWebElement SendAllButton { get { return WebDriver.GetElement(By.Id("SendAllButton")); } }




		public IList<IWebElement> RemoveCustomQuoteGroups { get { return WebDriver.GetElements(By.XPath("//*[@id='splitByQuantity_main']//div/a/i")); } }


		public IWebElement CustomeQuoteCancel { get { return WebDriver.GetElement(By.Id("quoteSplit_custom_cancel")); } }


		public IWebElement CustomGroupSplit { get { return WebDriver.GetElement(By.Id("quoteSplit_splitItems_bottom")); } }


		public IWebElement ReviewCustomQuotes { get { return WebDriver.GetElement(By.Id("quoteSplit_custom_reviewQuotes")); } }


		public IWebElement CustomSplit { get { return WebDriver.GetElement(By.Id("quoteDetail_splitBy_customSplit")); } }


		public IWebElement ExpandCollapseSku { get { return WebDriver.GetElement(By.XPath(".//a[@data-ng-if='item.IsSkuItemPresent']")); } }


		public IWebElement DisplayMessage { get { return WebDriver.GetElement(By.XPath(".//*[@class='alert-warning']")); } }


		public IWebElement ReviewQuote { get { return WebDriver.GetElement(By.Id("quoteDetail_reviewQuotes")); } }


		public IWebElement BtnServiceErrorOverride { get { return WebDriver.GetElement(By.CssSelector("#quoteCreate_GSCVValidation .row>div:nth-child(2) a")); } }


		public IWebElement MsgSwitchCatalogCustomer { get { return WebDriver.GetElement(By.XPath("//[@class='input-label ng-binding']")); } }


		public IWebElement ConfigOptionText { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_CS_category_build_category_0_0_0")); } }


		public IWebElement QuoteCreateLanguageDorpdown { get { return WebDriver.GetElement(By.Id("quoteCreate_language")); } }


		public IWebElement BtnServiceErrorOverrideYes { get { return WebDriver.GetElement(By.XPath("//button[text()='Yes']")); } }


		public IWebElement BtnServiceErrorOverrideYes1 { get { return WebDriver.GetElement(By.Id("_btn_ok")); } }


		public IWebElement BtnServiceErrorOverrideNo { get { return WebDriver.GetElement(By.XPath("//button[text()='No']")); } }


		public IWebElement BtnDiscountLimitReachedOk { get { return WebDriver.GetElement(By.Id("discountLimitReached_ok")); } }


		public IWebElement ValidationCustomerStatus { get { return WebDriver.GetElement(By.Id("validation_customerstatus")); } }


		public IWebElement CopyQuote { get { return WebDriver.GetElement(By.Id("quoteDetail_copyquote")); } }


		public IWebElement uploadtopom { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest")); } }


		public IWebElement SplitQuote { get { return WebDriver.GetElement(By.Id("quoteDetail_splitQuote")); } }


		public IWebElement BtnBillToCustomerFinancialInformation { get { return WebDriver.GetElement(By.Id("quoteCreate_financialInformationHeading")); } }


		public IWebElement BtnBillToCustomerInformation { get { return WebDriver.GetElement(By.XPath("//*[@class='ccpHeaderCollapsed']")); } }


		public IWebElement DdlQuoteCreateFinancialPaymentMethod { get { return WebDriver.GetElement(By.Id("quoteCreate_financingPaymentMethod")); } }


		public IWebElement BillToCompanyNumber { get { return WebDriver.GetElement(By.Id("quoteCreate_billToCompanyNumber")); } }


		public IWebElement BillToCompanyNumberClassCode { get { return WebDriver.GetElement(By.Id("quoteCreate_billToCustomerClass")); } }


		public IWebElement BillToCompanyState { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_billToAddress_section']//div[5]//span[2]")); } }


		public IWebElement DdlQuoteCreatePaymentTerm { get { return WebDriver.GetElement(By.Id("quoteCreate_paymentTerm")); } }


		public IWebElement CreateQuotePONumber { get { return WebDriver.GetElement(By.Id("quoteCreate_poNumber_input")); } }


		public IWebElement CreateQuotePrimarySalesRep { get { return WebDriver.GetElement(By.Id("quoteCreate_salesRepInfo")); } }

		// [FindsBy(How = How.Id, Using = "quoteSplit_salesRep")]
		// public IWebElement SplitQuotePrimarySalesRep;
		//[FindsBy(How = How.Id, Using = "quoteCreate_salesRep")]
		//public IWebElement SplitQuotePrimarySalesRep;


		public IWebElement SplitQuoteAddPrimarySalesRep { get { return WebDriver.GetElement(By.Id("quoteCreate_tagRepNew")); } }

		//[FindsBy(How = How.XPath, Using = "//*[@id='quoteCreate_GSCVValidation']/div/div[2]/a")]

		public IWebElement BtnOverrideGscvValidate { get { return WebDriver.GetElement(By.XPath("//*[contains(@id, 'quoteCreate_GSCVValidation')]//a")); } }


		public IWebElement DivGscvValidation { get { return WebDriver.GetElement(By.Id("quoteCreate_GSCVValidation")); } }


		public IWebElement BtnGscvValidationWarningYes { get { return WebDriver.GetElement(By.Id("_btn_ok")); } }


		public IWebElement BtnGscvValidationWarningNo { get { return WebDriver.GetElement(By.Id("_btn_cancel")); } }


		public IWebElement AddressLnk { get { return WebDriver.GetElement(By.XPath("//div[normalize-space()='Addresses']//a")); } }


		public IWebElement BtnCreateOderUsingDefaultSalesRep { get { return WebDriver.GetElement(By.CssSelector(".button-bar > button:nth-child(1)")); } }


		public IWebElement BtnCreateOderUsingLoggedInSalesRep { get { return WebDriver.GetElement(By.CssSelector(".button-bar > button:nth-child(2)")); } }


		public IWebElement CreateQuoteAddPrimarySalesRep { get { return WebDriver.GetElement(By.Id("quoteCreate_salesRepNew")); } }


		public IWebElement CreateQuoteEditPrimarySalesRep { get { return WebDriver.GetElement(By.Id("quoteCreate_primaryRepAdd")); } }


		public IWebElement CreateQuoteNewPrimarySalesRep { get { return WebDriver.GetElement(By.Id("quoteCreate_primaryRepAdd")); } }


		public IWebElement SalesRepPatchingError { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_salesRepInfo']/descendant::span")); } }


		public IWebElement BtnCustomerFinancialInformation { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_financialInformationHeading']/div/span[2]")); } }


		public IWebElement DblPaymentMethod { get { return WebDriver.GetElement(By.Id("quoteCreate_financingPaymentMethod")); } }


		public IWebElement RemoveCoupon { get { return WebDriver.GetElement(By.XPath("//*[@id='removeCoupon']/span")); } }


		public IWebElement LblArbExpDate { get { return WebDriver.GetElement(By.XPath("//label[@id='quoteCreate_expirationDate']")); } }


		public IWebElement CreateQuoteSummary { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_summary']/div")); } }

		//  [FindsBy(How = How.XPath, Using = ".//*[@id='quoteCreate_summary']/div/div/div[10]/div[1]/div/div/span")]

		public IWebElement LblQLOfflineMsg { get { return WebDriver.GetElement(By.XPath("//div[@class = 'smry-info pd-top-20']/div/div/span")); } }


		public IWebElement LblDFSEligible { get { return WebDriver.GetElement(By.Id("quoteCreate_dfsStatus")); } }


		public IWebElement BtnAddToQuote { get { return WebDriver.GetElement(By.XPath("//button[text()='Add To Quote']")); } }


		public IWebElement BtnEAPAddConfigueToQuote { get { return WebDriver.GetElement(By.XPath("(//button[@id='FlexBundlingRecommendation' or @id='AddConfigurationToQuote' or @id='AddRecommendationToQuote'])[1]")); } }


		public IWebElement BtnEAPnext { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Next')]")); } }


		public IWebElement ChkAllShippingGrp { get { return WebDriver.GetElement(By.Id("update-all-items-shipping-info-checkbox")); } }


		public IWebElement ApplyToAllQuotesChkBox { get { return WebDriver.GetElement(By.Name("QuoteUseForAllShippingGroups")); } }


		public IWebElement BtnFlexBundleConfigure { get { return WebDriver.GetElement(By.Id("FlexBundlingRecommendation")); } }
		#endregion

		//[FindsBy(How = How.Id, Using = "quoteCreate_financialInformationHeading")]
		//public IWebElement BtnBillToCustomerFinancialInformation;

		//[FindsBy(How = How.XPath, Using = "//*[@id='quoteCreate_financingPaymentMethod']/select")]
		//public IWebElement DdlQuoteCreateFinancialPaymentMethod;



		public IWebElement BtnSwitchCatalogCustomerYes { get { return WebDriver.GetElement(By.Id("_btn_ok")); } }


		public IWebElement BtnSwitchCatalogCustomerNo { get { return WebDriver.GetElement(By.Id("_btn_cancel")); } }


		public IWebElement BtnCloseCurrentQuoteYes { get { return WebDriver.GetElement(By.Id("messageDialogButton_0")); } }


		public IWebElement BtnCloseCurrentQuoteNo { get { return WebDriver.GetElement(By.Id("messageDialogButton_1")); } }


		public IWebElement BtnEditSolution { get { return WebDriver.GetElement(By.Id("quoteCreate_quoteSolution")); } }


		public IWebElement MsgBoxTitle { get { return WebDriver.GetElement(By.Id("dialog_heading")); } }


		public IWebElement LnkQuoteFlexbillingEligible { get { return WebDriver.GetElement(By.LinkText("Quote is subscription eligible")); } }


		public IWebElement DdlFlexBillingCadence { get { return WebDriver.GetElement(By.XPath("//select[@id='quoteCreate_cadence_1']")); } }


		public IWebElement QuoteSummaryHeader { get { return WebDriver.GetElement(By.Id("quoteCreate_summary_header")); } }


		public IWebElement QuoteSummaryHeaderCurrency { get { return WebDriver.GetElement(By.Id("quoteCreate_summary_header_currency")); } }


		public IWebElement SaveQuoteButton { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_saveQuote']/span")); } }


		public IWebElement PopupClose { get { return WebDriver.GetElement(By.XPath("//*[@id='_confirm']//a/span")); } }


		public IWebElement BillingNewAddressLink { get { return WebDriver.GetElement(By.XPath("//*[text()='Types']//following::input[1]")); } }


		public IWebElement ShippingNewAddressLink { get { return WebDriver.GetElement(By.XPath("//*[text()='Types']//following::input[2]")); } }


		public IWebElement MatchedMyAccountRecord { get { return WebDriver.GetElement(By.CssSelector("#COM > div.modal-small > div > div:nth-child(3) > div.modal-body > div:nth-child(2) > div")); } }


		public IWebElement FirstNameValue { get { return WebDriver.GetElement(By.Id("myaccount_first_name")); } }


		public IWebElement LastNameValue { get { return WebDriver.GetElement(By.Id("myaccount_last_name")); } }


		public IWebElement EmailAddressValue { get { return WebDriver.GetElement(By.Id("myaccount_email_address")); } }


		public IWebElement AddressLine1Value { get { return WebDriver.GetElement(By.Id("myaccount_address_line1")); } }


		public IWebElement CityValue { get { return WebDriver.GetElement(By.Id("myaccount_city")); } }


		public IWebElement ZipCodeValue { get { return WebDriver.GetElement(By.Id("myaccount_zip_code")); } }


		public IWebElement AddMyAccount { get { return WebDriver.GetElement(By.Id("_addMyAccountButton")); } }


		public IWebElement Cancel { get { return WebDriver.GetElement(By.Id("_cancel")); } }


		public IWebElement CloseDialogBox { get { return WebDriver.GetElement(By.XPath("//*[@id='_close']/span")); } }


		public IWebElement AddMyAccountPopUp { get { return WebDriver.GetElement(By.XPath("//*[@id='COM']/div[3]")); } }


		public IWebElement CheckboxEnableDellAdvantage { get { return WebDriver.GetElement(By.Id("myaccount_enable_dell_advantage")); } }


		public IWebElement CheckboxEmailOffers { get { return WebDriver.GetElement(By.Id("myaccount_include_offers")); } }


		public IWebElement LnkAddMyAccount { get { return WebDriver.GetElement(By.Id("quoteCreate_addMyAccount")); } }


		public IWebElement EmailSearchTextbox { get { return WebDriver.GetElement(By.Id("search_email_input")); } }


		public IWebElement BtnEmailSearch { get { return WebDriver.GetElement(By.Id("search_email")); } }


		public IWebElement ErrorMatchingAccount { get { return WebDriver.GetElement(By.Id("_emailSearchErrorSection")); } }


		public IWebElement AccountAlreadyExistsMessage { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'The info you entered matched an existing My Accoun')]")); } }


		public IWebElement ExpBillToCustomerInformation { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/quote-create-root/quote-create/div/div/div[1]/div[2]/quote-create-bill-to-customer-information/bill-to-customer-information/div[1]/h1")); } }


		public IWebElement LblSummaryLevelModifiedRevenue { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_GI_smartPrice_Revenue_']")); } }


		public IWebElement LblSummaryLevelPricingModifier { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_GI_with_pricing_modifier']")); } }


		public IWebElement LblSummaryLevelWithServicesIncentive { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_GI_with_service_incentive_']")); } }


		public IWebElement LblSummaryLevelDfsRevenuePrice { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_GI_revenue_Incentive_']")); } }


		public IWebElement LblSummaryLevelSellingPrice { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_summary_sellingPrice']")); } }



		public IWebElement ChangeShipToAddress { get { return WebDriver.GetElement(By.Id("quoteCreate_shipping_chooseAddress")); } }


		public IWebElement ChangeGroup1ShipToAddress { get { return WebDriver.GetElement(By.Id("quoteCreate_GI_changeAddress_0")); } }


		public IWebElement ApoFpoMessage { get { return WebDriver.GetElement(By.Id("notificationMessages_0")); } }


		public IWebElement AddressesTable { get { return WebDriver.GetElement(By.XPath("//*[@id='change-address-dialog_address-grid']")); } }


		public IWebElement BillPlanAgreements { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_serviceAccount_grid']")); } }


		public IWebElement AddressesTableCanada { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_addressInfo']/tbody")); } }


		public IWebElement DefaultShippingAddress { get { return WebDriver.GetElement(By.Id("quoteCreate_shipping_defaultAddress")); } }


		public IWebElement LblDfsStatus { get { return WebDriver.GetElement(By.Id("quoteCreate_dfsStatus")); } }


		public IWebElement LblLeaseGrid { get { return WebDriver.GetElement(By.Id("quoteCreate_summary_leaseProducts_header")); } }


		public IWebElement LnkCheckDfsCredit { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_header']/div/div[2]/div[3]/div/div[1]/div/div/div[4]/div/a")); } }


		public IWebElement BillToAddNewContact { get { return WebDriver.GetElement(By.Id("quoteCreate_billing_addNewContact")); } }


		public IWebElement LnkAddNewInstallAtCust { get { return WebDriver.GetElement(By.Id("quoteCreate_shipment-installAt0_addCustomer")); } }


		public IWebElement PostalCodeTxt_AddNewContact { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_addressInfo']//span[contains(text(), 'Postal Code')]")); } }


		public IWebElement ShippingGroup1InstallAt { get { return WebDriver.GetElement(By.Id("quoteCreate_GI_shippingInformation_installAt_0")); } }


		public IWebElement ProvinceTxt_AddNewContact { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_addressInfo']//span[contains(text(), 'Province')]")); } }


		public IWebElement SoldToAddNewContact { get { return WebDriver.GetElement(By.Id("quoteCreate_soldTo_addNewContact")); } }


		public IWebElement ShipToAddNewContact { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_shipment-0_addNewContact']")); } }


		public IWebElement AddNewContactInstallAt { get { return WebDriver.GetElement(By.XPath(".//*[@id='quoteCreate_groupAccordion_0']/div[3]//div[@class='dsaAccordion']//div[@id='quoteCreate_GI_shippingArea_0']/following-sibling::div[2]//div[@id='quoteCreate_GI_shippingInformation_installAt_0']//a[@id='quoteCreate_shipment-0_addNewContact']")); } }


		public IWebElement EditContactInstallAt { get { return WebDriver.GetElement(By.XPath(".//*[@id='quoteCreate_groupAccordion_0']/div[3]//div[@class='dsaAccordion']//div[@id='quoteCreate_GI_shippingArea_0']/following-sibling::div[2]//div[@id='quoteCreate_GI_shippingInformation_installAt_0']//a[@id='quoteCreate_shipment-0_editAddress']")); } }


		public IWebElement BilltoClose { get { return WebDriver.GetElement(By.Name("close")); } }


		public IWebElement SoldtoClose { get { return WebDriver.GetElement(By.Name("close")); } }


		public IWebElement ShiptoClose { get { return WebDriver.GetElement(By.Name("close")); } }

		public IWebElement PoLineNumber { get { return WebDriver.GetElement(By.XPath("//select[@id='_LI_poLineNumber_0_0']/option[2]")); } }


		public IWebElement Configurelink { get { return WebDriver.GetElement(By.XPath("//a[@id='quoteCreate_LI_configItem_0_0']")); } }



		public IWebElement QualifyShipMethodMessage { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'This product does not qualify for the Shipping Method you have selected.')]")); } }


		public IWebElement LnkClickHereQualifyShipMessage { get { return WebDriver.GetElement(By.XPath("//a[contains(text(),'Click here')]")); } }


		public IWebElement OverrideButton { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_rsInventoryValidation']/div/div[2]/button")); } }


		public IWebElement btnSaveQuote { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_saveQuote']")); } }
		public IWebElement ContractCode { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_LI_contractCode_input_1_1']")); } }
		public IWebElement NotifyCustomerHasBillPlan { get { return WebDriver.GetElement(By.XPath("//*contains(text(),'customer already has a bill plan for this usage based subscription')")); } }
		public IWebElement btnQuoteFlexbillingEligible { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Quote is subscription eligible')]")); } }

		public IWebElement ViewGrp { get => WebDriver.GetElement(By.Id("quoteCreate_viewAposGroups")); }

		public IWebElement CartItemsLnk
		{ get { return WebDriver.GetElement(By.Id("menu_productItems1")); } }

		public IWebElement RemoveItem_CartView_Link
		{ get { return WebDriver.GetElement(By.Id("RemoveItem_CartView_Link")); } }
		public IWebElement MobileCountryCode(int lineitemIndex)
		{
			return WebDriver.GetElements(By.XPath("phone-country-code/div/ul"))[lineitemIndex - 1];
		}

		public IWebElement CACountryCodeMobile(int LineItemIndex)
		{
			return WebDriver.GetElements(By.XPath("//ul[@class='phone-country-list ng-star-inserted']"))[lineitemIndex];
		}

		// Get the Area Code element
		public IWebElement PhoneAreaCode(int? index)
		{
			return WebDriver.GetElement(By.XPath("(//div[@class = 'phone-country-code-box'])[" + index + "]"));
		}

		// Get the list of Area Codes 
		public IWebElement SelectPhoneAreaCode(int? index)
		{
			return WebDriver.GetElement(By.XPath("//div[@class='cdk-overlay-pane']//li[" + index + "]"));
		}

		// Get and Set Area Code
		public void SetPhoneAreaCode(int? phoneIndex, int? areaCodeIndex)
		{
			PhoneAreaCode(phoneIndex).Click(WebDriver);
			SelectPhoneAreaCode(areaCodeIndex).Click(WebDriver);
		}

		public void CustomerAddMyAccount()
		{
			ExpBillToCustomerInformation.Click();
			LnkAddMyAccount.Click();
			AddMyAccountPopUp.Displayed.Should().BeTrue();
		}

		public CreateQuotePage movetoShipToAddNewContact() 
		{
			webDriver.ScrollToElement(ShipToAddNewContact);
			return new CreateQuotePage(WebDriver);
		}
		public void Contractcode(String Code)
		{
			ContractCode.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(15));
			ContractCode.SendKeys(Code);
			ContractCode.Click();
			ContractCode.SendKeys(Keys.Tab);
			WebDriver.VerifyBusyOverlayNotDisplayed();
		}


		public IWebElement FaxDropdown { get { return WebDriver.GetElement(By.XPath("(//div[@class = 'phone-country-code-box'])[3]")); } }


		public IWebElement MobileDropdown { get { return WebDriver.GetElement(By.XPath("(//div[@class = 'phone-country-code-box'])[1]")); } }


		public IWebElement WorkDropdown { get { return WebDriver.GetElement(By.XPath("(//div[@class = 'phone-country-code-box'])[2]")); } }


		public IWebElement SelectCountryCode { get { return WebDriver.GetElement(By.XPath("(//ul[@class='phone-country-list ng-star-inserted']")); } }


		public IWebElement CountryCodeMobile { get { return WebDriver.GetElement(By.XPath("(//div[@class='cdk-overlay-container']//li[4]")); } }


		public IWebElement MobileDropdownAddLocation { get { return WebDriver.GetElement(By.XPath("(//div[@class = 'phone-country-code-box'])[1]")); } }


		public IWebElement MobileDropdownAddNewContact { get { return WebDriver.GetElement(By.XPath("(//div[@class = 'phone-country-code-box'])[2]")); } }


		public IWebElement CountryCodeBillto { get { return WebDriver.GetElement(By.XPath("//div[@class='row top-offset-20']//div//div[1]//address[1]//div[1]//div[1]//div[1]//div[4]")); } }


		public IWebElement CountryCodeSoldto { get { return WebDriver.GetElement(By.XPath("//quote-create-header//div[@class='collapse in show']//div[2]//address[1]//div[1]//div[1]//div[1]//div[4]")); } }


		public IWebElement CountryCodeShipto { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_0']/div[3]/quote-create-shipping-group-address/div/div/div/address/div/div[1]/div/div[4]")); } }


		public IWebElement AddNewContactFirstName { get { return WebDriver.GetElement(By.XPath("//input[@id='AddNewContactComponent_first_name']")); } }


		public IWebElement AddNewContactLastName { get { return WebDriver.GetElement(By.XPath("//input[@id='AddNewContactComponent_last_name']")); } }


		public IWebElement AddNewContactMobilePhone { get { return WebDriver.GetElement(By.Name("mobilePhone")); } }


		public IWebElement AddNewContactWorkPhone { get { return WebDriver.GetElement(By.XPath("//input[@name='workPhone']")); } }


		public IWebElement AddNewContactEmail { get { return WebDriver.GetElement(By.Id("AddNewContactComponent_email")); } }



		public IWebElement CAAddNewContactEmail { get { return WebDriver.GetElement(By.XPath("//*[@id='AddNewContactComponent_email')")); } }


		public IWebElement SoldToAddNewContactEmail { get { return WebDriver.GetElement(By.Id("AddNewContactComponent_email")); } }


		public IWebElement AddNewContactSelectShippingAddress { get { return WebDriver.GetElement(By.XPath("//*[text()='Primary Shipping']//following::input[1]")); } }


		public IWebElement AddNewContactSelectBillingAddress { get { return WebDriver.GetElement(By.XPath("//*[text()='Primary Billing']//following::input[1]")); } }


		public IWebElement AddNewContactSaveButton { get { return WebDriver.GetElement(By.Id("AddNewContactComponent_saveContact")); } }


		public IList<IWebElement> first_last_name_from_address_txt { get { return WebDriver.GetElements(By.CssSelector("address:not([baseelementid]) .address-block>.show-with-text")); } }


		public IList<IWebElement> phone_number_txt { get { return WebDriver.GetElements(By.CssSelector("address:not([baseelementid]) .address-block>div:nth-child(4)")); } }


		public IList<IWebElement> email_address_txt { get { return WebDriver.GetElements(By.CssSelector("address:not([baseelementid]) .address-block>div:nth-child(5)")); } }


		public IWebElement ExportProductUsage { get { return WebDriver.GetElement(By.Id("exportComplianceEndUse")); } }

		public IWebElement ExportComplianceLink { get { return WebDriver.GetElement(By.Id("exportComplianceViewLink")); } }

		public IWebElement GTPId { get { return WebDriver.GetElement(By.Id("gtpId")); } }

		public IWebElement GTPIdLink { get { return WebDriver.GetElement(By.Id("gtpToolLink")); } }

		public IWebElement EndUseRequiredErrNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'The export compliance end-use is required.')]")); } }

		public IWebElement GtpIdRequiredWarningNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'The selected export compliance end-use requires a GTP ID to create order.')]")); } }


		public IWebElement GtpValidationMessage { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Valid GTP ID should be entered.')]")); } }


		public bool verifyContactFromShippingAddress(string expectedValue)
		{
			delay(5);
			bool flag = true;
			foreach (IWebElement el in first_last_name_from_address_txt)
			{
				Console.WriteLine(el.Text.Trim().Equals(expectedValue));
				if (!el.Text.Trim().Equals(expectedValue))

					flag = false;
			}
			return flag;
		}

		public bool verifyUpdatedEmailandPhoneFromShippingAddress(string firstExpectedValue, string secondExpectedValue)
		{
			delay(5);
			if (verifyPhoneNumberInShippingAddress(secondExpectedValue) == true && verifyEmailAddressInShippingAddress(firstExpectedValue) == true)
			{

				return true;
			}
			return false;
		}

		private bool verifyPhoneNumberInShippingAddress(string expectedValue)
		{
			bool flag = true;
			foreach (IWebElement el in phone_number_txt)
			{
				string phonenumber = el.Text;
				phonenumber = phonenumber.Substring(3, phonenumber.Length - 3).Replace("-", "").Replace(") ", "");
				if (!phonenumber.Trim().Equals(expectedValue))

					flag = false;
			}
			return flag;
		}

		private bool verifyEmailAddressInShippingAddress(string expectedValue)
		{
			bool flag = true;
			foreach (IWebElement el in email_address_txt)
			{
				if (!el.Text.Trim().Equals(expectedValue))
					flag = false;
			}
			return flag;
		}

		//[FindsBy(How = How.Id, Using = "_addCustomer")]

		public IWebElement AddNewShipTo { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_shipment-0_addCustomer']")); } }

		// Add New Ship To customer

		public IWebElement AddNewShipToCompName { get { return WebDriver.GetElement(By.Id("createFormComponent_company_name")); } }


		public IWebElement CreateThisNewCustomer { get { return WebDriver.GetElement(By.Id("createCustomerDuplicateCustomersDialog_entered_save")); } }


		public IWebElement AddNewShipToCompPhone { get { return WebDriver.GetElement(By.Id("createFormComponent_company_phone")); } }


		public IWebElement AddNewShipToFirstName { get { return WebDriver.GetElement(By.Id("contact_firstName")); } }


		public IWebElement BtnUseInQuoteAsInstallAtCustomer { get { return WebDriver.GetElement(By.Id("customerDetails_installAt")); } }


		public IWebElement AddNewShipToLastName { get { return WebDriver.GetElement(By.Id("contact_lastName")); } }


		public IWebElement AddNewShipToInvoicingEmail { get { return WebDriver.GetElement(By.Id("contact_invoicingEmailAddress")); } }


		public IWebElement AddNewShipToMobilePhone { get { return WebDriver.GetElement(By.Id("contact_mobilePhone")); } }


		public IWebElement AddNewShipToAddressLine1 { get { return WebDriver.GetElement(By.Id("address_line1")); } }


		public IWebElement AddNewShipToZipCode { get { return WebDriver.GetElement(By.Id("address_postalCode")); } }


		public IWebElement AddNewShipToZipCodePlusExt { get { return WebDriver.GetElement(By.Id("address_postalCodeExtension")); } }


		public IWebElement AddNewShipToSaveBtn { get { return WebDriver.GetElement(By.XPath("//*[text()='Save']")); } }


		public IWebElement ShippingGrp1CustNum { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_0']/div[1]")); } }


		public IWebElement AddShippingAddressCompName { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_companyName")); } }


		public IWebElement AddShippingAddressFirstName { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_firstName")); } }


		public IWebElement AddShippingAddressLastName { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_lastName")); } }


		public IWebElement AddShippingAddressEmail { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_email")); } }


		public IWebElement Close { get { return WebDriver.GetElement(By.Name("close")); } }


		public IWebElement AddShippingAddressLine1 { get { return WebDriver.GetElement(By.Name("address1")); } }


		public IWebElement AddShippingAddressLine2 { get { return WebDriver.GetElement(By.Name("address2")); } }


		public IWebElement AddShippingAddressCity { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_city")); } }


		public IWebElement AddShippingAddressState { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_state")); } }


		public IWebElement AddShippingAddressZipCode { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_zipCode")); } }


		public IWebElement AddShippingAddressPrimaryPhone { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_primaryPhone")); } }


		public IWebElement AddShippingAddressSaveBtn { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_save")); } }


		public IWebElement AdddressSuggestionAddShippingAddress { get { return WebDriver.GetElement(By.Id("AddressSuggestionsDialog_addShippingAddress_select")); } }


		public IWebElement VerifiedAddressesRadioBtn { get { return WebDriver.GetElement(By.XPath("(//*[@id='customerDetails_validateAddress_shippingAddress_validation_withSuggestion']//input)[2]")); } }


		public IWebElement AddShippingAddressZipExtension { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_zipCodeExtension")); } }


		public IWebElement SuggestedAddressSelect { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_addShippingAddress_select")); } }


		public IWebElement HdrCannotValidateAddress { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_shippingAddress_validationMessage_header")); } }


		public IWebElement QuoteShippingGroup1 { get { return WebDriver.GetElement(By.Id("quoteCreate_GI_shippingArea_0")); } }

		public IWebElement QuoteBillingGroup1 { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/quote-create-root/quote-create/div/div/div[1]/quote-create-header/div[5]/div/quote-create-dell-print-address/div/div/div[2]/div[1]/address")); } }

		public IWebElement QuoteSoldToGroup1 { get { return WebDriver.GetElement(By.XPath("//quote-create-header/div[5]/div[1]/quote-create-dell-print-address[1]/div[1]/div[1]/div[2]/div[2]/address[1]")); } }

		public IWebElement QuoteShippingGroup1Install { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_0']")); } }


		public IWebElement ShippingGroupDetails { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_0']")); } }


		public IWebElement ShippingGroup1 { get { return WebDriver.GetElement(By.Id("quoteCreate_group_0")); } }


		public IWebElement ShippingGroup1Address { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_0']/div[3]/quote-create-shipping-group-address/div/div/div/address/div/div[1]/div/div[3]")); } }


		public IWebElement ShippingGroup2Address { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_1']/div[3]/quote-create-shipping-group-address/div/div/div/address/div/div[1]/div/div[3]")); } }


		public IWebElement ShippingGroup2 { get { return WebDriver.GetElement(By.Id("quoteCreate_group_1")); } }


		public IWebElement ShippingGroup3 { get { return WebDriver.GetElement(By.Id("quoteCreate_group_2")); } }


		public IWebElement ShippingGroup1ShippingItem1 { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_cssiNumber_0_0")); } }


		public IWebElement ShippingGroup1ShippingItem2 { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_cssiNumber_0_1")); } }


		public IWebElement ShippingItem { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_LI_cssiNumber_0_0']")); } }

		//[FindsBy(How = How.Id, Using = "currentCustomer_createCustomerHeaderLink1")]
		//public IWebElement currCustomerHeaderlink;
		public IWebElement currCustomerHeaderlink { get { return WebDriver.GetElement(By.Id("currentCustomer_createCustomerHeaderLink1")); } }


		public IWebElement lblQuoteIdText { get { return WebDriver.GetElement(By.Id("quote-create-hidden-cartdata")); } }


		public IWebElement CustomerStatusNotification { get { return WebDriver.GetElement(By.XPath("//*[@id='notificationMessages_0']/span[2]")); } }


		public IWebElement invalidCustomerNotification { get { return WebDriver.GetElement(By.CssSelector("#QuoteCreateForm > div:nth-child(1) > span")); } }


		public IWebElement POboxValidationMsg { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'PO box')]")); } }


		public IWebElement SolutionNameInputField { get { return WebDriver.GetElement(By.Id("solutionName_input")); } }


		private IWebElement iCodeOverridMessageElement { get { return WebDriver.GetElement(By.XPath("(//span[contains(text(),'I coded item')]")); } }

		By ICodeOverridMessage = By.XPath(".//*[contains(text(),'I code override')]");


		public IWebElement SAOemailvalidationmsg { get { return WebDriver.GetElement(By.XPath("//span[normalize-space()='Unable to prepare order as a shipping location is missing the email address.'] ")); } }

		//[FindsBy(How = How.Id, Using = "icode-override")]
		//public IWebElement ICodeOverrideChkBox;
		public IWebElement ICodeOverrideChkBox { get { return WebDriver.GetElement(By.Id("icode-override")); } }


		public IWebElement SAOphonenumbervalidationmsg { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'do not have a phone number')]")); } }


		public IWebElement LnkCustomerFinancialInformationToggle { get { return WebDriver.GetElement(By.XPath("//*[contains(@id, '_financialInformationHeading')]")); } }


		public IWebElement closeAddresspopup { get { return WebDriver.GetElement(By.ClassName("icon-ui-close")); } }


		public IWebElement warningMessageDiffAddress { get { return WebDriver.GetElement(By.Id("_address_notification")); } }


		public IWebElement ExpandInstallationInstruction { get { return WebDriver.GetElement(By.Id("quoteCreate_installationinstructionsToggle")); } }


		public IWebElement TxtInstallationInstruction { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_installationinstructions']")); } }


		public IWebElement ClickViewMore { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='View More']")); } }


		public IWebElement ClickServiceTag { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_LI_arrow__0_0_0']")); } }


		public IWebElement UnitSellingPrice { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_LI_configuration_rows']//div[contains(text(),'$')]")); } }


		public IWebElement LnkChangeQuoteLevelSoldToCustomer { get { return WebDriver.GetElement(By.Id("quoteCreate_changeSoldToCustomer")); } }


		public IWebElement ChangeBillToAddress { get { return WebDriver.GetElement(By.Id("quoteCreate_billing_chooseAddress")); } }


		public IWebElement FilterChangeAddress { get { return WebDriver.GetElement(By.Id("customerParty_generalFilter")); } }


		public IWebElement ChangeBillAddressModal { get { return WebDriver.GetElement(By.ClassName("cdk-overlay-pane")); } }


		public IWebElement ChangeSoldToAddress { get { return WebDriver.GetElement(By.Id("quoteCreate_soldTo_chooseAddress")); } }


		public IWebElement ChangeBillAddressPaginated { get { return WebDriver.GetElement(By.ClassName("//*[@id='change-address-dialog_address-grid']/div[4]/paginated-list")); } }


		public IWebElement QuoteSoldToInfo { get { return WebDriver.GetElement(By.Id("quoteCreate_soldToCustomer_intro")); } }


		public IWebElement QuoteShipToInfo { get { return WebDriver.GetElement(By.Id("quoteCreate_shipToCustomer_intro")); } }


		public IWebElement AddressSuggestionPopup { get { return WebDriver.GetElement(By.Id("AddressSuggestionsDialog")); } }


		public IWebElement UseOriginalAddress { get { return WebDriver.GetElement(By.XPath("//button[@id='AddressSuggestionsDialog_addShippingAddress_useOriginal']")); } }


		public IWebElement ConfirmYesBtn { get { return WebDriver.GetElement(By.XPath("//*[text()='Yes']")); } }


		public IWebElement RemoveItemButton { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_removeItem_0_0")); } }


		public IWebElement BtnClickMoreRecommendedTab { get { return WebDriver.GetElement(By.XPath(".//*[@id='quoteCreate_accordionMore_0']/div/div[2]/div/div[2]/div[1]/div[3]/a[2]")); } }


		public IWebElement MoreInformation { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_accordionMore_0']/div/div[2]/div/div[2]/div[1]/div[3]/div/div[1]/div[1]/div/div[2]/a/h5")); } }


		public IWebElement CopyAddressBillto { get { return WebDriver.GetElement(By.Id("EditContactDialog_copy")); } }


		public IWebElement BillingNewAddressLinks { get { return WebDriver.GetElement(By.Id("quoteCreate_billing_newAddressLink")); } }


		public IWebElement BillingAddNewAddressLink { get { return WebDriver.GetElement(By.Id("quoteCreate_billing_addNewAddress")); } }

		public IWebElement ContractValidationMessage { get { return WebDriver.GetElement(By.Id("contract_invalid_message")); } }


		public IWebElement LinkedDpid { get { return WebDriver.GetElement(By.Id("quoteCreate_linkedDpId")); } }


		public IWebElement ValidationMessage { get { return WebDriver.GetElement(By.XPath("//*[normalize-space()='Invalid DPID']")); } }

		//[FindsBy(How = How.XPath, Using = "//label[contains(text(),'Payment Terms')]/../div")]
		//public IWebElement PaymentTerms;
		public IWebElement PaymentTerms { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Payment Terms')]/../div")); } }



		public IWebElement PatchedDNC { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'quoteCreateLI_D_discountName_')]")); } }

		//[FindsBy(How = How.XPath, Using = "//*[@id='quoteCreate_title_draftquote']//small")]
		//public IWebElement LblDraftQuoteNumber;
		public IWebElement LblDraftQuoteNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_title_draftquote']//small")); } }


		public IWebElement LblCreateQuoteTitle { get { return WebDriver.GetElement(By.Id("quoteCreate_title_createQuote")); } }


		public IWebElement LblDraftQuoteTitle { get { return WebDriver.GetElement(By.Id("quoteCreate_title_draftquote")); } }


		public IWebElement LblRebookOrderTitle { get { return WebDriver.GetElement(By.Id("quoteCreate_title_rebookOrder")); } }


		public IWebElement LblUpdateOrderTitle { get { return WebDriver.GetElement(By.Id("quoteCreate_title_updateOrder")); } }


		public IWebElement DeleteFieldConfirm { get { return WebDriver.GetElement(By.Id("ccf_submit")); } }


		public IWebElement UpdateAllFields { get { return WebDriver.GetElement(By.XPath("//button[contains(text(), 'Update All Fields')]")); } }


		public IWebElement CustomFieldsDialog { get { return WebDriver.GetElement(By.XPath("//custom-checkout-fields-dialog")); } }


		public IWebElement DeleteAllFields { get { return WebDriver.GetElement(By.XPath("//button[contains(text(), 'Delete All Fields')]")); } }


		public IWebElement ApplyChanges { get { return WebDriver.GetElement(By.XPath("//button[contains(text(), 'Apply Changes')]")); } }

		//button[@id = 'quoteCreate_expandCollapseAllGroups']


		public IWebElement CollapseAll { get { return WebDriver.GetElement(By.XPath("//button[@id = 'quoteCreate_expandCollapseAllGroups']")); } }


		public IWebElement MonthMABDcalendar { get { return WebDriver.GetElement(By.XPath("//common-date-picker//button[contains(@id, 'datepicker')]")); } }


		public IWebElement GoRightMABDcalendar { get { return WebDriver.GetElement(By.XPath("//common-date-picker//button[contains(@class, 'pull-right')]")); } }


		public IWebElement IcodeOverrideLbl { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'I-Code Override')]")); } }


		public IWebElement ShippingErrorNotif { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_accordion_0_0']/div[2]/quote-create-line-item-notification/div/div/div/div/p/span")); } }


		public IWebElement ViewDFSDetails { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'View DFS Details')]")); } }


		public IWebElement ViewDFSError { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-warning error']")); } }


		public IWebElement SummaryTotalTaxtPending { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_summary_totalTax_section']/tax-summary/div/span")); } }


		public IWebElement SummaryEcoFeePending { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_summary_totalEhf_section']/ehf-summary/div/span")); } }


		public IWebElement SummaryTotalAmountPending { get { return WebDriver.GetElement(By.XPath("//*[@id='GMOR_terms_of_sale_anchor']/div[4]/span[2]")); } }

		public IWebElement TermsConditions { get { return WebDriver.GetElement(By.XPath("//*[@id='GMOR_terms_of_sale_anchor']/div[4]/span[2]")); } }


		public IWebElement SGTotalTaxPending { get { return WebDriver.GetElement(By.Id("quoteCreate_GI_tax_0")); } }


		public IWebElement SGEcoFeePending { get { return WebDriver.GetElement(By.Id("quoteCreate_GI_ehf_0")); } }


		public IWebElement SGTotalAmountPending { get { return WebDriver.GetElement(By.Id("quoteCreate_GI_totalAmount_0")); } }


		public IWebElement SummaryCalculateTaxButton { get { return WebDriver.GetElement(By.XPath("//*[@id='GMOR_terms_of_sale_anchor']/button")); } }


		public IWebElement LnkDfsDetails { get { return WebDriver.GetElement(By.Id("declineScript")); } }


		public IWebElement lblPFLSFDCvalue { get { return WebDriver.GetElement(By.XPath("//p[normalize-space()='SFDC Deal ID']/../span")); } }


		public IWebElement lblPFLEndUserAccountvalue { get { return WebDriver.GetElement(By.XPath("//p[normalize-space()='End User Account']/../span")); } }


		public IWebElement ReadyStockIQcheckbox { get { return WebDriver.GetElement(By.Id("ready-stock-quote-readyStockIQ")); } }


		//public IWebElement SubscriptionBillingFlyout { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'Subscription Billing')]")); } }
		public IWebElement SubscriptionBillingFlyout { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Subscription Billing')]")); } }

		public IWebElement OfferSubscriptionDisclosureTxt { get { return WebDriver.GetElement(By.XPath("//div[contains(text(), 'Offer Subscription Disclosures and Terms and Conditions')]")); } }


		public IWebElement SkuLevelDisclosureTxt { get { return WebDriver.GetElement(By.XPath("//div[contains(text(), 'SKU Level Disclosures')]")); } }


		public IWebElement BackbuttonSubscriptionBillingFlyout { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'Back')]")); } }


		public IWebElement Notification { get { return WebDriver.GetElement(By.XPath("//div[@class='alert-error']")); } }


		public IWebElement WarrantiesNotificationQuotePage { get { return WebDriver.GetElement(By.XPath("//*[@id='notificationMessages_0']/span[2]")); } }


		public IWebElement WarrantiesNotificationConfigPage { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-info alert-close top-offset-10 ng-star-inserted']//span[1]")); } }


		public IWebElement FlyoutTermsandConditionsArrow { get { return WebDriver.GetElement(By.XPath("//*[@id='review-subscription-billing']//div[@class='collapsible-arrow-icon'][1]")); } }


		public IWebElement FlyoutTermsandConditionsLink { get { return WebDriver.GetElement(By.XPath("//*[@id='review-subscription-billing']//a[contains(text(),'Terms and Conditions')][1]")); } }


		public IWebElement BillPlanID { get { return WebDriver.GetElement(By.CssSelector("#review-subscription-billing > div > div > div > div > div:nth-child(2) > div > h5")); } }


		public IWebElement PaymentType { get { return WebDriver.GetElement(By.XPath("//*[@id='review-subscription-billing']//p[@class=' text-right']")); } }


		public IList<IWebElement> ServiceTypes { get { return WebDriver.GetElements(By.XPath("//*[@id='review-subscription-billing']//h5/strong")); } }


		public IList<IWebElement> ItemNotifications { get { return WebDriver.GetElements(By.XPath("//quote-create-line-item-notification")); } }


		public IWebElement BtnApplyAll { get { return WebDriver.GetElement(By.Id("_btn_ok")); } }


		public IWebElement ContractPopUp { get { return WebDriver.GetElement(By.Id("_confirm")); } }


		public IWebElement RemoveSolutionNameConfirmation { get { return WebDriver.GetElement(By.XPath("//*[@id='_confirm']//span[contains(text(), 'By removing solution name, you will also remove Install At address, unless you have a CO-IP/EMC item added.  Do you want to remove?')]")); } }


		public IWebElement BtnMoveToNewShipGrp { get { return WebDriver.GetElement(By.Id("_btn_cancel")); } }


		public IWebElement TxtContractInfo { get { return WebDriver.GetElement(By.XPath("//*[@id='_confirm']/mat-dialog-content/span")); } }


		public IWebElement LblDealIdStageName { get { return WebDriver.GetElement(By.XPath("//div[text()='Stage Name:']")); } }


		public IWebElement LblDealIdStageValue { get { return WebDriver.GetElement(By.XPath("//div[text()='Stage Name:']/span")); } }


		public IWebElement SoldToEmailMissing { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'The sold to contact is missing a valid email address.')]")); } }


		public IWebElement BillToEmailMissing { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'The billing contact is missing a valid email address.')]")); } }


		public IWebElement ShipToEmailMissing { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'The shipping contact is missing a valid email address.')]")); } }


		public IWebElement LblDealIdBookDateName { get { return WebDriver.GetElement(By.XPath("//div[text()='Book Date:']")); } }


		public IWebElement LblDealIdBookDateValue { get { return WebDriver.GetElement(By.XPath("//div[text()='Book Date:']/span")); } }


		public IWebElement LblDealIdSPNotificationMsg { get { return WebDriver.GetElement(By.Id("sfdcNotificationMessages_0")); } }



		public IWebElement LblSpPopupCondiMsgBlock1 { get { return WebDriver.GetElement(By.XPath("(//button[@class='smp-val-close']/..//div[@class='conditionalMsg'])[1]")); } }



		public IWebElement NumberofItems { get { return WebDriver.GetElement(By.XPath("//a[@id = 'menu_productItems1']")); } }


		public IWebElement Promotions1 { get { return WebDriver.GetElement(By.XPath("(//span[@id='quoteCreate_D_Promos_-'])[1]")); } }


		public IWebElement Promotions2 { get { return WebDriver.GetElement(By.XPath("(//span[@id='quoteCreate_D_Promos_-'])[1]")); } }


		public IWebElement QuoteSummaryListPrice { get { return WebDriver.GetElement(By.Id("quoteCreate_summary_listPrice")); } }


		public IWebElement TblOppList { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_opportunityLine_productGrid']")); } }


		public IWebElement EndUserValidationMsgForDifferentBUID { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'End User Customer Number not valid for this business unit.')]")); } }


		public IWebElement EndUserValidationMsgForSameCustomer { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'Please ensure your end user customer number is not the same as your current customer number.')]")); } }


		public IWebElement EndUserValidationMsg { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'Please ensure your End User customer company number matches your current customer company number.')]")); } }

		public IWebElement SetDates { get { return WebDriver.GetElement(By.XPath("//tabset//li[3]")); } }


		public IWebElement SkuUpgradeandExt { get { return WebDriver.GetElement(By.XPath("//tabset/div/tab[3]/set-dates/div/div[2]/div/div/a/div[2]/span")); } }


		public IWebElement YearMinus { get { return WebDriver.GetElement(By.XPath("//form/div[1]/input-integer/span/button[1]")); } }


		public IWebElement MonthPlus { get { return WebDriver.GetElement(By.XPath("//form/div[2]/input-integer/span/button[2]")); } }


		public IWebElement SalesHoldErrorNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Customer is on a Sales Hold')]")); } }


		public IWebElement SetDatesApply { get { return WebDriver.GetElement(By.Id("apos_setDates_item_apply")); } }


		public IWebElement CopyAsNewQuote { get { return WebDriver.GetElement(By.XPath("//a[contains(text(), 'Copy as New Quote')]")); } }


		public IWebElement EndUserCustomerNumberId { get { return WebDriver.GetElement(By.Id("quoteCreate_endUserCustomerNumber")); } }

		public IWebElement linkwalkme { get { return WebDriver.GetElement(By.XPath("//*[@id='walkme - player']")); } }

		public IWebElement linkwalkmePlayerMax { get { return WebDriver.GetElement(By.XPath("(//div[@class = 'walkme-arrow walkme-override walkme-css-reset'])[1]")); } }

		public IWebElement linkwalkmeTitle { get { return WebDriver.GetElement(By.XPath("(//div[@class = 'walkme-css-reset walkme-animation-hide walkme-title walkme-override walkme-css-reset'])")); } }

		public IWebElement linkwalkmePlayerMin { get { return WebDriver.GetElement(By.XPath("(//div[@class = 'walkme-minimize walkme-icon-font walkme-menu-click-close walkme-animation-hide walkme-override walkme-css-reset'])")); } }

		public IWebElement walkmeContractDiv { get { return WebDriver.GetElement(By.XPath("//*[@id='walkme-visual-design-dbbe87d645aafd469ec95bd000bf5fb7']")); } }

		public IWebElement walkmeContractDivClose { get { return WebDriver.GetElement(By.XPath("//*[@id='walkme-visual-design-dbbe87d645aafd469ec95bd000bf5fb7']//button")); } }

		public IWebElement walkmeContractwalkmeClose { get {return WebDriver.GetElement(By.XPath("//*[@class='wm-ignore-css-reset']"));} }

		public void CheckContractWalkMeVisibleOrNot()
		{
			if (walkmeContractDiv != null)
			{
				walkmeContractDivClose.Click();
			}
		}

		public IWebElement UnitListPrice { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_LI_0_0_0_panel']/div/div[2]/div[5]")); } }


		public IWebElement Unit_SellingPrice { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_LI_0_0_0_panel']/div/div[2]/div[6]")); } }


		//public IWebElement LnkViewAsStandardQuote { get { return WebDriver.GetElement(By.LinkText("View as Standard Quote")); } }
		public IWebElement LnkViewAsStandardQuote { get { return WebDriver.GetElement(By.XPath("//*[text()='View as Standard Quote']")); } }


		public IWebElement ReviewChecklistFlyout { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Review Checklist')]")); } }


		public IWebElement Txt847Module { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'847')]")); } }


		public IWebElement SetupFeeToggle { get { return WebDriver.GetElement(By.Id("productConfig_option_0_ModularServicesReserved18_toggle")); } }


		public IWebElement SetupFee { get { return WebDriver.GetElement(By.Id("productConfig_ModularServicesReserved18_selection_0")); } }


		public IWebElement FlyoutSetupFeeToggle { get { return WebDriver.GetElement(By.Id("quoteCreate_serviceTagsToggle")); } }


		public IWebElement TxtSetUpFee { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Subscription Setup Fee')]")); } }


		public IWebElement ReInstatementFee { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Re Instatement Fee:')]")); } }


		public IWebElement ETF { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Early Termination Fee')]")); } }


		public IWebElement BtnApply { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Apply')]")); } }


		public IWebElement Status_AddNewContact { get { return WebDriver.GetElement(By.XPath("//*[@id='mat-dialog-1']//add-new-contact//form//div//select-address-grid//div[2]//div//select")); } }


		public IWebElement AddressTableAddNewContact { get { return WebDriver.GetElement(By.Id("DataTables_Table_addressInfo")); } }


		public IWebElement SubscriptionBillingData { get { return WebDriver.GetElement(By.XPath("//table[@class='c-data-grid c-data-grid-table dataTable table-layout-fixed']")); } }

		public IWebElement GetSkuSummaryGrid(int? summaryGridIndex)
		{
			return WebDriver.FindElement(By.XPath("(//table[@class='c-data-grid c-data-grid-table dataTable table-layout-fixed'])[" + summaryGridIndex + "]"));
		}


		public IWebElement Sellingentity { get { return WebDriver.GetElement(By.Id("quoteCreate_sellingEntity")); } }


		public IWebElement WarrantySkuNotification { get { return WebDriver.GetElement(By.XPath("//div[@id='main']/quote-create-root/quote-create/div/div/div/quote-create-header-notification/div/warranty-sku-notification/div/div/span")); } }


		public IWebElement SaveQuoteConfirm { get { return WebDriver.GetElement(By.Id("saveQuote")); } }


		public IWebElement SolutionIdTextBox { get { return WebDriver.GetElement(By.Id(" solutionName_input")); } }


		public IWebElement SubBillingFlyoutContent { get { return WebDriver.GetElement(By.Id("review-subscription-billing")); } }


		public IWebElement BillPlanIdOnSubBillingFlyout { get { return WebDriver.GetElement(By.XPath("//*[@id='flex-billing-service-warranty']/div/div[1]/div[3]/label[2]")); } }


		public IWebElement ServiceTagOnSubBillingPageFlyout { get { return WebDriver.GetElement(By.Id("quoteCreate_serviceTags_header")); } }


		public IWebElement SomeServiceTagsdontMatchWarning { get { return WebDriver.GetElement(By.XPath("//*[@id='notificationMessages_1']/span[2]")); } }


		public IWebElement RSATSValidationMessage { get { return WebDriver.GetElement(By.Id("quoteCreate_rsInventoryValidation")); } }


		public IWebElement RSATSOverrideBtn { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_rsInventoryValidation']/div/div[2]/button")); } }


		public IWebElement CancelBtn { get { return WebDriver.GetElement(By.Name("cancel")); } }


		public IWebElement AddItemTopButton { get { return WebDriver.GetElement(By.Id("quoteCreate_additem_top_header_")); } }

		public IWebElement UpdateonQuote { get { return WebDriver.GetElement(By.XPath("//a[@id='quoteCreate_update_billTo']")); } }
		public IWebElement GetCustomerConsentScriptText { get { return WebDriver.GetElement(By.XPath("//p[contains(text(),'To learn how Dell uses your data and how to set ma')]")); } }


		public IWebElement lstgoaldealfamilyorclassitemsPerPage { get { return WebDriver.GetElement(By.XPath("//select[@id='goaldeal_familyorclass_grid_grid_paging_itemsPerPage;']")); } }


		public IWebElement ClearPriceHelpIcon { get { return WebDriver.GetElement(By.XPath("//i[@contenttodisplay='Clear Price provides price guidance for future renewal of support services. ']")); } }

		//Sv
		public IWebElement Btncatno { get { return WebDriver.GetElement(By.XPath("//*[@id='button_select_usic1f']")); } }

		

		public IWebElement RSIDNotification { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'RSID cannot be created')]")); } }

		public IWebElement AssetIdentifierId { get { return WebDriver.GetElement(By.Id("ad_col_identifierId_0")); } }

		public IWebElement AssetModelDescription { get { return WebDriver.GetElement(By.Id("ad_col_productLineDesc_0")); } }

		public IWebElement AssetManufacturer { get { return WebDriver.GetElement(By.Id("ad_col_mftrDesc_0")); } }

		public IWebElement AssetIdentifierType { get { return WebDriver.GetElement(By.Id("ad_col_identifierType_0")); } }


		#region Clear Price
		public IWebElement ClearPriceServiceLabel()
		{
			return WebDriver.GetElement(By.XPath("//b[contains(text(),' Clear Price Support Service Renewal ')]"));
		}

		public IWebElement ClearPriceUpperLevelPriceLabel()
		{
			return WebDriver.GetElement(By.XPath("//label[contains(text(),'Upper Level Price Guidance:')]"));
		}

		public IWebElement ClearPriceCalculatePriceLink()
		{
			return WebDriver.GetElement(By.XPath("//a[contains(text(),'Calculate Price ')]"));
		}

		public IWebElement ClearPriceCalculatePriceValue()
		{
			return WebDriver.GetElement(By.XPath("//label[contains(text(),' Upper Level Price Guidance: ')]//span[2]"));
		}

		public decimal ClearPriceReturnCalculatePriceValue(IWebDriver driver)
		{
			var text = ClearPriceCalculatePriceValue().GetText(driver);
			string str = Regex.Replace(text, @"[^0-9\.]+", "");
			return Convert.ToDecimal(str);
		}

		#endregion


		#region POS Subscription Billing fields

		public IWebElement FullPeriodChargeTxt { get { return WebDriver.GetElement(By.XPath("//div[contains(text(), 'Full period charge per unit')]")); } }

		public IWebElement Quantity { get { return WebDriver.GetElement(By.XPath("//div[contains(text(), 'Quantity')]")); } }

		public IWebElement TotalFullPeriodChargeTxt { get { return WebDriver.GetElement(By.XPath("//div[contains(text(), 'Total full period charge')]")); } }

		public IWebElement FirstPeriodChargeTxt { get { return WebDriver.GetElement(By.XPath("//div[contains(text(), 'First period charge prorated (estimated) per unit')]")); } }

		public IWebElement CoveragePeriodTxt { get { return WebDriver.GetElement(By.XPath("//div[contains(text(), 'Coverage Period')]")); } }

		public IWebElement RenewalDateTxt { get { return WebDriver.GetElement(By.XPath("//div[contains(text(), 'Renewal Date')]")); } }

		public IWebElement McAfeeHeaderTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'McAfee OEM ? US - ENG')]")); } }

		public IWebElement OfferDisclosureTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Offer Subscription Disclosures and Terms and Conditions')]")); } }

		public IWebElement SkuDisclosureTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Offer Subscription Disclosures and Terms and Conditions')]")); } }

		public IWebElement TermsAndConditionsLnk { get { return WebDriver.GetElement(By.XPath("(//*[contains(text(), 'Terms and Conditions')])[2]")); } }

		#endregion

		#region PMC Notifications


		public IWebElement CustomerConsentNotifications { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'When collecting or updating a customer')]")); } }


		public IWebElement PMCUpdateNotifications { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Any update to PMC will take up to 24/48 hours to reflect in DSA.')]")); } }


		public IWebElement CustomerConsentScriptLink { get { return WebDriver.GetElement(By.XPath("//div[contains(text(), 'Read Privacy Notice Script')]")); } }

		public IWebElement GetCustomerConsentScript(int? ConsentIndex)
		{
			return WebDriver.FindElement(By.XPath("//marketing-preference//div//p[" + ConsentIndex + "]"));
		}

		public IWebElement EditContactOptIn(string PMCField)
		{
			return WebDriver.FindElement(By.Id("EditContactDialog_Marketing_Preference_OptIn_" + PMCField + ""));
		}

		public IWebElement EditContactOptOut(string PMCField)
		{
			return WebDriver.FindElement(By.Id("EditContactDialog_Marketing_Preference_OptOut_" + PMCField + ""));
		}

		public IWebElement AddNewShipToOptIn(string PMCField)
		{
			return WebDriver.FindElement(By.Id("createFormComponent_Marketing_Preference_OptIn_" + PMCField + ""));
		}

		public IWebElement AddNewShipToOptOut(string PMCField)
		{
			return WebDriver.FindElement(By.Id("createFormComponent_Marketing_Preference_OptOut_" + PMCField + ""));
		}

		public IWebElement AddNewAddressOptIn(string PMCField)
		{
			return WebDriver.FindElement(By.Id("Marketing_Preference_OptIn_" + PMCField + ""));
		}

		public IWebElement AddNewAddressOptOut(string PMCField)
		{
			return WebDriver.FindElement(By.Id("Marketing_Preference_OptOut_" + PMCField + ""));
		}

		public void VerifyCustomerConsentScript(DataRow row)
		{
			CustomerConsentScriptLink.Displayed.Should().BeTrue();
			CustomerConsentScriptLink.Click(WebDriver);
			GetCustomerConsentScriptText.GetText(WebDriver).Should().BeEquivalentTo(row["CustomerConsentScript"].ToString());
			Close.Click();
		}

		public void EditContactInvoiceEmail(String emailAddress)
		{
			EditContactEmail.Clear();
			EditContactEmail.SetText(WebDriver, emailAddress);
		}

		public void EditContactMobile(String mobileNumber)
		{
			EditContactMobilePhone.Clear();
			EditContactMobilePhone.SetText(WebDriver, mobileNumber);
		}

		public void EditContactWork(String phoneNumber)
		{
			EditContactWorkPhone.Clear();
			EditContactWorkPhone.SetText(WebDriver, phoneNumber);
		}

		#endregion

		#region EAP Elements

		public IWebElement GetRecommendedTabAtIndex(int index)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_LI_show_more_" + index + "']/i"));
			//return WebDriver.FindElement(By.CssSelector("#quoteCreate_LI_show_more_" + index));
		}
		public IWebElement ToggleMoreOrLess(int index)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='toggleMoreLess_0_" + index + "']/span"));
		}
		public IWebElement GetConfigItem(int index)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_LI_configItem_0_" + index));
		}

		public IWebElement GetConfigItems(int index)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_LI_configItem_" + index + "_0"));
		}


		public IWebElement ConfigItem { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_configItem_0_0")); } }


		public IWebElement ConfigItem2 { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_configItem_0_1")); } }

		public IWebElement TiedItemsDropdown(int index1, int index2)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_LI_CS_Item_0_" + index1 + "_" + index2));
		}
		public IWebElement GetRecommendedTabAtIndexNew(int index)
		{
			return WebDriver.FindElement(By.CssSelector("#quoteCreate_LI_show_more_" + index));
		}

		public IWebElement GetRecommendedFlexBundleImage()
		{
			return WebDriver.GetElement(By.XPath("//*[@id='RecommendationCarousel']//slide[1]/div/div[1]/div[2]//img"));
		}

		public bool IsImagePresent(IWebElement image)
		{
			return image.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(20));
		}

		public IWebElement AddRecommendedItem(RecommendedItemType type, int groupIndex = 0, int lineIndex = 0, int n = 1)
		{
			//return WebDriver.FindElement(By.XPath("(//div[@id='quoteCreate_accordion_" + (groupIndex - 1) + "_" + (lineIndex - 1) + "']//button[@id='" + type + "'])[" + n + "]"));
			return WebDriver.FindElements(By.XPath("//*[@id='AddRecommendationToQuote']"))[0];
		}

		public IWebElement GetRecommendedItemCode(RecommendedItemType type, int groupIndex = 0, int lineIndex = 0, int n = 1)
		{
			return WebDriver.FindElement(By.XPath("(//div[@id='quoteCreate_accordion_" + (groupIndex - 1) + "_" + (lineIndex - 1) + "'])[" + n + "]/ancestor::div[@class='item recommended-item-block']/div[@class='item-details']/h6[1]"));
		}

		public string RecommendedItemXpath(int index)
		{
			var RecommendedItemXpath = string.Format("//*[@id='quoteCreate_accordionMore_0_0']/div/div[2]/div/div[2]/div[1]/div[3]/div/div[1]/div[{0}]/div/div[2]/a/h5", index);
			return RecommendedItemXpath;
		}

		public string RecommendedItemDescription()
		{
			var RecommendedItemDescription = string.Format("//*[@id='quoteCreate_accordionMore_0_0']/div/div[2]/div/div[2]/div[2]/div[2]/span");
			return RecommendedItemDescription;
		}

		public string LnkDell()
		{
			var LnkDell = string.Format("//*[@id='quoteCreate_accordionMore_0_0']/div/div[2]/div/div[2]/div[2]/div[2]/p[1]/a");
			return LnkDell;
		}

		public bool IsRecommendationsTabCollapsed(int index)
		{
			return WebDriver.FindElements(By.CssSelector("#quoteCreate_LI_show_more_" + index))[0].GetAttribute("innerHTML").Contains("icon-ui-expand");
		}

		public string RecommendedItemPrice()
		{
			var RecommendedItemPrice = string.Format("//*[@id='recommended-item']/h6");
			return RecommendedItemPrice;
		}
		//public IWebElement GetLeftArrowCarouselButton(int index)
		//{
		//    return WebDriver.FindElement(By.CssSelector("#quoteCreate_accordionMore_" + index + " > div > div:nth-child(2) > div > div.offset-0.pd-top-10 > div.col-md-12.recommend > div.carousel.carousel-filmstrip-arrow-only.carousel > a.carousel-control.left"));
		//}

		//public IWebElement GetRightArrowCarouselButton(int index)
		//{
		//    return WebDriver.FindElement(By.CssSelector("#quoteCreate_accordionMore_" + index + " > div > div:nth-child(2) > div > div.offset-0.pd-top-10 > div.col-md-12.recommend > div.carousel.carousel-filmstrip-arrow-only.carousel > a.carousel-control.right"));
		//}

		//public IWebElement GetInnerCarouselContents(int index)
		//{
		//    return WebDriver.FindElement(By.CssSelector("#quoteCreate_accordionMore_" + index + " > div > div:nth-child(2) > div > div.offset-0.pd-top-10 > div.col-md-12.recommend > div.carousel.carousel-filmstrip-arrow-only.carousel > div"));
		//}

		//public IWebElement GetEapButton(RecommendedItemType type, int groupIndex = 1, int lineItemIndex = 1, int n = 1)
		//{

		//    return WebDriver.FindElement(By.XPath("(//div[@id='quoteCreate_accordion_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']//button[@id='" + type + "'])[" + n + "]"));
		//}


		public IWebElement GetNoRecommendationsMessage(int index)
		{
			return WebDriver.FindElement(By.CssSelector("#quoteCreate_accordionMore_" + index + " > div > div:nth-child(2) > div > div.offset-0.pd-top-10 > div.col-md-12.recommend > div:nth-child(2) > h6"));
		}

		public IWebElement GetRecommendations(int index)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_accordionMore_" + index + "']/div[2]/div/recommendation-carousel/div[1]"));
			//return WebDriver.FindElement(By.CssSelector("#quoteCreate_accordionMore_" + index + " > div > div:nth-child(2) > div > div.offset-0.pd-top-10 > div.col-md-12.recommend > div.carousel.carousel-filmstrip-arrow-only.carousel"));
		}

		public IWebElement GetRetrievingRecommendationsMessage(int index)
		{
			return WebDriver.FindElement(By.CssSelector("#quoteCreate_accordionMore_" + index + " > div > div:nth-child(2) > div > div.offset-0.pd-top-10 > div.col-md-12.recommend > div:nth-child(1) > h6"));
		}

		public IWebElement AddRecommendationButton(int lineItemIndex, int recommendedItemIndex)
		{
			return WebDriver.FindElement(By.CssSelector("#quoteCreate_accordionMore_" + lineItemIndex + " > div > div:nth-child(2) > div > div.offset-0.pd-top-10 > div.col-md-12.recommend > div.carousel.carousel-filmstrip-arrow-only.carousel > div > div.carousel-inner.eap-recommendations.item.active > div:nth-child(" + recommendedItemIndex + ") > div > div:nth-child(5) > button"));
		}

		public List<IWebElement> RecommendationPrice(int lineItemIndex, int recommendedItemIndex)
		{
			var recommendedPrices = WebDriver.GetElements(By.XPath("//*[@id='RecommendationCarousel']//slide[1]/div/div[" + lineItemIndex + "]//div[" + recommendedItemIndex + "]"));
			return recommendedPrices;
			//return WebDriver.FindElement(By.CssSelector("#quoteCreate_accordionMore_" + lineItemIndex + " > div > div:nth-child(2) > div > div.offset-0.pd-top-10 > div.col-md-12.recommend > div.carousel.carousel-filmstrip-arrow-only.carousel > div > div.carousel-inner.eap-recommendations.item.active > div:nth-child(" + recommendedItemIndex + ") > div > div.item-details > h6.final-price"));
		}

		public IWebElement getRecommendationAddToQuote(int item)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='AddRecommendationToQuote'][" + item + "]"));
		}

		public List<IWebElement> getRecommendationConfigureToQuote(int item)
		{
			return WebDriver.GetElements(By.XPath("//*[@id='AddConfigurationToQuote'][" + item + "]"));
		}

		public void selectRecommendationAddToQuote(IWebDriver driver, int index)
		{
			WebDriver.GetElements(By.XPath("//*[contains(@id, 'AddRecommendationToQuote')]"))[index].Click(driver);
		}

		public IWebElement getQuoteSellingPrice()
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_GI_sellingPrice_0']"));
		}

		public IWebElement getRecommendedItemQuantity(int slide)
		{
			return WebDriver.GetElement(By.XPath("//slide[1]//div[" + slide + "]/div[4]/input"));
		}

		public IWebElement RecommendationQuantityMinus(int lineItemIndex, int recommendedItemIndex)
		{
			return WebDriver.FindElement(By.CssSelector("#quoteCreate_accordionMore_" + lineItemIndex + " > div > div:nth-child(2) > div > div.offset-0.pd-top-10 > div.col-md-12.recommend > div.carousel.carousel-filmstrip-arrow-only.carousel > div > div.carousel-inner.eap-recommendations.item.active > div:nth-child(" + recommendedItemIndex + ") > div > div.rangespinner > button:nth-child(1)"));
		}

		public IWebElement RecommendationQuantityPlus(int lineItemIndex, int recommendedItemIndex)
		{
			return WebDriver.FindElement(By.CssSelector("#quoteCreate_accordionMore_" + lineItemIndex + " > div > div:nth-child(2) > div > div.offset-0.pd-top-10 > div.col-md-12.recommend > div.carousel.carousel-filmstrip-arrow-only.carousel > div > div.carousel-inner.eap-recommendations.item.active > div:nth-child(" + recommendedItemIndex + ") > div > div.rangespinner > button:nth-child(3)"));
		}

		public IWebElement RecommendationQuantityTextInput(int lineItemIndex, int recommendedItemIndex)
		{
			return WebDriver.FindElement(By.CssSelector("#quoteCreate_accordionMore_" + lineItemIndex + " > div > div:nth-child(2) > div > div.offset-0.pd-top-10 > div.col-md-12.recommend > div.carousel.carousel-filmstrip-arrow-only.carousel > div > div.carousel-inner.eap-recommendations.item.active > div:nth-child(" + recommendedItemIndex + ") > div > div.rangespinner > input"));
		}

		public bool RecommendedTabExists(int index)
		{
			return WebDriver.ElementExists(By.Id("quoteCreate_LI_show_more_" + index));
		}

		public void WaitForRecommendationsToLoad(int index)
		{
			WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
			string RecommendedElement = string.Format("//*[@id='quoteCreate_accordionMore_{0}']/following-sibling::div/descendant::*[contains(@class,'item recommended-item-block')][1]", index);
			wait.Until(x => x.ElementExists(By.XPath(RecommendedElement)));
		}
		public IList<IWebElement> RecommendedTabVisibleElements(int index)
		{
			string RecommendedElements = string.Format("//*[@id='quoteCreate_accordionMore_{0}']/following-sibling::div/descendant::*[contains(@class,'item recommended-item-block')]", index);
			return webDriver.FindElements(By.XPath(RecommendedElements));
		}

		public IWebElement TxtRecommendationQuantity(int SlideNo, int ItemNo)
		{
			string RecommendedQuantity = string.Format("//*[@id='quoteCreate_accordionMore_0']/div/div[2]/div/recommendation-carousel/div[1]/carousel/div/div/slide[{0}]/div/div[{1}]/div[4]/input", SlideNo, ItemNo);
			return WebDriver.FindElement(By.XPath(RecommendedQuantity));
		}

		public bool RecommendationsTabVisible(int index)
		{
			return GetRecommendedTabAtIndex(index).Enabled && !Busy.Displayed;
		}

		public bool NoRecommendationsMessageVisible(int index)
		{
			return GetNoRecommendationsMessage(index).Enabled;
		}

		public bool RecommendationsVisible(int index)
		{
			return WebDriver.TryFindElement(GetRecommendations(index), TimeSpan.FromSeconds(5));
		}

		public bool RetrievingRecommendationsMessageVisible(int index)
		{
			return GetRetrievingRecommendationsMessage(index).Enabled;
		}

		public void UpdateQuantityOfRecommendations(int lineItemIndex, int recommendedProductIndex, string quantity)
		{
			RecommendationQuantityTextInput(lineItemIndex, recommendedProductIndex).SetText(WebDriver, quantity);
		}

		public void AddRecommendationToCart(int lineItemIndex, int recommendedProductIndex)
		{
			AddRecommendationButton(lineItemIndex, recommendedProductIndex).Click(WebDriver);
		}

		public IWebElement ShippingGroupTotalTax(string index)
		{

			var X_Path = ".//*[@id='" + "PricingSummary_" + index + "']/descendant::div[contains(@id,'tax_')]";
			return WebDriver.FindElement(By.XPath(X_Path));
		}

		public IWebElement ShippingGroupTax(string group, string taxindex)
		{

			var X_Path = ".//*[@id='quoteCreate_LI_tax_" + group + "_" + taxindex + "']";
			return WebDriver.FindElement(By.XPath(X_Path));
		}
		public IWebElement ShippingGrpChangeAddress(string group)
		{

			return WebDriver.FindElement(By.Id("quoteCreate_GI_changeAddress_" + group));

		}
		public IWebElement ShippingGrpChangeCustomer(string group)
		{
			return WebDriver.FindElement(By.Id("quoteCreate_GI_changeCustomer_" + group));
		}

		public IWebElement ShippingGrpChangeShippingAddress(string group)
		{

			return WebDriver.FindElement(By.Id("quoteCreate_shipment-" + group + "_chooseAddress"));

		}

		public IWebElement ShippingGrpAddNewShippingAddress(int? index)
		{
			return WebDriver.FindElement(By.Id("quoteCreate_shipment-" + index + "_addNewAddress"));
		}

		public IWebElement AddNewAddressShippingGroup1(int? index)
		{
			return WebDriver.FindElement(By.XPath("//a[@id='quoteCreate_shipment-0_addNewAddress']"));

		}

		public IWebElement QuoteSummaryTax { get { return WebDriver.GetElement(By.Id("quoteCreate_summary_totalTaxAmount")); } }

		public IWebElement ShippingGroups(int? Index)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_group_" + Index));
		}

		#endregion

		#region DTCP Elements


		public IWebElement DTCPQuoteErrorNotification { get { return WebDriver.GetElement(By.XPath("//*[@class='alert-error' and span[contains(text(), 'Quote contains DTCP and non-DTCP items. Please remove the conflicting item(s)')]]")); } }


		public IWebElement DtcpExpansionErrorNotification { get { return WebDriver.GetElement(By.XPath("//*[@class='alert-error' and span[contains(text(), 'For Expansion , Please select the expansion option')]]")); } }


		public IWebElement DtcpExpansionItemLevelErrorNotification { get { return WebDriver.GetElement(By.XPath("//*[@class='alert-warning' and span[contains(text(), 'For Expansion , Please select the expansion option')]]")); } }


		public IWebElement BillPlanTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Bill Plan')]")); } }


		public IWebElement PaymentTypeTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Payment Type')]")); } }


		public IWebElement CCNumberTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'CC Number')]")); } }


		public IWebElement NextPaymentTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Next Payment')]")); } }


		public IWebElement BillPlanNotFoundNotification { get { return WebDriver.GetElement(By.XPath("//*[@class='alert alert-info ng-star-inserted']")); } }

		#endregion

		#region Upgrade Quote - Install At Actions


		public IWebElement upgradeQuoteSearchExistingInstallAtCustomer { get { return WebDriver.GetElement(By.Id("upgrade_quote_change_installAtCustomer")); } }


		public IWebElement upgradeQuoteAddNewInstallAtCustomer { get { return WebDriver.GetElement(By.Id("upgrade_quote_add_installAtCustomer_addCustomer")); } }


		public IWebElement upgradeQuoteSearchExistingInstallAtAddress { get { return WebDriver.GetElement(By.XPath("//*[@id='upgrade_quote_installAt_actions']//a[contains(text(), 'Search Existing Install At Address')]")); } }


		public IWebElement upgradeQuoteAddNewInstallAtAddress { get { return WebDriver.GetElement(By.XPath("//*[@id='upgrade_quote_installAt_actions']//a[contains(text(), 'Add New Install At Address')]")); } }


		public IWebElement upgradeQuoteEditInstallAtAddress { get { return WebDriver.GetElement(By.XPath("//*[@id='upgrade_quote_installAt_actions']//a[contains(text(), 'Edit')]")); } }


		public IWebElement upgradeQuoteAddNewContactInstallAtAddress { get { return WebDriver.GetElement(By.XPath("//*[@id='upgrade_quote_installAt_actions']//a[contains(text(), 'Add New Contact')]")); } }

		#endregion

		#region Install At Customer Elements


		public IWebElement CompanyName { get { return WebDriver.GetElement(By.Id("createFormComponent_company_name")); } }


		public IWebElement CompanyPhone { get { return WebDriver.GetElement(By.Id("createFormComponent_company_phone")); } }


		public IWebElement FirstName { get { return WebDriver.GetElement(By.Id("contact_firstName")); } }


		public IWebElement LastName { get { return WebDriver.GetElement(By.Id("contact_lastName")); } }


		public IWebElement InvoicingEmail { get { return WebDriver.GetElement(By.Id("contact_invoicingEmailAddress")); } }


		public IWebElement MobilePhone { get { return WebDriver.GetElement(By.Id("contact_mobilePhone")); } }


		public IWebElement AddressLine_1 { get { return WebDriver.GetElement(By.Id("address_line1")); } }


		public IWebElement ZipCode { get { return WebDriver.GetElement(By.Id("address_postalCode")); } }


		public IWebElement City { get { return WebDriver.GetElement(By.Id("address_city")); } }


		public IWebElement PostalCode { get { return WebDriver.GetElement(By.Id("address_postalCodeExtension")); } }


		public IWebElement BtnSave { get { return WebDriver.GetElement(By.XPath("//*[@class='btn btn-success' and contains(text(), 'Save')]")); } }

		public IWebElement InstallAtAddNewCustomer(int? InstallAtIndex)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_shipment-installAt" + InstallAtIndex + "_addCustomer"));
		}

		public IWebElement InstallAtShippingInfo(int? InstallAtIndex)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_GI_shippingInformation_installAt_" + InstallAtIndex));
		}

		public IWebElement InstallAtCustomerInfo(int? InstallAtIndex)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_installAt_" + InstallAtIndex + "']//div"));
		}

		public IWebElement ShippingGroupInfo(int? groupIndex)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_groupAccordion_" + groupIndex + "']//span[contains(text(), 'Shipping Group Information')]"));

		}
		public IWebElement InstallAtAddNewAddress(int? InstallAtShippingIndex)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_installAt_" + InstallAtShippingIndex + "']//div[3]//a[contains(text(),'Add New Address')]"));
		}

		public IWebElement InstallAtChangeAddress(int? InstallAtShippingIndex)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_installAt_" + InstallAtShippingIndex + "']//div[3]//a[contains(text(),'Change')]"));
		}

		public IWebElement InstallAtAddNewContact(int? InstallAtIndex)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_installAt_" + InstallAtIndex + "']//div[3]//a[contains(text(),'Add New Contact')]"));
		}

		public IWebElement InstallAtAddressInfo(int? InstallAtIndex)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_installAt_" + InstallAtIndex + "']//div[3]//quote-create-shipping-group-install-at-address//div//div//div//address"));
		}

		public IWebElement InstallAtAddressInfoWithoutAddress(int? InstallAtIndex)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_installAt_" + InstallAtIndex + "']//div[3]//quote-create-shipping-group-install-at-address//div//address//div"));
		}

		public IWebElement InstallAtAddressAddNewAddress(int? InstallAtIndex)
		{
			return WebDriver.FindElement(By.CssSelector("#quoteCreate_GI_shippingArea_installAt_0 p>a#quoteCreate_shipment-0_addNewAddress"),DsaUtil.GlobalWaitTime);
		}

		public IWebElement InstallAtEditContact(int? InstallAtIndex)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_installAt_" + InstallAtIndex + "']//div[3]//a[contains(text(),'Edit')]"));
		}

		public IWebElement SelectAddressTab(String selectTab)
		{
			return WebDriver.GetElement(By.Id("change-address-dialog_address-grid_tab_" + selectTab));
		}

		public IWebElement InstallAtChangeCustomer(int? InstallAtIndex)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_GI_changeCustomer_installAt_" + InstallAtIndex));
		}


		public IWebElement InstallAtSelectExistingAddress { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']//tr[position()=1]//a[contains(text(),'Select')]")); } }


		public IWebElement BillToCustomerInfo { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_billToCustomer_intro']")); } }


		public IWebElement InstallAtAddressLine_1 { get { return WebDriver.GetElement(By.Id("AddLocationDialog_address_line1")); } }


		public IWebElement InstallAtAddressZipCode { get { return WebDriver.GetElement(By.Id("AddLocationDialog_address_postalCode")); } }


		public IWebElement InstallAtAddressFirstName { get { return WebDriver.GetElement(By.Id("AddLocationDialog_contact_firstName")); } }


		public IWebElement InstallAtAddressLastName { get { return WebDriver.GetElement(By.Id("AddLocationDialog_contact_lastName")); } }


		public IWebElement InstallAtAddressEmail { get { return WebDriver.GetElement(By.Id("AddLocationDialog_contact_email")); } }


		public IWebElement InstallAtAddressPhone { get { return WebDriver.GetElement(By.Id("AddLocationDialog_contact_mobilePhone")); } }


		public IWebElement InstallAtAddressWorkPhone { get { return WebDriver.GetElement(By.Id("AddLocationDialog_contact_workPhone")); } }


		public IWebElement WorkPhone { get { return WebDriver.GetElement(By.Id("contact_workPhone")); } }


		public IWebElement BtnSubmit { get { return WebDriver.GetElement(By.Id("AddLocationDialog_submit")); } }

		public IWebElement BtnNewRecord(int? InstallAtIndex)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_installAt_" + InstallAtIndex + "']//div[3]/quote-create-shipping-group-install-at-address//address//button[contains(text(), 'N - New Record')]"));
		}

		public IWebElement BtnCreateRequestSubmittedRecord(int? InstallAtIndex)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_installAt_" + InstallAtIndex + "']//div[3]/quote-create-shipping-group-install-at-address//address//button[contains(text(), 'Create request submitted')]"));
		}


		public IWebElement InstallAtAddressRequiredNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Install At address required, per shipping group to place order')]")); } }


		public IWebElement SolutionNameRequiredNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Solution name required, per shipping group to place order')]")); } }


		public IWebElement UCIDRequiredNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Install At address UCID required, per shipping group to place order')]")); } }


		public IWebElement UCIDRequestShippingAddress { get { return WebDriver.GetElement(By.CssSelector("#quoteCreate_GI_shippingInformation_0 address .address-block>div:nth-child(1)")); } }


		public IWebElement UCIDRequestShippingAddress2 { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_1']/div[3]/quote-create-shipping-group-address/div/div/div/address/div/div[1]/div/div[1]")); } }


		public IWebElement CustomerNameShipping1 { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_0']/div[3]/quote-create-shipping-group-address/div/div/div/address/div/div[1]/div/div[2]")); } }


		public IWebElement CustomerNameShipping2 { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_1']/div[3]/quote-create-shipping-group-address/div/div/div/address/div/div[1]/div/div[2]")); } }


		public IWebElement DisplayItemsPerPage { get { return WebDriver.GetElement(By.XPath("//*[@id='gridChangeAddress_grid_paging_itemsPerPage;']")); } }


		public IWebElement BtnConfirmRemoveSolution { get { return WebDriver.GetElement(By.XPath("//*[@id='_btn_ok' and contains(text(), 'Yes, remove solution name')]")); } }


		public IWebElement BtnDoNotRemoveSolution { get { return WebDriver.GetElement(By.XPath("//*[@id='_btn_cancel' and contains(text(), 'Dont remove it')]")); } }


		public IWebElement UCIDText { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'UCID')]")); } }


		public IWebElement Hypen { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[1]/td[14]")); } }


		public IWebElement SolutionName_Txt { get { return WebDriver.GetElement(By.XPath("//input[@id='solutionName_input']")); } }

		public IWebElement SolutionNameTxt(int? Index)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_groupAccordion_" + Index + "']//input[contains(@id, 'solutionName_input')]"));
		}

		public IWebElement InstallAtCustomerSection(int? InstallAtShippingIndex)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_installAt_" + InstallAtShippingIndex + "']//p"));
		}

		public IWebElement InstallAtCustomer(int? InstallAtShippingIndex)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_installAt_" + InstallAtShippingIndex + "']//div[1]//p"));
		}


		public IWebElement UpgradeSolutionSection { get { return WebDriver.GetElement(By.XPath("//*[@id='UpgradeSolutionSection']/div[2]/div[1]")); } }

		public IWebElement InstallAtAddress(int? InstallAtShippingIndex)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_GI_shippingInformation_installAt_" + InstallAtShippingIndex + "']//div[3]//quote-create-shipping-group-install-at-address//address//div//div"));
		}

		public IWebElement SearchForExistingAddress(int? InstallAtShippingIndex)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_shipment-" + InstallAtShippingIndex + "_chooseAddress' and contains(text(), 'Search Existing Address')]"));
		}

		public IWebElement RemoveShippingGroupItem(int? Index)
		{
			return WebDriver.FindElement(By.Id("quoteCreate_LI_removeItem_" + Index + "_0"));
		}

		// Review Checklist
		public IWebElement ReviewChecklistInstallAtSection(int? InstallAtShippingIndex)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='review-checklist']//div//div[" + InstallAtShippingIndex + "]//shipping-group//review-installat"));
		}


		public IWebElement UpgradeSolution { get { return WebDriver.GetElement(By.Id("quoteCreate_upgradeSolution")); } }


		public IWebElement RemoveUpgrade { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_removeUpgrade']")); } }

		public IWebElement BtnRemoveUpgrade { get { return WebDriver.GetElement(By.XPath("//button[@id='quoteCreate_removeUpgrade']")); } }

		public IWebElement AssetNotFoundError { get { return WebDriver.GetElement(By.Id("quoteCreate-assetErrorMessage")); } }


		public IWebElement AlertSuccess { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-success ng-star-inserted']")); } }


		public IWebElement UpgradeTypeSerialNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_serialNumberUpgrade']")); } }


		public IWebElement UpgradeTypeServiceTag { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_serviceTagUpgrade']")); } }


		public IWebElement UpgradeTypeAgreementId { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_dctpExpansion']")); } }

		public IWebElement AposRequestOptOut { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_request_opt_out']")); } }

		public IWebElement AposRequestOptOutDropDown { get { return WebDriver.GetElement(By.XPath("//*[@id='optOutReason']")); } }


		public IWebElement HelpMeFindAgreementIdLnk { get { return WebDriver.GetElement(By.Id("quoteCreate_help_agreementLink")); } }


		public IWebElement SelectBillPlanBtn { get { return WebDriver.GetElement(By.Id("billplan_select_undefined")); } }


		public IWebElement SolutionUpgradeTxt { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_upgradeSolutionTag']")); } }


		public IWebElement ApplyAsParentToAll { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_applyServiceTagAsParentToAll']")); } }


		public IWebElement RemoveServiceTagFromAll { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_removeServiceTagFromAll']")); } }


		public IWebElement LnkTagMaintainedAsDataViewer { get { return WebDriver.GetElement(By.Id("LinkMaintainedDataViewer_OpenMaintainedDataViewerLinkTag")); } }


		public IWebElement MenuLnkMaintainedAsDataViewer { get { return WebDriver.GetElement(By.Id("menu_maintained_data_view")); } }


		public IWebElement MaintainedAsDataViewerNavigationBar { get { return WebDriver.GetElement(By.XPath("//*[@id='navbar']/a/span[1]")); } }


		public IWebElement Search2ExistingAddressInInstallAt { get { return WebDriver.GetElement(By.XPath("//a[@id='quoteCreate_shipment-1_chooseAddress' and contains(text(),'Search Existing Address')]")); } }

		public IWebElement ErrorNotifications(String missingField)
		{
			return WebDriver.GetElement(By.XPath("//*[@class='alert alert-error ng-star-inserted' and @id='" + missingField + "']"));
		}

		public IWebElement SuccessNotifications(String missingField)
		{
			return WebDriver.GetElement(By.XPath("//*[@class='ng-star-inserted alert alert-success' and @id='" + missingField + "']"));
		}

		public IWebElement AposAndPosProductErrorNotification { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'The products on the quote are not compatible to be sold together.')]")); } }

		public IWebElement AssetInfoMissingErrorNotification { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'This quote cannot be saved as the asset details are missing. Please select Asset Type and Asset ID, under Solution Upgrade section.')]")); } }

		#endregion

		#region ISG APOS 


		public IWebElement SolutionWarrantyNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Please Ensure that all Service Level Warranties are the same for all Products in the solution.')]")); } }

		#endregion

		#region Add Location Pop Up Elements

		public IWebElement AddNewAddressCountry { get { return WebDriver.GetElement(By.Id("AddLocationDialog_address_country")); } }


		public IWebElement AddLocationAddress1 { get { return WebDriver.GetElement(By.Id("AddLocationDialog_address_line1")); } }


		public IWebElement AddLocationPostalcode { get { return WebDriver.GetElement(By.Id("AddLocationDialog_address_postalCode")); } }


		public IWebElement AddLocationAddress1WarningMsg { get { return WebDriver.GetElement(By.XPath("//p[contains(text(),'Cannot accept the')]")); } }


		public IWebElement AddLocationAddress1PoboxWarningMsg { get { return WebDriver.GetElement(By.XPath("//p[contains(text(),'PO box')]")); } }


		public IWebElement InvalidEmailWarningMsg { get { return WebDriver.GetElement(By.XPath("//p[contains(text(),'Must use the format name@domain.tld')]")); } }


		public IWebElement AddLocationCity { get { return WebDriver.GetElement(By.Id("AddLocationDialog_address_city")); } }


		public IWebElement AddLocationSelectState { get { return WebDriver.GetElement(By.Id("AddLocationDialog_address_state")); } }


		public IWebElement AddLocationSelectProvince { get { return WebDriver.GetElement(By.Id("AddLocationDialog_address_state")); } }


		public IWebElement AddLocationZipcode { get { return WebDriver.GetElement(By.Id("AddLocationDialog_address_postalCode")); } }


		public IWebElement AddLocationSelectTitle { get { return WebDriver.GetElement(By.Id("AddLocationDialog_contact_title")); } }


		public IWebElement AddLocationFirstName { get { return WebDriver.GetElement(By.Id("AddLocationDialog_contact_firstName")); } }


		public IWebElement AddLocationLastName { get { return WebDriver.GetElement(By.Id("AddLocationDialog_contact_lastName")); } }


		public IWebElement AddLocationPhoneMobile { get { return WebDriver.GetElement(By.Id("AddLocationDialog_contact_mobilePhone")); } }


		public IWebElement AddLocationFaxNumber { get { return WebDriver.GetElement(By.Id("AddLocationDialog_contact_faxNumber")); } }


		public IWebElement AddLocationEmailInvoice { get { return WebDriver.GetElement(By.Id("AddLocationDialog_contact_email")); } }


		public IWebElement AddLocationSubmit { get { return WebDriver.GetElement(By.XPath("//button[@id='AddLocationDialog_submit']")); } }


		public IWebElement AddLocationCancel { get { return WebDriver.GetElement(By.XPath("//button[contains(@id, 'Dialog_cancel')]")); } }


		public IWebElement ChangeAddressCancel { get { return WebDriver.GetElement(By.XPath("//button[contains(text(),'Cancel')]")); } }


		public IWebElement BillToAddressDetail { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'Bill to Address')]/following-sibling::div[1]")); } }


		public IWebElement BillToAddressInfo { get { return WebDriver.GetElement(By.XPath("//*[@id='main']//quote-create-root//quote-create//div//quote-create-header//div//quote-create-dell-print-address//div/div//div[2]//div[1]//address")); } }


		public IWebElement SoldToAddressInfo { get { return WebDriver.GetElement(By.XPath("//quote-create-header//div[@class='collapse in show']//div[2]//address[1]")); } }


		public IWebElement ShippingAddressInfo { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'Shipping Address')]/following-sibling::div[1]")); } }



		public IWebElement SoldToAddressDetail { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'Sold to Address')]/following-sibling::div[1]")); } }


		public IWebElement ShippingAddressDetail { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'Shipping Address')]/following-sibling::div[1]")); } }


		public IWebElement ChckApplyAllInstallAt { get { return WebDriver.GetElement(By.Id("quote-update-all-shipping-groups-checkbox")); } }


		public IWebElement AddlocationShippingChckBox { get { return WebDriver.GetElement(By.XPath(".//input[@name='shippingType']")); } }


		public IWebElement AddlocationBillingChckBox { get { return WebDriver.GetElement(By.XPath(".//input[@name='billingType']")); } }


		public IWebElement DupeShippingAddrNotificationMsg { get { return WebDriver.GetElement(By.XPath("//*[@id='locationForm' or contains(text(),'The address and/or contact already exists!')]")); } }


		public IWebElement topassemplylevel { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_accordion_0_0']/div[3]/div/div[2]/div[4]/qc-line-item-tla/div/div/p")); } }


		public IWebElement topassemplylevelvalue { get { return WebDriver.GetElement(By.Id("_LI_tla_input_1_1")); } }


		public IWebElement errormsg { get { return WebDriver.GetElement(By.XPath(" //*[@id='_LI_contractCode_1']/div/div/p")); } }


		public IWebElement Criteria_ViewAllLocations { get { return WebDriver.GetElement(By.Id("AddressGrid_generalFilter")); } }


		#endregion

		#region Canada Elements       


		public IWebElement PostalCodeTxt { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']//span[contains(text(), 'Postal Code')]")); } }


		public IWebElement PostalCodeTxt_AddNewAddress { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Postal Code')]")); } }


		public IWebElement BillToCustomerInformation { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Bill to Customer Information')]")); } }


		public IWebElement MyAccountEmailPatched { get { return WebDriver.GetElement(By.CssSelector("#customer-detail-add-myaccount>div>div.data-group>div>div:nth-child(1) span:first-of-type")); } }


		public IWebElement DellAdvantageEnabled { get { return WebDriver.GetElement(By.CssSelector("#customer-detail-add-myaccount>div>div.data-group>div>div:nth-child(1) span:last-of-type")); } }


		public IWebElement BtnEnableDellAdvantage { get { return WebDriver.GetElement(By.Id("quoteCreate_enableDellAdvantage")); } }



		//Element for Expedited Delivery Radio Button

		public IWebElement ExpeditedDeliveryRadioElement { get { return WebDriver.GetElement(By.XPath("//div[@class='col-md-5']/label[contains(text(),' Expedited ')]/input[@name='shippingMethodOption']")); } }


		public IWebElement PostalCodeTxt_BillToCustomerInformation { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_billToAddress_section']//span[contains(text(), 'Postal code')]")); } }


		public IWebElement AddmyAccount { get { return WebDriver.GetElement(By.Id("quoteCreate_addMyAccount")); } }

		#endregion

		#region Edit Contact Pop Up Elements

		public IWebElement ShippingChange { get { return WebDriver.GetElement(By.Id("quoteCreate_shipment-0_chooseAddress")); } }



		public IWebElement SearchExistingAddressInInstallAt { get { return WebDriver.GetElement(By.XPath("//a[@id='quoteCreate_shipment-0_chooseAddress' and contains(text(),'Search Existing Address')]")); } }

		public void ClickOn2SearchExistingAddress(IWebDriver driver)
		{
			delay(10);
			IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
			executor.ExecuteScript("arguments[0].click();", Search2ExistingAddressInInstallAt);

		}
		public void ScrolltoShippingAddressChange()
		{
			delay(10);
			IJavaScriptExecutor executor = (IJavaScriptExecutor)webDriver;
			executor.ExecuteScript("arguments[0].scrollIntoView(true);", BtnExpandShippingAddressGroup);
			delay(5);
			BtnExpandShippingAddressGroup.Click();
		}

		public void clickOnShippingChange()
		{
			delay(10);
			IJavaScriptExecutor executor = (IJavaScriptExecutor)webDriver;
			executor.ExecuteScript("arguments[0].scrollIntoView(true);", BtnExpandShippingAddressGroup);
			delay(1);
			BtnExpandShippingAddressGroup.Click();
			delay(2);
			ShippingChange.Click();
		}

		public void ClickOnSearchExistingAddress(IWebDriver driver)
		{
			delay(20);
			IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
			executor.ExecuteScript("arguments[0].click();", SearchExistingAddressInInstallAt);

		}

		public void ClickUseInQuoteAsInstallAt(IWebDriver driver)
		{
			delay(10);
			IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
			executor.ExecuteScript("arguments[0].click();", BtnUseInQuoteAsInstallAtCustomer);

		}
		public CreateQuotePage ScrollToCollapseAll()
		{
			delay(10);
			((IJavaScriptExecutor)WebDriver).ExecuteScript("window.scroll(0, 900);");
			delay(1);
			return new CreateQuotePage(webDriver);
		}

		public CreateQuotePage moveToBillToAddNewContact()
		{

			webDriver.ScrollIntoElement(BillToAddNewContact);
			return new CreateQuotePage(webDriver);
		}

		public IWebElement BtnExpandShippingAddressGroup { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Shipping Group Information')]")); } }


		public IWebElement ShippingEdit { get { return WebDriver.GetElement(By.Id("quoteCreate_shipment-0_editAddress")); } }


		public IWebElement EditContactEmail { get { return WebDriver.GetElement(By.Id("EditContactDialog_contact_email")); } }


		public IWebElement PresentCountryCode { get { return WebDriver.GetElement(By.Id("//div[contains(text(),'+1')]")); } }


		public IWebElement ChangeCountryCode { get { return WebDriver.GetElement(By.Id("//div[@class='cdk-overlay-container']//li[2]")); } }


		public IWebElement EditCountryCode { get { return WebDriver.GetElement(By.Id("//div[contains(text(),'+32')]")); } }


		public IWebElement EditContactMobilePhone { get { return WebDriver.GetElement(By.Id("EditContactDialog_contact_mobilePhone")); } }


		public IWebElement EditContactWorkPhone { get { return WebDriver.GetElement(By.Id("EditContactDialog_contact_workPhone")); } }


		public IWebElement EditContactWorkPhoneExtn { get { return WebDriver.GetElement(By.Id("EditContactDialog_contact_workPhone_extension")); } }


		public IWebElement EditContactFax { get { return WebDriver.GetElement(By.Id("EditContactDialog_contact_faxNumber")); } }


		public IWebElement EditContactApplyToAllChkbox { get { return WebDriver.GetElement(By.Id("quote-update-all-linked-quotes-checkbox")); } }


		public IWebElement EditContactSubmitBtn { get { return WebDriver.GetElement(By.Id("EditContactDialog_submit")); } }


		public IWebElement EditContactCancelBtn { get { return WebDriver.GetElement(By.Id("EditContactDialog_cancel")); } }


		public IWebElement EditContactCopyBtn { get { return WebDriver.GetElement(By.Id("EditContactDialog_copy")); } }


		public IWebElement SoldToAddNewAddress { get { return WebDriver.GetElement(By.Id("quoteCreate_soldTo_addNewAddress")); } }


		public IWebElement ShippingGroupAddNewAddress { get { return WebDriver.GetElement(By.Id("quoteCreate_shipment-0_addNewAddress")); } }


		public IWebElement PhoneOverride { get { return WebDriver.GetElement(By.XPath("//div[@id='override']//input[@class='form-input']")); } }


		public IWebElement EmailOverride { get { return WebDriver.GetElement(By.XPath("//div[@id='override']//input[@class='form-input']")); } }


		public IWebElement StarRemoveFavorite { get { return WebDriver.GetElement(By.XPath(".//a[@title='Remove Favorite']/i")); } }


		public IWebElement StarMakeFavorite { get { return WebDriver.GetElement(By.XPath(".//a[@title='Mark Favorite']/i")); } }

		#endregion

		#region Warranty

		public IWebElement QuoteLvlWarrantyNotification { get { return WebDriver.GetElement(By.XPath("//warranty-sku-notification//span[contains(text(), 'This quote contains one or more systems with a tied subscription')]")); } }

		public IWebElement ItemLvlWarrantyNotification(int shippingIndex, int itemIndex)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_LI_warrantySku_" + shippingIndex + "_" + itemIndex + "' and //span[contains(text(), 'This system contains a tied subscription')]]"));
		}

		#endregion

		#region QAR

		public IWebElement ExportQAR { get { return WebDriver.GetElement(By.Id("quoteCreate_exportQAR")); } }

		#endregion

		public string QuoteCreateListPrice { get; set; }
		public string CompanyNumber { get; set; }
		public string CustomerId { get; set; }
		public string TaxAmount { get; set; }
		public string SellingPrice { get; set; }
		public string DiscountOffList { get; set; }
		public string ListPrice { get; set; }
		public void SelectGroupInQuote(int groupIndex)
		{
			SelectGroupInCustomQuote(groupIndex).Click(WebDriver);
		}

		public bool RemoveCustomQuoteProduct(int productIndex = 0, int groupIndex = 0)
		{
			RemoveCustomQuoteProducts(productIndex, groupIndex).Click(WebDriver);
			return true;
		}

		public string LblQuoteIdOnDraftQuotePage()
		{
			var quoteId = lblQuoteIdText.GetText(WebDriver).Split(' ')[0];
			return quoteId;
		}

		#region Group Addresses

		public IWebElement ShippingGroupInfoCollapsibleLnk(int? shippingGroupIndex = 0)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_shippingGroupInfo_" + shippingGroupIndex + "']//a"));
		}

		public IWebElement ShippingGroupInfoCollapsibleLnk()
		{
			return WebDriver.GetElement(By.XPath("//accordion-group/div/div[1]/div/div/div/span"));
		}


		public IWebElement GroupLevelShippingAddNewAddress(int? shippingGroupIndex)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_shipment-" + shippingGroupIndex + "_addNewAddress"));
		}

		public IWebElement GroupLevelShippingAddNewContact(int? shippingGroupIndex)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_shipment-" + shippingGroupIndex + "_addNewContact"));
		}

		public IWebElement GroupLevelShippingAddressEdit(int? shippingGroupIndex)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_shipment-" + shippingGroupIndex + "_editAddress"));
		}

		public IWebElement GroupLevelShippingChangeCustomer(int? shippingGroupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_changeCustomer_" + shippingGroupIndex));
		}

		public IWebElement GroupLevelShippingChangeShippingAddress(int? shippingGroupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_shipment-" + shippingGroupIndex + "_chooseAddress"));

		}

		public IWebElement GroupLevelShippingShippingAddressInfo(int? shippingGroupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_shippingInformation_" + shippingGroupIndex));
		}

		public IWebElement GroupLevelShippingInfo(int? shippingGroupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_shippingArea_" + shippingGroupIndex));
		}

		public IWebElement GroupLevelShippingEditAddress(int? shippingGroupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_editAddress_" + shippingGroupIndex));
		}

		public IWebElement GroupLevelShippingAddr(int? shippingGroupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_shippingAddress_" + shippingGroupIndex));
		}

		#endregion


		public IWebElement InputCustomFieldAtIndex(int? index = 0)
		{
			return WebDriver.GetElement(By.Id("customFieldInput_" + index));
		}

		public IWebElement DeleteCustomFieldAtIndex(int? index = 0)
		{
			return WebDriver.GetElement(By.XPath("//label[@for='customFieldInput_" + index + "'" + "]/following-sibling::a"));
		}

		public IWebElement ConfigureItems(int? Index)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_LI_configItem_0_" + Index));
		}

		public IWebElement UpdateQtyCollapsedAtGroupAndItem(int? group = 0, int? index = 0)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_LI_quantity_"+ group +"_" + index));
		}

		public void SelectStatus(IWebDriver WebDriver, String Status, IWebElement Element1)
		{
			if (Status.ToString() == " " || Status.ToString() == "Active" || Status.ToString() == "Hold" || Status.ToString() == "Inactive" || Status.ToString() == "Suspend" || Status.ToString() == "DNBMatchHold")
			{
				Element1.PickDropdownByText(WebDriver, Status);
				BtnApply.Click();
				WebDriver.VerifyBusyOverlayNotDisplayed();
			}

		}


		public List<Dictionary<string, object>> GetAddressTableViewLocations()
		{
			AddressesTable.WaitForElement(WebDriver);

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

		public List<Dictionary<string, object>> GetAddnewContactTable()
		{
			AddressesTable.WaitForElement(WebDriver);

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

		public List<Dictionary<string, object>> GetAddressTableFromSubscriptionBillingTab(int? index)
		{
			GetSkuSummaryGrid(index).WaitForElement(WebDriver);
			return GetSkuSummaryGrid(index).GetTableData(WebDriver);
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

		#region Ship Group Shipping And Summary Elements

		public IWebElement DdlGroupLevelShippingMethod(int? groupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_" + groupIndex + "_shippingMethod"));
		}

		public By ByDdlGroupLevelShippingMethod(int? groupIndex = 0)
		{
			return By.Id(pagePrefix + "_GI_" + groupIndex + "_shippingMethod");
		}

		public IWebElement LblItemLevelShippingPrice(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_SI_shippingPrice_" + lineItemIndex));
		}

		public IWebElement TxtGroupLevelShippingDiscount(int? groupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_" + groupIndex + "_shippingManualDiscount"));
		}
		public IWebElement TxtGroupLevelShippingPrice(int? groupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_" + groupIndex + "_shippingPrice"));
		}

		public IWebElement TxtGroupLevelpromotionalShippingDiscount(int? groupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_" + groupIndex + "_shippingDiscount"));
		}
		public IWebElement TxtGroupLevelShippingPriceInCustomMode(int? groupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_" + groupIndex + "_shippingCharge"));
		}


		public IWebElement LblGroupLevelTotalShipping(int? groupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_totalShippingAmount_" + groupIndex));
		}

		public IWebElement LblGroupLevelSubTotal(int? groupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_sellingPrice_" + (groupIndex - 1)));
		}

		public IWebElement LblGroupLevelTotalTax(int? groupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_tax_" + (groupIndex - 1)));
		}

		public IWebElement LblGroupLevelTotalEcoFee(int? groupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_ehf_" + (groupIndex - 1)));
		}

		public IWebElement LblGroupLevelTotalAmount(int? groupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_totalAmount_" + (groupIndex - 1)));
		}
		public IWebElement ConfigItemsViewMore(int index)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='toggleMoreLess_0_" + index));
		}

		public IWebElement GetParentServiceTagValue(int index)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='_LI_ParentServiceTag_0_" + index + "']"));
		}

		public IWebElement ParentServiceTag(int shippingGroup = 1, int itemIndex = 1)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_accordionMore_" + (shippingGroup - 1) + "_" + (itemIndex - 1) + "']//div[4]/label"));
		}

		public CreateQuotePage ParentServiceTagLabel(int index)
		{
			try
			{
				WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_accordionMore_0_" + index + "']//div//label[contains(text(), 'Parent Service Tag')]")).IsElementDisplayed(WebDriver).Should().BeFalse();
			}
			catch (NoSuchElementException e)
			{
				// Do Nothing
			}
			return new CreateQuotePage(WebDriver);
		}

		#endregion

		#region Line Items



		public IWebElement CopyItem(int? shippingGroup = 1, int? product = 1)
		{
			return WebDriver.FindElement(By.Id(pagePrefix + "_LI_copyItem_" + (shippingGroup - 1) + "_" + (product - 1)));
		}


		public IWebElement ConnectToOpportunityItem(int? shippingGroup = 1, int? product = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_connectOpportunityProduct_" + (shippingGroup - 1) + "_" + (product - 1)));
		}

		public IWebElement LblProductTypeAccordionUnderViewMore(int shippingGroup = 1, int itemIndex = 1)
		{
			return WebDriver.FindElement(By.XPath(@"//*[@id='quoteCreate_accordionMore_" + (shippingGroup - 1) + "_" + (itemIndex - 1) + "']/div[1]/div[2]/div/div"));
		}

		public IWebElement LblProductTypeUnderViewMore(int shippingGroup = 1, int itemIndex = 1)
		{
			return WebDriver.FindElement(By.XPath(@"//label[contains(@id, '_" + (shippingGroup - 1) + "_" + (itemIndex - 1) + "_label')]"));
		}

		public IWebElement LblOrderCodeUnderViewMore(int shippingGroup = 1, int itemIndex = 1)
		{
			return WebDriver.FindElement(By.Id(pagePrefix + "_LI_orderCode_" + (shippingGroup - 1) + "_" + (itemIndex - 1)));
		}

		public IWebElement LnkViewMore(int shippingGroup = 1, int itemIndex = 1)
		{
			return WebDriver.FindElement(By.Id("toggleMoreLess_" + (shippingGroup - 1) + "_" + (itemIndex - 1)));
		}

		public IWebElement LblSkuUnderViewMore(int shippingGroup = 1, int itemIndex = 1)
		{
			return WebDriver.FindElement(By.Id(pagePrefix + "_LI_skuNumber_" + (shippingGroup - 1) + "_" + (itemIndex - 1)));
		}

		public IWebElement LblNonTiedListPrice(int shippingGroup = 1, int itemIndex = 1)
		{
			return WebDriver.FindElement(By.Id(pagePrefix + "_Sku_PI_unitPrice_" + (shippingGroup - 1) + "_" +
											   (itemIndex - 1) + "_"));
		}

		public IWebElement CopyGroup(int? shippingGroupIndex = 0)
		{//quoteCreate_LI_copyItem_0_
			return WebDriver.FindElement(By.Id(pagePrefix + "_shipment-" + shippingGroupIndex + "_copyGroup"));
		}
		public IWebElement MoveItem(int? shippingGroupIndex = 0, int? productIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_moveToLink_" + shippingGroupIndex + "_" + productIndex));
		}

		public IWebElement AddNewShippingGroup()
		{
			return WebDriver.GetElement(By.XPath("//span[contains(text(),'Add New Shipping Group')]"));
		}


		public IWebElement ShippingPrice(int? shippingGroupIndex = 0)
		{
			return WebDriver.FindElement(By.Id(pagePrefix + "_GI_" + shippingGroupIndex + "_shippingPrice"));
		}


		public IWebElement SplitQuoteCancel { get { return WebDriver.GetElement(By.Id("quoteSplit_cancel")); } }

		//[FindsBy(How = How.XPath, Using = ".//input[@data-ng-model='model.choosenQty' and @data-ng-click ='$event.stopPropagation()']")]

		public IWebElement QuantityText { get { return WebDriver.GetElement(By.XPath("//*[contains(@id, '_copy_input')]/input")); } }


		public IWebElement SaveChanges { get { return WebDriver.GetElement(By.Id("selectDestinationGroupMoveButton")); } }


		public IWebElement CancelChanges { get { return WebDriver.GetElement(By.Id("selectDestinationGroupCancelButton")); } }


		public IWebElement SelectAll_Link { get { return WebDriver.GetElement(By.Id("_shipping_item_title")); } }

		public IWebElement BtnAddItemFromSearch(int? shippingGroupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_additem_top_" + shippingGroupIndex + "_"));

			//return WebDriver.GetElements(By.XPath("//button[contains(@id,'" + pagePrefix + "_additem_top_')]"))[shippingGroupIndex - 1];
		}

		public IWebElement LnkRemoveItem(int itemIndex = 1)
		{
			return WebDriver.GetElements(By.XPath("//button[contains(@id,'" + pagePrefix + "_LI_removeItem_0_" + (itemIndex - 1).ToString() + "')]"))[0];
		}

		public IWebElement LnkRemoveItemAt(int? shippingIndex = 0, int? itemIndex = 0)
		{

			return WebDriver.FindElement(By.XPath("//button[contains(@id,'" + pagePrefix + "_LI_removeItem_" + shippingIndex + "_" + itemIndex + "')]"));
		}

		public IWebElement LnkRemoveShippingGroupAt(int? shippingGroup = 0)
		{

			return WebDriver.GetElement(By.XPath("//button[@id='quoteCreate_shipment-" + shippingGroup + "_removeShipment']"));
		}

		public IWebElement LnkItemLevelSplit(int lineitemIndex)
		{
			return WebDriver.GetElements(By.Id("quoteCreate_lineItem_split"))[lineitemIndex - 1];
		}

		public IWebElement ItemLevelQuantity(int? shippingIndex = 0, int? itemIndex = 0)
		{
			return WebDriver.FindElement(By.XPath("//input[contains(@id,'" + pagePrefix + "_LI_quantity_" + shippingIndex + "_" + itemIndex + "')]"));
		}


		public IWebElement MsgItemLevelDamValidation(int lineItemIndex = 1)
		{
			//var lstwebelements = WebDriver.GetElements(By.XPath("//span[contains(@id,'" + pagePrefix + "_dealValidationErrorMessage_LI')]"), TimeSpan.FromSeconds(10));
			//This is temp fix Ft2 dev is working on element id addition for new DAM message
			var lstwebelements = WebDriver.GetElements(By.XPath("//p[contains(text(),'approval is required')]"), TimeSpan.FromSeconds(10));
			if (lstwebelements != null && lstwebelements.Count > 0)
			{
				return lstwebelements[lineItemIndex - 1];
			}
			return null;
		}


		public IWebElement MsgItemLevelInvalidGoalDealId(int lineItemIndex = 1)
		{
			//var lstwebelements = WebDriver.GetElements(By.XPath("//span[contains(@id,'" + pagePrefix + "_dealValidationErrorMessage_LI')]"), TimeSpan.FromSeconds(10));
			//This is temp fix Ft2 dev is working on element id addition for new DAM message
			var lstwebelements = WebDriver.GetElements(By.XPath("//*[contains(text(),'GOAL Deal is not valid')]"), TimeSpan.FromSeconds(10));
			if (lstwebelements != null && lstwebelements.Count > 0)
			{
				return lstwebelements[lineItemIndex - 1];
			}
			return null;
		}

		public IWebElement MsgItemLevelDamValidationQty(int lineItemIndex = 1)
		{
			//var lstwebelements = WebDriver.GetElements(By.XPath("//span[contains(@id,'" + pagePrefix + "_dealValidationErrorMessage_LI')]"), TimeSpan.FromSeconds(10));
			//This is temp fix Ft2 dev is working on element id addition for new DAM message
			var lstwebelements = WebDriver.GetElements(By.XPath("//*[contains(text(),'exceeded GOAL Deal discount limits')]"), TimeSpan.FromSeconds(10));
			if (lstwebelements != null && lstwebelements.Count > 0)
			{
				return lstwebelements[lineItemIndex - 1];
			}
			return null;
		}

		public IWebElement MsgNonTiedItemLevelDamValidation(int nonTiedItemIndex = 1)
		{
			var lstwebelements = WebDriver.GetElements(By.XPath("//span[contains(@id,'_sku_dealValidationErrorMessage_LI_NTSKU_')]"), TimeSpan.FromSeconds(30));
			if (lstwebelements != null && lstwebelements.Count > 0)
			{
				return lstwebelements[nonTiedItemIndex - 1];
			}
			return null;
		}

		//Need to check with team if this is needed as the below one has the group level and Item level index
		public IWebElement LnkItemLevelProductDescription(int groupIndex = 1, int lineIndex = 1, int itemIndex = 1)
		{
				return WebDriver.GetElement(By.Id(pagePrefix + "_LI_CS_category_build_category_" + (groupIndex - 1) + "_" + (lineIndex - 1)+ "_" + (itemIndex - 1)));
			
		}
		public IWebElement ItemProductDescription(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_productDescription_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemConnectedToOpportunityLineItem(int lineItemIndex = 1)
		{
			return WebDriver.GetElements(By.XPath("//p[contains(@id,'" + pagePrefix + "_LI_productDescription_')]"))[lineItemIndex - 1];
		}

		public IWebElement LnkDisconnectFrompportunityLineItem(int lineItemIndex = 1)
		{
			return
				WebDriver.GetElements(By.XPath("//a[contains(@id,'" + pagePrefix + "_LI_productDescription_')]//a"))[
					lineItemIndex - 1];
		}

		public IWebElement MsgItemLevelContarctCodeMissing(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_contractMissingMsg"));
		}

		public IWebElement LblItemValidations(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + pagePrefix + "_item_validations_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']//span[contains(text(),'restricted')]"));
		}

		public IWebElement ByLblItemLevelUnitListPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_PI_unitPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemLevelUnitCost(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_PI_Unitcost_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement ByLblItemLevelUnitDiscount(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_PI_dol_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement ByTxtItemLevelUnitSellingPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_unitSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
			//return
			//    By.Id(pagePrefix + "_LI-PI_unitSellingPrice_input_" + (groupIndex - 1) + "_" +
			//              (lineItemIndex - 1));            
		}

		public IWebElement TxtItemLevelAposUnitSellingPrice(int lineItemIndex = 1)
		{
			return
				WebDriver.GetElements(By.XPath("//input[contains(@id,'" + pagePrefix + "_SEItem_unitSellingPrice_')]"))[
					lineItemIndex - 1];
			//return WebDriver.GetElement(By.XPath(@".//input[@id='" + pagePrefix + "_LI_PI_unitSellingPrice_" + lineItemIndex + "']"));
		}

		public IWebElement TblItemLevelSmartpriceTableOnUnitSellingPrice()
		{
			return
				WebDriver.GetElement(
					By.XPath("//div[contains(@id, '_LI_PI_unitSellingPrice_')]/following-sibling::div//table"),
					TimeSpan.FromSeconds(15));
		}

		public CreateQuotePage CloseSmartpricePopup()
		{
			WebDriver.GetElements(By.XPath("//button[@class='smp-val-close']"))
				.SingleOrDefault(a => a.Displayed)
				.Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public IWebElement TblItemLevelSmartpriceTableOnDiscountOffList()
		{
			return
				WebDriver.GetElements(
						By.XPath(
							"//*[contains(@id, 'quoteCreate_LI_PI_dolPercentage_smartPrice_input')]/../following-sibling::div//table"))
					.SingleOrDefault(a => a.Displayed);


		}

		public IWebElement TxtLineItemDolValue(int index = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_dolPercentage_0_" + index));
			//return WebDriver.GetElement(By.Id(pagePrefix + "_LI_PI_dolPercentage_smartPrice_input_0_" + index));
		}
		public IWebElement LblItemLevelUnitSmartpriceRevenue(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_PI_unitCompRevenue_" + lineItemIndex));
		}

		public IWebElement ByLblItemLevelUnitMargin(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_PI_unitMargin_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement ByLblItemLevelContractDiscount(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_PI_contractDiscountPercentage_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemLevelRenewalPrice(int lineItemIndex = 1)
		{
			return
				WebDriver.GetElements(By.XPath("//div[contains(@id,'" + pagePrefix + "_LI_Snp_MonthlyPayment')]"))[
					lineItemIndex - 1];

		}


		public IWebElement LblItemLevelDfsRevenuePrice(int lineItemIndex = 1)
		{
			return WebDriver.GetElements(By.XPath("//*[contains(@id,'" + pagePrefix + "_GI_revenue_Incentive_')]"))[lineItemIndex - 1];

		}

		public IWebElement LblNonTiedItemLevelRevenuePrice(int lineItemIndex = 1)
		{
			return
				WebDriver.GetElements(By.XPath("//div[contains(@id,'" + pagePrefix + "_Sku_Snp_RenewalPrice')]"))[
					lineItemIndex - 1];

		}

		public IWebElement ByLblItemLevelPromotions(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_PI_promotionsPercentage_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement ByTxtItemLevelDiscountOffList(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + pagePrefix +"_LI_dolPercentage_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)+ "' and @class='dds__form-control smartPriceGuidanceContainer ng-untouched ng-pristine ng-valid']"));
			//return By.Id(pagePrefix + "_LI_PI_dolPercentage_smartPrice_input_" + (groupIndex - 1) + "_" + (lineItemIndex - 1));
		}

		//////////////quoteCreate_LI_dolPercentage_0_0


		public string GetItemLevelDiscount(int index, int groupIndex)
		{
			return ByTxtItemLevelDiscountOffList(index, groupIndex).GetText(WebDriver);
		}
		public IWebElement ExpandItemInManualMode(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement ByTxtItemLevelQuantity(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_quantity_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));

		}

		public IWebElement UpdateQuantityInManualMode(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_quantity_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}
		public IWebElement UpdateQuantityInManualModeNonTied(int lineItemIndex = 1, int groupIndex = 1, int skuIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_quantity_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "_" + (skuIndex - 1)));
		}
		public IWebElement UpdateSellingPriceInManualMode(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_unitSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement UpdateDOLInManualMode(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_dolPercentage_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement UpdateDolInManualModeNontied(int lineItemIndex = 1, int groupIndex = 1, int skuIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_dolPercentage_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "_" + (skuIndex - 1)));
		}

		public IWebElement LblpremUnitSellingPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_PI_premUnitSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LinkMatchPremierPriceItem(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + pagePrefix + "_LI_PI_premUnitSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/div/a"));
		}
		public IWebElement LinkMatchPremierPriceGroup(int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//a[contains(text(),'Match previous Online price')][" + groupIndex + "]"));
		}
		public IWebElement TickMatchPremierPriceItem(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + pagePrefix + "_LI_PI_premUnitSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/div/div"));
		}
		public IWebElement TickMatchPremierPriceGroup(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//a[contains(text(),'Match previous Online price')][" + groupIndex + "]//following-sibling::div"));
		}
		public IWebElement LblSummaryPremierSellingPrice()
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_summary_totalPremierPrice"));
		}

		public IWebElement CopyShippingGroupSelectItem(int ItemIndex = 0)
		{
			string xpa = "//div[@id='_groupCheck_" + ItemIndex + "_" + ItemIndex + "']/input";
			return WebDriver.GetElement(By.XPath(xpa));
		}
		public IWebElement DdlItemLevelCadence(int lineItemIndex = 1)
		{
			return
				WebDriver.GetElements(By.XPath("//select[contains(@id,'" + pagePrefix + "_cadence_')]"))[
					lineItemIndex - 1];
		}

		public IWebElement LblItemLevelQuantity(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_quantity_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement ByLblItemLevelListPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_totalListPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemLevelCost(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_cost_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement ByLblItemLevelDiscount(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_totalDiscountPercent_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement ByLblItemLevelSellingPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_pricingInformation_sellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));

		}

		public IWebElement LblItemLevelSmartpriceRevenue(int groupIndex = 1, int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_smartPriceRevenue_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement ByLblItemLevelMargin(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_itemMarginPercentage_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement ByTxtContractCode(int groupIndex = 1, int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id("Quote_contractCode_input"));
		}

		public IWebElement ByTxtContractCodeCanada(int groupIndex = 1, int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_LI_contractCode_input_" + (groupIndex) + "_" + lineItemIndex));
		}

		public string TxtShippingOfContractCode(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("_//*[@id='quoteCreate_LI_contractCode_1']/../span")).GetText(WebDriver);
		}

		public IWebElement TxtContractCodeAt(int? groupIndex = 1, int? lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id("Quote_contractCode_input"));
		}
		//public IWebElement LblContractCode(int lineItemIndex = 1)
		//{
		//    return WebDriver.GetElement(By.Id(pagePrefix + "_LI_contractCode_" + lineItemIndex));
		//}

		public IWebElement LnkGroupLevelGoalDealIdPickFromList(int lineGroupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_selectGoalDealId_" + lineGroupIndex));
		}

		public IWebElement LnkItemLevelGoalDealIdNewRequest(int lineItemIndex = 1)
		{
			return WebDriver.GetElements(By.XPath("//a[contains(@id,'" + pagePrefix + "createNewGoalDealId')]"))[lineItemIndex - 1];
		}

		public IWebElement LnkItemLevelGoalDealIdPickFromList(int lineItemIndex = 1)
		{

			var wait = new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime);
			ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("goalPickFromListId"));
			var lstwebelements = WebDriver.GetElements(By.XPath("//a[contains(@id,'goalPickFromListId')]"));
	

			if (lstwebelements != null && lstwebelements.Count > 0)
			{
				return lstwebelements[lineItemIndex - 1];
			}
			return null;
		}

		public IWebElement LnkSolGroupLevelGoalDealIdPickFromList(int SolgroupIndex = 1)
		{
			return
				WebDriver.GetElement(
					By.XPath("//div[contains(@id,'" + pagePrefix + "_GI_info_goalDealId_" + (SolgroupIndex - 1) +
							 "')]/following-sibling::div//a[contains(text(),'Pick from list')]"));
		}

		public IWebElement LnkItemLevelGoalTool(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_openGoalTool_" + lineItemIndex));
		}

		public IWebElement LblItemLevelGoalDealId(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_info_goalDealId_" + lineItemIndex));
		}

		public IWebElement LblNonTiedItemLevelGoalDealId(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_NonTied_info_goalDealId_" + lineItemIndex));
		}


		public IWebElement LblItemLevelSummarySellingPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_pricingTotals_sellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		//Need to check and remove this
		//public IWebElement LblItemLevelTotalCost(int lineItemIndex = 1)
		//{
		//    return WebDriver.GetElement(By.XPath("id('PricingSummary_" + lineItemIndex + "')/div[2]/div[1]"));
		//}

		public IWebElement LblItemLevelTotalShipping(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_totalShippingAmount_" + lineItemIndex));
		}


		public IWebElement LblItemLevelSummaryTotalTax(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_tax_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemLevelTotalEcoFee(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_ehf_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemLevelTotalAmount(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_totalAmount_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LnkItemLevelShowMore(int lineItemIndex = 1)
		{
			return
				WebDriver.GetElement(By.XPath("id('" + pagePrefix + "_LI_show_more_" + lineItemIndex + "')/div[1]/a[1]"));
		}

		public IWebElement LnkItemLevelExpandCollapse(int groupIndex = 1, int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemLevelFulfillmentTime(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_itemBuildTime_" + lineItemIndex));
		}

		public IWebElement LblItemLevelOrderCode(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_orderCode_" + lineItemIndex));
		}

		public IWebElement LblItemLevelShippingPriceUnderShowMore(int lineItemIndex = 1)
		{
			return
				WebDriver.GetElement(
					By.XPath("id('" + pagePrefix +
							 "_accordion_0')/div[2]/div[3]/div[1]/div[1]/div[6]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[6]/div[2]"));
		}

		public IWebElement LnkItemLevelPickDifferentAddress(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_SI_shippingPickAddressLink_" + lineItemIndex));
		}

		public IWebElement LblItemLevelShippingAddress(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_SI_addressInformation_" + lineItemIndex));
		}

		public IWebElement LnkItemLevelAddShippingAddress(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_SI_shippingNewAddressLink_" + lineItemIndex));
		}

		public IWebElement LblItemLevelShippingInfoEmailAddress(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_SI_emailAddress_" + lineItemIndex));
		}

		public IWebElement LnkItemLevelShippingInfoEmailAddressSearch(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_SI_searchEmailAddress_" + lineItemIndex));
		}

		public IWebElement LblItemLevelShippingInfoChangeEmailAddress(int lineItemIndex = 1)
		{
			return
				WebDriver.GetElement(
					By.XPath("id('" + pagePrefix + "_LI_SI_grid_ext_" + lineItemIndex +
							 "')/div[2]/div[2]/span[2]/a[1]/span[1]"));
		}

		public IWebElement LblItemLevelShippingInfoMustArriveByDate(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_mabd_startDate"));
		}
		public IWebElement TextMABD(int groupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_arriveByDate_" + groupIndex));
		}

		public IWebElement LblGroupLevelShippingInfoEdd(int? groupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_EDD_Max_" + groupIndex));

		}

		public IWebElement ApplyAllShippMethod(int? groupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_" + groupIndex + "_" + "methodApplyAll"));
		}

		public IWebElement ApplyAllMABD(int? groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_" + groupIndex + "_" + "mabdApplyAll"));
		}

		public IWebElement ApplyAllInstructions(int? groupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_" + groupIndex + "_" + "instructionsApplyAll"));
		}


		public IWebElement LblItemLevelAddShippingInstruction(int lineItemIndex = 1)
		{
			return
				WebDriver.GetElement(
					By.XPath("id('" + pagePrefix + "_LI_SI_grid_ext_" + lineItemIndex + "')/div[7]/div[1]/a[1]"));
		}

		public IWebElement TextShippingInstructionAtGroupAndIndex(int? shippingIndex = 0, int? instructionIndex = 0)
		{
			return
				WebDriver.GetElement(
				By.XPath("//input[contains(@id,'" + pagePrefix + "_GI_shippingInstructions_" + shippingIndex + "_" + instructionIndex + "')]"));

		}

		public IWebElement LnkAddShippingInstructionAtGroup(int? shippingIndex = 0)
		{
			return
				WebDriver.GetElement(
				By.XPath("//a[contains(@id,'" + pagePrefix + "_GI_addNewInstruction_link_" + shippingIndex + "')]"));

		}

		public IWebElement LblItemLevelEddMin(int groupNum = 1, int lineItemNum = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_EDD_Minimum_" + (groupNum - 1) + "_" + (lineItemNum - 1)));
		}

		public IWebElement LblItemLevelEddMax(int groupNum = 1, int lineItemNum = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_EDD_Maximum_" + (groupNum - 1) + "_" + (lineItemNum - 1)));
		}

		public IWebElement LblItemLevelExpandAllConfiguration(int lineItemIndex = 1)
		{
			return
				WebDriver.GetElement(
					By.XPath("id('" + pagePrefix +
							 "_accordion_0')/div[2]/div[3]/div[1]/div[1]/div[6]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/a[1]"));
		}

		#region non-tied Elements

		public IWebElement LblItemLevelNonTiedUnitListPrice(int groupIndex = 1, int itemIndex = 1, int nonTiedIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='2_Sku_PI_unitPrice_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedIndex - 1) +"\']"));
		}

		public IWebElement LblItemLevelNonTiedUnitDiscount(int groupIndex = 1, int itemIndex = 1, int nonTiedIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='2_Sku_PI_dol_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedIndex - 1) + "\']"));

		}

		public IWebElement LblItemLevelNonTiedUnitCost(int nonTiedIndex = 1)
		{
			return WebDriver.GetElements(By.XPath("//[contains(@id,'" + pagePrefix + "_Sku_PI_unitCost')]"))[nonTiedIndex - 1];
		}

		public IWebElement TxtItemLevelNonTiedUnitSellingPrice(int lineItemIndex = 1, int groupIndex = 1, int nonTiedItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_unitSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "_" + (nonTiedItemIndex - 1)));
		}

		public IWebElement TxtItemLevelUnitSellingPriceNonTied(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_unitSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "_"));
			//return WebDriver.GetElement(By.Id(pagePrefix + "_Sku_PI_unitSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "_"));
		}

		public IWebElement ByTxtItemLevelDiscountOffListNonTied(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_Sku_discount_input_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "_" + (groupIndex - 1)));
		}

		public IWebElement LblItemLevelNonTiedSmartpriceRevenue(int nonTiedIndex = 1)
		{
			return WebDriver.GetElements(By.XPath("//div[contains(@id,'_Sku_PI_unitCompRevenue_')]"))[nonTiedIndex - 1];
		}

		public IWebElement LblItemLevelNonTiedUnitMargin(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_Sku_PI_unitMargin_" + lineItemIndex));
		}

		public IWebElement LblItemLevelNonTiedContractDiscount(int lineItemIndex = 1)
		{
			return
				WebDriver.GetElement(
					By.XPath("id('" + pagePrefix +
							 "_accordion_0')/div[2]/div[3]/div[1]/div[1]/div[6]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]"));
		}

		public IWebElement LblItemLevelNonTiedPromotions(int lineItemIndex = 1)
		{
			return
				WebDriver.GetElement(
					By.XPath("id('" + pagePrefix +
							 "_accordion_0')/div[2]/div[3]/div[1]/div[1]/div[6]/div[3]/div[1]/div[2]/div[1]/div[2]/div[1]"));
		}

		public IWebElement TxtItemLevelNonTiedDiscountOffList(int lineItemIndex = 1, int groupIndex = 1, int nonTiedItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_dolPercentage_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "_" + (nonTiedItemIndex - 1)));
		}

		public IWebElement TxtItemLevelNonTiedQuantity(int shippingGroupIndex = 1, int itemIndex = 1, int nonTiedItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_quantity_" + (shippingGroupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedItemIndex - 1)));
		}

		public IWebElement LblItemLevelNonTiedListPrice(int groupIndex = 1, int itemIndex = 1, int nonTiedIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='2_totalListPrice_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedIndex - 1) + "\']"));
		}

		public IWebElement LblItemLevelNonTiedCost(int lineItemIndex = 1)
		{
			return
				WebDriver.GetElement(
					By.XPath("id('" + pagePrefix +
							 "_accordion_0')/div[2]/div[3]/div[1]/div[1]/div[6]/div[3]/div[1]/div[1]/div[3]/div[3]/div[1]"));
		}

		public IWebElement LblItemLevelNonTiedDiscount(int groupIndex = 1, int itemIndex = 1, int nonTiedIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='2_totalDiscountValue_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedIndex - 1) + "\']/span"));
		}

		public IWebElement LblItemLevelNonTiedSellingPrice(int groupIndex = 1, int itemIndex = 1, int nonTiedIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='2_Sku_Quantity_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedIndex - 1) + "\']"));
		}

		public IWebElement LblItemLevelNonTiedTotalSmartpriceRevenue(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_Sku_compRevenue_" + lineItemIndex));
		}

		public IWebElement LblItemLevelNonTiedMargin(int lineItemIndex = 1)
		{
			return
				WebDriver.GetElement(
					By.XPath("id('" + pagePrefix +
							 "_accordion_0')/div[2]/div[3]/div[1]/div[1]/div[6]/div[3]/div[1]/div[1]/div[3]/div[7]/div[1]"));
		}

		public IWebElement LnkItemLevelNonTiedGoalDealIdNewRequest(int lineItemIndex = 1)
		{
			return
				WebDriver.GetElement(
					By.XPath("id('" + pagePrefix + "_LI_NonTied_info_goalDealId_" + lineItemIndex + "')/div[1]/a[1]"));
		}

		public IWebElement LnkItemLevelNonTiedGoalDealIdPickFromList(int lineItemIndex = 1)
		{
			return
				WebDriver.GetElement(
					By.XPath("id('" + pagePrefix + "_LI_NonTied_info_goalDealId_" + lineItemIndex + "')/div[1]/a[2]"));
		}

		public IWebElement LnkItemLevelNonTiedGoalTool(int lineItemIndex = 1)
		{
			return
				WebDriver.GetElement(
					By.XPath("id('" + pagePrefix + "_LI_NonTied_info_goalDealId_" + lineItemIndex + "')/div[1]/a[3]"));
		}

		public IWebElement LnkItemLevelNonTiedShowMore(int lineItemIndex = 1)
		{
			return
				WebDriver.GetElement(
					By.XPath("id('" + pagePrefix + "_LI_Sku_collapsible_d8e22ee8-cfde-4d54-b57e-8874a9d94e13_" +
							 lineItemIndex + "')/div[1]/a[1]/i[1]"));
		}

		public IWebElement TblItemLevelNonTiedSmartpricePopupOnUnitSellingPrice(int lineItemIndex = 1)
		{
			return
				WebDriver.GetElements(
						By.XPath("//*[contains(@id, '" + pagePrefix +
								 "_Sku_PI_unitSellingPrice')]/../following-sibling::div//table"))
					.SingleOrDefault(a => a.Displayed);
		}

		public IWebElement TblItemLevelNonTiedSmartpricePopupOnDiscountOffList(int lineItemIndex = 1)
		{
			return
				WebDriver.GetElements(
						By.XPath("//*[contains(@id, '" + pagePrefix +
								 "_Sku_PI_unitPercent')]/../following-sibling::div//table"))
					.SingleOrDefault(a => a.Displayed);
		}
		#endregion


		public IWebElement DivSmartpricepopupOnSellingPrice(int itemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath(@"//button[@class='smp-val-close']/.."));
		}

		public IWebElement DivSmartpriceConditionalMessage(IWebElement smartpriceDiv)
		{
			return smartpriceDiv.GetChildElement(By.XPath(".//div[@class='conditionalMsg']"));
		}

		public IWebElement DivSmartpriceGenericMessage(IWebElement smartpriceDiv)
		{
			return smartpriceDiv.GetChildElement(By.XPath(".//div[@class='mg-top-15']"));
		}

		public IWebElement DivSmartpricepopupOnDol(int itemIndex = 1)
		{
			return
				WebDriver.GetElement(
					By.XPath(@"//button[@class='smp-val-close']/.."));
		}

		public IWebElement DivSmartpricepopupOnSellingPriceNonTied(int itemIndex = 1)
		{
			return
				WebDriver.GetElement(
					By.XPath(@"//button[@class='smp-val-close']/.."));
		}

		public IWebElement DivSmartpricepopupOnDolNonTied(int itemIndex = 1)
		{
			return
				WebDriver.GetElement(
					By.XPath(@"//button[@class='smp-val-close']/.."));
		}

		public CreateQuotePage RefreshSmartprice()
		{
			BtnUpdateSmartPrice.Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public IWebElement LnkItemLevelConfigure(int configItemIndex = 1, int groupIndex = 1)
		{
			string configelement = "quoteCreate_LI_configItem_" + (groupIndex - 1) + "_" + (configItemIndex - 1).ToString();
			return WebDriver.GetElement(By.Id(configelement));
		}

		public By ByLnkItemLevelConfigure(int configItemIndex = 1, int groupIndex = 1)
		{
			return By.Id("quoteCreate_LI_configItem_" + (groupIndex -1) + "_" + (configItemIndex - 1).ToString());
		}

		public IWebElement LblItemListPriceApos(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_SEItem_listPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemSellingPriceApos(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_SEItem_unitSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemDiscountApos(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_SEItem_dolPercentage_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemTotalAmountApos(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_LI_totalAmount_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemTotalTaxApos(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_LI_tax_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement TxtValidationCustomerStatus()
		{

			return WebDriver.GetElement(By.Id("validation_customerstatus"));
		}



		public IWebElement ByItemSummaryModRevenueLabel(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + pagePrefix + "_LI_rawCompRevenue_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"));
		}
		public IWebElement ByItemSummaryModRevenueValue(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + pagePrefix + "_LI_rawCompRevenue_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']"));
		}

		public IWebElement ByItemSummarySPRevenueLabel(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + pagePrefix + "_LI_smartPriceRevenue_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"));
		}
		public IWebElement ByItemSummarySPRevenueValue(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + pagePrefix + "_LI_smartPriceRevenue_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']"));
		}

		public IWebElement ByItemSummaryPricingModifierLabel(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + pagePrefix + "_LI_pricingModifier_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"));
		}
		public IWebElement ByItemSummaryPricingModifierValue(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + pagePrefix + "_LI_pricingModifier_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']"));
		}

		public IWebElement ByItemSummaryServiceIncentiveLabel(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + pagePrefix + "_LI_commModifier_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"));
		}
		public IWebElement ByItemSummaryServiceIncentiveValue(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + pagePrefix + "_LI_commModifier_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']"));
		}

		public IWebElement ByItemSummaryUpSellModRevenueLabel(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + pagePrefix + "_LI_servicesIncentive_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"));
		}
		public IWebElement ByItemSummaryUpSellModRevenueValue(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + pagePrefix + "_LI_servicesIncentive_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/span"));
		}

		#endregion

		#region Autopilot Elements

		private const string autopilotxPath = "//auto-pilot[@shipmentindex={0} and @itemindex={1}]";

		public IWebElement AutoPilotSection(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath(string.Format(autopilotxPath, shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(10));
		}

		public IWebElement TxtTenantId(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(string.Format("quoteDetail_tenantID_{0}_{1}", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(3));
		}

		public IWebElement TxtDomain(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(string.Format("quoteDetail_domain_{0}_{1}", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(3));
		}

		public IWebElement LabelTenantId(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath(string.Format(autopilotxPath + "]//td[contains(text(), 'Tenant ID')]", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(3));
		}

		public IWebElement LabelDomain(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath(string.Format(autopilotxPath + "]//td[contains(text(), 'Domain')]", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(3));
		}

		public IWebElement LabelWindowsAutopilot(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath(string.Format(autopilotxPath + "]//td[contains(text(), 'Windows Autopilot')]", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(3));
		}

		public IWebElement LabelAutpilotInfo(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath(string.Format(autopilotxPath + "]//p[@class='alert alert-info' and @id= 'quoteDetail_Info_{0}_{1}')]", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(2));
		}

		public IWebElement LabelAutpilotSuccess(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(string.Format("quoteDetail_success_{0}_{1}", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(10));
		}
		public IWebElement LabelAutpilotFailure(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(string.Format("quoteDetail_Info_{0}_{1}", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(5));
		}
		public IWebElement LabelTenantIdInvalidInput(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath(string.Format("//auto-pilot//input[@id='quoteDetail_tenantID_{0}_{1}" + "']/parent::div//span[@class='invalid-input']", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(2));
		}

		public IWebElement LabelDomainInvalidInput(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath(string.Format("//auto-pilot//input[@id='quoteDetail_domain_{0}_{1}" + "']/parent::div//span[@class='invalid-input']", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(2));
		}

		public IWebElement IconWindowsAutopilot(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath(string.Format(autopilotxPath + "//td[contains(text(), 'Windows Autopilot')]/parent::tr//div[@class='icon icon-small-alertinfo text-blue']", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(2));
		}

		public IWebElement IconTenantId(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath(string.Format(autopilotxPath + "//td[contains(text(), 'Tenant ID')]/parent::tr//div[@class='icon icon-small-alertinfo text-blue']", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(2));
		}

		public IWebElement IconDomain(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath(string.Format(autopilotxPath + "//td[contains(text(), 'Domain')]/parent::tr//div[@class='icon icon-small-alertinfo text-blue']", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(2));
		}

		public IWebElement IconCloseWindowsAutopilot(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath(string.Format(autopilotxPath + "//td[contains(text(),'Windows Autopilot')]/parent::tr//i[@class='icon-ui-close']", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(2));
		}

		public IWebElement WindowsAutopilotPopupText(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath(string.Format(autopilotxPath + "//div[@class='popover fade right in']//div[contains(text(),'It is a collection')]", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(2));
		}

		public IWebElement AutopilotPopupLink(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath(string.Format(autopilotxPath + "//div[@class='popover fade right in']//a[contains(text(),'Microsoft')]", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(2));
		}

		public IWebElement IconCloseTenantId(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath(string.Format(autopilotxPath + "//td[contains(text(),'Tenant ID')]/parent::tr//i[@class='icon-ui-close']", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(2));
		}
		public IWebElement TenantIdPopupText(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath(string.Format(autopilotxPath + "//div[@class='popover fade right in']//div[contains(text(),'In the cloud-enabled workplace')]", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(2));
		}

		public IWebElement IconCloseDomain(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath(string.Format(autopilotxPath + "//td[contains(text(),'Domain')]/parent::tr//i[@class='icon-ui-close']", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(2));
		}

		public IWebElement DomainPopupText(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath(string.Format(autopilotxPath + "//div[@class='popover fade right in']//div[contains(text(),'A domain name is an')]", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(2));
		}


		public IList<IWebElement> LabelAutoPilotCreateQuoteNotifications { get { return WebDriver.GetElements(By.XPath("//quote-create-header-notification//div[(@class='alert-info' or @class='alert-warning') and contains(@id,'notificationMessages')]")); } }


		public IList<IWebElement> LabelAutoPilotCreateQuoteErrorNotifications { get { return WebDriver.GetElements(By.XPath("//quote-create-header-notification//div[@class='alert-error' and contains(@id,'notificationMessages')]")); } }


		public IWebElement BtnAutoPilotPopupCancel { get { return WebDriver.GetElement(By.Id("quoteDetail_cancelApplyAll")); } }


		public IWebElement CustomerNumberinHeader { get { return WebDriver.GetElement(By.Id("currentCustomer_customerNumber")); } }


		public IWebElement SaveAsOrderEnable { get { return WebDriver.GetElement(By.XPath("//button[@id='quoteCreate_saveQuoteToggle']")); } }


		public IWebElement SaveAndSplitButton { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_saveAndSplit']")); } }

		
		public IWebElement VendorProductNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_LI_vpn_0_0']")); } }
		#region Autopilot popup windonw Elements
		public IWebElement FilledALlTenantID()
		{
			return WebDriver.GetElement(By.XPath("//*[@class='col-xs-4'][2]"));
		}
		public IWebElement FilledAllDomainID()
		{
			return WebDriver.GetElement(By.XPath("//*[@class='col-xs-3'][1]"));
		}


		public IWebElement BtnautopilotpopuApplyall { get { return WebDriver.GetElement(By.Id("quoteDetail_applyAll")); } }

		public bool IsValidationPassed { get; set; }



		public IWebElement quotedetailsCancelapplyall { get { return WebDriver.GetElement(By.Id("quoteDetail_cancelApplyAll")); } }

		// current item is aviable or not

		public IWebElement lblCurrentitemtext { get { return WebDriver.GetElement(By.XPath("//span[text()='Current Item']")); } }

		// 

		public IList<IWebElement> AllColumnswithdomain { get { return WebDriver.GetElements(By.XPath("//div[@class = 'table table-fixed table-striped apply-all-table']")); } }
		//select all checkboxs

		public IWebElement SelectAllCheckBoxinpopup { get { return WebDriver.GetElement(By.Id("quoteDetail_header")); } }

		// select single checkbox

		public IWebElement SelectAnyoneCheckBoxinpopup { get { return WebDriver.GetElement(By.XPath("//mat-dialog-container//*[@id='quoteDetail_orderCheck_']")); } }

		//Get the Tenantid in current item 

		public IWebElement PatchtheTenantid { get { return WebDriver.GetElement(By.XPath("//mat-dialog-container//span[text()='Current Item']/parent::td/parent::tr//td[3]")); } }

		//Get the DomainID in current item 

		public IWebElement PatchtheDomainid { get { return WebDriver.GetElement(By.XPath("//mat-dialog-container//span[text()='Current Item']/parent::td/parent::tr//td[4]")); } }

		//Get the Tenantid in current item 

		public IWebElement GetCurrentItemTenantId { get { return WebDriver.GetElement(By.XPath("//mat-dialog-container//span[text()='Current Item']/parent::td/parent::tr//td[3]")); } }

		//Get the DomainID in current item 

		public IWebElement GetCurrentItemDomainId { get { return WebDriver.GetElement(By.XPath("//mat-dialog-container//span[text()='Current Item']/parent::td/parent::tr//td[4]")); } }


		public IWebElement GetCurrentItemInAuotpilotpopup { get { return WebDriver.GetElement(By.XPath("//mat-dialog-container//span[text()='Current Item']")); } }


		public IList<IWebElement> GetCheckBoxforAutopilotItems { get { return WebDriver.GetElements(By.XPath("//mat-dialog-container//input[@type='checkbox' and @id='quoteDetail_applyAllViewModel_']")); } }


		public IList<IWebElement> GetAllTenantIdsinAutopilotPopup { get { return WebDriver.GetElements(By.XPath("//mat-dialog-container//tr//input[@type='checkbox' and @id='quoteDetail_applyAllViewModel_']/parent::td/parent::tr//td[3]")); } }


		public IList<IWebElement> GetAllDomainIdsinAutopilotPopup { get { return WebDriver.GetElements(By.XPath("//mat-dialog-container//tr//input[@type='checkbox' and @id='quoteDetail_applyAllViewModel_']/parent::td/parent::tr//td[4]")); } }

		public IList<IWebElement> GetCheckBoxforAutopilotItemsPerShippingGroup(int shippingGroupIndex)
		{
			return WebDriver.GetElements(By.XPath($"//mat-dialog-container//td[contains(text(),'Shipping Group{shippingGroupIndex}')]/parent::tr//input[@type='checkbox' and @id='quoteDetail_applyAllViewModel_']"), TimeSpan.FromSeconds(2));
		}
		public IWebElement GetCurrentAutopilotItemPerShippingGroup(int shippingGroupIndex)
		{
			return WebDriver.GetElement(By.XPath($"//mat-dialog-container//td[contains(text(),'Shipping Group{shippingGroupIndex}')]/parent::tr//span[text()='Current Item']"), TimeSpan.FromSeconds(2));
		}
		public IList<IWebElement> GetTenantIdsforAutopilotItemsPerShippingGroup(int shippingGroupIndex)
		{
			return WebDriver.GetElements(By.XPath($"//mat-dialog-container//td[contains(text(),'Shipping Group{shippingGroupIndex}')]/parent::tr//td[3]"), TimeSpan.FromSeconds(2));
		}


		//Get DomainID with out cureent item in pop up 
		public IList<IWebElement> GetDomainIdsWithoutCurrentItemPerShippingGroup(int shippingGroupIndex)
		{
			return WebDriver.GetElements(By.XPath($"//mat-dialog-container//tr//input[@type='checkbox' and @id='quoteDetail_applyAllViewModel_']/parent::td/parent::tr//td[contains(text(),'Shipping Group{shippingGroupIndex}')]/parent::tr//td[4]"), TimeSpan.FromSeconds(2));
		}
		//Get Tenantid with out cureent item in pop up 
		public IList<IWebElement> GetTenantIdsWithoutCurrentItemPerShippingGroup(int shippingGroupIndex)
		{
			return WebDriver.GetElements(By.XPath($"//mat-dialog-container//tr//input[@type='checkbox' and @id='quoteDetail_applyAllViewModel_']/parent::td/parent::tr//td[contains(text(),'Shipping Group{shippingGroupIndex}')]/parent::tr//td[3]"), TimeSpan.FromSeconds(2));
		}
		public IList<IWebElement> GetDomainIdsforAutopilotItemsPerShippingGroup(int shippingGroupIndex)
		{
			return WebDriver.GetElements(By.XPath($"//mat-dialog-container//td[contains(text(),'Shipping Group{shippingGroupIndex}')]/parent::tr//td[4]"), TimeSpan.FromSeconds(2));
		}

		public IList<IWebElement> GetShippingGroups(int shippingGroupIndex = 1)
		{
			return WebDriver.GetElements(By.XPath($"//mat-dialog-container//td[contains(text(),'Shipping Group{shippingGroupIndex}')]"), TimeSpan.FromSeconds(3));
		}

		public IWebElement ShippingGroupItemExpand(int? groupItemIndex, int? lineItemIndex)
		{
		    return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_LI_" + groupItemIndex + "_" + lineItemIndex + "']"));
		}

		//Get Label Text for item 1 of shipping group 1

		public IWebElement GetItem1LabelDescriptionShipGroup1 { get { return WebDriver.GetElement(By.XPath("//div[@id='quoteCreate_LI_productDescription_0_0']")); } }

		//Get Label Text for item 2 of shipping group 1

		public IWebElement GetItem2LabelDescriptionShipGroup1 { get { return WebDriver.GetElement(By.XPath("//div[@id='quoteCreate_LI_productDescription_0_1']")); } }

		//Get ILabel Text Description for shipping group 2

		public IWebElement GetItem1LabelDescriptionShipGroup2 { get { return WebDriver.GetElement(By.XPath("//div[@id='quoteCreate_LI_productDescription_1_0']")); } }

		//Get Label Text for item 1 of shipping group 3

		public IWebElement GetItem1LabelDescriptionShipGroup3 { get { return WebDriver.GetElement(By.XPath("//div[@id='quoteCreate_LI_productDescription_2_0']")); } }




		#endregion Autopilot popup window elements
		#endregion

		#region Autopilot pupup window Methods




		//veerendra autopilot methods
		public string CurrentItemTenantidSelectedinPopupAsperQuote(IWebDriver driver, int shippingGroupIndex, int itemIndex)
		{
			if (GetShippingGroups(shippingGroupIndex).Count > 0)
			{
				for (int i = 0; i <= GetShippingGroups(shippingGroupIndex).Count; i++)
				{
					if (itemIndex == i + 1)
					{
						if (GetCurrentAutopilotItemPerShippingGroup(shippingGroupIndex) != null)
						{
							string tenantId = GetCurrentItemTenantId.GetText(driver);
							Logger.Write($"Autopilot section with TenantId-{tenantId} is displayed at Item-{itemIndex} in Shipping Group-{shippingGroupIndex}");
							return tenantId;

						}

					}
				}
			}
			return null;
		}

		public string CurrentItemDomainSelectedinPopupAsperQuote(IWebDriver driver, int shippingGroupIndex, int itemIndex)
		{
			if (GetShippingGroups(shippingGroupIndex).Count > 0)
			{
				for (int i = 0; i <= GetShippingGroups(shippingGroupIndex).Count; i++)
				{
					if (itemIndex == i + 1)
					{
						if (GetCurrentAutopilotItemPerShippingGroup(shippingGroupIndex) != null)
						{
							string domainId = GetCurrentItemDomainId.GetText(driver);
							Logger.Write($"Autopilot section with DomainId--{domainId} is displayed at Item--{itemIndex} in Shipping Group--{shippingGroupIndex}");
							return domainId;
						}
					}
				}
			}
			return null;
		}

		public bool SelectIteminPopup(IWebDriver driver, int shippingGroupIndex, int itemIndex)
		{
			if (GetShippingGroups(shippingGroupIndex).Count > 0)
			{
				for (int i = 0; i <= GetShippingGroups(shippingGroupIndex).Count; i++)
				{
					if (!GetCheckBoxforAutopilotItemsPerShippingGroup(shippingGroupIndex)[i].Selected)
					{
						if (itemIndex == i + 1)
						{
							GetCheckBoxforAutopilotItemsPerShippingGroup(shippingGroupIndex)[i].Click(driver);
							return true;
						}
					}
				}
			}
			return false;
		}

		public bool SelectIteminPopupAndVerifyTenantIdandDomain(IWebDriver driver, int shippingGroupIndex = 1, int itemIndex = 1)
		{
			if (GetShippingGroups(shippingGroupIndex).Count > 0)
			{
				for (int i = 0; i <= GetShippingGroups(shippingGroupIndex).Count; i++)
				{
					if (!GetCheckBoxforAutopilotItemsPerShippingGroup(shippingGroupIndex)[i].Selected)
					{
						if (itemIndex == i + 1)
						{
							GetCheckBoxforAutopilotItemsPerShippingGroup(shippingGroupIndex)[i].Click(driver);
							string tenantId = GetTenantIdsWithoutCurrentItemPerShippingGroup(shippingGroupIndex)[i].GetText(driver, TimeSpan.FromSeconds(2));
							tenantId.Equals(GetCurrentItemTenantId.GetText(driver, TimeSpan.FromSeconds(2)));
							Logger.Write($"Autopilot section with TenantId-{tenantId} is displayed at Item-{itemIndex} in Shipping Group-{shippingGroupIndex} in Autopilot Popup");
							string DominId = GetDomainIdsWithoutCurrentItemPerShippingGroup(shippingGroupIndex)[i].GetText(driver, TimeSpan.FromSeconds(2));
							DominId.Equals(GetCurrentItemDomainId.GetText(driver, TimeSpan.FromSeconds(2)));
							Logger.Write($"Autopilot section with DominId-{DominId} is displayed at Item-{itemIndex} in Shipping Group-{shippingGroupIndex} in Autopilot Popup");
							return true;
						}
					}
				}

			}
			return false;
		}

		public bool SelectAllinPopupAndVerifyTenantIdandDomain(IWebDriver driver, bool deSelect = false, bool closePopup = false)
		{

			SelectAllCheckBoxinpopup.Click(driver);

			foreach (IWebElement AllTenatIds in GetAllTenantIdsinAutopilotPopup)
			{
				string CurrentitemtenantId = GetCurrentItemTenantId.Text;
				if (!deSelect)
				{
					AllTenatIds.Text.Equals(CurrentitemtenantId);
					Logger.Write($"Autopilot section with TenantId--{CurrentitemtenantId}is displayed in Autopilot Popup");
					IsApplyAllButtonEnabled().Should().BeTrue();
					BtnautopilotpopuApplyall.IsElementClickable(WebDriver, TimeSpan.FromSeconds(5));
				}
				else
				{
					AllTenatIds.Text.Equals("-");
					Logger.Write($"Autopilot  TenantId is displayed with blank in Autopilot Popup");
					// Isapplybuttonenabled(WebDriver);
					// new ReportingPage(WebDriver).WaitForBusyIndicator(WebDriver);

				}
			}

			foreach (IWebElement AllDominIds in GetAllDomainIdsinAutopilotPopup)
			{
				string CurrentitemDominId = GetCurrentItemDomainId.Text;
				if (!deSelect)
				{
					AllDominIds.Text.Equals(GetCurrentItemDomainId);
					Logger.Write($"Autopilot section with DomainId-{GetCurrentItemDomainId} is displayed in Autopilot Popup");
					IsApplyAllButtonEnabled().Should().BeTrue();
					BtnautopilotpopuApplyall.IsElementClickable(WebDriver, TimeSpan.FromSeconds(5));
				}
				else
				{
					AllDominIds.Text.Equals("-");
					Logger.Write($"Autopilot  TenantId is displayed with blank in Autopilot Popup");
					// Isapplybuttonenabled(WebDriver);
				}
				return true;

			}

			if (closePopup == false)
			{
				BtnautopilotpopuApplyall.IsElementClickable(WebDriver, TimeSpan.FromSeconds(5));
				BtnautopilotpopuApplyall.Click(driver);
			}
			return false;
		}
		public bool sellectAllpopup(IWebDriver driver, bool deSelect = false, bool closePopup = false)
		{

			if (!deSelect)
			{
				SelectAllCheckBoxinpopup.Click(driver);
				IsApplyAllButtonEnabled().Should().BeTrue();
				BtnautopilotpopuApplyall.IsElementClickable(WebDriver, TimeSpan.FromSeconds(5));
			}
			else
			{
				SelectAllCheckBoxinpopup.Click(driver);
				SelectAllCheckBoxinpopup.Click(driver);
				Isapplybuttonenabled(WebDriver);
			}

			return false;
		}


		public bool VerifyCurrentItemAutopilotDataDisplayedonPopup(IWebDriver driver, string tenantId, string domain, int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return CurrentItemTenantidSelectedinPopupAsperQuote(driver, shippingGroupIndex, itemIndex).Equals(tenantId) && CurrentItemDomainSelectedinPopupAsperQuote(driver, shippingGroupIndex, itemIndex).Equals(domain);

		}


		public bool IsApplyAllButtonEnabled()
		{
			return BtnautopilotpopuApplyall.Enabled;
		}
		public void Isapplybuttonenabled(IWebDriver WebDriver)
		{
			var wait = new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime);
			ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("quoteDetail_applyAll"));

		}


		public void SelectAllCheckbox(IWebDriver WebDriver, Boolean deselection = true)
		{
			var serviceTagGroup = new ServiceTagSearchResultPage(WebDriver);
			SelectAllCheckBoxinpopup.SelectCheckBox(WebDriver);
			if (BtnautopilotpopuApplyall.IsElementClickable(WebDriver, TimeSpan.FromSeconds(5)))
				IsValidationPassed = IsApplyAllButtonEnabled();
			if (deselection == true)
			{
				SelectAllCheckBoxinpopup.UnSelectCheckBox(WebDriver);
			}
		}
		#endregion Autopilot popup window Methods





		#region Autopilot Methods
		public bool VerifyAutopilotSectionDisplayed(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return AutoPilotSection(shippingGroupIndex, itemIndex).IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(3)) && TxtTenantId(shippingGroupIndex, itemIndex).IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(3)) && TxtDomain(shippingGroupIndex, itemIndex).IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2));
		}
		public void PatchTenantIdandDomainData(string tenantId, string domain, int shippingGroupIndex = 1, int itemIndex = 1, bool closeAutopilotpopup = true)
		{
			TxtTenantId(shippingGroupIndex, itemIndex).SetText(WebDriver, tenantId, TimeSpan.FromSeconds(3));
			TxtTenantId(shippingGroupIndex, itemIndex).SendKeys(Keys.Tab);
			TxtDomain(shippingGroupIndex, itemIndex).SetText(WebDriver, domain, TimeSpan.FromSeconds(3));
			TxtDomain(shippingGroupIndex, itemIndex).SendKeys(Keys.Tab);
			Logger.Write($"TenantId - {tenantId} and Domain - {domain} is patched at Item-{itemIndex} in Shipping Group-{shippingGroupIndex}");
			if (closeAutopilotpopup)
				CloseAutopilotApplyAllPopup();
		}
		public bool VerifyTenantIdandDomainDataShown(string tenantId, string domain, int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return TxtTenantId(shippingGroupIndex, itemIndex).GetText(WebDriver, TimeSpan.FromSeconds(3)).Equals(tenantId) && TxtDomain(shippingGroupIndex, itemIndex).GetText(WebDriver, TimeSpan.FromSeconds(3)).Equals(domain);
		}
		public void VerifySuccessMessageAfterPatchTenantIdandDomainData(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			string authenticationSuccessMessageDisplay = "Tenant ID and Domain were successfully validated and attached to the quote";
			LabelAutpilotSuccess(shippingGroupIndex, itemIndex).GetText(WebDriver, TimeSpan.FromSeconds(10)).Should().Be(authenticationSuccessMessageDisplay);
			Logger.Write($"Autopilot section is displayed at Item-{itemIndex} in Shipping Group-{shippingGroupIndex} with authentication Success message - {authenticationSuccessMessageDisplay}");
		}

		public void VerifyFailureMessageAfterPatchTenantIDandDomainData(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			string authenticationFailureMessageDisplay = "Authentication failed. Please enter a valid Tenant ID and/or Domain to attempt re-authentication.";
			LabelAutpilotFailure(shippingGroupIndex, itemIndex).GetText(WebDriver, TimeSpan.FromSeconds(10)).Should().Be(authenticationFailureMessageDisplay);
			Logger.Write($"Autopilot section is displayed at Item-{itemIndex} in Shipping Group-{shippingGroupIndex} with authentication Failure message - {authenticationFailureMessageDisplay}");
		}

		public void VerifyLabelWindowsAutopilot(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			LabelWindowsAutopilot(shippingGroupIndex, itemIndex).IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2)).Should().BeTrue();
		}

		public void VerifyLabelTenantId(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			LabelTenantId(shippingGroupIndex, itemIndex).IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2)).Should().BeTrue();
		}

		public void VerifyLabelDomain(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			LabelDomain(shippingGroupIndex, itemIndex).IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2)).Should().BeTrue();
		}

		public void VerifyLabelAutpilotInfo(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			LabelAutpilotInfo(shippingGroupIndex, itemIndex).GetText(WebDriver, TimeSpan.FromSeconds(2)).Should().Be("Please provide a valid Tenant ID and Domain");
		}

		public void VerifyLabelTenantIdInvalidInput(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			LabelTenantIdInvalidInput(shippingGroupIndex, itemIndex).GetText(WebDriver, TimeSpan.FromSeconds(2)).Should().Be("Please enter a valid Tenant ID.");
		}
		public void VerifyLabelDomainInvalidInput(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			LabelDomainInvalidInput(shippingGroupIndex, itemIndex).GetText(WebDriver, TimeSpan.FromSeconds(2)).Should().Be("Please enter a valid Domain.");
		}

		public void VerifyIconWindowsAutopilot(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			IconWindowsAutopilot(shippingGroupIndex, itemIndex).IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2)).Should().BeTrue();
		}

		public void VerifyIconTenantId(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			IconTenantId(shippingGroupIndex, itemIndex).IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2)).Should().BeTrue();
		}
		public void VerifyIconDomain(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			IconDomain(shippingGroupIndex, itemIndex).IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2)).Should().BeTrue();
		}
		public void VerifyIconCloseWindowsAutopilot(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			IconCloseWindowsAutopilot(shippingGroupIndex, itemIndex).IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2)).Should().BeTrue();
		}
		public void VerifyIconCloseTenantId(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			IconCloseTenantId(shippingGroupIndex, itemIndex).IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2)).Should().BeTrue();
		}
		public void VerifyIconCloseDomain(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			IconCloseDomain(shippingGroupIndex, itemIndex).IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2)).Should().BeTrue();
		}


		public IWebElement ConnToOppLineRadiobutton(string OppLineitemName)
		{
			return WebDriver.GetElement(By.XPath(string.Format("//td[text()='{0}']/preceding-sibling::td/input", OppLineitemName)), TimeSpan.FromSeconds(10));
		}
		public void CloseAutopilotApplyAllPopup(Boolean Cancel = false)
		{
			if (BtnAutoPilotPopupCancel.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5)))
			{
				if (Cancel == false)
				{
					BtnAutoPilotPopupCancel.Click(WebDriver);
					Logger.Write("Autopilot Popup Closed");
				}

			}

		}
		public void BtnautopilotpopuApplyallpopup()
		{
			if (BtnautopilotpopuApplyall.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5)))
				BtnautopilotpopuApplyall.Click(WebDriver);
		}


		public void VerifyAutopilotNotifications()
		{
			string notificationWhenAllAutopilotDataFilled = "This quote has item(s) which qualify for Windows Autopilot. You may want to fill out the Tenant ID and Domain fields";
			string errorNotificationWhenPartialAutopilotDataFilled = "An Autopilot quote cannot be taken to order without Domain and Tenant IDs. Please enter them for the Autopilot items in this quote to Create Order.";
			bool notif = false;
			bool error = false;
			foreach (IWebElement notificationEle in LabelAutoPilotCreateQuoteNotifications)
			{
				if (notificationWhenAllAutopilotDataFilled.Equals(notificationEle.GetText(WebDriver, TimeSpan.FromSeconds(5)).Replace("Notification", "").Trim()))
					notif = true;
				else if (errorNotificationWhenPartialAutopilotDataFilled.Equals(notificationEle.GetText(WebDriver, TimeSpan.FromSeconds(1)).Replace("Notification", "").Trim()))
					error = true;

			}

			if (SaveAsOrderEnable.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(3)))
			{
				notif.Should().BeTrue();
				Logger.Write($"All TenantId and Domain are entered in Create Quote page, Save As Order is Enabled for Quote with Notification \n {notificationWhenAllAutopilotDataFilled}");
			}
			else
			{
				notif.Should().BeTrue();
				error.Should().BeTrue();
				Logger.Write($"Partial TenantId and Domain are entered in Create Quote page, Save As Order is Disabled for Quote with Notification {notificationWhenAllAutopilotDataFilled} \n {errorNotificationWhenPartialAutopilotDataFilled}");
			}

		}

		public void VerifyAutopilotData(bool verifyAutopilotSectionDisplayed, bool verifyTenantIdandDomainDataShown, string tenantId, string domain, int shippingGroupIndex = 1, int itemIndex = 1)
		{
			if (verifyAutopilotSectionDisplayed == true)
			{
				VerifyAutopilotSectionDisplayed(shippingGroupIndex, itemIndex).Should().BeTrue();
				Logger.Write($"Autopilot section is displayed at Item {itemIndex} in Shipping Group {shippingGroupIndex}");
				if (verifyTenantIdandDomainDataShown == true)
				{
					VerifyTenantIdandDomainDataShown(tenantId, domain, shippingGroupIndex, itemIndex).Should().BeTrue();
					Logger.Write($"Autopilot section with TenantId-{tenantId} and Domain-{domain} is displayed at Item-{itemIndex} in Shipping Group-{shippingGroupIndex}");
					if (!string.IsNullOrEmpty(tenantId) && !string.IsNullOrEmpty(domain))
						VerifySuccessMessageAfterPatchTenantIdandDomainData(shippingGroupIndex, itemIndex);
				}
				else
				{
					if (!string.IsNullOrEmpty(tenantId) && !string.IsNullOrEmpty(domain))
					{
						VerifyTenantIdandDomainDataShown(tenantId, domain, shippingGroupIndex, itemIndex).Should().BeFalse();
						Logger.Write($"Autopilot section shown with NO TenantId and Domain data at Item-{itemIndex} in Shipping Group-{shippingGroupIndex}");
					}
				}
			}
			else
			{
				VerifyAutopilotSectionDisplayed(shippingGroupIndex, itemIndex).Should().BeFalse();
				Logger.Write($"Autopilot section is NOT displayed at Item {itemIndex} in Shipping Group {shippingGroupIndex}");
			}


		}

		public void PatchandVerifyAutopilotData(bool authenticationSuccess, string tenantId, string domain, int shippingGroupIndex = 1, int itemIndex = 1)
		{
			PatchTenantIdandDomainData(tenantId, domain, shippingGroupIndex, itemIndex);
			if (authenticationSuccess)
				VerifyAutopilotData(true, true, tenantId, domain, shippingGroupIndex, itemIndex);
			else
				VerifyAutopilotData(true, false, tenantId, domain, shippingGroupIndex, itemIndex);

		}

		public void PatchandVerifyAutopilotData1(bool authenticationSuccess, string tenantId, string domain, int shippingGroupIndex = 1, int itemIndex = 1)
		{
			PatchTenantIdandDomainData(tenantId, domain, shippingGroupIndex, itemIndex);
			VerifyAutopilotSectionDisplayed(shippingGroupIndex, itemIndex).Should().BeTrue();
			Logger.Write($"Autopilot section is displayed at Item {itemIndex} in Shipping Group {shippingGroupIndex}");
			VerifyTenantIdandDomainDataShown(tenantId, domain, shippingGroupIndex, itemIndex);
			Logger.Write($"Autopilot section with TenantId-{tenantId} and Domain-{domain} is displayed at Item-{itemIndex} in Shipping Group-{shippingGroupIndex}");
			if (authenticationSuccess && !string.IsNullOrEmpty(tenantId) && !string.IsNullOrEmpty(domain))
				VerifySuccessMessageAfterPatchTenantIdandDomainData(shippingGroupIndex, itemIndex);
			else
				VerifyFailureMessageAfterPatchTenantIDandDomainData(shippingGroupIndex, itemIndex);

		}

		public bool IsCustomerPatched(string customerNumber)
		{
			if (CustomerNumberinHeader.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(6)))
				return true;
			//if (customerNumber.Equals(CustomerNumberinHeader.GetText(WebDriver, TimeSpan.FromSeconds(8))))
			return false;
		}

		public void VerifyValidationTenantIdDomainwithList(IWebDriver driver, IList<String> dataList, string idType, bool isValidList)
		{
			if (String.Equals(idType, "TenantId", StringComparison.OrdinalIgnoreCase))
			{
				if (!isValidList)
					foreach (string text in dataList)
					{
						InputAutopilotTenantandDomainData(TxtTenantId(), text);
						LabelTenantIdInvalidInput().Text.Should().Be("Please enter a valid Tenant ID.");
					}
				else
					foreach (string text in dataList)
					{
						InputAutopilotTenantandDomainData(TxtTenantId(), text);
						LabelTenantIdInvalidInput().IsElementDisplayed(driver, TimeSpan.FromSeconds(1)).Should().BeFalse();
					}
			}

			else
			{
				if (!isValidList)
					foreach (string text in dataList)
					{
						InputAutopilotTenantandDomainData(TxtDomain(), text);
						LabelDomainInvalidInput().Text.Should().Be("Please enter a valid Domain.");
					}
				else
					foreach (string text in dataList)
					{
						InputAutopilotTenantandDomainData(TxtDomain(), text);
						LabelDomainInvalidInput().IsElementDisplayed(driver, TimeSpan.FromSeconds(1)).Should().BeFalse();
					}
			}
		}

		public void InputAutopilotTenantandDomainData(IWebElement ele, string text)
		{

			ele.SendKeys(Keys.Control + "a");
			ele.SendKeys(Keys.Delete);
			ele.SendKeys(text);
			ele.SendKeys(Keys.Tab);
		}

		public void TenantidTab(IWebElement ele)
		{
			ele.SendKeys(Keys.Tab);
		}




		#endregion

		#region CustomPriceElements


		public IWebElement PricingModeSelection(string mode)
		{
			return WebDriver.FindElement(By.XPath("//span[normalize-space()='" + mode + "']/.."));
		}
		public IWebElement SelectMode(string mode)
		{
			return WebDriver.FindElement(By.XPath("//a[normalize-space()='" + mode + "']"));
		}


		public IWebElement CustomModePopUpHeader { get { return WebDriver.GetElement(By.XPath("//*[@id='_confirm']//span")); } }


		public IWebElement CustomModeContinue { get { return WebDriver.GetElement(By.Id("_btn_ok")); } }


		public IWebElement SwitchToStandardModeContinue { get { return WebDriver.GetElement(By.Id("_btn_ok")); } }


		public IWebElement CustomModeExitText { get { return WebDriver.GetElement(By.XPath("//*[@id='_confirm']/mat-dialog-content/span")); } }

		public List<IWebElement> LnkExpandItem(int itemIndex, int groupIndex)
		{
			return WebDriver.GetElements(By.Id("toggleMoreLess_" + (groupIndex - 1) + "_" + (itemIndex - 1)));
		}


		public IWebElement ExpandAposItem { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'quoteCreate_SEItem_show_more')]//a")); } }


		public IWebElement GroupDiscount { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_isAposglobalDiscountPercentage']")); } }

		public IWebElement ExpandAposSku(int itemIndex, int groupIndex, int skuIndex)
		{
			//return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_LI_arrow_" + "_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (skuIndex - 1) + "']"));
			return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_LI_configuration_details_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (skuIndex - 1) + "']/div/span"));
		}

		public List<IWebElement> BtnExpandAllConfiguration(int itemIndex, int groupIndex)
		{
			return WebDriver.GetElements(By.XPath("//*[@id='quoteCreate_LI_CS_header_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "']/..//a"));

		}

		public IWebElement ExpandNonTiedConfig(int itemIndex, int groupIndex, int nonTiedItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("/[@id='quoteCreate_LI_CS_header_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "'][" + nonTiedItemIndex + "]/..//a"));
		}

		public IWebElement TxtAllConfigOptions(int itemIndex, int groupIndex, int skuIndex)
		{
			//return WebDriver.GetElement(By.XPath("//*[contains(@id,'quoteCreate_LI_CS_configInfo_unitSellingPrice_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (skuIndex - 1) + "')]//input"));
			return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_LI_CS_configInfo_unitSellingPrice" + "_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (skuIndex - 1) + "']"));
		}

		//public IWebElement TxtAllConfigOptionsAPOS(int itemIndex, int groupIndex, int skuIndex)
		//{
		//	return WebDriver.GetElement(By.XPath("//div[@class='col-md-2 popup-adjustment']/input"));
		//}

		public IWebElement MaxValueOfSkuINCustomMode(int itemIndex, int groupIndex, int skuIndex)
		{
			TxtAllConfigOptions(itemIndex, groupIndex, skuIndex).Click(WebDriver);
			return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_LI_CS_configInfo_unitSellingPrice" + "_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (skuIndex - 1) + "']/..//div/section[2]/section[2]"));
		}

		public IWebElement MinValueOfSkuINCustomMode(int itemIndex, int groupIndex, int skuIndex)
		{
			TxtAllConfigOptions(itemIndex, groupIndex, skuIndex).Click(WebDriver);
			return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_LI_CS_configInfo_unitSellingPrice" + "_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (skuIndex - 1) + "']/..//div/section[1]/section[2]"));
		}

		//public IWebElement MaxValueOfSkuINCustomModeAPOS(int itemIndex, int groupIndex, int skuIndex)
		//{
		//	TxtAllConfigOptionsAPOS(itemIndex, groupIndex, skuIndex).Click(WebDriver);
		//	return WebDriver.GetElement(By.XPath("//div[@class='col-md-2 popup-adjustment']/div/div[2]/section[2]/section[2]"));
		//}

		public IWebElement TxtAposUnitPrice(int itemIndex, int groupIndex, int skuIndex)
		{
			return WebDriver.GetElement(By.XPath("//*[contains(@id,'quoteCreate_LI_configuration_rows_" +
												 (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (skuIndex - 1) +
												 "')]//input"));
		}

		public int NoOfConfigOptions(int itemIndex, int groupIndex)
		{
			return WebDriver.GetElements(By.XPath("//*[contains(@id,'quoteCreate_LI_CS_configInfo_unitSellingPrice_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "')]")).Count;
		}
		public IWebElement LblAllConfigOptions(int itemIndex, int groupIndex, int skuIndex)
		{
			//return WebDriver.GetElement(By.XPath("//*[contains(@id,'quoteCreate_LI_CS_configInfo_unitSellingPrice_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (skuIndex - 1) + "')]//span"));
			return WebDriver.GetElement(By.XPath("//*[@id='lineitem_config_block_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "']/div[" + (skuIndex - 1) + "]//table//span"));
		}

		public IWebElement LblListPriceOfSku(int itemIndex, int groupIndex, int skuIndex)
		{
			//return WebDriver.GetElement(By.XPath("//*[contains(@id,'quoteCreate_LI_CS_configInfo_unitSellingPrice_" + (itemIndex - 1) + "_" + (groupIndex - 1) + "_" + (skuIndex - 1) + "')]/tbody/tr[2]/td[2]"));
			return WebDriver.GetElement(By.XPath("//*[@id='lineitem_config_block_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "']/div[" + (skuIndex) + "]//table//tr[2]/td[3]"));
		}

		public IWebElement LblSellingPriceOfSku(int itemIndex, int groupIndex, int skuIndex)
		{
			// return WebDriver.GetElement(By.XPath("//*[contains(@id,'quoteCreate_LI_CS_configInfo_unitSellingPrice_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (skuIndex - 1) + "')]/tbody/tr[2]/span"));
			return WebDriver.GetElement(By.XPath("//*[@id='lineitem_config_block_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "']/div[" + (skuIndex) + "]//table/tbody[2]//span"));
		}

		public IWebElement PriceExceedNotification(int itemIndex, int groupIndex, int skuIndex)
		{
			return WebDriver.GetElement(By.XPath("//*[contains(@id,'quoteCreate_LI_CS_configInfo_unitSellingPrice_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (skuIndex - 1) + "')]/ancestor::tr/following-sibling::tr//p"));
		}
		public IWebElement ShipPriceExceedNotification()
		{
			return WebDriver.GetElement(By.XPath("//*[contains(@id,'custom_price_notification'"));
		}

		public IWebElement TxtSkuPriceChangeForNonTiedSku(int itemIndex, int groupIndex, int nonTiedItemIndex, int skuIndex)
		{
			return WebDriver.GetElement(By.XPath("//*[contains(@id,'quoteCreate_LI_CS_configInfo_unitSellingPrice_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedItemIndex - 1) + "_" + (skuIndex - 1) + "')]"));
		}
		public IWebElement LblListPriceOfNonTiedSku(int itemIndex, int groupIndex, int nonTiedItemIndex, int skuIndex)
		{
			return WebDriver.GetElement(By.XPath("//*[contains(@id,'quoteCreate_LI_CS_configInfo_unitSellingPrice_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedItemIndex - 1) + "_" + (skuIndex - 1) + "')]/../..//td[3]"));
		}

		public IWebElement TxtShippingCharge(int groupIndex)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_GI_" + (groupIndex - 1) + "_shippingCharge"));
		}


		public IWebElement TaxExemptFlag { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'quoteCreate_tax_override')]//input")); } }

		public IWebElement DdlPOLineNumber(int groupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.Id("_LI_poLineNumber_" + (groupIndex - 1) + "_" + (itemIndex - 1)));
		}

		public IWebElement POLineNumberReadOnly(int groupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.Id("_LI_poLineNumber_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_labelReadOnly"));
		}
		public IWebElement PoLineNotificationQuote(int notificationIndex = 1)
		{
			//return WebDriver.GetElement(By.Id("notificationMessages_" + (notificationIndex - 1) + "/span[2]"));
			return WebDriver.GetElement(By.Id("notificationMessages_" + (notificationIndex - 1)));
		}

		public IWebElement PoLineNotificationItem(int groupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_item_notifications_" + (groupIndex - 1) + "_" + (itemIndex - 1)));
		}

		#endregion

		#region CustomPriceActions
		public CreateQuotePage SelectPricingMode(string fromModeType, string toModeType)
		{
			PricingModeSelection(fromModeType).Click(WebDriver);
			SelectMode(toModeType).Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public bool CheckItemIsExpandOrCollaspeMode(string modeType, int groupIndex = 1, int skuIndex = 1)
		{
			if (modeType == "Manual")
			{
				if (WebDriver.GetElement(By.Id("quoteCreate_LI_" + (groupIndex - 1) + "_" + (skuIndex - 1))).GetAttribute("class") == "k-icon k-i-arrow-s")
				{
					return true;
				}
				return false;
			}
			else
			{
				if (WebDriver.GetElement(By.Id("quoteCreate_LI_" + (groupIndex - 1) + "_" + (skuIndex - 1))).GetAttribute("class") == "k-icon k-i-arrow-n")
				{
					return true;
				}
				return false;
			}
		}

		public bool IsCustomModeAvailable()
		{
			PricingModeSelection("Standard").Click(WebDriver);
			return SelectMode("Custom").IsElementVisible();
		}

		public bool IsCustomModePopUpAvailable()
		{
			return CustomModePopUpHeader.IsElementDisplayed(WebDriver);
		}
		public string GetCustomModeWarningData()
		{
			return CustomModePopUpHeader.GetText(WebDriver);
		}

		public string GetCustomModeExitWarningData()
		{
			return CustomModeExitText.GetText(WebDriver);
		}

		public CreateQuotePage SelectPricingModeContinue(string modeType = "CustomMode")
		{
			if (modeType == "CustomMode")
				CustomModeContinue.Click(WebDriver);
			else if (modeType == "StandardMode")
				SwitchToStandardModeContinue.Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage ExpandOrCollapseItemConfiguration(int itemIndex = 1, int groupIndex = 1)
		{
			var elements = BtnExpandAllConfiguration(itemIndex, groupIndex);
			foreach (IWebElement element in elements)
			{
				if (!(element.GetAttribute("class").Contains("ng-hide")))
				{
					element.Click(WebDriver);
					break;
				}
			}
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage ExpandOrCollapseNonTiedItemConfiguration(int itemIndex = 1, int groupIndex = 1, int nonTiedItemIndex = 1, bool itemExpanded = true)
		{
			var btn = BtnExpandAllConfiguration(itemIndex, groupIndex);
			if (itemExpanded)
			{
				btn[nonTiedItemIndex].Click(WebDriver);
			}

			else
			{
				btn[nonTiedItemIndex - 1].Click(WebDriver);
			}

			return new CreateQuotePage(WebDriver);
		}

		public string GetTotalShippingChargeForGroup(int groupIndex = 0)
		{
			return TxtGroupLevelShippingPriceInCustomMode(groupIndex).GetText(WebDriver);
		}

		public CreateQuotePage SetShippingChargeInCustomMode(double value, int groupIndex = 0)
		{
			TxtGroupLevelShippingPriceInCustomMode(groupIndex).SetText(WebDriver, value.ToString());
			return new CreateQuotePage(WebDriver);
		}


		public bool IsSkuSellingPriceEditable(int itemIndex = 1, int groupIndex = 1, int skuIndex = 1)
		{
			return TxtAllConfigOptions(itemIndex, groupIndex, skuIndex).IsElementClickable(WebDriver);
		}

		public bool IsMaxAndMinPriceAvailableForSku(int itemIndex = 1, int groupIndex = 1, int skuIndex = 1)
		{
			var maxValueElement = MaxValueOfSkuINCustomMode(itemIndex, groupIndex, skuIndex);
			var maxValue = Convert.ToDouble(maxValueElement.GetText(WebDriver));

			var minValueElement = MinValueOfSkuINCustomMode(itemIndex, groupIndex, skuIndex);
			var minValue = Convert.ToDouble(minValueElement.GetText(WebDriver));

			if (!minValue.ToString().Contains("-") && !maxValue.ToString().Contains("-"))
			{
				return true;
			}
			return false;
		}

		public bool IsSkuPriceUpdated(int itemIndex = 1, int groupIndex = 1, int skuIndex = 1)
		{
			var editableSku = TxtAllConfigOptions(itemIndex, groupIndex, skuIndex).GetText(WebDriver);
			var listPrice = LblListPriceOfSku(itemIndex, groupIndex, skuIndex).GetText(WebDriver).Substring(1);
			if (editableSku != listPrice)
			{
				return true;
			}
			return false;
		}

		public string GetSkuPriceInCustomMode(int itemIndex = 1, int groupIndex = 1, int skuIndex = 1)
		{
			return TxtAllConfigOptions(itemIndex, groupIndex, skuIndex).GetText(WebDriver);
		}
		public string GetSkuPriceInStandardMode(int itemIndex = 1, int groupIndex = 1, int skuIndex = 1)
		{
			return LblAllConfigOptions(itemIndex, groupIndex, skuIndex).GetText(WebDriver);
		}
		public bool IsNonTiedSkuPriceUpdated(int itemIndex = 1, int groupIndex = 1, int nonTiedItemIndex = 1, int skuIndex = 1)
		{
			var editableSku = TxtSkuPriceChangeForNonTiedSku(itemIndex, groupIndex, nonTiedItemIndex, skuIndex).GetText(WebDriver);
			var listPrice = LblListPriceOfNonTiedSku(itemIndex, groupIndex, nonTiedItemIndex, skuIndex).GetText(WebDriver).Substring(1);

			if (editableSku != listPrice)
			{
				return true;
			}
			return false;
		}

		public CreateQuotePage IncreaseSkuPriceMoreThanMaxPrice(int itemIndex = 1, int groupIndex = 1, int skuIndex = 1)
		{
			var editableSku = TxtAllConfigOptions(itemIndex, groupIndex, skuIndex);

			var skuValue = Convert.ToDouble(editableSku.GetText(WebDriver));
			var maxValueElement = MaxValueOfSkuINCustomMode(itemIndex, groupIndex, skuIndex);
			var maxValue = Convert.ToDouble(maxValueElement.GetText(WebDriver));

			if (skuValue <= maxValue)
			{
				skuValue = maxValue + 2.00;
			}
			editableSku.SetText(WebDriver, skuValue.ToString());
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage ChangeSkuPricWithinRange(int itemIndex = 1, int groupIndex = 1, int skuIndex = 1)
		{
			var editableSku = TxtAllConfigOptions(itemIndex, groupIndex, skuIndex);

			var skuValue = Convert.ToDouble(Convert.ToDecimal(editableSku.GetText(WebDriver)));

			var maxValueElement = MaxValueOfSkuINCustomMode(itemIndex, groupIndex, skuIndex);
			var maxValue = Convert.ToDouble(Convert.ToDecimal(maxValueElement.GetText(WebDriver)));

			if (skuValue <= maxValue)
			{
				skuValue = Convert.ToDouble(Generator.RandomDecimal(skuValue, maxValue));
			}
			skuValue = Math.Round(skuValue, 2);
			editableSku.SetText(WebDriver, skuValue.ToString());
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return new CreateQuotePage(WebDriver);
		}

		//public CreateQuotePage ChangeSkuPricWithinRangeAPOS(int itemIndex = 1, int groupIndex = 1, int skuIndex = 1)
		//{
		//	var editableSku = TxtAllConfigOptionsAPOS(itemIndex, groupIndex, skuIndex);

		//	var skuValue = Convert.ToDouble(Convert.ToDecimal(editableSku.GetText(WebDriver)));

		//	var maxValueElement = MaxValueOfSkuINCustomModeAPOS(itemIndex, groupIndex, skuIndex);
		//	var maxValue = Convert.ToDouble(Convert.ToDecimal(maxValueElement.GetText(WebDriver)));

		//	if (skuValue <= maxValue)
		//	{
		//		skuValue = Convert.ToDouble(Generator.RandomDecimal(skuValue, maxValue));
		//	}
		//	skuValue = Math.Round(skuValue, 2);
		//	editableSku.SetText(WebDriver, skuValue.ToString());
		//	WebDriver.VerifyBusyOverlayNotDisplayed();
		//	return new CreateQuotePage(WebDriver);
		//}

		public CreateQuotePage ChangePriceLessThanSkuValue(int itemIndex = 1, int groupIndex = 1, int skuIndex = 1)
		{
			var editableSku = TxtAllConfigOptions(itemIndex, groupIndex, skuIndex);
			var skuValue = Convert.ToDouble(editableSku.GetText(WebDriver));
			skuValue = Convert.ToDouble(Generator.RandomDecimal(skuValue - 5, skuValue));
			skuValue = Math.Round(skuValue, 2);
			editableSku.SetText(WebDriver, skuValue.ToString());
			return new CreateQuotePage(WebDriver);
		}
		public CreateQuotePage IncreaseSkuPriceMoreThanListPrice(int itemIndex = 1, int groupIndex = 1, int skuIndex = 1)
		{
			var editableSku = TxtAllConfigOptions(itemIndex, groupIndex, skuIndex);
			var skuValue = Convert.ToDouble(editableSku.GetText(WebDriver));
			var listPrice = Convert.ToDouble(LblListPriceOfSku(groupIndex, itemIndex, skuIndex).GetText(WebDriver).Substring(1));
			if (skuValue <= listPrice)
			{
				skuValue = listPrice + 2.00;
			}
			editableSku.SetText(WebDriver, skuValue.ToString());

			return new CreateQuotePage(WebDriver);
		}
		public CreateQuotePage IncreaseSkuPriceWithInMaxAndListPrice(int itemIndex = 1, int groupIndex = 1, int skuIndex = 1)
		{
			var editableSku = TxtAllConfigOptions(itemIndex, groupIndex, skuIndex);
			var skuValue = Convert.ToDouble(Convert.ToDecimal(editableSku.GetText(WebDriver)));
			var maxValueElement = MaxValueOfSkuINCustomMode(itemIndex, groupIndex, skuIndex);
			var maxValue = Convert.ToDouble(Convert.ToDecimal(maxValueElement.GetText(WebDriver)));

			var listPrice = Convert.ToDouble(LblListPriceOfSku(itemIndex, groupIndex, skuIndex).GetText(WebDriver).Substring(1));

			if (maxValue != listPrice)
			{
				skuValue = Convert.ToDouble(Generator.RandomDecimal(maxValue, listPrice));
			}
			else
			{
				skuValue = Convert.ToDouble(Generator.RandomDecimal(skuValue, listPrice));
			}
			skuValue = Math.Round(skuValue, 2);
			editableSku.SetText(WebDriver, skuValue.ToString());
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage ChangeSkuPriceOfNonTied(int itemIndex = 1, int groupIndex = 1, int nonTiedItemIndex = 1, int skuIndex = 1)
		{
			var editableSku = TxtSkuPriceChangeForNonTiedSku(itemIndex, groupIndex, nonTiedItemIndex, skuIndex);
			var skuValue = Convert.ToDouble(Convert.ToDecimal(editableSku.GetText(WebDriver)));
			skuValue = Convert.ToDouble(Generator.RandomDecimal(skuValue - 10, skuValue));
			skuValue = Math.Round(skuValue, 2);
			editableSku.SetText(WebDriver, skuValue.ToString());

			return new CreateQuotePage(WebDriver);
		}

		public string GetPriceExceedNotificationForSku(int itemIndex = 1, int groupIndex = 1, int skuIndex = 1)
		{
			return PriceExceedNotification(itemIndex, groupIndex, skuIndex).GetText(WebDriver);
		}
		public string GetShipPriceExceedNotification()
		{
			return ShipPriceExceedNotification().GetText(WebDriver);
		}

		public bool IsSkuTextBoxHighlightedInRed(int itemIndex = 1, int groupIndex = 1, int skuIndex = 1)
		{
			var editableSku = TxtAllConfigOptions(groupIndex, itemIndex, skuIndex);
			if (editableSku.GetAttribute("class").Contains("hlt-chd-sku"))
			{
				return true;
			}
			return false;
		}

		public double GetDiscountPertForSKuInItem(int itemIndex = 1, int groupIndex = 1, int skuIndex = 1)
		{
			var skulistPrice = Convert.ToDouble(LblListPriceOfSku(itemIndex, groupIndex, skuIndex).GetText(WebDriver).Substring(1));
			var skuSellingPrice = Convert.ToDouble(LblSellingPriceOfSku(itemIndex, groupIndex, skuIndex).GetText(WebDriver).Substring(1));

			return Convert.ToDouble(((skulistPrice - skuSellingPrice) / skulistPrice) * 100);
		}

		#endregion

		#region ManualPriceElements
		public IWebElement DolInManualPriceMode(int itemIndex, int groupIndex)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_accordion_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "']//*[contains(@data-ng-model,'.quickPrices.dolPercentage')]"));

		}
		public IWebElement UnitSellingPriceInManualPriceMode(int itemIndex, int groupIndex)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_accordion_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "']//*[contains(@data-ng-model,'.quickPrices.unitSellingPrice')]"));

		}

		public IWebElement QuantityInManualPriceMode(int itemIndex, int groupIndex)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_accordion_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "']//*[contains(@data-ng-model,'.quickPrices.quantity')]"));

		}

		public IWebElement SkuDolInManualPriceMode(int itemIndex, int groupIndex)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_accordion_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "']//*[contains(@data-ng-model,'sku.quickPrices.dolPercentage')]"));

		}
		public IWebElement SkuUnitSellingPriceInManualPriceMode(int itemIndex, int groupIndex)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_accordion_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "']//*[contains(@data-ng-model,'sku.quickPrices.unitSellingPrice')]"));

		}

		public IWebElement SkuQuantityInManualPriceMode(int itemIndex, int groupIndex)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_accordion_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "']//*[contains(@data-ng-model,'sku.quickPrices.quantity')]"));

		}


		public CreateQuotePage getAllValue(int itemIndex, int groupIndex)
		{
			string quantity = QuantityInManualPriceMode(itemIndex, groupIndex).GetText(WebDriver);
			string dol = DolInManualPriceMode(itemIndex, groupIndex).GetText(WebDriver);
			string unitSellingPrice = UnitSellingPriceInManualPriceMode(itemIndex, groupIndex).GetText(WebDriver);

			string unitSellingPriceForSku = SkuUnitSellingPriceInManualPriceMode(itemIndex, groupIndex).GetText(WebDriver);
			string quantityForSku = SkuQuantityInManualPriceMode(itemIndex, groupIndex).GetText(WebDriver);
			string dolForSku = SkuDolInManualPriceMode(itemIndex, groupIndex).GetText(WebDriver);

			return new CreateQuotePage(WebDriver);
		}

		#endregion

		#region Select Destination Group


		public IWebElement btnSelectDestinationGroupCancel { get { return WebDriver.GetElement(By.Id("selectDestinationGroupCancelButton")); } }


		public IWebElement btnSelectDestinationGroupMoveItem { get { return WebDriver.GetElement(By.Id("selectDestinationGroupMoveButton")); } }
		private int lineitemIndex;

		public IWebElement CopyShippingGroup(int shippingGroupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(string.Format("quoteCreate_shipment-{0}_copyGroup", shippingGroupIndex - 1)), TimeSpan.FromSeconds(2));
		}

		public IWebElement CopyItemfromShippingGroup(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(string.Format("quoteCreate_LI_copyItem_{0}_{1}", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(2));
		}

		public IWebElement MoveItemfromShippingGroup(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(string.Format("quoteCreate_LI_moveToLink_{0}_{1}", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(2));
		}

		public IWebElement AvailableDestinationGroup(int destinationShippingGroupNumber)
		{
			return WebDriver.GetElement(By.Id("availableShippingGroupRadio" + destinationShippingGroupNumber));
		}


		#endregion


		public bool ChangeBillToCustomer(IWebDriver WebDriver, String newCustomer = null)
		{
			bool newBillToCustomer = false;
			LnkChangeCustomer.Click(WebDriver);
			BtnChangeCustomerConfirm.Click(WebDriver);
			if (!string.IsNullOrEmpty(newCustomer))
			{
				TxtCustomerNumber.SetText(WebDriver, newCustomer);
				newBillToCustomer = TxtCurrentCustomerCustomerNumber.GetText(WebDriver).Equals(newCustomer);
				Logger.Write($"Current Bill to Customer Number is changed to New Bill to Customer Number {newCustomer}");
			}
			return false;
		}

		public bool ChangeSoldToCustomer(IWebDriver WebDriver, string newCustomer = null)
		{
			bool newSoldToCustomer = false;
			LnkChangeQuoteLevelSoldToCustomer.Click(WebDriver);
			if (!string.IsNullOrEmpty(newCustomer))
			{
				var customerDetailsPage = new CustomerSearchPage(WebDriver).SearchCustomerByCustomerNumber(newCustomer);
				customerDetailsPage.WaitForCustomerDetailsPageToLoad();
				customerDetailsPage.customerAsSoldToBtn.Click(WebDriver);
				newSoldToCustomer = QuoteSoldToInfo.GetText(WebDriver).Equals(newCustomer);
				Logger.Write($"Current Sold to Customer Number is changed to New Sold to Customer Number {newCustomer}");
			}
			return false;
		}

		public bool ChangeShipToCustomer(IWebDriver WebDriver, string index, string newCustomer = null)
		{
			bool newShipToCustomer = false;
			ShippingGrpChangeCustomer(index).Click(WebDriver);
			if (!string.IsNullOrEmpty(newCustomer))
			{
				var customerDetailsPage = new CustomerSearchPage(WebDriver).SearchCustomerByCustomerNumber(newCustomer);
				customerDetailsPage.WaitForCustomerDetailsPageToLoad();
				customerDetailsPage.GroupLvlChangeShipToCustomer.Click(WebDriver);
				var shippingCustomer = new CreateQuotePage(WebDriver).ShippingGrp1CustNum.GetText(WebDriver, null).Split(':')[1];
				newShipToCustomer = shippingCustomer.Equals(newCustomer);
				Logger.Write($"Current Ship to Customer Number is changed to New Ship to Customer Number {newCustomer}");
			}
			return false;
		}

		public CreateQuotePage ChangeOrPatchInstallAtCustomer(IWebDriver WebDriver, string newInstallAtCustomer)
		{
			ChangeInstallAtCustomer.Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();

			new CustomerSearchPage(WebDriver).SearchCustomerByCustomerNumber(newInstallAtCustomer);
			new CustomerDetailsPage(WebDriver).WaitForCustomerDetailsPageToLoad();
			new CustomerDetailsPage(WebDriver).BtnUseInQuoteAsInstallAtCustomer.Click(WebDriver);

			WebDriver.WaitForElementDisplay(ChangeInstallAtCustomer, TimeSpan.FromSeconds(20));
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage PatchEndUserCustomer(IWebDriver WebDriver, string newEndUserCustomer)
		{
			if (!string.IsNullOrEmpty(newEndUserCustomer))
			{
				try
				{
					WebDriver.ScrollToElement(TxtEndUserCustomerNumber);
					TxtEndUserCustomerNumber.Clear();
					TxtEndUserCustomerNumber.SetText(WebDriver, newEndUserCustomer);
					TxtEndUserCustomerNumber.SendKeys(Keys.Tab);
					WebDriver.VerifyBusyOverlayNotDisplayed();
					TxtEndUserCustomerNumber.GetText(WebDriver, TimeSpan.FromSeconds(20)).Should().Be(newEndUserCustomer);
				}
				catch (StaleElementReferenceException)
				{
					WebDriver.VerifyBusyOverlayNotDisplayed();
				}
			}
			return new CreateQuotePage(WebDriver);
		}


		public bool IsWarningMessageDiffAddressVisible()
		{
			return warningMessageDiffAddress.IsElementVisible();
		}

		public bool IsDupeShippingAddrNotificationMsgDisplayed()
		{
			return DupeShippingAddrNotificationMsg.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(20));
		}

		public CreateQuotePage ExpandItem(int itemIndex = 1, int groupIndex = 1, bool isNonTiedExpandItem = false, int nonTiedItemIndex = 1)
		{
			var links = LnkExpandItem(itemIndex, groupIndex);
			if (isNonTiedExpandItem)
			{
				links[nonTiedItemIndex].Click(WebDriver);
			}
			else
			{
				links[0].Click(WebDriver);
			}
			return new CreateQuotePage(WebDriver);
		}


		public CreateQuotePage EditPONumber(string poNumber)
		{
			TxtPoNumber.Clear();
			TxtPoNumber.SetText(WebDriver, poNumber);
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage ExpandSolutionModule(int itemIndex = 1, int groupIndex = 1, int moduleIndex = 1)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			By.Id(String.Format("quoteCreate_LI_{0}_{1}", groupIndex - 1, itemIndex - 1)).Click(WebDriver);
			ExpandItem(itemIndex, groupIndex);
			By.Id(String.Format("quoteCreate_LI_CS_Item_{0}_{1}_{2}", groupIndex - 1, itemIndex - 1, moduleIndex - 1)).Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}


		public CreateQuotePage ExpandItemModule(int itemIndex = 1, int groupIndex = 1, int moduleIndex = 1)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			ExpandItem(itemIndex, groupIndex);
			//IWebElement module = WebDriver.GetElement(By.Id(String.Format("quoteCreate_LI_CS_Item_{0}_{1}_{2}", groupIndex-1, itemIndex-1, moduleIndex-1)));           
			By.Id(String.Format("quoteCreate_LI_CS_Item_{0}_{1}_{2}", groupIndex - 1, itemIndex - 1, moduleIndex - 1)).Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public bool IsModuleICoded(int itemIndex, int groupIndex, int moduleIndex)
		{
			bool isICoded = false;
			ExpandItemModule(itemIndex, groupIndex, moduleIndex);
			//var text = WebDriver.FindElement(By.XPath(String.Format("//*[@id='quoteCreate_LI_CS_configInfo_build_categoryTable_{0}_{1}_{2}']/tbody/tr[11]/td[2]/span", groupIndex - 1, itemIndex - 1, moduleIndex - 1))).Text;
			var text = WebDriver.FindElement(By.XPath("//table[@class='config-option-sku-table']/tbody[2]/tr[2]/td[2]/span")).Text;
			if (text == "I Coded")
			{
				isICoded = true;
			}
			return isICoded;
		}

		public string GetSelectedOptionDescInModule(int itemIndex, int groupIndex, int moduleIndex, bool isSolutionQuote = false)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			if (!isSolutionQuote)
				ExpandItemModule(itemIndex, groupIndex, moduleIndex);
			else
				ExpandSolutionModule(itemIndex, groupIndex, moduleIndex);
			var optionDesc = WebDriver.GetElement(By.Id(String.Format("quoteCreate_LI_CS_category_build_category_{0}_{1}_{2}", groupIndex - 1, itemIndex - 1, moduleIndex - 1))).Text;
			return optionDesc.ToString();
		}

		public string GetDurationMonthsOfVISKU(int itemIndex, int groupIndex, int moduleIndex)
		{
			//ExpandItemModule(itemIndex, groupIndex, moduleIndex);
			var durationMonths = WebDriver.FindElement(By.XPath(String.Format("//*[@id='quoteCreate_LI_CS_configInfo_build_categoryTable_{0}_{1}_{2}']/tbody/tr[2]/td[7]", groupIndex - 1, itemIndex - 1, moduleIndex - 1))).Text;
			return durationMonths.ToString();
		}

		public string GetSKUDescofVIQuotePage(int itemIndex, int groupIndex, int moduleIndex, bool isSolutionQuote = false)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			if (!isSolutionQuote)
				ExpandItemModule(itemIndex, groupIndex, moduleIndex);
			else
				ExpandSolutionModule(itemIndex, groupIndex, moduleIndex);

			var skuDescVI = WebDriver.GetElement(By.Id(String.Format("quoteCreate_LI_CS_category_build_category_{0}_{1}_{2}", groupIndex - 1, itemIndex - 1, moduleIndex - 1))).Text;
			//var durationMonths = WebDriver.FindElement(By.XPath(String.Format("//*[@id='quoteCreate_LI_CS_category_build_category_{0}_{1}_{2}']/tbody/tr[2]/td[7]", groupIndex - 1, itemIndex - 1, moduleIndex - 1))).Text;
			//Verify that skudesc contains duration months appended
			//bool skuDesc = skuDescVI.Contains(durationMonths + " Month(s)");

			return skuDescVI;
		}

		public string GetProductDescQuotePage(int itemIndex, int groupIndex, int skuIndex)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			string productDesc = WebDriver
				.GetElement(By.XPath(String.Format("//*[contains(@id, 'Sku_productDescription_{0}_{1}_{2}')]", groupIndex - 1, itemIndex - 1, skuIndex - 1))).Text;
			//string productDesc = WebDriver.GetElement(By.Id(String.Format("quoteCreate_Sku_productDescription_{0}_{1}_{2}", groupIndex - 1, itemIndex - 1, skuIndex - 1))).Text;
			return productDesc;
		}

		public IWebElement SelectGroupInCustomQuote(int index)
		{
			var element = string.Format("//*[@id='quoteSplit_groupCheck_{0}']/input", index);
			return WebDriver.GetElement(By.XPath(element));
		}
		public IWebElement RemoveCustomQuoteProducts(int productIndex = 0, int groupIndex = 0)
		{
			//return WebDriver.GetElements((By.XPath("//*[@id='quoteSplitByCustomGroup_item']/div[3]/a")))[productIndex];
			//return WebDriver.GetElements(By.Id("quoteCreate_LI_removeItem_" + groupIndex + "_" + productIndex ));
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_removeItem_" + groupIndex + "_" + productIndex));
			//return WebDriver.GetElement((By.XPath(".//a[@data-ng-click ='removeItem(item.id,shippmentGroup.shipmentId);$event.stopPropagation();' ]")));
		}

		public IWebElement ItemSellingPriceInQuickPriceMode(int groupIndex = 1, int itemIndex = 1, bool isNontied = false, int nonTiedIndex = 1)
		{
			if (!isNontied)
				return
					WebDriver.GetElement(
					By.XPath(@"(//*[@id='quoteCreate_accordion_" + (groupIndex - 1) + "_" + (itemIndex - 1) +
							  "']//div//input)[2]"));

			nonTiedIndex = itemIndex + nonTiedIndex;
			return
				WebDriver.GetElement(
					By.XPath(@"(//*[@id='quoteCreate_accordion_" + (groupIndex - 1) + "_" + (itemIndex - 1) +
							 "']//div//input)[" + (nonTiedIndex * 3 - 1) + "]"));
		}

		public IWebElement ItemDolInQuickPriceMode(int groupIndex = 1, int itemIndex = 1, bool isNontied = false, int nonTiedIndex = 1)
		{
			if (!isNontied)
				return
					WebDriver.GetElement(
					By.XPath(@"(//*[@id='quoteCreate_accordion_" + (groupIndex - 1) + "_" + (itemIndex - 1) +
							  "']//div//input)[3]"));

			nonTiedIndex = itemIndex + nonTiedIndex;
			return
				WebDriver.GetElement(
					By.XPath(@"(//*[@id='quoteCreate_accordion_" + (groupIndex - 1) + "_" + (itemIndex - 1) +
							 "']//div//input)[" + (nonTiedIndex * 3) + "]"));
		}

		public SplitLineItemPage LineItemSplit(int itemIndex = 1)
		{
			LnkItemLevelSplit(itemIndex).Click(WebDriver);
			return new SplitLineItemPage(WebDriver);
		}

		public QuoteDetailsPage NoContinueWorking()
		{
			BtnNoContinueWorking.Click(WebDriver);
			return new QuoteDetailsPage(WebDriver);
		}

		public QuoteDetailsPage SubmitDamRequest(string approverMailId, string justification = "", bool highPriority = false)
		{
			WebDriver.WaitFor(x => BtnYesSubmitDamRequest.IsElementVisible());
			BtnYesSubmitDamRequest.Click(WebDriver);
			DdlDamApprover.PickDropdownByText(WebDriver, approverMailId);
			if (highPriority)
				ChkDamApprovalPriority.SelectCheckBox(WebDriver);
			TxtDamApprovalJustification.SetText(WebDriver, justification);
			BtnSubmitDamApproval.Click(WebDriver);
			return new QuoteDetailsPage(WebDriver);
		}

		public int GetItemCountFromMastHead()
		{
			string text = LblItemCountMastHead.GetText(WebDriver);
			return int.Parse(Regex.Match(text, @"\d+").Value);
		}

		public CreateQuotePage UpdateCadenceOnQuote(string cadence)
		{
			DdlFlexBillingCadence.PickDropdownByText(WebDriver, cadence);
			return new CreateQuotePage(WebDriver);
		}

		public bool ValidateCadenceIsVisible()
		{
			return DdlFlexBillingCadence.IsElementDisplayed(WebDriver);
		}

		public CreateQuotePage UpdateCadenceOnItem(string cadence, int itemIndex = 1)
		{
			DdlItemLevelCadence(itemIndex).PickDropdownByText(WebDriver, cadence);
			return new CreateQuotePage(WebDriver);
		}

		public string GetCadenceSelectedOnItem(int itemIndex = 1)
		{
			return DdlItemLevelCadence(itemIndex).Select().SelectedOption.Text;
		}

		public double GetUnitSellingPriceForItem(int groupIndex = 1, int itemIndex = 1)
		{
			return Convert.ToDouble(ByTxtItemLevelUnitSellingPrice(itemIndex, groupIndex).GetText(WebDriver));
		}

		public double GetShippingAmountPerGroup(int groupIndex = 1)
		{
			return Convert.ToDouble(LblGroupLevelTotalShipping(groupIndex - 1).GetText(WebDriver).Substring(1));
		}

		public bool IsReadyStockATSValidationMsgVisible()
		{
			return RSATSValidationMessage.IsElementVisible();
		}

		/// <summary>
		/// Saves the current quote as RSID Quote.
		/// </summary>
		/// <returns></returns>
		public QuoteDetailsPage SaveAsRsidQuote()
		{
			ReadyStockIQcheckbox.SelectCheckBox(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			ExcludeAllPromtion();
			WaitForQuoteValidationToComplete();
			return SaveQuote();
		}

		/// <summary>
		/// Checks the RSID checkbox on the current quote.
		/// </summary>
		public void MarkAsRSIDQuote()
		{
			ReadyStockIQcheckbox.SelectCheckBox(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
		}

		public QuoteDetailsPage OverrideRSATSValidation()
		{
			RSATSOverrideBtn.Click(WebDriver);
			BtnSaveQuote.Click(WebDriver);
			return new QuoteDetailsPage(WebDriver);
		}

		public void UnMarkAsRSIDQuote()
		{
			ReadyStockIQcheckbox.UnSelectCheckBox(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
		}

		public bool HasReadyStockNotifications()
		{
			if (ApoFpoMessage.Displayed)
			{
				var notification = ApoFpoMessage.GetText(WebDriver);
				return notification.Contains("Ready Stock Quote - ");
			}
			return false;
		}
		public ItemQuoteData GetLineItemUnitValues(int groupIndex = 1, int itemIndex = 1, bool contractCodeRequired = false)
		{
			Logger.Write("Getting Values for Item " + itemIndex + " in Shipping Group " + groupIndex);
			Logger.Write("-------------------------");

			var itemQuoteData = new ItemQuoteData
			{
				DiscountOffList = Convert.ToDouble(ByTxtItemLevelDiscountOffList(itemIndex, groupIndex).GetText(WebDriver)),
				ListPrice = ByLblItemLevelUnitListPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1),
				Discount = Convert.ToDouble(ByLblItemLevelUnitDiscount(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				SellingPrice = ByTxtItemLevelUnitSellingPrice(itemIndex, groupIndex).GetText(WebDriver),
				MarginValue = Convert.ToDouble(ByLblItemLevelUnitMargin(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				Quantity = int.Parse(ByTxtItemLevelQuantity(itemIndex, groupIndex).GetText(WebDriver)),
				ContractCode = contractCodeRequired ? ByTxtContractCode(itemIndex).GetText(WebDriver) : ""
			};

			return itemQuoteData;
		}

		public ItemQuoteData GetLineItemUnitValuesWithQuantity(int groupIndex = 1, int itemIndex = 1, bool contractCodeRequired = false)
		{
			Logger.Write("Getting Values for Item " + itemIndex + " in Shipping Group " + groupIndex + " With Quantity");
			Logger.Write("-------------------------");

			var discount = ByLblItemLevelDiscount(itemIndex, groupIndex).GetText(WebDriver);
			var margin = ByLblItemLevelMargin(itemIndex, groupIndex).GetText(WebDriver);
			var promotion = ByLblItemLevelPromotions(itemIndex, groupIndex).GetText(WebDriver);

			var itemQuoteDataWithQuantity = new ItemQuoteData
			{
				ListPrice = ByLblItemLevelListPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1),
				Discount = Convert.ToDouble(discount.Split('/')[1].Substring(2)),
				DiscountOffList = Convert.ToDouble(discount.Split('/')[0].Substring(0).Split('%')[0]),
				SellingPrice = ByLblItemLevelSellingPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1),
				Margin = margin,
				MarginValue = Convert.ToDouble(margin.Split('/')[1].Substring(2)),
				MarginPert = Convert.ToDouble(margin.Split('/')[0].Substring(0).Split('%')[0]),
				PromoValue = Convert.ToDouble(promotion.Split('/')[1].Substring(2)),
				PromoPert = Convert.ToDouble(promotion.Split('/')[0].Substring(0).Split('%')[0]),
				ContractCode = contractCodeRequired ? ByTxtContractCode(groupIndex, itemIndex).GetText(WebDriver) : "",
				ContractDiscount = contractCodeRequired ? ByLblItemLevelContractDiscount(itemIndex, groupIndex).GetText(WebDriver).Split('%')[0] : ""
			};

			return itemQuoteDataWithQuantity;
		}

		public ItemSummaryValues GetItemLevelSummary(int groupIndex = 1, int itemIndex = 1)
		{
			Logger.Write("Getting Values for Item Level Summary for Item " + itemIndex + "in Shipping Group " + groupIndex);
			Logger.Write("-------------------------");

			var itemSummary = new ItemSummaryValues
			{
				TotalSellingPrice = Convert.ToDouble(LblItemLevelSummarySellingPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				TotalTax = Convert.ToDouble(LblItemLevelSummaryTotalTax(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				TotalEcoFee = Convert.ToDouble(LblItemLevelTotalEcoFee(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				TotalAmount = Convert.ToDouble(LblItemLevelTotalAmount(itemIndex, groupIndex).GetText(WebDriver).Substring(5))
			};

			return itemSummary;
		}


		public ShippingGroupSummary GetShippingGroupSummary(int groupIndex = 1)
		{
			Logger.Write("Getting Values for Shipping Group Summary for group " + groupIndex);
			Logger.Write("-------------------------");

			var shipGroupSummary = new ShippingGroupSummary()
			{
				SubTotal = Convert.ToDouble(LblGroupLevelSubTotal(groupIndex).GetText(WebDriver).Substring(1)),
				TotalShipping = Convert.ToDouble(LblGroupLevelTotalShipping(groupIndex - 1).GetText(WebDriver).Substring(1)),
				TotalTax = Convert.ToDouble(LblGroupLevelTotalTax(groupIndex).GetText(WebDriver).Substring(1)),
				TotalEcoFee = Convert.ToDouble(LblGroupLevelTotalEcoFee(groupIndex).GetText(WebDriver).Substring(1)),
				TotalAmount = Convert.ToDouble(LblGroupLevelTotalAmount(groupIndex).GetText(WebDriver).Substring(5))
			};

			return shipGroupSummary;
		}


		public ItemQuoteData GetNonTiedItemUnitValues(int groupIndex = 1, int itemIndex = 1, int nonTiedIndex = 1, bool contractCodeRequired = false)
		{
			Logger.Write("Getting Values for Non-Tied Item " + nonTiedIndex + " under Item " + itemIndex + " in Shipping Group " + groupIndex);
			Logger.Write("-------------------------");

			var itemQuoteData = new ItemQuoteData
			{
				DiscountOffList = Convert.ToDouble(TxtItemLevelNonTiedDiscountOffList(groupIndex, itemIndex, nonTiedIndex).GetText(WebDriver)),
				ListPrice = LblItemLevelNonTiedUnitListPrice(groupIndex, itemIndex, nonTiedIndex).GetText(WebDriver).Substring(1),
				Discount = Convert.ToDouble(LblItemLevelNonTiedUnitDiscount(nonTiedIndex).GetText(WebDriver).Substring(1)),
				SellingPrice = TxtItemLevelNonTiedUnitSellingPrice(nonTiedIndex).GetText(WebDriver),
				Quantity = int.Parse(TxtItemLevelNonTiedQuantity(groupIndex, itemIndex, nonTiedIndex).GetText(WebDriver))
			};

			return itemQuoteData;
		}

		public ItemQuoteData GetNonTiedItemTotalValuesWithQuantity(int groupIndex = 1, int itemIndex = 1, int nonTiedIndex = 1, bool contractCodeRequired = false)
		{
			Logger.Write("Getting Values for Item " + itemIndex + " in Shipping Group " + groupIndex + " With Quantity");
			Logger.Write("-------------------------");

			var itemQuoteDataWithQuantity = new ItemQuoteData
			{
				ListPrice = LblItemLevelNonTiedListPrice(groupIndex, itemIndex, nonTiedIndex).GetText(WebDriver).Substring(1),
				Discount = Convert.ToDouble(LblItemLevelNonTiedDiscount(groupIndex, itemIndex, nonTiedIndex).GetText(WebDriver).Split('/')[1].Substring(2)),
				DiscountOffList = Convert.ToDouble(LblItemLevelNonTiedDiscount(groupIndex, itemIndex, nonTiedIndex).GetText(WebDriver).Split('/')[0].Substring(0).Split('%')[0]),
				SellingPrice = LblItemLevelNonTiedSellingPrice(groupIndex, itemIndex, nonTiedIndex).GetText(WebDriver).Substring(1)
			};

			return itemQuoteDataWithQuantity;
		}


		public CreateQuotePage GetSingleLineItemValues(int itemCount)
		{
			var values = new CreateQuotePage(WebDriver);
			int i = itemCount;
			Logger.Write("Getting Values for Item ");
			Logger.Write("-------------------------");

			values.SellingPrice = ByTxtItemLevelUnitSellingPrice(i).GetText(WebDriver);
			//values.TaxAmount = LblItemLevelTotalTax(i).GetText(WebDriver);
			//values.ListPrice = LblItemLevelUnitListPrice(i).GetText(WebDriver);
			values.DiscountOffList = ByTxtItemLevelDiscountOffList(i).GetText(WebDriver);

			return values;
		}

		public List<ItemQuoteData> GetLineItemValuesArb(int totalNumberOfItems, bool contractCodeRequired = true)
		{
			var lineItems = new List<ItemQuoteData>();

			for (int i = 1; i <= totalNumberOfItems; i++)
			{
				Logger.Write("Getting Values for Item " + i);
				Logger.Write("-------------------------");
				var itemQuoteData = new ItemQuoteData
				{
					SellingPrice = ByTxtItemLevelUnitSellingPrice(i).GetText(WebDriver),
					ContractCode = contractCodeRequired ? ByTxtContractCode(i).GetText(WebDriver) : "",
					FinalPrice = LblItemLevelTotalAmount(i).GetText(WebDriver),
					TotalShipping = LblItemLevelTotalShipping(i).GetText(WebDriver),
					TaxAmount = LblItemLevelSummaryTotalTax(i).GetText(WebDriver),
					EcoFee = LblItemLevelTotalEcoFee(i).GetText(WebDriver)
				};

				Logger.Write("-------------------------");

				lineItems.Add(itemQuoteData);
			}

			return lineItems;
		}

		public void ARBSystemDetails(int groupIndex, int itemIndex)
		{
			WebDriver.GetElement(By.Id("quoteCreate_LI_displayArbDetails_" + groupIndex + "_" + itemIndex + "")).Click(WebDriver);
		}

		public List<string> GetAllARBSystemSearch()
		{
			IList<IWebElement> list = WebDriver.GetElements(By.CssSelector("tbody > tr > td"));
			List<string> systemDetailsAllValues = new List<string>();
			var total = list.Count;
			if (total >= 3)
			{
				foreach (IWebElement values in WebDriver.GetElements(
					By.CssSelector("tbody > tr > td")))
				{
					systemDetailsAllValues.Add(values.GetText(WebDriver));


				}
				CloseDialogBox.Click(webDriver);

			}
			else
			{

				Assert.Fail("Count did not match");
			}
			return systemDetailsAllValues;
		}

		public List<ItemQuoteData> GetLineItemValuesApos(int totalNumberOfItems, int groupIndex = 1, bool contractCodeRequired = true)
		{
			var lineItems = new List<ItemQuoteData>();

			for (int i = 1; i <= totalNumberOfItems; i++)
			{
				Logger.Write("Getting Values for Item " + i);
				Logger.Write("-------------------------");
				var itemQuoteData = new ItemQuoteData
				{
					ListPrice = LblItemListPriceApos(i, groupIndex).GetText(WebDriver),
					SellingPrice = LblItemSellingPriceApos(i, groupIndex).GetText(WebDriver),
					Discount = (LblItemDiscountApos(i, groupIndex).GetText(WebDriver).Trim() == "") ? 0 : Convert.ToDouble(LblItemDiscountApos(i, groupIndex).GetText(WebDriver)),
					TaxAmount = LblItemTotalTaxApos(i, groupIndex).GetText(WebDriver),
					FinalPrice = LblItemTotalAmountApos(i, groupIndex).GetText(WebDriver)
				};

				Logger.Write("-------------------------");

				lineItems.Add(itemQuoteData);
			}

			return lineItems;
		}


		public bool IsContractCodeExists(int index)
		{
			var element = ByTxtContractCode(index).Displayed;
			return element;
		}

		public CreateQuotePage SelectCatalog(Catalogs catalog)
		{
			var selectCatalog = new SelectCatalogDialog(WebDriver);
			selectCatalog.SelectCatalog(catalog);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage SelectCatalogAny(Catalogs catalog)
		{
			var selectCatalog = new SelectCatalogDialog(WebDriver);
			selectCatalog.SelectCatalog(catalog);
			return new CreateQuotePage(WebDriver);
		}

		public YourSolutionsPage SelectSolutionsCatalog(Catalogs catalog = Catalogs.EmergingBusiness)
		{
			var selectCatalog = new SelectCatalogDialog(WebDriver);
			selectCatalog.SelectSolutionCatalog(catalog);
			if (WebDriver.Url.Contains($"identity/global/"))
				WebDriver.RefreshCurrentPage();
			WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(40));
			wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("create_new_solution")));

			//webDriver.WaitForElementDisplay(BtnCreateNewSolution, TimeSpan.FromSeconds(60));
			//WebDriver.WaitForElementDisplay(GridYourSolutions, TimeSpan.FromSeconds(40));
			return new YourSolutionsPage(WebDriver);
		}

		public string GetSolutionId()
		{
			string solution = SolutionId.GetText(WebDriver);
			return solution.Substring(11, solution.Length - 11);
		}

		public CreateQuotePage EnterCustomerNumber(string customerNumber)
		{
			TxtCustomerNumber.SetText(WebDriver, customerNumber);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return new CreateQuotePage(WebDriver);

		}

		public CreateQuotePage SearchAndPatchExistingInstallAtCustomer(IWebDriver WebDriver, string customerNumber)
		{
			upgradeQuoteSearchExistingInstallAtCustomer.Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			new CustomerSearchPage(WebDriver).SearchCustomerByCustomerNumber(customerNumber);
			new CustomerDetailsPage(WebDriver).BtnUseInQuoteAsInstallAtCustomer.Click(WebDriver);
			new WebDriverWait(WebDriver, TimeSpan.FromSeconds(60));
			WebDriver.WaitForElementDisplay(new CreateQuotePage(WebDriver).upgradeQuoteSearchExistingInstallAtAddress, TimeSpan.FromSeconds(20));
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return new CreateQuotePage(WebDriver);
		}


		public CreateQuotePage ChooseCustomerFromAccount(string customerNumber)
		{
			LnkChooseCustomerFromAccount.Click(WebDriver);
			WebDriver.GetElement(
				By.XPath("//*[@id='DataTables_Table_quoteCreate_customerSelect_grid']//tr//td[contains(text(),'" + customerNumber +
						 "')]//..//a[normalize-space()='Select']")).Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}


		public CreateQuotePage ChooseShippingAddress(string custName)
		{
			WebDriver.GetElement(
				By.XPath(
					"//*[@id='DataTables_Table_gridChangeAddress']/tbody//tr//td[normalize-space()='" +
					custName + "']//..//a[normalize-space()='Select']")).Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public ProductSearchResultsPage AddItemFromOpportunity(int shippingGroupIndex = 1,
			string opportunityLineItemId = "")
		{
			WebDriver.GetElements(By.XPath("//button[contains(@id,'" + pagePrefix + "_additem_top_')]/following-sibling::button"))[shippingGroupIndex - 1].Click();

			WebDriver.GetElement(By.Id("quoteCreate_addItemFromOpportunity_" + (shippingGroupIndex - 1) + "_"))
				.Click(WebDriver);

			if (!string.IsNullOrEmpty(opportunityLineItemId))
				WebDriver.GetElement(
					   By.XPath("//*[@id='opportunityLine_productGrid']//td[text()='" + opportunityLineItemId + "']"))
				   .FindElement(By.XPath("following-sibling::/a"))
				   .Click(WebDriver);
			else
				WebDriver.GetElement(
						By.XPath("//*[@id='opportunityLine_productGrid']//a"))
					.Click(WebDriver);

			return new ProductSearchResultsPage(WebDriver);
		}

		public CreateQuotePage BtnAddItem()
		{
			WebDriver.FindElement(By.XPath("//*[contains(@id,'quoteCreate_additem_top_0_')]")).Click(WebDriver);
			return new CreateQuotePage(WebDriver);

		}
		public CreateQuotePage BtnItem()
		{
			WebDriver.FindElement(By.Id("button_select_usic1f")).Click(WebDriver);
			return new CreateQuotePage(WebDriver);

		}

		public CreateQuotePage BtnAddItemCreateQuote(int i)
		{
			string xpath = string.Format("//*[@id='quoteCreate_additem_top_{0}_']", i);
			WebDriver.FindElement(By.XPath(xpath)).Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}


		public CreateQuotePage EnterQuoteHeaderDetails(string quoteName = "", string ponumber = "",
			string sfdcDealId = "", string endUserCustomerNumber = "", string shippingMethod = "")
		{
			if (!string.IsNullOrEmpty(quoteName))
			{
				TxtQuoteName.SetText(WebDriver, quoteName);
			}

			if (!string.IsNullOrEmpty(ponumber))
			{
				TxtPoNumber.SetText(WebDriver, ponumber);
			}

			if (!string.IsNullOrEmpty(sfdcDealId))
			{
				TxtSfdcDealId.SetText(WebDriver, sfdcDealId);
			}

			if (!string.IsNullOrEmpty(endUserCustomerNumber))
			{
				TxtEndUserCustomerNumber.SetText(WebDriver, endUserCustomerNumber);
			}

			if (!string.IsNullOrEmpty(shippingMethod))
			{
				ShippingMethodGroupLevel().PickDropdownByText(WebDriver, shippingMethod);
			}

			return new CreateQuotePage(WebDriver);
		}

		public ProductSearchPage AddItemsFromSearch(int? shippingGroupIndex = 0)
		{
			WebDriver.FindElement(By.Id(pagePrefix + "_additem_top_" + shippingGroupIndex + "_")).Click(WebDriver);
			//WebDriver.GetElement(By.Id(pagePrefix + "_additem_top_" + shippingGroupIndex + "_")).Click(WebDriver);
			Logger.Write("Clicked on Add Shipping group - " + shippingGroupIndex + 1);
			WebDriver.WaitForPageLoad();
			return new ProductSearchPage(WebDriver);
		}

		public ProductSearchPage AddItemsFromSearchTopButton()
		{
			AddItemTopButton.Click(WebDriver);
			return new ProductSearchPage(WebDriver);
		}

		public CreateQuotePage RemoveItem(int itemindex)
		{
			LnkRemoveItem(itemindex).Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage ApplyContractCodeToAllItems(string contractCode, bool applyToAllItems = true, bool getPaymentTerms = true)
		{
			if (!string.IsNullOrEmpty(contractCode))
			{
				ByTxtContractCode().SetText(WebDriver, contractCode);
				new CreateQuotePage(WebDriver).GetPaymentTerms();
				WebDriver.VerifyBusyOverlayNotDisplayed(); // After patching contract code wait for busy overlay
			}

			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage ApplyContractCodeToAll(string contractCode, bool applyToAllItems = true, bool getPaymentTerms = true)
		{
			if (!string.IsNullOrEmpty(contractCode))
			{
				ByTxtContractCode().SetText(WebDriver, contractCode);
				BtnApplyAll.Click(WebDriver);
				new CreateQuotePage(WebDriver).GetPaymentTerms();
				WebDriver.VerifyBusyOverlayNotDisplayed(); // After patching contract code wait for busy overlay
			}

			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage DeleteContractCode(int itemIndex = 1)
		{
			if (GetContractCodeText(itemIndex) != "")
				ByTxtContractCode(itemIndex).SetText(WebDriver, "");
			var blank = GetContractCodeText(itemIndex);
			return new CreateQuotePage(WebDriver);
		}

		//public CreateQuotePage SetContractAsDefaultYes()
		//{
		//    if (BtnSetContractAsDefaultYes.Enabled)
		//        BtnSetContractAsDefaultYes.Click(WebDriver);
		//    return new CreateQuotePage(WebDriver);
		//}

		public CreateQuotePage ClosePopUp()
		{
			PopupClose.Click();
			return new CreateQuotePage(WebDriver);
		}

		public QuoteDetailsPage SaveQuote()
		{
			VerifyExportComplianceEndUse();
			WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
			wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("quoteCreate_saveQuote")));
			BtnSaveQuote.Click(WebDriver);
			new QuoteDetailsPage(WebDriver).WaitForQuoteValidationToComplete();
			return new QuoteDetailsPage(WebDriver);
		}

		public CreateQuotePage VerifyExportComplianceEndUse()
		{
			WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
			ExportProductUsage.GetText(WebDriver).Should().NotBeNullOrEmpty();
			return new CreateQuotePage(WebDriver);
		}

		public void delay(int timeOutInSeconds)
		{
			System.Threading.Thread.Sleep(timeOutInSeconds * 1000);
		}

		public QuoteDetailsPage SubmitQuoteWithOverride()
		{
			DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(WebDriver);
			fluentWait.PollingInterval = TimeSpan.FromMilliseconds(2);
			fluentWait.Timeout = TimeSpan.FromSeconds(20);
			fluentWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("quoteCreate_saveQuote")));
			delay(15);
			IJavaScriptExecutor executor = (IJavaScriptExecutor)WebDriver;
			executor.ExecuteScript("document.querySelector('#quoteCreate_saveQuote').click()");
			delay(8);
			executor.ExecuteScript("document.querySelector('#quoteCreate_GSCVValidation .row>div:nth-child(2) a').click()");
			BtnServiceErrorOverrideYes1.Click(WebDriver);
			BtnSaveQuote.Click(WebDriver);
			delay(8);
			new QuoteDetailsPage(WebDriver).WaitForQuoteValidationToComplete();
			return new QuoteDetailsPage(WebDriver);
		}

		public QuoteDetailsPage SaveAllLinkedQuotes()
		{
			//var quoteid = lblQuoteIdText.GetText(WebDriver);
			//Logger.Write("Quote id :" + quoteid);
			SaveAllLinkedQuotesButton.Click(WebDriver);
			// CheckForServiceOverrideError();
			//new QuoteDetailsPage(WebDriver).WaitForQuoteValidationToComplete();
			return new QuoteDetailsPage(WebDriver);
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

		public CreateQuotePage UpdateItemLevelUnitSellingPrice(int itemindex, int groupIndex, double value)
		{
			ByTxtItemLevelUnitSellingPrice(itemindex, groupIndex).SetText(WebDriver, value.ToString(CultureInfo.InvariantCulture));
			WebDriver.WaitForFetchingCart();
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage UpdateDiscountOffList(int index, string value)
		{
			
			//WebDriver.ScrollIntoElement(ByTxtItemLevelDiscountOffList(index));
			//ByTxtItemLevelDiscountOffList(index).Clear();
			WebDriver.WaitForPageLoad();
			//ByTxtItemLevelDiscountOffList(index).Click();
			ByTxtItemLevelDiscountOffList(index).SetText(WebDriver, value);
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage UpdateDiscountOffListInShipGroup(int itemIndex, int groupIndex, string value)
		{
			ByTxtItemLevelDiscountOffList(itemIndex, groupIndex).SetText(WebDriver, value);
			//WebDriver.WaitForFetchingCart();
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage UpdateQuantity(int index, string value)
		{
			ByTxtItemLevelQuantity(index).SetText(WebDriver, value);
			//WebDriver.WaitForFetchingCart();
			//new CreateQuotePage(WebDriver).WaitForQuoteValidationToComplete();
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage UpdateQuantityManualMode(int index, string value)
		{
			UpdateQuantityInManualMode(index).SetText(WebDriver, value);
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage UpdateQuantityManualModeNonTied(int index, string value)
		{
			UpdateQuantityInManualModeNonTied(index).SetText(WebDriver, value);
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage UpdateDolManualModeNonTied(int index, string value)
		{
			UpdateDOLInManualMode(index).SetText(WebDriver, value);
			return new CreateQuotePage(WebDriver);
		}
		public CreateQuotePage UpdateSellingPriceManualMode(int index, string value)
		{
			UpdateSellingPriceInManualMode(index).SetText(WebDriver, value);
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage UpdateDOLManualMode(int index, string value)
		{
			UpdateDOLInManualMode(index).SetText(WebDriver, value);
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage UpdateQuantityInShipGroup(int itemIndex, int groupIndex, string value)
		{
			ByTxtItemLevelQuantity(itemIndex, groupIndex).SetText(WebDriver, value);
			// WebDriver.WaitForFetchingCart();
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage UpdateShippingDiscount(int groupIndex, double value)
		{
			TxtGroupLevelShippingDiscount(groupIndex).SetText(WebDriver, value.ToString(CultureInfo.InvariantCulture));
			//WebDriver.WaitForFetchingCart();
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage ApplyContractCode(int index, string value)
		{
			ByTxtContractCode(index).SetText(WebDriver, value);
			WebDriver.WaitForFetchingCart();
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage ApplyContractCodeAtGroup(int groupNum, int itemNum, string value)
		{
			TxtContractCodeAt(2, 1).SetText(WebDriver, value);
			WebDriver.WaitForFetchingCart();
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage UpdateGroupLevelShippingMethod(IWebDriver webDriver, int groupIndex, string value)
		{
			new CreateQuotePage(WebDriver).DdlGroupLevelShippingMethod(groupIndex).PickDropdownByText(WebDriver, value);
			//WebDriver.WaitForFetchingCart();
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage UpdateLineItemsData(int index, string quantity, string discount, double sellingPrice)
		{

			UpdateItemLevelUnitSellingPrice(index, 1, sellingPrice);
			UpdateQuantity(index, quantity);
			UpdateDiscountOffList(index, discount);


			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage ClickOnVersionRadioBtn()
		{
			RdbGenerateNewQuoteNumberFromCopyQuote.Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public QuoteDetailsPage ClickOnQuoteVersionNext()
		{
			BtnCopyQuoteNext.Click(WebDriver);
			return new QuoteDetailsPage(WebDriver);
		}

		public CreateQuotePage ClickOnAddNewInstallAtCustomer(int index)
		{
			InstallAtAddNewCustomer(index).Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage AddNewInstallAtCustomerForUpgradeQuote(DataRow row, string randomLetters)
		{
			upgradeQuoteAddNewInstallAtCustomer.Click(WebDriver);
			CreateInstallAtCustomer(WebDriver, row, randomLetters);
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage AddNewInstallAtAddressForUpgradeQuote(DataRow row, string randomLetters)
		{
			upgradeQuoteAddNewInstallAtAddress.Click(WebDriver);
			CreateInstallAtNewAddress(WebDriver, row, randomLetters);
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage ClickOnAddNewAddress(int index)
		{
			InstallAtAddressAddNewAddress(index).Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage AddNewInstallAtAddress(DataRow row, int Index)
		{
			String randomLetters = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly);
			ClickOnAddNewAddress(Index);
			CreateInstallAtNewAddress(WebDriver, row, randomLetters);
			return new CreateQuotePage(WebDriver);
		}

		public string GetLineItemOrderCode(int index)
		{
			return LblItemLevelOrderCode(index).GetText(WebDriver);
		}

		// Copy shipping group and verify new group is been added
		public CreateQuotePage CopyShippingGroup(String Copies)
		{
			CopyShippingGroup(1).Click(WebDriver);
			QuantityText.SetText(WebDriver, Copies);
			SaveChanges.Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();

			WaitForBusyIndicatorAppearAndDisappear();
			var totalGroupsInQuote = GetNumberofShippingGroups();
			totalGroupsInQuote.Should().Be((Convert.ToInt32(Copies)) + 1);
			Logger.Write("Total number of shipping groups in quote: " + totalGroupsInQuote);
			return new CreateQuotePage(WebDriver);
		}

		public bool IsSaveQuoteButtonEnabled()
		{
			return BtnSaveQuote.Enabled;
		}

		public bool IsSaveAllLinkedQuotesButtonEnabled()
		{
			return SaveAllLinkedQuotesButton.Enabled;
		}

		public bool IsSaveandSplitEnabled()
		{
			return SaveAndSplitButton.Enabled;
		}

		public bool IsLanguageDropDownEnabled()
		{
			return QuoteCreateLanguageDorpdown.Enabled;
		}
		public bool IsQuantityEnabled(int index1, int index2)
		{
			return GetItemQuantity(index1, index2).Enabled;
		}

		public string GetTotalItems()
		{
			string itemCountText = LblItemCountMastHead.GetText(WebDriver);
			string count = itemCountText.Split()[0];
			return count;
		}

		public string GetContractCodeText(int index)
		{
			return ByTxtContractCode(index).GetText(WebDriver);
		}

		public string GetContractCodeFromGroup(int itemIndex, int groupIndex)
		{
			return TxtContractCodeAt(groupIndex, itemIndex).GetText(WebDriver);
		}

		public string GetLineItemUnitListPrice(int index)
		{
			return ByLblItemLevelUnitListPrice(index).GetText(WebDriver);
		}

		public CreateQuotePage EnterCoupon(string coupon)
		{
			TxtAddCoupon.SetText(WebDriver, coupon);
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage RemoveCouponCode()
		{
			RemoveCoupon.Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage SetLineItemQuantity(int index, int quantity)
		{
			ByTxtItemLevelQuantity(index).SetText(WebDriver, quantity.ToString());
			return new CreateQuotePage(WebDriver);
		}

		public string GetLineItemTotalAmount(int index)
		{
			return LblItemLevelTotalAmount(index).GetText(WebDriver);
		}

		public void SelectShippingMethod(int index, int shippingMethodIndex)
		{
			DdlGroupLevelShippingMethod(index).PickDropdownByIndex(WebDriver, shippingMethodIndex);
		}

		public void SelectShippingMethod(int index, string shippingMethod)
		{
			DdlGroupLevelShippingMethod(index).PickDropdownByText(WebDriver, shippingMethod);
		}

		public void ClickOnAddNewShippingAddrAtGroup(int? shippingGroupIndex = 0)
		{
			GroupLevelShippingAddNewAddress(shippingGroupIndex).Click(WebDriver);
			//Thread.Sleep(5000);
		}

		public void ClickOnEditShippingContactAtGroup(int shippingGroupIndex = 0)
		{
			GroupLevelShippingEditAddress(shippingGroupIndex).Click(WebDriver);
		}

		public void ClickOnChangeShippingContactAtGroup(int shippingGroupIndex = 0)
		{
			GroupLevelShippingChangeShippingAddress(shippingGroupIndex).Click(WebDriver);
		}


		public void ChangeShipToAddressAtItemLevel(int index, int indexNewShipToAddress)
		{
			LnkItemLevelPickDifferentAddress(index).Click(WebDriver);
			int count = 0;
			ReadOnlyCollection<IWebElement> Address =
				WebDriver.FindElements(
					By.Id("CommerceLineItemSelectShippingAddressController_addressSelect_addressGrid_select"));
			foreach (var element in Address)
			{
				count++;
				if (count == indexNewShipToAddress)
				{
					element.Click();
				}

			}

		}

		public AddressRow GetAddressRowDetails(int index = 1)
		{
			var addr = new AddressRow
			{
				Company = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[" + index + "]/td[2]"), TimeSpan.FromSeconds(2)).Text,
				Name = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[" + index + "]/td[3]"), TimeSpan.FromSeconds(2)).Text,
				AddressLines = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[" + index + "]/td[4]"), TimeSpan.FromSeconds(2)).Text,
				City = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[" + index + "]/td[5]"), TimeSpan.FromSeconds(2)).Text,
				State = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[" + index + "]/td[6]"), TimeSpan.FromSeconds(2)).Text,
				ZipCode = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[" + index + "]/td[7]"), TimeSpan.FromSeconds(2)).Text,
				Email = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[" + index + "]/td[8]"), TimeSpan.FromSeconds(2)).Text,
				Type = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[" + index + "]/td[9]"), TimeSpan.FromSeconds(2)).Text,
				Relationship = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[" + index + "]/td[10]"), TimeSpan.FromSeconds(2)).Text,
				Status = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[" + index + "]/td[11]"), TimeSpan.FromSeconds(2)).Text,
				UndeliveredReasonValue = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[" + index + "]/td[12]"), TimeSpan.FromSeconds(2)).Text
			};
			return addr;
		}

		public List<AddressRow> GetAllAvailableAddressesInModal(IWebDriver webDriver)
		{
			List<AddressRow> availableAddresses = new List<AddressRow>();

			//Need the below two lines to get the table data correctly
			webDriver.GetElement(By.Id("gridChangeAddress_fromto"), TimeSpan.FromSeconds(5)).IsElementVisible();
			webDriver.FindElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[1]/td[11]")).GetText(webDriver).Equals("Active");
			var count = webDriver.FindElements(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr"), TimeSpan.FromSeconds(2)).Count;

			for (int index = 1; index <= count; index++)
			{
				availableAddresses.Add(GetAddressRowDetails(index));
			}
			return availableAddresses;
		}

		public CreateQuotePage expandAddresssection() 
		{
			webDriver.ScrollToElement(ExpandAddress);
			ExpandAddress.Click();
			return new CreateQuotePage(webDriver);

		}
			public CreateQuotePage movetoBillingAddNewAddressLink()
		{
			webDriver.ScrollToElement(BillingAddNewAddressLink);
			return new CreateQuotePage(webDriver);
		}

		public CreateQuotePage movetoSoldToAddNewAddressLink()
		{
			webDriver.ScrollToElement(SoldToAddNewAddress);
			return new CreateQuotePage(webDriver);
		}


		public CreateQuotePage movetoSoldToAddNewContact()
		{
			webDriver.ScrollToElement(SoldToAddNewContact);
			return new CreateQuotePage(webDriver);
		}
		public void ClickSelectOnChangeAddressPopUp(IWebDriver webDriver, int index = 1)
		{
			webDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[" + index + "]/td[13]/add-component/change-address-actions/a"), TimeSpan.FromSeconds(2)).Click(webDriver);
		}

		public void ChangeAddress()
		{
			WebDriver.WaitForPageLoad();
			WebDriver.WaitFor(x => ChkAllShippingGrp.Displayed, 160);
			ChkAllShippingGrp.UnSelectCheckBox(WebDriver);
			for (int i = 1; i <= 2; i++)
			{
				if (i == 1)
				{
					string ChangeAddressXpath = string.Format("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[{0}]", i);
					string BtnSelectChgAdd = string.Format("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[{0}]/td[13]/add-component/change-address-actions/a", i);
					WebDriver.FindElement(By.XPath(BtnSelectChgAdd)).Click(WebDriver);
					break;
				}
			}

		}
		// SDP //
		public void ChangeBillingAddress()
		{
			WebDriver.WaitForPageLoad();

			ChangeBillToAddress.Click();
			WebDriver.WaitFor(x => ChangeBillAddressModal.Displayed, 160);


			string BtnSelectChgAddXpath = string.Format("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[{0}]/td[14]/add-component/change-address-actions/a", 1);
			WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
			var BtnSelectChgAdd = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(BtnSelectChgAddXpath)));

			BtnSelectChgAdd.Click(WebDriver);
		}

		public void ClickAddShippingGroup()
		{
			//new CreateQuotePage(WebDriver).AddShippingGroup.Click(WebDriver);
			//WebDriver.WaitForElementDisplay(new CreateQuotePage(WebDriver).AddShippingGroup, TimeSpan.FromSeconds(5));
			//WebDriver.ScrollIntoElement(new CreateQuotePage(WebDriver).AddShippingGroup);
			//new CreateQuotePage(WebDriver).AddShippingGroup.Click();
			WebDriver.FindElement(By.Id("quoteCreate_addShippingGroup")).Click(WebDriver);
		}


		public CreateQuotePage SplitQuoteByGroup()
		{
			WaitForBusyIndicatorAppearAndDisappear();
			Bygroup.Click(WebDriver);
			ReviewQuote.Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage SplitQuoteByLineItem()
		{
			WaitForBusyIndicatorAppearAndDisappear();
			ByItem.Click(WebDriver);
			ReviewQuote.Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return new CreateQuotePage(WebDriver);
		}

		public void SaveAllQuotes()
		{
			SaveAllButton.Click(WebDriver);
		}

		public void SendAllQuotes()
		{
			SendAllButton.Click(WebDriver);
		}

		public CreateQuotePage SplitQuoteByEdd()
		{
			WaitForBusyIndicatorAppearAndDisappear();
			ByEDD.Click(WebDriver);
			ReviewQuote.Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return new CreateQuotePage(WebDriver);
		}

		public bool DisplayNontiedMessage()
		{
			//By loc = By.XPath(".//div[contains(text(),'The Quantity of the Non-tied items has been set to 1')]");
			By loc = By.XPath(".//div[contains(text(),'The Quantity of the Non-tied items has been set to 1. If you want a different Qty please update it manually before saving the Quote.')]");

			try
			{
				WebDriver.FindElement(loc);
				return true;
			}
			catch (NoSuchElementException)
			{
				return false;
			}
		}

		public CreateQuotePage SplitQuoteByCustomSplit()
		{
			WaitForBusyIndicatorAppearAndDisappear();
			CustomSplit.Click(WebDriver);
			ReviewQuote.Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public bool RemoveCustomQuoteGroup()
		{
			RemoveCustomQuoteGroups.FirstOrDefault().Click(WebDriver);
			return true;
		}

		public bool ValidateCustomQuoteCancel()
		{
			CustomeQuoteCancel.Click(WebDriver);
			return new PCFQuoteSummaryPage(webDriver).BtnMoreActions.IsElementDisplayed(WebDriver);
		}

		public bool IsPromotionsDisplayed()
		{
			var customerCreatePage = new CustomerCreatePage(WebDriver);
			return customerCreatePage.ElementExistValidation(PromotionAreaby);
		}

		public bool IsICodeOverrideMessage()
		{
			var customerCreatePage = new CustomerCreatePage(WebDriver);
			return customerCreatePage.ElementExistValidation(ICodeOverridMessage);
		}

		public void SelectPromotion(string promoName)
		{

			WebDriver.VerifyBusyOverlayNotDisplayed();
			var listOfPromotions = WebDriver.GetElements(By.XPath(".//*[@id='quoteCreate_D_Promos_-']"));
			foreach (var promotion in listOfPromotions)
			{
				var promotionLnk = promotion.FindElement(By.XPath("./a"));
				if (promotionLnk.Text.Contains(promoName))
				{
					var checkPromotion = promotion.FindElement(By.XPath("./input"));
					checkPromotion.SelectCheckBox(WebDriver);
					break;
				}

			}
			WebDriver.VerifyBusyOverlayNotDisplayed();

		}

		public string GetCouponApplied()
		{
			var couponTxt = WebDriver.GetElement(By.Id("quoteCreateLI_D_Coupon_display"));
			var getCouponTxt = couponTxt.GetText(WebDriver);
			return getCouponTxt;
		}

		public string GetCouponText()
		{
			var couponTxt = WebDriver.GetElement(By.XPath("//*[contains(@id,'quoteCreateLI_D_discountName_')]"));
			var getCouponTxt = couponTxt.GetText(WebDriver);
			return getCouponTxt;
		}
		public bool AppliedDNCPromotions(string coupon)
		{
			bool result = PatchedDNC.GetText(WebDriver).Contains(coupon);
			return result;
		}

		public void ExcludeAllPromtion()
		{
			((IJavaScriptExecutor)WebDriver).ExecuteScript("window.scroll(0, 0);");     // This line has been added for Edge Browser. Do not remove the line.
			LnkExcludeAllPromotion.Click(WebDriver);

		}
		public void IncludeAllPromtion()
		{
			LnkIncludeAllPromotion.Click(WebDriver);
		}

		public void UpdateListItems(int index, string quantity, double sellingPrice, string discount)
		{

			UpdateQuantity(index, quantity);
			UpdateItemLevelUnitSellingPrice(index, 1, sellingPrice);
			if (!IsPromotionsDisplayed())
			{
				UpdateDiscountOffList(index, discount);
			}
		}

		public void SplitItemsCustomGroup()
		{
			CustomGroupSplit.Click(WebDriver);
		}

		public void ReviewCustomQuote()
		{   
			ReviewCustomQuotes.Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
		}


		public string GetLineItemProductDescription(int index)
		{
			return LnkItemLevelProductDescription(index).GetText(WebDriver);
		}

		public void ClickItemProductDescription(int shipGroupIndex = 1, int lineItemIndex = 1)
		{
			ItemProductDescription(lineItemIndex, shipGroupIndex).Click(WebDriver);
		}

		public string GetLineItemdolvalue(int index)
		{
			return TxtLineItemDolValue(index).GetText(WebDriver);
		}

		public double GetItemLevelPromotionPercentageValue(int index)
		{
			return Convert.ToDouble(ByLblItemLevelPromotions(index).GetText(WebDriver));
		}
		public string GetpromotionalShippingDiscount(int index)
		{
			return TxtGroupLevelpromotionalShippingDiscount(index).GetText(WebDriver);
		}

		public CreateQuotePage ClickCustomerInformationToggle()
		{
			WebDriver.ScrollToBottom();
			LnkCustomerInformationToggle.Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public IWebElement EnterItemQuantity()
		{
			return WebDriver.FindElement(By.XPath("//*[contains(@id,'quoteCreate_LI_quantity_')]"));
			//return WebDriver.FindElement(By.XPath("//*[contains(@id,'quoteCreate_LI_quantity_input_')]"));

		}

		public IWebElement GetItemQuantity(int index1, int index2)
		{
			return WebDriver.GetElement(By.XPath(String.Format("//*[contains(@id,'quoteCreate_LI_quantity_{0}_{1}')]", index1, index2)));
			//return WebDriver.GetElement(By.Id(String.Format("//*[contains(@id,'quoteCreate_LI_quantity_input_{0}_{1}')]", index1, index2)));
		}

		public ProductConfigurePage Configure(int configItemindex = 1)
		{
			LblItemCountMastHead.Click(WebDriver);
			new HomePage(WebDriver).ConfigItems.Click(WebDriver);
			//LnkItemLevelConfigure(configItemindex).Click(WebDriver);
			return new ProductConfigurePage(WebDriver);
		}

		public ProductConfigurePage ConfigureAtItemLevel(int itemindex = 1, int groupIndex = 1)
		{
			ByLnkItemLevelConfigure(itemindex, groupIndex).Click(WebDriver);
			return new ProductConfigurePage(WebDriver);
		}

		public string GetCustomerNameAfterCustomerLoaded()
		{
			LnkCustomerName.WaitForElementDisplayed(TimeSpan.FromSeconds(30));
			string accCustomerName = LnkCustomerName.GetText(WebDriver);
			return accCustomerName.Substring(accCustomerName.IndexOf(':') + 1).Trim();
		}

		public string GetCompanyNumber()
		{
			return HdrCompanyNumberSegment.GetText(WebDriver);
		}

		public void ExpandAllShowMore()
		{
			var allShowMoreLinks = WebDriver.FindElements(By.ClassName("icon-ui-expand"));
			foreach (var allShowMoreLink in allShowMoreLinks)
			{
				allShowMoreLink.Click(WebDriver);
			}
		}

		public void ClickShowMoreAtIndex(int index)
		{
			//var showMore = WebDriver.GetElements(By.XPath("//div[@class='content-toggle-content ng-scope']"));

			var showMore = WebDriver.GetElements(By.XPath("//div[@class='content-toggle-content']"));
			showMore[index - 1].Click(WebDriver);
		}

		public void ClickExpandAllConfigurationButton()
		{
			WebDriver.ScrollAndClick(By.XPath("//a[@class='grid-btn']"));
		}

		public IWebElement ClickExpandAllConfigurationAtGroup(int? groupIndex = 0)
		{
			return WebDriver.GetElements(By.XPath("//div[@class='mg-btm-10 pull-right ng-star-inserted']/a[1]"))[(int)groupIndex];

		}


		public IWebElement CalendarMABD(int? groupIndex = 1)
		{
			return WebDriver.GetElements(By.XPath("//common-date-picker//span[@class='k-icon k-i-calendar']"))[(int)groupIndex];

		}

		public IWebElement FieldDateMABD(int? groupIndex = 0)
		{
			return WebDriver.GetElements(By.XPath("//common-date-picker//input"))[(int)groupIndex];
		}

		public IWebElement CalendarMABDday(string day)
		{
			//return WebDriver.GetElement(By.XPath("//span[contains(text(),'" + day + "')]"));
			return WebDriver.GetElement(By.XPath("//common-date-picker//td//button[@class='btn btn-sm btn-default']//span[contains(text(),'" + day + "')]"));
		}

		public IWebElement GroupDateMABD(int? groupIndex = 0)
		{
			return WebDriver.GetElements(By.XPath("//*[@id='quoteCreate_GI_arriveByDate_" + groupIndex + "']/div[2]/div/common-date-picker/div/div/span/span/span/span"))[(int)groupIndex];
			
		}

		public int GetTotalNumberOfConfigurations(int? groupIndex = 0)
		{
			//return WebDriver.GetElements(By.CssSelector("#quoteCreate_LI_CS_grid_1 > div > div")).Count;
			return WebDriver.GetElements(By.CssSelector(string.Format("#quoteCreate_LI_CS_grid_{0}_0 > div > div", groupIndex))).Count;

		}

		public string GetConfigSkuCodeAtGroupAndSku(int? groupIndex = 0, int? skuCodeIndex = 1)
		{
			//return WebDriver.GetElements(By.CssSelector("#quoteCreate_LI_CS_grid_1 > div > div")).Count;
			return WebDriver.GetElement(By.XPath(string.Format("(//*[@id='lineitem_config_block_{0}_0']//table[@class='config-option-sku-table'])[{1}]//tbody/tr[2]/td[2]", groupIndex, skuCodeIndex))).GetText(WebDriver);
		}

		public string GetConfigSkuQtyAtGroupAndSku(int? groupIndex = 0, int? skuCodeIndex = 1)
		{
			//return WebDriver.GetElements(By.CssSelector("#quoteCreate_LI_CS_grid_1 > div > div")).Count;
			return WebDriver.GetElement(By.XPath(string.Format("(//*[@id='lineitem_config_block_{0}_0']//table[@class='config-option-sku-table'])[{1}]//tbody/tr[2]/td[1]", groupIndex, skuCodeIndex))).GetText(WebDriver);
		}

		public string GetConfigurationTextAtId(int index)
		{
			return WebDriver.GetElement(
				By.Id(string.Format("quoteCreate_LI_CS_optionId_build1_category{0}", index))).Text;
		}

		public string GetQuoteNumber()
		{
			WebDriver.ScrollToElement(By.Id("quoteNumber"));
			return WebDriver.GetElement(By.Id("quoteNumber")).GetText(WebDriver);
		}

		public CreateQuotePage UpdateNontiedQuantity(int shippingGroupIndex = 1, int itemIndex = 1, int nonTiedItemIndex = 1, string qty = "3")
		{
			//TxtItemLevelNonTiedQuantity(shippingGroupIndex-1, itemIndex-1, nonTiedItemIndex).SetText(WebDriver, qty);
			TxtItemLevelNonTiedQuantity(shippingGroupIndex, itemIndex, nonTiedItemIndex).SetText(WebDriver, qty);

			WebDriver.VerifyBusyOverlayNotDisplayed();
			return new CreateQuotePage(WebDriver);
		}

		public string GetCustomerNumber()
		{

			string cno =
				WebDriver.FindElement(By.Id("currentCustomer_customerNumber"))
					.GetText(WebDriver);
			return cno;

		}

		public CreateQuotePage UpdateNonTiedItemDiscountOffList(int nontiedItemIndex, string disc)
		{
			TxtItemLevelNonTiedDiscountOffList(nontiedItemIndex).SetText(WebDriver, disc);
			//WebDriver.VerifyBusyOverlayNotDisplayed(); //After manual discount wait for busy overlay to complete
			return new CreateQuotePage(WebDriver);
		}

		public bool LineItemOrderCodeExists(int index)
		{
			return LblItemLevelOrderCode(index).GetText(WebDriver) == string.Empty;
		}

		public string GetLineItemTotalTax(int index)
		{
			return LblItemLevelSummaryTotalTax(index).GetText(WebDriver);
		}

		public string GetLineItemTotalEcoFee(int index)
		{
			return LblItemLevelTotalEcoFee(index).GetText(WebDriver);
		}

		public string GetLineItemSellingPrice(int index)
		{
			return ByLblItemLevelSellingPrice(index).GetText(WebDriver);
		}

		public string GetLineItemQuantity(int itemIndex, int groupIndex)
		{
			return ByTxtItemLevelQuantity(itemIndex, groupIndex).GetText(WebDriver);
		}

		public string GetLineItemTotalShippingPrice(int index)
		{
			return LblItemLevelShippingPrice(index).GetText(WebDriver);
		}

		public AposConfigurePage AposServiceTagConfigure(int itemindex = 1, int groupIndex = 1)
		{
			ByLnkItemLevelConfigure(itemindex, groupIndex).Click(WebDriver);
			return new AposConfigurePage(WebDriver);
		}

		public string GetPriceChangeNotificationMsg()
		{
			if (PriceChangeNotificationMsg.Displayed)
			{
				return PriceChangeNotificationMsg.GetText(WebDriver);

			}
			return null;
		}

		public void ExpandAllGoalDealIds()
		{
			var dealIdLinks =
				WebDriver.GetElements(By.CssSelector("#Quotecreation_goaldealsGrid > div > table > tbody > tr > td > a"));
			foreach (var ele in dealIdLinks)
			{
				ele.Click();
			}
		}

		public string GetGoalDealIdFromItem(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_info_goalDealId_" + (shippingGroupIndex - 1) + "_" + (itemIndex - 1))).GetText(WebDriver);
		}


		public string GetGoalDealIdFromSolutiongroup(int shippingGroupIndex = 1, int solutionGroup = 1)
		{
			return
				WebDriver.GetElement(
						By.Id(pagePrefix + "_GI_info_goalDealId_" + (shippingGroupIndex - 1)))
					.GetText(WebDriver);
		}
		public string GetGoalDealIdFromNonTiedItem(int shippingGroupIndex = 1, int itemIndex = 1, int nontiedItemIndex = 1)
		{
			//return WebDriver.GetElements(By.XPath("//*[contains(@id, '" + pagePrefix + "_LI_NTSKU_NonTied_info_goalDealId_" + (shippingGroupIndex - 1) + "_')]"))[nontiedItemIndex - 1].GetText(WebDriver);
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_NTSKU_NonTied_info_goalDealId_" + (shippingGroupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nontiedItemIndex - 1))).GetText(WebDriver); ;
		}

		public string GetMarginFromGroupPickFromListDialog(int groupIndex = 1)
		{
			LnkGroupLevelGoalDealIdPickFromList(groupIndex).Click();
			//return WebDriver.GetElement(By.XPath("//*[@id='COM']/div[4]/div/div[2]/div[1]/table/tbody/tr/td[2]/table[2]/tbody/tr/td[4]")).GetText(WebDriver);
			return WebDriver.GetElement(By.XPath("/td[@class='detail-cell']//table[@class='solution-select-group-details']//tbody/tr/td[4]")).GetText(WebDriver);
		}

		public string GetMarginFromItemLevelPickFromListDialog(int itemIndex = 1)
		{
			LnkItemLevelGoalDealIdPickFromList(itemIndex).Click(WebDriver);
			//return WebDriver.GetElement(By.XPath("//*[@id='COM']/div[4]/div/div[2]/div[1]/div/div[2]/div/table/tbody/tr/td/table[1]/tbody/tr/td[3]")).GetText(WebDriver);
			return WebDriver.GetElement(By.XPath("/td[@class='detail-cell']//table[@class='c-data-grid']//tbody/tr/td[3]")).GetText(WebDriver);
		}



		public CreateQuotePage PickGoalDealIdFromListForLineItem(int itemIndex, string goalDealId, int level = 1, string sfdcdeal = "", string enduserAcc = "")
		{
			LnkItemLevelGoalDealIdPickFromList(itemIndex).Click(WebDriver);
			if (sfdcdeal != "")
			{
				lblPFLSFDCvalue.GetText(WebDriver).Contains(sfdcdeal);
			}
			if (enduserAcc != "")
			{
				lblPFLEndUserAccountvalue.GetText(WebDriver).Contains(enduserAcc);
			}
			if (level != 1)
			{
				WebDriver.GetElement(By.XPath("//*[@class='modal-body']//div[@class='accordion-group'][" + level + "]//a[1]")).Click(WebDriver);
			}

			//lstgoaldealfamilyorclassitemsPerPage.PickDropdownByText(WebDriver, " 40 per page ");
			WebDriver.GetElement(By.XPath("//td[contains(text(), '" + goalDealId + "')]/preceding-sibling::td/input")).Click(WebDriver);
			WebDriver.GetElements(By.XPath("//*[@class='btn-bar']//button[normalize-space()='Select']"))[0].Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return new CreateQuotePage(WebDriver);
		}


		public CreateQuotePage PickGoalDealIdFromListForSolGroupLevel(int solGroupIndex, string goalDealId)
		{
			LnkSolGroupLevelGoalDealIdPickFromList(solGroupIndex).Click(WebDriver);

			WebDriver.GetElement(By.XPath("//td[contains(text(), '" + goalDealId + "')]/..//a")).Click(WebDriver);
			WebDriver.GetElement(By.XPath("//td[contains(text(), '" + goalDealId + "')]/../following-sibling::tr//a[normalize-space()='Select']")).Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage PickGoalDealIdFromListForNonTiedItem(int nonTiedItemIndex, string goalDealId, int level = 1, string sfdcdeal = "", string enduserAcc = "")
		{
			//Below will work for single non tied item only
			WebDriver.GetElement(By.XPath("//non-tied-sku//a[@id='goalPickFromListId']")).Click(WebDriver);
			if (sfdcdeal != "")
			{
				lblPFLSFDCvalue.GetText(WebDriver).Should().BeEquivalentTo(sfdcdeal);
			}
			if (enduserAcc != "")
			{
				lblPFLEndUserAccountvalue.GetText(WebDriver).Should().BeEquivalentTo(enduserAcc);
			}

			if (level != 1)
			{
				WebDriver.GetElement(By.XPath("//*[@class='modal-body']//div[@class='accordion-group'][" + level + "]//a[1]")).Click(WebDriver);
			}

			WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_goaldeal_familyorclass_grid']//tbody//tr//td[contains(text(), '" + goalDealId + "')]/..//input")).Click(WebDriver);

			WebDriver.GetElement(By.XPath("//*[@class='btn-bar']//button[normalize-space()='Select']")).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage RemoveGoalDealIdFromLineItem(int groupIndex = 1, int itemIndex = 1)
		{
			WebDriver.GetElement(
				By.XPath("//*[@id='" + pagePrefix + "_LI_info_goalDealId_" + (groupIndex - 1) + "_" + (itemIndex - 1) +
						 "']//a")).Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage RemoveGoalDealIdFromNontiedItem(int groupIndex = 1, int itemIndex = 1, int nonTiedItemIndex = 1)
		{
			WebDriver.GetElement(
				By.XPath("//*[@id='" + pagePrefix + "_LI_NTSKU_NonTied_info_goalDealId_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" +
						 (nonTiedItemIndex - 1) + "']//a")).Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public bool CheckIfGoalLinksAvailableAtGroupLevel(int groupIndex = 1)
		{

			if (WebDriver.TryFindElement(LnkNewRequestGroupLevel(groupIndex), new TimeSpan(5)) && WebDriver.TryFindElement(LnkPickFromListGroupLevel(groupIndex), new TimeSpan(5)))
				return true;
			else
				return false;
		}

		public bool CheckIfGoalLinkAvailableForGroupItems(int groupIndex = 1)
		{
			if (WebDriver.FindElements(By.XPath("//*[contains(@id,'" + pagePrefix + "_createNewGoalDealId_" + (groupIndex - 1) + "')]")).Count != 0 &&
				WebDriver.FindElements(By.XPath("//*[contains(@id,'" + pagePrefix + "_LI_selectGoalDealId_" + (groupIndex - 1) + "')]")).Count != 0)
				return true;
			else
				return false;
		}



		public QuoteDetailsPage CheckForServiceOverrideError()
		{
			var found = WebDriver.TryFindElement(BtnServiceErrorOverride, new TimeSpan(10));
			if (found)
			{
				BtnServiceErrorOverride.Click(WebDriver);
				BtnServiceErrorOverrideYes.Click(WebDriver);
				SaveQuote();
			}

			return new QuoteDetailsPage(WebDriver);
		}

		public bool CheckForDfsSofCreditFailure()
		{
			var found = WebDriver.TryFindElement(LnkCheckDfsCredit, new TimeSpan(15));
			return found;
		}

		#region Solutions Code

		public bool VerifyXPODandProductValidationErrorMessages()
		{
			bool result = false;
			WebDriver.VerifyBusyOverlayNotDisplayed();
			DsaUtil.WaitForElement(CreateQuoteOverrideValidationMessages, WebDriver);
			if (WebDriver.ElementExists(XPODErrorMessagesby) && WebDriver.ElementExists(ProductValidationErrorMessagesby))
			{
				result = true;
			}
			return result;
		}

		public bool VerifyXPODValidationErrorMessageOnCreateQuote()
		{
			bool result = false;
			WebDriver.VerifyBusyOverlayNotDisplayed();
			DsaUtil.WaitForElement(CreateQuoteOverrideValidationMessages, WebDriver);
			if (WebDriver.ElementExists(XPODErrorMessagesby))
			{
				result = true;
			}
			return result;
		}

		public bool VerifyOnlyXPODErrorMessages()
		{
			bool result = false;
			WebDriver.VerifyBusyOverlayNotDisplayed();
			DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
			if (WebDriver.ElementExists(CreateQuoteOverrideValidationMessagesby))
			{
				IWebElement OverridableXPODerror = CreateQuoteOverrideValidationMessages.FindElement(ValidationErrorMessagesby);
				if (OverridableXPODerror.Text.ToLower().Equals("xpod status"))
				{
					result = true;
				}
			}
			else if (WebDriver.ElementExists(quoteCreate_XPOD_Validation_Messageby))
			{
				IWebElement NonOverridableXPODerror = CreateQuoteOverrideValidationMessages.FindElement(quoteCreate_XPOD_Validation_Messageby);
				if (NonOverridableXPODerror.Text.ToLower().Contains("xpod status"))
				{
					result = true;
				}
			}
			return result;
		}

		public bool VerifyOverrideButtonForValidationMessages()
		{
			bool result = false;
			IList<IWebElement> Overridebtncount = WebDriver.FindElements(OverrideButtonby);
			if (WebDriver.ElementExists(OverrideButtonby) && WebDriver.FindElement(OverrideButtonby).Displayed && Overridebtncount.Count == 1)
			{
				result = true;
			}
			return result;

		}

		public bool IsOverrideEnabled()
		{
			return !(CreateQuoteOverrideValidationMessages.FindElement(OverrideButtonby)
					.GetAttribute("class")
					.ToLower()
					  .Contains("disabled"));
		}

		public CreateQuotePage ClickOnXPODAndProductValidationOverrideButton()
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			DsaUtil.WaitForElement(CreateQuoteOverrideValidationMessages, WebDriver);
			if (IsOverrideEnabled())
			{
				DsaUtil.WaitForElement(CreateQuoteOverrideValidationMessages.FindElement(OverrideButtonby), WebDriver);
				DsaUtil.WaitUntilItsClickable(CreateQuoteOverrideValidationMessages.FindElement(OverrideButtonby),
					WebDriver);
				DsaUtil.WaitForElement(WebDriver.FindElement(OverrideValidationDialogCheckBoxby), WebDriver);
				WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
				DsaUtil.WaitUntilItsClickable(OverrideValidationDialog.FindElement(OverrideValidationDialogCheckBoxby), WebDriver);

				DsaUtil.WaitForElement(WebDriver.FindElement(OverrideValidationDialogOverrideby), WebDriver);
				DsaUtil.WaitUntilItsClickable(OverrideValidationDialog.FindElement(OverrideValidationDialogOverrideby), WebDriver);
			}

			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage OverrideAnyGenericSolutionErrors()
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			if (WebDriver.ElementExists(ApprovalNeededDailogby))
			{
				BtnNoContinueWorking.Click(WebDriver);
				WebDriver.VerifyBusyOverlayNotDisplayed();
			}
			if (WebDriver.ElementExists(CreateQuoteGSCVValidationby))
			{
				WebDriver.VerifyBusyOverlayNotDisplayed();
				IJavaScriptExecutor Js = (IJavaScriptExecutor)WebDriver;
				Js.ExecuteScript("scroll(0, -250);");
				CreateQuoteGSCVValidation.FindElement(OverrideButtonby).Click(WebDriver);
				DsaUtil.WaitForElement(GSCVValidationWarningDialog.FindElement(GSCVValidationWarningDialogYesButton),
					WebDriver);
				GSCVValidationWarningDialog.FindElement(GSCVValidationWarningDialogYesButton).Click(WebDriver);
				WebDriver.VerifyBusyOverlayNotDisplayed();
			}

			if (WebDriver.ElementExists(By.Id("_setDefaultContract")))
			{
				IWebElement DeafultContract = WebDriver.FindElement(By.Id("_setDefaultContract"));
				DeafultContract.FindElement(By.Id("_setDefaultContract_cancel")).Click(WebDriver);
			}

			if (ProductValidationErrorMessagesby_2.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
			{
				DsaUtil.WaitUntilItsClickable(WebDriver.FindElement(OverrideButtonby), WebDriver);
				DsaUtil.WaitForElement(OverrideValidationDialogCheckBoxby_2, WebDriver);
				OverrideValidationDialogCheckBoxby_2.Click(WebDriver);
				DsaUtil.WaitForElement(OverrideValidationDialogOverrideby_2, WebDriver);
				OverrideValidationDialogOverrideby_2.Click(WebDriver);
			}

			return new CreateQuotePage(WebDriver);
		}

		public bool OverrideValidationConsolidatedValidationErrorsAndCheckOverrideButtonDisabledAtEachGroup(string GroupName_ErrorMessageToVerify)
		{
			bool result = false;
			WebDriver.VerifyBusyOverlayNotDisplayed();
			if (!(CreateQuoteOverrideValidationMessages.FindElement(OverrideButtonby).GetAttribute("class").ToLower().Contains("disabled")))
			{
				DsaUtil.WaitForElement(CreateQuoteOverrideValidationMessages.FindElement(OverrideButtonby), WebDriver);
				DsaUtil.WaitUntilItsClickable(CreateQuoteOverrideValidationMessages.FindElement(OverrideButtonby),
					WebDriver);
				DsaUtil.WaitForElement(OverrideValidationDialog.FindElement(OverrideValidationDialogCheckBoxby),
					WebDriver);
				OverrideValidationDialog.FindElement(OverrideValidationDialogCheckBoxby).Click();
				DsaUtil.WaitForElement(OverrideValidationDialog.FindElement(OverrideValidationDialogOverrideby),
					WebDriver);
				OverrideValidationDialog.FindElement(OverrideValidationDialogOverrideby).Click();
				foreach (var GroupNameAndErrorMessages in GroupName_ErrorMessageToVerify.Split('|'))
				{
					string[] GroupNamesAndErrors = GroupNameAndErrorMessages.Split(',');
					DsaUtil.WaitForElement(QuoteName, WebDriver);
					string Quotename = WebDriver.ExecuteJsScript<string>("return $('#quoteCreate_quoteName').val()");
					if (Quotename.ToLower().Contains(GroupNamesAndErrors[0].ToLower()))
					{
						if (WebDriver.ElementExists(OverrideButtonby) && CreateQuoteOverrideValidationMessages.FindElement(OverrideButtonby).GetAttribute("class").ToLower().Contains("disabled"))
						{
							result = true;
						}
						else
						{
							result = false;
							break;
						}
					}
					else
					{
						DsaUtil.PickDropdownByText(LinkedQuotesListBox, WebDriver, GroupNamesAndErrors[0]);
						WebDriver.VerifyBusyOverlayNotDisplayed();
						Quotename = WebDriver.ExecuteJsScript<string>("return $('#quoteCreate_quoteName').val()");
						if (WebDriver.ElementExists(OverrideButtonby) && CreateQuoteOverrideValidationMessages.FindElement(OverrideButtonby).GetAttribute("class").ToLower().Contains("disabled"))
						{
							result = true;
						}
						else
						{
							result = false;
							break;
						}
					}

				}

			}
			return result;
		}

		public bool SelectAndVerifyOverridableErrrorsAtEachGroup_WithOverrideButton(string GroupName_ErrorMessageToVerify)
		{
			bool result = false;
			WebDriver.VerifyBusyOverlayNotDisplayed();
			IList<IWebElement> SolutionShippingGroups = LinkedQuotesListBox.FindElements(By.XPath(".//option"));
			if (SolutionShippingGroups.Count == GroupName_ErrorMessageToVerify.Split('|').Length)
			{
				foreach (var GroupNameAndErrorMessages in GroupName_ErrorMessageToVerify.Split('|'))
				{
					string[] GroupQuoteNames = GroupNameAndErrorMessages.Split(';');
					string[] GroupErrors = GroupQuoteNames[1].Split(',');
					DsaUtil.WaitForElement(QuoteName, WebDriver);
					string Quotename = WebDriver.ExecuteJsScript<string>("return $('#quoteCreate_quoteName').val()");
					if (!(Quotename.ToLower().Equals(GroupQuoteNames[0].ToLower())))
					{
						DsaUtil.PickDropdownByText(LinkedQuotesListBox, WebDriver, GroupQuoteNames[0]);
						WebDriver.VerifyBusyOverlayNotDisplayed();
						Quotename = WebDriver.ExecuteJsScript<string>("return $('#quoteCreate_quoteName').val()");
					}
					IList<IWebElement> ValidationErrors = CreateQuoteOverrideValidationMessages.FindElements(ValidationErrorMessagesby);
					if (GroupErrors.Length == ValidationErrors.Count)
					{
						for (int i = 0; i < GroupErrors.Length; i++)
						{
							if (ValidationErrors[i].Text.ToLower().Contains(GroupErrors[i].ToLower()) && WebDriver.ElementExists(OverrideButtonby) && !(BtnSaveQuote.Enabled))
							{
								result = true;
								if (TxtCustomerNumber.Displayed)
								{
									result = false;
									break;
								}
							}
							else
							{
								result = false;
								break;
							}
						}
					}
					else
					{
						result = false;
						break;
					}
				}

			}

			return result;
		}

		public bool OverrideErrorAtOneGroupAndCheckOverridebuttondisabled(string GroupName_ErrorMessageToVerify)
		{
			bool result = false;
			int i = 1;
			foreach (var GroupNameAndErrorMessages in GroupName_ErrorMessageToVerify.Split('|'))
			{
				string[] GroupQuoteNames = GroupNameAndErrorMessages.Split(';');
				string[] GroupErrors = GroupQuoteNames[1].Split(',');
				string Quotename = WebDriver.ExecuteJsScript<string>("return $('#quoteCreate_quoteName').val()");
				if (!(Quotename.ToLower().Equals(GroupQuoteNames[0].ToLower())))
				{
					DsaUtil.PickDropdownByText(LinkedQuotesListBox, WebDriver, GroupQuoteNames[0]);
					WebDriver.VerifyBusyOverlayNotDisplayed();
					Quotename = WebDriver.ExecuteJsScript<string>("return $('#quoteCreate_quoteName').val()");
				}
				if (Quotename.ToLower().Contains(GroupQuoteNames[0].ToLower()) &&
					i == GroupName_ErrorMessageToVerify.Split('|').Length)
				{
					IList<IWebElement> ValidationErrors =
						CreateQuoteOverrideValidationMessages.FindElements(ValidationErrorMessagesby);
					if (ValidationErrors[0].Text.ToLower().Contains(GroupErrors[0].ToLower()) &&
						CreateQuoteOverrideValidationMessages.ElementExists(OverrideButtonby) && !(BtnSaveQuote.Enabled))
					{
						DsaUtil.WaitForElement(CreateQuoteOverrideValidationMessages.FindElement(OverrideButtonby),
							WebDriver);
						IJavaScriptExecutor Js = (IJavaScriptExecutor)WebDriver;
						Js.ExecuteScript("scroll(0, -250);");
						CreateQuoteOverrideValidationMessages.FindElement(OverrideButtonby).Click();
						DsaUtil.WaitForElement(
							OverrideValidationDialog.FindElement(OverrideValidationDialogCheckBoxby), WebDriver);
						OverrideValidationDialog.FindElement(OverrideValidationDialogCheckBoxby).Click();
						DsaUtil.WaitForElement(
							OverrideValidationDialog.FindElement(OverrideValidationDialogOverrideby), WebDriver);
						OverrideValidationDialog.FindElement(OverrideValidationDialogOverrideby).Click();
						WebDriver.VerifyBusyOverlayNotDisplayed();
						if (
						(CreateQuoteOverrideValidationMessages.FindElement(OverrideButtonby)
							.GetAttribute("class")
							.ToLower()
							.Contains("disabled")))
						{
							result = true;
							WebDriver.VerifyBusyOverlayNotDisplayed();
						}
					}
				}
				i++;
			}
			return result;
		}

		//Save solution quote needs to override few errors (Sometimes), so making use of the below method instead of SaveQuote
		public bool SaveSolutionQuote()
		{
			BtnSaveQuote.WaitForElement(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			if (BtnSaveQuote.Enabled)
			{
				BtnSaveQuote.Click(WebDriver);
				if (CreateQuoteGSCVValidation.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
				{
					CreateQuoteGSCVValidation.FindElement(OverrideButtonby).Click();
					DsaUtil.WaitForElement(new CreateQuotePage(WebDriver).GSCVValidationWarningDialogYesButton_2, WebDriver);
					new CreateQuotePage(WebDriver).GSCVValidationWarningDialogYesButton_2.Click(WebDriver);
					WebDriver.VerifyBusyOverlayNotDisplayed();
					BtnSaveQuote.Click(WebDriver);
					WebDriver.VerifyBusyOverlayNotDisplayed();
				}
			}

			return true;

		}


		//Save solution quote needs to override few errors (Sometimes), so making use of the below method instead of SaveQuote
		public bool SaveSolutionLinkedQuote()
		{
			SaveAllLinkedQuotesButton.WaitForElement(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();

			if (SaveAllLinkedQuotesButton.Enabled)
			{
				SaveAllLinkedQuotesButton.Click(WebDriver);

				if (ProductValidationErrorMessagesby_2.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
				{
					DsaUtil.WaitUntilItsClickable(WebDriver.FindElement(OverrideButtonby), WebDriver);
					DsaUtil.WaitForElement(OverrideValidationDialogCheckBoxby_2, WebDriver);
					OverrideValidationDialogCheckBoxby_2.Click(WebDriver);
					DsaUtil.WaitForElement(OverrideValidationDialogOverrideby_2, WebDriver);
					OverrideValidationDialogOverrideby_2.Click(WebDriver);

					SaveAllLinkedQuotesButton.Click(WebDriver);
				}

				if (CreateQuoteGSCVValidation.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
				{
					CreateQuoteGSCVValidation.FindElement(OverrideButtonby).Click();
					DsaUtil.WaitForElement(new CreateQuotePage(WebDriver).GSCVValidationWarningDialogYesButton_2, WebDriver);
					new CreateQuotePage(WebDriver).GSCVValidationWarningDialogYesButton_2.Click(WebDriver);
					WebDriver.VerifyBusyOverlayNotDisplayed();
					SaveAllLinkedQuotesButton.Click(WebDriver);
					WebDriver.VerifyBusyOverlayNotDisplayed();
				}
			}

			return true;

		}
		public bool IsSFDCDealIDPresent(string SFDCDealIDFromOSC)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WaitForQuoteValidationToComplete();
			return SfdcDealIdPresnetintheTxtBox.GetAttribute("href").Contains(SFDCDealIDFromOSC);
		}

		// Apply To All Linked Quotes Check Box
		public void HandleApplyToAllQuotesChkBoxAndClickSubmit(IWebDriver driver, bool applyToAllQuotesChkBox = true)
		{
			if (!applyToAllQuotesChkBox)
			{
				ApplyToAllQuotesChkBox.UnSelectCheckBox(driver);
			}
			AddLocationSubmit.Click(driver);
		}

		#endregion

		public CreateQuotePage ClickOnEditSolutionBtn()
		{
			DsaUtil.WaitForPageLoad(WebDriver);
			BtnEditSolution.Click(WebDriver);
			BtnSwitchCatalogCustomerYes.Click(WebDriver);
			DsaUtil.WaitForPageLoad(WebDriver);

			WebDriver.WaitForElementVisible(By.XPath("//div[@class='spinnerMask']"), TimeSpan.FromSeconds(25));
			var wait = new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime);
			wait.Until<bool>(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@class='spinnerMask']")));

			return new CreateQuotePage(WebDriver);
		}

		public SolutionConfigurationPage EditSolutionBtn()
		{
			BtnEditSolution.Click(WebDriver);
			BtnSwitchCatalogCustomerYes.Click(WebDriver);
			DsaUtil.WaitForPageLoad(WebDriver);

			WebDriver.WaitForElementVisible(By.XPath("//div[@class='spinnerMask']"), TimeSpan.FromSeconds(25));
			var wait = new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime);
			wait.Until<bool>(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@class='spinnerMask']")));

			return new SolutionConfigurationPage(WebDriver);
		}

		public CreateQuotePage SelectSwitchCatalog(string strYesNo)
		{
			if (strYesNo == "Yes")
			{
				BtnSwitchCatalogCustomerYes.Click(WebDriver);
				WebDriver.WaitForBusyOverlay();
			}
			else if (strYesNo == "No")
			{
				BtnSwitchCatalogCustomerNo.Click(WebDriver);
				WebDriver.WaitForBusyOverlay();
			}
			//WebDriver.WaitForElementDisplay();
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage CloseCurrentQuote(string strYesNo)
		{
			if (strYesNo == "Yes")
			{
				BtnCloseCurrentQuoteYes.Click();
				WebDriver.WaitForBusyOverlay();
			}
			else if (strYesNo == "No")
			{
				BtnCloseCurrentQuoteNo.Click();
				WebDriver.WaitForBusyOverlay();
			}
			//WebDriver.WaitForElementDisplay();
			return new CreateQuotePage(WebDriver);
		}

		public bool VerifySwitchCatalogPopUpAppears()
		{
			bool val = false;
			if (MsgBoxTitle.GetText(WebDriver).Contains("Warning")
				//&& WebDriver.ElementExists(By.XPath("//mat-dialog-content[@class = 'mat-dialog-content']/span"))
				&& WebDriver.GetElement(By.XPath("//mat-dialog-content[@class = 'mat-dialog-content']/span"), TimeSpan.FromSeconds(2))
				.GetText(WebDriver).Contains("The current solution catalog is different from the customer's catalog"))
				val = true;

			return val;
		}

		public bool VerifySwitchCatalogErrorPopUpAppears()
		{
			bool val = false;
			//BtnSwitchCatalogCustomerYes.Click();
			if (//MsgBoxTitle.GetText(WebDriver).Contains("Change Catalog")
				// WebDriver.GetElement(By.Id("_confirm"))
					//&& WebDriver.GetElement(By.Id("mat-dialog-1"))
				 WebDriver.GetElement(By.XPath("//mat-dialog-content[@class = 'mat-dialog-content']/span"), TimeSpan.FromSeconds(2))
				.GetText(WebDriver).Contains("Change catalog failed due to below issues"))
				val = true;

			return val;
		}

		public void ContryAddNewContactCreateQuote(IWebDriver driver, DataRow row, String randomEmailAddress)
		{
			AddNewContactFirstName.SetText(driver, row["AddLocationFirstName1"].ToString(), null);
			AddNewContactLastName.SetText(driver, row["AddLocationLastName1"].ToString());
			AddNewContactMobilePhone.SetText(driver, row["AddLocationPhoneHome1"].ToString());
			AddNewContactEmail.SetText(driver, randomEmailAddress);
			AddNewContactSelectBillingAddress.Click();
			MobileDropdownAddNewContact.Click();
			CACountryCodeMobile(2).Click();

		}

		public void ContryShipToAddNewContactCreateQuote(IWebDriver driver, DataRow row, String randomEmailAddress)
		{
			AddNewContactFirstName.SetText(driver, row["AddLocationFirstName1"].ToString(), null);
			AddNewContactLastName.SetText(driver, row["AddLocationLastName1"].ToString());
			AddNewContactMobilePhone.SetText(driver, row["AddLocationPhoneHome1"].ToString());
			AddNewContactEmail.SetText(driver, randomEmailAddress);
			AddNewContactSelectShippingAddress.Click();
			MobileDropdownAddNewContact.Click();
			CACountryCodeMobile(1).Click();

		}

		public void CountryAddNewAddressCreateQuote(IWebDriver driver, DataRow row, String randomEmailAddress, String randomphonenumber)
		{
			AddLocationFirstName.SetText(driver, row["AddLocationFirstName1"].ToString(), null);
			AddLocationLastName.SetText(driver, row["AddLocationLastName1"].ToString());
			AddLocationPhoneMobile.SetText(driver, randomphonenumber);
			AddLocationEmailInvoice.SetText(driver, randomEmailAddress);
			AddLocationAddress1.SetText(driver, row["Addressline1"].ToString(), null);
			AddLocationPostalcode.SetText(driver, row["Postalcode"].ToString(), null);
			MobileDropdownAddLocation.Click();
			CACountryCodeMobile(2).Click();


		}

		public void CountryEditCreateQuote(IWebDriver driver, DataRow row, String randomEmailAddress, String randomphonenumber)
		{
			EditContactMobilePhone.Clear();
			EditContactMobilePhone.SetText(driver, randomphonenumber);
			EditContactEmail.Clear();
			EditContactEmail.SetText(driver, randomEmailAddress);
			MobileDropdownAddLocation.Click();
			CACountryCodeMobile(2).Click();
		}

		public void EditCreateQuote(IWebDriver driver, DataRow row, String randomEmailAddress)
		{
			EditContactMobilePhone.Clear();
			Console.WriteLine("phonenumber: " + row["CompanyPhone"].ToString());
			delay(1);
			EditContactMobilePhone.SetText(driver, row["EditCompanyPhone"].ToString());
			EditContactEmail.Clear();
			EditContactEmail.SetText(driver, randomEmailAddress);
		}


		public void AddNewAddressCreateQuote(IWebDriver driver, DataRow row, String randomEmailAddress, String phoneNumber)
		{
			AddLocationFirstName.SetText(driver, row["AddLocationFirstName1"].ToString(), null);
			AddLocationLastName.SetText(driver, row["AddLocationLastName1"].ToString());
			AddLocationPhoneMobile.SetText(driver, phoneNumber);
			AddLocationEmailInvoice.SetText(driver, randomEmailAddress);
			AddLocationAddress1.SetText(driver, row["Addressline1"].ToString(), null);
			AddLocationPostalcode.SetText(driver, row["Postalcode"].ToString(), null);

		}

		public void ShipAddNewContactCreateQuote(IWebDriver driver, DataRow row, String randomEmailAddress)
		{
			AddNewContactFirstName.SetText(driver, row["AddLocationFirstName1"].ToString(), null);
			AddNewContactLastName.SetText(driver, row["AddLocationLastName1"].ToString());
			AddNewContactMobilePhone.SetText(driver, row["AddLocationPhoneNumber"].ToString());
			AddNewContactEmail.SetText(driver, randomEmailAddress);
			AddNewContactSelectShippingAddress.Click();
			delay(10);

		}


		public void AddNewContactCreateQuote(IWebDriver driver, DataRow row, String randomEmailAddress, String phoneNumber)
		{
			AddNewContactFirstName.SetText(driver, row["AddLocationFirstName1"].ToString(), null);
			AddNewContactLastName.SetText(driver, row["AddLocationLastName1"].ToString());
			AddNewContactMobilePhone.SetText(driver, phoneNumber);
			AddNewContactEmail.SetText(driver, randomEmailAddress);
			AddNewContactSelectBillingAddress.Click(WebDriver);
			AddNewContactSaveButton.Click(WebDriver);

		}

		public void AddNewContactInvalidEmail(IWebDriver driver, DataRow row, String randomEmailAddress)
		{
			AddNewContactFirstName.SetText(driver, row["AddLocationFirstName1"].ToString(), null);
			AddNewContactLastName.SetText(driver, row["AddLocationLastName1"].ToString(), null);
			AddNewContactMobilePhone.SetText(driver, row["AddLocationPhoneHome1"].ToString(), null);
			AddNewContactEmail.SetText(driver, randomEmailAddress, null);

		}

		public void AddNewContactInvalidPhone(IWebDriver driver, DataRow row, String randomphonenumber)
		{
			AddNewContactFirstName.SetText(driver, row["AddLocationFirstName1"].ToString(), null);
			AddNewContactLastName.SetText(driver, row["AddLocationLastName1"].ToString(), null);
			AddNewContactMobilePhone.SetText(driver, randomphonenumber, null);
			AddNewContactEmail.SetText(driver, row["AddLocationEmailInvoice1"].ToString(), null);
		}

		public void AddNewAddressInvalidEmail(IWebDriver driver, DataRow row, String randomemailaddress)
		{
			InstallAtAddressLine_1.SetText(driver, row["AddLocationAddress1"].ToString(), null);
			InstallAtAddressZipCode.SetText(driver, row["AddLocationZipcode1"].ToString(), null);
			InstallAtAddressFirstName.SetText(driver, row["AddLocationFirstName1"].ToString(), null);
			InstallAtAddressLastName.SetText(driver, row["AddLocationLastName1"].ToString(), null);
			InstallAtAddressEmail.SetText(driver, randomemailaddress, null);
			InstallAtAddressPhone.SetText(driver, row["AddLocationPhoneNumber"].ToString(), null);
		}

		public void AddNewAddressInvalidPhone(IWebDriver driver, DataRow row, String randomphonenumber)
		{
			InstallAtAddressLine_1.SetText(driver, row["AddLocationAddress1"].ToString(), null);
			InstallAtAddressZipCode.SetText(driver, row["AddLocationZipcode1"].ToString(), null);
			InstallAtAddressFirstName.SetText(driver, row["AddLocationFirstName1"].ToString(), null);
			InstallAtAddressLastName.SetText(driver, row["AddLocationLastName1"].ToString(), null);
			InstallAtAddressEmail.SetText(driver, row["InvoicingEmail"].ToString(), null);
			InstallAtAddressPhone.SetText(driver, randomphonenumber, null);

		}

		public void SoldAddNewContactInvalidEmail(IWebDriver driver, DataRow row, String randomEmailAddress)
		{
			AddNewContactFirstName.SetText(driver, row["AddLocationFirstName1"].ToString(), null);
			AddNewContactLastName.SetText(driver, row["AddLocationLastName1"].ToString(), null);
			AddNewContactMobilePhone.SetText(driver, row["AddLocationPhoneHome1"].ToString(), null);
			AddNewContactEmail.SetText(driver, randomEmailAddress, null);
			AddNewContactSelectBillingAddress.Click(WebDriver);

		}
		public void SoldAddNewContactInvalidPhone(IWebDriver driver, DataRow row, String randomphonenumber)
		{
			AddNewContactFirstName.SetText(driver, row["AddLocationFirstName1"].ToString(), null);
			AddNewContactLastName.SetText(driver, row["AddLocationLastName1"].ToString(), null);
			AddNewContactMobilePhone.SetText(driver, randomphonenumber, null);
			AddNewContactEmail.SetText(driver, row["AddLocationEmailInvoice1"].ToString(), null);
			AddNewContactSelectBillingAddress.Click(WebDriver);

		}


		public QuoteDetailsPage SaveAndSplitQuote()
		{
			SaveAsOrderEnable.WaitForElement(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			SaveAsOrderEnable.Click(WebDriver);

			if (SaveAndSplitButton.Enabled)
			{
				SaveAndSplitButton.Click(WebDriver);

				if (CreateQuoteGSCVValidation.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
				{
					CreateQuoteGSCVValidation.FindElement(OverrideButtonby).Click();
					DsaUtil.WaitForElement(new CreateQuotePage(WebDriver).GSCVValidationWarningDialogYesButton_2, WebDriver);
					new CreateQuotePage(WebDriver).GSCVValidationWarningDialogYesButton_2.Click(WebDriver);
					WebDriver.VerifyBusyOverlayNotDisplayed();
					SaveAllLinkedQuotesButton.Click(WebDriver);
					WebDriver.VerifyBusyOverlayNotDisplayed();
				}
			}
			return new QuoteDetailsPage(WebDriver);
		}

		public PCFQuoteSummaryPage OverrideGscvValidation()
		{
			OpenQA.Selenium.Interactions.Actions actions = new OpenQA.Selenium.Interactions.Actions(WebDriver);
			actions.MoveToElement(BtnOverrideGscvValidate).Build().Perform();
			BtnOverrideGscvValidate.Click(WebDriver);
			BtnGscvValidationWarningYes.Click(WebDriver);
			BtnSaveQuote.Click(WebDriver);
			return new PCFQuoteSummaryPage(WebDriver);

		}

		public PCFQuoteSummaryPage OverrideGscvValidationForLinkedQuotes()
		{
			BtnOverrideGscvValidate.Click(WebDriver);
			BtnGscvValidationWarningYes.Click(WebDriver);
			SaveAllLinkedQuotesButton.Click(WebDriver);
			return new PCFQuoteSummaryPage(WebDriver);
		}

		public void CreateInstallAtNewAddressMultipleShipping(IWebDriver Webdriver, DataRow row, string randomLetters)
		{

			InstallAtAddressLine_1.SetText(Webdriver, row["AddressLine"].ToString() + randomLetters, null);
			InstallAtAddressZipCode.SetText(Webdriver, row["ZipCode"].ToString(), null);
			InstallAtAddressFirstName.SetText(Webdriver, row["FirstName"].ToString(), null);
			InstallAtAddressLastName.SetText(Webdriver, row["LastName"].ToString() + randomLetters, null);
			InstallAtAddressEmail.SetText(Webdriver, row["ValidEmailAddress"].ToString(), null);
			InstallAtAddressPhone.SetText(Webdriver, row["MobilePhone"].ToString(), null);

			BtnSubmit.Click(Webdriver);
			if (IsAvsVisible())
			{
				SelectOriginalAddressFromAvsPopup();
			}
			Webdriver.VerifyBusyOverlayNotDisplayed();
		}

		// Install At Customer
		public void CreateInstallAtCustomer(IWebDriver Webdriver, DataRow row, string randomLetters)
		{
			CompanyName.SetText(Webdriver, row["CompanyName"].ToString(), null);
			CompanyPhone.SetText(Webdriver, row["CompanyPhone"].ToString(), null);
			FirstName.SetText(Webdriver, row["FirstName"].ToString(), null);
			LastName.SetText(Webdriver, row["LastName"].ToString() + randomLetters, null);
			InvoicingEmail.SetText(Webdriver, row["InvoicingEmail"].ToString(), null);
			MobilePhone.SetText(Webdriver, row["MobilePhone"].ToString(), null);
			AddressLine_1.SetText(Webdriver, row["AddressLine_1"].ToString() + randomLetters, null);
			ZipCode.SetText(Webdriver, row["ZipCode"].ToString(), null);
			if (EmailOverride.IsElementDisplayed(WebDriver))
			{
				EmailOverride.Click(WebDriver);
			}
			else
			{
				//Do nothing
			}
			BtnSave.Click();
			if (IsAvsVisible())
			{
				SelectOriginalAddressFromAvsPopup();
			}
			if (CreateThisNewCustomer.IsElementDisplayed(Webdriver))
			{
				CreateThisNewCustomer.Click();
			}
			else
			{
				// do nothing
			}
			Webdriver.VerifyBusyOverlayNotDisplayed();
		}


		// Install At New Address
		public void CreateInstallAtNewAddress(IWebDriver Webdriver, DataRow row, string randomLetters)
		{

			InstallAtAddressLine_1.SetText(Webdriver, row["AddressLine"].ToString() + randomLetters, null);
			InstallAtAddressZipCode.SetText(Webdriver, row["ZipCode"].ToString(), null);
			InstallAtAddressFirstName.SetText(Webdriver, row["FirstName"].ToString(), null);
			InstallAtAddressLastName.SetText(Webdriver, row["LastName"].ToString() + randomLetters, null);
			InstallAtAddressEmail.SetText(Webdriver, row["InvoicingEmail"].ToString(), null);
			InstallAtAddressPhone.SetText(Webdriver, row["MobilePhone"].ToString(), null);
			if (EmailOverride.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5)))
			{
				EmailOverride.Click(WebDriver);
			}
			else
			{
				//Do Nothing
			}
			UnCheckApplyAllInstallAtShippingGroups(WebDriver);

			BtnSubmit.Click(Webdriver);
			delay(10);
			if (IsAvsVisible())
			{
				SelectOriginalAddressFromAvsPopup();
			}
			Webdriver.VerifyBusyOverlayNotDisplayed();
		}

		public void UnCheckApplyAllInstallAtShippingGroups(IWebDriver Webdriver)
		{
			if (ChckApplyAllInstallAt.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
			{
				WebDriverUtil.ScrollIntoElement(Webdriver, ChckApplyAllInstallAt);
				ChckApplyAllInstallAt.Click();
				WebDriverUtil.WaitForBusyOverlay(Webdriver);
			}
			else
			{
				// do nothing
			}
		}

		public void DTCPAddNewAddressCreateQuote(IWebDriver driver, DataRow row, String randomAddressLine1)
		{
			AddLocationFirstName.SetText(driver, row["AddLocationFirstName"].ToString(), null);
			AddLocationLastName.SetText(driver, row["AddLocationLastName"].ToString());
			AddLocationEmailInvoice.SetText(driver, row["AddInvoicingEmail"].ToString());
			AddLocationPhoneMobile.SetText(driver, row["AddMobilePhone"].ToString());
			if (PhoneOverride.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5)))
			{
				PhoneOverride.Click(WebDriver);
			}
			else
			{
				//Do nothing
			}
			
			AddLocationAddress1.SetText(driver, randomAddressLine1);			
			AddLocationPostalcode.SetText(driver, row["Postalcode"].ToString(), null);
			if(AddLocationCity.GetText(WebDriver, TimeSpan.FromSeconds(5)).Equals(" "))
			{
				AddLocationCity.SendKeys("Paris");
			}
			else
			{
				//do nothing
			}
					
			BtnSubmit.Click(WebDriver);

		}



		public void AddAddressFromLocation(IWebDriver driver, DataRow row, int number, string randomLetters, bool clkSubmitBtn = true)
		{
			AddLocationAddress1.SetText(driver, number.ToString(), null);
			// AddLocationCity.SetText(driver, row["AddLocationCity1"].ToString(), null);
			//  AddLocationSelectState.PickDropdownByText(driver, row["AddLocationSelectState1"].ToString());
			AddLocationZipcode.SetText(driver, row["AddLocationZipcode1"].ToString(), null);
			AddLocationSelectTitle.PickDropdownByText(driver, row["AddLocationSelectTitle1"].ToString());
			AddLocationFirstName.SetText(driver, row["AddLocationFirstName1"].ToString() + randomLetters, null);
			AddLocationLastName.SetText(driver, row["AddLocationLastName1"].ToString(), null);
			AddLocationEmailInvoice.SetText(driver, row["AddLocationEmailInvoice1"].ToString(), null);
			AddLocationPhoneMobile.SetText(driver, row["AddLocationPhoneHome1"].ToString(), null);
			if (EmailOverride.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)))
			{
				EmailOverride.Click(webDriver);
			}
			else
			{
				//Do nothing
			}

			if (!clkSubmitBtn)
				return; //do not click sumbit button - used for clicking apply to all scenarios
			WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
			wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("AddLocationDialog_submit")));
			AddLocationSubmit.Click();
			delay(20);

			if (IsAvsVisible() == true)
			{
				UseOriginalAddress.Click();
				ConfirmYesBtn.Click();
			}
			driver.VerifyBusyOverlayNotDisplayed();
		}



		public void EditContact(IWebDriver driver, Contact location, bool clkSubmitBtn = true)
		{
			//Set fields
			EditContactMobilePhone.SetText(driver, location.PhoneMobile, null);
			EditContactEmail.SetText(driver, location.EmailInvoice, null);

			if (!clkSubmitBtn)
				return;
			EditContactSubmitBtn.Click(driver);
		}

		public CreateQuotePage EditContactInfo(IWebDriver Webdriver, Contact location)
		{
			//Set fields
			EditContactMobilePhone.Clear();
			EditContactMobilePhone.SetText(Webdriver, location.PhoneMobile);
			if (PhoneOverride.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5)))
			{
				PhoneOverride.Click(WebDriver);
			}
			else
			{
				//Do nothing
			}
			EditContactEmail.Clear();
			EditContactEmail.SetText(Webdriver, location.EmailInvoice);
			if (EmailOverride.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5)))
			{
				EmailOverride.Click(WebDriver);
			}
			else
			{
				//Do nothing
			}
			EditContactSubmitBtn.Enabled.Should().BeTrue();
			EditContactSubmitBtn.Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}


		public void EditAddressesAndValidateEmail(string randomemail, bool clkSubmitBtn = true)
		{
			//Set fields


			EditContactEmail.SendKeys("~ | : ; < {],> Dave_@_}");
			//validate here// 

			EditContactEmail.IsElementDisplayed(WebDriver);
			Logger.Write("Must use the format name@domain.tld");
			EditContactEmail.Clear();
			EditContactEmail.SetText(WebDriver, randomemail);
			EditContactSubmitBtn.Click(WebDriver);
			//EditContactMobilePhone.SetText(driver, location.PhoneMobile, null);

			//EditContactEmail.SetText(driver, location.EmailInvoice, null);

			if (!clkSubmitBtn)
				return;
			EditContactSubmitBtn.Click(WebDriver);
		}

		public void HandleApplyToAllItemsChkBoxAndClickSubmit(IWebDriver driver, bool applyToAllItemsChkBox = true)
		{
			if (!applyToAllItemsChkBox)
			{
				ChkAllShippingGrp.UnSelectCheckBox(driver);
			}
			AddLocationSubmit.Click(driver);
		}

		public IWebElement ShippingNewAddressLinks(int index)
		{
			ReadOnlyCollection<IWebElement> shippingElements =
				WebDriver.FindElements(By.Id("quoteCreate_shippingNewAddressLink"));
			return shippingElements.ElementAt(index);

		}

		public void NeedPricingErrorVerification(bool IntroducePricingError = false)
		{
			if (IntroducePricingError)
				UpdateDiscountOffList(2, "55");
		}

		public bool CheckForDfsSoftCreditCheck()
		{
			//bool found = WebDriver.TryFindElement(LblDfsStatus, new TimeSpan(900));
			bool found = LblDfsStatus.WaitForElement(WebDriver);
			return found;
		}
		public IWebElement DFSStatus => new WebDriverWait(WebDriver, TimeSpan.FromSeconds(90)).Until(ExpectedConditions.ElementIsVisible(By.Id("quoteCreate_dfsStatus")));

		public List<Dictionary<string, object>> GetAddressTable()
		{
			AddressesTable.WaitForElement(WebDriver);
			return AddressesTable.GetTableData(WebDriver);
		}

		public List<Dictionary<string, object>> GetAddressTableInstallAtAddress(String tabText)
		{
			AddressesTable.WaitForElementDisplayed(TimeSpan.FromSeconds(30));
			SelectAddressTab(tabText).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WebDriver.WaitForElementDisplayed(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']//thead//tr//th[3]//span"), TimeSpan.FromSeconds(30));

			if (DisplayItemsPerPage.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(60)))
			{
				DisplayItemsPerPage.PickDropdownByText(WebDriver, "40 per page");
				WebDriver.WaitForElementDisplayed(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']//thead//tr//th[3]//span"), TimeSpan.FromSeconds(60));
				WebDriver.VerifyBusyOverlayNotDisplayed();
			}
			else
			{
				// do nothing
			}
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return AddressesTable.GetTableData(WebDriver);
		}

		public IWebElement GetSelectButtonSoldTo(int index)
		{
			ReadOnlyCollection<IWebElement> selectButtons =
			WebDriver.FindElements(By.XPath("//*[text()='Billing']/following::a[contains(text(),'Select')]"));
			return selectButtons.ElementAt(index);
		}

		public CreateQuotePage SelectAndPatchAgreementId()
		{
			int index = 0;
			var agreementTable = GetBillPlanAgreementsTable();
			foreach (var agreement in agreementTable)
			{
				var selectBtn = GetSelectButtonFromAgreementsTable(index);
				if (agreement["Agreement ID"].ToString().Length.Equals(7) && selectBtn.Enabled)
				{
					selectBtn.Click(WebDriver);
					WebDriver.VerifyBusyOverlayNotDisplayed();
					break;
				}
				index++;
			}
			return new CreateQuotePage(WebDriver);
		}

		public List<Dictionary<string, object>> GetBillPlanAgreementsTable()
		{
			BillPlanAgreements.WaitForElement(WebDriver);
			return BillPlanAgreements.GetTableData(WebDriver);
		}

		public IWebElement GetSelectButtonFromAgreementsTable(int index)
		{
			ReadOnlyCollection<IWebElement> selectButtons =
			WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_serviceAccount_grid']//td//button[contains(text(),'Select')]"));
			return selectButtons.ElementAt(index);
		}

		public IWebElement GetSelectButtonFromAddressTableInstallAt(int index)
		{
			ReadOnlyCollection<IWebElement> selectButtons =
			WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']//tr//a[contains(text(),'Select')]"));
			return selectButtons.ElementAt(index);
		}



		public IWebElement GetSelectButtonFromAddressTable(int index = 1)
		{
			ReadOnlyCollection<IWebElement> selectButtons =
			WebDriver.FindElements(By.XPath("//*[text()='Shipping']/following::a[contains(text(),'Select')]"));
			return selectButtons.ElementAt(index);
		}

		public void AddShippingAddress(IWebDriver driver, DataRow row, int number)
		{
			AddShippingAddressCompName.SetText(driver, row["AddShippingCompanyName"].ToString());
			AddShippingAddressFirstName.SetText(driver, row["AddShippingFirstName"].ToString());
			AddShippingAddressLastName.SetText(driver, row["AddShippingLastName"].ToString());
			AddShippingAddressEmail.SetText(driver, row["AddShippingEmail"].ToString());
			AddShippingAddressLine1.SetText(driver, number.ToString());
			AddShippingAddressCity.SetText(driver, row["AddShippingCity"].ToString());
			AddShippingAddressState.PickDropdownByText(driver, row["AddShippingState"].ToString());
			AddShippingAddressZipCode.SetText(driver, row["AddShippingZipCode"].ToString());
			AddShippingAddressZipExtension.SetText(driver, row["AddShippingZipExtension"].ToString());
			AddShippingAddressPrimaryPhone.SetText(driver, row["AddShippingPrimaryPhone"].ToString());

			AddShippingAddressSaveBtn.Click(driver);
			VerifiedAddressesRadioBtn.Click(driver);
			SuggestedAddressSelect.Click(driver);
		}

		public void AddNewShipToInvalidEmail(IWebDriver driver, DataRow row, String randomemailaddress)
		{
			AddNewShipToCompName.SetText(driver, row["AddShippingCompanyName"].ToString());
			AddNewShipToCompPhone.SetText(driver, row["AddShippingPrimaryPhone"].ToString());
			AddNewShipToFirstName.SetText(driver, row["AddShippingFirstName"].ToString());
			AddNewShipToLastName.SetText(driver, row["AddShippingLastName"].ToString());
			AddNewShipToInvoicingEmail.SetText(driver, randomemailaddress);
			AddNewShipToMobilePhone.SetText(driver, row["AddShippingPrimaryPhone"].ToString());
			AddNewShipToAddressLine1.SetText(driver, row["AddShippingAddLine1"].ToString());
			AddNewShipToZipCode.SetText(driver, row["AddShippingZipCode"].ToString());
		}

		public void AddNewShipToInvalidPhoneNumber(IWebDriver driver, DataRow row, String randomphonenumber)
		{
			AddNewShipToCompName.SetText(driver, row["AddShippingCompanyName"].ToString());
			AddNewShipToCompPhone.SetText(driver, row["AddShippingPrimaryPhone"].ToString());
			AddNewShipToFirstName.SetText(driver, row["AddShippingFirstName"].ToString());
			AddNewShipToLastName.SetText(driver, row["AddShippingLastName"].ToString());
			AddNewShipToInvoicingEmail.SetText(driver, row["AddShippingEmail"].ToString());
			AddNewShipToMobilePhone.SetText(driver, randomphonenumber);
			AddNewShipToAddressLine1.SetText(driver, row["AddShippingAddLine1"].ToString());
			AddNewShipToZipCode.SetText(driver, row["AddShippingZipCode"].ToString());
		}

		public void AddNewShipToCustomer(IWebDriver driver, DataRow row)
		{
			AddNewShipToCompName.SetText(driver, row["AddShippingCompanyName"].ToString());
			AddNewShipToCompPhone.SetText(driver, row["AddShippingPrimaryPhone"].ToString());
			AddNewShipToFirstName.SetText(driver, row["AddShippingFirstName"].ToString());
			AddNewShipToLastName.SetText(driver, row["AddShippingLastName"].ToString());
			AddNewShipToInvoicingEmail.SetText(driver, row["AddShippingEmail"].ToString());
			AddNewShipToMobilePhone.SetText(driver, row["AddShippingPrimaryPhone"].ToString());
			AddNewShipToAddressLine1.SetText(driver, row["AddShippingAddLine1"].ToString());
			AddNewShipToZipCode.SetText(driver, row["AddShippingZipCode"].ToString());
			AddNewShipToSaveBtn.Click();

			// Choose Original Address
			if (IsAvsVisible())
			{
				SelectOriginalAddressFromAvsPopup();
				if (CreateThisNewCustomer.IsElementDisplayed(WebDriver))
				{
					CreateThisNewCustomer.Click();
				}
			}
			WebDriver.VerifyBusyOverlayNotDisplayed();
		}


		public bool SelectAndVerifyShippingInstructionsForShipingMethod(string shippingMethodsToSelect,
			string Shippinginstructionsmessageatshippingmethod, string Shippinginstructionsmessageatheader)
		{
			bool result = false;

			string[] Shippingmethods = shippingMethodsToSelect.Split('|');
			for (int i = 0; i < Shippingmethods.Length; i++)
			{
				DsaUtil.PickDropdownByText(LinkedQuotesListBox, WebDriver, Shippingmethods[i]);
				if (
					ShippingInstructionsMessageAtShippingMethod.Text.ToLower()
						.Equals(Shippinginstructionsmessageatshippingmethod.ToLower()) &&
					ShippingInstructionsMessageAtHeader.Text.ToLower()
						.Equals(Shippinginstructionsmessageatheader.ToLower()))
				{
					result = true;
				}
				else
				{
					result = false;
					break;
				}
			}

			return result;
		}

		public PCFComplianceNotificationsPage SaveAsOrder(bool continueWithCustomerSalesRep = true)
		{
			BtnSaveQuoteToggle.Click(WebDriver);
			BtnSaveAsOrder.Click(WebDriver);
			WebDriver.PCFVerifyBusyOverlayNotDisplayed();

			/*if (!WebDriver.Url.Contains("quote/saveasorder"))
			{

				bool bfound = BtnCreateOderUsingDefaultSalesRep.IsElementClickable(WebDriver, TimeSpan.FromSeconds(10));
				if (bfound)
				{
					BtnCreateOderUsingDefaultSalesRep.Click(WebDriver);
				}
			} */  //update this when salesrep mismatch popup shows up
			return new PCFComplianceNotificationsPage(WebDriver);
		}

		public void ValidateCustomerNumberPatch()
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			currCustomerHeaderlink.WaitForElementDisplayed(TimeSpan.FromMinutes(2));
			bool result = currCustomerHeaderlink.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(40));
			if (result)
				//Logger.Write("Customer number patch is successful");
				Log.Info("Customer number patch is successful");
			else
			{
				//Logger.Write("Customer number patch is failed");
				Log.Error("Customer number patch is failed");
				throw new NoSuchElementException();

			}
		}

		// Add Solution Name for Install At
		public CreateQuotePage SolutionNameInstallAt(String solutionName, IWebElement element)
		{
			try
			{
				element.Clear();
				element.SetText(WebDriver, solutionName);
				element.SendKeys(Keys.Tab);
			}
			catch (StaleElementReferenceException)
			{
				WebDriver.VerifyBusyOverlayNotDisplayed();
			}
			return new CreateQuotePage(WebDriver);
		}

		// Remove Solution name for Install At
		public CreateQuotePage RemoveSolutionNameInstallAt(int index)
		{
			SolutionNameTxt(index).SendKeys(Keys.Control + "a");
			SolutionNameTxt(index).SendKeys(Keys.Backspace);
			SolutionNameTxt(index).SendKeys(Keys.Tab);
			BtnConfirmRemoveSolution.Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return new CreateQuotePage(WebDriver);
		}

		// click Solution Upgrade and add service tag
		public CreateQuotePage ClickSolutionUpgrade_Add_and_ValidateAddServiceTag(IWebElement upgradeType, String serviceTagName)
		{
			upgradeType.Click(WebDriver);
			SolutionUpgradeTxt.SetText(WebDriver, serviceTagName);

			WebDriver.VerifyBusyOverlayNotDisplayed();
			Assert.AreNotEqual("", SolutionNameTxt(0).GetText(WebDriver));// to check solution name texbox is not empty
																		  // SearchForExistingAddress(0).IsElementDisplayed(WebDriver).Should().Contain(false);// to check searchExistingAddrees not to be shown this is to validate installAtaddress is displaying
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage SolutionUpgradeWithUpgradeType(IWebElement upgradeType, String assetNumber)
		{
			upgradeType.Click(WebDriver);
			SolutionUpgradeTxt.SetText(WebDriver, assetNumber);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage ClickOnSolutionUpgradeBtn()
		{
			UpgradeSolution.Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage SolutionUpgradeWithDtcpExpansion()
		{
			UpgradeTypeAgreementId.Click(WebDriver);
			HelpMeFindAgreementIdLnk.Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			SelectBillPlanBtn.Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage SolutionUpgradeWithRequestOptOut(string optOutReason)
		{
			AposRequestOptOutDropDown.PickDropdownByValue(WebDriver, optOutReason);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage DtcpExpansionUpdateCustomer()
		{
			BtnApplyAll.Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage RemoveUpgradeFromQuote()
		{
			int attempt = 0;
			while (attempt < 2)
			{
				try
				{
					RemoveUpgrade.Click(WebDriver);
					WebDriver.VerifyBusyOverlayNotDisplayed();
					break;
				}
				catch (StaleElementReferenceException)
				{

				}
				attempt++;
			}
			return new CreateQuotePage(WebDriver);
		}

		public void ApplyParentToAll()
		{
			ApplyAsParentToAll.Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
		}

		public void RemoveFromAll()
		{
			RemoveServiceTagFromAll.Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
		}

		public CreateQuotePage PatchGTPID(String gtpID, IWebElement element)
		{
			try
			{
				element.Clear();
				element.SetText(WebDriver, gtpID);
				element.SendKeys(Keys.Tab);
			}
			catch (StaleElementReferenceException)
			{
				WebDriver.VerifyBusyOverlayNotDisplayed();
			}
			return new CreateQuotePage(WebDriver);
		}

		public int AddressLinePoboxvalidation(string line, string address, int status)
		{

			if (line == AddressLine.Line1.ToString())
			{
				AddShippingAddressLine1.SendKeys(address);
				AddShippingAddressLine1.SendKeys(Keys.Tab);

				WebDriver.IsElementVisible(POboxValidationMsg);
				try
				{
					if (WebDriver.IsElementVisible(POboxValidationMsg))
						Logger.Write(address + "is validated");

				}
				catch (NoSuchElementException e)
				{
					Logger.Write(address + "is not validated");
					status++;
				}


				AddShippingAddressLine1.Clear();
				AddShippingAddressLine1.SendKeys(Keys.Tab);
			}
			else if (line == AddressLine.Line2.ToString())
			{
				AddShippingAddressLine2.SendKeys(address);
				AddShippingAddressLine2.SendKeys(Keys.Tab);
				//Thread.Sleep(1000);
				try
				{
					if (WebDriver.IsElementVisible(POboxValidationMsg))
						Logger.Write(address + "is validated");

				}
				catch (NoSuchElementException e)
				{
					Logger.Write(address + "is not validated");
					status++;
				}
				AddShippingAddressLine2.Clear();
				AddShippingAddressLine2.SendKeys(Keys.Tab);
			}
			return status;
		}

		public bool Verifyemailaddress()
		{
			return SAOemailvalidationmsg.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10));
		}

		public bool Verifyphonenumber()
		{
			return SAOphonenumbervalidationmsg.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10));
		}

		public void closeAddressPopup()
		{
			closeAddresspopup.Click(WebDriver);
		}
		public CreateQuotePage ClickICodeOverride()
		{

			if (ICodeOverrideChkBox.IsElementClickable(WebDriver, TimeSpan.FromSeconds(5)))
				ICodeOverrideChkBox.SelectCheckBox(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public void WaitForQuoteValidationToComplete()
		{
			while (WebDriver.TryFindElement(ImgValidatingQuoteBusyIndicator, TimeSpan.FromSeconds(60)))
			{
				// Do Nothing
			}
		}

		public CreateQuotePage ClickCustomerFinanceInformation()
		{
			LnkCustomerFinancialInformationToggle.Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage ClickCurrentCustomer()
		{
			LnkCurrentCustomerCustomerName.Click(WebDriver);
			return this;
		}

		public CreateQuotePage SelectPaymentMethod(string paymentMethod)
		{
			DdlQuoteCreateFinancialPaymentMethod.PickDropdownByText(WebDriver, paymentMethod);
			return this;
		}
		public String DefaultPaymentMethod()
		{
			String paymentMethod = DdlQuoteCreateFinancialPaymentMethod.GetText(WebDriver);
			paymentMethod = paymentMethod.Replace(" ", "");
			return paymentMethod;
		}
		
		public bool CheckIfPaymentMethodExists(string paymentMethod)
		{
			var isExist = false;
			var options = new SelectElement(DdlQuoteCreateFinancialPaymentMethod).Options;
			isExist = options.Any(elem => elem.Text.ToLower() == paymentMethod.ToLower());

			return isExist;
		}
		public CreateQuotePage ExpandinstallationInstruction()
		{
			ExpandInstallationInstruction.Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public OrderDetailsPage EnterInstallationInstructions(string installationInstruction)
		{

			var previousText = TxtInstallationInstruction.GetAttribute("Value");
			//TxtInstallationInstruction.Clear();
			TxtInstallationInstruction.SendKeys(previousText + "," + installationInstruction);
			WebDriver.WaitForPageLoad();
			return new OrderDetailsPage(WebDriver);
		}

		public bool IsAvsVisible()
		{
			return AddressSuggestionPopup.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(30));
		}

		public void SelectOriginalAddressFromAvsPopup()
		{
			UseOriginalAddress.Click(WebDriver);
			ConfirmYesBtn.Click(WebDriver);
		}
		public string GetGroupLevelShippingPrice(int? groupIndex = 0)
		{
			return TxtGroupLevelShippingPrice(groupIndex).GetText(WebDriver);
		}
		public string GetGroupLevelShippingDiscount(int? groupIndex = 0)
		{
			return TxtGroupLevelShippingDiscount(groupIndex).GetText(WebDriver);
		}

		public int GetNumberofShippingGroups()
		{
			WebDriverWait driverWait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(20));
			driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h4[contains(@id,'_group_')]")));
			delay(8);
			ReadOnlyCollection<IWebElement> shippingGroups = WebDriver.FindElements(By.XPath("//h4[contains(@id,'_group_')]"));
			return shippingGroups.Count;
		}
		public string GetContractValidationMessage()
		{
			return ContractValidationMessage.GetText(WebDriver);
		}
		public CreateQuotePage ValidateEnteredDpid(string dpid)
		{
			LinkedDpid.SetText(WebDriver, dpid);
			WebDriver.WaitForPageLoad();
			return new CreateQuotePage(WebDriver);
		}

		public string GetValidationMessage()
		{
			string msg = ValidationMessage.GetText(WebDriver);
			return msg;
		}
		public string GetPaymentTerms()
		{
			string msg = "";
			try
			{
				msg = PaymentTerms.GetText(WebDriver, TimeSpan.FromSeconds(30), waitForTextChange: false);
			}
			catch
			{
				return "";
			}
			return msg;
		}

		//This method is used to add new contact to Bill To, Sold To and Ship To
		//Customer Type arguement should be passed as 'BillTo', 'SoldTo', 'ShipTo
		public void AddNewContact(IWebDriver driver, DataRow row, String CustomerType, String Emailaddress)
		{
			AddNewContactFirstName.SetText(driver, row["AddLocationFirstName1"].ToString(), null);
			AddNewContactLastName.SetText(driver, row["AddLocationLastName1"].ToString());
			AddNewContactMobilePhone.SetText(driver, row["AddLocationPhoneHome1"].ToString());
			AddNewContactEmail.SetText(driver, Emailaddress);
			if (CustomerType.ToString() == "BillTo")
			{
				AddNewContactSelectBillingAddress.Click();
			}
			else if (CustomerType == "SoldTo")
			{
				AddNewContactSelectBillingAddress.Click();
			}
			else if (CustomerType == "ShipTo")
			{
				AddNewContactSelectShippingAddress.Click();
			}
			else if (CustomerType == "InstallAtAddress")
			{
				AddNewContactSelectShippingAddress.Click();
			}
			AddNewContactSaveButton.Click();
		}

		public CreateQuotePage GetAllOptionsFromDropDown(IWebElement element, int count)
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
			return new CreateQuotePage(WebDriver);
		}

		/*
         * mabd needs to be format "mm/dd/yyyy"  =>  "01/04/2018" => please include zero 01, 02, 03....
         * 
         * mabd will return straight away when clicked
         * 
         * method will throw timeout exception is madb is not found after approx 3 minutes
         *
         * This will include dates up until around 2040
         * 
         * Any Date After 2040 will throw timeout exception // with 3 minutes defeult timeout */
		// *  
		public void SelectMABD(string mabd)
		{
			string[] digits = mabd.Split('/');
			string month = digits[0];
			string day = digits[1];
			string year = digits[2];
			string monthYear;

			Dictionary<string, string> months = new Dictionary<string, string>();
			months.Add("01", "January");
			months.Add("02", "February");
			months.Add("03", "March");
			months.Add("04", "April");
			months.Add("05", "May");
			months.Add("06", "June");
			months.Add("07", "July");
			months.Add("08", "August");
			months.Add("09", "September");
			months.Add("10", "October");
			months.Add("11", "November");
			months.Add("12", "December");

			monthYear = months[month] + " " + year;

			Func<string, bool> isMonthYear = x =>
			{
				if (x.Equals(monthYear))
				{
					CalendarMABDday(day).Click(WebDriver);
					return true;
				}
				else
				{
					return false;
				}
			};

			if (RetryUntilSuccessOrTimeout(isMonthYear, TimeSpan.FromSeconds(180)))
			{
				Logger.Write("MADB Has Successfully Been Entered");
			}
			else
			{
				Logger.Write("mabd was not found it timed out");
				throw new TimeoutException("mabd was not found it timed out");
			}
		}



		/*
        * mabd needs to be format "mm/dd/yyyy"  =>  "01/04/2018" => please include zero 01, 02, 03....
        * 
        * mabd will return straight away when clicked
        * 
        * method will throw timeout exception is madb is not found after approx 3 minutes
        *
        * This will include dates up until around 2040
        * 
        * Any Date After 2040 will throw timeout exception // with 3 minutes defeult timeout */

		public bool RetryUntilSuccessOrTimeout(Func<string, bool> isMonthYear, TimeSpan timeSpan)
		{
			string monthYear = MonthMABDcalendar.GetText(WebDriver);
			bool success = false;
			int elapsed = 0;

			success = isMonthYear(monthYear);
			while ((!success) && (elapsed < timeSpan.TotalMilliseconds))
			{
				elapsed += 1000;
				GoRightMABDcalendar.Click(WebDriver);
				monthYear = MonthMABDcalendar.GetText(WebDriver);
				success = isMonthYear(monthYear);
			}

			return success;
		}


		public void WaitForBusyIndicatorAppearAndDisappear()
		{
			WebDriver.WaitForElementVisible(By.XPath("//*[@id='busy-indicator']"), TimeSpan.FromSeconds(25));
			var wait = new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime);
			wait.Until<bool>(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='busy-indicator']")));
		}


		public List<string> GetNotificationMessages()
		{
			List<string> NotificationMessages = new List<string>();
			if (CreateQuoteValidationMessages.Displayed)
			{
				//var allnotification = WebDriver.GetElements(By.XPath("//quote-create-header-notification//div[@class='ng-star-inserted']"));
				var allnotification = WebDriver.GetElements(By.XPath("//quote-create-header-notification/div"));
				foreach (var notification in allnotification)
				{
					NotificationMessages.Add(notification.Text);
				}
			}

			return NotificationMessages;
		}

		public string GetShippingMethodErrorNotification()
		{
			return ShippingErrorNotif.GetText(WebDriver);
		}


		public List<string> GetNotificationMessagesItemLevel(int groupIndex, int itemIndex)
		{
			List<string> NotificationMessages = new List<string>();
			if (CreateQuoteValidationMessages.Displayed)
			{
				//var allnotification = WebDriver.GetElements(By.XPath(String.Format("//*[@id='quoteCreate_item_notifications_{0}_{1}']/span", groupIndex - 1, itemIndex - 1)));
				var allnotification = WebDriver.GetElements(By.XPath(String.Format("//*[@id='quoteCreate_item_validations_{0}_{1}']", groupIndex - 1, itemIndex - 1)));
				foreach (var notification in allnotification)
				{
					NotificationMessages.Add(notification.Text);
				}
			}

			return NotificationMessages;
		}

		#region ManualTaxCalculation
		public void GetManualTaxStatus(String ManualPending)
		{
			SGTotalTaxPending.GetText(WebDriver).Contains(ManualPending);
			SGEcoFeePending.GetText(WebDriver).Contains(ManualPending);
			SGTotalAmountPending.GetText(WebDriver).Contains(ManualPending);
			SummaryTotalTaxtPending.GetText(WebDriver).Contains(ManualPending);
			SummaryEcoFeePending.GetText(WebDriver).Contains(ManualPending);
			SummaryTotalAmountPending.GetText(WebDriver).Contains(ManualPending);

			Logger.Write("Shipping and summary amount are comes as pending");
			SummaryCalculateTaxButton.IsElementDisplayed(WebDriver).Should().BeTrue();
			SummaryCalculateTaxButton.IsElementClickable(WebDriver).Should().BeTrue();
			SummaryCalculateTaxButton.Click(WebDriver);
			Logger.Write("Calculate tax button displayed and checked amount is displayed");

			SGTotalTaxPending.GetText(WebDriver).Should().NotContain(ManualPending);
			SGEcoFeePending.GetText(WebDriver).Should().NotContain(ManualPending);
			SGTotalAmountPending.GetText(WebDriver).Should().NotContain(ManualPending);
			SummaryTotalTaxtPending.GetText(WebDriver).Should().NotContain(ManualPending);
			SummaryEcoFeePending.GetText(WebDriver).Should().NotContain(ManualPending);
			SummaryTotalAmountPending.GetText(WebDriver).Should().NotContain(ManualPending);

			SummaryCalculateTaxButton.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)).Should().BeFalse();
		}

		#endregion

		#region EOLNotifications
		public int Get_countof_EOL_notifications(string EOLString)
		{
			string[] notifications = CreateQuoteValidationMessages.Text.Split('\n');
			var notificationsCnt = 0;
			foreach (var notification in notifications)
			{
				if (notification.Contains(EOLString))
					notificationsCnt++;
			}
			return notificationsCnt;
		}
		#endregion

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public bool IsDfsDetailsLinkDisplayed()
		{
			// Click on Bill to financial information
			LnkCustomerFinancialInformationToggle.Click(WebDriver);
			bool isFound = LnkDfsDetails.WaitForElement(WebDriver);
			return isFound;
		}




		public string GetTLAErrormessage(int index)
		{

			WebDriver.GetElements(By.XPath("//*[@id='_LI_contractCode_index']/div/div/p"));
			return Errormessagetla(index).GetText(WebDriver);
		}
		public IWebElement Errormessagetla(int lineItemIndex = 1)
		{
			var lstwebelements = WebDriver.GetElements(By.XPath("//*[contains(@id,'_LI_contractCode')]/div/div/p"), TimeSpan.FromSeconds(10));

			if (lstwebelements != null && lstwebelements.Count > 0)
			{
				return lstwebelements[lineItemIndex - 1];
			}
			return null;
		}
		public string ApplyTlaItemsvaluestxt(int itemIndex)
		{
			return LnkItemLevelTLAtextbox(itemIndex).GetText(WebDriver);


		}

		public CreateQuotePage ApplyTlaItems(int itemIndex, string value = "")
		{
			LnkItemLevelTLAtextbox(itemIndex).SetText(WebDriver, value, TimeSpan.FromSeconds(10));
			WebDriver.GetElements(By.XPath("//*[contains(@id,'_LI_tla_input_1')]"));
			return new CreateQuotePage(WebDriver);
		}

		public IWebElement LnkItemLevelTLAtextbox(int lineItemIndex = 1)
		{
			var lstwebelements = WebDriver.GetElements(By.XPath("//*[contains(@id,'_LI_tla_input_1')]"), TimeSpan.FromSeconds(10));

			if (lstwebelements != null && lstwebelements.Count > 0)
			{
				return lstwebelements[lineItemIndex - 1];
			}
			return null;
		}

		public bool VerifyOEILinkDisplayed()
		{
			bool OEILink = false;
			foreach (var notification in ItemNotifications)
			{
				if (notification.Text.Contains("Order Entry Instructions"))
				{
					OEILink = true;
				}
			}
			return OEILink;
		}

		public bool ClickOeiLink()
		{
			foreach (var notification in ItemNotifications)
			{
				if (notification.Text.Contains("Order Entry Instructions"))
				{
					var handlewindow = WebDriver.WindowHandles.Count;
					var clickhere = notification.FindElement(By.XPath("//a[contains(text(),'Click Here')]"));
					if (clickhere.IsElementClickable(WebDriver))
					{
						WebDriver.JavaScriptClick(clickhere);
						WebDriver.VerifyBusyOverlayNotDisplayed();
						if (handlewindow < WebDriver.WindowHandles.Count)
						{
							return true;
						}
						return false;
					}
					return false;
				}
			}
			return false;
		}

		public bool CheckQuoteExpiration(string expirationDate)
		{
			string ExpirationDate = TxtQuoteExpirationDate.GetText(webDriver);  
			var date = DateTime.Parse(ExpirationDate).ToString("MM/dd/yyyy");
			//ExpirationDate.
			if (date == expirationDate)
				return true;
			return false;
		}

		public IWebElement GetPromotionByDesc(string promotionName)
		{
			string promotionxpath = "//a[contains(text()," + "'" + promotionName + "'" + ")]";
			return
				WebDriver.GetElement(By.XPath(promotionxpath));
		}

		public int GetNumberofItems(IWebDriver webdriver)
		{
			WebDriverUtil.ScrollIntoElement(webdriver, NumberofItems);
			string Items = NumberofItems.Text;
			Items = Regex.Match(Items, @"\d+").Value;
			int totalItems = Int32.Parse(Items);
			return totalItems;
		}

		/// <summary>
		/// Deselects the Promotion check Box
		/// </summary>
		/// <param name="webdriver"></param>
		/// <param name="promotionCheckBox"></param>
		public void UncheckPromoCode(IWebDriver webdriver, IWebElement promotionCheckBox)
		{
			WebDriverUtil.ScrollIntoElement(webdriver, promotionCheckBox);
			promotionCheckBox.Click();
			WebDriverUtil.WaitForBusyOverlay(webdriver);
		}

		public IWebElement ProductQuantity(string itemIndex)
		{
			IWebElement ele = WebDriver.GetElement(By.XPath(string.Format("//input[@id = 'quoteCreate_LI_quantity_0_{0}']", itemIndex)), TimeSpan.FromSeconds(3));
			return ele;
		}

		public IWebElement UnitSellingPriceElement(string itemIndex)
		{
			return WebDriver.GetElement(By.XPath(string.Format("//input[@id = 'quoteCreate_LI_unitSellingPrice_0_{0}']", itemIndex)), TimeSpan.FromSeconds(3));
		}

		public IWebElement ListPriceLabelElement(string itemIndex)
		{
			return WebDriver.GetElement(By.XPath(string.Format("//div[@id = 'quoteCreate_LI_totalListPrice_0_{0}']", itemIndex)), TimeSpan.FromSeconds(3));
		}

		public IWebElement DiscountTextBoxElement(string itemIndex)
		{
			return WebDriver.GetElement(By.XPath(string.Format("//input[@id = 'quoteCreate_LI_dolPercentage_0_{0}']", itemIndex)), TimeSpan.FromSeconds(3));
		}

		public IWebElement TotalSellingPriceEle(string itemIndex)
		{
			return WebDriver.GetElement(By.XPath(string.Format("//div[@id = 'quoteCreate_LI_pricingTotals_sellingPrice_0_{0}']", itemIndex)), TimeSpan.FromSeconds(3));
		}

		public IWebElement UnitListPriceElement(string itemIndex)
		{
			return WebDriver.GetElement(By.XPath(string.Format("//div[@id = 'quoteCreate_LI_PI_unitPrice_0_{0}']", itemIndex)), TimeSpan.FromSeconds(3));
		}

		public IWebElement ItemInfoMessages(int shippingGroup = 1, int itemIndex = 1)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_accordion_" + (shippingGroup - 1) + "_" + (itemIndex - 1) + "']//following-sibling::div[contains(@class, 'alert-info')]"));
		}
		public IWebElement ItemContractPaymentTermMessages(int shippingGroup = 1, int itemIndex = 1)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_LI_contractCode_input_" + (shippingGroup) + "_" + (itemIndex) + "']//..//following-sibling::div[2]/div/div]"));
		}
		public IWebElement RsidRemoveItemYesOrNo(int YesNoButtonIndex = 1, int shippingGroup = 1, int itemIndex = 1)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_accordion_" + (shippingGroup - 1) + "_" + (itemIndex - 1) + "']//following-sibling::div[contains(@class, 'alert-info')]//a[" + YesNoButtonIndex + "]"));
		}
		public IWebElement GroupoInfoMessages(int shippingGroup = 1)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_groupAccordion_" + (shippingGroup - 1) + "']//following-sibling::div[contains(@class, 'alert-info')]"));
		}
		public IWebElement RsidRemoveGroupYesOrNo(int YesNoButtonIndex = 1, int shippingGroup = 1)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_groupAccordion_" + (shippingGroup - 1) + "']//following-sibling::div[contains(@class, 'alert-info')]//a[" + YesNoButtonIndex + "]"));
		}

		/// <summary>
		/// Methods checks if Quantity*Price entered is mathcing the Unit Price, Also verifies Discounts applied correctly
		/// </summary>
		/// <param name="driver"></param>
		/// <param name="quatity"></param>
		/// <param name="discountPercent"></param>
		/// <param name="itemIndex"></param>
		/// <returns></returns>
		public bool UpdateQuantityDiscountsValidatePrice(IWebDriver driver, string quatity, string discountPercent, string itemIndex = "0")
		{
			bool isConversionSucessfull = false;

			Logger.Write("Get Current Quantity");
			IWebElement productQuantity = ProductQuantity(itemIndex);
			productQuantity.Click();
			DsaUtil.SetTextForSolution(productQuantity, driver, quatity, TimeSpan.FromSeconds(3));
			WebDriverUtil.VerifyBusyOverlayNotDisplayed(driver);

			int currentQuantityInt = int.Parse(quatity);

			Logger.Write("Get Current Unit Selling Price");
			IWebElement unitSellingPriceEle = UnitSellingPriceElement(itemIndex);
			string currentUnitSellingPrice = unitSellingPriceEle.GetAttribute("value");
			int initialUnitSellingPriceInt = int.Parse(currentUnitSellingPrice);

			Logger.Write("Get Total List Price * Quantity");
			IWebElement listPriceLabelEle = ListPriceLabelElement(itemIndex);
			string listPrice = listPriceLabelEle.Text;
			listPrice = Regex.Match(listPrice, @"\d+").Value;
			int totalListPriceInt = int.Parse(listPrice);

			if (totalListPriceInt == initialUnitSellingPriceInt * currentQuantityInt)
			{
				Logger.Write("The Quantity multiple of Unit Price is correct");
				isConversionSucessfull = true;
			}

			Logger.Write("Calculate Discounts");
			IWebElement discountEle = DiscountTextBoxElement(itemIndex);
			//discountEle.Click();
			DsaUtil.SetTextForSolution(discountEle, driver, discountPercent, TimeSpan.FromSeconds(3));
			WebDriverUtil.VerifyBusyOverlayNotDisplayed(driver);
			IWebElement discountElement = DiscountTextBoxElement(itemIndex);
			WebDriverUtil.StalenessOfElement(WebDriver, discountElement, TimeSpan.FromSeconds(5));

			string currentDiscount = discountElement.GetAttribute("value");

			if (int.Parse(discountPercent) == 0)
			{
				currentUnitSellingPrice = UnitSellingPriceElement(itemIndex).GetAttribute("value");
				isConversionSucessfull = initialUnitSellingPriceInt.Equals(int.Parse(currentUnitSellingPrice));
			}
			else
			{
				discountEle = DiscountTextBoxElement(itemIndex);
				WebDriverUtil.StalenessOfElement(driver, discountEle, TimeSpan.FromSeconds(5));
				WebDriverUtil.WaitForElementDisplay(driver, discountEle);

				DsaUtil.SetTextForSolution(discountEle, driver, discountPercent, TimeSpan.FromSeconds(5));

				WebDriverUtil.VerifyBusyOverlayNotDisplayed(driver);
				currentDiscount = discountEle.GetAttribute("value");
				decimal currentDiscountInt = decimal.Parse(currentDiscount);

				Logger.Write("Get original Unit List Price");
				IWebElement UnitListPriceEle = UnitListPriceElement(itemIndex);

				//UnitListPriceEle.Click();
				string unitListPrice = UnitListPriceEle.Text;
				unitListPrice = Regex.Match(unitListPrice, @"\d+").Value;
				decimal unitListPriceInt = decimal.Parse(unitListPrice);

				Logger.Write("Get Discounted Price from the Total Selling Price");
				decimal discountedPrice = unitListPriceInt - unitListPriceInt * decimal.Parse(discountPercent) / 100;
				currentUnitSellingPrice = UnitSellingPriceElement(itemIndex).GetAttribute("value");
				decimal currentUnitSellingPriceInt = decimal.Parse(currentUnitSellingPrice);

				if (discountedPrice == currentUnitSellingPriceInt)
				{
					Logger.Write("Discount has been applied correctly");
					isConversionSucessfull = true;
				}
				else
				{
					Logger.Write("Discount has not been applied correctly");
					isConversionSucessfull = false;
				}


				Logger.Write("Get Total Selling Price");
				IWebElement totalSellingPriceEle = TotalSellingPriceEle(itemIndex);
				string totalPrice = totalSellingPriceEle.Text.Trim();
				totalPrice = Regex.Match(totalPrice, @"\d+(\.\d+)?").Value;
				decimal totalPriceInt = decimal.Parse(totalPrice);

				currentUnitSellingPrice = UnitSellingPriceElement(itemIndex).GetAttribute("value");
				currentUnitSellingPriceInt = decimal.Parse(currentUnitSellingPrice);

				if (totalPriceInt == currentUnitSellingPriceInt * currentQuantityInt)
				{
					Logger.Write("The Discounts and Quantity has been applied Correctly");
					isConversionSucessfull = true;
				}
				else
				{
					Logger.Write("The Discounts and Quantity has not been applied Correctly");
					isConversionSucessfull = false;
				}

			}
			return isConversionSucessfull;
		}

		public int GetOpportunityLineItemsCount()
		{
			return TblOppList.GetElements(WebDriver, By.XPath(".//input")).Count;
		}

		public void ConnectToOpportunityItem(string OppLineitemName)
		{
			ConnToOppLineRadiobutton(OppLineitemName).Click(WebDriver);
			BtnConnToOppConnect.Click(WebDriver);
		}

		public void SelectLangugage(SelectAction selectLanguage)
		{

			switch (selectLanguage)
			{
				case SelectAction.SelectEnglish:
					LnkAsEnglish.Click(WebDriver);
					break;
				case SelectAction.SelectFrench:
					LnkAsFrench.Click(WebDriver);
					break;

				default:
					Logger.Write("Improper Selection");
					break;
			}
		}

		public IWebElement GetGroupAddressElement(string groupAddress)
		{
			return WebDriver.FindElement(By.XPath($"//div[@id = 'cdk-overlay-5']//table//tbody/tr/td[text() = '{groupAddress}']"));
		}

		public void VerifyTenandIdDomainGroupAddress(IWebDriver driver, string groupAddress)
		{
			//div[@id = 'cdk-overlay-5']//table//tbody/tr/td[text() = 'Shipping Group1 - Precision 7920 XL Tower']
		}

		public IWebElement ConfigDiscountValue(int index1, int index2)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='quoteCreate_LI_dolPercentage_0_" + index1 + "_" + index2 + "']"));
		}

		public IWebElement QuoteNonTiedListPrice(int index1, int index2)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='2_totalListPrice_0_" + index1 + "_" + index2 + "']"));
			//*[@id="2_totalListPrice_0_2_0"]
		}

		public void UpdateConfigDiscountValue(string discountvalue)
		{
			//Set discounts field
			ConfigDiscountValue(2, 0).IsElementDisplayed(WebDriver);
			ConfigDiscountValue(2, 0).Click(WebDriver);
			ConfigDiscountValue(2, 0).Clear();
			ConfigDiscountValue(2, 0).SetText(WebDriver, discountvalue);
			ConfigDiscountValue(2, 0).SendKeys(Keys.Tab);
			return;

		}


		#region VP Elements
		public IWebElement ItemLevelserviceListPriceLabel(int lineItemIndex = 1, int groupIndex = 1)
		{

			return WebDriver.GetElement(By.XPath("//*[@id='" + pagePrefix + "_LI_totalListPrice_serviceListPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"), TimeSpan.FromSeconds(10));
		}

		public IWebElement ByLblItemLevelserviceListPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_totalListPrice_serviceListPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement ItemLevelnonServiceListPriceLabel(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + pagePrefix + "_LI_totalListPrice__nonServiceListPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"), TimeSpan.FromSeconds(10));
		}

		public IWebElement ByLblItemLevelnonServiceListPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_totalListPrice__nonServiceListPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement ItemLevelserviceSellingPriceLabel(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + pagePrefix + "_LI_pricingInformation_serviceSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"), TimeSpan.FromSeconds(10));
		}

		public IWebElement ByLblItemLevelserviceSellingPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_pricingInformation_serviceSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement ItemLevelnonServiceSellingPriceLabel(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + pagePrefix + "_LI_pricingInformation_nonServiceSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"), TimeSpan.FromSeconds(10));
		}

		public IWebElement ByLblItemLevelnonServiceSellingPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(pagePrefix + "_LI_pricingInformation_nonServiceSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public ItemQuoteData GetVPLineItemValues(int groupIndex = 1, int itemIndex = 1, bool contractCodeRequired = false)
		{
			Logger.Write("Getting VP Values for Item " + itemIndex + " in Shipping Group " + groupIndex);
			Logger.Write("-------------------------");

			var itemQuoteData = new ItemQuoteData
			{
				SupportServiceListPrice = Convert.ToDouble(ByLblItemLevelserviceListPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				HardwareOsListPrice = Convert.ToDouble(ByLblItemLevelnonServiceListPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				SupportServiceSellingPrice = Convert.ToDouble(ByLblItemLevelserviceSellingPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				HardwareOsSellingPrice = Convert.ToDouble(ByLblItemLevelnonServiceSellingPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1))
			};

			return itemQuoteData;
		}


		public bool IsserviceListpriceLebelVisible()
		{
			if (ItemLevelserviceListPriceLabel() != null)
			{
				if (ItemLevelserviceListPriceLabel().GetText(WebDriver).Contains("Support & Services List Price"))
					return true;
			}
			return false;
		}
		public bool IshardwareListpriceLebelVisible()
		{
			if (ItemLevelnonServiceListPriceLabel() != null)
			{
				if (ItemLevelnonServiceListPriceLabel().GetText(WebDriver).Contains("Hardware & OS List Price"))
					return true;
			}
			return false;
		}
		public bool IsserviceSellingtpriceLebelVisible()
		{
			if (ItemLevelserviceSellingPriceLabel() != null)
			{
				if (ItemLevelserviceSellingPriceLabel().GetText(WebDriver).Contains("Support & Services Selling Price"))
					return true;
			}
			return false;
		}
		public bool IshardwareSellingpriceLebelVisible()
		{
			if (ItemLevelnonServiceSellingPriceLabel() != null)
			{
				if (ItemLevelnonServiceSellingPriceLabel().GetText(WebDriver).Contains("Hardware & OS Selling Price"))
					return true;
			}
			return false;
		}

		public bool IsVPParametersDisplayed()
		{
			if (IsserviceListpriceLebelVisible() && IshardwareListpriceLebelVisible() && IsserviceSellingtpriceLebelVisible() && IshardwareSellingpriceLebelVisible())
			{
				return true;
			}
			return false;
		}

		#endregion

		public void SearchForExistingInstallAtAddress(string tabText, bool isComplexQuote = false, bool sameShippingAddress = true)
		{
			int index = 0;
			string customerName = String.Empty;

			if (isComplexQuote == true)
			{
				new QuoteFooter(WebDriver, "quoteDetail").ShippingGroupInfo(0).Click();
				SearchForExistingAddress(0).WaitForElementDisplayed(TimeSpan.FromSeconds(50));
			}

			var shippingAddress = QuoteShippingGroup1Install.GetText(WebDriver, null).Split('\r')[6].Trim();
			SearchForExistingAddress(0).Displayed.Should().BeTrue();
			var ucid = QuoteShippingGroup1Install.GetText(WebDriver, null).Split('\r')[5].Trim();
			SearchForExistingAddress(0).Click();
			WebDriver.VerifyBusyOverlayNotDisplayed();

			// Pick an address from the existing AddressTable
			var addressTable = GetAddressTableInstallAtAddress(tabText);
			delay(20);

			if (!sameShippingAddress)
			{
				foreach (var address in addressTable)
				{
					if (address["UCID"].ToString() != "-")
					{
						GetSelectButtonFromAddressTableInstallAt(index).Click();
						customerName = address["Name"].ToString();
						break;
					}

					index++;
				}
			}
			else
			{
				foreach (var address in addressTable)
				{
					if (shippingAddress.ToString().Equals(address["Name"]))
					{
						GetSelectButtonFromAddressTableInstallAt(index).Click();
						customerName = address["Name"].ToString();
						break;
					}

					index++;
				}
			}

			WebDriver.VerifyBusyOverlayNotDisplayed();
			int attempt = 0;
			while (attempt < 2)
			{
				try
				{
					// Verify the address is patched
					InstallAtAddressInfo(0).Displayed.Should().BeTrue();
					var a = InstallAtAddressInfo(0).GetText(webDriver);

					if (sameShippingAddress)
					{
						InstallAtAddressInfo(0)
								   .GetText(WebDriver).Split('\r')[2].Trim().Should().BeEquivalentTo(customerName);
					}
					break;
				}
				catch (StaleElementReferenceException)
				{

				}
				attempt++;
			}

		}

		public void PatchInstallAtAddressFromAddressTable(string tabText, int shippingNameIndex, bool isComplexQuote = false)
		{
			int index = 0;
			string customerName = String.Empty;

			if (isComplexQuote == true)
			{
				new QuoteFooter(WebDriver, "quoteDetail").ShippingGroupInfo(0).Click(WebDriver);
				SearchForExistingAddress(0).WaitForElementDisplayed(TimeSpan.FromSeconds(50));
			}

			var shippingAddress = QuoteShippingGroup1Install.GetText(WebDriver, null).Split('\r')[shippingNameIndex].Trim();
			SearchForExistingAddress(0).Displayed.Should().BeTrue();
			SearchForExistingAddress(0).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();

			// Pick an address from the existing AddressTable
			var addressTable = GetAddressTableInstallAtAddress(tabText);
			foreach (var address in addressTable)
			{
				if (shippingAddress.ToString().Equals(address["Name"]))
				{
					GetSelectButtonFromAddressTableInstallAt(index).Click(WebDriver);
					WebDriver.VerifyBusyOverlayNotDisplayed();
					customerName = address["Name"].ToString();
					break;
				}
				index++;
			}

			WebDriver.VerifyBusyOverlayNotDisplayed();
			int attempt = 0;
			while (attempt < 2)
			{
				try
				{
					// Verify the address is patched
					InstallAtAddressInfo(0).Displayed.Should().BeTrue();
					InstallAtAddressInfo(0)
								   .GetText(WebDriver).Split('\r')[2].Trim().Should().BeEquivalentTo(customerName);
					break;
				}
				catch (StaleElementReferenceException)
				{

				}
				attempt++;
			}

		}

		public void UpgradeQuotePatchExistingInstallAtAddress(IWebDriver WebDriver, string tabText, string installAtCustomerName)
		{
			int index = 0;
			string customerName = String.Empty;

			WebDriver.WaitForElementDisplay(upgradeQuoteSearchExistingInstallAtAddress, TimeSpan.FromSeconds(30));
			upgradeQuoteSearchExistingInstallAtAddress.Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();

			// Pick an address from the existing AddressTable
			var addressTable = GetAddressTableInstallAtAddress(tabText);
			foreach (var address in addressTable)
			{
				if (installAtCustomerName.ToString().Equals(address["Name"]))
				{
					GetSelectButtonFromAddressTableInstallAt(index).Click(WebDriver);
					customerName = address["Name"].ToString();
					break;
				}
				index++;
			}

			WebDriver.VerifyBusyOverlayNotDisplayed();
			int attempt = 0;
			while (attempt < 2)
			{
				try
				{
					// Verify the address is patched
					InstallAtAddressInfo(0).Displayed.Should().BeTrue();
					InstallAtAddressInfo(0)
								   .GetText(WebDriver).Split('\r')[2].Trim().Should().BeEquivalentTo(customerName);
					break;
				}
				catch (StaleElementReferenceException)
				{

				}
				attempt++;
			}

		}

		public void InstallAtAddressChange(int Index, string tabText)
		{
			int index = 0;
			string customerName = String.Empty;

			var shippingAddress = ShippingGroup1InstallAt.GetText(WebDriver, null).Split('\r')[6].Trim();
			InstallAtChangeAddress(Index).Displayed.Should().BeTrue();
			InstallAtChangeAddress(Index).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();

			// Pick an address from the existing AddressTable
			var addressTable = GetAddressTableInstallAtAddress(tabText);
			foreach (var address in addressTable)
			{

				if (!shippingAddress.ToString().Equals(address["Name"]))
				{
					GetSelectButtonFromAddressTableInstallAt(index).Click();
					delay(10);
					break;
				}
				index++;
			}

		}

		public void ChangeInstallAtAddress(int Index, string tabText)
		{
			int index = 0;
			string customerName = String.Empty;

			var shippingAddress = QuoteShippingGroup1Install.GetText(WebDriver, null).Split('\r')[6].Trim();
			InstallAtChangeAddress(Index).Displayed.Should().BeTrue();
			InstallAtChangeAddress(Index).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();

			// Pick an address from the existing AddressTable
			var addressTable = GetAddressTableInstallAtAddress(tabText);
			foreach (var address in addressTable)
			{

				if (shippingAddress.ToString().Equals(address["Name"]))
				{
					GetSelectButtonFromAddressTableInstallAt(index).Click();
					customerName = address["Name"].ToString();
					break;
				}
				index++;
			}

			// Verify the address is patched
			WebDriver.VerifyBusyOverlayNotDisplayed();
			delay(20);
			InstallAtAddressInfo(0).Displayed.Should().BeTrue();
			InstallAtAddressInfo(0)
						   .GetText(WebDriver).Split('\r')[2].Trim().Should().BeEquivalentTo(customerName);
		}

		public void ChangeInstallAtAddressNonCoIP(int Index, String tabText)
		{
			int index = 0;
			string customerName = String.Empty;

			var shippingAddress = QuoteShippingGroup1Install.GetText(WebDriver, null).Split('\r')[6].Trim();
			InstallAtChangeAddress(Index).Displayed.Should().BeTrue();
			InstallAtChangeAddress(Index).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();

			// Pick an address from the existing AddressTable
			var addressTable = GetAddressTableInstallAtAddress(tabText);
			foreach (var address in addressTable)
			{
				if (shippingAddress.ToString().Equals(address["Name"]))
				{
					GetSelectButtonFromAddressTableInstallAt(index).Click();
					customerName = address["Name"].ToString();
					break;
				}
				index++;
			}

			// Verify the address is patched
			WebDriver.VerifyBusyOverlayNotDisplayed();
			delay(20);
			InstallAtAddressInfo(0).Displayed.Should().BeTrue();
			InstallAtAddressInfo(0)
						   .GetText(WebDriver).Split('\r')[2].Trim().Should().Should().BeEquivalentTo(customerName);

		}
		public void SearchForExistingInstallAtNonCoIP(int Index, String tabText)
		{
			int index = 0;
			string customerName = String.Empty;

			var shippingAddress = QuoteShippingGroup1Install.GetText(WebDriver, null).Split('\r')[5].Trim();
			SearchForExistingAddress(Index).Displayed.Should().BeTrue();
			SearchForExistingAddress(Index).Click();
			WebDriver.VerifyBusyOverlayNotDisplayed();

			// Pick an address from the existing AddressTable
			var addressTable = GetAddressTableInstallAtAddress(tabText);
			foreach (var address in addressTable)
			{
				if (shippingAddress.ToString().Equals(address["Name"]))
				{
					GetSelectButtonFromAddressTableInstallAt(index).Click();
					customerName = address["Name"].ToString();
					break;
				}
				index++;
			}

			// Verify the address is patched
			WebDriver.VerifyBusyOverlayNotDisplayed();
			delay(20);
			InstallAtAddressInfo(0).Displayed.Should().BeTrue();
			InstallAtAddressInfo(0)
						   .GetText(WebDriver).Split('\r')[1].Trim().Should().BeEquivalentTo(customerName);
		}

		public void SelectExistingAddressWithShippingType(String shippingType, int Index, String tabText)
		{
			int index = 0;
			string customerName = String.Empty;

			var shippingAddress = QuoteShippingGroup1Install.GetText(WebDriver, null).Split('\r')[6].Trim();
			SearchForExistingAddress(Index).Displayed.Should().BeTrue();
			SearchForExistingAddress(Index).Click();
			WebDriver.VerifyBusyOverlayNotDisplayed();
			if (ChkAllShippingGrp.Displayed)
			{
				ChkAllShippingGrp.UnSelectCheckBox(WebDriver);
			}
			else
			{
				// do nothing
			}

			// Pick an address from the existing AddressTable
			var addressTable = GetAddressTableInstallAtAddress(tabText);
			foreach (var address in addressTable)
			{
				if (shippingAddress.ToString().Equals(address["Name"]) && shippingType.ToString().Equals(address["Type"]))
				{
					GetSelectButtonFromAddressTableInstallAt(index).Click(WebDriver);
					customerName = address["Name"].ToString();
					break;
				}
				index++;
			}

			// Verify the address is patched
			WebDriver.VerifyBusyOverlayNotDisplayed();
			InstallAtAddressInfo(0).Displayed.Should().BeTrue();
			InstallAtAddressInfo(0).GetText(WebDriver).Split('\r')[2].Trim().Should().BeEquivalentTo(customerName);
		}

		public void SearchForEMEAExistingInstallAtAddr(IWebDriver WebDriver, string SolutionName)
		{
			int index = 0;

			SolutionNameInputField.SetText(WebDriver, SolutionName);
			//SearchForExistingAddress(SolutionName);
			new QuoteFooter(WebDriver, "Quote Page").ShippingGroupInfo(0).Click(webDriver);
			SearchForExistingAddress(0).WaitForElementDisplayed(TimeSpan.FromSeconds(50));

			SearchForExistingAddress(0).Click();
			WebDriver.VerifyBusyOverlayNotDisplayed();

			// Pick an address from the existing AddressTable			
			var addressTable = new CreateQuotePage(webDriver).GetAddressTable();

			foreach (var address in addressTable)
			{
				if (address["UCID"].ToString() != "-")
				{
					GetSelectButtonFromAddressTableInstallAt(index).Click(webDriver);
					break;
				}

				index++;

			}

		}

		public int GetShippingGroupCount()
		{
			return WebDriver.GetElements(By.XPath("//div[contains(@id,'" + pagePrefix + "_groupAccordion_')]")).Count;
		}

		public int GetShippingLevelServicetagGroupCount(int shippingGroup = 1)
		{
			return WebDriver.GetElements(By.XPath("//div[contains(@id,'quoteCreate_accordion_" + (shippingGroup - 1) + "')]")).Count;
		}

		public CreateQuotePage ClickAddLocationSubmitBtn()
		{
			AddLocationSubmit.Click(WebDriver);
			if (IsAvsVisible())
			{
				SelectOriginalAddressFromAvsPopup();
			}
			return new CreateQuotePage(WebDriver);
		}

		public void SelectDropDownValue(string input)
		{
			WebDriver.FindElement(By.XPath($"((//div[@name = 'countryCode'])[2]//following::ul/li[contains(text(), '{input}')])[2]")).Click();

		}

		public bool IsLanguageDropDown()
		{
			throw new NotImplementedException();
		}

		public List<Dictionary<string, object>> GetChangeAddressTable()
		{
			ChangeAddressTable.WaitForElement(WebDriver);
			if (DisplayItemsPerPage.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
			{
				DisplayItemsPerPage.PickDropdownByText(WebDriver, "40 per page");
				WebDriver.VerifyBusyOverlayNotDisplayed();
			}
			else
			{
				// do nothing
			}
			return AddressesTable.GetTableData(WebDriver);
		}

		public IWebElement GroupLevelUCID(int? Index)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[" + Index + "]/td[14]"));
		}



		public IWebElement UCIDResilts { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr/td[14]")); } }


		public IWebElement UCIDNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[1]")); } }

		public IWebElement GetUCIDInformation()//(int lineItemIndex = 0)
		{
			var lstwebelements = WebDriver.GetElements(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr/td[14]"), TimeSpan.FromSeconds(10));
			//if (lstwebelements != null && lstwebelements.Count >= 0)
			//{
			//    return lstwebelements[lineItemIndex + 1];
			//}
			return null;
			//return WebDriver.GetElements(By.XPath("//*[@id='DataTables_Table_gridChangeAddress']/tbody/tr[" + Index + "]/td[14]"), TimeSpan.FromSeconds(2)).GetText(WebDriver);
		}

		public IWebElement RSIdNumberOnItemLevel(int groupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_LI_productRsId_" + (groupIndex - 1) + "_" + (itemIndex - 1)));
		}

		public IWebElement RSIdNumberOnGroupLevel()
		{
			return WebDriver.GetElement(By.Id("quoteCreate_LI_productRsId"));
		}

		public IWebElement DTCPSubscriptionPricePerNode(int itemIndex = 1)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_LI_CS_configInfo_optionDuration_" + itemIndex));
		}

		public CreateQuotePage DTCPSetSubscriptionPricePerNode(int itemIndex, string priceValue)
		{
			DTCPSubscriptionPricePerNode(itemIndex).Clear();
			DTCPSubscriptionPricePerNode(itemIndex).SendKeys(priceValue + Keys.Tab);
			return new CreateQuotePage(WebDriver);
		}

		public IWebElement DTCPSummaryDiscountPercent()
		{
			return WebDriver.GetElement(By.Id("quoteCreate_summary_discountPercent"));
		}
		public bool DTCPCalculateDiscount(string discountPercent)
		{
			string SummarydiscPert = DTCPSummaryDiscountPercent().GetText(webDriver);
			if (SummarydiscPert.Contains(discountPercent))
				return true;
			else
				return false;
		}


		public IWebElement DTCPEsad()
		{
			return WebDriver.GetElement(By.Id("quoteCreate_LI_ESAD_Maximum_0_0"));
		}

		public string DTCPGetEsad()
		{
			return DTCPEsad().GetText(webDriver);
		}

		public IWebElement DTCPPromotionPercentageElement()
		{
			return WebDriver.GetElement(By.Id("quoteCreate_LI_PI_promotionsPercentage_0_0"));
		}

		public string DTCPPromotionPercentage()
		{
			return DTCPPromotionPercentageElement().GetText(WebDriver);
		}


		public bool DTCPCheckUnitSellingPriceNotEditable()
		{
			IWebElement unitSellingPrice = UnitSellingPriceElement("0");
			string read_only = unitSellingPrice.GetAttribute("readonly");
			try
			{
				Assert.IsNotNull(read_only);
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool DTCPCheckDiscountTextBoxNotEditable()
		{
			IWebElement discountTextBox = DiscountTextBoxElement("0");
			string read_only = discountTextBox.GetAttribute("readonly");
			try
			{
				Assert.IsNotNull(read_only);
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool DTCPSetSubscriptionPricePerNodeIsEditable()
		{
			IWebElement subscriptionPricePerNode = DTCPSubscriptionPricePerNode(1);
			string read_only = subscriptionPricePerNode.GetAttribute("readonly");
			try
			{
				Assert.IsNotNull(read_only);
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool DTCPIsCustomModeNotAvailable()
		{
			try
			{
				IWebElement element = WebDriver.FindElement(By.XPath("//a[normalize-space()='Custom']"));
				return true;
			}
			catch
			{
				return false;
			}
		}
		public bool GetDupSkuNotiicationonDraftQuote(IWebDriver webDriver, string errorNotificationMeassage)
		{
			bool isExist = false;
			IList<IWebElement> quoteDetailErrorNotificationsList = WebDriver.FindElements(By.XPath("//quote-create-header-notification//div[@class='alert-error']/span[2]"));
			if (quoteDetailErrorNotificationsList.Count > 0)
			{
				foreach (IWebElement quoteDetailErrorNotifications in quoteDetailErrorNotificationsList)
				{
					if (quoteDetailErrorNotifications.GetText(webDriver).ToLower().Contains(errorNotificationMeassage.ToLower()))
					{
						isExist = true;
						break;
					}
				}
			}
			return isExist;

		}

		public string DraftQuoteGetErrorMessageForMissingOrderCode(IWebDriver WebDriver)
		{
			return WebDriver.FindElement(By.XPath("//div[@class='alert-error']//span[contains(text(),'Ordercode: XCTOO3046MFFUS no longer exists in this company number.')]")).Text;

		}
		public string DraftQuoteItemLevelGetErrorMessageForMissingOrderCode()
		{
			return WebDriver.FindElement(By.XPath("//div[@id='quoteCreate_item_notifications_0_0']//span[contains(text(),'Ordercode:')]")).Text;

		}

		public string DraftQuoteModuledescription(IWebDriver WebDriver)
		{
			return WebDriver.FindElement(By.XPath("//div[@id='notificationMessages_0']//span[contains(text(),'Requested Module')]")).Text;

		}

		public IWebElement LblbaseSkuUnderConfig(int groupIndex = 1, int itemIndex = 1)
		{
			return webDriver.FindElements(By.XPath("//*[@id='lineitem_config_block_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "'" + "]//td[@class='config-col-md']")).FirstOrDefault();
		}

		public void changeInstallAtforfirstShippingGroup(IWebDriver driver, string InstallAtCustomer, string InstallAt_DifferentCustomer, string tabText)
		{
			if (string.IsNullOrEmpty(InstallAt_DifferentCustomer))
			{
				if (!ChangeInstallAtCustomer.IsElementDisplayed(driver))
				{
					new QuoteDetailsPage(driver).ExpandShippingInformation.Click();
				}
				ChangeInstallAtCustomer.Click();
				CustomerDetailsPage customerdetilpge = new CustomerDetailsPage(driver);
				CustomerSearchWorkflow.SearchCustomerByCustomerNumber(driver, InstallAtCustomer);
				driver.VerifyBusyOverlayNotDisplayed();
				WebDriver.WaitFor(x => customerdetilpge.BtnUseInQuoteAsInstallAtCustomer.IsElementVisible());
				customerdetilpge.BtnUseInQuoteAsInstallAtCustomer.Click();

			}
			else
			{
				if (!ChangeInstallAtCustomer.IsElementDisplayed(driver))
				{
					new QuoteDetailsPage(driver).ExpandShippingInformation.Click();
				}
				ChangeInstallAtCustomer.Click();
				CustomerDetailsPage customerdetilpge = new CustomerDetailsPage(driver);
				CustomerSearchWorkflow.SearchCustomerByCustomerNumber(driver, InstallAt_DifferentCustomer);
				driver.VerifyBusyOverlayNotDisplayed();
				WebDriver.WaitFor(x => customerdetilpge.BtnUseInQuoteAsInstallAtCustomer.IsElementVisible());
				customerdetilpge.BtnUseInQuoteAsInstallAtCustomer.Click();
			}
			WebDriver.VerifyBusyOverlayNotDisplayed();
			delay(10);
			ClickOnSearchExistingAddress(driver);

			var addressTable = GetAddressTableInstallAtAddress(tabText);
			delay(10);
			int index = 0;
			foreach (var address in addressTable)
			{

				var addressTableUCID = address["UCID"].ToString();

				if ((address["UCID"].ToString().Length == 10) && (address["Column15"].ToString().Equals("Select")))
				{
					GetSelectButtonFromAddressTable(index).Click(driver);
					driver.VerifyBusyOverlayNotDisplayed();

					break;
				}
				index++;
			}


		}

		public void changeInstallAtforsecondShippingGroup(IWebDriver driver, string InstallAtCustomer, string tabText)
		{
			ChangeInstallAtCustomer2.Click();
			CustomerDetailsPage customerdetilpge = new CustomerDetailsPage(driver);
			CustomerSearchWorkflow.SearchCustomerByCustomerNumber(driver, InstallAtCustomer);
			driver.VerifyBusyOverlayNotDisplayed();
			WebDriver.WaitFor(x => customerdetilpge.BtnUseInQuoteAsInstallAtCustomer.IsElementVisible());
			customerdetilpge.BtnUseInQuoteAsInstallAtCustomer.Click();
			WebDriver.VerifyBusyOverlayNotDisplayed();
			delay(20);
			ClickOn2SearchExistingAddress(driver);

			var addressTable = GetAddressTableInstallAtAddress(tabText);
			delay(10);
			int index = 0;
			foreach (var address in addressTable)
			{

				var addressTableUCID = address["UCID"].ToString();

				if ((address["UCID"].ToString().Length == 10) && (address["Column15"].ToString().Equals("Select")))
				{
					GetSelectButtonFromAddressTable(index).Click(driver);
					driver.VerifyBusyOverlayNotDisplayed();

					break;
				}
				index++;
			}

		}

		#region Re-Seller


		public IWebElement ResellerCustomerHeader { get { return WebDriver.GetElement(By.Id("quoteCreate_ResellerCustomer_header")); } }


		public IWebElement ChangeResellerCustomer { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_changeResellerCustomer']")); } }


		public IWebElement ChangeResellerAddress { get { return WebDriver.GetElement(By.Id("quoteCreate_reseller_chooseAddress")); } }


		public IWebElement EditResellerContact { get { return WebDriver.GetElement(By.Id("quoteCreate_reseller_editAddress")); } }


		public IWebElement BtnCancelEditContact { get { return WebDriver.GetElement(By.Id("EditContactDialog_cancel")); } }


		public IWebElement AddResellerAddress { get { return WebDriver.GetElement(By.Id("quoteCreate_reseller_addNewAddress")); } }

		public IWebElement BtnCancelAddAddr { get { return WebDriver.GetElement(By.Id("AddLocationDialog_cancel")); } }


		public IWebElement AddResellerContact { get { return WebDriver.GetElement(By.Id("quoteCreate_reseller_addNewContact")); } }


		public IWebElement BtnCancelAddContact { get { return WebDriver.GetElement(By.XPath("//div/button[contains(text(), 'Cancel')]")); } }


		public IWebElement CheckboxResellerReason { get { return WebDriver.GetElement(By.XPath("//*[@id='reseller-reason']")); } }


		public IWebElement SelectExceptionReason { get { return WebDriver.GetElement(By.XPath("//*[@id='main']//reseller-exception//select")); } }

		public IWebElement NotificationMsg(int lineIndex)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='notificationMessages_" + lineIndex + "']/span[2]"));

		}
		public IWebElement ChangeAddrDialogBox()
		{
			return WebDriver.GetElement(By.XPath("mat-dialog-0"));
		}

		public IWebElement ChangeAddrResults(int lineIndex)
		{
			return WebDriver.GetElement(By.XPath("//td/a[contains(@class, 'ng-star-inserted')]/following::tr/td[" + lineIndex + "]//a"));

		}
		public IWebElement ResellerCustomerORAddressInfo(int index)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='main']//div[3]/address/div/div[1]/div/div[" + index + "]"));
		}

		public IWebElement ResellerContactInfo(int index)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='main']//div[3]/address//div[" + index + "]"));
		}

		public Address GetResellerAddrInfo()
		{
			Logger.Write("Getting all Info from Reseller Address");

			var ResellerAddress = new Address
			{
				FirstName = ResellerCustomerORAddressInfo(1).GetText(webDriver).Split(' ')[0].Trim(),
				LastName = ResellerCustomerORAddressInfo(1).GetText(webDriver).Split(' ')[1].Trim(),
				AddressLine1 = ResellerCustomerORAddressInfo(2).GetText(webDriver).Trim(),
				AddressLine2 = ResellerCustomerORAddressInfo(3).GetText(webDriver).Trim(),
				PrimaryPhone = ResellerContactInfo(4).GetText(WebDriver).Replace(" ", String.Empty),
				Email = ResellerContactInfo(5).GetText(webDriver),
			};

			return ResellerAddress;
		}

		#endregion Re-Seller


		#region FT4 Digtial Fulfillment

		//*********************Digital Fulfilment *************************
		public CreateQuotePage CreateQuote_AddOC(string customerNum, Dictionary<string, ProductSearchType> products, string tiedSku = "")
		{
			// Search for customer and navigate to create quote page
			CustomerSearchWorkflow.SearchCustomerByCustomerNumber(webDriver, customerNum).CreateQuote();

			var createQuotePage = new CreateQuotePage(webDriver);
			CreateQuoteWorkflow.AddMoreItemsToQuote(webDriver, products);

			if (tiedSku != "")
			{
				createQuotePage.Configure()
					.AddTiedSkus(new[] { tiedSku });
			}
			createQuotePage.BtnCurrentQuote.Click(webDriver);
			createQuotePage.UpdateGroupLevelShippingMethod(WebDriver, 0, "Standard Delivery");
			// Save quote enabled or not validation as DF emails are not mandatory
			createQuotePage.IsSaveQuoteButtonEnabled().Should().BeTrue();
			return createQuotePage;
		}
		public CreateQuotePage CreateQuote_AddOC_Split(string customerNum, Dictionary<string, ProductSearchType> products1, Dictionary<string, ProductSearchType> products2, string tiedSku = "")
		{
			// Search for customer and navigate to create quote page
			CustomerSearchWorkflow.SearchCustomerByCustomerNumber(webDriver, customerNum).CreateQuote();

			var createQuotePage = new CreateQuotePage(webDriver);

			CreateQuoteWorkflow.AddItemsToGroups(0, webDriver, products1);

			if (tiedSku != "")
			{
				createQuotePage.GetConfigItems(0).Click(webDriver);
				new ProductConfigurePage(webDriver).AddTiedSkus(new[] { tiedSku });
			}
			createQuotePage.BtnCurrentQuote.Click(webDriver);
			createQuotePage.ClickAddShippingGroup();
			CreateQuoteWorkflow.AddItemsToGroups(1, webDriver, products2);

			if (tiedSku != "")
			{
				createQuotePage.GetConfigItems(1).Click(webDriver);
				new ProductConfigurePage(webDriver).AddTiedSkus(new[] { tiedSku });
			}
			createQuotePage.BtnCurrentQuote.Click(webDriver);
			createQuotePage.UpdateGroupLevelShippingMethod(WebDriver, 0, "Standard Delivery");
			createQuotePage.UpdateGroupLevelShippingMethod(WebDriver, 1, "Standard Delivery");
			// Save quote enabled or not validation as DF emails are not mandatory
			createQuotePage.IsSaveQuoteButtonEnabled().Should().BeTrue();
			return createQuotePage;
		}
		public CreateQuotePage Copy_Order(string dpid)
		{
			return HomeWorkflow.GoToOrderSearchPage(WebDriver)
		   .SearchOrderByDpidNumber(dpid)
		   .CopyOrder();
		}

		public CreateQuotePage Update_Order(string dpid)
		{
			HomeWorkflow.GoToOrderSearchPage(WebDriver).SearchOrderByDpidNumber(dpid);
			return new OrderDetailsPage(WebDriver).DFUpdateOrder();

		}

		public CreateQuotePage Rebook_Order(string dpid)
		{
			HomeWorkflow.GoToOrderSearchPage(WebDriver)
			   .SearchOrderByDpidNumber(dpid)
			   .CancelOrder()
			   .SelectReason("Duplicate Order")
			   .OrderCancellationComments("Test")
			   .SendCancelOrderNotice(true)
			   // .OrderCancelationEmailSendTo("com_qe@dell.com")
			   .ClickRebookChkBox()
			   .ClickCancelOrderNextBtn()
			   .ClickCancelOrderSuccessBtn();

			//Sometimes for Rebook Link to Appear we must refresh page (only when running Automation, not manually)
			HomeWorkflow.GoToOrderSearchPage(WebDriver).SearchOrderByDpidNumber(dpid);

			//Check is Rebook Link Displayed up to max 3 times => exist loop if displyed => move on to next line regardless 
			int count = 0;
			while ((!new OrderDetailsPage(WebDriver).LnkRebook.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10))) && count < 3)
			{
				HomeWorkflow.GoToOrderSearchPage(WebDriver).SearchOrderByDpidNumber(dpid);
				count++;
			}

			return new OrderDetailsPage(WebDriver).RebookOrder();
		}


		public IWebElement Digitially_Fulfilled_Software_and_Services_Header()
		{
			return WebDriver.GetElement(By.XPath(string.Format("//h3[contains(text(),' Digitially Fulfilled Software and Services ')]")));
		}

		public IWebElement DellDigitalLocker()
		{
			return WebDriver.GetElement(By.Id("df_digitallocker_url"));
		}

		public IWebElement DellDigitalLockerHoverText()
		{
			return WebDriver.GetElement(By.XPath("//*[@id='df_lockerhovertext']/i"));
		}

		public IWebElement DFEndUserEmail()
		{
			return WebDriver.GetElement(By.XPath("//*[@id='df_enduseremail_text']/div[2]/textarea"));
		}

		public IWebElement DFPartnerEmail()
		{
			return WebDriver.GetElement(By.XPath("//*[@id='df_partneruseremail_text']/div[2]/textarea"));
		}

		public IWebElement DFEmailNotification()
		{
			return WebDriver.GetElement(By.XPath("//*[@id='notificationMessages_0']/span[contains(text(),'Digital Fulfillment email is missing')]"));
		}

		public IWebElement DFWrongEmailErrorMsg()
		{
			return WebDriver.GetElement(By.XPath("//*[@id='df_enduseremail_text']/div[4]"));
		}

		public IWebElement DFWrongPartnerEmailErrorMsg()
		{
			return WebDriver.GetElement(By.XPath("//*[@id='df_partneruseremail_text']/div[4]"));
		}

		public IWebElement DF100ChrEnduserEmailNotficationMsg()
		{
			return WebDriver.GetElement(By.XPath("//*[@id='df_enduseremail_text']/div[3]"));
		}

		public IWebElement DF100ChrPartnerEmailNotficationMsg()
		{
			return WebDriver.GetElement(By.XPath("//*[@id='df_partneruseremail_text']/div[3]"));
		}
		public IWebElement DellDigitalLockerPage()
		{
			return WebDriver.GetElement(By.XPath("//*[@id='main-content-area']/h2"));
		}

		public IWebElement PSRNotification { get { return WebDriver.GetElement(By.XPath("//*[@id='notificationMessages_0']/span[2][contains(text(),'Primary Sales Rep on the quote (12345) is different from the Sales Rep on the Customer/Account (999)')]")); } }

		#endregion

		#region F5 DD
		public IWebElement DeploymentServiceToggle(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.FindElement(By.Id(pagePrefix + "_CL_service_toggle_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)), TimeSpan.FromSeconds(10));
		}

		public IWebElement ByHardwareListPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			//return WebDriver.FindElements(By.XPath("//*[@id='AddRecommendationToQuote']"))[0];
			return WebDriver.FindElements(By.Id(pagePrefix + "_CL_item_LP_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)))[0];
		}
		public IWebElement ByServiceListPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.FindElements(By.Id(pagePrefix + "_CL_item_LP_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)))[1];
		}

		public IWebElement ByHardwaresellingPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.FindElement(By.Id(pagePrefix + "_CL_service_USP_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "_label"));
		}

		public IWebElement ByServiceSellingPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.FindElement(By.Id(pagePrefix + "_CL_service_USP_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement ByHardwareDiscount(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.FindElement(By.Id(pagePrefix + "_CL_service_discount_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "_label"));
		}

		public IWebElement ByServiceDiscount(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.FindElement(By.Id(pagePrefix + "_CL_service_discount_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public bool IsDDSectionDisplayedForItem(int lineItemIndex = 1, int groupIndex = 1)
		{
			if (IsDDSectionDisplayed(lineItemIndex, groupIndex) != null)
			{
				Log.Info(string.Format("DD section available for item {0} of group {1} ", lineItemIndex, groupIndex));
				return true;
			}
			Log.Info(string.Format("DD section not available for item {0} of group {1} ", lineItemIndex, groupIndex));
			return false;
		}
		public IWebElement IsDDSectionDisplayed(int lineItemIndex = 1, int groupIndex = 1)
		{

			return WebDriver.FindElement(By.XPath("//*[@id='" + pagePrefix + "_accordion_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']"), TimeSpan.FromSeconds(10));
		}

		public ItemDDData GetItemDDValues(bool ServiceSkuValueRequired = false, int groupIndex = 1, int itemIndex = 1, bool contractCodeRequired = false)
		{
			Logger.Write("Getting DD Values for Item " + itemIndex + " in Shipping Group " + groupIndex);
			Logger.Write("----------Start---------------");

			var itemDDData = new ItemDDData
			{
				ItemListPrice = Convert.ToDouble(ByLblItemLevelUnitListPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				ItemSellingPrice = Convert.ToDouble(ByTxtItemLevelUnitSellingPrice(itemIndex, groupIndex).GetText(WebDriver)),
				ItemDiscount = Convert.ToDouble(ByLblItemLevelUnitDiscount(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				ItemDiscountPer = Convert.ToDouble(ByTxtItemLevelDiscountOffList(itemIndex, groupIndex).GetText(WebDriver)),

				HardwareListPrice = Convert.ToDouble(ByHardwareListPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				ServiceListPrice = Convert.ToDouble(ByServiceListPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),

				HardwareSellingPrice = Convert.ToDouble(ByHardwaresellingPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				ServiceSellingPrice = Convert.ToDouble(ByServiceSellingPrice(itemIndex, groupIndex).GetText(WebDriver)),

				HardwareDiscount = Convert.ToDouble((ByHardwareDiscount(itemIndex, groupIndex).GetText(WebDriver)).Split('%')[0]),
				ServiceDiscount = Convert.ToDouble(ByServiceDiscount(itemIndex, groupIndex).GetText(WebDriver)),

				ItemServiceSkuDDDatas = ServiceSkuValueRequired ? GetItemServiceSkuDDDatas(groupIndex, itemIndex) : null
			};
			Logger.Write("-----------End--------------");
			return itemDDData;
		}

		public List<ItemServiceSkuDDData> GetItemServiceSkuDDDatas(int groupIndex = 1, int itemIndex = 1)
		{
			var DDskuconfig = WebDriver.GetElement(By.Id("deployment_service_config_" + (groupIndex - 1) + "_" + (itemIndex - 1)));
			var DDskuconfigtbodys = DDskuconfig.FindElements(By.TagName("tbody"));
			int ItemServiceSkuDDDataCount = DDskuconfig.FindElements(By.TagName("tbody")).Count();
			Logger.Write("Found " + (ItemServiceSkuDDDataCount - 1) + " DD service skus");
			var itemServiceSkuDDDatas = new List<ItemServiceSkuDDData>();
			for (int i = 1; i < ItemServiceSkuDDDataCount; i++)
			{
				var itemServiceSkuDDData = new ItemServiceSkuDDData
				{
					//SkuId= DDskuconfigtbodys[i].FindElement(By.XPath(".//tr[2]/td[2]")).GetText(WebDriver).ToString(),
					SkuListPrice = Convert.ToDouble(DDskuconfigtbodys[i].FindElement(By.XPath(".//tr[2]/td[3]")).GetText(WebDriver).ToString().Substring(1)),
					//SkuDiscountClass = DDskuconfigtbodys[i].FindElement(By.XPath(".//tr[2]/td[4]")).GetText(WebDriver).ToString(),
					SkuSellingPrice = Convert.ToDouble(DDskuconfigtbodys[i].FindElement(By.XPath(".//tr[2]/td[5]")).GetText(WebDriver).ToString().Substring(1)),
				};
				itemServiceSkuDDDatas.Add(itemServiceSkuDDData);
			}

			return itemServiceSkuDDDatas;
		}


		#endregion F5 DD

		/// <summary>
		/// Gets the Bill to UCID when exist in Bill To Address section.
		/// </summary>
		/// <returns></returns>
		public string GetBillToUcid()
		{
			var ucid = string.Empty;
			var addressFirstline = BillToAddressDetail.GetText(WebDriver).Split('\r')[1].Trim();
			if (addressFirstline.Contains("UCID"))
			{
				ucid = addressFirstline.Split(':')[1].Trim();
			}

			return ucid;
		}

		#region CA New DFS elements
		public void SelectCaCatalog(string value)
        {
			WebDriver.GetElement(By.XPath("//td[text()='" + value + "']/following-sibling::td//a[@class='grid-btn']")).Click(WebDriver);
        }

		public IWebElement BillToCustFinancialInfo { get { return WebDriver.GetElement(By.XPath(@"//div[normalize-space()='Bill to Customer Financial Information']//a")); } }
		public IWebElement DFSDetailsLink { get { return WebDriver.GetElement(By.XPath("//dfs-smb-info-ca//a[@id='scc_viewDfsDetailsLink']")); } }
		public IWebElement LeaseAccStatusValue { get { return WebDriver.GetElement(By.XPath("//label[text()='Lease Account Status']/following-sibling::div/span[contains(@id,'leaseAccountStatus')]")); } } //new
		public IWebElement CreditStatusValue { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Lease Credit Status')]/following-sibling::div/span")); } } //approved
		public IWebElement LeaseOfferValue { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Lease Offer')]/following-sibling::div/span")); } }
		public IWebElement MLAValue { get { return WebDriver.GetElement(By.XPath("//dfs-smb-info-ca//*[contains(text(),'MLA')]/following-sibling::div/span")); } }
		public IList<IWebElement> CaDfsStatusLabels { get { return WebDriver.GetElements(By.XPath("//dfs-smb-info-ca//div/label")); } }
		public IWebElement BtnYes { get { return WebDriver.GetElement(By.XPath("//*[@class='btn btn-success' and contains(text(), 'Yes')]")); } }

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

		//Sv
		public bool IssalesrepnotificationExist(IWebDriver webDriver, string errorNotificationMeassage)
		{

			IWebElement configureErrorNotifications = WebDriver.FindElement(By.XPath("//div[@id='notificationMessages_1']"));
			if (configureErrorNotifications.GetText(webDriver).ToLower().Contains(errorNotificationMeassage.ToLower()))
				return true;
			else
				return false;
		}
		//Sv
		public IWebElement Salesrepnotification { get { return WebDriver.GetElement(By.XPath("//*[@id='notificationMessages_2']/span[2]")); } }



		#region FT2

		public List<IWebElement> AllEmailOverrideValidation { get { return WebDriver.GetElements(By.XPath("//div/email-errors//input[@class='form-input']")); } }

		public List<IWebElement> AllPhoneOverrideValidation { get { return WebDriver.GetElements(By.XPath("//div/phone-errors//input[@class='form-input']")); } }

		public IWebElement EmailOverrideValidation { get { return WebDriver.GetElement(By.XPath("//div/email-errors//input[@class='form-input']")); } }

		public IWebElement PhoneOverrideValidation { get { return WebDriver.GetElement(By.XPath("//div/phone-errors//input[@class='form-input']")); } }

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

		#endregion

	}


}

