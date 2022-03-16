using System.Collections.Generic;
using System.Text.RegularExpressions;
using Dsa.Constants;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace Dsa.Pages.Product
{
    public class ProductSearchResultsPage : DsaPageBase
    {
        public ProductSearchResultsPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region -- Elements -- 
        

public IWebElement ItemsPerPage { get { return WebDriver.GetElement(By.Id("grid_paging_itemsPerPage")); } }


public IWebElement CustomerSearchTermLink { get { return WebDriver.GetElement(By.Id("customer_searchTerm_link")); } }

        public IWebElement ProductTabSearchLink { get { return WebDriver.GetElement(By.Id("products_tab_search")); } }


        public IWebElement SmartSelection { get { return WebDriver.GetElement(By.Id("productResult_refinement_1")); } }


public IWebElement lbl_ShowSmartSelectionOnly { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'Show Smart Selections Only')]")); } }


public IWebElement chk_ShowSmartSelectionOnly { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'Show Smart Selections Only')]/input")); } }


public IWebElement BuildToOrderChkBoxChk { get { return WebDriver.GetElement(By.Id("productResult_refinement_2")); } }

        //[FindsBy(How = How.CssSelector, Using = "span.search-term-pill > a")]
        //public IWebElement BackToSearchLink;
        public IWebElement BackToSearchLink { get { return WebDriver.GetElement(By.CssSelector("span.search-term-pill > a")); } }


public IWebElement CustomerSearchSaveLink { get { return WebDriver.GetElement(By.Id("customer_searchSave_link")); } }


public IWebElement CustomerSearchEditLink { get { return WebDriver.GetElement(By.Id("customer_searchEdit_link")); } }

        //[FindsBy(How = How.Id, Using = "productResult_grid_add")]
        //public IWebElement AddProduct;
        public IWebElement AddProduct { get { return WebDriver.GetElement(By.Id("productResult_grid_add")); } }

        //[FindsBy(How = How.XPath, Using = "//a[normalize-space()='Add']")]

public IWebElement ResultsInformationText { get { return WebDriver.GetElement(By.XPath("//div[@class='resultsHeadder']/span")); } }
        
        //[FindsBy(How = How.XPath, Using = "//a[normalize-space()='Add Config']")]
        //[FindsBy(How = How.Id, Using = "productResult_grid_addConfigure")]
        //public IWebElement AddConfig;
        public IWebElement AddConfig { get { return WebDriver.GetElement(By.Id("productResult_grid_addConfigure")); } }

        //[FindsBy(How = How.Id, Using = "productResult_grid_addAnother")]
        //public IWebElement AddAnother;
        public IWebElement AddAnother { get { return WebDriver.GetElement(By.Id("productResult_grid_addAnother")); } }


public IWebElement ConfigureProduct { get { return WebDriver.GetElement(By.Id("productResult_grid_configure")); } }


public IWebElement ConfigureButton { get { return WebDriver.GetElement(By.Id("products_configure")); } }


public IWebElement ProductListId { get { return WebDriver.GetElement(By.Id("productResult_paneList")); } }


public IWebElement ProductNameListViewId { get { return WebDriver.GetElement(By.Id("productResult_paneList-0-")); } }


        //public IWebElement BtnViewQuote { get { return WebDriver.GetElement(By.Id("_viewquote")); } }
        public IWebElement BtnViewQuote { get { return WebDriver.GetElement(By.XPath("//*[text()='View Quote']")); } }
        //[FindsBy(How = How.XPath, Using = "//*[@id='body-content']/div[2]/div/div[2]/div[1]/div[1]/div/div/ul/li[1]/a")]

        public IWebElement SearchTab { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='Search']")); } }


public IWebElement NextProductTab { get { return WebDriver.GetElement(By.XPath("//div[@id='body-content']/div[2]/div/div[2]/div/div/div/div[2]/div/ul/li[2]/a")); } }


public IWebElement ProductresultsTbl { get { return WebDriver.GetElement(By.Id("DataTables_Table_1")); } }


public IWebElement ItemsMenu { get { return WebDriver.GetElement(By.Id("menu_productItems1")); } }


public IWebElement GridViewLnk { get { return WebDriver.GetElement(By.Id("productResult_GridViewLink")); } }


