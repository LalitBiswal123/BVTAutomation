using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
    public class GoalPage : DsaPageBase
    {
        public GoalPage(IWebDriver webDriver)
            : base(webDriver)
        {
        }
        #region Elements


public IWebElement TxtTotalDiscountPercentage { get { return WebDriver.GetElement(By.Id("1_LI_discountPercent")); } }


public IWebElement MsgDamThreshold { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteCreate_LI_discountPercent_1')]/div[3)]/div[2)]")); } }


public IWebElement BtnCreateQuoteExpandLineItem { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_1")); } }


public IWebElement LblQuoteCreateGoalDealId { get { return WebDriver.GetElement(By.Id("quoteCreate_LI_info_goalDealId_1")); } }


public IWebElement LnkQuoteCreateNewRequest { get { return WebDriver.GetElement(By.Id("quoteCreate_createNewGoalDealId_1")); } }


public IWebElement LnkQuoteCreatePickFromList { get { return WebDriver.GetElement(By.Id("quoteCreate_selectGoalDealId_1")); } }


public IWebElement LnkQuoteCreateGoalTool { get { return WebDriver.GetElement(By.Id("quoteCreate_openGoalTool_1")); } }


public IWebElement DivQuoteCreateAvlGoalDealIdSelectedProd { get { return WebDriver.GetElement(By.Id("goal-deal-select-selected-product")); } }
        

public IWebElement TblQuoteCreateAvlGoalDealIdList { get { return WebDriver.GetElement(By.Id("Quotecreation_goaldealsGrid")); } }


public IWebElement LnkQuoteCreateActiveSelect { get { return WebDriver.GetElement(By.Id("quotecreation_goaldealsGrid_select")); } }


public IWebElement LblDiscountLimitReached { get { return WebDriver.GetElement(By.Id("changeCustomer_title")); } }


public IWebElement BtnDiscountLimitReachedOk { get { return WebDriver.GetElement(By.Id("discountLimitReached_ok")); } }


public IWebElement LblGoalValidationMessageAtQuote { get { return WebDriver.GetElement(By.Id("quoteDetail_dealValidationErrorMessage_missingGoalDeal")); } }


public IWebElement LblGoalValidationMessageAtQuoteCreatePage { get { return WebDriver.GetElement(By.Id("quoteCreate_dealValidationMessage")); } }


public IWebElement BtnQuoteDetailExpandLineItem { get { return WebDriver.GetElement(By.Id("quoteDetail_LI_1")); } }


public IWebElement LblQuoteDetailGoalValidationAtLineItem { get { return WebDriver.GetElement(By.Id("quoteDetail_dealValidationMessage")); } }


public IWebElement LblQuoteDetailGoalDealId { get { return WebDriver.GetElement(By.Id("quoteDetail_LI_info_goalDealId_1")); } }


public IWebElement LnkQuoteDetailNewRequest { get { return WebDriver.GetElement(By.Id("quoteDetail_createNewGoalDealId_1")); } }


public IWebElement LnkQuoteDetailPickFromList { get { return WebDriver.GetElement(By.Id("quoteDetail_selectGoalDealId_1")); } }


public IWebElement LnkQuoteDetailGoalTool { get { return WebDriver.GetElement(By.Id("quoteDetail_openGoalTool_1")); } }


public IWebElement DivQuoteDetailAvlGoalDealIdSelectedProd { get { return WebDriver.GetElement(By.Id("goal-deal-select-selected-product")); } }
        // Class

public IWebElement TblQuoteDetailAvlGoalDealIdList { get { return WebDriver.GetElement(By.Id("Quotecreation_goaldealsGrid")); } }


public IWebElement LnkQuoteDetailActiveSelect { get { return WebDriver.GetElement(By.Id("quotecreation_goaldealsGrid_select")); } }


public IWebElement BtnReviewOrderExpandLineItem { get { return WebDriver.GetElement(By.Id("orderReview_LI_1")); } }


public IWebElement LblReviewOrderGoalDealId { get { return WebDriver.GetElement(By.Id("orderReview_LI_info_goalDealId_1")); } }


public IWebElement BtnOrderDetailsExpandLineItem { get { return WebDriver.GetElement(By.Id("orderDetails_LI_1")); } }


public IWebElement LblOrderDetailsGoalDealId { get { return WebDriver.GetElement(By.Id("orderDetails_LI_info_goalDealId_1")); } }

        #endregion
    }
}
