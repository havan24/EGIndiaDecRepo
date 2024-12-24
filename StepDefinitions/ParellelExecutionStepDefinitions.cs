using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

[assembly: Parallelizable(ParallelScope.All)]
namespace SpecFlowProjectEG.StepDefinitions
{
    [Binding]
    public class ParellelExecutionStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public ParellelExecutionStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }

        [Given(@"user is on the application page on IE Browser")]
        public void GivenUserIsOnTheApplicationPageOnIEBrowser()
        {
            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Console.WriteLine("You are on the IE Browser");
        }

        [Given(@"user is on the application page on FF Browser")]
        public void GivenUserIsOnTheApplicationPageOnFFBrowser()
        {
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Console.WriteLine("You are on the FireFox Browser");
        }

        [Given(@"user is on the application page on Edge Browser")]
        public void GivenUserIsOnTheApplicationPageOnEdgeBrowser()
        {
            _driver.Navigate().GoToUrl("https://docs.specflow.org/projects/getting-started/en/latest/GettingStarted/Step9.html");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Console.WriteLine("You are on the Edge Browser");
        }
    }
}
