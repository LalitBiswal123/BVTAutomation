using System;
using Dsa.Constants;
using OpenQA.Selenium;

namespace Dsa.Pages.Product
{
    public class ProductSearchPage : DsaPageBase
    {
        public ProductSearchPage(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "Product Search";
        }
        
        public override bool Validate()
        {
            throw new NotImplementedException();
        }

        public override bool IsActive()
        {
            return (WebDriver.Url.Contains(ProductIDs.ProductsSearchRoute));
        }
    }
}
