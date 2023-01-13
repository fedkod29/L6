using System;
using System.Collections.Generic;
using System.Text;

     public class Person
     {
        protected string name;
        protected int age;
        public string Name
        {
            get 
            {
                return name;
            }
            set
            {
                if(value == null || value == " " || value.Length < 3)
                {
                    throw new Exception("Name's length should not be less than 3 symbols!");
                }    
                
                name = value;
            }
        }
        public virtual int Age
        {
            get 
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Age must be positive!");
                }    

                age = value;
            }
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string AllInf()
        {
            return $"Name: {Name}, age: {Age}";
        }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format($"Name: {Name}, Age: {Age}"));

            return stringBuilder.ToString();
        }
    }
