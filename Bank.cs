using System;

public class Bank
{
    static void Main(string[] args)
    {
        Bankaccount bank = new Bankaccount(1000);
        bank.Deposit(100);
        bank.Withdraw(50);
        Console.WriteLine("Your balance is: " + bank.GetBalance());

        Savingsaccount savings = new Savingsaccount();
        savings.Withdraw(200);
        savings.Deposit(300);
    }
}