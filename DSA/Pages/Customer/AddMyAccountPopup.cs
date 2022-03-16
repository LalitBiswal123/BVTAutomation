using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace Dsa.Pages.Customer
{
   public class AddMyAccountPopup : DsaPageBase
    {
        public AddMyAccountPopup(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements

        protected IWebElement TxtSearchMyAccountEmail { get { return WebDriver.GetElement(By.Id("search_email_input")); } }

        protected IWebElement BtnSearchMyAccount { get { return WebDriver.GetElement(By.Id("search_email")); } }

        protected IWebElement TxtMyAccountFirstName { get { return WebDriver.GetElement(By.Id("myaccount_first_name")); } }

        protected IWebElement TxtMyAccountLastName { get { return WebDriver.GetElement(By.Id("myaccount_last_name")); } }

        protected IWebElement TxtMyAccountEmailAddress { get { return WebDriver.GetElement(By.Id("myaccount_email_address")); } }

        protected IWebElement TxtMyAccountAddressLine1 { get { return WebDriver.GetElement(By.Id("myaccount_address_line1")); } }

        protected IWebElement TxtMyAccountAddressLine2 { get { return WebDriver.GetElement(By.Id("myaccount_address_line2")); } }

        protected IWebElement TxtMyAccountCity { get { return WebDriver.GetElement(By.Id("myaccount_city")); } }

        protected IWebElement TxtMyAccountState { get { return WebDriver.GetElement(By.Id("myaccount_state")); } }

        protected IWebElement TxtMyAccountZip { get { return WebDriver.GetElement(By.Id("myaccount_zip_code")); } }

        protected IWebElement TxtMyAccountZip4 { get { return WebDriver.GetElement(By.Id("myaccount_zip_4")); } }

        protected IWebElement ChxboxMyAccountIncludeOffer { get { return WebDriver.GetElement(By.Id("myaccount_include_offers")); } }

        protected IWebElement ChkboxMyAccountEnableDellAdvantage { get { return WebDriver.GetElement(By.Id("myaccount_enable_dell_advantage")); } }

        protected IList<IWebElement> BtnAddMyAccount { get { return WebDriver.GetElements(By.Id("_addMyAccountButton")); } }

        protected IWebElement BtnCancelAddMyAccount { get { return WebDriver.GetElement(By.Id("_cancel")); }}

        protected IWebElement CloseMyAccountPopup { get { return WebDriver.GetElement(By.Id("_close")); } }

        protected IWebElement DivSearchEmailError { get { return WebDriver.GetElement(By.Id("_emailSearchErrorSection")); } }

        protected IWebElement DivAssociateMyAccountError { get { return WebDriver.GetElement(By.Id("_associateMyAccountErrorSection")); } }

        protected IWebElement MsgSearchMyAccountSuccessRow1 { get { return WebDriver.GetElement(By.CssSelector("#COM > div.modal-small.ng-scope > div > div:nth-child(3) > div.modal-body > div:nth-child(2) > div")); } }

        protected IWebElement MsgSearchMyAccountSuccessRow2 { get { return WebDriver.GetElement(By.CssSelector("#COM > div.modal-small.ng-scope > div > div:nth-child(3) > div.modal-body > div:nth-child(3) > div")); } }
      
        protected IWebElement DivAddMyAccountFormValidationError { get { return WebDriver.GetElement(By.Id("_formValidationErrorSection")); } }

        #endregion

        /// <summary>
        /// Searches my account.
        /// </summary>
        public void SearchMyAccount()
        {
            BtnSearchMyAccount.Click(WebDriver);
        }

       //TODO :: Need to fix once check-box UTIL method done
        ///// <summary>
        ///// Sets the include offer.
        ///// </summary>
        ///// <param name="include">if set to <c>true</c> [include].</param>
        //public void SetIncludeOffer(bool include)
        //{
        //    ChxboxMyAccountIncludeOffer.
        //    webDriver.GetElement(_byMyAccountIncludeOfferCheckbox).Set(include);
        //}

        ///// <summary>
        ///// Sets the enable dell advantage.
        ///// </summary>
        ///// <param name="enable">if set to <c>true</c> [enable].</param>
        //public void SetEnableDellAdvantage(bool enable)
        //{
        //    webDriver.GetElement(_byMyAccountEnableDellAdvantageCheckbox).Set(enable);
        //}

        /// <summary>
        /// Adds my account.
        /// </summary>
        public void AddMyAccount()
        {
            BtnAddMyAccount[0].Click(WebDriver);
        }

        /// <summary>
        /// Associates my account.
        /// </summary>
        public void AssociateMyAccount()
        {
            BtnAddMyAccount[1].Click(WebDriver);
        }

        ///// <summary>
        ///// Closes my account popup.
        ///// </summary>
        //public void CloseMyAccountPopup()
        //{
        //    BtnCancelAddMyAccount.Click(WebDriver);           
        //}

        //TODO :: Need to check if needed or not
        ///// <summary>
        ///// The parent element of the page part. E.g. the div element that contains all of the child elements in the part.
        ///// </summary>
        ///// <value>The parent element.</value>
        //public IWebElement ParentElement { get; set; }

        ///// <summary>
        ///// The parent page. This is typically passed into the constructor of the concrete pagepart.
        ///// </summary>
        //public IPage ParentPage;

        ///// <summary>
        ///// Initializes a new instance of the <see cref="AddMyAccountPopup"/> class.
        ///// </summary>
        ///// <param name="page">The page.</param>
        ///// <param name="parentElement">The parent element.</param>
        //public AddMyAccountPopup(IPage page, IWebElement parentElement)
        //    : base(page, ref parentElement)
        //{
        //    ParentPage = page;
        //    ParentElement = parentElement;
        //    webDriver = page.WebDriver;
        //}
    }
}
