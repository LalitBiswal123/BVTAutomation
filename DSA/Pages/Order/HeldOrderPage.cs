using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.Order
{
    public class HeldOrderPage : DsaPageBase
    {
        public HeldOrderPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(WebDriver, this);
        }



        #region Elements


        public IWebElement LnkCvHoldToggle { get { return WebDriver.GetElement(By.Id("CVHold_holdsToggle")); } }


        public IWebElement LnkPvHoldToggle { get { return WebDriver.GetElement(By.Id("PVHold_holdsToggle")); } }


        public IWebElement LnkTaxHoldToggle { get { return WebDriver.GetElement(By.Id("Tax Hold_holdsToggle")); } }


        public IWebElement TblCvHold { get { return WebDriver.GetElement(By.XPath("//*[@id='CVHold_OrderHoldGrid']//table")); } }


        public IWebElement TblPvHold { get { return WebDriver.GetElement(By.XPath("//*[@id='PVHold_OrderHoldGrid']")); } }


        public IWebElement TblTaxHold { get { return WebDriver.GetElement(By.XPath("//*[@id='TAXHOLD_OrderHoldGrid']//table/tbody")); } }


        public IWebElement HldOrderDpidTxtElement { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridOrderHolds']//span[normalize-space()='DPID']/..//input")); } }


        public IWebElement DpidLinkElement { get { return WebDriver.GetElement(By.Id("gridOrderHolds-0-")); } }





        public IWebElement TblPvHoldtype { get { return WebDriver.GetElement(By.XPath("*//tr[1]//th[4]//div[@class='ms-parent ms-checkbox']//div")); } }



        public IWebElement selectHoldtype { get { return WebDriver.GetElement(By.XPath("*//th[4]/div/div/div/div/multi-select/div/div[2]/ul/li[1]/label")); } }


        public IWebElement selectcvHoldtype { get { return WebDriver.GetElement(By.XPath("*//th[4]/div/div/div/div/multi-select/div/div[2]/ul/li")); } }


        public IWebElement checkedcvHoldtype { get { return WebDriver.GetElement(By.XPath("*//th[4]/div/div/div/div/multi-select/div/div[2]/ul/li[3]/label/input")); } }


        public IWebElement checkedpvHoldtype { get { return WebDriver.GetElement(By.XPath("*//th[4]/div/div/div/div/multi-select/div/div[2]/ul/li[15]/label/input")); } }


        public IWebElement checkedcreditHoldtype { get { return WebDriver.GetElement(By.XPath("*//th[4]/div/div/div/div/multi-select/div/div[2]/ul/li[4]/label/input")); } }


        public IWebElement checkedtaxHoldtype { get { return WebDriver.GetElement(By.XPath("*//th[4]/div/div/div/div/multi-select/div/div[2]/ul/li[23]/label/input")); } }


        public IWebElement cvholdtype { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridOrderHolds']/tbody/tr[1]/td[4]")); } }


        public IWebElement LnkCvHoldToggle1 { get { return WebDriver.GetElement(By.Id("COM")); } }


        public IWebElement heldorderpage { get { return WebDriver.GetElement(By.Id("orderSearch_title")); } }


        public IWebElement cvholdtype1 { get { return WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_gridOrderHolds']/thead/tr/th[4]/div/div/div/div/multi-select/div/div[2]/ul")); } }

        public IWebElement HoldTypeDropdown { get { return WebDriver.GetElement(By.ClassName("ms-choice")); } }

        public IWebElement SearchButton { get { return WebDriver.GetElement(By.Id("heldOrdersSearch")); } }


        #endregion

        #region Actions

        public void FilterHoldType(string holdType)
        {
            string xpath = string.Format("//*[contains(text(),'{0}')]/input", holdType);
            var holdCheckBoxes = WebDriver.GetElements(By.XPath(xpath));
            foreach(var checkbox in holdCheckBoxes)
            {
                checkbox.Click();
            }
        }

        #endregion
    }
}
