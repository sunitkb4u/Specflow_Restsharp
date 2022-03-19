Feature: AddOrUpdateUser

User management using Post or Put user

@Users
Scenario Outline: Validates create user API
Given User entrs job <job>
And  User enters role <role>
When User send create user request
Then  user should get created
Examples: 
| job    | role     |
| Tester | API Test | 

@Users
Scenario Outline: Validates update user API
Given User entrs job <job>
And  User enters role <role>
Given user want to update user id <id>
When User send update user request
Then  user should get updated
Examples: 
| job    | role     | id |
| Tester | API Test | 2  |
