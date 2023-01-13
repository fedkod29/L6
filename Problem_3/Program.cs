using System;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Adolf", "Hitler");
            Console.WriteLine(human.AllInf());

            Console.Write("\n");

            Student student = new Student("Nazariy", "Machek", "14428");
            Console.WriteLine(student.AllInf());

            Console.Write("\n");

            Worker worker = new Worker("Stepan", "Bandera", 5000, 11);
            Console.WriteLine(worker.AllInf());
        }
    }
}
