namespace CommandPattern.WithHistory;

public interface IUndoableCommand : ICommand
{
    void Unexecute();
}
