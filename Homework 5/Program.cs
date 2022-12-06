namespace Homework_5;

public static class Program
{

    static void CompanyFunc()
    {
        Company company = new Company { IsLocal = false };
        Console.WriteLine(company.CalculateTax(200));

        company = new Company { IsLocal = true };
        Console.WriteLine(company.CalculateTax(200));
    }

    static void EmployeeFunc()
    {
        Developer dev = new Developer{ FirstName = "A", LastName = "A", Age = 21, HoursOfWorkPerDay = new uint[] { 8, 8, 8, 8, 8, 8, 0 } };
        Console.WriteLine(dev.CalculateSalary());
        
        Manager man = new Manager{ FirstName = "A", LastName = "B", Age = 21, HoursOfWorkPerDay = new uint[] { 8, 8, 8, 8, 8, 8, 0 } };
        Console.WriteLine(man.CalculateSalary());
        
        Tester test = new Tester { FirstName = "A", LastName = "B", Age = 21, HoursOfWorkPerDay = new uint[] { 8, 8, 8, 8, 8, 8, 0 } };
        Console.WriteLine(test.CalculateSalary());
    }

    static void StudentAndTeacherFunc()
    {
        Student G = new Student { Name = "Giga", Age = 21, Year = 2019};
        string subject = G.RandomSubject();
        Console.WriteLine(subject);
        Console.WriteLine(G.YearsLeftBeforeGraduate());

        Teacher X = new Teacher { Name = "John", IsCertified = true };
        X.CheckCompetency(subject);
    }
    
    static void Main(string[] args)
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