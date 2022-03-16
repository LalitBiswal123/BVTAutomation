using Dsa.Utils;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

namespace Dsa.Pages.APOS
{
    public class ServiceTagSearchResultPage : DsaPageBase
    {
        public ServiceTagSearchResultPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements

        public IWebElement ProductDesc { get { return WebDriver.GetElement(By.Id("apos_results_productDescription")); } }

        public IWebElement LnkEditSearch { get { return WebDriver.GetElement(By.CssSelector("#serviceTag_searchEdit_link")); } }

        public IWebElement EditSearch { get { return WebDriver.GetElement(By.XPath("//button[contains(text(), 'Edit Search')]")); } }

        public IWebElement BtnFilterResults { get { return WebDriver.GetElement(By.Id("apos_results_filterButton")); } }

        public IWebElement LnkInvalidServiceTags { get { return WebDriver.GetElement(By.Id("apos_search_results_invalidServiceTags")); } }

        public IWebElement NoResultsFound { get { return WebDriver.GetElement(By.Id("noResults_returnPrevious_partPre")); } }

        public IWebElement GridResults { get { return WebDriver.GetElement(By.Id("apos_serviceTag_resultsGrid")); } }

        public IWebElement LnkNoResults { get { return WebDriver.GetElement(By.Id("common_noResults_link")); } }

        public IWebElement GroupBtn { get { return WebDriver.GetElement(By.CssSelector("div.app-controls > button.btn.btn-success")); } }

        public IWebElement GroupServiceTagBtn { get { return WebDriver.GetElement(By.Id("apos_grouping")); } }

        public IWebElement SelectedServiceTagsMsg { get { return WebDriver.GetElement(By.XPath("//*[text()[contains(.,'selected out of')]]")); } }

        public IWebElement MsgshowMaxTagCount { get { return WebDriver.GetElement(By.XPath("//*[@class = 'alert alert-warning']")); } }

