using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_assessment.controllers;

namespace final_assessment.models
{
    public class Producer
    {
        public string Name { get; set; }
        public DateTime Dob { get; set; }
      
        public Producer(string name,DateTime dob)
        {
            this.Name = name;
            this.Dob = dob;
        }
        public Producer()
        {

        }
    }
}
