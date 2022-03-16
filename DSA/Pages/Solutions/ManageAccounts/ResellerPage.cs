using System.Linq;
using System.Collections.Generic;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;
using Dsa.Workflows;
using System.Threading;

namespace Dsa.Pages.Solutions.ManageAccounts
{
    public partial class ResellerPage : DsaPageBase
    {
        public ResellerPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        public List<Dictionary<string, object>> GetResellerResultList()
        {
            return GridResellerResultList.GetGridData(WebDriver);
        }

        public IWebElement GetSelectButtonFromResellerResults(int index)
        {
            ReadOnlyCollection<IWebElement> selectButtons =
            WebDriver.FindElements(By.XPath("//button[contains(text(), 'Select')]"));
            return selectButtons.ElementAt(index);
        }
        public List<Dictionary<string, object>> GetResellerResultsPage()
        {
            // GridResellerResultList.WaitForElement(WebDriver);
            return GridResellerResultList.GetTableDataMAReseller(WebDriver);
        }

        public int ResellerFindResults()
        {
            IWebElement table = WebDriver.FindElement(By.XPath("//mat-table[@class='dsa-table mat-table']"));
            ReadOnlyCollection<IWebElement> listOfRows = table.FindElements(By.TagName("mat-row"));

            return listOfRows.Count();
        }


        public ResellerPage SearchByCompNameAndPartnerTrack(string ResellerCompName, string PartnerTrack)
        {
            
            ResellerCompanyName.SetText(WebDriver, ResellerCompName);
            ResellerPartnerTrack.PickDropdownByText(WebDriver, PartnerTrack);

            return new ResellerPage(WebDriver);
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

        public bool getValidationErrorMessage()
        {
            try
            {

                return NoRecordsErrorMsg.Displayed;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
        }


        public string[] getTitles()
        {
            SelectElement el = new SelectElement(ResellerExcepReason);
            string[] actualTitles = new string[el.Options.Count - 1];
            for (int i = 1; i <= actualTitles.Length; i++)
            {
                actualTitles[i - 1] = el.Options.ElementAt(i).Text.Trim();
            }
            return actualTitles;
        }


        #region Reseller Elements

        public IWebElement RadioBtnResellerNotApplicable { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Reseller is not applicable')]/preceding-sibling::input[@formcontrolname='selectionOption']")); } }

        public IWebElement ResellerExcepReason { get { return WebDriver.GetElement(By.Id("resller-exception-reason")); } }

        public IWebElement ResellerExceptionMessage { get { return WebDriver.GetElement(By.XPath("//div[@class='dds__error-body']")); } }

        public IWebElement ResellerExcConfirmBtn { get { return WebDriver.GetElement(By.Id("reseller-exception-confirm-button")); } }

        public IWebElement ResellerCompanyNameLabel { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Company Name')]")); } }


        public IWebElement ResellerCompanyName { get { return WebDriver.GetElement(By.XPath("//*[@id='companyNameInput-validation']")); } }


        public IWebElement ResellerCountryLabel { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Country')]")); } }


        public IWebElement ResellerCountry { get { return WebDriver.GetElement(By.XPath("//select[@id='countryInput-validation']")); } }


        public IWebElement ResellerPartnerTrackLabel { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Partner Track')]")); } }


        public IWebElement ResellerPartnerTrack { get { return WebDriver.GetElement(By.XPath("//*[@id='partnerTrackInput-validation']")); } }


        public IWebElement FindReseller { get { return WebDriver.GetElement(By.XPath("//*[@id='allcustomers']/div/customers-tab/reseller-search/form/div/div/button")); } }

        
        public IWebElement TabFindReseller { get { return WebDriver.GetElement(By.Id("customers-tab")); } }


        public IWebElement RefineYourSearch { get { return WebDriver.GetElement(By.XPath("//legend[@class='dds__mb-4']")); } }


        public IWebElement BillToChangeButton { get { return WebDriver.GetElement(By.XPath("//div[@id='return-Reseller-data']//button[@id='ChangeButton-']")); } }


        public IWebElement BillToLHSdetails { get { return WebDriver.GetElement(By.XPath("//div[@id='return-Reseller-data']/app-customer[1]/div[1]/section[1]/div[1]/div[2]")); } }


        public IWebElement CompanySearchRequired { get { return WebDriver.GetElement(By.XPath("//div[@class='form-header dds__mb-3']")); } }


        public IWebElement ResellerRefineYourSearch { get { return WebDriver.GetElement(By.XPath("//button[contains(text(),'refine your search')]")); } }


        public IWebElement CompanyNameHeader { get { return WebDriver.GetElement(By.XPath("//mat-header-cell[@class='mat-header-cell cdk-column-companyName mat-column-companyName']")); } }


        public IWebElement ResellersearchResluts { get { return WebDriver.GetElement(By.XPath("//*[@id='ma-customer-selection']/div[2]/div/dsa-ma-reseller/reseller-search-result/div[1]")); } }


        public IWebElement ResellerSearchResultCount { get { return WebDriver.GetElement(By.XPath("//*[@id='ma-customer-selection']/div[2]/div/dsa-ma-reseller/reseller-search-result/div[1]/span[1]")); } }


        public IWebElement ResellerSearchResultComanyName { get { return WebDriver.GetElement(By.XPath("//*[@id='ma-customer-selection']/div[2]/div/dsa-ma-reseller/reseller-search-result/div[1]/span[2]")); } }


        public IWebElement ResellerSearchResultCountry { get { return WebDriver.GetElement(By.XPath("//*[@id='ma-customer-selection']/div[2]/div/dsa-ma-reseller/reseller-search-result/div[1]/span[3]")); } }


        public IWebElement ResellerSearchResultPartnertrack { get { return WebDriver.GetElement(By.XPath("//*[@id='ma-customer-selection']/div[2]/div/dsa-ma-reseller/reseller-search-result/div[1]/span[4]")); } }


        public IWebElement GridResellerResultList { get { return WebDriver.GetElement(By.XPath("//*[@id='ma-customer-selection']/div[2]/div/dsa-ma-reseller/reseller-search-result/div[2]")); } }


        public IWebElement ResellerSelectRowOne { get { return WebDriver.GetElement(By.XPath("//mat-row[1]//mat-cell[2]//button[1]")); } }


        public IWebElement ResellerRowoneInfo { get { return WebDriver.GetElement(By.XPath(" //body//mat-row[1]")); } }


        public IWebElement PatchedResellerInfo { get { return WebDriver.GetElement(By.XPath("//app-customer[2]//div[1]//section[1]")); } }


        public IWebElement ResellerCompName { get { return WebDriver.GetElement(By.Id("CompanyName-6")); } }


        public IWebElement ResellerAddressLine1 { get { return WebDriver.GetElement(By.Id("AddressLine1-6")); } }


        public IWebElement ResellerAddressLine2 { get { return WebDriver.GetElement(By.Id("Address-6")); } }


        public IWebElement ShipTo { get { return WebDriver.GetElement(By.XPath("//h2[contains(text(),'Ship To')]")); } }

        public IWebElement NoRecordsErrorMsg { get { return WebDriver.GetElement(By.XPath("//div[@class='dds__error-body']")); } }

        public void delay(int timeInSeconds)
        {
            Thread.Sleep(timeInSeconds * 1000);
        }


        #endregion

    }

}

