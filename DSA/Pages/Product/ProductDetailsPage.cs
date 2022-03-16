using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Product
{
   public class ProductDetailsPage : DsaPageBase
    {
        public ProductDetailsPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
     
        #region Elements
       

public IWebElement AddToQuoteListView { get { return WebDriver.GetElement(By.Id("productResult_list_add")); } }


public IWebElement MenuCurrentQuoteId { get { return WebDriver.GetElement(By.Id("menu_currentQuote")); } }

        #endregion
    }
}
