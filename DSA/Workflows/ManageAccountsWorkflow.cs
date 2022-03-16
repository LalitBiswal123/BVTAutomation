using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using Dsa.Pages.Solutions.ManageAccounts;
using Dsa.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsa.Pages.Solutions;
using Dsa.DataModels;
using SolutionsWorkFlow = Dsa.Workflows.Solutions;
using FluentAssertions;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;

namespace Dsa.Workflows
{
    public static class ManageAccountsWorkflow
    {
        public static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static TimeSpan GlobalWaitTime = TimeSpan.FromSeconds(130);
        public static void CreateManageAccountsFlow(IWebDriver TestWebDriver, string ManageAccUrl)
        {
           
            TestWebDriver.Navigate().GoToUrl(ManageAccUrl);            
            //new EndUserPage(TestWebDriver);
        }




        public static void CreateNewSolutionCpqFlowWithNewManageAccount(IWebDriver webDriver, OscSolutionData testData, string ProductsList, bool saveSolution = true) 
            {
            webDriver.Navigate().GoToUrl(testData.OscUrl);

            // check for auto-recovered solutions if any
            SolutionsWorkFlow.ManageAutoRecoveredSolutions(webDriver);

            //Add products to solution
            new YourSolutionsPage(webDriver).CreateNewSolutionCPQ(testData.SolutionName, ProductsList);

            //Click on End User link
            new SolutionConfigurationPage(webDriver).LnkSelectEndUser.Click(webDriver);
        }

       



        //Create new solution Customer type


        public static void CreateNewSolutionNewManageAccount(IWebDriver webDriver, OscSolutionData testData)
        {
            webDriver.Navigate().GoToUrl(testData.OscUrl);

            // check for auto-recovered solutions if any
            SolutionsWorkFlow.ManageAutoRecoveredSolutions(webDriver);

            //Creating New Solution
            new YourSolutionsPage(webDriver).CreateNewSolutionCPQcustType(testData.SolutionName);
            new YourSolutionsPage(webDriver).CustTypeOnSolPage.PickDropdownByText(webDriver, "Medium Business");
        }


        public static void CustTypeSolutionCpqFlowWithNewManageAccount(IWebDriver webDriver, OscSolutionData testData, string ProductsList, bool saveSolution = true)
        {
            webDriver.Navigate().GoToUrl(testData.OscUrl);

            // check for auto-recovered solutions if any
            SolutionsWorkFlow.ManageAutoRecoveredSolutions(webDriver);

            //Add products to solution
            var YourSolutionsPage = new YourSolutionsPage(webDriver);
            new YourSolutionsPage(webDriver).CreateNewSolutionCPQcustType(testData.SolutionName);

            var custtype = YourSolutionsPage.CustTypeOnSolPage.GetText(webDriver);
            Logger.Write("CustomerType:" +custtype);
          
            YourSolutionsPage.BtnCreate.WaitForElement(webDriver);
            YourSolutionsPage.BtnCreate.Click(webDriver);
           

            SolutionConfigurationPage SolutionConfigurationPage = new SolutionConfigurationPage(webDriver);
            SolutionConfigurationPage.SearchAndAddMultipleProducts(ProductsList);
            if (saveSolution)
                new SolutionConfigurationPage(webDriver).SaveSolution();
           

            //Click on End User link
            new SolutionConfigurationPage(webDriver).LnkSelectEndUser.Click(webDriver);
        }


        public static void CreateSolutionCpqFlowWithNewManageAccount(IWebDriver webDriver, OscSolutionData testData)
        {
            webDriver.Navigate().GoToUrl(testData.OscUrl);

            // check for auto-recovered solutions if any
            //SolutionsWorkFlow.ManageAutoRecoveredSolutions(webDriver);

            new YourSolutionsPage(webDriver).SearchAndOpenSolution(testData.SolutionId);

            if (!testData.SaveSolutionAsNewVersion)
            {
                new SolutionConfigurationPage(webDriver).SolutionSaveAsNewSolution();

                //Add code for updating shipping group
                if (!string.IsNullOrEmpty(testData.ShippingMethod))
                {
                    new SolutionConfigurationPage(webDriver).GoToGroupsTab();
                    new SolutionConfigurationPage(webDriver).ShippingMethodLnk.Click(webDriver);
                    new SolutionConfigurationPage(webDriver).SelectShippingMethod(webDriver, testData.ShippingMethod);
                }

                //Set Shipping instructions if needed
                if (!string.IsNullOrEmpty(testData.ShippingInstructions))
                {
                    new SolutionConfigurationPage(webDriver).GoToGroupsTab();
                    new SolutionConfigurationPage(webDriver).EnterShippingInstructions(webDriver, testData.ShippingInstructions);
                }

            }
            else
            {
                //do save as new version
                new SolutionConfigurationPage(webDriver).SolutionSaveAsNewVersion();
            }

            //new SolutionConfigurationPage(webDriver).SaveCPSolution();
            var createdSolId = new SolutionConfigurationPage(webDriver).SolutionIDLabel.GetText(webDriver).Split('#')[1];
            createdSolId.Should().NotBeEmpty("Solution creation failure (possibly timed out after 300 seconds)");
            Logger.Write("Solution Id: " + createdSolId);
            new SolutionConfigurationPage(webDriver).LnkSelectEndUser.Click(webDriver);
           
        }


