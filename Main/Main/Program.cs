using System;

internal class Program
{
    static void Main(string[] args)
    {
        GoTo(Side.East, 50);
        GoTo(Side.South, 20);
        GoTo(Side.West, 30);
        Console.WriteLine("You found it!");
    }

    static void GoTo(Side side, int distance)
    {
        Console.WriteLine($"Go {side} for {distance} meters");
    }
}