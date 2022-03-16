//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Dsa.Pages.Solutions
{
    public class YourSolutionsPage : DsaPageBase
    {

        protected IWebDriver webDriver;
        public YourSolutionsPage(IWebDriver webDriver)
            : base(webDriver)
        {
            this.webDriver = webDriver;
            Name = "Your Solutions";
            PageFactory.InitElements(webDriver, this);
            
        }

        #region Elements

        [FindsBy(How = How.Id, Using = @"yoursolution-link")]

        public IWebElement BtnBackToYourSolutions;


public IWebElement BtnCreateNewSolution { get { return WebDriver.GetElement(By.Id("create_new_solution")); } }


public IWebElement TxtSolutionName { get { return WebDriver.GetElement(By.Id("solutionName")); } }


public IWebElement TxtSolutionCategory { get { return WebDriver.GetElement(By.Id("solutionGroup")); } }


public IWebElement TxtSolutionOfferCategoryDropdown { get { return WebDriver.GetElement(By.Id("solutionOfferCategory")); } }


public IWebElement BtnCreate { get { return WebDriver.GetElement(By.Id("btnNewSolutionCreate")); } }


public IWebElement GridYourSolutions { get { return WebDriver.GetElement(By.Id("divsolutionTable")); } }

    
public IWebElement BtnDiscardAutoRecoveredSolution { get { return WebDriver.GetElement(By.Id("discardbutton")); } }


public IWebElement BtnRecoverAutoRecoveredSolution { get { return WebDriver.GetElement(By.Id("recoverbutton")); } }


public IWebElement SolutionIdTextBox { get { return WebDriver.GetElement(By.XPath("//input[@placeholder='Enter Solution ID']")); } }


public IWebElement SolutionSearchBtn { get { return WebDriver.GetElement(By.XPath("//button[contains(text(),'Search')]")); } }


public IWebElement ConfigSettingLink { get { return WebDriver.GetElement(By.Id("EditConfigSettingLink")); } }


public IWebElement ICodedSKUsOption { get { return WebDriver.GetElement(By.XPath(".//div[span[contains(text(),'I-Coded SKUs')]]")); } }


public IWebElement ConfigSettingCloseButton { get { return WebDriver.GetElement(By.XPath("//div[div[h3[contains(text(),'Configurator Settings')]]]//button[contains(text(),'Close')]")); } }


public IWebElement ConfigSettingSaveButton { get { return WebDriver.GetElement(By.XPath("//div[div[h3[contains(text(),'Configurator Settings')]]]//button[contains(text(),'Save')]")); } }



        #endregion

        #region Line Items





        #endregion




        /// <summary>
        /// Action to create a new solution 
        /// </summary>
        /// <param name="solutionName">Solution Name</param>
        /// <param name="solutionCategory">Solution Category</param>
        /// <param name="solutionOfferCategory">Solution Offer Category</param>
        /// <returns>new instance of SolutionConfigurationPage</returns>
        public SolutionConfigurationPage CreateNewSolution(string solutionName = null, string solutionCategory = null, string solutionOfferCategory = "Unified Communications & Collaboration")
        {
            //YourSolutionsPage YourSolutionsPage = new YourSolutionsPage(WebDriver);
            DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
            DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(60));
            DsaUtil.WaitForElement(BtnCreateNewSolution, WebDriver);
            BtnCreateNewSolution.Click(webDriver);
            DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
            //WebDriver.VerifyBusyOverlayNotDisplayed();
            BtnCreate.WaitForElement(WebDriver);
            DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
            //WebDriver.VerifyBusyOverlayNotDisplayed();
            if (solutionName != null)
            {
                TxtSolutionName.WaitForElement(WebDriver);
                TxtSolutionName.SetTextForSolution(WebDriver, solutionName);
            }

            if (solutionCategory != null)
            {
                TxtSolutionCategory.WaitForElement(WebDriver);
                TxtSolutionCategory.SetTextForSolution(WebDriver, solutionCategory);
            }

            if (solutionOfferCategory != null)
            {
                //TxtSolutionOfferCategoryDropdown.WaitForElement(WebDriver);

                TxtSolutionName.Clear();
                TxtSolutionName.SendKeys("New Solution");
                //YourSolutionsPage.TxtSolutionOfferCategoryDropdown.PickDropdownByText(WebDriver, solutionOfferCategory);
                // new SelectElement(new YourSolutionsPage(WebDriver).TxtSolutionOfferCategoryDropdown).SelectByText(solutionOfferCategory);
            }

            BtnCreate.WaitForElement(WebDriver);
            BtnCreate.Click(webDriver);
            WebDriver.WaitForPageLoad();
            WebDriver.WaitForPageLoad();


            new SolutionConfigurationPage(WebDriver).ProdcutSearchBtn.WaitForElement(WebDriver);

            //DsaUtil.TryFindElement(WebDriver, new SolutionConfigurationPage(WebDriver).ProdcutSearchBtn);

            //new SolutionConfigurationPage(WebDriver).ProdcutSearchBtn.WaitForElement(WebDriver);
            // some time config tab is not loading without any busy icon as soon as we load on solution config page

            return new SolutionConfigurationPage(WebDriver);
        }

        public SolutionConfigurationPage SearchAndOpenSolution(string SolutionID)
        {
            YourSolutionsPage YourSolutionsPage = new YourSolutionsPage(WebDriver);
            delay(5);
            YourSolutionsPage.SolutionIdTextBox.SetText(WebDriver, SolutionID);
            YourSolutionsPage.SolutionSearchBtn.Click();
            delay(10);
            return new SolutionConfigurationPage(WebDriver);
        }


        public YourSolutionsPage SelectConfigurationSettings()
        {
            ConfigSettingLink.Click();
            WebDriver.WaitForPageLoad();
            DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
            return new YourSolutionsPage(WebDriver);
        }

        public YourSolutionsPage SelectICodedSKUsCheckBox()
        {
            DsaUtil.SelectCheckBox(ICodedSKUsOption.FindElement(By.TagName("input")), WebDriver);
            WebDriver.WaitForPageLoad();
            DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
            return new YourSolutionsPage(WebDriver);
        }

        public YourSolutionsPage SaveConfigSettings()
        {
            DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
            ConfigSettingSaveButton.Click();
            return new YourSolutionsPage(WebDriver);
        }

        public bool IsIcodedSkuOptionEnabled()
        {
            bool result = false;
            if (!(ICodedSKUsOption.GetAttribute("class").ToLower().Contains("disabled")))
            {
                result = true;
            }
            else
            {
                ConfigSettingCloseButton.Click();
            }
            return result;
        }

        public void delay(int timeInSeconds)
        {
            Thread.Sleep(timeInSeconds * 1000);
        }




        #region FT1(Customer Type)



        public IWebElement CustTypeOnSolPage { get { return WebDriver.GetElement(By.Id("endUserCustomerTypeSelected")); } }


public IWebElement SolCatogery { get { return WebDriver.GetElement(By.XPath("//input[@id='solutionGroup']")); } }



        public SolutionConfigurationPage CreateNewSolutionCPQ(string solutionName, string ProductsList, bool saveSolution = true)
        {
            YourSolutionsPage YourSolutionsPage = new YourSolutionsPage(WebDriver);
            DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
            DsaUtil.WaitForElement(BtnCreateNewSolution, WebDriver);
            YourSolutionsPage.BtnCreateNewSolution.Click(webDriver);
            DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
            //WebDriver.VerifyBusyOverlayNotDisplayed();
            YourSolutionsPage.BtnCreate.WaitForElement(WebDriver);
            DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
            //WebDriver.VerifyBusyOverlayNotDisplayed();
            if (solutionName != null)
            {
                TxtSolutionName.WaitForElement(WebDriver);
                YourSolutionsPage.TxtSolutionName.SetTextForSolution(WebDriver, solutionName);
            }



            YourSolutionsPage.BtnCreate.WaitForElement(WebDriver);
            YourSolutionsPage.BtnCreate.Click(webDriver);
            WebDriver.WaitForPageLoad();
            WebDriver.WaitForPageLoad();


            SolutionConfigurationPage SolutionConfigurationPage = new SolutionConfigurationPage(WebDriver);
            SolutionConfigurationPage.SearchAndAddMultipleProducts(ProductsList);
            if (saveSolution)
                new SolutionConfigurationPage(WebDriver).SaveSolution();
            return new SolutionConfigurationPage(WebDriver);
        }
        
        
        //Method for customer Type 

        public SolutionConfigurationPage CreateNewSolutionCPQcustType(string solutionName)
        {
            YourSolutionsPage YourSolutionsPage = new YourSolutionsPage(WebDriver);
            DsaUtil.WaitForElement(BtnCreateNewSolution, WebDriver);
            YourSolutionsPage.BtnCreateNewSolution.Click(webDriver);
            DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
            YourSolutionsPage.BtnCreate.WaitForElement(WebDriver);
            DsaUtil.WaitForWaitAnimationToLoad(WebDriver);
            if (solutionName!=null)
            {
                TxtSolutionName.WaitForElement(WebDriver);
                YourSolutionsPage.TxtSolutionName.SetTextForSolution(WebDriver, solutionName);
            }


            return new SolutionConfigurationPage(WebDriver);
        }

        #endregion FT1(Customer Type)

    }
}

