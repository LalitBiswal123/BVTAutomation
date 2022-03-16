using Dsa.Enums;

namespace Dsa.DataModels
{
    public class ItemQuoteData
    {
        public string ContractCode { get; set; }
        public string TaxAmount { get; set; }

        public double TaxAmountDouble { get; set; }
        public string TotalShipping { get; set; }
        public string ShippingDiscount { get; set; }
        public double TotalShippingDouble { get; set;}
        public int Quantity { get; set; }
        public string FinalPrice { get; set; }

        public double FinalPriceDouble { get; set;}
        public string SellingPrice { get; set; }
        public double Discount { get; set; }
        public string SellingPriceDouble { get; set; }
        public string SmartPriceRevenue { get; set; }
        public string ContractDiscount { get; set; }
        public string Promotions { get; set; }
        public double PromoValue { get; set; }
        public double PromoPert { get; set; }
        public double DiscountOffList { get; set; }
        public string GoalDealId { get; set; }
        public string ListPrice { get; set; }
        public string Margin { get; set; }
        public double MarginValue { get; set; }
        public double MarginPert { get; set; }

        public string EcoFee { get; set; }
        public string QuoteNumber { get; set; }

        public string Edd { get; set; }

        public string ProductDescription { get; set; }

        public SplitLineValidation ValidationType { get; set; }

        public string Address { get; set; }

        public string SkuNumber { get; set; }
        public string OrderCode { get; set; }

        public double SupportServiceListPrice { get; set; }
        public double HardwareOsListPrice { get; set; }
        public double SupportServiceSellingPrice { get; set; }
        public double HardwareOsSellingPrice { get; set; }

    }
}
