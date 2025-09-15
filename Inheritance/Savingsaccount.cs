using System;

public class Savingsaccount : Bankaccount
{
        public override void Withdraw(int amount)
    {
        Console.WriteLine("You withdrew " + amount);
    }
    public override void Deposit(int amount)
    {
        Console.WriteLine("You deposited " + amount);
    }

}