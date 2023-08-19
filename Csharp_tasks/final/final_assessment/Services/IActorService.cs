using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_assessment.models;

namespace final_assessment.Services
{
    public interface IActorService
    {
        void Addactor_validate(String name, String dob);
        void AddActor(Actor a);
        List<Actor> GetActorList();
        void ListOfActors();
    }
}
