namespace Dsa.DataModels
{
    /// <summary>
    /// New customer data model class.
    /// </summary>
    public class NewCustomer
    {
        /// <summary>
        /// Gets or sets the business unit.
        /// </summary>
        /// <value>
        /// The business unit.
        /// </value>
        public string BusinessUnit { get; set; }

        /// <summary>
        /// Gets or sets the company number.
        /// </summary>
        /// <value>
        /// The company number.
        /// </value>
        public string CompanyNumber { get; set; }

        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        /// <value>
        /// The name of the company.
        /// </value>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the customer class.
        /// </summary>
        /// <value>
        /// The customer class.
        /// </value>
        public string CustomerClass { get; set; }

        /// <summary>
        /// Gets or sets the parent reference.
        /// </summary>
        /// <value>
        /// The parent reference.
        /// </value>
        public string ParentReference { get; set; }

        /// <summary>
        /// Gets or sets the billing information.
        /// </summary>
        /// <value>
        /// The billing information.
        /// </value>
        public Address BillingInformation { get; set; }

        public string CompanyPhone { get; set; }

        public string CompanyFax { get; set; }


        /// <summary>
        /// Gets or sets the shipping address.
        /// </summary>
        /// <value>
        /// The shipping address.
        /// </value>
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [shipping address same as billing address].
        /// </summary>
        /// <value>
        /// <c>true</c> if [shipping address same as billing address]; otherwise, <c>false</c>.
        /// </value>
        public bool ShippingAddressSameAsBillingAddress { get; set; }

        public bool MailingAddressSameAsBillingAddress { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the primary sales rep Id.
        /// </summary>
        /// <value>
        /// The primary sales rep identifier.
        /// </value>
        public string PrimarySalesRepId { get; set; }

        /// <summary>
        /// Gets or sets the note.
        /// </summary>
        /// <value>
        /// The note.
        /// </value>
        public string Note { get; set; }

        public FinancialPrefrences FinancialPrefrences { get; set; }
    }
}
