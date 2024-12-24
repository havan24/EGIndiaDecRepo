@sprint1
Feature: DummyData

A short summary of the feature
@Regression
Scenario Outline: Verify login with test parameters
When User enters the "<username>" and "<password>"
And User clicks on login button
Then user is navigated to home page
Then user selects city and country information
| city   | country |
| Delhi  | India   |
| Boston | USA     |

Examples: 
| username | password |
| tom      | harry    |
