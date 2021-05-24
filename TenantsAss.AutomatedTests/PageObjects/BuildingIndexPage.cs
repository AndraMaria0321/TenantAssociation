using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TenantsAss.AutomatedTests.PageObjects
{
    class BuildingIndexPage
    {
        private IWebDriver webDriver;

        [FindsBy(How = How.CssSelector, Using = "table")]
        private IWebElement buildingList;

        [FindsBy(How = How.LinkText, Using = "Add new building details")]
        private IWebElement addBuildingButton;

        public BuildingIndexPage(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void GoToPage()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44346/Building");
        }
        public AddBuildingPage GotoAddBuildingPage()
        {
            addBuildingButton.Click();
            return new AddBuildingPage(webDriver);
        }

        public bool BuildingExists(string streetName)
        {
            var elements = buildingList.FindElements(By.TagName("td"));
            return elements.Where(element => element.Text.Equals(streetName)).Count() > 0;

        }
    }
}
