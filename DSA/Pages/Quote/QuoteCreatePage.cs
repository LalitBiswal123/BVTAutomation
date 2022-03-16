using System;
using System.Globalization;
using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using Dsa.Constants;
using Dsa.Enums;
using Dsa.Util;
using OpenQA.Selenium;

namespace Dsa.Pages
{
    public class QuoteCreatePage : DsaPageBase
    {
        public QuoteCreatePage(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "CreateQuote";
        }

        #region Elements

        private readonly By _accountCustomerName = By.Id(QuoteIDs.AccountCustomerId);
        private readonly By _customerNumberTxt = By.Id(QuoteCreatePageConstants.CustomerNumberTxt);
        private readonly By _changeCustomerLnk = By.Id(QuoteCreatePageConstants.ChangeCustomerLnk);
        private readonly By _quoteNameTxt = By.Id(QuoteCreatePageConstants.QuoteNameTxt);
        private readonly By _quoteCreateVersionRb = By.Id(QuoteCreatePageConstants.QuoteCreateVersionRb);
        private readonly By _defaultShippingAddress = By.Id(QuoteCreatePageConstants.DefaultShippingAddress);
        private readonly By _totalItemsTxt = By.Id(QuoteCreatePageConstants.MenuProductItemsTxt);
        private readonly By _configureLnk = By.Id(QuoteCreatePageConstants.ConfigureLnk);
        private readonly By _quoteCreateLineItems = By.XPath(QuoteCreatePageConstants.QuoteCreateLineItemsCount);
        private readonly By _addItemBtn = By.Id(QuoteCreatePageConstants.AddItemBtn);
        private readonly By _quoteVersionNextBtn = By.Id(QuoteCreatePageConstants.QuoteVersionNextBtn);
        private readonly By _saveQuoteBtn = By.Id(QuoteCreatePageConstants.SaveQuoteBtn);
        private readonly By _customerId = By.Id(QuoteCreatePageConstants.CustomerId);
        private readonly By _customerInformationToggle = By.Id(QuoteCreatePageConstants.CustomerInformationToggle);
        private readonly By _companyNumber = By.Id(QuoteCreatePageConstants.CompanyNumber);
        private readonly By _finalPriceLbl = By.Id(QuoteCreatePageConstants.FinalPriceLbl);
        private readonly By _ecoFeeLbl = By.Id(QuoteCreatePageConstants.EcoFeeLbl);
        private readonly By _totalTaxAmountLbl = By.Id(QuoteCreatePageConstants.TotalTaxAmountLbl);
        private readonly By _shippingAmountLbl = By.Id(QuoteCreatePageConstants.ShippingAmountLbl);
        private readonly By _subtotalAmountLbl = By.Id(QuoteCreatePageConstants.SubtotalAmountLbl);
        private readonly By _listPriceLbl = By.Id(QuoteCreatePageConstants.ListPriceLbl);
        private readonly By _byShowMoreForEachItem = By.CssSelector(QuoteIDs.ShowMoreForEachItem);
        
        public QuoteCreatePage SelectCatalog(Catalogs catalog)
        {
            var selectCatalog = new SelectCatalogDialog(WebDriver);
            selectCatalog.SelectCatalog(catalog);

            return this;
        }
        
        public string DefaultShippingAddress
        {
            get
            {
                Console.WriteLine(WebDriver.GetElement(_defaultShippingAddress).Text);
                return WebDriver.GetElement(_defaultShippingAddress).Text;
            }
        }
        public string AccountCustomerName
        {
            get { return WebDriver.GetText(_accountCustomerName).Trim(); }
        }
        public string GetAccountNameAfterCustomerLoaded()
        {
            return AccountCustomerName.Substring(0, AccountCustomerName.IndexOf(':')).Trim();
        }
        public string GetCustomerNameAfterCustomerLoaded()
        {
            WebDriver.WaitForElementVisible(_accountCustomerName, TimeSpan.FromSeconds(30));
            Console.WriteLine(AccountCustomerName);
            return AccountCustomerName.Substring(AccountCustomerName.IndexOf(':') + 1).Trim();
        }

        public string GetCompanyNumber()
        {
            return
                WebDriver.FindElement(_accountCustomerName)
                    .FindElement(By.XPath(".."))
                    .FindElement(By.TagName("h5"))
                    .Text;
        }

        public string QuoteCustomerNumber
        {
            get { return WebDriver.GetElement(_customerNumberTxt).Text; }
            set
            {
                WebDriver.GetElement(_customerNumberTxt).SendKeys(value);
                WebDriver.GetElement(_customerNumberTxt).SendKeys(Keys.Tab);
                WebDriver.WaitForElementVisible(_changeCustomerLnk, TimeSpan.FromSeconds(20));
            }
        }

