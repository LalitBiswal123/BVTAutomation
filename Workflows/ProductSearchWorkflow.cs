using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Dsa.Constants;
using Dsa.Enums;
using Dsa.Pages;
using Dsa.Pages.Product;
using Dsa.Utils;
using OpenQA.Selenium;
using System;
using ProductSearchPage = Dsa.Pages.ProductSearchPage;
using ProductSearchHomePage = Dsa.Pages.Product.ProductSearchPage;
using Dsa.Pages.Customer;
using Dsa.Pages.Quote;

namespace Dsa.Workflows
{
    /// <summary>
    /// Workflow class for Product Search Page. All product search related workflows should be defined in this class.
    /// </summary>
    public static class ProductSearchWorkflow
    {
        #region Add Product to Quote by Row Number
        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="type"></param>
        /// <param name="textToSearch"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        public static ProductSearchResultsPage AddProductToQuoteByRowNum(IWebDriver driver, ProductSearchType type, string textToSearch, int row=1)
        {
            var prodSearchRes = SearchProduct(driver, type, textToSearch);
            return prodSearchRes.AddItemToCart(row);
        }

        public static CreateQuotePage AddAnItemWithNetTermsAsMethodOfPayment(IWebDriver driver, string PaymentMethod, string ordercode)
        {
            var customerdetailspage = new CustomerDetailsPage(driver);
            
            var createquote = customerdetailspage.CreateQuote();
            createquote.BtnBillToCustomerFinancialInformation.Click(driver);
            
            Thread.Sleep(TimeSpan.FromSeconds(30));
            
            createquote.DdlQuoteCreateFinancialPaymentMethod.PickDropdownByText(driver, PaymentMethod);
            new CreateQuotePage(driver).BtnAddItem();
            Dsa.Workflows.ProductSearchWorkflow.SearchAndAddMultipleItemsToQuote(driver, ProductSearchType.OrderCode, ordercode).ClickViewQuote();

            return new CreateQuotePage(driver);
        }


        #endregion

        #region Search and Multiple Items to Quote
        /// <summary>
        /// Searches the and adds multiple items to quote.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="type">The type.</param>
        /// <param name="textToSearch">The text to search, separated by comma.</param>
        /// <returns></returns>
        public static ProductSearchResultsPage SearchAndAddMultipleItemsToQuote(IWebDriver driver, ProductSearchType type, string textToSearch,bool addAnother = false)
        {
            var orderCodeArr = textToSearch.Split(',');

            for (var i = 1; i <= orderCodeArr.Length; i++)
            {
                var prodSearchRes = SearchProduct(driver, type, orderCodeArr[i - 1]);
                try
                {
                    if(addAnother)
                    {
                        prodSearchRes.AddAnother.Click(driver);
                    }
                    else
                    {
                        prodSearchRes.AddItemToCart(i);
                    }

                    if (i != orderCodeArr.Length)
                    {
                        prodSearchRes.BackToSearchLink.Click(driver);
                    }
                }
                catch (WebDriverException)
                {
                    throw new WebDriverException("Product search failed on product with code: " + orderCodeArr[i - 1]);
                }
            }

            return new ProductSearchResultsPage(driver);
        }

        #endregion

        #region Click Product Configuration Button
        public static void ClickProductConfigurationButton(IWebDriver webDriver)
        {
            new ProductSearchResultsPage(webDriver).ClickProductListConfiguration();
        }

        #endregion

        #region Click go to Quote
        public static void ClickGoToQuote(IWebDriver webDriver)
        {
            new ProductSearchPage(webDriver).GoToCurrentQuotePage();
        }

        #endregion

