using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace TenantsAss.AutomatedTest.PageObjects
{
    class LoginPage
    {
        private IWebDriver webDriver;

        [FindsBy(How = How.Id, Using = "exampleInputEmail1")]
        private IWebElement emailTextBox;

        [FindsBy(How = How.Id, Using = "exampleInputPassword1")]
        private IWebElement passwordTextBox;

        [FindsBy(How = How.XPath, Using = "/html/body/div/main/center/section/form/center/div[1]/button")]
        private IWebElement loginButton;

        public LoginPage(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Login(string userName, string password)
        {
            emailTextBox.Clear();
            emailTextBox.SendKeys(userName);

            passwordTextBox.Clear();
            passwordTextBox.SendKeys(password);

            loginButton.Click();
        }
    }
}
