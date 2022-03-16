using System;
using System.Collections.Generic;
using Dsa.Constants;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using OpenQA.Selenium.Interactions;
using Keys = OpenQA.Selenium.Keys;
using OpenQA.Selenium.Support.UI;

namespace Dsa.Pages
{
   public class CustomerCommunicationPage : DsaPageBase
    {
        public const string CfoHistoryTitlePageHeader = "cfoHistory_CustomerOutput";
        public const string Cfogrid = "grid_paging_itemsPerPage";
        public const string CfoResendEmail = "resendCFOEmail_send";


public IList<IWebElement> DateSentColumn { get { return WebDriver.GetElements(By.XPath("//div[@id = 'DataTables_div_']//tr/td[2]")); } }

        public CustomerCommunicationPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements


public IWebElement CfoHistoryDocumentSearch { get { return WebDriver.GetElement(By.Id("cfoHistory_documentNumber")); } }


public IWebElement TxtDocumentNumber { get { return WebDriver.GetElement(By.Id("CustomerOutput_DocumentNumber")); } }


public IWebElement LblCfoHistoryDPIDSearch { get { return WebDriver.GetElement(By.Id("cfoHistory_orderDpid_label")); } }


public IWebElement LblCfoHistoryQuoteSearch { get { return WebDriver.GetElement(By.Id("cfoHistory_quoteNumber_label")); } }


public IWebElement LblCfoHistoryDocumentSearch { get { return WebDriver.GetElement(By.Id("cfoHistory_documentNumber_label")); } }


public IWebElement CfoHistoryGrid { get { return WebDriver.GetElement(By.Id("cfo_historyGrid")); } }


public IWebElement HdrCfoHistoryTitlePage { get { return WebDriver.GetElement(By.Id("cfoHistory_CustomerOutput")); } }


public IWebElement CfoHistoryDateFilter { get { return WebDriver.GetElement(By.XPath("(//label[@class='control-label']/parent::div/select)[2]")); } }


public IWebElement CfoHistoryOutputTypeFilter { get { return WebDriver.GetElement(By.XPath(".//*[@id='main']/descendant::select[1]")); } }


public IWebElement CfoOutputTypeOptionSelect { get { return WebDriver.GetElement(By.XPath("//*[@id='cfoHistory_outputType']/option[2]")); } }


public IWebElement CfoHistoryCustomerFilter { get { return WebDriver.GetElement(By.Id("quoteCfoSearch_customer")); } }


public IWebElement CfoHistorySentByFilter { get { return WebDriver.GetElement(By.Id("cfoHistory_dateRange_sentBy")); } }


public IWebElement ChkboxCfoHistoryRecord { get { return WebDriver.GetElement(By.Id("cfoHistory_{0}")); } }


public IWebElement CfoHistoryResendQuote { get { return WebDriver.GetElement(By.Id("resend_{0}")); } }


public IWebElement HdrCfoResend { get { return WebDriver.GetElement(By.Id("resendCFOEmail_header")); } }


public IWebElement ChkboxCfoResend { get { return WebDriver.GetElement(By.Id("resendCFOEmail_checkBox")); } }


public IWebElement CfoResendEmailTextArea { get { return WebDriver.GetElement(By.Id("resendCFOEmail_originalRecipients")); } }


public IWebElement BtnCfoResendSend { get { return WebDriver.GetElement(By.Id("resendCFOEmail_send")); } }


public IWebElement BtnCfoResendCancel { get { return WebDriver.GetElement(By.Id("resendCFOEmail_cancel")); } }


public IWebElement BtnCfoResendClose { get { return WebDriver.GetElement(By.Id("resendCFOEmail_close")); } }


public IWebElement CfoOutputTypePopUp { get { return WebDriver.GetElement(By.Id("_cfoViewDocument")); } }


public IWebElement CfoResultTbl { get { return WebDriver.GetElement(By.Id("DataTables_Table_0")); } }


public IWebElement TxtCustomerNumber { get { return WebDriver.GetElement(By.Id("CustomerOutput__CustomerNumber")); } }


public IWebElement BtnProFormaView { get { return WebDriver.GetElement(By.XPath("//a[contains(@id,'view_')]")); } }


public IWebElement BtnProFormaResend { get { return WebDriver.GetElement(By.XPath("//a[contains(@id,'resend_')]")); } }


public IWebElement CC_DPID { get { return WebDriver.GetElement(By.XPath("//a[contains(@id,'resend_')]")); } }


public IWebElement verifyDocument { get { return WebDriver.GetElement(By.XPath("//iframe[@id='_viewDocumentContent']")); } }


public IWebElement ResendEmail { get { return WebDriver.GetElement(By.XPath("//input[@id='resendCFOEmail_originalRecipients']")); } }


public IWebElement ResendCancel { get { return WebDriver.GetElement(By.XPath("//button[@id='resendCFOEmail_cancel']")); } }


public IWebElement ResendSend { get { return WebDriver.GetElement(By.XPath("//button[@id='resendCFOEmail_send']")); } }


public IWebElement BtnCloseProForma { get { return WebDriver.GetElement(By.XPath("//div[@class='modal-close']/a")); } }


public IWebElement BtnView1stRow { get { return WebDriver.GetElement(By.XPath("(//view-resend-button-template/a[contains(text(),'View')])[1]")); } }


public IWebElement BtnResendOrSend1stRow { get { return WebDriver.GetElement(By.XPath("(//view-resend-button-template/a[contains(text(),'Send') or contains(text(),'Resend')])[1]")); } }

