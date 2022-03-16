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
        public static CustomerDetailsPage SearchCustomerByCustomerNumber(IWebDriver driver, string customerNumber)
        {
            var customer = HomeWorkflow.GoToCustomerSearchPage(driver);
            customer.SearchPersonByCustomerNumber(customerNumber);
            DsaUtil.WaitForPageLoad(driver);
            new CustomerDetailsPage(driver).WaitForCustomerDetailsPageToLoad();
            return new CustomerDetailsPage(driver);
        }

        #endregion
    }
}
