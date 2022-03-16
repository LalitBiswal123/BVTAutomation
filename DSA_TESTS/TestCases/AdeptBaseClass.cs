using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using Dell.Adept.Core.Testing;
using Dell.Adept.UI.Web.Testing.Framework;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dell.Adept.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
//using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Remote;

namespace DsaTest.TestCases
{
    [TestClass]
    public abstract class AdeptBaseClass : MsTestBase
    {
        #region Constants

        /// <summary>
        /// The web driver to use for test.
        /// </summary>
        //private static IWebDriver testWebDriver;
        private const string TestConfigurationName = "__Tfs_TestConfigurationName__";

        #endregion
        /// <summary>
        /// The test output.
        /// </summary>
        StringBuilder testOutput = new StringBuilder();

        /// <summary>
        /// The number of _webDriverReInitMaxAttemptsSetting, by default, to retry the initialization of the WebDriver.
        /// </summary>
        private int _webDriverReInitMaxAttemptsSetting;
        /// <summary>
        /// The current _attempt of reinitialization of the WebDriver. This for the recursion termination check.
        /// </summary>
        private int _retryInitsAttempted;
        /// <summary>
        /// List of PIDs of the opened browsers
        /// </summary>
        private readonly List<int> _browsersPid;

        /// <summary>
        /// List of PIDs of the opened driver services
        /// </summary>
        private readonly List<int> _driversPid;

        #region Events and Delegates

        /// <summary>
        /// Occurs [before web driver initialized].
        /// </summary>
        public event EventHandler<WebDriverInitEventArgs> BeforeWebDriverInitialized;

        /// <summary>
        /// Occurs [after web driver initialized].
        /// </summary>
        public event EventHandler<WebDriverInitEventArgs> AfterWebDriverInitialized;

        /// <summary>
        /// Occurs [before chrome web driver initialized].
        /// </summary>
        public event EventHandler<ChromeWebDriverEventArgs> BeforeChromeWebDriverInitialized;

        /// <summary>
        /// Occurs [before firefox web driver initialized].
        /// </summary>
        public event EventHandler<FirefoxWebDriverEventArgs> BeforeFirefoxWebDriverInitialized;

        /// <summary>
        /// Occurs [after firefox web driver initialized].
        /// </summary>
        public event EventHandler<FirefoxWebDriverEventArgs> AfterFirefoxWebDriverInitialized;

        /// <summary>
        /// Occurs [before internet explorer web driver initialized].
        /// </summary>
        public event EventHandler<InternetExplorerWebDriverEventArgs> BeforeInternetExplorerWebDriverInitialized;

        /// <summary>
        /// Occurs [after internet explorer web driver initialized].
        /// </summary>
        public event EventHandler<InternetExplorerWebDriverEventArgs> AfterInternetExplorerWebDriverInitialized;

        /// <summary>
        /// Occurs [before phantom js web driver initialized].
        /// </summary>
       // public event EventHandler<PhantomJSWebDriverEventArgs> BeforePhantomJSWebDriverInitialized;

        /// <summary>
        /// Occurs [after phantom js web driver initialized].
        /// </summary>
       // public event EventHandler<PhantomJSWebDriverEventArgs> AfterPhantomJSWebDriverInitialized;


        /// <summary>
        /// Occurs [after chrome web driver initialized].
        /// </summary>
        public event EventHandler<ChromeWebDriverEventArgs> AfterChromeWebDriverInitialized;

        /// <summary>
        /// Occurs [before Perfecto Mobile remote web driver initialized].
        /// </summary>
       // public event EventHandler<PerfectoMobileWebDriverEventArgs> BeforePerfectoMobileWebDriverInitialized;

        /// <summary>
        /// Occurs [after Perfecto Mobile remote web driver initialized].
        /// </summary>
        //public event EventHandler<PerfectoMobileWebDriverEventArgs> AfterPerfectoMobileDriverInitialized;

        /// <summary>
        /// Occurs when the [web driver stopped].
        /// </summary>
        public event EventHandler<WebDriverInitFailedEventArgs> WebDriverInitializationFailed;

