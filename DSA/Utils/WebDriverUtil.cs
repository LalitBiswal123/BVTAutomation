using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Pages;
using Dsa.Pages.Solutions;
using Dsa.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using systemForms = System.Windows.Forms;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System.Threading;

namespace Dsa.Utils
{
    /// <summary>
    /// General Utilities not dependent on any page
    /// </summary>
    public static class WebDriverUtil
    {
        /// <summary>
        /// The element wait time. Default is set to 60 seconds.
        /// </summary>
        public static TimeSpan WaitTime = TimeSpan.FromSeconds(150);
        public static string ParentHandler;
        public static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
                       
        public static void RefreshCurrentPage(this IWebDriver driver,int noOfTime = 1)
        {
            VerifyBusyOverlayNotDisplayed(driver);
            driver.Navigate().Refresh();
            VerifyBusyOverlayNotDisplayed(driver);
        }
        
        public static bool IsBusyElementDisplayed(By loc, IWebDriver driver)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(25));
                wait.Until(ExpectedConditions.ElementIsVisible(loc));
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }

       
        public static bool VerifyPopupDisplayed(IWebDriver driver, By popupEle)
        {
            try
            {
                IWebElement element = driver.FindElement(popupEle);
                return element.Displayed;
            }
            catch
            {
                return false;
            }
        }


        public static bool VerifyBusyOverlayNotDisplayed(this IWebDriver driver)

        {
            WaitForBusyOverlayNotDisplayed(driver);
            return true;
            //By oldbyLoc = By.XPath("//*[@id='busy-overlay']");
            //By newbyLoc = By.XPath("//overlay-busy/div[@id='busy-overlay']");


            //if (IsBusyElementDisplayed(newbyLoc, driver))
            //{
            //    new WebDriverWait(driver, DsaUtil.GlobalWaitTime).Until(ExpectedConditions.InvisibilityOfElementLocated(newbyLoc));

            //}
            //else if (IsBusyElementDisplayed(oldbyLoc, driver))
            //{
            //    new WebDriverWait(driver, DsaUtil.GlobalWaitTime).Until(ExpectedConditions.InvisibilityOfElementLocated(oldbyLoc));

            //}

            //else
            //{
            //    new WebDriverWait(driver, DsaUtil.GlobalWaitTime).Until(ExpectedConditions.InvisibilityOfElementLocated(oldbyLoc));
            //    new WebDriverWait(driver, DsaUtil.GlobalWaitTime).Until(ExpectedConditions.InvisibilityOfElementLocated(newbyLoc));
            //}
            //return true;
        }       

        public static bool PCFVerifyBusyOverlayNotDisplayed(this IWebDriver driver)

        {
            PCFWaitForBusyOverlayNotDisplayed(driver);
            return true;
        }

            /// <summary>
            /// Navigates the home page.
            /// </summary>
            /// <param name="driver">The driver.</param>
            /// <param name="baseUrl">base url to navigate</param>
        public static void NavigateHomePage(this IWebDriver driver, string baseUrl, string userName = "")
            {
            
                driver.Navigate().GoToUrl(baseUrl);
                    Log.Info(string.Format("Navigated to {0}", baseUrl));
            //driver.RefreshCurrentPage();
            //driver.WaitForPageLoad(new TimeSpan(5000)); 

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("welcomeMessage")));

            ParentHandler = driver.CurrentWindowHandle;
            Log.Info("Loggedin User : " + new HomePage(driver).MsgWelcome.GetText(driver).Replace("Welcome, ", ""));
            }

        /// <summary>
        /// Navigates to the DSA Channel page and login as channel partner.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="baseUrl">base url to navigate</param>
        public static void NavigateAndLoginAsChannelPartner(this IWebDriver driver, TestContext testContext, string baseUrl,
            string userName = "")
        {
            if (ConfigurationManager.AppSettings["WebDriver"].ToLower() != "edge")
                driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();

            driver.Manage().Cookies.DeleteAllCookies();
            
            if (!string.IsNullOrEmpty(userName))
            {
                string navigateUrl = baseUrl.Replace("http://",
                    "http://" + userName + ":" + Encryptor.DecryptString(ConfigurationManager.AppSettings[userName]) + "@");
                driver.Navigate().GoToUrl(navigateUrl);
                Log.Info(string.Format("Navigated to {0} with Username: {1}", baseUrl, userName));
            }
            else
            {
                driver.Navigate().GoToUrl(baseUrl);
                Log.Info(string.Format("Navigated to {0}", baseUrl));
            }

            ParentHandler = driver.CurrentWindowHandle;

            //logic for login
            var row = testContext.DataRow;
            new PartnerPortalLoginPage(driver).SignInWithPartnerLoginCredentials(driver, row["ChannelPartnerEmail"].ToString(), row["ChannelPartnerPwd"].ToString());
            Log.Info("Logged in as a Channel Partner. DSA homepage is loaded for channel flow");
        }
       

        public static IWebElement GetElement(this IWebDriver driver, By by, TimeSpan? waitTime = null)
        {
            try
            {
                if (waitTime == null)
                {
                    return driver.FindElement(by);
                }
                else
                {
                    var wait = new WebDriverWait(driver, waitTime.Value);
                    return wait.Until<IWebElement>(ExpectedConditions.ElementIsVisible(by));
                    //return wait.Until(x => x.FindElement(by));
                }
            }
            catch (Exception e)
            {
                Log.Info("Error: " + e);
                return null;
            }
        }

        public static List<IWebElement> GetElements(this IWebDriver driver, By by, TimeSpan? waitTime = null)
        {
            try
            {
                List<IWebElement> elements;
                driver.VerifyBusyOverlayNotDisplayed();
                if (ConfigurationManager.AppSettings["WebDriver"].ToLower() == "edge")
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0);");
                }
                if (waitTime == null)
                {
                    elements = driver.FindElements(by).Where(a => a.Displayed).ToList();
                }
                else
                {
                    var wait = new WebDriverWait(driver, waitTime.Value);
                    elements = wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(by)).Where(a => a.Displayed).ToList();
                }
                Log.Info(" List of elements found." + elements.Count);
                return elements;
            }
            catch (Exception e)
            {
                Log.Info("Error: " + e);
                return null;
            }
        }      

        /// <summary>
        /// gets contents of a table or grid
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="by">By</param>
        /// <returns>list of table contents</returns>
        public static List<Dictionary<string, object>> GetHtmlTableData(this IWebDriver driver, By by)
        {
            var divElement = driver.GetElement(by);
            var tableElement = divElement.FindElement(By.CssSelector("table"));
            var tableData = new List<Dictionary<string, object>>();
            const string columnHeaderCaption = "Column";

            var headers = tableElement.FindElements(By.CssSelector("thead > tr > th")); // Get all the header elements
            var rows = tableElement.FindElements(By.CssSelector("tbody > tr"));     // Get all the row elements
            foreach (var row in rows)       // Loop through all the <tr> elements in a row
            {
                var tds = row.FindElements(By.CssSelector("td"));   // Get all <td> elements inside a row or <tr> element
                var data = new Dictionary<string, object>();
                int index = 0;
                foreach (var td in tds)     // Loop through all the <td> elements in a row
                {
                    string columnHeader;
                    if (string.IsNullOrWhiteSpace(headers[index].Text))
                        columnHeader = columnHeaderCaption + (index + 1);   // Sometimes there may be more than one blank headers in a table
                    else
                        columnHeader = headers[index].Text;

                    data.Add(columnHeader, td.Text);    // Add the data in a dictionary
                    index++;
                }
                tableData.Add(data);
            }
            Log.Info(" Html table data recived.");
            return tableData;
        }

        /// <summary>
        /// runs javascript and returns results typed as T
        /// </summary>
        /// <typeparam name="T">object type</typeparam>
        /// <param name="driver">The selenium driver</param>
        /// <param name="javaScript">Java script string</param>
        /// <param name="args">Arguments</param>
        /// <returns>Return object after executing Js query</returns>
        public static T ExecuteJsScript<T>(this IWebDriver driver, string javaScript, params object[] args)
        {
            var js = driver as IJavaScriptExecutor;
            return (T)js.ExecuteScript(javaScript, args);
        }      
       
        public static void PickDropdownByText(this IWebDriver driver, By by, string text)
        {
            driver.WaitForElementVisible(by, WaitTime);
            driver.FindElement(by).IsElementClickable(driver);
            var dropdown = driver.GetElement(by);
            dropdown.FindElements(By.TagName("option")).ToList().First(a => a.Text.Trim() == text).Click();
            //dropdown.SendKeys(Keys.Tab);

            Log.Info(string.Format(" element selected by specified text: {0}", text));
        }

          public static void PickDropdownByValue(this IWebDriver driver, By dropdownId, string value)
        {
            driver.WaitForElementVisible(dropdownId, WaitTime);
            var dropdown = driver.GetElement(dropdownId);
            new SelectElement(dropdown).SelectByValue(value);
            dropdown.SendKeys(Keys.Tab);

            Log.Info(string.Format(" element selected by specified value: {0}", value));
        }


        public static string GetDropdownSelectedText(this IWebDriver driver, By dropdownId)
        {
            var dropdown = driver.GetElement(dropdownId);
            string str = dropdown.Text;

            Log.Info(string.Format(" selected text: {0}", str));
            return str;
        }
          
        public static void WaitForBusyOverlay(this IWebDriver driver)
        {
            //Commenting it temporarily as Angular JS is causing issue need to revisit later
           driver.WaitFor(v => !v.IsBusy());
        }
        
        public static void WaitFor(this IWebDriver driver, Func<IWebDriver, bool> waitCondition, int timeout = 145, bool ignoreException = false)
        {
            //driver.WaitForTimeSpan(waitCondition, TimeSpan.FromSeconds(timeout), ignoreException);
            TimeSpan? timespan = TimeSpan.FromSeconds(timeout);

            try
            {
                var wait = new WebDriverWait(driver, timespan.Value);
                wait.Until(waitCondition);
            }
            catch (Exception)
            {
                Console.WriteLine("Wait condition failed.");
                if (!ignoreException)
                    throw;
            }
        }
                     
        public static void ScrollToElement(this IWebDriver driver, By by)
        {
            IWebElement element = driver.GetElement(by);
            int elementPosition = element.Location.Y;
            ((IJavaScriptExecutor)driver).ExecuteScript(string.Format("window.scroll(0, {0} - 200)", elementPosition));
        }

        public static void ScrollToElement(this IWebDriver driver, IWebElement element)
        {
            int elementPosition = element.Location.Y;
            ((IJavaScriptExecutor)driver).ExecuteScript(string.Format("window.scroll(0, {0} - 200)", elementPosition));
        }

        public static void ScrollAndClick(this IWebDriver driver, By by)
        {
            // Scrolls down an automatic 200 pixels. Might need to be changed depending on header size.
            IWebElement element = driver.GetElement(by);
            int elementPosition = element.Location.Y;
            ((IJavaScriptExecutor)driver).ExecuteScript(string.Format("window.scroll(0, {0} - 200)", elementPosition));
            element.Click();
        }        

        public static void ScrollAndClickByElement(this IWebDriver driver, IWebElement element)
        {
            int elementPosition = element.Location.Y;
            ((IJavaScriptExecutor)driver).ExecuteScript(string.Format("window.scroll(0, {0} - 200)", elementPosition));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element, element.Location.X, element.Location.Y).Click().Build().Perform();
        }

        public static void ScrollIntoElement(this IWebDriver driver, IWebElement element)
        {
            int elementPosition = element.Location.Y;
            ((IJavaScriptExecutor)driver).ExecuteScript(string.Format("window.scroll(0, {0} - 200)", elementPosition));
            Actions builder = new Actions(driver);
            //builder.MoveToElement(element, element.Location.X, element.Location.Y).Perform();
            builder.MoveToElement(element).Perform();
        }

        public static bool IsElementVisible(this IWebDriver driver, IWebElement element)
        {
            return element.Displayed;
        }

        public static void ScrollToTop(this IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0);");
        }

        public static void ScrollToBottom(this IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }
        
        /// <summary>
        /// Wait until the Element is displayed on the UI
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        /// <param name="waitTime"></param>
        /// <returns></returns>
        public static bool WaitForElementDisplay(this IWebDriver driver, IWebElement element, TimeSpan? waitTime = null)
        {
            try
            {
                if (waitTime == null)
                    waitTime = WaitTime; // If no Wait time set from the page class, then use the default.
                WebDriverWait wait = new WebDriverWait(driver, waitTime.Value);
                return wait.Until(d => element.Displayed);
            }
            catch (Exception e)
            {
                return false;
            }
        }
       
        /// <summary>
        /// Wait until the Element is displayed on the UI
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="by"></param>
        /// <param name="waitTime"></param>
        /// <returns></returns>
        public static bool WaitForElementDisplay(this IWebDriver driver, By by, TimeSpan? waitTime = null)
        {
            try
            {
                if (waitTime == null)
                    waitTime = WaitTime; // If no Wait time set from the page class, then use the default.
                WebDriverWait wait = new WebDriverWait(driver, waitTime.Value);
                wait.Until(ExpectedConditions.ElementIsVisible(by));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Wait until the Element is displayed on the UI
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="by"></param>
        /// <param name="waitTime"></param>
        /// <returns></returns>
        public static IWebElement WaitAndGetElementAfterDisplay(this IWebDriver driver, By by, TimeSpan? waitTime = null)
        {
            try
            {
                if (waitTime == null)
                    waitTime = WaitTime; // If no Wait time set from the page class, then use the default.
                WebDriverWait wait = new WebDriverWait(driver, waitTime.Value);
                return wait.Until(ExpectedConditions.ElementIsVisible(by));
                
            }
            catch (Exception e)
            {
                return null;
            }
        }
       
        /// <summary>
        /// Wait until the Element is displayed in DOM. Won't check if Element is displayed on UI
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="by"></param>
        /// <param name="waitTime"></param>
        /// <returns></returns>
        public static bool WaitForElementPresentinDom(this IWebDriver driver, By by, TimeSpan? waitTime = null)
        {
            try
            {
                if (waitTime == null)
                    waitTime = WaitTime; // If no Wait time set from the page class, then use the default.
                WebDriverWait wait = new WebDriverWait(driver, waitTime.Value);
                wait.Until(ExpectedConditions.ElementExists(by));
                return true;
               
            }
            catch (Exception e)
            {
                return false;
            }
        }
      
        /// <summary>
        /// Element Click will happen using JavaScript click
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        public static void JavaScriptClick(this IWebDriver driver, IWebElement element)
        {
            try
            {
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", element);
                Log.Info("[Using Javascript] Element is clicked.");
                driver.VerifyBusyOverlayNotDisplayed();
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Wait for Fetching Cart... element to appear and disappear on the UI
        /// </summary>
        /// <param name="driver"></param>
        public static void WaitForFetchingCart(this IWebDriver driver)
        {
            driver.WaitForElementVisible(By.XPath("//overlay-busy//p[contains(text(), 'Fetching Cart...')]"), TimeSpan.FromSeconds(25));
            var wait = new WebDriverWait(driver, DsaUtil.GlobalWaitTime);
            wait.Until<bool>(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//overlay-busy//p[contains(text(), 'Fetching Cart...')]")));
        }        

        /// <summary>
        /// Wait for Element for refresh
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        /// <param name="waitTime"></param>
        /// <returns></returns>
        public static bool StalenessOfElement(this IWebDriver driver, By by, TimeSpan? waitTime = null)
        {
            try
            {
                if (waitTime == null)
                    waitTime = WaitTime; // If no Wait time set from the page class, then use the default.
                WebDriverWait wait = new WebDriverWait(driver, waitTime.Value);
                wait.Until(ExpectedConditions.StalenessOf(driver.FindElement(by)));
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool StalenessOfElement(this IWebDriver driver, IWebElement webElement, TimeSpan? waitTime = null)
        {
            try
            {
                if (waitTime == null)
                    waitTime = WaitTime; // If no Wait time set from the page class, then use the default.
                WebDriverWait wait = new WebDriverWait(driver, waitTime.Value);
                wait.Until(ExpectedConditions.StalenessOf(webElement));
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if the Element is not Present on UI Returns False if not Present, This Code Does not Crash if Element not Display
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="by"></param>
        /// <param name="waitTime"></param>
        /// <returns></returns>
        

        public static void WaitUntilElementDisappers(IWebDriver webDriver, By by, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
        }

        public static void WaitUntilUrlDisplay(IWebDriver webDriver, string url, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.UrlContains(url));
        }

        public static bool IsBusy(this IWebDriver driver)
        {
            //return (driver.ExecuteJsScript<bool>(
            //        "return angular != null ? angular.element('#busy-overlay').scope().showBusyOverlay : true;  ") ||
            //        (driver.ExecuteJsScript<bool>(
            //        "return angular != null ? angular.element('#busy-indicator').scope().showBusyIndicator : true;  ")));
            WaitForBusyOverlayNotDisplayed(driver);
            return false;
        }

        public static void WaitForBusyOverlayNotDisplayed(IWebDriver driver)
        {
            By loc = By.XPath("//*[@id='busy-overlay']");          
            if (IsBusyElementDisplayed(loc, driver))
            {
                new WebDriverWait(driver, DsaUtil.GlobalWaitTime).Until(ExpectedConditions.InvisibilityOfElementLocated(loc));
            }
            new WebDriverWait(driver, DsaUtil.GlobalWaitTime).Until(ExpectedConditions.InvisibilityOfElementLocated(loc));
        }

        public static void PCFWaitForBusyOverlayNotDisplayed(IWebDriver driver)
        {
            By loc = By.XPath("//*[@id='busy-indicator']");
            if (IsBusyElementDisplayed(loc, driver))
            {
                new WebDriverWait(driver, DsaUtil.GlobalWaitTime).Until(ExpectedConditions.InvisibilityOfElementLocated(loc));
            }
            new WebDriverWait(driver, DsaUtil.GlobalWaitTime).Until(ExpectedConditions.InvisibilityOfElementLocated(loc));
        }

        public static bool WaitForEitherElement(this IWebDriver driver, By expectedElement, By unexpectedElement, int timeout = 0)
        {
            int retryCounter = 0;
            if (timeout == 0)
            {
                timeout = Convert.ToInt32(DsaUtil.GlobalWaitTime.TotalSeconds);
            }
            int retryTimeout = timeout / 2;
            bool elementsLoaded = false;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            while (!elementsLoaded && retryCounter < retryTimeout)
            {
                try
                {
                    elementsLoaded = wait.Until(ExpectedConditions.ElementIsVisible(expectedElement)).Displayed;
                    return true;
                }
                catch (Exception e)
                {
                    try
                    {
                        elementsLoaded = wait.Until(ExpectedConditions.ElementIsVisible(unexpectedElement)).Displayed;
                        return false;
                    }
                    catch
                    {
                        retryCounter++;
                        if (retryCounter >= retryTimeout)
                        {
                            throw new WebDriverTimeoutException("No results returned and no message returned after " + retryTimeout * 2 + " seconds");
                        }
                    }
                }
            }
            return false;
        }


    }
}
