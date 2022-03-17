using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Utils;
using System.Data;
using System.IO;
using System.Net;
using System.Reflection;
using Dell.Adept.UI.Web.Testing.Framework;
using Microsoft.Edge.SeleniumTools;
using OpenQA.Selenium.Chrome;
using System.Text;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;

namespace DsaTest.TestCases
{
    [TestClass]
    public class DsaTestCaseBase : WebUIMsTestBase
    {
        //public static string runSettingsInputXMLFolderPath = "";
        public DsaTestCaseBase()
        {
            BeforeRemoteWebDriverInitialized += DsaTestCaseBase_BeforeRemoteWebDriverInitialized;
        }

        /// <summary>
        /// Timeout
        /// </summary>
        public TimeSpan? WebDriverTimeout { get; set; }

        void DsaTestCaseBase_BeforeRemoteWebDriverInitialized(object sender, RemoteWebDriverEventArgs e)
        {
            Logger.Write("Executing tests with RemoteWebDriver...");

            if (!bool.Parse(ConfigurationManager.AppSettings["RunInSauceLabs"]))
            {
                dynamic internalGridOptions;

                switch (ConfigurationManager.AppSettings["GridBrowserName"].ToLower())
                {
                    case "chrome":
                        internalGridOptions = new ChromeOptions();
                        ChromeOptions chromeOptions = new ChromeOptions();
                        chromeOptions.AddUserProfilePreference("download.default_directory", @"\\W10DTVB9R2\Samuel_G\Sandeep");
                        internalGridOptions = chromeOptions;
                        break;
                    case "internetexplorer":
                        internalGridOptions = new InternetExplorerOptions();
                        break;
                    case "firefox":
                        internalGridOptions = new FirefoxOptions();
                        break;
                    case "edge":
                        internalGridOptions = new Microsoft.Edge.SeleniumTools.EdgeOptions(); // use the new Microsoft.Edge for new Edge (Chromium) instead of OpenQA.Selenium.Edge
                        break;
                    case "legacyedge":
                        internalGridOptions = new OpenQA.Selenium.Edge.EdgeOptions(); // use OpenQA.Selenium.Edge for legacy edge
                        break;
                    default:
                        internalGridOptions = new ChromeOptions();
                        break;
                }

                e.Options.Uri = new Uri(ConfigurationManager.AppSettings["InternalGridHubUrl"]);
                e.Options.WebDriverOptions = internalGridOptions;
                WebDriverTimeout = TimeSpan.FromMinutes(10);
            }
            else
            {
                e.Options.Uri = new Uri(ConfigurationManager.AppSettings["SauceLabsGridHubUrl"]);
                var sauceLabsDriverOptions = ResolveBrowserDriverOptions(ConfigurationManager.AppSettings["GridBrowserName"]);
                e.Options.WebDriverOptions = sauceLabsDriverOptions;
            }
        }


        #region NonTest Code


        [AssemblyInitialize]
        public static void TestAssemblyInitialize(TestContext testContext)
        {
            try
            {
                //Reading Test executable directory path and splitting and to copy only till root path like c:\\DSA\Dsa-test-automation
                var exePath = Environment.CurrentDirectory.Split('\\');
                StringBuilder dirPath = new StringBuilder("", 1000);
                Console.WriteLine("exepath: " + exePath);
                Console.WriteLine("dirpath: " + dirPath);
                foreach (string pathStr in exePath)
                {
                    if (!pathStr.Contains("TestResult"))
                    {
                        dirPath.Append(pathStr);
                        dirPath.Append("\\");

                    }
                    else
                    {
                        break;
                    }

                }
                Console.WriteLine("dirpath: " + dirPath);
                var dirPathValue = dirPath.Remove(dirPath.Length - 1, 1);//to remove diretory path extra slash at end
                string testDatasourceDirPath = dirPathValue + testContext.Properties["LocalBuild"].ToString() + testContext.Properties["LocalBuildBinReleasePath"].ToString() + testContext.Properties["LocalTestDataPath"].ToString();
                string testDeploymentDirPath = testContext.DeploymentDirectory.ToString() + "\\TestData";
                DirectoryInfo sourceDir = new DirectoryInfo(testDatasourceDirPath);
                Console.WriteLine("testdatasourcedirpath:" + testDatasourceDirPath);
                Console.WriteLine("sourcedir: " + sourceDir);
                Directory.CreateDirectory(testDeploymentDirPath);
                string testDataDestDirPath = ".\\TestData";
                DirectoryInfo destDir = new DirectoryInfo(testDataDestDirPath);
                Console.WriteLine("destDir: " + destDir);
                foreach (FileInfo file in sourceDir.GetFiles("*.*", SearchOption.TopDirectoryOnly))
                {
                    //file.CopyTo(Path.Combine(destDir.FullName, file.Name), true);
                    file.CopyTo(Path.Combine(testDeploymentDirPath, file.Name), true);
                }
                //Directory.CreateDirectory(testDestDirPath);
                //foreach (FileInfo file in sourceDir.GetFiles("*.*", SearchOption.TopDirectoryOnly))
                //    file.CopyTo(Path.Combine(testDestDirPath, file.Name), true);
                Console.WriteLine("testdeplymentdirpath: " + testDeploymentDirPath);
            }
            catch (DirectoryNotFoundException ex)
            {
                Logger.Write(ex.Message);
                Logger.Write("Test started although no test data file provided.");
            }
            catch (Exception e)
            {
                Logger.Write(e.Message);
                throw;
            }

        }

