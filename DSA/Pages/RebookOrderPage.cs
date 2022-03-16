using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
    public class RebookOrderPage : DsaPageBase
    {
        public RebookOrderPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements


public IWebElement TxtShippingMethod { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_SI_shippingMethod_1")); } }


public IWebElement TxtShippingPrice { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_SI_shippingPrice_1")); } }


public IWebElement TxtShippingDiscount { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_SI_shippingDiscount_1")); } }


public IWebElement DolValue { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_PI_dolPercentage_1")); } }

        #endregion
    }
}
