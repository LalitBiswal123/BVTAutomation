using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dell.Adept.UI.Web.Pages;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.DataModels;
using Dsa.Enums;
using Dsa.Pages.Order;
using Dsa.Pages.PCFConvergence;
using Dsa.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Dsa.Pages.PCFConvergence
{
    public class PCFPaymentsPage : DsaPageBase
    {
        private IWebDriver webDriver;
        public PCFPaymentsPage(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "Payments Page";
            this.webDriver = webDriver;
        }

        #region Spartans
        public IWebElement GiftCardNumber { get { return WebDriver.GetElement(By.Id("txtGCNum")); } }
        public IWebElement GiftCardCID { get { return WebDriver.GetElement(By.Id("txtGCCId")); } }
        public IWebElement GCCIDErrorNotification { get { return WebDriver.GetElement(By.XPath("//*[@id='txtGCCId']/following-sibling::div")); } }
        public IWebElement LnkSplitPayment { get { return WebDriver.GetElement(By.Id("addPaymentMethodLink")); } }
        public IWebElement FldCustomerReferenceNumber { get { return WebDriver.GetElement(By.Id("txt_reference_number")); } }
        public IWebElement FldChargeDescription { get { return WebDriver.GetElement(By.Id("txt_charge_description")); } }
        public List<IWebElement>Amount  { get { return WebDriver.GetElements(By.XPath("//amount-input/descendant::input[@id='txt_amount']")); } }
        public List<IWebElement> SplitPayApplyReminderLink { get { return WebDriver.GetElements(By.Id("applyRemainderLink")); } }
        public IWebElement PaymentTerms { get { return WebDriver.GetElement(By.XPath("//div[@id='lblnetTerms_payment_terms']/parent::div/div[2]")); } }
        public IWebElement InvalidCardNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Please enter valid Card Number')]")); } }
        public IWebElement GiftCardValidationMesage { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Gift Card Number or CID is invalid. Please re-enter.')]")); } }
        public IWebElement DormantStatusAlert { get { return WebDriver.GetElement(By.XPath("//p[@class='dds__alert-body']")); } }
        public IWebElement DormantNotificationMsg { get { return WebDriver.GetElement(By.XPath("//div[contains(@class,'dds__content-error')]")); } }
        public IWebElement TxtCurrentCustomerCustomerNumber { get { return WebDriver.GetElement(By.XPath("//span[@class='dds__h5']")); } }
        public IWebElement AddressAvailabilityNotification { get { return WebDriver.GetElement(By.XPath("//div[contains(@class,'dds__content-error')]")); } }
        public IWebElement CreditLimitNotificationMsg { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'The amount of your purchase exceeds your available credit.')]")); } }
        public IWebElement TxtAmtNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),' Amount entered cannot be $0.00. Please adjust your payment(s) to continue.')]")); } }
        public IWebElement OverDueCollectionsHold { get { return WebDriver.GetElement(By.XPath("//div[contains(@class,'dds__content-error')]")); } }
        #endregion
        #region Warriors_Elements
        public IWebElement ContinueButton { get { return WebDriver.GetElement(By.Id("ContinueLink")); } }
        public IWebElement PricingContinueBtn { get { return WebDriver.GetElement(By.Id("PaymentLink")); } }
        public IWebElement PaymentMethodsDropdown { get { return WebDriver.GetElement(By.Id("paymentOptions1")); } }
        public List<IWebElement> PaymentMethodsDropdown1 { get { return WebDriver.GetElements(By.Id("paymentOptions1")); } }
        public IWebElement AdjustPaymentLabel { get { return WebDriver.GetElement(By.XPath("//a[contains(text(), 'Apply remainder')]")); } }

        public IWebElement ApplyReminderLink { get { return WebDriver.GetElement(By.Id("applyRemainderLink")); } }
        public IWebElement NextPayForSubscriptionBtn { get { return WebDriver.GetElement(By.XPath("//button[contains(@class,'primary continue-btn')]")); } }
        public IWebElement NextPayForSubscriptionContinueBtn { get { return WebDriver.GetElement(By.Id("lblContinue")); } }
        public IWebElement QuickLeaseCompleteDFSBtn { get { return WebDriver.GetElement(By.XPath("//button[text()=' Complete DFS Information ']")); } }
        public IWebElement LnkRunCredit { get { return WebDriver.GetElement(By.Id("dpa_runCreditLink")); } }
        public IWebElement BtnCompleteDpaInformation { get { return WebDriver.GetElement(By.XPath("//button[text()=' Complete DFS Information ']")); } }
        public IWebElement TxtPoNumber { get { return WebDriver.GetElement(By.Id("paymentPoNo")); } }
        public IWebElement TxtPOMId { get { return WebDriver.GetElement(By.XPath("//div[text()='POM ID']/following-sibling::div/input")); } }
        public IWebElement DfsStatusLink { get { return WebDriver.GetElement(By.Id("dfsfinancialInfo_link")); } }
        public IWebElement DbcCreditStatus { get { return WebDriver.GetElement(By.Id("scc_dbcCreditStatus")); } }
        public IWebElement LeaseCreditStatus { get { return WebDriver.GetElement(By.Id("scc_leaseCreditStatus")); } }
        public IWebElement ViewDfsDetailsLink { get { return WebDriver.GetElement(By.Id("scc_viewDfsDetailsLink")); } }
        public IWebElement DellHomeIcon { get { return WebDriver.GetElement(By.Id("DellIcon")); } }
        public IWebElement ProcessingDfsCC { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'DFS credit check')]")); } }
        public IWebElement DfsEligibleNotification { get { return WebDriver.GetElement(By.XPath("//p[@class='dds__alert-body']")); } }
        public IWebElement AvailableCreditSection { get { return WebDriver.GetElement(By.XPath("//div[@class='dds__col-md-6']")); } }
        public IWebElement DfsIncompleteError { get { return WebDriver.GetElement(By.XPath("//dbc//div[contains(@class,'dds__content-error')]")); } }
        public IWebElement ChangeRemovePopupHeader { get { return WebDriver.GetElement(By.XPath("//dialog-component//h4")); } }
        public IWebElement ChangeRemovePopupText { get { return WebDriver.GetElement(By.XPath("//dialog-component//p")); } }
        public IWebElement ChangeRemovePopupContinueBtn { get { return WebDriver.GetElement(By.XPath("//dialog-component//button[contains(@class,'dds__btn-primary')]")); } }
        public IWebElement LnkSplitPayment1 { get { return WebDriver.GetElement(By.XPath("//*[@id='addPaymentMethodLink']")); } }
        public IWebElement LblAmount { get { return WebDriver.GetElement(By.Id("lbl_amount")); } }
        public List<IWebElement> TxtAmt { get { return WebDriver.GetElements(By.Id("txt_amount")); } }
        public List<IWebElement> TxtAmt1 { get { return WebDriver.GetElements(By.XPath("//*[@id='lbl_amount']")); } }
        public IWebElement PONumNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Enter valid purchase order number to continue')]")); } }
        public IWebElement PayAmtMismatchNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Your payment amount(s) do not match the order total. Please adjust your payment amounts to continue.')]")); } }
        public IWebElement DADropdown { get { return WebDriver.GetElement(By.XPath("//*[@id='dellAccounts']")); } }
        public IWebElement PONumber { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Invalid PO number.')]")); } }
        public IWebElement ErrorNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Some required information is missing or incomplete. Please provide the requested information.')]")); } }
        public IWebElement CCApprovedNotification { get { return WebDriver.GetElement(By.XPath("//*[@id='paymentContainer']/credit-card-payment/div/div/div[1]/div/div/div")); } }
        public IWebElement SplitpayNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Note: To use Split payment with Dell Advantage, add Dell Advantage as the second payment method.')]")); } }
        public IWebElement EnterGpid { get { return WebDriver.GetElement(By.XPath("//*[@id='txt_gpid']")); } }
        public IWebElement ErrorGpidNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Entered GPID is not valid. Please try with another GPID')]")); } }
        public IWebElement Gpid { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'GPID is required')]")); } }
        public IWebElement ExpGpidNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Entered GPID has expired. Please try with another GPID')]")); } }
        public IWebElement LVGpidNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Order amount is greater than the authorized amount on the card. Please select a different payment method to continue.')]")); } }
        public IWebElement CustomeronHold { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Net Terms Orders cannot be created as this Customer is on Collections Hold.')]")); } }
        public List<IWebElement> CompleteDFSInformationBtn { get { return WebDriver.GetElements(By.XPath("//*[contains(text(),'ContinueLink')]")); } }
        public IWebElement DABalance { get { return WebDriver.GetElement(By.XPath("//*[@id='paymentContainer']/dell-advantage/div/div[2]/div[2]/div[1]/div[2]")); } }
        public IWebElement EpsilonProfileID { get { return WebDriver.GetElement(By.XPath("//*[@id='paymentContainer']/dell-advantage/div/div[2]/div[2]/div[2]/div[2]")); } }
        public IWebElement DAAmtExceedsNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'The purchase amount exceeds the available balance on this account.')]")); } }
        public IWebElement DAAccountNANotifiction { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'No Dell advantage account available.')]")); } }
        public IWebElement DAAccount { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Select Dell Advantage account to continue')]")); } }
        public IWebElement CompleteDPAInfoBtn { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Complete DPA Information')]")); } }
        public IWebElement TPNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Third Party Funding is not available for the selected billing address.')]")); } }
        public IWebElement GCErrorNotification { get { return WebDriver.GetElement(By.XPath("//*[@id='txtGCNum']/following-sibling::div")); } }
        public IWebElement GCBalance { get { return WebDriver.GetElement(By.XPath("//*[@id='lblbalance']/following-sibling::div")); } }
        public IWebElement GCAmtExceedsNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'The amount of your purchase exceeds the available balance on the Gift Card.')]")); } }
        public IWebElement lblCreditLimit { get { return WebDriver.GetElement(By.Id("lblnetTerms_creditLimit")); } }
        public IWebElement lblRemaningbal { get { return WebDriver.GetElement(By.Id("lblnetTerms_remainingBalance")); } }

        public IWebElement NotifyDFSFinancing { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'customer may be eligible for DFS financing.')]")); } }

        #region Credit_Card_Elements
        public IWebElement NameOnCard { get { return WebDriver.GetElement(By.Id("txt_name_on_card")); } }
        public IWebElement CardNumber { get { return WebDriver.GetElement(By.Id("txt_creditcard_number")); } }
        public IWebElement ExpirationMonth { get { return WebDriver.GetElement(By.Id("expiration_month")); } }
        public IWebElement ExpirationYear { get { return WebDriver.GetElement(By.Id("expiration_year")); } }
        public IWebElement SecurityCode { get { return WebDriver.GetElement(By.Id("txt_security_code")); } }
        public IWebElement PhoneNumber { get { return WebDriver.GetElement(By.Id("txt_phone_number")); } }
        public IWebElement CardType { get { return WebDriver.GetElement(By.XPath("//div[text()='Type']//following-sibling::div/p")); } }
        #endregion

        #endregion



        #region POM
        public IWebElement UploadPOLink { get { return WebDriver.GetElement(By.XPath("//a[@id='po-upload-comp']")); } }
        public IWebElement PONumberLabel { get { return WebDriver.GetElement(By.XPath("//div[@id='poNumberLabel']")); } }
      //  public IWebElement UploadPOLink { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='Upload PO']")); } }
       // public IWebElement PONumberTextbox_Paymentpage { get { return WebDriver.GetElement(By.XPath("//input[@id='paymentPoNo']")); } }
        public IWebElement UploadAddendum { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='Upload Addendum']")); } }
        public IWebElement POMIdTextbox { get { return WebDriver.GetElement(By.XPath("//input[@placeholder='Enter POM ID']")); } }
        public IWebElement PONumberDateReceived { get { return WebDriver.GetElement(By.Id("mat-input-2")); } }
        public IWebElement pomidFieldLevel_Notification { get { return WebDriver.GetElement(By.XPath("//div[contains(@class,'dds__invalid-feedback ng-star-inserted')]")); } }
        public IWebElement pomidPageLevel_Notification { get { return WebDriver.GetElement(By.XPath("//p[@class='dds__alert-body']")); } }
        #endregion POM

        public void SelectPaymentType(String PaymentType)
        {
            PaymentMethodsDropdown.IsElementClickable(WebDriver, TimeSpan.FromSeconds(25));
            PaymentMethodsDropdown.PickDropdownByText(WebDriver, PaymentType);
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
        }

        public void SplitPaymentMethod(string PaymentType, int index)
        {
            //IWebElement splitPay = WebDriver.FindElement(By.XPath("//div[text()='Payment Method " + index + "']/following-sibling::div/select[@id='paymentOptions1']"));
            IWebElement splitPay = WebDriver.FindElement(By.XPath("//h3[text()='Payment Method " + index + "']/following-sibling::div//select[@id='paymentOptions1']"));
            splitPay.IsElementClickable(WebDriver, TimeSpan.FromSeconds(25));
            splitPay.PickDropdownByText(WebDriver, PaymentType);
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
        }
        public PCFPaymentsPage EnterSplitPayApplyRemainderAmt(string method, int index, string amount)
        {
            index = index - 1;
            IWebElement payCategory = WebDriver.FindElement(By.XPath("//" + method + "[" + index + "]" + "//*[@id='txt_amount']"));
            payCategory.IsElementClickable(WebDriver, TimeSpan.FromSeconds(10));
            payCategory.SendKeys(amount);
            return new PCFPaymentsPage(WebDriver);
        }
        public void SelectDellAdvantageAccount(string payMethod)
        {
            DADropdown.IsElementClickable(WebDriver, TimeSpan.FromSeconds(15));
            DADropdown.PickDropdownByText(WebDriver, payMethod);
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
        }
        
        public PCFPaymentsPage EnterGpidNo(string GPID)
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            EnterGpid.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(15));
            EnterGpid.SendKeys(GPID);
            return new PCFPaymentsPage(WebDriver);
        }

        public bool ValidateEditAmt(int index)
        {
            try
            {
                if (TxtAmt[index].GetAttribute("readonly").Equals(null))
                {
                    return true;
                }
            }
            catch (NullReferenceException)
            {
                return true;
            }
            return false;
        }

        public bool PaymentAmt1(int index)
        {
            try
            {
                TxtAmt1[index].SendKeys("123");
                
            }
            catch (ElementNotInteractableException)
            {
               
                return true;
            }
            return false;
        }


        public string ClickSplitPayApplyRemainder(string method, int index)
        {
            WebDriver.FindElement(By.XPath("//" + method + "//*[@id='applyRemainderLink']")).Click(WebDriver);
            return WebDriver.FindElement(By.XPath("//" + method + "[" + index + "]" + "//*[@id='txt_amount']")).GetText(WebDriver);             
        }

        public PCFOrderReviewPage EnterCreditCardDetails(String PaymentType, String cardHolderName, String cardNumber, String expirationMonth, String expirationYear, String securityCode, String phoneNumber)
        {
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            SelectPaymentType(PaymentType);
            NameOnCard.EnterText(WebDriver, cardHolderName,TimeSpan.FromSeconds(2));
            CardNumber.EnterText(WebDriver, cardNumber,TimeSpan.FromSeconds(2));
            ExpirationMonth.PickDropdownByText(WebDriver, expirationMonth);
            ExpirationYear.PickDropdownByText(WebDriver, expirationYear);
            SecurityCode.EnterText(WebDriver, securityCode, TimeSpan.FromSeconds(2));
            PhoneNumber.EnterText(WebDriver, phoneNumber,TimeSpan.FromSeconds(2));

            ContinueButton.Click(WebDriver);

            WebDriver.PCFVerifyBusyOverlayNotDisplayed();

            while (AdjustPaymentLabel.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5)))
            {
                ApplyReminderLink.Click();
                WebDriver.PCFVerifyBusyOverlayNotDisplayed();
                ContinueButton.Click(WebDriver);
            }

            return new PCFOrderReviewPage(WebDriver);
        }

        public T PCF_EnterCreditCardDetails<T>(string PaymentType, CreditCard card, ref string cardType)
        {
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            SelectPaymentType(PaymentType);
            NameOnCard.EnterText(WebDriver, card.NameOnCard, TimeSpan.FromSeconds(2));
            CardNumber.EnterText(WebDriver, card.CreditCardNumber, TimeSpan.FromSeconds(2));
            cardType = CardType.GetText(WebDriver);
            ExpirationMonth.PickDropdownByText(WebDriver, card.ExpirationMonth);
            ExpirationYear.PickDropdownByText(WebDriver, card.ExpirationYear);
            SecurityCode.EnterText(WebDriver, card.Cid, TimeSpan.FromSeconds(2));
            PhoneNumber.EnterText(WebDriver, card.PhoneNumber, TimeSpan.FromSeconds(2));

            ContinueButton.Click(WebDriver);
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();

            while (AdjustPaymentLabel.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5)))
            {
                ApplyReminderLink.Click();
                WebDriver.PCFVerifyBusyOverlayNotDisplayed();
                ContinueButton.Click(WebDriver);
            }

            var page = PageFactory.InitElements<T>(WebDriver);
            return page;
        }

        public PCFOrderReviewPage ClickCompleteDfsBtnEnterQuickLeaseDetails(string processMethod, bool clickContinue = true)
        {
            QuickLeaseCompleteDFSBtn.IsElementClickable(WebDriver, TimeSpan.FromSeconds(15));
            QuickLeaseCompleteDFSBtn.Click(WebDriver);

            while (AdjustPaymentLabel.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5)))
            {
                ApplyReminderLink.Click();
                WebDriver.PCFVerifyBusyOverlayNotDisplayed();
                QuickLeaseCompleteDFSBtn.Click(WebDriver);
            }

            new DfsPaymentPage(WebDriver).EnterQuickLeaseDetails(processMethod);
            PaymentMethodsDropdown.IsElementClickable(WebDriver, TimeSpan.FromSeconds(20));
            if (clickContinue)
            {
                ContinueButton.Click(WebDriver);
            }

            return new PCFOrderReviewPage(WebDriver);
        }

        public PCFOrderReviewPage ClickCompleteDfsBtnEnterDbcDetails(string lastName, string pin, bool continueClick = true)
        {
            QuickLeaseCompleteDFSBtn.IsElementClickable(WebDriver, TimeSpan.FromSeconds(15));
            QuickLeaseCompleteDFSBtn.Click(WebDriver);

            while (AdjustPaymentLabel.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5)))
            {
                ApplyReminderLink.Click();
                WebDriver.PCFVerifyBusyOverlayNotDisplayed();
                QuickLeaseCompleteDFSBtn.Click(WebDriver);
            }

            new DfsPaymentPage(WebDriver).EnterDbcDFsInformation(WebDriver, lastName, pin);
            PaymentMethodsDropdown.IsElementClickable(WebDriver, TimeSpan.FromSeconds(20));

            if (continueClick)
            {
                ContinueButton.Click(WebDriver);
            }

            return new PCFOrderReviewPage(WebDriver);
        }

        public DpaPaymentPage RunCredit()
        {
            DfsStatusLink.Click(WebDriver);
            LnkRunCredit.Click(WebDriver);
            while (AdjustPaymentLabel.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5)))
            {
                ApplyReminderLink.Click();
                WebDriver.PCFVerifyBusyOverlayNotDisplayed();
                LnkRunCredit.Click(WebDriver);
            }

            WebDriverUtil.WaitUntilUrlDisplay(WebDriver, "Consumer/DPA/DPACreditApp", 30);
            return new DpaPaymentPage(WebDriver);
        }

        public DpaPaymentPage CompleteDpaInformation()
        {
            PaymentMethodsDropdown.IsElementClickable(WebDriver, TimeSpan.FromSeconds(30));
            BtnCompleteDpaInformation.Click(WebDriver);
            while (AdjustPaymentLabel.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5)))
            {
                ApplyReminderLink.Click();
                WebDriver.PCFVerifyBusyOverlayNotDisplayed();
                QuickLeaseCompleteDFSBtn.Click(WebDriver);
            }

            return new DpaPaymentPage(WebDriver);
        }

        public void CheckforApplyReminder()
        {
            while (AdjustPaymentLabel.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5)))
            {
                ApplyReminderLink.PCFClick(WebDriver);
                WebDriver.PCFVerifyBusyOverlayNotDisplayed();
                ContinueButton.PCFClick(WebDriver);
            }
        }

        #region FT2
        public PCFOrderReviewPage PaymentContinue()
        {
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            ContinueButton.PCFClick(WebDriver);
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            return new PCFOrderReviewPage(webDriver);
        }

        public IPage PaymentMethodNext(bool flexBilling = false, bool? gammaTest = false)
        {
            ContinueButton.PCFClick(WebDriver);
            //CheckforApplyReminder(gammaTest);
            CheckforApplyReminder();
            webDriver.PCFVerifyBusyOverlayNotDisplayed();
            if (flexBilling)
                return new PCFSubscriptionBillingPage(WebDriver);
            return new PCFOrderReviewPage(WebDriver);
        }

        public void WaitForPaymentOptions()
        {
            while (!WebDriver.ElementExists(By.XPath("//div[text()='Payment Method 1']/following-sibling::div/select[@id='paymentOptions1']")))
            {
                //Do Nothing 
            }
        }

        #endregion

        #region Sparnans
        public PCFPaymentsPage ApplyReminder(int index)
        {
            SplitPayApplyReminderLink[index-1].PCFClick(WebDriver);
            return new PCFPaymentsPage(WebDriver);
        }

        public PCFPaymentsPage EnterPaymentAmount(int paymentMethodIndex, double amount)
        {
            var amountTextBox = Amount[paymentMethodIndex - 1];
            if (amountTextBox != null) amountTextBox.Clear();

            amountTextBox.SetText(WebDriver, amount.ToString(System.Globalization.CultureInfo.InvariantCulture));
            amountTextBox.SendKeys(Keys.Tab);
            return new PCFPaymentsPage(WebDriver);
        }

        public void EnterCreditCardDetails(IWebDriver driver, CreditCard creditCard)
        {
            var paymentpage = new PCFPaymentsPage(driver);
            paymentpage.NameOnCard.EnterText(driver, creditCard.NameOnCard, TimeSpan.FromSeconds(2));
            paymentpage.CardNumber.EnterText(driver, creditCard.CreditCardNumber, TimeSpan.FromSeconds(2));
            paymentpage.ExpirationMonth.PickDropdownByText(driver, creditCard.ExpirationMonth);
            paymentpage.ExpirationYear.PickDropdownByText(driver, creditCard.ExpirationYear);
            paymentpage.SecurityCode.EnterText(driver, creditCard.Cid, TimeSpan.FromSeconds(2));
            paymentpage.PhoneNumber.EnterText(driver, creditCard.PhoneNumber, TimeSpan.FromSeconds(2));
            if (FldCustomerReferenceNumber.Displayed)           
            {               
                    paymentpage.FldCustomerReferenceNumber.EnterText(driver, creditCard.CustomerReferenceNumber, TimeSpan.FromSeconds(2));                 
               
            }
        }

        public void EnterGiftCardDetails(IWebDriver driver, GiftCard giftCard)
        {
            var paymentpage = new PCFPaymentsPage(driver);
            paymentpage.GiftCardNumber.EnterText(driver, giftCard.CardNumber);
            paymentpage.GiftCardCID.EnterText(driver, giftCard.Cid);

        }
        public bool CheckIfPaymentMethodExists(string paymentMethod)
        {
            var isExist = false;
            var options = new SelectElement(PaymentMethodsDropdown).Options;
            isExist = options.Any(elem => elem.Text.ToLower() == paymentMethod.ToLower());

            return isExist;
        }
        
        public bool IsCreditLimitNotificationMsgDisplayed()
        {
            return CreditLimitNotificationMsg.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10));
        }

        public bool ValidateContinueButtons()
        {
            var cnts= WebDriver.GetElements(By.XPath("(//*[contains(@id,'ContinueLink')])"));
            foreach (var cnt in cnts)
            {
                if (!cnt.Enabled)
                {
                    return false;                    
                }
            }
            return true;
        }


        #endregion

        public PCFPaymentsPage EnterPurchaseOrderInfo(string poNum, string pomId)
        {
            TxtPoNumber.SetText(WebDriver, poNum);
            TxtPOMId.IsElementClickable(WebDriver, TimeSpan.FromSeconds(15));
            TxtPOMId.SetText(WebDriver, pomId);
            return new PCFPaymentsPage(WebDriver);
        }

        public PCFPaymentsPage PCFEnterPurchaseOrderInfo(string poNum, string pomId)
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            TxtPoNumber.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(15));            
            TxtPoNumber.SendKeys(poNum);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            TxtPOMId.IsElementClickable(WebDriver, TimeSpan.FromSeconds(15));           
            TxtPOMId.SendKeys(pomId);
            return new PCFPaymentsPage(WebDriver);
        }

        public string GetAddressAvailabilityNotification()
        {
            var addressAvailabilityNotification = AddressAvailabilityNotification.Text;
            return addressAvailabilityNotification;
        }
        public PCFSubscriptionBillingPage PaymentContinueSubscription()
        {
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            ContinueButton.PCFClick(WebDriver);
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            return new PCFSubscriptionBillingPage(webDriver);
        }

        public void WaitUntilPaymentComponentsLoad()
        {
            WebDriverUtil.WaitUntilUrlDisplay(WebDriver, "payment", 15);
            PaymentMethodsDropdown.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10));
        }

        public void VerifyIfDfsCreditCheckIsDone()
        {
            WebDriverUtil.WaitUntilElementDisappers(WebDriver, By.XPath("//label[contains(text(),'DFS credit check')]"), 15);
        }

        public bool IsLeasingNotEligibleNotificationDisplayed(string value)
        {
            return WebDriver.GetElement(By.XPath("//p[contains(text(),'" + value + "')]")).Displayed;
        }
        public void VerifyIfLeasePaymentsAreRemoved(string value)
        {
            SelectElement select = new SelectElement(PaymentMethodsDropdown);
            IList<IWebElement> list = select.Options;

            foreach (var item in list)
            {
                if (item.Text.Contains(value))
                {
                    Assert.Fail(value + "should be removed from Payment dropdown");
                }
            }            
        }

        public void validateListOfFieldsForPaymentMethod(IWebDriver driver, String PaymentMethod)
        {
            List<IWebElement> ExpectedElementsToBePresent = new List<IWebElement>();

            switch (PaymentMethod)
            {
                case "NetTerms":
                    //ExpectedElementsToBePresent = new List<IWebElement>();
                    ExpectedElementsToBePresent.Add(new ChannelPaymentPage(driver).LblPaymentMethod);
                    ExpectedElementsToBePresent.Add(new ChannelPaymentPage(driver).LblAmountTitle);
                    ExpectedElementsToBePresent.Add(lblCreditLimit);
                    ExpectedElementsToBePresent.Add(lblRemaningbal);

                    ExpectedElementsToBePresent.Add(new ChannelPaymentPage(driver).LblPaymentTerms);

                    break;
            }
            foreach (IWebElement elment in ExpectedElementsToBePresent)
            {
                bool elementAvailable = driver.TryFindElement(elment);
                Assert.IsTrue(elementAvailable);
            }


        }

        #region Voyagers

        public IWebElement orderTypes { get { return WebDriver.GetElement(By.Id("orderTypes")); } }

        public IList<IWebElement> OrderTypeList { get { return WebDriver.GetElements(By.Id("orderTypes")); } }

        public IWebElement ByLblSummarySubTotal { get { return WebDriver.GetElement(By.XPath("//div[@id='sub-total']/span[2]")); } }

        public IWebElement ByLblSummaryTotalShipping { get { return WebDriver.GetElement(By.XPath("//div[@id='total-shipping']/span[2]")); } }

        public IWebElement ByLblSummaryTotalTax { get { return WebDriver.GetElement(By.XPath("//div[@id='total-tax']/span[2]")); } }

        public IWebElement OrderSummaryFinalPrice { get { return WebDriver.GetElement(By.XPath("//div[@id='total']/span[2]")); } }

        public IList<IWebElement> RemovePayment { get { return WebDriver.GetElements(By.XPath("//a[contains(text(), 'Remove')]")); } }

        public IWebElement VoidAuthorizationPopup { get { return WebDriver.GetElement(By.XPath("//div[contains(@class,'ng-star-inserted')/following-sibling::div/div")); } }

        public IWebElement RemoveButtonVoidAuthorization { get { return WebDriver.GetElement(By.XPath("//button[contains(text(), 'Remove')]")); } }

        public IWebElement CancelButtonVoidAuthorization { get { return WebDriver.GetElement(By.XPath("//button[contains(text(), 'Cancel')]")); } }


        public void SelectOrderType(String OrderType)
        {
            orderTypes.IsElementClickable(WebDriver, TimeSpan.FromSeconds(25));
            orderTypes.PickDropdownByText(WebDriver, OrderType);
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
        }

        public void RemovePaymentmethod(int methodIndex)
        {
            RemovePayment[0].Click(WebDriver);
        }

        public void VoidAuthorization(string Value)
        {
            if (Value == "Yes")
                RemoveButtonVoidAuthorization.Click(WebDriver);
            else
                CancelButtonVoidAuthorization.Click(WebDriver);
        }


        #endregion Voyagers






    }
}
