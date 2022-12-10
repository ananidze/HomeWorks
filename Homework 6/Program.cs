using Homework_6.Task_1;
using Homework_6.Task_2;

namespace Homework_6;

public static class Program
{
    static void Main()
    {
        #region Task 1
        var file = new FileWorker { FileFormat = "txt", FileMaxSize = 128 };
        file.Read();
        file.Write();
        file.Edit();
        file.Delete();
        #endregion

        #region Task 2
        var bank = new Bank();
        if (bank.CheckUserHistory())
        {
            Console.WriteLine(bank.CalculateLoanPercent(12, 200));
        }

        var microfinance = new MicroFinance();
        Console.WriteLine(microfinance.CalculateLoanPercent(12, 100));
        #endregion
    }
}