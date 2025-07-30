using System;

internal class Program
{
    public static void Main()
    {
        EventArgs arg = new UserRegisteredEventArgs("Test2@yandex.ru");
        var info = typeof(UserRegisteredEventArgs).GetProperty("Email");
        if (info.CanWrite == false)
            Console.WriteLine("Ok");
        else
            throw new Exception("Свойство Email должно быть только для чтения");

    }
}
