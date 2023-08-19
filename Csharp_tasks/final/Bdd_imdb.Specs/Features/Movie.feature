Feature: Movie
  Inorder to get the list of movies from the app
  as an user of the app
  i want to get the list of movies and able to add movies to it.

@displaymovie
Scenario: Display the list of movies
	When I call list movies
	Then it should display like this
         | Name     | YearOfRelease | Plot         | Producers | ActorData       |
         | RRR      | 2022          | RRRplot      | shobu     | ramcharan,NTR   |
         | Bahubali | 2019          | Bahubaliplot | vamsi     | Anushka,prabhas |

                                     
@addmovie                                 
Scenario: Adding movies to the list
    Given the <Name> is "wednesday" 
    And <YearOfRelease> is "2022" 
    And <Plot> is "Wednesday_plot"
    And <producerinput> is "1"
    And <actorsinput> are {"1","2"}
    When i try to add movie to Imdb
    Then it it should be like
    | Name      | YearOfRelease | Plot           |
    | wednesday | 2022          | Wednesday_plot |
    | RRR       | 2022          | RRRplot        |
    | Bahubali  | 2019          | Bahubaliplot   |
    And my ProducerData should look like this
    | Name  | Dob                 |
    | shobu | 9/1/1998 12:00:00 AM |
    | vamsi | 5/23/1988 12:00:00 AM |
    And my ActorList should look like this
    | Name      | Dob                   |
    | Anushka   | 12/2/2001 12:00:00 AM |
    | prabhas   | 8/4/2000 12:00:00 AM  |
    | ramcharan | 9/7/1999 12:00:00 AM  |
    | NTR       | 6/21/1993 12:00:00 AM |

   
     

                             
   Scenario Outline: Adding a movie with invalid data.
    When i try to add movie to Imdb
    Then it should display an error message like "Invalid input arguments"
    Examples:
             | Name      | YearOfRelease | Plot           | Producers | Actors |
             | wednesday | 2022          | Wednesday_plot | 1         |        |
             | wednesday | 2022          | Wednesday_plot |           | {1,2}  |
             | wednesday | 2022          |                | 1         | {1,2}  |
             | wednesday |               | Wednesday_plot | 1         | {1,2}  |
             |           | 2022          | Wednesday_plot | 1         | {1,2}  |
           
 
        