        #region Search Product
        /// <summary>
        /// Search Product
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="type"></param>
        /// <param name="textToSearch"></param>
        /// <returns></returns>
        public static ProductSearchResultsPage SearchProduct(IWebDriver driver, ProductSearchType type, string textToSearch)
        {
            var prodSearchRes = new ProductSearchResultsPage(driver);

            switch (type)
            {
                case ProductSearchType.OrderCode:
                    prodSearchRes = new ProductSearchPage(driver).SearchByOrderCode(textToSearch);
                    break;
                case ProductSearchType.SkuId:
                    prodSearchRes = new ProductSearchPage(driver).SearchBySkuId(textToSearch);
                    break;
                case ProductSearchType.SystemSearch:
                    prodSearchRes = new ProductSearchPage(driver).SearchBySystemSearch(textToSearch);
                    break;
                case ProductSearchType.SnPSearch:
                    prodSearchRes = new ProductSearchPage(driver).SearchBySAndPSearch(textToSearch);
                    break;
            }

            return prodSearchRes;
        }

        #endregion

        #region NavigateToProductConfigurePage (Commented)
        //public static ProductConfigurePage NavigateToProductConfigurePage(IWebDriver driver, DataRow row, string orderCode)
        //{
        //    var quoteCreatePage = new CreateQuotePage(driver);
        //    quoteCreatePage.SelectCatalog(Catalogs.Healthcare);

        //    quoteCreatePage.QuoteCustomerNumber = row["Customer_Number"].ToString();
        //    quoteCreatePage.QuoteName = "DFS Quote " + DateTime.Now.ToString("yyyyMMddhhmmss");
        //    quoteCreatePage.AddItemsFromsearch();

        //    var productSearctResultsPage = SearchByOrderCode(driver, orderCode);
        //    productSearctResultsPage.AddtoQuoteFromProductResult(driver, 1);

        //    var productConfigure = productSearctResultsPage.ConfigureProduct(driver, 1);
        //    return productConfigure;
        //}

        #endregion

        #region Go To Product Search Main Page
        public static ProductSearchPage GoToProductSearchMainPage(IWebDriver driver, string catalogName)
        {
            HomeWorkflow.GotoProductSearchPage(driver);
            var sharedPage = new SharedPage(driver);
            switch (catalogName.ToUpper())
            {
                case CustCatalogConstants.LargeEntAccounts: sharedPage.SelectCatalog("usle1f");
                    break;
                case CustCatalogConstants.MajorHighEdu: sharedPage.SelectCatalog("ushied1f");
                    break;
                case CustCatalogConstants.MajorK12Edu: sharedPage.SelectCatalog("usk121f");
                    break;
                case CustCatalogConstants.MajorStateLocalGov: sharedPage.SelectCatalog("usslg1f");
                    break;
                case CustCatalogConstants.Healthcare: sharedPage.SelectCatalog("ushea1f");
                    break;
                case CustCatalogConstants.PrefHigherEdu: sharedPage.SelectCatalog("usphied1f");
                    break;
                case CustCatalogConstants.OfflineUSGlobal500: sharedPage.SelectCatalog("usglob1f");
                    break;
                case CustCatalogConstants.PrefStateAndLocalGov: sharedPage.SelectCatalog("uspslg1f");
                    break;
                case CustCatalogConstants.PrefK12Edu: sharedPage.SelectCatalog("uspk121f");
                    break;
                case CustCatalogConstants.EmergingBusiness: sharedPage.SelectCatalog("useb1f");
                    break;
                case CustCatalogConstants.MediumBusiness: sharedPage.SelectCatalog("usmb1f");
                    break;
                case CustCatalogConstants.OfflineChannelPartners: sharedPage.SelectCatalog("uschn1f");
                    break;

            }

            driver.WaitForBusyOverlay();
            return new ProductSearchPage(driver);
        }

        #endregion

