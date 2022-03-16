using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
   public class EditProfileinManageProfilePage : DsaPageBase
    {
        public EditProfileinManageProfilePage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements


public IWebElement LblProfileName { get { return WebDriver.GetElement(By.Id("createProfile_profile_name")); } }


public IWebElement ChkBoxReporting { get { return WebDriver.GetElement(By.CssSelector("#chkViewViewReports")); } }


public IWebElement TxtProfileDescription { get { return WebDriver.GetElement(By.Id("createProfile_profile_description")); } }


public IWebElement TblProfileDescription { get { return WebDriver.GetElement(By.Id("editProfile_profile_description")); } }


public IWebElement BtnSave { get { return WebDriver.GetElement(By.Id("editProfile_saveProfile")); } }


public IWebElement ChkBoxQuoteSolution { get { return WebDriver.GetElement(By.Id("chkQuoteSolutions")); } }


public IWebElement ChkBoxFinanceApprovalforTransactionalDAM { get { return WebDriver.GetElement(By.Id("profileDetails_profileDAMFinanceApproval")); } }


public IWebElement ChkBoxManagerApprovalforTransactionalDAM { get { return WebDriver.GetElement(By.Id("profileDetails_profileDAMManagerApproval")); } }


public IWebElement BtnCancel { get { return WebDriver.GetElement(By.Id("editProfile_cancelProfile")); } }


public IWebElement availableRights { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/form/div[2]/div[2]/div")); } }


public IWebElement ChkBoxFirstRight { get { return WebDriver.GetElement(By.XPath("//div[@data-ui-view='edit-profile-rights']/descendant::input[@type='checkbox'][1]")); } }

        #endregion
    }
}
