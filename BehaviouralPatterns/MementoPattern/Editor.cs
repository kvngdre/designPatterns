namespace MementoPattern;

public class Editor
{
    private string _content = "";
    private Stack<string> _history = [];

    public string Content
    {
        get { return _content; }
        set
        {
            _history.Push(value);
            if (value is not null)
                _content = value;
        }
    }

    public void Undo()
    {
        if (_history.Count > 1)

            _content = _history.Pop();
        else
            _content = "";
    }
}