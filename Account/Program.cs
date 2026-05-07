namespace Account;

class Program
{
    static void Main(string[] args)
    {
        // This is a comment from a teammate!  
        Account firstAccount = new(100, "Bob");
        Account secondAccount = new(5, "Bobby");

        Console.WriteLine("Initial account states:");
        firstAccount.Show();
        secondAccount.Show();

        Console.WriteLine("\nAttempting to withdraw 200 from Bob's account:");
        if (firstAccount.Withdraw(200f))
        {
            Console.WriteLine("Withdraw successful!");
        }
        else
        {
            Console.WriteLine("Withdraw unsuccessful (balance too low).");
        }

        firstAccount.Show();

        Console.WriteLine("\nDepositing 100 to Bob's account:");
        firstAccount.Deposit(100f);
        firstAccount.Show();

        Console.WriteLine("\nAttempting to withdraw 150 from Bob's account:");
        if (firstAccount.Withdraw(150f))
        {
            Console.WriteLine("Withdrawal successful!");
        }
        else
        {
            Console.WriteLine("Withdrawal unsuccessful (balance too low).");
        }
        firstAccount.Show();

        Console.WriteLine("\nTransferring 2 from Bobby's account to Bob's account:");
        if (secondAccount.Transfer(firstAccount, 2f))
        {
            Console.WriteLine("Transfer successful!");
        }
        else
        {
            Console.WriteLine("Transfer unsuccessful (balance too low).");
        }
        secondAccount.Show();
        firstAccount.Show();

        Console.WriteLine("\nAttempting to transfer 500 from Bobby's account to Bob's account:");
        if (secondAccount.Transfer(firstAccount, 500f))
        {
            Console.WriteLine("Transfer successful!");
        }
        else
        {
            Console.WriteLine("Transfer unsuccessful (balance too low).");
        }
        secondAccount.Show();
        firstAccount.Show();

        Console.WriteLine("\nTesting the Balance property setter with negative value:");
        firstAccount.Balance = -50f; 
        Console.WriteLine($"Bob's balance after attempting to set -50: {firstAccount.Balance}");
    }
}