        //// Use ClassInitialize to run code before running the first test in the class
        /// <summary>
        /// Tests the class initialize.
        /// </summary>
        /// <param name="testContext">The test context.</param>
        [ClassInitialize()]
        public static void TestClassInitialize(TestContext testContext)
        {
            //BaseClassInitialize(testContext); //Do not remove this line
        }


        //
        // Use TestInitialize to run code before running each test 
        /// <summary>
        /// Tests the initialize.
        /// </summary>
        [TestInitialize()]
        public virtual void TestInitialize()
        {
            try
            {
                string navigateUrl = TestContext.Properties["BaseUrl"].ToString();
                string userName = ConfigurationManager.AppSettings["UserName"];
                TestWebDriver.NavigateHomePage(navigateUrl, userName);
                TestWebDriver.VerifyBusyOverlayNotDisplayed();
            }
            catch (Exception e)
            {
                Logger.Write(e.Message);
                TestWebDriver.Dispose();
                throw;
            }
        }

        // Use TestCleanup to run code after each test has run
        /// <summary>
        /// Tests the cleanup
        /// </summary>
        [TestCleanup()]
        public void TestCleanup()
        {
            try
            {
                if (TestContext.CurrentTestOutcome != UnitTestOutcome.Passed)
                {
                    TestWebDriver.TakeScreenshot(TestContext);
                }

                if (bool.Parse(ConfigurationManager.AppSettings["RunInSauceLabs"]) && ConfigurationManager.AppSettings["WebDriver"] == "RemoteWebDriver")
                {
                    IJavaScriptExecutor jse = (IJavaScriptExecutor)TestWebDriver;
                    jse.ExecuteScript("sauce:job-result=" +
                                      (TestContext.CurrentTestOutcome == UnitTestOutcome.Passed
                                          ? "passed"
                                          : "failed"));
                }

                TestWebDriver.Close();
                AppDomain.CurrentDomain.ProcessExit += (s, e) => TestWebDriver.Close();
            }
            catch (Exception e)
            {
                Logger.Write(e.Message);
                TestWebDriver.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Resolves the BrowserOptions for SauceLabs based on the browser selected in App.config file.
        /// </summary>
        protected dynamic ResolveBrowserDriverOptions(string browserName)
        {
            var sauceOptions = new Dictionary<string, object>();
            dynamic browserOptions;

            switch (browserName.ToLower())
            {
                case "chrome":
                    browserOptions = new ChromeOptions();
                    browserOptions.UseSpecCompliantProtocol = true;
                    browserOptions.PlatformName = ConfigurationManager.AppSettings["GridPlatform"];
                    browserOptions.BrowserVersion = "latest";
                    break;

                case "legacyedge":
                    browserOptions = new OpenQA.Selenium.Edge.EdgeOptions(); // legacy Edge
                    browserOptions.PlatformName = ConfigurationManager.AppSettings["GridPlatform"];
                    browserOptions.BrowserVersion = "latest";
                    break;

                case "edge":
                    browserOptions = new Microsoft.Edge.SeleniumTools.EdgeOptions(); // edge chromium
                    browserOptions.UseChromium = true;
                    browserOptions.PlatformName = ConfigurationManager.AppSettings["GridPlatform"];
                    browserOptions.BrowserVersion = "latest";
                    break;

                case "firefox":
                    browserOptions = new FirefoxOptions();
                    browserOptions.PlatformName = ConfigurationManager.AppSettings["GridPlatform"];
                    browserOptions.BrowserVersion = "latest";
                    break;

                case "internetexplorer":
                    browserOptions = new InternetExplorerOptions();
                    browserOptions.PlatformName = ConfigurationManager.AppSettings["GridPlatform"];
                    browserOptions.BrowserVersion = "latest";
                    break;

                case "safari":
                    browserOptions = new SafariOptions();
                    browserOptions.PlatformName = ConfigurationManager.AppSettings["GridPlatform"];
                    browserOptions.BrowserVersion = "latest";
                    break;

                default:
                    browserOptions = new ChromeOptions();
                    browserOptions.UseSpecCompliantProtocol = true;
                    browserOptions.PlatformName = ConfigurationManager.AppSettings["GridPlatform"];
                    browserOptions.BrowserVersion = "latest";
                    break;
            }

            sauceOptions.Add("username", ConfigurationManager.AppSettings["SauceLabsUserName"]);
            sauceOptions.Add("accessKey", ConfigurationManager.AppSettings["SauceLabsAccessKey"]);
            sauceOptions.Add("tunnelIdentifier", TestContext.Properties["SauceLabsTunnelIdentifier"].ToString());
            sauceOptions.Add("parentTunnel", ConfigurationManager.AppSettings["SauceLabsParentTunnelName"]);
            sauceOptions.Add("name", TestContext.TestName);
            sauceOptions.Add("screenResolution", "1920x1080");

            browserOptions.AddAdditionalCapability("sauce:options", sauceOptions, true);
            
            return browserOptions;

        }

        #endregion
    }
}