using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 5, 1, 3, 8 };
            bool IsSuccess = FindMinMax(scores, out int min, out int max);
            Console.WriteLine($"Операция завершилась с результатом: {IsSuccess}. Min: {min}, Max: {max}");
        }

        static bool FindMinMax(int[] scores, out int min, out int max)
        {
            min = 0;
            max = 0;
            if (scores == null || scores.Length < 2) return false;
            foreach (int score in scores)
            {
                if (score < 0) return false;
            }
            min = scores[0];
            max = scores[0];
            foreach (int score in scores)
            {
                if (score > max) max = score;
                if (score < min) min = score;
            }
            return true;
        }
    }
}
