using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
   public class AddConfigServiceComments : DsaPageBase
    {
        public AddConfigServiceComments(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        #region Elements


public IWebElement TxtAddCommentCode { get { return WebDriver.GetElement(By.Id("productConfig_addCommentCode_0")); } }


public IWebElement TxtAddComment { get { return WebDriver.GetElement(By.Id("productConfig_addCommentTextCode_0")); } }


public IWebElement ChkBoxInclude { get { return WebDriver.GetElement(By.Id("productConfig_addCommentInclude_0")); } }


public IWebElement BtnApplyConfig { get { return WebDriver.GetElement(By.Id("productConfig_ApplyCs")); } }


public IWebElement BtnCancelConfig { get { return WebDriver.GetElement(By.Id("productConfig_CancelCs")); } }

        #endregion

    }
}
