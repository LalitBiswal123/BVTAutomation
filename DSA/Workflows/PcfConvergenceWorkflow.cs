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
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
using Dsa.Pages.PCFConvergence;

namespace Dsa.Workflows
{
    /// <summary>
    /// PCF Convergence workflows will be defined in this class.
    /// </summary>
    public static class PcfConvergenceWorkflow
    {
        //This is temporary method which should be removed later
        public static void NavigateToTSRQuoteSummary(IWebDriver webDriver, TestContext context, string quoteNumber, string quoteVersion, string country, string language)
        {
            var url = "https://www.dell.com/salesapp/quote/"
                      + country
                      + "/"
                      + language + "/"
                      + quoteNumber + "/"
                      + quoteVersion;

            webDriver.Navigate().GoToUrl(url);
            //new PCFQuoteSummaryPage(webDriver).LnkSignIn.Click(webDriver);

        }

        public static void IsMoreActionOptionEnabled(SelectAction selectAction, IWebDriver webDriver)
        {

            var quoteSummaryPage = new PCFQuoteSummaryPage(webDriver);
            quoteSummaryPage.BtnMoreActions.Click(webDriver);
            switch (selectAction)
            {
                case SelectAction.MergeQuote:
                    if (quoteSummaryPage.BtnMergeQuote.IsElementClickable(webDriver) == true)
                    {
                        Logger.Write("Btn Merge Quote is Clickable, Passed");
                        quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        break;
                    }
                    else
                    {
                        Logger.Write("Merge Quote Button Disabled, Failed");
                        Assert.Fail("Failed");
                        break;
                    }

                case SelectAction.SplitQuote:
                    if (quoteSummaryPage.BtnSplitQuote.IsElementClickable(webDriver) == true)
                    {
                        Logger.Write("Btn Split Quote is Clickable, Passed");
                        quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        break;
                    }
                    else
                    {
                        Logger.Write("Split Quote Button Disabled, Failed");
                        Assert.Fail("Failed");
                        break;
                    }

                case SelectAction.CopyAsNewQuote:
                    if (quoteSummaryPage.CopyAsNewQuote.IsElementClickable(webDriver) == true)
                    {
                        Logger.Write("Btn Copy As New Quote is Clickable, Passed");
                        quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        break;
                    }
                    else
                    {
                        Logger.Write("Copy As New Quote Button Disabled, Failed");
                        Assert.Fail("Failed");
                        break;
                    }

                case SelectAction.CopyAsNewVersion:
                    if (quoteSummaryPage.CopyAsNewVersion.IsElementClickable(webDriver) == true)
                    {
                        Logger.Write("Btn Copy As New Version is Clickable, Passed");
                        quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        break;
                    }
                    else
                    {
                        Logger.Write("Copy As New Version Button Disabled, Failed");
                        Assert.Fail("Failed");
                        break;
                    }

                case SelectAction.CopyRSIQ:
                    if (quoteSummaryPage.CopyAsRSIDQuote.IsElementClickable(webDriver) == true)
                    {
                        Logger.Write("Btn Copy As RSID Quote is Clickable, Passed");
                        quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        break;
                    }
                    else
                    {
                        Logger.Write("Copy As RSID Quote Button Disabled, Failed");
                        Assert.Fail("Failed");
                        break;
                    }

                case SelectAction.CopyStockQuote:
                    if (quoteSummaryPage.CopyAsStockQuote.IsElementClickable(webDriver) == true)
                    {
                        Logger.Write("Btn Copy Stock Quote is Clickable, Passed");
                        quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        break;
                    }
                    else
                    {
                        Logger.Write("Copy Stock Quote Button Disabled, Failed");
                        Assert.Fail("Failed");
                        break;
                    }

                case SelectAction.CopyPickQuote:
                    if (quoteSummaryPage.CopyAsPickQuote.IsElementClickable(webDriver) == true)
                    {
                        Logger.Write("Btn Copy Pick Quote is Clickable, Passed");
                        quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        break;
                    }
                    else
                    {
                        Logger.Write("Copy Pick Quote Button Disabled, Failed");
                        Assert.Fail("Failed");
                        break;
                    }

                case SelectAction.UploadToPom:
                    if (quoteSummaryPage.BtnUploadToPOM.IsElementClickable(webDriver) == true)
                    {
                        Logger.Write("Btn Upload POM is Clickable, Passed");
                        quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        break;
                    }
                    else
                    {
                        Logger.Write("Upload POM Button Disabled, Failed");
                        Assert.Fail("Failed");
                        break;
                    }

                case SelectAction.SaveAsEquote:
                    if (quoteSummaryPage.BtnSaveAsEquote.IsElementClickable(webDriver) == true)
                    {
                        Logger.Write("Btn Save As Equote is Clickable, Passed");
                        quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        break;
                    }
                    else
                    {
                        Logger.Write("SaveAsEquote Button Disabled, Failed");
                        Assert.Fail("Failed");
                        break;
                    }

                case SelectAction.ExportStandardConfig:
                    if (quoteSummaryPage.BtnExportStandardConfig.IsElementClickable(webDriver) == true)
                    {
                        Logger.Write("Btn Export Standard Config is Clickable, Passed");
                        quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        break;
                    }
                    else
                    {
                        Logger.Write("Export Standard Config Button Disabled, Failed");
                        Assert.Fail("Failed");
                        break;
                    }

                case SelectAction.AssociateOpportunity:
                    if (quoteSummaryPage.BtnAssociateOpportunity.IsElementClickable(webDriver) == true)
                    {
                        Logger.Write("Btn Associate Opportunity is Clickable, Passed");
                        quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        break;
                    }
                    else
                    {
                        Logger.Write("Associate Opportunity Button Disabled, Failed");
                        Assert.Fail("Failed");
                        break;
                    }

                default:
                    Logger.Write("Improper Selection");
                    break;
            }
        }

