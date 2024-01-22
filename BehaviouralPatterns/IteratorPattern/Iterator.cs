namespace IteratorPattern;

public interface Iterator<T>
{
    bool HasNext();
    T CurrentValue();
    void Next();
}
