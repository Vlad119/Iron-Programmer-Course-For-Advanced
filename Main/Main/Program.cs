using System;

public class Program
{
    public static void Main()
    {
        Driver driverA = new Driver("Иван", "Иванов", 34);
        Driver driverB = new Driver("Алексей", "Алексеев", 30);
        Car carA = new Car("A123KC", "Красный", driverA);
        Car carB = new Car("В321EM", "Белый", driverB);
        Console.WriteLine($"Автомобиль A: {carA.Number} {carA.Color} {carA.Driver.LastName}");
        carA.Color = carB.Color;
        carA.Number = carB.Number;
        carA.Driver = carB.Driver;
        Console.WriteLine($"Автомобиль A: {carA.Number} {carA.Color} {carA.Driver.LastName}");
    }
}
