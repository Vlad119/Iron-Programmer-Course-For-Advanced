using System;

internal class Program
{
    public static void Main()
    {
        int[] numbers = new int[] { 11, 12, 13, 14, 15, 16, 22, 44, 66 };
        Selector selector = new Selector(numbers);
        selector.PrintOdds();
        Console.WriteLine();
        selector.PrintEvens();
    }
}