        // 

public IWebElement BtnResend1stRow { get { return WebDriver.GetElement(By.XPath("//a[normalize-space()='Resend'][1]")); } }


public IWebElement ResendCfoEmailDialog { get { return WebDriver.GetElement(By.Id("resendCFOEmailDailog")); } }


public IWebElement NoitemsinList { get { return WebDriver.GetElement(By.ClassName("data-grid-msg")); } }


public IWebElement BtnSearch { get { return WebDriver.GetElement(By.Id("CustomerOutput_CfoSearch")); } }


public IWebElement TxtCustomerNo { get { return WebDriver.GetElement(By.Id("_quoteCfoSearch_customer")); } }


public IWebElement TxtSalesRepid { get { return WebDriver.GetElement(By.Id("_quoteCfoSearch_cfoSalesRepNumber")); } }


public IWebElement BtnView { get { return WebDriver.GetElement(By.XPath(".//*[@id='DataTables_Table_']//td[9]/add-component/view-resend-button-template/a[1]")); } }


public IWebElement Lbl1stDPIDQuoteNumberGRID { get { return WebDriver.GetElement(By.XPath("(//table[@id='DataTables_Table_']//td[1])[1]")); } }


public IWebElement Lbl1stCustomerNumberGRID { get { return WebDriver.GetElement(By.XPath("(//table[@id='DataTables_Table_']//td[5]/a)[1]")); } }



public IWebElement BtnCloseView { get { return WebDriver.GetElement(By.XPath(".//*[@id='cfoViewDocument']/div[1]/a/span")); } }
       

public IWebElement BtnResend { get { return WebDriver.GetElement(By.XPath(".//*[@id='DataTables_Table_']//td[9]/add-component/view-resend-button-template/a[2]")); } }


public IWebElement DropDownDateRange { get { return WebDriver.GetElement(By.XPath("(//label[@class='control-label']/parent::div/select)[2]")); } }


public IWebElement TxtBoxSalesRepID { get { return WebDriver.GetElement(By.Id("CustomerOutput_cfoSalesRepNumber")); } }


public IWebElement BusyOverLay { get { return WebDriver.GetElement(By.XPath("//div[@class='inline-busy-block']/i")); } }

        #endregion

        public List<Dictionary<string, object>> GetCfoHistoryGridRecords()
        {
            WebDriverUtil.IsBusyElementDisplayed(By.XPath("//div[@class='inline-busy-block']/i)"), WebDriver);
            WebDriverUtil.WaitUntilElementDisappers(WebDriver, By.XPath("//div[@class='inline-busy-block']/i"), 50);
            return WebDriver.GetHtmlTableData(By.Id(QuoteIDs.CfoHistoryGrid));
          
        }

        public void OutputType_ProForma()
        {
            CfoHistoryOutputTypeFilter.Select().SelectByText("Proforma Invoice");
        }

        public void CustCommunication_DPID(string DPID)
        {
            CC_DPID.SendKeys(DPID);
        }

        public void ClickViewProForma(string DPID)
        {
            WebDriver.FindElement(By.Id("view_"+DPID)).Click();
            
           }
        public void VerifyViewProForma()
        {
           if (verifyDocument.Displayed)
            {
                Actions act = new Actions(WebDriver);
                act.SendKeys(OpenQA.Selenium.Keys.Escape).Build().Perform();
             }

        }

