using OpenQA.Selenium;
using Test_Automation_Project.Utils;

namespace Test_Automation_Project.Pages
{
    public class ProductPage
    {
        private By addToCartButton = By.XPath("//*[@class=\"sc-gYbzsP kUucxW\"]");
        private By continueShopping = By.CssSelector("#upsellingContinueWithShopping");
        private By toBasket = By.XPath("//*[@data-cypress=\"goToShoppingCart\"]/button");
        private By closePopup = By.XPath("//*[@class='exponea-close-cross']");

        public ProductPage AddToCart()
        {
            WebDriverExtensions.ClickWithAction(addToCartButton);
            return new ProductPage();
        }

        public ProductPage ContinueShopping()
        {
            WebDriverExtensions.ClickOnElement(continueShopping);
            return new ProductPage();
        }

        public BasketPage ToBasket()
        {
            WebDriverExtensions.ClickOnElement(toBasket);
            return new BasketPage();
        }

        public ProductPage ClosePopUp()
        {
            WebDriverExtensions.ClickOnElement(closePopup);
            return new ProductPage();
        }
    }
}
