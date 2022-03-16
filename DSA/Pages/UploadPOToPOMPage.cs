using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Dsa.Utils;
//using Dsa.Util;
using System.IO;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;

namespace Dsa.Pages
{
    public class UploadPOToPOMPage : DsaPageBase
    {
        public UploadPOToPOMPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region -- Elements --


public IWebElement UploadPOPopup { get { return WebDriver.GetElement(By.Id("orderCreate_send_poRequest")); } }


public IWebElement UploadPOToPOMHeader { get { return WebDriver.GetElement(By.Id("orderCreate_sendPoRequest_header")); } }


public IWebElement UploadNewPOHeader { get { return WebDriver.GetElement(By.Id("orderCreate_new_pomIdRequest_header")); } }


public IWebElement CloseUploadPOToPOMWindow { get { return WebDriver.GetElement(By.XPath("//div[@id='orderCreate_send_poRequest']//span[@class='icon-ui-close']")); } }


public IWebElement LnkUploadPO { get { return WebDriver.GetElement(By.Id("quoteSaveAsOrderPayment_UploadPo")); } }


public IWebElement BtnChooseFile { get { return WebDriver.GetElement(By.Id("orderCreate_pomFileUpload_chooseFile")); } }


public IWebElement BtnQuoteChooseFile { get { return WebDriver.GetElement(By.Id("quoteDetail_pomFileUpload_chooseFile")); } }


public IWebElement BtnEnterFile { get { return WebDriver.GetElement(By.XPath("//*[@id='orderCreate_pomFileUpload_chooseFile']//input[@type='file'][1]")); } }


public IWebElement BtnQuoteEnterFile { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_pomFileUpload_chooseFile']//input[@type='file'][1]")); } }


public IWebElement LnkAddSupplementaryDoc { get { return WebDriver.GetElement(By.XPath("//button[@data-c-file-selector-input-id='orderCreate_pomFileUpload_supplementaryPOUpload']/span[1]")); } }


public IWebElement TxtPomid { get { return WebDriver.GetElement(By.Id("orderCreate_sendPoRequest_pomId")); } }


public IWebElement DdlDestinationWrkGrp { get { return WebDriver.GetElement(By.XPath("//select[@id='orderCreate_sendPoRequest_destinationWorkgroup']")); } }


public IWebElement DdlQuoteDestinationWrkGrp { get { return WebDriver.GetElement(By.XPath("//select[@id='quoteDetail_sendPoRequest_destinationWorkgroup']")); } }


public IWebElement TxtCustomerNumber { get { return WebDriver.GetElement(By.Id("orderCreate_sendPoRequest_customerNumber")); } }


public IWebElement TxtCustomerName { get { return WebDriver.GetElement(By.Id("orderCreate_sendPoRequest_customerName")); } }


public IWebElement RdbPOSourceEmail { get { return WebDriver.GetElement(By.Id("orderCreate_sendPoRequest_poSourceAddress_emailSelect")); } }


public IWebElement RdbPOSourceFax { get { return WebDriver.GetElement(By.Id("orderCreate_sendPoRequest_poSourceAddress_faxSelect")); } }


public IWebElement DdlPOSourceAddress { get { return WebDriver.GetElement(By.XPath("//select[@id='orderCreate_sendPoRequest_poSourceAddressList_emailValue']")); } }


public IWebElement DdlQuotePOSourceAddress { get { return WebDriver.GetElement(By.XPath("//select[@id='quoteDetail_sendPoRequest_poSourceAddressList_emailValue']")); } }


public IWebElement TxtCustomEmailAddress { get { return WebDriver.GetElement(By.Id("orderCreate_sendPoRequest_poSourceAddress_emailValue")); } }


public IWebElement TxtFaxNumber { get { return WebDriver.GetElement(By.Id("orderCreate_sendPoRequest_poSourceAddress_faxValue")); } }


public IWebElement TxtSaleRepNumber { get { return WebDriver.GetElement(By.Id("orderCreate_sendPoRequest_salesRepNumber")); } }


public IWebElement TxtQuoteNumber { get { return WebDriver.GetElement(By.Id("orderCreate_sendPoRequest_quoteNumbers")); } }


public IWebElement TxtPONumber { get { return WebDriver.GetElement(By.Id("orderCreate_sendPoRequest_poNumber")); } }


public IWebElement TxtPOAmount { get { return WebDriver.GetElement(By.Id("orderCreate_sendPoRequest_poAmount")); } }


public IWebElement TxtQuotePONumber { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_poNumber")); } }


public IWebElement TxtQuotePOAmount { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_poAmount")); } }


public IWebElement TxtPOComments { get { return WebDriver.GetElement(By.Id("orderCreate_sendPoRequest_comments")); } }


public IWebElement ChkCreditCardPO { get { return WebDriver.GetElement(By.Id("orderCreate_sendPoRequest_creditCardPO")); } }


public IWebElement ChkBlanketPO { get { return WebDriver.GetElement(By.Id("orderCreate_sendPoRequest_blanketPO")); } }


public IWebElement BtnSend { get { return WebDriver.GetElement(By.Id("orderCreate_sendPoRequest_send")); } }


public IWebElement BtnQuoteSend { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_send")); } }


public IWebElement BtnCancel { get { return WebDriver.GetElement(By.Id("orderCreate_sendPoRequest_cancel")); } }


public IWebElement BtnYes { get { return WebDriver.GetElement(By.XPath("//button[@id='orderCreate_sendPoRequest_close' and text()='Yes']")); } }


public IWebElement BtnQuoteYes { get { return WebDriver.GetElement(By.XPath("//button[@id='quoteDetail_sendPoRequest_close' and text()='Yes']")); } }


public IWebElement BtnNo { get { return WebDriver.GetElement(By.XPath("//button[@id='orderCreate_sendPoRequest_close' and text()='No']")); } }


public IWebElement BtnOk { get { return WebDriver.GetElement(By.XPath("//button[@id='orderCreate_sendPoRequest_close' and text()='Ok']")); } }


public IWebElement BtnQuoteOk { get { return WebDriver.GetElement(By.XPath("//button[@id='quoteDetail_sendPoRequest_close' and text()='Ok']")); } }


public IWebElement POMIDSuccess { get { return WebDriver.GetElement(By.XPath("//h4[text()='Success!']")); } }


public IWebElement POMIdnumber { get { return WebDriver.GetElement(By.XPath("//*[@id='orderCreate_send_poRequest']/div[2]/div[3]/label")); } }


public IWebElement QuotePOMIdnumber { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_send_poRequest']/div[2]/div[3]/label")); } }


public IWebElement NewPOMpopup { get { return WebDriver.GetElement(By.XPath("//*[@id='orderCreate_new_pomIdRequest']")); } }


public IWebElement LnkCreateNewPOM { get { return WebDriver.GetElement(By.XPath("//a[@id='orderCreate_new_pomIdRequest_createNew']")); } }

public IWebElement UseExistingPOM { get { return WebDriver.GetElement(By.XPath("//a[@data-ng-click='sendPoRequest(pomResult.pomId)']")); } }

public IWebElement AddSuppDoc { get { return WebDriver.GetElement(By.XPath("//button[@data-c-file-selector-input-id='orderCreate_pomFileUpload_addAdddemdumPOUpload']")); } }
public IWebElement QuoteAddSuppDoc { get { return WebDriver.GetElement(By.XPath("//button[@data-c-file-selector-input-id='quoteDetail_pomFileUpload_addAdddemdumPOUpload']")); } }

public IWebElement BtnEnterSuppFile { get { return WebDriver.GetElement(By.XPath("//*[@id='orderCreate_pomFileUpload_addAdddemdumPOUpload']")); } }
public IWebElement QuoteBtnEnterSuppFile { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_pomFileUpload_addAdddemdumPOUpload']")); } }

public IWebElement SuccessTextContent { get { return WebDriver.GetElement(By.XPath("//label[@data-ng-if='model.isEditPom']")); } }

public IWebElement SuccessTextHeader { get { return WebDriver.GetElement(By.XPath("//div[@data-ng-show='model.success']/h4")); } }

public IWebElement PONumberEdit { get { return WebDriver.GetElement(By.XPath("//input[contains(@id,'sendPoRequest_poNumberEdit')]")); } }
public IWebElement POAmountEdit { get { return WebDriver.GetElement(By.XPath("//input[contains(@id,'sendPoRequest_poAmountEdit')]")); } }

public IWebElement CCpoCheckboxLabel { get { return WebDriver.GetElement(By.XPath("//div[contains(@class,'send-po-req')]//div[@class='checkbox-grp'][1]//label")); } }
public IWebElement PrimaryPOFile { get { return WebDriver.GetElement(By.XPath("//div[contains(@ng-repeat,'pomData.files')]/div")); } }
        #endregion

        #region New POM ID pop up elements
public IWebElement HeaderText { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_new_pomIdRequest_header']")); } }
public IWebElement ContentText1 { get { return WebDriver.GetElement(By.XPath("//new-pom-id-quote//h5[1]")); } }
public IWebElement ContentText2 { get { return WebDriver.GetElement(By.XPath("//new-pom-id-quote//h5[2]")); } }
public IWebElement ContentText3 { get { return WebDriver.GetElement(By.XPath("//new-pom-id-quote//h5[3]")); } }
public IWebElement MatchingListTable { get { return WebDriver.GetElement(By.XPath("//table[contains(@class,'pomSimpleGrid')]//thead")); } }
public IWebElement NewPOMIdCloseIcon { get { return WebDriver.GetElement(By.XPath("//new-pom-id-quote//span[contains(@class,'ui-close')]")); } }

public IWebElement PaymentHeaderText { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'_new_pomIdRequest_header')]")); } }
public IWebElement PaymentContentText1 { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'_new_pomIdRequest_header')]//following::h5[1]")); } }
public IWebElement PaymentContentText2 { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'_new_pomIdRequest_header')]//following::h5[2]")); } }
public IWebElement PaymentContentText3 { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'_new_pomIdRequest_header')]//following::h5[3]")); } }

public IWebElement CreateNewPOMIdBtn { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'_new_pomIdRequest_createNew')]")); } }
public IWebElement NewPOMIdCancel { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'_new_pomIdRequest_cancel')]")); } }
public IWebElement PaymentNewPOMIdCloseIcon { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'_new_pomIdRequest')]//span[contains(@class,'ui-close')]")); } }


