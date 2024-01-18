namespace MementoPattern;

internal class Editor
{
    private string _content = "";

    public string Content
    {
        get { return _content; }
        set
        {
            if (value is not null)
                _content = value;
            else
                throw new ArgumentNullException("Content");
        }
    }

    public EditorState CreateState()
    {
        return new EditorState(_content);
    }

    public void Restore(EditorState state)
    {
        _content = state.Content;
    }
}