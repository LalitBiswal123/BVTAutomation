using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
  public class PermissionAssignmentsPage : DsaPageBase
    {
        public PermissionAssignmentsPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements


public IWebElement TblPermission { get { return WebDriver.GetElement(By.Id("permissionsTable")); } }

        private readonly By _byPermissionTbl = By.Id(@"permissionsTable");
        private IWebElement PermissionTbl
        {
            get { return WebDriver.GetElement(_byPermissionTbl); }
        }
        public bool PermissionTblPresent()
        {
            return PermissionTbl.Displayed;
        }

        #endregion
    }
}
