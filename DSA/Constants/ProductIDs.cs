namespace Dsa.Constants
{
    public static class ProductIDs
    {

        #region DefaultProductPage
        public const string ProductConfigureButtonId = "_configure";
        public const string ViewQuoteButtonId = "productSearchResults_viewQuote";
        public const string CurrentQuoteLinkId = "menu_currentQuote";
        public const string ProductCartItemsId = "menu_productItems";
        public const string CartDropdownConfigureButtonId = "mastHead_configItems";

        #endregion

        #region Routes
        public const string ProductsSearchRoute = "/#/products/search/";
        public const string ProductsPreviewRoute = "/#/product/preview";
        public const string ProductsSearchResultRoute = "/#/products/results/";
        #endregion

        #region Product Search
        public const string OrderCodeId = "productSearch_orderCode";
        public const string SkuId = "productSearch_Sku";
        public const string ChassisDescriptionId = "productSearch_chassisDescription";
        public const string SkuDescriptionId = "productSearch_skuDescription";
        public const string ProductSearchButtonId = "productSearch_SearchButton";
        public const string ProductSearchClearButtonId = "productSearch_clearButton";
        public const string ProductBrowseButtonId = "productSearch_clearButton";
        public const string SkuIdLabel = "productSearch_Sku_label";
        public const string ChassisDescriptionLabel = "productSearch_ChassisDescription_label";
        public const string SkuDescriptionLabel = "productSearch_SkuDescription_label";
        #endregion
        #region Product Category Tabs routes
        public const string SearchTab = "Search";
        public const string DesktopsTab = "Desktops & Workstations";
        public const string LaptopsNoteBooksTab = "Laptops & Notebooks";
        public const string PeripheralsTab = "Peripherals";
        public const string ServersTab = "Servers, Storage & Networking";
        public const string SoftwareTab = "Software & Peripherals";
        #endregion
        #region Product Search Results
        public const string ProductListId = "DataTables_div_productResult_paneList";
        public const string ProductCFIListId = "DataTables_div_productCfsProjectResult_paneList";
        public const string ProductNameListViewId = "productResult_list_productName";
        public const string AddToQuoteListView = "productResult_grid_add";
        public const string AddAnotherListView = "productResult_grid_addAnother";
        public const string ConfigureListView = "productResult_grid_configure";
        public const string ListViewDiscountLink = "productResult_list_productDiscount";
        public const string SelectColumnsId = "productResult_selectColumns";
        public const string ProductGridSortId = "productResult_sortBy";
        public const string CategoryFilterLink = "productResult_category_{0}";
        public const string RefinerId = "productResult_refiner_{0}";
        public const string RefinementId = "productResult_refinement_{0}";
        public const string ProductGridId = "productResult_grid";
        public const string GridViewLink = "productResult_GridViewLink";
        public const string ListViewLink = "productResult_ListViewLink";
        public const string ConfigureGridViewButton = "productResult_grid_configure";
        public const string AddAnotherGridViewButton = "productResult_grid_addAnother";
        public const string AddToQuoteGridViewButton = "productResult_grid_add";
        public const string DeActivatedGridViewButton = "productResult_grid_deactivated";
        public const string ProductResultGridSavingsLink = "productResultGrid_savings_{0}";

        public const string CustomerSearchTermLink = "customer_searchTerm_link";
        public const string PillDelete = "pill-delete";
        public const string CustomerSearchSaveLink = "customer_searchSave_link";
        public const string CustomerSearchEditLink = "customer_searchEdit_link";
        public const string BuildToOrderChkBoxChk = "productResult_refinement_2";
        public const string SmartSelection = "productResult_refinement_1";
        public const string BackToSearchLink = "span.search-term-pill > a";
        public const string AddProduct = "productResult_list_add";
        public const string ConfigureProduct = "productResult_list_configure";
        // grid view results label and value keys
        public const string ProductNameGridViewId = "productResultValue_productName";
        public const string BundlePriceLabel = "productResultLabel_bundlePrice";
        public const string BundlePriceValue = "productResultValue_bundlePrice";
        public const string SavingsLabel = "productResultLabel_savings";
        public const string SavingsValue = "productResultValue_savings";
        public const string MarginLabel = "productResultLabel_margin";
        public const string MarginValue = "productResultValue_margin";
        public const string SellingPriceLabel = "productResultLabel_sellingPrice";
        public const string SellingPriceValue = "productResultValue_sellingPrice";
        public const string ProcessorLabel = "productResultLabel_processorDetails";
        public const string ProcessorValue = "productResultValue_processorDetails";
        public const string InventoryValidationSection = "productResultLabel_inventoryInfoSection";
        public const string ContinueToSellLabel = "productResultLabel_continueToSell";
        public const string ATSQuantityLabel = "productConfig_productInfoLI_atsInfo_0_label";
        public const string ATSQuantityValue = "productConfig_productInfoLI_atsInfo_0";
        public const string ProductDetailsATSId = "productResultValue_atsQuantity";
        public const string RestockLabel = "productResultLabel_restock";
        public const string RestockValue = "productResultValue_restock";
        public const string LeadTimeLabel = "productResultLabel_leadTime";
        public const string LeadTimeValue = "productResultValue_leadTime";
        public const string EDDLabel = "productResultLabel_estimatedDeliveryDate";
        public const string EDDValue = "productResultValue_estimatedDeliveryDate";
        public const string ESDLabel = "productResultLabel_estimatedShipDate";
        public const string ESDValue = "productResultValue_estimatedShipDate";
        public const string OSLabel = "productResultLabel_operatingSystemDetails";
        public const string OSValue = "productResultValue_operatingSystemDetails";
        public const string ScreenLabel = "productResultLabel_screenDetails";
        public const string ScreenValue = "productResultValue_screenDetails";
        public const string MemoryLabel = "productResultLabel_memoryDetails";
        public const string MemoryValue = "productResultValue_memoryDetails";
        public const string HDLabel = "productResultLabel_hardDriveDetails";
        public const string HDValue = "productResultValue_hardDriveDetails";
        public const string ItemsPerPage = "grid_paging_itemsPerPage";
        #endregion

        #region Config
        public const string ChangeCatalog = "productConfig_changeCatalog";
        public const string CurrentCatalog = "productConfig_currentCatalog";
        public const string PreviewOnlyHeader = "productConfig_previewOnlyHeader_0";
        public const string ConfigureMastHead = "dropMenu_productItems_configItems";
        public const string ConfigureBrowse = "productBrowse_tree_configure";
        #endregion

        #region Product Tree Browse
        public const string AddToQuoteBrowse = "productBrowse_tree_add";
        public const string AddAnotherBrowse = "productBrowse_tree_addAnother";
        public const string TreeViewNoAnavMsg = "productBrowse_noANAVMessage";

        public const string SnPTree = "Software & Peripherals";
        public const string AllSnPs = "All Software & Peripherals";
        public const string PartsUpgrades = "Parts & Upgrades";
        public const string PhonesCommunication = "Phones and Communication";
        public const string MonitorAccessories = "Monitors & Monitor Accessories";
        public const string HomeTheaterAudio = "Home Theater & Audio";
        public const string Audio = "Audio";
        public const string CameraPhotoVideo = "Camera, Photo & Video";

        public const string ConfigurableProductTree = "Configurable Products";
        public const string LaptopsNoteBooks = "Laptops & Notebooks";
        public const string AllLaptops = "All Laptops & Notebooks";
        public const string Latitude = "Latitude Laptops";
        public const string DellPrecision = "Dell Precision Mobile Workstations";
        public const string DesktopsWorkstations = "Desktops & Workstations";
        public const string AllDesktops = "All Desktops & Workstations";
        public const string OptiplexDesktops = "OptiPlex Desktops";
        public const string DellPrecisionWorkstations = "Dell Precision Workstations";
        public const string ServersStorageNetworking = "Servers, Storage & Networking";
        public const string AllServersStorageNetworking = "All Servers, Storage & Networking";
        public const string ClientSystemsManagement = "Client Systems Management";
        public const string PreviewProductOrderCode = "productConfig_productInfoLI_orderCode_0";

        #endregion

        #region Product Details
        public const string ProductDetailsHeader = "productDetail_Header";
        public const string ProductDetailsOrderCode = "productDetail_OrderCode";
        public const string ProductDetailsProductName = "productDetail_productName";
        public const string ProductDetailsStockId = "productDetail_stock-notification";
        public const string ProductDetailsPriceSectionId = "productDetails_priceDiscount";
        public const string AddToQuoteDetailsView = "productDetail_AddToQuote";
        public const string AddAnotherDetailsView = "productDetail_AddAnother";
        public const string ConfigureDetailsView = "productDetail_Configure";
        public const string ProductDetailsDiscountPercent = "productDetail_DiscountPercent";
        public const string ProductDetailsDiscountPrice = "productDetail_DnCDiscountPrice";
        public const string ProductDetailsDiscountValue = "productDetail_DiscountValue";
        public const string ProductDetailsTotalDiscount = "productDetail_TotalDiscounts";
        public const string ProductDetailsStartingPrice = "productDetail_ListPrice";
        public const string ProductDetailsLeadTime = "productDetail_LeadTimeInDays";
        public const string ProductDetailsEsd = "productDetail_ESD";
        public const string ConfigTypeLabel = "productResultLabel_configurationType";
        public const string ConfigTypeValue = "productResultValue_configurationType";
        public const string ProductDetailsConfigType = "productDetail_ConfigurationType";
        public const string SKUNumber = "productDetail_SkuNumber";
        public const string ProducTechSpecs = "productDetails_TechSpecs";
        public const string PreviewItemNotFound = "productDetails_itemsNotFoundMessage";
        #endregion

        // Product Search Catalog Modal
        public const string CatalogSelect = "customerSetSelect_Grid_select_{0}";
        public const string CatalogGrid = "customerSetSelect_Grid";

        public const string NoResultsMessage = "noResults_Apology_Bold";
        public const string NoResultsMessageOnaSearchTerm = "common_noResults_message";
        public const string EditSearchLink = "customer_searchEdit_link";

        // data results fields
        public const string ListPriceKey = "listPrice"; //UI element changed
        public const string LeadTimeKey = "leadtimedays";
        public const string DiscountKey = "savings";
        public const string NameKey = "name";
        public const string SellingPriceKey = "saleprice";
        public const string ServiceTagKey = "serviceTag";


        public const string ProductConfigOptionFilterDropDown = "productConfig_optionFilterDropDown";
    }
}
