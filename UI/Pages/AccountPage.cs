using OpenQA.Selenium;
using Test_Automation_Project.Utils;

namespace Test_Automation_Project.Pages
{
    public class AccountPage : ToolBar
    {
        private By username = By.XPath("//*[@class=\"sc-gGfaQS sc-dcntqk iCsBXi halcHM\"]");
        private By logout = By.XPath("//*[@data-cy=\"LogoutLink\"]");
        private By confirmLogout = By.XPath("//*[@class=\"sc-fEXmlR BTgcP\"]");

        public string GetUsername()
        {
            return WebDriverExtensions.GetTextFromElement(username);
        }

        public AccountPage PressLogout()
        {
            WebDriverExtensions.ClickOnElement(logout);
            return new AccountPage();
        }

        public MainPage ConfirmLogout()
        {
            WebDriverExtensions.ClickOnElement(confirmLogout);
            return new MainPage();
        }
    }
}
