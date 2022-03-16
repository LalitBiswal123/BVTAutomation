using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Quote
{
    public class QuoteSavePage : DsaPageBase
    {
        public QuoteSavePage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


private IWebElement NotExportRadioBtnElement { get { return WebDriver.GetElement(By.Id("quoteSaveExport_noRadio")); } }


private IWebElement ExportNextElement { get { return WebDriver.GetElement(By.Id("quoteSaveExport_next")); } }


private IWebElement SkipElement { get { return WebDriver.GetElement(By.Id("quoteSaveUpdateRevenue_skip_noitemstoupdate")); } }


private IWebElement CompanyNumber { get { return WebDriver.GetElement(By.XPath("//h5/span[2]")); } }


        #endregion

        public string GetCompanyNumber()
        {
            var companyNumber = CompanyNumber.GetText(WebDriver);
            var companyNumberSubstring = companyNumber.Substring(1, 2);
            return companyNumberSubstring ;
        }

    }
}

