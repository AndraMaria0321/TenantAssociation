using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TenantsAss.AutomatedTests
{
    [TestClass]
    public class AdminPageTest
    {
        private IWebDriver driver;

        [TestInitialize]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("https://localhost:44346/");
            //IWebElement loginPageLink =  driver.FindElement(By.LinkText("Login"));
           // loginPageLink.Click();
            
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Close();
        }
    }
}
