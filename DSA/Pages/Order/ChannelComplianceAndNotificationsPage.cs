using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;
using System.Text.RegularExpressions;

namespace Dsa.Pages.Order
{
    public class ChannelComplianceAndNotificationsPage : DsaPageBase
    {
        public ChannelComplianceAndNotificationsPage(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "Compliance & Notifications Page";
            PageFactory.InitElements(WebDriver, this);
            webDriver.VerifyBusyOverlayNotDisplayed();
        }

        #region Pricing Elements
        //Pricing Summary 

public IWebElement LblPricingSummaryListPrice { get { return WebDriver.GetElement(By.Id("pricingSummary_listPrice")); } }


public IWebElement LblPricingSummaryDiscount { get { return WebDriver.GetElement(By.Id("pricingSummary_discount")); } }


public IWebElement LblPricingSummarySellingPrice { get { return WebDriver.GetElement(By.Id("pricingSummary_sellingPrice")); } }


public IWebElement LblPricingSummaryShippingPrice { get { return WebDriver.GetElement(By.Id("pricingSummary_shippingPrice")); } }


public IWebElement LblPricingSummaryShippingDiscount { get { return WebDriver.GetElement(By.Id("pricingSummary_shippingDiscount")); } }


public IWebElement LblPricingSummaryTotalShipping { get { return WebDriver.GetElement(By.Id("pricingSummary_totalShipping")); } }


public IWebElement LblPricingSummaryTaxableAmount { get { return WebDriver.GetElement(By.Id("pricingSummary_taxableAmount")); } }


public IWebElement LblPricingSummaryNonTaxableAmount { get { return WebDriver.GetElement(By.Id("pricingSummary_nonTaxableAmount")); } }


public IWebElement LblPricingSummaryTotalTax { get { return WebDriver.GetElement(By.Id("pricingSummary_totalTax")); } }


public IWebElement LblPricingSummarySubTotal { get { return WebDriver.GetElement(By.Id("pricingSummary_subTotal")); } }


public IWebElement LblPricingSummaryTotalEcoFee { get { return WebDriver.GetElement(By.Id("pricingSummary_totalEcoFee")); } }


public IWebElement LblPricingSummaryFinalPrice { get { return WebDriver.GetElement(By.Id("pricingSummary_finalPrice")); } }

        //EMEA/APJ Pricing


public IWebElement LblEMEAAPJPricingSummary { get { return WebDriver.GetElement(By.XPath("//pricing-summary//h3[@id='lblTitle']")); } }


public IWebElement LblEMEAAPJSubTotal { get { return WebDriver.GetElement(By.XPath("//pricing-summary//div[@id='lblpsSubtotal']")); } }


public IWebElement LblEMEAAPJSubTotalPrice { get { return WebDriver.GetElement(By.XPath("//pricing-summary//div[@id='pricingSummary_subTotal']")); } }


public IWebElement LblEMEAAPJTotalShipping { get { return WebDriver.GetElement(By.XPath("//pricing-summary//div[@id='lblpsTotalShipping']")); } }


public IWebElement LblEMEAAPJTotalShippingPrice { get { return WebDriver.GetElement(By.XPath("//pricing-summary//div[@id='pricingSummary_totalShipping']")); } }


public IWebElement LblEMEAAPJTotalTax { get { return WebDriver.GetElement(By.XPath("//pricing-summary//div[@id='lblpsTotalTaxExp']")); } }


public IWebElement LblEMEAAPJTotalTaxPrice { get { return WebDriver.GetElement(By.XPath("//pricing-summary//div[@id='pricingSummary_totalTax_Exp']")); } }


public IWebElement LblNonUSTaxInfo { get { return WebDriver.GetElement(By.XPath("//pricing-summary//div[@id='lblpsTaxInfo']")); } }


public IWebElement LblEMEAAPJTaxInfoPrice { get { return WebDriver.GetElement(By.XPath("//pricing-summary//div[@id='pricingSummary_tax']")); } }


public IWebElement LblEMEAAPJTotal { get { return WebDriver.GetElement(By.XPath("//pricing-summary//div[@id='lblpsTotal']")); } }


public IWebElement LblEMEAAPJTotalPrice { get { return WebDriver.GetElement(By.XPath("//pricing-summary//div[@id='pricingSummary_finalPrice']")); } }

