using System;

internal class Program
{
    public enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Calc(2.5, 2, Operation.Add));
        Console.WriteLine(Calc(2.5, 2, Operation.Subtract));
    }

    public static double Calc(double a, double b, Operation oper)
    {
        switch (oper)
        {
            case Operation.Add: return a + b;
            case Operation.Subtract: return a - b;
            case Operation.Multiply: return a * b;
            case Operation.Divide: if (b == 0) throw new Exception("Деление на ноль"); return a / b;
            default: throw new Exception("Неизвестная операция");
        }
    }
}
