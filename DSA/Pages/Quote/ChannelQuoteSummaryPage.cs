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
using Dsa.Utils;
using Dsa.Workflows;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;


namespace Dsa.Pages.Quote
{
	public class ChannelQuoteSummaryPage : DsaPageBase
	{
		private const string PagePrefix = "channelQuoteSummary";

		public ChannelQuoteSummaryPage(IWebDriver webDriver)
			: base(webDriver)
		{
			Name = "Quote Summary Page";
			PageFactory.InitElements(WebDriver, this);
			webDriver.VerifyBusyOverlayNotDisplayed();

		}


		#region Elements

		//Quote header

		public IWebElement LnkGoToHomePage { get { return WebDriver.GetElement(By.Id("dellBrandLogo_goHomePage")); } }


		public IWebElement LblPageTitle { get { return WebDriver.GetElement(By.Id("quoteTitle")); } }


		public IWebElement LblQuoteNumber { get { return WebDriver.GetElement(By.XPath("//div//span[contains(@id, 'quoteNumber')]")); } }


		public IWebElement LblQuoteVersion { get { return WebDriver.GetElement(By.Id("quoteVersion")); } }


		public IWebElement LblOfferNumber { get { return WebDriver.GetElement(By.Id("offerNumber")); } }


		public IWebElement lnkSolutionId { get { return WebDriver.GetElement(By.Id("solutionId")); } }


		public IWebElement LblQuoteValidationMessage { get { return WebDriver.GetElement(By.XPath("//quote-summary-validation//div[contains(@class, 'error')]")); } }


		public IWebElement LblEndUserCustomerNumber { get { return WebDriver.GetElement(By.Id("endUserCustomerNumber")); } }


		public IWebElement LblPoNumber { get { return WebDriver.GetElement(By.Id("poNumber")); } }


		public IWebElement LblQuoteCreatedBy { get { return WebDriver.GetElement(By.Id("createdBy")); } }


		public IWebElement LblQuoteExpirationDate { get { return WebDriver.GetElement(By.Id("ExpirationDate")); } }


		public IWebElement LnkShowMore { get { return WebDriver.GetElement(By.Id("quote-summary-heading")); } }


		public IWebElement LnkShowLess { get { return WebDriver.GetElement(By.XPath("//button//span[contains(text(), 'See Less')]")); } }


		public IWebElement LblQuoteCreatedOn { get { return WebDriver.GetElement(By.XPath("//*[@id='CreatedOn']")); } }

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

		//Shipping information

