using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            JuiceExtractor juiceExtractor = new JuiceExtractor();
            Juice appleJuice = juiceExtractor.MakeJuice(new Apple());
            Console.WriteLine(appleJuice.Name);
            Juice orangeJuice = juiceExtractor.MakeJuice(new Orange());
            Console.WriteLine(orangeJuice.Name);
            Juice grapeJuice = juiceExtractor.MakeJuice(new Grape());
            Console.WriteLine(grapeJuice.Name);
        }
    }
}
