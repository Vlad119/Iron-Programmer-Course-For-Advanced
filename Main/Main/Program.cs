using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            GeometricArea circle = new GeometricArea();
            Console.WriteLine(circle.CalculateArea(3));
            GeometricArea rectangle = new GeometricArea();
            Console.WriteLine(rectangle.CalculateArea(3, 4));
            GeometricArea triangle = new GeometricArea();
            Console.WriteLine(triangle.CalculateArea(3, 4, 5));
        }
    }
}
