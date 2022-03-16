using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Dsa.Constants;
using Dsa.Enums;

namespace Dsa.Pages
{
   public class PreviewOrderCodePage : DsaPageBase
    {
        public PreviewOrderCodePage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements
       

public IWebElement OrderCodeId { get { return WebDriver.GetElement(By.Id("productSearch_orderCode")); } }


public IWebElement BtnProductSearch { get { return WebDriver.GetElement(By.Id("productSearch_SearchButton")); } }


public IWebElement ProductName { get { return WebDriver.GetElement(By.Id("productConfig_productInfoLI_detailslink_0")); } }


public IWebElement PreviewProductOrderCode { get { return WebDriver.GetElement(By.Id("productConfig_productInfoLI_orderCode_0")); } }




        #endregion

       private readonly By _byOrderCodeTxt = By.Id(ProductIDs.OrderCodeId);
       private readonly By _bySearchBtn = By.Id(ProductIDs.ProductSearchButtonId);

       private IWebElement OrderCodeTxt
       {
           get { return WebDriver.GetElement(_byOrderCodeTxt); }
       }

       private IWebElement SearchBtn
       {
           get { return WebDriver.GetElement(_bySearchBtn); }
       }

       /// <summary>
       /// Gets or sets the Order Code.
       /// </summary>
       /// <value></value>
       public string OrderCode
       {
           get { return _byOrderCodeTxt.GetText(WebDriver); }
           set { _byOrderCodeTxt.SetText(WebDriver, value); }
       }

       /// <summary>
       /// Executes the search.
       /// </summary>
       public void ExecuteSearch()
       {
           _bySearchBtn.Click(WebDriver);
       }

       /// <summary>
       /// Select Catalog in Preview Page
       /// </summary>
       private readonly By _catalogGrid = By.Id(ProductIDs.CatalogGrid);
       public PreviewOrderCodePage SelectCatalog(Catalogs catalog)
       {
           var selectCatalog = new SelectCatalogDialog(this.WebDriver);
           selectCatalog.SelectCatalog(catalog);

           return this;
       }

       

    }
}
