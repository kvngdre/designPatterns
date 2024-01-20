namespace MementoPattern.Exercise.Solution;


public class Document {
    private string _content;

    private string _fontName;

    private byte _fontSize;

    public string Content 
    {
        get {return _content;}
        set {
            ArgumentNullException.ThrowIfNull(value);

            _content = value;
        }
    }

    public string FontName 
    {
        get => _fontName;
        set 
        {
            ArgumentNullException.ThrowIfNull(value);
            
            _fontName = value;
        }
    }

    public byte FontSize 
    {
        get => _fontSize;
        set 
        {
            ArgumentNullException.ThrowIfNull(value);

            _fontSize = value;
        }
    }
}