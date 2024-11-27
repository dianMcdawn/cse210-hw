public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    //************
    //CONSTRUCTORS
    //************
    public Product()
    {
        _name = "";
        _id = "";
        _price = 0;
        _quantity = 0;
    }
    public Product(string name)
    {
        _name = name;
        _id = "";
        _price = 0;
        _quantity = 0;
    }
    public Product(string name, string id)
    {
        _name = name;
        _id = id;
        _price = 0;
        _quantity = 0;
    }
    public Product(string name, string id, double price)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = 0;
    }
    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    //************
    //SETTERS
    //************

    //************
    //GETTERS
    //************

    //************
    //METHODS
    //************
    public double TotalCost()
    {
        double total = (double)_price * _quantity;
        return total;
    }
    public string DisplayProductLine()
    {
        return $"{_id.PadRight(15)} {_quantity.ToString().PadRight(11)} ${_price.ToString().PadRight(10)} ${TotalCost()}\n{_name.PadRight(30)}";
    }
}