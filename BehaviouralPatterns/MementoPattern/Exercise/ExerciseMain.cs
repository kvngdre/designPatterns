using MementoPattern.Exercise.Solution;

namespace MementoPattern.Exercise;

public static class ExerciseMain
{
    public static void Run()
    {
        var caretaker = new Caretaker();
        var document = new Document
        {
            Content = "Hello",
            FontName = "Roboto",
            FontSize = 12
        };
        caretaker.Add(document.Save());

        document.Content += " World";
        document.FontName = "Lora";
        document.FontSize = 15;

        caretaker.Add(document.Save());

        document.Content += ", I am Kennedy";
        document.FontName = "Arial";
        document.FontSize = 10;

        System.Console.WriteLine("Exercise content before restore(undo): " + document.Content);
        System.Console.WriteLine("Exercise font name before restore(undo): " + document.FontName);

        document.Restore(caretaker.Pop());
        System.Console.WriteLine("---------------------------------------");


        System.Console.WriteLine("Exercise content after 1 restore(undo): " + document.Content);
        System.Console.WriteLine("Exercise font name after 1 restore(undo): " + document.FontName);
    }
}
