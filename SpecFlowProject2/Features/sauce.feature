Feature: sauce
	Simple calculator for adding two numbers

	@wip
Scenario: go to sauce labs
	Given user is on the sauce labs page
	When user enters username and password
	Then user should be able to login
	