namespace Homework_6.Task_2;

public class Bank : IFinanceOperations
{
    public double CalculateLoanPercent(int month, double amountPerMonth)
    {
        return month * amountPerMonth * 5 / 100;
    }

    public bool CheckUserHistory() => new Random().Next(2) == 1;
}
