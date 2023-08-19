using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_assessment.models;

namespace final_assessment.Services
{
    public interface IMovieService
    { 
      
        void AddMovie_validate(String name,String year,string plot,String[] selectactor,String produceractor);
        void AddMovie(Movie m);
        void DelMovie(String name);
        List<Movie> GetMovies();
        void DisplayMovies();
    }
}
