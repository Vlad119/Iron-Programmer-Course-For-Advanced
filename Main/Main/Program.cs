using System;

internal class Program
{
    static void Main(string[] args)
    {
        Book[] books =
        {
            new Book {Name = "Предел", Author = "Сергей Лукьяненко", ReleaseYear = 2021},
            new Book {Name = "Порог", Author = "Сергей Лукьяненко", ReleaseYear = 2020},
            new Book {Name = "Чистая архитектура", Author = "Мартин Роберт", ReleaseYear = 2018},
            new Book {Name = "C# для профессионалов", Author = "Скит Джон", ReleaseYear = 2019}
        };
        Array.Sort(books);
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}
