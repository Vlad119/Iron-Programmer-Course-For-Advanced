using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine(new Summator().Sum(5));
            Console.WriteLine(new PowerSummator(1).Sum(5));
            Console.WriteLine(new SquareSummator().Sum(5));
            Console.WriteLine(new PowerSummator(2).Sum(5));
            Console.WriteLine(new CubeSummator().Sum(5));
            Console.WriteLine(new PowerSummator(3).Sum(5));
        }
    }
}
