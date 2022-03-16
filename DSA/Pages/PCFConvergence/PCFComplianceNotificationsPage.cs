using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Utils;
using OpenQA.Selenium;

namespace Dsa.Pages.PCFConvergence
{
    public class PCFComplianceNotificationsPage : DsaPageBase
    {
        private IWebDriver webDriver;
        public PCFComplianceNotificationsPage(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "Compliance Notifications Page";
            this.webDriver = webDriver;
        }

        #region webelements_Knights
        public IWebElement IncludeMeAsRecipitent { get { return WebDriver.GetElement(By.XPath("//input[@id='email_include_orderAck]")); } }
        public IWebElement ContinueButton { get { return WebDriver.GetElement(By.Id("PaymentLink")); } }
        public IWebElement BtnContiueCheckOut { get { return WebDriver.GetElement(By.Id("ContinueLink")); } }
        public IWebElement ButtonBack { get { return WebDriver.GetElement(By.Id("BackButton")); } }
        public IWebElement CheckOutButton { get { return WebDriver.GetElement(By.Id("continueToCheckoutButton")); } }
        public IWebElement ChkboxOrderAcknowledgeBillTo { get { return WebDriver.GetElement(By.Id("email_billToEmailAck")); } }
        public IWebElement ChkboxOrderAcknowledgeSoldTo { get { return WebDriver.GetElement(By.Id("email_soldToEmailAck")); } }
        public IWebElement ChkboxOrderAcknowledgeShipTo { get { return WebDriver.GetElement(By.Id("email_custShipping_orderAck")); } }
        public IWebElement ChkboxOrderAcknowledgeCCTo { get { return WebDriver.GetElement(By.Id("email_AckSalesRep")); } }
        public IWebElement ChkboxOrderAcknowledgeIncludeMe { get { return WebDriver.GetElement(By.Id("email_include_orderAck")); } }
        public IWebElement ChkboxOrderConformationBillTo { get { return WebDriver.GetElement(By.Id("email_billToEmailConf")); } }
        public IWebElement ChkboxOrderConformationSoldTo { get { return WebDriver.GetElement(By.Id("email_soldToEmailConf")); } }
        public IWebElement ChkboxOrderConformationShipTo { get { return WebDriver.GetElement(By.Id("email_custShipping_orderConf")); } }
        public IWebElement ChkboxOrderConformationCCTo { get { return WebDriver.GetElement(By.Id("email_ConfSalesRep")); } }
        public IWebElement ChkboxOrderConformationIncludeMe { get { return WebDriver.GetElement(By.Id("email_include_orderConf")); } }
        public IWebElement BtnAddOrderAcknowledgement { get { return WebDriver.GetElement(By.XPath("(//a[@id='addEmailButton'])[1]")); } }
        public IWebElement BtnAddOrderConformation { get { return WebDriver.GetElement(By.XPath("(//a[@id='addEmailButton'])[2]")); } }
        public IWebElement TextAdditionalMail { get { return WebDriver.GetElement(By.Id("emailInputBox")); } }
        public IWebElement LblValidMailID { get { return WebDriver.GetElement(By.XPath("//span[text()='Enter a valid email address']")); } }
        public IWebElement LblAckBillTo { get { return WebDriver.GetElement(By.XPath("//input[@id='email_billToEmailAck']//parent::div")); } }
        public IWebElement LblAckSoldTo { get { return WebDriver.GetElement(By.XPath("//input[@id='email_soldToEmailAck']//parent::div")); } }
        public IWebElement LblAckShipTo { get { return WebDriver.GetElement(By.XPath("//input[@id='email_soldToEmailAck']//parent::div")); } }
        public IWebElement LblCnfBillTo { get { return WebDriver.GetElement(By.XPath("//input[@id='email_billToEmailConf']//parent::div")); } }
        public IWebElement LblCnfSoldTo { get { return WebDriver.GetElement(By.XPath("//input[@id='email_soldToEmailAck']//parent::div")); } }
        public IWebElement LblCnfShipTo { get { return WebDriver.GetElement(By.XPath("//input[@id='email_soldToEmailAck']//parent::div")); } }
        public IList<IWebElement> LblTotalListAckEmails { get { return WebDriver.GetElements(By.XPath("(//div[contains(@class,'notification-emails')])[1]//input[@type='checkbox']")); } }
        public IList<IWebElement> LblTotalListCnfEmails { get { return WebDriver.GetElements(By.XPath("(//div[contains(@class,'notification-emails')])[2]//input[@type='checkbox']")); } }

        public By LblErrorMsgPrompt = By.XPath(".//*[@class='alert alert-error']//span/span[contains(text(), 'Not Found')]");

