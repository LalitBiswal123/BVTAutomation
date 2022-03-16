using System;
using System.Linq;
using System.Collections.Generic;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;
using System.Globalization;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Interactions;
using Dsa.Pages.Quote;
using FluentAssertions;
//using PageObjects = SeleniumExtras.PageObjects;

namespace Dsa.Pages.Solutions
{
	public class SolutionConfigurationPage : DsaPageBase
	{
		protected IWebDriver webDriver;
		public static string productName;
		public const string defaultGroupNumber = "1";
		public const string GroupNumberAttribute = "data-quotesequence";
		public SolutionConfigurationPage(IWebDriver webDriver)
			: base(webDriver)
		{
			this.webDriver = webDriver;
			Name = "Solution Configurator";
			PageFactory.InitElements(webDriver, this);
			webDriver.WaitForPageLoad();
		}

		#region Elements


public IWebElement AddProductsTab { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Add Product')]")); } }


public IWebElement DraftQuoteLink { get { return WebDriver.GetElement(By.XPath("//span[@id='quoteList']")); } }


public IWebElement TxtSearchProducts { get { return WebDriver.GetElement(By.XPath("//input[@placeholder='Enter product name, SKU, service tag or product model']")); } }


public IWebElement ProdcutSearchBtn { get { return WebDriver.GetElement(By.XPath("//button[contains(text(),'Search')]")); } }


public IWebElement AddProductTab { get { return WebDriver.GetElement(By.XPath("//div[@id='Composer']//a[contains(@href, 'Composer-0')]")); } }


public IWebElement SaveLink { get { return WebDriver.GetElement(By.XPath("//*[@id='combo-save-SaveAs']/div/span/button")); } }

		//[FindsBy(How = How.XPath, Using = @"//*[contains(@class,'solutionidverion solutionversion')]")]

public IWebElement SolutionIDLabel { get { return WebDriver.GetElement(By.XPath("//*[@id='solutioncomposer-solutionName']/following-sibling::span")); } }


public IWebElement CatalogLabel { get { return WebDriver.GetElement(By.XPath("//*[@id='solutionComposerHeaderMainComponent']//div[1]//div[3]//div[2]//div[1]/div")); } }


public IWebElement CustomerLabel { get { return WebDriver.GetElement(By.XPath("//*[@id='solutionComposerHeaderMainComponent']//div[1]//div[3]//div[2]//div[3]/div")); } }


public IWebElement OfferCategoryLnk { get { return WebDriver.GetElement(By.Id("offerCategoryLink")); } }


public IWebElement TxtSolutionOfferCategoryDropdown { get { return WebDriver.GetElement(By.Id("solutionOfferCategory")); } }


public IWebElement SaveSolutionOfferCategoryBtn { get { return WebDriver.GetElement(By.Id("btnSaveSolutionOfferCategory")); } }


public IWebElement MoreOptionsBtn { get { return WebDriver.GetElement(By.XPath("//button[contains(text(), 'More Options')]")); } }


public IWebElement EditNameLnk { get { return WebDriver.GetElement(By.Id("composer-header-EditName")); } }


public IWebElement ContinueBtn { get { return WebDriver.GetElement(By.Id("BtnContinueOnPopUp")); } }

public IWebElement BtnSaveAs { get { return WebDriver.GetElement(By.XPath("//button[@id='btnSaveSolutionAs']")); } }

public IWebElement TxtEditName { get { return WebDriver.GetElement(By.Id("solutionName")); } }


public IWebElement SaveSolutionNameBtn { get { return WebDriver.GetElement(By.Id("btnUpdateSolutionName")); } }


public IWebElement CancelSolutionNameBtn { get { return WebDriver.GetElement(By.Id("btnCancelSolutionName")); } }


public IWebElement ReactAddProductDiv { get { return WebDriver.GetElement(By.ClassName("dds__btn dds__btn-secondary dds__btn-sm PD_productlist-add")); } }


public IWebElement SelectSingleOrMultiQuote { get { return WebDriver.GetElement(By.XPath("//div[input[@id='quoteonoffswitch']]/label/span[2]")); } }


public IWebElement ConfigErrorValidateBtn { get { return WebDriver.GetElement(By.Id("btnValidateSolution")); } }


public IWebElement SaveAsBtn { get { return WebDriver.GetElement(By.XPath("//*[@id='composer-header-solutionbutton-saveas-link' and contains(@class, 'dds__btn dds__btn-secondary buttons-Margin-right')]")); } }


public IWebElement SaveAsBtnNew { get { return WebDriver.GetElement(By.Id("composer-header-solutionbutton-saveas-link")); } }


public IWebElement SaveToggleButton { get { return WebDriver.GetElement(By.XPath("//*[@id='combo-save-SaveAs']/div/button")); } }


public IWebElement updates { get { return WebDriver.GetElement(By.Id("updateVariblePrice")); } }


public IWebElement SaveAsNewVersionRadioBtn { get { return WebDriver.GetElement(By.Id("rdbSaveAsVersion")); } }


public IWebElement SaveAsNewSolutionRadioBtn { get { return WebDriver.GetElement(By.XPath("//*[@id='SaveAsModal' and @aria-hidden='false']//*[@id='rdbSaveAsSolution']")); } }


public IWebElement SaveAsBtnOnDialog { get { return WebDriver.GetElement(By.Id("btnSaveSolutionAs")); } }

		
public IWebElement SendToQuoteValidationDailogForValidationError { get { return WebDriver.GetElement(By.Id("composer-sendtoquote-dsa-override-validationerrors")); } }


public IWebElement SendToQuoteValidationDailogForXPODError { get { return WebDriver.GetElement(By.Id("composer-sendtoquote-dsa-override-validationerrorsforxpod")); } }


public IWebElement ChkBoxValidationOvveride { get { return WebDriver.GetElement(By.Id("chkValidationOverride")); } }


public IWebElement SendToQuoteCheckBoxForValidation { get { return WebDriver.GetElement(By.Id("chkValidationOverrideConfirmationMessage")); } }


public IWebElement SendToQuoteCheckBoxForXPOD { get { return WebDriver.GetElement(By.Id("chkXPODOverrideConfirmationMessage")); } }


public IWebElement SendToQuoteValidationerrorContinueToQuote { get { return WebDriver.GetElement(By.Id("composer-sendtoquote-dsa-override-validation-continue-button")); } }


public IWebElement SendToQuoteXPODerrorContinueToQuote { get { return WebDriver.GetElement(By.Id("composer-sendtoquote-dsa-override-XPOD-continue-button")); } }


public IWebElement GroupTab { get { return WebDriver.GetElement(By.XPath("//*[@id='GroupsTabHeader']/a")); } }


public IWebElement CustomGroupName1 { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'Custom Group 1')]")); } }


public IWebElement CustomGroupName2 { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'Custom Group 2')]")); } }


public IWebElement CustomProductName1 { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'PRODUCT1')]")); } }


public IWebElement CustomProductName2 { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'PRODUCT2')]")); } }

		//[FindsBy(How = How.Id, Using = @"button-default-dropdown")]
		//public IWebElement MoreOptions;


public IWebElement ChangeCatalogBtn { get { return WebDriver.GetElement(By.Id("composer-header-switchCatalogButton")); } }


public IWebElement catalogElement { get { return WebDriver.GetElement(By.XPath("//label[text()='Small Business (04)']")); } }


public IWebElement ChangeCatalogNextBtn { get { return WebDriver.GetElement(By.XPath("//div[@id='switchcatalogbuttons']//button[contains(text(), 'Next')]")); } }


public IWebElement ChangeCatalogFinishBtn { get { return WebDriver.GetElement(By.XPath("//div[@id='switchcatalogbuttons']//button[contains(text(), 'Finish')]")); } }

		protected By ByTagtr { get { return By.TagName("tr"); } }

		protected By ReactAddProductDivBy { get { return By.Id("ComposerComponent"); } }

public IWebElement ClickOnReturnToHome { get { return WebDriver.GetElement(By.Id("go-to-quotes-link")); } }


public IWebElement MoreDdl { get { return WebDriver.GetElement(By.XPath("//*[@id='TSRMenu']/ul/li/a")); } }


public IWebElement SelectCatalog { get { return WebDriver.GetElement(By.Id("Inside Corp (08)")); } }


public IWebElement BtnSelectCatalog { get { return WebDriver.GetElement(By.Id("switchcatalogbuttons")); } }


public IWebElement TiedSkuSearchBox { get { return WebDriver.GetElement(By.Id("AddTiedItemText")); } }


public IWebElement TiedSkuAddBtn { get { return WebDriver.GetElement(By.Id("AddTiedItem")); } }


public IWebElement ConfigSettingLink { get { return WebDriver.GetElement(By.Id("EditConfigSettingLink")); } }


public IWebElement ICodedSKUsOption { get { return WebDriver.GetElement(By.XPath(".//div[span[contains(text(),'I-Coded SKUs')]]")); } }