        /// <summary>
        /// Invoked prior to the Edge webdriver get initialized.
        /// </summary>
        public event EventHandler<EdgeWebDriverEventArgs> BeforeEdgeWebDriverInitialized;
        /// <summary>
        /// Invoked after the Edge webdriver get initialized.
        /// </summary>
        public event EventHandler<EdgeWebDriverEventArgs> AfterEdgeWebDriverInitialized;
        /// <summary>
        /// Invoked prior to the RemoteWebDriver get initialized.
        /// </summary>
        public event EventHandler<RemoteWebDriverEventArgs> BeforeRemoteWebDriverInitialized;
        /// <summary>
        /// Invoked after to the RemoteWebDriver get initialized.
        /// </summary>
        public event EventHandler<RemoteWebDriverEventArgs> AfterRemoteWebDriverInitialized;

        /// <summary>
        /// Called when [before edge web driver initialized].
        /// </summary>
        /// <param name="options">The options.</param>
        protected virtual void OnBeforeEdgeWebDriverInitialized(ref EdgeOptions options)
        {
            EventHandler<EdgeWebDriverEventArgs> handler = BeforeEdgeWebDriverInitialized;
            if (handler != null) handler.Invoke(this, new EdgeWebDriverEventArgs(options));
        }

        /// <summary>
        /// Called when [after edge web driver initialized].
        /// </summary>
        /// <param name="driver">The driver.</param>
        protected virtual void OnAfterEdgeWebDriverInitialized(ref EdgeDriver driver)
        {
            //testOutput.AppendLine("Browser: "+driver.Capabilities.BrowserName+ driver.Capabilities.Version);
            TestContext.WriteLine("Browser: " + driver.Capabilities.GetCapability("broswer") + driver.Capabilities.GetCapability("version"));
            EventHandler<EdgeWebDriverEventArgs> handler = AfterEdgeWebDriverInitialized;
            if (handler != null) handler.Invoke(this, new EdgeWebDriverEventArgs(ref driver));
        }

        /// <summary>
        /// Called when [before remote web driver initialized].
        /// </summary>
        /// <param name="options">The options.</param>
        protected virtual void OnBeforeRemoteWebDriverInitialized(ref RemoteWebDriverOptions options)
        {
            EventHandler<RemoteWebDriverEventArgs> handler = BeforeRemoteWebDriverInitialized;
            if (handler != null) handler.Invoke(this, new RemoteWebDriverEventArgs(options));
        }

        /// <summary>
        /// Called when [after remote web driver initialized].
        /// </summary>
        /// <param name="driver">The driver.</param>
        protected virtual void OnAfterRemoteWebDriverInitialized(ref RemoteWebDriver driver)
        {
            TestContext.WriteLine("Browser: " + driver.Capabilities.GetCapability("browser") + driver.Capabilities.GetCapability("version"));
            EventHandler<RemoteWebDriverEventArgs> handler = AfterRemoteWebDriverInitialized;
            if (handler != null) handler.Invoke(this, new RemoteWebDriverEventArgs(ref driver));
        }

        ///// <summary>
        ///// Called [before phantom js web driver initialized].
        ///// </summary>
        ///// <param name="options">The options.</param>
        //protected virtual void OnBeforePhantomJsWebDriverInitialized(ref PhantomJSOptions options)
        //{
        //    EventHandler<PhantomJSWebDriverEventArgs> handler = BeforePhantomJSWebDriverInitialized;
        //    if (handler != null) handler.Invoke(this, new PhantomJSWebDriverEventArgs(options));
        //}

        ///// <summary>
        ///// Called [after phantom js web driver initialized].
        ///// </summary>
        ///// <param name="driver">The driver.</param>
        //protected virtual void OnAfterPhantomJsWebDriverInitialized(ref PhantomJSDriver driver)
        //{
        //    TestContext.WriteLine("Browser: "+driver.Capabilities.BrowserName+ driver.Capabilities.Version);
        //    EventHandler<PhantomJSWebDriverEventArgs> handler = AfterPhantomJSWebDriverInitialized;
        //    if (handler != null) handler.Invoke(this, new PhantomJSWebDriverEventArgs(ref driver));
        //}

        /// <summary>
        /// Called [after internet explorer web driver initialized].
        /// </summary>
        /// <param name="driver">The ie driver.</param>
        protected virtual void OnAfterInternetExplorerWebDriverInitialized(ref InternetExplorerDriver driver)
        {
            //TestContext.WriteLine("Browser: "+driver.Capabilities.BrowserName+ driver.Capabilities.Version);
            TestContext.WriteLine("Browser: " + driver.Capabilities.GetCapability("broswer") + driver.Capabilities.GetCapability("version"));
            EventHandler<InternetExplorerWebDriverEventArgs> handler = AfterInternetExplorerWebDriverInitialized;
            if (handler != null) handler.Invoke(this, new InternetExplorerWebDriverEventArgs(ref driver));
        }

