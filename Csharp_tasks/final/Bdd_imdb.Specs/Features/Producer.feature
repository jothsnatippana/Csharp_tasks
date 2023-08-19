Feature: Producer
  Inorder to get the list of movies from the app
  as an user of the app
  i want to add the producers 
  

@addproducer
Scenario: Adding a producer
    Given the producer name  is "vamsi" 
    And date of birth of producer is "8/27/1988"
    When i try to add a producer
    Then the information should display like:
    | Name  | Dob                   |
    | vamsi | 8/27/1988 12:00:00AM |
                                 
 Scenario Outline: Adding a producer with invalid data.
    Given the producer name  is "" 
    And date of birth of producer is "27/08/1988"
    When  i try to add a producer
    Then it should dispaly an error like this:"Invalid arguments"
    Examples:
            | Name  | Dob                   |
            | vamsi |                       |
            |       | 27/08/1988 12:00:00AM |
            