        public void ClickResendProForma(string DPID)
        {
            var i = "resend_"+DPID;
            WebDriver.FindElement(By.Id(i)).Click();
        }

        public void VerifyResendProForma(string Email,string DPID)
        {
            ResendCancel.Click();
            new CustomerCommunicationPage(WebDriver).ClickResendProForma(DPID);
            ResendEmail.Clear();
            ResendEmail.SendKeys(Email);
            ResendSend.Click();

        }

        public CustomerCommunicationPage ClickViewButton()
        {
            BtnView1stRow.Click();
            return this;
        }

        public CustomerCommunicationPage ClickResendButton()
        {
            BtnResend1stRow.Click();
            return this;
        }

       public bool IsResendCfoDialog()
       {
           try
           {
               return ResendCfoEmailDialog.Displayed;
           }
           catch (Exception)
           {
               
               return false;
           }
       }

      public void AppendEmailResend(string email)
       {
           var previousText = CfoResendEmailTextArea.GetAttribute("Value");
           CfoResendEmailTextArea.Clear();
           CfoResendEmailTextArea.SendKeys(previousText + "," + email);
           BtnCfoResendSend.Click();
       }

       public bool NoItemsinList()
       {
           return NoitemsinList.Displayed;
       }

       public void EnterDocumentNumber(string documentNumber)
       {
           CfoHistoryDocumentSearch.Clear();
           CfoHistoryDocumentSearch.SendKeys(documentNumber);
           CfoHistoryDocumentSearch.SendKeys(Keys.Tab);
       }

       public bool VerifyDateRangeOptionSelected(string dropDownValue)
       {
           try
           {
               if (WebDriverUtil.WaitForElementDisplay(WebDriver, DropDownDateRange, TimeSpan.FromSeconds(1)))
               {
                   foreach (IWebElement ele in new SelectElement(DropDownDateRange).Options)
                   {
                        if (ele.Selected)
                        {
                            if(ele.Text.Contains(dropDownValue))
                                return true;
                        }
                           
                   }          
               }

           }
           catch (System.Exception) { }
           return false;
       }

       public void SelectDateRangeByValue(string dropDownValue)
       {
           try
           {
               if (WebDriverUtil.WaitForElementDisplay(WebDriver, DropDownDateRange, TimeSpan.FromSeconds(1)))
               {
                   SelectElement DateRange = new SelectElement(DropDownDateRange);
                   DateRange.SelectByValue(dropDownValue);                  
               }

           }
           catch (System.Exception) { }

       }

        public bool VerifyOutputTypeSelected(string dropDownText)
        {
            try
            {
                if (WebDriverUtil.WaitForElementDisplay(WebDriver, CfoHistoryOutputTypeFilter, TimeSpan.FromSeconds(1)))
                {
                    foreach (IWebElement ele in new SelectElement(CfoHistoryOutputTypeFilter).Options)
                    {
                        if(ele.Selected)
                        {
                            if (ele.Text.Contains(dropDownText))
                                return true;
                        }
                    }
                }

            }
            catch (System.Exception) { }
            return false;
        }

        public void SelectOutputTypeByText(string dropDownText)
        {
            try
            {
                if (WebDriverUtil.WaitForElementDisplay(WebDriver, CfoHistoryOutputTypeFilter, TimeSpan.FromSeconds(1)))
                {
                    SelectElement DateRange = new SelectElement(CfoHistoryOutputTypeFilter);
                    DateRange.SelectByText(dropDownText);
                }

            }
            catch (System.Exception) { }

        }

        public IWebElement ViewButton()
        {
            return WebDriver.GetElement(By.XPath("//tr[@class='odd ng-star-inserted']//a[@class='grid-btn'][contains(text(),'View')]"));
        }

        public IWebElement GetViewElement(int index)
        {
            return WebDriver.GetElement(By.XPath($"(//a[text() = 'View'])[{index}]"));
        }

        public IList<string> GetAllDate()
        {
            IList<string> allDate = new List<string>();
            

            for (int i = 0; i < DateSentColumn.Count; i ++)
            {
                string date = DateSentColumn[i].Text;

                 DateTime dateTime = Convert.ToDateTime(date);
                 string finalDate =  dateTime.ToString("MMMM dd, yyyy");
                 allDate.Add(finalDate);
            }
            return allDate;
        }

        public IWebElement Language(string rowNumber)
        {
            return WebDriver.FindElement(By.XPath($"((//table[@id = 'DataTables_Table_']//td)[3])[{rowNumber}]"));
        }
    }
}
