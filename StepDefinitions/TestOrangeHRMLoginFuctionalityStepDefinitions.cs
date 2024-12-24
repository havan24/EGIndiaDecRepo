using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProjectEG.StepDefinitions
{
    [Binding]
    public class TestOrangeHRMLoginFuctionalityStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        private IWebDriver _driver;

        public TestOrangeHRMLoginFuctionalityStepDefinitions(ScenarioContext scenarioContext)

        {

            _scenarioContext = scenarioContext;

            _driver = _scenarioContext["WebDriver"] as IWebDriver;



        }

        [Given(@"User is on the login page")]

        public void GivenUserIsOnTheLoginPage()

        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            _driver = new FirefoxDriver();

            _driver.Manage().Window.Maximize();

            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            Thread.Sleep(6000);

        }

        [When(@"User enters the correct credentials")]

        public void WhenUserEntersTheCorrectCredentials()

        {

            IWebElement UserName = _driver.FindElement(By.XPath("//input[@placeholder='Username']"));

            UserName.SendKeys("Admin");

            Thread.Sleep(3000);

            IWebElement Password = _driver.FindElement(By.XPath("//input[@placeholder='Password']"));

            Password.SendKeys("admin123");

            Thread.Sleep(3000);

        }

        [When(@"User clicks on Login button")]

        public void WhenUserClicksOnLoginButton()

        {

            IWebElement Login = _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));

            Login.Click();

            Thread.Sleep(3000);

        }

        [Then(@"User is navigated to homepage")]

        public void ThenUserIsNavigatedToHomepage()

        {

            Console.WriteLine("Entered to home page");

        }
    }
}
