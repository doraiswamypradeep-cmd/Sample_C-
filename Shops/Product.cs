namespace Samplecsharp.Shops;
public class Product
{
    public string Name;
    public int Price;
    public int Qty;

    public Product(string name, int price, int qty)
    {
        Name = name;
        Price = price;
        Qty = qty;
    }

    public int Total()
    {
        return Price * Qty;
    }

    public void Print()
    {
        Console.WriteLine($"{Name} x {Qty} = Rs.{Total()}");
    }
}