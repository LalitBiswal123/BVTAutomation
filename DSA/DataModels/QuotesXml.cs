using System;
using System.Xml.Serialization;

namespace Dsa.DataModels
{
    [Serializable]
    public class QuotesXml
    {
            [XmlArrayItem("Quote", typeof(Quote), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            [XmlArray("QuotesList", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Quote[] Quotes{get; set; }
            
    }

    public class Quote
    {
        public string Environment { get; set; }
        public string QuoteNumber { get; set; }
        public string Timestamp { get; set; }

    }


}
