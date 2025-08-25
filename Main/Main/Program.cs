using System;

internal class Program
{
    public enum WeekDay
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }


    static void Main(string[] args)
    {
        Console.WriteLine((int)WeekDay.Wednesday);
        Console.WriteLine((int)WeekDay.Monday);
        Console.WriteLine((int)WeekDay.Friday);
    }
}