        public void ExpandAllShowMore()
        {
            var allShowMoreLinks = WebDriver.FindElements(By.ClassName("icon-ui-expand"));
            foreach (var allShowMoreLink in allShowMoreLinks)
            {
                allShowMoreLink.Click();
            }
        }

        public string QuoteName
        {
            get { return WebDriver.GetElement(_quoteNameTxt).Text; }
            set
            {
                WebDriver.WaitForPageLoad(TimeSpan.FromSeconds(30));
                WebDriver.GetElement(_quoteNameTxt).Clear();
                WebDriver.GetElement(_quoteNameTxt).SendKeys(value);
                WebDriver.GetElement(_quoteNameTxt).SendKeys(Keys.Tab);
            }
        }

        public QuoteCreatePage ClickOnVersionRadioBtn()
        {
            WebDriver.ElementClick(_quoteCreateVersionRb);
            return this;
        }
       
        public QuoteCreatePage Configure()
        {
            WebDriver.GetElement(_configureLnk).Click();
            return this;
        }

        public QuoteCreatePage EnterCoupon(string coupon)
        {
            WebDriver.SetText(By.Id(string.Format(QuoteIDs.AddCoupon)), coupon);
            WebDriver.SetText(By.Id(string.Format(QuoteIDs.AddCoupon)), Keys.Tab);
            return this;
        }

        public string GetLineItemTotalAmount(int index)
        {
            return WebDriver.GetText(By.Id(string.Format(QuoteCreatePageConstants.LineItemTotalAmount, index)));
        }

        public string GetLineItemTotalEcoFee(int index)
        {
            return WebDriver.GetText(By.Id(string.Format(QuoteCreatePageConstants.LineItemTotalEcoFee, index)));
        }
      
        public string GetLineItemTotalShippingPrice(int index)
        {
            return WebDriver.GetText(By.Id(string.Format(QuoteIDs.TotalShippingPrice, index)));
        }
       
        public QuoteCreatePage LineItemContractCode(int index, string contractCode)
        {
            WebDriver.SetText(By.Id(string.Format(QuoteIDs.ItemlevelContractCodeInCreateQuote, index)), contractCode);
            WebDriver.SetText(By.Id(string.Format(QuoteIDs.ItemlevelContractCodeInCreateQuote, index)), Keys.Tab);
            return this;
        }

        public bool IsContractCodeExists(int index)
        {
            var element = WebDriver.ElementExists(By.Id(string.Format(QuoteIDs.ItemlevelContractCodeInCreateQuote, index)));
            return element;
        }

        public QuoteCreatePage SetContractCodeAsDefaultYes()
        {
            WebDriver.GetElement(By.Id(string.Format(QuoteIDs.SetContractAsDefaultYes))).Click();
            return this;
        }

        public string GetLineItemProductDescription(int index)
        {
            return WebDriver.GetText(By.Id(string.Format(QuoteCreatePageConstants.Item, index)));
        }
        
        public string GetLineItemUnitPrice(int index)
        {
            return WebDriver.GetText(By.Id(string.Format(QuoteCreatePageConstants.UnitPrice, index)));
        }
        
        public string GetLineItemQuantity(int index)
        {
            return WebDriver.GetValue(By.Id(string.Format(QuoteCreatePageConstants.Quantity, index)));
        }

        public QuoteCreatePage SetLineItemQuantity(int index, int quantity)
        {
            WebDriver.ClearText(By.Id(string.Format(QuoteCreatePageConstants.Quantity, index)));
            WebDriver.GetElement(By.Id(string.Format(QuoteCreatePageConstants.Quantity, index))).Clear();
            WebDriver.SetText(By.Id(string.Format(QuoteCreatePageConstants.Quantity, index)), quantity.ToString(CultureInfo.InvariantCulture));
            new QuoteCreatePage(WebDriver).EnterCoupon("");
            return this;
        }

        public string GetLineItemSellingPrice(int index)
        {
            return WebDriver.GetText(By.Id(string.Format(QuoteCreatePageConstants.SellingPrice, index)));
        }

        public string GetLineItemTotalTax(int index)
        {
            return WebDriver.GetText(By.Id(string.Format(QuoteCreatePageConstants.LineItemTotalTax, index)));
        }

        public string GetLineItemContent(int index)
        {
            return WebDriver.GetElements(By.ClassName(QuoteCreatePageConstants.LineItemDetailsDiv))[index - 1].Text;
        }

