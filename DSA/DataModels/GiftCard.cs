namespace Dsa.DataModels
{
    public class GiftCard
    {
        public string Amount { get; set; }
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public string Cid { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public static GiftCard GetTestCard()
        {
            return new GiftCard()
            {
                NameOnCard = "Mark Wilson",
                CardNumber = "0000000000000000",
                Cid = "0000"
            };
        }
    }
}
