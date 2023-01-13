using System;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Nazariy", 18);
            Console.WriteLine(person.AllInf());

            Child child = new Child("Adolf", 12);
            Console.WriteLine(child.AllInf());
        }
    }
}
