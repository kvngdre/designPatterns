namespace CommandPattern.WithHistory;

public class Document
{
    public string? Content { get; set; } = "";

    public void MakeBold()
    {
        Content = "<b>" + Content + "</b>";
    }
}
