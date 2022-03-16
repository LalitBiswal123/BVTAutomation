using System.Globalization;
using System.Linq;
using Dell.Adept.UI.Web.Pages;
using Dsa.DataModels;
using Dsa.Pages.Quote;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;
using System;
using OpenQA.Selenium.Support.UI;
using System.Configuration;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using System.Threading;

namespace Dsa.Pages.Order
{
    public class PaymentsPage : DsaPageBase
    {
        private const string PagePrefix = "payment";
        readonly TimeSpan _waitTime = TimeSpan.FromSeconds(150);


public IWebElement OrderTypeDropDown { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrder_orderType")); } }


public IWebElement PaymentMethodDropDown { get { return WebDriver.GetElement(By.XPath("//*[@id='cartPayment_method_type_']/form/select")); } }


public IWebElement PaymenNextBtn { get { return WebDriver.GetElement(By.Id("create_Order_Payment_Next")); } }


public IWebElement PaymentText { get { return WebDriver.GetElement(By.Id("create_order_amount_")); } }

public IWebElement LnkPomIdChange { get { return WebDriver.GetElement(By.XPath("//a[@data-ng-click='editPomId()']")); } }

public IWebElement PoNumberPatched { get { return WebDriver.GetElement(By.XPath("")); } }
public IWebElement PomIdPatched { get { return WebDriver.GetElement(By.XPath("")); } }


public IWebElement InvalidCardError { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-error']")); } }


public IWebElement VoidAuthorizationPopup { get { return WebDriver.GetElement(By.Id("MessageBoxTitle")); } }

        public PaymentsPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        public QuoteSummary Summary
        {
            get
            {
                return new QuoteSummary(WebDriver, PagePrefix);
            }
        }

        #region Elements


public IWebElement LnkCurrentCustomerCompanyName { get { return WebDriver.GetElement(By.Id("currentCustomer_createCustomerHeaderLink1")); } }


public IWebElement LnkUploadPOPayment { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderPayment_UploadPo")); } }


public IWebElement LnkCurrentCustomerCustomerName { get { return WebDriver.GetElement(By.Id("currentCustomer_createCustomerHeaderLink2")); } }


public IWebElement TxtCurrentCustomerCustomerNumber { get { return WebDriver.GetElement(By.Id("currentCustomer_customerNumber")); } }


public IWebElement TxtCurrentCustomerCompanyNumber { get { return WebDriver.GetElement(By.Id("currentCustomer_context")); } }
      


public IWebElement LnkAddPaymentMethod { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderPayment_addPayment")); } }


public IWebElement LnkDeletePayment { get { return WebDriver.GetElement(By.Id("delete_payment_method")); } }



public IWebElement BtnVoidSucess { get { return WebDriver.GetElement(By.Id("messageDialogButton_0")); } }

        //[FindsBy(How = How.XPath, Using = "//button[normalize-space()='Next']")]
        //public IWebElement BtnPaymentMethodNext;
        public IWebElement BtnPaymentMethodNext { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='Next']")); } }


public IWebElement TxtPoNumber { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderPayment_poNumber")); } }

        //[FindsBy(How = How.Id, Using = "quoteSaveAsOrderPayment_poNumber")]
        //public IWebElement TxtNumber { get; set; }



public IWebElement Txt { get { return WebDriver.GetElement(By.ClassName("col-sm-6")); } }
        


public IWebElement TxtPOMId { get { return WebDriver.GetElement(By.XPath("//span[@data-ng-if='model.isPomIdAttached']")); } }


public IWebElement PONumberReceivedDate { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderPayment_poNumberReceivedDate")); } }


public IWebElement BtnCancel { get { return WebDriver.GetElement(By.Id("create_Order_Payment_Cancel")); } }


public IWebElement LnkRunCredit { get { return WebDriver.GetElement(By.Id("RunCredit")); } }


public IWebElement LnkSearchForExistingAccount { get { return WebDriver.GetElement(By.Id("SearchExistingAccount")); } }


public IWebElement BtnCompleteDpaInformation { get { return WebDriver.GetElement(By.Id("creatOrder_dpaInformation")); } }


public IWebElement PaymentValidationMsg { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderPayment_orderAmountErrorMessage")); } }


public IWebElement DdlOrderType { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrder_orderType")); } }


public IWebElement TxtOriginalOrderNumber { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrder_originalOrderNumber")); } }


public IWebElement TxtDpsNumber { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrder_dpsNumber")); } }


public IWebElement DdlReasonCode { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrder_reasonCode")); } }


public IWebElement PaymentMethodsDiv { get { return WebDriver.GetElement(By.ClassName("add-payment-method")); } }


public IWebElement PaymentTerms { get { return WebDriver.GetElement(By.Id("payment_netTerms_paymentTerm")); } }


public IWebElement NetTermPaymenttTerms { get { return WebDriver.GetElement(By.Id("payment_netTerms_term")); } }


public IWebElement BtnCompleteDfsInformation { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderPayment_dbcLink")); } }


public IWebElement BtnCompleteQuickLeaseInformation { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderPayment_quickLeaseLink")); } }


public IWebElement CustomerReferenceNumberTxt { get { return WebDriver.GetElement(By.Id("cart_payments_card_address_refnumber")); } }


public IWebElement LnkAddPomId { get { return WebDriver.GetElement(By.CssSelector("#_pomId > span:nth-child(2) > span:nth-child(1) > a:nth-child(1)")); } }


public IWebElement pomidFieldLevel_Notification { get { return WebDriver.GetElement(By.XPath("//div[@id='_pomId']/div/span")); } }



public IWebElement pomidPageLevel_Notification { get { return WebDriver.GetElement(By.XPath("//div[@id='create_order_validation_invalidPomId']/p")); } }


public IWebElement TxtPomId { get { return WebDriver.GetElement(By.Id("pom_id")); } }


public IWebElement LnkChangePomid { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderPayment_Change")); } }


public IWebElement TxtOrderNumber { get { return WebDriver.GetElement(By.Id("cartPayment_orderNumber")); } }


public IWebElement TxtComments { get { return WebDriver.GetElement(By.Id("cartPayment_comments")); } }

        //[FindsBy(How = How.Id, Using = "payments_link")]
        //public IWebElement ApplyPaymentReminder;
        public IWebElement ApplyPaymentReminder { get { return WebDriver.GetElement(By.Id("payments_link")); } }


public IWebElement ApplyremiderMessage { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteSaveAsOrderPayment_orderAmountErrorMessage'][contains(text(), 'clicking Apply Remainder')]")); } }


public IWebElement ApplyremiderMessage2 { get { return WebDriver.GetElement(By.XPath("(//*[@id='payments_link'])[2]")); } }


public IWebElement ThirdPartyFunder { get { return WebDriver.GetElement(By.Id("payment_thirdPartyFunding_funder")); } }


public IList<IWebElement> ThirdPartyFunderList { get { return WebDriver.GetElements(By.XPath("//*[@id='payment_thirdPartyFunding_funder']/option")); } }


public IWebElement ThirdPartyFunderRelationshipErrorMessage { get { return WebDriver.GetElement(By.CssSelector("div.alert:nth-child(4)")); } }


public IWebElement ThirdPartyFunding_PaymentType { get { return WebDriver.GetElement(By.Id("payment_thirdPartyFunding_ThirdPartyType")); } }


public IWebElement ThirdPartyFunding_PaymentMethod { get { return WebDriver.GetElement(By.CssSelector("#cartPayment_method_type_ > form > select")); } }


public IWebElement LstPaymentOptions { get { return WebDriver.GetElement(By.XPath("//*[@id='cartPayment_method_type_']/form/select")); } }


public IWebElement TotalTax { get { return WebDriver.GetElement(By.Id("summary_totalTaxAmount")); } }


public IWebElement OrderSummaryFinalPrice { get { return WebDriver.GetElement(By.Id("payment_summary_finalPrice")); } }


public IWebElement DivExchangeOrderValidationMessage { get { return WebDriver.GetElement(By.Id("createOrderPayment_exchangeOrderValidationMessage")); } }


public IWebElement ChkEnterGpid { get { return WebDriver.GetElement(By.Id("gama_gpid_Order_Creation")); } }


public IWebElement ChkRecurringPayment { get { return WebDriver.GetElement(By.Id("gama_Order_Creation")); } }


public IWebElement DivGammaOrderError { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderPayment_GammaorderErrorSection")); } }


public IWebElement TxtGpid { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderPayment_gpid")); } }


public IWebElement LblGpidCardType { get { return WebDriver.GetElement(By.XPath("//*[@data-c-for='cartPayment_cardType']/following-sibling::div")); } }
        

public IWebElement FunderName { get { return WebDriver.GetElement(By.Id("payment_thirdPartyFunding_funder")); } }


public IWebElement AddPOLink { get { return WebDriver.GetElement(By.XPath(".//*[@id='_pomId']/descendant::a")); } }


public IWebElement GiftCardBalance { get { return WebDriver.GetElement(By.Id("payment_giftCard_balance")); } }


public IWebElement GiftCardValidationMesage { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Failed to retrieve gift card balance:')]")); } }


public IWebElement TxtGiftCardNumber { get { return WebDriver.GetElement(By.Id("cartPayment_ccNumber")); } }


public IWebElement TxtPaymentAmount { get { return WebDriver.GetElement(By.Id("create_order_amount_")); } }


public IWebElement PaymentPageMessageBoxTitle { get { return WebDriver.GetElement(By.Id("MessageBoxTitle")); } }


public IWebElement PaymentPageMessagedialogOKButton { get { return WebDriver.GetElement(By.Id("messageDialogButton_0")); } }


public IWebElement ThirPartyPayType { get { return WebDriver.GetElement(By.Id("payment_thirdPartyFunding_ThirdPartyType")); } }


public IWebElement lstThirdPartyFunder { get { return WebDriver.GetElement(By.Id("payment_thirdPartyFunding_funder")); } }


public IWebElement LblPaymentonPaymentPage { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteSaveAsOrderStepProgess_stepName']")); } }


public IWebElement LblNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Card number not valid (Payment Method 1),')]")); } }


public IWebElement DellAdvantageAccountddl { get { return WebDriver.GetElement(By.Id("payment_dell_advantage_account")); } }


public IWebElement AddressAvailabilityNotification { get { return WebDriver.GetElement(By.Id("create_order_address_availability_message")); } }


public IWebElement PromotionLnk { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'_D_Promos_')]")); } }


public IWebElement ViewDFSdetails { get { return WebDriver.GetElement(By.XPath("//a[@data-ng-click='vm.viewDfsDetails()']")); } }


public IWebElement ViewDFSError { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-warning error']")); } }

public IWebElement OpDfsErrorMessage { get { return WebDriver.GetElement(By.XPath("//div[@data-ng-repeat='errorMessage in vm.dfsInformationErrorMessages']")); } }

public IWebElement ConsumerViewDFSdetails { get { return WebDriver.GetElement(By.Id("consumerDfsDetails")); } }


public IWebElement DALimitExceedNotificationMsg { get { return WebDriver.GetElement(By.XPath("(//div[contains(text(),'The amount of your purchase exceeds the available balance on the Dell Advantage Account. Please add another payment method.')])")); } }


public IWebElement CreditLimitNotificationMsg { get { return WebDriver.GetElement(By.XPath("(//span[contains(text(),'The amount of your purchase exceeds your available credit. Please choose another payment method.')])")); } }


public IWebElement DormantNotificationMsg { get { return WebDriver.GetElement(By.XPath("(//span[contains(text(),'credit status is dormant.')])")); } }


public IWebElement OTBNotificationMsg { get { return WebDriver.GetElement(By.XPath("//*[@id='dfsSmbMessages']//div/ul/li[2]")); } }


public IWebElement FSRNumber { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrder_FsrNumber")); } }


public IWebElement DellAdvantageAccountSec { get { return WebDriver.GetElement(By.ClassName("smry-ctnr")); } }

public IWebElement AddLink { get { return WebDriver.GetElement(By.XPath("//a[@data-ng-click='addPomId()']")); } }
public IWebElement PomIdTextBox { get { return WebDriver.GetElement(By.XPath("//*[@id='pom_id']")); } }
public IWebElement PomIdFieldLevelError { get { return WebDriver.GetElement(By.XPath("//span[@class='invalid-input']")); } }
public IWebElement POMidPatched { get { return WebDriver.GetElement(By.XPath("//div[@id='_pomId']//span/span")); } }
public IWebElement POMidChangeLnk { get { return WebDriver.GetElement(By.XPath("//div[@id='_pomId']//span/span/a")); } }


public IWebElement NTCustomerHold { get { return WebDriver.GetElement(By.Id("validation_customercreditstatus")); } }


public IList<IWebElement> DeletePaymentMethod { get { return WebDriver.GetElements(By.XPath("//i[@id='delete_payment_method']")); } }


public IWebElement YesButton { get { return WebDriver.GetElement(By.XPath("//button[contains(text(), 'Yes')]")); } }


public IWebElement NoButton { get { return WebDriver.GetElement(By.XPath("//button[contains(text(), 'No')]")); } }


public IWebElement OrderType { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrder_orderType")); } }


public IList<IWebElement> OrderTypeList { get { return WebDriver.GetElements(By.Id("quoteSaveAsOrder_orderType")); } }

public IWebElement SnowRequestID { get { return WebDriver.FindElement(By.Id("quoteSaveAsOrder_snowRequestId"), TimeSpan.FromSeconds(10)); } }
public IWebElement LeBuCc { get { return WebDriver.FindElement(By.XPath("//label[contains(text(),'LE/BU/CC:')]//parent::div/div/input"), TimeSpan.FromSeconds(10)); } }
public IWebElement InvalidSnowRequestID { get { return WebDriver.FindElement(By.XPath("//div[@id='createOrderPayment_snowRequestValidationMessage']/p"), TimeSpan.FromSeconds(10)); } }



        #endregion

        #region Methods

        //  public PaymentsPage EnterPONumber(int PO_No)
        //    {

        //  return new PaymentsPage(webDriver);
        //}
        public bool IsAddPaymentReminder()
        {
            if (ApplyremiderMessage.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
            {
                return ApplyPaymentReminder.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10));
            }
            else
            {
                return false;

            }
        }

        public PaymentsPage DblGetPaymentMethod(string PaymentMethod)
        {
            ThirdPartyFunding_PaymentMethod.WaitForElement(WebDriver);
            ThirdPartyFunding_PaymentMethod.PickDropdownByText(WebDriver, PaymentMethod);
            return new PaymentsPage(WebDriver);
        }

       

        public PaymentsPage EditPayment()
        {
            LnkDeletePayment.WaitForElement(WebDriver);
            LnkDeletePayment.Click();
            new PaymentsPage(WebDriver).ApplyRemainderAmount(1);

            return new PaymentsPage(WebDriver);
        }

        public PaymentsPage DblGetPaymentType(string PaymentType)
        {
            ThirdPartyFunding_PaymentType.WaitForElement(WebDriver);
            ThirdPartyFunding_PaymentType.PickDropdownByText(WebDriver, PaymentType);
            return new PaymentsPage(WebDriver);
        }

        public DpaPaymentPage RunCredit()
        {
            LnkRunCredit.Click(WebDriver);
            WebDriverUtil.WaitUntilUrlDisplay(WebDriver, "Consumer/DPA/DPACreditApp", 30);
            return new DpaPaymentPage(WebDriver);
        }

        public DpaPaymentPage SearchForExistingAccount()
        {
            LnkSearchForExistingAccount.Click(WebDriver);
            return new DpaPaymentPage(WebDriver);
        }

        public DpaPaymentPage CompleteDpaInformation()
        {
            BtnCompleteDpaInformation.Click(WebDriver);
            if (ApplyPaymentReminder.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
            {
                new PaymentsPage(WebDriver).ApplyRemainderAmount(1);
                BtnCompleteDpaInformation.Click(WebDriver);
            }
            return new DpaPaymentPage(WebDriver);
        }

        public IWebElement GetPaymentMethodSectionByIndex(int paymentMethodIndex)
        {
            return WebDriver.GetElements(By.XPath("//*[contains(@class,'add-payment-method')]/div/div"))[paymentMethodIndex - 1];
            //return WebDriver.GetElements(By.XPath("//*[@id='create_order_amount_']"))[paymentMethodIndex - 1];
           // return WebDriver.GetElements(By.XPath("//div[@class ='add-payment-method']"))[paymentMethodIndex - 1];
        }

        public PaymentsPage DblGetFunderType(string FunderType)
        {
            ThirdPartyFunding_PaymentType.PickDropdownByText(WebDriver, FunderType);

            return new PaymentsPage(WebDriver);
        }


        //
        //*[@id="quoteSaveAsOrder_orderType"]/option[5]


        //
        //*[@id="cartPayment_method_type_"]/form/select/option[7]

        public IWebElement OrderTypeMethod(int OrderMethodIndex)
        {
            return
            //*[@id="quoteSaveAsOrder_orderType"]/option[5]
           // WebDriver.GetElement(By.XPath("//[@id='quoteSaveAsOrder_orderType']/option[" + OrderMethodIndex + "]"));
            WebDriver.GetElement(By.XPath("(//*[@id='quoteSaveAsOrder_orderType'])"));

        }
        public IWebElement PaymentMethodDdl(int paymentMethodIndex)
        {

            return
                WebDriver.GetElement(By.XPath("(//*[@id='cartPayment_method_type_'])[" + paymentMethodIndex + "]/form/select"));

        }

        public IWebElement PaymentMethodAfterDFSredirect(int paymentMethodIndex)
        {
            return
                WebDriver.GetElement(By.XPath("(//*[@id='cartPayment_method_type_'])[" + paymentMethodIndex + "]/form/span"));

        }

        public IWebElement EditPayment(int editpaymentdIndex)
        {
            return WebDriver.GetElements(By.XPath("//*[contains(., 'Edit Payment'])"))[editpaymentdIndex - 1];
        }
       

        public IWebElement PaymentAmount(int paymentamountIndex = 1)
        {

            return WebDriver.GetElements(By.XPath("(//*[contains(@id,'_amount')])"))[paymentamountIndex - 1];
        }



        public IWebElement DdlDellAdvantageAccount(int dAAccountIndex)
        {
            return WebDriver.GetElement(By.XPath("(//*[@id='payment_dell_advantage_account'])[" + dAAccountIndex + "]"));
        }
        public int DdlDellAdvantageAccountCount()
        {
            IWebElement selectOptions = WebDriver.GetElement(By.XPath("(//*[@id='payment_dell_advantage_account'])"));

            SelectElement dropDown = new SelectElement(selectOptions);
            IList<IWebElement> elements = dropDown.Options;
            return elements.Count;

           // return WebDriver.GetElements(By.XPath("(//*[@id='payment_dellAdvantage_paymentTerm']/select)")).Count();
        }


        public double SelectDellAdvantageAccount(IWebDriver driver, int index)
        {            
           var accountBalance = 0.0;
            var indexDA = 1;
            var count = DdlDellAdvantageAccountCount();
            while (indexDA <= count)
            {
                DdlDellAdvantageAccount(index).PickDropdownByIndex(WebDriver, indexDA);
                //var count = DdlDellAdvantageAccountCount();
                accountBalance = new PaymentsPage(WebDriver).GetDABalance(1);
                if (accountBalance != 0)
                {
                    break;
                }
                else
                {
                    if (count != 1)
                    {
                        indexDA += 1;
                    }
                    else
                    {
                        break;
                    }
                }                   
               
            }

            var finalPrice = new PaymentsPage(WebDriver).GetFinalPrice();

            var remainingDABalance = Math.Round((accountBalance - finalPrice), 2);
            Logger.Write("Remaining balance on DA is: " + remainingDABalance.ToString());
            return remainingDABalance;
        }

        public double ReadBalance()
        {
            var accountBalance = 0.0;            
            accountBalance = new PaymentsPage(WebDriver).GetDABalance(1);
            var finalPrice = new PaymentsPage(WebDriver).GetFinalPrice();

            var remainingDABalance = Math.Round((accountBalance - finalPrice), 2);
            Logger.Write("Remaining balance on DA is: " + remainingDABalance.ToString());
            return remainingDABalance;
        }

        public IWebElement LblDellAdvantageEmail(int DAemailIndex)
        {
            return WebDriver.GetElement(By.XPath("(//*[@id='payment_dellAdvantage_email'])[" + DAemailIndex + "]"));
        }

        public IWebElement LblDellAdvantageProfileId(int ProfileIndex)
        {
            return WebDriver.GetElement(By.XPath("(//*[@id='payment_dellAdvantage_epsilonProfileId'])[" + ProfileIndex + "]"));
        }

        public IWebElement LblDAaccountbalance(int DAaccountbalanceIndex)
        {
            return WebDriver.GetElement(By.XPath("(//*[@id='payment_dellAdvantage_balance'])"));
        }

        public OrderReviewPage GoToReviewOrderPage()
        {
            BtnPaymentMethodNext.Click(WebDriver);
            return new OrderReviewPage(WebDriver);
        }

        public PaymentsPage SelectFirstPaymentMethod(string paymentMethod)
        {
            PaymentMethodDdl(1).PickDropdownByText(WebDriver, paymentMethod);
            return new PaymentsPage(WebDriver);
        }

        public IPage PaymentMethodNext(bool flexBilling = false,bool? gammaTest=false)
        {
            WebDriverUtil.ScrollToBottom(WebDriver);
            BtnPaymentMethodNext.WaitForElementVisible(_waitTime);
            BtnPaymentMethodNext.Click(WebDriver);
            CheckforApplyReminder(gammaTest);
            if (flexBilling)
                return new FlexBillingRenewalPage(WebDriver);
            return new OrderReviewPage(WebDriver);
        }

        public OrderReviewPage CheckforApplyReminder(bool? gammaTest = false)
        {
            if (ApplyPaymentReminder.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
            {
                if (gammaTest == false)
                {
                    new PaymentsPage(WebDriver).ApplyRemainderAmount(1).BtnPaymentMethodNext.WaitForElement(WebDriver);
                }
                else
                {
                    ApplyPaymentReminder.Click();
                }
                WebDriverUtil.ScrollToBottom(WebDriver);
                BtnPaymentMethodNext.Click(WebDriver);
            }

            return new OrderReviewPage(WebDriver);
        }

        public PaymentsPage EnterPaymentAmount(int paymentMethodIndex, double amount)
        {
            var amountTextBox = GetPaymentMethodSectionByIndex(paymentMethodIndex).FindElements(By.TagName("input"))
                .FirstOrDefault(a => a.GetAttribute("id").Contains("amount"));
            if (amountTextBox != null) amountTextBox.Clear();

            amountTextBox.SetText(WebDriver, amount.ToString(CultureInfo.InvariantCulture));

            return new PaymentsPage(WebDriver);
        }

        public String GetPaymentAmount(int paymentMethodIndex)
        {
            var amountTextBox = GetPaymentMethodSectionByIndex(paymentMethodIndex).FindElements(By.TagName("input"))
                .FirstOrDefault(a => a.GetAttribute("id").Contains("amount"));

            return amountTextBox.GetText(WebDriver);
        }

        public PaymentsPage SelectCreditCardType(int paymentMethodIndex, string cardType)
        {
            GetPaymentMethodSectionByIndex(paymentMethodIndex).FindElements(By.TagName("select"))
                .FirstOrDefault(a => a.GetAttribute("id").Contains("cardType"))
                .PickDropdownByText(WebDriver, cardType);

            return new PaymentsPage(WebDriver);
        }

        public PaymentsPage ApplyRemainderAmount(int paymentMethodIndex, bool? paymentMethod1IndexOnly=false)
        {
            // When Amount text box value is empty or equals $0.00, it does not apply remainder.
            // Therefore, changing the text to 1 and then applying remainder
            var amountTextBox = GetPaymentMethodSectionByIndex(paymentMethodIndex).FindElements(By.TagName("input"))
                .FirstOrDefault(a => a.GetAttribute("id").Contains("amount"));
            if (amountTextBox != null)
            {
                amountTextBox.Clear();
                amountTextBox.SendKeys("1");
            }            
           
            if (paymentMethod1IndexOnly.Value==true)
            {
                GetPaymentMethodSectionByIndex(1).FindElement(By.Id("payments_link")).Click(WebDriver);
            }
            else
            {               
                GetPaymentMethodSectionByIndex(paymentMethodIndex).FindElement(By.Id("payments_link")).Click(WebDriver);               
            }
            if(ApplyPaymentReminder.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
                GetPaymentMethodSectionByIndex(paymentMethodIndex).FindElement(By.Id("payments_link")).Click(WebDriver);

            return new PaymentsPage(WebDriver);
        }        

        public PaymentsPage EnterNameOnCard(int paymentMethodIndex, string nameOnCard)
        {
            GetPaymentMethodSectionByIndex(paymentMethodIndex)
                .FindElement(By.Id("cartPayment_nameOnCard"))
                .SetText(WebDriver, nameOnCard);
            return new PaymentsPage(WebDriver);
        }

        public PaymentsPage EnterCreditCardNumber(int paymentMethodIndex, string cardNumber)
        {
            GetPaymentMethodSectionByIndex(paymentMethodIndex)
                .GetChildElement(By.Id("cartPayment_ccNumber"))
                .SetText(WebDriver, cardNumber);
            return new PaymentsPage(WebDriver);
        }

        public PaymentsPage EnterCreditCardExpiration(int paymentMethodIndex, string month, string year)
        {
            GetPaymentMethodSectionByIndex(paymentMethodIndex)
                .FindElement(By.Id("cartPayment_expirationYear"))
                .PickDropdownByText(WebDriver, year);
            GetPaymentMethodSectionByIndex(paymentMethodIndex)
                .FindElement(By.Id("cartPayment_expirationMonth"))
                .PickDropdownByText(WebDriver, month);
            return new PaymentsPage(WebDriver);
        }

        public PaymentsPage EnterCreditCardCid(int paymentMethodIndex, string cid)
        {
            GetPaymentMethodSectionByIndex(paymentMethodIndex)
                .FindElement(By.Id("cartPayment_cid"))
                .SetText(WebDriver, cid);
            return new PaymentsPage(WebDriver);
        }

        public PaymentsPage EnterCreditCardPhoneNumber(int paymentMethodIndex, string phone)
        {
            GetPaymentMethodSectionByIndex(paymentMethodIndex)
                .FindElement(By.Id("cartPayment_phone"))
                .SetText(WebDriver, phone);
            return new PaymentsPage(WebDriver);
        }

        public string GetCreditCardType(int paymentMethodIndex)
        {
            return GetPaymentMethodSectionByIndex(paymentMethodIndex)
                .FindElement(By.XPath("//*[@id='payment_creditcard_type']/..")).GetText(WebDriver);
        }

        public PaymentsPage EnterCustomerReferenceNumber(int paymentMethodIndex, string custRefNum = "")
        {
            if (!String.IsNullOrEmpty(custRefNum))
            {
                GetPaymentMethodSectionByIndex(paymentMethodIndex)
                    .FindElement(By.Id("cart_payments_card_address_refnumber"))
                    .SetText(WebDriver, custRefNum);
            }
            return new PaymentsPage(WebDriver);
        }

        public PaymentsPage EnterChargeDesciption(int paymentMethodIndex, string chargeDesc = "")
        {
            if(!String.IsNullOrEmpty(chargeDesc))
            {
                GetPaymentMethodSectionByIndex(paymentMethodIndex)
                .FindElement(By.Id("cart_payments_card_address_chargeDescription"))
                .SetText(WebDriver, chargeDesc);
            }
            return new PaymentsPage(WebDriver);
        }

        public void EnterCreditCardDetails(IWebDriver driver, int paymentMethodIndex, CreditCard card)
        {
            new PaymentsPage(driver)
                .EnterCreditCardNumber(paymentMethodIndex, card.CreditCardNumber)
                .EnterNameOnCard(paymentMethodIndex, card.NameOnCard)
                .EnterCreditCardExpiration(paymentMethodIndex, card.ExpirationMonth, card.ExpirationYear)
                .EnterCreditCardCid(paymentMethodIndex, card.Cid)
                .EnterCreditCardPhoneNumber(paymentMethodIndex, card.PhoneNumber);
            if(driver.FindElements(By.Id("cart_payments_card_address_refnumber")).Count>1)
            {
                var indexes = driver.FindElements(By.Id("cart_payments_card_address_refnumber")).Count;
                if (driver.FindElements(By.Id("cart_payments_card_address_refnumber"))[indexes - 1].Displayed)
                {
                    new PaymentsPage(driver)
                    .EnterCustomerReferenceNumber(paymentMethodIndex, card.CustomerReferenceNumber);
                }
            }
            else
            {
                if (driver.FindElement(By.Id("cart_payments_card_address_refnumber")).Displayed)
                {
                    new PaymentsPage(driver)
                    .EnterCustomerReferenceNumber(paymentMethodIndex, card.CustomerReferenceNumber);
                }
            }            
            if (driver.FindElement(By.Id("cart_payments_card_address_chargeDescription")).Displayed)
            {
                new PaymentsPage(driver)
                    .EnterChargeDesciption(paymentMethodIndex, card.ChargeDescription);
            }
        }

        public void EnterGiftCardDetails(IWebDriver driver, int paymentMethodIndex, GiftCard card)
        {
            new PaymentsPage(driver)
                .EnterCreditCardNumber(paymentMethodIndex, card.CardNumber)
                .EnterCreditCardCid(paymentMethodIndex, card.Cid);
        }

        public IWebElement lblCustomerReferenceNumberValidation()
        {
            return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Customer Reference Number:')]"));
        }

        public IWebElement lblChargeDescriptionValidation()
        {
            return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Charge Description:')]"));
        }

        public ReadOnlyCollection<IWebElement> pUpCorporateValidation()
        {
            return WebDriver.FindElements(By.ClassName("popover-content"));

        }

        public IWebElement pUpCustomerReferenceNumberValidation()
        {
            return WebDriver.GetElement(By.XPath("//*[contains(text(),'Please Enter a Corporate Card Identifier')]"));
        }

        public IWebElement pUpChargeDescriptionValidation()
        {
            return WebDriver.GetElement(By.XPath("//*[contains(text(),'Please enter a valid Charge Description')]"));
        }

        public string GetPaymentValidationNotificationMsg()
        {
            if (PaymentValidationMsg.Displayed)
            {
                return PaymentValidationMsg.GetText(WebDriver);

            }
            return null;
        }

        public DfsPaymentPage CompleteDfsInformation()
        {            
            BtnCompleteDfsInformation.Click(WebDriver);
            if (ApplyPaymentReminder.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
            {
                new PaymentsPage(WebDriver).ApplyRemainderAmount(1);
                BtnCompleteDfsInformation.Click(WebDriver);
            }
            return new DfsPaymentPage(WebDriver);
        }

        public DfsPaymentPage CompleteQuickLeaseDfsInformation()
        {
            BtnCompleteQuickLeaseInformation.Click(WebDriver);
            return new DfsPaymentPage(WebDriver);
        }
        public PaymentsPage EnterPurchaseOrderNumber(string poNum)
        {
            TxtPoNumber.SetText(WebDriver, poNum);
            LnkAddPomId.Click(WebDriver);
           //TxtPomId.SetText(WebDriver, pomId);
            PONumberReceivedDate.SendKeys(Keys.Tab);
            return new PaymentsPage(WebDriver);
        }

        public PaymentsPage RemovePONumber()
        {
            TxtPoNumber.Clear();
            return new PaymentsPage(WebDriver);
        }


        public PaymentsPage EnterPurchaseOrderInfo(string poNum, string pomId)
        {
            TxtPoNumber.SetText(WebDriver, poNum);
            LnkAddPomId.Click(WebDriver);
            TxtPomId.SetText(WebDriver, pomId);
            PONumberReceivedDate.SendKeys(Keys.Tab);
            return new PaymentsPage(WebDriver);
        }

        public PaymentsPage S(string poNum, string pomId)
        {
            TxtPoNumber.SetText(WebDriver, poNum);
            LnkAddPomId.Click(WebDriver);
            TxtPomId.SetText(WebDriver, pomId);
            PONumberReceivedDate.SendKeys(Keys.Tab);
            return new PaymentsPage(WebDriver);
        }

        public string GetPoNumber()
        {
            TxtPoNumber.SendKeys(Keys.Tab);

            return TxtPoNumber.GetText(WebDriver); 
            
        }

        public string GetPOMID()
        {
            return TxtPOMId.GetText(WebDriver);
        }


        public PaymentsPage EnterOrderNumComments(string orderNumber, string comments)
        {
            TxtOrderNumber.SetText(WebDriver, orderNumber);
            TxtComments.SetText(WebDriver, comments);

            return new PaymentsPage(WebDriver);
        }

        public PaymentsPage SelectAFunder(string Funder)
        {
            ThirdPartyFunder.PickDropdownByText(WebDriver, Funder);
            return new PaymentsPage(WebDriver);
        }

        public int FunderDropdownCount()
        {            
            return ThirdPartyFunderList.Count();
        }

        public PaymentsPage SetPO_POMID(string ponum,string pomid)
        {
            TxtPoNumber.SetText(WebDriver,ponum);
            AddPOLink.IsElementClickable(WebDriver);
            AddPOLink.Click();
            TxtPomId.SetText(WebDriver,pomid);
            return new PaymentsPage(WebDriver);
        }
        
        public PaymentsPage PaymentPageIncorrectMessagepopup(IWebDriver driver)
        {
            if(PaymentPageMessageBoxTitle.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
                PaymentPageMessagedialogOKButton.Click(driver);
            return new PaymentsPage(WebDriver);
        }

        public PaymentsPage CheckforApplyReminder2()
        {
            if (ApplyremiderMessage2.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
            {
                ApplyremiderMessage2.Click(WebDriver);
            }

            return new PaymentsPage(WebDriver);
        }

        /// <summary>
        /// Checks if the provided payment method exists in payment method dropdown.
        /// </summary>
        /// <param name="paymentMethod">The type of payment.</param>
        /// <returns>True/False</returns>
        public bool CheckIfPaymentMethodExists(string paymentMethod)
        {
            var isExist = false;
            var options = new SelectElement(PaymentMethodDdl(1)).Options;
            isExist = options.Any(elem => elem.Text.ToLower() == paymentMethod.ToLower());

            return isExist;
        }

        /// <summary>
        /// Checks if any payment method is selected in payment method dropdown.
        /// </summary>
        /// <returns>True/False</returns>
        public bool CheckIfAnyPaymentMethodIsSelected()
        {
            // Get text for selected payment method. 
            var selectedPaymentMethod = GetSelectedPaymentMethod();
            if(selectedPaymentMethod.Equals("Pick a payment"))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Gets the address availability notification message 
        /// </summary>
        /// <returns></returns>
        public string GetAddressAvailabilityNotification()
        {
            var notifications = AddressAvailabilityNotification.FindElements(By.TagName("p"));
            var addressAvailabilityNotification = notifications[0].Text;

            return addressAvailabilityNotification;
        }

        /// <summary>
        /// Get the selected payment method from the payments dropdown
        /// </summary>
        /// <returns>payment method name.</returns>
        public string GetSelectedPaymentMethod()
        {
            var selectedPaymentMethod = new SelectElement(PaymentMethodDdl(1)).SelectedOption.Text;
            return selectedPaymentMethod;
        }

        /// <summary>
        /// Checks if the notification msg is displayed if the amount of purchase exceeds the DA account balance
        /// </summary>
        /// <returns>True/False</returns>
        public bool IsDaLimitNotificationMsgDisplayed()
        {
            return DALimitExceedNotificationMsg.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10));
        }
        /// <summary>
        /// Checks if the notification msg is displayed if the credit limit is less than amount of purchase.
        /// </summary>
        /// <returns>True/False</returns>
        public bool IsCreditLimitNotificationMsgDisplayed()
        {
            return CreditLimitNotificationMsg.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10));
        }

        public bool IsDormantNotificationMsgDisplayed()
        {
            return DormantNotificationMsg.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10));
        }

        public bool IsOTBNotificationMsgDisplayed()
        {
            return OTBNotificationMsg.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10));
        }

        /// <summary>
        /// Gets the available balance on the selected DA account. 
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Balance on selected DA account</returns>
        public double GetDABalance(int index)
        {
            var dAaccountbalance = LblDAaccountbalance(index).GetText(WebDriver);
            var currencySplitValues = dAaccountbalance.Split('$');
            return Convert.ToDouble(currencySplitValues[1], CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Gets the final price from the price summary section.
        /// </summary>
        /// <returns>final price from the price summary section</returns>
        public double GetFinalPrice()
        {
            var formattedFinalPrice = TxtPaymentAmount.GetText(WebDriver);
            var currencySplitValues = formattedFinalPrice.Split('$');
            return Convert.ToDouble(currencySplitValues[1], CultureInfo.InvariantCulture);
        }

        public void OpenNewTab(string baseUrl)
        {           
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            js.ExecuteScript("window.open();");
            WebDriver.SwitchTo().Window(WebDriver.WindowHandles.Last()); 
            WebDriver.Url = baseUrl;           
        }

        public void EnterTransferFundsAmount(double amount)
        {
            SelectTransferFunds();
            PaymentText.Clear();
            PaymentText.SendKeys(amount.ToString());
        }

        public void SelectTransferFunds()
        {
            SelectElement selectElement = new SelectElement(PaymentMethodDropDown);
            selectElement.SelectByValue("string:SIX");
            
        }

        public void PaymentTransferFundsSubmit()
        {
            WebDriver.WaitForPageLoad();
            EnterTransferFundsAmount(new PaymentsPage(WebDriver).GetFinalPrice());
            
            PaymenNextBtn.Click();
        }
        public void PaymentNullSubmit()
        {
            PaymenNextBtn.Click();
        }

        public void CompleteGMORAtReOrder(bool isGmorRequired = false)

        {
            var reviewPage = new OrderReviewPage(WebDriver);
            if (reviewPage.BtnGmorBeginNextDone.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(15)))
            {
                reviewPage.BtnGmorBeginNextDone.Click(WebDriver);

                for (int i = 0; i < 11; i++)
                {
                    Actions action = new Actions(WebDriver);
                    action.SendKeys(Keys.Right).Build().Perform();                   
                }
                reviewPage.BtnGmorBeginNextDone.Click(WebDriver);
            }
        }

        public void VoidAuthorization(string Value)
        {
            if (Value == "Yes")
                YesButton.Click(WebDriver);
            else
                NoButton.Click(WebDriver);
        }

        public void DeletePayment(int methodIndex)
        {            
            DeletePaymentMethod[0].Click(WebDriver);
        }
        public void ClickViewDfsDetails()
        {
            WebDriverUtil.WaitUntilElementDisappers(WebDriver, By.XPath("//span[@class='inline-busy-block']"), 50); 
            ViewDFSdetails.Click(WebDriver);           
        }

        public void EnterSnowRequestID(string snowRequestID)
        {
            SnowRequestID.Clear();
            SnowRequestID.SendKeys(snowRequestID + Keys.Tab);
        }

        public string GetInvalidSnowRequestIDMessage()
        {
            return InvalidSnowRequestID.GetText(WebDriver, TimeSpan.FromSeconds(5));
        }

        public bool ValidateSnowRequestIDField()
        {
            bool presentornot = WebDriver.ElementExists(By.Id("quoteSaveAsOrder_snowRequestId"));
            return presentornot;
        }

        public string GetLeBuCc()
        {
            string getTextLeBuCc = LeBuCc.GetText(WebDriver);
            return getTextLeBuCc;
        }
        
        public bool ValidateLeBuCcField()
        {
            bool presentornot = WebDriver.ElementExists(By.XPath("//label[contains(text(),'LE/BU/CC:')]//parent::div/div/input"));
            return presentornot;
        }

        public void ChangeOrderTypeDCE(string orderType)
        {
            WebDriver.FindElement(By.XPath("//*[@id='quoteSaveAsOrder_orderType']"), TimeSpan.FromSeconds(10)).PickDropdownByText(WebDriver, orderType);
        }

        public bool IsPaymentMethodNextClickable()
        {
            return BtnPaymentMethodNext.IsElementClickable(WebDriver, TimeSpan.FromSeconds(5));
        }


        #endregion
    }
}
