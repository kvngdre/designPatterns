using CommandPattern.WithHistory;

namespace CommandPattern;

class Program
{
    static void Main(string[] args)
    {
        // var customerService = new CustomerService();
        // var command = new AddCustomerCommand(customerService);
        // var button = new Button(command);

        // button.Click();

        Editor.Run();
    }
}
