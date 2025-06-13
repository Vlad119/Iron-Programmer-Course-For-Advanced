using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            Console.WriteLine(Calculate(a, b)); // Вывод: 8
            string operation = "*";
            Console.WriteLine(Calculate(a, b, operation)); // Вывод: 15
        }

        static double Calculate(int a, int b, string operation = "+")
        {
            switch (operation)
            {
                case "+":
                    return a + b;

                case "-":
                    return a - b;

                case "*":
                    return a * b;

                case "/":
                    if (b == 0)
                    {
                        return 0;
                    }
                    return (double)a / b;
                default: return a + b;
            }
        }
    }
}