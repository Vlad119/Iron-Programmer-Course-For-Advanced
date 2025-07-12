using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Book book = new Book(1, "Война и мир", new Author() { Name = "Л.Н. Толстой" });
            AddAuthorIntoDataBase(book);
        }
        private static void AddAuthorIntoDataBase(Book book)
        {
            Console.WriteLine($"{book.Author.Name}");
        }
    }
}