        #endregion

        #region Button Elements

public IWebElement BtnBack { get { return WebDriver.GetElement(By.Id("BackButton")); } }


public IWebElement BtnContinueToCheckout { get { return WebDriver.GetElement(By.Id("ContinueLink")); } }


public IWebElement BtnContinueToCheckoutFromPricingSummary { get { return WebDriver.GetElement(By.Id("PaymentLink")); } }


public IWebElement EMEA_APJ_BtnContinueToCheckoutFromPricingSummary { get { return WebDriver.GetElement(By.Id("lblContinue")); } }
        #endregion


        #region Banner and TnCs Elements


public IList<IWebElement> Banner { get { return WebDriver.GetElements(By.XPath("//compliance-notification//div[@id='PartnerProgressBar']//div[contains(@class,'dds__progress-bar dds__progress-bar')]")); } }


public IList<IWebElement> BannerLables { get { return WebDriver.GetElements(By.XPath("//compliance-notification//div[@id='PartnerProgressBar']//div[contains(@class,'dds__progress-bar dds__progress-bar')]/span")); } }


public IWebElement LblTermsAndConditionsTitle { get { return WebDriver.GetElement(By.XPath("//terms-and-conditions//div[@id='TermsAndConditionsTitle']/h2")); } }


public IWebElement LblTermsAndConditionsDescription { get { return WebDriver.GetElement(By.XPath("//terms-and-conditions//div[@id='tncDescripion']")); } }


public IWebElement LblTermsAndConditionsOfSale { get { return WebDriver.GetElement(By.XPath("//terms-and-conditions//div[@id='tncAgreement']/label[@for='chkAgreeToDellTnc']")); } }


public IWebElement ChkBoxTncAgreement { get { return WebDriver.GetElement(By.XPath("//terms-and-conditions//div[@id='tncAgreement']/input")); } }


public IWebElement HyperLnkTermsAndConditions { get { return WebDriver.GetElement(By.XPath("//terms-and-conditions//div[@id='tncDescripion']/a")); } }

        public By LblTermsAndConditionsOfSaleErrorMessage = By.XPath("//terms-and-conditions//span[@class='error-text']");
        public By LblComplianceNotificationPageErrorMessage = By.XPath("//compliance-notification//div[@class='dds__row']//div[@class='dds__alert dds__alert-dismissible dds__fade dds__show' and @role='alert']//p[@class='dds__alert-body']");

        #endregion

        #region Banner and Terms&Condiitons Methods

        public bool VerifyBannerExists()
        {
            if (Banner.Count == 4)
                return true;
            return false;
        }

        public bool VerifyBannerLabels(string quoteSummary, string complianceNotifications, string payment, string reviewOrder)
        {
            if (String.Equals(quoteSummary, BannerLables[0].Text, StringComparison.OrdinalIgnoreCase) & String.Equals(complianceNotifications, BannerLables[1].Text, StringComparison.OrdinalIgnoreCase) & String.Equals(payment, BannerLables[2].Text, StringComparison.OrdinalIgnoreCase) & String.Equals(reviewOrder, BannerLables[3].Text))
                return true;
            return false;
        }

        public bool VerifyLabelTermsAndConditionsTitle(string termsAndConditionsTitle)
        {
            if (String.Equals(LblTermsAndConditionsTitle.Text, termsAndConditionsTitle, StringComparison.OrdinalIgnoreCase))
                return true;
            return false;
        }

        public bool VerifyTermsAndConditionsDescription(string termsAndConditionsDescription)
        {
            if (String.Equals(LblTermsAndConditionsDescription.Text, termsAndConditionsDescription, StringComparison.OrdinalIgnoreCase))
                return true;
            return false;
        }

        public bool VerifyTermsAndConditionsOfSale(string termsAndConditionsOfSale)
        {
            if (String.Equals(LblTermsAndConditionsOfSale.Text, termsAndConditionsOfSale, StringComparison.OrdinalIgnoreCase))
                return true;
            return false;
        }

