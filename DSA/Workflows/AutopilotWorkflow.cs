//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using Dsa.Constants;
using Dsa.DataModels;
using Dsa.Enums;
using Dsa.Pages.Customer;
using Dsa.Pages.Order;
using Dsa.Pages.PCFConvergence;
using Dsa.Pages.Product;
using Dsa.Pages.Quote;
using Dsa.Utils;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ProductSearchPage = Dsa.Pages.ProductSearchPage;

namespace Dsa.Workflows
{
    /// <summary>
    /// Create quote workflows will be defined in this class.
    /// </summary>
    public static class AutopilotWorkflow
    {


        #region Create Autopilot Quote from Menu


        public static void CreateAutopilotQuoteFromMenu(IWebDriver driver, string customerNumber, string orderCode,string moduleName, bool autopilotSelection = true, string tenantId = "", string domain = "",
            string quoteName = "", bool saveQuote = true, bool autoPilotQuoteNotificationsBeforeSave = false,
            bool autoPilotQuoteNotificationsAfterSave = false,bool verifyAutopilotData=false, string contractCode = "", string endUserCustomer = "")
        {
            PatchCustomer(driver, customerNumber);
            AddAutopilotItemsToQuote(driver, orderCode, moduleName, autopilotSelection, tenantId, domain);
            Logger.Write($"Order Code- {orderCode} added with module - {moduleName} selection , patched the TenanId - {tenantId} and Domain - {domain}");
            if (verifyAutopilotData)
            {
                if(autopilotSelection)
                    VerifyAutopilotData(driver, true, true, tenantId, domain);
                else
                    VerifyAutopilotData(driver, false, false, tenantId, domain);
            }

            if (saveQuote)
            {
                if(autopilotSelection)
                    SaveAutopilotQuote(driver, customerNumber, quoteName, autoPilotQuoteNotificationsBeforeSave, autoPilotQuoteNotificationsAfterSave, contractCode, endUserCustomer);
                else
                    SaveAutopilotQuote(driver, customerNumber, quoteName, false, false, contractCode, endUserCustomer);
            }

            else if(autoPilotQuoteNotificationsBeforeSave && autopilotSelection)
                AutoPilotQuoteNotificationsBeforeSave(driver);
            

        }


        public static void AddAutopilotItemsToQuote(IWebDriver driver, string orderCode,
            string moduleName, bool autopilotSelection = true, string tenantId = null, string domain = null,
            int shippingGroupIndex = 1)
        {
            new CreateQuotePage(driver).AddItemsFromSearch(shippingGroupIndex-1).SearchByOrderCode(orderCode);
            ProductSearchWorkflow.VerifyProductSearchResultsGrid(new ProductSearchResultsPage(driver).GetProductResultsGridRecords()).Should().BeTrue("Product Search results data returned");
            //Get Items count in Cart
            int itemCount = new ProductSearchResultsPage(driver).GetItemCountFromMastHead();
            Logger.Write("Items count in Cart: "+itemCount);
            //Add Product to Cart and Click Configure button
            new ProductSearchResultsPage(driver).AddItemToCart(0);
            Logger.Write("Added Order code to cart: " + orderCode);
            new ProductSearchResultsPage(driver).ConfigureProduct.Click(driver);
            //Expand the newly added to cart and Verify the Autopilot section is displayed
            //new ProductConfigurePage(driver).ExpandProductUsingTogggleArrow(itemCount+1);
            ProductConfigurePage productConfigurePage = new ProductConfigurePage(driver);
            productConfigurePage.VerifyTenantIdandDomainShownforModule(moduleName,
                autopilotSelection == true ? 1 : 2);
            if ((autopilotSelection == true) && (!string.IsNullOrEmpty(tenantId) || !string.IsNullOrEmpty(domain)))
            {
                productConfigurePage.PatchTenantIdandDomainData(tenantId, domain);
                new ProductConfigurePage(driver).VerifyTenantIdandDomainDataShown(tenantId, domain).Should().BeTrue();
            }
            new ProductSearchPage(driver).GoToCurrentQuotePage();
        }

        public static void SaveAutopilotQuote(IWebDriver driver, string customerNumber, string quoteName = "",
            bool autoPilotQuoteNotificationsBeforeSave = false, bool autoPilotQuoteNotificationsAfterSave = false,
            string contractCode = "", string endUserCustomer = "")
        {

            PatchCustomer(driver, customerNumber);
            if (autoPilotQuoteNotificationsBeforeSave)
                AutoPilotQuoteNotificationsBeforeSave(driver);
            SaveQuote(driver, customerNumber, quoteName, contractCode, endUserCustomer);
            if (autoPilotQuoteNotificationsAfterSave)
                AutoPilotQuoteNotificationsAfterSave(driver);

        }