        public IWebElement ChkBoxDuplicateCheck { get { return WebDriver.GetElement(By.Id("chkContinueWithDuplOrder")); } }

        By byChkBoxDuplicateCheck = By.Id("chkContinueWithDuplOrder");

        public IWebElement BtnDuplicateCheckContinue { get { return WebDriver.GetElement(By.XPath("//button[@class='dds__btn dds__btn-primary pd-btn']")); } }

        public IWebElement PaymentPageText { get { return WebDriver.GetElement(By.XPath("//*[@id='PartnerProgressBar']//div//span[contains(text(), 'Payment')]")); } }

        #endregion

        public PCFPaymentsPage ContinueCheckout()
        {
            BtnContiueCheckOut.WaitForElementDisplayed(TimeSpan.FromSeconds(10));
            BtnContiueCheckOut.PCFClick(WebDriver);
            webDriver.PCFVerifyBusyOverlayNotDisplayed();
            return new PCFPaymentsPage(webDriver);
        }

        public bool AddAdditionalOrderAckMail(string sendTo, bool unselectothers = false)
        {
            if (unselectothers == true)
            {
                UnSelectingAllOrderAcknowledgement();
            }
            BtnAddOrderAcknowledgement.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2));
            BtnAddOrderAcknowledgement.PCFClick(WebDriver);

