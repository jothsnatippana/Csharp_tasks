 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_assessment.models;
using final_assessment.Repositories;


namespace final_assessment.Services
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;
        public ActorService()
        {
            _actorRepository = new ActorRepository();
        }
        public void AddActor(Actor newactor)
        {
            _actorRepository.Add(newactor);
        }
         public void Addactor_validate(string name,string dob)
        {
            if (string.IsNullOrEmpty(name) || int.TryParse(name, out _))
            {
                throw new ArgumentException("Invalid Arguments");
            }
            if (string.IsNullOrEmpty(dob))
            {
                throw new ArgumentException("Invalid Arguments");
            }
            DateTime newdob;
            newdob = DateTime.Parse(dob);
            if (newdob > DateTime.Now)
                throw new ArgumentOutOfRangeException("Invalid Arguments");
            var newactor = new Actor(name, newdob);
            AddActor(newactor);
        }
        public void ListOfActors()
        {
            List<Actor> actorList = GetActorList();
            int c = 1;
            foreach (var actor in actorList)
                Console.WriteLine("{0}.{1}", c++, actor.Name);
        }
        public List<Actor> GetActorList()
        {
            return _actorRepository.GetActorList();
        }
    }
}
