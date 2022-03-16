using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Solutions
{
    public class PartnerPortalLoginPage : DsaPageBase
    {
        public PartnerPortalLoginPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(WebDriver, this);

        }

        #region Elements


public IWebElement TxtEmailAddress { get { return WebDriver.GetElement(By.Id("EmailAddress")); } }


public IWebElement TxtUserAuth { get { return WebDriver.GetElement(By.Id("Password")); } }


public IWebElement BtnSignIn { get { return WebDriver.GetElement(By.Id("sign-in-button")); } }


public IWebElement isrSignInHereLink { get { return WebDriver.GetElement(By.Id("lemcEmployeeLoginLink")); } }


        // To detect redundant calls
  
        #endregion


        public void SignInWithPartnerLoginCredentials(IWebDriver driver, string email, string password)
        {

            TxtEmailAddress.SetText(driver, email);
            TxtUserAuth.SetText(driver, password);

            BtnSignIn.Click(driver);

        }


        public void SignInWithISR(IWebDriver driver)
        {

            isrSignInHereLink.Click(driver);

        }
    }
}
