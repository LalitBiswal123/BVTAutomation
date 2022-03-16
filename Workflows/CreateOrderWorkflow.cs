using System;
using Dell.Adept.Testing.DataGenerators.Primitive;
using Dsa.DataModels;
using Dsa.Enums;
using Dsa.Pages;
using Dsa.Pages.Quote;
using Dsa.Utils;
using OpenQA.Selenium;
using Dsa.Pages.Order;


namespace Dsa.Workflows
{
    public class CreateOrderWorkflow
    {
        #region Create Order From Quote Details

        public static OrderDetailsPage CreateOrderFromQuoteDetails(IWebDriver driver, string paymentMethod)
        {
            var quoteDetails = new QuoteDetailsPage(driver);
            var orderSave = quoteDetails.CreateOrder().WillNotExportOutsideUs()
                .EmailConfirmationNext()
                .SelectFirstPaymentMethod(paymentMethod);
            orderSave.TxtPoNumber.SetText(driver, Generator.RandomString(8, Generator.RandomCharacterGroup.AlphaNumericOnly));
            orderSave.PaymentMethodNext();
            return new OrderReviewPage(driver).SaveOrder();
        }

        #endregion


        #region Create Order From Create Quote Page

        public static OrderDetailsPage CreateOrderFromCreateQuotePage(IWebDriver driver, string paymentMethod)
        {
            var createQuote = new CreateQuotePage(driver);
            var orderSave = createQuote.CreateOrder().WillNotExportOutsideUs()
                .EmailConfirmationNext()
                .SelectFirstPaymentMethod(paymentMethod);

            orderSave.PaymentMethodNext();
            return new OrderReviewPage(driver).SaveOrder();
        }

        #endregion

        #region Create Order From Quote Details Return Summary

        public static string CreateOrderFromQuoteDetailsReturnSummary(IWebDriver driver, string paymentMethod)
        {
            var quoteDetails = new QuoteDetailsPage(driver);
            var orderSave = quoteDetails.CreateOrder()
                .WillNotExportOutsideUs()
                .EmailConfirmationNext()
                .SelectFirstPaymentMethod(paymentMethod);
            orderSave.TxtPoNumber.SetText(driver,
                Generator.RandomString(8, Generator.RandomCharacterGroup.AlphaNumericOnly));
            orderSave.PaymentMethodNext();
            var summary = driver.GetElement(By.ClassName("smry-info")).Text;
            new OrderReviewPage(driver).SaveOrder();
            return summary;

        }

        #endregion

        #region Get To Order Review From Quote Details

        public static void GetToOrderReviewFromQuoteDetails(IWebDriver driver, string paymentMethod)
        {
            var quoteDetails = new QuoteDetailsPage(driver);
            var orderSave = quoteDetails.CreateOrder()
                .WillNotExportOutsideUs()
                .EmailConfirmationNext()
                .SelectFirstPaymentMethod(paymentMethod);
            orderSave.TxtPoNumber.SetText(driver,
                Generator.RandomString(8, Generator.RandomCharacterGroup.AlphaNumericOnly));
            orderSave.PaymentMethodNext();
        }

        #endregion

        #region Get Ton Order Review From Quote Details Without Sending Order

        public static void GetToOrderReviewFromQuoteDetailsWithoutSendingOrder(IWebDriver driver, string paymentMethod)
        {
            var quoteDetails = new QuoteDetailsPage(driver);
            var orderSave = quoteDetails.CreateOrder()
                .WillNotExportOutsideUs()
                .EmailConfirmationNextWithoutSendingOrder()
                .SelectFirstPaymentMethod(paymentMethod);
            orderSave.TxtPoNumber.SetText(driver,
                Generator.RandomString(8, Generator.RandomCharacterGroup.AlphaNumericOnly));
            orderSave.PaymentMethodNext();
        }

        #endregion

        #region Enter DPA Through Run Credit In Payment Page

        public static PaymentsPage EnterDpaThroughRunCreditInPaymentPage(IWebDriver driver, Dpa dpaData)
        {
            new PaymentsPage(driver).RunCredit().EnterDpaInformationForRunCredit(dpaData);
            return new PaymentsPage(driver).CompleteDpaInformation().AcceptPromotionDisclosure();
        }

        public static FlexBillingRenewalPage EnterDpaThroughRunCreditInSubbillingPage(IWebDriver driver, Dpa dpaData)
        {
            new PaymentsPage(driver).RunCredit().EnterDpaInformationForRunCredit(dpaData);
            return new FlexBillingRenewalPage(driver);
        }

