using System;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Solo Leveling", "Chugong", 310.00);
            Console.WriteLine(book.AllInf());
            GoldenEditonBook goldenEditonBook = new GoldenEditonBook("Solo Leveling", "Chugong", 310.00);
            Console.WriteLine(goldenEditonBook.AllInf());
        }
    }
}
