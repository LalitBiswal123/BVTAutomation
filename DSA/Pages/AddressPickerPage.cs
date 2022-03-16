using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{ 
    public class AddressPickerPage : DsaPageBase
    {
        public AddressPickerPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);        
        }

        #region Elements
   

private IWebElement AddressGridElement { get { return WebDriver.GetElement(By.Id("addressSelect_addressGrid")); } }
       
        #endregion

    }
}
