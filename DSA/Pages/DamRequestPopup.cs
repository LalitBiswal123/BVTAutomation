using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
   public class DamRequestPopup : DsaPageBase
    {
        public DamRequestPopup(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements


public IWebElement BtnDamRequestSubmitRequest { get { return WebDriver.GetElement(By.Id("closeApprovalRequest_Submit")); } }


public IWebElement BtnDamRequestContinueWorking { get { return WebDriver.GetElement(By.Id("closeApprovalRequest_NoSubmit")); } }


public IWebElement DdlDamRequestApprover { get { return WebDriver.GetElement(By.Id("damApproval_Approver")); } }


public IWebElement ChkBoxDamRequestPriority { get { return WebDriver.GetElement(By.Id("damApproval_Priority")); } }


public IWebElement DamRequestJustification { get { return WebDriver.GetElement(By.Id("damApproval_Justification")); } }
       

public IWebElement BtnDamRequestSubmit { get { return WebDriver.GetElement(By.Id("closeApprovalRequest_Submit")); } }


public IWebElement DamRequestCancelSubmit { get { return WebDriver.GetElement(By.Id("closeApprovalRequest_CancelSubmit")); } }

        #endregion
    }
}
