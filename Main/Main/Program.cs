using System;

internal class Program
{
    public enum Month
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }


    static void Main(string[] args)
    {
        Console.WriteLine((int)Month.November);
        Console.WriteLine((int)Month.December);
        Console.WriteLine((int)Month.June);
    }
}
