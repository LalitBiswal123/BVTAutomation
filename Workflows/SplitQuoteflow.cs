using System;
using System.Collections.Generic;
//using Dell.Adept.UI.Web.Testing.Framework.WebUIMsTestbase;
using Dsa.Pages.Quote;
using Dsa.Utils;
using FluentAssertions;
using OpenQA.Selenium;
using HomeWorkFlow = Dsa.Workflows;

namespace Dsa.Workflows
{
     public class SplitQuoteWorkflow
     {
         
          public static void ChangeCustomer_Quote(IWebDriver driver, string newcustnumber)
          {
              var QuoteSplit = new QuoteSplitResultsPage(driver);
              QuoteSplit.ClickChangeCustomer_Quote();
              QuoteSplit.QuoteSplitCustomerNumber.Clear();
              QuoteSplit.QuoteSplitCustomerNumber.SendKeys(newcustnumber);
              QuoteSplit.QuoteSplitSearchCustomerNumber.Click();
                                         
          }

         public static List<string> getSplittedQuoteNumberList(IWebDriver driver)
         {
             List<string> quoteNumbersList = new List<string>();
             var iWebelementList = driver.GetElements(By.XPath("//a[contains(@href,'/quote/details/QuoteNumber')]"));
             if (iWebelementList != null)
             {
                 
                 foreach (var quotenoLink in iWebelementList)
                 {
                     var quoteNo = quotenoLink.Text.Split(new string[] {"v1"}, StringSplitOptions.None)[0].Trim();
                     quoteNumbersList.Add(quoteNo);           
                 }
             }
             else
             {
                 Logger.Write("Splitted quote numbers element is not present");
                 throw new NoSuchElementException("Splitted quote numbers element is not present");
             }

             return quoteNumbersList;

         }

     


   public static void Solution_Restriction(IWebDriver driver)
          {
              IReadOnlyCollection<IWebElement> table = driver.FindElements(By.XPath("//table[contains(@id,'DataTables_Table')]//tbody/tr"));
              int i = 1;
              foreach(IWebElement tabledata in table){
                  string splitoption = driver.FindElement(By.XPath("//table[contains(@id,'DataTables_Table')]//tbody/tr[" + i + "]/td[2]")).GetText(driver);
                  if(!splitoption.Equals("By Shipping Group")){
                      driver.FindElement(By.XPath("//table[contains(@id,'DataTables_Table')]//tbody/tr[" + i + "]/td[1]//input")).Enabled.Should().BeFalse();                  
             /// Refer create QuoteDetailsPage page.    
              }
                  i++;
              }
           }
          }

}