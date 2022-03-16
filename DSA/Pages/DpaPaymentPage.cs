using System;
using System.Configuration;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.DataModels;
using Dsa.Pages.Order;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Dell.Adept.Testing.DataGenerators.Primitive;
using Dsa.Pages.PCFConvergence;

namespace Dsa.Pages
{
    public class DpaPaymentPage : DsaPageBase
    {
        // As this is an external page, we need to wait few more seconds than expected to load all elements properly.
        readonly TimeSpan _waitTime = TimeSpan.FromSeconds(150);

        public DpaPaymentPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement ChkAmISpeakingToSsnHolder { get { return WebDriver.GetElement(By.Id("SSNHolder")); } }


public IWebElement DdlBirthMonth { get { return WebDriver.GetElement(By.Id("DateOfBirth_DateOfBirthMonth")); } }


public IWebElement DdlBirthDay { get { return WebDriver.GetElement(By.Id("DateOfBirth_DateOfBirthDay")); } }


public IWebElement DdlBirthYear { get { return WebDriver.GetElement(By.Id("DateOfBirth_DateOfBirthYear")); } }


public IWebElement TxtSocialSecurityNumber { get { return WebDriver.GetElement(By.Id("SocialSecurityNumber")); } }


public IWebElement TxtMothersMaidenNamWebElement { get { return WebDriver.GetElement(By.Id("MothersMaidenName")); } }


public IWebElement RdbRent { get { return WebDriver.GetElement(By.CssSelector("label.radio-inline:nth-child(1) > input:nth-child(1)")); } }


public IWebElement RdbOwn { get { return WebDriver.GetElement(By.CssSelector("label.radio-inline:nth-child(2) > input:nth-child(1)")); } }


public IWebElement RdbOther { get { return WebDriver.GetElement(By.CssSelector("label.radio-inline:nth-child(3) > input:nth-child(1)")); } }


public IWebElement TxtMonthlyMortgageOrRent { get { return WebDriver.GetElement(By.Id("MonthlyMortgageOrRent")); } }


public IWebElement ChkChildSupportSeparateMaintenance { get { return WebDriver.GetElement(By.Id("ChildSupportSeparateMaintenance")); } }


public IWebElement TxtAnnualIncome { get { return WebDriver.GetElement(By.Id("AnnualIncome")); } }


public IWebElement ChkPermissionToRunCredit { get { return WebDriver.GetElement(By.Id("PermissionToRunCredit")); } }


public IWebElement BtnSubmit { get { return WebDriver.GetElement(By.CssSelector("button.btn")); } }


public IWebElement BtnCancel { get { return WebDriver.GetElement(By.CssSelector("a.btn")); } }

       // [FindsBy(How = How.XPath, Using = "//button[@type='button']")]

public IWebElement BtnRunCreditNext { get { return WebDriver.GetElement(By.XPath("//button[@type='button']")); } }


public IWebElement BtnFeatureToggleUiContinue { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='Continue']")); } }


public IWebElement BtnDFSDetailsNext { get { return WebDriver.GetElement(By.XPath(".//button[contains(text(),'Next')]")); } }


public IWebElement LblDFSDetailsPage { get { return WebDriver.GetElement(By.XPath(".//*[contains(text(),'DFS Details')]")); } }



public IWebElement AgreeTCYes { get { return WebDriver.GetElement(By.XPath("//input[ @id='DoYouAgree' and @value='yes']")); } }


public IWebElement AddtoDPAYes { get { return WebDriver.GetElement(By.XPath("//input[ @id='UseDPA' and @value='yes']")); } }


public IWebElement DeliveryViaEmailDropdown { get { return WebDriver.GetElement(By.XPath("//*[@id='DeliveryMethod']")); } }
       

public IWebElement DriversLicenseTextBox { get { return WebDriver.GetElement(By.XPath("//*[@id='DriversLicenseOrStateID']")); } }


public IWebElement DLIssuingStateDropdown { get { return WebDriver.GetElement(By.XPath("//*[@id='IssuingState']")); } }


public IWebElement IDTypeDropdown { get { return WebDriver.GetElement(By.XPath("//*[@id='IDType']")); } }


public IWebElement EmployerTextBox { get { return WebDriver.GetElement(By.XPath("//*[@id='Employer']")); } }


public IWebElement DeliveryEmailTextbox { get { return WebDriver.GetElement(By.XPath("//*[@id='Email']")); } }


public IWebElement DPATCHeader { get { return WebDriver.GetElement(By.XPath("//*[@id='dpa-terms']//h2")); } }


