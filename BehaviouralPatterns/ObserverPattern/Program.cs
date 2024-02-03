namespace ObserverPattern;

class Program
{
    static void Main(string[] args)
    {
        var dataSource = new DataSource();
        var sheet1 = new SpreadSheet();
        var sheet2 = new SpreadSheet();
        var chart = new Chart();

        dataSource.Attach(sheet1);
        dataSource.Attach(sheet2);
        dataSource.Attach(chart);

        dataSource.Value = 10;
    }
}
