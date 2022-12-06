namespace Homework_5;

public class Teacher
{
    public string Name { get; set; }
    public bool IsCertified { get; set; }

    public void CheckCompetency(string subject)
    {
        switch (subject)
        {
            case "Math":
                Random random = new Random();
                int a = random.Next();
                int b = random.Next();
                Console.WriteLine($"{a} + {b} = {a + b}" );
                break;
            case "Chemistry":
                Console.WriteLine("H2O");
                break;
            case "English":
                Console.WriteLine("The quick brown fox jumps over the lazy dog");
                break;
            default:
                Console.WriteLine("Not Competent In This Subject");
                break;
        }
    } 
}
