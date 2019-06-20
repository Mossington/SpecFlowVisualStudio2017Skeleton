using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowVS2017Skeleton.SpecFlow.Support.Driver
{
    public class Driver
    {
        public static IWebDriver instance { get; set; }

        /// <summary>
        /// Chrome, Firefox
        /// </summary>
        /// <param name="browser"></param>
        /// <returns></returns>
        public static IWebDriver Initialize(string browser)
        {
            instance = null;
            switch (browser)
            {
                case "Chrome":
                    instance = new ChromeDriver();
                    break;
                case "Firefox":
                    instance = new FirefoxDriver();
                    break;
            }
            instance.Manage().Window.Maximize();
            return instance;
        }

        public static void Quit()
        {
            instance.Quit();
        }
    }
}
