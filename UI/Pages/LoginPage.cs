﻿using OpenQA.Selenium;
using Test_Automation_Project.Utils;

namespace Test_Automation_Project.Pages
{
    public class LoginPage
    {
        private static By emailField = By.CssSelector("#Email");
        private static By passwordField = By.CssSelector("#Password");
        private static By submitButton = By.XPath("//*[@data-callback=\"onSubmit\"]");

        public LoginPage EnterEmail(string email)
        {
            WebDriverExtensions.SendKeysToElement(emailField, email);
            return new LoginPage();
        }

        public LoginPage EnterPassword(string password)
        {
            WebDriverExtensions.SendKeysToElement(passwordField, password);
            return new LoginPage();
        }

        public AccountPage PressLogIn()
        {
            WebDriverExtensions.ClickOnElement(submitButton);
            return new AccountPage();
        }
    }
}
