using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Dsa.Pages.Quote;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using Dsa.Pages.PCFConvergence;

namespace Dsa.Pages
{
    public class PCFSendQuotePage : DsaPageBase
    {
        public PCFSendQuotePage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements

        public IWebElement RdbSendQuoteViaEmail { get { return WebDriver.GetElement(By.Id("quoteSendCfo_viaEmail")); } }

        public IWebElement RdbSendQuoteViaFax { get { return WebDriver.GetElement(By.Id("quoteSendCfo_viaFax")); } }

        public IWebElement TxtSendToEmailAddress { get { return WebDriver.GetElement(By.Id("quoteSendCfo_emailAddress")); } }

        public IWebElement ChkCcAddress { get { return WebDriver.GetElement(By.Id("quoteSendCfo_ccAddress")); } }

        public IWebElement CfoSendQuoteEmailSubject { get { return WebDriver.GetElement(By.Id("quoteSendCfo_subject")); } }

        public IWebElement ChkCustomerBilling { get { return WebDriver.GetElement(By.Id("quoteSendCfo_billingAddress")); } }

        public By SendQuoteBillingAddress = By.Id("quoteSendCfo_billingAddress");
        public By SendQuoteSoldToAddress = By.Id("quoteSendCfo_soldToEmailAddress");

        public IWebElement ChkCustomerShipping { get { return WebDriver.GetElement(By.Id("quoteSendCfo_shippingAddress_0")); } }

        public IWebElement ChkCustomerSoldTo { get { return WebDriver.GetElement(By.Id("quoteSendCfo_soldToAddress")); } }

        public IWebElement ChkIncludeMeAsRecipient { get { return WebDriver.GetElement(By.Id("quoteSendCfo_addloggedProfileEmail")); } }

        public IWebElement BtnCfoSendEmail { get { return WebDriver.GetElement(By.Id("quoteSendCfo_sendQuote")); } }

        public IWebElement DdlLanguage { get { return WebDriver.GetElement(By.Id("quoteSendCfo_language_options")); } }

        public IWebElement LanguageDisplay { get { return WebDriver.GetElement(By.Id("quoteSendCfo_language_display")); } }

        public IWebElement DdlFormat { get { return WebDriver.GetElement(By.Id("quoteSendCfo_format_option")); } }

        public IWebElement DdlShippingAddressDisplay { get { return WebDriver.GetElement(By.Id("quoteSendCfo_shippingAddress_options")); } }

        public IWebElement DdlSkuNumberDisplay { get { return WebDriver.GetElement(By.Id("quoteSendCfo_skuNumberDisplay_options")); } }

        public IWebElement TxtSubject { get { return WebDriver.GetElement(By.Id("quoteSendCfo_subject")); } }

        public IWebElement TxtAdditionalComments { get { return WebDriver.GetElement(By.Id("quoteSendCfo_comments")); } }

        public IWebElement BtnSend { get { return WebDriver.GetElement(By.Id("quoteSendCfo_sendQuote")); } }

        public IWebElement BtnCancel { get { return WebDriver.GetElement(By.Id("quoteSendCfo_cancelSend")); } }

        public IWebElement BtnMoreActions { get { return WebDriver.GetElement(By.Id("quoteSendCfo_moreActions")); } }

        public IWebElement BtnPreview { get { return WebDriver.GetElement(By.Id("quoteSendCfo_previewQuote")); } }

        public IWebElement BtnDownoadExcel { get { return WebDriver.GetElement(By.Id("quoteSendCfo_downloadQuoteCFO")); } }

        //[FindsBy(How = How.Id, Using = "quoteDetail_sendCFO")] public IWebElement BtnSendCFO;


        public IWebElement BtnSendCFO { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='Send Quote']")); } }

        public IWebElement RdbPrimarySalesRep { get { return WebDriver.GetElement(By.Id("quoteSendCfo_isPrimarySalesRep")); } }

        public IWebElement RdbLoggedInSalesRep { get { return WebDriver.GetElement(By.Id("quoteSendCfo_isLoggedInSalesRep")); } }

        public IWebElement HdrSendCfoHeaderAfterSent { get { return WebDriver.GetElement(By.XPath("//*[@id='main')]/div/h3")); } }

        public IWebElement LnkSendCfoNextSteps { get { return WebDriver.GetElement(By.XPath("//*[@")); } }

