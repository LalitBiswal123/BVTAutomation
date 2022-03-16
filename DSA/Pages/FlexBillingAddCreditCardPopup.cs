using Dsa.DataModels;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
    public class FlexBillingAddCreditCardPopup : DsaPageBase
    {
        public FlexBillingAddCreditCardPopup(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement DdlCardType { get { return WebDriver.GetElement(By.Id("cartPayment_cardType")); } }


public IWebElement TxtNameOnCard { get { return WebDriver.GetElement(By.Id("cartPayment_nameOnCard")); } }


public IWebElement TxtCreditCardNumber { get { return WebDriver.GetElement(By.Id("cartPayment_ccNumber")); } }


public IWebElement DdlExpirationMonth { get { return WebDriver.GetElement(By.Id("cartPayment_expirationMonth")); } }


public IWebElement DdlExpirationYear { get { return WebDriver.GetElement(By.Id("cartPayment_expirationYear")); } }


public IWebElement TxtCid { get { return WebDriver.GetElement(By.Id("cartPayment_cid")); } }


public IWebElement TxtAddress1 { get { return WebDriver.GetElement(By.Id("cartPayment_address1")); } }


public IWebElement TxtAddress2 { get { return WebDriver.GetElement(By.Id("cartPayment_address2")); } }


public IWebElement TxtCity { get { return WebDriver.GetElement(By.Id("cartPayment_city")); } }


public IWebElement DdlState { get { return WebDriver.GetElement(By.Id("cartPayment_state")); } }


public IWebElement TxtZipCode { get { return WebDriver.GetElement(By.Id("cartPayment_zip")); } }


public IWebElement TxtPhoneNumber { get { return WebDriver.GetElement(By.Id("cartPayment_phone")); } }


public IWebElement TxtCustomerReferenceNumber { get { return WebDriver.GetElement(By.Id("cartPayment_cardRefNumber")); } }


public IWebElement BtnSave { get { return WebDriver.GetElement(By.CssSelector(".btn-bar > button:nth-child(1)")); } }


public IWebElement BtnCancel { get { return WebDriver.GetElement(By.Id(".btn-bar > button:nth-child(2)")); } }

        #endregion

        public void AddCreditCard(CreditCard card)
        {
            DdlCardType.PickDropdownByText(WebDriver, card.CardType);
            TxtNameOnCard.SetText(WebDriver, card.NameOnCard);
            TxtCreditCardNumber.SetText(WebDriver, card.CreditCardNumber);
            DdlExpirationMonth.PickDropdownByText(WebDriver, card.ExpirationMonth);
            DdlExpirationYear.PickDropdownByText(WebDriver, card.ExpirationYear);
            TxtCid.SetText(WebDriver, card.Cid);
            TxtAddress1.SetText(WebDriver, card.Address1);
            TxtAddress2.SetText(WebDriver, card.Address2);
            TxtCity.SetText(WebDriver, card.City);
            DdlState.PickDropdownByText(WebDriver, card.State);
            TxtZipCode.SetText(WebDriver, card.ZipCode);
            TxtPhoneNumber.SetText(WebDriver, card.PhoneNumber);
            if (card.CardType.ToLower() == "amex" || card.CardType.ToLower() == "americanexpress")
                TxtCustomerReferenceNumber.SetText(WebDriver, card.CustomerReferenceNumber);
            BtnSave.Click(WebDriver);
        }
    }
}
