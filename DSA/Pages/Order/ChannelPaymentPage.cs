using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dsa.DataModels;
using Dsa.Enums;
using Dsa.Utils;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Dsa.Pages.Order
{
    public class ChannelPaymentPage : DsaPageBase
    {
        public ChannelPaymentPage(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "Channel Payment Page";
            PageFactory.InitElements(WebDriver, this);
            webDriver.VerifyBusyOverlayNotDisplayed();
        }

        
        #region Elements


public IWebElement LblNetTermsPaymentMethodName { get { return WebDriver.GetElement(By.XPath("//*[@id='lblnetTerms_name']/following-sibling::div")); } }


public IWebElement LblNetTermsPaymentAmount { get { return WebDriver.GetElement(By.XPath("//*[@id='lblnetTerms_amount']/following-sibling::div")); } }


public IWebElement LblPaymentTerms { get { return WebDriver.GetElement(By.XPath("//*[@id='lblnetTerms_payment_terms']/following-sibling::div")); } }


public IWebElement LblPaymentTermsTile { get { return WebDriver.GetElement(By.Id("lblnetTerms_payment_terms")); } }


public IWebElement LblThirdPartyPaymentMethodName { get { return WebDriver.GetElement(By.XPath("//*[@id='lblthirdparty_name']/following-sibling::div")); } }


public IWebElement LblThirdPartyPaymentAmount { get { return WebDriver.GetElement(By.XPath("//*[@id='lblthirdparty_amount']/following-sibling::div")); } }


public IWebElement LblInlineErrorMessageBelowDropdown { get { return WebDriver.GetElement(By.XPath("(//*[contains(@class,'content-error')])[1]")); } }


public IWebElement LblInlineErrorMessageBelowPoNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='lblpoNumber']/following::*[contains(@class,'content-error')]")); } }


public IList<IWebElement> LblsValidationsOnTopOfThePage { get { return WebDriver.GetElements(By.XPath("//payment-validation-summary//*[contains(@class,'alert-body')]")); } }


public IWebElement LblPaymentMethod { get { return WebDriver.GetElement(By.Id("lblPaymentMethod_name")); } }


public IWebElement DdlPaymentMethod { get { return WebDriver.GetElement(By.Id("paymentOptions1")); } }


public IWebElement DdlFunderOption { get { return WebDriver.GetElement(By.Id("funderOptions")); } }


public IWebElement LblAmountTitle { get { return WebDriver.GetElement(By.Id("lblwireTransfer_amount")); } }


public IWebElement LblAmounValue { get { return WebDriver.GetElement(By.Id("lbl_amount")); } }


public IWebElement LblPONumber { get { return WebDriver.GetElement(By.Id("lblpoNumber")); } }


public IWebElement TxtPoNumber { get { return WebDriver.GetElement(By.Id("txtPoNumber")); } }


public IWebElement BtnBack { get { return WebDriver.GetElement(By.Id("BackButton")); } }


public IWebElement BtnContinueToCheckout { get { return WebDriver.GetElement(By.Id("ContinueLink")); } }


public IWebElement BtnContinueToCheckoutFromPricingSummary { get { return WebDriver.GetElement(By.Id("lblContinue")); } }


public IWebElement LblReviewOrder { get { return WebDriver.GetElement(By.Id("lblreviewOrder")); } }

        //Pricing Summary 

public IWebElement LblPricingSummaryListPrice { get { return WebDriver.GetElement(By.Id("pricingSummary_listPrice")); } }


public IWebElement LblPricingSummaryDiscount { get { return WebDriver.GetElement(By.Id("pricingSummary_discount")); } }


public IWebElement LblPricingSummarySellingPrice { get { return WebDriver.GetElement(By.Id("pricingSummary_sellingPrice")); } }


public IWebElement LblPricingSummaryShippingPrice { get { return WebDriver.GetElement(By.Id("pricingSummary_shippingPrice")); } }


public IWebElement LblPricingSummaryShippingDiscount { get { return WebDriver.GetElement(By.Id("pricingSummary_shippingDiscount")); } }


public IWebElement LblPricingSummaryTotalShipping { get { return WebDriver.GetElement(By.Id("pricingSummary_totalShipping")); } }


public IWebElement LblPricingSummaryTaxableAmount { get { return WebDriver.GetElement(By.Id("pricingSummary_taxableAmount")); } }


public IWebElement LblPricingSummaryNonTaxableAmount { get { return WebDriver.GetElement(By.Id("pricingSummary_nonTaxableAmount")); } }


public IWebElement LblPricingSummaryTotalTax { get { return WebDriver.GetElement(By.Id("pricingSummary_totalTax")); } }


public IWebElement LblPricingSummarySubTotal { get { return WebDriver.GetElement(By.Id("pricingSummary_subTotal")); } }


public IWebElement LblPricingSummaryTotalEcoFee { get { return WebDriver.GetElement(By.Id("pricingSummary_totalEcoFee")); } }


public IWebElement LblPricingSummaryFinalPrice { get { return WebDriver.GetElement(By.Id("pricingSummary_finalPrice")); } }


public IWebElement LnkUpdatePrice { get { return WebDriver.GetElement(By.XPath("//*[@id='applyRemainder_togglnee']")); } }


public IWebElement PaymentAdjustMessage { get { return WebDriver.GetElement(By.XPath("//p[contains(text(),'Your payment amount')]")); } }

        public IWebElement PaymentTerms { get { return WebDriver.GetElement(By.XPath("//*[@id='paymentTerms']")); } }

        public IWebElement PONumber { get { return WebDriver.GetElement(By.XPath("//*[@id='paymentPoNo']")); } }
        public IWebElement POMID { get { return WebDriver.GetElement(By.XPath("/html/body/app-root/div[1]/div[2]/div/div/ng-component/div/div[2]/div[1]/div[3]/div/div/purchase-order/app-po-upload/div/div[2]/div[1]/div[2]/input")); } }
        public IWebElement PONumberReceivedDate { get { return WebDriver.GetElement(By.Id("//*[@id='mat-input-0']")); } }
        public IWebElement TabReview_Order { get { return WebDriver.GetElement(By.XPath("//*[text()='Review & Order']")); } }

        //ERROR MSG
        public IWebElement ErrInvalidPONumber { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),' Invalid PO number. Only Alphanumeric and following special characters are allowed.')]")); } }

        public ChannelPaymentPage EnterPoNumberPOMID(string poNumber, string pomid)
        {
            PONumber.SetText(WebDriver, poNumber);
            POMID.SetText(WebDriver, pomid);
            //PONumberReceivedDate.SendKeys(Keys.Tab + Keys.Enter);
            //PONumberReceivedDate.SetText(WebDriver, Keys.Tab + Keys.Enter);
            return new ChannelPaymentPage(WebDriver);
        }

        public IWebElement LegalFooterText { get { return WebDriver.GetElement(By.XPath("//div[@class='footer-text']")); } }


