@XYZBank
Feature: XYZBank

Background: 
	Given : User in on login page
@customer
Scenario: Customer Login
	When Customer click on Customer Login button
	And select the name
	And User Click on login button
	Then User is logged in and can the see data