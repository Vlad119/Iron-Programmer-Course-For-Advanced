using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Item item1 = new Item();
            Item item2 = new Item("Меч", 10);
            Item item3 = new Item("Лук", 5, "Возгорание");
            Item item4 = new Item("Щит", 15, "Дополнительный урон");
            Item[] items = { item1, item2, item3, item4 };
            Equipment equipment = new Equipment(items);
            Console.WriteLine($"Вес всех предметов: {equipment.GetWeightOfEquipment()}");
        }
    }
}
