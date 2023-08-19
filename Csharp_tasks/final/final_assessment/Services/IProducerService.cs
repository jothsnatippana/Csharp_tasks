using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_assessment.models;

namespace final_assessment.Services
{
    public interface IProducerService
    {
        void AddProducer_validate(string name,string dob);
        List<Producer> GetProducerList();
        void AddProducer(Producer p);
        void ListOfProducers();
    }
}
