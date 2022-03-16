using System;
using Dsa.Pages.Quote;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using Dsa.DataModels;
using System.Collections.Generic;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Workflows;
using Dsa.Enums;

namespace Dsa.Pages.Order
{
    public class OrderReviewPage : DsaPageBase
    {
        private const string PagePrefix = "orderReview";
        public OrderReviewPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        public QuoteSummary Summary
        {
            get
            {
                return new QuoteSummary(WebDriver, PagePrefix);
            }
        }
        

        public QuotePage PageInformation
        {
            get { return new QuotePage(WebDriver, PagePrefix); }
        }


        #region Elements


public IWebElement LnkCurrentCustomerCompanyName { get { return WebDriver.GetElement(By.Id("currentCustomer_createCustomerHeaderLink1")); } }


public IWebElement LnkCurrentCustomerCustomerName { get { return WebDriver.GetElement(By.Id("currentCustomer_createCustomerHeaderLink2")); } }


public IWebElement TxtCurrentCustomerCustomerNumber { get { return WebDriver.GetElement(By.Id("currentCustomer_customerNumber")); } }


public IWebElement TxtCurrentCustomerCompanyNumber { get { return WebDriver.GetElement(By.Id("currentCustomer_context")); } }

        //-------------------------------------------

        //[FindsBy(How = How.Id, Using = "orderReview_createOrder")]
        //public IWebElement BtnSaveOrder;
        public IWebElement BtnSaveOrder { get { return WebDriver.GetElement(By.Id("orderReview_createOrder")); } }


public IWebElement BtnCancelOrder { get { return WebDriver.GetElement(By.Id("orderReview_cancelQuote")); } }


public IWebElement BtnOrderReviewGmorNext { get { return WebDriver.GetElement(By.Id("bootstro_nextBtn")); } }


public IWebElement BtnOrderReviewGmorLast { get { return WebDriver.GetElement(By.Id("bootstro_lastBtn")); } }


public IWebElement NextCount { get { return WebDriver.GetElement(By.ClassName("pd-right-10")); } }


public IWebElement BtnReviewOrderExpandLineItem { get { return WebDriver.GetElement(By.Id("orderReview_LI_1")); } }


public IWebElement LblReviewOrderGoalDealId { get { return WebDriver.GetElement(By.Id("orderReview_LI_info_goalDealId_1")); } }


public IWebElement OrderReviewPaymentInfoSectionArrow { get { return WebDriver.GetElement(By.Id("orderReview_payment_information_Toggle")); } }
    

public IWebElement OrderReviewSoldToInfoSectionArrow { get { return WebDriver.GetElement(By.XPath("//h1[contains(text(),'Sold to Customer Information')]")); } }


public IWebElement OrderReviewBillToZip { get { return WebDriver.GetElement(By.XPath("//div[@id='orderReview_billToAddress_section']//span[contains(text(), 'Postal')]//following-sibling::span[1]")); } }


public IWebElement OrderReviewSoldToZip { get { return WebDriver.GetElement(By.XPath("//label[contains(text(),'Postal Code')]/following-sibling::div")); } }


public IWebElement OrderReviewOfSoldToZip { get { return WebDriver.GetElement(By.Id("_soldToZip")); } }


public IWebElement OrderReviewBillToInfoSectionArrow { get { return WebDriver.GetElement(By.XPath("//h1[contains(text(),'Bill to Customer Information')]")); } }


public IWebElement OrderReviewRemainingBalance { get { return WebDriver.GetElement(By.Id("orderReview_payment_information_netterms1_cardholdername")); } }


public IWebElement OrderReviewPaymentTerm { get { return WebDriver.GetElement(By.Id("orderDetails_payment_information_netterms1_paymentterms")); } }


public IWebElement DivGmorDiv { get { return WebDriver.GetElement(By.ClassName("bootstro-backdrop")); } }


public IWebElement BtnGmorDone { get { return WebDriver.GetElement(By.Id("bootstro_lastBtn")); } }


public IWebElement BtnBeginGmor { get { return WebDriver.GetElement(By.Id("bootstro_nextBtn")); } }


public IWebElement BtnGmorNext { get { return WebDriver.GetElement(By.Id("bootstro_nextBtn")); } }

