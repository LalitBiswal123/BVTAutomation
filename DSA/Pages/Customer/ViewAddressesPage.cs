using Dsa.Utils;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace Dsa.Pages.Customer
{
    public class ViewAddressesPage : DsaPageBase
    {
        public ViewAddressesPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements

        public IWebElement HdrShipToAddressAll { get { return WebDriver.GetElement(By.Id("customer_shipping_addresses_list_h")); } }

        public IWebElement ShipToAddressAllGrid { get { return WebDriver.GetElement(By.Id("customerDetailsShipToAddressList")); } }

        public IWebElement DdlPerPage { get { return WebDriver.GetElement(By.Id("grid_paging_itemsPerPage")); } }

        public IWebElement DdlCustomerPartySearchFilter { get { return WebDriver.GetElement(By.Id("customerParty_searchFilter")); } }

        public IWebElement TxtCustomerPartyEnterSearchTerm { get { return WebDriver.GetElement(By.Id("customerParty_searchFilter_value")); } }

        public IWebElement BtnCustomerPartySearch { get { return WebDriver.GetElement(By.Id("customerParty_searchAction")); } }

        public IWebElement ExpandShippingAddress { get { return WebDriver.GetElement(By.CssSelector("a.k-icon.expandRow")); } }

        #endregion

        #region PIR

        public IWebElement InvoiceProfileButton { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'View Invoice Profile')]")); } }

        public IWebElement closeInvoiceProfile { get { return WebDriver.GetElement(By.XPath("//*[@class='btn btn-blank icon-ui-close']")); } }

        public IWebElement InvoiceCopies { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Invoice Copies')]")); } }

        public IWebElement CreditNoteCopies { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Credit Note Copies')]")); } }

        public IWebElement DebitNoteCopies { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Debit Note Copies')]")); } }

        public IWebElement ConsolidationMethod { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Consolidation Method')]")); } }

        public IWebElement CustomInvoice { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Custom Invoicing')]")); } }

        public IWebElement SpecialHandling { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Special Handling')]")); } }

        public IWebElement eVoicingEnabled { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'eInvoicing Enabled')]")); } }

        public IWebElement CustomerIdentifier { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Customer Identifier')]")); } }

        public IWebElement TransactionType { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Transaction Type')]")); } }

        public IWebElement Frequence { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Frequence')]")); } }

        public IWebElement EDIFormat { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'EDI Format')]")); } }

        public IWebElement StartDate { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Start Date')]")); } }

        public IWebElement EndDate { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'End Date')]")); } }

        public IWebElement IntermediaryIdentifier { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Intermediary Identifier')]")); } }

        public IWebElement TransactionNature { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Transaction Nature')]")); } }

        public IWebElement FrequencyDetail { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Frequency Detail')]")); } }

        public IWebElement ViewInvoiceProfileRelated { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_locations']//locations-grid-actions//a[contains(text(), 'View Invoice Profile')]")); } }

        #endregion

        /// <summary>
        /// Treat this like a BVT of the page. If Validate does not pass, throw exception and console.writeline a return message into Test Class
        /// </summary>
        /// <returns>validated</returns>


        public override bool Validate()
        {
            return WebDriver.VerifyBusyOverlayNotDisplayed()
                && HdrShipToAddressAll.Displayed;
        }

        /// <summary>
        /// determines whether or not the driver is active on this page. Must be overriden with each subclass.
        /// </summary>
        /// <returns>active</returns>
        public override bool IsActive()
        {
            return (WebDriver.Url.Contains("customer/shippingaddresses"));
        }

        public List<Dictionary<string, object>> GetShippingAddresses()
        {
            return ShipToAddressAllGrid.GetHtmlTableData(WebDriver);
        }

        /// <summary>
        /// set the maximum number of items per page to display
        /// </summary>
        /// <param name="itemMax"></param>
        public void SetPerPageCount(int itemMax)
        {
            if (DdlPerPage.Displayed)
                DdlPerPage.PickDropdownByText(WebDriver, string.Format("{0} per page", itemMax));
            //TODO:: need to handle nosuchelementexception with IWebElement
            //else
            //    throw new NoSuchElementException(CustomerIDs.PerPageDropdown);
        }

        /// <summary>
        /// these methods scroll to other pages by either clicking the arrows or the page numbers
        /// </summary>
        //public void GoToNextPage()
        //{
        //    WebDriver.GoToNextPage();
        //}
        //public void GoToPage(int pageNum)
        //{
        //    WebDriver.GoToPage(pageNum);
        //}

        ///// <summary>
        ///// returns the "1-10 of 78" display, from given position 'start' and of given 'length'
        ///// </summary>
        ///// <param name="start"></param>
        ///// <param name="length"></param>
        ///// <returns></returns>
        //public string GetTablePagingDisplay(int start, int length)
        //{
        //    return WebDriver.GetPagingDisplay(start, length);
        //}

        // PIR
        public ViewAddressesPage verifyPIRFieldsareDisplayed()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            InvoiceCopies.IsElementDisplayed(WebDriver, null).Should().BeTrue();
            CreditNoteCopies.IsElementDisplayed(WebDriver, null).Should().BeTrue();
            DebitNoteCopies.IsElementDisplayed(WebDriver, null).Should().BeTrue();
            ConsolidationMethod.IsElementDisplayed(WebDriver, null).Should().BeTrue();
            CustomInvoice.IsElementDisplayed(WebDriver, null).Should().BeTrue();
            SpecialHandling.IsElementDisplayed(WebDriver, null).Should().BeTrue();
            eVoicingEnabled.IsElementDisplayed(WebDriver, null).Should().BeTrue();
            CustomerIdentifier.IsElementDisplayed(WebDriver, null).Should().BeTrue();
            TransactionType.IsElementDisplayed(WebDriver, null).Should().BeTrue();
            Frequence.IsElementDisplayed(WebDriver, null).Should().BeTrue();
            EDIFormat.IsElementDisplayed(WebDriver, null).Should().BeTrue();
            StartDate.IsElementDisplayed(WebDriver, null).Should().BeTrue();
            EndDate.IsElementDisplayed(WebDriver, null).Should().BeTrue();
            IntermediaryIdentifier.IsElementDisplayed(WebDriver, null).Should().BeTrue();
            TransactionNature.IsElementDisplayed(WebDriver, null).Should().BeTrue();
            FrequencyDetail.IsElementDisplayed(WebDriver, null).Should().BeTrue();
            return new ViewAddressesPage(WebDriver);
        }

        //public void SortAllShippingAddressesBy(string column)
        //{
        //    ShipToAddressAllGrid.SortGridBy(WebDriver, column);
        //}

        public IWebElement SelectAddressTab(int? selectTab)
        {
            return WebDriver.GetElement(By.Id("View_All_Locations_Grid_tab_" + selectTab));
        }

        public IEnumerable<string> ColumnList(string column)
        {
            return GetShippingAddresses().Select(k => k[column]).Cast<string>();
        }

        /// <summary>
        /// select criteria (column), then value, then click Search
        /// </summary>
        /// <param name="column"></param>
        /// <param name="filterValue"></param>
        public void FilterAddressesBy(string column, string filterValue)
        {
            //click on the dropdown
            DdlCustomerPartySearchFilter.PickDropdownByText(WebDriver, column);
            //enter the value
            TxtCustomerPartyEnterSearchTerm.SetText(WebDriver, filterValue);
            //click the search button
            BtnCustomerPartySearch.Click(WebDriver);
        }


        ///// <summary>
        ///// expand the given row
        ///// </summary>
        ///// <param name="row"></param>
        //public void ExpandShippingAddress(int row)
        //{
        //    WebDriver.GetElements(By.CssSelector("a.k-icon.expandRow"))[row].Click();
        //}

        /// <summary>
        /// returns the text (both labels and data) in the expanded row  
        /// </summary>
        /// <returns></returns>
        public string GetExpandedAddressInfo()
        {
            return WebDriver.GetElement(By.ClassName("detail-cell")).Text;
        }
        /// <summary>
        /// expands the given line
        /// </summary>
        /// <param name="i"></param>
        public void ExpandLine(int i)
        {
            var js = WebDriver as IJavaScriptExecutor;
            js.ExecuteScript(string.Format(
                "$('#{0}').find('tbody>tr:nth-child({1})').find('td:nth-child(1)>a').click();",
                ShipToAddressAllGrid, i));
        }
    }
}
