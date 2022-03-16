using System.Collections.Generic;
using Dsa.Constants;
using Dsa.Pages;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Dsa.Workflows
{

    /// <summary>
    /// Workflow class for Customer Communication Page.
    /// </summary>
    public static class CustomerOutputWorkflow
    {
        #region Choose Output Type
        /// <summary>
        /// Filters output type filter
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="outputType"></param>
        /// <returns></returns>
        public static void ChooseOutputType(IWebDriver driver, string outputType)
        {
            var customeroutputPage = new CustomerCommunicationPage(driver);
            customeroutputPage.CfoHistoryOutputTypeFilter.PickDropdownByText(driver, outputType);
        }

        #endregion

        #region Choose Output Type and tab out to get records
        /// <summary>
        /// Filters output type filter
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="outputType"></param>
        /// <returns></returns>
        public static void ChooseOutputTypeTabOutGetRecords(IWebDriver driver, string outputType)
        {
            var customeroutputPage = new CustomerCommunicationPage(driver);
            customeroutputPage.CfoHistoryOutputTypeFilter.PickDropdownByText(driver, outputType);
            
        }

        #endregion

        #region Choose Customer
        /// <summary>
        /// Filter by Customer
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="customer"></param>
        public static void ChooseCustomer(IWebDriver driver, string customer)
        {
            var customeroutputPage = new CustomerCommunicationPage(driver);
            customeroutputPage.CfoHistoryCustomerFilter.PickDropdownByText(driver, customer);
        }

        #endregion

        #region Choose Sent By
        /// <summary>
        /// Filter using Sent By
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="sentBy"></param>
        public static void ChooseSentBy(IWebDriver driver, string sentBy)
        {
            var customeroutputPage = new CustomerCommunicationPage(driver);
            customeroutputPage.CfoHistorySentByFilter.PickDropdownByText(driver, sentBy);
        }

        #endregion

        #region Choose Date Range
        /// <summary>
        /// Filter by Date Range
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="daterange"></param>
        public static void ChooseDateRange(IWebDriver driver, string daterange)
        {
            var customeroutputPage = new CustomerCommunicationPage(driver);
            customeroutputPage.CfoHistoryDateFilter.PickDropdownByText(driver, daterange);
        }

        #endregion

        #region Verify CFO History Grid
        /// <summary>
        /// Validate the table count
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="tableData"></param>
        /// <returns></returns>
        public static bool VerifyCfoHistoryGrid(List<Dictionary<string, object>> tableData)
        {
            if (tableData.Count >= 1)
                return tableData[0].Values.Count > 2;
            return false;
        }
        #endregion

        #region Choose Date Filter
        /// <summary>
        /// for given int number of days, choose corresponding Date filter
        /// </summary>
        /// <param name="option"></param>
        public static void ChooseDateFilter(IWebDriver driver, int option)
        {
            switch (option)
            {
                case 7:
                    driver.PickDropdownByText(By.Id(QuoteIDs.CfoHistoryDateFilter), "Last 7 days");
                    break;
                case 10:
                    driver.PickDropdownByText(By.Id(QuoteIDs.CfoHistoryDateFilter), "Last 10 days");
                    break;
                case 30:
                    driver.PickDropdownByText(By.Id(QuoteIDs.CfoHistoryDateFilter), "Last 30 days");
                    break;
                case 60:
                    driver.PickDropdownByText(By.Id(QuoteIDs.CfoHistoryDateFilter), "Last 60 days");
                    break;
                case 90:
                    driver.PickDropdownByText(By.Id(QuoteIDs.CfoHistoryDateFilter), "Last 90 days");
                    break;
                case 0:
                    driver.PickDropdownByText(By.Id(QuoteIDs.CfoHistoryDateFilter), "Today");
                    break;
                default:
                    driver.PickDropdownByText(By.Id(QuoteIDs.CfoHistoryDateFilter), "All");
                    break;
            }
        }

        #endregion

        #region Click on Output Grid 1st Row View /  Resend Button

        public static void ClickCustomerOutputGridViewButton(IWebDriver driver)
        {
            var customerOutputPage = new CustomerCommunicationPage(driver);
            customerOutputPage.ClickViewButton();
        }

        public static void ClickCustomerOutputGridResendButton(IWebDriver driver)
        {
            var customerOutputPage = new CustomerCommunicationPage(driver);

            customerOutputPage.ClickResendButton();

        }

        #endregion

        #region Below method could be used for all Output types selection and clicking on VIEW button
        /// <summary>
        /// View customer output page and click on View button
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="outputType"></param>
        public static void ViewCustomerOutputPageClickViewButton(IWebDriver driver, string outputType)
        {
            var customerCommPage = new CustomerCommunicationPage(driver);
            HomeWorkflow.GoToCustomerCommunicationPage(driver);
            ChooseOutputType(driver, outputType);
            if (!customerCommPage.NoItemsinList())
            {
                ClickCustomerOutputGridViewButton(driver);
            }
        }

        #endregion

        #region Below method could be used for all Output types selection and clicking on RESEND button
        /// <summary>
        /// View Customer output page and click on Resend button
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="outputType"></param>
        /// <param name="email"></param>
        public static void ViewCustomerOutputPageClickResendButton(IWebDriver driver, string outputType, string email)
        {
            var customerCommPage = new CustomerCommunicationPage(driver);
            HomeWorkflow.GoToCustomerCommunicationPage(driver);
            ChooseOutputType(driver, outputType);
            if (!customerCommPage.NoItemsinList())
            {
                ClickCustomerOutputGridResendButton(driver);
                if (customerCommPage.IsResendCfoDialog())
                {
                    customerCommPage.AppendEmailResend(email);
                }
            }

        }


        #endregion

        #region Get Quotes Specific to Customer
        /// <summary>
        /// Get Quotes specific to customer
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="outputType"></param>
        /// <param name="customer"></param>
        public static void GetQuotesSpecificToCustomer(IWebDriver driver, string outputType, string customer)
        {
            var customerCommPage = new CustomerCommunicationPage(driver);
            HomeWorkflow.GoToCustomerCommunicationPage(driver);
            ChooseOutputType(driver, outputType);
            ChooseCustomer(driver, customer);
        }

        #endregion

        #region Get Quotes Specific to Sales rep
        /// <summary>
        /// get Quotes specific to Sales representative
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="outputType"></param>
        /// <param name="salesRep"></param>
        public static void GetQuotesSpecificToSalesrep(IWebDriver driver, string outputType, string salesRep)
        {
            var customerCommPage = new CustomerCommunicationPage(driver);
            HomeWorkflow.GoToCustomerCommunicationPage(driver);
            ChooseOutputType(driver, outputType);
            ChooseSentBy(driver, salesRep);
        }

        #endregion

        #region Get Quotes Specific to Date Range
        /// <summary>
        /// get quote specific to date range provided
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="outputType"></param>
        /// <param name="dateRange"></param>
        public static void GetQuotesSpecificToDateRange(IWebDriver driver, string outputType, string dateRange)
        {
            var customerCommPage = new CustomerCommunicationPage(driver);
            HomeWorkflow.GoToCustomerCommunicationPage(driver);
            ChooseOutputType(driver, outputType);
            ChooseDateRange(driver, dateRange);
        }

        #endregion

        #region Get Documents Specific By Document Number
        /// <summary>
        /// get documents by document number
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="outputType"></param>
        /// <param name="documentNumber"></param>
        /// <param name="documentNumber1"></param>
        public static void GetDocumentsSpecificByDocumentNumber(IWebDriver driver, string outputType,
            string documentNumber, string documentNumber1)
        {
            var customerCommPage = new CustomerCommunicationPage(driver);
            HomeWorkflow.GoToCustomerCommunicationPage(driver);
            ChooseOutputType(driver, outputType);
            customerCommPage.EnterDocumentNumber(documentNumber);
            customerCommPage.EnterDocumentNumber(documentNumber1);
        }

        #endregion

        public static void WaitForGridLoad(IWebDriver driver)
        {
            bool elestatus;
            for (int i = 1; i <= 10; i++)
            {
                do
                {
                    var wait = new WebDriverWait(driver, DsaUtil.GlobalWaitTime);
                    elestatus = wait.Until<bool>(ExpectedConditions.InvisibilityOfElementLocated(OpenQA.Selenium.By.XPath("//div[@id='DataTables_div_']//table//inline-busy/span")));
                    //i++;
                } while (elestatus == false);

            }
        }
    }
}
