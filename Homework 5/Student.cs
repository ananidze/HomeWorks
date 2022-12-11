namespace Homework_5;

public class Student
{
    public string[] Subjects = { "Science", "English", "Chemistry", "Algebra", "Math" };
    
    public string Name { get; set; }
    public int Age { get; set; }
    public int Year { get; set; }

    public int YearsLeftBeforeGraduate() => 4 - (DateTime.Now.Year - Year);
    public string RandomSubject() => Subjects[new Random().Next(Subjects.Length)];
}
