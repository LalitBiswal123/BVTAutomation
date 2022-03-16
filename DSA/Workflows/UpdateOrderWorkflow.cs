using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using Dsa.Pages.Customer;
using Dsa.Pages.Order;
using Dsa.Pages.PCFConvergence;
using Dsa.Pages.Quote;
using Dsa.Utils;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;

namespace Dsa.Workflows
{
    public static class UpdateOrderWorkflow
    {
        #region Create Quote with Tied SKU WebAPI
        //public static string CreateQuoteWithTiedSKU_WebAPI(string companyNumber, string quoteName, string shippingAddressName, List<string> orderCodes, string quantity, string customerNumber, string shippingMethod )
        //{
        //    var apiServerUrl = ConfigurationManager.AppSettings["ApiUrl"];

        //    var dsaContext = CommonRequests.GetDsaContext(companyNumber, apiServerUrl);
        //    var newCartId = DL.CreateQuote.GetNewCart(apiServerUrl, dsaContext);
        //    //var customerNumber = DL.Customer.DoesCustomerExistElseCreate(apiServerUrl, dsaContext, newCustomer);
        //    DL.CreateQuote.AddCustomerToQuote(customerNumber, apiServerUrl, newCartId, dsaContext);
        //    DL.CreateQuote.AddQuoteNameToQuote(quoteName, apiServerUrl, newCartId, dsaContext, 0);
        //    var shippingAddressId = DL.CreateQuote.GetShippingAddressIdOrCreateMergeAddress(companyNumber, apiServerUrl, dsaContext, customerNumber, shippingAddressName);

        //    DL.CreateQuote.AddNewDefaultShippingAddressToCart(customerNumber, shippingAddressId, apiServerUrl, newCartId, dsaContext);
        //    var orderCodesUniqueIds = DL.CreateQuote.GetProductData(orderCodes, apiServerUrl, dsaContext);

        //    DL.CreateQuote.AddLineItemsToQuote(orderCodesUniqueIds, apiServerUrl, newCartId, dsaContext);
        //    // DL.CreateQuote.AddContractCodeToQuote(contractCode, orderCodesUniqueIds.First().Item2, apiServerUrl, newCartId, dsaContext, "HC");
        //    foreach (var orderCodesUniqueId in orderCodesUniqueIds)
        //    {
        //        DL.CreateQuote.UpdateQuantityForEachLineItem(quantity, orderCodesUniqueId.Item1, orderCodesUniqueId.Item2, apiServerUrl, newCartId, dsaContext);
        //        if (string.IsNullOrWhiteSpace(shippingMethod))
        //        {
        //            DL.CreateQuote.UpdateShipppingMethodForEachLineItem(shippingMethod,
        //                orderCodesUniqueId.Item2, apiServerUrl, newCartId, dsaContext, customerNumber);
        //        }
        //    }

        //    string quote = DL.CreateQuote.SaveQuote(newCartId, apiServerUrl, dsaContext, 0);
        //    return quote;
        //}

        #endregion

        #region Creating Order with Tied SKU
        //public static string CreatingOrderWithTiedSKU(string companyNumber, string customerNumber, long quoteid, int versionId, string SalesRepEmailId, string sendOrderConfToEmailId, string PaymentCategoryType, int SlotId, bool IsExport, string ProductUsage = "Home")
        //{
        //    string response;
        //    HttpStatusCode statusCode;

        //    var apiServerUrl = ConfigurationManager.AppSettings["ApiUrl"];

        //    var dsaContext = CommonRequests.GetDsaContext(companyNumber, apiServerUrl);

        //    //Get Quote with QuoteNumber to fetch the price
        //    HttpWebRequestsUtil.GetHttpWebRequest(apiServerUrl, string.Format("/api/v1/quotes/{0}/0?skipQuoteValidation=false", quoteid), out response, out statusCode, null, null, dsaContext);
        //    dynamic finalPrice = JObject.Parse(response);
        //    var fPrice = finalPrice["pricingSummary"]["finalPrice"]["value"].Value;

        //    //create a new cart for creating an order
        //    HttpWebRequestsUtil.CreateWebRequest(apiServerUrl, string.Format("/api/v1/quotes/{0}/{1}/order?insuredItem=", quoteid, versionId), "", dsaContext, out response, out statusCode, "application/json");
        //    string newCartId = response;

        //    //Updating the export intent
        //    var exportIntent = new ExportIntent();
        //    exportIntent.IsExport = Convert.ToString(IsExport);
        //    if (IsExport == false)
        //    {
        //        exportIntent.ProductUsage = ProductUsage;
        //    }
        //    var jexportintent = JsonConvert.SerializeObject(exportIntent);
        //    HttpWebRequestsUtil.PatchWebRequest(apiServerUrl, string.Format("/api/v1/carts/{0}/exportIntent", newCartId), jexportintent, dsaContext, out response, out statusCode);


