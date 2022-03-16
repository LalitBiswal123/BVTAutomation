using OpenQA.Selenium.Support.PageObjects;
using Dsa.Utils;
using OpenQA.Selenium;
using System;

namespace Dsa.Pages
{
    public class StandardConfigurationPage : DsaPageBase
    {
        public StandardConfigurationPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
                

public IWebElement RCDetailsGrid { get { return WebDriver.GetElement(By.Id("Standard_Config_RCDetails_grid")); } }


public IWebElement RCDetailsTable { get { return WebDriver.GetElement(By.Id("DataTables_div_rcdetails")); } }
        
        /// <summary>
        /// Selects the first category.
        /// </summary>
        public void SelectACategory()
        {
            var categoryElementId = "//*[@id='Standard_Config_RCDetails_0_group']//span";
            var categoryAsElement = WebDriver.GetElement(By.XPath(categoryElementId));
            if (categoryAsElement != null)
            {
                categoryAsElement.Click();
            }

            WebDriver.VerifyBusyOverlayNotDisplayed();
        }

        /// <summary>
        /// Clicks on Add to Quote button.
        /// </summary>
        public void AddConfigsToQuote()
        {
           var quoteBtnId = string.Format("button_Add to Quote_{0}_", 0);
          
            if(IsAddConfigsToQuoteEnabled(quoteBtnId) ==true)
            {
                 WebDriver.GetElement(By.Id(quoteBtnId)).Click();
            }
        }

        /// <summary>
        /// Checks if a specified Add to Quote button is enabled.
        /// </summary>
        /// <param name="quoteBtnId"></param>
        /// <returns></returns>
        public bool IsAddConfigsToQuoteEnabled(string quoteBtnId)
        {
            if (RCDetailsTable.IsElementDisplayed(WebDriver))
            {
                WebDriver.GetElement(By.Id(quoteBtnId)).IsElementClickable(WebDriver, TimeSpan.FromSeconds(10));
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks if any Add to Quote button is enabled.
        /// </summary>
        /// <returns></returns>
        public bool CanAddAnyConfigToQuote()
        {
            var canAdd = false;

            if(RCDetailsTable.IsElementDisplayed(WebDriver))
            {
                var rcTableData = RCDetailsTable.GetHtmlTableData(WebDriver);
                if(rcTableData != null && rcTableData.Count > 0)
                {
                    var totalCount = rcTableData.Count - 1;
                    while (totalCount >= 0 && canAdd == false)
                    {
                        var quoteBtnId = string.Format("button_Add to Quote_{0}_", totalCount);
                        canAdd = IsAddConfigsToQuoteEnabled(quoteBtnId);

                        totalCount--;
                    }
                }
            }

            return canAdd;
        }
    }
}  