public class Customer
{
    private string _name;
    private Address _address = new Address();

    //************
    //CONSTRUCTORS
    //************
    public Customer()
    {
        _name = "";
    }
    public Customer(string name)
    {
        _name = name;
    }
    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        SetAddress(street, city, state, country);
    }
    //************
    //SETTERS
    //************
    public void SetAddress(string street, string city, string state, string country)
    {
        _address = new Address(street, city, state, country);
    }

    //************
    //GETTERS
    //************
    public string GetShippingData()
    {
        return $"{_name} \n{_address.GetAddress()}";
    }

    //************
    //METHODS
    //************
    public int IsUsaCountry()
    {
        if (_address.IsUsaCountry() == 1) { return 1; }
        else { return 0; }
    }
}