using Dsa.Utils;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Linq;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Dsa.Pages
{
    public class AutomationPage : DsaPageBase
    {

        const string DSA_ID_DATA_TABLES_TABLE_STATUS_GRID = "bulkProcessingStatus_Grid";
        const string DSA_TAG_APP_DETAILS = "app-details";
        const string DSA_ID_STATUS_GRID_PAGINATION_PER_PAGE = "status_grid_grid_paging_itemsPerPage;";
        const string DSA_ID_WORK_ITEMS_GRID_PAGINATION = "work_items_grid_partyGrid_pagination";
        const string CANCELLED = "CANCELLED";
        const string COMPLETED = "COMPLETED";
        const string COMPLETED_WITH_ERRORS = "COMPLETEDWITHERRORS";
        const string INPROGRESS = "INPROGRESS";
        const string PENDING = "PENDING";

        public AutomationPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region UI Elements

        public IWebElement BtnViewStatus { get { return WebDriver.GetElement(By.Id("automationInitialize_viewStatus")); } }

        public IWebElement TextTitle { get { return WebDriver.GetElement(By.XPath("//*[@id='automationInitialize_title_bulkItemProcessing']")); } }

        public IWebElement InputChooseFile { get { return WebDriver.GetElement(By.Id("uploadAutomation")); } }

        public IWebElement UploadButton { get { return WebDriver.GetElement(By.Id("automationInitialize_upload_bulk")); } }

        public IWebElement LnkDownloadCreateQuote { get { return WebDriver.GetElement(By.LinkText("Download Create Quote Template")); } }

        public IWebElement BtnFilter { get { return WebDriver.GetElement(By.Id("automationStatus_viewStatus")); } }

        public IWebElement TblStatus { get { return WebDriver.FindElement(By.Id(DSA_ID_DATA_TABLES_TABLE_STATUS_GRID)); } }

        public IWebElement DivPaginationNo { get { return WebDriver.GetElement(By.Id("status_grid_fromto")); } }

        public IWebElement DivStatusPaginationNo { get { return WebDriver.GetElement(By.Id("bulkProcessingStatus_Grid_fromto")); } }

        public IWebElement LblPaginationDisplay { get { return WebDriver.GetElement(By.XPath("//*[@id='status_grid_pagesize']/label")); } }

        public IWebElement LblStatusPaginationDisplay { get { return WebDriver.GetElement(By.XPath("//*[@id='bulkProcessingStatus_Grid_pagesize']/label")); } }

        public IWebElement DropDownPagination { get { return WebDriver.GetElement(By.Id(DSA_ID_STATUS_GRID_PAGINATION_PER_PAGE)); } }

        public IWebElement DropDownStatusPagination { get { return WebDriver.GetElement(By.Id("grid_paging_itemsPerPage")); } }

        public IWebElement InputBulkVersionOverride { get { return WebDriver.GetElement(By.Id("automationInitializetxt-bulk-version-override")); } }

        public IWebElement TextDetailsTitle { get { return WebDriver.GetElement(By.Id("automation_title_bulkItemDetails")); } }

        public IWebElement BtnAddNew { get { return WebDriver.GetElement(By.Id("automationDetails_viewStatus_init")); } }

        public IWebElement BtnBack { get { return WebDriver.GetElement(By.Id("automationDetails_viewStatus")); } }

        public IWebElement BtnDownloadOptions { get { return WebDriver.GetElement(By.Id("automationDetails_moreActions")); } }

        public IWebElement DivCreatedBy { get { return WebDriver.GetElement(By.Id("automationDetails_createdBy")); } }

        public IWebElement DivCreatedOn { get { return WebDriver.GetElement(By.Id("automationDetails_createdOn")); } }

        public IWebElement DivJobStartedOn { get { return WebDriver.GetElement(By.Id("automationDetails_jobStartedOn")); } }

        public IWebElement DivWorkItemType { get { return WebDriver.GetElement(By.Id("automationDetails_workItemType")); } }

        public IWebElement DivTotalDuration { get { return WebDriver.GetElement(By.Id("automationDetails_totalDuration")); } }

        public IWebElement DivStatus { get { return WebDriver.GetElement(By.Id("automationDetails_jobStatus")); } }

        public IWebElement WorkItemDropdown { get { return WebDriver.GetElement(By.Id("automationInitialize_workItemType")); } }

        public IWebElement ChooseFileButton { get { return WebDriver.GetElement(By.Id("uploadAutomation")); } }

        public IWebElement BulkJobStatus
        {
            get
            {
                return new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='DataTables_Table_0']/tbody/tr[1]/td[7]")));
            }
        }


public IWebElement BulkDownloadButton { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_0']/tbody/tr[1]/td[8]")); } }

        #endregion

        #region Actions

        public void SelectWorkItemFromDropdown(string item)
        {
            WorkItemDropdown.Click();
            WorkItemDropdown.FindElement(By.XPath(string.Format("./option[@label='{0}']", item))).Click();
        }

        public void UploadFile(string filename)
        {
            try
            {
                string path = Directory.GetCurrentDirectory() + "\\TestData\\";
                ChooseFileButton.SendKeys(path + filename);
                UploadButton.Click();
            }
            catch (FileNotFoundException ex)
            {
                Logger.Write($"File - {ex.FileName} not found.");
            }
            catch (Exception ex)
            {
                Logger.Write(ex.Message);
            }
        }

        public bool DidBulkJobPass()
        {
            bool didJobPass = false;
            WebDriver.WaitForPageLoad();
            string status = BulkJobStatus.Text;
            var refreshCounter = 0;
            while (status == PENDING || status == INPROGRESS)
            {
                WebDriver.RefreshCurrentPage();
                status = BulkJobStatus.Text;
                refreshCounter += 1;
                System.Threading.Thread.Sleep(10000);
                Logger.Write("Order in" + status + " status for" + refreshCounter * 10 + " seconds");
            }

            if (status == COMPLETED)
            {
                //BulkDownloadButton.Click();
                Logger.Write("Completed successfully");
                didJobPass = true;
            }
            else if (status == COMPLETED_WITH_ERRORS)
            {
                //BulkDownloadButton.Click();
                Logger.Write("Completed with Errors");
            }

            return didJobPass;
        }

        public string getDropdownText(int option)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='automationInitialize_workItemType']/option[ " + option + "]")).Text;
        }

        public string getStatusDropdownText(int option)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='automationStatus_workItemType']/option[ " + option + "]")).Text;
        }

        public void ClickOnDropdownLinkAtElementIndex(int option)
        {
            WebDriver.GetElement(By.XPath("//select[@id='automationInitialize_workItemType']/option[" + option + "]")).Click();
        }



        public string GetWorkItemDownloadLinkText()
        {
            return WebDriver.GetElement(By.CssSelector("[href*='BulkTemplates/CreateQuoteTemplate.xlsx']")).Text;
        }

        public string GetLabel(int index)
        {
            return WebDriver.GetElement(By.XPath("//div[" + index + "]/label")).Text;
        }

        public string GetFilterLabel()
        {
            return WebDriver.GetElement(By.XPath("//h3[@class='section-header']")).Text;
        }

        public IWebElement GetFromDateInput()
        {
            return WebDriver.GetElement(By.XPath("//*[@id='automationStatus_search_startDate']"));
        }

        public IWebElement GetFromDatePicker()
        {
            return WebDriver.GetElements(By.XPath("//span[@role='button']"))[0];
        }

        public IWebElement GetToDateInput()
        {
            return WebDriver.GetElement(By.XPath("//*[@id='automationStatus_search_endDate']"));
        }

        public IWebElement GetToDatePicker()
        {
            return WebDriver.GetElements(By.XPath("//span[@role='button']"))[1];
        }

        public string GetAutoRefreshLabelText()
        {

            return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Auto Refresh')]")).Text;
        }

        public string GetAutoRefreshDropdownText(int option)
        {
            return WebDriver.GetElement(By.XPath("//div[5]//select/option[" + option + "]")).Text;
        }

        public IWebElement GetFromCalendarPickerNavButton(int index)
        {
            /* The first 3 buttons in the day calendar picker are at index
             * 1 - Left Nav
             * 2 - Change Month
             * 3 - Right Nav
            */
            return (WebDriver.FindElement(By.XPath("//div[@class='k-header']/a[@href='#'][" + index + "]")));
            //[index - 0];

            //return (WebDriver.FindElements(By.XPath("//" + DSA_TAG_COMMON_DATE_PICKER + "//daypicker//button")))[index - 1];
        }

        public IWebElement GetFromYearCalendarPickerNavButton(int index)
        {
            /* The first 3 buttons in the month calendar picker are at index
             * 1 - Left Nav
             * 2 - Change Year
             * 3 - Right Nav
            */
            return (WebDriver.FindElement(By.XPath("//div[@class='k-header']/a[@href='#'][" + index + "]")));

            //return (WebDriver.FindElements(By.XPath("//" + DSA_TAG_COMMON_DATE_PICKER + "//monthpicker//button")))[index - 1];
        }

        public IWebElement GetFromMonthCalendarPickerNavButton(int index)
        {
            /* The first 3 buttons in the month calendar picker are at index
             * 1 - Left Nav
             * 2 - Change Year
             * 3 - Right Nav
            */
            return (WebDriver.FindElement(By.XPath("//a[@tabindex='-1']")));

            //return (WebDriver.FindElements(By.XPath("//" + DSA_TAG_COMMON_DATE_PICKER + "//monthpicker//button")))[index - 1];
        }

        public IWebElement GetFromDayCalendarPickerNavButton(int index)
        {
            /* The first 3 buttons in the day calendar picker are at index
             * 1 - Left Nav
             * 2 - Change Month
             * 3 - Right Nav
            */
            //return (WebDriver.FindElement(By.XPath("//a[@data-value='2018/0/1']")));
            return (WebDriver.FindElement(By.XPath("//table/tbody/tr[1]/td[2]/a")));

            //table/tbody/tr[1]/td[2]/a

            //[index - 0];

            //return (WebDriver.FindElements(By.XPath("//" + DSA_TAG_COMMON_DATE_PICKER + "//daypicker//button")))[index - 1];
        }

        public IWebElement GetStatusGridHeaderColumn(int index)
        {
            //return WebDriver.GetElement(By.XPath("//*[@id='"+ DSA_ID_DATA_TABLES_TABLE_STATUS_GRID+"']/thead/tr/th[" + index + "]/span"));
            return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_0']/thead/tr/th[" + index + "]"));
        }


        public bool IsColumnSortedAscending(int index)
        {
            bool sortedAsc = false;
            string result = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_0']/thead/tr/th[" + index + "]")).GetAttribute("class");
            //string result = WebDriver.GetElement(By.XPath("//*[@id='" + DSA_ID_DATA_TABLES_TABLE_STATUS_GRID + "']/thead/tr/th[" + index + "]/span/span")).GetAttribute("class");

            //*[@id="DataTables_Table_0"]/thead/tr/th[2]
            if (result.Contains("sorting_asc"))
            //if (result == "sorting_asc")
            {
                sortedAsc = true;
            }

            return sortedAsc;
        }

        public bool IsColumnSortedDescending(int index)
        {
            bool sortedDesc = false;
            string result = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_0']/thead/tr/th[" + index + "]")).GetAttribute("class");
            //string result = WebDriver.GetElement(By.XPath("//*[@id='" + DSA_ID_DATA_TABLES_TABLE_STATUS_GRID + "']/thead/tr/th[" + index + "]/span/span")).GetAttribute("class");

            if (result.Contains("sorting_desc"))
            //if (result == "sorting_desc")
            {
                sortedDesc = true;
            }

            return sortedDesc;
        }

        public string GetStatusGridCellText(int rowIndex, int colIndex)
        {
            /* The first 3 buttons in the month calendar picker are at index
             * 1 - Left Nav
             * 2 - Change Year
             * 3 - Right Nav
            */
            //return WebDriver.GetElement(By.XPath("//*[@id='" + DSA_ID_DATA_TABLES_TABLE_STATUS_GRID + "']/tbody/tr[" + rowIndex + "]/td[" + colIndex + "]")).GetText(webDriver);
             
                return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_0']/tbody/tr[" + rowIndex + "]/td[" + colIndex + "]")).GetText(WebDriver).ToString();
            
        }

        public IWebElement GetStatusGridCellDownloadButton(int rowIndex)
        {
            //Note: rowIndex is 1 based
                     
            return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_0']/tbody/tr[" + rowIndex + "]/td[7]/a"));

        }

        public string GetStatusGridCellDownloadButtonText(int rowIndex)
        {
            //Note: rowIndex is 1 based
           
            return WebDriver.GetElement(By.XPath("//a[text()='Download']["+ rowIndex + "]")).Text;
        }

        public IWebElement GetStatusGridCellDetailsButton(int rowIndex)
        {
            //Note: rowIndex is 1 based
           
            return WebDriver.GetElement(By.XPath("//a[text()='Details'][" + rowIndex + "]"));

        }

        public string GetStatusGridCellDetailsButtonText(int rowIndex)
        {
            //Note: rowIndex is 1 based
            //return WebDriver.GetElement(By.XPath("//*[@id='button_Details_" + rowIndex + "_']")).GetText(webDriver);
            return WebDriver.GetElement(By.XPath("//a[text()='Details'][" + rowIndex + "]")).Text;

        }

        public int GetStatusGridRowCount()
        {
            int rowCount = 0;
            //List<IWebElement> rows = WebDriver.GetElements(By.XPath("//*[@id='" + DSA_ID_DATA_TABLES_TABLE_STATUS_GRID + "']/tbody/tr"));
            List<IWebElement> rows = WebDriver.GetElements(By.XPath("//*[@id='DataTables_Table_0']/tbody/tr"));

            if (rows != null)
            {
                rowCount = rows.Count;
            }
            return rowCount;
        }

        public List<string> GetStatusPageNumberOptions()
        {
            int optionCount = 0;

            List<IWebElement> options = WebDriver.GetElements(By.XPath("//*[@id='grid_paging_itemsPerPage']/option"));

            if (options != null)
            {
                optionCount = options.Count;
            }


            var perPageValues = new List<string>();
            for (int count = 1; count <= optionCount; count++)
            {
                //var options = WebDriver.GetElement(By.XPath("//*[@id='" + DSA_ID_STATUS_GRID_PAGINATION_PER_PAGE + "']/option[" + count + "]")).GetAttribute("value");
                var option = WebDriver.GetElement(By.XPath("//*[@id='grid_paging_itemsPerPage']/option[" + count + "]")).GetAttribute("value");

                perPageValues.Add(option);
            }
            return perPageValues;
        }

        public void SelectFromDateJanuaryPreviousYear(IWebDriver webDriver)
        {
            //Enter From date in past to current date to get some records displayed
            GetFromDatePicker().Click(webDriver);

            //Click on the date picker month/year nav button to enable to pick the previous year
            WebDriver.FindElement(By.XPath("//div[@class='k-header']/a[@href='#'][2]")).Click(webDriver);
            //GetFromCalendarPickerNavButton(2).Click(webDriver);

            //Click on the month picker left nav button to pick the previous year
            WebDriver.FindElement(By.XPath("//div[@class='k-header']/a[@href='#'][1]")).Click(webDriver);
            //GetFromYearCalendarPickerNavButton(1).Click(webDriver);

            //Click on the month picker January button
            WebDriver.FindElements(By.XPath("//a[@tabindex='-1']")).FirstOrDefault().Click(webDriver);
            //GetFromMonthCalendarPickerNavButton(4).Click(webDriver);

            //Click on the day picker January 01 button
            WebDriver.FindElement(By.XPath("//table/tbody/tr[1]/td[2]/a")).Click(webDriver);
            //GetFromDayCalendarPickerNavButton(5).Click(webDriver);

        }

        public void VerifyStatusGridHeaderColumnSort(int colIndex)
        {
            //Click header to enable sort order 
            GetStatusGridHeaderColumn(colIndex).Click(WebDriver);
            IsColumnSortedAscending(colIndex).Equals(true);
            GetStatusGridHeaderColumn(colIndex).Click(WebDriver);
            IsColumnSortedDescending(colIndex).Equals(true);
        }

        public void VerifyStatusGridRow(int rowIndex)
        {
            const string CREATEQUOTE = "CREATEQUOTE";
            const string BACK_SLASH = "\\";
            const char FORWARD_SLASH_CHAR = '/';
            const char COLON = ':';
            const string DOWNLOAD = "Download";
            const string DETAILS = "Details";

            //Verify that 'Created By' row 1, col 2 value contains valid content
            GetStatusGridCellText(rowIndex, 2).Contains(BACK_SLASH).Equals(true);

            ////Verify that 'Date Added' row 1, col 3 value contains valid content, i.e. it has 2 date separators 
            var dateAdded = GetStatusGridCellText(rowIndex, 3);
            VerifyDateAddedFormat(dateAdded);

            ////Verify that 'Date Last Updated' row 1, col 4 value contains valid content, i.e. it has 2 date separators
            var dateUpdated = GetStatusGridCellText(rowIndex, 4);
            VerifyDateUpdatedFormat(dateUpdated);

            //Verify that 'Duration' row 1, col 6 value contains valid content, i.e. it has 2 time separators
            GetStatusGridCellText(rowIndex, 6)[2].Should().BeEquivalentTo(COLON);
            GetStatusGridCellText(rowIndex, 6)[5].Should().BeEquivalentTo(COLON);

            //Verify that 'Status' row 1, col 7 value contains valid content, 1 of (COMPLETED, CANCELLED, COMPLETED_WITH_ERRORS, INPROGRESS)
            bool statusFlag = false;

            if (GetStatusGridCellText(rowIndex, 7).Equals(CANCELLED) ||
                GetStatusGridCellText(rowIndex, 7).Equals(COMPLETED) ||
                GetStatusGridCellText(rowIndex, 7).Equals(COMPLETED_WITH_ERRORS) ||
                GetStatusGridCellText(rowIndex, 7).Equals(INPROGRESS))
            {
                statusFlag = true;
            }
            Assert.AreEqual(statusFlag, true);

            //Verify that 'Download' button for the row value is correct
            GetStatusGridCellDownloadButtonText(rowIndex).Should().BeEquivalentTo(DOWNLOAD);

            //Verify that 'Details' button for row value is correct
            GetStatusGridCellDetailsButtonText(rowIndex).Should().BeEquivalentTo(DETAILS);
        }

        public void VerifyStatusGridPagination(int perPageValue)
        {
            const string PAGINATION_VALUE_PREFIX = "1-";
            //string[] pageNumberOptions = { "5", "10", "20", "40" };
            string[] pageNumberOptions = { "10", "20", "40" };

            //Verify that pagination number of rows displayed starts with a fixed prefix
            //DivPaginationNo.Text.StartsWith(PAGINATION_VALUE_PREFIX).Equals(true);
            DivStatusPaginationNo.Text.StartsWith(PAGINATION_VALUE_PREFIX).Equals(true);

            //verify that the first page number link is clickable
            //(if we have at least 1 row returned then there will be at least 1 page in the page set)
            GetPaginationPageNumberLink(1).IsElementClickable(WebDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();

            //(Note per page options only appear when the rows returned match or exceed the
            //default per page which is 10
            if (GetStatusGridRowCount() > 9)
            {
                //Verify that the Pagination 'Display' label is present
                LblStatusPaginationDisplay.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();

                //Verify that the Pagination DropDown is present
                DropDownStatusPagination.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();

                var perPageList = GetStatusPageNumberOptions();
                int count = 0;
                foreach (string page in perPageList)
                {
                    page.Should().BeEquivalentTo(pageNumberOptions[count]);
                    count++;
                }

                //Set Pagination value and verify a value is set
                SetPaginationRowsSelected(perPageValue);

            }
        }

        public void SetPaginationRowsSelected(int perPageValue)
        {
            const string FIVE_PER_PAGE = "5 per page";
            const string TEN_PER_PAGE = "10 per page";
            const string TWENTY_PER_PAGE = "20 per page";
            const string FORTY_PER_PAGE = "40 per page";
            string perPageDisplayValue = "";

            var paginationSelect = new SelectElement(DropDownStatusPagination);

            switch (perPageValue) {
                case 5:
                    paginationSelect.SelectByText(FIVE_PER_PAGE);
                    perPageDisplayValue = FIVE_PER_PAGE;
                    break;
                case 10:
                    paginationSelect.SelectByText(TEN_PER_PAGE);
                    perPageDisplayValue = TEN_PER_PAGE;
                    break;
                case 20:
                    paginationSelect.SelectByText(TWENTY_PER_PAGE);
                    perPageDisplayValue = TWENTY_PER_PAGE;
                    break;
                case 40:
                    paginationSelect.SelectByText(FORTY_PER_PAGE);
                    perPageDisplayValue = FORTY_PER_PAGE;
                    break;
            }

            //Wait for busy overlay to finish
            WebDriver.VerifyBusyOverlayNotDisplayed();

            //Verify that the per page has been set in the dropdown
            paginationSelect.SelectedOption.GetText(WebDriver, TimeSpan.FromSeconds(5)).Should().BeEquivalentTo(perPageDisplayValue);

        }

        public IWebElement GetPaginationPageNumberLink(int rowIndex)
        {
            //Note: rowIndex is 1 based
            //return WebDriver.GetElement(By.XPath("//*[@id='status_grid_partyGrid_pagination']/ul[" + rowIndex + "]/li/a"));
            return WebDriver.GetElement(By.XPath("//*[@id='bulkProcessingStatus_Grid_pagination']/ul/li[" + rowIndex + "]"));

        }

        public IWebElement GetDetailsLabel(int index)
        {
            //var elements = WebDriver.GetElements(By.XPath("//" + DSA_TAG_APP_DETAILS + "//label"));
            var elements = WebDriver.GetElements(By.XPath("//div[@id='main']//label"));

            // index in the array is now 0 based, so subtract 1 from parameter index
            return elements[index - 1];
        }

        public IWebElement GetDetailsTable(int index)
        {
            //var elements = WebDriver.GetElements(By.XPath("//" + DSA_TAG_APP_DETAILS + "//table"));
            var elements = WebDriver.GetElements(By.XPath("//table[@class='c-data-grid dataTable']"));

            // index in the array is now 0 based, so subtract 1 from parameter index
            return elements[index - 1];
        }

        public List<IWebElement> GetDetailsTableBodies()
        {
            //Note: index is 1 based
            return WebDriver.GetElements(By.XPath("//" + DSA_TAG_APP_DETAILS + "//table/tbody"));
        }

        public List<IWebElement> GetStatusCountTableBodies()
        {
            //Note: index is 1 based
            return WebDriver.GetElements(By.XPath("//div[@class='row']//table[@class='c-data-grid dataTable'][1]/tbody"));
        }

        public IWebElement GetDetailsTotalLabelCell(int index)
        {
            //Note: index is 1 based
            //return WebDriver.GetElement(By.XPath("//" + DSA_TAG_APP_DETAILS + "//table/tbody[" + index + "]/tr/td[1]"));
            return WebDriver.GetElement(By.XPath("//div[@class='row']//table[@class='c-data-grid dataTable'][1]/tbody[" + index + "]/tr/td[1]"));

        }
        public IWebElement GetDetailsTotalValueCell(int index)
        {
            //Note: index is 1 based
            //return WebDriver.GetElement(By.XPath("//" + DSA_TAG_APP_DETAILS + "//table/tbody[" + index + "]/tr/td[2]"));
            return WebDriver.GetElement(By.XPath("//div[@class='row']//table[@class='c-data-grid dataTable'][1]/tbody[" + index + "]/tr/td[2]"));
        }

        public int GetDetailsWorkItemsGridRowCount()
        {
            int rowCount = 0;

            //List<IWebElement> rows = WebDriver.GetElements(By.XPath("//*[@id='" + DSA_ID_DATA_TABLES_TABLE_WORK_ITEMS_GRID + "']/tbody/tr"));
            List<IWebElement> rows = WebDriver.GetElements(By.XPath("//*[@id='DataTables_Table_1']/tbody/tr"));

            if (rows != null)
            {
                rowCount = rows.Count;
            }

            return rowCount;
        }

        public IWebElement GetDetailsGridHeaderColumn(int index)
        {
            //return WebDriver.GetElement(By.XPath("//*[@id='" + DSA_ID_DATA_TABLES_TABLE_WORK_ITEMS_GRID + "']/thead/tr/th[" + index + "]/span"));
            return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_1_wrapper']/table/thead/tr/th[" + index + "]"));

        }

        public bool IsDetailsColumnSortedAscending(int index)
        {
            bool sortedAsc = false;
            //string result = WebDriver.GetElement(By.XPath("//*[@id='" + DSA_ID_DATA_TABLES_TABLE_WORK_ITEMS_GRID + "']/thead/tr/th[" + index + "]/span/span")).GetAttribute("class");
            string result = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_1_wrapper']/table/thead/tr/th[" + index + "]")).GetAttribute("class");

            if (result.Contains("sorting_asc"))
            {
                sortedAsc = true;
            }

            return sortedAsc;
        }

        public bool IsDetailsColumnSortedDescending(int index)
        {
            bool sortedDesc = false;
            //string result = WebDriver.GetElement(By.XPath("//*[@id='" + DSA_ID_DATA_TABLES_TABLE_WORK_ITEMS_GRID + "']/thead/tr/th[" + index + "]/span/span")).GetAttribute("class");
            string result = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_1_wrapper']/table/thead/tr/th[" + index + "]")).GetAttribute("class");
            if (result.Contains("sorting_asc"))

            if (result == "sorting_desc")
            {
                sortedDesc = true;
            }

            return sortedDesc;
        }

        public void VerifyDetailsGridHeaderColumnSort(int colIndex)
        {
            //Click header to enable sort order 
            GetDetailsGridHeaderColumn(colIndex).Click(WebDriver);
            IsDetailsColumnSortedAscending(colIndex).Equals(true);
            GetDetailsGridHeaderColumn(colIndex).Click(WebDriver);
            IsDetailsColumnSortedDescending(colIndex).Equals(true);
        }

        public void VerifyBulkAndDsaUrlsAreEqual(String DsaUrl, String BulkUrl)
        {
            var DsaUrlValues = DsaUrl.Split('/');
            var BulkUrlValues = BulkUrl.Split('/');

            /* The 3rd index in each array holds the base url prefix and we
               are interested in comparing the server no. at index 1 of that string
               these should be equal.
               If the server no.s are not equal then the DSA Management tool, App Setting for
               enabling NewBulkUI needs to be set to true. e.g for G2 SIT
               http://g2vmtools06.olqa.preol.dell.com/DSA-Maintenance/AppSettings?keyName=newbulk
               set NewBulkUiEnabled attribute to True */

            Assert.AreEqual(BulkUrlValues[2][1], DsaUrlValues[2][1]);
        }

        public void VerifyJobDetailsHeader(IWebDriver webDriver)
        {
            const string DETAILS_TITLE_PREFIX_TEXT = "Details for Job #:";
            const string ADD_NEW_BTN_TEXT = "Add New";
            const string BACK_BTN_TEXT = "Back";
            const string DOWNLOAD_OPTIONS_BTN_TEXT = "Download Options";
            const string CREATED_BY_LABEL_TEXT = "Created By:";
            const string CREATED_ON_LABEL_TEXT = "Created On:";
            const string JOB_STARTED_ON_LABEL_TEXT = "Job Started On:";
            const string WORK_ITEM_TYPE_LABEL_TEXT = "Work Item Type:";
            const string TOTAL_DURATION_LABEL_TEXT = "Total Duration:";
            const string STATUS_LABEL_TEXT = "Status:";
            const string BACK_SLASH = "\\";
            const string DASH = "-";
            const string T_CHAR = "T";
            const string Z_CHAR = "Z";
            const char COLON = ':';
            const string DOT = ".";
            const string CREATEQUOTE = "CREATEQUOTE";
            const string CREATEORDER = "CREATEORDER";
            const string TOTAL = "TOTAL";

            //Verify the Page title
            //TextDetailsTitle.GetText(webDriver).Should().StartWith(DETAILS_TITLE_PREFIX_TEXT);
            GetJobIdTitle().GetText(webDriver).Should().StartWith("Job Id:");

            //Verify Add New button is present
            BtnAddNew.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            BtnAddNew.GetText(webDriver).Should().BeEquivalentTo(ADD_NEW_BTN_TEXT);

            //Verify Back button is present
            BtnBack.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            BtnBack.GetText(webDriver).Should().BeEquivalentTo(BACK_BTN_TEXT);

            //Verify Download Options button is present
            BtnDownloadOptions.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            BtnDownloadOptions.GetText(webDriver).Should().BeEquivalentTo(DOWNLOAD_OPTIONS_BTN_TEXT);

            //Verify Created By label is present
            GetDetailsLabel(1).IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            GetDetailsLabel(1).GetText(webDriver).Should().BeEquivalentTo(CREATED_BY_LABEL_TEXT);

            //Verify Created By value is present
            DivCreatedBy.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            //Verify Created By value contains valid content
            DivCreatedBy.GetText(webDriver).Contains(BACK_SLASH).Equals(true);

            //Verify Created On label is present
            GetDetailsLabel(2).IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            GetDetailsLabel(2).GetText(webDriver).Should().BeEquivalentTo(CREATED_ON_LABEL_TEXT);

            //Verify Created On value is present
            DivCreatedOn.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();

            //Note update date validation after 0502

            //Verify Created On value contains valid content
            /*DivCreatedOn.GetText(webDriver)[4].Should().BeEquivalentTo(DASH);
            DivCreatedOn.GetText(webDriver)[7].Should().BeEquivalentTo(DASH);
            DivCreatedOn.GetText(webDriver)[10].Should().BeEquivalentTo(T_CHAR);
            DivCreatedOn.GetText(webDriver)[13].Should().BeEquivalentTo(COLON);
            DivCreatedOn.GetText(webDriver)[16].Should().BeEquivalentTo(COLON);
            DivCreatedOn.GetText(webDriver)[19].Should().BeEquivalentTo(DOT);
            Assert.IsTrue(DivCreatedOn.GetText(webDriver).EndsWith(Z_CHAR));*/

            //Verify Job Started On label is present
            GetDetailsLabel(3).IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            GetDetailsLabel(3).GetText(webDriver).Should().BeEquivalentTo(JOB_STARTED_ON_LABEL_TEXT);

            //Verify Job Started On value is present
            DivJobStartedOn.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            //Verify Job Started On value contains valid content
            /*DivJobStartedOn.GetText(webDriver)[4].Should().BeEquivalentTo(DASH);
            DivJobStartedOn.GetText(webDriver)[7].Should().BeEquivalentTo(DASH);
            DivJobStartedOn.GetText(webDriver)[10].Should().BeEquivalentTo(T_CHAR);
            DivJobStartedOn.GetText(webDriver)[13].Should().BeEquivalentTo(COLON);
            DivJobStartedOn.GetText(webDriver)[16].Should().BeEquivalentTo(COLON);
            DivJobStartedOn.GetText(webDriver)[19].Should().BeEquivalentTo(DOT);
            Assert.IsTrue(DivJobStartedOn.GetText(webDriver).EndsWith(Z_CHAR));
            */

            //Note update date validation after 0502

            //Verify Work Item Type label is present
            GetDetailsLabel(4).IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            GetDetailsLabel(4).GetText(webDriver).Should().BeEquivalentTo(WORK_ITEM_TYPE_LABEL_TEXT);

            //Verify Work Item Type value is present
            DivWorkItemType.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            DivWorkItemType.GetText(webDriver).Should().BeEquivalentTo(CREATEQUOTE);

            //Verify Total Duration label is present
            GetDetailsLabel(5).IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            GetDetailsLabel(5).GetText(webDriver).Should().BeEquivalentTo(TOTAL_DURATION_LABEL_TEXT);

            //Verify Total Duration value is present
            DivTotalDuration.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            //Verify Job Started On value contains valid content
            DivTotalDuration.GetText(webDriver)[2].Should().BeEquivalentTo(COLON);
            DivTotalDuration.GetText(webDriver)[5].Should().BeEquivalentTo(COLON);

            //Verify Status label is present
            GetDetailsLabel(6).IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            GetDetailsLabel(6).GetText(webDriver).Should().BeEquivalentTo(STATUS_LABEL_TEXT);

            //Verify Status value is present
            DivStatus.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            //Verify that Status value contains valid content, 1 of (COMPLETED, CANCELLED, COMPLETED_WITH_ERRORS)
            bool statusFlag = false;

            if (DivStatus.GetText(webDriver).Equals(CANCELLED) ||
                DivStatus.GetText(webDriver).Equals(COMPLETED) ||
                DivStatus.GetText(webDriver).Equals(COMPLETED_WITH_ERRORS) ||
                DivStatus.GetText(webDriver).Equals(INPROGRESS))
            {
                statusFlag = true;
            }
            Assert.AreEqual(statusFlag, true);

            //Verify totals table exists 
            GetDetailsTable(1).IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            //Verify that the table has a total label
            //List<IWebElement> els = GetDetailsTableBodies();

            List<IWebElement> els = GetStatusCountTableBodies();

            int count = 1;
            bool totalsLabelFoundFlag = false;

            foreach (IWebElement el in els)
            {
                if (GetDetailsTotalLabelCell(count).GetText(webDriver).Equals(TOTAL))
                {
                    totalsLabelFoundFlag = true;
                    break;
                }
                count++;
            }
            Assert.AreEqual(totalsLabelFoundFlag, true);

            //Verify that the table has a numeric total value
            int x = 0;
            string totalValueCell = GetDetailsTotalValueCell(count).GetText(webDriver);
            bool numericTotalValueFlag = false;

            if (Int32.TryParse(totalValueCell, out x))
            {
                // you know that the parsing attempt
                // was successful
                numericTotalValueFlag = true;
            }
            else
            {
                numericTotalValueFlag = false;
            }
            Assert.AreEqual(numericTotalValueFlag, true);

        }

        public void VerifyWorkItemDetailsHeader(IWebDriver webDriver)
        {
            string[] DetailsGridHeaders = { "Id", "Date Added", "Date Last Updated", "Duration", "Worker", "Status" };

            //Id header
            GetDetailsGridHeaderColumn(2).IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            GetDetailsGridHeaderColumn(2).GetText(webDriver).Should().BeEquivalentTo(DetailsGridHeaders[0]);
            VerifyDetailsGridHeaderColumnSort(2);

            //Date Added header
            GetDetailsGridHeaderColumn(3).IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            GetDetailsGridHeaderColumn(3).GetText(webDriver).Should().BeEquivalentTo(DetailsGridHeaders[1]);
            VerifyDetailsGridHeaderColumnSort(3);

            //Date Last Updated header
            GetDetailsGridHeaderColumn(4).IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            GetDetailsGridHeaderColumn(4).GetText(webDriver).Should().BeEquivalentTo(DetailsGridHeaders[2]);
            VerifyDetailsGridHeaderColumnSort(4);

            //Duration header (not sortable)
            GetDetailsGridHeaderColumn(5).IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            GetDetailsGridHeaderColumn(5).GetText(webDriver).Should().BeEquivalentTo(DetailsGridHeaders[3]);

            //Worker header
            GetDetailsGridHeaderColumn(6).IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            GetDetailsGridHeaderColumn(6).GetText(webDriver).Should().BeEquivalentTo(DetailsGridHeaders[4]);
            VerifyDetailsGridHeaderColumnSort(6);

            //Status header
            GetDetailsGridHeaderColumn(7).IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
            GetDetailsGridHeaderColumn(7).GetText(webDriver).Should().BeEquivalentTo(DetailsGridHeaders[5]);
            VerifyDetailsGridHeaderColumnSort(7);

        }

        public void VerifyWorkItemDetailsGridRow(int rowIndex)
        {
            const char FORWARD_SLASH_CHAR = '/';
            const string COLON = ":";
            const string VIEW_OBJECT = "View Object";
            const string OPEN_BRACE = "{";
            const string CLOSE_BRACE = "{";
            var test = GetDetailsGridCellText(rowIndex, 2);
            //Verify that 'Id' row 1, col 2 value contains valid content
            Assert.IsNotNull(GetDetailsGridCellText(rowIndex, 2));

            //Verify that 'Date Added' row 1, col 3 value contains valid content
            var dateAdded = GetDetailsGridCellText(rowIndex, 3);
            VerifyDateAddedFormat(dateAdded);

            //Verify that 'Date Last Updated' row 1, col 4 value contains valid content, i.e. it has 2 date separators
            var dateLastUpdated = GetDetailsGridCellText(rowIndex, 4);
            VerifyDateUpdatedFormat(dateLastUpdated);

            //Verify that 'Duration' row 1, col 5 value contains valid content, i.e. it has 2 time separators
            GetDetailsGridCellText(rowIndex, 5)[2].ToString().Should().BeEquivalentTo(COLON);
            GetDetailsGridCellText(rowIndex, 5)[5].ToString().Should().BeEquivalentTo(COLON);

            //Verify that 'Worker' row 1, col 6 value contains valid content
            GetDetailsGridCellText(rowIndex, 6).Contains("").Equals(false);

            //Verify that 'Status' row 1, col 7 value contains valid content, 1 of (COMPLETED, CANCELLED, COMPLETED_WITH_ERRORS)
            bool statusFlag = false;

            if (GetDetailsGridCellText(rowIndex, 7).Equals(CANCELLED) ||
                GetDetailsGridCellText(rowIndex, 7).Equals(COMPLETED) ||
                GetDetailsGridCellText(rowIndex, 7).Equals(COMPLETED_WITH_ERRORS) ||
                GetDetailsGridCellText(rowIndex, 7).Equals(INPROGRESS))
            {
                statusFlag = true;
            }
            Assert.AreEqual(statusFlag, true);

            //Verify that 'View Object' button text value for the row is correct (Note: Index here is 0 based, so subtract 1 from parameter rowIndex)
            GetDetailsGridCellViewObjectButtonText(rowIndex, 8).Should().BeEquivalentTo(VIEW_OBJECT);

            //Verify 'View Object' button is clickable
            GetDetailsGridCellViewObjectButton(rowIndex, 8).IsElementClickable(WebDriver, TimeSpan.FromSeconds(5));

            //Click 'View Object' button
            GetDetailsGridCellViewObjectButton(rowIndex, 8).Click(WebDriver);

            //Wait for busy overlay to finish
            WebDriver.VerifyBusyOverlayNotDisplayed();

            //Verify that a popup opens and it has valid content

            //Verify that the json code block is populated
            GetDetailsViewObjectPopupPreText(WebDriver).Contains(OPEN_BRACE);
            GetDetailsViewObjectPopupPreText(WebDriver).Contains(CLOSE_BRACE);

            //Close the popup
            GetDetailsViewObjectPopupCloseButton(WebDriver).Click(WebDriver);

        }

        public void VerifyStatusGridPaginationWorks(IWebDriver webDriver)
        {
            //var paginationText = DivPaginationNo.GetText(webDriver);
            if (DivStatusPaginationNo.IsElementDisplayed(webDriver))
            {
                var paginationText = DivStatusPaginationNo.GetText(webDriver);
                var index = paginationText.LastIndexOf(" ");
                var resultsSizeStr = paginationText.Substring(index + 1).Trim();

                var resultsSize = 0;
                if (Int32.TryParse(resultsSizeStr, out resultsSize))
                {
                    //We know that the parsing attempt was successful
                    var paginationSelect = new SelectElement(DropDownStatusPagination);

                    // parse the per page no. value from the selected value string, this is the first value in the split on ' ' array
                    string[] splitPageStrs = paginationSelect.SelectedOption.GetText(webDriver).Split(' ');
                    var perPageSelectedStr = splitPageStrs[0];

                    int perPageSelected;
                    if (Int32.TryParse(perPageSelectedStr, out perPageSelected))
                    {
                        // the resultsSize >= perPage Selected then we will expect multiple pages 
                        if (resultsSize >= perPageSelected)
                        {
                            //We can now test the nav left and nav right arrows and test that we have page number links

                            var pageNoLinks = GetStatusGridPaginationPageLinks();
                            //verify that the page links are appearing, they are clickable and the correct no. 
                            int pageNoLinkCounter = 0;

                            foreach (var pageNo in pageNoLinks)
                            {
                                pageNo.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
                                pageNo.IsElementClickable(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
                                pageNoLinkCounter++;

                                if (pageNoLinkCounter == pageNoLinks.Count)
                                {
                                    int maxPageNo;
                                    if (Int32.TryParse(pageNo.GetText(webDriver, TimeSpan.FromSeconds(5)), out maxPageNo))
                                    {
                                        Assert.AreEqual(maxPageNo, CalcNumOfPageLinks(perPageSelected, resultsSize));
                                    }
                                    else
                                    {
                                        Logger.Write("Page No. is not a number!");
                                        Assert.Fail();
                                    }

                                }
                            }

                            /*randomly select a page between 1 and 1 less than the page maxiumum as we expect to be able
                              to click the navigate right arrow link. If we were on the last page then the right arrow link
                            would be inactive */
                            var randomPageNo = DsaUtil.GetNextRnd(1, pageNoLinks.Count - 1);
                            var pageNoLink = GetStatusGridPaginationPageLink(randomPageNo);

                            //Verify that the page link is clickable
                            pageNoLink.IsElementClickable(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
                            //Click the page link
                            pageNoLink.Click(webDriver);

                            //Wait for busy overlay to finish
                            webDriver.VerifyBusyOverlayNotDisplayed();

                            //verify that the status grid has been populated
                            VerifyStatusGridPopulated();

                            //verify that we have a right nav arrow that is present
                            GetStatusPaginationNavArrow(2).IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
                            //verify that we have a right nav arrow that is clickable
                            GetStatusPaginationNavArrow(2).IsElementClickable(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();

                            //navigate to the next page by nav right arrow
                            GetStatusPaginationNavArrow(2).Click(webDriver);

                            //Wait for busy overlay to finish
                            webDriver.VerifyBusyOverlayNotDisplayed();

                            //verify that the status grid has been populated
                            VerifyStatusGridPopulated();

                            //verify that we have a left nav arrow that is present
                            GetStatusPaginationNavArrow(1).IsElementDisplayed(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();
                            //verify that we have a left nav arrow that is clickable
                            GetStatusPaginationNavArrow(1).IsElementClickable(webDriver, TimeSpan.FromSeconds(5)).Should().BeTrue();

                            //navigate to previous page by left nav arrow
                            GetStatusPaginationNavArrow(1).Click(webDriver);

                            //Wait for busy overlay to finish
                            webDriver.VerifyBusyOverlayNotDisplayed();

                            //verify that the status grid has been populated
                            VerifyStatusGridPopulated();

                        }
                    }
                    else
                    {
                        Logger.Write("Per Page selected is not a number!");
                        Assert.Fail();
                    }

                }
                else
                {
                    Logger.Write("Pagination result size returned is not a number!");
                    Assert.Fail();
                }

            }
        }

        private int CalcNumOfPageLinks(int perPageSize, int resultsSize)
        {
            double noOfPages = resultsSize / perPageSize;
            var remainder = resultsSize % perPageSize;

            noOfPages = Math.Floor(noOfPages);
            if (remainder > 0)
            {
                noOfPages = noOfPages + 1;
            }

            return Convert.ToInt32(noOfPages);

        }

        public string GetDetailsGridCellText(int rowIndex, int colIndex)
        {
            IWebElement element;
            string elementText = null;
            try
            {
                
                element = WebDriver.GetElement(
                By.XPath("//*[contains(@id,'DataTables_Table_')]/tbody/tr[" + rowIndex + "]/td[" + colIndex + "]"));
            }
            catch (Exception e)
            {
                WebDriver.Navigate().Refresh();
                Thread.Sleep(5000);
                element = WebDriver.GetElement(
                    By.XPath("//*['@id='DataTables_Table_0']/tbody/tr[" + rowIndex + "]/td[" + colIndex + "]"));
                //element = WebDriver.GetElement(By.XPath("//*[@id='bulkProcessingDetails_Grid']/div/table/tbody/tr[" + rowIndex + "]/td[" + colIndex + "]"));
            }
            
            if (element != null)
            {
                elementText = element.GetText(WebDriver);
               
            }
            return elementText;
        }

        public string GetDetailsGridCellViewObjectButtonText(int rowIndex, int colIndex)
        {
            //Note: rowIndex is 0 based
            //return WebDriver.GetElement(By.XPath("//*[@id='" + DSA_ID_BUTTON_VIEW_OBJECT + "_" + rowIndex + "_']")).GetText(webDriver);
            return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_1']/tbody/tr[" + rowIndex + "]/td[" + colIndex + "]/a")).GetText(WebDriver);

        }

        public IWebElement GetDetailsGridCellViewObjectButton(int rowIndex, int colIndex)
        {
            //Note: rowIndex is 0 based
            //return WebDriver.GetElement(By.XPath("//*[@id='" + DSA_ID_BUTTON_VIEW_OBJECT + "_" + rowIndex + "_']"));
            return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_1']/tbody/tr[" + rowIndex + "]/td[" + colIndex + "]/a"));

        }

        public string GetDetailsViewObjectPopupTitleText(IWebDriver webDriver)
        {
            //Note: rowIndex is 0 based
            //return WebDriver.GetElement(By.XPath("//*[@id='" + DSA_ID_DISPLAY_VIEW_OBJECT + "']//h3")).GetText(webDriver);
            return WebDriver.GetElement(By.XPath("//*[@id='automationDetailsModal_viewObject']//h3")).GetText(webDriver);

        }

        public string GetDetailsViewObjectPopupPreText(IWebDriver webDriver)
        {
            //return WebDriver.GetElement(By.XPath("//*[@id='" + DSA_ID_DISPLAY_VIEW_OBJECT + "']//pre")).GetText(webDriver);
            return WebDriver.GetElement(By.XPath("//*[@id='automationDetailsModal_viewObject']//pre")).GetText(webDriver);
        }

        public IWebElement GetDetailsViewObjectPopupCloseButton(IWebDriver webDriver)
        {
            //return WebDriver.GetElement(By.XPath("//*[@id='" + DSA_ID_DISPLAY_VIEW_OBJECT + "']//a"));
            return WebDriver.GetElement(By.XPath("//*[@id='automationDetailsModal_viewObject']//a"));
        }

        public IWebElement GetDownloadOptionsDropdownMenu()
        {
            //return WebDriver.GetElement(By.XPath("//" + DSA_TAG_APP_DETAILS + "//button/following-sibling::ul"));
            return WebDriver.GetElement(By.XPath("//div[@class='btn-group open']//ul"));
        }

        public string GetDownloadOptionsDropdownOption(int index)
        {
            //return WebDriver.GetElements(By.XPath("//" + DSA_TAG_APP_DETAILS + "//a[@class='dropdown-item']"))[index].GetText(webDriver);

            return WebDriver.GetElement(By.XPath("//div[@class='btn-group open']//ul/li["+ index +"]/a")).GetText(WebDriver);

        }

        public IWebElement GetDetailsPaginationPageNumberLink(int index)
        {
            //Note:index is 1 based
            return WebDriver.GetElement(By.XPath("//*[@id='" + DSA_ID_WORK_ITEMS_GRID_PAGINATION + "']/ul[" + index + "]/li/a"));
        }

        public IWebElement GetStatusPaginationNavArrow(int index)
        {
            //return WebDriver.GetElement(By.XPath("//*[@id='" + DSA_ID_STATUS_GRID_PAGINATION + "']/span[" + index + "]"));

            if (index == 1)
            {
                return WebDriver.GetElement(By.XPath("//*[@id='gridPagination_prev']"));
            } else
            {
                return WebDriver.GetElement(By.XPath("//*[@id='gridPagination_next']"));

            }

        }

        public List<IWebElement> GetStatusGridPaginationPageLinks()
        {
            //return WebDriver.GetElements(By.XPath("//*[@id='" + DSA_ID_STATUS_GRID_PAGINATION + "']/ul"));
            return WebDriver.GetElements(By.XPath("//*[@id='bulkProcessingStatus_Grid_pagination']/ul/li"));

        }

        public IWebElement GetStatusGridPaginationPageLink(int index)
        {
            //return WebDriver.GetElement(By.XPath("//*[@id='" + DSA_ID_STATUS_GRID_PAGINATION + "']/ul[" + index + "]"));
            return WebDriver.GetElement(By.XPath("//*[@id='bulkProcessingStatus_Grid_pagination']/ul/li[" + index + "]/a"));
        }

        public IWebElement GetBtnFilter()
        {
            return WebDriver.GetElement(By.XPath("//button[@id='automationStatus_viewStatus' and @class='btn btn-success']"));
        }

        public IWebElement GetBtnViewStatusAddNew()
        {
            return WebDriver.GetElement(By.XPath("//button[@id='automationStatus_viewStatus' and @class='btn btn-default top-offset-10']"));
        }

        public IWebElement GetJobIdTitle()
        {
            return WebDriver.GetElement(By.XPath("//*[@id='main']/h5"));
        }

        public void VerifyStatusGridPopulated()
        {
            //verify that the status grid has been populated
            bool statusGridPopulated = false;
            if (GetStatusGridRowCount() > 0)
            {
                statusGridPopulated = true;
            }
            Assert.AreEqual(statusGridPopulated, true);

        }

        public void VerifyWorkItemDetailsGridPopulated()
        { 
            //Verify that we have a populated details work items Grid
            bool detailsWorkItemsGridPopulated = false;
            if (GetDetailsWorkItemsGridRowCount() > 0)
            {
                detailsWorkItemsGridPopulated = true;
            }
            Assert.AreEqual(detailsWorkItemsGridPopulated, true);
        }



        public void VerifyDateAddedFormat(string dateAdded)
        {
            VerifyDateFormat(dateAdded, "MMMM d, yyyy");
        }
        public void VerifyDateUpdatedFormat(string dateUpdated)
        {
            VerifyDateFormat(dateUpdated, "MMMM d, yyyy hh:mm:ss tt");
        }


        public void VerifyDateFormat(string date, string format)
        {
            try
            {
                DateTime.ParseExact(date, format, null);
            }
            catch (FormatException e)
            {
                Assert.Fail("Invalid date format!");
            }
        }

    }

    #endregion

}
