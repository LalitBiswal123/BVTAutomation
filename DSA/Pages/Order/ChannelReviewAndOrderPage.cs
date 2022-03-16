using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Order
{
    public class ChannelReviewAndOrderPage : DsaPageBase
    {
        public ChannelReviewAndOrderPage(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "Channel Review & Order Page";
            PageFactory.InitElements(WebDriver, this);
            webDriver.VerifyBusyOverlayNotDisplayed();
        }

        #region Elements


public IWebElement BtnBack { get { return WebDriver.GetElement(By.Id("BackButton")); } }


public IWebElement BtnPlaceOrder { get { return WebDriver.GetElement(By.Id("PlaceOrderButton")); } }


public IWebElement BtnPlaceOrderFromPricingSummary { get { return WebDriver.GetElement(By.Id("PaymentLink")); } }


public IWebElement BtnContinueToCheckoutFromPricingSummary { get { return WebDriver.GetElement(By.Id("lblContinue")); } }


public IWebElement TxtReviewPageLegalFooter { get { return WebDriver.GetElement(By.XPath("//div[contains(@class,'footer-text')]")); } }

        #endregion

        public IWebElement UCIDNumber(int? index = 0)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='ShipGroup" + index + "_shipTo_UCID']"));
        }


    }
}
