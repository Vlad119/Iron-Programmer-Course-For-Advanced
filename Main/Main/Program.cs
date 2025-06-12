using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = 5;
            int height = 4;
            Console.WriteLine(CreateRectangle(width));
            Console.WriteLine(CreateRectangle(width, height));
        }

        static string CreateRectangle(int width, int height = -1)
        {
            if (width <= 0 || (height != -1 && height <= 0))
            {
                return "Неверный формат";
            }
            if (height == -1)
            {
                return $"Квадрат {width}x{width}";
            }
            return width == height? $"Квадрат {width}x{height}": $"Прямоугольник {width}x{height}";
        }
    }
}
