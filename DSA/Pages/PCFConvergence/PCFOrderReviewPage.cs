using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Utils;
using OpenQA.Selenium;

namespace Dsa.Pages.PCFConvergence
{
    public class PCFOrderReviewPage : DsaPageBase
    {
        private const string PagePrefix = "orderReviewPage";
        private IWebDriver webDriver;
        public PCFOrderReviewPage(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "Order Review Page";
            this.webDriver = webDriver;
        }

        public PCFPaymentsPage Summary
        {
            get
            {
                return new PCFPaymentsPage(WebDriver);
            }
        }
        #region webelements_Knights
        public IWebElement BtnBeginGMORReview { get { return WebDriver.GetElement(By.Id("GmorButton")); } }
        public IWebElement BtnGMORNext { get { return WebDriver.GetElement(By.Id("bootstro_nextBtn")); } }
        public IWebElement LblGMORStep { get { return WebDriver.GetElement(By.XPath("//span[@class='pd-right-10' and contains(text(), 'Step')]")); } }
        public IWebElement BtnGMORDone { get { return WebDriver.GetElement(By.Id("bootstro_lastBtn")); } }
        public IWebElement BtnPlaceOrder { get { return WebDriver.GetElement(By.Id("PlaceOrderButton")); } }
        public IWebElement LblDPID { get { return WebDriver.GetElement(By.Id("purchaseId")); } }

        #endregion
  
        #region Elements
        public IWebElement NonSubscriptionPaymentMethod { get { return WebDriver.GetElement(By.XPath("//*[@id='GM_PaymentMethod_1']//div[@id='paymentDescription']")); } }
        public IWebElement SubscriptionPaymentMethod { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'subscription-item')][2]//*[@id='paymentDescription']")); } }
        public IWebElement ShowDetailsLink { get { return WebDriver.GetElement(By.XPath("//*[contains(@id,'subscription-item')][1]//button//i")); } }
        //public IWebElement PaymentMethod { get { return WebDriver.GetElement(By.Id("paymentDescription")); } }
        public IWebElement PaymentMethod { get { return WebDriver.GetElement(By.Id("paymentDescriptionlbl")); } }
        public IWebElement UCIDShipTo { get { return WebDriver.GetElement(By.Id("ShipGroup0_shipTo_UCID")); } }
        public IWebElement UCIDRequestNotifShipTo { get { return WebDriver.GetElement(By.Id("ShipGroup0_shipTo_UCIDStatus")); } }
        public IWebElement EditPaymentMethodLink { get { return WebDriver.GetElement(By.Id("PaymentLink")); } }
        public List<IWebElement>  PONumValue { get { return WebDriver.GetElements(By.XPath("//*[@id='purchaseOrderNumber']")); } }
        public IWebElement OrderType { get { return WebDriver.GetElement(By.Id("headerOrderTypeValue")); } }
        public IWebElement PaymentAmt { get { return WebDriver.GetElement(By.Id(" amountlbl")); } }
        public IWebElement OrderReviewTitle { get { return WebDriver.GetElement(By.Id("OrderReviewTitle")); } }
        public IWebElement ReviewOrderShippingGrp(int? ShippingIndex)
        {
            return WebDriver.FindElement(By.Id("shipping_group_tab_" + ShippingIndex + ""));
        }

        public IWebElement ReviewOrderSolutionName(int? ShippingIndex)
        {
            return WebDriver.FindElement(By.Id("orderReview_solutionName_value_" + ShippingIndex + ""));
        }

        public IWebElement ReviewOrderSolutionNameTxt(int? ShippingIndex)
        {
            return WebDriver.FindElement(By.Id("solutionName" + ShippingIndex + ""));
        }

        public string SummarySelectedCadence()
        {
            return WebDriver.GetElement(By.XPath("//*[@id='aposPricingSummary_monthly']/strong")).GetText(WebDriver);
        }

        public string SummaryUpfrontPaymentAmount()
        {
            return WebDriver.GetElement(By.XPath("//*[@id='aposPricingSummary_upFrontPayment']/strong")).GetText(WebDriver);
        }

        public string TotalContractValue()
        {
            return WebDriver.GetElement(By.XPath("//*[@id='aposPricingSummary_totalContractPrice']/strong")).GetText(WebDriver);
        }
        #endregion

        #region DTCP 

        public IWebElement PaymentForSubscriptionTxt { get { return WebDriver.FindElement(By.XPath("//*[contains(text(),'Payment for subscription billing')]")); } }

        public IWebElement DTCPSubscriptionTxt { get { return WebDriver.FindElement(By.XPath("//*[contains(text(),'DTCP with Subscription')]")); } }

        #endregion
        #region POM
        public IWebElement PoNumberLabel { get { return WebDriver.GetElement(By.XPath("//div[@id='headerPONumberTitle']")); } }
        public IWebElement PoNumber { get { return WebDriver.GetElement(By.XPath("//div[@id='headerPONumberValue']")); } }
        public IWebElement POMIDLabel { get { return WebDriver.GetElement(By.XPath("//div[@id='headerPOMIdTitle']")); } }
        public IWebElement POMID { get { return WebDriver.GetElement(By.XPath("//div[@id='headerPOMIdValue']")); } }

