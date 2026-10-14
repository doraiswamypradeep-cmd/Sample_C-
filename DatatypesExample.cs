namespace Samplecsharp;
class Datatypes{
    public void Show()
    {
        int number = 10;
        Console.WriteLine("Interger number"+number);
        bool isCSharpEasy = true;
        Console.WriteLine("Is C# Easy? " + isCSharpEasy);
        float pi = 3.14f;
        float gravity = 9.81f;
        Console.WriteLine("Pi:float " + pi);
        Console.WriteLine("Gravity:float " + gravity);
        double pinew = 3.141592653589793;
        double gravitynew = 9.80665;
        Console.WriteLine("Pi:double " + pinew);
        Console.WriteLine("Gravity: double " + gravitynew);
        decimal price = 999.99m;
        decimal tax = 18.50m;
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Tax: " + tax);
        char grade = 'A';
        char symbol = '$';
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Symbol: " + symbol);
        string name = "Geeks";
        string message = "Welcome to C#";
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Message: " + message);
        object numberobj = 100;
        object messageobj = "Hello C#";

        Console.WriteLine("Number:obj " + numberobj);
        Console.WriteLine("Message:obj " + messageobj);
    }
}