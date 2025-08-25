using System;
using static Program;

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
        Console.WriteLine(GetDay(Month.February));
        Console.WriteLine(GetDay(Month.August));
        Console.WriteLine(GetDay(Month.July));
    }

    private static int GetDay(Month month)
    {
        switch (month)
        {
            case Month.February:
                return 28;
            case Month.April:
            case Month.June:
            case Month.September:
            case Month.November:
                return 30;
            default:
                return 31;
        }
    }
}
