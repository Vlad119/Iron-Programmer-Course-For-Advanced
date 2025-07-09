using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Dish dish = new Dish("Пельмени", 200);
            Dish newDish = dish + 50;
            Console.WriteLine(newDish);
        }
    }
}
