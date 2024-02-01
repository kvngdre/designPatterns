namespace TemplateMethodPattern;

public class PrintReportTask : Tasc
{
    protected override void DoTask()
    {
        System.Console.WriteLine("Printing report...");
    }

    protected override void ReadInput()
    {
        System.Console.WriteLine("Reading report from memory");
    }
}
