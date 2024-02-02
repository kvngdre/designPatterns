using CommandPattern.WithHistory;

namespace CommandPattern;

public class BoldTextCommand : IUndoableCommand
{
    private string? prevContent;

    private readonly Document _document;

    private readonly History _history;

    public BoldTextCommand(Document document, History history)
    {
        _document = document;
        _history = history;
    }

    public void Unexecute()
    {
        _document.Content = prevContent;
    }

    public void Execute()
    {
        prevContent = _document.Content;

        _document.MakeBold();

        _history.Push(this);
    }
}
