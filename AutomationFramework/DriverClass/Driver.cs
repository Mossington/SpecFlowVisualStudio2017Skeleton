using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SpecFlowVS2017Skeleton.AutomationFramework.DriverClass
{
    public class Driver
    {
        public static IWebDriver Instance;

        public static IWebDriver InitializeChrome()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Window.Maximize();
            return Instance;
        }

        public static IWebDriver InitializeFirefox()
        {
            Instance = new FirefoxDriver();
            Instance.Manage().Window.Maximize();
            return Instance;
        }

        public static IWebDriver InitializeInternetExplorer()
        {
            Instance = new InternetExplorerDriver();
            Instance.Manage().Window.Maximize();
            return Instance;
        }

        public static void closeBrowserInstance()
        {
            Instance.Quit();
        }
    }
}
