using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestSample
{
    [TestFixture]
    public class TestClass
    {
        LoginActions lActions = new LoginActions();

        [OneTimeSetUp]
        public void SetUp()
        {
            WebDriverUtils.InitializeBrowser();   
        }
        [Test]
        public void TestMethod()
        {
            lActions.NavigateToURL();
        }

        [Test, TestCaseSource(typeof(TestCaseRead), "ReadExcel")]
        public void LoginTest(string username, string password)
        {
            lActions.LinkedLogin(username, password);
        }
        [OneTimeTearDown]
        public void TearDown()
        {
            WebDriverUtils.CloseBrowser();
        }
    }
}
