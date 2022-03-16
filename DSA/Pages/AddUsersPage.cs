using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Dsa.Pages
{
    public class AddUsersPage : DsaPageBase
    {
        public AddUsersPage(IWebDriver webDriver)
            : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        #region Elements


public IWebElement BtnAddSingleUsers { get { return WebDriver.GetElement(By.Id("_createProfile")); } }
        

public IWebElement BtnAddBulkUsers { get { return WebDriver.GetElement(By.Id("_saveUser")); } }
        

public IWebElement BtnAddUserCancel { get { return WebDriver.GetElement(By.Id("_cancel")); } }
        

public IWebElement ProfileDescription { get { return WebDriver.GetElement(By.Id("permission_row_for_")); } }


public IWebElement TabSingleUser { get { return WebDriver.GetElement(By.Id("//*[@class='nav-tabs']/li[1]/a")); } }
        

public IWebElement TxtUserEmailId { get { return WebDriver.GetElement(By.Id("//*[@class='nav-tabs']/li[2]/a")); } }
        

public IWebElement TxtMuptipleUserEmailId { get { return WebDriver.GetElement(By.Id("//*[@id='singleAdd']/div/div[1]/div/div/input")); } }
        

public IWebElement TxtUserSalesRepId { get { return WebDriver.GetElement(By.Id("//*[@id='_user_email']")); } }
        

public IWebElement TglAddMultipleUser { get { return WebDriver.GetElement(By.Id("//*[@id='singleAdd']/div/div[2]/div/div/input")); } }
        

public IWebElement LblAddedSingleUser { get { return WebDriver.GetElement(By.Id("Multiple")); } }
        

public IWebElement AddedSingleUserNameSTS { get { return WebDriver.GetElement(By.Id("Users")); } }
    
        #endregion
       

    }
}
