using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_2
{
    class GoldenEditonBook : Book
    {
        public GoldenEditonBook(string title, string author, double price) : base(title, author, price)
        {
        }
        public override double Price
        {
            get
            {
                return base.Price * 1.3;
            }
        }
    }
}
