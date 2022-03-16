
namespace Dsa.Constants
{
    public class SplitLineItemConstants
    {
        public const string SplitLineItemHeader = "#body-content > div.content-shell > div > div.view-nav.ng-scope > div > div > table > tbody > tr > td:nth-child(1) > h2";
        public const string SplitType = "splitLineItem_SplitType";
        public const string Quantity = "splitLineItem_quantity";
        public const string ShippingAddressType = "splitLineItem_shipping AddressType";
        public const string ShippingMethodType = "splitLineItem_shippingMethodType";
        public const string NewLines = "#main > div > div.info-wrap > div.mg-btm-10 > table > tbody > tr > td:nth-child(5) > input";
        public const string ApplyToPreview = "splitLineItem_applyToPreview";
        public const string RemoveOriginalader = "splitLineItem_removeOriginal";
        public const string ItemInfo = "splitLineItem_item_info";
        public const string PreviewList = "_splititem_preview_list";
        public const string TotalPrice = "#_splititem_preview_list > div > table > tfoot > tr";
        public const string Close = "splitlineitem_cancel";
        public const string AddressModal = "#COM > div.modal-small.ng-scope";
        public const string AddressReview = "//*[@id=\"COM\"]/div[4]/div/div[3]/button[1]";
        public const string AddressFinished = "//*[@id=\"COM\"]/div[4]/div/div[3]/button[1]";
        public static readonly string AddressCheckbox = "input[data-ng-model=\"model.addressSelection[\"";
        public static readonly string NewlyAddedItemQuantity = "#_line_item_quantity_{0}";
        public static readonly string NewlyAddedItemShippingMethod = "#_shippingMethod_{0}";
        public static readonly string NewlyAddedAddressSecondLineEdit = "id('_splititem_preview_list')/div[@class='c-data-grid ng-scope']/table[1]/tbody[1]/tr[@class='ng-scope even']/td[@class='ng-binding']/a[@id='splitLineItem_edit']";

        public static readonly string SaveButtonModal =
            "id('COM')/div[@class='modal-small ng-scope']/div[@class='modal-wrap ln-itm-split']/div[5]/div[@class='button-bar']/button[@class='btn btn-success']";
        public static readonly string EvenAddressRadioButton =
            "tr.ng-scope.even > td.no-sort > span > input[name=\"addressSelect\"]";

        public static readonly string OddAddressRadioButton =
            "tr.ng-scope.odd > td.no-sort > span > input[name=\"addressSelect\"]";
        
        public static readonly string AddressRow = "//*[@id=\"DataTables_Table_5\"]/tbody/tr[{0}]/td[1]/span/input";
        public const string PickAddresses =
            "#main > div > div.info-wrap > div.mg-btm-10 > table > tbody > tr > td:nth-child(3) > div > a";
    }
}
