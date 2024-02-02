namespace CommandPattern.WithHistory;

public class History
{
    private readonly Stack<IUndoableCommand> _commands = [];

    public void Push(IUndoableCommand command)
    {
        _commands.Push(command);
    }

    public IUndoableCommand Pop()
    {
        return _commands.Pop();
    }

    public int Size()
    {
        return _commands.Count;
    }
}
