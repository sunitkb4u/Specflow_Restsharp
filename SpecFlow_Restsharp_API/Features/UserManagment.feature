Feature: UserManagment

User management using Get, Post,Put, Delete user

@Users
Scenario: Validate get User Api
	Given User enters user id <id>
	When User send get user request
	Then User validates details <firstName> <lastName> and http response code <httpCode>

Examples: 
| id  | firstName | lastName | httpCode |
| 1 | Janet     | Weaver   | 200      |
| 2 | Janet     | Weaver   | 200      |


@Users
Scenario Outline: Validates delete user API
Given User enters job user id <id>
When User send delete user request
Then  Validate user should get deleted <httpCode>
Examples: 
| hrrpCode | id |
| 204 Test | 2  |