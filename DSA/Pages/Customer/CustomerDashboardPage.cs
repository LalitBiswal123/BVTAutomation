using System;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Customer
{
    public class CustomerDashboardPage: DsaPageBase
    {
        public CustomerDashboardPage(IWebDriver webDriver): base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements



public IWebElement CustomerNameTxt { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_name']/span[1]")); } }


public IWebElement LblCustomerNumber { get { return WebDriver.GetElement(By.Id("customerdetails_number")); } }


public IWebElement customerNumber { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_CustomerNumber")); } }


public IWebElement AccountNumberLabel { get { return WebDriver.GetElement(By.Id("customerDetails_informationComponent_accountComponent_accountNumber")); } }


public IWebElement LnkTabVersion { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDetails_name']/span[2]/a")); } }


public IWebElement IFrameDashboard { get { return WebDriver.GetElement(By.XPath("//*[@id='COM']/div[4]/form/div[2]/div/div/div[2]/iframe")); } }

       
        public IWebElement WidgetPurchase { get { return WebDriver.GetElement(By.Id("purchase_by_category_widget")); } }

        By widget = By.Id("purchase_by_category_widget");
        

public IWebElement AccountHeader { get { return WebDriver.GetElement(By.Id("ribbon-container")); } }


public IWebElement PurchaseHistoryGraphView { get { return WebDriver.GetElement(By.XPath("//*[@id='custom_purchase']")); } }

        //By WidgetPurchase = By.XPath("//*[@id='purchase_by_category_widget']/div[1]/div[1]");
        //By AccountHeader = By.Id("ribbon-container");
        //By PurchaseHistoryGraphView= By.XPath("//*[@id='custom_purchase']");


public IWebElement LnkClose { get { return WebDriver.GetElement(By.XPath("//button[@class='btn btn-default btn-xs']")); } }
     
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


        public CustomerDashboardPage_TabView ClickLnkTabVersion(IWebDriver driver)
        {
            LnkTabVersion.Click(driver);
            return new CustomerDashboardPage_TabView(driver);
        }

        /// <summary>
        ///  true if purchase history widget is displayed
        /// </summary>
        /// <returns></returns>
        public bool HasPurchaseHistoryWidget()
        {
           bool purchasewidget=false;
           //if (DsaUtil.WaitForElement(IFrameDashboard, WebDriver))
           //{
               var DashboardFrame = WebDriver.SwitchTo().Frame(0);             
               //DsaUtil.WaitForElement(WidgetPurchase, WebDriver);
              //purchasewidget= DashboardFrame.FindElement(widget).Displayed;
               purchasewidget = WidgetPurchase.IsElementDisplayed(WebDriver,TimeSpan.FromMinutes(1));
               WebDriver.SwitchTo().DefaultContent();
           //}

           return purchasewidget;
        }

        /// <summary>
        /// Verify the account header section in the dashboard page
        /// </summary>
        /// <returns></returns>
        public bool HasAccountHeader()
        {
            bool accountHeader = false;
            //if (DsaUtil.WaitForElement(IFrameDashboard, WebDriver))
            //{
                var DashboardFrame = WebDriver.SwitchTo().Frame(0);
                DsaUtil.WaitForElement(AccountHeader, WebDriver);
                accountHeader = AccountHeader.Displayed;
                WebDriver.SwitchTo().DefaultContent();
            //}
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
            bool PurchaseGraphView =PurchaseHistoryGraphView.Displayed;
            WebDriver.SwitchTo().DefaultContent();
            return PurchaseGraphView;
        }

        /// <summary>
        /// Method to close the dashboard window
        /// </summary>
        public void ClickLnkClose()
        {

            DsaUtil.Click(LnkClose, WebDriver);
        }

    }
}
