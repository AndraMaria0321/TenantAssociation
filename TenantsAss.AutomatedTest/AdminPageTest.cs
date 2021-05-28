using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Quartz;
using System;
using System.Globalization;
using TenantsAss.AutomatedTest.PageObjects;

namespace TenantsAss.AutomatedTest
{
    [TestClass]
    public class AdminPageTest
    {

        private IWebDriver webDriver;

        [TestInitialize]
        public void Initialize()
        {
            webDriver = new ChromeDriver();
        }

        [TestMethod]
        public void AdminAddInvoice()
        {
            string userName = "user1@user.com";
            string apartmentNo = "2";
            string apartmentId = "4";
            string price = "123";
            string dueDate = "05-24-2021-\t-10-30PM";
            string status = "Unpaid";
            string description = "Hello!You have a new invoice.Please, do not forget to pay.";

            HomePage homePage = new HomePage(webDriver);
            homePage.GoToPage();

            LoginPage loginPage = homePage.GetLoginPage();
            loginPage.Login("admin@admin.com", "Admin123456@");

            AdminPage adminPage = new AdminPage(webDriver);
            adminPage.GoToPage();

            AddInvoice addInvoice = adminPage.GoToAddInvoice();
            addInvoice.Create(userName, apartmentNo, apartmentId, price, dueDate, status, description);

            Assert.IsTrue(adminPage.InvoiceExists(apartmentNo));
        }

        [TestCleanup]
        public void Cleanup()
        {
            webDriver.Close();
        }
    }
}
