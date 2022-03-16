using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
    public class SendPoRequestPage : DsaPageBase
    {
        public SendPoRequestPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements
      

public IWebElement ChooseFileUpload { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderExport_pomFileUpload_chooseFile")); } }
        

public IWebElement DestinationWorkGroup { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderExport_sendPoRequest_destinationWorkgroup")); } }
        

public IWebElement SourceAddressEmail { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderExport_sendPoRequest_poSourceAddress_emailValue")); } }


public IWebElement TxtSaveAsOrderPoNumber { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderExport_sendPoRequest_poNumber")); } }


public IWebElement TxtSaveAsOrderPoAmount { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderExport_sendPoRequest_poAmount")); } }
        

public IWebElement TxtSaveAsOrderComments { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderExport_sendPoRequest_comments")); } }


public IWebElement SaveAsOrderCreditCardPOCb { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderExport_sendPoRequest_creditCardPO")); } }
        

public IWebElement SaveAsOrderBlanketPOCb { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderExport_sendPoRequest_blanketPO")); } }


public IWebElement BtnSaveAsOrderSend { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderExport_sendPoRequest_send")); } }


public IWebElement BtnSaveAsOrderCancel { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderExport_sendPoRequest_cancel")); } }


public IWebElement BtnSaveAsOrderAddSuppDoc { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderExport_pomFileUpload_supplementaryPOUpload")); } }
        

public IWebElement BtnSaveAsOrderCloseOk { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderExport_sendPoRequest_close")); } }

        #endregion
    }
}
