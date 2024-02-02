namespace CommandPattern;

public class AddCustomerCommand : ICommand
{
    private readonly CustomerService _service;

    public AddCustomerCommand(CustomerService service)
    {
        _service = service;
    }

    public void execute()
    {
        _service.AddCustomer();
    }
}