        //[FindsBy(How = How.XPath, Using = "//*[@id='bootstro_nextBtn' or @id='bootstro_lastBtn']")]
        //public IWebElement BtnGmorBeginNextDone;
        public IWebElement BtnGmorBeginNextDone { get { return WebDriver.GetElement(By.XPath("//*[@id='bootstro_nextBtn' or @id='bootstro_lastBtn']")); } }


public IWebElement LblOrderReviewSummaryLevelDfsRevenuePrice { get { return WebDriver.GetElement(By.XPath("//*[@id='orderReview_GI_revenue_Incentive_']")); } }

        [FindsBy(How = How.Id, Using = "orderReview_summary_finalPrice")]

public IWebElement LblReviewPageFinalPrice { get { return WebDriver.GetElement(By.XPath("//*[contains(@class,'col-md-6 financial final-price content-bold')]")); } }


public IWebElement OrderReviewTotalTax { get { return WebDriver.GetElement(By.Id("orderReview_summary_totalTaxAmount")); } }


public IWebElement BtnExpandCollapseAllGroups { get { return WebDriver.GetElement(By.Id("orderReview_expandCollapseAllGroups")); } }


public IWebElement BtnExpandItem { get { return WebDriver.GetElement(By.Id("orderReview_expandCollapseAllGroups")); } }

        //[FindsBy(How = How.XPath, Using = "//*[@class='popover-title']/span")]
        //public IWebElement LblGmoreCount;
        public IWebElement LblGmoreCount { get { return WebDriver.GetElement(By.XPath("//*[@class='popover-title']/span")); } }

        //[FindsBy(How = How.XPath, Using = "//*[@id='_confirm_ok']")]
        //public IWebElement BtnPaymentDialogBox;
        public IWebElement BtnPaymentDialogBox { get { return WebDriver.GetElement(By.XPath("//*[@id='_confirm_ok']")); } }

        //[FindsBy(How = How.XPath, Using = "//*[@id='_confirm']")]
        //public IWebElement PopupPaymentSevices;
        public IWebElement PopupPaymentSevices { get { return WebDriver.GetElement(By.XPath("//*[@id='_confirm']")); } }


public IWebElement LblSummaryLevelSmartPriceRevenue { get { return WebDriver.GetElement(By.XPath("//*[@id='orderReview_GI_smartPrice_Revenue_1']")); } }


public IWebElement OrderReviewAdditonalCheckoutFieldsArrow { get { return WebDriver.GetElement(By.XPath("//h5[contains(text(),'Custom Checkout Fields')]")); } }


public IWebElement topassemplylevel { get { return WebDriver.GetElement(By.XPath("//*[@id='orderReview_accordion_0_0']/div[2]/div/div/div[2]/div[4]/div[3]/order-item-tla-info/div/div[1]/p")); } }

