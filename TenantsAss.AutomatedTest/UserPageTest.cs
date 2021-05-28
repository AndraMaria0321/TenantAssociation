using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TenantsAss.AutomatedTest.PageObjects;

namespace TenantsAss.AutomatedTest
{
    [TestClass]
    public class UserPageTest
    {
        private IWebDriver webDriver;

        [TestInitialize]
        public void Initialize()
        {
            webDriver = new ChromeDriver();
        }

        [TestMethod]
        public void UserPayInvoice()
        {
            string status = "Paid";

            HomePage homePage = new HomePage(webDriver);
            homePage.GoToPage();

            LoginPage loginPage = homePage.GetLoginPage();
            loginPage.Login("user@user.com", "User123456@");

            UserPage userPage = new UserPage(webDriver);
            userPage.GoToPage();

            PayInvoice payInvoice = userPage.GoToPayInvoice();
            payInvoice.Pay(status);

            Assert.IsTrue(userPage.PaimentExists(status));
        }

        [TestCleanup]
        public void Cleanup()
        {
            webDriver.Close();
        }
    }
}