        #region Exec Product Search by Criteria
        public static ProductListViewPagePart ExecProductSearchByCriteria(IWebDriver driver, ProductSearchType searchType, string criteria)
        {
            var productAdvSearchPage = new ProductAdvSearchPagePart(driver);

            switch (searchType)
            {
                case ProductSearchType.OrderCode:
                    productAdvSearchPage.OrderCode = criteria;
                    break;
                case ProductSearchType.SkuId:
                    productAdvSearchPage.SkuId = criteria;
                    break;
                case ProductSearchType.SystemSearch:
                    productAdvSearchPage.SystemSearch = criteria;
                    break;
                case ProductSearchType.SnPSearch:
                    productAdvSearchPage.SnPSearch = criteria;
                    break;
                default:
                    productAdvSearchPage.OrderCode = criteria;
                    break;
            }
            var prodResPage = (ProductListViewPagePart)productAdvSearchPage.ExecuteProductSearch();
            
            driver.WaitForBusyOverlay();
            return prodResPage;

        }

        #endregion

        #region Critical Path Searc Product
        public static CreateQuotePage CriticalPathSearchProduct(IWebDriver driver, string productId)
        {
            var quoteCreatePage = new CustomerDetailsPage(driver).UseInQuoteClk();
//            Thread.Sleep(10000);
            quoteCreatePage.AddItemsFromSearch();
            var productSearchResults = AddProductToQuoteByRowNum(driver, ProductSearchType.OrderCode, productId);
            productSearchResults.ClickViewQuote();
            quoteCreatePage.ClickCustomerInformationToggle();
            return quoteCreatePage;
        }

        #endregion

        #region Clicl Dropdown from Tree if not Toggled
        public static void ClickDropdownsFromTreeIfNotToggled(IWebDriver driver, string indexes)
        {
            var indexArr = indexes.Split(',');
            foreach (var element in indexArr.Select(index => driver.GetElement(

                By.CssSelector(
                    string.Format("#main > div > div.col-md-9 > div > div > ul > li:nth-child({0}) > span > span > span > a > i", index)))).Where(element => element.GetAttribute("class").Contains("triangledown")))
            {
                element.Click();
            }
        }

        #endregion

        #region Get first product not deactivated
        public static string GetFirstProductNotDeactivated(IWebDriver driver, string tableCssSelector, string name, bool getOrderName)
        {
            IList<IWebElement> tableRows = driver.GetElements(By.CssSelector(tableCssSelector));
            foreach (var row in tableRows)
            {
                row.FindElement(By.XPath("//table[@id='DataTables_Table_1']/tbody/tr/td/a")).Click();
                if (driver.GetElement(By.Id("productDetail_AddToQuote")).Displayed && driver.GetElement(By.Id("productDetail_" + name)).Text.Length > 2)
                {
                    string returnValue = getOrderName ? driver.GetElement(By.Id("productDetail_productName")).Text.Substring(0, 5) : driver.GetElement(By.Id("productDetail_OrderCode")).Text;
                    driver.GetElement(By.Id("productDetail_AddToQuote")).Click();
                    return returnValue;
                }
//                Thread.Sleep(8000);
                //driver.GetElement(By.CssSelector("#COM > div.modal-large.ng-scope > div > div > div.modal-close > a")).Click();
                driver.GetElement(By.XPath("//*[@id='COM']/div[4]/div/div/div[1]/a")).Click();
//                Thread.Sleep(2000);
            }
            return string.Empty;
        }

        #endregion

        #region Configure Tied SKUs
        public static void ConfigureTiedSkus(IWebDriver driver, string index)
        {
            new CreateQuotePage(driver).Configure();
            driver.ScrollAndClick(
                By.CssSelector(
                    string.Format("#productConfig_header > div > div.col-md-12.mg-top-20.offset-right-0.ng-scope > tabset > div > ul > li:nth-child({0}) > a", index)));
//            Thread.Sleep(1000);
            driver.ScrollAndClick(By.Id("productConfig_option_0_Speakers_toggle"));
            driver.ScrollAndClick(By.Id("productConfig_Speakers_selection_0"));
            driver.ScrollAndClick(By.Id("productConfig_option_0_DellMonitors_toggle"));
            driver.ScrollAndClick(By.Id("productConfig_DellMonitors_selection_1"));
            driver.ScrollAndClick(By.Id("productConfig_option_0_SerialPortPS2Adapter_toggle"));
            driver.ScrollAndClick(By.Id("productConfig_SerialPortPS2Adapter_selection_0"));
        }

