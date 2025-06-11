using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine(); 
            Greet(); // "Привет, Гость!"
            Greet(name); // "Привет, name!"
        }

        static void Greet(string name = "Гость")
        {
            Console.WriteLine($"Привет, {name}!");
        }
    }
}
