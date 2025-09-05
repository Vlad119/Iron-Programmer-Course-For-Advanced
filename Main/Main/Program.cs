using System;

internal class Program
{
    static void Main(string[] args)
    {
        var animals = ("собака", "кот", "корова", "курица", "лошадь");
        string last = animals.Item5;
        Console.WriteLine(last);
    }
}