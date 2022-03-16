using System;
using System.Collections.Generic;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
//using Dell.Adept.UI.Web.Support.Extensions.WebElement;
using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Linq;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;

namespace Dsa.Pages.Solutions
{
    public class GuidedJourneyPage : DsaPageBase
    {


        public GuidedJourneyPage(IWebDriver webDriver)
            : base(webDriver)
        {
            Name = "Add Product";
            PageFactory.InitElements(webDriver, this);

            webDriver.WaitForPageLoad();
            //GridYourSolutions.WaitForElement(webDriver);
        }

        #region Elements
        private By ByQtyTextBox { get { return By.CssSelector("[class*='listview-quantity-value']"); } }
        private By BySelectButton { get { return By.CssSelector("[id*='btnSelect']"); } }
        private IWebElement ExpandAllOptionsLink { get { return WebDriver.FindElement(By.XPath(".//div[contains(@class, 'complex-item-configurator-page-expand-collapse-links')]/span[1]")); } }
        private List<IWebElement> ModuleDivElements { get { return WebDriver.FindElements(By.XPath("//div[@id='complex_item_configurator_page_contents']/div")).Where(a => !string.IsNullOrEmpty(a.Text) && a.ElementExists(ByModuleName)).ToList(); } }
        private By ByModuleName { get { return By.TagName("h4"); } }
        private By ByOptionRow { get { return By.XPath(".//*[@class='css-components complex-item-configurator-page-options']/div"); } }
        private By ByOptionRowInputButton { get { return By.TagName("input"); } }
        private By ByOptionsRowTextBox { get { return By.XPath(".//span[1]/span/input"); } }
        public IWebElement ConfigureOptionsOkButton { get { return WebDriver.FindElement(By.Id("cp-ConfigureComponent-OK")); } }
        private IList<IWebElement> components { get { return WebDriver.FindElements(By.XPath(".//*[@id='cp-body-view']/div")); } }
        private List<IWebElement> Components { get { return WebDriver.FindElements(By.CssSelector("[class*='component-partial-view']")).ToList(); } }
        private By ByComponentName { get { return By.XPath(".//span[@class='gj_step_summary_component_name wrapword']"); } }
        public IList<IWebElement> OkButton { get { return WebDriver.FindElements(By.XPath(".//*[contains(@class, 'btn btn-primary')]")); } }
        private By ByNextPageButton { get { return By.Id("cp-nav-next"); } }
        private IWebElement NextPageButton { get { return WebDriver.FindElement(By.Id("cp-nav-next")); } }
        private By ByFinishButton { get { return By.Id("cp-nav-exit"); } }
        private IWebElement FinishButton { get { return WebDriver.FindElement(By.Id("cp-nav-exit")); } }
        #endregion

        #region Line Items


        private List<IWebElement> ComponentList
        {
            get
            {
                DsaUtil.WaitForPageLoad(WebDriver);
                var componentGrid = WebDriver.FindElement(By.CssSelector("[id*='availableOrderGrid']"));
                return componentGrid.FindElements(By.XPath(".//table/tbody/tr")).ToList();
            }
        }


        #endregion

