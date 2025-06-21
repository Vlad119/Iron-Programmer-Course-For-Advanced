using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            var w1 = new Worker()
            {
                Name = "Иван",
                Age = 25,
                Salary = 1000
            };
            var w2 = new Worker()
            {
                Name = "Вася",
                Age = 26,
                Salary = 2000
            };
            Console.WriteLine(w1.Salary + w2.Salary);
        }
    }
}
