using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TenantsAss.AutomatedTest.PageObjects
{
    class UserPage
    {
        private IWebDriver webDriver;

        [FindsBy(How = How.CssSelector, Using = "main")]
        private IWebElement payList;

        [FindsBy(How = How.XPath, Using = "/html/body/div/main/table/tbody/tr[1]/td[6]/a[1]")]
        private IWebElement payInvoiceButton;

        public UserPage(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void GoToPage()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44336/Pay");
        }

        public PayInvoice GoToPayInvoice()
        {
            payInvoiceButton.Click();
            return new PayInvoice(webDriver);
        }

        public bool PaimentExists(string status)
        {
            var elements = payList.FindElements(By.TagName("td"));
            return elements.Where(element => element.Text.Equals(status)).Count() > 0;
        }
    }
}
