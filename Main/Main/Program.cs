using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Исходное значение переменной: " + number);
            NextEvenNumber(ref number);
            Console.WriteLine("Измененное значение переменной: " + number);
        }

        static void NextEvenNumber(ref int _number)
        {
            if (_number % 2 == 0)
            {
                _number += 2;
            }
            else
            {
                _number += 1;
            }
        }
    }
}
