using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Admin
{
    public class AdminPage : DsaPageBase
    {
        public AdminPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        
        //TODO : REMOVE THIS PAGE.

        #region  Elements

        public IWebElement LnkUsers { get { return WebDriver.GetElement(By.CssSelector("ul.nav > li:nth-child(1) > a:nth-child(1)")); } }

        public IWebElement LnkProfiles { get { return WebDriver.GetElement(By.CssSelector("ul.nav > li:nth-child(2) > a:nth-child(1)")); } }

        public IWebElement LnkCustomerBases { get { return WebDriver.GetElement(By.CssSelector("ul.nav > li:nth-child(3) > a:nth-child(1)")); } }

        public IWebElement LnkPermissionAssignments { get { return WebDriver.GetElement(By.CssSelector("ul.nav > li:nth-child(4) > a:nth-child(1)")); } }

        public IWebElement LnkExportProfileUsers { get { return WebDriver.GetElement(By.CssSelector("ul.nav > li:nth-child(5) > a:nth-child(1)")); } }

        public IWebElement LnkExportAuditLog { get { return WebDriver.GetElement(By.CssSelector("l.nav > li:nth-child(6) > a:nth-child(1)")); } }


        #endregion

    }
}
