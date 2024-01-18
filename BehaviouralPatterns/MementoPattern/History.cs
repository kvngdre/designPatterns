namespace MementoPattern;
internal class History
{

    private readonly Stack<EditorState> _history = [];

    public void Add(EditorState editorState)
    {
        _history.Push(editorState);
    }
}