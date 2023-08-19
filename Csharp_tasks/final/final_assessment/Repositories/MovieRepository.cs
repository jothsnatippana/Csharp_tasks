using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_assessment.models;

namespace final_assessment.Repositories
{
    class MovieRepository : IMovieRepository
    {
        private readonly List<Movie> _movies;
      
        public MovieRepository()
        {
            _movies = new List<Movie>();
        }
      
        public void Add(Movie a)
        {
            _movies.Add(a);
        }
        public List<Movie> GetMovieList()
        {
            return _movies.ToList();
        }
        public void DelMovie(int movieId)
        {
                _movies.RemoveAt(movieId);
        }
    }
}
