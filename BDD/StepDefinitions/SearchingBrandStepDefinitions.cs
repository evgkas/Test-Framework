using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Test_Automation_Project.Pages;

namespace BDD.StepDefinitions
{
    [Binding]
    public class SearchingBrandStepDefinitions
    {
        private static MainPage mainPage = new();

        [Given(@"I should see Main page")]
        public void GivenIShouldSeeMainPage()
        {
            Assert.That(mainPage.IsVisible(), Is.True);
        }

        [When(@"I search ""([^""]*)""")]
        public void WhenISearchBy(string searchRequest)
        {
            mainPage.Search(searchRequest);
        }

        [Then(@"I should see products of the ""([^""]*)""")]
        public void ThenIShouldSeeProductsOfThe(string burberry)
        {
            throw new PendingStepException();
        }
    }
}
