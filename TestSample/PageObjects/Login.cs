using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSample
{
    public class Login
    {
        public static By username = By.Id("login-email");
        public static By password = By.Id("login-password");
    }
}
