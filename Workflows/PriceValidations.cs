using System;
using Dsa.DataModels;

namespace Dsa.Workflows
{
    public class PriceValidations
    {
        #region CreateQuotePriceValidations

        public static bool ValidateItemPriceWithQuantity(ItemQuoteData itemData, ItemQuoteData itemDataWithQuantity)
        {
            bool validate;
            var listPriceWithQty = Convert.ToDouble(itemData.ListPrice) * itemData.Quantity;
            var discountWithQty = Convert.ToDouble(itemData.Discount) * itemData.Quantity;
            var sellingPriceWithQty = Convert.ToDouble(itemData.SellingPrice) * itemData.Quantity;
            var mrgValue = itemData.MarginValue;
            var mrgValueWithQty = mrgValue * itemData.Quantity;


            if (Math.Abs(listPriceWithQty - Convert.ToDouble(itemDataWithQuantity.ListPrice)) < 0.05 &&
                Math.Abs(discountWithQty - Convert.ToDouble(itemDataWithQuantity.Discount)) < 0.05
                && Math.Abs(sellingPriceWithQty - Convert.ToDouble(itemDataWithQuantity.SellingPrice)) < 0.05 &&
                Math.Abs(mrgValueWithQty - itemDataWithQuantity.MarginValue) < 0.05 &&
                Math.Abs(itemData.DiscountOffList - itemDataWithQuantity.DiscountOffList) < 0.05)
            {
                validate = true;
            }
            else
            {
                validate = false;
            }

            return validate;
        }

        public static bool ValidateItemPriceWithTiedSku(ItemQuoteData itemData, ItemQuoteData itemDataWithTied, double tiedSkuPrice)
        {
            bool validate;
            var listPriceWithTied = Convert.ToDouble(itemData.ListPrice) + tiedSkuPrice;
            var discountWithTied = Convert.ToDouble(itemData.Discount) + tiedSkuPrice;
            var sellingPriceWithTied = Convert.ToDouble(itemData.SellingPrice) + tiedSkuPrice;

            if (Math.Abs(listPriceWithTied - Convert.ToDouble(itemDataWithTied.ListPrice)) < 0.05 &&
                Math.Abs(discountWithTied - Convert.ToDouble(itemDataWithTied.Discount)) < 0.05
                && Math.Abs(sellingPriceWithTied - Convert.ToDouble(itemDataWithTied.SellingPrice)) < 0.05)
               
            {
                validate = true;
            }
            else
            {
                validate = false;
            }

            return validate;
        }

        public static bool ValidateItemSummaryWithNonTiedAndNestedNonTied(ItemQuoteData itemDataWithQuantity, ItemQuoteData nonTiedItemWithQuantity, ItemSummaryValues itemSummary)
        {
            bool validate;
            var sellingPriceWithNonTied = Convert.ToDouble(itemDataWithQuantity.SellingPrice) + Convert.ToDouble(nonTiedItemWithQuantity.SellingPrice);

            if (Math.Abs(sellingPriceWithNonTied - Convert.ToDouble(itemSummary.TotalSellingPrice)) < 0.05)
            {
                validate = true;
            }
            else
            {
                validate = false;
            }

            return validate;
        }
        public static bool ValidateShipSummaryWithTwoItems(ItemSummaryValues itemSummary, ItemSummaryValues item2Summary, ShippingGroupSummary groupSummary)
        {
            bool validate;

            if (Math.Abs(itemSummary.TotalSellingPrice + item2Summary.TotalSellingPrice - groupSummary.SubTotal) < 0.05 &&
                groupSummary.TotalShipping < 0.02 ?
                (Math.Abs(itemSummary.TotalTax + item2Summary.TotalTax - groupSummary.TotalTax) < 0.02) && 
                (Math.Abs(itemSummary.TotalAmount + item2Summary.TotalAmount - groupSummary.TotalAmount) < 0.02) :
                (Math.Abs(itemSummary.TotalTax + item2Summary.TotalTax - groupSummary.TotalTax) > 0.05) && 
                (Math.Abs(itemSummary.TotalAmount + item2Summary.TotalAmount- groupSummary.TotalAmount) > 0.05) &&
               (Math.Abs(itemSummary.TotalEcoFee + item2Summary.TotalEcoFee - groupSummary.TotalEcoFee) < 0.05)
            )
            {
                validate = true;
            }
            else
            {
                validate = false;
            }

            return validate;
        }

        public static bool ValidateItemAndShippingSummaryValues(ItemSummaryValues itemSummary, ShippingGroupSummary groupSummary)
        {
            bool validate;

            if (Math.Abs(itemSummary.TotalSellingPrice - groupSummary.SubTotal) < 0.05 &&
                groupSummary.TotalShipping < 0.02 ?
                (Math.Abs(itemSummary.TotalTax - groupSummary.TotalTax) < 0.02) && (Math.Abs(itemSummary.TotalAmount - groupSummary.TotalAmount) < 0.02) :
                (Math.Abs(itemSummary.TotalTax - groupSummary.TotalTax) > 0.05) && (Math.Abs(itemSummary.TotalAmount - groupSummary.TotalAmount) > 0.05) &&
               (Math.Abs(itemSummary.TotalEcoFee - groupSummary.TotalEcoFee) < 0.05)
            )
            {
                validate = true;
            }
            else
            {
                validate = false;
            }

            return validate;
        }

