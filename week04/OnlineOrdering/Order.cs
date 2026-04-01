using System;

public class Order
{
    List<Product> _products;
    Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public void InCart(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.GetSubtotal();
        }
        
        if (_customer.IsAmerican())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }
        
        return totalPrice;
    }

    public List<string> GetPackingLabels()
    {
        List<string> packingLabels = new List<string>();
        foreach (Product product in _products)
        {
            packingLabels.Add(product.GetPacking());
        }
        return packingLabels;
    }

    public string GetShippingLabel()
    {
        return _customer.GetShippingLabel();
    }
    
}