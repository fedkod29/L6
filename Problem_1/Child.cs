using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace Problem_1
{
    class Child : Person
    {
        public override int Age
        {
            set
            {
                if (value < 0 || value > 15)
                {
                    throw new Exception("Child's age must be less than 15!");
                }    
                
                age = value;
            }
        }

        public Child(string Name, int Age) : base(Name, Age)
        {
            this.Age = Age;
        }
    }
}
