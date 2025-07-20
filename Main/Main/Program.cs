using System;

internal class Program
{
    delegate bool Predicate(int a);
    static void Main(string[] args)
    {
        var x = 25;
        Predicate predicate = IsAdult;
        var result = predicate(x);
        Console.WriteLine(result);
    }

    static bool IsAdult(int age)
    {
        return age >= 18;
    }
}
