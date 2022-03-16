using System;
using System.Linq;
using System.Collections.Generic;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;
using System.Threading;
using FluentAssertions;
using Dsa.Workflows;

namespace Dsa.Pages.Solutions.ManageAccounts
{
    public partial class BillToPage : DsaPageBase
    {
        public BillToPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        public int BillToFindResults()
        {
            IWebElement table = WebDriver.FindElement(By.XPath("//*[@id='favorites']/div/favorites-tab/div[2]/div/div/div/table/tbody"));
            ReadOnlyCollection<IWebElement> listOfRows = table.FindElements(By.TagName("tr"));

            return listOfRows.Count();
        }

        public int BillToFindResultsAPJnEMEA()
        {
            IWebElement table = WebDriver.FindElement(By.XPath("//table[@class='mat-table cdk-table ng-tns-c83-5']"));
            ReadOnlyCollection<IWebElement> listOfRows = table.FindElements(By.TagName("tr"));

            return listOfRows.Count();
        }

        public List<Dictionary<string, object>> GetResellerResultList()
        {
            return GridBillToResultList.GetGridData(WebDriver);
        }

        public List<Dictionary<string, object>> GetBillToResultsPage()
        {
            return GridBillToResultList.GetTableDataMABillTo(WebDriver);
        }
      

