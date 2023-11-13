using OpenQA.Selenium;
using Test_Automation_Project.Utils;

namespace Test_Automation_Project.Pages
{
    public abstract class ToolBar
    {
        private static By fragranceCategory = By.XPath("//*[@data-cypress=\"mainMenu-Fragrance\"]");
        private static By bascketButton = By.XPath("//*[@data-cypress=\"cart-info\"]/div");
        private static By mainLogo = By.XPath("//*[@aria-label=\"Notino logo\"]");
        private static By searchField = By.XPath("//*[@type=\"search\"]");

        public void HoverFragrance()
        {
            WebDriverExtensions.HoverElement(fragranceCategory);
        }

        public BasketPage ToBascket()
        {
            WebDriverExtensions.ClickOnElement(bascketButton);
            return new BasketPage();
        }

        public MainPage ToMainPage()
        {
            WebDriverExtensions.ClickOnElement(mainLogo);
            return new MainPage();
        }

        public ProductsPage Search(string request)
        {
            WebDriverExtensions.SendKeysToElement(searchField, request);
            WebDriverExtensions.ClickOnEnter(searchField);

            return new ProductsPage();
        }
    }
}
