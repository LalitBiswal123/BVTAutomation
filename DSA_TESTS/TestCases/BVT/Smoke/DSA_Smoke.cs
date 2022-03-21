using System;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Pages.Order;
using Dsa.Pages.PCFConvergence;
using Dsa.Utils;
using Dsa.Workflows;
using Dsa.Pages.Quote;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsa.Enums;
using FluentAssertions;
using HomeWorkFlow = Dsa.Workflows.HomeWorkflow;
using SolutionsWorkFlow = Dsa.Workflows.Solutions;
using Dsa.Pages.Solutions;
//using DsaTest.TestData.NonCsv;
using Dsa.Pages.POM;
using System.Data;

namespace DsaTest.TestCases.BVT.Smoke
{
    [TestClass]
    public class PCFConvergenceDVTs : DsaTestCaseBase
    {
        log4net.ILog Log = Dsa.Utils.WebDriverUtil.Log;

        [TestMethod]
        [Owner("Lalit Biswal")]
        [Description("DSA workflow to create quote and order.")]
        //Provider Name, Connection String, Table Name, Access method.
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"TestData\Shipping.xml", "Row", DataAccessMethod.Sequential)]
        [DeploymentItem(@"TestData\Shipping.xml", "TestData")]
        public void DSA_Quote_to_Order_CO19()
        {
            var row = TestContext.DataRow;
            var orderCodes = row["Order_Code_Comp19"].ToString();
            var skus = row["Skus_19"].ToString();
            var customerNumber = row["Customer_Number_Comp19"].ToString();

            var products = DsaUtil.GetProductDataFromCsv(orderCodes, skus);
            CreateQuoteWorkflow.CreateQuoteFromCustomerSearch(TestWebDriver, customerNumber, products, null, null, false);

            //Save Quote and Checkout
            new PCFQuoteSummaryPage(TestWebDriver).SaveQuote();
            new PCFQuoteSummaryPage(TestWebDriver).WaitForQuoteValidationToComplete();
            string quoteNo = new PCFQuoteSummaryPage(TestWebDriver).GetQuoteNumber();
            Log.Info("Created Quote number : " + quoteNo);
            Log.Info("**Output: " + quoteNo + "**");


            Log.Info("Click Continue To Checkout");
            new PCFQuoteSummaryPage(TestWebDriver).BtnContinueToCheckout.Click();
            new PCFQuoteSummaryPage(TestWebDriver).SalesRepMismatchPopup();

            Log.Info("Click Continue on Complaiance & Notification Page");
            TestWebDriver.PCFVerifyBusyOverlayNotDisplayed();
            new PCFComplianceNotificationsPage(TestWebDriver).ContinueButton.Click();
            TestWebDriver.PCFVerifyBusyOverlayNotDisplayed();

            //Payment page
            new ChannelPaymentPage(TestWebDriver).SelectPaymentMethod(TestWebDriver, PaymentMethodType.WireTransfer);
            new ChannelPaymentPage(TestWebDriver).BtnContinueToCheckout.Click(TestWebDriver);

            Log.Info("Begin GMOR Here");
            //TestWebDriver.VerifyBusyOverlayNotDisplayed_PCFConvergence();
            new PCFOrderReviewPage(TestWebDriver).CompleteGMOR();

            Log.Info("Place Order Here");
            new PCFOrderReviewPage(TestWebDriver).PlaceOrder();

            Log.Info("Get DPID from Confirmation Page");
            new PCFOrderDetailsPage(TestWebDriver).WaitForOrderToLoad();

            string dpid = new PCFOrderDetailsPage(TestWebDriver).dpidLabel.GetText(TestWebDriver, TimeSpan.FromSeconds(3));

            Log.Info("Successfully Placed Order for  DPID " + dpid);
            Assert.IsTrue(dpid.Contains("200"), "Unable to place Order Test Fail");
        }

        [TestMethod]
        [Owner("Lalit")]
        [Description("Create a new draft quote and search it")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"TestData\CreateOrder70.xml", "Row", DataAccessMethod.Sequential)]
        [DeploymentItem(@"TestData\CreateOrder70.xml", "TestData")]
        public void DSA_Create_Search_DraftQuote()
        {
            var row = TestContext.DataRow;
            var customerNumber = row["Customer_Number"].ToString();
            var catalogName = row["Catalog_Name"].ToString();
            var orderCodes = row["Order_Codes"].ToString();
            var skus = row["Skus"].ToString();
            var contractCode = row["Contract_Code"].ToString();
            var quoteName = row["Quote_Name"].ToString();

            var catalog = (Catalogs)Enum.Parse(typeof(Catalogs), catalogName);
            var products = DsaUtil.GetProductDataFromCsv(orderCodes, skus);
            HomeWorkflow.GoToQuoteCreatePage(TestWebDriver);
            CreateQuoteWorkflow.CreateQuoteFromMenu(TestWebDriver, catalog, customerNumber, products, contractCode,
                quoteName, false);
            //validate ordercode and sku in quote
            CreateQuoteWorkflow.ValidateOrderAndSku(TestWebDriver, products);
            int itemCount = new CreateQuotePage(TestWebDriver).GetItemCountFromMastHead();
            string finalPrice = new CreateQuotePage(TestWebDriver).Summary.LblSummaryFinalPrice.GetText(TestWebDriver);

            string draftQuoteNumber = new CreateQuotePage(TestWebDriver).LblDraftQuoteNumber.GetText(TestWebDriver);

            // Go to home page
            HomeWorkflow.GoToQuoteSearchPage(TestWebDriver).QuoteSearchByDraftQuoteNumber(draftQuoteNumber);

            //Assert
            new CreateQuotePage(TestWebDriver).LblDraftQuoteNumber.GetText(TestWebDriver).Should().Be(draftQuoteNumber);
            new CreateQuotePage(TestWebDriver).TxtCurrentCustomerCustomerNumber.GetText(TestWebDriver).Should()
                .Be(customerNumber);
            new CreateQuotePage(TestWebDriver).Summary.LblSummaryFinalPrice.GetText(TestWebDriver).Should()
                .Be(finalPrice);
            new CreateQuotePage(TestWebDriver).GetItemCountFromMastHead().Should().Be(itemCount);
            Log.Info("**Output: " + draftQuoteNumber + "**");
        }
    }
}
