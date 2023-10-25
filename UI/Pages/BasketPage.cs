using OpenQA.Selenium;
using Test_Automation_Project.Utils;

namespace Test_Automation_Project.Pages
{
    public class BasketPage
    {
        private By totalPrice = By.XPath("//*[@class=\"sc-iERabD sc-iqavZe gSVJEt klOPhz\"]");
        private By removeFromeBasket = By.XPath("//*[@title=\"remove from basket\"]");

        public double GetTotalPrice()
        {
            return Convert.ToDouble(WebDriverExtensions.GetElement(totalPrice).Text);
        }

        public int GetAmmountOfItems()
        {
            return WebDriverExtensions.AmmountOfElements(removeFromeBasket);
        }

        public BasketPage RemoveItem(int itemNumber)
        {
            WebDriverExtensions.ClickToElementNumber(removeFromeBasket, itemNumber);
            return new BasketPage();
        }
    }
}
