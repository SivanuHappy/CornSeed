using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSample
{
    public class WebDriverUtils
    {
        protected static IWebDriver driver;
        protected static String url = "https://www.linkedin.com/";
        public static void InitializeBrowser()
        {
            driver = Browsers.InitializeBrowser(driver);
            driver.Manage().Window.Maximize();
            GoTo();
        }
        public static string GetURL()
        {
            return driver.Url;
        }
        public static void CloseBrowser()
        {
            driver.Quit();
        }

        public static void GoTo()
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
