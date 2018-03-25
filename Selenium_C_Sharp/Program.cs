﻿using OpenQA.Selenium;
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
            // Open webpage in browser
            driver.Navigate().GoToUrl("https://www.jet2holidays.com/");
            
            //click the pop up
            PageObjectModel.ClickPopUp();

            // click the dropdown for departure airports
            PageObjectModel.Click_List_Departure();

            // click a airport
            PageObjectModel.Click_Departure_Airport("East Midlands (EMA)");

            // click the dropdown for arrival airports
            PageObjectModel.Click_List_Arrival();

            // click a airport
            PageObjectModel.Click_Arrival_Airport("Salzburg");

            // click date dropdown
            PageObjectModel.Click_Date_Dropdown();

            //driver.Close();

        }
    }
}
