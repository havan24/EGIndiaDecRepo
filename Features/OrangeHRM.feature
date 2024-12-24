@sprint2
Feature: OrangeHRM
 

Test orange hrm website login functionality
 
@Sanity
Scenario: Verify login for orange hrm website

	Given User is on the orange hrm login page

	When User enters the "<usrname>" and "<passwd>" in the text fields

	When User clicks on submit button

	Then User is navigated to home page
 
Examples: 

| usrname | passwd   |

| Admin   | admin123 |


 
 Scenario: Verify login for orange hrm website with invalid credentials

	Given User is on the orange hrm login page

	When User enters the "<usrname>" and "<passwd>" in the text fields

	When User clicks on submit button

	Then User is on the home page and a error is displayed
 
Examples: 

| usrname | passwd   |

| ravi   | ravi123 |


Scenario: Verify if the forgot password functionality to Reset Password
Given user forgot login credentials
When user clicks on the forgot password hyperlink text
And user will redirected to reset password page
And user enters the username
Then clicks reset password and confirmation  password reset link is sent to mail

Examples: 

| usrname |

| ravi   | 

