using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Dsa.Pages
{
   public class ExportProfileUsers : DsaPageBase
    {

        private readonly By _byDestinationFileNameTxt = By.Id("fileDestination_name");
        private readonly By _byExportBtn = By.Id("profilesExport_button");
        private IWebElement DestinationFileNameTxt
        {
            get { return WebDriver.GetElement(_byDestinationFileNameTxt); }
        }

        private IWebElement ExportBtn
        {
            get { return WebDriver.GetElement(_byExportBtn); }
        }

        public ExportProfileUsers(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        /// <summary>
        /// 
        /// </summary>
                
        public bool DestinationFileNamePresent()
        {
            return DestinationFileNameTxt.Displayed;
        }

        #region Elements


public IWebElement TxtDestinationFileName { get { return WebDriver.GetElement(By.Id("fileDestination_name")); } }


public IWebElement BtnExport { get { return WebDriver.GetElement(By.Id("profilesExport_button")); } }


public IWebElement downloadNotification { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/div[2]/form/div[3]/div")); } }


public IWebElement BtnExportUsers { get { return WebDriver.GetElement(By.Id("usersExport_button")); } }
        
        #endregion

    }
}