        public bool VerifyComplicanceNotficationPageErrorMessage(string complianceNotificationPageErrorMessage)
        {
            if (ChkBoxTncAgreement.Selected)
            {
                ChkBoxTncAgreement.Click();
                BtnContinueToCheckout.Click();
            }
            else
                BtnContinueToCheckout.Click();
            if (DsaUtil.FindElementBy(WebDriver, LblComplianceNotificationPageErrorMessage, TimeSpan.FromSeconds(1)))
                if (String.Equals(WebDriver.GetElement(LblComplianceNotificationPageErrorMessage, TimeSpan.FromMilliseconds(500)).Text, complianceNotificationPageErrorMessage, StringComparison.OrdinalIgnoreCase))
                    return true;
            return false;
        }

        public bool VerifyTermsAndConditionsOfSaleErrorMessage(string termsAndConditionsOfSaleErrorMessage)
        {
            if (ChkBoxTncAgreement.Selected)
            {
                ChkBoxTncAgreement.Click();
                BtnContinueToCheckout.Click();
            }
            else
                BtnContinueToCheckout.Click();
            if (DsaUtil.FindElementBy(WebDriver, LblTermsAndConditionsOfSaleErrorMessage, TimeSpan.FromSeconds(1)))
                if (String.Equals(WebDriver.GetElement(LblTermsAndConditionsOfSaleErrorMessage, TimeSpan.FromMilliseconds(500)).Text, termsAndConditionsOfSaleErrorMessage, StringComparison.OrdinalIgnoreCase))
                    return true;
            return false;
        }

        public bool VerifyTermsAndConditionsOfSaleHyperLinkExists()
        {
            return DsaUtil.IsElementDisplayed(HyperLnkTermsAndConditions, WebDriver, TimeSpan.FromSeconds(50));
        }

        public bool VerifyTermsAndConditionsOfSaleHyperLinkNavigatesToCorrectURL(String url)
        {
            Boolean boolean = false;
            String windowName = WebDriver.CurrentWindowHandle;
            DsaUtil.Click(HyperLnkTermsAndConditions, WebDriver, TimeSpan.FromSeconds(1));
            foreach (String window in WebDriver.WindowHandles)
            {
                if (!windowName.Equals(window))
                {
                    WebDriver.SwitchTo().Window(window);
                }
            }
            boolean = String.Equals(WebDriver.Url, url, StringComparison.OrdinalIgnoreCase);
            WebDriver.Close();
            WebDriver.SwitchTo().Window(windowName);
            return boolean;
        }
        #endregion


        #region Export Compliance Elements

public IWebElement LblExportComplianceHeader { get { return WebDriver.GetElement(By.XPath("//export-compliance//h2[@class='export-compliance-header']")); } }


public IWebElement LblExportOutside { get { return WebDriver.GetElement(By.XPath("//export-compliance//div[@id='ExportOutsideText']")); } }


public IWebElement LblYes { get { return WebDriver.GetElement(By.XPath("//export-compliance//label[@for='yesCheck']")); } }


public IWebElement LblNo { get { return WebDriver.GetElement(By.XPath("//export-compliance//label[@for='noCheck']")); } }



public IWebElement RdbtnYes { get { return WebDriver.GetElement(By.XPath("//export-compliance//input[@id='yesCheck' and @type='radio']")); } }


public IWebElement RdbtnNo { get { return WebDriver.GetElement(By.XPath("//export-compliance//input[@id='noCheck' and @type='radio']")); } }


public IWebElement LblCountryExportedTo { get { return WebDriver.GetElement(By.XPath("//export-compliance//select[@id='countryExportedTo']/parent::div/div")); } }


public IWebElement DdlCountryExportedTo { get { return WebDriver.GetElement(By.XPath("//export-compliance//select[@id='countryExportedTo']")); } }


public IWebElement LblProductUsage { get { return WebDriver.GetElement(By.XPath("//export-compliance//select[@id='productUsage']/parent::div/div")); } }


public IWebElement DdlProductUsage { get { return WebDriver.GetElement(By.Id("productUsage")); } }


public IWebElement LblExportText { get { return WebDriver.GetElement(By.XPath("//export-compliance//div[@id='export-static-text']")); } }

