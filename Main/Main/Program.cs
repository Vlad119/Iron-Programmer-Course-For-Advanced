using System;

internal class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book
        {
            Name = "Предел",
            Author = "Сергей Лукьяненко",
            ReleaseYear = 2021
        };

        Book book2 = new Book
        {
            Name = "Предел",
            Author = "Сергей Лукьяненко",
            ReleaseYear = 2021
        };

        Console.WriteLine(book1.Equals(book2));

        Book book3 = new Book
        {
            Name = "Предел2",
            Author = "Сергей Лукьяненко",
            ReleaseYear = 2021
        };
        Console.WriteLine(book1.Equals(book3));


        Book book4 = new Book
        {
            Name = "Предел",
            Author = "Сергей Лукьяненко2",
            ReleaseYear = 2021
        };
        Console.WriteLine(book1.Equals(book4));

        Book book5 = new Book
        {
            Name = "Предел",
            Author = "Сергей Лукьяненко",
            ReleaseYear = 2026
        };
        Console.WriteLine(book1.Equals(book5));
    }
}
