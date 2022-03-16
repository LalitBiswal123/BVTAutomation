using System.Globalization;
using Dsa.Constants;
using Dsa.Enums;
using Dsa.Pages.Quote;
using Dsa.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using Dsa.DataModels;
using Dsa.Pages.Customer;
using Dsa.Pages.Product;
using FluentAssertions;
using ProductSearchPage = Dsa.Pages.ProductSearchPage;
using Newtonsoft.Json;
using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using System.Linq;

namespace Dsa.Workflows
{
    /// <summary>
    /// Create quote workflows will be defined in this class.
    /// </summary>
    public static class CreateQuoteWorkflow
    {
        #region Create Quote from Menu

        /// <summary>
        /// Creates the quote from mast head.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="catalog">The catalog.</param>
        /// <param name="customerNumber">The customer number.</param>
        /// <param name="products">The products.</param>
        /// <param name="contractCode">The contract code.</param>
        /// <param name="quoteName">Name of the quote.</param>
        /// <param name="saveQuote">if set to <c>true</c> [save quote].</param>
        public static void CreateQuoteFromMenu(IWebDriver driver,Catalogs catalog, string customerNumber, Dictionary<string, ProductSearchType> products,
            string contractCode = "", string quoteName = "", bool saveQuote = true, string endUserCustomer = "")
        {
            var crQuotePage = new CreateQuotePage(driver);
            crQuotePage.SelectCatalog(catalog);
            if (!string.IsNullOrEmpty(quoteName))
                crQuotePage.TxtQuoteName.SetText(driver, quoteName);
            crQuotePage.TxtCustomerNumber.SetText(driver, customerNumber);
            crQuotePage.ValidateCustomerNumberPatch();
            AddMoreItemsToQuote(driver, products);

            if (!string.IsNullOrEmpty(contractCode))
                crQuotePage.ApplyContractCodeToAllItems(contractCode);
            
            if (!string.IsNullOrEmpty(endUserCustomer))
                crQuotePage.TxtEndUserCustomerNumber.SetText(driver,endUserCustomer);
            if (!saveQuote) return;
            crQuotePage.SaveQuote();
        }

        public static string CreateQuoteFromMenuGetQuoteNumber(IWebDriver driver,
            Catalogs catalog, string customerNumber, Dictionary<string, ProductSearchType> products,
            string contractCode = "", string quoteName = "", bool saveQuote = true)
        {
            var crQuotePage = new CreateQuotePage(driver);
            crQuotePage.SelectCatalog(catalog);
            crQuotePage.TxtCustomerNumber.SetText(driver, customerNumber);
            if (!string.IsNullOrEmpty(quoteName)) crQuotePage.TxtQuoteName.SetText(driver, quoteName);
            AddMoreItemsToQuote(driver, products);
            if (!string.IsNullOrEmpty(contractCode)) crQuotePage.ApplyContractCodeToAllItems(contractCode);
            if (saveQuote)
            {
                crQuotePage.SaveQuote();
            }
            return new CreateQuotePage(driver).GetQuoteNumber();


        }

        /// <summary>
        ///  Create quote with two shipping groups
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="catalog"></param>
        /// <param name="customerNumber"></param>
        /// <param name="products"></param>
        /// <param name="contractCode"></param>
        /// <param name="quoteName"></param>
        /// <param name="saveQuote"></param>
        public static void CreateQuoteWithTwoShippingGroups(IWebDriver driver,
            Catalogs catalog, string customerNumber, Dictionary<string, ProductSearchType> products,
            string contractCode = "", string quoteName = "", bool saveQuote = true)
        {
            new CreateQuotePage(driver).SelectCatalog(catalog);
            new CreateQuotePage(driver).TxtCustomerNumber.SetText(driver, customerNumber);
            AddItemsToGroups(0, driver, products);
            new ProductSearchResultsPage(driver).GoToCurrentQuotePage();
            if (!string.IsNullOrEmpty(contractCode)) new CreateQuotePage(driver).ApplyContractCodeToAllItems(contractCode);
            new CreateQuotePage(driver).ClickAddShippingGroup();
            AddItemsToGroups(1, driver, products);

            if (!string.IsNullOrEmpty(quoteName))
                new CreateQuotePage(driver).TxtQuoteName.SetText(driver, quoteName);

            if (saveQuote)
                new CreateQuotePage(driver).SaveQuote();           
        }

        public static void CreateQuoteWithTwoShippingGroupsWithTwoDifferentProducts(IWebDriver driver,
          Catalogs catalog, string customerNumber, Dictionary<string, ProductSearchType> products1, Dictionary<string, ProductSearchType> products2,
          string contractCode1 = "", string contractCode2 = "", string quoteName = "", bool saveQuote = true)
        {
            //var createQuotePage = new CreateQuotePage(driver);
            new CreateQuotePage(driver).SelectCatalog(catalog);
            new CreateQuotePage(driver).TxtCustomerNumber.SetText(driver, customerNumber);
            AddItemsToGroups(0, driver, products1);
            new ProductSearchResultsPage(driver).GoToCurrentQuotePage();
            if (!string.IsNullOrEmpty(contractCode1))
            {
                new CreateQuotePage(driver).TxtContractCodeAt().SetText(driver, contractCode1);
                new CreateQuotePage(driver).GetPaymentTerms();
                driver.VerifyBusyOverlayNotDisplayed(); // After patching contract code wait for busy overlay
            }
            new CreateQuotePage(driver).ClickAddShippingGroup();
            AddItemsToGroups(1, driver, products2);
            new ProductSearchResultsPage(driver).GoToCurrentQuotePage();
            if (!string.IsNullOrEmpty(contractCode2))
            {
                new CreateQuotePage(driver).TxtContractCodeAt(2, 1).SetText(driver, contractCode2);
                new CreateQuotePage(driver).GetPaymentTerms();
                driver.VerifyBusyOverlayNotDisplayed(); // After patching contract code wait for busy overlay
            }
             if (!string.IsNullOrEmpty(quoteName))
            {
                new CreateQuotePage(driver).TxtQuoteName.SetText(driver, quoteName);
                //driver.VerifyBusyOverlayNotDisplayed();
            }
            if (saveQuote)
                new CreateQuotePage(driver).SaveQuote();
        }

