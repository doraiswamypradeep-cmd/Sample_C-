using Samplecsharp;
using Samplecsharp.Shops;

Console.WriteLine("Hello, World!");

Console.WriteLine();
Console.WriteLine("Main Method ");
Console.WriteLine();

var emp = new Employee { Id = 1, Name = "HSUser1" };
 Console.WriteLine(emp.Greet());
Console.WriteLine();

Console.WriteLine("Data Types ");
Console.WriteLine();

var datatypes= new Datatypes();
datatypes.Show();

Console.WriteLine();
Console.WriteLine("Top level Statments ");
Console.WriteLine();

var analysis = new ProductAnalysis();
analysis.Show();
