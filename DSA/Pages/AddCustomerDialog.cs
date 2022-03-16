using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
   public class AddCustomerDialog : DsaPageBase
    {
        public AddCustomerDialog(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements


public IWebElement TxtCustomerNumbers { get { return WebDriver.GetElement(By.Id("customer_numbers")); } }


public IWebElement BtnAdd { get { return WebDriver.GetElement(By.Id("add_customer")); } }


public IWebElement BtnCancel { get { return WebDriver.GetElement(By.Id("add_customer_cancel")); } }


public IWebElement BtnReplaceCurrentList { get { return WebDriver.GetElement(By.Id("replace_customer")); } }


public IWebElement BtnAddCustomerOk { get { return WebDriver.GetElement(By.Id("add_customer_ok")); } }

        #endregion

    }
}
