using System;
using Dsa.Enums;
using Dsa.Pages.Admin;
using Dsa.Pages.Customer;
using Dsa.Utils;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using Dsa.Pages;

namespace Dsa.Admin.Pages
{
    public class UserDetailsPage : DsaPageBase
    {
        public UserDetailsPage(IWebDriver webDriver) : base(webDriver)
        {
            WebDriver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }


        #region Variables

        private IWebDriver WebDriver { get; }
        private List<int> OriginalProfiles { get; set; }

        #endregion

        #region Elements 



public IWebElement lstUserDomain { get { return WebDriver.GetElement(By.Id("userSearch_Domain")); } }


public IWebElement TxtEmailAddress { get { return WebDriver.GetElement(By.Id("userSearch_Text")); } }



public IWebElement TxtEnterEmailAddres { get { return WebDriver.GetElement(By.Id("_user_email")); } }


public IWebElement DdlSelectBusinessUnit { get { return WebDriver.GetElement(By.Id("userattribute_business_unit")); } }


public IWebElement BtnUserSearch { get { return WebDriver.GetElement(By.Id("UserSearch_button")); } }


public IWebElement BtnCancel { get { return WebDriver.GetElement(By.Id("_cancel")); } }


public IWebElement BtnAddUsers { get { return WebDriver.GetElement(By.Id("_createProfile")); } }


public IWebElement LblUserEmailId { get { return WebDriver.GetElement(By.Id("UserEmailLabel")); } }


public IWebElement LblUserName { get { return WebDriver.GetElement(By.Id("userDetails_userName")); } }
        

public IWebElement TblUserDetails { get { return WebDriver.GetElement(By.XPath("//*[@id='main']/div[2]/div[2]/div[3]")); } }
                    

public IWebElement UserDetailsAddUsers { get { return WebDriver.GetElement(By.Id("userDetails_createProfile")); } }


public IWebElement TextBoxAssignBusinessUnitName { get { return WebDriver.GetElement(By.Id("assignBusinessUnit_name")); } }
               


public IWebElement BtnSaveUser { get { return WebDriver.GetElement(By.Id("_saveProfile")); } }
        

public IWebElement TxtName { get { return WebDriver.GetElement(By.Id("assignBusinessUnit_name")); } }


public IList<IWebElement> LblNames { get { return WebDriver.GetElements(By.Id("userDetails_userAttributeName")); } }


public IWebElement TblProfile { get { return WebDriver.GetElement(By.CssSelector(".c-data-grid > table:nth-child(2)")); } }
        

public IWebElement BtnCnfSaveUser { get { return WebDriver.GetElement(By.Id("messageDialogButton_0")); } }


public IWebElement BtnAddBusinessUnit { get { return WebDriver.GetElement(By.Id("userDetails_addBusinessUnit")); } }

        //[FindsBy(How = How.CssSelector, Using = "div.col-md-6:nth-child(3) > div:nth-child(1) > div:nth-child(2) > input")]
        //public IWebElement TxtSalesRepId;


public IWebElement UserRepId { get { return WebDriver.GetElement(By.CssSelector("div.col-md-6:nth-child(3) > div:nth-child(1) > div:nth-child(2) > input")); } }


public IWebElement TxtSalesRepId { get { return WebDriver.GetElement(By.Id("assignBusinessUnit_salesrepid")); } }


public IWebElement BtnSaveBusinessUnit { get { return WebDriver.GetElement(By.Id("assignBusinessUnit_confirm")); } }


public IWebElement BtnCancelBusinessUnit { get { return WebDriver.GetElement(By.Id("assignBusinessUnit_cancel")); } }


public IWebElement BtnSave { get { return WebDriver.GetElement(By.Id("userDetails_saveProfile")); } }


public IWebElement BtnSubmitAddUser { get { return WebDriver.GetElement(By.Id("_saveUser")); } }


public IWebElement UserEmail { get { return WebDriver.GetElement(By.Id("userDetails_emailAddress")); } }
        


public IWebElement AddUserError { get { return WebDriver.GetElement(By.XPath("//*[@class='alert alert-error']//span/span[contains(text(), 'Not Found')]")); } }


public IWebElement AddUserSucces { get { return WebDriver.GetElement(By.XPath("//*[@class='alert alert-info']//span/span[contains(text(), 'Users Added')]")); } }


public IList<IWebElement> userProfilesCheckBoxes { get { return WebDriver.GetElements(By.Id("//*[@id='userDetails_profile_row_for_selection_checkbox']")); } }

