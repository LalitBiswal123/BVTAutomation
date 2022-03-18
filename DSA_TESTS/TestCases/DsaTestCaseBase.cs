using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsa.Utils;
using System.IO;
using Dell.Adept.UI.Web.Testing.Framework;
using System.Text;

namespace DsaTest.TestCases
{
    [TestClass]
    public class DsaTestCaseBase : WebUIMsTestBase
    {
        public DsaTestCaseBase()
        {

        }
     
        #region

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

                //Test Data Source Path - C:\MyDrive\SourceTree\DSA_TESTS\bin\Debug\TestData\US\SIT2
                string testDatasourceDirPath = dirPathValue + testContext.Properties["LocalBuild"].ToString() + testContext.Properties["LocalBuildBinReleasePath"].ToString() + testContext.Properties["LocalTestDataPath"].ToString();

                //Test Deployment Path - C:\MyDrive\SourceTree\TestResults\Deploy_Lalit_Biswal 2022-03-18 13_52_03\Out\TestData
                string testDeploymentDirPath = testContext.DeploymentDirectory.ToString() + "\\TestData";

                //C:\MyDrive\SourceTree\DSA_TESTS\bin\Debug\TestData\US\SIT2
                DirectoryInfo sourceDir = new DirectoryInfo(testDatasourceDirPath);
                Console.WriteLine("testdatasourcedirpath:" + testDatasourceDirPath);
                Console.WriteLine("sourcedir: " + sourceDir);

                //Create TestData folder in the deployment directory path
                Directory.CreateDirectory(testDeploymentDirPath);

                //string testDataDestDirPath = ".\\TestData";
                //DirectoryInfo destDir = new DirectoryInfo(testDataDestDirPath);
                //Console.WriteLine("destDir: " + destDir);

                //Copy files from data source path to deployment path
                foreach (FileInfo file in sourceDir.GetFiles("*.*", SearchOption.TopDirectoryOnly))
                {
                    file.CopyTo(Path.Combine(testDeploymentDirPath, file.Name), true);
                }
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
                TestWebDriver.NavigateHomePage(navigateUrl);
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

                TestWebDriver.Close();
                //AppDomain.CurrentDomain.ProcessExit += (s, e) => TestWebDriver.Close();
            }
            catch (Exception e)
            {
                Logger.Write(e.Message);
                TestWebDriver.Dispose();
                throw;
            }
        }

        #endregion
    }
}