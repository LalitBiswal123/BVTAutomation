using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Admin
{
    public class AdminPathsPage : DsaPageBase
    {
        public AdminPathsPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements

        
        public IWebElement TabSingleUser { get { return WebDriver.GetElement(By.XPath("@public class='nav-tabs')]/li[1)]/a")); } }

       

        public IWebElement TabMultipleUser { get { return WebDriver.GetElement(By.XPath("public class='nav-tabs')]/li[2)]/a")); } }

        public IWebElement BtnLoadingImage { get { return WebDriver.GetElement(By.Id("busy-overlay")); } }


public IWebElement TblSegments { get { return WebDriver.GetElement(By.XPath("main')]/div[2)]/div[2)]/div[2)]")); } }


public IWebElement TblCustomerBaseName { get { return WebDriver.GetElement(By.XPath("DataTables_Table_9')]/tbody/tr[1)]")); } }

        #endregion

    }
}
