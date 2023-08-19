using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_assessment.models;

namespace final_assessment.Repositories
{
    class ProducerRepository: IProducerRepository
    {
        private readonly List<Producer> _producers;
        public ProducerRepository()
        {
            _producers = new List<Producer>();
        }
        void IProducerRepository.Add(Producer p)
        {
            _producers.Add(p);
        }
        List<Producer> IProducerRepository.GetProducerList()
        {
                return _producers.ToList();
        }
    }
}
