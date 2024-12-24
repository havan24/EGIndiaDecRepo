using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProjectEG.StepDefinitions
{
    [Binding]
    public class XYZManagerStepDefinitions
    {
        private ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public XYZManagerStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }

        [Given(@"Manager is on login page")]
        public void GivenManagerIsOnLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"Customer clicks on Bank Manager Login button")]
        public void WhenCustomerClicksOnBankManagerLoginButton()
        {
            IWebElement manLogin = _driver.FindElement(By.XPath("//button[normalize-space()='Bank Manager Login']"));
            manLogin.Click();
            Thread.Sleep(2000);
        }

        [When(@"Clicks on Add Customer Button")]
        public void WhenClicksOnAddCustomerButton()
        {
            IWebElement add = _driver.FindElement(By.XPath("//button[normalize-space()='Add Customer']"));
            add.Click();
            Thread.Sleep(2000);
        }

        [When(@"enters firstname, lastname, postalcode")]
        public void WhenEntersFirstnameLastnamePostalcode(Table table)
        {
            IWebElement fname = _driver.FindElement(By.XPath("//input[@placeholder='First Name']"));
            IWebElement lname = _driver.FindElement(By.XPath("//input[@placeholder='Last Name']"));
            IWebElement post = _driver.FindElement(By.XPath("//input[@placeholder='Post Code']"));

            foreach (var item in table.Rows)
            {
                fname.SendKeys(item["firstname"]);
                Thread.Sleep(2000);
                lname.SendKeys(item["lastname"]);
                Thread.Sleep(2000);
                post.SendKeys(item["postalcode"]);
                Thread.Sleep(2000);
                IWebElement button = _driver.FindElement(By.XPath("//button[@type='submit']"));
                button.Click();
                Thread.Sleep(2000);
                IAlert alert = _driver.SwitchTo().Alert();
                Thread.Sleep(3000);
                alert.Accept();
                Thread.Sleep(2000);
            }
        }

        [When(@"clicks on Add new Customer Button")]
        public void WhenClicksOnAddNewCustomerButton()
        {
            Console.WriteLine("Customer added");
        }

        [Then(@"new Customer is added")]
        public void ThenNewCustomerIsAdded()
        {
            Console.WriteLine("New Customer Added");

        }
    }
}
