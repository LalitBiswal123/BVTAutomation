using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
    public class BasePage : DsaPageBase
    {
        public BasePage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);            
        }

        #region Elements
      

private IWebElement LoadingImageBtnElement { get { return WebDriver.GetElement(By.Id("busy-overlay")); } }

        #endregion

       
    }
}
