using System;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Dsa.DataModels;

namespace Dsa.Pages.Quote
{
    public class QuoteSummary : DsaPageBase
    {
        static string lineItemPagePrefix;

        public QuoteSummary(IWebDriver webDriver, string pagePrefix)
            : base(webDriver)
        {
            if (!string.IsNullOrEmpty(pagePrefix))
            {
                lineItemPagePrefix = pagePrefix + "_";
            }
            else
            {
                lineItemPagePrefix = pagePrefix;
            }

            PageFactory.InitElements(webDriver, this);
            webDriver.VerifyBusyOverlayNotDisplayed();
        }

        #region QuoteSummaryElements

        public IWebElement ByLblSummaryListPrice
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "summary_listPrice")); }
        }

        public IWebElement ByLblSummarySellingPrice
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "summary_sellingPrice")); }
        }

        public IWebElement ByLblSummaryDiscount
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "summary_discountPercent")); }
        }

        public IWebElement ByLblSummaryMargin
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "summary_marginValue")); }
        }

        public IWebElement ByLblSummaryShippingPrice
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "summary_shippingPriceAmount")); }
        }

        public IWebElement ByLblSummaryShippingDiscount
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "summary_shippingDiscountAmount")); }
        }

        public IWebElement ByLblSummaryShippingOrderDiscount
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "summary_shippingDiscount")); }
        }

        public IWebElement ByLblSummarySmartpriceRevenue
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "summary_compRevenue")); }
        }

        public IWebElement ByLblSummarySubTotal
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "summary_subtotalAmount")); }
        }

        public IWebElement ByLblSummaryTotalShipping
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "summary_shippingAmount")); }
        }

        public IWebElement ByLblSummaryTotalTax
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "summary_totalTaxAmount")); }
            
        }

        public IWebElement ByLblSummaryTotalEcoFee
        {
            get { return WebDriver.GetElement(By.Id(lineItemPagePrefix + "summary_totalEhfAmount")); }
        }

        public IWebElement LblSummaryFinalPrice
        {
            get
            {
                var element = WebDriver.GetElement(By.XPath(".//*[@id='GMOR_terms_of_sale_anchor']/div[4]/span[2]"));
                if (!element.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(30)))
                    return WebDriver.GetElement(By.Id(lineItemPagePrefix + "summary_finalPrice"));
                return element;
            }
        }

        public IWebElement LblSplitQuoteSummaryTotalShipping
        {
            get { return WebDriver.GetElement(By.Id("quoteCreate_summary_shippingAmount")); }
        }

        #endregion

        public QuoteSummaryValues GetQuoteSummaryValues(bool isSmartPriceEnabled = false)
        {
            var values = new QuoteSummaryValues();
            Logger.Write("Getting Values Of Summary of Quote " );
            Logger.Write("-------------------------");

            //values.Add("ListPrice", ByLblSummaryListPrice.GetText(WebDriver));
            //values.Add("SellingPrice", LblSummarySellingPrice.GetText(WebDriver));
            //values.Add("Discount", LblSummaryDiscount.GetText(WebDriver));
            values.ListPrice = ByLblSummaryListPrice.GetText(WebDriver);
            values.SellingPrice = ByLblSummarySellingPrice.GetText(WebDriver);

            string discount = ByLblSummaryDiscount.GetText(WebDriver);
            values.Discount = ByLblSummaryDiscount.GetText(WebDriver).Substring(1, discount.IndexOf('/')-1).Trim();
            values.DiscountPercentage = ByLblSummaryDiscount.GetText(WebDriver).Substring(discount.IndexOf('/')+1).Trim();

            //values.Discount = ByLblSummaryDiscount.GetText(WebDriver);

            string margin = ByLblSummaryMargin.GetText(WebDriver);
            values.TotalMargin = ByLblSummaryMargin.GetText(WebDriver).Substring(2, margin.IndexOf('/') - 3).Trim();
            if (isSmartPriceEnabled)
                values.SmartpriceRevenue = ByLblSummarySmartpriceRevenue.GetText(WebDriver);
            values.ShippingPrice = ByLblSummaryShippingPrice.GetText(WebDriver);
            values.ShippingDiscount = ByLblSummaryShippingDiscount.GetText(WebDriver);
            values.Subtotal =Convert.ToDouble(ByLblSummarySubTotal.GetText(WebDriver).Substring(1));
            values.TotalShipping = Convert.ToDouble(ByLblSummaryTotalShipping.GetText(WebDriver).Substring(1));
            values.TotalTax = Convert.ToDouble(ByLblSummaryTotalTax.GetText(WebDriver).Substring(1));
            values.TotalEcoFee = Convert.ToDouble(ByLblSummaryTotalEcoFee.GetText(WebDriver).Substring(1));
            values.FinalPrice = Convert.ToDouble(LblSummaryFinalPrice.GetText(WebDriver).Substring(5));

            return values;
        }


        public QuoteSummaryValues GetOrderSummaryValues(bool isSmartPriceEnabled = false)
        {
            var values = new QuoteSummaryValues();
            Logger.Write("Getting Values Of Summary of Quote ");
            Logger.Write("-------------------------");

            //values.Add("ListPrice", ByLblSummaryListPrice.GetText(WebDriver));
            //values.Add("SellingPrice", LblSummarySellingPrice.GetText(WebDriver));
            //values.Add("Discount", LblSummaryDiscount.GetText(WebDriver));
            values.ListPrice = ByLblSummaryListPrice.GetText(WebDriver);
            values.SellingPrice = ByLblSummarySellingPrice.GetText(WebDriver);
            values.Discount = ByLblSummaryDiscount.GetText(WebDriver);
            values.TotalMargin = ByLblSummaryMargin.GetText(WebDriver);
            if (isSmartPriceEnabled)
                values.SmartpriceRevenue = ByLblSummarySmartpriceRevenue.GetText(WebDriver);
            values.ShippingPrice = ByLblSummaryShippingPrice.GetText(WebDriver);
            values.ShippingDiscount = ByLblSummaryShippingOrderDiscount.GetText(WebDriver);
            values.Subtotal = Convert.ToDouble(ByLblSummarySubTotal.GetText(WebDriver).Substring(1));
            values.TotalShipping = Convert.ToDouble(ByLblSummaryTotalShipping.GetText(WebDriver).Substring(1));
            values.TotalTax = Convert.ToDouble(ByLblSummaryTotalTax.GetText(WebDriver).Substring(1));
            values.TotalEcoFee = Convert.ToDouble(ByLblSummaryTotalEcoFee.GetText(WebDriver).Substring(1));
            values.FinalPrice = Convert.ToDouble(LblSummaryFinalPrice.GetText(WebDriver).Substring(5));

            return values;
        }

        public string GetQuoteSummaryTotalMargin()
        {
            if (WebDriver.TryFindElement(ByLblSummaryMargin, TimeSpan.FromSeconds(5)))
                return ByLblSummaryMargin.GetText(WebDriver);
            else
                return string.Empty;
        }

        private static string ReplaceSpecialCharForCurrency(string value)
        {
            return value.Replace("$", string.Empty)
                .Replace(",", string.Empty)
                .Replace("(", string.Empty)
                .Replace(")", string.Empty)
                .Replace("%", string.Empty);
        }
    }
}
