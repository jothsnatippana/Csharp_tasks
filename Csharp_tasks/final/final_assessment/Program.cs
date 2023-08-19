using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_assessment.Repositories;
using final_assessment.models;
using final_assessment.Services;
using final_assessment.controllers;

namespace final_assessment
{
    class Program
    {
        
        static void Main(string[] args)
        {
           MovieService movie = new MovieService();
           ActorService actor = new ActorService();
           ProducerService producer = new ProducerService();
            var display = new Display();
            var fillIn = new FillInData();
            fillIn.FillData_Movie(movie);
            fillIn.FillData_Actor(actor);
            fillIn.FillData_Producer(producer);
            Console.WriteLine("1.list all movies\n2.add a movie\n3.add a actor\n4.add a producer\n5.delete a movie\n6.show list of actors\n7.show list of producers\n8.exit");
            while (true)
            {
                Console.WriteLine("what do you want");
                var n=Console.ReadLine();
                int input;
                try
                {
                    input = int.Parse(n);
                    if (input <= 0 || input >= 9)
                    {
                        Console.WriteLine("choose one from the above options..........");
                        continue;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                switch (input)
                {
                    case 1:
                        display.DisplayAllMovies(movie);
                        break;
                    case 2:
                        movie.GetInfo(actor,producer);
                        Console.WriteLine("enter the movie name");
                        string name;
                        name = Console.ReadLine();
                        Console.WriteLine("enter the year of release e.g:yyyy");
                        String year;
                        year = Console.ReadLine();
                        Console.WriteLine("enter the plot of movie");
                        string plot;
                        plot = Console.ReadLine();
                        Console.WriteLine("Choose the actors");
                        actor.ListOfActors();
                        var actorInput = Console.ReadLine().Split(' ');
                           
                        Console.WriteLine("Choose the producers");
                        producer.ListOfProducers();
                        var producerInput = Console.ReadLine();

                        try
                        {
                            movie.AddMovie_validate(name,year,plot,actorInput,producerInput);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                            continue;
                        }
                        break;

                    case 3:
                        Console.WriteLine("enter the name of the actor :");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter a date of birth(e.g. dd/mm/yyyy):");
                       
                        var sample_dob = Console.ReadLine();
                        try
                        {
                            actor.Addactor_validate(name, sample_dob);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            continue;
                        }
                        break;
                    case 4:
                        Console.WriteLine("enter the name of the producer:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter a date of birth(e.g. dd/mm/yyyy) of prodcuer:");
                        sample_dob = Console.ReadLine();
                        try
                        {
                            producer.AddProducer_validate(name,sample_dob);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            continue;
                        }
                      
                        break;
                    case 5:
                        Console.WriteLine("choose the movies to be deleted:");
                        movie.DisplayMovies();
                        var movieId = Console.ReadLine();
                        try
                        {
                            movie.DelMovie(movieId);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            continue;
                        }
                        break;
                    case 6:
                         Console.WriteLine("actors list:");
                         actor.ListOfActors();
                         break;
                    case 7: 
                        Console.WriteLine("producers list:");
                         producer.ListOfProducers();
                        break;
                    case 8:
                        break;
                }
                if (input == 8)
                    break;
            }
        }
    }
}
