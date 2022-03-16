using System;
using OpenQA.Selenium;

namespace Dsa.Pages.Product
{
    public class ProductListViewPagePart : ProductSearchPage
    {
    
        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    
        public ProductListViewPagePart(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "Product Results List View";
        }

    }
}