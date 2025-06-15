using System;

public class MainClass
{
    public static void Main()
    {
        string s = Convert.ToString(Console.ReadLine());
        char c = s[0];
        if (char.IsLetter(c) && char.IsUpper(c))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}