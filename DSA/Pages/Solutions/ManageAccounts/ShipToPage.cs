using System.Linq;
using System.Collections.Generic;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;
using System.Threading;
using Dsa.Workflows;
using System.Data;
using System;

namespace Dsa.Pages.Solutions.ManageAccounts
{
    public partial class ShipToPage : DsaPageBase
    {
        public ShipToPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }


        public int ShipToFindResults()
        {
            IWebElement table = WebDriver.FindElement(By.XPath("//*[@id='favorites']/div/app-favorites-tab/div[2]/div/div/table/tbody"));
            ReadOnlyCollection<IWebElement> listOfRows = table.FindElements(By.TagName("tr"));
            //*[@id="favorites"]/div/app-favorites-tab/div[2]/div/div/table/tbody

            return listOfRows.Count();
        }

        public int ShipToContactResults()
        {
            IWebElement table = WebDriver.FindElement(By.XPath("//*[@id='favorites']/div/app-favorites-tab/div[2]/div/div/table/tbody/tr[2]/td/div/div/div/div[3]/mat-table"));
            ReadOnlyCollection<IWebElement> listOfRows = table.FindElements(By.TagName("mat-row"));
            
            return listOfRows.Count();
        }

        public List<Dictionary<string, object>> GetShipToContactResultsPage()
        {
            return GridShipToContactList.GetTableDataShipToContacts(WebDriver);
        }


        public List<Dictionary<string, object>> GetShipToResultsPage()
        {
            return GridShipToResultList.GetTableDataMAShipTo(WebDriver);
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

        public void CreateNewShipToAddressAmer(IWebDriver driver, DataRow row)
        {
            InputAddLine1.SetText(driver, row["Address"].ToString());
            InputZipCode.SetText(driver, row["Zipcode"].ToString());
            InputFirstName.SetText(driver, row["FirstNameValue"].ToString());
            InputLastName.SetText(driver, row["LastNameValue"].ToString());
            InputMobilePhone.SetText(driver, row["MobPhoneValue"].ToString());
            InputWorkPhone.SetText(driver, row["WorkPhoneValue"].ToString());
            InputInvocingEmail.SetText(driver, row["EmailValue"].ToString());
            BtnAddAddress.Click();
        }


        public void CreateNewShipToAddressAmerFavorite(IWebDriver driver, DataRow row)
        {            
            InputZipCode.SetText(driver, row["Zipcode"].ToString());
            InputFirstName.SetText(driver, row["FirstNameValue"].ToString());
            InputLastName.SetText(driver, row["LastNameValue"].ToString());
            InputMobilePhone.SetText(driver, row["MobPhoneValue"].ToString());
            InputWorkPhone.SetText(driver, row["WorkPhoneValue"].ToString());
            InputInvocingEmail.SetText(driver, row["EmailValue"].ToString());
            CheckBoxSetAddressAsFavorite.Click();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            BtnAddAddress.Click();
            delay(15);
            if (AVSSuggestionPopUp.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5)))
            {
                BtnUseOriginalAddress.Click();
                delay(10);
            }
            else
            {
                //do nothing;
            }

        }

        public void CreateContactWithFav(IWebDriver driver, DataRow row)
        {
            ContactNameInput.SetText(driver, row["FNameLastName"].ToString());
            AreaCodeInput.PickDropdownByIndex(WebDriver, 1);
            PhoneNumberInput.SetText(driver, row["WorkPhoneValue"].ToString());
            EmailInput.SetText(driver, row["EmailValue"].ToString());
            SetFavorite.Click(WebDriver);
            BtnSelect.Click(WebDriver);
        }

        public void delay(int timeInSeconds)
        {
            Thread.Sleep(timeInSeconds*1000);
        }

        #region Ship To Elements

public IWebElement LnkShipTo { get { return WebDriver.GetElement(By.XPath("//h5[contains(text(),'Ship To')]")); } }

public IWebElement ShipToFavoritesTab { get { return WebDriver.GetElement(By.XPath("//button[@id='favorites-tab']")); } }

public IWebElement BillToChangeButtonDisti { get { return WebDriver.GetElement(By.XPath("//div[@id='return-Reseller-data']//button[@id='ChangeButton-']")); } }
      
public IWebElement BillToChangeButtonNonDisti { get { return WebDriver.GetElement(By.XPath(" //div[@id='return-BillTo-data']//button[@id='ChangeButton-']")); } }

public IWebElement HeaderShipTo { get { return WebDriver.GetElement(By.XPath("//h2[contains(text(),'Ship To')]")); } }

public IWebElement DistiShippingAddRadioButton { get { return WebDriver.GetElement(By.Id("radioBtnPartner")); } }

