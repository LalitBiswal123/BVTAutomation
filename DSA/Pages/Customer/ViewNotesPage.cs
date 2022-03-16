using Dsa.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace Dsa.Pages.Customer
{
   public class ViewNotesPage : DsaPageBase
    {
       public ViewNotesPage(IWebDriver webDriver) : base(webDriver)
       {
           PageFactory.InitElements(webDriver, this);
       }

       #region Elements

        public IWebElement AllNotesAccountName { get { return WebDriver.GetElement(By.Id("customerViewAllNotes_accountName")); } }

        public IWebElement DdlPerPage { get { return WebDriver.GetElement(By.Id("grid_paging_itemsPerPage")); } }

        public IWebElement GrdAllNotes { get { return WebDriver.GetElement(By.Id("notesList")); } }

        #endregion

        /// <summary>
        /// Validates this instance by checking that the account name is displayed
        /// </summary>
        /// <returns><c>true</c> if the account name is displayed 
        /// <c>false</c> otherwise.</returns>
        public override bool Validate()
       {
           return AllNotesAccountName.Displayed;
       }

       /// <summary>
       /// got right url?
       /// </summary>
       /// <returns><c>true</c> if this instance is active; otherwise, <c>false</c>.</returns>
       public override bool IsActive()
       {
           return (WebDriver.Url.Contains("customer/notes"));
       }

       //TODO:: Need to uncomment once the Page Count, PageNext, Pagination in Util classs
       /// <summary>
       /// get the list of Notes
       /// </summary>
       /// <returns></returns>
       public List<Dictionary<string, object>> GetAllNotes()
       {
           return DdlPerPage.GetHtmlTableData(WebDriver);
       }

       /// <summary>
       /// set the maximum number of items per page to display
       /// </summary>
       /// <param name="itemMax"></param>
       public void SetPerPageCount(int itemMax)
       {
           if (DdlPerPage.Displayed)
              
               DdlPerPage.PickDropdownByText(WebDriver, string.Format("{0} per page", itemMax));
           //TODO:: Need to handle NoSuchElementException with IWebElement
           //else
           //    throw new NoSuchElementException(CustomerIDs.PerPageDropdown);
       }

       /// <summary>
       /// these methods scroll to other pages by either clicking the arrows or the page numbers
       /// </summary>
       //public void GoToNextPage()
       //{
       //    WebDriver.GoToNextPage();
       //}
       //public void GoToPage(int pageNum)
       //{
       //    WebDriver.GoToPage(pageNum);
       //}

       ///// <summary>
       ///// returns the "1-10 of 78" display, from given position 'start' and of given 'length'
       ///// </summary>
       ///// <param name="start"></param>
       ///// <param name="length"></param>
       ///// <returns></returns>
       //public string GetTablePagingDisplay(int start, int length)
       //{
       //    return WebDriver.GetPagingDisplay(start, length);
       //}

       /// <summary>
       /// expands the given line
       /// </summary>
       /// <param name="i"></param>
       public void ExpandLine(int i)
       {
           var js = WebDriver as IJavaScriptExecutor;
           js.ExecuteScript(string.Format(
               "$('#{0}').find('tbody>tr:nth-child({1})').find('td:nth-child(1)>a').click();",
              GrdAllNotes, i));
       }

    }
}
