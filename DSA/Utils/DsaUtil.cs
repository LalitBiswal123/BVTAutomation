using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Enums;
using Dsa.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Dsa.Utils
{
    public static class DsaUtil
    {
        public static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static TimeSpan GlobalWaitTime = TimeSpan.FromSeconds(120);


        #region ElementActionMethods

        public static void Click(this IWebElement element, IWebDriver driver, TimeSpan? waitTime = null)
        {
            bool executeOnException = true;
            try
            {
                driver.VerifyBusyOverlayNotDisplayed();
                bool browserVerification = (ConfigurationManager.AppSettings["WebDriver"].ToLower() == "edge");
                if (browserVerification)
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0);");
                }                
                element.WaitForElementVisible(TimeSpan.FromSeconds(10));
                bool elefound = element.IsElementClickable(driver);
                if (elefound)
                {
                    string elementText = element.Text;
                    element.Click();
                    Log.Info(elementText + " is Clicked");
                    driver.VerifyBusyOverlayNotDisplayed();

                }
                else
                {
                    Log.Error($"Element: '{element.Text}' of type: '{element.TagName}' is not to ready to perform click action.");
                    throw new ElementClickInterceptedException($"Element: '{element.Text}' of type: '{element.TagName}' is not to ready to perform click action.");
                }
            }
            catch (ElementClickInterceptedException e)
            {

                if (executeOnException)
                {
                    // element present in a page but its overlapped on another element and not visible
                    if (e.Message.Contains("Other element would receive the click"))
                    {
                        WebDriverUtil.ScrollToTop(driver);
                        element.Click();
                        driver.VerifyBusyOverlayNotDisplayed();
                    }
                }

            }
        }
        public static void Click(this By byElement, IWebDriver driver, TimeSpan? waitTime = null, bool maintainScroll = false)
        {
            bool executeOnException = true;
            IWebElement element = null;
            try
            {
                driver.VerifyBusyOverlayNotDisplayed();
                bool browserVerification = (ConfigurationManager.AppSettings["WebDriver"].ToLower() == "edge");
                if (browserVerification & maintainScroll == false)
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0);");
                }

                driver.VerifyBusyOverlayNotDisplayed();
                element = driver.GetElement(byElement);
                bool elefound = element.IsElementClickable(driver);
                if (elefound)
                {
                    string elementText = element.Text;
                    driver.VerifyBusyOverlayNotDisplayed();
                    element.Click();
                    Log.Info(elementText + " is Clicked");

                }
                else
                {
                    Log.Error($"Element: '{element.Text}' of type: '{element.TagName}' is not to ready to perform click action.");
                    throw new ElementClickInterceptedException($"Element: '{element.Text}' of type: '{element.TagName}' is not to ready to perform click action.");
                }
            }
            catch (ElementClickInterceptedException e)
            {
                if (executeOnException)
                {
                    // element present in a page but its overlapped on another element and not visible
                    if (e.Message.Contains("Other element would receive the click"))
                    {
                        WebDriverUtil.ScrollToTop(driver);
                        element.Click();
                        driver.VerifyBusyOverlayNotDisplayed();
                    }
                }

            }
        }

        public static void PCFClick(this IWebElement element, IWebDriver driver)
        {
            try
            {
                if (ConfigurationManager.AppSettings["WebDriver"].ToLower() == "edge")
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0);");
                }
                WebDriverUtil.ScrollIntoElement(driver, element);
                if (element.IsElementClickable(driver))
                {
                    string eleText = element.Text;
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", element);
                    Log.Info(eleText + " Element is clicked");
                    driver.PCFVerifyBusyOverlayNotDisplayed();
                }
            }
            catch (Exception)
            {
                Log.Error($"Element: '{element.Text}' of type: '{element.TagName}'is not clickable. ");
                throw;
            }
        }

        //internal static void SetText(this IWebElement element, IWebDriver driver, NetworkCredential defaultNetworkCredentials)
        //{
        //    element.SendKeys(System.Net.CredentialCache.DefaultNetworkCredentials);
        //}

        public static void PCFClick(this By byElement, IWebDriver driver)
        {
            IWebElement element = null;
            try
            {
                if (ConfigurationManager.AppSettings["WebDriver"].ToLower() == "edge")
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0);");
                }
                element = driver.GetElement(byElement);
                WebDriverUtil.ScrollIntoElement(driver, element);
                if (element.IsElementClickable(driver))
                {
                    string eleText = element.Text;
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", element);
                    Log.Info(eleText + " Element is clicked");
                    driver.PCFVerifyBusyOverlayNotDisplayed();
                }

            }
            catch (Exception)
            {
                Log.Error($"Element: '{element.Text}' of type: '{element.TagName}' is not clickable.");
                throw;
            }
        }

        public static void SetText(this IWebElement element, IWebDriver driver, string textToEnter, TimeSpan? waitTime = null)
        {
            try
            {
                bool browserVerification = (ConfigurationManager.AppSettings["WebDriver"].ToLower() == "edge");
                if (browserVerification)
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0);");
                }
                if (waitTime == null) waitTime = GlobalWaitTime;
                driver.VerifyBusyOverlayNotDisplayed();
                element.IsElementClickable(driver);
                element.Click();
                element.Clear();
                element.SendKeys(textToEnter);
                try
                {
                    bool elementFound = new HomePage(driver).LbldsaTitle.IsElementClickable(driver, TimeSpan.FromSeconds(2));
                    if (elementFound)
                        new HomePage(driver).LbldsaTitle.Click();
                    driver.VerifyBusyOverlayNotDisplayed();
                }
                catch (Exception)
                {
                    element.SendKeys(Keys.Tab);
                    driver.VerifyBusyOverlayNotDisplayed();
                }

                Log.Info($"Textbox value is set to: {textToEnter }");
                driver.VerifyBusyOverlayNotDisplayed();
            }
            catch (Exception)
            {
                Log.Error($"Element: '{element.Text}' of type: '{element.TagName}' is not present in the application");
                throw;
            }
        }

        public static void SetText(this By byElement, IWebDriver driver, string textToEnter, TimeSpan? waitTime = null)
        {
            try
            {
                if (ConfigurationManager.AppSettings["WebDriver"].ToLower() == "edge")
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0);");
                }
                if (waitTime == null) waitTime = GlobalWaitTime;
                driver.GetElement(byElement).IsElementClickable(driver);
                driver.VerifyBusyOverlayNotDisplayed();
                driver.GetElement(byElement).SendKeys(Keys.Control + "a");
                driver.GetElement(byElement).SendKeys(Keys.Delete);
                driver.GetElement(byElement).SendKeys(textToEnter);
                driver.VerifyBusyOverlayNotDisplayed();
                try
                {
                    if (new HomePage(driver).LbldsaTitle.IsElementClickable(driver, TimeSpan.FromSeconds(5)))
                        new HomePage(driver).LbldsaTitle.Click();

                }
                catch (Exception)
                {
                    driver.GetElement(byElement).SendKeys(Keys.Tab);
                }
                driver.VerifyBusyOverlayNotDisplayed();
                Log.Info(string.Format("Textbox value is set to '{0}'", textToEnter));
            }
            catch (Exception)
            {
                Log.Error($"Element: '{byElement.ToString()}' is not present in the application");
                throw;
            }
        }

        public static void EnterText(this IWebElement element, IWebDriver driver, string textToEnter, TimeSpan? waitTime = null)
        {
            try
            {
                if (ConfigurationManager.AppSettings["WebDriver"].ToLower() == "edge")
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0);");
                }
                if (waitTime == null) waitTime = GlobalWaitTime;
                driver.VerifyBusyOverlayNotDisplayed();
                element.IsElementClickable(driver);
                WebDriverUtil.JavaScriptClick(driver, element);
                element.SendKeys(Keys.Control + "a");
                element.SendKeys(Keys.Delete);
                element.SendKeys(textToEnter);
                try
                {
                    if (new HomePage(driver).LbldsaTitle.IsElementClickable(driver, TimeSpan.FromSeconds(2)))
                        new HomePage(driver).LbldsaTitle.Click();
                    driver.VerifyBusyOverlayNotDisplayed();
                }
                catch (Exception)
                {
                    element.SendKeys(Keys.Tab);
                    driver.VerifyBusyOverlayNotDisplayed();
                }
                Log.Info($"Textbox value is set to: {textToEnter }");
                driver.VerifyBusyOverlayNotDisplayed();
            }
            catch (Exception)
            {
                Log.Error($"Element : '{element.Text}' of type: '{element.TagName}' is not present in the application");
                throw;
            }
        }

        public static void SetTextChannel(this IWebElement eleToEnterText, IWebDriver driver, string textToEnter, TimeSpan? waitTime = null)
        {

            eleToEnterText.SendKeys(Keys.Control + "a");
            eleToEnterText.SendKeys(Keys.Delete);
            eleToEnterText.SendKeys(textToEnter);
            eleToEnterText.SendKeys(Keys.Tab);
            Log.Info(string.Format("Textbox value is set to '{0}'", textToEnter));

        }

        public static string GetText(this IWebElement element, IWebDriver driver, TimeSpan? waitTime = null, bool waitForTextChange = true)
        {
            string str;
            try
            {
                if (waitTime == null) waitTime = GlobalWaitTime;
                driver.VerifyBusyOverlayNotDisplayed();
                element.IsElementDisplayed(driver, waitTime);
                if (ConfigurationManager.AppSettings["WebDriver"].ToLower() == "edge")
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0);");
                }

                if ((element.TagName == "input" && element.GetAttribute("type") == "text") || (element.TagName == "textarea" && element.GetAttribute("type") == "textarea") || (element.TagName == "input" && element.GetAttribute("type") == "number"))
                {
                    str = element.GetAttribute("value");
                }
                else if (element.TagName == "select")
                {
                    str = new SelectElement(element).SelectedOption.Text;
                }
                else
                {
                    if (waitForTextChange)
                    {
                        driver.WaitFor(
                            v =>
                                !string.IsNullOrWhiteSpace(element.Text) && element.Text != "-" && element.Text != "..." &&
                                element.Text != ". . .",
                            Convert.ToInt32(waitTime.Value.TotalSeconds), true);    
                    }

                    str = element.Text;
                }
                Log.Info(string.Format("Element text is '{0}'", str.Trim()));
                return str.Trim();
            }
            catch (WebDriverException)
            {
                str =
                    ((IJavaScriptExecutor)driver).ExecuteScript("return arguments[1].textContent;", element).ToString();
                Log.Warn(string.Format("[Using Javascript] Element text is '{0}'", element.Text.Trim()));
                return str.Trim();
            }
        }

        public static string GetText(this By byElement, IWebDriver driver, TimeSpan? waitTime = null, bool waitForTextChange = true)
        {
            string str;
            try
            {
                if (waitTime == null) waitTime = GlobalWaitTime;
                driver.VerifyBusyOverlayNotDisplayed();
                //element.WaitForElementVisible(GlobalWaitTime, false);
                driver.GetElement(byElement).IsElementDisplayed(driver, waitTime);
                if (ConfigurationManager.AppSettings["WebDriver"].ToLower() == "edge")
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0);");
                }

                if ((driver.GetElement(byElement).TagName == "input" && driver.GetElement(byElement).GetAttribute("type") == "text") || (driver.GetElement(byElement).TagName == "textarea" && driver.GetElement(byElement).GetAttribute("type") == "textarea") || (driver.GetElement(byElement).TagName == "input" && driver.GetElement(byElement).GetAttribute("type") == "number"))
                {
                    str = driver.GetElement(byElement).GetAttribute("value");
                }
                else if (driver.GetElement(byElement).TagName == "select")
                {
                    str = new SelectElement(driver.GetElement(byElement)).SelectedOption.Text;
                }
                else
                {
                    if (waitForTextChange)
                    {
                        driver.WaitFor(
                            v =>
                                !string.IsNullOrWhiteSpace(driver.GetElement(byElement).Text) && driver.GetElement(byElement).Text != "-" && driver.GetElement(byElement).Text != "..." &&
                                driver.GetElement(byElement).Text != ". . .",
                            Convert.ToInt32(waitTime.Value.TotalSeconds), true);
                    }

                    str = driver.GetElement(byElement).Text;
                }
                Log.Info(string.Format("Element text is '{0}'", str.Trim()));
                return str.Trim();
            }
            catch (WebDriverException)
            {
                str =
                    ((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].textContent;", driver.GetElement(byElement)).ToString();
                Log.Warn(string.Format("[Using Javascript] Element text is '{0}'", driver.GetElement(byElement).Text.Trim()));
                return str.Trim();
            }
        }

        /// <summary>
        /// Verifies and then select's the checkbox
        /// </summary>
        /// <param name="element"></param>
        /// <param name="driver"></param>
        public static void SelectCheckBox(this IWebElement element, IWebDriver driver)
        {
            try
            {
                driver.VerifyBusyOverlayNotDisplayed();
                bool found = element.IsElementDisplayed(driver);
                if (found)
                {
                    string elementText = element.Text;
                    if (!element.Selected)
                    {
                        element.Click(driver);
                        driver.VerifyBusyOverlayNotDisplayed();
                        Log.Info(string.Format("Checked the checkbox element '{0}'", elementText));
                    }
                    else
                        Log.Info(string.Format("Checkbox checked by default '{0}'", elementText));
                }
                else
                {
                    Log.Error("Object is not present in the application");
                    throw new Exception("Object is not present in the application");
                }
            }
            catch (Exception)
            {
                Log.Error($"Exception occurred while accessing the '{element.Text}' of type: '{element.TagName}' ");
            }
        }

        public static void UnSelectCheckBox(this IWebElement element, IWebDriver driver)
        {
            try
            {
                driver.VerifyBusyOverlayNotDisplayed();
                bool found = element.IsElementDisplayed(driver);
                if (found)
                {
                    string elementText = element.Text;
                    if (element.Selected)
                    {
                        element.Click(driver);
                        driver.VerifyBusyOverlayNotDisplayed();
                        Log.Info(string.Format("Un Checked the checkbox element '{0}'", elementText));
                    }
                    else
                        Log.Info(string.Format("Checkbox unchecked by default '{0}'", elementText));
                }
                else
                {
                    Log.Error("Object is not present in the application");
                }
            }
            catch (Exception)
            {
                Log.Error($"Exception occurred while accessing the '{element.Text}' of type: '{element.TagName}' ");
            }
        }

        public static void PickDropdownByText(this IWebElement element, IWebDriver driver, string text)
        {
            try
            {
                if (ConfigurationManager.AppSettings["WebDriver"].ToLower() == "edge")
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0);");
                }
                driver.VerifyBusyOverlayNotDisplayed();
                element.IsElementClickable(driver, TimeSpan.FromSeconds(5));
                new SelectElement(element).SelectByText(text);
                Log.Info(string.Format("Dropdown selected by specified text: {0}", text));
                driver.VerifyBusyOverlayNotDisplayed();
            }
            catch (Exception)
            {
                element.SetText(driver, text);
                Log.Error(string.Format("Dropdown selected by specified text: using SendKeys {0}", text));
                Log.Error($"Exception with the element: '{element.Text}' of type: '{element.TagName}' ");
            }
            //finally
            //{
            //    element.SendKeys(Keys.Tab);
            //}
        }

        public static void PickDropdownByIndex(this IWebElement element, IWebDriver driver, int index)
        {
            try
            {
                if (ConfigurationManager.AppSettings["WebDriver"].ToLower() == "edge")
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0);");
                }

                driver.VerifyBusyOverlayNotDisplayed();
                element.IsElementClickable(driver);
                new SelectElement(element).SelectByIndex(index);
                element.SendKeys(Keys.Tab);

                //try
                //{
                //    if (new HomePage(driver).LbldsaTitle.IsElementClickable(driver, TimeSpan.FromSeconds(5)))
                //        new HomePage(driver).LbldsaTitle.Click();
                //}
                //catch (Exception)
                //{
                //    element.SendKeys(Keys.Tab);
                //    driver.VerifyBusyOverlayNotDisplayed();
                //}
                Log.Info(string.Format("Dropdown selected by specified index: {0}", index));
            }
            catch (Exception)
            {
                Log.Error($"Element: '{element.Text}' of type: '{element.TagName}' is not present in the application");
                throw;
            }
        }

        public static void PickDropdownByValue(this IWebElement element, IWebDriver driver, string value)
        {
            try
            {
                if (ConfigurationManager.AppSettings["WebDriver"].ToLower() == "edge")
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0);");
                }

                driver.VerifyBusyOverlayNotDisplayed();
                element.IsElementClickable(driver);
                new SelectElement(element).SelectByValue(value);
                element.SendKeys(Keys.Tab);
                driver.VerifyBusyOverlayNotDisplayed();
                //new HomePage(driver).LbldsaTitle.Click();
                //try
                //{
                //    if (new HomePage(driver).LbldsaTitle.IsElementClickable(driver, TimeSpan.FromSeconds(5)))
                //        new HomePage(driver).LbldsaTitle.Click();
                //}
                //catch (Exception)
                //{
                //    element.SendKeys(Keys.Tab);
                //    driver.VerifyBusyOverlayNotDisplayed();
                //}
                Log.Info(string.Format("Dropdown selected by specified value: {0}", value));
            }
            catch (Exception)
            {
                Log.Error($"Element: '{element.Text}' of type: '{element.TagName}' is not present in the application");
                throw;
            }
        }

        public static List<String> PickDropdownOptions(this IWebElement element, IWebDriver driver)
        {
            List<String> allText = new List<String>();
            try
            {

                foreach (IWebElement ele in new SelectElement(element).Options)
                    allText.Add(ele.Text);
            }
            catch (Exception)
            {
                Log.Error($"Exception while getting options from Dropdown: '{element.Text}' of type: '{element.TagName}'");
            }
            return allText;
        }

        #endregion

        public static bool IsElementClickable(this IWebElement element, IWebDriver driver, TimeSpan? waitTime = null)
        {

            try
            {
                element.IsElementDisplayed(driver, GlobalWaitTime);
                if (ConfigurationManager.AppSettings["WebDriver"] == "RemoteWebDriver" && ConfigurationManager.AppSettings["RunInSauceLabs"] == "True")
                {
                    return true;
                }
                if (waitTime == null) waitTime = GlobalWaitTime;
                var wait = new WebDriverWait(driver, waitTime.Value);
                wait.Until(ExpectedConditions.ElementToBeClickable(element));
                return true;
            }
            catch (StaleElementReferenceException e)
            {
                Log.Error(e.Message);
                return false;

            }

        }

        public static bool TryFindElement(this IWebDriver driver, IWebElement element, TimeSpan? waitTime = null)
        {
            try
            {
                if (waitTime == null)
                    waitTime = GlobalWaitTime; // If no Wait time set from the page class, then use the default.
                driver.VerifyBusyOverlayNotDisplayed();
                //element.WaitForElementVisible(waitTime.Value, false);
                element.WaitForElementDisplayed(waitTime.Value, false);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public static bool IsElementDisplayed(this IWebElement element, IWebDriver driver, TimeSpan? waitTime = null)
        {
            try
            {
                if (waitTime == null) waitTime = GlobalWaitTime;
                //element.WaitForElementVisible(waitTime.Value, false);
                element.WaitForElementDisplayed(waitTime.Value, false);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static IList<IWebElement> GetElements(this IWebElement element, IWebDriver driver, By by, TimeSpan? waitTime = null)
        {

            if (waitTime == null)
            {
                waitTime = GlobalWaitTime;
            }

            element.IsElementClickable(driver);            
            driver.VerifyBusyOverlayNotDisplayed();
            List<IWebElement> children = element.FindElements(by, waitTime.Value).Where(a => a.Displayed).ToList();
            Log.Info(" List of elements found." + children.Count);
            return children;
        }

        public static IWebElement GetChildElement(this IWebElement element, By by, TimeSpan? waitTime = null)
        {
            if (waitTime == null)
            {
                waitTime = GlobalWaitTime;
            }

            element.WaitForElement(by, waitTime.Value);
            return element.FindElement(by, waitTime.Value);
        }

        public static bool FindElementBy(this IWebDriver driver, By locator, TimeSpan? waitTime = null)
        {
            try
            {
                driver.VerifyBusyOverlayNotDisplayed();
                if (waitTime == null) waitTime = GlobalWaitTime;
                var wait = new WebDriverWait(driver, waitTime.Value);
                wait.Until(ExpectedConditions.ElementIsVisible(locator));

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Waits for the element to enabled.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="driver"></param>
        /// <returns></returns>
        public static bool WaitForElement(this IWebElement element, IWebDriver driver)
        {
            try
            {
                var wait = new WebDriverWait(driver, GlobalWaitTime);
                return wait.Until(d => element.Enabled);
            }
            catch (Exception)
            {
                Log.Error("Timed Out : Element not Enabled : " + element.Text);
                return false;
            }
        }

        public static bool IsAttribtuePresent(this IWebElement element, IWebDriver driver, string attribute)
        {
            bool result = false;
            try
            {
                string value = element.GetAttribute(attribute);
                if (value != null)
                {
                    result = true;
                    Log.Info("Attribute =" + value);
                }
            }
            catch (Exception)
            {
                Log.Error($"The element: '{element.Text}' of type: '{element.TagName}' is no longer valid");
                return false;
            }

            return result;
        }      

        /// <summary>
        /// Finds the table element from the provided web element and returns contents of it.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="by">By</param>
        /// <returns>list of table contents</returns>
        public static List<Dictionary<string, object>> GetHtmlTableData(this IWebElement divElement, IWebDriver driver)
        {
            driver.VerifyBusyOverlayNotDisplayed();

            divElement.WaitForElementVisible(GlobalWaitTime);
            // var divElement = driver.GetElement(by);
            var tableElement = divElement.FindElement(By.CssSelector("table"), GlobalWaitTime);
            var tableData = BuildTableData(tableElement, driver);
            Log.Info("Table Data =" + tableData);
            return tableData;
        }

        /// <summary>
        /// Builds Header and Body data in a table element and returns it.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="driver"></param>
        /// <returns></returns>
        private static List<Dictionary<string, object>> BuildTableData(IWebElement element, IWebDriver driver)
        {
            var tableData = new List<Dictionary<string, object>>();
            const string columnHeaderCaption = "Column";

            var headers = element.FindElements(By.CssSelector("thead > tr > th")); // Get all the header elements
            var rows = element.FindElements(By.CssSelector("tbody > tr")); // Get all the row elements
            foreach (var row in rows) // Loop through all the <tr> elements in a row
            {
                var tds = row.FindElements(By.CssSelector("td")); // Get all <td> elements inside a row or <tr> element
                var data = new Dictionary<string, object>();
                int index = 0;
                foreach (var td in tds) // Loop through all the <td> elements in a row
                {
                    string columnHeader;
                    if (string.IsNullOrWhiteSpace(headers[index].Text))
                        columnHeader = columnHeaderCaption + (index + 1);
                    // Sometimes there may be more than one blank headers in a table
                    else
                        columnHeader = headers[index].Text;

                    data.Add(columnHeader, td.Text); // Add the data in a dictionary
                    index++;
                }

                tableData.Add(data);
            }

            Log.Info("Html table data recived. Row Count: " + tableData.Count + "; Coulumn Count: " +
                         tableData[0].Keys.Count);
            return tableData;
        }

        private static List<Dictionary<string, object>> BuildTableDataForAposGrid(IWebElement element, IWebDriver driver)
        {
            var tableData = new List<Dictionary<string, object>>();
            const string columnHeaderCaption = "Column";

            var headers = element.FindElements(By.XPath("//*[contains(@class, 'ag-header-cell dsa-agrid-header')]")); // Get all the header elements
            var rowContainer = element.FindElement(By.XPath("//*[contains(@class, 'ag-full-width-container')]"));
            var rows = rowContainer.FindElements(By.CssSelector("div[role='row']")); // Get all the row elements
            foreach (var row in rows) 
            {
                var cells = row.FindElements(By.CssSelector("apos-grid-row-service-tag > div > div.ag-results-grid-cell")); 
                var data = new Dictionary<string, object>();
                int index = 0;
                foreach (var cell in cells)
                {
                    string columnHeader = string.IsNullOrWhiteSpace(headers[index].Text)
                        ? columnHeaderCaption + (index + 1)
                        : headers[index].Text;
                    data.Add(columnHeader, cell.Text);
                    index++;
                }               
                tableData.Add(data);
            }

            Log.Info("Grid table data received. Row Count: " + tableData.Count + "; Coulumn Count: " +
                         tableData[0].Keys.Count);
            return tableData;
        }

        /// <summary>
        /// Gets contents of a table or grid
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="by">By</param>
        /// <returns>list of table contents</returns>
        public static List<Dictionary<string, object>> GetTableData(this IWebElement tableElement, IWebDriver driver)
        {
            driver.VerifyBusyOverlayNotDisplayed();
            tableElement.WaitForElementVisible(GlobalWaitTime);            
            var tableData = BuildTableData(tableElement, driver);
            Log.Info("Table Data " + tableData);
            return tableData;
        }

        public static List<Dictionary<string, object>> GetGridTableData(this IWebElement tableElement, IWebDriver driver)
        {
            driver.VerifyBusyOverlayNotDisplayed();
            tableElement.WaitForElementVisible(GlobalWaitTime);
            var tableData = BuildTableDataForAposGrid(tableElement, driver);
            Log.Info("Table Data " + tableData);
            return tableData;
        }

        public static List<Dictionary<string, object>> GetGridData(this IWebElement gridElement, IWebDriver driver)
        {
            driver.VerifyBusyOverlayNotDisplayed();
            gridElement.WaitForElementVisible(GlobalWaitTime);

            var gridData = new List<Dictionary<string, object>>();
            const string columnHeaderCaption = "Column";

            var headers = gridElement.FindElements(By.XPath(@"//*[contains(@class, 'ag-header-cell-text')]"));
            var rowContainer = gridElement.FindElement(By.XPath("//*[contains(@class, 'ag-full-width-container')]"));
            var rows = rowContainer.FindElements(By.CssSelector("div[role='row']")); // Get all the row elements
            foreach (var row in rows)
            {
                var columns = row.FindElements(By.CssSelector("results-grid-row-renderer > div > div > div.ag-results-grid-cell")); // Get all the column elements
                var data = new Dictionary<string, object>();
                int index = 0;
                foreach (var column in columns)
                {
                    string columnHeader = string.IsNullOrWhiteSpace(headers[index].Text)
                        ? columnHeaderCaption + (index + 1)
                        : headers[index].Text;
                    data.Add(columnHeader, column.Text);
                    index++;
                }
                gridData.Add(data);
            }
            Logger.Write("Angular grid data recived. Row Count: " + gridData.Count + "; Coulumn Count: " +
                gridData[0].Keys.Count);
            return gridData;

        }
      
        public static Catalogs GetCatalogFromString(string catalogName)
        {
            Catalogs catalog = (Catalogs)Enum.Parse(typeof(Catalogs), catalogName);
            Log.Info("Catalog : " + catalog);
            return catalog;
        }

        public static void WaitUntilTextChanges(this IWebElement element, IWebDriver driver, string text,
            TimeSpan? waitTime = null)
        {
            if (waitTime == null)
                waitTime = GlobalWaitTime; // If no Wait time set from the page class, then use the default.

            WebDriverWait wait = new WebDriverWait(driver, waitTime.Value);
            wait.Until(ExpectedConditions.TextToBePresentInElement(element, text));
        }

        public static Dictionary<string, ProductSearchType> GetProductDataFromCsv(string orderCodes = null,
            string skus = null)
        {
            var products = new Dictionary<string, ProductSearchType>();

            if (orderCodes != null)
            {
                foreach (string orderCode in orderCodes.Split(','))
                {
                    if (!string.IsNullOrEmpty(orderCode))
                        products.Add(orderCode.ToLower(), ProductSearchType.OrderCode);
                }
            }

            if (skus != null)
            {
                foreach (string orderCode in skus.Split(','))
                {
                    if (!string.IsNullOrEmpty(orderCode))
                        products.Add(orderCode.ToLower(), ProductSearchType.SkuId);
                }
            }
            Log.Info("Products : " + products);
            return products;
        }

        public static void SwitchWindowByTitle(this IWebDriver driver, string title)
        {
            bool bfound = false;
            Log.Info("Found " + driver.WindowHandles.Count() + " windows associated with driver.");
            foreach (string window in driver.WindowHandles)
            {
                driver.SwitchTo().Window(window);
                string curTitle = driver.Title;
                if (curTitle.Equals(title))
                {
                    Log.Info("Window Switched to " + title);
                    bfound = true;
                    break;
                }
            }
            if (!bfound)
            {
                driver.SwitchTo().Window(WebDriverUtil.ParentHandler);
                Log.Error("No window matched!!");
            }
        }

        public static void WaitForPageLoad(this IWebDriver driver)
        {
            driver.WaitForPageLoad(TimeSpan.FromSeconds(130), false);
        }
        public static void TakeScreenshot(this IWebDriver driver, TestContext testContext)
        {
            string snapshotlocation = testContext.TestRunDirectory + @"\FailureScreenshots";
            try
            {
                if (!Directory.Exists(snapshotlocation)) Directory.CreateDirectory(snapshotlocation);
                string imageFileName = DateTime.Now.Ticks.ToString();
                var screenShotFileName = snapshotlocation + "\\" + imageFileName + ".jpeg";
                ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(screenShotFileName, ScreenshotImageFormat.Jpeg);
                testContext.AddResultFile(screenShotFileName);
                Log.Info("Screenshot File Path: " + screenShotFileName);
            }
            catch (Exception ex)
            {
                Logger.Write(ex.Message);
            }

        }       

        #region OSC wait

        public static bool WaitAnimationToLoad(IWebDriver driver)
        {
            // var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));

            //Waiting for animation
            WaitingForSpinner(WaitAnimation, driver);

            //Waiting for pleasewaitoverlay animation
            WaitingForSpinner(WaitAnimation2, driver);

            //wait for the spinner disappear, if it shows up, otherwise it won't waiting
            WaitingForSpinner(Spinner, driver);

            // wait for loading... disappeared in tab initializing, in add product tab, groups tab, description/history tab
            WaitingForSpinner(ByLoadingText, driver);

            //please waiting animation in groups tab operation
            WaitingForSpinner(GroupWaitingOverlay, driver);

            //waiting for tree expanding spinner disappear,  if it shows up, otherwise it won't waiting
            WaitingForSpinner(CategoryExpandingWaitingSpinnerBy, driver);

            //Waiting for the loading disappeared from configuration tab, if it shows up, otherwise it won't waiting
            //wait.Until<bool>(
            //d =>
            //    Tabss.FirstOrDefault(t => t.Text.Contains("Configuration") && t.Text.Contains("Loading")) ==
            //    null);

            return true;
        }

        #endregion

        #region ElementsAndMethods

        /// <summary>
        /// Element to locate the title "Solution Configurator" on the page </summary>
        public static By WaitAnimation
        {
            get { return By.XPath(".//*[@class='pleaseWaitImage']"); }
        }

        ///<summary>
        ///Elemenet to location wait animation - that blocks page for a while        
        /// </summary>
        public static By WaitAnimation2
        {
            get { return By.XPath(".//*[@class='pleaseWaitOverlay']"); }
        }

        /// <summary>
        /// Loading after search product in CP/Gii EMEA/APJ
        /// </summary>
        public static By LoadingContainer
        {
            get { return By.CssSelector(".uif_gridLoadingContainer"); }
        }

        /// <summary>
        /// please waiting animation in groups tab operation
        /// </summary>
        public static By GroupWaitingOverlay
        {
            get { return By.Id("composerTabGroupsOverlay"); }
        }

        /// <summary>
        /// Locate the Spinner web element
        /// </summary>
        public static By Spinner
        {
            get { return By.XPath(".//div[contains(@class,'spinner')]"); }
        }

        /// <summary>
        /// Locate the catalog expanding spinner
        /// </summary>
        public static By CategoryExpandingWaitingSpinnerBy
        {
            get { return By.XPath(".//*[@class='smaller spinner']"); }
        }

        /// <summary>
        /// Waits for the loading wait animation to load and returns true when it completes loading
        /// Merge all the spinner, loading wait animation, for the animation isn't displayed, make sure it won't wait
        /// </summary>
        /// <returns>true when the animation is no longer visible</returns>
        /// 
        public static By ByLoadingText
        {
            get { return By.XPath(".//div[contains(., 'Loading') and not(*)]"); }
        }

        /// <summary>
        /// Locate all the tabs
        /// </summary>
        public static bool WaitUntilItsClickable(IWebElement button, IWebDriver driver)
        {
            bool notClickable = true;

            while (notClickable)
            {
                try
                {
                    //var browserName = ((RemoteWebDriver)driver).Capabilities.BrowserName;
                    var browserName = ((RemoteWebDriver)driver).Capabilities;
                    if (browserName.GetCapability("browser").ToString() == "internet explorer" || browserName.GetCapability("browser").ToString() == "firefox")
                    {
                        IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                        js.ExecuteScript("arguments[0].click();", button);
                    }
                    else
                    {
                        button.Click();
                    }
                    return true;
                }
                catch
                {
                }
                try
                {
                    IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                    js.ExecuteScript("arguments[0].click();", button);
                    return true;
                }
                catch
                {
                }
            }
            throw new Exception("Unable to click the desired button");
        }

        public static bool WaitForWaitAnimationToLoad(IWebDriver driver)
        {
            var wait = new WebDriverWait(driver, WebDriverUtil.WaitTime);

            //Waiting for animation
            WaitingForSpinner(WaitAnimation, driver);

            //Waiting for pleasewaitoverlay animation
            WaitingForSpinner(WaitAnimation2, driver);

            //wait for the spinner disappear, if it shows up, otherwise it won't waiting
            WaitingForSpinner(Spinner, driver);

            // wait for Loading after search product in CP/Gii EMEA/APJ
            WaitingForSpinner(LoadingContainer, driver);

            // wait for loading... disappeared in tab initializing, in add product tab, groups tab, description/history tab
            WaitingForSpinner(ByLoadingText, driver);

            //please waiting animation in groups tab operation
            WaitingForSpinner(GroupWaitingOverlay, driver);

            //waiting for tree expanding spinner disappear,  if it shows up, otherwise it won't waiting
            WaitingForSpinner(CategoryExpandingWaitingSpinnerBy, driver);

            //waiting for tree expanding spinner disappear,  if it shows up, otherwise it won't waiting
            WaitingForSpinner(By.XPath("//div[@class='spinnerMask']"), driver);

            return true;
        }

        private static void WaitingForSpinner(By spinnerBy, IWebDriver driver)
        {
            var wait = new WebDriverWait(driver, WebDriverUtil.WaitTime);
            wait.Until<bool>(
                delegate
                {
                    try
                    {
                        var spinners = driver.FindElements(spinnerBy);
                        Log.Info("Spinners :" + spinners);
                        return !spinners.Any(spinner => spinner.Displayed);
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                });
        }

        private static RNGCryptoServiceProvider _RNG = new RNGCryptoServiceProvider();

        public static int GetNextRnd(int min, int max)
        {
            byte[] rndBytes = new byte[4];
            _RNG.GetBytes(rndBytes);
            int rand = BitConverter.ToInt32(rndBytes, 0);
            const Decimal OldRange = (Decimal)int.MaxValue - (Decimal)int.MinValue;
            Decimal NewRange = max - min;
            Decimal NewValue = ((Decimal)rand - (Decimal)int.MinValue) / OldRange * NewRange + (Decimal)min;
            return (int)NewValue;
        }

        /// <summary>
        /// This Method will return the by Locator (Xpath) when we pass a the fixed xPath as String which has a Text to replace with other Text to identify other Locator
        /// 'textToRepalce' string must be placed/write as same and present in the String that is passing as  param name="xPathAsString" which will will be repalced by the param name="textToRepalce" and returns Xpath Locator
        /// </summary>
        /// <param name="xPathAsString">Ex: "//div[@id='customerDetails_locationsGrid']//table[@id='DataTables_Table_0']////th[Text()='textToRepalce']"</param>
        /// <param name="textToRepalce">Ex: "Company"</param>
        /// <returns>By Locator Ex:By.XPath("//div[@id='customerDetails_locationsGrid']//table[@id='DataTables_Table_0']////th[Text()='Company']")</returns>
        public static By GetLocatorWithText(string xPathAsString, string textToRepalce)
        {
            By byLocator = By.XPath(xPathAsString.Replace("textToRepalce", textToRepalce));

            return byLocator;
        }

        #endregion ElementsAndMethods

        #region SolutionsRelated - Please DND

        //SetText method check if busyoverylay is displayed. This does not happen in solutions flow, and this check is hampering the performance.
        //Hence using the below method only for solutions related flow
        public static void SetTextForSolution(this IWebElement element, IWebDriver driver, string textToEnter,
            TimeSpan? waitTime = null)
        {
            if (waitTime == null)
            {
                waitTime = GlobalWaitTime;
            }
            try
            {
                var wait = new WebDriverWait(driver, waitTime.Value);
                wait.Until(ExpectedConditions.ElementToBeClickable(element));
                //element.IsElementClickable(driver);
                //element.WaitForElementVisible(waitTime.Value, false);
                string elementText = element.Text;
                element.Clear();
                element.SendKeys(textToEnter);
                element.SendKeys(Keys.Tab);
                //new HomePage(driver).LbldsaTitle.Click();
                Log.Info(string.Format("Textbox value is set to '{0}'", textToEnter));
            }
            catch (Exception)
            {
                Log.Error($"Element: '{element.Text}' of type: '{element.TagName}' is not present in the application");
                throw;
            }
        }

        #endregion


        #region 0 References 

        //public static void SetTextChannel(this By byLocator, IWebDriver driver, string textToEnter, TimeSpan? waitTime = null)
        //{
        //    IWebElement eleToEnterText = null;
        //    eleToEnterText = driver.GetElement(byLocator, waitTime);
        //    eleToEnterText.SendKeys(Keys.Control + "a");
        //    eleToEnterText.SendKeys(Keys.Delete);
        //    eleToEnterText.SendKeys(textToEnter);
        //    eleToEnterText.SendKeys(Keys.Tab);
        //    Log.Info(string.Format("Textbox value is set to '{0}'", textToEnter));
        //}


        //public static void ElementTextNotPresent(this IWebElement element, IWebDriver driver, string strToVerfiy, TimeSpan? waitTime = null)
        //{
        //    if (waitTime == null) waitTime = GlobalWaitTime;
        //    driver.VerifyBusyOverlayNotDisplayed();
        //    if (element.IsElementDisplayed(driver, waitTime))
        //    {
        //        if (!element.GetText(driver).Contains(strToVerfiy))
        //        {
        //            Log.Info("This string is not present as expected : " + strToVerfiy);
        //        }
        //        else
        //        {
        //            Log.Error("This string is present : " + strToVerfiy);
        //        }
        //    }
        //    else
        //    {
        //        Log.Error("Element is not present :");
        //        throw new NoSuchElementException("Element is not present");
        //    }
        //}

        //public static void ElementTextPresent(this IWebElement element, IWebDriver driver, string strToVerfiy, TimeSpan? waitTime = null)
        //{
        //    if (waitTime == null) waitTime = GlobalWaitTime;
        //    driver.VerifyBusyOverlayNotDisplayed();
        //    if (element.IsElementDisplayed(driver, waitTime))
        //    {
        //        if (element.GetText(driver).Contains(strToVerfiy))
        //        {
        //            Log.Info("This string is present as expected : " + strToVerfiy);
        //        }
        //        else
        //        {
        //            Log.Error("This string is not present : " + strToVerfiy);
        //        }
        //    }
        //    else
        //    {
        //        Log.Error("Element is not present :");
        //        throw new NoSuchElementException("Element is not present");
        //    }
        //}


        ///// <summary>
        ///// sort the given grid by clicking on header of given column
        ///// </summary>
        ///// <param name="driver"></param>
        ///// <param name="gridId"></param>
        ///// <param name="column"></param>
        //public static void SortGridBy(this IWebElement grid, IWebDriver driver, string column)
        //{
        //    driver.VerifyBusyOverlayNotDisplayed();

        //    //var grid = driver.GetElement(By.Id(gridId));
        //    var headerLink = grid.FindElements(By.TagName("th")).FirstOrDefault(e => e.Text.Equals(column));
        //    if (headerLink == null)
        //        throw new NoSuchElementException(string.Format("Cannot find column header {0}", column));
        //    headerLink.Click();

        //    Log.Info(string.Format(" Grid sorted by column: {0}", column));
        //} // Reference having 0 reference //

        //public static string ConvertRgbToHex(string strgb)
        //{
        //    string[] numbers = strgb.Replace("rgba(", "").Replace(")", "").Split(',');
        //    int number1 = int.Parse(numbers[0]);
        //    numbers[1] = numbers[1].Trim();
        //    int number2 = int.Parse(numbers[1]);
        //    numbers[2] = numbers[2].Trim();
        //    int number3 = int.Parse(numbers[2]);
        //    string strhex = string.Format("#{0:X2}{1:X2}{2:X2}", number1, number2, number3).ToLower();
        //    return strhex;
        //} // Reference having 0 reference //

        #endregion


    }
}