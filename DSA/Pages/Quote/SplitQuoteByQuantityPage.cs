using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Quote
{
    public class SplitQuoteByQuantityPage : DsaPageBase
    {
        public SplitQuoteByQuantityPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement Title { get { return WebDriver.GetElement(By.Id("_title")); } }


public IWebElement BtnReviewQuotes { get { return WebDriver.GetElement(By.Id("_reviewQuotes")); } }


public IWebElement Cancel { get { return WebDriver.GetElement(By.Id("_cancel")); } }


public IWebElement QuoteInfo { get { return WebDriver.GetElement(By.Id("splitByQuantity_quote_info")); } }


public IWebElement OriginalQuoteSection { get { return WebDriver.GetElement(By.Id("_originalQuoteSection")); } }


public IWebElement DeltaSection { get { return WebDriver.GetElement(By.Id("_deltaSection")); } }


public IWebElement BtnAddQuotes { get { return WebDriver.GetElement(By.Id("_addQuotes")); } }


public IWebElement OriginalTable { get { return WebDriver.GetElement(By.CssSelector("#splitByQuantity_main > table > tbody")); } }


public IWebElement AddedQuoteTable { get { return WebDriver.GetElement(By.CssSelector("#splitByQuantity_main > div:nth-child(3) > table > tbody")); } }


public IWebElement Quantity { get { return WebDriver.GetElement(By.Id("_LI_quantity_{0}")); } }


public IWebElement TxtNumberOfNewQuotes { get { return WebDriver.GetElement(By.XPath("//*[@id='COM']/div[4]/div/div[3]/input")); } }


public IWebElement BtnAddNewQuote { get { return WebDriver.GetElement(By.CssSelector("button.btn-default:nth-child(1)")); } }

        #endregion

        public SplitPaloozaPage ReviewQuotesSplitByQuantity(int numOfQuoteToAdd = 1)
        {
            BtnAddQuotes.Click(WebDriver);
            TxtNumberOfNewQuotes.SetText(WebDriver, numOfQuoteToAdd.ToString());
            BtnAddNewQuote.Click(WebDriver);
            BtnReviewQuotes.Click(WebDriver);
            return new SplitPaloozaPage(WebDriver);
        }
    }
}
