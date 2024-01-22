namespace StatePattern;

class Program
{
    static void Main(string[] args)
    {
        var canvas = new Canvas
        {
            CurrentTool = new SelectionTool()
        };

        canvas.MouseDown();
        canvas.MouseUp();
    }
}
