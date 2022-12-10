namespace Homework_6.Task_2;

public class MicroFinance : IFinanceOperations
{
    public double CalculateLoanPercent(int month, double amountPerMonth)
    {
        return month * amountPerMonth * 1.1 + month * 4;
    }

    public bool CheckUserHistory() => true;
}
