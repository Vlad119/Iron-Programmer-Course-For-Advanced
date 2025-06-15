namespace Main
{
    internal class Program
    {
        static void Main()
        {
            int n = 72;
            int[] numbers = { 43, 85, 34, 21, 90, 123, 4, 6 };
            FindMax(n, numbers);
        }

        static int FindMax(int n, params int[] numbers)
        {
            int max = 0; 
            foreach (int number in numbers)
            {
                if (number <= n && number > max) 
                {
                    max = number;
                }
            }
            return max; 
        }
    }
}
