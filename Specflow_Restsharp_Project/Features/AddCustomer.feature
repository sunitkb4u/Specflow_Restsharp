Feature: AddCustomer

Add customer using admin portal

@tag1
Scenario: Add customer
	Given User is on admin portal login page
	When User enters credential <username> and <password>
	And user clicks on Login button
	Then User navigates to Customer Managment page
	When User clicks on Add Customer Button
	Then User should be on Add Customer page
	When User enters Customer details <firstName> <lastName> <email> <mobile> <country> and <address>
	And user enter details for settings <balance>
	When User clicks Update Settings button
	Then Customer should get added

	Examples: 
	| userName  | password      | firstName | lastName | email             | mobile    | country | address | balance |
	| validUser | validPassword | Kanishk   | Kamble   | kanishk@gmail.com | 123123123 | India   | Mumbai  | 6000    |
