using System;

internal class Program
{
    static void Main(string[] args)
    {
        var ford = new Car("Ford", 120);
        var tesla = new ElectricCar("Tesla", 150, 500);

        Console.WriteLine(ford);
        Console.WriteLine(tesla);
    }

    public record Car(string Brand, int Speed);

    public record ElectricCar(string Brand, int Speed, int BatteryRange) : Car(Brand, Speed);
}