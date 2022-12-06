namespace Homework_5;

public class Employee
{
    // public enum WeekDays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public uint SalaryPerHour { get; set; }
    public uint[] HoursOfWorkPerDay { get; set; }
    public uint Age { get; set; }
    
    public double CalculateSalary()
    {
        double sum = 0;
        for (int i = 0; i < HoursOfWorkPerDay.Length; i++)
        {
            if (HoursOfWorkPerDay[i] <= 8)
            {
                if (i < 5)
                {
                    sum += SalaryPerHour * HoursOfWorkPerDay[i];
                }
                else
                {
                    sum += SalaryPerHour * 2 * HoursOfWorkPerDay[i];
                }
            }
            else
            {
                if (i < 5)
                {
                    uint overtime = HoursOfWorkPerDay[i] - 8;
                    sum += (SalaryPerHour + 5) * overtime + SalaryPerHour * HoursOfWorkPerDay[i] - overtime;
                }
                else
                {
                 // TODO if employee worked overtime on sunday and monday   
                }
            }
        }

        return HoursOfWorkPerDay.Sum(x => x) > 50 ? sum  * 1.2 : sum;
    }
}

public class Manager : Employee
{
    public Manager() => SalaryPerHour = 40;
}

public class Developer : Employee
{
    public Developer() => SalaryPerHour = 30;
}

public class Tester : Employee
{
    public Tester() => SalaryPerHour = 20;
}
