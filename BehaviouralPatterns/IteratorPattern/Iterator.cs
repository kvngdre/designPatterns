namespace ITeratorPattern;

public interface ITerator<T>
{
    bool HasNext();
    T CurrentValue();
    void Next();
}
