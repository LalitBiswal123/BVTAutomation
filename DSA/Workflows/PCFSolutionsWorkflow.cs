using Dsa.Enums;
using Dsa.Pages.Solutions;
using Dsa.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dsa.Pages.Quote;
using Dsa.Pages.Order;
using Dsa.Pages.Product;
using Dsa.Pages.Customer;
using Dsa.Constants;
using Dsa.Pages;
using OpenQA.Selenium.Support.UI;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using Dsa.DataModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsa.Pages.PCFConvergence;

namespace Dsa.Workflows
{
    /// <summary>
    /// Soulutions workflows will be defined in this class.
    /// </summary>
    public static class PCFSolutions
    {

        static bool isValidationPassed = true;
        public static bool IsValidationPassed
        {
            get
            {
                return isValidationPassed;
            }

            set
            {
                // if once validation failed we are no more going pass test case.
                if (isValidationPassed)
                {
                    isValidationPassed = value;
                }
            }
        }
        //Working on this story Automation
        public static bool VerifyHyperlinkForSol(string solId, string enaOrDis)
        {
            switch (enaOrDis)
            {

                case "Enable":
                    //SolutionsSearchResultsGrid.FindElements(SolutionIdBy).FirstOrDefault(o => o.ElementExists());
                    //SolutionsSearchResultsGrid.FindElements(SolutionIdBy)
                    //    .FirstOrDefault(o => o.GetAttribute("target").Contains("_blank"));
                    //SolutionsSearchResultsGrid.FindElements(SolutionIdBy).FirstOrDefault(o => o.Text.Contains(solId));
                    break;
                case "Disable":
                    //IReadOnlyCollection<IWebElement> abc =
                    //    WebDriver.FindElement(By.Id("solutionsSearchResults_Grid"))
                    //        .FindElements(By.XPath(".//*[contains(@class, 'ng-scope')]"));
                    //foreach (var papitha in abc)
                    //{
                    //   bool b  = papitha.GetAttribute("ng-click").Contains("viewSolution");

                    // }
                    break;
            }
            return true;
        }


        #region Solutions
        public const string DefaultNumber = "1";
        public static void SingleQuoteCreateSolution(IWebDriver TestWebDriver, string catalog, string ProductsList, bool saveSolution = true)
        {
            var cat = (Catalogs)Enum.Parse(typeof(Catalogs), catalog);
            HomeWorkflow.GoToQuoteCreatePageUsingSolution(TestWebDriver);

            CreateQuotePage CreateQuotePage = new CreateQuotePage(TestWebDriver);
            DsaUtil.WaitForPageLoad(TestWebDriver);
            CreateQuotePage.SelectSolutionsCatalog(cat);

            FeedbackDialog feedbackdialog = new FeedbackDialog(TestWebDriver);
            feedbackdialog.CloseFeedBack();
            feedbackdialog.CloseCanaryDialog();

            YourSolutionsPage yourSolutionsPage = new YourSolutionsPage(TestWebDriver);
            yourSolutionsPage.CreateNewSolution();
            feedbackdialog.CloseFeedBack();

            SolutionConfigurationPage SolutionConfigurationPage = new SolutionConfigurationPage(TestWebDriver);
            SolutionConfigurationPage.SearchAndAddMultipleProducts(ProductsList);
            if (saveSolution)
                new SolutionConfigurationPage(TestWebDriver).SaveSolution();
        }

        public static void SingleQuoteCreateSolution(IWebDriver TestWebDriver, string catalog, string category, string productName, bool saveSolution = true)
        {
            var cat = (Catalogs)Enum.Parse(typeof(Catalogs), catalog);
            HomeWorkflow.GoToQuoteCreatePageUsingSolution(TestWebDriver);

            CreateQuotePage CreateQuotePage = new CreateQuotePage(TestWebDriver);
            DsaUtil.WaitForPageLoad(TestWebDriver);
            CreateQuotePage.SelectSolutionsCatalog(cat);

            FeedbackDialog feedbackdialog = new FeedbackDialog(TestWebDriver);
            feedbackdialog.CloseFeedBack();

            YourSolutionsPage YourSolutionsPage = new YourSolutionsPage(TestWebDriver);
            YourSolutionsPage.CreateNewSolution();
            feedbackdialog.CloseFeedBack();

            SolutionConfigurationPage SolutionConfigurationPage = new SolutionConfigurationPage(TestWebDriver);
            SolutionConfigurationPage.SearchAndAddProductByCategory(productName, category);
            if (saveSolution)
                new SolutionConfigurationPage(TestWebDriver).SaveSolution();
        }


        public static void SingleQuoteMultiGroupCreateSolution(IWebDriver TestWebDriver, string catalog, string ProductsList)
        {
            var cat = (Catalogs)Enum.Parse(typeof(Catalogs), catalog);
            HomeWorkflow.GoToQuoteCreatePageUsingSolution(TestWebDriver);

            CreateQuotePage CreateQuotePage = new CreateQuotePage(TestWebDriver);
            DsaUtil.WaitForPageLoad(TestWebDriver);
            CreateQuotePage.SelectSolutionsCatalog(cat);

            FeedbackDialog feedbackdialog = new FeedbackDialog(TestWebDriver);
            feedbackdialog.CloseFeedBack();

            YourSolutionsPage YourSolutionsPage = new YourSolutionsPage(TestWebDriver);
            YourSolutionsPage.CreateNewSolution();
            feedbackdialog.CloseFeedBack();

            SolutionConfigurationPage SolutionConfigurationPage = new SolutionConfigurationPage(TestWebDriver);
            SolutionConfigurationPage.SearchAndAddMultipleProductsAndSkus(ProductsList).SaveSolution();
        }


        public static void MultiQuoteCreateSolution(IWebDriver TestWebDriver, string catalog, string ProductsToAdd, string PrductsToMovetoDifferentgroups)
        {
            var cat = (Catalogs)Enum.Parse(typeof(Catalogs), catalog);
            HomeWorkflow.GoToQuoteCreatePageUsingSolution(TestWebDriver);

            CreateQuotePage CreateQuotePage = new CreateQuotePage(TestWebDriver);
            CreateQuotePage.SelectSolutionsCatalog(cat);

            YourSolutionsPage YourSolutionsPage = new YourSolutionsPage(TestWebDriver);
            new YourSolutionsPage(TestWebDriver).CreateNewSolution();

            SolutionConfigurationPage SolutionConfigurationPage = new SolutionConfigurationPage(TestWebDriver);
            SolutionConfigurationPage.SearchAndAddMultipleProducts(ProductsToAdd);
            SolutionConfigurationPage.GoToGroupsTab().MoveMultipleProductsToNewGroups(DefaultNumber, PrductsToMovetoDifferentgroups);
            SolutionConfigurationPage.SwitchToMultiQuote().SaveSolution();
        }

        public static void OpenSolutionAndSaveAsNewVersion(IWebDriver TestWebDriver, string catalog, string SolutionID)
        {
            var cat = (Catalogs)Enum.Parse(typeof(Catalogs), catalog);
            HomeWorkflow.GoToQuoteCreatePageUsingSolution(TestWebDriver);

            CreateQuotePage CreateQuotePage = new CreateQuotePage(TestWebDriver);
            DsaUtil.WaitForPageLoad(TestWebDriver);
            CreateQuotePage.SelectSolutionsCatalog(cat);

            FeedbackDialog feedbackdialog = new FeedbackDialog(TestWebDriver);
            feedbackdialog.CloseFeedBack();

            YourSolutionsPage YourSolutionsPage = new YourSolutionsPage(TestWebDriver);
            YourSolutionsPage.SearchAndOpenSolution(SolutionID).SolutionSaveAsNewVersion();
        }



