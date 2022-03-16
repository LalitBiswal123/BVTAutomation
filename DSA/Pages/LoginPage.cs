//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
    public class LoginPage : DsaPageBase
    {
        public LoginPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region  Elements

public IWebElement processingMessage { get { return WebDriver.GetElement(By.XPath("//*[text()='Your login request is processing.']")); } }


public IWebElement errorMessage { get { return WebDriver.GetElement(By.XPath("//*[text()='Username and/or Password are incorrect. Please try again.']")); } }


public IWebElement usernameField { get { return WebDriver.GetElement(By.Id("Username")); } }


public IWebElement userAuthField { get { return WebDriver.GetElement(By.Id("Password")); } }


public IWebElement loginButton { get { return WebDriver.GetElement(By.Id("login")); } }
     

        #endregion

        public LoginPage EnterUserName(string name)
        {
            usernameField.Set(name);
            return new LoginPage(WebDriver);
        }

        public LoginPage EnterPassword(string pword)
        {
            userAuthField.Set(pword);
            return new LoginPage(WebDriver);
        }

        public LoginPage Login(string name, string pword)
        {
            EnterUserName(name);
            EnterPassword(pword);
            loginButton.Click(WebDriver);
            return new LoginPage(WebDriver);
        }
    }
}
