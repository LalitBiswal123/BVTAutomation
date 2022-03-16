using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
     public class YourCustomerPage : DsaPageBase
    {
        [System.Obsolete]
        public YourCustomerPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements


public IWebElement CustomerNameCol { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_0 > thead > tr > th:nth-child(2)")); } }
        
        #endregion
    }

   
}
