//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Pages.Account;
using Dsa.Pages.Admin;
using Dsa.Pages.Customer;
using Dsa.Pages.Order;
using Dsa.Pages.PCFConvergence;
using Dsa.Pages.Quote;
using Dsa.Utils;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Dsa.Pages
{
    public class HomePage : DsaPageBase
    {
        public IWebDriver WebDriver { get; }

        public HomePage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
            WebDriver = webDriver;


        }

        #region -- Elements --


public IWebElement MainMenuId { get { return WebDriver.GetElement(By.Id("dropMenu")); } }


public IWebElement ProductList { get { return WebDriver.GetElement(By.Id("dropMenu_productList")); } }


public IWebElement ImportLegacyCart { get { return WebDriver.GetElement(By.Id("menu_importLegacyCart_link")); } }


public IWebElement HomeGreeting { get { return WebDriver.GetElement(By.Id("home_greeting_h")); } }


public IWebElement DellLogoClass { get { return WebDriver.GetElement(By.Id("icon-ui-dell")); } }


public IWebElement ProductItemsSection { get { return WebDriver.GetElement(By.Id("mastHead_Container")); } }


public IWebElement ConfigItems { get { return WebDriver.GetElement(By.Id("mastHead_configItems")); } }


public IWebElement ViewQuote { get { return WebDriver.GetElement(By.Id("mastHead_viewQuote")); } }


public IWebElement LblMenuMain { get { return WebDriver.GetElement(By.Id("menu_main_label")); } }


public IWebElement MenuToggle { get { return WebDriver.GetElement(By.Id("menu_versionToggle")); } }


public IWebElement AccountSearchMenu { get { return WebDriver.GetElement(By.Id("menu_accountSearch")); } }


public IWebElement CustomerSearchMenu { get { return WebDriver.GetElement(By.Id("menu_personSearch")); } }


public IWebElement ProductPreviewMenu { get { return WebDriver.GetElement(By.Id("menu_previewOrder_link")); } }


public IWebElement OrderSearchMenu { get { return WebDriver.GetElement(By.Id("menu_orderSearch")); } }


public IWebElement ProductSearchMenu { get { return WebDriver.GetElement(By.Id("menu_productSearch")); } }


public IWebElement QuoteSearchMenu { get { return WebDriver.GetElement(By.Id("menu_quoteSearch")); } }


public IWebElement ProductItems { get { return WebDriver.GetElement(By.Id("menu_productItems")); } }


public IWebElement ProductItemsToggle { get { return WebDriver.GetElement(By.Id("menu_productItems_toggle")); } }


public IWebElement QuoteAddMenu { get { return WebDriver.GetElement(By.Id("menu_quoteAdd_link")); } }


public IWebElement CustomerAddMenu { get { return WebDriver.GetElement(By.Id("menu_customerAdd_link")); } }


public IWebElement LnkMenuHome { get { return WebDriver.GetElement(By.Id("menu_home_link")); } }

        //[FindsBy(How = How.XPath, Using = "//*[@id='yourCustomersSection']/div[2]/div/div/div[2]/div[1]/input")]

public IWebElement SearchCustomerHome { get { return WebDriver.GetElement(By.XPath("//*[@id='yourCustomersSection']//input[@type='text']")); } }


public IWebElement NewFavCutomer { get { return WebDriver.GetElement(By.XPath("//*[@id='favourite-customer-grid-customer-6a0dae0b-3a75-ea11-949f-005056826b40']/div/div/a")); } }
        //*[@id='favourite-customer-grid-customer-6a0dae0b-3a75-ea11-949f-005056826b40']//div//div/a

public IWebElement searchcustnumber { get { return WebDriver.GetElement(By.XPath("//*[@id='favourite-customer-grid']")); } }
        

public IWebElement WarningMsg { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-info']//p")); } }


public IWebElement NoCustomerMsg { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-info ng-star-inserted']//p")); } }


public IWebElement CustomerOutput { get { return WebDriver.GetElement(By.Id("menu_customerOutput")); } }


public IWebElement MenuCurrentQuoteId { get { return WebDriver.GetElement(By.Id("menu_currentQuote")); } }


public IWebElement MenuReports { get { return WebDriver.GetElement(By.Id("menu_reports")); } }


public IWebElement MenuAdmin { get { return WebDriver.GetElement(By.Id("menu_manageSecurityOutput")); } }


public IWebElement MenuSalesEdge { get { return WebDriver.GetElement(By.Id("menu_salesEdge")); } }


public IWebElement HomeMenu { get { return WebDriver.GetElement(By.Id("menu_home_link")); } }


public IWebElement MenuOrderHoldWorkflow { get { return WebDriver.GetElement(By.Id("menu_workflow")); } }

        //[FindsBy(How = How.Id, Using = "welcomeMessage")]
        //public IWebElement MsgWelcome;
        public IWebElement MsgWelcome { get { return WebDriver.GetElement(By.Id("welcomeMessage")); } }

        //[FindsBy(How = How.XPath, Using = "//h3[contains(text(), 'Recent Activity')]")]
        //public IWebElement HomeRecentActivity;
        public IWebElement HomeRecentActivity { get { return WebDriver.GetElement(By.XPath("//h3[contains(text(), 'Recent Activity')]")); } }

        //[FindsBy(How = How.Id, Using = "home-page-recent-activity-items-0")]
        //public IWebElement HomeRecentActivityList;
        public IWebElement HomeRecentActivityList { get { return WebDriver.GetElement(By.Id("home-page-recent-activity-items-0")); } }


public IWebElement RecentActivityGridId { get { return WebDriver.GetElement(By.Id("recentActivity_List")); } }


public IWebElement RecentActivityCreateQuote { get { return WebDriver.GetElement(By.Id("recentActivity_createQuote")); } }


public IWebElement RecentActivityDateRange { get { return WebDriver.GetElement(By.Id("recentActivity_dateRange")); } }


public IWebElement RecentActivityActivityType { get { return WebDriver.GetElement(By.Id("recentActivity_activityType")); } }


public IWebElement ActivityFilterResultGrid { get { return WebDriver.GetElement(By.Id("recentActivity_Grid")); } }


public IWebElement LblSearchYourCustomerOrAccount { get { return WebDriver.GetElement(By.XPath("//*[@id='yourCustomersSection']//*[contains(text(), 'Search Your')]")); } }


public IWebElement YourCustomersSection { get { return WebDriver.GetElement(By.Id("home-customer-list")); } }


public IWebElement LnkOpportunity { get { return WebDriver.GetElement(By.Id("activity-opportunity")); } }


public IWebElement OpportunityType { get { return WebDriver.GetElement(By.Id("activity-type")); } }


public IWebElement OpportunityDate { get { return WebDriver.GetElement(By.Id("timestamp")); } }


public IWebElement Accountheading { get { return WebDriver.GetElement(By.Id("account_Heading")); } }


public IWebElement CustomerInformations { get { return WebDriver.GetElement(By.Id("customers_info")); } }


public IWebElement SetFavSearchFieldTo { get { return WebDriver.GetElement(By.Id("search_value")); } }


public IWebElement CustomerExpandable { get { return WebDriver.GetElement(By.Id("customer_customerInformationToggle")); } }


public IWebElement RemoveCustomer { get { return WebDriver.GetElement(By.ClassName("remove-record")); } }


public IWebElement AddRemovedCustomer { get { return WebDriver.GetElement(By.Id("yourCustomersSection_add")); } }


public IWebElement FavCustomersInfo { get { return WebDriver.GetElement(By.Id("Fav_customers_info")); } }


public IWebElement LnkFavoriteCustomerNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='customer_info_1']/div/a[2]")); } }


public IWebElement FavouriteCustomersId { get { return WebDriver.GetElement(By.Id("home_viewall_favourite_customers")); } }


public IWebElement FavouriteCustomerGrid { get { return WebDriver.GetElement(By.Id("favouriteCustomer_Grid")); } }


public IWebElement CustomerGridDelete { get { return WebDriver.GetElement(By.Id("delete_customer_{0}")); } }


public IWebElement BtnAddCustomers { get { return WebDriver.GetElement(By.Id("add_customers")); } }


public IWebElement LnkAddFavoriteCustomer { get { return WebDriver.GetElement(By.XPath("//*[@id='yourCustomersSection']/div[1]/a[2]")); } }


public IWebElement LnkUndoAddFavoriteCustomer { get { return WebDriver.GetElement(By.XPath("//*[@id='add_favouriteCustomers']/div/p[3]/a[1]")); } }


public IWebElement AddFavCustomersPage { get { return WebDriver.GetElement(By.Id("add_favouriteCustomers")); } }


public IWebElement CustomerNumbers { get { return WebDriver.GetElement(By.Id("customer_numbers")); } }


public IWebElement AddFavCustomersInPopUp { get { return WebDriver.GetElement(By.Id("add_customer")); } }


public IWebElement AddCustomerPopUpOk { get { return WebDriver.GetElement(By.Id("add_customer_ok")); } }


public IWebElement AddCustomerPopUpCancel { get { return WebDriver.GetElement(By.Id("add_customer_cancel")); } }


public IWebElement ChkboxReplaceCustomers { get { return WebDriver.GetElement(By.Id("replace_customer")); } }


public IWebElement ConfirmRemovefavouriteCustomer { get { return WebDriver.GetElement(By.Id("confirmRemove_favouriteCustomer")); } }


public IWebElement ConfirmAddFavoriteCustomer { get { return WebDriver.GetElement(By.Id("favoured_customer_numbers")); } }


public IWebElement FirstFavoriteCustomer { get { return WebDriver.GetElement(By.Id("customer_info_1")); } }


public IWebElement FavoriteCustomerLoadingSpinner { get { return WebDriver.GetElement(By.XPath("//*[@id='add_favouriteCustomers']/div/div[4]/span/img")); } }


public IWebElement FavoriteCustomerNotification { get { return WebDriver.GetElement(By.XPath("//*[@id='add_favouriteCustomers']/div")); } }


public IWebElement SelectedCustomer { get { return WebDriver.GetElement(By.Id("customer_info")); } }


public IWebElement DeleteCustomer { get { return WebDriver.GetElement(By.Id("remove_customer")); } }


public IWebElement ConfirmMessageonDeleteCustomer { get { return WebDriver.GetElement(By.Id("customer_deletion_status")); } }


public IWebElement RemoveCustomerpopUpOk { get { return WebDriver.GetElement(By.Id("remove_customer")); } }


public IWebElement RemoveustomerPopUpCancel { get { return WebDriver.GetElement(By.Id("remove_customer_cancel")); } }


public IWebElement LnkSOARTool { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='Click to view Notifications in the SOAR tool']")); } }


public IWebElement AddCustomer { get { return WebDriver.GetElement(By.CssSelector("#yourCustomersSection > div.home-col-hdr > a:nth-child(4)")); } }


public IWebElement LnkViewAll { get { return WebDriver.GetElement(By.CssSelector("#yourCustomersSection > div.home-col-hdr > a:nth-child(2)")); } }


public IWebElement TxtCustomerNumber { get { return WebDriver.GetElement(By.Id("customer_numbers")); } }


public IWebElement BtnFinalAddCustomer { get { return WebDriver.GetElement(By.Id("add_customer")); } }


public IWebElement TblAddedCustomer { get { return WebDriver.GetElement(By.Id("customer_info")); } }

        //[FindsBy(How = How.XPath, Using = "//*[@class='home-sections']//select")]
        //public IWebElement DdlYourRecentActivity;
        public IWebElement DdlYourRecentActivity { get { return WebDriver.GetElement(By.XPath("//*[@class='home-sections']//select")); } }


public IWebElement LnkRecentActivity { get { return WebDriver.GetElement(By.Id("home_recentActivity_opportunity_1")); } }


public IWebElement DellLogoImage { get { return WebDriver.GetElement(By.Id("DellIcon")); } }


public IWebElement ServiceTag { get { return WebDriver.GetElement(By.Id("menu_serviceTagSearch")); } }


public IWebElement Organization { get { return WebDriver.GetElement(By.Id("menu_orgSearch")); } }


public IWebElement Person { get { return WebDriver.GetElement(By.Id("menu_personSearch")); } }

        //[FindsBy(How = How.XPath, Using = "//h3[contains(text(), 'Recent Activity')]/following-sibling::a")]
        //public IWebElement LnkViewAllQuotes;
        public IWebElement LnkViewAllQuotes { get { return WebDriver.GetElement(By.XPath("//h3[contains(text(), 'Recent Activity')]/following-sibling::a")); } }



public IWebElement LnkViewAllDraftQuotes { get { return WebDriver.GetElement(By.Id("home-page-recent-activity_view_all_draft_quotes")); } }



public IWebElement ViewAllDraftQuotes { get { return WebDriver.GetElement(By.Id("home-page-recent-activity-items-0")); } }

        //[FindsBy(How = How.XPath, Using = "//h3[contains(text(), 'Recent Activity')]/following-sibling::a")]
        //public IWebElement LnkViewAllOrders;
        public IWebElement LnkViewAllOrders { get { return WebDriver.GetElement(By.XPath("//h3[contains(text(), 'Recent Activity')]/following-sibling::a")); } }



public IWebElement LnkViewAllOpportunities { get { return WebDriver.GetElement(By.Id("home-page-recent-activity_view_all_opportunities")); } }


public IWebElement LnkViewAllSolutions { get { return WebDriver.GetElement(By.Id("home-page-recent-activity_view_all_solutions")); } }


public IWebElement LnkViewAllNotification { get { return WebDriver.GetElement(By.XPath("//a[contains(text(), 'View All')]")); } }


public IWebElement BtnViewCustomers { get { return WebDriver.GetElement(By.XPath("//button[text()='View Customers']")); } }


public IWebElement BtnViewAccounts { get { return WebDriver.GetElement(By.XPath("//button[text()='View Accounts']")); } }


public IWebElement LinkAdd { get { return WebDriver.GetElement(By.LinkText("Add")); } }


public IWebElement LinkViewAll { get { return WebDriver.GetElement(By.LinkText("View All")); } }


public IWebElement addfvcustsucmsg { get { return WebDriver.GetElement(By.Id("add_favouriteCustomersNew")); } }


public IWebElement LbldsaTitle { get { return WebDriver.GetElement(By.Id("application_title_text")); } }


public IWebElement LbldsaHomeLogo { get { return WebDriver.GetElement(By.Id("dellBrandLogo_goHomePage")); } }


public IWebElement OrderCancelNotification { get { return WebDriver.GetElement(By.CssSelector(".actv-block:nth-child(1) .dotted + div")); } }


public IWebElement OrderCancelNotificationDate { get { return WebDriver.GetElement(By.CssSelector(".actv-block:nth-child(1) .actv-date")); } }


public IWebElement sessionGUID { get { return WebDriver.GetElement(By.ClassName("bTabSessionId")); } }


public IWebElement LnkCustomerDashboard { get { return WebDriver.GetElement(By.XPath("//*[@id='customer_info_1']/div/span[1]/a")); } }


public IWebElement LnkViewDashboard { get { return WebDriver.GetElement(By.XPath("//*[@alt='Customer Dashboard']")); } }


public IWebElement LnkRefreshPermissions { get { return WebDriver.GetElement(By.CssSelector("#dropMenu > ul:nth-child(5) > li > a")); } }


public IWebElement CancelOrderNoificationSection { get { return WebDriver.GetElement(By.XPath("//*[@id='main']//home-page-user-notification//div")); } }


public IWebElement CancelOrderNoificationFirstNotification { get { return WebDriver.GetElement(By.XPath("//*[@id='main']//home-page-user-notification//div[3]/span")); } }

public IWebElement RecentActivitySpinner { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/div/div[3]/div/div/div/span")); } }

        
        //[FindsBy(How = How.XPath, Using = "//favourite-customer-grid//a[@alt='Mark Favorite']")]

public IWebElement FavoritesList { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'favourite-customer-grid-customer-')]/descendant::i[contains(@class,'icon-small-favorite')]")); } }


public IWebElement DisableFavoriteStar { get { return WebDriver.GetElement(By.XPath("//i[@class='icon-small-favorite-0']")); } }


public IWebElement EnableFavoriteStar { get { return WebDriver.GetElement(By.XPath("//i[@class='icon-small-favorite-100']")); } }




public IWebElement welcomeHeader { get { return WebDriver.GetElement(By.Id("welcomeMessage")); } }


public IWebElement AccountLink { get { return WebDriver.GetElement(By.XPath("//*[@id=' fav_customers_info']/div/div[1]/div[1]/div/a")); } }


public IWebElement ViewAll { get { return WebDriver.GetElement(By.LinkText("View All")); } }


public IWebElement BtnRefresh { get { return WebDriver.GetElement(By.XPath("//*[@id='_favoutiteCustomers']/following-sibling::button")); } }


public IWebElement CustomersUpdatedSuccessfully { get { return WebDriver.GetElement(By.Id("_warning_cannotCreateQuoteBecauseItIsLinkAccount")); } }


public IWebElement BtnRecentActivity { get { return WebDriver.GetElement(By.XPath("//select[contains(.,'Quotes Created')]")); } }


public IWebElement LblSuspendedOrders { get { return WebDriver.GetElement(By.XPath("//*[@id='home - page - op - workflow']/h3")); } }


public IWebElement TableSuspendedOrders { get { return WebDriver.GetElement(By.Id("home_page_workflow")); } }
        


public IWebElement FirstQuoteInRecentActivity { get { return WebDriver.GetElement(By.XPath("//home-page-recent-activity//div[2][contains(@class, 'actv')]/span/a")); } }


public IWebElement TextSuspendedOrders { get { return WebDriver.GetElement(By.XPath("//*[@id='home-page-op-workflow']/div/h3")); } }


public IWebElement TextSuspendedPurchaseOrders { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/home-page/div[1]/home-page-suspended-holds/div/h3")); } }
        
        //replacing the following xpath while defect 6330069 is being worked on
        //[FindsBy(How = How.XPath, Using = "//*[@id='home-page-op-workflow']/div[2]/a/span[1]")]
        public IWebElement LnkSuspendedOrdersShowMoreLess { get { return WebDriver.GetElement(By.XPath("//*[@id='home-page-op-workflow']//span[1]")); } }


        public IWebElement LnkSuspendedOrdersShowMoreLessWithPurchaseOrders { get { return WebDriver.GetElement(By.XPath("//*[@id='home-page-op-workflow']/div/div[5]/a/span[1]")); } }
        


public IWebElement FirstRecentActivity { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/home-page/div/div[2]/home-page-recent-activity/div/div[3]/div[2]/div[2]/a")); } }


public IWebElement NoRecentActivity { get { return WebDriver.GetElement(By.XPath("//*[@id='home-page-recent-activity']//span[contains(text(), 'No Recent Activities')]")); } }

public IWebElement LnkHomeBuid { get { return WebDriver.GetElement(By.XPath("//span[@class='current-business-unit']/a")); } }
public IWebElement SelectCountrytext { get { return WebDriver.GetElement(By.XPath("//h3[@class='popover-title']")); } }
public IWebElement ChangeBUIDPopUp { get { return WebDriver.GetElement(By.Id("_confirm")); } }
public IWebElement PopupHeading { get { return WebDriver.GetElement(By.Id("dialog_heading")); } }
public IWebElement PopUpHeaderText { get { return WebDriver.GetElement(By.XPath("//mat-dialog-content[@class='mat-dialog-content']/span")); } }
        //displayed text 'Changing Business Unit will close any current quotes. Are you sure you wish to continue?'
public IWebElement BtnPopUpYes { get { return WebDriver.GetElement(By.Id("_btn_ok")); } }
public IWebElement BtnPopUpNo { get { return WebDriver.GetElement(By.Id("_btn_cancel")); } }


public IWebElement ShowMore { get { return WebDriver.GetElement(By.XPath("//a[text() = 'Show More']")); } }


public IWebElement ShowLess { get { return WebDriver.GetElement(By.XPath(" //a[text() = 'Show Less']")); } }


public IWebElement CustomersAddedLabel { get { return WebDriver.GetElement(By.XPath("//div[@id = 'add_favouriteCustomersNew_response']")); } }


public IWebElement AddLink { get { return WebDriver.GetElement(By.XPath("//a[text() = 'Show More']")); } }


public IWebElement ViewCustomers { get { return WebDriver.GetElement(By.XPath("//button[text() = 'View Customers']")); } }


public IList<IWebElement> RecentActivityDateLabels { get { return WebDriver.GetElements(By.XPath("//div[@id='home-page-recent-activity']/descendant::div[@class='actv-date']")); } }





        #endregion

        #region OPElements


public IWebElement SearchTypeDropDown { get { return WebDriver.GetElement(By.Id("search_type")); } }


public IWebElement SearchValue { get { return WebDriver.GetElement(By.Id("home_search_value")); } }


public IWebElement SearchDateRangeDropDown { get { return WebDriver.GetElement(By.Id("search_dateRange")); } }


public IWebElement ChkBox_ExactMatch { get { return WebDriver.GetElement(By.Id("search_exact_matches")); } }


public IWebElement BtnSearch { get { return WebDriver.GetElement(By.Id("searchBtn")); } }


public IWebElement BtnEdit { get { return WebDriver.GetElement(By.Id("searchQuoteBtn")); } }


public IWebElement ExpandFirstOPElement { get { return WebDriver.GetElement(By.XPath(".//*[@id='DataTables_Table_dpId']/descendant::td[1]")); } }


public IWebElement LegacyTab { get { return WebDriver.GetElement(By.Id("legacy_tb")); } }


public IWebElement ExpandedViewBillTo { get { return WebDriver.GetElement(By.XPath(".//*[@id='DataTables_Table_dpId']/descendant::duplicate-po-expand-view/descendant::div[@class='col-md-8 second-col']/descendant::address[1]")); } }


public IWebElement ExpandedViewSoldTo { get { return WebDriver.GetElement(By.XPath(".//*[@id='DataTables_Table_dpId']/descendant::duplicate-po-expand-view/descendant::div[@class='col-md-8 second-col']/descendant::address[2]")); } }


public IList<IWebElement> ClickToExpandArrow { get { return WebDriver.GetElements(By.XPath("  .//*[@id='DataTables_Table_dpId']/tbody//td[1]/a")); } }


public IList<IWebElement> ExpandRow { get { return WebDriver.GetElements(By.XPath("  .//*[@id='DataTables_Table_dpId']/tbody//td[1]/a")); } }


public IList<IWebElement> MultipleOrders { get { return WebDriver.GetElements(By.XPath("//div[@class = 'row full-row']//table//tr[contains(@class, 'ng-star-inserted')]")); } }


public IWebElement DisplayPerPage { get { return WebDriver.GetElement(By.Id("dpId_grid_paging_itemsPerPage;")); } }


public IList<IWebElement> TotalPriceChild { get { return WebDriver.GetElements(By.XPath("(//div[@class = 'row full-row']//table//tr[contains(@class, 'ng-star-inserted')]//td)[4]")); } }

        #endregion

        #region OP Methods
        public IList<IWebElement> GetOPResultColumn_By_Index(int index = 2)
        {
            IList<IWebElement> ResultSetColumn = WebDriver.FindElements(By.XPath(".//*[@id='DataTables_Table_dpId']/tbody/descendant::tr/td[" + index.ToString() + "]"));
            return ResultSetColumn;
        }

        public IWebElement GetOPExpandedViewValues_By_HeaderName(IWebDriver driver, string HeaderName)
        {
            IWebElement Element;
            try
            {
                WebDriver.WaitForElementDisplay(By.XPath(".//*[@id='DataTables_Table_dpId']/descendant::div[@class='inner-table-cell']"));
                Element = driver.FindElement(By.XPath(".//*[@id='DataTables_Table_dpId']/descendant::div[@class='inner-table-cell']/span[contains(text(),'" + HeaderName + "')]/parent::div/p"));
            }
            catch (Exception)
            {

                throw;
            }

            return Element;
        }

        public bool VerifyBusyOverlayNotDisplayedOPSearch(IWebDriver driver)
        {
            try
            {
                bool elestatus;
                for (int i = 1; i <= 5; i++)
                {
                    do
                    {
                        var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, DsaUtil.GlobalWaitTime);
                        elestatus = wait.Until<bool>(OpenQA.Selenium.Support.UI.ExpectedConditions.InvisibilityOfElementLocated(By.XPath(".//*[@id='duplicate-po']/div[2]/div/inline-busy/span")));
                        //i++;
                    } while (elestatus == false);

                }
            }
            catch (Exception ex)
            {
                Logger.Write("exception :" + ex.Message);
            }
            return true;
        }

        public bool SearchFiltersForOPprofileDisplayed(IWebDriver driver)
        {
            return (SearchTypeDropDown.IsElementDisplayed(driver, TimeSpan.FromSeconds(2)) && SearchValue.IsElementDisplayed(driver, TimeSpan.FromSeconds(2)));
        }

        public bool IsSearchBtnEnabled(IWebDriver driver)
        {
            return BtnSearch.Enabled;
        }

        public QuoteDetailsPage SearchQuoteFromHomePage(IWebDriver driver, string quoteNum, string version = "1")
        {
            var quoteToSearch = quoteNum;
            if (version != null)
                quoteToSearch = quoteNum + "." + version;
            SearchTypeDropDown.PickDropdownByText(driver, "Quote Number");
            SearchValue.SetText(driver, quoteToSearch);
            BtnSearch.Click(driver);
            return new QuoteDetailsPage(driver).WaitForQuoteValidationToComplete();
        }

        public CreateQuotePage EditQuoteFromHomePage(IWebDriver driver, string quoteNum, string version = "1")
        {
            var quoteToSearch = quoteNum;
            if (version != null)
                quoteToSearch = quoteNum + "." + version;
            SearchTypeDropDown.PickDropdownByText(driver, "Quote Number");
            SearchValue.SetText(driver, quoteToSearch);
            BtnEdit.Click(driver);
            new CreateQuotePage(driver).WaitForQuoteValidationToComplete(); 
            return new CreateQuotePage(driver);
        }


        #endregion

        #region -- Methods --

        public CreateQuotePage CreateQuoteFavCustomers(IWebDriver driver)
        {
            driver.GetElement(By.XPath("//*[@id='quotecreate_favcustomer_0']")).Click(driver);
            if (WebDriver.GetElement(By.XPath("(//*[@id='DataTables_Table_companyNumbers']//a[text()='Select'])[1]"), TimeSpan.FromSeconds(5)) != null)
            {
                //WebDriver.GetElement(By.XPath("//*[@id='customerSetSelect_Grid']//a[text()='Select'][1]")).Click(WebDriver);
                WebDriver.GetElement(By.XPath("(//*[@id='DataTables_Table_companyNumbers']//a[text()='Select'])[1]")).Click(WebDriver);
                return new CreateQuotePage(WebDriver);
            }
            else
            {
                return new CreateQuotePage(WebDriver);
            }
        }


        public By NoRecentActivityMessageLocator
        {
            get
            {
                return By.XPath("//*[@id='home-page-recent-activity']//span[contains(text(), 'No Recent Activities')]");

            }
        }

        public IWebElement NoRecentActivityMessage()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(1));
            return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='home-page-recent-activity']//span[contains(text(), 'No Recent Activities')]")));
        }

        public IWebElement GetFirstItemFromRecentActivityList2(IWebDriver driver)
        {
            return driver.GetElements(By.XPath("//home-page-recent-activity//div[2][contains(@class, 'actv')]/span/a")).First();
        }


        public By GetFirstItemFromRecentActivityListLocator
        {
            get
            {
                return By.ClassName("singleActivity");
            }
        }

        public IWebElement GetFirstItemFromRecentActivityList()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(1));
            return wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("singleActivity")));
        }


        public IWebElement GetfirstUnMarkedfavoriteQuoteFromRecentActivity(IWebDriver driver)
        {
            return driver.GetElements(By.XPath("//home-page-recent-activity//div[contains(@class, 'singleActivity')]//a[@alt='Mark Favorite']")).First();
        }

        public IWebElement GetfirstMarkedfavoriteQuoteFromRecentActivity(IWebDriver driver)
        {
            return driver.GetElements(By.XPath("//home-page-recent-activity//div[contains(@class, 'singleActivity')]//a[@alt='Remove Favorite']")).First();
        }

        public static AccountSearchPage GoToAccountSearchPage(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.SearchAccount();
        }

        /// <summary>
        /// Goes to customer search page.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns></returns>
        public static PersonSearchPage GoToCustomerSearchPage(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            var mainMenu = homePage.ClickMainMenu(driver);
            return mainMenu.SearchPerson();
        }

        public ReadOnlyCollection<IWebElement> BtnViewAll(IWebDriver driver)
        {
            return WebDriver.FindElements(By.XPath("//a[contains(text(), 'View All')]"));

        }

        /// <summary>
        /// Goes to quote search page.
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

        /// <summary>
        /// Goes to the Product search Page
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        //public static ProductSearchPage GotoProductSearchPageAfterCatalogSelect(IWebDriver driver)
        //{
        //    var homePage = new HomePage(driver);
        //    var mainMenu = homePage.ClickMainMenu();
        //    mainMenu.SearchProduct();
        //    //Select Catalog
        //    var prodSearchPage = new ProductSearchPage(driver);
        //    return prodSearchPage.SelectCatalog(Catalogs.Healthcare);
        //}


        /// <summary>
        /// Click on SOAR Tool
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public static HomePage SOARToolLnk(IWebDriver driver)
        {
            var homePage = new HomePage(driver);
            homePage.SOARTool();
            return new HomePage(driver);
        }

        public void SOARTool()
        {
            LnkSOARTool.Click(WebDriver);
        }

        ///// <summary>
        ///// Click on Add to Favourite Customer
        ///// </summary>
        ///// <param name="driver"></param>
        ///// <param name="custNum"></param>
        ///// <returns></returns>
        //public static HomePage AddFavouriteCustomer(IWebDriver driver, string custNum)
        //{
        //    var homePage = new HomePage(driver);
        //    homePage.AddCustomer();
        //    homePage.CustomerNumber = custNum;
        //    homePage.ReplaceCurrentList();
        //    homePage.FinalAddCustomer();
        //    return homePage;
        //}

        /// <summary>
        /// Drop down for all recent activity
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="ShowAllRecentActivity"></param>
        /// <returns></returns>
        public static HomePage ShowAllRecentActivity(IWebDriver driver, string ShowAllRecentActivity)
        {
            var homePage = new HomePage(driver);
            homePage.YourRecentActivity(driver);
            homePage.PickActivity(ShowAllRecentActivity, driver);
            return homePage;
        }

        public void WaitForBusyIndicatorAppearAndDisappear()
        {
            WebDriver.WaitForElementVisible(By.XPath("//*[@id='busy-indicator']"), TimeSpan.FromSeconds(10));
            var wait = new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime);
            wait.Until<bool>(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='busy-indicator']")));
        }
        public void YourRecentActivity(IWebDriver driver)
        {
            DdlYourRecentActivity.Click(driver);

        }
        public void PickActivity(string showAllRecentActivity, IWebDriver driver)
        {
            DdlYourRecentActivity.PickDropdownByText(driver, showAllRecentActivity);
        }


        /// <summary>
        /// Dell logo Verification
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public static HomePage DellLogoVerification(IWebDriver driver)
        {
            var dellLogo = new AdministrationPage(driver);
            dellLogo.ClickDellLogo(driver);
            return new HomePage(driver);
        }

        public static HomePage AddCustinHomePage(IWebDriver driver)
        {
            var homepage = new HomePage(driver);
            return new HomePage(driver);

        }

        public IWebElement checkSuspendedOrderListForOrder(string dpid)
        {
            //replacing the following xpath while defect 6330069 is being worked on
            //var allOrders = WebDriver.GetElements(By.XPath("//*[@id='home_page_workflow']/li"));
            var allOrders = WebDriver.GetElements(By.XPath("//*[contains(@id,'home_page_workflow')]//td[2]/a"));

            foreach (IWebElement element in allOrders)
            {
                if (element.GetText(WebDriver).Contains(dpid))
                {
                    return element; }

            }
            return null;
        }

        public IWebElement checkSuspendedOrderListForOrderWithPurchaseOrders(string dpid)
        {
            //replacing the following xpath while defect 6330069 is being worked on
            //var allOrders = WebDriver.GetElements(By.XPath("//*[@id='home_page_workflow']/li"));
            var allOrders = WebDriver.GetElements(By.XPath("//*[contains(@id,'home_page_workflow')]/div[2]/div[2]/div/a"));

            foreach (IWebElement element in allOrders)
            {
                if (element.GetText(WebDriver).Contains(dpid))
                {
                    return element;
                }

            }
            return null;
        }

        public IWebElement selectSuspendedOrderListForOrder(string dpid)
        {
            return WebDriver.GetElement(By.XPath("//*[contains(@id,'home_page_workflow_item_')]//a[contains(text(),'"+ dpid +"')]"));

        }

        //public IWebElement selectSuspendedOrderListForOrder(string dpid)
        //{
        //    return WebDriver.GetElement(By.XPath("//*[contains(@id,'"+ dpid +"')]//td[2]/a"));
        //  }

        public IWebElement selectSuspendedOrderListForOrderWithSuspendedPurchaseOrders(string dpid)
        {
            return WebDriver.GetElement(By.XPath("//*[contains(@id,'" + dpid + "')]//div[2]/div[2]/div/a"));

        }



        public RecentActivityPage ViewAllRecentActivity(string type)
        {
            switch (type)
            {
                case "quote":
                    DdlYourRecentActivity.PickDropdownByText(WebDriver, "Quotes Created");
                    LnkViewAllQuotes.Click(WebDriver);
                    break;
                case "order":
                    DdlYourRecentActivity.PickDropdownByText(WebDriver, "Orders Created");
                    LnkViewAllOrders.Click(WebDriver);
                    break;
                case "solution":
                    DdlYourRecentActivity.PickDropdownByText(WebDriver, "Solutions Created");
                    LnkViewAllSolutions.Click(WebDriver);
                    break;
                case "opportunities":
                    DdlYourRecentActivity.PickDropdownByText(WebDriver, "Opportunities");
                    LnkViewAllOpportunities.Click(WebDriver);
                    break;
                case "Draft":
                    DdlYourRecentActivity.PickDropdownByText(WebDriver, "Draft Quotes");
                    LnkViewAllDraftQuotes.Click(WebDriver);
                    break;
            }

            return new RecentActivityPage(WebDriver);
        }

        public void WaitForGridToLoad()
        {
            DdlYourRecentActivity.WaitForElementDisplayed(TimeSpan.FromSeconds(30));
        }

        public bool HasRecentActivities()
        {
            return HomeRecentActivity.Displayed &&
            DdlYourRecentActivity.Displayed &&
            LnkViewAllQuotes.Displayed;
        }

        public bool VerifyReturnsRecentActivitiesList()
        {
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            return HomeRecentActivityList.Displayed;
        }

        public List<string> RecentActivitiesFilterOptions()
        {
            return DdlYourRecentActivity.FindElements(By.TagName("option")).Select(select => select.Text).ToList();
        }

        public void SelectRecentActivitiesFilterOption(string option)
        {
            DdlYourRecentActivity.PickDropdownByText(WebDriver, option);
        }

        public List<string> AllRecentActivityTypes()
        {
            if (RecentActivityType == null)
                return new List<string>();
            return RecentActivityType.Select(webElement => webElement.Text).ToList();
        }

        private List<IWebElement> RecentActivityType
        {
            get
            {
                try
                {
                    var parentElements = WebDriver.GetElements(By.ClassName("actv-type"), TimeSpan.FromSeconds(5));
                    return
                        parentElements.Select(parentElement => parentElement.FindElement(By.ClassName("ng-binding")))
                            .ToList();
                }
                catch
                {
                    return null;
                }
            }
        }

        public void WaitForDraftQuotesGridToLoad()
        {
            ViewAllDraftQuotes.WaitForElementDisplayed(TimeSpan.FromSeconds(30));
        }


        public ReadOnlyCollection<IWebElement> SelectFirstOrderCreated()
        {
            return WebDriver.FindElements(By.Id("homepageController_recentActivity_opportunity_1"));
            //return WebDriver.FindElements(By.Id("//*[@id='main']/home-page/div/div[3]/home-page-recent-activity/div/div[3]"));
        }

        public IWebElement SelectFirstRecentActivityOrderFromList()
        {
            return WebDriver.FindElement(By.XPath("//*[contains(@id,'home-page-recent-activity-item-')]/div[2]/span/a[1]"));
        }

        public IWebElement SelectDraftQuoteCreated(string draftQuoteNumber)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='home-page-recent-activity-item-" + draftQuoteNumber + "']/div[2]/span/a"));
        }

        public HomePage ViewAllNotification(IWebDriver driver)
        {
            driver.WaitFor(x => LnkViewAllNotification.Displayed, 120);
            LnkViewAllNotification.Click(driver);
            return new HomePage(driver);
        }

        //public string GetMyUserPreferenceBGColor(string prefOption, IWebDriver driver)
        //{
        //    string actprefColor = "";
        //    string lcprefOption = prefOption.ToLower().Trim();
        //    driver.WaitFor(x => BtnViewAccounts.Displayed, 90);
        //    if (lcprefOption.Equals("accounts"))
        //    {
        //        actprefColor = DsaUtil.ConvertRgbToHex(BtnViewAccounts.GetCssValue("background-color"));
        //    }
        //    else if (lcprefOption.Equals("customers"))
        //    {
        //        actprefColor = DsaUtil.ConvertRgbToHex(BtnViewCustomers.GetCssValue("background-color"));

        //    }

        //    return (actprefColor);
        //}


        public HomePage AddCustomerAddLink(string cusno, IWebDriver driver, bool replaceCustomers = false)
        {

            WebDriver.WaitFor(x => LinkAdd.Displayed, 60);
            driver.JavaScriptClick(LinkAdd);
            Logger.Write("Add link clicked");
            CustomerNumbers.SetText(driver, cusno);
            //The line below will replace existing favorite customers, we do not want this to happen in prod
            //need to see if we can run test machines under unique SR ID's to avoid remove customers for SR 12345 or 999
            if (replaceCustomers)
            {
                ChkboxReplaceCustomers.Click(driver);
            }
            BtnFinalAddCustomer.Click(driver);
            Logger.Write("Add customers button clicked");
            try
            {
                WebDriver.WaitFor(x => addfvcustsucmsg.Displayed, 60);
            }
            catch (NoSuchElementException)
            {


            }
            Logger.Write("results message found");
            WebDriver.WaitForPageLoad();
            return new HomePage(WebDriver);

        }



        public HomePage AddCustomerAddLink_Account(string cusno, IWebDriver driver)
        {

            //            System.Threading.Thread.Sleep(2000);
            LinkAdd.Click(driver);
            CustomerNumbers.SendKeys(cusno);
            BtnFinalAddCustomer.Click(driver);
            driver.WaitForBusyOverlay();
            return new HomePage(driver);
        }
        public HomePage CustomerMarkFav(IWebDriver driver)
        {
            Logger.Write("Starting marking favorite test");
            //get the count of the customers before marking any customer as favorite
            driver.WaitFor(x => FavoritesList.Displayed, 90);
            //IList<IWebElement> favelements = FavoritesList;

            ReadOnlyCollection<IWebElement> favelements = WebDriver.FindElements(By.XPath("//*[contains(@id,'favourite-customer-grid-customer-')]/descendant::i[contains(@class,'icon-small-favorite')]"));
            //ReadOnlyCollection<IWebElement> favelements = WebDriver.FindElements(By.XPath("//favourite-customer-grid//a[@alt='Mark Favorite']"));
            favelements[favelements.Count - 1].Click(driver);
            Logger.Write("Marked 1 as favorite");

            ReadOnlyCollection<IWebElement> removefavelements1 = WebDriver.FindElements(By.XPath("//favourite-customer-grid//a[@alt='Remove Favorite']"));
            int countrem = removefavelements1.Count();
            removefavelements1.Count.Should().Be(countrem);
            return new HomePage(driver);

        }


        public HomePage AddCustomerViewAllLink(string cusno, IWebDriver driver)
        {


            //            System.Threading.Thread.Sleep(2000);
            LinkViewAll.Click();
            BtnFinalAddCustomer.Click();
            CustomerNumbers.SendKeys(cusno);

            driver.WaitForBusyOverlay();
            var sucessmsg = addfvcustsucmsg.Text.Contains("21 customers were added");
            WebDriverUtil.ScrollToElement(WebDriver, By.LinkText("Show more"));
            WebDriver.FindElement(By.LinkText("Show more")).Click();
            return new HomePage(WebDriver);
        }

        public IWebElement getAccountNameFromList(string CompanyName)
        {
            var companyAccList = WebDriver.GetElements(By.XPath("//*[@id=' fav_customers_info']/div/div[1]/div[1]/div/a"));
            foreach (IWebElement entry in companyAccList)
            {
                if (entry.Text.Contains(CompanyName))
                    return entry;
            }
            return null;

        }

        public IWebElement getFavouriteCustomerLinkFromList(string customer)
        {
            var favouriteCustomerList = WebDriver.GetElements(By.XPath("//div[contains(@id,'favourite-customer-grid-customer')]/div/div/a"));
            foreach(IWebElement entry in favouriteCustomerList)
            {
                if (entry.Text.Contains(customer))
                    return entry;
            }
            return null;
        }
        public IWebElement CustomerLink(IWebDriver driver, int index)
        {
            var FavouriteCustomerXpath = $"//favourite-customer-grid/div/div[1]/div[{index}]//a";
            var favouriteCustomer = WebDriver.FindElements(By.XPath(FavouriteCustomerXpath))[1]; // [1] is to get the customer name link
            WebDriver.WaitForBusyOverlay();
            return favouriteCustomer;
        }


        public CreateQuotePage QuoteLink(string custno, IWebDriver driver)
        {
            SetFavSearchFieldTo.SetText(driver, custno);
            //WebDriver.WaitForBusyOverlay();
            //WebDriver.WaitForElement(By.XPath("//*[@id='customer_info']/div/a[2]"), TimeSpan.FromSeconds(120));

            ReadOnlyCollection<IWebElement> atag = WebDriver.FindElement(By.Id("customer_info_1")).FindElements(By.TagName("a"));
            //WebDriver.FindElement(By.XPath("*[@id='customer_info']/div/a[2]")).Click();
            atag[2].Click();
            WebDriver.WaitForBusyOverlay();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120);
            return new CreateQuotePage(WebDriver);
        }
        public bool VerifyHomePageDisplayed()
        {

            return MsgWelcome.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2));
        }
        #endregion

        public IWebElement TotalPrice(int index)
        {
            return WebDriver.FindElement(By.XPath($"(//div[@id = 'DataTables_div_dpId']//td[9])[{index}]"));
        }

        public IWebElement GetRecentActivityItemsFromColumn(IWebDriver driver)
        {
            var recentActivityElements = driver.GetElements(By.ClassName("home-sections"), TimeSpan.FromSeconds(15));
            IWebElement activity = null;
            try
            {
                activity = recentActivityElements[0].GetChildElement(By.ClassName("actv-block"), TimeSpan.FromSeconds(15));
            }
            catch (Exception ex)
            {
                if (NoRecentActivity.Displayed)
                {
                    Logger.Write("No Recent Activities found. This could be due to data (no items created), or could be issue communicating with GOSS. Needs Investigation");
                }
                throw ex;
            }
            return activity;
        }

        public IEnumerable<IWebElement> GetListOfRecentActivities(IWebDriver driver)
        {
            var activityColumn = GetRecentActivityItemsFromColumn(driver);
            return activityColumn.GetElements(driver, By.ClassName("singleActivity"));
        }

        public int GetListOfMenuOptions(IWebDriver driver)
        {
            //Count from Search
            IList<IWebElement> allLinksInSearch = driver.FindElements(By.XPath("//*[@id='dropMenu']/div[2]/ul/li"));
            int allLinksInSearchCount = allLinksInSearch.Count();
            Logger.Write("Count of options from Search : " + allLinksInSearch);
            Logger.Write("Count of options from Search : "+ allLinksInSearchCount);

            IList<IWebElement> allLinksInAdd = driver.FindElements(By.XPath("//*[@id='dropMenu']/div[1]/ul/li"));
            int allLinksInAddCount = allLinksInAdd.Count();
            Logger.Write("Count of options from Add : " + allLinksInAddCount);

            //Count from Import
            IList<IWebElement> allLinksInImport = driver.FindElements(By.XPath("//*[@id='dropMenu']/div[1]/ul[2]/li"));
            int allLinksInImportCount = allLinksInImport.Count();
            Logger.Write("Count of options from Import : " + allLinksInImportCount);

            //Count from Divider
            IList<IWebElement> allLinksInDivider = driver.FindElements(By.XPath("//*[@id='dropMenu']/ul[1]/li"));
            int allLinksInDividerCount = allLinksInDivider.Count();
            Logger.Write("Count of options from Divider : " + allLinksInDividerCount);

            int TotalCount = (allLinksInSearchCount + allLinksInAddCount + allLinksInImportCount + allLinksInDividerCount);

            return TotalCount;
        }

        public HomePage RefreshPermissions(IWebDriver driver)
        {
            DsaUtil.Click(LnkRefreshPermissions, driver);
            driver.WaitForPageLoad();
            return new HomePage(WebDriver);
        }

        public HomePage SearchCustomer(IWebDriver driver, string custno)
        {
            SetFavSearchFieldTo.SendKeys(custno);
            WebDriver.FindElement(By.Id("customer_info")).FindElement(By.TagName("a"));

            return new HomePage(WebDriver);
        }

        public AccountDetailsPage ViewAccounts(IWebDriver driver)
        {
            driver.WaitForElementDisplayed(By.XPath("//*[@id='yourCustomersSection']/div[2]/div/div/div[3]/button[2]"), TimeSpan.FromSeconds(90));
            driver.FindElement(By.XPath("//*[@id='yourCustomersSection']/div[2]/div/div/div[3]/button[2]")).Click(driver);
            //driver.FindElement(By.LinkText("GRE ETS Org")).Click();
            driver.WaitForBusyOverlay();
            return new AccountDetailsPage(WebDriver);

        }

        public string CustomerList()
        {
            string c = WebDriver.FindElement(By.XPath("//table[@id='DataTables_Table_2']/tbody/tr/td/a")).Text;
            WebDriver.FindElement(By.XPath("//table[@id='DataTables_Table_2']/tbody/tr/td/a")).Click();

            return c;
        }

        public HomePage AddCustomerAddLink_Customer360(string custno, IWebDriver driver)
        {
            AddCustomerAddLink_dashboard(custno, driver);
            return new HomePage(WebDriver);

        }

        public CustomerDashboardPage CustomerDashboardLink(string custno, IWebDriver driver)
        {
            DsaUtil.WaitForElement(SetFavSearchFieldTo, driver);
            SetFavSearchFieldTo.SendKeys(custno);
            DsaUtil.Click(LnkCustomerDashboard, driver);
            WebDriver.WaitForBusyOverlay();
            return new CustomerDashboardPage(WebDriver);
        }

        public CustomerDashboardPage ClickViewDashboardLink(IWebDriver driver)
        {
            WebDriverUtil.WaitForElementDisplay(driver, By.XPath("//*[@alt='Customer Dashboard']"), TimeSpan.FromMinutes(2));
            DsaUtil.Click(LnkViewDashboard, driver);
            return new CustomerDashboardPage(WebDriver);
        }

        public HomePage AddCustomerAddLink_ViewAccountsClick(string custno, IWebDriver driver)
        {
            AddCustomerAddLink_dashboard(custno, driver);
            DsaUtil.WaitForElement(BtnViewAccounts, WebDriver);
            DsaUtil.Click(BtnViewAccounts, driver);
            return new HomePage(WebDriver);
        }

        public void AddCustomerAddLink_dashboard(string custno, IWebDriver driver)
        {

            WebDriverUtil.WaitForElementDisplay(driver, By.LinkText("Add"));
            DsaUtil.Click(LinkAdd, driver, TimeSpan.FromSeconds(20));  //driver.FindElement(By.LinkText("Add")).Click();
            CustomerNumbers.SendKeys(custno);
            //DsaUtil.Click(ChkboxReplaceCustomers, driver);
            DsaUtil.Click(BtnFinalAddCustomer, driver);
            WebDriverUtil.WaitForElementDisplay(driver, By.XPath("//*[@id='add_favouriteCustomersNew']/div/p[1]"));
            driver.FindElement(By.XPath("//*[@id='add_favouriteCustomersNew']/div/p[1]")).Text.Contains("1 customers were added");
        }


        /// <summary>
        /// Verify if customers were added if not added customer to dash board
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="customerNumber"></param>
        public void AddCustomersToDashBoard(IWebDriver driver, string customerNumber)
        {

            if(WebDriver.WaitForElementDisplay(ShowMore, TimeSpan.FromSeconds(2)) == false)
            {
                ViewCustomers.Click();
                WebDriver.VerifyBusyOverlayNotDisplayed();
                ShowMore.Click();
            }

            WebDriverUtil.WaitForElementDisplay(driver, By.LinkText("Add"));
            DsaUtil.Click(LinkAdd, driver, TimeSpan.FromSeconds(20));  //driver.FindElement(By.LinkText("Add")).Click();
            CustomerNumbers.SendKeys(customerNumber);
            DsaUtil.Click(BtnFinalAddCustomer, driver);

            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.WaitForElementDisplay(CustomersAddedLabel, TimeSpan.FromSeconds(5));
            string text = CustomersAddedLabel.Text;

            if (CustomersAddedLabel.Text.Contains("0 customers were added.") == true)
            {
                if (WebDriver.WaitForElementDisplay(ShowMore, TimeSpan.FromSeconds(2)) == false)
                {
                    ViewCustomers.Click();
                    WebDriver.VerifyBusyOverlayNotDisplayed();
                }

                if(WebDriver.WaitForElementDisplay(ShowLess, TimeSpan.FromSeconds(2)) == false)
                {
                    ShowMore.Click();
                    WebDriver.VerifyBusyOverlayNotDisplayed();
                }
            }
            else
            {
                if (WebDriver.WaitForElementDisplay(ShowMore) == false)
                {
                    ViewCustomers.Click();
                    WebDriver.VerifyBusyOverlayNotDisplayed();
                }
            }

            IWebElement path = WebDriver.FindElement(By.XPath($"//dashboard[contains(@ng-reflect-customer-number, '{customerNumber}')]"));

            WebDriverUtil.JavaScriptClick(WebDriver, WebDriver.FindElement(By.XPath($"//dashboard[contains(@ng-reflect-customer-number, '{customerNumber}')]")));
            path.Click();
        }

        public string VerifyCustomersUpdatedSuccessfully(IWebDriver driver)
        {
            By byBtnRefresh = By.XPath("//*[@id='_favoutiteCustomers']/following-sibling::button");
            By byCustomersUpdated = By.Id("_warning_cannotCreateQuoteBecauseItIsLinkAccount");
            WebDriver.VerifyBusyOverlayNotDisplayed();
            //WebDriverUtil.WaitForElementDisplay(driver, byBtnRefresh, TimeSpan.FromSeconds(15));
            driver.FindElement(byBtnRefresh).Click();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            //WebDriverUtil.WaitForElementDisplay(driver, byCustomersUpdated, TimeSpan.FromSeconds(60));
            string msg = driver.FindElement(byCustomersUpdated).Text;
            Logger.Write(byCustomersUpdated, msg);
            return msg;
        }

        public string GetCurrentFavouriteSelection(IWebDriver driver)
        {
            driver.WaitFor(x => x.FindElementBy(By.XPath("//div[contains(text(),'Search Your ')]"), TimeSpan.FromSeconds(120)));
            var title = driver.FindElement(By.XPath("//div[contains(text(),'Search Your ')]"));
            string text = title.Text.TrimEnd();
            int start = text.LastIndexOf(" ") + 1;
            return text.Substring(start, text.Length - start);
        }


        public bool EnsightenSrcExists(IWebDriver driver)
        {
            return driver.ElementExists(By.XPath("//script[contains(@src, '/nexus.ensighten.com/dell/internalDev/Bootstrap.js')]"));
        }

        public void SelectBUIDCountry(string country)
        {
            WebDriver.WaitFor(x => x.FindElementBy(By.XPath("//div[@class='popover-content']"), TimeSpan.FromSeconds(60)));
            WebDriver.FindElement(By.XPath("//a[contains(text(), '" + country + "')]")).Click(WebDriver);
        }

        public void WaitForChangeBUIDPopup()
        {
            WebDriver.WaitFor(x => x.FindElementBy(By.Id("_confirm"), TimeSpan.FromSeconds(60)));            
        }

        public void WaitForNewBuidToLoad()
        {
            WebDriver.WaitForPageLoad();
            WebDriver.WaitFor(x => x.FindElementBy(By.XPath("//select[@id='search_type']"), TimeSpan.FromSeconds(60)));
        }

        public void VerifyAndSelectBuidRegion(string currentBuid, string selectBuid)
        {
            if (currentBuid.Contains(selectBuid))
            {
                Logger.Write("Current Business Unit is " + currentBuid);
            }
            else
            {
                new HomePage(WebDriver).LnkHomeBuid.Click(WebDriver);
                new HomePage(WebDriver).SelectBUIDCountry(selectBuid);
                new HomePage(WebDriver).WaitForChangeBUIDPopup();
                Assert.IsTrue(new HomePage(WebDriver).PopupHeading.GetText(WebDriver).Contains("Change Business Unit - Confirm"));
                Assert.IsTrue(new HomePage(WebDriver).PopUpHeaderText.GetText(WebDriver).Contains("Changing Business Unit will close any current quotes. Are you sure you wish to continue?"));
                new HomePage(WebDriver).BtnPopUpYes.Click(WebDriver);
                new HomePage(WebDriver).WaitForNewBuidToLoad();
                Logger.Write(new HomePage(WebDriver).LnkHomeBuid.GetText(WebDriver));
                Logger.Write(selectBuid);
                Assert.IsTrue(new HomePage(WebDriver).LnkHomeBuid.GetText(WebDriver).Contains(selectBuid));
            }
        }

        public bool CheckFavoriteQuoteInHomePageRecentActivity(IWebDriver driver,string selectedmarkedQuote)
        {
            var homePage = new HomePage(driver);
            var favoriteQuotes = homePage.GetListOfRecentActivities(driver);
            bool isfound = false;
            if (favoriteQuotes.Count() > 0)
            {
                for (int i = 0; i < favoriteQuotes.Count(); i++)
                {
                    var quote = favoriteQuotes.ElementAt(i).GetChildElement(By.XPath(".//div[2]/span"));
                    var favoriteQuote = quote.GetText(driver);
                    //favoriteQuote = (favoriteQuote.ToString().Split(' ')[0]).Split('#')[1];
                    //if (favoriteQuote == selectedmarkedQuote)
                    //{
                    //    isfound = true;
                    //    break;
                    //}
                    if(favoriteQuote.Contains(selectedmarkedQuote))
                    {
                        isfound = true;
                    }
                }
            }
            return isfound;
        }

        public void VerifyRecentActivitySectionForOption(string dropdownOption, bool expectResults = false)
        {
            var dates = new List<DateTime>();
            WebDriver.WaitFor(x => BtnRecentActivity.Displayed, 15);
            BtnRecentActivity.Select().SelectByText(dropdownOption);
            WebDriver.WaitForPageLoad();
            bool loaded = WebDriver.WaitForEitherElement(GetFirstItemFromRecentActivityListLocator, NoRecentActivityMessageLocator, 90);
            if(loaded)
            {
                GetFirstItemFromRecentActivityList().Displayed.Should().BeTrue();
                var dateLabels = RecentActivityDateLabels;
                foreach (var dateLabel in dateLabels)
                {
                    VerifyDateFormat(dateLabel.Text);
                    dates.Add(Convert.ToDateTime(dateLabel.Text));
                }
                for (int i = 0; i < dates.Count - 1; i++)
                {
                    if (DateTime.Compare(dates[i], dates[i + 1]) <= 0)
                    {
                        Assert.Fail(dropdownOption + ": " + dates[i] + " should be displayed below " + dates[i + 1]);
                    }
                }
                Logger.Write("**Output: " + GetFirstItemFromRecentActivityList().Text);
            }
            else
            {
                NoRecentActivityMessage().Displayed.Should().BeTrue();
                Logger.Write("**Output: " + NoRecentActivity.Text);
                if (expectResults)
                    Assert.Fail("No results were returned for " + dropdownOption);
            }
        }

        public void WaitForRecentActivityToLoad()
        {
            int retryCounter = 0;
            int retryTimeout = 45; // 90 seconds - remember that this timeout will double, as we are waiting 1 second for each of the two elements
            bool activitiesLoaded = false;
            while(!activitiesLoaded && retryCounter < retryTimeout)
            {
                try
                {
                    activitiesLoaded = GetFirstItemFromRecentActivityList().Displayed;
                }
                catch (Exception e)
                {
                    try
                    {
                        activitiesLoaded = NoRecentActivityMessage().Displayed;
                    }
                    catch
                    {
                        retryCounter++;
                        if (retryCounter >= retryTimeout)
                        {
                            throw new WebDriverTimeoutException("No results returned and no message returned after " + retryTimeout * 2 + " seconds");
                        }
                    }
                }
            }
        } 

        public void VerifyDateFormat(string date)
        {
            try
            {
                DateTime.ParseExact(date, "MMMM d, yyyy", null);
            }
            catch (FormatException e)
            {
                Assert.Fail("Invalid date updated format!");
            }
        }

        public void ExpandRowByIndex(int index)
        {
            WebDriver.FindElement(By.XPath($".//*[@id='DataTables_Table_dpId']/tbody//td[{index}]/a"));
        }

        public PCFQuoteSummaryPage SearchQuoteFromPcfHomePage(IWebDriver driver, string quoteNum, string version = "1")
        {
            var quoteToSearch = quoteNum;
            if (version != null)
                quoteToSearch = quoteNum + "." + version;
            SearchTypeDropDown.PickDropdownByText(driver, "Quote Number");
            SearchValue.SetText(driver, quoteToSearch);
            BtnSearch.Click(driver);
            return new PCFQuoteSummaryPage(driver).WaitForQuoteValidationToComplete();
        }
        #region Suspended Purchase Order - Elements & methods

        public IWebElement SusPOHeading { get { return WebDriver.GetElement(By.XPath("//home-page-suspended-holds//div[contains(@class,'suspended-holds-comp')]/h3")); } }
