namespace StrategyPattern;

public class HighContrastFilter : IFilter
{
    public void Apply(string fileName)
    {
        System.Console.WriteLine("Applying high contrast filter to image.");
    }
}
