using Dsa.Pages.Quote;
using Dsa.Utils;
using OpenQA.Selenium;

namespace Dsa.Workflows
{
    public static class ExportQuoteWorkflow
    {
        public static void ExportQuote(IWebDriver driver, string customerSet, string emailAddr)
        {
            new QuoteDetailsPage(driver).MoreActions().SaveAseQuote.Click(driver);
            new QuoteDetailsPage(driver).CustomerSetEnterTab.Click(driver);
            new QuoteDetailsPage(driver).TxtCustomerSetEnter.SetText(driver, customerSet);
            new QuoteDetailsPage(driver).BtnCustomerSetSearch.Click(driver);
            new QuoteDetailsPage(driver).TxtRecipientEmail.SetText(driver, emailAddr);
            new QuoteDetailsPage(driver).BtnCreateEquote.Click(driver);
            driver.WaitForBusyOverlay();
        }
    }
}
