using System.Runtime.InteropServices.WindowsRuntime;
using Dsa.Pages;
using Dsa.Pages.Order;
using Dsa.Pages.PCFConvergence;
using Dsa.Utils;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Dsa.Workflows
{
    /// <summary>
    /// ARB workflows will be defined in this class.
    /// </summary>
    public static class PCFCancelOrderWorkflow
    {
        #region Cancel order


        public static void CancelOrder(IWebDriver driver, string dpid)
        {
            HomeWorkflow.GoToOrderSearchPage(driver).SearchOrderByDpidNumber(dpid);
            if (!IsOrderProcessingStatusOnHoldOrComplete(driver))
            {
                Logger.Write("Cannot Cancel Order. Order Processing Status is stuck on INW or ORL for this DPID: " + dpid);
                Assert.Fail("Cancel Order failed");
            }
            else
            {
                try
                {
                    new PCFOrderDetailsPage(driver).CancelOrder()
                        .SelectReason("Customer has cancelled the order");
                    new PCFCancelOrderPage(driver).OrderCancellationComments("cancel order test")
                       .ClickCancelOrderNextBtn();
                    new PCFCancelOrderPage(driver).LblCancelOrderSuccessMsg.IsElementDisplayed(driver).Should().BeTrue();
                    new PCFCancelOrderPage(driver).ClickCancelOrderSuccessBtn();
                    Logger.Write("Cancel Order success for DPID: " + dpid);
                    driver.RefreshCurrentPage();
                }
                catch (NoSuchElementException e)
                {
                    Logger.Write("Unable to cancel this order - DPID : " + dpid);
                    Assert.Fail("Cancel Order failed");
                }
            }
        }

        #endregion

        #region Check if order is on hold or complete or NAK

        public static bool IsOrderProcessingStatusOnHoldOrComplete(IWebDriver driver)
        {
            var orderProcessingStatus = new PCFOrderDetailsPage(driver).OrderProcessiongStatus.GetText(driver);
            var attempts = 10;

            //Refresh Order Details page to get latest order processing status
            while (attempts != 0)
            {
                //check if cancel order can be allowed based on order processing status
                if (orderProcessingStatus.Contains("HLD") || orderProcessingStatus.Contains("CMP") || orderProcessingStatus.Contains("NAK"))
                {
                    break;
                }
                driver.RefreshCurrentPage();
                driver.WaitFor(x => new PCFOrderDetailsPage(driver).OrderProcessiongStatus.Displayed, 90);
                attempts -= 1;

                if (attempts == 0)
                {
                    return false; //Order is stuck in INW or ORL
                }
            }
            return true; //Order is either HLD/CMP/NAK
        }

        #endregion


        public static bool CheckOrderProcessing_CancelOrder(IWebDriver driver,string beforeOrAfter)
        {
            if (beforeOrAfter=="before")
            {
                var refreshCounter = 0;
                while (new PCFOrderDetailsPage(driver).pcfGetOrderProcessingStatusOfDpid().Contains("INW"))
                {
                    driver.RefreshCurrentPage();
                    refreshCounter += 1;
                    if (refreshCounter >= 7)
                        break;
                }
                if (!new PCFOrderDetailsPage(driver).pcfGetOrderProcessingStatusOfDpid().Contains("INW"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (beforeOrAfter == "after")
            {
                var refreshCounter = 0;
                while (new PCFOrderDetailsPage(driver).pcfGetOrderProcessingStatusOfDpid().Contains("TBC") || new OrderDetailsPage(driver).GetOrderProcessingStatusOfDpid().Contains("HLD"))
                {
                    driver.RefreshCurrentPage();
                    refreshCounter += 1;
                    if (refreshCounter >= 7)
                        break;
                }
                if (new PCFOrderDetailsPage(driver).pcfGetOrderProcessingStatusOfDpid().Contains("TBC") ||
                    new PCFOrderDetailsPage(driver).pcfGetOrderProcessingStatusOfDpid().Contains("HLD"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
