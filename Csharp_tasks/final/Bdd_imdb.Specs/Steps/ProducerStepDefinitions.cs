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
    public sealed class ProducerStepDefinitions
    {
        string name="",dob="";
        readonly MovieStepDefinitions movieref = new MovieStepDefinitions();
        List<Producer> producers= new List<Producer>(); 
        string ex= "";
        [Given(@"the producer name  is ""(.*)""")]
        public void GivenTheProducerNameIs(string p0)
        {
            name += p0;
        }

        [Given(@"date of birth of producer is ""(.*)""")]
        public void GivenDateOfBirthOfProducerIs(string p0)
        {
            dob += p0;
        }

        [When(@"i try to add a producer")]
        public void WhenITryToAddAProducer()
        {
            try
            {
                movieref.producer.AddProducer_validate(name,dob);
            }
            catch (Exception e)
            {
                ex += e.Message;
            }
        }

        [Then(@"the information should display like:")]
        public void ThenTheInformationShouldDisplayLike(Table table)
        {
            producers = movieref.producer.GetProducerList();
            table.CompareToSet(producers);
        }

        
        [Then(@"it should dispaly an error like this:""([^""]*)""")]
        public void ThenItShouldDispalyAnErrorLikeThis(string p0)
        {
            Assert.Equal(p0, ex);
        }


    }
}
