namespace StrategyPattern;

public class BlackAndWhiteFilter : IFilter
{
    public void Apply(string fileName)
    {
        System.Console.WriteLine("Applying Black and White filter to image.");
    }
}
