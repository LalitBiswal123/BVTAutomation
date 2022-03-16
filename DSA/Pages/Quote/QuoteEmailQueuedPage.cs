using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Quote
{
    public class QuoteEmailQueuedPage : DsaPageBase
    {

        public QuoteEmailQueuedPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement GridId { get { return WebDriver.GetElement(By.Id("cfoResultGrid")); } }


public IWebElement QuoteEmailQueued { get { return WebDriver.GetElement(By.Id("quoteSendCfo_emailQueued")); } }


public IWebElement TblQuoteEmailQueuedStatus { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_3')]/tbody")); } }


public IWebElement CustomerOutputReport { get { return WebDriver.GetElement(By.Id("_CustomerOutputReport")); } }


public IWebElement LnkReturnToQuote { get { return WebDriver.GetElement(By.Id("_returnQuote")); } }

        #endregion

        public string GetReturnToQuoteNumber()
        {
            return LnkReturnToQuote.Text;
        }

        public void ClickReturnToQuote()
        {
            LnkReturnToQuote.Click();
        }
    }
}
