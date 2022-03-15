Feature: AddCustomer

Add customer using admin portal

@tag1
Scenario: Add customer
	Given User is on admin portal login page
	When User Enters credential <username> and <password>
	And User Clicks on Login button
	Then User navigates to Customer Managment page
	When User clicks on Add Customer Button
	Then User should be on Add Customer page
	When User enters Customer details <firstName> <lastName> <email> <mobile> <country> and <address>
	And user enter details for settings <balance>
	When User clicks Update Settings button
	Then Customer should get added

	Examples: 
	| userName  | password      | firstName | lastName | email | mobile | country | address | balance |
	| validUser | validPassword |
