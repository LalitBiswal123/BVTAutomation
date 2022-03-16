using System.Linq;
using Dsa.Pages.Quote;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Opportunity
{
   public class OpportunityViewAllPage : DsaPageBase
    {
        public OpportunityViewAllPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement HdrOpportunityViewAllPage { get { return WebDriver.GetElement(By.Id("account_opportunities_list_h")); } }


public IWebElement DdlSearchFilter { get { return WebDriver.GetElement(By.Id("account_viewAll_opportunities_searchFilter")); } }


public IWebElement TxtSearchTerm { get { return WebDriver.GetElement(By.Id("account_viewAll_opportunities_searchFilter_value")); } }


public IWebElement BtnSearchTerm { get { return WebDriver.GetElement(By.Id("account_viewAll_opportunities_search")); } }


public IWebElement DivOpportunityList { get { return WebDriver.GetElement(By.Id("accountDetails_opportunitiesGrid")); } }


public IWebElement DdlItemsPerPage { get { return WebDriver.GetElement(By.Id("grid_paging_itemsPerPage")); } }


public IWebElement BusySpin { get { return WebDriver.GetElement(By.ClassName("busy-spin")); } }


public IWebElement PagingDiv { get { return WebDriver.GetElement(By.ClassName("c-grid-pagination")); } }

        #endregion

        public CreateQuotePage CreateQuoteFromOpportunityList(string opportunityName)
        {
            DivOpportunityList.GetElements(WebDriver, By.CssSelector("table > tbody > tr"))
                .Single(a => a.GetText(WebDriver).Contains(opportunityName))
                .FindElement(By.LinkText("Create Quote"))
                .Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        }

        public CreateQuotePage GoToOpportunityDetailsFromOpportunityList(string opportunityName)
        {
            DivOpportunityList.GetElements(WebDriver, By.CssSelector("table > tbody > tr"))
                .Single(a => a.GetText(WebDriver).Contains(opportunityName))
                .FindElement(By.LinkText(opportunityName))
                .Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        }

        public OpportunityViewAllPage FilterOpportunities(string columnName = "", string searchTerm = "")
        {
            if (!string.IsNullOrEmpty(columnName))
                DdlSearchFilter.PickDropdownByText(WebDriver, columnName);

            if (!string.IsNullOrEmpty(searchTerm))
                TxtSearchTerm.SetText(WebDriver, searchTerm);

            BtnSearchTerm.Click(WebDriver);
            return this;
        }
    }
}