using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dsa.Pages.PCFConvergence;
using OpenQA.Selenium;
using Dsa.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsa.DataModels;
using Dsa.Enums;
using Dsa.Pages.Quote;


namespace Dsa.Workflows
{
    public static class PCFCreateOrderWorkflow
    {
        public static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static PCFOrderDetailsPage CreateOrderFromQuoteDetails(IWebDriver driver, string paymentMethod)
        {
            CreateOrderTillPaymentPage(driver);

            Log.Info("Complete Payment Info");
            new PCFPaymentsPage(driver).SelectPaymentType(paymentMethod);
            new PCFPaymentsPage(driver).ContinueButton.Click(driver);
            driver.PCFVerifyBusyOverlayNotDisplayed();

            Log.Info("Complete GMOR Steps and Place Order");
            PCFOrderReviewPage orderReviewPage = new PCFOrderReviewPage(driver);
            orderReviewPage.CompleteGMOR();
            PCFOrderDetailsPage pCFOrderDetailsPage = orderReviewPage.PlaceOrder();
            driver.PCFVerifyBusyOverlayNotDisplayed();
            string dpid = pCFOrderDetailsPage.dpidLabel.GetText(driver, TimeSpan.FromSeconds(3));

            Log.Info("Successfully Placed Order for  DPID " + dpid);
            Assert.IsTrue(dpid.Contains("200"), "Unable to place Order Test Fail");
            return pCFOrderDetailsPage;
        }

        public static PCFPaymentsPage CreateOrderTillPaymentPage(IWebDriver driver, string sendTo = "com_qe@dell.com", string attachmentType = "PDF Attachment", bool sendCFO = false)
        {
            Log.Info("Click continue To Check Out on Quote Summary Page");
            return new PCFQuoteSummaryPage(driver).ContiuetoCheckout().ProcessOrderAcknowledgement(attachmentType, sendTo, sendCFO);
        }

        // This method is needed to keep same dvt flow as we have in offline
        // If not need to refactor lot of tests
        public static PCFPaymentsPage EnterPaymentData(IWebDriver driver, int index, PaymentMethodType paymentMethod, double? amount = null, CreditCard creditCard = null, GiftCard giftCard = null, bool isSplitPay = false)
        {
            driver.PCFVerifyBusyOverlayNotDisplayed();
            //IWebElement paymentDropdown = driver.FindElement(By.XPath("//div[text()='Payment Method " + index + "']/following-sibling::div/select[@id='paymentOptions1']"));
            IWebElement paymentDropdown = driver.FindElement(By.XPath("//h3[text()='Payment Method " + index + "']/following-sibling::div//select[@id='paymentOptions1']"));
            driver.WaitForElementDisplay(paymentDropdown, TimeSpan.FromSeconds(10));
            PCFPaymentsPage paymentpage = new PCFPaymentsPage(driver);
            string payMethod = paymentpage.PaymentMethodsDropdown.GetText(driver);

            if (payMethod != paymentMethod.ToDescription())
            {
                paymentpage.SelectPaymentType(paymentMethod.ToDescription());
            }

            switch (paymentMethod)
            {
                case PaymentMethodType.CreditCard:
                    paymentpage.EnterCreditCardDetails(driver, creditCard);
                    break;
                case PaymentMethodType.GiftCard:
                    paymentpage.EnterGiftCardDetails(driver, giftCard);
                    break;
            }

            if (isSplitPay)
            {
                paymentpage.LnkSplitPayment.Click(driver);               
            }
            return paymentpage;
        }

        public static void EnterSplitPaymentData(IWebDriver driver, int index, PaymentMethodType paymentMethod, CreditCard creditCard = null, GiftCard giftCard = null, string splitAmt = "1")
        {
            PCFPaymentsPage paymentpage = new PCFPaymentsPage(driver);          
            paymentpage.SplitPaymentMethod(paymentMethod.ToDescription(), index);
            switch (paymentMethod)
            {
                case PaymentMethodType.CreditCard:
                    paymentpage.EnterCreditCardDetails(driver, creditCard);
                    paymentpage.EnterSplitPayApplyRemainderAmt("credit-card-payment", index, splitAmt);
                    break;
                case PaymentMethodType.GiftCard:
                    paymentpage.EnterGiftCardDetails(driver, giftCard);
                    paymentpage.EnterSplitPayApplyRemainderAmt("gift-card", index, splitAmt);
                    break;
                case PaymentMethodType.WireTransfer:
                    paymentpage.EnterSplitPayApplyRemainderAmt("wire-transfer", index, splitAmt);
                    break;
                case PaymentMethodType.Prepaidcheck:
                    paymentpage.EnterSplitPayApplyRemainderAmt("prepaid", index, splitAmt);
                    break;
                case PaymentMethodType.NetTerms:
                    paymentpage.EnterSplitPayApplyRemainderAmt("net-terms-payment", index, splitAmt);
                    break;
                case PaymentMethodType.DellPreferredAccount:
                    paymentpage.EnterSplitPayApplyRemainderAmt("dpa", index, splitAmt);
                    break;

            }            
        }


        public static PCFPaymentsPage PCFEnterPaymentData(IWebDriver driver, int paymentMethodIndex,
            PaymentMethodType paymentMethod, double? amount = null, CreditCard creditCard = null,
            GiftCard giftCard = null)
        {

            driver.VerifyBusyOverlayNotDisplayed();
            PCFPaymentsPage paymentpage = new PCFPaymentsPage(driver);
            if (paymentMethodIndex > 1)
                new PCFPaymentsPage(driver).LnkSplitPayment.Click(driver);

            new PCFPaymentsPage(driver).PaymentMethodsDropdown1[paymentMethodIndex-1].PickDropdownByText(driver, paymentMethod.ToDescription());
            switch (paymentMethod)
            {
                case PaymentMethodType.CreditCard:
                    paymentpage.EnterCreditCardDetails(driver, creditCard);
                    break;
                case PaymentMethodType.GiftCard:
                    paymentpage.EnterGiftCardDetails(driver, giftCard);
                    break;
            }

            return new PCFPaymentsPage(driver);
        }

        public static void PaymentMethodNext(IWebDriver driver)
        {
            driver.PCFVerifyBusyOverlayNotDisplayed();
            PCFPaymentsPage paymentpage = new PCFPaymentsPage(driver);
            paymentpage.ContinueButton.PCFClick(driver);
            driver.PCFVerifyBusyOverlayNotDisplayed();
            while (paymentpage.AdjustPaymentLabel.IsElementDisplayed(driver, TimeSpan.FromSeconds(5)))
            {
                paymentpage.ApplyReminderLink.PCFClick(driver);
                driver.VerifyBusyOverlayNotDisplayed();
                paymentpage.ContinueButton.PCFClick(driver);
                driver.PCFVerifyBusyOverlayNotDisplayed();
            }

        }

        public static PCFOrderDetailsPage CreateOrderFromCreateQuotePage(IWebDriver driver, string paymentMethod)
        {
            var createQuote = new CreateQuotePage(driver);
            createQuote.SaveAsOrder();
            new PCFComplianceNotificationsPage(driver).ContinueButton.Click(driver);
            driver.PCFVerifyBusyOverlayNotDisplayed();
            new PCFPaymentsPage(driver).SelectPaymentType(paymentMethod);
            driver.PCFVerifyBusyOverlayNotDisplayed();
            PaymentMethodNext(driver);
            driver.WaitForPageLoad();
            new PCFOrderReviewPage(driver).SaveOrder();
            return new PCFOrderDetailsPage(driver);
        }
    }
}