public IWebElement ConfigSettingCloseButton { get { return WebDriver.GetElement(By.XPath("//div[div[h3[contains(text(),'Configurator Settings')]]]//button[contains(text(),'Close')]")); } }

		//[FindsBy(How = How.XPath, Using = @"//span[text()='Expand all']")]

public IWebElement ExpandAllLink { get { return WebDriver.GetElement(By.XPath("//a[text()='Expand all']")); } }


public IWebElement ICodedSkusInItemConfigurations { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'I-Coded')]")); } }


public IWebElement QuickAddSearchText { get { return WebDriver.GetElement(By.Id("QuickAdd/SearchText")); } }


public IWebElement QuickAddItemListDialog { get { return WebDriver.GetElement(By.Id("QuickAdd/ItemList")); } }


public IWebElement QuickAddSearchAddBtn { get { return WebDriver.GetElement(By.XPath(".//div[input[@id='QuickAdd/SearchText']]/button")); } }


public IWebElement ConfigTabProductList { get { return WebDriver.GetElement(By.Id("product-list-wrapper")); } }


public IWebElement SaveAsModalDialog { get { return WebDriver.GetElement(By.XPath(".//*[@id='SaveAsModal']/div/div")); } }


public IWebElement ProductDiscoveryAddBtn { get { return WebDriver.GetElement(By.XPath(".//*[@id='ProductDiscovery/Modal']//button[contains(text(),'Add')]")); } }


public IWebElement SFDCDealID { get { return WebDriver.GetElement(By.Id("composer-header-registered-deal-id")); } }


public IWebElement AssociateDeal { get { return WebDriver.GetElement(By.Id("solutionscomposer-registerdeal-button")); } }


public IWebElement InputDeal { get { return WebDriver.GetElement(By.Id("txtDealId")); } }


public IWebElement ApplyDeal { get { return WebDriver.GetElement(By.Id("composer-patchdeal-dialog-btnApply")); } }


public IWebElement PatchedDeal { get { return WebDriver.GetElement(By.XPath("//span[@class='composer-header-registerdeal-dealid']")); } }

        //[FindsBy(How = How.XPath, Using = @"//*[@id='product-list-wrapper dds_margin-top3']/div/div/div/div/div[2]/div[2]/div[1]/p[2]/span/div/span[3]/button")]
        //public IWebElement IncreaseQty;     


public IWebElement IncreaseQty { get { return WebDriver.GetElement(By.XPath("//button[@class = 'spinbox-increase']")); } }

		protected By AddButtonBy { get { return By.Id("btnSearchToAddProduct"); } }


		public IWebElement SearchCategoryDropdown { get { return WebDriver.GetElement(By.XPath("//*[@id='ComposerComponent']//select")); } }


public IWebElement BtnAddOrderCode { get { return WebDriver.GetElement(By.Id("btnOrderCodeAdd")); } }

		protected By EnclosureSelectionBy { get { return By.Id("hostControl"); } }

		protected By GroupsTabHeader { get { return By.XPath(".//li[@id='GroupsTabHeader']/a"); } }

		protected By ConfigTab { get { return By.XPath(".//div[@id='Composer']/ul/li[2]/a"); } }

		protected By PowerCords { get { return By.XPath(".//span[contains(text(),'Power Cords')]"); } }

		protected By PowerCordCheckBox { get { return By.XPath(".//ul[li[div[span[span[contains(text(),'Power Cords')]]]]]/ul/div/div[2]//div[span[input[@checked='']]]/span[2]/span[1]/input[@id='product-options-multi-select-quantity']"); } }
		public IList<IWebElement> Groups { get { return webDriver.FindElements(By.XPath(".//*[@class='configuration-groupstab-reloader']//div[@class='configuration-groupstab-group']")); } }
		protected By ProductRowsOfGroup { get { return By.XPath(".//*[contains(@class, 'configuration-groupstab-group-products-body')]/div"); } }

		public By ByGroups { get { return By.XPath(".//*[@class='configuration-groupstab-reloader']//div[@class='configuration-groupstab-group']"); } }
		protected IWebElement NewGroup { get { return webDriver.FindElement(By.XPath(".//div[contains(@class,'configuration-groupstab-group-new-group-container')]")); } }

		protected By ByGroupID { get { return By.CssSelector("[class*='configuration-groupstab-uniqueid']"); } }

		protected By CheckforSingleQuote { get { return By.XPath("//div[@class='col-xs-3 switch-left-caption switch-caption-highlight']"); } }

		protected IList<IWebElement> ModuleInfo { get { return webDriver.FindElements(By.XPath("//span[@class='col-md-5 col-md-pull-1 description']/span[1]")); } }
		protected IList<IWebElement> OptionInfo { get { return webDriver.FindElements(By.XPath("//span[@class='col-md-7 col-md-pull-1 description']/span[1]")); } }

		protected By ValidationErrorssection { get { return By.XPath(".//*[@id='product-details-wrapper']/span/div[div[@class='validation-message-indicator-wrapper']/span/span[contains(text(),'Error')]]"); } }
		protected By ByConfigurationTab { get { return By.XPath(".//*[@id='Composer']/ul/li[2]/a"); } }
		protected IWebElement ConfigurationTab { get { return WebDriver.FindElement(By.XPath(".//*[@id='Composer']/ul/li[2]/a")); } }

		protected By SendToQuoteLink { get { return By.XPath("//div[*[@id='quoteListLink']]/span"); } }

		protected By VerifyCannotSendToQuoteDailogby { get { return By.XPath("//div[div[div[contains(text(),'Cannot send to Quote')]]]"); } }

		protected By Typ6TiedSkuErrorMessage { get { return By.XPath(".//span[contains(text(),'You don’t have access to add CFI Sku’s')]"); } }

		protected By ICodedSkusInItemConfigurationsby { get { return By.XPath("//span[contains(text(),'I-Coded')]"); } }

		protected By QuickAddItemList { get { return By.XPath(".//*[@id='QuickAdd/ItemList']/div"); } }

		protected By QuickAddItemSelect(string OEMProduct)
		{
			return By.XPath(".//a[text()='" + OEMProduct + "']");
		}
		#region Tied SKU Number Elements with react

		// Element for SKU Number
		protected IWebElement TiedSkuNumberTextbox
		{
			get { return webDriver.FindElement(By.Id("AddTiedItemText")); }
		}
		// Element Tied Item List Wrapper
		protected IList<IWebElement> TiedItemListWrapper
		{
			get { return webDriver.FindElement(By.Id("tied-item-list-wrapper")).FindElements(By.TagName("td")); }
		}

		private IWebElement AddTiedItem
		{
			get { return webDriver.FindElement(By.Id("AddTiedItem")); }
		}
		private IList<IWebElement> IncreaseSkuQty
		{
			get { return webDriver.FindElement(By.Id("TiedItemListContent")).FindElements(By.TagName("tr")); }

		}

		private By IncreaseSkuQtyBtn
		{
			get { return By.XPath(".//*[contains(@class, 'spinbox-increase')]"); }

		}
		// Get the drag icon of product to click on the product
		public By DragIconOfProduct
		{
			get { return By.XPath(".//*[contains(@class, 'draggableIcon-product')]"); }
		}
		protected By ProductCountInputBy
		{
			get { return By.XPath(".//*[contains(@class,'spinbox-input')]"); }
		}
		/// <summary>
		/// Locate blue text in product box
		/// </summary>
		protected By BlueTextBy
		{
			get { return By.XPath(".//*[contains(@class,'text-blue')]"); }
		}
		//private readonly double findElementWaitTime =
		//    double.Parse(ConfigurationManager.AppSettings["FindElementWaitTime"]);
		/// <summary>
		/// Product list wrapper
		/// </summary>
		public IWebElement ProductListWrapper
		{
			get { return ConfigurationWrapper.FindElement(By.Id("product-list-wrapper")); }
		}
		/// <summary>
		/// Locate the element of configuration tab wrapper
		/// </summary>
		protected IWebElement ConfigurationWrapper
		{
			get
			{
				return webDriver.FindElement(By.Id("composer-configuration-wrapper"));
			}
		}
		/// <summary>
		/// Locate product box
		/// </summary>
		public By ProductBoxBy
		{
			get { return By.XPath(".//*[contains(@class,'product-box')]"); }
		}
		public IReadOnlyCollection<IWebElement> GetAllProductBoxes
		{
			get
			{
				//return ProductListWrapper.FindElements(By.ClassName("row"));
				//Wait for 15 seconds and return an empty collection if no elemets are found.
				return ProductListWrapper.FindElements(ProductBoxBy);
			}
		}
		#endregion
		public IWebElement GroupDragDropOkBtn { get { return webDriver.FindElement(By.Id("btnMoveQuantityOk")); } }

		public IWebElement ShippingMethodLnk
		{
			get
			{
				return webDriver.FindElements(
					By.XPath("//span[@class='dds_accordion_blue_color' and contains(text(), 'Shipping Method')]"))[0];
			}
		}

		public IWebElement ShippingInstructionsLnk
		{
			get
			{
				return webDriver.FindElements(
					By.XPath("//span[@class='dds_accordion_blue_color' and contains(text(), 'Shipping Instructions')]"))[0];
			}
		}

		public IWebElement EnterShipInstructions
		{
			get
			{
				return webDriver.FindElements(
					By.XPath("//div//span//textarea[contains(@class, 'common-sharesolution-medium-dialog-textarea group-shipping-instruction-text top-offset-20')]"))[0];
			}
		}

		public void ClickShippingDetails()
		{
			WebDriver.FindElement(By.Id("lnkGroupsTab")).Click(webDriver);
		}


	public IWebElement TxtEnterOrderCode { get { return WebDriver.GetElement(By.XPath("//input[@placeholder='Enter Order Code']")); } }

		#endregion

		#region ChannelFlow elements
                public IWebElement LnkManageAccount { get { return WebDriver.GetElement(By.Id("manageAccountLink")); } }


        public IWebElement TxtEnterEndCustomer { get { return WebDriver.GetElement(By.Id("enterEndCustomer")); } }


