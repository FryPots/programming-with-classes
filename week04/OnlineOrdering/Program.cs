using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        
        Customer david = new Customer("David", new Address("123 Main St", "Anytown", "CA", "USA"));
        Order davidOrder = new Order(david);
        davidOrder.InCart(new Product("Laptop", "P001", 999.99, 1));
        davidOrder.InCart(new Product("USB", "P002", 25.99, 2));

        Customer emily = new Customer("Emily", new Address("456 Elm St", "Othertown", "ON", "Canada"));
        Order emilyOrder = new Order(emily);
        emilyOrder.InCart(new Product("Smartphone", "P003", 499.99, 1));
        emilyOrder.InCart(new Product("Headphones", "P004", 89.99, 1));
        emilyOrder.InCart(new Product("Charger", "P005", 19.99, 3));
    
        Console.WriteLine($"David's Order Total: ${davidOrder.GetTotalPrice():0.00}");
        Console.WriteLine($"David's Shipping Label: {davidOrder.GetShippingLabel()}");
        Console.WriteLine($"David's Order: {string.Join(", ", davidOrder.GetPackingLabels())}");

        Console.WriteLine();

        Console.WriteLine($"Emily's Order Total: ${emilyOrder.GetTotalPrice():0.00}");
        Console.WriteLine($"Emily's Shipping Label: {emilyOrder.GetShippingLabel()}");
        Console.WriteLine($"Emily's Order Items: {string.Join(", ", emilyOrder.GetPackingLabels())}");

    }
}