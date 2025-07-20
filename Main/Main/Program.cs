using System;

internal class Program
{
    static void Main(string[] args)
    {
        if (SafeDivide(10, 2, out decimal result)) Console.WriteLine(result);
        else Console.WriteLine("Деление невозможно");
    }

    static bool SafeDivide(decimal a, decimal b, out decimal result)
    {
        result = 0M;
        if (b != 0)
        {
            result = a / b;
            return true;
        }
        return false;
    }
}
