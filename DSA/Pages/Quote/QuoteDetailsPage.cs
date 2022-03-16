using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.DataModels;
using Dsa.Enums;
using Dsa.Pages.Order;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using FluentAssertions;
using Dsa.Workflows;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWorkFlow = Dsa.Workflows.HomeWorkflow;
using System.Threading;
using System.Data;

namespace Dsa.Pages.Quote
{
	public class QuoteDetailsPage : DsaPageBase
	{
		private const string PagePrefix = "quoteDetail";
		public int LineItemIndex = 1;
		private const string selectGoalDeal = "_LI_selectGoalDealId_";

		public QuoteDetailsPage(IWebDriver webDriver)
			: base(webDriver)
		{
			PageFactory.InitElements(WebDriver, this);
			// Below code to to get rid of LSP popup displayed after the quote is loaded.
			//if (WebDriver.TryFindElement(By.Id("_setDefaultContract_cancel"), out BtnLspPopupViewOriginalQuote,
			//    TimeSpan.FromSeconds(30)))
			//{
			//    BtnLspPopupViewOriginalQuote.Click(WebDriver);
			//}
		}

		#region Autopilot Elements


		public IList<IWebElement> LabelAutoPilotQuoteDetailNotifications { get { return WebDriver.GetElements(By.XPath("//div[@id='quoteDetail_quote_Validation']//div[@class='alert-info']//span")); } }


		public IList<IWebElement> LabelAutoPilotQuoteDetailErrorNotifications { get { return WebDriver.GetElements(By.XPath("//div[@id='quoteDetail_quote_Validation']//div[@class='alert-error']//span")); } }


		public IWebElement ButtonSaveOrderDisable { get { return WebDriver.GetElement(By.XPath("//button[@id='quoteDetail_quote_Validation' and @class='btn btn-success ng-star-inserted']")); } }


		#region Sample
		/**

public IList<IWebElement> AutoPilotSection { get { return WebDriver.GetElements(By.XPath("//tab[@heading='Summary']//auto-pilot-info")); } }


public IList<IWebElement> TxtTenantID { get { return WebDriver.GetElements(By.XPath("//auto-pilot//input[contains(@id, 'quoteDetail_tenantID')]")); } }


public IList<IWebElement> TxtDomain { get { return WebDriver.GetElements(By.XPath("//auto-pilot//td[contains(text(), 'Tenant ID')]")); } }


public IList<IWebElement> LabelDomain { get { return WebDriver.GetElements(By.XPath("//auto-pilot//td[contains(text(), 'Domain')]")); } }


public IList<IWebElement> LabelWindowsAutopilot { get { return WebDriver.GetElements(By.XPath("//auto-pilot//td[contains(text(), 'Windows Autopilot')]")); } }

        [FindsBy(How = How.XPath,
            Using = "//auto-pilot//p[@class='alert alert-info' and contains(@id, 'quoteDetail_Info')]")]
        public IList<IWebElement> LabelAutpilotInfo;

        [FindsBy(How = How.XPath,
            Using = "//auto-pilot//p[@class='alert alert-success' and contains(@id, 'quoteDetail_success')]")]
        public IList<IWebElement> LabelAutpilotSuccess;


public IList<IWebElement> LabelTenantIDInvalidInput { get { return WebDriver.GetElements(By.XPath("//auto-pilot//input[contains(@id, 'quoteDetail_tenantID')]/parent::div//span[contains(@class,'invalid-input')]")); } }


public IList<IWebElement> LabelDomainInvalidInput { get { return WebDriver.GetElements(By.XPath("//auto-pilot//input[contains(@id, 'quoteDetail_domain')]/parent::div//span[contains(@class,'invalid-input')]")); } }


public IList<IWebElement> IconWindowsAutopilot { get { return WebDriver.GetElements(By.XPath("//auto-pilot//td[contains(text(), 'Windows Autopilot')]/parent::tr//div[@class='Icon Icon-small-alertinfo text-blue']")); } }


public IList<IWebElement> IconTenantID { get { return WebDriver.GetElements(By.XPath("//auto-pilot//td[contains(text(), 'Tenant ID')]/parent::tr//div[@class='Icon Icon-small-alertinfo text-blue']")); } }


public IList<IWebElement> IconDomain { get { return WebDriver.GetElements(By.XPath("//auto-pilot//td[contains(text(), 'Domain')]/parent::tr//div[@class='Icon Icon-small-alertinfo text-blue']")); } }


public IList<IWebElement> LabelAutoPilotNotifications { get { return WebDriver.GetElements(By.XPath("//quote-create-header-notification//div[@class='alert-warning' and contains(@id,'notificationMessages')]")); } }


public IList<IWebElement> LabelAutoPilotQuoteDetailNotifications { get { return WebDriver.GetElements(By.XPath("//div[@id='quoteDetail_quote_Validation']//div[@class='alert-info']//span")); } }



public IWebElement IconCloseTenantIDPending { get { return WebDriver.GetElement(By.XPath("//div[@class='product-configure']//i[@class='icon-ui-close']/parent::button[contains(@onclick,'_popover_tenantID_')]")); } }


public IWebElement IconCloseDomainPending { get { return WebDriver.GetElement(By.XPath("//div[@class='product-configure']//i[@class='icon-ui-close']/parent::button[contains(@onclick,'_popover_domain_')]")); } }
    */
		#endregion

		#endregion

		#region Install At Elements


		public IWebElement UCIDRequiredNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Install At address UCID required, per shipping group to place order')]")); } }


		public IWebElement UCIDRequestNotification { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_GI_shippingInformation_0']/button')]")); } }


		public IWebElement InstallAtAddressRequiredNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Install At address required, per shipping group to place order')]")); } }


		public IWebElement SolutionNameRequiredNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Solution name required, per shipping group to place order')]")); } }


		public IWebElement InstallAtShippingInfo_QuoteDetailspage { get { return WebDriver.GetElement(By.Id("quoteDetail_GI_shippingInformation_0_installAt")); } }


		public IWebElement InstallAtAddressInfo_QuoteDetailspage { get { return WebDriver.GetElement(By.Id("quoteDetail_GI_installAtAddress_0")); } }


		public IWebElement InstallAtAddressInfo_UserReview { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_GI_installAtAddress_0']//address//div//div[1]//div//div[1]")); } }

		public IWebElement GetSolutionNameTxt(int? index)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_solutionName_value_" + index + "']"));
		}

		#endregion

		#region PMC

		public IWebElement CustomerConsentScriptLink { get { return WebDriver.GetElement(By.XPath("//div[contains(text(), 'Read Privacy Notice Script')]")); } }


		public IWebElement GetCustomerConsentScriptText { get { return WebDriver.GetElement(By.XPath("//p[contains(text(),'To learn how Dell uses your data and how to set ma')]")); } }

		public IWebElement GetCustomerConsentScript(int? ConsentIndex)
		{
			return WebDriver.FindElement(By.XPath("//marketing-preference//div//p[" + ConsentIndex + "]"));
		}

		public void VerifyCustomerConsentScript(DataRow row)
		{
			CustomerConsentScriptLink.Displayed.Should().BeTrue();
			CustomerConsentScriptLink.Click(WebDriver);
			GetCustomerConsentScriptText.GetText(WebDriver).Should().BeEquivalentTo("To learn how Dell uses your data and how to set marketing communication preferences visit the Dell Privacy Statement at www.Dell.com/privacy.");
			Close.Click();
		}

		public IWebElement EditContactOptIn(string PMCField)
		{
			return WebDriver.FindElement(By.Id("EditContactDialog_Marketing_Preference_OptIn_" + PMCField + ""));
		}

		public IWebElement EditContactOptOut(string PMCField)
		{
			return WebDriver.FindElement(By.Id("EditContactDialog_Marketing_Preference_OptOut_" + PMCField + ""));
		}

		public void EditContactEmail(String emailAddress)
		{
			EmailInvoice.Clear();
			EmailInvoice.SetText(WebDriver, emailAddress);
		}

		public void EditContactMobile(String mobileNumber)
		{
			MobilePhone.Clear();
			MobilePhone.SetText(WebDriver, mobileNumber);
		}

		public void EditContactWork(String phoneNumber)
		{
			WorkPhone.Clear();
			WorkPhone.SetText(WebDriver, phoneNumber);
		}

		#endregion

		#region Autopilot Methods
		public void VerifyAutopilotNotifications()
		{
			string notificationWhenAllAutopilotDataFilled = "This quote has item(s) which qualify for Windows Autopilot. You may want to fill out the Tenant ID and Domain fields";
			string errorNotificationWhenPartialAutopilotDataFilled = "An Autopilot quote cannot be taken to order without Domain and Tenant IDs. Please enter them for the Autopilot items in this quote to Create Order.";
			bool notif = false;
			bool error = false;
			foreach (IWebElement notificationEle in LabelAutoPilotQuoteDetailNotifications)
			{
				if (notificationWhenAllAutopilotDataFilled.Equals(notificationEle.GetText(WebDriver, TimeSpan.FromSeconds(5)).Replace("Notification", "").Trim()))
					notif = true;
			}
			foreach (IWebElement errorEle in LabelAutoPilotQuoteDetailErrorNotifications)
			{
				if (errorNotificationWhenPartialAutopilotDataFilled.Equals(errorEle.GetText(WebDriver, TimeSpan.FromSeconds(5)).Replace("Notification", "").Trim()))
					error = true;
			}

			if (error == true)
			{
				BtnCreateOrder.IsElementClickable(WebDriver, TimeSpan.FromSeconds(3)).Should().BeFalse();
				Logger.Write($"Partial TenantId and Domain are entered in Create Quote page, Create Order is Disabled for Quote with Notification {notificationWhenAllAutopilotDataFilled} \n {errorNotificationWhenPartialAutopilotDataFilled}");
			}
			else
			{
				notif.Should().BeTrue();
				error.Should().BeFalse();
				Logger.Write($"All TenantId and Domain are entered in Create Quote page, Create Order is Enabled for Quote with Notification \n {notificationWhenAllAutopilotDataFilled}");
			}

		}

		#endregion

		#region DTCP

		public IWebElement DbcHeader { get { return WebDriver.GetElement(By.Id("quoteDetail_summary_dbc_header")); } }


		public IWebElement BillPlanTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Bill Plan')]")); } }


		public IWebElement PaymentTypeTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Payment Type')]")); } }


