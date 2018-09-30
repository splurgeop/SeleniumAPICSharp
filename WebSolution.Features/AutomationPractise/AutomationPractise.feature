Feature: Validation of Messages at Sign in Functionality
  
  @Smoke
   Scenario Outline: Sign in with empty email and empty password
   Given I am on the login page 
    When I clicks on SignIn button
    And I enters username as <username> and password as <password>	
   And I click LogIn button
   Then I should see <errorMessage>
   
   Examples: 
   | username           | password |
   |                    | abcdef   |
   | testuser@gmail.com |          |
   | testuser@gmail.com | abcdef   | 