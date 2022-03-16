using System;
using Dsa.Pages.Customer;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using Dsa.Pages.Quote;
using Dsa.Enums;
using Dsa.Workflows;

namespace Dsa.Pages.Order
{
    public class EmailConfirmationPage : DsaPageBase
    {
        public EmailConfirmationPage(IWebDriver webDriver)
            : base(webDriver)
        {
            
        }

        #region Elements
                
        public IWebElement BtnEmailConfirmationNext() => WebDriver.GetElement(By.XPath("//button[normalize-space()='Next']"));

        public IWebElement BtnSoftwareCommunicationNext() => WebDriver.GetElement(By.Id("_next"));
       
        public IWebElement TxtPrimaryContactEmail() => WebDriver.GetElement(By.Id("orderCreate_licenseContactName"));
       
        public IList<IWebElement> OrderAckSection() => WebDriver.GetElements(By.Id("orderCreate_additionalInfo"));
       
        public IWebElement LblOrderAck() => WebDriver.GetElement(By.XPath("//label[@for='orderCreate_Acknowledgement' and contains(text(),'Send Order Acknowledgement')]"));
       
        public IWebElement TxtEmailConfirmationSendTo() => WebDriver.GetElement(By.Id("orderCreate_sendTo"));
       
        public IWebElement ChkSendOrderConfirmation() => WebDriver.GetElement(By.Id("orderCreate_Confirmation"));
       
        public IWebElement ChkOrderConfirmationBilling() => WebDriver.GetElement(By.Id("orderCreate_billingEmailAddress"));
       
        public IWebElement ChkOrderConfirmationShipping() => WebDriver.GetElement(By.Id("orderCreate_shippingEmailAddress_0"));
       
        public IWebElement ChkOrderConfirmationCC() => WebDriver.GetElement(By.Id("orderCreate_ccEmailAddress"));
       
        public IWebElement ChkOrderConfirmationIncludeMe() => WebDriver.GetElement(By.Id("orderCreate_includemeEmailAddress"));

        public IWebElement OrderConfirmationFormat => WebDriver.GetElement(By.XPath("//*[@id='orderCreate_additionalInfo']//select"));

        public IList<IWebElement> FormatLabel() => WebDriver.GetElements(By.XPath("//label[text()='Format:']"));

        public IWebElement ChkSendOrderAcknowledgement() => WebDriver.GetElement(By.Id("orderCreate_Acknowledgement"));

        //public By ByChkSendOrderAcknowledgement = By.Id("orderCreate_Acknowledgement");        

        public IWebElement lstFormateOption() => WebDriver.GetElement(By.Id("orderCreate_orderackformatoption"));


        public IWebElement TxtEmailAcknowledgementSendTo() => WebDriver.GetElement(By.Id("orderCreate_orderacksendTo"));


        public IWebElement ChkBoxCustomerBilling() => WebDriver.GetElement(By.XPath("//*[@id='orderCreate_orderackccEmailAddress'])[1]"));


        public IWebElement ChkBoxIncludeMeRecipient() => WebDriver.GetElement(By.XPath("(//*[@id='orderCreate_orderackccEmailAddress'])[2]"));


        public IWebElement ChkBoxCcSalesRep() => WebDriver.GetElement(By.XPath("//*[@id='orderCreate_orderackccEmailAddress'])[3]"));


        public IWebElement ChkBoxCustomerShipping => WebDriver.GetElement(By.Id("orderCreate_orderackccShipEmailAddress_0"));


        public IWebElement ChkBoxCustomerSoldTo() => WebDriver.GetElement(By.Id("orderCreate_orderackccSoldToEmailAddress"));


        public IWebElement TxtEmailInvoiceSendTo() => WebDriver.GetElement(By.Id("orderCreate_orderInvoiceSendTo"));


        public IWebElement AddButton() => WebDriver.GetElement(By.XPath("//*[@id='_pomId']/span/span/a"));
        public IList<IWebElement> SelectMultipleEmailsinOrder() => WebDriver.GetElements(By.XPath(string.Format("//*[contains(@id,'orderCreate_orderackccEmailAddress')]")), TimeSpan.FromSeconds(3));
                
