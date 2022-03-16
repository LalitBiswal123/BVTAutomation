using System;
using Dsa.Pages;
using Dsa.Pages.Customer;
using Dsa.Pages.Quote;
using Dsa.Pages.PCFConvergence;
using Dsa.Utils;
using OpenQA.Selenium;

namespace Dsa.Workflows
{
    public static class StandardConfigWorkflow
    {
        public static void PickCustomerSet(IWebDriver driver, string customerSet)
        {
            new PCFQuoteSummaryPage(driver).MoreActions().ExportStandardConfig.Click(driver);
            driver.VerifyBusyOverlayNotDisplayed();
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

        public static bool ValidatePremierPage(IWebDriver driver, string RCNO)
        {
            new CustomerDetailsPage(driver).PremierPages.Click(driver);
            driver.VerifyBusyOverlayNotDisplayed();
            new CustomerDetailsPage(driver).ViewAllPremierPages.Click(driver);
            driver.VerifyBusyOverlayNotDisplayed();
            var rcno = driver.FindElement(By.XPath(String.Format("//td[contains(text(),'{0}')]", RCNO)));
            if (rcno != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Selects a standard config from premier store and adds it to quote.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="rcno"></param>
        /// <param name="category"></param>
        public static void AddStandardConfigToQuote(IWebDriver driver, string rcno, string category)
        {
            //Pick a RC# and click on Open
            new PremierPages(driver).OpenPremierPage(rcno);
            // Select Catalog.
            if (driver.GetElement(By.XPath("(//*[@id='DataTables_Table_companyNumbers']//a[text()='Select'])[1]"), TimeSpan.FromSeconds(5)) != null)
            {
                driver.GetElement(By.XPath("(//*[@id='DataTables_Table_companyNumbers']//a[text()='Select'])[1]")).Click(driver);
            }
            // Wait for Spinner.
            driver.VerifyBusyOverlayNotDisplayed();

            //Land to Standard Config page
            //Expand any one category -- wait for the spinner
            new StandardConfigurationPage(driver).SelectACategory();
            new StandardConfigurationPage(driver).AddConfigsToQuote();
        }

        /// <summary>
        /// Checks if any `Add to Quote` button is enabled for provided rc number.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="rcno"></param>
        /// <returns></returns>
        public static bool CanAddConfigToQuote(IWebDriver driver, string rcno)
        {
            new PremierPages(driver).OpenPremierPage(rcno);
            new StandardConfigurationPage(driver).SelectACategory();
            return new StandardConfigurationPage(driver).CanAddAnyConfigToQuote();
        }
    }
}
