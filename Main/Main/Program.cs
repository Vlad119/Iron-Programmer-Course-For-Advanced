using System;

internal class Program
{
    public static void Main()
    {
        GeometricPerimeter p = new GeometricPerimeter();
        Console.WriteLine(p.CalculatePerimeter(2));
        Console.WriteLine(p.CalculatePerimeter(3, 4));
        Console.WriteLine(p.CalculatePerimeter(7, 3, 6));
    }
}

