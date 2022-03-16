using System.Collections.Generic;
using System.Linq;
using Dsa.Enums;
using Dsa.Pages;
using Dsa.Pages.Account;
using Dsa.Pages.Admin;
using Dsa.Pages.ARB;
using Dsa.Pages.Customer;
using Dsa.Pages.Quote;
using Dsa.Utils;
using OpenQA.Selenium;
using Dsa.Pages.APOS;
using Dsa.Pages.Order;
using Dsa.Pages.PCFConvergence;
using System;
using Dsa.Pages.ManagePartnerFavorites;

namespace Dsa.Workflows
{
    /// <summary>
    /// Workflow class for Home Page. All homepage related workflows should be defined in this class.
    /// </summary>
    public static class HomeWorkflow
    {
        #region Go to Account Search Page
        /// <summary>
        /// Goes to account search page.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public static AccountSearchPage GoToAccountSearchPage(IWebDriver driver)
        {
            var mainMenu = new HomePage(driver).ClickMainMenu(driver);
            return mainMenu.SearchAccount();
        }

        #endregion

        #region Go to Person Search
        public static PersonSearchPage GoToPersonSearch(IWebDriver driver)
        {
            var mainMenu = new HomePage(driver).ClickMainMenu(driver);
            return mainMenu.SearchPerson();
        }

        #endregion

        #region Go to Bulk UI Page
        public static AutomationPage GoToAutomationPage(IWebDriver driver)
        {
            var mainMenu = new HomePage(driver).ClickMainMenu(driver);
            return mainMenu.AutomationWorkflow();

        }

        #endregion

        #region Go to Organizarion Search
        public static OrganizationSearchPage GoToOrganizationSearch(IWebDriver driver)
        {
            var mainmenu = new HomePage(driver).ClickMainMenu(driver);
            return mainmenu.SearchOrganization();
        }

        public static void GoToCustomerCreatePage(object testWebDriver)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Go to Quote Search Page
        /// <summary>
        /// Goes to create quote search page.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public static QuoteSearchPage GoToQuoteSearchPage(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.SearchQuote();
        }

        /// <summary>
        /// Goes to quote summary search page.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public static QuoteSearchPage GoToQuoteSummarySearchPage(IWebDriver driver)
        {
            var pcfSummaryPage = new PCFQuoteSummaryPage(driver);           
            return pcfSummaryPage.MenuQuoteSearch();
        }

        #endregion