        public static void DraftQuoteInfo(IWebDriver driver)
        {
            Logger.Write("Quote id :" + new CreateQuotePage(driver).LblQuoteIdOnDraftQuotePage());
            string drftQuoteNo = new CreateQuotePage(driver).LblDraftQuoteNumber.GetText(driver);
            Logger.Write("Draft quote no : " + drftQuoteNo);
        }

        public static void PatchCustomer(IWebDriver driver, string customerNumber)
        {
            CreateQuotePage createQuotePage = new CreateQuotePage(driver);
            if (!createQuotePage.IsCustomerPatched(customerNumber))
            {
                createQuotePage.TxtCustomerNumber.SetText(driver, customerNumber);
                createQuotePage.ValidateCustomerNumberPatch();
            }
        }

        public static void SaveQuote(IWebDriver driver, string customerNumber, string quoteName = "",
            string contractCode = "", string endUserCustomer = "")
        {
            PatchCustomer(driver, customerNumber);
            if (!string.IsNullOrEmpty(quoteName))
                new CreateQuotePage(driver).TxtQuoteName.SetText(driver, quoteName);
            if (!string.IsNullOrEmpty(endUserCustomer))
                new CreateQuotePage(driver).TxtEndUserCustomerNumber.SetText(driver, endUserCustomer);
            if (!string.IsNullOrEmpty(contractCode))
                new CreateQuotePage(driver).ApplyContractCodeToAllItems(contractCode);
            DraftQuoteInfo(driver);
            new CreateQuotePage(driver).SaveQuote();
            driver.Url.Contains("quote/details").Should().BeTrue();
            Logger.Write("Quote Created: " + new QuoteDetailsPage(driver).GetQuoteNumber());
        }

        public static void AutoPilotQuoteNotificationsBeforeSave(IWebDriver driver)
        {
            new CreateQuotePage(driver).VerifyAutopilotNotifications();
        }

        public static void AutoPilotQuoteNotificationsAfterSave(IWebDriver driver)
        {
            new QuoteDetailsPage(driver).VerifyAutopilotNotifications();
        }

        public static void VerifyAutopilotData(IWebDriver driver, bool verifyAutopilotSectionDisplayed,bool verifyTenantIdandDomainDataShown, string tenantId, string domain, int shippingGroupIndex = 1,int itemIndex = 1)
        {
            new CreateQuotePage(driver).VerifyAutopilotData(verifyAutopilotSectionDisplayed,verifyTenantIdandDomainDataShown, tenantId, domain, shippingGroupIndex, itemIndex);

        }
        public static void VerifyAutopilotDataQuoteSummary(IWebDriver driver, bool verifyAutopilotSectionDisplayed, bool verifyTenantIdandDomainDataShown, string tenantId, string domain, int shippingGroupIndex = 1, int itemIndex = 1)
        {
            new PCFQuoteSummaryPage(driver).VerifyAutopilotData(verifyAutopilotSectionDisplayed, verifyTenantIdandDomainDataShown, tenantId, domain, shippingGroupIndex, itemIndex);

        }
        #region Create Autopilot pop up window

        public static bool SelectAllinPopupAndVerifyTenantIdandDomain(IWebDriver driver, bool deSelect = false, bool closePopup = false)
        {
          return  new CreateQuotePage(driver).SelectAllinPopupAndVerifyTenantIdandDomain(driver, deSelect, closePopup);
        }

        public static bool SelectIteminPopupAndVerifyTenantIdandDomain(IWebDriver driver, int shippingGroupIndex = 1, int itemIndex = 1)
        {
            return new CreateQuotePage(driver).SelectIteminPopupAndVerifyTenantIdandDomain(driver,shippingGroupIndex,itemIndex);
        }
        public static void SelectIteminPopup(IWebDriver driver, int shippingGroupIndex, int itemIndex)
        {
            new CreateQuotePage(driver).SelectIteminPopup(driver, shippingGroupIndex, itemIndex);
        }
        public static void CurrentItemDomainSelectedinPopupAsperQuote(IWebDriver driver, int shippingGroupIndex, int itemIndex)
        {
            new CreateQuotePage(driver).CurrentItemDomainSelectedinPopupAsperQuote(driver, shippingGroupIndex, itemIndex);
        }
        public static void CurrentItemTenantidSelectedinPopupAsperQuote(IWebDriver driver, int shippingGroupIndex, int itemIndex)
        {
            new CreateQuotePage(driver).CurrentItemTenantidSelectedinPopupAsperQuote(driver, shippingGroupIndex, itemIndex);
        }

        public static void VerifyAutopilotDatainOrderdetilspage(IWebDriver driver,bool verifyTenantIdandDomainDataShown, string tenantId, string domain)
        {
            new OrderDetailsPage(driver).VerifyAutopilotDatainOrderdetilsPage(driver,verifyTenantIdandDomainDataShown, tenantId, domain);

        }

        #endregion Create Autopilot pop up window


        #endregion
    }
}