       // [FindsBy(How = How.XPath, Using = "//*[@id='dpa-terms']//button")]
public IWebElement DPATCNext { get { return WebDriver.GetElement(By.XPath("//*[@id='dpa-terms']//button")); } }


public IWebElement HomePhone { get { return WebDriver.GetElement(By.Id("HomePhone")); } }


public IWebElement WorkPhone { get { return WebDriver.GetElement(By.Id("WorkPhone")); } }

        #region Complete DPA Information


public IWebElement ChkHaveReadPromotionalDisclosure { get { return WebDriver.GetElement(By.Id("HaveReadPromotionalDisclosure")); } }

        // [FindsBy(How = How.XPath, Using = "//button[@type='button']")]

public IWebElement BtnNextDPACustomerInformation { get { return WebDriver.GetElement(By.XPath("//button[normalize-space()='Next']")); } }


public IWebElement BtnNextHaveReadPromotionalDisclosure { get { return WebDriver.GetElement(By.CssSelector("#dpa-promotiondisclosures > div.row.top-offset-large > div > button")); } }

        #endregion

        #endregion

        public void ContinueWithFeatureToggleUi()
        {
            BtnFeatureToggleUiContinue.WaitForElementVisible(_waitTime);
            BtnFeatureToggleUiContinue.Click();
        }

        public PaymentsPage EnterDpaInformationForRunCredit(Dpa dpaData)
        {
            /* As This is an external page, we cannot use the busy overlay,
            hence wait for the element to be visible and use all selenium methods to interact with elements. */
            //ContinueWithFeatureToggleUi();
            ChkAmISpeakingToSsnHolder.WaitForElementVisible(_waitTime);
            ChkAmISpeakingToSsnHolder.Click();
            DdlBirthMonth.Select().SelectByText(dpaData.BirthMonth);
            DdlBirthDay.Select().SelectByText(dpaData.BirthDay);
            DdlBirthYear.Select().SelectByText(dpaData.BirthYear);
            TxtSocialSecurityNumber.WaitForElementVisible(_waitTime);
            TxtSocialSecurityNumber.Click();
            Logger.Write("SSN: " + dpaData.SocialSecurityNumber);
            TxtSocialSecurityNumber.SendKeys(dpaData.SocialSecurityNumber);
            //TxtSocialSecurityNumber.SetText(WebDriver, dpaData.SocialSecurityNumber);
            TxtMothersMaidenNamWebElement.SendKeys(dpaData.MothersMaidenName);
            RdbRent.Click();
            TxtMonthlyMortgageOrRent.WaitForElementVisible(_waitTime);
            TxtMonthlyMortgageOrRent.SendKeys(dpaData.MonthlyMortgageOrRent);
            ChkChildSupportSeparateMaintenance.Click();
            TxtAnnualIncome.WaitForElementVisible(_waitTime);
            TxtAnnualIncome.SendKeys(dpaData.AnnualIncome);
            ChkPermissionToRunCredit.Click();
            BtnSubmit.WaitForElementVisible(_waitTime);
            BtnSubmit.Click();
            BtnRunCreditNext.WaitForElementVisible(_waitTime);
            BtnRunCreditNext.Click();
            FixURlissueforCI();
            return new PaymentsPage(WebDriver);
        }

        public T EnterDpaInformationForRunCreditTEST<T>(Dpa dpaData)
        {
            /* As This is an external page, we cannot use the busy overlay,
            hence wait for the element to be visible and use all selenium methods to interact with elements. */
            //ContinueWithFeatureToggleUi();
            ChkAmISpeakingToSsnHolder.WaitForElementVisible(_waitTime);
            ChkAmISpeakingToSsnHolder.Click();
            DdlBirthMonth.Select().SelectByText(dpaData.BirthMonth);
            DdlBirthDay.Select().SelectByText(dpaData.BirthDay);
            DdlBirthYear.Select().SelectByText(dpaData.BirthYear);
            TxtSocialSecurityNumber.WaitForElementVisible(_waitTime);
            TxtSocialSecurityNumber.Click();
            Logger.Write("SSN: " + dpaData.SocialSecurityNumber);
            //TxtSocialSecurityNumber.SendKeys(dpaData.SocialSecurityNumber);
            TxtSocialSecurityNumber.SetText(WebDriver, dpaData.SocialSecurityNumber);
            TxtMothersMaidenNamWebElement.SendKeys(dpaData.MothersMaidenName);
            RdbRent.Click();
            TxtMonthlyMortgageOrRent.WaitForElementVisible(_waitTime);
            TxtMonthlyMortgageOrRent.SendKeys(dpaData.MonthlyMortgageOrRent);
            ChkChildSupportSeparateMaintenance.Click();
            TxtAnnualIncome.WaitForElementVisible(_waitTime);
            TxtAnnualIncome.SendKeys(dpaData.AnnualIncome);
            ChkPermissionToRunCredit.Click();
            BtnSubmit.WaitForElementVisible(_waitTime);
            BtnSubmit.Click();
            BtnRunCreditNext.WaitForElementVisible(_waitTime);
            BtnRunCreditNext.Click();
            FixURlissueforCI();

            var page = PageFactory.InitElements<T>(WebDriver);
            //var page = this.WebDriver;
            return page;
        }