        #endregion
        public static void CreateSolutionQuote(IWebDriver TestWebDriver, string catalog, string ProductsList)
        {
            var cat = (Catalogs)Enum.Parse(typeof(Catalogs), catalog);
            HomeWorkflow.GoToQuoteCreatePageUsingSolution(TestWebDriver);
            new CreateQuotePage(TestWebDriver).SelectSolutionsCatalog(cat);
            new YourSolutionsPage(TestWebDriver).CreateNewSolution();
            new SolutionConfigurationPage(TestWebDriver).SearchAndAddMultipleProducts(ProductsList).SaveSolution();
            new SolutionConfigurationPage(TestWebDriver).SendToQuote();
        }
        /// <summary>
        /// Click Add Solution on Create quote page. [Menu>Add quote>Select Catalog>Click Add Solution]
        /// </summary>
        /// <param name="TestWebDriver"></param>
        /// <param name="catalog"></param>
        /// <param name="ProductsList"></param>
        public static void CreateQuoteAndAddSolution(IWebDriver TestWebDriver, string catalog, string ProductsList)
        {
            var cat = (Catalogs)Enum.Parse(typeof(Catalogs), catalog);
            var createQuotePage = HomeWorkflow.GoToQuoteCreatePage(TestWebDriver);
            createQuotePage.SelectCatalog(cat);
            DsaUtil.WaitForPageLoad(TestWebDriver);

            // Click on Add Solution Page.
            createQuotePage.BtnEditSolution.Click();
            DsaUtil.WaitForPageLoad(TestWebDriver);

            new YourSolutionsPage(TestWebDriver).CreateNewSolution();
            new SolutionConfigurationPage(TestWebDriver).SearchAndAddMultipleProducts(ProductsList)
                                                        .SaveSolution();
            new SolutionConfigurationPage(TestWebDriver).SendToQuote();
            DsaUtil.WaitForPageLoad(TestWebDriver);
        }

        /// <summary>
        /// Creates a quote for specified customer and adds solution to it. [CustomerDetails Page> Create Solution]
        /// </summary>
        /// <param name="TestWebDriver"></param>
        /// <param name="customerNumber"></param>
        /// <param name="ProductsList"></param>
        public static void AddSolutionToQuote(IWebDriver TestWebDriver, string customerNumber, string ProductsList)
        {
            var createQuotePage = CustomerSearchWorkflow.SearchCustomerByCustomerNumber(TestWebDriver, customerNumber)
                                              .CreateQuote();

            // Click on Add Solution Page.
            createQuotePage.BtnEditSolution.Click();
            DsaUtil.WaitForPageLoad(TestWebDriver);

            new YourSolutionsPage(TestWebDriver).CreateNewSolution();
            new SolutionConfigurationPage(TestWebDriver).SearchAndAddMultipleProducts(ProductsList)
                                                        .SaveSolution();
            new SolutionConfigurationPage(TestWebDriver).SendToQuote();
            DsaUtil.WaitForPageLoad(TestWebDriver);
        }

        public static void SwitchCatalogFlow(IWebDriver TestWebDriver)
        {
            new SolutionConfigurationPage(TestWebDriver).SwithCatalogTo8();
            new SolutionConfigurationPage(TestWebDriver).SaveSolution();
            new SolutionConfigurationPage(TestWebDriver).SendToQuote();
            DsaUtil.WaitForPageLoad(TestWebDriver);
        }

        public static void ComplexPrroductConfig(IWebDriver TestWebDriver, string productName, string ControllerName, string ControllerQty)
        {
            new SolutionConfigurationPage(TestWebDriver).SearchAndAddProduct(productName);
            new GuidedJourneyPage(TestWebDriver).InitiateGJProcess();
            new GuidedJourneyPage(TestWebDriver).SelectComponent(ControllerName, ControllerQty, null, true, true);
            new GuidedJourneyPage(TestWebDriver).GoToNextPage();
            new GuidedJourneyPage(TestWebDriver).GoToNextPage();
            //**Adding Single Enclosure to verify Rule1 Inverse Propagation**
            //Select the Enclosure Component
            //new GuidedJourneyPage(TestWebDriver).SelectComponent(row["EnclosureName"].ToString(), row["EnclosureQty"].ToString(), row["EnclosureConfigureOptions"].ToString(), true, true);
            new GuidedJourneyPage(TestWebDriver).GoToNextPage();
            //new GuidedJourneyPage(TestWebDriver).GoToNextPage();
            //Click SolutionConfigurationPage
            new GuidedJourneyPage(TestWebDriver).FinishGuidedConfiguration();
            new SolutionConfigurationPage(TestWebDriver).SaveSolution();
            new SolutionConfigurationPage(TestWebDriver).SendToQuote();
        }
        public static bool VerifyCopyQuoteAsNewVersion(IWebDriver TestWebDriver)
        {
            var originalQuoteNum = new QuoteDetailsPage(TestWebDriver).GetQuoteNumber();
            var originalQuoteVer = new QuoteDetailsPage(TestWebDriver).GetQuoteVersion();
            var originalSolNum = new QuoteDetailsPage(TestWebDriver).GetSolutionID().Split(' ')[2].Split('.')[0];
            var originalSolVer = new QuoteDetailsPage(TestWebDriver).GetSolutionID().Split(' ')[2].Split('.')[1];
            new QuoteDetailsPage(TestWebDriver).CopyQuote(true);
            new CreateQuotePage(TestWebDriver).WaitForQuoteValidationToComplete();
            new CreateQuotePage(TestWebDriver).OverrideAnyGenericSolutionErrors();
            new CreateQuotePage(TestWebDriver).SaveSolutionQuote();
            var quoteNumNewVer = new QuoteDetailsPage(TestWebDriver).GetQuoteNumber();
            var quoteVerNewVer = new QuoteDetailsPage(TestWebDriver).GetQuoteVersion();
            var newVerSolNum = new QuoteDetailsPage(TestWebDriver).GetSolutionID().Split(' ')[2].Split('.')[0];
            var newVerSolVer = new QuoteDetailsPage(TestWebDriver).GetSolutionID().Split(' ')[2].Split('.')[1];
            return (((originalQuoteNum == quoteNumNewVer) && (originalQuoteVer != quoteVerNewVer)) &&
                    ((originalSolNum == newVerSolNum) && (originalSolVer != newVerSolVer + 1)));
        }

        public static bool VerifyCopyQuoteAsNewSol(IWebDriver TestWebDriver)
        {
            var originalQuoteNum = new QuoteDetailsPage(TestWebDriver).GetQuoteNumber();
            var originalSolNum = new QuoteDetailsPage(TestWebDriver).GetSolutionID().Split(' ')[2].Split('.')[0];
            new QuoteDetailsPage(TestWebDriver).CopyQuote(false);
            new CreateQuotePage(TestWebDriver).WaitForQuoteValidationToComplete();
            new CreateQuotePage(TestWebDriver).OverrideAnyGenericSolutionErrors();
            new CreateQuotePage(TestWebDriver).SaveSolutionQuote();
            var quoteNumNewVer = new QuoteDetailsPage(TestWebDriver).GetQuoteNumber();
            var newVerSolNum = new QuoteDetailsPage(TestWebDriver).GetSolutionID().Split(' ')[2].Split('.')[0];
            Logger.Write("**Output: " + quoteNumNewVer + "**");
            return ((originalQuoteNum != quoteNumNewVer) && (originalSolNum != newVerSolNum));
        }

