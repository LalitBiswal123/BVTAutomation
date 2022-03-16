//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Dsa.Pages.POM
{
    public class WorkgroupSummary : DsaPageBase
    {
        public static TimeSpan GlobalWaitTime = TimeSpan.FromSeconds(120);
        public WorkgroupSummary(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "WorkGroup Summary";
            PageFactory.InitElements(webDriver, this);
            webDriver.VerifyBusyOverlayNotDisplayed();
        }

        #region Workgroup Summary Screen


public IWebElement BacklogTab { get { return WebDriver.GetElement(By.XPath("//*[@id='backlog_tab']")); } }


public IWebElement WorkingTab { get { return WebDriver.GetElement(By.XPath("//*[@id='working_tab']")); } }


public IWebElement SuspendedTab { get { return WebDriver.GetElement(By.XPath("//*[@id='suspended_tab']")); } }


public IWebElement CompletedTab { get { return WebDriver.GetElement(By.XPath("//*[@id='completed_tab']")); } }


public IWebElement ViewAllTab { get { return WebDriver.GetElement(By.XPath("//*[@id='view_all_tab']")); } }


public IWebElement ShowWorkgroups { get { return WebDriver.GetElement(By.XPath("//*[@class='btn-group']/a[@class='k-icon k-i-arrow-s']")); } }


public IWebElement WorkgroupCheckbox { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/thead/tr[1]/th[1]/input")); } }


public IWebElement HideWorkgroups { get { return WebDriver.GetElement(By.XPath("//*[@class='btn-group']/a[@class='k-icon k-i-arrow-n']")); } }


public IWebElement BtnViewPomRecords { get { return WebDriver.GetElement(By.XPath("//*[@id='pomRecords']")); } }

public IWebElement Agefilter { get { return WebDriver.GetElement(By.XPath("//*[@id='pomSearch_DataReceived']")); } }
        //[FindsBy(How = How.XPath, Using = "//*[@class='floatRight mg-top-10']")]
        //public IWebElement LnkGoToMyQueue;


public IWebElement LnkGoToMyQueue { get { return WebDriver.GetElement(By.XPath("//div[@class='content-area container top-offset-10']/div/div/div/a")); } }


public IWebElement DrpdwnDateReceived { get { return WebDriver.GetElement(By.XPath("//*[@id='pomSearch_DataReceived']")); } }


public IWebElement DateReceivedViewAll { get { return WebDriver.GetElement(By.XPath("//*[@id='pomSearch_DataReceived']/option[6]")); } }


public IWebElement DrpdwnAgeFilter { get { return WebDriver.GetElement(By.XPath("//*[@class='dsa-width-to-allow-validation-icon ng-untouched ng-pristine ng-valid']")); } }


public IWebElement AgeFilterAll { get { return WebDriver.GetElement(By.XPath("//*[@class='dsa-width-to-allow-validation-icon ng-untouched ng-pristine ng-valid']/option[1]")); } }


public IWebElement TblWorkgrpList { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']")); } }


public IWebElement ChkFirstWorkgrp { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/descendant::tr[2]/td[1]/input[@type='checkbox']")); } }


public IWebElement ChkSecondWorkgrp { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/descendant::tr[3]/td[1]/input[@type='checkbox']")); } }


public IWebElement LblFirstWorkgrpName { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/descendant::tr[2]/td[2]")); } }


public IWebElement LblSecondWorkgrpName { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/descendant::tr[3]/td[2]")); } }


public IWebElement BacklogFrstRowCount { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/descendant::tr[2]/td[3]")); } }


public IWebElement BacklogSecndRowCount { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/descendant::tr[3]/td[3]")); } }


public IWebElement HdrWgDetailsPomCount { get { return WebDriver.GetElement(By.XPath("//*[@class='accordion-group']/div/workgroupdetails/div/h3")); } }


public IWebElement WorkingFrstRowCount { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/descendant::tr[2]/td[4]")); } }


public IWebElement WorkingScndRowCount { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/descendant::tr[3]/td[4]")); } }


public IWebElement SuspendedFrstRowCount { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/descendant::tr[2]/td[5]")); } }


public IWebElement SuspendedScndRowCount { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/descendant::tr[3]/td[5]")); } }


public IWebElement CompletedFrstRowCount { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/descendant::tr[2]/td[6]")); } }


public IWebElement CompletedScndRowCount { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/descendant::tr[3]/td[6]")); } }


public IWebElement PomIdCount { get { return WebDriver.GetElement(By.XPath("//*[@class='content-view']/following-sibling::div/workgroupdetails/div/h3")); } }

        //[FindsBy(How = How.XPath, Using = "//*[@class='btn-group']/a")]
        //public IWebElement ShowWorkgroups;


public IWebElement TblPomResultsGrid { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_WgDetailsGrid']")); } }


public IWebElement PomDateReceived { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/descendant::tr[3]/td[7]/add-component/wg-details-date-format/div")); } }


public IWebElement WgPomIdLink { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_WgDetailsGrid']/tbody/tr/td[3]/add-component/pom-id-link/a")); } }


public IWebElement WgPomIdDateReceived { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_WgDetailsGrid']/tbody/tr/td[7]/add-component/wg-details-date-format/div")); } }


public IWebElement WgViewPoLink { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_WgDetailsGrid']/tbody/tr/td[5]/add-component/pom-doc-link/a")); } }

public IWebElement WorkGroupFromTo { get { return WebDriver.GetElement(By.Id("MyWorkgroupGrid_fromto")); } }
public IWebElement WGPagination { get { return WebDriver.GetElement(By.Id("MyWorkgroupGrid_partyGrid_pagination")); } }
public IWebElement WGDisplayPerPage { get { return WebDriver.GetElement(By.Id("MyWorkgroupGrid_grid_paging_itemsPerPage;")); } }

public IWebElement WorkGroupDetailsFromTo { get { return WebDriver.GetElement(By.Id("WgDetailsGrid_fromto")); } }

public IWebElement WGDetailsPagination { get { return WebDriver.GetElement(By.Id("WgDetailsGrid_partyGrid_pagination")); } }

public IWebElement DisplayPerPage { get { return WebDriver.GetElement(By.Id("WgDetailsGrid_grid_paging_itemsPerPage;")); } }

public IWebElement WGSelectAllCheckbox { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'MyWorkgroupGrid')]//th/input[@type='checkbox']")); } }

public IWebElement AlertInfo { get { return WebDriver.GetElement(By.XPath("//label[contains(@class,'alert-info')]")); } }
public IWebElement PageText { get { return WebDriver.GetElement(By.XPath("//*[@id='pomworkflow_title']")); } }
public IWebElement PomView { get { return WebDriver.GetElement(By.XPath("//*[@id='workgroupBacklogSearch']/div/div[2]/form/div[1]/div/div/div[1]/div")); } }
public IWebElement AgeFilterDropdown { get { return WebDriver.GetElement(By.XPath("//select[@id='pomSearch_DataReceived']")); } }
public IWebElement NoItemsInList { get { return WebDriver.GetElement(By.XPath("//table[contains(@id,'MyWorkgroupGrid')]//tbody/tr[1]/td")); } }
public IWebElement BulkactionDropdown { get { return WebDriver.GetElement(By.XPath("//select[@id='pomSearch_BulkAction']")); } }
public IWebElement SelectAllCheckbox { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'WgDetailsGrid')]//th/input[@type='checkbox']")); } }
public IWebElement BtnApply { get { return WebDriver.GetElement(By.Id("pomSearch_ApplyButton")); } }

public IWebElement EnterComment { get { return WebDriver.GetElement(By.Id("pom_wrk_itm_comment")); } }
public IWebElement AddCommentHeader { get { return WebDriver.GetElement(By.Id("AddComments_work_item_header")); } }
public IWebElement SaveChangesForComment { get { return WebDriver.GetElement(By.Id("AddComments_ok")); } }
public IWebElement CancelForComment { get { return WebDriver.GetElement(By.Id("AddComments_cancel")); } }

public IWebElement CancelBtnForExpedite { get { return WebDriver.GetElement(By.Id("Expedite_cancel")); } }
public IWebElement SaveBtnForExpedite { get { return WebDriver.GetElement(By.Id("Expedite_ok")); } }
public IWebElement ExpediteHeader { get { return WebDriver.GetElement(By.Id("Expedite_work_item_header")); } }
public IWebElement LnkOffCanvasBack { get { return WebDriver.GetElement(By.XPath("//a[contains(@class,'offCanvasBackLink')]")); } }
public IWebElement CancelReason { get { return WebDriver.GetElement(By.Id("pom_wrk_itm_reason")); } }

public IWebElement CancelBtnForReAssign { get { return WebDriver.GetElement(By.Id("ReAssign_cancel")); } }
public IWebElement SaveBtnForReAssign { get { return WebDriver.GetElement(By.Id("ReAssign_ok")); } }
public IWebElement ReAssignHeader { get { return WebDriver.GetElement(By.Id("ReAssign_work_item_header")); } }
public IWebElement ClickArrow { get { return WebDriver.GetElement(By.XPath("//div[@class='col-md-8']//i[@class='caret pull-right']")); } }
public IWebElement ExpCheckbox { get { return WebDriver.GetElement(By.Id("isExpediteItems")); } }
public IWebElement Exptext { get { return WebDriver.GetElement(By.XPath("//*[@for='isExpediteItems']")); } }
public IWebElement WGCheckbox { get { return WebDriver.GetElement(By.XPath("//input[@id='wg_assignType']")); } }
public IWebElement WGDropdown { get { return WebDriver.GetElement(By.XPath("//div[@class='col-md-8']//input[@type='text']")); } }
public IWebElement CancelBtnForCancel { get { return WebDriver.GetElement(By.Id("Cancel_cancel")); } }
public IWebElement SaveBtnForCancel { get { return WebDriver.GetElement(By.Id("Cancel_ok")); } }
public IWebElement CancelHeader { get { return WebDriver.GetElement(By.Id("Cancel_work_item_header")); } }
public IWebElement NoSortForTotal { get { return WebDriver.GetElement(By.XPath("//th[@class='no-sorting']/span")); } }
public IWebElement RightArrow { get { return WebDriver.GetElement(By.XPath("//span[contains(@class,'arrowright touchMe')]")); } }
public IWebElement LeftArrow { get { return WebDriver.GetElement(By.XPath("//span[contains(@class,'arrowleft touchMe')]")); } }
public IWebElement DisabledLeftArrow { get { return WebDriver.GetElement(By.XPath("//span[@class='disabled']//span[contains(@class,'arrowleft')]")); } }
public IWebElement DisabledRightArrow { get { return WebDriver.GetElement(By.XPath("//span[@class='disabled']//span[contains(@class,'arrowright')]")); } }
public IWebElement CurrentPageNum { get { return WebDriver.GetElement(By.XPath("//div[@class='noFx']")); } }
public IWebElement PomIdLink { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_WgDetailsGrid']/tbody/tr[1]/td[3]/add-component/pom-id-link/a")); } }
        #endregion

        public IList<IWebElement> GetPomDateRecColumn()
        {
            IList<IWebElement> WgDateRecResults = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_WgDetailsGrid']/tbody/tr/td[7]/add-component/wg-details-date-format/div"));
            return WgDateRecResults;
        }

        public IList<IWebElement> WgGetPomId_ViewLink_Column()
        {
            IList<IWebElement> WgDateRecResults = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_WgDetailsGrid']/tbody/tr/td[3]/add-component/pom-id-link/a"));
            return WgDateRecResults;
        }
        public IList<IWebElement> WgGetPoDoc_ViewLink_Column()
        {
            IList<IWebElement> WgDateRecResults = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_WgDetailsGrid']/tbody/tr/td[3]/add-component/pom-id-link/a"));
            return WgDateRecResults;
        }

        public IList<IWebElement> WgGetBacklog_Column()
        {
            IList<IWebElement> WgDateRecResults = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/tbody/tr/td[3]"));
            return WgDateRecResults;
        }

        public IList<IWebElement> WgGetWorking_Column()
        {
            IList<IWebElement> WgDateRecResults = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/tbody/tr/td[4]"));
            return WgDateRecResults;
        }

        public IList<IWebElement> WgGetSuspended_Column()
        {
            IList<IWebElement> WgDateRecResults = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/tbody/tr/td[5]"));
            return WgDateRecResults;
        }

        #region WG Summary methods
        public string GetViewPOMRecordsToolTipText()
        {
            Actions builder = new Actions(WebDriver);

            builder.ClickAndHold().MoveToElement(BtnViewPomRecords);
            builder.MoveToElement(BtnViewPomRecords).Build().Perform();

            IWebElement toolTipElement = WebDriver.FindElement(By.XPath("//button[@id='pomRecords']//following::div[@class='popover-content']"));
            return toolTipElement.GetText(WebDriver);
        }

        public string SelectAWorkGroupDisplayed(string backlogCount, string tabName)
        {
            if (WebDriver.FindElements(By.XPath("//tbody/tr")).Count() > 0)
            {
                WebDriver.FindElement(By.XPath("//tbody/tr/td[1]/input[@type='checkbox']")).Click(WebDriver);
                if (tabName == "Backlog")
                {
                    backlogCount = WebDriver.FindElement(By.XPath("//tbody/tr[1]/td[3]")).GetText(WebDriver);
                }
                else if (tabName == "Working")
                {
                    backlogCount = WebDriver.FindElement(By.XPath("//tbody/tr[1]/td[4]")).GetText(WebDriver);
                }
                else if (tabName == "Suspended")
                {
                    backlogCount = WebDriver.FindElement(By.XPath("//tbody/tr[1]/td[5]")).GetText(WebDriver);
                }
                else if (tabName == "Completed")
                {
                    backlogCount = WebDriver.FindElement(By.XPath("//tbody/tr[1]/td[6]")).GetText(WebDriver);
                }
                else if (tabName == "View All")
                {
                    backlogCount = WebDriver.FindElement(By.XPath("//tbody/tr[1]/td[7]")).GetText(WebDriver);
                }
            }
            else
            {
                Assert.Fail("no workgroups are displayed on Work group summary page");
            }

            return backlogCount;
        }

        public List<string> VerifyIfListOfWorkGroupsDisplayedFrmAtoZ(List<string> wgList)
        {
            int i = WebDriver.FindElements(By.XPath("//tr/td[2]")).Count();
            for (int j = 1; j <= i; j++)
            {
                wgList.Add(WebDriver.FindElement(By.XPath("//tr[" + j + "]/td[2]")).GetText(WebDriver));               
            }

            var sorted = new List<string>();
            sorted.AddRange(wgList.OrderBy(o => o));
            Assert.IsTrue(wgList.SequenceEqual(sorted));

            return wgList;
        }

        public string ClickOnTabWithRecordsMoreThanMax(string tabName)
        {
            string[] backlog = BacklogTab.GetText(WebDriver).Replace("(", string.Empty).Replace(")", string.Empty).Split(' ');
            int backlogCount = Convert.ToInt32(backlog[1]);
            string[] working = WorkingTab.GetText(WebDriver).Replace("(", string.Empty).Replace(")", string.Empty).Split(' ');
            int workingCount = Convert.ToInt32(working[1]);
            string[] suspended = SuspendedTab.GetText(WebDriver).Replace("(", string.Empty).Replace(")", string.Empty).Split(' ');
            int suspendedCount = Convert.ToInt32(suspended[1]);
            string[] complete = CompletedTab.GetText(WebDriver).Replace("(", string.Empty).Replace(")", string.Empty).Split(' ');
            int completeCount = Convert.ToInt32(complete[1]);
            string[] viewAll = ViewAllTab.GetText(WebDriver).Replace("(", string.Empty).Replace(")", string.Empty).Split(' ');
            int viewAllCount = Convert.ToInt32(complete[1]);

            if (backlogCount > 500)
            {
                new WorkgroupSummary(WebDriver).BacklogTab.Click(WebDriver);
                tabName = backlog[0];
            }
            else if (workingCount > 500)
            {
                new WorkgroupSummary(WebDriver).WorkingTab.Click(WebDriver);
                tabName = working[0];
            }
            else if (suspendedCount > 500)
            {
                new WorkgroupSummary(WebDriver).SuspendedTab.Click(WebDriver);
                tabName = suspended[0];
            }
            else if (completeCount > 500)
            {
                new WorkgroupSummary(WebDriver).CompletedTab.Click(WebDriver);
                tabName = complete[0];
            }
            else if (viewAllCount > 500)
            {
                new WorkgroupSummary(WebDriver).ViewAllTab.Click(WebDriver);
                tabName = viewAll[0];
            }

            return tabName;
        }
        #endregion

        #region AgeFilter Methods
        public List<string> GetDateReceivedValuesFromWGDetailsGrid(List<string> dateReceived)
        {
            string[] dateValues;
            int rows = TblPomResultsGrid.FindElements(By.XPath("//*[@id='DataTables_Table_WgDetailsGrid']/tbody/tr")).Count();

            for(int j = 1; j <= rows; j ++)
            {
                dateValues = WebDriver.FindElement(By.XPath("//tr[" + j + "]/td//wg-details-date-format/div")).GetText(WebDriver).Split(' ');
                dateReceived.Add(dateValues[0]);
            }

            return dateReceived;
        }

        public void CompareDateReceivedWithSelectedAgeFilter(List<string> dateReceived, string oneWeekDate)
        {
            for (int i = 0; i < dateReceived.Count(); i++)
            {
                if (Convert.ToDateTime(dateReceived[i]) >= Convert.ToDateTime(oneWeekDate))
                {
                    Logger.Write("Date value displayed is in sync with Age Filter selection");
                }
                else
                {
                    Assert.Fail("Date value displayed is not in sync with Age Filter selection");
                }
            }
        }

        public void CompareDateReceivedWithSelectedAgeFilters(List<string> dateReceived, string btwDate, string btwDate1)
        {
            for (int i = 0; i < dateReceived.Count(); i++)
            {
                if (Convert.ToDateTime(dateReceived[i]) >= Convert.ToDateTime(btwDate) || Convert.ToDateTime(dateReceived[i]) <= Convert.ToDateTime(btwDate))
                {
                    Logger.Write("Date value displayed is in sync with Age Filter selection");
                }
                else
                {
                    Assert.Fail("Date value displayed is not in sync with Age Filter selection");
                }
            }
        }
        public void CompareDateReceivedWithSelectAgeFilter(List<string> dateReceived, string oneWeekDate)
        {
            for (int i = 0; i < dateReceived.Count(); i++)
            {
                if (Convert.ToDateTime(dateReceived[i]) <= Convert.ToDateTime(oneWeekDate))
                {
                    Logger.Write("Date value displayed is in sync with Age Filter selection");
                }
                else
                {
                    Assert.Fail("Date value displayed is not in sync with Age Filter selection");
                }
            }
        }
        public void WaitUntilTableValuesDisplay(IWebDriver driver, TimeSpan? waitTime = null)
        {
            By inlineBusy = By.XPath("//span[@class='inline-busy-block']");
      
            if (waitTime == null)
                waitTime = GlobalWaitTime; // If no Wait time set from the page class, then use the default.

            WebDriverWait wait = new WebDriverWait(driver, waitTime.Value); 
            try
            {
                if (WebDriver.ElementExists(inlineBusy))
                {                   
                    wait.Until(ExpectedConditions.InvisibilityOfElementLocated(inlineBusy));
                }               
            }
            catch (Exception e)
            {
                Logger.Write(e.Message);
            }
        }

        public void ClickOnAllTabs(string value)
        {
            WebDriver.FindElement(By.XPath("//a[@id='" + value + "_tab']")).Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
        }

        public int GetNumOfRows()
        {
            int i = WebDriver.FindElements(By.XPath("//*[contains(@id,'MyWorkgroupGrid')]//tbody/tr")).Count();
            return i;
        }
        #endregion

        #region Bulk Action Methods
        public void OpenNewTab(string baseUrl)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            js.ExecuteScript("window.open();");
            WebDriver.SwitchTo().Window(WebDriver.WindowHandles.Last());
            WebDriver.Url = baseUrl;
        }
        public List<string> GetPOMIdsForBulkActions(List<string> pomIds)
        {
            WebDriver.WaitForBusyOverlay();
            for (int i = 1; i <= 2; i++)
            {
                WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_WgDetailsGrid']//tbody/tr[" + i + "]//input[@type='checkbox']")).Click(WebDriver);
                pomIds.Add(WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_WgDetailsGrid']//tbody/tr[" + i + "]/td[3]//pom-id-link/a")).GetText(WebDriver));
            }
            return pomIds;
        }

        public void VerifyPOMIdInActionPopup(List<string> pomIds)
        {
            for (int j = 1; j <= 2; j++)
            {
                Assert.IsTrue(WebDriver.FindElement(By.XPath("//div[@class='row prow'][" + j + "]/div[2]")).GetText(WebDriver).Contains(pomIds[j - 1]));
                Assert.IsTrue(WebDriver.FindElement(By.XPath("//div[@class='row prow'][" + j + "]//input[@type='checkbox']")).Selected);
            }
        }

        public void SelectWG(string value)
        {
            WGDropdown.SetText(WebDriver, value);
            WGDropdown.SendKeys(Keys.Enter);
        }

        public void VerifyWorkGroupsInActionPopup(List<string> pomIDWorkGroups)
        {
            for (int j = 1; j <= 2; j++)
            {
                Assert.IsTrue(WebDriver.FindElement(By.XPath("//div[@class='row prow'][" + j + "]/div[3]")).GetText(WebDriver).Contains(pomIDWorkGroups[j - 1]));
            }
        }

        public List<string> GetSelectedPOMIdWorkGroups(List<string> pomIDWorkGroups)
        {
            for (int i = 1; i <= 2; i++)
            {
                pomIDWorkGroups.Add(WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]/td[13]")).GetText(WebDriver));
            }
            return pomIDWorkGroups;
        }

        public void SelectRequiredWorkGroups(string workGroups)
        {
            int rows = GetNumOfRows();
            for (int i = 1; i <= rows; i++)
            {
                string wg = WebDriver.FindElement(By.XPath("//*[contains(@id,'MyWorkgroupGrid')]//tr[" + i + "]//td[2]")).GetText(WebDriver);
                if (wg.Contains(workGroups) || wg.Contains("IT_ROBOTIX_TEST"))
                {
                    WebDriver.FindElement(By.XPath("//*[contains(@id,'MyWorkgroupGrid')]//tr[" + i + "]//td[2]//preceding-sibling::td/input")).Click(WebDriver);
                    break;
                }                
            }
        }
        #endregion

        #region Work Groups Grid Methods
        public List<string> GetAllWGgridColumnValues(List<string> columnsValues)
        {
            int i = WebDriver.FindElements(By.XPath("//th")).Count;

            for (int j = 1; j <= i; j++)
            {
                columnsValues.Add(WebDriver.FindElement(By.XPath("//th[" + j + "]/span")).GetText(WebDriver));
            }
            return columnsValues;
        }
        public IWebElement SortWGTableGridBy(int column)
        {
            var headerlnk = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/thead/tr/th[" + column + "]/span"));
            if (headerlnk == null)
                throw new NoSuchElementException(string.Format("Column header {0} is not found", column));
            return headerlnk;
        }       

        public bool IsColumnSortedAscending(int index)
        {
            string result = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/thead/tr/th[" + index + "]/span/span")).GetAttribute("class");
            if (result == "sorting_asc")
                return true;
            else return false;
        }

        public bool IsColumnSortedDescending(int index)
        {
            string result = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']/thead/tr/th[" + index + "]/span/span")).GetAttribute("class");
            if (result == "sorting_desc")
                return true;
            else return false;
        }
        public List<IWebElement> PageResultsByColumns()
        {
            try
            {
                var table = WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_MyWorkgroupGrid']"));
                List<IWebElement> headingTable = new List<IWebElement>(table.FindElements(By.TagName("th")));
                return headingTable;
            }
            catch (NoSuchElementException e)
            {
                throw;
            }
        }

        public int GetRecordValue(int i)
        {
           string s =  WebDriver.FindElement(By.XPath("//tbody/tr/td[" + i + "]")).GetText(WebDriver);
           int j = Convert.ToInt32(s);
           return j;
        }       

        public void ClickOnLastPageNum()
        {
            var v1 = WebDriver.FindElements(By.XPath("//div[contains(@class,'touchMe')]"));
            int i = v1.Count;
            int j = i + 1;

            Logger.Write("Clicking on Last Page number " + WebDriver.FindElement(By.XPath("//ul[" + j + "]//div[contains(@class,'touchMe')]")).GetText(WebDriver));
            WebDriver.FindElement(By.XPath("//ul[" + j + "]//div[contains(@class,'touchMe')]")).Click(WebDriver);
        }

        public void ClickOnRandomPageNum(string pageNum)
        {
            Logger.Write("Clicking on Page number " + pageNum);
            WebDriver.FindElement(By.XPath("//ul[" + pageNum + "]//div[contains(@class,'touchMe')]")).Click(WebDriver);
        }

        public List<string> GetWGnames(List<string> wgValues)
        {
            int count = GetNumOfRows();
            for (int i = 1; i <= count; i++)
            {
                wgValues.Add(WebDriver.FindElement(By.XPath("//*[contains(@id,'MyWorkgroupGrid')]/tbody/tr[" + i + "]/td[2]")).GetText(WebDriver));
            }
            return wgValues;
        }

        public void GetPOMidPoTotalValuesFromSusTab(ref List<string> pomId, ref List<string> poTotal)
        {
            int j = WebDriver.FindElements(By.XPath("//*[contains(@id,'WgDetailsGrid')]//tbody/tr")).Count();

            for (int i = 1; i <= j; i++)
            {
                if (WebDriver.FindElement(By.XPath("//*[contains(@id,'WgDetailsGrid')]/tbody//tr[" + i + "]/td[14]")).GetText(WebDriver).Contains("Sales Hold"))
                {
                    pomId.Add(WebDriver.FindElement(By.XPath("//*[contains(@id,'WgDetailsGrid')]/tbody//tr[" + i + "]/td[3]//pom-id-link/a")).GetText(WebDriver));
                    poTotal.Add(WebDriver.FindElement(By.XPath("//*[contains(@id,'WgDetailsGrid')]/tbody//tr[" + i + "]/td[10]")).GetText(WebDriver));
                }
                else
                {
                    Logger.Write("Pom id is not eligible to be displayed on Suspended Purchase Orders section on Home Page");
                }
            }
        }
        #endregion

        
    }
}
