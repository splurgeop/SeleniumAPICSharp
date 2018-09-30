Feature: As a User,I want to Register to Site

Scenario Outline: Register a new User with Valid UserName and email
When I register a new User with '<usernameState>' Username and '<passwordState>' Password
Then registration is sucessfull 
And token is generated

Examples:
| usernameState | passwordState |
| Valid         | Valid         |

Scenario Outline:Register a New User with Invalid combinations
When I register a new User with '<usernameState>' Username and '<passwordState>' Password
Then registration is not sucessfull 


Examples:
| usernameState | passwordState |
| Invalid       | Invalid       |
| Invalid       | Valid         |
| Valid         | Invalid       |
 