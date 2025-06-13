using System;

namespace Main
{
    internal class Program
    {
        static void Main()
        {
            int n = 3;
            string[] names = { "Игорь Кузнецов", "Елена Соколова", "Максим Петров" };
            AddNumbers(names);
        }

        static void AddNumbers(params string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {names[i]}");
            }
        }
    }
}
