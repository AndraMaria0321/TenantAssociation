using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace TenantsAss.AutomatedTest.PageObjects
{
    class AddInvoice
    {
        private IWebDriver webDriver;

        [FindsBy(How = How.Id, Using = "UserName")]
        private IWebElement userName;

        [FindsBy(How = How.Id, Using = "ApartmentNo")]
        private IWebElement apartmetnNo;

        [FindsBy(How = How.Id, Using = "ApartmentId")]
        private IWebElement apartmentId;

        [FindsBy(How = How.Id, Using = "Price")]
        private IWebElement price;

        [FindsBy(How = How.Id, Using = "DueDate")]
        private IWebElement dueDate;

        [FindsBy(How = How.Id, Using = "exampleSelect1")]
        private IWebElement status;

        [FindsBy(How = How.Id, Using = "Description")]
        private IWebElement description;

        [FindsBy(How = How.XPath, Using = "/html/body/div/main/center/div[1]/div/form/div[8]/input")]
        private IWebElement createButton;

        public AddInvoice(IWebDriver driver)
        {
            this.webDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Create(string userName, string apartmentNo, string apartmentId, string price, string dueDate, string status, string description)
        {
            this.userName.Clear();
            this.userName.SendKeys(userName);

            this.apartmentId.Clear();
            this.apartmentId.SendKeys(apartmentId);

            this.apartmetnNo.Clear();
            this.apartmetnNo.SendKeys(apartmentNo);

            this.price.Clear();
            this.price.SendKeys(price);

            this.dueDate.Clear();
            this.dueDate.SendKeys(dueDate);

            //this.status.Clear();
            this.status.SendKeys(status);

            this.description.Clear();
            this.description.SendKeys(description);

            createButton.Click();

        }
    }
}