        #endregion

        #region ConfigureNonTiedSkus (Commented)
        //public static void ConfigureNonTiedSkus(IWebDriver driver, string index)
        //{
        //    new CreateQuotePage(driver).Configure();
        //    driver.ScrollAndClick(
        //        By.CssSelector(
        //            string.Format("#productConfig_header > div > div.col-md-12.mg-top-20.offset-right-0.ng-scope > tabset > div > ul > li:nth-child({0}) > a", index)));
        //    driver.ScrollAndClick(By.Id("productConfig_option_0_MonitorsStands_toggle"));
        //    driver.ScrollAndClick(By.Id("productConfig_MonitorsStands_selection_1"));
        //    driver.ScrollAndClick(By.Id("productConfig_option_0_Printers_toggle"));
        //    driver.ScrollAndClick(By.Id("productConfig_Printers_selection_0"));
        //}

        #endregion

        #region Add Non Tied SKU monitor
        public static void AddNonTiedSkuMonitor(IWebDriver driver, string index)
        {
            driver.ScrollAndClick(
                By.CssSelector(
                    string.Format("#productConfig_header > div > div.col-md-12.mg-top-20.offset-right-0.ng-scope > tabset > div > ul > li:nth-child({0}) > a", index)));
            driver.ScrollAndClick(By.Id("productConfig_option_0_MonitorsStands_toggle"));
            driver.ScrollAndClick(By.Id("productConfig_MonitorsStands_selection_1"));
        }

        #endregion

        #region Select Item Add and Configure
        public static string SelectItemAddAndConfigure(IWebDriver driver, string index)
        {
            driver.GetElement(
                By.CssSelector(
                    string.Format("#main > div > div.col-md-9 > div > div > ul > li:nth-child({0}) > span > span > span > a", index))).Click();
//            Thread.Sleep(2000);
            var orderCode = driver.GetElement(By.Id("productDetail_OrderCode")).Text;
            driver.GetElement(
                By.CssSelector(
                    "#productDetail_AddToQuote")).Click();
            driver.GetElement(By.Id(ProductIDs.ProductConfigureButtonId)).Click();
            return orderCode;
        }

        #endregion

        #region Click SnP Products Tab
        public static void ClickSnPProductsTab(IWebDriver driver)
        {
            driver.GetElement(
                By.LinkText("Software & Peripherals")).Click();
        }

        #endregion

        #region Click Configurable Peripherals Tab
        public static void ClickConfigurablePeripheralsTab(IWebDriver driver)
        {
            driver.GetElement(
                By.LinkText("Configurable Peripherals")).Click();
        }

        #endregion

        #region Find SnP Product and Confiurable Hardware Service
        public static List<string> FindSnPProductAndConfigureHardWareService(IWebDriver driver, int resultIndex, string hardWareIndex, string numConfigs, string configAllIndex)
        {
            var information = new List<string>();
            driver.GetElement(
                By.Id(
                    string.Format("productResult_category_{0}", resultIndex))).Click();
            GetFirstProductNotDeactivated(driver, string.Format("#DataTables_Table_{0} > tbody > tr", resultIndex-1), "Header", false);
            driver.GetElement(By.Id("productResult_list_configure")).Click();
            //driver.ScrollAndClick(
            //     By.CssSelector(
            //         string.Format("#productConfig_header > div > div.col-md-12.mg-top-20.offset-right-0.ng-scope > tabset > div > ul > li:nth-child({0}) > a", configAllIndex)));
            driver.ScrollAndClick(By.Id("productConfig_option_0_HardwareSupportServices_toggle"));
            driver.ScrollAndClick(By.Id(string.Format("productConfig_HardwareSupportServices_selection_{0}", hardWareIndex)));
            Logger.Write("post click");
            information.Add(
                driver.GetElement(
                    By.Id(string.Format("productConfig_{0}_HardwareSupportServices_listPrice_{1}", numConfigs,
                        hardWareIndex))).Text);
            Logger.Write("found list price");
            information.Add(
                driver.GetElement(
                    By.Id(string.Format("productConfig_HardwareSupportServices_desc_{0}",
                        hardWareIndex))).Text.Substring(0, 5));
            Logger.Write("found description");
            driver.GetElement(By.Id("productConfig_summary_update")).Click();
            Logger.Write("clicked update");
            return information;
        }

