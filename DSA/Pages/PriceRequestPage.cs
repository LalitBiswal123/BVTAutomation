using System;
using System.Drawing;
using System.Linq;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Utils;
using Dsa.Workflows;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
    public class PriceRequestPage : DsaPageBase
    {
        public PriceRequestPage(IWebDriver webDriver) : base(webDriver)
        {

        }


        #region Menu

        public IWebElement LnkAllrequests { get { return WebDriver.GetElement(By.XPath("//a[contains(normalize-space(),'All Requests')]")); } }
        public IWebElement LnkMyQueue { get { return WebDriver.GetElement(By.XPath("//a[contains(normalize-space(),'My Queue')]")); } }

        public IWebElement LnkPrSigninHere { get { return WebDriver.GetElement(By.Id("lemcEmployeeLoginLink")); } }

        #endregion

        #region AllRequest

        public IWebElement NewUnassignedTab { get { return WebDriver.GetElement(By.Id("NewAndUnAssignedTab")); } }
        public IWebElement PendingApprovalTab { get { return WebDriver.GetElement(By.Id("PendingApprovalTab")); } }
        public IWebElement ResolvedTab { get { return WebDriver.GetElement(By.Id("ResolvedTab")); } }
        public IWebElement DrpItemPerPage { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'page')]/../select")); } }
        public IWebElement BtnAssignToMe { get { return WebDriver.GetElement(By.Id("btnAssignToMe")); } }
        public IWebElement LblNotification { get { return WebDriver.GetElement(By.XPath("//div[@role='alert']//p")); } }
        public IWebElement BtnRejectPriceRequest { get { return WebDriver.GetElement(By.Id("btnRejectPriceRequest")); } }
        public IWebElement BtnCounterOfferPriceRequest { get { return WebDriver.GetElement(By.Id("btnCounterOfferPriceRequest")); } }
        public IWebElement BtnApprovePriceRequest { get { return WebDriver.GetElement(By.Id("btnApprovePriceRequest")); } }

        public IWebElement TxtRejectReason { get { return WebDriver.GetElement(By.Id("idReasonforRejectionTextarea")); } }
        public IWebElement BtnRejectPopUp { get { return WebDriver.GetElement(By.XPath("//*[@id='btnCancelRejectPopUp']/preceding-sibling::button")); } }
        public IWebElement BtnCancelRejectPopUp { get { return WebDriver.GetElement(By.Id("btnCancelRejectPopUp")); } }
        public IWebElement LblPendingPrStatus { get { return WebDriver.GetElement(By.XPath("//label[@for='pendingStatus']")); } }
        public IWebElement LblRejectedPrStatus { get { return WebDriver.GetElement(By.XPath("//label[@for='rejectedStatus']")); } }
        public IWebElement LblRejectedPrComments { get { return WebDriver.GetElement(By.XPath("//label[@for='rejectionReasonComments']")); } }


        #endregion

        #region Pagemethods

        public void m_NavigateToDSAMDashboard()
        {
            HomeWorkflow.GoToDSAMPage(WebDriver);
            WebDriver.SwitchTo().Window(WebDriver.WindowHandles.Last());
            LnkPrSigninHere.Click(WebDriver);

        }



        public void m_GoToNewnUnAssignedTab()
        {
            LnkAllrequests.Click(WebDriver);
            NewUnassignedTab.Click(WebDriver);
        }


        public void m_GoToPendingApprovalTab()
        {
            LnkAllrequests.Click(WebDriver);
            PendingApprovalTab.Click(WebDriver);
        }


        public void m_GoToResolvedTab()
        {
            LnkAllrequests.Click(WebDriver);
            ResolvedTab.Click(WebDriver);
        }

        public void m_AssignToMeFromGrid(string prReqId)
        {
            m_GoToNewnUnAssignedTab();




        }

        public void m_AssignToMeFromDetailView(string prReqId)
        {
            m_GoToNewnUnAssignedTab();
            DrpItemPerPage.PickDropdownByText(WebDriver, "100");
            WebDriver.GetElement(By.LinkText(prReqId)).Click(WebDriver);
            BtnAssignToMe.Click(WebDriver);
            LblNotification.GetText(WebDriver).Contains(prReqId);
            LblPendingPrStatus.GetText(WebDriver).Contains("Pending");
            BtnApprovePriceRequest.Should().NotBeNull();
            BtnCounterOfferPriceRequest.Should().NotBeNull();
            BtnRejectPriceRequest.Should().NotBeNull();


        }

        public void m_RejectPriceRequest(string prReqId)
        {
            string rejectReason = "Rejecting this price request ";

            m_GoToPendingApprovalTab();
            DrpItemPerPage.PickDropdownByText(WebDriver, "100");
            WebDriver.GetElement(By.LinkText(prReqId)).Click(WebDriver);
            BtnRejectPriceRequest.Click(WebDriver);
            BtnRejectPopUp.IsElementClickable(WebDriver,TimeSpan.FromSeconds(5)).Should().BeFalse();
            TxtRejectReason.SetText(WebDriver, rejectReason + prReqId);
            BtnRejectPopUp.Click(WebDriver);
            LblNotification.GetText(WebDriver).Contains(prReqId);
            LblRejectedPrStatus.GetText(WebDriver).Contains("Rejected");
            LblRejectedPrComments.GetText(WebDriver).Contains(rejectReason);

        }

        public void m_ApprovePriceRequest(string prReqId)
        {

        }

        public void m_NegotiatePriceRequest(string prReqId)
        {

        }

        #endregion
    }
}
