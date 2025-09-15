using System.Runtime;

public class Bankaccount
{
    private int Balance;
    public string Amount;

    public Bankaccount(int balance)
    {
        Balance = balance;
    }

    public void Deposit(int amount)
    {
        Balance += amount;
        Console.WriteLine("You deposited " + amount);
    }

    public void Withdraw(int amount)
    {
        if (Balance < amount)
        {
            Console.WriteLine("Insufficient funds");
        }
        Balance -= amount;
        Console.WriteLine("You withdrew " + amount);
    }

    public int GetBalance()
    {
        return Balance;
    }

        public Bankaccount()  // lade till en tom konstuktor. Då bankaccount är en konstruktor som måste skicka ett värde. 
                          // och jag vill att savingsaccount ska ärva från bankaccount måste även den skicka med ett tal
                          // annars vet inte bankaccount vad den ska göra i savingsaccount.
    {
        Balance = 0;
    }


}
