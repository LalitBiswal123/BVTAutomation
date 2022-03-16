using Dsa.Pages.Quote;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
    public class AssociateOpportunityPage : DsaPageBase
    {
         public AssociateOpportunityPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement BtnAssociateOpportunityNext { get { return WebDriver.GetElement(By.Id("opportunityAssociateQuote_submitAction")); } }


public IWebElement BtnNextStep { get { return WebDriver.GetElement(By.Id("opportunityAssociation_nextstep")); } }


public IWebElement BtnUpdateOpportunityItemNext { get { return WebDriver.GetElement(By.Id("associateQuoteStep3_next")); } }


public IWebElement BtnDoneDeleteOpportunityItems { get { return WebDriver.GetElement(By.Id("delete_selected_items_done")); } }


public IWebElement ChkDisplayAllItems { get { return WebDriver.GetElement(By.Id("_allItems")); } }

        #endregion

        #region Methods

        public AssociateOpportunityPage SelectOpportunity(string opportunityId)
        {
            WebDriver.GetElement(By.XPath("//input[contains(@data-ng-click, '" + opportunityId + "')]"))
                .Click(WebDriver);
            BtnAssociateOpportunityNext.Click(WebDriver);
            return new AssociateOpportunityPage(WebDriver);
        }

        public AssociateOpportunityPage NextStepAfterSelectingLineItemsToConnect()
        {
            BtnNextStep.Click(WebDriver);
            return new AssociateOpportunityPage(WebDriver);
        }

        public AssociateOpportunityPage DisplayAllItems()
        {
            ChkDisplayAllItems.Click(WebDriver);
            return new AssociateOpportunityPage(WebDriver);
        }

        public AssociateOpportunityPage SelectOpportunityLineItem(string lineitemId)
        {
            WebDriver.GetElement(By.Id(lineitemId)).Click(WebDriver);
            return new AssociateOpportunityPage(WebDriver);
        }

        public AssociateOpportunityPage UpdateOpportunityNext()
        {
            BtnUpdateOpportunityItemNext.Click(WebDriver);
            return new AssociateOpportunityPage(WebDriver);
        }

        public QuoteDetailsPage DoneDeleteOpportunityItems()
        {
            BtnDoneDeleteOpportunityItems.Click(WebDriver);
            return new QuoteDetailsPage(WebDriver);
        }

        #endregion
    }
}
