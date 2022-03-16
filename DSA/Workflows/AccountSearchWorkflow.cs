using Dsa.Pages.Account;
using Dsa.Utils;
using OpenQA.Selenium;

namespace Dsa.Workflows
{
    /// <summary>
    /// Account search related workflows are to be written in this class.
    /// </summary>
    public static class AccountSearchWorkflow
    {

        #region Account Search ENUM
        /// <summary>
        /// Account search type enum
        /// </summary>
        public enum AccountSearchType
        {
            ByAccountName,
            ByAccountNumber,
            BySfdcDealId,
            ByCustomerNumber
        }

        #endregion

        #region Account Search Workflows

        #region Search by Account Number

        /// <summary>
        /// Searches the account by account number.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="accountNumber">The account number.</param>
        /// <returns></returns>
        public static AccountDetailsPage SearchAccountByAccountNumber(IWebDriver driver, string accountNumber)
        {
           // HomeWorkflow.GoToAccountSearchPage(driver);
            var accountSearch = new AccountSearchPage(driver);
            accountSearch.TxtAccountNumber.SetText(driver, accountNumber);
            return (AccountDetailsPage)accountSearch.ExecuteSearch(driver);
        }
        
        #endregion

        #region Search by SDFC Deal ID

        /// <summary>
        /// Searches the account by SFDC deal identifier.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="sfdcDealId">The SFDC deal identifier.</param>
        /// <returns></returns>
        public static AccountDetailsPage SearchAccountBySfdcDealId(IWebDriver driver, string sfdcDealId)
        {
            HomeWorkflow.GoToAccountSearchPage(driver);
            var accountSearch = new AccountSearchPage(driver);
            accountSearch.TxtSfdcDealId.SetText(driver, sfdcDealId);
            return (AccountDetailsPage)accountSearch.ExecuteSearch(driver);
        }

        #endregion

        #region Search by Customer Number

        /// <summary>
        /// Searches the account by customer number.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="customerNumber">The customer number.</param>
        /// <returns></returns>
        public static AccountDetailsPage SearchAccountByCustomerNumber(IWebDriver driver, string customerNumber)
        {
            //HomeWorkflow.GoToAccountSearchPage(driver);
            var accountSearch = new AccountSearchPage(driver);
            accountSearch.TxtCustomerNumber.SetText(driver, customerNumber);
            return (AccountDetailsPage)accountSearch.ExecuteSearch(driver);
        }

        #endregion

        #region Search by Account Name

        /// <summary>
        /// Searches the account by account name.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="accountName">Name of the account.</param>
        /// <returns></returns>
        public static AccountDetailsPage SearchAccountByAccountName(IWebDriver driver, string accountName)
        {
            HomeWorkflow.GoToAccountSearchPage(driver);
            var accountSearch = new AccountSearchPage(driver);
            accountSearch.TxtAccountName.SetText(driver, accountName);
            return (AccountDetailsPage)accountSearch.ExecuteSearch(driver);
        }

        public static AccountDetailsPage SearchAccountBySFDCdealId(IWebDriver driver, string SFDC)
        {
            HomeWorkflow.GoToAccountSearchPage(driver);
            var accountSearch = new AccountSearchPage(driver);
            accountSearch.TxtAccountName.SetText(driver, SFDC);
            return (AccountDetailsPage)accountSearch.ExecuteSearch(driver);
        }

        #endregion

        #region Search Account

        /// <summary>
        /// Searches the account with search type and text to search.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="searchType">Type of the search.</param>
        /// <param name="textToSearch">The text to search.</param>
        /// <returns></returns>
        public static AccountDetailsPage SearchAccount(IWebDriver driver, AccountSearchType searchType, string textToSearch)
        {
            var accountDetailsPage = new AccountDetailsPage(driver);
            switch (searchType)
            {
                case AccountSearchType.ByAccountName:
                    accountDetailsPage = SearchAccountByAccountName(driver, textToSearch);
                    break;
                case AccountSearchType.ByAccountNumber:
                    accountDetailsPage = SearchAccountByAccountNumber(driver, textToSearch);
                    break;
                case AccountSearchType.BySfdcDealId:
                    accountDetailsPage = SearchAccountBySfdcDealId(driver, textToSearch);
                    break;
                case AccountSearchType.ByCustomerNumber:
                    accountDetailsPage = SearchAccountByCustomerNumber(driver, textToSearch);
                    break;
            }

            return accountDetailsPage;
        }

        #endregion

    }

        #endregion
    
}
