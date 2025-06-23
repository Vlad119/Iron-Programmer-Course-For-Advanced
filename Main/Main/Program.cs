using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine(triangle.Perimeter());
            EquilateralTriangle triangle2 = new EquilateralTriangle(3);
            Console.WriteLine(triangle2.Perimeter());
        }
    }
}
