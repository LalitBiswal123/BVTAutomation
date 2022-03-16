using System;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using OpenQA.Selenium.Support.UI;
using FluentAssertions;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;

namespace Dsa.Pages
{
    public class MyPreferencesPage : DsaPageBase
    {
        public MyPreferencesPage(IWebDriver webDriver)
            : base(webDriver)
        {
          PageFactory.InitElements(webDriver, this);
        }
        #region -- Elements --
        

public IWebElement MyPrefUserPreferenceLabel { get { return WebDriver.GetElement(By.Id("preferences_header")); } }


public IWebElement MyPrefAccounts { get { return WebDriver.GetElement(By.Id("Home Page_Customer List_Accounts_RADIOBUTTON")); } }


public IWebElement MyPrefCustomers { get { return WebDriver.GetElement(By.Id("Home Page_Customer List_Customers_RADIOBUTTON")); } }


public IWebElement MyPrefSavePreferences { get { return WebDriver.GetElement(By.Id("_viewStatus")); } }


public IWebElement HomepageCustomerList { get { return WebDriver.GetElement(By.XPath("(//*[@id='main']//h3)[1]")); } }
        

public IWebElement TaxCalculationinCreateQuote { get { return WebDriver.GetElement(By.XPath("(//*[@id='main']//h3)[2]")); } }


public IWebElement MyPrefManual { get { return WebDriver.GetElement(By.Id("Quote_Tax Calculation_Manual_RADIOBUTTON")); } }


public IWebElement MyPrefAutomatic { get { return WebDriver.GetElement(By.Id("Quote_Tax Calculation_Automatic_RADIOBUTTON")); } }


public IWebElement SavePreferences { get { return WebDriver.GetElement(By.XPath("//*[@id='pref_navigation']/div[2]/div/button")); } }


public IWebElement MyPrefOrderAckNo { get { return WebDriver.GetElement(By.Id("Order Acknowledgment_Send Order Acknowledgement_No_RADIOBUTTON")); } }


public IWebElement MyPrefOrderAckYes { get { return WebDriver.GetElement(By.Id("Order Acknowledgment_Send Order Acknowledgement_Yes_RADIOBUTTON")); } }


public IWebElement MyPrefOrderAckInclMeAsRecpntNo { get { return WebDriver.GetElement(By.Id("Order Acknowledgment_Include me as recipient_No_RADIOBUTTON")); } }


public IWebElement MyPrefOrderAckInclMeAsRecpntYes { get { return WebDriver.GetElement(By.Id("Order Acknowledgment_Include me as recipient_Yes_RADIOBUTTON")); } }

        
        public IWebElement OrderAckResettoDefaultlink { get { return WebDriver.GetElement(By.XPath("//*[@id='grp_Order Acknowledgment']/div/div/div/div/following::div/a[text()='Reset to Default']")); } }

      
        public IWebElement ResettodefaultOk { get { return WebDriver.GetElement(By.Id("_btn_ok")); } }


        public IWebElement SavePreferencesBtn { get { return WebDriver.GetElement(By.XPath("//button[text()='Save Preferences']")); } }


public IWebElement ViewAllConfigurations { get { return WebDriver.GetElement(By.Id("Quote_Product Configuration_View All_RADIOBUTTON")); } }


public IWebElement ViewConfigurable { get { return WebDriver.GetElement(By.Id("Quote_Product Configuration_View Configurable_RADIOBUTTON")); } }


public IWebElement ManuallyValidateYes { get { return WebDriver.GetElement(By.Id("Quote_Manually Validate Configuration_Yes_RADIOBUTTON")); } }


public IWebElement ManuallyValidateNo { get { return WebDriver.GetElement(By.Id("Quote_Manually Validate Configuration_No_RADIOBUTTON")); } }


public IWebElement DdlQuotExpiration { get { return WebDriver.GetElement(By.Id("Quote_Quote Expiration_LIST")); } }


public IWebElement MyPrefPricingManual { get { return WebDriver.GetElement(By.Id("Quote_Pricing Mode (Not applicable for Solutions)_Manual_RADIOBUTTON")); } }


public IWebElement MyPrefPricingStandard { get { return WebDriver.GetElement(By.Id("Quote_Pricing Mode (Not applicable for Solutions)_Standard_RADIOBUTTON")); } }


public IWebElement MyPrefEnbleWalkMeYes { get { return WebDriver.GetElement(By.Id("WalkMe_Enable WalkMe_Yes_RADIOBUTTON")); } }


public IWebElement MyPrefEnbleWalkMeNo { get { return WebDriver.GetElement(By.Id("WalkMe_Enable WalkMe_No_RADIOBUTTON")); } }


public IWebElement WalkMe { get { return WebDriver.GetElement(By.XPath("//*[@id='walkme - player']")); } }


public IWebElement IFrameWalkMe { get { return WebDriver.GetElement(By.Id("walkme-proxy-iframe")); } }

        public void WaitForWalkMe()
        {
            while (WebDriver.TryFindElement(WalkMe, TimeSpan.FromSeconds(60)))
            {
                // Do Nothing
            }
        }

