using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Player player1 = new Player("Sergio Ramos", 4);
            Player player2 = new Player("Sergio Ramos", 4);
            Console.WriteLine(player1.Equals(player2));
        }
    }
}
