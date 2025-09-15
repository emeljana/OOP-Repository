using System;

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank(1000);
        bank.Deposit();
        bank.Withdraw();
    }
}