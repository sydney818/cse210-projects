using System.Data;
using System.Net.Sockets;

public class Address
{
    private string street;
    private string city;
    private string state;

    public Address(string street, string city, string state)
    {
        this.street = street;
        this.city = city;
        this.state = state;
    }

    public string GetFullAddress()
    {
        return $"{street}\n{city}, {state}";
    }
}