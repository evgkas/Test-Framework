using OpenQA.Selenium;
using Test_Automation_Project.Utils;

namespace Test_Automation_Project.Pages
{
    public class SalePage
    {
        private By productContainer = By.XPath("//*[@data-testid=\"product-container\"]");
        private By productLocator = By.XPath("//*[@data-testid=\"product-container\"]/a/div[@class=\"sc-fhzFiK cnoxFk\"]/h2");
        private By productsPrice = By.XPath("//*[@data-testid=\"price-component\"]");
        private By priceLowerLimit = By.XPath("(//*[@data-testid=\"price-input\"])[1]");
        private By priceUpperLimit = By.XPath("(//*[@data-testid=\"price-input\"])[2]");

        public ProductPage ToProduct(int productNumber)
        {
            List<IWebElement> products = ListOfProducts();
            products[productNumber].Click();

            return new ProductPage();
        }

        private List<IWebElement> ListOfProducts()
        {
            return WebDriverExtensions.GetElements(productLocator);
        }

        public SalePage PutLowPriceFilter(int price)
        {
            WebDriverExtensions.ClearField(priceLowerLimit);
            WebDriverExtensions.SendKeysToElement(priceLowerLimit, Convert.ToString(price));
            WebDriverExtensions.ClickOnEnter(priceLowerLimit);

            return new SalePage();
        }

        public SalePage PutUpPriceFilter(int price)
        {
            WebDriverExtensions.ClearField(priceUpperLimit);
            WebDriverExtensions.SendKeysToElement(priceUpperLimit, Convert.ToString(price));
            WebDriverExtensions.ClickOnEnter(priceUpperLimit);

            return new SalePage();
        }
    }
}
