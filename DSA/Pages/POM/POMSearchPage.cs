using Dsa.Utils;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.IO;

namespace Dsa.Pages.POM
{
    public class PomSearchPage : DsaPageBase
    {
        public PomSearchPage(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "POM Search Page";
            PageFactory.InitElements(webDriver, this);
            webDriver.VerifyBusyOverlayNotDisplayed();
        }


        #region POM Search


public IWebElement SearchPomnumber { get { return WebDriver.GetElement(By.Id("pomSearch_pomNumber")); } }


public IWebElement SearchPomid { get { return WebDriver.GetElement(By.Id("pomSearch_pomIdNumber")); } }


public IWebElement SearchPomCustomer { get { return WebDriver.GetElement(By.Id("pomSearch_customerNumber")); } }


public IWebElement PomStatus { get { return WebDriver.GetElement(By.XPath("//div//Select[@id='pomSearch_Status']")); } }


public IWebElement PomDateReceived { get { return WebDriver.GetElement(By.XPath("//div//Select[@id='pomSearch_DataReceived']")); } }


public IWebElement PomSource { get { return WebDriver.GetElement(By.Id("pomSearch_Source")); } }


public IWebElement PomSourceEmail { get { return WebDriver.GetElement(By.XPath("//select[@id='pomSearch_Source']")); } }


public IWebElement PomSalesRep { get { return WebDriver.GetElement(By.Id("pomSearch_salesRepId")); } }


public IWebElement PomSearchOp { get { return WebDriver.GetElement(By.Id("pomSearch_opName")); } }


public IWebElement PomBadgename { get { return WebDriver.GetElement(By.Id("pomSearch_opBadgeName")); } }


public IWebElement PomWorkGroupSelect { get { return WebDriver.GetElement(By.XPath("//*[@class='btn-secondary form-control form-control-dropdown ui-select-toggle']")); } }


public IWebElement PomWorkGroupDefaultText { get { return WebDriver.GetElement(By.XPath("//*[@class='btn-secondary form-control form-control-dropdown ui-select-toggle']/span")); } }


public IWebElement PomIdLink { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomSearchResultsGrid']/tbody/tr/td[3]/add-component/pom-id-link/a")); } }


public IWebElement ViewPoLink { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomSearchResultsGrid']/tbody/tr/td[5]/add-component/pom-doc-link/a")); } }


public IWebElement PomWorkGroup { get { return WebDriver.GetElement(By.XPath("//*[@class='form-control ui-select-search']")); } }


public IWebElement PomSearch { get { return WebDriver.GetElement(By.Id("pomSearch_searchAction")); } }


public IWebElement PomClearSearch { get { return WebDriver.GetElement(By.Id("pomSearch_clearAction")); } }


public IWebElement POMSearchTableRow { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomSearchResultsGrid']/tbody/tr/td")); } }


public IWebElement ShowFilters { get { return WebDriver.GetElement(By.XPath("//*[@class='k-icon k-i-arrow-s']")); } }


public IWebElement HideFilters { get { return WebDriver.GetElement(By.XPath("//*[@class='k-icon k-i-arrow-n']")); } }


public IWebElement PomIdSearchResultsGrid { get { return WebDriver.GetElement(By.XPath("//table[@id='DataTables_Table_PomSearchResultsGrid']/descendant::tr[2]/td[3]/add-component/pom-id-link/a")); } }


public IWebElement PomSearchResultsGrid { get { return WebDriver.GetElement(By.XPath("//table[@id='DataTables_Table_PomSearchResultsGrid']")); } }

public IWebElement ResultPOMid { get { return WebDriver.GetElement(By.XPath("//tr[1]//td[3]//a")); } }

public IWebElement ResultPONumber { get { return WebDriver.GetElement(By.XPath("//tr[1]//td[4]//div")); } }

public IWebElement ResultPOMStatus { get { return WebDriver.GetElement(By.XPath("//tr[1]//td[14]")); } }

public IWebElement ExpediteFlag { get { return WebDriver.GetElement(By.XPath("//i[@class='glyphicon glyphicon-flag']")); } }

public IWebElement Status { get { return WebDriver.GetElement(By.XPath("//td[14]")); } }
public IWebElement WorkGroup { get { return WebDriver.GetElement(By.XPath("//td[13]")); } }
public IWebElement User { get { return WebDriver.GetElement(By.XPath("//td[11]")); } }
public IWebElement BulkActionDropdown { get { return WebDriver.GetElement(By.XPath("//select[@id='pomSearch_BulkAction']")); } }

public IWebElement EnterComment { get { return WebDriver.GetElement(By.Id("pom_wrk_itm_comment")); } }
public IWebElement AddCommentHeader { get { return WebDriver.GetElement(By.Id("AddComments_work_item_header")); } }
public IWebElement SaveChangesForComment { get { return WebDriver.GetElement(By.Id("AddComments_ok")); } }
public IWebElement CancelForComment { get { return WebDriver.GetElement(By.Id("AddComments_cancel")); } }

public IWebElement CancelReason { get { return WebDriver.GetElement(By.Id("pom_wrk_itm_reason")); } }
public IWebElement CancelBtnForCancel { get { return WebDriver.GetElement(By.Id("Cancel_cancel")); } }
public IWebElement SaveBtnForCancel { get { return WebDriver.GetElement(By.Id("Cancel_ok")); } }
public IWebElement CancelHeader { get { return WebDriver.GetElement(By.Id("Cancel_work_item_header")); } }

public IWebElement CancelBtnForReAssign { get { return WebDriver.GetElement(By.Id("ReAssign_cancel")); } }
public IWebElement SaveBtnForReAssign { get { return WebDriver.GetElement(By.Id("ReAssign_ok")); } }
public IWebElement ReAssignHeader { get { return WebDriver.GetElement(By.Id("ReAssign_work_item_header")); } }

public IWebElement CancelBtnForExpedite { get { return WebDriver.GetElement(By.Id("Expedite_cancel")); } }
public IWebElement SaveBtnForExpedite { get { return WebDriver.GetElement(By.Id("Expedite_ok")); } }
public IWebElement ExpediteHeader { get { return WebDriver.GetElement(By.Id("Expedite_work_item_header")); } }
public IWebElement LnkOffCanvasBack { get { return WebDriver.GetElement(By.XPath("//a[contains(@class,'offCanvasBackLink')]")); } }

public IWebElement SelectAllCheckbox { get { return WebDriver.GetElement(By.XPath("//th/input[@type='checkbox']")); } }
public IWebElement BtnApply { get { return WebDriver.GetElement(By.Id("pomSearch_ApplyButton")); } }
public IWebElement ClickArrow { get { return WebDriver.GetElement(By.XPath("//div[@class='col-md-8']//i[@class='caret pull-right']")); } }
public IWebElement WGDropdown { get { return WebDriver.GetElement(By.XPath("//div[@class='col-md-8']//input[@type='text']")); } }

public IWebElement ExpCheckbox { get { return WebDriver.GetElement(By.Id("isExpediteItems")); } }
public IWebElement Exptext { get { return WebDriver.GetElement(By.XPath("//*[@for='isExpediteItems']")); } }
public IWebElement WGCheckbox { get { return WebDriver.GetElement(By.XPath("//input[@id='wg_assignType']")); } }
public IWebElement UserCheckbox { get { return WebDriver.GetElement(By.XPath("//input[@id='usr_assignType']")); } }
public IWebElement LnkGoToHomePage { get { return WebDriver.GetElement(By.Id("dellBrandLogo_goHomePage")); } }

public IWebElement DisplayPerPageDropdown { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'paging_itemsPerPage')]")); } }
public IWebElement PaginationFromTo { get { return WebDriver.GetElement(By.Id("PomSearchResultsGrid_fromto")); } }
public IWebElement RightArrow { get { return WebDriver.GetElement(By.XPath("//span[contains(@class,'arrowright touchMe')]")); } }
public IWebElement LeftArrow { get { return WebDriver.GetElement(By.XPath("//span[contains(@class,'arrowleft touchMe')]")); } }
public IWebElement DisabledLeftArrow { get { return WebDriver.GetElement(By.XPath("//span[@class='disabled']//span[contains(@class,'arrowleft')]")); } }
public IWebElement DisabledRightArrow { get { return WebDriver.GetElement(By.XPath("//span[@class='disabled']//span[contains(@class,'arrowright')]")); } }
public IWebElement CurrentPageNum { get { return WebDriver.GetElement(By.XPath("//div[@class='noFx']")); } }
public IWebElement InlineBusyBlock { get { return WebDriver.GetElement(By.XPath("//span[@class='inline-busy-block']")); } }
public IWebElement PoTotal { get { return WebDriver.GetElement(By.XPath("//tr[1]/td[10]")); } }
public IWebElement NoSortForPOMID { get { return WebDriver.GetElement(By.XPath("//th[@class='no-sorting'][2]/span")); } }
public IWebElement CalenderIcon { get { return WebDriver.GetElement(By.XPath("//span[@class='k-icon k-i-calendar']")); } }
public IWebElement ToDateCalenderIcon { get { return WebDriver.GetElement(By.XPath("//label[@for='pomSearch_ToDate']//following::span[@class='k-icon k-i-calendar']")); } }
public IWebElement DefaultToDate { get { return WebDriver.GetElement(By.XPath("//button[contains(@class,'active btn-default')]")); } }
public IWebElement AlertMesssage { get { return WebDriver.GetElement(By.XPath("//label[contains(@class,'alert-info')]")); } }
public IWebElement AgeHoursValue { get { return WebDriver.GetElement(By.XPath("//table[@id='DataTables_Table_PomSearchResultsGrid']/descendant::tr[2]/td[6]")); } }
public IWebElement PoTotalValue { get { return WebDriver.GetElement(By.XPath("//table[@id='DataTables_Table_PomSearchResultsGrid']/descendant::tr[2]/td[10]")); } }
public IWebElement PoNumberPOMID { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomSearchResultsGrid']/thead/tr/th[4]/span")); } }
public IWebElement OrderNumberPOMID { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomSearchResultsGrid']/thead/tr/th[9]/span")); } }
public IWebElement OrderNumberWorkGroup { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomSearchResultsGrid']/thead/tr/th[13]/span")); } }
public IWebElement POMIdWorkGroup { get { return WebDriver.GetElement(By.XPath("//tbody//tr[1]/td[13]")); } }
public IWebElement WorkGroupChoices { get { return WebDriver.GetElement(By.XPath("//ul[@class='ui-select-choices dropdown-menu']/li")); } }
public IWebElement NoRecordsMessage { get { return WebDriver.GetElement(By.XPath("//tr[1]/td")); } }
        #endregion

        public IList<IWebElement> PomSearchGetPomId_ViewLink_By_Index()
        {
            IList<IWebElement> WgDateRecResults = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_PomSearchResultsGrid']/tbody/tr/td[3]/add-component/pom-id-link/a"));
            return WgDateRecResults;
        }


        public IList<IWebElement> PomSearchGetPoDoc_ViewLink_By_Index()
        {
            IList<IWebElement> WgDateRecResults = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_PomSearchResultsGrid']/tbody/tr/td[5]/add-component/pom-doc-link/a"));
            return WgDateRecResults;
        }

        public string GetPomstatus()
        {
            return PomStatus.GetText(WebDriver);
        }

        public List<string> GetSelectedPOMIdsForCancel(List<string> pomIds)
        {
            for (int i = 1; i <= 5; i++)
            {
                WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]//input[@type='checkbox']")).Click(WebDriver);
                pomIds.Add(WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]/td[3]//pom-id-link/a")).GetText(WebDriver));
            }
            return pomIds;
        }

        public List<string> GetSelectedPOMIdsForExpedite(List<string> pomIds)
        {
            WebDriver.FindElement(By.XPath("//span[@class='icon-ui-arrowright touchMe']")).Click(WebDriver);
            WebDriver.WaitForBusyOverlay();
            for (int i = 6; i <= 10; i++)
            {
                WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]//input[@type='checkbox']")).Click(WebDriver);
                pomIds.Add(WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]/td[3]//pom-id-link/a")).GetText(WebDriver));
            }
            return pomIds;
        }

        public List<string> GetSelectedPOMIdsForAddComments(List<string> pomIds)
        {
            WebDriver.FindElement(By.XPath("//span[@class='icon-ui-arrowright touchMe']")).Click(WebDriver);
            WebDriver.WaitForBusyOverlay();
            for (int i = 1; i <= 5; i++)
            {
                WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]//input[@type='checkbox']")).Click(WebDriver);
                pomIds.Add(WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]/td[3]//pom-id-link/a")).GetText(WebDriver));
            }
            return pomIds;
        }

        public List<string> GetSelectedPOMIdsForReassignUser(List<string> pomIds)
        {
            WebDriver.FindElement(By.XPath("//span[@class='icon-ui-arrowright touchMe']")).Click(WebDriver);
            WebDriver.WaitForBusyOverlay();
            WebDriver.FindElement(By.XPath("//span[@class='icon-ui-arrowright touchMe']")).Click(WebDriver);
            WebDriver.WaitForBusyOverlay();
            for (int i = 1; i <= 5; i++)
            {
                WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]//input[@type='checkbox']")).Click(WebDriver);
                pomIds.Add(WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]/td[3]//pom-id-link/a")).GetText(WebDriver));
            }
            return pomIds;
        }

        public List<string> GetSelectedPOMIdsForReassignWG(List<string> pomIds)
        {
            for (int i = 6; i <= 10; i++)
            {
                WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]//input[@type='checkbox']")).Click(WebDriver);
                pomIds.Add(WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]/td[3]//pom-id-link/a")).GetText(WebDriver));
            }
            return pomIds;
        }

