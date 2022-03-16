using Dsa.Pages.Quote;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Opportunity
{
    public class OpportunityUpdatePage : DsaPageBase
    {
        public OpportunityUpdatePage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement HdrUpdateOpportunity { get { return WebDriver.GetElement(By.Id("quoteSaveUpdateRevenue_UpdateOpportunity")); } }


public IWebElement DivUpdateOpportunityItems { get { return WebDriver.GetElement(By.Id("quoteSaveUpdateRevenue_commonInfo")); } }


public IWebElement BtnUpdateOpportunityNext { get { return WebDriver.GetElement(By.Id("quoteSaveUpdateRevenue_next")); } }


public IWebElement BtnUpdateOpportunitySkip { get { return WebDriver.GetElement(By.Id("quoteSaveUpdateRevenue_skip")); } }


public IWebElement BtnUpdateOpportunitySkipNoItemToUpdate { get { return WebDriver.GetElement(By.Id("quoteSaveUpdateRevenue_skipNoItemsToUpdate")); } }

        #endregion

        public QuoteDetailsPage UpdateOpportunity(bool updateOpportunity = true)
        {
            if (updateOpportunity)
                BtnUpdateOpportunityNext.Click(WebDriver);
            else
                BtnUpdateOpportunitySkip.Click(WebDriver);

            return new QuoteDetailsPage(WebDriver);
        }

        public QuoteDetailsPage SkipUpdateOpportunityWhenNoItemsAvailable()
        {
            BtnUpdateOpportunitySkipNoItemToUpdate.Click(WebDriver);
            return new QuoteDetailsPage(WebDriver);
        }
    }
}
