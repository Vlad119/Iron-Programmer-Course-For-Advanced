using System;

internal class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 2, 4, 2 };
        int occurrences = FindOccurrencesCount(numbers, 2);
        Console.WriteLine(occurrences);

        string[] names = { "Josef", "Vadim", "Josef", "Ivan" };
        int occurrences2 = FindOccurrencesCount(names, "Josef");
        Console.WriteLine(occurrences2);
    }

    static int FindOccurrencesCount<T>(T[] array, T item)
    {
        int result = 0;
        foreach(T item2 in array)
        {
            if(item2.Equals(item)) result++;
        }
        return result;
    }


}
