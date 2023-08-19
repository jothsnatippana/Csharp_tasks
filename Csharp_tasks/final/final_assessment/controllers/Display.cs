using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_assessment.Repositories;
using final_assessment.models;
using final_assessment.Services;

namespace final_assessment.controllers
{
    public class Display
    {
        public void DisplayAllMovies(MovieService movies)
        {
            List<Movie> movieList = movies.GetMovies();
            foreach (var movie in movieList)
            {
                Console.WriteLine("{0}({1})", movie.Name, movie.YearOfRelease);

                Console.WriteLine("Plot - " + movie.Plot);

                List<string> s = new List<string>();
                foreach (var actor in movie.ActorList)
                    s.Add(actor.Name);
                Console.WriteLine("Actors-" + String.Join(",", s));

                Console.WriteLine("Producers-" + movie.ProducerData.Name);
                Console.WriteLine("----------------------------------");
                
            }
        } 

       
        
    }
}
