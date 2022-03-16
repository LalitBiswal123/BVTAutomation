using System.Collections.Generic;
using Dsa.Utils;
using OpenQA.Selenium;
using Dell.Adept.UI.Web.Pages;
using Dsa.Enums;
using Dsa.Pages.Account;
using Dsa.Pages.Admin;
using OpenQA.Selenium.Support.PageObjects;
using Dsa.Pages.Customer;
using Dsa.Pages.Quote;
using Dsa.Pages.APOS;
using Dsa.Pages.Order;
using Dsa.Pages.POM;
using Dsa.Pages.ManagePartnerFavorites;

namespace Dsa.Pages
{
    /// <summary>
    /// This is a pagepart class used to define elements and actions on .
    /// </summary>
    public class MainMenu : PagePartBase
    {
        private ImportCartPopUp importCart;
        private readonly IWebDriver WebDriver;
        
        /// <summary>
        /// The parent element of the page part. E.g. the div element that contains all of the child elements in the part.
        /// </summary>
        /// <value>The parent element.</value>
        public IWebElement parentElement { get; set; }

        /// <summary>
        /// The parent page. This is typically passed into the constructor of the concrete pagepart.
        /// </summary>
        public IPage parentPage;

        
        public MainMenu(IPage parentPage, IWebElement parentElement)
            : base(parentPage, ref parentElement)
        {
            this.parentPage = parentPage;
            this.parentElement = parentElement;
            this.WebDriver = parentPage.WebDriver;
            PageFactory.InitElements(WebDriver, this);
        }

        #region Elements


public IWebElement LnkSearchAccount { get { return WebDriver.GetElement(By.Id("menu_accountSearch")); } }


public IWebElement LnkSearchOrg { get { return WebDriver.GetElement(By.Id("menu_orgSearch")); } }


public IWebElement LnkImportLegacyCart { get { return WebDriver.GetElement(By.Id("menu_importLegacyCart_link")); } }


public IWebElement LnkSearchQuote { get { return WebDriver.GetElement(By.Id("menu_quoteSearch")); } }

        //[FindsBy(How = How.Id, Using = "menu_orderSearch")]
        //public IWebElement LnkSearchOrder;

        public IWebElement LnkSearchOrder { get { return WebDriver.GetElement(By.Id("menu_orderSearch")); } }



public IWebElement LnkSearchPomid { get { return WebDriver.GetElement(By.XPath("//*[@id='menu_pomSearch']")); } }

public IWebElement LnkManagePartnerFavorites { get { return WebDriver.GetElement(By.Id("menu_manage_partner_favorites")); } }

public IWebElement LnkGama { get { return WebDriver.GetElement(By.Id("menu_accessGama")); } }


public IWebElement LnkMaintainedAsDataViewer { get { return WebDriver.GetElement(By.Id("menu_maintained_data_view")); } }


public IWebElement LnkSearchProduct { get { return WebDriver.GetElement(By.Id("menu_productSearch")); } }


public IWebElement LnkSearchSolution { get { return WebDriver.GetElement(By.Id("menu_solutionSearch")); } }
        

public IWebElement LnkPreview { get { return WebDriver.GetElement(By.Id("menu_previewOrder_link")); } }


public IWebElement LnkRFPAndProposalExpressPortal { get { return WebDriver.GetElement(By.Id("menu_accessRfpPropsal")); } }


public IWebElement LnkAddCustomer { get { return WebDriver.GetElement(By.Id("menu_customerAdd_link")); } }

        //[FindsBy(How = How.Id, Using = "menu_quoteAdd_link")]
        //public IWebElement LnkAddQuote;

