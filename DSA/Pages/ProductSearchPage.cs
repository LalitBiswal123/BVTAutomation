using System;
using Dsa.Enums;
using Dsa.Pages.Product;
using Dsa.Pages.ARB;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace Dsa.Pages
{
    public class ProductSearchPage : DsaPageBase
    {
        public ProductSearchPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }//*[@id='products_tab_favproducts']

        #region Elements

        //[FindsBy(How = How.Id, Using = "productSearch_orderCode")]
        //public IWebElement TxtOrderCode;
        public IWebElement TxtOrderCode { get { return WebDriver.GetElement(By.Id("productSearch_orderCode"),DsaUtil.GlobalWaitTime); } }

        //[FindsBy(How = How.Id, Using = "productSearch_Sku")]
        //public IWebElement TxtSkuId;
        public IWebElement TxtSkuId { get { return WebDriver.GetElement(By.Id("productSearch_Sku")); } }

        public IWebElement CheckBox { get { return WebDriver.GetElement(By.XPath("//input[@class='ng-untouched ng-pristine ng-valid']")); } }

        public IWebElement CartOk { get { return WebDriver.GetElement(By.Id("cartItems_OkButton")); } }

        public IWebElement BtnSuccess { get { return WebDriver.GetElement(By.XPath("//button[@class='btn btn-success']")); } }
public IWebElement TxtSystemSearch { get { return WebDriver.GetElement(By.Id("productSearch_chassisDescription")); } }


public IWebElement TxtSnpSearch { get { return WebDriver.GetElement(By.Id("productSearch_skuDescription")); } }


public IWebElement TxtSISearch { get { return WebDriver.GetElement(By.Id("productSearch_sINumber")); } }

        //[FindsBy(How = How.Id, Using = "productSearch_SearchButton")]
        //public IWebElement BtnSearch;
        public IWebElement BtnSearch { get { return WebDriver.GetElement(By.Id("productSearch_SearchButton")); } }


public IWebElement BtnProductConfigure { get { return WebDriver.GetElement(By.Id("_configure")); } }

        //[FindsBy(How = How.XPath, Using = "//button[@id='_viewquote']")]
        //public IWebElement BtnViewQuote;
        public IWebElement BtnViewQuote { get { return WebDriver.GetElement(By.XPath("//button[@id='products_viewquote']"),DsaUtil.GlobalWaitTime); } }


public IWebElement LnkCurrentQuoteId { get { return WebDriver.GetElement(By.Id("menu_currentQuote")); } }


public IWebElement ProductCartItemsId { get { return WebDriver.GetElement(By.Id("menu_productItems1")); } }


public IWebElement BtnCartDropdownConfigureId { get { return WebDriver.GetElement(By.Id("mastHead_configItems")); } }


public IWebElement ProductsSearchRoute { get { return WebDriver.GetElement(By.XPath("/#/products/search/")); } }


public IWebElement ProductsPreviewRoute { get { return WebDriver.GetElement(By.XPath("/#/product/preview")); } }


public IWebElement ProductsSearchResultRoute { get { return WebDriver.GetElement(By.XPath("/#/products/results/")); } }
        

public IWebElement BtnProductSearchClear { get { return WebDriver.GetElement(By.Id("productSearch_clearButton")); } }


public IWebElement BtnProductBrowse { get { return WebDriver.GetElement(By.Id("productSearch_clearButton")); } }


public IWebElement LblSkuId { get { return WebDriver.GetElement(By.Id("productSearch_Sku_label")); } }


public IWebElement LblChassisDescription { get { return WebDriver.GetElement(By.Id("productSearch_ChassisDescription_label")); } }


public IWebElement LblSkuDescription { get { return WebDriver.GetElement(By.Id("productSearch_SkuDescription_label")); } }


public IWebElement TabSearch { get { return WebDriver.GetElement(By.Id("Search")); } }


public IWebElement TabDesktops { get { return WebDriver.GetElement(By.LinkText("Desktops & Workstations")); } }


public IWebElement TabLaptopsNoteBooks { get { return WebDriver.GetElement(By.LinkText("Laptops & Notebooks")); } }


public IWebElement TabPeripherals { get { return WebDriver.GetElement(By.LinkText("Configurable Peripherals")); } }


public IWebElement TabServers { get { return WebDriver.GetElement(By.LinkText("Servers, Storage & Networking")); } }


public IWebElement TabSoftware { get { return WebDriver.GetElement(By.LinkText("Software & Peripherals")); } }


public IWebElement FavoriteProducts { get { return WebDriver.GetElement(By.Id("products_tab_favproducts")); } }



public IWebElement ProductListId { get { return WebDriver.GetElement(By.Id("productResult_paneList")); } }


public IWebElement ProductNameListViewId { get { return WebDriver.GetElement(By.Id("productResult_list_productName")); } }


public IWebElement AddToQuoteListView { get { return WebDriver.GetElement(By.Id("productResult_list_add")); } }


public IWebElement AddAnotherListView { get { return WebDriver.GetElement(By.Id("productResult_list_add")); } }


public IWebElement ConfigureListView { get { return WebDriver.GetElement(By.Id("productResult_list_configure")); } }


public IWebElement LnkListViewDiscount { get { return WebDriver.GetElement(By.Id("productResult_list_productDiscount")); } }


public IWebElement SelectColumnsId { get { return WebDriver.GetElement(By.Id("productResult_selectColumns")); } }


public IWebElement ProductGridSortId { get { return WebDriver.GetElement(By.Id("productResult_sortBy")); } }


public IWebElement LnkCategoryFilter { get { return WebDriver.GetElement(By.Id("productResult_category_{0}")); } }


public IWebElement RefinerId { get { return WebDriver.GetElement(By.Id("productResult_refiner_{0}")); } }


public IWebElement RefinementId { get { return WebDriver.GetElement(By.Id("productResult_refinement_{0}")); } }


public IWebElement ProductGridId { get { return WebDriver.GetElement(By.Id("productResult_grid")); } }


public IWebElement LnkGridView { get { return WebDriver.GetElement(By.Id("productResult_GridViewLink")); } }


public IWebElement LnkListView { get { return WebDriver.GetElement(By.Id("productResult_ListViewLink")); } }


public IWebElement BtnConfigureGridView { get { return WebDriver.GetElement(By.Id("productResult_grid_configure")); } }


public IWebElement BtnAddAnotherGridView { get { return WebDriver.GetElement(By.Id("productResult_grid_addAnother")); } }


public IWebElement BtnAddToQuoteGridView { get { return WebDriver.GetElement(By.Id("productResult_grid_add")); } }


public IWebElement BtnDeActivatedGridView { get { return WebDriver.GetElement(By.Id("productResult_grid_deactivated")); } }


public IWebElement LnkProductResultGridSavings { get { return WebDriver.GetElement(By.Id("productResultGrid_savings_{0}")); } }


public IWebElement LnkCustomerSearchTerm { get { return WebDriver.GetElement(By.Id("customer_searchTerm_link")); } }


public IWebElement PillDelete { get { return WebDriver.GetElement(By.Id("pill-delete")); } }


public IWebElement LnkCustomerSearchSave { get { return WebDriver.GetElement(By.Id("customer_searchSave_link")); } }


public IWebElement LnkCustomerSearchEdit { get { return WebDriver.GetElement(By.Id("customer_searchEdit_link")); } }


public IWebElement BuildToOrderChkBoxChk { get { return WebDriver.GetElement(By.Id("productResult_refinement_2")); } }


public IWebElement SmartSelection { get { return WebDriver.GetElement(By.Id("productResult_refinement_1")); } }


public IWebElement LnkBackToSearch { get { return WebDriver.GetElement(By.CssSelector("span.search-term-pill > a")); } }


public IWebElement AddProduct { get { return WebDriver.GetElement(By.Id("productResult_grid_add")); } }


public IWebElement ConfigureProduct { get { return WebDriver.GetElement(By.Id("productResult_grid_configure")); } }


public IWebElement ProductNameGridViewId { get { return WebDriver.GetElement(By.Id("productResultValue_productName")); } }


public IWebElement LblBundlePrice { get { return WebDriver.GetElement(By.Id("productResultLabel_bundlePrice")); } }


public IWebElement BundlePriceValue { get { return WebDriver.GetElement(By.Id("productResultValue_bundlePrice")); } }


public IWebElement LblSavings { get { return WebDriver.GetElement(By.Id("productResultLabel_savings")); } }


public IWebElement SavingsValue { get { return WebDriver.GetElement(By.Id("productResultValue_savings")); } }


public IWebElement LblMargin { get { return WebDriver.GetElement(By.Id("productResultLabel_margin")); } }


public IWebElement MarginValue { get { return WebDriver.GetElement(By.Id("productResultValue_margin")); } }


public IWebElement LblSellingPrice { get { return WebDriver.GetElement(By.Id("productResultLabel_sellingPrice")); } }


public IWebElement SellingPriceValue { get { return WebDriver.GetElement(By.Id("productResultValue_sellingPrice")); } }


public IWebElement LblProcessor { get { return WebDriver.GetElement(By.Id("productResultLabel_processorDetails")); } }


public IWebElement ProcessorValue { get { return WebDriver.GetElement(By.Id("productResultValue_processorDetails")); } }


public IWebElement InventoryValidationSection { get { return WebDriver.GetElement(By.Id("productResultLabel_inventoryInfoSection")); } }


public IWebElement LblContinueToSell { get { return WebDriver.GetElement(By.Id("productResultLabel_continueToSell")); } }


public IWebElement LblATSQuantity { get { return WebDriver.GetElement(By.Id("productResultLabel_atsQuantity")); } }


public IWebElement ATSQuantityValue { get { return WebDriver.GetElement(By.Id("productResultValue_atsQuantity")); } }


public IWebElement ProductDetailsATSId { get { return WebDriver.GetElement(By.Id("productResultValue_atsQuantity")); } }


public IWebElement LblRestock { get { return WebDriver.GetElement(By.Id("productResultLabel_restock")); } }


public IWebElement RestockValue { get { return WebDriver.GetElement(By.Id("productResultValue_restock")); } }


public IWebElement LblLeadTime { get { return WebDriver.GetElement(By.Id("productResultLabel_leadTime")); } }


public IWebElement LeadTimeValue { get { return WebDriver.GetElement(By.Id("productResultValue_leadTime")); } }


public IWebElement LblEDD { get { return WebDriver.GetElement(By.Id("productResultLabel_estimatedDeliveryDate")); } }


public IWebElement EDDValue { get { return WebDriver.GetElement(By.Id("productResultValue_estimatedDeliveryDate")); } }


public IWebElement LblESD { get { return WebDriver.GetElement(By.Id("productResultLabel_estimatedShipDate")); } }


public IWebElement ESDValue { get { return WebDriver.GetElement(By.Id("productResultValue_estimatedShipDate")); } }


public IWebElement LblOS { get { return WebDriver.GetElement(By.Id("productResultLabel_operatingSystemDetails")); } }


public IWebElement OSValue { get { return WebDriver.GetElement(By.Id("productResultValue_operatingSystemDetails")); } }


public IWebElement LblScreen { get { return WebDriver.GetElement(By.Id("productResultLabel_screenDetails")); } }


public IWebElement ScreenValue { get { return WebDriver.GetElement(By.Id("productResultValue_screenDetails")); } }


public IWebElement LblMemory { get { return WebDriver.GetElement(By.Id("productResultLabel_memoryDetails")); } }


public IWebElement MemoryValue { get { return WebDriver.GetElement(By.Id("productResultValue_memoryDetails")); } }


public IWebElement LblHD { get { return WebDriver.GetElement(By.Id("productResultLabel_hardDriveDetails")); } }


public IWebElement HDValue { get { return WebDriver.GetElement(By.Id("productResultValue_hardDriveDetails")); } }


public IWebElement ItemsPerPage { get { return WebDriver.GetElement(By.Id("grid_paging_itemsPerPage")); } }


public IWebElement ChangeCatalog { get { return WebDriver.GetElement(By.Id("productConfig_changeCatalog")); } }


public IWebElement CurrentCatalog { get { return WebDriver.GetElement(By.Id("productConfig_currentCatalog")); } }


public IWebElement HdrPreviewOnly { get { return WebDriver.GetElement(By.Id("productConfig_previewOnlyHeader_0")); } }


public IWebElement ConfigureMastHead { get { return WebDriver.GetElement(By.Id("dropMenu_productItems_configItems")); } }


public IWebElement ConfigureBrowse { get { return WebDriver.GetElement(By.Id("productBrowse_tree_configure")); } }


public IWebElement AddToQuoteBrowse { get { return WebDriver.GetElement(By.Id("productBrowse_tree_add")); } }


public IWebElement AddAnotherBrowse { get { return WebDriver.GetElement(By.Id("productBrowse_tree_addAnother")); } }


public IWebElement TreeViewNoAnavMsg { get { return WebDriver.GetElement(By.Id("productBrowse_noANAVMessage")); } }


public IWebElement SnPTree { get { return WebDriver.GetElement(By.LinkText("Software & Peripherals")); } }


public IWebElement AllSnPs { get { return WebDriver.GetElement(By.LinkText("All Software & Peripherals")); } }


public IWebElement PartsUpgrades { get { return WebDriver.GetElement(By.LinkText("Parts & Upgrades")); } }


public IWebElement PhonesCommunication { get { return WebDriver.GetElement(By.LinkText("Phones and Communication")); } }


public IWebElement MonitorAccessories { get { return WebDriver.GetElement(By.LinkText("Monitors & Monitor Accessories")); } }


public IWebElement HomeTheaterAudio { get { return WebDriver.GetElement(By.LinkText("Home Theater & Audio")); } }


public IWebElement Audio { get { return WebDriver.GetElement(By.LinkText("Audio")); } }


public IWebElement CameraPhotoVideo { get { return WebDriver.GetElement(By.LinkText("Camera, Photo & Video")); } }


public IWebElement ConfigurableProductTree { get { return WebDriver.GetElement(By.LinkText("Configurable Products"),DsaUtil.GlobalWaitTime); } }


public IWebElement Tablets { get { return WebDriver.GetElement(By.LinkText("Tablets")); } }


public IWebElement AllLaptops { get { return WebDriver.GetElement(By.LinkText("All Laptops & Notebooks")); } }


public IWebElement Latitude { get { return WebDriver.GetElement(By.LinkText("Latitude")); } }


public IWebElement DellPrecision { get { return WebDriver.GetElement(By.LinkText("Dell Precision Mobile Workstations")); } }


public IWebElement DesktopsWorkstations { get { return WebDriver.GetElement(By.LinkText("Desktops & Workstations")); } }


public IWebElement AllDesktops { get { return WebDriver.GetElement(By.LinkText("All Desktops & Workstations")); } }


public IWebElement OptiplexDesktops { get { return WebDriver.GetElement(By.LinkText("OptiPlex Desktops")); } }


public IWebElement DellPrecisionWorkstations { get { return WebDriver.GetElement(By.LinkText("Dell Precision Workstations")); } }


public IWebElement ServersStorageNetworking { get { return WebDriver.GetElement(By.LinkText("Servers, Storage & Networking")); } }


public IWebElement AllServersStorageNetworking { get { return WebDriver.GetElement(By.LinkText("All Servers, Storage & Networking")); } }


public IWebElement ClientSystemsManagement { get { return WebDriver.GetElement(By.LinkText("Client Systems Management")); } }


public IWebElement PreviewProductOrderCode { get { return WebDriver.GetElement(By.Id("productConfig_productInfoLI_orderCode_0")); } }


public IWebElement HdrProductDetails { get { return WebDriver.GetElement(By.Id("productDetail_Header")); } }


public IWebElement ProductDetailsOrderCode { get { return WebDriver.GetElement(By.Id("productDetail_OrderCode")); } }


public IWebElement ProductDetailsProductName { get { return WebDriver.GetElement(By.Id("productDetail_productName")); } }


public IWebElement ProductDetailsStockId { get { return WebDriver.GetElement(By.Id("productDetail_stock-notification")); } }


public IWebElement ProductDetailsPriceSectionId { get { return WebDriver.GetElement(By.Id("productDetails_priceDiscount")); } }


public IWebElement AddToQuoteDetailsView { get { return WebDriver.GetElement(By.Id("productDetail_AddToQuote")); } }


public IWebElement AddAnotherDetailsView { get { return WebDriver.GetElement(By.Id("productDetail_AddAnother")); } }


public IWebElement ConfigureDetailsView { get { return WebDriver.GetElement(By.Id("productDetail_Configure")); } }


public IWebElement ProductDetailsDiscountPercent { get { return WebDriver.GetElement(By.Id("productDetail_DiscountPercent")); } }


public IWebElement ProductDetailsDiscountPrice { get { return WebDriver.GetElement(By.Id("productDetail_DnCDiscountPrice")); } }


public IWebElement ProductDetailsDiscountValue { get { return WebDriver.GetElement(By.Id("productDetail_DiscountValue")); } }


public IWebElement ProductDetailsTotalDiscount { get { return WebDriver.GetElement(By.Id("productDetail_TotalDiscounts")); } }


public IWebElement ProductDetailsStartingPrice { get { return WebDriver.GetElement(By.Id("productDetail_ListPrice")); } }


public IWebElement ProductDetailsLeadTime { get { return WebDriver.GetElement(By.Id("productDetail_LeadTimeInDays")); } }


public IWebElement ProductDetailsEsd { get { return WebDriver.GetElement(By.Id("productDetail_ESD")); } }


public IWebElement LblConfigType { get { return WebDriver.GetElement(By.Id("productResultLabel_configurationType")); } }


public IWebElement ConfigTypeValue { get { return WebDriver.GetElement(By.Id("productResultValue_configurationType")); } }


public IWebElement ProductDetailsConfigType { get { return WebDriver.GetElement(By.Id("productDetail_ConfigurationType")); } }


public IWebElement SKUNumber { get { return WebDriver.GetElement(By.Id("productDetail_SkuNumber")); } }


public IWebElement ProducTechSpecs { get { return WebDriver.GetElement(By.Id("productDetails_TechSpecs")); } }


public IWebElement PreviewItemNotFound { get { return WebDriver.GetElement(By.Id("productDetails_itemsNotFoundMessage")); } }


public IWebElement CatalogSelect { get { return WebDriver.GetElement(By.Id("customerSetSelect_Grid_select_{0}")); } }


public IWebElement CatalogGrid { get { return WebDriver.GetElement(By.Id("customerSetSelect_Grid")); } }


public IWebElement NoResultsMessage { get { return WebDriver.GetElement(By.Id("noResults_Apology_Bold")); } }


public IWebElement NoResultsMessageOnaSearchTerm { get { return WebDriver.GetElement(By.Id("common_noResults_message")); } }


public IWebElement NoItemsPresent { get { return WebDriver.GetElement(By.Id("data-grid-msg")); } }


public IWebElement LnkEditSearch { get { return WebDriver.GetElement(By.Id("customer_searchEdit_link")); } }


public IWebElement ListPriceKey { get { return WebDriver.GetElement(By.Id("listPrice")); } }
        //UI element changed

public IWebElement LeadTimeKey { get { return WebDriver.GetElement(By.Id("leadtimedays")); } }


public IWebElement DiscountKey { get { return WebDriver.GetElement(By.Id("savings")); } }


public IWebElement NameKey { get { return WebDriver.GetElement(By.Id("name")); } }


public IWebElement SellingPriceKey { get { return WebDriver.GetElement(By.Id("saleprice")); } }


public IWebElement ServiceTagKey { get { return WebDriver.GetElement(By.Id("serviceTag")); } }


public IWebElement LnkDellOutletProducts { get { return WebDriver.GetElement(By.Id("outlet_sales")); } }


public IWebElement LnkDellProducts { get { return WebDriver.GetElement(By.Id("return_dell_products")); } }


public IWebElement LnkConfigurableproducts { get { return WebDriver.GetElement(By.XPath("//div[@id='main']/div/div[2]/div/div/ul/li/div/div/div/a/span")); } }


public IWebElement LnkSoftarePeripherals { get { return WebDriver.GetElement(By.XPath("//div[@id='main']/div/div[2]/div/div/ul/li[2]/div/div/div/a/span")); } }


public IWebElement ProductItemToggle { get { return WebDriver.GetElement(By.Id("menu_productItems_toggle1")); } }


public IWebElement FirstRecommendedSku { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/div/div/div/div[4]/div[4]/div/div/div[2]/div[4]/tabset/div/div/div[2]/div[2]/div/div/div/div[1]/div[3]/div/div[1]/div[1]/div/div[3]/h6[1]")); } }


public IWebElement BtnFirstRecommdedSku { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/div/div/div/div[4]/div[4]/div/div/div[2]/div[4]/tabset/div/ul/li[2]")); } }


public IWebElement ErrorPopup { get { return WebDriver.GetElement(By.Id("_confirm")); } }


public IWebElement LnkCustomerKitSelector { get { return WebDriver.GetElement(By.Id("customer_kit_selector")); } }


public IWebElement addbuttonconfig { get { return WebDriver.GetElement(By.XPath("//tree-node[1]//div[1]//tree-node-wrapper[1]//div[1]//div[1]//tree-node-content[1]//a[1]//span[2]//button[1]")); } }


public IWebElement Addconfigbutton { get { return WebDriver.GetElement(By.XPath("//tree-node[1]//div[1]//tree-node-wrapper[1]//div[1]//div[1]//tree-node-content[1]//a[1]//span[2]//button[2]")); } }

        //  [FindsBy(How = How.Id, Using = "productConfig_option_0_AUTOPILOTTESTING-DONOTORDER_toggle")]
        // public IWebElement WinAutoPilotLnk;


public IWebElement TabMonitorPrintersProjectorsDocking { get { return WebDriver.GetElement(By.LinkText("Dell Monitors, Printers, Projectors & Docking Stations")); } }


public IWebElement TabLaptopTabletMobile { get { return WebDriver.GetElement(By.Id("products_tab_laptops-and-tablets")); } }


public IWebElement TreeLaptopTabletMobile { get { return WebDriver.GetElement(By.XPath("//span[normalize-space()='Laptops, Tablets & Mobile Workstations​']")); } }


public IWebElement TreeServerStorageNetwork { get { return WebDriver.GetElement(By.XPath("//span[normalize-space()='Servers, Storage & Networking']")); } }


public IWebElement TreeMonitorPrintersProjectorsDocking { get { return WebDriver.GetElement(By.XPath("//span[normalize-space()='Dell Monitors, Printers, Projectors & Docking Stations']")); } }


public IWebElement TreePartsUpgrades { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'parts & upgrades')]")); } }



public IWebElement SearchResultColumnDescription { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_productResult_paneList']/thead/tr/th[1]/span")); } }


public IWebElement SearchResultColumnLT { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_productResult_paneList']/thead/tr/th[2]/span")); } }


public IWebElement SearchResultColumnType { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_productResult_paneList']/thead/tr/th[3]/span")); } }


public IWebElement SearchResultColumnDBC { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_productResult_paneList']/thead/tr/th[4]/span")); } }


public IWebElement SearchResultColumnListPrice { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_productResult_paneList']/thead/tr/th[5]/span")); } }

        public IWebElement RemoveItem_CartView_Link
        { get { return WebDriver.GetElement(By.Id("RemoveItem_CartView_Link")); } }




        #endregion

        public bool ExpandConfigureSnPCatalogs()
        {
            bool treeLoaded = false;
            WebDriver.VerifyBusyOverlayNotDisplayed();
            //verify config tree exists
            if (WebDriver.TryFindElement(WebDriver.GetElement(By.XPath("//tree-root//tree-node-content/a/span[contains(text(),'Configurable Products')]"))))
            {
                if (WebDriver.FindElement(By.XPath("//product-tree//tree-root//tree-node-content/a/span[contains(text(),'Configurable Products')]/following::tree-node-collection")).IsElementDisplayed(WebDriver))
                {
                    treeLoaded = true;
                }
                else
                {
                    return treeLoaded;
                }
            }
            //verify snp tree exists
            if (WebDriver.TryFindElement(WebDriver.GetElement(By.XPath("//tree-root//tree-node-content/a/span[contains(text(),'Software & Peripherals')]"))))
            {
                if (WebDriver.FindElement(By.XPath("//product-tree//tree-root//tree-node-content/a/span[contains(text(),'Software & Peripherals')]/following::tree-node-collection")).IsElementDisplayed(WebDriver))
                {
                    treeLoaded = true;
                }
                else
                {
                    WebDriver.FindElement(By.XPath("//product-tree//tree-root//tree-node-content/a/span[contains(text(),'Software & Peripherals')]")).Click();
                    if (WebDriver.FindElement(By.XPath("//product-tree//tree-root//tree-node-content/a/span[contains(text(),'Software & Peripherals')]/following::tree-node-collection")).IsElementDisplayed(WebDriver))
                    {
                        treeLoaded = true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return treeLoaded;
        }


        public void ExpandAndAddAsConfigByDescription(string ItemDescription)
        {
            //move the page to element.
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.FindElement(By.XPath("//span[contains(text(),'Software & Peripherals')]/following::span[contains(text(),'software')]")).Click();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.FindElement(By.XPath("//span[contains(text(),'Software & Peripherals')]/following::span[contains(text(),'software')]/following::span[contains(text(),'business and office')]")).Click();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.FindElement(By.XPath("//span[contains(text(),'Software & Peripherals')]/following::span[contains(text(),'software')]/following::span[contains(text(),'business and office')]/following::span[contains(text(),'office applications')]")).Click();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            if (WebDriver.TryFindElement(WebDriver.FindElements(By.XPath(String.Format("//span[contains(text(),'Software & Peripherals')]/following::span[contains(text(),'software')]/following::span[contains(text(),'business and office')]/following::span[contains(text(),'office applications')]/following::span[contains(text(),'{0}')]/following::button[contains(text(),'Add Config')]", ItemDescription)))[0]))
            {
                WebDriver.FindElements(By.XPath(String.Format("//span[contains(text(),'Software & Peripherals')]/following::span[contains(text(),'software')]/following::span[contains(text(),'business and office')]/following::span[contains(text(),'office applications')]/following::span[contains(text(),'{0}')]/following::button[contains(text(),'Add Config')]", ItemDescription)))[0].Click();
            }
            WebDriver.VerifyBusyOverlayNotDisplayed();
            
        }

        public ProductSearchPage SelectCatalog(Catalogs catalog)
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            var selectCatalog = new SelectCatalogDialog(WebDriver);
            selectCatalog.SelectCatalog(catalog);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return this;
        }

        public ProductSearchPage SelectCompanyNumber(string companyNumber)
        {
            var compNumber = new SelectCompanyNumberDailog(WebDriver);
            compNumber.SelectCompanyNumber(companyNumber);
            return this;
        }

        public ProductSearchResultsPage SearchByOrderCode(string orderCode)
        {
            WebDriver.WaitForPageLoad();
            TxtOrderCode.SetText(WebDriver, orderCode);
            BtnViewQuote.WaitForElement(WebDriver);// need to wait till View Quote button is enabled
            BtnSearch.Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return new ProductSearchResultsPage(WebDriver);
        }

        public ProductSearchResultsPage SearchBySkuId(string skuId)
        {
            TxtSkuId.SetText(WebDriver, skuId);
            BtnViewQuote.WaitForElement(WebDriver);// need to wait till View Quote button is enabled
            BtnSearch.Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return new ProductSearchResultsPage(WebDriver);
        }

        public ProductSearchResultsPage SearchBySystemSearch(string systemDesc)
        {
            TxtSystemSearch.SetText(WebDriver, systemDesc);
            BtnSearch.Click(WebDriver);
            return new ProductSearchResultsPage(WebDriver);
        }

        public ProductSearchResultsPage SearchBySAndPSearch(string snpDesc)
        {
            TxtSnpSearch.SetText(WebDriver, snpDesc);
            BtnSearch.Click(WebDriver);
            return new ProductSearchResultsPage(WebDriver);
        }

        public ProductSearchResultsPage SearchBySIID(string SIDesc)
        {
            TxtSISearch.SetText(WebDriver, SIDesc);
            BtnSearch.Click(WebDriver);
            return new ProductSearchResultsPage(WebDriver);
        }

        public DellOutletProductsPage DellOutletProductsPage()
        {
            LnkDellOutletProducts.Click(WebDriver);
            DsaUtil.WaitAnimationToLoad(WebDriver);
            DsaUtil.TryFindElement(WebDriver,new DellOutletProductsPage(WebDriver).LaptopsTab);
            
            if (! new DellOutletProductsPage(WebDriver).LaptopsTab.Displayed.Equals(true))
            {
                LnkDellProducts.Click(WebDriver);
                LnkDellOutletProducts.Click(WebDriver);
            }
                return new DellOutletProductsPage(WebDriver);
        }

        public ProductSearchResultsPage GetProductName()
        {            
            ProductNameListViewId.GetText(WebDriver);
            return new ProductSearchResultsPage(WebDriver);
        }

        public string GetErrorMesssageInModal()
        {
            string message = string.Empty;
            WebDriver.VerifyBusyOverlayNotDisplayed();
            message = ErrorPopup.FindElement(By.TagName("Label")).Text;
            return message;
        }

		public void CustomerKitSelectorPage()
		{
			LnkCustomerKitSelector.Click(WebDriver);
			DsaUtil.WaitAnimationToLoad(WebDriver);
		}
        public void cliconaddbutton()
        {
            addbuttonconfig.Click(WebDriver);
        }
        public void cliconaddconfigbutton()
        {
            Addconfigbutton.Click(WebDriver);
        }


        public bool VerifyCategoryTreeIsAvailableUnderTab(string expctedvalue)
        {
            
            switch (expctedvalue.Trim())
            {
                case "Desktops & Workstations":
                    new ProductSearchPage(WebDriver).TabDesktops.Click(WebDriver);
                    WebDriver.VerifyBusyOverlayNotDisplayed();
                    var Text_TabDesktop = new ProductSearchPage(WebDriver).TabDesktops.Text;
                    var Text_TreeDesktop = new ProductSearchResultsPage(WebDriver).SearchResultCategorySelection.Text;

                    if (Text_TabDesktop == expctedvalue && Text_TreeDesktop == expctedvalue)
                    {
                        return true;                        
                    }
                    else
                    {
                        return false;                        
                    }
                     
                case "Software & Peripherals":
                    new ProductSearchPage(WebDriver).TabSoftware.Click(WebDriver);
                    WebDriver.VerifyBusyOverlayNotDisplayed();
                    var Text_TabSoftwarePeripherals = new ProductSearchPage(WebDriver).TabSoftware.Text;
                    
                    if (Text_TabSoftwarePeripherals == expctedvalue)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                     

                case "parts & upgrades":
                    new ProductSearchPage(WebDriver).TreePartsUpgrades.Click(WebDriver);
                    WebDriver.VerifyBusyOverlayNotDisplayed();
                    var Text_TreePartsUpgrades = new ProductSearchPage(WebDriver).TreePartsUpgrades.Text;
                    if (Text_TreePartsUpgrades == expctedvalue)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                                     
                 default:
                    return false;
                    
            }
        }

        public bool VerifyTheColumnDataFor_SearchResultsIsReturned(List<Dictionary<string, object>> searchResultGrid)
        {
            
            foreach (var result in searchResultGrid)
            {

                if (result["Description"].ToString() == null || result["Description"].ToString() == string.Empty || result["Description"].ToString() == "-")
                    return false;
                if (result["DBC"].ToString() == null || result["DBC"].ToString() == string.Empty || result["DBC"].ToString() == "-")
                    return false;
                if (result["List Price"].ToString() == null || result["List Price"].ToString() == string.Empty || result["List Price"].ToString() == "-")
                    return false;
            }
            return true;
        }
        public string DeacivatedSKU(IWebDriver WebDriver)
        {
            return WebDriver.FindElement(By.XPath("//label[@id='productResult_grid_deactivated']")).Text;


        }
        public void ExpandConfigTreeandAddItem()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.FindElement(By.XPath("//span[contains(text(),'Configurable Products')]/following::span[contains(text(),'Chromebook Laptops')]")).Click();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.FindElement(By.XPath("//span[contains(text(),'New Chromebook 3180')]")).Click();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.FindElement(By.XPath("//span[contains(text(),'bts002c31')]/following-sibling::span/button")).Click();
            WebDriver.VerifyBusyOverlayNotDisplayed();
        }

        public void RemoveItemfromTree()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.FindElement(By.XPath("//*[@id='RemoveItem_TreeView_Link']")).Click();
            WebDriver.VerifyBusyOverlayNotDisplayed();
        }

        public void ExpandSnPTreeandAddItem(string Addtype)
        {
            //move the page to element.
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.FindElement(By.XPath("//span[contains(text(),'Software & Peripherals')]/following::span[contains(text(),'software')]")).Click();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.FindElement(By.XPath("//span[contains(text(),'Software & Peripherals')]/following::span[contains(text(),'software')]/following::span[contains(text(),'operating systems')]")).Click();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            if (Addtype == "Add")
                WebDriver.FindElement(By.XPath("//span[contains(text(),'Chrome Enterprise Annual')]/following-sibling::span/button[not(contains(text(),'Add Config'))]")).Click();
            else
                WebDriver.FindElement(By.XPath("//span[contains(text(),'Chrome Enterprise Annual')]/following-sibling::span/button[contains(text(),'Add Config')]")).Click();

            WebDriver.VerifyBusyOverlayNotDisplayed();


        }

        public void ExpandConfigTreeandAddItemfromTechSpecs()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.FindElement(By.XPath("//span[contains(text(),'Configurable Products')]/following::span[contains(text(),'Chromebook Laptops')]")).Click();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.FindElement(By.XPath("//span[contains(text(),'New Chromebook 3180')]")).Click();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.FindElement(By.XPath("//span[contains(text(),'bts002c31')]")).Click();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.FindElement(By.XPath("//a[@id='productResult_grid_add']")).Click();
            WebDriver.VerifyBusyOverlayNotDisplayed();
        }

        public void AddconfigbuttonUnderSnP()
        {
            WebDriver.FindElement(By.XPath("//span[contains(text(),'Chrome Enterprise Annual')]/following-sibling::span/button[contains(text(),'Add Config')]")).Click();
        }

        
    }
}