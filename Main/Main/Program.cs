using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            MagicCauldron magicCauldron = new MagicCauldron();
            LovePotion lovePotion = magicCauldron.MakePotion(new RedCarnation(), new WhiteRose(), new IvyBush());
            DeathPotion deathPotion = magicCauldron.MakePotion(new WhiteRose(), new IvyBush(), new RedCarnation());
            Console.WriteLine(lovePotion.GetType().Name);
            Console.WriteLine(deathPotion.GetType().Name);
        }
    }
}
