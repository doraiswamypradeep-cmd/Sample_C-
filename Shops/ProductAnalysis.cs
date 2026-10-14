namespace Samplecsharp.Shops;

public class ProductAnalysis
{
    private readonly List<Product> products = new()
    {
        new Product("Laptop", 55000, 2),
        new Product("Mouse", 499, 10),
        new Product("Pen", 10, 50),
        new Product("Notebook", 60, 20),
        new Product("Chair", 4500, 0),
    };

    public void Show()
    {
        Console.WriteLine("=== Products ===");
        foreach (var p in products)
        {
            p.Print();
        }

        Console.WriteLine();
        Console.WriteLine("=== Analysis ===");
        Console.WriteLine($"Total products: {products.Count}");
        Console.WriteLine($"Total quantity: {products.Sum(p => p.Qty)}");
        Console.WriteLine($"Grand total:    Rs.{products.Sum(p => p.Total())}");
        Console.WriteLine($"Average price:  Rs.{products.Average(p => p.Price):F2}");
    }
}