        #endregion

        #region -- Methods --

        public string GetPrefOption(IWebDriver driver)
        {
            if (MyPrefAccounts.Selected)
            {
                return "accounts";
            }
            else
            {
                return "customers";
            }
        }

        public string GetprefTaxOption(IWebDriver driver)
        {
            if (MyPrefManual.Selected)
            {
                return "(//*[@id='main']//p[1]/label/input)[2]";
            }
            else
            {
                return "(//*[@id='main']//p[2]/label/input)[2]";
            }
        }
        public HomePage ChangeNSavePreferences(string prefOption, IWebDriver driver)
        {
            string lcprefOption = prefOption.ToLower().Trim();
            Console.WriteLine("Options is: " + lcprefOption);
            driver.WaitFor(x=>x.FindElementBy(By.Id(lcprefOption),TimeSpan.FromSeconds(120)));
            var rbutton = driver.FindElement(By.Id(lcprefOption),TimeSpan.FromSeconds(120));
            driver.WaitFor(x=>rbutton.Selected,120);
            Console.WriteLine("Found Radio button to be selected (Values from DB returned)");
           
            if (lcprefOption.Equals("accounts"))
            {
                MyPrefCustomers.Click(driver);
                driver.WaitForPageLoad();
                Logger.Write("MyPreference is now set to customers");
            }
            else if (lcprefOption.Equals("customers"))
            {
                MyPrefAccounts.Click(driver);
                driver.WaitForPageLoad();
                Logger.Write("MyPreference is now set to accounts");                
            }
            else
            {
                Logger.Write("Please enter valid preference option");
            }
            driver.WaitForPageLoad();
            MyPrefSavePreferences.Click(driver);
            return ClickDellLogo(driver);
        }
        //Change My Tax calculation preference to Manual Start
        public HomePage ChangeNSavePreferencesTaxCalc(string prefOption, IWebDriver driver)
        {
            string lcprefTaxOption = prefOption;

            if (lcprefTaxOption.Equals("manual"))
            {
                //MyPrefAutomatic.Click(driver);
                Logger.Write("Tax Calcualtion Preference is already set to Manual");
            }
            else if (lcprefTaxOption.Equals("automatic"))
            {
                MyPrefManual.Click(driver);
                Logger.Write("Tax Calcualtion Preference is now set to Manual");
				SavePreferences.Click(WebDriver);
            }
            else
            {
                Logger.Write("Please enter valid preference option");
            }
            
            return ClickDellLogo(driver);
        }
		//Change My Tax calculation preference to Automatic 
		public HomePage ChangeNSavePreferencesToAutomatic(string prefOption, IWebDriver driver)
		{
			string lcprefTaxOption = prefOption;

			if (lcprefTaxOption.Equals("manual"))
			{
				MyPrefAutomatic.Click(driver);
				Logger.Write("Tax Calcualtion Preference is already set to Automatic");
				SavePreferences.Click(WebDriver);
			}
			else if (lcprefTaxOption.Equals("automatic"))
			{
				MyPrefManual.Click(driver);
				Logger.Write("Tax Calcualtion Preference is now set to Manual");				
			}
			else
			{
				Logger.Write("Please enter valid preference option");
			}

			return ClickDellLogo(driver);
		}
		public MyPreferencesPage ChangeAndVerifyMyPreferencesOptions()
        {
            string prefOption = "";

            //HomeWorkflow.GoToMyPreferencesPage(TestWebDriver);
            //var myPrefpage = new MyPreferencesPage(WebDriver);
            WebDriver.WaitFor(x => MyPrefManual.Selected, 5, true);
            prefOption = "";
            if (MyPrefManual.Selected)
            {
                prefOption = "manual";
                Logger.Write("Tax Calcualtion Preference is already set to Manual");
				
            }
            else
            {
                prefOption = "automatic";
                ChangeNSavePreferencesTaxCalc(prefOption, WebDriver);
				
			}
            return new MyPreferencesPage(WebDriver);
        }
		//Change My Tax calculation preference to Automatic
		public MyPreferencesPage ChangeMyPreferencesOptionsToAutomatic()
		{
			string prefOption = "";
		
			WebDriver.WaitFor(x => MyPrefAutomatic.Selected, 5, true);
			prefOption = "";
			if (MyPrefAutomatic.Selected)
			{
				prefOption = "automatic";
				Logger.Write("Tax Calcualtion Preference is already set to automatic");
				
			}
			else
			{
				prefOption = "manual";
				ChangeNSavePreferencesToAutomatic(prefOption, WebDriver);
			}
			return new MyPreferencesPage(WebDriver);
		}





        //  public MyPreferencesPage OrderAckSelection(IWebElement OrderAckNo,IWebElement OrderAckYes,String OrderAckOptionLabel)
        // {

        //   if (OrderAckNo.Selected)
        //   {

        // Logger.Write(OrderAckOptionLabel+" Option Is Set To No");

        // }
        // else if(OrderAckYes.Selected)
        // {

