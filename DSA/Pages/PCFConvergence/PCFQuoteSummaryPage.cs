using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.DataModels;
using Dsa.Enums;
using Dsa.Pages.Order;
using Dsa.Pages.PCFConvergence;
using Dsa.Pages.Quote;
using Dsa.Utils;
using Dsa.Workflows;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using HomeWorkFlow = Dsa.Workflows.HomeWorkflow;

namespace Dsa.Pages.PCFConvergence
{
    public class PCFQuoteSummaryPage : DsaPageBase
    {
        private const string PagePrefix = "channelQuoteSummary";

        public PCFQuoteSummaryPage(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "Quote Summary Page";
            webDriver.VerifyBusyOverlayNotDisplayed();

        }



        #region Elements

        //Quote header

        public IWebElement LblExceptionReason { get { return WebDriver.GetElement(By.XPath("//*[@id='resellerExceptionReason']/div[2]/div[2]")); } }
        public IWebElement ChkLargeValueHold { get { return WebDriver.GetElement(By.XPath("//*[@id='checkboxLargeValueHold']/label/input")); } }

        public IWebElement LnkGoToHomePage { get { return WebDriver.GetElement(By.Id("dellBrandLogo_goHomePage")); } }


        public IWebElement LblPageTitle { get { return WebDriver.GetElement(By.Id("quoteTitle")); } }


        public IWebElement LblQuoteNumber { get { return WebDriver.GetElement(By.XPath("//h3[@id='quoteNumber']")); } }


        public IWebElement LblQuoteVersion { get { return WebDriver.GetElement(By.Id("quoteVersionsDropdownId")); } }


        public IWebElement LblOfferNumber { get { return WebDriver.GetElement(By.Id("offerNumber")); } }


        public IWebElement lnkSolutionId { get { return WebDriver.GetElement(By.Id("solutionId")); } }


        public IWebElement LblQuoteValidationMessage { get { return WebDriver.GetElement(By.XPath("//quote-summary-validation//div[contains(@class, 'error')]")); } }


        public IWebElement LblEndUserCustomerNumber { get { return WebDriver.GetElement(By.Id("endUserCustomerNumber")); } }


        public IWebElement LblPoNumber { get { return WebDriver.GetElement(By.Id("poNumber")); } }


        public IWebElement LblQuoteCreatedBy { get { return WebDriver.GetElement(By.Id("createdBy")); } }


        public IWebElement LblQuoteExpirationDate { get { return WebDriver.GetElement(By.Id("ExpirationDate")); } }

        public IWebElement QuoteExpirationDateValue { get { return WebDriver.GetElement(By.Id("headerExpiresOnValue")); } }

        public IWebElement LnkShowMore { get { return WebDriver.GetElement(By.Id("quote-summary-heading")); } }

        public IWebElement GoalLiteDealIdStatusLabel { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_goalLiteApprovalStatus_label']")); } }

        public IWebElement GoalLiteDealIdStatus { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_goalLiteApprovalStatus_label']/../span/label")); } }

        public IWebElement GoalLiteDealId { get { return WebDriver.GetElement(By.Id("goalLiteDealId")); } }

        public IWebElement LnkShowLess { get { return WebDriver.GetElement(By.XPath("//button//span[contains(text(), 'See Less')]")); } }

        public IWebElement ContinuetoCreateOrder { get { return WebDriver.GetElement(By.Id("continueToCheckoutButton")); } }

        public IWebElement LblQuoteCreatedOn { get { return WebDriver.GetElement(By.XPath("//*[@id='CreatedOn']")); } }

        public IWebElement SalesHoldErrorNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Customer is on a Sales Hold')]")); } }

        public IWebElement SendAnywayButton { get { return WebDriver.GetElement(By.XPath("//*[@id='proceed-button']")); } }

        //Bill To and SoldTo

        public IWebElement SoldToSection { get { return WebDriver.GetElement(By.XPath("//*[@id='soldToCustomer_title']/h3")); } }


        public IWebElement LblBillToCustomerNumber { get { return WebDriver.GetElement(By.Id("billingCustomer_customerNumber")); } }


        public IWebElement LblBillToCustomerContactName { get { return WebDriver.GetElement(By.Id("billingCustomer_contactname")); } }


        public IWebElement LblBillToCustomerAddress { get { return WebDriver.GetElement(By.Id("billingCustomer_address")); } }


        public IWebElement LblBillToCustomerPhone { get { return WebDriver.GetElement(By.Id("billingCustomer_phone")); } }


        public IWebElement LblBillToCustomerEmail { get { return WebDriver.GetElement(By.Id("billingCustomer_email")); } }


        public IWebElement LblSoldToCustomerNumber { get { return WebDriver.GetElement(By.Id("soldToCustomer_customerNumber")); } }


        public IWebElement LblSoldToCustomerContactName { get { return WebDriver.GetElement(By.Id("soldToCustomer_contactname")); } }


        public IWebElement LblSoldToCustomerAddress { get { return WebDriver.GetElement(By.Id("soldToCustomer_address")); } }


        public IWebElement LblSoldToCustomerPhone { get { return WebDriver.GetElement(By.Id("soldToCustomer_phone")); } }


        public IWebElement LblSoldToCustomerEmail { get { return WebDriver.GetElement(By.Id("soldToCustomer_email")); } }


        public IWebElement ShippingToSection { get { return WebDriver.GetElement(By.XPath("//*[@id='ShipGroup0_shipTo_title']/h3")); } }


        public IWebElement LblShipToCustomerNumber { get { return WebDriver.GetElement(By.Id("ShipGroup0_shipTo_customerNumber")); } }


        public IWebElement LblShipToCustomerContactName { get { return WebDriver.GetElement(By.Id("ShipGroup0_shipTo_contactname")); } }


        public IWebElement LblShipToCustomerAddress { get { return WebDriver.GetElement(By.Id("ShipGroup0_shipTo_address")); } }


        public IWebElement LblShipToCustomerPhone { get { return WebDriver.GetElement(By.Id("ShipGroup0_shipTo_phone")); } }


        public IWebElement LblShipToCustomerEmail { get { return WebDriver.GetElement(By.Id("ShipGroup0_shipTo_email")); } }

        public IWebElement EditBillToAddress { get { return WebDriver.GetElement(By.XPath("//*[@id='GM_billingCustomer']/div[5]//a")); } }

        public IWebElement EditSoldToAddress { get { return WebDriver.GetElement(By.XPath("//*[@id='GM_soldToCustomerCtrl']/div[5]//a")); } }

        public IWebElement EditContactOptInEmail { get { return WebDriver.GetElement(By.Id("emailMarketingPreference-Y")); } }

        public IWebElement EditContactOptOutEmail { get { return WebDriver.GetElement(By.Id("emailMarketingPreference-N")); } }

        public IWebElement EditContactOptInMail { get { return WebDriver.GetElement(By.Id("directMailMarketingPreference-Y")); } }

        public IWebElement EditContactOptOutMail { get { return WebDriver.GetElement(By.Id("directMailMarketingPreference-N")); } }

        public IWebElement EditContactOptInMobile { get { return WebDriver.GetElement(By.Id("mobileMarketingPreference-Y")); } }

        public IWebElement EditContactOptOutMobile { get { return WebDriver.GetElement(By.Id("mobileMarketingPreference-N")); } }

        public IWebElement EditContactOptInPhone { get { return WebDriver.GetElement(By.Id("phoneMarketingPreference-Y")); } }

        public IWebElement EditContactOptOutPhone { get { return WebDriver.GetElement(By.Id("phoneMarketingPreference-N")); } }

        public IWebElement BtnEditContactSubmit { get { return WebDriver.GetElement(By.Id("editContactFormSubmit")); } }

        public IWebElement QuoteSummaryHeaderCurrency { get { return WebDriver.GetElement(By.Id("header-currency-code")); } }

        // Edit Address

        public IWebElement MobilePhone { get { return WebDriver.GetElement(By.Id("mobile-phoneNumberInput-validation")); } }

        public IWebElement WorkPhoneCountryCode { get { return WebDriver.GetElement(By.Id("work-phoneCountryCodeInput-validation")); } }

        public IWebElement WorkPhone { get { return WebDriver.GetElement(By.Id("work-phoneNumberInput-validation")); } }

        public IWebElement EmailInvoice { get { return WebDriver.GetElement(By.Id("invoicingEmailInput-validation")); } }

        public IWebElement InvalidEmailWarningMsg { get { return WebDriver.GetElement(By.Id("invoicingEmailInput-validationFeedback")); } }
        public IWebElement DbcGridNotification { get { return WebDriver.GetElement(By.XPath("//*[@id='smb_summary_dbc_header']/following-sibling::div/span")); } }
        public IWebElement DbcGridHeader { get { return WebDriver.GetElement(By.Id("smb_summary_dbc_header")); } }

        public void EditContactEmail(String emailAddress)
        {
            EmailInvoice.Clear();
            EmailInvoice.SetText(WebDriver, emailAddress);
        }

        public void EditContactMobile(String mobileNumber)
        {
            MobilePhone.Clear();
            MobilePhone.SetText(WebDriver, mobileNumber);
        }

        public void EditContactWork(String countryCode, String phoneNumber)
        {
            WorkPhoneCountryCode.SetText(WebDriver, countryCode);
            WorkPhone.Clear();
            WorkPhone.SetText(WebDriver, phoneNumber);
        }

        public IWebElement EditAddressCancel { get { return WebDriver.GetElement(By.XPath("//button[contains(text(),'Cancel')]")); } }

        public IWebElement LangEnglish { get { return WebDriver.GetElement(By.Id("CALanguageOptionEnglish")); } }

        public IWebElement LangFrench { get { return WebDriver.GetElement(By.Id("CALanguageOptionFrench")); } }

        //Shipping information

        public IWebElement BtnExpandOrCollapseAll { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Shipping Info')]/button")); } }


        public IWebElement BtnShippingGrpExpandOrCollapseAll { get { return WebDriver.GetElement(By.XPath("//div//button[contains(@class, 'item-details-info dds__btn-link dds__btn-secondary dds__btn-sm expand-all-btn')]")); } }


        public IWebElement ShippingGroupAccordion { get { return WebDriver.GetElement(By.XPath("//div//button//i[contains(@class, 'dds__icons dds__chevron-right accordion-lg accordion-sm')]")); } }


        public IWebElement EndUserName { get { return WebDriver.GetElement(By.XPath("//*[@id='endUserCompanyName']/span[2]")); } }


        public IWebElement ResellerSection { get { return WebDriver.GetElement(By.Id("resellerCustomer_title")); } }


        public IWebElement LblResellerCompName { get { return WebDriver.GetElement(By.XPath("//*[@id='resellerCustomer_title']/text()")); } }


        public IWebElement LblResellerAddress { get { return WebDriver.GetElement(By.Id("resellerCustomer_address")); } }

        public IWebElement ResellerCustomerORAddressInfo(int index)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='resellerCustomer_address']/div[" + index + "]"));
        }

        public IWebElement ResellerContactInfo()
        {
            return WebDriver.FindElement(By.Id("resellerCustomer_phone"));
        }
        public IWebElement ResellerEmail()
        {
            return WebDriver.FindElement(By.Id("resellerCustomer_email"));
        }
        public IWebElement ResellerContactName()
        {
            return WebDriver.FindElement(By.Id("resellerCustomer_contactname"));
        }

        public Address GetResellerAddrInfo()
        {
            Logger.Write("Getting all Info from Reseller Address");

            var ResellerAddress = new Address
            {
                FirstName = ResellerContactName().GetText(WebDriver).Split(' ')[0].Trim(),       
                LastName= ResellerContactName().GetText(WebDriver).Split(' ')[1].Trim(),
                AddressLine1 = String.Format(ResellerCustomerORAddressInfo(1).GetText(WebDriver) + "  " + ResellerCustomerORAddressInfo(2).GetText(WebDriver)).Trim(),
                AddressLine2 = ResellerCustomerORAddressInfo(3).GetText(WebDriver).Trim(),
                PrimaryPhone = ResellerContactInfo().GetText(WebDriver).Replace(" ",String.Empty),
                Email = ResellerEmail().GetText(WebDriver),
            };

            return ResellerAddress;
        }

        public IWebElement GroupLevelShippingAddress { get { return WebDriver.GetElement(By.Id("GM_ShipGroup0_shipTo")); } }

        // PMC 
        public IWebElement CustomerConsentScriptLink { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Show/Hide Customer Consent')]")); } }

        public IWebElement GetCustomerConsentScriptText { get { return WebDriver.GetElement(By.XPath("//*[@id='customer-consent-accordion_accordion']/div/div")); } }

        public void VerifyCustomerConsentScript(DataRow row)
        {
            CustomerConsentScriptLink.Click(WebDriver);
            GetCustomerConsentScriptText.GetText(WebDriver).Should().Contain("I’d like to tell you about how we use your personal information. Dell Technologies");
            EditAddressCancel.Click();
        }

        public IWebElement CustomerConsentNotifications { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Please read customer consent and make preference selections.')]")); } }

        public IWebElement PMCUpdateNotifications { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Any update to PMC will take up to 24/48 hours to reflect in DSA.')]")); } }

        //Item Level

        public IWebElement LblItemDetails { get { return WebDriver.GetElement(By.XPath("//div[contains(@id, 'shipping_group_Item_panel')]/div[2]")); } }


        public IWebElement BtnItemGrpExpandOrCollapseAll { get { return WebDriver.GetElement(By.XPath("//div//button[contains(@class, 'item-details-info dds__btn dds__btn-secondary dds__btn-sm expand-all-btn')]")); } }

        public IWebElement ItemDescription { get { return WebDriver.GetElement(By.Id("itemDescription_0")); } }

        //Sku Level

        public IWebElement LblSkuDetails { get { return WebDriver.GetElement(By.XPath("//div[contains(@class, 'configuration-option-details')]")); } }


        public IWebElement BtnSkuGrpExpandOrCollapseAll { get { return WebDriver.GetElement(By.XPath("//div//button[contains(text(), 'Expand All')]")); } }

        //Pricing Summary 

        public IWebElement LblPricingSummaryListPrice { get { return WebDriver.GetElement(By.Id("pricingSummary_listPrice")); } }


        public IWebElement LblPricingSummaryDiscount { get { return WebDriver.GetElement(By.XPath("//*[@id='pricingSummary_discount']")); } }
        public IWebElement LblPricingSummaryDiscountPercentage { get { return WebDriver.GetElement(By.XPath("//*[@id='pricingSummary_discountPercentage']")); } }


        public IWebElement LblPricingSummarySellingPrice { get { return WebDriver.GetElement(By.Id("pricingSummary_sellingPrice")); } }


        public IWebElement LblPricingSummaryShippingPrice { get { return WebDriver.GetElement(By.Id("pricingSummary_shippingPrice")); } }


        public IWebElement LblPricingSummaryShippingDiscount { get { return WebDriver.GetElement(By.Id("pricingSummary_shippingDiscount")); } }


        public IWebElement LblPricingSummaryTotalShipping { get { return WebDriver.GetElement(By.Id("pricingSummary_shippingAmount")); } }


        public IWebElement LblPricingSummaryTaxableAmount { get { return WebDriver.GetElement(By.Id("pricingSummary_taxableAmount")); } }


        public IWebElement LblPricingSummaryNonTaxableAmount { get { return WebDriver.GetElement(By.Id("pricingSummary_nonTaxableAmount")); } }


        public IWebElement LblPricingSummaryTotalTax { get { return WebDriver.GetElement(By.Id("pricingSummary_totalTax")); } }


        public IWebElement LblPricingSummarySubTotal { get { return WebDriver.GetElement(By.Id("pricingSummary_subTotal")); } }


        public IWebElement LblPricingSummaryTotalEcoFee { get { return WebDriver.GetElement(By.Id("pricingSummary_eco")); } }


        public IWebElement LblPricingSummaryFinalPrice { get { return WebDriver.GetElement(By.Id("pricingSummary_finalPrice")); } }
        //Sales Rep

        public IWebElement LblSalesRepName { get { return WebDriver.GetElement(By.Id("salesRep_name")); } }


        public IWebElement LblSalesRepEmail { get { return WebDriver.GetElement(By.Id("salesRep_email")); } }


        public IWebElement LblSalesRepPhone { get { return WebDriver.GetElement(By.Id("salesRep_phone")); } }


        public IWebElement LblSalesRepDetails { get { return WebDriver.GetElement(By.XPath("//sales-rep//div//div[contains(@class, 'dds__col-12 dell-content')]")); } }


        public IWebElement LblPrimarySalesRep { get { return WebDriver.GetElement(By.Id("salesrep_primary_text")); } }

        //Navigation buttons


        public IWebElement BtnBack { get { return WebDriver.GetElement(By.Id("BackButton")); } }


        public IWebElement BtnContinueToCheckout { get { return WebDriver.GetElement(By.Id("continueToCheckoutButton")); } }


        public IWebElement BtnDrpdownCheckout { get { return WebDriver.GetElement(By.Id("continueToCheckoutSplitButton")); } }


        public IWebElement BtnCreateOrder { get { return WebDriver.GetElement(By.Id("createOrderLink")); } }


        public IWebElement BtnSendToPOMProcessing { get { return WebDriver.GetElement(By.Id("SendToPomLink")); } }


        public IWebElement BottomScreenCheckoutBtn { get { return WebDriver.GetElement(By.Id("PaymentButton")); } }


        public IWebElement LblProgressTrackerBar { get { return WebDriver.GetElement(By.Id("PartnerProgressBar")); } }


        public IWebElement BtnAdditionalQuoteDetails { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), ' Show additional quote details ')]")); } }


        public IWebElement ShowFullQuoteDetailSections { get { return WebDriver.GetElement(By.XPath("//div[contains(@class, 'mg-top-10 pd-top-10 dell-content dds__form-group')]")); } }


        public IWebElement TxtShippingInstructions { get { return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_panel_0']/div[4]/div")); } }


        public IWebElement TxtSummaryPageLegalFooter { get { return WebDriver.GetElement(By.XPath("//div[contains(@class,'footer-text')]")); } }


        public IWebElement SubscriptionBillingFlyout { get { return WebDriver.GetElement(By.Id("quoteDetailsSubscriptionBillingBtn")); } }

        public IWebElement LnkInstallationInstructionsHeader { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Installation Instructions')]")); } }

        public IWebElement FinancialInfoToggle { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Bill to Customer Financial Information')]")); } }

        public IWebElement PrimarySalesRep { get { return WebDriver.GetElement(By.Id("salesrep_primary_text")); } }

        public IWebElement TxtInstallationInstruction { get { return WebDriver.GetElement(By.Id("installation-instructions-text")); } }

        public IWebElement MultipleShipAddressWarningMsg { get { return WebDriver.GetElement(By.Id("warningMessage0")); } }

        public IWebElement quoteSummaryPagePONumber { get { return WebDriver.GetElement(By.Id("headerPoNumberInput")); } }
        public IWebElement LblQuoteTitle { get { return WebDriver.GetElement(By.Id("quoteName")); } }

        public string GetQuoteTitle()
        {
            return LblQuoteTitle.GetText(WebDriver);
        }

        public IWebElement MsgReservationCancelled { get { return WebDriver.GetElement(By.Id("warningMessage0")); } }

        public IWebElement TextTagSalesRepNum(int tagSalesRepNum)
        {
            return WebDriver.GetElements(By.XPath("//*[@id='quote-summary-sales-rep_accordion']//span"))[(int)tagSalesRepNum];
        }

        public IWebElement RemoveTagSalesRep(int tagSalesRepNum)
        {
            return WebDriver.GetElement(By.Id("salesrep_delete_" + tagSalesRepNum), TimeSpan.FromSeconds(5));
        }

        public IWebElement LblItemLevelUnitListPrice(int groupIndex = 1, int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[1]/div[2]/div[2]"));
        }

        public IWebElement LblItemLevelUnitCost(int groupIndex = 1, int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[1]/div[3]/div[2]"));
        }

        public IWebElement LblItemLevelUnitDiscount(int groupIndex = 1, int lineItemIndex = 1)
        {
            //return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[1]/div/div[3]/div[2]"));
            
            //For Production
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[1]/div[3]/div[2]"));
        }

        public IWebElement LblItemLevelDiscountOffList(int groupIndex = 1, int lineItemIndex = 1)
        {
            //return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[2]/div[1]/item-discounts/div/div/div[3]/div/div/smart-price-popover"));
            
            //For Production
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[2]/div[3]/div[2]"));
        }

        public IWebElement LblItemLevelUnitSellingPrice(int groupIndex = 1, int lineItemIndex = 1)
        {
            //return WebDriver.GetElement(By.XPath("//*[@id='smartPricePopover_selingPrice']"));

            //For Production
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']//div[contains(text(),'Unit Selling Price')]//parent::div/div[2]"));

        }

        public IWebElement LblItemLevelUnitMargin(int groupIndex = 1, int lineItemIndex = 1)
        {
            //return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[1]/div/div[6]/div[2]"));
            
            //Production
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']//div[contains(text(),'Unit Margin')]//parent::div/div[2]"));
        }

        public IWebElement LblItemLevelQuantity(int groupIndex = 1, int lineItemIndex = 1)
        {
            //return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[2]/div[1]/div[2]"));
            
            //Production
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[2]/div[1]/div[2]/b"));
        }

        public IWebElement LblContractCode(int groupIndex = 1, int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[2]/div[2]/item-contract-details/div/div/div[1]/div[2]/b"));
        }

        public IWebElement LblContractCodePaymentTerms(int groupIndex = 1, int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[2]/div[2]/item-contract-details/div/div/div[3]/div[2]"));
        }

        public IWebElement LblItemLevelTotalDiscount(int groupIndex = 1, int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[2]/div[3]/div[2]"));
        }

        public IWebElement LblItemLevelMargin(int groupIndex = 1, int lineItemIndex = 1)
        {
            //return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[2]/div[6]/div[2]"));
            
            //Production
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[2]/div[5]/div[2]"));
        }

        public IWebElement LblItemLevelPromotions(int groupIndex = 1, int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']//div[contains(text(),'Promotions')]//parent::div/div[2]/b"));
        }

        public IWebElement LblItemLevelTotalListPrice(int groupIndex = 1, int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[2]/div[2]/div[2]"));
        }

        public IWebElement LblItemLevelTotalSellingPrice(int groupIndex = 1, int lineItemIndex = 1)
        {
            //return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[2]/div[5]/div[2]"));
            
            //Production
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[2]/div[4]/div[2]"));
        }

        public IWebElement GetGroupLevel_ShippingMethod(int? groupItemIndex = 0)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_panel_" + groupItemIndex + "']/shipments-summary-base/shipments-summary/div[2]/div[1]/div/span[2]"));
        }

        public IWebElement ByLblSummaryTotalShipping { get { return WebDriver.GetElement(By.XPath("//*[@id='total-shipping']/span[2]")); } }

        public IWebElement BtnSaveQuote { get { return WebDriver.GetElement(By.Id("quoteCreate_saveQuote")); } }

        public IWebElement BtnCopyAsVersion { get { return WebDriver.GetElement(By.Id("btnCopyAsVersion")); } }

        public IWebElement CopyQuoteBtn { get { return WebDriver.GetElement(By.Id("copyQuoteBtn")); } }

        public IWebElement DsaSourceAppTxt { get { return WebDriver.GetElement(By.XPath("//quote-header-details//div//div//div[2]//div[8]//span[2]")); } }

        public IWebElement CcpSourceAppTxt { get { return WebDriver.GetElement(By.XPath("//quote-header-details//div//div//div[2]//div[5]//span[2]")); } }

        public IWebElement ExpandServiceTag(string serviceTag)
        {
            return WebDriver.GetElement(By.XPath("(//span[contains(text(), '" + serviceTag + "')])[2]"));
        }

        public IWebElement GetServiceTagSkuDetails(int? rowIndex, int? columnIndex)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='option_0_0_0_config_accordion']//div//div//table//tbody//tr[" + rowIndex + "]//td[" + columnIndex + "]"));
        }

        #endregion

        #region Cloud - DTCP/Dimension

        public IWebElement RateCardSummaryTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Rate Card Summary')]")); } }

        public IWebElement CloudDimensionVxRailText { get { return WebDriver.GetElement(By.XPath("(//*[contains(text(), 'VMWare Cloud on DellEMC')])[1]")); } }

        public IWebElement BackbuttonSubscriptionBillingFlyout { get { return WebDriver.GetElement(By.XPath("(//span[contains(text(), 'Back')])[2]")); } }

        public IWebElement BillPlanTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Bill Plan ID')]")); } }

        public IWebElement PaymentTypeTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Payment Type')]")); } }

        public IWebElement CCNumberTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'CC Number')]")); } }

        public IWebElement NextPaymentTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Next Payment')]")); } }

        public int GetCadenceGridSummaryCount()
        {
            return WebDriver.FindElements(By.XPath("//table[@class='c-data-grid c-data-grid-table table table-layout-fixed']")).Count;
        }

        public IWebElement GetSkuSummaryGrid(int? summaryGridIndex)
        {
            return WebDriver.FindElement(By.XPath("(//table[@class='c-data-grid c-data-grid-table table table-layout-fixed'])[" + summaryGridIndex + "]"));
        }

        public IWebElement BackIconSubscriptionBillingFlyout { get { return WebDriver.GetElement(By.XPath("(//span[contains(text(), 'Back')])[2]")); } }

        public IWebElement OfferSubscriptionDisclosureTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Offer Subscription Disclosures and Terms and Conditions')]")); } }

        public IWebElement SkuLevelDisclosureTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'SKU Level Disclosures')]")); } }

