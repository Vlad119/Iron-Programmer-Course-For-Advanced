using System;

public class MainClass
{
    public static void Main()
    {
        char c = Convert.ToChar(Console.ReadLine());
        if (char.IsLetter(c) && char.IsUpper(c))
        {
            Console.WriteLine(char.ToLower(c));
        }
        if (char.IsLetter(c) && char.IsLower(c))
        {
            Console.WriteLine(char.ToUpper(c));
        }
    }
}