        public static FlexBillingRenewalPage CompleteDPAInformationInSubbillingPage(IWebDriver driver, Dpa dpaData)
        {
            new PaymentsPage(driver).CompleteDpaInformation().AcceptPromotionDisclosure();
           return new FlexBillingRenewalPage(driver);
        }
        #endregion

        #region Critical Path Create Order

        public static OrderDetailsPage CriticalPathCreateOrder(IWebDriver driver, string paymenttype)
        {
            var orderdetailpage = CreateOrderFromQuoteDetails(driver, paymenttype);
            orderdetailpage.ExpandCustomerSection();
            var dpid = orderdetailpage.LblDpid.GetText(driver);
            try
            {
                System.IO.File.AppendAllText("\nC:\\DPIDs\\criticalpathids.txt", dpid);
            }
            catch (Exception)
            {
            }

            //            System.Threading.Thread.Sleep(30000);

            return orderdetailpage;
        }

        #endregion

        #region Save Order with One Payment Method

        public static OrderDetailsPage SaveOrderWithOnePaymentMethod(IWebDriver driver, PaymentMethodType paymentMethod,
            double? amount = null, CreditCard creditCard = null, GiftCard giftCard = null)
        {
            CreateOrderTillPaymentPage(driver);
            EnterPaymentData(driver, 1, paymentMethod, amount, creditCard, giftCard);

            new PaymentsPage(driver).PaymentMethodNext();
            return new OrderReviewPage(driver).SaveOrder();
        }

        #endregion

        #region Create Order Till Payment Page

        public static PaymentsPage CreateOrderTillPaymentPage(IWebDriver driver, string sendTo = "com_qe@dell.com", string attachmentType = "PDF Attachment")
        {
            return new QuoteDetailsPage(driver)
                .WaitForQuoteValidationToComplete()
                .CreateOrder()
                .WillNotExportOutsideUs()
                .ProcessOrderAcknowledgement(attachmentType, sendTo);
        }

        #endregion

        #region Get To Payments page From Quote Details Without Sending Order

        public static void GetToPaymentsFromQuoteDetailsWithoutSendingOrder(IWebDriver driver)
        {
            var quoteDetails = new QuoteDetailsPage(driver);
            var paymentsPage = quoteDetails.CreateOrder()
                                          .WillNotExportOutsideUs()
                                          .EmailConfirmationNextWithoutSendingOrder();
        }

        #endregion


        #region Enter Payment Data

        public static PaymentsPage EnterPaymentData(IWebDriver driver, int paymentMethodIndex,
            PaymentMethodType paymentMethod, double? amount = null, CreditCard creditCard = null,
            GiftCard giftCard = null)
        {
            if (paymentMethodIndex > 1)
                new PaymentsPage(driver).LnkAddPaymentMethod.Click(driver);
            switch (paymentMethod)
            {
                case PaymentMethodType.BusinessLease:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex)
                        .PickDropdownByText(driver, "BusinessLease");
                    break;

                case PaymentMethodType.CreditCard:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex)
                        .PickDropdownByText(driver, "CreditCard");
                    new PaymentsPage(driver).EnterCreditCardDetails(driver, paymentMethodIndex, creditCard);
                    break;

                case PaymentMethodType.CreditCardIvr:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex)
                        .PickDropdownByText(driver, "CreditCardIVR");
                    break;

