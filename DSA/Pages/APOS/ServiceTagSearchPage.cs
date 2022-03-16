using Dsa.Enums;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.APOS
{
    public class ServiceTagSearchPage : DsaPageBase
    {

        public ServiceTagSearchPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements
 
        public IWebElement CustomerNumberTxt { get { return WebDriver.GetElement(By.Id("apos_search_CustomerNumber")); } }

        public IWebElement OrderNumberTxt { get { return WebDriver.GetElement(By.Id("apos_search_OrderNumber")); } }

        public IWebElement ServiceTagTxt { get { return WebDriver.GetElement(By.Id("apos_search_ServiceTags")); } }

        public IWebElement SwAgreementIdTxt { get { return WebDriver.GetElement(By.Id("apos_search_Swags")); } }

        public IWebElement MsgShowNoResults { get { return WebDriver.GetElement(By.ClassName("alert-info")); } }

        public IWebElement BtnServiceTagSearch { get { return WebDriver.GetElement(By.Id("apos_search_searchButton")); } }

        public IWebElement BtnClearServiceTagSearch { get { return WebDriver.GetElement(By.Id("apos_search_clearAction")); } }

        public IWebElement DuplicateTagsNotification { get { return WebDriver.GetElement(By.XPath("//*[@class='alert alert-info' and contains(text(), 'Duplicate service tags will be removed')]")); } }

        public IWebElement DuplicateTagsRemovedNotification { get { return WebDriver.GetElement(By.XPath("//*[@class='alert alert-warning' and contains(text(), 'Duplicate service tags were removed')]")); } }

        public IWebElement NotificationMsg { get { return WebDriver.GetElement(By.XPath("//apos-search//div[contains(@class, 'alert alert-info')]")); } }


        public IWebElement BackDateCheckBox { get => WebDriver.GetElement(By.Id("chkBackDate")); }

        #endregion

        public ServiceTagSearchResultPage AposSearch()
        {
            BtnServiceTagSearch.Click(WebDriver);
            return new ServiceTagSearchResultPage(WebDriver);
        }

        public ServiceTagSearchPage AposClearSearch()
        {
            BtnClearServiceTagSearch.Click(WebDriver);
            return new ServiceTagSearchPage(WebDriver);
        }

        public ServiceTagSearchPage SelectCatalog(Catalogs catalog)
        {
            var selectCatalog = new SelectCatalogDialog(WebDriver);
            selectCatalog.SelectCatalog(catalog);
            return new ServiceTagSearchPage(WebDriver);
        }
    }
}
