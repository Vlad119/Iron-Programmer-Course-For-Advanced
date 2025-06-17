using System;

public class Program
{
    public static void Main()
    {
        Driver driverA = new Driver("Иван", "Иванов", 34);
        Driver driverC = new Driver("Пётр", "Петров", 25);
        Car carA = new Car("A123MP", "Красный", driverA);
        Car carB = new Car("B456XC", "Синий", null);
        Car carC = new Car("K789BA", "Белый", driverC);
        CarsDrivers(new Car[] { carA, carB, carC });
    }

    public static void CarsDrivers(Car[] cars)
    {
        foreach (var car in cars)
        {
            if (car.Driver != null)
            {
                Console.WriteLine($"{car.Number}:{car.Driver.LastName}");
            }
            else
            {
                Console.WriteLine($"{car.Number}:Нет водителя");
            }
        }
    }
}