        #endregion

        #region Verify Product Search Results Grid
        /// <summary>
        /// Validate the table count
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="tableData"></param>
        /// <returns></returns>
        public static bool VerifyProductSearchResultsGrid(List<Dictionary<string, object>> tableData)
        {
            if (tableData.Count >= 1)
            {
                return tableData[0].Keys.Count > 1; // If Keys Count == 1, then no item is in the grid. So must be compared with Keys Count > 1.
            }

            return false;
        }

        #endregion

        #region Preview by Order Code
        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="orderCode"></param>
        /// <param name="catalogName"></param>
        /// <returns></returns>
        public static PreviewOrderCodePage PreviewByOrderCode(IWebDriver driver, string orderCode, string catalogName)
        {
            var catalog = (Catalogs)Enum.Parse(typeof(Catalogs), catalogName);
            var previewSearch = new PreviewOrderCodePage(driver);
            previewSearch.SelectCatalog(catalog);
            previewSearch.OrderCode = orderCode;
            previewSearch.ExecuteSearch();
            return previewSearch;

        }

        #endregion
         

        #region Click Find Dell Outlet Products

        public static void ClickFindDellOutletProducts(IWebDriver driver)
        {
            new ProductSearchPage(driver).LnkDellOutletProducts.Click(driver);
        }

        #endregion


        #region AddAnItemAndSelectPaymentMethod
        public static CreateQuotePage AddAnItemAndSelectPaymentMethod(IWebDriver driver, string PaymentMethod, string ordercode, int i)
        {

            var customerdetailspage = new CustomerDetailsPage(driver);
            customerdetailspage.CreateQuote();
            var createquote = new CreateQuotePage(driver);
            createquote.BtnBillToCustomerFinancialInformation.Click(driver);
            Thread.Sleep(TimeSpan.FromSeconds(30));
           // createquote.DdlQuoteCreateFinancialPaymentMethod.PickDropdownByText(driver, PaymentMethod);
            createquote.BtnAddItemCreateQuote(i);
            Dsa.Workflows.ProductSearchWorkflow.SearchAndAddMultipleItemsToQuote(driver, ProductSearchType.OrderCode, ordercode).ClickViewQuote();

            return new CreateQuotePage(driver);

        }
        #endregion

        #region Add Products From each product category tabs

        public static bool VerifyProductCategoryTabs_AndAddProducts(IWebDriver driver)
        {            
            IList<IWebElement> ProductTabs = driver.GetElements(By.XPath("//div[@class='col-md-12']//li[@ng-repeat='tab in categories track by $index']//a"));           
                IWebElement element = ProductTabs[0];
                element.Click();  
                driver.VerifyBusyOverlayNotDisplayed();
                var productsearchResultsPage = new ProductSearchResultsPage(driver);
                driver.VerifyBusyOverlayNotDisplayed();
                productsearchResultsPage.AddProductFromTabs(driver);
            var ItemCount = productsearchResultsPage.LblItemCountMastHead.Text.Split(' ')[0];
            var TabCount = ProductTabs.Count + 1;
            if (TabCount.ToString() == ItemCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        #endregion
    }
}
