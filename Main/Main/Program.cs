using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperHero Batman = new SuperHero("Бэтмен");
            Console.WriteLine(((Human)Batman).Name);

            SuperHero SpiderMan = new SuperHero("Человек-паук");
            Console.WriteLine(((Human)SpiderMan).Name);

            SuperHero Superman = new SuperHero("Супермен");
            Console.WriteLine(((Human)Superman).Name);

            SuperHero MegaMan = new SuperHero("Мегамен");
            Console.WriteLine(((Human)MegaMan).Name);
        }
    }
}