        public IWebElement SelectAll { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Select all')]")); } }

        public IWebElement ErrorHandlingMsg { get { return WebDriver.GetElement(By.XPath("//*[@class = 'alert alert-info']")); } }

        public IWebElement ErrorMsg { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-error']")); } }

        public IWebElement NoServiceTagFound { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'No valid service tags found.')]")); } }

        public IWebElement Alertinfo { get { return WebDriver.GetElement(By.XPath("//span[@class = 'icon-small-alertinfo']")); } }

        public IWebElement ServiceTagchkbox { get { return WebDriver.GetElement(By.XPath("//input[@type='checkbox' and contains(@ng-model,'aposSearchResultsCtrl.tagSelections')]")); } }

        public IWebElement ServiceTagID { get { return WebDriver.GetElement(By.CssSelector("div[row-id='0'] div>div:nth-child(3)")); } }

        public IWebElement CompanyNumber { get { return WebDriver.GetElement(By.CssSelector("div[row-id='0'] div>div:nth-child(4)")); } }

        public IWebElement ServiceTagCustomerNumber { get { return WebDriver.GetElement(By.CssSelector("div[row-id='0'] div>div:nth-child(5)")); } }

        public IWebElement ServiceLevelcode { get { return WebDriver.GetElement(By.CssSelector("div[row-id='0'] div>div:nth-child(7)")); } }

        public IWebElement ContractEnddate { get { return WebDriver.GetElement(By.CssSelector("div[row-id='0'] div>div:nth-child(12)")); } }

        public IWebElement Shipdate { get { return WebDriver.GetElement(By.CssSelector("div[row-id='0'] div>div:nth-child(13)")); } }

        public IWebElement ContractStatus { get { return WebDriver.GetElement(By.CssSelector("div[row - id = '0'] div > div:nth - child(14)")); } }

        public IWebElement Systemclass { get { return WebDriver.GetElement(By.CssSelector("div[row-id='0'] div>div:nth-child(15)")); } }

        public IWebElement Zipcode { get { return WebDriver.GetElement(By.CssSelector("div[row-id='0'] div>div:nth-child(17)")); } }

        public IWebElement ServiceTagsSelected { get { return WebDriver.GetElement(By.CssSelector("h3~p")); } }

        public IWebElement ExpandServiceTag { get { return WebDriver.GetElement(By.XPath("//a[@class='k-icon expandRowPromise k-i-arrow-s']")); } }

        public IWebElement AgreementID { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_1']//tbody//tr[2]//td[2]//div//div[3]/div[2]/div[1]")); } }

        public IWebElement SolutionName { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_1']//tbody//tr[2]//td[2]//div//div[3]//div[2]/div[2]")); } }

        public IWebElement AddressesTable { get { return WebDriver.GetElement(By.XPath("//div[@class='ag-selectable']")); } }

        public IWebElement SplitGrp { get { return WebDriver.GetElement(By.XPath("//button[@class='btn icon-split']")); } }

        public IWebElement NoInvalidTagsNotification { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'No invalid service tags found.')]")); } }

        public IWebElement NoValidTagsNotification { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'No valid service tags found.')]")); } }

        public IWebElement AssetIdColumnName { get { return WebDriver.GetElement(By.XPath("//app-apos-grid-header-renderer//span[contains(text(), 'Asset Id')]")); } }

        public IWebElement AssetTypeColumnName { get { return WebDriver.GetElement(By.XPath("//app-apos-grid-header-renderer//span[contains(text(), 'Asset Type')]")); } }

        public IWebElement SelectAllChkbox { get { return WebDriver.GetElement(By.Id("selectAllServiceTags")); } }

        #endregion

        // Get the service tag count
        public int GetServiceTagCount()
        {
            int ServiceTagList = WebDriver.FindElements(By.XPath("//div[@class='ag-results-grid-cell apos-service-tag-id-result-cell'][1]")).Count;
            return ServiceTagList;
        }

        public List<Dictionary<string, object>> GetServiceTagSearchResultsTable()
        {
            GridResults.WaitForElement(WebDriver);
            return GridResults.GetTableData(WebDriver);
        }

        public ServiceTagGroupsPage CreateAposGroup()
        {
            GroupBtn.Click(WebDriver);
            return new ServiceTagGroupsPage(WebDriver);
        }

        public ServiceTagSearchResultPage ServiceTagSelect(string servicetag)
        {
            WebDriver.GetElement(By.XPath("//label[contains(text(),'Select all')]")).Click(WebDriver);
            return new ServiceTagSearchResultPage(WebDriver);
        }

        public ServiceTagSearchResultPage SelectAllTags(IWebDriver WebDriver)
        {
            var serviceTagGroup = new ServiceTagSearchResultPage(WebDriver);
            SelectAll.Click(WebDriver);

            serviceTagGroup.GroupBtn.Click(WebDriver);
            return new ServiceTagSearchResultPage(WebDriver);
        }

        public bool IsDisplayedServicetagRequiredData()

        {

            if ((ServiceTagID.GetText(WebDriver).ToString().Contains("-")) || (CompanyNumber.GetText(WebDriver).ToString().Contains("-")) || (ServiceTagCustomerNumber.GetText(WebDriver).ToString().Contains("-")) || (ServiceLevelcode.GetText(WebDriver).ToString().Contains("-")) || (ContractEnddate.GetText(WebDriver).ToString().Contains("-")) || (Shipdate.GetText(WebDriver).ToString().Contains("-")) || (ContractStatus.GetText(WebDriver).ToString().Contains("-")) || (Systemclass.GetText(WebDriver).ToString().Contains("-")))// || (Zipcode.GetText(WebDriver).ToString().Contains("-")))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              //    if ((ContractEnddate.GetText(WebDriver).ToString().Contains("-")))
            {

                return false;
            }

            return true;

        }
        public IWebElement GetServiceTagDetails(int? Index)
        {
            return WebDriver.FindElement(By.CssSelector("div[ref='eFullWidthContainer']>div[row-id='0'] apos-service-tag-summary>div>div:nth-child(3)>div:nth-child(2)>div:nth-child("+Index+")>div:last-child"));
        }

        public IWebElement ValidAndInvalidServiceTagsTab(string tabText)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='apos_search_results_" + tabText + "']"));

        }

