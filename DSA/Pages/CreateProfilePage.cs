using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
    public class CreateProfilePage : DsaPageBase
    { 
        public CreateProfilePage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements


public IWebElement BtnSaveProfile { get { return WebDriver.GetElement(By.Id("_saveProfile")); } }


public IWebElement UniqueProfileName { get { return WebDriver.GetElement(By.Id("createProfile_nameExists_alert")); } }


public IWebElement TxtProfileName { get { return WebDriver.GetElement(By.Id("createProfile_profile_name")); } }


public IWebElement TxtProfileDesc { get { return WebDriver.GetElement(By.Id("createProfile_profile_description")); } }

        #endregion


        /// <summary>
        /// Drop down for all recent activity
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="GoToCreateProfilePage"></param>
        /// <returns></returns>
        public EditProfileinManageProfilePage CreateProfile(string profname, string profDesc)
        {

            TxtProfileName.SetText(WebDriver,profname);
            TxtProfileDesc.SetText(WebDriver, profDesc);
            BtnSaveProfile.Click(WebDriver);
            return new EditProfileinManageProfilePage(WebDriver);

        }
    }
}