        public static void SaveSolutionSameVersionCpqFlow(IWebDriver webDriver, OscSolutionData testData)
        {
            webDriver.Navigate().GoToUrl(testData.OscUrl);
            webDriver.VerifyBusyOverlayNotDisplayed();
            
            //Check for auto-recovered solutions if any
            SolutionsWorkFlow.ManageAutoRecoveredSolutions(webDriver);
            
            new YourSolutionsPage(webDriver).SearchAndOpenSolution(testData.SolutionId);

            if (testData.SaveSolutionAsNewVersion)
            {
                new SolutionConfigurationPage(webDriver).SolutionSaveAsNewVersion();

                //Add code for updating shipping group
                if (!string.IsNullOrEmpty(testData.ShippingMethod))
                {
                    new SolutionConfigurationPage(webDriver).GoToGroupsTab();
                    new SolutionConfigurationPage(webDriver).ShippingMethodLnk.Click(webDriver);
                    new SolutionConfigurationPage(webDriver).SelectShippingMethod(webDriver, testData.ShippingMethod);
                }

                //Set Shipping instructions if needed
                if (!string.IsNullOrEmpty(testData.ShippingInstructions))
                {
                    new SolutionConfigurationPage(webDriver).GoToGroupsTab();
                    new SolutionConfigurationPage(webDriver).EnterShippingInstructions(webDriver, testData.ShippingInstructions);
                }

            }
            else
            {
                // save as new version
                new SolutionConfigurationPage(webDriver).SolutionSaveAsNewSolution();
            }

            var createdSolId = new SolutionConfigurationPage(webDriver).SolutionIDLabel.GetText(webDriver).Split('#')[1];
            createdSolId.Should().NotBeEmpty("Solution creation failure (possibly timed out after 300 seconds)");
            Logger.Write("Solution Id: " + createdSolId);

        }


        public static List<Dictionary<string, object>> GetTableDataMA(this IWebElement tableElement, IWebDriver driver)
        {
            driver.VerifyBusyOverlayNotDisplayed();
            tableElement.WaitForElementVisible(GlobalWaitTime);

            var tableData = BuildTableDataMA(tableElement, driver);

            return tableData;
        }

        public static List<Dictionary<string, object>> GetTableDataMAReseller(this IWebElement tableElement, IWebDriver driver)
        {
            driver.VerifyBusyOverlayNotDisplayed();
            tableElement.WaitForElementVisible(GlobalWaitTime);

            var tableData = BuildTableDataMAReseller(tableElement, driver);

            return tableData;
        }

        public static List<Dictionary<string, object>> GetTableDataMABillTo(this IWebElement tableElement, IWebDriver driver)
        {
            driver.VerifyBusyOverlayNotDisplayed();
            tableElement.WaitForElementVisible(GlobalWaitTime);

            var tableData = BuildTableDataMABillTo(tableElement, driver);

            return tableData;
        }

        public static List<Dictionary<string, object>> GetTableDataMAShipTo(this IWebElement tableElement, IWebDriver driver)
        {
            driver.VerifyBusyOverlayNotDisplayed();
            tableElement.WaitForElementVisible(GlobalWaitTime);

            var tableData = BuildTableDataMAShipTo(tableElement, driver);

            return tableData;
        }

        public static List<Dictionary<string, object>> GetTableDataShipToContacts(this IWebElement tableElement, IWebDriver driver)
        {
            driver.VerifyBusyOverlayNotDisplayed();
            tableElement.WaitForElementVisible(GlobalWaitTime);

            var tableData = BuildTableDataMAShipToContacts(tableElement, driver);

            return tableData;
        }

        public static List<Dictionary<string, object>> GetTableDataMAInstallAt(this IWebElement tableElement, IWebDriver driver)
        {
            driver.VerifyBusyOverlayNotDisplayed();
            tableElement.WaitForElementVisible(GlobalWaitTime);

            var tableData = BuildTableDataMAInstallAt(tableElement, driver);

            return tableData;
        }

        //public static List<Dictionary<string, object>> GetTableDataMASoldTo(this IWebElement tableElement, IWebDriver driver)
        //{
        //    driver.VerifyBusyOverlayNotDisplayed();
        //    tableElement.WaitForElementVisible(GlobalWaitTime);

        //    var tableData = BuildTableDataMASoldTo(tableElement, driver);

        //    return tableData;
        //}


        #region FT1 MA