        #endregion
        #region -- Methods --

        public string GeneratePOMFile(string fileType = null)
        {
            string pomFile = null;
            System.IO.StreamWriter file = null;
            if (fileType == null)
                pomFile = @"C:\Temp\POMIDFile.txt";
            else
                pomFile = @"C:\Temp\SupplementaryPOMIDFile.txt";
            try
            {
                if (!Directory.Exists(@"C:\Temp"))
                    Directory.CreateDirectory(@"C:\Temp");
                if (!File.Exists(pomFile))
                {
                    file = new System.IO.StreamWriter(File.Create(pomFile));
                    file.WriteLine("This is for uploadong a POM file");
                }
            }
            catch (Exception ex) {
                Logger.Write("Error: " + ex);

            }
            finally
            {
                if (file.BaseStream != null)
                {
                    file.Close();
                }
            }

            return pomFile;
        }

        public void WaitforUploadPOToPOMPageDisplay()
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

        public void WaitforQuoteUploadPOToPOMPageDisplay()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            By ExistCreateNew = By.Id("quoteDetail_new_pomIdRequest_createNew");
            By CreateNew = By.Id("quoteDetail_pomFileUpload_chooseFile");
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

        public void SavePO()
        {
            BtnSend.Click(WebDriver);
            BtnYes.Click(WebDriver);
            if (POMIDSuccess.Displayed)
                Logger.Write("The Pom Id generated successfully!");
            BtnOk.Click(WebDriver);

        }

