public class Customer
{
    public string _name { get; private set;}
    public Customer(string name)
    {
        _name = name;
    }
    public Address address { get; set; }

    
}