                case PaymentMethodType.MasterLeaseAgreement:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex)
                        .PickDropdownByText(driver, "MasterLeaseAgreement");
                    break;

                case PaymentMethodType.WireTransfer:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex)
                        .PickDropdownByText(driver, "WireTransfer");
                    break;

                case PaymentMethodType.NetTerms:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex).PickDropdownByText(driver, "NetTerms");
                    // new PaymentsPage(driver).TxtPoNumber.SetText(driver,Generator.RandomString(12, Generator.RandomCharacterGroup.AlphaNumericOnly).ToLowerInvariant());
                    break;

                case PaymentMethodType.GovernmentLease:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex)
                        .PickDropdownByText(driver, "GovernmentLease");
                    break;

                case PaymentMethodType.MediaEvalOrTradeShow:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex)
                        .PickDropdownByText(driver, "MediaEvalOrTradeShow");
                    break;

                case PaymentMethodType.DellPreferredAccount:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex)
                        .PickDropdownByText(driver, "Dell Preferred Account");
                    break;
                case PaymentMethodType.DellBusinessCredit:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex)
                        .PickDropdownByText(driver, "Dell Business Credit");
                    break;

                case PaymentMethodType.QuickLease:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex)
                        .PickDropdownByText(driver, "Quick Lease");
                    break;

                case PaymentMethodType.GiftCard:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex).PickDropdownByText(driver, "GiftCard");
                    new PaymentsPage(driver).EnterGiftCardDetails(driver, paymentMethodIndex, giftCard);
                    break;

                case PaymentMethodType.Prepaidcheck:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex)
                        .PickDropdownByText(driver, "Prepaidcheck");
                    break;

                case PaymentMethodType.BuyAndTry:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex)
                        .PickDropdownByText(driver, "BuyAndTry");
                    break;

                case PaymentMethodType.DfsLoanSoftware:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex)
                        .PickDropdownByText(driver, "DfsLoanSoftware");
                    break;

                case PaymentMethodType.FloorPlanning:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex)
                        .PickDropdownByText(driver, "FloorPlanning");
                    break;

                case PaymentMethodType.TransferOfFunds:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex)
                        .PickDropdownByText(driver, "TransferOfFunds");
                    break;

                case PaymentMethodType.RevenueAdjustment:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex)
                        .PickDropdownByText(driver, "RevenueAdjustment");
                    break;

                case PaymentMethodType.RecurringPayment:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex)
                        .PickDropdownByText(driver, "Recurring Payment");
                    break;

                case PaymentMethodType.TransferOfAuthorization:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex)
                        .PickDropdownByText(driver, "Transfer Of Authorization");
                    break;

                case PaymentMethodType.DFSLoanSoftwarenonMLA:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex)
                        .PickDropdownByText(driver, "DFS Loan/Software non-MLA");
                    break;

                case PaymentMethodType.DellAdvantage:
                    new PaymentsPage(driver).PaymentMethodDdl(paymentMethodIndex)
                        .PickDropdownByText(driver, "Dell Advantage");
                    break;
            }

            //if (amount != null)
            //    return new PaymentsPage(driver).EnterPaymentAmount(paymentMethodIndex, amount.Value);
            return new PaymentsPage(driver);
        }

        public static FlexBillingRenewalPage EnterSubscritionBillingPaymentData(IWebDriver driver, int paymentMethodIndex,
          PaymentMethodType paymentMethod, double? amount = null, CreditCard creditCard = null)
        {


            switch (paymentMethod)
            {
                case PaymentMethodType.CreditCard:
                    new FlexBillingRenewalPage(driver).DdlPaymentMethod(paymentMethodIndex).PickDropdownByText(driver, "Add Credit Card");
                    new FlexBillingRenewalPage(driver).EnterCreditCardDetails(driver, paymentMethodIndex, creditCard);
                    break;

                case PaymentMethodType.NetTerms:
                    new FlexBillingRenewalPage(driver).DdlPaymentMethod(paymentMethodIndex).PickDropdownByText(driver, "NetTerms");
                    // new PaymentsPage(driver).TxtPoNumber.SetText(driver,Generator.RandomString(12, Generator.RandomCharacterGroup.AlphaNumericOnly).ToLowerInvariant());
                    break;

                case PaymentMethodType.DellPreferredAccount:
                    new FlexBillingRenewalPage(driver).DdlPaymentMethod(paymentMethodIndex)
                        .PickDropdownByText(driver, "Dell Preferred Account");
                    break;
                case PaymentMethodType.DellBusinessCredit:
                    new FlexBillingRenewalPage(driver).DdlPaymentMethod(paymentMethodIndex)
                    .PickDropdownByText(driver, "Dell Business Credit");
                    break;

            }

            //if (amount != null)
            //    return new PaymentsPage(driver).EnterPaymentAmount(paymentMethodIndex, amount.Value);
            return new FlexBillingRenewalPage(driver);
        }

        public static void ProcessIndividualPaymentMethod(IWebDriver driver, string paymentMethod, int index, double? amount = null)
        {
            string[] paymentData = paymentMethod.Split('|');
            var payMethodTypeStr = paymentData[0];
            var paymentMethodType = (PaymentMethodType)Enum.Parse(typeof(PaymentMethodType), payMethodTypeStr.Replace(" ", string.Empty));

            switch (paymentMethodType)
            {
                case PaymentMethodType.CreditCard:
                    var cc = CreditCard.GetTestCard();
                    cc.CreditCardNumber = paymentData[1];
                    if (paymentData.Length > 2) cc.Cid = paymentData[2];
                    EnterPaymentData(driver, index, PaymentMethodType.CreditCard, amount, cc);
                    break;

                case PaymentMethodType.GiftCard:
                    var gc = GiftCard.GetTestCard();
                    gc.CardNumber = paymentData[1];
                    if (paymentData.Length > 2) gc.Cid = paymentData[2];
                    EnterPaymentData(driver, index, PaymentMethodType.GiftCard, amount, null, gc);
                    break;
                case PaymentMethodType.DellBusinessCredit:
                    EnterPaymentData(driver, index, PaymentMethodType.DellBusinessCredit);
                    break;
                default:
                    EnterPaymentData(driver, index, paymentMethodType);
                    break;
            }
        }

        public static PaymentsPage ProcessPaymentMehods(IWebDriver driver, string paymentMethod1, string paymentMethod2 = null,
            string paymentMethod3 = null, double? amount1 = null, double? amount2 = null, double? amount3 = null)
        {
            ProcessIndividualPaymentMethod(driver, paymentMethod1, 1);

            if (!string.IsNullOrEmpty(paymentMethod2))
            {
                ProcessIndividualPaymentMethod(driver, paymentMethod2, 2);
                if (!string.IsNullOrEmpty(paymentMethod3))
                {
                    ProcessIndividualPaymentMethod(driver, paymentMethod3, 3);
                }
            }

            if (amount1 != null && !string.IsNullOrEmpty(paymentMethod2))
            {
                new PaymentsPage(driver).EnterPaymentAmount(1, amount1.Value);
                if (string.IsNullOrEmpty(paymentMethod3)) new PaymentsPage(driver).ApplyRemainderAmount(2);
                else
                {
                    if (amount2 != null) new PaymentsPage(driver).EnterPaymentAmount(2, amount2.Value);
                    if (!string.IsNullOrEmpty(paymentMethod3)) new PaymentsPage(driver).ApplyRemainderAmount(3);
                }
            }

            return new PaymentsPage(driver);
        }

        public static OrderReviewPage EnterPaymentInformationWithDbc(IWebDriver driver, string lastName = "", string pin = "")
        {
            CompleteDFSInformation(driver, lastName, pin).PaymentMethodNext();
            return new OrderReviewPage(driver);
        }

        public static PaymentsPage CompleteDFSInformation(IWebDriver driver, string lastName = "", string pin = "")
        {

            if (!string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(pin))
                new PaymentsPage(driver).CompleteDfsInformation().EnterDfsInformation(driver, lastName, pin);
            return new PaymentsPage(driver);
        }


        public static OrderReviewPage EnterPaymentInformationWithQuickLease(IWebDriver driver, string processMethod)
        {
            var paymentPage = new PaymentsPage(driver);
            var dfsPaymentPage = new DfsPaymentPage(driver);
            paymentPage.CompleteQuickLeaseDfsInformation();
            if (paymentPage.IsAddPaymentReminder())
            {
                paymentPage.ApplyPaymentReminder.Click(driver);
                paymentPage.CompleteQuickLeaseDfsInformation();
            }
            dfsPaymentPage.EnterQuickLeaseData(driver, processMethod)
            .PaymentMethodNext();
            return new OrderReviewPage(driver);
        }

        public static void ClickAddPaymentReminder(IWebDriver driver, int paymentMethodIndex)
        {
            var paymentPage = new PaymentsPage(driver);
            if (paymentPage.IsAddPaymentReminder())
                paymentPage.ApplyRemainderAmount(paymentMethodIndex);
        }

        #endregion

        #region CancelOrder Checks

        public static bool OrderProcessingStatusCancelledAfterCancel(IWebDriver driver)
        {
            var orderDetails = new OrderDetailsPage(driver);
            
            int attempts = 10;

            while (attempts != 0)
            {
                var processingStatus = orderDetails.OrderStatus.GetText(driver);
                if (processingStatus.Contains("CAN"))
                {
                    break;
                }
                driver.RefreshCurrentPage();
                driver.WaitForPageLoad();
                attempts -= 1;

                if (attempts == 0)
                {
                    return false;
                }
            }
            return true;
        }


        public static void InstallationInstructions(IWebDriver driver, string instructions)
        {
            var quoteDetails = new QuoteDetailsPage(driver);
            quoteDetails.LnkInstallationInstructions.Click();
            quoteDetails.TxtInstallationInstructions.SetText(driver, instructions);

        }

        #endregion
    }
}    
