using OpenQA.Selenium;
using System.Configuration;
using System.Linq;
using TechTalk.SpecFlow;

namespace SpecFlowVS2017Skeleton.SpecFlow.Support.Setup
{
    [Binding]
    public sealed class Act
    {
        public static IWebDriver browserInstance;

        internal static string Environment => ConfigurationManager.AppSettings["Host"];
        public static string Specflow => Environment + ConfigurationManager.AppSettings["Specflow"];

        [BeforeScenario]
        public static void beforeEachTest()
        {
            if (!ScenarioContext.Current.ScenarioInfo.Tags.Contains("no_browser"))
            {
                if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Firefox")){
                    browserInstance = Driver.InitializeFirefox();
                }else if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("InternetExplorer")){
                    browserInstance = Driver.InitializeInternetExplorer();
                }else{
                    browserInstance = Driver.InitializeChrome();
                }
                browserInstance.Navigate().GoToUrl(Specflow);
            }
        }

        [AfterScenario]
        public static void afterEachTest()
        {
            browserInstance.Quit();
        }
    }
}