        public IWebElement MergeQuoteDialog_Count { get { return WebDriver.GetElement(By.Id("mergeQuote_mergeCount")); } }

        public IWebElement DbcHeader { get { return WebDriver.GetElement(By.Id("smb_summary_dbc_header")); } }

        #endregion

        #region OMS

        public IWebElement ExportProductUsage { get { return WebDriver.GetElement(By.Id("exportComplianceEndUse")); } }

        public IWebElement ExportComplianceLink { get { return WebDriver.GetElement(By.Id("exportComplianceViewLink")); } }

        public IWebElement GTPId { get { return WebDriver.GetElement(By.Id("gtpId")); } }

        public IWebElement GTPIdLink { get { return WebDriver.GetElement(By.Id("gtpToolLink")); } }

        public IWebElement EndUseRequiredErrNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'The export compliance end-use is required.')]")); } }

        public IWebElement GtpIdRequiredWarningNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'The selected export compliance end-use requires a GTP ID to create order.')]")); } }

        public IWebElement GtpValidationMessage { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Valid GTP ID should be entered.')]")); } }

        #endregion

        #region POS FB/Warranty

        public IWebElement McAfeeHeaderTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'McAfee Subscription with Auto-Renewal')]")); } }

        public IWebElement OfferDisclosureTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Offer Subscription Disclosures and Terms and Conditions')]")); } }

        public IWebElement SkuLvlDisclosureTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'SKU Level Disclosures')]")); } }

        public IWebElement FirstPeriodChargeTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'First period charge prorated (estimated) per unit')]")); } }

        public IWebElement FullPeriodChargeTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Full period charge per unit')]")); } }

        public IWebElement QuantityTxt { get { return WebDriver.GetElement(By.XPath("(//*[contains(text(), 'Quantity')])[2]")); } }

        public IWebElement TotalFullPeriodChargeTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Total full period charge')]")); } }

        public IWebElement FirstPeriodChargeProratedTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'First period charge prorated (estimated) per unit')]")); } }

        public IWebElement CoveragePeriodTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Coverage Period')]")); } }

        public IWebElement RenewalDateTxt { get { return WebDriver.GetElement(By.XPath("(//*[contains(text(), 'Renewal Date')])[3]")); } }

        public IWebElement TermsAndConditionsLnk { get { return WebDriver.GetElement(By.XPath("(//*[contains(text(), 'Terms and Conditions')])[2]")); } }

        public IWebElement ConsumerServicesTxt { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Consumer Subscription Services')]")); } }

        public IWebElement TiedMicrosoftSubscriptionTxt { get { return WebDriver.GetElement(By.XPath("(//div[contains(text(), 'Microsoft 365 Family')])[1]")); } }

        public IWebElement NonTiedMicrosoftSubscriptionTxt { get { return WebDriver.GetElement(By.XPath("(//div[contains(text(), 'Auto-Renewal  POS')])[1]")); } }

        #endregion

        #region PCFQuoteSummaryElements  

        //Login Section


        public IWebElement LnkSignIn { get { return WebDriver.GetElement(By.Id("lemcEmployeeLoginLink")); } }

        //Quote Section

        public IWebElement LblQuoteCopiedFrom { get { return WebDriver.GetElement(By.XPath("//*[@id='copiedFromId']/a")); } }


        public IWebElement ExpandItemViewMore { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'quoteDetail_SEItem_show_more')]//a")); } }
        public IWebElement LblSummaryMargin { get { return WebDriver.GetElement(By.XPath("//*[@id='pricingSummary_margin']")); } }


        public IWebElement BtnDellLogo { get { return WebDriver.GetElement(By.Id("DellIcon")); } }


        public IWebElement BtnReturnToTop { get { return WebDriver.GetElement(By.XPath("//*[@id='ReturnToTop']")); } }


        public IWebElement BtnLinkedQuote { get { return WebDriver.GetElement(By.XPath("//*[@id='linkedQuotesDropDown']")); } }


        public IWebElement TxtListLinkedQuote { get { return WebDriver.GetElement(By.XPath("//*[@id='linkedQuotesDropDownButton']")); } }


        public IWebElement BtnSendQuote { get { return WebDriver.GetElement(By.Id("sendQuoteBtn")); } }


        public IWebElement OrderedDpid { get { return WebDriver.GetElement(By.XPath("//div//a[contains(@class, 'dds__mr-2 quoteHeaderFieldValue')]")); } }

        //Item Level Elements

        public IWebElement LblItemDetail { get { return WebDriver.GetElement(By.XPath("shipping_group_Item_panel_0_0_eqZuE_3azEqUX71-M-n4tA")); } }


        public IWebElement LnkQuoteVersionDropDown { get { return WebDriver.GetElement(By.Id("quoteVersionsDropdownId")); } }


        public IWebElement HdrQuoteSummaryPage { get { return WebDriver.GetElement(By.Id("quoteTitle")); } }

        //Autopilot

        public IWebElement LblTenantId { get { return WebDriver.GetElement(By.Id("AutoPilot_0_0_tenantid_input")); } }


        public IWebElement LblDomainId { get { return WebDriver.GetElement(By.Id("AutoPilot_0_0_domain_input")); } }


        public IWebElement TxtEnterTenantID { get { return WebDriver.GetElement(By.XPath("//div[contains(text(), ' Please enter a valid Tenant ID. ')]")); } }


        public IWebElement TxtEnterDomainID { get { return WebDriver.GetElement(By.XPath("//div[contains(@class, 'validation-error auto_pilot_domain_validation_error')]")); } }


        public IWebElement TxtWarningInfo { get { return WebDriver.GetElement(By.XPath("//*[@id='infoMessage0']")); } }

        //Promotions Section

        public IWebElement PromotionsHyprLnk { get { return WebDriver.GetElement(By.XPath("//a[contains(@class, 'dds__btn-link dds__text data-wrap')]")); } }


        public IWebElement PromoDescription { get { return WebDriver.GetElement(By.XPath("//*[@id='longDescription']")); } }


        public IWebElement PromoCampaignType { get { return WebDriver.GetElement(By.XPath("//*[@id='campaignType']")); } }


        public IWebElement PromoExpiryDate { get { return WebDriver.GetElement(By.XPath("//*[@id='expiryDate']")); } }


        public IWebElement BtnClosePromoPopup { get { return WebDriver.GetElement(By.XPath("//*[@id='campaignDialogContent']/div[2]/button")); } }

        //Quote Details Elements

        public IWebElement QuoteCreatedBy { get { return WebDriver.GetElement(By.Id("headerCreatedByValue")); } }


        public IWebElement QuoteCreatedOn { get { return WebDriver.GetElement(By.Id("headerCreatedOnValue")); } }


        public IWebElement QuoteExpiresOn { get { return WebDriver.GetElement(By.Id("datepicker-input")); } }


        public IWebElement QuoteStatus { get { return WebDriver.GetElement(By.Id("headerQuoteStatusValue")); } }


        public IWebElement LnkAdditionalQuoteDetails { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), ' Show additional quote details ')]")); } }


        public IWebElement ServiceTag { get { return WebDriver.GetElement(By.XPath("//div//div//h5//button[contains(@class, 'dds__accordion-btn dds__d-flex')]")); } }

        //Bill To And Sold To Section

        public IWebElement LblBillingCustomerName { get { return WebDriver.GetElement(By.Id("billingCustomer_contactname")); } }


        public IWebElement LblBillingCustomerPhoneNumber { get { return WebDriver.GetElement(By.Id("billingCustomer_phone")); } }


        public IWebElement LblBillingAddress1 { get { return WebDriver.GetElement(By.XPath("//*[@id='billingCustomer_address']/div[1]")); } }


        public IWebElement LblBillingAddress2 { get { return WebDriver.GetElement(By.XPath("//*[@id='billingCustomer_address']/div[3]")); } }


        public IWebElement LblBillingEmailAddress { get { return WebDriver.GetElement(By.Id("billingCustomer_email")); } }


        public IWebElement LblSellingCustomerName { get { return WebDriver.GetElement(By.Id("soldToCustomer_contactname")); } }


        public IWebElement LblSellingCustomerPhoneNumber { get { return WebDriver.GetElement(By.Id("soldToCustomer_phone")); } }


        public IWebElement LblSellingAddress1 { get { return WebDriver.GetElement(By.XPath("//*[@id='soldToCustomer_address']/div[1]")); } }


        public IWebElement LblSellingAddress2 { get { return WebDriver.GetElement(By.XPath("//*[@id='soldToCustomer_address']/div[3]")); } }


        public IWebElement LblSellingEmailAddress { get { return WebDriver.GetElement(By.Id("soldToCustomer_email")); } }


        public IWebElement SellingEntity { get { return WebDriver.GetElement(By.XPath("//*[@id='[SOME_ID]']//div[2]/div[4]/div[2]")); } }


        public IWebElement LblQuoteStatus { get { return WebDriver.GetElement(By.Id("headerQuoteStatusValue")); } }

        public IWebElement LblGroupLevelShippingInfoEdd(int? groupIndex = 0)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_panel_" + groupIndex + "']/shipments-summary-base/shipments-summary/div[4]/div[1]/div/span[2]"));
        }

        public IWebElement GetCustomPriceNotification(int? index = 0)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='infoMessage" + index + "']"));
        }

        public IWebElement GetMABD(int? groupIndex = 0)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_panel_" + groupIndex + "']/shipments-summary-base/shipments-summary/div[5]/div/div/span[2]"));
        }


        //Shipping To Section

        public IWebElement LblShipToCustomerName { get { return WebDriver.GetElement(By.Id("ShipGroup0_shipTo_contactname")); } }


        public IWebElement LblShipToCustomerPhoneNumber { get { return WebDriver.GetElement(By.Id("ShipGroup0_shipTo_phone")); } }


        public IWebElement LblShipToAddress1 { get { return WebDriver.GetElement(By.XPath("//*[@id='ShipGroup0_shipTo_address']/div[1]")); } }


        public IWebElement LblShipToAddress2 { get { return WebDriver.GetElement(By.XPath("//*[@id='ShipGroup0_shipTo_address']/div[3]")); } }


        public IWebElement LblShipToEmailAddress { get { return WebDriver.GetElement(By.Id("ShipGroup0_shipTo_email")); } }


        public IWebElement LblShippingMethod { get { return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_panel_0']/div[3]//div[2]")); } }


        public IWebElement LblShippingPrice { get { return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_panel_0']/div[4]/div[2]/div")); } }


        public IWebElement LblEstimatedShipDate { get { return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_panel_0']/div[5]/div[2]/div")); } }


        public IWebElement LblShippingInstructions { get { return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_panel_0']/div[5]/div[3]/div[2]/ol/li/span")); } }


        public IWebElement UCIDNumberInstallAtAddr { get { return WebDriver.GetElement(By.Id("ShipGroup0_installAt_UCID")); } }


        public IWebElement UCIDNumberShipTo { get { return WebDriver.GetElement(By.Id("ShipGroup0_shipTo_UCID")); } }


        public IWebElement LblShowingShipGrpIndex { get { return WebDriver.GetElement(By.Id("shipping-group-index")); } }

        //Bill To Customer Information

        public IWebElement LnkBillToCustomerInformation { get { return WebDriver.GetElement(By.Id("billToCustomerInformation_header")); } }


        public IWebElement LblCompanyNumber { get { return WebDriver.GetElement(By.Id("billToCustomerInformation_companyNumber")); } }


        public IWebElement LblCustomerClass { get { return WebDriver.GetElement(By.Id("billToCustomerInformation_customerClass")); } }


        public IWebElement LblCustomerStatus { get { return WebDriver.GetElement(By.Id("billToCustomerInformation_customerStatus")); } }

        //Bill To Customer Financial Information

       // public IWebElement LnkBillToCustomerFinancialInformation { get { return WebDriver.GetElement(By.XPath("//h5//button//span[contains(@class, 'financeinfo-header accordion-header')]")); } }
        public IWebElement LnkBillToCustomerFinancialInformation { get { return WebDriver.GetElement(By.XPath("//*[@id='billToCustomerFinancialInfo_header']/button/div/span")); } }


        public IWebElement LblPaymentMethod { get { return WebDriver.GetElement(By.Id("billToCustomerFinancialInfo_paymentMethod")); } }


        public IWebElement LblPaymentTerms { get { return WebDriver.GetElement(By.XPath("//*[@id='billToCustomerFinancialInfo_paymentTerms']")); } }

        //Installation Instructions

        public IWebElement LnkInstallInstruction { get { return WebDriver.GetElement(By.XPath("//h5//button//span[contains(@class, 'accordion-header installation-accordion-lg')]")); } }


        public IWebElement TxtInstallInstruction { get { return WebDriver.GetElement(By.XPath("//*[@id='installation-instructions-text']")); } }

        //Solution Element Section

        public IWebElement SolutionNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='solutionId']/a")); } }

        //Customer Dashboard Section

        public IWebElement DashboardIcon { get { return WebDriver.GetElement(By.XPath("//*[@id='customerDashboardDropdown']/span")); } }


        public IWebElement LnkViewForCustomer { get { return WebDriver.GetElement(By.Id("dashboardByCustomer")); } }


        public IWebElement LnkViewForAccount { get { return WebDriver.GetElement(By.Id("dashboardByAccount")); } }


        public IWebElement CustomerNumberFromPopup { get { return WebDriver.GetElement(By.Id("customerdetails_number")); } }


        public IWebElement CustomerNameFromPopup { get { return WebDriver.GetElement(By.Id("customerdetails_name")); } }


        public IWebElement AccountNumberFromPopup { get { return WebDriver.GetElement(By.Id("customerdetails_number")); } }


        public IWebElement AccountNameFromPopup { get { return WebDriver.GetElement(By.Id("customerdetails_name")); } }


        public IWebElement CustomerNameDashboard { get { return WebDriver.GetElement(By.Id("customer-header-fullName-link")); } }


        public IWebElement CustomerNumberDashboard { get { return WebDriver.GetElement(By.XPath("//div//span[contains(@class, 'dds__h5')][1]")); } }


        public IWebElement CompanyNameDashboard { get { return WebDriver.GetElement(By.XPath("//*[@id='customer-header-company-link']")); } }


        public IWebElement CompanyNumberDashboard { get { return WebDriver.GetElement(By.Id("customer-context-label")); } }


        public IWebElement DBCCreditStatus { get { return WebDriver.GetElement(By.Id("dbcCreditStatus")); } }
        public IWebElement DBCLeaseStatus { get { return WebDriver.GetElement(By.Id("leaseCreditStatus")); } }


        public IWebElement DBCDetailsLink { get { return WebDriver.GetElement(By.Id("dfsfinancialInfo_link")); } }

        public IWebElement CustomerFinancialInfo { get { return WebDriver.GetElement(By.XPath("//*[@id='billToCustomerFinancialInfo_headingOne']/h5/div/button/span")); } }


        //End User Section

        public IWebElement TxtEndCustomerNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='endUserCustomer_title']/div[2]")); } }


        public IWebElement TxtEndUserCompanyName { get { return WebDriver.GetElement(By.XPath("//*[@id='endUserCustomer_title']/div[4]")); } }


        public IWebElement TxtEndUserAccountNo { get { return WebDriver.GetElement(By.XPath("//*[@id='endUserCustomer_title']/div[6]")); } }


        public IWebElement TxtEndUserAccountName { get { return WebDriver.GetElement(By.XPath("//*[@id='endUserCustomer_title']/div[8]")); } }

        //Review Checklist Section

        public IWebElement BtnFlyoutChecklist { get { return WebDriver.GetElement(By.Id("quoteDetailsReviewCheckListBtn")); } }


        public IWebElement BtnBackChecklist { get { return WebDriver.GetElement(By.XPath("//button//span[contains(text(), 'Back')]")); } }


        public IWebElement ChecklistTagSalesRep { get { return WebDriver.GetElement(By.XPath("//*[@id='review-checklist']/div[7]/div[3]/ul/li")); } }


        public IWebElement ChecklistInstallationInstructions { get { return WebDriver.GetElement(By.XPath("//*[@id='review-checklist']/div[13]//div/span")); } }


        public IWebElement ChecklistOriginalQuote { get { return WebDriver.GetElement(By.XPath("//*[@id='parentQuoteNumber']/div/text()")); } }

        public IList<IWebElement> TaggedSalesReps { get { return WebDriver.GetElements(By.Id("//*[contains(@class,'secondarysalesrep')]")); } }

        //Sales Rep Section

        public IWebElement BtnEditPrimarySalesRep { get { return WebDriver.GetElement(By.Id("salesrep_enable_primary")); } }


        public IWebElement TxtBoxPrimarySalesRep { get { return WebDriver.GetElement(By.Id("salesrep_primary_text")); } }


        public IWebElement TxtBoxTagSalesRep { get { return WebDriver.GetElement(By.Id("salesrep_secondary_text")); } }


        public IWebElement BtnAddSalesRep { get { return WebDriver.GetElement(By.Id("salesrep_add")); } }


        public IWebElement DrpDownTagSalesRep { get { return WebDriver.GetElement(By.XPath("//div[contains(text(), 'Tag Sales Rep')]")); } }


        public IWebElement BtnClearAllTagSalesRep { get { return WebDriver.GetElement(By.Id("salesrep_delete_all")); } }

        //ARB Section

        public IWebElement CloseDialogBox { get { return WebDriver.GetElement(By.XPath("//button[contains(text(), 'Close')]")); } }

        //ReadyStock Section

        public IWebElement LblQuoteType { get { return WebDriver.GetElement(By.XPath("//*[@id='[SOME_ID]']//div[1]/div[4]/div[2]")); } }


        public IWebElement LblRSID { get { return WebDriver.GetElement(By.XPath("//*[@id='GM_Product_0_0']/custom-panel/div/div[1]//div[2]")); } }

        public IWebElement QuoteType { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteType']/span[2]")); } }

        //More Actions Section

        public IWebElement BtnMoreActions { get { return WebDriver.GetElement(By.Id("moreActionsDropdown")); } }


        public IWebElement CopyAsRSIDQuote { get { return WebDriver.GetElement(By.Id("btnCopyAsRSIDQuote")); } }


        public IWebElement CopyAsNewQuote { get { return WebDriver.GetElement(By.Id("btnCopyAsQuote")); } }


        public IWebElement CopyAsStockQuote { get { return WebDriver.GetElement(By.Id("btnCopyAsStockQuote")); } }


        public IWebElement CopyAsPickQuote { get { return WebDriver.GetElement(By.Id("btnCopyAsPickQuote")); } }


        public IWebElement BtnSplitQuote { get { return WebDriver.GetElement(By.Id("btnSplitQuote")); } }


        public IWebElement BtnMergeQuote { get { return WebDriver.GetElement(By.Id("btnMergeQuote")); } }


        public IWebElement CopyAsNewVersion { get { return WebDriver.GetElement(By.Id("btnCopyAsVersion")); } }


        public IWebElement BtnUploadToPOM { get { return WebDriver.GetElement(By.Id("btnUploadToPom")); } }


        public IWebElement BtnSaveAsEquote { get { return WebDriver.GetElement(By.Id("btnSaveAsEQuote")); } }


        public IWebElement BtnExportStandardConfig { get { return WebDriver.GetElement(By.Id("btnExportStandardCfg")); } }


        public IWebElement BtnAssociateOpportunity { get { return WebDriver.GetElement(By.Id("btnAssociateOpportunity")); } }

        public IWebElement QuoteSummaryPageTotalAmount(int lineItemIndex = 0)
        {
            return WebDriver.GetElement(By.Id("Shipping_pricing_Summary_" + lineItemIndex + "_total"));
        }

        public IWebElement EOLConfirmation { get { return WebDriver.GetElement(By.XPath("//*[@id='mat-dialog-0']//span[contains(text(), 'Solution Contains one or more End of Life options, Go to OSC to fix solution.')]")); } }
                 
        public IWebElement QuoteSummaryPageSourceApplicationName { get { return WebDriver.GetElement(By.XPath("/html/body/app-root/div[1]/div[2]/div/div/ng-component/div/div/div[2]/div[1]/quote-header-base/quote-header-details/div/div/div[2]/div[5]/span[2]")); } }

        public QuoteDetailsPage MoreActions()
        {
            WaitForQuoteValidationToComplete();
            BtnMoreActions.Click(WebDriver);            
            return new QuoteDetailsPage(WebDriver);
        }
        
        public IWebElement MergeQuoteButtons(string QuoteNumber)
        {
            delay(5);
            return WebDriver.FindElement(By.CssSelector("[id*='mergeQuote_Grid_" + QuoteNumber + "']"));
        }

        public void delay(int timeOutInSeconds)
        {
            System.Threading.Thread.Sleep(timeOutInSeconds * 1000);
        }
        //Order Hold Options Section

        public IWebElement LblItemsInsureHdr { get { return WebDriver.GetElement(By.Id("quoteInsuredItem_title")); } }


        public IWebElement LblItemsInsureNotes { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteInsuredItem_notes']")); } }


        public IWebElement LblFusionID { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteInsuredItem_fusion_id']")); } }


        public IWebElement LblPOMID { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteInsuredItem_pom_id']")); } }


        public IWebElement BtnInsureItemCancel { get { return WebDriver.GetElement(By.Id("quoteInsuredItem_CancelBtn")); } }


        public IWebElement BtnSubmitInsureItem { get { return WebDriver.GetElement(By.Id("quoteInsuredItem_SubmitBtn")); } }

        public IWebElement ChkInsuredItem { get { return WebDriver.GetElement(By.XPath("//*[@id='checkboxInsuredItem'/label/span")); } }

        public IWebElement GetGroupLevelShippingMethod
        { get { return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_panel_0']/shipments-summary-base/shipments-summary/div[2]/div[1]/div/span[2]")); } }

        public IWebElement GetGroupLevelManualShippingDiscount
        { get { return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_panel_0']/shipments-summary-base/shipments-summary/div[3]/div[2]/div")); } }


        #region DFS Elements


        public IWebElement HeaderDfsProcessing { get { return WebDriver.GetElement(By.Id("scc_dfsMessage")); } }


        public IWebElement HeaderDbcCreditStatus { get { return WebDriver.GetElement(By.Id("scc_dbcCreditStatus")); } }


        public IWebElement HeaderLeaseCreditStatus { get { return WebDriver.GetElement(By.Id("scc_leaseCreditStatus")); } }


        public IWebElement HeaderDbcCreditAmount { get { return WebDriver.GetElement(By.Id("scc_dbcAvailableCredit")); } }


        public IWebElement HeaderDbcLeaseAmount { get { return WebDriver.GetElement(By.Id("scc_leaseOffer")); } }


        public IWebElement HeaderDfsDetailsLink { get { return WebDriver.GetElement(By.Id("scc_viewDfsDetailsLink")); } }


        public IWebElement DbcCreditStatus { get { return WebDriver.GetElement(By.XPath("//div[@id='lbl_dbc']//div[1]//div[2]")); } }


        public IWebElement LeaseCreditStatus { get { return WebDriver.GetElement(By.XPath("//div[@id='lbl_lease']//div[1]//div[2]")); } }


        public IWebElement DbcAccountStatus { get { return WebDriver.GetElement(By.XPath("//div[@id='lbl_dbc']/div[2]/div[2]")); } }


        public IWebElement LeaseAccountStatus { get { return WebDriver.GetElement(By.XPath("//div[@id='lbl_lease']//div[2]//div[2]")); } }


        public IWebElement DbcAmount { get { return WebDriver.GetElement(By.XPath("//div[@id='lbl_dbc']/div[3]/div[2]")); } }


        public IWebElement LeaseAmount { get { return WebDriver.GetElement(By.XPath("//div[@id='lbl_lease']//div[3]//div[2]")); } }


        public IWebElement DfsDetailsLink { get { return WebDriver.GetElement(By.XPath("//div[@id='lbl_billToCustomerFinancialInfo_dellfinancialinfo']//dfs-smb-information//div//div//a[@id='scc_viewDfsDetailsLink']")); } }



        public IWebElement LeaseGrid { get { return WebDriver.GetElement(By.XPath("//div[@class='dds__row smb-price-information-div']")); } }
        #endregion DFS Elements

        #endregion PCFQuoteSummaryElements

        #region CP OrderEnhancements Elements  


        public IWebElement BtnReturnToCurrentQuote { get { return WebDriver.GetElement(By.Id("createQuoteVersionReturn")); } }


        public IWebElement BtnCloseModal1 { get { return WebDriver.GetElement(By.XPath("//*[@id='mat-dialog-0']//span")); } }


        public IWebElement BtnCreateQuoteToEdit { get { return WebDriver.GetElement(By.Id("createQuoteVersionEdit")); } }


        public IWebElement BtnSaveNewQuote { get { return WebDriver.GetElement(By.Id("lblContinue")); } }


        public IWebElement BtnLnkMakeAdditionalChange { get { return WebDriver.GetElement(By.Id("saveQuoteConfirmation_additionalchanges_button")); } }


        public IWebElement BtnSaveNewQuoteModalPopUp { get { return WebDriver.GetElement(By.Id("saveQuoteConfirmation_save_new_quote_button")); } }


        public IWebElement BtnVisitPreviousVersion { get { return WebDriver.GetElement(By.XPath("//*[@id='draftQuoteVisitPreviousBtn']")); } }


        public IWebElement LblQuoteVersionSummaryPage { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteVersion']")); } }


        public IWebElement LblQuoteVersionDraftPage { get { return WebDriver.GetElement(By.Id("draftQuoteVersion")); } }


        public IWebElement LblQuoteNumberSummaryPage { get { return WebDriver.GetElement(By.Id("quoteNumber")); } }

        public IWebElement LblQuoteNumberDraftPage { get { return WebDriver.GetElement(By.Id("draftQuoteNumber")); } }

        public IWebElement LblDraftQuoteVersion { get { return WebDriver.GetElement(By.Id("draftQuoteVersion")); } }

        public IWebElement BtnNext { get { return WebDriver.GetElement(By.XPath("//div//button[contains(text(), 'Next')]")); } }

        public IWebElement BtnMakeChanges { get { return WebDriver.GetElement(By.XPath("//*[@id='change_button']")); } }

        public IWebElement LnkSolutionNo { get { return WebDriver.GetElement(By.XPath("//*[@id='solutionId']/a")); } }

        public IWebElement TextModalPopUp { get { return WebDriver.GetElement(By.Id("createQuoteVersionBody")); } }

        public IWebElement BtnCreateNewShipToORInstallAt { get { return WebDriver.GetElement(By.XPath("//button[contains(@class, 'dds__btn-link dds__text-truncate link')]")); } }

        public IWebElement CountryCode { get { return WebDriver.GetElement(By.XPath("//*[@id='Row-ColumnName-1-PhoneNumber']/div[1]/select")); } }

        public IWebElement RadioBtnResellerAddr { get { return WebDriver.GetElement(By.Id("radioBtnReseller")); } }

        public IWebElement RadioBtnEndUserAddr { get { return WebDriver.GetElement(By.Id("radioBtnEndUser")); } }


        #endregion CP OrderEnhancements Elements  

        #region PCF

        public void NavigateToQuote(IWebDriver webDriver, TestContext context, string quoteNumber, string quoteVersion, string country, string language)
        {
            var url = "https://www.dell.com/salesapp/"
                     + "quote/"
                     + country + "/"
                     + language + "/"
                     + quoteNumber + "/"
                     + quoteVersion;

            webDriver.Navigate().GoToUrl(url);

        }

        public bool ValidationMessageExists(IWebDriver webDriver)
        {
            if (LblQuoteValidationMessage.IsElementDisplayed(webDriver, TimeSpan.FromSeconds(2)))
                return LblQuoteValidationMessage.GetText(webDriver)
                .Contains(
                    "There was an error validating your quote or the quote is already ordered (DPID generated).");
            return false;
        }


        public bool IsQuoteValidationElementDisplayed(By loc)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromMilliseconds(50));
                wait.Until(ExpectedConditions.ElementIsVisible(loc));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public PCFQuoteSummaryPage WaitForQuoteValidationToComplete()
        {

            for (var i = 0; i <= 2; i++)
            {
                By oldbyLoc = By.XPath("//span[contains(@class,'validationMessage')]");

                if (IsQuoteValidationElementDisplayed(oldbyLoc))
                {
                    new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime).Until(ExpectedConditions.InvisibilityOfElementLocated(oldbyLoc));

                }

            }
            return new PCFQuoteSummaryPage(WebDriver);

        }
        public List<string> GetAllARBSystemSearch()
        {
            IList<IWebElement> list = WebDriver.GetElements(By.CssSelector("div.arb__modal-body > div.dds__row.itemContent > div"));
            List<string> systemDetailsAllValues = new List<string>();
            var total = list.Count;
            if (total >= 3)
            {
                foreach (IWebElement values in WebDriver.GetElements(
                    By.CssSelector("div.arb__modal-body > div.dds__row.itemContent > div")))
                {
                    systemDetailsAllValues.Add(values.GetText(WebDriver));


                }
                CloseDialogBox.Click(WebDriver);

            }
            else
            {

                Assert.Fail("Count did not match");
            }
            return systemDetailsAllValues;
        }

        public List<string> GetAllARBbaseConfigValues(int grpIndex, int itemIndex)
        {

            IList<IWebElement> list = WebDriver.GetElements(By.CssSelector("#option_" + grpIndex + "_" + itemIndex + "_0_config_accordion > div > div > table > tbody > tr > td"));
            List<string> baseConfigDetails = new List<string>();
            var total = list.Count;
            if (total >= 3)
            {
                foreach (IWebElement values in WebDriver.GetElements(
                    By.CssSelector("#option_" + grpIndex + "_" + itemIndex + "_0_config_accordion > div > div > table > tbody > tr > td")))
                {
                    baseConfigDetails.Add(values.GetText(WebDriver));


                }

            }
            else
            {

                Assert.Fail("Count did not match");
            }
            return baseConfigDetails;
        }


        public IWebElement ShippingGroupInfoSection(int? shippingGroupIndex, int? shippingItemIndex)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='item_" + shippingGroupIndex + "_" + shippingItemIndex + "_accordion_show_more_button']//span[1]"));

        }

        public IWebElement ExpandItemDetails(int groupIndex = 0, int itemIndex = 0)
        {
            return WebDriver.GetElement(By.Id("item_" + (groupIndex) + "_" + (itemIndex) + "_accordion_show_more_button"));
        }

        public IWebElement ShippingGroupInfoSection(int shippingGroupIndex , int itemIndex)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='item_" + shippingGroupIndex + "_" + itemIndex + "_accordion_show_more_button']/span[1]"));


        }

        public IWebElement UCIDNumber(int? index = 0)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='ShipGroup" + index + "_shipTo_UCID']"));
        }


        //Item Level
        public IWebElement BtnExpandAllOrCollapseAll(int index)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='item_" + index + "']"));
        }

        public IWebElement GetShippingLvlCadence(int shippingGrpIndex, int itemIndex)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='shipping_group_Item_panel_" + shippingGrpIndex + "_" + itemIndex + "']//item-pricing//app-apos-item-pricing-expanded//div//div//div[6]//div[2]"));
        }

        public IWebElement BtnSystemDetails(int lineIndex, int groupIndex)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='GM_Product_" + lineIndex + "_" + groupIndex + "']//a/span"));
        }

        #region ShippingGroupSummaryElements
        public IWebElement LblShippingGroupSummarySubTotal(int groupIndex)
        {
            return WebDriver.GetElement(By.Id("Shipping_pricing_Summary_" + groupIndex + "_subTotal"));
        }

        public IWebElement LblShippingGroupSummaryShippingAmount(int groupIndex)
        {
            return WebDriver.GetElement(By.Id("Shipping_pricing_Summary_" + groupIndex + "_totalShipping"));
        }

        public IWebElement LblShippingGroupSummaryTax(int groupIndex)
        {
            return WebDriver.GetElement(By.Id("Shipping_pricing_Summary_" + groupIndex + "_totalTax"));
        }

        public IWebElement LblShippingGroupSummaryEcoFee(int groupIndex)
        {
            return WebDriver.GetElement(By.Id("Shipping_pricing_Summary_" + groupIndex + "_totalEcoFee"));
        }

        public IWebElement LblShippingGroupSummaryTotalAmount(int groupIndex)
        {
            return WebDriver.GetElement(By.Id("Shipping_pricing_Summary_" + groupIndex + "_total"));
        }

        public IWebElement ShippingGroupTab(int groupIndex)
        {
            return WebDriver.GetElement(By.Id("shipping_group_tab_" + groupIndex + ""));
        }

        public IWebElement ChangeShipGroupTabQuotePage(int groupIndex)
        {
            return WebDriver.GetElement(By.Id("shipping_group_tab_" + groupIndex + ""));
        }

        public IWebElement ChangeShipGroupTabDraftPage(int groupIndex)
        {
            return WebDriver.GetElement(By.Id("shippingGroupTab_" + groupIndex + ""));
        }

        #endregion ShippingGroupSummaryElements


        public List<String> GetVersionsFromGrid()
        {
            List<string> versionsList = WebDriver.FindElements(By.XPath("//div//div[contains(@class, 'dds__button-dropdown-container dds__collapse dds__show')]")).Select(x => x.GetText(WebDriver)).ToList();
            return versionsList;
        }
        public IWebElement SelectDifferentVersion(string index = "1")
        {
            return WebDriver.GetElement(By.Id("quoteVersion" + index + ""));

        }

        public void SelectQuoteVersion(string quoteVersion)
        {
            try
            {
                SelectDifferentVersion(quoteVersion).Click(WebDriver);
            }
            catch (Exception e)
            {
                Logger.Write("Quote Version not available. Please check the requested quote version again.");
                Console.WriteLine(e);
                throw;
            }

        }

        public ShippingGroupSummary GetShippingGroupSummary(int index = 1)
        {
            WaitForQuoteValidationToComplete();
            Logger.Write("Getting Values for Shipping Group Summary for group " + index);
            Logger.Write("-------------------------");

            var shipGroupSummary = new ShippingGroupSummary()
            {
                SubTotal = Convert.ToDouble(LblShippingGroupSummarySubTotal(index-1).GetText(WebDriver).Substring(1)),
                TotalShipping = Convert.ToDouble(LblShippingGroupSummaryShippingAmount(index - 1).GetText(WebDriver).Substring(1)),
                TotalTax = Convert.ToDouble(LblShippingGroupSummaryTax(index - 1).GetText(WebDriver).Substring(1)),
                TotalEcoFee = Convert.ToDouble(LblShippingGroupSummaryEcoFee(index - 1).GetText(WebDriver).Substring(1)),
                TotalAmount = Convert.ToDouble(LblShippingGroupSummaryTotalAmount(index - 1).GetText(WebDriver).Substring(5))
            };

            return shipGroupSummary;
        }

        public QuoteSummaryValues GetQuoteSummaryValue(bool isSmartPriceEnabled = false)
        {
            var values = new QuoteSummaryValues();
            Logger.Write("Getting Values Of Summary of Quote ");
            Logger.Write("-------------------------");

            values.ListPrice = LblPricingSummaryListPrice.GetText(WebDriver);
            values.SellingPrice = LblPricingSummarySellingPrice.GetText(WebDriver);
            var oldDiscountString = LblPricingSummaryDiscount.GetText(WebDriver);
            var replaceDiscountString = System.Text.RegularExpressions.Regex.Replace(oldDiscountString, @"\(", "");
            var newDiscountString = System.Text.RegularExpressions.Regex.Replace(replaceDiscountString, @"\)", "");
            values.Discount = newDiscountString.Insert(5, " /");

            var oldMarginString = LblSummaryMargin.GetText(WebDriver);
            var replaceMarginString = System.Text.RegularExpressions.Regex.Replace(oldMarginString, @"\(", "");
            var newMarginString = System.Text.RegularExpressions.Regex.Replace(replaceMarginString, @"\)", "");
            values.TotalMargin = newMarginString.Insert(7, " /");

            values.ShippingPrice = LblPricingSummaryShippingPrice.GetText(WebDriver);
            values.ShippingDiscount = LblPricingSummaryShippingDiscount.GetText(WebDriver);
            values.Subtotal = Convert.ToDouble(LblPricingSummarySubTotal.GetText(WebDriver).Substring(1));
            values.TotalShipping = Convert.ToDouble(LblPricingSummaryTotalShipping.GetText(WebDriver).Substring(1));
            values.TotalTax = Convert.ToDouble(LblPricingSummaryTotalTax.GetText(WebDriver).Substring(1));
            values.TotalEcoFee = Convert.ToDouble(LblPricingSummaryTotalEcoFee.GetText(WebDriver).Substring(1));
            values.FinalPrice = Convert.ToDouble(LblPricingSummaryFinalPrice.GetText(WebDriver).Substring(1));

            return values;
        }

        public ItemSummaryValues GetItemLevelSummary(int groupIndex = 1, int itemIndex = 1)
        {
            WaitForQuoteValidationToComplete();
            Logger.Write("Getting Values for Item Level Summary for Item " + itemIndex + " in Shipping Group " + groupIndex);
            Logger.Write("-------------------------");

            var itemSummary = new ItemSummaryValues
            {
                TotalSellingPrice = Convert.ToDouble(LblItemSummarySellingPrice(groupIndex, itemIndex).GetText(WebDriver).Substring(1)),
                TotalTax = Convert.ToDouble(LblItemSummaryTax(groupIndex, itemIndex).GetText(WebDriver).Substring(1)),
                TotalEcoFee = Convert.ToDouble(LblItemSummaryEcoFee(groupIndex, itemIndex).GetText(WebDriver).Substring(1)),
                TotalAmount = Convert.ToDouble(LblItemSummaryTotalAmount(groupIndex, itemIndex).GetText(WebDriver).Substring(5))
            };

            return itemSummary;
        }

        #region ItemSummaryElements
        public IWebElement LblItemSummarySellingPrice(int groupIndex = 1, int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id("itemPricingSummary_" + (groupIndex - 1) +"_"+ (lineItemIndex - 1) +"_sellingPrice"));
        }

        public IWebElement LblItemSummaryTax(int groupIndex = 1, int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id("itemPricingSummary_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "_taxAmount"));
        }

        public IWebElement LblItemSummaryEcoFee(int groupIndex = 1, int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id("itemPricingSummary_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "_eco"));
        }

        public IWebElement LblItemSummaryTotalAmount(int groupIndex = 1, int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id("itemPricingSummary_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "_totalAmount"));
        }

        #endregion

        public void ClickLinkedQuote(int index)
        {
            var linkedQuoteDropdown = WebDriver.GetElement(By.XPath("//*[@id='linkedQuotesDropDownButton']/li[" + index + "]/button"));
            linkedQuoteDropdown.Click(WebDriver);
        }

        public string GetLblItemShippingGroupNumber(int index)
        {
            return WebDriver.GetElement(By.XPath(string.Format("//*[@id='shipping_group_panel_" + index + "']/item-base/item-details/div/h3"))).GetText(WebDriver);

        }

        public IWebElement ClickToShowShipGroupsArrow(string move)
        {
            return WebDriver.FindElement(By.XPath("//button[contains(@class, 'dds__overflow-control dds__overflow-control-" + move + " dds__overflow-control-btn dds__overflow-unresponsive')]"));

        }
        public void ClickDashboardByCustomerView()
        {
            DashboardIcon.Click(WebDriver);
            LnkViewForCustomer.Click(WebDriver);
        }

        public void ClickDashboardByAccountView()
        {
            DashboardIcon.Click(WebDriver);
            LnkViewForAccount.Click(WebDriver);
        }

        public PCFQuoteSummaryPage ClickLnkClose()
        {
            WebDriver.FindElement(By.XPath("//*[@id='dsaDialogCloseX']/span")).Click(WebDriver);
            return new PCFQuoteSummaryPage(WebDriver);
        }

        public PCFQuoteSummaryPage ExpandOrCollapseItemDetails()
        {
            WebDriver.FindElement(By.XPath("//*[@id='item_0']")).Click(WebDriver);
            return new PCFQuoteSummaryPage(WebDriver);
        }

        public PCFQuoteSummaryPage ExpandOrCollapseConfigDetails(int itemIndex = 1)
        {
            WebDriver.FindElement(By.XPath("//*[@id='option_0_" + (itemIndex - 1) + "']")).Click(WebDriver);
            return new PCFQuoteSummaryPage(WebDriver);
        }

        public bool IsSkuTextBoxHighlightedInRed(int skuIndex = 1)
        {
            var editableSku = SellingPriceOfSku(skuIndex);
            if (editableSku.GetAttribute("class").Contains("dds__btn btn-price-changed"))
            {
                return true;
            }
            return false;
        }

        public IWebElement SellingPriceOfSku(int skuIndex)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='option_0_1_" + (skuIndex - 1) + "_config_accordion']/div/div/table/tbody/tr[1]/td[8]/div/span"));
        }

        public IWebElement GetServiceTagDataFromTable(int index = 1)
        {
            return WebDriver.FindElement(By.XPath("//div[contains(@id, 'option_0_0_undefined_config_accordion')]//tr//td[" + index + "]"));
        }
        public IWebElement GetServiceTagORSystemID(int lineIndex, int groupIndex, int itemIndex)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + lineIndex + "_" + groupIndex + "']//item-details-expanded//div[" + itemIndex + "]/div[2]"));
        }

        public void CheckBoxOrderHoldOptions(string checkboxType)
        {
            WebDriver.GetElement(By.XPath("//*[@id='checkbox" + checkboxType + "']/label/input")).Click(WebDriver);

        }

        public string GetConfigDetailsSkuNo(int groupIndex, int lineItemIndex, int skuIndex)
        {
            return WebDriver.GetElement(By.XPath(string.Format("//*[@id='configuration-option-details_0_0']//div[contains(@class, 'dds__row itemRow')][" + groupIndex + "]//tbody[" + lineItemIndex + "]//td[" + skuIndex + "]"))).GetText(WebDriver);
        }

        public string GetSnpConfigDetailsSku(int groupIndex, int skuIndex)
        {
            return WebDriver.GetElement(By.XPath(string.Format("//*[@id='option_0_0_0_snp_accordion']//div//tbody[" + groupIndex + "]//td[" + skuIndex + "]"))).GetText(WebDriver);
        }

        public IWebElement GetItemLevelPricingInfo(int index)
        {
            return WebDriver.GetElement(By.XPath("(//div[@class='dds__col-md-6 dds__text-right'])[" + index + "]"));
        }

        public string GetTenantORDomainID(string Attribute)
        {
            return WebDriver.GetElement(By.Id(string.Format("AutoPilot_0_0_" + Attribute + "_input"))).GetText(WebDriver);
        }
        public void EditPrimarySalesRep()
        {
            WebDriver.FindElement(By.Id("salesrep_enable_primary")).Click(WebDriver);
            TxtBoxPrimarySalesRep.Clear();
        }

        public void EditTagSalesRep()
        {
            DrpDownTagSalesRep.Click(WebDriver);
            WebDriver.FindElement(By.Id("salesrep_secondary_text")).Clear();
        }
        public void ClickReturnToDell()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)WebDriver;
            //This will Scroll Down To The Bottom Of Page
            executor.ExecuteScript("arguments[0].scrollIntoView(true);", LnkInstallInstruction);
            //Verify Btn Return To Top, which Scrolls page to Top
            BtnReturnToTop.Click(WebDriver);
        }
        public string GetSolutionName(int groupIndex)
        {
            var splitTxt = WebDriver.FindElement(By.Id("solutionName" + groupIndex + "")).GetText(WebDriver);
            string solName = splitTxt.Split(':')[1].Trim();
            return solName;
        }

        public IWebElement ErrorValidationMsg(int lineIndex)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='errorMessage" + lineIndex + "']/span"));
        }
        public IWebElement WarningMsg(int lineIndex)
        {
            return WebDriver.GetElement(By.Id("warningMessage" + lineIndex + ""));
        }
        public IWebElement InfoMsg(int lineIndex)
        {
            return WebDriver.GetElement(By.Id("infoMessage" + lineIndex + ""));
        }

        public IWebElement ErrorValidationMsgSpan(int lineIndex)
        {
            var a = "//*[@id='errorMessage'" + lineIndex + "]/span";
            return WebDriver.GetElement(By.XPath("//*[@id='errorMessage" + lineIndex + "']/span"));
        }

        public IWebElement ProductName(int groupIndex, int lineIndex)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='GM_Product_" + groupIndex + "_" + lineIndex + "']/custom-panel/div/div[1]"));
        }

        public IWebElement LblOrderCodeName(int groupIndex, int lineIndex)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + groupIndex + "_" + lineIndex + "']//item-details-expanded//div[4]/div[2]"));
        }
        public IWebElement GetInfoNotification(string text)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='infoNotification']//li//div[contains(normalize-space(),'" + text + "')]"));
        }

        public IWebElement LineItemRSIQNumber(int groupIndex = 1, int itemIndex = 1)
        {
            return WebDriver.GetElement(By.Id("GM_Product_" + (groupIndex - 1) + "_" + (itemIndex - 1)));
        }

        #region ReviewChecklist

        public IWebElement ChecklistQuoteORCompanyInfo(string Name)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='" + Name + "']/text()"));

        }
        public IWebElement ChecklistCustomerORPricingORShippingInfo(int groupIndex, int lineIndex)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='review-checklist']/div[" + groupIndex + "]/div[" + lineIndex + "]/text()"));

        }
        public IWebElement ChecklistShippingORSalesRepContactInfo(int groupIndex, int itemIndex, int lineIndex)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='review-checklist']/div[" + groupIndex + "]/div[" + itemIndex + "]/text()[" + lineIndex + "]"));
        }
        public IWebElement ChecklistBillingORShippingInfo(int groupIndex, int itemIndex, int lineIndex)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='review-checklist']/div[" + groupIndex + "]/div[" + itemIndex + "]/div[" + lineIndex + "]"));
        }
        public IWebElement ChecklistTotalCost(int groupIndex)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='ShipGroup" + groupIndex + "_total']"));
        }

        public OrderChecklist GetReviewChecklistValues()
        {
            var values = new OrderChecklist();
            Logger.Write("Getting All the Values From Review Checklist Flyout");

            string Quote_Number = "quoteNumber";
            string Quote_Expiration = "expirationDate";
            string PO_Number = "poNumber";
            string Company_Name = "companyName";
            string Company_Number = "companyNumber";
            string Customer_Number = "customerNumber";

            values.QuoteNumber = ChecklistQuoteORCompanyInfo(Quote_Number).GetText(WebDriver);
            values.QuoteExpiration = ChecklistQuoteORCompanyInfo(Quote_Expiration).GetText(WebDriver);
            values.CompanyNumber = ChecklistQuoteORCompanyInfo(Company_Number).GetText(WebDriver);
            values.PoNumber = ChecklistQuoteORCompanyInfo(PO_Number).GetText(WebDriver);
            values.CustomerNumber = ChecklistQuoteORCompanyInfo(Customer_Number).GetText(WebDriver);
            values.CompanyName = ChecklistQuoteORCompanyInfo(Company_Name).GetText(WebDriver);

            values.POMNumber = ChecklistCustomerORPricingORShippingInfo(3, 4).GetText(WebDriver);
            values.EndCustomerNumber = ChecklistCustomerORPricingORShippingInfo(5, 4).GetText(WebDriver);
            values.PaymentMethod = ChecklistCustomerORPricingORShippingInfo(6, 2).GetText(WebDriver);
            values.PaymentTerms = ChecklistCustomerORPricingORShippingInfo(6, 3).GetText(WebDriver);
            values.PrimarySalesRep = ChecklistCustomerORPricingORShippingInfo(7, 2).GetText(WebDriver);
            values.Margin = ChecklistCustomerORPricingORShippingInfo(7, 4).GetText(WebDriver);
            values.ShippingInstruction = ChecklistCustomerORPricingORShippingInfo(9, 3).GetText(WebDriver);
            values.ShippingMethod = ChecklistCustomerORPricingORShippingInfo(9, 4).GetText(WebDriver);
            values.MustArriveDate = ChecklistCustomerORPricingORShippingInfo(10, 2).GetText(WebDriver);


            values.ShippingContactName = ChecklistShippingORSalesRepContactInfo(9, 1, 1).GetText(WebDriver);
            values.ShippingContactEmail = ChecklistShippingORSalesRepContactInfo(9, 1, 2).GetText(WebDriver);
            values.ShippingContactPhone = ChecklistShippingORSalesRepContactInfo(9, 1, 3).GetText(WebDriver);
            values.SalesRepEmail = ChecklistShippingORSalesRepContactInfo(7, 1, 1).GetText(WebDriver);
            values.SalesRepPhone = ChecklistShippingORSalesRepContactInfo(7, 1, 2).GetText(WebDriver);

            values.BillingCompanyName = ChecklistBillingORShippingInfo(6, 1, 1).GetText(WebDriver);
            values.BillingAddress = ChecklistBillingORShippingInfo(6, 1, 1).GetText(WebDriver);
            values.ShippingAddress = ChecklistBillingORShippingInfo(9, 2, 1).GetText(WebDriver);

            values.TagSalesRep = ChecklistTagSalesRep.GetText(WebDriver);
            values.OriginalQuoteNumber = ChecklistOriginalQuote.GetText(WebDriver);
            values.InstallationInstructions = ChecklistInstallationInstructions.GetText(WebDriver);

            values.TotalCost = ChecklistTotalCost(0).GetText(WebDriver);

            return values;
        }

        #endregion ReviewChecklist


        #endregion PCF

        #region CP OrderEnhancements 
        public PCFQuoteSummaryPage WaitForDraftQuoteValidationToComplete()
        {

            for (var i = 0; i <= 2; i++)
            {
                By waitValidationSpinner = By.XPath("//*[@id='validationLoading']/div/div");
                if (IsQuoteValidationElementDisplayed(waitValidationSpinner))
                {
                    new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime).Until(ExpectedConditions.InvisibilityOfElementLocated(waitValidationSpinner));

                }

            }
            return new PCFQuoteSummaryPage(WebDriver);

        }

        public void ChangeLnkSummaryPage(string changeBtn, int groupIndex)
        {
            WebDriver.FindElement(By.Id("change_" + changeBtn + "_" + groupIndex + "")).Click(WebDriver);
        }
        public IWebElement MakeChangeBtn(int groupIndex)
        {
            return WebDriver.FindElement(By.Id("shipping_group_tab_" + groupIndex + ""));
        }

        public IWebElement ChangeLnkShipToORInstallAtDraftPage(int groupIndex, string changeBtn)
        {
            return WebDriver.FindElement(By.Id("ShipGroup" + groupIndex + "_" + changeBtn + "_changeLink"));
        }

        public IWebElement BtnShippingMthodORInstructionsDraftPage(int groupIndex, string changeBtn)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='ShipGroup" + groupIndex + "_" + changeBtn + "']"));
        }

        public IWebElement ShipToContactName(int groupIndex)
        {
            return WebDriver.FindElement(By.Id("ShipGroup" + groupIndex + "_shipTo_contactname"));
        }
        public IWebElement ShipToAddress(int groupIndex)
        {
            return WebDriver.FindElement(By.Id("ShipGroup" + groupIndex + "_shipTo_address"));
        }
        public IWebElement ShipToPhoneNo(int groupIndex)
        {
            return WebDriver.FindElement(By.Id("ShipGroup" + groupIndex + "_shipTo_phone"));
        }
        public IWebElement ShipToEmailAddr(int groupIndex)
        {
            return WebDriver.FindElement(By.Id("ShipGroup" + groupIndex + "_shipTo_email"));
        }

        public IWebElement ShipToChangeBtnDraftPge(int groupIndex)
        {
            return WebDriver.FindElement(By.Id("ShipGroup" + groupIndex + "_shipTo_changeLink"));
        }
        public IWebElement InstallAtChangeBtnDraftPge(int groupIndex)
        {
            return WebDriver.FindElement(By.Id("ShipGroup" + groupIndex + "_installAt_changeLink"));
        }
        public IWebElement InstallAtContactName(int groupIndex)
        {
            return WebDriver.FindElement(By.Id("ShipGroup" + groupIndex + "_installAt_contactname"));
        }
        public IWebElement InstallAtAddr(int groupIndex)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='ShipGroup" + groupIndex + "_installAt_UCID']"));
        }
        public IWebElement InstallAtPhoneNo(int groupIndex)
        {
            return WebDriver.FindElement(By.Id("ShipGroup" + groupIndex + "_installAt_phone"));
        }
        public IWebElement InstallAtEmailAddr(int groupIndex)
        {
            return WebDriver.FindElement(By.Id("ShipGroup" + groupIndex + "_installAt_email"));
        }
        public IWebElement DeliveryMtdChangeBtnDraftPge(int groupIndex)
        {
            return WebDriver.FindElement(By.Id("ShipGroup" + groupIndex + "_deliveryMethod"));
        }
        public IWebElement DeliveryMtdChangeBtnQuotePge(int groupIndex)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='shipping_group_panel_" + groupIndex + "']//input"));
        }
        public IWebElement ShippingInstructionDraftPge(int groupIndex)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='ShipGroup" + groupIndex + "_shippingInstructionsinput']"));
        }
        public IWebElement ShippingInstructionQuotePge(int groupIndex)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='Shipping_Instructions_" + groupIndex + "']//following::div[contains(@class, 'dds__form-control disabled-div')]"));
        }
        public IWebElement SelectShipGroupTabDraftPage(int groupIndex)
        {
            return WebDriver.FindElement(By.Id("draftQuoteshippingGroupTab_" + groupIndex + ""));
        }

        public IWebElement ShipToApplyAllGroups(int groupIndex)
        {
            return WebDriver.FindElement(By.Id("shipToApplyAllBtn_" + groupIndex + ""));
        }

        public IWebElement InstallAtApplyAllGroups(int groupIndex)
        {
            return WebDriver.FindElement(By.Id("installAtApplyAllBtn_" + groupIndex + ""));
        }

        public IWebElement DeliveryMethodApplyAllGroups(int groupIndex)
        {
            return WebDriver.FindElement(By.Id("ShipGroup" + groupIndex + "_shippingMethodApplyAll"));
        }

        public IWebElement ShippingInstructionsApplyAllGroups(int groupIndex)
        {
            return WebDriver.FindElement(By.Id("ShipGroup" + groupIndex + "_shippingInstructionsApplyAll"));
        }

        public Address GetShipToAddrInfo(int shipGroup)
        {
            Logger.Write("Getting all Info from Shipping Address");

            var ShippingToAddress = new Address
            {
                FirstName = ShipToContactName(shipGroup).GetText(WebDriver),
                AddressLine1 = ShipToAddress(shipGroup).GetText(WebDriver),
                PrimaryPhone = ShipToPhoneNo(shipGroup).GetText(WebDriver),
                Email = ShipToEmailAddr(shipGroup).GetText(WebDriver),
            };

            return ShippingToAddress;
        }

        public Address GetInstallAtAddrInfo(int shipGroup)
        {
            Logger.Write("Getting all Info from Install At Address");

            var InstallAtAddress = new Address
            {
                FirstName = InstallAtContactName(shipGroup).GetText(WebDriver),
                AddressLine1 = InstallAtAddr(shipGroup).GetText(WebDriver),
                PrimaryPhone = InstallAtPhoneNo(shipGroup).GetText(WebDriver),
                Email = InstallAtEmailAddr(shipGroup).GetText(WebDriver),
            };

            return InstallAtAddress;
        }

        public void ChooseFromExistingAddress(int AddrIndex)
        {

            IJavaScriptExecutor executor = (IJavaScriptExecutor)WebDriver;
            //This will Scroll Down To The Bottom Of Page To choose last address from the grid
            executor.ExecuteScript("arguments[0].scrollIntoView(true);", BtnNext);
            WebDriver.FindElement(By.Id("SelectButton-" + AddrIndex + "")).Click(WebDriver);

        }

        public void UpdateDeliveryMethod(string shipMethod, int groupIndex)
        {
            DeliveryMtdChangeBtnDraftPge(groupIndex).PickDropdownByText(WebDriver, shipMethod);
        }

        public IWebElement LblChangeNewAddress(string Addresses)
        {
            return WebDriver.FindElement(By.XPath(" //*[@id='" + Addresses + "']//input"));
        }

        public void CreateNewShipToOrInstallAtAddresses(IWebDriver WebDriver, DataRow row)
        {
            string addNew_Address = "addressLine1";
            string addNew_Zipcode = "postalCode";
            string addNew_FirstName = "firstName";
            string addNew_LastName = "lastName";
            string addNew_WorkPhone = "workPhone";
            string addNew_MobilePhone = "mobilePhone";
            string addNew_Email = "invoicingEmail";

            //Enter New Address Details
            LblChangeNewAddress(addNew_Address).SetText(WebDriver, row["Address"].ToString());
            LblChangeNewAddress(addNew_Zipcode).SetText(WebDriver, row["Zipcode"].ToString());
            LblChangeNewAddress(addNew_FirstName).SetText(WebDriver, row["FirstName"].ToString());
            LblChangeNewAddress(addNew_LastName).SetText(WebDriver, row["LastName"].ToString());
            LblChangeNewAddress(addNew_MobilePhone).SetText(WebDriver, row["PhoneNo"].ToString());
            LblChangeNewAddress(addNew_WorkPhone).SetText(WebDriver, row["PhoneNo"].ToString());
            LblChangeNewAddress(addNew_Email).SetText(WebDriver, row["Email"].ToString());

            //Adding Original Address
            WebDriver.FindElement(By.Id("addAddress")).Click(WebDriver);
            WebDriver.FindElement(By.XPath("//*[@id='btnUseOriginalAddress']")).Click(WebDriver);

        }

        public IWebElement LblChangeResellerOrEndUserAddr(int column, string Addresses)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='Row-ColumnName-" + column + "-" + Addresses + "']/div[1]//input"));
        }

        public void ChangeResellerOrEndUserAddress(IWebDriver WebDriver, DataRow row, int column)
        {
            string addNew_Contact = "Contact";
            string addNew_Phone = "PhoneNumber";
            string addNew_Email = "Email";
            var addNew_CountryCode = "1";

            //Enter Reseller/EndUsers Address Details
            LblChangeResellerOrEndUserAddr(column, addNew_Contact).SetText(WebDriver, row["FirstName"].ToString());
            LblChangeResellerOrEndUserAddr(column, addNew_Phone).SetText(WebDriver, row["PhoneNo"].ToString());
            CountryCode.PickDropdownByValue(WebDriver, addNew_CountryCode);
            LblChangeResellerOrEndUserAddr(column, addNew_Email).SetText(WebDriver, row["Email"].ToString());

            //Click Btn "Save And Confirm" 
            WebDriver.FindElement(By.Id("SelectButton-1")).Click(WebDriver);

        }

        #endregion CP OrderEnhancements  

        #region FT2

        public IWebElement GoalLiteDealIdStatusLabel1 { get { return WebDriver.GetElement(By.XPath("//*[@id='goalLiteApprovalStatus_label']")); } }

        public IWebElement GoalLiteNewRequestLink { get { return WebDriver.GetElement(By.XPath("//*[@id='QuoteDetails_goalLiteApprovalStatus']")); } }
        public IWebElement GoalLiteReasonCode { get { return WebDriver.GetElement(By.Id("QuoteDetails_approveDiscount_reason")); } }
        public IWebElement GoalLiteBusCase { get { return WebDriver.GetElement(By.Id("QuoteDetails_approveDiscount_Notes")); } }
        public IWebElement GoalLiteSubmitReq { get { return WebDriver.GetElement(By.XPath("//*[@id='QuoteDetails_approveDiscount_submit']")); } }
        public IWebElement ChkTaxHold { get { return WebDriver.GetElement(By.XPath("//*[@id='checkboxTaxHold']/label/input")); } }
        public IWebElement GoalLiteDealIdStatus1 { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Submitted')] | //label[contains(text(),'Approved')] | //label[contains(text(),'Expired')] | //label[contains(text(),'Denied')] | //label[contains(text(),'Withdrawn')]")); } }
        public IWebElement GoalLiteDamMsgAtQuoteLevel { get { return WebDriver.GetElement(By.XPath("//*[@id='errorMessage0']/span")); } }

        public IWebElement MsgItemLevelDamValidation(int lineItemIndex = 1)
        {

            WebDriver.VerifyBusyOverlayNotDisplayed();
            //var lstwebelements = WebDriver.GetElements(By.XPath("//span[contains(@id,'" + PagePrefix + "_dealValidationErrorMessage_LI')]"), TimeSpan.FromSeconds(20));
            //This is temp fix Ft2 dev is working on element id addition for new DAM message
            var lstwebelements = WebDriver.GetElements(By.XPath("//*[contains(@id,'itemValidationResults')]//span[contains(text(),'pricing approval is required')]"),
             TimeSpan.FromSeconds(10));
            if (lstwebelements != null && lstwebelements.Count > 0)
            {
                return lstwebelements[lineItemIndex - 1];
            }
            return null;

        }

        public IWebElement ExpandLineItem(int lineItemIndex = 1)

        {
            //return WebDriver.GetElements(By.XPath("//span[contains(@id,'_LI_lineNumber__')]"))[lineItemIndex];
            //return WebDriver.GetElement(By.Id(PagePrefix + "_LI_" + "lineNumber__" + (lineItemIndex - 1)));
            // return WebDriver.GetElement(By.XPath("(//span[contains(@id,'_LI_lineNumber__')])[" + lineItemIndex + "]"));

            //Added for PCF Flow
            return WebDriver.GetElement(By.XPath("//*[@id='item_" + (lineItemIndex - 1) + "']"));


        }
        public IWebElement ExpandAllorCollapsLink { get { return WebDriver.GetElement(By.XPath("//div//button[@id='item_0']")); } }
        public IWebElement gotoMenu { get { return WebDriver.GetElement(By.XPath("//*[@id='masthead_menu_title']")); } }
        public IWebElement GoalLiteDealIdLabel { get { return WebDriver.GetElement(By.XPath("//*[@id='goalLiteDealId_label']")); } }
        public IWebElement GoalLiteDamMsgForAmtAtQuoteLevel { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_quote_Validation']//span[contains(text(),'Quote Selling Price has exceeded')]")); } }
        public IWebElement LnkSearchQuote { get { return WebDriver.GetElement(By.XPath("//*[@id='buttonDropdownPrimary']/ul/li[3]/app-menu-item[1]/li/ul/li[3]/a")); } }
        //Old Xpath
        public IWebElement duplicateCheckCheckBoxYes { get { return WebDriver.GetElement(By.Id("chkContinueWithDuplOrder")); } }
        public IWebElement duplicateCheckContinue { get { return WebDriver.GetElement(By.XPath("//button[contains(text(),'Continue')]")); } }

        public IWebElement QuickSearchtxtbox { get { return WebDriver.GetElement(By.XPath("//*[@class='intuitive-search-input ng-untouched ng-pristine ng-valid']")); } }

        public IWebElement QuickSearchbtn { get { return WebDriver.GetElement(By.XPath("//*[@class='intuitive-search-btn']")); } }

        //Goallite 
        public IWebElement LnkItemLevelGoalDealIdPickFromList(int shippingGroupIndex = 1, int lineItemIndex = 1)
        {
            return //WebDriver.GetElement(By.Id(PagePrefix + "_LI_selectGoalDealId_" + (shippingGroupIndex - 1) + "_" + (lineItemIndex - 1)));
                   //  WebDriver.GetElement(By.Id("goalSel_" + (shippingGroupIndex - 1) + "_" + (lineItemIndex - 1)));
          WebDriver.GetElement(By.Id("pick_GoalDeal"));

        }

        public IWebElement LblItemLevelNonTiedUnitSellingPrice(int groupIndex = 1, int itemIndex = 1, int nonTiedItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[1]/div[4]/div[2]//span/span"));
        }

        public IWebElement LblItemLevelNonTiedSellingPrice(int groupIndex = 1, int itemIndex = 1, int nonTiedItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[2]/div[4]/div[2]"));
        }

        public IWebElement LblItemLevelNonTiedDiscountOffList(int groupIndex = 1, int itemIndex = 1, int nonTiedItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedItemIndex - 1) + "\']/div[2]/div[1]/item-discounts/div/div/div[4]/div[2]//span/span"));
        }
        
        public IWebElement LblItemLevelNonTiedUnitListPrice(int groupIndex = 1, int itemIndex = 1, int nonTiedItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[1]/div[2]/div[2]"));
        }

        public IWebElement LblItemLevelNonTiedListPrice(int groupIndex = 1, int itemIndex = 1, int nonTiedItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[2]/div[2]/div[2]"));
        }


        public IWebElement LblItemLevelNonTiedUnitDiscount(int groupIndex = 1, int itemIndex = 1, int nonTiedItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[1]/div[3]/div[2]"));
        }

        public IWebElement LblItemLevelNonTiedDiscount(int groupIndex = 1, int itemIndex = 1, int nonTiedItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[2]/div[3]/div[2]"));
        }

        public IWebElement LblItemLevelNonTiedQuantity(int groupIndex = 1, int itemIndex = 1, int nonTiedItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nonTiedItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[2]/div[1]/div[2]/b"));
        }

        public IWebElement DivSmartpricepopupOnDolNonTied(int itemIndex = 1)
        {
            return
                 WebDriver.GetElement(
                     By.XPath(@"//button[@class='smp-val-close']/.."));
        }

        public IWebElement DivSmartpricepopupOnSellingPriceNonTied(int itemIndex = 1)
        {
            return
                WebDriver.GetElement(
                    By.XPath(@"//button[@class='smp-val-close']/.."));
        }


        public IWebElement DivSmartpricepopupOnDol(int itemIndex = 1)
        {
            return
                WebDriver.GetElement(
                    By.XPath(@"//button[@class='smp-val-close']/.."));
        }


        public IWebElement DivSmartpriceGenericMessage(IWebElement smartpriceDiv)
        {
            return smartpriceDiv.GetChildElement(By.XPath(".//div[@class='mg-top-15']"));
        }

        public IWebElement DivSmartpricepopupOnSellingPrice(int itemIndex = 1)
        {
            return
                WebDriver.GetElement(
                    By.XPath(@"//button[@class='smp-val-close']/.."));
        }

        public IWebElement DivSmartpriceConditionalMessage(IWebElement smartpriceDiv)
        {
            return smartpriceDiv.GetChildElement(By.XPath(".//div[@class='conditionalMsg']"));
        }


        public IWebElement LblItemLevelNonTiedSmartpriceRevenue(int nonTiedItemIndex = 1)
        {
            return WebDriver.GetElements(By.XPath("//*[contains(@id, '_Sku_PI_unitCompRevenue_')]"))[nonTiedItemIndex - 1];
        }


        public IWebElement LblItemLevelSmartpriceRevenue(int groupIndex = 1, int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_qdSmartPriceRevenue_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
        }


        public IWebElement MsgItemLevelInvalidGoalDealId(int lineItemIndex = 1)
        {
            //var lstwebelements = WebDriver.GetElements(By.XPath("//span[contains(@id,'" + PagePrefix + "_dealValidationErrorMessage_LI')]"), TimeSpan.FromSeconds(10));
            //This is temp fix Ft2 dev is working on element id addition for new DAM message
            var lstwebelements = WebDriver.GetElements(By.XPath("//*[contains(text(),'GOAL Deal is not valid')]"), TimeSpan.FromSeconds(10));
            if (lstwebelements != null && lstwebelements.Count > 0)
            {
                return lstwebelements[lineItemIndex - 1];
            }
            return null;
        }

        public QuoteSearchPage MenuQuoteSearch()
        {
            gotoMenu.Click(WebDriver);
            LnkSearchQuote.Click(WebDriver);
            return new QuoteSearchPage(WebDriver);

        }

        public CreateQuotePage CopyQuote_(bool newVersion = false)
        {
            // Click more actions and perform Copy quote
            if (newVersion)
                SelectMoreActions(SelectAction.CopyAsNewVersion);
            else
                SelectMoreActions(SelectAction.CopyAsNewQuote);

            WebDriver.VerifyBusyOverlayNotDisplayed();
            WaitForQuoteValidationToComplete();
            return new CreateQuotePage(WebDriver);

        }

        public IWebElement MsgItemLevelDamValidationQty(int lineItemIndex = 1)
        {

            WebDriver.VerifyBusyOverlayNotDisplayed();
            //var lstwebelements = WebDriver.GetElements(By.XPath("//span[contains(@id,'" + PagePrefix + "_dealValidationErrorMessage_LI')]"), TimeSpan.FromSeconds(20));
            //This is temp fix Ft2 dev is working on element id addition for new DAM message
            var lstwebelements = WebDriver.GetElements(By.XPath("//*[contains(text(),'exceeded GOAL Deal discount limits')]"),
                TimeSpan.FromSeconds(10));
            if (lstwebelements != null && lstwebelements.Count > 0)
            {
                return lstwebelements[lineItemIndex - 1];
            }
            return null;

        }

        public IWebElement lblPFLSFDCvalue { get { return WebDriver.GetElement(By.XPath("//p[normalize-space()='SFDC Deal ID']/../span")); } }

        public IWebElement lblPFLEndUserAccountvalue { get { return WebDriver.GetElement(By.XPath("//p[normalize-space()='End User Account']/../span")); } }

        public IWebElement LnkNonTiedItemLevelGoalDealIdPickFromList(int groupIndex = 1, int lineItemIndex = 1, int nonTiedItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id("goalSel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "_" + (nonTiedItemIndex - 1)));
        }
        //public PCFComplianceNotificationsPage CreateOrder()
        //{
        //    ContinuetoCreateOrder.Click(WebDriver);
        //    // BtnCreateOrder.Click(WebDriver);

        //    return new PCFComplianceNotificationsPage(WebDriver);
        //}

        public IWebElement LblSummaryLevelDfsRevenuePrice { get { return WebDriver.GetElement(By.XPath("////*[@id='quoteDetail_GI_revenue_Incentive_")); } }

        public string[] CurrentQuoteVersion()
        {
            var getQuoteVersion = new PCFQuoteSummaryPage(WebDriver).GetQuoteVersion();
            var quoteVersion = getQuoteVersion.Split(' ');
            //string versionNumber = quoteVersion[1];
            return quoteVersion;
        }

        public PCFQuoteSummaryPage RemoveGoalDealIdFromLineItem(int groupIndex = 1, int itemIndex = 1)
        {
            WebDriver.GetElement(
                By.XPath("//*[@id='" + PagePrefix + "_LI_info_goalDealId_" + (groupIndex - 1) + "_" + (itemIndex - 1) +
                         "']//a")).Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return new PCFQuoteSummaryPage(WebDriver);
        }

        public PCFQuoteSummaryPage ShowItemDetails(int shippingGroupIndex = 1, int itemIndex = 1, int nontiedItemIndex = 1)
        {

            WebDriver.GetElement(By.XPath("//*[@id='item_" + (shippingGroupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nontiedItemIndex - 1) + "_accordion_show_more_button']/span[1]")).Click(WebDriver);

            return new PCFQuoteSummaryPage(WebDriver);
        }

        public PCFQuoteSummaryPage RemoveGoalDealIdFromNontiedItem(int groupIndex = 1, int itemIndex = 1, int nonTiedItemIndex = 1)
        {
            WebDriver.GetElement(
                By.XPath("//*[@id='" + PagePrefix + "_LI_NTSKU_NonTied_info_goalDealId_" + (groupIndex - 1) + "_" + (itemIndex - 1) + "_" +
                         (nonTiedItemIndex - 1) + "']//a")).Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();

            return new PCFQuoteSummaryPage(WebDriver);
        }


        public IWebElement LblQuoteStatusTxt()
        {
            return WebDriver.GetElement(By.Id("headerQuoteStatusValue"));
        }

        //public PCFQuoteSummaryPage ClickLargeValueHLDChkBox()
        //{
        //    WebDriver.VerifyBusyOverlayNotDisplayed();
        //    ChkLargeValueHold.SelectCheckBox(WebDriver);


        //    return new PCFQuoteSummaryPage(WebDriver);
        //}

        public IWebElement LnkViewMore(int shippingGroup = 1, int itemIndex = 1)
        {
            return WebDriver.FindElement(By.Id("toggleMoreLess_" + (shippingGroup - 1) + "_" + (itemIndex - 1)));
        }

        public IWebElement LblProductTypeAccordionUnderViewMore(int shippingGroup = 1, int itemIndex = 1)
        {
            //return WebDriver.FindElement(By.XPath(@"//*[@id='quoteDetail_accordionMore_" + (shippingGroup - 1) + "_" + (itemIndex - 1) + "']/div[1]/div[2]/div/div"));
            //return WebDriver.FindElement(By.XPath("//line-item-inventory-information[@ng-reflect-shipment-index='" + (shippingGroup - 1) + "' and @ng-reflect-item-index='" + (itemIndex - 1) + "']/div/div/div[3]/label"));
            return WebDriver.FindElement(By.XPath("//*[contains(@id, '_" + (shippingGroup - 1) + "_" + (itemIndex - 1) + "_label')]"));
        }

        public IWebElement LblOrderCodeUnderViewMore(int shippingGroup = 1, int itemIndex = 1)
        {
            return WebDriver.FindElement(By.Id(PagePrefix + "_LI_orderCode_" + (shippingGroup - 1) + "_" + (itemIndex - 1)));
        }

        public IWebElement ByItemSummarySPRevenueLabel(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_smartPriceRevenue_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"));
        }

        public IWebElement ByItemSummarySPRevenueValue(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_smartPriceRevenue_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']"));
        }

        public IWebElement ByItemSummaryServiceIncentiveValue(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_commModifier_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']"));
        }

        public IWebElement ByItemSummaryServiceIncentiveLabel(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_commModifier_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"));
        }

        public IWebElement ByItemSummaryPricingModifierValue(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_pricingModifier_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']"));
        }

        public IWebElement ByItemSummaryPricingModifierLabel(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_pricingModifier_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"));
        }

        public IWebElement ByItemSummaryUpSellModRevenueLabel(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_servicesIncentive_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"));
        }

        public IWebElement ByItemSummaryModRevenueValue(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_rawCompRevenue_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']"));
        }

        public IWebElement ByItemSummaryModRevenueLabel(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_rawCompRevenue_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"));
        }
        public IWebElement LblSummaryLevelSmartPriceRevenue { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_GI_smartPrice_Revenue_']")); } }

        public IWebElement TxtQuoteNumber { get { return WebDriver.GetElement(By.XPath("//input[@id = 'quoteSearch_quoteNumber'][1]")); } }

        public IWebElement BtnMergeQuoteList { get { return WebDriver.GetElement(By.Id("quoteDetail_mergeQuotes")); } }

        public IWebElement DivMergeQuotePopup { get { return WebDriver.GetElement(By.XPath("//*[@class='dsa-modal-wrap']")); } }

        public IWebElement BtnCreateMergeQuote { get { return WebDriver.GetElement(By.XPath("//*[@id='mergeQuote_continue']")); } }

        public IWebElement LblSkuUnderViewMore(int shippingGroup = 1, int itemIndex = 1)
        {
            return WebDriver.FindElement(By.Id(PagePrefix + "_LI_skuNumber_" + (shippingGroup - 1) + "_" + (itemIndex - 1)));
        }

        public IWebElement BtnLspContinue { get { return WebDriver.GetElement(By.Id("_setDefaultContract_ok")); } }

        public IWebElement BtnQuoteSearch { get { return WebDriver.GetElement(By.Id("quoteSearch_searchButton")); } }

        public IWebElement BtnLspViewOriginalQuote { get { return WebDriver.GetElement(By.Id("_setDefaultContract_cancel")); } }

        public Boolean ValidateOrderAndSku(Dictionary<string, ProductSearchType> products, int shippingIndex = 1)
        {
            int itemIndex = 1;
            bool allitemsFound = true;
            for (int i = 0; i < products.Count; i++)
            {
                LnkViewMore(shippingIndex, itemIndex).Click(WebDriver);
                if (LblProductTypeAccordionUnderViewMore(shippingIndex, itemIndex).GetText(WebDriver).ToLower()
                    .Contains("order code"))
                {
                    string orderorskuvalue = LblOrderCodeUnderViewMore(shippingIndex, itemIndex).GetText(WebDriver)
                        .Trim();

                    if (!products.ContainsKey(orderorskuvalue.ToLower().Trim()))
                    {
                        allitemsFound = false;
                        break;
                    }
                }
                else
                {
                    string orderorskuvalue = LblSkuUnderViewMore(shippingIndex, itemIndex).GetText(WebDriver).Trim();

                    if (!products.ContainsKey(orderorskuvalue.ToLower().Trim()))
                    {
                        allitemsFound = false;
                        break;
                    }
                }
                LnkViewMore(shippingIndex, itemIndex).Click(WebDriver);
                itemIndex += 1;
            }
            return allitemsFound;
        }

        public void HandleLspPopUp(bool viewOriginalQuote = true)
        {
            if (viewOriginalQuote)
                BtnLspViewOriginalQuote.Click(WebDriver);
            else
                BtnLspContinue.Click(WebDriver);

        }

        public CreateQuotePage CloseSmartpricePopup()
        {
            WebDriver.GetElements(By.XPath("//button[@class='smp-val-close']"))
                .SingleOrDefault(a => a.Displayed)
                .Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        }

        public bool ValidateAutoRenewalWindowOpened()
        {
            bool opened = false;
            foreach (var handle in WebDriver.WindowHandles)
            {
                opened = WebDriver.SwitchTo().Window(handle).Title.Contains("Americas Client Pricing ");
            }

            return opened;
        }

        public PCFQuoteSummaryPage QuoteSearchByQuoteNumber(string quoteNumber, bool viewOriginalQuote = true)
        {

            TxtQuoteNumber.SetText(WebDriver, quoteNumber);
            BtnQuoteSearch.Click(WebDriver);
            new PCFQuoteSummaryPage(WebDriver).WaitForQuoteValidationToComplete();
            if (BtnLspViewOriginalQuote.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
                HandleLspPopUp(viewOriginalQuote);
            return new PCFQuoteSummaryPage(WebDriver);
        }

        public PCFQuoteSummaryPage PickGoalDealIdFromListForLineItem(int shippingroup = 1, int itemIndex = 1, string goalDealId = "", int level = 1, string sfdcdeal = "", string enduserAcc = "")
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            LnkItemLevelGoalDealIdPickFromList(shippingroup, itemIndex).Click(WebDriver);
            if (sfdcdeal != "")
            {
                lblPFLSFDCvalue.GetText(WebDriver).Should().BeEquivalentTo(sfdcdeal);
            }
            if (enduserAcc != "")
            {
                lblPFLEndUserAccountvalue.GetText(WebDriver).Should().BeEquivalentTo(enduserAcc);
            }
            if (level != 1)
            {
                WebDriver.GetElement(By.XPath("//*[@class='modal-body']//div[@class='accordion-group'][" + level + "]//a[1]")).Click(WebDriver);
            }

            // WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_goaldeal_familyorclass_grid']//tbody//tr//td[contains(text(), '" + goalDealId + "')]/..//input")).Click(WebDriver);
            WebDriver.GetElement(By.XPath("//*[@class='btn-bar']//button[normalize-space()='Select']")).Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WaitForQuoteValidationToComplete();
            return new PCFQuoteSummaryPage(WebDriver);
        }

        public PCFQuoteSummaryPage PickGoalDealIdFromListForNonTiedItem(int shippingroup = 1, int itemIndex = 1, int nontiedItemindex = 1, string goalDealId = "", int level = 1, string sfdcdeal = "", string enduserAcc = "")
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            LnkNonTiedItemLevelGoalDealIdPickFromList(shippingroup, itemIndex, nontiedItemindex).Click(WebDriver);
            if (sfdcdeal != "")
            {
                lblPFLSFDCvalue.GetText(WebDriver).Should().BeEquivalentTo(sfdcdeal);
            }
            if (enduserAcc != "")
            {
                lblPFLEndUserAccountvalue.GetText(WebDriver).Should().BeEquivalentTo(enduserAcc);
            }
            if (level != 1)
            {
                WebDriver.GetElement(
                        By.XPath("//*[@class='modal-body']//div[@class='accordion-group'][" + level + "]//a[1]"))
                    .Click(WebDriver);
            }

            WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_goaldeal_familyorclass_grid']//tbody//tr//td[contains(text(), '" + goalDealId + "')]/..//input")).Click(WebDriver);
            WebDriver.GetElement(By.XPath("//*[@class='btn-bar']//button[normalize-space()='Select']")).Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WaitForQuoteValidationToComplete();
            return new PCFQuoteSummaryPage(WebDriver);
        }

        public PCFQuoteSummaryPage SubmitGoalLiteRequest(string reasonCode, string busNotes)
        {

            GoalLiteNewRequestLink.Click(WebDriver);
            GoalLiteReasonCode.PickDropdownByText(WebDriver, reasonCode);
            GoalLiteBusCase.SetText(WebDriver, busNotes);
            GoalLiteSubmitReq.Click(WebDriver);
            return new PCFQuoteSummaryPage(WebDriver);
        }


        public string GetGoalDealIdFromItem(int shippingGroupIndex = 1, int itemIndex = 1)
        {
            return
            //    WebDriver.GetElement(By.Id(PagePrefix + "_LI_info_goalDealId_" + (shippingGroupIndex - 1) + "_" + (itemIndex - 1)))
            //        .GetText(WebDriver);

            WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (shippingGroupIndex - 1) + "_" + (itemIndex - 1) + "']//span[contains(text(),'G00')]"))
                    .GetText(WebDriver);
        }

        public string GetGoalDealIdFromNonTiedItem(int shippingGroupIndex = 1, int itemIndex = 1, int nontiedItemIndex = 1)
        {
            return
            //   WebDriver.GetElement(By.Id(PagePrefix + "_LI_NTSKU_NonTied_info_goalDealId_" + (shippingGroupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nontiedItemIndex - 1))).GetText(WebDriver);
            WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (shippingGroupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nontiedItemIndex - 1) + "']//span[contains(text(),'G00')]")).GetText(WebDriver);
            //*[@id="shipping_group_Item_panel_0_1_0"]//span[contains(text(),'G00')]
        }


        public PCFQuoteSummaryPage SelectQuoteByVersionNo(int version)
        {
            var currentQuoteVersion = new PCFQuoteSummaryPage(WebDriver).CurrentQuoteVersion()[1];
            if (!currentQuoteVersion.Equals(1))
            {
                LblQuoteVersion.Click(WebDriver);
                WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Version " + version + "']")));
                WebDriver.GetElement(By.XPath("//span[text()='Version " + version + "']")).PCFClick(WebDriver);
            }

            return new PCFQuoteSummaryPage(WebDriver);
        }


        //public IWebElement MsgItemLevelDamValidation(int lineItemIndex = 1)
        //{

        //    WebDriver.VerifyBusyOverlayNotDisplayed();
        //    //var lstwebelements = WebDriver.GetElements(By.XPath("//span[contains(@id,'" + PagePrefix + "_dealValidationErrorMessage_LI')]"), TimeSpan.FromSeconds(20));
        //    //This is temp fix Ft2 dev is working on element id addition for new DAM message
        //    var lstwebelements = WebDriver.GetElements(By.XPath("//*[contains(@id,'itemValidationResults')]//span[contains(text(),'pricing approval is required')]"),
        //     TimeSpan.FromSeconds(10));
        //    if (lstwebelements != null && lstwebelements.Count > 0)
        //    {
        //        return lstwebelements[lineItemIndex - 1];
        //    }
        //    return null;

        //}

        //public QuoteDetailsPage SubmitGoalLiteRequest(string reasonCode, string busNotes)
        //{

        //    GoalLiteNewRequestLink.Click(WebDriver);
        //    GoalLiteReasonCode.PickDropdownByText(WebDriver, reasonCode);
        //    GoalLiteBusCase.SetText(WebDriver, busNotes);
        //    GoalLiteSubmitReq.Click(WebDriver);
        //    return new QuoteDetailsPage(WebDriver);
        //}

        //public IWebElement LblQuoteStatusTxt()
        //{
        //    return WebDriver.GetElement(By.Id("headerQuoteStatusValue"));
        //}

        #endregion

        #region POM


        public IWebElement UploadPOLink_QuoteSummaryPage { get { return WebDriver.GetElement(By.XPath("//*[@id='uploadPo-Container']//a")); } }
        public IWebElement PONumberOptionalLabel_QuoteSummary { get { return WebDriver.GetElement(By.Id("headerPoNumberTitle")); } }
        public IWebElement PONumberOptionalValue_QuoteSummary { get { return WebDriver.GetElement(By.Id("headerPoNumberInput")); } }
        public IWebElement POMIDOptionalLabel_QuoteSummary { get { return WebDriver.GetElement(By.Id("headerPomIdTitle")); } }
        public IWebElement POMIDOptionalValue_QuoteSummary { get { return WebDriver.GetElement(By.Id("headerPomIdInput")); } }
        public IWebElement pomidFieldLevel_Notification_QuoteSummary { get { return WebDriver.GetElement(By.Id("pomInfoNotification")); } }
        public IWebElement pomidPageLevel_Notification_QuoteSummary { get { return WebDriver.GetElement(By.XPath(".//div[@id='pomErrorNotification']//li")); } }
        public IWebElement uploadaddendum_QuoteSummary { get { return WebDriver.GetElement(By.XPath("//div[@id='uploadAddendum-Container']//a")); } }
       // public IWebElement BtnMoreActions { get { return WebDriver.GetElement(By.XPath("//button[@id='moreActionsDropdown']")); } }
        public IWebElement UploadToPOM { get { return WebDriver.GetElement(By.XPath("//div[@id='uploadToPom-Container']//a")); } }
        public IWebElement QuoteDetailPagePONumberInput { get { return WebDriver.GetElement(By.XPath("//input[@id='headerPoNumberInput']")); } }
        public IWebElement QuoteDetailPagePomIdInput { get { return WebDriver.GetElement(By.Id("headerPomIdInput")); } }

        public void OpenNewTab(string baseUrl)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            js.ExecuteScript("window.open();");
            WebDriver.SwitchTo().Window(WebDriver.WindowHandles.Last());
            WebDriver.Url = baseUrl;
        }

        #endregion POM

        #region Install At Elements

        public IWebElement InstallAtAddressUCIDRequiredNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Install At address UCID required, per shipping group to place order')]")); } }

        public IWebElement SolutionNameRequiredNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Solution name required, per shipping group to place order')]")); } }

        public IWebElement UCIDRequestNotifShipTo { get { return WebDriver.GetElement(By.Id("ShipGroup0_shipTo_UCIDStatus")); } }

        public IWebElement UCIDRequestNotifInstallAt { get { return WebDriver.GetElement(By.Id("ShipGroup0_installAt_UCIDStatus")); } }

        public IWebElement UCIDShipTo { get { return WebDriver.GetElement(By.Id("ShipGroup0_shipTo_UCID")); } }

        public IWebElement UCIDRequiredNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Install At address UCID required, per shipping group to place order')]")); } }

        public IWebElement InstallAtAddressRequiredNotification { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Install At address UCID required')]")); } }

        public IWebElement InstallAtShippingInfo_QuoteDetailspage { get { return WebDriver.GetElement(By.Id("ShipGroup0_installAt_title")); } }

        public IWebElement InstallAtAddressInfo_QuoteDetailspage { get { return WebDriver.GetElement(By.Id("GM_ShipGroup0_installAt")); } }

        public IWebElement GetSolutionNameTxt(int? shippingIndex)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='solutionName" + shippingIndex + "']"));
        }

        #endregion

        #region Warranty

        public IWebElement QuoteLvlWarrantyNotification { get { return WebDriver.GetElement(By.XPath("//div[contains(text(), 'This quote contains one or more systems with a tied subscription')]")); } }

        public IWebElement ItemLvlWarrantyNotification()
        {
            return WebDriver.GetElement(By.XPath("//div[contains(text(), 'This system contains a tied subscription')]"));
        }

        #endregion

        #region Sizer

        public IWebElement SizerPopUpCloseBtn { get { return WebDriver.GetElement(By.XPath("//button[@class='close-btn width-10']")); } }

        public IWebElement SizerDetailsPopUp { get { return WebDriver.GetElement(By.XPath("//*[@class='popover-content popover-body']")); } }

        public IWebElement SizerDetailsLnk(int? index)
        {
            return WebDriver.GetElement(By.XPath("(//*[contains(text(), 'Sizer Details')])[" + index + "]"));
        }

        #endregion

        #region QAR
        public IWebElement ExportQAR { get { return WebDriver.GetElement(By.Id("btnExportQar")); } }

        #endregion

        public void CopySaveQuote(IWebDriver webDriver, string createdOrderNumber)
        {
            HomeWorkFlow.GoToQuoteSearchPage(webDriver)
              .PCFQuoteSearchByQuoteNumber(createdOrderNumber)
              .WaitForQuoteValidationToComplete();

            PCFQuoteSummaryPage quoteSummaryPage = new PCFQuoteSummaryPage(webDriver);
            CreateQuotePage createQuotePage = quoteSummaryPage.CopyQuote(false);
            createQuotePage.SaveQuote();

            WebDriverUtil.VerifyBusyOverlayNotDisplayed(webDriver);

        }
        public void CopySaveQuote1(IWebDriver webDriver, string createdOrderNumber)
        {
            HomeWorkFlow.GoToQuoteSummarySearchPage(webDriver)
              .QuoteSearchByQuoteNumber(createdOrderNumber)
              .WaitForQuoteValidationToComplete();

            PCFQuoteSummaryPage quoteDetailsPage = new PCFQuoteSummaryPage(webDriver);
            CreateQuotePage createQuotePage = quoteDetailsPage.CopyQuote(false);
            createQuotePage.SaveQuote();

            WebDriverUtil.VerifyBusyOverlayNotDisplayed(webDriver);

        }
        public PCFQuoteSummaryPage SaveQuote()
        {
            CreateQuotePage createQuotePage = new CreateQuotePage(WebDriver);
            createQuotePage.VerifyExportComplianceEndUse();
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("quoteCreate_saveQuote")));
            BtnSaveQuote.PCFClick(WebDriver);
            if (!WebDriver.Url.Contains($"salesapp/quote/"))
                WebDriver.RefreshCurrentPage();
            if (WebDriver.ElementExists(By.Id("proceed-button")))
                WebDriver.GetElement(By.Id("proceed-button")).PCFClick(WebDriver);
            WaitForQuoteValidationToComplete();
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            return new PCFQuoteSummaryPage(WebDriver);
        }

        #region knights
        public PCFComplianceNotificationsPage ContiuetoCheckout()
        {
            BtnContinueToCheckout.PCFClick(WebDriver);
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            return SalesRepMismatchPopup();

        }

        public PCFComplianceNotificationsPage SalesRepMismatchPopup()
        {

            By BySalesRepMismatchPopup = By.XPath("//*[@id='quoteSalesRepMismatch_loggedin_sales_rep_submit_button']");

            try
            {
                if (WebDriver.ElementExists(BySalesRepMismatchPopup))
                {
                    Logger.Write("Sales rep mismatch pop up is displayed");
                    BySalesRepMismatchPopup.PCFClick(WebDriver);
                }
                else
                {
                    Logger.Write("Sales rep mismatch pop up is not displayed");
                }
            }
            catch (Exception e)
            {
                Logger.Write(e.Message);
            }
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            return new PCFComplianceNotificationsPage(WebDriver);
        }

        public PCFSendQuotePage SendQuote(bool isQtoPqto = false)
        {
            BtnSendQuote.PCFClick(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            new QuoteDetailsPage(WebDriver).WaitForQuoteValidationToComplete();
            //if (isQtoPqto)
            //WebDriver.WaitForElementDisplay(BtnQtoPqtoNotificationOk, TimeSpan.FromSeconds(8));
            //BtnQtoPqtoNotificationOk.Click(WebDriver);

            return new PCFSendQuotePage(WebDriver);
        }


        #endregion

        public void SelectMoreActions(SelectAction selectAction)
        {
            BtnMoreActions.Click(WebDriver);
            switch (selectAction)
            {
                case SelectAction.CopyAsNewQuote:
                    CopyAsNewQuote.Click(WebDriver);
                    break;
                case SelectAction.CopyAsNewVersion:
                    CopyAsNewVersion.Click(WebDriver);
                    break;
                case SelectAction.SplitQuote:
                    BtnSplitQuote.Click(WebDriver);
                    break;
                case SelectAction.MergeQuote:
                    BtnMergeQuote.Click(WebDriver);
                    break;
                case SelectAction.CopyRSIQ:
                    CopyAsRSIDQuote.Click(WebDriver);
                    break;
                case SelectAction.CopyStockQuote:
                    CopyAsStockQuote.Click(WebDriver);
                    break;
                case SelectAction.CopyPickQuote:
                    CopyAsPickQuote.Click(WebDriver);
                    break;
                default:
                    Logger.Write("Improper Selection");
                    break;
            }
        }
        public CreateQuotePage CopyQuote(bool newVersion = false)
        {
            if (WebDriver.TryFindElement(CopyAsNewQuote, TimeSpan.FromSeconds(5)))
            {
                // read-only quote details page copy quote button
                CopyAsNewQuote.Click(WebDriver);
            }
            else
            {
                // Click more actions and perform Copy quote
                if (newVersion)
                    SelectMoreActions(SelectAction.CopyAsNewVersion);
                else
                    SelectMoreActions(SelectAction.CopyAsNewQuote);
            }
            WebDriver.VerifyBusyOverlayNotDisplayed();
            WaitForQuoteValidationToComplete();
            return new CreateQuotePage(WebDriver);

        }


        public ItemQuoteData GetLineItemUnitValues(int groupIndex = 1, int itemIndex = 1, bool contractCodeRequired = false)
        {
            WaitForQuoteValidationToComplete();
            Logger.Write("Getting Values for Item " + itemIndex + " in Shipping Group " + groupIndex);
            Logger.Write("-------------------------");

            var itemQuoteData = new ItemQuoteData
            {
                ListPrice = LblItemLevelUnitListPrice(groupIndex, itemIndex).GetText(WebDriver).Substring(1),
                DiscountOffList = Convert.ToDouble(LblItemLevelDiscountOffList(groupIndex, itemIndex).GetText(WebDriver).Split('%')[0]),
                Discount = Convert.ToDouble(LblItemLevelUnitDiscount(groupIndex, itemIndex).GetText(WebDriver).Substring(1)),
                SellingPrice = (groupIndex == 2 && itemIndex == 1) ? LblItemLevelUnitSellingPrice(groupIndex, itemIndex).GetText(WebDriver).Substring(1) : LblItemLevelUnitSellingPrice(groupIndex, itemIndex).GetText(WebDriver).Substring(1),
                MarginValue = Convert.ToDouble(LblItemLevelUnitMargin(groupIndex, itemIndex).GetText(WebDriver).Substring(1)),
                Quantity = int.Parse(LblItemLevelQuantity(groupIndex, itemIndex).GetText(WebDriver)),
                ContractCode = contractCodeRequired ? LblContractCode(itemIndex).GetText(WebDriver) : ""
            };
            return itemQuoteData;
        }


        public ItemQuoteData GetLineItemUnitValuesWithQuantity(int groupIndex = 1, int itemIndex = 1, bool contractCodeRequired = false)
        {
            WaitForQuoteValidationToComplete();
            Logger.Write("Getting Values for Item " + itemIndex + " in Shipping Group " + groupIndex + "With Quantity");
            Logger.Write("-------------------------");

            var discount = LblItemLevelTotalDiscount(groupIndex, itemIndex).GetText(WebDriver);
            var margin = LblItemLevelMargin(groupIndex, itemIndex).GetText(WebDriver);
            var promotion = LblItemLevelPromotions(groupIndex, itemIndex).GetText(WebDriver);

            var itemQuoteDataWithQuantity = new ItemQuoteData
            {
                ListPrice = LblItemLevelTotalListPrice(groupIndex, itemIndex).GetText(WebDriver).Substring(1),
                Discount = Convert.ToDouble(discount.Split('/')[1].Substring(2)),
                DiscountOffList = Convert.ToDouble(discount.Split('/')[0].Substring(0).Split('%')[0]),
                SellingPrice = LblItemLevelTotalSellingPrice(groupIndex, itemIndex).GetText(WebDriver).Substring(1),
                Margin = margin,
                MarginValue = Convert.ToDouble(margin.Split('/')[1].Substring(2)),
                MarginPert = Convert.ToDouble(margin.Split('/')[0].Substring(0).Split('%')[0]),
                PromoValue = Convert.ToDouble(promotion.Split('/')[1].Substring(2)),
                PromoPert = Convert.ToDouble(promotion.Split('/')[0].Substring(0).Split('%')[0]),
                ContractCode = contractCodeRequired ? LblContractCode(itemIndex).GetText(WebDriver) : ""
            };

            return itemQuoteDataWithQuantity;
        }

        public string GetQuoteNumber()
        {
            //WaitForQuoteValidationToComplete();
            return LblQuoteNumber.GetText(WebDriver).Trim();
        }

        public string GetQuoteVersion()
        {
            //WaitForQuoteValidationToComplete();
            return LblQuoteVersion.GetText(WebDriver).Trim();
        }

        public string GetSolutionID()
        {

            return lnkSolutionId.GetText(WebDriver);
        }

        public QuoteSummaryValues GetQuoteSummaryValues(bool isSmartPriceEnabled = false)
        {
            var values = new QuoteSummaryValues();
            Logger.Write("Getting Values Of Summary of Quote ");
            Logger.Write("-------------------------");

            //values.Add("ListPrice", ByLblSummaryListPrice.GetText(WebDriver));
            //values.Add("SellingPrice", LblSummarySellingPrice.GetText(WebDriver));
            //values.Add("Discount", LblSummaryDiscount.GetText(WebDriver));
            values.ListPrice = LblPricingSummaryListPrice.GetText(WebDriver);
            values.SellingPrice = LblPricingSummarySellingPrice.GetText(WebDriver);

            values.Discount = LblPricingSummaryDiscount.GetText(WebDriver).Substring(1);
            string discountPert = LblPricingSummaryDiscountPercentage.GetText(WebDriver);
            values.DiscountPercentage = LblPricingSummaryDiscountPercentage.GetText(WebDriver).Substring(1, discountPert.Length - 2);

            //values.Discount = LblPricingSummaryDiscount.GetText(WebDriver);

            values.TotalMargin = LblSummaryMargin.GetText(WebDriver).Substring(1);
            //if (isSmartPriceEnabled)
            //  values.SmartpriceRevenue = ByLblSummarySmartpriceRevenue.GetText(WebDriver);
            values.ShippingPrice = LblPricingSummaryShippingPrice.GetText(WebDriver);
            values.ShippingDiscount = LblPricingSummaryShippingDiscount.GetText(WebDriver);
            values.Subtotal = Convert.ToDouble(LblPricingSummarySubTotal.GetText(WebDriver).Substring(1));
            values.TotalShipping = Convert.ToDouble(LblPricingSummaryTotalShipping.GetText(WebDriver).Substring(1));
            values.TotalTax = Convert.ToDouble(LblPricingSummaryTotalTax.GetText(WebDriver).Substring(1));
            values.TotalEcoFee = Convert.ToDouble(LblPricingSummaryTotalEcoFee.GetText(WebDriver).Substring(1));
            values.FinalPrice = Convert.ToDouble(LblPricingSummaryFinalPrice.GetText(WebDriver).Substring(5));

            return values;
        }
        
        public ItemQuoteData GetNonTiedItemUnitValues(int groupIndex = 1, int itemIndex = 1, int nonTiedIndex = 1, bool contractCodeRequired = false)
        {
            Logger.Write("Getting Values for Non-Tied Item " + nonTiedIndex + " under Item " + itemIndex + " in Shipping Group " + groupIndex);
            Logger.Write("-------------------------");

            var itemQuoteData = new ItemQuoteData
            {
                DiscountOffList = Convert.ToDouble(LblItemLevelNonTiedDiscountOffList(nonTiedIndex).GetText(WebDriver)),
                ListPrice = LblItemLevelNonTiedUnitListPrice(nonTiedIndex).GetText(WebDriver).Substring(1),
                Discount = Convert.ToDouble(LblItemLevelNonTiedUnitDiscount(nonTiedIndex).GetText(WebDriver).Substring(1)),
                SellingPrice = LblItemLevelNonTiedUnitSellingPrice(nonTiedIndex).GetText(WebDriver).Substring(1),
                Quantity = int.Parse(LblItemLevelNonTiedQuantity(groupIndex, itemIndex, nonTiedIndex).GetText(WebDriver))
            };

            return itemQuoteData;
        }

        public ItemQuoteData GetNonTiedItemTotalValuesWithQuantity(int groupIndex = 1, int itemIndex = 1, int nonTiedIndex = 1, bool contractCodeRequired = false)
        {
            Logger.Write("Getting Values for Item " + itemIndex + " in Shipping Group " + groupIndex + " With Quantity");
            Logger.Write("-------------------------");

            var itemQuoteDataWithQuantity = new ItemQuoteData
            {
                ListPrice = LblItemLevelNonTiedListPrice(groupIndex, itemIndex, nonTiedIndex).GetText(WebDriver).Substring(1),
                Discount = Convert.ToDouble(LblItemLevelNonTiedDiscount(groupIndex, itemIndex, nonTiedIndex).GetText(WebDriver).Split('/')[1].Substring(2)),
                DiscountOffList = Convert.ToDouble(LblItemLevelNonTiedDiscount(groupIndex, itemIndex, nonTiedIndex).GetText(WebDriver).Split('/')[0].Substring(0).Split('%')[0]),
                SellingPrice = LblItemLevelNonTiedSellingPrice(groupIndex, itemIndex, nonTiedIndex).GetText(WebDriver).Substring(1)
            };

            return itemQuoteDataWithQuantity;
        }

        public List<Dictionary<string, object>> GetAddressTableFromSubscriptionBillingTab(int? index)
        {
            GetSkuSummaryGrid(index).WaitForElement(WebDriver);
            return GetSkuSummaryGrid(index).GetTableData(WebDriver);
        }

        public void ClickCreateQuoteFromMergeModal()
        {
            WebDriver.GetElement(By.Id("mergeQuote_continue")).Click(WebDriver);
        }

        public PCFQuoteSummaryPage PatchGTPId(String gtpID, IWebElement element)
        {
            try
            {
                element.Clear();
                element.SetText(WebDriver, gtpID);
                element.SendKeys(Keys.Tab);
            }
            catch (StaleElementReferenceException)
            {
                WebDriver.VerifyBusyOverlayNotDisplayed();
            }
            return new PCFQuoteSummaryPage(WebDriver);
        }

        #region
        public PCFComplianceNotificationsPage CreateOrder()
        {
            ContinuetoCreateOrder.Click(WebDriver);
            // BtnCreateOrder.Click(WebDriver);

            return new PCFComplianceNotificationsPage(WebDriver);
        }

        public PCFQuoteSummaryPage ClickLargeValueHLDChkBox()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            ChkLargeValueHold.SelectCheckBox(WebDriver);


            return new PCFQuoteSummaryPage(WebDriver);
        }

        #endregion

        public bool IsErrorNotificationExist(IWebDriver webDriver, string errorNotificationMeassage)
        {
            bool isExist = false;
            IList<IWebElement> quoteDetailErrorNotificationsList = WebDriver.FindElements(By.XPath("//validation-results[@id='quoteValidationResults']//div[@id='errorNotification']//span"));
            if (quoteDetailErrorNotificationsList.Count > 0)
            {
                foreach (IWebElement quoteDetailErrorNotifications in quoteDetailErrorNotificationsList)
                {
                    if (quoteDetailErrorNotifications.GetText(webDriver).ToLower().Contains(errorNotificationMeassage.ToLower()))
                    {
                        isExist = true;
                        break;
                    }
                }
            }
            return isExist;
        }

        public String GetItemLevelNotification(int groupIndex = 1, int itemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='GM_Product_" + (groupIndex - 1) + "_" + (groupIndex - 1) + "']//div[@id='errorNotification']//span")).Text;

        }

        public IWebElement GetTAAItemDescription(int groupItemIndex = 1, int lineItemIndex = 1)
        {
            //return WebDriver.GetElement(By.XPath("//div[contains(@id,'productDescription_" + (groupItemIndex - 1) + "_" + (lineItemIndex - 1) + "')]"));
            return WebDriver.GetElement(By.XPath("//div[@id='GM_Product_" + (groupItemIndex - 1) + "_" + (lineItemIndex - 1) + "']/custom-panel/div/div/div/div/div/h5"));
        }

        public IWebElement GetItemDescription(int groupItemIndex = 1, int lineItemIndex = 1)
        {
            //return WebDriver.GetElement(By.XPath("//div[contains(@id,'productDescription_" + (groupItemIndex - 1) + "_" + (lineItemIndex - 1) + "')]"));
            return WebDriver.GetElement(By.XPath("//div[@id='GM_Product_" + (groupItemIndex - 1) + "_" + (lineItemIndex - 1) + "']/custom-panel/div/div/div/div/div/h5"));
        }

        public IWebElement QuoteSummaryTotalShipping(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id= 'shipping_group_panel_" +(lineItemIndex - 1) + "']/shipments-summary-base/shipments-summary/div[3]/div[1]/div/span[2]"));
        }
        #region AutoPilot
        public IWebElement AutoPilotSection(int shippingGroupIndex = 1, int itemIndex = 1)
        {
            return WebDriver.GetElement(By.Id("AutoPilot_" + (shippingGroupIndex - 1) + "_" + (itemIndex - 1) + "_title"), TimeSpan.FromSeconds(10));
        }

        public IWebElement TxtTenantId(int shippingGroupIndex = 1, int itemIndex = 1)
        {
            return WebDriver.GetElement(By.Id(string.Format("AutoPilot_{0}_{1}", shippingGroupIndex - 1, itemIndex - 1) + "_tenantid_input"), TimeSpan.FromSeconds(3));
        }

        public IWebElement TxtDomain(int shippingGroupIndex = 1, int itemIndex = 1)
        {
            return WebDriver.GetElement(By.Id(string.Format("AutoPilot_{0}_{1}", shippingGroupIndex - 1, itemIndex - 1) + "_domain_input"), TimeSpan.FromSeconds(3));
        }

        public bool VerifyAutopilotSectionDisplayed(int shippingGroupIndex = 1, int itemIndex = 1)
        {
            return AutoPilotSection(shippingGroupIndex, itemIndex).IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(3)) && TxtTenantId(shippingGroupIndex, itemIndex).IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(3)) && TxtDomain(shippingGroupIndex, itemIndex).IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(2));
        }

        public bool VerifyTenantIdandDomainDataShown(string tenantId, string domain, int shippingGroupIndex = 1, int itemIndex = 1)
        {
            return TxtTenantId(shippingGroupIndex, itemIndex).GetText(WebDriver, TimeSpan.FromSeconds(3)).Equals(tenantId) && TxtDomain(shippingGroupIndex, itemIndex).GetText(WebDriver, TimeSpan.FromSeconds(3)).Equals(domain);
        }

        public void VerifyAutopilotData(bool verifyAutopilotSectionDisplayed, bool verifyTenantIdandDomainDataShown, string tenantId, string domain, int shippingGroupIndex = 1, int itemIndex = 1)
        {
            if (verifyAutopilotSectionDisplayed == true)
            {
                VerifyAutopilotSectionDisplayed(shippingGroupIndex, itemIndex).Should().BeTrue();
                Logger.Write($"Autopilot section is displayed at Item {itemIndex} in Shipping Group {shippingGroupIndex}");
                if (verifyTenantIdandDomainDataShown == true)
                {
                    VerifyTenantIdandDomainDataShown(tenantId, domain, shippingGroupIndex, itemIndex).Should().BeTrue();
                    Logger.Write($"Autopilot section with TenantId-{tenantId} and Domain-{domain} is displayed at Item-{itemIndex} in Shipping Group-{shippingGroupIndex}");

                }
                else
                {
                    if (!string.IsNullOrEmpty(tenantId) && !string.IsNullOrEmpty(domain))
                    {
                        VerifyTenantIdandDomainDataShown(tenantId, domain, shippingGroupIndex, itemIndex).Should().BeFalse();
                        Logger.Write($"Autopilot section shown with NO TenantId and Domain data at Item-{itemIndex} in Shipping Group-{shippingGroupIndex}");
                    }
                }
            }
            else
            {
                VerifyAutopilotSectionDisplayed(shippingGroupIndex, itemIndex).Should().BeFalse();
                Logger.Write($"Autopilot section is NOT displayed at Item {itemIndex} in Shipping Group {shippingGroupIndex}");
            }


        }

        #endregion

        public bool CheckQuoteExpiration(string expirationDate)
        {
            string ExpirationDate = QuoteExpirationDateValue.GetText(WebDriver);
            var date = DateTime.Parse(ExpirationDate).ToString("MM/dd/yyyy");
            //ExpirationDate.
            if (date == expirationDate)
                return true;
            return false;
        }
        public IWebElement LinkedQuoteList(int index)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='linkedQuotesDropDownButton']//li[" + index + "]/button"));
        }

        public IList<IWebElement> LinkedQuoteLists(IWebElement linkedQuoteDropdown)
        {
            return linkedQuoteDropdown.FindElements(By.TagName("li")); 
        }       


        public string GetCurrencyCodeFromSummary()
        {
            return WebDriver.GetElement(By.XPath("//*[@id='header-currency-code']")).GetText(WebDriver);

        }

        public IWebElement QuoteLanguage { get { return WebDriver.GetElement(By.XPath("//span[normalize-space()='Language']/following-sibling::span")); } }

        public IWebElement ToggleViewMoreOrLess { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_SEItem_show_more_0_0']//div//a//i")); } }

        public IWebElement ServiceTagInfo { get { return WebDriver.GetElement(By.Id("quoteDetail_LI_configuration_details_0_0_0")); } }
        public IWebElement BillToAddressDetail { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), 'Bill to Address')]/following-sibling::div[1]")); } }
        public IWebElement AddressLnk { get { return WebDriver.GetElement(By.XPath("//div[normalize-space()='Addresses']//a")); } }
        public IWebElement QuoteDeatilsLinkedQuotesListBox { get { return WebDriver.GetElement(By.Id("quoteDetail_LinkedQuotes")); } }
        By QuoteDetailsOverrideValidationMessagesby = By.Id("quoteDetail_Overridable_Validation_Messages");
        By XPODErrorwithNoOverrideby = By.Id("quoteDetail_XPOD_Validation_Message");
        By ValidationErrorMessagesby = By.XPath(".//span");
        public IWebElement LnkCurrentCustomerCompanyName { get { return WebDriver.GetElement(By.Id("currentCustomer_createCustomerHeaderLink1")); } }

        public IWebElement LnkCurrentCustomerCustomerName { get { return WebDriver.GetElement(By.Id("currentCustomer_createCustomerHeaderLink2")); } }


        public IWebElement TxtCurrentCustomerCustomerNumber { get { return WebDriver.GetElement(By.Id("currentCustomer_customerNumber")); } }


        public IWebElement TxtCurrentCustomerCompanyNumber { get { return WebDriver.GetElement(By.Id("currentCustomer_context")); } }       

        public IWebElement TxtEndUserAccountNumber { get { return WebDriver.GetElement(By.Id("quoteDetail_endUserAccountNumber")); } }
        public IWebElement UnitListPriceAtQuoteDetailsPage { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_LI_configuration_details_0_0_0']/div/div/div[2]/div[5]")); } }

        public IWebElement Unit_SellingPriceAtQuoteDetailsPag { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_LI_configuration_details_0_0_0']/div/div/div[2]/div[6]")); } }
        public IWebElement ReviewChecklist { get { return WebDriver.GetElement(By.XPath("//div[@id='quoteDetail_contentHorizontal']//div[@id='review-checklist-modal']")); } }
        public IWebElement UCIDRequestShippingAddress { get { return WebDriver.GetElement(By.CssSelector("#quoteDetail_GI_shippingInformation_0>div~div:not(#quoteDetail_GI_shippingAddress_0)")); } }

        public IWebElement LblExportConfirmationPcf { get { return WebDriver.GetElement(By.Id("quoteDetail_exportConfirmation")); } }

        public IWebElement CloseExportConfirmationDialogPcf { get { return WebDriver.GetElement(By.Id("quoteDetail_saveConfigClose")); } }

        public string GetServiceTagAtItemLevel()
        {
            WaitForQuoteValidationToComplete();
            ToggleViewMoreOrLess.Click();
            return ToggleViewMoreOrLess.Text;
        }

        //public IWebElement GetNotification()
        //{
        //    WebDriver.VerifyBusyOverlayNotDisplayed();
        //    return
        //        WebDriver.FindElement(By.XPath("//*[@id='quoteDetail_quote_Validation']"));
        //}
        public bool VerifyOnlyXPODErrorMessages()
        {
            bool result = false;
            WaitForQuoteValidationToComplete();
            WebDriver.VerifyBusyOverlayNotDisplayed();
            if (WebDriver.ElementExists(QuoteDetailsOverrideValidationMessagesby))
            {
                IWebElement OverridableXPODerror = QuoteDetailsOverrideValidationMessages().FindElement(ValidationErrorMessagesby);
                if (OverridableXPODerror.Text.ToLower().Equals("xpod status"))
                {
                    result = true;
                }

            }
            else if (WebDriver.ElementExists(XPODErrorwithNoOverrideby))
            {
                IWebElement NonOverridableXPODerror = WebDriver.FindElement(XPODErrorwithNoOverrideby);
                if (NonOverridableXPODerror.Text.ToLower().Contains("xpod status"))
                {
                    result = true;
                }
            }
            return result;
        }
        public IWebElement QuoteDetailsOverrideValidationMessages()
        {
            var lstwebelements = WebDriver.GetElements(By.XPath("//*[@id='quoteDetail_Overridable_Validation_Messages']"), TimeSpan.FromSeconds(15));
            if (lstwebelements != null && lstwebelements.Count > 0)
            {
                return lstwebelements[0];
            }
            return null;
        }
        public IWebElement LnkItemLevelShowMore(int? groupIndex = 0, int? lineItemIndex = 0)
        {
            return WebDriver.GetElement(By.XPath("id('" + PagePrefix + "_LI_show_more_" + groupIndex + "_" + lineItemIndex + "')/a"));
            //return WebDriver.GetElement(By.XPath("//div[@id='" + PagePrefix + "_LI_show_more_" + groupIndex + "_" + lineItemIndex + "')/div[1]/a[1]"));
        }
        public int GetTotalNumberOfConfigurations(int? groupIndex = 0)
        {
            //return WebDriver.GetElements(By.CssSelector("#quoteCreate_LI_CS_grid_1 > div > div")).Count;
            return WebDriver.GetElements(By.XPath(string.Format("//div[@id='quoteDetail_accordion_{0}_0']//table[@class='config-option-sku-table']", groupIndex))).Count;
        }
        public string GetConfigSkuCodeAtGroupAndSku(int? groupIndex = 0, int? lineItemIndex = 0, int? skuCodeIndex = 0)
        {
            //return WebDriver.GetElements(By.CssSelector("#quoteCreate_LI_CS_grid_1 > div > div")).Count;
            return WebDriver.GetElement(By.XPath(string.Format("(//*[@id='lineitem_config_block_{0}_0']//table[@class='config-option-sku-table'])[{1}]//tbody/tr[2]/td[2]", groupIndex, skuCodeIndex))).GetText(WebDriver);

        }
        public QuoteFooter OtherInformation
        {
            get
            {
                return new QuoteFooter(WebDriver, PagePrefix);
            }
        }

        public IWebElement ProductGroupName(int index1, int index2)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_LI_productDescription_" + index1 + "_" + index2 + "']"));
        }
        public IWebElement LblSystemID(int groupIndexint, int lineItemIndex)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_arbSystemId_" + groupIndexint + "_" + lineItemIndex + ""));
        }
        public IWebElement LblServiceTag(int groupIndex, int lineItemIndex)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_arbServiceTag2_" + groupIndex + "_" + lineItemIndex + ""));
        }
        public IWebElement LblItemValidations(int groupIndex, int lineItemIndex)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_item_validations_" + groupIndex + "_" + lineItemIndex + ""));
        }

        public IWebElement LineItemIQNumber(int groupIndex = 1, int itemIndex = 1)
        {
            return WebDriver.GetElement(By.Id("quoteDetail_LI_productRsId_" + (groupIndex - 1) + "_" + (itemIndex - 1)));
        }

        public List<string> GetAllARBbaseConfigValues()
        {

            IList<IWebElement> list = WebDriver.GetElements(By.CssSelector("tbody > tr > td"));
            List<string> baseConfigDetails = new List<string>();
            var total = list.Count;
            if (total >= 3)
            {
                foreach (IWebElement values in WebDriver.GetElements(
                    By.CssSelector("tbody > tr > td")))
                {
                    baseConfigDetails.Add(values.GetText(WebDriver));


                }

            }
            else
            {
                Assert.Fail("Count did not match");
            }
            return baseConfigDetails;
        }

        #region ARB Notifications                   
      

        #endregion

        public void SearchQuotewithQuickSearch(IWebDriver driver, string quoteNumber)
        {
            QuickSearchtxtbox.SetText(driver, quoteNumber);
            QuickSearchbtn.Click();

        }
        public IWebElement GetItemQuantity(int groupItemIndex = 1, int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='item_summary_quantity_" + (groupItemIndex - 1) + "_" + (lineItemIndex - 1) + "']"));
        }

        public IWebElement GetSellingPrice(int groupItemIndex = 1, int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.Id("item_summary_sellingPrice"));
        }

        public IWebElement ExpandAllConfiguration(int groupItemIndex , int lineItemIndex)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='option_"+ groupItemIndex +"_"+ lineItemIndex+"']"));
        }

        public bool CFICommentsFound()//int itemIndex = 0, int groupIndex = 0
        {
            bool commentFound = false;
            ShippingGroupInfoSection(0,0).Click(WebDriver);
            ExpandAllConfiguration(0,0).Click(WebDriver);

            //Click comments link

            WebDriver.FindElement(By.XPath("//*[@id='cfiComments']")).Click();
            if (WebDriver.GetElement(By.Id("cfiModal_title")).Displayed)
            {
                commentFound = WebDriver.FindElement(By.XPath("//*[@class='dds__modal - dialog']//div[contains(text(),'test')]")).Text.Contains("test");
            }
            return commentFound;
        }

        public IWebElement GetNotification()
        {
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return
                WebDriver.FindElement(By.XPath("//*[@id='quoteValidationResults']"));
        }
        public int Get_countof_EOL_notifications(string EOLString)
        {
            string[] notifications = GetNotification().Text.Split('\n');
            var notificationsCnt = 0;
            foreach (var notification in notifications)
            {
                if (notification.Contains(EOLString))
                    notificationsCnt++;
            }
            return notificationsCnt;
        }

        public IWebElement SelectVersionToggle { get { return WebDriver.GetElement(By.Id("quoteDetail_versionToggle")); } }

        public int GetCountOfAvailableVersions()
        {
            int count = WebDriver.GetElements(By.XPath("//table/tbody/tr")).Count();
            return (count - 1);
        }

    }
}

