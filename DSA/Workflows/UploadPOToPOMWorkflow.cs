using System;
using System.IO;
using System.Diagnostics;
using Dsa.Pages;
using OpenQA.Selenium;
//using Dsa.Util;
using Dsa.Utils;

namespace Dsa.Workflows
{
    public class UploadPOToPOMWorkflow
    {
        #region UploadPPOMFile
        /// <summary>
        /// This method is used to generate a POM file and will attach the POMFile. The same method can also be used to attach a supplementary document
        /// By default it will attach a POM File. If we pass any string value then it will attach a supplementary document
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="fileType"> fileType can be any string value</param>
        /// <returns>UploadPOToPOMPage</returns>
        public static UploadPOToPOMPage UploadPOMFile(IWebDriver driver, string fileType = null)
        {
            UploadPOToPOMPage uploadPOToPOMPage = new UploadPOToPOMPage(driver);
            uploadPOToPOMPage.LnkUploadPO.Click(driver);
            uploadPOToPOMPage.WaitforUploadPOToPOMPageDisplay();
            //Process process = null;
                try
            {
            if (fileType == null)
            {
                uploadPOToPOMPage.BtnChooseFile.Click();
            }
            else
            {
                UploadPOToPOMPage uploadPOToPOMPage1 = new UploadPOToPOMPage(driver);
                if (uploadPOToPOMPage.LnkAddSupplementaryDoc.Displayed)
                {
                    uploadPOToPOMPage.LnkAddSupplementaryDoc.Click();
                }
                uploadPOToPOMPage = uploadPOToPOMPage1;
            }

                //process = Process.Start(Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())), "UploadPomFileParam.exe"), uploadPOToPOMPage.GeneratePOMFile(fileType));
                //process = Process.Start(Path.Combine(new DirectoryInfo(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"dsa-test-automation\DSA\Utils\AutoItScripts\UploadPomFileParam.exe"), uploadPOToPOMPage.GeneratePOMFile(fileType));
                uploadPOToPOMPage.ClickAndEnterpath(@"dsa-test-automation\app.config");                
                //System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                //process.CloseMainWindow();
                //process.Close();
            }
            catch (Exception ex) { }
            return uploadPOToPOMPage; 
        }
        
        #endregion

        #region GeneratePOMId
        /// <summary>
        /// This method is used to generate the POMId for the given Order
        /// Prerequisite is to upload a Pomfile 
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="destinationWorkGroupDdlValue"> Give the Workgroup Id to select form the dropdown</param>
        /// <param name="pickAnEmailAddress">Give the Email Address/Custom</param>
        /// <param name="poNumber">PO Number </param>
        /// <param name="poAmount">PO Amount</param>
        /// <param name="customerName">Customer Name</param>
        /// <param name="poSourceAddress"> Email/Fax</param>
        /// <param name="customEmailAddress">Give the Custom Email Id(non Dell Id)</param>
        /// <param name="faxNumber">Fax Number</param>
        /// <param name="salesRepNumber">Sales Rep Number</param>
        /// <param name="poComments">PO Comments</param>
        /// <param name="poType">Blanket/Credit</param>
        /// <returns>CreateOrderWorkflow page</returns>

        public static CreateOrderWorkflow GeneratePOMId(IWebDriver driver, string destinationWorkGroupDdlValue, string pickAnEmailAddress, string poNumber, string poAmount, out string pomId, string customerName = null, string poSourceAddress = null, string customEmailAddress = null, string faxNumber = null, string salesRepNumber = null, string poComments = null, string poType = null)
        {
            UploadPOToPOMPage uploadPOToPOMPage = new UploadPOToPOMPage(driver);
            uploadPOToPOMPage.DdlDestinationWrkGrp.PickDropdownByText(driver, destinationWorkGroupDdlValue);
            uploadPOToPOMPage.TxtPONumber.SetText(driver, poNumber);
            uploadPOToPOMPage.TxtPOAmount.SetText(driver, poAmount);
            
            if (poSourceAddress != null)
            {
                if (!poSourceAddress.ToLower().Contains("mail"))
                {
                    uploadPOToPOMPage.RdbPOSourceFax.Click();
                    uploadPOToPOMPage.TxtFaxNumber.SetText(driver, faxNumber);
                }          
            }

            uploadPOToPOMPage.DdlPOSourceAddress.PickDropdownByText(driver, pickAnEmailAddress);
            if (pickAnEmailAddress.ToLower().Contains("custom"))
                uploadPOToPOMPage.TxtCustomEmailAddress.SetText(driver, customEmailAddress);
            if (customerName != null)
                uploadPOToPOMPage.TxtCustomerName.SetText(driver, customerName);
            if (salesRepNumber != null)
                uploadPOToPOMPage.TxtSaleRepNumber.SetText(driver, salesRepNumber);
            if (poComments != null)
                uploadPOToPOMPage.TxtPOComments.SetText(driver, poComments);
            if (poType.ToLower().Contains("credit"))
                uploadPOToPOMPage.ChkCreditCardPO.SelectCheckBox(driver);
            else if (poType.ToLower().Contains("blanket"))
                uploadPOToPOMPage.ChkBlanketPO.SelectCheckBox(driver);
            uploadPOToPOMPage.SavePO();
            pomId = uploadPOToPOMPage.POMIdnumber.GetText(driver);
            return new CreateOrderWorkflow();
        }
        #endregion
    }
}
