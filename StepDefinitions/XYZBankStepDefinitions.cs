using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace SpecFlowProjectEG.StepDefinitions
{
    [Binding]
    public class XYZBankStepDefinitions
    {
        private ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public XYZBankStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }

        [Given(@": User in on login page")]
        public void GivenUserInOnLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"Customer click on Customer Login button")]
        public void WhenCustomerClickOnCustomerLoginButton()
        {
            IWebElement CustLogin = _driver.FindElement(By.XPath("//button[normalize-space()='Customer Login']"));
            CustLogin.Click();
            Thread.Sleep(1000);
        }

        [When(@"select the name")]
        public void WhenSelectTheName()
        {
            IWebElement NamesDropDown = _driver.FindElement(By.XPath("//select[@id='userSelect']"));
            NamesDropDown.Click();
            var select = new SelectElement(NamesDropDown);
            Thread.Sleep(2000);
            select.SelectByText("Harry Potter");
            Thread.Sleep(2000);
        }

        [When(@"User Click on login button")]
        public void WhenUserClickOnLoginButton()
        {
            IWebElement NamesDropDown = _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
            NamesDropDown.Click();
            Thread.Sleep(2000);
        }

        [Then(@"User is logged in and can the see data")]
        public void ThenUserIsLoggedInAndCanTheSeeData()
        {
            Console.WriteLine("Customer Logged In");
        }
    }
}
