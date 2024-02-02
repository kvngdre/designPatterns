namespace CommandPattern.WithHistory;

public class Editor
{
    public static void Run()
    {
        var document = new Document();
        var history = new History();
        document.Content = "Hello, World!";

        var boldTextCommand = new BoldTextCommand(document, history);
        var undoCommand = new UndoCommand(history);

        boldTextCommand.Execute();
        System.Console.WriteLine(document.Content);

        undoCommand.Execute();
        System.Console.WriteLine(document.Content);
    }
}
