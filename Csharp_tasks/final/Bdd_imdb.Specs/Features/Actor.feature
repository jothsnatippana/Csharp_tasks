Feature: Actor
  Inorder to get the list of movies from the app
  as an user of the app
  i want to add the list of actors 
  
@addactor
Scenario: Adding an actor
    Given name of the actor is "Anuskha"
    And date of birth is "12/3/2022"
    When i try to add the actor
    Then it should display like:
    | Name    | Dob                   |
    | Anuskha | 12/3/2022 12:00:00 AM |
  
          
 Scenario Outline: Adding an actor with invalid data.
    Given name of the actor is "" 
    And date of birth is "12/03/2002"
    When  i try to add the actor
    Then it should dispaly an error like "Invalid Arguments"
    Examples:
            | Name    | Dob                    |
            | anuskha |                        |
            |         | 23-12-2002 12:00:00 AM |
            