        //[FindsBy(How = How.Id, Using = "orderReview_LI_productRsId")]
        //public IWebElement LblProductLevelRSid;


public IWebElement OrderReviewDiscount { get { return WebDriver.GetElement(By.Id("orderReview_SEItem_discount_off_list_0_0")); } }


public IWebElement FlexBillingDiscountNotificationMsg { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Submit Order Failed due to the Pre Order validation')]")); } }


public IList<IWebElement> LineItemCollpaseAll { get { return WebDriver.GetElements(By.ClassName("grid-btn")); } }
               

public IWebElement OrderReviewLineItemPromos { get { return WebDriver.GetElement(By.XPath("//*[contains(@id, 'orderReview_LI_D_promos_')]")); } }


public IWebElement OrderReviewPromo { get { return WebDriver.GetElement(By.XPath("//*[@id='orderDetails_D_Promos_45562']/a[1]")); } }


public IWebElement SellingEntity { get { return WebDriver.GetElement(By.Id("orderReview_orderEntity_title")); } }


public IWebElement SubscriptionsLnk { get { return WebDriver.GetElement(By.XPath("//h1[contains(text(), 'Subscriptions')]")); } }


public IWebElement OrderType { get { return WebDriver.FindElement(By.XPath("//div[@id='orderReview_orderType_label']//div"),TimeSpan.FromSeconds(10)); } }


public IWebElement OrderDetailsType { get { return WebDriver.GetElement(By.XPath("//label[@id='orderDetails_AllOrderHeader_orderType_0']/following-sibling::div")); } }

        //[FindsBy(How = How.XPath, Using = "//div[@class = 'bootstro-inner' and contains(text(),'Terms of Sale disclosure')]")]

public IWebElement TermsandConditions { get { return WebDriver.GetElement(By.XPath("//div[@class = 'bootstro-inner']")); } }

        public IWebElement GetShippingGrpTax(string index)
        {
            return WebDriver.FindElement(By.Id("orderReview_GI_tax_" + index));
        }

        public string GetSummarySelectedCadence()
        {
            return WebDriver.GetElement(By.XPath("//div[@class='smry-ctnr']//label[normalize-space()='Selected Cadence:']")).GetChildElement(By.XPath("./following-sibling::div")).GetText(WebDriver);
        }

        public string GetLblSummaryUpfrontPaymentAmount()
        {
            return WebDriver.GetElement(By.XPath("//div[@class='smry-ctnr']//label[normalize-space()='Upfront Payment:']")).GetChildElement(By.XPath("./following-sibling::div")).GetText(WebDriver);
        }

        public string GetLblSummaryUpfrontPaymentTax()
        {
            return WebDriver.GetElement(By.XPath("//div[@class='smry-ctnr']//label[normalize-space()='Tax on Upfront Amount:']")).GetChildElement(By.XPath("./following-sibling::div")).GetText(WebDriver);
        }

        public string GetLblSummaryTotalContractValue()
        {
            return WebDriver.GetElement(By.XPath("//div[@class='smry-ctnr']//label[normalize-space()='Total Contract Value:']")).GetChildElement(By.XPath("./following-sibling::div")).GetText(WebDriver);
        }

        public IWebElement InputCustomFieldAtIndex(int index = 0)
        {
            return WebDriver.GetElement(By.Id("customFieldValue_" + index));
        }

        public IList<IWebElement> ValidateLineItemDetails()
        {          
            return WebDriver
                    .FindElements(By.XPath("//div[@class='c-data-grid']"));
        }

        #endregion

        #region SolutionElements


public IWebElement UCIDRequestNotification { get { return WebDriver.GetElement(By.XPath("//*[@id='orderReview_GI_shippingAddress_0']/address/div/div[1]/div/div[1]")); } }


public IWebElement BeginGMORDialog { get { return WebDriver.GetElement(By.XPath(".//div[h3[contains(@text(),'Get My Order Right')]]")); } }


public IWebElement OPGmorScreenApp { get { return WebDriver.GetElement(By.XPath(".//div[contains(@class,'popover-inner')]/h3")); } }

        By BtnBeginGMOR = By.XPath(".//button[contains(text(),'Begin GMOR')]");

        By BeginGMORTextAppBy = By.XPath(".//div[contains(@text(),'Let's take a moment to review the details of this order against the customers PO.')]");

        #endregion

        //public IWebElement BtnBeginGmor
        //{
        //    get
        //    {
        //        return WebDriver.GetElements(By.Id("bootstro_nextBtn"))
        //            .FirstOrDefault(a => a.TagName == "button" && a.Text == "Begin GMOR");
        //    }
        //}

        public string ValidatePaymentMethod(string paymentMethod, int numberOfPayments)  
        {
            return WebDriver.FindElement(By.Id("orderDetails_payment_information_" + numberOfPayments + "_paymentmethod")).GetText(WebDriver);
        }

        public string ValidatePaymentAmount(string paymentMethod, int numberOfPayments)  
        {
            DsaUtil.WaitForElement(WebDriver.FindElement(By.Id("orderDetails_payment_information_" + numberOfPayments + "_amount")), WebDriver);
            return WebDriver.GetElement(By.Id("orderDetails_payment_information_" + numberOfPayments + "_amount")).GetText(WebDriver);
        }
        public IWebElement LblProductLevelRSid(int groupIndex = 1, int itemIndex = 1)
        {
            return WebDriver.GetElement(By.Id("orderReview_LI_productRsId_" + (groupIndex - 1) + "_" + (itemIndex - 1)));
        }

        public IWebElement ReviewOrderSolutionName(int? ShippingIndex)
        {
            return WebDriver.FindElement(By.Id("orderReview_solutionName_value_" + ShippingIndex + ""));
        }

        public IWebElement ReviewOrderSolutionNameTxt(int? ShippingIndex)
        {
            return WebDriver.FindElement(By.Id("orderReview_solutionName_label_" + ShippingIndex + ""));
        }

        public IWebElement VerifyListofPayments(int paymentmethodIndex = 1)
        {
            return WebDriver.GetElements(By.XPath("(//*[contains(@id,'_paymentmethod')])"))[paymentmethodIndex - 1];
        }

        public IWebElement VerifyListofAmount(int paymentamountIndex = 1)
        {

            return WebDriver.GetElements(By.XPath("(//*[contains(@id,'_amount')])"))[paymentamountIndex - 1];
        }
        public IWebElement ItemProductDescriptionOrderReview(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_productDescription_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
        }


        public OrderDetailsPage SaveOrder(bool isGmorRequired = false)
        {
            QuoteDetailsPage quoteDetailsPage = new QuoteDetailsPage(WebDriver);

            bool dupCheck = quoteDetailsPage.duplicateCheckCheckBoxYes.IsElementClickable(WebDriver, TimeSpan.FromSeconds(10));
            if (dupCheck)
            {
                quoteDetailsPage.duplicateCheckCheckBoxYes.Click(WebDriver);
                quoteDetailsPage.duplicateCheckContinue.Click(WebDriver);
            }

            CompleteGMOR(isGmorRequired);
            string[] tempArr = WebDriver.Url.Split('/');
            Logger.Write("Sales order id :" + tempArr[(tempArr.Length) - 1]);
            BtnSaveOrder.Click(WebDriver);
            bool isServicesdown = CheckforPaymentServices();
            if (isServicesdown == true)
                BtnSaveOrder.Click(WebDriver);
            return new OrderDetailsPage(WebDriver);
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

        public bool VerifyTermsText(string expectedText)

        {
            bool isTermsdisplayed = false;

            if (BtnGmorBeginNextDone.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(15)))
            {
                BtnGmorBeginNextDone.Click(WebDriver);
                var gmorCount = int.Parse(LblGmoreCount.GetText(WebDriver).Split('/')[1].Trim());
                if (gmorCount > 0)
                {
                    for (int i = 0; i < gmorCount; i++)
                    {
                        if (i == gmorCount-1)
                        {
                            string text =  WebDriver.FindElement(By.XPath("//div[@class = 'bootstro-inner' and contains(text(),'Terms of Sale disclosure')]")).Text;
                            text.Contains(expectedText);
                            isTermsdisplayed = true;
                        }
                        BtnGmorBeginNextDone.Click(WebDriver); 
                    }
                }
            }

            return isTermsdisplayed;
        }


        public bool CheckforPaymentServices()

        {

            if(new OrderDetailsPage(WebDriver).LblDpid.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(10)))
            {
                return false;
            }
            else if(PopupPaymentSevices.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(15)))
            {
                BtnPaymentDialogBox.Click(WebDriver);
                return true;
            }

