using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
    public class DAMRequestsPage : DsaPageBase
    {
        public DAMRequestsPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);

        }
        #region Elements


public IWebElement LnkPendingreqToggle { get { return WebDriver.GetElement(By.Id("managerApprovalRequest_pendingToggle")); } }


public IWebElement LnkRejectedreqToggle { get { return WebDriver.GetElement(By.Id("managerApprovalRequest_rejectedToggle")); } }


public IWebElement LnkApprovedreqToggle { get { return WebDriver.GetElement(By.Id("managerApprovalRequest_approvedToggle")); } }



        

        #endregion

        public void SelectEzDamActionInPendingAppPage(string Quoteno, string strAction)
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            string xpath = "//table[contains(@id,'DataTables_Table_')]/tbody/tr";
            var rows = WebDriver.GetElements(By.XPath(xpath));
            foreach (var row in rows)
            {
                if (row.FindElements(By.TagName("td"))[2].Text.Contains(Quoteno))
                {
                    row.FindElement(By.XPath(".//a[normalize-space()='" + strAction + "']")).Click();
                    break;
                }
            }

        }



    }
}
