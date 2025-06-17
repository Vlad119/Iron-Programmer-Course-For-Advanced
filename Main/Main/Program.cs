using System;

public class Program
{
    public static void Main()
    {
        Car carA = new Car("O123MP", "Красный", null);
        Car carB = new Car("M456XC", "Синий", null);
        Car carC = new Car("K789BA", "Белый", null);
        Car[] cars = new Car[] { carA, carB, carC };
        ChangeColor(cars);
        for (int i = 0; i < cars.Length; ++i)
        {
            Console.WriteLine($"{cars[i].Color}");
        }
    }

    public static void ChangeColor(Car[] cars)
    {
        foreach (var car in cars)
        {
            if (car.Number.Length > 0)
            {
                char firstLetter = car.Number[0];
                switch (firstLetter)
                {
                    case 'O':
                        car.Color = "Оранжевый";
                        break;
                    case 'C':
                        car.Color = "Синий";
                        break;
                    case 'K':
                        car.Color = "Красный";
                        break;
                    default:
                        car.Color = "Белый";
                        break;
                }
            }
            else
            {
                car.Color = "Белый";
            }
        }
    }
}
