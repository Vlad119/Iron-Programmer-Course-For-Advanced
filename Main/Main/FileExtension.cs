using static Program;

public static class FileExtension
{
    internal static string GetFileExtension(this FileFormat fileFormat)
    {
        switch(fileFormat)
        {
            case FileFormat.PlainText: { return "txt";}
            case FileFormat.OfficeWord: { return "docx"; }
            case FileFormat.Markdown: { return "md"; }
            case FileFormat.Json: { return "json"; }
            case FileFormat.XML: { return "xml"; }
        }
        return string.Empty;
    }
}
