using Test_Automation_Project.Model;
using Test_Automation_Project.Pages;

namespace Test_Automation_Project.Steps
{
    public class LoginSteps
    {
        private static LoginPage loginPage = new();
        private static AccountPage accountPage = new();

        public AccountPage Login(User user)
        {
            loginPage.
                EnterEmail(user.GetUsername()).
                EnterPassword(user.GetPassword()).
                PressLogIn();

            return new AccountPage();
        }

        public MainPage Logout()
        {
            accountPage.
                PressLogout().
                ConfirmLogout();

            return new MainPage();
        }
    }
}
