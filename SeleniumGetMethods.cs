using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    internal class SeleniumGetMethods
    {
        public static string GetTextValue(IWebDriver driver, string atributevalue, string atributetype)
        {
            if (atributetype == "Id")
               return driver.FindElement(By.Id(atributevalue)).GetAttribute("value");

            if (atributetype == "Name")
                return driver.FindElement(By.Name(atributevalue)).GetAttribute("value");

            if (atributetype == "CssSelector")
                return driver.FindElement(By.CssSelector(atributevalue)).GetAttribute("value");

            else return String.Empty;
        }


        public static string GetText(IWebDriver driver, string atributevalue, string atributetype)
        {
            if (atributetype == "Id")
                return driver.FindElement(By.Id(atributevalue)).Text;

            if (atributetype == "Name")
                return driver.FindElement(By.Name(atributevalue)).Text;

            if (atributetype == "CssSelector")
                return driver.FindElement(By.CssSelector(atributevalue)).Text;

            else return String.Empty;
        }

        public static string GetTextDDL(IWebDriver driver, string atributevalue, string atributetype)
        {
            if (atributetype == "Id")
                //.Text nao funciona para todos controles
                return new SelectElement(driver.FindElement(By.Id(atributevalue))).AllSelectedOptions.SingleOrDefault().Text;

            if (atributetype == "Name")
                return new SelectElement(driver.FindElement(By.Name(atributevalue))).AllSelectedOptions.SingleOrDefault().Text;

            else return String.Empty;
        }
    }
}
