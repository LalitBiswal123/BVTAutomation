using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;

namespace Dsa.Pages.ManagePartnerFavorites
{
    public class MPFPage : DsaPageBase
    {
        public MPFPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);

        }


        public int MPFResultsBillToFavorites()
        {
            IWebElement table = WebDriver.FindElement(By.XPath("//*[@id='main-container']/div/manage-partner-favorites-search/div[1]/div[5]/div/table"));
            ReadOnlyCollection<IWebElement> listOfRows = table.FindElements(By.TagName("tr"));

            return listOfRows.Count();
        }


        #region Elements


        public IWebElement MPFHeader { get { return WebDriver.GetElement(By.XPath("//h3[contains(text(),'Manage Partner Favorites - Bill To')]")); } }

        public IWebElement MPFDef { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'Manage Partner Favorites page is the starting point')]")); } }

        public IWebElement APIDHeader { get { return WebDriver.GetElement(By.XPath("//h4[contains(text(),'Account Partner ID (APID) Search')]")); } }

        public IWebElement APIDHeaderDesc { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Enter APID to see associated favorite Bill To')]")); } }

        public IWebElement APIDSearchInput { get { return WebDriver.GetElement(By.Id("name-3")); } }

        public IWebElement APIDSearchIcon { get { return WebDriver.GetElement(By.Id("end-user-search-button")); } }

        public IWebElement InvalidAPIDError { get { return WebDriver.GetElement(By.XPath("//*[@id='main-container']/div/manage-partner-favorites-search/div[1]/div[3]/div/div")); } }

        public IWebElement ResultsNotFound { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'No results were found')]")); } }

        public IWebElement AddFavorite { get { return WebDriver.GetElement(By.Id("add-favorites-button-on-no-results")); } }

        public IWebElement AddFavoriteResults { get { return WebDriver.GetElement(By.Id("add-favorites-button")); } }

        public IWebElement AddFavoritesPopUp { get { return WebDriver.GetElement(By.Id("mat-dialog-0")); } }

        public IWebElement FilterBy { get { return WebDriver.GetElement(By.Id("search-by-selection")); } }

        public IWebElement FilterByInput { get { return WebDriver.GetElement(By.Id("search-by-text")); } }

        public IWebElement FilteringError { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'No results were found')]")); } }

        public IWebElement FilterBySearch { get { return WebDriver.GetElement(By.XPath("//*[@id='main-container']/div/manage-partner-favorites-search/div[1]/div[4]/search-by/form/div/div[2]/div/i")); } }

        public IWebElement ClearSearch { get { return WebDriver.GetElement(By.XPath("//a[contains(text(),'Clear search')]")); } }

        public IWebElement HeaderCompName { get { return WebDriver.GetElement(By.XPath("//th[contains(text(),'Company Name')]")); } }

        public IWebElement HeaderCompAddress { get { return WebDriver.GetElement(By.XPath("//th[contains(text(),'Company Address')]")); } }

        public IWebElement HeaderCustNumber { get { return WebDriver.GetElement(By.XPath("//th[contains(text(),'Customer Number')]")); } }

        public IWebElement HeaderCompanyNo { get { return WebDriver.GetElement(By.XPath("//th[contains(text(),'Company No.')]")); } }

        public IWebElement HeaderPaymentType { get { return WebDriver.GetElement(By.XPath("//th[contains(text(),'Payment Type')]")); } }

        public IWebElement HeaderCurrency { get { return WebDriver.GetElement(By.XPath("//th[contains(text(),'Currency')]")); } }

        public IWebElement ExpandButton { get { return WebDriver.GetElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/i[1]")); } }

        public IWebElement HeaderContactName { get { return WebDriver.GetElement(By.XPath("//mat-header-cell[contains(text(),'Contact Name')]")); } }

        public IWebElement HeaderPhoneNumber { get { return WebDriver.GetElement(By.XPath("//mat-header-cell[contains(text(),'Phone Number')]")); } }

        public IWebElement HeaderEmailAddress { get { return WebDriver.GetElement(By.XPath("//mat-header-cell[contains(text(),'Email Address')]")); } }

        public IWebElement RemoveFavorites { get { return WebDriver.GetElement(By.XPath("//tbody/tr[3]/td[2]/div[1]/div[1]")); } }

        public IWebElement RemoveFavoritespopup { get { return WebDriver.GetElement(By.XPath("//*[@id='exampleModal']/div")); } }

        public IWebElement RemoveFavConfirm { get { return WebDriver.GetElement(By.XPath("//p[contains(text(),'Removing a favorite address removes all favorite contacts')]")); } }

        public IWebElement ContactDisplayed { get { return WebDriver.GetElement(By.Id("dsa-table-row")); } }

        public IWebElement ContactNotFound { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'No contacts were found')]")); } }
        
        public IWebElement RemoveFavoriteContact { get { return WebDriver.GetElement(By.XPath("//*[@id='dsa-table-row']/td/div")); } }

        public IWebElement DCNManualUploadTab { get { return WebDriver.GetElement(By.Id("dcn-manual-upload-tab")); } }

        public IWebElement DCNBulkUploadTab { get { return WebDriver.GetElement(By.Id("dcn-bulk-upload-tab")); } }

        public IWebElement MessageAddFavorites { get { return WebDriver.GetElement(By.XPath("//p[contains(text(),'Add favorites by manually entering Dell Customer Numbers')]")); } }

        public IWebElement APIDvalue { get { return WebDriver.GetElement(By.Id("apid")); } }

        public IWebElement DCNInputBox { get { return WebDriver.GetElement(By.Id("dcns")); } }

        public IWebElement DCNUploadSucessMessage { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'Dell Customer Number(s) uploaded successfully.')]")); } }

        public IWebElement BtnBacktoSearch { get { return WebDriver.GetElement(By.XPath("//button[contains(text(),'Back to Search')]")); } }

        public IWebElement ShowAllFavorites { get { return WebDriver.GetElement(By.XPath("//button[contains(text(),'Show all favorites')]")); } }

        public IWebElement DCNEntryConditions { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Separate DCNs with commas, semi-colons, spaces or newline')]")); } }

        public IWebElement DCNInputInstruction { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'When Entering DCN, please ensure')]")); } }

        public IWebElement CancelAddFavorites { get { return WebDriver.GetElement(By.XPath("//*[@id='favorites']/div[2]/button[1]")); } }

        public IWebElement BtnAdd { get { return WebDriver.GetElement(By.XPath("//*[@id='favorites']/div[2]/button[2]")); } }

        public IWebElement BulkUploadMessage { get { return WebDriver.GetElement(By.XPath("//p[contains(text(),'Use Bulk upload')]")); } }

        public IWebElement TabGoToBulkUpload { get { return WebDriver.GetElement(By.XPath("//button[contains(text(),'Go to Bulk Upload')]")); } }

        
        #endregion

        #region Methods

        public MPFPage SearchByAPID(string APID)
        {
            APIDSearchInput.SetText(WebDriver, APID);
            APIDSearchIcon.Click(WebDriver);            
            return new MPFPage(WebDriver);
        }

        public void FilterResult(string CustomerNumber)
        {
            FilterBy.PickDropdownByText(WebDriver, "Customer No.");
            FilterByInput.SendKeys(CustomerNumber);
            FilterBySearch.Click(WebDriver);
        }

        public void delay(int timeInSeconds)
        {
            Thread.Sleep(timeInSeconds * 1000);
        }


        #endregion
    }





}