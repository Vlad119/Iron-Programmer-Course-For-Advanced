using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        Reverse(numbers);
        Console.WriteLine(string.Join(", ", numbers));

        List<string> names = new List<string> { "Josef", "Vadim", "Ivan" };
        Reverse(names);
        Console.WriteLine(string.Join(", ", names));
    }

    static void Reverse<T>(List<T> list)
    {
        list.Reverse();
    }
}