public IWebElement TxtEnterSolutionName { get { return WebDriver.GetElement(By.Id("installATAggregateName")); } }

	
        public IWebElement BtnSubmit { get { return WebDriver.GetElement(By.XPath("//div[contains(@class, 'modal-dialog1')]//button[contains(text(), 'Submit')]")); } }


        public IWebElement BtnCreateQuote { get { return WebDriver.GetElement(By.XPath("//button[contains(text(), 'Create Quote')]")); } }


public IWebElement LnkQuoteNumber { get { return WebDriver.GetElement(By.XPath("//span[contains(@class, 'blueLink')]//following::span[contains(@id, 'QuoteLink')]")); } }

		public IWebElement LblSolutionNo { get { return WebDriver.GetElement(By.XPath("//*[@id='solutionComposerHeaderMainComponent']//span[2]/text()[2]")); } }

		public IWebElement BtnGroupTab { get { return WebDriver.GetElement(By.Id("lnkGroupsTab")); } }

		public IWebElement SaveAndSaveAsDropDownCombo { get { return WebDriver.GetElement(By.XPath("//*[@id='combo-save-SaveAs']/div/button")); } }


     
        public IWebElement GetSolutionId { get { return WebDriver.GetElement(By.XPath("//span[contains(@class, 'h3-fontsize-24')]/following-sibling::span[contains(text(), ' ')]")); } }


               public IWebElement DrpdwnSelectPaymentMethod { get { return WebDriver.GetElement(By.XPath("//div[contains(text(), 'quotes to be created')]/following-sibling::div/select]")); } }


        public IWebElement BtnContinueCreateQuote { get { return WebDriver.GetElement(By.XPath("//button[@class = 'btn btn-primary' and contains(text(), 'Continue')]")); } }

		
        public IWebElement BtnOkOnQuoteCreateInProgressPopUp { get { return WebDriver.GetElement(By.XPath("//div[contains(@class, 'modal fade in')]//button[@class='btn btn-primary']")); } }


        //Manage Account

        public IWebElement LnkEditSalesMotion { get { return WebDriver.GetElement(By.XPath("//div[contains(@class, 'sales-motion-text')]/../div[contains(@class, 'sale-btn-section')]/a[contains(@class, 'pencil')]")); } }


        public IWebElement LnkEditPartnerAccount { get { return WebDriver.GetElement(By.Id("editbutton_0")); } }


public IWebElement LnkEditBillToCustomer { get { return WebDriver.GetElement(By.Id("editbutton_1")); } }


public IWebElement LnkEditEndUserCustomer { get { return WebDriver.GetElement(By.XPath("//*[@id='EndCustomer']//a[contains(@class, 'pencil')]")); } }


public IWebElement LnkEditShipToCustomer { get { return WebDriver.GetElement(By.Id("editbutton_4")); } }

		
        public IWebElement LnkEditInstallAtCustomer { get { return WebDriver.GetElement(By.Id("editbutton_6")); } }


        public IWebElement BtnOk { get { return WebDriver.GetElement(By.Id("okBtn")); } }


public IWebElement SaveAndSaveAsDropdown { get { return WebDriver.GetElement(By.ClassName("dropdown-combo-button")); } }

		#endregion

		#region New Manage Account Elements


public IWebElement LnkSelectEndUser { get { return WebDriver.GetElement(By.Id("changeAddress-3")); } }

public IWebElement LnkChangeEndUserCust { get { return WebDriver.GetElement(By.XPath("//span[@id='icon-end-customer']//following-sibling::button")); } }

public IWebElement LnkChangeBillToCustomer { get { return WebDriver.GetElement(By.XPath("//span[@id='icon-billing']//following-sibling::button")); } }

public IWebElement LnkChangeSoldToCustomer { get { return WebDriver.GetElement(By.XPath("//span[@id='icon-soldto']//following-sibling::button")); } }

public IWebElement LnkChangeReseller { get { return WebDriver.GetElement(By.XPath("//span[@id='icon-reseller']//following-sibling::button")); } }

public IWebElement LnkChangeMailToCustomer { get { return WebDriver.GetElement(By.XPath("//span[@id='icon-mailing']//following-sibling::button")); } }

public IWebElement LnkChangeShipToCustomer { get { return WebDriver.GetElement(By.XPath("//span[@id='icon-shipTo']//following-sibling::button")); } }

public IWebElement LnkChangeInstallAtCustomer { get { return WebDriver.GetElement(By.XPath("//span[@id='icon-installAt']//following-sibling::button")); } }

