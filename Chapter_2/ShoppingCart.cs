using System.Collections.Generic;

namespace Chapter_2;

public class ShoppingCart
{
    public List<Product> Products { get; set; }

    public ShoppingCart()
    {
        Products = [];
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }
}
