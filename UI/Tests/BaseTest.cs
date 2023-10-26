using Core.enums;
using Core.Utils;
using NUnit.Framework.Interfaces;
using Test_Automation_Project.Core.Model;
using Test_Automation_Project.Core.Utils;
using Test_Automation_Project.Pages;
using Test_Automation_Project.Steps;
using Test_Automation_Project.Utils;
using Test_Automation_Project.WebDriver;

namespace Test_Automation_Project.Tests
{
    public abstract class BaseTest
    {
        protected static Logger logger;
        protected static Screenshoter screenshoter;
        protected static WelcomePage welcomePage = new WelcomePage();
        protected static BasketPage basketPage = new();
        protected static MainPage mainPage = new();
        protected static LoginSteps loginSteps = new();
        protected static User user = UserBuilder.ValidUser();

        [SetUp]
        public void Setup()
        {
            logger = new Logger();
            screenshoter = new Screenshoter();
            logger.LogInfo(LogLevel.Info, $"Start Test [{TestContext.CurrentContext.Test.Name}]");
            Browser.WindowMaximize();
            Browser.StartNavigate();
            mainPage.AgreeWithCookies();
        }

        [TearDown]
        public void Quit()
        {
            TestStatus NUnit_status = TestContext.CurrentContext.Result.Outcome.Status;

            if (NUnit_status.Equals(TestStatus.Failed))
            {
                var failMessage = $"[{TestContext.CurrentContext.Test.Name}] Test failed with Status: " +
                    TestContext.CurrentContext.Result.Message;
                logger.LogInfo(LogLevel.Error, failMessage);
                screenshoter.Capture();
            }
            else
            {
                var statusMessage = $"[{TestContext.CurrentContext.Test.Name}] Test ended with Status: " +
                    TestContext.CurrentContext.Result.Outcome.Status;
                logger.LogInfo(LogLevel.Info, statusMessage);
            }

            Browser.QuitBrowser();
        }
    }
}