		public IWebElement BtnExpandOrCollapseAll { get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Shipping Info')]/button")); } }


		public IWebElement BtnShippingGrpExpandOrCollapseAll { get { return WebDriver.GetElement(By.XPath("//div//button[contains(@class, 'item-details-info dds__btn-link dds__btn-secondary dds__btn-sm expand-all-btn')]")); } }


		public IWebElement ShippingGroupAccordion { get { return WebDriver.GetElement(By.XPath("//div//button//i[contains(@class, 'dds__icons dds__chevron-right accordion-lg accordion-sm')]")); } }


		public IWebElement EndUserName { get { return WebDriver.GetElement(By.XPath("//*[@id='endUserCompanyName']/span[2]")); } }


		public IWebElement ResellerSection { get { return WebDriver.GetElement(By.Id("resellerCustomer_title")); } }


		public IWebElement LblResellerCompName { get { return WebDriver.GetElement(By.XPath("//*[@id='resellerCustomer_title']/text()")); } }


		public IWebElement LblResellerAddress { get { return WebDriver.GetElement(By.Id("resellerCustomer_address")); } }

		//Item Level

		public IWebElement LblItemDetails { get { return WebDriver.GetElement(By.XPath("//div[contains(@id, 'shipping_group_Item_panel')]/div[2]")); } }


		public IWebElement BtnItemGrpExpandOrCollapseAll { get { return WebDriver.GetElement(By.XPath("//div//button[contains(@class, 'item-details-info dds__btn dds__btn-secondary dds__btn-sm expand-all-btn')]")); } }

		//Sku Level

		public IWebElement LblSkuDetails { get { return WebDriver.GetElement(By.XPath("//div[contains(@class, 'configuration-option-details')]")); } }


		public IWebElement BtnSkuGrpExpandOrCollapseAll { get { return WebDriver.GetElement(By.XPath("//div//button[contains(text(), 'Expand All')]")); } }

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


		public IWebElement BtnCreateOrder { get { return WebDriver.GetElement(By.Id("continueToCheckoutButton")); } }


		public IWebElement BtnSendToPOMProcessing { get { return WebDriver.GetElement(By.Id("SendToPomLink")); } }


		public IWebElement BottomScreenCheckoutBtn { get { return WebDriver.GetElement(By.Id("PaymentButton")); } }


		public IWebElement LblProgressTrackerBar { get { return WebDriver.GetElement(By.Id("PartnerProgressBar")); } }


		public IWebElement BtnAdditionalQuoteDetails { get { return WebDriver.GetElement(By.XPath("//span[contains(text(), ' Show additional quote details ')]")); } }


		public IWebElement ShowFullQuoteDetailSections { get { return WebDriver.GetElement(By.XPath("//div[contains(@class, 'mg-top-10 pd-top-10 dell-content dds__form-group')]")); } }


		public IWebElement TxtShippingInstructions { get { return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_panel_0']/div[4]/div")); } }


		public IWebElement TxtSummaryPageLegalFooter { get { return WebDriver.GetElement(By.XPath("//div[contains(@class,'footer-text')]")); } }


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
			return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[1]/div[4]/div[2]"));
		}

		public IWebElement LblItemLevelDiscountOffList(int groupIndex = 1, int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[2]/div[1]/item-discounts/div/div/div[4]/div[2]/div/b/span"));
		}

		public IWebElement LblItemLevelUnitSellingPrice(int groupIndex = 1, int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[1]/div[5]/div[2]/div/span"));
		}

		public IWebElement LblItemLevelUnitMargin(int groupIndex = 1, int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[1]/div[7]/div[2]"));
		}

		public IWebElement LblItemLevelQuantity(int groupIndex = 1, int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[2]/div[1]/div[2]"));
		}

		public IWebElement LblContractCode(int groupIndex = 1, int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[2]/div[2]/item-contract-details/div/div/div[1]/div[2]/b"));
		}

		public IWebElement LblItemLevelTotalDiscount(int groupIndex = 1, int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[2]/div[4]/div[2]"));
		}

		public IWebElement LblItemLevelMargin(int groupIndex = 1, int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[2]/div[6]/div[2]"));
		}

		public IWebElement LblItemLevelPromotions(int groupIndex = 1, int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[2]/div[1]/item-discounts/div/div/div[3]/div[2]/b"));
		}

		public IWebElement LblItemLevelTotalListPrice(int groupIndex = 1, int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[2]/div[2]/div[2]"));
		}

		public IWebElement LblItemLevelTotalSellingPrice(int groupIndex = 1, int lineItemIndex = 1)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[1]/div[1]/item-pricing/item-pricing-expanded/div/div[2]/div[5]/div[2]"));
		}

		#endregion

		#region PCFQuoteSummaryElements  

		//Login Section


		public IWebElement LnkSignIn { get { return WebDriver.GetElement(By.Id("lemcEmployeeLoginLink")); } }

		//Quote Section

		public IWebElement LblQuoteCopiedFrom { get { return WebDriver.GetElement(By.XPath("//*[@id='copiedFromId']/a")); } }


		public IWebElement ExpandItemViewMore { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'quoteDetail_SEItem_show_more')]//a")); } }


		public IWebElement BtnDellLogo { get { return WebDriver.GetElement(By.Id("DellIcon")); } }


		public IWebElement BtnReturnToTop { get { return WebDriver.GetElement(By.XPath("//*[@id='ReturnToTop']")); } }


		public IWebElement LblSummaryMargin { get { return WebDriver.GetElement(By.Id("pricingSummary_totalMargin")); } }


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


		public IWebElement QuoteExpiresOn { get { return WebDriver.GetElement(By.Id("headerExpiresOnValue")); } }


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

		public IWebElement LnkBillToCustomerFinancialInformation { get { return WebDriver.GetElement(By.XPath("//h5//button//span[contains(@class, 'financeinfo-header accordion-header')]")); } }


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


