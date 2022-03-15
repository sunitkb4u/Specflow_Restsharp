Feature: LoginAdminPortal

Login to admin portal should happen using valid credential only

@Smoke
Scenario Outline: Login Using valid Credential
	Given User is on admin portal login page
	When User enters credential <username> and <password>
	And user clicks on Login button
	Then User should be logged in successfully
	Examples: 
		| username  | password       |
		| valid_User | valid_Password |

@Admin
Scenario Outline: Login Using Invalid Credential
	Given User is on admin portal login page
	When User enters credential <username> and <password>
	And user clicks on Login button
	Then User should get <error>
	Examples: 
		| username     | password         | error                         |
		| invalid_user | invalid_password | Please enter valid credential |
		| valid_User   | invalid_password | Please enter password         |