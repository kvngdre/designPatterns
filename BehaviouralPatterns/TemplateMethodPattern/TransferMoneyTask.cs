namespace TemplateMethodPattern;

public class TransferMoneyTask : Tasc
{
    protected override void DoTask()
    {
        System.Console.WriteLine("Transferring the money...");
    }

    protected override void ReadInput()
    {
        System.Console.WriteLine("Initiating funds transfer.");
    }

    protected override void SignalTaskCompletion()
    {
        System.Console.WriteLine("Money transfer successful!");
    }
}
