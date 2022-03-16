using Dsa.Pages.Quote;
using Dsa.Utils;
using OpenQA.Selenium;

namespace Dsa.Workflows
{
    public static class StandardConfigWorkflow
    {
        public static void PickCustomerSet(IWebDriver driver, string customerSet)
        {
            new QuoteDetailsPage(driver).MoreActions().ExportStandardConfig.Click(driver);
            new QuoteDetailsPage(driver).CustomerSetEnterTab.Click(driver);
            new QuoteDetailsPage(driver).TxtCustomerSetEnter.SetText(driver, customerSet);
            new QuoteDetailsPage(driver).BtnCustomerSetSearch.Click(driver);
        }

        public static void SelectConfig(IWebDriver driver, int itemIndex, string description, string category, bool saveConfig = false)
        {
            new QuoteDetailsPage(driver).ChkboxExportIsSelected(itemIndex).Click(driver);
            new QuoteDetailsPage(driver).TxtExportTitle(itemIndex).SetText(driver, description);
            new QuoteDetailsPage(driver).DrpdwnExportCategoryId(itemIndex).PickDropdownByText(driver, category);
            if (saveConfig)
                new QuoteDetailsPage(driver).BtnSaveConfig.Click(driver);
            driver.WaitForBusyOverlay();
        }
    }
}
