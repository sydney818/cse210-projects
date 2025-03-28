


public class Customer
{
    private string Name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.Name = name;
        this.Address = address;
    }

    public string GetCustomerName()
    {
        return name; 
    }

    public string GetAddress()
    {
        return address.GetFullAddress();
    }
}