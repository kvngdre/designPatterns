namespace MementoPattern.Exercise.Solution;

public class Memento : IMemento
{
    public readonly string Content;
    public readonly string FontName;
    public readonly byte FontSize;

    public Memento(string content, string fontName, byte fontSize)
    {
        Content = content;
        FontName = fontName;
        FontSize = fontSize;
    }

    public string getDate()
    {
        return DateTime.Now.ToString();
    }
}