using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.ManagePartnerFavorites
{
    public class BulkUploadStatusPage : DsaPageBase
    {
        public BulkUploadStatusPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements

   
        public IWebElement HeaderBulkUploadStatus { get { return WebDriver.GetElement(By.XPath("//h2[contains(text(),'Bulk Processing Status - Upload Partner Favorites')]")); } }

        public IWebElement HeaderDateCreated { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Date Created')]")); } }

        public IWebElement HeaderDateLastUpdated { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Date Last Updated')]")); } }

        public IWebElement HeaderQueuePosition { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Queue Position')]")); } }

        public IWebElement HeaderDuration { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Duration')]")); } }

        public IWebElement HeaderStatus { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Status')]")); } }

        public IWebElement HeaderAction { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Action')]")); } }

        public IWebElement HeaderDetailsPage { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Details Page')]")); } }

        public IWebElement WorkItemTypeDropdown { get { return WebDriver.GetElement(By.Id("dropDownWorkItemType")); } }

        public IWebElement BulkStatusFilter { get { return WebDriver.GetElement(By.Id("bulkStatusFilterButton")); } }

        public IWebElement AutoRefreshDropdown { get { return WebDriver.GetElement(By.Id("ddlAutoRefresh")); } }

        public IWebElement BtnAddNew { get { return WebDriver.GetElement(By.Id("//button[contains(text(),'Add New')]")); } }

        public IWebElement BacktoCustomer { get { return WebDriver.GetElement(By.XPath("//a[contains(text(),'Back To Customer')]")); } }

        public IWebElement JobsinQueue { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Jobs in Queue')]")); } }

        public IWebElement JobsinProgress { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Jobs In Progress')]")); } }

        public IWebElement JobsPending { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Jobs Pending')]")); } }

        public IWebElement WorkIteminQueue { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Work Items in Queue')]")); } }

        public IWebElement InProgress { get { return WebDriver.GetElement(By.XPath("/html/body/app-root/div/div[2]/div/app-bulk-processing-status/div/div[2]/div/div[2]/div[1]/div[2]/div/div/div[5]/div/span")); } }

        public IWebElement Pending { get { return WebDriver.GetElement(By.XPath("/html/body/app-root/div/div[2]/div/app-bulk-processing-status/div/div[2]/div/div[2]/div[1]/div[2]/div/div/div[6]/div/span")); } }

        public IWebElement SelectedRefreshValue { get { return WebDriver.GetElement(By.XPath("/html/body/app-root/div/div[2]/div/app-bulk-processing-status/div/div[2]/div/div[2]/div[1]/div[2]/div/div/div[7]/div/div")); } }


        #endregion

        #region Methods


        #endregion


    }



}