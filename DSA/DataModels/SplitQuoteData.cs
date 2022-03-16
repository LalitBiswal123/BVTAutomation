using System.Collections.Generic;

namespace Dsa.DataModels
{
    public class SplitQuoteData
    {
        public int numberOfQuotesSplit { get; set; }

        public List<QuoteData> QuotesInSplit;
        public SplitQuoteData()
        {
            QuotesInSplit = new List<QuoteData>();
            numberOfQuotesSplit = 0;
        }
    }
}
