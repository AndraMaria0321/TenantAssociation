﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace TenantsAss.AutomatedTest.PageObjects
{
    class HomePage
    {
        private IWebDriver webDriver;

        public HomePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement loginButton;

        public LoginPage GetLoginPage()
        {
            loginButton.Click();
            return new LoginPage(webDriver);
        }

        public void GoToPage()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44336/");
        }
    }
}