        public static void CreateQuoteFromMenuNoContractCode(IWebDriver driver,
            Catalogs catalog, string customerNumber, Dictionary<string, ProductSearchType> products,
            string quoteName = "", bool saveQuote = true)
        {
            var crQuotePage = new CreateQuotePage(driver);
            crQuotePage.SelectCatalog(catalog);
            crQuotePage.TxtCustomerNumber.SetText(driver, customerNumber);
            AddMoreItemsToQuote(driver, products);
            if (!string.IsNullOrEmpty(quoteName)) crQuotePage.TxtQuoteName.SetText(driver, quoteName);
            if (saveQuote)
            {
                crQuotePage.SaveQuote();
            }
        }

        public static void CreateQuoteFromMenuNoCustomer(IWebDriver driver,
          Catalogs catalog,  Dictionary<string, ProductSearchType> products,
          string quoteName = "")
        {
            var crQuotePage = new CreateQuotePage(driver);
            crQuotePage.SelectCatalog(catalog);
            AddMoreItemsToQuote(driver, products, false, false);
            if (!string.IsNullOrEmpty(quoteName)) crQuotePage.TxtQuoteName.SetText(driver, quoteName);
        }

        #endregion

        #region Create Quote from Customer Search
        public static void CreateQuoteFromCustomerSearch(IWebDriver driver,string customerNumber, Dictionary<string, ProductSearchType> products,
            string contractCode = "", string quoteName = "", bool saveQuote = true, bool SnPasConfig = false, string enduserNo = "")
        {
            HomeWorkflow.GoToPersonSearch(driver);
            new PersonSearchPage(driver).SearchPersonByCustomerNumber(customerNumber).CreateQuote();
            if (!string.IsNullOrEmpty(quoteName))
                new CreateQuotePage(driver).TxtQuoteName.SetText(driver, quoteName);
            AddMoreItemsToQuote(driver, products, SnPasConfig);
            if (!string.IsNullOrEmpty(contractCode))
                new CreateQuotePage(driver).ApplyContractCodeToAllItems(contractCode);
            //new CreateQuotePage(driver).ClickICodeOverride(); team need to add this action in their script
            if(!string.IsNullOrEmpty(enduserNo))
                new CreateQuotePage(driver).TxtEndUserCustomerNumber.SetText(driver, enduserNo);
            //validate ordercode and sku in quote
            //ValidateOrderAndSku(driver, products, 1);
            if (saveQuote)
                new CreateQuotePage(driver).SaveQuote();
        }

        #endregion

        #region Add more Items to Quote
        public static void AddMoreItemsToQuote(IWebDriver driver, Dictionary<string, ProductSearchType> products,bool SnPasConfig=false, bool isCustomerPatched = true)
        {
            new CreateQuotePage(driver).AddItemsFromSearch();

            foreach (KeyValuePair<string, ProductSearchType> item in products)
            {
                if (item.Value == ProductSearchType.OrderCode)
                    new ProductSearchPage(driver).SearchByOrderCode(item.Key);
                else if (item.Value == ProductSearchType.SkuId)
                    new ProductSearchPage(driver).SearchBySkuId(item.Key);

                int itemCount = new ProductSearchResultsPage(driver).GetItemCountFromMastHead();
                new ProductSearchResultsPage(driver).AddItemToCart(0,SnPasConfig);

                //if(new ProductSearchResultsPage(driver).GetItemCountFromMastHead() == itemCount)
                //    throw new Exception("[QE Exception] Item '" + item.Key + "' could not be added to quote. Therefore, aborting testcase execution.");
                new ProductSearchResultsPage(driver).BackToSearchClick();
                new ProductSearchResultsPage(driver).LblItemCountMastHead.WaitUntilTextChanges(driver, (itemCount + 1).ToString());
            }

            new ProductSearchPage(driver).GoToCurrentQuotePage();
            // driver.WaitForFetchingCart();

            //Saravana : new CreateQuotePage(driver).WaitForQuoteValidationToComplete();
            //Adding below code to get Quote id and Draft quote no 
            if (isCustomerPatched)
            {
                Logger.Write("Quote id :" + new CreateQuotePage(driver).LblQuoteIdOnDraftQuotePage());
                string drftQuoteNo = new CreateQuotePage(driver).LblDraftQuoteNumber.GetText(driver);
                Logger.Write("Draft quote no : " + drftQuoteNo);
            }
        }
        public static void AddItemsToGroups(int ShippingGroupIndex, IWebDriver driver, Dictionary<string, ProductSearchType> products)
        {
            new CreateQuotePage(driver).AddItemsFromSearch(ShippingGroupIndex);

            foreach (KeyValuePair<string, ProductSearchType> item in products)
            {
                if (item.Value == ProductSearchType.OrderCode)
                    new ProductSearchPage(driver).SearchByOrderCode(item.Key);
                else if (item.Value == ProductSearchType.SkuId)
                    new ProductSearchPage(driver).SearchBySkuId(item.Key);

                int itemCount = new ProductSearchResultsPage(driver).GetItemCountFromMastHead();
                new ProductSearchResultsPage(driver).AddItemToCart();
                //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                DsaUtil.WaitUntilTextChanges(new ProductSearchResultsPage(driver).LblItemCountMastHead, driver, (itemCount + 1).ToString());
                if (new ProductSearchResultsPage(driver).GetItemCountFromMastHead() == itemCount)
                    throw new Exception("[QE Exception] Item '" + item.Key + "' could not be added to quote. Therefore, aborting testcase execution.");
                new ProductSearchResultsPage(driver).BackToSearchClick();
            }

            new ProductSearchPage(driver).GoToCurrentQuotePage();
            driver.WaitForFetchingCart();
        }

