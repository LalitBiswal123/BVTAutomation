using System;
using System.Linq;
using System.Threading;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using Dsa.Pages.Quote;
using FluentAssertions;
using Exception = System.Exception;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using OpenQA.Selenium.Support.UI;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using OpenQA.Selenium.Interactions;

namespace Dsa.Pages.Product
{
	public class ProductConfigurePage : DsaPageBase
	{
		public ProductConfigurePage(IWebDriver webDriver)
			: base(webDriver)
		{
			PageFactory.InitElements(webDriver, this);
			WebDriver.VerifyBusyOverlayNotDisplayed();
		}
		#region Elements


		public IList<IWebElement> ProductsList { get { return WebDriver.GetElements(By.ClassName("prd-list-item")); } }


		public IWebElement Commentsrequired { get { return WebDriver.GetElement(By.XPath("//input[@popover='Comment Code is required']")); } }


		public IWebElement Saveoncomments { get { return WebDriver.GetElement(By.Id("saveCsComments")); } }


		public IWebElement ProductAddedToSideBySideConfigElement { get { return WebDriver.GetElement(By.Id("productConfig_productListLI_config_0")); } }


		public IWebElement RemoveProductFromSideBySide { get { return WebDriver.GetElement(By.Id("productConfig_productInfoLI_lineItem_0")); } }


		public IWebElement ProductAddedToSideBySideConfigElementCollapse { get { return WebDriver.GetElement(By.Id("productConfig_productListLI_config_1")); } }


		public IWebElement ProductOrderCode1Element { get { return WebDriver.GetElement(By.Id("productConfig_productInfoLI_orderCode_0")); } }


		public IWebElement ProductOrderCode2Element { get { return WebDriver.GetElement(By.Id("productConfig_productInfoLI_orderCode_1")); } }


		public IWebElement ProductAddConfigSvcElement { get { return WebDriver.GetElement(By.Id("productConfig_productInfoLI_addCsLink")); } }


		public IWebElement ByLblSummaryListPrice { get { return WebDriver.GetElement(By.Id("productConfig_summary_listPrice")); } }


		public IWebElement ProductAddConfigProjectIdElement { get { return WebDriver.GetElement(By.Id("productConfig_addCs")); } }


		public IWebElement ProductGetCsProjectElement { get { return WebDriver.GetElement(By.Id("productConfig_GetCs")); } }


		public IWebElement ProductApplyCsProjectIdElement { get { return WebDriver.GetElement(By.Id("productConfig_ApplyCs")); } }


		public IWebElement ProductConfigViewQuote { get { return WebDriver.GetElement(By.Id("productConfig_viewQuote")); } }


		public IWebElement ProductConfigureMemory { get { return WebDriver.GetElement(By.Id("productConfig_Memory_selection_1")); } }


		public IWebElement ProductConfigureMemoryClick { get { return WebDriver.GetElement(By.Id("productConfig_option_0_Memory_toggle")); } }

		//[FindsBy(How = How.CssSelector, Using = "textarea.form-input.ng-pristine.ng-valid.ng-touched")]
		//public IWebElement TxtTiedSku;

		//[FindsBy(How = How.CssSelector, Using = "#div__ > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > button:nth-child(1)")]
		//public IWebElement BtnAddTiedSku;


		public IWebElement LnkProductConfigTiedSkuElement { get { return WebDriver.GetElement(By.Id("productConfig_option_0_a331-7567_toggle")); } }


		public IWebElement LnkProductConfigNonTiedSkuElement { get { return WebDriver.GetElement(By.Id("productConfig_option_0_MonitorsAccessories_toggle")); } }


		public IWebElement LnkProductConfigNonTiedSkuElementConsumer { get { return WebDriver.GetElement(By.Id("productConfig_option_0_HeadphonesSpeakers_toggle")); } }


		public IWebElement ProductConfigNonTiedSkuSelectedElement { get { return WebDriver.GetElement(By.Id("productConfig_Printers_desc_{0}")); } }


		public IWebElement ProductConfigNonTiedSkuModalWindowClosedElement { get { return WebDriver.GetElement(By.Id("productConfig_option___MonitorAccessories_close")); } }


		public IWebElement ProductConfigNonTiedSkuTextElement { get { return WebDriver.GetElement(By.Id("productConfig_option_0_MonitorAccessories_toggle")); } }


		public IWebElement ChkboxProductConfigNonTiedSku { get { return WebDriver.GetElement(By.Id("productConfig_MonitorsAccessories_selection_{0}")); } }


		public IWebElement ChkboxProductConfigNonTiedSkuConsumer { get { return WebDriver.GetElement(By.Id("productConfig_HeadphonesSpeakers_selection_{0}")); } }


		public IWebElement zerosmartselectrecommendations { get { return WebDriver.GetElement(By.Id("smartselectservicenotavailable")); } }


		public IWebElement btnSelectFlexBundleRecommendation { get { return WebDriver.GetElement(By.Id("FlexBundlingRecommendation")); } }


		public IWebElement SmartSelectProductVariantsNotSupported { get { return WebDriver.GetElement(By.Id("smart_select_product_variants_not_supported")); } }


		public IWebElement HdrDellDataPotectionEncryption_Main { get { return WebDriver.GetElement(By.Id("productConfig_option_156")); } }


		public IWebElement DellDataPotectionEncryption_Categories { get { return WebDriver.GetElement(By.Id("productConfig_option_0_DellDataProtectionEncryptionSecuritySW_toggle")); } }


		public IWebElement ProductConfigAddItemsToQuoteId { get { return WebDriver.GetElement(By.Id("productConfig_addItemsToQuote")); } }


		public IWebElement ProductConfigProductListCloseIconId_0 { get { return WebDriver.GetElement(By.Id("productConfig_productListLI_delete_0")); } }


		public IWebElement ProductConfigCloseIcon { get { return WebDriver.GetElement(By.Id("icon-ui-close")); } }

		public IWebElement HdrDellDataPotectionEncryption_SubCategory { get { return WebDriver.GetElement(By.XPath("//*[contains(concat( ' ', @public class, ' ' ), concat( ' ', 'module-content', ' ' )) and (((count(preceding-sibling::*) + 1) = 1) and parent::*))]//*[contains(concat( ' ', @public class, ' ' ), concat( ' ', 'desc', ' ' )))]")); } }


		public IWebElement ProductConfigureRoute { get { return WebDriver.GetElement(By.XPath("/#/products/configure")); } }


		public IWebElement AddTiedSkuTab { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='Add Tied Sku']")); } }

		//[FindsBy(How = How.XPath, Using = @".//*[@id='productConfig_header']/div/div/tabset/div/ul/li/a[text()='Summary']")]
		//public IWebElement SummaryTab;


		public IWebElement SummaryTab { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='Summary']")); } }


		public IWebElement SystemTab { get { return WebDriver.GetElement(By.XPath(".//*[@id='productConfig_header']/div/div/tabset/div/ul/li/a[text()='System']")); } }


		public IWebElement HelpMeChoose { get { return WebDriver.GetElement(By.LinkText("Help me choose")); } }


		public IWebElement ConfigPageMarginValueforselectedItem { get { return WebDriver.GetElement(By.XPath("//div[div[div[div[div[div[div[label[contains(text(),'Margin Value')]]]]]]]]/div[contains(@class,'prod-info-wrap')]//div[label[contains(text(),'Margin Value')]]/div")); } }


		public IWebElement ConfigPageUnitMarginValueforselectedItem { get { return WebDriver.GetElement(By.XPath("//div[div[div[div[div[div[div[label[contains(text(),'Margin %')]]]]]]]]/div[contains(@class,'prod-info-wrap')]//div[label[contains(text(),'Margin %')]]/div")); } }



		public IWebElement ExpandAll { get { return WebDriver.GetElement(By.XPath("(//a[normalize-space()='Expand All'])[1]")); } }


		public IWebElement CollapseAll { get { return WebDriver.GetElement(By.XPath("(//a[normalize-space()='Collapse All'])[1]")); } }


		public IWebElement ConfigPageMemory { get { return WebDriver.GetElement(By.XPath("//*[@id='productConfig_option_11']/span[2]")); } }


		public IWebElement UpdateLnk { get { return WebDriver.GetElement(By.Id("productConfig_summary_update")); } }


		public IWebElement CloseUpdateTiedItemDialog { get { return WebDriver.GetElement(By.XPath("//div[@class='modal-close']//a/span")); } }


		public IWebElement TiedSkuQtyElem { get { return WebDriver.GetElement(By.XPath("//*[@id='quantity']/input")); } }


		public IWebElement BtnPersonalizedRecommendationTab { get { return WebDriver.GetElement(By.XPath("//*[@id='body-content']/div[2]/div/div/product-configure/div[2]/div/div/div[3]/div[3]/div/div[2]/div[4]/tabset/ul/li[2]/a/span")); } }


		public IWebElement BtnClickMoreRecommendedTab { get { return WebDriver.GetElement(By.XPath(".//*[@id='main']/div/div/div/div[4]/div[4]/div/div/div[2]/div[4]/tabset/div/div/div[2]/div[2]/div/div/div/div[1]/div[3]/a[2]")); } }


		public IWebElement BtnDialogButton { get { return WebDriver.GetElement(By.XPath(".//*[@id='messageDialogButton_0']")); } }


		public IWebElement BtnConfigureItems { get { return WebDriver.GetElement(By.Id("mastHead_configItems")); } }


		public IWebElement BtnMoreRecommendedItems { get { return WebDriver.GetElement(By.Id(".//*[@id='main']/div/div/div/div[4]/div[4]/div/div/div[2]/div[4]/tabset/div/div/div[2]/div[2]/div/div/div/div[1]/div[3]/a[2]")); } }

		//[FindsBy(How = How.XPath, Using = "//*[contains(@data-ng-click,'skuClick')]")]
		//public IWebElement lnkTiedSkuName;


		public IWebElement txtTiedItemQty { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'quantity')]/input")); } }


		public IWebElement lblTiedSKUs { get { return WebDriver.GetElement(By.XPath("//*[@id='tiedSku_table']//th[text()='Tied SKUs']")); } }


		public IWebElement lnkTiedSKUPopClose { get { return WebDriver.GetElement(By.XPath("//*[@class='modal-close']//a/span")); } }


		public IWebElement btnTiedModalOK { get { return WebDriver.GetElement(By.Id("nontied_skus_AddButton")); } }


		public IWebElement btnItemCount { get { return WebDriver.GetElement(By.Id("menu_productItems1")); } }


		public IList<IWebElement> spanInciteRules { get { return WebDriver.GetElements(By.XPath("//div[@class='dtl-ctnr visible-lg']//span[contains(@id,'productConfig_productInfoLI_validationError')]/span/span/span")); } }


		public IWebElement summaryDPA { get { return WebDriver.GetElement(By.Id("productConfig_summary_dpa")); } }


		public IWebElement summaryDBC { get { return WebDriver.GetElement(By.XPath("//p[@id='productConfig_summary_dbc']")); } }


		public IWebElement nonTiedSKUAddPopUp { get { return WebDriver.GetElement(By.Id("DataTables_Table_gridNonTiedSKUDetails")); } }


		public IWebElement ATSQuantity { get { return WebDriver.GetElement(By.XPath("//div[@class='dtl-ctnr visible-lg ng-star-inserted']//div[@class='ng-star-inserted']//div[@class='ng-star-inserted']//div[@class='col-sm-6 financial'][contains(text(),'0')]")); } }


		public IWebElement Restock { get { return WebDriver.GetElement(By.XPath("//div[@id='productResultValue_restock'][1]")); } }


		public IWebElement LeadTime { get { return WebDriver.GetElement(By.XPath("//product-config-detail//label[contains(text(),'Lead Time')]/following-sibling::div[1]")); } }


		public IWebElement ESD { get { return WebDriver.GetElement(By.XPath("//product-config-detail//label[contains(text(),'ESD')]/following-sibling::div[1]")); } }


		public IWebElement OCType { get { return WebDriver.GetElement(By.XPath("//product-config-detail//label[contains(text(),'Type')]/following-sibling::div[1]")); } }


		public IWebElement Chassis { get { return WebDriver.GetElement(By.XPath("//product-config-detail//label[contains(text(),'Chassis')]/following-sibling::div[1]")); } }


		public IWebElement TAA { get { return WebDriver.GetElement(By.XPath("//product-config-detail//label[contains(text(),'TAA')]/following-sibling::div[1]")); } }


