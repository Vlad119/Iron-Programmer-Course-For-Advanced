using System.Globalization;
using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Fraction ratio = new Fraction(10, -2);
            Console.WriteLine($"{ratio.Numerator}/{ratio.Denominator} = {ratio.Value.ToString(CultureInfo.InvariantCulture)} ");
        }
    }
}
