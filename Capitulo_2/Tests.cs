using NUnit.Framework;

namespace Chapter_2;

[TestFixture]
public class Tests
{
    [Test]
    public void DescendingOrder()
    {
        ShoppingCart cart = new();
        cart.AddProduct(new Product("Refrigerator", 450.0));
        cart.AddProduct(new Product("Blender", 250.0));
        cart.AddProduct(new Product("Dish Set", 70.0));

        MaxAndMin algorithm = new();
        algorithm.Find(cart);

        Assert.That(algorithm.Min.Name, Is.EqualTo("Dish Set"));
        Assert.That(algorithm.Max.Name, Is.EqualTo("Refrigerator"));
    }

    [Test]
    public void OnlyOneProduct()
    {
        ShoppingCart cart = new();
        cart.AddProduct(new Product("Refrigerator", 450.0));

        MaxAndMin algorithm = new();
        algorithm.Find(cart);

        Assert.That(algorithm.Min.Name, Is.EqualTo("Refrigerator"));
        Assert.That(algorithm.Max.Name, Is.EqualTo("Refrigerator"));
    }
}