        public IWebElement LnkViewCustomerReportOutput { get { return WebDriver.GetElement(By.Id("_CustomerOutputReport")); } }

        public IWebElement LnkCreateANewQuote { get { return WebDriver.GetElement(By.LinkText("Create a New Quote")); } }

        //[FindsBy(How = How.Id, Using = "_returnQuote")] 

        public IWebElement LnkReturnToQuote { get { return WebDriver.GetElement(By.XPath("//a[@id='_returnQuote']")); } }

        public IWebElement LnkCopyQuote { get { return WebDriver.GetElement(By.Id("_copyQuote")); } }

        public IWebElement LnkEditSalesRep { get { return WebDriver.GetElement(By.Id("quoteSendCfo_editSalesRep")); } }

        public IWebElement SalesRepName { get { return WebDriver.GetElement(By.Id("_edit_salesRepContactInfo_salesRepName")); } }

        public IWebElement SalesRepEmail { get { return WebDriver.GetElement(By.Id("_edit_salesRepContactInfo_salesRepEmail")); } }

        public IWebElement SalesRepPhone { get { return WebDriver.GetElement(By.Id("_edit_salesRepContactInfo_salesRepPhone")); } }

        public IWebElement SalesRepExtention { get { return WebDriver.GetElement(By.Id("_edit_salesRepContactInfo_salesRepExtension")); } }

        public IWebElement SalesRepSave { get { return WebDriver.GetElement(By.Id("quoteSendCfo_saveSalesRep")); } }

        public IWebElement SalesRepCancel { get { return WebDriver.GetElement(By.Id("quoteSendCfo_cancelSalesRep")); } }

        public IWebElement LoggedInSalesRep { get { return WebDriver.GetElement(By.Id("quoteSendCfo_isLoggedInSalesRep")); } }