        #endregion

        #region Add Items From Search
        /// <summary>
        /// Adds the items from search.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="testContext">The test context.</param>
        /// <returns></returns>

        public static CreateQuotePage AddItemsFromSearch(IWebDriver driver, TestContext testContext)
        {
            var row = testContext.DataRow;
            var quoteCreatePage = new CreateQuotePage(driver);
            quoteCreatePage.AddItemsFromSearch();
            var productSearchResultPage = new ProductSearchResultsPage(driver);
            //if (string.IsNullOrWhiteSpace(row["Order_Codes"].ToString()))
            if (!string.IsNullOrWhiteSpace(row["Order_Codes"].ToString()))
                productSearchResultPage = ProductSearchWorkflow.SearchAndAddMultipleItemsToQuote(driver, ProductSearchType.OrderCode,
                    row["Order_Codes"].ToString());

            if (!string.IsNullOrWhiteSpace(row["Skus"].ToString()))
            {
                HomeWorkflow.GotoProductSearchPage(driver);
                productSearchResultPage = ProductSearchWorkflow.SearchAndAddMultipleItemsToQuote(driver, ProductSearchType.SkuId,
                    row["Skus"].ToString());
            }
            if (!string.IsNullOrWhiteSpace(row["SnP_Codes"].ToString()))
            {
                HomeWorkflow.GotoProductSearchPage(driver);
                productSearchResultPage = ProductSearchWorkflow.SearchAndAddMultipleItemsToQuote(driver, ProductSearchType.SnPSearch,
                   row["SnP_Codes"].ToString());
            }

            return productSearchResultPage.GoToCurrentQuotePage();
        }

        #endregion

        #region Custom Add Items From Search
        /// <summary>
        /// Adds Config/SKU/SNP items from search.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="testContext">The test context.</param>
        /// <returns></returns>

        public static CreateQuotePage CustomAddItemsFromSearch(IWebDriver driver, TestContext testContext, String OrderCode, String SKU, String SNPCodes )
        {
            var row = testContext.DataRow;
            var quoteCreatePage = new CreateQuotePage(driver);
            quoteCreatePage.AddItemsFromSearch();
            var productSearchResultPage = new ProductSearchResultsPage(driver);
            //if (string.IsNullOrWhiteSpace())
            if (!string.IsNullOrWhiteSpace(OrderCode))
                productSearchResultPage = ProductSearchWorkflow.SearchAndAddMultipleItemsToQuote(driver, ProductSearchType.OrderCode, OrderCode);

            if (!string.IsNullOrWhiteSpace(SKU))
            {
                HomeWorkflow.GotoProductSearchPage(driver);
                productSearchResultPage = ProductSearchWorkflow.SearchAndAddMultipleItemsToQuote(driver, ProductSearchType.SkuId, SKU);
            }
            if (!string.IsNullOrWhiteSpace(SNPCodes))
            {
                HomeWorkflow.GotoProductSearchPage(driver);
                productSearchResultPage = ProductSearchWorkflow.SearchAndAddMultipleItemsToQuote(driver, ProductSearchType.SnPSearch, SNPCodes);
            }

            return productSearchResultPage.GoToCurrentQuotePage();
        }

        #endregion

        #region Set Quote Name

        public static void SetQuoteName(CreateQuotePage quoteCreatePage, string quoteName)
        {
            quoteCreatePage.TxtQuoteName.SetText(quoteCreatePage.WebDriver, quoteName);
        }

        #endregion

        #region Copy Quote and Save as New

        // Copies the given quote and saves as a new quote number
        public static QuoteDetailsPage CopyQuoteAndSaveAsNew(IWebDriver driver, string contractCode = null, string endUserCustomer = "")
        {
            var copyQuote = new QuoteDetailsPage(driver);
            var copiedQuote = copyQuote.CopyQuote();
            //ApplyDefaultContractCodeToAllLineItems(driver,
            //        contractCode);
            copiedQuote.TxtEndUserCustomerNumber.SetText(driver,endUserCustomer);
            copiedQuote.SaveQuote();
            //copiedQuote.ClickOnVersionRadioBtn();
            //copiedQuote.ClickOnQuoteVersionNext();
            return new QuoteDetailsPage(driver);
        }

        #endregion

        #region Critical Path Quote Create

        public static QuoteDetailsPage CriticalPathQuoteCreate(IWebDriver driver, string contractCode, string name)
        {
            var quoteCreatePage = new CreateQuotePage(driver);
            SetQuoteName(quoteCreatePage, name);
            quoteCreatePage.ApplyContractCodeToAllItems(contractCode);
            return quoteCreatePage.SaveQuote();
        }

        #endregion

        #region Critical path Quote Create No Contract Code

        public static QuoteDetailsPage CriticalPathQuoteCreateNoContractCode(IWebDriver driver, string name)
        {
            var quoteCreatePage = new CreateQuotePage(driver);
            SetQuoteName(quoteCreatePage, name);
            return quoteCreatePage.SaveQuote();
        }

        #endregion

        #region Critical Path Copy Quote

        public static QuoteDetailsPage CriticalPathCopyQuote(IWebDriver driver, string name)
        {
            new QuoteDetailsPage(driver).CopyQuote();
            SetQuoteName(new CreateQuotePage(driver), name);
            new CreateQuotePage(driver).SaveQuote();
            new CreateQuotePage(driver).ClickOnVersionRadioBtn();
            new CreateQuotePage(driver).ClickOnQuoteVersionNext();
            return new QuoteDetailsPage(driver);
        }

        #endregion

        #region Dollar Value String to Double Conversion

        public static double DollarValueStringToDoubleConversion(string dollarValue)
        {
            double result;
            double.TryParse(dollarValue.Replace("$", String.Empty), out result);
            return result;
        }

