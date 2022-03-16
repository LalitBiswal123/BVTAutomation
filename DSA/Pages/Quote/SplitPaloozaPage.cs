using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Quote
{
    public class SplitPaloozaPage : DsaPageBase
    {
        public SplitPaloozaPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements
      

public IWebElement QuoteNumber { get { return WebDriver.GetElement(By.CssSelector("#quoteSplit_header > div:nth-child(2) > div:nth-child(2) > div > p")); } }


public IWebElement Title { get { return WebDriver.GetElement(By.Id("quoteSplit_title")); } }


public IWebElement DdlSelectQuote { get { return WebDriver.GetElement(By.Id("splitQuoteSelect")); } }


public IWebElement DeleteQuote { get { return WebDriver.GetElement(By.Id("splitQuoteDelete")); } }


public IWebElement TxtCustomerNumber { get { return WebDriver.GetElement(By.Id("quoteSplit_customerNumber")); } }


public IWebElement TxtQuoteName { get { return WebDriver.GetElement(By.Id("quoteSplit_quoteName")); } }


public IWebElement TxtExpirationDate { get { return WebDriver.GetElement(By.Id("quoteSplit_expirationDate")); } }


public IWebElement TxtPoNumber { get { return WebDriver.GetElement(By.Id("quoteSplit_poNumber")); } }


public IWebElement ByTxtContractCode { get { return WebDriver.GetElement(By.Id("quoteSplit_contractCode")); } }


public IWebElement TxtDealId { get { return WebDriver.GetElement(By.Id("quoteSplit_dealId")); } }


public IWebElement TxtEndUserCustomerNumber { get { return WebDriver.GetElement(By.Id("quoteSplit_endUserCustomerNumber")); } }


public IWebElement BtnSaveQuotes { get { return WebDriver.GetElement(By.Id("quoteSplit_saveQuotes")); } }


public IWebElement Cancel { get { return WebDriver.GetElement(By.Id("quoteSplit_cancel")); } }


public IWebElement HdrSummary { get { return WebDriver.GetElement(By.Id("quoteSplit_summary_header")); } }


public IWebElement LblListPrice { get { return WebDriver.GetElement(By.Id("quoteSplit_summary_listPrice")); } }


public IWebElement LblSellingPrice { get { return WebDriver.GetElement(By.Id("quoteSplit_summary_sellingPrice")); } }


public IWebElement LblDiscountPercent { get { return WebDriver.GetElement(By.Id("quoteSplit_summary_discountPercent")); } }


public IWebElement LblMarginValue { get { return WebDriver.GetElement(By.Id("quoteSplit_summary_marginValue")); } }


public IWebElement LblMarginPercentage { get { return WebDriver.GetElement(By.Id("quoteSplit_summary_marginPercentage")); } }


public IWebElement LblSubtotalAmount { get { return WebDriver.GetElement(By.Id("quoteSplit_summary_subtotalAmount")); } }


public IWebElement LblShippingAmount { get { return WebDriver.GetElement(By.Id("quoteSplit_summary_shippingAmount")); } }


public IWebElement LblTotalTaxAmount { get { return WebDriver.GetElement(By.Id("quoteSplit_summary_totalTaxAmount")); } }


public IWebElement LblEcoFee { get { return WebDriver.GetElement(By.Id("quoteSplit_summary_ecoFee")); } }


public IWebElement LblFinalPrice { get { return WebDriver.GetElement(By.Id("quoteSplit_summary_finalPrice")); } }


public IWebElement BtnNotesToggle { get { return WebDriver.GetElement(By.Id("quoteCreate_notesToggle")); } }


public IWebElement SpnHdrNotes { get { return WebDriver.GetElement(By.Id("quoteCreate_notes_header")); } }


public IWebElement TblNotes { get { return WebDriver.GetElement(By.Id("DataTables_Table_3")); } }


public IWebElement BtnInstallationinstructionsToggle { get { return WebDriver.GetElement(By.Id("quoteCreate_installationinstructionsToggle")); } }


public IWebElement SpnHdrInstallationinstructions { get { return WebDriver.GetElement(By.Id("quoteCreate_installationinstructions_header")); } }


public IWebElement TxtAreaInstallationInstructions { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_installationinstructions']")); } }


public IWebElement LnkSaveInstallationInstructions { get { return WebDriver.GetElement(By.Id("quoteCreate_saveInstallationInstructions")); } }


public IWebElement LnkCancelInstallationInstructions { get { return WebDriver.GetElement(By.Id("quoteCreate_cancelInstallationInstructions")); } }


public IWebElement CustomerInformationToggle { get { return WebDriver.GetElement(By.Id("quoteSplit_customerInformationToggle")); } }


public IWebElement HdrCustomerInformation { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteSplit_contactHeading')]/div/span[1)]/span")); } }


public IWebElement CustomerId { get { return WebDriver.GetElement(By.Id("quoteSplit_customerId")); } }


public IWebElement CustomerNumber { get { return WebDriver.GetElement(By.Id("quoteSplit_customerNumber")); } }


public IWebElement CompanyName { get { return WebDriver.GetElement(By.Id("quoteSplit_companyName")); } }


public IWebElement CompanyNumber { get { return WebDriver.GetElement(By.Id("quoteSplit_companyNumber")); } }


public IWebElement CustomerClass { get { return WebDriver.GetElement(By.Id("quoteSplit_customerClass")); } }


public IWebElement ParentReference { get { return WebDriver.GetElement(By.Id("quoteSplit_parentReference")); } }


public IWebElement Channel { get { return WebDriver.GetElement(By.Id("quoteSplit_channel")); } }


public IWebElement ContactCfoLanguage { get { return WebDriver.GetElement(By.Id("quoteSplit_contactCFOLang")); } }


public IWebElement Address1 { get { return WebDriver.GetElement(By.Id("quoteSplit_address1")); } }


public IWebElement Address2 { get { return WebDriver.GetElement(By.Id("quoteSplit_address2")); } }


public IWebElement City { get { return WebDriver.GetElement(By.Id("quoteSplit_city")); } }


public IWebElement State { get { return WebDriver.GetElement(By.Id("quoteSplit_state")); } }


public IWebElement PostalCode { get { return WebDriver.GetElement(By.Id("quoteSplit_zip")); } }


public IWebElement Country { get { return WebDriver.GetElement(By.Id("quoteSplit_primaryContactCountry")); } }


public IWebElement PrimaryContactName { get { return WebDriver.GetElement(By.Id("quoteSplit_primaryContactName")); } }


public IWebElement Department { get { return WebDriver.GetElement(By.Id("quoteSplit_department")); } }


public IWebElement Email { get { return WebDriver.GetElement(By.Id("quoteSplit_email")); } }


public IWebElement Telephone { get { return WebDriver.GetElement(By.Id("quoteSplit_telephone")); } }


public IWebElement FinancialInformationId { get { return WebDriver.GetElement(By.Id("quoteSplit_financialInformationHeading")); } }


public IWebElement FinancialInformationToggle { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteSplit_financialInformationHeading')]/div/span/a")); } }


public IWebElement HdrFinancialInformation { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteSplit_financialInformationHeading')]/div/span[1)]/span")); } }


public IWebElement PaymentMethod { get { return WebDriver.GetElement(By.Id("quoteSplit_financingPaymentMethod")); } }


public IWebElement PaymentTerms { get { return WebDriver.GetElement(By.Id("quoteSplit_paymentTerm")); } }


public IWebElement Currency { get { return WebDriver.GetElement(By.Id("quoteSplit_currency")); } }


public IWebElement Discount { get { return WebDriver.GetElement(By.Id("quoteSplit_discount")); } }


public IWebElement FederalTaxId { get { return WebDriver.GetElement(By.Id("quoteSplit_federalTaxId")); } }


public IWebElement TaxExempt { get { return WebDriver.GetElement(By.Id("quoteSplit_taxExempt")); } }


public IWebElement DiscountEntitlements { get { return WebDriver.GetElement(By.Id("quoteSplit_discountEntitlements")); } }


public IWebElement PromotionCode { get { return WebDriver.GetElement(By.Id("quoteSplit_promotionCode")); } }


public IWebElement CustomerHold { get { return WebDriver.GetElement(By.Id("quoteSplit_customerHold")); } }


public IWebElement CreditHold { get { return WebDriver.GetElement(By.Id("quoteSplit_creditHold")); } }


public IWebElement CreditLimit { get { return WebDriver.GetElement(By.Id("quoteSplit_CreditLimit")); } }


public IWebElement CurrentBalance { get { return WebDriver.GetElement(By.Id("quoteSplit_CurrentBalance")); } }


public IWebElement RemainingBalance { get { return WebDriver.GetElement(By.Id("quoteSplit_RemainingBalance")); } }


public IWebElement ThirtyDayBalance { get { return WebDriver.GetElement(By.Id("quoteSplit_30DayBalance")); } }


public IWebElement SixtyDayBalance { get { return WebDriver.GetElement(By.Id("quoteSplit_60DayBalance")); } }


public IWebElement PrimarySalesRep { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteSplit_salesRep')]/span")); } }


public IWebElement TagSalesRep { get { return WebDriver.GetElement(By.Id("quoteSplit_tagRepNew")); } }

        #endregion

        public QuoteSplitResultsPage SaveQuotes()
        {
            BtnSaveQuotes.Click(WebDriver);
            return new QuoteSplitResultsPage(WebDriver);
        }
    }
}
