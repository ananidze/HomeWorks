namespace Homework_5;

public static class Program
{

    static void CompanyFunc()
    {
        var company = new Company { IsLocal = false };
        Console.WriteLine(company.CalculateTax(200));

        company = new Company { IsLocal = true };
        Console.WriteLine(company.CalculateTax(200));
    }

    static void EmployeeFunc()
    {
        var dev = new Developer{ FirstName = "A", LastName = "A", Age = 21, HoursOfWorkPerDay = new uint[] { 8, 8, 8, 8, 8, 8, 0 } };
        Console.WriteLine(dev.CalculateSalary());
        
        var man = new Manager{ FirstName = "A", LastName = "B", Age = 21, HoursOfWorkPerDay = new uint[] { 8, 8, 8, 8, 8, 8, 0 } };
        Console.WriteLine(man.CalculateSalary());
        
        var test = new Tester { FirstName = "A", LastName = "B", Age = 21, HoursOfWorkPerDay = new uint[] { 8, 8, 8, 8, 8, 8, 0 } };
        Console.WriteLine(test.CalculateSalary());
    }

    static void StudentAndTeacherFunc()
    {
        var student = new Student { Name = "Giga", Age = 21, Year = 2019};
        string subject = g.RandomSubject();
        Console.WriteLine(subject);
        Console.WriteLine(g.YearsLeftBeforeGraduate());

        var x = new Teacher { Name = "John", IsCertified = true };
        x.CheckCompetency(subject);
    }
    
    static void Main()
    {
        #region Company
        CompanyFunc();
        #endregion


        #region Employee
        EmployeeFunc();
        #endregion


        #region Student
        StudentAndTeacherFunc();
        #endregion
    }
}