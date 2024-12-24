@sprint2
Feature: RahulShetty


A short summary of the feature
@Regression
Scenario: Verify login for RahulShetty website

	Given User is on the RahulShetty login page

	When User enters the "<username>" and "<email>" and "<password>" in the text fields

	And user slects "<gender>", and "<dob>" fields


 
Examples: 

| username | email               | password | gender | dob        |

| Ravi     | ravigupta@gmail.com | ravi234  | Male   | 1998-02-13 |
| sam      | samy@gmail.com      | sam123   | Female | 2001-03-29 |