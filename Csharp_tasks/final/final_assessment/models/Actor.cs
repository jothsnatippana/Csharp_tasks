﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_assessment.controllers;
using final_assessment.Services;

namespace final_assessment.models
{
    public class Actor
    {
        public string Name { get; set; }
        public DateTime Dob { get; set; }
       
        public Actor()
        {

        }
        public Actor(string name,DateTime dob)
        {
            this.Name = name;
            this.Dob = dob;
        }
    }
}
