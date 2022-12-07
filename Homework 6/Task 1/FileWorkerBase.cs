namespace Homework_6.Task_1;

public abstract class FileWorkerBase
{
    public int FileMaxSize { get; set; }
    public abstract string? FileFormat { get; set; }

    public abstract void Read();
    public abstract void Write();
    public abstract void Edit();
    public abstract void Delete();
}