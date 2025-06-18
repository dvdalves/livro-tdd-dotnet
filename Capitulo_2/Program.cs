using System;

namespace Chapter_2;

internal class Program
{
    static void Main(string[] args)
    {
        ShoppingCart shoppingCart = new();
        shoppingCart.AddProduct(new Product("Blender", 250.0));
        shoppingCart.AddProduct(new Product("Refrigerator", 450.0));
        shoppingCart.AddProduct(new Product("Dish Set", 70.0));

        MaxAndMin maxMinFinder = new();
        maxMinFinder.Find(shoppingCart);

        Console.WriteLine("The cheapest product: " + maxMinFinder.Min.Name);
        Console.WriteLine("The most expensive product: " + maxMinFinder.Max.Name);
    }
}