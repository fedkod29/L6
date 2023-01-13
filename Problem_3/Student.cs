using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Problem_3
{
    class Student : Human
    {
        private string facultyNumber;
        public Student(string fisrtName, string lastName, string facultyNumber) : base(fisrtName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get 
            {
                return this.facultyNumber;
            }
            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new Exception("Invalid faculty number!");
                } 

                foreach (char letter in value)
                {   
                   if(Char.IsLetter(letter))
                   { 
                        throw new Exception("Invalid faculty number!");
                   }

                this.facultyNumber = value;
                }
            }
        }

        public override string AllInf()
        {
            return $"{base.AllInf()} \n Faculty number: {this.facultyNumber}";
        }
    }
}