        public IWebElement SendCfo_details { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteSendCfo_details_header']/div/h3/span")); } }

        public IWebElement QuoteCfo_CheckBoxes { get { return WebDriver.GetElement(By.XPath("//input[@type='checkbox']")); } }

        public IWebElement SendCfo_subject { get { return WebDriver.GetElement(By.Id("quoteSendCfo_subject")); } }


        // [FindsBy(How = How.Id, Using = "quoteSendCfo_format_option") ];

        public IWebElement ChannelQuoteDislplay { get { return WebDriver.GetElement(By.XPath("//label[text()='Channel Quote Display']/following::select[contains(@class,'ng-untouched ng-pristine ng-valid')]")); } }


        public IList<IWebElement> MultiQuote_QuoteNumbers { get { return WebDriver.GetElements(By.XPath(".//*[@id='main']/send-multi-quote-selected-quotes-details/descendant::tbody/tr/td[2]")); } }


        public IWebElement MultiQuote_SendQuote_EmailTextBox { get { return WebDriver.GetElement(By.XPath(".//*[@id='main']/send-multi-quote-body/descendant::label[contains(text(),'Send To')]/parent::*/textarea")); } }


        public IWebElement MultiQuote_SendQuote_Button { get { return WebDriver.GetElement(By.XPath(" .//send-multi-quote-header/descendant::button[contains(text(),'Send')]")); } }


        public IWebElement MultiQuote_SendQuote_QueueHeader { get { return WebDriver.GetElement(By.XPath(".//*[@id='NG2_UPGRADE_141_0']/descendant::h2[contains(text(),'Quote Email Queued')]")); } }


        public IWebElement MultiQuote_SendQuote_ValidationErrorMessage { get { return WebDriver.GetElement(By.XPath(".//*[@id='main']//div[@class='alert alert-warning']")); } }


        public IWebElement MultiQuote_SendQuote_SuccessMessage { get { return WebDriver.GetElement(By.XPath(".//*[@id='main']/div[1]/h3[contains(text(),'Quotes successfully queued to send')]")); } }


        public IWebElement ExpirationDateCFO { get { return WebDriver.GetElement(By.XPath("(//table[@class = 'c-data-grid']//tbody/tr/td)[4]")); } }

        public IWebElement CopyAsNewQuote(int quoteIndex = 1)
        {
            return WebDriver.GetElement(By.Id($"_copyAsNewQuote_{quoteIndex - 1}"), TimeSpan.FromSeconds(3));
        }

        public IWebElement CopyAsNewVersion(int quoteIndex = 1)
        {
            return WebDriver.GetElement(By.Id($"[@id=_copyAsNewVersion_{quoteIndex - 1}"), TimeSpan.FromSeconds(3));
        }

        #endregion

        public PCFSendQuotePage SendQuoteViaMail()
        {
            RdbSendQuoteViaFax.Click(WebDriver);
            return this;
        }

        public PCFQuoteSummaryPage SendQuoteCfOEmailtoRecipients(string email, string subject)
        {
            BtnSendCFO.Click(WebDriver);
            string subjectInfo = CfoSendQuoteEmailSubject.GetText(WebDriver);
            RdbLoggedInSalesRep.Click(WebDriver);
            ClearAllQuoteCfoCheckBoxTextBox();
            TxtSendToEmailAddress.SetText(WebDriver, email);
            CfoSendQuoteEmailSubject.SetText(WebDriver, subject + " " + subjectInfo);
            BtnCfoSendEmail.Click(WebDriver);
            LnkReturnToQuote.Click(WebDriver);
            return new PCFQuoteSummaryPage(WebDriver);
        }

        public PCFSendQuotePage ClearAllQuoteCfoCheckBoxTextBox()
        {
            TxtSendToEmailAddress.Clear();
            CfoSendQuoteEmailSubject.Clear();

            var numberOfChkBox =
                WebDriver.GetElements(By.XPath("//input[contains(@id, 'quoteSendCfo') and @type ='checkbox']"));
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
            //CustomerCreatePage customerCreatePage = new CustomerCreatePage(WebDriver);

            //ChkIncludeMeAsRecipient.UnSelectCheckBox(WebDriver);
            //ChkCcAddress.UnSelectCheckBox(WebDriver);
            //ChkCustomerBilling.UnSelectCheckBox(WebDriver);
            //if (customerCreatePage.ElementExistValidation(SendQuoteBillingAddress))
            //{
            //    ChkCustomerBilling.UnSelectCheckBox(WebDriver);
            //    ChkCustomerSoldTo.UnSelectCheckBox(WebDriver);
            //}
            return this;
        }

        public PCFSendQuotePage SendQuoteViaFax()
        {
            RdbSendQuoteViaFax.Click(WebDriver);
            return this;
        }

        public PCFSendQuotePage SendQuote(string sendToEmail = "", bool isDellPrint = true, bool includeMe = false,
            bool cc = false, bool sendToCustBilling = false, bool sendToCustSoldTo = false, string subject = "",
            string additionalComments = "")
        {
            //new CreateQuotePage(WebDriver).WaitForBusyIndicatorAppearAndDisappear();    
            WebDriverUtil.WaitForElementDisplay(WebDriver, new PCFSendQuotePage(WebDriver).ChkIncludeMeAsRecipient, TimeSpan.FromSeconds(10));

            if (includeMe)
                ChkIncludeMeAsRecipient.SelectCheckBox(WebDriver);
            else
                ChkIncludeMeAsRecipient.UnSelectCheckBox(WebDriver);

            if (cc)
                ChkCcAddress.SelectCheckBox(WebDriver);
            else
                ChkCcAddress.UnSelectCheckBox(WebDriver);

            if (isDellPrint)
            {
                if (sendToCustBilling)
                    ChkCustomerBilling.SelectCheckBox(WebDriver);
                else
                    ChkCustomerBilling.UnSelectCheckBox(WebDriver);

                if (sendToCustSoldTo)
                    ChkCustomerSoldTo.SelectCheckBox(WebDriver);
                else
                    ChkCustomerSoldTo.UnSelectCheckBox(WebDriver);
            }

            if (!string.IsNullOrEmpty(subject))
                TxtSubject.SetText(WebDriver, subject);

            if (!string.IsNullOrEmpty(additionalComments))
                TxtAdditionalComments.SetText(WebDriver, additionalComments);
            if (!string.IsNullOrEmpty(sendToEmail))
            {
                TxtSendToEmailAddress.SetText(WebDriver, sendToEmail);
            }
            BtnSend.Click(WebDriver);
            return this;
        }

        public PCFSendQuotePage Sendwithprimarysalesrep(bool primarySalesRep, bool loggedSalesRep, string sendToEmail,
            bool isDellPrint, bool includeMe, bool cc, bool sendToCustBilling, bool sendToCustShipping, string subject,
            string additionalComments)
        {
            if (primarySalesRep)
                RdbPrimarySalesRep.SelectCheckBox(WebDriver);
            else
                RdbPrimarySalesRep.UnSelectCheckBox(WebDriver);

            if (loggedSalesRep)
                LoggedInSalesRep.SelectCheckBox(WebDriver);
            else
                ChkIncludeMeAsRecipient.UnSelectCheckBox(WebDriver);

            if (!string.IsNullOrEmpty(sendToEmail))
            {
                TxtSendToEmailAddress.SetText(WebDriver, sendToEmail);
            }

            if (includeMe)
                ChkIncludeMeAsRecipient.SelectCheckBox(WebDriver);
            else
                ChkIncludeMeAsRecipient.UnSelectCheckBox(WebDriver);

            if (cc)
                ChkCcAddress.SelectCheckBox(WebDriver);
            else
                ChkCcAddress.UnSelectCheckBox(WebDriver);

            if (isDellPrint)
            {
                if (sendToCustBilling)
                    ChkCustomerBilling.SelectCheckBox(WebDriver);
                else
                    ChkCustomerBilling.UnSelectCheckBox(WebDriver);
            }


            if (!string.IsNullOrEmpty(subject))

                TxtSubject.SetText(WebDriver, subject);

            if (!string.IsNullOrEmpty(additionalComments))
                TxtAdditionalComments.SetText(WebDriver, additionalComments);

            BtnSend.Click(WebDriver);


            return new PCFSendQuotePage(WebDriver);
        }


        public QuoteEmailQueuedPage SendCFOBasedOnFormat(string TypeOfAttachment, string SendToEmail, bool IsDellPrint,
            bool IncludeMe, bool cc, bool SendToCustBilling)
        {
            DdlFormat.PickDropdownByText(WebDriver, TypeOfAttachment);
            if (IncludeMe)
                ChkIncludeMeAsRecipient.SelectCheckBox(WebDriver);
            else
                ChkIncludeMeAsRecipient.UnSelectCheckBox(WebDriver);

            if (cc)
                ChkCcAddress.SelectCheckBox(WebDriver);
            else
                ChkCcAddress.UnSelectCheckBox(WebDriver);

            if (IsDellPrint)
            {
                if (SendToCustBilling)
                    ChkCustomerBilling.SelectCheckBox(WebDriver);
                else
                    ChkCustomerBilling.UnSelectCheckBox(WebDriver);
            }

            BtnSend.Click(WebDriver);
            return new QuoteEmailQueuedPage(WebDriver);
        }


        public PreviewQuoteEmail ViewPreviewBasedOnFormat(string TypeOfAttachment, string SendToEmail, bool IsDellPrint,
            bool IncludeMe, bool cc, bool SendToCustBilling)
        {
            DdlFormat.PickDropdownByText(WebDriver, TypeOfAttachment);

            if (IncludeMe)
                ChkIncludeMeAsRecipient.SelectCheckBox(WebDriver);
            else
                ChkIncludeMeAsRecipient.UnSelectCheckBox(WebDriver);

            if (cc)
                ChkCcAddress.SelectCheckBox(WebDriver);
            else
                ChkCcAddress.UnSelectCheckBox(WebDriver);

            if (IsDellPrint)
            {
                if (SendToCustBilling)
                    ChkCustomerBilling.SelectCheckBox(WebDriver);
                else
                    ChkCustomerBilling.UnSelectCheckBox(WebDriver);
            }
            if (!string.IsNullOrEmpty(SendToEmail))
            {
                TxtSendToEmailAddress.SetText(WebDriver, SendToEmail);
            }
            BtnMoreActions.Click(WebDriver);
            BtnPreview.Click(WebDriver);
            return new PreviewQuoteEmail(WebDriver);
        }


        public PCFQuoteSummaryPage ReturnToQuoteDetails()
        {
            if (LnkReturnToQuote.IsElementDisplayed(WebDriver,TimeSpan.FromSeconds(5)))
            {
                LnkReturnToQuote.Click(WebDriver);
            }
            new PCFQuoteSummaryPage(WebDriver).WaitForQuoteValidationToComplete();
            return new PCFQuoteSummaryPage(WebDriver);
        }

        public PCFQuoteSummaryPage UpdateSalesRepDetails(string SaleRepName, string SaleRepEmail, string SaleRepPhone,
            string SaleRepExtention)
        {
            LoggedInSalesRep.Click(WebDriver);
            SalesRepName.SetText(WebDriver, SaleRepName);
            SalesRepEmail.SetText(WebDriver, SaleRepEmail);
            SalesRepPhone.SetText(WebDriver, SaleRepPhone);
            SalesRepExtention.SetText(WebDriver, SaleRepExtention);
            SalesRepSave.Click();
            return new PCFQuoteSummaryPage(WebDriver);
        }

        public CreateQuotePage CopyQuote()
        {
            LnkCopyQuote.Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        }

        public CustomerCommunicationPage ViewCustomerOutputReport()
        {
            LnkViewCustomerReportOutput.Click(WebDriver);
            return new CustomerCommunicationPage(WebDriver);
        }

        public CreateQuotePage CreateNewQuote()
        {
            LnkCreateANewQuote.Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        }


        public PCFSendQuotePage DownloadExcelWithPDFFormat(string typeOfAttachment, string sendToEmail, bool isDellPrint,
            bool includeMe, bool cc, bool sendToCustBilling)
        {
            DdlFormat.PickDropdownByText(WebDriver, typeOfAttachment);

            if (includeMe)
                ChkIncludeMeAsRecipient.SelectCheckBox(WebDriver);
            else
                ChkIncludeMeAsRecipient.UnSelectCheckBox(WebDriver);

            if (cc)
                ChkCcAddress.SelectCheckBox(WebDriver);
            else
                ChkCcAddress.UnSelectCheckBox(WebDriver);

            if (isDellPrint)
            {
                if (sendToCustBilling)
                    ChkCustomerBilling.SelectCheckBox(WebDriver);
                else
                    ChkCustomerBilling.UnSelectCheckBox(WebDriver);
            }
            BtnMoreActions.Click(WebDriver);
            BtnDownoadExcel.Click(WebDriver);
            return new PCFSendQuotePage(WebDriver);
        }

        public QuoteEmailQueuedPage SendWithPDFFormat(string TypeOfAttachment, string TesteMail, bool IsDellPrint,
            bool IncludeMe, bool cc, bool SendToCustBilling)
        {
            DdlFormat.PickDropdownByText(WebDriver, TypeOfAttachment);

            if (IncludeMe)
                ChkIncludeMeAsRecipient.SelectCheckBox(WebDriver);
            else
                ChkIncludeMeAsRecipient.UnSelectCheckBox(WebDriver);

            if (cc)
                ChkCcAddress.SelectCheckBox(WebDriver);
            else
                ChkCcAddress.UnSelectCheckBox(WebDriver);

            if (IsDellPrint)
            {
                if (SendToCustBilling)
                    ChkCustomerBilling.SelectCheckBox(WebDriver);
                else
                    ChkCustomerBilling.UnSelectCheckBox(WebDriver);
            }
            BtnSend.Click(WebDriver);

            return new QuoteEmailQueuedPage(WebDriver);
        }

        /// <summary>
        /// Return True if the ChannelQuoteDislplay display is List & DOL% - For Company 45
        /// </summary>
        /// <returns></returns>

        public bool VerifyDefaultOptionInChannelQouteDisplay(string dropDownValue)
        {
            try
            {
                if (WebDriverUtil.WaitForElementDisplay(WebDriver, ChannelQuoteDislplay, TimeSpan.FromSeconds(30)))
                {
                    foreach (IWebElement ele in new SelectElement(ChannelQuoteDislplay).Options)
                        if (ele.GetAttribute("label") == dropDownValue)
                        {
                            if (ele.Selected)
                                return true;
                        }
                }

            }
            catch (Exception) { }
            return false;
        }

        public bool VerifyOptionsInChannelQouteDisplay()
        {
            List<String> dropDownText = new List<string>();

            try
            {
                if (WebDriverUtil.WaitForElementDisplay(WebDriver, ChannelQuoteDislplay, TimeSpan.FromSeconds(20)))
                {
                    dropDownText = ChannelQuoteDislplay.PickDropdownOptions(WebDriver);
                    if (dropDownText.Contains("Unit Price Quote") && dropDownText.Contains("List and DOL%") && dropDownText.Contains("List and Standard Partner Discount"))
                        return true;
                }
            }
            catch (Exception) { }
            return false;
        }
    }
}