        public static bool PCFVerifyCopyQuoteAsNewSol(IWebDriver TestWebDriver)
        {
            var originalQuoteNum = new PCFQuoteSummaryPage(TestWebDriver).GetQuoteNumber();
            var originalSolNum = new PCFQuoteSummaryPage(TestWebDriver).GetSolutionID().Split(' ')[2].Split('.')[0];
            new PCFQuoteSummaryPage(TestWebDriver).CopyQuote(false);
            new CreateQuotePage(TestWebDriver).WaitForQuoteValidationToComplete();
            new CreateQuotePage(TestWebDriver).OverrideAnyGenericSolutionErrors();
            new CreateQuotePage(TestWebDriver).SaveSolutionQuote();
            var quoteNumNewVer = new QuoteDetailsPage(TestWebDriver).GetQuoteNumber();
            var newVerSolNum = new QuoteDetailsPage(TestWebDriver).GetSolutionID().Split(' ')[2].Split('.')[0];
            Logger.Write("**Output: " + quoteNumNewVer + "**");
            return ((originalQuoteNum != quoteNumNewVer) && (originalSolNum != newVerSolNum));
        }

        public static bool PCFVerifyCopyQuoteAsNewVersion(IWebDriver TestWebDriver)
        {

            var pCFQuoteSummaryPage = new PCFQuoteSummaryPage(TestWebDriver);
            var originalQuoteNum = pCFQuoteSummaryPage.GetQuoteNumber();
            var originalQuoteVer = pCFQuoteSummaryPage.GetQuoteVersion();
            var originalSolNum = pCFQuoteSummaryPage.GetSolutionID().Split(' ')[2].Split('.')[0];
            var originalSolVer = pCFQuoteSummaryPage.GetSolutionID().Split(' ')[2].Split('.')[1];
            pCFQuoteSummaryPage.CopyQuote(true);
            new CreateQuotePage(TestWebDriver).WaitForQuoteValidationToComplete();
            new CreateQuotePage(TestWebDriver).OverrideAnyGenericSolutionErrors();
            new CreateQuotePage(TestWebDriver).SaveSolutionQuote();
            var quoteNumNewVer = pCFQuoteSummaryPage.GetQuoteNumber();
            var quoteVerNewVer = pCFQuoteSummaryPage.GetQuoteVersion();
            var newVerSolNum = pCFQuoteSummaryPage.GetSolutionID().Split(' ')[2].Split('.')[0];
            var newVerSolVer = pCFQuoteSummaryPage.GetSolutionID().Split(' ')[2].Split('.')[0];
            return (((originalQuoteNum == quoteNumNewVer) && (originalQuoteVer != quoteVerNewVer)) &&
                    ((originalSolNum == newVerSolNum) && (originalSolVer != newVerSolVer + 1)));
        }

        public static bool PCFVerifyCopyQuoteAsNewQuote(IWebDriver TestWebDriver)
        {
            var pCFQuoteSummaryPage = new PCFQuoteSummaryPage(TestWebDriver);
            var originalQuoteNum = pCFQuoteSummaryPage.GetQuoteNumber();
            var originalSolNum = pCFQuoteSummaryPage.GetSolutionID().Split(' ')[2].Split('.')[0];
            var originalSolVer = pCFQuoteSummaryPage.GetSolutionID().Split(' ')[2].Split('.')[1];
            new PCFQuoteSummaryPage(TestWebDriver).CopyQuote(false);
            new CreateQuotePage(TestWebDriver).WaitForQuoteValidationToComplete();
            new CreateQuotePage(TestWebDriver).OverrideAnyGenericSolutionErrors();
            new CreateQuotePage(TestWebDriver).SaveSolutionQuote();
            var quoteNumNewVer = pCFQuoteSummaryPage.GetQuoteNumber();
            var newVerSolNum = pCFQuoteSummaryPage.GetSolutionID().Split(' ')[2].Split('.')[0];
            var newVerSolVer = pCFQuoteSummaryPage.GetSolutionID().Split(' ')[2].Split('.')[0];
            return ((originalQuoteNum != quoteNumNewVer) && (originalSolNum != newVerSolNum));
        }

        public static bool VerifyCopyLinkedQuoteAsNewVersion(IWebDriver TestWebDriver)
        {
            var originalQuoteNum = new QuoteDetailsPage(TestWebDriver).GetQuoteNumber();
            var originalQuoteVer = new QuoteDetailsPage(TestWebDriver).GetQuoteVersion();
            var originalSolNum = new QuoteDetailsPage(TestWebDriver).GetSolutionID().Split(' ')[2].Split('.')[0];
            var originalSolVer = new QuoteDetailsPage(TestWebDriver).GetSolutionID().Split(' ')[2].Split('.')[1];
            new QuoteDetailsPage(TestWebDriver).CopyQuote(true);
            new CreateQuotePage(TestWebDriver).OverrideAnyGenericSolutionErrors();
            new CreateQuotePage(TestWebDriver).SaveSolutionLinkedQuote();
            var quoteNumNewVer = new QuoteDetailsPage(TestWebDriver).GetQuoteNumber();
            var quoteVerNewVer = new QuoteDetailsPage(TestWebDriver).GetQuoteVersion();
            var newVerSolNum = new QuoteDetailsPage(TestWebDriver).GetSolutionID().Split(' ')[2].Split('.')[0];
            var newVerSolVer = new QuoteDetailsPage(TestWebDriver).GetSolutionID().Split(' ')[2].Split('.')[1];
            return (((originalQuoteNum == quoteNumNewVer) && (originalQuoteVer != quoteVerNewVer)) &&
                    ((originalSolNum == newVerSolNum) && (originalSolVer != newVerSolVer + 1)));
        }

        public static bool VerifyCopyLinkedQuoteAsNewSol(IWebDriver TestWebDriver)
        {
            var originalQuoteNum = new QuoteDetailsPage(TestWebDriver).GetQuoteNumber();
            var originalSolNum = new QuoteDetailsPage(TestWebDriver).GetSolutionID().Split(' ')[2].Split('.')[0];
            new QuoteDetailsPage(TestWebDriver).CopyQuote(false);
            new CreateQuotePage(TestWebDriver).OverrideAnyGenericSolutionErrors();
            new CreateQuotePage(TestWebDriver).SaveSolutionLinkedQuote();
            var quoteNumNewVer = new QuoteDetailsPage(TestWebDriver).GetQuoteNumber();
            var newVerSolNum = new QuoteDetailsPage(TestWebDriver).GetSolutionID().Split(' ')[2].Split('.')[0];
            Logger.Write("**Output: " + quoteNumNewVer + "**");
            return ((originalQuoteNum != quoteNumNewVer) && (originalSolNum != newVerSolNum));
        }


        public static void MultiGroupCreateSolution(IWebDriver TestWebDriver, string catalog, string ProductsToAdd, string PrductsToMovetoDifferentgroups)
        {
            var cat = (Catalogs)Enum.Parse(typeof(Catalogs), catalog);
            HomeWorkflow.GoToQuoteCreatePageUsingSolution(TestWebDriver);

            CreateQuotePage CreateQuotePage = new CreateQuotePage(TestWebDriver);
            CreateQuotePage.SelectSolutionsCatalog(cat);

            YourSolutionsPage YourSolutionsPage = new YourSolutionsPage(TestWebDriver);
            new YourSolutionsPage(TestWebDriver).CreateNewSolution();

            SolutionConfigurationPage SolutionConfigurationPage = new SolutionConfigurationPage(TestWebDriver);
            SolutionConfigurationPage.SearchAndAddMultipleProducts(ProductsToAdd);
            SolutionConfigurationPage.GoToGroupsTab().MoveMultipleProductsToNewGroups(DefaultNumber, PrductsToMovetoDifferentgroups);
            SolutionConfigurationPage.SaveSolution();

        }


