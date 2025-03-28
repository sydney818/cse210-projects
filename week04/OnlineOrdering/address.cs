using System.Data;
using System.Net.Sockets;

public class Product
{
    private string Street;
    private string City;
    private string State;
    private string Country;

    public Address(string Street, string City, string State)
    {
        this.Street = street;
        this.City = city;
        this.State = State;
    }

    public string GetFullAddress()
    {
        return $"{street}\n{city}, {state}";
    }
}