        #region Go to Manage Held Orders Page
        /// <summary>
        /// Goes to Manage Held Orders page.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public static ManageHeldOrdersPage GoToManageHeldOrdersPage(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.OrderHeldWorkflow();
        }

        #endregion

        #region Go to Order Search Page
        /// <summary>
        /// Goes to order search page.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public static OrderSearchPage GoToOrderSearchPage(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.SearchOrder();
        }

        #endregion

        #region Go to Product Search Page
        /// <summary>
        /// Goes to the Product search Page
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public static ProductSearchPage GotoProductSearchPage(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.SearchProduct();
        }

        #endregion

        #region Go to Service Tag Page
        /// <summary>
        /// Goes to the Service Tag Search Page
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public static ServiceTagSearchPage GotoServiceTagPage(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.ServiceTagClick();
        }

        #endregion

        #region Go to Customer Create Page
        /// <summary>
        /// Goes to customer create page.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public static CustomerCreatePage GoToCustomerCreatePage(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.AddCustomer();
        }

        #endregion

        #region Go to Quote Create Page
        /// <summary>
        /// Goes to quote create page.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public static CreateQuotePage GoToQuoteCreatePage(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.AddQuote();
        }

        #endregion

        #region Go to Manage Partner Favorite Page
        /// <summary>
        /// Goes to Manage Partner Favorites Page.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public static MPFPage GoToManagePartnerFavoritesPage(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.NavigatetoManagePartner();
        }

        #endregion

        #region Go to Quote Create Page using Solution
        public static CreateQuotePage GoToQuoteCreatePageUsingSolution(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.AddSolution();
        }

        #endregion

        #region Go to Dell Outlet Products Page
        /// <summary>
        /// Goes to Dell outlet products page
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public static DellOutletProductsPage GoToDellOutletProductsPage(IWebDriver driver)
        {
            GotoProductSearchPage(driver);
            var productsearchpage = new ProductSearchPage(driver);
            productsearchpage.SelectCatalog((Catalogs.Consumer));
//            System.Threading.Thread.Sleep(4000);
            return productsearchpage.DellOutletProductsPage();
        }

        #endregion

        #region Go to Customer Communication Page
        /// <summary>
        /// Goes to customer communication page.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public static CustomerCommunicationPage GoToCustomerCommunicationPage(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.CustomerCommunication();
        }

        #endregion

        #region Verify Recent Activity Type Options
        public static bool VerifyRecentActivityTypeOptions(IWebDriver driver)
        {
            var recentActivitiesFilterOptions = new List<string> { "Quotes Created", "Orders Created", "Solutions Created", "Opportunities" };
            foreach (var recentActivitiesFilterOption in recentActivitiesFilterOptions)
            {
                new HomePage(driver).SelectRecentActivitiesFilterOption(recentActivitiesFilterOption);
                if (new HomePage(driver).AllRecentActivityTypes().Any() &&
                    new HomePage(driver).AllRecentActivityTypes().Any(x => x != recentActivitiesFilterOption))
                    return false;
            }

            return true;
        }

        #endregion

        #region Go to Legacy Cart
        public static ImportCartPopUp GoToLegacyCart(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.ImportLegacyCart();
        }

        #endregion

        #region Go to my Preferences Page
        /// <summary>
        /// Goes to My Preferences page.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public static MyPreferencesPage GoToMyPreferencesPage(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.MyPreferences();
        }

        #endregion

        #region Go to Sales Edge Page
        /// <summary>
        /// Get Sales edge link from main menu
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public static void ClickSalesEdgeLinkFromMenu(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            mainMenu.LnkSalesEdge.Click();
        }

        #endregion

        #region Go to DSA Learn more Page
        /// <summary>
        /// Click on Sales edge from main menu
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public static void ClickDSALearnMoreLinkFromMenu(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            mainMenu.LnkDsaLearnMore.Click();
        }

        public static string GetDSARFPLinkFromMenu(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            string hrefForRFP = mainMenu.DSARFP();
            return hrefForRFP;
        }
        #endregion

        #region Go to Access and Support Page

        /// <summary>
        /// Get Access and Support link from Menu
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public static void ClickAccessAndSupportLinkFromMenu(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            mainMenu.LnkAccessNSupport.Click();
        }

        #endregion


        #region Go to GamaLink
        public static HomePage GamaLink(IWebDriver driver)
        {
            var mainMenu = new HomePage(driver).ClickMainMenu(driver);
            return mainMenu.GamaLink();
        }

        #endregion

        #region Go to Admin Page

        /// <summary>
        /// Goes to Admin page.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public static AdministrationPage GoToAdminPage(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.Admin();
        }

        #endregion

        #region Go to Customer Search Page
        /// <summary>
        /// Goes to customer search page.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public static CustomerSearchPage GoToCustomerSearchPage(IWebDriver driver)
        {
            var homepage = new HomePage(driver);
            var mainMenu = homepage.ClickMainMenu(driver);

            return mainMenu.CustomerSearchClick();
        }

        #endregion

        #region Go to Preview Page
        /// <summary>
        /// Goes to preview page.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public static PreviewOrderCodePage GoToPreviewPage(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.Preview();
        }

        #endregion

        #region  Go to RFP & Proposal and Express Portal
        public static PreviewOrderCodePage GoToRFPPage(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.RFPandProposalExpressPortal();
        }

        #endregion



        #region Click Main menu Search Product
        /// <summary>
        /// Goes to product search page.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public static ProductSearchPage ClickMainMenuSearchProduct(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.SearchProduct();
        }

        #endregion

        #region Click Main menu Reporting
        public static OrderHistoryReportPage ClickMainMenuReporting(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.Reporting();
        }

        #endregion

        #region Click Main menu Home
        public static HomePage ClickMainMenuHome(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.Home();
        }

        #endregion

        #region Click Service Tag menu Home
        public static ServiceTagSearchPage ClickServiceTagMenuHome(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.ServiceTagClick();
        }

        #endregion

        #region Go to View Order Hold
        public static HeldOrderPage GoToViewOrderHold(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);

            return mainMenu.ViewOrderHold();
        }

        #endregion

        #region Go to Sales Rept Tagging Page
        /// <summary>
        /// Goes to Sales Rep Tagging page.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public static SalesRepTaggingPage GoToSalesReptTaggingPage(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.SalesRepTagging();
        }

        #endregion

        #region Go to Solutions Page
        /// <summary>
        /// Goes to the Solution search Page
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public static SolutionSearchPage GotoSolutionSearchPage(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.SearchSolution();
        }
        #endregion


        #region Go to DSAM Page
        /// <summary>
        /// Goes to customer search page.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public static PriceRequestPage GoToDSAMPage(IWebDriver driver)
        {
            var homepage = new HomePage(driver);
            var mainMenu = homepage.ClickMainMenu(driver);

            return mainMenu.DSAMClick();
        }

        #endregion

        ///// <summary>
        ///// Goes to quote create page.
        ///// </summary>
        ///// <param name="driver">The driver.</param>
        ///// <returns></returns>
        //public static SolutionsHomePage GoToSolutionsHomePage(IWebDriver driver)
        //{
        //    var homePage = new HomePage(driver);
        //    var mainMenu = homePage.ClickMainMenu();
        //    return mainMenu.SolutionsHome();
        //}

        public static DAMReqPendingApprovalsPage GoToDAMrequest_PendingApprovalPage(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            mainMenu.LnkDAMreqPendingApprovals.Click(driver);
            return new DAMReqPendingApprovalsPage(driver);
        }

        public static DAMRequestsPage GoToDAMrequestsPage(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            mainMenu.LnkDAMRequests.Click(driver);
            return new DAMRequestsPage(driver);
        }


   }
}