        public IWebElement InvalidServiceTagsGridColumns(string columnName)
        {
            return WebDriver.FindElement(By.XPath("//app-apos-grid-header-renderer//span[contains(text(), '" + columnName + "')]"));

        }

        public List<Dictionary<string, object>> GetServiceTagDataTable()
        {
            AddressesTable.WaitForElement(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return AddressesTable.GetGridTableData(WebDriver);
        }

        public void GetServiceTagFromDataTable(String replacementServiceTag)
        {
            int index = 0;
            string replacementTag = String.Empty;

            var serviceTagTable = GetServiceTagDataTable();
            foreach (var serviceTags in serviceTagTable)
            {
                if (replacementServiceTag.ToString().Equals(serviceTags["Service Tag Id"]))
                {
                    replacementTag = serviceTags["Service Tag Id"].ToString();
                    Logger.Write("Replacement Tag: " + replacementTag);
                    replacementTag.Should().BeEquivalentTo(replacementServiceTag);
                    break;
                }
                index++;
            }
        }

        public int GetStatusGridRowCount()
        {
            int rowCount = 0;
            List<IWebElement> rows = WebDriver.GetElements(By.XPath("//*[@id='DataTables_Table_1']//tbody//tr"));

            if (rows != null)
            {
                rowCount = rows.Count;
            }
            return rowCount;
        }

        // Check for the service tag in each page
        public void GetGridPagination(String serviceTag, int? agreementIdIndex, int? solutionNamedIndex, String AgreementId, String SolutionName)
        {
            int index = 0;
            var paginationIndex = 1;
            var pageNoLinks = GetStatusGridPaginationPageLinks();
            foreach (var pageNo in pageNoLinks)
            {
                var addressTable = GetServiceTagDataTable();
                foreach (var address in addressTable)
                {
                    if (serviceTag.ToString().Equals(address["Service Tag Id"]))
                    {
                        GetPaginationTableData(serviceTag, agreementIdIndex, solutionNamedIndex, AgreementId, SolutionName);
                        break;
                    }
                    index++;
                }

                var gridPaginationIndex = paginationIndex++;
                WebDriver.FindElement(By.XPath("//*[@id='gridPagination_page" + gridPaginationIndex + "']//div")).Click(WebDriver);
                WebDriver.VerifyBusyOverlayNotDisplayed();
            }
        }

        public List<IWebElement> GetStatusGridPaginationPageLinks()
        {
            return WebDriver.GetElements(By.XPath("//*[@class='c-grid-pagination c-pagination']//ul//li"));
        }

        public IWebElement GetExpandServiceTagButtons(int index)
        {
            ReadOnlyCollection<IWebElement> paginationButtons =
            WebDriver.FindElements(By.XPath("//*[@class='k-icon expandRowPromise k-i-arrow-s']"));
            return paginationButtons.ElementAt(index);
        }

        // Find the agreement Id and Solution Name for specific row
        public IWebElement GetAgreementIdandSolutionName(int? rowIndex, int? Index)
        {
            return WebDriver.FindElement(By.CssSelector("div[row-id='" + rowIndex + "'] apos-service-tag-summary>div>div:nth-child(3)>div:nth-child(2)>div:nth-child(" + Index + ")"));
        }

        // Check for the matching service tag from one of the pages and get the Agreement Id and Solution name of that tag
        public void GetPaginationTableData(String serviceTag, int? agreementIdIndex, int? solutionNamedIndex, String AgreementId, String SolutionName)
        {
            int index = 0;
            var addressTable = GetServiceTagDataTable();

            foreach (var address in addressTable)
            {
                if (serviceTag.ToString().Equals(address["Service Tag Id"]))
                {
                    GetExpandServiceTagButtons(index).Click(WebDriver);
                    var agreementId = GetAgreementIdandSolutionName(index + 2, agreementIdIndex).GetText(WebDriver).Split(':')[1].Trim();
                    agreementId.Should().BeEquivalentTo(AgreementId);

                    var solutionName = GetAgreementIdandSolutionName(index + 2, solutionNamedIndex).GetText(WebDriver).Split(':')[1].Trim();
                    solutionName.Should().BeEquivalentTo(SolutionName);
                    break;
                }
                index++;
            }
        }
    }
}