        #endregion

        #region Precent Value String to Double Conversion

        public static double PercentValueStringToDoubleConversion(string percentValue)
        {
            double result;
            double.TryParse(percentValue.Replace("%", String.Empty), out result);
            return result;
        }

        #endregion

        #region Percent and Dollar Value String to Double Conversion
        public static double PercentAndDollarValueStringToDoubleConversion(string value, bool dollarOrPercent)
        {
            var parseResult = value.Split(' ');
            return dollarOrPercent ? DollarValueStringToDoubleConversion(parseResult[2]) : PercentValueStringToDoubleConversion(parseResult[0]);
        }

        #endregion

        #region Commented method- SplitLineValidatingQuote
        //public static ItemQuoteData SplitLineValidatingQuote(IWebDriver testWebDriver, string customerNumber, string productNumber, string contractCode, int quantity, SplitLineValidation typeValidation)
        //{

        //    CustomerSearch.CriticalPathSearchCustomer(testWebDriver, customerNumber);
        //    new CustomerDetailsPage(testWebDriver).CustomerNumber.Should().BeEquivalentTo(customerNumber);

        //    new CustomerDetailsPage(testWebDriver).UseInQuoteClk();
        //    SelectQuoteAddressByName(testWebDriver, "Standard");


        //    new CreateQuotePage(testWebDriver).AddItemsFromsearch();
        //    ProductSearch.AddProductToQuoteByRowNum(testWebDriver, ProductSearchType.OrderCode, productNumber);
        //    new ProductSearchResultsPage(testWebDriver).ClickViewQuote();


        //    new CreateQuotePage(testWebDriver).TotalLineItemCount.Should().Be(1);

        //    ApplyDefaultContractCodeToAllLineItems(testWebDriver, contractCode);
        //    Thread.Sleep(2000);
        //    new CreateQuotePage(testWebDriver).SetLineItemQuantity(1, quantity);

        //    switch (typeValidation)
        //    {
        //        case SplitLineValidation.SplitLineItemByQuantity:
        //            new CreateQuotePage(testWebDriver).QuoteName = "Split Line Item - Quantity";
        //            break;
        //        case SplitLineValidation.SplitLineItemPerShippingAddressModified:
        //            new CreateQuotePage(testWebDriver).QuoteName = "Split Line Item - Modified Shipping Address";
        //            SelectQuoteAddressByName(testWebDriver, "Modified Close");
        //            break;
        //        case SplitLineValidation.SplitLineItemPerShippingMethodModified:
        //            new CreateQuotePage(testWebDriver).QuoteName = "Split Line Item - Modified Shipping Method";
        //            new CreateQuotePage(testWebDriver).SelectShippingMethod(1,1);

        //            break;
        //        case SplitLineValidation.SplitLineItemManualTestModifiedClose:
        //            new CreateQuotePage(testWebDriver).QuoteName = "Split Line Item - Modified Close Address";

        //            SelectQuoteAddressByName(testWebDriver, "Modified Close");

        //            break;


        //        case SplitLineValidation.SplitLineItemManualTestModifiedFar:
        //            new CreateQuotePage(testWebDriver).QuoteName = "Split Line Item - Modified Far Address";

        //            SelectQuoteAddressByName(testWebDriver, "Modified Far");

        //            break;

        //        case SplitLineValidation.SplitLineItemOriginal:
        //            new CreateQuotePage(testWebDriver).QuoteName = "Split Line Item - Original";

        //            break;
        //    }

        //    var quoteData = new ItemQuoteData();
        //    new CreateQuotePage(testWebDriver).ShowMoreForEachItemClk();
        //    quoteData.testCaseName = new CreateQuotePage(testWebDriver).QuoteName;
        //    quoteData.totalShipping = new CreateQuotePage(testWebDriver).QuoteCreateShippingAmount;
        //    quoteData.quantity = int.Parse(new CreateQuotePage(testWebDriver).GetLineItemQuantity(1));
        //    quoteData.sellingPrice = new CreateQuotePage(testWebDriver).QuoteCreateSubtotalAmount;
        //    quoteData.finalPrice = new CreateQuotePage(testWebDriver).QuoteCreateFinalPrice;
        //    quoteData.ecoFee = new CreateQuotePage(testWebDriver).QuoteCreateEcoFee;
        //    quoteData.validationType = typeValidation;
        //    quoteData.taxAmount =
        //    new CreateQuotePage(testWebDriver).QuoteCreateTotalTaxAmount;
        //    quoteData.taxAmountDouble =
        //    DollarValueStringToDoubleConversion(quoteData.taxAmount);
        //    quoteData.totalShippingDouble = DollarValueStringToDoubleConversion(quoteData.totalShipping);
        //    quoteData.finalPriceDouble =
        //    DollarValueStringToDoubleConversion(quoteData.finalPrice);

        //    new CreateQuotePage(testWebDriver).SaveQuote();
        //    quoteData.quoteNumber = new QuoteDetailsPage(testWebDriver).QuoteNumber;
        //    quoteData.testCaseName = new QuoteDetailsPage(testWebDriver).QuoteTitle;
        //    return quoteData;

        //}
        #endregion

        #region Select Quote Address by Name

        public static void SelectQuoteAddressByName(IWebDriver testWebDriver, string searchString)
        {
            testWebDriver.ScrollAndClick(By.Id("quoteCreate_chooseAddress"));
            testWebDriver.PickDropdownByText(By.Id("customerSelect_searchFilter"), "Name");
            testWebDriver.GetElement(By.Id("customerSelect_searchFilter_value")).Click(testWebDriver);
            testWebDriver.GetElement(By.Id("customerSelect_searchFilter_value")).Clear();
            testWebDriver.GetElement(By.Id("customerSelect_searchFilter_value")).SendKeys(searchString);
            testWebDriver.GetElement(By.Id("customerSelect_searchAction")).Click(testWebDriver);
            testWebDriver.GetElements(By.Id("addressSelect_addressGrid_select"))[0].Click(testWebDriver);
        }

