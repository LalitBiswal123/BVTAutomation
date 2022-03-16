using Dsa.Pages.Quote;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;

namespace Dsa.Pages.Order
{
    public class ExportCompliancePage : DsaPageBase
    {
        public ExportCompliancePage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement RdoBtnExportNo { get { return WebDriver.GetElement(By.Id("orderCreate_noRadio")); } }


public IWebElement RdoBtnExportYes { get { return WebDriver.GetElement(By.Id("orderCreate_yesRadio")); } }


public IWebElement ExportProductUsage { get { return WebDriver.GetElement(By.Id("orderCreate_productUsage")); } }


public IWebElement ExportProductCountry { get { return WebDriver.GetElement(By.Id("orderCreate_countryCode")); } }

        ////[FindsBy(How = How.Id, Using = "orderCreate_exportcompliance_next")]
        //[FindsBy(How = How.XPath, Using = "//button[normalize-space()='Next']")]
        //public IWebElement BtnExportComplianceNext;
        public IWebElement BtnExportComplianceNext { get { return WebDriver.GetElement(By.XPath("//button[@id='ContinueLink']")); } }


        //[FindsBy(How = How.XPath, Using = "//button[@id='orderCreate_exportcompliance_cancel' and contains(text(), 'Cancel')]")]

public IWebElement BtnExportCancel { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='Cancel']")); } }


public IWebElement PaymentPageText { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteSaveAsOrderStepProgess_stepName' and contains(text(), 'Payment')]")); } }


public IWebElement ExpandedDPID { get { return WebDriver.GetElement(By.XPath("//div[@class='accordion-inner']")); } }


public IWebElement PONumber { get { return WebDriver.GetElement(By.XPath("//p//b[contains(text(),'PO Number')]//following::div[1]")); } }


public IWebElement BillToCustomer { get { return WebDriver.GetElement(By.XPath("//b[contains(text(),'Bill to Customer')]//following::div[1]")); } }


public IWebElement BillToAddress { get { return WebDriver.GetElement(By.XPath("//b[contains(text(),'Bill to Address')]//following::div[1]")); } }


public IWebElement CreatedDate { get { return WebDriver.GetElement(By.XPath("//b[contains(text(),'Created Date')]//following::div[1]")); } }


public IWebElement FinalPrice { get { return WebDriver.GetElement(By.XPath("//b[contains(text(),'Final Price')]//following::div[1]")); } }


public IWebElement SoldToCustomer { get { return WebDriver.GetElement(By.XPath("//b[contains(text(),'Sold to Customer')]//following::div[1]")); } }


public IWebElement SoldToAddress { get { return WebDriver.GetElement(By.XPath("//b[contains(text(),'Sold to Address')]//following::div[2]")); } }


public IList<IWebElement> DPIDList { get { return WebDriver.GetElements(By.XPath("//div[@class='ng-star-inserted']//span//following-sibling::a")); } }

        #endregion

        #region Methods

        public EmailConfirmationPage WillNotExportOutsideUs()
        {
            QuoteDetailsPage quoteDetailsPage = new QuoteDetailsPage(WebDriver);
            WebDriver.WaitForElementDisplay(By.Id("chkContinueWithDuplOrder"), TimeSpan.FromSeconds(10));
            bool dupCheck = quoteDetailsPage.duplicateCheckCheckBoxYes.IsElementClickable(WebDriver, TimeSpan.FromSeconds(10));
            if (dupCheck)
            {
                quoteDetailsPage.duplicateCheckCheckBoxYes.Click(WebDriver);
                quoteDetailsPage.duplicateCheckContinue.Click(WebDriver);
            }


            //ExportProductUsage.PickDropdownByText(WebDriver, "Home");
            //RdoBtnExportNo.Click(WebDriver);
            if (BtnExportComplianceNext.Enabled)
            {
                BtnExportComplianceNext.Click(WebDriver);
            }            
            return new EmailConfirmationPage(WebDriver);
        }

        public EmailConfirmationPage DuplicateORderCheckPopUp()
        {

            QuoteDetailsPage quoteDetailsPage = new QuoteDetailsPage(WebDriver);
            bool dupOrderCheck = false;
            bool dupCheck = quoteDetailsPage.duplicateCheckCheckBoxYes.IsElementClickable(WebDriver, TimeSpan.FromSeconds(10));
            if (dupCheck)
            {
                dupOrderCheck = true;
            }
            return new EmailConfirmationPage(WebDriver);
        }

        public QuoteDetailsPage ExportComplianceCancel()
        {
            BtnExportCancel.Click(WebDriver);
            // CheckForServiceOverrideError();
            return new QuoteDetailsPage(WebDriver);
        }

        #endregion
    }
}
