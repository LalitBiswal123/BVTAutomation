using Dsa.Utils;
using OpenQA.Selenium;
using System;
using Dell.Adept.UI.Web.Pages;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{ 
    public class ImportCartPopUp : PagePartBase
    {
        private readonly IWebDriver WebDriver;
        
        public override bool Validate()
        {
            throw new NotImplementedException();
        }
        
        public ImportCartPopUp(IPage page, IWebElement parentElement)
            : base(page, ref parentElement)
        {
            ParentPage = page;
            ParentElement = parentElement;
            this.WebDriver = ParentPage.WebDriver;
            PageFactory.InitElements(WebDriver, this);
        }

        #region Element 


public IWebElement ImportCartPopUpDialog { get { return WebDriver.GetElement(By.Id("importLegacyCartDialog")); } }


public IWebElement RdoBtnWork { get { return WebDriver.GetElement(By.Id("importLegacyCartDialog_work")); } }


public IWebElement RdoBtnHome { get { return WebDriver.GetElement(By.Id("importLegacyCartDialog_home")); } }


public IWebElement TxtQuoteId { get { return WebDriver.GetElement(By.Id("importLegacyCartDialog_equoteId")); } }


public IWebElement TxtCartNumber { get { return WebDriver.GetElement(By.Id("importLegacyCartDialog_legacyCartNumber")); } }


public IWebElement BtnImport { get { return WebDriver.GetElement(By.Id("importLegacyCartDialog_import")); } }


public IWebElement BtnCancel { get { return WebDriver.GetElement(By.Id("importLegacyCartDialog_cancel")); } }
        

public IWebElement TxtEmailCart { get { return WebDriver.GetElement(By.Id("importLegacyCartDialog_customerEmail")); } }


public IWebElement TxTHomeEmail { get { return WebDriver.GetElement(By.Id("importLegacyCartDialog_homecustomerEmail")); } }


public IWebElement GridDataTable { get { return WebDriver.GetElement(By.Id("customerDetails_myAccountCartsGrid")); } }


public IWebElement GridMyEmailedQuotes { get { return WebDriver.GetElement(By.Id("DataTables_Table_emailedQuotesData")); } }


public IWebElement MsgDataNotRetrieved { get { return WebDriver.GetElement(By.XPath("//span[contains(@class, 'notification') and text() = 'Could not retrieve data. Please check the e-Mail address and try again.']")); } }
        
        #endregion

        #region Method

        /// <summary>
        /// Clicks on Import Button.
        /// </summary>
        public void Import()
        {
            BtnImport.Click(WebDriver);
        }

        
        /// <summary>
        /// Clicks on Cancel Button.
        /// </summary>
        public void Cancel()
        {
            BtnCancel.Click(WebDriver);
        }
        public IWebElement CartNumber()
        {
            return TxtCartNumber;
        }
        public IWebElement GridTable()
        {

            return GridDataTable;
        }
        /// <summary>
        /// Returns Email textbox
        /// </summary>
        public IWebElement EmailCart()
        {
            return TxtEmailCart;
        }

        public IWebElement NoCartsAssociated()
        {
            return MsgDataNotRetrieved;
        }

        public string GetQuoteNumberAtIndex(int index = 1)
        {
            //var xpath = "//*[contains(@id, '_email_cart_quote_id_" + index + "')]";
            var xpath = "//*[@id='DataTables_Table_emailedQuotesData']/tbody/tr[" + index + "]/td[2]";
            return WebDriver.GetElement(By.XPath(xpath)).GetText(WebDriver);
        }

        public void ClickLoadQuoteAtIndex (int index = 0)
        {
            var xpath = "//*[contains(@id, 'button_Load Quote_" + (index-1) + "_')]";
            WebDriver.GetElement(By.XPath(xpath)).Click(WebDriver);
        }

        #endregion
    }
}