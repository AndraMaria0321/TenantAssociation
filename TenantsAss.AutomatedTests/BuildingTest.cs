using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TenantsAss.AutomatedTests.PageObjects;

namespace TenantsAss.AutomatedTests
{
    [TestClass]
    public class BuildingTest
    {
        private IWebDriver webDriver;
        [TestInitialize]
        public void InitTests()
        {
            webDriver = new ChromeDriver();
        }
        [TestMethod]
        public void AddBuilding_Creates_BuildingWithGivenName()
        {

            Random randomNumber = new Random();
            string streetName = "StreetNameTest " + randomNumber.Next(100, 10000000);
            HomePage homePage = new HomePage(webDriver);
            homePage.GoToPage();
            LoginPage loginPage = homePage.GoToLoginPage();
            loginPage.Login("User1@user.com", "User123.");

            BuildingIndexPage indexPage = new BuildingIndexPage(webDriver);
            indexPage.GoToPage();
            AddBuildingPage addbuildingPage = indexPage.GotoAddBuildingPage();
            addbuildingPage.Save(streetName, "1", "1");

            Assert.IsTrue(indexPage.BuildingExists(streetName));

        }
        [TestCleanup]
        public void Cleanup()
        {
            webDriver.Close();
        }
    }
}