        By AddUserErrorMessage = By.XPath(".//*[@class='alert alert-error']//span/span[contains(text(), 'Not Found')]");

        By AddUserSuccesMessage = By.XPath(".//*[@class='alert alert-info']//span/span[contains(text(), 'Users Added')]");

        private IWebElement GetProfileCheckBoxElement(int index)
        {
            return WebDriver.FindElement(By.XPath(String.Format("//*[@id='userDetails_profile_row_for_selection_checkbox'])[{0}]", index)));
        }

        #endregion

        /// <summary>
        /// Drop down for all recent activity
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="SearchUserDetails"></param>
        /// <returns></returns>
        
        public void SearchUserDetails(string emailId)
        {
            TxtEmailAddress.SetText(WebDriver, emailId);
            BtnUserSearch.Click(WebDriver);
        }

        public void UpdateSalesRepId(string existingRepId, string newRepId1, string newRepId2 )
        {
            TxtSalesRepId.SetText(WebDriver, existingRepId == newRepId1 ? newRepId2 : newRepId1);
            BtnSaveBusinessUnit.Click(WebDriver);
        }

        public void UpdateSalesRepName(string newRepName)
        {
            TxtName.SetText(WebDriver, newRepName);
            BtnSaveBusinessUnit.Click(WebDriver);
        }

        public void SelectBusinessUnitFromDrpDwn(IWebDriver driver, BusinessUnitType businessUnitType)
        {
            switch (businessUnitType)
            {
                case BusinessUnitType.Canada:
                    DdlSelectBusinessUnit.PickDropdownByText(driver, "707 - Canada");
                    break;
                case BusinessUnitType.China:
                    DdlSelectBusinessUnit.PickDropdownByText(driver, "8270 - China");
                    break;
                case BusinessUnitType.France:
                    DdlSelectBusinessUnit.PickDropdownByText(driver, "909 - France");
                    break;
                case BusinessUnitType.IndiaDellIndiaPvtLtd:
                    DdlSelectBusinessUnit.PickDropdownByText(driver, "1717 - India (Dell India Pvt Ltd)");
                    break;
                case BusinessUnitType.IndiaICCINR:
                    DdlSelectBusinessUnit.PickDropdownByText(driver, "7460 - India (ICC INR)");
                    break;
                case BusinessUnitType.IndiaICCUSD:
                    DdlSelectBusinessUnit.PickDropdownByText(driver, "7465 - India (ICC USD)");
                    break;
                case BusinessUnitType.Ireland:
                    DdlSelectBusinessUnit.PickDropdownByText(driver, "5102 - Ireland");
                    break;
                case BusinessUnitType.UnitedKingdom:
                    DdlSelectBusinessUnit.PickDropdownByText(driver, "202 - United Kingdom");
                    break;
                case BusinessUnitType.UnitedStates:
                    DdlSelectBusinessUnit.PickDropdownByText(driver, "11 - United States");
                    break;
                default:
                    break;

            }
        }

        public List<IWebElement> userDetailsAttributesByRow(UserDetailsPage UDP)
        {
            var elemTable = UDP.getUserDetailsAttributesTable();
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            return lstTrElem;

        }

        public IWebElement getUserDetailsAttributesTable()
        {
            var elemTable = WebDriver.FindElements(By.XPath("//*[@id='main']//tbody"))[0]; 
            return elemTable;

        }

        public string userDetailsAttributesSearchByField(int row, int col)
        {
            try
            {
                var elemTable = getUserDetailsAttributesTable();
                var elem = WebDriver.GetElement(By.XPath("(//*[@id='main']//tbody)[1]" + "/tr[" + row + "]/td[" + col + "]"));// + "/tr[" + row + "]/td[" + col + "]"));
                return elem.Text;
            }
            catch (InvalidSelectorException e2)
            {
                throw (e2);
            }
            catch (NoSuchElementException e)
            {
                throw (e);
            }
            
        }

