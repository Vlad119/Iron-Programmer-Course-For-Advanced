using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Driver driver = new Driver("Иван", "Иванов", 34);
            Console.WriteLine($"Новый водитель: {driver.FirstName} {driver.LastName}, возраст: {driver.Age}");
            driver.FirstName = "Алексей";
            driver.LastName = "Алексеев";
            driver.Age = 30;
            Console.WriteLine($"Новый водитель: {driver.FirstName} {driver.LastName}, возраст: {driver.Age}");
        }
    }
}
