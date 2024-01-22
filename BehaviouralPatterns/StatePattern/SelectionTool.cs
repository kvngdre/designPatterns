namespace StatePattern;

public class SelectionTool : Tool
{
    public void MouseDown()
    {
        System.Console.WriteLine("Selection Icon");
    }

    public void MouseUp()
    {
        System.Console.WriteLine("Draw a dashed rectangle.");
    }
}
