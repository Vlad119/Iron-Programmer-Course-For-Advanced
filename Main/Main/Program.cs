using System;

public class MainClass
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] words = new string[n];
        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine().Trim();
        }
        for (int i = 1; i < n; i++)
        {
            char lastChar = char.ToUpper(words[i - 1][words[i - 1].Length - 1]);
            char firstChar = char.ToUpper(words[i][0]);
            if (lastChar != firstChar)
            {
                int moveNumber = i + 1;
                if (moveNumber % 2 == 1)
                {
                    Console.WriteLine("Паша");
                }
                else
                {
                    Console.WriteLine("Маша");
                }
                return;
            }
        }
        if (n % 2 == 1)
        {
            Console.WriteLine("Маша");
        }
        else
        {
            Console.WriteLine("Паша");
        }
    }
}