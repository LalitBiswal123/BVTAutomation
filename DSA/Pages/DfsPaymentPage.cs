using System;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Pages.Customer;
using Dsa.Pages.Order;
using Dsa.Pages.PCFConvergence;
using Dsa.Utils;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
//Testcheckin

namespace Dsa.Pages
{
    public class DfsPaymentPage : DsaPageBase
    {
        readonly TimeSpan _waitTime = TimeSpan.FromSeconds(150);

        public DfsPaymentPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }


public IWebElement TxtLastName { get { return WebDriver.GetElement(By.Id("LastName")); } }


public IWebElement TxtPin { get { return WebDriver.GetElement(By.Id("PIN")); } }


public IWebElement ChkCallBackWithPinInfo { get { return WebDriver.GetElement(By.Id("CallBackPinInformation")); } }


public IWebElement BtnNext { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='Next']")); } }


public IWebElement BtnCancel { get { return WebDriver.GetElement(By.CssSelector("//a[normalize-space()='Cancel']")); } }


public IWebElement BtnDbcPromotionDisclosureNext { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Next')]")); } }


public IWebElement DdlProcessMethod { get { return WebDriver.GetElement(By.Id("ProcessMethod")); } }


public IWebElement BtnQuicKLeaseNext { get { return WebDriver.GetElement(By.Id("btn-submit")); } }



public IWebElement ViewDfsDetails { get { return WebDriver.GetElement(By.XPath("//*[@id='declineScript']")); } }


public IWebElement DfsPageDbcTitle { get { return WebDriver.GetElement(By.XPath("//*[@id='dbc-details-title']")); } }


public IWebElement BtnDfsPageNext { get { return WebDriver.GetElement(By.XPath("//*[@id='dfs-details']//button")); } }



public IWebElement ViewDfSlinikforDpaCustomer { get { return WebDriver.GetElement(By.XPath("(//a[normalize-space()='View DFS Details'])")); } }


public IWebElement DpaPageCustomerName { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'Customer Name')]")); } }



public IWebElement DpaPageNextButton { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='Next']")); } }


public IWebElement BtnDPADetailsNext { get { return WebDriver.GetElement(By.XPath(".//button[contains(text(),'Next')]")); } }


public IWebElement BtnFeatureToggleUiContinue { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='Continue']")); } }

