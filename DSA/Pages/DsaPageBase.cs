using Dsa.Utils;
using OpenQA.Selenium;
using System;
using Dsa.Pages.Quote;
using Dell.Adept.UI.Web.Pages;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;

namespace Dsa.Pages
{
    public class DsaPageBase : PageBase
    {
        public const string DefaultElementText = "-";
        private bool disposedValue1;

        public DsaPageBase(IWebDriver webDriver)
            : base(ref webDriver)
        {
        }

        public bool IsBusy()
        {
            try
            {
                return Busy.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }


public IWebElement Busy { get { return WebDriver.GetElement(By.Id("busy-overlay")); } }

public IWebElement CurrentQuote { get { return WebDriver.GetElement(By.Id("menu_currentQuote1")); } }

public IWebElement ViewQuote { get { return WebDriver.GetElement(By.Id("_viewquote")); } }
        //[FindsBy(How = How.Id, Using = "menu_versionToggle")]
        //public IWebElement MainMenu;
        //public IWebElement MainMenu { get { return WebDriver.GetElement(By.Id("menu_main_label")); } }

        public IWebElement MainMenu { get { return WebDriver.GetElement(By.XPath("//span[@id='masthead_menu_title']")); } }
        //[FindsBy(How = How.CssSelector, Using = "#body-content > div.main-nav > div > div > a > i")]
        //public IWebElement DellLogoImg;
        public IWebElement DellLogoImg { get { return WebDriver.GetElement(By.Id("DellIcon")); } }

        //[FindsBy(How = How.Id, Using = "customerDetails_dashboard")]

public IWebElement LnkDashboardIcon_Dropdown { get { return WebDriver.GetElement(By.XPath("//a[@title='Customer Dashboard']")); } }

public IWebElement DashboardIcon { get { return WebDriver.GetElement(By.XPath("//a[@id='customerDetails_dashboard']/i")); } }

public IWebElement BtnWorkThisItem { get { return WebDriver.GetElement(By.XPath("//button[@class='btn btn-success']")); } }

public IWebElement RefreshProfile { get { return WebDriver.GetElement(By.Id("menu_refresh_profile")); } }

public IWebElement ClickonYes { get { return WebDriver.GetElement(By.Id("messageDialogButton_0")); } }

        public IWebElement CartItemsLnk
        { get { return WebDriver.GetElement(By.Id("menu_productItems1")); } }

        /// <summary>
        /// Click on Dell Logo.
        /// </summary>
        /// <returns></returns>
        public HomePage ClickDellLogo(IWebDriver driver)
        {
            DellLogoImg.Click(driver);
            return new HomePage(driver);
        }


        //TODO : Revisit after Utils checkin

        public CreateQuotePage GoToCurrentQuotePage()
        {
            CurrentQuote.Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        }

        public CreateQuotePage GoToViewQuotePage()
        {
            ViewQuote.Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        }


        public MainMenu ClickMainMenu(IWebDriver driver)
        {
            MainMenu.Click(driver);
            //Logger.Write("main menu clicked");
            return new MainMenu(this, MainMenu);
        }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }

        public override bool IsActive()
        {
            throw new NotImplementedException();
        }

        public string GetToolTipText(IWebElement ToolTipElement)
        {
            string toolTipText = string.Empty;
            Actions action = new Actions(WebDriver);
            action.MoveToElement(ToolTipElement).Perform();
            toolTipText = ToolTipElement.GetAttribute("title");
            return toolTipText;
        }

        public string ClearPriceGetIconText(IWebElement ToolTipElement)
        {
            string toolTipText = string.Empty;
            Actions action = new Actions(WebDriver);
            action.MoveToElement(ToolTipElement).Perform();
            toolTipText = ToolTipElement.GetAttribute("contenttodisplay");
            return toolTipText;
        }

        public CreateQuotePage CartViewLnk()
        {
            CartItemsLnk.Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        }

        
    }
}
