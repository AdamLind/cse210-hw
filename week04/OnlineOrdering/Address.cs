public class Address
{
    string _streetAddress;
    string _city;
    string _stateProvince;
    string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateProvince = state;
        _country = country;
    }

    public bool InUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}, {_city}\n{_stateProvince}, {_country}";
    }

    public string GetCountry()
    {
        return _country;
    }
}