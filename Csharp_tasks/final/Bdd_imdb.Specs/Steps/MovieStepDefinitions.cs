using TechTalk.SpecFlow;
using final_assessment.Services;
using final_assessment.models ;
using final_assessment.controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;
using Xunit;
using static Bdd_imdb.Steps.MovieStepDefinitions;
using System.Numerics;
using FluentAssertions;

namespace Bdd_imdb.Steps
{

    [Binding]
    public sealed class MovieStepDefinitions
    {
        readonly MovieService movie = new MovieService();
        public ActorService actor = new ActorService();
        public ProducerService producer = new ProducerService();
        List<MoviesList> movies = new List<MoviesList>();
        string? ex;
        string? name,plot,producerinput,year;
        public string[]? actorinput;
       
      
        [BeforeScenario("addmovie","displaymovie")]
        public void FillinData()
        {
            var fillIn = new FillInData();
            fillIn.FillData_Movie(movie);
            fillIn.FillData_Actor(actor);
            fillIn.FillData_Producer(producer);
        }

       
        [When(@"I call list movies")]
        public void WhenICallListMovies()
        {
            List<Movie> allmovies = movie.GetMovies();
           
            foreach (var eachmovie in allmovies)
            {
                List<string> s = new List<string>();
                foreach (var actor in eachmovie.ActorList)
                    s.Add(actor.Name);
                string actors = String.Join(",", s);
                MoviesList newmovie = new MoviesList
                {
                    Plot = eachmovie.Plot,
                    Name = eachmovie.Name,
                    YearOfRelease = eachmovie.YearOfRelease.ToString(),
                    Producers = eachmovie.ProducerData.Name,
                    ActorData = actors
                };
                movies.Add(newmovie);
            }
        }

        [Then(@"it should display like this")]
        public void ThenItShouldDisplayLikeThis(Table table)
        {
            table.CompareToSet(movies);
        }

        [Given(@"the <Name> is ""([^""]*)""")]
        public void GivenTheNameIs(string wednesday)
        {
            name = wednesday;
        }

        [Given(@"<YearOfRelease> is ""([^""]*)""")]
        public void GivenYearOfReleaseIs(string p0)
        {
            year = p0;
        }

        [Given(@"<Plot> is ""([^""]*)""")]
        public void GivenPlotIs(string p0)
        {
            plot = p0;
        }

        [Given(@"<producerinput> is ""([^""]*)""")]
        public void GivenProducerinputIs(string p0)
        {
            producerinput = p0;
        }

        [Given(@"<actorsinput> are \{""([^""]*)"",""([^""]*)""}")]
        public void GivenActorsinputAre(string p0, string p1)
        {
            actorinput = new string[] { p0, p1 };
        }

        [When(@"i try to add movie to Imdb")]
        public void WhenITryToAddMovieToImdb()
        {
            try
            {
                movie.GetInfo(actor, producer);
                movie.AddMovie_validate(name, year, plot, actorinput, producerinput);
            }
            catch (Exception e)
            {
                ex += e.Message;
            }
        }

        [Then(@"it it should be like")]
        public void ThenItItShouldBeLike(Table table)
        {
      
            List<Movie> allmovies = movie.GetMovies();
            table.CompareToSet(allmovies);
        }

        [Then(@"my ProducerData should look like this")]
        public void ThenMyProducerDataShouldLookLikeThis(Table table)
        {
            table.CompareToSet(producer.GetProducerList());
        }

        [Then(@"my ActorList should look like this")]
        public void ThenMyActorListShouldLookLikeThis(Table table)
        {
            table.CompareToSet(actor.GetActorList());
        }

        [Then(@"it should display an error message like ""([^""]*)""")]
        public void ThenItShouldDisplayAnErrorMessageLike(string p0)
        {
            Assert.Equal(p0, ex);
        }
        public class MoviesList
        {
            public string? Name { get; set; }
            public string? YearOfRelease { get; set; }
            public string? Plot {get; set;}
            public string? Producers { get; set; }
            public string? ActorData { get; set; }
        }
    }
}
