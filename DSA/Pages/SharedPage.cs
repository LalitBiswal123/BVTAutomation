using System;
using Dell.Adept.UI.Web.Pages;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using Dsa.Constants;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
    public class SharedPage : PageBase
    {
        //IWebDriver webDriver;
        public SharedPage(IWebDriver webDriver) : base(ref webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

         

        public override bool IsActive()
        {
            throw new System.NotImplementedException();
        }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }

        public void SelectCatalog(string catalogName = "Healthcare")
        {
            if (!IsCatalogPopUpAvailable()) return;
            CatalogSelect(catalogName).Click();
            WebDriver.WaitForBusyOverlay();
        }

        public IWebElement CatalogSelect(string catalogName)
        {
            return WebDriver.FindElement(By.Id(string.Format(QuoteIDs.CatalogSelect, catalogName)),
                TimeSpan.FromSeconds(60));
        }

        public bool IsCatalogPopUpAvailable()
        {
            WebDriver.WaitForBusyOverlay();
            WebDriver.WaitForElement(By.Id(QuoteIDs.CatalogeGrid), TimeSpan.FromSeconds(60), false); // because of the false option. If unable to find the element withint the time, then throw exception. otherwise, goto the next step.
            return WebDriver.ElementExists(By.Id(QuoteIDs.CatalogeGrid));
        }
    }
}
