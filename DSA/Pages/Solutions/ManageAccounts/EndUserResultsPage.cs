using Dsa.Utils;
using Dsa.Workflows;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Dummy class
namespace Dsa.Pages.Solutions.ManageAccounts
{
    public partial class EndUserResultsPage : DsaPageBase
    {
        public EndUserResultsPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }


        //public List<Dictionary<string, object>> GetEndUserResultList()
        //{
        //    return GridEndUserResultList.GetGridData(WebDriver);
        //}

        //Dummy GetGridData return method

        public List<Dictionary<string, object>> GetEndUserResultList()
        {
            //WebDriver.SwitchTo().Frame(1);
            return GridEndUserResultList.GetGridData(WebDriver);
        }

        public IWebElement GetSelectButtonFromEndUserResults(int index)
        {
            ReadOnlyCollection<IWebElement> selectButtons =
            WebDriver.FindElements(By.XPath("//button[contains(text(), 'Select')]"));
            return selectButtons.ElementAt(index);
        }
        public List<Dictionary<string, object>> GetEUResultsPage()
        {
            GridEndUserResultList.WaitForElement(WebDriver);
            return GridEndUserResultList.GetTableDataMA(WebDriver);
        }

        public int FindResults()
        {
            IWebElement table = WebDriver.FindElement(By.XPath("//mat-table[@class='mat-table cdk-table dsa-table']"));
            ReadOnlyCollection<IWebElement> listOfRows = table.FindElements(By.TagName("mat-row"));

            return listOfRows.Count();
        }

        


        #region Elements
        //Dummy Locater
        //[FindsBy(How = How.Id, Using = "ma-customer-selection")]
        //public IWebElement GridEndUserResultList;


public IWebElement GridEndUserResultList { get { return WebDriver.GetElement(By.XPath("//mat-table[@class='dsa-table mat-table']")); } }

public IWebElement EndUserPannel { get { return WebDriver.GetElement(By.XPath("//h5[contains(text(),'End User')]")); } }

public IWebElement PatchedEUCustDetailsPannel { get { return WebDriver.GetElement(By.Id("customerdetail-EndCustomer")); } }

public IWebElement EndUserPannelText { get { return WebDriver.GetElement(By.XPath("//h5[contains(text(),'End User')]")); } }


public IWebElement EndUserResultsCompanyName { get { return WebDriver.GetElement(By.XPath("//mat-header-cell[contains(text(), 'Company Name')]")); } }

public IWebElement EndUserResultsComapanyAddress { get { return WebDriver.GetElement(By.XPath("//mat-header-cell[contains(text(),'Company Address')]")); } }

public IWebElement EUResultsCustomerNumber { get { return WebDriver.GetElement(By.XPath("//mat-header-cell[contains(text(),'Customer Number')]")); } }

public IWebElement EUResultsFirstRowAddress { get { return WebDriver.GetElement(By.XPath("//mat-row[1]//mat-cell[2]")); } }

public IWebElement EUResultsFirstRowCompanyName { get { return WebDriver.GetElement(By.XPath("/*[@id='end - user']//dsa-ma-end-user//end-user-search-result//dsa-ma-table//div//div[2]//table/tbody//tr[1]//td[1]")); } }

public IWebElement EndUserSelectButton { get { return WebDriver.GetElement(By.XPath("//button[@id='select_button_351750703369929328']")); } }

public IWebElement EURowOneSelectButton { get { return WebDriver.GetElement(By.XPath("//mat-row[1]//mat-cell[3]//button[1]")); } }

public IWebElement EURowTwoSelectButton { get { return WebDriver.GetElement(By.XPath("//mat-row[1]//mat-cell[3]//button[1]")); } }

public IWebElement EURowOneInfo { get { return WebDriver.GetElement(By.XPath("//mat-row[1]")); } }

public IWebElement RefineYourSearch { get { return WebDriver.GetElement(By.XPath("//button[contains(text(),'refine your search')]")); } }
        
public IWebElement NoRecordsMessage { get { return WebDriver.GetElement(By.XPath("//*[@id='ma-customer-selection']//div[2]//div//dsa-ma-end-user//end-user-search-result//legend")); } }

public IWebElement EndUserResultsFor { get { return WebDriver.GetElement(By.XPath("//div[@class='dds__mb-4']")); } }

public IWebElement DCNSearchResult { get { return WebDriver.GetElement(By.XPath("//mat-row[@id='dsa-table-row']//mat-cell[2]")); } }

public IWebElement EUResultsForCustomerType { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Customer Type:')]")); } }

public IWebElement EUResultsForCompanyName { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Company Name:')]")); } }

public IWebElement EUResultsForCountry { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Country:')]")); } }

public IWebElement EUResultsForCity { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'City:')]")); } }

public IWebElement EndUserName { get { return WebDriver.GetElement(By.Id("CompanyName-3")); } }


        #endregion

    }
}