        public static bool ValidateQuoteSummaryValues(ShippingGroupSummary groupSummary, QuoteSummaryValues quoteSummary)
        {
            bool validate;

            if (Math.Abs(quoteSummary.Subtotal - groupSummary.SubTotal) < 0.05 &&
                Math.Abs(quoteSummary.TotalShipping - groupSummary.TotalShipping) < 0.05 &&
                Math.Abs(quoteSummary.TotalTax - groupSummary.TotalTax) < 0.05 &&
                Math.Abs(quoteSummary.TotalEcoFee - groupSummary.TotalEcoFee) < 0.05 &&
                Math.Abs(quoteSummary.FinalPrice - groupSummary.TotalAmount) < 0.05
               )
            {
                validate = true;
            }
            else
            {
                validate = false;
            }

            return validate;
        }

        #endregion

        #region QuoteDetailsPriceValidation
        public static bool ValidateItemPricesBetweenQuoteAndOrder(ItemQuoteData itemDataInCreateQuote, ItemQuoteData itemDataInQuotedetails)
        {
            bool validate;

            if (Math.Abs(Convert.ToDouble(itemDataInCreateQuote.ListPrice) - Convert.ToDouble(itemDataInQuotedetails.ListPrice)) < 0.05 &&
                Math.Abs(Convert.ToDouble(itemDataInCreateQuote.Discount) - Convert.ToDouble(itemDataInQuotedetails.Discount)) < 0.05
                && Math.Abs(Convert.ToDouble(itemDataInCreateQuote.SellingPrice) - Convert.ToDouble(itemDataInQuotedetails.SellingPrice)) < 0.05 &&
                Math.Abs(itemDataInCreateQuote.MarginValue - itemDataInQuotedetails.MarginValue) < 0.05 )
                //&&
                //Math.Abs(itemDataInCreateQuote.DiscountOffList - itemDataInQuotedetails.DiscountOffList) < 0.05) 
            {
                validate = true;
            }
            else
            {
                validate = false;
            }

            return validate;
        }



        public static bool ValidateItemSummaryInQuoteDetails(ItemSummaryValues itemSummaryInCreateQuote, ItemSummaryValues itemSummaryInQuotedetails)
        {
            bool validate;

            if (Math.Abs(itemSummaryInCreateQuote.TotalSellingPrice - itemSummaryInQuotedetails.TotalSellingPrice) < 0.05 &&
                Math.Abs(itemSummaryInCreateQuote.TotalTax - itemSummaryInQuotedetails.TotalTax) < 0.05 &&
                Math.Abs(itemSummaryInCreateQuote.TotalEcoFee - itemSummaryInQuotedetails.TotalEcoFee) < 0.05 &&
                Math.Abs(itemSummaryInCreateQuote.TotalAmount - itemSummaryInQuotedetails.TotalAmount) < 0.05
               )
            {
                validate = true;
            }
            else
            {
                validate = false;
            }

            return validate;
        }

        public static bool ValidateGroupSummaryInQuoteDetails(ShippingGroupSummary groupSummaryInCreateQuote, ShippingGroupSummary groupSummaryInQuotedetails)
        {
            bool validate;

            if (Math.Abs(groupSummaryInCreateQuote.SubTotal - groupSummaryInQuotedetails.SubTotal) < 0.05 &&
                Math.Abs(groupSummaryInCreateQuote.TotalShipping - groupSummaryInQuotedetails.TotalShipping) < 0.05 &&
                Math.Abs(groupSummaryInCreateQuote.TotalTax - groupSummaryInQuotedetails.TotalTax) < 0.05 &&
                Math.Abs(groupSummaryInCreateQuote.TotalEcoFee - groupSummaryInQuotedetails.TotalEcoFee) < 0.05 &&
                Math.Abs(groupSummaryInCreateQuote.TotalAmount - groupSummaryInQuotedetails.TotalAmount) < 0.05
               )
            {
                validate = true;
            }
            else
            {
                validate = false;
            }

            return validate;
        }

        public static bool ValidateFinalSummary(QuoteSummaryValues summaryInCreateQuote, QuoteSummaryValues summaryInQuotedetails)
        {
            bool validate;

            if (Math.Abs(summaryInCreateQuote.Subtotal - summaryInQuotedetails.Subtotal) < 0.05 &&
                Math.Abs(summaryInCreateQuote.TotalShipping - summaryInQuotedetails.TotalShipping) < 0.05 &&
                Math.Abs(summaryInCreateQuote.TotalTax - summaryInQuotedetails.TotalTax) < 0.05 &&
                Math.Abs(summaryInCreateQuote.TotalEcoFee - summaryInQuotedetails.TotalEcoFee) < 0.05 &&
                Math.Abs(summaryInCreateQuote.FinalPrice - summaryInQuotedetails.FinalPrice) < 0.05
               )
            {
                validate = true;
            }
            else
            {
                validate = false;
            }

            return validate;
        }

        #endregion

        public static bool ValidateShippingSummaryBetweenPages(ShippingGroupSummary groupSummaryPage1, ShippingGroupSummary groupSummaryPage2)
        {
            bool validate;

            if (Math.Abs(groupSummaryPage1.SubTotal - groupSummaryPage2.SubTotal) < 0.05 &&
                (Math.Abs(groupSummaryPage1.TotalTax - groupSummaryPage2.TotalTax) < 0.02) &&
                (Math.Abs(groupSummaryPage1.TotalEcoFee - groupSummaryPage2.TotalEcoFee) < 0.05) &&
                (Math.Abs(groupSummaryPage1.TotalShipping - groupSummaryPage2.TotalShipping) < 0.05) &&
                (Math.Abs(groupSummaryPage1.TotalAmount - groupSummaryPage2.TotalAmount) < 0.02)  
               )
            {
                validate = true;
            }
            else
            {
                validate = false;
            }

            return validate;
        }
    }
}
