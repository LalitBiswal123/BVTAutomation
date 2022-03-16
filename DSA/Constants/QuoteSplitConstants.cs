namespace Dsa.Constants
{
    public class QuoteSplitConstants
    {
        public const string SplitQuoteHeader = "//*[@class='modal-wrap ln-itm-split']/div/div/h3";
        public const string ItemRb = "//input[@type='radio' and @id='0']";
        public const string EstimatedDeliveryDateRb = "//input[@type='radio' and @id='1']";
        public const string QuantityRb = "//input[@type='radio' and @id='2']";
        public const string ShippingLocationRb = "//input[@type='radio' and @id='3']";
        public const string ShippingMethodRb = "//input[@type='radio' and @id='4']";

        public const string ReviewQuotes = "#COM > div.modal-small.ng-scope > div > div.button-bar > button.btn.btn-primary";
        
        public const string Cancel = "#COM > div.modal-small.ng-scope > div > div.button-bar > button.button";

        public const string CloseSplitScreen = "//*[@class='modal-wrap ln-itm-split']/div/a/span";
    }
}