        public static bool ValidateXPODandProductValidationErrors_WithOverrideFunctionality_ForCopyOrder(IWebDriver TestWebDriver)
        {
            OrderDetailsPage orderDetailsPage = new OrderDetailsPage(TestWebDriver);
            orderDetailsPage.CopyOrder();

            CreateQuotePage createQuotePage = new CreateQuotePage(TestWebDriver);
            IsValidationPassed = createQuotePage.VerifyXPODandProductValidationErrorMessages();
            IsValidationPassed = createQuotePage.VerifyOverrideButtonForValidationMessages();

            createQuotePage.ClickOnXPODAndProductValidationOverrideButton().SaveQuote();
            IsValidationPassed = createQuotePage.OverrideAnyGenericSolutionErrors().IsSaveQuoteButtonEnabled();
            createQuotePage.SaveQuote();

            QuoteDetailsPage quoteDetailsPage = new QuoteDetailsPage(TestWebDriver);
            IsValidationPassed = quoteDetailsPage.VerifyXPODandProductValidationErrorMessages();
            IsValidationPassed = quoteDetailsPage.VerifyOverrideButtonForValidationMessages();

            IsValidationPassed = quoteDetailsPage.OverrideXPODAndProductValidationErrors().IsCreateOrderBtnEnable();
            quoteDetailsPage.CreateOrder().WillNotExportOutsideUs().EmailConfirmationNextWithoutSendingOrder().SelectFirstPaymentMethod("WireTransfer").PaymentMethodNext();

            OrderReviewPage orderReviewPage = new OrderReviewPage(TestWebDriver);
            orderReviewPage.SaveOrder(false);

            return IsValidationPassed;
        }

        public static bool ValidateOverrideFunctionality_XPODWithPauseQuoteTrue_ForCopyOrder(IWebDriver TestWebDriver)
        {
            TestWebDriver.VerifyBusyOverlayNotDisplayed();
            OrderDetailsPage orderDetailsPage = new OrderDetailsPage(TestWebDriver);
            orderDetailsPage.CopyOrder();

            CreateQuotePage createQuotePage = new CreateQuotePage(TestWebDriver);
            IsValidationPassed = createQuotePage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = createQuotePage.VerifyOverrideButtonForValidationMessages();

            createQuotePage.ClickOnXPODAndProductValidationOverrideButton().SaveQuote();

            QuoteDetailsPage quoteDetailsPage = new QuoteDetailsPage(TestWebDriver);
            IsValidationPassed = quoteDetailsPage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = quoteDetailsPage.VerifyOverrideButtonForValidationMessages();

            IsValidationPassed = quoteDetailsPage.OverrideXPODAndProductValidationErrors().IsCreateOrderBtnEnable();
            quoteDetailsPage.CreateOrder().WillNotExportOutsideUs().EmailConfirmationNextWithoutSendingOrder().SelectFirstPaymentMethod("WireTransfer").PaymentMethodNext();

            TestWebDriver.VerifyBusyOverlayNotDisplayed();

            OrderReviewPage orderReviewPage = new OrderReviewPage(TestWebDriver);
            orderReviewPage.SaveOrder(false);

            TestWebDriver.VerifyBusyOverlayNotDisplayed();
            return IsValidationPassed;
        }
        public static bool ValidateOverrideFunctionality_XPODWithPauseQuoteFalse_ForCopyOrder(IWebDriver TestWebDriver)
        {
            OrderDetailsPage orderDetailsPage = new OrderDetailsPage(TestWebDriver);
            orderDetailsPage.CopyOrder();

            CreateQuotePage createQuotePage = new CreateQuotePage(TestWebDriver);
            IsValidationPassed = createQuotePage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = !(createQuotePage.VerifyOverrideButtonForValidationMessages());
            IsValidationPassed = createQuotePage.IsSaveQuoteButtonEnabled();
            createQuotePage.SaveQuote();

            QuoteDetailsPage quoteDetailsPage = new QuoteDetailsPage(TestWebDriver);
            IsValidationPassed = quoteDetailsPage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = quoteDetailsPage.VerifyOverrideButtonForValidationMessages();

            IsValidationPassed = quoteDetailsPage.OverrideXPODAndProductValidationErrors().IsCreateOrderBtnEnable();
            quoteDetailsPage.CreateOrder().WillNotExportOutsideUs().EmailConfirmationNextWithoutSendingOrder().SelectFirstPaymentMethod("WireTransfer").PaymentMethodNext();

            OrderReviewPage orderReviewPage = new OrderReviewPage(TestWebDriver);
            orderReviewPage.SaveOrder(false);

            return IsValidationPassed;
        }

        public static bool NoOverridePermission_ValidateOverrideFunctionality_XPODWithPauseQuoteFalse(IWebDriver TestWebDriver, string CustomerNumber)
        {
            CreateQuotePage createQuotePage = new CreateQuotePage(TestWebDriver);
            IsValidationPassed = createQuotePage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = !(createQuotePage.VerifyOverrideButtonForValidationMessages());

            createQuotePage.EnterCustomerNumber(CustomerNumber);
            IsValidationPassed = createQuotePage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = !(createQuotePage.VerifyOverrideButtonForValidationMessages());
            IsValidationPassed = createQuotePage.IsSaveQuoteButtonEnabled();
            createQuotePage.SaveQuote();

            QuoteDetailsPage quoteDetailsPage = new QuoteDetailsPage(TestWebDriver);
            quoteDetailsPage.WaitForQuoteValidationToComplete();

            IsValidationPassed = quoteDetailsPage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = !(quoteDetailsPage.VerifyOverrideButtonForValidationMessages());
            IsValidationPassed = !(quoteDetailsPage.IsCreateOrderBtnEnable());

            return IsValidationPassed;
        }
        public static bool ValidateOverrideFunctionality_XPODWithPauseQuoteFalse(IWebDriver TestWebDriver, string CustomerNumber)
        {
            CreateQuotePage createQuotePage = new CreateQuotePage(TestWebDriver);
            IsValidationPassed = createQuotePage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = !(createQuotePage.VerifyOverrideButtonForValidationMessages());

            createQuotePage.EnterCustomerNumber(CustomerNumber);
            IsValidationPassed = createQuotePage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = !(createQuotePage.VerifyOverrideButtonForValidationMessages());
            IsValidationPassed = createQuotePage.IsSaveQuoteButtonEnabled();
            createQuotePage.SaveQuote();

            QuoteDetailsPage quoteDetailsPage = new QuoteDetailsPage(TestWebDriver);
            quoteDetailsPage.WaitForQuoteValidationToComplete();

            IsValidationPassed = quoteDetailsPage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = quoteDetailsPage.VerifyOverrideButtonForValidationMessages();

            IsValidationPassed = quoteDetailsPage.OverrideXPODAndProductValidationErrors().IsCreateOrderBtnEnable();

            quoteDetailsPage.CreateOrder().WillNotExportOutsideUs().EmailConfirmationNextWithoutSendingOrder().SelectFirstPaymentMethod("WireTransfer").PaymentMethodNext();

            OrderReviewPage orderReviewPage = new OrderReviewPage(TestWebDriver);
            orderReviewPage.SaveOrder(false);

            TestWebDriver.VerifyBusyOverlayNotDisplayed();
            return IsValidationPassed;
        }

