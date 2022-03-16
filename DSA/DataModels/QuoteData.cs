using System.Collections.Generic;

namespace Dsa.DataModels
{
    public class QuoteData
    {

        public ItemQuoteData Summary { get; set; }
        public string TestCaseName { get; set; }


        public int numberOfItemsInQuote { get; set; }

        public List<Dictionary<string, ItemQuoteData>> LineItemsInQuote;

        public QuoteData()
        {
            LineItemsInQuote = new List<Dictionary<string, ItemQuoteData>>();
            numberOfItemsInQuote = 0;
            
        }



    }
}
