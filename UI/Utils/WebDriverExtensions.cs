using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Test_Automation_Project.WebDriver;

namespace Test_Automation_Project.Utils
{
    public static class WebDriverExtensions
    {
        private static void WaitElementIsVisible(By locator)
        {
            WebDriverWait Wait = new WebDriverWait(Browser.GetDriver(),
                TimeSpan.FromSeconds(int.Parse(DriverParameterReader.Get("elementTimeout"))));
            Wait.Until(driver => driver.FindElement(locator).Displayed);
        }

        private static void WaitElementIsClickable(By locator)
        {
            WebDriverWait Wait = new WebDriverWait(Browser.GetDriver(), TimeSpan.FromSeconds(int.Parse(DriverParameterReader.Get("elementTimeout"))));
            Wait.Until(driver => driver.FindElement(locator).Enabled);
        }
        public static void ClickOnElement(By locator)
        {
            WaitElementIsVisible(locator);
            Browser.GetDriver().FindElement(locator).Click();
        }

        public static void SendKeysToElement(By locator, string text)
        {
            WaitElementIsVisible(locator);
            Browser.GetDriver().FindElement(locator).SendKeys(text);
        }

        public static void ClickOnEnter(By locator)
        {
            WaitElementIsVisible(locator);
            Browser.GetDriver().FindElement(locator).SendKeys(Keys.Enter);
        }

        public static string GetTextFromElement(By locator)
        {
            WaitElementIsVisible(locator);
            return Browser.GetDriver().FindElement(locator).Text;
        }

        public static bool IsElementVisible(By locator)
        {
            try
            {
                WaitElementIsVisible(locator);
                return Browser.GetDriver().FindElement(locator).Displayed;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
            catch (StaleElementReferenceException)
            {
                return false;
            }
        }

        public static string GetAttributeValueFromElement(By locator, string attribute)
        {
            WaitElementIsVisible(locator);
            return Browser.GetDriver().FindElement(locator).GetAttribute(attribute);
        }

        public static void ClearField(By locator)
        {
            WaitElementIsVisible(locator);
            Browser.GetDriver().FindElement(locator).Clear();
        }

        public static IWebElement GetElement(By locator)
        {
            WaitElementIsVisible(locator);
            return Browser.GetDriver().FindElement(locator);
        }

        public static void ClickWithAction(By locator)
        {
            var elementToClick = GetElement(locator);
            Browser.GetActions().MoveToElement(elementToClick).Click().Perform();
        }

        public static void HoverElement(By locator)
        {
            var elementToHover = GetElement(locator);
            Browser.GetActions().MoveToElement(elementToHover);
        }

        public static List<IWebElement> GetElements(By locator)
        {
            WaitElementIsVisible(locator);
            return Browser.GetDriver().FindElements(locator).ToList();
        }

        public static int AmmountOfElements(By locator)
        {
            WaitElementIsVisible(locator);
            return Browser.GetDriver().FindElements(locator).Count;
        }

        public static void ClickToElementNumber(By locator, int number)
        {
            WaitElementIsVisible(locator);
            var elements = Browser.GetDriver().FindElements(locator);

            if (number > elements.Count)
            {
                throw new ArgumentOutOfRangeException($"There is less than {number} items");
            }

            elements[number - 1].Click();
        }
    }
}
