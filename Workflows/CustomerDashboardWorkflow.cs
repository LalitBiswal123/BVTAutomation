using OpenQA.Selenium;
using Dsa.Pages.Customer;

namespace Dsa.Workflows
{
   public static class CustomerDashboardWorkflow
   {
       #region CustomerSearchByNumber
       public static CustomerDetailsPage SearchCustomerByNumber(IWebDriver Driver,string customerNumber)
       {
           HomeWorkflow.GoToPersonSearch(Driver);
           var personSearchPage = new PersonSearchPage(Driver);
           var customerDetailsPage = personSearchPage.SearchPersonByCustomerNumber(customerNumber);
           return customerDetailsPage;
       }

      
       #endregion
   }
}
