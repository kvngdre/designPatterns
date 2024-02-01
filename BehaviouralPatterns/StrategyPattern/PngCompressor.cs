namespace StrategyPattern;

public class PngCompressor : ICompressor
{
    public void Compress(string fileName)
    {
        System.Console.WriteLine("Compressing image using PNG"); ;
    }
}
