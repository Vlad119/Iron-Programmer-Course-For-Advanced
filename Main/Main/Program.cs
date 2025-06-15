using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Point p1 = new Point(1, 2);
            Console.WriteLine(p1.Print());
            Point p2 = new Point(4, 6);
            Console.WriteLine(p2.Print());
            Console.WriteLine(p1.CalculateDistance(p2));
            Console.WriteLine(p2.CalculateDistance(p1));
        }
    }
}
