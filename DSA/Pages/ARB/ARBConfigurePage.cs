using Dsa.Pages.Quote;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.ARB
{
    public class ARBConfigurePage : DsaPageBase
    {
        public ARBConfigurePage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements


public IWebElement ProductConfigAddItemsToQuoteId { get { return WebDriver.GetElement(By.Id("productConfig_addItemsToQuote")); } }


public IWebElement ProductConfigViewQuote { get { return WebDriver.GetElement(By.Id("productConfig_viewQuote")); } }


public IWebElement RefurbishedMonitorOptions { get { return WebDriver.GetElement(By.XPath("//div[7]/div/div/div[3]/div/div/div/div/div/a/div[2]")); } }


public IWebElement RefurbishedMonitorSelection { get { return WebDriver.GetElement(By.XPath("//input[@id='productConfig_RefurbishedMonitors_selection_0']")); } }


public IWebElement SummaryTab { get { return WebDriver.GetElement(By.XPath("//div[@id='productConfig_header']/div/div[3]/tabset/div/ul/li[2]/a")); } }


public IWebElement ProductConfigSummary { get { return WebDriver.GetElement(By.Id("productConfig_summary")); } }


public IWebElement NonTiedModuleOptions { get { return WebDriver.GetElement(By.XPath("//div[4]/div/div/div[3]/div/div/div/div/div/a/div[2]")); } }


public IWebElement NonTiedModuleSelection { get { return WebDriver.GetElement(By.XPath("//input[@id='productConfig_OfficeSoftware_selection_0']")); } }

        #endregion

        public CreateQuotePage ViewArbQuote()
        {
            ProductConfigViewQuote.Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        }

        public ARBConfigurePage SelectMonitor()
        {
            RefurbishedMonitorOptions.Click(WebDriver);
            RefurbishedMonitorSelection.Click(WebDriver);
            return new ARBConfigurePage(WebDriver);
        }

        public ARBConfigurePage RemoveProductFromCart(string index)
        {
            WebDriver.FindElement(By.Id("productConfig_productListLI_delete_" + index));
            return new ARBConfigurePage(WebDriver);
        }

        public ARBConfigurePage SelectNonTiedModule()
        {
            NonTiedModuleOptions.Click(WebDriver);
            NonTiedModuleSelection.Click(WebDriver);
            return new ARBConfigurePage(WebDriver);
        }
    
    }

}
