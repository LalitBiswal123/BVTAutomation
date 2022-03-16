using System.Collections.Generic;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using System;
using FluentAssertions;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;

namespace Dsa.Pages.Quote
{
    public class QuoteSplitResultsPage : DsaPageBase
    {
        public QuoteSplitResultsPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements


public IWebElement Title { get { return WebDriver.GetElement(By.Id("_title")); } }


public IWebElement Quotelist { get { return WebDriver.GetElement(By.Id("_quotelist")); } }


public IWebElement BtnSendAll { get { return WebDriver.GetElement(By.Id("quoteSplit_sendAll")); } }


public IWebElement LblSplitValidationError { get { return WebDriver.GetElement(By.XPath("//*[@id='_quoteSplit_sendAllFailure']/p")); } }


public IWebElement SplitQuoteGrid { get { return WebDriver.GetElement(By.Id("splitQuote_popupGrid")); } }


public IWebElement SplitResultInfo { get { return WebDriver.GetElement(By.XPath("//*[@id='main')]/div/div")); } }


public IWebElement quoteSplit { get { return WebDriver.GetElement(By.Id("splitQuoteSelect")); } }


public IWebElement SavequoteSplit { get { return WebDriver.GetElement(By.Id("quoteSplit_saveQuotes")); } }


public IWebElement SplitQuotetable { get { return WebDriver.GetElement(By.XPath("//*[contains(@id, 'DataTables_Table')]/tbody")); } }


public IWebElement ChangeCutomer_Quote { get { return WebDriver.GetElement(By.Id("currentCustomer_changeCustomer")); } }


public IWebElement QuoteSplitCustomerNumber { get { return WebDriver.GetElement(By.Id("quoteSplit_customerNumber")); } }


public IWebElement QuoteSplitSearchCustomerNumber { get { return WebDriver.GetElement(By.Id("quoteSplit_searchCustomer")); } }


public IWebElement ChangeCustomerNumber_Confirm { get { return WebDriver.GetElement(By.Id("changeCustomer_confirm")); } }


public IWebElement CurrentCustomerNumber_QuoteSplit { get { return WebDriver.GetElement(By.Id("currentCustomer_customerNumber")); } }


public IWebElement SplitQuote_1 { get { return WebDriver.GetElement(By.Id("customerSetSelect-Grid-0-")); } }


public IWebElement SplitQuote_2 { get { return WebDriver.GetElement(By.Id("customerSetSelect-Grid-1-")); } }

        public IWebElement ShippingGroupEdd(int groupIndex)
        {
            return WebDriver.GetElement(By.Id("quoteSplit_GI_EDD_Max_" + groupIndex + "_"));
        }
        public IWebElement ShippingGroupEdds(int groupIndex)
        {
            return WebDriver.GetElement(By.Id("quoteCreate_GI_EDD_Max_0"));
        }
        

        public IWebElement ShippingGroupShippingMethod(int groupIndex = 0)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_GI_"+groupIndex+"_shippingMethod']"));
        }

        public IWebElement ShippingGroupManualShippingDiscount(int groupIndex = 0)
        {
            return WebDriver.GetElement(By.Id("quoteCreate_GI_"+groupIndex+"_shippingManualDiscount"));
        }

        #endregion

        public List<Dictionary<string, object>> GetQuoteSplitResultsGrid()
        {
            return SplitQuoteGrid.GetHtmlTableData(WebDriver);
        }

        public SendQuotePage SendAllQuotes()
        {
            BtnSendAll.Click(WebDriver);
            return new SendQuotePage(WebDriver);
        }

        public bool IsQuoteSplit(IWebDriver webDriver)
        {
            new QuoteSplitResultsPage(webDriver).quoteSplit.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(30)).Should().BeTrue();
            var isFirstSplitShown = quoteSplit.GetText(webDriver).Contains("1/");
         
            return (quoteSplit.IsElementDisplayed(webDriver) && isFirstSplitShown);
        }

        public bool VerifysplitQuote()
        {
            return SplitResultInfo.Displayed;
        }

        public void ClickSaveQuotes(IWebDriver webDriver)
        {
            SavequoteSplit.Click();
            DsaUtil.WaitForWaitAnimationToLoad(webDriver);
        }

        public List<string> SplitQuoteList()
        {
            string table = "//*[@id='customerSetSelect-Grid-";
            string row_part = "-']";
            int numOfRow = SplitQuotetable.FindElements(By.TagName("tr")).Count;
            List<string> QuoteColumnList = new List<string>();
            for (int i = 0; i < numOfRow; i++)
            {

                //Prepare final xpath of each row in the table
                var final_xpath = table + i + row_part;
                //retrieve Quote number from each row and add it to the list
                var quoteNum = WebDriver.FindElement(By.XPath(final_xpath)).GetText(WebDriver).Substring(0, 13);
                QuoteColumnList.Add(quoteNum);
            }
            return QuoteColumnList;
        }

        public void ClickChangeCustomer_Quote()
        {
            ChangeCutomer_Quote.Click(WebDriver);
            ChangeCustomerNumber_Confirm.Click(WebDriver);

        }

        public bool ConfirmChangeCustomer(string newcustomer)
        {
           return CurrentCustomerNumber_QuoteSplit.GetText(WebDriver).Equals(newcustomer);
        }

        public QuoteSplitResultsPage SplitQuoteNum(int index)
        {
            quoteSplit.Select().SelectByPartialText(index + "/");
           // new QuoteDetailsPage(WebDriver).WaitForQuoteValidationToComplete();
           
            return this;
        }

        public string GetShippingGroupEdd(int shippingGroupIndex = 1)
        {
            return ShippingGroupEdd(shippingGroupIndex - 1).GetText(WebDriver);
        }
        public string GetShippingGroupEdds(int shippingGroupIndex = 1)
        {
            return ShippingGroupEdds(shippingGroupIndex).GetText(WebDriver);
        }
    }
    
}