public IWebElement OSCPageHeader { get { return WebDriver.GetElement(By.XPath("//h2[contains(text(),'Solutions Configurator')]")); } }

		public void delay(int timeInSeconds)
		{
			Thread.Sleep(timeInSeconds * 1000);
		}


		#endregion


		#region Line Items

		protected IWebElement SearchResultElement
		{
			get
			{
			//	DsaUtil.WaitForElement(ReactAddProductDiv.FindElement(ByTagtr), webDriver);
				return ReactAddProductDiv.FindElement(SearchResultBy);
			}
		}

		public By TiedSkuOfType6Present(string Type6TiedSku)
		{
			return By.XPath("//tr[td[contains(text(),'" + Type6TiedSku + "')]]");
		}

		public By SearchItemList(string OEMItem)
		{
			return By.XPath("//tr[td[a[contains(text(),'" + OEMItem + "')]]]");
		}



		#endregion

		#region Add product page
		protected IWebElement SearchProductTextBox
		{
			get
			{
				return ReactAddProductDiv.FindElement(By.XPath(".//*[contains(@class,'form-control SearchText')]"));
			}
		}
		protected IWebElement SearchButton
		{
			get { return ReactAddProductDiv.FindElement(By.CssSelector(".input-group-btn.SearchBox")).FindElement(By.TagName("button")); }
		}

		protected By SearchResultBy
		{
			get { return By.XPath(".//*[contains(@class,'dds__table dds__table-cmplx dds__table-hover dds__table-striped dds__table-responsive-lg no-underline')]"); }
		}

		protected IWebElement ProductDiscoveryModalDialog
		{
			get { return webDriver.FindElement(By.Id("ProductDiscovery/Modal")); }
		}
		protected IWebElement CancelAddProductButtonOnDialog { get { return ProductDiscoveryModalDialog.FindElement(By.XPath(".//button[contains(@class,'btn btn-default')]")); } }

		/// <summary>
		/// Product name textbox on dialog
		/// </summary>
		protected IWebElement ProductNameTextboxOnDialog
		{
			get { return ProductDiscoveryModalDialog.FindElement(By.Id("txtProductName")); }
		}
		#endregion

		#region Line Items

		public IWebElement BtnNextSwitchCatalog { get { return BtnSelectCatalog.FindElements(By.TagName("button")).FirstOrDefault(o => o.Text.Contains("Next")); } }

		public IWebElement BtnSkipSwitchCatalog { get { return BtnSelectCatalog.FindElements(By.TagName("button")).FirstOrDefault(o => o.Text.Contains("Skip")); } }

		public IWebElement BtnFinishSwitchCatalog { get { return BtnSelectCatalog.FindElements(By.TagName("button")).FirstOrDefault(o => o.Text.Contains("Finish")); } }
		/// <summary>
		/// Solution Save link on Home page
		/// </summary>

		#endregion

		#region Add Product Page
		private int GetSearchResultCount()
		{
			if (!WebDriver.ElementExists(SearchResultBy))
				return 0;

			var resultList = SearchResultElement.FindElements(ByTagtr);
			return resultList.Count - 1; // one row is header
		}
		public bool SearchForProduct(string productName)
		{
			DsaUtil.WaitUntilItsClickable(SearchProductTextBox, WebDriver);
			SearchProductTextBox.Clear();
			SearchProductTextBox.SendKeys(productName);
			DsaUtil.WaitUntilItsClickable(SearchButton, WebDriver);
			DsaUtil.WaitForPageLoad(WebDriver);
			return GetSearchResultCount() > 0;
		}
		public SolutionConfigurationPage GoToConfigurationTab()
		{
			DsaUtil.WaitForPageLoad(WebDriver);
			DsaUtil.WaitUntilItsClickable(ConfigurationTab, WebDriver);
			ConfigurationTab.Click();
			DsaUtil.WaitForPageLoad(WebDriver);
			return new SolutionConfigurationPage(WebDriver);

		}
		#endregion
		public HomePage ClickOnReturnToHomeHyperlink()
		{
			DsaUtil.WaitForPageLoad(WebDriver);
			MoreDdl.Click(WebDriver);
			ClickOnReturnToHome.Click();
			DsaUtil.WaitForPageLoad(WebDriver);

			return new HomePage(WebDriver);
		}


		#region Search And Add Product
		/// <summary>
		/// Method to search and add a product
		/// </summary>
		/// <param name="productName">string : Name of the product to be searched and added</param>
		///<param name="parentProductName">string : Name of the parent/enclosure product that need</param>
		/// <returns>returns bool</returns>
		/// <author>Sagarika</author>
		protected IWebElement AddButtonOnDialog
		{
			get
			{
				ProductDiscoveryModalDialog.WaitForElement(WebDriver);
				DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
				return ProductDiscoveryModalDialog.FindElement(By.XPath(".//button[contains(@class,'dds__btn dds__btn-primary')]"));
				//return ProductDiscoveryModalDialog.FindElement(By.XPath("//*[@id='modal_container']//div[3]//button[2]"));
			}
		}



		/// <summary>
		/// Solution Save link on Home page
		/// </summary>

		#endregion

		#region Search And Add Product

		public bool SearchAndAddProduct(string productName)
		{
			//Search product spinnter is taking more than 60 secs to happen, and the below wait actions are timing out after 60 sec, hence adding try catch block
			try
			{
				DsaUtil.WaitForWaitAnimationToLoad(webDriver);
				DsaUtil.WaitForWaitAnimationToLoad(webDriver);
			}
			catch (Exception ex)
			{
				// Do nothing 
			}

			TxtSearchProducts.SetTextForSolution(webDriver, productName);
			WebDriver.WaitForBusyOverlay();

			ProdcutSearchBtn.Click(webDriver);
			try
			{
				DsaUtil.WaitForWaitAnimationToLoad(webDriver);
				DsaUtil.WaitForWaitAnimationToLoad(webDriver);
			}
			catch (Exception ex)
			{
				// Do nothing 
			}
			var resultList = SearchResultElement.FindElements(ByTagtr);
			//var productElement = resultList.FirstOrDefault(p => p.Text.Contains(productName));
			var productElement = resultList[1];
			if (productElement == null)
			{
				//log.Error("Not able find the product from search result with name " + productName);
				return false;
			}
			//DsaUtil.WaitUntilItsClickable(productElement.FindElement(AddButtonBy), webDriver);
			AddButtonBy.Click(webDriver);
			if (!string.IsNullOrEmpty(productName))
			{
				AddProductToSolutionPopup(productName);
			}

			AddButtonOnDialog.Click(webDriver);
			DsaUtil.WaitForWaitAnimationToLoad(webDriver);
			//comment out the waiting for add another button, as loading mark shows in configuration tab now, waitForWaitAnimationToLoad coveres this waiting
			//wait for add another button shows up
			//var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(pageLoadWaitTime));
			//wait.Until<bool>(driver => VerifyAddAnotherButtonAndConfigureShows(productName));

			return true;

		}
		public void AddProductToSolutionPopup(string parentEnclosureName = null)
		{
			//webDriver.WaitForPageLoad(WebDriverUtil.GlobalWaitTime);
			var enclosureSelection = ProductDiscoveryModalDialog.FindElements(EnclosureSelectionBy).FirstOrDefault();
			if (enclosureSelection != null)
			{
				enclosureSelection.Select().SelectByText(parentEnclosureName);
			}
		}

		#endregion

		public SolutionConfigurationPage GoToAddProductsTab()
		{
			webDriver.WaitForPageLoad(WebDriverUtil.WaitTime);
			//Click Add Products tab
			AddProductTab.Click();
			//Wait for the products tab to load
			webDriver.WaitForPageLoad(WebDriverUtil.WaitTime);
			return new SolutionConfigurationPage(webDriver);
		}

		public SolutionConfigurationPage SwitchToMultiQuote()
		{
			if (webDriver.ElementExists(CheckforSingleQuote))
			{
				SelectSingleOrMultiQuote.Click();
				DsaUtil.WaitForWaitAnimationToLoad(webDriver);
			}
			return new SolutionConfigurationPage(webDriver);
		}

		/// <summary>
		/// Clicks on Save link and Saves the Solution and Do signin if required.
		/// </summary>
		public bool SaveSolution()
		{
			if (SaveLink.Displayed)
			{
				SaveLink.WaitForElementVisible(WebDriverUtil.WaitTime);
				DsaUtil.WaitForWaitAnimationToLoad(webDriver);
				SaveLink.Click(webDriver);
			}
			else
			{
				var saveBtn = WebDriver.GetElement(By.XPath("//*[@id='separate-save-SaveAs']//button"));
				saveBtn.WaitForElementVisible(WebDriverUtil.WaitTime);
				DsaUtil.WaitForWaitAnimationToLoad(webDriver);
				saveBtn.Click(webDriver);
			}
			webDriver.WaitForPageLoad(WebDriverUtil.WaitTime);
			DsaUtil.WaitForWaitAnimationToLoad(webDriver);

			return SolutionIDExist();
		}

		/// <summary>
		///Clicks on Save(new) link and Saves the Solution and Do signin if required.
		/// </summary>
		/// <returns></returns>
		public bool NewSaveSolution()
		{
			var newSave = WebDriver.GetElement(By.XPath("//*[@id = 'composer-header-solutionbutton-save-link' and contains(@class, 'dds__btn dds__btn-secondary')]"));
			newSave.WaitForElementVisible(WebDriverUtil.WaitTime);
			DsaUtil.WaitForWaitAnimationToLoad(webDriver);
			newSave.Click(webDriver);
			webDriver.WaitForPageLoad(WebDriverUtil.WaitTime);
			DsaUtil.WaitForWaitAnimationToLoad(webDriver);
			return SolutionIDExist();
		}

		public bool SaveCPSolution()
		{
			if (SaveToggleButton.Displayed)
			{
				var saveBtn = WebDriver.GetElement(By.XPath("//*[@id = 'composer-header-solutionbutton-save-link' and contains(@class, 'dds__btn dds__btn-secondary')]"));
				saveBtn.WaitForElementVisible(WebDriverUtil.WaitTime);
				DsaUtil.WaitForWaitAnimationToLoad(webDriver);
				saveBtn.Click(webDriver);
			}
			else
			{
				var saveBtn = WebDriver.GetElement(By.XPath("//*[@id = 'composer-header-solutionbutton-save-link' and contains(@class, 'btn-primary')]"));
				saveBtn.WaitForElementVisible(WebDriverUtil.WaitTime);
				DsaUtil.WaitForWaitAnimationToLoad(webDriver);
				saveBtn.Click(webDriver);
			}
			webDriver.WaitForPageLoad(WebDriverUtil.WaitTime);
			DsaUtil.WaitForWaitAnimationToLoad(webDriver);
			return SolutionIDExist();
		}

		public bool IsSendToQuoteEnabled()
		{
			bool result = false;

			if (webDriver.ElementExists(SendToQuoteLink))
			{
				result = WebDriver.FindElement(SendToQuoteLink).Enabled;
			}
			return result;
		}

		public bool VerifyCannotSendToQuoteDailog()
		{
			bool result = false;
			if (WebDriver.ElementExists(VerifyCannotSendToQuoteDailogby))
			{
				result = true;
				WebDriver.FindElement(By.Id("composer-gii-registerdeal-dialog-okbutton")).Click();
			}

			return result;
		}

		public CreateQuotePage SendToQuote()
		{

			if (webDriver.ElementExists(SendToQuoteLink))
			{
				webDriver.FindElement(SendToQuoteLink).Click();
				//Thread.Sleep(10000);
				DsaUtil.WaitAnimationToLoad(WebDriver);
				if (webDriver.ElementExists(By.Id("composer-sendtoquote-dsa-override-validationerrors")) || webDriver.ElementExists(By.Id("composer-sendtoquote-dsa-override-validationerrorsforxpod")))
				{
					if (SendToQuoteValidationDailogForValidationError.Displayed)
					{
						SendToQuoteCheckBoxForValidation.Click();
						SendToQuoteValidationerrorContinueToQuote.Click();
						webDriver.WaitForPageLoad(WebDriverUtil.WaitTime);
						//Thread.Sleep(2000);
						WebDriver.VerifyBusyOverlayNotDisplayed();

					}
					else if (SendToQuoteValidationDailogForXPODError.Displayed)
					{
						SendToQuoteCheckBoxForXPOD.Click();
						SendToQuoteXPODerrorContinueToQuote.Click();
						webDriver.WaitForPageLoad(WebDriverUtil.WaitTime);
						WebDriver.VerifyBusyOverlayNotDisplayed();
					}
				}
				//webDriver.WaitForPageLoad(WebDriverUtil.WaitTime);
				webDriver.WaitForPageLoad(WebDriverUtil.WaitTime);
				WebDriver.VerifyBusyOverlayNotDisplayed();
				DsaUtil.WaitForWaitAnimationToLoad(webDriver);
				//Sometime we intially see a blank quote creation page, hence the below wait actions
				//WebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
				//WebDriver.TryFindElement(new CreateQuotePage(WebDriver).BtnEditSolution);
				//WebDriver.TryFindElement(new CreateQuotePage(WebDriver).BtnEditSolution);

				new CreateQuotePage(webDriver).Summary.ByLblSummaryListPrice.GetText(webDriver).Should().NotBe("$0.00");
				WebDriver.TryFindElement(new CreateQuotePage(WebDriver).BtnEditSolution);
				new CreateQuotePage(WebDriver).WaitForQuoteValidationToComplete();
			}
			return new CreateQuotePage(WebDriver);
		}

		public bool SolutionIDExist()
		{

			return !(string.IsNullOrEmpty(SolutionIDLabel.Text));

		}

		public CreateQuotePage AddToQuote()
		{
			WebDriver.GetElement(By.XPath("//button[contains(text(), 'Add to Quote')]")).Click(WebDriver);
			return new CreateQuotePage(WebDriver);
		}
		#region Search and Add multiple products

		/// <summary>
		/// Method to search ann add multiple products to the solution
		/// </summary>
		/// <param name="productsList">Comma seperated list of products to add to the solution</param>
		/// <returns>Returns true on success, else false</returns>
		public SolutionConfigurationPage SearchAndAddMultipleProducts(string productsList)
		{
			string[] products = productsList.Split(',');

			products.All(product => SearchAndAddProduct(product));
			return new SolutionConfigurationPage(webDriver);
		}

		/// <summary>
		/// Get the product box in configuration tab new view
		/// </summary>
		/// <param name="productName"></param>
		/// <returns></returns>
		public IWebElement GetProductBoxByProductName(string productName)
		{
			//Some products have a difference with regards to white-spaces in the name between AddProductPage and SolutionConfiguratorPage. Thus, ignore white-spaces.
			var productBox =
				GetAllProductBoxes.FirstOrDefault(
					p =>
						CultureInfo.CurrentCulture.CompareInfo.IndexOf(p.Text.Replace(" ", string.Empty),
							productName.Replace(" ", string.Empty), CompareOptions.IgnoreCase) >= 0);
			if (productBox == null)
				Thread.Sleep(3000);
			return productBox;
		}

		/// <summary>
		/// Update product count 
		/// </summary>
		/// <param name="productName"></param>
		/// <param name="count"></param>
		public bool UpdateProductQuantity(string productName, int count)
		{
			//Find the product box
			var productBox = GetProductBoxByProductName(productName);
			//Click the product and click on ellipsis to show the remove
			productBox.FindElement(DragIconOfProduct).Click();
			var numberInput = productBox.FindElement(ProductCountInputBy);

			numberInput.Clear();
			numberInput.SendKeys(count.ToString(CultureInfo.InvariantCulture));

			var productNameElement = productBox.FindElement(BlueTextBy);
			new Actions(webDriver).MoveToElement(productNameElement).Click().Perform();
			return true;
		}



		/// <summary>
		/// Update product count 
		/// </summary>
		/// <param name="productName"></param>
		/// <param name="count"></param>
		public bool AddSKuUpdateSkuQty(string skuName, int qty = 1)
		{
			webDriver.WaitForElementDisplayed(By.Id("AddTiedItemText"), TimeSpan.FromSeconds(10));
			Thread.Sleep(5000);
			DsaUtil.WaitForPageLoad(WebDriver);
			TiedSkuNumberTextbox.Click();
			TiedSkuNumberTextbox.Clear();
			TiedSkuNumberTextbox.SendKeys(skuName.ToString(CultureInfo.InvariantCulture));
			AddTiedItem.Click();
			for (var i = 1; i <= qty; i++)
			{
				IncreaseSkuQty.FirstOrDefault(o => o.Text.Contains(skuName))
					.WaitForElementDisplayed(IncreaseSkuQtyBtn, TimeSpan.FromSeconds(10));
				DsaUtil.WaitForPageLoad(WebDriver);
				Thread.Sleep(2000);
				IncreaseSkuQty.FirstOrDefault(o => o.Text.Contains(skuName)).FindElement(IncreaseSkuQtyBtn).Click();
			}
			return true;
		}
		private By TagNameOption { get { return By.TagName("option"); } }
		public void SearchAndAddNonTiedSkuItems(string skuIDs, string addSKUTabText = "Add by SKU", bool needToSelectSKUCatagory = true)
		{
			var separator = new char[] { ',' };
			var lineitemList = skuIDs.Split(separator, StringSplitOptions.RemoveEmptyEntries);
			// Set SKU
			if (needToSelectSKUCatagory)
			{
				IReadOnlyCollection<IWebElement> ele = webDriver.FindElement(By.Id("ComposerComponent")).FindElement(By.CssSelector(".form-control")).FindElements(TagNameOption);
				IWebElement AddAsStandAloneOption = ele.FirstOrDefault(a => a.Text.Trim().ToLower() == "sku");
				AddAsStandAloneOption.Click();
			}

			SearchAndAddProduct(skuIDs);
		}
		/// <summary>
		/// Method to search ann add multiple products to the solution
		/// </summary>
		/// <param name="productsList">Comma seperated list of products to add to the solution</param>
		/// <returns>Returns true on success, else false</returns>
		public SolutionConfigurationPage SearchAndAddMultipleProductsAndSkus(string productsList)
		{
			string[] products = productsList.Split('|');

			foreach (string data in products)
			{
				string[] productAndSku = data.Split(';');
				if (productAndSku[0].Split('.')[0].Contains("-"))
				{
					SearchAndAddNonTiedSkuItems(productAndSku[0].Split('.')[0]);
					//Adding Non Tied Items
				}
				else
				{
					SearchAndAddProduct(productAndSku[0].Split('.')[0]);

				}
			}
			GoToConfigurationTab();
			foreach (string data in products)
			{
				string[] productAndSku = data.Split(';');
				if (!productAndSku[0].Split('.')[0].Contains("-"))
				{
					UpdateProductQuantity(productAndSku[0].Split('.')[0], Convert.ToInt32(productAndSku[0].Split('.')[1]));
					//Tied Line Items
					AddSKuUpdateSkuQty(productAndSku[1].Split('.')[0]);
					AddSKuUpdateSkuQty(productAndSku[2].Split('.')[0]);
				}
				else
				{
					//UpdateProductQuantity(productAndSku[1], Convert.ToInt32(productAndSku[0].Split('.')[1]));
				}
			}
			GoToGroupsTab();

			foreach (string data in products)
			{
				string[] productAndSku = data.Split(';');
				if (productAndSku[3] != "1" && productAndSku[3] != string.Empty)
					if (productAndSku[0].Split('.')[0].Contains("-"))
						MoveProductToNewGroup("1", productAndSku[1]);
					else
						MoveProductToNewGroup("1", productAndSku[0].Split('.')[0]);
			}


			return new SolutionConfigurationPage(webDriver);
		}


		#endregion  //Search and Add multiple products

		#region SwitchCatalog

		public bool SwitchCatalogPopUp()
		{
			if (webDriver.GetElement(By.XPath("//*[text()='Change this catalog?']")).IsElementDisplayed(webDriver, TimeSpan.FromSeconds(2)))
				return true;

			return false;
		}

		public void SwithCatalogTo8()
		{
			DsaUtil.WaitForPageLoad(WebDriver);
			SelectCatalog.Click();
			DsaUtil.WaitUntilItsClickable(BtnNextSwitchCatalog, WebDriver);
			BtnNextSwitchCatalog.Click();
			DsaUtil.WaitUntilItsClickable(BtnSkipSwitchCatalog, WebDriver);
			BtnSkipSwitchCatalog.Click();
			DsaUtil.WaitUntilItsClickable(BtnNextSwitchCatalog, WebDriver);
			BtnNextSwitchCatalog.Click();
			DsaUtil.WaitUntilItsClickable(BtnFinishSwitchCatalog, WebDriver);
			BtnFinishSwitchCatalog.Click();
		}

		#endregion

		/// <summary>
		/// Clicks on Save link and Saves the Solution and Do signin if required.
		/// </summary>

		#region Search and Add multiple products

		/// <summary>
		/// Method to search ann add multiple products to the solution
		/// </summary>
		/// <param name="productsList">Comma seperated list of products to add to the solution</param>
		/// <returns>Returns true on success, else false</returns>

		public bool UpdateConfigChanges(string productsList, string ConfigChanges)
		{
			bool result = false;
			GotoConfigTab();
			string[] products = productsList.Split(',');
			for (int i = 0; i < products.Count(); i++)
			{
				webDriver.FindElement(By.XPath("//div[div[div[p[a[contains(text(),'" + products[i] + "')]]]]]")).Click();
				UpdateSelectionofModule(ConfigChanges);
				DsaUtil.WaitAnimationToLoad(WebDriver);
				ConfigErrorValidateBtn.Click();
				if (webDriver.ElementExists(ValidationErrorssection))
				{
					result = true;
				}
				SaveSolution();
			}
			return result;
		}


		public SolutionConfigurationPage AddNonTiedSkuSolution(string nonTiedSkuModule, int index = 2)
		{
			GotoConfigTab();
			ExpandAllLink.Click();
			WebDriver.GetElement(By.XPath(string.Format("(//*[@id = 'ModuleId-{0}']//input[@type='radio' or @type='checkbox'])[{1}]", nonTiedSkuModule.Replace(" ", string.Empty), index)))
				.Click(WebDriver);
			SaveSolution();
			return new SolutionConfigurationPage(webDriver);
		}



		public bool UpdateSelectionofModule(string listOf_ModuleId_OptionId_Quantity)
		{
			bool isSelected = true;
			foreach (var module in listOf_ModuleId_OptionId_Quantity.Split('|'))
			{
				string[] keyValue = module.Split(new char[] { ';' }, 2);
				foreach (var option in keyValue[1].Split(';'))
				{
					int quantity = option.Split('~').Length == 2 ? int.Parse(option.Split('~')[1]) : 1;
					isSelected = quantity == 0 ? false : true;
					string optionId = option.Split('~').Length == 2 ? option.Split('~')[0] : option;
					if (webDriver.ElementExists(By.XPath(".//ul[@id='ModuleId-" + keyValue[0] + "']")))
					{
						DsaUtil.WaitForElement(webDriver.FindElement(By.XPath(".//ul[@id='ModuleId-" + keyValue[0] + "']")), webDriver);
						//Though element gets clicked, we are seeing sometime an error, hence the below try catch
						webDriver.FindElement(By.XPath(".//ul[@id='ModuleId-" + keyValue[0] + "']")).Click(WebDriver);

						if (webDriver.ElementExists(By.XPath(".//*[@id='ModuleId-" + keyValue[0] + "']//div[span[span[contains(text(),'[Option Id: " + optionId + "]')]]]/span/input")))
						{
							if (isSelected == true)
							{
								DsaUtil.WaitForElement(webDriver.FindElement(By.XPath(".//*[@id='ModuleId-" + keyValue[0] + "']//div[span[span[contains(text(),'[Option Id: " + optionId + "]')]]]/span/input")), webDriver);
								webDriver.FindElement(By.XPath(".//*[@id='ModuleId-" + keyValue[0] + "']//div[span[span[contains(text(),'[Option Id: " + optionId + "]')]]]/span/input")).Click();
							}
						}
						else if (webDriver.ElementExists(By.XPath(".//ul[@id='ModuleId-" + keyValue[0] + "']//div[span[span[span[contains(text(),'Option Id: " + optionId + "')]]]]/span/input")))
						{
							if (isSelected == true)
							{
								DsaUtil.WaitForElement(webDriver.FindElement(By.XPath(".//ul[@id='ModuleId-" + keyValue[0] + "']//div[span[span[span[contains(text(),'Option Id: " + optionId + "')]]]]/span/input")), webDriver);
								if (webDriver.ElementExists(By.XPath(".//*[@id='ModuleId-" + keyValue[0] + "']//input[@type='radio'][contains(@data-reactid,'" + optionId + "')]")))
								{
									webDriver.FindElement(By.XPath(".//*[@id='ModuleId-" + keyValue[0] + "']//input[@type='radio'][contains(@data-reactid,'" + optionId + "')]")).Click();
								}
								else if (webDriver.ElementExists(By.XPath(".//ul[@id='ModuleId-" + keyValue[0] + "']//div[span[span[span[contains(text(),'Option Id: " + optionId + "')]]]]//input[@id='product-options-multi-select-quantity'][@hidden='']")))
								{
									webDriver.FindElement(By.XPath(".//ul[@id='ModuleId-" + keyValue[0] + "']//div[span[span[span[contains(text(),'Option Id: " + optionId + "')]]]]/span/input")).Click();
								}
								else if (webDriver.ElementExists(By.XPath(".//ul[@id='ModuleId-" + keyValue[0] + "']//div[span[span[span[contains(text(),'Option Id: " + optionId + "')]]]]//input[@id='product-options-multi-select-quantity']")))
								{
									webDriver.FindElement(By.XPath(".//ul[@id='ModuleId-" + keyValue[0] + "']//div[span[span[span[contains(text(),'Option Id: " + optionId + "')]]]]//input[@id='product-options-multi-select-quantity']")).Clear();
									webDriver.FindElement(By.XPath(".//ul[@id='ModuleId-" + keyValue[0] + "']//div[span[span[span[contains(text(),'Option Id: " + optionId + "')]]]]//input[@id='product-options-multi-select-quantity']")).SendKeys(quantity.ToString());
								}

							}
						}
					}
					else
					{ break; }
				}

			}
			return true;
		}
		public SolutionConfigurationPage GotoConfigTab()
		{
			WebDriverWait wait = new WebDriverWait(webDriver, WebDriverUtil.WaitTime);
			IWebElement ConfigTabHeader = wait.Until(ExpectedConditions.ElementIsVisible(ConfigTab));
			DsaUtil.WaitUntilItsClickable(ConfigTabHeader, webDriver);
			webDriver.WaitForPageLoad(WebDriverUtil.WaitTime);
			DsaUtil.WaitForWaitAnimationToLoad(webDriver);
			return new SolutionConfigurationPage(webDriver);
		}

		public SolutionConfigurationPage GoToGroupsTab()
		{
			WebDriverWait wait = new WebDriverWait(webDriver, WebDriverUtil.WaitTime);
			IWebElement GroupsHeader = wait.Until(ExpectedConditions.ElementIsVisible(GroupsTabHeader));
			DsaUtil.WaitUntilItsClickable(GroupsHeader, webDriver);
			webDriver.WaitForPageLoad(WebDriverUtil.WaitTime);

			DsaUtil.WaitForWaitAnimationToLoad(webDriver);
			return new SolutionConfigurationPage(webDriver);
		}


		public bool MoveMultipleProductsToNewGroups(string groupSequenceNo, string ListOfproductsToMove)
		{
			string[] products = ListOfproductsToMove.Split(',');

			for (int i = 0; i < products.Count(); i++)
			{
				int count = Groups.Count;
				int attempt = 1;
				MoveProductToNewGroup(groupSequenceNo, products[i]);
				//Verify the product is moved to destination group, else attempt to move the product again
				while ((Groups.Count <= count || VerifyProductInGroup(defaultGroupNumber, products[i])) && attempt <= 5)
				{
					attempt++;
					MoveProductToNewGroup(defaultGroupNumber, products[i]);

				}
			}


			// The element collection, Groups has always 3 items more, 1 is now empty group, 1 is New Group, and 1 is hidden Group
			return Groups.Count.Equals(products.Count() + 3);
		}


		public bool MoveProductToNewGroup(string groupSequenceNo, string product)
		{
			try
			{
				// Find the group from where the product has to be picked up
				var requiredGroup = GetReqGroup(groupSequenceNo);
				//var requiredGroup = Groups.FirstOrDefault(group => group.Text.Contains(groupSequenceNo)); //GetReqGroup(groupSequenceNo);
				//var requiredGroup = Groups.FirstOrDefault(group => group.GetAttribute(Constants.GroupNumberAttribute) == groupSequenceNo);
				if (requiredGroup == null) return false;

				// Find the row in group where the product is present
				var productRows = requiredGroup.FindElements(ProductRowsOfGroup);
				var row = productRows.FirstOrDefault(productRow => productRow.Text.Contains(product));
				//var row = productRows.FirstOrDefault(productRow => productRow.Text.Contains(product));
				if (row == null) return false;

				// Move the product to new group
				Actions builder = new Actions(webDriver);
				IAction action = builder.ClickAndHold(row).MoveToElement(NewGroup).Release(NewGroup).Build();
				action.Perform();
				webDriver.WaitForPageLoad(WebDriverUtil.WaitTime);
				DsaUtil.WaitForWaitAnimationToLoad(webDriver);
				GroupDragDropOkBtn.Click();
				webDriver.WaitForPageLoad(WebDriverUtil.WaitTime);
				DsaUtil.WaitForWaitAnimationToLoad(webDriver);
			}
			catch (Exception)
			{
				//Do nothing
			}

			// Verify the product is moved to new group 
			//Product destination group cannot be predicted, hence doing a negative testing here
			return !VerifyProductInGroup(groupSequenceNo, product);
		}


		public bool VerifyProductInGroup(string groupSequenceNo, string product)
		{
			return GetProductListInGroup(groupSequenceNo).Count >= 1 &&
				GetProductListInGroup(groupSequenceNo).Any(productRow => productRow.Text.Contains(product));

		}

		public ReadOnlyCollection<IWebElement> GetProductListInGroup(string groupSequenceNo)
		{
			var requiredGroup = GetReqGroup(groupSequenceNo);
			if (requiredGroup == null) throw new Exception("VerifyProductInGroup" + " Failed");
			webDriver.WaitForPageLoad(WebDriverUtil.WaitTime);
			return requiredGroup.FindElements(ProductRowsOfGroup);
		}

		public IWebElement GetReqGroup(string groupNo)
		{
			IWebElement requiredGroup = null;
			int retryCount = 1;
		label:
			try
			{
				//System.Threading.Thread.Sleep(3000);
				requiredGroup = GetGroupWhichProductsAreMoving(groupNo);
			}
			catch (Exception e)
			{
				retryCount++;
				//&& e.Message.Contains("Element not found"
				if (retryCount < 10)
				{
					WebDriverWait wait = new WebDriverWait(webDriver, WebDriverUtil.WaitTime);
					wait.Until(ExpectedConditions.ElementExists(ByGroups));
					goto label;
				}
				throw e;
			}
			return requiredGroup;
		}

		private IWebElement GetGroupWhichProductsAreMoving(string groupMoveTo)
		{
			if (groupMoveTo.IndexOf('.') >= 0)
			{
				groupMoveTo = groupMoveTo.Substring(groupMoveTo.LastIndexOf('.') + 1);
			}

			//System.Threading.Thread.Sleep(2000);
			var moveToGroup = Groups.FirstOrDefault(group => group.GetAttribute(GroupNumberAttribute) == groupMoveTo);
			if (moveToGroup == null)
			{
				//moveToGroup = Groups.FirstOrDefault(group => group.FindElement(ByGroupID).Text.ToString().Split('.').LastOrDefault().ToString() == groupMoveTo);
				foreach (var grs in Groups)
				{
					if (grs.FindElement(ByGroupID).Text.ToString().Split('.').LastOrDefault().ToString() == groupMoveTo)
					{
						moveToGroup = grs;
						break;
					}
				}
			}
			//var moveToGroup = Groups.FirstOrDefault(group => group.FindElements(ByGroupID).Count > 0 &&
			//    (group.FindElement(ByGroupID).Text.ToString().Split('.').LastOrDefault().ToString() == groupMoveTo));
			if (moveToGroup == null) throw new Exception(string.Format("No group found with number : {0}", groupMoveTo));
			return moveToGroup;
		}

		#endregion  //Search and Add multiple products

		public SolutionConfigurationPage SaveSolutionsAsNewVersion(string SolutionID)
		{
			string[] OldSolutionVersion = SolutionID.Split('.');
			int OldVersion = int.Parse(OldSolutionVersion[1]);
			SaveAsBtnNew.Click();
			DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
			SaveAsNewVersionRadioBtn.Click();
			SaveAsBtnOnDialog.Click();
			DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
			string[] NewSolutionVersion = SolutionIDLabel.Text.Split('.');
			int NewVersion = int.Parse(NewSolutionVersion[1]);
			if (NewVersion > OldVersion)
			{
				//
			}
			else { throw new Exception("Save as newVersion, new version number is not greater than old version number"); }
			return new SolutionConfigurationPage(WebDriver);
		}

		public bool IsDraggerDisbaled()
		{
			return SelectSingleOrMultiQuote.IsElementClickable(webDriver, TimeSpan.FromSeconds(5));
		}

		public SolutionConfigurationPage SolutionSaveAsNewVersion()
		{
			DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
			var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(15));

			if (SaveToggleButton.Displayed)
			{
				SaveToggleButton.Click(WebDriver);
				SaveAsBtnNew.Click(webDriver);
			}
			else
			{
				var saveAsBtn = WebDriver.GetElement(By.Id("separate-save-SaveAs"));
				saveAsBtn.Click(WebDriver);
			}

			DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
			DsaUtil.WaitForElement(SaveAsModalDialog, WebDriver);
			DsaUtil.WaitForElement(SaveAsNewVersionRadioBtn, WebDriver);
			DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
			DsaUtil.WaitForElement(SaveAsModalDialog, WebDriver);
			wait.Until(ExpectedConditions.ElementToBeClickable(SaveAsNewVersionRadioBtn));
			SaveAsNewVersionRadioBtn.Click();
			SaveAsBtnOnDialog.Click();
			delay(10);
			DsaUtil.WaitForWaitAnimationToLoad(WebDriver);

			return new SolutionConfigurationPage(WebDriver);
		}

		public SolutionConfigurationPage SolutionSaveAsNewSolution()
		{
			DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
			var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(15));

			if (SaveToggleButton.Displayed)
			{
				SaveToggleButton.Click(WebDriver);
				SaveAsBtnNew.Click(webDriver);
			}
			else
			{
				var saveAsBtn = WebDriver.GetElement(By.Id("separate-save-SaveAs"));
				saveAsBtn.Click(WebDriver);
			}
			
			DsaUtil.WaitForElement(SaveAsModalDialog, WebDriver);
			DsaUtil.WaitForElement(SaveAsNewVersionRadioBtn, WebDriver);
			DsaUtil.WaitForElement(SaveAsModalDialog, WebDriver);
			wait.Until(ExpectedConditions.ElementToBeClickable(SaveAsNewSolutionRadioBtn));
			SaveAsNewSolutionRadioBtn.Click();
			DsaUtil.WaitForElement(SaveAsBtnOnDialog, WebDriver);
			SaveAsBtnOnDialog.Click();
			DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
			return new SolutionConfigurationPage(WebDriver);
		}

		public SolutionConfigurationPage TemplateSolutionSaveAsNewVersion()
		{
			SaveAsBtnNew.Click(WebDriver);
			DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
			DsaUtil.WaitForElement(ContinueBtn, WebDriver);
			ContinueBtn.Click(WebDriver);
			DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
			DsaUtil.WaitForElement(SaveAsModalDialog, WebDriver);
			SaveAsBtnOnDialog.Click(WebDriver);
			DsaUtil.WaitForWaitAnimationToLoad(WebDriver);

			return new SolutionConfigurationPage(WebDriver);
		}

		public SolutionConfigurationPage AddTiedSkuOfType6(string Type6TiedSkus)
		{
			string[] SkusToAdd = Type6TiedSkus.Split(',');

			for (int i = 0; i < SkusToAdd.Length; i++)
			{
				TiedSkuSearchBox.Clear();
				TiedSkuSearchBox.SendKeys(SkusToAdd[i]);
				TiedSkuAddBtn.Click();
				DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
			}
			return new SolutionConfigurationPage(WebDriver);
		}

		public bool VerifyTiedSkusAdded(string Type6TiedSkusAdded)
		{
			bool result = false;
			string[] SkusToAdd = Type6TiedSkusAdded.Split(',');

			for (int i = 0; i < SkusToAdd.Length; i++)
			{
				if (WebDriver.ElementExists(TiedSkuOfType6Present(SkusToAdd[i])))
				{
					result = true;
				}
				else
				{ result = false; break; }
			}
			return result;
		}

		public bool NonCFIAdmin_VerifyErrorMessgaeDisplayedForTiedSkusofType6Added()
		{
			bool result = false;
			if (WebDriver.ElementExists(Typ6TiedSkuErrorMessage))
			{
				result = true;
			}
			return result;
		}

		public SolutionConfigurationPage SelectConfigurationSettings()
		{
			ConfigSettingLink.Click();
			WebDriver.WaitForPageLoad();
			DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
			return new SolutionConfigurationPage(WebDriver);
		}

		public bool IsIcodedSkuOptionEnabled()
		{
			bool result = false;

			if (!(ICodedSKUsOption.GetAttribute("class").ToLower().Contains("disabled")))
			{
				result = true;
				ConfigSettingCloseButton.Click();
			}
			else
			{
				ConfigSettingCloseButton.Click();
			}
			return result;
		}

		public SolutionConfigurationPage ExpandAll()
		{
			SolutionConfigurationPage solutionConfigurationPage = new SolutionConfigurationPage(WebDriver);
			solutionConfigurationPage.GotoConfigTab();
			ExpandAllLink.Click();
			WebDriver.WaitForPageLoad();
			DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
			return new SolutionConfigurationPage(webDriver);
		}

		public bool IsIcodedSkuPresentInTheItemConfiguration()
		{
			bool result = false;
			IList<IWebElement> ICodedSkus = WebDriver.FindElements(ICodedSkusInItemConfigurationsby);
			if (ICodedSkus.Count > 1)
			{
				result = true;
			}
			return result;
		}

		public bool SearchOEMProductsAndVerifyIfAddbuttonIsEnabled(string OEMProducts)
		{
			bool result = false;

			string[] OEMProduct = OEMProducts.Split(';');
			foreach (string OEMItem in OEMProduct)
			{
				SearchProductTextBox.Clear();
				SearchProductTextBox.SendKeys(OEMItem);
				DsaUtil.WaitUntilItsClickable(SearchButton, WebDriver);
				DsaUtil.WaitForPageLoad(WebDriver);
				DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
				IWebElement AddButtonOfItem = WebDriver.FindElement(SearchItemList(OEMItem));
				if (!(AddButtonOfItem.GetAttribute("Class").ToLower().Contains("disabled")))
				{
					result = true;
					AddButtonOfItem.FindElement(By.TagName("button")).Click();
					DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
					DsaUtil.WaitUntilItsClickable(ProductDiscoveryAddBtn, WebDriver);
					DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
				}
			}
			return result;
		}

		public bool QuickSearchOEMProductsAndVerifyIfAddbuttonIsEnabled(string OEMProducts)
		{
			bool result = false;
			string[] OEMProduct = OEMProducts.Split(';');
			foreach (string OEMItem in OEMProduct)
			{
				QuickAddSearchText.Clear();
				QuickAddSearchText.SendKeys(OEMItem);
				DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
				DsaUtil.WaitForElement(QuickAddItemListDialog, WebDriver);
				DsaUtil.WaitForElement(WebDriver.FindElement(QuickAddItemSelect(OEMItem)), WebDriver);
				WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
				if (WebDriver.ElementExists(QuickAddItemList))
				{
					QuickAddItemListDialog.FindElement(QuickAddItemSelect(OEMItem)).Click();
					DsaUtil.WaitForElement(QuickAddSearchAddBtn, WebDriver);
					if (!(QuickAddSearchAddBtn.GetAttribute("Class").ToLower().Contains("disabled")))
					{
						result = true;
					}
				}
			}
			return result;
		}

		public bool VerifyOEMItemsIntheSolution()
		{
			bool result = false;

			IList<IWebElement> OEMProductList = ConfigTabProductList.FindElements(By.XPath("./div"));
			foreach (IWebElement OEMProduct in OEMProductList)
			{
				if (OEMProduct.Text.ToUpper().Contains("OEM"))
				{
					result = true;
				}
				else { result = false; break; }
			}
			return result;
		}

		public string GetSFDCDealID()
		{
			string[] SFDCDealID2 = SFDCDealID.Text.Split('#');
			return SFDCDealID2[1].TrimStart();
		}

		public void SelectValidationOverrideChkBox(IWebDriver driver)
		{
			DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
			DsaUtil.WaitForElement(ChkBoxValidationOvveride, WebDriver);
			var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(15));
			wait.Until(ExpectedConditions.ElementToBeClickable(ChkBoxValidationOvveride));
			try
			{
				ChkBoxValidationOvveride.Click();
			}
			catch (Exception e)
			{
				Logger.Write("Unable to select Validation Override checkbox. Exception thrown: " + e);
			}
		}

		public CreateQuotePage NavigateToDraftQuote()
		{

			if (WebDriver.ElementExists(By.Id("chkValidationOverride")))
			{
				new SolutionConfigurationPage(WebDriver).SelectValidationOverrideChkBox(WebDriver);
				new SolutionConfigurationPage(WebDriver).NewSaveSolution();
			}

			DraftQuoteLink.WaitForElement(WebDriver);
			DraftQuoteLink.Click();

			DsaUtil.WaitAnimationToLoad(WebDriver);
			if (webDriver.ElementExists(By.Id("composer-sendtoquote-dsa-override-validationerrors")) || webDriver.ElementExists(By.Id("composer-sendtoquote-dsa-override-validationerrorsforxpod")))
			{
				if (SendToQuoteValidationDailogForValidationError.Displayed)
				{
					SendToQuoteCheckBoxForValidation.Click();
					SendToQuoteValidationerrorContinueToQuote.Click();
					webDriver.WaitForPageLoad(WebDriverUtil.WaitTime);
					//Thread.Sleep(2000);
					WebDriver.VerifyBusyOverlayNotDisplayed();

				}
				else if (SendToQuoteValidationDailogForXPODError.Displayed)
				{
					SendToQuoteCheckBoxForXPOD.Click();
					SendToQuoteXPODerrorContinueToQuote.Click();
					webDriver.WaitForPageLoad(WebDriverUtil.WaitTime);
					WebDriver.VerifyBusyOverlayNotDisplayed();
				}
			}

			DsaUtil.WaitForPageLoad(webDriver);
			//webDriver.VerifyBusyOverlayNotDisplayed();
			return new CreateQuotePage(WebDriver);
		}

		public CreateQuotePage ClickOnDraftQuoteNumber()
		{
			DraftQuoteLink.WaitForElement(WebDriver);
			DraftQuoteLink.Click(WebDriver);
			DsaUtil.WaitAnimationToLoad(WebDriver);
			DsaUtil.WaitForPageLoad(webDriver);
			WebDriver.VerifyBusyOverlayNotDisplayed();
			return new CreateQuotePage(WebDriver);
		}

		public SolutionConfigurationPage SelectOfferCategory(IWebDriver webDriver, string solutionOfferCategory = "Unified Communications & Collaboration")
		{
			OfferCategoryLnk.Click(webDriver);
			TxtSolutionOfferCategoryDropdown.PickDropdownByText(webDriver, solutionOfferCategory);
			SaveSolutionOfferCategoryBtn.Click(webDriver);
			return new SolutionConfigurationPage(webDriver);
		}

		public SolutionConfigurationPage EditSolutionName(string solutionName)
		{
			MoreOptionsBtn.Click(webDriver);
			EditNameLnk.Click(webDriver);
			TxtEditName.SetText(webDriver, solutionName);
			SaveSolutionNameBtn.Click(webDriver);
			return new SolutionConfigurationPage(webDriver);
		}


		public SolutionConfigurationPage AssociateDealID(string dealID)
		{
			AssociateDeal.Click(webDriver);
			DsaUtil.WaitForElement(InputDeal, WebDriver);
			InputDeal.SetText(webDriver, dealID);
			ApplyDeal.Click(webDriver);
			DsaUtil.WaitForElement(PatchedDeal, WebDriver);
			PatchedDeal.GetText(webDriver).Trim().Equals(dealID).Should().BeTrue();
			return new SolutionConfigurationPage(webDriver);
		}

		public string GetChannelPartnerQuoteNumber(IWebDriver webDriver, double timeOut)
		{
			// by default search until 30 seconds and return quote number after it is generated
			return webDriver.TryFindElement(LnkQuoteNumber, TimeSpan.FromSeconds(timeOut)) && LnkQuoteNumber.IsElementClickable(webDriver) ? LnkQuoteNumber.GetText(webDriver) : string.Empty;
		}

		public IWebElement BtnContinueOnPopUp(IWebDriver webDriver)
		{
			return webDriver.GetElement(
				By.XPath("//h3[contains(text(), 'Create Quote')]/ancestor::div[contains(@class, 'modal-header')]/following-sibling::div//button[contains(@class, 'btn-primary')]"));
		}

		public SolutionConfigurationPage SelectShippingMethod(IWebDriver webDriver, string shippingMethod)
		{
			try
			{
				var xpath = "//input[@class='shipmentmethod-option' and @value='" + shippingMethod + "']";
				var shippingMethodElement = webDriver.FindElements(By.XPath(xpath));
				shippingMethodElement[0].Click(webDriver);
				return new SolutionConfigurationPage(webDriver);
			}
			catch (Exception e)
			{
				Logger.Write("Unable to find and select shipping method" + e.ToString());
				throw;
			}
		}

		public void ChangeSolutionCatalog()
		{
			MoreOptionsBtn.Click(webDriver);
			ChangeCatalogBtn.Click();
			DsaUtil.WaitForPageLoad(WebDriver);

            catalogElement.Click(webDriver);
            DsaUtil.WaitForPageLoad(WebDriver);

            // click on Next
            DsaUtil.WaitForElement(ChangeCatalogNextBtn, WebDriver);
            ChangeCatalogNextBtn.Click(WebDriver);
            DsaUtil.WaitForPageLoad(WebDriver);


            // click Next again
            DsaUtil.WaitForElement(ChangeCatalogNextBtn, WebDriver);
            ChangeCatalogNextBtn.Click();
            DsaUtil.WaitForPageLoad(WebDriver);

            // click Finish
            DsaUtil.WaitForElement(ChangeCatalogFinishBtn, WebDriver);
            ChangeCatalogFinishBtn.Click();
            DsaUtil.WaitForPageLoad(WebDriver);

			NewSaveSolution();
		}

		public SolutionConfigurationPage EnterShippingInstructions(IWebDriver webDriver, string shippingInstructions)
		{
			try
			{
				// string setShippingInstructions = Generator.RandomString(20, Generator.RandomCharacterGroup.AlphaNumericOnly);
				ShippingInstructionsLnk.Click(webDriver);
				EnterShipInstructions.SetText(webDriver, shippingInstructions);
				// SaveSolutionNameBtn.Click(webDriver);
				return new SolutionConfigurationPage(webDriver);
			}
			catch (Exception e)
			{
				Logger.Write("Unable to find and select shipping method" + e.ToString());
				throw;
			}
		}

		public SolutionConfigurationPage SearchAndAddProductByCategory(string productName, string category)
		{
			SearchCategoryDropdown.PickDropdownByText(WebDriver, category);
			TxtEnterOrderCode.SetText(WebDriver, productName);
			BtnAddOrderCode.Click(WebDriver);
			DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
			return new SolutionConfigurationPage(WebDriver);
		}

	}

}