        #endregion

        #region Select line item address by name

        public static void SelectLineItemAddressByName(IWebDriver testWebDriver, int index, string searchString)
        {
            testWebDriver.GetElement(By.Id(string.Format("quoteCreate_LI_SI_shippingPickAddressLink_{0}", index))).Click(testWebDriver);
            testWebDriver.PickDropdownByText(By.Id("customerSelect_searchFilter"), "Name");
            testWebDriver.GetElement(By.Id("customerSelect_searchFilter_value")).Click(testWebDriver);
            testWebDriver.GetElement(By.Id("customerSelect_searchFilter_value")).Clear();
            testWebDriver.GetElement(By.Id("customerSelect_searchFilter_value")).SendKeys(searchString);
            testWebDriver.GetElement(By.Id("customerSelect_searchAction")).Click(testWebDriver);
            testWebDriver.GetElements(By.Id("addressSelect_addressGrid_select"))[0].Click(testWebDriver);
        }

        #endregion

        #region Collect Data from Line Item

        public static ItemQuoteData CollectDataFromLineItem(IWebDriver driver, int index,
            SplitLineValidation typeSplitLineValidation, int groupIndex = 1)
        {
            var quoteData = new ItemQuoteData();
            //var showMore = driver.GetElements(By.XPath("//div[@class='content-toggle-content ng-scope']"));
            //showMore[index - 1].Click();
            //quoteData.Edd =
            //    driver.GetElement(
            //        By.XPath(string.Format("//div[@id='quoteCreate_LI_SI_estimatedDeliveryDate_{0}']", index))).Text;

            quoteData.ProductDescription = new CreateQuotePage(driver).GetLineItemProductDescription(index);
            //quoteData.TotalShipping = new CreateQuotePage(driver).GetLineItemTotalShippingPrice(index);

            quoteData.Quantity = int.Parse(new CreateQuotePage(driver).GetLineItemQuantity(index, groupIndex));
            quoteData.SellingPrice = new CreateQuotePage(driver).GetLineItemSellingPrice(index);
            //quoteData.FinalPrice = new CreateQuotePage(driver).GetLineItemTotalAmount(index);
            quoteData.Discount = double.Parse(new CreateQuotePage(driver).GetItemLevelDiscount(groupIndex, index));

            //quoteData.EcoFee = new CreateQuotePage(driver).GetLineItemTotalEcoFee(index);
            //quoteData.ValidationType = typeSplitLineValidation;
            //quoteData.TaxAmount =
            //    new CreateQuotePage(driver).GetLineItemTotalTax(index);
            //quoteData.TaxAmountDouble =
            //    DollarValueStringToDoubleConversion(quoteData.TaxAmount);
            //quoteData.TotalShippingDouble = DollarValueStringToDoubleConversion(quoteData.TotalShipping);
            //quoteData.FinalPriceDouble =
            //    DollarValueStringToDoubleConversion(quoteData.FinalPrice);
            //if (new CreateQuotePage(driver).LineItemOrderCodeExists(index))
            //{
            //    quoteData.OrderCode = new CreateQuotePage(driver).GetLineItemOrderCode(index);
            //}
            return quoteData;
        }

        #endregion

        #region Create Quote with Items and Contract Code

        public static CreateQuotePage CreateQuoteWithItemsAndContractCode(IWebDriver driver, TestContext data, string contractCode, string customerNumber)
        {
            HomeWorkflow.GoToPersonSearch(driver);
            var customerDetailsPage = new PersonSearchPage(driver).SearchPersonByCustomerNumber(customerNumber);
            try
            {
                customerDetailsPage.CreateQuote();
            }
            catch (WebDriverException)
            {
                throw new WebDriverException("No results for customer " + customerNumber + ".");
            }

            AddItemsFromSearch(driver, data);

            try
            {
                new CreateQuotePage(driver).ApplyContractCodeToAllItems(contractCode);
            }
            catch (Exception)
            {
                throw new WebDriverException("Quote Create page did not load properly.");
            }
            new CreateQuotePage(driver).TxtQuoteName.SetText(driver, data.DataRow["Quote_Name"].ToString());
            return new CreateQuotePage(driver);
        }

        #endregion

        #region Set Expiration Date

        public static void SetExpirationDate(IWebDriver driver, string year)
        {
            driver.GetElement(By.CssSelector(QuoteCreatePageConstants.ExpirationDateViewButtonCss)).Click(driver);
            driver.GetElement(
                By.CssSelector(".k-calendar > div.k-header > a.k-link.k-nav-fast")).Click(driver);
            driver.GetElement(
                By.CssSelector(".k-calendar > table > tbody > tr:nth-child(2) > td:nth-child(4) > a")).Click(driver);
            driver.GetElement(By.CssSelector(".k-calendar > table > tbody > tr:nth-child(2) > td:nth-child(4) > a")).Click(driver);
        }

        #endregion

        #region Show more add unit selling prices

        public static decimal ShowMoreAddUnitSellingPrices(IWebDriver driver, int index)
        {
            driver.ScrollAndClick(By.CssSelector(string.Format("#quoteCreate_LI_show_more_{0} > div > a", index)));
            driver.ScrollAndClick(
                By.XPath(
                    "//div[@class='mg-btm-10 pull-right']/a[1]"));
            int totalElements =
                driver.GetElements(By.CssSelector(string.Format("#lineitem_config_block_{0} > div", index))).Count;
            decimal totalSellingPrice = 0;
            for (int i = 1; i <= totalElements; i++)
            {
                totalSellingPrice +=
                    Convert.ToDecimal(DollarValueStringToDoubleConversion(
                        driver.GetElement(
                            By.Id(string.Format("quoteCreate_LI_CS_configSellingPrice_build{0}_category{1}", index, i)))
                            .Text));
            }
            driver.ScrollAndClick(
                By.XPath(
                    "//div[@class='mg-btm-10 pull-right']/a[2]"));
            driver.ScrollAndClick(By.CssSelector(string.Format("#quoteCreate_LI_show_more_{0} > div > a", index)));
            return totalSellingPrice;
        }

