using System;
using System.Threading;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Warrior warrior = new Warrior("Вода", 4);
            Console.WriteLine($"Мой воин - {warrior}");
            Console.WriteLine($"Противник - {!warrior}");
        }
    }
}
