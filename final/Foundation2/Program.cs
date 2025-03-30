using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        Product tomato = new Product("Tomato", 1, 3, 2);
        Product ham = new Product("Ham", 2, 15, 1);
        Product soda = new Product("Soda", 3, 5, 10);
        Product orange = new Product("Orange", 4, 1, 12);
        Product salad = new Product("Salad", 5, 8, 1);
        Product grapes = new Product("Grapes", 6, 5, 2);

        Customer customerOne = new Customer("Joe Shmoe");
        customerOne.address = new Address("3388 W Pond Dr", "Lehi", "Utah", "USA");

        Order customerOneOrder = new Order(customerOne);
        customerOneOrder.addProduct(tomato);
        customerOneOrder.addProduct(ham);
        customerOneOrder.addProduct(soda);

        customerOneOrder.packingLabel();
        customerOneOrder.shippingLabel();
        Console.WriteLine("Total Cost: $" + customerOneOrder.totalPrice());
        

        Console.WriteLine("\n");
        Customer customerTwo = new Customer("Kristina Smith");
        customerTwo.address = new Address("4108 W Pond Dr", "Stanik", "Dublin", "Europe");

        Order customerTwoOrder = new Order(customerTwo);
        customerTwoOrder.addProduct(orange);
        customerTwoOrder.addProduct(salad);
        customerTwoOrder.addProduct(grapes);

        customerTwoOrder.packingLabel();
        customerTwoOrder.shippingLabel();
        Console.WriteLine("Total Cost: $" + customerTwoOrder.totalPrice());

        // Console.WriteLine(customerOne.address.displayAddress());
    }
}