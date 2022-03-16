using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa.DataModels
{
    public class OrderChecklist
    {

        public string QuoteNumber { get; set; }
        public string OriginalQuoteNumber { get; set; }
        public string PoNumber { get; set; }
        public string POMNumber { get; set; }
        public string CompanyNumber { get; set; }
        public string CompanyName { get; set; }
        public string TagSalesRep { get; set; }
        public string CustomerNumber { get; set; }
        public string EndCustomerNumber { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentTerms { get; set; }
        public string PrimarySalesRep { get; set; }
        public string Margin { get; set; }
        public string QuoteExpiration { get; set; }
        public string ShippingInstruction { get; set; }
        public string ShippingMethod { get; set; }
        public string MustArriveDate { get; set; }
        public string TotalCost { get; set; }
        public string BillingCompanyName { get; set; }
        public string BillingAddress { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingContactName { get; set; }
        public string ShippingContactEmail { get; set; }
        public string ShippingContactPhone { get; set; }
        public string SalesRepEmail { get; set; }
        public string SalesRepPhone { get; set; }
        public string InstallationInstructions { get; set; }

    }
}
