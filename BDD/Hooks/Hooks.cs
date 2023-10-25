using Core.Utils;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using Test_Automation_Project.Utils;
using Test_Automation_Project.WebDriver;

namespace BDD.Hooks
{
    public class Hooks
    {
        protected IWebDriver driver;
        protected Core.Utils.Logger logger;
        protected Screenshoter screenshoter;

        [BeforeScenario]
        public void Setup()
        {
            screenshoter = new Screenshoter();
            driver = Browser.GetDriver();
            Browser.WindowMaximize();
            Browser.StartNavigate();
            logger = new Logger();

            logger.LogInfo(Core.enums.LogLevel.Info, $"Start testcase {TestContext.CurrentContext.Test.Name}");
        }

        [AfterScenario]
        public void TearDown()
        {
            TestStatus NUnit_status = TestContext.CurrentContext.Result.Outcome.Status;

            if (NUnit_status.Equals(TestStatus.Failed))
            {
                var failMessage = $"[{TestContext.CurrentContext.Test.Name}] Test failed with Status: " +
                    TestContext.CurrentContext.Result.Message;
                logger.LogInfo(Core.enums.LogLevel.Error, failMessage);
                screenshoter.Capture();
            }
            else
            {
                var statusMessage = $"[{TestContext.CurrentContext.Test.Name}] Test ended with Status: " +
                    TestContext.CurrentContext.Result.Outcome.Status;
                logger.LogInfo(Core.enums.LogLevel.Info, statusMessage);
            }

            Browser.QuitBrowser();
            driver = null;

        }
    }
}