        public IWebElement LnkAddQuote { get { return WebDriver.GetElement(By.Id("menu_quoteAdd_link")); } }


public IWebElement LnkAddSolution { get { return WebDriver.GetElement(By.Id("menu_solutionAdd_link")); } }


public IWebElement LnkCustomerCommunication { get { return WebDriver.GetElement(By.Id("menu_customerOutput")); } }


public IWebElement LnkReporting { get { return WebDriver.GetElement(By.Id("menu_reports")); } }


public IWebElement LnkSalesEdge { get { return WebDriver.GetElement(By.XPath("//*[@id='menu_salesEdge']")); } }


public IWebElement LnkAdmin { get { return WebDriver.GetElement(By.Id("menu_manageSecurityOutput")); } }


public IWebElement LnkHome { get { return WebDriver.GetElement(By.Id("menu_home_link")); } }


public IWebElement LnkServiceTag { get { return WebDriver.GetElement(By.Id("menu_serviceTagSearch")); } }


public IWebElement DellLogoImg { get { return WebDriver.GetElement(By.XPath("//*[@id=body-content']/div[1]/div/a")); } }


public IWebElement LnkPersonSearch { get { return WebDriver.GetElement(By.Id("menu_personSearch")); } }


public IWebElement LnkCustomerSearch { get { return WebDriver.GetElement(By.Id("menu_smartSearch")); } }


public IWebElement SearchCustomerHome { get { return WebDriver.GetElement(By.XPath("//*[@id='yourCustomersSection']/div[2]/div/div/div[2]/div[1]/input")); } }


public IWebElement LnkViewOrderHold { get { return WebDriver.GetElement(By.Id("menu_orderHold")); } }


public IWebElement LnkMyPreferences { get { return WebDriver.GetElement(By.Id("menu_preferences")); } }


public IWebElement LnkDsaLearnMore { get { return WebDriver.GetElement(By.XPath("//*[@id='dsa_learnMore']")); } }


public IWebElement LnkAccessNSupport { get { return WebDriver.GetElement(By.XPath("//*[@id='dsa_gteos_support']")); } }


public IWebElement LnkSalesRepTagging { get { return WebDriver.GetElement(By.Id("menu_salesRepTagging")); } }

        //[FindsBy(How = How.XPath, Using = "//*[@id='menu_workflow']")]
        //public IWebElement LnkMenuWorkflow;


public IWebElement LnkMenuWorkflow { get { return WebDriver.GetElement(By.XPath("//*[@id='dropMenu']|//button[@id='menu_pom_workflow']")); } }
        

public IWebElement LnkOrderHoldWorkflow { get { return WebDriver.GetElement(By.Id("menu_order_hold_workflow")); } }


public IWebElement LnkDAMreqPendingApprovals { get { return WebDriver.GetElement(By.Id("menu_approvalRequestsPending")); } }


public IWebElement LnkDAMRequests { get { return WebDriver.GetElement(By.Id("menu_approvalRequests")); } }


public IWebElement LnkAutomation { get { return WebDriver.GetElement(By.Id("menu_automation")); } }

public IWebElement LnkDSAM { get { return WebDriver.GetElement(By.Id("menu_accessDsam")); } }



        #endregion

        #region Methods 

        /// <summary>
        /// Clicks on Search Account hyperlink.
        /// </summary>
        public AccountSearchPage SearchAccount()
        {
            LnkSearchAccount.Click(WebDriver);
            return new AccountSearchPage(WebDriver);
        }
         
        public ImportCartPopUp ImportLegacyCart()
        {
            LnkImportLegacyCart.Click(WebDriver);
            //WebDriverByLblSummaryTotalTax_byImportLegacyCartLnk);
            importCart = new ImportCartPopUp(this.ParentPage, LnkImportLegacyCart);
            return importCart;
        }
        
        /// <summary>
        /// Clicks on Legacy Cart.
        /// </summary>
        public ImportCartPopUp ClickLegacyCart()
        {
            LnkImportLegacyCart.Click(WebDriver);
            //WebDriverByLblSummaryTotalTax_byImportLegacyCartLnk);
            return new ImportCartPopUp(ParentPage, WebDriver.GetElement(By.ClassName("modal-small")));
        }
        
        /// <summary>
        /// Clicks on Search Customer hyperlink.
        /// </summary>
        public PersonSearchPage SearchPerson()
        {
            LnkPersonSearch.Click(WebDriver);
             return new PersonSearchPage(WebDriver);
        }

        

        public OrganizationSearchPage SearchOrganization()
        {
            LnkSearchOrg.Click(WebDriver);
            return new OrganizationSearchPage(WebDriver);
        }

        /// <summary>
        /// Clicks on Search Quote hyperlink.
        /// </summary>
        public QuoteSearchPage SearchQuote()
        {
            LnkSearchQuote.Click(WebDriver);
            return new QuoteSearchPage(WebDriver);
        }

        /// <summary>
        /// Clicks on Search Quote hyperlink.
        /// </summary>
        public MPFPage NavigatetoManagePartner()
        {
            LnkManagePartnerFavorites.Click(WebDriver);
            return new MPFPage(WebDriver);
        }

