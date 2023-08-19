using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_assessment.models;
using final_assessment.Repositories;

namespace final_assessment.Repositories
{
    public class ActorRepository : IActorRepository
    {
        private readonly List<Actor> _actors;
        public ActorRepository()
        {
            _actors = new List<Actor>();
        }
        public void Add(Actor a)
        {
            _actors.Add(a);
        }
        public List<Actor> GetActorList()
        {
            return _actors.ToList();
        }
    }
}