        public SolutionConfigurationPage InitiateGJProcess()
        {
            Console.WriteLine("** Navigate to configuration tab **");
            new SolutionConfigurationPage(WebDriver).GoToConfigurationTab();
            Console.WriteLine("** Initiate guided configuration **");
            IList<IWebElement> configureBtn = OkButton;

            foreach (IWebElement configbtn in configureBtn)
            {
                if (configbtn.Text.Equals("Configure/Edit"))
                {
                    configbtn.Click();
                    break;
                }
            }
            DsaUtil.WaitAnimationToLoad(WebDriver);
            return new SolutionConfigurationPage(WebDriver);
        }
        public void UpdateComponentConfigureOptions(string configureOptions)
        {
            //Wait for Configure options page to launch
            DsaUtil.WaitForPageLoad(WebDriver);
            //Expand all modules -- This is a pre-requisite for ReadConfigurationDetailsFromStepReviewPage method. 

            //Select OK Button from Configure Options dialog, if there are no configuration updates to be done
            if (string.IsNullOrEmpty(configureOptions))
            {
                //Do Nothing                
            }
            else
            {
                //Thread.Sleep(1000);
                WebDriver.WaitForElementDisplayed(By.XPath(".//div[contains(@class, 'complex-item-configurator-page-expand-collapse-links')]/span[1]"), TimeSpan.FromSeconds(4000));
                ExpandAllOptionsLink.Click();
                DsaUtil.WaitForPageLoad(WebDriver);
                //Convert configureOptions string to a dictionary
                Dictionary<string, string[]> moduleOptions = new Dictionary<string, string[]>();

                foreach (var item in configureOptions.Split(new char[] { '|' }))
                {
                    string[] KeyValue = item.Split(new char[] { ';' }, 2);
                    moduleOptions.Add(KeyValue[0], KeyValue[1].Split(new char[] { ';' }));
                }
                //Thread.Sleep(2000);
                //Navigate through all the modules
                foreach (var module in moduleOptions)
                {
                    IWebElement ModuleRow = ModuleDivElements.FirstOrDefault(a => a.FindElement(ByModuleName).Text.Equals(module.Key.Trim()));

                    if (ModuleRow == null)
                    {
                        throw new Exception("Error : Did not find the module" + module.Key);
                    }
                    //Navigate through all the options for a selected module
                    foreach (var option in module.Value)
                    {
                        string[] optionNameQty = option.Split(new char[] { '~' });
                        IWebElement OptionRow = ModuleRow.FindElements(ByOptionRow).FirstOrDefault(a => a.Text.Contains(optionNameQty[0]));

                        if (OptionRow == null)
                        {
                            throw new Exception("Error : Did not find the option" + optionNameQty[0]);
                        }

                        IWebElement inputButton = OptionRow.FindElement(ByOptionRowInputButton);
                        //Unselect the option, if the qty is 0
                        if (optionNameQty.Length > 1 && int.Parse(optionNameQty[1]) == 0 && inputButton.Selected)
                        {
                            inputButton.Click();
                            DsaUtil.WaitForPageLoad(WebDriver);
                        }
                        else if (!inputButton.Selected)
                        {
                            inputButton.Click();
                            DsaUtil.WaitForPageLoad(WebDriver);
                        }

                        if (optionNameQty.Length > 1)
                        {
                            if (int.Parse(optionNameQty[1]) >= 1)
                            {
                                IWebElement inputTextBox = OptionRow.FindElement(ByOptionsRowTextBox);
                                inputTextBox.SendKeys(Keys.Backspace);
                                inputTextBox.SendKeys(Keys.Backspace);
                                inputTextBox.SendKeys(Keys.Backspace);
                                inputTextBox.SendKeys(optionNameQty[1]);
                                DsaUtil.WaitForPageLoad(WebDriver);
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Method to verify if a component is added to the review summary page
        /// </summary>
        /// <param name="componentName">Name of the component(Controller/Enclosure)</param>
        /// <param name="noOfInstances">Quantity(No. of Instances)</param>
        /// <returns>Returns true on success, else false</returns>
        /// <Author>Sagarika</Author>
        public bool VerifyIfComponentAddedToStepSummaryPage(string componentName, string noOfInstances = "1")
        {
            int componentQty = 0;
            DsaUtil.WaitForElement(WebDriver.FindElement(By.Id("btnAddComponent")), WebDriver);
            foreach (var component in Components)
            {
                if (component.FindElement(ByComponentName).Text.ToLower().Equals(componentName.ToLower()))
                    componentQty++;
            }

            Console.WriteLine("Actual quantity, No. of instances found in step summary page :" + componentName + "-" + componentQty);
            if (componentQty.ToString() != noOfInstances)
            {
                Console.WriteLine(componentName + " successfully added to step summary page");
                return true;
            }
            else
            {
                Console.WriteLine("Expected quantity " + noOfInstances);
                throw new Exception("Error in adding the component" + componentName);
            }

        }

        public SolutionConfigurationPage SelectComponent(string componentName, string noOfInstances = "1", string configureOptions = null, bool verifyAtSummeryPage = true, bool clickOk = true)
        {
            Console.WriteLine("** Adding component " + componentName + " **");
            //System.Threading.Thread.Sleep(2000);
            IWebElement componentRow = ComponentList.FirstOrDefault(a => a.Text.ToLower().Contains(componentName.ToLower()));

            if (componentRow == null)
                throw new Exception("Error: Did not find any controller with name" + componentName);

            else
            {
                //Set quantity if the qty is greater than 1
                if (noOfInstances != "1")
                {
                    //System.Threading.Thread.Sleep(4000);
                    componentRow.FindElement(ByQtyTextBox).Clear();
                    componentRow.FindElement(ByQtyTextBox).SendKeys(noOfInstances.ToString());
                    DsaUtil.WaitForPageLoad(WebDriver);
                }

                //DsaUtil.WaitForPageLoad(WebDriver);
                componentRow.FindElement(BySelectButton).Click();
                DsaUtil.WaitAnimationToLoad(WebDriver);
                //Update options available in Configure Options dialog
                UpdateComponentConfigureOptions(configureOptions);

                if (clickOk)
                {
                    //DsaUtil.WaitForPageLoad(WebDriver);
                    //Click OK Button on Configure Options Page
                    ConfigureOptionsOkButton.Click();
                   // DsaUtil.WaitForPageLoad(WebDriver);
                    //Wait for the step review page to launch                    
                   // DsaUtil.waitAnimationToLoad(WebDriver);
                    //Verify if instances are added successfully
                    Console.WriteLine("Added " + noOfInstances + " instances of " + componentName);
                    //if (verifyAtSummeryPage)
                    //    VerifyIfComponentAddedToStepSummaryPage(componentName, noOfInstances);
                }
                return new SolutionConfigurationPage(WebDriver);
            }
        }
        public SolutionConfigurationPage GoToNextPage()
        {
            DsaUtil.WaitForPageLoad(WebDriver);
            WebDriver.WaitForElementVisible(ByNextPageButton, TimeSpan.FromSeconds(2000));
            DsaUtil.WaitUntilItsClickable(NextPageButton, WebDriver);
            //Wait for the next page to load
            //DsaUtil.WaitForPageLoad(WebDriver);
            DsaUtil.WaitAnimationToLoad(WebDriver);
            Console.WriteLine("Navigating to next page");
            return new SolutionConfigurationPage(WebDriver);
        }
        public SolutionConfigurationPage FinishGuidedConfiguration()
        {
            DsaUtil.WaitForPageLoad(WebDriver);
            Console.WriteLine("** Finish GJ **");
            WebDriver.WaitForElement(ByFinishButton, TimeSpan.FromSeconds(2000));
            //Thread.Sleep(2000);
            FinishButton.Click();
            //Wait for the Solution configurator page to load
            //DsaUtil.WaitForPageLoad(WebDriver);
            //DsaUtil.waitAnimationToLoad(WebDriver);
            return new SolutionConfigurationPage(WebDriver);
        }

    }
}
