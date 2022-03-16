using Dsa.Pages.Customer;
using OpenQA.Selenium;
using Dsa.Utils;

namespace Dsa.Workflows
{
    /// <summary>
    /// Customer search related workflows are to be written in this class.
    /// </summary>
    public static class CustomerSearchWorkflow
    {
        #region Search Customer By Customer Number

        /// <summary>
        /// Search the Customer by Customer number.
        /// </summary>
        /// <param name="driver">Driver</param>
        /// <param name="customerNumber">Customer Number</param>
        /// <returns></returns>
        //public static CustomerDetailsPage SearchCustomerByCustomerNumber(IWebDriver driver, string customerNumber)
        //{
        //    var customerSearchPage = HomeWorkflow.GoToPersonSearch(driver);
        //    customerSearchPage.SearchPersonByCustomerNumber(customerNumber);
        //    DsaUtil.WaitForPageLoad(driver);
        //    new CustomerDetailsPage(driver).WaitForCustomerDetailsPageToLoad();
        //    return new CustomerDetailsPage(driver);
        //}

        public static CustomerDetailsPage SearchCustomerByCustomerNumber(IWebDriver driver, string customerNumber)
        {
            var customerSearchPage = HomeWorkflow.GoToCustomerSearchPage(driver);
            customerSearchPage.SearchCustomerByCustomerNumber(customerNumber);
            DsaUtil.WaitForPageLoad(driver);
            new CustomerDetailsPage(driver).WaitForCustomerDetailsPageToLoad();
            return new CustomerDetailsPage(driver);
        }

        #endregion

        #region Search Customer By Quote Number

        /// <summary>
        /// Search the Customer by Quote Number.
        /// </summary>
        /// <param name="driver">Driver</param>
        /// <param name="quoteNumber">Quote Number</param>
        /// <returns></returns>
        public static CustomerDetailsPage SearchCustomerByQuoteNumber(IWebDriver driver, string quoteNumber)
        {
            var customerSearchPage = HomeWorkflow.GoToCustomerSearchPage(driver);
            customerSearchPage.SearchCustomerByQuoteNumber(quoteNumber);
            DsaUtil.WaitForPageLoad(driver);
            new CustomerDetailsPage(driver).WaitForCustomerDetailsPageToLoad();
            return new CustomerDetailsPage(driver);
        }

        #endregion

        #region Search Customer By DPID

        /// <summary>
        /// Search the Customer by DPID.
        /// </summary>
        /// <param name="driver">Driver</param>
        /// <param name="dpid">DPID</param>
        /// <returns></returns>
        public static CustomerDetailsPage SearchCustomerByDpid(IWebDriver driver, string dpid)
        {
            var customerSearchPage = HomeWorkflow.GoToCustomerSearchPage(driver);
            customerSearchPage.SearchCustomerByDpid(dpid);
            DsaUtil.WaitForPageLoad(driver);
            new CustomerDetailsPage(driver).WaitForCustomerDetailsPageToLoad();
            return new CustomerDetailsPage(driver);
        }

        #endregion

        #region Search Customer By Order Number

        /// <summary>
        /// Search the Customer by Order Number.
        /// </summary>
        /// <param name="driver">Driver</param>
        /// <param name="orderNumber">Order Number</param>
        /// <returns></returns>
        public static CustomerDetailsPage SearchCustomerByOrderNumber(IWebDriver driver, string orderNumber)
        {
            var customerSearchPage = HomeWorkflow.GoToCustomerSearchPage(driver);
            customerSearchPage.SearchCustomerByOrderNumber(orderNumber);
            DsaUtil.WaitForPageLoad(driver);
            new CustomerDetailsPage(driver).WaitForCustomerDetailsPageToLoad();
            return new CustomerDetailsPage(driver);
        }

        public static CustomerSearchResultsPage SearchCustomerByUCID(IWebDriver driver, string UCID)
        {
            var customerSearchPage = HomeWorkflow.GoToCustomerSearchPage(driver);
            customerSearchPage.SearchCustomerByUCID(UCID);
            DsaUtil.WaitForPageLoad(driver);
           
            return new CustomerSearchResultsPage(driver);
        }

        public static CustomerSearchResultsPage AdvanceSerchbyCompanyName(IWebDriver driver, string CompanyName)
        {
            var customerSearchPage = HomeWorkflow.GoToCustomerSearchPage(driver);
            customerSearchPage.SearchCustomerByCompanyName(CompanyName);
            DsaUtil.WaitForPageLoad(driver);

            return new CustomerSearchResultsPage(driver);
        }


        #endregion

    }
}
