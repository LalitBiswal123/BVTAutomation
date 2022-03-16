using Dsa.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace Dsa.Pages.Customer
{
   public class CustomerSearchResultsPage : DsaPageBase
    {
        public CustomerSearchResultsPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements

        public IWebElement GridCustomerSearchResult { get { return WebDriver.GetElement(By.Id("customerSearchResult_grid")); } }

        public IWebElement FindCustomerResultEditLink { get { return WebDriver.GetElement(By.Id("customer_searchEdit_link")); } }

        public IWebElement FindCustomerResultEditLinkForUCID { get { return WebDriver.GetElement(By.XPath("//a[contains(text(),'Edit search')]")); } }

        public IWebElement UCIDlabelInUCIDResultsPage { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'UCID:')]")); } }

        public IWebElement StatuslabelInUCIDResultsPage { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'Status:')]")); } }

        public IWebElement CompanyNamelabelInUCIDResultsPage { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'Company Name:')]")); } }

        public IWebElement CompanyAddresslabelInUCIDResultsPage { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'Company Address:')]")); } }

        public IWebElement MessageInUCIDResultsPage { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), ' Dell Customer IDs mapped to this UCID')]")); } }

        public IWebElement AdvanceSearcheditLnk { get { return WebDriver.GetElement(By.Id("customer_searchEdit_link")); } }

        public IWebElement AdvanceSearchCusPartyFilter { get { return WebDriver.GetElement(By.XPath("//select[@id='customerParty_Filter']")); } }

        public IWebElement AdvanceSearchEmptyFilter { get { return WebDriver.GetElement(By.XPath("//div[@class='col-md-2']")); } }

        public IWebElement AdvanceSearchFilterButton { get { return WebDriver.GetElement(By.XPath("//button[@id='customerParty_filterAction']")); } }

        public IWebElement SmartSearchEditLnk { get { return WebDriver.GetElement(By.XPath("//button[@id='customer_searchEdit_link']")); } }

        public IWebElement SmartSearchEmptyFilter { get { return WebDriver.GetElement(By.XPath("//div[@class='col-md-2']")); } }
               
        public IWebElement SmartSearchCusPartyFilter { get { return WebDriver.GetElement(By.XPath("//select[@id='customerParty_Filter']")); } }




        #endregion

        /// <summary>
        /// Validates this instance by checking that the page title is displayed and that it matches 
        /// the title as stored in the associated resource file.
        /// </summary>
        /// <returns><c>true</c> if the page title is displayed and is the correct value, 
        /// <c>false</c> otherwise.</returns>
        public override bool Validate()
        {
            return GridCustomerSearchResult.Displayed;
        }

        /// <summary>
        /// Determines whether this instance is active.
        /// </summary>
        /// <returns><c>true</c> if this instance is active; otherwise, <c>false</c>.</returns>
        public override bool IsActive()
        {
            return (WebDriver.Url.Contains(Url));
        }


        public CustomerDetailsPage GetAllOptionsFromDropDown(IWebElement element, int count)
        {
            SelectElement select = new SelectElement(element);
            IList<IWebElement> list = select.Options;
            var total = list.Count;
            if (total.Equals(count))
            {
                foreach (var item in list)
                {
                    Logger.Write(item.GetText(WebDriver));
                }

            }
            else
            {

                Assert.Fail("Count doesn't match.");
            }
            return new CustomerDetailsPage(WebDriver);
        }

    }
}
