using System.Linq;
using System.Collections.Generic;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using Dsa.Workflows;

namespace Dsa.Pages.Solutions.ManageAccounts
{
    public partial class InstallAtPage : DsaPageBase
    {
        public InstallAtPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        public int InstallAtFindResults()
        {
            IWebElement table = WebDriver.FindElement(By.XPath("//*[@id='address-selection']/dsa-ma-ship-to-install-at/div/div/app-customize-table/div/div[1]/app-customer-selection-table/div/table"));
            ReadOnlyCollection<IWebElement> listOfRows = table.FindElements(By.TagName("tr"));

            return listOfRows.Count();
        }

        public List<Dictionary<string, object>> GetInstallAtResultsPage()
        {
        return GridInstallAtResultList.GetTableDataMAInstallAt(WebDriver);
        }


        public void WaitForElementLoadAndSwitchFrame()
        {
            DsaUtil.WaitForPageLoad(WebDriver);
            Thread.Sleep(5000);
            WebDriver.SwitchTo().Frame(1);
        }

        public bool GetElementDisplayedStatus(string selector)
        {
            IWebElement el = WebDriver.FindElement(By.Id(selector));
            return el.Displayed;
        }

        public void CreateNewInstallAtAddressAmer(IWebDriver driver, System.Data.DataRow row)
        {
            InputAddLine1.SetText(driver, row["Address"].ToString());
            InputZipCode.SetText(driver, row["Zipcode"].ToString());
            InputFirstName.SetText(driver, row["FirstNameValue"].ToString());
            InputLastName.SetText(driver, row["LastNameValue"].ToString());
            InputMobilePhone.SetText(driver, row["MobPhoneValue"].ToString());
            InputWorkPhone.SetText(driver, row["WorkPhoneValue"].ToString());
            InputInvoicingEmail.SetText(driver, row["EmailValue"].ToString());
            BtnAddAddress.Click();
        }

        public void delay(int timeInSeconds)
        {
            Thread.Sleep(timeInSeconds * 1000);
        }


        #region INstallAt Elements

public IWebElement GridInstallAtResultList { get { return WebDriver.GetElement(By.XPath("//*[@id='ma-customer-selection']/div[2]")); } }

public IWebElement InputSlnName { get { return WebDriver.GetElement(By.Id("cc-installat-box")); } }

public IWebElement InstallAtPageHeader { get { return WebDriver.GetElement(By.XPath("//h2[contains(text(),'Install At')]")); } }

public IWebElement LnkCreateNewInstallAtAdd { get { return WebDriver.GetElement(By.XPath("//button[contains(text(),'Create a new Install At address')]")); } }

public IWebElement LnkShipToChange { get { return WebDriver.GetElement(By.XPath("//div[@id='return-ShipTo-data']//button")); } }

public IWebElement PatchedShipToAddress { get { return WebDriver.GetElement(By.XPath("//div[@id='return-ShipTo-data']//div[@id='customerdetail-']/p[@id='addressLine1-']")); } }

public IWebElement PartInstallAtAddRadioButton { get { return WebDriver.GetElement(By.Id("radioBtnPartner")); } }

public IWebElement EndUserInstallAtAddRadioButton { get { return WebDriver.GetElement(By.Id("radioBtnEndUser")); } }

public IWebElement ResellerInstallAtAddRadioButton { get { return WebDriver.GetElement(By.Id("radioBtnReseller")); } }

public IWebElement InputAddLine1 { get { return WebDriver.GetElement(By.XPath("//input[@id='addressLine1']")); } }

public IWebElement InputCountry { get { return WebDriver.GetElement(By.XPath("//select[@id='country']")); } }

public IWebElement InputZipCode { get { return WebDriver.GetElement(By.XPath("//input[@id='postalCode']")); } }

public IWebElement InputFirstName { get { return WebDriver.GetElement(By.XPath("//input[@id='firstName']")); } }

public IWebElement InputLastName { get { return WebDriver.GetElement(By.XPath("//input[@id='lastName']")); } }

public IWebElement InputMobilePhone { get { return WebDriver.GetElement(By.XPath("//input[@id='mobilePhone']")); } }

public IWebElement InputWorkPhone { get { return WebDriver.GetElement(By.XPath("//input[@id='workPhone']")); } }

public IWebElement InputInvoicingEmail { get { return WebDriver.GetElement(By.XPath("//input[@id='invoicingEmail']")); } }

public IWebElement StateSelection { get { return WebDriver.GetElement(By.XPath("//select[@id='state']")); } }

public IWebElement InputCity { get { return WebDriver.GetElement(By.XPath("//input[@id='city']")); } }

public IWebElement ShowAddFields { get { return WebDriver.GetElement(By.XPath("//a[contains(text(),'Fields')]")); } }

public IWebElement HideAddFields { get { return WebDriver.GetElement(By.XPath("//a[contains(text(),'Fields')]")); } }

public IWebElement BtnAddAddress { get { return WebDriver.GetElement(By.Id("addAddress")); } }

public IWebElement BtnClearAddress { get { return WebDriver.GetElement(By.Id("clearAddress")); } }

public IWebElement BtnCancelAddress { get { return WebDriver.GetElement(By.Id("cancelAddress")); } }

public IWebElement MiddleInitial { get { return WebDriver.GetElement(By.XPath("//input[@id='middleInitial']")); } }

public IWebElement Department { get { return WebDriver.GetElement(By.XPath("//input[@id='department']")); } }

public IWebElement Fax { get { return WebDriver.GetElement(By.XPath("//input[@id='department']")); } }

public IWebElement TitleDropdown { get { return WebDriver.GetElement(By.XPath("//select[@id='title']")); } }