        public List<string> GetSelectedPOMIdWorkGroups(List<string> pomIDWorkGroups)
        {
            for (int i = 6; i <= 10; i++)
            {
                pomIDWorkGroups.Add(WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]/td[13]")).GetText(WebDriver));
            }
            return pomIDWorkGroups;
        }

        public void VerifyPOMIdInActionPopup(List<string> pomIds)
        {
            for (int j = 1; j <= 5; j++)
            {
                Assert.IsTrue(WebDriver.FindElement(By.XPath("//div[@class='row prow'][" + j + "]/div[2]")).GetText(WebDriver).Contains(pomIds[j - 1]));
                Assert.IsTrue(WebDriver.FindElement(By.XPath("//div[@class='row prow'][" + j + "]//input[@type='checkbox']")).Selected);
            }
        }

        public void VerifyWorkGroupsInActionPopup(List<string> pomIDWorkGroups)
        {
            for (int j = 1; j <= 5; j++)
            {
                Assert.IsTrue(WebDriver.FindElement(By.XPath("//div[@class='row prow'][" + j + "]/div[3]")).GetText(WebDriver).Contains(pomIDWorkGroups[j - 1]));
            }
        }

        public void VerifyExpediteFlags(List<string> pomIds)
        {
            WebDriver.FindElement(By.XPath("//span[@class='icon-ui-arrowright touchMe']")).Click(WebDriver);
            WebDriver.WaitForBusyOverlay();
            for (int k = 6; k <= 10; k++)
            {
                Assert.IsTrue(WebDriver.FindElement(By.XPath("//tr[" + k + "]/td[2]//i[@class='glyphicon glyphicon-flag']")).IsElementDisplayed(WebDriver));
            }
        }