        public void FixURlissueforCI()
        {
            var currentURL = WebDriver.Url.ToString();
            if (currentURL.Contains("dell.com.dell.com"))
            {
                var baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
                var temp = currentURL.Substring(0, currentURL.IndexOf('#') + 2);
                currentURL = currentURL.Replace(temp, baseUrl);
                WebDriver.Navigate().GoToUrl(currentURL);
            }

        }

        public void DPACustomerInformation()
        {
            if (WebDriver.Url.Contains("DPACreditAppPart2"))
            {
                DriversLicenseTextBox.WaitForElementVisible(_waitTime);
                //DriversLicenseTextBox.Click();
                DriversLicenseTextBox.SendKeys(Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly));
                DLIssuingStateDropdown.Select().SelectByIndex(2);
               // DLIssuingStateDropdown.PickDropdownByIndex(WebDriver, 2);
                IDTypeDropdown.Select().SelectByIndex(2);
                EmployerTextBox.WaitForElementVisible(_waitTime);
                EmployerTextBox.SendKeys(Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly));

                string homePhone = "461" + Generator.RandomString(7, Generator.RandomCharacterGroup.NumericOnly);
                string workPhone = "787" + Generator.RandomString(7, Generator.RandomCharacterGroup.NumericOnly);
                if (HomePhone.GetText(WebDriver) == string.Empty)
                {                  
                    HomePhone.SetText(WebDriver, homePhone);
                }
                if (WorkPhone.GetText(WebDriver) == string.Empty)
                {
                    WorkPhone.SetText(WebDriver, workPhone);
                }               
                               
                BtnNextDPACustomerInformation.WaitForElementVisible(_waitTime);
                BtnNextDPACustomerInformation.Click();
            }
        }

        public PaymentsPage AcceptPromotionDisclosure()
        {
            //DpatnC();
            //ContinueWithFeatureToggleUi();
            DPACustomerInformation();
            if (WebDriver.Url.Contains("DPATerms"))
            { AgreeTCYes.Click(); AddtoDPAYes.Click(); DeliveryViaEmailDropdown.Select().SelectByIndex(1); DPATCNext.WaitForElementVisible(_waitTime); DPATCNext.Click(); }
            ChkHaveReadPromotionalDisclosure.WaitForElementVisible(_waitTime);
            ChkHaveReadPromotionalDisclosure.Click();
            BtnNextHaveReadPromotionalDisclosure.WaitForElementVisible(_waitTime);
            BtnNextHaveReadPromotionalDisclosure.Click();
            return new PaymentsPage(WebDriver);
        }

        public PaymentsPage ValidatePromotion()
        {
            if (WebDriver.Url.Contains("DPATerms")) { AgreeTCYes.Click(); AddtoDPAYes.Click(); DeliveryViaEmailDropdown.Select().SelectByIndex(1); DPATCNext.Click(WebDriver); }
            ChkHaveReadPromotionalDisclosure.WaitForElementVisible(_waitTime);
            return new PaymentsPage(WebDriver);
        }


        public PaymentsPage DpatnC()
        {
            if (DPATCHeader.IsElementDisplayed(WebDriver))
                AgreeTCYes.Click(WebDriver);
                AddtoDPAYes.Click(WebDriver);
                DeliveryViaEmailDropdown.PickDropdownByText(WebDriver, "Email Address");
                DeliveryEmailTextbox.SetText(WebDriver,"com_qe@dell.com");
                DPATCNext.Click(WebDriver);
                return new PaymentsPage(WebDriver);
        }
        public PCFPaymentsPage AcceptDpaPromotionDisclosure()
        {
            DPACustomerInformation();
            if (WebDriver.Url.Contains("DPATerms"))
            { AgreeTCYes.Click(); AddtoDPAYes.Click(); DeliveryViaEmailDropdown.Select().SelectByIndex(1); DPATCNext.WaitForElementVisible(_waitTime); DPATCNext.Click(); }
            ChkHaveReadPromotionalDisclosure.WaitForElementVisible(_waitTime);
            ChkHaveReadPromotionalDisclosure.Click();
            BtnNextHaveReadPromotionalDisclosure.WaitForElementVisible(_waitTime);
            BtnNextHaveReadPromotionalDisclosure.Click();

            new PCFPaymentsPage(WebDriver).PaymentMethodsDropdown.IsElementClickable(WebDriver, TimeSpan.FromSeconds(20));
            return new PCFPaymentsPage(WebDriver);
        }
    }
}
