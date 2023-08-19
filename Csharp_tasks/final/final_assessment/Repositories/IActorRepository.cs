using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_assessment.models;

namespace final_assessment.Repositories
{
    interface IActorRepository
    {
        void Add(Actor a);
        List<Actor> GetActorList();
    }
}