        public void SelectWG(string value)
        {
            WGDropdown.SetText(WebDriver, value);
            WGDropdown.SendKeys(Keys.Enter);
        }

        public void ClickOnAnyClosedPOMid()
        {
            for (int k = 1; k <= 9; k++)
            {
                if (WebDriver.FindElement(By.XPath("//tr[" + k + "]/td[14]")).GetText(WebDriver) == "Closed")
                {
                    WebDriver.FindElement(By.XPath("//tbody/tr[" + k + "]/td[3]//pom-id-link/a")).Click(WebDriver);
                    break;
                }
            }
        }

        public string GetOPNameToolTipText()
        {
            IWebElement opName = WebDriver.FindElement(By.XPath("//label[@for='pomSearch_opName']/i"));
            Actions builder = new Actions(WebDriver);

            builder.ClickAndHold().MoveToElement(opName);
            builder.MoveToElement(opName).Build().Perform();

            IWebElement toolTipElement = WebDriver.FindElement(By.XPath("//label[@for='pomSearch_opName']//div[@class='popover-content']"));
            return toolTipElement.GetText(WebDriver);
        }

        public string GetWGToolTipText()
        {
            IWebElement workGroup = WebDriver.FindElement(By.XPath("//label[@for='pomSearch_Workgroup']/i"));
            Actions builder = new Actions(WebDriver);

            builder.ClickAndHold().MoveToElement(workGroup);
            builder.MoveToElement(workGroup).Build().Perform();

            IWebElement toolTipElement = WebDriver.FindElement(By.XPath("//label[@for='pomSearch_Workgroup']//div[@class='popover-content']"));
            return toolTipElement.GetText(WebDriver);
        }

