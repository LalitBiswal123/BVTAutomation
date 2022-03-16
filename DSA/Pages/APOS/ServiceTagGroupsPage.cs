using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Dsa.Pages.Quote;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;

namespace Dsa.Pages.APOS
{
    public class ServiceTagGroupsPage : DsaPageBase
    {
        public ServiceTagGroupsPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements

        public IWebElement AddtoQuoteBtn { get { return WebDriver.GetElement(By.Id("btnConfigureGroups")); } }

        public IWebElement Group1 { get { return WebDriver.GetElement(By.XPath("//a[@class='k-icon k-i-arrow-s']")); } }

        public IWebElement SplitGroup { get { return WebDriver.GetElement(By.XPath("//*[@class='btn icon-split']")); } }

        public IWebElement SplitGroupConfirmYes { get { return WebDriver.GetElement(By.XPath("//*[@id='messageDialogButton_0' and contains(text(), 'Yes')]")); } }

        public IWebElement SelectTagfrmGroup1 { get { return WebDriver.GetElement(By.CssSelector("div[ref='eFullWidthContainer']>[row-index='0'] div>div>input")); } }

        public IWebElement Dragelement { get { return WebDriver.GetElement(By.XPath("//*[@class = 'handle ag-results-grid-cell drag-handle']")); } }

        public IWebElement CreateSubGrp { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Create Subgroup')]")); } }

        public IWebElement PopupUnsavedChanges { get { return WebDriver.GetElement(By.Id("MessageBoxTitle")); } }

        public IWebElement UnsavedChangesMsg { get { return WebDriver.GetElement(By.XPath("//*[@class = 'input-label']")); } }

        public IWebElement AddServiceTags { get { return WebDriver.GetElement(By.XPath("//button[@class='btn btn-default']")); } }

        public IWebElement ErrorAgreementIdMismatch { get { return WebDriver.GetElement(By.XPath("//*[@class='alert alert-error' and contains(text(), 'Service tags do not have same Agreement ID.')]")); } }

        public IWebElement AddServiceTagsBtn { get { return WebDriver.GetElement(By.Id("btnAddServiceTags")); } }

        public IWebElement CancelBtn { get { return WebDriver.GetElement(By.XPath("//button[contains(text(), 'Cancel')]")); } }

        public IWebElement ExportToExcelBtn { get { return WebDriver.GetElement(By.XPath("//button[contains(text(), 'Export to Excel')]")); } }

        public IWebElement SplitPopupYes { get { return WebDriver.GetElement(By.Id("_btn_ok")); }}

        public IWebElement SplitPopupNo { get { return WebDriver.GetElement(By.Id("_btn_cancel")); } }

        public IWebElement AddressesTable { get { return WebDriver.GetElement(By.XPath("//div[@class='ag-selectable']")); } }

        #endregion

        #region Clear Price

        public IWebElement InvalidServiceTagsGridColumns(string columnName)
        {
            return WebDriver.FindElement(By.XPath("//app-apos-grid-header-renderer//span[contains(text(), '" + columnName + "')]"));

        }

        #endregion

        public IWebElement AssetGridColumns(string columnName)
        {
            return WebDriver.FindElement(By.XPath("//app-apos-grid-header-renderer//span[contains(text(), '" + columnName + "')]"));

        }

        public IWebElement VerifyUnsavedChangesButtonClick(int index)
        {

            return WebDriver.GetElement(By.XPath("//*[@id='messageDialogButton_'])[" + index + "]"));
        }

        /// <summary>
        /// Clicks on Update Quote button.
        /// </summary>
        /// <returns></returns>
        public CreateQuotePage AposAddToQuote()
        {
            AddtoQuoteBtn.Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        }


        public int SplitServiceTagGroup()
        {
            SplitGroup.Click(WebDriver);
            SplitPopupYes.Click(WebDriver);
            int getGroupCount = WebDriver.FindElements(By.XPath("//span[@class='apos-group-name-heading']")).Count;
            DsaUtil.WaitForPageLoad(WebDriver);
            return getGroupCount;
        }

        public ServiceTagGroupsPage CreateSiblingGroup(IWebDriver WebDriver)
        {
            Group1.Click(WebDriver);
            SelectTagfrmGroup1.Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            dragdropTag();
            return this;
        }

        public void dragdropTag()
        {
            Actions ac = new Actions(WebDriver);
            //ac.DragAndDrop(Dragelement, (WebDriver.TryFindElement(CreateSubGrp, TimeSpan(30)));

            //ac.Build().Perform();
            //ac.ClickAndHold(Dragelement);
            //ac.MoveToElement(CreateSubGrp);
            //ac.Build().Perform();

            ac.ClickAndHold(Dragelement);
            ac.DragAndDropToOffset(Dragelement, 15, 30);
            ac.Build().Perform();

        }

        public ServiceTagSearchResultPage AddMoreServiceTags(IWebDriver WebDriver, string serviceTag)
        {
            var serviceTagGroup = new ServiceTagSearchResultPage(WebDriver);
            AddServiceTags.Click(WebDriver);
            var serviceTagearch = new ServiceTagSearchPage(WebDriver);
            serviceTagearch.ServiceTagTxt.SetText(WebDriver, serviceTag);
            return serviceTagearch.AposSearch();

        }

        public bool CheckforUnsavedChanges()

        {
            var UnsavedChangesText = "Are you sure you want to leave this page and lose unsaved changes?";
            if (PopupUnsavedChanges.IsElementDisplayed(WebDriver))
            {
                if (UnsavedChangesMsg.GetText(WebDriver).ToString() == UnsavedChangesText)
                    return true;
            }

            return false;

        }

        public List<Dictionary<string, object>> GetServiceTagDataTable()
        {
            AddressesTable.WaitForElement(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return AddressesTable.GetGridTableData(WebDriver);
        }

    }
}
