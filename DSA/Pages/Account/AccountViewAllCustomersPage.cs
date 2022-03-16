using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Account
{
  public partial  class AccountViewAllCustomersPage : DsaPageBase
    { 
        public AccountViewAllCustomersPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements

        public IWebElement ItemPerPageId { get { return WebDriver.GetElement(By.Id("grid_paging_itemsPerPage")); } }
       
        public IWebElement SearchFilterId { get { return WebDriver.GetElement(By.Id("account_viewAll_customers_searchFilter")); } }

        public IWebElement SearchBoxId { get { return WebDriver.GetElement(By.Id("account_viewAll_customers_searchFilter_value")); } }

        public IWebElement BtnSearch { get { return WebDriver.GetElement(By.Id("account_viewAll_customers_search")); } }

        public IWebElement TotalNumberOfItemsId { get { return WebDriver.GetElement(By.Id("accountDetails_customersGrid_fromto")); } }

        public IWebElement PageLinkId { get { return WebDriver.GetElement(By.Id("accountDetails_customersGrid_pagination")); } }

        public IWebElement PageLinkArrowClassName { get { return WebDriver.GetElement(By.ClassName("icon-ui-arrowright")); } }

        public IWebElement DataTableViewAllCustomersId { get { return WebDriver.GetElement(By.Id("DataTables_Table_1")); } }

        public IWebElement DataTableBody { get { return WebDriver.GetElement(By.TagName("tBody")); } }

        public IWebElement DtRow { get { return WebDriver.GetElement(By.TagName("tr")); } }

        public IWebElement DataCell { get { return WebDriver.GetElement(By.TagName("td")); } }

        #endregion

    }
}
