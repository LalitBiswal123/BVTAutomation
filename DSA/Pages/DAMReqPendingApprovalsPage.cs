using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
    public class DAMReqPendingApprovalsPage : DsaPageBase
    {
        public DAMReqPendingApprovalsPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);

        }
        #region Elements


public IWebElement LnkPendingreqToggle { get { return WebDriver.GetElement(By.Id("approverApproval_approverPendingRequestToggle")); } }


public IWebElement TxtDamApprovalNotes { get { return WebDriver.GetElement(By.Id("approverApproveDialog_notes")); } }


public IWebElement BtnDamApproveDialogApprove { get { return WebDriver.GetElement(By.Id("approverApproveDialog_approve")); } }


public IWebElement tblDateheader { get { return WebDriver.GetElement(By.XPath("//th[normalize-space()='Date']")); } }



public IWebElement TxtDamRejectNotes { get { return WebDriver.GetElement(By.Id("approverApproveDialog_notes")); } }


public IWebElement BtnDamRejectDialogReject { get { return WebDriver.GetElement(By.Id("approverApproveDialog_reject")); } }


public IWebElement DdlDamApprover { get { return WebDriver.GetElement(By.Id("approverApproveDialog_approvers")); } }


public IWebElement TxtDamReassignNotes { get { return WebDriver.GetElement(By.Id("approverApproveDialog_notes")); } }


public IWebElement BtnDamReAssignDialogApprove { get { return WebDriver.GetElement(By.Id("approverApproveDialog_reassign")); } }


public IWebElement DdlSelectApprover { get { return WebDriver.GetElement(By.Id("damApproval_ApprovedByMgrFa")); } }

public IWebElement DdlSelectDateRng { get { return WebDriver.GetElement(By.Id("approverApproval_dateRange")); } }

        

        public By PendAppReqsTable = By.XPath("//table[contains(@id,'DataTables_Table_')]/tbody/tr");
        #endregion

        public DAMReqPendingApprovalsPage SelectApprover(string approver)
        {
            DdlSelectApprover.PickDropdownByText(WebDriver, approver);
            return new DAMReqPendingApprovalsPage(WebDriver);
        }

        public void SelectEzDamActionInPendingAppPage(string Quoteno, string strAction)
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            var rows = WebDriver.GetElements(PendAppReqsTable);
            foreach (var row in rows)
            {
                if (row.FindElements(By.TagName("td"))[2].Text.Contains(Quoteno))
                {
                    row.FindElement(By.XPath(".//a[normalize-space()='" + strAction + "']")).Click();
                    break;
                }
            }

        }

        public DAMReqPendingApprovalsPage ApproveDamRequestInPendingApprovalPage(string notes)
        {
            TxtDamApprovalNotes.SetText(WebDriver, notes);
            BtnDamApproveDialogApprove.Click(WebDriver);
            return new DAMReqPendingApprovalsPage(WebDriver);
        }

        public DAMReqPendingApprovalsPage RejectDamRequestInPendingApprovalPage(string notes)
        {
            TxtDamRejectNotes.SetText(WebDriver, notes);
            BtnDamRejectDialogReject.Click(WebDriver);
            return new DAMReqPendingApprovalsPage(WebDriver);
        }

        public DAMReqPendingApprovalsPage ReassginDamRequestInPendingApprovalPage(string approverMailId, string justification = "")
        {
            DdlDamApprover.PickDropdownByText(WebDriver, approverMailId);
            TxtDamReassignNotes.SetText(WebDriver,justification);
            BtnDamReAssignDialogApprove.Click(WebDriver);
            return new DAMReqPendingApprovalsPage(WebDriver);
        }


        public bool VerifyQuoteNoInPendingAppReqPage(string Quoteno)
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            var rows = WebDriver.GetElements(PendAppReqsTable);
            bool found = false;
            foreach (var row in rows)
            {
                if (row.FindElements(By.TagName("td"))[2].Text.Contains(Quoteno))
                {
                    found = true;
                    break;
                }
            }
            return found;

        }
        
    }
}