        /// <summary>
        /// Called [before internet explorer web driver initialized].
        /// </summary>
        /// <param name="options">The options.</param>
        protected virtual void OnBeforeInternetExplorerWebDriverInitialized(ref InternetExplorerOptions options)
        {
            EventHandler<InternetExplorerWebDriverEventArgs> handler = BeforeInternetExplorerWebDriverInitialized;
            if (handler != null) handler.Invoke(this, new InternetExplorerWebDriverEventArgs(options));
        }

        /// <summary>
        /// Called [after firefox web driver initialized].
        /// </summary>
        /// <param name="driver">The firefox driver.</param>
        protected virtual void OnAfterFirefoxWebDriverInitialized(ref FirefoxDriver driver)
        {
            //TestContext.WriteLine("Browser: "+driver.Capabilities.BrowserName+ driver.Capabilities.Version);
            TestContext.WriteLine("Browser: " + driver.Capabilities.GetCapability("broswer") + driver.Capabilities.GetCapability("version"));
            EventHandler<FirefoxWebDriverEventArgs> handler = AfterFirefoxWebDriverInitialized;
            if (handler != null) handler.Invoke(this, new FirefoxWebDriverEventArgs(ref driver));
        }

        /// <summary>
        /// Called [before firefox web driver initialized].
        /// </summary>
        /// <param name="profile">The profile.</param>
        /// <param name="options"></param>
        /// TODO: FirefoxProfile will be removed
        protected virtual void OnBeforeFirefoxWebDriverInitialized(ref FirefoxProfile profile, ref FirefoxOptions options)
        {
            EventHandler<FirefoxWebDriverEventArgs> handler = BeforeFirefoxWebDriverInitialized;
            //if (handler != null) handler.Invoke(this, new FirefoxWebDriverEventArgs(profile, options));
            if (handler != null) handler.Invoke(this, new FirefoxWebDriverEventArgs(options));
        }

        /// <summary>
        /// Called [before chrome web driver initialized].
        /// </summary>
        /// <param name="chromeOptions">The chrome options.</param>
        protected virtual void OnBeforeChromeWebDriverInitialized(ref ChromeOptions chromeOptions)
        {
            EventHandler<ChromeWebDriverEventArgs> handler = BeforeChromeWebDriverInitialized;
            if (handler != null) handler.Invoke(this, new ChromeWebDriverEventArgs(chromeOptions));
        }

        /// <summary>
        /// Called [after chrome web driver initialized].
        /// </summary>
        /// <param name="driver">The chrome driver.</param>
        protected virtual void OnAfterChromeWebDriverInitialized(ref ChromeDriver driver)
        {
            //TestContext.WriteLine("Browser: "+driver.Capabilities.BrowserName+ driver.Capabilities.Version);
            TestContext.WriteLine("Browser: " + driver.Capabilities.GetCapability("broswer") + driver.Capabilities.GetCapability("version"));
            EventHandler<ChromeWebDriverEventArgs> handler = AfterChromeWebDriverInitialized;
            if (handler != null) handler.Invoke(this, new ChromeWebDriverEventArgs(ref driver));
        }



        /// <summary>
        /// Called [before Perfecto Mobile web driver initialized].
        /// </summary>
        /// <param name="perfectoMobileOptions">The perfecto mobile options.</param>
        //protected virtual void OnBeforePerfectoMobileDriverInitialized(ref PerfectoMobileOptions perfectoMobileOptions)
        //{
        //    EventHandler<PerfectoMobileWebDriverEventArgs> handler = BeforePerfectoMobileWebDriverInitialized;
        //    if (handler != null) handler.Invoke(this, new PerfectoMobileWebDriverEventArgs(perfectoMobileOptions));
        //}

        /// <summary>
        /// Called [after Perfecto Mobile web driver initialized].
        /// </summary>
        /// <param name="driver">The perfecto mobile driver.</param>
        //protected virtual void OnAfterPerfectoMobileDriverInitialized(ref RemoteWebDriver driver)
        //{
        //    TestContext.WriteLine("Browser: "+driver.Capabilities.BrowserName+ driver.Capabilities.Version);
        //    EventHandler<PerfectoMobileWebDriverEventArgs> handler = AfterPerfectoMobileDriverInitialized;
        //    if (handler != null) handler.Invoke(this, new PerfectoMobileWebDriverEventArgs(ref driver));
        //}


