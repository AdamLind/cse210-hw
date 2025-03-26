public class Customer
{
    string _name;
    Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public string GetName()
    {
        return _name;
    }

    public bool InUSA()
    {
        if (_address.GetCountry() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}