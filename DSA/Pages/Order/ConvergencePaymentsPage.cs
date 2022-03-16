using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dsa.DataModels;
using Dsa.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Dsa.Pages.Order
{
    public class ConvergencePaymentsPage : DsaPageBase
    {
        private const string PagePrefix = "ConvergencePayment";

        public ConvergencePaymentsPage(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "Quote Summary Page";
            PageFactory.InitElements(WebDriver, this);
            webDriver.VerifyBusyOverlayNotDisplayed();
        }

        #region Elements

        #endregion

        #region DFSElements

public IWebElement dfsstatus { get { return WebDriver.GetElement(By.Id("")); } }
        #endregion
    }
}