public IWebElement GridViewAddtn { get { return WebDriver.GetElement(By.Id("productResult_grid_add")); } }


public IWebElement BtnGridViewAddAnother { get { return WebDriver.GetElement(By.Id("productResult_grid_addAnother")); } }

        //[FindsBy(How = How.Id, Using = @"menu_productItems1")]
        //public IWebElement LblItemCountMastHead;
        public IWebElement LblItemCountMastHead { get { return WebDriver.GetElement(By.Id("menu_productItems1")); } }


public IWebElement BtnProductItemToggle { get { return WebDriver.GetElement(By.Id("menu_productItems_toggle1")); } }

        //[FindsBy(How = How.CssSelector, Using = "#COM > div.modal-small.ng-scope > div")]

public IWebElement ErrorPopup { get { return WebDriver.GetElement(By.XPath("//*[@class='cdk-overlay-pane dsa-modal-small']")); } }


public IWebElement BtnConfigureItems { get { return WebDriver.GetElement(By.Id("mastHead_configItems")); } }


public IWebElement LineItemMoreInformation { get { return WebDriver.GetElement(By.XPath(".//*[@id='main']/div/div/div/div[4]/div[4]/div/div/div[2]/div[4]/tabset/div/div/div[2]/div[2]/div/div/div/div[2]")); } }


public IWebElement ChkCfiAdminOverride { get { return WebDriver.GetElement(By.Id("cfs-admin-override")); } }

        public IWebElement LblAdd { get { return WebDriver.GetElement(By.Id("productResult_list_add")); } }

        //[FindsBy(How = How.XPath, Using = "//div[@id='ProductSearch_CartItemSelectGrid']/div/table/tbody/tr/td[1]/input")]
        //public IWebElement ChkTiedtoBuild;


