namespace Homework_6.Task_2;

public interface IFinanceOperations
{
    double CalculateLoanPercent(int month, double amountPerMonth);
    bool CheckUserHistory();
}
