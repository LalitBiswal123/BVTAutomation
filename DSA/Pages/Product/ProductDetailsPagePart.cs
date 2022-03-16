using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace Dsa.Pages.Product
{
    public class ProductDetailsPagePart : DsaPageBase
    {
        public ProductDetailsPagePart(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement OrderCodeId { get { return WebDriver.GetElement(By.Id("productDetail_orderCode")); } }


public IWebElement ProductDetailsConfigType { get { return WebDriver.GetElement(By.Id("productDetail_ConfigurationType")); } }


public IWebElement ProductDetailsStartingPrice { get { return WebDriver.GetElement(By.Id("productDetail_ListPrice")); } }


public IWebElement AddToQuoteDetailsView { get { return WebDriver.GetElement(By.Id("productResult_grid_Add")); } }


public IWebElement BtnAddAnother { get { return WebDriver.GetElement(By.Id("productResult_grid_addAnother")); } }


public IWebElement btnConfigure { get { return WebDriver.GetElement(By.Id("productResult_grid_configure")); } }


public IWebElement CloseProductDetails { get { return WebDriver.GetElement(By.ClassName("modal-close")); } }


public IList<IWebElement> BtnList { get { return WebDriver.GetElements(By.XPath("//button[@class='btn btn-default']")); } }

public IList<IWebElement> BtnAddAnotherTechSpec { get { return WebDriver.GetElements(By.XPath("//*[@id='productResult_grid_addAnother']")); } }

        #endregion
    }
}