        private static List<Dictionary<string, object>> BuildTableDataMA(IWebElement element, IWebDriver driver)
        {
            var tableData = new List<Dictionary<string, object>>();
            const string columnHeaderCaption = "Column";

            var headers = element.FindElements(By.CssSelector("#ma-customer-selection > div.dds__col-lg-9.dds__col-md-8.dds__mt-sm-4 > div > dsa-ma-end-user > end-user-search-result > div:nth-child(4) > mat-table > mat-header-row > mat-header-cell")); // Get all the header elements
            var rows = element.FindElements(By.CssSelector("#ma-customer-selection > div.dds__col-lg-9.dds__col-md-8.dds__mt-sm-4 > div > dsa-ma-end-user > end-user-search-result > div:nth-child(4) > mat-table > mat-row")); // Get all the row elements
            foreach (var row in rows) // Loop through all the <tr> elements in a row
            {
                var tds = row.FindElements(By.CssSelector("mat-cell")); // Get all <td> elements inside a row or <tr> element
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

        private static List<Dictionary<string, object>> BuildTableDataMASoldTo(IWebElement element, IWebDriver driver)
        {
            var tableData = new List<Dictionary<string, object>>();
            const string columnHeaderCaption = "Column";

            var headers = element.FindElements(By.CssSelector("thead > th")); // Get all the header elements

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

            Log.Info("Html table data received. Row Count: " + tableData.Count + "; Column Count: " +
                         tableData[0].Keys.Count);
            return tableData;
        
        }

        private static List<Dictionary<string, object>> BuildTableDataMABillTo(IWebElement element, IWebDriver driver)
        {
            var tableData = new List<Dictionary<string, object>>();
            const string columnHeaderCaption = "Column";

            var headers = element.FindElements(By.CssSelector("#ma-customer-selection > div.dds__col-lg-9.dds__col-md-8.dds__mt-sm-4 > div > dsa-ma-bill-to > div > div > mat-table > mat-header-row > mat-header-cell")); // Get all the header elements
            
            var rows = element.FindElements(By.CssSelector("#ma-customer-selection > div.dds__col-lg-9.dds__col-md-8.dds__mt-sm-4 > div > dsa-ma-bill-to > div > div > mat-table  > mat-row")); // Get all the row elements
            
            foreach (var row in rows) // Loop through all the <tr> elements in a row
            {
                var tds = row.FindElements(By.CssSelector("mat-cell")); // Get all <td> elements inside a row or <tr> element
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

            Log.Info("Html table data received. Row Count: " + tableData.Count + "; Column Count: " +
                         tableData[0].Keys.Count);
            return tableData;
        }


        private static List<Dictionary<string, object>> BuildTableDataMAReseller(IWebElement element, IWebDriver driver)
        {
            var tableData = new List<Dictionary<string, object>>();
            const string columnHeaderCaption = "Column";

            var headers = element.FindElements(By.CssSelector("#ma-customer-selection > div.dds__col-lg-9.dds__col-md-8.dds__mt-sm-4 > div > dsa-ma-reseller > reseller-search-result > div:nth-child(4) > mat-table > mat-header-row > mat-header-cell")); // Get all the header elements
            
            var rows = element.FindElements(By.CssSelector("#ma-customer-selection > div.dds__col-lg-9.dds__col-md-8.dds__mt-sm-4 > div > dsa-ma-reseller > reseller-search-result > div:nth-child(4) > mat-table > mat-row")); // Get all the row elements
          
            foreach (var row in rows) // Loop through all the <tr> elements in a row
            {
                var tds = row.FindElements(By.CssSelector("mat-cell")); // Get all <td> elements inside a row or <tr> element
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


        private static List<Dictionary<string, object>> BuildTableDataMAShipTo(IWebElement element, IWebDriver driver)
        {
            var tableData = new List<Dictionary<string, object>>();
            const string columnHeaderCaption = "Column";

            var headers = element.FindElements(By.CssSelector("thead > th")); // Get all the header elements

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

            Log.Info("Html table data received. Row Count: " + tableData.Count + "; Column Count: " +
                         tableData[0].Keys.Count);
            return tableData;
        }


        private static List<Dictionary<string, object>> BuildTableDataMAShipToContacts(IWebElement element, IWebDriver driver)
        {
            var tableData = new List<Dictionary<string, object>>();
            const string columnHeaderCaption = "Column";

            var headers = element.FindElements(By.CssSelector("mat-header-row > th")); // Get all the header elements

            var rows = element.FindElements(By.CssSelector("mat-row > mat-cell")); // Get all the row elements

            foreach (var row in rows) // Loop through all the <tr> elements in a row
            {
                var tds = row.FindElements(By.CssSelector("mat-cell")); // Get all <mat-cell> elements inside a row or <mat-row> element
                var data = new Dictionary<string, object>();
                int index = 0;
                foreach (var td in tds) // Loop through all the <mat-cell> elements in a row
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

            Log.Info("Html table data received. Row Count: " + tableData.Count + "; Column Count: " +
                         tableData[0].Keys.Count);
            return tableData;
        }

        private static List<Dictionary<string, object>> BuildTableDataMAInstallAt(IWebElement element, IWebDriver driver)
        {
            var tableData = new List<Dictionary<string, object>>();
            const string columnHeaderCaption = "Column";

            var headers = element.FindElements(By.CssSelector("thead > th")); // Get all the header elements

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

            Log.Info("Html table data received. Row Count: " + tableData.Count + "; Column Count: " +
                         tableData[0].Keys.Count);
            return tableData;
        }
        #endregion

    }
}
