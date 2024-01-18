namespace MementoPattern;

public class Editor
{
    private string _content = "";
    private List<string> _history = [];

    public string Content
    {
        get { return _content; }
        set
        {
            _history.Add(value);
            if (value is not null)
                _content = value;
        }
    }

    public void Undo()
    {
        var count = _history.Count;
        if (count > 1)
        {
            _history.RemoveAt(count - 1);
            _content = _history.TakeLast(1).First();
        }
        else
        {
            _content = "";
        }
    }
}