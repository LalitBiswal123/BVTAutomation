using System;
using System.Linq;
using Dell.Adept.UI.Web.Testing.Framework.WebDriver;
//using Dell.Adept.UI.Web.Support.Extensions.WebDriver;
using OpenQA.Selenium;


namespace Dsa.Pages.Solutions
{
  public class FeedbackDialog
    {
        IWebDriver webDriver;

        public FeedbackDialog(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        //Need to be removed.
        private const string noThanksText = "No, thanks";

        public By DialogBy { get { return By.Id("IPEinvL"); } }
        public By DialogByAdvisor { get { return By.Id("ipeWrapper"); } }

        public By CanaryButtonBy { get { return By.Id("canary-close"); } }  

        public IWebElement Dialog { get { return webDriver.FindElement(DialogBy); } }

        public IWebElement DialogAdvisory { get { return webDriver.FindElement(DialogByAdvisor); } }       

        public IWebElement CanaryButton { get { return webDriver.FindElement(CanaryButtonBy); } }

        public IWebElement NoThanksButton
        {
            get
            {

                IWebElement feedback = null;
                try
                {
                    feedback = Dialog.FindElements(By.TagName("span")).FirstOrDefault(e => e.Text.Equals(noThanksText, StringComparison.CurrentCultureIgnoreCase));
                }
                //we are going to handel only below 2 type of exception as in above stament we are expecting them as per Application 
                catch (NoSuchElementException e) { }
                catch (ElementNotVisibleException e) { }
                return feedback == null ? feedback = DialogAdvisory.FindElement(By.TagName("map")).FindElements(By.TagName("area"))[1] : feedback;

            }
        }
        public bool IsDialogExist()
        {
            try
            {
                return webDriver.ElementExists(DialogBy) || webDriver.SwitchTo().Window(webDriver.WindowHandles.ToList<string>().Last()).ElementExists(DialogByAdvisor); ;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool IsDialogCanaryExist()
        {
            try
            {
                return webDriver.SwitchTo().Window(webDriver.WindowHandles.ToList<string>().Last()).ElementExists(CanaryButtonBy); ;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public void CloseFeedBack()
        {
            if (IsDialogExist())
                NoThanksButton.Click();

        }

        public void CloseCanaryDialog()
        {
            if (IsDialogCanaryExist())
            {
                try
                {
                    CanaryButton.Click();
                }
                catch(Exception ex)
                {
                    
                }
            }
               
        }
    }
    
}
