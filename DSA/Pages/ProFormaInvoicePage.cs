using System.Linq;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;
using System;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using System.Collections.Generic;

namespace Dsa.Pages
{
     public class ProFormaInvoicePage : DsaPageBase
    {
         public ProFormaInvoicePage(IWebDriver webDriver): base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

         
        #region Elements


public IWebElement PID { get { return WebDriver.GetElement(By.ClassName("nav-subtext ng-binding")); } }


public IWebElement SKUNumberDisplay { get { return WebDriver.GetElement(By.Id("ProformaInvoiceSend_skuNumberDisplay_options")); } }


public IWebElement shippingAddress { get { return WebDriver.GetElement(By.XPath("//select[@id = 'ProformaInvoiceSend_shippingaddress_options']")); } }


public IWebElement Format { get { return WebDriver.GetElement(By.Id("ProformaInvoiceSend_format_option")); } }


public IWebElement PrimarySalesRep { get { return WebDriver.GetElement(By.Id("ProformaInvoiceSend_isPrimarySalesRep")); } }


public IWebElement OrderCheck { get { return WebDriver.GetElement(By.XPath("//th[@id='ProformaInvoiceSend_orderCheck']/input")); } }


public IWebElement SendInvoice { get { return WebDriver.GetElement(By.Id("ProformaInvoiceSend_sendInvoice")); } }


public IWebElement SendTo { get { return WebDriver.GetElement(By.Id("ProformaInvoiceSend_emailAddress")); } }


public IWebElement OrderTableBody { get { return WebDriver.GetElement(By.XPath("//*[@Class='table table-fixed table-striped ']/tbody")); } }


public IWebElement OrderTableHead { get { return WebDriver.GetElement(By.XPath("//table[@Class='table table-fixed table-striped ']/thead/tr")); } }


public IWebElement ImgValidatingQuoteBusyIndicator { get { return WebDriver.GetElement(By.CssSelector("#quoteDetail_header > div > div.section-header.pd-btm-5 > div.col-md-12.table-column-centered.mg-btm-10.mg-top-10.ng-scope > p > span > img")); } }


public IWebElement ProformaHeader { get { return WebDriver.GetElement(By.Id("ProformaInvoiceSend_title")); } }


public IWebElement ProformaEmailQueue { get { return WebDriver.GetElement(By.Id("proformaInvoiceQueued_emailQueued")); } }


public IList<IWebElement> AllOrdresInProformaPage { get { return WebDriver.GetElements(By.XPath("//td[contains(@id,'ProformaInvoiceSend_orderCheck_')]//input")); } }


public IWebElement IncludeMe_ChkBox { get { return WebDriver.GetElement(By.Id("ProformaInvoiceSend_addloggedProfileEmail")); } }


public IWebElement BillingAddress_ChkBox { get { return WebDriver.GetElement(By.Id("ProformaInvoiceSend_billingAddress")); } }


public IWebElement Btn_Proforma_CancelInvoice { get { return WebDriver.GetElement(By.Id("ProformaInvoiceSend_cancelInvoice")); } }


public IList<IWebElement> IndividualOrdreNoInProformaPage { get { return WebDriver.GetElements(By.XPath("//td[contains(@id,'ProformaInvoiceSend_orderCheck_')]//input[@value='order.selected']")); } }


public IWebElement SKUNumberDisplayFalse { get { return WebDriver.GetElement(By.Id("ProformaInvoiceSend_skuNumberDisplay_options")); } }


public IWebElement SubjectTextBox { get { return WebDriver.GetElement(By.XPath("//input[@id = 'ProformaInvoiceSend_subject']")); } }


public IWebElement BodyTextBox { get { return WebDriver.GetElement(By.XPath("//textarea[@id = 'ProformaInvoiceSend_bodytext']")); } }


public IWebElement SendToTextBox { get { return WebDriver.GetElement(By.XPath("//textarea[@id = 'ProformaInvoiceSend_emailAddress']")); } }

        #endregion
        public string GetProformaInvoiceID()
        {
            return PID.GetText(WebDriver);
        }
       public bool IsSKUNumberDisplayDisabled()
        {
           return SKUNumberDisplay.Enabled.Equals(false);
        }

       

        public void selectShippingAddressDisplay(string show)
        {
            shippingAddress.Select().SelectByPartialText(show);
                    
        }
        public void selectFormat(string format)
        {
            Format.Select().SelectByPartialText(format);
        }

        public void selectPrimarySalesRep()
        {
            PrimarySalesRep.Click();
        }

        public void selectOrders()
        {
            OrderCheck.Click();
        }

        public void ClicksendInvoice()
        {
           SendInvoice.Click();
        }

        public void sendInvoiceTo(string email)
        {
            SendTo.Clear();
            SendTo.SendKeys(email);
        }

        public bool verify_msg(string dpid)
        {
            return WebDriver.FindElement(By.XPath("//h3[contains(text(),'DELL Pro-forma Invoice  - #P"+dpid+" successfully queued to send.')]")).Displayed;
        }

        public ReadOnlyCollection<IWebElement> Orders()
        {
           return OrderTableBody.FindElements(By.TagName("tr"));
        }

        public int GetStatusPos()
        {
            int StatusPos = 0;
            ReadOnlyCollection<IWebElement> OrderTableColumns = OrderTableHead.FindElements(By.TagName("th"));
            for (int col = 0; col < OrderTableColumns.Count; col++)
            {
                if ((OrderTableColumns.ElementAt(col).Text).Equals("Status"))
                {
                    StatusPos = col;
                    break;
                }
            }
            return StatusPos;
        }
        public void WaitForQuoteValidationToComplete()
        {
            while (WebDriver.TryFindElement(ImgValidatingQuoteBusyIndicator, TimeSpan.FromSeconds(10)))
            {
                // Do nothing.
            }
        }

        public IWebElement PriceElement(int rowIndex)
        {
            rowIndex = rowIndex - 1;
            return WebDriver.GetElement(By.XPath($"//tr//td[@id = 'ProformaInvoiceSend_orderCheck_{rowIndex}']//following::td[5]"));
        }

        public bool OrderNumberCheckBoxIsDisabled(string checkBoxRowNumber)
        {
            bool Isdisabled = false;
            //string attribute = CheckBoxElement(checkBoxRowNumber)
            bool attribute = CheckBoxElement(checkBoxRowNumber).Enabled;

            if (attribute == true)
            {
                Isdisabled = true;
            }

            return Isdisabled;
        }

        public IWebElement CheckBoxElement(string index)
        {
            return WebDriver.GetElement(By.XPath($"(//table[contains(@class, 'table table-fixed')]//tbody/tr/td/input)[{index}]"));
        }
    }
}
