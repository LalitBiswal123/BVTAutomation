using System.Linq;
using System.Collections.Generic;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;
using System.Threading;
using FluentAssertions;
using Dsa.Workflows;

namespace Dsa.Pages.Solutions.ManageAccounts
{
    public partial class SoldToPage : DsaPageBase
    {
        public SoldToPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        public int SoldToFindResults()
        {
            IWebElement table = WebDriver.FindElement(By.XPath("//*[@id='allcustomers']/div/customers-tab/div[2]/div[3]/div[4]/div/table/tbody"));
            ReadOnlyCollection<IWebElement> listOfRows = table.FindElements(By.TagName("tr"));

            return listOfRows.Count();
        }

        public int SoldToResultsFavorites()
        {
            IWebElement table = WebDriver.FindElement(By.XPath("//*[@id='favorites']/div/favorites-tab/div[2]/div/div/div/table/tbody"));
            ReadOnlyCollection<IWebElement> listOfRows = table.FindElements(By.TagName("tr"));

            return listOfRows.Count(); 
        }



        public List<Dictionary<string, object>> GetSoldToResultList()
        {
            return GridSoldToResultList.GetGridData(WebDriver);
        }

        public List<Dictionary<string, object>> GetSoldToResultsPage()
        {
            return GridSoldToResultList.GetTableDataMAShipTo(WebDriver);
        }


        #region Sold To Elements


        public IWebElement SoldToHeader { get { return WebDriver.GetElement(By.XPath("//h3[contains(text(),'Sold To')]")); } }

        public IWebElement FavoritesTab { get { return WebDriver.GetElement(By.Id("favorites-tab")); } }

        public IWebElement AllCustomersTab { get { return WebDriver.GetElement(By.Id("customers-tab")); } }

        public IWebElement SoldToDCNmessage { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'Enter the Dell Customer Number (DCN) for the Sold')]")); } }

        public IWebElement DCNlabel { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Dell Customer Number (DCN)')]")); } }

        public IWebElement InputDCN { get { return WebDriver.GetElement(By.XPath("//input[@id='dellCustomerNumber']")); } }

        public IWebElement SearchByDCN { get { return WebDriver.GetElement(By.XPath("//div[@class='search-sold-to form-row-bottom-line dds__mr-3']//i")); } }

        public IWebElement ClearDCNInput { get { return WebDriver.GetElement(By.XPath("//div[@class='dsa-dcn-search-row']//div//a[contains(text(),'Clear search')]")); } }

        public IWebElement TxtAdvSearch { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'If you don’t see your customer, use advanced search')]")); } }

        public IWebElement SearchBySelection { get { return WebDriver.GetElement(By.Id("search-by-selection")); } }

        public IWebElement SearchByTxt { get { return WebDriver.GetElement(By.Id("search-by-text")); } }

        public IWebElement SearchByAdvSearch { get { return WebDriver.GetElement(By.XPath("//div[@class='search-input form-row-bottom-line']//div//i")); } }

        public IWebElement ClearAdvSeachInput { get { return WebDriver.GetElement(By.XPath("//div[@class='search-by-line dds__mb-3']//div//a[contains(text(),'Clear search')]")); } }

        public IWebElement RecUsedAccHeader { get { return WebDriver.GetElement(By.XPath("//*[@id='allcustomers']/div/customers-tab/div[2]/div[3]/div[2]/h3")); } }

