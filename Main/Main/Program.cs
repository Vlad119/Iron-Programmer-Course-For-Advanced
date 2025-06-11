using System;

public class Program
{

    static void Main(string[] args)
    {
        Car("Mercedes-Benz E-Class", "Blue", 2021, "Unknown", true);
    }

    static void Car(string model, string color, int year = 2024, string engineType = "Unknown", bool hasSunroof = false)
    {
        Console.WriteLine($"Model: {model}");
        Console.WriteLine($"Color: {color}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Engine Type: {engineType}");
        Console.WriteLine($"Has Sunroof: {hasSunroof}");

    }
}