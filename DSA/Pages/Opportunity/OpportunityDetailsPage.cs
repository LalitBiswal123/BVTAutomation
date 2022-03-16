using System.Collections.Generic;
using System.Linq;
using Dsa.Pages.Account;
using Dsa.Pages.Quote;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Opportunity
{
   public class OpportunityDetailsPage : DsaPageBase
    {
       public OpportunityDetailsPage(IWebDriver webDriver) : base(webDriver)
       {
           PageFactory.InitElements(webDriver, this);
       }

       #region Elements


public IWebElement LblOpportunityName { get { return WebDriver.GetElement(By.Id("opportunityDetailName")); } }


public IWebElement BtnCreateQuote { get { return WebDriver.GetElement(By.Id("opportunityDetail_createQuote")); } }


public IWebElement LnkAccountName { get { return WebDriver.GetElement(By.Id("opportunityDetail_accountName")); } }


public IWebElement LblSfdcDealId { get { return WebDriver.GetElement(By.Id("opportunityDetail_dealId")); } }


public IWebElement BtnViewInSfdc { get { return WebDriver.GetElement(By.Id("opportunityDetail_viewInSfdc")); } }


public IWebElement LnkMoreActions { get { return WebDriver.GetElement(By.Id("opportunityDetail_moreActions")); } }


public IWebElement LnkViewAccountUnderMoreActions { get { return WebDriver.GetElement(By.Id("opportunityDetail_viewAccount")); } }


public IWebElement LnkViewCustomerUnderMoreActions { get { return WebDriver.GetElement(By.Id("opportunityDetail_viewCustomer")); } }


public IWebElement LnkAssociateQuoteUnderMoreActions { get { return WebDriver.GetElement(By.Id("opportunityDetail_associateQuote")); } }


public IWebElement BtnExpandItemsToggle { get { return WebDriver.GetElement(By.Id("opportunityDetails_opportunityProductsToggle")); } }


public IWebElement BtnExpandAssociatedQuotesToggle { get { return WebDriver.GetElement(By.Id("opportunityDetail_associatedQuotesToggle")); } }


public IWebElement BtnExpandAssociatedOrdersToggle { get { return WebDriver.GetElement(By.Id("opportunityDetails_associatedOrdersToggle")); } }


public IWebElement GridOpportunityLineItems { get { return WebDriver.GetElement(By.Id("opportunityDetails_productGrid")); } }


public IWebElement DivAssociatedQuotes { get { return WebDriver.GetElement(By.Id("opportunityDetails_associatedQuotesGrid")); } }


public IWebElement DivAssociatedOrders { get { return WebDriver.GetElement(By.Id("opportunityDetails_associatedOrdersGrid")); } }


public IWebElement LnkItemsViewAll { get { return WebDriver.GetElement(By.Id("opportunityDetails_itemListViewAll")); } }


public IWebElement LnkAssociatedQuotesViewAll { get { return WebDriver.GetElement(By.Id("opportunityDetails_quoteListViewAll")); } }


public IWebElement LnkAssociatedOrdersViewAll { get { return WebDriver.GetElement(By.Id("opportunityDetails_orderListViewAll")); } }


public IWebElement DivAssociatedQuotesViewAll { get { return WebDriver.GetElement(By.Id("quoteSearchResults_Grid")); } }


public IWebElement DivAssociatedOrdersViewAll { get { return WebDriver.GetElement(By.Id("orderSearchResults_Grid")); } }


public IWebElement LblDealRegistrationStatusLabel { get { return WebDriver.GetElement(By.Id("opportunityDetail_dealRegistrationStatus_label")); } }


public IWebElement LblDealRegistrationStatus { get { return WebDriver.GetElement(By.Id("opportunityDetail_dealRegistrationStatus")); } }


public IWebElement DivOpportunityDetails { get { return WebDriver.GetElement(By.Id("opportunityDetail_opportunityDetails")); } }


public IWebElement LblUnweightedRevenue { get { return WebDriver.GetElement(By.Id("opportunityDetail_unweightedRevenue")); } }


public IWebElement LblWeightedRevenue { get { return WebDriver.GetElement(By.Id("opportunityDetail_weightedRevenue")); } }


public IWebElement BtnDisassociateConfirmationYes { get { return WebDriver.GetElement(By.Id("messageDialogButton_0")); } }

       #endregion
       
       public AccountDetailsPage GoToAccountDetails()
       {
           LnkAccountName.Click(WebDriver);
           return new AccountDetailsPage(WebDriver);
       }

       public CreateQuotePage CreateQuote()
       {
           LblUnweightedRevenue.WaitUntilTextChanges(WebDriver, "00");      // This is important as it waits till page is loaded completely loaded.
           BtnCreateQuote.Click(WebDriver);
           return new CreateQuotePage(WebDriver);
       }

       public OpportunityDetailsPage DisassociateQuote(string quoteNumberWithVersion, bool expandQuoteList = true, bool viewAll = false)
       {
           if (expandQuoteList)
               BtnExpandAssociatedQuotesToggle.Click(WebDriver);
           if (viewAll)
           {
               LnkAssociatedQuotesViewAll.Click(WebDriver);
               DivAssociatedQuotesViewAll.GetElements(WebDriver, By.XPath(".//tbody//tr"))
                   .Single(a => a.Text.Contains(quoteNumberWithVersion))
                   .FindElement(By.LinkText("Disassociate"))
                   .Click(WebDriver);
           }
           else
           {
               DivAssociatedQuotes.GetElements(WebDriver, By.XPath(".//tbody//tr"))
                   .Single(a => a.Text.Contains(quoteNumberWithVersion))
                   .FindElement(By.LinkText("Disassociate"))
                   .Click(WebDriver);
           }

           BtnDisassociateConfirmationYes.Click(WebDriver);
           return new OpportunityDetailsPage(WebDriver);
       }

       public Dictionary<string, string> GetItemFromItemListByOpportunityLineId(string lineItemId, bool expandItemsToggle = true)
       {
           Dictionary<string, string> tableData = new Dictionary<string, string>();
           if (expandItemsToggle) BtnExpandItemsToggle.Click(WebDriver);

           var headercolumns = GridOpportunityLineItems.GetElements(WebDriver, By.XPath(".//thead//tr//th")).Select(a => a.Text).ToList();
           var row = GridOpportunityLineItems.FindElement(By.XPath(".//tbody//tr//td[contains(text(), '" + lineItemId + "')]//.."));
           int tdCount = 1;
           var tds = row.GetElements(WebDriver, By.XPath(".//td"));
           foreach (var td in tds)
           {
               tableData.Add(headercolumns[tdCount - 1], td.Text);
               tdCount += 1;
           }

           return tableData;
       }
    }
}
