namespace Dsa.DataModels
{
    public class ShippingGroupSummary
    {
        public double SubTotal { get; set; }
        public double TotalShipping { get; set; }
        public double TotalTax { get; set; }
        public double TotalEcoFee { get; set; }
        public double TotalAmount { get; set; }
    }
}
