using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
    public class CustCatalogPage : DsaPageBase
    {
        public CustCatalogPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements


public IWebElement LargeEntAccounts { get { return WebDriver.GetElement(By.LinkText("LARGE ENTERPRISE ACCOUNTS")); } }


public IWebElement MajorHighEdu { get { return WebDriver.GetElement(By.LinkText("MAJOR HIGHER EDUCATION")); } }


public IWebElement MajorK12Edu { get { return WebDriver.GetElement(By.LinkText("MAJOR K12 EDUCATION")); } }


public IWebElement MajorStateLocalGov { get { return WebDriver.GetElement(By.LinkText("MAJOR STATE AND LOCAL GOVERNMENT")); } }


public IWebElement Healthcare { get { return WebDriver.GetElement(By.LinkText("HEALTHCARE")); } }


public IWebElement PrefHigherEdu { get { return WebDriver.GetElement(By.LinkText("PREFERRED HIGHER EDUCATION")); } }


public IWebElement OfflineUSGlobal500 { get { return WebDriver.GetElement(By.LinkText("OFFLINE US GLOBAL 500")); } }


public IWebElement PrefStateAndLocalGov { get { return WebDriver.GetElement(By.LinkText("PREFERRED STATE AND LOCAL GOVERNMENT")); } }


public IWebElement PrefK12Edu { get { return WebDriver.GetElement(By.LinkText("PREFERRED K12 EDUCATION")); } }


public IWebElement EmergingBusiness { get { return WebDriver.GetElement(By.LinkText("EMERGING BUSINESS")); } }


public IWebElement MediumBusiness { get { return WebDriver.GetElement(By.LinkText("MEDIUM BUSINESS")); } }


public IWebElement OfflineChannelPartners { get { return WebDriver.GetElement(By.LinkText("OFFLINE CHANNEL PARTNERS")); } }

        #endregion
    }
}