        //    //PatchSmartPriceDtaa and Sales Rep//check
        //    HttpWebRequestsUtil.CreateWebRequest(apiServerUrl, string.Format("/api/v1/orders/{0}/patchSmartPriceData?isSmartPrice=false&salesRepEmail={1}", newCartId, SalesRepEmailId), "", dsaContext, out response, out statusCode);

        //    //Patch Send Order Confirmation metadata
        //    OrderConfirmationData[] orderConfData = {
        //       new OrderConfirmationData  {            
        //    IsCcRequired = false,
        //    Format = "Pdf",
        //    IsOrderConfirmation = true,
        //    Language = "EN",
        //    SendTo = sendOrderConfToEmailId
        //    },
        //        new OrderConfirmationData  {
        //    IsCcRequired = false,
        //    Format = "Pdf",
        //    IsOrderAcknowledgement = true,
        //    Language = "EN",
        //    SendTo = sendOrderConfToEmailId
        //    }        
        //    };

        //    var jOrderConfData = JsonConvert.SerializeObject(orderConfData);
        //    HttpWebRequestsUtil.PatchWebRequest(apiServerUrl, string.Format("/api/v1/carts/{0}/saveorderordercfometadata", newCartId), jOrderConfData, dsaContext, out response, out statusCode);


        //    //Save payments
        //    var savePaymentsInformation = new SavePaymentsInformation();
        //    savePaymentsInformation.PoDateReceived = System.DateTime.Now;//DateTime.Parse(TestContext.DataRow["PoDateReceived"].ToString());
        //    savePaymentsInformation.PoNumber = "";

        //    var basePaymentOption = new BasePaymentOption();
        //    var currency = new Currency();
        //    currency.Value = Convert.ToDecimal(fPrice);
        //    basePaymentOption.Amount = currency;

        //    var quotePayment = new List<QuotePayment>() {
        //        new QuotePayment {
        //        PaymentCategoryType = PaymentCategoryType,
        //        paymentDetails = basePaymentOption,
        //        SlotId = SlotId
        //        }
        //    };

        //    savePaymentsInformation.Payments = quotePayment;
        //    var jsavepayment = JsonConvert.SerializeObject(savePaymentsInformation);

        //    HttpWebRequestsUtil.PatchWebRequest(apiServerUrl, string.Format("/api/v1/carts/{0}/savepayments", newCartId), jsavepayment, dsaContext, out response, out statusCode);

        //    var paymentResult = JsonConvert.DeserializeObject<PaymentResult>(response);

        //    //Save an order
        //    var createOrder = new DL.Models.CreateOrder();
        //    createOrder.CartId = newCartId;
        //    createOrder.DpId = 0;
        //    createOrder.IsUpdateOrder = false;
        //    createOrder.QuoteNumber = quoteid;
        //    var jcreteorder = JsonConvert.SerializeObject(createOrder);
        //    HttpWebRequestsUtil.CreateWebRequest(apiServerUrl, string.Format("/api/v1/orders", customerNumber), jcreteorder, dsaContext, out response, out statusCode, "application/json");

        //    var createorderresponse = JsonConvert.DeserializeObject<CreateOrderResponse>(response);

        //    return response;
        //}

        #endregion

        #region UpdateOrderUpdateInstallAtCustomer

        public static void UpdateOrderUpdateInstallAtCustomer(IWebDriver driver, string DPIDtoUpdate, string InstallAtCustomer, string InstallAt_DifferentCustomer = "")
        {
            //OrderDetailsPage orderDetailsPage = new OrderDetailsPage(driver);
            //orderDetailsPage.GetDpidFromOrderDetails().Should().BeEquivalentTo(DPIDtoUpdate);
            //orderDetailsPage.UpdateOrder();
            new PCFOrderDetailsPage(driver).UpdateOrder();
            CreateQuotePage createQuotePage = new CreateQuotePage(driver);

            var totalGroupsInQuote = createQuotePage.GetNumberofShippingGroups();
            if (totalGroupsInQuote > 1)
            {
                createQuotePage.changeInstallAtforfirstShippingGroup(driver, InstallAtCustomer, InstallAt_DifferentCustomer, "standard");
                createQuotePage.changeInstallAtforsecondShippingGroup(driver, InstallAtCustomer, "standard");
            }
            else
            {
                createQuotePage.changeInstallAtforfirstShippingGroup(driver, InstallAtCustomer, InstallAt_DifferentCustomer, "standard");
            }

        }                      
        #endregion

    }
}
