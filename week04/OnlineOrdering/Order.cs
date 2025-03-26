using System.Globalization;

public class Order
{
    Customer _customer;
    List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    private double CalculateTotalCost()
    {
        double cost = 0;
        foreach (Product p in _products)
        {
            cost += p.CalculateTotalPrice();
        }
        return cost;
    }

    public void PrintPackingLabel()
    {
        Console.WriteLine($"___________Order for {_customer.GetName()}___________");
        Console.WriteLine("Items Ordered:");
        int i = 1;
        foreach (Product p in _products)
        {
            Console.WriteLine($"{i}. {p.GetQuantity()}x {p.GetName()}, Price: ${p.GetPrice()}, ID: {p.GetId()}");
            i++;
        }
        Console.WriteLine($"Subtotal: {CalculateTotalCost().ToString("C", CultureInfo.CurrentCulture)}\n");
    }

    public void PrintShippingLabel()
    {
        int shippingCost;

        Console.WriteLine("Shipping to:");
        Console.WriteLine($"{_customer.GetAddress().GetFullAddress()}");

        if (_customer.InUSA() == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        Console.WriteLine($"Shipping cost: ${shippingCost}\n");
        Console.WriteLine($"Grand Total: {(CalculateTotalCost() + shippingCost).ToString("C", CultureInfo.CurrentCulture)}\n");
    }

}