		public IWebElement CCNumberTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'CC Number')]")); } }


		public IWebElement NextPaymentTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Next Payment')]")); } }

		#endregion

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
			return WebDriver.GetElement(By.XPath("//span[contains(text(),'per year')]"));
		}

		#endregion

		#region OMS

		public IWebElement ExportProductUsage { get { return WebDriver.GetElement(By.Id("exportComplianceEndUse")); } }

		public IWebElement ExportComplianceLink { get { return WebDriver.GetElement(By.Id("exportComplianceViewLink")); } }

		public IWebElement GTPId { get { return WebDriver.GetElement(By.Id("gtpId")); } }

		public IWebElement GtpIdRequiredWarningNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'The selected export compliance end-use requires a GTP ID to create order.')]")); } }

		public IWebElement GTPIdLink { get { return WebDriver.GetElement(By.Id("gtpToolLink")); } }

		#endregion

		public IWebElement MergeQuoteDialog_Count { get { return WebDriver.GetElement(By.Id("mergeQuote_mergeCount")); } }


		public QuoteSummary Summary
		{
			get
			{
				return new QuoteSummary(WebDriver, PagePrefix);
			}
		}

		public QuotePage PageInformation
		{
			get { return new QuotePage(WebDriver, PagePrefix); }
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

		#region Elements


		public IWebElement LnkGoToHomePage { get { return WebDriver.GetElement(By.Id("dellBrandLogo_goHomePage")); } }

		public IWebElement APOSServiceTagInfo { get { return WebDriver.GetElement(By.Id("apos-product-details_0_0")); } }		

		public IWebElement ServiceTagInfo { get { return WebDriver.GetElement(By.Id("quoteDetail_LI_configuration_details_0_0_0")); } }


		public IWebElement ExpandItemViewMore { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'quoteDetail_SEItem_show_more')]//a")); } }


		public IWebElement ExpandServiceTag { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'quoteDetail_LI_configuration_details_0_0_0')]")); } }


		public IWebElement UnitListPriceAtQuoteDetailsPage { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_LI_configuration_details_0_0_0']/div/div/div[2]/div[5]")); } }


		public IWebElement Unit_SellingPriceAtQuoteDetailsPag { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_LI_configuration_details_0_0_0']/div/div/div[2]/div[6]")); } }


		public IWebElement SalesHoldErrorNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Customer is on a Sales Hold')]")); } }


		public IWebElement B2BCreateNewVersion { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_quote_b2bporeject_validation']/label/b/a")); } }


		public IWebElement EditLinkPomId { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_pomId']//a[contains(@class,'sublink')]")); } }


		public IWebElement SellingEntityEMCConfirmation { get { return WebDriver.GetElement(By.XPath("//*[contains(@id, 'sellingEntityEMCConfirmation')]/descendant::*[contains(text(),'Confirm')]")); } }


		public IWebElement ExpandShippingInformation { get { return WebDriver.GetElement(By.XPath("//i[@class='k-icon k-i-arrow-s']")); } }


		public IWebElement ExpandCustomerConsentScript { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Read Privacy Notice Script')]")); } }


		public IWebElement SubscriptionBillingData { get { return WebDriver.GetElement(By.XPath("//table[@class='c-data-grid c-data-grid-table dataTable table-layout-fixed']")); } }


		public IWebElement CustomerConsentScript { get { return WebDriver.GetElement(By.XPath("//div[@class='col-md-6']//div[@class='col-md-12']")); } }


		public IWebElement EditCustomerConsentScript { get { return WebDriver.GetElement(By.XPath("//div[@class='collapse in show ng-star-inserted']")); } }


		public IWebElement LangEnglish { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'English')] ")); } }


		public IWebElement LangFrench { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'French')] ")); } }


		public IWebElement EOLConfirmation { get { return WebDriver.GetElement(By.XPath("//*[@id='mat-dialog-0']//span[contains(text(), 'Solution Contains one or more End of Life options, Go to OSC to fix solution.')]")); } }


		public IWebElement AlertErrorMessage { get { return WebDriver.GetElement(By.XPath("//*[contains(@class,'alert-error')]")); } }

		public IWebElement QuoteTypeRSID { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),' RSIDQuote ')]")); } }

		public IWebElement MergeQuoteButtons(string QuoteNumber)
		{
			delay(5);
			return WebDriver.FindElement(By.CssSelector("[id*='mergeQuote_Grid_" + QuoteNumber + "']"));
		}

		public void delay(int timeOutInSeconds)
		{
			System.Threading.Thread.Sleep(timeOutInSeconds * 1000);
		}


		#region Solutions

		public IWebElement QuoteDetailsOverrideValidationMessages()
		{
			var lstwebelements = WebDriver.GetElements(By.XPath("//*[@id='quoteDetail_Overridable_Validation_Messages']"), TimeSpan.FromSeconds(15));
			if (lstwebelements != null && lstwebelements.Count > 0)
			{
				return lstwebelements[0];
			}
			return null;
		}

		public IWebElement QuoteDetailsGoalValidationMessages()
		{
			var lstwebelements = WebDriver.GetElements(By.XPath("quoteDetail_dealValidationErrorMessage_missingGoalDeal"), TimeSpan.FromSeconds(15));
			if (lstwebelements != null && lstwebelements.Count > 0)
			{
				return lstwebelements[0];
			}
			return null;
		}

		public IWebElement POMidfield { get { return WebDriver.GetElement(By.XPath("//input[@id='pom_id']")); } }


		public IWebElement OverrideValidationDialog { get { return WebDriver.GetElement(By.XPath("//div[h3[contains(text(),'Override Validation')]]")); } }


		public IWebElement QuoteDeatilsLinkedQuotesListBox { get { return WebDriver.GetElement(By.Id("quoteDetail_LinkedQuotes")); } }


		public IWebElement FinalPrice { get { return WebDriver.GetElement(By.XPath("//*[text()='Final Price:']/following::span[1]")); } }


		public IWebElement FinalTotalPrice { get { return WebDriver.GetElement(By.XPath("//span[@id = 'quoteDetail_summary_finalPrice']")); } }


		public IWebElement ReviewChecklist { get { return WebDriver.GetElement(By.XPath("//div[@id='quoteDetail_contentHorizontal']//div[@id='review-checklist-modal']")); } }


		public IWebElement QuoteDetailQuoteName { get { return WebDriver.GetElement(By.Id("quoteDetail_title")); } }


		public IWebElement EditAddress { get { return WebDriver.GetElement(By.Id("_editAddress")); } }


		public IWebElement BillToEditAddress { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_address_information']//div[2]//div[2]//div[1]//div[1]//a[@id='_editAddress']")); } }


		public IWebElement SoldToEditAddress { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_address_information']//div[2]//div[2]//div[2]//div[1]//a[@id='_editAddress']")); } }


		public IWebElement ErrorValidation { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_quote_b2bporeject_validation']/label/b")); } }


		public IWebElement GoalDialogTotalDiscountPercent { get { return WebDriver.GetElement(By.XPath("//table[contains(@class,'solution-select-group-details')]/tbody/tr/td[3]")); } }


		public IWebElement GoalDialogTotalMarginPercent { get { return WebDriver.GetElement(By.XPath("//table[contains(@class,'solution-select-group-details')]/tbody/tr/td[4]")); } }


		public IWebElement GoalDialogTotalSellingPrice { get { return WebDriver.GetElement(By.XPath("//table[contains(@class,'solution-select-group-details')]/tbody/tr/td[5]")); } }


		public IWebElement GoalDialogCurreny { get { return WebDriver.GetElement(By.XPath("//table[contains(@class,'solution-select-group-details')]/tbody/tr/td[6]")); } }


		public IWebElement OverrideValidationDialogCheckBoxby_2 { get { return WebDriver.GetElement(By.Id("quote_details_agreed")); } }


		public IWebElement OverrideValidationDialogOverrideby_2 { get { return WebDriver.GetElement(By.Id("_btn_ok")); } }


		public IWebElement ErrorNotification { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_quote_b2bporeject_validation']/h4")); } }


		public IWebElement NotificationMessage { get { return WebDriver.GetElement(By.XPath("//*[@id='notificationMessages_0']/span[2]")); } }


		public IWebElement PoLineNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='_LI_poLineNumber_0_0']")); } }


		public IWebElement PoLineNumberValue { get { return WebDriver.GetElement(By.XPath("//*[@id='_LI_poLineNumber_0_0']/option[2]")); } }


		public IWebElement FieldNotification { get { return WebDriver.GetElement(By.XPath("//*[@id='notificationMessages_0']/span[2]")); } }


		public IWebElement PoNumberColumn { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_poNumber_input']")); } }


		public IWebElement EditLink { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_pomId']/span/span[2]/span/a")); } }


		public IWebElement CopyAsNewQuote { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_copyQuoteNew']")); } }


		public IWebElement CopyAsNewVersion { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_copyQuoteVersion']")); } }



		public IWebElement SaveQuoteButton { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_saveQuote']/span")); } }


		public IWebElement ClickViewMore { get { return WebDriver.GetElement(By.XPath("//*[@id='toggleMoreLess_0_0']")); } }


		public IWebElement PoLineNumber1 { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_LI_poLineNumber_0_0_label']")); } }


		public IWebElement PoLineNumberValue1 { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_LI_poLineNumber_0_0']")); } }


		public IWebElement QuoteDetailsPoMId { get { return WebDriver.GetElement(By.XPath("//*[@id='pom_id']")); } }


		public IWebElement TextMessage { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_pomId']/div/span")); } }


		public IWebElement PoMIdText { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_pomId']/span/span")); } }


		public IWebElement ErrorText { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_pomId']/div/span")); } }


		public IWebElement PoNumberText { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_poNumber']/span[1]")); } }

		public IWebElement ErrorDetails { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_pomId']/div/span")); } }

		public IWebElement CreateNewVersion { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_quote_b2bporeject_validation']/label//a")); } }

		#region PMC Notifications


		public IWebElement CustomerConsentNotifications { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'When collecting or updating a customer')]")); } }


		public IWebElement PMCUpdateNotifications { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Any update to PMC will take up to 24/48 hours to reflect in DSA.')]")); } }


		public IWebElement Close { get { return WebDriver.GetElement(By.Name("close")); } }

		#endregion

		By DiscountLimitReached = By.Id("changeCustomer_title");

		By discountLimitReached_ok = By.Id("discountLimitReached_ok");

		By QuoteDetailsOverrideValidationMessagesby = By.Id("quoteDetail_Overridable_Validation_Messages");

		By XPODErrorwithNoOverrideby = By.Id("quoteDetail_XPOD_Validation_Message");

		By ItemLevelPickFromList = By.XPath("//div[a[contains(text(),'Pick from list')]][@class='ng-hide']/a");

		By OverrideValidationDialogCheckBoxby = By.Id("quote_details_agreed");

		By OverrideValidationDialogOverrideby = By.Id("_btn_ok");

		By ValidationErrorMessagesby = By.XPath(".//span");

		By XPODErrorMessagesby = By.XPath(".//div[contains(@data-ng-if,'Override')]//span[contains(text(),'XPOD')]");

		By ProductValidationErrorMessagesby = By.XPath(".//div[contains(@data-ng-if,'Override')]//span[contains(text(),'Validation')]");

		By OverrideButtonby = By.XPath(".//button[contains(text(),'Override')]");

		public IWebElement LnkNewRequestGroupLevel(int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id((PagePrefix + "_GI_createNewGoalDealId_" + (groupIndex - 1))));
		}

		public IWebElement LnkPickFromListGroupLevel(int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id((PagePrefix + "_GI_selectGoalDealId_" + (groupIndex - 1))));
		}

		#endregion

		#region ARB Notifications


		public IWebElement MsgReservationCancelled { get { return WebDriver.GetElement(By.Id("quoteDetail_reservationCancelledMessage")); } }


		public IWebElement MsgReservationExpired { get { return WebDriver.GetElement(By.Id("quoteDetail_reservationExpiredMessage")); } }

		#endregion


		public IWebElement CopyPickQuote { get { return WebDriver.GetElement(By.Id("quoteDetail_copyRSPickQuote")); } }


		public IWebElement CopyStockQuote { get { return WebDriver.GetElement(By.Id("quoteDetail_copyRSStockQuote")); } }


		public IWebElement CopyRSIQ { get { return WebDriver.GetElement(By.Id("quoteDetail_copyRSIDQuote")); } }


		public IWebElement QuoteType { get { return WebDriver.GetElement(By.Id("quoteDetail_quoteType")); } }

		public IWebElement QuoteName { get { return WebDriver.GetElement(By.Id("quoteName")); } }

		//[FindsBy(How = How.Id, Using = "quoteDetail_LI_productRsId_0_0")] //quoteDetail_LI_productRsId_0_0
		//public IWebElement LineItemIQNumber { get; set; }


		public IWebElement LnkCurrentCustomerCompanyName { get { return WebDriver.GetElement(By.Id("currentCustomer_createCustomerHeaderLink1")); } }


		public IWebElement LnkCurrentCustomerCustomerName { get { return WebDriver.GetElement(By.Id("currentCustomer_createCustomerHeaderLink2")); } }


		public IWebElement TxtCurrentCustomerCustomerNumber { get { return WebDriver.GetElement(By.Id("currentCustomer_customerNumber")); } }


		public IWebElement TxtCurrentCustomerCompanyNumber { get { return WebDriver.GetElement(By.Id("currentCustomer_context")); } }


		public IWebElement TxtEndCustomerNumber { get { return WebDriver.GetElement(By.Id("quoteDetail_endUserCustomerNumber")); } }



		public IWebElement TxtEndUserCompanyName { get { return WebDriver.GetElement(By.Id("quoteDetail_endUserCompanyName")); } }


		public IWebElement TxtEndUserAccountNumber { get { return WebDriver.GetElement(By.Id("quoteDetail_endUserAccountNumber")); } }


		public IWebElement TxtEndUserAccountName { get { return WebDriver.GetElement(By.Id("quoteDetail_endUserAccountName")); } }


		public IWebElement LinkedDpid { get { return WebDriver.GetElement(By.Id("quoteDetail_linkedDpId")); } }


		public IWebElement LinkcopiedFromQuote { get { return WebDriver.GetElement(By.Id("quote_copiedFrom")); } }


		public IWebElement LinkcopiedFromOrder { get { return WebDriver.GetElement(By.Id("order_copiedFrom")); } }


		public IWebElement ValidationMessage { get { return WebDriver.GetElement(By.XPath("//span[normalize-space()='Invalid DPID Entered']")); } }

		//--------------------------------------------------

		public IWebElement CompanyChangeMsg { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Company number of customer has changed')]")); } }


		public IWebElement DivDiscountLimitReachedPopup { get { return WebDriver.GetElement(By.ClassName("modal-wrap")); } }


		public IWebElement QuoteDetailPrimarySalesRep { get { return WebDriver.GetElement(By.Id("quoteDetail_salesRep")); } }


		public IWebElement QuoteDetailAddPrimarySalesRep { get { return WebDriver.GetElement(By.Id("quoteDetail_salesRepNew")); } }


		public IWebElement BtnDiscountLimitReachedOk { get { return WebDriver.GetElement(By.Id("discountLimitReached_ok")); } }


		public IWebElement FinancialInfoToggle { get { return WebDriver.GetElement(By.Id("quoteDetail_billToCustomerFinancialInformationToggle")); } }


		public IWebElement PaymentMethodInQuote { get { return WebDriver.GetElement(By.Id("quoteDetail_paymentMethod")); } }


		public IWebElement DdlQuoteDetailsPaymentTerm { get { return WebDriver.GetElement(By.Id("quoteDetail_paymentTerm")); } }


		public IWebElement CustomerInfoToggle { get { return WebDriver.GetElement(By.CssSelector("#quoteDetail_customerInformationToggle > div > span > a")); } }

		//[FindsBy(How = How.Id, Using = "quoteDetail_createOrder")]
		//public IWebElement BtnCreateOrder;
		public IWebElement BtnCreateOrder { get { return WebDriver.GetElement(By.Id("quoteDetail_createOrder")); } }



		public IWebElement ContractExpiryMsg { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_quote_Validation']/div[2]/div/span")); } }


		public IWebElement LblLSPValidation { get { return WebDriver.GetElement(By.Id("quoteDetail_quote_lspValidations")); } }


		public IWebElement LblQuoteTitle { get { return WebDriver.GetElement(By.Id("quoteDetail_title")); } }


		public IWebElement QuoteStatusLoading { get { return WebDriver.GetElement(By.XPath("//div[@id='quoteDetail_quoteStatus']//span[@class='ellipsis_animated-inner']")); } }


		public IWebElement LnkSaveAsEQuote { get { return WebDriver.GetElement(By.Id("quoteDetail_saveAseQuote")); } }


		public IWebElement LnkAssociateOpportunity { get { return WebDriver.GetElement(By.Id("quoteDetail_associateOpportunity")); } }

		//[FindsBy(How = How.XPath, Using = "//*[@id ='quoteDetail_moreActions' or @data-c-id='quoteDetail_moreActions']")]
		//[FindsBy(How = How.Id, Using = @"quoteDetail_moreActions")]

		//public IWebElement BtnMoreActions { get { return WebDriver.GetElement(By.XPath("//span[normalize-space()='More Actions']/..")); } }

		public IWebElement BtnMoreActions { get { return WebDriver.GetElement(By.XPath("//button//span[contains(text(), 'More Actions')]")); } }

		public IWebElement CopyQuoteBtn { get { return WebDriver.GetElement(By.Id("quoteDetail_copyQuote")); } }


		public IWebElement BtnCopyQuote { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='Copy Quote']")); } }


		public IWebElement LnkCopyQuote { get { return WebDriver.GetElement(By.Id("quoteDetail_copyquote")); } }


		public IWebElement ErrorAgreementIdMismatch { get { return WebDriver.GetElement(By.Id("mergeQuote_mergeQuotes_error_notSameAgreementId")); } }


		public IWebElement LnkSplitQuote { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_splitQuote']")); } }


		public IWebElement LnkMergeQuote { get { return WebDriver.GetElement(By.Id("quoteDetail_mergeQuote")); } }


		public IWebElement BtnMergeQuoteList { get { return WebDriver.GetElement(By.Id("quoteDetail_mergeQuotes")); } }


		public IWebElement BtnCreateMergeQuote { get { return WebDriver.GetElement(By.XPath("//*[@id='mergeQuote_continue']")); } }


		public IWebElement BtnselectMergeQuote { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'mergeQuote_Grid_')]")); } }


		public IWebElement DivMergeQuotePopup { get { return WebDriver.GetElement(By.XPath("//*[@class='dsa-modal-wrap']")); } }

		public IWebElement BtnSendMultipleQuotes { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteSearchResults_mergeQuotes'][contains(text(),'Send')]")); } }

		public IWebElement BtnSendQuote { get { return WebDriver.GetElement(By.XPath("//*[@id ='quoteDetail_sendCfo']")); } }




		public IWebElement LblCustomerNumber { get { return WebDriver.GetElement(By.Id("quoteDetail_customerNumber")); } }


		public IWebElement LblCustomerName { get { return WebDriver.GetElement(By.Id("currentCustomer_currentCustomer")); } }


		public IWebElement LblCompanyNumber { get { return WebDriver.GetElement(By.Id("quoteDetail_companyNumber")); } }

		//[FindsBy(How = How.XPath, Using = "//*[@id='quoteNumber']")]
		//public IWebElement LblQuoteNumber;

		//public IWebElement LblQuoteNumber { get { return WebDriver.GetElement(By.XPath("//span[@id='quoteNumber']")); } }
		public IWebElement LblQuoteNumber { get { return WebDriver.GetElement(By.XPath("//h3[@id='quoteNumber']")); } }

		public IWebElement LblQuoteVersion { get { return WebDriver.GetElement(By.Id("quoteDetail_versionToggle")); } }


		public IWebElement LblOpportunityDealId { get { return WebDriver.GetElement(By.Id("quoteDetail_dealId")); } }

		//[FindsBy(How = How.Id, Using = @"quoteDetail_mergeQuote")]
		//public IWebElement BtnMergeQuote;


		public IWebElement BtnMergeQuote { get { return WebDriver.GetElement(By.Id("quoteDetail_mergeQuote")); } }


		public IWebElement LblBillToCustomerNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='3_billToCustomer_intro']/div[2]")); } }


		public IWebElement LblSoldToCustomerNumber { get { return WebDriver.GetElement(By.Id("soldToCustomer_customerNumber")); } }


		public IWebElement DivGoalValidationErrorMessage { get { return WebDriver.GetElement(By.ClassName("modal-wrap")); } }



		public IWebElement BtnMergeXQuotes { get { return WebDriver.GetElement(By.Id("quoteDetail_mergeQuotes")); } }
		//[FindsBy(How = How.Id, Using = @"QuoteMerge_continue")]
		//public IWebElement BtnMergeXQuotes;


		public IWebElement BtnQtoPqtoNotificationOk { get { return WebDriver.GetElement(By.Id("_confirm_ok")); } }


		public IWebElement BtnQtoPqtoNotificationCancel { get { return WebDriver.GetElement(By.Id("_confirm_cancel")); } }


		public IWebElement QtoPqtoNotificationModal { get { return WebDriver.GetElement(By.Id("_confirm")); } }

		////[FindsBy(How = How.CssSelector, Using = @".button-bar > button:nth-child(1)")]
		//[FindsBy(How = How.XPath, Using = "//*[@class='modal-wrap']//button[@class='btn btn-success']")]
		//public IWebElement BtnCreateOderUsingDefaultSalesRep;
		public IWebElement BtnCreateOderUsingDefaultSalesRep { get { return WebDriver.GetElement(By.XPath("//*[@class='modal-wrap']//button[@class='btn btn-success']")); } }


		public IWebElement BtnCreateOderUsingLoggedInSalesRep { get { return WebDriver.GetElement(By.CssSelector(".button-bar > button:nth-child(2)")); } }


		public IWebElement RdbSplitByItem { get { return WebDriver.GetElement(By.Id("quoteDetail_splitBy_byProduct")); } }


		public IWebElement RdbSplitByEdd { get { return WebDriver.GetElement(By.Id("quoteDetail_splitBy_byEDD")); } }


		public IWebElement RdbSplitQuantity { get { return WebDriver.GetElement(By.CssSelector("tr.odd:nth-child(3) > td:nth-child(1) > span:nth-child(1) > input:nth-child(1)")); } }


		public IWebElement RdbSplitShippingLocation { get { return WebDriver.GetElement(By.CssSelector("tr.ng-scope:nth-child(4) > td:nth-child(1) > span:nth-child(1) > input:nth-child(1)")); } }


		public IWebElement RdbSplitShippingMethod { get { return WebDriver.GetElement(By.CssSelector("tr.ng-scope:nth-child(5) > td:nth-child(1) > span:nth-child(1) > input:nth-child(1)")); } }


		public IWebElement RdbSplitShippingGroup { get { return WebDriver.GetElement(By.Id("quoteDetail_splitBy_byShippingGroup")); } }


		public IWebElement BtnSplitReviewQuotes { get { return WebDriver.GetElement(By.XPath("//button[contains(text(), 'Review Quotes')]")); } }


		public IWebElement BtnApproveDamRequest { get { return WebDriver.GetElement(By.CssSelector("#quoteDetail_dam_approval > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > a:nth-child(1)")); } }


		public IWebElement BtnReassignDamRequest { get { return WebDriver.GetElement(By.CssSelector("#quoteDetail_dam_approval > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > a:nth-child(3)")); } }


		public IWebElement BtnRejectDamRequest { get { return WebDriver.GetElement(By.CssSelector("#quoteDetail_dam_approval > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > a:nth-child(2)")); } }


		public IWebElement DivDamApprovalHistory { get { return WebDriver.GetElement(By.Id("quoteDetail_dam_approval")); } }


		public IWebElement TxtDamApprovalNotes { get { return WebDriver.GetElement(By.Id("approverApproveDialog_notes")); } }


		public IWebElement BtnDamApproveDialogApprove { get { return WebDriver.GetElement(By.Id("approverApproveDialog_approve")); } }


		public IWebElement DdlDamRequestReassignApprover { get { return WebDriver.GetElement(By.Id("approverApproveDialog_approvers")); } }


		public IWebElement TxtDamRequestReassignNotes { get { return WebDriver.GetElement(By.Id("approverApproveDialog_notes")); } }


		public IWebElement BtnDamApproveDialogReassign { get { return WebDriver.GetElement(By.Id("approverApproveDialog_reassign")); } }


		public IWebElement TxtDamRequestRejectNotes { get { return WebDriver.GetElement(By.Id("approverApproveDialog_notes")); } }


		public IWebElement BtnDamApproveDialogReject { get { return WebDriver.GetElement(By.Id("approverApproveDialog_reject")); } }



		public IWebElement RdCreateNewQteNoForOld { get { return WebDriver.GetElement(By.Id("quoteDetail_quote")); } }


		public IWebElement RdQteSavetoNewVersion { get { return WebDriver.GetElement(By.Id("quoteDetail_version")); } }


		public IWebElement LnkSaveAsNewQuote { get { return WebDriver.GetElement(By.Id("quoteDetail_copyQuoteNew")); } }
		


		public IWebElement LnkSaveAsNewVersion { get { return WebDriver.GetElement(By.Id("quoteDetail_copyQuoteVersion")); } }


		public IWebElement BtnQteDetailsNext { get { return WebDriver.GetElement(By.Id("quoteDetail_next")); } }


		public IWebElement BtnQteDetailsCancel { get { return WebDriver.GetElement(By.Id("quoteDetail_cancel")); } }


		public IWebElement BillToAddressDetail { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'Bill to Address')]/following-sibling::div[1]")); } }


		public IWebElement SoldToAddressDetail { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'Sold to Address')]/following-sibling::div[1]")); } }


		public IWebElement Group1ShipingAddress { get { return WebDriver.GetElement(By.XPath("//div[@id = 'quoteDetail_GI_shippingAddress_0']")); } }


		public IWebElement Group2ShipingAddress { get { return WebDriver.GetElement(By.XPath("//div[@id = 'quoteDetail_GI_shippingAddress_1']")); } }


		public IWebElement ordeDPIDLink { get { return WebDriver.GetElement(By.XPath("//a[contains(@href, '/order/details/dpid')]")); } }


		//--------------------------------------------------


		public IWebElement BtnSubmitRequest { get { return WebDriver.GetElement(By.LinkText("Submit Request")); } }


		public IWebElement BtnYesSubmitDamRequest { get { return WebDriver.GetElement(By.Id("closeApprovalRequest_Submit")); } }


		public IWebElement DdlDamApprover { get { return WebDriver.GetElement(By.Id("damApproval_Approver")); } }


		public IWebElement ChkDamApprovalPriority { get { return WebDriver.GetElement(By.Id("damApproval_Priority")); } }


		public IWebElement TxtDamApprovalJustification { get { return WebDriver.GetElement(By.Id("damApproval_Justification")); } }


		public IWebElement BtnSubmitDamApproval { get { return WebDriver.GetElement(By.Id("closeApprovalRequest_Submit")); } }


		public IWebElement BtnLspPopupContinue { get { return WebDriver.GetElement(By.Id("_setDefaultContract_ok")); } }


		public IWebElement BtnLspPopupViewOriginalQuote { get { return WebDriver.GetElement(By.Id("_setDefaultContract_cancel")); } }


		public IWebElement ImgValidatingQuoteBusyIndicator { get { return WebDriver.GetElement(By.CssSelector("#quoteDetail_header > div > div.section-header.pd-btm-5 > div.col-md-12.table-column-centered.mg-btm-10.mg-top-10.ng-scope > p > span > img")); } }


		public IWebElement validationCustomerStatus { get { return WebDriver.GetElement(By.Id("validation_customerstatus")); } }


		public IWebElement validationCustomerCreditStatus { get { return WebDriver.GetElement(By.Id("validation_customercreditstatus")); } }


		public IWebElement resendCfoDialog { get { return WebDriver.GetElement(By.Id("resendCFOEmailDailog")); } }


		public IWebElement titleQuoteDetails { get { return WebDriver.GetElement(By.XPath("//h2[text()=' Quote Details']")); } }


		public IWebElement notificationMessage { get { return WebDriver.GetElement(By.Id("quoteDetail_quote_Validation")); } }


		public IWebElement mergeQuoteWarningMessage { get { return WebDriver.GetElement(By.Id("quoteDetail_mergeQuotes_warningMessage")); } }


		public IWebElement validateShippingMethod { get { return WebDriver.GetElement(By.XPath("//*[normalize-space()='APO/FPO PARCEL POST']")); } }

		//--------------------------------------------------


		public IWebElement LblQuoteExpirationDate { get { return WebDriver.GetElement(By.Id("quoteDetail_expirationDate")); } }


		public IWebElement QuoteEdd { get { return WebDriver.GetElement(By.Id("quoteDetail_deliveryDate")); } }


		public IWebElement LblOriginalMasterQuote { get { return WebDriver.GetElement(By.XPath("//label[contains(text(), 'Original Master Quote')]")); } }


		public IWebElement GetOriginalMasterQuote { get { return WebDriver.GetElement(By.XPath("//div//div//a[@href='#/quote/details/QuoteNumber/3001013561492?versionNumber=1']")); } }

		//--------------------------------------------------


		public IWebElement ChkTaxHold { get { return WebDriver.GetElement(By.Id("tax-hold")); } }

		//[FindsBy(How = How.Id, Using = "large-value-hold")]
		//public IWebElement ChkLargeValueHold;
		public IWebElement ChkLargeValueHold { get { return WebDriver.GetElement(By.Id("large-value-hold")); } }



		public IWebElement ChkInsuredItem { get { return WebDriver.GetElement(By.Id("insured-item")); } }



		public IWebElement txtFusionID { get { return WebDriver.GetElement(By.Id("quoteDetail_insuredItem_fusionId")); } }

		public IWebElement txtPOMID { get { return WebDriver.GetElement(By.Id("quoteDetail_insuredItem_pomId")); } }

		public IWebElement txtInsNotes { get { return WebDriver.GetElement(By.Id("quoteDetail_insuredItem_Notes")); } }

		public IWebElement btnInsSubmit { get { return WebDriver.GetElement(By.Id("quoteDetail_insuredItem_submit")); } }




		public IWebElement QuoteDetailPageTaxableAmount { get { return WebDriver.GetElement(By.Id("quoteDetail_summary_taxableAmount")); } }


		public IWebElement QuoteDetailPageTotalTax { get { return WebDriver.GetElement(By.Id("quoteDetail_summary_totalTaxAmount")); } }


		public IWebElement QuoteDetailPageTotalShipping { get { return WebDriver.GetElement(By.Id("quoteDetail_summary_shippingAmount")); } }


		public IWebElement QuoteDetailPageCopyQuote { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_copyQuote' and contains(text(), 'Copy Quote')]")); } }

		//--------------------------------------------------

		public IWebElement QuoteDetailsPageSolutionID { get { return WebDriver.GetElement(By.Id("quoteDetail_items_header_s")); } }


		public IWebElement QuoteDetailPagePOMID { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_pomId']/span/span[1]")); } }

		//Added new element for POMID input box as the old one is not geting identified

		public IWebElement QuoteDetailPagePomidInput { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_pomId']/span/input")); } }


		public IWebElement PomidFieldLevel_Notification { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_pomId']/div/span")); } }


		public IWebElement QuoteDetailPageEditPOMID { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_pomId']/span/span[2]/a")); } }

		//Added new element for Edit Link beside POMID as the old one is not geting identified

		public IWebElement QuoteDetailPageLnkEditPOMID { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_pomId']/span/span[2]/span/a")); } }


		public IWebElement UploadToPOM { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest")); } }

		public IWebElement ClickEditPoM { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_pomId']/span/span[2]/span/a")); } }

		public IWebElement ErrorDialogueBox { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_setDefaultContract']")); } }
		//  [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Upload to POM']")]
		// public IWebElement UploadToPOM;


		public IWebElement SaveAseQuote { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='Save as eQuote']")); } }


		public IWebElement ProformaInvoice { get { return WebDriver.GetElement(By.XPath("//a[@id = 'orderDetails_proformaInvoice']")); } }


		public IWebElement ExportStandardConfig { get { return WebDriver.GetElement(By.Id("quoteDetail_exportStandardConfig")); } }


		public IWebElement ChkAdminOverrideCFS { get { return WebDriver.GetElement(By.XPath("//*[@id='cfs-admin-override']")); } }


		public IWebElement QuoteVersion1 { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='Version 1']")); } }


		public IWebElement SelectVersionToggle { get { return WebDriver.GetElement(By.Id("quoteDetail_versionToggle")); } }


		public IWebElement QuoteDetailsPageSendPoRequest { get { return WebDriver.GetElement(By.Id("quoteDetail_send_poRequest")); } }


		public IWebElement QuoteDetailPagePOMDesWorkgroup { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_destinationWorkgroup")); } }


		public IWebElement QuoteDetailPagePOMSourceAddressListEmailValue { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_poSourceAddressList_emailValue")); } }


		public IWebElement QuoteDetailPageSendPONumber { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_poNumber")); } }


		public IWebElement QuoteDetailPageSendPORequestAmount { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_poAmount")); } }


		public IWebElement QuoteDetailPageSendPORequestCancel { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_cancel")); } }


		public IWebElement QuoteDetailPagePONumberRemoveLink { get { return WebDriver.GetElement(By.Id("quoteDetail_poNumber_update")); } }


		public IWebElement QuoteDetailPagePONumberInput { get { return WebDriver.GetElement(By.Id("quoteDetail_poNumber_input")); } }


		public IWebElement QuoteDetailPagePONumberEditCancel { get { return WebDriver.GetElement(By.Id("quoteDetail_cancelPoNumber")); } }


		public IWebElement QuoteDetailPagePONumberEditSave { get { return WebDriver.GetElement(By.Id("quoteDetail_savePoNumber")); } }


		public IWebElement QuoteDetailPagePONumber { get { return WebDriver.GetElement(By.Id("quoteDetail_poNumber")); } }


		public IWebElement QuoteDetailPagePONumberWithPOentered { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_poNumber']/span")); } }


		public IWebElement QuoteDetailPageSourceApplicationName { get { return WebDriver.GetElement(By.Id("quoteDetail_sourceApplicationName")); } }


		public IWebElement LblDfsStatus { get { return WebDriver.GetElement(By.Id("quoteDetail_dfsStatus")); } }


		public IWebElement LblLeaseGrid { get { return WebDriver.GetElement(By.Id("quoteDetail_summary_leaseProducts_header")); } }


		public IWebElement LnkCheckDfsCredit { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_header']/div/div[2]/div[3]/div/div[1]/div/div/div[4]/div/a")); } }


		public IWebElement submit { get { return WebDriver.GetElement(By.Id("quoteDetail_exportStandardConfig")); } }


		public IWebElement DefaultShipToAddressText { get { return WebDriver.GetElement(By.Id("quoteDetail_defaultShipToAddress")); } }

		//Edit Contact

		public IWebElement EmailInvoice { get { return WebDriver.GetElement(By.Id("EditContactDialog_contact_email")); } }


		public IWebElement MobilePhone { get { return WebDriver.GetElement(By.Id("EditContactDialog_contact_mobilePhone")); } }


		public IWebElement WorkPhone { get { return WebDriver.GetElement(By.Id("EditContactDialog_contact_workPhone")); } }


		public IWebElement FaxNumber { get { return WebDriver.GetElement(By.Id("EditContactDialog_contact_faxNumber")); } }


		public IWebElement SubmitBtn { get { return WebDriver.GetElement(By.Id("EditContactDialog_submit")); } }


		public IWebElement AddressLnk { get { return WebDriver.GetElement(By.XPath("//div[normalize-space()='Addresses']//a")); } }


		public IWebElement ViewAddressesLnk { get { return WebDriver.GetElement(By.XPath("//div[normalize-space()='View Addresses']//a")); } }


		public IWebElement UCIDRequestInstallAtAddress { get { return WebDriver.GetElement(By.CssSelector("#quoteDetail_GI_installAtAddress_0 address .address-block>div:nth-child(1)")); } }


		public IWebElement UCIDInstallAtAddress { get { return WebDriver.GetElement(By.Id("ShipGroup0_installAt_UCID")); } }

		public IWebElement AddressExpandLink { get { return WebDriver.GetElement(By.XPath("//h2[contains(text(), 'Addresses')]")); } }

		//[FindsBy(How = How.Id, Using = @"quoteDetail_editDefaultBillToAddress")]
		//public IWebElement EditBillToAddressLnk;


		public IWebElement EditBillToAddressLnk { get { return WebDriver.GetElement(By.XPath("//*[@id='NG2_UPGRADE_27_0']/div/div[2]/a")); } }


		public IWebElement UCIDRequestShippingAddress { get { return WebDriver.GetElement(By.CssSelector("#quoteDetail_GI_shippingInformation_0>div~div:not(#quoteDetail_GI_shippingAddress_0)")); } }


		public IWebElement UCIDRequestBtnShippingAddress { get { return WebDriver.GetElement(By.CssSelector("#quoteDetail_GI_shippingInformation_0>div~button")); } }

		public IWebElement LblSummaryLevelDfsRevenuePrice { get { return WebDriver.GetElement(By.XPath("////*[@id='quoteDetail_GI_revenue_Incentive_")); } }


		public IWebElement LblSummaryLevelSmartPriceRevenue { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_GI_smartPrice_Revenue_']")); } }


		public IWebElement ShippingInstructionTextAtQuoteHeader { get { return WebDriver.GetElement(By.XPath(".//*[@id='quoteDetail_contentHorizontal']//div[contains(@data-ng-show,'ShippingInstructions')]")); } }

		//[FindsBy(How = How.XPath, Using = "//*[@id='quoteDetail_dealValidationErrorMessage_missingGoalDeal']")]

		public IWebElement GoalLiteDamMsgAtQuoteLevel { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_quote_Validation']//span[contains(text(),'approval is required')]")); } }


		public IWebElement GoalLiteDamMsgForAmtAtQuoteLevel { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_quote_Validation']//span[contains(text(),'Quote Selling Price has exceeded')]")); } }


		public IWebElement GoalLiteNewRequestLink { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_goalLiteApprovalStatus']")); } }


		public IWebElement GoalLiteReasonCode { get { return WebDriver.GetElement(By.Id("quoteDetail_approveDiscount_reason")); } }


		public IWebElement GoalLiteBusCase { get { return WebDriver.GetElement(By.Id("quoteDetail_approveDiscount_Notes")); } }


		public IWebElement GoalLiteSubmitReq { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_approveDiscount_submit']")); } }


		public IWebElement GoalLiteCancelReq { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_approveDiscount_cancel']")); } }


		public IWebElement GoalLiteDealId { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_goalLiteDealId']")); } }



		public IWebElement GoalLiteDealIdLabel { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_goalLiteDealId_label']")); } }


		public IWebElement GoalLiteDealIdStatusLabel { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_goalLiteApprovalStatus_label']")); } }




		public IWebElement GoalLiteDealIdStatus { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_goalLiteApprovalStatus_label']/../span/label")); } }

		public IWebElement LnkInstallationInstructions { get { return WebDriver.GetElement(By.Id("quoteDetail_installationinstructions_header")); } }

		//--------------------Solutions------------------------------

		public IWebElement SolutionId { get { return WebDriver.GetElement(By.Id("quoteCreate_items_header_s")); } }
		//--------------------------------------------------


		public IWebElement TxtInstallationInstructions { get { return WebDriver.GetElement(By.XPath("//textarea[@data-ng-model='model.viewData.installationInstructions']")); } }


		public IWebElement QuoteSaveSummaryFinalPrice { get { return WebDriver.GetElement(By.XPath(".//*[@id='GMOR_terms_of_sale_anchor']/descendant::span[2]")); } }


		public IWebElement RejectMsgAtQuotelevel { get { return WebDriver.GetElement(By.XPath("//*[@class='alert-error']//p")); } }


		public IWebElement PaymentTerms { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Payment Terms')]/../div")); } }


		public IWebElement quotetlanumber { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_LI_tla_0_0']/span")); } }


		public IWebElement topassemply { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_accordion_0_0']/div[2]/div[2]/div/div[2]/div[4]/div/div[2]/p")); } }


		public IWebElement favoriteQuoteimage { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_contentHorizontal']/div[1]/quote-details-header/div[2]/div[2]/h5/span[1]/a")); } }
		public IWebElement CCpoLabel { get { return WebDriver.GetElement(By.XPath("//div[contains(@class,'send-po-req')]//div[@class='checkbox-grp'][1]//label")); } }


		public IWebElement ShippingPrice { get { return WebDriver.GetElement(By.XPath("//label[text() = 'Shipping Price']/following::div[contains(@id , 'shippingPrice')]")); } }


		public IWebElement UnitListPrice { get { return WebDriver.GetElement(By.XPath("//div[@id = 'quoteCreate_LI_PI_unitPrice_0_0']")); } }


		public IWebElement TotalAmount { get { return WebDriver.GetElement(By.XPath("//div[@id= 'quoteDetail_GI_totalAmount_0']/span")); } }


		public IWebElement QuoteDetailProduct { get { return WebDriver.GetElement(By.XPath("//span[contains(@id, 'quoteDetail_LI_productDescription')]")); } }


		public IWebElement ViewAllDpid { get { return WebDriver.GetElement(By.Id("quoteDetail_dpidsToggle")); } }


		public IWebElement QuoteLanguage { get { return WebDriver.GetElement(By.Id("quoteDetail_quoteLanguage")); } }


		public IWebElement QuoteDetailEndUserCustomerNumber { get { return WebDriver.GetElement(By.Id("quoteDetail_endUserCustomerNumber")); } }


		public IWebElement SplitQuote_1 { get { return WebDriver.GetElement(By.Id("_returnQuote_0")); } }


		public IList<IWebElement> TaggedSalesReps { get { return WebDriver.GetElements(By.XPath("//*[contains(@id,'quoteDetail_tagRep_')]")); } }


		public IWebElement ChecklistTotalCost { get { return WebDriver.GetElement(By.XPath("(//*[text()='Total:']/following::td[1])")); } }


		public IWebElement ChecklistInstallationInstructions { get { return WebDriver.GetElement(By.XPath("//*[text()='Installation Instructions:']/following::p[1]")); } }

		public bool IsTopLevelAssemplyleveltDisplayed()
		{
			return topassemply.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(20));
		}

		public bool IsfavoriteQuoteimageVisible()
		{
			return favoriteQuoteimage.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(20));
		}

		public IWebElement ExistCreateNewPOM { get { return WebDriver.GetElement(By.Id("quoteDetail_new_pomIdRequest_createNew")); } }
		#region Pick Premier Customer Set


		public IWebElement CustomerSetEnterTab { get { return WebDriver.GetElement(By.Id("quoteDetail_customerSetEnterTab")); } }


		public IWebElement CustomerSetListTab { get { return WebDriver.GetElement(By.Id("quoteDetail_customerSetListTab")); } }


		public IWebElement CustomerSetSearchTab { get { return WebDriver.GetElement(By.Id("quoteDetail_customerSetSearchTab")); } }


		public IWebElement TxtCustomerSetEnter { get { return WebDriver.GetElement(By.Id("quoteDetail_customerSetEnter")); } }


		public IWebElement BtnCustomerSetSearch { get { return WebDriver.GetElement(By.Id("quoteDetail_customerSetSearchButton")); } }

		#endregion

		#region Send Premier Quote Email


		public IWebElement TxtRecipientEmail { get { return WebDriver.GetElement(By.Id("quoteDetail_recipientEmail")); } }


		public IWebElement BtnCreateEquote { get { return WebDriver.GetElement(By.Id("quoteDetail_createEQuote")); } }

		#endregion


		public IWebElement LblExportConfirmation { get { return WebDriver.GetElement(By.Id("quoteDetail_exportConfirmation")); } }


		public IWebElement CloseExportConfirmationDialog { get { return WebDriver.GetElement(By.Id("quoteDetail_saveConfigClose")); } }


		public IWebElement MsgEquoteInvalidShipping { get { return WebDriver.GetElement(By.Id("quoteDetail_eQuoteInvalidShippingMessage")); } }


		public IWebElement MsgEquoteInvalidContractCodes { get { return WebDriver.GetElement(By.Id("quoteDetail_eQuoteInvalidContractCodesMessage")); } }


		public IWebElement SGTotalTaxPending { get { return WebDriver.GetElement(By.Id("quoteDetail_GI_tax_0")); } }


		public IWebElement SGEcoFeePending { get { return WebDriver.GetElement(By.Id("quoteDetail_GI_ehf_0")); } }


		public IWebElement SGTotalAmountPending { get { return WebDriver.GetElement(By.Id("quoteDetail_GI_totalAmount_0")); } }


		public IWebElement SummaryTotalTaxtPending { get { return WebDriver.GetElement(By.Id("quoteDetail_summary_totalTaxAmount")); } }


		public IWebElement SummaryEcoFeePending { get { return WebDriver.GetElement(By.Id("quoteDetail_summary_totalEhfAmount")); } }


		public IWebElement SummaryTotalAmountPending { get { return WebDriver.GetElement(By.Id("quoteDetail_summary_finalPrice")); } }


		public IWebElement LnkCustomerFinancialInformationToggle { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Bill to Customer Financial Information')]")); } }


		public IWebElement LnkDfsDetails { get { return WebDriver.GetElement(By.Id("declineScript")); } }


		public IWebElement lblPFLSFDCvalue { get { return WebDriver.GetElement(By.XPath("//p[normalize-space()='SFDC Deal ID']/../span")); } }


		public IWebElement lblPFLEndUserAccountvalue { get { return WebDriver.GetElement(By.XPath("//p[normalize-space()='End User Account']/../span")); } }


		public IWebElement topassemplylevel { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_accordion_0_0']/div[2]/div[2]/div/div[2]/div[4]/div/div[2]/p")); } }


		public IWebElement SubscriptionBillingFlyout { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'Subscription Billing')]")); } }


		public IWebElement RateCardSummaryTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Rate Card Summary')]")); } }


		public IWebElement FinalPriceSummary { get { return WebDriver.GetElement(By.XPath("//span[@id = 'quoteDetail_summary_finalPrice']")); } }


		public IWebElement WarrantySkuNotification { get { return WebDriver.GetElement(By.XPath("//div[@id='quoteDetail_contentHorizontal']/div/warranty-sku-notification/div/div/span")); } }


		public IWebElement LnkdealId { get { return WebDriver.GetElement(By.Id("quoteDetail_dealId")); } }


		public IWebElement LblSellingEntity { get { return WebDriver.GetElement(By.Id("quoteDetail_sellingEntityName")); } }


		public IWebElement QuoteDetailsPagePOMIDText { get { return WebDriver.GetElement(By.XPath(".//*[@id='quoteDetail_pomId']/span/span")); } }

		//[FindsBy(How = How.Id, Using = "chkContinueWithDuplOrder")]
		//public IWebElement duplicateCheckCheckBoxYes;
		public IWebElement duplicateCheckCheckBoxYes { get { return WebDriver.GetElement(By.XPath("//input[@id='chkContinueWithDuplOrder']")); } }

		//[FindsBy(How = How.XPath, Using = "//button[contains(text(),'Continue')]")]
		//public IWebElement duplicateCheckContinue;
		public IWebElement duplicateCheckContinue { get { return WebDriver.GetElement(By.XPath("//button[@class='dds__btn dds__btn-primary pd-btn']")); } }


		public IWebElement TagSalesRepButton { get { return WebDriver.GetElement(By.XPath("//*[text()='Tag Sales Rep']")); } }


		public IWebElement TagSalesRepInput { get { return WebDriver.GetElement(By.Id("quoteDetail_tagRepNew")); } }


		public IWebElement TagSalesRepAddButton { get { return WebDriver.GetElement(By.Id("quoteDetail_tagRepAdd")); } }


		public IWebElement duplicateCheckCheckBoxCloseButton { get { return WebDriver.GetElement(By.XPath("//button[@class='btn btn-blank icon-ui-close']")); } }


		public IWebElement duplicateCheckCheckBoxCancelButton { get { return WebDriver.GetElement(By.XPath("//div[@class='dsa-modal-wrap modal-wrap-container']//button[contains(text(),'Cancel')]")); } }


		public IWebElement MultipleShipAddressWarningMsg { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_quote_Validation']/div/div/span[contains(text(),'This Quote contains multiple ship to address selections. The Quote default shipping address will NOT be used for all products.')]")); } }

		#region Export Standard Config - Select Config


		public IWebElement ChkboxExportSelectAll { get { return WebDriver.GetElement(By.Id("quoteDetail_exportSelectAll")); } }


		public IWebElement BtnSaveConfig { get { return WebDriver.GetElement(By.Id("quoteDetail_saveConfig")); } }


		public IWebElement BtnSaveConfigBack { get { return WebDriver.GetElement(By.Id("quoteDetail_saveConfigBack")); } }


		public IWebElement BtnSaveConfigCancel { get { return WebDriver.GetElement(By.Id("quoteDetail_saveConfigCancel")); } }

		#region Reseller 


		public IWebElement LblExceptionReason { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetails_customer_information']//div[3]//div[2]")); } }


		public IWebElement ChangeResellerCustomer { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_changeResellerCustomer']")); } }


		public IWebElement ResellerCustomerSection { get { return WebDriver.GetElement(By.Id("3_ResellerCustomer_intro")); } }


		public IWebElement ResellerAddrSection { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_address_information']//div[3]/address/div")); } }
		public IWebElement ResellerCustomerORAddressInfo(int index)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='main']//div[3]/address/div/div[1]/div/div[" + index + "]"));
		}
		public IWebElement ResellerContactInfo(int index)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='main']//div[3]/address//div[" + index + "]"));
		}
		public Address GetQuoteDetailsResellerAddrInfo()
		{
			Logger.Write("Getting all Reseller Address Info from Quote Details Page");

			var values = new Address();
			{
				values.FirstName = ResellerCustomerORAddressInfo(1).GetText(WebDriver).Split(' ')[0].Trim();
				values.LastName = ResellerCustomerORAddressInfo(1).GetText(WebDriver).Split(' ')[1].Trim();
				values.AddressLine1 = ResellerCustomerORAddressInfo(2).GetText(WebDriver);
				values.AddressLine2 = ResellerCustomerORAddressInfo(3).GetText(WebDriver);
				values.PrimaryPhone = ResellerContactInfo(4).GetText(WebDriver);
				values.Email = ResellerContactInfo(5).GetText(WebDriver);
			};

			return values;
		}

		#endregion Reseller

		public IWebElement ChkboxExportIsSelected(int index)
		{
			return WebDriver.GetElements(By.Id(PagePrefix + "_exportIsSelected_"))[index - 1];
		}

		public IWebElement TxtExportTitle(int index)
		{
			return WebDriver.GetElements(By.Id(PagePrefix + "_exportTitle_"))[index - 1];
		}

		public IWebElement DrpdwnExportCategoryId(int index)
		{
			return WebDriver.GetElements(By.Id(PagePrefix + "_exportCategoryId_"))[index - 1];
		}


		public IWebElement LblStandardConfigSuccess { get { return WebDriver.GetElement(By.Id("quoteDetail_standardConfigSuccess")); } }


		public IWebElement LblStandardConfigSelect { get { return WebDriver.GetElement(By.Id("quoteDetail_standardConfigSelect")); } }

		#endregion

		#region HoldCheckBoxes

		public By quotedetailsCheckboxCollection = By.XPath("//*[@id='quoteDetail_header']//*[@type='checkbox']");



		#endregion

		#endregion

		#region Line Items

		#region Solution Line Item
		public IWebElement LnkGroupLevelGoalDealIdPickFromList(int lineGroupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_GI_selectGoalDealId_" + lineGroupIndex));
		}

		#endregion


		public Boolean StandardConfigOptionAvailable(IWebDriver driver)
		{
			return !driver.FindElement(By.Id("quoteDetail_exportStandardConfig"), TimeSpan.FromSeconds(5))
				.GetAttribute("class")
				.Contains("disabled");
		}

		public IWebElement AddressBlockShippingGroupSection(int index = 0)
		{
			var xpath = String.Format("//*[@id='quoteDetail_GI_shippingAddress_{0}']/div/text()[4]", index);
			return WebDriver.GetElement(By.XPath(xpath));
		}
		public IWebElement TxtItemLevelPhoneNumber(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_SI_phoneNumber_" + lineItemIndex));
		}

		public IWebElement LnkItemLevelProductDescription(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_productDescription_" + lineItemIndex));
		}

		public IWebElement MsgItemLevelContarctCodeMissing(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_contractMissingMsg"));
		}

		public IWebElement LblItemLevelUnitListPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_PI_unitPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public By ByLblItemLevelUnitListPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return By.Id(PagePrefix + "_LI_PI_unitPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1));
		}

		public IWebElement LblItemLevelUnitCost(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_PI_unitCost_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemLevelUnitDiscount(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_PI_dol_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemLevelCadence(int shippingGroupIndex = 1, int lineItemIndex = 1)
		{
			return
				WebDriver.GetElement(
					By.XPath("//*[@id='quoteDetail_SEItem_" + (shippingGroupIndex - 1) + "_" + (lineItemIndex - 1) +
							 "']//label[contains(text(), 'Cadence')]/following-sibling::div"));
		}

		public IWebElement LblItemLevelUnitSellingPrice(int lineItemIndex = 1)
		{
			return WebDriver.GetElements(By.XPath("//div[contains(@id,'_LI_PI_unitSellingPrice_')]/div/span"))[lineItemIndex - 1];
		}

		public IWebElement LblItemLevelUnitSmartpriceRevenue(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_PI_unitCompRevenue_" + lineItemIndex));
		}

		public IWebElement LblItemLevelDfsRevenuePrice(int lineItemIndex = 1)
		{
			return WebDriver.GetElements(By.XPath("//span[contains(@id,'" + PagePrefix + "_GI_revenue_Incentive_0')]"))[lineItemIndex - 1];

		}

		public IWebElement LblItemLevelUnitMargin(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_PI_unitMargin_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemLevelContractDiscount(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_PI_unitPercent_" + lineItemIndex));
		}

		public IWebElement LblItemLevelPromotions(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_PI_promotionsPercentage_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemLevelDiscountOffList(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_PI_dolPercentage_" + (groupIndex - 1) + "_" + (lineItemIndex - 1))).FindElement(By.TagName("span"));
		}

		public IWebElement LblItemLevelQuantity(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_quantity_" + +(groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemLevelTotalListPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_totalListPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemLevelTotalCostPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_cost_" + +(groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemLevelTotalDiscount(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_totalDiscountPercent_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemLevelTotalSellingPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_pricingInformation_sellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemLevelSmartpriceRevenue(int groupIndex = 1, int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_qdSmartPriceRevenue_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemLevelMargin(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_itemMarginPercentage_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblContractCode(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_contractCode_" + lineItemIndex));//.FindElements(By.Id(PagePrefix + "_LI_contractCode_" + lineItemIndex))[0];
		}

		public IWebElement LnkItemLevelGoalDealIdNewRequest(int shippingGroupIndex = 1, int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_createNewGoalDealId_" + (shippingGroupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LnkItemLevelGoalDealIdPickFromList(int shippingGroupIndex = 1, int lineItemIndex = 1)
		{
			return //WebDriver.GetElement(By.Id(PagePrefix + "_LI_selectGoalDealId_" + (shippingGroupIndex - 1) + "_" + (lineItemIndex - 1)));
				WebDriver.GetElement(By.Id("goalSel_" + (shippingGroupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LnkNonTiedItemLevelGoalDealIdPickFromList(int groupIndex = 1, int lineItemIndex = 1, int nonTiedItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id("goalSel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "_" + (nonTiedItemIndex - 1)));
		}


		public IWebElement LnkItemLevelGoalTool(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_openGoalTool_" + lineItemIndex));
		}

		public IWebElement LblItemLevelGoalDealId(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_info_goalDealId_" + lineItemIndex));
		}

		public IWebElement LblNonTiedItemLevelGoalDealId(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_NonTied_info_goalDealId_" + lineItemIndex));
		}

		public IWebElement LblItemLevelShippingPrice(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_SI_shippingPrice_" + lineItemIndex));
		}

		public IWebElement TxtItemLevelShippingDiscount(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_SI_shippingDiscount_" + lineItemIndex));
		}

		#region ItemSummaryElements
		public IWebElement LblItemSummarySellingPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_pricingTotals_sellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemSummaryTax(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_GI_tax_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemSummaryEcoFee(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_GI_ehf_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement LblItemSummaryTotalAmount(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_totalAmount_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		#endregion

		#region GroupSummaryElements
		public IWebElement LblGroupSummarySubTotal(int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_GI_sellingPrice_" + (groupIndex - 1)));
		}

		public IWebElement LblGroupSummaryShippingAmount(int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_GI_totalShippingAmount_" + (groupIndex - 1)));
		}

		public IWebElement LblGroupSummaryTax(int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_GI_tax_" + (groupIndex - 1)));
		}

		public IWebElement LblGroupSummaryEcoFee(int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_GI_ehf_" + (groupIndex - 1)));
		}

		public IWebElement LblGroupSummaryTotalAmount(int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_GI_totalAmount_" + (groupIndex - 1)));
		}

		#endregion

		public IWebElement DivSmartpriceConditionalMessage(IWebElement smartpriceDiv)
		{
			return smartpriceDiv.GetChildElement(By.XPath(".//div[@class='conditionalMsg']"));
		}

		public IWebElement DivSmartpriceGenericMessage(IWebElement smartpriceDiv)
		{
			return smartpriceDiv.GetChildElement(By.XPath(".//div[@class='mg-top-15']"));
		}

		public IWebElement LblItemLevelTotalShipping(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_totalShippingAmount_" + lineItemIndex));
		}


		public IWebElement LnkItemLevelShowMore(int? groupIndex = 0, int? lineItemIndex = 0)
		{
			return WebDriver.GetElement(By.XPath("id('" + PagePrefix + "_LI_show_more_" + groupIndex + "_" + lineItemIndex + "')/a"));
			//return WebDriver.GetElement(By.XPath("//div[@id='" + PagePrefix + "_LI_show_more_" + groupIndex + "_" + lineItemIndex + "')/div[1]/a[1]"));
		}

		public IWebElement LblItemLevelFulfillmentTime(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_itemBuildTime_" + lineItemIndex));
		}
		public IWebElement LblSystemID(int groupIndexint, int lineItemIndex)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_arbSystemId_" + groupIndexint + "_" + lineItemIndex + ""));
		}
		public IWebElement LblServiceTag(int groupIndex, int lineItemIndex)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_arbServiceTag2_" + groupIndex + "_" + lineItemIndex + ""));
		}
		public IWebElement LblItemValidations(int groupIndex, int lineItemIndex)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_item_validations_" + groupIndex + "_" + lineItemIndex + ""));
		}

		public IWebElement LblItemLevelOrderCode(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_orderCode_" + lineItemIndex));
		}

		public IWebElement LblItemLevelShippingPriceUnderShowMore(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("id('" + PagePrefix + "_accordion_0')/div[2]/div[3]/div[1]/div[1]/div[6]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[6]/div[2]"));
		}

		public IWebElement LnkItemLevelPickDifferentAddress(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_SI_shippingPickAddressLink_" + lineItemIndex));
		}

		public IWebElement LblItemLevelShippingAddress(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_SI_addressInformation_" + lineItemIndex));
		}

		public IWebElement LnkItemLevelAddShippingAddress(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_SI_shippingNewAddressLink_" + lineItemIndex));
		}

		public IWebElement LblItemLevelShippingInfoEmailAddress(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_SI_emailAddress_" + lineItemIndex));
		}

		public IWebElement LnkItemLevelShippingInfoEmailAddressSearch(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_SI_searchEmailAddress_" + lineItemIndex));
		}

		public IWebElement LblItemLevelShippingInfoChangeEmailAddress(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("id('" + PagePrefix + "_LI_SI_grid_ext_" + lineItemIndex + "')/div[2]/div[2]/span[2]/a[1]/span[1]"));
		}
		public IWebElement LblItemLevelShippingInfoMustArriveByDate(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_mabd_startDate"));
		}

		public IWebElement LblGroupLevelShippingInfoEdd(int? groupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_GI_EDD_Max_" + groupIndex + "_"));
		}

		public IWebElement LblItemLevelShippingInfoEdd(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_SI_estimatedDeliveryDate_" + lineItemIndex));
		}

		public IWebElement LblItemLevelEddMin(int groupNum = 1, int lineItemNum = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_EDD_Min_" + (groupNum - 1) + "_" + (lineItemNum - 1)));
		}

		public IWebElement LblItemLevelEddMax(int groupNum = 1, int lineItemNum = 1)
		{
			return WebDriver.FindElement(By.Id(PagePrefix + "_LI_EDD_Max_" + (groupNum - 1) + "_" + (lineItemNum - 1)));
		}

		public IWebElement LblItemLevelAddShippingInstruction(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("id('" + PagePrefix + "_LI_SI_grid_ext_" + lineItemIndex + "')/div[7]/div[1]/a[1]"));
		}

		public IWebElement LblItemLevelExpandAllConfiguration(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("id('" + PagePrefix + "_accordion_0')/div[2]/div[3]/div[1]/div[1]/div[6]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/a[1]"));
		}

		#region nonTied Elements
		public IWebElement LblItemLevelNonTiedUnitListPrice(int nonTiedIndex = 1)
		{
			return
				WebDriver.GetElements(By.XPath("//[contains(@id,'" + PagePrefix + "_Sku_PI_unitPrice')]"))[
					nonTiedIndex - 1];
		}

		public IWebElement LblItemLevelNonTiedUnitDiscount(int nonTiedIndex = 1)
		{
			return
			   WebDriver.GetElements(By.XPath("//[contains(@id,'" + PagePrefix + "_Sku_PI_dol')]"))[
				   nonTiedIndex - 1];
		}

		public IWebElement LblItemLevelNonTiedUnitCost(int nonTiedIndex = 1)
		{
			return
			   WebDriver.GetElements(By.XPath("//[contains(@id,'" + PagePrefix + "_Sku_PI_unitCost')]"))[
				   nonTiedIndex - 1];
		}

		public IWebElement LblItemLevelNonTiedUnitSellingPrice(int nonTiedItemIndex = 1)
		{
			return
				WebDriver.GetElements(
						By.XPath("//*[contains(@id, '" + PagePrefix +
								 "_Sku_PI_unitSellingPrice_')]/div"))[nonTiedItemIndex - 1];
		}

		public IWebElement LblItemLevelNonTiedSmartpriceRevenue(int nonTiedItemIndex = 1)
		{
			return WebDriver.GetElements(By.XPath("//*[contains(@id, '_Sku_PI_unitCompRevenue_')]"))[nonTiedItemIndex - 1];
		}

		public IWebElement LblItemLevelNonTiedUnitMargin(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_Sku_PI_unitMargin_" + lineItemIndex));
		}

		public IWebElement LblItemLevelNonTiedContractDiscount(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("id('" + PagePrefix + "_accordion_0')/div[2]/div[3]/div[1]/div[1]/div[6]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]"));
		}

		public IWebElement LblItemLevelNonTiedPromotions(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("id('" + PagePrefix + "_accordion_0')/div[2]/div[3]/div[1]/div[1]/div[6]/div[3]/div[1]/div[2]/div[1]/div[2]/div[1]"));
		}

		public IWebElement LblItemLevelNonTiedDiscountOffList(int nonTiedItemIndex = 1)
		{
			return
				WebDriver.GetElements(
						By.XPath("//*[contains(@id, '" + PagePrefix +
								 "_Sku_PI_unitPercent_')]/span"))[nonTiedItemIndex - 1];
		}

		public IWebElement LblItemLevelNonTiedQuantity(int shippingGroupIndex = 1, int itemIndex = 1, int nonTiedItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_Sku_quantity_input_" + (shippingGroupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedItemIndex - 1)));
		}

		public IWebElement LblItemLevelNonTiedListPrice(int groupIndex = 1, int itemIndex = 1, int nonTiedIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_totalListPrice_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedIndex - 1)));
		}

		public IWebElement LblItemLevelNonTiedCost(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("id('" + PagePrefix + "_accordion_0')/div[2]/div[3]/div[1]/div[1]/div[6]/div[3]/div[1]/div[1]/div[3]/div[3]/div[1]"));
		}
		public IWebElement LblItemLevelNonTiedDiscount(int groupIndex = 1, int itemIndex = 1, int nonTiedIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_totalDiscountValue_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedIndex - 1)));
		}

		public IWebElement LblItemLevelNonTiedSellingPrice(int groupIndex = 1, int itemIndex = 1, int nonTiedIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_Sku_Quantity_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedIndex - 1)));
		}

		public IWebElement LblItemLevelNonTiedTotalSmartpriceRevenue(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_Sku_compRevenue_" + lineItemIndex));
		}

		public IWebElement LblItemLevelNonTiedMargin(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("id('" + PagePrefix + "_accordion_0')/div[2]/div[3]/div[1]/div[1]/div[6]/div[3]/div[1]/div[1]/div[3]/div[7]/div[1]"));
		}

		public IWebElement LnkItemLevelNonTiedGoalDealIdNewRequest(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("id('" + PagePrefix + "_LI_NonTied_info_goalDealId_" + lineItemIndex + "')/div/a[1]"));
		}

		public IWebElement LnkItemLevelNonTiedGoalDealIdPickFromList(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.CssSelector("#" + PagePrefix + "_LI_NonTied_info_goalDealId_" + lineItemIndex + " > div:nth-child(2) > a:nth-child(3)"));
		}

		public IWebElement LnkItemLevelNonTiedGoalTool(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.CssSelector("#" + PagePrefix + "_LI_NonTied_info_goalDealId_" + lineItemIndex + " > div:nth-child(2) > a:nth-child(4)"));
		}

		public IWebElement LnkItemLevelNonTiedShowMore(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("id('" + PagePrefix + "_LI_Sku_collapsible_d8e22ee8-cfde-4d54-b57e-8874a9d94e13_" + lineItemIndex + "')/div[1]/a[1]/i[1]"));
		}
		#endregion

		public IWebElement LnkItemLevelToggleMoreOrLess(int itemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(string.Format("toggleMoreLess_{0}_{1}", itemIndex - 1,
				groupIndex - 1)));
		}


		public IWebElement ToggleViewMoreOrLess { get { return WebDriver.GetElement(By.XPath("//*[@class='dds__more']")); } }

		public IWebElement LblEndUserCompanyName()
		{
			return WebDriver.GetElement(By.Id("quoteDetail_endUserCompanyName"));
		}

		public IWebElement LblServiceTagAtItemLevel()
		{
			return WebDriver.GetElement(By.XPath("id('" + PagePrefix + "_LI_configuration_rows" + "')/div/div/div[1]/div[1]"));
		}

		public IWebElement LnkItemLevelConfigure(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id("quoteCreate_LI_configItem"));
		}

		public IWebElement LblItemListPriceApos(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id("quoteDetail_SEItem_listPrice_" + lineItemIndex));
		}

		public IWebElement LblItemSellingPriceApos(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id("quoteDetail_SEItem_sellingPrice_" + lineItemIndex));
		}

		public IWebElement LblItemDiscountApos(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id("quoteDetail_SEItem_discount_off_list_" + lineItemIndex));
		}

		public IWebElement LblItemTotalAmountApos(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id("quoteDetail_LI_totalAmount_" + lineItemIndex));
		}

		public IWebElement LblItemTotalTaxApos(int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.Id("quoteDetail_LI_tax_" + lineItemIndex));
		}

		public IWebElement LblQuoteStatusTxt()
		{
			return WebDriver.GetElement(By.Id("quoteDetail_quoteStatus"));
		}

		public IWebElement TxtValidationCustomerStatus()
		{
			return validationCustomerStatus;
		}
		public IWebElement LblItemLevelRenewalPrice(int lineItemIndex = 1)
		{
			return WebDriver.GetElements(By.XPath("//div[contains(@id,'" + PagePrefix + "_LI_Snp_MonthlyPayment')]"))[lineItemIndex - 1];
		}

		public IWebElement LblNonTiedItemLevelRevenuePrice(int lineItemIndex = 1)
		{
			return WebDriver.GetElements(By.XPath("//div[contains(@id,'" + PagePrefix + "_Sku_Snp_RenewalPrice')]"))[lineItemIndex - 1];
		}

		public IWebElement QuoteDetailPageTotalAmount(int lineItemIndex = 0)
		{
			return WebDriver.GetElement(By.Id("quoteDetail_GI_totalAmount_" + lineItemIndex));
		}

		public bool ValidateAutoRenewalWindowOpened()
		{
			bool opened = false;
			foreach (var handle in WebDriver.WindowHandles)
			{
				opened = WebDriver.SwitchTo().Window(handle).Title.Contains("Americas Client Pricing ");
			}

			return opened;
		}
		#endregion

		#region CustomPrice Elements & Actions

		public IWebElement GetCustomPriceNotification(string text)
		{
			return
				WebDriver.FindElement(By.XPath("//*[@id='quoteDetail_quote_Validation']//span[contains(normalize-space(),'" + text + "')]"));
		}
		public IWebElement GetNotification()
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return
				WebDriver.FindElement(By.XPath("//*[@id='quoteDetail_quote_Validation']"));
		}

		public List<IWebElement> LnkExpandItem(int itemIndex, int groupIndex)
		{
			return WebDriver.GetElements(By.Id("toggleMoreLess_" + (groupIndex - 1) + "_" + (itemIndex - 1)));
		}

		public IWebElement ExpandNonTiedConfig(int nonTiedItemIndex, int skuIndex)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_Sku_CS_Item_" + nonTiedItemIndex + "_" + skuIndex));
		}


		public int GetTotalNumberOfConfigurations(int? groupIndex = 0)
		{
			//return WebDriver.GetElements(By.CssSelector("#quoteCreate_LI_CS_grid_1 > div > div")).Count;
			return WebDriver.GetElements(By.XPath(string.Format("//div[@id='quoteDetail_accordion_{0}_0']//table[@class='config-option-sku-table']", groupIndex))).Count;
		}

		public string GetConfigSkuCodeAtGroupAndSku(int? groupIndex = 0, int? lineItemIndex = 0, int? skuCodeIndex = 0)
		{
			//return WebDriver.GetElements(By.CssSelector("#quoteCreate_LI_CS_grid_1 > div > div")).Count;
			return WebDriver.GetElement(By.XPath(string.Format("(//*[@id='lineitem_config_block_{0}_0']//table[@class='config-option-sku-table'])[{1}]//tbody/tr[2]/td[2]", groupIndex, skuCodeIndex))).GetText(WebDriver);

		}

		public IWebElement BtnExpandAllConfiguration(int itemIndex, int groupIndex)
		{
			return WebDriver.GetElement(By.XPath("//div[@id='quoteDetail_accordionMore_" + (itemIndex - 1) + "_" + (groupIndex - 1) + "']//a[text()='Expand All']"));
		}

		public bool CFICommentsFound()//int itemIndex = 0, int groupIndex = 0
		{
			bool commentFound = false;
			WebDriver.FindElement(By.Id("toggleMoreLess_0_0")).Click(WebDriver);
			WebDriver.FindElement(By.XPath("//div[@id='quoteDetail_accordionMore_0_0']//a[text()='Expand All']")).Click(WebDriver);

			//Click comments link

			WebDriver.FindElement(By.XPath("//a[contains(text(),'Configuration Services:')]/parent::div/parent::div/parent::div/parent::div//div[contains(@class,'line-item-details-data ')]//a[contains(text(),'Comments')]")).Click();
			if (WebDriver.GetElement(By.Id("CSComments")).Displayed)
			{
				commentFound = WebDriver.FindElement(By.XPath("//label[contains(@id,'_addCommentTextCode')]")).Text.Contains("test");
			}
			return commentFound;
		}

		public IWebElement SellingPriceOfSku(int groupIndex, int itemIndex, int skuIndex)
		{
			//return WebDriver.GetElement(By.XPath("//*[contains(@id,'quoteCreate_LI_CS_configInfo_build_categoryTable_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (skuIndex - 1) + "')]//span"));
			return WebDriver.GetElement(By.XPath("//*[@id='lineitem_config_block_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "']//table//tr[2]/td[7]/span"));
		}

		public QuoteDetailsPage ExpandItem(int itemIndex = 1, int groupIndex = 1, bool isNonTiedExpandItem = false, int nonTiedItemIndex = 1)
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
			return new QuoteDetailsPage(WebDriver);
		}

		public QuoteDetailsPage ExpandOrCollapseItemConfiguration(int itemIndex = 1, int groupIndex = 1)
		{
			BtnExpandAllConfiguration(itemIndex, groupIndex).Click(WebDriver);
			return new QuoteDetailsPage(WebDriver);
		}
		public QuoteDetailsPage ExpandOrCollapseNonTiedItemConfiguration(int nonTiedItemIndex = 1, int skuIndex = 1)
		{
			ExpandNonTiedConfig(nonTiedItemIndex, skuIndex).Click(WebDriver);
			return new QuoteDetailsPage(WebDriver);
		}

		public bool IsSkuTextBoxHighlightedInRed(int itemIndex = 1, int groupIndex = 1, int skuIndex = 1)
		{
			var editableSku = SellingPriceOfSku(groupIndex, itemIndex, skuIndex);
			if (editableSku.GetAttribute("class").Contains("hlt-chd-sku"))
			{
				return true;
			}
			return false;
		}


		#endregion

		public IWebElement ByItemSummaryModRevenueLabel(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_rawCompRevenue_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"));
		}
		public IWebElement ByItemSummaryModRevenueValue(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_rawCompRevenue_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']"));
		}

		public IWebElement ByItemSummarySPRevenueLabel(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_smartPriceRevenue_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"));
		}
		public IWebElement ByItemSummarySPRevenueValue(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_smartPriceRevenue_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']"));
		}

		public IWebElement ByItemSummaryPricingModifierLabel(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_pricingModifier_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"));
		}
		public IWebElement ByItemSummaryPricingModifierValue(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_pricingModifier_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']"));
		}

		public IWebElement ByItemSummaryServiceIncentiveLabel(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_commModifier_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"));
		}
		public IWebElement ByItemSummaryServiceIncentiveValue(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_commModifier_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']"));
		}

		public IWebElement ByItemSummaryUpSellModRevenueLabel(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_servicesIncentive_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"));
		}
		public IWebElement ByItemSummaryUpSellModRevenueValue(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_servicesIncentive_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/span"));
		}
		public IWebElement ParentServiceTag(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_ParentServiceTag_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']"));
		}

		public IWebElement GetChecklistQuoteORCustomerORPayInfo(string Name)
		{
			return WebDriver.FindElement(By.XPath("//*[text()='" + Name + "']/following::p[1]"));
		}
		public IWebElement GetChecklistCompanyNoORShippingInfo(int groupIndex)
		{
			return WebDriver.FindElement(By.XPath("(//*[text()='Customer Number:']/following::td[1])/following::p[" + groupIndex + "]"));
		}

		public IWebElement GetChecklistBillingInfo(int lineIndex)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='review-checklist']//div[1]/address/div//div[1]/span[" + lineIndex + "]"));
		}
		public IWebElement GetChecklistShippingInfo(int groupIndex, int itemIndex, int lineIndex1, int lineIndex2)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='review-checklist']//div[" + groupIndex + "]//div[" + itemIndex + "]/div[" + lineIndex1 + "]//span[" + lineIndex2 + "]"));
		}

		public IWebElement GetChecklistMarginORCOMName(int groupIndex, int lineIndex)
		{
			return WebDriver.FindElement(By.XPath("//*[@id='review-checklist']//div[" + groupIndex + "]/div[" + lineIndex + "]/p"));
		}

		public IWebElement ItemProductDescriptionQuoteDetails(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_productDescription_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}
		public void UnSelectAllHoldCheckbox()
		{
			var numberOfChkBox = WebDriver.GetElements(quotedetailsCheckboxCollection);
			if (numberOfChkBox != null)
			{
				foreach (var chkBox in numberOfChkBox)
				{
					if (chkBox.Selected)
					{
						chkBox.UnSelectCheckBox(WebDriver);
					}
				}
			}
		}

		public QuoteDetailsPage ViewOriginalQuoteAfterLspPopup()
		{
			BtnLspPopupViewOriginalQuote.Click(WebDriver);
			return new QuoteDetailsPage(WebDriver);
		}

		public QuoteDetailsPage PickGoalDealIdFromListForLineItem(int shippingroup = 1, int itemIndex = 1, string goalDealId = "", int level = 1, string sfdcdeal = "", string enduserAcc = "")
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			LnkItemLevelGoalDealIdPickFromList(shippingroup, itemIndex).Click(WebDriver);
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
			WaitForQuoteValidationToComplete();
			return new QuoteDetailsPage(WebDriver);
		}

		public QuoteDetailsPage PickGoalDealIdFromListForNonTiedItem(int shippingroup = 1, int itemIndex = 1, int nontiedItemindex = 1, string goalDealId = "", int level = 1, string sfdcdeal = "", string enduserAcc = "")
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			LnkNonTiedItemLevelGoalDealIdPickFromList(shippingroup, itemIndex, nontiedItemindex).Click(WebDriver);
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
				WebDriver.GetElement(
						By.XPath("//*[@class='modal-body']//div[@class='accordion-group'][" + level + "]//a[1]"))
					.Click(WebDriver);
			}

			WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_goaldeal_familyorclass_grid']//tbody//tr//td[contains(text(), '" + goalDealId + "')]/..//input")).Click(WebDriver);
			WebDriver.GetElement(By.XPath("//*[@class='btn-bar']//button[normalize-space()='Select']")).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WaitForQuoteValidationToComplete();
			return new QuoteDetailsPage(WebDriver);
		}

		public IWebElement MsgItemLevelDamValidation(int lineItemIndex = 1)
		{

			WebDriver.VerifyBusyOverlayNotDisplayed();
			//var lstwebelements = WebDriver.GetElements(By.XPath("//span[contains(@id,'" + PagePrefix + "_dealValidationErrorMessage_LI')]"), TimeSpan.FromSeconds(20));
			//This is temp fix Ft2 dev is working on element id addition for new DAM message
			var lstwebelements = WebDriver.GetElements(By.XPath("//*[contains(text(),'approval is required')]"),
				TimeSpan.FromSeconds(10));
			if (lstwebelements != null && lstwebelements.Count > 0)
			{
				return lstwebelements[lineItemIndex - 1];
			}
			return null;

		}


		public IWebElement MsgItemLevelDamValidationQty(int lineItemIndex = 1)
		{

			WebDriver.VerifyBusyOverlayNotDisplayed();
			//var lstwebelements = WebDriver.GetElements(By.XPath("//span[contains(@id,'" + PagePrefix + "_dealValidationErrorMessage_LI')]"), TimeSpan.FromSeconds(20));
			//This is temp fix Ft2 dev is working on element id addition for new DAM message
			var lstwebelements = WebDriver.GetElements(By.XPath("//*[contains(text(),'exceeded GOAL Deal discount limits')]"),
				TimeSpan.FromSeconds(10));
			if (lstwebelements != null && lstwebelements.Count > 0)
			{
				return lstwebelements[lineItemIndex - 1];
			}
			return null;

		}


		public IWebElement MsgNonTiedItemLevelDamValidation(int nonTiedItemIndex = 1)
		{
			var lstwebelements =
				WebDriver.GetElements(
					By.XPath("//span[contains(@id,'_sku_dealValidationErrorMessage_LI_NTSKU_')]"), TimeSpan.FromSeconds(30));
			if (lstwebelements != null && lstwebelements.Count > 0)
			{
				return lstwebelements[nonTiedItemIndex - 1];
			}
			return null;
		}


		public IWebElement MsgItemLevelInvalidGoalDealId(int lineItemIndex = 1)
		{
			//var lstwebelements = WebDriver.GetElements(By.XPath("//span[contains(@id,'" + PagePrefix + "_dealValidationErrorMessage_LI')]"), TimeSpan.FromSeconds(10));
			//This is temp fix Ft2 dev is working on element id addition for new DAM message
			var lstwebelements = WebDriver.GetElements(By.XPath("//*[contains(text(),'GOAL Deal is not valid')]"), TimeSpan.FromSeconds(10));
			if (lstwebelements != null && lstwebelements.Count > 0)
			{
				return lstwebelements[lineItemIndex - 1];
			}
			return null;
		}
		public string GetGoalDealIdFromSolutiongroup(int shippingGroupIndex = 1, int solutionGroup = 1)
		{
			return
				WebDriver.GetElement(
						By.Id(PagePrefix + "_GI_info_goalDealId_" + (shippingGroupIndex - 1)))
					.GetText(WebDriver);
		}
		public string GetGoalDealIdFromItem(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return
				WebDriver.GetElement(By.Id(PagePrefix + "_LI_info_goalDealId_" + (shippingGroupIndex - 1) + "_" + (itemIndex - 1)))
					.GetText(WebDriver);
		}

		public string GetGoalDealIdFromNonTiedItem(int shippingGroupIndex = 1, int itemIndex = 1, int nontiedItemIndex = 1)
		{
			return
				WebDriver.GetElement(By.Id(PagePrefix + "_LI_NTSKU_NonTied_info_goalDealId_" + (shippingGroupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nontiedItemIndex - 1))).GetText(WebDriver);
		}

		public QuoteDetailsPage RemoveGoalDealIdFromLineItem(int groupIndex = 1, int itemIndex = 1)
		{
			WebDriver.GetElement(
				By.XPath("//*[@id='" + PagePrefix + "_LI_info_goalDealId_" + (groupIndex - 1) + "_" + (itemIndex - 1) +
						 "']//a")).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return new QuoteDetailsPage(WebDriver);
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

		//getting currency code from Summary
		public string GetCurrencyCodeFromSummary()
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_summary_header_currency']")).GetText(WebDriver);

		}
		//getting currency code from  Final price
		public string GetCurrencyCodeFromFinalPrice()
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_summary_finalPrice']/span")).GetText(WebDriver);
		}

		//getting currency code from  Shipping group one1
		public string GetCurrencyCodeFromShippingGroup1()
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_GI_totalAmount_0']/span/span")).GetText(WebDriver);
		}

		//getting currency code from  Product1
		public string GetCurrencyCodeFromProduct1()
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_LI_totalAmount_0_0']/span/span")).GetText(WebDriver);
		}

		//getting currency code from  Product2
		public string GetCurrencyCodeFromProduct2()
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_LI_totalAmount_0_1']/span/span")).GetText(WebDriver);
		}


		public QuoteDetailsPage SelectQuoteByVersionNo(int version)
		{
			var currentQuoteVersion = new QuoteDetailsPage(WebDriver).CurrentQuoteVersion()[1];
			if (!currentQuoteVersion.Equals(1))
			{
				LblQuoteVersion.Click(WebDriver);
				WebDriver.GetElement(By.XPath("//table/tbody//a[normalize-space()='Version " + version + "']")).Click(WebDriver);
			}

			return new QuoteDetailsPage(WebDriver);
		}
		public QuoteDetailsPage RemoveGoalDealIdFromNontiedItem(int groupIndex = 1, int itemIndex = 1, int nonTiedItemIndex = 1)
		{
			WebDriver.GetElement(
				By.XPath("//*[@id='" + PagePrefix + "_LI_NTSKU_NonTied_info_goalDealId_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" +
						 (nonTiedItemIndex - 1) + "']//a")).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();

			return new QuoteDetailsPage(WebDriver);
		}

		//public QuoteDetailsPage PickGoalDealIdFromListForNonTiedItem(string goalDealId, int groupIndex = 1, int itemIndex = 2, int nonTiedItemIndex = 1, int level = 1)
		//{
		//    //WebDriver.GetElement(By.XPath("//a[contains(@id,'" + PagePrefix + selectGoalDeal + "_LI_NTSKU_selectGoalDealId_0_')]")).Click(WebDriver);
		//    WebDriver.GetElement(By.XPath("//*[@id='" + "goalSel_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedItemIndex - 1) + "']")).Click(WebDriver);
		//    if (level != 1)
		//    {
		//        WebDriver.GetElement(By.XPath("//*[@class='modal-body']//div[@class='accordion-group'][" + level + "]//a[1]")).Click(WebDriver);
		//    }
		//    WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_goaldeal_familyorclass_grid']//tbody//tr//td[contains(text(), '" + goalDealId + "')]/..//input")).Click(WebDriver);
		//    WebDriver.GetElement(By.XPath("//*[@class='btn-bar']//button[normalize-space()='Select']")).Click(WebDriver);
		//    WebDriver.VerifyBusyOverlayNotDisplayed();
		//    WaitForQuoteValidationToComplete();
		//    return new QuoteDetailsPage(WebDriver);
		//}

		public QuoteDetailsPage SubmitDamRequest(string approverMailId, string justification, bool highPriority = false)
		{
			BtnSubmitRequest.Click(WebDriver);
			BtnYesSubmitDamRequest.Click(WebDriver);
			DdlDamApprover.PickDropdownByText(WebDriver, approverMailId);
			if (highPriority)
				ChkDamApprovalPriority.SelectCheckBox(WebDriver);
			TxtDamApprovalJustification.SetText(WebDriver, justification);
			BtnSubmitDamApproval.Click(WebDriver);
			return new QuoteDetailsPage(WebDriver);
		}

		public QuoteDetailsPage ApproveDamRequest(string notes)
		{
			BtnApproveDamRequest.Click(WebDriver);
			TxtDamApprovalNotes.SetText(WebDriver, notes);
			BtnDamApproveDialogApprove.Click(WebDriver);
			return new QuoteDetailsPage(WebDriver);
		}

		public QuoteDetailsPage SubmiteInsuredItemReq(string FusionID, string POMid, string Notes)
		{
			txtFusionID.SetText(WebDriver, FusionID);
			txtPOMID.SetText(WebDriver, POMid);
			txtInsNotes.SetText(WebDriver, Notes);
			btnInsSubmit.Click(WebDriver);
			return new QuoteDetailsPage(WebDriver);
		}

		public QuoteDetailsPage ReassignDamRequest(string reassignMailId, string notes)
		{
			BtnReassignDamRequest.Click(WebDriver);
			DdlDamRequestReassignApprover.PickDropdownByText(WebDriver, reassignMailId);
			TxtDamApprovalNotes.SetText(WebDriver, notes);
			BtnDamApproveDialogReassign.Click(WebDriver);
			return new QuoteDetailsPage(WebDriver);
		}

		public QuoteDetailsPage RejectDamRequest(string notes)
		{
			BtnRejectDamRequest.Click(WebDriver);
			TxtDamApprovalNotes.SetText(WebDriver, notes);
			BtnDamApproveDialogReject.Click(WebDriver);
			return new QuoteDetailsPage(WebDriver);
		}

		public void ClickFinancialInformationToggle()
		{
			FinancialInfoToggle.Click(WebDriver);
		}

		public void SelectQuoteVersion1()
		{
			SelectVersionToggle.Click(WebDriver);
			QuoteVersion1.Click(WebDriver);
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
			if (WebDriver.GetElements(By.XPath("//a[contains(@id,'" + PagePrefix + "_createNewGoalDealId_' +(groupIndex - 1)")).Count != 0 &&
				WebDriver.GetElements(By.XPath("//a[contains(@id,'" + PagePrefix + "_LI_selectGoalDealId_' +(groupIndex - 1)")).Count != 0)
				return true;
			else
				return false;
		}

		public ExportCompliancePage CreateOrder()
		{
			BtnCreateOrder.Click(WebDriver);

			bool btnFound = false;
			try
			{
				btnFound = BtnCreateOderUsingDefaultSalesRep.IsElementClickable(WebDriver, TimeSpan.FromSeconds(5));
				if (btnFound)
					BtnCreateOderUsingDefaultSalesRep.Click(WebDriver);
			}
			catch (Exception ex)
			{

			}

			return new ExportCompliancePage(WebDriver);
		}

		//public QuoteDetailsPage WaitForQuoteValidationToComplete()
		//{
		//    //By by = By.ClassName("inline-busy");
		//    //By by = By.XPath("//*[@data-ng-if='model.isValidating']//img");
		//    //By by = By.XPath("//*[contains(text(),'Validating Quote')]");
		//    By by = By.XPath("//*[@class='inline - busy']/img");

		//    bool elestatus;
		//    do
		//    {
		//        var wait = new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime);
		//        elestatus = wait.Until<bool>(ExpectedConditions.InvisibilityOfElementLocated(by));
		//    } while (elestatus == false);

		//    return new QuoteDetailsPage(WebDriver);
		//}

		public bool IsQuoteValidationElementDisplayed(By loc)
		{
			try
			{
				WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromMilliseconds(50));
				wait.Until(ExpectedConditions.ElementIsVisible(loc));
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		public QuoteDetailsPage WaitForQuoteValidationToComplete()

		{

			for (int i = 0; i <= 2; i++)
			{
				//By oldbyLoc = By.XPath("//*[@class='inline - busy']/img");
				//By oldbyLoc = By.XPath("//div[contains(text(),'Validating Quote')]");
				By oldbyLoc = By.XPath("//span[contains(text(),'Validating Quote')]");

				if (IsQuoteValidationElementDisplayed(oldbyLoc))
				{
					new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime).Until(ExpectedConditions.InvisibilityOfElementLocated(oldbyLoc));

				}

			}
			return new QuoteDetailsPage(WebDriver);

		}

		public void WaitForValidatingAppearAndDisappear()
		{
			WebDriver.WaitForElementVisible(By.XPath("//*[contains(text(),'Validating Quote')]"), TimeSpan.FromSeconds(25));
			var wait = new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime);
			wait.Until<bool>(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[contains(text(),'Validating Quote')]")));
		}

		public void WaitForDashboardIconToDisplay()
		{
			WaitForQuoteValidationToComplete();
			while (!WebDriver.ElementExists(By.Id("customerDetails_dashboard")))
			{
				//Do Nothing 
			}
		}

		public AssociateOpportunityPage AssociateOpportunity()
		{
			MoreActions();
			LnkAssociateOpportunity.Click(WebDriver);
			return new AssociateOpportunityPage(WebDriver);
		}

		public QuoteDetailsPage MoreActions()
		{
			WaitForQuoteValidationToComplete();
			BtnMoreActions.Click(WebDriver);
			return new QuoteDetailsPage(WebDriver);
		}
		public CreateQuotePage CopyQuote(bool newVersion = false)
		{
			if (WebDriver.TryFindElement(QuoteDetailPageCopyQuote, TimeSpan.FromSeconds(5)))
			{
				// read-only quote details page copy quote button
				QuoteDetailPageCopyQuote.Click(WebDriver);
			}
			else
			{
				// Click more actions and perform Copy quote
				if (!newVersion)
					SelectMoreActions(SelectAction.CopyAsNewQuote);
				else
					SelectMoreActions(SelectAction.CopyAsNewVersion);
			}
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WaitForQuoteValidationToComplete();
			return new CreateQuotePage(WebDriver);

		}

		public string[] CurrentQuoteVersion()
		{
			var getQuoteVersion = new QuoteDetailsPage(WebDriver).GetQuoteVersion();
			var quoteVersion = getQuoteVersion.Split(' ');
			//string versionNumber = quoteVersion[1];
			return quoteVersion;
		}



		public void SplitQuote(QuoteSplitType splitBy)
		{
			MoreActions();
			LnkSplitQuote.Click(WebDriver);

			switch (splitBy)
			{
				case QuoteSplitType.Item:
					RdbSplitByItem.Click(WebDriver);
					break;
				case QuoteSplitType.EstimatedDeliveryDate:
					RdbSplitByEdd.Click(WebDriver);
					break;
				case QuoteSplitType.Quantity:
					RdbSplitQuantity.Click(WebDriver);
					break;
				case QuoteSplitType.ShippingLocation:
					RdbSplitShippingLocation.Click(WebDriver);
					break;
				case QuoteSplitType.ShippingMethod:
					RdbSplitShippingMethod.Click(WebDriver);
					break;
				case QuoteSplitType.ShippingGroup:
					RdbSplitShippingGroup.Click(WebDriver);
					break;
			}

			BtnSplitReviewQuotes.Click(WebDriver);
		}

		public SendQuotePage SendQuote(bool isQtoPqto = false)
		{
			BtnSendQuote.Click(WebDriver);
			if (isQtoPqto)
				WebDriver.WaitForElementDisplay(BtnQtoPqtoNotificationOk, TimeSpan.FromSeconds(8));
			BtnQtoPqtoNotificationOk.Click(WebDriver);
			return new SendQuotePage(WebDriver);
		}

		public bool IsCreateOrderBtnEnable()
		{
			return BtnCreateOrder.Enabled;
		}

		public bool IsSendQuoteBtnEnabled()
		{
			return BtnSendQuote.Enabled;
		}

		public string GetSummaryListPrice()
		{
			return Summary.ByLblSummaryListPrice.GetText(WebDriver);
			//return Summary.GetQuoteSummaryValues().ListPrice.ToString(CultureInfo.InvariantCulture);
		}

		public string GetCompanyNumber()
		{
			return LblCustomerNumber.GetText(WebDriver);
		}

		public string GetCustomerNumber()
		{
			return LblCompanyNumber.GetText(WebDriver);
		}

		public string GetCustomerName()
		{
			return LblCustomerName.GetText(WebDriver);
		}

		public void ToggleCustomerInformation()
		{
			CustomerInfoToggle.Click(WebDriver);
		}

		public void SelectMergeQuote()
		{
			MoreActions();
			BtnMergeQuote.Click(WebDriver);
		}

		public bool IsMergeQuoteButtonDisabled()
		{
			return BtnMergeXQuotes.GetAttribute("disabled") == "true";
		}



		public MergeQuotePage ClickMergeQuotes()
		{
			BtnMergeXQuotes.Click(WebDriver);
			return new MergeQuotePage(WebDriver);
		}

		public bool IsMergeCreateQuoteButtonDisabled()
		{
			return WebDriver.GetElement(By.Id("QuoteMerge_continue")).GetAttribute("disabled") == "true";
		}

		public void ClickCancelMergeQuote()
		{
			WebDriver.GetElement(By.Id("QuoteMerge_cancel")).Click(WebDriver);
		}

		public bool IsMergeQuoteLimitDisplayed()
		{
			return WebDriver.GetElement(By.Id("quoteDetail_mergeQuotes_limitExceeded")).GetAttribute("disabled") == "true";
		}

		public void ClickRemoveFromMergePopup(string quoteNumber)
		{
			WebDriver.GetElement(By.Id("QuoteMerge_remove_" + quoteNumber + ".1")).Click(WebDriver);
		}

		public bool VerifyUndoButtonIsDisplayed(string quoteNumber)
		{
			return
				WebDriver.GetElement(By.Id("QuoteMerge_undo_" + quoteNumber + ".1"))
					.GetAttribute("class")
					.Contains("ng-hide");
		}

		public void ClickUndoFromMergePopup(string quoteNumber)
		{
			WebDriver.GetElement(By.Id("QuoteMerge_undo_" + quoteNumber + ".1")).Click(WebDriver);
		}

		public void ClickAddMoreQuotes()
		{
			WebDriver.GetElement(By.Id("mergeQuote_addMore")).Click(WebDriver);
		}

		public void ClickCreateQuoteFromMergeModal()
		{
			WebDriver.GetElement(By.Id("mergeQuote_continue")).Click(WebDriver);
		}

		public void ClickDifferentMasterQuote(string quoteNumber)
		{
			WebDriver.GetElement(By.Id("QuoteMerge_Grid_masterSelect_" + quoteNumber + ".1")).Click(WebDriver);
		}


		public ItemQuoteData GetLineItemUnitValues(int groupIndex = 1, int itemIndex = 1, bool contractCodeRequired = false)
		{
			WaitForQuoteValidationToComplete();
			Logger.Write("Getting Values for Item " + itemIndex + " in Shipping Group " + groupIndex);
			Logger.Write("-------------------------");

			var itemQuoteData = new ItemQuoteData
			{
				ListPrice = LblItemLevelUnitListPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1),
				DiscountOffList = Convert.ToDouble(LblItemLevelDiscountOffList(itemIndex, groupIndex).GetText(WebDriver).Split('%')[0]),
				Discount = Convert.ToDouble(LblItemLevelUnitDiscount(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				SellingPrice = (groupIndex == 2 && itemIndex == 1) ? LblItemLevelUnitSellingPrice(groupIndex).GetText(WebDriver).Substring(1) : LblItemLevelUnitSellingPrice(itemIndex).GetText(WebDriver).Substring(1),
				MarginValue = Convert.ToDouble(LblItemLevelUnitMargin(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				Quantity = int.Parse(LblItemLevelQuantity(itemIndex, groupIndex).GetText(WebDriver)),
				ContractCode = contractCodeRequired ? LblContractCode(itemIndex).GetText(WebDriver) : ""
			};
			//SellingPrice = "$" + ByTxtItemLevelUnitSellingPrice(i).GetText(WebDriver).Replace(",", string.Empty),


			return itemQuoteData;
		}


		public ItemQuoteData GetLineItemUnitValuesWithQuantity(int groupIndex = 1, int itemIndex = 1, bool contractCodeRequired = false)
		{
			WaitForQuoteValidationToComplete();
			Logger.Write("Getting Values for Item " + itemIndex + " in Shipping Group " + groupIndex + "With Quantity");
			Logger.Write("-------------------------");

			var discount = LblItemLevelTotalDiscount(itemIndex, groupIndex).GetText(WebDriver);
			var margin = LblItemLevelMargin(itemIndex, groupIndex).GetText(WebDriver);
			var promotion = LblItemLevelPromotions(itemIndex, groupIndex).GetText(WebDriver);

			var itemQuoteDataWithQuantity = new ItemQuoteData
			{
				ListPrice = LblItemLevelTotalListPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1),
				Discount = Convert.ToDouble(discount.Split('/')[1].Substring(2)),
				DiscountOffList = Convert.ToDouble(discount.Split('/')[0].Substring(0).Split('%')[0]),
				SellingPrice = LblItemLevelTotalSellingPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1),
				Margin = margin,
				MarginValue = Convert.ToDouble(margin.Split('/')[1].Substring(2)),
				MarginPert = Convert.ToDouble(margin.Split('/')[0].Substring(0).Split('%')[0]),
				PromoValue = Convert.ToDouble(promotion.Split('/')[1].Substring(2)),
				PromoPert = Convert.ToDouble(promotion.Split('/')[0].Substring(0).Split('%')[0]),
				ContractCode = contractCodeRequired ? LblContractCode(itemIndex).GetText(WebDriver) : ""
			};

			return itemQuoteDataWithQuantity;
		}

		public ItemSummaryValues GetItemLevelSummary(int groupIndex = 1, int itemIndex = 1)
		{
			WaitForQuoteValidationToComplete();
			Logger.Write("Getting Values for Item Level Summary for Item " + itemIndex + " in Shipping Group " + groupIndex);
			Logger.Write("-------------------------");

			var itemSummary = new ItemSummaryValues
			{
				TotalSellingPrice = Convert.ToDouble(LblItemSummarySellingPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				TotalTax = Convert.ToDouble(LblItemSummaryTax(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				TotalEcoFee = Convert.ToDouble(LblItemSummaryEcoFee(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				TotalAmount = Convert.ToDouble(LblItemSummaryTotalAmount(itemIndex, groupIndex).GetText(WebDriver).Substring(5))
			};

			return itemSummary;
		}


		public ShippingGroupSummary GetShippingGroupSummary(int groupIndex = 1)
		{
			WaitForQuoteValidationToComplete();
			Logger.Write("Getting Values for Shipping Group Summary for group " + groupIndex);
			Logger.Write("-------------------------");

			var shipGroupSummary = new ShippingGroupSummary()
			{
				SubTotal = Convert.ToDouble(LblGroupSummarySubTotal(groupIndex).GetText(WebDriver).Substring(1)),
				TotalShipping = Convert.ToDouble(LblGroupSummaryShippingAmount(groupIndex).GetText(WebDriver).Substring(1)),
				TotalTax = Convert.ToDouble(LblGroupSummaryTax(groupIndex).GetText(WebDriver).Substring(1)),
				TotalEcoFee = Convert.ToDouble(LblGroupSummaryEcoFee(groupIndex).GetText(WebDriver).Substring(1)),
				TotalAmount = Convert.ToDouble(LblGroupSummaryTotalAmount(groupIndex).GetText(WebDriver).Substring(5))
			};

			return shipGroupSummary;
		}


		public ItemQuoteData GetNonTiedItemUnitValues(int groupIndex = 1, int itemIndex = 1, int nonTiedIndex = 1, bool contractCodeRequired = false)
		{
			Logger.Write("Getting Values for Non-Tied Item " + nonTiedIndex + " under Item " + itemIndex + " in Shipping Group " + groupIndex);
			Logger.Write("-------------------------");

			var itemQuoteData = new ItemQuoteData
			{
				DiscountOffList = Convert.ToDouble(LblItemLevelNonTiedDiscountOffList(nonTiedIndex).GetText(WebDriver)),
				ListPrice = LblItemLevelNonTiedUnitListPrice(nonTiedIndex).GetText(WebDriver).Substring(1),
				Discount = Convert.ToDouble(LblItemLevelNonTiedUnitDiscount(nonTiedIndex).GetText(WebDriver).Substring(1)),
				SellingPrice = LblItemLevelNonTiedUnitSellingPrice(nonTiedIndex).GetText(WebDriver),
				Quantity = int.Parse(LblItemLevelNonTiedQuantity(groupIndex, itemIndex, nonTiedIndex).GetText(WebDriver))
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

		public List<ItemQuoteData> GetLineItemValuesArb(int totalNumberOfItems, bool contractCodeRequired = true)
		{
			var lineItems = new List<ItemQuoteData>();

			for (int i = 1; i <= totalNumberOfItems; i++)
			{
				Logger.Write("Getting Values for Item " + i);
				Logger.Write("-------------------------");
				var itemQuoteData = new ItemQuoteData
				{
					SellingPrice = LblItemLevelUnitSellingPrice(i).GetText(WebDriver),
					ContractCode = contractCodeRequired ? LblContractCode(i).GetText(WebDriver) : "",
					FinalPrice = LblItemSummaryTotalAmount(i).GetText(WebDriver),
					TotalShipping = LblItemLevelTotalShipping(i).GetText(WebDriver),
					TaxAmount = LblItemSummaryTax(i).GetText(WebDriver),
					EcoFee = LblItemSummaryEcoFee(i).GetText(WebDriver)
				};

				Logger.Write("-------------------------");

				lineItems.Add(itemQuoteData);
			}

			return lineItems;
		}

		public List<string> GetAllARBbaseConfigValues()
		{

			IList<IWebElement> list = WebDriver.GetElements(By.CssSelector("tbody > tr > td"));
			List<string> baseConfigDetails = new List<string>();
			var total = list.Count;
			if (total >= 3)
			{
				foreach (IWebElement values in WebDriver.GetElements(
					By.CssSelector("tbody > tr > td")))
				{
					baseConfigDetails.Add(values.GetText(WebDriver));


				}

			}
			else
			{
				Assert.Fail("Count did not match");
			}
			return baseConfigDetails;
		}

		public List<ItemQuoteData> GetLineItemValuesApos(int totalNumberOfItems, bool contractCodeRequired = true)
		{
			var lineItems = new List<ItemQuoteData>();

			for (int i = 1; i <= totalNumberOfItems; i++)
			{
				Logger.Write("Getting Values for Item " + i);
				Logger.Write("-------------------------");
				var itemQuoteData = new ItemQuoteData
				{
					ListPrice = LblItemListPriceApos(i).GetText(WebDriver),
					//ContractCode = contractCodeRequired ? LblContractCode(i).GetText(WebDriver) : "",
					//SellingPrice = LblItemSellingPriceApos(i).GetText(WebDriver),
					TaxAmount = LblItemTotalTaxApos(i).GetText(WebDriver),
					FinalPrice = LblItemTotalAmountApos(i).GetText(WebDriver)
				};

				Logger.Write("-------------------------");

				lineItems.Add(itemQuoteData);
			}

			return lineItems;
		}

		public string GetQuoteNumber()
		{
			WaitForQuoteValidationToComplete();
			return LblQuoteNumber.GetText(WebDriver).Trim();
		}
		
		public string GetcopiedfromQuoteNumber()
		{
			WaitForQuoteValidationToComplete();
			return LinkcopiedFromQuote.GetText(WebDriver).Trim();
		}

		public string GetcopiedfromOrderNumber()
		{
			WaitForQuoteValidationToComplete();
			return LinkcopiedFromOrder.GetText(WebDriver).Trim();
		}

		public string GetPOMID()
		{
			WaitForQuoteValidationToComplete();
			return QuoteDetailPagePOMID.GetText(WebDriver).Trim();
		}
		public string GetQuoteVersion()
		{
			return LblQuoteVersion.GetText(WebDriver);
		}

		public string GetQuoteTitle()
		{
			return LblQuoteTitle.GetText(WebDriver);
		}

		public bool QuoteExpiryErrorMesssage()
		{
			return WebDriver.IsElementVisible(WebDriver.GetElement(By.Id("quoteDetail_quoteExpiryErrorMessage")));
		}

		public string GetPremierId()
		{
			return WebDriver.GetElement(By.Id("quoteDetail_premierId")).GetText(WebDriver);
		}

		public string GetPaymentMethodInQuote()
		{
			ClickFinancialInformationToggle();
			return PaymentMethodInQuote.GetText(WebDriver);
		}


		public QuoteFooter OtherInformation
		{
			get
			{
				return new QuoteFooter(WebDriver, PagePrefix);
			}
		}

		public bool CheckForDfsSoftCreditCheck()
		{
			bool found = WebDriver.TryFindElement(LblDfsStatus, new TimeSpan(20));
			return found;
		}

		public IWebElement GroupLevelShippingAddress(int? shippingGroupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_GI_shippingAddress_" + shippingGroupIndex));
		}

		public IWebElement GroupLevelShippingShippingAddressInfo(int? shippingGroupIndex = 0)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_GI_shippingInformation_" + shippingGroupIndex));
		}

		public IWebElement CustomFieldValue(int? index = 0)
		{
			return WebDriver.GetElement(By.Id("customFieldValue_" + index));
		}

		public IWebElement GetGroupLevelShippingMethod(int? groupItemIndex = 0)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_GI_SI_grid_" + groupItemIndex + "']//div[normalize-space()='Shipping Method']/../div[2]"));
		}

		public IWebElement GetNonTiedDescription(int groupItemIndex = 1, int lineItemIndex = 1, int nonTiedIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//span[contains(@id,'productDescription_" + (groupItemIndex - 1) + "_" + (lineItemIndex - 1) + "_" + (nonTiedIndex - 1) + "')]"));
		}

		public IWebElement GetItemDescription(int groupItemIndex = 1, int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//div[contains(@id,'productDescription_" + (groupItemIndex - 1) + "_" + (lineItemIndex - 1) + "')]"));
		}

		public IWebElement GetTAAItemDescription(int groupItemIndex = 1, int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_LI_cssiNumber_" + (groupItemIndex - 1) + "_" + (lineItemIndex - 1) + "']/descendant::span[contains(text(),'TAA')]"));
		}

		public IWebElement GroupLevelManualShippingDiscount(int? shippingGroupIndex = 0)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_GI_SI_grid_" + shippingGroupIndex + "']/quote-detail-shipping-information/quote-detail-shipping-discount/div/div"));
		}

		public IWebElement LblPOLineNumber(int groupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.Id("quoteDetail_LI_poLineNumber_" + (groupIndex - 1) + "_" + (itemIndex - 1)));
		}

		public IWebElement ShippingGroupName()
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_group_0']"));
		}

		public IWebElement ProductGroupName(int index1, int index2)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_LI_productDescription_" + index1 + "_" + index2 + "']"));
		}

		public string GetErrorMessageForMissingOrderCode()
		{
			return WebDriver.FindElement(By.XPath("//div[@class='alert-error']")).Text;

		}
		public string QuotePageModuledescription(IWebDriver WebDriver)
		{
			return WebDriver.FindElement(By.XPath("//div[@id='quoteDetail_quote_Validation']//span[contains(text(),'Requested Module')]")).Text;

		}
		public string QuotePageModuledescriptionItemlevel(IWebDriver WebDriver)
		{
			return WebDriver.FindElement(By.XPath("//div[@id='quoteDetail_item_notifications_0_0']//span[contains(text(),'Requested Module')]")).Text;

		}

		public string DraftquotepageModuledescriptionItemlevel(IWebDriver WebDriver)
		{
			return WebDriver.FindElement(By.XPath("//div[@id='quoteCreate_item_notifications_0_0']//span[contains(text(),'Requested Module')]")).Text;

		}
		public IWebElement LineItemIQNumber(int groupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.Id("quoteDetail_LI_productRsId_" + (groupIndex - 1) + "_" + (itemIndex - 1)));
		}

		public QuoteDetailsPage SubmitGoalLiteRequest(string reasonCode, string busNotes)
		{

			GoalLiteNewRequestLink.Click(WebDriver);
			GoalLiteReasonCode.PickDropdownByText(WebDriver, reasonCode);
			GoalLiteBusCase.SetText(WebDriver, busNotes);
			GoalLiteSubmitReq.Click(WebDriver);
			return new QuoteDetailsPage(WebDriver);
		}

		public QuoteDetailsPage ClickLargeValueHLDChkBox()
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			ChkLargeValueHold.SelectCheckBox(WebDriver);


			return new QuoteDetailsPage(WebDriver);
		}

		public void SelectMoreActions(SelectAction selectAction)
		{
			MoreActions();
			switch (selectAction)
			{
				case SelectAction.CopyAsNewQuote:
					LnkSaveAsNewQuote.Click(WebDriver);
					break;
				case SelectAction.CopyAsNewVersion:
					LnkSaveAsNewVersion.Click(WebDriver);
					break;
				case SelectAction.SplitQuote:
					LnkSplitQuote.Click(WebDriver);
					break;
				case SelectAction.MergeQuote:
					LnkMergeQuote.Click(WebDriver);
					break;
				case SelectAction.CopyRSIQ:
					CopyRSIQ.Click(WebDriver);
					break;
				case SelectAction.CopyStockQuote:
					CopyStockQuote.Click(WebDriver);
					break;
				case SelectAction.CopyPickQuote:
					CopyPickQuote.Click(WebDriver);
					break;
				default:
					Logger.Write("Improper Selection");
					break;
			}
		}
		public string GetPaymentTerms()
		{
			string msg = PaymentTerms.GetText(WebDriver);
			return msg;
		}

		public IWebElement ConfigureLinkAt(int itemIndex = 0, int shippingGrpIndex = 0)
		{
			var eleId = string.Format("quoteCreate_LI_configItem_{0}_{1}", itemIndex.ToString(), shippingGrpIndex.ToString());
			return WebDriver.FindElement(By.Id(eleId));
		}

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

		#region Manualtaxcalc

		public void GetManualTaxStatus(String ManualPending)
		{
			SGTotalTaxPending.GetText(WebDriver).Should().NotContain(ManualPending);
			SGEcoFeePending.GetText(WebDriver).Should().NotContain(ManualPending);
			SGTotalAmountPending.GetText(WebDriver).Should().NotContain(ManualPending);
			SummaryTotalTaxtPending.GetText(WebDriver).Should().NotContain(ManualPending);
			SummaryEcoFeePending.GetText(WebDriver).Should().NotContain(ManualPending);
			SummaryTotalAmountPending.GetText(WebDriver, TimeSpan.FromSeconds(20)).Should().NotContain(ManualPending);
		}

		#endregion

		#region Solutions

		public string GetSolutionID()
		{

			return QuoteDetailsPageSolutionID.GetText(WebDriver);
		}

		public bool VerifyOverrideButtonForValidationMessages()
		{
			bool result = false;
			if (WebDriver.ElementExists(OverrideButtonby) && WebDriver.FindElement(OverrideButtonby).Displayed)
			{
				result = true;
			}
			return result;

		}

		public bool IsOverrideEnabled()
		{
			return !(QuoteDetailsOverrideValidationMessages().FindElement(OverrideButtonby)
					  .GetAttribute("class")
					  .ToLower()
					  .Contains("disabled"));
		}

		public bool VerifyXPODandProductValidationErrorMessages()
		{
			bool result = false;
			WebDriver.VerifyBusyOverlayNotDisplayed();
			DsaUtil.WaitForElement(QuoteDetailsOverrideValidationMessages(), WebDriver);
			if (WebDriver.ElementExists(XPODErrorMessagesby) && WebDriver.ElementExists(ProductValidationErrorMessagesby))
			{
				result = true;
			}
			return result;
		}

		public bool VerifyOnlyXPODErrorMessages()
		{
			bool result = false;
			WaitForQuoteValidationToComplete();
			WebDriver.VerifyBusyOverlayNotDisplayed();
			if (WebDriver.ElementExists(QuoteDetailsOverrideValidationMessagesby))
			{
				IWebElement OverridableXPODerror = QuoteDetailsOverrideValidationMessages().FindElement(ValidationErrorMessagesby);
				if (OverridableXPODerror.Text.ToLower().Equals("xpod status"))
				{
					result = true;
				}

			}
			else if (WebDriver.ElementExists(XPODErrorwithNoOverrideby))
			{
				IWebElement NonOverridableXPODerror = WebDriver.FindElement(XPODErrorwithNoOverrideby);
				if (NonOverridableXPODerror.Text.ToLower().Contains("xpod status"))
				{
					result = true;
				}
			}
			return result;
		}

		public QuoteDetailsPage OverrideXPODAndProductValidationErrors()
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WaitForQuoteValidationToComplete();

			if (QuoteDetailsOverrideValidationMessages() != null)
			{
				if (IsOverrideEnabled())
				{
					QuoteDetailsOverrideValidationMessages().FindElement(OverrideButtonby).Click(WebDriver);
					//DsaUtil.WaitForElement(OverrideValidationDialog.FindElement(OverrideValidationDialogCheckBoxby), WebDriver);
					DsaUtil.WaitForElement(OverrideValidationDialogCheckBoxby_2, WebDriver);
					//OverrideValidationDialog.FindElement(OverrideValidationDialogCheckBoxby).Click(WebDriver);
					OverrideValidationDialogCheckBoxby_2.Click(WebDriver);
					DsaUtil.WaitForElement(OverrideValidationDialogOverrideby_2, WebDriver);
					OverrideValidationDialogOverrideby_2.Click(WebDriver);
				}
			}

			return new QuoteDetailsPage(WebDriver);
		}

		public QuoteDetailsPage PickGoalDealIdFromListForGroupItem(string SolutionId, string GroupIndex_GoalDealId)
		{
			foreach (var GroupIndexwithGoalDealIdAndSelectButtonstate in GroupIndex_GoalDealId.Split('|'))
			{
				string[] GroupIndex = GroupIndexwithGoalDealIdAndSelectButtonstate.Split(',');
				string[] GoalDealIdAndSelectButtonState = GroupIndex[1].Split('~');
				LnkGroupLevelGoalDealIdPickFromList(int.Parse(GroupIndex[0])).Click(WebDriver);
			}

			return new QuoteDetailsPage(WebDriver);
		}

		static bool isValidationPassed = true;
		private object quoteDetailsPage;

		public static bool IsValidationPassed
		{
			get
			{
				return isValidationPassed;
			}

			set
			{
				// if once validation failed we are no more going pass test case.
				if (isValidationPassed)
				{
					isValidationPassed = value;
				}
			}
		}

		public object QuoteDetailPagePOMIDs { get; private set; }

		public bool PickGoalDealIdFromListForGroupItem_VerifySelectedGoalDealID(string SolutionId, string GroupIndex_GoalDealId)
		{
			foreach (var GroupIndexwithGoalDealIdAndSelectButtonstate in GroupIndex_GoalDealId.Split('|'))
			{
				string[] GroupIndex = GroupIndexwithGoalDealIdAndSelectButtonstate.Split(',');
				string[] GoalDealIdAndSelectButtonState = GroupIndex[1].Split('~');
				if (GoalDealIdAndSelectButtonState.Length == 1)
				{
					GoalDealIdAndSelectButtonState = new string[GoalDealIdAndSelectButtonState.Length + 1];
					GoalDealIdAndSelectButtonState[0] = GroupIndex[1];
					GoalDealIdAndSelectButtonState[1] = "true";
				}
				LnkGroupLevelGoalDealIdPickFromList(int.Parse(GroupIndex[0])).Click(WebDriver);

				IsValidationPassed = verifySolutionGroupID(SolutionId, GroupIndex[0], GoalDealIdAndSelectButtonState[0]);
				IsValidationPassed = VerifyPricingDetailsForSelectButtonEnabledOrDisabled(GoalDealIdAndSelectButtonState[0]);
				if (bool.Parse(GoalDealIdAndSelectButtonState[1]) == true)
				{
					WebDriver.GetElements(By.Id("quotecreation_goaldealsGrid_select")).FirstOrDefault(ele => ele.GetAttribute("data-ng-click").Contains(GoalDealIdAndSelectButtonState[0])).Click(WebDriver);
					IsValidationPassed = verifySelectedGoalDealIDAtGroup(GroupIndex[0], GoalDealIdAndSelectButtonState[0]);
				}
				else
				{
					WebDriver.FindElement(By.XPath(".//*[@id='COM']/div[contains(@class,'goal-deal')]/div/div/a")).Click();
				}
			}
			return IsValidationPassed;
		}

		public CreateQuotePage CloseSmartpricePopup()
		{
			WebDriver.GetElements(By.XPath("//button[@class='smp-val-close']"))
				.SingleOrDefault(a => a.Displayed)
				.Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}

		public IWebElement DivSmartpricepopupOnSellingPrice(int itemIndex = 1)
		{
			return
				WebDriver.GetElement(
					By.XPath(@"//button[@class='smp-val-close']/.."));
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

		public bool ItemLevelPickFromListNotDisplayed()
		{
			bool result = true;
			IList<IWebElement> ItemLevelPickFromLists = WebDriver.FindElements(ItemLevelPickFromList);
			for (int i = 0; i < ItemLevelPickFromLists.Count; i++)
			{
				if (ItemLevelPickFromLists[i].Displayed)
				{
					result = false;
					break;
				}
			}
			return result;
		}

		public bool verifySelectedGoalDealIDAtGroup(string groupIndex, string GoalDealID)
		{
			bool result = false;
			WebDriver.Navigate().Refresh();
			DsaUtil.WaitForPageLoad(WebDriver);
			//Thread.Sleep(5000);
			IWebElement GroupLevelGoalDeaID = WebDriver.FindElement(By.XPath(".//div[@id='quoteDetail_GI_info_goalDealId_" + groupIndex + "']/span[contains(text(),'" + GoalDealID + "')]"));
			DsaUtil.WaitForElement(GroupLevelGoalDeaID, WebDriver);
			if (WebDriver.ElementExists(By.XPath(".//div[@id='quoteDetail_GI_info_goalDealId_" + groupIndex + "']/span[contains(text(),'" + GoalDealID + "')]")))
			{
				result = true;
			}
			return result;
		}

		public bool verifySolutionGroupID(string SolutionID, string GroupIndex, string GoalDealId)
		{
			bool result = false;
			int Index = int.Parse(GroupIndex) + 1;
			GroupIndex = Index.ToString();
			SolutionID = SolutionID + "." + GroupIndex;
			string SolutionIDFromGoalDialog = WebDriver.FindElement(By.XPath(".//tbody[tr[td[contains(text(),'" + GoalDealId + "')]]]//tbody/tr/td[1]")).Text;
			if (SolutionID.Equals(SolutionIDFromGoalDialog))
			{
				result = true;
			}
			return result;
		}

		public bool VerifyPricingDetailsForSelectButtonEnabledOrDisabled(string GoalDealID)
		{
			bool result = false;
			string TotalDiscount = GoalDialogTotalDiscountPercent.Text;
			string TotalMargin = GoalDialogTotalMarginPercent.Text;
			string TotalSellingPrice = GoalDialogTotalSellingPrice.Text;
			string Currency = GoalDialogCurreny.Text;
			string ApprovedDiscount = "";
			string ApprovedMargin = "";
			string ApprovedSellingPrice = "";
			string ApprovedCurrency = "";

			IList<IWebElement> TrList = WebDriver.FindElements(By.XPath(".//tbody[tr[td[contains(text(),'" + GoalDealID + "')]]]/tr"));
			for (int i = 1; i <= TrList.Count; i++)
			{
				string GoalDealIDFromPopUp = WebDriver.FindElement(By.XPath(".//tbody[tr[td[contains(text(),'" + GoalDealID + "')]]]/tr[" + i + "]/td[2]")).Text;
				if (GoalDealID.Equals(GoalDealIDFromPopUp))
				{
					int j = i + 1;
					ApprovedDiscount = WebDriver.FindElement(By.XPath(".//tbody[tr[td[contains(text(),'" + GoalDealID + "')]]]/tr[" + j.ToString() + "]/td[2]/table/tbody/tr/td[2]")).Text;
					ApprovedMargin = WebDriver.FindElement(By.XPath(".//tbody[tr[td[contains(text(),'" + GoalDealID + "')]]]/tr[" + j.ToString() + "]/td[2]/table/tbody/tr/td[3]")).Text;
					ApprovedSellingPrice = WebDriver.FindElement(By.XPath(".//tbody[tr[td[contains(text(),'" + GoalDealID + "')]]]/tr[" + j.ToString() + "]/td[2]/table/tbody/tr/td[4]")).Text;
					ApprovedCurrency = WebDriver.FindElement(By.XPath(".//tbody[tr[td[contains(text(),'" + GoalDealID + "')]]]/tr[" + j.ToString() + "]/td[2]/table/tbody/tr/td[5]")).Text;
					break;
				}
			}

			//check for currency - set result
			if (!Currency.ToLower().Equals(ApprovedCurrency.ToLower()))
			{
				result = false;
			}

			if (double.Parse(TotalDiscount) <= double.Parse(ApprovedDiscount) && double.Parse(TotalMargin) >= double.Parse(ApprovedMargin) && double.Parse(TotalSellingPrice) >= double.Parse(ApprovedSellingPrice))
			{
				IList<IWebElement> SelectButtons = WebDriver.FindElements(By.Id("quotecreation_goaldealsGrid_select"));
				foreach (var SelectButtBasedonGoalID in SelectButtons)
				{
					string GoalDealIDFromUIOfselectButton = SelectButtBasedonGoalID.GetAttribute("data-ng-click");
					if (GoalDealIDFromUIOfselectButton.Contains(GoalDealID))
					{
						result = true;
					}
				}
			}
			else if (!WebDriver.ElementExists(By.XPath(".//*[@id='quotecreation_goaldealsGrid_select'][contains(@data-ng-click,'" + GoalDealID + "')]")))
			{

				//select button should be disabled - set result
				result = true;
			}

			return result;

		}

		public bool QuoteDetails_SelectAndVerifyOverridableErrrorsAtEachGroup(string GroupName_ErrorMessageToVerify)
		{
			bool result = false;
			WebDriver.VerifyBusyOverlayNotDisplayed();
			if (WebDriver.ElementExists(DiscountLimitReached))
			{
				WebDriver.FindElement(discountLimitReached_ok).Click();
			}
			foreach (var GroupNameAndErrorMessages in GroupName_ErrorMessageToVerify.Split('|'))
			{
				string[] GroupQuoteNames = GroupNameAndErrorMessages.Split(';');
				string[] GroupErrors = GroupQuoteNames[1].Split(',');
				DsaUtil.WaitForElement(QuoteDetailQuoteName, WebDriver);
				string Quotename = QuoteDetailQuoteName.Text;
				if (!(Quotename.ToLower().Equals(GroupQuoteNames[0].ToLower())))
				{
					IList<IWebElement> GroupQuotesWithQuoteNumber = QuoteDeatilsLinkedQuotesListBox.FindElements(By.TagName("option"));
					foreach (var GroupQuotes in GroupQuotesWithQuoteNumber)
					{
						if (GroupQuotes.Text.ToLower().Contains(GroupQuoteNames[0].ToLower()))
						{
							DsaUtil.PickDropdownByText(QuoteDeatilsLinkedQuotesListBox, WebDriver, GroupQuotes.Text);
							WebDriver.VerifyBusyOverlayNotDisplayed();
							DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
							DsaUtil.WaitForElement(QuoteDetailQuoteName, WebDriver);
							Quotename = QuoteDetailQuoteName.Text;
						}
					}
				}

				DsaUtil.WaitForElement(QuoteDetailQuoteName, WebDriver);
				WaitForQuoteValidationToComplete();
				if (WebDriver.ElementExists(QuoteDetailsOverrideValidationMessagesby))
				{
					IList<IWebElement> ValidationErrors = QuoteDetailsOverrideValidationMessages().FindElements(ValidationErrorMessagesby);
					if (GroupErrors.Length == ValidationErrors.Count)
					{
						for (int i = 0; i < ValidationErrors.Count; i++)
						{
							if (ValidationErrors[i].Text.ToLower().Contains(GroupErrors[i].ToLower()) && QuoteDetailsOverrideValidationMessages().ElementExists(OverrideButtonby) && !(BtnCreateOrder.Enabled))
							{
								if (!(QuoteDetailsOverrideValidationMessages().FindElement(OverrideButtonby).GetAttribute("class").ToLower().Contains("disabled")) && i == ValidationErrors.Count - 1)
								{
									DsaUtil.WaitForElement(QuoteDetailsOverrideValidationMessages().FindElement(OverrideButtonby), WebDriver);
									IJavaScriptExecutor Js = (IJavaScriptExecutor)WebDriver;
									Js.ExecuteScript("scroll(0, -250);");
									QuoteDetailsOverrideValidationMessages().FindElement(OverrideButtonby).Click();
									DsaUtil.WaitForElement(OverrideValidationDialog.FindElement(OverrideValidationDialogCheckBoxby), WebDriver);
									OverrideValidationDialog.FindElement(OverrideValidationDialogCheckBoxby).Click();
									DsaUtil.WaitForElement(OverrideValidationDialog.FindElement(OverrideValidationDialogOverrideby), WebDriver);
									OverrideValidationDialog.FindElement(OverrideValidationDialogOverrideby).Click();
									WebDriver.VerifyBusyOverlayNotDisplayed();
									result = true;
								}

							}
							else
							{
								result = false;
								break;
							}
						}
					}
				}

			}
			return result;
		}

		public bool SelectAndVerifyShippingInstructionsForShipingMethodWithCreatQuoteBtnDisabled(string ShippingInstructionsMessageAtQuoteDetailsPage)
		{
			bool result = false;
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WaitForQuoteValidationToComplete();
			if (ShippingInstructionTextAtQuoteHeader.Text.ToLower().Equals(ShippingInstructionsMessageAtQuoteDetailsPage.ToLower()) && !(BtnCreateOrder.Enabled))
			{
				result = true;
			}
			return result;
		}

		public bool checkCompanyChangeMsg()
		{
			return WebDriver.IsElementVisible(CompanyChangeMsg);
		}
		public QuoteDetailsPage EndCustomerNumber(string EndCustomer)
		{
			TxtEndCustomerNumber.SetText(WebDriver, EndCustomer);
			return new QuoteDetailsPage(WebDriver);
		}

		public void ClickExpandAllConfigurationButtonForSolution()
		{
			WebDriver.ScrollAndClick(
				By.XPath("//[contains(@id, 'toggleMoreLess')]"));
		}

		public IWebElement FindTiedItemsInGroup(int groupIndex = 0, int productIndex = 0)
		{
			var xpath = String.Format("//*[@id='quoteDetail_LI_CS_grid_{0}_{1}']", groupIndex, productIndex);
			return WebDriver.GetElement(By.XPath(xpath));
		}
		public IWebElement LinkedQuoteList(int index)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_LinkedQuotes']/option[" + index + "]"));
		}



		#endregion
		#region APOS

		public string GetServiceTagAtItemLevel()
		{
			WaitForQuoteValidationToComplete();
			ToggleViewMoreOrLess.Click();
			return ToggleViewMoreOrLess.Text;
		}

		#endregion

		#region ValidateDPID

		public CreateQuotePage ValidateEnteredDpid(string dpid)
		{
			LinkedDpid.SetText(WebDriver, dpid);
			WebDriver.WaitForPageLoad();
			return new CreateQuotePage(WebDriver);
		}

		public string GetValidationMessageInQuoteDetailsPage()
		{
			string msg = ValidationMessage.GetText(WebDriver);
			return msg;

		}

		#endregion

		#region Addresses
		public void ClickLnkEditBillToContact()
		{
			var lstElements = WebDriver.GetElements(By.XPath("//*[contains(text(),'Edit')]"));
			lstElements[1].Click(WebDriver);
		}

		public void ClickLnkEditSoldToContact()
		{
			var lstElements = WebDriver.GetElements(By.XPath("//*[contains(text(),'Edit')]"));
			lstElements[3].Click(WebDriver);
		}
		#endregion

		#region ItemValidation
		public IWebElement LnkViewMore(int shippingGroup = 1, int itemIndex = 1)
		{
			return WebDriver.FindElement(By.Id("toggleMoreLess_" + (shippingGroup - 1) + "_" + (itemIndex - 1)));
		}

		public IWebElement LblProductTypeAccordionUnderViewMore(int shippingGroup = 1, int itemIndex = 1)
		{
			//return WebDriver.FindElement(By.XPath(@"//*[@id='quoteDetail_accordionMore_" + (shippingGroup - 1) + "_" + (itemIndex - 1) + "']/div[1]/div[2]/div/div"));
			//return WebDriver.FindElement(By.XPath("//line-item-inventory-information[@ng-reflect-shipment-index='" + (shippingGroup - 1) + "' and @ng-reflect-item-index='" + (itemIndex - 1) + "']/div/div/div[3]/label"));
			return WebDriver.FindElement(By.XPath("//*[contains(@id, '_" + (shippingGroup - 1) + "_" + (itemIndex - 1) + "_label')]"));
		}

		public IWebElement LblOrderCodeUnderViewMore(int shippingGroup = 1, int itemIndex = 1)
		{
			return WebDriver.FindElement(By.Id(PagePrefix + "_LI_orderCode_" + (shippingGroup - 1) + "_" + (itemIndex - 1)));
		}
		public IWebElement LblSkuUnderViewMore(int shippingGroup = 1, int itemIndex = 1)
		{
			return WebDriver.FindElement(By.Id(PagePrefix + "_LI_skuNumber_" + (shippingGroup - 1) + "_" + (itemIndex - 1)));
		}

		public Boolean ValidateOrderAndSku(Dictionary<string, ProductSearchType> products, int shippingIndex = 1)
		{
			int itemIndex = 1;
			bool allitemsFound = true;
			for (int i = 0; i < products.Count; i++)
			{
				LnkViewMore(shippingIndex, itemIndex).Click(WebDriver);
				if (LblProductTypeAccordionUnderViewMore(shippingIndex, itemIndex).GetText(WebDriver).ToLower()
					.Contains("order code"))
				{
					string orderorskuvalue = LblOrderCodeUnderViewMore(shippingIndex, itemIndex).GetText(WebDriver)
						.Trim();

					if (!products.ContainsKey(orderorskuvalue.ToLower().Trim()))
					{
						allitemsFound = false;
						break;
					}
				}
				else
				{
					string orderorskuvalue = LblSkuUnderViewMore(shippingIndex, itemIndex).GetText(WebDriver).Trim();

					if (!products.ContainsKey(orderorskuvalue.ToLower().Trim()))
					{
						allitemsFound = false;
						break;
					}
				}
				LnkViewMore(shippingIndex, itemIndex).Click(WebDriver);
				itemIndex += 1;
			}
			return allitemsFound;
		}

		public Boolean ValidateNonTiedItem(string selectedNontiedItemPrice,
			int shippingIndex = 1, int itemIndex = 1)
		{
			bool nonTiedItemFound = true;
			string nontiedItemPrice = new CreateQuotePage(WebDriver)
				.LblNonTiedListPrice(shippingIndex, itemIndex).GetText(WebDriver).Trim();
			if (nontiedItemPrice.Trim() != selectedNontiedItemPrice.Trim())
			{
				nonTiedItemFound = false;
			}
			return nonTiedItemFound;
		}
		#endregion

		#region EOLNotifications
		public int Get_countof_EOL_notifications(string EOLString)
		{
			string[] notifications = GetNotification().Text.Split('\n');
			var notificationsCnt = 0;
			foreach (var notification in notifications)
			{
				if (notification.Contains(EOLString))
					notificationsCnt++;
			}
			return notificationsCnt;
		}
		#endregion

		public bool CheckQuoteExpiration(string expirationDate)
		{
			string ExpirationDate = LblQuoteExpirationDate.GetText(WebDriver);
			if (ExpirationDate == expirationDate)
				return true;
			return false;
		}

		public int GetCountOfAvailableVersions()
		{
			int count = WebDriver.GetElements(By.XPath("//table/tbody/tr")).Count();
			return (count - 1);
		}




		public string ApplyTlaItemsvaluestxt(int itemIndex)
		{
			return LnkItemLevelTLAtextbox(itemIndex).GetText(WebDriver);
		}

		public IWebElement LnkItemLevelTLAtextbox(int lineItemIndex = 1)
		{
			var lstwebelements = WebDriver.GetElements(By.XPath("//*[contains(@id,'_LI_tla_0_')]/span"), TimeSpan.FromSeconds(10));

			if (lstwebelements != null && lstwebelements.Count > 0)
			{
				return lstwebelements[lineItemIndex - 1];
			}
			return null;
		}

		public string ApplyTlaItemsvaluesinQuotepage(int itemIndex)
		{
			return LnkItemLevelTLAtextvalue(itemIndex).GetText(WebDriver);
		}

		public IWebElement LnkItemLevelTLAtextvalue(int lineItemIndex = 1)
		{
			var lstwebelements = WebDriver.GetElements(By.XPath("//*[contains(@id,'_LI_tla_input_1_')]"), TimeSpan.FromSeconds(10));

			if (lstwebelements != null && lstwebelements.Count > 0)
			{
				return lstwebelements[lineItemIndex - 1];
			}
			return null;
		}

		public void OpenNewTab(string baseUrl)
		{
			IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
			js.ExecuteScript("window.open();");
			WebDriver.SwitchTo().Window(WebDriver.WindowHandles.Last());
			WebDriver.Url = baseUrl;
		}

		public void CopySaveQuote(IWebDriver webDriver, string createdOrderNumber)
		{
			HomeWorkFlow.GoToQuoteSearchPage(webDriver)
			  .QuoteSearchByQuoteNumber(createdOrderNumber)
			  .WaitForQuoteValidationToComplete();

			QuoteDetailsPage quoteDetailsPage = new QuoteDetailsPage(webDriver);
			CreateQuotePage createQuotePage = quoteDetailsPage.CopyQuote(false);
			createQuotePage.SaveQuote();

			WebDriverUtil.VerifyBusyOverlayNotDisplayed(webDriver);

		}

		/// <summary>
		/// Copy Save the Quote and Returns Total Number of Items
		/// </summary>
		/// <param name="webDriver"></param>
		/// <param name="createdOrderNumber"></param>
		/// <returns></returns>
		//public int CopySaveQuoteMultipleItems(IWebDriver webDriver, string createdOrderNumber)
		//{
		//    HomeWorkFlow.GoToQuoteSearchPage(webDriver)
		//      .QuoteSearchByQuoteNumber(createdOrderNumber)
		//      .WaitForQuoteValidationToComplete();

		//    QuoteDetailsPage quoteDetailsPage = new QuoteDetailsPage(webDriver);
		//    CreateQuotePage createQuotePage = quoteDetailsPage.CopyQuote(false);

		//    //int listOfProducts = GetNumberofItems();
		//    createQuotePage.SaveQuote();

		//    WebDriverUtil.VerifyBusyOverlayNotDisplayed(webDriver);
		//    return listOfProducts;
		//}


		public string GetProductItemDescription(IWebDriver webDriver, IWebElement webElement)
		{
			WebDriverUtil.ScrollIntoElement(webDriver, webElement);
			string productItemDescription = webElement.Text;
			return productItemDescription;
		}


		//public bool GetandValidateAddress(IWebElement actualAddress, IWebElement expectedAddress)
		//{
		//    BillToAddressDetail.
		//    return true;
		//}

		#region VP Elements
		public IWebElement ItemLevelserviceListPriceLabel(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_totalListPrice_serviceListPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"), TimeSpan.FromSeconds(10));
		}

		public IWebElement ByLblItemLevelserviceListPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_totalListPrice_serviceListPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement ItemLevelnonServiceListPriceLabel(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_totalListPrice__nonServiceListPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"), TimeSpan.FromSeconds(10));
		}

		public IWebElement ByLblItemLevelnonServiceListPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_totalListPrice__nonServiceListPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement ItemLevelserviceSellingPriceLabel(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_pricingInformation_serviceSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"), TimeSpan.FromSeconds(10));
		}

		public IWebElement ByLblItemLevelserviceSellingPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_pricingInformation_serviceSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public IWebElement ItemLevelnonServiceSellingPriceLabel(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_pricingInformation_nonServiceSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"), TimeSpan.FromSeconds(10));
		}

		public IWebElement ByLblItemLevelnonServiceSellingPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.GetElement(By.Id(PagePrefix + "_LI_pricingInformation_nonServiceSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}

		public ItemQuoteData GetVPLineItemValues(int groupIndex = 1, int itemIndex = 1, bool contractCodeRequired = false)
		{
			//Logger.Write("Getting VP Values for Item " + itemIndex + " in 


			//    Group " + groupIndex);
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

		/// <summary>
		/// Verifies Product Description String Type
		/// </summary>
		/// <param name="expectedProduct"></param>
		/// <param name="actualPrduct"></param>
		/// <param name="webDriver"></param>
		/// <returns></returns>
		public bool CompareProductDesctiption(IWebElement expectedProduct, IWebElement actualPrduct, IWebDriver webDriver)
		{
			bool Ismatching = false;

			if (expectedProduct.Text == actualPrduct.Text)
			{
				Ismatching = true;
			}
			return Ismatching;
		}

		public IWebElement ProductDetailsPage(int shippingGroupIndex = 1, int itemindex = 1)
		{
			shippingGroupIndex = shippingGroupIndex - 1;
			itemindex = itemindex - 1;
			return WebDriver.GetElement(By.Id(string.Format("quoteDetail_LI_productDescription_{0}_{1}", shippingGroupIndex, itemindex)), TimeSpan.FromSeconds(3));
		}

		/// <summary>
		/// Get Products Descriptions
		/// </summary>
		/// <param name="webDriver"></param>
		/// <param name="totalItems"></param>
		/// <returns></returns>
		public IList<string> GetProductsDescription(IWebDriver webdriver, int totalItems, int shippingaddress)
		{
			IList<string> products = new List<string>();

			for (int i = 1; i <= totalItems; i++)
			{
				IWebElement ProductsDetailsEle = ProductDetailsPage(totalItems, shippingaddress);
				CheckIfProductExpanded(webdriver, i);
				IWebElement webElement = ProductsDetailsEle;
				products.Add(webElement.Text);
			}
			return products;
		}

		public void CheckIfProductExpanded(IWebDriver webdriver, int i)
		{
			IWebElement ProductsDetailsEle = ProductDetailsPage(i);

			try
			{
				if (webdriver.FindElement(By.XPath("k-icon k-i-arrow-n")).Displayed == false)
				{
					webdriver.FindElement(By.XPath("btn-group")).Click();
				}
			}
			catch (Exception e)
			{

			}
		}

		#region ProductsUnits

		public IWebElement GetProductElement(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.Id($"quoteDetail_LI_productDescription_{shippingGroupIndex - 1}_{itemIndex - 1}"), TimeSpan.FromSeconds(3));
		}

		public IWebElement UnitListPriceElement(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			shippingGroupIndex = shippingGroupIndex - 1;
			itemIndex = itemIndex - 1;

			return WebDriver.GetElement(By.Id(string.Format("quoteDetail_LI_PI_unitPrice_{0}_{1}", shippingGroupIndex, itemIndex)), TimeSpan.FromSeconds(3));
		}

		public IWebElement UnitDiscountElement(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			shippingGroupIndex = shippingGroupIndex - 1;
			itemIndex = itemIndex - 1;
			return WebDriver.GetElement(By.Id($"quoteDetail_LI_PI_dol_{shippingGroupIndex}_{itemIndex}"), TimeSpan.FromSeconds(3));
		}

		public IWebElement UnitSellingPriceElement(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			shippingGroupIndex = shippingGroupIndex - 1;
			itemIndex = itemIndex - 1;
			return WebDriver.GetElement(By.Id(string.Format("quoteDetail_LI_PI_unitSellingPrice_OC_{0}_{1}", shippingGroupIndex, itemIndex)), TimeSpan.FromSeconds(3));
		}

		public IWebElement ListPriceElement(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			shippingGroupIndex = shippingGroupIndex - 1;
			itemIndex = itemIndex - 1;
			return WebDriver.GetElement(By.Id(string.Format("quoteDetail_LI_totalListPrice_{0}_{1}", shippingGroupIndex, itemIndex)), TimeSpan.FromSeconds(3));
		}

		public IWebElement DiscountElement(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			shippingGroupIndex = shippingGroupIndex - 1;
			itemIndex = itemIndex - 1;
			return WebDriver.GetElement(By.Id(string.Format("quoteDetail_LI_totalDiscountPercent_{0}_{1}", shippingGroupIndex, itemIndex)), TimeSpan.FromSeconds(3));
		}

		public IWebElement SellingPriceElement(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			shippingGroupIndex = shippingGroupIndex - 1;
			itemIndex = itemIndex - 1;
			return WebDriver.GetElement(By.Id(string.Format("quoteDetail_LI_pricingInformation_sellingPrice_{0}_{1}", shippingGroupIndex, itemIndex)), TimeSpan.FromSeconds(3));
		}

		public IWebElement ProductDescriptionNonTiedItem(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			shippingGroupIndex = shippingGroupIndex - 1;
			itemIndex = itemIndex - 1;
			return WebDriver.GetElement(By.Id(string.Format("3_Sku_productDescription_0_{0}_{1}", shippingGroupIndex, itemIndex)), TimeSpan.FromSeconds(3));
		}

		public IWebElement ProductDescriptionConfigItem(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(string.Format("3_Sku_productDescription_0_{0}_{1}", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(3));
		}

		public IWebElement UnitListPriceNonTiedItem(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(string.Format("3_Sku_PI_unitPrice_0_{0}_{1}", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(3));
		}

		public IWebElement UnitDiscountNonTiedItem(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(string.Format("3_Sku_PI_dol_0_{0}_{1}", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(3));
		}

		public IWebElement UnitSellingPriceNonTiedItem(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(string.Format("3_Sku_PI_unitSellingPrice_0_{0}_{1}", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(3));
		}

		public IWebElement ListPriceNonTiedItem(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.Id(string.Format("3_totalListPrice_0_{0}_{1}", shippingGroupIndex - 1, itemIndex - 1)), TimeSpan.FromSeconds(3));
		}
		#endregion


		public IList<string> GetAllQuoteProductsUnitPrices(IWebDriver webdriver, int totalItems, bool GetunitListPrice, bool GetunitDiscount, bool GetunitSellingPrice, int shippingAddress = 0, int itemIndex = 0, bool finalPrice = true)
		{
			IList<string> unitQuotePricing = new List<string>();

			for (int i = 0; i < totalItems; i++)
			{
				if (GetunitListPrice)
				{
					IWebElement unitListPriceEle = UnitListPriceElement(shippingAddress, itemIndex);
					string actualListPrice = unitListPriceEle.Text;
					actualListPrice = Regex.Replace(actualListPrice, @"[^\d]", "");
					unitQuotePricing.Add(actualListPrice);
				}

				if (GetunitDiscount)
				{
					IWebElement unitDiscountEle = UnitDiscountElement(shippingAddress, itemIndex);
					string actualDiscountPrice = unitDiscountEle.Text;
					actualDiscountPrice = Regex.Replace(actualDiscountPrice, @"[^\d]", "");
					unitQuotePricing.Add(actualDiscountPrice);
				}

				if (GetunitSellingPrice)
				{
					IWebElement UnitSellingPriceEle = UnitSellingPriceElement(shippingAddress, itemIndex);
					string actualunitSellingPrice = UnitSellingPriceEle.Text;
					actualunitSellingPrice = Regex.Replace(actualunitSellingPrice, @"[^\d]", "");
					unitQuotePricing.Add(actualunitSellingPrice);
				}
			}

			if (finalPrice)
			{
				string finalprice = FinalPrice.Text;
				string actualfinalPrice = Regex.Replace(finalprice, @"[^\d]", "");
				unitQuotePricing.Add(actualfinalPrice);

			}

			return unitQuotePricing;
		}

		/// <summary>
		/// Compare Quote Details Items and Products with Order Details PRoducts and Items
		/// </summary>
		/// <param name="webdriver"></param>
		/// <param name="totalItems"></param>
		/// <param name="email"></param>
		/// <param name="getunitlistPrice"></param>
		/// <param name="getUnitDiscout"></param>
		/// <param name="getSellingPrice"></param>
		/// <param name="paymentMethod"></param>
		/// <returns></returns>
		public bool CompareQuoteOrderDetailsProductItems(IWebDriver webdriver, int totalItems, string email, bool getunitlistPrice, bool getUnitDiscout, bool getSellingPrice, PaymentMethodType paymentMethod, int shippingAddress = 1, int itemIndex = 1)
		{
			bool IsMatching = false;

			IList<string> allQuoteDetailsAllProducts = GetProductsDescription(webdriver, totalItems, shippingAddress);
			IList<string> allQuoteDetailsPrices = GetAllQuoteProductsUnitPrices(webdriver, totalItems, getunitlistPrice, getUnitDiscout, getSellingPrice, shippingAddress, itemIndex, getSellingPrice);

			//new QuoteDetailsPage(webdriver).SendQuote().SendQuote(email).ReturnToQuoteDetails();
			CreateOrderWorkflow.CreateOrderTillPaymentPage(webdriver);
			CreateOrderWorkflow.EnterPaymentData(webdriver, 1, paymentMethod).PaymentMethodNext();
			OrderDetailsPage orderDetailsPage = new OrderReviewPage(webdriver).SaveOrder();

			Logger.Write("customer is on Order Details Page verify Expected Address");
			WebDriverUtil.VerifyBusyOverlayNotDisplayed(webdriver);

			Logger.Write("Get all Products Description on Order Page");
			IList<string> allOrderDetailsAllProducts = orderDetailsPage.GetAllProductsDescription(webdriver, itemIndex);
			IList<string> allOrderDetailsPrices = orderDetailsPage.GetAllOrderProductsUnitPrices(webdriver, totalItems, getunitlistPrice, getUnitDiscout, getSellingPrice);

			Logger.Write("compare both the lists");
			bool isProductMatching = !allQuoteDetailsAllProducts.Except(allOrderDetailsAllProducts).Any();
			bool isUnitPricingMatching = !allQuoteDetailsPrices.Except(allOrderDetailsPrices).Any();

			if (isProductMatching == true && isUnitPricingMatching == true)
			{
				IsMatching = true;
			}

			return IsMatching;
		}

		public void CompareAllProductLineItemsQuoteDetailstoOrderDetails(IWebDriver webDriver)
		{
			QuoteDetailsPage quoteDetailsPage = new QuoteDetailsPage(webDriver);
			IList<ProductUnitObjects> LineProduct1 = quoteDetailsPage.GetLineProductTiedItemUnitItems(webDriver, 0);
			IList<ProductUnitObjects> LineProduct2 = quoteDetailsPage.GetLineProductTiedItemUnitItems(webDriver, 1);
		}
		#endregion

		public void WaitforUploadPOToPOMPopupToDisplay()
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WebDriver.VerifyBusyOverlayNotDisplayed();
			By ExistCreateNew = By.Id("quoteDetail_new_pomIdRequest_createNew");
			By CreateNew = By.Id("quoteDetail_pomFileUpload_chooseFile");
			try
			{
				if (WebDriver.ElementExists(ExistCreateNew))
				{
					Logger.Write("There are existing POM ids to use - clicking on Create new POM id");
					ExistCreateNew.Click(WebDriver);
					WebDriver.VerifyBusyOverlayNotDisplayed();
				}
				else if (WebDriver.ElementExists(CreateNew))
				{
					Logger.Write("There are no existing POM ids to use");
				}
			}
			catch (Exception e)
			{
				Logger.Write(e.Message);
			}
		}

		public void SalesRepMismatchPopup()
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			Thread.Sleep(3000);
			By salesRep = By.XPath("//primary-salesrep-mismatch//button[2]");

			try
			{
				if (WebDriver.ElementExists(salesRep))
				{
					Logger.Write("Sales rep mismatch pop up is displayed");
					salesRep.Click(WebDriver);
					WebDriver.VerifyBusyOverlayNotDisplayed();
				}
				else
				{
					Logger.Write("Sales rep mismatch pop up is not displayed");
				}
			}
			catch (Exception e)
			{
				Logger.Write(e.Message);
			}
		}


		/// <summary>
		/// Compare Quote Details Items and Products with Order Details PRoducts and Items
		/// </summary>
		/// <param name="webdriver"></param>
		/// <param name="totalItems"></param>
		/// <param name="email"></param>
		/// <param name="getunitlistPrice"></param>
		/// <param name="getUnitDiscout"></param>
		/// <param name="getSellingPrice"></param>
		/// <param name="paymentMethod"></param>
		/// <returns></returns>
		public bool CompareQuoteDetailsWithOrderDetails(IWebDriver webdriver, int totalItems, string email, bool getunitlistPrice, bool getUnitDiscout, bool getSellingPrice, PaymentMethodType paymentMethod, int shippingAddressIndex = 0, int itemindex = 0)
		{
			bool IsMatching = false;

			IList<string> allQuoteDetailsAllProducts = GetProductsDescription(webdriver, totalItems, shippingAddressIndex);
			IList<string> allQuoteDetailsPrices = GetAllQuoteProductsUnitPrices(webdriver, totalItems, getunitlistPrice, getUnitDiscout, getSellingPrice, shippingAddressIndex, itemindex, getSellingPrice);

			SendQuoteSaveOrder(webdriver, email, paymentMethod);

			Logger.Write("customer is on Order Details Page verify Expected Address");
			WebDriverUtil.VerifyBusyOverlayNotDisplayed(webdriver);

			Logger.Write("Get all Products Description on Order Page");
			OrderDetailsPage orderDetailsPage = new OrderDetailsPage(webdriver);
			IList<string> allOrderDetailsAllProducts = orderDetailsPage.GetAllProductsDescription(webdriver, totalItems);
			IList<string> allOrderDetailsPrices = orderDetailsPage.GetAllOrderProductsUnitPrices(webdriver, totalItems, getunitlistPrice, getUnitDiscout, getSellingPrice);

			Logger.Write("compare both the lists");
			bool isProductMatching = !allQuoteDetailsAllProducts.Except(allOrderDetailsAllProducts).Any();
			bool isUnitPricingMatching = !allQuoteDetailsPrices.Except(allOrderDetailsPrices).Any();

			if (isProductMatching == true && isUnitPricingMatching == true)
			{
				IsMatching = true;
			}

			return IsMatching;
		}

		public void SendQuoteSaveOrder(IWebDriver webdriver, string email, PaymentMethodType paymentMethod)
		{
			CreateOrderWorkflow.CreateOrderTillPaymentPage(webdriver);
			CreateOrderWorkflow.EnterPaymentData(webdriver, 1, paymentMethod).PaymentMethodNext();
			OrderDetailsPage orderDetailsPage = new OrderReviewPage(webdriver).SaveOrder();
		}

		/// <summary>
		/// Products Index Starts with 0 and Sku index starts with 1
		/// </summary>
		/// <param name="productIndex"></param>
		/// <param name="skuindex"></param>
		/// <returns></returns>
		public IWebElement GetProductModules(string productTitle, string moduleTitle)
		{
			return WebDriver.GetElement(By.XPath($"//span[text() = '{productTitle + " "}']//following::span[text() = '{moduleTitle + " "}']"), TimeSpan.FromSeconds(3));
		}

		/// <summary>
		/// Verify that the Submodules has been attached to Product Correctly
		/// </summary>
		/// <param name="productTitle"></param>
		/// <param name="moduleTitle"></param>
		/// <returns></returns>
		public bool VerifySubModuleAttachedToProduct(string productTitle, string moduleTitle)
		{
			bool subModules = false;

			try
			{
				if (GetProductModules(productTitle, moduleTitle).Displayed)
				{
					subModules = true;
				}
			}
			catch (Exception e)
			{
				Logger.Write("The Module has not been attached to the Product");
			}
			return subModules;
		}

		///// <summary>
		///// subProductTitle = Product Title, subProductIndex starts with '0'(zero)
		///// </summary>
		///// <param name="webDriver"></param>
		///// <param name="subProductTitle"></param>
		///// <param name="subProductIndex"></param>
		//public IList<string> GetModuleProductUnits(IWebDriver webDriver, string moduleTitle, int subProductIndex)
		//{
		//    IList<string> unitItems = new List<string>();
		//    string unitListPriceText = webDriver.FindElement(By.XPath($"//span[text() = '{moduleTitle + " "}']//following::div[@id = '3_Sku_PI_unitPrice_0_0_1']")).GetText(webDriver, TimeSpan.FromSeconds(2));
		//    string unitDiscountText = webDriver.FindElement(By.XPath($"//span[text() = '{moduleTitle + " "}']//following::div[@id = '3_Sku_PI_dol_0_0_{subProductIndex}']")).GetText(webDriver, TimeSpan.FromSeconds(2));
		//    unitItems.Add(unitListPriceText);
		//    unitItems.Add(unitDiscountText);
		//    return unitItems;
		//}

		/// <summary>
		/// nonTideProductTitle is Text Based,  index starts with Zero for nonTiedItem
		/// </summary>
		/// <param name="webDriver"></param>
		/// <param name="nonTideProductTitle"></param>
		/// <param name="index"></param>
		/// <returns></returns>
		public IList<string> GetNonTideUnits(IWebDriver webDriver, string nonTideProductTitle, int index)
		{
			IList<string> unitItems = new List<string>();

			string unitListPriceText = webDriver.FindElement(By.XPath($"//span[text() = '{nonTideProductTitle + " "}']//following::div[@id = '3_Sku_PI_unitPrice_0_0_{index}']")).GetText(webDriver, TimeSpan.FromSeconds(2));
			string unitDiscountText = webDriver.FindElement(By.XPath($"//span[text() = '{nonTideProductTitle + " "}']//following::div[@id = '3_Sku_PI_dol_0_0_{index}']")).GetText(webDriver, TimeSpan.FromSeconds(2));
			string unitSellingPriceText = webDriver.FindElement(By.XPath($"//span[text() = '{nonTideProductTitle + " "}']//following::div[@id = '3_Sku_PI_unitSellingPrice_0_0_{index}']")).GetText(webDriver, TimeSpan.FromSeconds(2));
			unitItems.Add(unitListPriceText);
			unitItems.Add(unitDiscountText);
			unitItems.Add(unitSellingPriceText);
			return unitItems;
		}

		public void GetProductandTiedItems(IWebDriver webDriver, string product, string nonTiedProduct, int getItems, bool isTiedItem = true, int shippingAddress = 0)
		{
			for (int i = 0; i <= getItems; i++)
			{
				IList<string> parentProducts = GetProductsDescription(webDriver, getItems, shippingAddress);

				if (isTiedItem)
				{
					IList<string> nonTiedUnits = GetNonTideUnits(webDriver, nonTiedProduct, i);

					parentProducts.Concat(nonTiedUnits);
				}
			}
		}

		public IList<ProductUnitObjects> GetProductandUnitItems(IWebDriver webDriver, int shippingIndex = 0, int itemIndex = 0)
		{
			WebDriverUtil.VerifyBusyOverlayNotDisplayed(webDriver);
			string productTitle = GetProductElement(shippingIndex, itemIndex).Text;
			string unitListPrice = UnitListPriceElement(shippingIndex, itemIndex).GetText(webDriver);
			string unitDiscount = UnitDiscountElement(shippingIndex, itemIndex).GetText(webDriver);
			string unitSellingPrice = UnitSellingPriceElement(shippingIndex, itemIndex).GetText(webDriver);
			string listPrice = ListPriceElement(shippingIndex, itemIndex).GetText(webDriver);
			string finalPrice = FinalTotalPrice.Text.Trim();
			finalPrice = Regex.Replace(finalPrice, @"[^\d]", "");

			var items = new List<ProductUnitObjects>();
			items.Add(new ProductUnitObjects
			{
				ProductTitle = productTitle,
				UnitListPrice = unitListPrice,
				UnitDiscount = unitDiscount,
				ListPrice = listPrice,

			});

			return items;
		}

		public IList<ProductUnitObjects> GetLineProductTiedItemUnitItems(IWebDriver webDriver, int shippingAddress = 0, int itemIndex = 0)
		{
			string productTitle = ProductDescriptionNonTiedItem(itemIndex).GetText(webDriver);

			string unitListPrice = UnitListPriceNonTiedItem(shippingAddress, itemIndex).GetText(webDriver);
			string unitDiscount = UnitDiscountNonTiedItem(shippingAddress, itemIndex).GetText(webDriver);
			string unitSellingPrice = UnitSellingPriceNonTiedItem(shippingAddress, itemIndex).GetText(webDriver);
			string listPrice = ListPriceNonTiedItem(shippingAddress, itemIndex).GetText(webDriver);

			var items = new List<ProductUnitObjects>();
			items.Add(new ProductUnitObjects
			{
				ProductTitle = productTitle,
				UnitListPrice = unitListPrice,
				UnitDiscount = unitDiscount,
				ListPrice = listPrice,
			});

			return items;
		}

		public string ExtractText(IWebDriver webdriver, IWebElement webElement)
		{
			WebDriverUtil.ScrollAndClickByElement(webdriver, webElement);
			string actualListPrice = webElement.GetText(webdriver);
			actualListPrice = Regex.Replace(actualListPrice, @"[^\d]", "");
			return actualListPrice;
		}

		#region Product&Units

		public IWebElement ProductsDescription(int itemindex)
		{
			return WebDriver.GetElement(By.XPath($"(//span[contains(@id, 'quoteDetail_LI_productDescription')])[{itemindex}]"));
		}

		public IWebElement ProductName(int index1, int index2)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_LI_productDescription_" + index1 + "_" + index2 + "]"));
		}

		public IWebElement ProductUnitListPrice(int itemindex)
		{
			return WebDriver.GetElement(By.XPath($"(//span[contains(@id, 'quoteDetail_LI_productDescription')]//following::div[contains(@id, 'quoteDetail_LI_PI_unitPrice')])[{itemindex}]"));
		}


		public IWebElement ProductUnitDiscount(int itemindex)
		{
			return WebDriver.GetElement(By.XPath($"(//span[contains(@id, 'quoteDetail_LI_productDescription')]//following::div[contains(@id, 'quoteDetail_LI_PI_dol_')])[{itemindex}]"));
		}

		public IWebElement ProductUnitSellingPrice(int itemindex)
		{
			return WebDriver.GetElement(By.XPath($"(//span[contains(@id, 'quoteDetail_LI_productDescription')]//following::div[contains(@id, 'quoteDetail_LI_PI_unitSellingPrice_')])[{itemindex}]"));
		}

		public IWebElement ProductListPrice(int itemindex)
		{
			return WebDriver.GetElement(By.XPath($"(//span[contains(@id, 'quoteDetail_LI_productDescription')]//following::div[contains(@id, 'quoteDetail_LI_totalListPrice_')])[{itemindex}]"));
		}
		#endregion

		#region LineItemProducts
		public IWebElement LineItemProductDescription(int itemindex)
		{
			return WebDriver.GetElement(By.XPath($"(//span[contains(@id, '3_Sku_productDescription')])[{itemindex}]"));
		}

		public IWebElement LineItemUnitListPrice(int itemindex)
		{
			return WebDriver.GetElement(By.XPath($"(//span[contains(@id, '3_Sku_productDescription')]//following::div[contains(@id, '3_Sku_PI_unitPrice')])[{itemindex}]"));
		}

		public IWebElement LineItemUnitDiscount(int itemindex)
		{
			return WebDriver.GetElement(By.XPath($"(//span[contains(@id, '3_Sku_productDescription')]//following::div[contains(@id, '3_Sku_PI_dol_')])[{itemindex}]"));
		}

		public IWebElement LineItemUnitSellingPrice(int itemindex)
		{
			return WebDriver.GetElement(By.XPath($"(//span[contains(@id, '3_Sku_productDescription')]//following::div[contains(@id, '3_Sku_PI_unitSellingPrice_')])[{itemindex}]"));
		}

		public IWebElement LineItemListPrice(int itemindex)
		{
			return WebDriver.GetElement(By.XPath($"(//span[contains(@id, '3_Sku_productDescription')]//following::div[contains(@id, '3_totalListPrice_')])[{itemindex}]"));
		}
		#endregion

		/// <summary>
		/// Gets all Product Description and Units
		/// </summary>
		/// <returns></returns>
		public IList<ProductUnitObjects> GetAllProductsUnits(bool getProducts = true, bool getLineItems = true)
		{
			var items = new List<ProductUnitObjects>();

			if (getProducts == true)
			{
				IList<IWebElement> allProducts = WebDriver.FindElements(By.XPath("(//span[contains(@id, 'quoteDetail_LI_productDescription')])"));

				for (int i = 1; i <= allProducts.Count; i++)

					items.Add(new ProductUnitObjects
					{
						ProductTitle = ProductsDescription(i).Text,
						UnitListPrice = ProductUnitListPrice(i).Text,
						UnitDiscount = ProductUnitDiscount(i).Text,
						ListPrice = ProductListPrice(i).Text,
					});
			}

			if (getLineItems == true)
			{
				IList<IWebElement> allLineItems = WebDriver.FindElements(By.XPath("//span[contains(@id, '3_Sku_productDescription')]"));

				for (int i = 1; i <= allLineItems.Count; i++)
					items.Add(new ProductUnitObjects
					{
						ProductTitle = LineItemProductDescription(i).Text,
						UnitListPrice = LineItemUnitListPrice(i).Text,
						UnitDiscount = LineItemUnitDiscount(i).Text,
						ListPrice = LineItemUnitListPrice(i).Text,
					});
			}
			return items;
		}

		public QuoteDetailsPage WaitForValidatingQuoteToDisappear()
		{
			for (int i = 0; i <= 2; i++)
			{
				By validateQuote = By.XPath("//span[contains(text(),'Validating Quote')]");
				By saveQuote = By.XPath("//p[contains(text(),'Save Quote')]");

				if (WebDriver.ElementExists(validateQuote) || WebDriver.ElementExists(saveQuote))
				{
					new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime).Until(ExpectedConditions.InvisibilityOfElementLocated(validateQuote));
				}
			}
			return new QuoteDetailsPage(WebDriver);
		}

		public void WaitForUploadPOLinkToDisplayAndClick()
		{
			By uploadPo = By.Id("quoteDetail_sendPoRequest");
			if (!WebDriver.ElementExists(uploadPo))
			{
				new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime).Until(ExpectedConditions.ElementIsVisible(uploadPo));
			}
			else
			{
				uploadPo.Click(WebDriver);
			}
		}

		public bool IsErrorNotificationExist(IWebDriver webDriver, string errorNotificationMeassage)
		{
			bool isExist = false;
			IList<IWebElement> quoteDetailErrorNotificationsList = WebDriver.FindElements(By.XPath("//div[@id='quoteDetail_quote_Validation']//div[@class='alert-error']//span"));
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

		public void TagSalesRep(string salesRepId, bool firstTag = true)
		{
			if (firstTag)
			{
				TagSalesRepButton.Click();
			}
			TagSalesRepInput.Set(salesRepId);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			TagSalesRepAddButton.Click();
		}

		public OrderChecklist GetReviewChecklistValues()
		{
			var values = new OrderChecklist();
			Logger.Write("Getting All the Values From Review Checklist Flyout");

			string Quote_Number = "Quote Number:";
			string Quote_Expiration = "Quote Expiration:";
			string Original_Quote = "Original Quote Number:";
			string PO_Number = "PO Number:";
			string POM_ID = "POM ID:";
			string End_Customer = "End User Customer Number:";
			string Payment_Method = "Payment Method:";
			string Payment_Terms = "Payment Terms:";
			string Primary_Sales_Rep = "Primary Sales Rep:";
			string Tag_Sales_Rep = "Tag Sales Reps:";

			values.QuoteNumber = GetChecklistQuoteORCustomerORPayInfo(Quote_Number).GetText(WebDriver);
			values.OriginalQuoteNumber = GetChecklistQuoteORCustomerORPayInfo(Original_Quote).GetText(WebDriver);
			values.POMNumber = GetChecklistQuoteORCustomerORPayInfo(POM_ID).GetText(WebDriver);
			values.PoNumber = GetChecklistQuoteORCustomerORPayInfo(PO_Number).GetText(WebDriver);
			values.QuoteExpiration = GetChecklistQuoteORCustomerORPayInfo(Quote_Expiration).GetText(WebDriver);
			values.TagSalesRep = GetChecklistQuoteORCustomerORPayInfo(Tag_Sales_Rep).GetText(WebDriver);
			values.EndCustomerNumber = GetChecklistQuoteORCustomerORPayInfo(End_Customer).GetText(WebDriver);
			values.PaymentMethod = GetChecklistQuoteORCustomerORPayInfo(Payment_Method).GetText(WebDriver);
			values.PaymentTerms = GetChecklistQuoteORCustomerORPayInfo(Payment_Terms).GetText(WebDriver);
			values.PrimarySalesRep = GetChecklistQuoteORCustomerORPayInfo(Primary_Sales_Rep).GetText(WebDriver);

			values.CompanyNumber = GetChecklistCompanyNoORShippingInfo(7).GetText(WebDriver);
			values.CustomerNumber = GetChecklistCompanyNoORShippingInfo(8).GetText(WebDriver);
			values.ShippingInstruction = GetChecklistCompanyNoORShippingInfo(16).GetText(WebDriver);
			values.ShippingMethod = GetChecklistCompanyNoORShippingInfo(17).GetText(WebDriver);
			values.MustArriveDate = GetChecklistCompanyNoORShippingInfo(18).GetText(WebDriver);

			values.Margin = GetChecklistMarginORCOMName(4, 4).GetText(WebDriver);
			values.CompanyName = GetChecklistMarginORCOMName(2, 1).GetText(WebDriver);

			values.TotalCost = ChecklistTotalCost.GetText(WebDriver);
			values.InstallationInstructions = ChecklistInstallationInstructions.GetText(WebDriver);

			values.BillingCompanyName = GetChecklistBillingInfo(1).GetText(WebDriver);
			values.BillingAddress = GetChecklistBillingInfo(2).GetText(WebDriver);

			values.ShippingAddress = GetChecklistShippingInfo(1, 2, 2, 2).GetText(WebDriver);
			values.ShippingContactName = GetChecklistShippingInfo(3, 2, 1, 2).GetText(WebDriver);
			values.ShippingContactEmail = GetChecklistShippingInfo(3, 2, 1, 3).GetText(WebDriver);
			values.ShippingContactPhone = GetChecklistShippingInfo(3, 2, 1, 4).GetText(WebDriver);
			values.SalesRepEmail = GetChecklistShippingInfo(2, 4, 1, 2).GetText(WebDriver);
			values.SalesRepPhone = GetChecklistShippingInfo(2, 4, 1, 3).GetText(WebDriver);

			return values;
		}



		public IWebElement DTCPSummaryDiscountPercentQuoteDetails()
		{
			return WebDriver.GetElement(By.Id("quoteDetail_summary_discountPercent"));
		}

		public bool DTCPVerifyDiscountQuoteDetails(string discountPercent)
		{
			string SummarydiscPert = DTCPSummaryDiscountPercentQuoteDetails().GetText(WebDriver);
			if (SummarydiscPert.Contains(discountPercent))
				return true;
			else
				return false;
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

		public String GetItemLevelNotification(int groupIndex = 1, int itemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_item_notifications_" + (groupIndex - 1) + "_" + (groupIndex - 1) + "']/div/span")).Text;

		}

		//div[@class='item-details']//div[@id='errorNotification']//span


		//*********************Digital Fulfilment *************************        

		public IWebElement DigitalFulfillmentEmail_Expanded() => WebDriver.GetElement(By.XPath("//digital-fulfillment-email/div/div[1]"));

		public IList<IWebElement> DF_Emails() => WebDriver.GetElements(By.Id("email_value_0"));

		public EmailConfirmationPage EmailAcknowledgement(QuoteDetailsPage quoteDetails, string sendTo = "com_qe@dell.com", string attachmentType = "PDF Attachment")
		{
			var exportCompliancePage = quoteDetails.CreateOrder();
			var emailConfPage = exportCompliancePage.WillNotExportOutsideUs();
			//emailConfPage.ProcessOrderEmailAcknowledgement(attachmentType, sendTo);
			return emailConfPage;
		}

		//*****************************************************************

		#region F5 DD
		public IWebElement DeploymentServiceToggle(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.FindElement(By.Id(PagePrefix + "_CL_service_toggle_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
		}
		public IWebElement ByHardwareListPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			//return WebDriver.FindElements(By.XPath("//*[@id='AddRecommendationToQuote']"))[0];
			return WebDriver.FindElements(By.Id(PagePrefix + "_CL_item_LP_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)))[0];
		}
		public IWebElement ByServiceListPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.FindElements(By.Id(PagePrefix + "_CL_item_LP_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)))[1];
		}

		public IWebElement ByHardwaresellingPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.FindElements(By.Id(PagePrefix + "_CL_service_USP_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "_label"))[0];
		}

		public IWebElement ByServiceSellingPrice(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.FindElements(By.Id(PagePrefix + "_CL_service_USP_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "_label"))[1];
		}

		public IWebElement ByHardwareDiscount(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.FindElements(By.Id(PagePrefix + "_CL_service_discount_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "_label"))[0];
		}

		public IWebElement ByServiceDiscount(int lineItemIndex = 1, int groupIndex = 1)
		{
			return WebDriver.FindElements(By.Id(PagePrefix + "_CL_service_discount_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "_label"))[1];
		}

		public bool IsDDSectionDisplayedForItem(int lineItemIndex = 1, int groupIndex = 1)
		{
			if (IsDDSectionDisplayed(lineItemIndex, groupIndex) != null)
			{
				Logger.Write(string.Format("DD section available for item {0} of group {1} ", lineItemIndex, groupIndex));
				return true;
			}
			Logger.Write(string.Format("DD section not available for item {0} of group {1} ", lineItemIndex, groupIndex));
			return false;
		}
		public IWebElement IsDDSectionDisplayed(int lineItemIndex = 1, int groupIndex = 1)
		{

			return WebDriver.FindElement(By.XPath("//*[@id='" + PagePrefix + "_accordion_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']"), TimeSpan.FromSeconds(10));
		}

		public ItemDDData GetItemDDValues(bool ServiceSkuValueRequired = false, int groupIndex = 1, int itemIndex = 1, bool contractCodeRequired = false)
		{
			Logger.Write("Getting DD Values for Item " + itemIndex + " in Shipping Group " + groupIndex);
			Logger.Write("----------Start---------------");

			var itemDDData = new ItemDDData
			{
				ItemListPrice = Convert.ToDouble(LblItemLevelUnitListPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				ItemDiscountPer = Convert.ToDouble(LblItemLevelDiscountOffList(itemIndex, groupIndex).GetText(WebDriver).Split('%')[0]),
				ItemDiscount = Convert.ToDouble(LblItemLevelUnitDiscount(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				ItemSellingPrice = (groupIndex == 2 && itemIndex == 1) ? Convert.ToDouble(LblItemLevelUnitSellingPrice(groupIndex).GetText(WebDriver).Substring(1)) : Convert.ToDouble(LblItemLevelUnitSellingPrice(itemIndex).GetText(WebDriver).Substring(1)),

				HardwareListPrice = Convert.ToDouble(ByHardwareListPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				ServiceListPrice = Convert.ToDouble(ByServiceListPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),

				HardwareSellingPrice = Convert.ToDouble(ByHardwaresellingPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				ServiceSellingPrice = Convert.ToDouble(ByServiceSellingPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),

				HardwareDiscount = Convert.ToDouble(ByHardwareDiscount(itemIndex, groupIndex).GetText(WebDriver).Split('%')[0]),
				ServiceDiscount = Convert.ToDouble(ByServiceDiscount(itemIndex, groupIndex).GetText(WebDriver).Split('%')[0]),

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
	}

	public class ProductUnitObjects
	{
		public string ProductTitle { get; set; }
		public string UnitListPrice { get; set; }
		public string UnitDiscount { get; set; }
		public string ListPrice { get; set; }

	}

}