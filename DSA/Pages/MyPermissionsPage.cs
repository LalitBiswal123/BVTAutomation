using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Dsa.Pages
{
    public class MyPermissionsPage : DsaPageBase
    {
        public MyPermissionsPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements


public IWebElement LnkPermissions { get { return WebDriver.GetElement(By.PartialLinkText("Administrator")); } }

        #endregion
 
    }
}
