using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace TenantsAss.AutomatedTests.PageObjects
{
    class AddApartmentPage
    {
        private IWebDriver webDriver;

        [FindsBy(How = How.Id, Using = "ApartmentNo")]
        private IWebElement apartmentNo;

        [FindsBy(How = How.Id, Using = "UserName")]
        private IWebElement userName;

        [FindsBy(How = How.Id, Using = "BuildingId")]
        private IWebElement buildingId;

        [FindsBy(How = How.Id, Using = "BuildingNo")]
        private IWebElement buildingNo;

        [FindsBy(How = How.XPath, Using = "/html/body/div/main/center/form/div/div[2]/div[5]/input")]
        private IWebElement createButton;

        public AddApartmentPage(IWebDriver driver)
        {
            this.webDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Save(string apartmentNo, string userName,string buildingId, string buildingNo)
        {
            this.apartmentNo.Clear();
            this.apartmentNo.SendKeys(apartmentNo);
            this.userName.Clear();
            this.userName.SendKeys(userName);
            this.buildingId.SendKeys(buildingId);
            this.buildingNo.SendKeys(buildingNo);
            createButton.Click();
        }
    }
}
