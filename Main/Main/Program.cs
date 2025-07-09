using System;
using System.Net;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Cooker cooker = new Cooker();
            Soup soup1 = cooker.MakeSoup(new Carrot(), new Chicken(), new Potato());
            Soup soup2 = cooker.MakeSoup(new Chicken(), new Carrot(), new Potato());
            Soup soup3 = cooker.MakeSoup(new Chicken(), new Potato(), new Carrot());
            Console.WriteLine(soup1.GetType().Name);
            Console.WriteLine(soup2.GetType().Name);
            Console.WriteLine(soup3.GetType().Name);
        }
    }
}
