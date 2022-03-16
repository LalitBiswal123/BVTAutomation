using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
    public class PomGmirPage: DsaPageBase
    {
        public PomGmirPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement BtnSendPoRequest { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest")); } }


public IWebElement BtnSendPoRequestChooseFile { get { return WebDriver.GetElement(By.Id("quoteDetail_pomFileUpload_chooseFile")); } }


public IWebElement DdlSendPoRequestDestinationWorkgrooup { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_destinationWorkgroup")); } }


public IWebElement SendPoRequestPoSourceAddressEmail { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_poSourceAddress_emailValue")); } }


public IWebElement TxtSendPoRequestPoNumber { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_poNumber")); } }


public IWebElement TxtSendPoRequestPoAmount { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_poAmount")); } }


public IWebElement TxtSendPoRequestComment { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_comments")); } }


public IWebElement ChkboxSendPoRequestCreditCardPo { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_creditCardPO")); } }


public IWebElement ChkboxSendPoRequestBlanketPo { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_blanketPO")); } }


public IWebElement BtnSendPoRequestSend { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_send")); } }


public IWebElement BtnSendPoRequestCancel { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_cancel")); } }


public IWebElement BtnSendPoRequestAddSuppDoc { get { return WebDriver.GetElement(By.Id("quoteDetail_pomFileUpload_supplementaryPOUpload")); } }


public IWebElement BtnSendPoRequestCloseOK { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_close")); } }


public IWebElement LblSendPoRequestPomId { get { return WebDriver.GetElement(By.XPath(".//*[@id='quoteDetail_send_poRequest')]/div[2)]/div[2)]/label")); } }


public IWebElement LnkSaveAsOrderUploadPo { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderPayment_UploadPo")); } }


public IWebElement LnkSaveAsOrderChange { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderPayment_Change")); } }


public IWebElement BtnSaveAsOrderChooseFile { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderExport_pomFileUpload_primaryPOUpload")); } }


public IWebElement TxtSaveAsOrderPoNumberEdit { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderExport_sendPoRequest_poNumberEdit")); } }


public IWebElement TxtSaveAsOrderPoAmountEdit { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderExport_sendPoRequest_poAmountEdit")); } }


public IWebElement SaveAsOrderPomModal { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderExport_send_poRequest")); } }


public IWebElement LblSaveAsOrderPomId { get { return WebDriver.GetElement(By.Id("ABC")); } }


public IWebElement ReviewOrderPomIDDiv { get { return WebDriver.GetElement(By.Id("orderReview_pomId")); } }


public IWebElement LnkReviewOrderEditPomId { get { return WebDriver.GetElement(By.XPath("//*[@id='orderReview_pomId')]/span/a")); } }


public IWebElement BtnReviewOrderAddSupDoc { get { return WebDriver.GetElement(By.XPath("//*[@id='orderReview_send_poRequest')]/div[2)]/div[1)]/div[1)]/div[2)]/div[2)]/button")); } }


public IWebElement DdlReviewOrderDestinationWorkgroup { get { return WebDriver.GetElement(By.Id("orderReview_sendPoRequest_destinationWorkgroup")); } }


public IWebElement TxtReviewOrderPoSourceAddressEmailValue { get { return WebDriver.GetElement(By.Id("orderReview_sendPoRequest_poSourceAddress_emailValue")); } }


public IWebElement TxtReviewOrderPoNumberEdit { get { return WebDriver.GetElement(By.Id("orderReview_sendPoRequest_poNumberEdit")); } }


public IWebElement TxtReviewOrderPoAmountEdit { get { return WebDriver.GetElement(By.Id("orderReview_sendPoRequest_poAmountEdit")); } }


public IWebElement TxtReviewOrderReviewComments { get { return WebDriver.GetElement(By.Id("orderReview_sendPoRequest_comments")); } }


public IWebElement ReviewOrderCreditCardPoCb { get { return WebDriver.GetElement(By.Id("orderReview_sendPoRequest_creditCardPO")); } }


public IWebElement ReviewOrderBlanketPoCb { get { return WebDriver.GetElement(By.Id("orderReview_sendPoRequest_blanketPO")); } }


public IWebElement BtnReviewOrderSend { get { return WebDriver.GetElement(By.Id("orderReview_sendPoRequest_send")); } }


public IWebElement BtnReviewOrderCancel { get { return WebDriver.GetElement(By.Id("orderReview_sendPoRequest_cancel")); } }


public IWebElement LblReviewOrderAddendumMessage { get { return WebDriver.GetElement(By.XPath("//*[@id='orderReview_send_poRequest')]/div[2)]/div[2)]/label")); } }


public IWebElement BtnReviewOrderClose { get { return WebDriver.GetElement(By.Id("orderReview_sendPoRequest_close")); } }


public IWebElement LblOrderDetailsPomId { get { return WebDriver.GetElement(By.Id("orderDetails_pomId")); } }


public IWebElement LnkOrderDetailsEditPom { get { return WebDriver.GetElement(By.Id("orderDetails_pomId_Edit")); } }


public IWebElement BtnOrderDetailsAddSupDoc { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_send_poRequest')]/div[2)]/div[1)]/div[1)]/div[2)]/div[3)]/button")); } }


public IWebElement DdlOrderDetailsDestinationWorkGroup { get { return WebDriver.GetElement(By.Id("orderDetails_sendPoRequest_destinationWorkgroup")); } }

 //TODO
public IWebElement TxtOrderDetailsPoSourceAddressEmailValue { get { return WebDriver.GetElement(By.Id("ABC")); } }


public IWebElement TxtOrderDetailsPoNumberEdit { get { return WebDriver.GetElement(By.Id("orderDetails_sendPoRequest_poNumberEdit")); } }


public IWebElement TxtOrderDetailsPoAmountEdit { get { return WebDriver.GetElement(By.Id("orderDetails_sendPoRequest_poAmountEdit")); } }


public IWebElement TxtOrderDetailsComment { get { return WebDriver.GetElement(By.Id("orderDetails_sendPoRequest_comments")); } }


public IWebElement OrderDetailsCreditCardPoCb { get { return WebDriver.GetElement(By.Id("orderDetails_sendPoRequest_creditCardPO")); } }


public IWebElement OrderDetailsBlanketPoCb { get { return WebDriver.GetElement(By.Id("orderDetails_sendPoRequest_blanketPO")); } }


public IWebElement BtnOrderDetailsSend { get { return WebDriver.GetElement(By.Id("orderDetails_sendPoRequest_send")); } }


public IWebElement BtnOrderDetailsCancel { get { return WebDriver.GetElement(By.Id("orderDetails_sendPoRequest_cancel")); } }

 //TODO
public IWebElement LblOrderDetailsAddendumMessage { get { return WebDriver.GetElement(By.Id("ABC")); } }


public IWebElement BtnOrderDetailsClose { get { return WebDriver.GetElement(By.Id("orderDetails_sendPoRequest_close")); } }


public IWebElement BtnOrderDetailsMoreAction { get { return WebDriver.GetElement(By.Id("orderDetails_moreActions")); } }


public IWebElement BtnOrderDetailsGmir { get { return WebDriver.GetElement(By.Id("orderDetails_gmir")); } }


public IWebElement CloseGmirPomId { get { return WebDriver.GetElement(By.Id("_closePom_id")); } }


public IWebElement GmirClosePomIdYesRb { get { return WebDriver.GetElement(By.Id("_closePom_yesSelect")); } }


public IWebElement GmirClosePomIdNoRb { get { return WebDriver.GetElement(By.Id("_closePom_noSelect")); } }


public IWebElement GmirReasonDld { get { return WebDriver.GetElement(By.Id("closePOM_gmirReason")); } }


public IWebElement BtnGmirClosePomOK { get { return WebDriver.GetElement(By.Id("closePOM_ok")); } }


public IWebElement BtnGmirClosePomCancel { get { return WebDriver.GetElement(By.Id("closePOM_cancel")); } }


public IWebElement LblOrderDetailsGmirMessage { get { return WebDriver.GetElement(By.Id("orderDetails_gimrMessage")); } }

        #endregion
        
    }
}
