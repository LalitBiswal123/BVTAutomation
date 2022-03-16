using Dsa.Enums;
using Dsa.Pages.APOS;
using Dsa.Pages.Quote;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Workflows
{
    /// <summary>
    /// Dell outlet products related workflows are to be written in this class.
    /// </summary>
    public class AposWorkflow
    {

        #region APOS WorkFlow

        #region Search Service Tags

        /// <summary>
        /// Search for Service Tags.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="serviceTag">serviceTag.</param>
        /// <param name="catalog">catalog.</param>
        /// <returns></returns>
        public ServiceTagSearchResultPage SearchForServiceTags(IWebDriver driver, string serviceTag, Catalogs catalog = Catalogs.SmallBusiness)
        {
            new ServiceTagSearchPage(driver).SelectCatalog(catalog);
            var serviceTagSearch = new ServiceTagSearchPage(driver);
            serviceTagSearch.ServiceTagTxt.SetText(driver, serviceTag);
            return serviceTagSearch.AposSearch();
        }

        public ServiceTagSearchResultPage SearchServiceTags(IWebDriver driver, string serviceTag, Catalogs catalog = Catalogs.SmallBusiness)
        {
            new ServiceTagSearchPage(driver).SelectCatalog(catalog);
            var serviceTagSearch = new ServiceTagSearchPage(driver);
            serviceTagSearch.ServiceTagTxt.SetText(driver, serviceTag);
            return new ServiceTagSearchResultPage(driver);
        }

            public ServiceTagSearchResultPage SearchForServiceTagsusingcustomerno(IWebDriver driver, string APOSCustomerNo, Catalogs catalog = Catalogs.SmallBusiness)
        {
            new ServiceTagSearchPage(driver).SelectCatalog(catalog);
            var serviceTagSearchusingcustomerno = new ServiceTagSearchPage(driver);
            serviceTagSearchusingcustomerno.CustomerNumberTxt.SetText(driver, APOSCustomerNo);
            return serviceTagSearchusingcustomerno.AposSearch();
        }

        public ServiceTagSearchResultPage SearchForServiceTagsusingOrderNumber(IWebDriver driver, string OrderNumber, Catalogs catalog = Catalogs.SmallBusiness)
        {
            new ServiceTagSearchPage(driver).SelectCatalog(catalog);
            var serviceTagSearchusingOrderNumber = new ServiceTagSearchPage(driver);
            serviceTagSearchusingOrderNumber.OrderNumberTxt.SetText(driver, OrderNumber);
            return serviceTagSearchusingOrderNumber.AposSearch();
        }

        public ServiceTagSearchResultPage SearchForSwAgreementIDs(IWebDriver driver, string swAgreement, Catalogs catalog = Catalogs.SmallBusiness)
        {
            new ServiceTagSearchPage(driver).SelectCatalog(catalog);
            var swAgreementSearch = new ServiceTagSearchPage(driver);
            swAgreementSearch.SwAgreementIdTxt.SetText(driver, swAgreement);
            return swAgreementSearch.AposSearch();
        }

        public ServiceTagSearchResultPage SearchForServiceTagAndSwAgreementIDs(IWebDriver driver, string serviceTag, string swAgreement, Catalogs catalog = Catalogs.SmallBusiness)
        {
            new ServiceTagSearchPage(driver).SelectCatalog(catalog);
            var serviceTagAndSwAgreementSearch = new ServiceTagSearchPage(driver);
            serviceTagAndSwAgreementSearch.ServiceTagTxt.SetText(driver, serviceTag);
            serviceTagAndSwAgreementSearch.SwAgreementIdTxt.SetText(driver, swAgreement);
            return serviceTagAndSwAgreementSearch.AposSearch();
        }

        public ServiceTagSearchResultPage ValidateServiceTagInformation(IWebDriver driver)
        {
            Actions ToolTip = new Actions(driver);
            ToolTip.ClickAndHold(new ServiceTagSearchResultPage(driver).Alertinfo).Perform();
            string toolTipText = new ServiceTagSearchResultPage(driver).Alertinfo.GetAttribute("title");

            return new ServiceTagSearchResultPage(driver);
        }

        //public string GetToolTipText(IWebDriver driver)
        //{
        //    string toolTipText = string.Empty;
        //    Actions action = new Actions(driver);
        //    action.ClickAndHold(new ServiceTagSearchResultPage(driver).Alertinfo).Perform();
        //    toolTipText = new ServiceTagSearchResultPage(driver).Alertinfo.GetAttribute("title");
        //return toolTipText;

        //}


        #endregion

        #region SelectAllServiceTags

        public ServiceTagGroupsPage SelectAllServiceTags(IWebDriver driver)
        {
            var serviceTagGroup = new ServiceTagSearchResultPage(driver);
            serviceTagGroup.SelectAllChkbox.Click(driver);
            serviceTagGroup.GroupBtn.Click(driver);
            return new ServiceTagGroupsPage(driver);
        }

        public ServiceTagGroupsPage SelectAllFBServiceTags(IWebDriver driver)
        {
            var serviceTagGroup = new ServiceTagSearchResultPage(driver);
            serviceTagGroup.SelectAll.Click(driver);
            serviceTagGroup.GroupBtn.Click(driver);
            return new ServiceTagGroupsPage(driver);
        }

       
        #region GroupServiceTags

        /// <summary>
        /// Group Service Tags.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="modNumbers">serviceTag.</param>
        /// <returns></returns>
        public ServiceTagGroupsPage GroupServiceTags(IWebDriver driver, string serviceTag)
        {
            var serviceTagGroup = new ServiceTagSearchResultPage(driver);
            serviceTagGroup.ServiceTagSelect(serviceTag);
            return (ServiceTagGroupsPage)serviceTagGroup.CreateAposGroup();
        }

        #endregion

        #region Add Service Tags to Quote

        /// <summary>
        /// Add Service Tags to Quote
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public  CreateQuotePage AddServiceTagsToQuote(IWebDriver driver)
        {
            var addToQuoteTag = new ServiceTagGroupsPage(driver);
            return (CreateQuotePage)addToQuoteTag.AposAddToQuote();
        }

        #endregion
        
        #region Configure Service Tags

        /// <summary>
        /// Configure Service Tags
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public AposConfigurePage ConfigureServiceTags(IWebDriver driver)
        {
            var configureTag = new CreateQuotePage(driver);
            return (AposConfigurePage)configureTag.AposServiceTagConfigure();
        }

        #endregion

        #region Set Duration and Update duration

        /// <summary>
        /// Set Dates , Set Duration
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public  AposConfigurePage SetDuration(IWebDriver driver)
        {
            var aposconfigureTag = new AposConfigurePage(driver);
            aposconfigureTag.SetdatesTab.Click(driver);
            aposconfigureTag.SelectGroup.Click(driver);
            aposconfigureTag.SetDuration.Click(driver);
            aposconfigureTag.UpdateDuration.Click(driver);
            return (AposConfigurePage)aposconfigureTag.UpdateSummary();
        }

        #endregion

        #region Set Duration only

        /// <summary>
        /// Set Dates , Set Duration
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public void SetDurationOnly(IWebDriver driver)
        {
            var aposconfigureTag = new AposConfigurePage(driver);
            aposconfigureTag.SetdatesTab.Click(driver);
            aposconfigureTag.SelectGroup.Click(driver);
            aposconfigureTag.SetDuration.Click(driver); 
        }

        #endregion

        #region Remove Recret Fee

        /// <summary>
        /// Remove Recert Fee
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public  AposConfigurePage RemoveRecertFee(IWebDriver driver)
        {
            var aposRemoveRecertFee = new AposConfigurePage(driver);
            if (aposRemoveRecertFee.RemoveRecertFeeBtn.Displayed)
            {
                aposRemoveRecertFee.RemoveRecertFee();
            }
            return (AposConfigurePage)aposRemoveRecertFee.UpdateSummary();
        }

        #endregion

        #region Service Update

        /// <summary>
        /// Select a service
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public  AposConfigurePage ServiceUpdate(IWebDriver driver)
        {
            var aposserviceconfigure = new AposConfigurePage(driver);
            aposserviceconfigure.SummaryTab.Click(driver);
            aposserviceconfigure.SelectTechSupportModule();
            return (AposConfigurePage)aposserviceconfigure.UpdateSummary();
        }

        #endregion

        #region View Quote

        /// <summary>
        /// View Quote
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public CreateQuotePage ViewQuote(IWebDriver driver)
        {
            var aposserviceconfigure = new AposConfigurePage(driver);
            return (CreateQuotePage)aposserviceconfigure.ViewQuote();
        }

        #endregion

        #region Set Customer Number

        /// <summary>
        /// Set customer Number and quote Name
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="driver">customerNumber.</param>
        /// <param name="driver">quoteName.</param>
        /// <returns></returns>
        public void SetCustomerNumber(IWebDriver driver, string quoteName, string customerNumber)
        {
            var createQuotePage = new CreateQuotePage(driver);
            createQuotePage.TxtQuoteName.SetText(driver, quoteName);
            createQuotePage.TxtCustomerNumber.SetText(driver, customerNumber);
            //createQuotePage.TxtCustomerNumber.SetText(driver, customerNumber);
            createQuotePage.TxtQuoteName.Click(driver);
        }

        #endregion

        #region Verify  price in create quote page under service tag
        public void GotoPriceDetailsUnderServiceTag(IWebDriver driver)
        {
            var createQuotePage = new CreateQuotePage(driver);
            createQuotePage.ClickViewMore.Click(driver);
            // createQuotePage.ClickServiceTag.Click(driver);
        }

        #endregion

        #endregion

    }
}
#endregion