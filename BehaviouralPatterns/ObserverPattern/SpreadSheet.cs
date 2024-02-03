namespace ObserverPattern;

public class SpreadSheet : IObserver
{
    public void Update()
    {
        System.Console.WriteLine("SpreadSheet got notified.");
    }
}
