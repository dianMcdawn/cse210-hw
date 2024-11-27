public class Order
{
    private Customer _customer = new Customer();
    private List<Product> _products = new List<Product>();

    //************
    //CONSTRUCTORS
    //************
    public Order(string name)
    {
        SetCustomer(name);
    }
    public Order(string name, string street, string city, string state, string country)
    {
        SetCustomer(name);
        SetCustomerAddress(street, city, state, country);
    }

    //************
    //SETTERS
    //************
    public void SetCustomer(string name)
    {
        _customer = new Customer(name);
    }
    public void SetCustomerAddress(string street, string city, string state, string country)
    {
        _customer.SetAddress(street, city, state, country);
    }
    public void SetNewProduct(string name, string id, double price, int quantity)
    {
        Product newProduct = new Product(name, id, price, quantity);
        _products.Add(newProduct);
    }

    //************
    //GETTERS
    //************
    private double GetTotalOfProducts()
    {
        double total = 0;
        int shipping = 0;
        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }

        if (_customer.IsUsaCountry() == 1) { shipping = 5; }
        else { shipping = 35; }

        total += shipping;

        return total;
    }

    //************
    //METHODS
    //************
    public string PackingLabel()
    {
        string packingLabel = "";
        packingLabel += $"ITEM             QTY         PRICE       SUBTOTAL\n";
        packingLabel += $"-------------------------------------------------\n";
        foreach (Product product in _products)
        {
            packingLabel += $"${product.DisplayProductLine()}\n";
        }
        packingLabel += $"-------------------------------------------------\n";
        packingLabel += $"{GetTotalOfProducts().ToString().PadLeft(48)}\n";
        packingLabel += $"-------------------------------------------------\n";

        return packingLabel;
    }
    public string ShippingLabel()
    {
        string shippingLabel = "";
        shippingLabel += $"SHIPPED TO\n";
        shippingLabel += $"{_customer.GetShippingData()}";
        return shippingLabel;
    }

}