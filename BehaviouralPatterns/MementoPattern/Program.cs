namespace MementoPattern;

class Program
{
    static void Main(string[] args)
    {
        var editor = new Editor();
        editor.Content = "John";
        editor.Content = "Kennedy";
        editor.Content = "Kalu";

        editor.Undo();

        System.Console.WriteLine(editor.Content);
    }
}
