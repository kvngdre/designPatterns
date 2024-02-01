namespace StatePattern;

public class Canvas
{
    private Tool? _currentTool;

    public void MouseDown()
    {
        _currentTool?.MouseDown();
    }

    public void MouseUp()
    {
        _currentTool?.MouseUp();
    }

    public Tool? CurrentTool
    {
        get => _currentTool;
        set => _currentTool = value;
    }

}