public IWebElement PoShowMore { get { return WebDriver.GetElement(By.XPath("//home-page-suspended-holds//i/following::span[@class='text-primary'][1]")); } }
public IWebElement PoShowLess { get { return WebDriver.GetElement(By.XPath("//home-page-suspended-holds//i/following::span[@class='text-primary'][2]")); } }
public IWebElement ClickShowMore { get { return WebDriver.GetElement(By.XPath("//home-page-suspended-holds//i")); } }

        public int GetNumOfSuspendedPurchaseOrders()
        {
            return WebDriver.FindElements(By.XPath("//home-page-suspended-holds//div[contains(@class,'suspended-holds-comp')]/div")).Count();
        }

        public void GetDatesFromSusPOOrdersSection(List<string> suspendDate)
        {            
            WebDriver.WaitForPageLoad();            
            int i = GetNumOfSuspendedPurchaseOrders();
            
            for (int j = 1; j <= i; j ++)
            {
                By susDates = By.XPath("//home-page-suspended-holds//div[" + j + "]/div[contains(@class,'reminders_container')]/div[1]/div[2]/div");
                By susDates1 = By.XPath("//home-page-suspended-holds//div[" + j + "]/div[contains(@class,'reminders_container')]/div/div[3]/p");

                if (WebDriver.ElementExists(susDates))
                {
                    suspendDate.Add(WebDriver.FindElement(susDates).GetText(WebDriver));
                    string[] s = suspendDate[j - 1].Split(',');
                    string s1 = s[0] + " " + s[1];
                    string s2 = DateTime.Parse(s1, new CultureInfo("en-US", true)).ToString("M/d/yyyy");

                    suspendDate[j - 1] = s2 + s[2];
                    Logger.Write(suspendDate[j - 1]);
                }
                else if(WebDriver.ElementExists(susDates1))
                {
                    suspendDate.Add(WebDriver.FindElement(susDates1).GetText(WebDriver));
                    string[] s = suspendDate[j - 1].Split(',');
                    string s1 = s[0] + " " + s[1];
                    string s2 = DateTime.Parse(s1, new CultureInfo("en-US", true)).ToString("M/d/yyyy");

                    suspendDate[j - 1] = s2 + s[2];
                    Logger.Write(suspendDate[j - 1]);
                }
            }
        }

        public void VerifyReminderLabels(List<string> suspendDate, string todaysDate)
        {
            string[] dates;
            List<string> dateValues = new List<string>();
            for (int i = 0; i < suspendDate.Count(); i++)
            {
                dates = suspendDate[i].Split(' ');
                dateValues.Add(dates[0]);
            }

            for (int j = 0; j < suspendDate.Count(); j++)
            {
                DateTime s1 = Convert.ToDateTime(dateValues[j]).AddDays(5);
                if (s1 < Convert.ToDateTime(todaysDate))
                {
                    Assert.IsTrue(WebDriver.FindElement(By.XPath("//home-page-suspended-holds//div[" + (j + 1) + "]/div[contains(@class,'reminders_container')]/div/div[1]//*[contains(@class,'label-red')]")).GetText(WebDriver).Contains("final reminder"));
                }
                else
                {
                    int diff = (s1 - Convert.ToDateTime(todaysDate)).Days;
                    string diff1 = diff + " days remaining";
                    Assert.IsTrue(WebDriver.FindElement(By.XPath("//home-page-suspended-holds//div[" + (j + 1) + "]/div[contains(@class,'reminders_container')]/div/div[1]//*[contains(@class,'label-default')]")).GetText(WebDriver).Contains(diff1));
                }
            }
        }

        public void ClickOnPOMIdLink(string pomId)
        {           
            WebDriver.FindElement(By.XPath("//home-page-suspended-holds//a[contains(text(),'" + pomId + "')]")).Click(WebDriver);            
        }

        public string GetPOMidLabel(int value)
        {
            By pomIdLabel = By.XPath("//home-page-suspended-holds//div[" + (value + 1) + "]/div[contains(@class,'reminders_container')]/div/div[4]");
            By pomIdLabel1 = By.XPath("//home-page-suspended-holds//div[" + (value + 1) + "]/div[contains(@class,'reminders_container')]/div[2]/div[2]");
            string s = string.Empty;

            if (WebDriver.ElementExists(pomIdLabel))
            {
               s = WebDriver.FindElement(pomIdLabel).GetText(WebDriver);
            }
            else if (WebDriver.ElementExists(pomIdLabel1))
            {
               s= WebDriver.FindElement(pomIdLabel1).GetText(WebDriver);
            }

            return s;
        }

        public string GetHoldReasonDesc(int value)
        {
            By holdReason = By.XPath("//home-page-suspended-holds//div[" + (value + 1) + "]/div[contains(@class,'reminders_container')]/div/div[1]/div");
            By holdReason1 = By.XPath("//home-page-suspended-holds//div[" + (value + 1) + "]/div[contains(@class,'reminders_container')]/div/div[1]/p[1]");
            string hold = string.Empty;

            if (WebDriver.ElementExists(holdReason))
            {
                hold =  WebDriver.FindElement(holdReason).GetAttribute("title");
            }
            else if (WebDriver.ElementExists(holdReason1))
            {
                hold = WebDriver.FindElement(holdReason1).GetAttribute("title");
            }

            return hold;
        }

        public string GetTotalAmountValues(int j)
        {
            By poAmt = By.XPath("//home-page-suspended-holds//div[" + (j + 1) + "]/div[contains(@class,'reminders_container')]/div[3]//div[contains(@class,'reminders_date')]");
            By poAmt1 = By.XPath("//home-page-suspended-holds//div[" + (j + 1) + "]/div[contains(@class,'reminders_container')]/div/div[5]/p");
            string amount = string.Empty;

            if (WebDriver.ElementExists(poAmt))
            {
                amount = WebDriver.FindElement(poAmt).GetText(WebDriver);
            }
            else if (WebDriver.ElementExists(poAmt1))
            {
                amount = WebDriver.FindElement(poAmt1).GetText(WebDriver);
            }

            return amount;
        }

        public string GetAndClickOnCustomerNumberLink(int value)
        {
            By custSec = By.XPath("//home-page-suspended-holds//div[" + (value + 1) + "]/div[contains(@class,'reminders_container')]/div[2]//div[contains(@class,'text-left')]");
            By custSection = By.XPath("//home-page-suspended-holds//div[" + (value + 1) + "]/div[contains(@class,'reminders_container')]/div/div[2]//p");
            string s = string.Empty;          

            if(WebDriver.ElementExists(custSection))
            {
                s = WebDriver.FindElement(custSection).GetText(WebDriver);
                WebDriver.FindElement(By.XPath("//home-page-suspended-holds//div[" + (value + 1) + "]/div[contains(@class,'reminders_container')]/div/div[2]//a")).Click(WebDriver);
            }
            else if (WebDriver.ElementExists(custSec))
            {
                s = WebDriver.FindElement(custSec).GetText(WebDriver);
                WebDriver.FindElement(By.XPath("//home-page-suspended-holds//div[" + (value + 1) + "]/div[contains(@class,'reminders_container')]/div[2]//div[contains(@class,'text-left')]//a")).Click(WebDriver);
            }
            else
            {
                Logger.Write("No Customer number displayed for the POM id");
            }
            return s;
        }

        public string GetPomIdToolTipForHoldComments(int j)
        {            
            WebDriver.WaitForPageLoad();
            IWebElement pomId = WebDriver.FindElement(By.XPath("//home-page-suspended-holds//div[" + (j + 1) + "]/div[contains(@class,'reminders_container')]/div/div[4]//a"));
            Actions builder = new Actions(WebDriver);         
            WebDriver.WaitForPageLoad();
            builder.ClickAndHold().MoveToElement(pomId);
            builder.MoveToElement(pomId).Build().Perform();            
            WebDriver.WaitForBusyOverlay();            
            string toolTipElement = WebDriver.FindElement(By.XPath("//home-page-suspended-holds//div[" + (j + 1) + "]/div[contains(@class,'reminders_container')]/div/div[4]//a//following::div[@class='popover-content']")).GetText(WebDriver);
            return toolTipElement;
        }

        public void WaitUntilInlineBusyBlockDisappear(IWebDriver driver, TimeSpan? waitTime = null)
        {
            By inlineBusy = By.XPath("//span[@class='inline-busy-block']");

            if (waitTime == null)
                waitTime = TimeSpan.FromSeconds(90); 

            WebDriverWait wait = new WebDriverWait(driver, waitTime.Value);
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(inlineBusy));
        }
        #endregion

        #region POM Workflow - Next in Queue - Elements & methods
