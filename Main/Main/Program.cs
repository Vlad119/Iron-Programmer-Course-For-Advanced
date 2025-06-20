using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Matrix matrix = new Matrix();
            Console.WriteLine(matrix[0, 1]);
            matrix[0, 1] = 32;
            Console.WriteLine(matrix[0, 1]);
        }
    }
}