        public bool getValidationErrorMessage()
        {
            try
            {
                return NoRecordsErrorMsg.Displayed;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
        }

        //Non Disti user navigates Bill to page to Ship to page
        public BillToPage SelectPaymentTypeNonDisti()
        {
            var billTo = new BillToPage(WebDriver);
            //Verify is there any records displaying under any pament type
            billTo.NetTermsRadioButton.IsElementClickable(WebDriver).Should().BeTrue();
            if (billTo.getValidationErrorMessage())
            {
                billTo.ThirdPartyRadioButton.Click(WebDriver);
            }
            else if (billTo.BillToFindResults() >= 1)
            {
                billTo.BillToRow1Select.IsElementClickable(WebDriver).Should().BeTrue();
                billTo.BillToRow1Select.Click(WebDriver);
                //Navigate back from reseller page to bill to page
                new ShipToPage(WebDriver).BillToChangeButtonNonDisti.Click(WebDriver);
                billTo.ThirdPartyRadioButton.Click(WebDriver);
            }

            //Select Third pary payment type 
            if (billTo.BillToFindResults() < 1 && billTo.getValidationErrorMessage())
            {
                billTo.PrepaidRadioButton.Click(WebDriver);
            }
            else if (billTo.BillToFindResults() >= 1)
            {
                billTo.BillToRow1Select.IsElementClickable(WebDriver).Should().BeTrue();
                billTo.BillToRow1Select.Click(WebDriver);
                //Navigate back from reseller page to bill to page
                new ShipToPage(WebDriver).BillToChangeButtonNonDisti.Click(WebDriver);
                billTo.PrepaidRadioButton.Click(WebDriver);
            }
            //Prepaid
            if (billTo.BillToFindResults() < 1 && billTo.getValidationErrorMessage())
            {
                Logger.Write("No records display");
            }
            else if (billTo.BillToFindResults() >= 1)
            {
                billTo.BillToRow1Select.IsElementClickable(WebDriver).Should().BeTrue();
                billTo.BillToRow1Select.Click(WebDriver);
            }

            return new BillToPage(WebDriver);

        }


        //Distributor user navigates to the reseller page from Bill To Page

        public BillToPage SelectPaymentTypeDisti()
        {
            var billTo = new BillToPage(WebDriver);
            //Verify is there any records displaying under any pament type
            billTo.NetTermsRadioButton.IsElementClickable(WebDriver).Should().BeTrue();
            if (billTo.BillToFindResults() >= 1)
            {
                billTo.BillToRow1Select.IsElementClickable(WebDriver).Should().BeTrue();
                billTo.BillToRow1Select.Click(WebDriver);
                //Navigate back from reseller page to bill to page
                new ResellerPage(WebDriver).BillToChangeButton.Click(WebDriver);
                billTo.ThirdPartyRadioButton.Click(WebDriver);

            }
            else if (billTo.BillToFindResults() < 1 && billTo.getValidationErrorMessage())
            {
                billTo.ThirdPartyRadioButton.Click(WebDriver);
            }
            //Select Third pary payment type 

            if (billTo.BillToFindResults() < 1 && billTo.getValidationErrorMessage())
            {
                billTo.PrepaidRadioButton.Click(WebDriver);
            }
            else if (billTo.BillToFindResults() >= 1)
            {
                billTo.BillToRow1Select.IsElementClickable(WebDriver).Should().BeTrue();
                billTo.BillToRow1Select.Click(WebDriver);
                //Navigate back from reseller page to bill to page
                new ResellerPage(WebDriver).BillToChangeButton.Click(WebDriver);
                billTo.PrepaidRadioButton.Click(WebDriver);
            }

            //Prepaid
            if (billTo.BillToFindResults() < 1 && billTo.getValidationErrorMessage())
            {
                Logger.Write("No records display");

            }
            else if (billTo.BillToFindResults() >= 1)
            {
                billTo.BillToRow1Select.IsElementClickable(WebDriver).Should().BeTrue();
                billTo.BillToRow1Select.Click(WebDriver);
            }
            return new BillToPage(WebDriver);

        }

        public BillToPage SelectPaymentTypeDistiNoResults()
        {
            var billTo = new BillToPage(WebDriver);
            billTo.NetTermsRadioButton.Click(WebDriver);
            if (billTo.BillToFindResults() < 1 && billTo.getValidationErrorMessage())
            {
                Logger.Write("No records display");
                billTo.ThirdPartyRadioButton.Click(WebDriver);

            }

            else if (billTo.BillToFindResults() < 1 && billTo.getValidationErrorMessage())
            {
                Logger.Write("No records display");
                billTo.PrepaidRadioButton.Click(WebDriver);
            }
            else if (billTo.BillToFindResults() < 1 && billTo.getValidationErrorMessage())
            {
                Logger.Write("No records display");
            }


            return new BillToPage(WebDriver);
        }

        public BillToPage SelectAPJnEMEApaymentType()
        {
            var billTo = new BillToPage(WebDriver);
            //Verify is there any records displaying under any pament type
            billTo.NetTermsRadioButton.IsElementClickable(WebDriver).Should().BeTrue();
            if (billTo.BillToFindResultsAPJnEMEA() < 1 || billTo.getValidationErrorMessage())
                //if (billTo.BillToFindResults() < 1 && billTo.getValidationErrorMessage())
                {
                billTo.ThirdPartyRadioButton.Click(WebDriver);
            }
            else if (billTo.BillToFindResultsAPJnEMEA() >= 1)
            {

                billTo.ExpandResult.Click(WebDriver);
                WebDriver.VerifyBusyOverlayNotDisplayed();
                billTo.SelectResult.Click(WebDriver);
                //Navigate back from reseller page to bill to page
                new ResellerPage(WebDriver).BillToChangeButton.Click(WebDriver);
                billTo.ThirdPartyRadioButton.Click(WebDriver);
            }
            //Select Third pary payment type 

            if (billTo.BillToFindResultsAPJnEMEA() < 1 || billTo.getValidationErrorMessage())
            {
                billTo.PrepaidRadioButton.Click(WebDriver);
            }
            else if (billTo.BillToFindResultsAPJnEMEA() >= 1)
            {

                billTo.ExpandResult.Click(WebDriver, TimeSpan.FromSeconds(5));

                billTo.ExpandResult.Click(WebDriver);
                WebDriver.VerifyBusyOverlayNotDisplayed();
                billTo.SelectResult.Click(WebDriver);

                //Navigate back from reseller page to bill to page
                new ResellerPage(WebDriver).BillToChangeButton.Click(WebDriver);
                billTo.PrepaidRadioButton.Click(WebDriver);
            }

            //Prepaid
            if (billTo.BillToFindResultsAPJnEMEA() >= 1)

            {
                billTo.ExpandResult.Click(WebDriver, TimeSpan.FromSeconds(5));
                WebDriver.VerifyBusyOverlayNotDisplayed();
                billTo.SelectResult.Click(WebDriver);

            }
            else if (billTo.BillToFindResultsAPJnEMEA() < 1 || billTo.getValidationErrorMessage())
            {
                Logger.Write("No records display");

            }
            return new BillToPage(WebDriver);

        }

        public MailToPage SelectBillToAPJ()
        {
            if (UseAsBillToCust.Displayed)
            {
                UseAsBillToCust.Click(WebDriver);
            }
            else
            {
                if (BillToFindResultsAPJnEMEA() >= 1)
                {
                    ExpandResult.Click(WebDriver);
                    SelectResult.Click(WebDriver);
                    WebDriver.VerifyBusyOverlayNotDisplayed();
                }
                else
                {
                    SelectPaymentTypeDisti();
                }
                
            }
            return new MailToPage(WebDriver);
        }

        public void WaitForElementLoadAndSwitchFrame()
        {
            DsaUtil.WaitForPageLoad(WebDriver);
            Thread.Sleep(5000);
            WebDriver.SwitchTo().Frame(1);
        }

        public void delay(int timeInSeconds)
        {
            Thread.Sleep(timeInSeconds * 1000);
        }


        #region Billto Elements


        public IWebElement BillToHeader { get { return WebDriver.GetElement(By.XPath("//*[@id='ma-customer-selection']/div[2]/div/dsa-ma-bill-to/div/h3")); } }

        public IWebElement BillToAllCustomersTab { get { return WebDriver.GetElement(By.Id("customers-tab")); } }

        public IWebElement PatchedEUCustDetailsPannel { get { return WebDriver.GetElement(By.XPath("//div[@id='return-EndCustomer-data']//section[@id='customer-Section-']")); } }

        public IWebElement BillToFavoritesTab { get { return WebDriver.GetElement(By.Id("favorites-tab")); } }


        public IWebElement ExpandResult { get { return WebDriver.GetElement(By.XPath("//tr[1]//td[1]//div[1]//i[1]")); } }

        public IWebElement SelectResult { get { return WebDriver.GetElement(By.XPath("//mat-row[1]//mat-cell[4]//button[1]")); } }

        public IWebElement BillToRow1Select { get { return WebDriver.GetElement(By.XPath("//mat-row[1]//mat-cell[9]//button[1]")); } }

        public IWebElement BillToRowOneInfo { get { return WebDriver.GetElement(By.XPath("//tbody/tr[1]")); } }

        public IWebElement PatchedBillToInfo { get { return WebDriver.GetElement(By.XPath("//div[@id='customerdetail-BillTo']")); } }

        public IWebElement NetTermsRadioButton { get { return WebDriver.GetElement(By.XPath("(.//*[@id='[object Object]'])[1]")); } }

        public IWebElement PrepaidRadioButton { get { return WebDriver.GetElement(By.XPath("(.//*[@id='[object Object]'])[2]")); } }

        public IWebElement ThirdPartyRadioButton { get { return WebDriver.GetElement(By.XPath("(.//*[@id='[object Object]'])[3]")); } }

        public IWebElement SelectDifferEntendUserText { get { return WebDriver.GetElement(By.XPath("//*[@id='ma-customer-selection']/div[2]/div/dsa-ma-bill-to/div/div[1]")); } }

        public IWebElement NetTermsRadioButtonTxt { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Net Terms (Default)')]")); } }

        public IWebElement PrepaidRadioButtonTxt { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),' Prepaid (Credit Card, Wire Transfer, Prepaid Check) ')]")); } }

