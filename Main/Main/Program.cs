using System;

internal class Program
{
    static void Main()
    {
        string[] names = { "Josef", "Vadim", "Ivan" };
        PrintArray(names);
    }

    static void PrintArray<T>(T[] array)
    {
        foreach (T item in array)
        {
            Console.WriteLine(item);
        }
    }
}