public IWebElement ChkTiedtoBuild { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_ProductSearch_CartItemSelectGrid']/thead/tr/th[1]/input")); } }


public IWebElement BtnOkCartItems { get { return WebDriver.GetElement(By.XPath("//div[@class='btn-bar']/button[@id='cartItems_OkButton']")); } }
        //[FindsBy(How = How.XPath, Using = "//*[@id='DataTables_Table_ProductSearch_CartItemSelectGrid']/thead/tr/th[1]/input")]
        //public IWebElement BtnOkCartItems;


public IWebElement BtnSuccessAddSku { get { return WebDriver.GetElement(By.XPath(".//div[@class='btn-bar']/button")); } }


public IWebElement okMsgDialogButton { get { return WebDriver.GetElement(By.Id("messageDialogButton_0")); } }


public IWebElement okMsgDialogButton_ErrorAddingItem { get { return WebDriver.GetElement(By.Id("mat-dialog-0")); } }


public IWebElement messageOnAlert_ErrorAddingItem { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Sorry, there was a problem adding this item to your cart. Please try again or report this problem.')]")); } }


public IWebElement AddFromTechSpec { get { return WebDriver.GetElement(By.Id("productDetail_AddToQuote")); } }


public IWebElement SelectaCategory { get { return WebDriver.GetElement(By.XPath("//h3[@class='section-header header-padding']")); } }


public IWebElement FilterResultsBy { get { return WebDriver.GetElement(By.XPath("//h3[@class='section-header header-padding ng-star-inserted']")); } }


public IWebElement CategoryRefinerTree { get { return WebDriver.GetElement(By.XPath("//div[@name='form_category_filter']")); } }


public IWebElement AnavRefiner { get { return WebDriver.GetElement(By.XPath("//div[@name='form_checkboxList']")); } }


public IWebElement TaaValueInTileView { get { return WebDriver.GetElement(By.Id("productResultValue_TAA")); } }

public IWebElement SearchResultCategorySelection { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='Desktops & Workstations']")); } }

public IWebElement ResultsInformationEndText { get { return WebDriver.GetElement(By.XPath("//span[@class = 'h5 ng-star-inserted']")); } }
public IWebElement SearchResultListPriceValue { get { return WebDriver.GetElement(By.XPath("//*//table[@id='DataTables_Table_productResult_paneList']/tbody[1]/tr/td[5]")); } }
public IWebElement ItemSearchResultNotFound { get { return WebDriver.GetElement(By.XPath("//table[@id='DataTables_Table_productResult_paneList']//td[contains(text(),'No items in list.')]")); } }
public IWebElement removeicon_searchresult { get { return WebDriver.GetElement(By.Id("RemoveItem_OrderOrSkuSearch_Link")); } }

public IWebElement CSProjectHeader { get { return WebDriver.GetElement(By.XPath("//h3[contains(text(),'CS Project Search Result')]")); } }
public IWebElement lblCSAdminOverride { get { return WebDriver.GetElement(By.XPath("//*[@id='cfs-admin-override']/following-sibling::label")); } }
public IWebElement lblProjectID { get { return WebDriver.GetElement(By.XPath("//div[@id='DataTables_div_productCfsProjectResult_paneList']//th[2]/span")); } }


        #endregion


        public bool VerifySearchBusyOverlayNotDisplayed()
        {
            try
            {
                bool elestatus;
                for (int i = 1; i <= 5; i++)
                {
                    do
                    {
                        var wait = new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime);
                        elestatus = wait.Until<bool>(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//inline-busy")));
                        //i++;
                    } while (elestatus == false);

                }
            }
            catch (Exception ex)
            {
                Logger.Write("exception :" + ex.Message);
            }
            return true;
        }
        public ProductSearchResultsPage AddItemToCart(int index = 0,bool SnPasConfig = false)
        {
            //AddProduct.WaitForElement(WebDriver);
            int itemCount = new ProductSearchResultsPage(WebDriver).GetItemCountFromMastHead();
            if(SnPasConfig)
            {
                AddConfig.Click(WebDriver);
                DsaUtil.WaitUntilTextChanges(new ProductSearchResultsPage(WebDriver).LblItemCountMastHead, WebDriver, (itemCount + 1).ToString());
            }
            else
            {

                try
                {
                    if (AddProduct.IsElementDisplayed(WebDriver, TimeSpan.FromMilliseconds(10)))
                        AddProduct.Click(WebDriver);
                    else if (AddAnother.IsElementDisplayed(WebDriver, TimeSpan.FromMilliseconds(10)))
                        AddAnother.Click(WebDriver);
                }
                
                catch(Exception e)
                {
                    Logger.Write("Unable to add item in Product Search Result page: " + e.ToString());
                }

               // WebDriver.WaitForAddItemToAppearAndDissapear();
                //AddProduct.Click(WebDriver);
                //DsaUtil.WaitUntilTextChanges(new ProductSearchResultsPage(WebDriver).LblItemCountMastHead, WebDriver, (itemCount + 1).ToString());

            }

            
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return this;
        }

        public ProductSearchResultsPage ClickProductItemToggle()
        {
            BtnProductItemToggle.Click(WebDriver);
            return this;
        }

        public void ClickViewQuote()
        {
            WebDriver.WaitForBusyOverlay();
            BtnViewQuote.Click(WebDriver);
        }

        public string RecommendedItemsConfigurePageXpath()
        {
          string RecommendedItemsConfigurePageXpath = string.Format(".//*[@id='main']/div/div/div/div[4]/div[4]/div/div/div[2]/div[4]/tabset/div/div/div[2]/div[2]/div/div/div/div[1]/div[3]/div/div/div[{0}]/div/div[2]/a/h5");
          return RecommendedItemsConfigurePageXpath;
        }
        public ProductConfigurePage ClickProductListConfiguration()
        {
            ConfigureProduct.Click(WebDriver);
            return new ProductConfigurePage(WebDriver);
        }

        public ProductConfigurePage ClickConfigureItems()
        {
            BtnConfigureItems.Click(WebDriver);
            return new ProductConfigurePage(WebDriver);
        }
        public ProductSearchPage BackToSearchClick()
        {
            BackToSearchLink.Click(WebDriver);
            return new ProductSearchPage(WebDriver);
        }

        public List<Dictionary<string, object>> GetProductResultsGridRecords()
        {
            VerifySearchBusyOverlayNotDisplayed();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return WebDriver.GetHtmlTableData(By.Id(ProductIDs.ProductListId));
        }

        public List<Dictionary<string,object>> GetproductCfsProjectResultGridRecords()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return WebDriver.GetHtmlTableData(By.Id(ProductIDs.ProductCFIListId));
        }

        public int GetItemCountFromMastHead()
        {
            string text = LblItemCountMastHead.GetText(WebDriver);
            return int.Parse(Regex.Match(text, @"\d+").Value);
        }

        public void ChkCFIAdminOverride()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            ChkCfiAdminOverride.Click(WebDriver);
        }

        public void CheckTiedtoBuild()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            ChkTiedtoBuild.Click(WebDriver);
        }

        public void ClickbtnOkCartItems()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            BtnOkCartItems.Click(WebDriver);
        }

        public void ClickbtnSuccessAddSku()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            BtnSuccessAddSku.Click(WebDriver);
        }//
       

        public string ReadAddSKUToBuildMessage()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return 
                WebDriver.FindElement(By.XPath("//div[@class='input-value']//div[@class='col-xs-12 input-label']")).Text;
        }

        public void AddProductFromTabs(IWebDriver driver)
        {
            //To add product from first tab
           // AddFirstAvailableProductFromResults(driver);
            IList<IWebElement> ProductTabs = driver.GetElements(By.XPath("//ul[@class='nav nav-tabs']//li/a"));
						ProductTabs.RemoveAt(0);
                        ProductTabs.RemoveAt(0);
            foreach (IWebElement element in ProductTabs)
            {
                element.Click();
                driver.VerifyBusyOverlayNotDisplayed();
                //IWebElement parentElement = element.FindElement(By.XPath("//parent::li[@class='active']"));
                //string activeClass = parentElement.GetAttribute("class");
                //if (activeClass!="active")
                // if(ProductTabs.IndexOf(element)!=0)
                AddFirstAvailableProductFromResults(driver);
            }
        }

        //Raja ReviewRaja


        public bool handleCannotAddItemErrorAlertPresent(IWebDriver driver)
        {
            bool alertPresent = false;

            if (driver.TryFindElement(messageOnAlert_ErrorAddingItem))
            {
                driver.FindElement(By.Id("_btn_ok")).Click(WebDriver);
                driver.VerifyBusyOverlayNotDisplayed();
                alertPresent = true;
            }

            return alertPresent;
        }

        public bool isShowSmartSelectionOnlyPresent(IWebDriver driver)
        {
            bool alertPresent = false;

            if (driver.TryFindElement(lbl_ShowSmartSelectionOnly))
            {
                alertPresent = true;
            }

            return alertPresent;
        }

        public void chkShowSmartSelectionOnly(IWebDriver driver)
        {
            
            if (isShowSmartSelectionOnlyPresent(driver))
            {
                chk_ShowSmartSelectionOnly.Click();
            }

           
        }

        public bool clickAdd(int index, IWebDriver driver)
        {
            var divElement = driver.GetElement(By.Id(ProductIDs.ProductListId));
            var tableElement = divElement.FindElement(By.CssSelector("table"));
            var addButtons = tableElement.FindElements(By.XPath("//a[@id='productResult_grid_add']"));
            bool addClickSuccess = false;

            addButtons[index].Click();

            if (AddAnother.IsElementDisplayed(driver)){
                addClickSuccess = false;
            }
            else { 
                addClickSuccess = handleCannotAddItemErrorAlertPresent(driver);
            }
            return !addClickSuccess;
        }

        //Raja ReviewRaja
        public void AddFirstAvailableProductFromResults(IWebDriver driver)
        {
            var divElement = driver.GetElement(By.Id(ProductIDs.ProductListId));
            var tableElement = divElement.FindElement(By.CssSelector("table"));
			var addButtons = tableElement.FindElements(By.XPath("//a[@id='productResult_grid_add']"));
            bool addNext = false;
            bool add = false;
            bool addClickSuccess = false;
            //Get items count from cart
            var itemCount = GetItemCountFromMastHead();

            int totalButtons = addButtons.Count;


            //int tempR = 2;
            //if (tempR == 2)
            //{
                for (int i = 0; i < totalButtons; i++)
                {
                    //final

                    int max=5;
                    if (totalButtons <= max)
                    {
                        max = totalButtons;
                    }

                    addClickSuccess = clickAdd(i, driver);

                    if (addClickSuccess == false)
                    {
                        while (i < max)
                        {
                            addClickSuccess = !clickAdd(++i, driver);
                            //if (addClickSuccess == true)
                            if (addClickSuccess == false)
                            {
                            driver.VerifyBusyOverlayNotDisplayed();
                            var newItemCount = GetItemCountFromMastHead();
                            if (newItemCount == itemCount)
                            {
                                //if (driver.TryFindElement(okMsgDialogButton))
                                //  okMsgDialogButton.Click();
                            }
                            driver.VerifyBusyOverlayNotDisplayed();

                            if (newItemCount > itemCount)
                            {
                                addNext = true;
                                itemCount = newItemCount;
                                
                            }
                            break;
                            }
                            else { }
                                
                        }


                    }
                    else { }
                    if(addClickSuccess == false)
                    {

                    }
                    else
                    {
                        driver.VerifyBusyOverlayNotDisplayed();
                        var newItemCount = GetItemCountFromMastHead();
                        if (newItemCount == itemCount)
                        {
                            //if (driver.TryFindElement(okMsgDialogButton))
                            //  okMsgDialogButton.Click();
                        }
                        driver.VerifyBusyOverlayNotDisplayed();

                        if (newItemCount > itemCount)
                        {
                            add = true;
                            itemCount = newItemCount;
                            break;
                        }

                        if (!add)
                            continue;
                    }

                if (addNext)
                    break;
            }
            //}

        }

        public void AddFirstAvailableProductFromResults_old(IWebDriver driver)
        {
            var divElement = driver.GetElement(By.Id(ProductIDs.ProductListId));
            var tableElement = divElement.FindElement(By.CssSelector("table"));

            //var tableRows = tableElement.FindElements(By.CssSelector("tbody > tr"));
            var tableRows = tableElement.FindElements(By.XPath("//a[@id='productResult_grid_add']"));
            bool add = false;
            //Get items count from cart
            var itemCount = GetItemCountFromMastHead();
            //IWebElement addbtn;
            foreach (var row in tableRows)
            {
                //addbtn = row.FindElement(By.XPath("//a[@id='productResult_list_add']"));
                row.Click();
                //addbtn.Click();
                driver.VerifyBusyOverlayNotDisplayed();
                var newItemCount = GetItemCountFromMastHead();
                //if item is not added , handle the popup
                if (newItemCount == itemCount)
                {
                    if (driver.TryFindElement(okMsgDialogButton))
                        okMsgDialogButton.Click();
                }
                driver.VerifyBusyOverlayNotDisplayed();

                if (newItemCount > itemCount)
                {
                    add = true;
                    itemCount = newItemCount;
                    break;
                }

                if (!add)
                    continue;

            }
            // driverByLblSummaryTotalTaxBy.XPath("//*[@id='customer_searchTerm_link']/following-sibling::a"));
        }

        public string GetErrorMesssageInModal()
        {
            string message = string.Empty;
            WebDriver.VerifyBusyOverlayNotDisplayed();
            if(WebDriver.TryFindElement(ErrorPopup,System.TimeSpan.FromSeconds(5)))
            {
                message = ErrorPopup.FindElement(By.TagName("mat-dialog-content")).Text;
            }
            return message;
        }

        public string GetResultsInformation()
        {
            string resultsInfo = string.Empty;
            WebDriver.VerifyBusyOverlayNotDisplayed();
            if (WebDriver.TryFindElement(ResultsInformationText))
            {
                resultsInfo = ResultsInformationText.Text;
            }
            return resultsInfo;
        }

        public int getProductSearchResultCount()
        {
            int count = 0;

            String resultMsg = GetResultsInformation();
            int indexOfFirstSpaceInResultsMessage = resultMsg.IndexOf(' ');
            count = Convert.ToInt32(resultMsg.Substring(0, indexOfFirstSpaceInResultsMessage));
            return count;
        }
        public void SearchByOrderCode(string v)
        {
            throw new NotImplementedException();
        }
        //Sv
        public IWebElement TypeinTechspecs
        {
            get
            {
                return WebDriver.GetElement(By.XPath("//*[@id='productDetail_ConfigurationType']"));
            }
        }
        public IWebElement LnkClose { get { return WebDriver.GetElement(By.XPath("//button[@class='btn btn-default btn-xs']")); } }


    }
}
