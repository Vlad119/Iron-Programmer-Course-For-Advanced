using System;
using System.Security.Cryptography;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sides = 5;
            bool IsSuccess = IsEven(sides, out int rightSides);
            Console.WriteLine($"Фигура задана {sides} сторонами с результатом {IsSuccess}, фигура создана. У неё: {rightSides} стороны(он)");
        }

        static bool IsEven(int sides, out int rightSides)
        {
            if (sides % 2 == 0 && sides >= 3)
            {
                rightSides = sides;
                return true;
            }
            else
            {
                rightSides = sides < 3 ? 4 : sides + 1;
                return false;
            }
        }
    }
}
