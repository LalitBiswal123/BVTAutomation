using Dsa.Admin.Pages;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Admin
{
    public class AdministrationPage : DsaPageBase
    {
        public AdministrationPage(IWebDriver webDriver)
            : base(webDriver)
        {
          PageFactory.InitElements(webDriver, this);
        }

        #region Elements 

public IWebElement LnkUsers { get { return WebDriver.GetElement(By.CssSelector("ul.nav > li:nth-child(1) > a:nth-child(1)")); } }


public IWebElement LnkProfiles { get { return WebDriver.GetElement(By.Id("admin_profiles_tab")); } }


public IWebElement LnkCustomerBases { get { return WebDriver.GetElement(By.Id("admin_global_customerBases_tab")); } }


public IWebElement LnkPermissionAssignments { get { return WebDriver.GetElement(By.Id("landing_viewPermissionAssignments")); } }


public IWebElement LnkExportProfileUsers { get { return WebDriver.GetElement(By.Id("admin_exportProfileUsers_tab")); } }


public IWebElement LnkExportAuditLog { get { return WebDriver.GetElement(By.Id("ul.nav > li:nth-child(6) > a:nth-child(1)")); } }
        

public IWebElement TxtProfileName { get { return WebDriver.GetElement(By.Id("createProfile_profile_name")); } }


public IWebElement TxtSearch { get { return WebDriver.GetElement(By.Id("profileSearch_name")); } }


public IWebElement BtnSearch { get { return WebDriver.GetElement(By.Id("profilesSearch_button")); } }


public IWebElement TblProfile { get { return WebDriver.GetElement(By.Id("security_profilesgrid")); } }

       // [FindsBy(How = How.Id, Using = "_createProfile")]
        //public IWebElement BtnCreateProfile;


public IWebElement TblPermission { get { return WebDriver.GetElement(By.Id("permissionsTable")); } }


public IWebElement AuditLogFromDate { get { return WebDriver.GetElement(By.Id("audit_search_fromDate")); } }


public IWebElement TxtSalesRepId { get { return WebDriver.GetElement(By.XPath("//label[normalize-space()='SalesRepId']/..//input")); } }


public IWebElement BtnSave { get { return WebDriver.GetElement(By.Id("_saveProfile")); } }


public IWebElement _byExportProfileLnk { get { return WebDriver.GetElement(By.Id("admin_exportProfileUsers_tab")); } }


public IWebElement _byPermissionAssignmentsLnk { get { return WebDriver.GetElement(By.Id("landing_viewPermissionAssignments")); } }
        #endregion

        
        #region Methods

        /// <summary>
        /// Executes Click on Users Link
        /// </summary>
        public UserDetailsPage Users()
        {
            DsaUtil.Click(LnkUsers, WebDriver);
            return new UserDetailsPage(WebDriver);
        }

        /// <summary>
        /// Executes Click on Profiles Link
        /// </summary>
        public ManageProfilesPage Profiles()
        {
            WebDriver.WaitFor(x => LnkProfiles.Displayed, 15);
            LnkProfiles.Click(WebDriver);
         return new ManageProfilesPage(WebDriver);
        }

        /// <summary>
        /// Executes Click on Export Profiles Link
        /// </summary>
        public ExportProfileUsers ExportProfile(IWebDriver driver)
        {
            driver.WaitFor(x => _byExportProfileLnk.Displayed, 15);
            _byExportProfileLnk.Click(driver);
            return new ExportProfileUsers(driver);
        }

        /// <summary>
        /// Executes Click on Customer Bases Link
        /// </summary>
        public CustomerBasesManagePage CustomerBases()
        {
            LnkCustomerBases.Click(WebDriver);
            return new CustomerBasesManagePage(WebDriver);
        }

       
        public static CustomerBasesManagePage SearchCustomerBase(IWebDriver driver, string newTestCustomerBase)
        {
            var adminSearch = new AdministrationPage(driver);
            adminSearch.CustomerBases();
            var manageCustBase = new CustomerBasesManagePage(driver);
            manageCustBase.SearchCustBase(newTestCustomerBase);
            return new CustomerBasesManagePage(driver);

        }


        

        /// <summary>
        /// Admin --> search profiles in Profiles
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="newTestProfile"></param>
        /// <returns></returns>
        public static ManageProfilesPage SearchProfile(IWebDriver driver, string newTestProfile)
        {
            var adminSearch = new AdministrationPage(driver);
            adminSearch.Profiles();
            var manageProfile = new ManageProfilesPage(driver);
            manageProfile.ProfileSearch = newTestProfile;
            manageProfile.SearchProfile(newTestProfile);
            return new ManageProfilesPage(driver);
        }

        /// <summary>
        /// Export profile Page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="testExportProfile"></param>
        /// <returns></returns>
        public static bool ExportProfileName(IWebDriver driver, string testExportProfile)
        {
            var adminSearch = new AdministrationPage(driver);
            adminSearch.ExportProfile(driver);
            var exportProfile = new ExportProfileUsers(driver);
            exportProfile.TxtDestinationFileName.SetText(driver,testExportProfile);
            exportProfile.BtnExport.Click(driver);

            return exportProfile.downloadNotification.Displayed;
        }

        //TODO : ExportProfilePage does not exist here.
        ///// <summary>
        ///// Executes Click on Export Profiles Link
        ///// </summary>
        //public ExportProfilePage ExportProfile()
        //{
        //    LnkExportProfileUsers.Click(WebDriver);
        //    return new ExportProfilePage(WebDriver);
        //}

        /// <summary>
        /// Executes Click on Export Audit Log Link
        /// </summary>
        public ExportAuditLogPage ExportAuditLog()
        {
           LnkExportAuditLog.Click(WebDriver);
            return new ExportAuditLogPage(WebDriver);
        }
		
		

        #endregion


       
    }
}
