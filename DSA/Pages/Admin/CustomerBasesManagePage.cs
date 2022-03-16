using System.Collections.Generic;
using System.Linq;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Admin
{
    public class CustomerBasesManagePage : DsaPageBase
    {
        public CustomerBasesManagePage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        private readonly By _byCustomerBaseTbl = By.Id("security_customerbasesgrid");
        private readonly By _byPermissionTbl = By.Id(@"permissionsTable");
        private IWebElement PermissionTbl
        {
            get { return WebDriver.GetElement(_byPermissionTbl); }
        }

        #region Elements


public IWebElement TxtCustomerBaseSearch { get { return WebDriver.GetElement(By.Id("customerbaseSearch_name")); } }


public IWebElement BtnSearch { get { return WebDriver.GetElement(By.Id("customerbaseSearch_button")); } }


public IWebElement BtnSave { get { return WebDriver.GetElement(By.XPath("//button[contains(text(), 'Save')]")); } }


public IWebElement CreateCustomerBase { get { return WebDriver.GetElement(By.Id("_createCustomerbase")); } }


public IWebElement TblCustomerBaseName { get { return WebDriver.GetElement(By.Id("security_customerbasesgrid")); } }


public IWebElement BtnDelYes { get { return WebDriver.GetElement(By.Id("messageDialogButton_0")); } }


public IWebElement BtnDelNo { get { return WebDriver.GetElement(By.Id("messageDialogButton_1")); } }


public IWebElement Alert { get { return WebDriver.GetElement(By.XPath("//*[@id='controller_alert']")); } }


public IWebElement ContentTree { get { return WebDriver.GetElement(By.XPath("//*[@class='tree-node-level-1 tree-node tree-node-expanded']")); } }


public IWebElement LnkEditCustBase { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'editGlobalCustomerBase')]")); } }


public IWebElement dropDown40 { get { return WebDriver.GetElement(By.XPath("//*[@id='grid_paging_itemsPerPage']/option[3]")); } }

        #endregion


        /// <summary>
        /// Drop down for all recent activity
        /// </summary>
        /// <returns></returns>
        public CustomerBaseCreatePage GoToCreateCusBasePage()
        {
            CreateCustomerBase.Click(WebDriver);
            return new CustomerBaseCreatePage(WebDriver);

        }

        
        /// <summary>
        /// Drop down for all recent activity
        /// </summary>
        /// <returns></returns>
        public void SearchCustBase(string cusBaseName)
        {
            TxtCustomerBaseSearch.SetText(WebDriver, cusBaseName);
            BtnSearch.Click(WebDriver);

        }

        public IWebElement GetNthRegionChkBoxFromTable(IWebDriver driver, int n)
        {
            return driver.GetElements(By.XPath("//tree-node-content/input"))[n];
        }

        
        public IWebElement CheckedItems(IWebDriver driver, int n)
        {
            return driver.GetElements(By.XPath("//tree-node-content/input"))[n];
               
        }

       

        public IWebElement LnkExpandRegion(int regionIndex)
        {
            return WebDriver.GetElements(By.XPath("//span[contains(@class,'toggle-children-wrapper toggle-children-wrapper-collapsed')]"))[regionIndex];
        }

        public void DeleteCustomerBase(string custBaseToDelete)
        {
            WebDriver.WaitFor(x => TblCustomerBaseName.Displayed, 60);
            TblCustomerBaseName.FindElements(By.CssSelector("tbody > tr"))
                .Where(v => v.Text.Contains(custBaseToDelete)).First()
                .FindElement(By.XPath("//*[text()=' Delete ']")).Click(WebDriver, System.TimeSpan.FromSeconds(30));

            WebDriver.WaitFor(x => BtnDelYes.Displayed, 30);
            BtnDelYes.Click(WebDriver, System.TimeSpan.FromSeconds(30));
        }

        /// <summary>
        /// Executes Profile Name search.
        /// </summary>
        /// <value>
        /// The profile name.
        /// </value>
        public string CustomerBaseTable
        {
            get { return _byCustomerBaseTbl.GetText(WebDriver); }
        }


    }
}
