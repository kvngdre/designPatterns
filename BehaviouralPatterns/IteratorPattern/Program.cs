namespace ITeratorPattern;

class Program
{
    static void Main(string[] args)
    {
        var browseHistory = new BrowseHistory();
        browseHistory.Push("a");
        browseHistory.Push("b");
        browseHistory.Push("c");
        browseHistory.Push("d");
        browseHistory.Push("e");

        var iterator = browseHistory.CreateIterator();

        while (iterator.HasNext())
        {
            var current = iterator.CurrentValue();

            System.Console.WriteLine(current);

            iterator.Next();
        }
    }
}
