using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    class Program
    {
        delegate bool Predicate(int year);
        static void Main()
        {
            List<int> years = new List<int> { 13, 17, 18, 19, 20, 50 };
            List<int> adults = GetAdults(years, IsAdult);
            foreach (var adult in adults)
            {
                Console.WriteLine(adult);
            }
        }

        private static bool IsAdult(int year)
        {
            return year >= 18;
        }

        private static List<int> GetAdults(List<int> years, Predicate predicate)
        {
            var adults = new List<int>();
            foreach (var year in years)
            {
                if(predicate(year)) adults.Add(year);
            }
            return adults;
        }
    }
}