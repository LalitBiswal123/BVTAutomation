using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Customer
{
    public class ViewAllCustomerAccountPage : DsaPageBase
    {
        public ViewAllCustomerAccountPage(IWebDriver webDriver)
            : base(webDriver)
        {
           PageFactory.InitElements(webDriver, this);
        }
        #region Elements

        public IWebElement CusomerAccountDD { get { return WebDriver.GetElement(By.CssSelector("CusomerAccountDDId")); } }

        #endregion

        public override bool IsActive()
        {           
            return (WebDriver.Url.Contains("viewAllCustomers"));
        }
    }

}
