using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Dsa.Pages.Quote;
using System.Collections.Generic;
using System;

namespace Dsa.Pages.APOS
{
    public class AposConfigurePage : DsaPageBase
    {
        public AposConfigurePage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements

        public IWebElement RemoveRecertFeeBtn { get { return WebDriver.GetElement(By.Id("productConfig_removeReinstatementFee_0")); } }

        public IWebElement SetdatesTab { get { return WebDriver.GetElement(By.XPath("//*[@id='body-content']//div[2]//app-root//product-configure//div//tabset//ul/li[3]")); } }


        public IWebElement AddCustomSkuTab { get { return WebDriver.GetElement(By.XPath("//span[normalize-space()='Add Custom Sku']")); } }
        public IWebElement SelectGroup { get { return WebDriver.GetElement(By.XPath("//*[@class='btn-group']")); } }

        public IWebElement ModuleToggle { get { return WebDriver.GetElement(By.XPath("//*[@id='body-content']//tab[3]//set-dates//div//div[2]//div//div//a//div[1]")); } }

        public IWebElement CustomSKU { get { return WebDriver.GetElement(By.XPath("//input[@id='addCustomSku_TextInput']")); } }

        public IWebElement AddButton { get { return WebDriver.GetElement(By.XPath("//button[@class='btn btn-primary input-btn module-group-add-btn']")); } }
        //public IWebElement AddButton { get { return WebDriver.GetElement(By.CssSelector(".col-md-4.offset-0")); } }
        public IWebElement Success { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-success module-group-alert-mg']")); } }

        public IWebElement Alert { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-warning module-group-alert-mg']")); } }

        public IWebElement AlertMessage2 { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-warning module-group-alert-mg']")); } }

        public IWebElement InlineError { get { return WebDriver.GetElement(By.XPath("//div[@class='module-group-invalid--message-c-red']")); } }

        public IWebElement TabOut { get { return WebDriver.GetElement(By.XPath("//div[@class='module-group-invalid--message-c-red']")); } }
        public IWebElement SetDuration { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='Set Date Range']/../span)[2]")); } }

        public IWebElement UpdateDuration { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='Upgrade']/../span)[2]")); } }

        public IWebElement SummaryTab { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='Summary']")); } }

        public IWebElement SummaryUpdateLnk { get { return WebDriver.GetElement(By.Id("productConfig_summary_update")); } }

        public IWebElement ViewQuoteBtn { get { return WebDriver.GetElement(By.Id("productConfig_viewQuote")); } }

        public IWebElement TechSupportSelection { get { return WebDriver.GetElement(By.XPath("//*[@id='productConfig_TECHSUPPORTSERVICESEXTENSION_selection_0']")); } }

        public IWebElement TechSupportModule { get { return WebDriver.GetElement(By.XPath("//*[@id='productConfig_option_0_TECHSUPPORTSERVICESEXTENSION_toggle']/div[2]")); } }

        public IWebElement ProductConfigSummary { get { return WebDriver.GetElement(By.Id("productConfig_summary")); } }

        public IWebElement SummarysellingPrice { get { return WebDriver.GetElement(By.Id("productConfig_summary_sellingPrice")); } }

        public IWebElement Module806ReinstatementFee { get { return WebDriver.GetElement(By.Id("productConfig_option_806")); } }

        public IWebElement ViewModules { get { return WebDriver.GetElement(By.XPath("//*[@class=' col-md-3']")); } }

        public IWebElement SolutionWarrantyNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Please Ensure that all Service Level Warranties are the same for all Products in the solution.')]")); } }

        public IWebElement ExpandServiceTag { get { return WebDriver.GetElement(By.XPath("//*[@class='k-icon k-i-arrow-s']")); } }

        public IWebElement UnitPriceLbl { get { return WebDriver.GetElement(By.XPath("//div[contains(text(), 'Unit Price')]")); } }

        public IWebElement RemoveAllRecertFeesBtn { get { return WebDriver.GetElement(By.Id("productConfigremoveAllRecertificationFees")); } }

        public IWebElement RemoveAllRecertFeesConfirm { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Yes, remove all recert fees')]")); } }

        public IWebElement RemoveAllRecertFeesCancel { get { return WebDriver.GetElement(By.Id("_btn_cancel")); } }

        public IWebElement ConfirmationDialog { get { return WebDriver.GetElement(By.XPath("//*[@id='mat-dialog-0']")); } }

        public IWebElement ConfirmationQuestion { get { return WebDriver.GetElement(By.XPath("//*[@id='mat-dialog-0']//span[contains(text(), 'You are removing all recert fees for the group(s). Are you sure you want to proceed?')]")); } }

        public IWebElement FinalPrice { get { return WebDriver.GetElement(By.XPath("//*[@id='productConfig_summary_finalPrice']")); } }

        public IWebElement RemoveServiceTag { get { return WebDriver.GetElement(By.XPath("//i[@class='dds__icons dds__trash']")); } }

        //public IWebElement MultiGroupConfiguration { get { return WebDriver.GetElement(By.Id("MultiGroupConfigurationDialog_Submit")); } }
        public IWebElement MultiGroupConfiguration { get { return WebDriver.GetElement(By.XPath("//button[@id='MultiGroupConfigurationDialog_Submit']")); } }

        public IWebElement Module801ServiceUpgradesdd { get { return WebDriver.GetElement(By.XPath("(//module/div//a)[1]")); } }
        public IWebElement radioMonthlySubsPremium { get { return WebDriver.GetElement(By.XPath("(//tbody/tr/td[contains(text(),'Monthly Subscript')]/preceding-sibling::td/input)[1]")); } }
        public IWebElement setdurationdd { get { return WebDriver.GetElement(By.XPath("//*[text()=' Set Group Level Duration ']/../../following-sibling::div//a")); } }
        public IWebElement daterangeTab { get { return WebDriver.GetElement(By.XPath("//*[text()='Date Range']/..")); } }
        public IWebElement Appydaterange { get { return WebDriver.GetElement(By.XPath("(//*[@id='apos_setDates_item_apply'])[2]")); } }
        public IWebElement ErrSAQ { get { return WebDriver.GetElement(By.XPath("//*[contains(text(),'All entitlements must have a duration of one month to be eligible for recurring billing.')]")); } }

        #endregion

        public AposConfigurePage UpdateSummary()
        {
            SummaryUpdateLnk.Click(WebDriver);
            return new AposConfigurePage(WebDriver);
        }

        public CreateQuotePage ViewQuote()
        {
            ViewQuoteBtn.Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        }

        public IWebElement RecertFeeRemovedStatus(int? Index)
        {
            return WebDriver.FindElement(By.XPath("(//span[contains(text(), 'Fees Removed')])[" + Index + "]"));
        }

        public AposConfigurePage RemoveAllRecertFees()
        {
            RemoveAllRecertFeesBtn.Click(WebDriver);
            RemoveAllRecertFeesConfirm.Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return new AposConfigurePage(WebDriver);
        }

        public AposConfigurePage RemoveRecertFee()
        {
            RemoveRecertFeeBtn.Click(WebDriver);
            return new AposConfigurePage(WebDriver);
        }

        public AposConfigurePage SelectTechSupportModule()
        {
            TechSupportModule.Click(WebDriver);
            TechSupportSelection.Click(WebDriver);
            return new AposConfigurePage(WebDriver);
        }

        public AposConfigurePage SelectViewAll()
        {
            ViewModules.PickDropdownByIndex(WebDriver, 0);

            return new AposConfigurePage(WebDriver);
        }

        public AposConfigurePage SelectDateRangeTab()
        {
            setdurationdd.Click(WebDriver);
            daterangeTab.Click(WebDriver);


            return new AposConfigurePage(WebDriver);
        }
        public void SelectServiceCatlog(string catlogeNo)
        {
            WebDriver.FindElement(By.XPath("//div[@class='module-left']//*[contains(text(),'" + catlogeNo + "')]/ancestor::div[contains(@class,'module-ctnr')]//a")).Click();

        }
        public void SelectMonthlyPremiumRadio()
        {

            for (int i = 0; radioMonthlySubsPremium.Selected == false; i++)
            {
                ((IJavaScriptExecutor)WebDriver).ExecuteScript("arguments[0].click()", radioMonthlySubsPremium);
                WebDriver.VerifyBusyOverlayNotDisplayed();
            }

        }



        public Boolean IsPresent(IWebElement element)
        {
            if ((element) == null)
                return false;
            else
                return true;
        }
        public string CalculateDateFromCurrentDate(int PlusDays = 0, int PlusMonths = 0)
        {
            string expectedDate = DateTime.Now.AddDays(PlusDays).AddMonths(PlusMonths).ToString("dd/MM/yyyy");
            return expectedDate;
        }
        public void datePickerEnterDates(string startDate, string datetype, IWebDriver driver)
        {
            string startdate1 = startDate;
            string[] splitDate = startdate1.Split('/');
            string day1 = splitDate[0];
            string month = splitDate[1];
            string year = splitDate[2];
            //string year1 = year[0];
            string day = null;
            int day2 = Convert.ToInt32(day1);
            if (day2 < 10)
            {
                day = day1.TrimStart('0');
            }
            else
            {
                day = day1;
            }

            string NewMonthInLetters = null;
            if ((month.Equals("01") || month.Equals("1")))
            {
                NewMonthInLetters = "January";
            }
            else if (month.Equals("02") || month.Equals("2"))
            {
                NewMonthInLetters = "February";
            }
            else if (month.Equals("03") || month.Equals("3"))
            {
                NewMonthInLetters = "March";
            }
            else if (month.Equals("04") || month.Equals("4"))
            {
                NewMonthInLetters = "April";
            }
            else if (month.Equals("05") || month.Equals("5"))
            {
                NewMonthInLetters = "May";
            }
            else if (month.Equals("06") || month.Equals("6"))
            {
                NewMonthInLetters = "June";
            }
            else if (month.Equals("07") || month.Equals("7"))
            {
                NewMonthInLetters = "July";
            }
            else if (month.Equals("08") || month.Equals("8"))
            {
                NewMonthInLetters = "August";
            }
            else if (month.Equals("09") || month.Equals("9"))
            {
                NewMonthInLetters = "September";
            }
            else if (month.Equals("10"))
            {
                NewMonthInLetters = "October";
            }
            else if (month.Equals("11"))
            {
                NewMonthInLetters = "November";
            }
            else if (month.Equals("12"))
            {
                NewMonthInLetters = "December";
            }

            if (datetype.Equals("StartDate"))
            {
                if (driver.FindElement(By.XPath("//*[@name='startDate']//span[contains(@class,'calendar')]")).Displayed) ;
                {
                    driver.FindElement(By.XPath("//*[@name='startDate']//span[contains(@class,'calendar')]")).Click();
                }

            }
            else if (datetype.Equals("EndDate"))
            {
                if (driver.FindElement(By.XPath("//*[@name='endDate']//span[contains(@class,'calendar')]")).Displayed)
                {
                    driver.FindElement(By.XPath("//*[@name='endDate']//span[contains(@class,'calendar')]")).Click();
                }
            }
            IList<IWebElement> tableRows = driver.FindElements(By.XPath("//daypicker/table/tbody/tr"));
            int rowCount = tableRows.Count;

            IList<IWebElement> tableCol = driver.FindElements(By.XPath("//daypicker/table/tbody/tr[1]/td"));
            int colCount = tableCol.Count;

            string newDateFind = NewMonthInLetters + " " + year;

            string CurrentMonth = driver.FindElement(By.XPath("//datepicker//table//th[2]/button/strong")).Text;
            string[] split = CurrentMonth.Split(' ');
            CurrentMonth = split[0];
            string CurrentYear = split[1];
            string NewDisplayDate = CurrentMonth + " " + CurrentYear;


            int flgy = 0;
            if (CurrentYear != year)
            {
                colCount = tableCol.Count;
                rowCount = tableRows.Count;
                driver.FindElement(By.XPath("//datepicker//table//th[2]/button/strong")).Click();
                driver.FindElement(By.XPath("//datepicker//table//th[2]/button/strong")).Click();
                for (int i = 1; i <= rowCount && flgy == 0; i++)
                {
                    for (int j = 1; j <= colCount && flgy == 0; j++)
                    {

                        string Table = driver.FindElement(By.XPath("//yearpicker/table/tbody/tr[" + i + "]/td[" + j + "]")).Text;
                        if (Table.Equals(year))
                        {
                            driver.FindElement(By.XPath("//yearpicker/table/tbody/tr[" + i + "]/td[" + j + "]")).Click();
                            flgy = 1;
                            break;
                        }
                    }
                }
            }
            int flg = 0;
            if (CurrentMonth != NewMonthInLetters)
            {
                colCount = tableCol.Count;
                rowCount = tableRows.Count;
                if (flgy == 0) { driver.FindElement(By.XPath("//datepicker//table//th[2]/button/strong")).Click(); }
                for (int i = 1; i <= rowCount && flg == 0; i++)
                {
                    for (int j = 1; j <= colCount && flg == 0; j++)
                    {

                        string Table = driver.FindElement(By.XPath("//monthpicker/table/tbody/tr[" + i + "]/td[" + j + "]")).Text;
                        if (Table.Equals(NewMonthInLetters))
                        {
                            driver.FindElement(By.XPath("//monthpicker/table/tbody/tr[" + i + "]/td[" + j + "]")).Click();
                            flg = 1;
                            break;
                        }
                    }
                }
            }


            colCount = tableCol.Count;
            rowCount = tableRows.Count;
            flg = 0;
            string dayTable;
            for (int i = 1; i <= rowCount && flg == 0; i++)
            {
                for (int j = 1; j <= colCount && flg == 0; j++)
                {

                    dayTable = driver.FindElement(By.XPath("//daypicker/table/tbody/tr[" + i + "]/td[" + j + "]")).Text;
                    if (dayTable.Equals(day))
                    {
                        driver.FindElement(By.XPath("//daypicker/table/tbody/tr[" + i + "]/td[" + j + "]")).Click();
                        flg = 1;
                        break;
                    }
                }
            }
        }

    }
}
