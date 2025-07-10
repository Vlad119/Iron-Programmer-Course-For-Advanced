using System;

public class BankAccount
{
    public Guid Id { get; set; }
    public decimal Balance { get; set; }

    public static decimal operator +(BankAccount b1, BankAccount b2)
    {
        return b1.Balance + b2.Balance;
    }
}
