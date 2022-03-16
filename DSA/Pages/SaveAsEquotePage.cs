using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
    public class SaveAsEquotePage : DsaPageBase
    {
        public SaveAsEquotePage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        } 
        //TODO : Need to check
    }
}
