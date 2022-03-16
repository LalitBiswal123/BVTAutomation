namespace Dsa.DataModels
{
    public class QuoteSummaryValues
    {
        public string ListPrice { get; set; }
        public string SellingPrice { get; set; }
        public string Discount { get; set; }
        public string DiscountPercentage { get; set; }
        public string TotalMargin { get; set; }
        public string ShippingPrice { get; set; }
        public string ShippingDiscount { get; set; }
        public string SmartpriceRevenue { get; set; }
        public double Subtotal { get; set; }
        public double TotalShipping { get; set; }
        public double TotalTax { get; set; }
        public double TotalEcoFee { get; set; }
        public double FinalPrice { get; set; }
    }
}
