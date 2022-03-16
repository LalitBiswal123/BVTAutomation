using Dsa.DataModels;
using FluentAssertions;

namespace Dsa.Workflows
{
    public class QuoteValidationWorkflow
    {
        #region Validate Quote Data
        public static void ValidateQuoteData(ItemQuoteData originalQuoteData, ItemQuoteData comparisonQuoteData)
        {
           originalQuoteData.Quantity.Should().Be(comparisonQuoteData.Quantity);
           originalQuoteData.SellingPrice.Should().Be(comparisonQuoteData.SellingPrice);
           originalQuoteData.EcoFee.Should().Be(comparisonQuoteData.EcoFee);
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
