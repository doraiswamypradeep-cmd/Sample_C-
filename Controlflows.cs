namespace Samplecsharp;
class Contorlflowslogis{

    public void Show(){
         int a=10, b=20;
         Console.WriteLine($"Add two number: {a+b}");
         Console.WriteLine($"Sub two number {a-b}");
         Console.WriteLine($"Multiply two number {a*b}");
         Console.WriteLine($"Division {b/a}");
         Console.WriteLine($"Module {a%b}");
        
        int x = 5;
        Console.WriteLine($"Prefix {x++}"); 
        Console.WriteLine($"Postfix {++x}");
        x--;
        Console.WriteLine($"Postfix -- {x}");
        Console.WriteLine($"Prefix -- {--x}"); 
         
        Console.WriteLine($"compare with == {a==b}");
        Console.WriteLine($"Compare a!=b {a!=b}");
        Console.WriteLine($"a is less than b {a<b}");
        Console.WriteLine($"a is greater than b {a>b}");

        Console.WriteLine($"check with && {a==10 && b==20}");
        Console.WriteLine($"checking with or || {a==10 || b==18}");
        Console.WriteLine($"checking  with ! {!true}");

        string result = a >= b ? "higher" : "lower";  
        Console.WriteLine($"checking  with ternary  {result}");
   
        



         


        
    }
    
}