using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;

namespace Dsa.Pages.POM
{
    public class QuotePageEditPomPopup : DsaPageBase
    {
        public QuotePageEditPomPopup(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "EditUploadPomPopup";
            PageFactory.InitElements(webDriver, this);
            webDriver.VerifyBusyOverlayNotDisplayed();
        }

        #region Elements

        

public IWebElement EditPomPopup { get { return WebDriver.GetElement(By.Id("quoteDetail_setDefaultContract")); } }
        

public IWebElement TxtPomid { get { return WebDriver.GetElement(By.XPath(".//input[@id='quoteDetail_sendPoRequest_pomId']")); } }



public IWebElement BtnCancel { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_cancel")); } }
        #endregion


    }
}