        //input : User Details Object,Business Unit & expected fields
        //method : checks that expected fields match required input parameters
        //returns row Number that Business Unit searched is on  
        public int verifyUserDetailsAttributeTableBusinessUnit(UserDetailsPage UserDetailspage, BusinessUnitType businessUnitType, string username, string lang
            , string salesRepId, string edit, string delete)
        {
            int AddedBusinessUnitRow = 0;
            var tblRows = new List<IWebElement>();
            tblRows = UserDetailspage.userDetailsAttributesByRow(UserDetailspage);

            //find corresponding status type for row which contains suspended DPID
            for (int rowNum = 1; rowNum <= tblRows.Count; rowNum++)
            {

                if (UserDetailspage.userDetailsAttributesSearchByField(rowNum, 1).Contains(businessUnitType.ToString()))
                {
                    //check row entries

                    UserDetailspage.userDetailsAttributesSearchByField(rowNum, 2).Should().BeEquivalentTo(username);
                    UserDetailspage.userDetailsAttributesSearchByField(rowNum, 3).Should().BeEquivalentTo(lang);
                    UserDetailspage.userDetailsAttributesSearchByField(rowNum, 4).Should().BeEquivalentTo(salesRepId);
                    UserDetailspage.userDetailsAttributesSearchByField(rowNum, 5).Should().Contain(edit);
                    UserDetailspage.userDetailsAttributesSearchByField(rowNum, 6).Should().Contain(delete);
                    AddedBusinessUnitRow = rowNum;
                }
            }
            return AddedBusinessUnitRow;

        }
        
        public bool checkUserDetailsAttributeTableFor(UserDetailsPage userDetailsPage, BusinessUnitType businessUnitType)
        {
            List<IWebElement> tblRows = new List<IWebElement>();
            tblRows = userDetailsPage.userDetailsAttributesByRow(userDetailsPage);
            for (int rowNum = 1; rowNum <= tblRows.Count; rowNum++)
            {

                if (userDetailsPage.userDetailsAttributesSearchByField(rowNum, 1).Contains(businessUnitType.ToString()))
                {
                    return false;
                }
            }
            return true;
        }


        public bool AddSingleUser(IWebDriver driver, string emailId, string salesRepId, BusinessUnitType businessUnitType = BusinessUnitType.UnitedStates)
        {
            var addUserValidation = new CustomerCreatePage(WebDriver);
            bool addUserMessage = true; ;
            UserDetailsAddUsers.Click(WebDriver);
            TxtEnterEmailAddres.SetText(WebDriver, emailId +" " +salesRepId);
            SelectBusinessUnitFromDrpDwn(WebDriver, businessUnitType);
            BtnSubmitAddUser.Click(WebDriver);
            if (addUserValidation.ElementExistValidation(AddUserErrorMessage))
            {
                addUserMessage = false;
            }

            return addUserMessage;
        }


        public void ClickEditUserAttribute(IWebDriver driver, int index = 0)
        {
            WebDriver.GetElements(By.XPath("//*[contains(@id, 'userDetails_editUserAttribute')]"))[index].Click(driver);
        }

        public void ClickDeleteUserAttribute(IWebDriver driver, int index = 0)
        {
            WebDriver.GetElements(By.XPath("//*[contains(@id, 'userDetails_deleteUserAttribute')]"))[index].Click(driver);
        }

        private void GetExistingProfiles()
        {
            foreach (var checkBox in userProfilesCheckBoxes)
            {
                if (checkBox.Selected)
                {

                }
            }
        }

        private void ClearAllProfiles()
        {

        }

        private void RefreshProfile()
        {

        }

        private void AssignProfiles()
        {

        }

        public void GiveFollowingProfilePermissions()
        {
            GetExistingProfiles();
            //ClearAllProfiles();
            AssignProfiles();
            RefreshProfile();
        }

        public void GiveOriginalProfilePermission()
        {
            ClearAllProfiles();

        }


    }
}
