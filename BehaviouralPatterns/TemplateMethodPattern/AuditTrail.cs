namespace TemplateMethodPattern;

public class AuditTrail
{
    public DateTime CreatedAt { get; } = DateTime.Now;
    public void Record()
    {
        System.Console.WriteLine("Recording audit...");
    }
}
