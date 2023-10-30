using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using Test_Automation_Project.Pages;

namespace BDD.StepDefinitions
{
    [Binding]
    public class LoginInvalidUserStepDefinitions
    {
        private static LoginPage loginPage = new();
        private static MainPage mainPage = new();

        [Given(@"I should see Login page")]
        public void GivenIShouldSeeLoginPage()
        {
            bool isPageVisible = mainPage.
                ToLoginPage().
                IsVisible();
            Assert.That(isPageVisible, Is.True);
        }

        [When(@"When I put in invalid credentials \(""([^""]*)"" or ""([^""]*)""\)")]
        public void WhenWhenIPutInInvalidCredentialsLoginOrPassword(string login, string password)
        {
            loginPage.
                EnterEmail(login).
                EnterPassword(password).
                PressLogIn();
        }

        [Then(@"I should see error message")]
        public void ThenIShouldSeeErrorMessage()
        {
            Assert.That(loginPage.IsCredentialErrorVisible(), Is.True);
        }
    }
}
