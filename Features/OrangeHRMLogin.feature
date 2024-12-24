@sprint1
Feature: Test OrangeHRM Login fuctionality

A short summary of the feature

@Sanity
Scenario: Verify login with valid credentials
	Given User is on the login page
	When User enters the username and Password
	And User clicks on login Button
	Then Usre is navigated to hoem page
