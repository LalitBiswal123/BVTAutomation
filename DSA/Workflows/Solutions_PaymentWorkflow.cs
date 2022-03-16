using Dsa.Enums;
using Dsa.Pages.Solutions;
using Dsa.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dsa.Pages.Quote;
using Dsa.Pages.Order;
using Dsa.Pages.Product;
using Dsa.Pages.Customer;
using Dsa.Constants;
using Dsa.Pages;
using OpenQA.Selenium.Support.UI;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using Dsa.DataModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dsa.Workflows
{
    public static class Solutions_PaymentWorkflow
    {

        static bool isValidationPassed = true;
        public static bool IsValidationPassed
        {
            get
            {
                return isValidationPassed;
            }

            set
            {
                // if once validation failed we are no more going pass test case.
                if (isValidationPassed)
                {
                    isValidationPassed = value;
                }
            }
        }

        //public static string CreateSolutionQuoteCpqFlow1(IWebDriver webDriver, OscSolutionData testData)
        //{
        //    webDriver.Navigate().GoToUrl(testData.OscUrl);
           
        //}
    }
}
