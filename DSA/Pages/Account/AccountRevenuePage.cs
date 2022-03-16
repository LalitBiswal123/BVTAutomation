using System.Collections.Generic;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Dsa.Pages.Account
{   
    public class AccountRevenuePage: DsaPageBase
    {
        public AccountRevenuePage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement ddTerm { get { return WebDriver.GetElement(By.XPath("//div[@class='col-md-2']/select")); } }


public IWebElement TableCustomerRevenue { get { return WebDriver.GetElement(By.Id("DataTables_Table_customerRevenue_Grid")); } }


public IWebElement lnkAccountName { get { return WebDriver.GetElement(By.XPath("//div[@class='customer-revenue']/h2/a")); } }
        #endregion

        #region Methods

        public string GetAccountName()
        {
            return lnkAccountName.GetText(WebDriver);
        }

        public void SetTermDDValue(int index)
        {
            IList<IWebElement> termOptions = new SelectElement(ddTerm).Options;
            SelectElement term = new SelectElement(ddTerm);
            ddTerm.PickDropdownByValue(WebDriver, termOptions[index].GetAttribute("value"));
            WebDriver.VerifyBusyOverlayNotDisplayed();

        }
        #endregion
    }
}