        /// <summary>
        /// Clicks on Order Hold Workflow hyperlink.
        /// </summary>
        public ManageHeldOrdersPage OrderHeldWorkflow()
        {
            LnkOrderHoldWorkflow.Click(WebDriver);
            return new ManageHeldOrdersPage(WebDriver);
        }

        /// <summary>
        /// Clicks on Auytomation Workflow hyperlink.
        /// </summary>
        public AutomationPage AutomationWorkflow()
        {
            LnkAutomation.Click(WebDriver);
            if (WebDriver.WindowHandles.Count < 2)
            {
                return new AutomationPage(WebDriver);
               
            } else
            {
                AutomationPage bulkUITab = SwitchToBulkUITabFromHomePage(WebDriver, "Dell | Dell BulkUI");
                return bulkUITab;
            }
        }

        public AutomationPage SwitchToBulkUITabFromHomePage(IWebDriver driver, string title)
        {
            string parentWindow = driver.CurrentWindowHandle;
            foreach (string window in driver.WindowHandles)
            {
                if (window != parentWindow)
                {
                    driver.SwitchTo().Window(window);
                    if (driver.Title.Contains(title))
                    {
                        Logger.Write("Window Switched to " + driver.Url);
                        return new AutomationPage(driver);
                    }
                }

            }
           return null;
       }

        /// <summary>
        /// Clicks on Search Order hyperlink.
        /// </summary>
        public OrderSearchPage SearchOrder()
        {
            LnkSearchOrder.Click(WebDriver);
            return new OrderSearchPage(WebDriver);
        }

        /// <summary>
        /// Clicks on Search Order hyperlink.
        /// </summary>
        public PomSearchPage SearchPomId()
        {
            LnkSearchPomid.Click(WebDriver);
            return new PomSearchPage(WebDriver);
        }

        public HomePage GamaLink()
        {
            LnkGama.Click(WebDriver);
            return new HomePage(WebDriver);
        }

        /// <summary>
        /// Clicks on Search Product hyperlink.
        /// </summary>
        public ProductSearchPage SearchProduct()
        {
            LnkSearchProduct.Click(WebDriver);
            return new ProductSearchPage(WebDriver);
        } 
        
        /// <summary>
        /// Clicks on Search Solution hyperlink.
        /// </summary>
        public SolutionSearchPage SearchSolution()
        {
            LnkSearchSolution.Click(WebDriver);
            return new SolutionSearchPage(WebDriver);
        } 
        
        /// <summary>
        /// Clicks on Preview hyperlink.
        /// </summary>
        public PreviewOrderCodePage Preview()
        {
            LnkPreview.Click(WebDriver);
            return new PreviewOrderCodePage(WebDriver);
        }

        /// <summary>
        /// Clicks on Preview hyperlink.
        /// </summary>
        public PreviewOrderCodePage RFPandProposalExpressPortal()
        {
            LnkRFPAndProposalExpressPortal.Click(WebDriver);
            return new PreviewOrderCodePage(WebDriver);
        }

        /// <summary>
        /// Clicks on Add Customer hyperlink.
        /// </summary>
        public CustomerCreatePage AddCustomer()
        {
            LnkAddCustomer.Click(WebDriver);
            return new CustomerCreatePage(WebDriver);
        }
 
        /// <summary>
        /// Clicks on Add Quote hyperlink.
        /// </summary>
        public CreateQuotePage AddQuote()
        {
            LnkAddQuote.Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        }

        /// <summary>
        /// Clicks on Add Solution hyperlink.
        /// </summary>
        public CreateQuotePage AddSolution()
        {
            LnkAddSolution.Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        } 

        /// <summary>
        /// Clicks on Customer Communication hyperlink.
        /// </summary>
        public CustomerCommunicationPage CustomerCommunication()
        {
            LnkCustomerCommunication.Click(WebDriver);
            return new CustomerCommunicationPage(WebDriver);
        }
 
        /// <summary>
        /// Clicks on Reporting hyperlink.
        /// </summary>
        public OrderHistoryReportPage Reporting()
        {
            LnkReporting.Click(WebDriver);
            return new OrderHistoryReportPage(WebDriver);
        } 


        public string DSARFP()
        {
            Logger.Write("DSA RFP link found and returned");
            return LnkRFPAndProposalExpressPortal.GetAttribute("href");
        }



