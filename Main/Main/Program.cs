using System;

public class MainClass
{
    public static void Main()
    {
        string s = Console.ReadLine();
        int plus = 0;
        int pow = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '+') plus++;
            if (s[i] == '*') pow++;
        }
        Console.WriteLine("Символ + встречается " + plus + " раз");
        Console.WriteLine("Символ * встречается " + pow + " раз");
    }
}