        public string GetExpediteFlagToolTipText()
        {
            IWebElement expediteFlag = WebDriver.FindElement(By.XPath("//i[@class='glyphicon glyphicon-flag']"));
            Actions builder = new Actions(WebDriver);

            builder.ClickAndHold().MoveToElement(expediteFlag);
            builder.MoveToElement(expediteFlag).Build().Perform();

            IWebElement toolTipElement = WebDriver.FindElement(By.XPath("//i[@class='glyphicon glyphicon-flag']//following::div[@class='popover-content']"));
            return toolTipElement.GetText(WebDriver);
        }

        public string GetNumofRecordsDisplayed()
        {
            int i = WebDriver.FindElements(By.XPath("//tbody/tr")).Count;
            return i.ToString();
        }

        public bool VerifyInlineBusyBlockIsDisplayed()
        {
            By inlineBusy = By.XPath("//span[@class='inline-busy-block']");
            if (!(WebDriver.IsElementVisible(InlineBusyBlock)))
            {
                Logger.Write("Inline busy");
            }
            else
            {
                new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime).Until(ExpectedConditions.InvisibilityOfElementLocated(inlineBusy));
            }

            return true;
        }

        public void VerifyAllRowsHavePOMIds()
        {
            int i = WebDriver.FindElements(By.XPath("//tbody/tr")).Count;
            for (int j = 1; j < i; j++)
            {
                if (WebDriver.FindElement(By.XPath("//tbody/tr[" + j + "]/td[3]//a")).GetText(WebDriver) != string.Empty)
                {
                    Logger.Write("POM id link is displayed for row " + j);
                    break;
                }
                else
                {
                    Logger.Write("POM id link is not displayed for row " + j);
                }
            }
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

        public List<string> GetPOMidLinksRecords(List<string> pomIds)
        {
            int count = Convert.ToInt16(GetNumofRecordsDisplayed());
            for (int i = 1; i <= count; i++)
            {
                pomIds.Add(WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]/td[3]//pom-id-link/a")).GetText(WebDriver));
            }
            return pomIds;
        }

        public int GetTotalNumOfRecordsDisplayed()
        {
            string[] w1 = WebDriver.FindElement(By.Id("PomSearchResultsGrid_fromto")).GetText(WebDriver).Split(' ');
            return Convert.ToInt16(w1[2]);
        }

        public List<string> GetAllSearchGridColumnValues(List<string> columnsValues)
        {
            int i = WebDriver.FindElements(By.XPath("//th")).Count;

            for (int j = 3; j <= i; j++)
            {
                columnsValues.Add(WebDriver.FindElement(By.XPath("//th[" + j + "]/span")).GetText(WebDriver));
            }
            return columnsValues;
        }

        public List<string> GetPoNumberOfAllPOMids(List<string> columnsValues, int i)
        {
            for (int j = 1; j <= i; j++)
            {
                IWebElement poNumber = WebDriver.FindElement(By.XPath("//tr[" + j + "]/td[4]//div"));
                Actions builder = new Actions(WebDriver);

                builder.ClickAndHold().MoveToElement(poNumber);
                builder.MoveToElement(poNumber).Build().Perform();

                IWebElement poNumberHover = WebDriver.FindElement(By.XPath("//tr[" + j + "]/td[4]//div[@class='popover-content']"));
                columnsValues.Add(poNumberHover.GetText(WebDriver));
            }
            return columnsValues;
        }

        public int GetSearchResultsCount()
        {
            int i = WebDriver.GetElements(By.CssSelector("#DataTables_Table_PomSearchResultsGrid > tbody > tr")).Count;
            return i;
        }

        public List<string> GetOpNamesOfAllPOMids(List<string> columnsValues, int i)
        {
            for (int j = 1; j <= i; j++)
            {
                columnsValues.Add(WebDriver.FindElement(By.XPath("//tr[" + j + "]/td[11]")).GetText(WebDriver));
            }
            return columnsValues;
        }

        public List<string> GetWorkgroupOfAllPOMids(List<string> columnsValues, int i)
        {
            for (int j = 1; j <= i; j++)
            {
                columnsValues.Add(WebDriver.FindElement(By.XPath("//tr[" + j + "]/td[13]")).GetText(WebDriver));
            }
            return columnsValues;
        }

        public List<string> GetOrderNumberOfAllPOMids(List<string> columnsValues, int i)
        {
            for (int j = 1; j <= i; j++)
            {
                IWebElement poNumber = WebDriver.FindElement(By.XPath("//tr[" + j + "]/td[9]//div"));
                Actions builder = new Actions(WebDriver);

                builder.ClickAndHold().MoveToElement(poNumber);
                builder.MoveToElement(poNumber).Build().Perform();

                IWebElement poNumberHover = WebDriver.FindElement(By.XPath("//tr[" + j + "]/td[9]//div[@class='popover-content']"));
                columnsValues.Add(poNumberHover.GetText(WebDriver));
            }
            return columnsValues;
        }

        public List<IWebElement> pomSearchPageResultsByColumns()
        {
            try
            {
                var table = WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_PomSearchResultsGrid']"));
                List<IWebElement> headingTable = new List<IWebElement>(table.FindElements(By.TagName("th")));
                return headingTable;
            }
            catch (NoSuchElementException e)
            {
                throw;
            }
        }

        public IWebElement SortTableGridBy(int column)
        {
            var headerlnk = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomSearchResultsGrid']/thead/tr/th[" + column + "]/span"));
            if (headerlnk == null)
                throw new NoSuchElementException(string.Format("Column header {0} is not found", column));
            WebDriver.WaitForBusyOverlay();
            return headerlnk;
        }

        public List<IWebElement> pomSearchResults()
        {
            var elemTable = WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_PomSearchResultsGrid']"));
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            return lstTrElem;
        }

        public bool isColumnSortedAscending(int index)
        {
            string result = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomSearchResultsGrid']/thead/tr/th[" + index + "]/span/span")).GetAttribute("class");
            if (result == "sorting_asc")
                return true;
            else return false;
        }

        public bool isColumnSortedDescending(int index)
        {
            string result = WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomSearchResultsGrid']/thead/tr/th[" + index + "]/span/span")).GetAttribute("class");
            if (result == "sorting_desc")
                return true;
            else return false;
        }

        public int GetNumOfSelectableRecordsCount()
        {
            return WebDriver.FindElements(By.XPath("//tbody/tr//input[@ng-reflect-is-disabled='false']")).Count(); // number of enabled checkboxes displayed
        }

        public void VerifyIfAllRecordsAreSelected()
        {
            int j = WebDriver.FindElements(By.XPath("//tbody/tr")).Count();
            Assert.IsTrue(WebDriver.FindElement(By.XPath("//tr[1]/th//input[@type='checkbox']")).Selected);

            for (int i = 1; i < j; i++)
            {
                Assert.IsTrue(WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]//input[@type='checkbox']")).Selected);
            }
        }

        public void VerifyIfAllRecordsAreUnSelected()
        {
            int j = WebDriver.FindElements(By.XPath("//tbody/tr")).Count();
            Assert.IsFalse(WebDriver.FindElement(By.XPath("//tr[1]/th//input[@type='checkbox']")).Selected);

            for (int i = 1; i < j; i++)
            {
                Assert.IsFalse(WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]//input[@type='checkbox']")).Selected);
            }
        }

        public void VerifyIfAllRecordsAreDisabledForSelection(bool complete)
        {
            int j = WebDriver.FindElements(By.XPath("//input[@ng-reflect-is-disabled='true']")).Count();
            if (complete == true)
            {
                Assert.IsFalse(WebDriver.FindElement(By.XPath("//tr[1]/th//input[@type='checkbox']")).Enabled);
            }
            else
            {
                Assert.IsTrue(WebDriver.FindElement(By.XPath("//tr[1]/th//input[@type='checkbox']")).Enabled);
            }

            for (int i = 1; i < j; i++)
            {
                Assert.IsFalse(WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]//input[@type='checkbox']")).Enabled);
            }
        }

        public void VerifyRecordsSelectionForWorkingStatus()
        {
            int j = WebDriver.FindElements(By.XPath("//tbody/tr")).Count();
            Assert.IsTrue(WebDriver.FindElement(By.XPath("//tr[1]/th//input[@type='checkbox']")).Selected);

            for (int i = 1; i < j; i++)
            {
                bool assignedTo = WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]//td[11]")).GetText(WebDriver).Contains("OEA_Process");
                bool workGroup = !(WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]//td[13]")).GetText(WebDriver).Contains("-"));

                if (assignedTo && workGroup)
                {
                    Assert.IsFalse(WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]//input[@type='checkbox']")).Enabled);
                }
                else
                {
                    Assert.IsTrue(WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]//input[@type='checkbox']")).Selected);
                }

            }
        }

