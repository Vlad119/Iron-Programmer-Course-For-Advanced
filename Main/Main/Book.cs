using System;

public class Book : IComparable<Book>
{
    public string Name { get; set; }
    public string Author { get; set; }
    public int ReleaseYear { get; set; }

    public int CompareTo(Book other)
    {
        var comp = Author.CompareTo(other.Author);
        if (comp == 0) return ReleaseYear.CompareTo(other.ReleaseYear);
        return comp;
    }
    public override string ToString() => $"{Name}, {Author}, {ReleaseYear}";
}