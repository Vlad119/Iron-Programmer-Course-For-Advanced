using System;

public class MainClass
{
    public static void Main()
    {
        char c = Convert.ToChar(Console.ReadLine());
        if (char.IsDigit(c))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}