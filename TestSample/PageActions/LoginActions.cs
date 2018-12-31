using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSample
{
    public class LoginActions
    {
        WebElementUtils elementUtils = new WebElementUtils();

        public void NavigateToURL()
        {
            elementUtils.NavigateToURL(WebDriverUtils.GetURL());
        }
        public void LinkedLogin(string username, string password)
        {
            elementUtils.ClickElement(Login.username);
            elementUtils.SendKeys(Login.username, username);
            elementUtils.ClickElement(Login.password);
            elementUtils.SendKeys(Login.password, password);
        }
    }
}
