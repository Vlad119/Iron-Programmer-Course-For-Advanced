using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Human piterParker = new Human("Питер Паркер");
            SuperHero spiderMan = piterParker;
            Console.WriteLine(spiderMan.Name);

            Human clarkKent = new Human("Кларк Кент");
            SuperHero superMan = clarkKent;
            Console.WriteLine(superMan.Name);

            Human bruceWayne = new Human("Брюс Уейн");
            SuperHero batman = bruceWayne;
            Console.WriteLine(batman.Name);

            Human nikolasCage = new Human("Николас Кейдж");
            SuperHero ghostRider = nikolasCage;
            Console.WriteLine(ghostRider.Name);
        }
    }
}
