using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Character character = new Character();
            character.equipment.items[0].ShowItem();
            character.equipment.items[1].ShowItem();
            Console.WriteLine($"Общий вес: {character.equipment.GetWeightOfEquipment()}");
        }
    }
}