        public IWebElement ThirdPartyRadioButtonTxt { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Third Party Funding')]")); } }

        public IWebElement CompanyName { get { return WebDriver.GetElement(By.XPath("//th[contains(text(),'Company Name')]")); } }

        public IWebElement CompanyAddress { get { return WebDriver.GetElement(By.XPath("//th[contains(text(),'Company Address')]")); } }

        public IWebElement CustomerNumber { get { return WebDriver.GetElement(By.XPath("//th[contains(text(),'Customer Number')]")); } }

        public IWebElement ContactName { get { return WebDriver.GetElement(By.XPath("//mat-header-cell[contains(text(),'Contact Name')]")); } }

        public IWebElement Terms { get { return WebDriver.GetElement(By.XPath("//th[contains(text(),'Terms')]")); } }

        public IWebElement Currency { get { return WebDriver.GetElement(By.XPath("//th[contains(text(),'Currency')]")); } }

        public IWebElement PhoneNumber { get { return WebDriver.GetElement(By.XPath("//mat-header-cell[contains(text(),'Phone Number')]")); } }

        public IWebElement EmailAddress { get { return WebDriver.GetElement(By.XPath("//mat-header-cell[contains(text(),'Email Address')]")); } }

        public IWebElement BillToSelectRowOne { get { return WebDriver.GetElement(By.XPath("//mat-row[1]//mat-cell[9]//button[1]")); } }

        public IWebElement NoRecordsErrorMsg { get { return WebDriver.GetElement(By.XPath("//div[@class='dds__error-body']")); } }

        public IWebElement GridBillToResultList { get { return WebDriver.GetElement(By.XPath("//*[@id='ma-customer-selection']/div[2]/div/dsa-ma-bill-to/div/div")); } }

        public IWebElement BillToTextMsg { get { return WebDriver.GetElement(By.XPath("//div[contains(text(),'Select you Bill To customer.If you can't find the')]")); } }

        public IWebElement UseAsBillToCust { get { return WebDriver.GetElement(By.XPath("//button[contains(text(),'Use as Bill To Customer')]")); } }
        
        public IWebElement SoldToLHS { get { return WebDriver.GetElement(By.XPath("//div[@id='return-SoldTo-data']//div[@id='customerdetail-']")); } }

        public IWebElement ChangeLinkSoldTo { get { return WebDriver.GetElement(By.XPath("//div[@id='return-SoldTo-data']//button")); } }

        
        #endregion

    }

}
