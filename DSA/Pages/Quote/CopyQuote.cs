using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using HomeWorkFlow = Dsa.Workflows.HomeWorkflow;


namespace Dsa.Pages.Quote
{
    public class CopyQuote : DsaPageBase
    {
		private IWebDriver webDriver;

		public CopyQuote(IWebDriver webDriver)
			: base(webDriver)
		{
			Name = "Copy Quote Page";
			this.webDriver = webDriver;
			PageFactory.InitElements(webDriver, this);
			webDriver.VerifyBusyOverlayNotDisplayed();
		}

        public CreateQuotePage CopyQuoteByQuoteNumber(string quoteNumber)
        {
            HomeWorkFlow.GoToQuoteSearchPage(webDriver).QuoteSearchByQuoteNumber(quoteNumber);
            new QuoteDetailsPage(webDriver).WaitForQuoteValidationToComplete();

            //Copy Quote
            return new QuoteDetailsPage(webDriver).CopyQuote(false);           

        }
    }
}
