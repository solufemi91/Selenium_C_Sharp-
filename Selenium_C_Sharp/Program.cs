using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Selenium_C_Sharp
{
    class Program
    {

        public static String PATH = "C:/webdriver/";

        public static IWebDriver driver = new ChromeDriver(PATH);

        static void Main(string[] args)
        {
            
            //String PATH = "C:/webdriver/";
            //IWebDriver driver = new ChromeDriver(PATH);

            driver.Navigate().GoToUrl("https://www.jet2holidays.com/");
            
            PageObjectModel.ClickPopUp();
            
            driver.Close();
            PageObjectModel.Test1();


        }
    }
}
