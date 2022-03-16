using System.Linq;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
   public class ManageProfilesPage : DsaPageBase
    {
        public ManageProfilesPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        private readonly By _bySearchTxt = By.Id(@"profileSearch_name");
        private readonly By _bySearchBtn = By.Id(@"profilesSearch_button");
        private readonly By _byProfileTbl = By.Id("security_profilesgrid");

        #region Elements


public IWebElement TxtSearch { get { return WebDriver.GetElement(By.Id("profileSearch_name")); } }


public IWebElement BtnSearch { get { return WebDriver.GetElement(By.Id("profilesSearch_button")); } }


public IWebElement ProfileTbl { get { return WebDriver.GetElement(By.Id("security_profilesgrid")); } }


public IWebElement BtnCreateProfile { get { return WebDriver.GetElement(By.Id("_createProfile")); } }


public IWebElement BtnProfYes { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='Yes']")); } }


public IWebElement BtnProfNo { get { return WebDriver.GetElement(By.Id("//button[normalize-space()='No']")); } }


public IWebElement BtnEditProfile { get { return WebDriver.GetElement(By.CssSelector("#DataTables_Table_0 > tbody > tr > td.no-sort > a")); } }


public IWebElement TblNoResults { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'No items in list.')]")); } }
       
        #endregion


        /// <summary>
        /// Drop down for all recent activity
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="GoToCreateProfilePage"></param>
        /// <returns></returns>
        public CreateProfilePage GoToCreateProfilePage()
        {
           BtnCreateProfile.Click(WebDriver);
            return new CreateProfilePage(WebDriver);

        }


        /// <summary>
        /// Drop down for all recent activity
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="SearchProfile"></param>
        /// <returns></returns>
        public ManageProfilesPage SearchProfile(string profName)
        {
            TxtSearch.Clear();
            TxtSearch.SetText(WebDriver, profName);
            BtnSearch.Click(WebDriver);

            return new ManageProfilesPage(WebDriver);
        }

        /// <summary>
        /// Gets the Profile Name.
        /// </summary>
        /// <value>
        /// The Profile Name    
        /// </value>
        public string ProfileSearch
        {
            get { return _bySearchTxt.GetText(WebDriver); }
            set { _bySearchTxt.SetText(WebDriver, value); }
        }

        /// <summary>
        /// Drop down for all recent activity
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="DeleteProfile"></param>
        /// <returns></returns>

        public ManageProfilesPage DeleteProfile(string profileToDelete)
        {
            ProfileTbl
                .FindElements(By.CssSelector("tbody > tr")).First(v => v.Text.Contains(profileToDelete))   
                .FindElement(By.XPath("//*[text()=' Delete ']")).Click(WebDriver);
            BtnProfYes.Click(WebDriver);
            return new ManageProfilesPage(WebDriver);
        }

        /// <summary>
        /// Executes Profile Name search.
        /// </summary>
        /// <value>
        /// The profile name.
        /// </value>
        public string ProfileTable
        {
            get { return _byProfileTbl.GetText(WebDriver); }
        }

        public EditProfileinManageProfilePage EditProfileAfterSearch(IWebDriver driver)
        {
            BtnEditProfile.Click(driver);
            return new EditProfileinManageProfilePage(WebDriver);
        }

    }




 }
