using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_assessment.controllers;
using final_assessment.Services;

namespace final_assessment.models
{
    public class Movie
    {
        public string Name { get; set; }
        public int YearOfRelease { get; set; }
        public string Plot { get; set; }
        public List<Actor> ActorList { get; set; }
        public Producer ProducerData{ get; set; }
        public Movie()
        {

        }
        public Movie(string name,int year,string plot,List<Actor>actorlist,Producer producer)
        {
            this.Name = name;
            this.YearOfRelease = year;
            this.Plot = plot;
            this.ActorList = actorlist;
            this.ProducerData = producer;
        }
    }
}
