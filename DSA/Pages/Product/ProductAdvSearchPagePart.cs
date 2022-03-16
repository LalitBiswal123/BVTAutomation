using System;
using Dell.Adept.UI.Web.Pages;
using Dsa.Utils;
using OpenQA.Selenium;
using Dsa.Constants;

namespace Dsa.Pages.Product
{
    public class ProductAdvSearchPagePart : ProductSearchPage
    {
        #region Elements
        private readonly By _byOrderCode = By.Id(ProductIDs.OrderCodeId);
        private readonly By _byProductSearchBtn = By.Id(ProductIDs.ProductSearchButtonId);
        private readonly By _bySnPSearch = By.Id(ProductIDs.SkuDescriptionId);
        private readonly By _bySystemSearch = By.Id(ProductIDs.ChassisDescriptionId);
        private readonly By _bySkuId = By.Id(ProductIDs.SkuId);
        
        public string OrderCode
        {   //Original Getter and setter methods are commented as this is not working in CI environment and updated with common getter and setter used for other Searches
            //get { return WebDriver.GetElement(_byOrderCode).Text; }
            get { return _byOrderCode.GetText(WebDriver); }            
            //set { WebDriver.GetElement(_byOrderCode).SendKeys(value); }
            set { _byOrderCode.SetText(WebDriver, value); }
        }
        
        public string SkuId
        {
            get { return _bySkuId.GetText(WebDriver); }
            set { _bySkuId.SetText(WebDriver, value); }
        }
        
        public string SystemSearch
        {
            get { return _bySystemSearch.GetText(WebDriver); }
            set { _bySystemSearch.SetText(WebDriver, value); }
        }
        
        public string SnPSearch
        {
            get { return _bySnPSearch.GetText(WebDriver); }
            set { _bySnPSearch.SetText(WebDriver, value); }
        }
        
        public IPage ExecuteProductSearch()
        {
            _byProductSearchBtn.Click(WebDriver);
            return new ProductListViewPagePart(WebDriver);
        }

        #endregion
        public override bool Validate()
        {
            throw new NotImplementedException();
        }
        
        public ProductAdvSearchPagePart(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "Product Search";
        }
    }
}