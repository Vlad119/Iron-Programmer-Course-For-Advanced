using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(1, "Мёртвые души", new Author() { Name = "Н.В. Гоголь" });
            Console.WriteLine($"{(int)book} {(string)book}");
        }
    }
}
