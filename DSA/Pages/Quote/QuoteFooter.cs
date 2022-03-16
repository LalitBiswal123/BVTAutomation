using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;

namespace Dsa.Pages.Quote
{
    public class QuoteFooter : DsaPageBase
    {
        static string lineItemPagePrefix;

        public QuoteFooter(IWebDriver webDriver, string pagePrefix)
            : base(webDriver)
        {
            lineItemPagePrefix = pagePrefix;
            PageFactory.InitElements(webDriver, this);
            webDriver.VerifyBusyOverlayNotDisplayed();
        }

        #region Elements

      
         public List<IWebElement> ChecklistTotalCost
        {
          get { return WebDriver.GetElements(By.XPath("(//*[text()='Total:']/following::td[1])")); }
        }

        public List<IWebElement> ChecklistQuoteNumber
        {
            get { return WebDriver.GetElements(By.XPath("//*[text()='Linked Quote Number:']/following-sibling::p")); }
        }

        public List<IWebElement> ChecklistInstallationInstructions
        {
            get { return WebDriver.GetElements(By.XPath("//*[text()='Installation Instructions:']/following::p[1]")); }
        }


        public IWebElement ChecklistShipInstructHeading
        {
            get { return WebDriver.GetElement(By.XPath("(//span[text()='Shipping Instructions:'])[1]")); }
        }

        public IWebElement CheckListUnitSellingPrice
        {
            get { return WebDriver.GetElement(By.XPath("(//th[text()='Unit Selling Price'])[1]")); }
        }


        public IWebElement BackChecklist
        {
            get { return WebDriver.GetElement(By.XPath("//span[text()='Back']")); }
        }

        public IWebElement ChecklistExpandCollapse(string expandCollapseOption)
        {
            return WebDriver.GetElement(By.XPath("//a[text()='" + expandCollapseOption + "']"), TimeSpan.FromSeconds(5));
        }


        public IWebElement LnkShippingInformation
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_shippingHeading")); }
        }
        public IWebElement InstallationInstructionsToggle
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_installationinstructionsToggle")); }
        }


        public IWebElement LnkInstallationInstructionsHeader
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_installationinstructions_header")); }
        }

        public IWebElement TxtInstallationInstruction
        {
            get { return WebDriver.GetElement(By.CssSelector("textarea#" + lineItemPagePrefix + "_installationinstructions")); }
        }
        
        public IWebElement TxtInstallationInstructiontReadonly
        {
            get { return WebDriver.FindElement(By.XPath("//div[contains(text(),'No installation instructions')]"));}
        }


        public IWebElement LnkCustomerInformationHeader
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_billToContactHeading")); }
        }


        protected IWebElement LblCustomerInfoCutomerId
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_customerId")); }
        }

        protected IWebElement LblCustomerInfoCustomerNumber
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_customerNumber")); }
        }

        protected IWebElement LblCustomerInfoCompanyName
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_companyName")); }
        }

        protected IWebElement LblCustomerInfoCompanyNumber
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_companyNumber")); }
        }

        protected IWebElement LblCustomerInfoCustomerClass
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_customerClass")); }
        }

        protected IWebElement LblCustomerInfoParentReference
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_parentReference")); }
        }

        protected IWebElement LblCustomerInfoChannel
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_channel")); }
        }

        protected IWebElement LblCustomerInfoContactCfoLanguage
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_contactCFOLang")); }
        }

        protected IWebElement LblCustomerInfoCustomerStatus
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_customerStatus")); }
        }

        protected IWebElement LblCustomerInfoLegacyFreeShipping
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_chargeShippingPrice")); }
        }

        protected IWebElement LblPrimaryContactName
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_primaryContactName")); }
        }

        protected IWebElement LblPrimaryContactDepartment
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_department")); }
        }

        protected IWebElement LblPrimaryContactEmail
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_email")); }
        }

        protected IWebElement LblPrimaryContactTelephone
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_telephone")); }
        }

        protected IWebElement LblBillToAddressAddress1
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_address1")); }
        }

        protected IWebElement LblBillToAddressAddress2
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_address2")); }
        }

        protected IWebElement LblBillToAddressCity
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_city")); }
        }

        protected IWebElement LblBillToAddressState
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_state")); }
        }

        protected IWebElement LblBillToAddressPostalCode
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_zip")); }
        }

        protected IWebElement LblBillToAddressCountry
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_primaryContactCountry")); }
        }

        public IWebElement LnkFinancialInformationHeader
        {
            get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Bill to Customer Financial Information')]")); }
        }

        public IWebElement DdlFinancialInfoPaymentMethod
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_financingPaymentMethod")); }
        }

        public IWebElement LblFinancialInfoPaymentTerms
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_paymentTerm")); }
        }

        protected IWebElement LblFinancialInfoCurrency
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_currency")); }
        }

        protected IWebElement LblFinancialInfoDiscount
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_discount")); }
        }

        protected IWebElement LblFinancialInfoFederalTaxId
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_federalTaxId")); }
        }

        protected IWebElement ChkFinancialInfoTaxExemptOverride
        {
            get { return WebDriver.GetElement(By.XPath("id('" + lineItemPagePrefix + "_financialInformation')/div[1]/div[1]/div[1]/div[6]/div[1]/input[1]")); }
        }

        protected IWebElement LblFinancialInfoDiscountEntitlements
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_discountEntitlements")); }
        }

        protected IWebElement LblFinancialInfoPromotionCode
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_promotionCode")); }
        }

        protected IWebElement LblFinancialInfoCustomerHold
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_customerHold")); }
        }

        protected IWebElement LblFinancialInfoCreditHold
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_creditHold")); }
        }

        protected IWebElement LblFinancialInfoCreditLimit
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_CreditLimit")); }
        }

        protected IWebElement LblFinancialInfoRemainingBalance
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_RemainingBalance")); }
        }

        protected IWebElement LblFinancialInfoPrimarySalesRep
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_salesRep")); }
        }

        public IWebElement LnkAddTagSalesRep
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_tagRepAdd")); }
        }

        public IWebElement TextTagSalesRepNum(int tagSalesRepNum)
        {

            return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_tagRep_" + tagSalesRepNum));

        }


        public IWebElement ShippingGroupInfo(int? groupIndex = 0)
        {
           return WebDriver.GetElements(By.XPath("//div//span[contains(text(), 'Shipping Group Information')]"))[(int)groupIndex];
        }


        public IWebElement ExpandTagSalesRep
        {
            get { return WebDriver.GetElement(By.XPath("//label[contains(text(), 'Tag Sales Rep')]")); }
        }
        public IWebElement AddTagSalesRep
        {
            get { return WebDriver.FindElement(By.Id(lineItemPagePrefix + "_tagRepNew")); }
        }
        public IWebElement LnkFinancialInfoRemovePrimarySalesRep
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_primaryRepAdd"), TimeSpan.FromSeconds(5)); }
        }

        public IWebElement LnkFinancialInfoRemoveTagSalesRep(int tagSalesRepNum)
        {
            return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_deleteTagSalesRep_" + tagSalesRepNum), TimeSpan.FromSeconds(5)); 
        }
        public IWebElement QuoteDetailsPrimarySalesRepAdd
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_primaryRepAdd"), TimeSpan.FromSeconds(5)); }
        }

        public IWebElement LnkCustomFieldsHeader
        {
            get { return WebDriver.GetElement(By.XPath("//*[contains(text(), 'Checkout Fields')]")); }
        }

        protected IWebElement TxtFinancialInfoPrimarySalesRep
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "_salesRepNew")); }
        }

        #endregion
    }
}
