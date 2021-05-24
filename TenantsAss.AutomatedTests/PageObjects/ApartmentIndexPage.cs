using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TenantsAss.AutomatedTests.PageObjects
{
    class ApartmentIndexPage
    {
        private IWebDriver webDriver;

        [FindsBy(How = How.CssSelector, Using = "table")]
        private IWebElement apartmentList;

        [FindsBy(How = How.LinkText, Using = "Create New")]
        private IWebElement addApartmentButton;

        public ApartmentIndexPage(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void GoToPage()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44346/Apartments");
        }
        public AddApartmentPage GotoAddApartmentPage()
        {
            addApartmentButton.Click();
            return new AddApartmentPage(webDriver);
        }

        public bool ApartmentExists(string streetName)
        {
            var elements = apartmentList.FindElements(By.TagName("td"));
            return elements.Where(element => element.Text.Equals(streetName)).Count() > 0;

        }
    }
}
