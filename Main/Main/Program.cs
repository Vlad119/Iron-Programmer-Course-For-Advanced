using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Team realMadrid = new Team();
            realMadrid[0] = new Player("Benzema", 9);
            realMadrid[1] = new Player("Sergio Ramos", 4);
            Console.WriteLine(realMadrid[1].Name);
        }
    }
}