        public By LblExportComplianceErrorMessage = By.XPath("//export-compliance//span[@class='dds__text-danger']");
        //public By RdbtnYesBy = By.XPath("//export-compliance//input[@id='yesCheck' and @type='radio']");
        //public By RdbtnNoBy = By.XPath("//export-compliance//input[@id='noCheck' and @type='radio']");


public IWebElement TxtCompliancePageLegalFooter { get { return WebDriver.GetElement(By.XPath("//div[contains(@class,'footer-text')]")); } }

        #endregion

        #region Export Complicance Methods
        public bool VerifyExportComplianceHeader(string exportComplianceHeader)
        {
            if (String.Equals(LblExportComplianceHeader.Text, exportComplianceHeader, StringComparison.OrdinalIgnoreCase))
                return true;
            return false;
        }
        public bool VerifyLabelExportOutside(string exportOutside)
        {
            if (String.Equals(LblExportOutside.Text, exportOutside, StringComparison.OrdinalIgnoreCase))
                return true;
            return false;
        }

        public bool VerifyLabelsYesNO(string yes, string no)
        {
            if (String.Equals(LblYes.Text, yes, StringComparison.OrdinalIgnoreCase) & String.Equals(LblNo.Text, no, StringComparison.OrdinalIgnoreCase))
                return true;
            return false;
        }


        public void SelectProductUsagebyText(string value)
        {
            DdlProductUsage.PickDropdownByText(WebDriver, value);
        }

        public void SelectCountryExportedTobyText(string value)
        {
            if (!RdbtnYes.Selected)
            {
                WebDriverUtil.ScrollIntoElement(WebDriver, RdbtnYes);
                RdbtnYes.Click();
            }

            DdlCountryExportedTo.PickDropdownByText(WebDriver, value);
        }

        public void SelectProductUsageOption(IWebDriver driver, string option = "7: HOME")
        {
            DdlProductUsage.PickDropdownByValue(driver, option);
        }

        public void SelectCountryExportedToOption(string option = "10: AR")
        {
            DdlCountryExportedTo.PickDropdownByValue(WebDriver, option);
        }

        public bool VerifyExportText(string exportText)
        {
            string s = LblExportText.Text.Replace("\n", "").Replace("\r", "");
            string y = exportText.Replace("\n", "").Replace("\r", "");
            if (String.Equals(LblExportText.Text.Replace("\n", "").Replace("\r", ""), Regex.Replace(exportText, "<.*?>", String.Empty), StringComparison.OrdinalIgnoreCase))
                if (String.Equals(LblExportText.Text.Replace("\n", "").Replace("\r", ""), exportText.Replace("\n", "").Replace("\r", ""), StringComparison.OrdinalIgnoreCase))
                    return true;
            return false;
        }


        public bool VerifyProductUsageErrorMessage(string productUsageErrorMessage)
        {
            SelectProductUsageOption(WebDriver, "-1");
            if (DsaUtil.FindElementBy(WebDriver, LblExportComplianceErrorMessage, TimeSpan.FromSeconds(1)))
                if (String.Equals(WebDriver.GetElement(LblExportComplianceErrorMessage, TimeSpan.FromMilliseconds(500)).Text, productUsageErrorMessage, StringComparison.OrdinalIgnoreCase))
                    return true;
            return false;
        }

        public bool VerifyCountryExportedErrorMessage(string productUsageErrorMessage)
        {

            if (!RdbtnYes.Selected)
            {
                WebDriverUtil.ScrollIntoElement(WebDriver, RdbtnYes);
                RdbtnYes.Click();
            }
            SelectCountryExportedToOption("-1");
            if (DsaUtil.FindElementBy(WebDriver, LblExportComplianceErrorMessage, TimeSpan.FromSeconds(1)))
                if (String.Equals(WebDriver.GetElement(LblExportComplianceErrorMessage, TimeSpan.FromMilliseconds(500)).Text, productUsageErrorMessage, StringComparison.OrdinalIgnoreCase))
                {
                    WebDriverUtil.ScrollIntoElement(WebDriver, RdbtnNo);
                    RdbtnNo.Click();
                    return true;
                }

            return false;
        }

