namespace StrategyPattern;

public class JpegCompressor : ICompressor
{
    public void Compress(string fileName)
    {
        System.Console.WriteLine("Compressing image using JPEG");
    }
}
