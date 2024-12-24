@XYZBank
Feature: XYZManager


Scenario: Bank Manager Login
	Given Manager is on login page
	When Customer clicks on Bank Manager Login button
	And Clicks on Add Customer Button
	And enters firstname, lastname, postalcode
	| firstname | lastname | postalcode |
	| Ravi      | Gupta    | 12345      |
	| Sam       | Brick    | 56789      |
	And clicks on Add new Customer Button
	Then new Customer is added
