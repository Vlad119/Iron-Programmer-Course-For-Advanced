using System;

public class Book : IComparable<Book>
{
    public string Name { get; set; }
    public string Author { get; set; }
    public int ReleaseYear { get; set; }

    public int CompareTo(Book other) => ReleaseYear.CompareTo(other.ReleaseYear);
    public override string ToString() => $"{Name}, {Author}, {ReleaseYear}";
}