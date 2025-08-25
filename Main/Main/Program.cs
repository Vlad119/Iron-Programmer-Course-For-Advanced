using System;

internal class Program
{
    public enum TrafficLight
    {
        Red, Yellow, Green
    }


    static void Main(string[] args)
    {
        Console.WriteLine((int)TrafficLight.Red);
        Console.WriteLine((int)TrafficLight.Yellow);
        Console.WriteLine((int)TrafficLight.Green);
    }
}
