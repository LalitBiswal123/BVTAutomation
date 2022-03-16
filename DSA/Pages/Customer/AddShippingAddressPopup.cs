using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Dell.Adept.UI.Web.Pages;
using Dsa.DataModels;

namespace Dsa.Pages.Customer
{
    public class AddShippingAddressPopup : PagePartBase
    {
        private IWebDriver WebDriver;

        #region Elements

        public IWebElement AddShippingCompanyNameId { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_companyName")); } }

        public IWebElement AddShippingFirstNameId { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_firstName")); } }

        public IWebElement AddShippingMiddleNameId { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_middleName")); } }

        public IWebElement AddShippingLastNameId { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_lastName")); } }

        public IWebElement AddShippingTitle { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_title")); } }

        public IWebElement AddShippingDepartmentId { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_department")); } }

        public IWebElement AddShippingMailStop { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_mailstop")); } }

        public IWebElement AddShippingPrimaryPhoneId { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_primaryPhone")); } }

        public IWebElement AddShippingSecPhoneId { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_secondaryPhone")); } }

        public IWebElement AddShippingFaxNumberId { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_fax")); } }

        public IWebElement AddShippingAddress1 { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_addressLine1")); } }

        public IWebElement AddShippingAddress2 { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_addressLine2")); } }

        public IWebElement AddShippingCity { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_city")); } }

        public IWebElement AddShippingState { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_state")); } }

        public IWebElement AddShippingZipCode { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_zipCode")); } }

        public IWebElement AddShippingZipCodeExtension { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_zipCodeExtension")); } }

        public IWebElement AddShippingCountry { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_country")); } }

        public IWebElement AddShippingEmailId { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_email")); } }

        public IWebElement EnteredAddressLine1 { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_entered_line1")); } }

        public IWebElement SuggestedAddressEdit { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_addShippingAddress_edit")); } }

        public IWebElement SuggestedAddressSelect { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_addShippingAddress_select")); }}
   
        public IWebElement SuggestedAddressLine1 { get { return WebDriver.GetElement(By.Id("customerDetails_validateAddress_suggested_line1_")); } }

        public IWebElement BtnAddShippingSave { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_save")); } }

        public IWebElement BtnAddShippingCancel { get { return WebDriver.GetElement(By.Id("customerDetails_addShippingAddress_cancel")); } }

        #endregion

        /// <summary>
        /// The parent element of the page part. E.g. the div element that contains all of the child elements in the part.
        /// </summary>
        /// <value>The parent element.</value>
        public IWebElement ParentElement { get; set; }

        /// <summary>
        /// The parent page. This is typically passed into the constructor of the concrete pagepart.
        /// </summary>
        public IPage ParentPage;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddShippingAddressPopup"/> class.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <param name="parentElement">The parent element.</param>
        public AddShippingAddressPopup(IPage page, IWebElement parentElement)
            : base(page, ref parentElement)
        {
            ParentPage = page;
            ParentElement = parentElement;
            WebDriver = ParentPage.WebDriver;
        }

        /// <summary>
        /// Adds the shipping address.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <param name="selectenteredAddress">if set to <c>true</c> [selectentered address].</param>
        /// <param name="suggestedAddressIndex">Index of the suggested address.</param>
        public void AddShippingAddress(Address address, bool selectenteredAddress = true, int suggestedAddressIndex = 1)
        {
            AddShippingCompanyNameId.SetText(WebDriver, address.CompanyName);
            AddShippingFirstNameId.SetText(WebDriver, address.FirstName);
            AddShippingMiddleNameId.SetText(WebDriver, address.MiddleInitial);
            AddShippingLastNameId.SetText(WebDriver, address.LastName);
            AddShippingTitle.SetText(WebDriver, address.Title);
            AddShippingEmailId.SetText(WebDriver, address.Email);
            AddShippingAddress1.SetText(WebDriver, address.AddressLine1);
            AddShippingAddress2.SetText(WebDriver, address.AddressLine2);
            AddShippingDepartmentId.SetText(WebDriver, address.Department);
            AddShippingMailStop.SetText(WebDriver, address.Mailstop);
            AddShippingCity.SetText(WebDriver, address.City);
            AddShippingState.PickDropdownByText(WebDriver, address.State);
            AddShippingZipCode.SetText(WebDriver, address.ZipCode);
            AddShippingZipCodeExtension.SetText(WebDriver, address.ZipExtension);
            AddShippingPrimaryPhoneId.SetText(WebDriver, address.PrimaryPhone);
            AddShippingSecPhoneId.SetText(WebDriver, address.SecondaryPhone);
            AddShippingFaxNumberId.SetText(WebDriver, address.FaxNumber);

            BtnAddShippingSave.Click(WebDriver);

            if (selectenteredAddress)
                SelectEnteredAddress();
            else
                SelectSuggestedAddress(suggestedAddressIndex);
        }

        /// <summary>
        /// Selects the entered address.
        /// </summary>
        public void SelectEnteredAddress()
        {
            EnteredAddressLine1.Click(WebDriver);
            SuggestedAddressSelect.Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();           
        }

        /// <summary>
        /// Selects the suggested address.
        /// </summary>
        /// <param name="row">The row.</param>
        public void SelectSuggestedAddress(int row)
        {
            SuggestedAddressLine1.Click(WebDriver);
            SuggestedAddressSelect.Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
          
        }

        /// <summary>
        /// Cancels the add shipping address.
        /// </summary>
        public void CancelAddShippingAddress()
        {
            BtnAddShippingCancel.Click(WebDriver);            
        }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
