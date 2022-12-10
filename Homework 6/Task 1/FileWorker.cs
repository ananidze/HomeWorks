namespace Homework_6.Task_1;

public class FileWorker : FileWorkerBase
{
    public override string? FileFormat { get; set; }
    public override void Read()
    {
        Console.WriteLine($"I can read from {FileFormat} file with max storage {FileMaxSize}");
    }

    public override void Write()
    {
        Console.WriteLine($"I can write to {FileFormat} file with max storage {FileMaxSize}");
    }

    public override void Edit()
    {
        Console.WriteLine($"I can edit from {FileFormat} file with max storage {FileMaxSize}");
    }

    public override void Delete()
    {
        Console.WriteLine($"I can Delete from {FileFormat} file with max storage {FileMaxSize}");
    }
}