        public IWebElement SelectorderCreate_orderackccSoldToEmailAddress() => WebDriver.GetElement(By.Id("orderCreate_orderackccSoldToEmailAddress"));


        public IWebElement TxtorderAckOriginalRecipient() => WebDriver.GetElement(By.Name("orderAckOriginalRecipient"));

        // **************Digital Fulfillment*******************

        
        public IWebElement Digitially_Fulfilled_Software_and_Services_Header() => WebDriver.GetElement(By.XPath(string.Format("//*[text() = ' Digitally Fulfilled Software and Services ']")));
        public IWebElement DellDigitalLocker() => WebDriver.GetElement(By.Id("df_digitallocker_url"));
        
        public IWebElement DellDigitalLockerHoverText() => WebDriver.GetElement(By.XPath("//*[@id='df_lockerhovertext']/i"));
        

        public IWebElement DFEndUserEmail() => WebDriver.GetElement(By.XPath("//*[@id='df_enduseremail_text']/div[2]/textarea"));               

        public IWebElement DFPartnerEmail() => WebDriver.GetElement(By.XPath("//*[@id='df_partneruseremail_text']/div[2]/textarea"));

        public IWebElement DellDigitalLockerPage()
        {
            return WebDriver.GetElement(By.XPath("//*[@id='main-content-area']/h2"));
        }

        // **************Digital Fulfillment*******************
        #endregion

        #region Methods

