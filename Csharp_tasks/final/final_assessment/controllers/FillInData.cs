using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_assessment.models;
using final_assessment.Repositories;
using final_assessment.Services;

namespace final_assessment.controllers
{
    public class FillInData
    {
        
        Actor actor1 = new Actor("Anushka", new DateTime(2001, 12, 2));
        Actor actor2 = new Actor("prabhas",new  DateTime(2000, 08, 4));
        Actor actor3 = new Actor("ramcharan", new DateTime(1999, 9, 7));
        Actor actor4 = new Actor("NTR", new DateTime(1993, 6, 21));
        Producer producer1 = new Producer("shobu", new DateTime(1998, 9, 1));
        Producer producer2 = new Producer("vamsi", new DateTime(1988, 5, 23));
        public void FillData_Actor(ActorService newactor)
        {
            newactor.AddActor(actor1);
            newactor.AddActor(actor2);
            newactor.AddActor(actor3);
            newactor.AddActor(actor4);
        }
        public void FillData_Producer(ProducerService newproducer)
        {
            newproducer.AddProducer(producer1);
            newproducer.AddProducer(producer2);
        }
        public void FillData_Movie(MovieService newmovie)
        {
            var movie1 = new Movie("RRR", 2022, "RRRplot",new List<Actor> { actor3, actor4 }, producer1);
            var movie2 = new Movie("Bahubali", 2019, "Bahubaliplot", new List<Actor> { actor1, actor2 }, producer2);
            newmovie.AddMovie(movie1);
            newmovie.AddMovie(movie2);
        }
        
    }
}