        #endregion


        #region CFO Notofications Elements
        //Need proper Component/Ids/Classes for CFO Notifications


public IWebElement LblNotificationsHeader { get { return WebDriver.GetElement(By.XPath("//h2[contains(text(), 'Notifications')]")); } }


public IList<IWebElement> TxtOrderAckEmails1 { get { return WebDriver.GetElements(By.XPath("//h5[contains(text(), 'order acknowledgement')]/ancestor::div[@class='dds__row']/following-sibling::notification//div[@class='categorized-email-value']")); } }


public IList<IWebElement> TxtOrderConfEmails1 { get { return WebDriver.GetElements(By.XPath("//h5[contains(text(), 'order acknowledgement')]/ancestor::div[@class='dds__row']/following-sibling::notification//div[@class='categorized-email-value']")); } }


public IList<IWebElement> TxtOrderAckEmails { get { return WebDriver.GetElements(By.XPath("//div[@class='ackmargins']//notification//div[@class='email-label-box']/div[@class='email-label']/div[@class='categorized-email-value']")); } }


public IList<IWebElement> TxtOrderConfEmails { get { return WebDriver.GetElements(By.XPath("//div[contains(@class,'ocmargins')]//notification//div[@class='email-label-box']/div[@class='email-label']/div[@class='categorized-email-value']")); } }


public IList<IWebElement> IconRemoveOrderAckEmails { get { return WebDriver.GetElements(By.XPath("//div[@class='ackmargins']//notification//a/span[@class='notification-remove']")); } }


public IList<IWebElement> IconRemoveOrderConfEmails { get { return WebDriver.GetElements(By.XPath("//div[contains(@class,'ocmargins')]//notification//a/span[@class='notification-remove']")); } }


        public By IconAddOrderAckEmail = By.XPath("//div[@class='ackmargins']//notification//a[@id='addEmailButton']");
        public By TextAddOrderAckEmail = By.XPath("//div[@class='ackmargins']//notification//input[@id='emailInputBox']");

        public By IconAddOrderConfEmail = By.XPath("//div[contains(@class,'ocmargins')]//notification//a[@id='addEmailButton']");
        public By TextAddOrderConfEmail = By.XPath("//div[contains(@class,'ocmargins')]//notification//input[@id='emailInputBox']");

        public By LblOrderAckEmailErrorMessage = By.XPath("//div[@class='ackmargins']//notification//span[@class='error-text']");
        public By LblOrderConfEmailErrorMessage = By.XPath("//div[contains(@class,'ocmargins')]//notification//span[@class='error-text']");

        #endregion


        #region CFO Notofications Methods

        public bool AddEmailsInOrderAckSection(string orderACkEmail)
        {
            if (DsaUtil.FindElementBy(WebDriver, IconAddOrderAckEmail, TimeSpan.FromMilliseconds(500)))
            {
                WebDriver.GetElement(IconAddOrderAckEmail, TimeSpan.FromMilliseconds(500)).Click();
                WebDriver.GetElement(TextAddOrderAckEmail, TimeSpan.FromMilliseconds(500)).SetTextChannel(WebDriver, orderACkEmail);
                DsaUtil.Log.Info("Order Ack Email entered : " + orderACkEmail);
                if (DsaUtil.FindElementBy(WebDriver, LblOrderAckEmailErrorMessage, TimeSpan.FromMilliseconds(500)))
                {
                    DsaUtil.Log.Warn("Order Ack Email is not valid : " + orderACkEmail);
                    WebDriver.GetElement(TextAddOrderAckEmail, TimeSpan.FromMilliseconds(500)).SetTextChannel(WebDriver, "");
                    return false;
                }
                else
                {
                    DsaUtil.Log.Info("Order Ack Email Added : " + orderACkEmail);
                    return true;
                }
            }
            return false;
        }

