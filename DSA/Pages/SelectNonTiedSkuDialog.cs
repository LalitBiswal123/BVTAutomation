using Dsa.Pages.Product;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
    public class SelectNonTiedSkuDialog : DsaPageBase
    {
        public SelectNonTiedSkuDialog(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement ProductConfigNonTiedSkuSelectedElement { get { return WebDriver.GetElement(By.Id("productConfig_Printers_desc_{0}")); } }


public IWebElement BtnCloseDialog { get { return WebDriver.GetElement(By.ClassName("cfg-flyout-close")); } }
        
        #endregion

        #region Methods
        public ProductConfigurePage ProductConfigNonTiedSkuLink_Click(int index)
        {
            ProductConfigNonTiedSkuSelectedElement.Click();
            return new ProductConfigurePage(WebDriver);
        }

        public void ClosePopUpDialog()
        {
            BtnCloseDialog.Click();
        } 
        #endregion
    }
}
