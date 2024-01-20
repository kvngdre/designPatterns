using MementoPattern.Exercise.Solution;

namespace MementoPattern.Exercise;

public static class ExerciseMain
{
    public static void Run()
    {
        var document = new Document
        {
            Content = "Hello",
            FontName = "Roboto",
            FontSize = 12
        };

        System.Console.WriteLine(document.FontName);
    }
}
