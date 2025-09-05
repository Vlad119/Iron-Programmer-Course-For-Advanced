using System;

internal class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        int b = -4;
        int c = -5;
        var roots = SolveQuadraticEquation(a, b, c);
        Console.WriteLine("{0} {1}", roots.Item1, roots.Item2);
    }

    public static (double min, double max) SolveQuadraticEquation(int a, int b, int c)
    {
        double discriminant = b * b - 4 * a * c;
        double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        return (Math.Min(root1, root2), Math.Max(root1, root2));
    }
}