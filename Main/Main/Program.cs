using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Driver d1 = new Driver("Василий", 35, 'B');
            Driver d2 = new Driver("Виктор", 23, 'C');
            Console.WriteLine(d1.Age + d2.Age);
        }
    }
}
