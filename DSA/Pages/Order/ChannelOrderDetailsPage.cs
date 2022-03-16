using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dsa.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Order
{
    public class ChannelOrderDetailsPage : DsaPageBase
    {
        public ChannelOrderDetailsPage(IWebDriver webDriver) : base(webDriver)
        {
            Name = "Channel Order Details Page";
            PageFactory.InitElements(WebDriver, this);
            webDriver.VerifyBusyOverlayNotDisplayed();
        }

        #region Elements


public IWebElement LblDpid { get { return WebDriver.GetElement(By.XPath("//*[@id='purchaseId']/h5")); } }


public IWebElement DpidNo { get { return WebDriver.GetElement(By.XPath("//div[@id='orderConfirmationWell']/descendant::h5[contains(text(),'2001')]")); } }


public IWebElement LblIrn { get { return WebDriver.GetElement(By.Id("internetReceiptNumber")); } }


public IWebElement LblOrderTotal { get { return WebDriver.GetElement(By.Id("orderTotal")); } }


public IWebElement LblOrderDate { get { return WebDriver.GetElement(By.Id("orderDate")); } }


public IWebElement OrderDate { get { return WebDriver.GetElement(By.XPath("//div[@id='orderConfirmationWell']/descendant::h5[3]")); } }


public IWebElement TxtOrderDetailPageLegalFooter { get { return WebDriver.GetElement(By.XPath("//div[contains(@class,'footer-text')]")); } }

        #endregion


        public void NavigateToOrder(IWebDriver webDriver, TestContext context, string dpid, string salesOrderId, string orderAmount)
        {
            var url = context.Properties["ChannelBaseUrl"].ToString()
                      + "order-confirmation/"
                      + dpid + "/"
                      + salesOrderId + "/"
                      + orderAmount;

            webDriver.Navigate().GoToUrl(url);

        }

    }
}
