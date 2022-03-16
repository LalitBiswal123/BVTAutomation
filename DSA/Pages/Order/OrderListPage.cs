using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Order
{
    public class OrderListPage : DsaPageBase
    {
        public OrderListPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        //TODO : 
    }
}
