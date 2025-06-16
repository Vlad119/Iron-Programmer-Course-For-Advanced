using System;

namespace Main
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Character pers = new Character();
            string[] itemsDescriptions = new string[] { "Щит 4", "Сабля 3", "Посох 4" };
            Secret(pers, itemsDescriptions);
        }

        public static void Secret(Character pers, string[] itemsDescriptions)
        {
            Item[] items = new Item[itemsDescriptions.Length];
            int totalWeight = 0;
            for (int i = 0; i < itemsDescriptions.Length; i++)
            {
                string[] split = itemsDescriptions[i].Split();
                string name = split[0];
                int weight = Convert.ToInt32(split[1]);
                totalWeight += weight;
                items[i] = new Item(name, weight);
            }
            if (totalWeight > 20)
            {
                Console.WriteLine("Слишком тяжёлое снаряжение");
            }
            else
            {
                Console.WriteLine("Персонаж забрал снаряжение");
                pers.equipment.items = items;
            }
        }
    }
}
