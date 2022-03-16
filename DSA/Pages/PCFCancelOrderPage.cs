//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Dsa.Pages.Order;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Pages.PCFConvergence;
using System;

namespace Dsa.Pages
{
    public class PCFCancelOrderPage : DsaPageBase
    {
        public PCFCancelOrderPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements


public IWebElement CancelOrderReason { get { return WebDriver.GetElement(By.Id("cancel_reason")); } }


public IWebElement CancelOrderComments { get { return WebDriver.GetElement(By.Id("cancel_comments")); } }


public IWebElement CancelOrderNotify { get { return WebDriver.GetElement(By.Id("cancel-order-notify")); } }


public IWebElement CancelToRebook { get { return WebDriver.GetElement(By.Id("cancel_voidpayment")); } }


public IWebElement CancelOrderNext { get { return WebDriver.GetElement(By.Id("cancel_order_next")); } }

        //[FindsBy(How = How.Id, Using = "orderCancelCfo_sendTo")]

public IWebElement CancelOrderSendTo { get { return WebDriver.GetElement(By.Id("_sendTo")); } }


public IWebElement CancelFormateOption { get { return WebDriver.GetElement(By.Id("orderCancelCfo_formatoption")); } }


public IWebElement LblCancelOrderSuccessMsg { get { return WebDriver.GetElement(By.Id("cancel_order_success_message")); } }


public IWebElement BtnCancelOrderSuccessOk { get { return WebDriver.GetElement(By.Id("cancel_order_success")); } }


public IWebElement CancelOrderCancelBtn { get { return WebDriver.GetElement(By.Id("cancel_order_cancel")); } }


public IWebElement CancelOrderCfoCc { get { return WebDriver.GetElement(By.Id("orderCancelCfo_ccEmailAddress")); } }

        public IWebElement ChkboxOrderCancel(int index)
        {
            return WebDriver.FindElement(By.Id(string.Format("split_selection_{0}", index - 1)));
        }

        #endregion

        #region Methods

        public PCFCancelOrderPage SelectReasonByValue(string cancelReason)
        {
            CancelOrderReason.PickDropdownByValue(WebDriver, cancelReason);
            return this;
        }

        public PCFCancelOrderPage SelectReason(string cancelReason)
        {
            CancelOrderReason.PickDropdownByText(WebDriver, cancelReason);
            return this;
        }

        public bool CancelReasonExist(string cancelReason)
        {
            WebDriver.WaitFor(x => x.IsElementVisible(CancelOrderReason));
            return CancelOrderReason.Text.Contains(cancelReason);
        }

        public PCFCancelOrderPage OrderCancellationComments(string cancelComments)
        {
            CancelOrderComments.SetText(WebDriver, cancelComments);
            return this;
        }

        public PCFCancelOrderPage SendCancelOrderNotice(bool send = false)
        {
            if (CancelOrderNotify.Enabled)
                CancelOrderNotify.Set(send);
            return this;
        }

        public PCFCancelOrderPage ClickRebookChkBox()
        {
            CancelToRebook.Click();
            return this;
        }

        public PCFCancelOrderPage ClickCancelOrderNextBtn()
        {
            CancelOrderNext.Click(WebDriver);
            return this;
        }
        public PCFOrderDetailsPage ClickCancelOrderSuccessBtn()
        {
            BtnCancelOrderSuccessOk.Click(WebDriver);
            return new PCFOrderDetailsPage(WebDriver);
        }
        public PCFCancelOrderPage ClickCancelBtn()
        {
            CancelOrderCancelBtn.Click(WebDriver);
            return this;
        }

        public PCFCancelOrderPage OrderCancelationEmailSendTo(string sendToEmailId)
        {
            if (CancelOrderNotify.Enabled)
            {
                CancelOrderSendTo.SetText(WebDriver, sendToEmailId);
            }

            return this;
        }

        public IWebElement ItemtoCancel(int fulfilindex = 1)
        {

            return WebDriver.GetElement(By.XPath("(//*[contains(@id,'split_selection_')])[" + fulfilindex + "]"));
        }

        public void ProcessOrderCancelAcknowledgement(string attachmentType, string sendTo)
        {
            if (CancelOrderNotify.IsElementClickable(WebDriver))
            CancelOrderNotify.SelectCheckBox(WebDriver);
            CancelFormateOption.PickDropdownByText(WebDriver, attachmentType);
            CancelOrderSendTo.Clear();
            CancelOrderSendTo.SendKeys(sendTo);
            CancelOrderCfoCc.UnSelectCheckBox(WebDriver);
        }

        public PCFCancelOrderPage PCFEnterCancelOrderInfo(string Reason, string Comments)
        {
            CancelOrderReason.IsElementClickable(WebDriver, TimeSpan.FromSeconds(25));
            CancelOrderReason.PickDropdownByText(WebDriver, Reason);
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            CancelOrderComments.SendKeys(Comments);
            return new PCFCancelOrderPage(WebDriver);
        }
        #endregion

        #region FT2



        #endregion

    }

}
