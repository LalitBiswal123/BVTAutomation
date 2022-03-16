using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Quote
{
    public class SplitLineItemPage : DsaPageBase
    {
        public SplitLineItemPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement HdrSplitLineItem { get { return WebDriver.GetElement(By.CssSelector("#body-content > div.content-shell > div > div.view-nav.ng-scope > div > div > table > tbody > tr > td:nth-child(1) > h2")); } }


public IWebElement DdlSplitType { get { return WebDriver.GetElement(By.Id("splitLineItem_SplitType")); } }


public IWebElement TxtQantity { get { return WebDriver.GetElement(By.Id("splitLineItem_quantity")); } }


public IWebElement DdlShippingAddressType { get { return WebDriver.GetElement(By.Id("splitLineItem_shipping AddressType")); } }


public IWebElement DdlShippingMethodType { get { return WebDriver.GetElement(By.Id("splitLineItem_shippingMethodType")); } }


public IWebElement TxtNewLines { get { return WebDriver.GetElement(By.CssSelector("#main > div > div.info-wrap > div.mg-btm-10 > table > tbody > tr > td:nth-child(5) > input")); } }


public IWebElement LnkApplyToQuotePreview { get { return WebDriver.GetElement(By.Id("splitLineItem_applyToPreview")); } }


public IWebElement ChkRemoveOriginalLineFromQuote { get { return WebDriver.GetElement(By.Id("splitLineItem_removeOriginal")); } }


public IWebElement HdrItemInfo { get { return WebDriver.GetElement(By.Id("splitLineItem_item_info")); } }


public IWebElement DivPreviewList { get { return WebDriver.GetElement(By.Id("_splititem_preview_list")); } }


public IWebElement TotalPrice { get { return WebDriver.GetElement(By.CssSelector("#_splititem_preview_list > div > table > tfoot > tr")); } }


public IWebElement BtnClose { get { return WebDriver.GetElement(By.Id("splitlineitem_cancel")); } }

        #endregion

        public CreateQuotePage SplitByQuantityPerLine(int quantity = 1, string shippingAddress = null,
            string shippingMethod = null, int newLines = 1, bool removeOriginal = false)
        {
            DdlSplitType.PickDropdownByText(WebDriver, "Quantity per Line");
            TxtQantity.SetText(WebDriver, quantity.ToString());
            if (shippingAddress != null)
                DdlShippingAddressType.PickDropdownByText(WebDriver, shippingAddress);
            if (shippingMethod != null)
                DdlShippingMethodType.PickDropdownByText(WebDriver, shippingMethod);
            TxtNewLines.SetText(WebDriver, newLines.ToString());
            if(removeOriginal)
                ChkRemoveOriginalLineFromQuote.SelectCheckBox(WebDriver);
            LnkApplyToQuotePreview.Click(WebDriver);
            BtnClose.Click(WebDriver);
            return new CreateQuotePage(WebDriver);
        }

        public CreateQuotePage SplitByQuantityPerAddress()
        {
            //TODO:
            return new CreateQuotePage(WebDriver);
        }

        public CreateQuotePage SplitByManual()
        {
            //TODO:
            return new CreateQuotePage(WebDriver);
        }
    }
}
