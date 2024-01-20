
using MementoPattern.Exercise;

namespace MementoPattern;

class Program
{
    static void Main(string[] args)
    {
        Run();

        ExerciseMain.Run();
    }

    static void Run()
    {
        var editor = new Editor();
        var history = new History();

        editor.Content = "John";
        history.Add(editor.CreateState());

        editor.Content = "Kennedy";
        history.Add(editor.CreateState());

        editor.Content = "Kalu";

        System.Console.WriteLine("Editor content before restore(undo): " + editor.Content);

        editor.Restore(history.Pop());
        System.Console.WriteLine("Editor content after 1 restore(undo): " + editor.Content);

    }
}
