using System;
using System.Linq;
using System.Collections.Generic;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using FluentAssertions;

namespace Dsa.Pages.Solutions.ManageAccounts
{
    public class EndUserPage : DsaPageBase
    {


        public EndUserPage(IWebDriver webDriver)
                : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);

        }

        public int FindResults()
        {
            IWebElement table = WebDriver.FindElement(By.XPath("//mat-table[@class='mat-table cdk-table dsa-table']"));
            ReadOnlyCollection<IWebElement> listOfRows = table.FindElements(By.TagName("mat-row"));

            return listOfRows.Count();
        }


        public EndUserPage SearchByCompanyNameAndAddress(string companyName, string Address)
        {                     
            EndUserCompanyName.SetText(WebDriver, companyName);          
            EndUserAddress.SetText(WebDriver, Address);
            
            return new EndUserPage(WebDriver);
        }

        public EndUserPage SearchByCompanyNameAndZipCode(string companyName, string Zipcode)
        {           
            EndUserCompanyName.SetText(WebDriver, companyName);           
            EndUserZipCode.SetText(WebDriver, Zipcode);
            return new EndUserPage(WebDriver);
        }

        public EndUserPage SearchByAllCombinations(string CompanyName, string Zipcode, string City, string State, string Address, string CustomerType)
        {           
            EndUserCompanyName.SetText(WebDriver, CompanyName);            
            EndUserZipCode.SetText(WebDriver, Zipcode);           
            EndUserCity.SetText(WebDriver, City);
            EndUserState.PickDropdownByText(WebDriver, State);
            EndUserAddress.SetText(WebDriver, Address);
            if (EndUserCustomerType.Equals("Medium Business"))
            {
                //Do nothing
            }
            else
            {
                EndUserCustomerType.PickDropdownByText(WebDriver, CustomerType);
            }
            return new EndUserPage(WebDriver);

        }

        public EndUserPage SearchByAllCombinationsUS(string CompanyName, string Zipcode, string City, string State, string Address)
        {
            
            EndUserCompanyName.SetText(WebDriver, CompanyName);         
            EndUserZipCode.SetText(WebDriver, Zipcode);
            EndUserCity.SetText(WebDriver, City);
            EndUserState.PickDropdownByText(WebDriver, State);         
            EndUserAddress.SetText(WebDriver, Address);
   
            return new EndUserPage(WebDriver);
        }

        public EndUserPage RefineURSearchByAllCombinations(string CompanyName, string Zipcode, string City, string State, string Address, string CustomerType)
        {
            
            EndUserCompanyName.SetText(WebDriver, CompanyName);           
            EndUserZipCode.SetText(WebDriver, Zipcode);
            EndUserCity.SetText(WebDriver, City);
            EndUserState.PickDropdownByText(WebDriver, State);
            EndUserAddress.SetText(WebDriver, Address);
            if (EndUserCustomerType.Equals("Medium Business"))
            {
                //Do nothing
            }
            else
            {
                EndUserCustomerType.PickDropdownByText(WebDriver, CustomerType);
            }
            return new EndUserPage(WebDriver);

        }

        public EndUserPage RefineURSearchByAllCombinationsAU(string CompanyName, string CustomerTypeLarge)
        {
            EndUserCompanyName.SetText(WebDriver, CompanyName);
            if (EndUserCustomerType.Equals("Large Business"))
            {
                //Do nothing
            }
            else
            {
                EndUserCustomerType.PickDropdownByText(WebDriver, CustomerTypeLarge);
            }
            return new EndUserPage(WebDriver);

        }

        public EndUserPage RefineURSearchByAllCombinationsUK(string CompanyName, string City, string CustomerTypeLarge)
        {
            EndUserCompanyName.SetText(WebDriver, CompanyName);
            EndUserCity.SetText(WebDriver, City);
            EndUserState.PickDropdownByText(WebDriver, "Select State");
            if (EndUserCustomerType.Equals("Large Business"))
            {
                //Do nothing
            }
            else
            {
                EndUserCustomerType.PickDropdownByText(WebDriver, CustomerTypeLarge);
            }
            return new EndUserPage(WebDriver);

        }


        public EndUserPage SearchByCompanyName(string CompanyName)
        {            
            EndUserCompanyName.SetText(WebDriver, CompanyName);
            
            return new EndUserPage(WebDriver);
        }

        public EndUserPage GetAllOptionsFromDropDown(IWebElement element, int count)
        {
            SelectElement select = new SelectElement(element);
            IList<IWebElement> list = select.Options;
            var total = list.Count;
            if (total.Equals(count))
            {
                foreach (var item in list)
                {
                    Logger.Write(item.GetText(WebDriver));
                }

            }
            return new EndUserPage(WebDriver);
        }

        public EndUserPage SearchByCompanyNameCountryCityAndCustomerType(string CompanyName, string City, string MediumBusiness)
        {         
            EndUserCompanyName.SetText(WebDriver, CompanyName);           
            EndUserCity.SetText(WebDriver, City);
            EndUserCustomerType.GetText(WebDriver);
            EndUserCustomerType.PickDropdownByText(WebDriver, MediumBusiness);
                      
            return new EndUserPage(WebDriver);
        }

        public EndUserPage SearchByCityAndAddress(string City, string Address)
        {           
            EndUserCity.SetText(WebDriver, City);           
            EndUserAddress.SetText(WebDriver, Address);
            return new EndUserPage(WebDriver);
        }

        public EndUserPage SearchByCompanyNameCityAndZipcode(string CompanyName, string City, string Zipcode)
        {           
            EndUserCompanyName.SetText(WebDriver, CompanyName);
            EndUserCity.SetText(WebDriver, City);
            EndUserZipCode.SetText(WebDriver, Zipcode);
            FindEndUser.Enabled.Should().BeTrue();
            FindEndUser.Click(WebDriver);

            return new EndUserPage(WebDriver);
        }

        public EndUserPage SearchByState(string CompanyName)
        {
            EndUserCompanyName.SetText(WebDriver, CompanyName);

            return new EndUserPage(WebDriver);
        }


        public EndUserPage SearchByCompanyNameCityAndAddress(string companyName, string City, string Address)
        {           
            EndUserCompanyName.SetText(WebDriver, companyName);
            EndUserCity.SetText(WebDriver, City);
            EndUserAddress.SetText(WebDriver, Address);
            FindEndUser.Enabled.Should().BeTrue();
            FindEndUser.Click(WebDriver);

            return new EndUserPage(WebDriver);
        }

        public EndUserPage SearchByCompanyNameAndCity(string companyName, string City)
        {
            EndUserCompanyName.SetText(WebDriver, companyName);
            EndUserCity.SetText(WebDriver, City);

            return new EndUserPage(WebDriver);
        }

        public EndUserPage EndUserResults(string companyName, string City)
        {
            EndUserCompanyName.SetText(WebDriver, companyName);
            EndUserCity.SetText(WebDriver, City);
            FindEndUser.Enabled.Should().BeTrue();
            FindEndUser.Click(WebDriver);

            return new EndUserPage(WebDriver);
        }

        public void delay(int timeInSeconds)
        {
            Thread.Sleep(timeInSeconds * 1000);
        }

        public void WaitForElementLoadAndSwitchFrame()
        {
            DsaUtil.WaitForPageLoad(WebDriver);
            Thread.Sleep(5000);
            WebDriver.SwitchTo().Frame(1);
        }

        public SoldToPage SelectEndUserAPJ(String CompanyName)
        {
            WaitForElementLoadAndSwitchFrame();
            if (FindResults() >= 1)
            {
                EURowOneSelectButton.Click(WebDriver);
                delay(10);
            }
            else
            {
                EndUserSearchTab.Click(WebDriver);
                SearchByCompanyName(CompanyName);
                new EndUserResultsPage(WebDriver).EURowOneSelectButton.Click(WebDriver);
                WebDriver.VerifyBusyOverlayNotDisplayed();
            }
            return new SoldToPage(WebDriver);
        }

        public SoldToPage SelectEndUserAMEREMEA(String CompanyName, String City)
        {
            WaitForElementLoadAndSwitchFrame();
            if (FindResults() >= 1)
            {
                EURowOneSelectButton.Click(WebDriver);
                delay(10);
            }
            else
            {
                EndUserSearchTab.Click(WebDriver);
                SearchByCompanyNameAndCity(CompanyName, City);
                new EndUserResultsPage(WebDriver).EURowOneSelectButton.Click(WebDriver);
                WebDriver.VerifyBusyOverlayNotDisplayed();
            }
            return new SoldToPage(WebDriver);
        }

        #region Elements

        public IWebElement EndUserCompanyName { get { return WebDriver.GetElement(By.Id("companyNameInput-validation")); } }

        public IWebElement ResellerLabelOnEndUserpage { get { return WebDriver.GetElement(By.XPath("//div[@id='return-Reseller-data']//app-customer[2]//div[2]")); } }

        public IWebElement EndUserSession { get { return WebDriver.GetElement(By.XPath("//h5[contains(text(),'End User')]")); } }

        public IWebElement ChangeEndUserSearch { get { return WebDriver.GetElement(By.XPath("//button[@id='ChangeButton-']")); } }

        public IWebElement EndUserSearchLabel { get { return WebDriver.GetElement(By.XPath("//h2[@class='dds__mb-sm-3']")); } }

        public IWebElement EndUserCompanyNameLabel { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Company Name')]")); } }

        public IWebElement EndUserCity { get { return WebDriver.GetElement(By.Id("cityInput-validation")); } }

        public IWebElement EndUserCityLabel { get { return WebDriver.GetElement(By.XPath(" //label[contains(text(),'City')]")); } }

        public IWebElement FindEndUser { get { return WebDriver.GetElement(By.XPath("//*[@id='end-user-search-button'] ")); } }

        public IWebElement RefineFindEndUSer { get { return WebDriver.GetElement(By.XPath("//*[@id='end-user-search-button']")); } }

        public IWebElement EndUserCountry { get { return WebDriver.GetElement(By.XPath("//*[@id='countryInput-validation']")); } }

        public IWebElement EndUsercountryLabel { get { return WebDriver.GetElement(By.XPath(" //label[contains(text(),'Country')]")); } }

        public IWebElement EndUserSelectacountry { get { return WebDriver.GetElement(By.XPath("//option[contains(text(),'Select a country')]")); } }

        public IWebElement EndUserAddress { get { return WebDriver.GetElement(By.Id("addressInput-validation")); } }

        public IWebElement EndUserAddressLabel { get { return WebDriver.GetElement(By.XPath(" //label[contains(text(),'Address')]")); } }

        public IWebElement EndUserState { get { return WebDriver.GetElement(By.XPath("//select[@id='stateInput-validation']")); } }

        public IWebElement EndUserStateLabel { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'State')]")); } }

        public IWebElement EndUserZipCode { get { return WebDriver.GetElement(By.Id("zipCodeInput-validation")); } }

        public IWebElement EndUserZipcodeLabel { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Zip Code')]")); } }

        public IWebElement EndUserCustomerType { get { return WebDriver.GetElement(By.Id("customerTypeInput-validation")); } }

        public IWebElement EndUserCustomerTypeLabel { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Customer Type')]")); } }

        public IWebElement AlertInfoCircle { get { return WebDriver.GetElement(By.XPath("//span[@class='dds__alert-info-cir']")); } }

        public IWebElement MsgCustTypeSelection { get { return WebDriver.GetElement(By.XPath("//span[contains(@class,'tooltiptext')]")); } }

        public IWebElement EUchangingCustomerTypeAlertMsg { get { return WebDriver.GetElement(By.XPath("//p[@class='dds__alert-body']")); } }

        public IWebElement EndUserCustomerResult { get { return WebDriver.GetElement(By.XPath("")); } }

        public IWebElement EndUserRowOneResult { get { return WebDriver.GetElement(By.XPath("//*[@id='dsa-table-row']/mat-cell[2]")); } }

        public IWebElement EUFavoritesTab { get { return WebDriver.GetElement(By.Id("favorites-tab")); } }

        public IWebElement EndUserSearchTab { get { return WebDriver.GetElement(By.Id("customers-tab")); } }

        public IWebElement EURowOneSelectButton { get { return WebDriver.GetElement(By.XPath("//mat-row[1]//mat-cell[3]//button[1]")); } }

        public IWebElement DCNSearchInputBox { get { return WebDriver.GetElement(By.Id("customerNumberInput-validation")); } }

        public IWebElement EUSearchTab { get { return WebDriver.GetElement(By.Id("customers-tab")); } }

        public IWebElement HeaderCompNameFav { get { return WebDriver.GetElement(By.XPath("//mat-header-cell[contains(text(),'Company Name')]")); } }

        public IWebElement HeaderCompAddFav { get { return WebDriver.GetElement(By.XPath("//mat-header-cell[contains(text(),'Company Address')]")); } }

        public IWebElement DCNSearchMessage { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Please enter only the last 4 digits')]")); } }

        public IWebElement MsgNoFavoritesFound { get { return WebDriver.GetElement(By.XPath("//*[@id='favorites']/div/favorites-tab/div/div/div/div")); } }

        #endregion
    }

}
