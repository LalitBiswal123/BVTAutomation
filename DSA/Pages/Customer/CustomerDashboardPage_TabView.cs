using System;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Customer
{
    public class CustomerDashboardPage_TabView: DsaPageBase
    {
        public CustomerDashboardPage_TabView(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements



public IWebElement CustomerNameTxt { get { return WebDriver.GetElement(By.Id("customerDetails_header")); } }


public IWebElement LblCustomerNumber { get { return WebDriver.GetElement(By.Id("_customerNumber")); } }

        public IWebElement WidgetPurchase { get { return WebDriver.GetElement(By.Id("purchase_by_category_widget")); } }



public IWebElement AccountHeader { get { return WebDriver.GetElement(By.Id("ribbon-container")); } }


public IWebElement PurchaseHistoryGraphView { get { return WebDriver.GetElement(By.XPath("//*[@id='custom_purchase']")); } }

        //By WidgetPurchase = By.XPath("//*[@id='purchase_by_category_widget']/div[1]/div[1]");
        //By AccountHeader = By.Id("ribbon-container");
        //By PurchaseHistoryGraphView= By.XPath("//*[@id='custom_purchase']");
                    
        #endregion

       
        /// <summary></summary>
        /// <returns>
        /// Customer Number IWebElement
        /// </returns>
        public IWebElement GetCustomerNumber()
        {
            return LblCustomerNumber;
        }

        /// <summary></summary>
        /// <returns>
        /// Customer Name IWebElement
        /// </returns>
        public IWebElement GetCustomerName()
        {
            return CustomerNameTxt;
        }             


        /// <summary>
        ///  true if purchase history widget is displayed
        /// </summary>
        /// <returns></returns>
        public bool HasPurchaseHistoryWidget()
        {
            bool purchasewidget = false;
           var DashboardFrame =  WebDriver.SwitchTo().Frame(0);
          // DsaUtil.WaitForElement(WidgetPurchase, WebDriver);
           purchasewidget = WidgetPurchase.IsElementDisplayed(WebDriver, TimeSpan.FromMinutes(1));
           WebDriver.SwitchTo().DefaultContent();
           return purchasewidget;
        }

        /// <summary>
        /// Verify the account header section in the dashboard page
        /// </summary>
        /// <returns></returns>
        public bool HasAccountHeader()
        {
            var DashboardFrame = WebDriver.SwitchTo().Frame(0);
            DsaUtil.WaitForElement(AccountHeader, WebDriver);
            bool accountHeader = AccountHeader.Displayed;
            WebDriver.SwitchTo().DefaultContent();
            return accountHeader;
        }

        /// <summary>
        /// Verify the purchase history graph view in the dashboard
        /// </summary>
        /// <returns></returns>
        public bool HasPurchaseHistoryGraphView()
        {
            var DashboardFrame = WebDriver.SwitchTo().Frame(0);
            DsaUtil.WaitForElement(PurchaseHistoryGraphView, WebDriver);
            bool PurchaseGraphView = PurchaseHistoryGraphView.Displayed;
            WebDriver.SwitchTo().DefaultContent();
            return PurchaseGraphView;
        }

         
    }
}
