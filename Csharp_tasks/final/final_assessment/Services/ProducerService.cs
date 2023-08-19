using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_assessment.models;
using final_assessment.Repositories;

namespace final_assessment.Services
{
    public class ProducerService : IProducerService
    {
        private readonly IProducerRepository _producerRepository;
       
        public ProducerService()
        {
            _producerRepository = new ProducerRepository();
        }

        public void AddProducer(Producer newproducer)
        {
            _producerRepository.Add(newproducer);
        }

        public void AddProducer_validate(string name,string dob)
        {
            if (string.IsNullOrEmpty(name) || int.TryParse(name, out _))
            {
                throw new ArgumentException("Invalid arguments");
            }
            DateTime newdob;
            newdob = DateTime.Parse(dob);
            if (newdob > DateTime.Now)
                throw new ArgumentOutOfRangeException("Invalid arguments");
            var newproducer = new Producer(name, newdob);
            AddProducer(newproducer);
        }
        public void ListOfProducers()
        {
            List<Producer> producerList = GetProducerList();
            int c = 1;
            foreach (var producer in producerList)
                Console.WriteLine("{0}.{1}({2})", c++, producer.Name,producer.Dob);
        }
        public List<Producer> GetProducerList()
        {
            return _producerRepository.GetProducerList();
        }
    }
}
