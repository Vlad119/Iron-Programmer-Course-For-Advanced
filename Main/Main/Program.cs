using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int random = rnd.Next(1,7);
                Console.WriteLine(random);
            }
        }
    }
}
