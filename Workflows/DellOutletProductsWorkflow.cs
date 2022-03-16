using Dsa.Pages.ARB;
using Dsa.Pages.Quote;
using Dsa.Utils;
using OpenQA.Selenium;
using Dsa.Pages.APOS;

namespace Dsa.Workflows
{
    /// <summary>
    /// Dell outlet products related workflows are to be written in this class.
    /// </summary>
    public class DellOutletProductsWorkflow
    {

        #region Search Outlet Products by MOD Search
        /// <summary>
        /// Searches the Dell Outlet Products by MOD Search.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="modNumbers">MOD numbers.</param>
        /// <returns></returns>
        public  DellOutletProductsPage SearchOutletProductsByModSearch(IWebDriver driver, string modNumbers)
        {
            var outletProducts = new DellOutletProductsPage(driver);
            outletProducts.ModNumbersSearchTxt.SetText(driver, modNumbers);
            return (DellOutletProductsPage)outletProducts.FilterDellOutletProducts();
        }

        #endregion

        #region Search Outlet Products by Service Tag
        /// <summary>
        /// Search Dell Outlet Products using Service Tag search
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="ServiceTag">Service Tag.</param>
        /// <returns></returns>
        public  DellOutletProductsPage SearchOutletProductsByServiceTag(IWebDriver driver, string serviceTag)
        {
            var outletProducts = new DellOutletProductsPage(driver);
            outletProducts.ServiceTagSearchTxt.SetText(driver, serviceTag);
            return (DellOutletProductsPage)outletProducts.SearchServiceTag();
        }

        #endregion

        #region Add Outlet Monitor to Cart
        /// <summary>
        /// Add an ARB monitor to the cart
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="accessoryNumber">accessoryNumber.</param>
        /// <returns></returns>
        public DellOutletProductsPage AddOutleMonitorToCart(IWebDriver driver, string accessoryNumber)
        {
            var outletProducts = new DellOutletProductsPage(driver);
            outletProducts.MonitorsTab.Click(driver);
            return (DellOutletProductsPage)outletProducts.AddDellOutletMonitor(accessoryNumber);
        }

        #endregion

        #region Add Outlet Products to Cart
        /// <summary>
        /// Filter a laptop based on a model and add to the cart
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="accessoryNumber">accessoryNumber.</param>
        /// <returns></returns>
        public ARBConfigurePage AddOutletProductsToCart(IWebDriver driver)
        {
            var outletProducts = new DellOutletProductsPage(driver);
            outletProducts.LaptopsTab.Click(driver);
            outletProducts.ModelFilterSelections();
            return (ARBConfigurePage)outletProducts.AddDellOutletProduct();
        }

        #endregion

        #region Configur Dell Outlet Products
        /// <summary>
        /// Configure a refurbished monitor as a tied item and view quote
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public void ConfigureDellOutletproducts(IWebDriver driver)
        {
            var arbConfigure = new ARBConfigurePage(driver);
            arbConfigure.SelectMonitor();
            new AposConfigurePage(driver).UpdateSummary();
        }

        #endregion

        #region View Quote
        /// <summary>
        /// view quote
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public CreateQuotePage ViewQuote(IWebDriver driver)
        {
            var arbConfigure = new ARBConfigurePage(driver);
            return (CreateQuotePage)arbConfigure.ViewArbQuote();
        }

        #endregion

        #region Configur Non Tied Module
        /// <summary>
        /// Configure a non tied module and update summary
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public void ConfigureNonTiedModule(IWebDriver driver)
        {
            var arbConfigure = new ARBConfigurePage(driver);
            arbConfigure.SelectNonTiedModule();
            new AposConfigurePage(driver).UpdateSummary();
        }

        #endregion

    }
}
