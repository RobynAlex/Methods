using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string faveColor = Console.ReadLine();

            Console.WriteLine("What about your favorite animal?");
            string faveAnimal = Console.ReadLine();

            Console.WriteLine("Who is your favorite band?");
            string faveBand = Console.ReadLine();

            Console.WriteLine($"One time {name} went to a record store called {faveColor} {faveAnimal} and bought his first {faveBand} record.");
        }
    }
}
