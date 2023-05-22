Feature: User Registration and Login

    Background:
        Given I am on the home page
@wip
    Scenario: Register a new user
        Given I am on the registration page
        When I fill in the registration form with valid information
        And I submit the registration form
        Then I should be redirected to the login page
        And I should see a success message