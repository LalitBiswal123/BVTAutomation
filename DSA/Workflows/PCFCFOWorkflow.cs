using Dsa.Pages.Order;
using Dsa.Utils;
using OpenQA.Selenium;
using Dsa.Pages;
using Dsa.Pages.Quote;
using HomeWorkFlow = Dsa.Workflows.HomeWorkflow;

namespace Dsa.Workflows
{
    public static class PCFCFOWorkflow
    {
        #region Work Flows for the SendWithPrimarySalesRep and PreviewWithPDFFormat


        public static QuoteEmailQueuedPage SendWithPrimarySalesRep(IWebDriver driver, bool primarySalesRep, bool loggedSalesRep, string sendToEmail, bool isDellPrint, bool includeMe, bool cc, bool sendToCustBilling, bool sendToCustShipping, string subject, string additionalComments)
        {

            var sendquote = new SendQuotePage(driver);
            string quoteSendCfoDetails = sendquote.SendCfo_details.GetText(driver);
            string quoteSendCfoSubject = sendquote.SendCfo_subject.GetText(driver);
            sendquote.Sendwithprimarysalesrep(primarySalesRep, loggedSalesRep, sendToEmail + "@dell.com", isDellPrint, includeMe, cc, sendToCustBilling, sendToCustShipping, quoteSendCfoDetails + quoteSendCfoSubject, additionalComments);
            return new QuoteEmailQueuedPage(driver);
        }

        public static PreviewQuoteEmail ViewPreviewBasedOnFormat(IWebDriver driver, string typeOfAttachment, string testeMail, bool isDellPrint, bool includeMe, bool cc, bool sendToCustBilling)
        {
            var sendquote = new SendQuotePage(driver);
            sendquote.ViewPreviewBasedOnFormat(typeOfAttachment, testeMail, isDellPrint, includeMe, cc, sendToCustBilling);

            return new PreviewQuoteEmail(driver);

        }

        public static SendQuotePage DownloadExcelWithPdfFormat(IWebDriver driver, string typeOfAttachment, string testeMail, bool isDellPrint, bool includeMe, bool cc, bool sendToCustBilling)
        {
            var sendQuote = new SendQuotePage(driver);
            sendQuote.DownloadExcelWithPDFFormat(typeOfAttachment, testeMail, isDellPrint, includeMe, cc, sendToCustBilling);
            return new SendQuotePage(driver);
        }

        public static QuoteEmailQueuedPage SendWithPdfFormat(IWebDriver driver, string typeOfAttachment, string testeMail, bool isDellPrint, bool includeMe, bool cc, bool sendToCustBilling)
        {

            var sendQuote = new SendQuotePage(driver);
            sendQuote.SendWithPDFFormat(typeOfAttachment, testeMail, isDellPrint, includeMe, cc, sendToCustBilling);
            return new QuoteEmailQueuedPage(driver);
        }

        #endregion


        #region Send order acknowledgement with PDF / HTML

        public static void SendOrderAcknowledgementCfo(IWebDriver driver, string attachmentType, string sendTo)
        {
            var emailConfirmationpage = new EmailConfirmationPage(driver);
            emailConfirmationpage.ProcessOrderAcknowledgement(attachmentType, sendTo);
        }

        #endregion

        #region Send order Cancel Acknowledgement

        public static void SendOrderCancelCfo(IWebDriver driver, string attachmentType, string sendTo)
        {
            var cancelOrderPage = new CancelOrderPage(driver);
            cancelOrderPage.ProcessOrderCancelAcknowledgement(attachmentType, sendTo);
        }
        #endregion
    }
}