            return false;

            //Saravana
            //if (PopupPaymentSevices.IsElementDisplayed(WebDriver, TimeSpan.FromSeconds(15)))
            //{
            //    BtnPaymentDialogBox.Click(WebDriver);
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
        public OrderReviewPage SaveOrdercheck(bool isGmorRequired = false)
        {
            CompleteGMOR(isGmorRequired);
           
            return new OrderReviewPage(WebDriver);
        }

        public string ApplyTlaItemsvaluestxt(int itemIndex)
        {
            return LnkItemLevelTLAtextbox(itemIndex).GetText(WebDriver);
        }


        public IWebElement LnkItemLevelTLAtextbox(int lineItemIndex = 1)
        {
            var lstwebelements = WebDriver.GetElements(By.XPath("//*[contains(@id,'orderReview_LI_info_tla_0_')]/span"), TimeSpan.FromSeconds(10));

            if (lstwebelements != null && lstwebelements.Count > 0)
            {
                return lstwebelements[lineItemIndex - 1];
            }
            return null;
        }

        public string GetGoalDealIdFromItem(int shippingGroupIndex = 1, int itemIndex = 1)
        {
            return
                WebDriver.GetElement(By.Id(PagePrefix + "_LI_info_goalDealId_" + (shippingGroupIndex - 1) + "_" + (itemIndex - 1)))
                    .GetText(WebDriver);
        }