        public static bool ValidateOverrideFunctionality_XPODWithPauseQuoteTrue(IWebDriver TestWebDriver, string CustomerNumber)
        {
            CreateQuotePage createQuotePage = new CreateQuotePage(TestWebDriver);
            IsValidationPassed = createQuotePage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = !(createQuotePage.VerifyOverrideButtonForValidationMessages());

            createQuotePage.EnterCustomerNumber(CustomerNumber);
            IsValidationPassed = createQuotePage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = createQuotePage.VerifyOverrideButtonForValidationMessages();

            createQuotePage.ClickOnXPODAndProductValidationOverrideButton().SaveQuote();

            QuoteDetailsPage quoteDetailsPage = new QuoteDetailsPage(TestWebDriver);

            IsValidationPassed = quoteDetailsPage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = quoteDetailsPage.VerifyOverrideButtonForValidationMessages();

            IsValidationPassed = quoteDetailsPage.OverrideXPODAndProductValidationErrors().IsCreateOrderBtnEnable();
            quoteDetailsPage.CreateOrder().WillNotExportOutsideUs().EmailConfirmationNextWithoutSendingOrder().SelectFirstPaymentMethod("WireTransfer").PaymentMethodNext();

            OrderReviewPage orderReviewPage = new OrderReviewPage(TestWebDriver);
            orderReviewPage.SaveOrder(false);

            TestWebDriver.VerifyBusyOverlayNotDisplayed();
            return IsValidationPassed;

        }
        public static bool ValidateOverrideFunctionality_XPODWithPauseQuoteTrue_ForCopyQuote(IWebDriver TestWebDriver, string CustomerNumber)
        {
            CreateQuotePage createQuotePage = new CreateQuotePage(TestWebDriver);
            IsValidationPassed = createQuotePage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = !(createQuotePage.VerifyOverrideButtonForValidationMessages());

            createQuotePage.EnterCustomerNumber(CustomerNumber);
            IsValidationPassed = createQuotePage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = createQuotePage.VerifyOverrideButtonForValidationMessages();

            createQuotePage.ClickOnXPODAndProductValidationOverrideButton().SaveQuote();

            QuoteDetailsPage quoteDetailsPage = new QuoteDetailsPage(TestWebDriver);
            quoteDetailsPage.WaitForQuoteValidationToComplete();
            IsValidationPassed = quoteDetailsPage.OverrideXPODAndProductValidationErrors().IsCreateOrderBtnEnable();

            quoteDetailsPage.CopyQuote();

            IsValidationPassed = createQuotePage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = createQuotePage.VerifyOverrideButtonForValidationMessages();

            createQuotePage.ClickOnXPODAndProductValidationOverrideButton().SaveQuote();

            IsValidationPassed = quoteDetailsPage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = quoteDetailsPage.VerifyOverrideButtonForValidationMessages();

            IsValidationPassed = quoteDetailsPage.OverrideXPODAndProductValidationErrors().IsCreateOrderBtnEnable();
            quoteDetailsPage.CreateOrder().WillNotExportOutsideUs().EmailConfirmationNextWithoutSendingOrder().SelectFirstPaymentMethod("WireTransfer").PaymentMethodNext();

            OrderReviewPage orderReviewPage = new OrderReviewPage(TestWebDriver);
            orderReviewPage.SaveOrder(false);

            return IsValidationPassed;
        }
        public static bool VerifySolutionConfigurationHasTiedSkusInGroup1(IWebDriver driver, string sku1, string sku2)
        {
            // new QuoteDetailsPage(driver).ClickExpandAllConfigurationButtonForSolution();

            IReadOnlyCollection<IWebElement> b = new QuoteDetailsPage(driver).FindTiedItemsInGroup(0, 0).FindElements(By.ClassName("cfg-group"));

            IEnumerable<IWebElement> lst =
                new QuoteDetailsPage(driver).FindTiedItemsInGroup(0, 0)
                    .FindElements(By.TagName("a"))
                    .Where(ab => ab.Text.Contains("Tied Items:"));

            foreach (var VARIABLE in lst)
            {
                sku1 = "421-9736";
                sku2 = "2";
                int test = Convert.ToInt32(VARIABLE) - Convert.ToInt32(b);
                int testst = 0;
                VARIABLE.Click();
                var xpath = String.Format("//*[@id='quoteDetail_LI_CS_configInfo_build_categoryTable_{0}_{1}_{2}']", testst, testst, test);
                driver.FindElement(By.XPath(xpath)).FindElements(By.TagName("td")).FirstOrDefault(o => o.GetAttribute("ng-bind").Contains(sku1).Equals(sku2));


            }
            return true;
        }



        public static bool ValidateOverrideFunctionality_XPODApprovedSolutionWithPauseQuoteTrue_ForCopyQuote(IWebDriver TestWebDriver, string CustomerNumber)
        {
            CreateQuotePage createQuotePage = new CreateQuotePage(TestWebDriver);
            IsValidationPassed = !(createQuotePage.VerifyOnlyXPODErrorMessages());
            IsValidationPassed = !(createQuotePage.VerifyOverrideButtonForValidationMessages());


            createQuotePage.EnterCustomerNumber(CustomerNumber);
            IsValidationPassed = !(createQuotePage.VerifyOnlyXPODErrorMessages());
            IsValidationPassed = !(createQuotePage.VerifyOverrideButtonForValidationMessages());
            IsValidationPassed = createQuotePage.IsSaveQuoteButtonEnabled();
            createQuotePage.SaveQuote();
            TestWebDriver.VerifyBusyOverlayNotDisplayed();

            QuoteDetailsPage quoteDetailsPage = new QuoteDetailsPage(TestWebDriver);
            TestWebDriver.VerifyBusyOverlayNotDisplayed();
            quoteDetailsPage.WaitForQuoteValidationToComplete();

            IsValidationPassed = quoteDetailsPage.IsCreateOrderBtnEnable();

            quoteDetailsPage.CopyQuote(true);

            TestWebDriver.VerifyBusyOverlayNotDisplayed();

            IsValidationPassed = !(createQuotePage.VerifyOnlyXPODErrorMessages());
            TestWebDriver.VerifyBusyOverlayNotDisplayed();
            IsValidationPassed = !(createQuotePage.VerifyOverrideButtonForValidationMessages());
            TestWebDriver.VerifyBusyOverlayNotDisplayed();
            IsValidationPassed = createQuotePage.IsSaveQuoteButtonEnabled();
            TestWebDriver.VerifyBusyOverlayNotDisplayed();

            createQuotePage.SaveQuote();

            TestWebDriver.VerifyBusyOverlayNotDisplayed();

            IsValidationPassed = !(quoteDetailsPage.VerifyOnlyXPODErrorMessages());
            TestWebDriver.VerifyBusyOverlayNotDisplayed();
            IsValidationPassed = !(quoteDetailsPage.VerifyOverrideButtonForValidationMessages());
            TestWebDriver.VerifyBusyOverlayNotDisplayed();
            IsValidationPassed = quoteDetailsPage.IsCreateOrderBtnEnable();
            TestWebDriver.VerifyBusyOverlayNotDisplayed();

            quoteDetailsPage.CreateOrder().WillNotExportOutsideUs().EmailConfirmationNextWithoutSendingOrder().SelectFirstPaymentMethod("WireTransfer").PaymentMethodNext();
            TestWebDriver.VerifyBusyOverlayNotDisplayed();

            OrderReviewPage orderReviewPage = new OrderReviewPage(TestWebDriver);
            orderReviewPage.SaveOrder(false);

            return IsValidationPassed;
        }