        public string GetLineItemOrderCode(int index)
        {
            return WebDriver.GetText(By.Id(string.Format(QuoteCreatePageConstants.OrderCode, index)));
        }

        public int TotalLineItemCount
        {
            get
            {
                WebDriver.WaitForElementVisible(_quoteCreateLineItems, TimeSpan.FromSeconds(30));
                var element = WebDriver.GetElement(_quoteCreateLineItems);
                var elements = element.FindElements(By.XPath("//div[@class='line-item-wrapper ng-scope']"));
                return elements.Count;
            }
        }

        public void SelectShippingMethod(int lineItemIdex, int index)
        {
            var shippingMethod = By.Id(string.Format(QuoteCreatePageConstants.ShippingMethod, lineItemIdex));
            WebDriver.PickDropdownByIndex(shippingMethod, index);
        }

        public QuoteDetailsPage SaveQuote()
        {
            WebDriver.ElementClick(_saveQuoteBtn);
            return new QuoteDetailsPage(WebDriver);
        }

        public bool IsSaveQuoteButtonEnabled()
        {
            return WebDriver.GetElement(_saveQuoteBtn).Enabled;
        }

        public QuoteCreatePage ClickOnQuoteVersionNext()
        {
            WebDriver.ElementClick(_quoteVersionNextBtn);
            return this;
        }

        public ProductSearchPage AddItemsFromsearch()
        {
            WebDriver.ElementClick(_addItemBtn);
            return new ProductSearchPage(WebDriver);
        }

        public QuoteCreatePage ClickCustomerInformationToggle()
        {
            WebDriver.ElementClick(_customerInformationToggle);
            return this;
        }

        public string CustomerId
        {
            get
            {
                return WebDriver.GetElement(_customerId).Text;
            }
        }
        public string CompanyNumber
        {
            get
            {
                return WebDriver.GetElement(_companyNumber).Text;
            }
        }
        
        public string QuoteCreateListPrice
        {
            get { return WebDriver.GetElement(_listPriceLbl).Text; }
        }

        public string QuoteCreateSubtotalAmount
        {
            get { return WebDriver.GetElement(_subtotalAmountLbl).Text; }
        }

        public string QuoteCreateShippingAmount
        {
            get { return WebDriver.GetElement(_shippingAmountLbl).Text; }
        }

        public string QuoteCreateTotalTaxAmount
        {
            get { return WebDriver.GetElement(_totalTaxAmountLbl).Text; }
        }

        public string QuoteCreateEcoFee
        {
            get { return WebDriver.GetElement(_ecoFeeLbl).Text; }
        }

        public string QuoteCreateFinalPrice
        {
            get { return WebDriver.GetElement(_finalPriceLbl).Text; }
        }
        
        public void ShowMoreForEachItemClk()
        {
            WebDriver.ElementClick(_byShowMoreForEachItem);

        }
        
        #endregion

        public QuoteDetailsPage 

        /// <summary>
        /// Determines whether this instance is active.
        /// </summary>
        /// <returns><c>true</c> if this instance is active; otherwise, <c>false</c>.</returns>
        public override bool IsActive()
        {
            return (WebDriver.Url.Contains(Url));
        }

        public string GetContractCodeText(int index)
        {
            return WebDriver.GetElement(By.Id(string.Format(QuoteCreatePageConstants.ContractCodeText, index))).Text;
        }

        public string GetTotalItems()
        {
            return WebDriver.GetElement(_totalItemsTxt).Text;
        }
        
        public bool LineItemOrderCodeExists(int index)
        {
            return WebDriver.ElementExists(By.Id(string.Format("quoteCreate_LI_orderCode_{0}", index)));
        }

        public void ClickShowMoreAtIndex(int index)
        {
            var showMore = WebDriver.GetElements(By.XPath("//div[@class='content-toggle-content ng-scope']"));
            showMore[index - 1].Click();
        }
        
        public void ClickExpandAllConfigurationButton()
        {
            WebDriver.ScrollAndClick(
                By.XPath(
                    "//div[@class='mg-btm-10 pull-right']/a[1]"));
        }

        public int GetTotalNumberOfConfigurations()
        {
            return WebDriver.GetElements(By.CssSelector("#quoteCreate_LI_CS_grid_1 > div > div")).Count;
        }

        public string GetConfigurationTextAtId(int index)
        {
            return WebDriver.GetElement(
                By.Id(string.Format("quoteCreate_LI_CS_optionId_build1_category{0}", index))).Text;
        }

        public string GetQuoteNumber()
        {
            WebDriver.ScrollToElement(By.Id("quoteNumber"));
            return WebDriver.GetElement(By.Id("quoteNumber")).ToString();
        }
    }
}
