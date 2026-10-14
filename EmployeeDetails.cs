namespace Samplecsharp;
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = "";

    public string Greet()
    {
        return $"Hello, {Name}!";
    
    }
}