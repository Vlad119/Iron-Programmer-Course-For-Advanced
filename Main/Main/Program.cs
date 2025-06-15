using System;

public class MainClass
{
    public static void Main()
    {
        string s = Console.ReadLine();
        int sosedy = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == s[i + 1])
            {
                sosedy++;
            }
        }
        Console.WriteLine(sosedy);
    }
}