        #endregion

        #region Set Discount more than contract discount

        public static void SetDiscountMoreThanContractDiscount(IWebDriver driver, int totalItems)
        {
            for (int i = 1; i <= totalItems; i++)
            {
                decimal contractDiscount =
                    Convert.ToDecimal(
                        PercentValueStringToDoubleConversion(
                            driver.GetElement(By.Id(string.Format("quoteCreate_LI_PI_unitPercent_{0}", i))).Text));
                decimal newDiscount = contractDiscount + 1;
                driver.GetElement(By.CssSelector(string.Format("#quoteCreate_LI_PI_dolPercentage_{0} > input", i))).Clear();
                By.CssSelector(string.Format("#quoteCreate_LI_PI_dolPercentage_{0} > input", i)).SetText(driver, newDiscount.ToString(CultureInfo.InvariantCulture));
            }
        }

        #endregion

        #region Find validating line item index

        public static int FindValidatingLineItemIndex(IWebDriver driver, string validatingProduct, int itemCount)
        {
            var showMore = driver.GetElements(By.XPath("//div[@class='content-toggle-content ng-scope']"));

            int index;
            for (index = 1; index <= itemCount; index++)
            {
                showMore[index - 1].Click(driver);

                //Thread.Sleep(3000);

                var skuNumber = new CreateQuotePage(driver).GetLineItemOrderCode(index);

                if (skuNumber.Equals(validatingProduct))
                {
                    break;
                }
            }
            return index;
        }

        #endregion

        #region Change line item shipping method by option index

        public static void ChangeLineItemShippingMethodByOptionIndex(IWebDriver webDriver, int lineItemIndex, int optionIndex)
        {
            webDriver.PickDropdownByIndex(By.Id(string.Format("quoteCreate_LI_SI_shippingMethod_{0}", lineItemIndex)), optionIndex);
        }

        #endregion

        #region Save quote and generate new quote number

        public static void SaveQuoteAndGenereateNewQuoteNumber(IWebDriver driver)
        {
            new CreateQuotePage(driver).SaveQuote();
            new CreateQuotePage(driver).ClickOnVersionRadioBtn();
            new CreateQuotePage(driver).ClickOnQuoteVersionNext();
        }

        #endregion

        #region Get list of all line item quote data

        public static List<ItemQuoteData> GetListOfAllLineItemQuoteData(IWebDriver testWebDriver, int totalLineItemCount)
        {
            var lobQuoteDataList = new List<ItemQuoteData>();

            for (var index = 1; index <= totalLineItemCount; index++)
            {
                var lobQuoteData = CollectDataFromLineItem(testWebDriver, index, SplitLineValidation.SplitLineItemOriginal);
                lobQuoteDataList.Add(lobQuoteData);
            }
            return lobQuoteDataList;
        }

        #endregion

        #region Update line item data

        public static void UpdateLineItemData(IWebDriver driver, int lineItemCount)
        {

            var quoteitemsDataList = GetListOfAllLineItemQuoteData(driver, lineItemCount);

            for (var index = 0; index < lineItemCount; index++)
            {
                double updatedSellingPrice = double.Parse(quoteitemsDataList[index].SellingPrice) - QuoteCreatePageConstants.DoubleTen;
                string updatedQuantity = (quoteitemsDataList[index].Quantity + QuoteCreatePageConstants.Int32Seven).ToString();
                string updatedDiscount = (quoteitemsDataList[index].Discount + QuoteCreatePageConstants.DoubleTen).ToString();

                new CreateQuotePage(driver).UpdateItemLevelUnitSellingPrice(index + 1,1, updatedSellingPrice);
                new CreateQuotePage(driver).UpdateQuantity(index + 1, updatedQuantity);
                if (!new CreateQuotePage(driver).IsPromotionsDisplayed())
                    new CreateQuotePage(driver).UpdateDiscountOffList(index + 1, updatedDiscount);

            }

        }

        #endregion

        #region Click line item configuration by index

        public static ProductConfigurePage ClickLineItemConfigureByIndex(IWebDriver driver, int index)
        {
            driver.ScrollAndClickByIndex(By.Id("quoteCreate_LI_configItem"), index);


            return new ProductConfigurePage(driver);
        }

        #endregion

        #region Verify configuration has tied skus

        public static bool VerifyConfigurationHasTiedSkus(IWebDriver driver, string sku1, string sku2)
        {
            new CreateQuotePage(driver).ClickShowMoreAtIndex(1);
            new CreateQuotePage(driver).ClickExpandAllConfigurationButton();
            int totalConfigs = new CreateQuotePage(driver).GetTotalNumberOfConfigurations();
            if (new CreateQuotePage(driver).GetConfigurationTextAtId(totalConfigs - 2).Contains(sku1) ||
                new CreateQuotePage(driver).GetConfigurationTextAtId(totalConfigs - 1).Contains(sku1) ||
                new CreateQuotePage(driver).GetConfigurationTextAtId(totalConfigs - 2).Contains(sku2) ||
                new CreateQuotePage(driver).GetConfigurationTextAtId(totalConfigs - 1).Contains(sku2))
                return true;
            return false;
        }

        #endregion

        #region Click save Quote

        public static void ClickSaveQuote(IWebDriver driver)
        {
            new CreateQuotePage(driver).SaveQuote();
        }

        #endregion

        #region Click Save All Linked Quotes 

