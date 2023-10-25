using OpenQA.Selenium;
using Test_Automation_Project.Utils;

namespace Test_Automation_Project.Pages
{
    public class WelcomePage
    {
        private static By toBritishShop = By.XPath("//*[@hreflang='en']/span[1]");

        public MainPage ToBritishShop()
        {
            WebDriverExtensions.ClickOnElement(toBritishShop);
            return new MainPage();
        }
    }
}