        public string GetGoalDealIdFromNonTiedItem(int shippingGroupIndex = 1, int itemIndex = 1, int nontiedItemIndex = 1)
        {
            //return WebDriver.GetElement(By.Id(PagePrefix + "_LI_NTSKU_NonTied_info_goalDealId_" + (shippingGroupIndex - 1) + "_" +(itemIndex - 1) + "_" + (nontiedItemIndex - 1))).GetText(WebDriver);
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_info_goalDealId_" + (shippingGroupIndex - 1) + "_" + (itemIndex - 1) + "_" + (nontiedItemIndex - 1))).GetText(WebDriver);
        }
       
        public bool IsPromotionAvailable(string promotionName)
        {
            var promoText = OrderReviewLineItemPromos.Text;
            return promoText.Contains(promotionName);
        }

        #region SolutionsCode
        public bool ValidateGMORScreensOPGMORUsers(string gmorScreens)
        {
            bool result = false;
            string[] GmorScreens = gmorScreens.Split('|');
            WebDriver.VerifyBusyOverlayNotDisplayed();
            DsaUtil.WaitForElement(BtnBeginGmor, WebDriver);

            if (WebElement.ElementExists(BeginGMORDialog, BeginGMORTextAppBy) && WebElement.ElementExists(BeginGMORDialog, BtnBeginGMOR))
            {
                BtnBeginGmor.Click();
                for (int i = 0; i < GmorScreens.Length; i++)
                {
                    int j = i + 1;
                    string k = j.ToString();
                    string Fulltext = k + " / " + GmorScreens.Length.ToString() + GmorScreens[i];
                    int DoneButtonAtLastStep = GmorScreens.Length - 1;
                    if (Fulltext.ToLower().Equals(OPGmorScreenApp.Text.ToLower()) && i != DoneButtonAtLastStep)
                    {
                        result = true;
                        DsaUtil.WaitForElement(BtnOrderReviewGmorNext, WebDriver);
                        BtnOrderReviewGmorNext.Click();
                    }
                    else if (Fulltext.ToLower().Equals(OPGmorScreenApp.Text.ToLower()) && i == GmorScreens.Length - 1)
                    {
                        result = true;
                        DsaUtil.WaitForElement(BtnGmorDone, WebDriver);
                        BtnGmorDone.Click();
                    }
                    else
                    {
                        break;
                    }
                }

            }

            return result;
        }

        public void ExpandAllProductsForSolutionQuotes()
        {
            //We have to click expand collapse button twice to see product configuration expanded
            BtnExpandItem.Click();
            BtnExpandItem.Click();

            WebDriver.VerifyBusyOverlayNotDisplayed();

            //Expand each product
            var products = WebDriver.GetElements(By.XPath("//*[contains(@id,'orderReview_LI_0_')]"));
            foreach (var row in products)
            {
                row.Click();
                WebDriver.VerifyBusyOverlayNotDisplayed();

            }
        }
        #endregion 

        #region VP Elements
        public IWebElement ItemLevelserviceListPriceLabel(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_totalListPrice_serviceListPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"), TimeSpan.FromSeconds(10));
        }

        public IWebElement ByLblItemLevelserviceListPrice(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_totalListPrice_serviceListPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
        }

        public IWebElement ItemLevelnonServiceListPriceLabel(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_totalListPrice__nonServiceListPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"), TimeSpan.FromSeconds(10));
        }

        public IWebElement ByLblItemLevelnonServiceListPrice(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_totalListPrice__nonServiceListPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
        }

        public IWebElement ItemLevelserviceSellingPriceLabel(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_pricingInformation_serviceSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"), TimeSpan.FromSeconds(10));
        }

        public IWebElement ByLblItemLevelserviceSellingPrice(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_pricingInformation_serviceSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
        }

