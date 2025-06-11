using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distance = 10;
            int discount = 50;
            Console.WriteLine(CalculateDelivery(distance: distance));
            Console.WriteLine(CalculateDelivery(distance: distance, discount: discount));
        }

        static double CalculateDelivery(int distance, int discount = 0)
        {
            double result = distance * 20 * (1 - ((double)discount / 100));
            return result;
        }
    }
}
