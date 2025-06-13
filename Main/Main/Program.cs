using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string login = "admin";
            string email = "admin@site.com";
            int age = 25;
            Console.WriteLine(RegisterUser(login)); 
            Console.WriteLine(RegisterUser(login, email)); 
            Console.WriteLine(RegisterUser(login, email, age)); 
        }

        static string RegisterUser(string login, string email = "не указано", int age = 18)
        {
            return $"Логин: {login}, Email: {email}, Возраст: {age}";
        }
    }
}