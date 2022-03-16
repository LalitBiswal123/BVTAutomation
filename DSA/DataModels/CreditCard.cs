using System;
using Dell.Adept.Testing.DataGenerators.Primitive;

namespace Dsa.DataModels
{
    public class CreditCard
    {
        /// <summary>
        /// Gets or sets the type of the card.
        /// </summary>
        /// <value>
        /// The type of the card.
        /// </value>
        public string CardType { get; set; }

        /// <summary>
        /// Gets or sets the name on card.
        /// </summary>
        /// <value>
        /// The name on card.
        /// </value>
        public string NameOnCard { get; set; }

        /// <summary>
        /// Gets or sets the credit card number.
        /// </summary>
        /// <value>
        /// The credit card number.
        /// </value>
        public string CreditCardNumber { get; set; }

        /// <summary>
        /// Gets or sets the expiration month.
        /// </summary>
        /// <value>
        /// The expiration month.
        /// </value>
        public string ExpirationMonth { get; set; }

        /// <summary>
        /// Gets or sets the expiration year.
        /// </summary>
        /// <value>
        /// The expiration year.
        /// </value>
        public string ExpirationYear { get; set; }

        /// <summary>
        /// Gets or sets the cid.
        /// </summary>
        /// <value>
        /// The cid.
        /// </value>
        public string Cid { get; set; }

        /// <summary>
        /// Gets or sets the address1.
        /// </summary>
        /// <value>
        /// The address1.
        /// </value>
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the address2.
        /// </summary>
        /// <value>
        /// The address2.
        /// </value>
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the zip code.
        /// </summary>
        /// <value>
        /// The zip code.
        /// </value>
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public string Amount { get; set; }

        /// <summary>
        /// Gets or sets the Customer Reference Number.
        /// </summary>
        /// <value>
        /// The Customer Reference Number.
        /// </value>
        public string CustomerReferenceNumber { get; set; }
       
        /// <summary>
        /// Gets or sets the Charge Description.
        /// </summary>
        /// <value>
        /// The Charge Description.
        /// </value>
        public string ChargeDescription { get; set; }

        public static CreditCard GetTestCard()
        {
            return new CreditCard()
            {
                NameOnCard = "Test CreditCard",
                CreditCardNumber = "0000000000000000",
                ExpirationMonth = Generator.RandomInt(1, 12).ToString("00"),
                ExpirationYear = Convert.ToString(DateTime.Now.Year + Generator.RandomInt(1, 5)),
                Cid = "101",
                Address1 = "1 Dell Way",
                Address2 = "",
                City = "Round Rock",
                State = "TX",
                ZipCode = "78682-7000",
                PhoneNumber = "1234567890",
                CustomerReferenceNumber = "123456"
            };
        }
    }
}
