using System;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Admin
{
    public class CustomerBaseCreatePage : DsaPageBase
    {
        public CustomerBaseCreatePage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement TxtCreateCustomerBaseName { get { return WebDriver.GetElement(By.Id("customerBaseName")); } }


public IWebElement ChkboxCustBaseNameBSDT { get { return WebDriver.GetElement(By.ClassName("check-box-ctnr")); } }


public IWebElement BtnSave { get { return WebDriver.GetElement(By.XPath("//button[contains(text(), 'Save')]")); } }


public IWebElement TblSegments { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/div[2]/div[2]/div[2]")); } }


public IWebElement TblSegmentName1 { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/div[3]/div[2]/div[2]/table/tbody/tr[1]/td[2]/text()")); } }


public IWebElement TblSegmentChkBox1 { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/div[3]/div[2]/div[2]/table/tbody/tr[1]/td[1]/input")); } }


public IWebElement TxtNoResultsFound { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'No items in list.')]")); } }
     
        public IWebElement GetFirstRegionChkBoxFromTable(IWebDriver driver)
        {
            return driver.GetElements(By.XPath("//tree-node-content/input"))[0];
        }
     
        public IWebElement CustomerBaseNameInTable(IWebDriver driver, string customerBaseName)
        {
            var xpath = "//*[contains(@id, 'editGlobalCustomerBase_') and contains(text(), '" +
                        customerBaseName + "')]";
            return driver.GetElement(By.XPath(xpath));
        }

        #endregion

        /// <summary>
        /// Drop down for all recent activity
        /// </summary>
        /// <param name="cusBasename"></param>
        /// <param name="cusBaseSegments"></param>
        /// <returns></returns>
        public CustomerBasesManagePage CreateCustomerBase(string cusBasename, string cusBaseSegments)
        {

            TxtCreateCustomerBaseName.SetText(WebDriver, cusBasename);
            GetFirstRegionChkBoxFromTable(WebDriver).Click();
            BtnSave.Click();
            return new CustomerBasesManagePage(WebDriver);

        }

        public CustomerBasesManagePage CreateCustomerBaseByName(string cusBasename)
        {

            TxtCreateCustomerBaseName.SetText(WebDriver, cusBasename);
            GetFirstRegionChkBoxFromTable(WebDriver).Click(WebDriver);
            BtnSave.Click(WebDriver);
            return new CustomerBasesManagePage(WebDriver);

        }

        public bool NoResultsFound(IWebDriver driver)
        {
            //return driver.TryFindElement(TxtNoResultsFound, TimeSpan.FromSeconds(5));
            return TxtNoResultsFound.Displayed;
        }
    }
}
