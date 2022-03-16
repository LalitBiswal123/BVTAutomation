using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Admin
{
    class AdminConsolePage : DsaPageBase
    {
        public AdminConsolePage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements


public IWebElement RdoBtnDev1 { get { return WebDriver.GetElement(By.Id("vEnvironments_0")); } }
       

public IWebElement RdoBtnDev2 { get { return WebDriver.GetElement(By.Id("vEnvironments_1")); } }
        

public IWebElement RdoBtnDit1 { get { return WebDriver.GetElement(By.Id("vEnvironments_2")); } }
        

public IWebElement RdoBtnDit2 { get { return WebDriver.GetElement(By.Id("vEnvironments_3")); } }
        

public IWebElement RdoBtnSit1 { get { return WebDriver.GetElement(By.Id("vEnvironments_4")); } }
        

public IWebElement RdoBtnSit2 { get { return WebDriver.GetElement(By.Id("vEnvironments_5")); } }
        

public IWebElement RdoBtnSit3 { get { return WebDriver.GetElement(By.Id("vEnvironments_6")); } }
        

public IWebElement RdoBtnPerf { get { return WebDriver.GetElement(By.Id("vEnvironments_7")); } }

public IWebElement RdoBtnProd { get { return WebDriver.GetElement(By.Id("vEnvironments_8")); } }
        

public IWebElement TxtSearchUser { get { return WebDriver.GetElement(By.Id("vSearchUser")); } }
        

public IWebElement ImgSearchUser { get { return WebDriver.GetElement(By.Id("vbSearch")); } }
        

public IWebElement TblUserRoles { get { return WebDriver.GetElement(By.Id("vUserRoles")); } }

        #endregion
    }
}