		public IWebElement DBCCreditStatus { get { return WebDriver.GetElement(By.Id("scc_dbcAvailableCredit")); } }


		public IWebElement DBCLeaseStatus { get { return WebDriver.GetElement(By.Id("scc_leaseOffer")); } }


		public IWebElement DBCDetailsLink { get { return WebDriver.GetElement(By.Id("scc_viewDfsDetailsLink")); } }

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

		//Order Hold Options Section

		public IWebElement LblItemsInsureHdr { get { return WebDriver.GetElement(By.Id("quoteInsuredItem_title")); } }


		public IWebElement LblItemsInsureNotes { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteInsuredItem_notes']")); } }


		public IWebElement LblFusionID { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteInsuredItem_fusion_id']")); } }


		public IWebElement LblPOMID { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteInsuredItem_pom_id']")); } }


		public IWebElement BtnInsureItemCancel { get { return WebDriver.GetElement(By.Id("quoteInsuredItem_CancelBtn")); } }


		public IWebElement BtnSubmitInsureItem { get { return WebDriver.GetElement(By.Id("quoteInsuredItem_SubmitBtn")); } }

		//Quick Search
		public IWebElement LblQuickSearch { get { return WebDriver.GetElement(By.XPath("//div//input[contains(@class,  'intuitive-search')]")); } }

		public IWebElement BtnQuickSearch { get { return WebDriver.GetElement(By.XPath("//button//i[contains(@class, 'dds__icons dds__search')]")); } }

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

		public IWebElement BtnReturnToQuoteSummaryLnk { get { return WebDriver.GetElement(By.Id("returnToQuoteSummaryLink")); } }

		public IWebElement TextReviewOrderShippingDetails { get { return WebDriver.GetElement(By.Id("salesOrderTitle")); } }

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

		public ChannelQuoteSummaryPage WaitForQuoteValidationToComplete()
		{

			for (var i = 0; i <= 2; i++)
			{
				By oldbyLoc = By.XPath("//span[contains(@class,'validationMessage')]");

				if (IsQuoteValidationElementDisplayed(oldbyLoc))
				{
					new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime).Until(ExpectedConditions.InvisibilityOfElementLocated(oldbyLoc));

				}

			}
			return new ChannelQuoteSummaryPage(WebDriver);

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

		public IWebElement ShippingGroupInfoSection(int? shippingGroupIndex = 0)
		{
			return WebDriver.GetElement(By.XPath("//*[@id='item_" + shippingGroupIndex + "_" + shippingGroupIndex + "_accordion_show_more_button']/span[1]"));

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
				SubTotal = Convert.ToDouble(LblShippingGroupSummarySubTotal(0).GetText(WebDriver).Substring(1)),
				TotalShipping = Convert.ToDouble(LblShippingGroupSummaryShippingAmount(0).GetText(WebDriver).Substring(1)),
				TotalTax = Convert.ToDouble(LblShippingGroupSummaryTax(0).GetText(WebDriver).Substring(1)),
				TotalEcoFee = Convert.ToDouble(LblShippingGroupSummaryEcoFee(0).GetText(WebDriver).Substring(1)),
				TotalAmount = Convert.ToDouble(LblShippingGroupSummaryTotalAmount(0).GetText(WebDriver).Substring(5))
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

		public ChannelQuoteSummaryPage ClickLnkClose()
		{
			WebDriver.FindElement(By.XPath("//*[@id='dsaDialogCloseX']/span")).Click(WebDriver);
			return new ChannelQuoteSummaryPage(WebDriver);
		}

		public ChannelQuoteSummaryPage ExpandOrCollapseItemDetails()
		{
			WebDriver.FindElement(By.XPath("//*[@id='item_0']")).Click(WebDriver);
			return new ChannelQuoteSummaryPage(WebDriver);
		}

		public ChannelQuoteSummaryPage ExpandOrCollapseConfigDetails()
		{
			WebDriver.FindElement(By.XPath("//*[@id='option_0_0']")).Click(WebDriver);
			return new ChannelQuoteSummaryPage(WebDriver);
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

		public void QuickSearch(IWebDriver webDriver, DataRow row)
		{
			string[] arrValue = { row["Quote"].ToString(), row["Customer_Number"].ToString(), row["Dpid"].ToString(), row["OrderNumber"].ToString() };

			foreach (string s in arrValue)

			{
				//Quick Search - quote#, customer#, dpid# and order#
				LblQuickSearch.SetText(webDriver, s);
				BtnQuickSearch.Click(webDriver);

				By invalidSearch = By.XPath("//div//div[contains(@class, 'notification-wrapper')]");

				if (WebDriver.ElementExists(invalidSearch))
				{
					Assert.Fail("Search Type Is Incorrect");

				}

				else
				{

					WaitForQuoteValidationToComplete();
					//Returns to DSA Homepage
					var url = row["HomepageURL"].ToString();
					webDriver.Navigate().GoToUrl(url);
				}

			}

		}


		public IWebElement ErrorValidationMsg(int lineIndex)
		{
			return WebDriver.GetElement(By.Id("errorMessage" + lineIndex + ""));
		}
		public IWebElement WarningMsg(int lineIndex)
		{
			return WebDriver.GetElement(By.Id("warningMessage" + lineIndex + ""));
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
		public ChannelQuoteSummaryPage WaitForDraftQuoteValidationToComplete()
		{

			for (var i = 0; i <= 2; i++)
			{
				By waitValidationSpinner = By.XPath("//*[@id='validationLoading']/div/div");
				if (IsQuoteValidationElementDisplayed(waitValidationSpinner))
				{
					new WebDriverWait(WebDriver, DsaUtil.GlobalWaitTime).Until(ExpectedConditions.InvisibilityOfElementLocated(waitValidationSpinner));

				}

			}
			return new ChannelQuoteSummaryPage(WebDriver);

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
			return WebDriver.FindElement(By.XPath("//*[@id='ShipGroup" + groupIndex + "_installAt_address']/div[3]"));
		}
		public IWebElement InstallAtPhoneNo(int groupIndex)
		{
			return WebDriver.FindElement(By.Id("ShipGroup" + groupIndex + "_installAt_phone"));
		}
		public IWebElement InstallAtEmailAddr(int groupIndex)
		{
			return WebDriver.FindElement(By.Id("ShipGroup" + groupIndex + "_installAt_email"));
		}

		public IWebElement SoldToAddrInfo(string contactDetails)
		{
			return WebDriver.FindElement(By.Id("soldToCustomerCtrl_" + contactDetails));
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

		public Address GetSoldToAddrInfo()
		{
			Logger.Write("Getting all Info from Sold To Address");

			string customerName = "contactname";
			string contactAddress = "address";
			string phoneNumber = "phone";
			string emailAddress = "email";

			var SoldToAddrDetails = new Address

			{
				FirstName = SoldToAddrInfo(customerName).GetText(WebDriver),
				AddressLine1 = SoldToAddrInfo(contactAddress).GetText(WebDriver),
				PrimaryPhone = SoldToAddrInfo(phoneNumber).GetText(WebDriver),
				Email = SoldToAddrInfo(emailAddress).GetText(WebDriver),
			};

			return SoldToAddrDetails;
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


		public void SalesRepMismatchPopup()
		{
			WebDriver.VerifyBusyOverlayNotDisplayed();
			Thread.Sleep(3000);
			By salesRep = By.XPath("//*[@id='quoteSalesRepMismatch_loggedin_sales_rep_submit_button']");

			try
			{
				if (WebDriver.ElementExists(salesRep))
				{
					Logger.Write("Sales rep mismatch pop up is displayed");
					salesRep.Click(WebDriver);
					WebDriver.VerifyBusyOverlayNotDisplayed();
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
		}

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
				ListPrice = LblItemLevelUnitListPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1),
				DiscountOffList = Convert.ToDouble(LblItemLevelDiscountOffList(itemIndex, groupIndex).GetText(WebDriver).Split('%')[0]),
				Discount = Convert.ToDouble(LblItemLevelUnitDiscount(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				SellingPrice = (groupIndex == 2 && itemIndex == 1) ? LblItemLevelUnitSellingPrice(groupIndex).GetText(WebDriver).Substring(1) : LblItemLevelUnitSellingPrice(itemIndex).GetText(WebDriver).Substring(1),
				MarginValue = Convert.ToDouble(LblItemLevelUnitMargin(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
				Quantity = int.Parse(LblItemLevelQuantity(itemIndex, groupIndex).GetText(WebDriver)),
				ContractCode = contractCodeRequired ? LblContractCode(itemIndex).GetText(WebDriver) : ""
			};
			//SellingPrice = "$" + ByTxtItemLevelUnitSellingPrice(i).GetText(WebDriver).Replace(",", string.Empty),


			return itemQuoteData;
		}


		public ItemQuoteData GetLineItemUnitValuesWithQuantity(int groupIndex = 1, int itemIndex = 1, bool contractCodeRequired = false)
		{
			WaitForQuoteValidationToComplete();
			Logger.Write("Getting Values for Item " + itemIndex + " in Shipping Group " + groupIndex + "With Quantity");
			Logger.Write("-------------------------");

			var discount = LblItemLevelTotalDiscount(itemIndex, groupIndex).GetText(WebDriver);
			var margin = LblItemLevelMargin(itemIndex, groupIndex).GetText(WebDriver);
			var promotion = LblItemLevelPromotions(itemIndex, groupIndex).GetText(WebDriver);

			var itemQuoteDataWithQuantity = new ItemQuoteData
			{
				ListPrice = LblItemLevelTotalListPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1),
				Discount = Convert.ToDouble(discount.Split('/')[1].Substring(2)),
				DiscountOffList = Convert.ToDouble(discount.Split('/')[0].Substring(0).Split('%')[0]),
				SellingPrice = LblItemLevelTotalSellingPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1),
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
			WaitForQuoteValidationToComplete();
			return LblQuoteNumber.GetText(WebDriver).Trim();
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

			string discount = LblPricingSummaryDiscount.GetText(WebDriver);
			values.Discount = LblPricingSummaryDiscount.GetText(WebDriver).Substring(1, discount.IndexOf('(') - 1).Trim();

			//values.Discount = LblPricingSummaryDiscount.GetText(WebDriver);

			values.TotalMargin = LblSummaryMargin.GetText(WebDriver);
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
		public IWebElement GetItemDescription(int groupItemIndex = 1, int lineItemIndex = 1)
		{
			//return WebDriver.GetElement(By.XPath("//div[contains(@id,'productDescription_" + (groupItemIndex - 1) + "_" + (lineItemIndex - 1) + "')]"));
			return WebDriver.GetElement(By.XPath("//div[@id='GM_Product_" + (groupItemIndex - 1) + "_" + (lineItemIndex - 1) + "']/custom-panel/div/div/div/div/div/h5"));
		}
		public IWebElement GetTAAItemDescription(int groupItemIndex = 1, int lineItemIndex = 1)
		{
			//return WebDriver.GetElement(By.XPath("//div[contains(@id,'productDescription_" + (groupItemIndex - 1) + "_" + (lineItemIndex - 1) + "')]"));
			return WebDriver.GetElement(By.XPath("//div[@id='GM_Product_" + (groupItemIndex - 1) + "_" + (lineItemIndex - 1) + "']/custom-panel/div/div/div/div/div/h5"));
		}
		//to check dupsku notification on quote detail page
		public bool IsdupskuNotificationExist(IWebDriver webDriver, string errorNotificationMeassage)
		{

			IWebElement QuoteDupErrorNotifications = WebDriver.FindElement(By.XPath("//*[@id='errorMessage0']/span/text()"));
			if (QuoteDupErrorNotifications.GetText(webDriver).ToLower().Contains(errorNotificationMeassage.ToLower()))
				return true;
			else
				return false;
		}

		public bool IsErrorNotificationExist(IWebDriver webDriver, string errorNotificationMeassage)
		{
			bool isExist = false;

			IList<IWebElement> quoteDetailErrorNotificationsList = WebDriver.FindElements(By.XPath("//validation-results[@id='quoteValidationResults']//div[@id='errorNotification']//span"));

			
			//IList<IWebElement> quoteDetailErrorNotificationsList = WebDriver.FindElements(By.XPath("//div[@id='quoteDetail_quote_Validation']//div[@class='alert-error']//span"));

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


	}
}


