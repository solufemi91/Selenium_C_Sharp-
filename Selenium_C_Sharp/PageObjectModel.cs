using OpenQA.Selenium;
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

        public static void Click_List_Departure()
        {
            IReadOnlyCollection<IWebElement> element = Program.driver.FindElements(By.ClassName("search-box-group__link"));
            element.ElementAt(0).Click();
        }

        public static void Click_Departure_Airport(String Location)
        {
            IReadOnlyCollection<IWebElement> elements = Program.driver.FindElements(By.ClassName("checkbox-button-group__item"));
            foreach(IWebElement element in elements)
            {
                if (element.Text == Location)
                {
                    element.Click();
                }
            }
        }

    }
}
