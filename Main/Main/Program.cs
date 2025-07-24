using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        Print(new List<int> { 1, 2, 3, 4, 5 }, Twice);
    }

    static void Print(List<int> items, Action<int> action)
    {
        foreach (var item in items)
        {
            action(item);
        }
    }

    // Создайте метод Twice

    static void Twice(int item)
    {
        Console.Write(item * 2 + " ");
    }
}