        public static void IsMoreActionOptionDisabled(SelectAction selectAction, IWebDriver webDriver)
        {

            var quoteSummaryPage = new PCFQuoteSummaryPage(webDriver);
            quoteSummaryPage.BtnMoreActions.Click(webDriver);
            switch (selectAction)
            {
                case SelectAction.MergeQuote:
                    //Verify the Merge Quote Btn Display but should Not be Clickable
                    if (quoteSummaryPage.BtnMergeQuote.Enabled != true)
                    {
                        Logger.Write("Btn Merge Quote is disabled As Expected, Passed");
                        //quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        ////Verify if Merge Quote Btn Not Displayed, Should Fail 
                        //if (quoteSummaryPage.BtnMergeQuote.IsElementDisplayed(webDriver) != true)
                        //{
                        //    Assert.Fail("Merge Quote Not Visible, Failed");
                        //}
                        break;
                    }
                    else
                    {
                        //Verify if Merge Quote Button Enabled, Should Fail
                        Assert.IsTrue(quoteSummaryPage.BtnMergeQuote.Enabled);
                        Assert.Fail("Merge Quote Btn Enabled, Failed");
                        break;
                    }

                case SelectAction.SplitQuote:
                    //Verify the Split Quote Btn Display but should Not be Clickable
                    if (quoteSummaryPage.BtnSplitQuote.Enabled != true)
                    {
                        Logger.Write("Btn Split Quote is  disabled As Expected, Passed");
                        //quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        //Verify if Split Quote Btn Not Displayed, Should Fail 
                        //if (quoteSummaryPage.BtnSplitQuote.IsElementDisplayed(webDriver) != true)
                        //{
                        //    Assert.Fail("Split Quote Not Visible, Failed");
                        //}
                        break;
                    }
                    else
                    {
                        //Verify if Split Quote Button Enabled, Should Fail
                        Assert.IsTrue(quoteSummaryPage.BtnSplitQuote.Enabled);
                        Assert.Fail("Split Quote Btn Enabled, Failed");
                        break;
                    }

                case SelectAction.CopyAsNewQuote:
                    //Verify the CopyNewQuote Btn Display but should Not be Clickable
                    if (quoteSummaryPage.CopyAsNewQuote.Enabled != true)
                    {
                        Logger.Write("Btn CopyNewQuote is disabled As Expected, Passed");
                        //quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        ////Verify if CopyNewQuote Btn Not Displayed, Should Fail 
                        //if (quoteSummaryPage.CopyAsNewQuote.IsElementDisplayed(webDriver) != true)
                        //{
                        //    Assert.Fail("CopyNewQuote Not Visible, Failed");
                        //}
                        break;
                    }
                    else
                    {
                        //Verify if CopyNewQuote Button Enabled, Should Fail
                        Assert.IsTrue(quoteSummaryPage.CopyAsNewQuote.Enabled);
                        Assert.Fail("CopyNewQuote Btn Enabled, Failed");
                        break;
                    }

                case SelectAction.CopyAsNewVersion:
                    //Verify the CopyNewVersion Btn Display but should Not be Clickable
                    if (quoteSummaryPage.CopyAsNewVersion.Enabled != true)
                    {
                        Logger.Write("Btn CopyNewVersion is disabled As Expected, Passed");
                        //quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        ////Verify if CopyNewVersion Btn Not Displayed, Should Fail 
                        //if (quoteSummaryPage.CopyAsNewVersion.IsElementDisplayed(webDriver) != true)
                        //{
                        //    Assert.Fail("CopyNewVersion Not Visible, Failed");
                        //}
                        break;
                    }
                    else
                    {
                        //Verify if CopyNewVersion Button Enabled, Should Fail
                        Assert.IsTrue(quoteSummaryPage.CopyAsNewVersion.Enabled);
                        Assert.Fail("CopyNewVersion Btn Enabled, Failed");
                        break;
                    }

                case SelectAction.CopyRSIQ:
                    //Verify the Copy RSID Btn Display but should Not be Clickable
                    if (quoteSummaryPage.CopyAsRSIDQuote.Enabled != true)
                    {
                        Logger.Write("Btn CopyRSID is disabled As Expected, Passed");
                        //quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        ////Verify if CopyRSID Btn Not Displayed, Should Fail 
                        //if (quoteSummaryPage.CopyAsRSIDQuote.IsElementDisplayed(webDriver) != true)
                        //{
                        //    Assert.Fail("CopyRSID Not Visible, Failed");
                        //}
                        break;
                    }
                    else
                    {
                        //Verify if CopyRSID Button Enabled, Should Fail
                        Assert.IsTrue(quoteSummaryPage.CopyAsRSIDQuote.Enabled);
                        Assert.Fail("CopyRSID Btn Enabled, Failed");
                        break;
                    }

                case SelectAction.CopyStockQuote:
                    //Verify the Copy Stock Btn Display but should Not be Clickable
                    if (quoteSummaryPage.CopyAsStockQuote.Enabled != true)
                    {
                        Logger.Write("Btn CopyStockQuote is disabled As Expected, Passed");
                        //quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        ////Verify if CopyStockQuote Btn Not Displayed, Should Fail 
                        //if (quoteSummaryPage.CopyAsStockQuote.IsElementDisplayed(webDriver) != true)
                        //{
                        //    Assert.Fail("CopyStockQuote Not Visible, Failed");
                        //}
                        break;
                    }
                    else
                    {
                        //Verify if CopyStockQuote Button Enabled, Should Fail
                        Assert.IsTrue(quoteSummaryPage.CopyAsStockQuote.Enabled);
                        Assert.Fail("CopyStockQuote Btn Enabled, Failed");
                        break;
                    }

                case SelectAction.CopyPickQuote:
                    //Verify the Copy Pick Btn Display but should Not be Clickable
                    if (quoteSummaryPage.CopyAsPickQuote.Enabled != true)
                    {
                        Logger.Write("Btn CopyPickQuote is disabled As Expected, Passed");
                        //quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        ////Verify if CopyPickQuote Btn Not Displayed, Should Fail 
                        //if (quoteSummaryPage.CopyAsPickQuote.IsElementDisplayed(webDriver) != true)
                        //{
                        //    Assert.Fail("CopyPickQuote Not Visible, Failed");
                        //}
                        break;
                    }
                    else
                    {
                        //Verify if CopyPickQuote Button Enabled, Should Fail
                        Assert.IsTrue(quoteSummaryPage.CopyAsPickQuote.Enabled);
                        Assert.Fail("CopyPickQuote Btn Enabled, Failed");
                        break;
                    }

                case SelectAction.UploadToPom:
                    //Verify the UploadPOM Btn Display but should Not be Clickable
                    if (quoteSummaryPage.BtnUploadToPOM.Enabled != true)
                    {
                        Logger.Write("Btn UploadPOM is disabled As Expected, Passed");
                        //quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        ////Verify if UploadPOM Btn Not Displayed, Should Fail 
                        //if (quoteSummaryPage.BtnUploadToPOM.IsElementDisplayed(webDriver) != true)
                        //{
                        //    Assert.Fail("UploadPOM Btn Not Visible, Failed");
                        //}
                        break;
                    }
                    else
                    {
                        //Verify if UploadPOM Button Enabled, Should Fail
                        Assert.IsTrue(quoteSummaryPage.BtnUploadToPOM.Enabled);
                        Assert.Fail("UploadPOM Btn Enabled, Failed");
                        break;
                    }

                case SelectAction.SaveAsEquote:
                    //Verify the SaveAsEquote Btn Display but should Not be Clickable
                    if (quoteSummaryPage.BtnSaveAsEquote.Enabled != true)
                    {
                        Logger.Write("Btn SaveAsEquote is disabled As Expected, Passed");
                        //quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        ////Verify if SaveAsEquote Btn Not Displayed, Should Fail 
                        //if (quoteSummaryPage.BtnSaveAsEquote.IsElementDisplayed(webDriver) != true)
                        //{
                        //    Assert.Fail("SaveAsEquote Btn Not Visible, Failed");
                        //}
                        break;
                    }
                    else
                    {
                        //Verify if SaveAsEquote Button Enabled, Should Fail
                        Assert.IsTrue(quoteSummaryPage.BtnSaveAsEquote.Enabled);
                        Assert.Fail("SaveAsEquote Btn Enabled, Failed");
                        break;
                    }

                case SelectAction.ExportStandardConfig:
                    //Verify the StandardConfig Btn Display but should Not be Clickable
                    if (quoteSummaryPage.BtnExportStandardConfig.Enabled != true)
                    {
                        Logger.Write("Btn ExportStandardConfig is disabled As Expected, Passed");
                        //quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        ////Verify if StandardConfig Btn Not Displayed, Should Fail 
                        //if (quoteSummaryPage.BtnExportStandardConfig.IsElementDisplayed(webDriver) != true)
                        //{
                        //    Assert.Fail("ExportStandardConfig Btn Not Visible, Failed");
                        //}
                        break;
                    }
                    else
                    {
                        //Verify if StandardConfig Button Enabled, Should Fail
                        Assert.IsTrue(quoteSummaryPage.BtnExportStandardConfig.Enabled);
                        Assert.Fail("ExportStandardConfig Btn Enabled, Failed");
                        break;
                    }

                case SelectAction.AssociateOpportunity:
                    //Verify the AssociateOpportunity Btn Display but should Not be Clickable
                    if (quoteSummaryPage.BtnAssociateOpportunity.Enabled != true)
                    {
                        Logger.Write("Btn AssociateOpportunity is disabled As Expected, Passed");
                        //quoteSummaryPage.BtnMoreActions.Click(webDriver);
                        ////Verify if AssociateOpportunity Btn Not Displayed, Should Fail 
                        //if (quoteSummaryPage.BtnAssociateOpportunity.IsElementDisplayed(webDriver) != true)
                        //{
                        //    Assert.Fail("AssociateOpportunity Btn Not Visible, Failed");
                        //}
                        break;
                    }
                    else
                    {
                        //Verify if AssociateOpportunity Button Enabled, Should Fail
                        Assert.IsTrue(quoteSummaryPage.BtnAssociateOpportunity.Enabled);
                        Assert.Fail("AssociateOpportunity Btn Enabled, Failed");
                        break;
                    }


                default:
                    Logger.Write("Improper Selection");
                    break;
            }
        }

