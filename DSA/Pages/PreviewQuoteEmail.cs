using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Dsa.Pages
{


    public class PreviewQuoteEmail : DsaPageBase
    {
        public PreviewQuoteEmail(IWebDriver webDriver)
            : base(webDriver)
        {
          PageFactory.InitElements(webDriver, this);
        }
    }
}