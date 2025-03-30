public class Product
{
    public string _name { get; private set; }
    public int _productId { get; private set; }
    private int _pricePerUnit {get; set; }
    private int _quantity { get; set; }

    public Product(string name, int productId, int pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }
    public int totalCost()
    {
      return  _pricePerUnit * _quantity;
    }
}