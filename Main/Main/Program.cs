using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double enemySpeed = 5.5;
            double playerSpeed = 10.2;
            SwapSpeeds(ref enemySpeed, ref playerSpeed);
            Console.WriteLine($"{enemySpeed} и {playerSpeed}");
        }

        static void SwapSpeeds(ref double enemySpeed, ref double playerSpeed)
        {
            double temp = enemySpeed;
            enemySpeed = playerSpeed;
            playerSpeed = temp;
        }
    }
}
