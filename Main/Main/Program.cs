using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int levelProgres = int.Parse(Console.ReadLine()); // Передаём 5
            bool isSuccess = ResetProgres(ref levelProgres);
            Console.WriteLine($"Уровень игрока обнулён с результатом {isSuccess}. Теперь у игрока {levelProgres} уровень");
        }
        static bool ResetProgres(ref int levelProgres)
        {
            if (levelProgres == 0)
            {
                return false;
            }
            levelProgres = 0;
            return true;
        }
    }
}