        public static void ClickSaveAllLinkedQuotes(IWebDriver driver)
        {
            new CreateQuotePage(driver).SaveAllLinkedQuotesButton.Click(driver);
            new QuoteDetailsPage(driver).WaitForQuoteValidationToComplete();
        }

        #endregion

        #region Verify Quote number created
        public static bool VerifyQuoteNumberCreated(IWebDriver driver)
        {
            return string.IsNullOrWhiteSpace(new CreateQuotePage(driver).GetQuoteNumber());
        }

        #endregion

        #region Patch Customer
        public static void PatchCustomer(IWebDriver driver, string customerNumber)
        {
            var createQuotePage = new CreateQuotePage(driver);
            createQuotePage.EnterCustomerNumber(customerNumber);
        }

        #endregion

        #region Get Customer Credit Balance
        public static decimal GetRemainingCreditWithThresholdFromFinancialApi(string customerNumber, string businessUnit, string companyNumber)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                var url = string.Format(
                    @"http://ausvmpocaiaap01.us.dell.com:8080/CreditRSService/api/FinancialAttrService/{0}/{1}/{2}/GCM",
                    customerNumber, businessUnit, companyNumber);

                var response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    var content = responseContent.ReadAsStringAsync().Result;

                    var deserializedContents = JsonConvert.DeserializeObject<dynamic>(content);

                    return Math.Round(decimal.Parse(deserializedContents.REMAINING_CREDIT_WITH_THRESHOLD.ToString()), 2);

                }

