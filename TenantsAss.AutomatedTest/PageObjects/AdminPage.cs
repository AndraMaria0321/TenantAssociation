using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TenantsAss.AutomatedTest.PageObjects
{
    class AdminPage
    {
        private IWebDriver webDriver;

        [FindsBy(How = How.CssSelector, Using = "main")]
        private IWebElement invoicesList;

        [FindsBy(How = How.XPath, Using = "/html/body/div/main/p/a")]
        private IWebElement createInvoiceButton;

        public AdminPage(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void GoToPage()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44336/Invoice");
        }

        public AddInvoice GoToAddInvoice()
        {
            createInvoiceButton.Click();
            return new AddInvoice(webDriver);
        }

        public bool InvoiceExists(string apartmentNo)
        {
            var elements = invoicesList.FindElements(By.TagName("td"));
            return elements.Where(element => element.Text.Equals(apartmentNo)).Count() > 0;
        }
    }
}