        public string ClickOnViewLinkForAnyPOM(string pomId)
        {
            int i = WebDriver.FindElements(By.XPath("//tbody/tr")).Count();
            for (int j = 1; j <= i; j++)
            {
                if (WebDriver.FindElement(By.XPath("//tbody/tr[" + j + "]//td[5]//pom-doc-link/a")).IsElementDisplayed(WebDriver))
                {
                    WebDriver.FindElement(By.XPath("//tbody/tr[" + j + "]//td[5]//pom-doc-link/a")).Click(WebDriver);
                    pomId = WebDriver.FindElement(By.XPath("//tbody/tr[" + j + "]//td[3]//pom-id-link/a")).GetText(WebDriver);
                    break;
                }
            }

            return pomId;
        }

        public void VerifyDownloadedFile(string fileName)
        {
            string userProfileFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string downloadsFolder = userProfileFolder + "\\Downloads\\";
            try
            {
                string[] fileEntries = Directory.GetFiles(downloadsFolder);

                for (int i = 0; i < fileEntries.Length; i++)
                {
                    if (fileEntries[i].Contains(fileName))
                    {
                        break;
                    }
                    else
                    {
                        Logger.Write("Check next");
                    }
                }
            }
            catch(Exception ex)
            {
                Logger.Write(ex.Message);
            }


        }

