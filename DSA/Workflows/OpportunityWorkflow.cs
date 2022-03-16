using Dsa.Enums;
using Dsa.Pages.Account;
using Dsa.Pages.Opportunity;
using Dsa.Pages.Quote;
using OpenQA.Selenium;

namespace Dsa.Workflows
{
    public static class OpportunityWorkflow
    {
        public static void CreateQuoteFromOpportunityDetails(IWebDriver driver, string opportunityDealId,
            string customerNumber, Catalogs catalog, string opportunityLineId, string contractCode, bool updateOpportunity,
            bool saveQuote = true)
        {
            AccountSearchWorkflow.SearchAccountBySfdcDealId(driver, opportunityDealId);
            new AccountDetailsPage(driver).GoToOpportunityDetailsFromOpportunityList(opportunityDealId)
                .CreateQuote()
                .SelectCatalog(catalog)
                .ChooseCustomerFromAccount(customerNumber)
                .AddItemFromOpportunity(opportunityLineItemId: opportunityLineId)
                .AddItemToCart().GoToCurrentQuotePage();

            if (!string.IsNullOrEmpty(contractCode))
                new CreateQuotePage(driver).ApplyContractCodeToAllItems(contractCode);

        }

        public static OpportunityDetailsPage GoToOpportunityDetails(IWebDriver driver, string opportunityDealId)
        {
            AccountSearchWorkflow.SearchAccountBySfdcDealId(driver, opportunityDealId);
            new AccountDetailsPage(driver).GoToOpportunityDetailsFromOpportunityList(opportunityDealId);

            return new OpportunityDetailsPage(driver);
        }
    }
}