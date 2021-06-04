using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TenantsAss.AutomatedTests.PageObjects;

namespace TenantsAss.AutomatedTests
{
    [TestClass]
    public class ApartmentTest
    {
        private IWebDriver webDriver;
        [TestInitialize]
        public void InitTests()
        {
            webDriver = new ChromeDriver();
        }
        [TestMethod]
        public void AddApartment_Creates_ApartmentWithGivenNumber()
        {

            Random randomNumber = new Random();
            string apartmentNo = "" + randomNumber.Next(1, 100);
            HomePage homePage = new HomePage(webDriver);
            homePage.GoToPage();
            LoginPage loginPage = homePage.GoToLoginPage();
            loginPage.Login("User1@user.com", "User123.");
            string username = "User1@user.com";

            ApartmentIndexPage indexPage = new ApartmentIndexPage(webDriver);
            indexPage.GoToPage();
            AddApartmentPage addapartmentPage = indexPage.GotoAddApartmentPage();
            addapartmentPage.Save(apartmentNo,username, "1", "78");

            Assert.IsTrue(indexPage.ApartmentExists(apartmentNo));

        }
        [TestCleanup]
        public void Cleanup()
        {
            webDriver.Close();
        }
    }
}
