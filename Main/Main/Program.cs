using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(2, 3);
            Console.WriteLine(f1 * f2);
        }
    }
}
