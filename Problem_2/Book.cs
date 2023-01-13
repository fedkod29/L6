using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_2
{
    class Book
    {
        protected string title;
        protected string author;
        protected double price;
        public Book(string title, string author, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }
        public string Title
        {
            get
            { 
                return this.title;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new Exception("Title not valid!");
                }

                this.title = value;
            }
        }

        public string Author
        {
            get
            { 
                return this.author;
            }
            set
            {
                foreach(char letter in value)
                {     
                    if (Char.IsNumber(letter))
                    {
                        throw new Exception("Author not valid!");
                    }
                }                    
                this.author = value;
            }
        }

        public virtual double Price
        {
            get 
            { 
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price not valid!");
                }

                this.price = Math.Round(value, 2);
            }
        }

        public string AllInf()
        {
            return $"Title: {this.Title}, Author: {this.Author}, Price: {this.Price}$.";
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
