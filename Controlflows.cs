namespace Samplecsharp;
class Contorlflowslogis{

    public void Show(){
         int a=10, b=20; //Arithmetic
         Console.WriteLine($"Add two number: {a+b}");
         Console.WriteLine($"Sub two number {a-b}");
         Console.WriteLine($"Multiply two number {a*b}");
         Console.WriteLine($"Division {b/a}");
         Console.WriteLine($"Module {a%b}");
        
        int x = 5; //Increment and decrement
        Console.WriteLine($"Prefix {x++}"); 
        Console.WriteLine($"Postfix {++x}");
        x--;
        Console.WriteLine($"Postfix -- {x}");
        Console.WriteLine($"Prefix -- {--x}"); 
         
         //Comparison
        Console.WriteLine($"compare with == {a==b}");
        Console.WriteLine($"Compare a!=b {a!=b}");
        Console.WriteLine($"a is less than b {a<b}");
        Console.WriteLine($"a is greater than b {a>b}");
        //Logical
        Console.WriteLine($"check with && {a==10 && b==20}");
        Console.WriteLine($"checking with or || {a==10 || b==18}");
        Console.WriteLine($"checking  with ! {!true}");

        //Ternary: a one-line if/else
        string result = a >= b ? "higher" : "lower";  
        Console.WriteLine($"checking  with ternary  {result}");

        
        string? name =null; //null operators 
        Console.WriteLine($"checking  with ternary  {name??"pradeep"}"); //assign the values if the name is null
        if (name?.Length > 0) //check the ?. if it not null it will execute or execute else
        {
         Console.WriteLine("Not enter if");
        }
        else
        {
            Console.WriteLine("Enter else");
            name??="Guest"; //assign the values is empty 
             Console.WriteLine($"checking  with ternary  {name??="pradeep"}"); 
        }

        //Type casting using convert
       Console.WriteLine("Type casting with Convert class ");
       int n1 = Convert.ToInt32("123");      // 123
       Console.WriteLine($"String to number {n1}");
       int n2 = Convert.ToInt32(99.6);       // 100 (rounds; a cast would truncate)
       Console.WriteLine($"round off  to number {n2}");
       double d1 = Convert.ToDouble("12.5"); // 12.5
       Console.WriteLine($"String to  double {d1}");
       bool b1 = Convert.ToBoolean("true");  // true
       Console.WriteLine($"String to  boolen {b1}");
       string s1 = Convert.ToString(456);    // "456"
       Console.WriteLine($"number to  string {s1}");
       
       int number;
       Console.Write("Enter a number: ");
       while (!int.TryParse(Console.ReadLine(), out number))
       {
        Console.Write("Invalid. Enter a number: ");
        }
       Console.WriteLine($"You entered {number}");
       
      Console.WriteLine(); 
   
        for (int i = 1; i <= 5; i++)
        {
            Console.Write(i + " normal for lop  "); 
            Console.WriteLine();     // 1 2 3 4 5
        }
        Console.WriteLine(); 
        string[] students = { "Pradeep", "Anita", "Rahul" };
        foreach (string s in students)
        {
            Console.WriteLine($" for each loop {s} ");
            Console.WriteLine(); 
        }
         Console.WriteLine(); 
        int count = 1;
        while (count <= 3)
        {
            Console.WriteLine($"do Count {count}");
                  Console.WriteLine(); 
            count++;
        }
        
        Console.WriteLine(); 
        int rows = 5;
        
        for (int i = 1; i <= rows; i++)        
        {
            for (int j = 1; j <= i; j++)       
            {
                Console.Write("* ");
            }
            Console.WriteLine();   
        }
        Console.WriteLine(); 

       for (int i = 1; i <= rows; i++)
        {
         for (int s = 1; s <= rows - i; s++)
         Console.Write(" ");
         for (int j = 1; j <= i; j++)
         Console.Write("* ");
         for (int j = i - 1; j >= 1; j--)
         Console.Write(" ");
         Console.WriteLine();
        }
       





         


        
    }
    
}