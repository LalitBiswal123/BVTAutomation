//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace Dsa.Pages.Order
{
    public class OrderSearchResultsPage : DsaPageBase
    {
        public OrderSearchResultsPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement GridOrderSearchResults { get { return WebDriver.GetElement(By.Id("orderSearchResults_Grid")); } }


public IWebElement NoResultsMsg { get { return WebDriver.GetElement(By.Id("common_noResults_message")); } }


public IList<IWebElement> ExpandedLink { get { return WebDriver.GetElements(By.XPath(".//table[contains(@id,'DataTables_Table_')]/descendant::td/a[contains(@class,'expandRow')]")); } }


public IWebElement PO { get { return WebDriver.GetElement(By.XPath(".//table[contains(@id,'DataTables_Table_')]/descendant::table//td[2]")); } }


public IWebElement FirstDPIDfromOrdersearchrslt { get { return WebDriver.GetElement(By.XPath("//table[contains(@id,'DataTables_Table_')]/thead/tr//following::tr/td//following::td[4]/a")); } }


public IWebElement DpsNumber { get { return WebDriver.GetElement(By.Id("orderSearch_dpsNumber")); } }


public IWebElement DpsNumberLable { get { return WebDriver.GetElement(By.Id("orderDetails_dpsNumber")); } }


public IWebElement OrderSearchResultsGrid { get { return WebDriver.GetElement(By.Id("orderSearchResults_Grid")); } }


public IList<IWebElement> CurrencyColumns { get { return WebDriver.GetElements(By.XPath("//table[@id = 'DataTables_Table_3']//td[12]")); } }


        #endregion

        public OrderDetailsPage SelectFirstDpidFromTable()
        {
            GridOrderSearchResults.FindElement(By.CssSelector("tbody > tr > td:nth-child(5) > a")).Click(WebDriver);
            return new OrderDetailsPage(WebDriver);
        }
        public OrderDetailsPage SelectCMPDpidFromTable()
        {
            if (GridOrderSearchResults.FindElement(By.CssSelector("tbody > tr > td:nth-child(6) > a")).Text == "CMP")
            {
                GridOrderSearchResults.FindElement(By.CssSelector("tbody > tr > td:nth-child(5) > a")).Click(WebDriver);
                return new OrderDetailsPage(WebDriver);
            }
            return null;
        }

        public bool OrderSearchNoResultsErrorMessage()
        {
            return NoResultsMsg.IsElementVisible();
        }



    }
}
