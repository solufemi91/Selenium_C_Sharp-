﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_C_Sharp
{
    class PageObjectModel { 


        public static void ClickPopUp()
        {
            IReadOnlyCollection<IWebElement> element = Program.driver.FindElements(By.ClassName("j017-close-lightbox"));
            element.ElementAt(0).Click();
        }
    }
}