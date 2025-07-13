using System;

internal class Program
{
    public static void Main()
    {
        Console.WriteLine(FileFormat.PlainText.GetFileExtension());
        Console.WriteLine(FileFormat.OfficeWord.GetFileExtension());
        Console.WriteLine(FileFormat.Markdown.GetFileExtension());
        Console.WriteLine(FileFormat.Json.GetFileExtension());
        Console.WriteLine(FileFormat.XML.GetFileExtension());
    }

    public enum FileFormat
    {
        PlainText,
        OfficeWord,
        Markdown,
        Json,
        XML
    }
}

