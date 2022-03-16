using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
   public class AddConfigServiceDialog : DsaPageBase
    {
        public AddConfigServiceDialog(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements


public IWebElement ProductConfig { get { return WebDriver.GetElement(By.Id("productConfig_addCs")); } }
       

public IWebElement BtnGet { get { return WebDriver.GetElement(By.Id("productConfig_GetCs")); } }

        #endregion
    }
}
