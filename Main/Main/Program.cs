using System;

internal class Program
{
    static void Main(string[] args)
    {
        Point point1 = new Point(1, 2);
        Point point2 = new Point(4, 2);
        Point point3 = new Point(15, 5);
        Console.WriteLine(point1.Equals(point2));
        Console.WriteLine(point1.Equals(point3));
    }
}
