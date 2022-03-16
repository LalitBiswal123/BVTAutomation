using System.Linq;
using Dsa.Pages.Opportunity;
using Dsa.Pages.Quote;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Dsa.Pages.Customer;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using System;
using System.Collections.Generic;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;

namespace Dsa.Pages.Account
{
    public class AccountDetailsPage : DsaPageBase
    {
        public AccountDetailsPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements

        public IWebElement LblAccountName { get { return WebDriver.GetElement(By.Id("accountDetail_accountName")); } }
                
        public IWebElement LblAccountNameText { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_0']/tbody//a)[2]")); } }

        public IWebElement CanadaAccountNameText { get { return WebDriver.GetElement(By.Id("accountDetail_accountName")); } }

        public IWebElement SpecificLblAccountNameTxt { get { return WebDriver.GetElement(By.XPath("//*[@id='accountSearchResultGrid-0-']")); } }

        public IWebElement AccountResults { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_accountSearchResultGrid']")); } }

        public IWebElement LblAccountNumber { get { return WebDriver.GetElement(By.Id("accountDetail_accountNumber")); } }

        public IWebElement LblStatus { get { return WebDriver.GetElement(By.Id("accountDetail_status")); } }

        public IWebElement SalesRep { get { return WebDriver.GetElement(By.Id("accountDetail_primarySalesRep")); } }

        public IWebElement BtnViewAccountTeam { get { return WebDriver.GetElement(By.Id("accountDetail_viewAccountTeam")); } }

        public IWebElement BtnViewInSfdc { get { return WebDriver.GetElement(By.Id("accountDetail_viewInSfdc")); } }

        public IWebElement TblCustomerList { get { return WebDriver.GetElement(By.Id("DataTables_Table_customerResults")); } }

        public IWebElement CustomersGrid { get { return WebDriver.GetElement(By.Id("accountDetail_customer_information")); } }

        public IWebElement HdrOpportunityList { get { return WebDriver.GetElement(By.Id("accountDetails_opportunitiesHeading")); } }

        public IWebElement OpportunityGrid { get { return WebDriver.GetElement(By.Id("accountDetails_opportunitiesGrid")); } }

        public IWebElement TblOpportunityList { get { return WebDriver.GetElement(By.Id("accountDetail_opportunity")); } }

        public IWebElement LnkOpportunityListViewAll { get { return WebDriver.GetElement(By.Id("accountDetails_opportunitiesViewAll")); } }

        public IWebElement LnkViewAllCustomer { get { return WebDriver.GetElement(By.Id("accountDetails_customersViewAll")); } }

        public IWebElement BtnDetails { get { return WebDriver.GetElement(By.XPath("//tr[1]/td[5]/a")); } }

        public IWebElement LnkAddCustomerId { get { return WebDriver.GetElement(By.Id("accountDetails_showAdd")); } }

        public IWebElement TxtAddCustomerId { get { return WebDriver.GetElement(By.Id("_accountNumber")); } }

        public IWebElement LnkAddCustomerIdSave { get { return WebDriver.GetElement(By.Id("accountDetails_submitAccount")); } }

        public IWebElement MsgAddCustomerError { get { return WebDriver.GetElement(By.Id("accountDetails_showMessage")); } }

        public IWebElement BtnMoreActions { get { return WebDriver.GetElement(By.Id("accountDetail_moreActions")); } }

        public IWebElement DashboardIconForCustomer { get { return WebDriver.GetElement(By.Id("dashboardnavigation")); } }

        public IWebElement CustomerRevenueIcon { get { return WebDriver.GetElement(By.XPath("//i[@class='icon-revenue-lg mg-right-10']")); } }

        public IWebElement CustomerDashBoardIcon { get { return WebDriver.GetElement(By.XPath("//i[@class = 'icon-c360-lg mg-right-10']")); } }

        public IWebElement CustomerPAMInfo { get { return WebDriver.GetElement(By.Id("accountDetail_partnerAccountMgmt")); } }

        public IWebElement CreateQuoteBtn { get { return WebDriver.GetElement(By.Id("button_Create Quote_0_")); } }

        public IWebElement CreateQuoteBtnOpportunityList(int? Index)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_opportunitiesResults']//td//a[@id='button_Create Quote_" + Index + "_']"));
        }

        public IWebElement CustomersInAccountDetailsPage(int? Index)
        {
            return WebDriver.GetElement(By.Id("customerResults-" + Index + "-"));
        }

        public IWebElement AlrertMsg { get { return WebDriver.GetElement(By.XPath("//div[@class='alert alert-info']")); } }

        public IWebElement AccountInfo { get { return WebDriver.GetElement(By.Id("accountDetails_header_Information")); } }

        public IWebElement Accountdetails { get { return WebDriver.GetElement(By.Id("accountDetail_accountDetails")); } }




        #endregion

        #region Methods

        public AccountViewAllCustomersPage ViewAllCustomers()
        {
            LnkViewAllCustomer.Click(WebDriver);
            return new AccountViewAllCustomersPage(WebDriver);
        }

        public AccountViewAllCustomersPage ViewAllOpportunities()
        {
            LnkOpportunityListViewAll.Click(WebDriver);
            return new AccountViewAllCustomersPage(WebDriver);
        }

        public CreateQuotePage CreateQuoteFromCustomerList(string customerNumber)
        {
            TblCustomerList.GetElements(WebDriver, By.CssSelector("table > tbody > tr"))
                .Single(a => a.GetText(WebDriver).Contains(customerNumber))
                .FindElement(By.LinkText("Create Quote"))
                .Click(WebDriver);

            // WebDriver.VerifyBusyOverlayNotDisplayed();
            if (WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_companyNumbers']//a[text()='Select'])[1]"), TimeSpan.FromSeconds(5)) != null)
            {
                WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_companyNumbers']//a[text()='Select'])[1]")).Click(WebDriver);
                return new CreateQuotePage(WebDriver);
            }
            else
            {
                return new CreateQuotePage(WebDriver);
            }
        }

        public CreateQuotePage CreateQuoteFromAccountDetailsPage()
        {
            CreateQuoteBtn.Click();
            if (WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_companyNumbers']//a[text()='Select'])[1]"), TimeSpan.FromSeconds(5)) != null)
            {
                WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_companyNumbers']//a[text()='Select'])[1]")).Click(WebDriver);
                return new CreateQuotePage(WebDriver);
            }
            else
            {
                return new CreateQuotePage(WebDriver);
            }
        }



        public CreateQuotePage GoToCustomerDetailsFromCustomerList(string customerNumber)
        {
            TblCustomerList.GetElements(WebDriver, By.CssSelector("table > tbody > tr"))
                .Single(a => a.GetText(WebDriver).Contains(customerNumber))
                .FindElement(By.LinkText(customerNumber))
                .Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            if (WebDriver.GetElement(By.Id("customerSetSelect_Grid")).IsElementVisible())
            {
                WebDriver.GetElement(By.XPath("//*[@id='customerSetSelect_Grid']//a[text()='Select'][1]")).Click(WebDriver);
                return new CreateQuotePage(WebDriver);
            }
            else
            {
                return new CreateQuotePage(WebDriver);
            }
        }

        public CreateQuotePage CreateQuoteFromOpportunityList(string opportunityName)
        {
            IWebElement CreateQuoteButton = WebDriver.FindElement(By.XPath("//*[text()='" + opportunityName + "']/following::a[text()='Create Quote'][1]"));
            CreateQuoteButton.Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        }

        public CreateQuotePage CreateQuoteFromOpportunityLists(int Index)
        {
            CreateQuoteBtnOpportunityList(Index).Click(WebDriver);
            if (WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_companyNumbers']//a[text()='Select'])[1]"), TimeSpan.FromSeconds(5)) != null)
            {
                WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_companyNumbers']//a[text()='Select'])[1]")).Click(WebDriver);
                return new CreateQuotePage(WebDriver);
            }
            else
            {
                return new CreateQuotePage(WebDriver);
            }
        }

        public CustomerDetailsPage NavigateToCustomerDetailsPage(int Index)
        {
            CustomersInAccountDetailsPage(Index).Click(WebDriver);
            return new CustomerDetailsPage(WebDriver);
        }

        public OpportunityDetailsPage GoToOpportunityDetailsFromOpportunityList(string opportunityDealId)
        {

            WebDriver.GetElement(By.Id("opportunitiesResults-0-")).Click(WebDriver);
            //OpportunityGrid.GetElements(WebDriver, By.XPath(".//table//tbody//tr//a"))
            //    .Single(
            //        ele =>
            //            ele.GetAttribute("href") != null &&
            //            ele.GetAttribute("href").Contains(opportunityDealId))

            //    .Click(WebDriver); 
            return new OpportunityDetailsPage(WebDriver);
        }

        public AccountDetailsPage AddNewCustomer(string customerNumber)
        {
            LnkAddCustomerId.Click(WebDriver);
            TxtAddCustomerId.SetText(WebDriver, customerNumber);
            LnkAddCustomerIdSave.Click(WebDriver);
            return this;
        }

        public void ViewInSfdc()
        {
            // TODO: New SFDC page needs to be created and change the return type
            BtnMoreActions.Click(WebDriver);
            BtnViewInSfdc.Click(WebDriver);
        }

        public void ViewAccountTeam()
        {
            // TODO: New SFDC page needs to be created and change the return type.
            BtnMoreActions.Click(WebDriver);
            BtnViewAccountTeam.Click(WebDriver);
        }

        public int GetCustomerListRowCount(IWebDriver driver)
        {
            return CustomersGrid.GetHtmlTableData(driver).Count;
            //return WebDriver.GetHtmlTableData(_byCustomerListDiv).Count;
        }

        public string GetCustomerAccountNumber()
        {
            WebDriverUtil.VerifyBusyOverlayNotDisplayed(WebDriver);
            return LblAccountNumber.GetText(WebDriver);
        }

        public string GetCustomerPAMInfo()
        {
            return CustomerPAMInfo.GetText(WebDriver);
        }

        public CustomerDashboardPage ClickDashboardIcon()
        {
            DashboardIconForCustomer.Click(WebDriver);
            return new CustomerDashboardPage(WebDriver);
        }

        public AccountRevenuePage ClickRevenueIcon()
        {
            CustomerRevenueIcon.Click(WebDriver);
            return new AccountRevenuePage(WebDriver);
        }

        public List<Dictionary<string, object>> GetAccountResultsTable()
        {
            AccountResults.WaitForElement(WebDriver);
            return AccountResults.GetTableData(WebDriver);
        }
        #endregion
    }
}