public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    //************
    //CONSTRUCTORS
    //************
    public Address()
    {
        _street = "";
        _city = "";
        _state = "";
        _country = "";
    }
    public Address(string street)
    {
        _street = street;
        _city = "";
        _state = "";
        _country = "";
    }
    public Address(string street, string city)
    {
        _street = street;
        _city = city;
        _state = "";
        _country = "";
    }
    public Address(string street, string city, string state)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = "";
    }
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    //************
    //SETTERS
    //************

    //************
    //GETTERS
    //************
    public string GetAddress()
    {
        return $"{_street},\n{_city}, {_state},\n{_country}";
    }

    //************
    //METHODS
    //************
    public int IsUsaCountry()
    {
        if (_country == "USA") { return 1; }
        else { return 0; }
    }
}