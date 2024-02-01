namespace StrategyPattern;

class Program
{
    static void Main(string[] args)
    {
        var jpegCompressor = new JpegCompressor();
        var pngCompressor = new PngCompressor();
        var blackAndWhiteFilter = new BlackAndWhiteFilter();

        ImageStorage imgStorage = new();
        imgStorage.Store("new-image", jpegCompressor, blackAndWhiteFilter);
        imgStorage.Store("new-image", pngCompressor, blackAndWhiteFilter);
    }
}