public IWebElement POMWorkFlowNextInQueueHeader { get { return WebDriver.GetElement(By.XPath(".//h3[contains(text(),'POM Workflow - Next in Queue')]")); } }
public IWebElement Nextinqueue { get { return WebDriver.GetElement(By.XPath(".//*[@class='col-md-12']//div[1]//label[1]/b")); } }
public IWebElement POMIDText_NextInQueue { get { return WebDriver.GetElement(By.XPath(".//*[@class='col-md-12']//div[1]//label[2]/b")); } }
public IWebElement POMIDValue_NextInQueue { get { return WebDriver.GetElement(By.XPath(".//*[@class='col-md-12']//div[1]//label[2]")); } }
public IWebElement PONumber_NextInQueue { get { return WebDriver.GetElement(By.XPath(".//*[@class='col-md-12']//div[1]//label[3]")); } }
public IWebElement DateReceived_NextInQueue { get { return WebDriver.GetElement(By.XPath(".//*[@class='col-md-12']//div[1]//label[4]")); } }
public IWebElement DateReceivedValue_NextInQueue { get { return WebDriver.GetElement(By.XPath(".//*[@class='col-md-12']//div[1]//label[5]/date/div")); } }
public IWebElement Workgroup_NextInQueue { get { return WebDriver.GetElement(By.XPath(".//*[@class='col-md-12']//div[1]//label[6]")); } }
public IWebElement WorkThisItem_NextInQueue { get { return WebDriver.GetElement(By.XPath(".//*[@class='col-md-12']//div[1]//button")); } }
public IWebElement GoToMyQueueLink_NextInQueue { get { return WebDriver.GetElement(By.XPath(".//a[contains(text(),'Go to My Queue')]")); } }
        #endregion
    }
}
