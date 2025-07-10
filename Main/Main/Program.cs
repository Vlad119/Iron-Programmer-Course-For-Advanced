using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Fire fire = new Fire();
            Ground ground = new Ground();
            Lava lava1 = ground + fire;
            Air air = new Air();
            Stone stone1 = lava1 + air;
            Console.WriteLine(lava1.GetType().Name);
            Console.WriteLine(stone1.GetType().Name);
        }
    }
}