        public string[] getTitles() 
        {
            SelectElement el = new SelectElement(TitleDropdown);
            string[] actualTitles = new string[el.Options.Count-1];
            for (int i = 1; i <= actualTitles.Length ; i++)
            {
                actualTitles[i-1] = el.Options.ElementAt(i).Text.Trim();
            }
            return actualTitles;
        }

public IWebElement AVSSuggestionPopUp { get { return WebDriver.GetElement(By.XPath("//div[@id='avs-suggestion']")); } }

public IWebElement InstallAtSearchBy { get { return WebDriver.GetElement(By.XPath("//select[@id='addressOption']")); } }

public IWebElement SearchIcon { get { return WebDriver.GetElement(By.Id("filter-button")); } }

public IWebElement FilteringValue { get { return WebDriver.GetElement(By.Id("first-name-Input")); } }

public IWebElement MaxLengthMessage { get { return WebDriver.GetElement(By.Id("maxlength-error")); } }

public IWebElement MinLengthMessage { get { return WebDriver.GetElement(By.Id("length-error")); } }

public IWebElement BtnSelectConfirm { get { return WebDriver.GetElement(By.Id("SelectButton-1")); } }

public IWebElement HeaderCompName { get { return WebDriver.GetElement(By.Id("column-Company Name")); } }

public IWebElement HeaderCompAddress { get { return WebDriver.GetElement(By.Id("column-Company Address")); } }

public IWebElement HeaderContactName { get { return WebDriver.GetElement(By.Id("column-Contact Name")); } }

public IWebElement HeaderPhoneNumber { get { return WebDriver.GetElement(By.Id("column-Phone Number")); } }

public IWebElement HeaderEmailAddress { get { return WebDriver.GetElement(By.Id("column-Email Address")); } }

public IWebElement ErrorContactName { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Contact Name is required')]")); } }

public IWebElement ErrorEmailAddress { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Email Address is required')]")); } }

public IWebElement OSCPageHeader { get { return WebDriver.GetElement(By.XPath("//h2[contains(text(),'Solutions Configurator')]")); } }

public IWebElement ErrorMessage { get { return WebDriver.GetElement(By.Id("error")); } }


        #endregion

    }


}