        /// <summary>
        /// Called [before web driver initialized].
        /// </summary>
        /// <param name="webDriverType">Type of the web driver.</param>
        protected virtual void OnBeforeWebDriverInitialized(WebDriverType webDriverType)
        {
            EventHandler<WebDriverInitEventArgs> handler = BeforeWebDriverInitialized;
            if (handler != null) handler.Invoke(this, new WebDriverInitEventArgs(webDriverType));
        }

        /// <summary>
        /// Called [after web driver initialized].
        /// </summary>
        /// <param name="webDriverType">Type of the web driver.</param>
        protected virtual void OnAfterWebDriverInitialized(WebDriverType webDriverType)
        {
            EventHandler<WebDriverInitEventArgs> handler = AfterWebDriverInitialized;
            if (handler != null) handler.Invoke(this, new WebDriverInitEventArgs(webDriverType));
        }

        /// <summary>
        /// Called when the [web driver stopped unexpectedly].
        /// </summary>
        /// <param name="e">The <see cref="WebDriverInitFailedEventArgs" /> instance containing the event data.</param>
        protected virtual void OnWebDriverWebDriverInitializationFailed(WebDriverInitFailedEventArgs e)
        {
            EventHandler<WebDriverInitFailedEventArgs> handler = WebDriverInitializationFailed;
            if (handler != null) handler.Invoke(this, e);
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the test web driver.
        /// </summary>
        /// <value>The test web driver.</value>
        /// <exception cref="System.ArgumentNullException">WebDriver cannot be null.</exception>
        public IWebDriver TestWebDriver { get; set; }

        public TimeSpan? WebDriverTimeout { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Class constructor
        /// </summary>
        public AdeptBaseClass()
        {
            _browsersPid = new List<int>();
            _driversPid = new List<int>();
            AppDomain.CurrentDomain.DomainUnload += AppCleanup;
        }

        /// <summary>
        /// Tries do kill the opened browsers.
        /// </summary>
        private void TryKillProcesses(ICollection<int> processes)
        {
            if (processes.Any())
            {
                foreach (var pid in processes)
                {
                    try
                    {
                        Process.GetProcessById(pid).Kill();
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }
            }
            processes.Clear();
        }

        /// <summary>
        /// Code in this method will run after all tests are run.
        /// </summary>
        private void AppCleanup(object sender, EventArgs e)
        {
            if (UseSingleWebDriver(GetType()))
            {
                TryKillProcesses(_browsersPid);
                TryKillProcesses(_driversPid);
            }
        }

        [Obsolete("This method will be removed in future versions. Please remove references.")]
        [ClassInitialize]
        public static void BaseClassInitialize(TestContext testCOntext)
        {

        }

        [Obsolete("This method will be removed in future versions. Please remove references.")]
        [ClassCleanup]
        public static void BaseClassCleanup()
        {

        }

        /// <summary>
        /// Code in this method will run after running each test.
        /// </summary>
        [TestCleanup]
        [WorkItem(588306)]
        public void BaseTestCleanup()
        {
            //We can kill the processes in here when SWD = false, otherwise we use AppCleanup
            if (!UseSingleWebDriver(GetType()))
            {
                //TryKillProcesses(_browsersPid);
                //TryKillProcesses(_driversPid);
            }
            try
            {
                if (!UseSingleWebDriver(GetType()) && TestWebDriver != null)
                {
                    TestContext.WriteLine(testOutput.ToString());
                    testOutput.Clear();
                    TestContext.WriteLine("Quitting WebDriver");
                    TestWebDriver.Quit();
                    TestWebDriver = null;
                }
            }
            catch (WebDriverException wdException)
            {
                //Hide Webdriver exception here after the test has finished.
                TestContext.WriteLine(testOutput.ToString());
                testOutput.Clear();
                TestContext.WriteLine(wdException.ToString());
            }
        }

        /// <summary>
        /// Code in this method will run before running each test.
        /// </summary>
        [TestInitialize]
        public void BaseTestInitialize()
        {
            bool shouldRetrySetting;
            testOutput.AppendLine("Platform: " + Environment.OSVersion.VersionString);
            if (MethodHasWebDriverInitRetryAttribute(GetType(), out _webDriverReInitMaxAttemptsSetting, out shouldRetrySetting))
            {
                testOutput.AppendLine(
                    "The method has the attribute, it's retryInitValue is '" + shouldRetrySetting +
                    "'. Max retry attempts set to '" + _webDriverReInitMaxAttemptsSetting + "'");
            }
            else if (ClassHasWebDriverInitRetryAttribute(GetType(), out _webDriverReInitMaxAttemptsSetting, out shouldRetrySetting))
            {
                testOutput.AppendLine(
                    "TestClass has RetryWebDriverInit Attribute set to '" + shouldRetrySetting +
                    "'. Max retry attempts set to '" + _webDriverReInitMaxAttemptsSetting + "'.");
            }
            else if (!int.TryParse(ConfigurationManager.AppSettings["MaxWebDriverReInitAttempts"], out _webDriverReInitMaxAttemptsSetting))
            {
                _webDriverReInitMaxAttemptsSetting = 0; //If a non-integer is supplied we set the _webDriverReInitMaxAttemptsSetting to zero.
                shouldRetrySetting = false;
                testOutput.AppendLine("No valid entry for 'MaxWebDriverReInitAttempts': No reinit attempts will be made.");
            }
            else
            {
                shouldRetrySetting = true;
                testOutput.AppendLine(
                    "WebDriver Init Retry enabled in App.Config. Max retry attempts: " + _webDriverReInitMaxAttemptsSetting);
            }

            //Upperbound limit is 3, lowerbound limit is 0
            if (_webDriverReInitMaxAttemptsSetting >= 3) _webDriverReInitMaxAttemptsSetting = 3;
            else if (_webDriverReInitMaxAttemptsSetting <= 0) _webDriverReInitMaxAttemptsSetting = 0;


            if (!UseSingleWebDriver(GetType()) || TestWebDriver == null)
            {
                try
                {
                    InitializeWebDriver();
                }
                catch (Exception exception)
                {
                    testOutput.Append(exception);
                    TestContext.WriteLine(testOutput.ToString());
                    testOutput.Clear();

                    Assert.Inconclusive("There was a problem communicating with the WebDriver, if this problem persists please contact support.");
                }

                testOutput.AppendLine("Completed Selenium Web Driver Initialization.");
                TestContext.WriteLine(testOutput.ToString());
                testOutput.Clear();
            }

            try
            {
                //Reading the URL from the TestWebDriver to verify that the instance is still responding.

                if (TestWebDriver != null)
                    testOutput.AppendLine("URL at start of test: " + TestWebDriver.Url);
            }
            catch (WebDriverException exception)
            {
                var tryInitAgain = false;
                //WebDriverInitFailedEventArgs wdsEventArgs = new WebDriverInitFailedEventArgs(exception, ref tryInitAgain);
                WebDriverInitFailedEventArgs wdsEventArgs = new WebDriverInitFailedEventArgs(exception);
                testOutput.AppendLine("***** WARNING *****");
                testOutput.AppendLine(exception.ToString());
                OnWebDriverWebDriverInitializationFailed(wdsEventArgs);
                //if (wdsEventArgs.RetryWebDriverInit && (_webDriverReInitMaxAttemptsSetting > _retryInitsAttempted) && shouldRetrySetting)
                //{
                //    testOutput.AppendFormat("Lost contact with the WebDriver. This is attempt number {0} of {1}.",
                //        _retryInitsAttempted + 1, _webDriverReInitMaxAttemptsSetting);
                //    TestContext.WriteLine(testOutput.ToString());
                //    testOutput.Clear();
                //    TestWebDriver = null;
                //    _retryInitsAttempted++;
                //    BaseTestInitialize();
                //}

                //else
                {
                    testOutput.AppendFormat("Lost contact with the WebDriver. This test will not continue.");
                    testOutput.AppendLine();
                    testOutput.AppendLine("***** END WARNING *****");

                    TestContext.WriteLine(testOutput.ToString());
                    testOutput.Clear();
                    Assert.Inconclusive("The test did not execute correctly. Please see the test output and retry.");
                }


            }
            finally
            {
                TestContext.WriteLine(testOutput.ToString());
                testOutput.Clear(); //Clearing stringbuilder to avoid duplicating output.
            }

        }

        /// <summary>
        /// Initializes the web driver.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void InitializeWebDriver()
        {
            string browser = "InternetExplorer";//string.Empty;

            //running via MTM
            //if (TestContext.Properties.Contains(TestConfigurationName))
            //{
            //    browser = TestContext.Properties[TestConfigurationName].ToString();
            //}

            //browser = SeleniumDriver.ResolveBrowser(browser);

            switch (GetDriverType(browser))
            {
                case WebDriverType.ChromeDriver:
                    var chromeOptions = new ChromeOptions();
                    var chromeService = ChromeDriverService.CreateDefaultService();
                    chromeOptions.AddUserProfilePreference("download.default_directory", @"\\W10DTVB9R2\Samuel_G\Sandeep");
                    OnBeforeChromeWebDriverInitialized(ref chromeOptions);
                    OnBeforeWebDriverInitialized(WebDriverType.ChromeDriver);
                    var activeChromePids = Process.GetProcessesByName("chrome").Select(p => p.Id);
                    var chromeDriver = new ChromeDriver(chromeService, chromeOptions);
                    _browsersPid.AddRange(Process.GetProcessesByName("chrome").Select(p => p.Id).Except(activeChromePids));
                    _driversPid.Add(chromeService.ProcessId);
                    TestWebDriver = chromeDriver;
                    OnAfterChromeWebDriverInitialized(ref chromeDriver);
                    OnAfterWebDriverInitialized(WebDriverType.ChromeDriver);
                    break;
                case WebDriverType.FirefoxDriver:
                    //Selenium 3.0 calls Geckodriver internally when FirefoxDriver is instantiated
                    //TODO: FirefoxProfile will be removed
                    var firefoxProfile = new FirefoxProfile();
                    var firefoxOptions = new FirefoxOptions { Profile = firefoxProfile };
                    var firefoxService = FirefoxDriverService.CreateDefaultService();
                    //OnBeforeFirefoxWebDriverInitialized(ref firefoxProfile, ref firefoxOptions);
                    OnBeforeWebDriverInitialized(WebDriverType.FirefoxDriver);
                    var activeFirefoxPids = Process.GetProcessesByName("firefox").Select(p => p.Id);
                    var firefoxDriver = new FirefoxDriver(firefoxService, firefoxOptions, System.Threading.Timeout.InfiniteTimeSpan);
                    _browsersPid.AddRange(Process.GetProcessesByName("firefox").Select(p => p.Id).Except(activeFirefoxPids));
                    _driversPid.Add(firefoxService.ProcessId);
                    TestWebDriver = firefoxDriver;
                    OnAfterFirefoxWebDriverInitialized(ref firefoxDriver);
                    OnAfterWebDriverInitialized(WebDriverType.FirefoxDriver);
                    break;
                case WebDriverType.InternetExplorerDriver:
                    var ieOptions = new InternetExplorerOptions();
                    var ieDriverService = InternetExplorerDriverService.CreateDefaultService();
                    //to make sure that test execution on Internet explorer does not fail when the zoom level is anything other than 100%.
                    ieOptions.IgnoreZoomLevel = true;
                    OnBeforeInternetExplorerWebDriverInitialized(ref ieOptions);
                    OnBeforeWebDriverInitialized(WebDriverType.InternetExplorerDriver);
                    var activeIEPids = Process.GetProcessesByName("iexplore").Select(p => p.Id);
                    var ieDriver = new InternetExplorerDriver(ieDriverService, ieOptions);
                    _browsersPid.AddRange(Process.GetProcessesByName("iexplore").Select(p => p.Id).Except(activeIEPids));
                    _driversPid.Add(ieDriverService.ProcessId);
                    TestWebDriver = ieDriver;
                    OnAfterInternetExplorerWebDriverInitialized(ref ieDriver);
                    OnAfterWebDriverInitialized(WebDriverType.InternetExplorerDriver);
                    break;               
                case WebDriverType.EdgeDriver:
                    var edgeOptions = new EdgeOptions();
                    var edgeDriverService = EdgeDriverService.CreateDefaultService();
                    OnBeforeEdgeWebDriverInitialized(ref edgeOptions);
                    OnBeforeWebDriverInitialized(WebDriverType.EdgeDriver);
                    var activeEdgePids = Process.GetProcessesByName("edge").Select(p => p.Id);
                    var edgeDriver = new EdgeDriver(edgeDriverService, edgeOptions);
                    _browsersPid.AddRange(Process.GetProcessesByName("edge").Select(p => p.Id).Except(activeEdgePids));
                    _driversPid.Add(edgeDriverService.ProcessId);
                    TestWebDriver = edgeDriver;
                    OnAfterEdgeWebDriverInitialized(ref edgeDriver);
                    OnAfterWebDriverInitialized(WebDriverType.EdgeDriver);
                    break;
                case WebDriverType.RemoteWebDriver:
                    var rwdOptions = new RemoteWebDriverOptions();
                    OnBeforeRemoteWebDriverInitialized(ref rwdOptions);
                    OnBeforeWebDriverInitialized(WebDriverType.RemoteWebDriver);
                    //this is changed in adpet 4.5
                    //var remoteWebDriver = WebDriverTimeout == null ?
                    //new RemoteWebDriver(rwdOptions.Uri, rwdOptions.DesiredCapabilities) :
                    //new RemoteWebDriver(rwdOptions.Uri, rwdOptions.DesiredCapabilities, WebDriverTimeout.Value);
                    //TestWebDriver = remoteWebDriver;
                    //OnAfterRemoteWebDriverInitialized(ref remoteWebDriver);
                    OnAfterWebDriverInitialized(WebDriverType.RemoteWebDriver);
                    break;
                default:
                    throw new System.NotImplementedException();
            }
        }

        /// <summary>
        /// Initializes the Selenium WebDriver.
        /// </summary>
        /// <param name="t">The TestClass to check for the attribute. (Typically <code>this.GetType()</code></param>
        /// <returns>IWebDriver</returns>
        /// <exception cref="UnsupportedMtmConfigurationException">Thrown when an unsupported configuration is selected from MTM.</exception>
        protected static bool UseSingleWebDriver(Type t)
        {
            var singleWebDriverAttribute =
                (SingleWebDriverAttribute)Attribute.GetCustomAttribute(t, typeof(SingleWebDriverAttribute));

            return singleWebDriverAttribute != null && singleWebDriverAttribute.SingleWebDriver;
        }

        /// <summary>
        /// Classes the has web driver initialize retry attribute.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="maxRetries">The maximum retries.</param>
        /// <param name="retryInitValue">if set to <c>true</c> [retryInitValue].</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        protected static bool ClassHasWebDriverInitRetryAttribute(Type t, out int maxRetries, out bool retryInitValue)
        {
            //TODO: Update this to include bool output for the setting.
            var retryWebDriverInitAttribute =
                (RetryWebDriverInitAttribute)Attribute.GetCustomAttribute(t, typeof(RetryWebDriverInitAttribute));
            if (retryWebDriverInitAttribute != null)
            {
                retryInitValue = retryWebDriverInitAttribute.RetryInitialize;
                maxRetries = retryWebDriverInitAttribute.RetryMax;
                return true;
            }
            retryInitValue = false;
            maxRetries = 0;
            return false;
        }

        /// <summary>
        /// Methods the has web driver initialize retry attribute.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="maxRetries">The maximum retries.</param>
        /// <param name="retryInitValue">if set to <c>true</c> [retryInitValue].</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        protected bool MethodHasWebDriverInitRetryAttribute(Type t, out int maxRetries, out bool retryInitValue)
        {
            var methodName = TestContext.TestName;
            var retryWebDriverInitAttribute =
                (RetryWebDriverInitAttribute)t.GetMethod(methodName).GetCustomAttribute(typeof(RetryWebDriverInitAttribute));

            if (retryWebDriverInitAttribute != null)
            {
                maxRetries = retryWebDriverInitAttribute.RetryMax;
                retryInitValue = retryWebDriverInitAttribute.RetryInitialize;
                return true;
            }
            retryInitValue = false;
            maxRetries = 0;
            return false;
        }

        /// <summary>
        /// Gets the type of the driver.
        /// </summary>
        /// <param name="browserName">Name of the browser.</param>
        /// <returns>WebDriverType.</returns>
        protected static WebDriverType GetDriverType(string browserName)
        {
            if (browserName == null) return WebDriverType.FirefoxDriver;
            switch (browserName)
            {
                case "Chrome":
                    return WebDriverType.ChromeDriver;
                case "InternetExplorer":
                    return WebDriverType.InternetExplorerDriver;
                case "Firefox":
                    return WebDriverType.FirefoxDriver;               
                case "Edge":
                    return WebDriverType.EdgeDriver;
                case "RemoteWebDriver":
                    return WebDriverType.RemoteWebDriver;

                default:
                    return WebDriverType.FirefoxDriver;
            }
        }
        #endregion
    }
}