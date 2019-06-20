using FluentAssertions;
using OpenQA.Selenium;
using SpecFlowVS2017Skeleton.SpecFlow.Support.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowVS2017Skeleton.SpecFlow.StepDefinitions
{
    [Binding]
    public sealed class ExampleStepDefinition
    {
        [Given(@"I inpuf the Cat Consultancy url in to google chrome")]
        public void GivenIInpufTheCatConsultancyUrlInToGoogleChrome()
        {
            //creates instance of new Chromedriver
            Driver.Initialize("Chrome");

            //navigates to the website
            Driver.instance.Navigate().GoToUrl("http://accept.li/posts/");

        }

        [Then(@"i am on the Act Consultancy webpage")]
        public void ThenIAmOnTheActConsultancyWebpage()
        {
            string webPageTitle = Driver.instance.FindElement(By.CssSelector("p.site-title > a")).Text;
            webPageTitle.Should().BeEquivalentTo("Act. Consulting");
            Driver.instance.Quit();
        }
    }
}
