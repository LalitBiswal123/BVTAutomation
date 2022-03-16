using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa.Pages
{
    public class PremierPages : DsaPageBase
    {
        public PremierPages(IWebDriver webDriver)
           : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement PremierPagesTable { get { return WebDriver.GetElement(By.Id("Premier_View_All_Page_grid")); } }

        #endregion

        public StandardConfigurationPage OpenPremierPage(string rcno)
        {
            //Get Premierpagetable
            var allRCno = GetPremierPagesTable();
            //Filter a row based on RC#
            for (int i = 0; i < allRCno.Count; i++)
            {
                var premierStore = allRCno[i];
                var isMatchingPremierStore = string.Equals(premierStore["RC#"].ToString(), rcno, StringComparison.InvariantCultureIgnoreCase);
                if (isMatchingPremierStore)
                {
                    var buttonId = string.Format("//*[@id='button_Open_{0}_']", i);
                    // click on Open
                    WebDriver.FindElement(By.XPath(buttonId)).Click();
                    return new StandardConfigurationPage(WebDriver);
                }
            }        

            return new StandardConfigurationPage(WebDriver);
        }

        public List<Dictionary<string, object>> GetPremierPagesTable()
        {
            return PremierPagesTable.GetHtmlTableData(WebDriver);
        }
    }
}