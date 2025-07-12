namespace Main
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }

        public Book(int id, string title, Author author)
        {
            Id = id;
            Title = title;
            Author = author;
        }

        public static implicit operator Author(Book book)
        {
            return book.Author;
        }
    }
}
