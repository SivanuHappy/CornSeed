using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSample
{
    public class WebElementUtils : WebDriverUtils
    {
    
        public void ClickElement(By element)
        {
            driver.FindElement(element).Click();
        }

        public void SendKeys(By element, String value)
        {
            driver.FindElement(element).SendKeys(value);
        }

        public void NavigateToURL(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