        //   Logger.Write(OrderAckOptionLabel+" Option Is Set To Yes");
        //   }
        //  return new MyPreferencesPage(WebDriver);
        // }
        public MyPreferencesPage OrderAckSelection(IWebElement OrderAck, String OrderAckOptionLabel)
        {

            if (OrderAck.Selected)
            {

                Logger.Write(OrderAckOptionLabel + " Is Selected");

            }
            
            return new MyPreferencesPage(WebDriver);
        }

        public void WaitForBusyIndicator(IWebDriver Driver)//Changes Done As Per New UI Works Fine
        {
            WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            Wait.Until(
              ExpectedConditions.InvisibilityOfElementLocated(
                  By.XPath(".//*[@id='busy-indicator']")));
            System.Threading.Thread.Sleep(1000 * 3);
        }

        public void SetQuoteExpiration(IWebDriver webDriver, string value)
        {
            DdlQuotExpiration.PickDropdownByText(WebDriver, value);
            SavePreferences.Click(WebDriver);
        }

        public void SetPricingMode(IWebDriver testWebDriver, string PricingMode)
        {
            bool isManualSelected = MyPrefPricingManual.Selected;
            bool isStandardSelected = MyPrefPricingStandard.Selected;
            if (isManualSelected && PricingMode == "Manual")
            {
                Logger.Write("Pricing mode in user preference is already set to Manual");

            }
            else if (isStandardSelected && PricingMode == "Standard")
            {
                Logger.Write("Pricing mode in user preference is already set to Standard");
            }
            else if (PricingMode == "Manual")
            {
                MyPrefPricingManual.Click(testWebDriver);
                Logger.Write("Pricing mode in user preference is now set to Manual");
                SavePreferences.Click(WebDriver);

            }
            else
            {
                MyPrefPricingStandard.Click(testWebDriver);
                Logger.Write("Pricing mode in user preference is now set to Standard");
                SavePreferences.Click(WebDriver);
            }
            ClickDellLogo(testWebDriver);
        }
        public void VerifyMyPreferences(IWebDriver Driver)
        {
            new MyPreferencesPage(Driver).OrderAckSelection(MyPrefOrderAckInclMeAsRecpntNo, "Include me as recipient No");
            MyPrefOrderAckInclMeAsRecpntNo.Selected.Should().Be(true);
            //mypreferences.WaitForBusyIndicator(TestWebDriver);
            if (MyPrefOrderAckNo.Selected)
            {

                MyPrefOrderAckYes.Click();
                new MyPreferencesPage(Driver).OrderAckSelection(MyPrefOrderAckYes, "Send Order Acknowledgement Yes");
                OrderAckResettoDefaultlink.Click();
                ResettodefaultOk.Click();
                WaitForBusyIndicator(Driver);
                MyPrefOrderAckNo.Selected.Should().Be(true);
                new MyPreferencesPage(Driver).OrderAckSelection(MyPrefOrderAckNo, "Send Order Acknowledgement No");


            }
            if (MyPrefOrderAckInclMeAsRecpntNo.Selected)
            {

                MyPrefOrderAckInclMeAsRecpntYes.Click();
                new MyPreferencesPage(Driver).OrderAckSelection(MyPrefOrderAckInclMeAsRecpntYes, "Include me as recipient Yes");
                //mypreferences.MyPrefOrderAckInclMeAsRecpntYes.Should().Be(true);
                OrderAckResettoDefaultlink.Click();
                ResettodefaultOk.Click();
                WaitForBusyIndicator(Driver);
                new MyPreferencesPage(Driver).OrderAckSelection(MyPrefOrderAckInclMeAsRecpntNo, "Include me as recipient No");
                MyPrefOrderAckInclMeAsRecpntNo.Selected.Should().Be(true);
            }


            if (MyPrefOrderAckNo.Selected)
            {
                if (MyPrefOrderAckInclMeAsRecpntNo.Selected)
                {

                    MyPrefOrderAckYes.Click();
                    new MyPreferencesPage(Driver).OrderAckSelection(MyPrefOrderAckYes, "Include me as recipient Yes");

                    MyPrefOrderAckInclMeAsRecpntYes.Click();
                    new MyPreferencesPage(Driver).OrderAckSelection(MyPrefOrderAckInclMeAsRecpntYes, "Include me as recipient Yes");

                    SavePreferencesBtn.Click();
                    WaitForBusyIndicator(Driver);
                    OrderAckResettoDefaultlink.Click();
                    ResettodefaultOk.Click();
                    WaitForBusyIndicator(Driver);
                    new MyPreferencesPage(Driver).OrderAckSelection(MyPrefOrderAckNo, "Send Order Acknowledgement No");

                    new MyPreferencesPage(Driver).OrderAckSelection(MyPrefOrderAckInclMeAsRecpntNo, "Include me as recipient No");
                    MyPrefOrderAckNo.Selected.Should().Be(true);
                    MyPrefOrderAckInclMeAsRecpntNo.Selected.Should().Be(true);
                }
            }
        }
        #endregion
    }
}
