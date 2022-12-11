using System.Text;

namespace Classwork7;

public class BankAccount
{
    public string Number { get; }
    public string Owner { get; }

    public decimal Balance
    {
        get => AllTransactions.Sum(x => x.Amount);
        set => throw new NotImplementedException();
    }

    static int _accountNumberSeed = 12345689;

    public readonly List<Transaction> AllTransactions = new();

    public BankAccount(string name, decimal initialBalance)
    {
        Owner = name;
        Number = _accountNumberSeed.ToString();
        MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
        _accountNumberSeed++;
    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of Deposit must be positive");
        }

        var deposit = new Transaction(amount, date, note);
        AllTransactions.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "amount of withdrawal must be positive");
        }

        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Not Sufficient funds for this withdrawal");
        }

        var withdrawal = new Transaction(-amount, date, note);
        AllTransactions.Add(withdrawal);
    }

    
    public string GetAccountHistory()
    {
        var reports = new StringBuilder();
        reports.AppendLine("Date\tAmount\tNote");
        foreach (var item in AllTransactions)
        {
            reports.AppendLine($"{item.Date}\t{item.Amount}\t{item.Notes}");
        }

        return reports.ToString();
    }
    
}
