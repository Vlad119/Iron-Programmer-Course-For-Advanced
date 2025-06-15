using System;

public class Selector
{
    public int[] array;

    public Selector(int[] array)
    {
        this.array = array;
    }

    public void PrintOdds()
    {
        foreach (var a in array)
        {
            if (Math.Abs(a) % 2 != 0) Console.Write(a + " ");
        }
    }

    public void PrintEvens()
    {
        foreach (var a in array)
        {
            if (Math.Abs(a) % 2 == 0) Console.Write(a + " ");
        }
    }
}