        public void SelectFromDate(string year)
        {
            //((IJavaScriptExecutor)WebDriver).ExecuteScript("document.getElementBy('fromDate').setAttribute('ng-reflect-model','01 Jan 2018')");
            WebDriver.FindElement(By.XPath("//th[2]/button")).Click(WebDriver);
            WebDriver.FindElement(By.XPath("//th[2]/button")).Click(WebDriver);
            WebDriver.FindElement(By.XPath("//th[1]/button")).Click(WebDriver);
            WebDriver.FindElement(By.XPath("//tr[4]/td/button/span[text()='" + year + "']")).Click(WebDriver);
            WebDriver.FindElement(By.XPath("//monthpicker//tbody/tr[1]/td[1]/button/span")).Click(WebDriver);
            WebDriver.FindElement(By.XPath("//daypicker//tbody/tr[1]/td[2]/button/span")).Click(WebDriver);
        }

        public void VerifyIfAllRowsHaveSearchPoNumber(string poNumber)
        {
            poNumber = poNumber.Replace("*", string.Empty).ToUpper();
            int i = GetSearchResultsCount();

            for (int j = 1; j < i; j++)
            {
                Assert.IsTrue(WebDriver.FindElement(By.XPath("//tbody/tr[" + j + "]//td[4]//pom-grid-po-no-tooltip//div")).GetText(WebDriver).ToUpper().Contains(poNumber));
            }
        }

