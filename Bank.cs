using System.Runtime;

public class Bank
{
    private int Balance;

    public Bank(int balance)
    {
        Balance = balance;
    }

    public void Deposit()
    {
        Console.WriteLine("You deposited " + Balance);
    }

    public void Withdraw()
    {
        Console.WriteLine("You withdrew " + Balance);
    }
}