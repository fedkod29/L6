using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_3
{
    class Human
    {
        protected string firstName;
        protected string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get 
            {
                return this.firstName;
            }
            set
            {
                if (value.Length <= 3)
                {
                    throw new Exception("Expected length at least 4 symbols! Argument: FirstName");
                }

                if (Char.IsLower(value, 0))
                {
                    throw new Exception("Expected upper case letter! Argument: FirstName");
                }

                this.firstName = value;
            }
        }
        public string LastName
        {
            get 
            { 
                return this.lastName;
            }
            set
            {
                if (value.Length <= 2)
                {
                    throw new Exception("Expected length at least 3 symbols! Argument: LastName");
                }    
                
                if (Char.IsLower(value, 0))
                {
                    throw new Exception("Expected upper case letter! Argument: LastName");
                }                  

                this.lastName = value;
            }
        }

        public virtual string AllInf()
        {
            return $"First name: {this.firstName}, Last name: {this.lastName}";
        }
    }
}
