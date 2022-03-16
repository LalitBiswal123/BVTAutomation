using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.ManagePartnerFavorites
{
    public class BulkUploadPage : DsaPageBase
    {
        public BulkUploadPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements

   
        public IWebElement WorkItemTypeDropdown { get { return WebDriver.GetElement(By.Id("dropDownWorkItemType")); } }

        public IWebElement BulkUploadPageHeader { get { return WebDriver.GetElement(By.XPath("//h2[contains(text(),'Bulk Item Processing')]")); } }

        public IWebElement DownloadTemplate { get { return WebDriver.GetElement(By.Id("//a[contains(text(),'Download Upload Partner Favorites')]")); } }

        public IWebElement SelectFile { get { return WebDriver.GetElement(By.Id("workItemFile")); } }

        public IWebElement BtnUpload { get { return WebDriver.GetElement(By.Id("bulk_upload")); } }

        public IWebElement BtnViewStatus { get { return WebDriver.GetElement(By.XPath("//button[contains(text(),'View Status')]")); } }

        public IWebElement BacktoCustomer { get { return WebDriver.GetElement(By.Id("backToCaller")); } }


        #endregion

        #region Methods


        #endregion


    }



}