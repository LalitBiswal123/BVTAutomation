using System;
using Dsa.DataModels;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Dsa.Pages.Order;
using FluentAssertions;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Dsa.Pages
{
    public class FlexBillingRenewalPage : DsaPageBase
    {
        private const string PagePrefix = "";
        public FlexBillingRenewalPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement HdrSubscription { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrder_flexibleBilling")); } }


public IWebElement TxtEmailAddress { get { return WebDriver.GetElement(By.Id("fb_cart_payments_card_address_email_address")); } }


public IWebElement BtnDisclosureAcceptOnPopup { get { return WebDriver.GetElement(By.CssSelector(".modal-wrap > div:nth-child(2) > div:nth-child(1) > div:nth-child(4) > button:nth-child(1)")); } }


public IWebElement BtnDisclosureDeclineOnPopup { get { return WebDriver.GetElement(By.CssSelector(".modal-wrap > div:nth-child(2) > div:nth-child(1) > div:nth-child(4) > button:nth-child(2)")); } }


public IWebElement BtnNext { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='Next']")); } }


public IWebElement BtnCancel { get { return WebDriver.GetElement(By.CssSelector("button.btn-success")); } }


public IWebElement BtnDisclosureAccept { get { return WebDriver.GetElement(By.XPath("//button[text()='Accept']")); } }


public IWebElement BtnDisclosureDecline { get { return WebDriver.GetElement(By.CssSelector(".btn-default")); } }


public IWebElement LnkRunCredit { get { return WebDriver.GetElement(By.Id("RunCredit")); } }


public IWebElement SubscriptionBillingNextButton { get { return WebDriver.GetElement(By.Id("create_Order_Payment_Subscription_Next")); } }


public IWebElement LnkSearchForExistingAccount { get { return WebDriver.GetElement(By.Id("SearchExistingAccount")); } }


public IWebElement BtnCompleteDpaInformation { get { return WebDriver.GetElement(By.Id("complete_dpa_information")); } }


public IWebElement BtnCompleteDfsInformation { get { return WebDriver.GetElement(By.Id("complete_dbc_information")); } }


public IWebElement LblDbcCreditStatus { get { return WebDriver.GetElement(By.Id("customerDetails_dbcCreditStatus")); } }


public IWebElement DivFlexBillingOption { get { return WebDriver.GetElement(By.ClassName("smry-info")); } }


public IWebElement LblUpfrontPaymentAmount { get { return WebDriver.GetElement(By.Id("_summary_upfrontAmount")); } }


public IWebElement LblUpfrontPaymentTax { get { return WebDriver.GetElement(By.Id("_summary_tax")); } }


public IWebElement LblTotalContractPrice { get { return WebDriver.GetElement(By.Id("_summary_totalContractValue")); } }


public IWebElement DdlBillPlan { get { return WebDriver.GetElement(By.Name("billPlanOptions")); } }


public IWebElement TxtPoNumber { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderPayment_poNumber")); } }


public IWebElement LnkAddPomId { get { return WebDriver.GetElement(By.CssSelector("#_pomId > span:nth-child(2) > span:nth-child(1) > a:nth-child(1)")); } }


public IWebElement TxtPomId { get { return WebDriver.GetElement(By.Id("pom_id")); } }


public IWebElement LblFBDisclosurescript { get { return WebDriver.GetElement(By.XPath("//form[@name='flexibleBillingDisclosureForm']/p")); } }


public IWebElement LblInvalidPaymentWrng { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'Invalid Card Number or Account')]")); } }


public IList<IWebElement> NameOnCardTextBox { get { return WebDriver.GetElements(By.Id("cartPayment_nameAsOnCard")); } }


public IList<IWebElement> CCNumberTextBox { get { return WebDriver.GetElements(By.Id("cartPayment_ccNumber")); } }


public IList<IWebElement> CCexpirationMonth { get { return WebDriver.GetElements(By.Id("cartPayment_expirationMonth")); } }


public IList<IWebElement> CCexpirationYear { get { return WebDriver.GetElements(By.Id("cartPayment_expirationYear")); } }


public IList<IWebElement> CardIdTextbox { get { return WebDriver.GetElements(By.Id("cartPayment_cardId")); } }


public IList<IWebElement> phoneNumberTextbox { get { return WebDriver.GetElements(By.Id("cartPayment_phoneNumber")); } }


public IWebElement CardidTextbox { get { return WebDriver.GetElement(By.Id("cartPayment_cardId")); } }


public IList<IWebElement> customerReferenceNumberTextbox { get { return WebDriver.GetElements(By.Id("cartPayment_customerReferenceNumber")); } }


public IList<IWebElement> ChargeDescriptionTextbox { get { return WebDriver.GetElements(By.Id("cartPayment_cardChargeDescription")); } }


public IWebElement PONotificationMsg { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'PO Number Required To Proceed')]")); } }


public IWebElement PaymentMethodDropDown { get { return WebDriver.GetElement(By.XPath("//*[@name='payments']")); } }


public IWebElement PaymentErrorMsg { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'An error occurred while saving payments.')]")); } }


public IWebElement cardType { get { return WebDriver.GetElement(By.Id("payment_creditcard_type")); } }


public IWebElement BillPlanOptions { get { return WebDriver.GetElement(By.Name("payments")); } }


public IWebElement PaymentOptions { get { return WebDriver.GetElement(By.Name("payments")); } }

public IWebElement FlexBillingUploadPO { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderPayment_UploadPo")); } }
public IWebElement PomIdFieldLevelError { get { return WebDriver.GetElement(By.XPath("//span[@class='invalid-input']")); } }
public IWebElement POMidPatched { get { return WebDriver.GetElement(By.XPath("//div[@id='_pomId']//span/span")); } }
public IWebElement POMidChangeLnk { get { return WebDriver.GetElement(By.XPath("//div[@id='_pomId']//span/span/a")); } }
public IWebElement BillPlanOPtions { get { return WebDriver.GetElement(By.XPath("//select[@name='billPlanOptions']")); } }
public IWebElement SelectCadence { get { return WebDriver.GetElement(By.XPath("//*[@id='main']//select[1]")); } }
        #endregion

        #region DTCP Elements


        public IWebElement Cadences { get { return WebDriver.GetElement(By.XPath("//*[@name='cadences']")); } }


public IWebElement DTCPVerbalDescription { get { return WebDriver.GetElement(By.Id("is_consented")); } }
public IWebElement DisclosureText { get { return WebDriver.GetElement(By.XPath("//recurring-payment/div[3]/div")); } }
public IWebElement DisclosureAcceptanceText { get { return WebDriver.GetElement(By.XPath("//label[@for='is_consented']/span//span")); } }

public IWebElement AddressAvailabilityNotification { get { return WebDriver.GetElement(By.XPath("//*[@id='create_order_subscription_billing_message_0']")); } }


public IWebElement CadenceAmount { get { return WebDriver.GetElement(By.Id("id_amount")); } }


public IWebElement DfsHeader { get { return WebDriver.GetElement(By.Id("financialServices_header")); } }

 public IWebElement TxtFaxId { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderPayment_FaxId")); } }

public IWebElement txtZipCode { get { return WebDriver.GetElement(By.Id("cartPayment_postalCode")); } }

public IWebElement zipCodeValidator { get { return WebDriver.GetElement(By.XPath("//div[@class='text-danger']/div[3]")); } }
 public IWebElement ViewDfsDetails { get { return WebDriver.GetElement(By.Id("declineScript")); } }

public IWebElement NetTermValue { get { return WebDriver.GetElement(By.Id("payment_netTerms_terms"));  } }

public IList<IWebElement> SubscriptionSkus { get { return WebDriver.GetElements(By.XPath("//div[@class='offset-0 col-md-4 content-bold text-right offset-right-0 sub-details padding-small']")); } }


public IWebElement NextBtn { get { return WebDriver.GetElement(By.XPath("//button[@class='btn btn-success']")); } }

        public IWebElement GetCadenceSummaryGrid(int? summarySkuCount)
        {
            return WebDriver.GetElement(By.XPath("(//*[@class='c-data-grid c-data-grid-table dataTable table-layout-fixed'])[" + summarySkuCount + "]"));
        }

        public IWebElement CCMandatoryField { get { return WebDriver.GetElement(By.XPath("//label[@for='cartPayment_ccNumber']/following-sibling::div//input[contains(@class,'dsa-validation-highlight')]")); } }
        public IWebElement CCNameMandatoryField { get { return WebDriver.GetElement(By.XPath("//label[@for='cartPayment_nameAsOnCard']/following-sibling::div//input[contains(@class,'dsa-validation-highlight')]")); } }
        public IWebElement CardIdMandatoryField { get { return WebDriver.GetElement(By.XPath("//label[@for='cartPayment_cardId']/following-sibling::div//input[contains(@class,'dsa-validation-highlight')]")); } }
        public IWebElement ExpirationMonthMandatoryField { get { return WebDriver.GetElement(By.XPath("//label[@for='cartPayment_expirationMonth']/following-sibling::div/select[contains(@class,'dsa-validation-highlight')][1]")); } }
        public IWebElement ExpirationYearMandatoryField { get { return WebDriver.GetElement(By.XPath("//label[@for='cartPayment_expirationMonth']/following-sibling::div/select[contains(@class,'dsa-validation-highlight')][2]")); } }
        public IWebElement PhoneNumberMandatoryField { get { return WebDriver.GetElement(By.XPath("//label[@for='cartPayment_phoneNumber']/following-sibling::div/div/div")); } }
        public IWebElement Address1MandatoryField { get { return WebDriver.GetElement(By.XPath("//label[@for='cartPayment_line1']/following-sibling::div/input[contains(@class,'dsa-validation-highlight')]")); } }
        public IWebElement Address1Text { get { return WebDriver.GetElement(By.XPath("//*[@id='cartPayment_line1']")); } }
        public IWebElement Address2Text { get { return WebDriver.GetElement(By.XPath("//*[@id='cartPayment_line2']")); } }
        public IWebElement Address2MandatoryField { get { return WebDriver.GetElement(By.XPath("//label[@for='cartPayment_line2']/following-sibling::div/input[contains(@class,'dsa-validation-highlight')]")); } }
        public IWebElement CityMandatoryField { get { return WebDriver.GetElement(By.XPath("//label[@for='cartPayment_city']/following-sibling::div/input[contains(@class,'dsa-validation-highlight')]")); } }
        public IWebElement CityText { get { return WebDriver.GetElement(By.XPath("//*[@id='cartPayment_city']")); } }
        public IWebElement ZipCodeMandatoryField { get { return WebDriver.GetElement(By.XPath("//label[@for='cartPayment_postalCode']/following-sibling::div/div/div")); } }
        public IWebElement CustomerReferenceNumberMandatoryField { get { return WebDriver.GetElement(By.XPath("//label[@for='cartPayment_customerReferenceNumber']/following-sibling::div/input[contains(@class,'dsa-validation-highlight')]")); } }
        public IWebElement CIDAmexValidation { get { return WebDriver.GetElement(By.XPath("//*[@id='cartPayment_cardId']/following-sibling::div/div")); } }


        public IWebElement CCErrorMessages { get { return WebDriver.GetElement(By.XPath("//div[@class='text-danger']/div")); } }
public IWebElement PomIdRequiredError { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Pom Id is required. Please Upload a PO to associate a POM Id.')]")); } }
        public IWebElement CCState { get { return WebDriver.GetElement(By.Id("cartPayment_state")); } }
        public IWebElement CancelBtn { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='Cancel']")); } }

        public int GetCadenceSummaryGridCount()
        {
            return WebDriver.GetElements(By.XPath("//*[@class='c-data-grid c-data-grid-table dataTable table-layout-fixed']")).Count();
        }
        #endregion

        #region POS Subscription Billing fields


        public IWebElement FullPeriodChargeTxt { get { return WebDriver.GetElement(By.XPath("//label[contains(text(), 'Full period charge per unit')]")); } }


public IWebElement Quantity { get { return WebDriver.GetElement(By.XPath("//label[contains(text(), 'Quantity')]")); } }


public IWebElement TotalFullPeriodChargeTxt { get { return WebDriver.GetElement(By.XPath("//label[contains(text(), 'Total full period charge')]")); } }


public IWebElement FirstPeriodChargeTxt { get { return WebDriver.GetElement(By.XPath("//label[contains(text(), 'First period charge prorated (estimated) per unit')]")); } }


public IWebElement CoveragePeriodTxt { get { return WebDriver.GetElement(By.XPath("//label[contains(text(), 'Coverage Period')]")); } }


public IWebElement RenewalDateTxt { get { return WebDriver.GetElement(By.XPath("//label[contains(text(), 'Renewal Date')]")); } }

        #endregion

        public List<Dictionary<string, object>> GetSkuSummaryGridTable(int? index)
        {
            GetCadenceSummaryGrid(index).WaitForElement(WebDriver);
            return GetCadenceSummaryGrid(index).GetTableData(WebDriver);
        }

        public FlexBillingRenewalPage AcceptTermsAndConditionsFromPopup()
        {
            ChkDoYouAgreeToTermsConditions().SelectCheckBox(WebDriver);
            BtnDisclosureAcceptOnPopup.Click(WebDriver);
            return this;
        }

        public FlexBillingRenewalPage AcceptVerbalDescription()
        {
            ChkDoYouAgreeToTermsConditions().SelectCheckBox(WebDriver);
            return this;
        }

        public FlexBillingRenewalPage SelectBillPlan(string billPlan)
        {
            DdlBillPlan.PickDropdownByText(WebDriver, billPlan);            
            return new FlexBillingRenewalPage(WebDriver);
        }

        public int SelectBillPlanCount()
        {            
            IList<IWebElement> selectElements = WebDriver.FindElements(By.Name("billPlanOptions"));
            int count = 0;
            foreach (IWebElement select in selectElements)
            {
                var selectElement = new SelectElement(select);
                count += 1;
            }
            return count;
        }

        public List<string> GetSubscriptionSkus()
        {
            List<string> fbskuNumbers = new List<string>();
            foreach(IWebElement fbsku in SubscriptionSkus)
            {               
                fbskuNumbers.Add(fbsku.Text.ToString());
            }
            return fbskuNumbers;
        }

		public FlexBillingRenewalPage GetAllOptionsFromDropDown(IWebElement element, int count)
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
			return new FlexBillingRenewalPage(WebDriver);
		}

		public List<IWebElement> DdlBillPlans(int paymentType)
        {               
            return
                WebDriver.GetElements(By.XPath("//recurring-payment["+ paymentType + "]//payment-methods//select//option"));         
        }
        public List<IWebElement> DdlBillPlansExisting(int paymentType)
        {
            return
                WebDriver.GetElements(By.XPath("//recurring-payment[" + paymentType + "]//bill-plan-list//select//option"));
        }

        public List<IWebElement> SkuListServiceTypeWise(int paymentType)
        {
            return
                WebDriver.GetElements(By.XPath("//recurring-payment[" + paymentType + "]//sku-list/div"));            
        }

        public IWebElement ServiceHeaderText(int paymentType)
        {
            return
                WebDriver.GetElement(By.XPath("//recurring-payment[" + paymentType + "]/div/div/h4"));
        }

        public IWebElement ServiceTypeDisclosure(int paymentType)
        {           
            return
                WebDriver.GetElement(By.XPath("//recurring-payment-list//recurring-payment[" + paymentType + "]/div[3]//div/div/span"));           
        }

        public List<IWebElement> TermsAndConditionsLink()
        {
            return
                WebDriver.GetElements(By.XPath("//a[@class='more-product-details']"));
        }

        public bool ServiceHeader(int serviceType)
        {
            return ServiceHeaderText(serviceType).Displayed;
        }
        public int SkulistCount(int serviceType)
        {
            return SkuListServiceTypeWise(serviceType).Count;
        }

        public FlexBillingRenewalPage SelectNewPlan(int paymentTypes,int paymentMethods=1)
        {
            DdlBillPlans(paymentTypes)[paymentMethods].Click();
            return this;
        }
       

        public int BillPlanExists( int paymentTypes)
        {
            return DdlBillPlansExisting(paymentTypes).Count;
        }

        public void EnterPurchaseOrderInfo(string poNum, string pomId)
        {
            if(TxtPoNumber.GetText(WebDriver) =="")
            {
                TxtPoNumber.SetText(WebDriver, poNum);
                LnkAddPomId.Click(WebDriver);
                TxtPomId.SetText(WebDriver, pomId);
            }            
        }

        public FlexBillingRenewalPage AcceptTermsAndConditions(string disscript = "")
        {
            if (!disscript.Equals(""))
                LblFBDisclosurescript.GetText(WebDriver).Should().Contain(disscript);
            ChkDoYouAgreeToTermsConditions().SelectCheckBox(WebDriver);
            BtnDisclosureAccept.Click(WebDriver);
            return this;
        }

        public DpaPaymentPage RunCredit(bool flex=false)
        {
            if(flex==true)
            {
                ChkDoYouAgreeToTermsConditions(1).Click();
            }
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
            return new DpaPaymentPage(WebDriver);
        }

        public DfsPaymentPage CompleteDfsInformation()
        {
            BtnCompleteDfsInformation.Click(WebDriver);
            return new DfsPaymentPage(WebDriver);
        }

        public IWebElement GetPaymentMethodSectionByIndex(int paymentMethodIndex)
        {
            return WebDriver.GetElements(By.XPath("//*[contains(@class,'add-payment-method')]/div/div"))[paymentMethodIndex - 1];

        }

        public IWebElement DdlPaymentMethod(int paymentMethodIndex)
        {
            return
                WebDriver.GetElements(By.Name("payments"))[paymentMethodIndex - 1];

        }       

        public FlexBillingRenewalPage EnterNameOnCard(int paymentMethodIndex, string nameOnCard)
        {
            NameOnCardTextBox[paymentMethodIndex-1].SetText(WebDriver, nameOnCard);
            return new FlexBillingRenewalPage(WebDriver);
        }

        public FlexBillingRenewalPage EnterCreditCardNumber(int paymentMethodIndex, string cardNumber)
        {
            CCNumberTextBox[paymentMethodIndex-1].SetText(WebDriver, cardNumber);
            return new FlexBillingRenewalPage(WebDriver);
        }

        public FlexBillingRenewalPage EnterCreditCardExpiration(int paymentMethodIndex, string month, string year)
        {
            CCexpirationMonth[paymentMethodIndex-1].SetText(WebDriver, month);
            CCexpirationYear[paymentMethodIndex-1].SetText(WebDriver, year);
            return new FlexBillingRenewalPage(WebDriver);
        }

        public FlexBillingRenewalPage EnterCreditCardCid(int paymentMethodIndex, string cid)
        {
            CardIdTextbox[paymentMethodIndex-1].SetText(WebDriver, cid);
            return new FlexBillingRenewalPage(WebDriver);
        }

        public FlexBillingRenewalPage EnterCreditCardPhoneNumber(int paymentMethodIndex, string phone)
        {
            phoneNumberTextbox[paymentMethodIndex-1].SetText(WebDriver, phone);
            return new FlexBillingRenewalPage(WebDriver);
        }

        public FlexBillingRenewalPage EnterCustomerReferenceNumber(int paymentMethodIndex, string custRefNum = "")
        {
            if (!String.IsNullOrEmpty(custRefNum))
            {
                customerReferenceNumberTextbox[paymentMethodIndex-1].SetText(WebDriver, custRefNum);
            }
            return new FlexBillingRenewalPage(WebDriver);
        }

        public FlexBillingRenewalPage EnterChargeDesciption(int paymentMethodIndex, string chargeDesc = "")
        {
            if (!String.IsNullOrEmpty(chargeDesc))
            {
                ChargeDescriptionTextbox[paymentMethodIndex-1].SetText(WebDriver, chargeDesc);
            }
            return new FlexBillingRenewalPage(WebDriver);
        }
        
        public void EnterCreditCardDetails(IWebDriver driver, int paymentMethodIndex, CreditCard card)
        {
            new FlexBillingRenewalPage(driver)
                .EnterNameOnCard(paymentMethodIndex, card.NameOnCard)
                .EnterCreditCardNumber(paymentMethodIndex, card.CreditCardNumber)
                .EnterCreditCardExpiration(paymentMethodIndex, card.ExpirationMonth, card.ExpirationYear)
                .EnterCreditCardCid(paymentMethodIndex, card.Cid)
                .EnterCreditCardPhoneNumber(paymentMethodIndex, card.PhoneNumber);
            if(customerReferenceNumberTextboxExists())//validate text box exists or not 
            if (customerReferenceNumberTextbox[paymentMethodIndex-1].IsElementDisplayed(driver,TimeSpan.FromSeconds(10)))
            {
                customerReferenceNumberTextbox[paymentMethodIndex-1].SetText(driver, card.CustomerReferenceNumber);
            }
            if(ChargeDescriptionTextboxExists())//validate text box exists or not           
            if (ChargeDescriptionTextbox[paymentMethodIndex-1].IsElementDisplayed(driver, TimeSpan.FromSeconds(10)))
            {
                ChargeDescriptionTextbox[paymentMethodIndex-1].SetText(driver, card.ChargeDescription);
            }
        }

        public FlexBillingRenewalPage EnterFlexbillingInformationWithExistingCreditCard(int paymentMethodIndex, string creditCardToSelect)
        {
            DdlPaymentMethod(paymentMethodIndex).PickDropdownByText(WebDriver, creditCardToSelect);
            ChkDoYouAgreeToTermsConditions(paymentMethodIndex).SelectCheckBox(WebDriver);

            return this;
        }

        public OrderReviewPage EnterFlexbillingInformationWithDpa(Dpa dpaData = null, string emailAddress = "", bool acceptTermsFromPopup = false,bool flex=false)
        {
            //DdlPaymentMethod(index).PickDropdownByText(WebDriver, "Dell Preferred Account");
            if (dpaData != null)
            {
                RunCredit(flex).EnterDpaInformationForRunCredit(dpaData);               
                CompleteDpaInformation().AcceptPromotionDisclosure();
            }

            if (acceptTermsFromPopup)
            {
                AcceptTermsAndConditionsFromPopup();
                BtnNext.Click(WebDriver);
            }
            else
            {
                if(flex==true)
                {
                    ChkDoYouAgreeToTermsConditions(1).WaitForElement(WebDriver);
                    ChkDoYouAgreeToTermsConditions(1).Click();
                }
                BtnNext.Click(WebDriver);
                if (flex == false)
                {
                    ChkDoYouAgreeToTermsConditions().SelectCheckBox(WebDriver);
                    BtnNext.Click(WebDriver);
                }                
            }

            return new OrderReviewPage(WebDriver);
        }

        public FlexBillingRenewalPage EnterFlexbillingInfoWithDpa(Dpa dpaData = null, bool flex = false)
        {         
            if (dpaData != null)
            {
                RunCredit(flex).EnterDpaInformationForRunCredit(dpaData);              
            }
            return new FlexBillingRenewalPage(WebDriver);
        }

        public FlexBillingRenewalPage EnterFlexbillingInformationWithDbc(string lastName, string pin, int index = 1) 
        {
            DdlPaymentMethod(index).PickDropdownByText(WebDriver, "Dell Business Credit");
            ChkDoYouAgreeToTermsConditions(index).SelectCheckBox(WebDriver);
            if(index >=1)
            {
                if(DdlPaymentMethod(index).GetText(WebDriver)== "Dell Business Credit")
                {
                    CompleteDfsInformation().EnterDfsInformation<FlexBillingRenewalPage>(WebDriver, lastName, pin);
                    // reselect the terms & condition as it is lost after coming from DFS page.
                    ChkDoYouAgreeToTermsConditions(index).SelectCheckBox(WebDriver);
                }               
            }
            return this;
        }

        public OrderReviewPage EnterFlexbillingInformationWitheExistingDbcPayment(int index = 1)
        {
            DdlPaymentMethod(index).PickDropdownByText(WebDriver, "Dell Business Credit");
            ChkDoYouAgreeToTermsConditions(index).SelectCheckBox(WebDriver);
            if (index >= 1)
            {
                if (DdlPaymentMethod(index).GetText(WebDriver) == "Dell Business Credit")
                {
                    BtnNext.Click(WebDriver);                   
                }
            }
            return new OrderReviewPage(WebDriver); 
        }

        public OrderReviewPage FlexbillingpageNextButton(string emailAddress = "", bool acceptTermsFromPopup = false, bool isApos = false)
        {
            
            if (acceptTermsFromPopup && !isApos)
            {
                AcceptTermsAndConditionsFromPopup();
                BtnNext.Click(WebDriver);
            }
            else
            {
                BtnNext.Click(WebDriver);

                if (!isApos)
                    AcceptTermsAndConditions();
            }

            return new OrderReviewPage(WebDriver);
        }
        public FlexBillingRenewalPage EnterAposFlexbillingInformationWithAddNewCreditCard(CreditCard card, int index = 1)
        {
           // DdlPaymentMethod(index).PickDropdownByText(WebDriver, "Add Creditcard");// dropdown is not clickable hence commented the code.
            EnterCreditCardDetails(WebDriver, 1, card);
            ChkDoYouAgreeToTermsConditions(index).SelectCheckBox(WebDriver);
            return this;
        }
        public FlexBillingRenewalPage EnterFlexbillingInformationWithAddNewCreditCard(CreditCard card, int index = 1)
        {
            DdlPaymentMethod(index).PickDropdownByText(WebDriver, "Add Creditcard");
            EnterCreditCardDetails(WebDriver, index, card);
            ChkDoYouAgreeToTermsConditions(index).SelectCheckBox(WebDriver);

            return this;
        }

        public FlexBillingRenewalPage EnterFlexbillingInformationWithNetTerms(string poNum, string pomId, int index = 1)
        {
            DdlPaymentMethod(index).PickDropdownByText(WebDriver, "NetTerms");  
            if(index==1)//only for first time 
            EnterPurchaseOrderInfo(poNum, pomId);
            ChkDoYouAgreeToTermsConditions(index).SelectCheckBox(WebDriver);

            return this;
        }

        public FlexBillingRenewalPage EnterFlexbillingInformationWithNetTermswithsamePOMIDfromPaymentsPage(int paymentMethodIndex, string poNum)
        {
            PaymentMethodDropDown.PickDropdownByText(WebDriver, "NetTerms");
            TxtPoNumber.SetText(WebDriver, poNum);
            ChkDoYouAgreeToTermsConditions(paymentMethodIndex).SelectCheckBox(WebDriver);

            return this;
        }

        public FlexBillingRenewalPage EnterFlexbillingInformationWithNetTermsWithFaxIdAndPoNum(int paymentMethodIndex, string poNum, string faxId)
        {
            PaymentMethodDropDown.PickDropdownByText(WebDriver, "NetTerms");
            TxtPoNumber.SetText(WebDriver, poNum);
            TxtFaxId.SetText(WebDriver, faxId);
            ChkDoYouAgreeToTermsConditions(paymentMethodIndex).SelectCheckBox(WebDriver);

            return this;
        }

        public CreditCard GetSubscriptionCreditCardFromPaymentMethodData(string paymentMethod)
        {
            string[] paymentData = paymentMethod.Split('|');
            var card = CreditCard.GetTestCard();
            switch (paymentData[1].ToLower())
            {

                case "visa":
                    card.CardType = "Visa";
                    break;
                case "master":
                    card.CardType = "MasterCard";
                    break;
                case "mastercard":
                    card.CardType = "MasterCard";
                    break;
                case "discover":
                    card.CardType = "Discover";
                    break;
                case "amex":
                    card.CardType = "AmericanExpress";
                    break;
                case "americanexpress":
                    card.CardType = "AmericanExpress";
                    break;
            }

            card.CreditCardNumber = paymentData[2];
            if (paymentData.Length > 3) card.Cid = paymentData[3];

            return card;
        }

        public bool IsPONotificationMsgVisible()
        {
            return PONotificationMsg.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)); 
        }

        public OrderReviewPage ClickNext()
        {
            BtnNext.Click(WebDriver);
            return new OrderReviewPage(WebDriver);
        }

        public OrderReviewPage ClickNextOnSbPage()
        {
            NextBtn.Click(WebDriver);
            return new OrderReviewPage(WebDriver);
        }

        public IWebElement ChkDoYouAgreeToTermsConditions(int position=1)
        {
            return
                WebDriver.GetElements(By.Id("is_consented"))[position - 1];
        }
        public IWebElement lblPaymentType(int position)
        {
            return
                WebDriver.GetElements(By.XPath("//bill-plan/div//div//div//div//div[2]//div"))[position - 1];
        }

        public bool ChargeDescriptionTextboxExists()
        {
            try
            {
                if (WebDriver.GetElements(By.Id("cartPayment_cardChargeDescription")).Count > 0)
                    return true;
            }
            catch(Exception ex)
            {
                return false;
            }            
            return false;
        }

        public bool customerReferenceNumberTextboxExists()
        {
            try
            {
                if (WebDriver.GetElements(By.Id("cartPayment_customerReferenceNumber")).Count > 0)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }

        public void WaitForDisclosureToDisplay()
        {
            WebDriver.WaitFor(x => x.FindElementBy(By.XPath("//label[@for='is_consented']/span//span"), TimeSpan.FromSeconds(60)));
        }
        public bool VerifyIfChargeDescriptionTextBoxIsDisplayed()
        {
            return ChargeDescriptionTextbox[1].IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(20));             
        }

        public IWebElement IsCCMandatory { get { return WebDriver.GetElement(By.XPath("//label[@for='cartPayment_ccNumber']/following-sibling::div/input[contains(@class,'dsa-validation-highlight')]")); } }
        //public IWebElement IsCCMandatory { get { return WebDriver.GetElement(By.XPath("//label[@for='cartPayment_ccNumber']/following-sibling::div/input[contains(@class,'dsa-validation-highlight')]")); } }

        public void EnterCardDetailsForEMEA(IWebDriver driver, int paymentMethodIndex, CreditCard card)
        {
            new FlexBillingRenewalPage(driver)
                .EnterNameOnCard(paymentMethodIndex, card.NameOnCard)
                .EnterCreditCardNumber(paymentMethodIndex, card.CreditCardNumber)
                .EnterCreditCardExpiration(paymentMethodIndex, card.ExpirationMonth, card.ExpirationYear)
                .EnterCreditCardCid(paymentMethodIndex, card.Cid)
                .EnterCreditCardPhoneNumber(paymentMethodIndex, card.PhoneNumber);

            if (customerReferenceNumberTextbox[paymentMethodIndex - 1].IsElementDisplayed(driver, TimeSpan.FromSeconds(10)))
            {
                customerReferenceNumberTextbox[paymentMethodIndex - 1].SetText(driver, card.CustomerReferenceNumber);
            }

            //if (VerifyIfChargeDescriptionTextBoxIsDisplayed())
            //{
            //    ChargeDescriptionTextbox[paymentMethodIndex - 1].SetText(driver, card.ChargeDescription);
            //}
            //else
            //{
            //    Logger.Write("Charge description is not displayed");
            //}
        }
    }
}