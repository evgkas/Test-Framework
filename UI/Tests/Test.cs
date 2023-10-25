namespace Test_Automation_Project.Tests
{
    [TestFixture]
    public class Test : BaseTest
    {
        [Test]
        public void AddProductToBasket()
        {
            int ammountOfItems = mainPage.
                AgreeWithCookies().
                ToSales().
                ToProduct(1).
                ClosePopUp().
                AddToCart().
                ToBasket().
                GetAmmountOfItems();

            Assert.That(ammountOfItems, Is.EqualTo(1));
        }

        [Test]
        public void LoginAndLogut()
        {
            mainPage.
                ToLoginPage();
            string actualUsername = loginSteps.
                Login(user).
                GetUsername();

            Assert.That(user.GetUsername(), Is.EqualTo(actualUsername));

            loginSteps.Logout();

            Assert.That(mainPage.IsVisible(), Is.True);
        }
    }
}
