namespace ObserverPattern;

public class Chart : IObserver
{
    public void Update()
    {
        System.Console.WriteLine("Chart got notified.");
    }
}
