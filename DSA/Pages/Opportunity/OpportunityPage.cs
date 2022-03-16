using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Opportunity
{
    public class OpportunityPage : DsaPageBase
    {
        public OpportunityPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        //TODO : Vinod

    }
}
