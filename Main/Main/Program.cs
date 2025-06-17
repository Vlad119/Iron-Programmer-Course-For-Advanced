using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            MyClass instance = new MyClass();
            instance.Property1 = 14;
            Console.WriteLine(instance.Property1);
        }
    }
}
