using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace TenantsAss.AutomatedTest.PageObjects
{
    class PayInvoice
    {
        private IWebDriver webDriver;

        [FindsBy(How = How.Id, Using = "exampleSelect1")]
        private IWebElement status;

        [FindsBy(How = How.XPath, Using = "/html/body/div/main/div[1]/div/form/div[7]/input")]
        private IWebElement payButton;

        public PayInvoice(IWebDriver driver)
        {
            this.webDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Pay(string status)
        {

            //this.status.Clear();
            this.status.SendKeys(status);

            payButton.Click();

        }
    }
}