public IWebElement PageHeader { get { return WebDriver.GetElement(By.XPath("//h1[@class='page-header']")); } }

        public IWebElement GetCPQPaymentMethodSection(int paymentMethodIndex)
        {
            return WebDriver.GetElements(By.XPath("//*[@id='splitPaymentContainer']/payment-creditcard/form/div/div"))[paymentMethodIndex - 1];
        }


        #endregion



        public PaymentsPage SelectPaymentMethod(IWebDriver driver, PaymentMethodType paymentMethod)
        {

            switch (paymentMethod)
            {
                case PaymentMethodType.BusinessLease:
                    new ChannelPaymentPage(driver).DdlPaymentMethod
                        .PickDropdownByText(driver, "BusinessLease");
                    break;

                case PaymentMethodType.CreditCard:
                    new ChannelPaymentPage(driver).DdlPaymentMethod
                        .PickDropdownByText(driver, "CreditCard");
                    break;

                case PaymentMethodType.MasterLeaseAgreement:
                    new ChannelPaymentPage(driver).DdlPaymentMethod
                       .PickDropdownByText(driver, "MasterLeaseAgreement");
                    break;

                case PaymentMethodType.WireTransfer:
                    new ChannelPaymentPage(driver).DdlPaymentMethod
                       .PickDropdownByText(driver, "WireTransfer");
                    break;

                case PaymentMethodType.NetTerms:
                    new ChannelPaymentPage(driver).DdlPaymentMethod
                        .PickDropdownByText(driver, "NetTerms");
                    break;

                case PaymentMethodType.Prepaidcheck:
                    new ChannelPaymentPage(driver).DdlPaymentMethod
                       .PickDropdownByText(driver, "Prepaidcheck");
                    break;

                case PaymentMethodType.DfsLoanSoftware:
                    new ChannelPaymentPage(driver).DdlPaymentMethod
                        .PickDropdownByText(driver, "DfsLoanSoftware");
                    break;

                case PaymentMethodType.DFSLoanSoftwarenonMLA:
                    new ChannelPaymentPage(driver).DdlPaymentMethod
                         .PickDropdownByText(driver, "DFS Loan/Software non-MLA");
                    break;

                default:
                    Logger.Write("No supported Payment Method selected");
                    break;

            }
            return new PaymentsPage(driver);
        }


        public void EnterCPQCreditCardDetails(IWebDriver driver, int paymentMethodIndex, CreditCard card)
        {
            GetCPQPaymentMethodSection(paymentMethodIndex)
                .FindElement(By.Id("txt_name_on_card"))
                .SetText(WebDriver, card.NameOnCard);
            GetCPQPaymentMethodSection(paymentMethodIndex)
                .FindElement(By.Id("txt_creditcard_number"))
                .SetText(WebDriver, card.CreditCardNumber);

            GetCPQPaymentMethodSection(paymentMethodIndex)
                .FindElement(By.Id("expiration_year"))
                .PickDropdownByText(WebDriver, card.ExpirationYear);
            GetCPQPaymentMethodSection(paymentMethodIndex)
                .FindElement(By.Id("expiration_month"))
                .PickDropdownByText(WebDriver, card.ExpirationMonth);

            GetCPQPaymentMethodSection(paymentMethodIndex)
                .FindElement(By.Id("txt_security_code"))
                .SetText(WebDriver, card.Cid);

            GetCPQPaymentMethodSection(paymentMethodIndex)
                .FindElement(By.Id("txt_phone_number"))
                .SetText(WebDriver, card.PhoneNumber);
        }

        public List<String> getCPQPaymentMethodList(IWebDriver driver)
        {
            SelectElement paymentMehodDropDown = new SelectElement(DdlPaymentMethod);
            IList<IWebElement> paymentMethods = paymentMehodDropDown.Options;
            List<String> paymentMethodValues = new List<String>();
            foreach (IWebElement option in paymentMethods)
            {
                paymentMethodValues.Add(option.Text.Trim());
            }
            return paymentMethodValues;
        }

        public bool isPaymentMethodAvailabe(IWebDriver driver, String paymentMethod)
        {
            bool paymentMethodAvailabe = false;
            List<String> paymentMethods = getCPQPaymentMethodList(driver);
            paymentMethodAvailabe = paymentMethods.Contains(paymentMethod);
            return paymentMethodAvailabe;
        }

        public void checkAndProcessApplyRemainder(IWebDriver driver)
        {
            if (PaymentAdjustMessage.IsElementDisplayed(driver))
            {
                LnkUpdatePrice.IsElementDisplayed(driver).Should().Be(true);
                LnkUpdatePrice.Click(driver);
                BtnContinueToCheckout.Click(driver);
            }
            else
            {
                Logger.Write("Continue Checking Out :");
            }
        }

        public String checkAndProcessApplyRemainderAndReturnNewSellingPrice(IWebDriver driver, String TotalSellingPrice)
        {
            if (PaymentAdjustMessage.IsElementDisplayed(driver))
            {
                LnkUpdatePrice.IsElementDisplayed(driver).Should().Be(true);
                LnkUpdatePrice.Click(driver);
                TotalSellingPrice = LblAmounValue.Text;
                BtnContinueToCheckout.Click(driver);
            }
            else
            {
                Logger.Write("Continue Checking Out :");
            }

            return TotalSellingPrice;
        }

        public void validateListOfFieldsForPaymentMethod(IWebDriver driver, String PaymentMethod)
        {
            List<IWebElement> ExpectedElementsToBePresent = new List<IWebElement>();
            List<IWebElement> ExpectedElementsNotToPresent = new List<IWebElement>();
            switch (PaymentMethod)
            {
                case "MasterLeaseAgreement":
                case "BusinessLease":
                case "WireTransfer":
                case "PrepaidCheck":
                    //ExpectedElementsToBePresent = new List<IWebElement>();
                    ExpectedElementsToBePresent.Add(LblPaymentMethod);
                    ExpectedElementsToBePresent.Add(DdlPaymentMethod);
                    ExpectedElementsToBePresent.Add(LblAmountTitle);
                    ExpectedElementsToBePresent.Add(LblAmounValue);
                    ExpectedElementsToBePresent.Add(LblPONumber);
                    ExpectedElementsToBePresent.Add(TxtPoNumber);

                    ExpectedElementsNotToPresent.Add(DdlFunderOption);
                    ExpectedElementsNotToPresent.Add(LblPaymentTermsTile);
                    ExpectedElementsNotToPresent.Add(LblPaymentTerms);
                    break;

                case "NetTerms":
                    //ExpectedElementsToBePresent = new List<IWebElement>();
                    ExpectedElementsToBePresent.Add(LblPaymentMethod);
                    ExpectedElementsToBePresent.Add(DdlPaymentMethod);
                    ExpectedElementsToBePresent.Add(LblAmountTitle);
                    ExpectedElementsToBePresent.Add(LblAmounValue);
                    ExpectedElementsToBePresent.Add(LblPONumber);
                    ExpectedElementsToBePresent.Add(TxtPoNumber);
                    ExpectedElementsToBePresent.Add(LblPaymentTerms);
                    ExpectedElementsToBePresent.Add(LblPaymentTermsTile);
                    break;

                
            }
            foreach (IWebElement elment in ExpectedElementsToBePresent)
            {
                bool elementAvailable = driver.TryFindElement(elment);
                Assert.IsTrue(elementAvailable);
            }
            foreach (IWebElement elment in ExpectedElementsNotToPresent)
            {
                bool elementAvailable = driver.TryFindElement(elment);
                Assert.IsFalse(elementAvailable);
            }
    
        }

        public bool VerifyLegalFooterIsDisplayedWithValidText(String inputFooter)
        {

            String actualText = DsaUtil.GetText(LegalFooterText, WebDriver, TimeSpan.FromSeconds(50));
            string pattern = "\\s+";
            string replacement = " ";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(actualText, replacement);
            return String.Equals(result, inputFooter, StringComparison.OrdinalIgnoreCase);

        }

        public List<String> GetListPaymentMethodsAvailableInDropdown(String dropdownNumber)
        {
            List<String> list = new List<string>();
            foreach (IWebElement option in WebDriver.FindElements(By.XPath("//select[@id='paymentOptions" + dropdownNumber + "']/option")))
            {
                try
                {
                    list.Add(option.Text.Trim());
                }
                catch (Exception) { }
            }
            return list;
        }

        public void SelectPaymentMethod(IWebDriver testWebDriver, object wireTransfer)
        {
            throw new NotImplementedException();
        }

        public List<String> GetListPaymentCodesAvailableInDropdown(String dropdownNumber)
        {
            List<String> list = new List<string>();
            foreach (IWebElement option in WebDriver.FindElements(By.XPath("//select[@id='paymentOptions" + dropdownNumber + "']/option")))
            {
                try
                {
                    list.Add(option.GetAttribute("value").Trim());
                }
                catch (Exception) { }
            }
            return list;
        }

    }
}
