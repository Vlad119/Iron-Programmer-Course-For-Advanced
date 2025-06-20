using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Dictionary dict = new Dictionary();
            Console.WriteLine(dict["blue"]);
            dict["blue"] = "голубой";
            Console.WriteLine(dict["blue"]);
        }
    }
}
