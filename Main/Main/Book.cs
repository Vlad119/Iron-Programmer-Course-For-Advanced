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

        public static explicit operator int(Book book)
        {
            return book.Id;
        }

        public static implicit operator string(Book book)
        {
            return book.Title;
        }
    }
}
