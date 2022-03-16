using System;
using OpenQA.Selenium;

namespace Dsa.Utils
{
    public static class Logger
    {
        public static void Write(By by, string log)
        {
            string elementName = by.ToString();
            Console.WriteLine("{0} - {1}:{2}", DateTime.Now, elementName, log);
        }

        public static void Write(string log)
        {
            Console.WriteLine("{0} - {1}", DateTime.Now, log);
        }

        public static void Write(IWebElement element, string log)
        {
            string elementId = element.GetAttribute("id");
            if (!string.IsNullOrEmpty(elementId))
                Console.WriteLine("{0} - [Element Id: '{1}'] : {2}", DateTime.Now, elementId, log);
            else
                Console.WriteLine("{0} - {1}", DateTime.Now, log);
        }

        public static void Write(Object by, string log)
        {
            string elementName = by.ToString();
            Console.WriteLine("{0} - {1}:{2}", DateTime.Now, elementName, log);
        }
    }
}   
