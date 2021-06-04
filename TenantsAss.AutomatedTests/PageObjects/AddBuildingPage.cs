using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace TenantsAss.AutomatedTests.PageObjects
{
    class AddBuildingPage
    {
        private IWebDriver webDriver;

        [FindsBy(How = How.Id, Using = "StreetName")]
        private IWebElement streetName;

        [FindsBy(How = How.Id, Using = "StreetNo")]
        private IWebElement streetNo;

        [FindsBy(How = How.Id, Using = "BuildingNo")]
        private IWebElement buildingNo;

        [FindsBy(How = How.XPath, Using = "/html/body/div/main/center/form/center/div/div[2]/div[4]/input")]
        private IWebElement createButton;

        public AddBuildingPage(IWebDriver driver)
        {
            this.webDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Save(string streetName, string streetNo, string buildingNo)
        {
            this.streetName.Clear();
            this.streetName.SendKeys(streetName);
            this.streetNo.Clear();
            this.streetNo.SendKeys(streetNo);
            this.buildingNo.Clear();
            this.buildingNo.SendKeys(buildingNo);
            createButton.Click();
        }

    }
}