        public IWebElement ItemLevelnonServiceSellingPriceLabel(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.XPath("//*[@id='" + PagePrefix + "_LI_pricingInformation_nonServiceSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1) + "']/../label"), TimeSpan.FromSeconds(10));
        }

        public IWebElement ByLblItemLevelnonServiceSellingPrice(int lineItemIndex = 1, int groupIndex = 1)
        {
            return WebDriver.GetElement(By.Id(PagePrefix + "_LI_pricingInformation_nonServiceSellingPrice_" + (groupIndex - 1) + "_" + (lineItemIndex - 1)));
        }

        public ItemQuoteData GetVPLineItemValues(int groupIndex = 1, int itemIndex = 1, bool contractCodeRequired = false)
        {
            Logger.Write("Getting VP Values for Item " + itemIndex + " in Shipping Group " + groupIndex);
            Logger.Write("-------------------------");

            var itemQuoteData = new ItemQuoteData
            {
                SupportServiceListPrice = Convert.ToDouble(ByLblItemLevelserviceListPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
                HardwareOsListPrice = Convert.ToDouble(ByLblItemLevelnonServiceListPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
                SupportServiceSellingPrice = Convert.ToDouble(ByLblItemLevelserviceSellingPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1)),
                HardwareOsSellingPrice = Convert.ToDouble(ByLblItemLevelnonServiceSellingPrice(itemIndex, groupIndex).GetText(WebDriver).Substring(1))
            };

            return itemQuoteData;
        }


        public bool IsserviceListpriceLebelVisible()
        {
            if (ItemLevelserviceListPriceLabel() != null)
            {
                if (ItemLevelserviceListPriceLabel().GetText(WebDriver).Contains("Support & Services List Price"))
                    return true;
            }
            return false;
        }
        public bool IshardwareListpriceLebelVisible()
        {
            if (ItemLevelnonServiceListPriceLabel() != null)
            {
                if (ItemLevelnonServiceListPriceLabel().GetText(WebDriver).Contains("Hardware & OS List Price"))
                    return true;
            }
            return false;
        }
        public bool IsserviceSellingtpriceLebelVisible()
        {
            if (ItemLevelserviceSellingPriceLabel() != null)
            {
                if (ItemLevelserviceSellingPriceLabel().GetText(WebDriver).Contains("Support & Services Selling Price"))
                    return true;
            }
            return false;
        }
        public bool IshardwareSellingpriceLebelVisible()
        {
            if (ItemLevelnonServiceSellingPriceLabel() != null)
            {
                if (ItemLevelnonServiceSellingPriceLabel().GetText(WebDriver).Contains("Hardware & OS Selling Price"))
                    return true;
            }
            return false;
        }

        public bool IsVPParametersDisplayed()
        {
            if (IsserviceListpriceLebelVisible() && IshardwareListpriceLebelVisible() && IsserviceSellingtpriceLebelVisible() && IshardwareSellingpriceLebelVisible())
            {
                return true;
            }
            return false;
        }

        #endregion

        #region Digital Fulfillment

        public IWebElement DigitalFulfillmentEmail_Expanded() => WebDriver.GetElement(By.XPath("//order-review/div/div[1]/or-df-emails/div[1]"));

        public IList<IWebElement> DF_Emails() => WebDriver.GetElements(By.Id("email_value_0"));

        public OrderReviewPage PaymentToOrderReview(EmailConfirmationPage emailConfPage,bool isGmorRequired = false)
        {
            emailConfPage.BtnEmailConfirmationNext().Click(WebDriver);
            CreateOrderWorkflow.EnterPaymentData(WebDriver, 1, PaymentMethodType.WireTransfer);
            new PaymentsPage(WebDriver).PaymentMethodNext();
            QuoteDetailsPage quoteDetailsPage = new QuoteDetailsPage(WebDriver);

            bool dupCheck = quoteDetailsPage.duplicateCheckCheckBoxYes.IsElementClickable(WebDriver, TimeSpan.FromSeconds(10));
            if (dupCheck)
            {
                quoteDetailsPage.duplicateCheckCheckBoxYes.Click(WebDriver);
                quoteDetailsPage.duplicateCheckContinue.Click(WebDriver);
            }

            CompleteGMOR(isGmorRequired);
            string[] tempArr = WebDriver.Url.Split('/');
            Logger.Write("Sales order id :" + tempArr[(tempArr.Length) - 1]);
            return new OrderReviewPage(WebDriver);
        }
        #endregion

        public IWebElement DTCPEsad()
        {
            return WebDriver.GetElement(By.Id("orderReview_LI_ESAD_Max_0_0"));
        }

        public string GetSnowRequestID()
        {
            return WebDriver.FindElement(By.Id("orderReview_SnowID"), TimeSpan.FromSeconds(10)).GetText(WebDriver);
        }

        public string GetLeBuCc()
        {
            return WebDriver.FindElement(By.XPath("//div[@id='orderReview_LEBUCC']/label")).GetText(WebDriver);
        }

        public string GetOrderType()
        {
            return OrderType.GetText(WebDriver);
        }
    }
}
