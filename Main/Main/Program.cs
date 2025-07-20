using System;

internal class Program
{
    static void Main(string[] args)
    {
        decimal senderBalance = 100;
        decimal receiverBalance = 50;
        decimal amount = 30;
        bool isSuccess = Transfer(ref senderBalance, ref receiverBalance, amount);
        Console.WriteLine($"Выполнение операции {isSuccess}. Отправитель: {senderBalance}, Получатель: {receiverBalance}");
    }

    static bool Transfer(ref decimal senderBalance, ref decimal receiverBalance, decimal amount)
    {
        if (senderBalance - amount >= 0) 
        {
            senderBalance -= amount;
            receiverBalance += amount;
            return true;
        }
        return false;
    }
}
