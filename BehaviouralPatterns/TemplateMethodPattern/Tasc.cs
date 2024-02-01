namespace TemplateMethodPattern;

public abstract class Tasc
{
    private readonly AuditTrail auditTrail;

    public Tasc()
    {
        this.auditTrail = new AuditTrail();
    }

    public Tasc(AuditTrail auditTrail)
    {
        this.auditTrail = auditTrail;
    }

    public void Execute()
    {
        this.auditTrail.Record();
        ReadInput();
        DoTask();
        SignalTaskCompletion();
    }

    protected abstract void ReadInput();

    protected abstract void DoTask();

    protected virtual void SignalTaskCompletion()
    {
        System.Console.WriteLine("Task is done!");
    }
}
