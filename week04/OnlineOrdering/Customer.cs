using System;

public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsAmerican()
    {
        return _address.IsAmerica();
    }

    public string GetShippingLabel()
    {
        return $"{_name} | {_address.GetFullAddress()}";
    }
}