        public bool SelectMultipleEmails(IWebDriver driver,int checkbox=3,Boolean selectbox=false)
        {
            if (selectbox == false)
            {
                ChkSendOrderConfirmation().UnSelectCheckBox(WebDriver);
            }
           ChkSendOrderAcknowledgement().SelectCheckBox(WebDriver);
           
            if (SelectMultipleEmailsinOrder().Count > 0)
            {
                for (int i = 0; i <= SelectMultipleEmailsinOrder().Count; i++)
                {
                    if (checkbox >= i + 1)
                    {
                        if (!SelectMultipleEmailsinOrder()[i].Selected)
                        {

                            SelectMultipleEmailsinOrder()[i].Click(driver);
                            //return true;
                        }
                    }
                }
            }
            return false;
        }
        public void SelectorderCreateorderackccSoldToEmailAddress(IWebDriver driver)
        {
            SelectorderCreate_orderackccSoldToEmailAddress().IsElementClickable(WebDriver, TimeSpan.FromSeconds(5));
            SelectorderCreate_orderackccSoldToEmailAddress().Click(driver, TimeSpan.FromSeconds(3));
            SelectorderCreate_orderackccSoldToEmailAddress().Click(driver, TimeSpan.FromSeconds(3));

        }
        public void OrderEmailslist(IWebDriver driver,bool emailVerification=false)
        {
            
            if(emailVerification==true)
            {
                TxtorderAckOriginalRecipient().IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5));
                string EmailsList = TxtorderAckOriginalRecipient().GetText(driver, TimeSpan.FromSeconds(3));
                Logger.Write($"Emails list {EmailsList} are displayed ");

            }
            else
            {
                string EmailsList = TxtorderAckOriginalRecipient().GetText(driver, TimeSpan.FromSeconds(3));
                Logger.Write($"Emails list {EmailsList} are displayed ");
            }
        }
        public void OrderEmailslist(string Emailslist)
        {
            TxtorderAckOriginalRecipient().IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5));
            TxtorderAckOriginalRecipient().SetText(WebDriver, Emailslist, TimeSpan.FromSeconds(3));

        }

        public PaymentsPage EmailConfirmationNext()
        {
            BtnEmailConfirmationNext().Click(WebDriver);
            return new PaymentsPage(WebDriver);
        }       

        public bool OrderAckSectionVisible()
        {
            return DsaUtil.FindElementBy(WebDriver, By.XPath("//label[@for='orderCreate_Acknowledgement' and contains(text(),'Send Order Acknowledgement')]"), TimeSpan.FromSeconds(30)) & OrderAckSection().Count==1;
        }

        public bool OrderConfCFOAsHTMLOnly()
        {
            return DsaUtil.FindElementBy(WebDriver, By.XPath("//label[@for='orderCreate_format' and contains(text(),'HTML')]"), TimeSpan.FromSeconds(30));
        }
        public PaymentsPage EmailConfirmationNextWithoutSendingOrder()
        {
            ChkSendOrderConfirmation().UnSelectCheckBox(WebDriver);
            ChkSendOrderAcknowledgement().UnSelectCheckBox(WebDriver);
            BtnEmailConfirmationNext().Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return new PaymentsPage(WebDriver);
        }

        public PaymentsPage ProcessOrderAcknowledgement(string attachmentType, string sendTo)
        {
            //CustomerCreatePage customerCreatePage = new CustomerCreatePage(WebDriver);
            ProcessOrderEmailAcknowledgement(attachmentType, sendTo);
            BtnEmailConfirmationNext().Click(WebDriver);
            return new PaymentsPage(WebDriver);
        }        

        public void ProcessOrderEmailAcknowledgement(string attachmentType, string sendTo)
        {
            if (ChkSendOrderAcknowledgement().IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(5)))
            {
                ChkSendOrderConfirmation().UnSelectCheckBox(WebDriver);
                ChkSendOrderAcknowledgement().SelectCheckBox(WebDriver);
                //lstFormateOption.PickDropdownByText(WebDriver, attachmentType);
                UnSelectAllOrderAckCheckbox();
                TxtEmailAcknowledgementSendTo().SetText(WebDriver, sendTo);
            }
            else
            {
                ChkSendOrderConfirmation().SelectCheckBox(WebDriver);
                OrderConfirmationFormat.PickDropdownByText(WebDriver, attachmentType);
                UnSelectAllOrderConfirmationCheckbox();
                TxtEmailConfirmationSendTo().SetText(WebDriver, sendTo);
            }
        }

        public void UnSelectAllOrderAckCheckbox()
        {
            var numberOfChkBox = WebDriver.GetElements(By.XPath("//input[contains(@id, 'orderCreate_orderack') and @type ='checkbox']"));
            if (numberOfChkBox != null)
            {
                foreach (var chkBox in numberOfChkBox)
                {
                    if (chkBox.Selected)
                    {
                        chkBox.UnSelectCheckBox(WebDriver);
                    }
                }
            }
        }

        public void VerfiyNoFormatForORderAck()
        {
            var numberOfChkBox = WebDriver.GetElements(By.XPath("//input[contains(@id, 'orderCreate_orderack') and @type ='checkbox']"));
            if (numberOfChkBox != null)
            {
                foreach (var chkBox in numberOfChkBox)
                {
                    if (chkBox.Selected)
                    {
                        chkBox.UnSelectCheckBox(WebDriver);
                    }
                }
            }
        }

        public void UnSelectAllOrderConfirmationCheckbox()
        {
            //ChkOrderConfirmationBilling.UnSelectCheckBox(WebDriver);
            //ChkBoxCustomerShipping.UnSelectCheckBox(WebDriver);
            //ChkOrderConfirmationCC.UnSelectCheckBox(WebDriver);
            //ChkOrderConfirmationIncludeMe.UnSelectCheckBox(WebDriver);
            var numberOfChkBox =
                WebDriver.GetElements(By.XPath("//input[contains(@id, 'EmailAddress') and @type ='checkbox']"));
            if (numberOfChkBox != null)
            {
                foreach (var chkBox in numberOfChkBox)
                {
                    if (chkBox.Selected)
                    {
                        chkBox.UnSelectCheckBox(WebDriver);
                    }
                }
            }
        }


        public bool VerfiyNoFormatTypeForOrderAck()
        {
            ChkSendOrderConfirmation().SelectCheckBox(WebDriver);
            ChkSendOrderAcknowledgement().SelectCheckBox(WebDriver);
            int count = FormatLabel().Count;
            if (count == 1)
                return true;
            return false;
        }
       
        #endregion
    }
}
