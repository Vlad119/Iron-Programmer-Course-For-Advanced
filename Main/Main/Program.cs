using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person pers = new Person(18);
            if (pers.IsAdult())
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

            Person.IncreaseLegalAge(1);
            if (pers.IsAdult())
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