                throw new Exception("Could not parse the value");
            }
        }

        #endregion

        #region Change BillTo Customer
        public static CreateQuotePage ChangeBillToCustomer(IWebDriver driver, string customerNumber)
        {
            var createQuotePage = new CreateQuotePage(driver);
            createQuotePage.LnkChangeCustomer.Click(driver);
            createQuotePage.BtnChangeCustomerConfirm.Click(driver);
            PatchCustomer(driver, customerNumber);
            createQuotePage.WaitForQuoteValidationToComplete();
            return new CreateQuotePage(driver);
        }
        #endregion

        #region Add Items to Shipping Group
        public static void AddItemsToShippingGroup(IWebDriver driver, Dictionary<string, ProductSearchType> products, int groupIndex)
        {
            new CreateQuotePage(driver).AddItemsFromSearch(groupIndex);

            foreach (KeyValuePair<string, ProductSearchType> item in products)
            {
                if (item.Value == ProductSearchType.OrderCode)
                    new ProductSearchPage(driver).SearchByOrderCode(item.Key);
                else if (item.Value == ProductSearchType.SkuId)
                    new ProductSearchPage(driver).SearchBySkuId(item.Key);

                //int itemCount = new ProductSearchResultsPage(driver).GetItemCountFromMastHead();
                new ProductSearchResultsPage(driver).AddItemToCart();
                new ProductSearchResultsPage(driver).BackToSearchClick();
            }

            new ProductSearchPage(driver).GoToCurrentQuotePage();
        }
        #endregion

        # region  Sell To Value - Margin Visibility





        public static bool ValidateTotalMarginQuoteSummary(bool ViewMarginRight, string summaryTotalMargin)
        {
            bool result = true;
            if (ViewMarginRight)
            {
                if (string.IsNullOrEmpty(summaryTotalMargin) || !summaryTotalMargin.Any(c => char.IsDigit(c)))
                {
                    result = false;
                    return result;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(summaryTotalMargin))
                {
                    result = false;
                    return result;
                }
            }

            return result;


        }

        public static bool VerifyMarginVisibility_ProductConfigurePage(IWebDriver TestWebDriver, string OrderCodesWithBrandIDFlag, bool ViewMarginRight)
        {
            bool result = true;
            foreach (var item in OrderCodesWithBrandIDFlag.Split('|'))
            {
                var marginDetailsFromConfigurePage = new ProductConfigurePage(TestWebDriver).GetMarginAndUnitMarginFromProductConfigurePage(TestWebDriver, item.Split(';')[2], item.Split(';')[3]);

                if (ViewMarginRight == true || Convert.ToBoolean(item.Split(';')[1]) == true)
                {
                    //if (marginDetailsFromConfigurePage.MarginForSelectedItem.Contains("-") || marginDetailsFromConfigurePage.UnitMarginForSelectedItem.Contains("-"))
                    if (string.IsNullOrEmpty(marginDetailsFromConfigurePage.MarginForSelectedItem) || string.IsNullOrEmpty(marginDetailsFromConfigurePage.UnitMarginForSelectedItem))
                    {
                        result = false;
                        Logger.Write(string.Format("Item not found on quote creation page {0}", item.Split(';')[2]));
                    }

                    if (!marginDetailsFromConfigurePage.MarginForSelectedItem.Any(c => char.IsDigit(c)) || !marginDetailsFromConfigurePage.UnitMarginForSelectedItem.Any(c => char.IsDigit(c)))
                    {
                        result = false;
                        Logger.Write(string.Format("Margin for item {0} {1} does not contain any digits", item.Split(';')[0], item.Split(';')[1]));
                    }

                    if (marginDetailsFromConfigurePage.MarginForSelectedItem.Contains("-"))
                    {
                        result = false;
                        Logger.Write(string.Format("Margin for item {0} {1} is not in right format, contains -", item.Split(';')[0], item.Split(';')[1]));
                    }

                    if (item.Split(';')[3] != "null")
                    {
                        if (marginDetailsFromConfigurePage.ConfigOptionLevelMargin.Contains("-") || marginDetailsFromConfigurePage.ConfigOptionLevelMargin_AfterUpdates.Contains("-"))
                        {
                            result = false;
                            Logger.Write(string.Format("Configure option margin is not in right format for item {0} {1}", item.Split(';')[0], item.Split(';')[1]));


                            if (!marginDetailsFromConfigurePage.ConfigOptionLevelMargin.Any(c => char.IsDigit(c)) || !marginDetailsFromConfigurePage.ConfigOptionLevelMargin_AfterUpdates.Any(c => char.IsDigit(c)))
                            {
                                result = false;
                                Logger.Write(string.Format("Configur option Margin for item {0} {1} does not contain any digits", item.Split(';')[0], item.Split(';')[1]));
                            }
                        }
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(marginDetailsFromConfigurePage.MarginForSelectedItem) || string.IsNullOrEmpty(marginDetailsFromConfigurePage.UnitMarginForSelectedItem))
                    {
                        result = false;
                        Logger.Write(string.Format("Item not found on quote creation page {0}", item.Split(';')[2]));
                    }


                    if (!marginDetailsFromConfigurePage.MarginForSelectedItem.Contains("-") || !marginDetailsFromConfigurePage.UnitMarginForSelectedItem.Contains("-"))
                    {
                        result = false;
                    }


                    if (marginDetailsFromConfigurePage.MarginForSelectedItem.Any(c => char.IsDigit(c)) || marginDetailsFromConfigurePage.UnitMarginForSelectedItem.Any(c => char.IsDigit(c)))
                    {
                        result = false;
                        Logger.Write(string.Format("Margin for item {0} {1} does contain some digits", item.Split(';')[0], item.Split(';')[1]));
                    }

                    if (item.Split(';')[2] != "null")
                    {
                        if (!marginDetailsFromConfigurePage.ConfigOptionLevelMargin.Contains("-") || !marginDetailsFromConfigurePage.ConfigOptionLevelMargin_AfterUpdates.Contains("-"))
                        {
                            result = false;
                        }
                    }
                }
            }

            return result;
        }

          #endregion

        #region Move Item to Shipping Group
        public static void MoveItemToShippingGroup(IWebDriver driver, int shippingGroupIndex, int productIndex, int destinationShippingGroupNumber)
        {
            new CreateQuotePage(driver).MoveItem(shippingGroupIndex, productIndex).Click(driver);
            new CreateQuotePage(driver).AvailableDestinationGroup(destinationShippingGroupNumber).Click(driver);
            new CreateQuotePage(driver).btnSelectDestinationGroupMoveItem.Click(driver);
            //driver.WaitForBusyOverlay();
        }
        #endregion

        #region Copy Shipping Group
        public static void CopyShippingGroup(IWebDriver driver,int groupIndex, int numberOfCopies, string selectItems)
        {
            CreateQuotePage createQuotePage = new CreateQuotePage(driver);
            createQuotePage.CopyGroup(groupIndex).Click();
            createQuotePage.QuantityText.SetText(driver, numberOfCopies.ToString());
            createQuotePage.SelectAll_Link.Click();
            if (!selectItems.Equals("SelectAll"))
            {
                createQuotePage.CopyShippingGroupSelectItem().Click();
            }
            createQuotePage.SaveChanges.Click(driver);
        }
        #endregion

        # region Work Flow for Recomended Items at Configure Page
        public static ProductConfigurePage RecommendedItemsAtConfigurePage(IWebDriver driver)
        {
            driver.WaitForPageLoad(TimeSpan.FromSeconds(40));
           var ProductConfigurePage= new ProductConfigurePage(driver);
            for (int i = 1; i <= 3; i++)
            {
                string FirstRecommendedItemXpath = string.Format(ProductConfigurePage.FirstRecommendedItemsTabXpath(i));
                driver.FindElement(By.XPath(FirstRecommendedItemXpath)).WaitForElement(driver);
                driver.FindElement(By.XPath(FirstRecommendedItemXpath)).Displayed.Should().BeTrue();
                string FirstRecommendedItem = driver.FindElement(By.XPath(FirstRecommendedItemXpath)).GetText(driver);
                Logger.Write("First Set of Recommended Items" + FirstRecommendedItem);
            }

            return new ProductConfigurePage(driver);      
        }


        #endregion

        #region Validate Items

        public static void ValidateOrderAndSku(IWebDriver driver, Dictionary<string, ProductSearchType> products, int shippingIndex = 1)
        {
            int itemIndex = 1;
            bool allitemsFound = true;
            driver.WaitForBusyOverlay();
            for (int i = 0; i < products.Count; i++)
            {
                new CreateQuotePage(driver).LnkViewMore(shippingIndex, itemIndex).Click(driver);
                if (new CreateQuotePage(driver).LblProductTypeUnderViewMore(shippingIndex, itemIndex).GetText(driver).ToLower()
                    .Contains("order code"))
                {
                    string orderorskuvalue = new CreateQuotePage(driver)
                        .LblOrderCodeUnderViewMore(shippingIndex, itemIndex).GetText(driver).Trim();

                    if (!products.ContainsKey(orderorskuvalue.ToLower().Trim()))
                    {
                        allitemsFound = false;
                        break;
                    }
                }
                else
                {
                    string orderorskuvalue = new CreateQuotePage(driver)
                        .LblSkuUnderViewMore(shippingIndex, itemIndex).GetText(driver).Trim();

                    if (!products.ContainsKey(orderorskuvalue.ToLower().Trim()))
                    {
                        allitemsFound = false;
                        break;
                    }
                }

                new CreateQuotePage(driver).LnkViewMore(shippingIndex, itemIndex).Click(driver);
                itemIndex += 1;
            }

            allitemsFound.Should().BeTrue();
        }

        public static void ValidateNonTiedItem(IWebDriver driver, string selectedNontiedItemPrice,
            int shippingIndex = 1, int itemIndex = 1)
        {
            bool nonTiedItemFound = true;
            string nontiedItemPrice = new CreateQuotePage(driver)
                .LblNonTiedListPrice(shippingIndex, itemIndex).GetText(driver).Trim();
            if (nontiedItemPrice.Trim() != selectedNontiedItemPrice.Trim())
            {
                nonTiedItemFound = false;
            }
            nonTiedItemFound.Should().BeTrue();
        }
        
        #endregion

    }
}
