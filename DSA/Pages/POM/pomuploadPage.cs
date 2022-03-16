using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;

namespace Dsa.Pages.POM
{
    public class pomuploadPage : DsaPageBase
    {
        public pomuploadPage(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "pomuploadPage";
            PageFactory.InitElements(webDriver, this);
            webDriver.VerifyBusyOverlayNotDisplayed();
        }

        #region pomuploadPage


public IWebElement UploadPOToPOMHeader { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_header")); } }


public IWebElement UploadnewPOToPOMHeader { get { return WebDriver.GetElement(By.Id("quoteDetail_new_pomIdRequest_header")); } }



public IWebElement Uploadcreatenewpo { get { return WebDriver.GetElement(By.Id("quoteDetail_new_pomIdRequest_createNew")); } }


public IWebElement choosefile { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_pomFileUpload_chooseFile']")); } }



public IWebElement destinationWorkgroup { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_sendPoRequest_destinationWorkgroup']")); } }


public IWebElement pocustomerNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_sendPoRequest_customerNumber']")); } }


public IWebElement pocustomerName { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_sendPoRequest_customerName']")); } }


public IWebElement emailvalue { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_sendPoRequest_poSourceAddressList_emailValue']")); } }


public IWebElement salesRepNumber { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_sendPoRequest_salesRepNumber']")); } }

   
        public IWebElement ponumber { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_sendPoRequest_poNumber']")); } }



        public IWebElement poamount { get { return WebDriver.GetElement(By.XPath("//*[@id='quoteDetail_sendPoRequest_poAmount']")); } }


public IWebElement TxtPOComments { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_comments")); } }


public IWebElement ChkCreditCardPO { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_creditCardPO")); } }


public IWebElement ChkBlanketPO { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_blanketPO")); } }


public IWebElement BtnSend { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_send")); } }


public IWebElement BtnCancel { get { return WebDriver.GetElement(By.Id("quoteDetail_sendPoRequest_cancel")); } }


public IWebElement BtnYes { get { return WebDriver.GetElement(By.XPath("//button[@id='quoteDetail_sendPoRequest_close' and text()='Yes']")); } }


public IWebElement BtnNo { get { return WebDriver.GetElement(By.XPath("//button[@id='quoteDetail_sendPoRequest_close' and text()='No']")); } }


public IWebElement BtnOk { get { return WebDriver.GetElement(By.XPath("//button[@id='quoteDetail_sendPoRequest_close' and text()='Ok']")); } }


public IWebElement POMIDSuccess { get { return WebDriver.GetElement(By.XPath("//h4[text()='Success!']")); } }


public IWebElement BtnEnterFile { get { return WebDriver.GetElement(By.Id("quoteDetail_pomFileUpload_primaryPOUpload")); } }
        #endregion

        public void ClickChoosefile()
        {
            choosefile.Click(WebDriver);
        }


        public string GetpocustomerName()
        {
            return pocustomerName.GetText(WebDriver);
        }
        public string GetpocustomerNumber()
        {
            return pocustomerNumber.GetText(WebDriver);
        }
        public string Getemailvalue()
        {
            return emailvalue.GetText(WebDriver);
        }
        public string Getponumber()
        {
            return ponumber.GetText(WebDriver);
        }

        public pomuploadPage EnterPoNumber(string poNumber)
        {
            //txtponumber.SetText(WebDriver, poNumber);
            WebDriver.WaitForPageLoad();
            return new pomuploadPage(WebDriver);

        }
        public string GetsalesRepNumber()
        {
            return salesRepNumber.GetText(WebDriver);
        }

        public string GeneratePOMFile(string fileType = null)
        {
            string pomFile = null;
            if (fileType == null)
                pomFile = @"C:\Temp\POMIDFile.txt";
            else
                pomFile = @"C:\Temp\SupplementaryPOMIDFile.txt";
            // <!-- try
            {
                // if (!Directory.Exists(@"C:\Temp"))
                //     Directory.CreateDirectory(@"C:\Temp");
                // if (!File.Exists(pomFile))
                {
                    // System.IO.StreamWriter file = new System.IO.StreamWriter(File.Create(pomFile));
                    // file.WriteLine("This is for uploadong a POM file");
                    //  file.Close();
                }
            }
            // catch (Exception ex) { }-->

            return pomFile;
        }
        public void WaitforUploadPOToPOMPageDisplay()
        {
            // WebDriver.VerifyBusyOverlayNotDisplayed();
            if (UploadPOToPOMHeader.Displayed) { 
                new pomuploadPage(WebDriver).upload();
            }
        }

        //public void WaitforUploadnewPOToPOMHeadereDisplay()
       // {
            // WebDriver.VerifyBusyOverlayNotDisplayed();
         //   if( UploadnewPOToPOMHeader.Displayed)
         //   {
         //       new pomuploadPage(WebDriver).Clickcreatenewfile();
         //       new pomuploadPage(WebDriver).upload();
         //   }
       // }

        public void Clickcreatenewfile()
        {
            Uploadcreatenewpo.Click(WebDriver);
        }
        public void uploadpomdetails()
        {
            destinationWorkgroup.PickDropdownByText(WebDriver, "ABU INK TONER WORKGROUP");
            emailvalue.PickDropdownByIndex(WebDriver, 1);
            salesRepNumber.SendKeys("12834");
            poamount.SendKeys("133");
        }
        public void SavePO()
        {
            BtnSend.Click(WebDriver);
            BtnYes.Click(WebDriver);
            if (POMIDSuccess.Displayed)
                Logger.Write("The Pom Id generated successfully!");
            BtnOk.Click(WebDriver);

        }

        public void upload()
        { 
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
        js.ExecuteScript("arguments[0].click()", choosefile);
            BtnEnterFile.SendKeys(@"\\10.116.159.50\\DsaBuilds\\LegacyPOMFile.txt"); 
        }

       
    }
}
