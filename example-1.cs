using System;
public class BankingApplication
{
    private decimal accountABalance;
    private decimal accountBBalance;

    public BankingApplication(decimal initialBalanceA, decimal initialBalanceB)
    {
        accountABalance = initialBalanceA;
        accountBBalance = initialBalanceB;
    }

    public void TransferMoney(decimal amount, string sourceAccount, string destinationAccount)
    {
        if (sourceAccount == "A" && accountABalance >= amount)
        {
            accountABalance -= amount;
            accountBBalance += amount;
            Console.WriteLine($"Transfer of {amount:C} from Account A to Account B successful.");
        }
        else
        {
            Console.WriteLine("Insufficient funds or invalid account.");
        }
    }

    public void DisplayBalances()
    {
        Console.WriteLine($"Account A balance: {accountABalance:C}");
        Console.WriteLine($"Account B balance: {accountBBalance:C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankingApplication bankingApp = new BankingApplication(1000, 500); // Initial balances for Account A and Account B

        Console.WriteLine("Initial Balances:");
        bankingApp.DisplayBalances();

        Console.WriteLine("\nTransferring $1500 from Account A to Account B...");
        bankingApp.TransferMoney(1500, "A", "B"); // Attempt to transfer $1500 from Account A to Account B

        Console.WriteLine("\nBalances after Transfer:");
        bankingApp.DisplayBalances();
    }
}
