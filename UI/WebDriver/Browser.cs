using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using static Test_Automation_Project.WebDriver.WebDriverFactory;

namespace Test_Automation_Project.WebDriver
{
    public class Browser
    {     
        private static BrowserType _currentBrowser;
        private static IWebDriver _currentInstance;
        private static IWebDriver webDriver => GetDriver();

        private static void InitParams()
        {            
            string browserFromConfig = DriverParameterReader.Get("browser");
            Enum.TryParse(browserFromConfig, out _currentBrowser);
        }

        private Browser()
        {
            InitParams();
            _currentInstance = WebDriverFactory.GetDriver(_currentBrowser);
        }

        public static IWebDriver GetDriver()
        {
            if (_currentInstance == null)
            {
                new Browser();
            }

            return _currentInstance;
        }

        public static void WindowMaximize() => webDriver.Manage().Window.Maximize();

        public static void NavigateTo(string url) => webDriver.Navigate().GoToUrl(url);

        public static void StartNavigate() => webDriver.Navigate().GoToUrl(DriverParameterReader.Get("startUrl"));

        public static void QuitBrowser()
        {
            webDriver.Quit();            
            _currentInstance = null;
        }

        public static Actions GetActions() => new Actions(GetDriver());

        public static IJavaScriptExecutor GetJSExecuter() => (IJavaScriptExecutor)GetDriver();
    }
}

