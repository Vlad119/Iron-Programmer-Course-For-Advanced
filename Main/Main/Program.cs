using System.Collections.Generic;
using System;


public class Program
{
    public static void Main()
    {
        BaseDate date = new BaseDate(2021, 3, 24);
        AmericanDate date1 = new AmericanDate(2021, 3, 24);
        EuropeanDate date2 = new EuropeanDate(2021, 3, 24);

        List<BaseDate> dates = new List<BaseDate>
    {
        date,date1, date2
    };

        foreach (var item in dates)
        {
            Console.WriteLine(item.GetFormat());
        }
    }
}
