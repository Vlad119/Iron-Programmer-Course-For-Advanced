using System;

public class Book : IEquatable<Book>
{
    public string Name { get; set; }
    public string Author { get; set; }
    public int ReleaseYear { get; set; }

    public bool Equals(Book other)
    {
        return Name == other.Name && Author == other.Author && ReleaseYear == other.ReleaseYear;
    }

    public override string ToString()
    {
        return $"{Name}, {Author}, {ReleaseYear}";
    }
}