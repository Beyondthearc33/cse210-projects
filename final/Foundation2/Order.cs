public class Order
{
       private List<Product> products { get; set; } = new List<Product>();
    public Customer customer { set; get; }

    public Order(Customer newCustomer)
    {
        customer = newCustomer;
    }
    public void addProduct(Product product)
    {
        products.Add(product);
    }
    public int totalPrice()
    {
        int totalPrice = 0;
        foreach(Product product in products)
        {
            totalPrice += product.totalCost();
        }
        if (customer.address.isAddressInUSA())
        {
            totalPrice += 5;
        } else
        {
            totalPrice += 35;
        }
        return totalPrice;
    }
    public void packingLabel()
    {
        Console.WriteLine("Packing Label:");
        foreach (Product product in products)
        {
        Console.WriteLine($"    {product._name}..........ID: {product._productId}");
        }
    }
    public void shippingLabel()
    {
        Console.WriteLine("Shipping Label:");
        Console.WriteLine("    " + customer._name);
        Console.WriteLine("    " + customer.address.displayAddress());
    }

    // To display each product, use the foreach like above.

}