public IWebElement SaveAndReturnSol { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Save and return to solution')]")); } }

public IWebElement SolutionName { get { return WebDriver.GetElement(By.XPath(" //span[@id='solution-name']")); } }

public IWebElement GridShipToResultList { get { return WebDriver.GetElement(By.XPath("//*[@id='ma-customer-selection']/div[2]")); } }

public IWebElement GridShipToContactList { get { return WebDriver.GetElement(By.XPath("//mat-table[@class='mat-table cdk-table inner-tableXXX dsa__mb-20px ng-tns-c101-4']")); } }
      
public IWebElement ShipToSearchBy { get { return WebDriver.GetElement(By.XPath("//select[@id='addressOption']")); } }

public IWebElement SearchIcon { get { return WebDriver.GetElement(By.Id("filter-button")); } }

public IWebElement FilteringValue { get { return WebDriver.GetElement(By.Id("first-name-Input")); } }

public IWebElement LnkCreateNewShipTo { get { return WebDriver.GetElement(By.XPath("//button[contains(text(),'Create a new Ship To address')]")); } }

public IWebElement InputAddLine1 { get { return WebDriver.GetElement(By.XPath("//input[@id='addressLine1']")); } }

public IWebElement InputZipCode { get { return WebDriver.GetElement(By.XPath("//input[@id='postalCode']")); } }

public IWebElement InputFirstName { get { return WebDriver.GetElement(By.XPath("//input[@id='firstName']")); } }

public IWebElement InputLastName { get { return WebDriver.GetElement(By.XPath("//input[@id='lastName']")); } }

public IWebElement InputMobilePhone { get { return WebDriver.GetElement(By.XPath("//input[@id='mobilePhone']")); } }

public IWebElement InputWorkPhone { get { return WebDriver.GetElement(By.XPath("//input[@id='workPhone']")); } }

public IWebElement InputInvocingEmail { get { return WebDriver.GetElement(By.XPath("//input[@id='invoicingEmail']")); } }

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

public IWebElement EndUserShipAddRadioButton { get { return WebDriver.GetElement(By.Id("radioBtnEndUser")); } }

public IWebElement ResellerShipAddRadioButton { get { return WebDriver.GetElement(By.Id("radioBtnReseller")); } }

public IWebElement AVSSuggestionPopUp { get { return WebDriver.GetElement(By.XPath("//div[@id='avs-suggestion']")); } }

public IWebElement BtnSelect { get { return WebDriver.GetElement(By.XPath("//button[@id='SelectButton-1']")); } }

public IWebElement ResNotApplicable { get { return WebDriver.GetElement(By.Id("notApplicable-Reseller")); } }

public IWebElement ResExcSelection { get { return WebDriver.GetElement(By.Id("resellerNA-Reason")); } }

public IWebElement LnkShipToChange { get { return WebDriver.GetElement(By.XPath("//div[@id='return-ShipTo-data']//button")); } }

public IWebElement LnkResellerChange { get { return WebDriver.GetElement(By.XPath("//div[@id='return-Reseller-data']//button")); } }

public IWebElement MinLengthMessage { get { return WebDriver.GetElement(By.Id("length-error")); } }

public IWebElement AllCustomerTab { get { return WebDriver.GetElement(By.XPath("//button[@id='customers-tab']")); } }

public IWebElement ExpandCollapseFavAddress { get { return WebDriver.GetElement(By.XPath("//*[@id='favorites']/div/app-favorites-tab/div[2]/div/div/table/tbody/tr[1]/td[1]/div/i")); } }

public IWebElement SelectContactNotification { get { return WebDriver.GetElement(By.XPath("//*[@id='favorites']/div/app-favorites-tab/div[2]/div/div/table/tbody/tr[2]/td/div/div/div/div[1]/div/div")); } }

public IWebElement LnkShowAllContacts { get { return WebDriver.GetElement(By.XPath("//a[contains(text(),'Show All Contacts')]")); } }

public IWebElement ContactSelectionNotif { get { return WebDriver.GetElement(By.XPath("//*[@id='favorites']/div/app-favorites-tab/div[2]/div/div/table/tbody/tr[2]/td/div/div/div/div[1]/div/div")); } }

public IWebElement HeaderContactName { get { return WebDriver.GetElement(By.XPath("//mat-header-cell[contains(text(),'Contact Name')]")); } }

public IWebElement HeaderPhoneNumber { get { return WebDriver.GetElement(By.XPath("//mat-header-cell[contains(text(),'Phone Number')]")); } }

public IWebElement HeaderEmailAddress { get { return WebDriver.GetElement(By.XPath("//mat-header-cell[contains(text(),'Email Address')]")); } }

public IWebElement RemoveFavPopup { get { return WebDriver.GetElement(By.XPath("//*[@id='exampleModal']/div/div")); } }

public IWebElement RemoveFav { get { return WebDriver.GetElement(By.XPath("//*[@id='favorites']/div/app-favorites-tab/div[2]/div/div/table/tbody/tr[1]/td[2]/div/div")); } }

public IWebElement CancelRemFavPopup { get { return WebDriver.GetElement(By.XPath("//*[@id='exampleModal']/div/div/div[3]/button[1]")); } }

public IWebElement CheckBoxSetAddressAsFavorite { get { return WebDriver.GetElement(By.Id("checkboxName")); } }

public IWebElement SetAddressAsFavoriteMessage { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Set as favorite shipping address')]")); } }

public IWebElement ContactNameInput { get { return WebDriver.GetElement(By.Id("txtContact")); } }

public IWebElement AreaCodeInput { get { return WebDriver.GetElement(By.XPath("//*[@id='Row-ColumnName-1-PhoneNumber']/div[1]/select")); } }

public IWebElement PhoneNumberInput { get { return WebDriver.GetElement(By.Id("txtPhoneNumber")); } }

public IWebElement EmailInput { get { return WebDriver.GetElement(By.Id("txtEmail")); } }

public IWebElement SetFavorite { get { return WebDriver.GetElement(By.XPath("//*[@id='Span-Row-ColumnName-1-isFavorite']/div")); } }

public IWebElement BtnUseOriginalAddress { get { return WebDriver.GetElement(By.Id("btnUseOriginalAddress")); } }


public IWebElement AddressSetAsFavorite { get { return WebDriver.GetElement(By.Id("Span-Row-ColumnName--isFavorite")); } }


        #endregion

    }

}
