using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = 25;
            int month = 10;
            int year = 1917;
            Console.WriteLine(FormatDate(ref day, ref month, ref year));
            day = 25;
            month = 10;
            year = 1917;
            string separator = "-";
            Console.WriteLine(FormatDate(ref day, ref month, ref year, separator));
            Console.WriteLine($"Даты переведены на современный календарь. Год: {year}, месяц: {month}, день: {day}");
        }

        static string FormatDate(ref int day, ref int month, ref int year, string separator = "/")
        {
            day += 13;
            int[] daysInMonth = new int[]
            {
                31, ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) ? 29 : 28,
                31, 30, 31, 30, 31, 31, 30, 31, 30, 31  
            };
            while (day > daysInMonth[month - 1])
            {
                day -= daysInMonth[month - 1];
                month++;
                if (month > 12)
                {
                    month = 1;
                    year++;
                }
            }
            return $"{day}{separator}{month}{separator}{year}";
        }
    }
}