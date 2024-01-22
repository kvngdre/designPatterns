namespace MementoPattern.Exercise.Solution;


public class Caretaker
{
    private Stack<IMemento> _history = [];

    public void Add(IMemento memento)
    {
        _history.Push(memento);
    }

    public IMemento Pop()
    {
        return _history.Pop();
    }
}