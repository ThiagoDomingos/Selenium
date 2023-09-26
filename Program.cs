using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Selenium 
{ 
    class Program
    {
        

        public static void Main( )
        {
            //Create the reference of browser - GLOBAL
            IWebDriver driver = new ChromeDriver();

            //Example to Navigate
            driver.Navigate().GoToUrl("https://app.endtest.io/guides/docs/how-to-test-dropdowns/");

            //Find the Element
            //IWebElement element = driver.FindElement(By.Name("q"));

            //Usando metodos da classe SeleniumSetMethods
            
            //EnterText OK
            //SeleniumSetMethods.EnterText(driver, "APjFqb", "testando", "Id");

            //SelectDropDown OK
            SeleniumSetMethods.SelectDropDown(driver, "pets", "Dog", "Id");

            //Click
            SeleniumSetMethods.Click(driver, "[class='docs-next button']", "Selector");
            

            //Perform Ops sem classe
            //element.SendKeys("teste");

            driver.Quit();

            

      
        }

    }

}