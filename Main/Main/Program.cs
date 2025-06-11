using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palindrom = "топот";
            bool IsSuccess = IsPalindrome(palindrom, out string revers);
            Console.WriteLine($"Строка палиндром? Ответ {IsSuccess}. Полученый результат: {revers}");
        }

        static bool IsPalindrome(string palindrom, out string revers)
        {     
            int left = 0;
            int right = palindrom.Length - 1;
            while (left < right)
            {
                if (palindrom[left] != palindrom[right])
                {
                    revers = "Это не палиндром";
                    return false;
                }
                left++;
                right--;
            }
            char[] charArray = palindrom.ToCharArray();
            Array.Reverse(charArray);
            revers = new string(charArray);
            return true;
        }
    }
}