        #endregion POM
        public int GetGMORSteps()
        {
            BtnGMORNext.Click(WebDriver, TimeSpan.FromSeconds(3));

            string Steps = LblGMORStep.GetText(WebDriver, TimeSpan.FromSeconds(5));
            Steps = Steps.Substring(Steps.Length - 1);
            int num = int.Parse(Steps);
            return num;
        }

        /// <summary>
        /// Begins and Ends GMOR Steps
        /// </summary>
        public void CompleteGMOR()
        {
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            webDriver.WaitForElementDisplay(By.Id("GmorButton"));
            {
                Logger.Write("Completing GMOR");
                new PCFOrderReviewPage(webDriver).BtnBeginGMORReview.PCFClick(WebDriver);
                do
                {
                    BtnGMORNext.WaitForElementDisplayed(TimeSpan.FromSeconds(2));
                    // GMORNextButton.Click();
                    WebDriverUtil.JavaScriptClick(WebDriver, BtnGMORNext);

                    if (BtnGMORNext.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(3)) == false)
                    {
                        break;
                    }

                } while (BtnGMORNext.Displayed == true);

                WebDriverUtil.JavaScriptClick(WebDriver, BtnGMORDone);
            }
            
        }

        public PCFOrderDetailsPage PlaceOrder()
        {
            BtnPlaceOrder.PCFClick(WebDriver);
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            return new PCFOrderDetailsPage(WebDriver);
        }

        public void WaitForOrderReviewDetailsToload()
        {
            WebDriverUtil.WaitForElementDisplay(WebDriver, By.XPath("//*[@id='GM_PaymentMethod_1']//div[@id='paymentDescription']']"), TimeSpan.FromSeconds(15));
        }

        public PCFPaymentsPage EditPaymentMethod(String PaymentType)
        {

            EditPaymentMethodLink.PCFClick(WebDriver);
            WebDriver.PCFVerifyBusyOverlayNotDisplayed();
            new PCFPaymentsPage(WebDriver).SelectPaymentType(PaymentType);
            return new PCFPaymentsPage(WebDriver);
        }

        public PCFOrderDetailsPage SaveOrder()
        {           

            CompleteGMOR();
            return PlaceOrder();
        }
        public IWebElement LblProductLevelRSid(int groupIndex = 1, int itemIndex = 1)
        {
            return WebDriver.GetElement(By.Id("GM_Product_" + (groupIndex - 1) + "_" + (itemIndex - 1)));
        }


        #region FT2

        public IWebElement BtnGmorBeginNextDone { get { return WebDriver.GetElement(By.XPath("//*[@id='bootstro_nextBtn' or @id='bootstro_lastBtn']")); } }

        public IWebElement LblGmoreCount { get { return WebDriver.GetElement(By.XPath("//*[@class='popover-title']/span")); } }


        public string GetGoalDealIdFromItem(int shippingGroupIndex = 1, int itemIndex = 1)
        {
            return
                WebDriver.GetElement(By.Id(PagePrefix + "_LI_info_goalDealId_" + (shippingGroupIndex - 1) + "_" + (itemIndex - 1)))
                    .GetText(WebDriver);
        }


        public string GetGoalDealIdFromNonTiedItem(int shippingGroupIndex = 1, int itemIndex = 1, int nontiedItemIndex = 1)
        {
            return
                WebDriver.GetElement(By.Id(PagePrefix + "_LI_NTSKU_NonTied_info_goalDealId_" + (shippingGroupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nontiedItemIndex - 1))).GetText(WebDriver);
        }

        public void CompleteGMOR(bool isGmorRequired = false)

        {
            if (BtnGmorBeginNextDone.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(20)))
            {
                BtnGmorBeginNextDone.Click(WebDriver);
                var gmorCount = int.Parse(LblGmoreCount.GetText(WebDriver).Split('/')[1].Trim());
                if (gmorCount > 0)
                {
                    for (int i = 0; i < gmorCount; i++)
                    {
                        BtnGmorBeginNextDone.Click(WebDriver);
                    }
                }


            }
            //Disabled below code to improve performance
            //while (BtnGmorBeginNextDone.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(15)))
            //{
            //    BtnGmorBeginNextDone.Click(WebDriver);
            //}
        }




        #endregion

        #region FT5
        public IWebElement BtnExpandAllOrCollapseAll(int index)
        {
            return WebDriver.FindElement(By.XPath("//*[@id='item_" + index + "']"));
        }

        public IWebElement LblContractCodePaymentTerms(int groupIndex = 1, int lineItemIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='shipping_group_Item_panel_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "\']/div[2]/div[2]/item-contract-details/div/div/div[3]/div[2]"));
        }
        #endregion

    }
}

