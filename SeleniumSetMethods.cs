using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class SeleniumSetMethods
    {
        //Enter Text
        public static void EnterText(IWebDriver driver, string atributevalue, string value, string atributetype)
        {
            if (atributetype == "Id")
                driver.FindElement(By.Id(atributevalue)).SendKeys(value);
            if (atributetype == "Name")
                driver.FindElement(By.Name(atributevalue)).SendKeys(value);
            if (atributetype == "Selector")
                driver.FindElement(By.CssSelector(atributevalue)).SendKeys(value);
            if (atributetype == "XPath")
                driver.FindElement(By.XPath(atributevalue)).SendKeys(value);

        }

        //Click button, checkbox, option etc
        public static void Click(IWebDriver driver, string atributevalue, string atributetype)
        {
            if (atributetype == "Id")
                driver.FindElement(By.Id(atributevalue)).Click();
            if (atributetype == "Name")
                driver.FindElement(By.Name(atributevalue)).Click();
            if (atributetype == "CssSelector")
                driver.FindElement(By.CssSelector(atributevalue)).Click();
            if (atributetype == "XPath")
                driver.FindElement(By.XPath(atributevalue)).Click();
        }

        //Select a drop down control
        public static void SelectDropDown(IWebDriver driver, string atributevalue, string value, string atributetype)
        {
            
            if (atributetype == "Id")
                new SelectElement( driver.FindElement(By.Id(atributevalue))).SelectByText(value);
            if (atributetype == "Name")
                new SelectElement(driver.FindElement(By.Name(atributevalue))).SelectByText(value);
            if (atributetype == "CssSelector")
                new SelectElement(driver.FindElement(By.CssSelector(atributevalue))).SelectByText(value);
            if (atributetype == "XPath")
                new SelectElement(driver.FindElement(By.XPath(atributevalue))).SelectByText(value);
        }

    }
}
