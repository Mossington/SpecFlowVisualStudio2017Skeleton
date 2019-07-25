using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowVS2017Skeleton.SpecFlow.Support.BaseStep;
using System;

namespace SpecFlowVS2017Skeleton.AutomationFramework.Selenium.BaseElements
{
    public class BaseElement
    {
        protected IWebElement element(By by)
        {
            WebDriverWait wait = new WebDriverWait(Act.browserInstance, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));

            return Act.browserInstance.FindElement(by);
        }
    }
}
