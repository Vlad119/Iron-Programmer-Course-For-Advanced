using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 5);
            Point point2 = new Point(5, 5);
            Console.WriteLine(Point.LengthPoints(point1, point2));
        }
    }
}