            TextAdditionalMail.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2));
            TextAdditionalMail.SetText(WebDriver, sendTo, TimeSpan.FromSeconds(2));

            // Validating email message prompt displaying or not 
            bool ErrorMsg = WebDriver.ElementExists(LblErrorMsgPrompt);
            return ErrorMsg;
        }

        public bool AddAdditionalOrderConformationMail(string sendTo, bool unselectothers = false)
        {
            if (unselectothers == true)
            {
                UnSelectingAllOrderConformation();
            }
            BtnAddOrderConformation.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2));
            BtnAddOrderConformation.PCFClick(WebDriver);

            TextAdditionalMail.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2));
            TextAdditionalMail.SetText(WebDriver, sendTo, TimeSpan.FromSeconds(2));

            // Validating email message prompt displaying or not
            bool ErrorMsg = WebDriver.ElementExists(LblErrorMsgPrompt);
            return ErrorMsg;
        }
        public void SelectMultipleOrderAckEmails(IWebDriver driver, bool soldTo = true, bool billTo = false, bool shipTo = false, bool cc = true, bool includeMe = false)
        {
            string AckBillTo = LblAckBillTo.Text.Trim().Split('<')[1];
            string AckSoldTo = LblAckSoldTo.Text.Trim().Split('<')[1];
            string AckShipTo = LblAckShipTo.Text.Trim().Split('<')[1];

            if (soldTo == false && ChkboxOrderAcknowledgeSoldTo.Selected)
            {
                ChkboxOrderAcknowledgeSoldTo.UnSelectCheckBox(WebDriver);
            }
            else if (soldTo == true && !ChkboxOrderAcknowledgeSoldTo.Selected)
            {
                ChkboxOrderAcknowledgeSoldTo.SelectCheckBox(WebDriver);

                if (AckSoldTo.Equals(AckBillTo) && !ChkboxOrderAcknowledgeBillTo.Selected)
                {
                    ChkboxOrderAcknowledgeBillTo.SelectCheckBox(WebDriver);
                    Logger.Write(" SoldTo and ShipTo emails are same and are Selected");
                }
                else
                {
                    Logger.Write(" BillTo is UnSelected");
                }

                if (AckSoldTo.Equals(AckShipTo) && !ChkboxOrderAcknowledgeShipTo.Selected)
                {
                    ChkboxOrderAcknowledgeShipTo.SelectCheckBox(WebDriver);
                    Logger.Write(" SoldTo and ShipTo emails are same and are Selected");
                }
                else
                {
                    Logger.Write(" ShipTo is UnSelected");
                }
            }

            if (billTo == true && !ChkboxOrderConformationBillTo.Selected)
            {
                ChkboxOrderAcknowledgeBillTo.SelectCheckBox(WebDriver);

                if (AckBillTo.Equals(AckSoldTo) && !ChkboxOrderAcknowledgeSoldTo.Selected)
                {
                    ChkboxOrderAcknowledgeSoldTo.SelectCheckBox(WebDriver);
                    Logger.Write(" SoldTo and BillTo emails are same and are Selected");
                }
                else
                {
                    Logger.Write(" SoldTo is UnSelected");
                }

                if (AckBillTo.Equals(AckShipTo) && !ChkboxOrderAcknowledgeShipTo.Selected)
                {
                    ChkboxOrderAcknowledgeShipTo.SelectCheckBox(WebDriver);
                    Logger.Write(" BillTo and ShipTo emails are same and are Selected");
                }
                else
                {
                    Logger.Write(" ShipTo is UnSelected");
                }
            }

            if (shipTo == true && !ChkboxOrderAcknowledgeShipTo.Selected)
            {
                ChkboxOrderAcknowledgeShipTo.SelectCheckBox(WebDriver);

                if (AckShipTo.Equals(AckSoldTo) && !ChkboxOrderAcknowledgeSoldTo.Selected)
                {
                    ChkboxOrderAcknowledgeSoldTo.SelectCheckBox(WebDriver);
                    Logger.Write(" SoldTo and ShipTo emails are same and are Selected");
                }
                else
                {
                    Logger.Write(" SoldTo is UnSelected");
                }

                if (AckShipTo.Equals(AckBillTo) && !ChkboxOrderAcknowledgeBillTo.Selected)
                {
                    ChkboxOrderAcknowledgeBillTo.SelectCheckBox(WebDriver);
                    Logger.Write(" BillTo and ShipTo emails are same and are Selected");
                }
                else
                {
                    Logger.Write(" ShipTo is UnSelected");
                }
            }

            if (cc == false && ChkboxOrderAcknowledgeCCTo.Selected)
            {
                ChkboxOrderAcknowledgeCCTo.UnSelectCheckBox(WebDriver);
            }
            else if (cc == true && !ChkboxOrderAcknowledgeCCTo.Selected)
            {
                ChkboxOrderAcknowledgeCCTo.SelectCheckBox(WebDriver);
            }

            if (includeMe == true && !ChkboxOrderAcknowledgeIncludeMe.Selected)
            {
                ChkboxOrderAcknowledgeIncludeMe.SelectCheckBox(WebDriver);
            }
            else if (includeMe == false && ChkboxOrderAcknowledgeIncludeMe.Selected)
            {
                ChkboxOrderAcknowledgeIncludeMe.UnSelectCheckBox(WebDriver);
            }
        }

        public void SelectMultipleOrderConformationEmails(IWebDriver driver, bool soldTo = true, bool billTo = false, bool shipTo = false, bool cc = true, bool includeMe = false)
        {
            string ConfBillTo = LblCnfBillTo.Text.Trim().Split('<')[1];
            string ConfSoldTo = LblCnfSoldTo.Text.Trim().Split('<')[1];
            string ConfShipTo = LblCnfShipTo.Text.Trim().Split('<')[1];

            if (soldTo == false && ChkboxOrderConformationSoldTo.Selected)
            {
                ChkboxOrderConformationSoldTo.UnSelectCheckBox(WebDriver);
            }
            else if (soldTo == true && !ChkboxOrderConformationSoldTo.Selected)
            {
                ChkboxOrderConformationSoldTo.SelectCheckBox(WebDriver);

                if (ConfSoldTo.Equals(ConfBillTo) && !ChkboxOrderConformationBillTo.Selected)
                {
                    ChkboxOrderConformationBillTo.SelectCheckBox(WebDriver);
                    Logger.Write(" SoldTo and ShipTo emails are same and are Selected");
                }
                else
                {
                    Logger.Write(" BillTo is UnSelected");
                }

                if (ConfSoldTo.Equals(ConfShipTo) && !ChkboxOrderConformationShipTo.Selected)
                {
                    ChkboxOrderConformationShipTo.SelectCheckBox(WebDriver);
                    Logger.Write(" SoldTo and ShipTo emails are same and are Selected");
                }
                else
                {
                    Logger.Write(" ShipTo is UnSelected");
                }
            }

            if (billTo == true && !ChkboxOrderConformationBillTo.Selected)
            {
                ChkboxOrderConformationBillTo.SelectCheckBox(WebDriver);

                if (ConfBillTo.Equals(ConfSoldTo) && !ChkboxOrderConformationSoldTo.Selected)
                {
                    ChkboxOrderConformationSoldTo.SelectCheckBox(WebDriver);
                    Logger.Write(" SoldTo and BillTo emails are same and are Selected");
                }
                else
                {
                    Logger.Write(" SoldTo is UnSelected");
                }

                if (ConfBillTo.Equals(ConfShipTo) && !ChkboxOrderConformationShipTo.Selected)
                {
                    ChkboxOrderConformationShipTo.SelectCheckBox(WebDriver);
                    Logger.Write(" BillTo and ShipTo emails are same and are Selected");
                }
                else
                {
                    Logger.Write(" ShipTo is UnSelected");
                }
            }

            if (shipTo == true && !ChkboxOrderConformationShipTo.Selected)
            {
                ChkboxOrderConformationShipTo.SelectCheckBox(WebDriver);

                if (ConfShipTo.Equals(ConfSoldTo) && !ChkboxOrderConformationSoldTo.Selected)
                {
                    ChkboxOrderConformationSoldTo.SelectCheckBox(WebDriver);
                    Logger.Write(" SoldTo and ShipTo emails are same and are Selected");
                }
                else
                {
                    Logger.Write(" SoldTo is UnSelected");
                }

                if (ConfShipTo.Equals(ConfBillTo) && !ChkboxOrderConformationBillTo.Selected)
                {
                    ChkboxOrderConformationBillTo.SelectCheckBox(WebDriver);
                    Logger.Write(" BillTo and ShipTo emails are same and are Selected");
                }
                else
                {
                    Logger.Write(" ShipTo is UnSelected");
                }
            }

            if (cc == false && ChkboxOrderConformationCCTo.Selected)
            {
                ChkboxOrderConformationCCTo.UnSelectCheckBox(WebDriver);
            }
            else if (cc == true && !ChkboxOrderConformationCCTo.Selected)
            {
                ChkboxOrderConformationCCTo.SelectCheckBox(WebDriver);
            }

            if (includeMe == true && !ChkboxOrderConformationIncludeMe.Selected)
            {
                ChkboxOrderConformationIncludeMe.SelectCheckBox(WebDriver);
            }
            else if (includeMe == false && ChkboxOrderConformationIncludeMe.Selected)
            {
                ChkboxOrderConformationIncludeMe.UnSelectCheckBox(WebDriver);
            }
        }

        public void UnSelectingAllOrderAcknowledgement()
        {
            // Unselecting all emails in order acknowledgement
            if (LblTotalListAckEmails.Count > 0)
            {
                for (int i = 1; i <= LblTotalListAckEmails.Count - 1; i++)
                {
                    if (LblTotalListAckEmails[i].Selected)
                    {
                        LblTotalListAckEmails[i].PCFClick(WebDriver);
                    }
                }
            }
        }
        public void UnSelectingAllOrderConformation()
        {
            // Unselecting all emails in order conformation
            if (LblTotalListCnfEmails.Count > 0)
            {
                for (int i = 1; i <= LblTotalListCnfEmails.Count - 1; i++)
                {
                    if (LblTotalListCnfEmails[i].Selected)
                    {
                        LblTotalListCnfEmails[i].PCFClick(WebDriver);
                    }
                }
            }
        }
        public PCFPaymentsPage ProcessOrderAcknowledgement(string attachmentType, string sendTo, bool sendCFO = true)
        {
            webDriver.PCFVerifyBusyOverlayNotDisplayed();

            //Checking if Duplicate Order Check popup shown and proceed to Continue
            if (WebDriver.WaitForElementDisplay(byChkBoxDuplicateCheck, TimeSpan.FromSeconds(3)))
            {
                ChkBoxDuplicateCheck.PCFClick(webDriver);
                BtnDuplicateCheckContinue.PCFClick(webDriver);
                webDriver.PCFVerifyBusyOverlayNotDisplayed();

            }
            //Unchecking the Other Selections and add only Send To for Order Ack and Order Conf
            if (sendCFO == true)
            {
                UnSelectingAllOrderAcknowledgement();
                AddAdditionalOrderAckMail(sendTo);
                UnSelectingAllOrderConformation();
                AddAdditionalOrderConformationMail(sendTo);
            }
            //Unchecking all Selections for Order Ack and Order Confsection
            else
            {
                //UnSelectingAllOrderAcknowledgement();
                //UnSelectingAllOrderConformation();
            }
            return ContinueCheckout();
        }

        public PCFSubscriptionBillingPage ContinueToSubscriptionBillingPage()
        {
            BtnContiueCheckOut.Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return new PCFSubscriptionBillingPage(WebDriver);
        }

        public PCFComplianceNotificationsPage CheckDuplicateOrderPopUp()
        {
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            By duplicateCheckElement = By.Id("chkContinueWithDuplOrder");

            // Check for duplicate order popup window 
            try
            {
				if (WebDriver.ElementExists(duplicateCheckElement))
				{
                    ChkBoxDuplicateCheck.PCFClick(webDriver);
                    BtnDuplicateCheckContinue.PCFClick(webDriver);
                }
				else
				{
                    Logger.Write("Duplicate order check pop-up is not displayed.");
				}
            }
            catch(Exception e)
			{
                Logger.Write(e.Message);
			}

            WebDriver.VerifyBusyOverlayNotDisplayed();
            return new PCFComplianceNotificationsPage(webDriver);
        }

        public PCFQuoteSummaryPage ExportComplianceCancel()
        {
            ButtonBack.Click(WebDriver);
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            return new PCFQuoteSummaryPage(WebDriver);
        }

        #region   FT2





        #endregion

    }
}

