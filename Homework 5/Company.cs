namespace Homework_5;

public static class CompanyType
{
    public static readonly double Local = 0.18;
    public static readonly double Foreign = 0.05;

}
public class Company
{
    public bool IsLocal { get; set; }
    public double CalculateTax(double amount) => IsLocal ? amount * CompanyType.Local : amount * CompanyType.Foreign;
}
