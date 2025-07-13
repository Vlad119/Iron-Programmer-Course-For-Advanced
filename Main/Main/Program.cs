using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 1);
            Console.WriteLine(Point.Counter);

            Point point2 = new Point(2, 3);
            Console.WriteLine(Point.Counter);
        }
    }
}
