using System;
using System.Diagnostics;
using System.Text;

namespace CSharpEssentials
{
    class Program
    {
        delegate void MeasureMethod(int repeatCount);
        static void Main()
        {
            Measure(StringMeasure);
            Measure(StringBuilderMeasure);
        }
        private static void Measure(MeasureMethod measureMethod)
        {
            int repeatCount = 10000;
            Stopwatch time = Stopwatch.StartNew();
            measureMethod(repeatCount);
            time.Stop();
            Console.WriteLine(time.Elapsed.TotalMilliseconds);
        }
        private static void StringBuilderMeasure(int repeatCount)
        {
            StringBuilder stringBuilderResult = new StringBuilder("Test");
            for (int i = 0; i < repeatCount; i++)
            {
                stringBuilderResult.Append("{i}");
            }
        }
        private static void StringMeasure(int repeatCount)
        {
            string stringResult = "Test";
            for (int i = 0; i < repeatCount; i++)
            {
                stringResult += "{i}";
            }
        }
    }
}