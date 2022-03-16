using System.Linq;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace Dsa.Pages.Solutions.ManageAccounts
{
    public partial class MailToPage : DsaPageBase
    {
        public MailToPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        public int MailToFindResults()
        {
            IWebElement table = WebDriver.FindElement(By.XPath("//*[@id='ma-customer-selection']/div[2]/div/dsa-ma-mail-to/div/div/div[3]/div/table/tbody"));
            ReadOnlyCollection<IWebElement> listOfRows = table.FindElements(By.TagName("tr"));

            return listOfRows.Count();
        }


        public bool getNotificationMessage()
        {
            try
            {
                return NoMailToResults.Displayed;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
        }

        public void WaitForElementLoadAndSwitchFrame()
        {
            DsaUtil.WaitForPageLoad(WebDriver);
            Thread.Sleep(5000);
            WebDriver.SwitchTo().Frame(1);
        }

        public void delay(int timeInSeconds)
        {
            Thread.Sleep(timeInSeconds * 1000);
        }

        public string[] getTitles()
        {
            SelectElement el = new SelectElement(SearchMailToBy);
            string[] actualTitles = new string[el.Options.Count - 1];
            for (int i = 1; i <= actualTitles.Length; i++)
            {
                actualTitles[i - 1] = el.Options.ElementAt(i).Text.Trim();
            }
            return actualTitles;
        }


        public ShipToPage SelectMailToAPJ(string CountryCode)
        {
            if (BtnUseAsMailTo.Displayed)
            {
                BtnUseAsMailTo.Click(WebDriver);
            }
            else
            {
                if (MailToFindResults() >= 1)
                {
                    MailToExpandResult.Click(WebDriver);
                    SelectResult.Click(WebDriver);
                }
                else
                {
                    SearchMailToBy.PickDropdownByText(WebDriver, CountryCode);
                    SearchByOptions.SetText(WebDriver, "CN");
                    SearchIcon.Click(WebDriver);
                }
            }
            return new ShipToPage(WebDriver);
        }




        #region Mailto Elements

        public IWebElement NoMailToResults { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'There are no recently used accounts to display')]")); } }

        public IWebElement HeaderMostRecentMailingAdd { get { return WebDriver.GetElement(By.XPath("//h3[contains(text(),'Most recently used mailing address')]")); } }

        public IWebElement SearchMailToBy { get { return WebDriver.GetElement(By.Id("search-by-selection")); } }

        public IWebElement SearchByOptions { get { return WebDriver.GetElement(By.Id("search-by-text")); } }

        public IWebElement SearchIcon { get { return WebDriver.GetElement(By.XPath("//div[@class='search-input form-row-bottom-line']/div/i")); } }

        public IWebElement LnkClearSearch { get { return WebDriver.GetElement(By.XPath("//div[@class='search-by-line dds__mb-3']//div[3]")); } }

        public IWebElement BtnUseAsMailTo { get { return WebDriver.GetElement(By.XPath("//button[contains(text(),'Use as Mail To Customer')]")); } }

        public IWebElement TxtUseBillingAsMailTo { get { return WebDriver.GetElement(By.XPath("//h4[contains(text(),'Use billing address as mailing address')]")); } }

        public IWebElement HeaderMailTo { get { return WebDriver.GetElement(By.XPath("//h3[contains(text(),'Mail To')]")); } }

        public IWebElement HeaderSearchMailingAdd { get { return WebDriver.GetElement(By.XPath("//h3[contains(text(),'Search mailing address')]")); } }

        public IWebElement LnkContinueWithMailTo { get { return WebDriver.GetElement(By.XPath("//b[contains(text(),'Continue with this Mail To')]")); } }

        public IWebElement HeaderCompName { get { return WebDriver.GetElement(By.XPath("//th[contains(text(),'Company Name')]")); } }

        public IWebElement HeaderCompAddress { get { return WebDriver.GetElement(By.XPath("//th[contains(text(),'Company Address')]")); } }

        public IWebElement HeaderCustNumber { get { return WebDriver.GetElement(By.XPath("//th[contains(text(),'Customer Number')]")); } }

        public IWebElement MailToExpandResult { get { return WebDriver.GetElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/i[1]")); } }

        public IWebElement MailToContactFilter { get { return WebDriver.GetElement(By.XPath("(.//div[@class='search-input form-row-bottom-line']//i[contains(@class,'dsa-search-icon')])[1]")); } }

        public IWebElement MailToSearchIcon { get { return WebDriver.GetElement(By.XPath("(.//div[@class='search-input form-row-bottom-line']//i[contains(@class,'dsa-search-icon')])[2]")); } }

        public IWebElement ExpandClearSearch { get { return WebDriver.GetElement(By.XPath("(.//div[@class='search-input form-row-bottom-line']//following-sibling::div//a[contains(text(),'Clear search')])[2]")); } }

        public IWebElement HeaderContactName { get { return WebDriver.GetElement(By.XPath("//div/mat-table/mat-header-row/mat-header-cell[contains(text(), 'Contact Name')]")); } }

        public IWebElement HeaderPhoneNumber { get { return WebDriver.GetElement(By.XPath("//div/mat-table/mat-header-row/mat-header-cell[contains(text(), 'Phone Number')]")); } }

        public IWebElement HeaderEmailAddress { get { return WebDriver.GetElement(By.XPath("//div/mat-table/mat-header-row/mat-header-cell[contains(text(), 'Email Address')]")); } }

        public IWebElement SelectResult { get { return WebDriver.GetElement(By.Id("select_button")); } }

        public IWebElement SelectContactMessage { get { return WebDriver.GetElement(By.XPath("//div[contains(text(), 'Select a contact that you want to receive the invoice')]")); } }



        #endregion


    }

}