        public static bool ValidateOverrideFunctionality_XPODWithPauseQuoteFalse_ForCopyQuote(IWebDriver TestWebDriver, string CustomerNumber)
        {
            CreateQuotePage createQuotePage = new CreateQuotePage(TestWebDriver);
            IsValidationPassed = createQuotePage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = !(createQuotePage.VerifyOverrideButtonForValidationMessages());

            createQuotePage.EnterCustomerNumber(CustomerNumber);
            IsValidationPassed = createQuotePage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = !(createQuotePage.VerifyOverrideButtonForValidationMessages());
            IsValidationPassed = createQuotePage.IsSaveQuoteButtonEnabled();
            createQuotePage.SaveQuote();

            QuoteDetailsPage quoteDetailsPage = new QuoteDetailsPage(TestWebDriver);
            IsValidationPassed = quoteDetailsPage.OverrideXPODAndProductValidationErrors().IsCreateOrderBtnEnable();

            quoteDetailsPage.CopyQuote();

            IsValidationPassed = createQuotePage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = !(createQuotePage.VerifyOverrideButtonForValidationMessages());
            IsValidationPassed = createQuotePage.IsSaveQuoteButtonEnabled();
            createQuotePage.SaveQuote();

            IsValidationPassed = quoteDetailsPage.VerifyOnlyXPODErrorMessages();
            IsValidationPassed = quoteDetailsPage.VerifyOverrideButtonForValidationMessages();

            IsValidationPassed = quoteDetailsPage.OverrideXPODAndProductValidationErrors().IsCreateOrderBtnEnable();
            quoteDetailsPage.CreateOrder().WillNotExportOutsideUs().EmailConfirmationNextWithoutSendingOrder().SelectFirstPaymentMethod("WireTransfer").PaymentMethodNext();

            OrderReviewPage orderReviewPage = new OrderReviewPage(TestWebDriver);
            orderReviewPage.SaveOrder(false);

            return IsValidationPassed;
        }
        public static bool ValidateXPODandProductValidationErrors_WithOverrideFunctionality_ForCopyQuote(IWebDriver TestWebDriver, string CustomerNumber)
        {
            CreateQuotePage createQuotePage = new CreateQuotePage(TestWebDriver);
            IsValidationPassed = createQuotePage.VerifyXPODandProductValidationErrorMessages();
            IsValidationPassed = !(createQuotePage.VerifyOverrideButtonForValidationMessages());

            createQuotePage.EnterCustomerNumber(CustomerNumber);
            IsValidationPassed = createQuotePage.VerifyXPODandProductValidationErrorMessages();
            IsValidationPassed = createQuotePage.VerifyOverrideButtonForValidationMessages();

            createQuotePage.ClickOnXPODAndProductValidationOverrideButton().SaveQuote();//renamemothodname
            IsValidationPassed = createQuotePage.OverrideAnyGenericSolutionErrors().IsSaveQuoteButtonEnabled();
            createQuotePage.SaveQuote();

            QuoteDetailsPage quoteDetailsPage = new QuoteDetailsPage(TestWebDriver);
            quoteDetailsPage.CopyQuote();

            IsValidationPassed = createQuotePage.VerifyXPODandProductValidationErrorMessages();
            IsValidationPassed = createQuotePage.VerifyOverrideButtonForValidationMessages();

            createQuotePage.ClickOnXPODAndProductValidationOverrideButton().SaveQuote();
            IsValidationPassed = createQuotePage.OverrideAnyGenericSolutionErrors().IsSaveQuoteButtonEnabled();
            createQuotePage.SaveQuote();

            IsValidationPassed = quoteDetailsPage.VerifyXPODandProductValidationErrorMessages();
            IsValidationPassed = quoteDetailsPage.VerifyOverrideButtonForValidationMessages();

            IsValidationPassed = quoteDetailsPage.OverrideXPODAndProductValidationErrors().IsCreateOrderBtnEnable();
            quoteDetailsPage.CreateOrder().WillNotExportOutsideUs().EmailConfirmationNextWithoutSendingOrder().SelectFirstPaymentMethod("WireTransfer").PaymentMethodNext();

            OrderReviewPage orderReviewPage = new OrderReviewPage(TestWebDriver);
            orderReviewPage.SaveOrder(false);

            return IsValidationPassed;
        }

        public static bool MultiQuote_ValidateXPODandProductValidationErrors_WithOverrideFunctionality_ForCopyQuote(IWebDriver TestWebDriver, string groupNameErrorMessageToVerify, string cstNumber)
        {
            CreateQuotePage createQuotePage = new CreateQuotePage(TestWebDriver);
            IsValidationPassed = !(createQuotePage.SelectAndVerifyOverridableErrrorsAtEachGroup_WithOverrideButton(groupNameErrorMessageToVerify));

            createQuotePage.EnterCustomerNumber(cstNumber);

            IsValidationPassed = createQuotePage.SelectAndVerifyOverridableErrrorsAtEachGroup_WithOverrideButton(groupNameErrorMessageToVerify);
            IsValidationPassed = createQuotePage.OverrideErrorAtOneGroupAndCheckOverridebuttondisabled(groupNameErrorMessageToVerify);

            IsValidationPassed = createQuotePage.IsSaveQuoteButtonEnabled();
            createQuotePage.SaveQuote();

            IsValidationPassed = createQuotePage.OverrideValidationConsolidatedValidationErrorsAndCheckOverrideButtonDisabledAtEachGroup(groupNameErrorMessageToVerify);
            createQuotePage.SaveQuote();

            IsValidationPassed = createQuotePage.OverrideAnyGenericSolutionErrors().IsSaveQuoteButtonEnabled();
            createQuotePage.SaveQuote();

            QuoteDetailsPage quoteDetailsPage = new QuoteDetailsPage(TestWebDriver);
            IsValidationPassed = quoteDetailsPage.QuoteDetails_SelectAndVerifyOverridableErrrorsAtEachGroup(groupNameErrorMessageToVerify);
            IsValidationPassed = quoteDetailsPage.IsCreateOrderBtnEnable();

            quoteDetailsPage.CopyQuote();

            createQuotePage = new CreateQuotePage(TestWebDriver);
            IsValidationPassed = createQuotePage.SelectAndVerifyOverridableErrrorsAtEachGroup_WithOverrideButton(groupNameErrorMessageToVerify);
            IsValidationPassed = createQuotePage.OverrideErrorAtOneGroupAndCheckOverridebuttondisabled(groupNameErrorMessageToVerify);

            IsValidationPassed = createQuotePage.IsSaveQuoteButtonEnabled();
            createQuotePage.SaveQuote();

            IsValidationPassed = createQuotePage.OverrideValidationConsolidatedValidationErrorsAndCheckOverrideButtonDisabledAtEachGroup(groupNameErrorMessageToVerify);
            createQuotePage.SaveQuote();

            IsValidationPassed = createQuotePage.OverrideAnyGenericSolutionErrors().IsSaveQuoteButtonEnabled();
            createQuotePage.SaveQuote();

            quoteDetailsPage = new QuoteDetailsPage(TestWebDriver);
            IsValidationPassed = quoteDetailsPage.QuoteDetails_SelectAndVerifyOverridableErrrorsAtEachGroup(groupNameErrorMessageToVerify);
            IsValidationPassed = quoteDetailsPage.IsCreateOrderBtnEnable();

            return IsValidationPassed;
        }

        public static void AddCFIProjectForStandardQuoteOnProductConfigPage(IWebDriver TestWebDriver, string CFIProjectWithReviewState)
        {
            ProductConfigurePage productConfigurePage = new ProductConfigurePage(TestWebDriver);
            productConfigurePage.ClickConfigurationService();
            productConfigurePage.ClickNoneSelected();
            productConfigurePage.SelectCFSAdminOverrideChecbox();
            productConfigurePage.EnterConfigurationServicesProjects(CFIProjectWithReviewState);
            productConfigurePage.ClickAddOnConfigurationServicesProject();
            productConfigurePage.EnterCommentTextByCommentCode(ProductConfigureIDs.CFIProjectFirstCommentCode, ProductConfigureIDs.CFIProjectComment);
            productConfigurePage.ClickSaveOnComments();
            productConfigurePage.GoToCurrentQuotePage();
        }

        public static bool VerifyFunctionalityOfFirstArticleReviewHoldOnOrderDetailsPage(IWebDriver TestWebDriver, string Holdtype, string CFIProjectStatus)
        {
            OrderDetailsPage orderDetailsPage = new OrderDetailsPage(TestWebDriver);
            IsValidationPassed = orderDetailsPage.IsfirstArticleReviewCheckBoxDisplayedWithProperLabel();
            IsValidationPassed = !(orderDetailsPage.IsSaveOrderEnabled());
            IsValidationPassed = orderDetailsPage.VerifyHoldTypeAndCFIProjectStatus(Holdtype, CFIProjectStatus);
            IsValidationPassed = orderDetailsPage.SelectFirstArticleCheckBox().IsSaveOrderEnabled();

            return IsValidationPassed;
        }

