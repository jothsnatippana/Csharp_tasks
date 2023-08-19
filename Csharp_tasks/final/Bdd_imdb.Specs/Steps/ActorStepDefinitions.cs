using TechTalk.SpecFlow;
using final_assessment.Services;
using final_assessment.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;
using Xunit;

namespace Bdd_imdb.Steps
{
    [Binding]
    public sealed class ActorStepDefinitions
    {
        string ex="";
        string? name, dob;
        readonly MovieStepDefinitions movieref = new MovieStepDefinitions();
      


        [Given(@"name of the actor is ""([^""]*)""")]
        public void GivenNameOfTheActorIs(string anuskha)
        {
            name = anuskha;
        }

        [Given(@"date of birth is ""(.*)""")]
        public void GivenDateOfBirthIs(string p0)
        {
            dob = p0;
        }

        [When(@"i try to add the actor")]
        public void WhenITryToAddTheActor()
        {
            try
            {
                movieref.actor.Addactor_validate(name,dob);
            }
            catch(Exception e)
            {
                ex += e.Message;
            }
        }

        [Then(@"it should display like:")]
        public void ThenItShouldDisplayLike(Table table)
        {
            table.CompareToSet(movieref.actor.GetActorList());
        }

        [Then(@"it should dispaly an error like ""([^""]*)""")]
        public void ThenItShouldDispalyAnErrorLike(string p0)
        {
               Assert.Equal(p0,ex);
        }
    }
}
