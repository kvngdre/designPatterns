namespace StrategyPattern;

class Program
{
    static void Main(string[] args)
    {
        var jpegCompressor = new JpegCompressor();
        var blackAndWhiteFilter = new BlackAndWhiteFilter();

        ImageStorage imgStorage = new(jpegCompressor, blackAndWhiteFilter);
        imgStorage.Store("new-image");
    }
}
