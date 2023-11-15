Feature: LoginInvalidUser

As user I should see error message when I'm loged with incorrect credentials

@Login
Scenario: InvalidCredentialsLogin
	Given I should see Login page
	When When I put in invalid credentials (<login> or <password>)
	Then I should see error message
	Examples: 
	| login                        | password |
	| "randomLogin@gmail.com"      | "123456"   |
	| "AliceTestAcc4587@gmail.com" | "12345sdf6"   |