        public IWebElement ViewDfSlinikforDpaCustomerWithIndex(int index)
        {
            return WebDriver.FindElements(By.Id("consumerDfsDetails"))[index];
        }
        public void ContinueWithFeatureToggleUi()
        {
            if (BtnFeatureToggleUiContinue.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(30)))
            {
                BtnFeatureToggleUiContinue.WaitForElementVisible(_waitTime);
                BtnFeatureToggleUiContinue.Click();
            }
        }

        public T EnterDfsInformation<T>(IWebDriver driver, string lastName, string pin, bool callBackWithPinInfo = false)
        {            
            TxtLastName.WaitForElementVisible(_waitTime);
            TxtLastName.Click();
            TxtLastName.SetText(driver,lastName);
            TxtPin.WaitForElementVisible(_waitTime);
            TxtPin.Click();
            TxtPin.SetText(driver,pin);
            BtnNext.WaitForElementVisible(_waitTime);
            BtnNext.Click();
            BtnNext.Click();
            if (WebDriver.Url.Contains("DBCPromotionDisclosures"))
                {
                BtnNext.WaitForElementVisible(_waitTime);
                BtnNext.Click();
                }
            WebDriver.VerifyBusyOverlayNotDisplayed();

            var page = PageFactory.InitElements<T>(WebDriver);
            //var page = this.WebDriver;
            return page;            
        }

        public PaymentsPage EnterQuickLeaseData(IWebDriver driver, string processMethod)
        {
            ContinueWithFeatureToggleUi();
            //DdlProcessMethod.PickDropdownByText(driver, processMethod);
            DdlProcessMethod.Select().SelectByText(processMethod);
            BtnQuicKLeaseNext.Click();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return new PaymentsPage(WebDriver);
        }

        public PCFPaymentsPage EnterQuickLeaseDetails(string processMethod)
        {
            WebDriverUtil.WaitUntilUrlDisplay(WebDriver, "SMB/Lease/LeaseCreditApp", 45);
            DdlProcessMethod.Select().SelectByText(processMethod);
            BtnQuicKLeaseNext.Click();
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            return new PCFPaymentsPage(WebDriver);
        }

        public PaymentsPage CancelAuthenticateCustomer(string lastName, string pin, bool callBackWithPinInfo = false)
        {
            BtnCancel.Click();
            return new PaymentsPage(WebDriver);
        }


        public PaymentsPage ViewDfsDetailsPage(IWebDriver driver, string dbcTitle)
        {
            if (ViewDfsDetails.IsElementClickable(driver))
                ViewDfsDetails.Click(driver);
            //driver.Manage().Timeouts().PageLoad = new TimeSpan(0, 0, 120);
            WebDriverUtil.WaitUntilUrlDisplay(WebDriver, "SMB/DFSDetails/DFSDetails", 45);
            string s = DfsPageDbcTitle.Text.ToString();
            DfsPageDbcTitle.GetText(driver).Should().BeEquivalentTo(dbcTitle);
            BtnDfsPageNext.Click(driver);
            return new PaymentsPage(WebDriver);
        }   
        
        public PaymentsPage ViewDpaDetails(IWebDriver driver, string customerName)
        {
            if (ViewDfSlinikforDpaCustomer.IsElementClickable(driver))
                ViewDfSlinikforDpaCustomer.Click();
            //driver.Manage().Timeouts().PageLoad = new TimeSpan(0, 0, 120);
            WebDriverUtil.WaitUntilUrlDisplay(WebDriver, "Consumer/DPA/DPA", 45);
            bool isRightCustomer = DpaPageCustomerName.GetText(driver, TimeSpan.FromMinutes(2)).Contains(customerName);          
            BtnDPADetailsNext.Click(driver);
            return new PaymentsPage(WebDriver);           
        }

        public T VerifyDpaCustomerName<T>(IWebDriver driver, string customerName)
        {    
            WebDriverUtil.WaitUntilUrlDisplay(WebDriver, "Consumer/DPA/DPA", 45);
            bool isRightCustomer = DpaPageCustomerName.GetText(driver, TimeSpan.FromMinutes(2)).Contains(customerName);
            BtnDPADetailsNext.Click(driver);
            var page = PageFactory.InitElements<T>(WebDriver);
            //var page = this.WebDriver;
            return page;
        }

        public PaymentsPage ViewDpaDetails_TwoInstances(IWebDriver driver, string customerName, int index = 0)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, -2000)");
            ViewDfSlinikforDpaCustomerWithIndex(index).WaitForElement(driver);
            ViewDfSlinikforDpaCustomerWithIndex(index).Click();
            WebDriverUtil.WaitUntilUrlDisplay(WebDriver, "Consumer/DPA/DPA", 45);
            //driver.Manage().Timeouts().PageLoad = new TimeSpan(0, 0, 120);
            bool isRightCustomer = DpaPageCustomerName.GetText(driver, TimeSpan.FromMinutes(2)).Contains(customerName);
            BtnDPADetailsNext.Click(driver);
            return new PaymentsPage(WebDriver);
        }
        public PCFPaymentsPage EnterDbcDFsInformation(IWebDriver driver, string lastName, string pin, bool callBackWithPinInfo = false)
        {
            WebDriverUtil.WaitUntilUrlDisplay(WebDriver, "SMB/DBC/DBCAuthentication", 45);
            TxtLastName.WaitForElementVisible(_waitTime);
            TxtLastName.Click();
            TxtLastName.SetText(driver, lastName);
            TxtPin.WaitForElementVisible(_waitTime);
            TxtPin.Click();
            TxtPin.SetText(driver, pin);
            BtnNext.WaitForElementVisible(_waitTime);
            BtnNext.Click();
            BtnNext.Click();
            if (WebDriver.Url.Contains("DBCPromotionDisclosures"))
            {
                BtnNext.WaitForElementVisible(_waitTime);
                BtnNext.Click();
            }
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return new PCFPaymentsPage(WebDriver);
        }
    }
}