        public void VerifyIfAllRowsHaveSearchWorkGroup(string workGroup)
        {
            int i = GetSearchResultsCount();

            for (int j = 1; j < i; j++)
            {
                Assert.IsTrue(WebDriver.FindElement(By.XPath("//tbody/tr[" + j + "]//td[13]")).GetText(WebDriver).Contains(workGroup));
            }
        }

        public List<string> GetWorkingPomIdsList(List<string> pomIds)
        {
            int count = Convert.ToInt16(GetNumofRecordsDisplayed());
            if (count > 5)
            {
                for (int i = 1; i <= 5; i++)
                {
                    pomIds.Add(WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]/td[3]//pom-id-link/a")).GetText(WebDriver));
                }
            }
            else
            {
                for (int i = 1; i <= count; i++)
                {
                    pomIds.Add(WebDriver.FindElement(By.XPath("//tbody/tr[" + i + "]/td[3]//pom-id-link/a")).GetText(WebDriver));
                }
            }
            return pomIds;
        }

public IWebElement ReassignItem_userSearchbox { get { return WebDriver.GetElement(By.XPath(".//ng-select[@placeholder='Search']//span[text()='Search']")); } }
public IWebElement userSearchBoxBulkReassign { get { return WebDriver.GetElement(By.XPath(".//input[@type='text' and @placeholder='Search']")); } }
public IWebElement SelectedBusinessUnit { get { return WebDriver.GetElement(By.XPath(".//span[@class='current-business-unit']/a")); } }
public IWebElement FirstWorkgroupInPOMWorkGroups { get { return WebDriver.GetElement(By.XPath("//div[@id='DataTables_div_MyWorkgroupGrid']//td[1]/input[@class='ng-valid ng-dirty ng-touched']")); } }
        //[FindsBy(How = How.XPath, Using = "//th/input[@class='ng-untouched ng-pristine']")] public IWebElement selectAllcheckboxOnPOMWorkgroups;

        public List<string> GetListOfMappedUsersFromReassignWorkItems()
        {
            IList<IWebElement> userDropdownValuesForBulkReAssign = WebDriver.FindElements(By.XPath(".//*[@class='form-input form-control-dropdown']//ul//li//a/div"));
            List<string> usersList = new List<string>();
            foreach (IWebElement element in userDropdownValuesForBulkReAssign)
            {
                usersList.Add(element.Text);
            }

            return usersList;
        }
    }
}