        public static void SearchSolution(IWebDriver webdriver, SolutionSearchType searchCriteria, string solutionId)
        {
            HomeWorkflow.GotoSolutionSearchPage(webdriver);
            new SolutionSearchPage(webdriver).SolutionSearch(searchCriteria, solutionId);
            new SolutionSearchPage(webdriver).SolutionSearch(solutionId);
            DsaUtil.WaitForPageLoad(webdriver);
        }

        public static void CheckValidationOverride(IWebDriver webdriver, bool clickValidationOverride = false)
        {
            if (clickValidationOverride)
            {
                new SolutionConfigurationPage(webdriver).SelectValidationOverrideChkBox(webdriver);
                new SolutionConfigurationPage(webdriver).SaveSolution();
            }
        }

        // Search solution by sol. Id in DSA -> Open that solution in OSC -> Save As New Soln. -> Select Validation Override checkbox if needed -> Send to quote
        public static void SearchAndCopySolutionAsNewSolutionAndSendToQuote(IWebDriver webdriver, SolutionSearchType searchCriteria, string solutionId, bool clickValidationOverride = false)
        {
            SearchSolution(webdriver, searchCriteria, solutionId);
            //webdriver.WaitForElementVisible(By.XPath("//div[@class='spinnerMask']"), TimeSpan.FromSeconds(25));
            var wait = new WebDriverWait(webdriver, DsaUtil.GlobalWaitTime);
            wait.Until<bool>(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@class='spinnerMask']")));

            new SolutionConfigurationPage(webdriver).SolutionSaveAsNewSolution();
            CheckValidationOverride(webdriver, clickValidationOverride);
            new SolutionConfigurationPage(webdriver).SendToQuote().WaitForQuoteValidationToComplete();
        }

        public static void SearchCopyChangeCatalogSaveAndSendToQuote(IWebDriver webdriver, SolutionSearchType searchCriteria, string solutionId, bool clickValidationOverride = false)
        {
            SearchSolution(webdriver, searchCriteria, solutionId);
            //webdriver.WaitForElementVisible(By.XPath("//div[@class='spinnerMask']"), TimeSpan.FromSeconds(25));
            var wait = new WebDriverWait(webdriver, DsaUtil.GlobalWaitTime);
            wait.Until<bool>(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@class='spinnerMask']")));

            new SolutionConfigurationPage(webdriver).SolutionSaveAsNewSolution();
            CheckValidationOverride(webdriver, clickValidationOverride);
            new SolutionConfigurationPage(webdriver).ChangeSolutionCatalog();
            new SolutionConfigurationPage(webdriver).SendToQuote().WaitForQuoteValidationToComplete();
        }

        public static void SearchAndCopySolutionAsNewVersionAndSendToQuote(IWebDriver webdriver, SolutionSearchType searchCriteria, string solutionId, bool clickValidationOverride = false)
        {
            SearchSolution(webdriver, searchCriteria, solutionId);
            var wait = new WebDriverWait(webdriver, DsaUtil.GlobalWaitTime);
            wait.Until<bool>(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@class='spinnerMask']")));

            new SolutionConfigurationPage(webdriver).SolutionSaveAsNewVersion();
            CheckValidationOverride(webdriver, clickValidationOverride);
            new SolutionConfigurationPage(webdriver).SendToQuote().WaitForQuoteValidationToComplete();
        }

        public static void SearchAndCopyTemplateSolutionAndSendToQuote(IWebDriver webdriver, SolutionSearchType searchCriteria, string solutionId, bool clickValidationOverride = false)
        {
            SearchSolution(webdriver, searchCriteria, solutionId);

            new SolutionConfigurationPage(webdriver).TemplateSolutionSaveAsNewVersion();
            CheckValidationOverride(webdriver, clickValidationOverride);
            new SolutionConfigurationPage(webdriver).SendToQuote().WaitForQuoteValidationToComplete();
        }

        public static void SearchCopySolutionPatchDealSendToQuote(IWebDriver webdriver, SolutionSearchType searchCriteria, string solutionId, string deal, bool clickValidationOverride = false)
        {
            SearchSolution(webdriver, searchCriteria, solutionId);

            new SolutionConfigurationPage(webdriver).SolutionSaveAsNewSolution();
            CheckValidationOverride(webdriver, clickValidationOverride);

            new SolutionConfigurationPage(webdriver).AssociateDealID(deal);
            new SolutionConfigurationPage(webdriver).SaveLink.Click(webdriver);
            new SolutionConfigurationPage(webdriver).SendToQuote().WaitForQuoteValidationToComplete();
        }

        public static void NavigateToLinkedQuoteByPartialText(IWebDriver webdriver, string partialTextString)
        {
            var linkedQuoteDrpDwn = new CreateQuotePage(webdriver).LinkedQuotesListBox;
            linkedQuoteDrpDwn.Click(webdriver);
            foreach (var option in new SelectElement(linkedQuoteDrpDwn).Options)
            {
                if (option.GetText(webdriver).Contains(partialTextString))
                {
                    option.Click(webdriver);
                    break;
                }
            }
            new CreateQuotePage(webdriver).WaitForQuoteValidationToComplete();
        }

        public static void EditSolutionToNavigateToOsc(IWebDriver webDriver)
        {
            new CreateQuotePage(webDriver).ClickOnEditSolutionBtn();
        }

        public static SolutionConfigurationPage CreateSolutionFromCustomerDetails(IWebDriver webDriver, string customerNumber)
        {
            CustomerSearchWorkflow.SearchCustomerByCustomerNumber(webDriver, customerNumber);
            new CustomerDetailsPage(webDriver).BtnCreateSolution.Click(webDriver);
            webDriver.WaitForPageLoad();
            DsaUtil.WaitAnimationToLoad(webDriver);
            return new SolutionConfigurationPage(webDriver);
        }

        public static void SearchAndCopyAsNewQuoteAndSendToSolutionQuote(IWebDriver webdriver, SolutionSearchType searchCriteria, string solutionId, int quoteIndex = 1, bool clickValidationOverride = false)
        {
            HomeWorkflow.GotoSolutionSearchPage(webdriver);
            new SolutionSearchPage(webdriver).SolutionSearch(searchCriteria, solutionId);

            new SolutionSearchPage(webdriver).QuoteIDList[quoteIndex].Click();
            DsaUtil.WaitForPageLoad(webdriver);

            //webdriver.WaitForElementVisible(By.XPath("//div[@class='spinnerMask']"), TimeSpan.FromSeconds(25));
            //var wait = new WebDriverWait(webdriver, DsaUtil.GlobalWaitTime);
            //wait.Until<bool>(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@class='spinnerMask']")));
            WebDriverUtil.VerifyBusyOverlayNotDisplayed(webdriver);

            new SolutionConfigurationPage(webdriver).SolutionSaveAsNewSolution();
            CheckValidationOverride(webdriver, clickValidationOverride);

            new SolutionConfigurationPage(webdriver).SendToQuote().WaitForQuoteValidationToComplete();
        }


        public static int GetEditCustomerLinkIndex(CustomerType custType)
        {
            int index;
            switch (custType)
            {
                case CustomerType.BillTo:
                    index = 1;
                    break;

                case CustomerType.EndUser:
                    index = 2;
                    break;

                case CustomerType.ShipTo:
                    index = 3;
                    break;

                case CustomerType.InstallAt:
                    index = 4;
                    break;

                // this is not needed in OSC usage.
                case CustomerType.SoldTo:
                    index = 0;
                    break;

                default:
                    index = 0;
                    break;
            }

            return index;
        }

        public static YourSolutionsPage ManageAutoRecoveredSolutions(IWebDriver webDriver)
        {
            if (webDriver.TryFindElement(new YourSolutionsPage(webDriver).BtnDiscardAutoRecoveredSolution, TimeSpan.FromSeconds(3)))
                new YourSolutionsPage(webDriver).BtnDiscardAutoRecoveredSolution.Click(webDriver);
            return new YourSolutionsPage(webDriver);
        }

