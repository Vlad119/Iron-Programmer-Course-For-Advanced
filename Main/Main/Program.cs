using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = "+";
            bool IsSuccess = TryCalculateTotal(out double result, operation, 3, 5.5, 7.1, 7.78, 19);
            if (IsSuccess) Console.WriteLine(result);
            else Console.WriteLine("Невозможно выполнить операцию");
        }

        static bool TryCalculateTotal(out double result, string operation, params double[] numbers)
        {
            result = 0;
            if (numbers == null || numbers.Length < 2) return false;
            double total = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                switch (operation)
                {
                    case "+": total += numbers[i]; break;
                    case "-": total -= numbers[i]; break;
                    case "*": total *= numbers[i]; break;
                    case "/": if (numbers[i] == 0) return false; total /= numbers[i]; break;
                    default: return false;
                }
            }
            result = total;
            return true;
        }
    }
}