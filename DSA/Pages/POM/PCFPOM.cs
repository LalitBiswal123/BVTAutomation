//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Utils;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace Dsa.Pages.POM
{
    public class PCFPOM : DsaPageBase
    {
        public static TimeSpan GlobalWaitTime = TimeSpan.FromSeconds(60);
        public PCFPOM(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "POM";
            PageFactory.InitElements(webDriver, this);
            webDriver.VerifyBusyOverlayNotDisplayed();
        }

       

        #region Convergence Payment Page - New POM ID pop up-MFE

       
        public IWebElement SelectPOMIDtoAssociateHeader { get { return WebDriver.GetElement(By.XPath("//h2[@class='dds__modal-title dds__modal-header']")); } }
        public IWebElement ExistingPOMIDtext { get { return WebDriver.GetElement(By.XPath("//h5[contains(text(),'Existing POM IDs were found for the Customer/PO')]")); } }

        public List<IWebElement> ExistingPOMIDs { get { return WebDriver.GetElements(By.XPath("//pom-id-list//table[@class='dds__table dds__table-striped']//td[1]')]")); } }
        
        public IWebElement DontseePOMIDtext { get { return WebDriver.GetElement(By.XPath("//h5/b[contains(text(),'Don't see POM ID to Associate?')]")); } }        
        public IWebElement NewPOMIDPopupText2 { get { return WebDriver.GetElement(By.XPath("//h5[contains(text(),'- Click the POM ID # to upload supplementary docum')]")); } }
        public IWebElement GridHeaderPOMID { get { return WebDriver.GetElement(By.XPath("//th[normalize-space()='POM ID']")); } }
        public IWebElement GridHeaderPoNumber { get { return WebDriver.GetElement(By.XPath("//th[normalize-space()='PO Number']")); } }
        public IWebElement GridHeaderPoAmount { get { return WebDriver.GetElement(By.XPath("//th[normalize-space()='PO Amount']")); } }
        public IWebElement GridHeaderWorkgroup { get { return WebDriver.GetElement(By.XPath("//th[normalize-space()=' Workgroup']")); } }
        public IWebElement BodyPOMID_FirstValue { get { return WebDriver.GetElement(By.XPath("//html[1]//table[1]//tbody[1]//tr[1]//td[1]")); } }
        public IWebElement BodyPONumber_FirstValue { get { return WebDriver.GetElement(By.XPath("//html[1]//table[1]//tbody[1]//tr[1]//td[2]")); } }
        public IWebElement BodyPOAmount_FirstValue { get { return WebDriver.GetElement(By.XPath("//html[1]//table[1]//tbody[1]//tr[1]//td[3]")); } }
        public IWebElement BodyWorkgroup_FirstValue { get { return WebDriver.GetElement(By.XPath("//html[1]//table[1]//tbody[1]//tr[1]//td[4]")); } }
        public IWebElement BodySelectBtn_FirstValue { get { return WebDriver.GetElement(By.XPath("//tbody[1]/tr[1]/td[5]/button[1]")); } }
        public IWebElement CancelBtn_NewPOMIDpopup { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='Cancel']")); } }
        public IWebElement CreateNewPOMIDbutton { get { return WebDriver.GetElement(By.XPath("//button[@id='pomIdRequest_createNew']")); } }

        #region addendum
        public IWebElement uploadAddendumTitle { get { return WebDriver.GetElement(By.XPath("//h3[@id='mat-dialog-title-0']")); } }
        public IWebElement AddendumPoNumberValue { get { return WebDriver.GetElement(By.XPath("//*[@id='uploadAddendumDialogContent']//div[2]/input[1]")); } }

        public IWebElement AddendumPoAmountValue { get { return WebDriver.GetElement(By.XPath("//*[@id='uploadAddendumDialogContent']//div[3]/input[1]")); } }



        #endregion addendum
        #region upload PO elements        
        public IWebElement UploadPOTitle { get { return WebDriver.GetElement(By.XPath("//label[normalize-space()='Upload Purchase Order (PO)']")); } }
        public IWebElement PrimaryPurchaseOrder { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='Choose File']")); } }                
        public IWebElement UploadPODialogClose { get { return WebDriver.GetElement(By.Id("poDialogCloseX")); } }        
        public IWebElement BtnEnterFilePrimary { get { return WebDriver.GetElement(By.XPath("//*[normalize-space()='Choose File']//input[@type='file']")); } }

        public IWebElement PoNumberLabel { get { return WebDriver.GetElement(By.XPath("//div[normalize-space()='PO Number(s)']")); } }
        public IWebElement PoNumberValue { get { return WebDriver.GetElement(By.XPath("//*[@id='poDialogContent']//div[2]/input[1]")); } }

        public IWebElement PoAmountLabel { get { return WebDriver.GetElement(By.XPath("//div[normalize-space()='PO Amount(s)']")); } }
        public IWebElement PoAmountValue { get { return WebDriver.GetElement(By.XPath("//*[@id='poDialogContent']//div[3]/input[1]")); } }

        public IWebElement CreditCardPOCheckbox { get { return WebDriver.GetElement(By.XPath("//input[@id='creditcard-po']")); } }
        public IWebElement CreditCardPOLabel { get { return WebDriver.GetElement(By.XPath("//label[@for='creditcard-po']//span")); } }
        public IWebElement BlanketPOCheckbox { get { return WebDriver.GetElement(By.XPath("//input[@id='blanket-po']")); } }
        public IWebElement BlanketPOLabel { get { return WebDriver.GetElement(By.XPath("//input[@id='blanket-po']//span")); } }
        public IWebElement DestinationWorkGroup { get { return WebDriver.GetElement(By.XPath("//label[normalize-space()='Destination Workgroup']")); } }
        public IWebElement PickaWorkgroupDropdown { get { return WebDriver.GetElement(By.XPath("//div[@id='dest-workgroups']//select")); } }
        public IWebElement PoSourceLabel { get { return WebDriver.GetElement(By.XPath("//label[normalize-space()='PO Source Address']")); } }
        public IWebElement PoSourceEmailCheckbox { get { return WebDriver.GetElement(By.XPath("//span[normalize-space()='Email']")); } }
        public IWebElement PickanEmailAddress { get { return WebDriver.GetElement(By.XPath("//select[@id='pu-email-data']")); } }
        public IWebElement PoSourceFaxCheckbox { get { return WebDriver.GetElement(By.XPath("//span[normalize-space()='Fax']")); } }
        public IWebElement EnterFaxBox { get { return WebDriver.GetElement(By.XPath("//input[@id='pu-fax-data']")); } }
        public IWebElement CommentsLabel { get { return WebDriver.GetElement(By.XPath("//label[normalize-space()='Comments (Optional)']")); } }
        public IWebElement CommentsTextBox { get { return WebDriver.GetElement(By.XPath("//textarea[@id='po-comments']")); } }
        public IWebElement CustomerNameLabel { get { return WebDriver.GetElement(By.XPath("//label[normalize-space()='Customer Name (Optional)']")); } }
        public IWebElement CustomerName { get { return WebDriver.GetElement(By.XPath("//input[@id='customer-name']")); } }
        public IWebElement CustomerNumberLabel { get { return WebDriver.GetElement(By.XPath("//label[normalize-space()='Customer Number']")); } }
        public IWebElement CustomerNumber { get { return WebDriver.GetElement(By.XPath("//input[@id='customer-no']")); } }
        public IWebElement SalesRepNumberLabel { get { return WebDriver.GetElement(By.XPath("//label[normalize-space()='Sales Rep Number']")); } }
        public IWebElement SalesRepNumber { get { return WebDriver.GetElement(By.XPath("//input[@id='sales-rep-no']")); } }
        public IWebElement QuoteNumberLabel { get { return WebDriver.GetElement(By.XPath("//label[normalize-space()='Quote Number']")); } }
        public IWebElement QuoteNumber { get { return WebDriver.GetElement(By.XPath("//input[@id='quote-no']")); } }
        public IWebElement SaveButton { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='Save']")); } }
        public IWebElement CancelButton { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='Cancel']")); } }
        
        #endregion upload PO elements        

        public IWebElement BtnYes { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='Yes']")); } }
        public IWebElement BtnNo { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='No']")); } }
        public IWebElement POMIDNumber { get { return WebDriver.GetElement(By.XPath(".//*[@id='poDialogContent']//div/label")); } }
        public IWebElement BtnOk { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='Ok']")); } }
        public IWebElement POMIDSuccess { get { return WebDriver.GetElement(By.XPath("//h4[text()='Success!']")); } }


        #endregion Convergence Payment Page - New POM ID pop up

     

       

        


        #region common methods for uploading POM ID
        public void WaitforUploadPurchaseOrderPopupToDisplay()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            By ExistCreateNew = By.Id("orderCreate_new_pomIdRequest_createNew");
            By CreateNew = By.Id("orderCreate_pomFileUpload_chooseFile");
            try
            {
                if (WebDriver.ElementExists(ExistCreateNew))
                {
                    Logger.Write("There are existing POM ids to use - clicking on Create new POM id");
                    ExistCreateNew.Click(WebDriver);
                    WebDriver.VerifyBusyOverlayNotDisplayed();
                }
                else if (WebDriver.ElementExists(CreateNew))
                {
                    Logger.Write("There are no existing POM ids to use");
                }
            }
            catch (Exception e)
            {
                Logger.Write(e.Message);
            }
        }
        public void ClickAndEnterFilepath(string path)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            js.ExecuteScript("arguments[0].click()", PrimaryPurchaseOrder);
            BtnEnterFilePrimary.SendKeys(path);
        }
        public string SavePOAndGetPOMID()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            js.ExecuteScript("arguments[0].click()", SaveButton);
            BtnYes.Click(WebDriver);
            if (POMIDSuccess.Displayed)
                Logger.Write("The Pom Id generated successfully!");
            return POMIDNumber.GetText(WebDriver);
        }
        public void SaveAddendum()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            js.ExecuteScript("arguments[0].click()", SaveButton);
        }
        public void CreateFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Multiple file tests line");
                }
            }
            else if (File.Exists(path))
            {
                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine("Multiple file tests test next line!");
                }
            }
        }
        public void SelectWorkGroup(String WorkGroup)
        {
            PickaWorkgroupDropdown.IsElementClickable(WebDriver, TimeSpan.FromSeconds(25));
            PickaWorkgroupDropdown.PickDropdownByText(WebDriver, WorkGroup);
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
        }
        public List<string> GetAndVerifyPomIdsListValues(List<string> pomIds)
        {
            List<IWebElement> allExistingPomids = ExistingPOMIDs;
            List<string> list = new List<string>();

            for (int j = 0; j < allExistingPomids.Count(); j++)
            {
                list.Add(allExistingPomids[j].Text);
            }
            for (int i = 0; i < pomIds.Count(); i++)
            {
                string s = "POM ID #" + pomIds[i];
                Assert.IsTrue(list.Contains(s));
            }
            return pomIds;
        }
        public void RefreshPage()
        {
            WebDriver.RefreshCurrentPage();
           // string dpid = GetDpidFromOrderDetails();
        }


        public static string UploadPo(IWebDriver driver, string comments, string poNumber,string path,string destWrkGrp)
        {
            PCFPOM convergencePOM = new PCFPOM(driver);

            
            convergencePOM.WaitforUploadPurchaseOrderPopupToDisplay();
            convergencePOM.SelectPOMIDtoAssociateHeader.IsElementVisible().Should().Be(true);
            convergencePOM.CreateNewPOMIDbutton.Click();
            driver.PCFVerifyBusyOverlayNotDisplayed();
            convergencePOM.UploadPOTitle.IsElementVisible().Should().Be(true);
            convergencePOM.ClickAndEnterFilepath(path);

            convergencePOM.PoNumberValue.SendKeys(poNumber);
            convergencePOM.PoAmountValue.SendKeys("129");
            convergencePOM.SelectWorkGroup(destWrkGrp);
            convergencePOM.PickanEmailAddress.PickDropdownByIndex(driver, 1);
            convergencePOM.CommentsTextBox.SendKeys(comments);

            string pomIDGen = convergencePOM.SavePOAndGetPOMID();
            Logger.Write(pomIDGen);
            string[] w1 = pomIDGen.Split(' ');
            Logger.Write("POM Id generated: " + w1[3].TrimStart('#'));
            convergencePOM.BtnOk.Click(driver);
            return w1[3].TrimStart('#');
        }    
        
        #endregion
    }
}
