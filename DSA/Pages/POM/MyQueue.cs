//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace Dsa.Pages.POM
{
    public class MyQueue:DsaPageBase
    {
        public static TimeSpan GlobalWaitTime = TimeSpan.FromSeconds(60);
        public MyQueue(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "MyQueue";
            PageFactory.InitElements(webDriver, this);
            webDriver.VerifyBusyOverlayNotDisplayed();
        }

        #region My Queue

public IWebElement MyQWorkingTab { get { return WebDriver.GetElement(By.XPath("//*[@id='working_tab']")); } }


public IWebElement MyQSuspendedTab { get { return WebDriver.GetElement(By.XPath("//*[@id='suspended_tab']")); } }


public IWebElement MyQCompletedTab { get { return WebDriver.GetElement(By.XPath("//*[@id='completed_tab']")); } }


public IWebElement MyQViewAllTab { get { return WebDriver.GetElement(By.XPath("//*[@id='view_all_tab']")); } }


public IWebElement TblMyQueueList { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomMyQueueGrid']")); } }


public IWebElement HeaderMyQueue { get { return WebDriver.GetElement(By.XPath("//*[@id='pomMyQueue_title']")); } }


public IWebElement MyQPomIdLink { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomMyQueueGrid']/tbody/tr[1]/td[2]/descendant::a")); } }


public IWebElement LblNextInQueue { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/pom-nextin-queue/div/div/label[1]/b")); } }


public IWebElement BtnWorkThisItem { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/pom-nextin-queue/div/div/button[@class='btn btn-success']")); } }


public IWebElement DateReceived { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomMyQueueGrid']/tbody/tr/td[6]/add-component/my-queue-date-format/div")); } }


public IWebElement MyQueuePomIdLink { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomMyQueueGrid']/tbody/tr/td[2]/add-component/my-queue-pom-id-link/div/a")); } }


public IWebElement MyQueueViewPoLink { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomMyQueueGrid']/tbody/tr/td[4]/add-component/my-queue-pom-doc-link/div/a")); } }

public IWebElement LnkPomId { get { return WebDriver.GetElement(By.XPath("//tbody/tr[1]/td[2]//a")); } }
public IWebElement NextPomIdStatus { get { return WebDriver.GetElement(By.XPath("//tbody/tr[1]/td[13]")); } }

public IWebElement NextPOMid { get { return WebDriver.GetElement(By.XPath("//tbody/tr[1]/td[2]//div")); } }
public IWebElement NextPOMPonumebr { get { return WebDriver.GetElement(By.XPath("//tbody/tr[1]/td[3]")); } }
public IWebElement NextPOMDateReceived { get { return WebDriver.GetElement(By.XPath("//tbody/tr[1]/td[6]//div")); } }
public IWebElement NextPOMWorkgroup { get { return WebDriver.GetElement(By.XPath("//tbody/tr[1]/td[12]")); } }
public IWebElement POMIdNextinQueueSection { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/pom-nextin-queue/div/div/label[2]")); } }
public IWebElement PoNumberNextinQueueSection { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/pom-nextin-queue/div/div/label[3]")); } }
public IWebElement DateReceivedNextinQueueSection { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/pom-nextin-queue/div/div/label[5]//div")); } }
public IWebElement WorkGroupNextinQueueSection { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/pom-nextin-queue/div/div/label[6]")); } }
public IWebElement DellHomeLogo { get { return WebDriver.GetElement(By.Id("dellBrandLogo_goHomePage")); } }
 public IWebElement PoMIdLink;
public IWebElement PoMIdText { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_PomMyQueueGrid']/tbody/tr/td[2]/add-component/my-queue-pom-id-link/div")); } }
public IWebElement AddNextItemInQueue { get { return WebDriver.GetElement(By.XPath("//pom-nextin-queue//div[contains(@class,'alert-info')]/a")); } }
        #endregion

        public IList<IWebElement> MyQueueGetPomId_ViewLink_By_Index()
        {
            IList<IWebElement> WgDateRecResults = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_PomMyQueueGrid']/tbody/tr/td[2]/add-component/my-queue-pom-id-link/div/a"));
            return WgDateRecResults;
        }
        public IList<IWebElement> MyQueueGetPoDoc_ViewLink_By_Index()
        {
            IList<IWebElement> WgDateRecResults = WebDriver.FindElements(By.XPath("//*[@id='DataTables_Table_PomMyQueueGrid']/tbody/tr/td[4]/add-component/my-queue-pom-doc-link/div/a"));
            return WgDateRecResults;
        }

        public void VerifyTabCountWithRowsDisplayed(string strPomCount, int iLength, int iPomCount)
        {
            if (iPomCount > 0)
            {
                var wrkngrows = WebDriver.GetElements(By.CssSelector("#DataTables_Table_PomMyQueueGrid > tbody > tr"));
                if (iLength < 2)
                {
                    if (!(wrkngrows.Count == iPomCount))
                    {
                        Assert.Fail("No.of PomIDs are incorrect");
                    }
                }
                else if (iLength > 1)
                {
                    if (!(wrkngrows.Count == 10))
                    {
                        Assert.Fail("No of PomIDs are incorrect");
                    }
                }
                wrkngrows.Clear();
            }
        }

        public IList<IWebElement> GetNextInQueueSections()
        {
            IList<IWebElement> sections = WebDriver.FindElements(By.XPath("//*[@id='main']/pom-nextin-queue/div/div/label/b"));
            return sections;
        }

        public string ClickOnViewLinkForAnyPOMId(string pomId)
        {
            int i = WebDriver.FindElements(By.XPath("//tbody/tr")).Count();          

            for (int j = 1; j <= i; j++)
            {
                By viewlink = By.XPath("//tbody/tr[" + j + "]//td[4]//my-queue-pom-doc-link//a");
            
                if (WebDriver.ElementExists(viewlink))
                {
                    WebDriver.FindElement(By.XPath("//tbody/tr[" + j + "]//td[4]//my-queue-pom-doc-link//a")).Click(WebDriver);
                    pomId = WebDriver.FindElement(By.XPath("//tbody/tr[" + j + "]//td[2]//my-queue-pom-id-link//a")).GetText(WebDriver);                    
                    WebDriver.WaitForBusyOverlay();
                    break;
                }
                else
                {
                    Logger.Write("Verify next");
                }
            }

            return pomId;
        }

        public int GetFilesCountBefore()
        {
            string userProfileFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string downloadsFolder = userProfileFolder + "\\Downloads\\";
            int file_length = 0;
            try
            {
                string[] fileEntries = Directory.GetFiles(downloadsFolder);
                file_length = fileEntries.Length;
            }
            catch(Exception ex)
            {
                Logger.Write(ex.Message);
            }
            return file_length;
        }
        public void OpenNewTab(string baseUrl)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            js.ExecuteScript("window.open();");
            WebDriver.SwitchTo().Window(WebDriver.WindowHandles.Last());
            WebDriver.Url = baseUrl;
        }       

        public IList<IWebElement> GetStatusOfPomIds()
        {
            IList<IWebElement> status = WebDriver.FindElements(By.XPath("//*[contains(@id,'PomMyQueueGrid')]/tbody//tr/td[13]"));
            return status;
        }

        public void VerifyPomIdAndViewLink(int i)
        {
            i = i + 1;
            By pomIdLink = By.XPath("//*[contains(@id,'PomMyQueueGrid')]/tbody//tr[" + i + "]/td[2]//my-queue-pom-id-link//a");
            By viewLink = By.XPath("//*[contains(@id,'PomMyQueueGrid')]/tbody//tr[" + i + "]/td[4]//my-queue-pom-doc-link//a");

            if(WebDriver.ElementExists(pomIdLink))
            {
                Logger.Write("Pom id " + WebDriver.FindElement(pomIdLink).GetText(WebDriver) + " is shown as a Link");
                Assert.IsTrue(WebDriver.ElementExists(pomIdLink));

                if (WebDriver.ElementExists(viewLink))
                {
                    Logger.Write("View is shown as link for this " + WebDriver.FindElement(pomIdLink).GetText(WebDriver));
                    Assert.IsTrue(WebDriver.ElementExists(viewLink));
                }
                else
                {
                    Logger.Write("POM id " + WebDriver.FindElement(pomIdLink).GetText(WebDriver) + " doesnot have View link");
                }                
            }
            else
            {
                Assert.Fail("Pom id and View are not shown as Links");
            }            
        }

        public void GetPOMidDateReceivedValuesFromSusTab(ref List<string> pomId, ref List<string> poTotal)
        {
            int j = WebDriver.FindElements(By.XPath("//tbody/tr")).Count();         

            for (int i = 1; i <= j; i ++)
            {
                //if (!(WebDriver.FindElement(By.XPath("//*[contains(@id,'PomMyQueueGrid')]/tbody//tr[" + i + "]/td[13]")).GetText(WebDriver).Contains("Sales Hold")))
                //{
                    pomId.Add(WebDriver.FindElement(By.XPath("//*[contains(@id,'PomMyQueueGrid')]/tbody//tr[" + i + "]/td[2]//my-queue-pom-id-link//a")).GetText(WebDriver));                  
                    poTotal.Add(WebDriver.FindElement(By.XPath("//*[contains(@id,'PomMyQueueGrid')]/tbody//tr[" + i + "]/td[9]")).GetText(WebDriver));
                //}
                //else
                //{
                //    Logger.Write("Pom id is not eligible to be displayed on Suspended Purchase Orders section on Home Page");
                //}
            }
        }

        public void WaitUntilPomIdsDisplay(IWebDriver driver, TimeSpan? waitTime = null)
        {
            By inlineBusy = By.XPath("//my-queue-pom-id-link");

            if (waitTime == null)
                waitTime = GlobalWaitTime; // If no Wait time set from the page class, then use the default.

            WebDriverWait wait = new WebDriverWait(driver, waitTime.Value);
            wait.Until(ExpectedConditions.ElementIsVisible(inlineBusy));
        }
    }
}
