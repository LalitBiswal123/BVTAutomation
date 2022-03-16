using Dsa.Enums;
using Dsa.Pages.Quote;
using Dsa.Utils;
using OpenQA.Selenium;
using ProductSearchPage = Dsa.Pages.ProductSearchPage;
using Dsa.Pages.ARB;
using Dsa.Pages.Order;

namespace Dsa.Workflows
{
    /// <summary>
    /// ARB workflows will be defined in this class.
    /// </summary>
    public static class ArbWorkflow
    {
        #region Add an ARB item

        public static string AddArbItem(IWebDriver driver)
        {
            new DellOutletProductsPage(driver).OptiPlexDesktopsTab.Click(driver);
            var serviceTag = new DellOutletProductsPage(driver).LblServiceTagAt(1).GetText(driver);
            new DellOutletProductsPage(driver).BtnAddArbItemAt(1).Click(driver);
            new DellOutletProductsPage(driver).LnkCurrentQuote.Click(driver);
            return serviceTag;
        }

        public static string AddVostroLaptop(IWebDriver driver)
        {
            new DellOutletProductsPage(driver).VostroLaptopsTab.Click(driver);
            var serviceTag = new DellOutletProductsPage(driver).LblServiceTagAt(1).GetText(driver);
            new DellOutletProductsPage(driver).BtnAddArbItemAt(1).Click(driver);
            new DellOutletProductsPage(driver).LnkCurrentQuote.Click(driver);
            return serviceTag;
        }
        #endregion

        #region Add an ARB monitor
        public static string AddArbMonitor(IWebDriver driver)
        {
            new DellOutletProductsPage(driver).MonitorsTab.Click(driver);
            new DellOutletProductsPage(driver).lnkQuantity.Click(driver);
            new DellOutletProductsPage(driver).lnkQuantity.Click(driver);
            var quantity_Before = new DellOutletProductsPage(driver).LblQuantityAt(1).GetText(driver);
            new DellOutletProductsPage(driver).BtnAddArbMonitorAt(1).Click(driver);
            driver.VerifyBusyOverlayNotDisplayed();
            new DellOutletProductsPage(driver).lnkQuantity.Click(driver);
            new DellOutletProductsPage(driver).lnkQuantity.Click(driver);
                var quantity_After = new DellOutletProductsPage(driver).LblQuantityAt(1).GetText(driver);
            while(quantity_Before == quantity_After)
            {
                new DellOutletProductsPage(driver).lnkQuantity.Click(driver);
                new DellOutletProductsPage(driver).lnkQuantity.Click(driver);
                quantity_After = new DellOutletProductsPage(driver).LblQuantityAt(1).GetText(driver);
                driver.VerifyBusyOverlayNotDisplayed();
            }
            new DellOutletProductsPage(driver).LnkCurrentQuote.Click(driver);
            return quantity_After;
        }
        #endregion

        #region Check ARB system in the inventory

        public static bool IsArbSystemAvailable(IWebDriver driver, string serviceTag)
        {
            new DellOutletProductsPage(driver).ServiceTagSearchTxt.SetText(driver, serviceTag);
            new DellOutletProductsPage(driver).SearchServiceTag();
            return !new DellOutletProductsPage(driver).Pagination.Text.Contains("0 of 0");
        }

        #endregion

        #region Go to ARB products page without selecting catalog

        public static DellOutletProductsPage ArbProductsPage(IWebDriver driver)
        {
            HomeWorkflow.GotoProductSearchPage(driver);
            new ProductSearchPage(driver).SelectCatalog((Catalogs.Consumer));
            return new ProductSearchPage(driver).DellOutletProductsPage();
        }

        #endregion

        #region Create ARB order with Prepaid check payment

        public static OrderDetailsPage CreateOrder(IWebDriver driver)
        {
            var quoteDetails = new QuoteDetailsPage(driver);
            var orderSave = quoteDetails.CreateOrder()
                .WillNotExportOutsideUs()
                .EmailConfirmationNextWithoutSendingOrder()
                .SelectFirstPaymentMethod(PaymentMethodType.Prepaidcheck.ToString());
            orderSave.PaymentMethodNext();
            return new OrderReviewPage(driver).SaveOrder();
        }

        #endregion

    }
}
