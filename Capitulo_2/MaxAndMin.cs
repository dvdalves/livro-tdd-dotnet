namespace Chapter_2;

public class MaxAndMin
{
    public Product Min { get; set; }
    public Product Max { get; set; }

    public void Find(ShoppingCart cart)
    {
        foreach (Product product in cart.Products)
        {
            if (Min == null || product.Price < Min.Price)
                Min = product;

            if (Max == null || product.Price > Max.Price)
                Max = product;
        }
    }
}
