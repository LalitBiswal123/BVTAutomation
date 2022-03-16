using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dsa.DataModels;
using Dsa.Pages.PCFConvergence;
using Dsa.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Dsa.Pages.PCFConvergence
{
    public class PCFSubscriptionBillingPage : DsaPageBase
    {
        private IWebDriver webDriver;
        public PCFSubscriptionBillingPage(IWebDriver webDriver) : base(webDriver)
        {
            Name = "Subscription Payment Page"; 
            this.webDriver = webDriver;
        }

        #region Elements
        public IWebElement SubscriptionPaymentMethods { get { return WebDriver.GetElement(By.Id("paymentOptions1")); } }
        public IWebElement CreditCardSection { get { return WebDriver.GetElement(By.XPath("//*[@id='paymentContainer']/credit-card")); } }
        public IWebElement AcceptConsent { get { return WebDriver.GetElement(By.Id("is_consented")); } }
        public IWebElement ContinueButton { get { return WebDriver.GetElement(By.Id("ContinueLink")); } }
        public IWebElement SameCardNumber { get { return WebDriver.GetElement(By.XPath("//div[text()='Card Number']//following-sibling::div/span")); } }
        public IWebElement SameCardType { get { return WebDriver.GetElement(By.XPath("//div[text()='Type']//following-sibling::div/span")); } }
        public IWebElement DfsStatusLink { get { return WebDriver.GetElement(By.Id("dfsfinancialInfo_link")); } }       
        public IWebElement DbcCreditStatus { get { return WebDriver.GetElement(By.Id("scc_dbcCreditStatus")); } }
        public IWebElement DbcAvailableCredit { get { return WebDriver.GetElement(By.Id("scc_dbcAvailableCredit")); } }
        public IWebElement LeaseCreditStatus { get { return WebDriver.GetElement(By.Id("scc_leaseCreditStatus")); } }
        public IWebElement LeaseOffer { get { return WebDriver.GetElement(By.Id("scc_leaseOffer")); } }
        public IWebElement ViewDfsDetailsLink { get { return WebDriver.GetElement(By.Id("scc_viewDfsDetailsLink")); } }
        public IWebElement RunCreditLink { get { return WebDriver.GetElement(By.Id("dpa_runCreditLink")); } }
        //remove this use common text
        public IWebElement PricingCompleteDfsBtn { get { return WebDriver.GetElement(By.XPath("//subscription-pricing-summary//button[contains(text(),'Complete DFS Information')]")); } }
        //remove this use common text
        public IWebElement BottomCompleteDfsBtn { get { return WebDriver.GetElement(By.Id("ContinueLink")); } }
        public IWebElement TxtPoNumber { get { return WebDriver.GetElement(By.Id("paymentPoNo")); } }
        public IWebElement TxtFaxId { get { return WebDriver.GetElement(By.XPath("//*[text()='Fax ID']/following-sibling::div/input")); } }
        public IWebElement TxtPOMId { get { return WebDriver.GetElement(By.XPath("//div[text()='POM ID']/following-sibling::div/input")); } }
        public IWebElement UpfrontPayment { get { return WebDriver.GetElement(By.Id("pricingSummary_UpfrontPayment")); } }
        public IWebElement TotalContractPrice { get { return WebDriver.GetElement(By.Id("pricingSummary_TotalContractPrice")); } }
        public IWebElement DfsEligibleNotification { get { return WebDriver.GetElement(By.XPath("//p[@class='dds__alert-body']")); } }
        public IWebElement DfsIncompleteError { get { return WebDriver.GetElement(By.XPath("//dbc//div[contains(@class,'dds__content-error')]")); } }
        public IWebElement ETFLabel { get { return WebDriver.GetElement(By.Id("lblpricingSummary_EstimatedMonthlyPayment")); } }
        public IWebElement ETFValue { get { return WebDriver.GetElement(By.Id("pricingSummary_EstimatedMonthlyPayment")); } }
        public IWebElement UpfrontPaymentLabel { get { return WebDriver.GetElement(By.Id("lblpricingSummary_UpfrontPayment")); } }
        public IWebElement UpfrontPaymentTaxLabel { get { return WebDriver.GetElement(By.Id("lblpricingSummary_UpfrontPaymentTax")); } }
        public IWebElement UpfrontPaymentTaxValue { get { return WebDriver.GetElement(By.Id("pricingSummary_UpfrontPaymentTax")); } }
        public IWebElement TotalContractPriceLabel { get { return WebDriver.GetElement(By.Id("lblpricingSummary_TotalContractPrice")); } }
        public IWebElement SubsBillinglabel { get { return WebDriver.GetElement(By.XPath("//subscription-pricing-summary//div/div/b")); } }
        public IWebElement InlineErrorMsgs { get { return WebDriver.GetElement(By.XPath("//p[contains(@class,'content-error')]")); } }

        #region Credit_Card_Elements
        public IWebElement NameOnCard { get { return WebDriver.GetElement(By.Id("txt_name_on_card")); } }
        public IWebElement CardNumber { get { return WebDriver.GetElement(By.Id("txt_creditcard_number")); } }
        public IWebElement ExpirationMonth { get { return WebDriver.GetElement(By.Id("expiration_month")); } }
        public IWebElement ExpirationYear { get { return WebDriver.GetElement(By.Id("expiration_year")); } }
        public IWebElement SecurityCode { get { return WebDriver.GetElement(By.Id("txt_security_code")); } }
        public IWebElement PhoneNumber { get { return WebDriver.GetElement(By.Id("txt_phone_number")); } }
        public IWebElement CardType { get { return WebDriver.GetElement(By.XPath("//div[text()='Type']//following-sibling::div/p")); } }
        public IWebElement AddressLine1 { get { return WebDriver.GetElement(By.Id("txt_address1")); } }
        public IWebElement City { get { return WebDriver.GetElement(By.Id("city")); } }
        public IWebElement Zipcode { get { return WebDriver.GetElement(By.Id("txt_postal_code")); } }        

        #endregion


        #endregion

        #region Cloud - DTCP/Dimension

        public IWebElement Cadences { get { return WebDriver.GetElement(By.XPath("(//*[@id='paymentMethod_categories']//select)[1]")); } }

        public IWebElement CadenceAmount { get { return WebDriver.GetElement(By.Id("lbl_amount")); } }

        public IWebElement RecurringPaymentTitle { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Select a recurring payment method for subscription billing')]")); } }

        public IWebElement Payments { get { return WebDriver.GetElement(By.XPath("(//*[@id='paymentMethod_categories']//select)[2]")); } }

        public IWebElement PaymentOptions { get { return WebDriver.GetElement(By.XPath("//*[@id='paymentOptions1']")); } }

        public IWebElement NameOnCardTextBox { get { return WebDriver.GetElement(By.Id("txt_name_on_card")); } }

        public IWebElement CCNumberTextBox { get { return WebDriver.GetElement(By.Id("txt_creditcard_number")); } }

        public IWebElement CCexpirationMonth { get { return WebDriver.GetElement(By.Id("expiration_month")); } }

        public IWebElement CCexpirationYear { get { return WebDriver.GetElement(By.Id("expiration_year")); } }

        public IWebElement SecurityCodeTextbox { get { return WebDriver.GetElement(By.Id("txt_security_code")); } }

        public IWebElement PhoneNumberTextbox { get { return WebDriver.GetElement(By.Id("txt_phone_number")); } }

        public IWebElement ShowBillingDetailsLnk { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Show Billing Details')]")); } }

        public IWebElement BackLnk { get { return WebDriver.GetElement(By.XPath("//span[@class='sidebar-popup-back' and contains(text(), 'Back')]")); } }

        public IWebElement VerbalDescription { get { return WebDriver.GetElement(By.Id("is_consented")); } }

        public IWebElement BtnContinue { get { return WebDriver.GetElement(By.XPath("//*[@type='button' and contains(text(), 'Continue')]")); } }
        public IWebElement CreditCardType { get { return WebDriver.GetElement(By.XPath("//div[text()='Type']//following-sibling::div//p")); } }
        public IWebElement CCState { get { return WebDriver.GetElement(By.Id("cartPayment_state")); } }
        public IWebElement CCMandatoryField { get { return WebDriver.GetElement(By.XPath("//*[@id='txt_creditcard_number']//following-sibling::div//p")); } }
        public IWebElement CCNameMandatoryField { get { return WebDriver.GetElement(By.XPath("//*[@id='txt_name_on_card']//following-sibling::div//p")); } }
        public IWebElement CardIdMandatoryField { get { return WebDriver.GetElement(By.XPath("//*[@id='txt_security_code']//following-sibling::div//p")); } }
        public IWebElement ExpirationMonthMandatoryField { get { return WebDriver.GetElement(By.XPath("//label[text()='Expiration Date']//following-sibling::div//p")); } }
        public IWebElement PhoneNumberMandatoryField { get { return WebDriver.GetElement(By.XPath("//label[@for='cartPayment_phoneNumber']/following-sibling::div/div/div")); } }
        public IWebElement Address1MandatoryField { get { return WebDriver.GetElement(By.XPath("//*[@id='txt_address1']//following-sibling::div//p")); } }
        public IWebElement Address1Text { get { return WebDriver.GetElement(By.Id("txt_address1")); } }
        public IWebElement CityMandatoryField { get { return WebDriver.GetElement(By.XPath("//*[@id='city']//following-sibling::div//p")); } }
        public IWebElement CityText { get { return WebDriver.GetElement(By.Id("city")); } }
        public IWebElement ZipCodeMandatoryField { get { return WebDriver.GetElement(By.XPath("//*[@id='txt_postal_code']//following-sibling::div//p")); } }
        public IWebElement CustomerReferenceNumberMandatoryField { get { return WebDriver.GetElement(By.XPath("//*[@id='txt_reference_number']//following-sibling::div//p")); } }      
        public IWebElement TxtZipCode { get { return WebDriver.GetElement(By.Id("txt_postal_code")); } }
        public IWebElement ChargeDescriptionTextbox { get { return WebDriver.GetElement(By.Id("txt_charge_description")); } }
        public IWebElement DisclosureText { get { return WebDriver.GetElement(By.XPath("//span[text()='Disclosure: ']")); } }
        public IWebElement DisclosureAcceptanceText { get { return WebDriver.GetElement(By.XPath("//div[@class='termscondition-checkbox']")); } }
        public IWebElement NetTermValue { get { return WebDriver.GetElement(By.XPath("//*[@id='lblnetTerms_payment_terms']/following-sibling::div")); } }
        public IList<IWebElement> SubscriptionSkus { get { return WebDriver.GetElements(By.XPath("//div[contains(@class,'sub-details')]/div[2]")); } }
        public IWebElement TxtEmailAddress { get { return WebDriver.GetElement(By.XPath("//div[text()='Billing Email Address']/following-sibling::div/input")); } }
        public IWebElement FBCadences { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_cadence_1']/..//select")); } }
        #endregion

        #region Methods
        public void SelectPaymentMethod(string payMethod)
        {
            SubscriptionPaymentMethods.IsElementClickable(WebDriver, TimeSpan.FromSeconds(15));
            SubscriptionPaymentMethods.PickDropdownByText(WebDriver, payMethod);
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
        }

        public PCFOrderReviewPage ClickContinueButton()
        {
            ContinueButton.Click(WebDriver);
            return new PCFOrderReviewPage(WebDriver);
        }

        public T EnterCreditCardDetails<T>(string PaymentType, CreditCard card, ref string cardType, bool clickContinue = true)
        {
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            SelectPaymentMethod(PaymentType);
            NameOnCard.EnterText(WebDriver, card.NameOnCard, TimeSpan.FromSeconds(2));
            CardNumber.EnterText(WebDriver, card.CreditCardNumber, TimeSpan.FromSeconds(2));
            cardType = CardType.GetText(WebDriver);
            ExpirationMonth.PickDropdownByText(WebDriver, card.ExpirationMonth);
            ExpirationYear.PickDropdownByText(WebDriver, card.ExpirationYear);
            SecurityCode.EnterText(WebDriver, card.Cid, TimeSpan.FromSeconds(2));
            PhoneNumber.EnterText(WebDriver, card.PhoneNumber, TimeSpan.FromSeconds(2));
            AcceptConsent.Click();

            if (clickContinue)
            {
                ContinueButton.Click(WebDriver);
                WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            }

            var page = PageFactory.InitElements<T>(WebDriver);
            return page;
        }
        
        public PCFSubscriptionBillingPage DPAClickContinueButton()
        {
            AcceptConsent.Click();
            ContinueButton.Click(WebDriver);
            return new PCFSubscriptionBillingPage(WebDriver);
        }

        #endregion

        #region FB Fields

        public IWebElement FullPeriodChargeTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Full period charge per unit')]")); } }

        public IWebElement QuantityTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Quantity')]")); } }

        public IWebElement TotalFullPeriodChargeTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Total full period charge')]")); } }

        public IWebElement FirstPeriodChargeProratedTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'First period charge prorated (estimated) per unit')]")); } }

        public IWebElement CoveragePeriodTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Coverage Period')]")); } }

        public IWebElement RenewalDateTxt { get { return WebDriver.GetElement(By.XPath("(//*[contains(text(), 'Renewal Date')])[2]")); } }

        public IWebElement TermsAndConditionsLnk { get { return WebDriver.GetElement(By.XPath("(//*[contains(text(), 'Terms and Conditions')])[2]")); } }

        #endregion

        public PCFSubscriptionBillingPage GetAllOptionsFromDropDown(IWebElement element, int count)
        {
            SelectElement select = new SelectElement(element);
            IList<IWebElement> list = select.Options;
            var total = list.Count;
            if (total.Equals(count))
            {
                foreach (var item in list)
                {
                    Logger.Write(item.GetText(WebDriver));
                }
            }
            else
            {
                Assert.Fail("Count doesn't match.");
            }
            return new PCFSubscriptionBillingPage(WebDriver);
        }

        public void EnterCreditCardDetails(IWebDriver WebDriver, CreditCard card)
        {
            var pcfSubscriptionBilling = new PCFSubscriptionBillingPage(WebDriver);
            pcfSubscriptionBilling.NameOnCardTextBox.SetText(WebDriver, card.NameOnCard);
            pcfSubscriptionBilling.CCNumberTextBox.SetText(WebDriver, card.CreditCardNumber);
            pcfSubscriptionBilling.CCexpirationMonth.PickDropdownByValue(WebDriver, card.ExpirationMonth);
            pcfSubscriptionBilling.CCexpirationYear.PickDropdownByValue(WebDriver, card.ExpirationYear);
            pcfSubscriptionBilling.SecurityCodeTextbox.SetText(WebDriver, card.Cid);
            pcfSubscriptionBilling.PhoneNumberTextbox.SetText(WebDriver, card.PhoneNumber);
        }

        public IWebElement GetCadenceSummaryGrid(int? summarySkuCount)
        {
            return WebDriver.GetElement(By.XPath("(//*[@class='c-data-grid c-data-grid-table table table-layout-fixed'])[" + summarySkuCount + "]"));
        }

        public List<Dictionary<string, object>> GetSkuSummaryGridTable(int? index)
        {
            GetCadenceSummaryGrid(index).WaitForElement(WebDriver);
            return GetCadenceSummaryGrid(index).GetTableData(WebDriver);
        }

        public PCFSubscriptionBillingPage PCFEnterFlexbillingInfoWithDpa(Dpa dpaData = null, bool flex = false)
        {
            if (dpaData != null)
            {
                RunCredit(flex).EnterDpaInformationForRunCreditTEST<PCFSubscriptionBillingPage>(dpaData);
            }
            return new PCFSubscriptionBillingPage(WebDriver);
        }

        public DpaPaymentPage RunCredit(bool flex = false)
        {
            if (flex == true)
            {
                ChkDoYouAgreeToTermsConditions(1).Click();
            }
            DfsStatusLink.Click(WebDriver);
            RunCreditLink.Click(WebDriver);
            WebDriverUtil.WaitUntilUrlDisplay(WebDriver, "Consumer/DPA/DPACreditApp", 30);
            return new DpaPaymentPage(WebDriver);
        }

        public IWebElement ChkDoYouAgreeToTermsConditions(int position = 1)
        {
            return
                WebDriver.GetElements(By.Id("is_consented"))[position - 1];
        }
        public PCFSubscriptionBillingPage EnterFbInfoWithNetTerms(string poNum, string pomId, int index = 1)
        {
            SelectPaymentMethod("NetTerms");
            if (index == 1)//only for first time 
                EnterPurchaseOrderInfo(poNum, pomId);
            ChkDoYouAgreeToTermsConditions(index).SelectCheckBox(WebDriver);

            return this;
        }
        public void EnterPurchaseOrderInfo(string poNum, string pomId)
        {
            if (TxtPoNumber.GetText(WebDriver) == "")
            {
                TxtPoNumber.SetText(WebDriver, poNum);
                TxtPOMId.IsElementClickable(WebDriver, TimeSpan.FromSeconds(15));
                TxtPOMId.SetText(WebDriver, pomId);
            }
        }
        public PCFSubscriptionBillingPage EnterFbInfWithDbc(string lastName, string pin, int index = 1)
        {
            SelectPaymentMethod("Dell Business Credit");
            ChkDoYouAgreeToTermsConditions(index).SelectCheckBox(WebDriver);
            if (index >= 1)
            {
                if (SubscriptionPaymentMethods.GetText(WebDriver) == "Dell Business Credit")
                {                   
                    CompleteDfsInformation().EnterDfsInformation<PCFSubscriptionBillingPage>(WebDriver, lastName, pin);
                    // reselect the terms & condition as it is lost after coming from DFS page.
                    ChkDoYouAgreeToTermsConditions(index).SelectCheckBox(WebDriver);
                }
            }
            return this;
        }

        public DfsPaymentPage CompleteDfsInformation()
        {
            //new WebDriverWait(WebDriver, TimeSpan.FromSeconds(90)).Until(d => PricingCompleteDfsBtn.IsElementDisplayed(WebDriver);

            PricingCompleteDfsBtn.Click(WebDriver);
            WebDriverUtil.WaitUntilUrlDisplay(WebDriver, "SMB/DBC/DBCAuthentication", 45);
            return new DfsPaymentPage(WebDriver);
        }
        public void VerifyIfDfsCreditCheckIsDone()
        {
            WebDriverUtil.WaitUntilElementDisappers(WebDriver, By.XPath("//label[contains(text(),'DFS credit check')]"), 15);
        }
        public void WaitUntilFbComponentsLoad()
        {
            WebDriverUtil.WaitUntilUrlDisplay(WebDriver, "subscription-payment", 15);
            SubscriptionPaymentMethods.IsElementClickable(WebDriver, TimeSpan.FromSeconds(10));
        }

        public string GetPricingSummaryContinueButtonText()
        {
            return WebDriver.GetElement(By.XPath("//subscription-pricing-summary//button")).GetText(WebDriver);
        }
        public PCFSubscriptionBillingPage EnterFbInfoWithNetTermsWithFaxIdAndPoNum(int paymentMethodIndex, string poNum, string faxId)
        {
            SubscriptionPaymentMethods.PickDropdownByText(WebDriver, "NetTerms");
            TxtPoNumber.SetText(WebDriver, poNum);
            TxtFaxId.SetText(WebDriver, faxId);
            ChkDoYouAgreeToTermsConditions(paymentMethodIndex).SelectCheckBox(WebDriver);

            return this;
        }

        public List<string> GetSubscriptionSkus()
        {
            List<string> fbskuNumbers = new List<string>();
            foreach (IWebElement fbsku in SubscriptionSkus)
            {
                fbskuNumbers.Add(fbsku.Text.ToString());
            }
            return fbskuNumbers;
        }

        public IWebElement ServiceTypeDisclosure(int paymentType)
        {                         
            return WebDriver.GetElement(By.XPath("//subscription-billing/div[2]/div/div[" + paymentType + "]/div/div[4]/div/span[2]"));
        }

        public IWebElement ServiceTermsAndConditionsLink(int paymentType)
        {
            return WebDriver.GetElement(By.XPath("//subscription-billing//a[text()='Terms and Conditions'][" + paymentType + "]"));
        }

        public PCFSubscriptionBillingPage EnterFlexbillingInformationWithExistingCreditCard(int paymentMethodIndex, string creditCardToSelect)
        {
            SelectPaymentMethod(creditCardToSelect);
            ChkDoYouAgreeToTermsConditions(paymentMethodIndex).SelectCheckBox(WebDriver);
            return this;
        }
        public IWebElement LblPaymentType(int position)
        {
            return WebDriver.GetElements(By.XPath("//bill-plan/div//div//div//div//div[2]//div"))[position - 1];
        }

       }
}
