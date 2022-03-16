using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
   public class ExportAuditLogPage : DsaPageBase
    {
        public ExportAuditLogPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements


public IWebElement LnkExportAuditLog { get { return WebDriver.GetElement(By.XPath("ul.nav > li:nth-child(6) > a:nth-child(1)")); } }


public IWebElement TxtDestination { get { return WebDriver.GetElement(By.XPath("audit_search_destination")); } }


public IWebElement BtnExport { get { return WebDriver.GetElement(By.Id("auditLogExport_button")); } }

        #endregion
    }
}
