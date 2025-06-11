using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<string> books = new List<string>();
        for (int i = 0; i < n; i++)
        {
            books.Add(Console.ReadLine());
        }
        int index1 = int.Parse(Console.ReadLine());
        int index2 = int.Parse(Console.ReadLine());
        SwapBooks(ref books, index1, index2);
        Console.WriteLine(string.Join(" ", books));
    }

    
    static void SwapBooks(ref List<string> books, int index1, int index2)
    {
        string temp = books[index1];
        books[index1] = books[index2];
        books[index2] = temp;
    }
}