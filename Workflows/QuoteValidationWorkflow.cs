using Dsa.DataModels;
using FluentAssertions;

namespace Dsa.Workflows
{
    public class QuoteValidationWorkflow
    {
        #region Validate Quote Data
        public static void ValidateQuoteData(ItemQuoteData originalQuoteData, ItemQuoteData comparisonQuoteData)
        {
           originalQuoteData.Quantity.ShouldBeEquivalentTo(comparisonQuoteData.Quantity);
           originalQuoteData.SellingPrice.ShouldBeEquivalentTo(comparisonQuoteData.SellingPrice);
           originalQuoteData.EcoFee.ShouldBeEquivalentTo(comparisonQuoteData.EcoFee);
           originalQuoteData.TaxAmountDouble.Should()
                .BeInRange(comparisonQuoteData.TaxAmountDouble * .95, comparisonQuoteData.TaxAmountDouble * 1.05);
           originalQuoteData.TotalShippingDouble.Should()
                .BeInRange(comparisonQuoteData.TotalShippingDouble * .95, comparisonQuoteData.TotalShippingDouble * 1.05);
           originalQuoteData.FinalPriceDouble.Should()
                .BeInRange(comparisonQuoteData.FinalPriceDouble * .95, comparisonQuoteData.FinalPriceDouble * 1.05);
        }

        #endregion
    }
}
