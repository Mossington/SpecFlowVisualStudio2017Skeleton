using FluentAssertions;
using OpenQA.Selenium;
using SpecFlowVS2017Skeleton.SpecFlow.Support.Setup;
using TechTalk.SpecFlow;

namespace SpecFlowVS2017Skeleton.SpecFlow.StepDefinitions
{
    [Binding]
    public sealed class ExampleStepDefinition
    {
        [Given(@"I input the Aat Consultancy url in to Internet Explorer")]
        [Given(@"I input the Aat Consultancy url in to FireFox")]
        [Given(@"I input the Aat Consultancy url in to google chrome")]
        public void GivenIInputTheAatConsultancyUrlInToGoogleChrome()
        {
            // This is done as part of the Act baseclass
        }

        [Then(@"i am on the Act Consultancy webpage")]
        public void ThenIAmOnTheActConsultancyWebpage()
        {
            string webPageTitle = Act.browserInstance.FindElement(By.CssSelector("header > h1")).Text;
            webPageTitle.Should().BeEquivalentTo("SpecFlow, BDD for the .NET World");
        }
    }
}
