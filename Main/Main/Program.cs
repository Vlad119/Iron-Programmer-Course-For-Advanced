using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    class Program
    {
        static void Main()
        {
            Print(new List<int> { 1, 2, 3, 4, 5 }, IsEven);
        }

        static void Print(List<int> items, Func<int, bool> predicate)
        {
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    Console.Write(item + " ");
                }
            }
        }

        // Создайте метод IsEven

        static bool IsEven(int item)
        {
            return item % 2 == 0;
        }

    }
}