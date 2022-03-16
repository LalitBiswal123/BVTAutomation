using System.Collections.Generic;
using System.Linq;
using Dsa.Pages;
using Dsa.Utils;
using OpenQA.Selenium;
using HomeWorkFlow = Dsa.Workflows.HomeWorkflow;
using ProductSearchHomePage = Dsa.Pages.Product.ProductSearchPage;
using System.Collections.ObjectModel;
using Dsa.Pages.Order;


namespace Dsa.Workflows
{
    /// <summary>
    /// Workflow class for Product Search Page. All product search related workflows should be defined in this class.
    /// </summary>
    public static class ProFormaInvoiceWorkflow
    {
        #region ProForma Invoice Details
        public static string ProFormaInvoiceDetails(IWebDriver driver, string SKUNumberDisplay, string ShippingAddressDisplay, string Format, string sendInvoiceTo)
        {
            DsaUtil.WaitForWaitAnimationToLoad(driver);
            var dpid = new OrderDetailsPage(driver).GetDpidFromOrderDetails();
            var ProformaInvoicePageInstance = new ProFormaInvoicePage(driver);
            new OrderDetailsPage(driver).ProFormaInvoice();
            DsaUtil.WaitForWaitAnimationToLoad(driver);
            ProformaInvoicePageInstance.IsSKUNumberDisplayDisabled();
            //ProformaInvoicePageInstance.selectSKUNumberDisplay(SKUNumberDisplay);-- Greyed out
            ProformaInvoicePageInstance.selectShippingAddressDisplay(ShippingAddressDisplay);
            ProformaInvoicePageInstance.selectFormat(Format);
            ProformaInvoicePageInstance.selectPrimarySalesRep();
            ProformaInvoicePageInstance.selectOrders();
            ProformaInvoicePageInstance.sendInvoiceTo(sendInvoiceTo);
            ProformaInvoicePageInstance.ClicksendInvoice();
            return dpid;
        }

        #endregion

        #region Limitations
        public static bool Limitations(IWebDriver driver)
        {
            var ProformaInvoicePageInstance = new ProFormaInvoicePage(driver);
            int StatusPos = ProformaInvoicePageInstance.GetStatusPos();
            ReadOnlyCollection<IWebElement> rowsTable = ProformaInvoicePageInstance.Orders();
            int rowCount = rowsTable.Count;
            var status = true;
            for (int row = 0; row < rowCount; row++)
            {
                ReadOnlyCollection<IWebElement> Columns_row = rowsTable.ElementAt(row).FindElements(By.TagName("td"));
                var Orderstatus = Columns_row.ElementAt(StatusPos).Text;
                if ((Orderstatus.Equals("INV")) || (Orderstatus.Equals("CL")))
                {
                    if (Columns_row.ElementAt(0).Enabled)
                    {
                        status = false;
                        break;
                    }

                }

            }
            return status;


        }

        #endregion

        #region Check Cancelled Orders
        public static bool CheckCancelledOrders(IWebDriver driver)
        {
            var ProformaInvoicePageInstance = new ProFormaInvoicePage(driver);
            ReadOnlyCollection<IWebElement> orders = driver.FindElements(By.XPath("//div[label[contains(text(),'Order Status:')]]/div"));
            List<string> OrderStatus = new List<string>();
          
            int i=0;
            do
            {
                string status = orders.ElementAt(i).GetText(driver);
                OrderStatus.Add(status);
                i++;
            } while (i < orders.Count);
            bool isCancelled = true;
            foreach (string j in OrderStatus)
            {
                if (j.Equals("Cancelled"))
                {
                    isCancelled = false;
                    break;
                }
            }
            return isCancelled;

        }

        #endregion

        #region Verify ProForma
        public static bool VerifyProForma(IWebDriver driver)
        {
            var OrderdetailsPageInstance = new OrderDetailsPage(driver);
            OrderdetailsPageInstance.LnkMoreActions.Click();
            return OrderdetailsPageInstance.LnkProformaInvoice.Displayed;

        }
        #endregion
        
    }
}