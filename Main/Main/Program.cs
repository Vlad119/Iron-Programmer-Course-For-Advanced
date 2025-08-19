using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        List<Car> myCars = new List<Car>
    {
       new Car { Model = "Lada", Price = 250000 },
       new Car { Model = "Mercedes", Price = 500000 },
       new Car { Model = "BMW", Price = 350000}
    };

        CarShowroom shop = new CarShowroom(myCars);
        foreach (var car in shop)
        {
            Console.WriteLine(car);
        }
    }
}

