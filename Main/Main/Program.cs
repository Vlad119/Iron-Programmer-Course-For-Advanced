using System;

public class MainClass
{
    public static void Main()
    {
        string s1 = Convert.ToString(Console.ReadLine());
        string s2 = Convert.ToString(Console.ReadLine());
        char c1 = char.ToLower(s1[0]);
        char c2 = char.ToLower(s2[s2.Length - 1]);
        if (c1 == c2)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}