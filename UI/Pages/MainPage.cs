using OpenQA.Selenium;
using Test_Automation_Project.Utils;
using Test_Automation_Project.WebDriver;

namespace Test_Automation_Project.Pages
{
    public class MainPage : ToolBar
    {
        private static By agreeWithCookies = By.XPath("//*[@class='ack accept exp-btn close']");
        private static By saleCategory = By.XPath("//*[@class=\"shop-category__name\"][contains(.,'Sale')]");
        private static By accountButton = By.XPath("//*[@title=\"My account\"]");
        private static By title = By.XPath("//*/title[contains(., 'Shop Beauty & Fragrance')]");

        public LoginPage ToLoginPage()
        {
            WebDriverExtensions.ClickOnElement(accountButton);
            return new LoginPage();
        }
        
        public MainPage AgreeWithCookies()
        {
            WebDriverExtensions.ClickOnElement(agreeWithCookies);
            return new MainPage();
        }

        public SalePage ToSales()
        {
            WebDriverExtensions.ClickOnElement(saleCategory);
            return new SalePage();
        }

        public bool IsVisible()
        {
            return Browser.GetDriver().Title.Contains("Shop Beauty & Fragrance");
        }
    }
}
