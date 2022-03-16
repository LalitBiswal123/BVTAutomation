using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
    public class SalesRepTaggingPage : DsaPageBase
    {
        public SalesRepTaggingPage(IWebDriver webDriver)
            : base(webDriver)
        {
          PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement LblSalesUserName { get { return WebDriver.GetElement(By.XPath("//*[@id='salesRepTaggingContentArea']/div[1]/div[1]/div[1]/label")); } }


public IWebElement LblSalesRepId { get { return WebDriver.GetElement(By.XPath("//*[@id='salesRepTaggingContentArea']/div[1]/div[2]/div[1]/label")); } }
        

public IWebElement LblNoSalesRepMessage { get { return WebDriver.GetElement(By.Id("salesRepIdNoValid")); } }
        //salesRepId

public IWebElement SalesRepIdValue { get { return WebDriver.GetElement(By.Id("salesRepId")); } }


public IWebElement TxtCustomerEmailAddress { get { return WebDriver.GetElement(By.XPath("//input[contains(@class,'form-control')]")); } }


public IWebElement LblSalesRepTaggingAccessDenied { get { return WebDriver.GetElement(By.Id("salesRepTaggingAccessDenied")); } }
        //customerEmailAddress
        //submitButton
        //addEmailButton


public IWebElement BtnAddEmail { get { return WebDriver.GetElement(By.Id("addEmailButton")); } }


public IWebElement btnSubmit { get { return WebDriver.GetElement(By.Id("submitButton")); } }
        #endregion

    }
}