        /// <summary>
        /// Clicks on Admin hyperlink.
        /// </summary>
        public AdministrationPage Admin()
        {
            LnkAdmin.Click(WebDriver);
            return new AdministrationPage(WebDriver);
        }

        /// <summary>
        /// Clicks on Home hyperlink.
        /// </summary>
        public HomePage Home()
        {
            LnkHome.Click(WebDriver);
            return new HomePage(WebDriver);
        }
        
        /// <summary>
        /// Click on Dell Logo
        /// </summary>
        /// <param name="isDeterministicSearch"></param>
        /// <returns></returns>
        public void DellLogo()
        {
            DellLogoImg.Click(WebDriver);
        }

        public void MenuMaintainedAsDataViewerLnk()
        {
            new HomePage(WebDriver).ClickMainMenu(WebDriver);
            LnkMaintainedAsDataViewer.Click(WebDriver);
        }

        /// <summary>
        /// Click on Dell Logo
        /// </summary>
        /// <param name="isDeterministicSearch"></param>
        /// <returns></returns>
        public ServiceTagSearchPage ServiceTagClick()
        {
            LnkServiceTag.Click(WebDriver);
            return new ServiceTagSearchPage(WebDriver);
        }
 
        /// <summary>
        /// Click on Dell Logo
        /// </summary>
        /// <param name="isDeterministicSearch"></param>
        /// <returns></returns>
        public PersonSearchPage PersonSearchClick()
        {
            LnkPersonSearch.Click(WebDriver);
            return new PersonSearchPage(WebDriver);
        }


        public CustomerSearchPage CustomerSearchClick()
        {
            LnkCustomerSearch.Click(WebDriver);
            return new CustomerSearchPage(WebDriver);
        }


        /// <summary>
        /// Click on Sales rep tagging link
        /// </summary>
        /// <param name="isDeterministicSearch"></param>
        /// <returns></returns>
        public SalesRepTaggingPage SalesRepTagging()
        {
			LnkSalesRepTagging.Click(WebDriver);
            return new SalesRepTaggingPage(WebDriver);
        }

        
        /// <summary>
        /// Click on My Preferences link
        /// </summary>
        /// <param name="isDeterministicSearch"></param>
        /// <returns></returns>
        public MyPreferencesPage MyPreferences()
        {
            LnkMyPreferences.Click(WebDriver);
            return new MyPreferencesPage(WebDriver);
        }

        public HeldOrderPage ViewOrderHold()
        {
            LnkViewOrderHold.Click(WebDriver);
            return new HeldOrderPage(WebDriver);
        }

        public int GetMenuElementsCount()
        {
            var elements = WebDriver.FindElements(By.XPath("//*[@id='dropMenu']/descendant::button"));
            return elements.Count;
        }


        public PriceRequestPage DSAMClick()
        {
            LnkDSAM.Click(WebDriver);
            return new PriceRequestPage(WebDriver);
        }
        #endregion



        public IPage ClickOnMenuItem(MenuItemToClick menuItem)
        {
            IPage returnPage = null;
            switch (menuItem)
            {
                case MenuItemToClick.AddCustomer:
                {
                    LnkAddCustomer.Click(WebDriver);
                    returnPage = new CustomerCreatePage(WebDriver);
                    break;
                }
                case MenuItemToClick.AddQuote:
                {
                    LnkAddCustomer.Click(WebDriver);
                    //returnPage = new CreateQuotePage(WebDriver); TODO : 
                    break;
                }
                case MenuItemToClick.Admin:
                {
                    LnkAddCustomer.Click(WebDriver);
                    returnPage = new AdminPage(WebDriver);
                    break;
                }
                case MenuItemToClick.Automation:
                {
                    LnkAddCustomer.Click(WebDriver);
                    returnPage = new AutomationPage(WebDriver);
                    break;
                }
                case MenuItemToClick.CustomerCommunication:
                {
                    LnkAddCustomer.Click(WebDriver);
                    returnPage = new PersonSearchPage(WebDriver);
                    break;
                }               
                default:
                {
                    returnPage = new HomePage(WebDriver);
                    break;
                }
            }
            return returnPage;
        }

        public override bool Validate()
        {
            return LnkPersonSearch.Displayed;
        }

        public bool VerifyMenuName(IWebDriver driver, string menuName)
        {
            if (LnkReporting.Text.Trim() == menuName)
            {
                return true;
            }
            return false;
        }
    }
}