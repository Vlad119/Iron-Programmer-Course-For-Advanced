using System;

public class MainClass
{
    public static void Main()
    {
        string s = Console.ReadLine();
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsDigit(s[i]))
            {
                Console.Write(s[i] + " ");
            }
        }
    }
}