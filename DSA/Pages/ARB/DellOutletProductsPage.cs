using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages.ARB

{
    public class DellOutletProductsPage : DsaPageBase
    {
        private const string pagePrefix = "outletSales";

        public DellOutletProductsPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement LnkCurrentQuote { get { return WebDriver.GetElement(By.Id("menu_currentQuote1")); } }


public IWebElement LnkReturnToAllDellProducts { get { return WebDriver.GetElement(By.Id("outletSales_return")); } }


public IWebElement ServiceTagSearchTxt { get { return WebDriver.GetElement(By.Name("txtservicetag")); } }


public IWebElement BtnSearchServiceTag { get { return WebDriver.GetElement(By.XPath("//input[@name='txtservicetag']/following-sibling::button")); } }


public IWebElement ModNumbersSearchTxt { get { return WebDriver.GetElement(By.Id("outletSales_productFilter_modNumbers")); } }


public IWebElement BtnProductFilterSearch { get { return WebDriver.GetElement(By.Id("outletSales_productFilter_submit")); } }


public IWebElement BtnProductClearFilterSearch { get { return WebDriver.GetElement(By.Id("outletSales_productFilter_clear")); } }


public IWebElement Pagination { get { return WebDriver.GetElement(By.Id("serviceTag_fromto")); } }


public IWebElement MinPriceTxt { get { return WebDriver.GetElement(By.Id("outletSales_productFilter_minPrice")); } }


public IWebElement MaxPriceTxt { get { return WebDriver.GetElement(By.Id("outletSales_productFilter_maxPrice")); } }

        //check these

public IWebElement MonitorsTab { get { return WebDriver.GetElement(By.Id("outletSales_tab_MON")); } }


public IWebElement LaptopsTab { get { return WebDriver.GetElement(By.Id("outletSales_tab_INSP")); } }


public IWebElement OptiPlexDesktopsTab { get { return WebDriver.GetElement(By.Id("outletSales_tab_OPTI")); } }


public IWebElement VostroLaptopsTab { get { return WebDriver.GetElement(By.Id("outletSales_tab_VOSNB")); } }


public IWebElement ModelFilter { get { return WebDriver.GetElement(By.XPath("//div[@id='outletSalesFilters']/div/div[6]/a")); } }


public IWebElement ModelFilterSelection { get { return WebDriver.GetElement(By.XPath("//div[@id='outletSalesFilters']/div/div[6]/ul/li[16]/label/input")); } }


public IWebElement AddOutletProductBtn { get { return WebDriver.GetElement(By.XPath("//div[6]/div/div[6]/div/a")); } }


public IWebElement ConfigureOutletProductBtn { get { return WebDriver.GetElement(By.XPath("//div[6]/div/div[6]/div/a[2]")); } }


public IWebElement ServiceTag { get { return WebDriver.GetElement(By.XPath("//div[6]/div/div[4]/div")); } }


public IWebElement ItemsMenu { get { return WebDriver.GetElement(By.Id("menu_productItems")); } }


public IWebElement lnkQuantity { get { return WebDriver.GetElement(By.XPath("//span[contains(text(),'Quantity')]")); } }

        public IWebElement LblServiceTagAt(int? itemIndex = 0)
        {
            //return WebDriver.GetElement(By.Id(pagePrefix + "_productList_" + itemIndex + "_serviceTag"));
            //after angular chages ID is removed from ARB table, so adding a workaround
            var temp = WebDriver.GetElement(By.XPath(string.Format("//*[@id='DataTables_Table_serviceTag']/tbody/tr[{0}]/td[4]",itemIndex)));
            return temp;
        }

        public IWebElement BtnAddArbItemAt(int? itemindex = 0)
        {
            // return WebDriver.GetElement(By.XPath(string.Format("//Table[@id='DataTables_Table_serviceTag']/tbody/tr[{0}]/td[6]/add-component/add-template/a", itemindex)));
            return WebDriver.GetElement(By.XPath(string.Format("//*[@id='DataTables_Table_serviceTag']/tbody/tr[1]/td[6]/add-component/add-template/a", itemindex))); 
        }

        public IWebElement BtnAddArbMonitorAt(int? itemindex = 1)
        {
            return WebDriver.GetElement(By.XPath(string.Format("//Table[@id='DataTables_Table_accessoryList_Grid']/tbody/tr[{0}]//td/add-component/add-template/a", itemindex))); //need to change this after elements are updated
        }

        public IWebElement LblQuantityAt(int? itemIndex = 0)
        {
            return WebDriver.GetElement(By.XPath(string.Format("//*[@id='DataTables_Table_accessoryList_Grid']/tbody/tr[{0}]/td[5]", itemIndex))); //need to change this after elements are updated
        }

        #endregion

        public DellOutletProductsPage FilterDellOutletProducts()
        {
            BtnProductFilterSearch.Click(WebDriver);
            return new DellOutletProductsPage(WebDriver);
        }

        public DellOutletProductsPage ClearFilterDellOutletProducts()
        {
            BtnProductClearFilterSearch.Click(WebDriver);
            return new DellOutletProductsPage(WebDriver);
        }

        public DellOutletProductsPage SearchServiceTag()
        {
            BtnSearchServiceTag.Click(WebDriver);
            return new DellOutletProductsPage(WebDriver);
        }

        public ARBConfigurePage AddDellOutletProduct()
        {
            AddOutletProductBtn.Click(WebDriver);
            ConfigureOutletProductBtn.Click(WebDriver);
            return new ARBConfigurePage(WebDriver);
        }

        public ARBConfigurePage AddWithNoConfigure()
        {
            AddOutletProductBtn.Click(WebDriver);
            return new ARBConfigurePage(WebDriver);
        }

        public ARBConfigurePage ConfigureDellOutletProduct()
        {
            ConfigureOutletProductBtn.Click(WebDriver);
            return new ARBConfigurePage(WebDriver);
        }

        public DellOutletProductsPage AddDellOutletMonitor(string accessoryNum)
        {
            //WebDriver.FindElement(By.XPath("//*[@id='DataTables_Table_1']/tbody/tr[9]/td[7]")).Click(WebDriver);
            //WebDriver.FindElement(By.XPath("//a[@id='" + accessoryNum + "']")).Click(WebDriver);

            //WebDriver.GetElement(By.XPath("//*[@id='DataTables_Table_accessoryList_Grid']/tbody/tr[1]/td[7]/add-component/add-template/a")).Click(WebDriver);
            //WebDriver.GetElement(By.XPath("//a[@id='" + accessoryNum + "']")).Click(WebDriver);
            WebDriver.GetElement(By.XPath("//td[text()='" + accessoryNum + "']/following-sibling::td//a")).Click(WebDriver);
            WebDriver.VerifyBusyOverlayNotDisplayed();
            return new DellOutletProductsPage(WebDriver);
        }

        public DellOutletProductsPage ModelFilterSelections()
        {
            ModelFilter.Click(WebDriver);
            ModelFilterSelection.Click(WebDriver);
            BtnProductFilterSearch.Click(WebDriver);
            return new DellOutletProductsPage(WebDriver);
        }

        public string GetServiceTag()
        {
            return ServiceTag.GetText(WebDriver).ToString();
        }
    }
}
