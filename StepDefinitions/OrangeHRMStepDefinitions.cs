using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectEG.StepDefinitions
{
    [Binding]
    public class OrangeHRMStepDefinitions
    {

        [When(@"User enters the ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersTheAnd(string username, string password)
        {
            Console.WriteLine("The usename is : "+ username + "  ..........  The Password is : "+ password);
        }

        [When(@"User clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {
            Console.WriteLine("User clicked on login button");
        }

        [Then(@"user is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            Console.WriteLine("User is on the home page");
        }

        [Then(@"user selects city and country information")]
        public void ThenUserSelectsCityAndCountryInformation(Table table)
        {
            foreach(var item in table.Rows)
            {
                string city = item["city"];
                string country = item["country"];
                Console.WriteLine(city + " , " + country);
            }
        }
    }
}