        public IWebElement NoSoldToAccountAdvSearch { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'There are no recently used accounts to display')]")); } }

        public IWebElement SoldToPane { get { return WebDriver.GetElement(By.XPath("//div[@id='return-SoldTo-data']//div[@id='customerdetail-']")); } }

        public IWebElement NoRecentAccounts { get { return WebDriver.GetElement(By.XPath("//body/app-root[1]/div[2]/div[2]/div[2]/div[1]/dsa-ma-sold-to[1]/div[1]/div[2]/div[2]/div[1]/div[1]/customers-tab[1]/div[1]/div[3]/div[3]/div[1]/div[1]/div[1]/div[1]")); } }
        
        public IWebElement SoldToExpandResult { get { return WebDriver.GetElement(By.XPath("//tr[1]//td[1]//div[1]//i[1]")); } }

        public IWebElement SearchBySoldToDCN { get { return WebDriver.GetElement(By.XPath("//*[@id='allcustomers']/div/customers-tab/div[2]/div[2]/dcn-search/form/div/div[1]/i")); } }

        public IWebElement ErrorInvalidDCNSearch { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'Sorry, we could')]")); } }

        public IWebElement SearchDCN { get { return WebDriver.GetElement(By.XPath("//body/app-root[1]/div[2]/div[2]/div[2]/div[1]/dsa-ma-sold-to[1]/div[1]/div[2]/div[2]/div[1]/div[1]/customers-tab[1]/div[1]/div[2]/dcn-search[1]/form[1]/div[1]/div[1]/i[1]")); } }
                                                                                  
        public IWebElement AdvanceSearchResults { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'If you don’t see your customer, use advanced search')]")); } }

        public IWebElement FilterByAdvSearch { get { return WebDriver.GetElement(By.XPath("//select[@id='search-by-selection']")); } }
        
        public IWebElement SearchByText { get { return WebDriver.GetElement(By.XPath("//input[@id='search-by-text']")); } }

        public IWebElement ClearSearch { get { return WebDriver.GetElement(By.XPath("(.//div[@class='search-input form-row-bottom-line']//following-sibling::div//a[contains(text(),'Clear search')])[1]")); } }
                                                                                                              
        public IWebElement SoldToFilterSearch { get { return WebDriver.GetElement(By.XPath("(.//div[@class='search-input form-row-bottom-line']//i[contains(@class,'dsa-search-icon')])[1]")); } }

        public IWebElement SoldToExpandFilterSearch { get { return WebDriver.GetElement(By.XPath("(.//div[@class='search-input form-row-bottom-line']//i[contains(@class,'dsa-search-icon')])[2]")); } }

        public IWebElement ExpandClearSearch { get { return WebDriver.GetElement(By.XPath("(.//div[@class='search-input form-row-bottom-line']//following-sibling::div//a[contains(text(),'Clear search')])[2]")); } }

        public IWebElement SelectResult { get { return WebDriver.GetElement(By.XPath("//*[@id='select_button']")); } }

        public IWebElement AdvSearchResultsSoldTo { get { return WebDriver.GetElement(By.XPath("//table[@class='mat-elevation-z8 mat-table']//tbody")); } }

        public IWebElement CompanyNameResult { get { return WebDriver.GetElement(By.XPath("//tbody/tr[1]/td[3]")); } }

        public IWebElement CompanyAddressResult { get { return WebDriver.GetElement(By.XPath("//*[@id='allcustomers']/div/customers-tab[1]/div/div[3]/div[4]/div/table/tbody/tr[1]/td[4]")); } }

        public IWebElement SearchbyFnLN { get { return WebDriver.GetElement(By.XPath("//tbody/tr[2]/td[1]/div[1]/div[1]/div[1]/div[3]/div[1]/search-by[1]/form[1]/div[1]/div[1]/select[1]")); } }

        public IWebElement SearchbyFnLNTxt { get { return WebDriver.GetElement(By.XPath("//tbody/tr[2]/td[1]/div[1]/div[1]/div[1]/div[3]/div[1]/search-by[1]/form[1]/div[1]/div[2]/input[1]")); } }

        public IWebElement ResultofFnLNTxt { get { return WebDriver.GetElement(By.XPath("//*[@id='dsa-table-row']/mat-cell[2]")); } }

        public IWebElement NoResultFound { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'No contacts were found')]")); } }
        
        public IWebElement SelectResultFound { get { return WebDriver.GetElement(By.XPath("//tbody/tr[2]/td[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]")); } }

        public IWebElement GridSoldToResultList { get { return WebDriver.GetElement(By.XPath("//*[@id='ma-customer-selection']/div[2]/div/dsa-ma-bill-to/div/div")); } }

        public IWebElement ChangeLinkSoldTo { get { return WebDriver.GetElement(By.XPath("//div[@id='return-SoldTo-data']//button")); } }

        public IWebElement ContinueWithSoldTo { get { return WebDriver.GetElement(By.XPath("//div[@id='return-SoldTo-data']//p[11]")); } }

        public IWebElement HeaderCompName { get { return WebDriver.GetElement(By.XPath("//th[contains(text(),'Company Name')]")); } }

        public IWebElement HeaderCompAddress { get { return WebDriver.GetElement(By.XPath("//th[contains(text(),'Company Address')]")); } }

        public IWebElement HeaderCustNumber { get { return WebDriver.GetElement(By.XPath("//th[contains(text(),'Customer Number')]")); } }

        public IWebElement NoFavContactFound { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'No favorite contacts were found')]")); } }

        public IWebElement LnkShowAllContacts { get { return WebDriver.GetElement(By.XPath("//a[contains(text(),'Show all contacts')]")); } }

        public IWebElement RemoveFavorites { get { return WebDriver.GetElement(By.XPath("//tbody/tr[1]/td[2]/div[1]/div[1]")); } }

        public IWebElement RemoveFavConfirm { get { return WebDriver.GetElement(By.XPath("//p[contains(text(),'Removing')]")); } }

        public IWebElement HeaderContactName { get { return WebDriver.GetElement(By.XPath("//div/mat-table/mat-header-row/mat-header-cell[contains(text(), 'Contact Name')]")); } }

        public IWebElement HeaderPhoneNumber { get { return WebDriver.GetElement(By.XPath("//div/mat-table/mat-header-row/mat-header-cell[contains(text(), 'Phone Number')]")); } }

        public IWebElement HeaderEmailAddress { get { return WebDriver.GetElement(By.XPath("//div/mat-table/mat-header-row/mat-header-cell[contains(text(), 'Email Address')]")); } }

        public IWebElement PatchedEUCustDetailsPanel { get { return WebDriver.GetElement(By.XPath("//div[@id='return-EndCustomer-data']//section[@id='customer-Section-']")); } }

        public IWebElement MessageSelectContact { get { return WebDriver.GetElement(By.XPath("//*[@id='favorites']/div/favorites-tab/div[2]/div/div/div/table/tbody/tr[2]/td/div/div/div/div[1]/div/div")); } }




        public BillToPage SelectSoldToEMEAAPJ(string countryCode)
        {
            var soldToResults = SoldToResultsFavorites().ToString().Count();
            if (soldToResults >= 1)
            {
                SoldToExpandResult.Click(WebDriver);
                SelectResult.Click();
            }
            else
            {
                AllCustomersTab.Click(WebDriver);
                delay(15);
                WebDriver.VerifyBusyOverlayNotDisplayed();

                //Find the Sold To results by advanced search (Search by country code)
                SearchBySelection.PickDropdownByText(WebDriver, "Country Code");
                SearchByText.SendKeys(countryCode);
                SoldToFilterSearch.Click(WebDriver);
                if (soldToResults >= 1)
                {
                    SoldToExpandResult.Click(WebDriver);
                    SelectResult.Click();
                }
                else
                {
                    //do nothing
                }
                
            }
            return new BillToPage(WebDriver);
        }

        public void delay(int timeInSeconds)
        {
            Thread.Sleep(timeInSeconds * 1000);
        }

        public bool getNotificationMessage()
        {
            try
            {

                return NoRecentAccounts.Displayed;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
        }

        public int SoldToAdvSearchResults()
        {
            IWebElement table = WebDriver.FindElement(By.XPath("//table[@class='mat-elevation-z8 mat-table']//tbody"));
            ReadOnlyCollection<IWebElement> listOfRows = table.FindElements(By.TagName("mat-row"));

            return listOfRows.Count();
        }


        public SoldToPage SoldToResults(string soldToDCN)
        {
            var soldTo = new SoldToPage(WebDriver);
            if (soldTo.getNotificationMessage())
            {
                soldTo.SearchBySoldToDCN.Click(WebDriver);
                soldTo.SearchBySoldToDCN.SetText(WebDriver, soldToDCN);
                soldTo.SearchDCN.Click(WebDriver);
            }
            else if (soldTo.AdvanceSearchResults.GetText(WebDriver).Contains("If you don’t see your customer") && soldTo.SoldToAdvSearchResults() >= 1)
            {

                //Do nothing
            }
            return new SoldToPage(WebDriver);
        }


        public SoldToPage SoldToResultsCN(string soldToDCN)
        {
            var soldTo = new SoldToPage(WebDriver);
            if (soldTo.AdvanceSearchResults.GetText(WebDriver).Contains("If you don’t see your customer") || soldTo.SoldToAdvSearchResults() > 1)
            {
                soldTo.SearchBySoldToDCN.Click(WebDriver);
                soldTo.SearchBySoldToDCN.SetText(WebDriver, soldToDCN);
                soldTo.SearchDCN.Click(WebDriver);
            }
            else if (soldTo.getNotificationMessage())
            {

                //Do nothing
            }
            return new SoldToPage(WebDriver);
        }

        //Advance search Filtering

        public SoldToPage AdvSearchSolToFiltering(string CompanyNameSoldTo, string AddressLine1SoldTo, string CitySoldTo, string StateSoldTo, string ZipCodeSoldTo, string CountryCodeSoldTo)
        {
            //Filter by Company Name
            FilterByAdvSearch.PickDropdownByText(WebDriver, "Company Name");
            SearchByText.SetText(WebDriver, CompanyNameSoldTo);
            var searchcompTxt = SearchByText.GetText(WebDriver);
            SoldToFilterSearch.Click(WebDriver);
             var resultcompTxt = CompanyNameResult.GetText(WebDriver);
            resultcompTxt.Contains(searchcompTxt).Should().BeTrue();
            ClearSearch.Click(WebDriver);

            //Filter By Address Line 1
            FilterByAdvSearch.PickDropdownByText(WebDriver, "Address Line 1");
            SearchByText.SetText(WebDriver, AddressLine1SoldTo);
            var searchAddLine1Txt = SearchByText.GetText(WebDriver);
            SoldToFilterSearch.Click(WebDriver);
            //SoldToFilterSearch.Click(WebDriver);
            var resultAddline1Txt = CompanyAddressResult.GetText(WebDriver);
            resultAddline1Txt.Contains(searchAddLine1Txt).Should().BeTrue();
            ClearSearch.Click(WebDriver);

            //Filter by City
            FilterByAdvSearch.PickDropdownByText(WebDriver, "City");
            SearchByText.SetText(WebDriver, CitySoldTo);
            var searchCityTxt = SearchByText.GetText(WebDriver);
            SoldToFilterSearch.Click(WebDriver);
            var resultCityTxt = CompanyAddressResult.GetText(WebDriver);
            resultCityTxt.Contains(searchCityTxt).Should().BeTrue();
            ClearSearch.Click(WebDriver);

            //Filter by State
            FilterByAdvSearch.PickDropdownByText(WebDriver, "State");
            SearchByText.SetText(WebDriver, StateSoldTo);
            var searchStateTxt = SearchByText.GetText(WebDriver);
            SoldToFilterSearch.Click(WebDriver);
            var resultStateTxt = CompanyAddressResult.GetText(WebDriver);
            resultStateTxt.Contains(searchStateTxt).Should().BeTrue();
            ClearSearch.Click(WebDriver);

            //Filter by Zipcode
            FilterByAdvSearch.PickDropdownByText(WebDriver, "Zip Code");
            SearchByText.SetText(WebDriver, ZipCodeSoldTo);
            var searchZipCodeTxt = SearchByText.GetText(WebDriver);
            SoldToFilterSearch.Click(WebDriver);
            var resultZipcodeTxt = CompanyAddressResult.GetText(WebDriver);
            resultZipcodeTxt.Contains(searchZipCodeTxt).Should().BeTrue();
            ClearSearch.Click(WebDriver);

            //Filter bY Country Code
            FilterByAdvSearch.PickDropdownByText(WebDriver, "Country Code");
            SearchByText.SetText(WebDriver, CountryCodeSoldTo);
            var searchCountryCodeTxt = SearchByText.GetText(WebDriver);
            SoldToFilterSearch.Click(WebDriver);
            var resultCountryCodeTxt = CompanyAddressResult.GetText(WebDriver);
            resultCountryCodeTxt.Contains(searchCountryCodeTxt).Should().BeTrue();
            ClearSearch.Click(WebDriver);


            return new SoldToPage(WebDriver);
        }

        //SoldToExpandFilter
        public SoldToPage SoldToExpandFilter(string FirstName, string LastName)
        {
            //Filter by First Name
            SearchbyFnLN.PickDropdownByText(WebDriver, "First Name");
            SearchbyFnLNTxt.SetText(WebDriver, FirstName);
            var fnTxt = SearchbyFnLNTxt.GetText(WebDriver);
            SoldToExpandFilterSearch.Click(WebDriver);
            //var fnResultTxt = ResultofFnLNTxt.GetText(WebDriver);
            if (ResultofFnLNTxt.GetText(WebDriver).Contains(fnTxt))
            {
                ResultofFnLNTxt.GetText(WebDriver).Contains(fnTxt).Should().BeTrue();
                ExpandClearSearch.Click(WebDriver);
            }

            else if (NoResultFound.GetText(WebDriver).Contains("No contacts were found"))

            {
                ResultofFnLNTxt.GetText(WebDriver).Contains(fnTxt).Should().BeTrue();
                ExpandClearSearch.Click(WebDriver);

            }
            
            //Filter By last name
            SearchbyFnLN.PickDropdownByText(WebDriver, "LastName");
            SearchbyFnLNTxt.SetText(WebDriver, LastName);
            var lnTxt = SearchbyFnLNTxt.GetText(WebDriver);
            SoldToExpandFilterSearch.Click(WebDriver);
            // var lnResultTxt = ResultofFnLNTxt.GetText(WebDriver);
            if (SelectResultFound.GetText(WebDriver).Contains("Select a contact that")  && ResultofFnLNTxt.GetText(WebDriver).Contains(lnTxt))       
                
            {
                ExpandClearSearch.Click(WebDriver);

            }

            else if (NoResultFound.GetText(WebDriver).Contains("No contacts were found"))
            {
                ExpandClearSearch.Click(WebDriver);

            }
            return new SoldToPage(WebDriver);

        }

    }

}

#endregion