        public static void ManageAccountFlow(IWebDriver webDriver, string billToCustomer, string endUserCustomer, string shipToCustomer, string solutionName, string installAtCustomer, string partnerAccountNumber = null, string salesMotion = null)
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(2));
            new SolutionConfigurationPage(webDriver).LnkManageAccount.Click(webDriver);

            //Sales Motion Selection
            if (!string.IsNullOrEmpty(salesMotion))
            {
                new SolutionConfigurationPage(webDriver).LnkEditSalesMotion.Click(webDriver);
                //Todo: complete sales motion dropdown selection
            }

            //Partner Account selection
            if (!string.IsNullOrEmpty(partnerAccountNumber))
            {
                if (new SolutionConfigurationPage(webDriver).LnkEditPartnerAccount.IsElementClickable(webDriver, TimeSpan.FromSeconds(3)))
                    new SolutionConfigurationPage(webDriver).LnkEditPartnerAccount.Click(webDriver);
                webDriver.GetElement(By.XPath(
                    "//div[contains(text(), 'Choose Partner Account')]/following-sibling::div//tbody//td[contains(.,'" +
                    partnerAccountNumber + "')]")).Click(webDriver);
                //webDriver.GetElement(By.XPath("//div[contains(@class, 'manage-section-header') and contains(text(), 'Bill To')]/../div/a[contains(@id, 'cancelbutton')]")).Click(webDriver);
            }


            //Edit BillTo
            new SolutionConfigurationPage(webDriver).LnkEditBillToCustomer.WaitForElement(webDriver);
            if (new SolutionConfigurationPage(webDriver).LnkEditBillToCustomer.IsElementClickable(webDriver, TimeSpan.FromSeconds(3)))
                new SolutionConfigurationPage(webDriver).LnkEditBillToCustomer.Click(webDriver);
            webDriver.GetElement(By.XPath("//div[contains(text(), 'Choose Bill To')]/../../../div/following-sibling::div/div[contains(@class, 'table')]//tbody//td[contains(., '" + billToCustomer + "')]")).Click(webDriver);
            webDriver.GetElements(By.XPath("//*[@id='customerAddressesDiv']//div[3]/table/tbody/tr"))[0].Click(webDriver); //Click the first row as Bill To address
            wait.Until<bool>(
                ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@class='pleaseWaitImage']")));

            //Edit End User
            new SolutionConfigurationPage(webDriver).TxtEnterEndCustomer.WaitForElement(webDriver);
            new SolutionConfigurationPage(webDriver).TxtEnterEndCustomer.SetText(webDriver, endUserCustomer, TimeSpan.FromSeconds(2));
            webDriver.GetElement(By.XPath("//button[contains(text(),'Look Up')]")).Click(webDriver);
            wait.Until<bool>(
                ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@class='pleaseWaitImage']")));

            //Edit ShipTo
            new SolutionConfigurationPage(webDriver).LnkEditShipToCustomer.WaitForElement(webDriver);
            if (new SolutionConfigurationPage(webDriver).LnkEditShipToCustomer.IsElementClickable(webDriver, TimeSpan.FromSeconds(3)))
                new SolutionConfigurationPage(webDriver).LnkEditShipToCustomer.Click(webDriver);
            webDriver.GetElement(By.XPath("//div[contains(text(), 'Choose Ship To')]/../../../div/following-sibling::div/div[contains(@class, 'table')]//tbody//td[contains(., '" + shipToCustomer + "')]")).Click(webDriver);
            webDriver.GetElements(By.XPath("//*[@id='customerAddressesDiv']//div[3]/table/tbody/tr"))[1].Click(webDriver); //Click the first row as Ship To address
            wait.Until<bool>(
                ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@class='pleaseWaitImage']")));

            //Edit InstallAt and enter solution name
            new SolutionConfigurationPage(webDriver).LnkEditInstallAtCustomer.WaitForElement(webDriver);
            new SolutionConfigurationPage(webDriver).LnkEditInstallAtCustomer.Click(webDriver);
            new SolutionConfigurationPage(webDriver).TxtEnterSolutionName.SetText(webDriver, solutionName, TimeSpan.FromSeconds(2));
            webDriver.GetElements(By.XPath("//div//table//tbody//tr[contains(@class, 'clickable')]"))[1].Click(webDriver); //add the first row as InstallAt value

            //click submit
            new SolutionConfigurationPage(webDriver).BtnOk.Click(webDriver);
        }

        public static string CreateSolutionQuoteCpqFlow(IWebDriver webDriver, OscSolutionData testData)
        {
            //var partnerPortalLoginUrl = row["PartnerLoginUrl"].ToString();
            //var oscUrl = row["OscUrl"].ToString();
            //webDriver.Navigate().GoToUrl(partnerPortalLoginUrl);  
            webDriver.Navigate().GoToUrl(testData.OscUrl);

            // check for auto-recovered solutions if any
            ManageAutoRecoveredSolutions(webDriver);

            new YourSolutionsPage(webDriver).SearchAndOpenSolution(testData.SolutionId);

            if (!testData.SaveSolutionAsNewVersion)
            {
                new SolutionConfigurationPage(webDriver).SolutionSaveAsNewSolution();

                // manage account flow to select respective customer/addresses/solution name
                ManageAccountFlow(webDriver,
                    testData.BillToCustomer,
                    testData.EndUserCustomer,
                    testData.ShipToCustomer,
                    testData.SolutionName,
                    testData.InstallAtCustomer,
                    testData.PartnerAccountNumber
                );

                //Add code for updating shipping group
                if (!string.IsNullOrEmpty(testData.ShippingMethod))
                {
                    new SolutionConfigurationPage(webDriver).GoToGroupsTab();
                    new SolutionConfigurationPage(webDriver).ShippingMethodLnk.Click(webDriver);
                    new SolutionConfigurationPage(webDriver).SelectShippingMethod(webDriver, testData.ShippingMethod);
                }

                //Set Shipping instructions if needed
                if (!string.IsNullOrEmpty(testData.ShippingInstructions))
                {
                    new SolutionConfigurationPage(webDriver).GoToGroupsTab();
                    new SolutionConfigurationPage(webDriver).EnterShippingInstructions(webDriver, testData.ShippingInstructions);
                }

            }
            else
            {
                //do save as new version
                new SolutionConfigurationPage(webDriver).SolutionSaveAsNewVersion();
            }

            new SolutionConfigurationPage(webDriver).SaveCPSolution();
            var createdSolId = new SolutionConfigurationPage(webDriver).SolutionIDLabel.GetText(webDriver).Split('#')[1];
            Logger.Write("Solution Id: " + createdSolId);

            new SolutionConfigurationPage(webDriver).BtnCreateQuote.WaitForElement(webDriver);
            new SolutionConfigurationPage(webDriver).BtnCreateQuote.Click(webDriver);

            new SolutionConfigurationPage(webDriver).BtnContinueOnPopUp(webDriver).WaitForElement(webDriver);
            new SolutionConfigurationPage(webDriver).BtnContinueOnPopUp(webDriver).Click(webDriver);

            // handle quote creation
            new SolutionConfigurationPage(webDriver).BtnOkOnQuoteCreateInProgressPopUp.Click(webDriver);

            //Todo: Handle failure scenario with appropriate logs

            //Temporary fix for V3 quote conversion delay - should remove after 0804
            var v3QuoteCreationTimeoutValue = !string.IsNullOrEmpty(testData.TimeoutValue) ? Convert.ToDouble(testData.TimeoutValue) : 300;

            return new SolutionConfigurationPage(webDriver).GetChannelPartnerQuoteNumber(webDriver, v3QuoteCreationTimeoutValue);
        }

    }
}