        public string SavePOGetPOMID()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            js.ExecuteScript("arguments[0].click()", BtnSend);
            BtnYes.Click(WebDriver);
            if (POMIDSuccess.Displayed)
                Logger.Write("The Pom Id generated successfully!");
            return POMIdnumber.GetText(WebDriver);
        }

        public string SaveQuotePOGetPOMID()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            js.ExecuteScript("arguments[0].click()", BtnQuoteSend);
            BtnQuoteYes.Click(WebDriver);
            if (POMIDSuccess.Displayed)
                Logger.Write("The Pom Id generated successfully!");
            return QuotePOMIdnumber.GetText(WebDriver);
        }

        public void ClickAndEnterpath(string path)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            js.ExecuteScript("arguments[0].click()", BtnChooseFile);
            BtnEnterFile.SendKeys(path);
        }

        public void ClickAndEnterpathQuote(string path)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            js.ExecuteScript("arguments[0].click()", BtnQuoteChooseFile);
            BtnQuoteEnterFile.SendKeys(path);
        }

        public void AddSupplementaryDocumentPath(string path)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            js.ExecuteScript("arguments[0].click()", AddSuppDoc);
            BtnEnterSuppFile.SendKeys(path);
        }

        public void QuoteAddSupplementaryDocumentPath(string path)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            js.ExecuteScript("arguments[0].click()", QuoteAddSuppDoc);
            QuoteBtnEnterSuppFile.SendKeys(path);
        }

        public List<string> GetAndVerifyPomIdsListValues(List<string> pomIds)
        {
            List<IWebElement> allExistingPomids = WebDriver.GetElements(By.XPath("//*[@id='quoteDetail_new_pomIdRequest']//td[1]/a"));
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

        public void VerifyMatchingListTableValues(List<string> newPOMIdsList, List<string> poNumbers, List<string> poTotal, List<string> workGroup)
        {
            //verify all pom id and its corresponding pototal/workgroup/po numbers

            for (int i = 0; i < poNumbers.Count(); i ++)
            {
                string s = "POM ID #" + newPOMIdsList[i];
                Assert.IsTrue(WebDriver.FindElement(By.XPath("//tbody//tr[" + (i + 1) + "]//a[contains(@id,'pomIdRequest_useExisting')]")).GetText(WebDriver).Contains(s));
                Assert.IsTrue(WebDriver.FindElement(By.XPath("//table[contains(@class,'pomSimpleGrid')]//tbody//tr[" + (i + 1) + "]//td[2]")).GetText(WebDriver).Contains(poNumbers[i]));
                Assert.IsTrue(WebDriver.FindElement(By.XPath("//table[contains(@class,'pomSimpleGrid')]//tbody//tr[" + (i + 1) + "]//td[3]")).GetText(WebDriver).Contains(poTotal[i]));
                Assert.IsTrue(WebDriver.FindElement(By.XPath("//table[contains(@class,'pomSimpleGrid')]//tbody//tr[" + (i + 1) + "]//td[4]")).GetText(WebDriver).Contains(workGroup[i]));
                Assert.IsTrue(WebDriver.FindElement(By.XPath("//table[contains(@class,'pomSimpleGrid')]//tbody//tr[" + (i + 1) + "]//td[5]/a")).IsElementDisplayed(WebDriver));
            }
        }

        public void VerifyPopupAndClickOnAnyPOMIdLink(ref string poNumber, ref string pomID)
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            By ExistCreateNew = By.XPath("//*[contains(@id,'_new_pomIdRequest_createNew')]");
            By CreateNew = By.XPath("//*[contains(@id,'_pomFileUpload_chooseFile')]");
            try
            {
                if (WebDriver.ElementExists(ExistCreateNew))
                {
                    Logger.Write("There are existing POM ids to use - clicking on Create new POM id");
                    int i = WebDriver.FindElements(By.XPath("//table[contains(@class,'pomSimpleGrid')]//tbody//tr")).Count();

                    pomID = WebDriver.FindElement(By.XPath("//tbody//tr[1]//a[contains(@id,'pomIdRequest_useExisting')]")).GetText(WebDriver);
                    poNumber = WebDriver.FindElement(By.XPath("//table[contains(@class,'pomSimpleGrid')]//tbody//tr[1]//td[2]")).GetText(WebDriver);

                    WebDriver.FindElement(By.XPath("//table[contains(@class,'pomSimpleGrid')]//tbody//tr[1]//a[contains(@id,'pomIdRequest_useExisting')]")).Click(WebDriver);
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

        public void VerifyPopupAndClickSelectOnAnyPOMIdLink(ref string poNumber, ref string pomID)
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            By ExistCreateNew = By.XPath("//*[contains(@id,'_new_pomIdRequest_createNew')]");
            By CreateNew = By.XPath("//*[contains(@id,'_pomFileUpload_chooseFile')]");
            try
            {
                if (WebDriver.ElementExists(ExistCreateNew))
                {
                    Logger.Write("There are existing POM ids to use - clicking on Create new POM id");
                    int i = WebDriver.FindElements(By.XPath("//table[contains(@class,'pomSimpleGrid')]//tbody//tr")).Count();

                    pomID = WebDriver.FindElement(By.XPath("//tbody//tr[2]//a[contains(@id,'pomIdRequest_useExisting')]")).GetText(WebDriver);
                    poNumber = WebDriver.FindElement(By.XPath("//table[contains(@class,'pomSimpleGrid')]//tbody//tr[2]//td[2]")).GetText(WebDriver);

                    WebDriver.FindElement(By.XPath("//table[contains(@class,'pomSimpleGrid')]//tbody//tr[2]//td[5]/a")).Click(WebDriver);
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

        public void VerifyPOMIdLinkForB2BRejectPOOnQuoteDetails(ref string pomId)
        {
            int i = WebDriver.FindElements(By.XPath("//table[contains(@class,'pomSimpleGrid')]//tbody//tr")).Count();

            for(int j = 1; j < i; j ++)
            {
                if(!WebDriver.FindElement(By.XPath("//tbody/tr[" + j + "]/td[1]")).GetAttribute("title").Contains("POM ID"))
                {
                    string s = WebDriver.FindElement(By.XPath("//tbody/tr[" + j + "]/td[1]")).GetAttribute("title");
                    Assert.AreEqual("Upload not available at this time for BRB Reject PO", s);
                    Assert.IsTrue(WebDriver.FindElement(By.XPath("//tbody/tr[" + j + "]/td[5]")).Enabled);
                    pomId = WebDriver.FindElement(By.XPath("//tbody/tr[" + j + "]/td[1]")).GetText(WebDriver);
                }
            }            
        }

        public void VerifyPOMIdLinkForB2BRejectPOOnPayment(string pomId)
        {
            int i = WebDriver.FindElements(By.XPath("//table[contains(@class,'pomSimpleGrid')]//tbody//tr")).Count();

            for (int j = 1; j < i; j++)
            {
                if (WebDriver.FindElement(By.XPath("//table[contains(@class,'pomSimpleGrid')]//tbody//tr[" + j + "]//td[1]/a")).GetAttribute("title").Contains("Upload"))
                {                   
                    Assert.Fail("B2B reject po is not excluded from matching list on Payment page");
                }
                else
                {
                    Assert.IsFalse(WebDriver.FindElement(By.XPath("//table[contains(@class,'pomSimpleGrid')]//tbody//tr[" + j + "]//td[1]/a")).GetText(WebDriver).Contains(pomId));
                }
            }
        }
        #endregion
    }
}