		public IWebElement VPServiceNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(@class,'tab-content')]/tab[1]/div")); } }


		public IWebElement HighlightDifferences { get { return WebDriver.GetElement(By.Id("highlight-config-differences")); } }


		public IWebElement AddtoQuote { get { return WebDriver.GetElement(By.XPath("//div[@class='configpage-smartselect-button']/descendant::*[contains(text(),'Add to Quote')]")); } }


		public IWebElement MoreMatchingProducts { get { return WebDriver.GetElement(By.XPath("//div[@class='configpage-smartselect-button']/descendant::*[contains(text(),'More Matching Products')]")); } }


		public IWebElement AddedSmartSelection { get { return WebDriver.GetElement(By.XPath("//div[@class='smart-select-icon-stickyheader']/following::span[contains(text(),'Added Smart Selection')]")); } }


		public IWebElement CloseSmartSelectRecommenderPane { get { return WebDriver.GetElement(By.XPath("//div[@class='sb-wrapper2 ieRecommender banner-margin-top']//descendant::p[@class='icon-close']")); } }


		public IWebElement MatchingSmartSelections { get { return WebDriver.GetElement(By.XPath("//a[@class='ng-star-inserted']/child::span[contains(text(),'Matching Smart Selections')]")); } }


		public IWebElement ShowingSmartSelections { get { return WebDriver.GetElement(By.XPath("//a[@class='ng-star-inserted']/child::span[contains(text(),'Showing Smart Selections')]")); } }


		public IWebElement PrimaryMatchingSmartSelection { get { return WebDriver.GetElement(By.XPath("//div[@class='smart-select-icon']/following::h3")); } }


		public IWebElement RecommenderPane { get { return WebDriver.GetElement(By.XPath("//div[@class='sb-wrapper2 ieRecommender ng-star-inserted']")); } }


		public IWebElement NoRoomProductComparisionViewNotification { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-info alert-bordered ng-star-inserted']/span[1]")); } }


		public IWebElement SmartSelectServiceNotAvailable { get { return WebDriver.GetElement(By.Id("smartselectservicenotavailable")); } }


		public IWebElement SystemLeveDiscountIcon { get { return WebDriver.GetElement(By.XPath("//product-config-detail//div[@class='ng-star-inserted']//span[@class='flex-icon']")); } }


		public IWebElement lnkSystemLevelDiscount { get { return WebDriver.GetElement(By.XPath("//a[@class='discount-desc']")); } }

		public IWebElement FB_Disclosure { get { return WebDriver.GetElement(By.XPath("//tab[@class='dellmetrics-configurealltab active tab-pane']//div//div//tr[@class='ng-star-inserted']//div[1]//div[1]")); } }

		public IWebElement FB_TandC { get { return WebDriver.GetElement(By.XPath("//div[@class='ng-star-inserted']//div[@class='module-group clearfix']//div[@class='ng-star-inserted']//module[@ng-reflect-module-group='[object Object]']//div[@class='module-ctnr ng-star-inserted']//div[@class='col-md-12 offset-0 module-options ng-star-inserted']//options[@ng-reflect-comparison-line-items='[object Object]']//div[@class='cfg-module-item module-scroll']//div[@class='module-content ng-star-inserted']//option-group[@class='ng-star-inserted']//form[@id='productConfig_0__form']//table[@id='productConfig_0__table']//tr[@class='no-top-border ng-star-inserted']//td[@class='child-table-ctnr no-top-border']//div[@class='ng-star-inserted']//div//tbody//div[@class='ng-star-inserted']//a[@target='_blank'][contains(text(),'Terms and Conditions')]")); } }



		public IWebElement skualertmessages { get { return WebDriver.GetElement(By.XPath("//add-tied-skus//div//div[contains(@class,'alert alert-error')]")); } }


		public IWebElement Skutextarea { get { return WebDriver.GetElement(By.XPath("//textarea[@name='sku']")); } }


		public IWebElement AddBtn { get { return WebDriver.GetElement(By.XPath("//button[text()=' Add ']")); } }


		public IWebElement AddSkuvalidationMsg { get { return WebDriver.GetElement(By.XPath("//div[@class = 'alert alert-error ng-star-inserted']//li[@class = 'ng-star-inserted']")); } }


		public IWebElement ProductConfigDetail { get { return WebDriver.GetElement(By.XPath("//product-config-detail")); } }


		public IWebElement FDDWarningMessage { get { return WebDriver.GetElement(By.XPath("//*[@id='productConfig_productInfoLI_distruptivr_validationError_0']/span")); } }


		public IWebElement WarrantySkuNotification { get { return WebDriver.GetElement(By.XPath("//warranty-sku-notification[@id='productConfig_warrantySku']/div/div/span")); } }


		public IWebElement Warranty_TnC { get { return WebDriver.GetElement(By.XPath("//a[contains(text(),'Terms and Conditions')]")); } }


		public IWebElement lbl_SmartSelectionMessage { get { return WebDriver.GetElement(By.XPath("//div[@class='smart-select-icon']/../div/h4[@class='sb-msg-new']")); } }


		public IWebElement errormessage_tiedsku { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-error ng-star-inserted']")); } }


		public IWebElement TotalTaxLnk { get { return WebDriver.GetElement(By.XPath("//a[contains(text(),'Total Tax')]")); } }


		public IWebElement TaxSummaryDialogue { get { return WebDriver.GetElement(By.XPath("//h3[@id='dialog_heading']")); } }


		public IWebElement TotalTaxExpand { get { return WebDriver.GetElement(By.XPath("//i[@class='item-breakup-icon k-icon k-i-arrow-s ng-star-inserted']")); } }


		public IWebElement TotalTaxCollapse { get { return WebDriver.GetElement(By.XPath("//i[@class='item-breakup-icon k-icon ng-star-inserted k-i-arrow-n']")); } }


		public IWebElement TotalTaxLabel { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Total Tax:')]")); } }


		public IWebElement AddAnother { get { return WebDriver.GetElement(By.XPath("//div[@class='configpage-smartselect-button']/descendant::*[contains(text(),'Add Another')]")); } }


		public IWebElement txtTiedDuration { get { return WebDriver.GetElement(By.XPath("//table[@id='tiedSku_table']//input[@name='inputSkuDuration']")); } }


		public IWebElement DtcpExpansionErrorNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'For Expansion , Please select the expansion option')]")); } }

		
		public IWebElement VendorProduct { get { return WebDriver.GetElement(By.XPath("//*[@id='body-content']/div[2]/app-root/product-configure/div[2]/div/div/div[4]/div[1]/div/div[2]/product-config-detail/div[2]/div/div/div/div/div[1]/div")); } }
				
		public IWebElement ConfigureLT
		{
			get { return WebDriver.GetElement(By.XPath("//div[@class='smart-product-LeadTime']/p")); }
		}
		public IWebElement ConfigureLTValue
		{
			get { return WebDriver.GetElement(By.XPath("//div[@class='smart-product-LeadTimeValue']")); }
		}
		public IWebElement ConfigureLPRU
		{
			get { return WebDriver.GetElement(By.XPath("//div[@class='grid-data-config']//label[contains(text(),'LPRU')]")); }
		}

		public IWebElement RemoveItem_CartView_Link
		{ get { return WebDriver.GetElement(By.Id("RemoveItem_CartView_Link")); } }
		#endregion


		#region Solution Elements


		public IWebElement CFSAdminOverrideChecbox { get { return WebDriver.GetElement(By.Id("cfs-admin-override")); } }

		public void EnterCommentTextByCommentCode(string commentCode, string value)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WebDriver.GetElement(By.XPath("//input[@popover='Comment Text is required']")).SetText(WebDriver, value);
			//WebDriver.GetElement(By.XPath("//div[div[span[text()='" + commentCode + "']]]//input[@popover='Comment Text is required']")).SetText(WebDriver, value);
		}
		public ProductConfigurePage SelectCFSAdminOverrideChecbox()
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			DsaUtil.SelectCheckBox(CFSAdminOverrideChecbox, WebDriver);
			return new ProductConfigurePage(WebDriver);
		}

		public ProductConfigurePage ExpandRequiredSkus()
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();

			var requireSkuLnk = WebDriver.GetElements(By.Id("productConfig_option_0_CFIRequiredSKUs_toggle")).FirstOrDefault();
			//if (requireSkuLnk.IsElementClickable(WebDriver))
			requireSkuLnk.Click(WebDriver);
			return this;
		}

		#endregion

		#region Autopilot Elements


		public IWebElement AutoPilotSection { get { return WebDriver.GetElement(By.XPath("//tab[@heading='Summary']//auto-pilot-info")); } }


		public IWebElement TxtTenantId { get { return WebDriver.GetElement(By.XPath("//tab[@heading='Summary']//auto-pilot-info//input[contains(@id, 'tenantID')]")); } }


		public IWebElement TxtDomain { get { return WebDriver.GetElement(By.XPath("//tab[@heading='Summary']//auto-pilot-info//input[contains(@id, 'domain')]")); } }


		public IWebElement LabelTenantId { get { return WebDriver.GetElement(By.XPath("//tab[@heading='Summary']//auto-pilot-info//td[contains(text(), 'Tenant ID')]")); } }


		public IWebElement LabelDomain { get { return WebDriver.GetElement(By.XPath("//tab[@heading='Summary']//auto-pilot-info//td[contains(text(), 'Domain')]")); } }


		public IWebElement LabelAutpilotInfo { get { return WebDriver.GetElement(By.XPath(" //tab[@heading='Summary']//auto-pilot-info//p[contains(@class,'alert alert-info') and contains(@id, 'Info')]")); } }


		public IWebElement LabelAutpilotSuccess { get { return WebDriver.GetElement(By.XPath("//tab[@heading='Summary']//auto-pilot-info//p[contains(@class,'alert alert-success') and contains(@id, 'success')]")); } }


		public IWebElement LabelAutpilotFailure { get { return WebDriver.GetElement(By.XPath("//tab[@heading='Summary']//auto-pilot-info//p[contains(@class,'alert alert-info') and contains(@id, 'Info')]")); } }


		public IWebElement LabelTenantIdInvalidInput { get { return WebDriver.GetElement(By.XPath("//tab[@heading='Summary']//auto-pilot-info//input[contains(@id, 'tenantID')]/parent::div//span[contains(@class,'invalid-input')]")); } }


		public IWebElement LabelDomainInvalidInput { get { return WebDriver.GetElement(By.XPath("//tab[@heading='Summary']//auto-pilot-info//input[contains(@id, 'domain')]/parent::div//span[contains(@class,'invalid-input')]")); } }


		public IWebElement IconTenantId { get { return WebDriver.GetElement(By.XPath("//tab[@heading='Summary']//auto-pilot-info//td[contains(text(), 'Tenant ID')]/parent::tr//div[@class='icon icon-small-alertinfo text-blue']")); } }


		public IWebElement IconDomain { get { return WebDriver.GetElement(By.XPath("//tab[@heading='Summary']//auto-pilot-info//td[contains(text(), 'Domain')]/parent::tr//div[@class='icon icon-small-alertinfo text-blue']")); } }


		public IWebElement IconCloseTenantId { get { return WebDriver.GetElement(By.XPath("//div[@class='product-configure']//i[@class='icon-ui-close']/parent::button[contains(@onclick,'_popover_tenantID_')]")); } }


		public IWebElement IconCloseDomain { get { return WebDriver.GetElement(By.XPath("//div[@class='product-configure']//i[@class='icon-ui-close']/parent::button[contains(@onclick,'_popover_domain_')]")); } }

		#endregion

		#region Autopilot Methods

		/// <summary>
		/// Ram - This method is to expand module by passing the Module Name
		/// </summary>
		/// <param name="moduleName"></param>
		/// <returns></returns>
		public ProductConfigurePage ExpandModule(string moduleName)
		{
			IWebElement eleOptionSelected = null;
			By moduleBy = By.Id(string.Format("productConfig_option_0_{0}_toggle", moduleName.Replace(" ", string.Empty)));
			try
			{
				eleOptionSelected = WebDriver.GetElement(By.XPath(String.Format("//tab[@heading='Summary']//table[@class='child-config-table']//td[@id='productConfig_{0}_desc_0']", moduleName.Replace(" ", string.Empty))), TimeSpan.FromSeconds(15));
				if (eleOptionSelected.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
					return this;
			}
			catch (Exception e)
			{
				eleOptionSelected = null;
				Console.WriteLine(e);
			}
			WebDriver.GetElement(moduleBy, TimeSpan.FromSeconds(15)).Click();
			return this;

		}

		public ProductConfigurePage clickModuleExpandCollapseToggle(string moduleName)
		{
			By moduleBy = By.Id(string.Format("productConfig_option_0_{0}_toggle", moduleName.Replace(" ", string.Empty)));
			WebDriver.GetElement(moduleBy, TimeSpan.FromSeconds(15)).Click();
			return this;
		}

		/// <summary>
		/// Ram - This method is to expand module by passing the Module Name and verify the Option Description is selected by passing the Option index starting from 1
		/// </summary>
		/// <param name="moduleName"></param>
		/// <param name="optionDescription"></param>
		/// <param name="optionIndex"></param>
		/// <returns></returns>
		public bool VerifyIsOptionSelected(string moduleName, string optionDescription, int optionIndex = 1)
		{
			try
			{
				ExpandModule(moduleName);
				Logger.Write($"Module Expanded - {moduleName}");
				IWebElement eleSelectedOption = WebDriver.GetElement(By.Id(string.Format("productConfig_{0}_selection_{1}", moduleName.Replace(" ", string.Empty), optionIndex - 1)), TimeSpan.FromSeconds(10));
				IWebElement eleSelectedOPtionLabel = WebDriver.GetElement(By.Id(string.Format("productConfig_{0}_desc_{1}", moduleName.Replace(" ", string.Empty), optionIndex - 1)), TimeSpan.FromSeconds(10));
				return eleSelectedOption.Selected & eleSelectedOPtionLabel.Text.Trim().Contains(optionDescription);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return false;
			}
		}

		/// <summary>
		/// Ram - This method is to expand module by passing the Module Name and select the Option by passing the Option index starting from 1
		/// </summary>
		/// <param name="moduleName"></param>
		/// <param name="optionIndex"></param>
		/// <returns></returns>
		public ProductConfigurePage SelectOptionInModule(string moduleName, int optionIndex = 1)
		{
			ExpandModule(moduleName);
			WebDriver.FindElements(By.Id(string.Format("productConfig_{0}_selection_{1}", moduleName.Replace(" ", string.Empty), optionIndex - 1)), TimeSpan.FromSeconds(10)).FirstOrDefault().Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			Logger.Write(string.Format("Selected Option at Index - {0} , under module - {1}", optionIndex, moduleName));
			return this;
		}

		/// <summary>
		/// Ram - This method is used to verify whether TenantId and Domain component is shown
		/// </summary>
		/// <returns></returns>
		public bool VerifyTenantIdandDomainSectionShown()
		{
			return AutoPilotSection.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(6)) && TxtTenantId.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(6)) && TxtDomain.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(6));
		}

		public void PatchTenantIdandDomainData(string tenantId, string domain)
		{
			TxtTenantId.SetText(WebDriver, tenantId, TimeSpan.FromSeconds(3));
			TxtDomain.SetText(WebDriver, domain, TimeSpan.FromSeconds(3));
			Logger.Write($"TeanantId - {tenantId} and Domain - {domain} are patched");
		}

		/// <summary>
		/// Ram - This method is used to verify whether Get Text from TenantID and Domain are same as provided
		/// </summary>
		/// <param name="tenantIdandDomain"></param>
		/// <returns></returns>
		public bool VerifyTenantIdandDomainDataShown(string tenantId, string domain)
		{
			return TxtTenantId.GetText(WebDriver, TimeSpan.FromSeconds(2)).Equals(tenantId) && TxtDomain.GetText(WebDriver, TimeSpan.FromSeconds(2)).Equals(domain);
		}

		/// <summary>
		/// Ram - This method is used to verify the Successfull authentication message after Tenant ID and Domain were successfully
		/// </summary>
		public void VerifySuccessMessageAfterPatchTenantIdandDomainData()
		{
			string authenticationSuccessMessageDisplay = "Tenant ID and Domain were successfully validated";
			LabelAutpilotSuccess.GetText(WebDriver, TimeSpan.FromSeconds(10)).Should().Be(authenticationSuccessMessageDisplay);
			Logger.Write($"Autopilot section is displayed with authentication Success message - {authenticationSuccessMessageDisplay}");
		}
		/// <summary>
		/// Ram - This method is used to verify the Failure authentication message after Tenant ID and Domain were failed authentication
		/// </summary>
		public void VerifyFailureMessageAfterPatchTenantIdandDomainData()
		{
			string authenticationFailureMessageDisplay = "Authentication failed. Please enter a valid Tenant ID and/or Domain to attempt re-authentication.";
			LabelAutpilotFailure.GetText(WebDriver, TimeSpan.FromSeconds(10)).Should().Be(authenticationFailureMessageDisplay);
			Logger.Write($"Autopilot section is displayed with authentication Success message - {authenticationFailureMessageDisplay}");
		}

		public void VerifyLabelTenantId(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			LabelTenantId.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2)).Should().BeTrue();
		}

		public void VerifyLabelDomain(int shippingGroupIndex = 1, int itemIndex = 1)
		{
			LabelDomain.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2)).Should().BeTrue();
		}

		/// <summary>
		/// Ram - This method is used to verify the Info Message for TenantId and Domain info
		/// </summary>
		public void VerifyLabelAutpilotInfo()
		{
			LabelAutpilotInfo.GetText(WebDriver, TimeSpan.FromSeconds(2)).Should().Be("Please provide a valid Tenant ID and Domain");
		}
		public void VerifyLabelTenantIdInvalidInput()
		{
			LabelTenantIdInvalidInput.GetText(WebDriver, TimeSpan.FromSeconds(2)).Should().Be("Please enter a valid Tenant ID.");
		}
		public void VerifyLabelDomainInvalidInput()
		{
			LabelDomainInvalidInput.GetText(WebDriver, TimeSpan.FromSeconds(2)).Should().Be("Please enter a valid Domain.");
		}

		public void VerifyIconTenantId()
		{
			IconTenantId.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2)).Should().BeTrue();
		}
		public void VerifyIconDomain()
		{
			IconDomain.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2)).Should().BeTrue();
		}

		public void VerifyIconCloseTenantId()
		{
			IconCloseTenantId.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2)).Should().BeTrue();
		}
		public void VerifyIconCloseDomain()
		{
			IconCloseDomain.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2)).Should().BeTrue();
		}

		/// <summary>
		/// Ram - This method is used to verify whether TenantId and Domain component is shown
		/// </summary>
		/// <returns></returns>
		public void VerifyTenantIdandDomainShownforModule(string moduleName, int optionIndex = 1)
		{
			SelectOptionInModule(moduleName, optionIndex);
			if (optionIndex == 2)
				VerifyTenantIdandDomainSectionShown().Should().BeFalse();
			else
				VerifyTenantIdandDomainSectionShown().Should().BeTrue();
		}

		/// <summary>
		/// Ram - This method is to expand Config Prod using toggle arrow by passing the Module Name by passing the Option index starting from 1
		/// </summary>
		/// <param name="orderCode"></param>
		/// <param name="optionIndex"></param>
		public void ExpandProductUsingTogggleArrow(int optionIndex = 1)
		{
			IList<IWebElement> productList = WebDriver.FindElements(By.XPath("//div[@class='prd-list-item']//i[@class='icon-ui-arrowleft']"));
			if (productList.Count != 1)
			{
				foreach (var prodElement in productList)
				{
					prodElement.Click();
				}
				WebDriver.GetElement(By.XPath("(//div[@class='prd-list-item']//i[@class='icon-ui-arrowleft'])['" + optionIndex + "']"), TimeSpan.FromSeconds(10)).Click(WebDriver);
			}

		}

		public void VerifyAutopilotData(bool verifyAutopilotSectionDisplayed, bool verifyTenantIdandDomainDataShown, string tenantId, string domain)
		{
			if (verifyAutopilotSectionDisplayed == true)
			{
				VerifyTenantIdandDomainSectionShown().Should().BeTrue();
				Logger.Write("Autopilot section is displayed");
				if (verifyTenantIdandDomainDataShown == true)
				{
					VerifyTenantIdandDomainDataShown(tenantId, domain).Should().BeTrue();
					Logger.Write($"Autopilot section with TenantId - {tenantId} and Domain - {domain} is displayed");
					VerifySuccessMessageAfterPatchTenantIdandDomainData();
				}
				else
					VerifyTenantIdandDomainDataShown(tenantId, domain).Should().BeFalse();
				Logger.Write($"Autopilot section with NO data for TenantId - {tenantId} and Domain - {domain}");
			}
			else
				VerifyTenantIdandDomainSectionShown().Should().BeFalse();
		}

		public void VerifyValidationTenantIdDomainwithList(IWebDriver driver, IList<String> dataList, string idType, bool isValidList)
		{
			if (String.Equals(idType, "TenantId", StringComparison.OrdinalIgnoreCase))
			{
				if (!isValidList)
					foreach (string text in dataList)
					{
						InputAutopilotTenantandDomainData(TxtTenantId, text);
						LabelTenantIdInvalidInput.Text.Should().Be("Please enter a valid Tenant ID.");
					}
				else
					foreach (string text in dataList)
					{
						InputAutopilotTenantandDomainData(TxtTenantId, text);
						LabelTenantIdInvalidInput.IsElementDisplayed(driver, TimeSpan.FromSeconds(1)).Should().BeFalse();
					}
			}

			else
			{
				if (!isValidList)
					foreach (string text in dataList)
					{
						InputAutopilotTenantandDomainData(TxtDomain, text);
						LabelDomainInvalidInput.Text.Should().Be("Please enter a valid Domain.");
					}
				else
					foreach (string text in dataList)
					{
						InputAutopilotTenantandDomainData(TxtDomain, text);
						LabelDomainInvalidInput.IsElementDisplayed(driver, TimeSpan.FromSeconds(1)).Should().BeFalse();
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

		#endregion

		#region Warranty 

		public IWebElement ConfigurePgeWarrantyNotification { get { return WebDriver.GetElement(By.XPath("//*[@id='productConfig_warrantySku']//span[contains(text(), 'One or more systems contains a tied subscription')]")); } }

		#endregion

		public IWebElement lnkTiedSkuName(string tiedSku)
		{
			//return WebDriver.GetElements(By.XPath("(//*[contains (@id,'tiedSku_multiple']/..//a"))[1];
			return WebDriver.GetElement(By.XPath("(//a[contains(text(),'" + tiedSku + "')])[3]"));
		}


		public IWebElement lnkBundleDetails(string bundleHeader)
		{
			return WebDriver.GetElement(By.XPath("(//tab[@heading='Summary']//a[contains(text(),'" + bundleHeader + "')])"));
		}


		public string MarginForSelectedItem;

		public string UnitMarginForSelectedItem;

		public string ConfigOptionLevelMargin;

		public string ConfigOptionLevelMargin_AfterUpdates;

		//public string SelectedNontiedItemPrice;


		public int GetTotalItemsCount(IWebDriver driver)
		{
			var text = btnItemCount.GetText(WebDriver);
			return int.Parse(Regex.Match(text, @"\d+").Value);
		}

		public void ViewProductsSidebySide(int index)
		{
			WebDriver.GetElement(By.CssSelector(string.Format("i.icon-ui-arrowright")))
				.Click(WebDriver);
		}

		public string GetRecommendationHeaderText(int index)
		{
			return WebDriver.GetElements(By.XPath("//recommendation-list-config-page//div[1]/h5"))[index].GetText(WebDriver);
		}


		public void SelectRecommendationBundleItem(int index)
		{
			WebDriver.GetElements(By.XPath("//*[@id='productConfig_SaveMoreWithBundles_selection_0']"))[index].Click(WebDriver);
		}


		public void CollapseandExpandAllProducts(int index)
		{
			WebDriver.GetElement(By.CssSelector(string.Format("i.icon-ui-arrowleft"))).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WebDriver.GetElement(By.CssSelector(string.Format("i.icon-ui-arrowright"))).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
		}

		public void WaitForBusyIndicatorAppearAndDisappear()
		{
			WebDriver.WaitForElementVisible(By.XPath("//*[@id='busy-indicator']"), TimeSpan.FromSeconds(10));
			var wait = new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime);
			wait.Until<bool>(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='busy-indicator']")));
		}

		public void WaitForRecommendationsToLoad()
		{
			var retry = true;
			var retryCounter = 1;
			while (retry && retryCounter <= 3)
				try
				{
					WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(30));
					wait.Until(d => d.FindElement(By.XPath("(//h5[@class='name'])[1]")));
					retry = false;
				}
				catch (WebDriverTimeoutException e)
				{
					retryCounter++;
					if (retryCounter > 3)
					{
						throw;
					}
				}
		}

		public IWebElement TxtTiedSku(int configItemIndex = 1)
		{
			// return WebDriver.GetElements(By.Id(string.Format("productConfig_productInfoLI_{0}_AddSku", configItemIndex - 1))).FirstOrDefault(a => a.Displayed);
			return WebDriver.GetElements(By.XPath(".//textarea[@type='text' and @name='sku']"))[configItemIndex - 1];
		}

		public IWebElement ConfigModule(string moduleNo)
		{
			return WebDriver.GetElement(By.XPath(string.Format("//*[@id='productConfig_option_{0}']/span[2]", moduleNo)));
		}

		public IWebElement RecommendedItems_Refresh
		{
			get
			{
				return WebDriver.GetElement(By.XPath("(//a[text()='Refresh'])[1]"));
			}
		}

		public IWebElement RecommendedItemTxt(int index)
		{
			var recommendedItemText = $"//recommendation-list-config-page/div/ul/div[{index + 1}]/li/div[2]/a/h5";
			var item = WebDriver.GetElement(By.XPath(recommendedItemText));
			return item;
		}

		public IList<IWebElement> RecommendedItem_AddButtons
		{
			get
			{
				return WebDriver.FindElements(By.XPath("//div[@class='configpage-recommend-button']/button[contains(@id,'AddRecommendationToQuote')]"));
			}
		}

		public IWebElement RecommendedItem_AddButton(int i)
		{
			WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
			return wait.Until(d => d.FindElement(By.XPath(string.Format("(//*[@id='AddRecommendationToQuote'])[{0}]", i))));
		}

		public IList<IWebElement> RecommededItemNames
		{
			get
			{
				return WebDriver.FindElements(By.XPath("//h5[@class='name']"));
			}
		}

		public IWebElement MoreDetail_RecommededItemName
		{
			get
			{
				return WebDriver.GetElement(By.XPath("//*[@class='recommendation-detail-header']"));
			}
		}

		public IWebElement MoreDetails_RecommededItemDescription
		{
			get
			{
				return WebDriver.GetElement(By.XPath("//*[@class='configpage-product-detail']"));

			}
		}

		public IList<IWebElement> MoreProductDetails
		{
			get
			{
				return WebDriver.FindElements(By.XPath("//div/a[@class='more-product-details']"));
			}
		}

		public IWebElement MoreDetails_LnkDell
		{
			get
			{
				return WebDriver.GetElement(By.XPath("//p/a[@class='more-product-details ng-star-inserted']"));
			}
		}

		public IWebElement MoreDetails_Back
		{
			get
			{
				return WebDriver.GetElement(By.XPath("//span[text()='Back']"));
			}
		}

		public IWebElement MoreDetails_RecommededItemPrice
		{
			get
			{
				return WebDriver.GetElement(By.XPath("//*[@class='recommendation-detail-price']"));
			}
		}

		public IList<IWebElement> RecommededItemPrice
		{
			get
			{
				return WebDriver.FindElements(By.XPath("//*[@class='item-final-price']"));
			}
		}

		public IWebElement MoreDetails_RecommendedItemQuantitySpinner
		{
			get
			{
				return WebDriver.GetElement(By.XPath("//div[@class='config-recommendation-detail-rangespinner']/input"));
			}
		}

		public IList<IWebElement> RecommendedItemQuantitySpinners
		{
			get
			{
				return WebDriver.FindElements(By.XPath("//div[@class='rangespinner']/input"));
			}
		}

		public IWebElement BtnAddTiedSku(int configItemIndex = 1)
		{
			var ele =
				WebDriver.GetElements(
					By.XPath(".//button[@class='btn btn-primary input-btn' and contains(text(),'Add')]")).LastOrDefault();
			return ele;
		}
		public bool IsExistingTiedSkuMessage()
		{
			return WebDriver.TryFindElement(WebDriver.FindElement(By.XPath("//div[contains(@class, 'alert alert-error ng-star-inserted')]")));
		}

		public IWebElement BtnSummary()
		{
			return WebDriver.GetElement(By.XPath("//li[@class='nav-item ng-star-inserted']//span[contains(text(),'Summary')]"));

		}

		public IWebElement TblAddTiedSku(string tiedSku)
		{
			return WebDriver.GetElement(By.Id(string.Format("__a{0}_table", tiedSku)));
		}

		public IWebElement ConfigAddedMesage(int index)
		{
			return WebDriver.GetElement(By.Id("productConfig_productInfoLI_flavorMessage_" + index));
		}

		

		public IWebElement TxtBaseQuantity()
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return WebDriver.FindElements(By.XPath("//label[contains(text(),'Quantity')]/following-sibling::div/input")).FirstOrDefault();
		}

		public IWebElement LnkHelpMeChoose()
		{
			return HelpMeChoose;
		}

		public IWebElement DFIcon { get { return WebDriver.GetElement(By.XPath("//*[@id='productConfig_option_0_DellApplicationSoftware_toggle']/div")); } }

		public IWebElement DFIconToolTip { get { return WebDriver.GetElement(By.XPath("//*[@id='productConfig_option_0_DellApplicationSoftware_toggle']/div/span[1]/span")); } }

		public ProductConfigurePage ClickConfigurationService()
		{
			WebDriver.GetElement(By.LinkText("Configuration Services")).Click(WebDriver);
			return this;
		}

		public ProductConfigurePage ClickNoneSelected()
		{
			WebDriver.GetElement(By.LinkText("None Selected")).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return this;
		}

		public ProductConfigurePage EnterConfigurationServicesProjects(string value)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WebDriver.GetElement(
				By.XPath(
					"//input[@placeholder='Type CS SI']"))
				.SendKeys(value);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return this;
		}

		//public void ClickAddOnConfigurationServicesProject1()
		//{
		//    WebDriver.GetElement(By.XPath("//div[@class='cfs-project-id-input-wrapper clearfix']/button")).Click(WebDriver);
		//    WebDriver.VerifyBusyOverlayNotDisplayed();
		//    WebDriver.GetElement(By.XPath("//span[normalize-space()='Add New Comment']")).Click(WebDriver);
		//    //if (WebDriver.TryFindElement(WebDriver.FindElement(
		//    //    By.TagName("cfi-comments"))))
		//    if (WebDriver.TryFindElement(WebDriver.FindElement(
		//        By.XPath("//*[@class='accordion-body form-group']"))))
		//    {
		//        var requiredComments = WebDriver.FindElements(By.XPath("//div[@class='col-md-4 cfs-comment-header']//input[@popover='Comment Code is required']"));
		//        foreach (var comment in requiredComments)
		//        {
		//            comment.SendKeys("test");
		//        }
		//        WebDriver.FindElement(By.Id("saveCsComments")).Click();
		//    }
		//}

		public void ClickAddOnConfigurationServicesProject()
		{
			WebDriver.GetElement(By.XPath("//div[@class='cfs-project-id-input-wrapper clearfix']/button")).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			if (WebDriver.GetElement(By.XPath("//display-error-info/div[contains(@class , 'alert')]/p[1]"),
					TimeSpan.FromSeconds(2)) == null)
			{
				WebDriver.GetElement(By.XPath("//span[normalize-space()='Add New Comment']")).Click(WebDriver);
				if (WebDriver.GetElement(
						By.XPath("//*[@class='accordion-body form-group']"), TimeSpan.FromSeconds(2)) != null)
				{
					var requiredCommentcode =
						WebDriver.FindElements(By.XPath("//input[@popover='Comment Code is required']"));
					var requiredComments =
						WebDriver.FindElements(By.XPath("//input[@popover='Comment Text is required']"));
					foreach (var comment in requiredComments)
					{
						comment.SendKeys("test");
					}

					foreach (var comment1 in requiredCommentcode)
					{
						comment1.SendKeys("testcode");
					}

					WebDriver.FindElement(By.Id("saveCsComments")).Click();
				}
			}
		}

		public void ClickRemoveCFIProject()
		{
			SummaryTab.Click(WebDriver);
			WebDriver.GetElement(By.XPath("//div[@class='caret module-toggle']")).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			ToggleConfigureProjectServices();
			WebDriver.GetElement(By.XPath("//button[contains(text(),'Remove')]")).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
		}

		public ProductConfigurePage ToggleConfigureProjectServices()
		{
			WebDriver.GetElement(
				By.XPath("//div[@class='accordion-toggle']//span[contains(text(), 'Configuration Services Projects')]")).Click(WebDriver);
			return this;
		}

		public bool IsCfiGridVisible()
		{
			return WebDriver.TryFindElement(WebDriver.FindElement(By.Id("DataTables_Table_cfsGrid")));
		}

		public ProductConfigurePage ClickReplaceCfiFromGrid()
		{
			WebDriver.GetElements(By.XPath("//tr[1]//td[5]//add-component[1]//action-template[1]//a[1]")).FirstOrDefault().Click(WebDriver);
			return this;
		}

		public void ClickAddCommentToConfigurationServicesProject()
		{
			WebDriver.GetElement(By.XPath("//button[@class='btn btn-link cfs-add-comment-row-btn']")).Click(WebDriver);
		}

		public void EnterValueInCommentCode(string value)
		{
			WebDriver.GetElement(By.XPath("//input[@data-c-validation='Comment Code is required']")).SetText(WebDriver, value);
		}


		public void EnterCommentText(string value)
		{
			WebDriver.GetElement(By.XPath("//input[@data-c-validation='Comment Text is required']"))
				.SetText(WebDriver, value);
		}

		public void ClickSaveOnComments()
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WebDriver.FindElement(By.Id("saveCsComments")).Click();
		}

		public void EnterTiedSkuText(string value, int configItemIndex = 1)
		{
			TxtTiedSku(configItemIndex).SetText(WebDriver, value);
		}

		public IWebElement DeleteTiedSku(int? tiedSkuIndex = 0)
		{

			return WebDriver.GetElements(By.XPath("//a[@title='Remove']"))[(int)tiedSkuIndex];
		}
		public string FirstRecommendedItemsTabXpath(int index)
		{

			string FirstRecommendedItemsTabXpath = string.Format("//*[@id='main']/div/div/div/div[4]/div[4]/div/div/div[2]/div[4]/tabset/div/div/div[2]/div[2]/div/div/div/div[1]/div[3]/div/div[1]/div[{0}]/div/div[2]/a/h5", index);
			return FirstRecommendedItemsTabXpath;
		}
		public IWebElement TxtRecommendedItemQuantity(int SlideNo, int ItemNo)
		{
			string RecommendedQuantity = string.Format("//*[@id='main']/div/div/div/div[4]/div[4]/div/div/div[2]/div[4]/tabset/div/div/div[2]/div[2]/div/div/recommendation-carousel/div[1]/carousel/div/div/slide[{0}]/div/div[{1}]/div[4]/input", SlideNo, ItemNo);
			return WebDriver.FindElement(By.XPath(RecommendedQuantity));
		}

		public IWebElement GetTiedSkuElementAt(string tiedSku)
		{
			return WebDriver.GetElements(By.XPath(string.Format("//a[@data-toggle='dropdown' and contains(text(), '{0}')]", tiedSku)))[0];
		}

		public IWebElement BtnAddRecommendedItemAsNewLineItem(int index)
		{
			// below xpath is very specific - finds the add to quote button for the recommended item for which the quantity field is editable
			var addToQuoteBtn = "//recommendation-list-config-page/div/ul//input[contains(@class,'ng-valid')]/ancestor::div[@class='configrecommended-item-details-block']/following-sibling::div[@class='configpage-recommend-button']/button";

			return WebDriver.GetElements(By.XPath(addToQuoteBtn))[index];

		}

		private IWebElement OptionChckBox(string moduleName, int index = 1)
		{
			return WebDriver.GetElement(By.Id(string.Format("productConfig_{0}_selection_{1}", moduleName, index - 1)));
		}

		public bool IsOptionSelected(string moduleName, int index = 1)
		{
			bool res = false;
			ClickExpandModule(moduleName);
			if (OptionChckBox(moduleName, index).IsElementVisible())
			{
				res = OptionChckBox(moduleName, index).Selected;
			}
			ClickExpandModule(moduleName);
			return res;
		}

		public ProductConfigurePage CloneProduct(int index = 1)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			var lnkCopy = WebDriver.GetElement(By.Id(string.Format("productConfig_productInfoLI_cloneItem_{0}", index - 1)));
			lnkCopy.Click();
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return this;
		}

		public bool ValidateTiedSKUAdded(string tiedSku)
		{
			bool visible = false;
			AddTiedSkuTab.IsElementClickable(WebDriver);
			AddTiedSkuTab.Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			var skuAdded = WebDriver.FindElements(By.XPath(string.Format("//a[contains(text(), '{0}')]", tiedSku))).FirstOrDefault();
			if (skuAdded.Text == "")
			{
				skuAdded = WebDriver.FindElements(By.XPath(string.Format("//a[contains(text(), '{0}')]", tiedSku))).LastOrDefault();
			}
			if (skuAdded != null && skuAdded.Displayed)
				visible = true;
			return visible;
		}


		public void ClickAddTiedSkuButton()
		{
			BtnAddTiedSku().Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
		}

		public ProductConfigurePage AddTiedSkus(string[] tiedSkus, int configItemIndex = 1)
		{
			AddTiedSkuTab.Click(WebDriver);
			TxtTiedSku(configItemIndex).SetText(WebDriver, string.Join(",", tiedSkus));
			BtnAddTiedSku(configItemIndex).Click(WebDriver);
			SummaryTab.Click(WebDriver);
			return this;
		}

		public string RecommendedItemAtConfigurePage(int index)
		{
			var recommendedItemsConfigurePageXpath = string.Format(".//*[@id='main']/div/div/div/div[4]/div[4]/div/div/div[2]/div[4]/tabset/div/div/div[2]/div[2]/div/div/div/div[1]/div[3]/div/div/div[{0}]/div/div[2]/a/h5", index);
			return recommendedItemsConfigurePageXpath;
		}

		public ProductConfigurePage AddTiedSku(string tiedSku, int configItemIndex = 1, int qty = 1)
		{
			AddTiedSkuTab.Click(WebDriver);
			TxtTiedSku(configItemIndex).SetText(WebDriver, tiedSku);
			BtnAddTiedSku(configItemIndex).Click(WebDriver);
			lnkTiedSkuName(tiedSku).Click(WebDriver);
			txtTiedItemQty.SetText(WebDriver, qty.ToString());
			lblTiedSKUs.Click(WebDriver);
			lnkTiedSKUPopClose.Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			IJavaScriptExecutor Js = (IJavaScriptExecutor)WebDriver;
			Js.ExecuteScript("scroll(0, 0);");
			ProductConfigViewQuote.Click(WebDriver);
			return this;
		}

		public ProductConfigurePage UpdateBaseQuantity(string quantity)
		{
			TxtBaseQuantity().SetText(WebDriver, quantity);
			return this;
		}

		public ProductConfigurePage UpdateTiedSkuQuantity(string tiedSku, string quantity)
		{
			WebDriver.GetElements(
				By.XPath(string.Format("//div[@id='tiedSku_multiple']/following::div/a[contains(.,'{0}')]", tiedSku))).Last().Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			if (WebDriver.TryFindElement(WebDriver.GetElement(
				By.XPath("//td[@id='quantity']//input[@type='text']"))))
			{
				var txtQuantity = WebDriver.GetElement(
					By.XPath(string.Format("//td[@id='quantity']//input[@type='text']", tiedSku)));
				txtQuantity.SetText(WebDriver, quantity);
				//txtQuantity.Click();
			}
			WebDriver.VerifyBusyOverlayNotDisplayed();
			//click to close tied item popup
			WebDriver.GetElement(By.XPath("//div[@class='modal-close']//a/span")).Click(WebDriver);
			return this;
		}

		public void CopyProductWithOC(string OC)
		{
			foreach (var Product in ProductsList)
			{
				if (Product.Text.Contains(OC.ToUpper()))
				{
					Product.FindElement(
						By.XPath(string.Format(
							"//a[@id='productConfig_productInfoLI_cloneItem_0']", OC))).Click(WebDriver);
					return;
				}
			}
		}

		public string GetTiedSkuQuantity(string tiedSku)
		{
			WebDriver.GetElements(
				By.XPath(string.Format("//td[@id='desc']//div[contains(text(),'{0}')]", tiedSku))).Last().Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return
				WebDriver.GetElement(
				By.XPath(string.Format("//td[@id='quantity']/input", tiedSku))).GetText(WebDriver);
		}

		public ProductConfigurePage AddNonTiedSku(string nonTiedSkuModule, int index)
		{
			WebDriver.GetElement(By.Id(string.Format("productConfig_option_0_{0}_toggle", nonTiedSkuModule.Replace(" ", string.Empty))))
			   .Click(WebDriver);


			string id = string.Format("productConfig_{0}_selection_{1}", nonTiedSkuModule.Replace(" ", string.Empty),
					index - 1);
			string xpath = "//input[@id='" + id + "']";
			By.XPath(xpath).Click(WebDriver, null, true);
			new ProductConfigurePage(WebDriver).GoToCurrentQuotePage();
			return this;
		}

		public ProductConfigurePage AddNonTiedItem(string nonTiedSkuModule)
		{
			WebDriver.GetElement(By.Id(string.Format("productConfig_option_0_Accessories_toggle", nonTiedSkuModule.Replace(" ", string.Empty))))
			   .Click(WebDriver);

			WebDriver.GetElement(By.Id("productConfig_Accessories_selection_0")).Click(WebDriver);

			new ProductConfigurePage(WebDriver).GoToCurrentQuotePage();
			return this;
		}



		/// <summary>
		/// Adds Non-Tied sku for Flexbilling order codes.
		/// There will be multiple option groups with multiple options in each group.
		/// </summary>
		/// <param name="nonTiedSkuModule"></param>
		/// <param name="index"></param>
		/// <returns></returns>
		public ProductConfigurePage AddFlexBillingNonTiedSku(string nonTiedSkuModule, int index)
		{
			WebDriver.GetElement(
			   By.Id(string.Format("productConfig_option_0_{0}_toggle", nonTiedSkuModule.Replace(" ", string.Empty))))
			   .Click(WebDriver);

			string id = string.Format("productConfig_{0}_selection_{1}", nonTiedSkuModule.Replace(" ", string.Empty),
					index - 1);
			string xpath = "//input[@id='" + id + "']";
			var elements = WebDriver.GetElements(By.XPath(xpath));
			if (elements.Count > 1)
			{
				// Choose the first option from second <option group>.
				elements[1].Click(WebDriver);
			}
			new ProductConfigurePage(WebDriver).GoToCurrentQuotePage();
			return this;
		}

		public ProductConfigurePage AddNestedNonTiedSku(string nonTiedSkuModule, int index, string nestednonTied, int nestedIndex)
		{
			//Add Non-Tied Item first
			WebDriver.GetElement(
			  By.Id(string.Format("productConfig_option_0_{0}_toggle", nonTiedSkuModule.Replace(" ", string.Empty))))
			  .Click(WebDriver);

			string nonTiedId = string.Format("productConfig_{0}_selection_{1}", nonTiedSkuModule.Replace(" ", string.Empty),
					index - 1);
			string xpath = "//input[@id='" + nonTiedId + "']";
			WebDriver.GetElement(By.XPath(xpath)).Click(WebDriver);

			//Click the accordian available beside non-tied
			string id = string.Format("productConfig_{0}_selection_{1}", nonTiedSkuModule.Replace(" ", string.Empty),
					index - 1);
			WebDriver.GetElement(By.XPath("//input[@id='" + id + "']/..//a")).Click(WebDriver);

			//Select the nested non-tied passed in the parameters
			try
			{
				var nestednonTiedCheckBox = WebDriver.GetElement(By.XPath(" (//*[contains(text(),'" + nestednonTied + "')])[1]/../../../..//*[@id='productConfig_" + nonTiedSkuModule + "_selection_" + (nestedIndex - 1) + "']"));
				nestednonTiedCheckBox.Click(WebDriver);
			}
			catch (Exception e)
			{
				Logger.Write(e.Message);
			}
			new ProductConfigurePage(WebDriver).GoToCurrentQuotePage();
			return this;
		}

		public string ChangeOptionInAModule(string moduleName, int index)
		{
			WebDriver.GetElement(By.Id(string.Format("productConfig_option_0_{0}_toggle", moduleName.Replace(" ", string.Empty))))
				.Click(WebDriver);
			WebDriver.GetElement(By.Id(string.Format("productConfig_{0}_selection_{1}", moduleName.Replace(" ", string.Empty),
					index - 1))).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			//DsaUtil.waitForWaitAnimationToLoad(WebDriver);
			return WebDriver.GetElement(By.Id(string.Format("productConfig_{0}_desc_{1}", moduleName.Replace(" ", string.Empty),
					index - 1))).Text;
		}

		public bool SelectRequiredSku(int index = 1)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			var sku = WebDriver.GetElements(By.Id(string.Format("productConfig_CFIRequiredSKUs_selection_{0}", index - 1))).FirstOrDefault();
			sku.SelectCheckBox(WebDriver);
			return sku.IsElementClickable(WebDriver);
		}

		public bool UnSelectRequiredSku(int index = 1)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			var sku = WebDriver.GetElements(By.Id(string.Format("productConfig_CFIRequiredSKUs_selection_{0}", index - 1))).FirstOrDefault();
			sku.UnSelectCheckBox(WebDriver);
			return sku.IsElementClickable(WebDriver);
		}

		public void UnSelectNonTiedModuleSku(string moduledescription)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WebDriver.GetElements(By.XPath(string.Format("//td[contains(text(),'{0}')]/preceding-sibling::td/input", moduledescription))).FirstOrDefault().UnSelectCheckBox(WebDriver);
		}

		public void SelectNonTiedModuleSku(string moduledescription)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WebDriver.GetElements(By.XPath(string.Format("//td[contains(text(),'{0}')]/preceding-sibling::td/input", moduledescription))).FirstOrDefault().SelectCheckBox(WebDriver);
		}
		public ProductConfigurePage UpdateRequiredSkuQuantity(string quantity, int index = 1)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WebDriver.GetElements(By.XPath(string.Format("//*[@id='productConfig_CFIRequiredSKUs_quantity_{0}']/input", index - 1))).FirstOrDefault().SetText(WebDriver, quantity);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return this;
		}

		public bool ValidateCFIProjectAdded(string cfiProject)
		{
			bool visible = false;
			WebDriver.VerifyBusyOverlayNotDisplayed();

			if (WebDriver.TryFindElement(WebDriver.FindElement(By.XPath($"//div[@class='ng-star-inserted module-right col-md-12 offset-0 module-highlight']/descendant::span[contains(text(),'{cfiProject}')]"))))
			{
				visible = true;
			}
			return visible;
		}

		public string GetRequiredSkuPrice(int index = 1)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			var skuPrice = WebDriver.GetElements(By.Id($"productConfig_0_CFIRequiredSKUs_listPrice_{index - 1}")).FirstOrDefault();
			if (skuPrice != null)
			{
				return skuPrice.Text;
			}
			else
			{
				return string.Empty;
			}
		}

		public string GetRequiredSkuQuantity(int index = 1)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return WebDriver.GetElements(By.XPath(string.Format("//*[@id='productConfig_CFIRequiredSKUs_quantity_{0}']/input", index - 1))).FirstOrDefault().Text;
		}

		public string GetOptionDescriptionInModule(string moduleName, int index)
		{
			ExpandModule(moduleName);
			var desc = WebDriver.GetElement(By.Id(string.Format("productConfig_{0}_desc_{1}", moduleName.Replace(" ", string.Empty),
					index - 1))).Text;
			WebDriver.GetElement(By.Id(string.Format("productConfig_option_0_{0}_toggle", moduleName.Replace(" ", string.Empty))))
				.Click(WebDriver);
			return desc;
		}

		public string GetSelectedOptionDescriptionInModule(string moduleName, int itemIndex)
		{
			//WebDriver.GetElement(By.Id(string.Format("productConfig_option_0_{0}_toggle", moduleName.Replace(" ", string.Empty)))).Click(WebDriver);
			var desc = WebDriver.GetElement(By.Id(string.Format("productConfig_option_{1}_{0}_toggle", moduleName.Replace(" ", string.Empty),
					itemIndex - 1))).Text;
			//WebDriver.GetElement(By.Id(string.Format("productConfig_option_0_{0}_toggle", moduleName.Replace(" ", string.Empty)))).Click(WebDriver);
			return desc;
		}

		public int GetDurationCountInModule()
		{
			int DurationCount = WebDriver.FindElements(By.XPath("//table[@class='child-config-table']/tbody/tr/td[8]/input")).Count;
			return DurationCount;
		}

		public string GetDurationValuetInModule(string moduleName, int Index)
		{
			string DurationValue = WebDriver.GetElement(By.XPath(string.Format("//*[@id='productConfig_{0}_duration_{1}']/input", moduleName.Replace(" ", string.Empty), Index - 1))).GetAttribute("ng-reflect-model");
			return DurationValue;
		}

		public IWebElement GetDurationInServiceModule(string moduleName, int Index)
		{
			//clicking on module
			SelectOptionInModule(moduleName, Index);
			return WebDriver.GetElement(By.XPath(string.Format("//*[@id='productConfig_{0}_duration_{1}']/input", moduleName.Replace(" ", string.Empty), Index - 1)));

		}

		public string GetDefaultDurationForVIOption(string moduleName, int index)
		{
			IWebElement duration = GetDurationInServiceModule(moduleName, index);
			string DefaultDuration = DsaUtil.GetText(duration, WebDriver);
			// string DefaultDuration = duration.GetAttribute("ng-reflect-model");
			// duration.SetText(WebDriver, "57");
			return DefaultDuration;
		}

		public string[] GetMinMaxDurationForVIOption(string moduleName, int index)
		{
			IWebElement duration = GetDurationInServiceModule(moduleName, index);
			string[] durationrange = new string[2];
			//Get min duration
			durationrange[0] = duration.GetAttribute("ng-reflect-min");
			//Get max duration
			durationrange[1] = duration.GetAttribute("ng-reflect-max");
			return durationrange;
		}

		public bool[] verifyOptionDescAndListPriceChangeOnDurationChange(string moduleName, int index, string durationtoSet)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			IWebElement duration = GetDurationInServiceModule(moduleName, index);
			//Get option desc before duration change
			string optionDescBeforeChange = WebDriver.GetElement(By.Id(string.Format("productConfig_{0}_desc_{1}", moduleName.Replace(" ", string.Empty),
					index - 1))).Text;

			//Get list price before duration change
			WebDriver.VerifyBusyOverlayNotDisplayed();
			//if(WebDriver.TryFindElement(UpdateLnk,TimeSpan.FromSeconds(5)))	
			//UpdateLnk.Click();

			//IWebElement lstPrice = WebDriver.GetElement(By.XPath(string.Format("//*[@id='productConfig_0_{0}_listPrice_{1}']/span", moduleName.Replace(" ", string.Empty), index - 1)));
			IWebElement lstPrice = WebDriver.GetElement(By.XPath(string.Format("//*[@id='productConfig_0_{0}_listPrice_{1}']", moduleName.Replace(" ", string.Empty), index - 1)));
			string priceBeforeChange = lstPrice.Text;
			//Set duration to some value other than default value

			duration = WebDriver.GetElement(By.XPath(string.Format("//*[@id='productConfig_{0}_duration_{1}']/input", moduleName.Replace(" ", string.Empty), index - 1)));
			duration.SetText(WebDriver, durationtoSet);

			WebDriver.VerifyBusyOverlayNotDisplayed();
			//Get option desc after duration change
			string optionDescAfterChange = WebDriver.GetElement(By.Id(string.Format("productConfig_{0}_desc_{1}", moduleName.Replace(" ", string.Empty),
				  index - 1))).Text;
			//Get list price after duration change
			//if (WebDriver.TryFindElement(UpdateLnk, TimeSpan.FromSeconds(5)))
			//	UpdateLnk.Click();
			WebDriver.VerifyBusyOverlayNotDisplayed();

			//string priceAfterChange = WebDriver.GetElement(By.XPath(string.Format("//*[@id='productConfig_0_{0}_listPrice_{1}']/span", moduleName.Replace(" ", string.Empty), index - 1))).Text;
			string priceAfterChange = WebDriver.GetElement(By.XPath(string.Format("//*[@id='productConfig_0_{0}_listPrice_{1}']", moduleName.Replace(" ", string.Empty), index - 1))).Text;
			bool[] results = new bool[2];
			results[0] = optionDescBeforeChange.Equals(optionDescAfterChange);
			results[1] = priceBeforeChange.Equals(priceAfterChange);
			return results;
		}

		public string ChangeVIDuration(string moduleName, int index, string DurationToSet)
		{
			IWebElement duration = GetDurationInServiceModule(moduleName, index);
			//  string minDuration = duration.GetAttribute("ng-reflect-min");
			//Set duration to min duration
			duration = WebDriver.GetElements(By.XPath(string.Format("//*[@id='productConfig_{0}_duration_{1}']/input", moduleName.Replace(" ", string.Empty), index - 1))).LastOrDefault();
			duration.Click();
			duration.SetText(WebDriver, DurationToSet);
			return DurationToSet;
		}

		public void VerifyListPriceAndUpsellChangeOnVIOptionChange(string moduleName, int index)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();

			//clicking on module
			ExpandModule(moduleName);

			//Get list price and upsell price before 

			IWebElement listprice = WebDriver.GetElement(By.Id(string.Format("productConfig_0_{0}_listPrice_{1}", moduleName.Replace(" ", string.Empty), index - 1)));
			IWebElement upsellPrice = WebDriver.GetElement(By.Id(string.Format("productConfig_0_{0}_deltaPrice_{1}", moduleName.Replace(" ", string.Empty), index - 1)));

			string ListPriceBeforeChange = listprice.Text;
			string UpsellPriceBeforeChange = upsellPrice.Text;

			WebDriver.GetElement(By.Id(string.Format("productConfig_{0}_selection_{1}", moduleName.Replace(" ", string.Empty),
				   index - 1))).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();

			listprice = WebDriver.GetElement(By.Id(string.Format("productConfig_0_{0}_listPrice_{1}", moduleName.Replace(" ", string.Empty), index - 1)));
			upsellPrice = WebDriver.GetElement(By.Id(string.Format("productConfig_0_{0}_deltaPrice_{1}", moduleName.Replace(" ", string.Empty), index - 1)));

			string ListPriceAfterChange = listprice.Text;
			string UpsellPriceAfterChange = upsellPrice.Text;

			if (ListPriceAfterChange != ListPriceBeforeChange) { }
			if (UpsellPriceAfterChange != UpsellPriceBeforeChange) { }
		}

		public void ChangeLineItemQuantity(string moduleName, int Index, int newQty)
		{
			IWebElement quantity = GetQtyInModule(moduleName, Index);
			//Set quantity to new quantity
			quantity.SetText(WebDriver, newQty.ToString());

		}

		public IWebElement GetQtyInModule(string moduleName, int Index)
		{
			//clicking on module
			SelectOptionInModule(moduleName, Index);
			// DsaUtil.waitForWaitAnimationToLoad(WebDriver);
			return WebDriver.GetElement(By.XPath(string.Format("//*[@id='productConfig_{0}_quantity_{1}']/input", moduleName.Replace(" ", string.Empty), Index - 1)));

		}

		public IWebElement GetDisruptiveQtyInModule(string moduleName, int Index)
		{
			//clicking on module			
			SelectOptionInModule(moduleName, Index);
			IWebElement dq = WebDriver.GetElement(By.XPath(string.Format("//*[@id='productConfig_{0}_disruptiveQuantity_{1}']/span", moduleName.Replace(" ", string.Empty), Index - 1)));
			return dq;

		}

		public IWebElement GetDisruptiveQtyOfNestedNonTiedSku(string nonTiedSkuModule, int index, string nestednonTied, int nestedIndex)
		{
			IWebElement nestednonTiedDQty = null;
			//Add Non-Tied Item first
			ExpandModule(nonTiedSkuModule);

			string nonTiedId = string.Format("productConfig_{0}_selection_{1}", nonTiedSkuModule.Replace(" ", string.Empty),
					index - 1);
			string xpath = "//input[@id='" + nonTiedId + "']";
			WebDriver.GetElement(By.XPath(xpath)).Click(WebDriver);

			//Click the accordian available beside non-tied
			string id = string.Format("productConfig_{0}_selection_{1}", nonTiedSkuModule.Replace(" ", string.Empty),
					index - 1);
			WebDriver.GetElement(By.XPath("//input[@id='" + id + "']/..//a")).Click(WebDriver);

			//get the disruptive quantity of the nested non-tied passed in the parameters
			try
			{
				nestednonTiedDQty = WebDriver.GetElement(By.XPath(" (//table[@class='table prd-cfg-options-parent option-group']//*[contains(text(),'" + nestednonTied + "')])[1]/../../../..//*[@id='productConfig_" + nonTiedSkuModule + "_disruptiveQuantity_" + (nestedIndex - 1) + "']"));

			}
			catch (Exception e)
			{
				Logger.Write(e.Message);
			}
			return nestednonTiedDQty;
		}

		public IWebElement GetDisruptiveQtyofTiedSKU(string tiedSku)
		{
			WebDriver.GetElements(
				By.XPath(string.Format("//div[@id='tiedSku_multiple']/following::div/a[contains(.,'{0}')]", tiedSku))).Last().Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return WebDriver.GetElement(By.XPath(string.Format("//td[@id='disruptiveQuantity']/span", tiedSku)));

		}

		public IWebElement GetDisruptiveQtyOfCFI(int index = 1)
		{

			WebDriver.VerifyBusyOverlayNotDisplayed();
			//return WebDriver.GetElements(By.XPath(string.Format("//*[@id='productConfig_CFIRequiredSKUs_desc_{0}']", index - 1))).FirstOrDefault();
			return WebDriver.FindElements(By.XPath(string.Format("//td[@id='productConfig_CFIRequiredSKUs_quantity_{0}']/input", index - 1))).FirstOrDefault();
		}

		public bool ValidateCFIOptionalSKU(string skuNumber)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return WebDriver.FindElements(By.Id("productConfig_option_0_CFIOptionalSKUs_toggle"))[1].Text.Contains(skuNumber);

		}

		public bool ValidateTiedSkuErrorMessageContains(string errorMessage)
		{
			//var val = WebDriver.FindElements(By.XPath("//div[@class='alert alert-error ng-star-inserted']/ul/li"))[0];
			//var val = WebDriver.FindElements(By.XPath("//table[@id='DataTables_Table_gridNonTiedSKUDetails']//td")).LastOrDefault();
			var val = WebDriver.FindElements(By.XPath("//add-tied-skus/div/div/ul/li")).LastOrDefault();
			return val.Text.Contains(errorMessage);
		}

		public ProductConfigurePage ClickExpandModule(string moduleName)
		{
			var module =
				By.Id(string.Format("productConfig_option_0_{0}_toggle", moduleName.Replace(" ", string.Empty)));
			WebDriver.ScrollToElement(module);
			module.Click(WebDriver);
			return this;
		}


		public string GetMaringValueByOptionIndex(string moduleName, int index)
		{
			WebDriver.GetElement(By.Id(string.Format("productConfig_option_0_{0}_toggle", moduleName.Replace(" ", string.Empty))))
			   .Click(WebDriver);
			string optionMargin = WebDriver.GetElement(By.Id(string.Format("productConfig_{0}_marginAmount_{1}", moduleName.Replace(" ", string.Empty), index))).GetText(WebDriver);
			ClickExpandModule(moduleName);
			return optionMargin;
		}

		public string GetListPrice()
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			var price = ByLblSummaryListPrice.GetText(WebDriver);
			return price;
		}

		public void ClickTiedModalOK()
		{
			btnTiedModalOK.Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
		}

		public ProductConfigurePage GetMarginAndUnitMarginFromProductConfigurePage(IWebDriver webDriver, string productDescription, string moduleName)
		{
			ProductConfigurePage productConfigurePage = new ProductConfigurePage(webDriver);
			var itemsCount = int.Parse(new CreateQuotePage(webDriver).GetTotalItems());
			for (int i = 0; i < itemsCount; i++)
			{
				if (new CreateQuotePage(webDriver).GetLineItemProductDescription(i + 1).Equals(productDescription))
				{
					IJavaScriptExecutor Js = (IJavaScriptExecutor)WebDriver;
					Js.ExecuteScript("scroll(0, -250);");
					new CreateQuotePage(webDriver).Configure(i + 1);
					DsaUtil.WaitForPageLoad(WebDriver);
					WebDriver.VerifyBusyOverlayNotDisplayed();
					ProductConfigViewQuote.WaitForElement(webDriver);
					productConfigurePage.MarginForSelectedItem = ConfigPageMarginValueforselectedItem.GetText(WebDriver);
					productConfigurePage.UnitMarginForSelectedItem = ConfigPageUnitMarginValueforselectedItem.GetText(WebDriver);
					if (moduleName != "null")
					{
						string modulename = moduleName.Split('~')[0];
						int moduleOptionIndexSelected = int.Parse(moduleName.Split('~')[1]);
						int moduleOptionIndexToBeUpdated = int.Parse(moduleName.Split('~')[2]);
						productConfigurePage.ConfigOptionLevelMargin = GetMaringValueByOptionIndex(modulename, moduleOptionIndexSelected);
						ChangeOptionInAModule(modulename, moduleOptionIndexToBeUpdated);
						ClickExpandModule(modulename); //Used for collapsing the module
						productConfigurePage.ConfigOptionLevelMargin_AfterUpdates = GetMaringValueByOptionIndex(modulename, moduleOptionIndexSelected);
						// ClickExpandModule(moduleName); //Used for collapsing the module
						// ChangeOptionInAModule(moduleName, 1);                            
					}
					new ProductConfigurePage(WebDriver).GoToCurrentQuotePage();
					return productConfigurePage;
				}
			}
			return productConfigurePage;
		}

		public string[] GetInciteNotifications()
		{
			List<String> currentOptions = new List<String>();
			WebDriverUtil.WaitForElementDisplay(WebDriver, By.XPath("//div[@class='dtl-ctnr visible-lg']//span[contains(@id,'productConfig_productInfoLI_validationError')]/span/span/span"), TimeSpan.FromSeconds(5));

			foreach (IWebElement element in spanInciteRules)
			{
				currentOptions.Add(element.Text.ToString());
			}
			return currentOptions.ToArray();

		}

		public string GetDPASummaryText()
		{
			return summaryDPA.Text.ToString();
		}

		public string GetDBCSummaryText()
		{
			return summaryDBC.Text.ToString();
		}

		public string GetATSQuantity()
		{
			var atsquantity = WebDriver.FindElements(By.XPath("//product-config-detail//label[contains(text(),'ATS Quantity')]/following-sibling::div")).FirstOrDefault();
			//return ATSQuantity.GetText(WebDriver);
			return atsquantity.Text;

		}

		public string GetRestockInfo()
		{
			return Restock.GetText(WebDriver);
		}

		public string[] GetLeadTimeESDTypeAndChassis()
		{
			string[] configvalues = new string[4];
			configvalues[0] = LeadTime.GetText(WebDriver);
			configvalues[1] = ESD.GetText(WebDriver);
			configvalues[2] = OCType.GetText(WebDriver);
			configvalues[3] = Chassis.GetText(WebDriver);
			return configvalues;

		}
		//to check dupsku notification on product configure page-Sv
		public bool IsdupskuNotificationExist(IWebDriver webDriver, string errorNotificationMeassage)
		{
			
			IWebElement configureErrorNotifications = WebDriver.FindElements(By.XPath("//div[@class='alert alert-warning']")).FirstOrDefault();
			if (configureErrorNotifications.GetText(webDriver).ToLower().Contains(errorNotificationMeassage.ToLower()))
				return true;
			else
				return false;
		}
		//to check sales rep change notification-Sv
		
		#region EOLNotifications
		public int Get_countof_EOL_notifications(string EOLString)
		{
			string[] notifications = GetInciteNotifications();
			var notificationsCnt = 0;
			foreach (var notification in notifications)
			{
				if (notification.Contains(EOLString))
					notificationsCnt++;
			}
			return notificationsCnt;
		}
		#endregion

		public void ReplaceCfiProject(string replacementProject)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WebDriver.GetElement(By.XPath("//*[@id='main']/div/div/div/div[4]/div[4]/div/div/div[2]/div[4]/tabset/div/div/div[7]/div[2]/div[2]/div[1]/div/div/div/a/div[2]/span")).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WebDriver.GetElement(By.XPath("//*[@id='main']/div/div/div/div[4]/div[4]/div/div/div[2]/div[4]/tabset/div/div/div[7]/div[2]/div[2]/div[2]/div/div/div/form/div/div/div[1]/div/div/span[2]/span")).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			EnterConfigurationServicesProjects(replacementProject);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WebDriver.GetElement(By.XPath("//*[@id='main']/div/div/div/div[4]/div[4]/div/div/div[2]/div[4]/tabset/div/div/div[7]/div[2]/div[2]/div[2]/div/div/div/form/div/div/div[2]/div/div/div/div[4]/div/div[1]/button")).Click(WebDriver);
		}

		public void ReplaceCFIProjectFromSummaryTab(string existingPrj, string replacementProject)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			new ProductConfigurePage(WebDriver).SummaryTab.Click();
			WebDriver.VerifyBusyOverlayNotDisplayed();
			//List<IWebElement> elemts1 = WebDriver.GetElements(By.XPath("//div/span[contains(text(),'" + existingPrj + "')]"));
			WebDriver.GetElement(By.XPath("//div/span[contains(text(),'" + existingPrj + "')]")).Click(WebDriver);
			//elemts1[1].Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			//elemts1 = WebDriver.GetElements(By.XPath("//div/span[contains(text(),'" + existingPrj + "')]/../../../../../../following-sibling::div//span[contains(text(),'Configuration Services Projects')]"));
			WebDriver.GetElement(By.XPath("//div/span[contains(text(),'" + existingPrj + "')]/../../../../../../following-sibling::div//span[contains(text(),'Configuration Services Projects')]")).Click(WebDriver);

			WebDriver.VerifyBusyOverlayNotDisplayed();
			EnterConfigurationServicesProjects(replacementProject);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WebDriver.GetElement(By.XPath("//span[contains(text(),'Replace')]")).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WebDriver.TryFindElement(WebDriver.FindElement(By.XPath("//input[@popover='Comment Text is required']")));
			var requiredCommentcode =
					   WebDriver.FindElements(By.XPath("//input[@popover='Comment Code is required']"));
			var requiredComments =
				WebDriver.FindElements(By.XPath("//input[@popover='Comment Text is required']"));
			foreach (var comment in requiredComments)
			{
				comment.SendKeys("test");
			}

			foreach (var comment1 in requiredCommentcode)
			{
				comment1.SendKeys("testcode");
			}
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WebDriver.FindElement(By.Id("saveCsComments")).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
		}

		public string GetCfiWarningMessage()
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			string message = string.Empty;
			if (WebDriver.TryFindElement(WebDriver.FindElement(By.XPath("//display-error-info/div[contains(@class , 'alert')]/p[1]"))))
			{
				message = WebDriver.GetElement(By.XPath("//display-error-info/div[contains(@class , 'alert')]/p[1]")).Text;
			}
			return message;
		}

		public string GetNonTiedSKUPopupMessage()
		{
			string message = string.Empty;
			if (WebDriver.TryFindElement(nonTiedSKUAddPopUp))
			{
				message = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridNonTiedSKUDetails']/tbody/tr/td[4]")).Text;
			}
			return message;

		}
		public string EditQuantityOfModuleOption(string moduleName, int optionIndex, string quantity)
		{
			//clicking on module
			ExpandModule(moduleName);
			//WebDriver.GetElement(By.Id(string.Format("productConfig_{0}_selection_{1}", moduleName.Replace(" ", string.Empty),
			// optionIndex - 1))).Click(WebDriver);
			// WebDriver.VerifyBusyOverlayNotDisplayed();
			IWebElement OptionQty = WebDriver.GetElement(By.XPath(string.Format("//*[@id='productConfig_{0}_quantity_{1}']/input", moduleName.Replace(" ", string.Empty),
				   optionIndex - 1)));
			//productConfig_ConfigurationServices-CustomOrderFirst_quantity_0
			OptionQty.SetText(WebDriver, quantity);
			var qty = WebDriver.GetElement(By.XPath(string.Format("//*[@id='productConfig_{0}_quantity_{1}']/input", moduleName.Replace(" ", string.Empty),
				   optionIndex - 1))).GetText(WebDriver);
			return qty;
		}

		public bool HighlightedColor(int moduleNo)
		{
			bool result = false;
			try
			{
				if (WebDriver.GetElement(By.XPath(string.Format("//module//label[@id='productConfig_option_{0}']/parent::*/parent::*/parent::div[contains(@class, 'module-compare-highlight')]", moduleNo))).GetText(WebDriver) != null)
					return true;
			}
			catch (Exception)
			{
				Logger.Write("Given " + moduleNo + " Module is not highlighted due to no-differences found in modules data");
			}
			return result;
		}

		public IWebElement smartselectrecommendations(int recommendedproducts)
		{
			return WebDriver.FindElement(By.XPath(string.Format("//div[contains(@class,'smart-select-recommender-bottom')]/descendant::button[contains(text(),'Add')][{0}]", recommendedproducts)));
		}

		public bool IsTermsAndConditionLinkVisible(string module, int index = 1)
		{
			return WebDriver.FindElement(By.XPath(String.Format(
				"//input[@id = 'productConfig_{0}_selection_{1}']//following::tr//a[1]", module.Replace(" ", string.Empty), index - 1))).IsElementVisible();
		}
		public bool IsDisclosureVisible(string module, int index = 1)
		{
			return WebDriver.FindElement(By.XPath(String.Format(
				"//input[@id = 'productConfig_{0}_selection_{1}']//following::tr[2]//td[2]/div", module.Replace(" ", string.Empty), index - 1))).IsElementVisible();
		}

		// Commenting out Duplicate Methods with same signature
		/**
		public ProductConfigurePage ExpandModule(string moduleName)
		{
			IWebElement eleOptionSelected = null;
			By moduleBy = By.XPath(string.Format("//tab[@heading='Summary']//a[@id='productConfig_option_0_{0}_toggle']", moduleName.Replace(" ", string.Empty)));
			WebDriver.VerifyBusyOverlayNotDisplayed();
			try
			{
				eleOptionSelected = WebDriver.GetElement(By.XPath(String.Format("//tab[@heading='Summary']//table[@class='child-config-table']//td[@id='productConfig_{0}_desc_0']", moduleName.Replace(" ", string.Empty))), TimeSpan.FromSeconds(15));
				if (eleOptionSelected.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
					return this;
			}
			catch (Exception e)
			{
				eleOptionSelected = null;
				Console.WriteLine(e);
			}
			WebDriver.GetElement(moduleBy, TimeSpan.FromSeconds(15)).Click();
			return this;

		}

		public bool VerifyIsOptionSelected(string moduleName, string optionDescription, int optionIndex = 1)
		{
			try
			{
				ExpandModule(moduleName);
				IWebElement eleSelectedOption = WebDriver.GetElement(By.Id(string.Format("productConfig_{0}_selection_{1}", moduleName.Replace(" ", string.Empty), optionIndex - 1)), TimeSpan.FromSeconds(10));
				IWebElement eleSelectedOPtionLabel = WebDriver.GetElement(By.Id(string.Format("productConfig_{0}_desc_{1}", moduleName.Replace(" ", string.Empty), optionIndex - 1)), TimeSpan.FromSeconds(10));
				return eleSelectedOption.Selected & eleSelectedOPtionLabel.Text.Trim().Contains(optionDescription);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return false;
			}
		}

		public ProductConfigurePage SelectOptionInModule(string moduleName, int optionIndex = 1)
		{
			ExpandModule(moduleName);
			WebDriver.GetElement(By.Id(string.Format("productConfig_{0}_selection_{1}", moduleName.Replace(" ", string.Empty), optionIndex - 1)), TimeSpan.FromSeconds(10)).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			//DsaUtil.waitForWaitAnimationToLoad(WebDriver);
			return this;
		}

		*/
		public string GetSystemLevelDiscountDesc()
		{
			return lnkSystemLevelDiscount.Text.ToString();
		}

		public string GetDiscountIdFromPromotionPopup()
		{
			lnkSystemLevelDiscount.Click();
			WebDriver.VerifyBusyOverlayNotDisplayed();
			IWebElement discountId = WebDriver.GetElement(By.XPath(
				"//div[@class='modal-body content-bold']//div[text()='Discount Id']//following-sibling::div"));
			return discountId.Text.ToString();
		}

		public void ViewBundleDtlsLink(string moduleName)
		{
			IWebElement module = WebDriver.GetElement(By.Id(string.Format("productConfig_option_0_{0}_toggle", moduleName.Replace(" ", string.Empty))));
			WebDriver.GetElement(By.Id(string.Format("productConfig_option_0_{0}_toggle", moduleName.Replace(" ", string.Empty))))
				.Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			IWebElement lnkBundleDtls = lnkBundleDetails("View Bundle Details");
			lnkBundleDtls.Click();
		}

		public string GetBundleHeader(string moduleName)
		{
			string bundleHeaderXpath = "//tab[@heading='Summary']//span[contains(text()," + "'" + moduleName + "'" +
									   ")]//parent::label//span[contains(@class,'flex-icon')]";

			IWebElement bundleHeader = WebDriver.GetElement(By.XPath(bundleHeaderXpath));
			return bundleHeader.Text;
		}

		public bool GetBundleIcon(string moduleName)
		{
			string bundleHeaderXpath = "//tab[@heading='Summary']//span[contains(text()," + "'" + moduleName + "'" +
									   ")]//parent::label//i[@class='icon-small-deals module-flex-icon']";
			IWebElement bundleIcon = WebDriver.GetElement(By.XPath(bundleHeaderXpath));
			return bundleIcon.Displayed;
		}

		public IWebElement SelectOptionAndGetoptionDesc(string moduleName, int Index)
		{
			IWebElement module = WebDriver.GetElement(By.Id(string.Format("productConfig_option_0_{0}_toggle", moduleName.Replace(" ", string.Empty))));
			WebDriver.GetElement(By.Id(string.Format("productConfig_option_0_{0}_toggle", moduleName.Replace(" ", string.Empty))))
				.Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			WebDriver.GetElement(By.Id(string.Format("productConfig_{0}_selection_{1}", moduleName.Replace(" ", string.Empty),
				Index - 1))).Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return WebDriver.GetElement(By.XPath(string.Format("//*[@id='productConfig_{0}_desc_{1}']", moduleName.Replace(" ", string.Empty), Index - 1)));
		}

		public string GetUpSellTextForModule(string moduleName)
		{
			IWebElement module = WebDriver.GetElement(By.Id(string.Format("productConfig_option_0_{0}_toggle", moduleName.Replace(" ", string.Empty))));
			WebDriver.GetElement(By.Id(string.Format("productConfig_option_0_{0}_toggle", moduleName.Replace(" ", string.Empty))))
				.Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			IWebElement upSellText = WebDriver.GetElement(By.XPath("//tab[@heading='Summary']//span[@class='module-flex-content']"));
			return upSellText.Text;
		}

		public IWebElement GetViewDtlsLnkForOption(string moduleName, int optionIndex)
		{
			IWebElement module = WebDriver.GetElement(By.Id(string.Format("productConfig_option_0_{0}_toggle", moduleName.Replace(" ", string.Empty))));
			WebDriver.GetElement(By.Id(string.Format("productConfig_option_0_{0}_toggle", moduleName.Replace(" ", string.Empty))))
				.Click(WebDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			IWebElement lnkViewDtls = WebDriver.GetElement(By.XPath(string.Format("//tab[@heading='Summary']//td[@id='productConfig_{0}_desc_{1}']//a", moduleName.Replace(" ", string.Empty), optionIndex - 1)));
			return lnkViewDtls;
		}

		public string GetVPServiceNotification()
		{
			return VPServiceNotification.Text.ToString();
		}

		public string GetOptionListPrice(string moduleName, int index)
		{
			//WebDriver.GetElement(By.Id(string.Format("productConfig_option_0_{0}_toggle", moduleName.Replace(" ", string.Empty))))
			// .Click(WebDriver);
			//WebDriver.VerifyBusyOverlayNotDisplayed();
			//WebDriver.GetElement(By.Id(string.Format("productConfig_{0}_selection_{1}", moduleName.Replace(" ", string.Empty),
			// index - 1))).Click(WebDriver);
			//WebDriver.VerifyBusyOverlayNotDisplayed();
			var listPrice = WebDriver.GetElement(By.Id(string.Format("productConfig_0_{0}_listPrice_{1}", moduleName.Replace(" ", string.Empty),
				index - 1))).Text;
			return listPrice;
		}

		public string GetOptionDeltaPrice(string moduleName, int index)
		{
			//WebDriver.GetElement(By.Id(string.Format("productConfig_option_0_{0}_toggle", moduleName.Replace(" ", string.Empty))))
			// .Click(WebDriver);
			//WebDriver.VerifyBusyOverlayNotDisplayed();
			//WebDriver.GetElement(By.Id(string.Format("productConfig_{0}_selection_{1}", moduleName.Replace(" ", string.Empty),
			// index - 1))).Click(WebDriver);
			//WebDriver.VerifyBusyOverlayNotDisplayed();
			var listPrice = WebDriver.GetElement(By.Id(string.Format("productConfig_0_{0}_deltaPrice_{1}", moduleName.Replace(" ", string.Empty),
				index - 1))).Text;
			return listPrice;
		}

		public IWebElement GetViewDtlsLnkForNestedNonTied(string nonTiedSkuModule, int index, string nestednonTied, int nestedIndex)
		{
			IWebElement viewdtlsLnk = null;
			//Add Non-Tied Item first
			ExpandModule(nonTiedSkuModule);

			string nonTiedId = string.Format("productConfig_{0}_selection_{1}", nonTiedSkuModule.Replace(" ", string.Empty),
				index - 1);
			string xpath = "//input[@id='" + nonTiedId + "']";
			WebDriver.GetElement(By.XPath(xpath)).Click(WebDriver);

			//Click the accordian available beside non-tied
			string id = string.Format("productConfig_{0}_selection_{1}", nonTiedSkuModule.Replace(" ", string.Empty),
				index - 1);
			WebDriver.GetElement(By.XPath("//input[@id='" + id + "']/..//a")).Click(WebDriver);

			//get the disruptive quantity of the nested non-tied passed in the parameters
			try
			{
				// WebDriver.GetElement(By.XPath(" (//*[contains(text(),'" + nestednonTied + "')])[1]/../../../..//*[@id='productConfig_" + nonTiedSkuModule + "_disruptiveQuantity_" + (nestedIndex - 1) + "']"));
				viewdtlsLnk = WebDriver.GetElement(By.XPath("(//*[contains(text(),'" + nestednonTied +
												  "')])[1]/../../../..//*[@id='productConfig_" + nonTiedSkuModule +
												  "_desc_" + (nestedIndex - 1) +
												  "']//a"));
			}
			catch (Exception e)
			{
				Logger.Write(e.Message);
			}
			return viewdtlsLnk;
		}

		public bool ValidateAutoRenewalWindowOpened()
		{
			bool opened = false;
			foreach (var handle in WebDriver.WindowHandles)
			{
				opened = WebDriver.SwitchTo().Window(handle).Title.Contains("Auto-Renewal Terms");
			}

			return opened;
		}

		public void GetOptionIndicator()
		{
			if (WebDriver.GetElement(By.XPath("//a[contains(@class,'i-arrow-s')]")).IsElementClickable(WebDriver, TimeSpan.FromSeconds(5)))
			{
				WebDriver.GetElement(By.XPath("//a[contains(@class,'i-arrow-s')]")).Click(WebDriver);
				Console.WriteLine("Module Option Indicator is displayed and expanded");
			}
			else
			{
				WebDriver.GetElement(By.XPath("//a[contains(@class,'i-arrow-n')]")).Click(WebDriver);
				Console.WriteLine("Module Option is in Collapsed mode");
			}
		}

		public bool HighlightedColor(string moduleNo)
		{
			bool result = false;
			try
			{
				if (WebDriver.GetElement(By.XPath(string.Format("//module//label[@id='productConfig_option_{0}']/parent::*/parent::*/parent::div[contains(@class, 'module-compare-highlight')]", moduleNo))).GetText(WebDriver) != null)
					return true;
			}
			catch (Exception)
			{
				Logger.Write("Given " + moduleNo + " Module is not highlighted due to no-differences found in modules data");
			}
			return result;
		}

		public string GetErrorMessage()
		{
			return WebDriver.FindElement(By.XPath("//div[@class='alert alert-error ng-star-inserted']")).Text;

		}

		public string BaseSKUNotification()
		{
			return WebDriver.FindElement(By.XPath("//div[@class='alert alert-error ng-star-inserted']/p[contains(text(),'Cannot add non-configurable Base SKUs')]")).Text;

		}

		public string GetMatchingPercentage()
		{
			string MatchingText = WebDriver.FindElement(By.XPath("//div[@class='prod-detail-block']")).Text;
			string[] strarr = MatchingText.Split('%');
			double matchingpercentage = Convert.ToDouble(strarr[0]);
			if (matchingpercentage > 75)
				return "Smart selection percentage is greater than 75";
			else
				return "Smart selection percentage is not greater than 75";
		}

		public string GetMoreMatchingPercentage()
		{
			IList<IWebElement> elementList = WebDriver.FindElements(By.XPath("//div[@class='prod-detail-block']"));
			List<string> validations = new List<string>();
			foreach (IWebElement element in elementList)
			{
				validations.Add(element.Text.ToString());
			}
			foreach (string val in validations)
			{
				string[] strarr = val.Split('%');
				double matchingpercentage = Convert.ToDouble(strarr[0]);
				if (matchingpercentage > 75)
					Console.WriteLine("Smart selection percentage is greater than 75");
				else
					return "Wrong Matching percentage";
			}
			return "Smart selection percentage is greater than 75";

		}

		public bool GetTaxValues()
		{
			List<string> taxvalues = new List<string>(); ;
			IList<IWebElement> elementList = WebDriver.FindElements(By.XPath("//div[@class='data-group totaltax-position ng-star-inserted']//label[@class='col-md-6']"));
			foreach (IWebElement element in elementList)
			{
				taxvalues.Add(element.Text.ToString());
			}

			if (taxvalues.Count != 0)
				return true;
			else
				return false;
		}

		public void SelectConfigurationDropDown(string Option)
		{
			IWebElement element = WebDriver.FindElement(By.XPath("//select"));
			SelectElement selector = new SelectElement(element);
			selector.SelectByText(Option);

		}
		public void ViewProductsLeftSide(int index)
		{
			WebDriver.GetElement(By.CssSelector(string.Format("i.icon-ui-arrowleft")))
				.Click(WebDriver);
		}

		public string GetConfigurationDifferences()
		{
			string ProductDetailText = WebDriver.FindElement(By.XPath("//p[@class='prod-detail-text']/span[2]")).Text;
			if (ProductDetailText != null)
				return ProductDetailText;
			else
				return "This is a 100% matched product, so no differences found";
		}


		//public bool RequiredCommentsEnter()
		//{
		//	return WebDriver.TryFindElement(WebDriver.FindElement(By.XPath("//input[@popover='Comment Code is required']")));
		//}

		//public bool SaveonComments()
		//      {

		//	return WebDriver.TryFindElement(WebDriver.FindElement(By.Id("saveCsComments")));

		//}
		public void ClickAddConfigurationProject()
		{
			WebDriver.FindElement(By.XPath("//div[@class='cfs-project-id-input-wrapper clearfix']/button")).Click();
		}


		public string getpreventdupskuerrormsg()
		{
			return WebDriver.FindElement(By.XPath("//add-tied-skus//li")).Text;
		}
		public string GetErrorMessageForMissingOrderCode()
		{
			return WebDriver.FindElement(By.XPath("//div[@class='alert alert-warning rest-error-msg']/p[contains(text(),' An error occurred while loading the configuration.')]")).Text;

		}
		public string ModuledescriptioninConfigurePage(IWebDriver WebDriver)
		{
			return WebDriver.FindElement(By.XPath("//div[@class='alert alert-warning']//span[contains(text(),'Requested Module')]")).Text;


		}

		public bool AddNonTiedSku_TiedSkutab()
		{

			if (WebDriver.TryFindElement(nonTiedSKUAddPopUp))
			{
				WebDriver.FindElement(By.XPath("//table[@id='DataTables_Table_gridNonTiedSKUDetails']//tbody//td/input")).Click();
				WebDriver.FindElement(By.XPath("//button[@id='nontied_skus_AddButton']")).Click();
				return true;

			}
			else
			{
				return false;
			}

		}

		public IWebElement lnkTiedSkuadded(string tiedSku)
		{
			return WebDriver.GetElements(By.XPath("(//a[contains(text(),'" + tiedSku + "')])")).LastOrDefault();
		}

		public IWebElement ProductConfigDropdown { get { return WebDriver.GetElement(By.XPath("//*[@id='body - content']/div[2]/app-root/product-configure/div[2]/div/div/div[4]/div[3]/div/div[2]/div[1]/div/div/select")); } }



		public IWebElement TypeinConfig_BTS { get { return WebDriver.GetElement(By.XPath("//*[@id='body-content']/div[2]/app-root/product-configure/div[2]/div/div/div[3]/div[1]/div/div[2]/product-config-detail/div[2]/div/div/div/div/div[4]/div")); } }
		
		public IWebElement TypeinConfig { get { return WebDriver.GetElement(By.XPath("//*[@id='body-content']/div[2]/app-root/product-configure/div[2]/div/div/div[3]/div[1]/div[1]/div[2]/product-config-detail/div[2]/div/div/div/div/div[3]/div")); } }

		//*[@id='body-content']/div[2]/app-root/product-configure/div[2]/div/div/div[4]/div[1]/div[1]/div[1]/product-config-detail/div[2]/div/div/div/div/div[3]/label

		public bool VerifyDFIcon(string moduleName, int itemIndex)
		{
			
			IWebElement DFicon = WebDriver.GetElement(By.XPath(string.Format("//*[@id='productConfig_option_{1}_{0}_toggle']//span[@class='dds__icons dds__management-software text-dell-blue']/..", moduleName.Replace(" ", string.Empty),
					itemIndex - 1)));
			
			if (DFicon.IsElementVisible())
			{
				return true;
			}
				
			else 
				return false;
		}

		public string VerifyDFIconToolTip(string moduleName, int itemIndex)
		{
			IWebElement DFicon = WebDriver.GetElement(By.XPath(string.Format("//*[@id='productConfig_option_{1}_{0}_toggle']//span[@class='dds__icons dds__management-software text-dell-blue']/..", moduleName.Replace(" ", string.Empty),
					itemIndex - 1)));
			string tooltip = null;
			if (DFicon.IsElementVisible())
			{
				tooltip = DFicon.GetAttribute("title");
				Actions actions = new Actions(WebDriver);
				actions.MoveToElement(DFicon).Perform();				
				return tooltip;
			}
			else
				return tooltip;
		}
		public bool VerifyDFIconOptionLevel(string moduleName, int index)
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			IWebElement DFIconOptionLevel = WebDriver.GetElement(By.XPath(string.Format("//*[@id='productConfig_{0}_desc_{1}']/span", moduleName.Replace(" ", string.Empty),
					index - 1)));

			if (DFIconOptionLevel.IsElementVisible())
			{
				return true;
			}

			else
				return false;
		}
		public bool VerifyFBIcon(string moduleName, int itemIndex)
		{

			IWebElement FBicon = WebDriver.GetElement(By.XPath(string.Format("//*[@id='productConfig_option_{1}_{0}_toggle']//span[@class='dds__icons dds__currency-coins']/..", moduleName.Replace(" ", string.Empty),
					itemIndex - 1)));

			if (FBicon.IsElementVisible())
			{
				return true;
			}

			else
				return false;
		}
		public IWebElement lnkSelectAll { get { return WebDriver.GetElement(By.LinkText("Select All")); } }
		public IWebElement lnkRemoveAll { get { return WebDriver.GetElement(By.LinkText("Remove All")); } }
		public IWebElement lnkRemoveSelected { get { return WebDriver.GetElement(By.LinkText("Remove Selected")); } }

		public void SelectProduct_ConfigurePage(string ordercode)
		{
			WebDriver.GetElement(By.XPath(string.Format("//span[contains(text(),'{0}')]/parent::p/parent::div/parent::div//span[2]", ordercode)))
				.Click(WebDriver);
		}
		public IWebElement projectColumntext { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_cfsGrid']//th[2]/span")); } }
		public IWebElement lblCFSAdminoverride { get { return WebDriver.GetElement(By.XPath("//*[@id='cfs-admin-override']/following-sibling::label")); } }
	}

}

