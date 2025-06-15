using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string separator = ", ";
            Console.WriteLine(JoinNotes(separator, "Eat", "sleep", "code", "repeat"));
        }

        static string JoinNotes(string separator, params string[] str)
        {
            string result = string.Empty;
            result = string.Join(separator, str);
            return result;
        }
    }
}
