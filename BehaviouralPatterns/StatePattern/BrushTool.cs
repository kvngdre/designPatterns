namespace StatePattern;

public class BrushTool : Tool
{
    public void MouseDown()
    {
        System.Console.WriteLine("Brush Icon");
    }

    public void MouseUp()
    {
        System.Console.WriteLine("Draw a line");
    }
}