        public bool AddEmailsInOrderConfSection(string orderConfEmail)
        {
            if (DsaUtil.FindElementBy(WebDriver, IconAddOrderConfEmail, TimeSpan.FromMilliseconds(500)))
            {
                WebDriver.GetElement(IconAddOrderConfEmail, TimeSpan.FromMilliseconds(500)).Click();
                WebDriver.GetElement(TextAddOrderConfEmail, TimeSpan.FromMilliseconds(500)).SetTextChannel(WebDriver, orderConfEmail);
                DsaUtil.Log.Info("Order Conf Email entered : " + orderConfEmail);
                if (DsaUtil.FindElementBy(WebDriver, LblOrderConfEmailErrorMessage, TimeSpan.FromMilliseconds(500)))
                {
                    DsaUtil.Log.Warn("Order Conf Email is not valid : " + orderConfEmail);
                    WebDriver.GetElement(TextAddOrderConfEmail, TimeSpan.FromMilliseconds(500)).SetTextChannel(WebDriver, "");
                    return false;
                }
                else
                {
                    DsaUtil.Log.Info("Order Conf Email Added : " + orderConfEmail);
                    return true;
                }
            }
            return false;
        }

        public bool RemoveEmailsInOrderAckSection(string orderAckEmail)
        {

            for (int i = 0; i < TxtOrderAckEmails.Count; i++)
            {
                if (String.Compare(TxtOrderAckEmails[i].Text, orderAckEmail, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    IconRemoveOrderAckEmails[i].Click();
                    DsaUtil.Log.Info("Order Ack Email Removed : " + orderAckEmail);
                    return true;
                }
            }
            DsaUtil.Log.Info("Order Ack Email not found : " + orderAckEmail);
            return false;
        }

        public bool RemoveEmailsInOrderConfSection(string orderConfEmail)
        {

            for (int i = 0; i < TxtOrderConfEmails.Count; i++)
            {
                if (String.Compare(TxtOrderConfEmails[i].Text, orderConfEmail, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    IconRemoveOrderConfEmails[i].Click();
                    DsaUtil.Log.Info("Order Ack Email Removed : " + orderConfEmail);
                    return true;
                }
            }
            DsaUtil.Log.Info("Order Ack Email not found : " + orderConfEmail);
            return false;
        }



        public List<string> EmailsInOrderAck()
        {
            List<string> emails = new List<string>();
            //var listOfEmails = driver.GetElements(By.XPath("//h5[contains(text(), 'order acknowledgement')]/ancestor::div[@class='dds__row']/following-sibling::notification//div[@class='categorized-email-value']"));
            foreach (var element in TxtOrderAckEmails)
            {
                emails.Add(element.Text);
            }
            DsaUtil.Log.Info("Order Ack Emails : " + emails);
            return emails;
        }

        public List<string> EmailsInOrderConfirmation()
        {
            List<string> emails = new List<string>();
            //var listOfEmails =  driver.GetElements( By.XPath("//h5[contains(text(), 'order confirmation')]/ancestor::div[@class='dds__row']/following-sibling::notification//div[@class='categorized-email-value']"));
            foreach (var element in TxtOrderConfEmails)
            {
                emails.Add(element.Text);
            }
            DsaUtil.Log.Info("Order Conf Emails : " + emails);
            return emails;
        }



        public bool EmailExistsInOrderAckAndConfirmation(IWebDriver driver, string email)
        {
            return (EmailsInOrderAck().Contains(email) && EmailsInOrderConfirmation().Contains(email));
        }
        #endregion
        public ChannelPaymentPage ProcessChannelComplianceAndNotificationsPage(IWebDriver driver, String channelPartnerEmail, String totalShippingPrice, String totalSellingPrice, String totalPrice, String productUsage)
        {
            EmailExistsInOrderAckAndConfirmation(driver, channelPartnerEmail);
            LblPricingSummaryTotalShipping.Text.Should().Be(totalShippingPrice);
            LblPricingSummarySellingPrice.Text.Should().Be(totalSellingPrice);
            LblPricingSummaryFinalPrice.Text.Should().Be(totalPrice);
            if (!ChkBoxTncAgreement.Selected)
            {
                ChkBoxTncAgreement.Click(driver);
            }
            SelectProductUsageOption(driver, productUsage);
            BtnContinueToCheckout.Click(driver);

            return new ChannelPaymentPage(driver);
        }

    }
}
