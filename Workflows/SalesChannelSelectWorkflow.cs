using Dsa.Utils;
using OpenQA.Selenium;

namespace Dsa.Workflows
{
    public class SalesChannelSelectWorkflow
    {
        #region Select Sales Channel by Company Number
        //public static void SelectSalesChannelByCompanyNumber(IWebDriver driver, string companyNumber)
        //{
        //    var companyId = ValidateCompany.GetCompanyNumberIdFromDatabase(companyNumber);

        //    if (companyId == null) return;
        //    var elementById = By.Id(string.Format("companyNumberSelect_Grid_select_{0}", companyId));
        //    driver.ScrollAndClick(elementById);
        //}

        #endregion

        #region Select Company Number
        public static void SelectCompanyNumber(IWebDriver driver, string companynumber)
        {
            var rows = driver.GetElements(By.CssSelector("#DataTables_Table_companyNumbers > tbody > tr"));
            foreach (var row in rows)
            {
                if (row.FindElements(By.TagName("td"))[0].Text.StartsWith(companynumber))
                {
                    row.FindElements(By.TagName("button"))[0].Click();
                    break;
                }
            }
        }
        #endregion

    }
}
