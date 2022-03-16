
namespace Dsa.Constants
{
    public class SendQuotePageConstants
    {
        public const string ViaEmail = "quoteSendCfo_viaEmail";
        public const string ViaFax = "quoteSendCfo_viaFax";
        public const string EmailAddress = "quoteSendCfo_emailAddress";
        public const string CcAddress = "quoteSendCfo_ccAddress";
        public const string IncludeMeAsRecipient = "quoteSendCfo_addloggedProfileEmail";
        
        public const string Language = "quoteSendCfo_language_options";
        public const string Format = "quoteSendCfo_format_option";
        public const string SkuNumberDisplay = "quoteSendCfo_skuNumberDisplay_options";
        public const string Subject = "quoteSendCfo_subject";
        public const string Comments = "quoteSendCfo_comments";

        public const string SendQuote = "quoteSendCfo_sendQuote";
        public const string PreviewQuote = "quoteSendCfo_previewQuote";
        public const string Cancel = "quoteSendCfo_cancelSend";
        
        public const string SendCfoHeaderAfterSent = "//*[@id='main']/div/h3";
        public const string SendCfoNextSteps = "//*[@class='next-steps']";
        public const string SelectOutputType = "cfoHistory_outputType";
        public const string SelectDateRange = "cfoHistory_dateRange";
        public const string OutputResultTable = "//*[@id='cfo_historyGrid']/div/table";
        public const string CfoResultGrid = "cfoResultGrid";
    }
}