        public static void IsMoreActionOptionHidden(SelectAction selectAction, IWebDriver webDriver)
        {
            var quoteSummaryPage = new PCFQuoteSummaryPage(webDriver);
            quoteSummaryPage.BtnMoreActions.Click(webDriver); 
            
            switch (selectAction)
            {
                case SelectAction.MergeQuote:
                    MoreActionOptionsHidden(quoteSummaryPage.BtnMergeQuote, webDriver);
                    break;

                case SelectAction.SplitQuote:
                    MoreActionOptionsHidden(quoteSummaryPage.BtnSplitQuote, webDriver);
                    break;
                case SelectAction.CopyAsNewQuote:
                    MoreActionOptionsHidden(quoteSummaryPage.CopyAsNewQuote, webDriver);
                    break;

                case SelectAction.CopyAsNewVersion:
                    MoreActionOptionsHidden(quoteSummaryPage.BtnCopyAsVersion, webDriver);
                    break;

                case SelectAction.CopyRSIQ:
                    MoreActionOptionsHidden(quoteSummaryPage.CopyAsRSIDQuote, webDriver);
                    break;

                case SelectAction.CopyStockQuote:
                    MoreActionOptionsHidden(quoteSummaryPage.CopyAsStockQuote, webDriver);
                    break;

                case SelectAction.CopyPickQuote:
                    MoreActionOptionsHidden(quoteSummaryPage.CopyAsPickQuote, webDriver);
                    break;

                case SelectAction.UploadToPom:
                    MoreActionOptionsHidden(quoteSummaryPage.BtnUploadToPOM, webDriver);
                    break;
                case SelectAction.ExportStandardConfig:
                    MoreActionOptionsHidden(quoteSummaryPage.BtnExportStandardConfig, webDriver);
                    break;

                default:
                    Logger.Write("Improper Selection");
                    break;
            }
        }

        public static void MoreActionOptionsHidden( IWebElement element,IWebDriver webDriver)
        {            
            //Element Displayed Should Be False
            if (element.IsElementDisplayed(webDriver) == true)
            {
                Logger.Write("Element is Displayed But Expected to be hidden, Failed");
                Assert.Fail("Failed");            
            }
            else
            {
                //Element Suppose to be Hidden as expected
                Assert.IsFalse(element.IsElementDisplayed(webDriver));
                Logger.Write("Element is Not Visible As Expected, Passed");               
            }
        }

        public static void NavigateToQuoteSummaryPage(IWebDriver webDriver, TestContext context, string quoteNumber, string quoteVersion, string country, string language)
        {
            var url = "https://www.dell.com/salesapp/"
                      + "/quote/"
                      + country
                      + "/"
                      + language
                      + "/"
                      + quoteNumber + "/"
                      + quoteVersion;

            webDriver.Navigate().GoToUrl(url);
            //new ChannelQuoteSummaryPage(webDriver).LnkSignIn.Click(webDriver);

        }

    }

}
