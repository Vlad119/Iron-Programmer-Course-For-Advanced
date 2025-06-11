using System;

class Program
{
    static void Main(string[] args)
    {
        string format = "Иосиф:Яблочный спас";
        if (SplitNameAndHoliday(format, out string name, out string holiday))
        {
            Console.WriteLine($"{name} поздравляю тебя с праздником под названием: {holiday}");
        }
        else
        {
            Console.WriteLine("Неверный формат праздника");
        }
    }

    static bool SplitNameAndHoliday(string input, out string name, out string holiday)
    {
        name = string.Empty;
        holiday = string.Empty;
        if (string.IsNullOrEmpty(input)) return false;
        string[] split = input.Split(':');
        if (split.Length != 2) return false;
        if (string.IsNullOrWhiteSpace(split[0]) || string.IsNullOrWhiteSpace(split[1])) return false;
        name = split[0];
        holiday = split[1];
        return true;
    }
}