namespace MementoPattern;

class Program
{
    static void Main(string[] args)
    {
        var editor = new Editor();
        var history = new History();

        editor.Content = "John";
        history.Add(editor.CreateState());

        editor.Content = "Kennedy";
        history.Add(editor.CreateState());

        editor.Content = "Kalu";

        System.Console.WriteLine(editor.Content);

        editor.Restore(history.Pop());
        System.Console.WriteLine(editor.Content);

        editor.Restore(history.Pop());
        System.Console.WriteLine(editor.Content);
    }
}
