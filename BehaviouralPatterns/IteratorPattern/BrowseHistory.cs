namespace ITeratorPattern;

public class BrowseHistory
{
    private readonly List<string> _urls = [];

    public void Push(string url)
    {
        _urls.Add(url);
    }

    public string Pop()
    {
        var lastIndex = _urls.Count - 1;
        var lastUrl = _urls[lastIndex];
        _urls.Remove(lastUrl);

        return lastUrl;
    }

    public ITerator<string> CreateIterator()
    {
        return new ListIterator(this);
    }

    class ListIterator : ITerator<string>
    {
        private readonly BrowseHistory _history;
        private int Index;

        public ListIterator(BrowseHistory history)
        {
            _history = history;
        }

        public string CurrentValue()
        {
            return _history._urls[Index];
        }

        public bool HasNext()
        {
            return Index < _history._urls.Count;
        }

        public void Next()
        {
            Index++;
        }
    }
}
