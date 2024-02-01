namespace TemplateMethodPattern;

class Program
{
    static void Main(string[] args)
    {
        var moneyTransferTask = new TransferMoneyTask();
        var printReportTask = new PrintReportTask();

        moneyTransferTask.Execute();
        System.Console.WriteLine("\n");
        printReportTask.Execute();
    }
}
