using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
    public class AnalyticsPage : DsaPageBase
    {
         public AnalyticsPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);            
            
        }

        #region Elements
      

private IWebElement TblAnalyticsResult { get { return WebDriver.GetElement(By.XPath("//*[@id='analytics_Grid']/div/table")); } }
    

private IWebElement AnalyticsTypeElement { get { return WebDriver.GetElement(By.Id("recentAnalytic_analyticType")); } }


private IWebElement AnalyticsDateRangeElement { get { return WebDriver.GetElement(By.Id("recentanalytic_dateRange")); } }
        

        #endregion
    }
}
