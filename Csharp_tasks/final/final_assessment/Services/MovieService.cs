using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_assessment.models;
using final_assessment.Repositories;
using final_assessment.controllers;

namespace final_assessment.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        List<Actor> actorList=new List<Actor>();
        List<Producer> producerList=new List<Producer>();
        public MovieService()
        {
            _movieRepository = new MovieRepository();
        }
        public void AddMovie(Movie newmovie)
        {
            _movieRepository.Add(newmovie);
        }
        public void AddMovie_validate(String name, String year, string plot, string[] actorInput, string producerInput)
        {
            int year1;
            if (string.IsNullOrEmpty(name) || int.TryParse(name, out _))
                throw new ArgumentException("Invalid input arguments");
            if (string.IsNullOrEmpty(year))
                throw new ArgumentException("Invalid input arguments");
            if (year.Length != 4)
                throw new ArgumentException("Invalid input arguments");
            year1 = int.Parse(year);
            if (year1 > DateTime.Now.Year)
                throw new ArgumentException("Invalid input arguments");
            if (string.IsNullOrEmpty(plot) || int.TryParse(plot, out _))
                throw new Exception("Invalid input arguments");
            Console.WriteLine(actorList.Count);
            int selectactor;
            List<Actor> newActorList = new List<Actor>();
            foreach (var newactor in actorInput)
            {
                if(int.TryParse(newactor, out _))
                {
                    selectactor = int.Parse(newactor);
                    if (selectactor > 0 && selectactor <= actorList.Count)
                        newActorList.Add(actorList[selectactor - 1]);
                    else
                        throw new Exception("Invalid input arguments");
                }
                else
                    throw new Exception("Invalid input arguments");
            }
           
            int selectProducer;
            Producer newproducer;
            selectProducer = int.Parse(producerInput);
            if (selectProducer > 0 && selectProducer <= producerList.Count)
                newproducer = producerList[selectProducer - 1];
            else
                throw new ArgumentException("Invalid input arguments");
            Movie newmovie = new Movie(name,year1,plot,newActorList,newproducer);
            AddMovie(newmovie);
        }
      
        public void DelMovie(string movieInput)
        {
            var movieList = GetMovies();
            int selectMovie = int.Parse(movieInput);
            if (selectMovie > 0 && selectMovie <= movieList.Count)
                _movieRepository.DelMovie(selectMovie-1);
            else
                throw new ArgumentException("Invalid input arguments");
        }
        
        public void GetInfo(ActorService a,ProducerService p)
        {
            actorList = a.GetActorList();
            producerList = p.GetProducerList();
        }
         
        
        public List<Movie> GetMovies()
        {
            return _movieRepository.GetMovieList();
        }
        public void DisplayMovies()
        {
            List<Movie> movieList =GetMovies();
            int c = 1;
            foreach (var movie in movieList)
            {
                Console.WriteLine("{0}.{1}", c++, movie.Name);
            }
        }
    }
}
