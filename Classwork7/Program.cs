namespace Classwork7;

public class Giga
{
    static void Main()
    {
        var account = new BankAccount("Giga", 1000);
        Console.WriteLine($"Account {account.Number} was created for {account.Owner}");
        account.MakeDeposit(200, DateTime.Now, "Deposit 200$");
        Console.WriteLine(account.GetAccountHistory());
        Console.WriteLine(account.AllTransactions[0].Amount);
        Console.WriteLine(account.Balance);
    }
}